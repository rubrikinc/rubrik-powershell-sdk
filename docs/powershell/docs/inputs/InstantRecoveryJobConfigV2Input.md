### InstantRecoveryJobConfigV2Input
Supported in v5.1+

- hostId: System.String
  - Supported in v5.1+
      ID of the ESXi host to use for Instant Recovery.
- preserveMoid: System.Boolean
  - Supported in v5.1+
      A Boolean value that determines whether the MOID of the source virtual machine is preserved in a restore operation. When this value is 'true', the MOID of the source is preserved. When this value is 'false', the restored virtual machine is assigned a new MOID.
- shouldRecoverTags: System.Boolean
  - Supported in v5.1+
      A Boolean value that determines whether the job recovers the tags assigned to the virtual machine. When this value is 'true', the job recovers the tags. When this value is 'false', the job does not recover the tags.
- vlan: System.Int32
  - Supported in v5.1+
      The preferred VLAN ID used by the VLAN ESXi host to mount the datastore.
- clusterId: System.String
  - Supported in v6.0+
      ID of the compute cluster where the new virtual machine will be mounted.
- resourcePoolId: System.String
  - Supported in v6.0+
      ID of the resource pool where the new virtual machine will be mounted.
- vNicBindings: list of VmwareVnicBindingInfoV2Inputs
  - Supported in v6.0+
      The network binding for vNIC of the virtual machine.
- mountExportSnapshotJobCommonOptionsV2: MountExportSnapshotJobCommonOptionsV2Input
  - 
- requiredRecoveryParameters: RequiredRecoveryParametersInput
  - 
