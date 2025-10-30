### StartClusterReportMigrationJobInput
The input configuration to start the report migration job.

- clusterUuid: System.String
  - The Rubrik cluster ID. If the cluster ID is not provided, the job will perform migration of reports for all the eligible clusters connected.
- shouldDeleteCdmSchedules: System.Boolean
  - Specifies whether to delete schedules of the cluster reports that get migrated to RSC.
