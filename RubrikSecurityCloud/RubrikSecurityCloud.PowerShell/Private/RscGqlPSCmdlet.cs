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
        /// Input: Operation to run. Overridden by operation switches.
        /// </summary>
        [Parameter(
            Mandatory = false,
            Position = 1,
            ValueFromPipeline = true,
            ValueFromPipelineByPropertyName = true)]
        public string Op { get; set; }

        /// <summary>
        /// Input: Arguments to the operation. Overridden by argument parameters.
        /// </summary>
        [Parameter(
            Mandatory = false,
            Position = 2,
            ValueFromPipeline = true,
            ValueFromPipelineByPropertyName = true)]
        public object Arg { get; set; }

        /// <summary>
        /// An object that represents the fields that need to be returned
        /// for a given query. Each property on this object that does not
        /// have a null value (actual values don’t matter) will be included 
        /// in the API request.
        /// </summary>
        [Parameter(
            Mandatory = false,
            Position = 3,
            ValueFromPipeline = true,
            ValueFromPipelineByPropertyName = true)]
        public object Field { get; set; }

        /// <summary>
        /// Returns an object that contains the Op, Arg and Field inputs
        /// that would be used to run the operation.
        /// </summary>
        [Parameter(
            Mandatory = false,
            Position = 4,
            ValueFromPipeline = false)]
        public SwitchParameter GetInputs { get; set; }

        /// <summary>
        /// The input profile determines how inputs to the operation
        /// should be automatically set if they are not explicitly given
        /// as parameters.
        /// </summary>
        [Parameter(
            Mandatory = false,
            Position = 5,
            ValueFromPipeline = false)]
        public Exploration.Profile InputProfile { get; set; }

        /// <summary>
        /// Returns the GraphQL request instead of sending it
        /// to the server.
        /// </summary>
        [Parameter(
            Mandatory = false,
            Position = 6,
            ValueFromPipeline = false)]
        public SwitchParameter GetGqlRequest { get; set; }

        internal string _operationsDir = null;
        internal string _customDir = null;

        // _input is instantiated in BeginProcessing() here
        // and initialized in the Invoke methods in derived classes.
        internal RscCmdletInput _input = null;
        internal string _opKind = null;
        internal string _opName = null;
        internal string _opArgs = null;
        internal string _opFields = null;
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
            ResolveOperationsDir();
            Exploration.Init(this.InputProfile);
            if (string.IsNullOrEmpty(Op))
            {
                Op = ParameterSetName ;
            }
            _input = new RscCmdletInput(this);
        }

        protected override void EndProcessing()
        {
            base.EndProcessing();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + _gqlRequest.Query);
                this.WriteObject(this._input);
                return;
            }
            if (this.GetGqlRequest) {
                _gqlRequest.Init(
                    variables: _gqlVars.AsJson(this._logger),
                    customOperationsDir: _customDir);
                this.WriteObject(_gqlRequest);
                return;
            }
        }

        protected void ResolveOperationsDir() 
        {
            _customDir = Files.GetCustomDir(
                this.SessionState.PSVariable.GetValue(
                    "RSC_CUSTOM_DIR", "").ToString());
            if (this.InputProfile == Exploration.Profile.CUSTOM)
            {
                _operationsDir = _customDir;
            } else {
                _operationsDir = Files.GetSdkOperationsDir(this.InputProfile.ToString());
            }
            this._logger.Debug($"_operationsDir: {_operationsDir} {Directory.Exists(_operationsDir)}");
        }

        protected void Initialize(
            Tuple<String, String>[] argDefs,
            System.Object fieldSpecObj,
            string opKind,
            string opName,
            string opArgs,
            string opFields,
            string opReturnType)
        {
            _input.Initialize(argDefs, fieldSpecObj, opName);
            _opKind = opKind;
            _opName = opName;
            _opArgs = opArgs;
            _opFields = opFields;
            _opReturnType = opReturnType;
            // fix _opFields indenting if needed:
            if ( ! string.IsNullOrEmpty(_opFields) && _opFields[0] != ' ') {
                _opFields = "  " + _opFields.Replace("\n", "\n  ");
            }
            string query = _opKind + " " + _opName + _opArgs + "\n{\n" + _opFields + "}\n" ;
            string overrideFile = Path.Combine(_operationsDir, _opName + ".gql");
            string overrideQuery = Files.ReadFileIfExists(overrideFile);

            if ( ! string.IsNullOrEmpty(overrideQuery) ) {
                this._logger.Debug("Using override " + overrideFile);
                query = overrideQuery;
            } else {
                this._logger.Debug("No override " + overrideFile);
                if (InputProfile == Exploration.Profile.CUSTOM ) {
                    this._logger.Warning("Missing Operation File: " + overrideFile + " (using DEFAULT)");
                }
            }
            _gqlRequest = new RscGqlRequest{
                Query = query,
                OperationName = opName };
            _gqlVars = new OperationVariableSet();
            if (!string.IsNullOrEmpty(_opArgs)) {
                _gqlVars.Variables = this._input.GetArgDict();
            }
        }
    }

}

