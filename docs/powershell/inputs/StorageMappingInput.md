### StorageMappingInput
Input for creating a storage mapping for Kubernetes recovery.

- storageClassMappings: StorageClassMappingInput
  - Map source storage classes to target storage classes.
- pvcStorageClassMappings: PvcStorageClassMappingInput
  - Map specific PVC names to target storage classes. Takes precedence over storageClassMappings.
