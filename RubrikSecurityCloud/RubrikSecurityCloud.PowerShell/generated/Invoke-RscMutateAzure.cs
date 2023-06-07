// Invoke-RscMutateAzure.cs
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
using RubrikSecurityCloud.Schema.Utils;
using GraphQL;

namespace Rubrik.SecurityCloud.PowerShell.Cmdlets
{
    [Cmdlet(
        "Invoke",
        "RscMutateAzure",
        DefaultParameterSetName = "Createtarget")
    ]
    public class Invoke_RscMutateAzure : RscPSCmdlet
    {
        
        // -------------------------------------------------------------------
        // Startrefreshnativesubscriptionsjob parameter set
        //
        // [GraphQL: startRefreshAzureNativeSubscriptionsJob]
        //
        [Parameter(
            ParameterSetName = "Startrefreshnativesubscriptionsjob",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Start a job to refresh Azure Native subscription for the given subscription IDs. When started, this job will update the Rubrik platform with any changes that have been done on Azure for the respective subscription.
[GraphQL: startRefreshAzureNativeSubscriptionsJob]",
            Position = 0
        )]
        public SwitchParameter Startrefreshnativesubscriptionsjob { get; set; }

        [Parameter(
            ParameterSetName = "Startrefreshnativesubscriptionsjob",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Input for the job to refresh Azure Native subscriptions.
GraphQL argument input: StartRefreshAzureNativeSubscriptionsJobInput!"
        )]
        public StartRefreshAzureNativeSubscriptionsJobInput? Input { get; set; }
        
