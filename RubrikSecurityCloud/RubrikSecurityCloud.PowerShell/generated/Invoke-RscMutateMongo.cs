// Invoke-RscMutateMongo.cs
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
        "RscMutateMongo",
        DefaultParameterSetName = "AddSource")
    ]
    public class Invoke_RscMutateMongo : RscPSCmdlet
    {
        
        // -------------------------------------------------------------------
        // AddSource parameter set
        //
        // [GraphQL: addMongoSource]
        //
        [Parameter(
            ParameterSetName = "AddSource",
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
        public SwitchParameter AddSource { get; set; }

        
        // -------------------------------------------------------------------
        // DeleteSource parameter set
        //
        // [GraphQL: deleteMongoSource]
        //
        [Parameter(
            ParameterSetName = "DeleteSource",
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
        public SwitchParameter DeleteSource { get; set; }

        
        // -------------------------------------------------------------------
        // DiscoverSource parameter set
        //
        // [GraphQL: discoverMongoSource]
        //
        [Parameter(
            ParameterSetName = "DiscoverSource",
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
        public SwitchParameter DiscoverSource { get; set; }

        
        // -------------------------------------------------------------------
        // PatchSource parameter set
        //
        // [GraphQL: patchMongoSource]
        //
        [Parameter(
            ParameterSetName = "PatchSource",
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
        public SwitchParameter PatchSource { get; set; }

        
        // -------------------------------------------------------------------
        // RetryAddSource parameter set
        //
        // [GraphQL: retryAddMongoSource]
        //
        [Parameter(
            ParameterSetName = "RetryAddSource",
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
        public SwitchParameter RetryAddSource { get; set; }

        
        // -------------------------------------------------------------------
        // AssignSlaToDbCollection parameter set
        //
        // [GraphQL: assignSlaToMongoDbCollection]
        //
        [Parameter(
            ParameterSetName = "AssignSlaToDbCollection",
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
        public SwitchParameter AssignSlaToDbCollection { get; set; }

        
        // -------------------------------------------------------------------
        // RecoverSource parameter set
        //
        // [GraphQL: recoverMongoSource]
        //
        [Parameter(
            ParameterSetName = "RecoverSource",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Recover a MongoDB source from Rubrik CDM cluster.
[GraphQL: recoverMongoSource]",
            Position = 0
        )]
        public SwitchParameter RecoverSource { get; set; }

        
        // -------------------------------------------------------------------
        // CreatedbSource parameter set
        //
        // [GraphQL: createMongodbSource]
        //
        [Parameter(
            ParameterSetName = "CreatedbSource",
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
        public SwitchParameter CreatedbSource { get; set; }

        
        // -------------------------------------------------------------------
        // UpdatedbSource parameter set
        //
        // [GraphQL: updateMongodbSource]
        //
        [Parameter(
            ParameterSetName = "UpdatedbSource",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Modifies configuration for a registered MongoDB source in NoSQL cluster.
[GraphQL: updateMongodbSource]",
            Position = 0
        )]
        public SwitchParameter UpdatedbSource { get; set; }

        
        // -------------------------------------------------------------------
        // DeletedbSource parameter set
        //
        // [GraphQL: deleteMongodbSource]
        //
        [Parameter(
            ParameterSetName = "DeletedbSource",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Remove a registered MongoDB source from NoSQL cluster.
[GraphQL: deleteMongodbSource]",
            Position = 0
        )]
        public SwitchParameter DeletedbSource { get; set; }

        
        // -------------------------------------------------------------------
        // BulkDeletedbSource parameter set
        //
        // [GraphQL: bulkDeleteMongodbSources]
        //
        [Parameter(
            ParameterSetName = "BulkDeletedbSource",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Bulk Delete Sources

Supported in m3.2.0-m4.2.0.
[GraphQL: bulkDeleteMongodbSources]",
            Position = 0
        )]
        public SwitchParameter BulkDeletedbSource { get; set; }

        
        // -------------------------------------------------------------------
        // RecoverdbSource parameter set
        //
        // [GraphQL: recoverMongodbSource]
        //
        [Parameter(
            ParameterSetName = "RecoverdbSource",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Recover a MongoDB source from NoSQL cluster.
[GraphQL: recoverMongodbSource]",
            Position = 0
        )]
        public SwitchParameter RecoverdbSource { get; set; }


        protected override void ProcessRecord()
        {
            try
            {
                switch(Op)
                {
                    case "AddSource":
                        this.ProcessRecord_AddSource();
                        break;
                    case "DeleteSource":
                        this.ProcessRecord_DeleteSource();
                        break;
                    case "DiscoverSource":
                        this.ProcessRecord_DiscoverSource();
                        break;
                    case "PatchSource":
                        this.ProcessRecord_PatchSource();
                        break;
                    case "RetryAddSource":
                        this.ProcessRecord_RetryAddSource();
                        break;
                    case "AssignSlaToDbCollection":
                        this.ProcessRecord_AssignSlaToDbCollection();
                        break;
                    case "RecoverSource":
                        this.ProcessRecord_RecoverSource();
                        break;
                    case "CreatedbSource":
                        this.ProcessRecord_CreatedbSource();
                        break;
                    case "UpdatedbSource":
                        this.ProcessRecord_UpdatedbSource();
                        break;
                    case "DeletedbSource":
                        this.ProcessRecord_DeletedbSource();
                        break;
                    case "BulkDeletedbSource":
                        this.ProcessRecord_BulkDeletedbSource();
                        break;
                    case "RecoverdbSource":
                        this.ProcessRecord_RecoverdbSource();
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
        protected void ProcessRecord_AddSource()
        {
            this._logger.name += " -AddSource";
            // Invoke graphql operation addMongoSource
            InvokeMutationAddMongoSource();
        }

        // This parameter set invokes a single graphql operation:
        // deleteMongoSource.
        protected void ProcessRecord_DeleteSource()
        {
            this._logger.name += " -DeleteSource";
            // Invoke graphql operation deleteMongoSource
            InvokeMutationDeleteMongoSource();
        }

        // This parameter set invokes a single graphql operation:
        // discoverMongoSource.
        protected void ProcessRecord_DiscoverSource()
        {
            this._logger.name += " -DiscoverSource";
            // Invoke graphql operation discoverMongoSource
            InvokeMutationDiscoverMongoSource();
        }

        // This parameter set invokes a single graphql operation:
        // patchMongoSource.
        protected void ProcessRecord_PatchSource()
        {
            this._logger.name += " -PatchSource";
            // Invoke graphql operation patchMongoSource
            InvokeMutationPatchMongoSource();
        }

        // This parameter set invokes a single graphql operation:
        // retryAddMongoSource.
        protected void ProcessRecord_RetryAddSource()
        {
            this._logger.name += " -RetryAddSource";
            // Invoke graphql operation retryAddMongoSource
            InvokeMutationRetryAddMongoSource();
        }

        // This parameter set invokes a single graphql operation:
        // assignSlaToMongoDbCollection.
        protected void ProcessRecord_AssignSlaToDbCollection()
        {
            this._logger.name += " -AssignSlaToDbCollection";
            // Invoke graphql operation assignSlaToMongoDbCollection
            InvokeMutationAssignSlaToMongoDbCollection();
        }

        // This parameter set invokes a single graphql operation:
        // recoverMongoSource.
        protected void ProcessRecord_RecoverSource()
        {
            this._logger.name += " -RecoverSource";
            // Invoke graphql operation recoverMongoSource
            InvokeMutationRecoverMongoSource();
        }

        // This parameter set invokes a single graphql operation:
        // createMongodbSource.
        protected void ProcessRecord_CreatedbSource()
        {
            this._logger.name += " -CreatedbSource";
            // Invoke graphql operation createMongodbSource
            InvokeMutationCreateMongodbSource();
        }

        // This parameter set invokes a single graphql operation:
        // updateMongodbSource.
        protected void ProcessRecord_UpdatedbSource()
        {
            this._logger.name += " -UpdatedbSource";
            // Invoke graphql operation updateMongodbSource
            InvokeMutationUpdateMongodbSource();
        }

        // This parameter set invokes a single graphql operation:
        // deleteMongodbSource.
        protected void ProcessRecord_DeletedbSource()
        {
            this._logger.name += " -DeletedbSource";
            // Invoke graphql operation deleteMongodbSource
            InvokeMutationDeleteMongodbSource();
        }

        // This parameter set invokes a single graphql operation:
        // bulkDeleteMongodbSources.
        protected void ProcessRecord_BulkDeletedbSource()
        {
            this._logger.name += " -BulkDeletedbSource";
            // Invoke graphql operation bulkDeleteMongodbSources
            InvokeMutationBulkDeleteMongodbSources();
        }

        // This parameter set invokes a single graphql operation:
        // recoverMongodbSource.
        protected void ProcessRecord_RecoverdbSource()
        {
            this._logger.name += " -RecoverdbSource";
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
            var vars = new OperationVariableSet();
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
            var vars = new OperationVariableSet();
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
            var vars = new OperationVariableSet();
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
            var vars = new OperationVariableSet();
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
            var vars = new OperationVariableSet();
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
            var vars = new OperationVariableSet();
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
            var vars = new OperationVariableSet();
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


    } // class Invoke_RscMutateMongo
}