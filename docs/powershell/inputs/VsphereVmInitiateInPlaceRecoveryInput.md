### VsphereVmInitiateInPlaceRecoveryInput
Input for in place recovery for vSphere virtual machine.

- config: InPlaceRecoveryJobConfigV2Input
  - Required. Configuration for the in-place recovery request, including timestamp and snapshot ID fields. When the snapshot ID is passed without a timestamp, this endpoint triggers an in-place recovery using the given snapshot ID. When this endpoint is passed a recovery point or a recovery point and snapshot ID, the endpoint triggers an in-place recovery using the point in time (PIT) for recovery. Calling this endpoint without a recovery point or a snapshot ID triggers a PIT in-place recovery that uses the most recent time available.
- id: System.String
  - Required. ID of a VM.