        // -------------------------------------------------------------------
        // Startrestorenativevirtualmachinejob parameter set
        //
        // [GraphQL: startRestoreAzureNativeVirtualMachineJob]
        //
        [Parameter(
            ParameterSetName = "Startrestorenativevirtualmachinejob",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Start a job to restore Azure Native virtual machine with the selected snapshot. When started, this will replace the original VM with the selected snapshot.
[GraphQL: startRestoreAzureNativeVirtualMachineJob]",
            Position = 0
        )]
        public SwitchParameter Startrestorenativevirtualmachinejob { get; set; }

        
        // -------------------------------------------------------------------
        // Startexportnativevirtualmachinejob parameter set
        //
        // [GraphQL: startExportAzureNativeVirtualMachineJob]
        //
        [Parameter(
            ParameterSetName = "Startexportnativevirtualmachinejob",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Start a job to export the Azure native virtual machine for a specified snapshot to a specified destination.
[GraphQL: startExportAzureNativeVirtualMachineJob]",
            Position = 0
        )]
        public SwitchParameter Startexportnativevirtualmachinejob { get; set; }

        
        // -------------------------------------------------------------------
        // Excludenativemanageddisksfromsnapshot parameter set
        //
        // [GraphQL: excludeAzureNativeManagedDisksFromSnapshot]
        //
        [Parameter(
            ParameterSetName = "Excludenativemanageddisksfromsnapshot",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Exclude the Managed Disks from snapshots, for the specified virtual machines.
[GraphQL: excludeAzureNativeManagedDisksFromSnapshot]",
            Position = 0
        )]
        public SwitchParameter Excludenativemanageddisksfromsnapshot { get; set; }

        
        // -------------------------------------------------------------------
        // Startcreatenativevirtualmachinesnapshotsjob parameter set
        //
        // [GraphQL: startCreateAzureNativeVirtualMachineSnapshotsJob]
        //
        [Parameter(
            ParameterSetName = "Startcreatenativevirtualmachinesnapshotsjob",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Start a job to create a snapshot for the Azure Native virtual machine identified by the IDs. When started, this will start taking an on-demand snapshot of the selected VMs as per the SLA Policy assigned to the respective VMs.
[GraphQL: startCreateAzureNativeVirtualMachineSnapshotsJob]",
            Position = 0
        )]
        public SwitchParameter Startcreatenativevirtualmachinesnapshotsjob { get; set; }

        
        // -------------------------------------------------------------------
        // Startdisablenativesubscriptionprotectionjob parameter set
        //
        // [GraphQL: startDisableAzureNativeSubscriptionProtectionJob]
        //
        [Parameter(
            ParameterSetName = "Startdisablenativesubscriptionprotectionjob",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Start a job to disable protection for a specified Azure subscription.
[GraphQL: startDisableAzureNativeSubscriptionProtectionJob]",
            Position = 0
        )]
        public SwitchParameter Startdisablenativesubscriptionprotectionjob { get; set; }

        
        // -------------------------------------------------------------------
        // Startcreatenativemanageddisksnapshotsjob parameter set
        //
        // [GraphQL: startCreateAzureNativeManagedDiskSnapshotsJob]
        //
        [Parameter(
            ParameterSetName = "Startcreatenativemanageddisksnapshotsjob",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Start a job to create snapshots of the Azure Native Managed Disks identified by the given IDs. When started, this will start taking an on-demand snapshot of the selected disks as per the SLA Policy assigned to the respective disks.
[GraphQL: startCreateAzureNativeManagedDiskSnapshotsJob]",
            Position = 0
        )]
        public SwitchParameter Startcreatenativemanageddisksnapshotsjob { get; set; }

        
        // -------------------------------------------------------------------
        // Startexportnativemanageddiskjob parameter set
        //
        // [GraphQL: startExportAzureNativeManagedDiskJob]
        //
        [Parameter(
            ParameterSetName = "Startexportnativemanageddiskjob",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Start a job to export the specified Azure Native Managed Disks to the desired destination.
[GraphQL: startExportAzureNativeManagedDiskJob]",
            Position = 0
        )]
        public SwitchParameter Startexportnativemanageddiskjob { get; set; }

        
        // -------------------------------------------------------------------
        // Startexportsqldatabasedbjob parameter set
        //
        // [GraphQL: startExportAzureSqlDatabaseDbJob]
        //
        [Parameter(
            ParameterSetName = "Startexportsqldatabasedbjob",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Start a job to export Azure SQL Database. The job creates a new Azure SQL Database with the same properties as that of the instance that is exported.
[GraphQL: startExportAzureSqlDatabaseDbJob]",
            Position = 0
        )]
        public SwitchParameter Startexportsqldatabasedbjob { get; set; }

        
        // -------------------------------------------------------------------
        // Startexportsqlmanagedinstancedbjob parameter set
        //
        // [GraphQL: startExportAzureSqlManagedInstanceDbJob]
        //
        [Parameter(
            ParameterSetName = "Startexportsqlmanagedinstancedbjob",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Start a job to export Azure SQL Managed Instance database. The job creates a new Azure SQL Managed Instance database with the same properties as that of the instance that is exported.
[GraphQL: startExportAzureSqlManagedInstanceDbJob]",
            Position = 0
        )]
        public SwitchParameter Startexportsqlmanagedinstancedbjob { get; set; }

        
        // -------------------------------------------------------------------
        // Createaccount parameter set
        //
        // [GraphQL: createAzureAccount]
        //
        [Parameter(
            ParameterSetName = "Createaccount",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"
[GraphQL: createAzureAccount]",
            Position = 0
        )]
        public SwitchParameter Createaccount { get; set; }

        
        // -------------------------------------------------------------------
        // Updateaccount parameter set
        //
        // [GraphQL: updateAzureAccount]
        //
        [Parameter(
            ParameterSetName = "Updateaccount",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"
[GraphQL: updateAzureAccount]",
            Position = 0
        )]
        public SwitchParameter Updateaccount { get; set; }

        
        // -------------------------------------------------------------------
        // Createautomatictargetmapping parameter set
        //
        // [GraphQL: createAutomaticAzureTargetMapping]
        //
        [Parameter(
            ParameterSetName = "Createautomatictargetmapping",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"
[GraphQL: createAutomaticAzureTargetMapping]",
            Position = 0
        )]
        public SwitchParameter Createautomatictargetmapping { get; set; }

        
        // -------------------------------------------------------------------
        // Createcloudnativestoragesetting parameter set
        //
        // [GraphQL: createCloudNativeAzureStorageSetting]
        //
        [Parameter(
            ParameterSetName = "Createcloudnativestoragesetting",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Creates Storage Settings for the archival of azure cloud native protected objects
[GraphQL: createCloudNativeAzureStorageSetting]",
            Position = 0
        )]
        public SwitchParameter Createcloudnativestoragesetting { get; set; }

        
        // -------------------------------------------------------------------
        // Createcloudnativercvstoragesetting parameter set
        //
        // [GraphQL: createCloudNativeRcvAzureStorageSetting]
        //
        [Parameter(
            ParameterSetName = "Createcloudnativercvstoragesetting",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create Rubrik Cloud Vault storage settings for archiving azure cloud native protected objects.
[GraphQL: createCloudNativeRcvAzureStorageSetting]",
            Position = 0
        )]
        public SwitchParameter Createcloudnativercvstoragesetting { get; set; }

        
        // -------------------------------------------------------------------
        // Updateautomatictargetmapping parameter set
        //
        // [GraphQL: updateAutomaticAzureTargetMapping]
        //
        [Parameter(
            ParameterSetName = "Updateautomatictargetmapping",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"
[GraphQL: updateAutomaticAzureTargetMapping]",
            Position = 0
        )]
        public SwitchParameter Updateautomatictargetmapping { get; set; }

        
        // -------------------------------------------------------------------
        // Updatecloudnativestoragesetting parameter set
        //
        // [GraphQL: updateCloudNativeAzureStorageSetting]
        //
        [Parameter(
            ParameterSetName = "Updatecloudnativestoragesetting",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"
[GraphQL: updateCloudNativeAzureStorageSetting]",
            Position = 0
        )]
        public SwitchParameter Updatecloudnativestoragesetting { get; set; }

        
        // -------------------------------------------------------------------
        // Updatecloudnativercvstoragesetting parameter set
        //
        // [GraphQL: updateCloudNativeRcvAzureStorageSetting]
        //
        [Parameter(
            ParameterSetName = "Updatecloudnativercvstoragesetting",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Updates an existing Rubrik Cloud Vault Storage Settings for the archival of azure cloud native protected objects.
[GraphQL: updateCloudNativeRcvAzureStorageSetting]",
            Position = 0
        )]
        public SwitchParameter Updatecloudnativercvstoragesetting { get; set; }

        
        // -------------------------------------------------------------------
        // Createtarget parameter set
        //
        // [GraphQL: createAzureTarget]
        //
        [Parameter(
            ParameterSetName = "Createtarget",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Creates an Azure archival target on the Rubrik cluster.
[GraphQL: createAzureTarget]",
            Position = 0
        )]
        public SwitchParameter Createtarget { get; set; }

        
        // -------------------------------------------------------------------
        // Updatetarget parameter set
        //
        // [GraphQL: updateAzureTarget]
        //
        [Parameter(
            ParameterSetName = "Updatetarget",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"
[GraphQL: updateAzureTarget]",
            Position = 0
        )]
        public SwitchParameter Updatetarget { get; set; }

        
        // -------------------------------------------------------------------
        // Createreadertarget parameter set
        //
        // [GraphQL: createAzureReaderTarget]
        //
        [Parameter(
            ParameterSetName = "Createreadertarget",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Creates reader type for Azure archival location on a CDM cluster.
[GraphQL: createAzureReaderTarget]",
            Position = 0
        )]
        public SwitchParameter Createreadertarget { get; set; }

        
        // -------------------------------------------------------------------
        // Startcloudaccountoauth parameter set
        //
        // [GraphQL: startAzureCloudAccountOauth]
        //
        [Parameter(
            ParameterSetName = "Startcloudaccountoauth",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Initiates a session before doing Azure OAuth flow. If a custom app is configured for the tenant, the client ID of the custom app is returned. Otherwise, the client ID of the default app is returned.
[GraphQL: startAzureCloudAccountOauth]",
            Position = 0
        )]
        public SwitchParameter Startcloudaccountoauth { get; set; }

        
        // -------------------------------------------------------------------
        // Completecloudaccountoauth parameter set
        //
        // [GraphQL: completeAzureCloudAccountOauth]
        //
        [Parameter(
            ParameterSetName = "Completecloudaccountoauth",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Complete the Azure OAuth flow and pass the authorization code.
[GraphQL: completeAzureCloudAccountOauth]",
            Position = 0
        )]
        public SwitchParameter Completecloudaccountoauth { get; set; }

        
        // -------------------------------------------------------------------
        // Setcloudaccountcustomerappcredential parameter set
        //
        // [GraphQL: setAzureCloudAccountCustomerAppCredentials]
        //
        [Parameter(
            ParameterSetName = "Setcloudaccountcustomerappcredential",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Set credentials for the customer application, for the tenant domain name.
[GraphQL: setAzureCloudAccountCustomerAppCredentials]",
            Position = 0
        )]
        public SwitchParameter Setcloudaccountcustomerappcredential { get; set; }

        
        // -------------------------------------------------------------------
        // Addcloudaccount parameter set
        //
        // [GraphQL: addAzureCloudAccount]
        //
        [Parameter(
            ParameterSetName = "Addcloudaccount",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Add the Azure Subscriptions cloud account for the given feature.
[GraphQL: addAzureCloudAccount]",
            Position = 0
        )]
        public SwitchParameter Addcloudaccount { get; set; }

        
        // -------------------------------------------------------------------
        // Addcloudaccountwithoutoauth parameter set
        //
        // [GraphQL: addAzureCloudAccountWithoutOauth]
        //
        [Parameter(
            ParameterSetName = "Addcloudaccountwithoutoauth",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Add the Azure Subscription cloud account for the given feature without OAuth.
[GraphQL: addAzureCloudAccountWithoutOauth]",
            Position = 0
        )]
        public SwitchParameter Addcloudaccountwithoutoauth { get; set; }

        
        // -------------------------------------------------------------------
        // Deletecloudaccount parameter set
        //
        // [GraphQL: deleteAzureCloudAccount]
        //
        [Parameter(
            ParameterSetName = "Deletecloudaccount",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Delete the Azure Subscriptions cloud account for the given feature.
[GraphQL: deleteAzureCloudAccount]",
            Position = 0
        )]
        public SwitchParameter Deletecloudaccount { get; set; }

        
        // -------------------------------------------------------------------
        // Deletecloudaccountwithoutoauth parameter set
        //
        // [GraphQL: deleteAzureCloudAccountWithoutOauth]
        //
        [Parameter(
            ParameterSetName = "Deletecloudaccountwithoutoauth",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Delete the Azure Subscriptions cloud account for the given feature without OAuth.
[GraphQL: deleteAzureCloudAccountWithoutOauth]",
            Position = 0
        )]
        public SwitchParameter Deletecloudaccountwithoutoauth { get; set; }

        
        // -------------------------------------------------------------------
        // Upgradecloudaccount parameter set
        //
        // [GraphQL: upgradeAzureCloudAccount]
        //
        [Parameter(
            ParameterSetName = "Upgradecloudaccount",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Update permissions of the Azure Subscriptions cloud account for given feature.
[GraphQL: upgradeAzureCloudAccount]",
            Position = 0
        )]
        public SwitchParameter Upgradecloudaccount { get; set; }

        
        // -------------------------------------------------------------------
        // Updatecustomerapppermissionforsql parameter set
        //
        // [GraphQL: updateCustomerAppPermissionForAzureSql]
        //
        [Parameter(
            ParameterSetName = "Updatecustomerapppermissionforsql",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Updates the Azure app for the specified account in an idempotent manner to support Azure SQL Database and  Managed Instance Database authentication.
[GraphQL: updateCustomerAppPermissionForAzureSql]",
            Position = 0
        )]
        public SwitchParameter Updatecustomerapppermissionforsql { get; set; }

        
        // -------------------------------------------------------------------
        // Startdisablecloudaccountjob parameter set
        //
        // [GraphQL: startDisableAzureCloudAccountJob]
        //
        [Parameter(
            ParameterSetName = "Startdisablecloudaccountjob",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Start on-demand jobs to disable the feature for the given Azure Cloud Accounts. When completed, the status of cloud account feature will change to Disabled and the feature will become eligible to be deleted.
[GraphQL: startDisableAzureCloudAccountJob]",
            Position = 0
        )]
        public SwitchParameter Startdisablecloudaccountjob { get; set; }

        
        // -------------------------------------------------------------------
        // Updatecloudaccount parameter set
        //
        // [GraphQL: updateAzureCloudAccount]
        //
        [Parameter(
            ParameterSetName = "Updatecloudaccount",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Update names of the Azure Subscriptions cloud account and regions for the given feature.
[GraphQL: updateAzureCloudAccount]",
            Position = 0
        )]
        public SwitchParameter Updatecloudaccount { get; set; }

        
        // -------------------------------------------------------------------
        // Mapcloudaccounttopersistentstoragelocation parameter set
        //
        // [GraphQL: mapAzureCloudAccountToPersistentStorageLocation]
        //
        [Parameter(
            ParameterSetName = "Mapcloudaccounttopersistentstoragelocation",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Map Azure cloud accounts to a persistent storage location.
[GraphQL: mapAzureCloudAccountToPersistentStorageLocation]",
            Position = 0
        )]
        public SwitchParameter Mapcloudaccounttopersistentstoragelocation { get; set; }

        
        // -------------------------------------------------------------------
        // Addcloudaccountexocomputeconfiguration parameter set
        //
        // [GraphQL: addAzureCloudAccountExocomputeConfigurations]
        //
        [Parameter(
            ParameterSetName = "Addcloudaccountexocomputeconfiguration",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Add Exocompute configurations for an Azure Cloud Account.
[GraphQL: addAzureCloudAccountExocomputeConfigurations]",
            Position = 0
        )]
        public SwitchParameter Addcloudaccountexocomputeconfiguration { get; set; }

        
        // -------------------------------------------------------------------
        // Deletecloudaccountexocomputeconfiguration parameter set
        //
        // [GraphQL: deleteAzureCloudAccountExocomputeConfigurations]
        //
        [Parameter(
            ParameterSetName = "Deletecloudaccountexocomputeconfiguration",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Delete Exocompute configurations for an Azure Cloud Account.
[GraphQL: deleteAzureCloudAccountExocomputeConfigurations]",
            Position = 0
        )]
        public SwitchParameter Deletecloudaccountexocomputeconfiguration { get; set; }

        
        // -------------------------------------------------------------------
        // Mapcloudaccountexocomputesubscription parameter set
        //
        // [GraphQL: mapAzureCloudAccountExocomputeSubscription]
        //
        [Parameter(
            ParameterSetName = "Mapcloudaccountexocomputesubscription",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Map Azure cloud accounts to an Exocompute subscription.
[GraphQL: mapAzureCloudAccountExocomputeSubscription]",
            Position = 0
        )]
        public SwitchParameter Mapcloudaccountexocomputesubscription { get; set; }

        
        // -------------------------------------------------------------------
        // Unmapcloudaccountexocomputesubscription parameter set
        //
        // [GraphQL: unmapAzureCloudAccountExocomputeSubscription]
        //
        [Parameter(
            ParameterSetName = "Unmapcloudaccountexocomputesubscription",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Unmap Azure cloud accounts from the mapped Exocompute subscription.
[GraphQL: unmapAzureCloudAccountExocomputeSubscription]",
            Position = 0
        )]
        public SwitchParameter Unmapcloudaccountexocomputesubscription { get; set; }

        
        // -------------------------------------------------------------------
        // Upgradecloudaccountpermissionswithoutoauth parameter set
        //
        // [GraphQL: upgradeAzureCloudAccountPermissionsWithoutOauth]
        //
        [Parameter(
            ParameterSetName = "Upgradecloudaccountpermissionswithoutoauth",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Set Azure Cloud Account feature status to Connected from Update Permissions state without any permission validation. It should be used by caution from cloud accounts which have been set up without using OAuth, only after adding the latest permissions that are required.
[GraphQL: upgradeAzureCloudAccountPermissionsWithoutOauth]",
            Position = 0
        )]
        public SwitchParameter Upgradecloudaccountpermissionswithoutoauth { get; set; }

        
        // -------------------------------------------------------------------
        // Oauthconsentkickoff parameter set
        //
        // [GraphQL: azureOauthConsentKickoff]
        //
        [Parameter(
            ParameterSetName = "Oauthconsentkickoff",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Kicks off an OAuth consent flow for Azure resource access.
[GraphQL: azureOauthConsentKickoff]",
            Position = 0
        )]
        public SwitchParameter Oauthconsentkickoff { get; set; }

        
        // -------------------------------------------------------------------
        // Oauthconsentcomplete parameter set
        //
        // [GraphQL: azureOauthConsentComplete]
        //
        [Parameter(
            ParameterSetName = "Oauthconsentcomplete",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Completes an OAuth consent flow for Azure resource access.
[GraphQL: azureOauthConsentComplete]",
            Position = 0
        )]
        public SwitchParameter Oauthconsentcomplete { get; set; }

        
        // -------------------------------------------------------------------
        // Createsaasappaad parameter set
        //
        // [GraphQL: createAzureSaasAppAad]
        //
        [Parameter(
            ParameterSetName = "Createsaasappaad",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create or get an Azure AAD application.
[GraphQL: createAzureSaasAppAad]",
            Position = 0
        )]
        public SwitchParameter Createsaasappaad { get; set; }

        
        // -------------------------------------------------------------------
        // Createcluster parameter set
        //
        // [GraphQL: createAzureCluster]
        //
        [Parameter(
            ParameterSetName = "Createcluster",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a Rubrik Cloud Cluster on Azure.
[GraphQL: createAzureCluster]",
            Position = 0
        )]
        public SwitchParameter Createcluster { get; set; }

        
        // -------------------------------------------------------------------
        // Deletecluster parameter set
        //
        // [GraphQL: deleteAzureCluster]
        //
        [Parameter(
            ParameterSetName = "Deletecluster",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Delete a Rubrik Cloud Cluster on Azure.
[GraphQL: deleteAzureCluster]",
            Position = 0
        )]
        public SwitchParameter Deletecluster { get; set; }

        
        // -------------------------------------------------------------------
        // Kickoffadappsetup parameter set
        //
        // [GraphQL: kickoffAzureAdAppSetup]
        //
        [Parameter(
            ParameterSetName = "Kickoffadappsetup",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Initiates the Azure AD app creation flow.
[GraphQL: kickoffAzureAdAppSetup]",
            Position = 0
        )]
        public SwitchParameter Kickoffadappsetup { get; set; }

        
        // -------------------------------------------------------------------
        // Completeadappsetup parameter set
        //
        // [GraphQL: completeAzureAdAppSetup]
        //
        [Parameter(
            ParameterSetName = "Completeadappsetup",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Completes the creation flow for an Azure AD app.
[GraphQL: completeAzureAdAppSetup]",
            Position = 0
        )]
        public SwitchParameter Completeadappsetup { get; set; }

        
        // -------------------------------------------------------------------
        // Deleteaddirectory parameter set
        //
        // [GraphQL: deleteAzureAdDirectory]
        //
        [Parameter(
            ParameterSetName = "Deleteaddirectory",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Deletes an Azure AD directory.
[GraphQL: deleteAzureAdDirectory]",
            Position = 0
        )]
        public SwitchParameter Deleteaddirectory { get; set; }

