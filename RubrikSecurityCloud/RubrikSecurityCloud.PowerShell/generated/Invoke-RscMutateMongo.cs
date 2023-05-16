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
using Rubrik.SecurityCloud.NetSDK.Library.HelperClasses;
using GraphQL;

namespace Rubrik.SecurityCloud.PowerShell.Cmdlets
{
    [Cmdlet(
        "Invoke",
        "RscMutateMongo",
        DefaultParameterSetName = "addSource")
    ]
    public class Invoke_RscMutateMongo : RscPSCmdlet
    {
        
        // -------------------------------------------------------------------
        // addSource parameter set
        //
        // GraphQL operation: addMongoSource(input: AddMongoSourceInput!):AddMongoSourceReply!
        //
        [Parameter(
            ParameterSetName = "addSource",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Add a new MongoDB source

Supported in v8.1+
Adds a new MongoDB source to the Rubrik Cluster.
                GraphQL operation: addMongoSource(input: AddMongoSourceInput!):AddMongoSourceReply!
                ",
            Position = 0
        )]
        public SwitchParameter addSource { get; set; }

        [Parameter(
            ParameterSetName = "addSource",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Input for V1AddMongoSource.
                GraphQL argument input: AddMongoSourceInput!
                "
        )]
        public AddMongoSourceInput? Input { get; set; }
        
        // -------------------------------------------------------------------
        // deleteSource parameter set
        //
        // GraphQL operation: deleteMongoSource(input: DeleteMongoSourceInput!):AsyncRequestStatus!
        //
        [Parameter(
            ParameterSetName = "deleteSource",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Delete a MongoDB source

Supported in v8.1+
Deletes a specific MongoDB source.
                GraphQL operation: deleteMongoSource(input: DeleteMongoSourceInput!):AsyncRequestStatus!
                ",
            Position = 0
        )]
        public SwitchParameter deleteSource { get; set; }

        
        // -------------------------------------------------------------------
        // discoverSource parameter set
        //
        // GraphQL operation: discoverMongoSource(input: DiscoverMongoSourceInput!):AsyncRequestStatus!
        //
        [Parameter(
            ParameterSetName = "discoverSource",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Discover a MongoDB source on-demand

Supported in v8.1+
Initiates an on-demand job to discover a MongoDB source.
                GraphQL operation: discoverMongoSource(input: DiscoverMongoSourceInput!):AsyncRequestStatus!
                ",
            Position = 0
        )]
        public SwitchParameter discoverSource { get; set; }

        
        // -------------------------------------------------------------------
        // patchSource parameter set
        //
        // GraphQL operation: patchMongoSource(input: PatchMongoSourceInput!):AsyncRequestStatus!
        //
        [Parameter(
            ParameterSetName = "patchSource",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Edit a MongoDB source

Supported in v8.1+
Edits the properties of a MongoDB source. Hosts, name, and type of MongoDB cannot be changed once added.
                GraphQL operation: patchMongoSource(input: PatchMongoSourceInput!):AsyncRequestStatus!
                ",
            Position = 0
        )]
        public SwitchParameter patchSource { get; set; }

        
        // -------------------------------------------------------------------
        // retryAddSource parameter set
        //
        // GraphQL operation: retryAddMongoSource(input: RetryAddMongoSourceInput!):AsyncRequestStatus!
        //
        [Parameter(
            ParameterSetName = "retryAddSource",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Update a MongoDB source

Supported in v8.1+
Updates a MongoDB source details. You can use this endpoint for updating MongoDB source details when the request to add a source fails.
                GraphQL operation: retryAddMongoSource(input: RetryAddMongoSourceInput!):AsyncRequestStatus!
                ",
            Position = 0
        )]
        public SwitchParameter retryAddSource { get; set; }

        
        // -------------------------------------------------------------------
        // assignSlaToDbCollection parameter set
        //
        // GraphQL operation: assignSlaToMongoDbCollection(input: AssignSlaToMongoDbCollectionInput!):AsyncRequestStatus!
        //
        [Parameter(
            ParameterSetName = "assignSlaToDbCollection",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Assign SLA Domain to MongoDB collection objects

Supported in v8.1+
Assigns SLA Domain to the given MongoDB collection objects.
                GraphQL operation: assignSlaToMongoDbCollection(input: AssignSlaToMongoDbCollectionInput!):AsyncRequestStatus!
                ",
            Position = 0
        )]
        public SwitchParameter assignSlaToDbCollection { get; set; }

        
        // -------------------------------------------------------------------
        // recoverSource parameter set
        //
        // GraphQL operation: recoverMongoSource(input: RecoverMongoSourceInput!):AsyncRequestStatus!
        //
        [Parameter(
            ParameterSetName = "recoverSource",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Recover a MongoDB source from Rubrik CDM cluster.
                GraphQL operation: recoverMongoSource(input: RecoverMongoSourceInput!):AsyncRequestStatus!
                ",
            Position = 0
        )]
        public SwitchParameter recoverSource { get; set; }

        
        // -------------------------------------------------------------------
        // createdbSource parameter set
        //
        // GraphQL operation: createMongodbSource(input: AddMosaicSourceInput!):MosaicAsyncResponse!
        //
        [Parameter(
            ParameterSetName = "createdbSource",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Register a new MongoDB source to NoSQL cluster. 
For MongoDB, the term ""source"" is usually used for either a replica set or a sharded cluster.
For more info on MongoDB cluster, refer to: https://docs.mongodb.com/manual/introduction/.
                GraphQL operation: createMongodbSource(input: AddMosaicSourceInput!):MosaicAsyncResponse!
                ",
            Position = 0
        )]
        public SwitchParameter createdbSource { get; set; }

        
        // -------------------------------------------------------------------
        // updatedbSource parameter set
        //
        // GraphQL operation: updateMongodbSource(input: ModifyMosaicSourceInput!):MosaicAsyncResponse!
        //
        [Parameter(
            ParameterSetName = "updatedbSource",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Modifies configuration for a registered MongoDB source in NoSQL cluster.
                GraphQL operation: updateMongodbSource(input: ModifyMosaicSourceInput!):MosaicAsyncResponse!
                ",
            Position = 0
        )]
        public SwitchParameter updatedbSource { get; set; }

        
        // -------------------------------------------------------------------
        // deletedbSource parameter set
        //
        // GraphQL operation: deleteMongodbSource(input: DeleteMosaicSourceInput!):MosaicAsyncResponse!
        //
        [Parameter(
            ParameterSetName = "deletedbSource",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Remove a registered MongoDB source from NoSQL cluster.
                GraphQL operation: deleteMongodbSource(input: DeleteMosaicSourceInput!):MosaicAsyncResponse!
                ",
            Position = 0
        )]
        public SwitchParameter deletedbSource { get; set; }

        
        // -------------------------------------------------------------------
        // bulkDeletedbSource parameter set
        //
        // GraphQL operation: bulkDeleteMongodbSources(input: BulkDeleteMosaicSourcesInput!):MosaicAsyncResponse!
        //
        [Parameter(
            ParameterSetName = "bulkDeletedbSource",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Bulk Delete Sources

Supported in m3.2.0-m4.2.0.
                GraphQL operation: bulkDeleteMongodbSources(input: BulkDeleteMosaicSourcesInput!):MosaicAsyncResponse!
                ",
            Position = 0
        )]
        public SwitchParameter bulkDeletedbSource { get; set; }

        
        // -------------------------------------------------------------------
        // recoverdbSource parameter set
        //
        // GraphQL operation: recoverMongodbSource(input: MosaicRestoreDataInput!):MosaicAsyncResponse!
        //
        [Parameter(
            ParameterSetName = "recoverdbSource",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Recover a MongoDB source from NoSQL cluster.
                GraphQL operation: recoverMongodbSource(input: MosaicRestoreDataInput!):MosaicAsyncResponse!
                ",
            Position = 0
        )]
        public SwitchParameter recoverdbSource { get; set; }


