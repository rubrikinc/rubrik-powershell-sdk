### ThreatHuntObjectMetricsReply
Response for the threat hunt object metrics.

- totalObjectsScanned: System.Int64
  - Total number of objects selected for scan.
- totalAffectedObjects: System.Int64
  - Total number of objects in which malware was found and hunt succeeded, or partially succeeded, or is in progress.
- totalUnaffectedObjects: System.Int64
  - Total number of objects in which malware was not found and hunt succeeded.
- totalObjectsUnscannable: System.Int64
  - Total number of objects where hunt failed, or partially succeeded without matches, or did not scan.
- unaffectedObjectsFromDb: System.Int64
  - Number of objects from the database in which malware was not found, this
can vary from the totalUnaffectedObjects for turbo threat hunts.
- cleanRecoverableObjectLimit: System.Int64
  - Maximum number of clean objects eligible for cyber recovery that can be
stored in the database. This can vary based on the corresponding AST value.
