# New-RscQuerySnapshot
## Subcommands
### browsefilelist
Returns a list files whose name is prefixed by the query in the given snapshot.

- There are 5 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - path - System.String: The path under which you want your search to run.
    - snapshotFid - System.String: Snapshot persistent UUID in RSC.
    - searchPrefix - System.String: Prefix arg for searching for files within a snapshot.
- Returns SnapshotFileConnection.
### closesttopointintime
Details of the unexpired snapshot closest to the specified point in time for each provided workload ID.

- There are 8 arguments.
    - beforeTime - DateTime: Specifies the time at which or before which the snapshot was taken.
    - afterTime - DateTime: Specifies the time at which or after which the snapshot was taken.
    - snappableIds - list of System.Strings: Workload UUIDs.
    - includeLinked - System.Boolean: Specifies whether the retrieved snapshots should include the linked snapshots.
    - ignoreActiveWorkloadCheck - System.Boolean: Specifies whether to ignore the active workload check.
    - excludeQuarantined - System.Boolean: Specifies whether to exclude quarantined snapshots.
    - excludeAnomalous - System.Boolean: Specifies whether to exclude anomalous snapshots.
    - getFullDetails - System.Boolean: Specifies whether to include full snapshot workload details.
- Returns list of ClosestSnapshotSearchResults.
### clouddirect
Returns a Cloud Direct snapshot by ID.

- There is a single argument of type System.String.
- Returns CloudDirectSnapshot.
### clouddirects
Returns a list of Cloud Direct snapshots.

- There are 4 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - filter - list of CloudDirectNasSnapshotsFilterInputs: Filter for Cloud Direct NAS snapshots.
    - sortBy - CloudDirectNasSnapshotsSortByInput: Sort Cloud Direct NAS snapshots.
- Returns CloudDirectSnapshotConnection.
### comparesalesforcerecordsbetweenandlive
Compares the records of a given object between a snapshot and the live environment

- There are 10 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
    - workloadId - System.String: The ID of the workload.
    - salesforceRecordIds - list of System.Strings: List of Salesforce record IDs.
    - leftSnapshotNumber - System.Int32: The snapshot number of the snapshot selected on the left side.
    - sortBy - System.String: Field name to sort Salesforce records by.
    - sortOrder - SortOrder: Sort order of result.
    - fieldNames - list of System.Strings: The list of fields for which the record values must be returned. An empty input returns values for the ID and name fields only.
- Returns CompareSalesforceRecords.
### comparisonsbetweensaasappandlive
Compares the version of a data item in the snapshot to the version in the live environment.

- There are 5 arguments.
    - saasAppType - SaasAppType: SaaS application type.
    - workloadId - System.String: The Rubrik ID of the workload.
    - itemId - System.String: The ID of the data item. For example, the natural ID of a Jira project issue.
    - snapshotId - System.String: The Rubrik ID of the snapshot.
    - appItemTypeToken - System.String: Token specifying the type of the data item. The token should match the token retrieved by the GraphQL query.
- Returns CompareSnapshotsReply.
### comparisonsbetweensaasapps
Compares item data of the two selected snapshots.

- There are 6 arguments.
    - saasAppType - SaasAppType: SaaS application type.
    - workloadId - System.String: The Rubrik ID of the workload.
    - itemId - System.String: The ID of the data item. For example, the natural ID of a Jira project issue.
    - leftSnapshotNumber - System.Int32: The snapshot number of the snapshot selected on the left side.
    - rightSnapshotNumber - System.Int32: The snapshot number of the snapshot selected on the right side.
    - appItemTypeToken - System.String: Token specifying the type of the data item. The token should match the token retrieved by the GraphQL query.
- Returns CompareSnapshotsReply.
### emailsearch
- There are 6 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - snappableFid - System.String: The fid for the workload.
    - snapshotFid - System.String: The ID of the snapshot.
    - orgId - System.String: Org UUID.
    - searchFilter - SearchFilter: search filters
- Returns O365ExchangeObjectConnection.
### eventsearch
- There are 6 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - snappableFid - System.String: The fid for the workload.
    - snapshotFid - System.String: The ID of the snapshot.
    - orgId - System.String: Org UUID.
    - calendarSearchFilter - CalendarSearchFilter: Search filter for calendar search.
- Returns O365ExchangeObjectConnection.
### filesdelta
Browse or search the given path for files and directories along with their deltas in a given snapshot.

- There are 8 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - path - System.String: The path under which you want your search to run.
    - snapshotFid - System.String: Snapshot persistent UUID in RSC.
    - filter - SnapshotDeltaFilterInput: Filter snapshot delta based on delta types.
    - searchPrefix - System.String: Prefix arg for searching for files within a snapshot.
    - quarantineFilters - list of QuarantineFilters: Filter entries based on quarantine status of the entries in the base snapshot.
    - workloadFieldsArg - WorkloadFieldsInput: Workload fields in BrowseSnapshotFileDelta request.
- Returns SnapshotFileDeltaConnection.
### filesdeltav2
Browse or search the given path for files and directories along with their deltas in a given snapshot.

- There are 8 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - path - System.String: The path under which you want your search to run.
    - snapshotFid - System.String: Snapshot persistent UUID in RSC.
    - filter - SnapshotDeltaFilterInput: Filter snapshot delta based on delta types.
    - searchPrefix - System.String: Prefix arg for searching for files within a snapshot.
    - quarantineFilters - list of QuarantineFilters: Filter entries based on quarantine status of the entries in the base snapshot.
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
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
    - input - LegalHoldSnapshotsForSnappableInput: Query legal hold snapshots for a workload.
