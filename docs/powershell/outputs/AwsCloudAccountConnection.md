### AwsCloudAccountConnection
Paginated list of AwsCloudAccount objects. Each page of the results includes at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- edges: list of AwsCloudAccountEdges
  - List of AwsCloudAccount objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: list of AwsCloudAccounts
  - List of AwsCloudAccount objects.
- pageInfo: PageInfo
  - General information about this result page.
- count: System.Int32
  - Total number of AwsCloudAccount objects matching the request arguments.
