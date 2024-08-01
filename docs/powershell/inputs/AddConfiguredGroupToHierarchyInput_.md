### AddConfiguredGroupToHierarchyInput
Configuration for the addition of Configured Groups in O365.

- orgId: System.String
  - UUID of the org.
- displayName: System.String
  - The display name for the configured group.
- wildcard: System.String
  - The wildcard pattern configured for this group. When empty, group members will not be constrained on name or URL identifiers.
- pdls: list of System.Strings
  - The preferred data locations configured for this group. When empty, group members will not be constrained on data location. These are three-letter region codes as defined in Microsoft Azure.
- workload: WorkloadLevelHierarchy
  - The workload for the group.
- groupFilterAttributes: list of GroupFilterAttributes
  - The filters to narrow down group members based on attribute tags.For more information, see https://learn.microsoft.com/en-us/graph/extensibility-overview.
