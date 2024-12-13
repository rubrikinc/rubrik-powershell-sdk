### NfAnomalyResultConnection
Paginated list of NfAnomalyResult objects. Each page of the results includes at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- edges: list of NfAnomalyResultEdges
  - List of NfAnomalyResult objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: list of NfAnomalyResults
  - List of NfAnomalyResult objects.
- pageInfo: PageInfo
  - General information about this result page.
- count: System.Int32
  - Total number of NfAnomalyResult objects matching the request arguments.
