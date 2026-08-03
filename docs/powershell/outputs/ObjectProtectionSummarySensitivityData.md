### ObjectProtectionSummarySensitivityData
Sensitive data aggregated per protection status.

- protectionStatus: SnappableProtectionStatus
  - Protection status for which the counts are aggregated.
- sensitiveObjectCount: System.Int64
  - Number of sensitive objects in this protection status.
- nonSensitiveObjectCount: System.Int64
  - Number of non-sensitive objects in this protection status.
- pendingScanObjectCount: System.Int64
  - Number of objects pending a scan in this protection status.
- scanNotEnabledObjectCount: System.Int64
  - Number of objects for which scanning is not enabled.
