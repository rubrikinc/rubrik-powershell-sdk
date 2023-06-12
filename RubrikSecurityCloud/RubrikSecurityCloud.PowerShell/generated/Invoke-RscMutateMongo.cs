// Invoke-RscMutateMongo.cs
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
        "RscMutateMongo",
        DefaultParameterSetName = "Addsource")
    ]
    public class Invoke_RscMutateMongo : RscPSCmdlet
    {
        
        // -------------------------------------------------------------------
        // Addsource parameter set
        //
        // [GraphQL: addMongoSource]
        //
        [Parameter(
            ParameterSetName = "Addsource",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Add a new MongoDB source

Supported in v8.1+
Adds a new MongoDB source to the Rubrik Cluster.
[GraphQL: addMongoSource]",
            Position = 0
        )]
        public SwitchParameter Addsource { get; set; }

        [Parameter(
            ParameterSetName = "Addsource",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Input for V1AddMongoSource.
GraphQL argument input: AddMongoSourceInput!"
        )]
        public AddMongoSourceInput? Input { get; set; }
        
        // -------------------------------------------------------------------
        // Deletesource parameter set
        //
        // [GraphQL: deleteMongoSource]
        //
        [Parameter(
            ParameterSetName = "Deletesource",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Delete a MongoDB source

Supported in v8.1+
Deletes a specific MongoDB source.
[GraphQL: deleteMongoSource]",
            Position = 0
        )]
        public SwitchParameter Deletesource { get; set; }

        
        // -------------------------------------------------------------------
        // Discoversource parameter set
        //
        // [GraphQL: discoverMongoSource]
        //
        [Parameter(
            ParameterSetName = "Discoversource",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Discover a MongoDB source on-demand

Supported in v8.1+
Initiates an on-demand job to discover a MongoDB source.
[GraphQL: discoverMongoSource]",
            Position = 0
        )]
        public SwitchParameter Discoversource { get; set; }

        
        // -------------------------------------------------------------------
        // Patchsource parameter set
        //
        // [GraphQL: patchMongoSource]
        //
        [Parameter(
            ParameterSetName = "Patchsource",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Edit a MongoDB source

Supported in v8.1+
Edits the properties of a MongoDB source. Hosts, name, and type of MongoDB cannot be changed once added.
[GraphQL: patchMongoSource]",
            Position = 0
        )]
        public SwitchParameter Patchsource { get; set; }

        
        // -------------------------------------------------------------------
        // Retryaddsource parameter set
        //
        // [GraphQL: retryAddMongoSource]
        //
        [Parameter(
            ParameterSetName = "Retryaddsource",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Update a MongoDB source

Supported in v8.1+
Updates a MongoDB source details. You can use this endpoint for updating MongoDB source details when the request to add a source fails.
[GraphQL: retryAddMongoSource]",
            Position = 0
        )]
        public SwitchParameter Retryaddsource { get; set; }

        
        // -------------------------------------------------------------------
        // Assignslatodbcollection parameter set
        //
        // [GraphQL: assignSlaToMongoDbCollection]
        //
        [Parameter(
            ParameterSetName = "Assignslatodbcollection",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Assign SLA Domain to MongoDB collection objects

Supported in v8.1+
Assigns SLA Domain to the given MongoDB collection objects.
[GraphQL: assignSlaToMongoDbCollection]",
            Position = 0
        )]
        public SwitchParameter Assignslatodbcollection { get; set; }

        
        // -------------------------------------------------------------------
        // Recoversource parameter set
        //
        // [GraphQL: recoverMongoSource]
        //
        [Parameter(
            ParameterSetName = "Recoversource",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Recover a MongoDB source from Rubrik CDM cluster.
[GraphQL: recoverMongoSource]",
            Position = 0
        )]
        public SwitchParameter Recoversource { get; set; }

        
        // -------------------------------------------------------------------
        // Createdbsource parameter set
        //
        // [GraphQL: createMongodbSource]
        //
        [Parameter(
            ParameterSetName = "Createdbsource",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Register a new MongoDB source to NoSQL cluster. 
For MongoDB, the term ""source"" is usually used for either a replica set or a sharded cluster.
For more info on MongoDB cluster, refer to: https://docs.mongodb.com/manual/introduction/.
[GraphQL: createMongodbSource]",
            Position = 0
        )]
        public SwitchParameter Createdbsource { get; set; }

        
        // -------------------------------------------------------------------
        // Updatedbsource parameter set
        //
        // [GraphQL: updateMongodbSource]
        //
        [Parameter(
            ParameterSetName = "Updatedbsource",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Modifies configuration for a registered MongoDB source in NoSQL cluster.
[GraphQL: updateMongodbSource]",
            Position = 0
        )]
        public SwitchParameter Updatedbsource { get; set; }

        
        // -------------------------------------------------------------------
        // Deletedbsource parameter set
        //
        // [GraphQL: deleteMongodbSource]
        //
        [Parameter(
            ParameterSetName = "Deletedbsource",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Remove a registered MongoDB source from NoSQL cluster.
[GraphQL: deleteMongodbSource]",
            Position = 0
        )]
        public SwitchParameter Deletedbsource { get; set; }

        
        // -------------------------------------------------------------------
        // Bulkdeletedbsource parameter set
        //
        // [GraphQL: bulkDeleteMongodbSources]
        //
        [Parameter(
            ParameterSetName = "Bulkdeletedbsource",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Bulk Delete Sources

Supported in m3.2.0-m4.2.0.
[GraphQL: bulkDeleteMongodbSources]",
            Position = 0
        )]
        public SwitchParameter Bulkdeletedbsource { get; set; }

        
        // -------------------------------------------------------------------
        // Recoverdbsource parameter set
        //
        // [GraphQL: recoverMongodbSource]
        //
        [Parameter(
            ParameterSetName = "Recoverdbsource",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Recover a MongoDB source from NoSQL cluster.
[GraphQL: recoverMongodbSource]",
            Position = 0
        )]
        public SwitchParameter Recoverdbsource { get; set; }


        protected override void ProcessRecord()
        {
            try
            {
                switch(Op)
                {
                    case "Addsource":
                        this.ProcessRecord_Addsource();
                        break;
                    case "Deletesource":
                        this.ProcessRecord_Deletesource();
                        break;
                    case "Discoversource":
                        this.ProcessRecord_Discoversource();
                        break;
                    case "Patchsource":
                        this.ProcessRecord_Patchsource();
                        break;
                    case "Retryaddsource":
                        this.ProcessRecord_Retryaddsource();
                        break;
                    case "Assignslatodbcollection":
                        this.ProcessRecord_Assignslatodbcollection();
                        break;
                    case "Recoversource":
                        this.ProcessRecord_Recoversource();
                        break;
                    case "Createdbsource":
                        this.ProcessRecord_Createdbsource();
                        break;
                    case "Updatedbsource":
                        this.ProcessRecord_Updatedbsource();
                        break;
                    case "Deletedbsource":
                        this.ProcessRecord_Deletedbsource();
                        break;
                    case "Bulkdeletedbsource":
                        this.ProcessRecord_Bulkdeletedbsource();
                        break;
                    case "Recoverdbsource":
                        this.ProcessRecord_Recoverdbsource();
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
        // addMongoSource.
        protected void ProcessRecord_Addsource()
        {
            this._logger.name += " -Addsource";
            // Invoke graphql operation addMongoSource
            InvokeMutationAddMongoSource();
        }

        // This parameter set invokes a single graphql operation:
        // deleteMongoSource.
        protected void ProcessRecord_Deletesource()
        {
            this._logger.name += " -Deletesource";
            // Invoke graphql operation deleteMongoSource
            InvokeMutationDeleteMongoSource();
        }

        // This parameter set invokes a single graphql operation:
        // discoverMongoSource.
        protected void ProcessRecord_Discoversource()
        {
            this._logger.name += " -Discoversource";
            // Invoke graphql operation discoverMongoSource
            InvokeMutationDiscoverMongoSource();
        }

        // This parameter set invokes a single graphql operation:
        // patchMongoSource.
        protected void ProcessRecord_Patchsource()
        {
            this._logger.name += " -Patchsource";
            // Invoke graphql operation patchMongoSource
            InvokeMutationPatchMongoSource();
        }

        // This parameter set invokes a single graphql operation:
        // retryAddMongoSource.
        protected void ProcessRecord_Retryaddsource()
        {
            this._logger.name += " -Retryaddsource";
            // Invoke graphql operation retryAddMongoSource
            InvokeMutationRetryAddMongoSource();
        }

        // This parameter set invokes a single graphql operation:
        // assignSlaToMongoDbCollection.
        protected void ProcessRecord_Assignslatodbcollection()
        {
            this._logger.name += " -Assignslatodbcollection";
            // Invoke graphql operation assignSlaToMongoDbCollection
            InvokeMutationAssignSlaToMongoDbCollection();
        }

        // This parameter set invokes a single graphql operation:
        // recoverMongoSource.
        protected void ProcessRecord_Recoversource()
        {
            this._logger.name += " -Recoversource";
            // Invoke graphql operation recoverMongoSource
            InvokeMutationRecoverMongoSource();
        }

        // This parameter set invokes a single graphql operation:
        // createMongodbSource.
        protected void ProcessRecord_Createdbsource()
        {
            this._logger.name += " -Createdbsource";
            // Invoke graphql operation createMongodbSource
            InvokeMutationCreateMongodbSource();
        }

        // This parameter set invokes a single graphql operation:
        // updateMongodbSource.
        protected void ProcessRecord_Updatedbsource()
        {
            this._logger.name += " -Updatedbsource";
            // Invoke graphql operation updateMongodbSource
            InvokeMutationUpdateMongodbSource();
        }

        // This parameter set invokes a single graphql operation:
        // deleteMongodbSource.
        protected void ProcessRecord_Deletedbsource()
        {
            this._logger.name += " -Deletedbsource";
            // Invoke graphql operation deleteMongodbSource
            InvokeMutationDeleteMongodbSource();
        }

        // This parameter set invokes a single graphql operation:
        // bulkDeleteMongodbSources.
        protected void ProcessRecord_Bulkdeletedbsource()
        {
            this._logger.name += " -Bulkdeletedbsource";
            // Invoke graphql operation bulkDeleteMongodbSources
            InvokeMutationBulkDeleteMongodbSources();
        }

        // This parameter set invokes a single graphql operation:
        // recoverMongodbSource.
        protected void ProcessRecord_Recoverdbsource()
        {
            this._logger.name += " -Recoverdbsource";
            // Invoke graphql operation recoverMongodbSource
            InvokeMutationRecoverMongodbSource();
        }


        // Invoke GraphQL Mutation:
        // addMongoSource(input: AddMongoSourceInput!): AddMongoSourceReply!
        protected void InvokeMutationAddMongoSource()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "AddMongoSourceInput!"),
            };
            AddMongoSourceReply? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (AddMongoSourceReply)psObject.BaseObject;
                } else {
                    fields = (AddMongoSourceReply)this.Field;
                }
            }
            string document = Mutation.AddMongoSource(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.AddMongoSource");
            var parameters = "($input: AddMongoSourceInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationAddMongoSource" + parameters + "{" + document + "}",
                OperationName = "MutationAddMongoSource",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "AddMongoSourceReply", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Mutation:
        // deleteMongoSource(input: DeleteMongoSourceInput!): AsyncRequestStatus!
        protected void InvokeMutationDeleteMongoSource()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteMongoSourceInput!"),
            };
            AsyncRequestStatus? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (AsyncRequestStatus)psObject.BaseObject;
                } else {
                    fields = (AsyncRequestStatus)this.Field;
                }
            }
            string document = Mutation.DeleteMongoSource(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.DeleteMongoSource");
            var parameters = "($input: DeleteMongoSourceInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationDeleteMongoSource" + parameters + "{" + document + "}",
                OperationName = "MutationDeleteMongoSource",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "AsyncRequestStatus", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Mutation:
        // discoverMongoSource(input: DiscoverMongoSourceInput!): AsyncRequestStatus!
        protected void InvokeMutationDiscoverMongoSource()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DiscoverMongoSourceInput!"),
            };
            AsyncRequestStatus? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (AsyncRequestStatus)psObject.BaseObject;
                } else {
                    fields = (AsyncRequestStatus)this.Field;
                }
            }
            string document = Mutation.DiscoverMongoSource(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.DiscoverMongoSource");
            var parameters = "($input: DiscoverMongoSourceInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationDiscoverMongoSource" + parameters + "{" + document + "}",
                OperationName = "MutationDiscoverMongoSource",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "AsyncRequestStatus", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Mutation:
        // patchMongoSource(input: PatchMongoSourceInput!): AsyncRequestStatus!
        protected void InvokeMutationPatchMongoSource()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "PatchMongoSourceInput!"),
            };
            AsyncRequestStatus? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (AsyncRequestStatus)psObject.BaseObject;
                } else {
                    fields = (AsyncRequestStatus)this.Field;
                }
            }
            string document = Mutation.PatchMongoSource(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.PatchMongoSource");
            var parameters = "($input: PatchMongoSourceInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationPatchMongoSource" + parameters + "{" + document + "}",
                OperationName = "MutationPatchMongoSource",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "AsyncRequestStatus", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Mutation:
        // retryAddMongoSource(input: RetryAddMongoSourceInput!): AsyncRequestStatus!
        protected void InvokeMutationRetryAddMongoSource()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "RetryAddMongoSourceInput!"),
            };
            AsyncRequestStatus? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (AsyncRequestStatus)psObject.BaseObject;
                } else {
                    fields = (AsyncRequestStatus)this.Field;
                }
            }
            string document = Mutation.RetryAddMongoSource(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.RetryAddMongoSource");
            var parameters = "($input: RetryAddMongoSourceInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationRetryAddMongoSource" + parameters + "{" + document + "}",
                OperationName = "MutationRetryAddMongoSource",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "AsyncRequestStatus", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Mutation:
        // assignSlaToMongoDbCollection(input: AssignSlaToMongoDbCollectionInput!): AsyncRequestStatus!
        protected void InvokeMutationAssignSlaToMongoDbCollection()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "AssignSlaToMongoDbCollectionInput!"),
            };
            AsyncRequestStatus? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (AsyncRequestStatus)psObject.BaseObject;
                } else {
                    fields = (AsyncRequestStatus)this.Field;
                }
            }
            string document = Mutation.AssignSlaToMongoDbCollection(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.AssignSlaToMongoDbCollection");
            var parameters = "($input: AssignSlaToMongoDbCollectionInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationAssignSlaToMongoDbCollection" + parameters + "{" + document + "}",
                OperationName = "MutationAssignSlaToMongoDbCollection",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "AsyncRequestStatus", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Mutation:
        // recoverMongoSource(input: RecoverMongoSourceInput!): AsyncRequestStatus!
        protected void InvokeMutationRecoverMongoSource()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "RecoverMongoSourceInput!"),
            };
            AsyncRequestStatus? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (AsyncRequestStatus)psObject.BaseObject;
                } else {
                    fields = (AsyncRequestStatus)this.Field;
                }
            }
            string document = Mutation.RecoverMongoSource(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.RecoverMongoSource");
            var parameters = "($input: RecoverMongoSourceInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationRecoverMongoSource" + parameters + "{" + document + "}",
                OperationName = "MutationRecoverMongoSource",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "AsyncRequestStatus", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Mutation:
        // createMongodbSource(input: AddMosaicSourceInput!): MosaicAsyncResponse!
        protected void InvokeMutationCreateMongodbSource()
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
            string document = Mutation.CreateMongodbSource(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.CreateMongodbSource");
            var parameters = "($input: AddMosaicSourceInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationCreateMongodbSource" + parameters + "{" + document + "}",
                OperationName = "MutationCreateMongodbSource",
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
        // updateMongodbSource(input: ModifyMosaicSourceInput!): MosaicAsyncResponse!
        protected void InvokeMutationUpdateMongodbSource()
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
            string document = Mutation.UpdateMongodbSource(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.UpdateMongodbSource");
            var parameters = "($input: ModifyMosaicSourceInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationUpdateMongodbSource" + parameters + "{" + document + "}",
                OperationName = "MutationUpdateMongodbSource",
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
        // deleteMongodbSource(input: DeleteMosaicSourceInput!): MosaicAsyncResponse!
        protected void InvokeMutationDeleteMongodbSource()
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
            string document = Mutation.DeleteMongodbSource(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.DeleteMongodbSource");
            var parameters = "($input: DeleteMosaicSourceInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationDeleteMongodbSource" + parameters + "{" + document + "}",
                OperationName = "MutationDeleteMongodbSource",
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
        // bulkDeleteMongodbSources(input: BulkDeleteMosaicSourcesInput!): MosaicAsyncResponse!
        protected void InvokeMutationBulkDeleteMongodbSources()
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
            string document = Mutation.BulkDeleteMongodbSources(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.BulkDeleteMongodbSources");
            var parameters = "($input: BulkDeleteMosaicSourcesInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationBulkDeleteMongodbSources" + parameters + "{" + document + "}",
                OperationName = "MutationBulkDeleteMongodbSources",
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
        // recoverMongodbSource(input: MosaicRestoreDataInput!): MosaicAsyncResponse!
        protected void InvokeMutationRecoverMongodbSource()
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
            string document = Mutation.RecoverMongodbSource(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.RecoverMongodbSource");
            var parameters = "($input: MosaicRestoreDataInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationRecoverMongodbSource" + parameters + "{" + document + "}",
                OperationName = "MutationRecoverMongodbSource",
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


    } // class Invoke_RscMutateMongo
}