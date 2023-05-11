### MssqlDatabaseLiveMount
Live mount of a SQL Server database.

- cdmId: System.String
  - Internal ID of the live mount.
- cluster: Cluster
  - Cluster of the live mount.
- creationDate: DateTime
  - Timestamp when the mount was created.
- fid: System.String
  - Forever ID of the live mount.
- isReady: System.Boolean
  - Status of the live mount.
- mountRequestId: System.String
  - ID of the database mount request job.
- mountedDatabaseId: System.String
  - Internal ID of the mounted database.
- mountedDatabaseName: System.String
  - Name of the mounted database.
- ownerId: System.String
  - Owner ID of the live mount.
- recoveryPoint: DateTime
  - Recovery point of the live mount.
- sourceDatabase: MssqlDatabase
  - Source database of the live mount.
- targetInstance: MssqlInstance
  - Target instance of the live mount.
- unmountRequestId: System.String
  - ID of the database unmount request job.
