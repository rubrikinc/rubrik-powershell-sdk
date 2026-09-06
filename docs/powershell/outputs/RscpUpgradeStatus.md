### RscpUpgradeStatus
Upgrade status of the RSC-P appliance.

- version: System.String
  - Version of the software installed on the appliance.
- rscClusterUpgradeStatus: RscUpgradeStatusType
  - Upgrade status of the appliance. For example, Upgrading,
ReadyForUpgrade, or UpgradeFailed.
- uiStatus: System.String
  - Status to display for the appliance upgrade.
- uiStatusAttributes: UiStatusAttributes
  - Additional details for the displayed status. Includes the source and
target versions, progress, remaining time, and failed task.
- statusGenTimestamp: DateTime
  - Time at which the status was last determined. The status is retained if
the appliance stops responding, so this indicates how current it is.
