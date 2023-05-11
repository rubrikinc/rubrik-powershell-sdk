### NcdSharesObjectProtectionStatusData
SharesObjectProtectionStatusData represents a summary of the various types of
 object protection statuses and their individual counts as well as their delta
 in bytes for shares.

- notProtected: System.Int64
  - The count of Not Protected objects or objects that have no backups.
- protected: System.Int64
  - The count of Protected objects or objects that have valid backups.
- totalSizeInBytes: System.Int64
  - The total size in bytes of all objects.
