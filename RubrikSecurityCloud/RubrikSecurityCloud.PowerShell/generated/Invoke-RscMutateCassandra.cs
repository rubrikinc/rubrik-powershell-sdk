// Invoke-RscMutateCassandra.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using Rubrik.SecurityCloud.Types;
using Rubrik.SecurityCloud.NetSDK.Client;
using Rubrik.SecurityCloud.PowerShell.Private;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Management.Automation;
using System.Text;
using System.Threading.Tasks;
using Rubrik.SecurityCloud.NetSDK.Library.HelperClasses;
using GraphQL;

namespace Rubrik.SecurityCloud.PowerShell.Cmdlets
{
    [Cmdlet(
        "Invoke",
        "RscMutateCassandra",
        DefaultParameterSetName = "createSource")
    ]
    public class Invoke_RscMutateCassandra : RscPSCmdlet
    {
        
        // -------------------------------------------------------------------
        // recoverSource parameter set
        //
        // GraphQL operation: recoverCassandraSource(input: MosaicRestoreDataInput!):MosaicAsyncResponse!
        //
        [Parameter(
            ParameterSetName = "recoverSource",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: recoverCassandraSource(input: MosaicRestoreDataInput!):MosaicAsyncResponse!",
            Position = 0
        )]
        public SwitchParameter recoverSource { get; set; }

        [Parameter(
            ParameterSetName = "recoverSource",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument input: MosaicRestoreDataInput!"
        )]
        public MosaicRestoreDataInput? Input { get; set; }
        
        // -------------------------------------------------------------------
        // createSource parameter set
        //
        // GraphQL operation: createCassandraSource(input: AddMosaicSourceInput!):MosaicAsyncResponse!
        //
        [Parameter(
            ParameterSetName = "createSource",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: createCassandraSource(input: AddMosaicSourceInput!):MosaicAsyncResponse!",
            Position = 0
        )]
        public SwitchParameter createSource { get; set; }

        
        // -------------------------------------------------------------------
        // updateSource parameter set
        //
        // GraphQL operation: updateCassandraSource(input: ModifyMosaicSourceInput!):MosaicAsyncResponse!
        //
        [Parameter(
            ParameterSetName = "updateSource",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: updateCassandraSource(input: ModifyMosaicSourceInput!):MosaicAsyncResponse!",
            Position = 0
        )]
        public SwitchParameter updateSource { get; set; }

        
        // -------------------------------------------------------------------
        // deleteSource parameter set
        //
        // GraphQL operation: deleteCassandraSource(input: DeleteMosaicSourceInput!):MosaicAsyncResponse!
        //
        [Parameter(
            ParameterSetName = "deleteSource",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: deleteCassandraSource(input: DeleteMosaicSourceInput!):MosaicAsyncResponse!",
            Position = 0
        )]
        public SwitchParameter deleteSource { get; set; }

        
        // -------------------------------------------------------------------
        // bulkDeleteSource parameter set
        //
        // GraphQL operation: bulkDeleteCassandraSources(input: BulkDeleteMosaicSourcesInput!):MosaicAsyncResponse!
        //
        [Parameter(
            ParameterSetName = "bulkDeleteSource",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: bulkDeleteCassandraSources(input: BulkDeleteMosaicSourcesInput!):MosaicAsyncResponse!",
            Position = 0
        )]
        public SwitchParameter bulkDeleteSource { get; set; }


        protected override void ProcessRecord()
        {
            try
            {
                switch(Op)
                {
                    case "recoverSource":
                        this.ProcessRecord_recoverSource();
                        break;
                    case "createSource":
                        this.ProcessRecord_createSource();
                        break;
                    case "updateSource":
                        this.ProcessRecord_updateSource();
                        break;
                    case "deleteSource":
                        this.ProcessRecord_deleteSource();
                        break;
                    case "bulkDeleteSource":
                        this.ProcessRecord_bulkDeleteSource();
                        break;
                    default:
                        throw new Exception("Unknown Operation " + Op);
                }
           }
           catch (Exception ex)
           {
                this._logger.Flush();
                var error = new ErrorRecord(
                    ex,
                    "Invoke-RscMutateCassandra",
                    ErrorCategory.InvalidOperation,
                    null);
                ThrowTerminatingError(error);
           }
        }

        // This parameter set invokes a single graphql operation:
        // recoverCassandraSource.
        protected void ProcessRecord_recoverSource()
        {
            this._logger.name += " -recoverSource";
            // Invoke graphql operation recoverCassandraSource
            InvokeMutationRecoverCassandraSource();
        }

        // This parameter set invokes a single graphql operation:
        // createCassandraSource.
        protected void ProcessRecord_createSource()
        {
            this._logger.name += " -createSource";
            // Invoke graphql operation createCassandraSource
            InvokeMutationCreateCassandraSource();
        }

