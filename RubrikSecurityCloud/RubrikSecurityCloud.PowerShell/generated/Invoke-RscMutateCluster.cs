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
    /// <summary>
    /// Cluster mutations
    /// </summary>
    /// <description>
    /// Invoke-RscMutateCluster is a master cmdlet for Cluster work that can invoke any of the following subcommands: AddNodesToCloud, RegisterCloud, UpdateDatabaseLogReportingProperties, CreateFailover, UpdateFailover, DeleteFailover, BulkDeleteFailover, AddK8s, DeleteK8s, RefreshK8sV2, CreateK8s, RefreshK8s, ArchiveK8s, RemoveCdm, RecoverCloud.
    /// </description>
    /// <example>
    /// <code>Invoke-RscMutateCluster -AddNodesToCloud [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscMutateCluster -RegisterCloud [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscMutateCluster -UpdateDatabaseLogReportingProperties [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscMutateCluster -CreateFailover [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscMutateCluster -UpdateFailover [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscMutateCluster -DeleteFailover [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscMutateCluster -BulkDeleteFailover [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscMutateCluster -AddK8s [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscMutateCluster -DeleteK8s [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscMutateCluster -RefreshK8sV2 [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscMutateCluster -CreateK8s [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscMutateCluster -RefreshK8s [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscMutateCluster -ArchiveK8s [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscMutateCluster -RemoveCdm [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscMutateCluster -RecoverCloud [-Arg ..] [-Field ..]</code>
    /// </example>
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
        /// UpdateDatabaseLogReportingProperties parameter set
        ///
        /// [GraphQL: updateDatabaseLogReportingPropertiesForCluster]
        /// </summary>
        [Parameter(
            ParameterSetName = "UpdateDatabaseLogReportingProperties",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Update the database log backup report properties

Supported in v5.3+
Update the properties for the database (SQL and Oracle) log backup delay email notification creation. The properties are logDelayThresholdInMin and logDelayNotificationFrequencyInMin.
[GraphQL: updateDatabaseLogReportingPropertiesForCluster]",
            Position = 0
        )]
        public SwitchParameter UpdateDatabaseLogReportingProperties { get; set; }

        
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
                    case "UpdateDatabaseLogReportingProperties":
                        this.ProcessRecord_UpdateDatabaseLogReportingProperties();
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
        // updateDatabaseLogReportingPropertiesForCluster.
        internal void ProcessRecord_UpdateDatabaseLogReportingProperties()
        {
            this._logger.name += " -UpdateDatabaseLogReportingProperties";
            // Invoke graphql operation updateDatabaseLogReportingPropertiesForCluster
            InvokeMutationUpdateDatabaseLogReportingPropertiesForCluster();
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
            Initialize(
                argDefs,
                "mutation",
                "MutationAddNodesToCloudCluster",
                "($input: AddNodesToCloudClusterInput!)",
                "CcProvisionJobReply"
                );
            CcProvisionJobReply? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (CcProvisionJobReply)this.Field;
            }
            string fieldSpecDoc = Mutation.AddNodesToCloudCluster(ref fieldSpecObj);
            string inputExample = @"# REQUIRED
$inputs.Var.input = @{
	# OPTIONAL
	numberOfNodes = <System.Int32>
	# OPTIONAL
	shouldKeepResourcesOnFailure = <System.Boolean>
	# REQUIRED
	cloudAccountId = <System.String>
	# REQUIRED
	vendor = <CcpVendorType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CcpVendorType]) for enum values.
	# REQUIRED
	clusterUuid = <System.String>
}";
            BuildInput(fieldSpecObj, inputExample);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Mutation:
        // registerCloudCluster(input: RegisterCloudClusterInput!): RegisterCloudClusterReply!
        internal void InvokeMutationRegisterCloudCluster()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "RegisterCloudClusterInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationRegisterCloudCluster",
                "($input: RegisterCloudClusterInput!)",
                "RegisterCloudClusterReply"
                );
            RegisterCloudClusterReply? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (RegisterCloudClusterReply)this.Field;
            }
            string fieldSpecDoc = Mutation.RegisterCloudCluster(ref fieldSpecObj);
            string inputExample = @"# REQUIRED