- Returns LegalHoldSnapshotDetailConnection.
### onedrivesearch
- There are 6 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - snappableFid - System.String: The fid for the workload.
    - snapshotFid - System.String: The ID of the snapshot.
    - orgId - System.String: Org UUID.
    - onedriveSearchFilter - OnedriveSearchFilter
- Returns O365OnedriveObjectConnection.
### polaris
Returns the RSC snapshot according to ID.

- There is a single argument of type System.String.
- Returns PolarisSnapshot.
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
### saasappitemindividuals
Returns snapshots containing the specified data item.

- There are 9 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
    - workloadId - System.String: The Rubrik ID of the workload.
    - itemId - System.String: The ID of the data item. For example, the natural ID of a Jira project issue.
    - saasAppType - SaasAppType: SaaS application type.
    - appItemTypeToken - System.String: Token specifying the type of the data item. The token should match the token retrieved by the GraphQL query.
    - timeFilter - TimeFilter: Filter to restrict results within a time range.
- Returns SaasAppSnapshotConnection.
### saasappitemoverlappings
Returns snapshots that contain all of the specified data items.

- There are 11 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
    - workloadId - System.String: The Rubrik ID of the workload.
    - itemIds - list of System.Strings: The IDs of the data items. For example, the natural IDs of Jira project issues.
    - appItemTypeToken - System.String: Token specifying the type of the data item. The token should match the token retrieved by the GraphQL query.
    - saasAppType - SaasAppType: SaaS application type.
    - timeFilter - TimeFilter: Filter to restrict results within a time range.
    - sortBy - SnapshotSortByField: Field to sort the snapshots.
    - sortOrder - SortOrder: Sort order of result.
- Returns SaasAppSnapshotConnection.
### saasapplatestitems
Returns the latest snapshot in the time range for each data item.

- There are 5 arguments.
    - workloadId - System.String: The Rubrik ID of the workload.
    - itemIds - list of System.Strings: The IDs of the data items. For example, the natural IDs of Jira project issues.
    - saasAppType - SaasAppType: SaaS application type.
    - appItemTypeToken - System.String: Token specifying the type of the data item. The token should match the token retrieved by the GraphQL query.
    - timeFilter - TimeFilter: Filter to restrict results within a time range.
- Returns list of ItemSnapshots.
### sanomalyinfo
Get anomaly information for snapshots.

- There is a single argument of type SnapshotsMalwareInfoInput.
- Returns SnapshotsMalwareInfoReply.
### smalwareinfo
Get malware information for snapshots.

- There is a single argument of type SnapshotsMalwareInfoInput.
- Returns SnapshotsMalwareInfoReply.
### snapmirrorcloudfiles
Lists all files and directories in a given path

Supported in v7.0+
Lists all files and directories in a given path.

- There is a single argument of type SnapMirrorCloudSnapshotFilesInput.
- Returns BrowseResponseListResponse.
### snappablelist
Returns a list of snapshots for a workload.

- There are 10 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
    - workloadId - System.String: The FID of the workload.
    - snapshotFilter - list of SnapshotQueryFilterInputs: Filter for snapshot connection.
    - sortOrder - SortOrder: Sort order of result.
    - sortBy - SnapshotQuerySortByField: Sort snapshots by field.
    - timeRange - TimeRangeInput: Time range input.
    - ignoreActiveWorkloadCheck - System.Boolean: Specifies whether to ignore the active workload check.
- Returns GenericSnapshotConnection.
### snappableslist
Returns list of snapshots for a list of workloads.

- There are 10 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
    - snappableIds - list of System.Strings: Workload UUIDs.
    - snapshotFilter - list of SnapshotQueryFilterInputs: Filter for snapshot connection.
    - sortOrder - SortOrder: Sort order of result.
    - sortBy - SnapshotQuerySortByField: Sort snapshots by field.
    - timeRange - TimeRangeInput: Time range input.
    - ignoreActiveWorkloadCheck - System.Boolean: Specifies whether to ignore the active workload check.
- Returns GenericSnapshotConnection.
### snappableswithlegalholdssummary
List of workloads with legal hold snapshots.

- There are 5 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
    - input - SnappablesWithLegalHoldSnapshotsInput: Input to retrieve workloads with legal hold snapshots.
- Returns LegalHoldSnappableDetailConnection.
### snapshot
Returns a single snapshot by snapshot forever UUID and cluster UUID. In case cluster UUID is not provided, the snapshot forever UUID is used to resolve it. Cluster UUID is beneficial for fetching the same snapshot in a different replication target Rubrik cluster.

- There are 2 arguments.
    - snapshotFid - System.String: Snapshot persistent UUID in RSC.
    - clusterUuid - System.String: The Rubrik cluster ID.
- Returns CdmSnapshot.
### storageaccountdetaildownloadurl
URL that contains the summary details of the objects in the snapshot.

- There is a single argument of type System.String.
- Returns StorageAccountSnapshotDetailDownloadUrlReply.
### unmanagedobject
List of snapshots for unmanaged objects.

- There are 5 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
    - input - QueryUnmanagedObjectSnapshotsV1Input: Input for V1QueryUnmanagedObjectSnapshotsV1.
- Returns SnapshotSummaryConnection.
### vappexportoptions
Options for exporting a vApp snapshot.

- There is a single argument of type VappSnapshotExportOptionsInput.
- Returns VappExportOptions.
### vappinstantrecoveryoptions
Options for instantly recovering a vApp snapshot.

- There is a single argument of type VappSnapshotInstantRecoveryOptionsInput.
- Returns VappInstantRecoveryOptions.
### vapptemplateexportoptions
Export options for a vApp snapshot template.

- There is a single argument of type VappTemplateSnapshotExportOptionsInput.
- Returns VappTemplateExportOptionsUnion.
