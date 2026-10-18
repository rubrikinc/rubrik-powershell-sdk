### VsphereVmRecoverFilesNewInput
Input for recovering files from snapshot.

- id: System.String
  - ID of a snapshot.
- config: RestoreFilesJobConfigInput
  - Required. Configuration for the restore request.
- clusterUuid: System.String
  - UUID used to identify the cluster the request goes to.
- deltaRequest: DeltaRecoveryInput
  - An object providing the parameters for the recovery of a snapshot and a next snapshot delta.
- recoveryPurpose: RecoveryPurpose
  - Purpose of the recovery operation.
