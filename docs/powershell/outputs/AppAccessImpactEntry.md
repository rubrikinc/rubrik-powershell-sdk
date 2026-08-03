### AppAccessImpactEntry
A single impact bucket (e.g., all apps where access was revoked).

- impactType: AppAccessImpactType
  - Classification of this impact bucket.
- appsCount: System.Int32
  - Total number of affected apps. This may exceed the number of apps
returned when capped by the request limit.
- apps: list of AppNodes
  - Affected apps, capped by the request limit.
