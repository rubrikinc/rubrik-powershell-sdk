# New-RscMutationM365
## Subcommands
### backupmailbox
Backup mailbox workload.

- There is a single argument of type BackupM365MailboxInput.
- Returns list of CreateOnDemandJobReplys.
### backuponedrive
Take on-demand snapshot for Onedrive.

- There is a single argument of type BackupM365OnedriveInput.
- Returns list of CreateOnDemandJobReplys.
### backupsharepointdrive
Take on-demand snapshot for Sharepoint drive.

- There is a single argument of type BackupM365SharepointDriveInput.
- Returns list of CreateOnDemandJobReplys.
### backupstoragesetupcomplete
Completes the Microsoft 365 Backup Storage setup process.

- There is a single argument of type M365BackupStorageSetupCompleteInput.
- Returns M365BackupStorageSetupCompleteReply.
### backupstoragesetupkickoff
Initiates the Microsoft 365 Backup Storage setup process.

- The backupstoragesetupkickoff subcommand takes no arguments.
- Returns M365BackupStorageSetupKickoffReply.
### backupteam
Take on-demand snapshot for Teams.

- There is a single argument of type BackupM365TeamInput.
- Returns list of CreateOnDemandJobReplys.
### persistcustomerapp
Persists the details of the customer-owned M365 app.

- There is a single argument of type PersistCustomerM365AppInput.
- Returns System.String.