        protected override void ProcessRecord()
        {
            try
            {
                switch(Op)
                {
                    case "addSource":
                        this.ProcessRecord_addSource();
                        break;
                    case "deleteSource":
                        this.ProcessRecord_deleteSource();
                        break;
                    case "discoverSource":
                        this.ProcessRecord_discoverSource();
                        break;
                    case "patchSource":
                        this.ProcessRecord_patchSource();
                        break;
                    case "retryAddSource":
                        this.ProcessRecord_retryAddSource();
                        break;
                    case "assignSlaToDbCollection":
                        this.ProcessRecord_assignSlaToDbCollection();
                        break;
                    case "recoverSource":
                        this.ProcessRecord_recoverSource();
                        break;
                    case "createdbSource":
                        this.ProcessRecord_createdbSource();
                        break;
                    case "updatedbSource":
                        this.ProcessRecord_updatedbSource();
                        break;
                    case "deletedbSource":
                        this.ProcessRecord_deletedbSource();
                        break;
                    case "bulkDeletedbSource":
                        this.ProcessRecord_bulkDeletedbSource();
                        break;
                    case "recoverdbSource":
                        this.ProcessRecord_recoverdbSource();
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
                    "Invoke-RscMutateMongo",
                    ErrorCategory.InvalidOperation,
                    null);
                ThrowTerminatingError(error);
           }
        }

