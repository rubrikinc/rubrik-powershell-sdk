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
### bulkupdatetemplate
Modify fileset templates

Supported in v5.0+
Modify the values of specified fileset templates.

- There is a single argument of type BulkUpdateFilesetTemplateInput.
- Returns BulkUpdateFilesetTemplateReply.
### recoverfiles
v5.0-v9.2: Create restore job to restore multiple files/directories
v9.3+: (DEPRECATED) Create restore job to restore multiple files/directories

Supported in v5.0+
v5.0-v9.2: Initiate a job to copy one or more file or folder from a fileset backup to the source host. Returns the job instance ID.
v9.3+: Initiate a job to copy one or more file or folder from a fileset backup to the source host. Returns the job instance ID. This endpoint will be removed in CDM v9.3.0 in favor of `POST v1/fileset/snapshot/{id}/restore_files`.

- There is a single argument of type FilesetRecoverFilesInput.
- Returns AsyncRequestStatus.
### update
Update a Fileset

Supported in v5.0+
Update a Fileset with the specified properties.

- There is a single argument of type UpdateFilesetInput.
- Returns FilesetDetail.
