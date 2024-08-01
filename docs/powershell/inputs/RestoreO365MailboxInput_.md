### RestoreO365MailboxInput
Configuration for O365 mailbox restore.

- orgUuid: System.String
  - Polaris ID of O365 subscription.
- mailboxUuid: System.String
  - Polaris ID of the mailbox.
- snapshotUuid: System.String
  - Polaris ID of restoring snapshot.
- restoreConfigs: list of RestoreObjectConfigs
  - Configuration for restore job.
- actionType: O365RestoreActionType
  - Specifies the recovery type for the job.
- inplaceRestoreConfig: InplaceRestoreConfig
  - In-place restore configuration for restore job.
- skipRifItems: System.Boolean
  - Specifies whether to skip items in the Recoverable Items folder.
