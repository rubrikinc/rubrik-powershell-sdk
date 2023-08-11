// Invoke-RscMutateAzure.cs
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
        "RscMutateAzure",
        DefaultParameterSetName = "CreateTarget")
    ]
    public class Invoke_RscMutateAzure : RscPSCmdlet
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

        
        /// <summary>
        /// KickoffAdAppSetup parameter set
        ///
        /// [GraphQL: kickoffAzureAdAppSetup]
        /// </summary>
        [Parameter(
            ParameterSetName = "KickoffAdAppSetup",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Initiates the Azure AD app creation flow.
[GraphQL: kickoffAzureAdAppSetup]",
            Position = 0
        )]
        public SwitchParameter KickoffAdAppSetup { get; set; }

        
        /// <summary>
        /// CompleteAdAppSetup parameter set
        ///
        /// [GraphQL: completeAzureAdAppSetup]
        /// </summary>
        [Parameter(
            ParameterSetName = "CompleteAdAppSetup",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Completes the creation flow for an Azure AD app.
[GraphQL: completeAzureAdAppSetup]",
            Position = 0
        )]
        public SwitchParameter CompleteAdAppSetup { get; set; }

        
        /// <summary>
        /// DeleteAdDirectory parameter set
        ///
        /// [GraphQL: deleteAzureAdDirectory]
        /// </summary>
        [Parameter(
            ParameterSetName = "DeleteAdDirectory",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Deletes an Azure AD directory.
[GraphQL: deleteAzureAdDirectory]",
            Position = 0
        )]
        public SwitchParameter DeleteAdDirectory { get; set; }

        
        /// <summary>
        /// BackupAdDirectory parameter set
        ///
        /// [GraphQL: backupAzureAdDirectory]
        /// </summary>
        [Parameter(
            ParameterSetName = "BackupAdDirectory",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Backs up the Azure AD directory.
[GraphQL: backupAzureAdDirectory]",
            Position = 0
        )]
        public SwitchParameter BackupAdDirectory { get; set; }

        
        /// <summary>
        /// InitiateAdAppUpdate parameter set
        ///
        /// [GraphQL: initiateAzureAdAppUpdate]
        /// </summary>
        [Parameter(
            ParameterSetName = "InitiateAdAppUpdate",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Initiates an update to the Azure AD directory App.
[GraphQL: initiateAzureAdAppUpdate]",
            Position = 0
        )]
        public SwitchParameter InitiateAdAppUpdate { get; set; }

        
        /// <summary>
        /// CompleteAdAppUpdate parameter set
        ///
        /// [GraphQL: completeAzureAdAppUpdate]
        /// </summary>
        [Parameter(
            ParameterSetName = "CompleteAdAppUpdate",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Completes an update to the Azure AD directory App.
[GraphQL: completeAzureAdAppUpdate]",
            Position = 0
        )]
        public SwitchParameter CompleteAdAppUpdate { get; set; }

        
        /// <summary>
        /// RestoreAdObjectsWithPassword parameter set
        ///
        /// [GraphQL: restoreAzureAdObjectsWithPassword]
        /// </summary>
        [Parameter(
            ParameterSetName = "RestoreAdObjectsWithPassword",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Restores the Azure AD directory.
[GraphQL: restoreAzureAdObjectsWithPassword]",
            Position = 0
        )]
        public SwitchParameter RestoreAdObjectsWithPassword { get; set; }


