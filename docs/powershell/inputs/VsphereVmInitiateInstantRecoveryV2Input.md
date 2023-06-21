### VsphereVmInitiateInstantRecoveryV2Input
Input for instant recovery for vSphere virtual machine.

- config: InstantRecoveryJobConfigV2Input
  - Required. Configuration for the Instant Recovery request, including timestamp and snapshot ID fields. When the snapshot ID is passed without a timestamp, this endpoint triggers an instant recovery using the given snapshot ID. When this endpoint is passed a recovery point or a recovery point and snapshot ID, the endpoint triggers an instant recovery using the point in time (PIT) for recovery. Calling this endpoint without a recovery point or a snapshot ID triggers a PIT instant recovery that uses the most recent time or snapshot available.
- id: System.String
  - Required. ID of a VM.
