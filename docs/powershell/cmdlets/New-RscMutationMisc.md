# New-RscMutationMisc
## Subcommands
### addadgroupstohierarchy
Add AD Groups to O365 hierarchy.

- There is a single argument of type AddAdGroupsToHierarchyInput.
- Returns RequestStatus.
### addclouddirectkerberoscredential
AddCloudDirectKerberosCredential creates a new Kerberos credential for NCD systems.

- There is a single argument of type AddCloudDirectKerberosCredentialInput.
- Returns AddCloudDirectKerberosCredentialReply.
### addclouddirectsharestosystem
Add shares (NFS, NFS4, or SMB) to an existing system.

- There is a single argument of type AddCloudDirectSharesToSystemInput.
- Returns AddCloudDirectSharesToSystemReply.
### addclouddirectsystem
AddCloudDirectSystem is used to add a new system to the NCD cluster.

- There is a single argument of type AddCloudDirectSystemInput.
- Returns AddCloudDirectSystemReply.
### addconfiguredgrouptohierarchy
Add a Configured Group to the O365 hierarchy.

- There is a single argument of type AddConfiguredGroupToHierarchyInput.
- Returns AddConfiguredGroupToHierarchyReply.
### addcustomintelfeed
Add custom intel feed.

- There is a single argument of type AddCustomIntelFeedInput.
- Returns AddCustomIntelFeedReply.
### addidentityprovider
Add a new identity provider.

- There is a single argument of type AddIdentityProviderInput.
- Returns AddIdentityProviderReply.
### addinventoryworkloads
Add account level inventory workloads.

- There is a single argument of type AddInventoryWorkloadsInput.
- Returns System.Boolean.
### addipwhitelistentries
Add entries to the IP allowlist.

- There is a single argument of type AddIpWhitelistEntriesInput.
- Returns System.String.
### addmysqlinstance
Create a MySQL database instance

Supported in v9.3+
Start an asynchronous job to create an instance of MySQL database.

- There is a single argument of type AddMysqldbInstanceInput.
- Returns AddMysqldbInstanceResponse.
### addroleassignments
Add RBAC role assignments to the given users and/or groups.
Existing role assignments are preserved.

- There are 3 arguments.
    - userIds - list of System.Strings: List of user IDs.
    - groupIds - list of System.Strings: List of group IDs.
    - roleIds - list of System.Strings: List of role IDs to assign.
- Returns System.Boolean.
### addvlan
Add VLAN to Rubrik cluster.

- There is a single argument of type AddVlanInput.
- Returns ResponseSuccess.
### addvmappconsistentspecs
Add Vm App consistent specs info

- There is a single argument of type AddVmAppConsistentSpecsInput.
- Returns AddVmAppConsistentSpecsReply.
### airgapstatus
Update the air-gap status of the Rubrik cluster.

- There is a single argument of type AirGapStatusInput.
- Returns System.String.
### approvetprrequest
Approve a two-person rule (TPR) request with optional comments.

- There is a single argument of type ApproveTprRequestInput.
- Returns System.String.
### archivecrawl
Archive a crawl.

- There is a single argument of type System.String.
- Returns System.String.
### assignprotection
Assign protection to cassandra objects.

- There is a single argument of type AssignProtectionInput.
- Returns SlaAssignResult.
### assignvmname
AssignVmName assigns a user-defined display name to an NCD virtual machine
device. Names must be unique within a cluster. Duplicate names within the
same cluster are rejected. Assigning a new name to a device that already
has one replaces the previous name.

- There is a single argument of type AssignVmNameInput.
- Returns System.String.
### backupdevopsrepository
Take a backup of a DevOps repository.

- There is a single argument of type BackupDevOpsRepositoryInput.
- Returns BackupDevOpsRepositoryReply.
### batchdeassignrolefromusergroups
Batch deassign roles from the given user groups.

- There is a single argument of type list of UserGroupToRolesInputs.
- Returns System.Boolean.
### batchquarantineoperations
Quarantines or releases from quarantine at workload and file version.

- There is a single argument of type BatchQuarantineOperationsInput.
- Returns System.String.
### batchtriggerexocomputehealthcheck
Initiates an on-demand Exocompute health check for a batch of exocompute configurations across regions.

- There is a single argument of type BatchTriggerExocomputeHealthCheckInput.
- Returns BatchTriggerExocomputeHealthCheckReply.
### bulkcreatefusioncomputevmbackup
Initiate on-demand backups for multiple FusionCompute virtual machines in
a single request. Fans out to the per-virtual-machine CDM REST endpoint
server-side and returns one AsyncRequestStatus per input ID, in the same
order. A per-virtual-machine failure (translation, RBAC inside CDM,
cluster-unreachable, or per-virtual-machine timeout) appears as an entry
with `error` populated; the request itself does not return an RPC error
for per-virtual-machine failures.

- There is a single argument of type BulkCreateFusionComputeVmBackupInput.
- Returns BatchAsyncRequestStatus.
### bulkcreatenasfilesets
Create filesets in bulk for NAS shares

Supported in v7.0+
Create primary filesets for a list of NAS shares.

- There is a single argument of type BulkCreateNasFilesetsInput.
- Returns BulkCreateNasFilesetsReply.
### bulkobjectpause
Toggle pause at object level and refresh pause status of their descendants.

- There is a single argument of type ToggleObjectPauseReq.
- Returns ToggleObjectPauseRes.
### bulkupdatenasnamespaces
Update NAS namespaces with SMB credentials

Supported in v8.1+
Add, update, or remove SMB credentials for NAS namespaces.

- There is a single argument of type BulkUpdateNasNamespacesInput.
- Returns System.String.
### bulkupdatesystemconfig
Bulk update system config params

Supported in v9.5+
Updates configs for multiple SAP HANA systems.

- There is a single argument of type BulkUpdateSapHanaSystemConfigInput.
- Returns AsyncRequestStatus.
### canceldownloadpackage
Cancels download package job of a cluster.

- There is a single argument of type System.String.
- Returns CancelJobReply.
### cancelscheduledupgrade
Cancels scheduled upgrade job of a cluster.

- There is a single argument of type System.String.
- Returns CancelJobReply.
### canceltaskchain
Cancels the taskchain.

- There is a single argument of type System.String.
- Returns RequestStatus.
### canceltprrequest
Cancel a two-person rule (TPR) request with optional comments.

