### AzureUpdateTenantForSubscriptionInput
Input for updating the tenant for the Azure Subscription.

- customerSubscriptionId: System.String
  - Cloud Account ID of the Azure Subscription whose tenant you want to update.
- tenantDomainName: System.String
  - New tenant domain name for the Azure subscription.
- cloudType: AzureCloudType
  - Type of the Azure Tenant. Possible values are Azure Public Cloud and Azure China Cloud.
