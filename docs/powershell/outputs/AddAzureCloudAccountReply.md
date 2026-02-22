### AddAzureCloudAccountReply
Response of the operation to add an Azure Cloud Account.

- status: list of AddAzureCloudAccountStatuss
  - Status of the operation to add Azure Cloud Account.
- tenantId: System.String
  - Tenant ID for the added subscriptions.
- entraIdGroupStatus: AzureEntraIdGroupStatus
  - Status of the Entra ID group for the added Azure Cloud Account.
- taskchainUuid: System.String
  - UUID of the taskchain for the management group bulk onboard job.
