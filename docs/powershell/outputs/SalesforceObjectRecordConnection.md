### SalesforceObjectRecordConnection
Paginated list of SalesforceObjectRecord objects. Each page of the results will include at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- edges: list of SalesforceObjectRecordEdges
  - List of SalesforceObjectRecord objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: list of SalesforceObjectRecords
  - List of SalesforceObjectRecord objects.
- pageInfo: PageInfo
  - General information about this page of results.
- count: System.Int32
  - Total number of SalesforceObjectRecord objects matching the request arguments.
