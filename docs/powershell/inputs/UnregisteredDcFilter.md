### UnregisteredDcFilter
Filter for the unifiedUnregisteredDomainControllers query. Local to
active-directory-service: only fields meaningful to unregistered DC listings
are exposed. The handler maps these to authzservice.Filter when calling
GetManagedObjectDescendants.

- field: UnregisteredDcFilterField
  - The field this filter matches on.
- texts: list of System.Strings
  - Values to match against. Within one filter the relationship is OR;
multiple filters in a request are combined with AND.
