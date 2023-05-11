### UserFilterInput
Input for filtering a list of users.

- domainFilter: a list of UserDomainEnums
  - Filter users by domain type.
- emailFilter: System.String
  - Filter users by email.
- hiddenStateFilter: HiddenStateFilter
  - Filter users by hidden status.
- lockoutStateFilter: LockoutStateFilter
  - Filter users by lockout state.
- orgIdsFilter: a list of System.Strings
  - Filter users by organization ID.
- roleIdsFilter: a list of System.Strings
  - Filter users that have the specified roles assigned in the current
 organization.
