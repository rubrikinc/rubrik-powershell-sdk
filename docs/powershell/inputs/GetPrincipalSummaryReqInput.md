### GetPrincipalSummaryReqInput
Represents the request to retrieve the principal summary.

- principalId: System.String
  - Specifies the principal ID to filter by.
- timelineDate: System.String
  - Specifies the date for retrieving the principal summary.
- historicalDeltaDays: System.Int32
  - Specifies the number of days in the past from the provided date to compute
deltas (optional).
- insightsMarkerRequested: System.Boolean
  - Indicates whether to augment the insights marker.
- featureFilter: PrincipalFeature
  - Specifies the feature to filter by.
- apiPermissionsSort: list of ListApiPermissionsSorts
  - Specifies the sort to be applied when retrieving the API permissions.
