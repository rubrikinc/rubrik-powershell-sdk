# New-RscMutationCloudNative
## Subcommands
### addsqlserverbackupcredentials
Add credentials for the user in the databases with authorization to perform backups.

- There is a single argument of type AddCloudNativeSqlServerBackupCredentialsInput.
- Returns AddCloudNativeSqlServerBackupCredentialsReply.
### checkrbaconnectivity
Check Rubrik Backup Agent (RBA) connectivity for the VMs.

- There is a single argument of type CloudNativeCheckRbaConnectivityInput.
- Returns CloudNativeCheckRbaConnectivityReply.
### clearsqlserverbackupcredentials
Clear credentials for the user with authorization to perform database backups. Credentials are cleared from the object to which they were assigned directly.

- There is a single argument of type ClearCloudNativeSqlServerBackupCredentialsInput.
- Returns ClearCloudNativeSqlServerBackupCredentialsReply.
### createlabelrule
Create cloud native label rule

- There is a single argument of type CreateCloudNativeLabelRuleInput.
- Returns CreateCloudNativeLabelRuleReply.
### createtagrule
Create cloud native tag rule

- There is a single argument of type CreateCloudNativeTagRuleInput.
- Returns CreateCloudNativeTagRuleReply.
### deletelabelrule
Delete cloud native label rule.

- There is a single argument of type DeleteCloudNativeLabelRuleInput.
- Returns System.String.
### deletetagrule
Delete cloud native tag rule.

- There is a single argument of type DeleteCloudNativeTagRuleInput.
- Returns System.String.
### downloadfiles
Download files from a cloud-native snapshot to a cloud download location or a virtual machine.

- There is a single argument of type CloudNativeDownloadFilesInput.
- Returns DownloadFilesReply.
### setupsqlserverbackup
Setup backups on the SQL Server databases using the admin credentials.

- There is a single argument of type SetupCloudNativeSqlServerBackupInput.
- Returns BatchAsyncJobStatus.
### startsnapshotsindexjob
Create index of cloudnative snapshots

- There is a single argument of type StartCloudNativeSnapshotsIndexJobInput.
- Returns BatchAsyncJobStatus.
### updateindexingstatus
Update indexing status for cloudnative snappables

- There is a single argument of type UpdateCloudNativeIndexingStatusInput.
- Returns UpdateCloudNativeIndexingStatusReply.
### updatelabelrule
Update cloud native label rule

- There is a single argument of type UpdateCloudNativeLabelRuleInput.
- Returns System.String.
### updatetagrule
Update cloud native tag rule

- There is a single argument of type UpdateCloudNativeTagRuleInput.
- Returns System.String.
### warmindexcache
Warm cache for search in cloud native snappables

- There is a single argument of type System.String.
- Returns System.Boolean.
