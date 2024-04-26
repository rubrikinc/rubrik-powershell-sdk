using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Management.Automation;
using System.Management.Automation.Language;
using System.Reflection;
using System.Threading.Tasks;
using System.Xml.Linq;
using Newtonsoft.Json;
using RubrikSecurityCloud.NetSDK.Client;
using RubrikSecurityCloud.NetSDK.Client.Models.Authentication;
using RubrikSecurityCloud;
using RubrikSecurityCloud.Types;
using GraphQL;

// ignore warning 'Missing XML comment'
#pragma warning disable 1591

// until we use #nullable enable
#pragma warning disable CS8632

namespace RubrikSecurityCloud.PowerShell.Private
{


    /// <summary>
    /// Configuration for RscGqlPSCmdlet
    /// 
    /// HasPatchingDynamicParam:
    /// If true, add patching dynamic parameter to the cmdlet
    /// (-AddField and -RemoveField)
    /// 
    /// SendQueryOnExitIfAny:
    /// If true, send the query to the server when the cmdlet exits.
    /// If false, return the query object instead (if any).
    /// </summary>
    public class RscGqlPSCmdletConfig : RscDynParamPSCmdletConfig
    {
        public bool SendQueryOnExitIfAny { get; set; } = false;
    }
    /// <summary>
    /// Base class for all RSC PowerShell cmdlets that use a GraphQL query.
    /// </summary>
    [CmdletBinding()]
    public class RscGqlPSCmdlet : RscDynParamPSCmdlet
    {
        // Note : we are using HelpMessage tags
        // instead of <summary> tags because the xml doc generator
        // reads the <summary> tags from the derived classes
        // (e.g. New-RscQueryVsphere.cs) and ignores the base class
        // <summary> tags.

        [Parameter(
            Mandatory = false,
            // No Position -> named parameter only.
            ValueFromPipeline = true,
            HelpMessage = "Start off by copying another query before altering it with -Var, -AddField, -RemoveField and -FilePatch.",
            ValueFromPipelineByPropertyName = true)]
        public RscQuery Copy { get; set; }

        [Parameter(
            Mandatory = false,
            Position = 1,
            HelpMessage = "Operation variables. The set of variables to use depends on the operation. Call Info() on the object this cmdlet returns to see the variables for the operation. If -Var is not given, all variables are null. Specify the variable with a hash table, e.g. @{id = \"123\"}. The keys of the hash table are the variable names, and are case-insensitive. Simple types like ints and strings can be specified directly. The [RubrikSecurityCloud.Types] namespace contains a set of classes that you can use to specify complex types. You can use Get-RscType to create a new object of a given type.",
            ValueFromPipeline = true,
            ValueFromPipelineByPropertyName = true)]
        public object Var { get; set; }

        [Parameter(
            Mandatory = false,
            // No Position -> named parameter only.
            HelpMessage = "Fields to select for retrieval. Unlike -AddField and -RemoveField where fields are specified as dotted strings (e.g. 'nodes.id'), this parameter expects an object that contains the fields you want to select as properties. Any property that is not null in that object is interpreted as a field to select (and the actual values they are set to do not matter). The [RubrikSecurityCloud.Types] namespace contains a set of classes that you can use to specify fields. To know what [RubrikSecurityCloud.Types] object to use for a specific operation, call Info() on the object returned by this cmdlet. You can combine a -Field parameter with patching parameters. -Field is applied first, then -FilePatch, -AddField and -RemoveField.",
            ValueFromPipeline = true,
            ValueFromPipelineByPropertyName = true)]
        public object Field { get; set; }

        [Parameter(
            Mandatory = false,
            // No Position -> named parameter only.
            HelpMessage = "Patch the field specification with field names from a file. Each line in the file is a field name. If the line starts with a '-', the field is removed from the field spec. If the line does not start with a '-', the field is added to the field specification.",
            ValueFromPipeline = false)]
        public string[] FilePatch { get; set; }

