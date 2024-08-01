### SearchSnapMirrorCloudInput
Input for searching a file within the SnapMirror Cloud workload.

- cursor: System.String
  - Pagination cursor returned by the previous request.
- limit: System.Int32
  - Maximum number of entries in the response.
- id: System.String
  - Required. The Rubrik ID of the SnapMirrorCloud to search.
- path: System.String
  - Required. The path query. Either path prefix or filename prefix.
