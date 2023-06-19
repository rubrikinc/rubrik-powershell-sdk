### NgAlphaReportConfigInput
Configuration of an NG Alpha version report.

- name: System.String
  - Report name.
- dataViewType: DataViewTypeEnum
  - Type of report.
- columns: list of System.Strings
  - Column selection for the report.
- groupBy: ConfigGroupByInput
  - GroupBy selection for the report.
- aggregations: list of System.Strings
  - Aggregations for single-level groupBy. This does not affect double-level groupBys.
- filters: list of ReportFilterInputs
  - Filter selection for the report.
- sortBy: System.String
  - Selected column for sorting the table data in the report.
- sortOrder: SortOrder
  - Selected sort order in the report.
