### GithubOrganizationConnection
Paginated list of GithubOrganization objects. Each page of the results includes at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- edges: list of GithubOrganizationEdges
  - List of GithubOrganization objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: list of GithubOrganizations
  - List of GithubOrganization objects.
- pageInfo: PageInfo
  - General information about this result page.
- count: System.Int32
  - Total number of GithubOrganization objects matching the request arguments.
