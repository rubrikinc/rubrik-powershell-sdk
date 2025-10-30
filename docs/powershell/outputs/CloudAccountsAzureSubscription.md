### CloudAccountsAzureSubscription
AzureSubscription is a representation of the native Azure subscription.

- nativeId: System.String
  - Azure Native ID of the subscription.
- name: System.String
  - Name of the subscription.
- isAuthorized: System.Boolean
  - Authorization status to perform CRUD actions on the subscription.
- customerSubscriptionId: System.String
  - Customer subscription ID.
- customerTenantId: System.String
  - Tenant ID of the subscription.
- cloudType: AzureCloudType
  - Cloud type in which the subscription is present.
