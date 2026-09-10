### FieldOverrideInput
Field-level override within an object.

- fieldName: System.String
  - Field name (e.g., "Email", "Phone").
- maskingTechnique: MaskingTechnique
  - Masking technique to apply to this field.
- isInclusion: System.Boolean
  - Indicates whether the field is an inclusion (not initially selected) or
an override (initially selected but with a changed technique).
- classificationDataTypeTagId: System.Int32
  - The tag ID of the classification data type for this field.
