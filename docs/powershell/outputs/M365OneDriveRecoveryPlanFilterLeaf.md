### M365OneDriveRecoveryPlanFilterLeaf
A leaf predicate for OneDrive file items.
Exactly one primitive field must be set.

- fileName: M365StringListFilter
  - Filter by file name.
- fileExtensions: M365StringListFilter
  - Filter by file extension.
- fileSize: M365IntRangeFilter
  - Filter by file size in bytes.
