### RekeyArchivalLocationMasterKeyWithAzureKeyVaultKeyInput
Input for re-keying archival location's master key with Azure Key Vault key.

- locationId: System.String
  - Field for specifying location identifier of the archival location.
- existingRsaKey: System.String
  - Existing RSA key if archival location is encrypted by RSA key.
- newAzureKeyIdentifier: AzureKeyVaultKeyIdentifierInput
  - Identifier for Azure Key Vault Key to be used for re-keying master key.
