### ReportMigrationStatus
Migration details of the Rubrik cluster report.

- reportId: System.String
  - Report ID on the Rubrik cluster.
- reportName: System.String
  - Report name.
- reportTemplate: ReportTemplate
  - Report template.
- status: CdmReportMigrationStatus
  - Migration status of the report.
- details: System.String
  - JSON string that captures the migration details, if any.
- cluster: Cluster
  - Rubrik cluster of the report.
- rscReportId: System.Int64
  - The corresponding report ID on RSC after migration.