        // This parameter set invokes a single graphql operation:
        // addMongoSource.
        protected void ProcessRecord_addSource()
        {
            this._logger.name += " -addSource";
            // Invoke graphql operation addMongoSource
            InvokeMutationAddMongoSource();
        }

        // This parameter set invokes a single graphql operation:
        // deleteMongoSource.
        protected void ProcessRecord_deleteSource()
        {
            this._logger.name += " -deleteSource";
            // Invoke graphql operation deleteMongoSource
            InvokeMutationDeleteMongoSource();
        }

        // This parameter set invokes a single graphql operation:
        // discoverMongoSource.
        protected void ProcessRecord_discoverSource()
        {
            this._logger.name += " -discoverSource";
            // Invoke graphql operation discoverMongoSource
            InvokeMutationDiscoverMongoSource();
        }

        // This parameter set invokes a single graphql operation:
        // patchMongoSource.
        protected void ProcessRecord_patchSource()
        {
            this._logger.name += " -patchSource";
            // Invoke graphql operation patchMongoSource
            InvokeMutationPatchMongoSource();
        }

        // This parameter set invokes a single graphql operation:
        // retryAddMongoSource.
        protected void ProcessRecord_retryAddSource()
        {
            this._logger.name += " -retryAddSource";
            // Invoke graphql operation retryAddMongoSource
            InvokeMutationRetryAddMongoSource();
        }

        // This parameter set invokes a single graphql operation:
        // assignSlaToMongoDbCollection.
        protected void ProcessRecord_assignSlaToDbCollection()
        {
            this._logger.name += " -assignSlaToDbCollection";
            // Invoke graphql operation assignSlaToMongoDbCollection
            InvokeMutationAssignSlaToMongoDbCollection();
        }

        // This parameter set invokes a single graphql operation:
        // recoverMongoSource.
        protected void ProcessRecord_recoverSource()
        {
            this._logger.name += " -recoverSource";
            // Invoke graphql operation recoverMongoSource
            InvokeMutationRecoverMongoSource();
        }

        // This parameter set invokes a single graphql operation:
        // createMongodbSource.
        protected void ProcessRecord_createdbSource()
        {
            this._logger.name += " -createdbSource";
            // Invoke graphql operation createMongodbSource
            InvokeMutationCreateMongodbSource();
        }

        // This parameter set invokes a single graphql operation:
        // updateMongodbSource.
        protected void ProcessRecord_updatedbSource()
        {
            this._logger.name += " -updatedbSource";
            // Invoke graphql operation updateMongodbSource
            InvokeMutationUpdateMongodbSource();
        }

        // This parameter set invokes a single graphql operation:
        // deleteMongodbSource.
        protected void ProcessRecord_deletedbSource()
        {
            this._logger.name += " -deletedbSource";
            // Invoke graphql operation deleteMongodbSource
            InvokeMutationDeleteMongodbSource();
        }

        // This parameter set invokes a single graphql operation:
        // bulkDeleteMongodbSources.
        protected void ProcessRecord_bulkDeletedbSource()
        {
            this._logger.name += " -bulkDeletedbSource";
            // Invoke graphql operation bulkDeleteMongodbSources
            InvokeMutationBulkDeleteMongodbSources();
        }

