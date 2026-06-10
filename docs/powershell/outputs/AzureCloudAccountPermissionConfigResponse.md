### AzureCloudAccountPermissionConfigResponse
Permission version and the list of permissions required at the subscription
and resource group level for setting up an Azure subscription.

- permissionVersion: System.Int32
  - Permission version.
- rolePermissions: list of AzureCloudAccountRolePermissions
  - Permissions to be applied on the subscription level role.
- resourceGroupRolePermissions: list of AzureCloudAccountRolePermissions
  - Permissions to be applied on the resource group level role.
- permissionsGroupVersions: list of PermissionsGroupWithVersions
  - Permissions group versions.
