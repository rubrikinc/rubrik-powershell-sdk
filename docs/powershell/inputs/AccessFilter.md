### AccessFilter
AccessFilter specifies filtering conditions when retrieving access statistics.

- objectId: System.String
  - Object ID to filter access statistics for a specific resource.
- violationId: System.String
  - Violation ID to filter access statistics for a specific violation.
- identityId: System.String
  - Identity ID to filter access statistics for a specific identity.
- accessGrantingIdentityId: System.String
  - Access granting identity ID to filter by the identity that grants access.
- sensitivityLevels: list of RiskLevelTypes
  - Sensitivity levels to filter by data sensitivity.
- dataCategoryId: System.String
  - Data category ID to filter by data category.
- accessVia: AccessVia
  - Access type to filter by how access is granted.
- searchNameQuery: System.String
  - Search name query to filter identities by name.
- principalType: PrincipalRiskySummaryPrincipalType
  - Specifies the principal type used to filter different types of identities.
- snapshotId: System.String
  - Snapshot ID to filter access statistics for a specific snapshot.
- timelineDate: System.String
  - Timeline date to filter access statistics for a specific date (format: YYYY-MM-DD).
