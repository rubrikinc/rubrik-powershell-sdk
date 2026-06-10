### CompleteAzureDevOpsOauthInput
Contains parameters to complete the OAuth flow for an Azure DevOps cloud
account.

- sessionId: System.String
  - Session ID obtained from the startAzureCloudAccountOauth mutation
(with azureRubrikAppUseCase set to AZURE_DEVOPS).
- tenantDomainName: System.String
  - Azure AD tenant domain name (e.g., "contoso.onmicrosoft.com") that the
Azure DevOps organization is linked to.
- redirectUrl: System.String
  - The OAuth redirect URL that received the authorization code from Azure AD.
Must match the redirect URL registered in the Azure AD app.
- cloudType: AzureCloudType
  - Azure cloud environment --AZURE_PUBLIC_CLOUD, US_GOV_CLOUD, or
CHINA_CLOUD.
- keepRefreshToken: System.Boolean
  - Whether the OAuth refresh token should be retained for future use. Set to
true for persistent access; false if only a one-time operation is needed.
- organizationName: System.String
  - Azure DevOps organization name to validate access for after OAuth
completion (e.g., "my-org" from https://dev.azure.com/my-org). Optional --
when empty, the access check is skipped.
- azureDevopsAuthMethod: AzureDevopsAuthMethod
  - Auth method type used for Azure DevOps OAuth.
