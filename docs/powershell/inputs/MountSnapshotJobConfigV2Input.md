### MountSnapshotJobConfigV2Input
Supported in v5.1+

- createDatastoreOnly: System.Boolean
  - Supported in v5.1+
      The job creates a datastore that contains the VMDK, but does not create the corresponding virtual machine.
- dataStoreName: System.String
  - Supported in v5.1+
      Obsolete parameter.
- hostId: System.String
  - Supported in v5.1+
      ID of the ESXi host to mount the new virtual machine on.
- shouldRecoverTags: System.Boolean
  - Supported in v5.1+
      The job recovers the tags that were assigned to the virtual machine.
- vlan: System.Int32
  - Supported in v5.1+
      VLAN ID for the VLAN ESXi host preferred to use for mounting the datastore.
- clusterId: System.String
  - Supported in v6.0+
      ID of the compute cluster where the new virtual machine will be mounted.
- resourcePoolId: System.String
  - Supported in v6.0+
      ID of the resource pool where the new virtual machine will be mounted.
- shouldMigrateImmediately: System.Boolean
  - Supported in v8.1+
      Specifies whether to trigger migration immediately when the Live Mount succeeds.
- folderId: System.String
  - Supported in v9.1+
      ID of the virtual machine folder where the new virtual machine will be mounted.
- migrationConfig: RelocateMountConfigV2Input
  - Supported in v8.1+
      Configuration for migration.
- mountExportSnapshotJobCommonOptionsV2: MountExportSnapshotJobCommonOptionsV2Input
  - 
- requiredRecoveryParameters: RequiredRecoveryParametersInput
  - 
- vNicBindings: list of VmwareVnicBindingInfoV2Inputs
  - Supported in v6.0+
      The network binding for vNIC of the virtual machine.
