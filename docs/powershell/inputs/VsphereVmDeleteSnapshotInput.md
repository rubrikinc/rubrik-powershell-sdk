### VsphereVmDeleteSnapshotInput
Input for deleting VMware snapshots.

- location: DeleteVmwareSnapshotRequestLocation
  - Required. Location of the snapshot. Use **_local_** to delete only the local copy of the snapshot. Or use **_all_** to delete the snapshot locally, on a replication target, and at an archival location.
- id: System.String
  - Required. ID of snapshot.
