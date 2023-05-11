### GcpNativeExportGceInstanceInput
Input required to export a GCP GCE instance snapshot.

- diskEncryptionType: DiskEncryptionType
  - Encryption type of created disk.
- kmsCryptoKey: KmsCryptoKey
  - Customer managed key to encrypt exported instance. This is only applicable when encryption type is CustomerManagedKey.
- kmsCryptoKeyResourceId: System.String
  - Customer managed key to encrypt exported instance. This is only applicable when encryption type is CustomerManagedKeyResourceId.
- sharedVpcHostProjectNativeId: System.String
  - Native ID of the shared VPC host project for the current service project.
- shouldAddRubrikLabels: System.Boolean
  - Specifies whether to allow Rubrik labels on the exported disk or not.
- shouldCopyLabels: System.Boolean
  - Specfies whether the labels will be copied to the exported disk from the source disk that were there at the time of taking the snapshot or not.
- shouldPowerOff: System.Boolean
  - Specifies whether the exported instance will be created in a powered-off state.
- snapshotId: System.String
  - Snapshot Rubrik ID.
- targetInstanceName: System.String
  - The name of the exported instance.
- targetMachineType: System.String
  - The machine type of the exported instance.
- targetNetworkTags: a list of System.Strings
  - The network tags of the exported instance.
- targetSubnetName: System.String
  - The subnet name of the exported instance.
- targetZone: System.String
  - The zone of the exported disk.
