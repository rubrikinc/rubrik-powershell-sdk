// Invoke-RscMutateCassandra.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections;
using System.Collections.Generic;
using System.Management.Automation;
using System.Text;
using System.Threading.Tasks;
using GraphQL;
using RubrikSecurityCloud;
using RubrikSecurityCloud.Types;
using RubrikSecurityCloud.NetSDK.Client;
using RubrikSecurityCloud.PowerShell.Private;

namespace RubrikSecurityCloud.PowerShell.Cmdlets
{
    [Cmdlet(
        "Invoke",
        "RscMutateCassandra",
        DefaultParameterSetName = "CreateSource")
    ]
    public class Invoke_RscMutateCassandra : RscPSCmdlet
    {
        
        // -------------------------------------------------------------------
        // RecoverSource parameter set
        //
        // [GraphQL: recoverCassandraSource]
        //
        [Parameter(
            ParameterSetName = "RecoverSource",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Recover a cassandra source.
[GraphQL: recoverCassandraSource]",
            Position = 0
        )]
        public SwitchParameter RecoverSource { get; set; }

        
        // -------------------------------------------------------------------
        // CreateSource parameter set
        //
        // [GraphQL: createCassandraSource]
        //
        [Parameter(
            ParameterSetName = "CreateSource",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a cassandra source.
[GraphQL: createCassandraSource]",
            Position = 0
        )]
        public SwitchParameter CreateSource { get; set; }

        
        // -------------------------------------------------------------------
        // UpdateSource parameter set
        //
        // [GraphQL: updateCassandraSource]
        //
        [Parameter(
            ParameterSetName = "UpdateSource",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Update a cassandra source.
[GraphQL: updateCassandraSource]",
            Position = 0
        )]
        public SwitchParameter UpdateSource { get; set; }

        
        // -------------------------------------------------------------------
        // DeleteSource parameter set
        //
        // [GraphQL: deleteCassandraSource]
        //
        [Parameter(
            ParameterSetName = "DeleteSource",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Delete a cassandra source.
[GraphQL: deleteCassandraSource]",
            Position = 0
        )]
        public SwitchParameter DeleteSource { get; set; }

        
        // -------------------------------------------------------------------
        // BulkDeleteSource parameter set
        //
        // [GraphQL: bulkDeleteCassandraSources]
        //
        [Parameter(
            ParameterSetName = "BulkDeleteSource",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Bulk Delete cassandra sources.
[GraphQL: bulkDeleteCassandraSources]",
            Position = 0
        )]
        public SwitchParameter BulkDeleteSource { get; set; }


        protected override void ProcessRecord()
        {
            try
            {
                switch(Op)
                {
                    case "RecoverSource":
                        this.ProcessRecord_RecoverSource();
                        break;
                    case "CreateSource":
                        this.ProcessRecord_CreateSource();
                        break;
                    case "UpdateSource":
                        this.ProcessRecord_UpdateSource();
                        break;
                    case "DeleteSource":
                        this.ProcessRecord_DeleteSource();
                        break;
                    case "BulkDeleteSource":
                        this.ProcessRecord_BulkDeleteSource();
                        break;
                    default:
                        throw new Exception("Unknown Operation " + Op);
                }
           }
           catch (Exception ex)
           {
                ThrowTerminatingException(ex);
           }
        }

        // This parameter set invokes a single graphql operation:
        // recoverCassandraSource.
        protected void ProcessRecord_RecoverSource()
        {
            this._logger.name += " -RecoverSource";
            // Invoke graphql operation recoverCassandraSource
            InvokeMutationRecoverCassandraSource();
        }

        // This parameter set invokes a single graphql operation:
        // createCassandraSource.
        protected void ProcessRecord_CreateSource()
        {
            this._logger.name += " -CreateSource";
            // Invoke graphql operation createCassandraSource
            InvokeMutationCreateCassandraSource();
        }

        // This parameter set invokes a single graphql operation:
        // updateCassandraSource.
        protected void ProcessRecord_UpdateSource()
        {
            this._logger.name += " -UpdateSource";
            // Invoke graphql operation updateCassandraSource
            InvokeMutationUpdateCassandraSource();
        }

        // This parameter set invokes a single graphql operation:
        // deleteCassandraSource.
        protected void ProcessRecord_DeleteSource()
        {
            this._logger.name += " -DeleteSource";
            // Invoke graphql operation deleteCassandraSource
            InvokeMutationDeleteCassandraSource();
        }

        // This parameter set invokes a single graphql operation:
        // bulkDeleteCassandraSources.
        protected void ProcessRecord_BulkDeleteSource()
        {
            this._logger.name += " -BulkDeleteSource";
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
            var vars = new OperationVariableSet();
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
            var vars = new OperationVariableSet();
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
            var vars = new OperationVariableSet();
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
            var vars = new OperationVariableSet();
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
            var vars = new OperationVariableSet();
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