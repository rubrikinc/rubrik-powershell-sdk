### DhrcScoreMetric
Metric represents a specific metric as included in the score calculation.

- impact: System.Single
  - The impact the metric had on the score calculation. Note that the impact
 is scaled by the weight before being used in the score calculation.
- maxValue: System.Single
  - The maximum value of the metric.
- metric: DhrcMetric
  - The metric identity.
- value: System.Single
  - The value of the metric.
- version: System.Int32
  - The metric version. Increase by one every time the metric definition is
 updated.
- weight: System.Single
  - The weight of the impact value for the score calculation.
