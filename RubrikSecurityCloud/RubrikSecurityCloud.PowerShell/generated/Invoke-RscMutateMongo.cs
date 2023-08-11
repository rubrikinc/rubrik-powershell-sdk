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
        
        /// <summary>
        /// AddSource parameter set
        ///
        /// [GraphQL: addMongoSource]
        /// </summary>
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

        
        /// <summary>
        /// DeleteSource parameter set
        ///
        /// [GraphQL: deleteMongoSource]
        /// </summary>
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

        
        /// <summary>
        /// DiscoverSource parameter set
        ///
        /// [GraphQL: discoverMongoSource]
        /// </summary>
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

        
        /// <summary>
        /// PatchSource parameter set
        ///
        /// [GraphQL: patchMongoSource]
        /// </summary>
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

        
        /// <summary>
        /// RetryAddSource parameter set
        ///
        /// [GraphQL: retryAddMongoSource]
        /// </summary>
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

        
        /// <summary>
        /// AssignSlaToDbCollection parameter set
        ///
        /// [GraphQL: assignSlaToMongoDbCollection]
        /// </summary>
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

        
        /// <summary>
        /// RecoverSource parameter set
        ///
        /// [GraphQL: recoverMongoSource]
        /// </summary>
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

        
        /// <summary>
        /// CreateOnDemandDatabaseBackup parameter set
        ///
        /// [GraphQL: createOnDemandMongoDatabaseBackup]
        /// </summary>
        [Parameter(
            ParameterSetName = "CreateOnDemandDatabaseBackup",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Take an on-demand snapshot for a MongoDB database

Supported in v9.1
Initiates a job to take an on-demand, full or incremental snapshot of the specified MongoDB database.
[GraphQL: createOnDemandMongoDatabaseBackup]",
            Position = 0
        )]
        public SwitchParameter CreateOnDemandDatabaseBackup { get; set; }

        
        /// <summary>
        /// CreatedbSource parameter set
        ///
        /// [GraphQL: createMongodbSource]
        /// </summary>
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

        
        /// <summary>
        /// UpdatedbSource parameter set
        ///
        /// [GraphQL: updateMongodbSource]
        /// </summary>
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

        
        /// <summary>
        /// DeletedbSource parameter set
        ///
        /// [GraphQL: deleteMongodbSource]
        /// </summary>
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

        
        /// <summary>
        /// BulkDeletedbSources parameter set
        ///
        /// [GraphQL: bulkDeleteMongodbSources]
        /// </summary>
        [Parameter(
            ParameterSetName = "BulkDeletedbSources",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Bulk Delete Sources

Supported in m3.2.0-m4.2.0.
[GraphQL: bulkDeleteMongodbSources]",
            Position = 0
        )]
        public SwitchParameter BulkDeletedbSources { get; set; }

        
        /// <summary>
        /// RecoverdbSource parameter set
        ///
        /// [GraphQL: recoverMongodbSource]
        /// </summary>
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