        // This parameter set invokes a single graphql operation:
        // updateCassandraSource.
        protected void ProcessRecord_updateSource()
        {
            this._logger.name += " -updateSource";
            // Invoke graphql operation updateCassandraSource
            InvokeMutationUpdateCassandraSource();
        }

        // This parameter set invokes a single graphql operation:
        // deleteCassandraSource.
        protected void ProcessRecord_deleteSource()
        {
            this._logger.name += " -deleteSource";
            // Invoke graphql operation deleteCassandraSource
            InvokeMutationDeleteCassandraSource();
        }

        // This parameter set invokes a single graphql operation:
        // bulkDeleteCassandraSources.
        protected void ProcessRecord_bulkDeleteSource()
        {
            this._logger.name += " -bulkDeleteSource";
            // Invoke graphql operation bulkDeleteCassandraSources
            InvokeMutationBulkDeleteCassandraSources();
        }


        // Invoke GraphQL Mutation:
        // recoverCassandraSource(input: MosaicRestoreDataInput!): MosaicAsyncResponse!
        protected void InvokeMutationRecoverCassandraSource()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "MosaicRestoreDataInput!"),
            };
            MosaicAsyncResponse? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (MosaicAsyncResponse)psObject.BaseObject;
                } else {
                    fields = (MosaicAsyncResponse)this.Field;
                }
            }
            string document = Mutation.RecoverCassandraSource(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.RecoverCassandraSource");
            string parameters = "($input: MosaicRestoreDataInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationRecoverCassandraSource" + parameters + "{" + document + "}",
                OperationName = "MutationRecoverCassandraSource",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<MosaicAsyncResponse> task = this._rbkClient.InvokeGenericCallAsync<MosaicAsyncResponse>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Mutation:
        // createCassandraSource(input: AddMosaicSourceInput!): MosaicAsyncResponse!
        protected void InvokeMutationCreateCassandraSource()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "AddMosaicSourceInput!"),
            };
            MosaicAsyncResponse? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (MosaicAsyncResponse)psObject.BaseObject;
                } else {
                    fields = (MosaicAsyncResponse)this.Field;
                }
            }
            string document = Mutation.CreateCassandraSource(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.CreateCassandraSource");
            string parameters = "($input: AddMosaicSourceInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationCreateCassandraSource" + parameters + "{" + document + "}",
                OperationName = "MutationCreateCassandraSource",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<MosaicAsyncResponse> task = this._rbkClient.InvokeGenericCallAsync<MosaicAsyncResponse>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Mutation:
        // updateCassandraSource(input: ModifyMosaicSourceInput!): MosaicAsyncResponse!
        protected void InvokeMutationUpdateCassandraSource()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "ModifyMosaicSourceInput!"),
            };
            MosaicAsyncResponse? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (MosaicAsyncResponse)psObject.BaseObject;
                } else {
                    fields = (MosaicAsyncResponse)this.Field;
                }
            }
            string document = Mutation.UpdateCassandraSource(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.UpdateCassandraSource");
            string parameters = "($input: ModifyMosaicSourceInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationUpdateCassandraSource" + parameters + "{" + document + "}",
                OperationName = "MutationUpdateCassandraSource",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<MosaicAsyncResponse> task = this._rbkClient.InvokeGenericCallAsync<MosaicAsyncResponse>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Mutation:
        // deleteCassandraSource(input: DeleteMosaicSourceInput!): MosaicAsyncResponse!
        protected void InvokeMutationDeleteCassandraSource()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteMosaicSourceInput!"),
            };
            MosaicAsyncResponse? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (MosaicAsyncResponse)psObject.BaseObject;
                } else {
                    fields = (MosaicAsyncResponse)this.Field;
                }
            }
            string document = Mutation.DeleteCassandraSource(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.DeleteCassandraSource");
            string parameters = "($input: DeleteMosaicSourceInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationDeleteCassandraSource" + parameters + "{" + document + "}",
                OperationName = "MutationDeleteCassandraSource",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<MosaicAsyncResponse> task = this._rbkClient.InvokeGenericCallAsync<MosaicAsyncResponse>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Mutation:
        // bulkDeleteCassandraSources(input: BulkDeleteMosaicSourcesInput!): MosaicAsyncResponse!
        protected void InvokeMutationBulkDeleteCassandraSources()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "BulkDeleteMosaicSourcesInput!"),
            };
            MosaicAsyncResponse? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (MosaicAsyncResponse)psObject.BaseObject;
                } else {
                    fields = (MosaicAsyncResponse)this.Field;
                }
            }
            string document = Mutation.BulkDeleteCassandraSources(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.BulkDeleteCassandraSources");
            string parameters = "($input: BulkDeleteMosaicSourcesInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationBulkDeleteCassandraSources" + parameters + "{" + document + "}",
                OperationName = "MutationBulkDeleteCassandraSources",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<MosaicAsyncResponse> task = this._rbkClient.InvokeGenericCallAsync<MosaicAsyncResponse>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }


    } // class Invoke_RscMutateCassandra
}