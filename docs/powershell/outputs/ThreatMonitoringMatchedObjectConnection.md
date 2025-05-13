### ThreatMonitoringMatchedObjectConnection
Paginated list of ThreatMonitoringMatchedObject objects. Each page of the results includes at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- edges: list of ThreatMonitoringMatchedObjectEdges
  - List of ThreatMonitoringMatchedObject objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: list of ThreatMonitoringMatchedObjects
  - List of ThreatMonitoringMatchedObject objects.
- pageInfo: PageInfo
  - General information about this result page.
- count: System.Int32
  - Total number of ThreatMonitoringMatchedObject objects matching the request arguments.
- stats: ThreatMonitoringStats
  - Aggregated stats for threat monitoring.
