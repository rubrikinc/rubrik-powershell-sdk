### NasAutomigrationJobInput
Job information for NAS Automigration service.

- MigrateAllHosts: System.Boolean
  - Determines if this job will handle all CDM NAS hosts that are not yet migrated to RSC.
- CopyableHostIDs: list of System.Strings
  - FIDs for CDM NAS hosts that should be migrated.
- NasSystemIDs: list of System.Strings
  - FIDs for RSC NAS Systems that the CDM NAS hosts are migrating to.
- clusterUUID: System.String
  - Rubrik cluster UUID.
