# New-RscQuerySnapshot
## Subcommands
### browsefilelist
Returns a list files whose name is prefixed by the query in the given snapshot.

- There are 5 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - path - System.String: The path under which you want your search to run.
    - snapshotFid - System.String: Snapshot persistent UUID in RSC.
    - searchPrefix - System.String: Prefix arg for searching for files within a snapshot.
- Returns SnapshotFileConnection.
### byids
Returns the details for the passed snapshot IDs.

- There are 2 arguments.
    - snapshotFids - list of System.Strings: List of snapshot UUIDs.
    - shouldShowSnapshotRetentionInfo - System.Boolean: Specifies whether to show snapshot retention.
- Returns list of GenericSnapshots.
### closesttopointintime
Details of the unexpired snapshot closest to the specified point in time for each provided workload ID.

- There are 13 arguments.
    - beforeTime - DateTime: Specifies the time at which or before which the snapshot was taken.
    - afterTime - DateTime: Specifies the time at which or after which the snapshot was taken.
    - snappableIds - list of System.Strings: Workload UUIDs.
    - includeLinked - System.Boolean: Specifies whether the retrieved snapshots should include the linked snapshots.
    - ignoreActiveWorkloadCheck - System.Boolean: Specifies whether to ignore the active workload check.
    - excludeQuarantined - System.Boolean: Specifies whether to exclude quarantined snapshots.
    - excludeAnomalous - System.Boolean: Specifies whether to exclude anomalous snapshots.
    - quarantinedOnly - System.Boolean: Specifies whether to only include quarantined snapshots.
    - anomalousOnly - System.Boolean: Specifies whether to only include anomalous snapshots.
    - getFullDetails - System.Boolean: Specifies whether to include full snapshot workload details.
    - excludeReplica - System.Boolean: Specifies whether to exclude replica snapshots.
    - excludeArchivalLocationTypes - list of System.Strings: List of archival location types that, if a snapshot is stored in them, will exclude the snapshot from query results.
    - archivalLocationId - System.String: Filter snapshots by archival location ID. Only snapshots stored at this archival location will be returned. If the value is null, no filter is applied.
- Returns list of ClosestSnapshotSearchResults.
### clouddirect
Returns a NAS Cloud Direct snapshot by ID.

- There is a single argument of type System.String.
- Returns CloudDirectSnapshot.
### clouddirects
Returns a list of NAS Cloud Direct snapshots.

- There are 6 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that occur before the specified cursor.
    - filter - list of CloudDirectSnapshotsFilterInputs: Filter for NAS Cloud Direct snapshots.
    - sortBy - CloudDirectSnapshotsSortByInput: Sort NAS Cloud Direct snapshots.
- Returns CloudDirectSnapshotConnection.
### emailsearch
- There are 6 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - snappableFid - System.String: The FID for the workload.
    - snapshotFid - System.String: The ID of the snapshot.
    - orgId - System.String: Org UUID.
    - searchFilter - SearchFilter: search filters
- Returns O365ExchangeObjectConnection.
### eventsearch
- There are 6 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - snappableFid - System.String: The FID for the workload.
    - snapshotFid - System.String: The ID of the snapshot.
    - orgId - System.String: Org UUID.
    - calendarSearchFilter - CalendarSearchFilter: Search filter for calendar search.
- Returns O365ExchangeObjectConnection.
### filesdelta
Browse or search the given path for files and directories along with their deltas in a given snapshot.

- There are 8 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - path - System.String: The path under which you want your search to run.
    - snapshotFid - System.String: Snapshot persistent UUID in RSC.
    - filter - SnapshotDeltaFilterInput: Filter snapshot delta based on delta types.
    - searchPrefix - System.String: Prefix arg for searching for files within a snapshot.
    - quarantineFilters - list of QuarantineFilters: Filter entries based on quarantine status of the entries in the base snapshot.
    - workloadFieldsArg - WorkloadFieldsInput: Workload fields in BrowseSnapshotFileDelta request.
- Returns SnapshotFileDeltaConnection.
### filesdeltav2
Browse or search the given path for files and directories along with their deltas in a given snapshot.

