### CustomReportInfo
Simplified report information for custom reports.

- id: System.Int64
  - Unique identifier of the report.
- name: System.String
  - Name of the report.
- reportViewType: PolarisReportViewType
  - Type of report view.
- reportCategory: ReportCategory
  - Category of the report.
- reportFilters: list of FilterOutputs
  - Filters applied to the report.
- room: ReportRoomType
  - Room the report belongs to.
- createdAt: DateTime
  - Timestamp of when the report was created.
- createdBy: System.String
  - Email address of the user who created the report.
- updatedAt: DateTime
  - Timestamp of when the report was last updated.
- updatedBy: System.String
  - Email address of the user who last updated the report.
- scheduledReportsCount: System.Int32
  - Number of scheduled reports associated with the report.
