### VsphereVmRecoverFilesNewInput
Input for recovering files from snapshot.

- clusterUuid: System.String
  - UUID used to identify the cluster the request goes to.
- config: RestoreFilesJobConfigInput
  - Required. Configuration for the restore request.
- deltaRequest: DeltaRecoveryInput
  - An object providing the parameters for the recovery of a snapshot and a next snapshot delta.
- id: System.String
  - ID of a snapshot.
