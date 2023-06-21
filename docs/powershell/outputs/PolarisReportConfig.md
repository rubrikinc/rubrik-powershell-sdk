### PolarisReportConfig
The saved configurations of a report.

- id: System.Int64
  - Report ID.
- name: System.String
  - Report name.
- reportViewType: PolarisReportViewType
  - Type of report.
- charts: list of ChartViewTypes
  - A list of selected charts in the report.
- table: TableViewType
  - The selected table in the report.
- filters: list of ReportFilters
  - The filter used for sorting in the report.
- sortBy: System.String
  - The selected order of sorting in the report.
- sortOrder: SortOrder
  - The selected sortOrder in the report.
