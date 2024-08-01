### CompareSalesforceRecords
Comparison of Salesforce records across 2 snapshots or between a snapshot and a live environment.

- fields: list of SalesforceObjectFields
  - Fields for which the values are returned. The order of the fields and the values in the record are correlated.
- offset: System.Int32
- total: System.Int32
  - Total number of Salesforce record changes.
- recordChangesConnection: ObjectRecordChangeConnection
  - List of Salesforce object records across the 2 snapshots or live environments.
