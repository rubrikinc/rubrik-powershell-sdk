### StartRecoverAzureNativeStorageAccountJobInput
Input for the job to recover azure storage account or blobs using storage account snapshot.

- snapshotId: System.String
  - Snapshot ID of the snapshot with which the azure storage account or blobs are to be recovered.
- destinationSubscriptionRubrikId: System.String
  - Rubrik ID of the azure subscription to which storage accounts or blob needs to be recovered.
- shouldExportTags: System.Boolean
  - Whether to export tags to the recovered storage account.
- name: System.String
  - Name of the azure storage account to which we need to recover. This should not be provided or should be left empty in the case of recovery to the source storage account.
- region: AzureNativeRegion
  - Region of azure storage account, if not already exists.
- resourceGroupName: System.String
  - Resource group to be associated with the azure storage account created after export, if not already exists.
- objectKeys: list of System.Strings
  - Object keys to be provided for recovery. It should only be populated in case of blob or container level recovery.
- tier: AzureStorageAccessTier
  - Access tier of the blobs to be recovered. The only supported tier are hot and cool.
