### M365RecoveryPlanConditionTree
A per-workload boolean condition expression filter set for an M365 recovery
plan.

- exchange: M365ExchangeRecoveryPlanFilterTree
  - Condition expression for Exchange mailbox items. Omit to apply no Exchange filter.
- onedrive: M365OneDriveRecoveryPlanFilterTree
  - Condition expression for OneDrive file items. Omit to apply no OneDrive filter.
- sharepoint: M365SharePointRecoveryPlanFilterTree
  - Condition expression for SharePoint site and list items. Omit to apply no SharePoint filter.
