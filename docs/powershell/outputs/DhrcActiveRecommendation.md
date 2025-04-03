### DhrcActiveRecommendation
Recommendation represents a single textual recommendation how to increase the
score for a specific category. Recommendations are derived from a set of
metrics.

- key: DhrcRecommendationKey
  - The key uniquely identifies the type of the recommendation. One use-case is
for translation of the recommendation message.
- category: DhrcCategory
  - The category that the recommendation belong to.
- compiledAt: DateTime
  - The time that the recommendation was compiled from the set of metrics.
- earliestMetric: DateTime
  - The earliest (oldest) metric used to compile the recommendation.
- weight: System.Single
  - The weight of the issue this recommendation aims to resolve. Heavier means
the issue is more severe.
- message: System.String
  - The textual recommendation compiled by the service, always in English.
- translationArgs: list of DhrcKeyValues
  - The translation arguments of the recommendation. Stored as key/value pairs.
