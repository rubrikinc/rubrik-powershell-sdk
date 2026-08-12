### EventDigestConfig
An event digest configuration.

- objectType: list of ActivityObjectTypeEnums
  - Object type to include in event digest.
- activityStatus: list of ActivityStatusEnums
  - Activity statuses to include in event digest.
- activityType: list of System.Strings
  - Activity types included in event digest.
- auditType: list of UserAuditTypeEnums
  - Audit types included in event digest.
- activitySeverity: list of ActivitySeverityEnums
  - Activity severities to include in event digest.
- clusters: list of System.Strings
  - Clusters to include in event digest.
- emailAddresses: list of System.Strings
  - Email addresses of the event digest recipients.
- objectIds: list of System.Strings
  - Scopes the digest to specific objects by their unique identifiers. When
empty, no object-level scoping is applied and all objects match, subject to
the other filters.