- There is a single argument of type CancelTprRequestInput.
- Returns System.String.
### changecurrentuserpassword
Change the password for the current user.

- There is a single argument of type ChangeCurrentUserPasswordInput.
- Returns System.String.
### changepassword
Changes a users password without using email.

- There is a single argument of type ChangePasswordInput.
- Returns System.Boolean.
### cleanuprecoveries
Cleans up recoveries by scheduling a clean up job for each recovery.

- There is a single argument of type CleanupRecoveriesInput.
- Returns CleanupRecoveriesReply.
### clouddirectaddsubdirbackup
CloudDirectAddSubdirBackup is used to add Details of Subdir for backup.

- There is a single argument of type CloudDirectAddSubdirBackupInput.
- Returns CloudDirectAddSubdirBackupReply.
### clouddirectsetkerberosenforceconfig
CloudDirectSetKerberosEnforceConfig sets the Kerberos enforcement configuration for a specific protocol.

- There is a single argument of type CloudDirectSetKerberosEnforceConfigInput.
- Returns CloudDirectSetKerberosEnforceConfigReply.
### clouddirectsetwanthrottlesettings
CloudDirectSetWanThrottleSettings is used to set WAN Throttle Settings for the NCD cluster.

- There is a single argument of type CloudDirectSetWanThrottleSettingsInput.
- Returns CloudDirectSetWanThrottleSettingsReply.
### clouddirectsystemdelete
CloudDirectSystemDelete is used to delete the system.

- There is a single argument of type CloudDirectSystemDeleteInput.
- Returns System.String.
### clouddirectsystemrescan
CloudDirectSystemRescan is used to rescan a system already
added to the NCD cluster.

- There is a single argument of type CloudDirectSystemRescanInput.
- Returns CloudDirectSystemRescanReply.
### clouddirectvalidatesubdir
CloudDirectValidateSubdir is used to validate SubDir on an export.

- There is a single argument of type CloudDirectValidateSubdirInput.
- Returns CloudDirectValidateSubdirReply.
### completegithubappinstallation
Completes the GitHub App installation (step 3 of the 3-step flow).

After calling completeGitHubAppRegistration (step 2) and the user
installs the app on their GitHub organization, GitHub provides an
installation ID. Pass this ID along with the session ID from step 1 to
finalize the setup. After this step the GitHub App is fully configured
and ready for use.

- There is a single argument of type CompleteGitHubAppInstallationInput.
- Returns System.String.
### completegithubappregistration
Completes the GitHub App registration (step 2 of the 3-step flow).

After calling startGitHubAppSetup (step 1) and the user creates the app
on GitHub using the manifest, GitHub returns a setup code. Pass this code
along with the session ID from step 1 to exchange it for app credentials.
Returns the installation URL where the user should install the app on
their GitHub organization.

- There is a single argument of type CompleteGitHubAppRegistrationInput.
- Returns CompleteGitHubAppRegistrationReply.
### completeuploadsession
Complete the upload session with Minio.

- There is a single argument of type CompleteUploadSessionInput.
- Returns CompleteUploadSessionReply.
### confirmpartupload
Confirm the upload of a part of the CDM package.

- There is a single argument of type ConfirmPartUploadInput.
- Returns ConfirmPartUploadReply.
### createautomatedrestoremysqldbinstance
Initiates a job to restore the MySQL instance on the given target MySQL instance. Supported in v9.5.

- There is a single argument of type CreateAutomatedRestoreMysqldbInstanceInput.
- Returns CreateAutomatedRestoreMysqldbInstanceReply.
### createcustomanalyzer
Create a new custom analyzer.

- There is a single argument of type CreateCustomAnalyzerInput.
- Returns Analyzer.
### createdistributionlistdigestbatch
Create distribution list digests for specific recipients.

- There is a single argument of type CreateDistributionListDigestBatchInput.
- Returns System.String.
### createeventdigestbatch
Create event digests for specific recipients.

- There is a single argument of type CreateEventDigestBatchInput.
- Returns System.String.
### createfusioncomputemount
Mount a FusionCompute virtual machine from a snapshot.

- There is a single argument of type CreateFusionComputeMountInput.
- Returns AsyncRequestStatus.
### createfusioncomputevmbackup
Initiate an on-demand backup for a FusionCompute virtual machine.

- There is a single argument of type CreateFusionComputeVmBackupInput.
- Returns AsyncRequestStatus.
### createguestcredential
Create guest OS credentials.

- There is a single argument of type CreateGuestCredentialInput.
- Returns CreateGuestCredentialReply.
### createlegalhold
Place legal hold on snapshots.

- There is a single argument of type CreateLegalHoldInput.
- Returns CreateLegalHoldReply.
### createondemandvolumegroupbackup
Create on-demand snapshot for the Volume Group

Supported in v5.3+
Create an on-demand snapshot for the given Volume Group ID.

- There is a single argument of type CreateOnDemandVolumeGroupBackupInput.
- Returns AsyncRequestStatus.
### createrecoveryschedulev2
Creates a recovery schedule for a recovery plan.

- There is a single argument of type CreateRecoveryScheduleV2Input.
- Returns System.String.
### createssousers
Create SSO users.

- There is a single argument of type CreateSsoUsersInput.
- Returns CreateSsoUsersReply.
### createvappsinstantrecovery
Initiate instant recovery from vApp snapshots.

- There is a single argument of type CreateVappsInstantRecoveryInput.
- Returns CreateVappsInstantRecoveryReply.
### createvrm
Add a FusionCompute VRM instance

Supported in v9.6
Create a FusionCompute VRM instance by providing the hostname and account credentials of the FusionCompute VRM. Establishes a connection to the VRM instance and retrieves all associated metadata objects.

- There is a single argument of type CreateVrmInput.
- Returns CreateVrmReply.
### deactivatecustomanalyzer
Deactivate a custom analyzer.

- There are 2 arguments.
    - analyzerId - System.String
    - disableAnalyzer - System.Boolean: If true, disable the underlying requested analyzer.
- Returns System.String.
### deleteadgroupsfromhierarchy
Delete AD Groups from O365 hierarchy.

- There is a single argument of type DeleteAdGroupsFromHierarchyInput.
- Returns RequestStatus.
### deletecephsetting
Delete a Ceph setting for an OpenStack Availability Zone

