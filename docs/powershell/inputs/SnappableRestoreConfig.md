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
