### ReportFilterInput
Filter is used in data query API parameters.
i.e. Retrieving data with a certain filter enabled, report config, etc...

- name: System.String
  - The name of the column or attribute this filter applies to.
- values: list of System.Strings
  - Values are JSON serialized string of the original value. (Deprecated: use valuesV2).
- operator: FilterOperator
  - Operator for advanced filters. When unspecified, defaults to IN behavior.
