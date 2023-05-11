# Invoke-RscMutateAzure
## Subcommands
### AdAppSetupComplete
Completes the creation flow for an Azure AD app.

- The Input parameter takes a single value of type AzureAdAppSetupCompleteInput.
- Returns AzureAdAppSetupCompleteReply.
### AdAppSetupKickoff
Initiates off the creation flow for an Azure AD app.

- The Input parameter takes a single value of type AzureAdAppSetupKickoffInput.
- Returns AADSaasSetupKickoffResponse.
### OauthConsentComplete
Completes an OAuth consent flow for Azure resource access.

- The Input parameter takes a single value of type AzureOauthConsentCompleteInput.
- Returns RequestStatus.
### OauthConsentKickoff
Kicks off an OAuth consent flow for Azure resource access.

- The OauthConsentKickoff subcommand takes no arguments.
- Returns AzureOauthConsentKickoffReply.
### addCloudAccount
Add the Azure Subscriptions cloud account for the given feature.

- The Input parameter takes a single value of type AddAzureCloudAccountInput.
- Returns AddAzureCloudAccountReply.
### addCloudAccountExocomputeConfiguration
Add Exocompute configurations for an Azure Cloud Account.

- The Input parameter takes a single value of type AddAzureCloudAccountExocomputeConfigurationsInput.
- Returns AddAzureCloudAccountExocomputeConfigurationsReply.
### addCloudAccountWithoutOauth
Add the Azure Subscription cloud account for the given feature without OAuth.

- The Input parameter takes a single value of type AddAzureCloudAccountWithoutOauthInput.
- Returns AddAzureCloudAccountWithoutOauthReply.
### completeCloudAccountOauth
Complete the Azure OAuth flow and pass the authorization code.

- The Input parameter takes a single value of type CompleteAzureCloudAccountOauthInput.
- Returns CompleteAzureCloudAccountOauthReply.
### createAccount
- The Input parameter takes a single value of type CreateAzureAccountInput.
- Returns CloudAccount.
### createAutomaticTargetMapping
- The Input parameter takes a single value of type CreateAutomaticAzureTargetMappingInput.
- Returns TargetMapping.
### createCloudNativeRcvStorageSetting
Create Rubrik Cloud Vault storage settings for archiving azure cloud native protected objects.

- The Input parameter takes a single value of type CreateCloudNativeRcvAzureStorageSettingInput.
- Returns CreateCloudNativeRcvAzureStorageSettingReply.
### createCloudNativeStorageSetting
Creates Storage Settings for the archival of azure cloud native protected objects

- The Input parameter takes a single value of type CreateCloudNativeAzureStorageSettingInput.
- Returns CreateCloudNativeAzureStorageSettingReply.
### createCluster
Create a Rubrik Cloud Cluster on Azure.

- The Input parameter takes a single value of type CreateAzureClusterInput.
- Returns CcProvisionJobReply.
### createReaderTarget
Creates reader type for Azure archival location on a CDM cluster.

- The Input parameter takes a single value of type CreateAzureReaderTargetInput.
- Returns Target.
### createSaasAppAad
Create or get an Azure AAD application.

- The createSaasAppAad subcommand takes no arguments.
- Returns CreateAzureSaasAppAadReply.
### createTarget
Creates an Azure archival target on the Rubrik cluster.

- The Input parameter takes a single value of type CreateAzureTargetInput.
- Returns Target.
### deleteAdDirectory
Deletes an Azure AD directory.

- The Input parameter takes a single value of type System.String.
- Returns CreateOnDemandJobReply.
### deleteCloudAccount
Delete the Azure Subscriptions cloud account for the given feature.

- The Input parameter takes a single value of type DeleteAzureCloudAccountInput.
- Returns DeleteAzureCloudAccountReply.
### deleteCloudAccountExocomputeConfiguration
Delete Exocompute configurations for an Azure Cloud Account.

- The Input parameter takes a single value of type DeleteAzureCloudAccountExocomputeConfigurationsInput.
- Returns DeleteAzureCloudAccountExocomputeConfigurationsReply.
### deleteCloudAccountWithoutOauth
Delete the Azure Subscriptions cloud account for the given feature without OAuth.

- The Input parameter takes a single value of type DeleteAzureCloudAccountWithoutOauthInput.
- Returns DeleteAzureCloudAccountWithoutOauthReply.
### deleteCluster
Delete a Rubrik Cloud Cluster on Azure.

- The Input parameter takes a single value of type DeleteAzureClusterInput.
- Returns CcProvisionJobReply.
### excludeNativeManagedDisksFromSnapshot
Exclude the Managed Disks from snapshots, for the specified virtual machines.

- The Input parameter takes a single value of type ExcludeAzureNativeManagedDisksFromSnapshotInput.
- Returns System.String.
### mapCloudAccountExocomputeSubscription
Map Azure cloud accounts to an Exocompute subscription.

- The Input parameter takes a single value of type MapAzureCloudAccountExocomputeSubscriptionInput.
- Returns MapAzureCloudAccountExocomputeSubscriptionReply.
### mapCloudAccountToPersistentStorageLocation
Map Azure cloud accounts to a persistent storage location.

- The Input parameter takes a single value of type MapAzureCloudAccountToPersistentStorageLocationInput.
- Returns MapAzureCloudAccountToPersistentStorageLocationReply.
### setCloudAccountCustomerAppCredential
Set credentials for the customer application, for the tenant domain name.

- The Input parameter takes a single value of type SetAzureCloudAccountCustomerAppCredentialsInput.
- Returns System.Boolean.
### startCloudAccountOauth
Initiates a session before doing Azure OAuth flow. If a custom app is configured for the tenant, the client ID of the custom app is returned. Otherwise, the client ID of the default app is returned.

