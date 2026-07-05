### ActivityTimelineResult
Aggregated activity for a single day in a user activity timeline.

- day: System.String
  - Day the activity occurred on, formatted as YYYY-MM-DD.
- topFiles: list of FileAccessResults
  - Top files accessed on this day.
- activityResults: list of ActivityResults
  - Aggregated activity counts across all files for this day.