- There are 10 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - path - System.String: The path under which you want your search to run.
    - snapshotFid - System.String: Snapshot persistent UUID in RSC.
    - filter - SnapshotDeltaFilterInput: Filter snapshot delta based on delta types.
    - searchPrefix - System.String: Prefix arg for searching for files within a snapshot.
    - quarantineFilters - list of QuarantineFilters: Filter entries based on quarantine status of the entries in the base snapshot.
    - sensitiveDataDiscoveryFilters - SensitiveDataDiscoveryFiltersInput: Filters for sensitive data discovery results.
    - sort - FileResultSortInput: Sorts to apply when listing file results.
    - workloadFieldsArg - WorkloadFieldsInput: Workload fields in BrowseSnapshotFileDelta request.
- Returns SnapshotFileDeltaV2Connection.
### fileset
- There are 2 arguments.
    - id - System.String: ID of snapshot.
    - verbose - System.Boolean: Whether or not to fetch verbose fileset snapshot information. The performance of this endpoint will decrease if set to true.
- Returns FilesetSnapshotDetail.
### filesetfiles
Lists all files and directories in a given path

Supported in v5.0+
Lists all files and directories in a given path.

- There are 4 arguments.
    - id - System.String: ID of snapshot.
    - limit - System.Int32: Maximum number of entries in the response.
    - offset - System.Int32: Starting position in the list of path entries contained in the query results, sorted by lexicographical order. The response includes the specified numbered entry and all higher numbered entries.
    - path - System.String: The absolute path of the starting point for the directory listing.
- Returns BrowseResponseListResponse.
### legalholdsnappable
List of legal hold snapshots for a workload.

- There are 5 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that occur before the specified cursor.
    - input - LegalHoldSnapshotsForSnappableInput: Query legal hold snapshots for a workload.
- Returns LegalHoldSnapshotDetailConnection.
### newestforclouddirectobject
Returns the newest snapshot for a Cloud Direct object, such as a share or bucket. The results can be optionally filtered by target ID.

- There are 2 arguments.
    - workloadId - System.String: The ID of the workload.
    - cloudDirectTargetId - System.String: The NAS Cloud Direct target ID.
- Returns CloudDirectSnapshot.
### oldestforclouddirectobject
Returns the oldest snapshot for a Cloud Direct object, such as a share or bucket. The results can be optionally filtered by target ID.

- There are 2 arguments.
    - workloadId - System.String: The ID of the workload.
    - cloudDirectTargetId - System.String: The NAS Cloud Direct target ID.
- Returns CloudDirectSnapshot.
### onedrivesearch
- There are 6 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - snappableFid - System.String: The FID for the workload.
    - snapshotFid - System.String: The ID of the snapshot.
    - orgId - System.String: Org UUID.
    - onedriveSearchFilter - OnedriveSearchFilter
- Returns O365OnedriveObjectConnection.
### polaris
Returns the RSC snapshot according to ID.

- There is a single argument of type System.String.
- Returns PolarisSnapshot.
### possiblelocationsforobjects
GetPossibleSnapshotLocationsForObjects returns all valid
locations where unexpired snapshots of the objects are present.
This includes both RSC (MBL archival groups) and CDM snapshot locations.

- There is a single argument of type GetPossibleSnapshotLocationsForObjectsInput.
- Returns GetPossibleSnapshotLocationsForObjectsResp.
### pvcs
All PVCs in a snapshot.

- There are 3 arguments.
    - snapshotId - System.String: The snapshot ID.
    - snappableId - System.String: The FID of the workload.
    - isReplica - System.Boolean: Specifies if the snapshot is a replica snapshot.
- Returns list of PvcInformations.
### quarantineddetails
Quarantine details of all snapshots.

- There is a single argument of type list of System.Strings.
- Returns list of QuarantineSpecs.
### results
Returns snapshot results for a workload.

- There are 3 arguments.
    - snappableFid - System.String
    - startTimeMs - System.Int64: Begin time of the range (in milliseconds since epoch)
    - endTimeMs - System.Int64: End time of the range (in milliseconds since epoch)
- Returns SnapshotResultConnection.
### snappablelist
Returns a list of snapshots for a workload.

- There are 13 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that occur before the specified cursor.
    - workloadId - System.String: The FID of the workload.
    - snapshotFilter - list of SnapshotQueryFilterInputs: Filters for snapshot connection.
    - sortOrder - SortOrder: Sorts the order of results.
    - sortBy - SnapshotQuerySortByField: Sorts snapshots by field.
    - timeRange - TimeRangeInput: Time range input.
    - ignoreActiveWorkloadCheck - System.Boolean: Specifies whether to ignore the active workload check.
    - showSnapshotRetentionInfo - System.Boolean: Specifies whether to show retention information of snapshots of RSC native workloads.
    - includeOnlySourceSnapshots - System.Boolean: Specifies whether to include source snapshots or not. If its true, response will contain only source snapshots.
    - shouldExcludeCdmSnapshotRetentionInfo - System.Boolean: Specifies whether to show snapshot retention for snapshots of CDM workloads.
