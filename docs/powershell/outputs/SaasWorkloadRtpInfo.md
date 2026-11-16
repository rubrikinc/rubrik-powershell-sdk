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
- isRtpEligible: System.Boolean
  - Whether this workload is eligible to have real-time protection enabled.
- rtpIneligibleReason: System.String
  - Reason why real-time protection cannot be enabled for this workload.
Empty when is_rtp_eligible is true.
