### RelocateMountConfigV2Input
Supported in Rubrik CDM version 9.0 and later.

- diskDeviceKeyToStorageId: list of VmwareStorageIdWithDeviceKeyV2Inputs
  - Supported in v8.1+
List of mappings between disk device keys and storage IDs. If the list is not defined or emtpy, the storageLocationId is the location where all virtual disks are migrated. When this mapping is provided, each Live-mounted virtual disk must be mapped to a valid storage location, either a datastore or a datastore cluster. An incomplete or invalid mapping will result in the failure of the relocation operation.
- storageLocationId: System.String
  - Supported in v8.1+
The ID of the datastore or datastore cluster that is the target of relocation.
- computeClusterId: System.String
  - Supported in v9.0+
ID of the compute cluster to relocate the new virtual machine to.
- hostId: System.String
  - Supported in v9.0+
ID of the ESXi host to relocate the new virtual machine to. Include if the target host is different from the mounted host.
- networkDeviceKeyToNetworkName: list of VmwareDeviceKeywithNetworkNameV2Inputs
  - Supported in v9.0+
List of mappings between network device keys and network names.
- resourcePoolId: System.String
  - Supported in v9.0+
ID of the resource pool where the new virtual machine will be mounted.
