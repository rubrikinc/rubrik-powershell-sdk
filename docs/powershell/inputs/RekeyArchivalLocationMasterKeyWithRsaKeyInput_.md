### RekeyArchivalLocationMasterKeyWithRsaKeyInput
Input for re-keying archival location's master key with RSA key.

- locationId: System.String
  - Field for specifying location identifier of the archival location.
- newRsaKey: System.String
  - New RSA key that will be used as the master key to encrypt the archival location.
- existingRsaKey: System.String
  - Existing RSA key if archival location is encrypted by RSA key.
