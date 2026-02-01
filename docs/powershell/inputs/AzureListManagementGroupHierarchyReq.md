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
  - Should recurse into child management groups. If false, only immediate
children are returned.
