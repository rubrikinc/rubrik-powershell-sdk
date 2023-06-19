### AzureArmTemplateByFeature
Custom role ARM template corresponding to the feature.

- feature: CloudAccountFeature
  - Cloud native protections features.
- roleDefinitionAssignmentTemplate: System.String
  - The template required for supporting the feature specified by the feature field. During the upgrade operation, only the role definition template is returned.
- version: System.Int32
  - Policy permission version to be used for adding and upgrading the subscription.
