### ExportPolicyViolationsCsvInput
Request to trigger an asynchronous CSV export of policy violations
matching the provided filters.

- filter: ListPolicyViolationsFilter
  - Violation-level filters (statuses, resource IDs, date ranges, etc.).
- policyFilters: PolicyFilters
  - Policy-level filters (severities, categories, frameworks).
The `policyTypes` field on this object is not used for this export;
the top-level `policyTypes` argument is authoritative.
- resourceMetadataFilters: ResourceMetadataFiltersInput
  - Resource metadata filters (identity / IDP / object metadata).
- columns: list of PolicyViolationCsvColumns
  - Ordered list of columns to include in the CSV. Order in this list
is the order in the output. When empty, the server-side default
column set for the requested (policy types, group-by) combination
is used. Columns that are not valid for the requested group-by
view are rejected (see PolicyViolationCsvColumn).
- groupBy: PolicyViolationGroupBy
  - Grouping mode for the export, mirroring the violations list UI's
group-by selector. Defaults to no grouping when unset.
- policyTypes: list of PolicyTypes
  - Policy types to scope the export to. Used for both authorization
scoping (each type's permission check must pass) and for result
filtering.
- sortField: PolicyViolationSortField
  - Field to sort the exported rows by. When unset, the export uses
the default sort order for the requested groupBy mode. Not every
sort field is meaningful in every groupBy mode; unsupported
values fall back to the default sort.
- sortOrder: SortOrder
  - Sort order (ASC / DESC) applied to sortField. Ignored when
sortField is unset.
