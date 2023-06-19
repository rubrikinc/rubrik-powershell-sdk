### BulkDeleteMosaicSourcesInput
Input for deleting NoSQL Protection sources in bulk.

- sourceType: V2BulkDeleteMosaicSourcesRequestSourceType
  - Type of sources to be deleted.
- clusterUuid: System.String
  - Required. UUID used to identify the cluster the request goes to.
- sourceData: BulkDeleteSourceRequestInput
  - Required. List of names of sources to be deleted.
