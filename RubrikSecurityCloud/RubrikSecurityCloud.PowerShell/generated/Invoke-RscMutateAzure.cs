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
        
        // -------------------------------------------------------------------
        // StartRefreshNativeSubscriptionsJob parameter set
        //
        // [GraphQL: startRefreshAzureNativeSubscriptionsJob]
        //
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

        
        // -------------------------------------------------------------------
        // StartRestoreNativeVirtualMachineJob parameter set
        //
        // [GraphQL: startRestoreAzureNativeVirtualMachineJob]
        //
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

        
        // -------------------------------------------------------------------
        // StartExportNativeVirtualMachineJob parameter set
        //
        // [GraphQL: startExportAzureNativeVirtualMachineJob]
        //
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

        
        // -------------------------------------------------------------------
        // ExcludeNativeManagedDisksFromSnapshot parameter set
        //
        // [GraphQL: excludeAzureNativeManagedDisksFromSnapshot]
        //
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

        
        // -------------------------------------------------------------------
        // StartCreateNativeVirtualMachineSnapshotsJob parameter set
        //
        // [GraphQL: startCreateAzureNativeVirtualMachineSnapshotsJob]
        //
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

        
        // -------------------------------------------------------------------
        // StartDisableNativeSubscriptionProtectionJob parameter set
        //
        // [GraphQL: startDisableAzureNativeSubscriptionProtectionJob]
        //
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

        
        // -------------------------------------------------------------------
        // StartCreateNativeManagedDiskSnapshotsJob parameter set
        //
        // [GraphQL: startCreateAzureNativeManagedDiskSnapshotsJob]
        //
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

        
        // -------------------------------------------------------------------
        // StartExportNativeManagedDiskJob parameter set
        //
        // [GraphQL: startExportAzureNativeManagedDiskJob]
        //
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

        
        // -------------------------------------------------------------------
        // StartExportSqlDatabaseDbJob parameter set
        //
        // [GraphQL: startExportAzureSqlDatabaseDbJob]
        //
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

        
        // -------------------------------------------------------------------
        // StartExportSqlManagedInstanceDbJob parameter set
        //
        // [GraphQL: startExportAzureSqlManagedInstanceDbJob]
        //
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

        
        // -------------------------------------------------------------------
        // CreateAccount parameter set
        //
        // [GraphQL: createAzureAccount]
        //
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

        
        // -------------------------------------------------------------------
        // UpdateAccount parameter set
        //
        // [GraphQL: updateAzureAccount]
        //
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

        
        // -------------------------------------------------------------------
        // CreateAutomaticTargetMapping parameter set
        //
        // [GraphQL: createAutomaticAzureTargetMapping]
        //
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

        
        // -------------------------------------------------------------------
        // CreateCloudNativeStorageSetting parameter set
        //
        // [GraphQL: createCloudNativeAzureStorageSetting]
        //
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

        
        // -------------------------------------------------------------------
        // CreateCloudNativeRcvStorageSetting parameter set
        //
        // [GraphQL: createCloudNativeRcvAzureStorageSetting]
        //
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

        
        // -------------------------------------------------------------------
        // UpdateAutomaticTargetMapping parameter set
        //
        // [GraphQL: updateAutomaticAzureTargetMapping]
        //
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

        
        // -------------------------------------------------------------------
        // UpdateCloudNativeStorageSetting parameter set
        //
        // [GraphQL: updateCloudNativeAzureStorageSetting]
        //
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

        
        // -------------------------------------------------------------------
        // UpdateCloudNativeRcvStorageSetting parameter set
        //
        // [GraphQL: updateCloudNativeRcvAzureStorageSetting]
        //
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

        
        // -------------------------------------------------------------------
        // CreateTarget parameter set
        //
        // [GraphQL: createAzureTarget]
        //
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

        
        // -------------------------------------------------------------------
        // UpdateTarget parameter set
        //
        // [GraphQL: updateAzureTarget]
        //
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

        
        // -------------------------------------------------------------------
        // CreateReaderTarget parameter set
        //
        // [GraphQL: createAzureReaderTarget]
        //
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

        
        // -------------------------------------------------------------------
        // StartCloudAccountOauth parameter set
        //
        // [GraphQL: startAzureCloudAccountOauth]
        //
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

        
        // -------------------------------------------------------------------
        // CompleteCloudAccountOauth parameter set
        //
        // [GraphQL: completeAzureCloudAccountOauth]
        //
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

        
        // -------------------------------------------------------------------
        // SetCloudAccountCustomerAppCredentials parameter set
        //
        // [GraphQL: setAzureCloudAccountCustomerAppCredentials]
        //
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

        
        // -------------------------------------------------------------------
        // AddCloudAccount parameter set
        //
        // [GraphQL: addAzureCloudAccount]
        //
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

        
        // -------------------------------------------------------------------
        // AddCloudAccountWithoutOauth parameter set
        //
        // [GraphQL: addAzureCloudAccountWithoutOauth]
        //
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

        
        // -------------------------------------------------------------------
        // DeleteCloudAccount parameter set
        //
        // [GraphQL: deleteAzureCloudAccount]
        //
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

        
        // -------------------------------------------------------------------
        // DeleteCloudAccountWithoutOauth parameter set
        //
        // [GraphQL: deleteAzureCloudAccountWithoutOauth]
        //
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

        
        // -------------------------------------------------------------------
        // UpgradeCloudAccount parameter set
        //
        // [GraphQL: upgradeAzureCloudAccount]
        //
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

        
        // -------------------------------------------------------------------
        // UpdateCustomerAppPermissionForSql parameter set
        //
        // [GraphQL: updateCustomerAppPermissionForAzureSql]
        //
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

        
        // -------------------------------------------------------------------
        // StartDisableCloudAccountJob parameter set
        //
        // [GraphQL: startDisableAzureCloudAccountJob]
        //
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

        
        // -------------------------------------------------------------------
        // UpdateCloudAccount parameter set
        //
        // [GraphQL: updateAzureCloudAccount]
        //
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

        
        // -------------------------------------------------------------------
        // MapCloudAccountToPersistentStorageLocation parameter set
        //
        // [GraphQL: mapAzureCloudAccountToPersistentStorageLocation]
        //
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

        
        // -------------------------------------------------------------------
        // AddCloudAccountExocomputeConfigurations parameter set
        //
        // [GraphQL: addAzureCloudAccountExocomputeConfigurations]
        //
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

        
        // -------------------------------------------------------------------
        // DeleteCloudAccountExocomputeConfigurations parameter set
        //
        // [GraphQL: deleteAzureCloudAccountExocomputeConfigurations]
        //
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

        
        // -------------------------------------------------------------------
        // MapCloudAccountExocomputeSubscription parameter set
        //
        // [GraphQL: mapAzureCloudAccountExocomputeSubscription]
        //
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

        
        // -------------------------------------------------------------------
        // UnmapCloudAccountExocomputeSubscription parameter set
        //
        // [GraphQL: unmapAzureCloudAccountExocomputeSubscription]
        //
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

        
        // -------------------------------------------------------------------
        // UpgradeCloudAccountPermissionsWithoutOauth parameter set
        //
        // [GraphQL: upgradeAzureCloudAccountPermissionsWithoutOauth]
        //
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

        
        // -------------------------------------------------------------------
        // UnmapPersistentStorageSubscription parameter set
        //
        // [GraphQL: unmapAzurePersistentStorageSubscription]
        //
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

        
        // -------------------------------------------------------------------
        // OauthConsentKickoff parameter set
        //
        // [GraphQL: azureOauthConsentKickoff]
        //
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

        
        // -------------------------------------------------------------------
        // OauthConsentComplete parameter set
        //
        // [GraphQL: azureOauthConsentComplete]
        //
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

        
        // -------------------------------------------------------------------
        // CreateSaasAppAad parameter set
        //
        // [GraphQL: createAzureSaasAppAad]
        //
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

        
        // -------------------------------------------------------------------
        // CreateCluster parameter set
        //
        // [GraphQL: createAzureCluster]
        //
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

        
        // -------------------------------------------------------------------
        // DeleteCluster parameter set
        //
        // [GraphQL: deleteAzureCluster]
        //
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

        
        // -------------------------------------------------------------------
        // KickoffAdAppSetup parameter set
        //
        // [GraphQL: kickoffAzureAdAppSetup]
        //
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

        
        // -------------------------------------------------------------------
        // CompleteAdAppSetup parameter set
        //
        // [GraphQL: completeAzureAdAppSetup]
        //
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

        
        // -------------------------------------------------------------------
        // DeleteAdDirectory parameter set
        //
        // [GraphQL: deleteAzureAdDirectory]
        //
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

        
        // -------------------------------------------------------------------
        // BackupAdDirectory parameter set
        //
        // [GraphQL: backupAzureAdDirectory]
        //
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

        
        // -------------------------------------------------------------------
        // InitiateAdAppUpdate parameter set
        //
        // [GraphQL: initiateAzureAdAppUpdate]
        //
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

        
        // -------------------------------------------------------------------
        // CompleteAdAppUpdate parameter set
        //
        // [GraphQL: completeAzureAdAppUpdate]
        //
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
        // startRefreshAzureNativeSubscriptionsJob.
        protected void ProcessRecord_StartRefreshNativeSubscriptionsJob()
        {
            this._logger.name += " -StartRefreshNativeSubscriptionsJob";
            // Invoke graphql operation startRefreshAzureNativeSubscriptionsJob
            InvokeMutationStartRefreshAzureNativeSubscriptionsJob();
        }

        // This parameter set invokes a single graphql operation:
        // startRestoreAzureNativeVirtualMachineJob.
        protected void ProcessRecord_StartRestoreNativeVirtualMachineJob()
        {
            this._logger.name += " -StartRestoreNativeVirtualMachineJob";
            // Invoke graphql operation startRestoreAzureNativeVirtualMachineJob
            InvokeMutationStartRestoreAzureNativeVirtualMachineJob();
        }

        // This parameter set invokes a single graphql operation:
        // startExportAzureNativeVirtualMachineJob.
        protected void ProcessRecord_StartExportNativeVirtualMachineJob()
        {
            this._logger.name += " -StartExportNativeVirtualMachineJob";
            // Invoke graphql operation startExportAzureNativeVirtualMachineJob
            InvokeMutationStartExportAzureNativeVirtualMachineJob();
        }

        // This parameter set invokes a single graphql operation:
        // excludeAzureNativeManagedDisksFromSnapshot.
        protected void ProcessRecord_ExcludeNativeManagedDisksFromSnapshot()
        {
            this._logger.name += " -ExcludeNativeManagedDisksFromSnapshot";
            // Invoke graphql operation excludeAzureNativeManagedDisksFromSnapshot
            InvokeMutationExcludeAzureNativeManagedDisksFromSnapshot();
        }

        // This parameter set invokes a single graphql operation:
        // startCreateAzureNativeVirtualMachineSnapshotsJob.
        protected void ProcessRecord_StartCreateNativeVirtualMachineSnapshotsJob()
        {
            this._logger.name += " -StartCreateNativeVirtualMachineSnapshotsJob";
            // Invoke graphql operation startCreateAzureNativeVirtualMachineSnapshotsJob
            InvokeMutationStartCreateAzureNativeVirtualMachineSnapshotsJob();
        }

        // This parameter set invokes a single graphql operation:
        // startDisableAzureNativeSubscriptionProtectionJob.
        protected void ProcessRecord_StartDisableNativeSubscriptionProtectionJob()
        {
            this._logger.name += " -StartDisableNativeSubscriptionProtectionJob";
            // Invoke graphql operation startDisableAzureNativeSubscriptionProtectionJob
            InvokeMutationStartDisableAzureNativeSubscriptionProtectionJob();
        }

        // This parameter set invokes a single graphql operation:
        // startCreateAzureNativeManagedDiskSnapshotsJob.
        protected void ProcessRecord_StartCreateNativeManagedDiskSnapshotsJob()
        {
            this._logger.name += " -StartCreateNativeManagedDiskSnapshotsJob";
            // Invoke graphql operation startCreateAzureNativeManagedDiskSnapshotsJob
            InvokeMutationStartCreateAzureNativeManagedDiskSnapshotsJob();
        }

        // This parameter set invokes a single graphql operation:
        // startExportAzureNativeManagedDiskJob.
        protected void ProcessRecord_StartExportNativeManagedDiskJob()
        {
            this._logger.name += " -StartExportNativeManagedDiskJob";
            // Invoke graphql operation startExportAzureNativeManagedDiskJob
            InvokeMutationStartExportAzureNativeManagedDiskJob();
        }

        // This parameter set invokes a single graphql operation:
        // startExportAzureSqlDatabaseDbJob.
        protected void ProcessRecord_StartExportSqlDatabaseDbJob()
        {
            this._logger.name += " -StartExportSqlDatabaseDbJob";
            // Invoke graphql operation startExportAzureSqlDatabaseDbJob
            InvokeMutationStartExportAzureSqlDatabaseDbJob();
        }

        // This parameter set invokes a single graphql operation:
        // startExportAzureSqlManagedInstanceDbJob.
        protected void ProcessRecord_StartExportSqlManagedInstanceDbJob()
        {
            this._logger.name += " -StartExportSqlManagedInstanceDbJob";
            // Invoke graphql operation startExportAzureSqlManagedInstanceDbJob
            InvokeMutationStartExportAzureSqlManagedInstanceDbJob();
        }

        // This parameter set invokes a single graphql operation:
        // createAzureAccount.
        protected void ProcessRecord_CreateAccount()
        {
            this._logger.name += " -CreateAccount";
            // Invoke graphql operation createAzureAccount
            InvokeMutationCreateAzureAccount();
        }

        // This parameter set invokes a single graphql operation:
        // updateAzureAccount.
        protected void ProcessRecord_UpdateAccount()
        {
            this._logger.name += " -UpdateAccount";
            // Invoke graphql operation updateAzureAccount
            InvokeMutationUpdateAzureAccount();
        }

        // This parameter set invokes a single graphql operation:
        // createAutomaticAzureTargetMapping.
        protected void ProcessRecord_CreateAutomaticTargetMapping()
        {
            this._logger.name += " -CreateAutomaticTargetMapping";
            // Invoke graphql operation createAutomaticAzureTargetMapping
            InvokeMutationCreateAutomaticAzureTargetMapping();
        }

        // This parameter set invokes a single graphql operation:
        // createCloudNativeAzureStorageSetting.
        protected void ProcessRecord_CreateCloudNativeStorageSetting()
        {
            this._logger.name += " -CreateCloudNativeStorageSetting";
            // Invoke graphql operation createCloudNativeAzureStorageSetting
            InvokeMutationCreateCloudNativeAzureStorageSetting();
        }

        // This parameter set invokes a single graphql operation:
        // createCloudNativeRcvAzureStorageSetting.
        protected void ProcessRecord_CreateCloudNativeRcvStorageSetting()
        {
            this._logger.name += " -CreateCloudNativeRcvStorageSetting";
            // Invoke graphql operation createCloudNativeRcvAzureStorageSetting
            InvokeMutationCreateCloudNativeRcvAzureStorageSetting();
        }

        // This parameter set invokes a single graphql operation:
        // updateAutomaticAzureTargetMapping.
        protected void ProcessRecord_UpdateAutomaticTargetMapping()
        {
            this._logger.name += " -UpdateAutomaticTargetMapping";
            // Invoke graphql operation updateAutomaticAzureTargetMapping
            InvokeMutationUpdateAutomaticAzureTargetMapping();
        }

        // This parameter set invokes a single graphql operation:
        // updateCloudNativeAzureStorageSetting.
        protected void ProcessRecord_UpdateCloudNativeStorageSetting()
        {
            this._logger.name += " -UpdateCloudNativeStorageSetting";
            // Invoke graphql operation updateCloudNativeAzureStorageSetting
            InvokeMutationUpdateCloudNativeAzureStorageSetting();
        }

        // This parameter set invokes a single graphql operation:
        // updateCloudNativeRcvAzureStorageSetting.
        protected void ProcessRecord_UpdateCloudNativeRcvStorageSetting()
        {
            this._logger.name += " -UpdateCloudNativeRcvStorageSetting";
            // Invoke graphql operation updateCloudNativeRcvAzureStorageSetting
            InvokeMutationUpdateCloudNativeRcvAzureStorageSetting();
        }

        // This parameter set invokes a single graphql operation:
        // createAzureTarget.
        protected void ProcessRecord_CreateTarget()
        {
            this._logger.name += " -CreateTarget";
            // Invoke graphql operation createAzureTarget
            InvokeMutationCreateAzureTarget();
        }

        // This parameter set invokes a single graphql operation:
        // updateAzureTarget.
        protected void ProcessRecord_UpdateTarget()
        {
            this._logger.name += " -UpdateTarget";
            // Invoke graphql operation updateAzureTarget
            InvokeMutationUpdateAzureTarget();
        }

        // This parameter set invokes a single graphql operation:
        // createAzureReaderTarget.
        protected void ProcessRecord_CreateReaderTarget()
        {
            this._logger.name += " -CreateReaderTarget";
            // Invoke graphql operation createAzureReaderTarget
            InvokeMutationCreateAzureReaderTarget();
        }

        // This parameter set invokes a single graphql operation:
        // startAzureCloudAccountOauth.
        protected void ProcessRecord_StartCloudAccountOauth()
        {
            this._logger.name += " -StartCloudAccountOauth";
            // Invoke graphql operation startAzureCloudAccountOauth
            InvokeMutationStartAzureCloudAccountOauth();
        }

        // This parameter set invokes a single graphql operation:
        // completeAzureCloudAccountOauth.
        protected void ProcessRecord_CompleteCloudAccountOauth()
        {
            this._logger.name += " -CompleteCloudAccountOauth";
            // Invoke graphql operation completeAzureCloudAccountOauth
            InvokeMutationCompleteAzureCloudAccountOauth();
        }

        // This parameter set invokes a single graphql operation:
        // setAzureCloudAccountCustomerAppCredentials.
        protected void ProcessRecord_SetCloudAccountCustomerAppCredentials()
        {
            this._logger.name += " -SetCloudAccountCustomerAppCredentials";
            // Invoke graphql operation setAzureCloudAccountCustomerAppCredentials
            InvokeMutationSetAzureCloudAccountCustomerAppCredentials();
        }

        // This parameter set invokes a single graphql operation:
        // addAzureCloudAccount.
        protected void ProcessRecord_AddCloudAccount()
        {
            this._logger.name += " -AddCloudAccount";
            // Invoke graphql operation addAzureCloudAccount
            InvokeMutationAddAzureCloudAccount();
        }

        // This parameter set invokes a single graphql operation:
        // addAzureCloudAccountWithoutOauth.
        protected void ProcessRecord_AddCloudAccountWithoutOauth()
        {
            this._logger.name += " -AddCloudAccountWithoutOauth";
            // Invoke graphql operation addAzureCloudAccountWithoutOauth
            InvokeMutationAddAzureCloudAccountWithoutOauth();
        }

        // This parameter set invokes a single graphql operation:
        // deleteAzureCloudAccount.
        protected void ProcessRecord_DeleteCloudAccount()
        {
            this._logger.name += " -DeleteCloudAccount";
            // Invoke graphql operation deleteAzureCloudAccount
            InvokeMutationDeleteAzureCloudAccount();
        }

        // This parameter set invokes a single graphql operation:
        // deleteAzureCloudAccountWithoutOauth.
        protected void ProcessRecord_DeleteCloudAccountWithoutOauth()
        {
            this._logger.name += " -DeleteCloudAccountWithoutOauth";
            // Invoke graphql operation deleteAzureCloudAccountWithoutOauth
            InvokeMutationDeleteAzureCloudAccountWithoutOauth();
        }

        // This parameter set invokes a single graphql operation:
        // upgradeAzureCloudAccount.
        protected void ProcessRecord_UpgradeCloudAccount()
        {
            this._logger.name += " -UpgradeCloudAccount";
            // Invoke graphql operation upgradeAzureCloudAccount
            InvokeMutationUpgradeAzureCloudAccount();
        }

        // This parameter set invokes a single graphql operation:
        // updateCustomerAppPermissionForAzureSql.
        protected void ProcessRecord_UpdateCustomerAppPermissionForSql()
        {
            this._logger.name += " -UpdateCustomerAppPermissionForSql";
            // Invoke graphql operation updateCustomerAppPermissionForAzureSql
            InvokeMutationUpdateCustomerAppPermissionForAzureSql();
        }

        // This parameter set invokes a single graphql operation:
        // startDisableAzureCloudAccountJob.
        protected void ProcessRecord_StartDisableCloudAccountJob()
        {
            this._logger.name += " -StartDisableCloudAccountJob";
            // Invoke graphql operation startDisableAzureCloudAccountJob
            InvokeMutationStartDisableAzureCloudAccountJob();
        }

        // This parameter set invokes a single graphql operation:
        // updateAzureCloudAccount.
        protected void ProcessRecord_UpdateCloudAccount()
        {
            this._logger.name += " -UpdateCloudAccount";
            // Invoke graphql operation updateAzureCloudAccount
            InvokeMutationUpdateAzureCloudAccount();
        }

        // This parameter set invokes a single graphql operation:
        // mapAzureCloudAccountToPersistentStorageLocation.
        protected void ProcessRecord_MapCloudAccountToPersistentStorageLocation()
        {
            this._logger.name += " -MapCloudAccountToPersistentStorageLocation";
            // Invoke graphql operation mapAzureCloudAccountToPersistentStorageLocation
            InvokeMutationMapAzureCloudAccountToPersistentStorageLocation();
        }

        // This parameter set invokes a single graphql operation:
        // addAzureCloudAccountExocomputeConfigurations.
        protected void ProcessRecord_AddCloudAccountExocomputeConfigurations()
        {
            this._logger.name += " -AddCloudAccountExocomputeConfigurations";
            // Invoke graphql operation addAzureCloudAccountExocomputeConfigurations
            InvokeMutationAddAzureCloudAccountExocomputeConfigurations();
        }

        // This parameter set invokes a single graphql operation:
        // deleteAzureCloudAccountExocomputeConfigurations.
        protected void ProcessRecord_DeleteCloudAccountExocomputeConfigurations()
        {
            this._logger.name += " -DeleteCloudAccountExocomputeConfigurations";
            // Invoke graphql operation deleteAzureCloudAccountExocomputeConfigurations
            InvokeMutationDeleteAzureCloudAccountExocomputeConfigurations();
        }

        // This parameter set invokes a single graphql operation:
        // mapAzureCloudAccountExocomputeSubscription.
        protected void ProcessRecord_MapCloudAccountExocomputeSubscription()
        {
            this._logger.name += " -MapCloudAccountExocomputeSubscription";
            // Invoke graphql operation mapAzureCloudAccountExocomputeSubscription
            InvokeMutationMapAzureCloudAccountExocomputeSubscription();
        }

        // This parameter set invokes a single graphql operation:
        // unmapAzureCloudAccountExocomputeSubscription.
        protected void ProcessRecord_UnmapCloudAccountExocomputeSubscription()
        {
            this._logger.name += " -UnmapCloudAccountExocomputeSubscription";
            // Invoke graphql operation unmapAzureCloudAccountExocomputeSubscription
            InvokeMutationUnmapAzureCloudAccountExocomputeSubscription();
        }

        // This parameter set invokes a single graphql operation:
        // upgradeAzureCloudAccountPermissionsWithoutOauth.
        protected void ProcessRecord_UpgradeCloudAccountPermissionsWithoutOauth()
        {
            this._logger.name += " -UpgradeCloudAccountPermissionsWithoutOauth";
            // Invoke graphql operation upgradeAzureCloudAccountPermissionsWithoutOauth
            InvokeMutationUpgradeAzureCloudAccountPermissionsWithoutOauth();
        }

        // This parameter set invokes a single graphql operation:
        // unmapAzurePersistentStorageSubscription.
        protected void ProcessRecord_UnmapPersistentStorageSubscription()
        {
            this._logger.name += " -UnmapPersistentStorageSubscription";
            // Invoke graphql operation unmapAzurePersistentStorageSubscription
            InvokeMutationUnmapAzurePersistentStorageSubscription();
        }

        // This parameter set invokes a single graphql operation:
        // azureOauthConsentKickoff.
        protected void ProcessRecord_OauthConsentKickoff()
        {
            this._logger.name += " -OauthConsentKickoff";
            // Invoke graphql operation azureOauthConsentKickoff
            InvokeMutationAzureOauthConsentKickoff();
        }

        // This parameter set invokes a single graphql operation:
        // azureOauthConsentComplete.
        protected void ProcessRecord_OauthConsentComplete()
        {
            this._logger.name += " -OauthConsentComplete";
            // Invoke graphql operation azureOauthConsentComplete
            InvokeMutationAzureOauthConsentComplete();
        }

        // This parameter set invokes a single graphql operation:
        // createAzureSaasAppAad.
        protected void ProcessRecord_CreateSaasAppAad()
        {
            this._logger.name += " -CreateSaasAppAad";
            // Invoke graphql operation createAzureSaasAppAad
            InvokeMutationCreateAzureSaasAppAad();
        }

        // This parameter set invokes a single graphql operation:
        // createAzureCluster.
        protected void ProcessRecord_CreateCluster()
        {
            this._logger.name += " -CreateCluster";
            // Invoke graphql operation createAzureCluster
            InvokeMutationCreateAzureCluster();
        }

        // This parameter set invokes a single graphql operation:
        // deleteAzureCluster.
        protected void ProcessRecord_DeleteCluster()
        {
            this._logger.name += " -DeleteCluster";
            // Invoke graphql operation deleteAzureCluster
            InvokeMutationDeleteAzureCluster();
        }

        // This parameter set invokes a single graphql operation:
        // kickoffAzureAdAppSetup.
        protected void ProcessRecord_KickoffAdAppSetup()
        {
            this._logger.name += " -KickoffAdAppSetup";
            // Invoke graphql operation kickoffAzureAdAppSetup
            InvokeMutationKickoffAzureAdAppSetup();
        }

        // This parameter set invokes a single graphql operation:
        // completeAzureAdAppSetup.
        protected void ProcessRecord_CompleteAdAppSetup()
        {
            this._logger.name += " -CompleteAdAppSetup";
            // Invoke graphql operation completeAzureAdAppSetup
            InvokeMutationCompleteAzureAdAppSetup();
        }

        // This parameter set invokes a single graphql operation:
        // deleteAzureAdDirectory.
        protected void ProcessRecord_DeleteAdDirectory()
        {
            this._logger.name += " -DeleteAdDirectory";
            // Invoke graphql operation deleteAzureAdDirectory
            InvokeMutationDeleteAzureAdDirectory();
        }

        // This parameter set invokes a single graphql operation:
        // backupAzureAdDirectory.
        protected void ProcessRecord_BackupAdDirectory()
        {
            this._logger.name += " -BackupAdDirectory";
            // Invoke graphql operation backupAzureAdDirectory
            InvokeMutationBackupAzureAdDirectory();
        }

        // This parameter set invokes a single graphql operation:
        // initiateAzureAdAppUpdate.
        protected void ProcessRecord_InitiateAdAppUpdate()
        {
            this._logger.name += " -InitiateAdAppUpdate";
            // Invoke graphql operation initiateAzureAdAppUpdate
            InvokeMutationInitiateAzureAdAppUpdate();
        }

        // This parameter set invokes a single graphql operation:
        // completeAzureAdAppUpdate.
        protected void ProcessRecord_CompleteAdAppUpdate()
        {
            this._logger.name += " -CompleteAdAppUpdate";
            // Invoke graphql operation completeAzureAdAppUpdate
            InvokeMutationCompleteAzureAdAppUpdate();
        }


        // Invoke GraphQL Mutation:
        // startRefreshAzureNativeSubscriptionsJob(input: StartRefreshAzureNativeSubscriptionsJobInput!): BatchAsyncJobStatus!
        protected void InvokeMutationStartRefreshAzureNativeSubscriptionsJob()
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
        protected void InvokeMutationStartRestoreAzureNativeVirtualMachineJob()
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
        protected void InvokeMutationStartExportAzureNativeVirtualMachineJob()
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
        protected void InvokeMutationExcludeAzureNativeManagedDisksFromSnapshot()
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
        protected void InvokeMutationStartCreateAzureNativeVirtualMachineSnapshotsJob()
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
        protected void InvokeMutationStartDisableAzureNativeSubscriptionProtectionJob()
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
        protected void InvokeMutationStartCreateAzureNativeManagedDiskSnapshotsJob()
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
        protected void InvokeMutationStartExportAzureNativeManagedDiskJob()
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
        protected void InvokeMutationStartExportAzureSqlDatabaseDbJob()
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
        protected void InvokeMutationStartExportAzureSqlManagedInstanceDbJob()
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
        protected void InvokeMutationCreateAzureAccount()
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
        protected void InvokeMutationUpdateAzureAccount()
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
        protected void InvokeMutationCreateAutomaticAzureTargetMapping()
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
        protected void InvokeMutationCreateCloudNativeAzureStorageSetting()
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
        protected void InvokeMutationCreateCloudNativeRcvAzureStorageSetting()
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
        protected void InvokeMutationUpdateAutomaticAzureTargetMapping()
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
        protected void InvokeMutationUpdateCloudNativeAzureStorageSetting()
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
        protected void InvokeMutationUpdateCloudNativeRcvAzureStorageSetting()
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
        protected void InvokeMutationCreateAzureTarget()
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
        protected void InvokeMutationUpdateAzureTarget()
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
        protected void InvokeMutationCreateAzureReaderTarget()
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
        protected void InvokeMutationStartAzureCloudAccountOauth()
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
        protected void InvokeMutationCompleteAzureCloudAccountOauth()
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
        protected void InvokeMutationSetAzureCloudAccountCustomerAppCredentials()
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
        protected void InvokeMutationAddAzureCloudAccount()
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
        protected void InvokeMutationAddAzureCloudAccountWithoutOauth()
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
        protected void InvokeMutationDeleteAzureCloudAccount()
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
        protected void InvokeMutationDeleteAzureCloudAccountWithoutOauth()
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
        protected void InvokeMutationUpgradeAzureCloudAccount()
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
        protected void InvokeMutationUpdateCustomerAppPermissionForAzureSql()
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
        protected void InvokeMutationStartDisableAzureCloudAccountJob()
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
        protected void InvokeMutationUpdateAzureCloudAccount()
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
        protected void InvokeMutationMapAzureCloudAccountToPersistentStorageLocation()
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
        protected void InvokeMutationAddAzureCloudAccountExocomputeConfigurations()
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
        protected void InvokeMutationDeleteAzureCloudAccountExocomputeConfigurations()
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
        protected void InvokeMutationMapAzureCloudAccountExocomputeSubscription()
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
        protected void InvokeMutationUnmapAzureCloudAccountExocomputeSubscription()
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
        protected void InvokeMutationUpgradeAzureCloudAccountPermissionsWithoutOauth()
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
        protected void InvokeMutationUnmapAzurePersistentStorageSubscription()
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
        protected void InvokeMutationAzureOauthConsentKickoff()
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
        protected void InvokeMutationAzureOauthConsentComplete()
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
        protected void InvokeMutationCreateAzureSaasAppAad()
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
        protected void InvokeMutationCreateAzureCluster()
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
        protected void InvokeMutationDeleteAzureCluster()
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
        protected void InvokeMutationKickoffAzureAdAppSetup()
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
        protected void InvokeMutationCompleteAzureAdAppSetup()
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
        protected void InvokeMutationDeleteAzureAdDirectory()
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
        protected void InvokeMutationBackupAzureAdDirectory()
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
        protected void InvokeMutationInitiateAzureAdAppUpdate()
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
        protected void InvokeMutationCompleteAzureAdAppUpdate()
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


    } // class Invoke_RscMutateAzure
}