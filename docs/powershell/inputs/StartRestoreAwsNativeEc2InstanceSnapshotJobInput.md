### StartRestoreAwsNativeEc2InstanceSnapshotJobInput
Trigger AWS EC2 instance snapshot restore job.

- snapshotId: System.String
  - ID of snapshot to restore.
- shouldPowerOn: System.Boolean
  - Specifies the power status of the restored EC2 Instance. When true, the
EC2 Instance is powered-on after completion of the restore.
- shouldRestoreTags: System.Boolean
  - Specifies whether to restore associated tags. If true, the restored EC2
Instance will have same tags associated.
- snapshotTypeToUseIfSourceExpired: SnapshotTypeToUseIfSourceExpired
  - Snapshot type to use if source snapshot is expired.
- archivedSnapshotId: System.String
  - ID of the archived snapshot to be restored. This field should be specified only when `snapshotTypeToUseIfSourceExpired` is set to `Archived`. In such cases, the archived snapshot will be used for restore. If `snapshotTypeToUseIfSourceExpired` is not `Archived`, this field is ignored.
- retrievalTier: AwsRetrievalTier
  - AWS Glacier retrieval tier to use when hydrating archived objects for this restore. Only meaningful when restoring from a Glacier-tier archival location.
- recoveryPurpose: RecoveryPurpose
  - Purpose of the recovery operation. Set to SURGICAL_RECOVERY to automatically exclude quarantined files from the restored instance (subject to feature availability for the account). Defaults to RECOVERY_PURPOSE_UNSPECIFIED, which preserves prior behavior.
- surgicalRecoveryConfig: SurgicalRecoveryConfigInput
  - Clean-version selections for a surgical recovery: which quarantined files keep their clean version restored, and which encrypted files are restored from their clean counterparts. Requires recoveryPurpose SURGICAL_RECOVERY and the surgical recovery V2 entitlement on the account. Omit to restore with quarantined files excluded and encrypted files left as they stand.
- customTags: TagsInput
  - Tags to apply to the restored EC2 Instance and to every resource Rubrik creates for the restore (recovered volumes, and the image and snapshots copied for a cross-region restore), in addition to the tags Rubrik manages and any tags restored from the snapshot. These tags apply only to this restore. The request is rejected if any tag uses the key Name, a key reserved by Rubrik (rk_) or AWS (aws:), a key or value AWS will not accept, or a key more than once, or if there are more than 41 tags.
