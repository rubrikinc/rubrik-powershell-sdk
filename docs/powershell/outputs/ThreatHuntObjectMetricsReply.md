### ThreatHuntObjectMetricsReply
Response for the threat hunt object metrics.

- totalObjectsScanned: System.Int64
  - Total number of objects selected for scan.
- totalAffectedObjects: System.Int64
  - Total number of objects with at least one file match where the hunt
succeeded, partially succeeded, or is in progress.
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
- totalRegistryAffectedObjects: System.Int64
  - Total number of objects with at least one Windows registry key match. An
object with both file and registry matches is also counted in the total
affected objects, so the two must not be summed.
- totalObjectsWithMatches: System.Int64
  - Total number of objects with at least one file or registry key match,
counting each object once. Use this instead of combining
total_affected_objects and total_registry_affected_objects. For a hunt in
SUCCEEDED, PARTIALLY_SUCCEEDED or FAILED status, this plus
total_unaffected_objects and total_objects_unscannable equals
total_objects_scanned.
