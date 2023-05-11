### InstantRecoveryJobConfigV2Input
Supported in v5.1+

- clusterId: System.String
  - Supported in v6.0+
      ID of the compute cluster where the new virtual machine will be mounted.
- hostId: System.String
  - Supported in v5.1+
      ID of the ESXi host to use for Instant Recovery.
- mountExportSnapshotJobCommonOptionsV2: MountExportSnapshotJobCommonOptionsV2Input
  - 
- preserveMoid: System.Boolean
  - Supported in v5.1+
      A Boolean value that determines whether the MOID of the source virtual machine is preserved in a restore operation. When this value is 'true', the MOID of the source is preserved. When this value is 'false', the restored virtual machine is assigned a new MOID.
- requiredRecoveryParameters: RequiredRecoveryParametersInput
  - 
- resourcePoolId: System.String
  - Supported in v6.0+
      ID of the resource pool where the new virtual machine will be mounted.
- shouldRecoverTags: System.Boolean
  - Supported in v5.1+
      A Boolean value that determines whether the job recovers the tags assigned to the virtual machine. When this value is 'true', the job recovers the tags. When this value is 'false', the job does not recover the tags.
- vNicBindings: a list of VmwareVnicBindingInfoV2Inputs
  - Supported in v6.0+
      The network binding for vNIC of the virtual machine.
- vlan: System.Int32
  - Supported in v5.1+
      The preferred VLAN ID used by the VLAN ESXi host to mount the datastore.
