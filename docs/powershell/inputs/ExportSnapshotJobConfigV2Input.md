### ExportSnapshotJobConfigV2Input
Supported in v5.1+

- hostId: System.String
  - Supported in v5.1+
      ID of the ESXi host to export the new virtual machine to.
- shouldRecoverTags: System.Boolean
  - Supported in v5.1+
      The job recovers any tags that were assigned to the virtual machine.
- unregisterVm: System.Boolean
  - Supported in v5.1+
      A Boolean value that determines whether the new virtual machine created from a snapshot is registered with the vCenter Server. When this value is 'true', the registration is removed from the vCenter Server. When this value is 'false', the registration is kept on the vCenter Server. The default is 'false'.
- clusterId: System.String
  - ID of the Rubrik cluster to export the new virtual machine to.
- resourcePoolId: System.String
  - Supported in v5.2+
      ID of the resource pool to export the new virtual machine to.
- vNicBindings: list of VmwareVnicBindingInfoV2Inputs
  - Supported in v6.0+
      The network binding for vNIC of the virtual machine.
- shouldUseHotAddProxy: System.Boolean
  - Supported in v7.0+
      Boolean value that determines whether Export uses a HotAdd mode to transport virtual disk data. When this value is `true`, Export uses HotAdd mode to transport virtual disk data. When this value is `false`, Export uses NBDSSL to transport virtual disk data. The default value is `false`.
- mountExportSnapshotJobCommonOptionsV2: MountExportSnapshotJobCommonOptionsV2Input
  - 
- requiredRecoveryParameters: RequiredRecoveryParametersInput
  - 
- folderId: System.String
  - Supported in v9.1+
      ID of the virtual machine folder to export the new virtual machine to.
- contentLibraryId: System.String
  - Supported in v9.1+
      ID of the content library to which the new content library item is being exported.
- shouldConvertToTemplate: System.Boolean
  - Supported in v9.1+
      Specifies whether Export converts the recovered virtual machine to a template.
- datastoreId: System.String
  - Required. Supported in v5.1+
      ID of the datastore to assign to the exported virtual machine.
