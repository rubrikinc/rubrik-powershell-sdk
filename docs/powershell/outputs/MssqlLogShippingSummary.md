### MssqlLogShippingSummary
Supported in v5.0+

- id: System.String
  - Required. Supported in v5.0+
v5.0-v5.2: The ID assigned to the log shipping configuration object.
v5.3+: ID assigned to the log shipping configuration object.
- lagTime: System.Int64
  - Supported in v5.0+
v5.0-v5.2: The number of milliseconds between the time the latest backup was applied to the secondary database and when that backup was taken on the primary database.
v5.3+: Number of milliseconds elapsed since the latest backup was applied to the secondary database and the time the backup was taken on the primary database.
- lastAppliedPoint: DateTime
  - Supported in v5.0+
v5.0-v5.2: The timestamp of the last transaction that was applied using the specified log shipping configuration object.
v5.3+: Timestamp of the last transaction applied using the specified log shipping configuration object.
- location: System.String
  - Required. Supported in v5.0+
v5.0-v5.2: The location of a specified secondary database in the format "host/instance".
v5.3+: Location of a specified secondary database. Location uses this format: "host/instance".
- primaryDatabaseId: System.String
  - Required. Supported in v5.0+
v5.0-v5.2: The ID of the primary database.
v5.3+: ID of the primary database.
- primaryDatabaseName: System.String
  - Required. Supported in v5.0+
v5.0-v5.2: The name of the primary database.
v5.3+: Name of the primary database.
- secondaryDatabaseId: System.String
  - Supported in v5.0+
v5.0-v5.2: The ID of the secondary database.
v5.3+: ID of the secondary database.
- secondaryDatabaseName: System.String
  - Required. Supported in v5.0+
v5.0-v5.2: The name of the secondary database.
v5.3+: Name of the secondary database.
- state: System.String
  - Supported in v5.0+
The current state of the secondary database.
- status: MssqlLogShippingStatusInfo
  - Required. Supported in v5.0+
- primaryDatabaseLogBackupFrequency: System.Int64
  - Supported in v5.2+
v5.2: Configured log backup frequency of the primary database, in seconds.
v5.3+: Log backup frequency, in seconds, of the primary database.
