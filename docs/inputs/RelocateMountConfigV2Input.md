### RelocateMountConfigV2Input
Supported in Rubrik CDM version 9.0 and later.

- diskDeviceKeyToStorageId: a list of VmwareStorageIdWithDeviceKeyV2Inputs
  - Supported in v8.1+
      List of mappings between disk device keys and storage IDs. If the list is not defined or emtpy, the storageLocationId is the location where all virtual disks are migrated. When this mapping is provided, each Live-mounted virtual disk must be mapped to a valid storage location, either a datastore or a datastore cluster. An incomplete or invalid mapping will result in the failure of the relocation operation.
- storageLocationId: System.String
  - Supported in v8.1+
      The ID of the datastore or datastore cluster that is the target of relocation.
