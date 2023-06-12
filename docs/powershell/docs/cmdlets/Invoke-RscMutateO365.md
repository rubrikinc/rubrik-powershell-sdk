# Invoke-RscMutateO365
## Subcommands
### Addorg
Adds an O365 org to the account.

- There is a single argument of type AddO365OrgInput.
- Returns AddO365OrgResponse.
### Backupmailbox
Backup mailbox workload.

- There is a single argument of type list of System.Strings.
- Returns BatchAsyncJobStatus.
### Backuponedrive
Take on-demand snapshot for Onedrive.

- There is a single argument of type BackupO365OnedriveInput.
- Returns BatchAsyncJobStatus.
### Backupsharepointdrive
Take on-demand snapshot for Sharepoint drive.

- There is a single argument of type BackupO365SharepointDriveInput.
- Returns BatchAsyncJobStatus.
### Backupsharepointlist
Take on-demand snapshot for SharePoint list.

- There is a single argument of type BackupO365SharePointListInput.
- Returns CreateOnDemandJobReply.
### Backupsharepointsite
Take on-demand snapshot for a SharePoint site.

- There is a single argument of type BackupO365SharePointSiteInput.
- Returns CreateOnDemandJobReply.
### Backupteam
Take on-demand snapshot for Teams.

- There is a single argument of type BackupO365TeamInput.
- Returns BatchAsyncJobStatus.
### Createappcomplete
Completes the creation flow for an O365 Azure AD App.

- There is a single argument of type CreateO365AppCompleteInput.
- Returns RequestStatus.
### Createappkickoff
Kicks off the creation flow for an O365 Azure AD App.

- There is a single argument of type CreateO365AppKickoffInput.
- Returns CreateO365AppKickoffResp.
### Deleteazureapp
Deletes an O365 Azure AD App from the account.

- There are 2 arguments.
    - o365AppClientId - System.String
    - o365AppType - System.String
- Returns RequestStatus.
### Deleteorg
Deletes an O365 org from the account.

- There is a single argument of type System.String.
- Returns CreateOnDemandJobReply.
### Deleteserviceaccount
Deletes the service account for an org.

- There is a single argument of type System.String.
- Returns RequestStatus.
### Enablesharepoint
Enables SharePoint protection in the exocompute cluster.

- There is a single argument of type EnableO365SharePointInput.
- Returns RequestStatus.
### Enableteam
Enables Teams protection in the exocompute cluster.

- There is a single argument of type System.String.
- Returns RequestStatus.
### Exportmailbox
Exports an Exchange mailbox.

- There is a single argument of type ExportO365MailboxInput.
- Returns CreateOnDemandJobReply.
### Insertcustomerapp
Inserts a Customer-hosted O365 Azure AD App.

- There is a single argument of type InsertCustomerO365AppInput.
- Returns RequestStatus.
### Oauthconsentcomplete
Completes the OAuth consent flow for an O365 Azure AD App.

- There is a single argument of type O365OauthConsentCompleteInput.
- Returns O365OauthConsentCompleteReply.
### Oauthconsentkickoff
Kicks off the OAuth consent flow for an O365 Azure AD App.

- There is a single argument of type O365OauthConsentKickoffInput.
- Returns O365OauthConsentKickoffReply.
### Pdlgroup
Retrieve or create the groups corresponding to the preferred data location and workload pairings for use in role creation.

- There is a single argument of type O365PdlGroupsInput.
- Returns O365PdlGroupsReply.
### Refreshorg
Refreshes an O365 org.

- There is a single argument of type System.String.
- Returns CreateOnDemandJobReply.
### Restoremailbox
Restores an Exchange mailbox.

- There is a single argument of type RestoreO365MailboxInput.
- Returns CreateOnDemandJobReply.
### Restoresnappable
Restores an O365 snappable.

- There is a single argument of type RestoreO365SnappableInput.
- Returns CreateOnDemandJobReply.
### Restoreteamsconversation
Restore Team conversations.

- There is a single argument of type RestoreO365TeamsConversationsInput.
- Returns CreateOnDemandJobReply.
### Restoreteamsfile
Restore Team files.

- There is a single argument of type RestoreO365TeamsFilesInput.
- Returns CreateOnDemandJobReply.
### Saassetupcomplete
Completes a Rubrik-Hosted setup flow.

- There is a single argument of type O365SaasSetupCompleteInput.
- Returns AddO365OrgResponse.
### Saassetupkickoff
- The Saassetupkickoff subcommand takes no arguments.
- Returns O365SaasSetupKickoffReply.
### Setserviceaccount
Sets the service account for the org.

- There are 3 arguments.
    - username - System.String
    - appPassword - System.String
    - orgId - System.String: Org UUID.
- Returns RequestStatus.
### Setupkickoff
Kicks off an O365 subscription setup flow.

- The Setupkickoff subcommand takes no arguments.
- Returns O365SetupKickoffResp.
### Updateappauthstatus
Update O365 App authentication status to applicable app version.

- There is a single argument of type UpdateO365AppAuthStatusInput.
- Returns UpdateO365AppAuthStatusReply.
### Updateapppermission
Update O365 Azure app permission in Azure AD portal.

- There is a single argument of type UpdateO365AppPermissionsInput.
- Returns System.String.
### Updateorgcustomname
Update the custom name for an O365 Organization.

- There is a single argument of type UpdateO365OrgCustomNameInput.
- Returns UpdateO365OrgCustomNameReply.
