### OracleConfigInput
Input to configure the log settings for Oracle database in an SLA Domain.

- frequency: SlaDurationInput
  - Frequency for log backups of Oracle databases.
- logRetention: SlaDurationInput
  - The duration for which the logs will be retained.
- hostLogRetention: SlaDurationInput
  - The duration for which the archived redo logs will be retained.
