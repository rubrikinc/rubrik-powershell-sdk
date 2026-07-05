### ListAccessUsersFilterInput
Filter applied when listing access users.

- groupsIds: list of System.Strings
  - List of group IDs. Returns users belonging to at least one of these groups.
- timeRange: UserTimeRangeInput
  - Aggregate over the supplied time range.
- search: System.String
  - Filter usernames by prefix.
