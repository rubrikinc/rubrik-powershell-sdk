### SaasWorkloadRtpInfo
Real-time protection status and configuration for a SaaS workload (object).
Reusable across SaaS app types; placed here to avoid circular imports between
salesforcesvc.proto and saasappsservice.proto.

- isRtpEnabled: System.Boolean
  - Whether real-time protection is currently enabled for this workload.
- captureIntervalMins: System.Int32
  - Capture interval in minutes. Zero when is_rtp_enabled is false.
- captureRetentionDays: System.Int32
  - Retention period in days. Zero when is_rtp_enabled is false.
- isRtpRestoreEnabled: System.Boolean
  - Whether RTP restore is available for this workload. True when RTP is
enabled and the most recent RTP capture falls within capture_retention_days
of the current time.
