### UserFilterInput
Input for filtering a list of users.

- emailFilter: System.String
  - Filter users by email.
- domainFilter: list of UserDomainEnums
  - Filter users by domain type.
- orgIdsFilter: list of System.Strings
  - Filter users by organization ID.
- roleIdsFilter: list of System.Strings
  - Filter users that have the specified roles assigned in the current
 organization.
- lockoutStateFilter: LockoutStateFilter
  - Filter users by lockout state.
- hiddenStateFilter: HiddenStateFilter
  - Filter users by hidden status.
