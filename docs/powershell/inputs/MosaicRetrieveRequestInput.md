### MosaicRetrieveRequestInput
Supported in m3.2.0-m4.2.0
Request object for retrieve request on mosaic.

- destinationManagementObjects: MosaicDatabaseManagementObjectInput
  - Supported in m3.2.0-m4.2.0
Destination Management objects for retrieve.
- destinationPath: System.String
  - Required. Supported in m3.2.0-m4.2.0
Destination path for restore.
- destinationSourceName: System.String
  - Supported in m3.2.0-m4.2.0
m3.2.0-m4.0.1: Source name for destination (restore).
m4.1.0-m4.2.0: Destination source name for retrieve.
- keyspaceConfig: System.String
  - Supported in m3.2.0-m4.2.0
Keyspace config.
- managementObjects: MosaicDatabaseManagementObjectInput
  - Required. Supported in m3.2.0-m4.2.0
Source Management objects.
- maxDiskUsage: System.String
  - Supported in m3.2.0-m4.2.0
Max disk usage.
- parameterEncoded: System.Boolean
  - Required. Supported in m3.2.0-m4.2.0
m3.2.0-m4.0.1: If the parameter is encoded.
m4.1.0-m4.2.0: If parameter is encoded.
- restoreDbUserPwd: System.String
  - Supported in m3.2.0-m4.2.0
m3.2.0-m4.0.1: Restore db password.
m4.1.0-m4.2.0: Db password of database to restore to.
- restoreDbUsername: System.String
  - Supported in m3.2.0-m4.2.0
m3.2.0-m4.0.1: Restore db username.
m4.1.0-m4.2.0: Db name of database to restore to.
- sourceName: System.String
  - Required. Supported in m3.2.0-m4.2.0
Name of the source.
- startTimestamp: System.Int32
  - Supported in m3.2.0-m4.2.0
Start timestamp.
- targetEncryptionKey: System.String
  - Supported in m3.2.0-m4.2.0
Target encryption key.
- targetQuery: System.String
  - Supported in m3.2.0-m4.2.0
Target query.
- versionTime: System.Int32
  - Required. Supported in m3.2.0-m4.2.0
Timestamp of the version.
- sourceType: MosaicRetrieveRequestSourceType
  - Supported in m4.1.0-m4.2.0
Source type.
