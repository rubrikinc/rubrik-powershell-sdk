# Invoke-RscMutateAzure
## Subcommands
### addcloudaccount
Add the Azure Subscriptions cloud account for the given feature.

- There is a single argument of type AddAzureCloudAccountInput.
- Returns AddAzureCloudAccountReply.
### addcloudaccountexocomputeconfigurations
Add Exocompute configurations for an Azure Cloud Account.

- There is a single argument of type AddAzureCloudAccountExocomputeConfigurationsInput.
- Returns AddAzureCloudAccountExocomputeConfigurationsReply.
### addcloudaccountwithoutoauth
Add the Azure Subscription cloud account for the given feature without OAuth.

- There is a single argument of type AddAzureCloudAccountWithoutOauthInput.
- Returns AddAzureCloudAccountWithoutOauthReply.
### backupaddirectory
Backs up the Azure AD directory.

- There is a single argument of type BackupAzureAdDirectoryInput.
- Returns list of CreateOnDemandJobReplys.
### completeadappsetup
Completes the creation flow for an Azure AD app.

- There is a single argument of type CompleteAzureAdAppSetupInput.
- Returns CompleteAzureAdAppSetupReply.
### completeadappupdate
Completes an update to the Azure AD directory App.

- There is a single argument of type CompleteAzureAdAppUpdateInput.
- Returns System.String.
### completecloudaccountoauth
Complete the Azure OAuth flow and pass the authorization code.

- There is a single argument of type CompleteAzureCloudAccountOauthInput.
- Returns CompleteAzureCloudAccountOauthReply.
### createaccount
- There is a single argument of type CreateAzureAccountInput.
- Returns CloudAccount.
### createautomatictargetmapping
- There is a single argument of type CreateAutomaticAzureTargetMappingInput.
- Returns TargetMapping.
### createcloudnativercvstoragesetting
Create Rubrik Cloud Vault storage settings for archiving azure cloud native protected objects.

- There is a single argument of type CreateCloudNativeRcvAzureStorageSettingInput.
- Returns CreateCloudNativeRcvAzureStorageSettingReply.
### createcloudnativestoragesetting
Creates Storage Settings for the archival of azure cloud native protected objects

- There is a single argument of type CreateCloudNativeAzureStorageSettingInput.
- Returns CreateCloudNativeAzureStorageSettingReply.
### createcluster
Create a Rubrik Cloud Cluster on Azure.

- There is a single argument of type CreateAzureClusterInput.
- Returns CcProvisionJobReply.
### createreadertarget
Creates reader type for Azure archival location on a CDM cluster.

- There is a single argument of type CreateAzureReaderTargetInput.
- Returns Target.
### createsaasappaad
Create or get an Azure AAD application.

- The createsaasappaad subcommand takes no arguments.
- Returns CreateAzureSaasAppAadReply.
### createtarget
Creates an Azure archival target on the Rubrik cluster.

- There is a single argument of type CreateAzureTargetInput.
- Returns Target.
### deleteaddirectory
Deletes an Azure AD directory.

- There is a single argument of type System.String.
- Returns CreateOnDemandJobReply.
### deletecloudaccount
Delete the Azure Subscriptions cloud account for the given feature.

- There is a single argument of type DeleteAzureCloudAccountInput.
- Returns DeleteAzureCloudAccountReply.
### deletecloudaccountexocomputeconfigurations
Delete Exocompute configurations for an Azure Cloud Account.

- There is a single argument of type DeleteAzureCloudAccountExocomputeConfigurationsInput.
- Returns DeleteAzureCloudAccountExocomputeConfigurationsReply.
### deletecloudaccountwithoutoauth
Delete the Azure Subscriptions cloud account for the given feature without OAuth.

- There is a single argument of type DeleteAzureCloudAccountWithoutOauthInput.
- Returns DeleteAzureCloudAccountWithoutOauthReply.
### deletecluster
Delete a Rubrik Cloud Cluster on Azure.

- There is a single argument of type DeleteAzureClusterInput.
- Returns CcProvisionJobReply.
### excludenativemanageddisksfromsnapshot
Exclude the Managed Disks from snapshots, for the specified virtual machines.

- There is a single argument of type ExcludeAzureNativeManagedDisksFromSnapshotInput.
- Returns System.String.
### initiateadappupdate
Initiates an update to the Azure AD directory App.

- There is a single argument of type InitiateAzureAdAppUpdateInput.
- Returns InitiateAzureAdAppUpdateReply.
### kickoffadappsetup
Initiates the Azure AD app creation flow.

- There is a single argument of type KickoffAzureAdAppSetupInput.
- Returns KickoffAzureAdAppSetupReply.
### mapcloudaccountexocomputesubscription
Map Azure cloud accounts to an Exocompute subscription.

- There is a single argument of type MapAzureCloudAccountExocomputeSubscriptionInput.
- Returns MapAzureCloudAccountExocomputeSubscriptionReply.
### mapcloudaccounttopersistentstoragelocation
Map Azure cloud accounts to a persistent storage location.

- There is a single argument of type MapAzureCloudAccountToPersistentStorageLocationInput.
- Returns MapAzureCloudAccountToPersistentStorageLocationReply.
### oauthconsentcomplete
Completes an OAuth consent flow for Azure resource access.

- There is a single argument of type AzureOauthConsentCompleteInput.
- Returns RequestStatus.
### oauthconsentkickoff
Kicks off an OAuth consent flow for Azure resource access.

- The oauthconsentkickoff subcommand takes no arguments.
- Returns AzureOauthConsentKickoffReply.
### setcloudaccountcustomerappcredentials
Set credentials for the customer application, for the tenant domain name.

