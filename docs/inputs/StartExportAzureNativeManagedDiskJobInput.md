### StartExportAzureNativeManagedDiskJobInput
Input for the job to export the specified Azure Native Managed Disk to the specified destination.

- destinationAvailabilityZone: System.String
  - Availability Zone in which to export the disk. It is empty for regions types which do not support availability zones.
- destinationRegion: AzureNativeRegion
  - Region in which the disk created after export will exist.
- destinationSubscriptionRubrikId: System.String
  - Rubrik ID of the subscription in which to export the disk. When empty, the disk is exported to same subscription.
- diskEncryptionSetNativeId: System.String
  - Native ID of the disk encryption set for encrypting the newly created disks.
- diskName: System.String
  - Name of the disk created after export.
- diskSize: System.Int32
  - Size of the disk created after export, in GiB.
- diskStorageTier: AzureNativeManagedDiskType
  - Type of the disk created after export.
- resourceGroup: System.String
  - Resource group to be associated with the disk created after export.
- shouldExportTags: System.Boolean
  - Specifies whether to export tags from the snapshot or not. When true, the tags from the snapshot are exported as well.
- shouldReplaceAttachedManagedDisk: System.Boolean
  - Specifies whether to run only the export job or to run both the export and replace jobs. When true, the attached managed disk is exported and replaced.
- shouldUseReplica: System.Boolean
  - Specifies whether to recover from the replica of the source snapshot or not. Default value is false.
- snapshotId: System.String
  - Snapshot ID of the snapshot with which the disk is to be exported.
- snapshotType: AzureSnapshotType
  - The type of the snapshot to recover from.
