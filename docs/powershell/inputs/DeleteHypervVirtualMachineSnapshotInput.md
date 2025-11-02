### DeleteHypervVirtualMachineSnapshotInput
Input for deleting a Hyper-V virtual machine snapshot.

- id: System.String
  - Required. ID of snapshot.
- location: InternalDeleteHypervVirtualMachineSnapshotRequestLocation
  - Required. Snapshot location to delete. Use **_local_** to delete all local snapshots and **_all_** to delete the snapshot in all locations.
