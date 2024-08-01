### DhrcScore
Score represent a score for a single category. Scores are calculated from a
 set of metrics.

- category: DhrcCategory
  - The category that the score belong to.
- calculatedAt: DateTime
  - The time that the score was calculated.
- earliestMetric: DateTime
  - The time at which the earliest (oldest) metric used to calculate the score
 was collected.
- value: System.Single
  - The score value, always between 0 and 100.
- date: DateTime
  - The time of this score. This may differ from the time the score was
 calculated if padding was used to introduce the score.
- context: DhrcScoreContext
  - The calculation context for the score.
