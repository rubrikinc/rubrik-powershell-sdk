### StartAzureAdAppSetupInput
Configuration to initiate Azure AD Application creation.

- domainName: System.String
  - Domain name of the MSFT tenant for which the application is being created.
- includeIntune: System.Boolean
  - Specifies whether Intune protection should be enabled.
- region: AzureAdRegion
  - Azure region name.
- azureAdApp: AzureAdApp
  - Azure AD application details.
- permissionAccessMode: PermissionAccessMode
  - Access mode for the Azure AD app.
