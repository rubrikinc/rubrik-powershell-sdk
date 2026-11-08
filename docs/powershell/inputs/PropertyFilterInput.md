### PropertyFilterInput
Property filter (for filtering by resource properties).

- field: PropertyFilterField
  - Property field to filter on.
- propertyValue: list of System.Strings
  - Property value (optional - empty means match any value).
- isSearch: System.Boolean
  - If true, use LIKE search; if false, use exact match.
When true, property_value must contain exactly one
entry as search operates on a single value.
