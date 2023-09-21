// New-RscMutationAzure.cs
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
    /// Mutations for the 'Azure' API domain.
    /// </summary>
    /// <description>
    /// New-RscMutationAzure is a master cmdlet for Azure work that can invoke any of the following subcommands: StartRefreshNativeSubscriptionsJob, StartRestoreNativeVirtualMachineJob, StartExportNativeVirtualMachineJob, ExcludeNativeManagedDisksFromSnapshot, StartCreateNativeVirtualMachineSnapshotsJob, StartDisableNativeSubscriptionProtectionJob, StartCreateNativeManagedDiskSnapshotsJob, StartExportNativeManagedDiskJob, StartExportSqlDatabaseDbJob, StartExportSqlManagedInstanceDbJob, CreateAccount, UpdateAccount, CreateAutomaticTargetMapping, CreateCloudNativeStorageSetting, CreateCloudNativeRcvStorageSetting, UpdateAutomaticTargetMapping, UpdateCloudNativeStorageSetting, UpdateCloudNativeRcvStorageSetting, CreateTarget, UpdateTarget, CreateReaderTarget, StartCloudAccountOauth, CompleteCloudAccountOauth, SetCloudAccountCustomerAppCredentials, AddCloudAccount, AddCloudAccountWithoutOauth, DeleteCloudAccount, DeleteCloudAccountWithoutOauth, UpgradeCloudAccount, UpdateCustomerAppPermissionForSql, StartDisableCloudAccountJob, UpdateCloudAccount, MapCloudAccountToPersistentStorageLocation, AddCloudAccountExocomputeConfigurations, DeleteCloudAccountExocomputeConfigurations, MapCloudAccountExocomputeSubscription, UnmapCloudAccountExocomputeSubscription, UpgradeCloudAccountPermissionsWithoutOauth, UnmapPersistentStorageSubscription, OauthConsentKickoff, OauthConsentComplete, CreateSaasAppAad, CreateCluster, DeleteCluster.
    /// </description>
    /// <example>
    /// <code>New-RscMutationAzure -StartRefreshNativeSubscriptionsJob [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationAzure -StartRestoreNativeVirtualMachineJob [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationAzure -StartExportNativeVirtualMachineJob [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationAzure -ExcludeNativeManagedDisksFromSnapshot [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationAzure -StartCreateNativeVirtualMachineSnapshotsJob [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationAzure -StartDisableNativeSubscriptionProtectionJob [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationAzure -StartCreateNativeManagedDiskSnapshotsJob [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationAzure -StartExportNativeManagedDiskJob [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationAzure -StartExportSqlDatabaseDbJob [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationAzure -StartExportSqlManagedInstanceDbJob [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationAzure -CreateAccount [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationAzure -UpdateAccount [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationAzure -CreateAutomaticTargetMapping [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationAzure -CreateCloudNativeStorageSetting [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationAzure -CreateCloudNativeRcvStorageSetting [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationAzure -UpdateAutomaticTargetMapping [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationAzure -UpdateCloudNativeStorageSetting [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationAzure -UpdateCloudNativeRcvStorageSetting [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationAzure -CreateTarget [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationAzure -UpdateTarget [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationAzure -CreateReaderTarget [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationAzure -StartCloudAccountOauth [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationAzure -CompleteCloudAccountOauth [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationAzure -SetCloudAccountCustomerAppCredentials [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationAzure -AddCloudAccount [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationAzure -AddCloudAccountWithoutOauth [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationAzure -DeleteCloudAccount [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationAzure -DeleteCloudAccountWithoutOauth [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationAzure -UpgradeCloudAccount [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationAzure -UpdateCustomerAppPermissionForSql [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationAzure -StartDisableCloudAccountJob [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationAzure -UpdateCloudAccount [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationAzure -MapCloudAccountToPersistentStorageLocation [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationAzure -AddCloudAccountExocomputeConfigurations [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationAzure -DeleteCloudAccountExocomputeConfigurations [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationAzure -MapCloudAccountExocomputeSubscription [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationAzure -UnmapCloudAccountExocomputeSubscription [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationAzure -UpgradeCloudAccountPermissionsWithoutOauth [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationAzure -UnmapPersistentStorageSubscription [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationAzure -OauthConsentKickoff [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationAzure -OauthConsentComplete [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationAzure -CreateSaasAppAad [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationAzure -CreateCluster [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationAzure -DeleteCluster [-Arg ..] [-Field ..]</code>
    /// </example>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscMutationAzure",
        DefaultParameterSetName = "CreateTarget")
    ]
    public class New_RscMutationAzure : RscGqlPSCmdlet
    {
        
        /// <summary>
        /// StartRefreshNativeSubscriptionsJob parameter set
        ///
        /// [GraphQL: startRefreshAzureNativeSubscriptionsJob]
        /// </summary>
        [Parameter(
            ParameterSetName = "StartRefreshNativeSubscriptionsJob",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Start a job to refresh Azure Native subscription for the given subscription IDs. When started, this job will update the Rubrik platform with any changes that have been done on Azure for the respective subscription.
[GraphQL: startRefreshAzureNativeSubscriptionsJob]",
            Position = 0
        )]
        public SwitchParameter StartRefreshNativeSubscriptionsJob { get; set; }

        
        /// <summary>
        /// StartRestoreNativeVirtualMachineJob parameter set
        ///
        /// [GraphQL: startRestoreAzureNativeVirtualMachineJob]
        /// </summary>
        [Parameter(
            ParameterSetName = "StartRestoreNativeVirtualMachineJob",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Start a job to restore Azure Native virtual machine with the selected snapshot. When started, this will replace the original VM with the selected snapshot.
[GraphQL: startRestoreAzureNativeVirtualMachineJob]",
            Position = 0
        )]
        public SwitchParameter StartRestoreNativeVirtualMachineJob { get; set; }

        
        /// <summary>
        /// StartExportNativeVirtualMachineJob parameter set
        ///
        /// [GraphQL: startExportAzureNativeVirtualMachineJob]
        /// </summary>
        [Parameter(
            ParameterSetName = "StartExportNativeVirtualMachineJob",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Start a job to export the Azure native virtual machine for a specified snapshot to a specified destination.
[GraphQL: startExportAzureNativeVirtualMachineJob]",
            Position = 0
        )]
        public SwitchParameter StartExportNativeVirtualMachineJob { get; set; }

        
        /// <summary>
        /// ExcludeNativeManagedDisksFromSnapshot parameter set
        ///
        /// [GraphQL: excludeAzureNativeManagedDisksFromSnapshot]
        /// </summary>
        [Parameter(
            ParameterSetName = "ExcludeNativeManagedDisksFromSnapshot",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Exclude the Managed Disks from snapshots, for the specified virtual machines.
[GraphQL: excludeAzureNativeManagedDisksFromSnapshot]",
            Position = 0
        )]
        public SwitchParameter ExcludeNativeManagedDisksFromSnapshot { get; set; }

        
        /// <summary>
        /// StartCreateNativeVirtualMachineSnapshotsJob parameter set
        ///
        /// [GraphQL: startCreateAzureNativeVirtualMachineSnapshotsJob]
        /// </summary>
        [Parameter(
            ParameterSetName = "StartCreateNativeVirtualMachineSnapshotsJob",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Start a job to create a snapshot for the Azure Native virtual machine identified by the IDs. When started, this will start taking an on-demand snapshot of the selected VMs as per the SLA Policy assigned to the respective VMs.
[GraphQL: startCreateAzureNativeVirtualMachineSnapshotsJob]",
            Position = 0
        )]
        public SwitchParameter StartCreateNativeVirtualMachineSnapshotsJob { get; set; }

        
        /// <summary>
        /// StartDisableNativeSubscriptionProtectionJob parameter set
        ///
        /// [GraphQL: startDisableAzureNativeSubscriptionProtectionJob]
        /// </summary>
        [Parameter(
            ParameterSetName = "StartDisableNativeSubscriptionProtectionJob",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Start a job to disable protection for a specified Azure subscription.
[GraphQL: startDisableAzureNativeSubscriptionProtectionJob]",
            Position = 0
        )]
        public SwitchParameter StartDisableNativeSubscriptionProtectionJob { get; set; }

        
        /// <summary>
        /// StartCreateNativeManagedDiskSnapshotsJob parameter set
        ///
        /// [GraphQL: startCreateAzureNativeManagedDiskSnapshotsJob]
        /// </summary>
        [Parameter(
            ParameterSetName = "StartCreateNativeManagedDiskSnapshotsJob",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Start a job to create snapshots of the Azure Native Managed Disks identified by the given IDs. When started, this will start taking an on-demand snapshot of the selected disks as per the SLA Policy assigned to the respective disks.
[GraphQL: startCreateAzureNativeManagedDiskSnapshotsJob]",
            Position = 0
        )]
        public SwitchParameter StartCreateNativeManagedDiskSnapshotsJob { get; set; }

        
        /// <summary>
        /// StartExportNativeManagedDiskJob parameter set
        ///
        /// [GraphQL: startExportAzureNativeManagedDiskJob]
        /// </summary>
        [Parameter(
            ParameterSetName = "StartExportNativeManagedDiskJob",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Start a job to export the specified Azure Native Managed Disks to the desired destination.
[GraphQL: startExportAzureNativeManagedDiskJob]",
            Position = 0
        )]
        public SwitchParameter StartExportNativeManagedDiskJob { get; set; }

        
        /// <summary>
        /// StartExportSqlDatabaseDbJob parameter set
        ///
        /// [GraphQL: startExportAzureSqlDatabaseDbJob]
        /// </summary>
        [Parameter(
            ParameterSetName = "StartExportSqlDatabaseDbJob",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Start a job to export Azure SQL Database. The job creates a new Azure SQL Database with the same properties as that of the instance that is exported.
[GraphQL: startExportAzureSqlDatabaseDbJob]",
            Position = 0
        )]
        public SwitchParameter StartExportSqlDatabaseDbJob { get; set; }

        
        /// <summary>
        /// StartExportSqlManagedInstanceDbJob parameter set
        ///
        /// [GraphQL: startExportAzureSqlManagedInstanceDbJob]
        /// </summary>
        [Parameter(
            ParameterSetName = "StartExportSqlManagedInstanceDbJob",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Start a job to export Azure SQL Managed Instance database. The job creates a new Azure SQL Managed Instance database with the same properties as that of the instance that is exported.
[GraphQL: startExportAzureSqlManagedInstanceDbJob]",
            Position = 0
        )]
        public SwitchParameter StartExportSqlManagedInstanceDbJob { get; set; }

        
        /// <summary>
        /// CreateAccount parameter set
        ///
        /// [GraphQL: createAzureAccount]
        /// </summary>
        [Parameter(
            ParameterSetName = "CreateAccount",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"
[GraphQL: createAzureAccount]",
            Position = 0
        )]
        public SwitchParameter CreateAccount { get; set; }

        
        /// <summary>
        /// UpdateAccount parameter set
        ///
        /// [GraphQL: updateAzureAccount]
        /// </summary>
        [Parameter(
            ParameterSetName = "UpdateAccount",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"
[GraphQL: updateAzureAccount]",
            Position = 0
        )]
        public SwitchParameter UpdateAccount { get; set; }

        
        /// <summary>
        /// CreateAutomaticTargetMapping parameter set
        ///
        /// [GraphQL: createAutomaticAzureTargetMapping]
        /// </summary>
        [Parameter(
            ParameterSetName = "CreateAutomaticTargetMapping",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"
[GraphQL: createAutomaticAzureTargetMapping]",
            Position = 0
        )]
        public SwitchParameter CreateAutomaticTargetMapping { get; set; }

        
        /// <summary>
        /// CreateCloudNativeStorageSetting parameter set
        ///
        /// [GraphQL: createCloudNativeAzureStorageSetting]
        /// </summary>
        [Parameter(
            ParameterSetName = "CreateCloudNativeStorageSetting",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Creates Storage Settings for the archival of azure cloud native protected objects
[GraphQL: createCloudNativeAzureStorageSetting]",
            Position = 0
        )]
        public SwitchParameter CreateCloudNativeStorageSetting { get; set; }

        
        /// <summary>
        /// CreateCloudNativeRcvStorageSetting parameter set
        ///
        /// [GraphQL: createCloudNativeRcvAzureStorageSetting]
        /// </summary>
        [Parameter(
            ParameterSetName = "CreateCloudNativeRcvStorageSetting",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create Rubrik Cloud Vault storage settings for archiving azure cloud native protected objects.
[GraphQL: createCloudNativeRcvAzureStorageSetting]",
            Position = 0
        )]
        public SwitchParameter CreateCloudNativeRcvStorageSetting { get; set; }

        
        /// <summary>
        /// UpdateAutomaticTargetMapping parameter set
        ///
        /// [GraphQL: updateAutomaticAzureTargetMapping]
        /// </summary>
        [Parameter(
            ParameterSetName = "UpdateAutomaticTargetMapping",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"
[GraphQL: updateAutomaticAzureTargetMapping]",
            Position = 0
        )]
        public SwitchParameter UpdateAutomaticTargetMapping { get; set; }

        
        /// <summary>
        /// UpdateCloudNativeStorageSetting parameter set
        ///
        /// [GraphQL: updateCloudNativeAzureStorageSetting]
        /// </summary>
        [Parameter(
            ParameterSetName = "UpdateCloudNativeStorageSetting",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"
[GraphQL: updateCloudNativeAzureStorageSetting]",
            Position = 0
        )]
        public SwitchParameter UpdateCloudNativeStorageSetting { get; set; }

        
        /// <summary>
        /// UpdateCloudNativeRcvStorageSetting parameter set
        ///
        /// [GraphQL: updateCloudNativeRcvAzureStorageSetting]
        /// </summary>
        [Parameter(
            ParameterSetName = "UpdateCloudNativeRcvStorageSetting",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Updates an existing Rubrik Cloud Vault Storage Settings for the archival of azure cloud native protected objects.
[GraphQL: updateCloudNativeRcvAzureStorageSetting]",
            Position = 0
        )]
        public SwitchParameter UpdateCloudNativeRcvStorageSetting { get; set; }

        
        /// <summary>
        /// CreateTarget parameter set
        ///
        /// [GraphQL: createAzureTarget]
        /// </summary>
        [Parameter(
            ParameterSetName = "CreateTarget",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Creates an Azure archival target on the Rubrik cluster.
[GraphQL: createAzureTarget]",
            Position = 0
        )]
        public SwitchParameter CreateTarget { get; set; }

        
        /// <summary>
        /// UpdateTarget parameter set
        ///
        /// [GraphQL: updateAzureTarget]
        /// </summary>
        [Parameter(
            ParameterSetName = "UpdateTarget",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"
[GraphQL: updateAzureTarget]",
            Position = 0
        )]
        public SwitchParameter UpdateTarget { get; set; }

        
        /// <summary>
        /// CreateReaderTarget parameter set
        ///
        /// [GraphQL: createAzureReaderTarget]
        /// </summary>
        [Parameter(
            ParameterSetName = "CreateReaderTarget",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Creates reader type for Azure archival location on a CDM cluster.
[GraphQL: createAzureReaderTarget]",
            Position = 0
        )]
        public SwitchParameter CreateReaderTarget { get; set; }

        
        /// <summary>
        /// StartCloudAccountOauth parameter set
        ///
        /// [GraphQL: startAzureCloudAccountOauth]
        /// </summary>
        [Parameter(
            ParameterSetName = "StartCloudAccountOauth",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Initiates a session before doing Azure OAuth flow. If a custom app is configured for the tenant, the client ID of the custom app is returned. Otherwise, the client ID of the default app is returned.
[GraphQL: startAzureCloudAccountOauth]",
            Position = 0
        )]
        public SwitchParameter StartCloudAccountOauth { get; set; }

        
        /// <summary>
        /// CompleteCloudAccountOauth parameter set
        ///
        /// [GraphQL: completeAzureCloudAccountOauth]
        /// </summary>
        [Parameter(
            ParameterSetName = "CompleteCloudAccountOauth",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Complete the Azure OAuth flow and pass the authorization code.
[GraphQL: completeAzureCloudAccountOauth]",
            Position = 0
        )]
        public SwitchParameter CompleteCloudAccountOauth { get; set; }

        
        /// <summary>
        /// SetCloudAccountCustomerAppCredentials parameter set
        ///
        /// [GraphQL: setAzureCloudAccountCustomerAppCredentials]
        /// </summary>
        [Parameter(
            ParameterSetName = "SetCloudAccountCustomerAppCredentials",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Set credentials for the customer application, for the tenant domain name.
[GraphQL: setAzureCloudAccountCustomerAppCredentials]",
            Position = 0
        )]
        public SwitchParameter SetCloudAccountCustomerAppCredentials { get; set; }

        
        /// <summary>
        /// AddCloudAccount parameter set
        ///
        /// [GraphQL: addAzureCloudAccount]
        /// </summary>
        [Parameter(
            ParameterSetName = "AddCloudAccount",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Add the Azure Subscriptions cloud account for the given feature.
[GraphQL: addAzureCloudAccount]",
            Position = 0
        )]
        public SwitchParameter AddCloudAccount { get; set; }

        
        /// <summary>
        /// AddCloudAccountWithoutOauth parameter set
        ///
        /// [GraphQL: addAzureCloudAccountWithoutOauth]
        /// </summary>
        [Parameter(
            ParameterSetName = "AddCloudAccountWithoutOauth",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Add the Azure Subscription cloud account for the given feature without OAuth.
[GraphQL: addAzureCloudAccountWithoutOauth]",
            Position = 0
        )]
        public SwitchParameter AddCloudAccountWithoutOauth { get; set; }

        
        /// <summary>
        /// DeleteCloudAccount parameter set
        ///
        /// [GraphQL: deleteAzureCloudAccount]
        /// </summary>
        [Parameter(
            ParameterSetName = "DeleteCloudAccount",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Delete the Azure Subscriptions cloud account for the given feature.
[GraphQL: deleteAzureCloudAccount]",
            Position = 0
        )]
        public SwitchParameter DeleteCloudAccount { get; set; }

        
        /// <summary>
        /// DeleteCloudAccountWithoutOauth parameter set
        ///
        /// [GraphQL: deleteAzureCloudAccountWithoutOauth]
        /// </summary>
        [Parameter(
            ParameterSetName = "DeleteCloudAccountWithoutOauth",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Delete the Azure Subscriptions cloud account for the given feature without OAuth.
[GraphQL: deleteAzureCloudAccountWithoutOauth]",
            Position = 0
        )]
        public SwitchParameter DeleteCloudAccountWithoutOauth { get; set; }

        
        /// <summary>
        /// UpgradeCloudAccount parameter set
        ///
        /// [GraphQL: upgradeAzureCloudAccount]
        /// </summary>
        [Parameter(
            ParameterSetName = "UpgradeCloudAccount",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Update permissions of the Azure Subscriptions cloud account for given feature.
[GraphQL: upgradeAzureCloudAccount]",
            Position = 0
        )]
        public SwitchParameter UpgradeCloudAccount { get; set; }

        
        /// <summary>
        /// UpdateCustomerAppPermissionForSql parameter set
        ///
        /// [GraphQL: updateCustomerAppPermissionForAzureSql]
        /// </summary>
        [Parameter(
            ParameterSetName = "UpdateCustomerAppPermissionForSql",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Updates the Azure app for the specified account in an idempotent manner to support Azure SQL Database and  Managed Instance Database authentication.
[GraphQL: updateCustomerAppPermissionForAzureSql]",
            Position = 0
        )]
        public SwitchParameter UpdateCustomerAppPermissionForSql { get; set; }

        
        /// <summary>
        /// StartDisableCloudAccountJob parameter set
        ///
        /// [GraphQL: startDisableAzureCloudAccountJob]
        /// </summary>
        [Parameter(
            ParameterSetName = "StartDisableCloudAccountJob",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Start on-demand jobs to disable the feature for the given Azure Cloud Accounts. When completed, the status of cloud account feature will change to Disabled and the feature will become eligible to be deleted.
[GraphQL: startDisableAzureCloudAccountJob]",
            Position = 0
        )]
        public SwitchParameter StartDisableCloudAccountJob { get; set; }

        
        /// <summary>
        /// UpdateCloudAccount parameter set
        ///
        /// [GraphQL: updateAzureCloudAccount]
        /// </summary>
        [Parameter(
            ParameterSetName = "UpdateCloudAccount",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Update names of the Azure Subscriptions cloud account and regions for the given feature.
[GraphQL: updateAzureCloudAccount]",
            Position = 0
        )]
        public SwitchParameter UpdateCloudAccount { get; set; }

        
        /// <summary>
        /// MapCloudAccountToPersistentStorageLocation parameter set
        ///
        /// [GraphQL: mapAzureCloudAccountToPersistentStorageLocation]
        /// </summary>
        [Parameter(
            ParameterSetName = "MapCloudAccountToPersistentStorageLocation",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Map Azure cloud accounts to a persistent storage location.
[GraphQL: mapAzureCloudAccountToPersistentStorageLocation]",
            Position = 0
        )]
        public SwitchParameter MapCloudAccountToPersistentStorageLocation { get; set; }

        
        /// <summary>
        /// AddCloudAccountExocomputeConfigurations parameter set
        ///
        /// [GraphQL: addAzureCloudAccountExocomputeConfigurations]
        /// </summary>
        [Parameter(
            ParameterSetName = "AddCloudAccountExocomputeConfigurations",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Add Exocompute configurations for an Azure Cloud Account.
[GraphQL: addAzureCloudAccountExocomputeConfigurations]",
            Position = 0
        )]
        public SwitchParameter AddCloudAccountExocomputeConfigurations { get; set; }

        
        /// <summary>
        /// DeleteCloudAccountExocomputeConfigurations parameter set
        ///
        /// [GraphQL: deleteAzureCloudAccountExocomputeConfigurations]
        /// </summary>
        [Parameter(
            ParameterSetName = "DeleteCloudAccountExocomputeConfigurations",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Delete Exocompute configurations for an Azure Cloud Account.
[GraphQL: deleteAzureCloudAccountExocomputeConfigurations]",
            Position = 0
        )]
        public SwitchParameter DeleteCloudAccountExocomputeConfigurations { get; set; }

        
        /// <summary>
        /// MapCloudAccountExocomputeSubscription parameter set
        ///
        /// [GraphQL: mapAzureCloudAccountExocomputeSubscription]
        /// </summary>
        [Parameter(
            ParameterSetName = "MapCloudAccountExocomputeSubscription",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Map Azure cloud accounts to an Exocompute subscription.
[GraphQL: mapAzureCloudAccountExocomputeSubscription]",
            Position = 0
        )]
        public SwitchParameter MapCloudAccountExocomputeSubscription { get; set; }

        
        /// <summary>
        /// UnmapCloudAccountExocomputeSubscription parameter set
        ///
        /// [GraphQL: unmapAzureCloudAccountExocomputeSubscription]
        /// </summary>
        [Parameter(
            ParameterSetName = "UnmapCloudAccountExocomputeSubscription",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Unmap Azure cloud accounts from the mapped Exocompute subscription.
[GraphQL: unmapAzureCloudAccountExocomputeSubscription]",
            Position = 0
        )]
        public SwitchParameter UnmapCloudAccountExocomputeSubscription { get; set; }

        
        /// <summary>
        /// UpgradeCloudAccountPermissionsWithoutOauth parameter set
        ///
        /// [GraphQL: upgradeAzureCloudAccountPermissionsWithoutOauth]
        /// </summary>
        [Parameter(
            ParameterSetName = "UpgradeCloudAccountPermissionsWithoutOauth",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Set Azure Cloud Account feature status to Connected from Update Permissions state without any permission validation. It should be used by caution from cloud accounts which have been set up without using OAuth, only after adding the latest permissions that are required.
[GraphQL: upgradeAzureCloudAccountPermissionsWithoutOauth]",
            Position = 0
        )]
        public SwitchParameter UpgradeCloudAccountPermissionsWithoutOauth { get; set; }

        
        /// <summary>
        /// UnmapPersistentStorageSubscription parameter set
        ///
        /// [GraphQL: unmapAzurePersistentStorageSubscription]
        /// </summary>
        [Parameter(
            ParameterSetName = "UnmapPersistentStorageSubscription",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Unmaps the archival location from the subscription.
[GraphQL: unmapAzurePersistentStorageSubscription]",
            Position = 0
        )]
        public SwitchParameter UnmapPersistentStorageSubscription { get; set; }

        
        /// <summary>
        /// OauthConsentKickoff parameter set
        ///
        /// [GraphQL: azureOauthConsentKickoff]
        /// </summary>
        [Parameter(
            ParameterSetName = "OauthConsentKickoff",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Kicks off an OAuth consent flow for Azure resource access.
[GraphQL: azureOauthConsentKickoff]",
            Position = 0
        )]
        public SwitchParameter OauthConsentKickoff { get; set; }

        
        /// <summary>
        /// OauthConsentComplete parameter set
        ///
        /// [GraphQL: azureOauthConsentComplete]
        /// </summary>
        [Parameter(
            ParameterSetName = "OauthConsentComplete",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Completes an OAuth consent flow for Azure resource access.
[GraphQL: azureOauthConsentComplete]",
            Position = 0
        )]
        public SwitchParameter OauthConsentComplete { get; set; }

        
        /// <summary>
        /// CreateSaasAppAad parameter set
        ///
        /// [GraphQL: createAzureSaasAppAad]
        /// </summary>
        [Parameter(
            ParameterSetName = "CreateSaasAppAad",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create or get an Azure AAD application.
[GraphQL: createAzureSaasAppAad]",
            Position = 0
        )]
        public SwitchParameter CreateSaasAppAad { get; set; }

        
        /// <summary>
        /// CreateCluster parameter set
        ///
        /// [GraphQL: createAzureCluster]
        /// </summary>
        [Parameter(
            ParameterSetName = "CreateCluster",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a Rubrik Cloud Cluster on Azure.
[GraphQL: createAzureCluster]",
            Position = 0
        )]
        public SwitchParameter CreateCluster { get; set; }

        
        /// <summary>
        /// DeleteCluster parameter set
        ///
        /// [GraphQL: deleteAzureCluster]
        /// </summary>
        [Parameter(
            ParameterSetName = "DeleteCluster",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Delete a Rubrik Cloud Cluster on Azure.
[GraphQL: deleteAzureCluster]",
            Position = 0
        )]
        public SwitchParameter DeleteCluster { get; set; }


// ignore warning 'Missing XML comment'
#pragma warning disable 1591
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                switch(Op)
                {
                    case "StartRefreshNativeSubscriptionsJob":
                        this.ProcessRecord_StartRefreshNativeSubscriptionsJob();
                        break;
                    case "StartRestoreNativeVirtualMachineJob":
                        this.ProcessRecord_StartRestoreNativeVirtualMachineJob();
                        break;
                    case "StartExportNativeVirtualMachineJob":
                        this.ProcessRecord_StartExportNativeVirtualMachineJob();
                        break;
                    case "ExcludeNativeManagedDisksFromSnapshot":
                        this.ProcessRecord_ExcludeNativeManagedDisksFromSnapshot();
                        break;
                    case "StartCreateNativeVirtualMachineSnapshotsJob":
                        this.ProcessRecord_StartCreateNativeVirtualMachineSnapshotsJob();
                        break;
                    case "StartDisableNativeSubscriptionProtectionJob":
                        this.ProcessRecord_StartDisableNativeSubscriptionProtectionJob();
                        break;
                    case "StartCreateNativeManagedDiskSnapshotsJob":
                        this.ProcessRecord_StartCreateNativeManagedDiskSnapshotsJob();
                        break;
                    case "StartExportNativeManagedDiskJob":
                        this.ProcessRecord_StartExportNativeManagedDiskJob();
                        break;
                    case "StartExportSqlDatabaseDbJob":
                        this.ProcessRecord_StartExportSqlDatabaseDbJob();
                        break;
                    case "StartExportSqlManagedInstanceDbJob":
                        this.ProcessRecord_StartExportSqlManagedInstanceDbJob();
                        break;
                    case "CreateAccount":
                        this.ProcessRecord_CreateAccount();
                        break;
                    case "UpdateAccount":
                        this.ProcessRecord_UpdateAccount();
                        break;
                    case "CreateAutomaticTargetMapping":
                        this.ProcessRecord_CreateAutomaticTargetMapping();
                        break;
                    case "CreateCloudNativeStorageSetting":
                        this.ProcessRecord_CreateCloudNativeStorageSetting();
                        break;
                    case "CreateCloudNativeRcvStorageSetting":
                        this.ProcessRecord_CreateCloudNativeRcvStorageSetting();
                        break;
                    case "UpdateAutomaticTargetMapping":
                        this.ProcessRecord_UpdateAutomaticTargetMapping();
                        break;
                    case "UpdateCloudNativeStorageSetting":
                        this.ProcessRecord_UpdateCloudNativeStorageSetting();
                        break;
                    case "UpdateCloudNativeRcvStorageSetting":
                        this.ProcessRecord_UpdateCloudNativeRcvStorageSetting();
                        break;
                    case "CreateTarget":
                        this.ProcessRecord_CreateTarget();
                        break;
                    case "UpdateTarget":
                        this.ProcessRecord_UpdateTarget();
                        break;
                    case "CreateReaderTarget":
                        this.ProcessRecord_CreateReaderTarget();
                        break;
                    case "StartCloudAccountOauth":
                        this.ProcessRecord_StartCloudAccountOauth();
                        break;
                    case "CompleteCloudAccountOauth":
                        this.ProcessRecord_CompleteCloudAccountOauth();
                        break;
                    case "SetCloudAccountCustomerAppCredentials":
                        this.ProcessRecord_SetCloudAccountCustomerAppCredentials();
                        break;
                    case "AddCloudAccount":
                        this.ProcessRecord_AddCloudAccount();
                        break;
                    case "AddCloudAccountWithoutOauth":
                        this.ProcessRecord_AddCloudAccountWithoutOauth();
                        break;
                    case "DeleteCloudAccount":
                        this.ProcessRecord_DeleteCloudAccount();
                        break;
                    case "DeleteCloudAccountWithoutOauth":
                        this.ProcessRecord_DeleteCloudAccountWithoutOauth();
                        break;
                    case "UpgradeCloudAccount":
                        this.ProcessRecord_UpgradeCloudAccount();
                        break;
                    case "UpdateCustomerAppPermissionForSql":
                        this.ProcessRecord_UpdateCustomerAppPermissionForSql();
                        break;
                    case "StartDisableCloudAccountJob":
                        this.ProcessRecord_StartDisableCloudAccountJob();
                        break;
                    case "UpdateCloudAccount":
                        this.ProcessRecord_UpdateCloudAccount();
                        break;
                    case "MapCloudAccountToPersistentStorageLocation":
                        this.ProcessRecord_MapCloudAccountToPersistentStorageLocation();
                        break;
                    case "AddCloudAccountExocomputeConfigurations":
                        this.ProcessRecord_AddCloudAccountExocomputeConfigurations();
                        break;
                    case "DeleteCloudAccountExocomputeConfigurations":
                        this.ProcessRecord_DeleteCloudAccountExocomputeConfigurations();
                        break;
                    case "MapCloudAccountExocomputeSubscription":
                        this.ProcessRecord_MapCloudAccountExocomputeSubscription();
                        break;
                    case "UnmapCloudAccountExocomputeSubscription":
                        this.ProcessRecord_UnmapCloudAccountExocomputeSubscription();
                        break;
                    case "UpgradeCloudAccountPermissionsWithoutOauth":
                        this.ProcessRecord_UpgradeCloudAccountPermissionsWithoutOauth();
                        break;
                    case "UnmapPersistentStorageSubscription":
                        this.ProcessRecord_UnmapPersistentStorageSubscription();
                        break;
                    case "OauthConsentKickoff":
                        this.ProcessRecord_OauthConsentKickoff();
                        break;
                    case "OauthConsentComplete":
                        this.ProcessRecord_OauthConsentComplete();
                        break;
                    case "CreateSaasAppAad":
                        this.ProcessRecord_CreateSaasAppAad();
                        break;
                    case "CreateCluster":
                        this.ProcessRecord_CreateCluster();
                        break;
                    case "DeleteCluster":
                        this.ProcessRecord_DeleteCluster();
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
        // startRefreshAzureNativeSubscriptionsJob.
        internal void ProcessRecord_StartRefreshNativeSubscriptionsJob()
        {
            this._logger.name += " -StartRefreshNativeSubscriptionsJob";
            // Create new graphql operation startRefreshAzureNativeSubscriptionsJob
            InitMutationStartRefreshAzureNativeSubscriptionsJob();
        }

        // This parameter set invokes a single graphql operation:
        // startRestoreAzureNativeVirtualMachineJob.
        internal void ProcessRecord_StartRestoreNativeVirtualMachineJob()
        {
            this._logger.name += " -StartRestoreNativeVirtualMachineJob";
            // Create new graphql operation startRestoreAzureNativeVirtualMachineJob
            InitMutationStartRestoreAzureNativeVirtualMachineJob();
        }

        // This parameter set invokes a single graphql operation:
        // startExportAzureNativeVirtualMachineJob.
        internal void ProcessRecord_StartExportNativeVirtualMachineJob()
        {
            this._logger.name += " -StartExportNativeVirtualMachineJob";
            // Create new graphql operation startExportAzureNativeVirtualMachineJob
            InitMutationStartExportAzureNativeVirtualMachineJob();
        }

        // This parameter set invokes a single graphql operation:
        // excludeAzureNativeManagedDisksFromSnapshot.
        internal void ProcessRecord_ExcludeNativeManagedDisksFromSnapshot()
        {
            this._logger.name += " -ExcludeNativeManagedDisksFromSnapshot";
            // Create new graphql operation excludeAzureNativeManagedDisksFromSnapshot
            InitMutationExcludeAzureNativeManagedDisksFromSnapshot();
        }

        // This parameter set invokes a single graphql operation:
        // startCreateAzureNativeVirtualMachineSnapshotsJob.
        internal void ProcessRecord_StartCreateNativeVirtualMachineSnapshotsJob()
        {
            this._logger.name += " -StartCreateNativeVirtualMachineSnapshotsJob";
            // Create new graphql operation startCreateAzureNativeVirtualMachineSnapshotsJob
            InitMutationStartCreateAzureNativeVirtualMachineSnapshotsJob();
        }

        // This parameter set invokes a single graphql operation:
        // startDisableAzureNativeSubscriptionProtectionJob.
        internal void ProcessRecord_StartDisableNativeSubscriptionProtectionJob()
        {
            this._logger.name += " -StartDisableNativeSubscriptionProtectionJob";
            // Create new graphql operation startDisableAzureNativeSubscriptionProtectionJob
            InitMutationStartDisableAzureNativeSubscriptionProtectionJob();
        }

        // This parameter set invokes a single graphql operation:
        // startCreateAzureNativeManagedDiskSnapshotsJob.
        internal void ProcessRecord_StartCreateNativeManagedDiskSnapshotsJob()
        {
            this._logger.name += " -StartCreateNativeManagedDiskSnapshotsJob";
            // Create new graphql operation startCreateAzureNativeManagedDiskSnapshotsJob
            InitMutationStartCreateAzureNativeManagedDiskSnapshotsJob();
        }

        // This parameter set invokes a single graphql operation:
        // startExportAzureNativeManagedDiskJob.
        internal void ProcessRecord_StartExportNativeManagedDiskJob()
        {
            this._logger.name += " -StartExportNativeManagedDiskJob";
            // Create new graphql operation startExportAzureNativeManagedDiskJob
            InitMutationStartExportAzureNativeManagedDiskJob();
        }

        // This parameter set invokes a single graphql operation:
        // startExportAzureSqlDatabaseDbJob.
        internal void ProcessRecord_StartExportSqlDatabaseDbJob()
        {
            this._logger.name += " -StartExportSqlDatabaseDbJob";
            // Create new graphql operation startExportAzureSqlDatabaseDbJob
            InitMutationStartExportAzureSqlDatabaseDbJob();
        }

        // This parameter set invokes a single graphql operation:
        // startExportAzureSqlManagedInstanceDbJob.
        internal void ProcessRecord_StartExportSqlManagedInstanceDbJob()
        {
            this._logger.name += " -StartExportSqlManagedInstanceDbJob";
            // Create new graphql operation startExportAzureSqlManagedInstanceDbJob
            InitMutationStartExportAzureSqlManagedInstanceDbJob();
        }

        // This parameter set invokes a single graphql operation:
        // createAzureAccount.
        internal void ProcessRecord_CreateAccount()
        {
            this._logger.name += " -CreateAccount";
            // Create new graphql operation createAzureAccount
            InitMutationCreateAzureAccount();
        }

        // This parameter set invokes a single graphql operation:
        // updateAzureAccount.
        internal void ProcessRecord_UpdateAccount()
        {
            this._logger.name += " -UpdateAccount";
            // Create new graphql operation updateAzureAccount
            InitMutationUpdateAzureAccount();
        }

        // This parameter set invokes a single graphql operation:
        // createAutomaticAzureTargetMapping.
        internal void ProcessRecord_CreateAutomaticTargetMapping()
        {
            this._logger.name += " -CreateAutomaticTargetMapping";
            // Create new graphql operation createAutomaticAzureTargetMapping
            InitMutationCreateAutomaticAzureTargetMapping();
        }

        // This parameter set invokes a single graphql operation:
        // createCloudNativeAzureStorageSetting.
        internal void ProcessRecord_CreateCloudNativeStorageSetting()
        {
            this._logger.name += " -CreateCloudNativeStorageSetting";
            // Create new graphql operation createCloudNativeAzureStorageSetting
            InitMutationCreateCloudNativeAzureStorageSetting();
        }

        // This parameter set invokes a single graphql operation:
        // createCloudNativeRcvAzureStorageSetting.
        internal void ProcessRecord_CreateCloudNativeRcvStorageSetting()
        {
            this._logger.name += " -CreateCloudNativeRcvStorageSetting";
            // Create new graphql operation createCloudNativeRcvAzureStorageSetting
            InitMutationCreateCloudNativeRcvAzureStorageSetting();
        }

        // This parameter set invokes a single graphql operation:
        // updateAutomaticAzureTargetMapping.
        internal void ProcessRecord_UpdateAutomaticTargetMapping()
        {
            this._logger.name += " -UpdateAutomaticTargetMapping";
            // Create new graphql operation updateAutomaticAzureTargetMapping
            InitMutationUpdateAutomaticAzureTargetMapping();
        }

        // This parameter set invokes a single graphql operation:
        // updateCloudNativeAzureStorageSetting.
        internal void ProcessRecord_UpdateCloudNativeStorageSetting()
        {
            this._logger.name += " -UpdateCloudNativeStorageSetting";
            // Create new graphql operation updateCloudNativeAzureStorageSetting
            InitMutationUpdateCloudNativeAzureStorageSetting();
        }

        // This parameter set invokes a single graphql operation:
        // updateCloudNativeRcvAzureStorageSetting.
        internal void ProcessRecord_UpdateCloudNativeRcvStorageSetting()
        {
            this._logger.name += " -UpdateCloudNativeRcvStorageSetting";
            // Create new graphql operation updateCloudNativeRcvAzureStorageSetting
            InitMutationUpdateCloudNativeRcvAzureStorageSetting();
        }

        // This parameter set invokes a single graphql operation:
        // createAzureTarget.
        internal void ProcessRecord_CreateTarget()
        {
            this._logger.name += " -CreateTarget";
            // Create new graphql operation createAzureTarget
            InitMutationCreateAzureTarget();
        }

        // This parameter set invokes a single graphql operation:
        // updateAzureTarget.
        internal void ProcessRecord_UpdateTarget()
        {
            this._logger.name += " -UpdateTarget";
            // Create new graphql operation updateAzureTarget
            InitMutationUpdateAzureTarget();
        }

        // This parameter set invokes a single graphql operation:
        // createAzureReaderTarget.
        internal void ProcessRecord_CreateReaderTarget()
        {
            this._logger.name += " -CreateReaderTarget";
            // Create new graphql operation createAzureReaderTarget
            InitMutationCreateAzureReaderTarget();
        }

        // This parameter set invokes a single graphql operation:
        // startAzureCloudAccountOauth.
        internal void ProcessRecord_StartCloudAccountOauth()
        {
            this._logger.name += " -StartCloudAccountOauth";
            // Create new graphql operation startAzureCloudAccountOauth
            InitMutationStartAzureCloudAccountOauth();
        }

        // This parameter set invokes a single graphql operation:
        // completeAzureCloudAccountOauth.
        internal void ProcessRecord_CompleteCloudAccountOauth()
        {
            this._logger.name += " -CompleteCloudAccountOauth";
            // Create new graphql operation completeAzureCloudAccountOauth
            InitMutationCompleteAzureCloudAccountOauth();
        }

        // This parameter set invokes a single graphql operation:
        // setAzureCloudAccountCustomerAppCredentials.
        internal void ProcessRecord_SetCloudAccountCustomerAppCredentials()
        {
            this._logger.name += " -SetCloudAccountCustomerAppCredentials";
            // Create new graphql operation setAzureCloudAccountCustomerAppCredentials
            InitMutationSetAzureCloudAccountCustomerAppCredentials();
        }

        // This parameter set invokes a single graphql operation:
        // addAzureCloudAccount.
        internal void ProcessRecord_AddCloudAccount()
        {
            this._logger.name += " -AddCloudAccount";
            // Create new graphql operation addAzureCloudAccount
            InitMutationAddAzureCloudAccount();
        }

        // This parameter set invokes a single graphql operation:
        // addAzureCloudAccountWithoutOauth.
        internal void ProcessRecord_AddCloudAccountWithoutOauth()
        {
            this._logger.name += " -AddCloudAccountWithoutOauth";
            // Create new graphql operation addAzureCloudAccountWithoutOauth
            InitMutationAddAzureCloudAccountWithoutOauth();
        }

        // This parameter set invokes a single graphql operation:
        // deleteAzureCloudAccount.
        internal void ProcessRecord_DeleteCloudAccount()
        {
            this._logger.name += " -DeleteCloudAccount";
            // Create new graphql operation deleteAzureCloudAccount
            InitMutationDeleteAzureCloudAccount();
        }

        // This parameter set invokes a single graphql operation:
        // deleteAzureCloudAccountWithoutOauth.
        internal void ProcessRecord_DeleteCloudAccountWithoutOauth()
        {
            this._logger.name += " -DeleteCloudAccountWithoutOauth";
            // Create new graphql operation deleteAzureCloudAccountWithoutOauth
            InitMutationDeleteAzureCloudAccountWithoutOauth();
        }

        // This parameter set invokes a single graphql operation:
        // upgradeAzureCloudAccount.
        internal void ProcessRecord_UpgradeCloudAccount()
        {
            this._logger.name += " -UpgradeCloudAccount";
            // Create new graphql operation upgradeAzureCloudAccount
            InitMutationUpgradeAzureCloudAccount();
        }

        // This parameter set invokes a single graphql operation:
        // updateCustomerAppPermissionForAzureSql.
        internal void ProcessRecord_UpdateCustomerAppPermissionForSql()
        {
            this._logger.name += " -UpdateCustomerAppPermissionForSql";
            // Create new graphql operation updateCustomerAppPermissionForAzureSql
            InitMutationUpdateCustomerAppPermissionForAzureSql();
        }

        // This parameter set invokes a single graphql operation:
        // startDisableAzureCloudAccountJob.
        internal void ProcessRecord_StartDisableCloudAccountJob()
        {
            this._logger.name += " -StartDisableCloudAccountJob";
            // Create new graphql operation startDisableAzureCloudAccountJob
            InitMutationStartDisableAzureCloudAccountJob();
        }

        // This parameter set invokes a single graphql operation:
        // updateAzureCloudAccount.
        internal void ProcessRecord_UpdateCloudAccount()
        {
            this._logger.name += " -UpdateCloudAccount";
            // Create new graphql operation updateAzureCloudAccount
            InitMutationUpdateAzureCloudAccount();
        }

        // This parameter set invokes a single graphql operation:
        // mapAzureCloudAccountToPersistentStorageLocation.
        internal void ProcessRecord_MapCloudAccountToPersistentStorageLocation()
        {
            this._logger.name += " -MapCloudAccountToPersistentStorageLocation";
            // Create new graphql operation mapAzureCloudAccountToPersistentStorageLocation
            InitMutationMapAzureCloudAccountToPersistentStorageLocation();
        }

        // This parameter set invokes a single graphql operation:
        // addAzureCloudAccountExocomputeConfigurations.
        internal void ProcessRecord_AddCloudAccountExocomputeConfigurations()
        {
            this._logger.name += " -AddCloudAccountExocomputeConfigurations";
            // Create new graphql operation addAzureCloudAccountExocomputeConfigurations
            InitMutationAddAzureCloudAccountExocomputeConfigurations();
        }

        // This parameter set invokes a single graphql operation:
        // deleteAzureCloudAccountExocomputeConfigurations.
        internal void ProcessRecord_DeleteCloudAccountExocomputeConfigurations()
        {
            this._logger.name += " -DeleteCloudAccountExocomputeConfigurations";
            // Create new graphql operation deleteAzureCloudAccountExocomputeConfigurations
            InitMutationDeleteAzureCloudAccountExocomputeConfigurations();
        }

        // This parameter set invokes a single graphql operation:
        // mapAzureCloudAccountExocomputeSubscription.
        internal void ProcessRecord_MapCloudAccountExocomputeSubscription()
        {
            this._logger.name += " -MapCloudAccountExocomputeSubscription";
            // Create new graphql operation mapAzureCloudAccountExocomputeSubscription
            InitMutationMapAzureCloudAccountExocomputeSubscription();
        }

        // This parameter set invokes a single graphql operation:
        // unmapAzureCloudAccountExocomputeSubscription.
        internal void ProcessRecord_UnmapCloudAccountExocomputeSubscription()
        {
            this._logger.name += " -UnmapCloudAccountExocomputeSubscription";
            // Create new graphql operation unmapAzureCloudAccountExocomputeSubscription
            InitMutationUnmapAzureCloudAccountExocomputeSubscription();
        }

        // This parameter set invokes a single graphql operation:
        // upgradeAzureCloudAccountPermissionsWithoutOauth.
        internal void ProcessRecord_UpgradeCloudAccountPermissionsWithoutOauth()
        {
            this._logger.name += " -UpgradeCloudAccountPermissionsWithoutOauth";
            // Create new graphql operation upgradeAzureCloudAccountPermissionsWithoutOauth
            InitMutationUpgradeAzureCloudAccountPermissionsWithoutOauth();
        }

        // This parameter set invokes a single graphql operation:
        // unmapAzurePersistentStorageSubscription.
        internal void ProcessRecord_UnmapPersistentStorageSubscription()
        {
            this._logger.name += " -UnmapPersistentStorageSubscription";
            // Create new graphql operation unmapAzurePersistentStorageSubscription
            InitMutationUnmapAzurePersistentStorageSubscription();
        }

        // This parameter set invokes a single graphql operation:
        // azureOauthConsentKickoff.
        internal void ProcessRecord_OauthConsentKickoff()
        {
            this._logger.name += " -OauthConsentKickoff";
            // Create new graphql operation azureOauthConsentKickoff
            InitMutationAzureOauthConsentKickoff();
        }

        // This parameter set invokes a single graphql operation:
        // azureOauthConsentComplete.
        internal void ProcessRecord_OauthConsentComplete()
        {
            this._logger.name += " -OauthConsentComplete";
            // Create new graphql operation azureOauthConsentComplete
            InitMutationAzureOauthConsentComplete();
        }

        // This parameter set invokes a single graphql operation:
        // createAzureSaasAppAad.
        internal void ProcessRecord_CreateSaasAppAad()
        {
            this._logger.name += " -CreateSaasAppAad";
            // Create new graphql operation createAzureSaasAppAad
            InitMutationCreateAzureSaasAppAad();
        }

        // This parameter set invokes a single graphql operation:
        // createAzureCluster.
        internal void ProcessRecord_CreateCluster()
        {
            this._logger.name += " -CreateCluster";
            // Create new graphql operation createAzureCluster
            InitMutationCreateAzureCluster();
        }

        // This parameter set invokes a single graphql operation:
        // deleteAzureCluster.
        internal void ProcessRecord_DeleteCluster()
        {
            this._logger.name += " -DeleteCluster";
            // Create new graphql operation deleteAzureCluster
            InitMutationDeleteAzureCluster();
        }


        // Create new GraphQL Mutation:
        // startRefreshAzureNativeSubscriptionsJob(input: StartRefreshAzureNativeSubscriptionsJobInput!): BatchAsyncJobStatus!
        internal void InitMutationStartRefreshAzureNativeSubscriptionsJob()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "StartRefreshAzureNativeSubscriptionsJobInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationStartRefreshAzureNativeSubscriptionsJob",
                "($input: StartRefreshAzureNativeSubscriptionsJobInput!)",
                "BatchAsyncJobStatus",
                Mutation.StartRefreshAzureNativeSubscriptionsJob_ObjectFieldSpec,
                Mutation.StartRefreshAzureNativeSubscriptionsJobFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	azureSubscriptionRubrikIds = @(
		<System.String>
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // startRestoreAzureNativeVirtualMachineJob(input: StartRestoreAzureNativeVirtualMachineJobInput!): AsyncJobStatus!
        internal void InitMutationStartRestoreAzureNativeVirtualMachineJob()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "StartRestoreAzureNativeVirtualMachineJobInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationStartRestoreAzureNativeVirtualMachineJob",
                "($input: StartRestoreAzureNativeVirtualMachineJobInput!)",
                "AsyncJobStatus",
                Mutation.StartRestoreAzureNativeVirtualMachineJob_ObjectFieldSpec,
                Mutation.StartRestoreAzureNativeVirtualMachineJobFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	snapshotId = <System.String>
	# REQUIRED
	shouldPowerOn = <System.Boolean>
	# REQUIRED
	shouldRestoreTags = <System.Boolean>
	# OPTIONAL
	snapshotTypeToUseIfSourceExpired = <SnapshotTypeForRestoreIfSourceExpired> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SnapshotTypeForRestoreIfSourceExpired]) for enum values.
	# OPTIONAL
	recoveryDiskIds = @(
		<System.String>
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // startExportAzureNativeVirtualMachineJob(input: StartExportAzureNativeVirtualMachineJobInput!): AsyncJobStatus!
        internal void InitMutationStartExportAzureNativeVirtualMachineJob()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "StartExportAzureNativeVirtualMachineJobInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationStartExportAzureNativeVirtualMachineJob",
                "($input: StartExportAzureNativeVirtualMachineJobInput!)",
                "AsyncJobStatus",
                Mutation.StartExportAzureNativeVirtualMachineJob_ObjectFieldSpec,
                Mutation.StartExportAzureNativeVirtualMachineJobFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	snapshotId = <System.String>
	# REQUIRED
	virtualMachineName = <System.String>
	# OPTIONAL
	diskEncryptionSetNativeId = <System.String>
	# REQUIRED
	resourceGroupName = <System.String>
	# REQUIRED
	destinationRegion = <AzureNativeRegion> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeRegion]) for enum values.
	# OPTIONAL
	destinationAvailabilityZone = <System.String>
	# OPTIONAL
	destinationSubscriptionRubrikId = <System.String>
	# REQUIRED
	virtualMachineSize = <System.String>
	# REQUIRED
	subnetNativeId = <System.String>
	# OPTIONAL
	networkSecurityGroupNativeId = <System.String>
	# REQUIRED
	shouldExportTags = <System.Boolean>
	# REQUIRED
	shouldPowerOff = <System.Boolean>
	# OPTIONAL
	shouldUseReplica = <System.Boolean>
	# OPTIONAL
	availabilitySetNativeId = <System.String>
	# OPTIONAL
	shouldEnableAcceleratedNetworking = <System.Boolean>
	# OPTIONAL
	snapshotType = <AzureSnapshotType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureSnapshotType]) for enum values.
	# OPTIONAL
	recoveryDiskIds = @(
		<System.String>
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // excludeAzureNativeManagedDisksFromSnapshot(input: ExcludeAzureNativeManagedDisksFromSnapshotInput!): Void
        internal void InitMutationExcludeAzureNativeManagedDisksFromSnapshot()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "ExcludeAzureNativeManagedDisksFromSnapshotInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationExcludeAzureNativeManagedDisksFromSnapshot",
                "($input: ExcludeAzureNativeManagedDisksFromSnapshotInput!)",
                "System.String",
                Mutation.ExcludeAzureNativeManagedDisksFromSnapshot_ObjectFieldSpec,
                Mutation.ExcludeAzureNativeManagedDisksFromSnapshotFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	virtualMachineRubrikId = <System.String>
	# REQUIRED
	managedDiskExclusions = @(
		@{
			# REQUIRED
			managedDiskRubrikId = <System.String>
			# REQUIRED
			isExcludedFromSnapshot = <System.Boolean>
		}
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // startCreateAzureNativeVirtualMachineSnapshotsJob(input: StartCreateAzureNativeVirtualMachineSnapshotsJobInput!): BatchAsyncJobStatus!
        internal void InitMutationStartCreateAzureNativeVirtualMachineSnapshotsJob()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "StartCreateAzureNativeVirtualMachineSnapshotsJobInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationStartCreateAzureNativeVirtualMachineSnapshotsJob",
                "($input: StartCreateAzureNativeVirtualMachineSnapshotsJobInput!)",
                "BatchAsyncJobStatus",
                Mutation.StartCreateAzureNativeVirtualMachineSnapshotsJob_ObjectFieldSpec,
                Mutation.StartCreateAzureNativeVirtualMachineSnapshotsJobFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	virtualMachineRubrikIds = @(
		<System.String>
	)
	# OPTIONAL
	retentionSlaId = <System.String>
}"
            );
        }

        // Create new GraphQL Mutation:
        // startDisableAzureNativeSubscriptionProtectionJob(input: StartDisableAzureNativeSubscriptionProtectionJobInput!): AsyncJobStatus!
        internal void InitMutationStartDisableAzureNativeSubscriptionProtectionJob()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "StartDisableAzureNativeSubscriptionProtectionJobInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationStartDisableAzureNativeSubscriptionProtectionJob",
                "($input: StartDisableAzureNativeSubscriptionProtectionJobInput!)",
                "AsyncJobStatus",
                Mutation.StartDisableAzureNativeSubscriptionProtectionJob_ObjectFieldSpec,
                Mutation.StartDisableAzureNativeSubscriptionProtectionJobFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	azureSubscriptionRubrikId = <System.String>
	# REQUIRED
	shouldDeleteNativeSnapshots = <System.Boolean>
	# REQUIRED
	azureNativeProtectionFeature = <AzureNativeProtectionFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeProtectionFeature]) for enum values.
}"
            );
        }

        // Create new GraphQL Mutation:
        // startCreateAzureNativeManagedDiskSnapshotsJob(input: StartCreateAzureNativeManagedDiskSnapshotsJobInput!): BatchAsyncJobStatus!
        internal void InitMutationStartCreateAzureNativeManagedDiskSnapshotsJob()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "StartCreateAzureNativeManagedDiskSnapshotsJobInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationStartCreateAzureNativeManagedDiskSnapshotsJob",
                "($input: StartCreateAzureNativeManagedDiskSnapshotsJobInput!)",
                "BatchAsyncJobStatus",
                Mutation.StartCreateAzureNativeManagedDiskSnapshotsJob_ObjectFieldSpec,
                Mutation.StartCreateAzureNativeManagedDiskSnapshotsJobFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	managedDiskRubrikIds = @(
		<System.String>
	)
	# OPTIONAL
	retentionSlaId = <System.String>
}"
            );
        }

        // Create new GraphQL Mutation:
        // startExportAzureNativeManagedDiskJob(input: StartExportAzureNativeManagedDiskJobInput!): AsyncJobStatus!
        internal void InitMutationStartExportAzureNativeManagedDiskJob()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "StartExportAzureNativeManagedDiskJobInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationStartExportAzureNativeManagedDiskJob",
                "($input: StartExportAzureNativeManagedDiskJobInput!)",
                "AsyncJobStatus",
                Mutation.StartExportAzureNativeManagedDiskJob_ObjectFieldSpec,
                Mutation.StartExportAzureNativeManagedDiskJobFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	snapshotId = <System.String>
	# REQUIRED
	diskName = <System.String>
	# OPTIONAL
	diskEncryptionSetNativeId = <System.String>
	# REQUIRED
	diskStorageTier = <AzureNativeManagedDiskType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeManagedDiskType]) for enum values.
	# REQUIRED
	diskSize = <System.Int32>
	# REQUIRED
	resourceGroup = <System.String>
	# REQUIRED
	destinationRegion = <AzureNativeRegion> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeRegion]) for enum values.
	# OPTIONAL
	destinationAvailabilityZone = <System.String>
	# OPTIONAL
	destinationSubscriptionRubrikId = <System.String>
	# REQUIRED
	shouldExportTags = <System.Boolean>
	# REQUIRED
	shouldReplaceAttachedManagedDisk = <System.Boolean>
	# OPTIONAL
	shouldUseReplica = <System.Boolean>
	# OPTIONAL
	snapshotType = <AzureSnapshotType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureSnapshotType]) for enum values.
}"
            );
        }

        // Create new GraphQL Mutation:
        // startExportAzureSqlDatabaseDbJob(input: StartExportAzureSqlDatabaseDbJobInput!): AsyncJobStatus!
        internal void InitMutationStartExportAzureSqlDatabaseDbJob()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "StartExportAzureSqlDatabaseDbJobInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationStartExportAzureSqlDatabaseDbJob",
                "($input: StartExportAzureSqlDatabaseDbJobInput!)",
                "AsyncJobStatus",
                Mutation.StartExportAzureSqlDatabaseDbJob_ObjectFieldSpec,
                Mutation.StartExportAzureSqlDatabaseDbJobFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	sourceDatabaseRubrikId = <System.String>
	# REQUIRED
	destinationDatabaseName = <System.String>
	# OPTIONAL
	destinationServerRubrikId = <System.String>
	# OPTIONAL
	elasticPoolName = <System.String>
	# REQUIRED
	shouldExportTags = <System.Boolean>
	# OPTIONAL
	azureSqlDatabaseDbPitExportInput = @{
		# REQUIRED
		restorePointInTime = <DateTime>
		# OPTIONAL
		dbBackupRedundancy = <AzureSqlBackupStorageRedundancyType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureSqlBackupStorageRedundancyType]) for enum values.
	}
	# OPTIONAL
	azureSqlDatabaseDbLtrExportInput = @{
		# REQUIRED
		sourceSnapshotRubrikId = <System.String>
		# REQUIRED
		destinationResourceGroupName = <System.String>
		# REQUIRED
		destinationServerName = <System.String>
		# REQUIRED
		destinationRegionName = <System.String>
		# OPTIONAL
		dbBackupRedundancy = <AzureSqlBackupStorageRedundancyType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureSqlBackupStorageRedundancyType]) for enum values.
	}
	# OPTIONAL
	persistentBackupExportInput = @{
		# REQUIRED
		sourceSnapshotRubrikId = <System.String>
		# OPTIONAL
		destinationServerCredentials = @{
			# REQUIRED
			login = <System.String>
			# REQUIRED
			password = <System.String>
		}
		# OPTIONAL
		authMechanism = <SqlAuthenticationMechanism> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SqlAuthenticationMechanism]) for enum values.
		# OPTIONAL
		sessionId = <System.String>
		# OPTIONAL
		dbBackupRedundancy = <AzureSqlBackupStorageRedundancyType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureSqlBackupStorageRedundancyType]) for enum values.
	}
	# OPTIONAL
	serviceTier = <System.String>
	# OPTIONAL
	serviceObjectiveName = <System.String>
}"
            );
        }

        // Create new GraphQL Mutation:
        // startExportAzureSqlManagedInstanceDbJob(input: StartExportAzureSqlManagedInstanceDbJobInput!): AsyncJobStatus!
        internal void InitMutationStartExportAzureSqlManagedInstanceDbJob()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "StartExportAzureSqlManagedInstanceDbJobInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationStartExportAzureSqlManagedInstanceDbJob",
                "($input: StartExportAzureSqlManagedInstanceDbJobInput!)",
                "AsyncJobStatus",
                Mutation.StartExportAzureSqlManagedInstanceDbJob_ObjectFieldSpec,
                Mutation.StartExportAzureSqlManagedInstanceDbJobFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	sourceManagedInstanceDatabaseRubrikId = <System.String>
	# OPTIONAL
	destinationManagedInstanceRubrikId = <System.String>
	# REQUIRED
	destinationDatabaseName = <System.String>
	# REQUIRED
	destinationManagedInstanceName = <System.String>
	# REQUIRED
	destinationResourceGroupName = <System.String>
	# OPTIONAL
	azureSqlManagedInstanceDbPitExportInput = @{
		# REQUIRED
		restorePointInTime = <DateTime>
	}
	# OPTIONAL
	azureSqlManagedInstanceDbLtrExportInput = @{
		# REQUIRED
		sourceSnapshotRubrikId = <System.String>
		# REQUIRED
		destinationRegionName = <System.String>
	}
	# OPTIONAL
	persistentBackupExportInput = @{
		# REQUIRED
		sourceSnapshotRubrikId = <System.String>
		# OPTIONAL
		destinationServerCredentials = @{
			# REQUIRED
			login = <System.String>
			# REQUIRED
			password = <System.String>
		}
		# OPTIONAL
		authMechanism = <SqlAuthenticationMechanism> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SqlAuthenticationMechanism]) for enum values.
		# OPTIONAL
		sessionId = <System.String>
		# OPTIONAL
		dbBackupRedundancy = <AzureSqlBackupStorageRedundancyType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureSqlBackupStorageRedundancyType]) for enum values.
	}
	# OPTIONAL
	serviceTier = <System.String>
	# OPTIONAL
	serviceObjectiveName = <System.String>
}"
            );
        }

        // Create new GraphQL Mutation:
        // createAzureAccount(input: CreateAzureAccountInput!): CloudAccount!
        internal void InitMutationCreateAzureAccount()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateAzureAccountInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateAzureAccount",
                "($input: CreateAzureAccountInput!)",
                "CloudAccount",
                Mutation.CreateAzureAccount_ObjectFieldSpec,
                Mutation.CreateAzureAccountFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	name = <System.String>
	# OPTIONAL
	description = <System.String>
	# REQUIRED
	subscriptionId = <System.String>
}"
            );
        }

        // Create new GraphQL Mutation:
        // updateAzureAccount(input: UpdateAzureAccountInput!): CloudAccount!
        internal void InitMutationUpdateAzureAccount()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateAzureAccountInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateAzureAccount",
                "($input: UpdateAzureAccountInput!)",
                "CloudAccount",
                Mutation.UpdateAzureAccount_ObjectFieldSpec,
                Mutation.UpdateAzureAccountFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
	# OPTIONAL
	name = <System.String>
	# OPTIONAL
	description = <System.String>
	# OPTIONAL
	subscriptionId = <System.String>
}"
            );
        }

        // Create new GraphQL Mutation:
        // createAutomaticAzureTargetMapping(input: CreateAutomaticAzureTargetMappingInput!): TargetMapping!
        internal void InitMutationCreateAutomaticAzureTargetMapping()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateAutomaticAzureTargetMappingInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateAutomaticAzureTargetMapping",
                "($input: CreateAutomaticAzureTargetMappingInput!)",
                "TargetMapping",
                Mutation.CreateAutomaticAzureTargetMapping_ObjectFieldSpec,
                Mutation.CreateAutomaticAzureTargetMappingFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	name = <System.String>
	# REQUIRED
	storageAccountName = <System.String>
	# REQUIRED
	accessKey = <System.String>
	# REQUIRED
	containerNamePrefix = <System.String>
	# REQUIRED
	cloudAccountId = <System.String>
	# REQUIRED
	instanceType = <InstanceTypeEnum> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.InstanceTypeEnum]) for enum values.
	# REQUIRED
	rsaKey = <System.String>
	# OPTIONAL
	computeSettings = @{
		# OPTIONAL
		appId = <System.String>
		# OPTIONAL
		appSecretKey = <System.String>
		# OPTIONAL
		region = <AzureRegion> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureRegion]) for enum values.
		# OPTIONAL
		generalPurposeStorageName = <System.String>
		# OPTIONAL
		generalPurposeStorageContainer = <System.String>
		# OPTIONAL
		resourceGroup = <System.String>
		# OPTIONAL
		virtualNetworkId = <System.String>
		# OPTIONAL
		subnetId = <System.String>
		# OPTIONAL
		securityGroupId = <System.String>
		# OPTIONAL
		computeProxySettings = @{
			# OPTIONAL
			proxyServer = <System.String>
			# OPTIONAL
			portNumber = <System.Int32>
			# OPTIONAL
			username = <System.String>
			# OPTIONAL
			password = <System.String>
			# OPTIONAL
			protocol = <System.String>
		}
		# OPTIONAL
		cloudAccountId = <System.String>
	}
	# OPTIONAL
	proxySettings = @{
		# OPTIONAL
		proxyServer = <System.String>
		# OPTIONAL
		portNumber = <System.Int32>
		# OPTIONAL
		username = <System.String>
		# OPTIONAL
		password = <System.String>
		# OPTIONAL
		protocol = <System.String>
	}
	# OPTIONAL
	clusterUuidList = @(
		<System.String>
	)
	# REQUIRED
	isConsolidationEnabled = <System.Boolean>
}"
            );
        }

        // Create new GraphQL Mutation:
        // createCloudNativeAzureStorageSetting(input: CreateCloudNativeAzureStorageSettingInput!): CreateCloudNativeAzureStorageSettingReply!
        internal void InitMutationCreateCloudNativeAzureStorageSetting()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateCloudNativeAzureStorageSettingInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateCloudNativeAzureStorageSetting",
                "($input: CreateCloudNativeAzureStorageSettingInput!)",
                "CreateCloudNativeAzureStorageSettingReply",
                Mutation.CreateCloudNativeAzureStorageSetting_ObjectFieldSpec,
                Mutation.CreateCloudNativeAzureStorageSettingFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	name = <System.String>
	# REQUIRED
	cloudAccountId = <System.String>
	# REQUIRED
	storageAccountName = <System.String>
	# REQUIRED
	containerName = <System.String>
	# OPTIONAL
	storageAccountTags = @{
		# REQUIRED
		tagList = @(
			@{
				# REQUIRED
				key = <System.String>
				# REQUIRED
				value = <System.String>
			}
		)
	}
	# OPTIONAL
	storageAccountRegion = <AzureRegion> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureRegion]) for enum values.
	# REQUIRED
	storageTier = <AzureStorageTier> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureStorageTier]) for enum values.
	# REQUIRED
	redundancy = <AzureRedundancy> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureRedundancy]) for enum values.
	# REQUIRED
	subscriptionNativeId = <System.String>
	# REQUIRED
	cloudNativeLocTemplateType = <CloudNativeLocTemplateType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudNativeLocTemplateType]) for enum values.
	# OPTIONAL
	cmkInfo = @(
		@{
			# OPTIONAL
			keyVaultName = <System.String>
			# OPTIONAL
			keyName = <System.String>
			# OPTIONAL
			region = <AzureRegion> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureRegion]) for enum values.
		}
	)
	# OPTIONAL
	azureCloudType = <AzureCloudType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureCloudType]) for enum values.
}"
            );
        }

        // Create new GraphQL Mutation:
        // createCloudNativeRcvAzureStorageSetting(input: CreateCloudNativeRcvAzureStorageSettingInput!): CreateCloudNativeRcvAzureStorageSettingReply!
        internal void InitMutationCreateCloudNativeRcvAzureStorageSetting()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateCloudNativeRcvAzureStorageSettingInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateCloudNativeRcvAzureStorageSetting",
                "($input: CreateCloudNativeRcvAzureStorageSettingInput!)",
                "CreateCloudNativeRcvAzureStorageSettingReply",
                Mutation.CreateCloudNativeRcvAzureStorageSetting_ObjectFieldSpec,
                Mutation.CreateCloudNativeRcvAzureStorageSettingFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	name = <System.String>
	# REQUIRED
	region = <AzureRegion> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureRegion]) for enum values.
	# REQUIRED
	cloudNativeLocTemplateType = <CloudNativeLocTemplateType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudNativeLocTemplateType]) for enum values.
}"
            );
        }

        // Create new GraphQL Mutation:
        // updateAutomaticAzureTargetMapping(input: UpdateAutomaticAzureTargetMappingInput!): TargetMapping!
        internal void InitMutationUpdateAutomaticAzureTargetMapping()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateAutomaticAzureTargetMappingInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateAutomaticAzureTargetMapping",
                "($input: UpdateAutomaticAzureTargetMappingInput!)",
                "TargetMapping",
                Mutation.UpdateAutomaticAzureTargetMapping_ObjectFieldSpec,
                Mutation.UpdateAutomaticAzureTargetMappingFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
	# OPTIONAL
	name = <System.String>
	# OPTIONAL
	storageAccountName = <System.String>
	# OPTIONAL
	accessKey = <System.String>
	# OPTIONAL
	cloudAccountId = <System.String>
	# OPTIONAL
	computeSettings = @{
		# OPTIONAL
		appId = <System.String>
		# OPTIONAL
		appSecretKey = <System.String>
		# OPTIONAL
		region = <AzureRegion> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureRegion]) for enum values.
		# OPTIONAL
		generalPurposeStorageName = <System.String>
		# OPTIONAL
		generalPurposeStorageContainer = <System.String>
		# OPTIONAL
		resourceGroup = <System.String>
		# OPTIONAL
		virtualNetworkId = <System.String>
		# OPTIONAL
		subnetId = <System.String>
		# OPTIONAL
		securityGroupId = <System.String>
		# OPTIONAL
		computeProxySettings = @{
			# OPTIONAL
			proxyServer = <System.String>
			# OPTIONAL
			portNumber = <System.Int32>
			# OPTIONAL
			username = <System.String>
			# OPTIONAL
			password = <System.String>
			# OPTIONAL
			protocol = <System.String>
		}
		# OPTIONAL
		cloudAccountId = <System.String>
	}
	# OPTIONAL
	proxySettings = @{
		# OPTIONAL
		proxyServer = <System.String>
		# OPTIONAL
		portNumber = <System.Int32>
		# OPTIONAL
		username = <System.String>
		# OPTIONAL
		password = <System.String>
		# OPTIONAL
		protocol = <System.String>
	}
	# OPTIONAL
	clusterUuidList = @(
		<System.String>
	)
	# OPTIONAL
	isConsolidationEnabled = <System.Boolean>
}"
            );
        }

        // Create new GraphQL Mutation:
        // updateCloudNativeAzureStorageSetting(input: UpdateCloudNativeAzureStorageSettingInput!): UpdateCloudNativeAzureStorageSettingReply!
        internal void InitMutationUpdateCloudNativeAzureStorageSetting()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateCloudNativeAzureStorageSettingInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateCloudNativeAzureStorageSetting",
                "($input: UpdateCloudNativeAzureStorageSettingInput!)",
                "UpdateCloudNativeAzureStorageSettingReply",
                Mutation.UpdateCloudNativeAzureStorageSetting_ObjectFieldSpec,
                Mutation.UpdateCloudNativeAzureStorageSettingFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
	# REQUIRED
	name = <System.String>
	# REQUIRED
	storageAccountTags = @{
		# REQUIRED
		tagList = @(
			@{
				# REQUIRED
				key = <System.String>
				# REQUIRED
				value = <System.String>
			}
		)
	}
	# REQUIRED
	storageTier = <AzureStorageTier> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureStorageTier]) for enum values.
	# OPTIONAL
	cmkInfo = @(
		@{
			# OPTIONAL
			keyVaultName = <System.String>
			# OPTIONAL
			keyName = <System.String>
			# OPTIONAL
			region = <AzureRegion> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureRegion]) for enum values.
		}
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // updateCloudNativeRcvAzureStorageSetting(input: UpdateCloudNativeRcvAzureStorageSettingInput!): UpdateCloudNativeRcvAzureStorageSettingReply!
        internal void InitMutationUpdateCloudNativeRcvAzureStorageSetting()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateCloudNativeRcvAzureStorageSettingInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateCloudNativeRcvAzureStorageSetting",
                "($input: UpdateCloudNativeRcvAzureStorageSettingInput!)",
                "UpdateCloudNativeRcvAzureStorageSettingReply",
                Mutation.UpdateCloudNativeRcvAzureStorageSetting_ObjectFieldSpec,
                Mutation.UpdateCloudNativeRcvAzureStorageSettingFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
	# REQUIRED
	name = <System.String>
}"
            );
        }

        // Create new GraphQL Mutation:
        // createAzureTarget(input: CreateAzureTargetInput!): Target!
        internal void InitMutationCreateAzureTarget()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateAzureTargetInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateAzureTarget",
                "($input: CreateAzureTargetInput!)",
                "Target",
                Mutation.CreateAzureTarget_ObjectFieldSpec,
                Mutation.CreateAzureTargetFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	clusterUuid = <System.String>
	# REQUIRED
	name = <System.String>
	# REQUIRED
	storageAccountName = <System.String>
	# REQUIRED
	accessKey = <System.String>
	# REQUIRED
	containerName = <System.String>
	# REQUIRED
	cloudAccountId = <System.String>
	# REQUIRED
	instanceType = <InstanceTypeEnum> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.InstanceTypeEnum]) for enum values.
	# REQUIRED
	rsaKey = <System.String>
	# OPTIONAL
	computeSettings = @{
		# OPTIONAL
		appId = <System.String>
		# OPTIONAL
		appSecretKey = <System.String>
		# OPTIONAL
		region = <AzureRegion> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureRegion]) for enum values.
		# OPTIONAL
		generalPurposeStorageName = <System.String>
		# OPTIONAL
		generalPurposeStorageContainer = <System.String>
		# OPTIONAL
		resourceGroup = <System.String>
		# OPTIONAL
		virtualNetworkId = <System.String>
		# OPTIONAL
		subnetId = <System.String>
		# OPTIONAL
		securityGroupId = <System.String>
		# OPTIONAL
		computeProxySettings = @{
			# OPTIONAL
			proxyServer = <System.String>
			# OPTIONAL
			portNumber = <System.Int32>
			# OPTIONAL
			username = <System.String>
			# OPTIONAL
			password = <System.String>
			# OPTIONAL
			protocol = <System.String>
		}
		# OPTIONAL
		cloudAccountId = <System.String>
	}
	# OPTIONAL
	proxySettings = @{
		# OPTIONAL
		proxyServer = <System.String>
		# OPTIONAL
		portNumber = <System.Int32>
		# OPTIONAL
		username = <System.String>
		# OPTIONAL
		password = <System.String>
		# OPTIONAL
		protocol = <System.String>
	}
	# REQUIRED
	isConsolidationEnabled = <System.Boolean>
	# OPTIONAL
	immutabilitySettings = @{
		# OPTIONAL
		lockDurationDays = <System.Int32>
	}
	# OPTIONAL
	retrievalTier = <AzureRetrievalTier> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureRetrievalTier]) for enum values.
	# REQUIRED
	bypassProxy = <System.Boolean>
}"
            );
        }

        // Create new GraphQL Mutation:
        // updateAzureTarget(input: UpdateAzureTargetInput!): Target!
        internal void InitMutationUpdateAzureTarget()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateAzureTargetInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateAzureTarget",
                "($input: UpdateAzureTargetInput!)",
                "Target",
                Mutation.UpdateAzureTarget_ObjectFieldSpec,
                Mutation.UpdateAzureTargetFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
	# OPTIONAL
	name = <System.String>
	# OPTIONAL
	storageAccountName = <System.String>
	# OPTIONAL
	accessKey = <System.String>
	# OPTIONAL
	cloudAccountId = <System.String>
	# OPTIONAL
	computeSettings = @{
		# OPTIONAL
		appId = <System.String>
		# OPTIONAL
		appSecretKey = <System.String>
		# OPTIONAL
		region = <AzureRegion> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureRegion]) for enum values.
		# OPTIONAL
		generalPurposeStorageName = <System.String>
		# OPTIONAL
		generalPurposeStorageContainer = <System.String>
		# OPTIONAL
		resourceGroup = <System.String>
		# OPTIONAL
		virtualNetworkId = <System.String>
		# OPTIONAL
		subnetId = <System.String>
		# OPTIONAL
		securityGroupId = <System.String>
		# OPTIONAL
		computeProxySettings = @{
			# OPTIONAL
			proxyServer = <System.String>
			# OPTIONAL
			portNumber = <System.Int32>
			# OPTIONAL
			username = <System.String>
			# OPTIONAL
			password = <System.String>
			# OPTIONAL
			protocol = <System.String>
		}
		# OPTIONAL
		cloudAccountId = <System.String>
	}
	# OPTIONAL
	proxySettings = @{
		# OPTIONAL
		proxyServer = <System.String>
		# OPTIONAL
		portNumber = <System.Int32>
		# OPTIONAL
		username = <System.String>
		# OPTIONAL
		password = <System.String>
		# OPTIONAL
		protocol = <System.String>
	}
	# OPTIONAL
	isConsolidationEnabled = <System.Boolean>
	# OPTIONAL
	immutabilitySettings = @{
		# OPTIONAL
		lockDurationDays = <System.Int32>
	}
	# OPTIONAL
	retrievalTier = <AzureRetrievalTier> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureRetrievalTier]) for enum values.
	# REQUIRED
	bypassProxy = <System.Boolean>
}"
            );
        }

        // Create new GraphQL Mutation:
        // createAzureReaderTarget(input: CreateAzureReaderTargetInput!): Target!
        internal void InitMutationCreateAzureReaderTarget()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateAzureReaderTargetInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateAzureReaderTarget",
                "($input: CreateAzureReaderTargetInput!)",
                "Target",
                Mutation.CreateAzureReaderTarget_ObjectFieldSpec,
                Mutation.CreateAzureReaderTargetFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	name = <System.String>
	# REQUIRED
	clusterUuid = <System.String>
	# REQUIRED
	storageAccountName = <System.String>
	# REQUIRED
	accessKey = <System.String>
	# REQUIRED
	containerName = <System.String>
	# REQUIRED
	cloudAccountId = <System.String>
	# REQUIRED
	instanceType = <InstanceTypeEnum> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.InstanceTypeEnum]) for enum values.
	# REQUIRED
	rsaKey = <System.String>
	# OPTIONAL
	computeSettings = @{
		# OPTIONAL
		appId = <System.String>
		# OPTIONAL
		appSecretKey = <System.String>
		# OPTIONAL
		region = <AzureRegion> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureRegion]) for enum values.
		# OPTIONAL
		generalPurposeStorageName = <System.String>
		# OPTIONAL
		generalPurposeStorageContainer = <System.String>
		# OPTIONAL
		resourceGroup = <System.String>
		# OPTIONAL
		virtualNetworkId = <System.String>
		# OPTIONAL
		subnetId = <System.String>
		# OPTIONAL
		securityGroupId = <System.String>
		# OPTIONAL
		computeProxySettings = @{
			# OPTIONAL
			proxyServer = <System.String>
			# OPTIONAL
			portNumber = <System.Int32>
			# OPTIONAL
			username = <System.String>
			# OPTIONAL
			password = <System.String>
			# OPTIONAL
			protocol = <System.String>
		}
		# OPTIONAL
		cloudAccountId = <System.String>
	}
	# OPTIONAL
	proxySettings = @{
		# OPTIONAL
		proxyServer = <System.String>
		# OPTIONAL
		portNumber = <System.Int32>
		# OPTIONAL
		username = <System.String>
		# OPTIONAL
		password = <System.String>
		# OPTIONAL
		protocol = <System.String>
	}
	# REQUIRED
	isConsolidationEnabled = <System.Boolean>
	# OPTIONAL
	immutabilitySettings = @{
		# OPTIONAL
		lockDurationDays = <System.Int32>
	}
	# REQUIRED
	readerRetrievalMethod = <ReaderRetrievalMethod> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ReaderRetrievalMethod]) for enum values.
	# OPTIONAL
	retrievalTier = <AzureRetrievalTier> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureRetrievalTier]) for enum values.
	# REQUIRED
	bypassProxy = <System.Boolean>
}"
            );
        }

        // Create new GraphQL Mutation:
        // startAzureCloudAccountOauth(input: StartAzureCloudAccountOauthInput!): StartAzureCloudAccountOauthReply!
        internal void InitMutationStartAzureCloudAccountOauth()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "StartAzureCloudAccountOauthInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationStartAzureCloudAccountOauth",
                "($input: StartAzureCloudAccountOauthInput!)",
                "StartAzureCloudAccountOauthReply",
                Mutation.StartAzureCloudAccountOauth_ObjectFieldSpec,
                Mutation.StartAzureCloudAccountOauthFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# OPTIONAL
	tenantDomainName = <System.String>
	# OPTIONAL
	azureCloudType = <AzureCloudType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureCloudType]) for enum values.
}"
            );
        }

        // Create new GraphQL Mutation:
        // completeAzureCloudAccountOauth(input: CompleteAzureCloudAccountOauthInput!): CompleteAzureCloudAccountOauthReply!
        internal void InitMutationCompleteAzureCloudAccountOauth()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CompleteAzureCloudAccountOauthInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCompleteAzureCloudAccountOauth",
                "($input: CompleteAzureCloudAccountOauthInput!)",
                "CompleteAzureCloudAccountOauthReply",
                Mutation.CompleteAzureCloudAccountOauth_ObjectFieldSpec,
                Mutation.CompleteAzureCloudAccountOauthFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	sessionId = <System.String>
	# REQUIRED
	tenantDomainName = <System.String>
	# REQUIRED
	authorizationCode = <System.String>
	# REQUIRED
	redirectUrl = <System.String>
	# REQUIRED
	features = @(
		<CloudAccountFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
	)
	# OPTIONAL
	appId = <System.String>
	# OPTIONAL
	appSecretKey = <System.String>
	# REQUIRED
	shouldSkipPermissionChecks = <System.Boolean>
	# OPTIONAL
	azureCloudType = <AzureCloudType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureCloudType]) for enum values.
	# OPTIONAL
	resource = <AzureOauthResource> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureOauthResource]) for enum values.
	# OPTIONAL
	performBasicOauth = <System.Boolean>
	# OPTIONAL
	shouldKeepRefreshToken = <System.Boolean>
}"
            );
        }

        // Create new GraphQL Mutation:
        // setAzureCloudAccountCustomerAppCredentials(input: SetAzureCloudAccountCustomerAppCredentialsInput!): Boolean!
        internal void InitMutationSetAzureCloudAccountCustomerAppCredentials()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "SetAzureCloudAccountCustomerAppCredentialsInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationSetAzureCloudAccountCustomerAppCredentials",
                "($input: SetAzureCloudAccountCustomerAppCredentialsInput!)",
                "System.Boolean",
                Mutation.SetAzureCloudAccountCustomerAppCredentials_ObjectFieldSpec,
                Mutation.SetAzureCloudAccountCustomerAppCredentialsFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	appId = <System.String>
	# REQUIRED
	appSecretKey = <System.String>
	# OPTIONAL
	appTenantId = <System.String>
	# OPTIONAL
	appName = <System.String>
	# OPTIONAL
	tenantDomainName = <System.String>
	# REQUIRED
	shouldReplace = <System.Boolean>
	# REQUIRED
	azureCloudType = <AzureCloudType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureCloudType]) for enum values.
}"
            );
        }

        // Create new GraphQL Mutation:
        // addAzureCloudAccount(input: AddAzureCloudAccountInput!): AddAzureCloudAccountReply!
        internal void InitMutationAddAzureCloudAccount()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "AddAzureCloudAccountInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationAddAzureCloudAccount",
                "($input: AddAzureCloudAccountInput!)",
                "AddAzureCloudAccountReply",
                Mutation.AddAzureCloudAccount_ObjectFieldSpec,
                Mutation.AddAzureCloudAccountFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	sessionId = <System.String>
	# REQUIRED
	tenantDomainName = <System.String>
	# REQUIRED
	subscriptions = @(
		@{
			# REQUIRED
			features = @(
				@{
					# OPTIONAL
					resourceGroup = @{
						# REQUIRED
						name = <System.String>
						# OPTIONAL
						tags = @{
							# REQUIRED
							tagList = @(
								@{
									# REQUIRED
									key = <System.String>
									# REQUIRED
									value = <System.String>
								}
							)
						}
						# REQUIRED
						region = <AzureCloudAccountRegion> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureCloudAccountRegion]) for enum values.
					}
					# REQUIRED
					featureType = <CloudAccountFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
					# OPTIONAL
					permissionsGroups = @(
						<PermissionsGroup> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.PermissionsGroup]) for enum values.
					)
				}
			)
			# REQUIRED
			subscription = @{
				# REQUIRED
				nativeId = <System.String>
				# REQUIRED
				name = <System.String>
			}
		}
	)
	# REQUIRED
	regions = @(
		<AzureCloudAccountRegion> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureCloudAccountRegion]) for enum values.
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // addAzureCloudAccountWithoutOauth(input: AddAzureCloudAccountWithoutOauthInput!): AddAzureCloudAccountWithoutOauthReply!
        internal void InitMutationAddAzureCloudAccountWithoutOauth()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "AddAzureCloudAccountWithoutOauthInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationAddAzureCloudAccountWithoutOauth",
                "($input: AddAzureCloudAccountWithoutOauthInput!)",
                "AddAzureCloudAccountWithoutOauthReply",
                Mutation.AddAzureCloudAccountWithoutOauth_ObjectFieldSpec,
                Mutation.AddAzureCloudAccountWithoutOauthFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	tenantDomainName = <System.String>
	# REQUIRED
	subscriptions = @(
		@{
			# REQUIRED
			features = @(
				@{
					# REQUIRED
					policyVersion = <System.Int32>
					# OPTIONAL
					resourceGroup = @{
						# REQUIRED
						name = <System.String>
						# OPTIONAL
						tags = @{
							# REQUIRED
							tagList = @(
								@{
									# REQUIRED
									key = <System.String>
									# REQUIRED
									value = <System.String>
								}
							)
						}
						# REQUIRED
						region = <AzureCloudAccountRegion> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureCloudAccountRegion]) for enum values.
					}
					# OPTIONAL
					specificFeatureInput = @{
						# REQUIRED
						userAssignedManagedIdentityInput = @{
							# REQUIRED
							name = <System.String>
							# REQUIRED
							resourceGroupName = <System.String>
							# REQUIRED
							principalId = <System.String>
							# REQUIRED
							region = <AzureCloudAccountRegion> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureCloudAccountRegion]) for enum values.
						}
					}
					# REQUIRED
					featureType = <CloudAccountFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
					# OPTIONAL
					permissionsGroups = @(
						<PermissionsGroup> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.PermissionsGroup]) for enum values.
					)
				}
			)
			# REQUIRED
			subscription = @{
				# REQUIRED
				nativeId = <System.String>
				# REQUIRED
				name = <System.String>
			}
		}
	)
	# REQUIRED
	regions = @(
		<AzureCloudAccountRegion> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureCloudAccountRegion]) for enum values.
	)
	# OPTIONAL
	azureCloudType = <AzureCloudType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureCloudType]) for enum values.
}"
            );
        }

        // Create new GraphQL Mutation:
        // deleteAzureCloudAccount(input: DeleteAzureCloudAccountInput!): DeleteAzureCloudAccountReply!
        internal void InitMutationDeleteAzureCloudAccount()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteAzureCloudAccountInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDeleteAzureCloudAccount",
                "($input: DeleteAzureCloudAccountInput!)",
                "DeleteAzureCloudAccountReply",
                Mutation.DeleteAzureCloudAccount_ObjectFieldSpec,
                Mutation.DeleteAzureCloudAccountFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	sessionId = <System.String>
	# REQUIRED
	features = @(
		<CloudAccountFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
	)
	# REQUIRED
	azureSubscriptionRubrikIds = @(
		<System.String>
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // deleteAzureCloudAccountWithoutOauth(input: DeleteAzureCloudAccountWithoutOauthInput!): DeleteAzureCloudAccountWithoutOauthReply!
        internal void InitMutationDeleteAzureCloudAccountWithoutOauth()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteAzureCloudAccountWithoutOauthInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDeleteAzureCloudAccountWithoutOauth",
                "($input: DeleteAzureCloudAccountWithoutOauthInput!)",
                "DeleteAzureCloudAccountWithoutOauthReply",
                Mutation.DeleteAzureCloudAccountWithoutOauth_ObjectFieldSpec,
                Mutation.DeleteAzureCloudAccountWithoutOauthFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	features = @(
		<CloudAccountFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
	)
	# REQUIRED
	azureSubscriptionRubrikIds = @(
		<System.String>
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // upgradeAzureCloudAccount(input: UpgradeAzureCloudAccountInput!): UpgradeAzureCloudAccountReply!
        internal void InitMutationUpgradeAzureCloudAccount()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpgradeAzureCloudAccountInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpgradeAzureCloudAccount",
                "($input: UpgradeAzureCloudAccountInput!)",
                "UpgradeAzureCloudAccountReply",
                Mutation.UpgradeAzureCloudAccount_ObjectFieldSpec,
                Mutation.UpgradeAzureCloudAccountFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	sessionId = <System.String>
	# REQUIRED
	features = @(
		<CloudAccountFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
	)
	# OPTIONAL
	featuresToUpgrade = @(
		@{
			# REQUIRED
			featureType = <CloudAccountFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
			# REQUIRED
			permissionsGroups = @(
				<PermissionsGroup> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.PermissionsGroup]) for enum values.
			)
		}
	)
	# REQUIRED
	azureSubscriptionRubrikIds = @(
		<System.String>
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // updateCustomerAppPermissionForAzureSql: Void
        internal void InitMutationUpdateCustomerAppPermissionForAzureSql()
        {
            Tuple<string, string>[] argDefs = {
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateCustomerAppPermissionForAzureSql",
                "",
                "System.String",
                Mutation.UpdateCustomerAppPermissionForAzureSql_ObjectFieldSpec,
                Mutation.UpdateCustomerAppPermissionForAzureSqlFieldSpec,
                @""
            );
        }

        // Create new GraphQL Mutation:
        // startDisableAzureCloudAccountJob(input: StartDisableAzureCloudAccountJobInput!): BatchAsyncJobStatus!
        internal void InitMutationStartDisableAzureCloudAccountJob()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "StartDisableAzureCloudAccountJobInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationStartDisableAzureCloudAccountJob",
                "($input: StartDisableAzureCloudAccountJobInput!)",
                "BatchAsyncJobStatus",
                Mutation.StartDisableAzureCloudAccountJob_ObjectFieldSpec,
                Mutation.StartDisableAzureCloudAccountJobFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	feature = <CloudAccountFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
	# REQUIRED
	cloudAccountIds = @(
		<System.String>
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // updateAzureCloudAccount(input: UpdateAzureCloudAccountInput!): UpdateAzureCloudAccountReply!
        internal void InitMutationUpdateAzureCloudAccount()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateAzureCloudAccountInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateAzureCloudAccount",
                "($input: UpdateAzureCloudAccountInput!)",
                "UpdateAzureCloudAccountReply",
                Mutation.UpdateAzureCloudAccount_ObjectFieldSpec,
                Mutation.UpdateAzureCloudAccountFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	subscriptions = @(
		@{
			# OPTIONAL
			id = <System.String>
			# OPTIONAL
			name = <System.String>
		}
	)
	# REQUIRED
	features = @(
		<CloudAccountFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
	)
	# OPTIONAL
	regionsToAdd = @(
		<AzureCloudAccountRegion> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureCloudAccountRegion]) for enum values.
	)
	# OPTIONAL
	regionsToRemove = @(
		<AzureCloudAccountRegion> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureCloudAccountRegion]) for enum values.
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // mapAzureCloudAccountToPersistentStorageLocation(input: MapAzureCloudAccountToPersistentStorageLocationInput!): MapAzureCloudAccountToPersistentStorageLocationReply!
        internal void InitMutationMapAzureCloudAccountToPersistentStorageLocation()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "MapAzureCloudAccountToPersistentStorageLocationInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationMapAzureCloudAccountToPersistentStorageLocation",
                "($input: MapAzureCloudAccountToPersistentStorageLocationInput!)",
                "MapAzureCloudAccountToPersistentStorageLocationReply",
                Mutation.MapAzureCloudAccountToPersistentStorageLocation_ObjectFieldSpec,
                Mutation.MapAzureCloudAccountToPersistentStorageLocationFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	cloudAccountIds = @(
		<System.String>
	)
	# REQUIRED
	persistentStorageId = <System.String>
	# REQUIRED
	azureNativeProtectionFeature = <AzureNativeProtectionFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeProtectionFeature]) for enum values.
}"
            );
        }

        // Create new GraphQL Mutation:
        // addAzureCloudAccountExocomputeConfigurations(input: AddAzureCloudAccountExocomputeConfigurationsInput!): AddAzureCloudAccountExocomputeConfigurationsReply!
        internal void InitMutationAddAzureCloudAccountExocomputeConfigurations()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "AddAzureCloudAccountExocomputeConfigurationsInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationAddAzureCloudAccountExocomputeConfigurations",
                "($input: AddAzureCloudAccountExocomputeConfigurationsInput!)",
                "AddAzureCloudAccountExocomputeConfigurationsReply",
                Mutation.AddAzureCloudAccountExocomputeConfigurations_ObjectFieldSpec,
                Mutation.AddAzureCloudAccountExocomputeConfigurationsFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	cloudAccountId = <System.String>
	# REQUIRED
	azureExocomputeRegionConfigs = @(
		@{
			# REQUIRED
			region = <AzureCloudAccountRegion> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureCloudAccountRegion]) for enum values.
			# REQUIRED
			subnetNativeId = <System.String>
			# REQUIRED
			isRscManaged = <System.Boolean>
			# OPTIONAL
			podSubnetNativeId = <System.String>
		}
	)
	# OPTIONAL
	triggerHealthCheck = <System.Boolean>
}"
            );
        }

        // Create new GraphQL Mutation:
        // deleteAzureCloudAccountExocomputeConfigurations(input: DeleteAzureCloudAccountExocomputeConfigurationsInput!): DeleteAzureCloudAccountExocomputeConfigurationsReply!
        internal void InitMutationDeleteAzureCloudAccountExocomputeConfigurations()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteAzureCloudAccountExocomputeConfigurationsInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDeleteAzureCloudAccountExocomputeConfigurations",
                "($input: DeleteAzureCloudAccountExocomputeConfigurationsInput!)",
                "DeleteAzureCloudAccountExocomputeConfigurationsReply",
                Mutation.DeleteAzureCloudAccountExocomputeConfigurations_ObjectFieldSpec,
                Mutation.DeleteAzureCloudAccountExocomputeConfigurationsFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	cloudAccountIds = @(
		<System.String>
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // mapAzureCloudAccountExocomputeSubscription(input: MapAzureCloudAccountExocomputeSubscriptionInput!): MapAzureCloudAccountExocomputeSubscriptionReply!
        internal void InitMutationMapAzureCloudAccountExocomputeSubscription()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "MapAzureCloudAccountExocomputeSubscriptionInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationMapAzureCloudAccountExocomputeSubscription",
                "($input: MapAzureCloudAccountExocomputeSubscriptionInput!)",
                "MapAzureCloudAccountExocomputeSubscriptionReply",
                Mutation.MapAzureCloudAccountExocomputeSubscription_ObjectFieldSpec,
                Mutation.MapAzureCloudAccountExocomputeSubscriptionFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	cloudAccountIds = @(
		<System.String>
	)
	# REQUIRED
	exocomputeCloudAccountId = <System.String>
}"
            );
        }

        // Create new GraphQL Mutation:
        // unmapAzureCloudAccountExocomputeSubscription(input: UnmapAzureCloudAccountExocomputeSubscriptionInput!): UnmapAzureCloudAccountExocomputeSubscriptionReply!
        internal void InitMutationUnmapAzureCloudAccountExocomputeSubscription()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UnmapAzureCloudAccountExocomputeSubscriptionInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUnmapAzureCloudAccountExocomputeSubscription",
                "($input: UnmapAzureCloudAccountExocomputeSubscriptionInput!)",
                "UnmapAzureCloudAccountExocomputeSubscriptionReply",
                Mutation.UnmapAzureCloudAccountExocomputeSubscription_ObjectFieldSpec,
                Mutation.UnmapAzureCloudAccountExocomputeSubscriptionFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	cloudAccountIds = @(
		<System.String>
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // upgradeAzureCloudAccountPermissionsWithoutOauth(input: UpgradeAzureCloudAccountPermissionsWithoutOauthInput!): UpgradeAzureCloudAccountPermissionsWithoutOauthReply!
        internal void InitMutationUpgradeAzureCloudAccountPermissionsWithoutOauth()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpgradeAzureCloudAccountPermissionsWithoutOauthInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpgradeAzureCloudAccountPermissionsWithoutOauth",
                "($input: UpgradeAzureCloudAccountPermissionsWithoutOauthInput!)",
                "UpgradeAzureCloudAccountPermissionsWithoutOauthReply",
                Mutation.UpgradeAzureCloudAccountPermissionsWithoutOauth_ObjectFieldSpec,
                Mutation.UpgradeAzureCloudAccountPermissionsWithoutOauthFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	cloudAccountId = <System.String>
	# REQUIRED
	feature = <CloudAccountFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
	# OPTIONAL
	featureToUpgrade = @{
		# REQUIRED
		featureType = <CloudAccountFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
		# REQUIRED
		permissionsGroups = @(
			<PermissionsGroup> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.PermissionsGroup]) for enum values.
		)
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // unmapAzurePersistentStorageSubscription(input: UnmapAzurePersistentStorageSubscriptionInput!): Void
        internal void InitMutationUnmapAzurePersistentStorageSubscription()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UnmapAzurePersistentStorageSubscriptionInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUnmapAzurePersistentStorageSubscription",
                "($input: UnmapAzurePersistentStorageSubscriptionInput!)",
                "System.String",
                Mutation.UnmapAzurePersistentStorageSubscription_ObjectFieldSpec,
                Mutation.UnmapAzurePersistentStorageSubscriptionFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	applicationCloudAccountIds = @(
		<System.String>
	)
	# REQUIRED
	feature = <CloudAccountFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
	# REQUIRED
	unmappingValidationType = <UnmappingValidationType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UnmappingValidationType]) for enum values.
}"
            );
        }

        // Create new GraphQL Mutation:
        // azureOauthConsentKickoff: AzureOauthConsentKickoffReply!
        internal void InitMutationAzureOauthConsentKickoff()
        {
            Tuple<string, string>[] argDefs = {
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationAzureOauthConsentKickoff",
                "",
                "AzureOauthConsentKickoffReply",
                Mutation.AzureOauthConsentKickoff_ObjectFieldSpec,
                Mutation.AzureOauthConsentKickoffFieldSpec,
                @""
            );
        }

        // Create new GraphQL Mutation:
        // azureOauthConsentComplete(input: AzureOauthConsentCompleteInput!): RequestStatus!
        internal void InitMutationAzureOauthConsentComplete()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "AzureOauthConsentCompleteInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationAzureOauthConsentComplete",
                "($input: AzureOauthConsentCompleteInput!)",
                "RequestStatus",
                Mutation.AzureOauthConsentComplete_ObjectFieldSpec,
                Mutation.AzureOauthConsentCompleteFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	tenantId = <System.String>
	# REQUIRED
	code = <System.String>
	# REQUIRED
	stateToken = <System.String>
	# REQUIRED
	redirectUrl = <System.String>
	# OPTIONAL
	azureAppId = <System.String>
	# OPTIONAL
	azureAppSecret = <System.String>
	# REQUIRED
	azureCloudType = <O365AzureCloudType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.O365AzureCloudType]) for enum values.
}"
            );
        }

        // Create new GraphQL Mutation:
        // createAzureSaasAppAad: CreateAzureSaasAppAadReply!
        internal void InitMutationCreateAzureSaasAppAad()
        {
            Tuple<string, string>[] argDefs = {
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateAzureSaasAppAad",
                "",
                "CreateAzureSaasAppAadReply",
                Mutation.CreateAzureSaasAppAad_ObjectFieldSpec,
                Mutation.CreateAzureSaasAppAadFieldSpec,
                @""
            );
        }

        // Create new GraphQL Mutation:
        // createAzureCluster(input: CreateAzureClusterInput!): CcProvisionJobReply!
        internal void InitMutationCreateAzureCluster()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateAzureClusterInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateAzureCluster",
                "($input: CreateAzureClusterInput!)",
                "CcProvisionJobReply",
                Mutation.CreateAzureCluster_ObjectFieldSpec,
                Mutation.CreateAzureClusterFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# OPTIONAL
	cloudAccountId = <System.String>
	# OPTIONAL
	isEsType = <System.Boolean>
	# OPTIONAL
	keepClusterOnFailure = <System.Boolean>
	# OPTIONAL
	clusterConfig = @{
		# OPTIONAL
		userEmail = <System.String>
		# OPTIONAL
		adminPassword = <System.String>
		# OPTIONAL
		clusterName = <System.String>
		# OPTIONAL
		numNodes = <System.Int32>
		# OPTIONAL
		dnsSearchDomains = @(
			<System.String>
		)
		# OPTIONAL
		dnsNameServers = @(
			<System.String>
		)
		# OPTIONAL
		ntpServers = @(
			<System.String>
		)
		# OPTIONAL
		azureEsConfig = @{
			# OPTIONAL
			storageAccount = <System.String>
			# OPTIONAL
			resourceGroup = <System.String>
			# OPTIONAL
			storageSecret = <System.String>
			# OPTIONAL
			containerName = <System.String>
			# OPTIONAL
			shouldCreateContainer = <System.Boolean>
			# OPTIONAL
			enableImmutability = <System.Boolean>
		}
		# OPTIONAL
		awsEsConfig = @{
			# OPTIONAL
			bucketName = <System.String>
			# OPTIONAL
			shouldCreateBucket = <System.Boolean>
			# OPTIONAL
			enableObjectLock = <System.Boolean>
			# OPTIONAL
			enableImmutability = <System.Boolean>
		}
	}
	# OPTIONAL
	vmConfig = @{
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
}"
            );
        }

        // Create new GraphQL Mutation:
        // deleteAzureCluster(input: DeleteAzureClusterInput!): CcProvisionJobReply!
        internal void InitMutationDeleteAzureCluster()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteAzureClusterInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDeleteAzureCluster",
                "($input: DeleteAzureClusterInput!)",
                "CcProvisionJobReply",
                Mutation.DeleteAzureCluster_ObjectFieldSpec,
                Mutation.DeleteAzureClusterFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# OPTIONAL
	cloudAccountId = <System.String>
	# OPTIONAL
	clusterName = <System.String>
	# OPTIONAL
	numNodes = <System.Int32>
	# OPTIONAL
	resourceGroupName = <System.String>
	# OPTIONAL
	networkResourceGroup = <System.String>
	# OPTIONAL
	isEsType = <System.Boolean>
	# OPTIONAL
	storageAccount = <System.String>
	# OPTIONAL
	containerName = <System.String>
	# OPTIONAL
	storageResourceGroup = <System.String>
	# OPTIONAL
	isNewContainer = <System.Boolean>
	# OPTIONAL
	clusterUuid = <System.String>
}"
            );
        }


    } // class New_RscMutationAzure
}