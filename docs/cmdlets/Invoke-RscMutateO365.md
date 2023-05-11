# Invoke-RscMutateO365
## Subcommands
### OauthConsentComplete
Completes the OAuth consent flow for an O365 Azure AD App.

- The Input parameter takes a single value of type O365OauthConsentCompleteInput.
- Returns O365OauthConsentCompleteReply.
### OauthConsentKickoff
Kicks off the OAuth consent flow for an O365 Azure AD App.

- The Input parameter takes a single value of type O365OauthConsentKickoffInput.
- Returns O365OauthConsentKickoffReply.
### PdlGroup
Retrieve or create the groups corresponding to the preferred data location and workload pairings for use in role creation.

- The Input parameter takes a single value of type O365PdlGroupsInput.
- Returns O365PdlGroupsReply.
### SaaSSetupKickoff
- The SaaSSetupKickoff subcommand takes no arguments.
- Returns O365SaasSetupKickoffReply.
### SaasSetupComplete
Completes a Rubrik-Hosted setup flow.

- The Input parameter takes a single value of type O365SaasSetupCompleteInput.
- Returns AddO365OrgResponse.
### SetupKickoff
Kicks off an O365 subscription setup flow.

- The SetupKickoff subcommand takes no arguments.
- Returns O365SetupKickoffResp.
### addOrg
Adds an O365 org to the account.

- The Input parameter takes a single value of type AddO365OrgInput.
- Returns AddO365OrgResponse.
### backupMailbox
Backup mailbox workload.

- The Input parameter takes a single value of type a list of System.Strings.
- Returns BatchAsyncJobStatus.
### backupOnedrive
Take on-demand snapshot for Onedrive.

- The Input parameter takes a single value of type BackupO365OnedriveInput.
- Returns BatchAsyncJobStatus.
### backupSharePointSite
Take on-demand snapshot for a SharePoint site.

- The Input parameter takes a single value of type BackupO365SharePointSiteInput.
- Returns CreateOnDemandJobReply.
### backupSharepointDrive
Take on-demand snapshot for Sharepoint drive.

- The Input parameter takes a single value of type BackupO365SharepointDriveInput.
- Returns BatchAsyncJobStatus.
### backupSharepointList
Take on-demand snapshot for SharePoint list.

- The Input parameter takes a single value of type BackupO365SharePointListInput.
- Returns CreateOnDemandJobReply.
### backupTeam
Take on-demand snapshot for Teams.

- The Input parameter takes a single value of type BackupO365TeamInput.
- Returns BatchAsyncJobStatus.
### createAppComplete
Completes the creation flow for an O365 Azure AD App.

- The Input parameter takes a single value of type CreateO365AppCompleteInput.
- Returns RequestStatus.
### createAppKickoff
Kicks off the creation flow for an O365 Azure AD App.

- The Input parameter takes a single value of type CreateO365AppKickoffInput.
- Returns CreateO365AppKickoffResp.
### deleteAzureApp
Deletes an O365 Azure AD App from the account.

- The Input parameter takes a hashtable with 2 name and value pairs.
    - o365AppClientId - System.String
    - o365AppType - System.String
- Returns RequestStatus.
### deleteOrg
Deletes an O365 org from the account.

- The Input parameter takes a single value of type System.String.
- Returns CreateOnDemandJobReply.
### deleteServiceAccount
Deletes the service account for an org.

- The Input parameter takes a single value of type System.String.
- Returns RequestStatus.
### enableSharePoint
Enables SharePoint protection in the exocompute cluster.

- The Input parameter takes a single value of type EnableO365SharePointInput.
- Returns RequestStatus.
### enableTeam
Enables Teams protection in the exocompute cluster.

- The Input parameter takes a single value of type System.String.
- Returns RequestStatus.
### exportMailbox
Exports an Exchange mailbox.

- The Input parameter takes a single value of type ExportO365MailboxInput.
- Returns CreateOnDemandJobReply.
### insertCustomerApp
Inserts a Customer-hosted O365 Azure AD App.

- The Input parameter takes a single value of type InsertCustomerO365AppInput.
- Returns RequestStatus.
### refreshOrg
Refreshes an O365 org.

- The Input parameter takes a single value of type System.String.
- Returns CreateOnDemandJobReply.
### restoreMailbox
Restores an Exchange mailbox.

- The Input parameter takes a single value of type RestoreO365MailboxInput.
- Returns CreateOnDemandJobReply.
### restoreSnappable
Restores an O365 snappable.

- The Input parameter takes a single value of type RestoreO365SnappableInput.
- Returns CreateOnDemandJobReply.
### restoreTeamsConversation
Restore Team conversations.

- The Input parameter takes a single value of type RestoreO365TeamsConversationsInput.
- Returns CreateOnDemandJobReply.
### restoreTeamsFile
Restore Team files.

- The Input parameter takes a single value of type RestoreO365TeamsFilesInput.
- Returns CreateOnDemandJobReply.
### setServiceAccount
Sets the service account for the org.

- The Input parameter takes a hashtable with 3 name and value pairs.
    - appPassword - System.String
    - orgId - System.String: Org UUID.
    - username - System.String
- Returns RequestStatus.
### updateAppAuthStatus
Update O365 App authentication status to applicable app version.

- The Input parameter takes a single value of type UpdateO365AppAuthStatusInput.
- Returns UpdateO365AppAuthStatusReply.
### updateAppPermission
Update O365 Azure app permission in Azure AD portal.

- The Input parameter takes a single value of type UpdateO365AppPermissionsInput.
- Returns System.String.
### updateOrgCustomName
Update the custom name for an O365 Organization.

- The Input parameter takes a single value of type UpdateO365OrgCustomNameInput.
- Returns UpdateO365OrgCustomNameReply.
