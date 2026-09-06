### QuarantinedFileRecoverySpecInput
What a surgical recovery does with the quarantined files of the snapshot it
recovers from.

- shouldSkipCleanVersionRecovery: System.Boolean
  - Restore no clean version at all, so that every quarantined file is
removed from the recovered image. Describes a choice made over quarantine
data the caller was shown, not the absence of such data, which is
described by leaving this whole message unset.
- skippedFilePaths: list of System.Strings
  - Paths whose clean version is not restored even though a retained snapshot
holds one; each is removed instead. Holds at most 1000 paths, matching the
cap on the read side, since a caller skipping that many is describing in a
list what shouldSkipCleanVersionRecovery describes in a single field.
Paths are normalized before they are compared, so they match the paths
quarantinedFilesInSnapshot returned.
