### DhrcScoreMetric
Metric represents a specific metric as included in the score calculation.

- value: System.Single
  - The value of the metric.
- maxValue: System.Single
  - The maximum value of the metric.
- impact: System.Single
  - The impact the metric had on the score calculation. Note that the impact
 is scaled by the weight before being used in the score calculation.
- weight: System.Single
  - The weight of the impact value for the score calculation.
- version: System.Int32
  - The metric version. Increase by one every time the metric definition is
 updated.
- metric: DhrcMetric
  - The metric identity.
