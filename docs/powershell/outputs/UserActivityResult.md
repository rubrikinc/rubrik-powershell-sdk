### UserActivityResult
Represents the activity for a specific user.

- user: AccessUser
  - The user that this result corresponds to.
- numActivities: System.Int64
  - The total number of activities this user had.
- numActivitiesBreakdown: list of ActivityResults
  - The total number of activities, grouped by activity type.
- paginationId: System.String
  - ID used for pagination.
