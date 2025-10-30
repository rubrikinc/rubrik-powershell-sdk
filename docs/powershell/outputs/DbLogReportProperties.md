### DbLogReportProperties
Supported in v5.3+

- enableDelayNotification: System.Boolean
  - Required. Supported in v5.3+
Indicates whether the database log backup delay notification is enabled. Set to 'true' to send an email notification when the log backup delay is more than the configured threshold, and 'false' to disable the behavior.
- logDelayThresholdInMin: System.Int64
  - Required. Supported in v5.3+
The threshold for the delay in log backup before an email notification should be created.
- logDelayNotificationFrequencyInMin: System.Int64
  - Required. Supported in v5.3+
The frequency for sending an email notification to the customer when the log backup delay is more than the threshold.
