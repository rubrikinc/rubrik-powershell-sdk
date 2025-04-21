### UiStatusAttributes
UI status attributes.

- sourceVersion: System.String
  - The version of the cluster before the upgrade.
- targetVersion: System.String
  - The version of the cluster after the upgrade.
- progress: System.Single
  - The progress percentage for the UI status operation.
- remainingTimeSec: System.Int32
  - Remaining time in seconds for the UI status operation.
- startTime: System.String
  - Start time for the UI status operation.
- endTime: System.String
  - End time for the UI status operation.
- upgradeScheduledTime: System.String
  - Scheduled upgrade timestamp.
- ruDoneNodesCount: System.Int32
  - Number of nodes where rolling upgrade is complete.
- ruTotalNodesCount: System.Int32
  - Total number of nodes in the Rubrik cluster performing rolling upgrade.
