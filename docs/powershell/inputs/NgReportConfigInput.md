### NgReportConfigInput
Configuration of an NG version report.

- name: System.String
  - Report name.
- reportViewType: PolarisReportViewType
  - Type of report.
- charts: list of ChartViewTypes
  - Selected charts of the report.
- table: TableViewType
  - The selected table of the report.
- filters: list of ReportFilterInputs
  - Filter selection for the report.
- sortBy: System.String
  - Selected column for sorting the table data in the report.
- sortOrder: SortOrder
  - Selected sort order in the report.
