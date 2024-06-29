# New-RscMutationO365
## Subcommands
### addorg
Adds an O365 org to the account.

- There is a single argument of type AddO365OrgInput.
- Returns AddO365OrgResponse.
### backupmailbox
Backup mailbox workload.

- There is a single argument of type list of System.Strings.
- Returns BatchAsyncJobStatus.
### backuponedrive
Take on-demand snapshot for Onedrive.

- There is a single argument of type BackupO365OnedriveInput.
- Returns BatchAsyncJobStatus.
### backupsharepointdrive
Take on-demand snapshot for Sharepoint drive.

- There is a single argument of type BackupO365SharepointDriveInput.
- Returns BatchAsyncJobStatus.
### backupsharepointlist
Take on-demand snapshot for SharePoint list.

- There is a single argument of type BackupO365SharePointListInput.
- Returns CreateOnDemandJobReply.
### backupsharepointsite
Take on-demand snapshot for a SharePoint site.

- There is a single argument of type BackupO365SharePointSiteInput.
- Returns CreateOnDemandJobReply.
### backupteam
Take on-demand snapshot for Teams.

- There is a single argument of type BackupO365TeamInput.
- Returns BatchAsyncJobStatus.
### createappcomplete
Completes the creation flow for an O365 Azure AD App.

- There is a single argument of type CreateO365AppCompleteInput.
- Returns RequestStatus.
### createappkickoff
Kicks off the creation flow for an O365 Azure AD App.

- There is a single argument of type CreateO365AppKickoffInput.
- Returns CreateO365AppKickoffResp.
### deleteazureapp
Deletes an O365 Azure AD App from the account.

- There are 2 arguments.
    - o365AppClientId - System.String
    - o365AppType - System.String
- Returns RequestStatus.
### deleteorg
Deletes an O365 org from the account.

- There is a single argument of type System.String.
- Returns CreateOnDemandJobReply.
### deleteserviceaccount
Deletes the service account for an org.

- There is a single argument of type System.String.
- Returns RequestStatus.
### enablesharepoint
Enables SharePoint protection in the exocompute cluster.

- There is a single argument of type EnableO365SharePointInput.
- Returns RequestStatus.
### enableteams
Enables Teams protection in the exocompute cluster.

- There is a single argument of type System.String.
- Returns RequestStatus.
### exportmailbox
Exports an Exchange mailbox.

- There is a single argument of type ExportO365MailboxInput.
- Returns CreateOnDemandJobReply.
### exportmailboxv2
Exports an Exchange mailbox.

- There is a single argument of type ExportO365MailboxInput.
- Returns list of CreateOnDemandJobReplys.
### insertcustomerapp
Inserts a Customer-hosted O365 Azure AD App.

- There is a single argument of type InsertCustomerO365AppInput.
- Returns RequestStatus.
### oauthconsentcomplete
Completes the OAuth consent flow for an O365 Azure AD App.

- There is a single argument of type O365OauthConsentCompleteInput.
- Returns O365OauthConsentCompleteReply.
### oauthconsentkickoff
Kicks off the OAuth consent flow for an O365 Azure AD App.

- There is a single argument of type O365OauthConsentKickoffInput.
- Returns O365OauthConsentKickoffReply.
### pdlgroups
Retrieve or create the groups corresponding to the preferred data location and workload pairings for use in role creation.

- There is a single argument of type O365PdlGroupsInput.
- Returns O365PdlGroupsReply.
### refreshorg
Refreshes an O365 org.

- There is a single argument of type System.String.
- Returns CreateOnDemandJobReply.
### restoremailbox
Restores an Exchange mailbox.

- There is a single argument of type RestoreO365MailboxInput.
- Returns CreateOnDemandJobReply.
### restoremailboxv2
Restores an Exchange mailbox data.

- There is a single argument of type RestoreO365MailboxInput.
- Returns list of CreateOnDemandJobReplys.
### restoresnappable
Restores an O365 snappable.

- There is a single argument of type RestoreO365SnappableInput.
- Returns CreateOnDemandJobReply.
### restoreteamsconversations
Restore Team conversations.

- There is a single argument of type RestoreO365TeamsConversationsInput.
- Returns CreateOnDemandJobReply.
### restoreteamsfiles
Restore Team files.

- There is a single argument of type RestoreO365TeamsFilesInput.
- Returns CreateOnDemandJobReply.
### saassetupcomplete
Completes a Rubrik-Hosted setup flow.

- There is a single argument of type O365SaasSetupCompleteInput.
- Returns AddO365OrgResponse.
### saassetupkickoff
- The saassetupkickoff subcommand takes no arguments.
- Returns O365SaasSetupKickoffReply.
### setserviceaccount
Sets the service account for the org.

- There are 3 arguments.
    - username - System.String
    - appPassword - System.String
    - orgId - System.String: Org UUID.
- Returns RequestStatus.
### setupkickoff
Kicks off an O365 subscription setup flow.

- The setupkickoff subcommand takes no arguments.
- Returns O365SetupKickoffResp.
### updateappauthstatus
Update O365 App authentication status to applicable app version.

- There is a single argument of type UpdateO365AppAuthStatusInput.
- Returns UpdateO365AppAuthStatusReply.
### updateapppermissions
Update O365 Azure app permission in Azure AD portal.

- There is a single argument of type UpdateO365AppPermissionsInput.
- Returns System.String.
### updateorgcustomname
Update the custom name for an O365 Organization.

- There is a single argument of type UpdateO365OrgCustomNameInput.
- Returns UpdateO365OrgCustomNameReply.
