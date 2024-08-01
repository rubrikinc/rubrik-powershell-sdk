### ResolveAnomalyInput
Resolve an anomaly.

- anomalyType: AnomalyType
  - The type of anomaly.
- workloadId: System.String
  - The workload ID of the anomaly.
- anomalyId: System.String
  - The ID of the anomaly.
- falsePositiveReport: AnomalyFalsePositiveReport
  - An optional false positive report for the anomaly resolution.
- directoriesToSnooze: list of System.Strings
  - An optional list of directories to snooze if a false positive is reported.
