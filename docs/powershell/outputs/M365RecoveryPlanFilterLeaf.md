### M365RecoveryPlanFilterLeaf
A leaf node holding a single filter predicate. Exactly one
workload-specific field (exchange, onedrive, or sharepoint) must be set.

- exchange: M365ExchangeRecoveryPlanFilterLeaf
  - Exchange mailbox leaf predicate.
- onedrive: M365OneDriveRecoveryPlanFilterLeaf
  - OneDrive file leaf predicate.
- sharepoint: M365SharePointRecoveryPlanFilterLeaf
  - SharePoint site and list item leaf predicate.
