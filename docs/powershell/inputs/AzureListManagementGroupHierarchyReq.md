### AzureListManagementGroupHierarchyReq
Request to list Azure management groups and subscriptions.

- sessionId: System.String
  - Session ID.
- tenantDomainName: System.String
  - Tenant domain name.
- cloudType: AzureCloudType
  - Cloud type.
- managementGroupId: System.String
  - Native ID of management group to be listed.
- features: list of CloudAccountFeatures
  - Features to be checked for eligibility.
- shouldRecurse: System.Boolean
  - Should recurse into child management groups. If
false, only immediate children are returned.
- scopedManagementGroupIds: list of System.Strings
  - Optional scoped child MG IDs. When non-empty,
returns hierarchy only under these IDs instead of
management_group_id. Must be descendants of
management_group_id. When empty, falls back to
management_group_id.
- operationType: CloudAccountOperation
  - Operation type: ADD (default), UPGRADE, or MIGRATE for which
the list is being requested.
- searchText: System.String
  - Search text to filter out any subscriptions or management
groups.
