### AzureCloudAccountTenantApp
AzureCloudAccountTenantApp describes a single Azure application configured on
a tenant, together with the authentication method it is bound to. A
mixed-auth tenant surfaces one entry per auth type.

- authType: AzureAuthType
  - The authentication method this app is bound to.
- appName: System.String
  - App name of the Azure application.
- clientId: System.String
  - Client (app) ID of the Azure application.
