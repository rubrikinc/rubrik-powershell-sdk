### StartAzureAdAppUpdateInput
Configuration to initiate an update to the Azure AD directory app.

- workloadFid: System.String
  - Workload FID of the Azure AD directory to update.
- azureAdApp: AzureAdApp
  - Azure AD application details.
- permissionAccessMode: PermissionAccessMode
  - Access mode for the Azure AD app.
- missingObjectTypes: list of AzureAdObjectTypes
  - List of object types to add write permissions for.
- includeIntune: System.Boolean
  - Specifies whether Intune protection should be enabled.
- m365AccessRecoveryConfig: M365AccessRecoveryConfig
  - Specifies the Automated M365 Access Recovery configuration for the
directory. An absent configuration leaves the directory's stored state
untouched, so an update that does not carry a configuration cannot change
one.
