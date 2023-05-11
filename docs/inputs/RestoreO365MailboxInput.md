### RestoreO365MailboxInput
Configuration for O365 mailbox restore.

- actionType: O365RestoreActionType
  - Specifies the recovery type for the job.
- mailboxUuid: System.String
  - Polaris ID of the mailbox.
- orgUuid: System.String
  - Polaris ID of O365 subscription.
- restoreConfigs: a list of RestoreObjectConfigs
  - Configuration for restore job.
- snapshotUuid: System.String
  - Polaris ID of restoring snapshot.
