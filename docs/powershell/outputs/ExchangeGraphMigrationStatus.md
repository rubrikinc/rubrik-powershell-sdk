### ExchangeGraphMigrationStatus
Status of the EWS to Microsoft Graph migration for an org's protected Exchange mailboxes.

- isInProgress: System.Boolean
  - Whether the org has protected mailboxes that are not yet on Microsoft Graph.
- mailboxesPendingGraphMigration: System.Int32
  - Count of protected, active mailboxes not yet on Microsoft Graph.
