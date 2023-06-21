# Invoke-RscMutateAzure
## Subcommands
### Addcloudaccount
Add the Azure Subscriptions cloud account for the given feature.

- There is a single argument of type AddAzureCloudAccountInput.
- Returns AddAzureCloudAccountReply.
### Addcloudaccountexocomputeconfiguration
Add Exocompute configurations for an Azure Cloud Account.

- There is a single argument of type AddAzureCloudAccountExocomputeConfigurationsInput.
- Returns AddAzureCloudAccountExocomputeConfigurationsReply.
### Addcloudaccountwithoutoauth
Add the Azure Subscription cloud account for the given feature without OAuth.

- There is a single argument of type AddAzureCloudAccountWithoutOauthInput.
- Returns AddAzureCloudAccountWithoutOauthReply.
### Backupaddirectory
Backs up the Azure AD directory.

- There is a single argument of type BackupAzureAdDirectoryInput.
- Returns list of CreateOnDemandJobReplys.
### Completeadappsetup
Completes the creation flow for an Azure AD app.

- There is a single argument of type CompleteAzureAdAppSetupInput.
- Returns CompleteAzureAdAppSetupReply.
### Completeadappupdate
Completes an update to the Azure AD directory App.

- There is a single argument of type CompleteAzureAdAppUpdateInput.
- Returns System.String.
### Completecloudaccountoauth
Complete the Azure OAuth flow and pass the authorization code.

- There is a single argument of type CompleteAzureCloudAccountOauthInput.
- Returns CompleteAzureCloudAccountOauthReply.
### Createaccount
- There is a single argument of type CreateAzureAccountInput.
- Returns CloudAccount.
### Createautomatictargetmapping
- There is a single argument of type CreateAutomaticAzureTargetMappingInput.
- Returns TargetMapping.
### Createcloudnativercvstoragesetting
Create Rubrik Cloud Vault storage settings for archiving azure cloud native protected objects.

- There is a single argument of type CreateCloudNativeRcvAzureStorageSettingInput.
- Returns CreateCloudNativeRcvAzureStorageSettingReply.
### Createcloudnativestoragesetting
Creates Storage Settings for the archival of azure cloud native protected objects

- There is a single argument of type CreateCloudNativeAzureStorageSettingInput.
- Returns CreateCloudNativeAzureStorageSettingReply.
### Createcluster
Create a Rubrik Cloud Cluster on Azure.

- There is a single argument of type CreateAzureClusterInput.
- Returns CcProvisionJobReply.
### Createreadertarget
Creates reader type for Azure archival location on a CDM cluster.

- There is a single argument of type CreateAzureReaderTargetInput.
- Returns Target.
### Createsaasappaad
Create or get an Azure AAD application.

- The Createsaasappaad subcommand takes no arguments.
- Returns CreateAzureSaasAppAadReply.
### Createtarget
Creates an Azure archival target on the Rubrik cluster.

- There is a single argument of type CreateAzureTargetInput.
- Returns Target.
### Deleteaddirectory
Deletes an Azure AD directory.

- There is a single argument of type System.String.
- Returns CreateOnDemandJobReply.
### Deletecloudaccount
Delete the Azure Subscriptions cloud account for the given feature.

- There is a single argument of type DeleteAzureCloudAccountInput.
- Returns DeleteAzureCloudAccountReply.
### Deletecloudaccountexocomputeconfiguration
Delete Exocompute configurations for an Azure Cloud Account.

- There is a single argument of type DeleteAzureCloudAccountExocomputeConfigurationsInput.
- Returns DeleteAzureCloudAccountExocomputeConfigurationsReply.
### Deletecloudaccountwithoutoauth
Delete the Azure Subscriptions cloud account for the given feature without OAuth.

- There is a single argument of type DeleteAzureCloudAccountWithoutOauthInput.
- Returns DeleteAzureCloudAccountWithoutOauthReply.
### Deletecluster
Delete a Rubrik Cloud Cluster on Azure.

- There is a single argument of type DeleteAzureClusterInput.
- Returns CcProvisionJobReply.
### Excludenativemanageddisksfromsnapshot
Exclude the Managed Disks from snapshots, for the specified virtual machines.

- There is a single argument of type ExcludeAzureNativeManagedDisksFromSnapshotInput.
- Returns System.String.
### Initiateadappupdate
Initiates an update to the Azure AD directory App.

- There is a single argument of type InitiateAzureAdAppUpdateInput.
- Returns InitiateAzureAdAppUpdateReply.
### Kickoffadappsetup
Initiates the Azure AD app creation flow.

- There is a single argument of type KickoffAzureAdAppSetupInput.
- Returns KickoffAzureAdAppSetupReply.
### Mapcloudaccountexocomputesubscription
Map Azure cloud accounts to an Exocompute subscription.

- There is a single argument of type MapAzureCloudAccountExocomputeSubscriptionInput.
- Returns MapAzureCloudAccountExocomputeSubscriptionReply.
### Mapcloudaccounttopersistentstoragelocation
Map Azure cloud accounts to a persistent storage location.

- There is a single argument of type MapAzureCloudAccountToPersistentStorageLocationInput.
- Returns MapAzureCloudAccountToPersistentStorageLocationReply.
### Oauthconsentcomplete
Completes an OAuth consent flow for Azure resource access.

- There is a single argument of type AzureOauthConsentCompleteInput.
- Returns RequestStatus.
### Oauthconsentkickoff
Kicks off an OAuth consent flow for Azure resource access.

- The Oauthconsentkickoff subcommand takes no arguments.
- Returns AzureOauthConsentKickoffReply.
### Setcloudaccountcustomerappcredential
Set credentials for the customer application, for the tenant domain name.

