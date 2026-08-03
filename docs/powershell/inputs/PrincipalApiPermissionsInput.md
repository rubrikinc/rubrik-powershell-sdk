### PrincipalApiPermissionsInput
GetPrincipalApiPermissionsReq represents the request to retrieve API
permissions for a principal.

- principalId: System.String
  - Principal ID to query.
- timelineDate: System.String
  - Timeline date for the query.
Format: "YYYY-MM-DDTHH:MM:SS+00:00" (e.g., "2025-10-08T00:00:00+00:00").
- apiPermissionsSort: list of ListApiPermissionsSorts
  - Sort options for API permissions.
- apiPermissionsFilter: ApiPermissionsFilter
  - Specifies the filter to be applied when retrieving the API permissions.
