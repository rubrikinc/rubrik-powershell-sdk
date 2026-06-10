# New-RscMutationFileset
## Subcommands
### bulkcreate
Create filesets for a host

Supported in v5.0+
Create filesets for a network host. Each fileset is a fileset template applied to a host.

- There is a single argument of type BulkCreateFilesetsInput.
- Returns BulkCreateFilesetsReply.
### bulkcreatetemplates
Create fileset templates

Supported in v5.0+
v5.0-v5.3: Create fileset templates. The template is applied to the host.  Each template is a set of paths on the host.

A template uses full paths and wildcards to define the objects to include, exclude, and exempt from exclusion.

The **_exceptions_** value specifies paths that should not be excluded from the fileset by the **_exclude_** value.

Specify an array of full path descriptions for each property **_include_**, **_exclude_**, and **_exceptions_**.

Acceptable wildcard characters are
+ **_\*_** Single asterisk matches zero or more characters up to a path deliminator
+ **_\*\*_** Double asterisk matches zero or more characters

The following rules apply to path descriptions
+ Accepts UTF-8 characters
+ Case sensitive
+ Forward slash character **_/_** is the path deliminator
+ Symbolic links must point to a subset of a non symbolic link path
+ Paths that do not start with **_/_** are modified to start with **_\*\*/_**
+ Paths that do not end with **_\*_** are modified to end with **_/\*\*_**
v6.0+: Create fileset templates. The template is applied to the host.  Each template is a set of paths on the host.

A template uses full paths and wildcards to define the objects to include, exclude, and exempt from exclusion.

The **_exceptions_** value specifies paths that should not be excluded from the fileset by the **_exclude_** value.

Specify an array of full path descriptions for each property **_include_**, **_exclude_**, and **_exceptions_**.

Acceptable wildcard characters are.
+ **_\*_** Single asterisk matches zero or more characters up to a path deliminator.
+ **_\*\*_** Double asterisk matches zero or more characters.

The following rules apply to path descriptions.
+ Accepts UTF-8 characters.
+ Case sensitive.
+ Forward slash character **_/_** is the path deliminator.
+ Symbolic links must point to a subset of a non symbolic link path.
+ Paths that do not start with **_/_** are modified to start with **_\*\*/_**.
+ Paths that do not end with **_\*_** are modified to end with **_/\*\*_**.

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
