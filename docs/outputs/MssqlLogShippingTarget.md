### MssqlLogShippingTarget
SQL Server log shipping target.

- cdmId: System.String
  - Internal ID of the log shipping target.
- cluster: Cluster
  - Cluster of the log shipping target.
- fid: System.String
  - Forever ID of the log shipping target.
- lagTimeFromPrimary: System.Int64
  - Lag time of the log shipping target.
- lastAppliedPoint: DateTime
  - Last applied point of the log shipping target.
- location: System.String
  - Location of the log shipping target.
- logFrequency: System.Int64
  - Frequency that the primary database takes log backups.
- primaryCluster: Cluster
  - Primary cluster of the log shipping target.
- primaryDatabase: MssqlDatabase
  - Primary database of the log shipping target.
- secondaryDatabase: MssqlDatabase
  - Secondary database of the log shipping target.
- secondaryInstance: MssqlInstance
  - Secondary instance of the log shipping target.
- state: System.String
  - State of the log shipping target.
- status: System.String
  - Status of the log shipping target.
