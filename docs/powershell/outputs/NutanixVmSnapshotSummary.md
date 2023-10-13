### NutanixVmSnapshotSummary
Supported in v5.0+

- vmName: System.String
  - Required. Supported in v5.0+
- nicsInSnapshot: System.Int32
  - Supported in v8.1+
  Number of NICs present in the snapshot app metadata.
- snapshotNetworkUuids: list of System.Strings
  - List of all UUIDs for the networks connected to the virtual machine when snapshot was taken.
- baseSnapshotSummary: BaseSnapshotSummary
  - This field contains the base information of a snapshot which are common across other workloads.
