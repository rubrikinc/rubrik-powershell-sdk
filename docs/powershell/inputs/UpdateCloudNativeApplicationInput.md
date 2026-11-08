### UpdateCloudNativeApplicationInput
Request to update a cloud native application.

- id: System.String
  - Managed Object ID.
- name: System.String
  - Application name.
- targetCloudNativeAccountId: System.String
  - Cloud account ID for recovery account.
- serviceConfigured: ApplicationServiceConfigurationInput
  - Application Service configuration.
- postRecoveryScriptConfigured: System.Boolean
  - SSM script configured for post recovery operations.
Nullable bool - if not set (nil), the field will not be updated.
- resourceInclusionList: ResourceUriList
  - When set, replaces the resources (by ARN, the uri from
GetAccountResourceDependencyGraph) explicitly included in this
application. An empty list clears it. If not set, the stored list is
not updated.
- resourceExclusionList: ResourceUriList
  - When set, replaces the resources (by ARN) explicitly excluded from this
application. An empty list clears it. If not set, the stored list is not
updated.
- matchingTags: UpdateApplicationMatchingTagInput
  - Tags used to match resources for this application.
