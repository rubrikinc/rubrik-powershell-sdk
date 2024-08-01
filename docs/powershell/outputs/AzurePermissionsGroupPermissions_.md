### AzurePermissionsGroupPermissions
Permissions belonging to a permissions group.

- permissionsGroup: PermissionsGroup
  - Azure cloud account permissions group.
- subscriptionPermissions: list of AzureCloudAccountRolePermissions
  - Permissions required at the subscription level.
- resourceGroupPermissions: list of AzureCloudAccountRolePermissions
  - Permissions required at the resource group level.
- version: System.Int32
  - Version of the permissions group.