        [Parameter(
            Mandatory = false,
            // No Position -> named parameter only.
            HelpMessage = "Field profile. Determines what fields should be selected for retrieval when no -Field object is given. If -FieldProfile is not given and -Field is not given either, the default profile is used.",
            ValueFromPipeline = false)]
        public Exploration.Profile FieldProfile { get; set; } = Exploration.Profile.UNSET;

        [Parameter(
            Mandatory = false,
            // No Position -> named parameter only.
            HelpMessage = "Introspection utility: if -ValidPatchSet is given, no query object is returned, but instead, the cmdlet outputs the 'valid patch set' (that is, what field names can be given to -AddField and -RemoveField).",
            ValueFromPipeline = false)]
        public SwitchParameter ValidPatchSet { get; set; }

        protected RscGqlPSCmdletConfig _config; // Class configuration

        protected string gqlRootField;

        internal RscQuery _query = null;

        /// <summary>
        /// Create a new RSC PowerShell cmdlet.
        /// </summary>
        public RscGqlPSCmdlet(
            RscGqlPSCmdletConfig? config = null) : base(config)
        {
            _config = config ?? new RscGqlPSCmdletConfig();

            // set static delegate on RscOp:
            RubrikSecurityCloud.RscOp.FillInRscOp =
                SchemaMeta.FillInRscOp;
            RubrikSecurityCloud.RscOp.GetRootFieldKind =
                SchemaMeta.GetRootFieldKind;
        }

        internal string _OpObjToString(object opObj)
        {
            if (opObj == null)
            {
                return null;
            }
            if (opObj is string sOp)
            {
                return sOp;
            }
            if (opObj is RscOp rscOp)
            {
                return rscOp.CmdletSwitchName;
            }
            if (opObj is RscQuery rscQuery)
            {
                return rscQuery.Op;
            }
            return null;
        }

        internal virtual string GetOperationParameter()
        {
            return this.GetStringDynParam("Operation");
        }

        internal virtual RscOp GetOp(bool unknownOk = false)
        {
            // Op can come from 2 sources
            string? opFromParam = this.GetOperationParameter();
            _logger?.Debug($"Operation from -Operation: {opFromParam}");
            string? opFromCopy = _OpObjToString(this.Copy?.Op);

            opFromParam = opFromParam?.Trim();
            opFromCopy = opFromCopy?.Trim();

            opFromParam = string.IsNullOrEmpty(opFromParam) ? null : opFromParam;
            opFromCopy = string.IsNullOrEmpty(opFromCopy) ? null : opFromCopy;

            // The -Copy parameter is applied first
            string op = opFromCopy;

            // The -Operation parameter is applied next
            if (op == null)
            {
                op = opFromParam;
            }
            else
            {
                _logger?.Debug($"Operation from -Copy: {op}");
            }

            // If no operation is specified, throw an exception
            if (op == null)
            {
                if (unknownOk)
                {
                    return RscOp.NullRscOp;
                }
                throw new Exception("No operation specified");
            }

            // If the operation is not recognized, throw an exception
            var opKey = this.ValidateOperation(op, unknownOk);
            if (string.IsNullOrEmpty(opKey))
            {
                return RscOp.NullRscOp;
            }

            // Return the operation
            string cmdletName = this.GetCmdletName();
            return (new RscOp(cmdletName, opKey)).Finalize();
        }

        // Return a list of valid values for -AddField and -RemoveField.
        // Needed by RscDynParamPSCmdlet parent class
        override protected List<string>? GetValidPatchSet()
        {
            RscOp rscOp = GetOp(unknownOk: true);
            string gqlReturnType = "";
            if (!rscOp.IsDetermined())
            {
                _logger.Debug("Could not determine operation");
                if (this.gqlRootField != null)
                {
                    gqlReturnType = SchemaMeta.ReturnTypeLookupByGqlRootField(this.gqlRootField);
                } else
                {
                    return null;
                }
            } else
            {
                gqlReturnType = rscOp.GqlReturnTypeName;
            }
            List<string>? validValues = null;
            try
            {
                validValues = RscPatchSet.BuildValidPatchStringsFor(
                    gqlReturnType);
                if (validValues.Count > 0)
                {
                    return validValues;
                }
            }
            catch (Exception ex)
            {
                _logger.Debug($"Error building valid patch strings for {rscOp.GqlReturnTypeName}: {ex.Message}");
            }
            return null;
        }



