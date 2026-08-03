### EntraIDGroupMetadataProperties
EntraIDGroupMetadataProperties holds additional properties for EntraID
groups.

- groupType: EntraIDGroupType
  - Specifies if the group is a Microsoft 365 or a security group.
- description: System.String
  - Describes the group's purpose.
- unprivilegedOwners: list of System.Strings
  - Lists the SIDs of the owners of the group who do not have privileged roles.
- containsGuestMember: System.Boolean
  - Specifies if the group contains a guest member.
- unprivilegedOwnersNames: list of System.Strings
  - Lists the names of the owners of the group who do not have privileged
roles.
- owners: list of EntraIDOwners
  - Lists all owners of the group.
- roleNames: list of System.Strings
  - List of role names that the group is assigned to if the group has
more than maxPrivilegedGroupMembers.
