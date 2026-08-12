### IcebergSlaConfigInput
Input to configure the SLA Domain for Apache Iceberg table objects.

- snapshotSelectionStrategy: IcebergSnapshotSelectionStrategy
  - Which snapshot to select. If omitted, defaults to LATEST.
- tagRegex: System.String
  - RE2 regular expression matched against tag ref names. Only applies when
the tagged strategy is selected; an empty pattern matches all tags.
- fallbackToLatest: System.Boolean
  - Whether to fall back to the latest snapshot when the selected snapshot
cannot be resolved (no compacted snapshot for the compacted strategy, or
no matching tag for the tagged strategy). Ignored for the latest
strategy, which always resolves; when false, an unresolvable selection
fails the backup.
