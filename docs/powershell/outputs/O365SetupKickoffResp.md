### O365SetupKickoffResp
O365 setup kickoff response.

- appClientId: System.String
  - The Exchange app client ID for the singular app type UI flow. This is to be deprecated in favor of field 3.
- csrfToken: System.String
  - The CSRF token.
- appClientIdsPerType: list of AppIdForTypes
  - The app client IDs per type.
