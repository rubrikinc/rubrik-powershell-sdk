### NgAlphaReportConfigInput
Configuration of an NG Alpha version report.

- aggregations: a list of System.Strings
  - Aggregations for single-level groupBy. This does not affect double-level groupBys.
- columns: a list of System.Strings
  - Column selection for the report.
- dataViewType: DataViewTypeEnum
  - Type of report.
- filters: a list of ReportFilterInputs
  - Filter selection for the report.
- groupBy: ConfigGroupByInput
  - GroupBy selection for the report.
- name: System.String
  - Report name.
- sortBy: System.String
  - Selected column for sorting the table data in the report.
- sortOrder: SortOrder
  - Selected sort order in the report.
