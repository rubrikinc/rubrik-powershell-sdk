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
        
        /// <summary>
        /// RecoverSource parameter set
        ///
        /// [GraphQL: recoverCassandraSource]
        /// </summary>
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

        
        /// <summary>
        /// CreateSource parameter set
        ///
        /// [GraphQL: createCassandraSource]
        /// </summary>
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

        
        /// <summary>
        /// UpdateSource parameter set
        ///
        /// [GraphQL: updateCassandraSource]
        /// </summary>
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

        
        /// <summary>
        /// DeleteSource parameter set
        ///
        /// [GraphQL: deleteCassandraSource]
        /// </summary>
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

        
        /// <summary>
        /// BulkDeleteSources parameter set
        ///
        /// [GraphQL: bulkDeleteCassandraSources]
        /// </summary>
        [Parameter(
            ParameterSetName = "BulkDeleteSources",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Bulk Delete cassandra sources.
[GraphQL: bulkDeleteCassandraSources]",
            Position = 0
        )]
        public SwitchParameter BulkDeleteSources { get; set; }


// ignore warning 'Missing XML comment'
#pragma warning disable 1591
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
                    case "BulkDeleteSources":
                        this.ProcessRecord_BulkDeleteSources();
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
        // recoverCassandraSource.
        internal void ProcessRecord_RecoverSource()
        {
            this._logger.name += " -RecoverSource";
            // Invoke graphql operation recoverCassandraSource
            InvokeMutationRecoverCassandraSource();
        }

        // This parameter set invokes a single graphql operation:
        // createCassandraSource.
        internal void ProcessRecord_CreateSource()
        {
            this._logger.name += " -CreateSource";
            // Invoke graphql operation createCassandraSource
            InvokeMutationCreateCassandraSource();
        }

        // This parameter set invokes a single graphql operation:
        // updateCassandraSource.
        internal void ProcessRecord_UpdateSource()
        {
            this._logger.name += " -UpdateSource";
            // Invoke graphql operation updateCassandraSource
            InvokeMutationUpdateCassandraSource();
        }

        // This parameter set invokes a single graphql operation:
        // deleteCassandraSource.
        internal void ProcessRecord_DeleteSource()
        {
            this._logger.name += " -DeleteSource";
            // Invoke graphql operation deleteCassandraSource
            InvokeMutationDeleteCassandraSource();
        }

        // This parameter set invokes a single graphql operation:
        // bulkDeleteCassandraSources.
        internal void ProcessRecord_BulkDeleteSources()
        {
            this._logger.name += " -BulkDeleteSources";
            // Invoke graphql operation bulkDeleteCassandraSources
            InvokeMutationBulkDeleteCassandraSources();
        }


        // Invoke GraphQL Mutation:
        // recoverCassandraSource(input: MosaicRestoreDataInput!): MosaicAsyncResponse!
        internal void InvokeMutationRecoverCassandraSource()
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
            string fieldSpecDoc = Mutation.RecoverCassandraSource(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationRecoverCassandraSource",
                "($input: MosaicRestoreDataInput!)",
                fieldSpecDoc,
                "MosaicAsyncResponse"
            );
        }

        // Invoke GraphQL Mutation:
        // createCassandraSource(input: AddMosaicSourceInput!): MosaicAsyncResponse!
        internal void InvokeMutationCreateCassandraSource()
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
            string fieldSpecDoc = Mutation.CreateCassandraSource(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationCreateCassandraSource",
                "($input: AddMosaicSourceInput!)",
                fieldSpecDoc,
                "MosaicAsyncResponse"
            );
        }

        // Invoke GraphQL Mutation:
        // updateCassandraSource(input: ModifyMosaicSourceInput!): MosaicAsyncResponse!
        internal void InvokeMutationUpdateCassandraSource()
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
            string fieldSpecDoc = Mutation.UpdateCassandraSource(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationUpdateCassandraSource",
                "($input: ModifyMosaicSourceInput!)",
                fieldSpecDoc,
                "MosaicAsyncResponse"
            );
        }

        // Invoke GraphQL Mutation:
        // deleteCassandraSource(input: DeleteMosaicSourceInput!): MosaicAsyncResponse!
        internal void InvokeMutationDeleteCassandraSource()
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
            string fieldSpecDoc = Mutation.DeleteCassandraSource(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationDeleteCassandraSource",
                "($input: DeleteMosaicSourceInput!)",
                fieldSpecDoc,
                "MosaicAsyncResponse"
            );
        }

        // Invoke GraphQL Mutation:
        // bulkDeleteCassandraSources(input: BulkDeleteMosaicSourcesInput!): MosaicAsyncResponse!
        internal void InvokeMutationBulkDeleteCassandraSources()
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
            string fieldSpecDoc = Mutation.BulkDeleteCassandraSources(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationBulkDeleteCassandraSources",
                "($input: BulkDeleteMosaicSourcesInput!)",
                fieldSpecDoc,
                "MosaicAsyncResponse"
            );
        }


    } // class Invoke_RscMutateCassandra
}