$inputs.Var.input = @{
	# OPTIONAL
	clusterUuid = <System.String>
}";
            BuildInput(fieldSpecObj, inputExample);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Mutation:
        // updateDatabaseLogReportingPropertiesForCluster(input: UpdateDatabaseLogReportingPropertiesForClusterInput!): DbLogReportProperties!
        internal void InvokeMutationUpdateDatabaseLogReportingPropertiesForCluster()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateDatabaseLogReportingPropertiesForClusterInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateDatabaseLogReportingPropertiesForCluster",
                "($input: UpdateDatabaseLogReportingPropertiesForClusterInput!)",
                "DbLogReportProperties"
                );
            DbLogReportProperties? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (DbLogReportProperties)this.Field;
            }
            string fieldSpecDoc = Mutation.UpdateDatabaseLogReportingPropertiesForCluster(ref fieldSpecObj);
            string inputExample = @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	clusterUuid = <System.String>
	# REQUIRED
	properties = @{
		# OPTIONAL
		enableDelayNotification = <System.Boolean>
		# OPTIONAL
		logDelayThresholdInMin = <System.Int64>
		# OPTIONAL
		logDelayNotificationFrequencyInMin = <System.Int64>
	}
}";
            BuildInput(fieldSpecObj, inputExample);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Mutation:
        // createFailoverCluster(input: CreateFailoverClusterInput!): CreateFailoverClusterReply!
        internal void InvokeMutationCreateFailoverCluster()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateFailoverClusterInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateFailoverCluster",
                "($input: CreateFailoverClusterInput!)",
                "CreateFailoverClusterReply"
                );
            CreateFailoverClusterReply? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (CreateFailoverClusterReply)this.Field;
            }
            string fieldSpecDoc = Mutation.CreateFailoverCluster(ref fieldSpecObj);
            string inputExample = @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	clusterUuid = <System.String>
	# REQUIRED
	config = @{
		# OPTIONAL
		configuredSlaDomainId = <System.String>
		# REQUIRED
		hostIds = @(
			<System.String>
		)
		# REQUIRED
		name = <System.String>
	}
}";
            BuildInput(fieldSpecObj, inputExample);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Mutation:
        // updateFailoverCluster(input: UpdateFailoverClusterInput!): UpdateFailoverClusterReply!
        internal void InvokeMutationUpdateFailoverCluster()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateFailoverClusterInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateFailoverCluster",
                "($input: UpdateFailoverClusterInput!)",
                "UpdateFailoverClusterReply"
                );
            UpdateFailoverClusterReply? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (UpdateFailoverClusterReply)this.Field;
            }
            string fieldSpecDoc = Mutation.UpdateFailoverCluster(ref fieldSpecObj);
            string inputExample = @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
	# REQUIRED
	updateProperties = @{
		# OPTIONAL
		configuredSlaDomainId = <System.String>
		# REQUIRED
		hostIds = @(
			<System.String>
		)
		# REQUIRED
		name = <System.String>
	}
}";
            BuildInput(fieldSpecObj, inputExample);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Mutation:
        // deleteFailoverCluster(input: DeleteFailoverClusterInput!): ResponseSuccess!
        internal void InvokeMutationDeleteFailoverCluster()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteFailoverClusterInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDeleteFailoverCluster",
                "($input: DeleteFailoverClusterInput!)",
                "ResponseSuccess"
                );
            ResponseSuccess? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (ResponseSuccess)this.Field;
            }
            string fieldSpecDoc = Mutation.DeleteFailoverCluster(ref fieldSpecObj);
            string inputExample = @"# REQUIRED
$inputs.Var.input = @{
	# OPTIONAL
	preserveSnapshots = <System.Boolean>
	# REQUIRED
	id = <System.String>
}";
            BuildInput(fieldSpecObj, inputExample);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Mutation:
        // bulkDeleteFailoverCluster(input: BulkDeleteFailoverClusterInput!): ResponseSuccess!
        internal void InvokeMutationBulkDeleteFailoverCluster()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "BulkDeleteFailoverClusterInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationBulkDeleteFailoverCluster",
                "($input: BulkDeleteFailoverClusterInput!)",
                "ResponseSuccess"
                );
            ResponseSuccess? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (ResponseSuccess)this.Field;
            }
            string fieldSpecDoc = Mutation.BulkDeleteFailoverCluster(ref fieldSpecObj);
            string inputExample = @"# REQUIRED
