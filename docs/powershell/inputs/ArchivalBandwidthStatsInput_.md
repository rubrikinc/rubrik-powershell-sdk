### ArchivalBandwidthStatsInput
Input for retrieving archival bandwidth stats.

- dataLocationId: System.String
  - Archival location ID. If this ID is not provided, bandwidth statistics are summed for all archival locations on the Rubrik cluster.
- range: System.String
  - Range for timeseries. eg: -1h, -1min, etc. Default value is -1h.
- bandwidthType: ArchivalBandwidthStatsRequestType
  - Archival bandwidth statistics type. Default is to sum the bandwidth of incoming and outgoing traffic.
- clusterUuid: System.String
  - Required. UUID used to identify to which Rubrik cluster the request is directed.