        [Parameter(
            ParameterSetName = "Deleteaddirectory",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"The FID of the workload.
GraphQL argument workloadFid: UUID!"
        )]
        public System.String? WorkloadFid { get; set; }
        
        // -------------------------------------------------------------------
        // Backupaddirectory parameter set
        //
        // [GraphQL: backupAzureAdDirectory]
        //
        [Parameter(
            ParameterSetName = "Backupaddirectory",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Backs up the Azure AD directory.
[GraphQL: backupAzureAdDirectory]",
            Position = 0
        )]
        public SwitchParameter Backupaddirectory { get; set; }


        protected override void ProcessRecord()
        {
            try
            {
                switch(Op)
                {
                    case "Startrefreshnativesubscriptionsjob":
                        this.ProcessRecord_Startrefreshnativesubscriptionsjob();
                        break;
                    case "Startrestorenativevirtualmachinejob":
                        this.ProcessRecord_Startrestorenativevirtualmachinejob();
                        break;
                    case "Startexportnativevirtualmachinejob":
                        this.ProcessRecord_Startexportnativevirtualmachinejob();
                        break;
                    case "Excludenativemanageddisksfromsnapshot":
                        this.ProcessRecord_Excludenativemanageddisksfromsnapshot();
                        break;
                    case "Startcreatenativevirtualmachinesnapshotsjob":
                        this.ProcessRecord_Startcreatenativevirtualmachinesnapshotsjob();
                        break;
                    case "Startdisablenativesubscriptionprotectionjob":
                        this.ProcessRecord_Startdisablenativesubscriptionprotectionjob();
                        break;
                    case "Startcreatenativemanageddisksnapshotsjob":
                        this.ProcessRecord_Startcreatenativemanageddisksnapshotsjob();
                        break;
                    case "Startexportnativemanageddiskjob":
                        this.ProcessRecord_Startexportnativemanageddiskjob();
                        break;
                    case "Startexportsqldatabasedbjob":
                        this.ProcessRecord_Startexportsqldatabasedbjob();
                        break;
                    case "Startexportsqlmanagedinstancedbjob":
                        this.ProcessRecord_Startexportsqlmanagedinstancedbjob();
                        break;
                    case "Createaccount":
                        this.ProcessRecord_Createaccount();
                        break;
                    case "Updateaccount":
                        this.ProcessRecord_Updateaccount();
                        break;
                    case "Createautomatictargetmapping":
                        this.ProcessRecord_Createautomatictargetmapping();
                        break;
                    case "Createcloudnativestoragesetting":
                        this.ProcessRecord_Createcloudnativestoragesetting();
                        break;
                    case "Createcloudnativercvstoragesetting":
                        this.ProcessRecord_Createcloudnativercvstoragesetting();
                        break;
                    case "Updateautomatictargetmapping":
                        this.ProcessRecord_Updateautomatictargetmapping();
                        break;
                    case "Updatecloudnativestoragesetting":
                        this.ProcessRecord_Updatecloudnativestoragesetting();
                        break;
                    case "Updatecloudnativercvstoragesetting":
                        this.ProcessRecord_Updatecloudnativercvstoragesetting();
                        break;
                    case "Createtarget":
                        this.ProcessRecord_Createtarget();
                        break;
                    case "Updatetarget":
                        this.ProcessRecord_Updatetarget();
                        break;
                    case "Createreadertarget":
                        this.ProcessRecord_Createreadertarget();
                        break;
                    case "Startcloudaccountoauth":
                        this.ProcessRecord_Startcloudaccountoauth();
                        break;
                    case "Completecloudaccountoauth":
                        this.ProcessRecord_Completecloudaccountoauth();
                        break;
                    case "Setcloudaccountcustomerappcredential":
                        this.ProcessRecord_Setcloudaccountcustomerappcredential();
                        break;
                    case "Addcloudaccount":
                        this.ProcessRecord_Addcloudaccount();
                        break;
                    case "Addcloudaccountwithoutoauth":
                        this.ProcessRecord_Addcloudaccountwithoutoauth();
                        break;
                    case "Deletecloudaccount":
                        this.ProcessRecord_Deletecloudaccount();
                        break;
                    case "Deletecloudaccountwithoutoauth":
                        this.ProcessRecord_Deletecloudaccountwithoutoauth();
                        break;
                    case "Upgradecloudaccount":
                        this.ProcessRecord_Upgradecloudaccount();
                        break;
                    case "Updatecustomerapppermissionforsql":
                        this.ProcessRecord_Updatecustomerapppermissionforsql();
                        break;
                    case "Startdisablecloudaccountjob":
                        this.ProcessRecord_Startdisablecloudaccountjob();
                        break;
                    case "Updatecloudaccount":
                        this.ProcessRecord_Updatecloudaccount();
                        break;
                    case "Mapcloudaccounttopersistentstoragelocation":
                        this.ProcessRecord_Mapcloudaccounttopersistentstoragelocation();
                        break;
                    case "Addcloudaccountexocomputeconfiguration":
                        this.ProcessRecord_Addcloudaccountexocomputeconfiguration();
                        break;
                    case "Deletecloudaccountexocomputeconfiguration":
                        this.ProcessRecord_Deletecloudaccountexocomputeconfiguration();
                        break;
                    case "Mapcloudaccountexocomputesubscription":
                        this.ProcessRecord_Mapcloudaccountexocomputesubscription();
                        break;
                    case "Unmapcloudaccountexocomputesubscription":
                        this.ProcessRecord_Unmapcloudaccountexocomputesubscription();
                        break;
                    case "Upgradecloudaccountpermissionswithoutoauth":
                        this.ProcessRecord_Upgradecloudaccountpermissionswithoutoauth();
                        break;
                    case "Oauthconsentkickoff":
                        this.ProcessRecord_Oauthconsentkickoff();
                        break;
                    case "Oauthconsentcomplete":
                        this.ProcessRecord_Oauthconsentcomplete();
                        break;
                    case "Createsaasappaad":
                        this.ProcessRecord_Createsaasappaad();
                        break;
                    case "Createcluster":
                        this.ProcessRecord_Createcluster();
                        break;
                    case "Deletecluster":
                        this.ProcessRecord_Deletecluster();
                        break;
                    case "Kickoffadappsetup":
                        this.ProcessRecord_Kickoffadappsetup();
                        break;
                    case "Completeadappsetup":
                        this.ProcessRecord_Completeadappsetup();
                        break;
                    case "Deleteaddirectory":
                        this.ProcessRecord_Deleteaddirectory();
                        break;
                    case "Backupaddirectory":
                        this.ProcessRecord_Backupaddirectory();
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
                    "Invoke-RscMutateAzure",
                    ErrorCategory.InvalidOperation,
                    null);
                ThrowTerminatingError(error);
           }
        }