$inputs.Var.input = @{
	# OPTIONAL
	preserveSnapshots = <System.Boolean>
	# REQUIRED
	ids = @(
		<System.String>
	)
}";
            BuildInput(fieldSpecObj, inputExample);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Mutation:
        // addK8sCluster(input: AddK8sClusterInput!): K8sClusterSummary!
        internal void InvokeMutationAddK8sCluster()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "AddK8sClusterInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationAddK8sCluster",
                "($input: AddK8sClusterInput!)",
                "K8sClusterSummary"
                );
            K8sClusterSummary? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (K8sClusterSummary)this.Field;
            }
            string fieldSpecDoc = Mutation.AddK8sCluster(ref fieldSpecObj);
            string inputExample = @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	clusterUuid = <System.String>
	# REQUIRED
	config = @{
		# OPTIONAL
		registry = <System.String>
		# OPTIONAL
		distribution = <System.String>
		# OPTIONAL
		k8SAwsConfig = @{
			# REQUIRED
			cloudAccountId = <System.String>
			# REQUIRED
			eksClusterArn = <System.String>
		}
		# OPTIONAL
		region = <System.String>
		# REQUIRED
		kubeconfig = <System.String>
		# REQUIRED
		name = <System.String>
	}
}";
            BuildInput(fieldSpecObj, inputExample);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Mutation:
        // deleteK8sCluster(input: DeleteK8sClusterInput!): AsyncRequestStatus!
        internal void InvokeMutationDeleteK8sCluster()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteK8sClusterInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDeleteK8sCluster",
                "($input: DeleteK8sClusterInput!)",
                "AsyncRequestStatus"
                );
            AsyncRequestStatus? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (AsyncRequestStatus)this.Field;
            }
            string fieldSpecDoc = Mutation.DeleteK8sCluster(ref fieldSpecObj);
            string inputExample = @"# REQUIRED
$inputs.Var.input = @{
	# OPTIONAL
	preserveSnapshots = <System.Boolean>
	# REQUIRED
	id = <System.String>
}";
            BuildInput(fieldSpecObj, inputExample);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Mutation:
        // refreshK8sV2Cluster(input: RefreshK8sV2ClusterInput!): AsyncRequestStatus!
        internal void InvokeMutationRefreshK8sV2Cluster()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "RefreshK8sV2ClusterInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationRefreshK8sV2Cluster",
                "($input: RefreshK8sV2ClusterInput!)",
                "AsyncRequestStatus"
                );
            AsyncRequestStatus? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (AsyncRequestStatus)this.Field;
            }
            string fieldSpecDoc = Mutation.RefreshK8sV2Cluster(ref fieldSpecObj);
            string inputExample = @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	clusterUuid = <System.String>
	# REQUIRED
	id = <System.String>
}";
            BuildInput(fieldSpecObj, inputExample);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Mutation:
        // createK8sCluster(input: CreateK8sClusterInput!): CreateK8sClusterReply!
        internal void InvokeMutationCreateK8sCluster()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateK8sClusterInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateK8sCluster",
                "($input: CreateK8sClusterInput!)",
                "CreateK8sClusterReply"
                );
            CreateK8sClusterReply? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (CreateK8sClusterReply)this.Field;
            }
            string fieldSpecDoc = Mutation.CreateK8sCluster(ref fieldSpecObj);
            string inputExample = @"# REQUIRED
$inputs.Var.input = @{
	# OPTIONAL
	cdmClusterId = <System.String>
	# REQUIRED
	hostList = @(
		<System.String>
	)
	# REQUIRED
	name = <System.String>
	# REQUIRED
	port = <System.Int32>
	# REQUIRED
	rbsPortRanges = @(
		@{
			# OPTIONAL
			portMin = <System.Int32>
			# OPTIONAL
			portMax = <System.Int32>
		}
	)
	# OPTIONAL
	userDrivenPortRanges = @(
		@{
			# OPTIONAL
			portMin = <System.Int32>
			# OPTIONAL
			portMax = <System.Int32>
		}
	)
	# REQUIRED
	type = <K8sClusterProtoType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.K8sClusterProtoType]) for enum values.
	# OPTIONAL
	proxyUrl = <System.String>
}";
            BuildInput(fieldSpecObj, inputExample);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Mutation:
        // refreshK8sCluster(input: RefreshK8sClusterInput!): CreateOnDemandJobReply!
        internal void InvokeMutationRefreshK8sCluster()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "RefreshK8sClusterInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationRefreshK8sCluster",
                "($input: RefreshK8sClusterInput!)",
                "CreateOnDemandJobReply"
                );
            CreateOnDemandJobReply? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (CreateOnDemandJobReply)this.Field;
            }
            string fieldSpecDoc = Mutation.RefreshK8sCluster(ref fieldSpecObj);
            string inputExample = @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	k8sClusterId = <System.String>
}";
            BuildInput(fieldSpecObj, inputExample);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Mutation:
        // archiveK8sCluster(input: ArchiveK8sClusterInput!): ArchiveK8sClusterReply!
        internal void InvokeMutationArchiveK8sCluster()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "ArchiveK8sClusterInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationArchiveK8sCluster",
                "($input: ArchiveK8sClusterInput!)",
                "ArchiveK8sClusterReply"
                );
            ArchiveK8sClusterReply? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (ArchiveK8sClusterReply)this.Field;
            }
            string fieldSpecDoc = Mutation.ArchiveK8sCluster(ref fieldSpecObj);
            string inputExample = @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	clusterId = <System.String>
}";
            BuildInput(fieldSpecObj, inputExample);
            BuildRequest(fieldSpecDoc);
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
            Initialize(
                argDefs,
                "mutation",
                "MutationRemoveCdmCluster",
                "($clusterUUID: UUID!,$isForce: Boolean!,$expireInDays: Long)",
                "System.Boolean"
                );
            System.Boolean? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (System.Boolean)this.Field;
            }
            string fieldSpecDoc = Mutation.RemoveCdmCluster(ref fieldSpecObj);
            string inputExample = @"# REQUIRED
