// Invoke-RscMutateCluster.cs
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
        "RscMutateCluster",
        DefaultParameterSetName = "AddK8s")
    ]
    public class Invoke_RscMutateCluster : RscPSCmdlet
    {
        
        /// <summary>
        /// AddNodesToCloud parameter set
        ///
        /// [GraphQL: addNodesToCloudCluster]
        /// </summary>
        [Parameter(
            ParameterSetName = "AddNodesToCloud",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Add nodes to cloud cluster.
[GraphQL: addNodesToCloudCluster]",
            Position = 0
        )]
        public SwitchParameter AddNodesToCloud { get; set; }

        
        /// <summary>
        /// RegisterCloud parameter set
        ///
        /// [GraphQL: registerCloudCluster]
        /// </summary>
        [Parameter(
            ParameterSetName = "RegisterCloud",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Register a cloud cluster.
[GraphQL: registerCloudCluster]",
            Position = 0
        )]
        public SwitchParameter RegisterCloud { get; set; }

        
        /// <summary>
        /// CreateFailover parameter set
        ///
        /// [GraphQL: createFailoverCluster]
        /// </summary>
        [Parameter(
            ParameterSetName = "CreateFailover",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a failover cluster

Supported in v5.2+
Create a failover cluster.
[GraphQL: createFailoverCluster]",
            Position = 0
        )]
        public SwitchParameter CreateFailover { get; set; }

        
        /// <summary>
        /// UpdateFailover parameter set
        ///
        /// [GraphQL: updateFailoverCluster]
        /// </summary>
        [Parameter(
            ParameterSetName = "UpdateFailover",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Update a failover cluster

Supported in v5.2+
Update failover cluster with specified properties.
[GraphQL: updateFailoverCluster]",
            Position = 0
        )]
        public SwitchParameter UpdateFailover { get; set; }

        
        /// <summary>
        /// DeleteFailover parameter set
        ///
        /// [GraphQL: deleteFailoverCluster]
        /// </summary>
        [Parameter(
            ParameterSetName = "DeleteFailover",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Delete a failover cluster

Supported in v5.2+
Delete a failover cluster.
[GraphQL: deleteFailoverCluster]",
            Position = 0
        )]
        public SwitchParameter DeleteFailover { get; set; }

        
        /// <summary>
        /// BulkDeleteFailover parameter set
        ///
        /// [GraphQL: bulkDeleteFailoverCluster]
        /// </summary>
        [Parameter(
            ParameterSetName = "BulkDeleteFailover",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Delete the provided failover clusters

Supported in v5.3+
Delete the provided failover clusters.
[GraphQL: bulkDeleteFailoverCluster]",
            Position = 0
        )]
        public SwitchParameter BulkDeleteFailover { get; set; }

        
        /// <summary>
        /// AddK8s parameter set
        ///
        /// [GraphQL: addK8sCluster]
        /// </summary>
        [Parameter(
            ParameterSetName = "AddK8s",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Add a Kubernetes cluster

Supported in v9.0+
Adds a Kubernetes cluster to the Rubrik cluster.
[GraphQL: addK8sCluster]",
            Position = 0
        )]
        public SwitchParameter AddK8s { get; set; }

        
        /// <summary>
        /// DeleteK8s parameter set
        ///
        /// [GraphQL: deleteK8sCluster]
        /// </summary>
        [Parameter(
            ParameterSetName = "DeleteK8s",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Delete a Kubernetes cluster

Supported in v9.0+
Deletes a Kubernetes cluster by specifying the cluster ID.
[GraphQL: deleteK8sCluster]",
            Position = 0
        )]
        public SwitchParameter DeleteK8s { get; set; }

        
        /// <summary>
        /// RefreshK8sV2 parameter set
        ///
        /// [GraphQL: refreshK8sV2Cluster]
        /// </summary>
        [Parameter(
            ParameterSetName = "RefreshK8sV2",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Initiate an on-demand refresh for a Kubernetes cluster

Supported in v9.0+
Initiates an on-demand refresh request for the specified Kubernetes cluster.
[GraphQL: refreshK8sV2Cluster]",
            Position = 0
        )]
        public SwitchParameter RefreshK8sV2 { get; set; }

        
        /// <summary>
        /// CreateK8s parameter set
        ///
        /// [GraphQL: createK8sCluster]
        /// </summary>
        [Parameter(
            ParameterSetName = "CreateK8s",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Add a Kubernetes cluster.
[GraphQL: createK8sCluster]",
            Position = 0
        )]
        public SwitchParameter CreateK8s { get; set; }

        
        /// <summary>
        /// RefreshK8s parameter set
        ///
        /// [GraphQL: refreshK8sCluster]
        /// </summary>
        [Parameter(
            ParameterSetName = "RefreshK8s",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Refresh resources of a Kubernetes cluster.
[GraphQL: refreshK8sCluster]",
            Position = 0
        )]
        public SwitchParameter RefreshK8s { get; set; }

        
        /// <summary>
        /// ArchiveK8s parameter set
        ///
        /// [GraphQL: archiveK8sCluster]
        /// </summary>
        [Parameter(
            ParameterSetName = "ArchiveK8s",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Archive a Kubernetes cluster.
[GraphQL: archiveK8sCluster]",
            Position = 0
        )]
        public SwitchParameter ArchiveK8s { get; set; }

        
        /// <summary>
        /// RemoveCdm parameter set
        ///
        /// [GraphQL: removeCdmCluster]
        /// </summary>
        [Parameter(
            ParameterSetName = "RemoveCdm",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"
[GraphQL: removeCdmCluster]",
            Position = 0
        )]
        public SwitchParameter RemoveCdm { get; set; }

        
        /// <summary>
        /// RecoverCloud parameter set
        ///
        /// [GraphQL: recoverCloudCluster]
        /// </summary>
        [Parameter(
            ParameterSetName = "RecoverCloud",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Recover a Rubrik Cloud Cluster.
[GraphQL: recoverCloudCluster]",
            Position = 0
        )]
        public SwitchParameter RecoverCloud { get; set; }


// ignore warning 'Missing XML comment'
#pragma warning disable 1591
        protected override void ProcessRecord()
        {
            try
            {
                switch(Op)
                {
                    case "AddNodesToCloud":
                        this.ProcessRecord_AddNodesToCloud();
                        break;
                    case "RegisterCloud":
                        this.ProcessRecord_RegisterCloud();
                        break;
                    case "CreateFailover":
                        this.ProcessRecord_CreateFailover();
                        break;
                    case "UpdateFailover":
                        this.ProcessRecord_UpdateFailover();
                        break;
                    case "DeleteFailover":
                        this.ProcessRecord_DeleteFailover();
                        break;
                    case "BulkDeleteFailover":
                        this.ProcessRecord_BulkDeleteFailover();
                        break;
                    case "AddK8s":
                        this.ProcessRecord_AddK8s();
                        break;
                    case "DeleteK8s":
                        this.ProcessRecord_DeleteK8s();
                        break;
                    case "RefreshK8sV2":
                        this.ProcessRecord_RefreshK8sV2();
                        break;
                    case "CreateK8s":
                        this.ProcessRecord_CreateK8s();
                        break;
                    case "RefreshK8s":
                        this.ProcessRecord_RefreshK8s();
                        break;
                    case "ArchiveK8s":
                        this.ProcessRecord_ArchiveK8s();
                        break;
                    case "RemoveCdm":
                        this.ProcessRecord_RemoveCdm();
                        break;
                    case "RecoverCloud":
                        this.ProcessRecord_RecoverCloud();
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
        // addNodesToCloudCluster.
        internal void ProcessRecord_AddNodesToCloud()
        {
            this._logger.name += " -AddNodesToCloud";
            // Invoke graphql operation addNodesToCloudCluster
            InvokeMutationAddNodesToCloudCluster();
        }

        // This parameter set invokes a single graphql operation:
        // registerCloudCluster.
        internal void ProcessRecord_RegisterCloud()
        {
            this._logger.name += " -RegisterCloud";
            // Invoke graphql operation registerCloudCluster
            InvokeMutationRegisterCloudCluster();
        }

        // This parameter set invokes a single graphql operation:
        // createFailoverCluster.
        internal void ProcessRecord_CreateFailover()
        {
            this._logger.name += " -CreateFailover";
            // Invoke graphql operation createFailoverCluster
            InvokeMutationCreateFailoverCluster();
        }

        // This parameter set invokes a single graphql operation:
        // updateFailoverCluster.
        internal void ProcessRecord_UpdateFailover()
        {
            this._logger.name += " -UpdateFailover";
            // Invoke graphql operation updateFailoverCluster
            InvokeMutationUpdateFailoverCluster();
        }

        // This parameter set invokes a single graphql operation:
        // deleteFailoverCluster.
        internal void ProcessRecord_DeleteFailover()
        {
            this._logger.name += " -DeleteFailover";
            // Invoke graphql operation deleteFailoverCluster
            InvokeMutationDeleteFailoverCluster();
        }

        // This parameter set invokes a single graphql operation:
        // bulkDeleteFailoverCluster.
        internal void ProcessRecord_BulkDeleteFailover()
        {
            this._logger.name += " -BulkDeleteFailover";
            // Invoke graphql operation bulkDeleteFailoverCluster
            InvokeMutationBulkDeleteFailoverCluster();
        }

        // This parameter set invokes a single graphql operation:
        // addK8sCluster.
        internal void ProcessRecord_AddK8s()
        {
            this._logger.name += " -AddK8s";
            // Invoke graphql operation addK8sCluster
            InvokeMutationAddK8sCluster();
        }

        // This parameter set invokes a single graphql operation:
        // deleteK8sCluster.
        internal void ProcessRecord_DeleteK8s()
        {
            this._logger.name += " -DeleteK8s";
            // Invoke graphql operation deleteK8sCluster
            InvokeMutationDeleteK8sCluster();
        }

        // This parameter set invokes a single graphql operation:
        // refreshK8sV2Cluster.
        internal void ProcessRecord_RefreshK8sV2()
        {
            this._logger.name += " -RefreshK8sV2";
            // Invoke graphql operation refreshK8sV2Cluster
            InvokeMutationRefreshK8sV2Cluster();
        }

        // This parameter set invokes a single graphql operation:
        // createK8sCluster.
        internal void ProcessRecord_CreateK8s()
        {
            this._logger.name += " -CreateK8s";
            // Invoke graphql operation createK8sCluster
            InvokeMutationCreateK8sCluster();
        }

        // This parameter set invokes a single graphql operation:
        // refreshK8sCluster.
        internal void ProcessRecord_RefreshK8s()
        {
            this._logger.name += " -RefreshK8s";
            // Invoke graphql operation refreshK8sCluster
            InvokeMutationRefreshK8sCluster();
        }

        // This parameter set invokes a single graphql operation:
        // archiveK8sCluster.
        internal void ProcessRecord_ArchiveK8s()
        {
            this._logger.name += " -ArchiveK8s";
            // Invoke graphql operation archiveK8sCluster
            InvokeMutationArchiveK8sCluster();
        }

        // This parameter set invokes a single graphql operation:
        // removeCdmCluster.
        internal void ProcessRecord_RemoveCdm()
        {
            this._logger.name += " -RemoveCdm";
            // Invoke graphql operation removeCdmCluster
            InvokeMutationRemoveCdmCluster();
        }

        // This parameter set invokes a single graphql operation:
        // recoverCloudCluster.
        internal void ProcessRecord_RecoverCloud()
        {
            this._logger.name += " -RecoverCloud";
            // Invoke graphql operation recoverCloudCluster
            InvokeMutationRecoverCloudCluster();
        }


        // Invoke GraphQL Mutation:
        // addNodesToCloudCluster(input: AddNodesToCloudClusterInput!): CcProvisionJobReply!
        internal void InvokeMutationAddNodesToCloudCluster()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "AddNodesToCloudClusterInput!"),
            };
            CcProvisionJobReply? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (CcProvisionJobReply)psObject.BaseObject;
                } else {
                    fieldSpecObj = (CcProvisionJobReply)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.AddNodesToCloudCluster(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationAddNodesToCloudCluster",
                "($input: AddNodesToCloudClusterInput!)",
                fieldSpecDoc,
                "CcProvisionJobReply"
            );
        }

        // Invoke GraphQL Mutation:
        // registerCloudCluster(input: RegisterCloudClusterInput!): RegisterCloudClusterReply!
        internal void InvokeMutationRegisterCloudCluster()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "RegisterCloudClusterInput!"),
            };
            RegisterCloudClusterReply? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (RegisterCloudClusterReply)psObject.BaseObject;
                } else {
                    fieldSpecObj = (RegisterCloudClusterReply)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.RegisterCloudCluster(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationRegisterCloudCluster",
                "($input: RegisterCloudClusterInput!)",
                fieldSpecDoc,
                "RegisterCloudClusterReply"
            );
        }

        // Invoke GraphQL Mutation:
        // createFailoverCluster(input: CreateFailoverClusterInput!): CreateFailoverClusterReply!
        internal void InvokeMutationCreateFailoverCluster()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateFailoverClusterInput!"),
            };
            CreateFailoverClusterReply? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (CreateFailoverClusterReply)psObject.BaseObject;
                } else {
                    fieldSpecObj = (CreateFailoverClusterReply)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.CreateFailoverCluster(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationCreateFailoverCluster",
                "($input: CreateFailoverClusterInput!)",
                fieldSpecDoc,
                "CreateFailoverClusterReply"
            );
        }

        // Invoke GraphQL Mutation:
        // updateFailoverCluster(input: UpdateFailoverClusterInput!): UpdateFailoverClusterReply!
        internal void InvokeMutationUpdateFailoverCluster()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateFailoverClusterInput!"),
            };
            UpdateFailoverClusterReply? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (UpdateFailoverClusterReply)psObject.BaseObject;
                } else {
                    fieldSpecObj = (UpdateFailoverClusterReply)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.UpdateFailoverCluster(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationUpdateFailoverCluster",
                "($input: UpdateFailoverClusterInput!)",
                fieldSpecDoc,
                "UpdateFailoverClusterReply"
            );
        }

        // Invoke GraphQL Mutation:
        // deleteFailoverCluster(input: DeleteFailoverClusterInput!): ResponseSuccess!
        internal void InvokeMutationDeleteFailoverCluster()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteFailoverClusterInput!"),
            };
            ResponseSuccess? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (ResponseSuccess)psObject.BaseObject;
                } else {
                    fieldSpecObj = (ResponseSuccess)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.DeleteFailoverCluster(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationDeleteFailoverCluster",
                "($input: DeleteFailoverClusterInput!)",
                fieldSpecDoc,
                "ResponseSuccess"
            );
        }

        // Invoke GraphQL Mutation:
        // bulkDeleteFailoverCluster(input: BulkDeleteFailoverClusterInput!): ResponseSuccess!
        internal void InvokeMutationBulkDeleteFailoverCluster()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "BulkDeleteFailoverClusterInput!"),
            };
            ResponseSuccess? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (ResponseSuccess)psObject.BaseObject;
                } else {
                    fieldSpecObj = (ResponseSuccess)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.BulkDeleteFailoverCluster(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationBulkDeleteFailoverCluster",
                "($input: BulkDeleteFailoverClusterInput!)",
                fieldSpecDoc,
                "ResponseSuccess"
            );
        }

        // Invoke GraphQL Mutation:
        // addK8sCluster(input: AddK8sClusterInput!): K8sClusterSummary!
        internal void InvokeMutationAddK8sCluster()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "AddK8sClusterInput!"),
            };
            K8sClusterSummary? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (K8sClusterSummary)psObject.BaseObject;
                } else {
                    fieldSpecObj = (K8sClusterSummary)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.AddK8sCluster(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationAddK8sCluster",
                "($input: AddK8sClusterInput!)",
                fieldSpecDoc,
                "K8sClusterSummary"
            );
        }

        // Invoke GraphQL Mutation:
        // deleteK8sCluster(input: DeleteK8sClusterInput!): AsyncRequestStatus!
        internal void InvokeMutationDeleteK8sCluster()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteK8sClusterInput!"),
            };
            AsyncRequestStatus? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (AsyncRequestStatus)psObject.BaseObject;
                } else {
                    fieldSpecObj = (AsyncRequestStatus)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.DeleteK8sCluster(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationDeleteK8sCluster",
                "($input: DeleteK8sClusterInput!)",
                fieldSpecDoc,
                "AsyncRequestStatus"
            );
        }

        // Invoke GraphQL Mutation:
        // refreshK8sV2Cluster(input: RefreshK8sV2ClusterInput!): AsyncRequestStatus!
        internal void InvokeMutationRefreshK8sV2Cluster()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "RefreshK8sV2ClusterInput!"),
            };
            AsyncRequestStatus? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (AsyncRequestStatus)psObject.BaseObject;
                } else {
                    fieldSpecObj = (AsyncRequestStatus)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.RefreshK8sV2Cluster(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationRefreshK8sV2Cluster",
                "($input: RefreshK8sV2ClusterInput!)",
                fieldSpecDoc,
                "AsyncRequestStatus"
            );
        }

        // Invoke GraphQL Mutation:
        // createK8sCluster(input: CreateK8sClusterInput!): CreateK8sClusterReply!
        internal void InvokeMutationCreateK8sCluster()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateK8sClusterInput!"),
            };
            CreateK8sClusterReply? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (CreateK8sClusterReply)psObject.BaseObject;
                } else {
                    fieldSpecObj = (CreateK8sClusterReply)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.CreateK8sCluster(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationCreateK8sCluster",
                "($input: CreateK8sClusterInput!)",
                fieldSpecDoc,
                "CreateK8sClusterReply"
            );
        }

        // Invoke GraphQL Mutation:
        // refreshK8sCluster(input: RefreshK8sClusterInput!): CreateOnDemandJobReply!
        internal void InvokeMutationRefreshK8sCluster()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "RefreshK8sClusterInput!"),
            };
            CreateOnDemandJobReply? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (CreateOnDemandJobReply)psObject.BaseObject;
                } else {
                    fieldSpecObj = (CreateOnDemandJobReply)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.RefreshK8sCluster(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationRefreshK8sCluster",
                "($input: RefreshK8sClusterInput!)",
                fieldSpecDoc,
                "CreateOnDemandJobReply"
            );
        }

        // Invoke GraphQL Mutation:
        // archiveK8sCluster(input: ArchiveK8sClusterInput!): ArchiveK8sClusterReply!
        internal void InvokeMutationArchiveK8sCluster()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "ArchiveK8sClusterInput!"),
            };
            ArchiveK8sClusterReply? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (ArchiveK8sClusterReply)psObject.BaseObject;
                } else {
                    fieldSpecObj = (ArchiveK8sClusterReply)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.ArchiveK8sCluster(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationArchiveK8sCluster",
                "($input: ArchiveK8sClusterInput!)",
                fieldSpecDoc,
                "ArchiveK8sClusterReply"
            );
        }

        // Invoke GraphQL Mutation:
        // removeCdmCluster(clusterUUID: UUID!, isForce: Boolean!, expireInDays: Long): Boolean!
        internal void InvokeMutationRemoveCdmCluster()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("clusterUUID", "UUID!"),
                Tuple.Create("isForce", "Boolean!"),
                Tuple.Create("expireInDays", "Long"),
            };
            System.Boolean? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (System.Boolean)psObject.BaseObject;
                } else {
                    fieldSpecObj = (System.Boolean)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.RemoveCdmCluster(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationRemoveCdmCluster",
                "($clusterUUID: UUID!,$isForce: Boolean!,$expireInDays: Long)",
                fieldSpecDoc,
                "System.Boolean"
            );
        }

        // Invoke GraphQL Mutation:
        // recoverCloudCluster(input: RecoverCloudClusterInput!): CcProvisionJobReply!
        internal void InvokeMutationRecoverCloudCluster()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "RecoverCloudClusterInput!"),
            };
            CcProvisionJobReply? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (CcProvisionJobReply)psObject.BaseObject;
                } else {
                    fieldSpecObj = (CcProvisionJobReply)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.RecoverCloudCluster(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationRecoverCloudCluster",
                "($input: RecoverCloudClusterInput!)",
                fieldSpecDoc,
                "CcProvisionJobReply"
            );
        }


    } // class Invoke_RscMutateCluster
}