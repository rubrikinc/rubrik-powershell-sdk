### ObjectRecordsChangeFilter
The filter to be applied on the change summary for Salesforce object records

- actionTypes: list of AppItemActionTypes
  - Filters records for a Salesforce object according to the action types that were performed on the records (added, deleted, and/or updated) during the specified time.
- clauseItems: list of WhereSqlClauseItems
  - Filters Salesforce records that satisfy the specified clauses. The clauses are joined together by an AND operator.
- searchTerm: System.String
  - Filters metadata records with the matching id or name (substring).
