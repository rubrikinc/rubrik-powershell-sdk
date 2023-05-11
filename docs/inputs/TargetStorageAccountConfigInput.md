### TargetStorageAccountConfigInput
Input required to upload a database snapshot to an Azure storage account.

- resourceGroupName: System.String
  - Resource group name of the storage account.
- storageAccountName: System.String
  - Storage account name where database snapshot will be uploaded.
- subscriptionCloudAccountId: System.String
  - Cloud account ID of the target storage account's subscription.
- tags: TagsInput
  - Tags for the storage account. If storage account already exists, these tags are ignored and existing tags will be retained.
