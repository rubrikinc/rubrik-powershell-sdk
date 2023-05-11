### SearchSnapMirrorCloudInput
Input for searching a file within the SnapMirror Cloud workload.

- cursor: System.String
  - Pagination cursor returned by the previous request.
- id: System.String
  - Required. The Rubrik ID of the SnapMirrorCloud to search.
- limit: System.Int32
  - Maximum number of entries in the response.
- path: System.String
  - Required. The path query. Either path prefix or filename prefix.
