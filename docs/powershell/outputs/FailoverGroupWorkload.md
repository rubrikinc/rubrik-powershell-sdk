### FailoverGroupWorkload
Information about a workload in a failover group.

- workloadId: System.String
  - Workload ID.
- name: System.String
  - Name of the workload.
- workloadType: FlexmotionWorkloadType
  - Type of the workload.
- managedObjectType: ManagedObjectType
  - Type of the workload.
- status: FailoverGroupObjectStatus
  - Status of the workload.
- statusMessage: System.String
  - Status message providing additional details.
- primaryClusterUuid: System.String
  - Primary cluster UUID.
- hostIds: list of System.Strings
  - List of host FIDs associated with this workload.
- counterpartIds: list of System.Strings
  - List of counterpart workload IDs on other clusters.
- hostNames: list of System.Strings
  - List of host names for the hosts associated with this workload.
- location: System.String
  - Display name of the parent object that defines the workload's location
(SQL Server instance name for MSSQL databases, host name for filesets).
- locationId: System.String
  - FID of the parent object that defines the location (e.g., SQL instance FID).
