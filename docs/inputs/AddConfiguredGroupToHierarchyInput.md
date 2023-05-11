### AddConfiguredGroupToHierarchyInput
Configuration for the addition of Configured Groups in O365.

- displayName: System.String
  - The display name for the configured group.
- orgId: System.String
  - UUID of the org.
- pdls: a list of System.Strings
  - The preferred data locations configured for this group. When empty, group members will not be constrained on data location. These are three-letter region codes as defined in Microsoft Azure.
- wildcard: System.String
  - The wildcard pattern configured for this group. When empty, group members will not be constrained on name or URL identifiers.