Supported in v9.5+
Delete a specific Ceph storage setting for an OpenStack Availability Zone.

- There is a single argument of type DeleteCephSettingInput.
- Returns System.String.
### deleteclouddirectkerberoscredential
DeleteCloudDirectKerberosCredential deletes an existing Kerberos credential for NCD systems.

- There is a single argument of type DeleteCloudDirectKerberosCredentialInput.
- Returns System.String.
### deletedistributionlistdigestbatch
Delete specific distribution list digests.

- There is a single argument of type DeleteDistributionListDigestBatchInput.
- Returns System.String.
### deleteeventdigest
Delete event digests for specific recipients.

- There is a single argument of type DeleteEventDigestInput.
- Returns System.String.
### deletefusioncomputemount
Delete a mounted FusionCompute virtual machine.

- There is a single argument of type DeleteFusionComputeMountInput.
- Returns AsyncRequestStatus.
### deletefusioncomputevrm
Delete a FusionCompute VRM instance

Supported in v9.6
Delete a FusionCompute VRM instance object and archive all associated objects.

- There is a single argument of type DeleteFusionComputeVrmInput.
- Returns AsyncRequestStatus.
### deleteguestcredentialbyid
Delete guest OS credentials.

- There is a single argument of type DeleteGuestCredentialByIdInput.
- Returns System.Boolean.
### deleteidentityproviderbyid
Delete an identity provider.

- There is a single argument of type DeleteIdentityProviderByIdInput.
- Returns System.String.
### deleteintelfeed
Delete intel feed.

- There is a single argument of type DeleteIntelFeedInput.
- Returns System.String.
### deleteipwhitelistentries
Delete entries from the IP allowlist.

- There is a single argument of type DeleteIpWhitelistEntriesInput.
- Returns System.String.
### deletemvcprofiles
DeleteMvcProfiles archives the minimum viable company profiles.

- There is a single argument of type DeleteMvcProfilesInput.
- Returns System.String.
### deletemysqldbinstancelivemount
Delete a Live Mount of a MySQL instance

Supported in v9.4+
Deletes the Live Mount of a MySQL instance associated with the specified ID.

- There is a single argument of type DeleteMysqldbInstanceLiveMountInput.
- Returns AsyncRequestStatus.
### deletemysqlinstance
Delete a MySQL instance

Supported in v9.3+
Initiates a job to delete a MySQL instance. GET /mysqldb/instance/request/{id} endpoint can be used to monitor the progress of the job.

- There is a single argument of type DeleteMysqldbInstanceInput.
- Returns AsyncRequestStatus.
### deleterecoveryplansv2
Deletes recovery plans.

- There is a single argument of type DeleteRecoveryPlansV2Input.
- Returns DeleteRecoveryPlansV2Reply.
### deleterecoveryschedulev2
Deletes a recovery schedule for a recovery plan.

- There is a single argument of type DeleteRecoveryScheduleV2Input.
- Returns System.String.
### deletevolumegroupmount
Request to delete a mount

Supported in v5.0+
Create a request to delete a mount. If there are volumes mounted on a target host, this will use best-effort to unmount those volumes from the host, and proceed to unmount storage on Rubrik.

- There is a single argument of type DeleteVolumeGroupMountInput.
- Returns AsyncRequestStatus.
### denytprrequests
Deny two-person rule (TPR) requests with optional comments.

- There is a single argument of type DenyTprRequestsInput.
- Returns System.String.
### deregisterprivatecontainerregistry
Deregister the Private Container Registry (PCR) for an Exocompute account.

- There is a single argument of type DeregisterPrivateContainerRegistryInput.
- Returns System.String.
### disablesupportuseraccess
Disables a Rubrik Support representative's access to the customer's account.

- There is a single argument of type DisableSupportUserAccessInput.
- Returns System.String.
### disabletprorg
Disable TPR for an organization.

- There is a single argument of type DisableTprOrgInput.
- Returns System.String.
### dissolvelegalhold
Dissolve legal hold on snapshots.

- There is a single argument of type DissolveLegalHoldInput.
- Returns DissolveLegalHoldReply.
### enableautomaticfmdupload
Enable/disable auto fmd upload on given cluster.

- There is a single argument of type EnableAutomaticFmdUploadInput.
- Returns EnableAutomaticFmdUploadReply.
### enabledisableappconsistency
Enable/ Disable App consistency for a VM

- There is a single argument of type EnableDisableAppConsistencyInput.
- Returns EnableDisableAppConsistencyReply.
### enablesupportuseraccess
Enables a Rubrik Support representative's access to the customer's account.

- There is a single argument of type EnableSupportUserAccessInput.
- Returns System.String.
### enabletprorg
Enable TPR for an organization.

- There is a single argument of type EnableTprOrgInput.
- Returns System.String.
### excludevmdisks
Exclude or include virtual disks during snapshot.

- There is a single argument of type list of ExcludeVmDisksInputs.
- Returns RequestSuccess.
### executetprrequests
Execute two-person rule (TPR) requests.

- There is a single argument of type ExecuteTprRequestsInput.
- Returns System.String.
### expiresnoozeddirectories
Expire snoozed directories.

- There is a single argument of type ExpireSnoozedDirectoriesInput.
- Returns ExpireSnoozedDirectoriesReply.
### generateconfigprotectionrestoreform
Generate restore form for the configuration backup file.

- There is a single argument of type GenerateConfigProtectionRestoreFormInput.
- Returns GenerateConfigProtectionRestoreFormReply.
### generatepresignedurlfordownload
Generate a presigned URL for downloading a specific package in CDM.

- There is a single argument of type GeneratePresignedUrlForDownloadInput.
- Returns GeneratePresignedUrlForDownloadReply.
### generatepresignedurlforpartupload
Generate a presigned URL for uploading a part of the CDM package.

- There is a single argument of type GeneratePresignedUrlForPartUploadInput.
- Returns GeneratePresignedUrlForPartUploadReply.
### generatesupportbundle
Collect log files from the cluster

Supported in v5.0+
To be used by Admin to collect necessary Rubrik's log files from all the nodes. Both event_id and reqeust_ids are optional. If nothing is specified, the whole support bundle is to be collected, if event_id is specified, the reqeuest_ids is ignored. If request id is specified, only collect logs related to the specific request, otherwise collect all the logs.

- There is a single argument of type GenerateSupportBundleInput.
- Returns AsyncRequestStatus.
### getdownloadurl
Get the download URL for a user file.

