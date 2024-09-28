# New-RscQueryM365
## Subcommands
### backupstoragelicenseusage
Returns usage of Microsoft backups storage for an account.

- The backupstoragelicenseusage subcommand takes no arguments.
- Returns M365BackupStorageLicenseUsage.
### backupstorageobjectrestorepoints
Lists the Microsoft 365 backup storage object restore points.

- There are 3 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - m365BackupStorageObjectRestorePointsInput - M365BackupStorageObjectRestorePointsInput: The input to list Microsoft 365 Backup Storage restore points.
- Returns M365BackupStorageRestorePointConnection.
### daytodaymodestats
Returns the statistics of an M365 organization product in day-to-day mode.

- There are 2 arguments.
    - orgId - System.String: Org UUID.
    - dashboardWorkloadType - M365DashboardWorkloadType: Workload type for M365 dashboard.
- Returns DayToDayModeStats.
### directoryobjectattributes
Lists down the directory object attribute present in the Microsoft tenant.

- There is a single argument of type ListM365DirectoryObjectAttributesInput.
- Returns ListO365DirectoryObjectAttributesResp.
### licenseentitlement
Display license entitlement for M365 workloads.

- The licenseentitlement subcommand takes no arguments.
- Returns M365LicenseEntitlementReply.
### onboardingmodebackupstats
Returns the backup statistics of an M365 organization product in onboarding mode.

- There are 3 arguments.
    - orgId - System.String: Org UUID.
    - dashboardWorkloadType - M365DashboardWorkloadType: Workload type for M365 dashboard.
    - backupStatsTimeRange - BackupStatsTimeRange: Time range for backup statistics.
- Returns OnboardingModeBackupStats.
### onboardingmodestats
Returns the statistics of an M365 organization product in onboarding mode.

- There are 2 arguments.
    - orgId - System.String: Org UUID.
    - dashboardWorkloadType - M365DashboardWorkloadType: Workload type for M365 dashboard.
- Returns OnboardingModeStats.
### orgbackuplocations
Returns the backup locations of an M365 organization.

- There is a single argument of type System.String.
- Returns M365OrgBackupLocations.
### orgoperationmodes
Returns the operation modes of an M365 organization.

- There is a single argument of type System.String.
- Returns M365OrgOperationModes.
### regions
Retrieves the M365 regions for the organization.

- There is a single argument of type System.String.
- Returns M365RegionsResp.
