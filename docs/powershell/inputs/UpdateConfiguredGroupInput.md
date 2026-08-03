### UpdateConfiguredGroupInput
Configuration for the update of a configured group in O365.

- orgId: System.String
  - UUID of the org.
- groupId: System.String
  - ID of the configured group to be updated.
- updatedDisplayName: System.String
  - The updated display name for the configured group. Empty string means no update.
- updatedWildcard: System.String
  - The updated wildcard pattern for the configured group. Empty string means no update.
- updatedPdls: list of System.Strings
  - The updated preferred data locations configured for this group. When empty, group members will not be constrained on data location.
- updatedGroupFilterAttributes: list of GroupFilterAttributes
  - The updated group filter attributes for the configured group.
- performArchival: System.Boolean
  - When true, the group will be archived.
