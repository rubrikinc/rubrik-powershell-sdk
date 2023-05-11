### UpdateConfiguredGroupInput
Configuration for the update of a configured group in O365.

- groupId: System.String
  - ID of the configured group to be updated.
- orgId: System.String
  - UUID of the org.
- performArchival: System.Boolean
  - When true, the group will be archived.
- updatedDisplayName: System.String
  - The updated display name for the configured group.
- updatedPdls: a list of System.Strings
  - The updated preferred data locations configured for this group. When empty, group members will not be constrained on data location.
- updatedWildcard: System.String
  - The updated wildcard pattern configured for this group. When empty, group members will not be constrained on name or URL identifiers.
