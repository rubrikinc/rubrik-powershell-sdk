### SapHanaSystemCopyConfigInput
Supported in v9.4+

- sourceDbId: System.String
  - Required. Supported in v9.4+
ID of the source database.
- lssPassword: System.String
  - The Local Secure Store (LSS) backup encryption password for this specific database pair. Required when the source database backup was created with LSS encryption enabled.
- targetDbId: System.String
  - Required. Supported in v9.4+
ID of the target database.
