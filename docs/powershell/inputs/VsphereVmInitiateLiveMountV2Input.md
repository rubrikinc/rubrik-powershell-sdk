### VsphereVmInitiateLiveMountV2Input
Input to initiate live mount of vSphere snapshot.

- config: MountSnapshotJobConfigV2Input
  - Configuration for the Live Mount request, including timestamp and snapshot ID fields. When the snapshot ID is passed without a timestamp, this endpoint triggers a live mount using the given snapshot ID. When this endpoint is passed a recovery point or a recovery point and snapshot ID, the endpoint triggers a live mount using the point in time (PIT) for recovery. Calling this endpoint without a recovery point or a snapshot ID triggers a PIT live mount that uses the most recent time or snapshot available.
- id: System.String
  - Required. ID of a VM.
