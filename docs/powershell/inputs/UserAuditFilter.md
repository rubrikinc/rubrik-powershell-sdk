### UserAuditFilter
Filter user audit data.

- auditSeverity: list of AuditSeveritys
  - Filter by audit severity.
- auditStatus: list of AuditStatuss
  - Filter by audit status.
- auditType: list of AuditTypes
  - Filter by audit type.
- auditObjectType: list of AuditObjectTypes
  - Filter by audit object type.
- clusterId: list of System.Strings
  - Filter by cluster UUIDs.
- objectIds: list of System.Strings
  - Filter by object IDs.
- objectFids: list of System.Strings
  - Filter by object forever IDs.
- timeGt: DateTime
  - Filter audits that have time after the specified value.
- timeLt: DateTime
  - Filter audits that have time before the specified value.
- hasUserNote: System.Boolean
  - Filter audits that have a user note attached.
- searchTerm: System.String
  - Filter by search term in audit message.
- orgIds: list of System.Strings
  - Filter by organization ID.
