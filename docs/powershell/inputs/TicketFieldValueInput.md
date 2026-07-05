### TicketFieldValueInput
Input for a field value with type information and typed value fields.

- fieldType: TicketFieldType
  - The type of the field value.
- stringValue: System.String
  - String value for text fields.
- numberValue: System.Int64
  - Numeric value for number fields.
- optionValue: System.String
  - Single option ID for dropdown selections.
- multiOptionValues: StringArrayInput
  - Multiple option IDs for multi-select fields.
- arrayValues: StringArrayInput
  - Array of string values for tags/labels.
- userValue: System.String
  - User ID for user assignment fields.
- dateValue: System.String
  - ISO date string for date fields.
- datetimeValue: System.String
  - ISO datetime string for datetime fields.
- booleanValue: System.Boolean
  - Boolean value for checkbox fields.
- textAreaValue: System.String
  - Multi-line text for text area fields.
