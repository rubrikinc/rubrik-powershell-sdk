### O365OauthConsentCompleteInput
Configuration for the completion of an O365 OAuth consent flow.

- tenantId: System.String
  - ID of the Microsoft 365 tenant.
- code: System.String
  - Authorization code for the consent flow.
- stateToken: System.String
  - CSRF token for the setup flow.
- redirectUrl: System.String
  - Redirect URL for the consent flow.
- resourceNaturalId: System.String
  - Natural ID of the resource.
