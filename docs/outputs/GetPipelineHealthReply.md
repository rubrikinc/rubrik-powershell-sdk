### GetPipelineHealthReply
Specifies the health metric for the Ransomware Investigation pipeline covering the backup, indexing, and analysis jobs.

- failedAnalysis: System.Int64
  - The number of failed analysis operations in the specified time range.
- failedBackup: System.Int64
  - The number of failed backups in the specified time range.
- failedIndexing: System.Int64
  - The number of failed indexing operations in the specified time range.
- totalAnalysis: System.Int64
  - The total number of analysis operations in the specified time range.
- totalBackup: System.Int64
  - The total number of backups in the specified time range.
- totalIndexing: System.Int64
  - The total number of indexing operations in the specified time range.
