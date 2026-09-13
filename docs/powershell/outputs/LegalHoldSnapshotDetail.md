### LegalHoldSnapshotDetail
LegalHoldSnapshotDetails.

- id: System.String
  - ID.
- type: SnapshotTypeEnum
  - Snapshot type.
- snapshotTime: DateTime
  - Snapshot time.
- legalHoldTime: DateTime
  - Legal hold time.
- customizations: list of SnapshotCustomizations
- snapshotRetentionInfo: CdmSnapshotRetentionInfo
  - Provides snapshot details for each location.
- legalHoldInfo: LegalHoldInfo
  - Legal hold configuration for the snapshot. Populated only for RSC
native snapshots.
