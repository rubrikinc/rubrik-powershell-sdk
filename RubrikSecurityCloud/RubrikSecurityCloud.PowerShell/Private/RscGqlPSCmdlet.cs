using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Management.Automation;
using System.Reflection;
using System.Threading.Tasks;
using System.Xml.Linq;
using Newtonsoft.Json;
using RubrikSecurityCloud.NetSDK.Client;
using RubrikSecurityCloud.NetSDK.Client.Models.Authentication;
using RubrikSecurityCloud;
using RubrikSecurityCloud.Types;
using GraphQL;

namespace RubrikSecurityCloud.PowerShell.Private
{
    /// <summary>
    /// Configuration for RscGqlPSCmdlet
    /// 
    /// HasPatchDynamicParam:
    /// If true, add a -Patch dynamic parameter to the cmdlet.
    /// 
    /// SendQueryOnExitIfAny:
    /// If true, send the query to the server when the cmdlet exits.
    /// If false, return the query object instead (if any).
    /// </summary>
    public class RscGqlPSCmdletConfig
    {
        public bool HasPatchDynamicParam { get; set; } = true;
        public bool SendQueryOnExitIfAny { get; set; } = false;

    }
    /// <summary>
    /// Base class for all RSC PowerShell cmdlets that use a GraphQL query.
    /// </summary>
    public class RscGqlPSCmdlet : RscBasePSCmdlet, IDynamicParameters
    {
        /// <summary>
        /// Start off by copying another query
        /// before altering it with 
        /// -Op -Var -Field -FilePatch -FieldProfile and -Patch.
        /// </summary>
        [Parameter(
            Mandatory = false,
            Position = 0,
            ValueFromPipeline = true,
            ValueFromPipelineByPropertyName = true)]
        public RscQuery Copy { get; set; }

        /// <summary>
        /// Operation to run. Overridden by operation switches.
        /// Only use -Op to programmatically pick the operation to run.
        /// Typically, you would use the operation switches instead.
        /// For example, `New-RscQueryCluster -List` is equivalent to
        /// `New-RscQueryCluster -Op List`. 
        /// </summary>
        [Parameter(
            Mandatory = false,
            // No Position -> named parameter only.
            ValueFromPipeline = true,
            ValueFromPipelineByPropertyName = true)]
        public string Op { get; set; }

        /// <summary>
        /// Operation variables.
        /// </summary>
        [Parameter(
            Mandatory = false,
            Position = 3,
            ValueFromPipeline = true,
            ValueFromPipelineByPropertyName = true)]
        public object Var { get; set; }

        /// <summary>
        /// An object that represents the fields that need to be returned
        /// for a given query. Each property on this object that does not
        /// have a null value (actual values don’t matter) will be included 
        /// in the API request.
        /// </summary>
        [Parameter(
            Mandatory = false,
            Position = 4,
            ValueFromPipeline = true,
            ValueFromPipelineByPropertyName = true)]
        public object Field { get; set; }

        /// <summary>
        ///  Patch the field spec with field names from a file
        /// </summary>
        [Parameter(
            Mandatory = false,
            // No Position -> named parameter only.
            ValueFromPipeline = false)]
        public string[] FilePatch { get; set; }

        /// <summary>
        /// The field profile determines how inputs to the operation
        /// should be automatically set if they are not explicitly given
        /// as parameters.
        /// </summary>
        [Parameter(
            Mandatory = false,
            // No Position -> named parameter only.
            ValueFromPipeline = false)]
        public Exploration.Profile FieldProfile { get; set; } = Exploration.Profile.UNSET;

        protected RscGqlPSCmdletConfig _config; // Class configuration

        internal RscQuery _query = null;

        protected RuntimeDefinedParameterDictionary _dynamicParameters;

        /// <summary>
        /// Create a new RSC PowerShell cmdlet.
        /// </summary>
        public RscGqlPSCmdlet(
            RscGqlPSCmdletConfig config = null)
        {
            _config = (config!=null) ? config : new RscGqlPSCmdletConfig();

            // set static delegates on RscOp:
            RubrikSecurityCloud.RscOp.GqlRootFieldLookup =
                SchemaMeta.StringGqlRootFieldNameLookupByRscOp;
            RubrikSecurityCloud.RscOp.ReturnTypeLookup =
                SchemaMeta.ReturnTypeLookupByGqlRootField;
        }

