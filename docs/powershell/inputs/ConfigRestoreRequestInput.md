### ConfigRestoreRequestInput
Supported in v7.0+

- isSourceSafe: System.Boolean
  - Supported in v7.0+
      If true, the snappables will not get disconnected from the source cluster during the configuration restore on the target cluster. However, some configuraions will not be restored on the target cluster.
- backupFileName: System.String
  - Required. Supported in v7.0+
      The name of the configuration backup file.
- customizedRestoreForm: CustomizedRestoreFormInput
  - Required. Supported in v7.0+
      Customized restore form along with secrets.
- encryptionPassword: System.String
  - Required. Supported in v7.0+
      Passphrase to decrypt the configuration backup.
