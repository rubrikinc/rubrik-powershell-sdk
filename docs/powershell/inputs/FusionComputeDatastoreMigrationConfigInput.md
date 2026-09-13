### FusionComputeDatastoreMigrationConfigInput
Supported in v9.6+
Configuration for migrating a FusionCompute Live Mount to another datastore.

- diskToDatastoreMap: list of FusionComputeDiskToDatastoreInputs
  - Supported in v9.6+
Per-disk to target datastore mapping. If not specified, all disks use the datastoreId.
- datastoreId: System.String
  - Supported in v9.6+
The ID of the default target datastore for the storage migration.
