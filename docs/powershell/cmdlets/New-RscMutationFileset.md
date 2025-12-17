# New-RscMutationFileset
## Subcommands
### bulkcreate
- There is a single argument of type BulkCreateFilesetsInput.
- Returns BulkCreateFilesetsReply.
### bulkcreatetemplates
- There is a single argument of type BulkCreateFilesetTemplatesInput.
- Returns BulkCreateFilesetTemplatesReply.
### bulkdelete
Delete filesets

Supported in v5.0+
Delete filesets by specifying the fileset IDs.

- There is a single argument of type BulkDeleteFilesetInput.
- Returns ResponseSuccess.
### bulkdeletetemplate
Delete fileset templates

Supported in v5.0+
Deletes specfied fileset templates. Detaches and retains all associated filesets as independent filesets with the existing values.

- There is a single argument of type BulkDeleteFilesetTemplateInput.
- Returns ResponseSuccess.
### bulkgeneratebackupreport
BulkGenerateFilesetBackupReport generates backup reports for multiple fileset snapshots.

- There is a single argument of type BulkGenerateFilesetBackupReportInput.
- Returns BulkGenerateFilesetBackupReportReply.
### bulkupdatetemplate
Modify fileset templates

Supported in v5.0+
Modify the values of specified fileset templates.

- There is a single argument of type BulkUpdateFilesetTemplateInput.
- Returns BulkUpdateFilesetTemplateReply.
### generatebackupreport
Generate a success and failure report for a fileset backup

Supported in v9.2+
Start an asynchronous job to generate success and failure files for a specified fileset backup. The response returns an asynchronous request ID. To get the URL for downloading the ZIP file containing the specific files and folders, send a GET request to 'fileset/request/{id}'.

- There is a single argument of type GenerateFilesetBackupReportInput.
- Returns AsyncRequestStatus.
### recoverfiles
v5.0-v9.2: Create restore job to restore multiple files/directories
v9.3+: (DEPRECATED) Create restore job to restore multiple files/directories

Supported in v5.0+
v5.0-v9.2: Initiate a job to copy one or more file or folder from a fileset backup to the source host. Returns the job instance ID.
v9.3+: Initiate a job to copy one or more file or folder from a fileset backup to the source host. Returns the job instance ID. This endpoint will be removed in CDM v9.3.0 in favor of `POST v1/fileset/snapshot/{id}/restore_files`.

- There is a single argument of type FilesetRecoverFilesInput.
- Returns AsyncRequestStatus.
### recoverfilesfromarchivallocation
Initiate a job to restore files or folders

Supported in v8.0+
Initiate a job to copy one or more file or folder in a fileset backup from specified archival location to the source host. Returns the job instance ID.

- There is a single argument of type FilesetRecoverFilesFromArchivalLocationInput.
- Returns AsyncRequestStatus.
### update
Update a Fileset

Supported in v5.0+
Update a Fileset with the specified properties.

- There is a single argument of type UpdateFilesetInput.
- Returns FilesetDetail.
