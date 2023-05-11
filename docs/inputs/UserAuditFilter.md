### UserAuditFilter
Filter user audit data.

- auditObjectType: a list of AuditObjectTypes
  - Filter by audit object type.
- auditSeverity: a list of AuditSeveritys
  - Filter by audit severity.
- auditStatus: a list of AuditStatuss
  - Filter by audit status.
- auditType: a list of AuditTypes
  - Filter by audit type.
- clusterId: a list of System.Strings
  - Filter by cluster UUIDs.
- hasUserNote: System.Boolean
  - Filter audits that have a user note attached.
- objectIds: a list of System.Strings
  - Filter by object IDs.
- orgIds: a list of System.Strings
  - Filter by organization ID.
- searchTerm: System.String
  - Filter by search term in audit message.
- timeGt: DateTime
  - Filter audits that have time after the specified value.
- timeLt: DateTime
  - Filter audits that have time before the specified value.
