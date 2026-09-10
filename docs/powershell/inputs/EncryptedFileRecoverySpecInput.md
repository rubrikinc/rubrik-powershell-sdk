### EncryptedFileRecoverySpecInput
What a surgical recovery does with the encrypted files of the snapshot it
recovers from.

- shouldRecoverCleanVersions: System.Boolean
  - Restore encrypted files from their clean counterparts. False does nothing
with encrypted files: each is restored as it stands.
- excludedExtensions: list of System.Strings
  - Extension groups the caller deselected, whose files are restored as they
stand. Every other extension's recoverable files are restored from their
clean counterparts, so an empty list restores all of them. Lowercased and
without a leading dot, matching the extensions
encryptedFilesByExtensionInSnapshot returns.
Ignored when shouldRecoverCleanVersions is false.
