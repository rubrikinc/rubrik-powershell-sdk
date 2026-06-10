### RecoveryPurpose
Purpose of a file recovery operation. Used to signal surgical recovery,
where quarantined files are automatically excluded from the restore.

- RECOVERY_PURPOSE_UNSPECIFIED - Default value. Preserves prior recovery behavior - no quarantine-aware
exclusions are applied during the restore.
- SURGICAL_RECOVERY - Recover from a snapshot while automatically excluding files that the
Orion Hunt Service has flagged as quarantined for that snapshot.
Subject to feature availability for the account.
