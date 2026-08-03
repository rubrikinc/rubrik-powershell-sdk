### M365SharePointRecoveryPlanFilterLeaf
A leaf predicate for SharePoint site and list items.
Exactly one primitive field must be set.

- fileName: M365StringListFilter
  - Filter by file or item name.
- fileExtensions: M365StringListFilter
  - Filter by file extension.
- fileSize: M365IntRangeFilter
  - Filter by file size in bytes.