- There is a single argument of type System.Int64.
- Returns UserDownloadUrl.
### hiderevealnasnamespaces
Hide and reveal NAS namespaces

Supported in v7.0+
Hide individually selected NAS namespaces by setting the "action" field to "Hide". Reveal the selected NAS namespaces by setting the "action" field to "Reveal".

- There is a single argument of type HideRevealNasNamespacesInput.
- Returns System.String.
### initializeuploadsession
Initialize a new upload session for CDM package upload.

- There is a single argument of type InitializeUploadSessionInput.
- Returns InitializeUploadSessionReply.
### installiofilter
Install the Rubrik ioFilter to the VMware cluster with a specific ID

Supported in v5.1+
Install the latest version of Rubrik ioFilter to the VMware cluster with a specific ID. The cluster must be in maintenance mode to install the ioFilter successfully. The vCenter of the VMware compute cluster must be of version 6.7 and above.

- There is a single argument of type InstallIoFilterInput.
- Returns RequestSuccess.
### invitessogroup
Assigns roles to SSO groups in the current organization using the given group name and role IDs.

- There is a single argument of type InviteSsoGroupInput.
- Returns System.Boolean.
### linuxrbsbulkinstall
Bulk install and register RBS on Linux host.

- There is a single argument of type LinuxRbsBulkInstallInput.
- Returns LinuxRbsBulkInstallReply.
### listcidrsforcomputesetting
List CIDRs for compute settings.

- There is a single argument of type ListCidrsForComputeSettingInput.
- Returns ListCidrsForComputeSettingReply.
### lockcyberrecovery
Locks a cyber recovery to prevent modifications or deletions.

- There is a single argument of type LockCyberRecoveryInput.
- Returns System.String.
### lockusersbyadmin
Specifies the endpoint through which the admin can lock the user accounts.

- There is a single argument of type LockUsersByAdminInput.
- Returns System.String.
### logoutfromrubriksupportportal
Logout from Rubrik support portal using username.

- The logoutfromrubriksupportportal subcommand takes no arguments.
- Returns SupportPortalLogoutReply.
### makeprimary
Make this cluster the primary for agents on a set of hosts

Supported in v5.3+
Migrate the primary cluster with which the agent is able to perform regular operations (backup, restore etc). This can be done on a specified set of hosts or for all hosts that currently have a specified primary cluster for disaster recovery. Specify exactly one of `ids` or `oldPrimaryClusterUuid`.

- There is a single argument of type MakePrimaryInput.
- Returns AsyncRequestStatus.
### manageprotectionforlinkedobjects
Manage protection for linked objects, allowing objects to be linked or unlinked and allow changes in SLA Domain assignment for linked objects.

- There is a single argument of type ManageProtectionForLinkedObjectsInput.
- Returns CreateOnDemandJobReply.
### migratefusioncomputemount
Migrate a FusionCompute Live Mount to another datastore

Supported in v9.6
Run storage migration to relocate a FusionCompute Live Mount into another datastore.

- There is a single argument of type MigrateFusionComputeMountInput.
- Returns AsyncRequestStatus.
### migratevmdatastore
Migrate datastore of a Live Mount

Supported in v9.4+
Triggers a datastore migration job to migrate the datastore of a Hyper-V virtual machine Live Mount.

- There is a single argument of type MigrateVmDataStoreInput.
- Returns AsyncRequestStatus.
### modifydistributionlistdigestbatch
Modify distribution list digests.

- There is a single argument of type ModifyDistributionListDigestBatchInput.
- Returns System.String.
### modifyeventdigestbatch
Modify event digests for specific recipients.

- There is a single argument of type ModifyEventDigestBatchInput.
- Returns System.String.
### modifyidentityprovider
Modify an existing identity provider.

- There is a single argument of type ModifyIdentityProviderInput.
- Returns System.String.
### modifyipmi
Modify IPMI settings

Supported in v5.0+
modify IPMI settings.

- There is a single argument of type ModifyIpmiInput.
- Returns ModifyIpmiReply.
### mountdisk
Mount disks to the given workload.

- There is a single argument of type MountDiskInput.
- Returns MountDiskReply.
### notificationforgetlicense
Send notification when the user clicks on the Get License button.

- There is a single argument of type NotificationForGetLicenseInput.
- Returns NotificationForGetLicenseReply.
### patchfusioncomputevm
Patch FusionCompute virtual machine

Supported in v9.6
Patch a FusionCompute virtual machine with specified properties.

- There is a single argument of type PatchFusionComputeVmInput.
- Returns System.String.
### patchmysqlinstance
Update properties of the MySQL instance

Supported in v9.3+
Start an asynchronous job to update the properties of the MySQL Instance.

- There is a single argument of type PatchMysqldbInstanceInput.
- Returns PatchMysqldbInstanceResponse.
### pitrestoremysqlinstance
Point-in-time recovery of the specified MySQL instance to host

Supported in v9.4+
Initiates a job to export the data and log snapshot to the given host. The GET /mysqldb/instance/request/{id} endpoint can be used to monitor the progress of the job.

- There is a single argument of type PitRestoreMysqldbInstanceInput.
- Returns PitRestoreMysqldbInstanceResponse.
### provisionclouddirectcloudvm
ProvisionCloudDirectCloudVm provisions a NAS Cloud Direct virtual machine
in a public cloud environment and returns the provisioning details.

- There is a single argument of type ProvisionCloudDirectCloudVmInput.
- Returns ProvisionCloudDirectCloudVmReply.
### recoverclouddirectmultipaths
NAS Cloud Direct MultiPaths Recovery.

- There is a single argument of type RecoverCloudDirectMultiPathsInput.
- Returns AsyncRequestStatus.
### recoverclouddirectnasshare
NAS Cloud Direct share recovery.

- There is a single argument of type RecoverCloudDirectNasShareInput.
- Returns AsyncRequestStatus.
### recoverclouddirectpath
Cloud Direct Path Recovery.

- There is a single argument of type RecoverCloudDirectPathInput.
- Returns AsyncRequestStatus.
### recoverdevopsrepository
Recover DevOps repository.

- There is a single argument of type RecoverDevOpsRepositoryInput.
- Returns RecoverDevOpsRepositoryReply.
### refreshdevopsorganizations
RefreshDevOpsOrganizations triggers a refresh of the specified
DevOps organizations to sync their data with the RSC.

