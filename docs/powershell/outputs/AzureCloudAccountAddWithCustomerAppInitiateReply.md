### AzureCloudAccountAddWithCustomerAppInitiateReply
Response from Azure cloud account addition initiation.

- success: System.Boolean
  - Indicates whether the operation was successful.
- subscriptions: list of CloudAccountsAzureSubscriptions
  - List of Azure subscriptions discovered in the tenant.
- sessionId: System.String
  - Session ID for tracking the OAuth flow.
