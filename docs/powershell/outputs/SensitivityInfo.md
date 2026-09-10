### SensitivityInfo
Sensitive-data information for an anomaly.

- sensitiveHits: SensitiveHits
  - Sensitive-data hits, per risk level.
- analyzerGroupResults: list of AnalyzerGroupResults
  - Per-data-category violated-hit breakdown.
- sensitiveFilesCount: System.Int64
  - Number of files carrying at least one violated sensitive-data hit.
