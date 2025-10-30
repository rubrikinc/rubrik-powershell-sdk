# New-RscMutationAzure
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
### cloudaccountaddwithcustomerappinitiate
AzureCloudAccountAddWithCustomerAppInitiate adds a cloud account using customer app
credentials without requiring interactive user consent.
This process uses the user's app ID and secret key to assign roles to the
service principal of the Rubrik multi-tenant app.

- There is a single argument of type AzureCloudAccountAddWithCustomerAppInitiateInput.
- Returns AzureCloudAccountAddWithCustomerAppInitiateReply.
### completeadappsetup
Completes the creation flow for an Azure AD app.

- There is a single argument of type CompleteAzureAdAppSetupInput.
- Returns CompleteAzureAdAppSetupReply.
### completeadappupdate
Completes an update to the Azure AD directory app.

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

- There is a single argument of type DeleteAzureAdDirectoryInput.
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
### excludestorageaccountcontainers
Updates the list of containers excluded from protection for the specified storage account.

- There is a single argument of type ExcludeAzureStorageAccountContainersInput.
- Returns System.String.
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
### restoreadobjectswithpasswords
Restores the Azure AD directory with multiple passwords.

- There is a single argument of type RestoreAzureAdObjectsWithPasswordsInput.
- Returns RestoreAzureAdObjectsWithPasswordsReply.
### setcloudaccountcustomerappcredentials
Set credentials for the customer application, for the tenant domain name.

- There is a single argument of type SetAzureCloudAccountCustomerAppCredentialsInput.
- Returns System.Boolean.
### startadappsetup
Initiates the Azure AD app creation workflow.

- There is a single argument of type StartAzureAdAppSetupInput.
- Returns StartAzureAdAppSetupReply.
### startadappupdate
Initiates an update to the Azure AD directory app.

- There is a single argument of type StartAzureAdAppUpdateInput.
- Returns StartAzureAdAppUpdateReply.
### startcloudaccountoauth
Initiates a session before doing Azure OAuth flow. If a custom app is configured for the tenant, the client ID of the custom app is returned. Otherwise, the client ID of the default app is returned.

- There is a single argument of type StartAzureCloudAccountOauthInput.
- Returns StartAzureCloudAccountOauthReply.
### startdisablecloudaccountjob
Start on-demand jobs to disable the feature for the given Azure Cloud Accounts. When completed, the status of cloud account feature will change to Disabled and the feature will become eligible to be deleted.

- There is a single argument of type StartDisableAzureCloudAccountJobInput.
- Returns BatchAsyncJobStatus.
### startexportsqldatabasedbjob
Start a job to export Azure SQL Database. The job creates a new Azure SQL Database with the same properties as that of the instance that is exported.

- There is a single argument of type StartExportAzureSqlDatabaseDbJobInput.
- Returns AsyncJobStatus.
### startexportsqlmanagedinstancedbjob
Start a job to export Azure SQL Managed Instance database. The job creates a new Azure SQL Managed Instance database with the same properties as that of the instance that is exported.

- There is a single argument of type StartExportAzureSqlManagedInstanceDbJobInput.
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
Updates an existing Rubrik Cloud Vault Azure storage settings for the archival of Azure cloud-native protected objects.

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
### updatetenantforsubscription
Updates the Tenant of the Azure Subscription added in RSC.

- There is a single argument of type AzureUpdateTenantForSubscriptionInput.
- Returns System.String.
### upgradecloudaccount
Update permissions of the Azure Subscriptions cloud account for given feature.

- There is a single argument of type UpgradeAzureCloudAccountInput.
- Returns UpgradeAzureCloudAccountReply.
### upgradecloudaccountpermissionswithoutoauth
Set Azure Cloud Account feature status to Connected from Update Permissions state without any permission validation. It should be used by caution from cloud accounts which have been set up without using OAuth, only after adding the latest permissions that are required.

- There is a single argument of type UpgradeAzureCloudAccountPermissionsWithoutOauthInput.
- Returns UpgradeAzureCloudAccountPermissionsWithoutOauthReply.
