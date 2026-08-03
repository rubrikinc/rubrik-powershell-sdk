### RpoLagInfoV2
RPO lag information for a workload, including actual and expected RPO
values and a severity level indicating how far the workload deviates
from its expected RPO.

- lagLevel: RpoLagLevel
  - The severity level of the RPO lag.
- expectedRpoInSecs: System.Int64
  - The expected RPO duration in seconds.
- actualRpoInSecs: System.Int64
  - The actual RPO lag duration in seconds.