        // This parameter set invokes a single graphql operation:
        // startRefreshAzureNativeSubscriptionsJob.
        protected void ProcessRecord_Startrefreshnativesubscriptionsjob()
        {
            this._logger.name += " -Startrefreshnativesubscriptionsjob";
            // Invoke graphql operation startRefreshAzureNativeSubscriptionsJob
            InvokeMutationStartRefreshAzureNativeSubscriptionsJob();
        }

        // This parameter set invokes a single graphql operation:
        // startRestoreAzureNativeVirtualMachineJob.
        protected void ProcessRecord_Startrestorenativevirtualmachinejob()
        {
            this._logger.name += " -Startrestorenativevirtualmachinejob";
            // Invoke graphql operation startRestoreAzureNativeVirtualMachineJob
            InvokeMutationStartRestoreAzureNativeVirtualMachineJob();
        }

        // This parameter set invokes a single graphql operation:
        // startExportAzureNativeVirtualMachineJob.
        protected void ProcessRecord_Startexportnativevirtualmachinejob()
        {
            this._logger.name += " -Startexportnativevirtualmachinejob";
            // Invoke graphql operation startExportAzureNativeVirtualMachineJob
            InvokeMutationStartExportAzureNativeVirtualMachineJob();
        }

        // This parameter set invokes a single graphql operation:
        // excludeAzureNativeManagedDisksFromSnapshot.
        protected void ProcessRecord_Excludenativemanageddisksfromsnapshot()
        {
            this._logger.name += " -Excludenativemanageddisksfromsnapshot";
            // Invoke graphql operation excludeAzureNativeManagedDisksFromSnapshot
            InvokeMutationExcludeAzureNativeManagedDisksFromSnapshot();
        }

