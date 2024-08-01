### MigrationMetadata
Migration metadata of CDM clusters.

- clusterUuid: System.String
  - UUID of the CDM cluster.
- clusterName: System.String
  - Name of the CDM cluster.
- totalApplicablePrechecks: System.Int32
  - Total count of applicable prechecks.
- totalMigratedPrechecks: System.Int32
  - Total count of migrated prechecks.
- softwareVersion: System.String
  - Software version of the Rubrik cluster.
- mandatoryPrechecksMigrated: System.Boolean
  - Boolean value to specify if all mandatory prechecks are migrated.
- registeredMode: ClusterRegistrationMode
  - Mode of registration.
- clusterStatus: ClusterStatus
  - Connected status of the Rubrik cluster.
