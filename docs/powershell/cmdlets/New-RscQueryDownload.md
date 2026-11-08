# New-RscQueryDownload
## Subcommands
### anchorresources
Download discovered anchor resources as JSON for offline review.
Returns all resources matching the filter criteria as a JSON string.
This API is intended for customers to download resource details for
offline analysis and review.

- There is a single argument of type DownloadAnchorResourcesRequest.
- Returns DownloadAnchorResourcesResponse.
### applicationresources
Download application resources as JSON for a given application.
Returns all resources belonging to the specified application.

- There is a single argument of type DownloadApplicationResourcesRequest.
- Returns DownloadApplicationResourcesResponse.
### cdmupgradespdf
Download cdm upgrades table pdf.

- There is a single argument of type DownloadCdmUpgradesPdfFiltersInput.
- Returns DownloadCdmUpgradesPdfReply.
### configrecoveryreport
DownloadConfigRecoveryReport returns the full dump of
recovered config resources for a failover as a
self-contained HTML report.

- There is a single argument of type DownloadConfigRecoveryReportRequest.
- Returns DownloadConfigRecoveryReportReply.
### downloadedversionlist
Counts of Rubrik clusters grouped by the CDM version each has downloaded.

- The downloadedversionlist subcommand takes no arguments.
- Returns list of GroupCounts.
### packagestatus
Get Status of download package job.

- There is a single argument of type System.String.
- Returns DownloadPackageStatusReply.
### turbothreathuntcsv
Get status of turbo threat hunt result generation and, if available,
signed URL to download the CSV.

- There is a single argument of type DownloadTurboThreatHuntResultsCsvInput.
- Returns DownloadTurboThreatHuntResultsCsvResponse.
