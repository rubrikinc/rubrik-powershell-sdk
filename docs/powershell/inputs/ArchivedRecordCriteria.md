### ArchivedRecordCriteria
Criteria used to select archived records, shared by the browse,
download, and unarchive flows. A free-text search term and/or
field-level conditions; both optional. Empty criteria (no search
term, no conditions) match every archived record for the object.

- searchTerm: System.String
  - Case-insensitive substring OR-matched against recordId and
recordName -- the "search by record ID or name" box. Empty/absent
imposes no search-term constraint.
- recordFilters: RecordFilter
  - Filter expression whose conditions are connected by AND. Records
must match all conditions. Empty/absent imposes no field
conditions.
