using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
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
    public class RscGqlPSCmdlet : RscBasePSCmdlet
    {
        /// <summary>
        /// Specifies the inputs to the GraphQL operation.
        /// Any other -Op, -Var, or -Field parameter
        /// will override what is given in -Input.
        /// </summary>
        [Parameter(
            Mandatory = false,
            Position = 1,
            ValueFromPipeline = true,
            ValueFromPipelineByPropertyName = true)]
        public RscCmdletInput Input { get; set; }

        /// <summary>
        /// Operation to run. Overridden by operation switches.
        /// Only use -Op to programmatically pick the operation to run.
        /// Typically, you would use the operation switches instead.
        /// For example, `Invoke-RscQueryCluster -List` is equivalent to
        /// `Invoke-RscQueryCluster -Op List`. 
        /// </summary>
        [Parameter(
            Mandatory = false,
            Position = 2,
            ValueFromPipeline = true,
            ValueFromPipelineByPropertyName = true)]
        public string Op { get; set; }

        /// <summary>
        /// Operation variables. DEPRECATED in favor of -Var
        /// </summary>
        [Parameter(
            Mandatory = false,
            Position = 3,
            ValueFromPipeline = true,
            ValueFromPipelineByPropertyName = true)]
        public object Arg { get; set; }

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
        ///  Patch the field spec with field names from a string
        /// </summary>
        [Parameter(
            Mandatory = false,
            Position = 4,
            ValueFromPipeline = false)]
        public string[] Patch { get; set; }
    
        /// <summary>
        ///  Patch the field spec with field names from a file
        /// </summary>
        [Parameter(
            Mandatory = false,
            Position = 4,
            ValueFromPipeline = false)]
        public string[] PatchFile { get; set; }

        /// <summary>
        /// Returns an object that contains the Op, Var and Field inputs
        /// that would be used to run the operation.
        /// </summary>
        [Parameter(
            Mandatory = false,
            Position = 5,
            ValueFromPipeline = false)]
        public SwitchParameter GetInput { get; set; }

        /// <summary>
        /// The field profile determines how inputs to the operation
        /// should be automatically set if they are not explicitly given
        /// as parameters. DEPRECATED in favor of -FieldProfile
        /// </summary>
        [Parameter(
            Mandatory = false,
            Position = 6,
            ValueFromPipeline = false)]
        public Exploration.Profile InputProfile { get; set; } = Exploration.Profile.UNSET;

        /// <summary>
        /// The field profile determines how inputs to the operation
        /// should be automatically set if they are not explicitly given
        /// as parameters.
        /// </summary>
        [Parameter(
            Mandatory = false,
            Position = 6,
            ValueFromPipeline = false)]
        public Exploration.Profile FieldProfile { get; set; } = Exploration.Profile.UNSET;

        /// <summary>
        /// Returns the GraphQL request instead of sending it
        /// to the server.
        /// </summary>
        [Parameter(
            Mandatory = false,
            Position = 7,
            ValueFromPipeline = false)]
        public SwitchParameter GetGqlRequest { get; set; }

        internal RscCmdletInput _input = null;
        internal string _opKind = null;
        internal string _opName = null;
        internal string _opArgs = null;
        internal Tuple<string, string>[] _opArgDefs = null;
        internal string _opReturnType = null;
        internal RscGqlRequest _gqlRequest = null;
        internal OperationVariableSet _gqlVars = null;

        /// <summary>
        /// Create a new RSC PowerShell cmdlet.
        /// </summary>
        public RscGqlPSCmdlet()
        {
        }

        protected override void BeginProcessing()
        {
            base.BeginProcessing();

            // Log operations dir that will be used:
            string opDir = GetOperationsDir();
            this._logger.Debug($"op dir: {opDir} {Directory.Exists(opDir)}");


            // Pre-process inputs before getting into
            // the InvokeX() method:

            // -Arg is deprecated in favor of -Var
            if (this.Var != null)
            {
                this.Arg = this.Var;
            }

            // -InputProfile is deprecated in favor of -FieldProfile
            if (this.FieldProfile != Exploration.Profile.UNSET)
            {
                this.InputProfile = this.FieldProfile;
            }

            // -Input is exclusive with other parameters
            // and needs exploration to be turned off
            if (this.Input != null)
            {
                this.Op = this.Input.Op;
                this.Arg = this.Input.Var;
                this.Field = this.Input.Field;
                this.InputProfile = Exploration.Profile.EMPTY;
            }
            if (string.IsNullOrEmpty(this.Op))
            {
                this.Op = ParameterSetName;
            }
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject)
                {
                    this.Field = psObject.BaseObject;
                }
            }
            if (this.InputProfile == Exploration.Profile.UNSET)
            {
                this.InputProfile = Exploration.Profile.DEFAULT;
            }
            Exploration.Init(this.InputProfile);
            if (this.Field != null)
            {
                if (this.Field is string sField)
                {
                    Exploration.ReadPatchFromString(sField);
                    this.Field = null;
                }
            }
            // apply -PatchFile patches if any:
            if (this.PatchFile != null)
            {
                foreach (string patchFile in this.PatchFile)
                {
                    Exploration.ReadPatchFromFile(patchFile);
                }
            }
            // apply -Patch patches if any:
            if (this.Patch != null)
            {
                foreach (string patch in this.Patch)
                {
                    Exploration.ReadPatchFromString(patch);
                }
            }

            // if no Field is given, and no patch is given,
            // profile can't be empty:
            if (this.Field == null && !Exploration.HasPatch() && 
            this.InputProfile == Exploration.Profile.EMPTY)
            {
                this.InputProfile = Exploration.Profile.DEFAULT;
                Exploration.GlobalProfile = Exploration.Profile.DEFAULT;
            }
        }

        protected override void EndProcessing()
        {
            base.EndProcessing();
            if (this.GetInput)
            {
                this._logger.Debug("Query: " + _gqlRequest.Query);
                this.WriteObject(this._input);
                return;
            }
            if (this.GetGqlRequest)
            {
                _gqlRequest.Init(
                    // always give the custom dir, even if this
                    // query doesn't comes from CUSTOM profile,
                    // because if the user wants to save it,
                    // it should be saved in RSC_CUSTOM_DIR:
                    customOperationsDir: this.GetCustomDir(),
                    variables: _gqlVars.AsJson(this._logger)
                );
                this.WriteObject(_gqlRequest);
                return;
            }
        }

        protected string GetOperationsDir()
        {
            switch (this.InputProfile)
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
            string opReturnType
        )
        {
            _opArgDefs = opArgDefs;
            _opKind = opKind;
            _opName = opName;
            _opArgs = opArgs;
            _opReturnType = opReturnType;

            if (this.InputProfile == Exploration.Profile.DEFAULT ||
                this.InputProfile == Exploration.Profile.DETAIL ||
                this.InputProfile == Exploration.Profile.CUSTOM)
            {
                // read patch file (if any) and apply it:
                string patchFile = Path.Combine(
                    this.GetOperationsDir(), _opName + ".patch");
                Exploration.ReadPatchFromFile(patchFile);
            }
        }

        protected void BuildInput(System.Object fieldSpecObj, string example)
        {
            var vars = new RscGqlVars(
                    this.Arg,
                    _opArgDefs,
                    this.GetValueFromParameterSet,
                    this.IsIntrospective(),
                    example);
            var gqlOp = new RscGqlOperation(
                    _opKind,
                    _opName,
                    _opArgs,
                    _opReturnType
                );
            _input = new RscCmdletInput(
                this.Op,
                vars,
                fieldSpecObj,
                gqlOp
            );
            _logger.Debug($"Input: {this._input}");
        }
        /// <summary>
        /// Build the GraphQL request
        /// </summary>
        /// <param name="opFields">
        /// GraphQL field specification
        /// e.g. "count { node { id name } }"
        /// </param>
        protected void BuildRequest(string opFieldSpec)
        {
            // this should go in BuildInput()
            _input._gqlOperation.FieldSpec = opFieldSpec;

            string query = _input._gqlOperation.Query();

            _gqlRequest = new RscGqlRequest
            {
                Query = ApplyOverrideGqlFileIfAny(query),
                OperationName = _opName
            };
            _gqlVars = new OperationVariableSet();
            if (!string.IsNullOrEmpty(_opArgs))
            {
                _gqlVars.Variables = this._input.Var.ToDict();
            }
        }

        internal string ApplyOverrideGqlFileIfAny(string query)
        {
            string overrideFile = Path.Combine(
                this.GetOperationsDir(), _opName + ".gql");
            string overrideQuery = Files.ReadFileIfExists(overrideFile);

            if (!string.IsNullOrEmpty(overrideQuery))
            {
                this._logger.Debug("Using override " + overrideFile);
                query = overrideQuery;
            }
            else
            {
                this._logger.Debug("No override " + overrideFile);
            }
            return query;
        }

        internal bool IsIntrospective()
        {
            return this.GetInput || this.GetGqlRequest;
        }
    }

}

