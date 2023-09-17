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
    /// Base class for all RSC PowerShell cmdlets that use a GraphQL query.
    /// </summary>
    public class RscGqlPSCmdlet : RscBasePSCmdlet, IDynamicParameters
    {
        /// <summary>
        /// Specifies the inputs to the GraphQL operation.
        /// Any other -Op, -Var, or -Field parameter
        /// will override what is given in -Input.
        /// </summary>
        [Parameter(
            Mandatory = false,
            Position = 0,
            ValueFromPipeline = true,
            ValueFromPipelineByPropertyName = true)]
        public RscQuery Input { get; set; }

        /// <summary>
        /// Operation to run. Overridden by operation switches.
        /// Only use -Op to programmatically pick the operation to run.
        /// Typically, you would use the operation switches instead.
        /// For example, `Invoke-RscQueryCluster -List` is equivalent to
        /// `Invoke-RscQueryCluster -Op List`. 
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
        /// Returns an object that contains the Op, Var and Field inputs
        /// that would be used to run the operation.
        /// </summary>
        [Parameter(
            Mandatory = false,
            // No Position -> named parameter only.
            ValueFromPipeline = false)]
        public SwitchParameter GetInput { get; set; }

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

        /// <summary>
        /// Returns the GraphQL request instead of sending it
        /// to the server.
        /// </summary>
        [Parameter(
            Mandatory = false,
            // No Position -> named parameter only.
            ValueFromPipeline = false)]
        public SwitchParameter GetGqlRequest { get; set; }

        private RuntimeDefinedParameterDictionary _dynamicParameters;

        internal RscQuery _query = null;

        /// <summary>
        /// Create a new RSC PowerShell cmdlet.
        /// </summary>
        public RscGqlPSCmdlet()
        {
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
            // PS> (Invoke-RscQueryAzure -Subscriptions -GetGqlRequest).operationName
            // QueryAzureSqlDatabase
            // PS> (Invoke-RscQueryCluster -IsTotpAckNecessary -GetGqlRequest).operationName
            // QueryClusterConnection
            //
            // Note: in Invoke-RscQueryAzure.cs, we see:
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
            var rscOp = GetRscOp();

            // Define -Patch
            var patchAttributes = new Collection<Attribute>();
            patchAttributes.Add(new ParameterAttribute
            {
                HelpMessage = "Add or remove fields in the response."
            });
            if (rscOp != null && rscOp.IsDetermined())
            {
                try {
                    List<string> validValues = RscPatchString.BuildValidPatchStringsFor(rscOp.GqlReturnTypeName, 5, new HashSet<string> { "Edges" });
                    if (validValues.Count > 0)
                    {
                        var attr = new ValidateSetAttribute(validValues.ToArray());
                        patchAttributes.Add(attr);
                    }
                } catch (Exception ex)
                {
                    _logger.Debug($"Error building valid patch strings for {rscOp.GqlReturnTypeName}: {ex.Message}");
                }
            }
            var patchParams = new RuntimeDefinedParameter("Patch", typeof(string[]), patchAttributes);

            // Define the dynamic parameter set:
            _dynamicParameters = new RuntimeDefinedParameterDictionary();

            // Add Patch to the set:
            _dynamicParameters.Add("Patch", patchParams);

            return _dynamicParameters;
        }
        protected override void ProcessRecord()
        {
            base.ProcessRecord();

            // Log operations dir that will be used:
            string opDir = GetOperationsDir();
            _logger.Debug($"op dir: {opDir} {Directory.Exists(opDir)}");
            PreprocessInputs();
            if (!this.IsIntrospective())
            {
                RetrieveConnection();
            }
        }

        protected void PreprocessInputs()
        {
            // Pre-process inputs before getting into
            // the InvokeX() method:

            // -Input is exclusive with other parameters
            // and needs exploration to be turned off
            if (this.Input != null)
            {
                this.Op = this.Input.Op;
                this.Var = this.Input.Var;
                this.Field = this.Input.Field;
                this.FieldProfile = Exploration.Profile.EMPTY;
            }
            if (string.IsNullOrEmpty(this.Op))
            {
                this.Op = DetermineOp();
            }
            if (this.Field != null)
            {
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
                if (this.Field is string sField)
                {
                    Exploration.ReadPatchFromString(sField);
                    this.Field = null;
                }
            }
            // apply -FilePatch patches if any:
            if (this.FilePatch != null)
            {
                foreach (string patchFile in this.FilePatch)
                {
                    Exploration.ReadPatchFromFile(patchFile);
                }
            }
            // apply -Patch patches if any:
            string[] patches = null;
            try {
                patches = _dynamicParameters["Patch"].Value as string[];
            } catch (Exception ex)
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

        protected override void EndProcessing()
        {
            base.EndProcessing();
            if (this.GetInput)
            {
                this.WriteObject(_query);
                return;
            }
            RscGqlRequest gqlReq = _query.GqlRequest();
            if (this.GetGqlRequest)
            {
                this.WriteObject(gqlReq);
                return;
            }
            if (gqlReq != null && _rbkClient != null)
            {
                this.SendGqlRequest(gqlReq);
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
                this.IsIntrospective(),
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

        internal bool IsIntrospective()
        {
            return this.GetInput || this.GetGqlRequest;
        }
    }

}

