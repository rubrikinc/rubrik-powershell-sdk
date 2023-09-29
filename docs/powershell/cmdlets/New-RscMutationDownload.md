# New-RscMutationDownload
## Subcommands
### auditlogcsvasync
Download audit log in CSV format asynchronously.

- There is a single argument of type DownloadAuditLogCsvAsyncInput.
- Returns AsyncDownloadReply.
### exchangesnapshot
Download exchange database snapshot from archive

Supported in v8.0+
Downloads a Microsoft Exchange database snapshot from the specified archival location.

- There is a single argument of type DownloadExchangeSnapshotInput.
- Returns AsyncRequestStatus.
### filesetsnapshot
- There is a single argument of type DownloadFilesetSnapshotInput.
- Returns AsyncRequestStatus.
### filesetsnapshotfromlocation
Download a snapshot from a replication target

Supported in v7.0+
Initiates a job to download a snapshot from the specified location when the snapshot does not exist locally. The specified location has to be a replication target connected to this Rubrik cluster. If an SLA Domain is not provided, the snapshot will be retained forever.

- There is a single argument of type DownloadFilesetSnapshotFromLocationInput.
- Returns AsyncRequestStatus.
### objectfilescsv
Schedule a download CSV job for cross object files.

- There is a single argument of type DownloadObjectFilesCsvInput.
- Returns DownloadCsvReply.
### objectslistcsv
Schedule a download CSV job for objects list.

- There is a single argument of type DownloadObjectsListCsvInput.
- Returns DownloadCsvReply.
### reportcsvasync
Download a report in CSV format asynchronously.

- There is a single argument of type DownloadReportCsvAsyncInput.
- Returns AsyncDownloadReply.
### reportpdfasync
Download a report asynchronously in PDF format.

- There is a single argument of type DownloadReportPdfAsyncInput.
- Returns AsyncDownloadReply.
### resultscsv
Download file results in CSV format.

- There are 2 arguments.
    - crawlId - System.String
    - downloadFilter - DownloadResultsCsvFiltersInput
- Returns DownloadResultsCsvReply.
### saphanasnapshot
Download SAP HANA database snapshot from archive

Supported in v8.0+
Downloads a specific SAP HANA database snapshot from the specified archival location.

- There is a single argument of type DownloadSapHanaSnapshotInput.
- Returns AsyncRequestStatus.
### saphanasnapshotfromlocation
Download a snapshot from the remote location

Supported in v8.1+
Initiates a job to download a snapshot from the specified location when the snapshot does not exist locally. The specified location can be replication target or archival location. If SLA Domain is not selected, the snapshot will be retained forever.

- There is a single argument of type DownloadSapHanaSnapshotFromLocationInput.
- Returns AsyncRequestStatus.
### saphanasnapshotsforpointintimerecovery
Download SAP HANA database snapshots from archive for a point in time recovery

Supported in v8.0+
Downloads the most recent full snapshot and the log snapshots taken after the full snapshot, required for the point in time recovery of an SAP HANA database.

- There is a single argument of type DownloadSapHanaSnapshotsForPointInTimeRecoveryInput.
- Returns AsyncRequestStatus.
### snapshotresultscsv
Download snapshot policy results in CSV format.

- There are 3 arguments.
    - snappableFid - System.String
    - snapshotFid - System.String
    - downloadFilter - DownloadResultsCsvFiltersInput
- Returns DownloadCsvReply.
### threathuntcsv
Download threat hunt result in CSV format.

- There is a single argument of type DownloadThreatHuntCsvInput.
- Returns DownloadThreatHuntCsvReply.
### volumegroupsnapshotfiles
Download files from Volume Group snapshot

Supported in v5.0+
Create a download files request.

- There is a single argument of type DownloadVolumeGroupSnapshotFilesInput.
- Returns AsyncRequestStatus.
### volumegroupsnapshotfromlocation
Download a snapshot from a replication target

Supported in v7.0+
Initiates a job to download a snapshot from the specified location when the snapshot does not exist locally. The specified location has to be a replication target connected to this Rubrik cluster. If an SLA Domain is not provided, the snapshot will be retained forever.

- There is a single argument of type DownloadVolumeGroupSnapshotFromLocationInput.
- Returns AsyncRequestStatus.