        // This parameter set invokes a single graphql operation:
        // recoverMongodbSource.
        protected void ProcessRecord_recoverdbSource()
        {
            this._logger.name += " -recoverdbSource";
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (AddMongoSourceReply)psObject.BaseObject;
                } else {
                    fields = (AddMongoSourceReply)this.Field;
                }
            }
            string document = Mutation.AddMongoSource(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.AddMongoSource");
            string parameters = "($input: AddMongoSourceInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationAddMongoSource" + parameters + "{" + document + "}",
                OperationName = "MutationAddMongoSource",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<AddMongoSourceReply> task = this._rbkClient.InvokeGenericCallAsync<AddMongoSourceReply>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (AsyncRequestStatus)psObject.BaseObject;
                } else {
                    fields = (AsyncRequestStatus)this.Field;
                }
            }
            string document = Mutation.DeleteMongoSource(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.DeleteMongoSource");
            string parameters = "($input: DeleteMongoSourceInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationDeleteMongoSource" + parameters + "{" + document + "}",
                OperationName = "MutationDeleteMongoSource",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<AsyncRequestStatus> task = this._rbkClient.InvokeGenericCallAsync<AsyncRequestStatus>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (AsyncRequestStatus)psObject.BaseObject;
                } else {
                    fields = (AsyncRequestStatus)this.Field;
                }
            }
            string document = Mutation.DiscoverMongoSource(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.DiscoverMongoSource");
            string parameters = "($input: DiscoverMongoSourceInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationDiscoverMongoSource" + parameters + "{" + document + "}",
                OperationName = "MutationDiscoverMongoSource",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<AsyncRequestStatus> task = this._rbkClient.InvokeGenericCallAsync<AsyncRequestStatus>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (AsyncRequestStatus)psObject.BaseObject;
                } else {
                    fields = (AsyncRequestStatus)this.Field;
                }
            }
            string document = Mutation.PatchMongoSource(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.PatchMongoSource");
            string parameters = "($input: PatchMongoSourceInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationPatchMongoSource" + parameters + "{" + document + "}",
                OperationName = "MutationPatchMongoSource",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<AsyncRequestStatus> task = this._rbkClient.InvokeGenericCallAsync<AsyncRequestStatus>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (AsyncRequestStatus)psObject.BaseObject;
                } else {
                    fields = (AsyncRequestStatus)this.Field;
                }
            }
            string document = Mutation.RetryAddMongoSource(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.RetryAddMongoSource");
            string parameters = "($input: RetryAddMongoSourceInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationRetryAddMongoSource" + parameters + "{" + document + "}",
                OperationName = "MutationRetryAddMongoSource",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<AsyncRequestStatus> task = this._rbkClient.InvokeGenericCallAsync<AsyncRequestStatus>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (AsyncRequestStatus)psObject.BaseObject;
                } else {
                    fields = (AsyncRequestStatus)this.Field;
                }
            }
            string document = Mutation.AssignSlaToMongoDbCollection(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.AssignSlaToMongoDbCollection");
            string parameters = "($input: AssignSlaToMongoDbCollectionInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationAssignSlaToMongoDbCollection" + parameters + "{" + document + "}",
                OperationName = "MutationAssignSlaToMongoDbCollection",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<AsyncRequestStatus> task = this._rbkClient.InvokeGenericCallAsync<AsyncRequestStatus>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (AsyncRequestStatus)psObject.BaseObject;
                } else {
                    fields = (AsyncRequestStatus)this.Field;
                }
            }
            string document = Mutation.RecoverMongoSource(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.RecoverMongoSource");
            string parameters = "($input: RecoverMongoSourceInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationRecoverMongoSource" + parameters + "{" + document + "}",
                OperationName = "MutationRecoverMongoSource",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<AsyncRequestStatus> task = this._rbkClient.InvokeGenericCallAsync<AsyncRequestStatus>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (MosaicAsyncResponse)psObject.BaseObject;
                } else {
                    fields = (MosaicAsyncResponse)this.Field;
                }
            }
            string document = Mutation.CreateMongodbSource(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.CreateMongodbSource");
            string parameters = "($input: AddMosaicSourceInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationCreateMongodbSource" + parameters + "{" + document + "}",
                OperationName = "MutationCreateMongodbSource",
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
        // updateMongodbSource(input: ModifyMosaicSourceInput!): MosaicAsyncResponse!
        protected void InvokeMutationUpdateMongodbSource()
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
            string document = Mutation.UpdateMongodbSource(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.UpdateMongodbSource");
            string parameters = "($input: ModifyMosaicSourceInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationUpdateMongodbSource" + parameters + "{" + document + "}",
                OperationName = "MutationUpdateMongodbSource",
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
        // deleteMongodbSource(input: DeleteMosaicSourceInput!): MosaicAsyncResponse!
        protected void InvokeMutationDeleteMongodbSource()
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
            string document = Mutation.DeleteMongodbSource(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.DeleteMongodbSource");
            string parameters = "($input: DeleteMosaicSourceInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationDeleteMongodbSource" + parameters + "{" + document + "}",
                OperationName = "MutationDeleteMongodbSource",
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
        // bulkDeleteMongodbSources(input: BulkDeleteMosaicSourcesInput!): MosaicAsyncResponse!
        protected void InvokeMutationBulkDeleteMongodbSources()
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
            string document = Mutation.BulkDeleteMongodbSources(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.BulkDeleteMongodbSources");
            string parameters = "($input: BulkDeleteMosaicSourcesInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationBulkDeleteMongodbSources" + parameters + "{" + document + "}",
                OperationName = "MutationBulkDeleteMongodbSources",
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
        // recoverMongodbSource(input: MosaicRestoreDataInput!): MosaicAsyncResponse!
        protected void InvokeMutationRecoverMongodbSource()
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
            string document = Mutation.RecoverMongodbSource(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.RecoverMongodbSource");
            string parameters = "($input: MosaicRestoreDataInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationRecoverMongodbSource" + parameters + "{" + document + "}",
                OperationName = "MutationRecoverMongodbSource",
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


    } // class Invoke_RscMutateMongo
}