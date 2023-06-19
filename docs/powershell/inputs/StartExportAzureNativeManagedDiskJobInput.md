### StartExportAzureNativeManagedDiskJobInput
Input for the job to export the specified Azure Native Managed Disk to the specified destination.

- snapshotId: System.String
  - Snapshot ID of the snapshot with which the disk is to be exported.
- diskName: System.String
  - Name of the disk created after export.
- diskEncryptionSetNativeId: System.String
  - Native ID of the disk encryption set for encrypting the newly created disks.
- diskStorageTier: AzureNativeManagedDiskType
  - Type of the disk created after export.
- diskSize: System.Int32
  - Size of the disk created after export, in GiB.
- resourceGroup: System.String
  - Resource group to be associated with the disk created after export.
- destinationRegion: AzureNativeRegion
  - Region in which the disk created after export will exist.
- destinationAvailabilityZone: System.String
  - Availability Zone in which to export the disk. It is empty for regions types which do not support availability zones.
- destinationSubscriptionRubrikId: System.String
  - Rubrik ID of the subscription in which to export the disk. When empty, the disk is exported to same subscription.
- shouldExportTags: System.Boolean
  - Specifies whether to export tags from the snapshot or not. When true, the tags from the snapshot are exported as well.
- shouldReplaceAttachedManagedDisk: System.Boolean
  - Specifies whether to run only the export job or to run both the export and replace jobs. When true, the attached managed disk is exported and replaced.
- shouldUseReplica: System.Boolean
  - Specifies whether to recover from the replica of the source snapshot or not. Default value is false.
- snapshotType: AzureSnapshotType
  - The type of the snapshot to recover from.
