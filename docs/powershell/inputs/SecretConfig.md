### SecretConfig
Configuration for an individual secret setting during restore.

- settingDefinitionId: System.String
  - ID of the secret setting to populate.
- secretValue: System.String
  - The secret value set during restore.
- collectionDefinitionId: System.String
  - ID of the parent collection. Empty for non-collection secrets.
- rowIndex: System.Int32
  - Zero-based row index within the parent collection. -1 for non-collection secrets.
- secretValues: list of System.Strings
  - Secret values to apply, one per row for collection settings.
