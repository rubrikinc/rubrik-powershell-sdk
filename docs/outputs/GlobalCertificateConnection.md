### GlobalCertificateConnection
Paginated list of GlobalCertificate objects. Each page of the results will include at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- count: System.Int32
  - Total number of GlobalCertificate objects matching the request arguments.
- edges: a list of GlobalCertificateEdges
  - List of GlobalCertificate objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: a list of GlobalCertificates
  - List of GlobalCertificate objects.
- pageInfo: PageInfo
  - General information about this page of results.
