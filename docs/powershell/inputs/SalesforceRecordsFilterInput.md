### SalesforceRecordsFilterInput
Filter for Salesforce object records.

- isRelic: System.Boolean
  - Filters relic records.
- searchTerm: System.String
  - Filters Salesforce records by matching the name or ID to the specified search string.
- clauseItems: list of WhereSqlClauseItems
  - Filters Salesforce records that satisfy the specified clauses. The clauses are joined together by an AND operator.
