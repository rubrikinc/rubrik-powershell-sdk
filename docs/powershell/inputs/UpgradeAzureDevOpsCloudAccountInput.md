### UpgradeAzureDevOpsCloudAccountInput
Contains parameters to upgrade an existing Azure DevOps cloud account
configuration with additional features or permission groups.

- organizationId: System.String
  - RSC-assigned UUID of the Azure DevOps organization to upgrade.
- sessionId: System.String
  - Session ID obtained from the startAzureCloudAccountOauth mutation. Use
the same session ID that was passed to completeAzureDevOpsOauth.
- featuresToUpgrade: list of FeatureWithPermissionsGroupss
  - Features and permission groups to add to the organization.
