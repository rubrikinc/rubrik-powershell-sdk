### DownloadSalesforceArchivedRecordsInput
Request for downloadSalesforceArchivedRecords.

- orgId: System.String
  - ID of this workload's organization.
- objectId: System.String
  - Object ID of the Salesforce object whose archived records will be
packaged for download.
- objectName: System.String
  - API name of the Salesforce object (e.g. "Account").
- fieldNames: list of System.Strings
  - The list of fields for which the record values must be returned.
- recordsToDownload: UnarchiveRecordsInfo
  - Records to download by explicit natural ID. Mutually exclusive
with record_criteria. If neither is set, all archived records for
the object are packaged.
- recordCriteria: ArchivedRecordCriteria
  - Criteria selecting which records to download (search term and/or
field conditions), as an alternative to listing record_ids.
Mutually exclusive with records_to_download.
