### ReportTableCreate
Create configs for an activity data table.

- name: System.String
  - The name of the table.
- focus: ReportFocusEnum
  - The metrics focus of the table.
- groupBy: list of GroupByFieldEnums
  - Group-by fields for the table data.
- selectedColumns: list of ReportTableColumnEnums
  - The columns to include in the table.
- sortBy: SortByFieldEnum
  - The field to sort the table data by.
- sortOrder: SortOrder
  - The data sorting order for the table, ASC or DESC.