- The Input parameter takes a single value of type StartAzureCloudAccountOauthInput.
- Returns StartAzureCloudAccountOauthReply.
### startCreateNativeManagedDiskSnapshotsJob
Start a job to create snapshots of the Azure Native Managed Disks identified by the given IDs. When started, this will start taking an on-demand snapshot of the selected disks as per the SLA Policy assigned to the respective disks.

- The Input parameter takes a single value of type StartCreateAzureNativeManagedDiskSnapshotsJobInput.
- Returns BatchAsyncJobStatus.
### startCreateNativeVirtualMachineSnapshotsJob
Start a job to create a snapshot for the Azure Native virtual machine identified by the IDs. When started, this will start taking an on-demand snapshot of the selected VMs as per the SLA Policy assigned to the respective VMs.

- The Input parameter takes a single value of type StartCreateAzureNativeVirtualMachineSnapshotsJobInput.
- Returns BatchAsyncJobStatus.
### startDisableCloudAccountJob
Start on-demand jobs to disable the feature for the given Azure Cloud Accounts. When completed, the status of cloud account feature will change to Disabled and the feature will become eligible to be deleted.

- The Input parameter takes a single value of type StartDisableAzureCloudAccountJobInput.
- Returns BatchAsyncJobStatus.
### startDisableNativeSubscriptionProtectionJob
Start a job to disable protection for a specified Azure subscription.

- The Input parameter takes a single value of type StartDisableAzureNativeSubscriptionProtectionJobInput.
- Returns AsyncJobStatus.
### startExportNativeManagedDiskJob
Start a job to export the specified Azure Native Managed Disks to the desired destination.

- The Input parameter takes a single value of type StartExportAzureNativeManagedDiskJobInput.
- Returns AsyncJobStatus.
### startExportNativeVirtualMachineJob
Start a job to export the Azure native virtual machine for a specified snapshot to a specified destination.

- The Input parameter takes a single value of type StartExportAzureNativeVirtualMachineJobInput.
- Returns AsyncJobStatus.
### startExportSqlDatabaseDbJob
Start a job to export Azure SQL Database. The job creates a new Azure SQL Database with the same properties as that of the instance that is exported.

- The Input parameter takes a single value of type StartExportAzureSqlDatabaseDbJobInput.
- Returns AsyncJobStatus.
### startExportSqlManagedInstanceDbJob
Start a job to export Azure SQL Managed Instance database. The job creates a new Azure SQL Managed Instance database with the same properties as that of the instance that is exported.

- The Input parameter takes a single value of type StartExportAzureSqlManagedInstanceDbJobInput.
- Returns AsyncJobStatus.
### startRefreshNativeSubscriptionsJob
Start a job to refresh Azure Native subscription for the given subscription IDs. When started, this job will update the Rubrik platform with any changes that have been done on Azure for the respective subscription.

- The Input parameter takes a single value of type StartRefreshAzureNativeSubscriptionsJobInput.
- Returns BatchAsyncJobStatus.
### startRestoreNativeVirtualMachineJob
Start a job to restore Azure Native virtual machine with the selected snapshot. When started, this will replace the original VM with the selected snapshot.

- The Input parameter takes a single value of type StartRestoreAzureNativeVirtualMachineJobInput.
- Returns AsyncJobStatus.
### unmapCloudAccountExocomputeSubscription
Unmap Azure cloud accounts from the mapped Exocompute subscription.

- The Input parameter takes a single value of type UnmapAzureCloudAccountExocomputeSubscriptionInput.
- Returns UnmapAzureCloudAccountExocomputeSubscriptionReply.
### updateAccount
- The Input parameter takes a single value of type UpdateAzureAccountInput.
- Returns CloudAccount.
### updateAutomaticTargetMapping
- The Input parameter takes a single value of type UpdateAutomaticAzureTargetMappingInput.
- Returns TargetMapping.
### updateCloudAccount
Update names of the Azure Subscriptions cloud account and regions for the given feature.

- The Input parameter takes a single value of type UpdateAzureCloudAccountInput.
- Returns UpdateAzureCloudAccountReply.
### updateCloudNativeRcvStorageSetting
Updates an existing Rubrik Cloud Vault Storage Settings for the archival of azure cloud native protected objects.

- The Input parameter takes a single value of type UpdateCloudNativeRcvAzureStorageSettingInput.
- Returns UpdateCloudNativeRcvAzureStorageSettingReply.
### updateCloudNativeStorageSetting
- The Input parameter takes a single value of type UpdateCloudNativeAzureStorageSettingInput.
- Returns UpdateCloudNativeAzureStorageSettingReply.
### updateCustomerAppPermissionForSql
Updates the Azure app for the specified account in an idempotent manner to support Azure SQL Database and  Managed Instance Database authentication.

- The updateCustomerAppPermissionForSql subcommand takes no arguments.
- Returns System.String.
### updateTarget
- The Input parameter takes a single value of type UpdateAzureTargetInput.
- Returns Target.
### upgradeCloudAccount
Update permissions of the Azure Subscriptions cloud account for given feature.

- The Input parameter takes a single value of type UpgradeAzureCloudAccountInput.
- Returns UpgradeAzureCloudAccountReply.
### upgradeCloudAccountPermissionsWithoutOauth
Set Azure Cloud Account feature status to Connected from Update Permissions state without any permission validation. It should be used by caution from cloud accounts which have been set up without using OAuth, only after adding the latest permissions that are required.

- The Input parameter takes a single value of type UpgradeAzureCloudAccountPermissionsWithoutOauthInput.
- Returns UpgradeAzureCloudAccountPermissionsWithoutOauthReply.
