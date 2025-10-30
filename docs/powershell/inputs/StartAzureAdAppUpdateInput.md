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
