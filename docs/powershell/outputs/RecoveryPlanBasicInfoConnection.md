### RecoveryPlanBasicInfoConnection
Paginated list of RecoveryPlanBasicInfo objects. Each page of the results includes at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- edges: list of RecoveryPlanBasicInfoEdges
  - List of RecoveryPlanBasicInfo objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: list of RecoveryPlanBasicInfos
  - List of RecoveryPlanBasicInfo objects.
- pageInfo: PageInfo
  - General information about this result page.
- count: System.Int32
  - Total number of RecoveryPlanBasicInfo objects matching the request arguments.
