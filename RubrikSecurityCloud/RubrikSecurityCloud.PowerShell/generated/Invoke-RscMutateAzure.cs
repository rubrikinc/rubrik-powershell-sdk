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
        // SetCloudAccountCustomerAppCredential parameter set
        //
        // [GraphQL: setAzureCloudAccountCustomerAppCredentials]
        //
        [Parameter(
            ParameterSetName = "SetCloudAccountCustomerAppCredential",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Set credentials for the customer application, for the tenant domain name.
[GraphQL: setAzureCloudAccountCustomerAppCredentials]",
            Position = 0
        )]
        public SwitchParameter SetCloudAccountCustomerAppCredential { get; set; }

        
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
        // AddCloudAccountExocomputeConfiguration parameter set
        //
        // [GraphQL: addAzureCloudAccountExocomputeConfigurations]
        //
        [Parameter(
            ParameterSetName = "AddCloudAccountExocomputeConfiguration",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Add Exocompute configurations for an Azure Cloud Account.
[GraphQL: addAzureCloudAccountExocomputeConfigurations]",
            Position = 0
        )]
        public SwitchParameter AddCloudAccountExocomputeConfiguration { get; set; }

        
        // -------------------------------------------------------------------
        // DeleteCloudAccountExocomputeConfiguration parameter set
        //
        // [GraphQL: deleteAzureCloudAccountExocomputeConfigurations]
        //
        [Parameter(
            ParameterSetName = "DeleteCloudAccountExocomputeConfiguration",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Delete Exocompute configurations for an Azure Cloud Account.
[GraphQL: deleteAzureCloudAccountExocomputeConfigurations]",
            Position = 0
        )]
        public SwitchParameter DeleteCloudAccountExocomputeConfiguration { get; set; }

        
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
                    case "SetCloudAccountCustomerAppCredential":
                        this.ProcessRecord_SetCloudAccountCustomerAppCredential();
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
                    case "AddCloudAccountExocomputeConfiguration":
                        this.ProcessRecord_AddCloudAccountExocomputeConfiguration();
                        break;
                    case "DeleteCloudAccountExocomputeConfiguration":
                        this.ProcessRecord_DeleteCloudAccountExocomputeConfiguration();
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
        protected void ProcessRecord_SetCloudAccountCustomerAppCredential()
        {
            this._logger.name += " -SetCloudAccountCustomerAppCredential";
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
        protected void ProcessRecord_AddCloudAccountExocomputeConfiguration()
        {
            this._logger.name += " -AddCloudAccountExocomputeConfiguration";
            // Invoke graphql operation addAzureCloudAccountExocomputeConfigurations
            InvokeMutationAddAzureCloudAccountExocomputeConfigurations();
        }

        // This parameter set invokes a single graphql operation:
        // deleteAzureCloudAccountExocomputeConfigurations.
        protected void ProcessRecord_DeleteCloudAccountExocomputeConfiguration()
        {
            this._logger.name += " -DeleteCloudAccountExocomputeConfiguration";
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
            BatchAsyncJobStatus? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (BatchAsyncJobStatus)psObject.BaseObject;
                } else {
                    fields = (BatchAsyncJobStatus)this.Field;
                }
            }
            string document = Mutation.StartRefreshAzureNativeSubscriptionsJob(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.StartRefreshAzureNativeSubscriptionsJob");
            var parameters = "($input: StartRefreshAzureNativeSubscriptionsJobInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationStartRefreshAzureNativeSubscriptionsJob" + parameters + "{" + document + "}",
                OperationName = "MutationStartRefreshAzureNativeSubscriptionsJob",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "BatchAsyncJobStatus", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Mutation:
        // startRestoreAzureNativeVirtualMachineJob(input: StartRestoreAzureNativeVirtualMachineJobInput!): AsyncJobStatus!
        protected void InvokeMutationStartRestoreAzureNativeVirtualMachineJob()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "StartRestoreAzureNativeVirtualMachineJobInput!"),
            };
            AsyncJobStatus? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (AsyncJobStatus)psObject.BaseObject;
                } else {
                    fields = (AsyncJobStatus)this.Field;
                }
            }
            string document = Mutation.StartRestoreAzureNativeVirtualMachineJob(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.StartRestoreAzureNativeVirtualMachineJob");
            var parameters = "($input: StartRestoreAzureNativeVirtualMachineJobInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationStartRestoreAzureNativeVirtualMachineJob" + parameters + "{" + document + "}",
                OperationName = "MutationStartRestoreAzureNativeVirtualMachineJob",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "AsyncJobStatus", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Mutation:
        // startExportAzureNativeVirtualMachineJob(input: StartExportAzureNativeVirtualMachineJobInput!): AsyncJobStatus!
        protected void InvokeMutationStartExportAzureNativeVirtualMachineJob()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "StartExportAzureNativeVirtualMachineJobInput!"),
            };
            AsyncJobStatus? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (AsyncJobStatus)psObject.BaseObject;
                } else {
                    fields = (AsyncJobStatus)this.Field;
                }
            }
            string document = Mutation.StartExportAzureNativeVirtualMachineJob(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.StartExportAzureNativeVirtualMachineJob");
            var parameters = "($input: StartExportAzureNativeVirtualMachineJobInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationStartExportAzureNativeVirtualMachineJob" + parameters + "{" + document + "}",
                OperationName = "MutationStartExportAzureNativeVirtualMachineJob",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "AsyncJobStatus", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Mutation:
        // excludeAzureNativeManagedDisksFromSnapshot(input: ExcludeAzureNativeManagedDisksFromSnapshotInput!): Void
        protected void InvokeMutationExcludeAzureNativeManagedDisksFromSnapshot()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "ExcludeAzureNativeManagedDisksFromSnapshotInput!"),
            };
            System.String? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (System.String)psObject.BaseObject;
                } else {
                    fields = (System.String)this.Field;
                }
            }
            string document = Mutation.ExcludeAzureNativeManagedDisksFromSnapshot(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.ExcludeAzureNativeManagedDisksFromSnapshot");
            var parameters = "($input: ExcludeAzureNativeManagedDisksFromSnapshotInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationExcludeAzureNativeManagedDisksFromSnapshot" + parameters + "{" + document + "}",
                OperationName = "MutationExcludeAzureNativeManagedDisksFromSnapshot",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "System.String", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Mutation:
        // startCreateAzureNativeVirtualMachineSnapshotsJob(input: StartCreateAzureNativeVirtualMachineSnapshotsJobInput!): BatchAsyncJobStatus!
        protected void InvokeMutationStartCreateAzureNativeVirtualMachineSnapshotsJob()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "StartCreateAzureNativeVirtualMachineSnapshotsJobInput!"),
            };
            BatchAsyncJobStatus? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (BatchAsyncJobStatus)psObject.BaseObject;
                } else {
                    fields = (BatchAsyncJobStatus)this.Field;
                }
            }
            string document = Mutation.StartCreateAzureNativeVirtualMachineSnapshotsJob(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.StartCreateAzureNativeVirtualMachineSnapshotsJob");
            var parameters = "($input: StartCreateAzureNativeVirtualMachineSnapshotsJobInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationStartCreateAzureNativeVirtualMachineSnapshotsJob" + parameters + "{" + document + "}",
                OperationName = "MutationStartCreateAzureNativeVirtualMachineSnapshotsJob",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "BatchAsyncJobStatus", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Mutation:
        // startDisableAzureNativeSubscriptionProtectionJob(input: StartDisableAzureNativeSubscriptionProtectionJobInput!): AsyncJobStatus!
        protected void InvokeMutationStartDisableAzureNativeSubscriptionProtectionJob()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "StartDisableAzureNativeSubscriptionProtectionJobInput!"),
            };
            AsyncJobStatus? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (AsyncJobStatus)psObject.BaseObject;
                } else {
                    fields = (AsyncJobStatus)this.Field;
                }
            }
            string document = Mutation.StartDisableAzureNativeSubscriptionProtectionJob(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.StartDisableAzureNativeSubscriptionProtectionJob");
            var parameters = "($input: StartDisableAzureNativeSubscriptionProtectionJobInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationStartDisableAzureNativeSubscriptionProtectionJob" + parameters + "{" + document + "}",
                OperationName = "MutationStartDisableAzureNativeSubscriptionProtectionJob",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "AsyncJobStatus", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Mutation:
        // startCreateAzureNativeManagedDiskSnapshotsJob(input: StartCreateAzureNativeManagedDiskSnapshotsJobInput!): BatchAsyncJobStatus!
        protected void InvokeMutationStartCreateAzureNativeManagedDiskSnapshotsJob()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "StartCreateAzureNativeManagedDiskSnapshotsJobInput!"),
            };
            BatchAsyncJobStatus? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (BatchAsyncJobStatus)psObject.BaseObject;
                } else {
                    fields = (BatchAsyncJobStatus)this.Field;
                }
            }
            string document = Mutation.StartCreateAzureNativeManagedDiskSnapshotsJob(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.StartCreateAzureNativeManagedDiskSnapshotsJob");
            var parameters = "($input: StartCreateAzureNativeManagedDiskSnapshotsJobInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationStartCreateAzureNativeManagedDiskSnapshotsJob" + parameters + "{" + document + "}",
                OperationName = "MutationStartCreateAzureNativeManagedDiskSnapshotsJob",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "BatchAsyncJobStatus", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Mutation:
        // startExportAzureNativeManagedDiskJob(input: StartExportAzureNativeManagedDiskJobInput!): AsyncJobStatus!
        protected void InvokeMutationStartExportAzureNativeManagedDiskJob()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "StartExportAzureNativeManagedDiskJobInput!"),
            };
            AsyncJobStatus? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (AsyncJobStatus)psObject.BaseObject;
                } else {
                    fields = (AsyncJobStatus)this.Field;
                }
            }
            string document = Mutation.StartExportAzureNativeManagedDiskJob(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.StartExportAzureNativeManagedDiskJob");
            var parameters = "($input: StartExportAzureNativeManagedDiskJobInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationStartExportAzureNativeManagedDiskJob" + parameters + "{" + document + "}",
                OperationName = "MutationStartExportAzureNativeManagedDiskJob",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "AsyncJobStatus", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Mutation:
        // startExportAzureSqlDatabaseDbJob(input: StartExportAzureSqlDatabaseDbJobInput!): AsyncJobStatus!
        protected void InvokeMutationStartExportAzureSqlDatabaseDbJob()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "StartExportAzureSqlDatabaseDbJobInput!"),
            };
            AsyncJobStatus? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (AsyncJobStatus)psObject.BaseObject;
                } else {
                    fields = (AsyncJobStatus)this.Field;
                }
            }
            string document = Mutation.StartExportAzureSqlDatabaseDbJob(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.StartExportAzureSqlDatabaseDbJob");
            var parameters = "($input: StartExportAzureSqlDatabaseDbJobInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationStartExportAzureSqlDatabaseDbJob" + parameters + "{" + document + "}",
                OperationName = "MutationStartExportAzureSqlDatabaseDbJob",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "AsyncJobStatus", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Mutation:
        // startExportAzureSqlManagedInstanceDbJob(input: StartExportAzureSqlManagedInstanceDbJobInput!): AsyncJobStatus!
        protected void InvokeMutationStartExportAzureSqlManagedInstanceDbJob()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "StartExportAzureSqlManagedInstanceDbJobInput!"),
            };
            AsyncJobStatus? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (AsyncJobStatus)psObject.BaseObject;
                } else {
                    fields = (AsyncJobStatus)this.Field;
                }
            }
            string document = Mutation.StartExportAzureSqlManagedInstanceDbJob(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.StartExportAzureSqlManagedInstanceDbJob");
            var parameters = "($input: StartExportAzureSqlManagedInstanceDbJobInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationStartExportAzureSqlManagedInstanceDbJob" + parameters + "{" + document + "}",
                OperationName = "MutationStartExportAzureSqlManagedInstanceDbJob",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "AsyncJobStatus", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Mutation:
        // createAzureAccount(input: CreateAzureAccountInput!): CloudAccount!
        protected void InvokeMutationCreateAzureAccount()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateAzureAccountInput!"),
            };
            CloudAccount? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (CloudAccount)psObject.BaseObject;
                } else {
                    fields = (CloudAccount)this.Field;
                }
            }
            string document = Mutation.CreateAzureAccount(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.CreateAzureAccount");
            var parameters = "($input: CreateAzureAccountInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationCreateAzureAccount" + parameters + "{" + document + "}",
                OperationName = "MutationCreateAzureAccount",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "CloudAccount", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Mutation:
        // updateAzureAccount(input: UpdateAzureAccountInput!): CloudAccount!
        protected void InvokeMutationUpdateAzureAccount()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateAzureAccountInput!"),
            };
            CloudAccount? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (CloudAccount)psObject.BaseObject;
                } else {
                    fields = (CloudAccount)this.Field;
                }
            }
            string document = Mutation.UpdateAzureAccount(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.UpdateAzureAccount");
            var parameters = "($input: UpdateAzureAccountInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationUpdateAzureAccount" + parameters + "{" + document + "}",
                OperationName = "MutationUpdateAzureAccount",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "CloudAccount", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Mutation:
        // createAutomaticAzureTargetMapping(input: CreateAutomaticAzureTargetMappingInput!): TargetMapping!
        protected void InvokeMutationCreateAutomaticAzureTargetMapping()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateAutomaticAzureTargetMappingInput!"),
            };
            TargetMapping? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (TargetMapping)psObject.BaseObject;
                } else {
                    fields = (TargetMapping)this.Field;
                }
            }
            string document = Mutation.CreateAutomaticAzureTargetMapping(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.CreateAutomaticAzureTargetMapping");
            var parameters = "($input: CreateAutomaticAzureTargetMappingInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationCreateAutomaticAzureTargetMapping" + parameters + "{" + document + "}",
                OperationName = "MutationCreateAutomaticAzureTargetMapping",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "TargetMapping", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Mutation:
        // createCloudNativeAzureStorageSetting(input: CreateCloudNativeAzureStorageSettingInput!): CreateCloudNativeAzureStorageSettingReply!
        protected void InvokeMutationCreateCloudNativeAzureStorageSetting()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateCloudNativeAzureStorageSettingInput!"),
            };
            CreateCloudNativeAzureStorageSettingReply? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (CreateCloudNativeAzureStorageSettingReply)psObject.BaseObject;
                } else {
                    fields = (CreateCloudNativeAzureStorageSettingReply)this.Field;
                }
            }
            string document = Mutation.CreateCloudNativeAzureStorageSetting(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.CreateCloudNativeAzureStorageSetting");
            var parameters = "($input: CreateCloudNativeAzureStorageSettingInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationCreateCloudNativeAzureStorageSetting" + parameters + "{" + document + "}",
                OperationName = "MutationCreateCloudNativeAzureStorageSetting",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "CreateCloudNativeAzureStorageSettingReply", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Mutation:
        // createCloudNativeRcvAzureStorageSetting(input: CreateCloudNativeRcvAzureStorageSettingInput!): CreateCloudNativeRcvAzureStorageSettingReply!
        protected void InvokeMutationCreateCloudNativeRcvAzureStorageSetting()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateCloudNativeRcvAzureStorageSettingInput!"),
            };
            CreateCloudNativeRcvAzureStorageSettingReply? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (CreateCloudNativeRcvAzureStorageSettingReply)psObject.BaseObject;
                } else {
                    fields = (CreateCloudNativeRcvAzureStorageSettingReply)this.Field;
                }
            }
            string document = Mutation.CreateCloudNativeRcvAzureStorageSetting(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.CreateCloudNativeRcvAzureStorageSetting");
            var parameters = "($input: CreateCloudNativeRcvAzureStorageSettingInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationCreateCloudNativeRcvAzureStorageSetting" + parameters + "{" + document + "}",
                OperationName = "MutationCreateCloudNativeRcvAzureStorageSetting",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "CreateCloudNativeRcvAzureStorageSettingReply", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Mutation:
        // updateAutomaticAzureTargetMapping(input: UpdateAutomaticAzureTargetMappingInput!): TargetMapping!
        protected void InvokeMutationUpdateAutomaticAzureTargetMapping()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateAutomaticAzureTargetMappingInput!"),
            };
            TargetMapping? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (TargetMapping)psObject.BaseObject;
                } else {
                    fields = (TargetMapping)this.Field;
                }
            }
            string document = Mutation.UpdateAutomaticAzureTargetMapping(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.UpdateAutomaticAzureTargetMapping");
            var parameters = "($input: UpdateAutomaticAzureTargetMappingInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationUpdateAutomaticAzureTargetMapping" + parameters + "{" + document + "}",
                OperationName = "MutationUpdateAutomaticAzureTargetMapping",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "TargetMapping", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Mutation:
        // updateCloudNativeAzureStorageSetting(input: UpdateCloudNativeAzureStorageSettingInput!): UpdateCloudNativeAzureStorageSettingReply!
        protected void InvokeMutationUpdateCloudNativeAzureStorageSetting()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateCloudNativeAzureStorageSettingInput!"),
            };
            UpdateCloudNativeAzureStorageSettingReply? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (UpdateCloudNativeAzureStorageSettingReply)psObject.BaseObject;
                } else {
                    fields = (UpdateCloudNativeAzureStorageSettingReply)this.Field;
                }
            }
            string document = Mutation.UpdateCloudNativeAzureStorageSetting(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.UpdateCloudNativeAzureStorageSetting");
            var parameters = "($input: UpdateCloudNativeAzureStorageSettingInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationUpdateCloudNativeAzureStorageSetting" + parameters + "{" + document + "}",
                OperationName = "MutationUpdateCloudNativeAzureStorageSetting",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "UpdateCloudNativeAzureStorageSettingReply", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Mutation:
        // updateCloudNativeRcvAzureStorageSetting(input: UpdateCloudNativeRcvAzureStorageSettingInput!): UpdateCloudNativeRcvAzureStorageSettingReply!
        protected void InvokeMutationUpdateCloudNativeRcvAzureStorageSetting()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateCloudNativeRcvAzureStorageSettingInput!"),
            };
            UpdateCloudNativeRcvAzureStorageSettingReply? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (UpdateCloudNativeRcvAzureStorageSettingReply)psObject.BaseObject;
                } else {
                    fields = (UpdateCloudNativeRcvAzureStorageSettingReply)this.Field;
                }
            }
            string document = Mutation.UpdateCloudNativeRcvAzureStorageSetting(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.UpdateCloudNativeRcvAzureStorageSetting");
            var parameters = "($input: UpdateCloudNativeRcvAzureStorageSettingInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationUpdateCloudNativeRcvAzureStorageSetting" + parameters + "{" + document + "}",
                OperationName = "MutationUpdateCloudNativeRcvAzureStorageSetting",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "UpdateCloudNativeRcvAzureStorageSettingReply", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Mutation:
        // createAzureTarget(input: CreateAzureTargetInput!): Target!
        protected void InvokeMutationCreateAzureTarget()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateAzureTargetInput!"),
            };
            Target? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (Target)psObject.BaseObject;
                } else {
                    fields = (Target)this.Field;
                }
            }
            string document = Mutation.CreateAzureTarget(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.CreateAzureTarget");
            var parameters = "($input: CreateAzureTargetInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationCreateAzureTarget" + parameters + "{" + document + "}",
                OperationName = "MutationCreateAzureTarget",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "Target", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Mutation:
        // updateAzureTarget(input: UpdateAzureTargetInput!): Target!
        protected void InvokeMutationUpdateAzureTarget()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateAzureTargetInput!"),
            };
            Target? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (Target)psObject.BaseObject;
                } else {
                    fields = (Target)this.Field;
                }
            }
            string document = Mutation.UpdateAzureTarget(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.UpdateAzureTarget");
            var parameters = "($input: UpdateAzureTargetInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationUpdateAzureTarget" + parameters + "{" + document + "}",
                OperationName = "MutationUpdateAzureTarget",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "Target", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Mutation:
        // createAzureReaderTarget(input: CreateAzureReaderTargetInput!): Target!
        protected void InvokeMutationCreateAzureReaderTarget()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateAzureReaderTargetInput!"),
            };
            Target? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (Target)psObject.BaseObject;
                } else {
                    fields = (Target)this.Field;
                }
            }
            string document = Mutation.CreateAzureReaderTarget(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.CreateAzureReaderTarget");
            var parameters = "($input: CreateAzureReaderTargetInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationCreateAzureReaderTarget" + parameters + "{" + document + "}",
                OperationName = "MutationCreateAzureReaderTarget",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "Target", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Mutation:
        // startAzureCloudAccountOauth(input: StartAzureCloudAccountOauthInput!): StartAzureCloudAccountOauthReply!
        protected void InvokeMutationStartAzureCloudAccountOauth()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "StartAzureCloudAccountOauthInput!"),
            };
            StartAzureCloudAccountOauthReply? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (StartAzureCloudAccountOauthReply)psObject.BaseObject;
                } else {
                    fields = (StartAzureCloudAccountOauthReply)this.Field;
                }
            }
            string document = Mutation.StartAzureCloudAccountOauth(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.StartAzureCloudAccountOauth");
            var parameters = "($input: StartAzureCloudAccountOauthInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationStartAzureCloudAccountOauth" + parameters + "{" + document + "}",
                OperationName = "MutationStartAzureCloudAccountOauth",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "StartAzureCloudAccountOauthReply", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Mutation:
        // completeAzureCloudAccountOauth(input: CompleteAzureCloudAccountOauthInput!): CompleteAzureCloudAccountOauthReply!
        protected void InvokeMutationCompleteAzureCloudAccountOauth()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CompleteAzureCloudAccountOauthInput!"),
            };
            CompleteAzureCloudAccountOauthReply? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (CompleteAzureCloudAccountOauthReply)psObject.BaseObject;
                } else {
                    fields = (CompleteAzureCloudAccountOauthReply)this.Field;
                }
            }
            string document = Mutation.CompleteAzureCloudAccountOauth(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.CompleteAzureCloudAccountOauth");
            var parameters = "($input: CompleteAzureCloudAccountOauthInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationCompleteAzureCloudAccountOauth" + parameters + "{" + document + "}",
                OperationName = "MutationCompleteAzureCloudAccountOauth",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "CompleteAzureCloudAccountOauthReply", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Mutation:
        // setAzureCloudAccountCustomerAppCredentials(input: SetAzureCloudAccountCustomerAppCredentialsInput!): Boolean!
        protected void InvokeMutationSetAzureCloudAccountCustomerAppCredentials()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "SetAzureCloudAccountCustomerAppCredentialsInput!"),
            };
            System.Boolean? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (System.Boolean)psObject.BaseObject;
                } else {
                    fields = (System.Boolean)this.Field;
                }
            }
            string document = Mutation.SetAzureCloudAccountCustomerAppCredentials(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.SetAzureCloudAccountCustomerAppCredentials");
            var parameters = "($input: SetAzureCloudAccountCustomerAppCredentialsInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationSetAzureCloudAccountCustomerAppCredentials" + parameters + "{" + document + "}",
                OperationName = "MutationSetAzureCloudAccountCustomerAppCredentials",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "System.Boolean", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Mutation:
        // addAzureCloudAccount(input: AddAzureCloudAccountInput!): AddAzureCloudAccountReply!
        protected void InvokeMutationAddAzureCloudAccount()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "AddAzureCloudAccountInput!"),
            };
            AddAzureCloudAccountReply? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (AddAzureCloudAccountReply)psObject.BaseObject;
                } else {
                    fields = (AddAzureCloudAccountReply)this.Field;
                }
            }
            string document = Mutation.AddAzureCloudAccount(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.AddAzureCloudAccount");
            var parameters = "($input: AddAzureCloudAccountInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationAddAzureCloudAccount" + parameters + "{" + document + "}",
                OperationName = "MutationAddAzureCloudAccount",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "AddAzureCloudAccountReply", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Mutation:
        // addAzureCloudAccountWithoutOauth(input: AddAzureCloudAccountWithoutOauthInput!): AddAzureCloudAccountWithoutOauthReply!
        protected void InvokeMutationAddAzureCloudAccountWithoutOauth()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "AddAzureCloudAccountWithoutOauthInput!"),
            };
            AddAzureCloudAccountWithoutOauthReply? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (AddAzureCloudAccountWithoutOauthReply)psObject.BaseObject;
                } else {
                    fields = (AddAzureCloudAccountWithoutOauthReply)this.Field;
                }
            }
            string document = Mutation.AddAzureCloudAccountWithoutOauth(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.AddAzureCloudAccountWithoutOauth");
            var parameters = "($input: AddAzureCloudAccountWithoutOauthInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationAddAzureCloudAccountWithoutOauth" + parameters + "{" + document + "}",
                OperationName = "MutationAddAzureCloudAccountWithoutOauth",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "AddAzureCloudAccountWithoutOauthReply", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Mutation:
        // deleteAzureCloudAccount(input: DeleteAzureCloudAccountInput!): DeleteAzureCloudAccountReply!
        protected void InvokeMutationDeleteAzureCloudAccount()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteAzureCloudAccountInput!"),
            };
            DeleteAzureCloudAccountReply? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (DeleteAzureCloudAccountReply)psObject.BaseObject;
                } else {
                    fields = (DeleteAzureCloudAccountReply)this.Field;
                }
            }
            string document = Mutation.DeleteAzureCloudAccount(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.DeleteAzureCloudAccount");
            var parameters = "($input: DeleteAzureCloudAccountInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationDeleteAzureCloudAccount" + parameters + "{" + document + "}",
                OperationName = "MutationDeleteAzureCloudAccount",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "DeleteAzureCloudAccountReply", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Mutation:
        // deleteAzureCloudAccountWithoutOauth(input: DeleteAzureCloudAccountWithoutOauthInput!): DeleteAzureCloudAccountWithoutOauthReply!
        protected void InvokeMutationDeleteAzureCloudAccountWithoutOauth()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteAzureCloudAccountWithoutOauthInput!"),
            };
            DeleteAzureCloudAccountWithoutOauthReply? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (DeleteAzureCloudAccountWithoutOauthReply)psObject.BaseObject;
                } else {
                    fields = (DeleteAzureCloudAccountWithoutOauthReply)this.Field;
                }
            }
            string document = Mutation.DeleteAzureCloudAccountWithoutOauth(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.DeleteAzureCloudAccountWithoutOauth");
            var parameters = "($input: DeleteAzureCloudAccountWithoutOauthInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationDeleteAzureCloudAccountWithoutOauth" + parameters + "{" + document + "}",
                OperationName = "MutationDeleteAzureCloudAccountWithoutOauth",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "DeleteAzureCloudAccountWithoutOauthReply", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Mutation:
        // upgradeAzureCloudAccount(input: UpgradeAzureCloudAccountInput!): UpgradeAzureCloudAccountReply!
        protected void InvokeMutationUpgradeAzureCloudAccount()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpgradeAzureCloudAccountInput!"),
            };
            UpgradeAzureCloudAccountReply? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (UpgradeAzureCloudAccountReply)psObject.BaseObject;
                } else {
                    fields = (UpgradeAzureCloudAccountReply)this.Field;
                }
            }
            string document = Mutation.UpgradeAzureCloudAccount(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.UpgradeAzureCloudAccount");
            var parameters = "($input: UpgradeAzureCloudAccountInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationUpgradeAzureCloudAccount" + parameters + "{" + document + "}",
                OperationName = "MutationUpgradeAzureCloudAccount",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "UpgradeAzureCloudAccountReply", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Mutation:
        // updateCustomerAppPermissionForAzureSql: Void
        protected void InvokeMutationUpdateCustomerAppPermissionForAzureSql()
        {
            Tuple<string, string>[] argDefs = {
            };
            System.String? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (System.String)psObject.BaseObject;
                } else {
                    fields = (System.String)this.Field;
                }
            }
            string document = Mutation.UpdateCustomerAppPermissionForAzureSql(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.UpdateCustomerAppPermissionForAzureSql");
            var parameters = "";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationUpdateCustomerAppPermissionForAzureSql" + parameters + "{" + document + "}",
                OperationName = "MutationUpdateCustomerAppPermissionForAzureSql",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            var result = this._rbkClient.Invoke(
                request, vars, "System.String", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Mutation:
        // startDisableAzureCloudAccountJob(input: StartDisableAzureCloudAccountJobInput!): BatchAsyncJobStatus!
        protected void InvokeMutationStartDisableAzureCloudAccountJob()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "StartDisableAzureCloudAccountJobInput!"),
            };
            BatchAsyncJobStatus? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (BatchAsyncJobStatus)psObject.BaseObject;
                } else {
                    fields = (BatchAsyncJobStatus)this.Field;
                }
            }
            string document = Mutation.StartDisableAzureCloudAccountJob(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.StartDisableAzureCloudAccountJob");
            var parameters = "($input: StartDisableAzureCloudAccountJobInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationStartDisableAzureCloudAccountJob" + parameters + "{" + document + "}",
                OperationName = "MutationStartDisableAzureCloudAccountJob",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "BatchAsyncJobStatus", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Mutation:
        // updateAzureCloudAccount(input: UpdateAzureCloudAccountInput!): UpdateAzureCloudAccountReply!
        protected void InvokeMutationUpdateAzureCloudAccount()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateAzureCloudAccountInput!"),
            };
            UpdateAzureCloudAccountReply? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (UpdateAzureCloudAccountReply)psObject.BaseObject;
                } else {
                    fields = (UpdateAzureCloudAccountReply)this.Field;
                }
            }
            string document = Mutation.UpdateAzureCloudAccount(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.UpdateAzureCloudAccount");
            var parameters = "($input: UpdateAzureCloudAccountInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationUpdateAzureCloudAccount" + parameters + "{" + document + "}",
                OperationName = "MutationUpdateAzureCloudAccount",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "UpdateAzureCloudAccountReply", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Mutation:
        // mapAzureCloudAccountToPersistentStorageLocation(input: MapAzureCloudAccountToPersistentStorageLocationInput!): MapAzureCloudAccountToPersistentStorageLocationReply!
        protected void InvokeMutationMapAzureCloudAccountToPersistentStorageLocation()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "MapAzureCloudAccountToPersistentStorageLocationInput!"),
            };
            MapAzureCloudAccountToPersistentStorageLocationReply? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (MapAzureCloudAccountToPersistentStorageLocationReply)psObject.BaseObject;
                } else {
                    fields = (MapAzureCloudAccountToPersistentStorageLocationReply)this.Field;
                }
            }
            string document = Mutation.MapAzureCloudAccountToPersistentStorageLocation(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.MapAzureCloudAccountToPersistentStorageLocation");
            var parameters = "($input: MapAzureCloudAccountToPersistentStorageLocationInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationMapAzureCloudAccountToPersistentStorageLocation" + parameters + "{" + document + "}",
                OperationName = "MutationMapAzureCloudAccountToPersistentStorageLocation",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "MapAzureCloudAccountToPersistentStorageLocationReply", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Mutation:
        // addAzureCloudAccountExocomputeConfigurations(input: AddAzureCloudAccountExocomputeConfigurationsInput!): AddAzureCloudAccountExocomputeConfigurationsReply!
        protected void InvokeMutationAddAzureCloudAccountExocomputeConfigurations()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "AddAzureCloudAccountExocomputeConfigurationsInput!"),
            };
            AddAzureCloudAccountExocomputeConfigurationsReply? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (AddAzureCloudAccountExocomputeConfigurationsReply)psObject.BaseObject;
                } else {
                    fields = (AddAzureCloudAccountExocomputeConfigurationsReply)this.Field;
                }
            }
            string document = Mutation.AddAzureCloudAccountExocomputeConfigurations(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.AddAzureCloudAccountExocomputeConfigurations");
            var parameters = "($input: AddAzureCloudAccountExocomputeConfigurationsInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationAddAzureCloudAccountExocomputeConfigurations" + parameters + "{" + document + "}",
                OperationName = "MutationAddAzureCloudAccountExocomputeConfigurations",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "AddAzureCloudAccountExocomputeConfigurationsReply", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Mutation:
        // deleteAzureCloudAccountExocomputeConfigurations(input: DeleteAzureCloudAccountExocomputeConfigurationsInput!): DeleteAzureCloudAccountExocomputeConfigurationsReply!
        protected void InvokeMutationDeleteAzureCloudAccountExocomputeConfigurations()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteAzureCloudAccountExocomputeConfigurationsInput!"),
            };
            DeleteAzureCloudAccountExocomputeConfigurationsReply? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (DeleteAzureCloudAccountExocomputeConfigurationsReply)psObject.BaseObject;
                } else {
                    fields = (DeleteAzureCloudAccountExocomputeConfigurationsReply)this.Field;
                }
            }
            string document = Mutation.DeleteAzureCloudAccountExocomputeConfigurations(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.DeleteAzureCloudAccountExocomputeConfigurations");
            var parameters = "($input: DeleteAzureCloudAccountExocomputeConfigurationsInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationDeleteAzureCloudAccountExocomputeConfigurations" + parameters + "{" + document + "}",
                OperationName = "MutationDeleteAzureCloudAccountExocomputeConfigurations",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "DeleteAzureCloudAccountExocomputeConfigurationsReply", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Mutation:
        // mapAzureCloudAccountExocomputeSubscription(input: MapAzureCloudAccountExocomputeSubscriptionInput!): MapAzureCloudAccountExocomputeSubscriptionReply!
        protected void InvokeMutationMapAzureCloudAccountExocomputeSubscription()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "MapAzureCloudAccountExocomputeSubscriptionInput!"),
            };
            MapAzureCloudAccountExocomputeSubscriptionReply? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (MapAzureCloudAccountExocomputeSubscriptionReply)psObject.BaseObject;
                } else {
                    fields = (MapAzureCloudAccountExocomputeSubscriptionReply)this.Field;
                }
            }
            string document = Mutation.MapAzureCloudAccountExocomputeSubscription(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.MapAzureCloudAccountExocomputeSubscription");
            var parameters = "($input: MapAzureCloudAccountExocomputeSubscriptionInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationMapAzureCloudAccountExocomputeSubscription" + parameters + "{" + document + "}",
                OperationName = "MutationMapAzureCloudAccountExocomputeSubscription",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "MapAzureCloudAccountExocomputeSubscriptionReply", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Mutation:
        // unmapAzureCloudAccountExocomputeSubscription(input: UnmapAzureCloudAccountExocomputeSubscriptionInput!): UnmapAzureCloudAccountExocomputeSubscriptionReply!
        protected void InvokeMutationUnmapAzureCloudAccountExocomputeSubscription()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UnmapAzureCloudAccountExocomputeSubscriptionInput!"),
            };
            UnmapAzureCloudAccountExocomputeSubscriptionReply? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (UnmapAzureCloudAccountExocomputeSubscriptionReply)psObject.BaseObject;
                } else {
                    fields = (UnmapAzureCloudAccountExocomputeSubscriptionReply)this.Field;
                }
            }
            string document = Mutation.UnmapAzureCloudAccountExocomputeSubscription(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.UnmapAzureCloudAccountExocomputeSubscription");
            var parameters = "($input: UnmapAzureCloudAccountExocomputeSubscriptionInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationUnmapAzureCloudAccountExocomputeSubscription" + parameters + "{" + document + "}",
                OperationName = "MutationUnmapAzureCloudAccountExocomputeSubscription",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "UnmapAzureCloudAccountExocomputeSubscriptionReply", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Mutation:
        // upgradeAzureCloudAccountPermissionsWithoutOauth(input: UpgradeAzureCloudAccountPermissionsWithoutOauthInput!): UpgradeAzureCloudAccountPermissionsWithoutOauthReply!
        protected void InvokeMutationUpgradeAzureCloudAccountPermissionsWithoutOauth()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpgradeAzureCloudAccountPermissionsWithoutOauthInput!"),
            };
            UpgradeAzureCloudAccountPermissionsWithoutOauthReply? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (UpgradeAzureCloudAccountPermissionsWithoutOauthReply)psObject.BaseObject;
                } else {
                    fields = (UpgradeAzureCloudAccountPermissionsWithoutOauthReply)this.Field;
                }
            }
            string document = Mutation.UpgradeAzureCloudAccountPermissionsWithoutOauth(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.UpgradeAzureCloudAccountPermissionsWithoutOauth");
            var parameters = "($input: UpgradeAzureCloudAccountPermissionsWithoutOauthInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationUpgradeAzureCloudAccountPermissionsWithoutOauth" + parameters + "{" + document + "}",
                OperationName = "MutationUpgradeAzureCloudAccountPermissionsWithoutOauth",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "UpgradeAzureCloudAccountPermissionsWithoutOauthReply", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Mutation:
        // azureOauthConsentKickoff: AzureOauthConsentKickoffReply!
        protected void InvokeMutationAzureOauthConsentKickoff()
        {
            Tuple<string, string>[] argDefs = {
            };
            AzureOauthConsentKickoffReply? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (AzureOauthConsentKickoffReply)psObject.BaseObject;
                } else {
                    fields = (AzureOauthConsentKickoffReply)this.Field;
                }
            }
            string document = Mutation.AzureOauthConsentKickoff(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.AzureOauthConsentKickoff");
            var parameters = "";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationAzureOauthConsentKickoff" + parameters + "{" + document + "}",
                OperationName = "MutationAzureOauthConsentKickoff",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            var result = this._rbkClient.Invoke(
                request, vars, "AzureOauthConsentKickoffReply", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Mutation:
        // azureOauthConsentComplete(input: AzureOauthConsentCompleteInput!): RequestStatus!
        protected void InvokeMutationAzureOauthConsentComplete()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "AzureOauthConsentCompleteInput!"),
            };
            RequestStatus? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (RequestStatus)psObject.BaseObject;
                } else {
                    fields = (RequestStatus)this.Field;
                }
            }
            string document = Mutation.AzureOauthConsentComplete(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.AzureOauthConsentComplete");
            var parameters = "($input: AzureOauthConsentCompleteInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationAzureOauthConsentComplete" + parameters + "{" + document + "}",
                OperationName = "MutationAzureOauthConsentComplete",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "RequestStatus", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Mutation:
        // createAzureSaasAppAad: CreateAzureSaasAppAadReply!
        protected void InvokeMutationCreateAzureSaasAppAad()
        {
            Tuple<string, string>[] argDefs = {
            };
            CreateAzureSaasAppAadReply? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (CreateAzureSaasAppAadReply)psObject.BaseObject;
                } else {
                    fields = (CreateAzureSaasAppAadReply)this.Field;
                }
            }
            string document = Mutation.CreateAzureSaasAppAad(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.CreateAzureSaasAppAad");
            var parameters = "";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationCreateAzureSaasAppAad" + parameters + "{" + document + "}",
                OperationName = "MutationCreateAzureSaasAppAad",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            var result = this._rbkClient.Invoke(
                request, vars, "CreateAzureSaasAppAadReply", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Mutation:
        // createAzureCluster(input: CreateAzureClusterInput!): CcProvisionJobReply!
        protected void InvokeMutationCreateAzureCluster()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateAzureClusterInput!"),
            };
            CcProvisionJobReply? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (CcProvisionJobReply)psObject.BaseObject;
                } else {
                    fields = (CcProvisionJobReply)this.Field;
                }
            }
            string document = Mutation.CreateAzureCluster(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.CreateAzureCluster");
            var parameters = "($input: CreateAzureClusterInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationCreateAzureCluster" + parameters + "{" + document + "}",
                OperationName = "MutationCreateAzureCluster",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "CcProvisionJobReply", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Mutation:
        // deleteAzureCluster(input: DeleteAzureClusterInput!): CcProvisionJobReply!
        protected void InvokeMutationDeleteAzureCluster()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteAzureClusterInput!"),
            };
            CcProvisionJobReply? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (CcProvisionJobReply)psObject.BaseObject;
                } else {
                    fields = (CcProvisionJobReply)this.Field;
                }
            }
            string document = Mutation.DeleteAzureCluster(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.DeleteAzureCluster");
            var parameters = "($input: DeleteAzureClusterInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationDeleteAzureCluster" + parameters + "{" + document + "}",
                OperationName = "MutationDeleteAzureCluster",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "CcProvisionJobReply", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Mutation:
        // kickoffAzureAdAppSetup(input: KickoffAzureAdAppSetupInput!): KickoffAzureAdAppSetupReply!
        protected void InvokeMutationKickoffAzureAdAppSetup()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "KickoffAzureAdAppSetupInput!"),
            };
            KickoffAzureAdAppSetupReply? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (KickoffAzureAdAppSetupReply)psObject.BaseObject;
                } else {
                    fields = (KickoffAzureAdAppSetupReply)this.Field;
                }
            }
            string document = Mutation.KickoffAzureAdAppSetup(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.KickoffAzureAdAppSetup");
            var parameters = "($input: KickoffAzureAdAppSetupInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationKickoffAzureAdAppSetup" + parameters + "{" + document + "}",
                OperationName = "MutationKickoffAzureAdAppSetup",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "KickoffAzureAdAppSetupReply", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Mutation:
        // completeAzureAdAppSetup(input: CompleteAzureAdAppSetupInput!): CompleteAzureAdAppSetupReply!
        protected void InvokeMutationCompleteAzureAdAppSetup()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CompleteAzureAdAppSetupInput!"),
            };
            CompleteAzureAdAppSetupReply? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (CompleteAzureAdAppSetupReply)psObject.BaseObject;
                } else {
                    fields = (CompleteAzureAdAppSetupReply)this.Field;
                }
            }
            string document = Mutation.CompleteAzureAdAppSetup(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.CompleteAzureAdAppSetup");
            var parameters = "($input: CompleteAzureAdAppSetupInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationCompleteAzureAdAppSetup" + parameters + "{" + document + "}",
                OperationName = "MutationCompleteAzureAdAppSetup",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "CompleteAzureAdAppSetupReply", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Mutation:
        // deleteAzureAdDirectory(workloadFid: UUID!): CreateOnDemandJobReply!
        protected void InvokeMutationDeleteAzureAdDirectory()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("workloadFid", "UUID!"),
            };
            CreateOnDemandJobReply? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (CreateOnDemandJobReply)psObject.BaseObject;
                } else {
                    fields = (CreateOnDemandJobReply)this.Field;
                }
            }
            string document = Mutation.DeleteAzureAdDirectory(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.DeleteAzureAdDirectory");
            var parameters = "($workloadFid: UUID!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationDeleteAzureAdDirectory" + parameters + "{" + document + "}",
                OperationName = "MutationDeleteAzureAdDirectory",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "CreateOnDemandJobReply", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Mutation:
        // backupAzureAdDirectory(input: BackupAzureAdDirectoryInput!): [CreateOnDemandJobReply!]!
        protected void InvokeMutationBackupAzureAdDirectory()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "BackupAzureAdDirectoryInput!"),
            };
            List<CreateOnDemandJobReply>? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (List<CreateOnDemandJobReply>)psObject.BaseObject;
                } else {
                    fields = (List<CreateOnDemandJobReply>)this.Field;
                }
            }
            string document = Mutation.BackupAzureAdDirectory(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.BackupAzureAdDirectory");
            var parameters = "($input: BackupAzureAdDirectoryInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationBackupAzureAdDirectory" + parameters + "{" + document + "}",
                OperationName = "MutationBackupAzureAdDirectory",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "List<CreateOnDemandJobReply>", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Mutation:
        // initiateAzureAdAppUpdate(input: InitiateAzureAdAppUpdateInput!): InitiateAzureAdAppUpdateReply!
        protected void InvokeMutationInitiateAzureAdAppUpdate()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "InitiateAzureAdAppUpdateInput!"),
            };
            InitiateAzureAdAppUpdateReply? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (InitiateAzureAdAppUpdateReply)psObject.BaseObject;
                } else {
                    fields = (InitiateAzureAdAppUpdateReply)this.Field;
                }
            }
            string document = Mutation.InitiateAzureAdAppUpdate(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.InitiateAzureAdAppUpdate");
            var parameters = "($input: InitiateAzureAdAppUpdateInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationInitiateAzureAdAppUpdate" + parameters + "{" + document + "}",
                OperationName = "MutationInitiateAzureAdAppUpdate",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "InitiateAzureAdAppUpdateReply", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Mutation:
        // completeAzureAdAppUpdate(input: CompleteAzureAdAppUpdateInput!): Void
        protected void InvokeMutationCompleteAzureAdAppUpdate()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CompleteAzureAdAppUpdateInput!"),
            };
            System.String? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (System.String)psObject.BaseObject;
                } else {
                    fields = (System.String)this.Field;
                }
            }
            string document = Mutation.CompleteAzureAdAppUpdate(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.CompleteAzureAdAppUpdate");
            var parameters = "($input: CompleteAzureAdAppUpdateInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationCompleteAzureAdAppUpdate" + parameters + "{" + document + "}",
                OperationName = "MutationCompleteAzureAdAppUpdate",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "System.String", this._logger, GetMetricTags());
            WriteObject(result, true);
        }


    } // class Invoke_RscMutateAzure
}