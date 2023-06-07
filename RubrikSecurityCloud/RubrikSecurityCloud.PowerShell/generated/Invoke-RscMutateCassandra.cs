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
using RubrikSecurityCloud.Schema.Utils;
using GraphQL;

namespace Rubrik.SecurityCloud.PowerShell.Cmdlets
{
    [Cmdlet(
        "Invoke",
        "RscMutateCassandra",
        DefaultParameterSetName = "Createsource")
    ]
    public class Invoke_RscMutateCassandra : RscPSCmdlet
    {
        
        // -------------------------------------------------------------------
        // Recoversource parameter set
        //
        // [GraphQL: recoverCassandraSource]
        //
        [Parameter(
            ParameterSetName = "Recoversource",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Recover a cassandra source.
[GraphQL: recoverCassandraSource]",
            Position = 0
        )]
        public SwitchParameter Recoversource { get; set; }

        [Parameter(
            ParameterSetName = "Recoversource",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Input for V2MosaicRestoreData.
GraphQL argument input: MosaicRestoreDataInput!"
        )]
        public MosaicRestoreDataInput? Input { get; set; }
        
        // -------------------------------------------------------------------
        // Createsource parameter set
        //
        // [GraphQL: createCassandraSource]
        //
        [Parameter(
            ParameterSetName = "Createsource",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a cassandra source.
[GraphQL: createCassandraSource]",
            Position = 0
        )]
        public SwitchParameter Createsource { get; set; }

        
        // -------------------------------------------------------------------
        // Updatesource parameter set
        //
        // [GraphQL: updateCassandraSource]
        //
        [Parameter(
            ParameterSetName = "Updatesource",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Update a cassandra source.
[GraphQL: updateCassandraSource]",
            Position = 0
        )]
        public SwitchParameter Updatesource { get; set; }

        
        // -------------------------------------------------------------------
        // Deletesource parameter set
        //
        // [GraphQL: deleteCassandraSource]
        //
        [Parameter(
            ParameterSetName = "Deletesource",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Delete a cassandra source.
[GraphQL: deleteCassandraSource]",
            Position = 0
        )]
        public SwitchParameter Deletesource { get; set; }

        
        // -------------------------------------------------------------------
        // Bulkdeletesource parameter set
        //
        // [GraphQL: bulkDeleteCassandraSources]
        //
        [Parameter(
            ParameterSetName = "Bulkdeletesource",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Bulk Delete cassandra sources.
[GraphQL: bulkDeleteCassandraSources]",
            Position = 0
        )]
        public SwitchParameter Bulkdeletesource { get; set; }


        protected override void ProcessRecord()
        {
            try
            {
                switch(Op)
                {
                    case "Recoversource":
                        this.ProcessRecord_Recoversource();
                        break;
                    case "Createsource":
                        this.ProcessRecord_Createsource();
                        break;
                    case "Updatesource":
                        this.ProcessRecord_Updatesource();
                        break;
                    case "Deletesource":
                        this.ProcessRecord_Deletesource();
                        break;
                    case "Bulkdeletesource":
                        this.ProcessRecord_Bulkdeletesource();
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
        protected void ProcessRecord_Recoversource()
        {
            this._logger.name += " -Recoversource";
            // Invoke graphql operation recoverCassandraSource
            InvokeMutationRecoverCassandraSource();
        }

        // This parameter set invokes a single graphql operation:
        // createCassandraSource.
        protected void ProcessRecord_Createsource()
        {
            this._logger.name += " -Createsource";
            // Invoke graphql operation createCassandraSource
            InvokeMutationCreateCassandraSource();
        }

        // This parameter set invokes a single graphql operation:
        // updateCassandraSource.
        protected void ProcessRecord_Updatesource()
        {
            this._logger.name += " -Updatesource";
            // Invoke graphql operation updateCassandraSource
            InvokeMutationUpdateCassandraSource();
        }

        // This parameter set invokes a single graphql operation:
        // deleteCassandraSource.
        protected void ProcessRecord_Deletesource()
        {
            this._logger.name += " -Deletesource";
            // Invoke graphql operation deleteCassandraSource
            InvokeMutationDeleteCassandraSource();
        }

        // This parameter set invokes a single graphql operation:
        // bulkDeleteCassandraSources.
        protected void ProcessRecord_Bulkdeletesource()
        {
            this._logger.name += " -Bulkdeletesource";
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
                if (this.Field is PSObject psObject) {
                    fields = (MosaicAsyncResponse)psObject.BaseObject;
                } else {
                    fields = (MosaicAsyncResponse)this.Field;
                }
            }
            string document = Mutation.RecoverCassandraSource(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.RecoverCassandraSource");
            var parameters = "($input: MosaicRestoreDataInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationRecoverCassandraSource" + parameters + "{" + document + "}",
                OperationName = "MutationRecoverCassandraSource",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "MosaicAsyncResponse", this._logger, GetMetricTags());
            WriteObject(result, true);
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
                if (this.Field is PSObject psObject) {
                    fields = (MosaicAsyncResponse)psObject.BaseObject;
                } else {
                    fields = (MosaicAsyncResponse)this.Field;
                }
            }
            string document = Mutation.CreateCassandraSource(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.CreateCassandraSource");
            var parameters = "($input: AddMosaicSourceInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationCreateCassandraSource" + parameters + "{" + document + "}",
                OperationName = "MutationCreateCassandraSource",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "MosaicAsyncResponse", this._logger, GetMetricTags());
            WriteObject(result, true);
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
                if (this.Field is PSObject psObject) {
                    fields = (MosaicAsyncResponse)psObject.BaseObject;
                } else {
                    fields = (MosaicAsyncResponse)this.Field;
                }
            }
            string document = Mutation.UpdateCassandraSource(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.UpdateCassandraSource");
            var parameters = "($input: ModifyMosaicSourceInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationUpdateCassandraSource" + parameters + "{" + document + "}",
                OperationName = "MutationUpdateCassandraSource",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "MosaicAsyncResponse", this._logger, GetMetricTags());
            WriteObject(result, true);
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
                if (this.Field is PSObject psObject) {
                    fields = (MosaicAsyncResponse)psObject.BaseObject;
                } else {
                    fields = (MosaicAsyncResponse)this.Field;
                }
            }
            string document = Mutation.DeleteCassandraSource(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.DeleteCassandraSource");
            var parameters = "($input: DeleteMosaicSourceInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationDeleteCassandraSource" + parameters + "{" + document + "}",
                OperationName = "MutationDeleteCassandraSource",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "MosaicAsyncResponse", this._logger, GetMetricTags());
            WriteObject(result, true);
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
                if (this.Field is PSObject psObject) {
                    fields = (MosaicAsyncResponse)psObject.BaseObject;
                } else {
                    fields = (MosaicAsyncResponse)this.Field;
                }
            }
            string document = Mutation.BulkDeleteCassandraSources(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.BulkDeleteCassandraSources");
            var parameters = "($input: BulkDeleteMosaicSourcesInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationBulkDeleteCassandraSources" + parameters + "{" + document + "}",
                OperationName = "MutationBulkDeleteCassandraSources",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "MosaicAsyncResponse", this._logger, GetMetricTags());
            WriteObject(result, true);
        }


    } // class Invoke_RscMutateCassandra
}