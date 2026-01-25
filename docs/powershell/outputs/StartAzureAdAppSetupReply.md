### StartAzureAdAppSetupReply
Response of the operation that initiates onboarding of Azure AD.

- csrfToken: System.String
  - State token to be used in CompleteAzureAdAppSetupReply.
- appId: System.String
  - ID of the created Azure AD app.
- warning: AzureAdAppSetupWarningType
  - A warning message indicating a unrecommended onboarding scenario.
- tenantCloudType: AzureCloudType
  - Cloud type of the Entra ID tenant.
- missingPermissions: list of System.Strings
  - List of missing permissions for the Entra ID app.
- excessivePermissions: list of System.Strings
  - List of excessive permissions for the Entra ID app.
