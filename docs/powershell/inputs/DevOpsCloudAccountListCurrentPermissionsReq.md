### DevOpsCloudAccountListCurrentPermissionsReq
Contains parameters to list the currently configured permissions for a
DevOps cloud account organization. Use this to verify which permissions are
already granted before performing operations like backup or recovery.

- organizationId: System.String
  - RSC-assigned UUID of the DevOps organization (Azure DevOps or GitHub).
- featuresWithPermissionsGroups: list of FeatureWithPermissionsGroupss
  - Features and permission groups to query permissions for.
