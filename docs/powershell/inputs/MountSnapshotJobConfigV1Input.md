### MountSnapshotJobConfigV1Input
Supported in v5.0+

- createDatastoreOnly: System.Boolean
  - Supported in v5.0+
      The job creates a datastore that contains the VMDK, but does not create the corresponding virtual machine.
- dataStoreName: System.String
  - Supported in v5.0+
      v5.0: Name of the host NAS datastore to use with the new virtual machine. The Rubrik cluster creates a new datastore on the host using the provided name.
      v5.1+: Obsolete parameter.
- hostId: System.String
  - Supported in v5.0+
      ID of the ESXi host to mount the new virtual machine on.
- shouldRecoverTags: System.Boolean
  - Supported in v5.0+
      The job recovers the tags that were assigned to the virtual machine.
- vlan: System.Int32
  - Supported in v5.0+
      VLAN ID for the VLAN ESXi host prefer to use for mounting the datastore.
- mountExportSnapshotJobCommonOptions: MountExportSnapshotJobCommonOptionsInput
  - 
