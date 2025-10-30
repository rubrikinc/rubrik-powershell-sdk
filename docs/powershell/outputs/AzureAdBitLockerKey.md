### AzureAdBitLockerKey
Entra ID BitLocker key.

- deviceName: System.String
  - Name of the device associated with this BitLocker recovery key.
- keyId: System.String
  - Unique identifier for this BitLocker recovery key.
- key: System.String
  - BitLocker recovery key used to unlock the encrypted drive.
- volumeType: AzureAdBitLockerVolumeType
  - Type of drive/volume this key protects.
- createdDateTime: DateTime
  - Date and time when this key was created and backed up to Entra ID.
