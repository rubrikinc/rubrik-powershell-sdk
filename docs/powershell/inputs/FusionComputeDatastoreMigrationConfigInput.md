### FusionComputeDatastoreMigrationConfigInput
Configuration for migrating a FusionCompute Live Mount to another datastore.

- diskToDatastoreMap: list of FusionComputeDiskToDatastoreInputs
  - Per-disk to target datastore mapping. If not specified, all disks use the datastoreId.
- datastoreId: System.String
  - The ID of the default target datastore for the storage migration.
