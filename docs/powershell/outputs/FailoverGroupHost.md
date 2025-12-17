### FailoverGroupHost
Information about a host in a failover group.

- hostId: System.String
  - Host ID.
- hostName: System.String
  - Name of the host.
- hostType: HostRegisterOsType
  - Type of the host.
- hostStatus: FailoverGroupStatus
  - Status of the host.
- numberOfObjects: System.Int32
  - Number of workloads under this host.
- activeClusterUuid: System.String
  - Active cluster UUID where this host is currently active.
- counterpartIds: list of System.Strings
  - List of counterpart host IDs on other clusters.
