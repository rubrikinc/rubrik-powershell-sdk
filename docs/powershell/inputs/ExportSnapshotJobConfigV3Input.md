### ExportSnapshotJobConfigV3Input
Supported in Rubrik CDM version 9.0 and later.

- clusterId: System.String
  - ID of the cluster to export the new virtual machine to.
- diskDeviceKeyToStorageId: list of VmwareStorageIdWithDeviceKeyV2Inputs
  - List of disk device keys to storage ID mappings. If the list is not defined, the export virtual machine is created at the storageLocationId. If the list is defined, the storageLocationId specifies where the vmx file is created. When this mapping is provided, each virtual disk in the snapshot must be mapped to a valid storage location, either a datastore or a datastore cluster. An incomplete or invalid mapping will result in the failure of the export operation.
- hostId: System.String
  - Supported in v8.1+
      ID of the ESXi host to export the new virtual machine to.
- resourcePoolId: System.String
  - Supported in v8.1+
      ID of the resource pool to export the new virtual machine to.
- shouldRecoverTags: System.Boolean
  - Supported in v8.1+
      The job recovers any tags that were assigned to the virtual machine.
- shouldUseHotAddProxy: System.Boolean
  - Specifies whether the export uses a HotAdd mode to transport virtual disk data. When this value is `true`, the export uses HotAdd mode to transport virtual disk data. When this value is `false`, the export uses NBDSSL to transport virtual disk data. The default value is `false`.
- storageLocationId: System.String
  - Supported in v8.1+
      ID of the datastore or datastore cluster to assign to the exported virtual machine.
- unregisterVm: System.Boolean
  - Specifies whether the new virtual machine created from a snapshot is registered with the vCenter Server. When this value is `true`, the registration is removed from the vCenter Server. When this value is `false`, the registration is kept on the vCenter Server. The default value is `false`.
- vNicBindings: list of VmwareVnicBindingInfoV2Inputs
  - The network binding for the vNIC of the virtual machine.
- mountExportSnapshotJobCommonOptionsV2: MountExportSnapshotJobCommonOptionsV2Input
  - Common fields for recovery operations.
- requiredRecoveryParameters: RequiredRecoveryParametersInput
  - Target snapshot ID or a point in time for recovery.
- folderId: System.String
  - Supported in v9.1+
      ID of the virtual machine folder to export the new virtual machine to.
- contentLibraryId: System.String
  - Supported in v9.1+
      ID of the content library to which the new content library item is being exported.
- shouldConvertToTemplate: System.Boolean
  - Supported in v9.1+
      Specifies whether Export converts the recovered virtual machine to a template.
