### NfAnomalyResultGroupedDataConnection
Paginated list of NfAnomalyResultGroupedData objects. Each page of the results will include at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- edges: list of NfAnomalyResultGroupedDataEdges
  - List of NfAnomalyResultGroupedData objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: list of NfAnomalyResultGroupedDatas
  - List of NfAnomalyResultGroupedData objects.
- pageInfo: PageInfo
  - General information about this page of results.
- count: System.Int32
  - Total number of NfAnomalyResultGroupedData objects matching the request arguments.
