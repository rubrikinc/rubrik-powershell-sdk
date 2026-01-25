### StartAzureAdAppUpdateReply
Response for Entra ID app update initiation.

- csrfToken: System.String
  - State token to be used in CompleteAzureAdAppUpdate.
- appId: System.String
  - ID of the updated Azure AD app.
- missingPermissions: list of System.Strings
  - List of missing permissions for the Entra ID app.
- excessivePermissions: list of System.Strings
  - List of excessive permissions for the Entra ID app.
