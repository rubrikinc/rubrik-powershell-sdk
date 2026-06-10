### FusionComputeVmExportSnapshotJobConfigInput
Configuration for a FusionCompute virtual machine snapshot export job.

- targetHostId: System.String
  - The ID of the target FusionCompute host for exporting the snapshot. At least one of targetClusterId or targetHostId must be provided.
- snapshotId: System.String
  - Required. The ID of the snapshot to export.
- targetClusterId: System.String
  - The ID of the target FusionCompute cluster for exporting the snapshot. At least one of targetClusterId or targetHostId must be provided.
- shouldPowerOn: System.Boolean
  - Determines whether to power on the FusionCompute virtual machine after the export operation. Set to 'false' to leave the instance powered off, or 'true' to power it on. The default value is 'false'.
- targetDatastoreId: System.String
  - The ID of the default target datastore for all disks in the export.
- diskToDatastoreMap: list of FusionComputeDiskToDatastoreInputs
  - Per-disk to target datastore mapping. If not specified, all disks use the targetDatastoreId.
- recoveredVmName: System.String
  - The name for the recovered FusionCompute virtual machine on the target.
- networkToNicMap: list of FusionComputeNetworkToNicInputs
  - Network to NIC mapping for the recovered virtual machine.
