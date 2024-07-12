### ExportO365MailboxInput
Configuration for O365 mailbox export.

- orgUuid: System.String
  - Polaris ID of O365 subscription.
- fromMailboxUuid: System.String
  - Polaris ID of the source mailbox.
- toMailboxUuid: System.String
  - Polaris ID of the destination mailbox.
- snapshotUuid: System.String
  - Polaris ID of restoring snapshot.
- exportConfigs: list of RestoreObjectConfigs
  - Configuration for restore job.
- actionType: O365RestoreActionType
  - Specifies the recovery type for the job.
- inplaceRestoreConfig: InplaceRestoreConfig
  - In-place restore configuration for the restore job.
- skipRifItems: System.Boolean
  - Specifies whether to skip items in the Recoverable Items folder.
