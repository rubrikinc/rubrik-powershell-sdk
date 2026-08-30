### DataMaskingConfigInput
Data masking configuration for requests.

- dataTypeMappings: list of ClassificationDataTypeIdToMaskingTechniques
  - Classification data type ID to masking technique mappings (one-to-one).
- exclusions: list of MaskingExclusionInputs
  - Object-field exclusions.
- overrides: list of MaskingOverrideInputs
  - Object-field to masking technique overrides.
