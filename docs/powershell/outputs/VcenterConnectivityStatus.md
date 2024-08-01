### VcenterConnectivityStatus
Supported in v7.0+
  Connectivity status of the vCenter server.

- jobId: System.String
  - Supported in v7.0+
  The ID of refresh job used to poll the status.
- lastUpdatedTime: DateTime
  - Supported in v7.0+
  Field containing the last updated time for the status.
- vcenterConnection: HostConnectionStatusType
  - The connection status of the ESXi host.
- esxiHosts: list of EsxiHostConnectivityStatuss
  - Required. Supported in v7.0+