        protected override void ProcessRecord()
        {
            base.ProcessRecord();

            // Log operations dir that will be used:
            string opDir = GetOperationsDir();
            _logger.Debug($"op dir: {opDir} {Directory.Exists(opDir)}");
        }

        protected bool _passPatchesToExploration()
        {
            // Pass file patches to Exploration if any:
            if (this.FilePatch != null)
            {
                foreach (string patchFile in this.FilePatch)
                {
                    Exploration.PatchSet.ReadFromFile(patchFile);
                }
            }

            // Pass string patches to Exploration if any:
            try
            {
                string[] af = this.GetStringArrayDynParam("AddField");
                if (af != null && af.Length > 0)
                {
                    _logger.Debug($"AddField: {string.Join(",", af)}");
                }
                string[] rf = this.GetStringArrayDynParam("RemoveField");
                if (rf != null && rf.Length > 0)
                {
                    _logger.Debug($"RemoveField: {string.Join(",", rf)}");
                }
                Exploration.PatchSet.ReadFromArrays(af, rf);
            }
            catch (Exception ex)
            {
                _logger.Debug($"Error getting Patch parameters: {ex.Message}");
            }
            return Exploration.PatchSet.HasPatch();
        }

        protected object _makeFields(
            string opName,
            QueryFieldSpecMethod queryFieldSpecMethod)
        {
            Exploration.Init();

            // start off by copying field from other query.
            // Note that with PowerShell, passing `-Copy $q` 
            // passes $q by value,
            // so if we just did this.Field = this.Copy.Field
            // we would modify the object passed on the 
            // command line, which is not what we want.
            // Instead we serialize by getting the object's
            // flat list of selected fields,
            // and we deserialize by feeding it to Exploration
            // as patch strings.
            if (this.Copy != null && this.Copy.Field != null)
            {
                Exploration.PatchSet.ReadFieldSpecFromObject(this.Copy.Field);
                _logger?.Debug($"Copied field from passed -Copy.");
            }

            if (this.Field != null)
            {
                var f = this.Field;
                // If Field is a PSObject, unwrap it
                // (e.g. this happens when object is piped in)
                if (this.Field is PSObject psObject)
                {
                    f = psObject.BaseObject;
                }
                Exploration.PatchSet.ReadFieldSpecFromObject(f);
                _logger?.Debug($"Copied field from passed -Field.");
            }

            bool hasPatch = _passPatchesToExploration();
            Exploration.Profile fieldProf = this.FieldProfile;

            if (fieldProf == Exploration.Profile.UNSET)
            {
                fieldProf = Exploration.Profile.DEFAULT;
            }

            // if no patch is given, profile can't be empty:
            if (!hasPatch && fieldProf == Exploration.Profile.EMPTY)
            {
                fieldProf = Exploration.Profile.DEFAULT;
            }

            // read override patch file (if any) and apply it:
            if (fieldProf == Exploration.Profile.DEFAULT ||
                fieldProf == Exploration.Profile.DETAIL ||
                fieldProf == Exploration.Profile.CUSTOM)
            {
                string f = Path.Combine(
                    this.GetOperationsDir(), opName + ".patch");
                Exploration.PatchSet.ReadFromFile(patchFile: f, missingOk: true);
            }

            // run exploration
            ExplorationContext ec = new ExplorationContext();
            Exploration.GlobalProfile = fieldProf;
            return queryFieldSpecMethod(ec);
        }

        protected string GetOperationsDir()
        {
            _logger?.Debug("GetOperationsDir()");
            switch (this.FieldProfile)
            {
                case Exploration.Profile.CUSTOM:
                    return this.GetCustomDir();
                case Exploration.Profile.DETAIL:
                    return Files.GetSdkOperationsDir(Exploration.Profile.DETAIL.ToString());
                default:
                    return Files.GetSdkOperationsDir(Exploration.Profile.DEFAULT.ToString());
            }
        }

