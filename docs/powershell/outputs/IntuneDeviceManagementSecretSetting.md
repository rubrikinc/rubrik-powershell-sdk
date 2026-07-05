### IntuneDeviceManagementSecretSetting
Intune device management secret setting.

- settingDefinitionId: System.String
  - Setting definition ID.
- settingType: IntuneDeviceManagementSecretSettingType
  - Secret setting type.
- collectionDefinitionId: System.String
  - ID of the containing collection when the secret is one item in a list.
Empty for standalone secrets.
- rowIndex: System.Int32
  - Position of the secret within its collection. -1 for standalone secrets.
- itemKeyType: IntuneSettingItemKeyType
  - Type of the label field that names this secret's row.
- itemKeyValue: System.String
  - Value of the label field for this secret's row.
- passwordCount: System.Int32
  - Number of secret values configured for this setting in the policy.
