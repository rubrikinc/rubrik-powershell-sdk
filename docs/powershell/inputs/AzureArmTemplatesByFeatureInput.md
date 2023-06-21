### AzureArmTemplatesByFeatureInput
Input for retrieving ARM templates for custom roles.

- customerTenantDomainName: System.String
  - Domain name of the customer's Azure Tenant.
- features: list of CloudAccountFeatures
  - Features to be enabled for the Azure Cloud Account.
- operationType: CloudAccountOperation
  - Azure cloud account operation type.
- cloudType: AzureCloudType
  - Azure cloud type.
