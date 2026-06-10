### CdmLabelSelectorRequirement
A label selector requirement for matching workloads by key, operator, and values.

- key: System.String
  - Required. The label key.
- values: list of System.Strings
  - List of string values for the label selector requirement. The operator is applied against these values.
- operator: System.String
  - Required. The operator. One of: In, NotIn, Exists, DoesNotExist.
