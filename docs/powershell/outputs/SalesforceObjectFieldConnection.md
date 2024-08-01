### SalesforceObjectFieldConnection
Paginated list of SalesforceObjectField objects. Each page of the results will include at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- edges: list of SalesforceObjectFieldEdges
  - List of SalesforceObjectField objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: list of SalesforceObjectFields
  - List of SalesforceObjectField objects.
- pageInfo: PageInfo
  - General information about this page of results.
- count: System.Int32
  - Total number of SalesforceObjectField objects matching the request arguments.