- Returns GenericSnapshotConnection.
### snappableslist
Returns list of snapshots for a list of workloads.

- There are 12 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that occur before the specified cursor.
    - snappableIds - list of System.Strings: Workload UUIDs.
    - snapshotFilter - list of SnapshotQueryFilterInputs: Filters for snapshot connection.
    - sortOrder - SortOrder: Sorts the order of results.
    - sortBy - SnapshotQuerySortByField: Sorts snapshots by field.
    - timeRange - TimeRangeInput: Time range input.
    - ignoreActiveWorkloadCheck - System.Boolean: Specifies whether to ignore the active workload check.
    - includeOnlySourceSnapshots - System.Boolean: Specifies whether to include source snapshots or not. If its true, response will contain only source snapshots.
    - shouldExcludeCdmSnapshotRetentionInfo - System.Boolean: Specifies whether to show snapshot retention for snapshots of CDM workloads.
- Returns GenericSnapshotConnection.
### snappableswithlegalholdssummary
List of workloads with legal hold snapshots.

- There are 5 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that occur before the specified cursor.
    - input - SnappablesWithLegalHoldSnapshotsInput: Input to retrieve workloads with legal hold snapshots.
- Returns LegalHoldSnappableDetailConnection.
### snapshot
Returns a single snapshot by snapshot forever UUID and cluster UUID. In case cluster UUID is not provided, the snapshot forever UUID is used to resolve it. Cluster UUID is beneficial for fetching the same snapshot in a different replication target Rubrik cluster.

- There are 2 arguments.
    - snapshotFid - System.String: Snapshot persistent UUID in RSC.
    - clusterUuid - System.String: The Rubrik cluster ID.
- Returns CdmSnapshot.
### sofclouddirectbucket
Returns a list of NAS Cloud Direct snapshots for a bucket.

- There are 10 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that occur before the specified cursor.
    - workloadId - System.String: The FID of the workload.
    - snapshotFilter - list of SnapshotQueryFilterInputs: Filters for snapshot connection.
    - sortOrder - SortOrder: Sorts the order of results.
    - sortBy - SnapshotQuerySortByField: Sorts snapshots by field.
    - timeRange - TimeRangeInput: Time range input.
    - cloudDirectTargetId - System.String: The NAS Cloud Direct target ID.
- Returns CloudDirectSnapshotConnection.
### sofclouddirectshare
Returns a list of NAS Cloud Direct snapshots for a share.

- There are 10 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that occur before the specified cursor.
    - workloadId - System.String: The FID of the workload.
    - snapshotFilter - list of SnapshotQueryFilterInputs: Filters for snapshot connection.
    - sortOrder - SortOrder: Sorts the order of results.
    - sortBy - SnapshotQuerySortByField: Sorts snapshots by field.
    - timeRange - TimeRangeInput: Time range input.
    - cloudDirectTargetId - System.String: The NAS Cloud Direct target ID.
- Returns CloudDirectSnapshotConnection.
### totalclouddirectobject
Retrieves the total count of snapshots for a Cloud Direct object.
The results can be filtered optionally by target ID.

- There is a single argument of type TotalSnapshotsForCloudDirectObjectReq.
- Returns TotalSnapshotsForCloudDirectObjectReply.
### unmanagedobject
List of snapshots for unmanaged objects.

- There are 5 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that occur before the specified cursor.
    - input - QueryUnmanagedObjectSnapshotsV1Input: Input for V1QueryUnmanagedObjectSnapshotsV1.
- Returns SnapshotSummaryConnection.
### vappinstantrecoveryoptions
Options for instantly recovering a vApp snapshot.

- There is a single argument of type VappSnapshotInstantRecoveryOptionsInput.
- Returns VappInstantRecoveryOptions.
### vapptemplateexportoptions
Export options for a vApp snapshot template.

- There is a single argument of type VappTemplateSnapshotExportOptionsInput.
- Returns VappTemplateExportOptionsUnion.
