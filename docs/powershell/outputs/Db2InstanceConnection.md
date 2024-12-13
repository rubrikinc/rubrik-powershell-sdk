### Db2InstanceConnection
Paginated list of Db2Instance objects. Each page of the results includes at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- edges: list of Db2InstanceEdges
  - List of Db2Instance objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: list of Db2Instances
  - List of Db2Instance objects.
- pageInfo: PageInfo
  - General information about this result page.
- count: System.Int32
  - Total number of Db2Instance objects matching the request arguments.
