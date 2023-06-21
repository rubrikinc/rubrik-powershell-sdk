### MssqlDatabaseLiveMount
Live mount of a SQL Server database.

- fid: System.String
  - Forever ID of the live mount.
- cdmId: System.String
  - Internal ID of the live mount.
- mountedDatabaseId: System.String
  - Internal ID of the mounted database.
- mountedDatabaseName: System.String
  - Name of the mounted database.
- mountRequestId: System.String
  - ID of the database mount request job.
- unmountRequestId: System.String
  - ID of the database unmount request job.
- creationDate: DateTime
  - Timestamp when the mount was created.
- isReady: System.Boolean
  - Status of the live mount.
- recoveryPoint: DateTime
  - Recovery point of the live mount.
- ownerId: System.String
  - Owner ID of the live mount.
- targetInstance: MssqlInstance
  - Target instance of the live mount.
- sourceDatabase: MssqlDatabase
  - Source database of the live mount.
- cluster: Cluster
  - Cluster of the live mount.
