### Column
Column represents a report table column for the UI.

- name: System.String
  - The identifier of the column.
- dataViewType: DataViewTypeEnum
  - The type of the data view that the column belongs to.
- type: DataTypeEnum
  - Specifies the data type of the column.
- nullable: System.Boolean
  - Specifies if the value of the column can be null.
- dimensional: System.Boolean
  - Specifies if the column is a dimension column.
- aggregate: System.Boolean
  - Specifies if the column is obtained by calling an aggregate
function on another column.
- sortable: System.Boolean
  - Specifies if the table can be sorted by the column.
- default: System.Boolean
  - Specifies if the column should appear in the table in the default
view of the report.
- displayName: System.String
  - The user facing name.
