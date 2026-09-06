### SurgicalRecoveryConfigInput
Recovery-time selections for a surgical recovery that restores clean
versions of affected files in place of the versions the snapshot holds.
Carried alongside recoveryPurpose SURGICAL_RECOVERY, which remains the
only surgical signal: this message refines that recovery rather than
describing a different one. A request that carries it without that purpose
is rejected, since nothing would act on the selections.

- quarantinedFiles: QuarantinedFileRecoverySpecInput
  - Selections over the quarantined files of the snapshot. Absent leaves
quarantine handling as it is without this message: no clean version is
restored and every quarantined file is removed. Absent is also how a
caller describes having nothing to select from -- threat monitoring not
enabled, the snapshot unprocessed, or no file quarantined -- since each of
those leaves an empty set to act on.
- encryptedFiles: EncryptedFileRecoverySpecInput
  - Selections over the encrypted files of the snapshot. Absent restores no
clean version: encrypted files are restored as they stand.