- There is a single argument of type SetAzureCloudAccountCustomerAppCredentialsInput.
- Returns System.Boolean.
### Startcloudaccountoauth
Initiates a session before doing Azure OAuth flow. If a custom app is configured for the tenant, the client ID of the custom app is returned. Otherwise, the client ID of the default app is returned.

- There is a single argument of type StartAzureCloudAccountOauthInput.
- Returns StartAzureCloudAccountOauthReply.
### Startcreatenativemanageddisksnapshotsjob
Start a job to create snapshots of the Azure Native Managed Disks identified by the given IDs. When started, this will start taking an on-demand snapshot of the selected disks as per the SLA Policy assigned to the respective disks.

- There is a single argument of type StartCreateAzureNativeManagedDiskSnapshotsJobInput.
- Returns BatchAsyncJobStatus.
### Startcreatenativevirtualmachinesnapshotsjob
Start a job to create a snapshot for the Azure Native virtual machine identified by the IDs. When started, this will start taking an on-demand snapshot of the selected VMs as per the SLA Policy assigned to the respective VMs.

- There is a single argument of type StartCreateAzureNativeVirtualMachineSnapshotsJobInput.
- Returns BatchAsyncJobStatus.
### Startdisablecloudaccountjob
Start on-demand jobs to disable the feature for the given Azure Cloud Accounts. When completed, the status of cloud account feature will change to Disabled and the feature will become eligible to be deleted.

- There is a single argument of type StartDisableAzureCloudAccountJobInput.
- Returns BatchAsyncJobStatus.
### Startdisablenativesubscriptionprotectionjob
Start a job to disable protection for a specified Azure subscription.

- There is a single argument of type StartDisableAzureNativeSubscriptionProtectionJobInput.
- Returns AsyncJobStatus.
### Startexportnativemanageddiskjob
Start a job to export the specified Azure Native Managed Disks to the desired destination.

- There is a single argument of type StartExportAzureNativeManagedDiskJobInput.
- Returns AsyncJobStatus.
### Startexportnativevirtualmachinejob
Start a job to export the Azure native virtual machine for a specified snapshot to a specified destination.

- There is a single argument of type StartExportAzureNativeVirtualMachineJobInput.
- Returns AsyncJobStatus.
### Startexportsqldatabasedbjob
Start a job to export Azure SQL Database. The job creates a new Azure SQL Database with the same properties as that of the instance that is exported.

- There is a single argument of type StartExportAzureSqlDatabaseDbJobInput.
- Returns AsyncJobStatus.
### Startexportsqlmanagedinstancedbjob
Start a job to export Azure SQL Managed Instance database. The job creates a new Azure SQL Managed Instance database with the same properties as that of the instance that is exported.

- There is a single argument of type StartExportAzureSqlManagedInstanceDbJobInput.
- Returns AsyncJobStatus.
### Startrefreshnativesubscriptionsjob
Start a job to refresh Azure Native subscription for the given subscription IDs. When started, this job will update the Rubrik platform with any changes that have been done on Azure for the respective subscription.

- There is a single argument of type StartRefreshAzureNativeSubscriptionsJobInput.
- Returns BatchAsyncJobStatus.
### Startrestorenativevirtualmachinejob
Start a job to restore Azure Native virtual machine with the selected snapshot. When started, this will replace the original VM with the selected snapshot.

- There is a single argument of type StartRestoreAzureNativeVirtualMachineJobInput.
- Returns AsyncJobStatus.
### Unmapcloudaccountexocomputesubscription
Unmap Azure cloud accounts from the mapped Exocompute subscription.

- There is a single argument of type UnmapAzureCloudAccountExocomputeSubscriptionInput.
- Returns UnmapAzureCloudAccountExocomputeSubscriptionReply.
### Updateaccount
- There is a single argument of type UpdateAzureAccountInput.
- Returns CloudAccount.
### Updateautomatictargetmapping
- There is a single argument of type UpdateAutomaticAzureTargetMappingInput.
- Returns TargetMapping.
### Updatecloudaccount
Update names of the Azure Subscriptions cloud account and regions for the given feature.

- There is a single argument of type UpdateAzureCloudAccountInput.
- Returns UpdateAzureCloudAccountReply.
### Updatecloudnativercvstoragesetting
Updates an existing Rubrik Cloud Vault Storage Settings for the archival of azure cloud native protected objects.

- There is a single argument of type UpdateCloudNativeRcvAzureStorageSettingInput.
- Returns UpdateCloudNativeRcvAzureStorageSettingReply.
### Updatecloudnativestoragesetting
- There is a single argument of type UpdateCloudNativeAzureStorageSettingInput.
- Returns UpdateCloudNativeAzureStorageSettingReply.
### Updatecustomerapppermissionforsql
Updates the Azure app for the specified account in an idempotent manner to support Azure SQL Database and  Managed Instance Database authentication.

- The Updatecustomerapppermissionforsql subcommand takes no arguments.
- Returns System.String.
### Updatetarget
- There is a single argument of type UpdateAzureTargetInput.
- Returns Target.
### Upgradecloudaccount
Update permissions of the Azure Subscriptions cloud account for given feature.

- There is a single argument of type UpgradeAzureCloudAccountInput.
- Returns UpgradeAzureCloudAccountReply.
### Upgradecloudaccountpermissionswithoutoauth
Set Azure Cloud Account feature status to Connected from Update Permissions state without any permission validation. It should be used by caution from cloud accounts which have been set up without using OAuth, only after adding the latest permissions that are required.

- There is a single argument of type UpgradeAzureCloudAccountPermissionsWithoutOauthInput.
- Returns UpgradeAzureCloudAccountPermissionsWithoutOauthReply.
