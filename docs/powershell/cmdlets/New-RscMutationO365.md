# New-RscMutationO365
## Subcommands
### addorg
Adds an O365 org to the account.

- There is a single argument of type AddO365OrgInput.
- Returns AddO365OrgResponse.
### analyzemvb
AnalyzeO365Mvb starts an O365 MVB recovery analysis job.

- There is a single argument of type AnalyzeO365MvbInput.
- Returns AnalyzeO365MvbReply.
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
BackupO365SharepointListV2 schedules an on-demand backup of the given
SharePoint list workload. V2 replacement for the legacy api-server
resolver `backupO365SharepointV2` (GraphQL name
`backupO365SharepointList`). Identity is carried in req_ctx; the
handler builds the JobInfo with SharepointObjectType="LIST" and a nil
retention SLA Domain (both hardcoded in V1) and schedules using the
korg-job-backup-o365-sharepoint-v2 job service.

- There is a single argument of type BackupO365SharePointListInput.
- Returns CreateOnDemandJobReply.
### backupsharepointsite
BackupO365SharePointSiteV2 schedules an on-demand backup of the given
SharePoint site workload. V2 replacement for the legacy api-server
resolver `backupO365SharePointSite`. Identity is carried in req_ctx;
the handler builds the JobInfo with SharepointObjectType="SITE" and
forwards the optional retention SLA Domain, then schedules using the
korg-job-backup-o365-sharepoint-v2 job service (same job type as the
list variant -- they differ only in JobInfo).

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
### restorefullteams
Restore the complete Team.

- There is a single argument of type RestoreO365FullTeamsInput.
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
Restores an O365 workload (OneDrive, SharePoint, Exchange, Calendar,
Contacts, Teams). The account, user, and RSC org id are resolved from
req_ctx.

- There is a single argument of type RestoreO365SnappableInput.
- Returns CreateOnDemandJobReply.
### restoreteamsconversations
Restore Team conversations.

- There is a single argument of type RestoreO365TeamsConversationsInput.
- Returns CreateOnDemandJobReply.
### restoreteamsfiles
Schedules an on-demand restore job for files and folders within a
Teams channel. The account, user, and RSC org id are resolved from
req_ctx.

- There is a single argument of type RestoreO365TeamsFilesInput.
- Returns CreateOnDemandJobReply.
### saassetupcomplete
Completes a Rubrik-Hosted setup flow.

- There is a single argument of type O365SaasSetupCompleteInput.
- Returns AddO365OrgResponse.
### saassetupkickoff
O365SaaSSetupKickoff starts the first-leg of an O365 OAuth client-secret code
flow for the fully hosted solution.

- The saassetupkickoff subcommand takes no arguments.
- Returns O365SaasSetupKickoffReply.
### setserviceaccount
SetO365ServiceAccountV2 sets the Microsoft 365 service account
credentials for an organization. V2 replacement for the legacy
cloud-manager SetO365ServiceAccount RPC. Identity is carried in
req_ctx; the handler delegates to the existing cloud-manager RPC.

- There are 3 arguments.
    - username - System.String: Service account username.
    - appPassword - System.String: Service account app password.
    - orgId - System.String: Microsoft 365 organization ID for which the service
account is being set.
- Returns RequestStatus.
### setupkickoff
O365SetupKickoff starts the first-leg of an O365 OAuth client-secret code
flow.

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
