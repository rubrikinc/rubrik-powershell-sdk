### IrisdbStorageSpec
IRIS DB instance storage binding.

- protectionGroupIds: list of System.Strings
  - The Pure Protection Group IDs for this instance's volumes.
- volumes: list of IrisdbVolumes
  - The discovery-populated storage volumes for this instance.
- mountPaths: list of System.Strings
  - All distinct mount paths on this instance, aggregated across all volumes and lsblk device subtrees.
- storageId: System.String
  - The Pure FlashArray FID backing this instance.
