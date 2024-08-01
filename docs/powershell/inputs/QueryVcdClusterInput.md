### QueryVcdClusterInput
Input for querying vCD clusters.

- name: System.String
  - Search for a vCD Cluster object by name.
- hostname: System.String
  - Search for a vCD cluster object by hostname.
- sortBy: QueryVcdClusterRequestSortBy
  - Attribute to sort the results.
- sortOrder: QueryVcdClusterRequestSortOrder
  - Order for sorting the results, either ascending or descending.
- status: QueryVcdClusterRequestStatus
  - Filter the results using the status value of the vCD Cluster objects.
- clusterUuid: System.String
  - Required. UUID used to identify the cluster the request goes to.
