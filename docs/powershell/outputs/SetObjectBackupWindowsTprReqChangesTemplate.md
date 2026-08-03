### SetObjectBackupWindowsTprReqChangesTemplate
TPR requested changes template for setting an object-level backup window override.

- oldBackupWindowGroup: BackupWindowSpec
  - The existing object-level backup window override. It is unset when no override is configured and for multi-object requests.
- newBackupWindowGroup: BackupWindowSpec
  - The backup window group being applied by the request.
- templateName: System.String
  - Name of the requested changes template for quorum authorization.
