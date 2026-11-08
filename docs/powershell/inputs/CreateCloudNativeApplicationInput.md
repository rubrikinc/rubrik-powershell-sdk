### CreateCloudNativeApplicationInput
Request body for creating a cloud native application.

- name: System.String
  - Application name.
- cloudNativeAccountId: System.String
  - Cloud native account ID where the application resides.
- targetCloudNativeAccountId: System.String
  - Target cloud native account ID for recovery.
- region: CloudRegionInput
  - Region where the application is deployed.
- serviceConfigured: ApplicationServiceConfigurationInput
  - Service configuration.
- cloudType: CloudServiceProvider
  - Cloud type of the application.
- resourceInclusionList: list of System.Strings
  - Resources (by ARN, the uri from GetAccountResourceDependencyGraph) to
explicitly include in this application. An alternative to matching_tags;
at least one of the two must be non-empty.
- resourceExclusionList: list of System.Strings
  - Resources (by ARN) to explicitly exclude from this application. An ARN in
both lists is excluded, and a resource with the rbrk_backup_exclude tag
is excluded even if it is in resource_inclusion_list.
- matchingTags: CreateApplicationMatchingTagInput
  - Tags used to match resources to this application. At least one of
matching_tags and resource_inclusion_list must be non-empty.