        // This parameter set invokes a single graphql operation:
        // startCreateAzureNativeVirtualMachineSnapshotsJob.
        protected void ProcessRecord_Startcreatenativevirtualmachinesnapshotsjob()
        {
            this._logger.name += " -Startcreatenativevirtualmachinesnapshotsjob";
            // Invoke graphql operation startCreateAzureNativeVirtualMachineSnapshotsJob
            InvokeMutationStartCreateAzureNativeVirtualMachineSnapshotsJob();
        }

        // This parameter set invokes a single graphql operation:
        // startDisableAzureNativeSubscriptionProtectionJob.
        protected void ProcessRecord_Startdisablenativesubscriptionprotectionjob()
        {
            this._logger.name += " -Startdisablenativesubscriptionprotectionjob";
            // Invoke graphql operation startDisableAzureNativeSubscriptionProtectionJob
            InvokeMutationStartDisableAzureNativeSubscriptionProtectionJob();
        }

        // This parameter set invokes a single graphql operation:
        // startCreateAzureNativeManagedDiskSnapshotsJob.
        protected void ProcessRecord_Startcreatenativemanageddisksnapshotsjob()
        {
            this._logger.name += " -Startcreatenativemanageddisksnapshotsjob";
            // Invoke graphql operation startCreateAzureNativeManagedDiskSnapshotsJob
            InvokeMutationStartCreateAzureNativeManagedDiskSnapshotsJob();
        }

