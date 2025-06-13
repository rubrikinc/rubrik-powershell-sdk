### FailedRestoreItemsInfoReply
Represents information on Microsoft 365 restore
 failed items performed by Rubrik.

- failedItems: list of FailedRestoreItemInfos
  - A collection of up to 20 failed items.
- totalFailedItemCount: System.Int32
  - Total count of failed items encountered.
- canExportFailedItems: System.Boolean
  - Indicates whether the failed items export can be triggered.
- exportDisabledReason: RestoreFailedItemsExportDisabledReason
  - Provides a reason why failed items export is not enabled.
- csvDownloadLink: System.String
  - Click the link to download a CSV file containing
 the Microsoft 365 failed items.