$inputs.Var.clusterUUID = <System.String>
# REQUIRED
$inputs.Var.isForce = <System.Boolean>
# OPTIONAL
$inputs.Var.expireInDays = <System.Int64>";
            BuildInput(fieldSpecObj, inputExample);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Mutation:
        // recoverCloudCluster(input: RecoverCloudClusterInput!): CcProvisionJobReply!
        internal void InvokeMutationRecoverCloudCluster()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "RecoverCloudClusterInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationRecoverCloudCluster",
                "($input: RecoverCloudClusterInput!)",
                "CcProvisionJobReply"
                );
            CcProvisionJobReply? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (CcProvisionJobReply)this.Field;
            }
            string fieldSpecDoc = Mutation.RecoverCloudCluster(ref fieldSpecObj);
            string inputExample = @"# REQUIRED
$inputs.Var.input = @{
	# OPTIONAL
	adminPassword = <System.String>
	# OPTIONAL
	userEmail = <System.String>
	# REQUIRED
	cloudAccountId = <System.String>
	# REQUIRED
	clusterUuid = <System.String>
	# OPTIONAL
	azureEsResourceGroup = <System.String>
	# OPTIONAL
	azureVmConfig = @{
		# OPTIONAL
		resourceGroup = <System.String>
		# OPTIONAL
		cdmVersion = <System.String>
		# OPTIONAL
		location = <System.String>
		# OPTIONAL
		nodeSizeGb = <System.Int32>
		# OPTIONAL
		networkResourceGroup = <System.String>
		# OPTIONAL
		vnetResourceGroup = <System.String>
		# OPTIONAL
		networkSecurityGroup = <System.String>
		# OPTIONAL
		networkSecurityResourceGroup = <System.String>
		# OPTIONAL
		vnet = <System.String>
		# OPTIONAL
		subnet = <System.String>
		# OPTIONAL
		tags = <System.String>
		# OPTIONAL
		vmImage = <System.String>
		# OPTIONAL
		cdmProduct = <System.String>
		# OPTIONAL
		vmType = <VmType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.VmType]) for enum values.
		# OPTIONAL
		instanceType = <AzureInstanceType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureInstanceType]) for enum values.
	}
	# OPTIONAL
	awsVmConfig = @{
		# OPTIONAL
		cdmVersion = <System.String>
		# OPTIONAL
		nodeSizeGb = <System.Int32>
		# OPTIONAL
		subnet = <System.String>
		# OPTIONAL
		tags = <System.String>
		# OPTIONAL
		imageId = <System.String>
		# OPTIONAL
		instanceProfileName = <System.String>
		# OPTIONAL
		cdmProduct = <System.String>
		# OPTIONAL
		vmType = <VmType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.VmType]) for enum values.
		# OPTIONAL
		securityGroups = @(
			<System.String>
		)
		# OPTIONAL
		instanceType = <AwsInstanceType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsInstanceType]) for enum values.
	}
	# OPTIONAL
	awsRegion = <System.String>
	# REQUIRED
	shouldDisableAwsApiTermination = <System.Boolean>
	# REQUIRED
	shouldKeepClusterOnFailure = <System.Boolean>
	# OPTIONAL
	ntpServers = @(
		<System.String>
	)
}";
            BuildInput(fieldSpecObj, inputExample);
            BuildRequest(fieldSpecDoc);
        }


    } // class Invoke_RscMutateCluster
}