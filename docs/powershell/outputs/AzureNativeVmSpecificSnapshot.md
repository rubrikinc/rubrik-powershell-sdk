### AzureNativeVmSpecificSnapshot
Azure VM-specific snapshot information.

- osDiskSnapshot: AzureNativeAttachedDiskSpecificSnapshot
  - OS disk snapshot attached to the Azure VM.
- dataDiskSnapshots: list of AzureNativeAttachedDiskSpecificSnapshots
  - List of data disk snapshots attached to the Azure VM.
- snapshotId: System.String
  - ID of the snapshot.