// ignore warning 'Missing XML comment'
#pragma warning disable 1591
        protected override void ProcessRecord()
        {
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
                    case "KickoffAdAppSetup":
                        this.ProcessRecord_KickoffAdAppSetup();
                        break;
                    case "CompleteAdAppSetup":
                        this.ProcessRecord_CompleteAdAppSetup();
                        break;
                    case "DeleteAdDirectory":
                        this.ProcessRecord_DeleteAdDirectory();
                        break;
                    case "BackupAdDirectory":
                        this.ProcessRecord_BackupAdDirectory();
                        break;
                    case "InitiateAdAppUpdate":
                        this.ProcessRecord_InitiateAdAppUpdate();
                        break;
                    case "CompleteAdAppUpdate":
                        this.ProcessRecord_CompleteAdAppUpdate();
                        break;
                    case "RestoreAdObjectsWithPassword":
                        this.ProcessRecord_RestoreAdObjectsWithPassword();
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
            // Invoke graphql operation startRefreshAzureNativeSubscriptionsJob
            InvokeMutationStartRefreshAzureNativeSubscriptionsJob();
        }

        // This parameter set invokes a single graphql operation:
        // startRestoreAzureNativeVirtualMachineJob.
        internal void ProcessRecord_StartRestoreNativeVirtualMachineJob()
        {
            this._logger.name += " -StartRestoreNativeVirtualMachineJob";
            // Invoke graphql operation startRestoreAzureNativeVirtualMachineJob
            InvokeMutationStartRestoreAzureNativeVirtualMachineJob();
        }

        // This parameter set invokes a single graphql operation:
        // startExportAzureNativeVirtualMachineJob.
        internal void ProcessRecord_StartExportNativeVirtualMachineJob()
        {
            this._logger.name += " -StartExportNativeVirtualMachineJob";
            // Invoke graphql operation startExportAzureNativeVirtualMachineJob
            InvokeMutationStartExportAzureNativeVirtualMachineJob();
        }

        // This parameter set invokes a single graphql operation:
        // excludeAzureNativeManagedDisksFromSnapshot.
        internal void ProcessRecord_ExcludeNativeManagedDisksFromSnapshot()
        {
            this._logger.name += " -ExcludeNativeManagedDisksFromSnapshot";
            // Invoke graphql operation excludeAzureNativeManagedDisksFromSnapshot
            InvokeMutationExcludeAzureNativeManagedDisksFromSnapshot();
        }

        // This parameter set invokes a single graphql operation:
        // startCreateAzureNativeVirtualMachineSnapshotsJob.
        internal void ProcessRecord_StartCreateNativeVirtualMachineSnapshotsJob()
        {
            this._logger.name += " -StartCreateNativeVirtualMachineSnapshotsJob";
            // Invoke graphql operation startCreateAzureNativeVirtualMachineSnapshotsJob
            InvokeMutationStartCreateAzureNativeVirtualMachineSnapshotsJob();
        }

        // This parameter set invokes a single graphql operation:
        // startDisableAzureNativeSubscriptionProtectionJob.
        internal void ProcessRecord_StartDisableNativeSubscriptionProtectionJob()
        {
            this._logger.name += " -StartDisableNativeSubscriptionProtectionJob";
            // Invoke graphql operation startDisableAzureNativeSubscriptionProtectionJob
            InvokeMutationStartDisableAzureNativeSubscriptionProtectionJob();
        }

        // This parameter set invokes a single graphql operation:
        // startCreateAzureNativeManagedDiskSnapshotsJob.
        internal void ProcessRecord_StartCreateNativeManagedDiskSnapshotsJob()
        {
            this._logger.name += " -StartCreateNativeManagedDiskSnapshotsJob";
            // Invoke graphql operation startCreateAzureNativeManagedDiskSnapshotsJob
            InvokeMutationStartCreateAzureNativeManagedDiskSnapshotsJob();
        }

        // This parameter set invokes a single graphql operation:
        // startExportAzureNativeManagedDiskJob.
        internal void ProcessRecord_StartExportNativeManagedDiskJob()
        {
            this._logger.name += " -StartExportNativeManagedDiskJob";
            // Invoke graphql operation startExportAzureNativeManagedDiskJob
            InvokeMutationStartExportAzureNativeManagedDiskJob();
        }

        // This parameter set invokes a single graphql operation:
        // startExportAzureSqlDatabaseDbJob.
        internal void ProcessRecord_StartExportSqlDatabaseDbJob()
        {
            this._logger.name += " -StartExportSqlDatabaseDbJob";
            // Invoke graphql operation startExportAzureSqlDatabaseDbJob
            InvokeMutationStartExportAzureSqlDatabaseDbJob();
        }

        // This parameter set invokes a single graphql operation:
        // startExportAzureSqlManagedInstanceDbJob.
        internal void ProcessRecord_StartExportSqlManagedInstanceDbJob()
        {
            this._logger.name += " -StartExportSqlManagedInstanceDbJob";
            // Invoke graphql operation startExportAzureSqlManagedInstanceDbJob
            InvokeMutationStartExportAzureSqlManagedInstanceDbJob();
        }

        // This parameter set invokes a single graphql operation:
        // createAzureAccount.
        internal void ProcessRecord_CreateAccount()
        {
            this._logger.name += " -CreateAccount";
            // Invoke graphql operation createAzureAccount
            InvokeMutationCreateAzureAccount();
        }

        // This parameter set invokes a single graphql operation:
        // updateAzureAccount.
        internal void ProcessRecord_UpdateAccount()
        {
            this._logger.name += " -UpdateAccount";
            // Invoke graphql operation updateAzureAccount
            InvokeMutationUpdateAzureAccount();
        }

        // This parameter set invokes a single graphql operation:
        // createAutomaticAzureTargetMapping.
        internal void ProcessRecord_CreateAutomaticTargetMapping()
        {
            this._logger.name += " -CreateAutomaticTargetMapping";
            // Invoke graphql operation createAutomaticAzureTargetMapping
            InvokeMutationCreateAutomaticAzureTargetMapping();
        }

        // This parameter set invokes a single graphql operation:
        // createCloudNativeAzureStorageSetting.
        internal void ProcessRecord_CreateCloudNativeStorageSetting()
        {
            this._logger.name += " -CreateCloudNativeStorageSetting";
            // Invoke graphql operation createCloudNativeAzureStorageSetting
            InvokeMutationCreateCloudNativeAzureStorageSetting();
        }

        // This parameter set invokes a single graphql operation:
        // createCloudNativeRcvAzureStorageSetting.
        internal void ProcessRecord_CreateCloudNativeRcvStorageSetting()
        {
            this._logger.name += " -CreateCloudNativeRcvStorageSetting";
            // Invoke graphql operation createCloudNativeRcvAzureStorageSetting
            InvokeMutationCreateCloudNativeRcvAzureStorageSetting();
        }

        // This parameter set invokes a single graphql operation:
        // updateAutomaticAzureTargetMapping.
        internal void ProcessRecord_UpdateAutomaticTargetMapping()
        {
            this._logger.name += " -UpdateAutomaticTargetMapping";
            // Invoke graphql operation updateAutomaticAzureTargetMapping
            InvokeMutationUpdateAutomaticAzureTargetMapping();
        }

        // This parameter set invokes a single graphql operation:
        // updateCloudNativeAzureStorageSetting.
        internal void ProcessRecord_UpdateCloudNativeStorageSetting()
        {
            this._logger.name += " -UpdateCloudNativeStorageSetting";
            // Invoke graphql operation updateCloudNativeAzureStorageSetting
            InvokeMutationUpdateCloudNativeAzureStorageSetting();
        }

        // This parameter set invokes a single graphql operation:
        // updateCloudNativeRcvAzureStorageSetting.
        internal void ProcessRecord_UpdateCloudNativeRcvStorageSetting()
        {
            this._logger.name += " -UpdateCloudNativeRcvStorageSetting";
            // Invoke graphql operation updateCloudNativeRcvAzureStorageSetting
            InvokeMutationUpdateCloudNativeRcvAzureStorageSetting();
        }

        // This parameter set invokes a single graphql operation:
        // createAzureTarget.
        internal void ProcessRecord_CreateTarget()
        {
            this._logger.name += " -CreateTarget";
            // Invoke graphql operation createAzureTarget
            InvokeMutationCreateAzureTarget();
        }

        // This parameter set invokes a single graphql operation:
        // updateAzureTarget.
        internal void ProcessRecord_UpdateTarget()
        {
            this._logger.name += " -UpdateTarget";
            // Invoke graphql operation updateAzureTarget
            InvokeMutationUpdateAzureTarget();
        }

        // This parameter set invokes a single graphql operation:
        // createAzureReaderTarget.
        internal void ProcessRecord_CreateReaderTarget()
        {
            this._logger.name += " -CreateReaderTarget";
            // Invoke graphql operation createAzureReaderTarget
            InvokeMutationCreateAzureReaderTarget();
        }

        // This parameter set invokes a single graphql operation:
        // startAzureCloudAccountOauth.
        internal void ProcessRecord_StartCloudAccountOauth()
        {
            this._logger.name += " -StartCloudAccountOauth";
            // Invoke graphql operation startAzureCloudAccountOauth
            InvokeMutationStartAzureCloudAccountOauth();
        }

        // This parameter set invokes a single graphql operation:
        // completeAzureCloudAccountOauth.
        internal void ProcessRecord_CompleteCloudAccountOauth()
        {
            this._logger.name += " -CompleteCloudAccountOauth";
            // Invoke graphql operation completeAzureCloudAccountOauth
            InvokeMutationCompleteAzureCloudAccountOauth();
        }

        // This parameter set invokes a single graphql operation:
        // setAzureCloudAccountCustomerAppCredentials.
        internal void ProcessRecord_SetCloudAccountCustomerAppCredentials()
        {
            this._logger.name += " -SetCloudAccountCustomerAppCredentials";
            // Invoke graphql operation setAzureCloudAccountCustomerAppCredentials
            InvokeMutationSetAzureCloudAccountCustomerAppCredentials();
        }

        // This parameter set invokes a single graphql operation:
        // addAzureCloudAccount.
        internal void ProcessRecord_AddCloudAccount()
        {
            this._logger.name += " -AddCloudAccount";
            // Invoke graphql operation addAzureCloudAccount
            InvokeMutationAddAzureCloudAccount();
        }

        // This parameter set invokes a single graphql operation:
        // addAzureCloudAccountWithoutOauth.
        internal void ProcessRecord_AddCloudAccountWithoutOauth()
        {
            this._logger.name += " -AddCloudAccountWithoutOauth";
            // Invoke graphql operation addAzureCloudAccountWithoutOauth
            InvokeMutationAddAzureCloudAccountWithoutOauth();
        }

        // This parameter set invokes a single graphql operation:
        // deleteAzureCloudAccount.
        internal void ProcessRecord_DeleteCloudAccount()
        {
            this._logger.name += " -DeleteCloudAccount";
            // Invoke graphql operation deleteAzureCloudAccount
            InvokeMutationDeleteAzureCloudAccount();
        }

        // This parameter set invokes a single graphql operation:
        // deleteAzureCloudAccountWithoutOauth.
        internal void ProcessRecord_DeleteCloudAccountWithoutOauth()
        {
            this._logger.name += " -DeleteCloudAccountWithoutOauth";
            // Invoke graphql operation deleteAzureCloudAccountWithoutOauth
            InvokeMutationDeleteAzureCloudAccountWithoutOauth();
        }

        // This parameter set invokes a single graphql operation:
        // upgradeAzureCloudAccount.
        internal void ProcessRecord_UpgradeCloudAccount()
        {
            this._logger.name += " -UpgradeCloudAccount";
            // Invoke graphql operation upgradeAzureCloudAccount
            InvokeMutationUpgradeAzureCloudAccount();
        }

        // This parameter set invokes a single graphql operation:
        // updateCustomerAppPermissionForAzureSql.
        internal void ProcessRecord_UpdateCustomerAppPermissionForSql()
        {
            this._logger.name += " -UpdateCustomerAppPermissionForSql";
            // Invoke graphql operation updateCustomerAppPermissionForAzureSql
            InvokeMutationUpdateCustomerAppPermissionForAzureSql();
        }

        // This parameter set invokes a single graphql operation:
        // startDisableAzureCloudAccountJob.
        internal void ProcessRecord_StartDisableCloudAccountJob()
        {
            this._logger.name += " -StartDisableCloudAccountJob";
            // Invoke graphql operation startDisableAzureCloudAccountJob
            InvokeMutationStartDisableAzureCloudAccountJob();
        }

        // This parameter set invokes a single graphql operation:
        // updateAzureCloudAccount.
        internal void ProcessRecord_UpdateCloudAccount()
        {
            this._logger.name += " -UpdateCloudAccount";
            // Invoke graphql operation updateAzureCloudAccount
            InvokeMutationUpdateAzureCloudAccount();
        }

        // This parameter set invokes a single graphql operation:
        // mapAzureCloudAccountToPersistentStorageLocation.
        internal void ProcessRecord_MapCloudAccountToPersistentStorageLocation()
        {
            this._logger.name += " -MapCloudAccountToPersistentStorageLocation";
            // Invoke graphql operation mapAzureCloudAccountToPersistentStorageLocation
            InvokeMutationMapAzureCloudAccountToPersistentStorageLocation();
        }

        // This parameter set invokes a single graphql operation:
        // addAzureCloudAccountExocomputeConfigurations.
        internal void ProcessRecord_AddCloudAccountExocomputeConfigurations()
        {
            this._logger.name += " -AddCloudAccountExocomputeConfigurations";
            // Invoke graphql operation addAzureCloudAccountExocomputeConfigurations
            InvokeMutationAddAzureCloudAccountExocomputeConfigurations();
        }

        // This parameter set invokes a single graphql operation:
        // deleteAzureCloudAccountExocomputeConfigurations.
        internal void ProcessRecord_DeleteCloudAccountExocomputeConfigurations()
        {
            this._logger.name += " -DeleteCloudAccountExocomputeConfigurations";
            // Invoke graphql operation deleteAzureCloudAccountExocomputeConfigurations
            InvokeMutationDeleteAzureCloudAccountExocomputeConfigurations();
        }

        // This parameter set invokes a single graphql operation:
        // mapAzureCloudAccountExocomputeSubscription.
        internal void ProcessRecord_MapCloudAccountExocomputeSubscription()
        {
            this._logger.name += " -MapCloudAccountExocomputeSubscription";
            // Invoke graphql operation mapAzureCloudAccountExocomputeSubscription
            InvokeMutationMapAzureCloudAccountExocomputeSubscription();
        }

        // This parameter set invokes a single graphql operation:
        // unmapAzureCloudAccountExocomputeSubscription.
        internal void ProcessRecord_UnmapCloudAccountExocomputeSubscription()
        {
            this._logger.name += " -UnmapCloudAccountExocomputeSubscription";
            // Invoke graphql operation unmapAzureCloudAccountExocomputeSubscription
            InvokeMutationUnmapAzureCloudAccountExocomputeSubscription();
        }

        // This parameter set invokes a single graphql operation:
        // upgradeAzureCloudAccountPermissionsWithoutOauth.
        internal void ProcessRecord_UpgradeCloudAccountPermissionsWithoutOauth()
        {
            this._logger.name += " -UpgradeCloudAccountPermissionsWithoutOauth";
            // Invoke graphql operation upgradeAzureCloudAccountPermissionsWithoutOauth
            InvokeMutationUpgradeAzureCloudAccountPermissionsWithoutOauth();
        }

        // This parameter set invokes a single graphql operation:
        // unmapAzurePersistentStorageSubscription.
        internal void ProcessRecord_UnmapPersistentStorageSubscription()
        {
            this._logger.name += " -UnmapPersistentStorageSubscription";
            // Invoke graphql operation unmapAzurePersistentStorageSubscription
            InvokeMutationUnmapAzurePersistentStorageSubscription();
        }

        // This parameter set invokes a single graphql operation:
        // azureOauthConsentKickoff.
        internal void ProcessRecord_OauthConsentKickoff()
        {
            this._logger.name += " -OauthConsentKickoff";
            // Invoke graphql operation azureOauthConsentKickoff
            InvokeMutationAzureOauthConsentKickoff();
        }

        // This parameter set invokes a single graphql operation:
        // azureOauthConsentComplete.
        internal void ProcessRecord_OauthConsentComplete()
        {
            this._logger.name += " -OauthConsentComplete";
            // Invoke graphql operation azureOauthConsentComplete
            InvokeMutationAzureOauthConsentComplete();
        }

        // This parameter set invokes a single graphql operation:
        // createAzureSaasAppAad.
        internal void ProcessRecord_CreateSaasAppAad()
        {
            this._logger.name += " -CreateSaasAppAad";
            // Invoke graphql operation createAzureSaasAppAad
            InvokeMutationCreateAzureSaasAppAad();
        }

        // This parameter set invokes a single graphql operation:
        // createAzureCluster.
        internal void ProcessRecord_CreateCluster()
        {
            this._logger.name += " -CreateCluster";
            // Invoke graphql operation createAzureCluster
            InvokeMutationCreateAzureCluster();
        }

        // This parameter set invokes a single graphql operation:
        // deleteAzureCluster.
        internal void ProcessRecord_DeleteCluster()
        {
            this._logger.name += " -DeleteCluster";
            // Invoke graphql operation deleteAzureCluster
            InvokeMutationDeleteAzureCluster();
        }

        // This parameter set invokes a single graphql operation:
        // kickoffAzureAdAppSetup.
        internal void ProcessRecord_KickoffAdAppSetup()
        {
            this._logger.name += " -KickoffAdAppSetup";
            // Invoke graphql operation kickoffAzureAdAppSetup
            InvokeMutationKickoffAzureAdAppSetup();
        }

        // This parameter set invokes a single graphql operation:
        // completeAzureAdAppSetup.
        internal void ProcessRecord_CompleteAdAppSetup()
        {
            this._logger.name += " -CompleteAdAppSetup";
            // Invoke graphql operation completeAzureAdAppSetup
            InvokeMutationCompleteAzureAdAppSetup();
        }

        // This parameter set invokes a single graphql operation:
        // deleteAzureAdDirectory.
        internal void ProcessRecord_DeleteAdDirectory()
        {
            this._logger.name += " -DeleteAdDirectory";
            // Invoke graphql operation deleteAzureAdDirectory
            InvokeMutationDeleteAzureAdDirectory();
        }

        // This parameter set invokes a single graphql operation:
        // backupAzureAdDirectory.
        internal void ProcessRecord_BackupAdDirectory()
        {
            this._logger.name += " -BackupAdDirectory";
            // Invoke graphql operation backupAzureAdDirectory
            InvokeMutationBackupAzureAdDirectory();
        }

        // This parameter set invokes a single graphql operation:
        // initiateAzureAdAppUpdate.
        internal void ProcessRecord_InitiateAdAppUpdate()
        {
            this._logger.name += " -InitiateAdAppUpdate";
            // Invoke graphql operation initiateAzureAdAppUpdate
            InvokeMutationInitiateAzureAdAppUpdate();
        }

        // This parameter set invokes a single graphql operation:
        // completeAzureAdAppUpdate.
        internal void ProcessRecord_CompleteAdAppUpdate()
        {
            this._logger.name += " -CompleteAdAppUpdate";
            // Invoke graphql operation completeAzureAdAppUpdate
            InvokeMutationCompleteAzureAdAppUpdate();
        }

        // This parameter set invokes a single graphql operation:
        // restoreAzureAdObjectsWithPassword.
        internal void ProcessRecord_RestoreAdObjectsWithPassword()
        {
            this._logger.name += " -RestoreAdObjectsWithPassword";
            // Invoke graphql operation restoreAzureAdObjectsWithPassword
            InvokeMutationRestoreAzureAdObjectsWithPassword();
        }


        // Invoke GraphQL Mutation:
        // startRefreshAzureNativeSubscriptionsJob(input: StartRefreshAzureNativeSubscriptionsJobInput!): BatchAsyncJobStatus!
        internal void InvokeMutationStartRefreshAzureNativeSubscriptionsJob()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "StartRefreshAzureNativeSubscriptionsJobInput!"),
            };
            BatchAsyncJobStatus? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (BatchAsyncJobStatus)psObject.BaseObject;
                } else {
                    fieldSpecObj = (BatchAsyncJobStatus)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.StartRefreshAzureNativeSubscriptionsJob(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationStartRefreshAzureNativeSubscriptionsJob",
                "($input: StartRefreshAzureNativeSubscriptionsJobInput!)",
                fieldSpecDoc,
                "BatchAsyncJobStatus"
            );
        }

        // Invoke GraphQL Mutation:
        // startRestoreAzureNativeVirtualMachineJob(input: StartRestoreAzureNativeVirtualMachineJobInput!): AsyncJobStatus!
        internal void InvokeMutationStartRestoreAzureNativeVirtualMachineJob()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "StartRestoreAzureNativeVirtualMachineJobInput!"),
            };
            AsyncJobStatus? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (AsyncJobStatus)psObject.BaseObject;
                } else {
                    fieldSpecObj = (AsyncJobStatus)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.StartRestoreAzureNativeVirtualMachineJob(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationStartRestoreAzureNativeVirtualMachineJob",
                "($input: StartRestoreAzureNativeVirtualMachineJobInput!)",
                fieldSpecDoc,
                "AsyncJobStatus"
            );
        }

        // Invoke GraphQL Mutation:
        // startExportAzureNativeVirtualMachineJob(input: StartExportAzureNativeVirtualMachineJobInput!): AsyncJobStatus!
        internal void InvokeMutationStartExportAzureNativeVirtualMachineJob()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "StartExportAzureNativeVirtualMachineJobInput!"),
            };
            AsyncJobStatus? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (AsyncJobStatus)psObject.BaseObject;
                } else {
                    fieldSpecObj = (AsyncJobStatus)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.StartExportAzureNativeVirtualMachineJob(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationStartExportAzureNativeVirtualMachineJob",
                "($input: StartExportAzureNativeVirtualMachineJobInput!)",
                fieldSpecDoc,
                "AsyncJobStatus"
            );
        }

        // Invoke GraphQL Mutation:
        // excludeAzureNativeManagedDisksFromSnapshot(input: ExcludeAzureNativeManagedDisksFromSnapshotInput!): Void
        internal void InvokeMutationExcludeAzureNativeManagedDisksFromSnapshot()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "ExcludeAzureNativeManagedDisksFromSnapshotInput!"),
            };
            System.String? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (System.String)psObject.BaseObject;
                } else {
                    fieldSpecObj = (System.String)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.ExcludeAzureNativeManagedDisksFromSnapshot(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationExcludeAzureNativeManagedDisksFromSnapshot",
                "($input: ExcludeAzureNativeManagedDisksFromSnapshotInput!)",
                fieldSpecDoc,
                "System.String"
            );
        }

        // Invoke GraphQL Mutation:
        // startCreateAzureNativeVirtualMachineSnapshotsJob(input: StartCreateAzureNativeVirtualMachineSnapshotsJobInput!): BatchAsyncJobStatus!
        internal void InvokeMutationStartCreateAzureNativeVirtualMachineSnapshotsJob()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "StartCreateAzureNativeVirtualMachineSnapshotsJobInput!"),
            };
            BatchAsyncJobStatus? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (BatchAsyncJobStatus)psObject.BaseObject;
                } else {
                    fieldSpecObj = (BatchAsyncJobStatus)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.StartCreateAzureNativeVirtualMachineSnapshotsJob(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationStartCreateAzureNativeVirtualMachineSnapshotsJob",
                "($input: StartCreateAzureNativeVirtualMachineSnapshotsJobInput!)",
                fieldSpecDoc,
                "BatchAsyncJobStatus"
            );
        }

        // Invoke GraphQL Mutation:
        // startDisableAzureNativeSubscriptionProtectionJob(input: StartDisableAzureNativeSubscriptionProtectionJobInput!): AsyncJobStatus!
        internal void InvokeMutationStartDisableAzureNativeSubscriptionProtectionJob()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "StartDisableAzureNativeSubscriptionProtectionJobInput!"),
            };
            AsyncJobStatus? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (AsyncJobStatus)psObject.BaseObject;
                } else {
                    fieldSpecObj = (AsyncJobStatus)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.StartDisableAzureNativeSubscriptionProtectionJob(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationStartDisableAzureNativeSubscriptionProtectionJob",
                "($input: StartDisableAzureNativeSubscriptionProtectionJobInput!)",
                fieldSpecDoc,
                "AsyncJobStatus"
            );
        }

        // Invoke GraphQL Mutation:
        // startCreateAzureNativeManagedDiskSnapshotsJob(input: StartCreateAzureNativeManagedDiskSnapshotsJobInput!): BatchAsyncJobStatus!
        internal void InvokeMutationStartCreateAzureNativeManagedDiskSnapshotsJob()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "StartCreateAzureNativeManagedDiskSnapshotsJobInput!"),
            };
            BatchAsyncJobStatus? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (BatchAsyncJobStatus)psObject.BaseObject;
                } else {
                    fieldSpecObj = (BatchAsyncJobStatus)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.StartCreateAzureNativeManagedDiskSnapshotsJob(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationStartCreateAzureNativeManagedDiskSnapshotsJob",
                "($input: StartCreateAzureNativeManagedDiskSnapshotsJobInput!)",
                fieldSpecDoc,
                "BatchAsyncJobStatus"
            );
        }

        // Invoke GraphQL Mutation:
        // startExportAzureNativeManagedDiskJob(input: StartExportAzureNativeManagedDiskJobInput!): AsyncJobStatus!
        internal void InvokeMutationStartExportAzureNativeManagedDiskJob()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "StartExportAzureNativeManagedDiskJobInput!"),
            };
            AsyncJobStatus? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (AsyncJobStatus)psObject.BaseObject;
                } else {
                    fieldSpecObj = (AsyncJobStatus)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.StartExportAzureNativeManagedDiskJob(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationStartExportAzureNativeManagedDiskJob",
                "($input: StartExportAzureNativeManagedDiskJobInput!)",
                fieldSpecDoc,
                "AsyncJobStatus"
            );
        }

        // Invoke GraphQL Mutation:
        // startExportAzureSqlDatabaseDbJob(input: StartExportAzureSqlDatabaseDbJobInput!): AsyncJobStatus!
        internal void InvokeMutationStartExportAzureSqlDatabaseDbJob()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "StartExportAzureSqlDatabaseDbJobInput!"),
            };
            AsyncJobStatus? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (AsyncJobStatus)psObject.BaseObject;
                } else {
                    fieldSpecObj = (AsyncJobStatus)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.StartExportAzureSqlDatabaseDbJob(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationStartExportAzureSqlDatabaseDbJob",
                "($input: StartExportAzureSqlDatabaseDbJobInput!)",
                fieldSpecDoc,
                "AsyncJobStatus"
            );
        }

        // Invoke GraphQL Mutation:
        // startExportAzureSqlManagedInstanceDbJob(input: StartExportAzureSqlManagedInstanceDbJobInput!): AsyncJobStatus!
        internal void InvokeMutationStartExportAzureSqlManagedInstanceDbJob()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "StartExportAzureSqlManagedInstanceDbJobInput!"),
            };
            AsyncJobStatus? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (AsyncJobStatus)psObject.BaseObject;
                } else {
                    fieldSpecObj = (AsyncJobStatus)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.StartExportAzureSqlManagedInstanceDbJob(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationStartExportAzureSqlManagedInstanceDbJob",
                "($input: StartExportAzureSqlManagedInstanceDbJobInput!)",
                fieldSpecDoc,
                "AsyncJobStatus"
            );
        }

        // Invoke GraphQL Mutation:
        // createAzureAccount(input: CreateAzureAccountInput!): CloudAccount!
        internal void InvokeMutationCreateAzureAccount()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateAzureAccountInput!"),
            };
            CloudAccount? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (CloudAccount)psObject.BaseObject;
                } else {
                    fieldSpecObj = (CloudAccount)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.CreateAzureAccount(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationCreateAzureAccount",
                "($input: CreateAzureAccountInput!)",
                fieldSpecDoc,
                "CloudAccount"
            );
        }

        // Invoke GraphQL Mutation:
        // updateAzureAccount(input: UpdateAzureAccountInput!): CloudAccount!
        internal void InvokeMutationUpdateAzureAccount()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateAzureAccountInput!"),
            };
            CloudAccount? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (CloudAccount)psObject.BaseObject;
                } else {
                    fieldSpecObj = (CloudAccount)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.UpdateAzureAccount(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationUpdateAzureAccount",
                "($input: UpdateAzureAccountInput!)",
                fieldSpecDoc,
                "CloudAccount"
            );
        }

        // Invoke GraphQL Mutation:
        // createAutomaticAzureTargetMapping(input: CreateAutomaticAzureTargetMappingInput!): TargetMapping!
        internal void InvokeMutationCreateAutomaticAzureTargetMapping()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateAutomaticAzureTargetMappingInput!"),
            };
            TargetMapping? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (TargetMapping)psObject.BaseObject;
                } else {
                    fieldSpecObj = (TargetMapping)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.CreateAutomaticAzureTargetMapping(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationCreateAutomaticAzureTargetMapping",
                "($input: CreateAutomaticAzureTargetMappingInput!)",
                fieldSpecDoc,
                "TargetMapping"
            );
        }

        // Invoke GraphQL Mutation:
        // createCloudNativeAzureStorageSetting(input: CreateCloudNativeAzureStorageSettingInput!): CreateCloudNativeAzureStorageSettingReply!
        internal void InvokeMutationCreateCloudNativeAzureStorageSetting()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateCloudNativeAzureStorageSettingInput!"),
            };
            CreateCloudNativeAzureStorageSettingReply? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (CreateCloudNativeAzureStorageSettingReply)psObject.BaseObject;
                } else {
                    fieldSpecObj = (CreateCloudNativeAzureStorageSettingReply)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.CreateCloudNativeAzureStorageSetting(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationCreateCloudNativeAzureStorageSetting",
                "($input: CreateCloudNativeAzureStorageSettingInput!)",
                fieldSpecDoc,
                "CreateCloudNativeAzureStorageSettingReply"
            );
        }

        // Invoke GraphQL Mutation:
        // createCloudNativeRcvAzureStorageSetting(input: CreateCloudNativeRcvAzureStorageSettingInput!): CreateCloudNativeRcvAzureStorageSettingReply!
        internal void InvokeMutationCreateCloudNativeRcvAzureStorageSetting()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateCloudNativeRcvAzureStorageSettingInput!"),
            };
            CreateCloudNativeRcvAzureStorageSettingReply? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (CreateCloudNativeRcvAzureStorageSettingReply)psObject.BaseObject;
                } else {
                    fieldSpecObj = (CreateCloudNativeRcvAzureStorageSettingReply)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.CreateCloudNativeRcvAzureStorageSetting(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationCreateCloudNativeRcvAzureStorageSetting",
                "($input: CreateCloudNativeRcvAzureStorageSettingInput!)",
                fieldSpecDoc,
                "CreateCloudNativeRcvAzureStorageSettingReply"
            );
        }

        // Invoke GraphQL Mutation:
        // updateAutomaticAzureTargetMapping(input: UpdateAutomaticAzureTargetMappingInput!): TargetMapping!
        internal void InvokeMutationUpdateAutomaticAzureTargetMapping()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateAutomaticAzureTargetMappingInput!"),
            };
            TargetMapping? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (TargetMapping)psObject.BaseObject;
                } else {
                    fieldSpecObj = (TargetMapping)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.UpdateAutomaticAzureTargetMapping(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationUpdateAutomaticAzureTargetMapping",
                "($input: UpdateAutomaticAzureTargetMappingInput!)",
                fieldSpecDoc,
                "TargetMapping"
            );
        }

        // Invoke GraphQL Mutation:
        // updateCloudNativeAzureStorageSetting(input: UpdateCloudNativeAzureStorageSettingInput!): UpdateCloudNativeAzureStorageSettingReply!
        internal void InvokeMutationUpdateCloudNativeAzureStorageSetting()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateCloudNativeAzureStorageSettingInput!"),
            };
            UpdateCloudNativeAzureStorageSettingReply? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (UpdateCloudNativeAzureStorageSettingReply)psObject.BaseObject;
                } else {
                    fieldSpecObj = (UpdateCloudNativeAzureStorageSettingReply)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.UpdateCloudNativeAzureStorageSetting(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationUpdateCloudNativeAzureStorageSetting",
                "($input: UpdateCloudNativeAzureStorageSettingInput!)",
                fieldSpecDoc,
                "UpdateCloudNativeAzureStorageSettingReply"
            );
        }

        // Invoke GraphQL Mutation:
        // updateCloudNativeRcvAzureStorageSetting(input: UpdateCloudNativeRcvAzureStorageSettingInput!): UpdateCloudNativeRcvAzureStorageSettingReply!
        internal void InvokeMutationUpdateCloudNativeRcvAzureStorageSetting()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateCloudNativeRcvAzureStorageSettingInput!"),
            };
            UpdateCloudNativeRcvAzureStorageSettingReply? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (UpdateCloudNativeRcvAzureStorageSettingReply)psObject.BaseObject;
                } else {
                    fieldSpecObj = (UpdateCloudNativeRcvAzureStorageSettingReply)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.UpdateCloudNativeRcvAzureStorageSetting(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationUpdateCloudNativeRcvAzureStorageSetting",
                "($input: UpdateCloudNativeRcvAzureStorageSettingInput!)",
                fieldSpecDoc,
                "UpdateCloudNativeRcvAzureStorageSettingReply"
            );
        }

        // Invoke GraphQL Mutation:
        // createAzureTarget(input: CreateAzureTargetInput!): Target!
        internal void InvokeMutationCreateAzureTarget()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateAzureTargetInput!"),
            };
            Target? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (Target)psObject.BaseObject;
                } else {
                    fieldSpecObj = (Target)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.CreateAzureTarget(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationCreateAzureTarget",
                "($input: CreateAzureTargetInput!)",
                fieldSpecDoc,
                "Target"
            );
        }

        // Invoke GraphQL Mutation:
        // updateAzureTarget(input: UpdateAzureTargetInput!): Target!
        internal void InvokeMutationUpdateAzureTarget()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateAzureTargetInput!"),
            };
            Target? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (Target)psObject.BaseObject;
                } else {
                    fieldSpecObj = (Target)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.UpdateAzureTarget(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationUpdateAzureTarget",
                "($input: UpdateAzureTargetInput!)",
                fieldSpecDoc,
                "Target"
            );
        }

        // Invoke GraphQL Mutation:
        // createAzureReaderTarget(input: CreateAzureReaderTargetInput!): Target!
        internal void InvokeMutationCreateAzureReaderTarget()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateAzureReaderTargetInput!"),
            };
            Target? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (Target)psObject.BaseObject;
                } else {
                    fieldSpecObj = (Target)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.CreateAzureReaderTarget(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationCreateAzureReaderTarget",
                "($input: CreateAzureReaderTargetInput!)",
                fieldSpecDoc,
                "Target"
            );
        }

        // Invoke GraphQL Mutation:
        // startAzureCloudAccountOauth(input: StartAzureCloudAccountOauthInput!): StartAzureCloudAccountOauthReply!
        internal void InvokeMutationStartAzureCloudAccountOauth()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "StartAzureCloudAccountOauthInput!"),
            };
            StartAzureCloudAccountOauthReply? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (StartAzureCloudAccountOauthReply)psObject.BaseObject;
                } else {
                    fieldSpecObj = (StartAzureCloudAccountOauthReply)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.StartAzureCloudAccountOauth(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationStartAzureCloudAccountOauth",
                "($input: StartAzureCloudAccountOauthInput!)",
                fieldSpecDoc,
                "StartAzureCloudAccountOauthReply"
            );
        }

        // Invoke GraphQL Mutation:
        // completeAzureCloudAccountOauth(input: CompleteAzureCloudAccountOauthInput!): CompleteAzureCloudAccountOauthReply!
        internal void InvokeMutationCompleteAzureCloudAccountOauth()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CompleteAzureCloudAccountOauthInput!"),
            };
            CompleteAzureCloudAccountOauthReply? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (CompleteAzureCloudAccountOauthReply)psObject.BaseObject;
                } else {
                    fieldSpecObj = (CompleteAzureCloudAccountOauthReply)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.CompleteAzureCloudAccountOauth(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationCompleteAzureCloudAccountOauth",
                "($input: CompleteAzureCloudAccountOauthInput!)",
                fieldSpecDoc,
                "CompleteAzureCloudAccountOauthReply"
            );
        }

        // Invoke GraphQL Mutation:
        // setAzureCloudAccountCustomerAppCredentials(input: SetAzureCloudAccountCustomerAppCredentialsInput!): Boolean!
        internal void InvokeMutationSetAzureCloudAccountCustomerAppCredentials()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "SetAzureCloudAccountCustomerAppCredentialsInput!"),
            };
            System.Boolean? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (System.Boolean)psObject.BaseObject;
                } else {
                    fieldSpecObj = (System.Boolean)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.SetAzureCloudAccountCustomerAppCredentials(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationSetAzureCloudAccountCustomerAppCredentials",
                "($input: SetAzureCloudAccountCustomerAppCredentialsInput!)",
                fieldSpecDoc,
                "System.Boolean"
            );
        }

        // Invoke GraphQL Mutation:
        // addAzureCloudAccount(input: AddAzureCloudAccountInput!): AddAzureCloudAccountReply!
        internal void InvokeMutationAddAzureCloudAccount()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "AddAzureCloudAccountInput!"),
            };
            AddAzureCloudAccountReply? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (AddAzureCloudAccountReply)psObject.BaseObject;
                } else {
                    fieldSpecObj = (AddAzureCloudAccountReply)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.AddAzureCloudAccount(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationAddAzureCloudAccount",
                "($input: AddAzureCloudAccountInput!)",
                fieldSpecDoc,
                "AddAzureCloudAccountReply"
            );
        }

        // Invoke GraphQL Mutation:
        // addAzureCloudAccountWithoutOauth(input: AddAzureCloudAccountWithoutOauthInput!): AddAzureCloudAccountWithoutOauthReply!
        internal void InvokeMutationAddAzureCloudAccountWithoutOauth()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "AddAzureCloudAccountWithoutOauthInput!"),
            };
            AddAzureCloudAccountWithoutOauthReply? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (AddAzureCloudAccountWithoutOauthReply)psObject.BaseObject;
                } else {
                    fieldSpecObj = (AddAzureCloudAccountWithoutOauthReply)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.AddAzureCloudAccountWithoutOauth(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationAddAzureCloudAccountWithoutOauth",
                "($input: AddAzureCloudAccountWithoutOauthInput!)",
                fieldSpecDoc,
                "AddAzureCloudAccountWithoutOauthReply"
            );
        }

        // Invoke GraphQL Mutation:
        // deleteAzureCloudAccount(input: DeleteAzureCloudAccountInput!): DeleteAzureCloudAccountReply!
        internal void InvokeMutationDeleteAzureCloudAccount()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteAzureCloudAccountInput!"),
            };
            DeleteAzureCloudAccountReply? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (DeleteAzureCloudAccountReply)psObject.BaseObject;
                } else {
                    fieldSpecObj = (DeleteAzureCloudAccountReply)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.DeleteAzureCloudAccount(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationDeleteAzureCloudAccount",
                "($input: DeleteAzureCloudAccountInput!)",
                fieldSpecDoc,
                "DeleteAzureCloudAccountReply"
            );
        }

        // Invoke GraphQL Mutation:
        // deleteAzureCloudAccountWithoutOauth(input: DeleteAzureCloudAccountWithoutOauthInput!): DeleteAzureCloudAccountWithoutOauthReply!
        internal void InvokeMutationDeleteAzureCloudAccountWithoutOauth()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteAzureCloudAccountWithoutOauthInput!"),
            };
            DeleteAzureCloudAccountWithoutOauthReply? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (DeleteAzureCloudAccountWithoutOauthReply)psObject.BaseObject;
                } else {
                    fieldSpecObj = (DeleteAzureCloudAccountWithoutOauthReply)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.DeleteAzureCloudAccountWithoutOauth(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationDeleteAzureCloudAccountWithoutOauth",
                "($input: DeleteAzureCloudAccountWithoutOauthInput!)",
                fieldSpecDoc,
                "DeleteAzureCloudAccountWithoutOauthReply"
            );
        }

        // Invoke GraphQL Mutation:
        // upgradeAzureCloudAccount(input: UpgradeAzureCloudAccountInput!): UpgradeAzureCloudAccountReply!
        internal void InvokeMutationUpgradeAzureCloudAccount()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpgradeAzureCloudAccountInput!"),
            };
            UpgradeAzureCloudAccountReply? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (UpgradeAzureCloudAccountReply)psObject.BaseObject;
                } else {
                    fieldSpecObj = (UpgradeAzureCloudAccountReply)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.UpgradeAzureCloudAccount(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationUpgradeAzureCloudAccount",
                "($input: UpgradeAzureCloudAccountInput!)",
                fieldSpecDoc,
                "UpgradeAzureCloudAccountReply"
            );
        }

        // Invoke GraphQL Mutation:
        // updateCustomerAppPermissionForAzureSql: Void
        internal void InvokeMutationUpdateCustomerAppPermissionForAzureSql()
        {
            Tuple<string, string>[] argDefs = {
            };
            System.String? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (System.String)psObject.BaseObject;
                } else {
                    fieldSpecObj = (System.String)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.UpdateCustomerAppPermissionForAzureSql(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationUpdateCustomerAppPermissionForAzureSql",
                "",
                fieldSpecDoc,
                "System.String"
            );
        }

        // Invoke GraphQL Mutation:
        // startDisableAzureCloudAccountJob(input: StartDisableAzureCloudAccountJobInput!): BatchAsyncJobStatus!
        internal void InvokeMutationStartDisableAzureCloudAccountJob()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "StartDisableAzureCloudAccountJobInput!"),
            };
            BatchAsyncJobStatus? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (BatchAsyncJobStatus)psObject.BaseObject;
                } else {
                    fieldSpecObj = (BatchAsyncJobStatus)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.StartDisableAzureCloudAccountJob(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationStartDisableAzureCloudAccountJob",
                "($input: StartDisableAzureCloudAccountJobInput!)",
                fieldSpecDoc,
                "BatchAsyncJobStatus"
            );
        }

        // Invoke GraphQL Mutation:
        // updateAzureCloudAccount(input: UpdateAzureCloudAccountInput!): UpdateAzureCloudAccountReply!
        internal void InvokeMutationUpdateAzureCloudAccount()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateAzureCloudAccountInput!"),
            };
            UpdateAzureCloudAccountReply? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (UpdateAzureCloudAccountReply)psObject.BaseObject;
                } else {
                    fieldSpecObj = (UpdateAzureCloudAccountReply)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.UpdateAzureCloudAccount(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationUpdateAzureCloudAccount",
                "($input: UpdateAzureCloudAccountInput!)",
                fieldSpecDoc,
                "UpdateAzureCloudAccountReply"
            );
        }

        // Invoke GraphQL Mutation:
        // mapAzureCloudAccountToPersistentStorageLocation(input: MapAzureCloudAccountToPersistentStorageLocationInput!): MapAzureCloudAccountToPersistentStorageLocationReply!
        internal void InvokeMutationMapAzureCloudAccountToPersistentStorageLocation()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "MapAzureCloudAccountToPersistentStorageLocationInput!"),
            };
            MapAzureCloudAccountToPersistentStorageLocationReply? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (MapAzureCloudAccountToPersistentStorageLocationReply)psObject.BaseObject;
                } else {
                    fieldSpecObj = (MapAzureCloudAccountToPersistentStorageLocationReply)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.MapAzureCloudAccountToPersistentStorageLocation(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationMapAzureCloudAccountToPersistentStorageLocation",
                "($input: MapAzureCloudAccountToPersistentStorageLocationInput!)",
                fieldSpecDoc,
                "MapAzureCloudAccountToPersistentStorageLocationReply"
            );
        }

        // Invoke GraphQL Mutation:
        // addAzureCloudAccountExocomputeConfigurations(input: AddAzureCloudAccountExocomputeConfigurationsInput!): AddAzureCloudAccountExocomputeConfigurationsReply!
        internal void InvokeMutationAddAzureCloudAccountExocomputeConfigurations()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "AddAzureCloudAccountExocomputeConfigurationsInput!"),
            };
            AddAzureCloudAccountExocomputeConfigurationsReply? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (AddAzureCloudAccountExocomputeConfigurationsReply)psObject.BaseObject;
                } else {
                    fieldSpecObj = (AddAzureCloudAccountExocomputeConfigurationsReply)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.AddAzureCloudAccountExocomputeConfigurations(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationAddAzureCloudAccountExocomputeConfigurations",
                "($input: AddAzureCloudAccountExocomputeConfigurationsInput!)",
                fieldSpecDoc,
                "AddAzureCloudAccountExocomputeConfigurationsReply"
            );
        }

        // Invoke GraphQL Mutation:
        // deleteAzureCloudAccountExocomputeConfigurations(input: DeleteAzureCloudAccountExocomputeConfigurationsInput!): DeleteAzureCloudAccountExocomputeConfigurationsReply!
        internal void InvokeMutationDeleteAzureCloudAccountExocomputeConfigurations()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteAzureCloudAccountExocomputeConfigurationsInput!"),
            };
            DeleteAzureCloudAccountExocomputeConfigurationsReply? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (DeleteAzureCloudAccountExocomputeConfigurationsReply)psObject.BaseObject;
                } else {
                    fieldSpecObj = (DeleteAzureCloudAccountExocomputeConfigurationsReply)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.DeleteAzureCloudAccountExocomputeConfigurations(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationDeleteAzureCloudAccountExocomputeConfigurations",
                "($input: DeleteAzureCloudAccountExocomputeConfigurationsInput!)",
                fieldSpecDoc,
                "DeleteAzureCloudAccountExocomputeConfigurationsReply"
            );
        }

        // Invoke GraphQL Mutation:
        // mapAzureCloudAccountExocomputeSubscription(input: MapAzureCloudAccountExocomputeSubscriptionInput!): MapAzureCloudAccountExocomputeSubscriptionReply!
        internal void InvokeMutationMapAzureCloudAccountExocomputeSubscription()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "MapAzureCloudAccountExocomputeSubscriptionInput!"),
            };
            MapAzureCloudAccountExocomputeSubscriptionReply? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (MapAzureCloudAccountExocomputeSubscriptionReply)psObject.BaseObject;
                } else {
                    fieldSpecObj = (MapAzureCloudAccountExocomputeSubscriptionReply)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.MapAzureCloudAccountExocomputeSubscription(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationMapAzureCloudAccountExocomputeSubscription",
                "($input: MapAzureCloudAccountExocomputeSubscriptionInput!)",
                fieldSpecDoc,
                "MapAzureCloudAccountExocomputeSubscriptionReply"
            );
        }

        // Invoke GraphQL Mutation:
        // unmapAzureCloudAccountExocomputeSubscription(input: UnmapAzureCloudAccountExocomputeSubscriptionInput!): UnmapAzureCloudAccountExocomputeSubscriptionReply!
        internal void InvokeMutationUnmapAzureCloudAccountExocomputeSubscription()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UnmapAzureCloudAccountExocomputeSubscriptionInput!"),
            };
            UnmapAzureCloudAccountExocomputeSubscriptionReply? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (UnmapAzureCloudAccountExocomputeSubscriptionReply)psObject.BaseObject;
                } else {
                    fieldSpecObj = (UnmapAzureCloudAccountExocomputeSubscriptionReply)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.UnmapAzureCloudAccountExocomputeSubscription(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationUnmapAzureCloudAccountExocomputeSubscription",
                "($input: UnmapAzureCloudAccountExocomputeSubscriptionInput!)",
                fieldSpecDoc,
                "UnmapAzureCloudAccountExocomputeSubscriptionReply"
            );
        }

        // Invoke GraphQL Mutation:
        // upgradeAzureCloudAccountPermissionsWithoutOauth(input: UpgradeAzureCloudAccountPermissionsWithoutOauthInput!): UpgradeAzureCloudAccountPermissionsWithoutOauthReply!
        internal void InvokeMutationUpgradeAzureCloudAccountPermissionsWithoutOauth()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpgradeAzureCloudAccountPermissionsWithoutOauthInput!"),
            };
            UpgradeAzureCloudAccountPermissionsWithoutOauthReply? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (UpgradeAzureCloudAccountPermissionsWithoutOauthReply)psObject.BaseObject;
                } else {
                    fieldSpecObj = (UpgradeAzureCloudAccountPermissionsWithoutOauthReply)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.UpgradeAzureCloudAccountPermissionsWithoutOauth(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationUpgradeAzureCloudAccountPermissionsWithoutOauth",
                "($input: UpgradeAzureCloudAccountPermissionsWithoutOauthInput!)",
                fieldSpecDoc,
                "UpgradeAzureCloudAccountPermissionsWithoutOauthReply"
            );
        }

        // Invoke GraphQL Mutation:
        // unmapAzurePersistentStorageSubscription(input: UnmapAzurePersistentStorageSubscriptionInput!): Void
        internal void InvokeMutationUnmapAzurePersistentStorageSubscription()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UnmapAzurePersistentStorageSubscriptionInput!"),
            };
            System.String? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (System.String)psObject.BaseObject;
                } else {
                    fieldSpecObj = (System.String)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.UnmapAzurePersistentStorageSubscription(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationUnmapAzurePersistentStorageSubscription",
                "($input: UnmapAzurePersistentStorageSubscriptionInput!)",
                fieldSpecDoc,
                "System.String"
            );
        }

        // Invoke GraphQL Mutation:
        // azureOauthConsentKickoff: AzureOauthConsentKickoffReply!
        internal void InvokeMutationAzureOauthConsentKickoff()
        {
            Tuple<string, string>[] argDefs = {
            };
            AzureOauthConsentKickoffReply? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (AzureOauthConsentKickoffReply)psObject.BaseObject;
                } else {
                    fieldSpecObj = (AzureOauthConsentKickoffReply)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.AzureOauthConsentKickoff(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationAzureOauthConsentKickoff",
                "",
                fieldSpecDoc,
                "AzureOauthConsentKickoffReply"
            );
        }

        // Invoke GraphQL Mutation:
        // azureOauthConsentComplete(input: AzureOauthConsentCompleteInput!): RequestStatus!
        internal void InvokeMutationAzureOauthConsentComplete()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "AzureOauthConsentCompleteInput!"),
            };
            RequestStatus? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (RequestStatus)psObject.BaseObject;
                } else {
                    fieldSpecObj = (RequestStatus)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.AzureOauthConsentComplete(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationAzureOauthConsentComplete",
                "($input: AzureOauthConsentCompleteInput!)",
                fieldSpecDoc,
                "RequestStatus"
            );
        }

        // Invoke GraphQL Mutation:
        // createAzureSaasAppAad: CreateAzureSaasAppAadReply!
        internal void InvokeMutationCreateAzureSaasAppAad()
        {
            Tuple<string, string>[] argDefs = {
            };
            CreateAzureSaasAppAadReply? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (CreateAzureSaasAppAadReply)psObject.BaseObject;
                } else {
                    fieldSpecObj = (CreateAzureSaasAppAadReply)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.CreateAzureSaasAppAad(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationCreateAzureSaasAppAad",
                "",
                fieldSpecDoc,
                "CreateAzureSaasAppAadReply"
            );
        }

        // Invoke GraphQL Mutation:
        // createAzureCluster(input: CreateAzureClusterInput!): CcProvisionJobReply!
        internal void InvokeMutationCreateAzureCluster()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateAzureClusterInput!"),
            };
            CcProvisionJobReply? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (CcProvisionJobReply)psObject.BaseObject;
                } else {
                    fieldSpecObj = (CcProvisionJobReply)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.CreateAzureCluster(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationCreateAzureCluster",
                "($input: CreateAzureClusterInput!)",
                fieldSpecDoc,
                "CcProvisionJobReply"
            );
        }

        // Invoke GraphQL Mutation:
        // deleteAzureCluster(input: DeleteAzureClusterInput!): CcProvisionJobReply!
        internal void InvokeMutationDeleteAzureCluster()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteAzureClusterInput!"),
            };
            CcProvisionJobReply? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (CcProvisionJobReply)psObject.BaseObject;
                } else {
                    fieldSpecObj = (CcProvisionJobReply)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.DeleteAzureCluster(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationDeleteAzureCluster",
                "($input: DeleteAzureClusterInput!)",
                fieldSpecDoc,
                "CcProvisionJobReply"
            );
        }

        // Invoke GraphQL Mutation:
        // kickoffAzureAdAppSetup(input: KickoffAzureAdAppSetupInput!): KickoffAzureAdAppSetupReply!
        internal void InvokeMutationKickoffAzureAdAppSetup()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "KickoffAzureAdAppSetupInput!"),
            };
            KickoffAzureAdAppSetupReply? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (KickoffAzureAdAppSetupReply)psObject.BaseObject;
                } else {
                    fieldSpecObj = (KickoffAzureAdAppSetupReply)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.KickoffAzureAdAppSetup(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationKickoffAzureAdAppSetup",
                "($input: KickoffAzureAdAppSetupInput!)",
                fieldSpecDoc,
                "KickoffAzureAdAppSetupReply"
            );
        }

        // Invoke GraphQL Mutation:
        // completeAzureAdAppSetup(input: CompleteAzureAdAppSetupInput!): CompleteAzureAdAppSetupReply!
        internal void InvokeMutationCompleteAzureAdAppSetup()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CompleteAzureAdAppSetupInput!"),
            };
            CompleteAzureAdAppSetupReply? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (CompleteAzureAdAppSetupReply)psObject.BaseObject;
                } else {
                    fieldSpecObj = (CompleteAzureAdAppSetupReply)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.CompleteAzureAdAppSetup(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationCompleteAzureAdAppSetup",
                "($input: CompleteAzureAdAppSetupInput!)",
                fieldSpecDoc,
                "CompleteAzureAdAppSetupReply"
            );
        }

        // Invoke GraphQL Mutation:
        // deleteAzureAdDirectory(workloadFid: UUID!): CreateOnDemandJobReply!
        internal void InvokeMutationDeleteAzureAdDirectory()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("workloadFid", "UUID!"),
            };
            CreateOnDemandJobReply? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (CreateOnDemandJobReply)psObject.BaseObject;
                } else {
                    fieldSpecObj = (CreateOnDemandJobReply)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.DeleteAzureAdDirectory(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationDeleteAzureAdDirectory",
                "($workloadFid: UUID!)",
                fieldSpecDoc,
                "CreateOnDemandJobReply"
            );
        }

        // Invoke GraphQL Mutation:
        // backupAzureAdDirectory(input: BackupAzureAdDirectoryInput!): [CreateOnDemandJobReply!]!
        internal void InvokeMutationBackupAzureAdDirectory()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "BackupAzureAdDirectoryInput!"),
            };
            List<CreateOnDemandJobReply>? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (List<CreateOnDemandJobReply>)psObject.BaseObject;
                } else {
                    fieldSpecObj = (List<CreateOnDemandJobReply>)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.BackupAzureAdDirectory(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationBackupAzureAdDirectory",
                "($input: BackupAzureAdDirectoryInput!)",
                fieldSpecDoc,
                "List<CreateOnDemandJobReply>"
            );
        }

        // Invoke GraphQL Mutation:
        // initiateAzureAdAppUpdate(input: InitiateAzureAdAppUpdateInput!): InitiateAzureAdAppUpdateReply!
        internal void InvokeMutationInitiateAzureAdAppUpdate()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "InitiateAzureAdAppUpdateInput!"),
            };
            InitiateAzureAdAppUpdateReply? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (InitiateAzureAdAppUpdateReply)psObject.BaseObject;
                } else {
                    fieldSpecObj = (InitiateAzureAdAppUpdateReply)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.InitiateAzureAdAppUpdate(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationInitiateAzureAdAppUpdate",
                "($input: InitiateAzureAdAppUpdateInput!)",
                fieldSpecDoc,
                "InitiateAzureAdAppUpdateReply"
            );
        }

        // Invoke GraphQL Mutation:
        // completeAzureAdAppUpdate(input: CompleteAzureAdAppUpdateInput!): Void
        internal void InvokeMutationCompleteAzureAdAppUpdate()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CompleteAzureAdAppUpdateInput!"),
            };
            System.String? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (System.String)psObject.BaseObject;
                } else {
                    fieldSpecObj = (System.String)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.CompleteAzureAdAppUpdate(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationCompleteAzureAdAppUpdate",
                "($input: CompleteAzureAdAppUpdateInput!)",
                fieldSpecDoc,
                "System.String"
            );
        }

        // Invoke GraphQL Mutation:
        // restoreAzureAdObjectsWithPassword(input: RestoreAzureAdObjectsWithPasswordInput!): [CreateOnDemandJobReply!]!
        internal void InvokeMutationRestoreAzureAdObjectsWithPassword()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "RestoreAzureAdObjectsWithPasswordInput!"),
            };
            List<CreateOnDemandJobReply>? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (List<CreateOnDemandJobReply>)psObject.BaseObject;
                } else {
                    fieldSpecObj = (List<CreateOnDemandJobReply>)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.RestoreAzureAdObjectsWithPassword(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationRestoreAzureAdObjectsWithPassword",
                "($input: RestoreAzureAdObjectsWithPasswordInput!)",
                fieldSpecDoc,
                "List<CreateOnDemandJobReply>"
            );
        }


    } // class Invoke_RscMutateAzure
}