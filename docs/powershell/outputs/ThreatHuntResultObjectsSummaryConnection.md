### ThreatHuntResultObjectsSummaryConnection
Paginated list of ThreatHuntResultObjectsSummary objects. Each page of the results includes at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- edges: list of ThreatHuntResultObjectsSummaryEdges
  - List of ThreatHuntResultObjectsSummary objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: list of ThreatHuntResultObjectsSummarys
  - List of ThreatHuntResultObjectsSummary objects.
- pageInfo: PageInfo
  - General information about this result page.
- count: System.Int32
  - Total number of ThreatHuntResultObjectsSummary objects matching the request arguments.
