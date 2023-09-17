### AzureArmTemplatesByFeatureInput
Input for retrieving ARM templates for custom roles.

- customerTenantDomainName: System.String
  - Domain name of the customer's Azure Tenant.
- features: list of CloudAccountFeatures
  - Deprecated, use featuresToInclude instead. Features to be enabled for the Azure cloud account.
- operationType: CloudAccountOperation
  - Azure cloud account operation type.
- cloudType: AzureCloudType
  - Azure cloud type.
- featuresToInclude: list of AzureRoleArmTemplateFeatures
  - Features and permissions groups used to determine the permissions to include in the templates.