        // This parameter set invokes a single graphql operation:
        // startExportAzureNativeManagedDiskJob.
        protected void ProcessRecord_Startexportnativemanageddiskjob()
        {
            this._logger.name += " -Startexportnativemanageddiskjob";
            // Invoke graphql operation startExportAzureNativeManagedDiskJob
            InvokeMutationStartExportAzureNativeManagedDiskJob();
        }

        // This parameter set invokes a single graphql operation:
        // startExportAzureSqlDatabaseDbJob.
        protected void ProcessRecord_Startexportsqldatabasedbjob()
        {
            this._logger.name += " -Startexportsqldatabasedbjob";
            // Invoke graphql operation startExportAzureSqlDatabaseDbJob
            InvokeMutationStartExportAzureSqlDatabaseDbJob();
        }

        // This parameter set invokes a single graphql operation:
        // startExportAzureSqlManagedInstanceDbJob.
        protected void ProcessRecord_Startexportsqlmanagedinstancedbjob()
        {
            this._logger.name += " -Startexportsqlmanagedinstancedbjob";
            // Invoke graphql operation startExportAzureSqlManagedInstanceDbJob
            InvokeMutationStartExportAzureSqlManagedInstanceDbJob();
        }

        // This parameter set invokes a single graphql operation:
        // createAzureAccount.
        protected void ProcessRecord_Createaccount()
        {
            this._logger.name += " -Createaccount";
            // Invoke graphql operation createAzureAccount
            InvokeMutationCreateAzureAccount();
        }

        // This parameter set invokes a single graphql operation:
        // updateAzureAccount.
        protected void ProcessRecord_Updateaccount()
        {
            this._logger.name += " -Updateaccount";
            // Invoke graphql operation updateAzureAccount
            InvokeMutationUpdateAzureAccount();
        }

        // This parameter set invokes a single graphql operation:
        // createAutomaticAzureTargetMapping.
        protected void ProcessRecord_Createautomatictargetmapping()
        {
            this._logger.name += " -Createautomatictargetmapping";
            // Invoke graphql operation createAutomaticAzureTargetMapping
            InvokeMutationCreateAutomaticAzureTargetMapping();
        }

        // This parameter set invokes a single graphql operation:
        // createCloudNativeAzureStorageSetting.
        protected void ProcessRecord_Createcloudnativestoragesetting()
        {
            this._logger.name += " -Createcloudnativestoragesetting";
            // Invoke graphql operation createCloudNativeAzureStorageSetting
            InvokeMutationCreateCloudNativeAzureStorageSetting();
        }

        // This parameter set invokes a single graphql operation:
        // createCloudNativeRcvAzureStorageSetting.
        protected void ProcessRecord_Createcloudnativercvstoragesetting()
        {
            this._logger.name += " -Createcloudnativercvstoragesetting";
            // Invoke graphql operation createCloudNativeRcvAzureStorageSetting
            InvokeMutationCreateCloudNativeRcvAzureStorageSetting();
        }

        // This parameter set invokes a single graphql operation:
        // updateAutomaticAzureTargetMapping.
        protected void ProcessRecord_Updateautomatictargetmapping()
        {
            this._logger.name += " -Updateautomatictargetmapping";
            // Invoke graphql operation updateAutomaticAzureTargetMapping
            InvokeMutationUpdateAutomaticAzureTargetMapping();
        }

        // This parameter set invokes a single graphql operation:
        // updateCloudNativeAzureStorageSetting.
        protected void ProcessRecord_Updatecloudnativestoragesetting()
        {
            this._logger.name += " -Updatecloudnativestoragesetting";
            // Invoke graphql operation updateCloudNativeAzureStorageSetting
            InvokeMutationUpdateCloudNativeAzureStorageSetting();
        }

        // This parameter set invokes a single graphql operation:
        // updateCloudNativeRcvAzureStorageSetting.
        protected void ProcessRecord_Updatecloudnativercvstoragesetting()
        {
            this._logger.name += " -Updatecloudnativercvstoragesetting";
            // Invoke graphql operation updateCloudNativeRcvAzureStorageSetting
            InvokeMutationUpdateCloudNativeRcvAzureStorageSetting();
        }

