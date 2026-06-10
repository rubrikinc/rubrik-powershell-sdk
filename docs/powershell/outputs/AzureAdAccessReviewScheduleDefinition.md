### AzureAdAccessReviewScheduleDefinition
Represents an access review schedule definition.

- displayName: System.String
  - Display name of the access review.
- resourceType: AzureAdObjectType
  - Type of resource being reviewed.
- resourceName: System.String
  - Display name of the resource being reviewed.
- resourceId: System.String
  - ID of the resource being reviewed.
- recurrence: AzureAdAccessReviewRecurrence
  - How often the review recurs.
- fallbackAction: AzureAdAccessReviewFallbackAction
  - Action taken when a reviewer does not respond.
- reviewers: list of AzureAdAccessReviewReviewers
  - Reviewers assigned to this access review.
- endDate: DateTime
  - Date when the review schedule ends.
