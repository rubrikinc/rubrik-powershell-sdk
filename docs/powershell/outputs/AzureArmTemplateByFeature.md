### AzureArmTemplateByFeature
ARM template for an Azure feature.

- feature: CloudAccountFeature
  - The cloud account feature.
- roleDefinitionAssignmentTemplate: System.String
  - Role definition assignment template.
- version: System.Int32
  - Template version.
- permissionsGroupVersions: list of PermissionsGroupWithVersions
  - Policy version for each permissions group used to generate the template.
- deploymentLevel: ArmTemplateDeploymentLevel
  - Whether the template should be deployed at the subscription or
resource group level.
