### GetPossibleSnapshotLocationsForObjectsInput
GetPossibleSnapshotLocationsForObjectsReq is the input for
GetPossibleSnapshotLocationsForObjects query.

- objectIds: list of System.Strings
  - IDs of the objects for which possible snapshot locations are to be
returned.
- pagination: Pagination
  - Pagination parameters to control the response size.
Optional - if not provided, all results will be returned.
- onlyLocationsWithSnapshots: System.Boolean
  - When true, only locations that currently hold an unexpired snapshot of the
objects are returned. Otherwise, the response also carries the backup
locations configured on the objects' SLA Domain, which need not hold any
snapshot yet.
This field is optional and defaults to false.
