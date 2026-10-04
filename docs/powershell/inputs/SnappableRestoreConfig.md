### SnappableRestoreConfig
Represents the snappable contents to be restored.

- destinationOrgUuid: System.String
  - UUID of the destination Office 365 organization.
- rubrikOrgUuid: System.String
  - UUID of the the logged-in user's RSC organization.
- SharePointDriveRestoreConfig: SharePointDriveRestoreConfig
  - Restore configuration for SharePoint drive jobs.
- sharePointListRestoreConfig: SharePointListRestoreConfig
  - Restore configuration for SharePoint list jobs.
- sharePointFullRestoreConfig: SharePointFullRestoreConfig
  - Restore configuration for full SharePoint jobs.
- OneDriveRestoreConfig: DriveRestoreConfig
  - Restore configuration for Onedrive jobs.
- TeamsRestoreConfig: TeamsRestoreConfig
  - Restore configuration for Teams jobs.
- fullTeamRestoreConfig: FullTeamRestoreConfig
  - Restore configuration for a full Team restore.
- MailboxRestoreConfig: MailboxRestoreConfig
  - Restore configuration for Mailbox jobs.
- calendarRestoreConfig: CalendarRestoreConfig
  - Restore configuration for Calendar jobs.
- contactsRestoreConfig: ContactsRestoreConfig
  - Restore configuration for Contacts jobs.
- inplaceRestoreConfig: InplaceRestoreConfig
  - In-place restore configuration for restore jobs.
- failedItemsRecoveryConfig: FailedItemsRecoveryConfig
  - Configuration for failed items recovery jobs.
- relicRestoreConfig: RelicRestoreConfig
  - Relic restore configuration for restore jobs.
- tasksRestoreConfig: TasksRestoreConfig
  - Restore configuration for Microsoft To Do tasks jobs.
- leaseId: System.String
  - ID of the just-in-time permission elevation lease covering this
restore's write permissions, if elevation was required. Empty for
full-access-mode apps and for JIT-mode restores that needed no write
permissions the app didn't already have. Correlates the restore
taskchain to the lease adopted in `prepare` and released in `teardown`.
