### ArchivalLocationEncryptionJobsSummary
Summary of all encryption jobs of an archival location.

- automaticRotationFrequency: System.Int32
  - Archival location's automatic key rotation frequency in days.
- lastMasterKeyRekeyStatus: ArchivalLocationEncryptionJobInfo
  - Info on the archival location's latest master key re-key.
- lastKeyRotationStatus: ArchivalLocationEncryptionJobInfo
  - Info on the archival location's latest key rotation.
- lastRootKekRekeyStatus: ArchivalLocationEncryptionJobInfo
  - Info on the archival location's latest root key re-key.
