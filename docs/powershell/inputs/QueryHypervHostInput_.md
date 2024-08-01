### QueryHypervHostInput
Input for getting the summary of all Hyper-V hosts.

- effectiveSlaDomainId: System.String
  - Filter by ID of effective SLA domain.
- limit: System.Int32
  - Limit the number of matches returned.
- name: System.String
  - Search for a virtual machine by name.
- offset: System.Int32
  - Ignore these many matches in the beginning.
- primaryClusterId: System.String
  - Filter by primary cluster ID, or **local**.
- slaAssignment: InternalQueryHypervHostRequestSlaAssignment
  - Filter by SLA assignment type.
- sortBy: InternalQueryHypervHostRequestSortBy
  - Sort the result by the given attribute.
- sortOrder: InternalQueryHypervHostRequestSortOrder
  - Sort order, either ascending or descending.
- clusterUuid: System.String
  - Required. UUID used to identify the cluster the request goes to.