        protected RscGqlVars _makeVars(
            Func<object?, RscGqlVars> makeRscGqlVars = null)
        {
            object? fromCopy = (this.Copy != null && this.Copy.Var != null) ? this.Copy.Var : null;
            object? fromVar = this.Var;
            if (fromCopy == null && fromVar == null)
            {
                return makeRscGqlVars(null);
            }
            if (fromCopy != null && fromVar != null)
            {
                var vc = makeRscGqlVars(fromCopy);
                var vv = makeRscGqlVars(fromVar);
                vc.AddFromDictionary(vv as Dictionary<string, object>);
                return vc;
            }
            return makeRscGqlVars((fromVar != null) ? fromVar : fromCopy);
        }

        /// <summary>
        /// Initialize the query object.
        /// Initialize() is called by the cmdlet's ProcessRecord() method.
        /// </summary>
        /// <param name="opArgDefs">
        /// Operation argument definitions. e.g. { Tuple.Create("first",
        /// "Int"), Tuple.Create("sortOrder", "SortOrder") }
        /// </param>
        /// <param name="opKind">"query" or "mutation"</param>
        /// <param name="opName">e.g. "QueryClusterConnection"</param>
        /// <param name="opArgs">
        /// e.g. "($first: Int ,$sortOrder: SortOrder)"</param>
        /// <param name="opReturnType">e.g. "ClusterConnection"</param>
        /// <param name="queryDocMethod">
        /// Method that returns the query document as a string.
        /// It does not explore. It takes a field object as input,
        /// and returns the query document as a string.
        /// "query document": the text of the operation: 
        /// the operation name, the operation arguments,
        /// and the fields to select for retrieval. For example in
        /// the final query, it's all the text inside
        /// query QueryClusterConnection($first: Int ...) {
        ///         -- query document --
        /// }
        /// So it's: the query name, the query arguments, and 
        /// the field spec.
        /// </param>
        /// <param name="queryFieldSpecMethod">
        /// Method that builds the field object for this query
        /// using exploration. It takes for input an exploration context,
        /// and returns the field object.
        /// </param>
        /// <param name="varUsageExample">
        /// Example text of how to initialize the variables
        /// </param>
        protected void Initialize(
            Tuple<String, String>[] opArgDefs,
            string opKind,
            string opName,
            string opArgs,
            string opReturnType,
            QueryDocMethod queryDocMethod,
            QueryFieldSpecMethod queryFieldSpecMethod,
            string varUsageExample
        )
        {
            _logger?.Debug("Initialize()");
            var vars = _makeVars(o => new RscGqlVars(
                o,
                opArgDefs,
                this.GetValueFromParameterSet,
                // we don't check the variables here,
                // user may want to fill them in later.
                // variables are checked in Invoke-Rsc
                // when the query is actually sent
                ignoreRequired: true,
                varUsageExample)
            );

            object fields = _makeFields(opName, queryFieldSpecMethod);

            var gqlOp = new RscGqlOperation(
                opKind,
                opName,
                opArgs,
                opReturnType
            );
            _query = new RscQuery(
                this.GetOp(), vars, fields, gqlOp);
            _query.Init(
                _logger,
                this.GetOperationsDir(),
                this.GetCustomDir(),
                queryDocMethod,
                queryFieldSpecMethod);
        }

        protected override void EndProcessing()
        {
            _logger?.Debug("EndProcessing()");
            
            // If -ValidPatchSet is given,
            // output the valid patch set and exit.
            if (this.ValidPatchSet)
            {
                List<string>? validPatchSet = this.GetValidPatchSet();
                if (validPatchSet != null)
                {
                    this.WriteObject(validPatchSet);
                } else
                {
                    throw new Exception("Could not determine valid patch set"); 
                }
                return;
            }

            if (_config.SendQueryOnExitIfAny && _query != null)
            {
                RscGqlRequest gqlReq = _query.GqlRequest();
                if (gqlReq != null && _rbkClient != null)
                {
                    this.SendGqlRequest(gqlReq);
                }
            }
            else
            {
                if (_query != null)
                {
                    //InterfaceHelper.ConvertListsToRscInterfaces(_query.Field);
                    this.WriteObject(_query);
                }
            }

            base.EndProcessing();
        }
    }
}

