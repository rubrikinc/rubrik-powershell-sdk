### UserAuditGroupByInfo
Group by information for the requested audits. Includes both primary and secondary group by fields.

- count: System.Int64
  - Number of audits matching the group by information.
- groupByField: UserAuditGroupBy
  - Group by field corresponding to the set of audits.
- groupByValue: System.String
  - String value of the group by field.
- secondaryGroupByInfo: a list of UserAuditGroupByBases
  - List of audit group by information per secondary group by field.