// ignore warning 'Missing XML comment'
#pragma warning disable 1591
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
                    case "CreateOnDemandDatabaseBackup":
                        this.ProcessRecord_CreateOnDemandDatabaseBackup();
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
                    case "BulkDeletedbSources":
                        this.ProcessRecord_BulkDeletedbSources();
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
#pragma warning restore 1591

        // This parameter set invokes a single graphql operation:
        // addMongoSource.
        internal void ProcessRecord_AddSource()
        {
            this._logger.name += " -AddSource";
            // Invoke graphql operation addMongoSource
            InvokeMutationAddMongoSource();
        }

        // This parameter set invokes a single graphql operation:
        // deleteMongoSource.
        internal void ProcessRecord_DeleteSource()
        {
            this._logger.name += " -DeleteSource";
            // Invoke graphql operation deleteMongoSource
            InvokeMutationDeleteMongoSource();
        }

        // This parameter set invokes a single graphql operation:
        // discoverMongoSource.
        internal void ProcessRecord_DiscoverSource()
        {
            this._logger.name += " -DiscoverSource";
            // Invoke graphql operation discoverMongoSource
            InvokeMutationDiscoverMongoSource();
        }

        // This parameter set invokes a single graphql operation:
        // patchMongoSource.
        internal void ProcessRecord_PatchSource()
        {
            this._logger.name += " -PatchSource";
            // Invoke graphql operation patchMongoSource
            InvokeMutationPatchMongoSource();
        }

        // This parameter set invokes a single graphql operation:
        // retryAddMongoSource.
        internal void ProcessRecord_RetryAddSource()
        {
            this._logger.name += " -RetryAddSource";
            // Invoke graphql operation retryAddMongoSource
            InvokeMutationRetryAddMongoSource();
        }

        // This parameter set invokes a single graphql operation:
        // assignSlaToMongoDbCollection.
        internal void ProcessRecord_AssignSlaToDbCollection()
        {
            this._logger.name += " -AssignSlaToDbCollection";
            // Invoke graphql operation assignSlaToMongoDbCollection
            InvokeMutationAssignSlaToMongoDbCollection();
        }

        // This parameter set invokes a single graphql operation:
        // recoverMongoSource.
        internal void ProcessRecord_RecoverSource()
        {
            this._logger.name += " -RecoverSource";
            // Invoke graphql operation recoverMongoSource
            InvokeMutationRecoverMongoSource();
        }

        // This parameter set invokes a single graphql operation:
        // createOnDemandMongoDatabaseBackup.
        internal void ProcessRecord_CreateOnDemandDatabaseBackup()
        {
            this._logger.name += " -CreateOnDemandDatabaseBackup";
            // Invoke graphql operation createOnDemandMongoDatabaseBackup
            InvokeMutationCreateOnDemandMongoDatabaseBackup();
        }

        // This parameter set invokes a single graphql operation:
        // createMongodbSource.
        internal void ProcessRecord_CreatedbSource()
        {
            this._logger.name += " -CreatedbSource";
            // Invoke graphql operation createMongodbSource
            InvokeMutationCreateMongodbSource();
        }

        // This parameter set invokes a single graphql operation:
        // updateMongodbSource.
        internal void ProcessRecord_UpdatedbSource()
        {
            this._logger.name += " -UpdatedbSource";
            // Invoke graphql operation updateMongodbSource
            InvokeMutationUpdateMongodbSource();
        }

        // This parameter set invokes a single graphql operation:
        // deleteMongodbSource.
        internal void ProcessRecord_DeletedbSource()
        {
            this._logger.name += " -DeletedbSource";
            // Invoke graphql operation deleteMongodbSource
            InvokeMutationDeleteMongodbSource();
        }

        // This parameter set invokes a single graphql operation:
        // bulkDeleteMongodbSources.
        internal void ProcessRecord_BulkDeletedbSources()
        {
            this._logger.name += " -BulkDeletedbSources";
            // Invoke graphql operation bulkDeleteMongodbSources
            InvokeMutationBulkDeleteMongodbSources();
        }

        // This parameter set invokes a single graphql operation:
        // recoverMongodbSource.
        internal void ProcessRecord_RecoverdbSource()
        {
            this._logger.name += " -RecoverdbSource";
            // Invoke graphql operation recoverMongodbSource
            InvokeMutationRecoverMongodbSource();
        }


        // Invoke GraphQL Mutation:
        // addMongoSource(input: AddMongoSourceInput!): AddMongoSourceReply!
        internal void InvokeMutationAddMongoSource()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "AddMongoSourceInput!"),
            };
            AddMongoSourceReply? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (AddMongoSourceReply)psObject.BaseObject;
                } else {
                    fieldSpecObj = (AddMongoSourceReply)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.AddMongoSource(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationAddMongoSource",
                "($input: AddMongoSourceInput!)",
                fieldSpecDoc,
                "AddMongoSourceReply"
            );
        }

        // Invoke GraphQL Mutation:
        // deleteMongoSource(input: DeleteMongoSourceInput!): AsyncRequestStatus!
        internal void InvokeMutationDeleteMongoSource()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteMongoSourceInput!"),
            };
            AsyncRequestStatus? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (AsyncRequestStatus)psObject.BaseObject;
                } else {
                    fieldSpecObj = (AsyncRequestStatus)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.DeleteMongoSource(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationDeleteMongoSource",
                "($input: DeleteMongoSourceInput!)",
                fieldSpecDoc,
                "AsyncRequestStatus"
            );
        }

        // Invoke GraphQL Mutation:
        // discoverMongoSource(input: DiscoverMongoSourceInput!): AsyncRequestStatus!
        internal void InvokeMutationDiscoverMongoSource()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DiscoverMongoSourceInput!"),
            };
            AsyncRequestStatus? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (AsyncRequestStatus)psObject.BaseObject;
                } else {
                    fieldSpecObj = (AsyncRequestStatus)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.DiscoverMongoSource(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationDiscoverMongoSource",
                "($input: DiscoverMongoSourceInput!)",
                fieldSpecDoc,
                "AsyncRequestStatus"
            );
        }

        // Invoke GraphQL Mutation:
        // patchMongoSource(input: PatchMongoSourceInput!): AsyncRequestStatus!
        internal void InvokeMutationPatchMongoSource()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "PatchMongoSourceInput!"),
            };
            AsyncRequestStatus? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (AsyncRequestStatus)psObject.BaseObject;
                } else {
                    fieldSpecObj = (AsyncRequestStatus)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.PatchMongoSource(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationPatchMongoSource",
                "($input: PatchMongoSourceInput!)",
                fieldSpecDoc,
                "AsyncRequestStatus"
            );
        }

        // Invoke GraphQL Mutation:
        // retryAddMongoSource(input: RetryAddMongoSourceInput!): AsyncRequestStatus!
        internal void InvokeMutationRetryAddMongoSource()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "RetryAddMongoSourceInput!"),
            };
            AsyncRequestStatus? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (AsyncRequestStatus)psObject.BaseObject;
                } else {
                    fieldSpecObj = (AsyncRequestStatus)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.RetryAddMongoSource(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationRetryAddMongoSource",
                "($input: RetryAddMongoSourceInput!)",
                fieldSpecDoc,
                "AsyncRequestStatus"
            );
        }

        // Invoke GraphQL Mutation:
        // assignSlaToMongoDbCollection(input: AssignSlaToMongoDbCollectionInput!): AsyncRequestStatus!
        internal void InvokeMutationAssignSlaToMongoDbCollection()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "AssignSlaToMongoDbCollectionInput!"),
            };
            AsyncRequestStatus? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (AsyncRequestStatus)psObject.BaseObject;
                } else {
                    fieldSpecObj = (AsyncRequestStatus)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.AssignSlaToMongoDbCollection(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationAssignSlaToMongoDbCollection",
                "($input: AssignSlaToMongoDbCollectionInput!)",
                fieldSpecDoc,
                "AsyncRequestStatus"
            );
        }

        // Invoke GraphQL Mutation:
        // recoverMongoSource(input: RecoverMongoSourceInput!): AsyncRequestStatus!
        internal void InvokeMutationRecoverMongoSource()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "RecoverMongoSourceInput!"),
            };
            AsyncRequestStatus? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (AsyncRequestStatus)psObject.BaseObject;
                } else {
                    fieldSpecObj = (AsyncRequestStatus)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.RecoverMongoSource(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationRecoverMongoSource",
                "($input: RecoverMongoSourceInput!)",
                fieldSpecDoc,
                "AsyncRequestStatus"
            );
        }

        // Invoke GraphQL Mutation:
        // createOnDemandMongoDatabaseBackup(input: CreateOnDemandMongoDatabaseSnapshotInput!): AsyncRequestStatus!
        internal void InvokeMutationCreateOnDemandMongoDatabaseBackup()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateOnDemandMongoDatabaseSnapshotInput!"),
            };
            AsyncRequestStatus? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (AsyncRequestStatus)psObject.BaseObject;
                } else {
                    fieldSpecObj = (AsyncRequestStatus)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.CreateOnDemandMongoDatabaseBackup(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationCreateOnDemandMongoDatabaseBackup",
                "($input: CreateOnDemandMongoDatabaseSnapshotInput!)",
                fieldSpecDoc,
                "AsyncRequestStatus"
            );
        }

        // Invoke GraphQL Mutation:
        // createMongodbSource(input: AddMosaicSourceInput!): MosaicAsyncResponse!
        internal void InvokeMutationCreateMongodbSource()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "AddMosaicSourceInput!"),
            };
            MosaicAsyncResponse? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (MosaicAsyncResponse)psObject.BaseObject;
                } else {
                    fieldSpecObj = (MosaicAsyncResponse)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.CreateMongodbSource(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationCreateMongodbSource",
                "($input: AddMosaicSourceInput!)",
                fieldSpecDoc,
                "MosaicAsyncResponse"
            );
        }

        // Invoke GraphQL Mutation:
        // updateMongodbSource(input: ModifyMosaicSourceInput!): MosaicAsyncResponse!
        internal void InvokeMutationUpdateMongodbSource()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "ModifyMosaicSourceInput!"),
            };
            MosaicAsyncResponse? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (MosaicAsyncResponse)psObject.BaseObject;
                } else {
                    fieldSpecObj = (MosaicAsyncResponse)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.UpdateMongodbSource(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationUpdateMongodbSource",
                "($input: ModifyMosaicSourceInput!)",
                fieldSpecDoc,
                "MosaicAsyncResponse"
            );
        }

        // Invoke GraphQL Mutation:
        // deleteMongodbSource(input: DeleteMosaicSourceInput!): MosaicAsyncResponse!
        internal void InvokeMutationDeleteMongodbSource()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteMosaicSourceInput!"),
            };
            MosaicAsyncResponse? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (MosaicAsyncResponse)psObject.BaseObject;
                } else {
                    fieldSpecObj = (MosaicAsyncResponse)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.DeleteMongodbSource(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationDeleteMongodbSource",
                "($input: DeleteMosaicSourceInput!)",
                fieldSpecDoc,
                "MosaicAsyncResponse"
            );
        }

        // Invoke GraphQL Mutation:
        // bulkDeleteMongodbSources(input: BulkDeleteMosaicSourcesInput!): MosaicAsyncResponse!
        internal void InvokeMutationBulkDeleteMongodbSources()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "BulkDeleteMosaicSourcesInput!"),
            };
            MosaicAsyncResponse? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (MosaicAsyncResponse)psObject.BaseObject;
                } else {
                    fieldSpecObj = (MosaicAsyncResponse)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.BulkDeleteMongodbSources(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationBulkDeleteMongodbSources",
                "($input: BulkDeleteMosaicSourcesInput!)",
                fieldSpecDoc,
                "MosaicAsyncResponse"
            );
        }

        // Invoke GraphQL Mutation:
        // recoverMongodbSource(input: MosaicRestoreDataInput!): MosaicAsyncResponse!
        internal void InvokeMutationRecoverMongodbSource()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "MosaicRestoreDataInput!"),
            };
            MosaicAsyncResponse? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (MosaicAsyncResponse)psObject.BaseObject;
                } else {
                    fieldSpecObj = (MosaicAsyncResponse)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.RecoverMongodbSource(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationRecoverMongodbSource",
                "($input: MosaicRestoreDataInput!)",
                fieldSpecDoc,
                "MosaicAsyncResponse"
            );
        }


    } // class Invoke_RscMutateMongo
}