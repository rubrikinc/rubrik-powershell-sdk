### AnomalyDetectionConfigInput
AnomalyDetectionConfig carries per-policy anomaly-detection tuning for timing
and threshold parameters. Zero-valued fields use the policy default.

- threshold: System.Int64
  - Override for the anomaly-detection event-count threshold.
- quietPeriodMinutes: System.Int32
  - Quiet period (minutes) that determines whether a new observation continues
an existing violation or starts a new one.
- latenessBufferMinutes: System.Int32
  - Buffer period (minutes) applied when suppressing duplicate alerts from
delayed events arriving against recently closed violations.
- windowMinutes: System.Int32
  - Sliding-window width (minutes) for the detection query (e.g., the
distinct-user count over the most recent window). Zero uses the policy
default.
- errorCodes: list of System.Int32s
  - Sign-in error codes that count toward a spike. An empty list uses the
policy default set (the Conditional Access family 53000-53003 for sign-in
anomaly policies).
- results: list of System.Strings
  - Sign-in result labels that count toward a spike (e.g. FAILURE,
INTERRUPTED). An empty list uses the policy default set. Each value must be
a valid sign-in result label.
