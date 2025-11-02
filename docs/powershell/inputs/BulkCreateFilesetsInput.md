### BulkCreateFilesetsInput
Input for creating multiple filesets.

- definitions: list of FilesetCreateInputs
  - Required. For each fileset, specify a template id along with either host id or share id. If a share id is provided, the host id will be inferred from the host share.
- clusterUuid: System.String
  - Required. UUID used to identify the cluster the request goes to.