        // This parameter set invokes a single graphql operation:
        // createAzureTarget.
        protected void ProcessRecord_Createtarget()
        {
            this._logger.name += " -Createtarget";
            // Invoke graphql operation createAzureTarget
            InvokeMutationCreateAzureTarget();
        }

        // This parameter set invokes a single graphql operation:
        // updateAzureTarget.
        protected void ProcessRecord_Updatetarget()
        {
            this._logger.name += " -Updatetarget";
            // Invoke graphql operation updateAzureTarget
            InvokeMutationUpdateAzureTarget();
        }

        // This parameter set invokes a single graphql operation:
        // createAzureReaderTarget.
        protected void ProcessRecord_Createreadertarget()
        {
            this._logger.name += " -Createreadertarget";
            // Invoke graphql operation createAzureReaderTarget
            InvokeMutationCreateAzureReaderTarget();
        }

        // This parameter set invokes a single graphql operation:
        // startAzureCloudAccountOauth.
        protected void ProcessRecord_Startcloudaccountoauth()
        {
            this._logger.name += " -Startcloudaccountoauth";
            // Invoke graphql operation startAzureCloudAccountOauth
            InvokeMutationStartAzureCloudAccountOauth();
        }

        // This parameter set invokes a single graphql operation:
        // completeAzureCloudAccountOauth.
        protected void ProcessRecord_Completecloudaccountoauth()
        {
            this._logger.name += " -Completecloudaccountoauth";
            // Invoke graphql operation completeAzureCloudAccountOauth
            InvokeMutationCompleteAzureCloudAccountOauth();
        }

        // This parameter set invokes a single graphql operation:
        // setAzureCloudAccountCustomerAppCredentials.
        protected void ProcessRecord_Setcloudaccountcustomerappcredential()
        {
            this._logger.name += " -Setcloudaccountcustomerappcredential";
            // Invoke graphql operation setAzureCloudAccountCustomerAppCredentials
            InvokeMutationSetAzureCloudAccountCustomerAppCredentials();
        }

        // This parameter set invokes a single graphql operation:
        // addAzureCloudAccount.
        protected void ProcessRecord_Addcloudaccount()
        {
            this._logger.name += " -Addcloudaccount";
            // Invoke graphql operation addAzureCloudAccount
            InvokeMutationAddAzureCloudAccount();
        }

        // This parameter set invokes a single graphql operation:
        // addAzureCloudAccountWithoutOauth.
        protected void ProcessRecord_Addcloudaccountwithoutoauth()
        {
            this._logger.name += " -Addcloudaccountwithoutoauth";
            // Invoke graphql operation addAzureCloudAccountWithoutOauth
            InvokeMutationAddAzureCloudAccountWithoutOauth();
        }

        // This parameter set invokes a single graphql operation:
        // deleteAzureCloudAccount.
        protected void ProcessRecord_Deletecloudaccount()
        {
            this._logger.name += " -Deletecloudaccount";
            // Invoke graphql operation deleteAzureCloudAccount
            InvokeMutationDeleteAzureCloudAccount();
        }

        // This parameter set invokes a single graphql operation:
        // deleteAzureCloudAccountWithoutOauth.
        protected void ProcessRecord_Deletecloudaccountwithoutoauth()
        {
            this._logger.name += " -Deletecloudaccountwithoutoauth";
            // Invoke graphql operation deleteAzureCloudAccountWithoutOauth
            InvokeMutationDeleteAzureCloudAccountWithoutOauth();
        }

        // This parameter set invokes a single graphql operation:
        // upgradeAzureCloudAccount.
        protected void ProcessRecord_Upgradecloudaccount()
        {
            this._logger.name += " -Upgradecloudaccount";
            // Invoke graphql operation upgradeAzureCloudAccount
            InvokeMutationUpgradeAzureCloudAccount();
        }

        // This parameter set invokes a single graphql operation:
        // updateCustomerAppPermissionForAzureSql.
        protected void ProcessRecord_Updatecustomerapppermissionforsql()
        {
            this._logger.name += " -Updatecustomerapppermissionforsql";
            // Invoke graphql operation updateCustomerAppPermissionForAzureSql
            InvokeMutationUpdateCustomerAppPermissionForAzureSql();
        }

        // This parameter set invokes a single graphql operation:
        // startDisableAzureCloudAccountJob.
        protected void ProcessRecord_Startdisablecloudaccountjob()
        {
            this._logger.name += " -Startdisablecloudaccountjob";
            // Invoke graphql operation startDisableAzureCloudAccountJob
            InvokeMutationStartDisableAzureCloudAccountJob();
        }

        // This parameter set invokes a single graphql operation:
        // updateAzureCloudAccount.
        protected void ProcessRecord_Updatecloudaccount()
        {
            this._logger.name += " -Updatecloudaccount";
            // Invoke graphql operation updateAzureCloudAccount
            InvokeMutationUpdateAzureCloudAccount();
        }

        // This parameter set invokes a single graphql operation:
        // mapAzureCloudAccountToPersistentStorageLocation.
        protected void ProcessRecord_Mapcloudaccounttopersistentstoragelocation()
        {
            this._logger.name += " -Mapcloudaccounttopersistentstoragelocation";
            // Invoke graphql operation mapAzureCloudAccountToPersistentStorageLocation
            InvokeMutationMapAzureCloudAccountToPersistentStorageLocation();
        }

        // This parameter set invokes a single graphql operation:
        // addAzureCloudAccountExocomputeConfigurations.
        protected void ProcessRecord_Addcloudaccountexocomputeconfiguration()
        {
            this._logger.name += " -Addcloudaccountexocomputeconfiguration";
            // Invoke graphql operation addAzureCloudAccountExocomputeConfigurations
            InvokeMutationAddAzureCloudAccountExocomputeConfigurations();
        }

        // This parameter set invokes a single graphql operation:
        // deleteAzureCloudAccountExocomputeConfigurations.
        protected void ProcessRecord_Deletecloudaccountexocomputeconfiguration()
        {
            this._logger.name += " -Deletecloudaccountexocomputeconfiguration";
            // Invoke graphql operation deleteAzureCloudAccountExocomputeConfigurations
            InvokeMutationDeleteAzureCloudAccountExocomputeConfigurations();
        }