- There is a single argument of type SetAzureCloudAccountCustomerAppCredentialsInput.
- Returns System.Boolean.
### startcloudaccountoauth
Initiates a session before doing Azure OAuth flow. If a custom app is configured for the tenant, the client ID of the custom app is returned. Otherwise, the client ID of the default app is returned.

- There is a single argument of type StartAzureCloudAccountOauthInput.
- Returns StartAzureCloudAccountOauthReply.
### startcreatenativemanageddisksnapshotsjob
Start a job to create snapshots of the Azure Native Managed Disks identified by the given IDs. When started, this will start taking an on-demand snapshot of the selected disks as per the SLA Policy assigned to the respective disks.

- There is a single argument of type StartCreateAzureNativeManagedDiskSnapshotsJobInput.
- Returns BatchAsyncJobStatus.
### startcreatenativevirtualmachinesnapshotsjob
Start a job to create a snapshot for the Azure Native virtual machine identified by the IDs. When started, this will start taking an on-demand snapshot of the selected VMs as per the SLA Policy assigned to the respective VMs.

- There is a single argument of type StartCreateAzureNativeVirtualMachineSnapshotsJobInput.
- Returns BatchAsyncJobStatus.
### startdisablecloudaccountjob
Start on-demand jobs to disable the feature for the given Azure Cloud Accounts. When completed, the status of cloud account feature will change to Disabled and the feature will become eligible to be deleted.

- There is a single argument of type StartDisableAzureCloudAccountJobInput.
- Returns BatchAsyncJobStatus.
### startdisablenativesubscriptionprotectionjob
Start a job to disable protection for a specified Azure subscription.

- There is a single argument of type StartDisableAzureNativeSubscriptionProtectionJobInput.
- Returns AsyncJobStatus.
### startexportnativemanageddiskjob
Start a job to export the specified Azure Native Managed Disks to the desired destination.

- There is a single argument of type StartExportAzureNativeManagedDiskJobInput.
- Returns AsyncJobStatus.
### startexportnativevirtualmachinejob
Start a job to export the Azure native virtual machine for a specified snapshot to a specified destination.

- There is a single argument of type StartExportAzureNativeVirtualMachineJobInput.
- Returns AsyncJobStatus.
### startexportsqldatabasedbjob
Start a job to export Azure SQL Database. The job creates a new Azure SQL Database with the same properties as that of the instance that is exported.

- There is a single argument of type StartExportAzureSqlDatabaseDbJobInput.
- Returns AsyncJobStatus.
### startexportsqlmanagedinstancedbjob
Start a job to export Azure SQL Managed Instance database. The job creates a new Azure SQL Managed Instance database with the same properties as that of the instance that is exported.

- There is a single argument of type StartExportAzureSqlManagedInstanceDbJobInput.
- Returns AsyncJobStatus.
### startrefreshnativesubscriptionsjob
Start a job to refresh Azure Native subscription for the given subscription IDs. When started, this job will update the Rubrik platform with any changes that have been done on Azure for the respective subscription.

- There is a single argument of type StartRefreshAzureNativeSubscriptionsJobInput.
- Returns BatchAsyncJobStatus.
### startrestorenativevirtualmachinejob
Start a job to restore Azure Native virtual machine with the selected snapshot. When started, this will replace the original VM with the selected snapshot.

- There is a single argument of type StartRestoreAzureNativeVirtualMachineJobInput.
- Returns AsyncJobStatus.
### unmapcloudaccountexocomputesubscription
Unmap Azure cloud accounts from the mapped Exocompute subscription.

- There is a single argument of type UnmapAzureCloudAccountExocomputeSubscriptionInput.
- Returns UnmapAzureCloudAccountExocomputeSubscriptionReply.
### unmappersistentstoragesubscription
Unmaps the archival location from the subscription.

- There is a single argument of type UnmapAzurePersistentStorageSubscriptionInput.
- Returns System.String.
### updateaccount
- There is a single argument of type UpdateAzureAccountInput.
- Returns CloudAccount.
### updateautomatictargetmapping
- There is a single argument of type UpdateAutomaticAzureTargetMappingInput.
- Returns TargetMapping.
### updatecloudaccount
Update names of the Azure Subscriptions cloud account and regions for the given feature.

- There is a single argument of type UpdateAzureCloudAccountInput.
- Returns UpdateAzureCloudAccountReply.
### updatecloudnativercvstoragesetting
Updates an existing Rubrik Cloud Vault Storage Settings for the archival of azure cloud native protected objects.

- There is a single argument of type UpdateCloudNativeRcvAzureStorageSettingInput.
- Returns UpdateCloudNativeRcvAzureStorageSettingReply.
### updatecloudnativestoragesetting
- There is a single argument of type UpdateCloudNativeAzureStorageSettingInput.
- Returns UpdateCloudNativeAzureStorageSettingReply.
### updatecustomerapppermissionforsql
Updates the Azure app for the specified account in an idempotent manner to support Azure SQL Database and  Managed Instance Database authentication.

- The updatecustomerapppermissionforsql subcommand takes no arguments.
- Returns System.String.
### updatetarget
- There is a single argument of type UpdateAzureTargetInput.
- Returns Target.
### upgradecloudaccount
Update permissions of the Azure Subscriptions cloud account for given feature.

- There is a single argument of type UpgradeAzureCloudAccountInput.
- Returns UpgradeAzureCloudAccountReply.
### upgradecloudaccountpermissionswithoutoauth
Set Azure Cloud Account feature status to Connected from Update Permissions state without any permission validation. It should be used by caution from cloud accounts which have been set up without using OAuth, only after adding the latest permissions that are required.

- There is a single argument of type UpgradeAzureCloudAccountPermissionsWithoutOauthInput.
- Returns UpgradeAzureCloudAccountPermissionsWithoutOauthReply.
