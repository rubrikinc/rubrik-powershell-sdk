### M365OneDriveRecoveryPlanFilterLeaf
A leaf predicate for OneDrive file items.
Exactly one primitive field must be set.

- fileName: M365StringListFilter
  - Filter by file name.
- fileExtensions: M365StringListFilter
  - Filter by file extension.
- fileSize: M365IntRangeFilter
  - Filter by file size in bytes.
- createTime: RecoveryPlanFilterTimeRange
  - Filter by creation time.
- modifiedTime: RecoveryPlanFilterTimeRange
  - Filter by last-modified time.
- hasUniquePermissions: System.Boolean
  - Filter by unique-permissions status.
- createdByEmail: M365StringListFilter
  - Filter by the email of the identity that created the item.
- lastModifiedByEmail: M365StringListFilter
  - Filter by the email of the identity that last modified the item.
