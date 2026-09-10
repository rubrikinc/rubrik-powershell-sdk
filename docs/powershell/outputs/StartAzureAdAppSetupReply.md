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
- missingM365Permissions: list of System.Strings
  - Lists the missing M365 permissions (Exchange Online / SharePoint Online)
required for Automated M365 Access Recovery.
- isExchangeAdminRoleAssigned: System.Boolean
  - Indicates whether the app's service principal already holds the Exchange
Administrator directory role, as observed at setup kickoff. A
customer-hosted app requires the tenant admin to grant the role; it is not
granted by consent.
