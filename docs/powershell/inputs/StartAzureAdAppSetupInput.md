### StartAzureAdAppSetupInput
Configuration to initiate Azure AD Application creation.

- domainName: System.String
  - Domain name of the MSFT tenant for which the application is being created.
- region: AzureAdRegion
  - Azure region name.
- azureAdApp: AzureAdApp
  - Azure AD application details.
- permissionAccessMode: PermissionAccessMode
  - Access mode for the Azure AD app.
- includeIntune: System.Boolean
  - Specifies whether Intune protection should be enabled.
- m365AccessRecoveryConfig: M365AccessRecoveryConfig
  - Specifies the Automated M365 Access Recovery configuration for the directory
being onboarded. An absent configuration onboards the directory in the
default state.