        internal virtual RscOp GetRscOp()
        {
            // Retrieve the Cmdlet attribute
            var cmdletAttribute = (CmdletAttribute)Attribute.GetCustomAttribute(this.GetType(), typeof(CmdletAttribute));

            if (cmdletAttribute == null)
            {
                return null;
            }
            string cmdletName = $"{cmdletAttribute.VerbName}-{cmdletAttribute.NounName}";

            string op = DetermineOp(unknownOk: true);
            if (string.IsNullOrEmpty(op))
            {
                return null;
            }

            return new RscOp(cmdletName, op);
        }

        internal virtual string DetermineOp(bool unknownOk = false)
        {
            // ~~~ BUG WORKAROUND ~~~
            //
            // There are occasional mismatches between the
            // ParameterSetName that PSCmdlet resolves to,
            // and the matching SwitchParameter. You can see it
            // if you breakpoint here in the debugger,
            // with the first implementation: this.Op = ParameterSetName;
            // and the following examples:
            //
            // PS> (New-RscQueryAzure -Subscriptions).GqlRequest().operationName
            // QueryAzureSqlDatabase
            // PS> (New-RscQueryCluster -IsTotpAckNecessary).GqlRequest().operationName
            // QueryClusterConnection
            //
            // Note: in New-RscQueryAzure.cs, we see:
            //      [Parameter(ParameterSetName = "Subscriptions",...)]
            //      public SwitchParameter Subscriptions { get; set; }
            //
            //this.Op = ParameterSetName;

            if (_switches == null || _switches.Count == 0)
            {
                BuildCmdletParametersReport();
            }
            if (_switches != null && _switches.Count > 0)
            {
                return _switches[0]; // fragile.
            }
            if (unknownOk)
            {
                return null;
            }
            throw new Exception("No operation specified");
        }


        public object GetDynamicParameters()
        {
            // Define the dynamic parameter set:
            _dynamicParameters = new RuntimeDefinedParameterDictionary();

            var rscOp = GetRscOp();

            // Define -Patch
            if (_config.HasPatchDynamicParam)
            {
                var patchAttributes = new Collection<Attribute>();
                patchAttributes.Add(new ParameterAttribute
                {
                    HelpMessage = "Add or remove fields in the response."
                });
                if (rscOp != null && rscOp.IsDetermined())
                {
                    try
                    {
                        List<string> validValues = RscPatchString.BuildValidPatchStringsFor(rscOp.GqlReturnTypeName, 5, new HashSet<string> { "Edges" });
                        if (validValues.Count > 0)
                        {
                            var attr = new ValidateSetAttribute(validValues.ToArray());
                            patchAttributes.Add(attr);
                        }
                    }
                    catch (Exception ex)
                    {
                        _logger.Debug($"Error building valid patch strings for {rscOp.GqlReturnTypeName}: {ex.Message}");
                    }
                }
                var patchParams = new RuntimeDefinedParameter("Patch", typeof(string[]), patchAttributes);

                // Add Patch to the set:
                _dynamicParameters.Add("Patch", patchParams);
            }

            return _dynamicParameters;
        }
        protected override void ProcessRecord()
        {
            base.ProcessRecord();

            // Log operations dir that will be used:
            string opDir = GetOperationsDir();
            _logger.Debug($"op dir: {opDir} {Directory.Exists(opDir)}");
            PreprocessInputs();
        }

