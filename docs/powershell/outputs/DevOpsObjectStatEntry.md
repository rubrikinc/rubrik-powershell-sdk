### DevOpsObjectStatEntry
A single (key, value) DevOps object statistic. The value is absent (null)
when the statistic is unavailable, which is distinct from a present zero.

- key: DevOpsObjectStatKey
  - The statistic this entry reports.
- value: System.Int64
  - The statistic's value. Null when unavailable, distinct from a zero count.
