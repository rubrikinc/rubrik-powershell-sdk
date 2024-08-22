### RestoreObjectConfig
Configuration for the mailbox object (email/folder) to be restored.

- SnapshotUUID: System.String
  - UUID of the snapshot for recovery.
- EmailID: System.String
  - ID of the email to restore.
- FolderID: System.String
  - ID of the folder to restore.
- hierarchyType: ExchangeItemHierarchyType
  - Specify the hierarchy type of the mailbox object to be restored, whether it is an email or a folder.
- parentFolderId: System.String
  - ID of the parent folder of the mailbox object being restored, whether the object is an email or a folder.