        // This parameter set invokes a single graphql operation:
        // mapAzureCloudAccountExocomputeSubscription.
        protected void ProcessRecord_Mapcloudaccountexocomputesubscription()
        {
            this._logger.name += " -Mapcloudaccountexocomputesubscription";
            // Invoke graphql operation mapAzureCloudAccountExocomputeSubscription
            InvokeMutationMapAzureCloudAccountExocomputeSubscription();
        }

        // This parameter set invokes a single graphql operation:
        // unmapAzureCloudAccountExocomputeSubscription.
        protected void ProcessRecord_Unmapcloudaccountexocomputesubscription()
        {
            this._logger.name += " -Unmapcloudaccountexocomputesubscription";
            // Invoke graphql operation unmapAzureCloudAccountExocomputeSubscription
            InvokeMutationUnmapAzureCloudAccountExocomputeSubscription();
        }

        // This parameter set invokes a single graphql operation:
        // upgradeAzureCloudAccountPermissionsWithoutOauth.
        protected void ProcessRecord_Upgradecloudaccountpermissionswithoutoauth()
        {
            this._logger.name += " -Upgradecloudaccountpermissionswithoutoauth";
            // Invoke graphql operation upgradeAzureCloudAccountPermissionsWithoutOauth
            InvokeMutationUpgradeAzureCloudAccountPermissionsWithoutOauth();
        }

        // This parameter set invokes a single graphql operation:
        // azureOauthConsentKickoff.
        protected void ProcessRecord_Oauthconsentkickoff()
        {
            this._logger.name += " -Oauthconsentkickoff";
            // Invoke graphql operation azureOauthConsentKickoff
            InvokeMutationAzureOauthConsentKickoff();
        }

        // This parameter set invokes a single graphql operation:
        // azureOauthConsentComplete.
        protected void ProcessRecord_Oauthconsentcomplete()
        {
            this._logger.name += " -Oauthconsentcomplete";
            // Invoke graphql operation azureOauthConsentComplete
            InvokeMutationAzureOauthConsentComplete();
        }

        // This parameter set invokes a single graphql operation:
        // createAzureSaasAppAad.
        protected void ProcessRecord_Createsaasappaad()
        {
            this._logger.name += " -Createsaasappaad";
            // Invoke graphql operation createAzureSaasAppAad
            InvokeMutationCreateAzureSaasAppAad();
        }

        // This parameter set invokes a single graphql operation:
        // createAzureCluster.
        protected void ProcessRecord_Createcluster()
        {
            this._logger.name += " -Createcluster";
            // Invoke graphql operation createAzureCluster
            InvokeMutationCreateAzureCluster();
        }

        // This parameter set invokes a single graphql operation:
        // deleteAzureCluster.
        protected void ProcessRecord_Deletecluster()
        {
            this._logger.name += " -Deletecluster";
            // Invoke graphql operation deleteAzureCluster
            InvokeMutationDeleteAzureCluster();
        }

        // This parameter set invokes a single graphql operation:
        // kickoffAzureAdAppSetup.
        protected void ProcessRecord_Kickoffadappsetup()
        {
            this._logger.name += " -Kickoffadappsetup";
            // Invoke graphql operation kickoffAzureAdAppSetup
            InvokeMutationKickoffAzureAdAppSetup();
        }

        // This parameter set invokes a single graphql operation:
        // completeAzureAdAppSetup.
        protected void ProcessRecord_Completeadappsetup()
        {
            this._logger.name += " -Completeadappsetup";
            // Invoke graphql operation completeAzureAdAppSetup
            InvokeMutationCompleteAzureAdAppSetup();
        }

        // This parameter set invokes a single graphql operation:
        // deleteAzureAdDirectory.
        protected void ProcessRecord_Deleteaddirectory()
        {
            this._logger.name += " -Deleteaddirectory";
            // Invoke graphql operation deleteAzureAdDirectory
            InvokeMutationDeleteAzureAdDirectory();
        }

        // This parameter set invokes a single graphql operation:
        // backupAzureAdDirectory.
        protected void ProcessRecord_Backupaddirectory()
        {
            this._logger.name += " -Backupaddirectory";
            // Invoke graphql operation backupAzureAdDirectory
            InvokeMutationBackupAzureAdDirectory();
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
            OperationVariableSet vars = new();
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
            OperationVariableSet vars = new();
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
            OperationVariableSet vars = new();
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
            OperationVariableSet vars = new();
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
            OperationVariableSet vars = new();
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
            OperationVariableSet vars = new();
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
            OperationVariableSet vars = new();
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
            OperationVariableSet vars = new();
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
            OperationVariableSet vars = new();
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
            OperationVariableSet vars = new();
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
            OperationVariableSet vars = new();
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
            OperationVariableSet vars = new();
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
            OperationVariableSet vars = new();
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
            OperationVariableSet vars = new();
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
            OperationVariableSet vars = new();
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
            OperationVariableSet vars = new();
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
            OperationVariableSet vars = new();
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
            OperationVariableSet vars = new();
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
            OperationVariableSet vars = new();
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
            OperationVariableSet vars = new();
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
            OperationVariableSet vars = new();
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
            OperationVariableSet vars = new();
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
            OperationVariableSet vars = new();
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
            OperationVariableSet vars = new();
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
            OperationVariableSet vars = new();
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
            OperationVariableSet vars = new();
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
            OperationVariableSet vars = new();
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
            OperationVariableSet vars = new();
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
            OperationVariableSet vars = new();
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
            OperationVariableSet vars = new();
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
            OperationVariableSet vars = new();
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
            OperationVariableSet vars = new();
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
            OperationVariableSet vars = new();
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
            OperationVariableSet vars = new();
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
            OperationVariableSet vars = new();
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
            OperationVariableSet vars = new();
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
            OperationVariableSet vars = new();
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
            OperationVariableSet vars = new();
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
            OperationVariableSet vars = new();
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
            OperationVariableSet vars = new();
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
            OperationVariableSet vars = new();
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
            OperationVariableSet vars = new();
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
            OperationVariableSet vars = new();
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
            OperationVariableSet vars = new();
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
            OperationVariableSet vars = new();
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
            OperationVariableSet vars = new();
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
            OperationVariableSet vars = new();
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


    } // class Invoke_RscMutateAzure
}