- There is a single argument of type RefreshDevOpsOrganizationsInput.
- Returns RefreshDevOpsOrganizationsReply.
### refreshdomain
Initiates an on-demand refresh job of a specified Active Directory domain.

- There is a single argument of type RefreshDomainInput.
- Returns AsyncRequestStatus.
### refreshfusioncomputevrm
Refresh the FusionCompute VRM metadata

Supported in v9.6
Create a job to refresh the metadata for the specified FusionCompute VRM instance.

- There is a single argument of type RefreshFusionComputeVrmInput.
- Returns AsyncRequestStatus.
### refreshglobalmanagerconnectivitystatus
- There is a single argument of type System.String.
- Returns GlobalManagerConnectivity.
### refreshmysqlinstance
Refresh MySQL instance metadata

Supported in v9.3+
Initiates a job to refresh metadata of a MySQL instance object. The GET /mysqldb/instance/request/{id} endpoint can be used to monitor the progress of the job.

- There is a single argument of type RefreshMysqldbInstanceInput.
- Returns AsyncRequestStatus.
### removedisk
Marks the disk removed and updates cluster metadata.

- There is a single argument of type RemoveDiskInput.
- Returns ResponseSuccess.
### removeinventoryworkloads
Remove account level inventory workloads.

- There is a single argument of type RemoveInventoryWorkloadsInput.
- Returns System.Boolean.
### removenodeforreplacement
Remove a node for replacement.

- There is a single argument of type RemoveNodeForReplacementInput.
- Returns RemoveNodeForReplacementReply.
### removeprivateendpointlist
Removes a private endpoint connection from an RCV location.
After removing a Private endpoint connection to an RCV storage account,
the private tunnel can't be used to send data to and from cdm cluster to
Rubrik hosted storage account.

- There is a single argument of type RemovePrivateEndpointConnectionInput.
- Returns System.String.
### removeproxyconfig
Delete existing proxy configuration

Supported in v5.0+
Delete an existing proxy that was configured.

- There is a single argument of type RemoveProxyConfigInput.
- Returns ResponseSuccess.
### removeuploadrecord
Remove the upload record from the database.

- There is a single argument of type RemoveUploadRecordInput.
- Returns RemoveUploadRecordReply.
### removevlans
Delete cluster VLAN(s).

- There is a single argument of type RemoveVlansInput.
- Returns RemoveVlansReply.
### reseedlogshippingsecondary
Reseed a secondary database.

- There is a single argument of type ReseedLogShippingSecondaryInput.
- Returns AsyncRequestStatus.
### resetallorguserspasswords
Used by the administrator to reset passwords for all users in the organization.

- The resetallorguserspasswords subcommand takes no arguments.
- Returns System.String.
### resetuserspasswordswithuserids
Used by the administrator to reset passwords for selected users in the organization.

- There is a single argument of type ResetUsersPasswordsWithUserIdsInput.
- Returns System.String.
### resizedisk
Resize the disk and updates cluster metadata.

- There is a single argument of type ResizeDiskInput.
- Returns ResponseSuccess.
### resolveanomaly
Resolve an anomaly.

- There is a single argument of type ResolveAnomalyInput.
- Returns System.String.
### resolvevolumegroupsconflict
Marks that the user has resolved that there are no conflicting volume groups on the host where this Exchange server exists

Supported in v8.0+
Marks that the user has resolved that there are no conflicting volume groups on the host where this Exchange server exists.

- There is a single argument of type ResolveVolumeGroupsConflictInput.
- Returns RequestSuccess.
### retrybackup
Initiates retry for a failed job.

- There are 2 arguments.
    - backupObjects - list of BackupObjects: Retry backup for the objects.
    - backupRunConfig - BackupRunConfig: The configuration of the backup operation.
- Returns RetryBackupResp.
### retrydownloadpackagejob
Retry the previous failed download package CDM job.

- There is a single argument of type System.String.
- Returns DownloadPackageReply.
### revokeallorgroles
Revoke all roles of the current organization from the specified users and groups.

- There is a single argument of type RevokeAllOrgRolesInput.
- Returns System.String.
### runcustomanalyzer
- There is a single argument of type RunCustomAnalyzerInput.
- Returns RunCustomAnalyzerReply.
### scheduleupgradebatchjob
Schedule an upgrade job in batch.

- There are 6 arguments.
    - listClusterUuid - list of System.Strings: Specifies the list of cluster UUIDs.
    - mode - System.String: Specifies the upgrade mode.
    - action - ActionType: Specifies the upgrade action.
    - version - System.String: Specifies the Rubrik CDM upgrade tarball version.
    - scheduleAt - DateTime: Specifies the ISO8601 timestamp string.
    - context_tag - System.String: Specifies the Context tag.
- Returns list of UpgradeJobReplyWithUuids.
### setanalyzerrisks
Set risk for analyzers.

- There is a single argument of type SetAnalyzerRisksInput.
- Returns SetAnalyzerRisksReply.
### setbundleapprovalstatus
Sets the approval status of an Exocompute container image bundle.

- There is a single argument of type SetBundleApprovalStatusInput.
- Returns System.String.
### setcephsettings
Set the Ceph settings for an OpenStack Availability Zone

Supported in v9.5+
Set the Ceph storage settings for an OpenStack Availability Zone. Accepts multiple settings.

- There is a single argument of type SetCephSettingsInput.
- Returns SetCephSettingsReply.
### setclouddirectnamespaceoverride
SetCloudDirectNamespaceOverride is used to override properties of a
namespace already added to the NCD cluster.

- There is a single argument of type SetCloudDirectNamespaceOverrideInput.
- Returns System.String.
### setclouddirectshareexclusions
Sets exclusions to a specific share.

- There is a single argument of type SetCloudDirectShareExclusionsInput.
- Returns System.String.
### setclouddirectsystemoverride
SetCloudDirectSystemOverride is used to override properties of a
system already added to the NCD cluster.

- There is a single argument of type SetCloudDirectSystemOverrideInput.
- Returns System.String.
### setcoordinatorlabels
SetCoordinatorLabels replaces the coordinator labels
for virtual machines on a Cloud Direct cluster.

- There is a single argument of type SetCoordinatorLabelsInput.
- Returns SetCoordinatorLabelsReply.
### setcustomertags
Sets customer-specified tags and the value whether the resource tags should be overridden by customer-specified tags for a given cloud type.

