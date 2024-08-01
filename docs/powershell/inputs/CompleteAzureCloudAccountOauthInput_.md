### CompleteAzureCloudAccountOauthInput
Input for completing authentication of the Azure Cloud Accounts.

- sessionId: System.String
  - Session ID of the current OAuth session.
- tenantDomainName: System.String
  - Domain name of the Azure Tenant.
- authorizationCode: System.String
  - Authorization code received after the OAuth consent flow. For more information, see https://auth0.com/docs/flows/authorization-code-flow.
- redirectUrl: System.String
  - Redirect URL used in the OAuth flow.
- features: list of CloudAccountFeatures
  - Features enabled on the Azure Cloud Account.
- appId: System.String
  - Client ID of the application. The appID is empty if the tenant uses a Rubrik app or a custom app.
- appSecretKey: System.String
  - Client secret key of the application. The appSecretKey is empty if the tenant uses a Rubrik app or a custom app.
- shouldSkipPermissionChecks: System.Boolean
  - Specifies whether to skip permission checks of Azure subscriptions required for addition.
- azureCloudType: AzureCloudType
  - Type of Azure Tenant. Possible values: Azure Public Cloud, Azure China Cloud.
- resource: AzureOauthResource
  - The resource that requires OAuth access.
- performBasicOauth: System.Boolean
  - Ensures that only basic OAuth is performed. The session will be stored in Rubrik, however, no additional information (such as list of subscriptions) is returned.
- shouldKeepRefreshToken: System.Boolean
  - Indicates whether the OAuth refresh token should be retained for future use.
