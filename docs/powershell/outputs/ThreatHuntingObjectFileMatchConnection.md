### ThreatHuntingObjectFileMatchConnection
Paginated list of ThreatHuntingObjectFileMatch objects. Each page of the results includes at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- edges: list of ThreatHuntingObjectFileMatchEdges
  - List of ThreatHuntingObjectFileMatch objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: list of ThreatHuntingObjectFileMatchs
  - List of ThreatHuntingObjectFileMatch objects.
- pageInfo: PageInfo
  - General information about this result page.
- count: System.Int32
  - Total number of ThreatHuntingObjectFileMatch objects matching the request arguments.