- There is a single argument of type SetCustomerTagsInput.
- Returns System.String.
### setdatastorefreespacethresholds
Set datastore freespace thresholds.

- There is a single argument of type SetDatastoreFreespaceThresholdsInput.
- Returns SetDatastoreFreespaceThresholdsReply.
### setipwhitelistenabled
Enable or disable the IP allowlist for the given organization.

- There is a single argument of type System.Boolean.
- Returns System.Boolean.
### setipwhitelistsetting
Update the IP allowlist settings for the account.

- There is a single argument of type SetIpWhitelistSettingInput.
- Returns System.String.
### setmfasetting
Update the MFA settings for the account.
Return true when the operation succeeds.

- There is a single argument of type SetMfaSettingInput.
- Returns System.Boolean.
### setprivatecontainerregistry
Sets the Private Container Registry (PCR) details for an Exocompute cloud account. Updates the details if the registry already exists and creates a new entry if it does not exist.

- There is a single argument of type SetPrivateContainerRegistryInput.
- Returns System.String.
### setselfserverollingupgrade
Sets the rolling upgrade enabled setting for the account.

- There is a single argument of type SetSelfServeRollingUpgradeInput.
- Returns SetSelfServeRollingUpgradeReply.
### settotpconfig
Setup TOTP configuration for a user. Return true when the operation succeeds.

- There is a single argument of type SetTotpConfigInput.
- Returns System.Boolean.
### setupdisk
Setup an unformatted disk.

- There is a single argument of type SetupDiskInput.
- Returns DiskInfo.
### setupgradetype
Sets upgrade type of a cluster.

- There is a single argument of type SetUpgradeTypeInput.
- Returns SetUpgradeTypeReply.
### setuserleveltotpenforcement
Update the user-level TOTP enforcement for given users. Return true when the operation succeeds.

- There is a single argument of type SetUserLevelTotpEnforcementInput.
- Returns System.Boolean.
### setusersessionmanagementconfig
Update the session management configurations for the user account.

- There is a single argument of type SetUserSessionManagementConfigInput.
- Returns SetUserSessionManagementConfigReply.
### setworkloadalertsetting
Enable/disable alerts for given workload on given cluster.

- There is a single argument of type SetWorkloadAlertSettingInput.
- Returns SetWorkloadAlertSettingReply.
### startcrawl
Start a crawl.

- There are 4 arguments.
    - name - System.String
    - resources - list of ResourceInputs
    - analyzerGroups - list of AnalyzerGroupInputs
    - extWhiteList - list of System.Strings
- Returns StartCrawlReply.
### startdownloadpackagebatchjob
Starts CDM job to download installer package in batch.

- There are 5 arguments.
    - listClusterUuid - list of System.Strings: Specifies the list of cluster UUIDs.
    - downloadVersion - System.String: Specifies the Rubrik CDM download package version.
    - packageUrl - System.String: Specifies the Rubrik CDM upgrade package URL.
    - md5checksum - System.String: Specifies the MD5CheckSum of the Rubrik CDM installer package.
    - size - System.Int64: Specifies the size in bytes of the Rubrik CDM package.
- Returns list of DownloadPackageReplyWithUuids.
### startexportrdsinstancejob
Start a job to export RDS Instance. The job creates a new RDS Instance with the same properties as that of the instance that is exported.

- There is a single argument of type StartExportRdsInstanceJobInput.
- Returns AsyncJobStatus.
### startgithubappsetup
Starts the GitHub App setup flow for the specified organization and app
purposes. This is step 1 of the 3-step GitHub App registration flow:

Step 1: Call startGitHubAppSetup -- returns a session ID, the current app
status for each requested purpose, and setup info. If the app
status is NOT_REGISTERED or MISSING_LATEST_PERMISSIONS, the
response includes a GitHub App manifest (JSON) and a create_url.
The manifest contains the app name, homepage URL, visibility
setting, and the required GitHub permissions. Before submitting
the manifest, add two additional fields:
- setup_url: The URL where GitHub redirects users after they
install the app. GitHub appends the installation_id as a query
parameter to this URL.
- redirect_url: The URL where GitHub redirects after the app is
created. GitHub appends the setup code as a query parameter
to this URL.
Then POST the manifest to the create_url to begin app creation
on GitHub (see GitHubAppRegistrationInfo for details).
Step 2: Call completeGitHubAppRegistration -- after the user approves the
app on GitHub, pass the returned setup code along with the
session ID to exchange it for app credentials. Returns an
installation URL.
Step 3: Call completeGitHubAppInstallation -- after the user installs the
app on their GitHub organization, pass the installation ID along
with the session ID to finalize the setup.

- There is a single argument of type StartGitHubAppSetupInput.
- Returns StartGitHubAppSetupReply.
### startperiodicupgradeprechecksondemandjob
Starts an on demand periodic upgrade prechecks job in CDM cluster.

- There is a single argument of type System.String.
- Returns PrechecksJobReply.
### startupgradebatchjob
Starts cdm upgrades instantly, monitors the upgrade until terminal state is reached.

- There are 5 arguments.
    - listClusterUuid - list of System.Strings: Specifies the list of cluster UUIDs.
    - mode - System.String: Specifies the upgrade mode.
    - action - ActionType: Specifies the upgrade action.
    - version - System.String: Specifies the Rubrik CDM upgrade tarball version.
    - context_tag - System.String: Specifies the Context tag.
- Returns list of UpgradeJobReplyWithUuids.
### startvolumegroupmount
Initiate a live mount for a given Volume Group snapshot

Supported in v5.0+
Create a live mount request for a Volume Group snapshot.

- There is a single argument of type StartVolumeGroupMountInput.
- Returns AsyncRequestStatus.
### stopjobinstance
Issue request to stop a job instance. If successful, stop process for job instance is initiated. Job instance is stopped asynchronously in the background. The input must contain either the job instance ID or the event series ID. If it contains the job instance ID, this will stop the job instance corresponding to the ID. If it contains the event series ID, it will retrieve the latest job instance associated with the event series, and stop it.

- There is a single argument of type StopJobInstanceInput.
- Returns StopJobInstanceReply.
### stopjobinstancefromeventseries
Send a request to stop a job instance with the event series ID. If successful, stop process for the job instance is initiated, and the job instance is terminated asynchronously in the background.

