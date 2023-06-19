### ManagedVolumeSnapshotReferencePatchInput
Supported in v5.0+
  v5.0-v8.0: 
  v8.1+: Reference for a Managed Volume snapshot.

- expiryDurationInMinutes: System.Int32
  - Supported in v5.0+
      v5.0-v5.1: Specifies a time interval in minutes. This reference expires from the snapshot after the specified interval. A value of -1 indicates that the snapshot should not expire.
      v5.2-v6.0: Specifies a time interval in minutes. This reference expires from the snapshot after the specified interval. A value of -1 indicates that the snapshot does not expire.
      v7.0+: A time interval, in minutes, after which the reference expires from the snapshot. A value of -1 indicates that the snapshot does not expire.
