### MailboxRestoreConfig
Type representing the mailbox contents to be restored.

- SnapshotUUID: System.String
  - RSC ID of the snapshot you are restoring.
- RestoreConfigs: list of RestoreObjectConfigs
  - Configuration for the restore task.
- skipRifItems: System.Boolean
  - Specifies whether to skip items in the Recoverable Items folder.