- There is a single argument of type StopJobInstanceFromEventSeriesInput.
- Returns System.String.
### submittprrequest
Submit a TPR request.

- There is a single argument of type SubmitTprRequestInput.
- Returns System.String.
### supportportallogin
Log in to the Rubrik Support portal using username and password.

- There is a single argument of type SupportPortalLoginInput.
- Returns SupportPortalLoginReply.
### switchproducttoonboardingmode
Moves an M365 organization product from day-to-day mode to onboarding mode.

- There is a single argument of type SwitchProductToOnboardingModeInput.
- Returns System.String.
### triggerblimigration
TriggerBLIMigration triggers blob immutability migration for a list
of RCV Azure locations.

- There is a single argument of type TriggerBliMigrationInput.
- Returns TriggerBliMigrationReply.
### triggercloudcomputeconnectivitycheck
Trigger cloud compute connectivity check

Supported in v6.0+
Triggers a background job to perform the cloud compute connectivity check for the specified archival location.

- There is a single argument of type TriggerCloudComputeConnectivityCheckInput.
- Returns AsyncRequestStatus.
### triggerexocomputehealthcheck
Initiates on-demand Exocompute health check.

- There is a single argument of type TriggerExocomputeHealthCheckInput.
- Returns TriggerExocomputeHealthCheckReply.
### uninstallgithubapp
Uninstalls a GitHub App for the specified organization and permission group.

- There is a single argument of type UninstallGitHubAppInput.
- Returns System.String.
### uninstalliofilter
Uninstall the Rubrik ioFilter from the VMware cluster with a specific ID

Supported in v5.1+
Uninstall the Rubrik ioFilter from the VMware cluster with a specific ID. The cluster must be in maintenance mode to uninstall the ioFilter successfully. The vCenter of the VMware compute cluster must be of version 6.7 and above.

- There is a single argument of type UninstallIoFilterInput.
- Returns RequestSuccess.
### unlockusersbyadmin
Specifies the endpoint through which the admin can unlock the user accounts.

- There is a single argument of type UnlockUsersByAdminInput.
- Returns System.String.
### unmountdisk
Unmount selected disks.

- There is a single argument of type UnmountDiskInput.
- Returns System.String.
### updateaccountowner
- There is a single argument of type System.String.
- Returns System.Boolean.
### updateadgroup
Update the AD group display name, and it's filter attribute spec.

- There is a single argument of type UpdateAdGroupInput.
- Returns System.String.
### updateagentdeploymentsetting
Change the Rubrik Backup Service deployment setting

Supported in v5.0+
Modify the global setting for automatic deployment of the Rubrik Backup Service to virtual machines.

- There is a single argument of type UpdateVmAgentDeploymentSettingInput.
- Returns AgentDeploymentSettings.
### updateagentdeploymentsettinginbatch
Change the Rubrik Backup Service deployment setting in batch.

- There is a single argument of type UpdateAgentDeploymentSettingInBatchInput.
- Returns UpdateAgentDeploymentSettingInBatchReply.
### updateagentdeploymentsettinginbatchnew
Change the Rubrik Backup Service deployment setting in a batch.

- There is a single argument of type UpdateAgentDeploymentSettingInBatchNewInput.
- Returns UpdateAgentDeploymentSettingInBatchNewReply.
### updateauthdomainusershiddenstatus
Update the hidden status for the given auth domain users.

- There is a single argument of type UpdateAuthDomainUsersHiddenStatusInput.
- Returns System.String.
### updatebackupthrottlesetting
Update backup throttle setting.

- There is a single argument of type UpdateBackupThrottleSettingInput.
- Returns UpdateBackupThrottleSettingReply.
### updatebackuptriggerforworkloads
Set the backup trigger type for the workloads

Supported in v9.4+
Updates the backup trigger type for the workloads passed in the input.

- There is a single argument of type UpdateBackupTriggerForWorkloadsInput.
- Returns System.String.
### updatebaddiskledstatus
Find bad disk of a node in the CDM cluster.

- There is a single argument of type UpdateBadDiskLedStatusInput.
- Returns UpdateBadDiskLedStatusReply.
### updateclouddirectkerberoscredential
UpdateCloudDirectKerberosCredential updates an existing Kerberos credential for NCD systems.

- There is a single argument of type UpdateCloudDirectKerberosCredentialInput.
- Returns UpdateCloudDirectKerberosCredentialReply.
### updateconfiguredgroup
Update the configuration, name, or deletion status of a configured group.

- There is a single argument of type UpdateConfiguredGroupInput.
- Returns System.String.
### updatecustomanalyzer
Update a custom analyzer.

- There is a single argument of type CreateCustomAnalyzerInput.
- Returns Analyzer.
### updatecustomerapppermissions
Updates the Azure app for the specified account with specified permissions in an idempotent manner.

- There is a single argument of type UpdateCustomerAppPermissionsInput.
- Returns UpdateCustomerAppPermissionsReply.
### updatecustomintelfeed
Update custom intel feed.

- There is a single argument of type UpdateCustomIntelFeedInput.
- Returns System.String.
### updatedistributionlistdigest
Update specific distribution list digests.

- There is a single argument of type UpdateDistributionListDigestInput.
- Returns UpdateDistributionListDigestReply.
### updatednsserversandsearchdomains
Update cluster DNS servers and search domains.

- There is a single argument of type UpdateDnsServersAndSearchDomainsInput.
- Returns ResponseSuccess.
### updateeventdigest
Update event digests for specific recipients.

- There is a single argument of type UpdateEventDigestInput.
- Returns UpdateEventDigestReply.
### updatefeed
Updates properties of the feed.

- There is a single argument of type UpdateFeedInput.
- Returns System.String.
### updatefloatingips
Modify the list of cluster IPs

Supported in v5.0+
Modify the list of cluster IPs.

- There is a single argument of type UpdateFloatingIpsInput.
- Returns UpdateFloatingIpsReply.
### updatefusioncomputemount
Power a FusionCompute Live Mount on and off

Supported in v9.6
Power a specified FusionCompute Live Mount virtual machine on or off. Pass **_true_** to power the virtual machine on and pass **_false_** to power the virtual machine off.

- There is a single argument of type UpdateFusionComputeMountInput.
- Returns UpdateFusionComputeMountReply.
### updatefusioncomputevrm
Update FusionCompute VRM instance

