### StartRecoverAzureNativeStorageAccountJobInput
Input for the job to recover storage account or blobs using storage account snapshot.

- snapshotId: System.String
  - Snapshot ID of the snapshot with which the storage account or blobs is to be recovered.
- destinationSubscriptionRubrikId: System.String
  - Rubrik ID of subscription to which storage accounts or blob needs to be recovered.
- shouldExportTags: System.Boolean
  - Whether to export tags to the recovered storage account.
- name: System.String
  - Name of the storage account we need to recover to. This should not be passed or should be empty in case of recovery to source storage account.
- region: AzureNativeRegion
  - Region of storage account, if not already exists.
- resourceGroupName: System.String
  - Resource group to be associated with the storage account created after export, if not already exists.
- objectKeys: list of System.Strings
  - Object keys to be provided for recovery. It should only be populated in case of blob or container level recovery.
- tier: AzureStorageAccessTier
  - Access tier of blobs to be recovered. Only supported tier are hot and cool.
