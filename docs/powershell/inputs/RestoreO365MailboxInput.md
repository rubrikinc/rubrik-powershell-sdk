### RestoreO365MailboxInput
Configuration for O365 mailbox restore.

- orgUuid: System.String
  - Polaris ID of the O365 subscription.
- mailboxUuid: System.String
  - Polaris ID of the mailbox.
- snapshotUuid: System.String
  - Polaris ID of the snapshot to restore.
- restoreConfigs: list of RestoreObjectConfigs
  - Configuration for the restore job.
- actionType: O365RestoreActionType
  - Specifies the recovery type for the job.
- inplaceRestoreConfig: InplaceRestoreConfig
  - In-place restore configuration for the restore job.
- skipRifItems: System.Boolean
  - Specifies whether to skip items in the Recoverable Items folder.
- leaseId: System.String
  - ID of the just-in-time permission elevation lease covering this
restore's write permissions, if elevation was required. Empty for
full-access-mode apps.
