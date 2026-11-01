### RestoreItemInfo
Info specifying the item to be restored.

- itemId: System.String
  - The natural ID of the item to be restored.
- snapshotId: System.String
  - ID of the snapshot this item needs to be restored to. Required together with sequenceNumber.
- sequenceNumber: System.Int32
  - Sequence number of the snapshot this item needs to be restored to. Required together with snapshotId.
- rtpPointInTimeInfo: SaasRtpPointInTimeInfo
  - Optional, real-time protection (RTP) point in time this item needs to be restored from, in place of a backup snapshot. When set, snapshotId and sequenceNumber are not set.