        protected void PreprocessInputs()
        {
            // start off by copying another query:
            if (this.Copy != null)
            {
                this.Op = this.Copy.Op;
                this.Var = this.Copy.Var;
                this.Field = this.Copy.Field;
            }

            // If no OpSwitch is given, determine it at run-time:
            if (string.IsNullOrEmpty(this.Op))
            {
                this.Op = DetermineOp();
            }

            if (this.Field != null)
            {
                // If Field is a PSObject, unwrap it
                // (e.g. this happens when object is piped in)
                if (this.Field is PSObject psObject)
                {
                    this.Field = psObject.BaseObject;
                }
            }
            if (this.FieldProfile == Exploration.Profile.UNSET)
            {
                this.FieldProfile = Exploration.Profile.DEFAULT;
            }
            Exploration.Init(this.FieldProfile);
            if (this.Field != null)
            {
                // if Field is a string we assume a patch
                // (e.g. "nodes.snapshotcount, -nodes.name" )
                if (this.Field is string sField)
                {
                    Exploration.ReadPatchFromString(sField);
                    this.Field = null;
                }
            }

            // apply file patches if any:
            if (this.FilePatch != null)
            {
                foreach (string patchFile in this.FilePatch)
                {
                    Exploration.ReadPatchFromFile(patchFile);
                }
            }

            // apply string patches if any:
            string[] patches = null;
            try
            {
                patches = _dynamicParameters["Patch"].Value as string[];
            }
            catch (Exception ex)
            {
                _logger.Debug($"Error getting Patch parameter: {ex.Message}");
            }

            if (patches != null && patches.Length > 0)
            {
                _logger.Debug($"patches: {string.Join(",", patches)}");
                foreach (string patch in patches)
                {
                    Exploration.ReadPatchFromString(patch);
                }
            }
            else
            {
                _logger.Debug($"no patches");
            }

            // if no Field is given, and no patch is given,
            // profile can't be empty:
            if (this.Field == null && !Exploration.HasPatch() &&
            this.FieldProfile == Exploration.Profile.EMPTY)
            {
                this.FieldProfile = Exploration.Profile.DEFAULT;
                Exploration.GlobalProfile = Exploration.Profile.DEFAULT;
            }
        }
        protected string GetOperationsDir()
        {
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

        /// <summary>
        /// Initialize the inputs
        /// </summary>
        /// <param name="argDefs"></param>
        /// <param name="opKind">
        /// "query" or "mutation"
        /// </param>
        /// <param name="opName">
        /// name of operation, e.g. "QueryClusterConnection"
        /// </param>
        /// <param name="opArgs">
        /// e.g. "($first: Int,$after: String,$last: Int,$before: String,$filter: ClusterFilterInput,$sortOrder: SortOrder,$sortBy: ClusterSortByEnum)"
        /// </param>
        /// <param name="opReturnType">
        /// e.g. "ClusterConnection"
        /// </param>
        protected void Initialize(
            Tuple<String, String>[] opArgDefs,
            string opKind,
            string opName,
            string opArgs,
            string opReturnType,
            QueryDocMethod queryDocMethod,
            QueryFieldSpecMethod queryFieldSpecMethod,
            string example
        )
        {
            if (this.FieldProfile == Exploration.Profile.DEFAULT ||
                this.FieldProfile == Exploration.Profile.DETAIL ||
                this.FieldProfile == Exploration.Profile.CUSTOM)
            {
                // read override patch file (if any) and apply it:
                string f = Path.Combine(
                    this.GetOperationsDir(), opName + ".patch");
                Exploration.ReadPatchFromFile(patchFile: f, missingOk: true);
            }

            // apply exploratory fragment to Field if it's null:
            if (this.Field == null)
            {
                this.Field = queryFieldSpecMethod();
            }

            var vars = new RscGqlVars(
                this.Var,
                opArgDefs,
                this.GetValueFromParameterSet,
                // we don't check the variables here,
                // user may want to fill them in later.
                // variables are checked in Invoke-Rsc
                // when the query is actually sent
                ignoreRequired: true,
                example);

            var gqlOp = new RscGqlOperation(
                opKind,
                opName,
                opArgs,
                opReturnType
            );
            _query = new RscQuery(this.Op, vars, this.Field, gqlOp);
            _query.Init(
                _logger,
                this.GetOperationsDir(),
                this.GetCustomDir(),
                queryDocMethod,
                queryFieldSpecMethod);
        }

        protected override void EndProcessing()
        {
            base.EndProcessing();
            if ( _config.SendQueryOnExitIfAny && _query != null)
            {
                RscGqlRequest gqlReq = _query.GqlRequest();
                if (gqlReq != null && _rbkClient != null)
                {
                    this.SendGqlRequest(gqlReq);
                }
            }
            else
            {
                this.WriteObject(_query);
            }
        }
    }
}