Supported in v9.6
Update the metadata and configs of the specified FusionCompute VRM instance object.

- There is a single argument of type UpdateFusionComputeVrmInput.
- Returns UpdateFusionComputeVrmReply.
### updateguestcredential
Update guest OS credentials.

- There is a single argument of type UpdateGuestCredentialInput.
- Returns UpdateGuestCredentialReply.
### updateinsightstate
Toggle the dismissed state of an insight.

- There is a single argument of type UpdateInsightStateInput.
- Returns UpdateInsightStateReply.
### updateiocstatus
Update IOC status.

- There is a single argument of type list of UpdateIocStatusInputs.
- Returns System.String.
### updateipwhitelist
Update the IP allowlist for the given organization.

- There are 2 arguments.
    - whitelistMode - WhitelistModeEnum: The mode of the IP allowlist.
    - ipCidrs - list of System.Strings: The list of IP addresses in the allowlist.
- Returns System.Boolean.
### updateipwhitelistentry
Update an entry in the IP allowlist.

- There is a single argument of type UpdateIpWhitelistEntryInput.
- Returns System.String.
### updatelambdasettings
- There are 3 arguments.
    - anomalyThreshold - System.Single: Probability threshold for anomaly detector.
    - ransomwareThreshold - System.Single: Probability threshold for ransomware detector.
    - isAnomalyAlertEnabled - System.Boolean: Flag to represent if alert on anomaly workload is enabled.
- Returns LambdaSettings.
### updatelockoutconfig
Used by the administrator to update the account lockout settings for an organization.

- There is a single argument of type UpdateLockoutConfigInput.
- Returns UpdateLockoutConfigReply.
### updatemanagedidentities
Transition to Managed Identities.

- There is a single argument of type UpdateManagedIdentitiesInput.
- Returns UpdateManagedIdentitiesReply.
### updatemanagedidentitiesasync
Async transition of Azure Cloud Cluster to managed identities.

- There is a single argument of type UpdateManagedIdentitiesAsyncInput.
- Returns CcProvisionJobReply.
### updatenetworkthrottle
Update a network throttle

Supported in v5.0+
Update the configuration of a specified network throttle object.

- There is a single argument of type UpdateNetworkThrottleInput.
- Returns UpdateNetworkThrottleReply.
### updateproxmoxenvironment
Update Proxmox environment.

- There is a single argument of type UpdateProxmoxEnvironmentInput.
- Returns UpdateProxmoxEnvironmentReply.
### updateproxyconfig
Update proxy config

Supported in v5.0+
Update proxy config.

- There is a single argument of type UpdateProxyConfigInput.
- Returns UpdateProxyConfigReply.
### updaterecoveryschedulev2
Updates a recovery schedule for a recovery plan.

- There is a single argument of type UpdateRecoveryScheduleV2Input.
- Returns System.String.
### updateroleassignments
Replaces RBAC role assignments for the given users and/or groups.
Existing role assignments are overwritten with the provided role IDs.

- There are 3 arguments.
    - userIds - list of System.Strings: List of user IDs.
    - groupIds - list of System.Strings: List of group IDs.
    - roleIds - list of System.Strings: List of role IDs to assign.
- Returns System.Boolean.
### updatesupportuseraccess
Updates a Rubrik Support representative's access to the customer's account.

- There is a single argument of type UpdateSupportUserAccessInput.
- Returns System.String.
### updatetprconfiguration
Update TPR configuration.

- There is a single argument of type UpdateTprConfigurationInput.
- Returns System.String.
### updatetunnelstatus
Enable or disable the SSH Tunnel for Support Access

Supported in v5.0+
To be used by Admin to open or close a SSH tunnel for support. When enabling the support tunnel, the node 'id' must be *me* or the current node's 'id', because remote open is not supported. When disabling a support tunnel, the node 'id' can be that of any node in the cluster.

- There is a single argument of type UpdateTunnelStatusInput.
- Returns UpdateTunnelStatusReply.
### updatevlan
Update a VLAN interface on the Rubrik cluster

Supported in v8.0+
Update the configuration of an existing VLAN on the Rubrik cluster. VLAN netmask and IP addresses can be changed.

- There is a single argument of type UpdateVlanInput.
- Returns System.String.
### updatevolumegroup
Update Volume Group properties

Supported in v5.3+
Patch Volume Group with specified properties.

- There is a single argument of type UpdateVolumeGroupInput.
- Returns UpdateVolumeGroupReply.
### updatewhitelistedanalyzers
Update whitelisted analyzers for a path.

- There are 5 arguments.
    - stdPath - System.String: The standard path of the directory to browse.
    - snappableFid - System.String
    - snapshotFid - System.String
    - analyzerIds - list of System.Strings
    - runAsync - System.Boolean
- Returns System.String.
### upgradeiofilter
Upgrade the Rubrik ioFilter for the VMware cluster with a specific ID

Supported in v5.1+
Upgrade the Rubrik ioFilter for a VMware cluster with a specific ID. The cluster must be in maintenance mode to upgrade the ioFilter successfully. The vCenter of the VMware compute cluster must be of version 6.7 and above.

- There is a single argument of type UpgradeIoFilterInput.
- Returns RequestSuccess.
### upgradetorsc
Converts a GPS account to an RSC account.

- The upgradetorsc subcommand takes no arguments.
- Returns System.String.
### validateandsavecustomerkmsinfo
Validate KMS input provided on O365 subscription setup.

- There is a single argument of type ValidateAndSaveCustomerKmsInfoInput.
- Returns ValidateAndSaveCustomerKmsInfoReply.
### vmmakeprimary
Make this cluster the primary for agents on a set of VMs

Supported in v5.3+
Migrate the primary cluster with which the agent is able to communicate. For disaster recovery when migrating everything over from another cluster, the /host/make_primary endpoint can be used with the oldPrimaryClusterUuid parameter.

- There is a single argument of type VmMakePrimaryInput.
- Returns AsyncRequestStatus.
### warmsearchcache
Warms the search cache for an O365 workload.

- There is a single argument of type WarmSearchCacheInput.
- Returns System.Boolean.
### windowsrbsbulkinstall
Bulk install and register RBS on Windows host.

- There is a single argument of type WindowsRbsBulkInstallInput.
- Returns WindowsRbsBulkInstallReply.
