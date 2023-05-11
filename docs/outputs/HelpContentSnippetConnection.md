### HelpContentSnippetConnection
Paginated list of HelpContentSnippet objects. Each page of the results will include at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- count: System.Int32
  - Total number of HelpContentSnippet objects matching the request arguments.
- edges: a list of HelpContentSnippetEdges
  - List of HelpContentSnippet objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: a list of HelpContentSnippets
  - List of HelpContentSnippet objects.
- pageInfo: PageInfo
  - General information about this page of results.
