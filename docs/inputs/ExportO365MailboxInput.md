### ExportO365MailboxInput
Configuration for O365 mailbox export.

- exportConfigs: a list of RestoreObjectConfigs
  - Configuration for restore job.
- fromMailboxUuid: System.String
  - Polaris ID of the source mailbox.
- orgUuid: System.String
  - Polaris ID of O365 subscription.
- snapshotUuid: System.String
  - Polaris ID of restoring snapshot.
- toMailboxUuid: System.String
  - Polaris ID of the destination mailbox.
