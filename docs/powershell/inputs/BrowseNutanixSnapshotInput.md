### BrowseNutanixSnapshotInput
Input for browsing Nutanix snapshots.

- id: System.String
  - Required. ID of snapshot.
- limit: System.Int32
  - Maximum number of entries in the response.
- offset: System.Int32
  - Starting position in the list of path entries contained in the query results, sorted by lexicographical order. The response includes the specified numbered entry and all higher numbered entries.
- path: System.String
  - Required. The absolute path of the starting point for the directory listing.
