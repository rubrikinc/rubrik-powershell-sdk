### AzureArmTemplatesByFeatureInput
Input for retrieving ARM templates for custom roles.

- cloudType: AzureCloudType
  - Azure cloud type.
- customerTenantDomainName: System.String
  - Domain name of the customer's Azure Tenant.
- features: a list of CloudAccountFeatures
  - Features to be enabled for the Azure Cloud Account.
- operationType: CloudAccountOperation
  - Azure cloud account operation type.
