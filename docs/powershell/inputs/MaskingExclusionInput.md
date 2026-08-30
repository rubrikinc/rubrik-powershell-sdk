### MaskingExclusionInput
Objects or fields to exclude from masking.

- workloadId: System.String
  - Object ID (e.g., workload identifier).
- fieldNames: list of System.Strings
  - List of field names to exclude (empty if excluding entire object).
- excludeEntireObject: System.Boolean
  - Whether to exclude the entire object.
- schemaName: System.String
  - Name of the schema or the appItemTypeToken value of the object, such as Accounts or Contact.
