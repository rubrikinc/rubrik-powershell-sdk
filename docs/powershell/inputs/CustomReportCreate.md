### CustomReportCreate
Create or update a custom report configuration.

- name: System.String
  - Name of the report.
- focus: ReportFocusEnum
  - Metrics focus of the report.
- isHidden: System.Boolean
  - Specifies whether the report should be hidden from the gallery view.
- isReadOnly: System.Boolean
  - Specifies whether the report is auto-generated and not editable.
- charts: list of ReportChartCreates
  - Chart configs for the report.
- tables: list of ReportTableCreates
  - Table configs for the report.
- filters: CustomReportFiltersConfig
  - Filters for the report data.
