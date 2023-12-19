# New-RscMutationMisc
## Subcommands
### addadgroupstohierarchy
Add AD Groups to O365 hierarchy.

- There is a single argument of type AddAdGroupsToHierarchyInput.
- Returns RequestStatus.
### addclusternodes
Add nodes to the CDM cluster.

- There is a single argument of type AddClusterNodesInput.
- Returns AddClusterNodesReply.
### addconfiguredgrouptohierarchy
Add a Configured Group to the O365 hierarchy.

- There is a single argument of type AddConfiguredGroupToHierarchyInput.
- Returns AddConfiguredGroupToHierarchyReply.
### addinventoryworkloads
Add account level inventory workloads.

- There is a single argument of type AddInventoryWorkloadsInput.
- Returns System.Boolean.
### addpolicyobjects
Add policies to objects.

- There are 4 arguments.
    - policyIds - list of System.Strings
    - objectIds - list of System.Strings
    - objectRootIds - list of System.Strings: List of supported root IDs.
    - clusterIds - list of System.Strings: List of Rubrik cluster IDs.
- Returns System.String.
### addroleassignments
- There are 3 arguments.
    - userIds - list of System.Strings: List of user IDs.
    - groupIds - list of System.Strings: List of group IDs.
    - roleIds - list of System.Strings
- Returns System.Boolean.
### addsyslogexportrule
Add a new syslog export rule

Supported in v5.1+
Adds a new rule specifying where to export the specified syslog information.

- There is a single argument of type AddSyslogExportRuleInput.
- Returns AddSyslogExportRuleReply.
### addvlan
Add VLAN to Rubrik cluster.

- There is a single argument of type AddVlanInput.
- Returns ResponseSuccess.
### addvmappconsistentspecs
Add Vm App consistent specs info

- There is a single argument of type AddVmAppConsistentSpecsInput.
- Returns AddVmAppConsistentSpecsReply.
### archivecrawl
Archive a crawl.

- There is a single argument of type System.String.
- Returns System.String.
### assignprotection
Assign protection to cassandra objects.

- There is a single argument of type AssignProtectionInput.
- Returns SlaAssignResult.
### batchdeassignrolefromusergroups
- There is a single argument of type list of UserGroupToRolesInputs.
- Returns System.Boolean.
### bulkcreatenasfilesets
Create filesets in bulk for NAS shares

Supported in v7.0+
Create primary filesets for a list of NAS shares.

- There is a single argument of type BulkCreateNasFilesetsInput.
- Returns BulkCreateNasFilesetsReply.
### bulkdeletefailoverclusterapp
Delete failover cluster applications

Supported in v5.3+
Delete failover cluster applications from Rubrik cluster.

- There is a single argument of type BulkDeleteFailoverClusterAppInput.
- Returns ResponseSuccess.
### bulkdeletenassystems
Delete multiple NAS systems

Supported in v7.0+
Triggers a delete of the specified NAS systems. Returns an asynchronous request to check their delete status.

- There is a single argument of type BulkDeleteNasSystemsInput.
- Returns BatchAsyncRequestStatus.
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
### changepassword
- There is a single argument of type ChangePasswordInput.
- Returns System.Boolean.
### createactivedirectorylivemount
Initiate a Live Mount of an Active Directory Domain Controller snapshot

Supported in v9.0+
Initiates a job to perform a Live Mount of an Active Directory Domain Controller snapshot. Returns the job instance ID.

- There is a single argument of type CreateActiveDirectoryLiveMountInput.
- Returns AsyncRequestStatus.
### createactivedirectoryunmount
Remove a Live Mount of an Active Directory Domain Controller snapshot

Supported in v9.0+
Initiates a job to remove a Live Mount of an Active Directory Domain Controller snapshot. Returns the job instance ID.

- There is a single argument of type CreateActiveDirectoryUnmountInput.
- Returns AsyncRequestStatus.
### createcustomanalyzer
Create a new custom analyzer.

- There is a single argument of type CreateCustomAnalyzerInput.
- Returns Analyzer.
### createfailoverclusterapp
Create a failover cluster app

Supported in v5.2+
Create a failover cluster app.

- There is a single argument of type CreateFailoverClusterAppInput.
- Returns CreateFailoverClusterAppReply.
### createglacierreadertarget
Create a reader target of type Glacier on a Rubrik cluster.

- There is a single argument of type CreateGlacierReaderTargetInput.
- Returns Target.
### createguestcredential
Create guest OS credentials.

- There is a single argument of type CreateGuestCredentialInput.
- Returns CreateGuestCredentialReply.
### createintegration
Creates a new integration.

- There is a single argument of type CreateIntegrationInput.
- Returns CreateIntegrationReply.
### createintegrations
Create a batch of new integrations.

- There is a single argument of type CreateIntegrationsInput.
- Returns CreateIntegrationsReply.
### createmanualtargetmapping
- There is a single argument of type CreateManualTargetMappingInput.
- Returns TargetMapping.
### createondemandvolumegroupbackup
Create on-demand snapshot for the Volume Group

Supported in v5.3+
Create an on-demand snapshot for the given Volume Group ID.

- There is a single argument of type CreateOnDemandVolumeGroupBackupInput.
- Returns AsyncRequestStatus.
### createorg
Create a new organization under global org.

- There is a single argument of type CreateOrgInput.
- Returns CreateOrgReply.
### createorgswitchsession
Generate a new authentication token for a user to switch organizations.

- There is a single argument of type CreateOrgSwitchSessionInput.
- Returns CreateOrgSwitchSessionReply.
### createpolicy
Create a classification policy.

- There is a single argument of type CreatePolicyInput.
- Returns ClassificationPolicyDetail.
### createrole
This endpoint is deprecated.

- There are 3 arguments.
    - name - System.String
    - description - System.String
    - permissions - list of PermissionInputs: Permissions in the role.
- Returns System.String.
### creates3compatiblereadertarget
Creates reader type for S3Compatible archival location on a CDM cluster.

- There is a single argument of type CreateS3CompatibleReaderTargetInput.
- Returns Target.
### creates3compatibletarget
- There is a single argument of type CreateS3CompatibleTargetInput.
- Returns Target.
### createuser
- There are 2 arguments.
    - email - System.String
    - roleIds - list of System.Strings
- Returns System.String.
### createuserwithpassword
- There is a single argument of type CreateUserWithPasswordInput.
- Returns System.String.
### createvappsinstantrecovery
Initiate instant recovery from vApp snapshots.

- There is a single argument of type CreateVappsInstantRecoveryInput.
- Returns CreateVappsInstantRecoveryReply.
### deactivatecustomanalyzer
Deactivate a custom analyzer.

- There is a single argument of type System.String.
- Returns System.String.
### deactivatepolicy
Deactivate a classification policy.

- There are 2 arguments.
    - policyId - System.String
    - runAsync - System.Boolean
- Returns list of System.Strings.
### deleteadgroupsfromhierarchy
Delete AD Groups from O365 hierarchy.

- There is a single argument of type DeleteAdGroupsFromHierarchyInput.
- Returns RequestStatus.
### deletecsr
Delete Certificate Signing Request.

- There is a single argument of type DeleteCsrInput.
- Returns System.String.
### deletedistributionlistdigestbatch
Delete specific distribution list digests.

- There is a single argument of type DeleteDistributionListDigestBatchInput.
- Returns System.String.
### deleteeventdigest
Delete event digests for specific recipients.

- There is a single argument of type DeleteEventDigestInput.
- Returns System.String.
### deletefailoverclusterapp
Delete a failover cluster

Supported in v5.2+
Delete a failover cluster.

- There is a single argument of type DeleteFailoverClusterAppInput.
- Returns ResponseSuccess.
### deleteguestcredentialbyid
Delete guest OS credentials.

- There is a single argument of type DeleteGuestCredentialByIdInput.
- Returns System.Boolean.
### deleteintegration
Delete the integration with the specified integration ID.

- There is a single argument of type DeleteIntegrationInput.
- Returns System.String.
### deleteintegrations
Delete a batch of integrations.

- There is a single argument of type DeleteIntegrationsInput.
- Returns System.String.
### deletelogshipping
Delete a specified log shipping configuration.

- There is a single argument of type DeleteLogShippingInput.
- Returns AsyncRequestStatus.
### deletenassystem
Delete a registered NAS system

Supported in v7.0+
Delete a NAS system by specifying the NAS system ID.

- There is a single argument of type DeleteNasSystemInput.
- Returns AsyncRequestStatus.
### deleteorg
Delete an organization.

- There is a single argument of type DeleteOrgInput.
- Returns System.Boolean.
### deleterole
- There is a single argument of type System.String.
- Returns System.Boolean.
### deletesyslogexportrule
Delete the specified syslog export rule

Supported in v5.1+
Delete the syslog export rule specified by the given id.

- There is a single argument of type DeleteSyslogExportRuleInput.
- Returns System.String.
### deletetarget
Deletes an archival location.

- There is a single argument of type DeleteTargetInput.
- Returns System.String.
### deletetargetmapping
Deletes mapping of a target.

- There is a single argument of type DeleteTargetMappingInput.
- Returns System.String.
### deletetotpconfig
Reset TOTP configuration for a user. Return true when the operation succeeds.

- There is a single argument of type System.String.
- Returns System.Boolean.
### deletetotpconfigs
Reset TOTP configuration for users in batch. Return true when the operation succeeds.

- There is a single argument of type DeleteTotpConfigsInput.
- Returns System.Boolean.
### deletevolumegroupmount
Requst to delete a mount

Supported in v5.0+
Create a request to delete a mount. If there are volumes mounted on a target host, this will use best-effort to unmount those volumes from the host, and proceed to unmount storage on Rubrik.

- There is a single argument of type DeleteVolumeGroupMountInput.
- Returns AsyncRequestStatus.
### disablesupportuseraccess
Disables a Rubrik Support representative's access to the customer's account.

- There is a single argument of type DisableSupportUserAccessInput.
- Returns System.String.
### disabletarget
Disables an Archival Location.

- There is a single argument of type DisableTargetInput.
- Returns DisableTargetReply.
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
### enabletarget
Enables an Archival Location.

- There is a single argument of type EnableTargetInput.
- Returns EnableTargetReply.
### excludevmdisks
Exclude or include virtual disks during snapshot.

- There is a single argument of type list of ExcludeVmDisksInputs.
- Returns RequestSuccess.
### generateclusterregistrationtoken
Generate a JWT that can be used to register clusters with Rubrik. If ManagedByRubrikArg is not given, the product type is inferred automatically.

- There is a single argument of type GenerateClusterRegistrationTokenInput.
- Returns ClusterRegistrationToken.
### generateconfigprotectionrestoreform
Generate restore form for the configuration backup file.

- There is a single argument of type GenerateConfigProtectionRestoreFormInput.
- Returns GenerateConfigProtectionRestoreFormReply.
### generatecsr
Generate CSR.

- There are 10 arguments.
    - name - System.String: Name for your CSR.
    - hostnames - list of System.Strings: Hostnames for your CSR.
    - organization - System.String: Organization for your CSR.
    - organizationUnit - System.String: Organization unit for your CSR.
    - country - System.String: Country for your CSR.
    - state - System.String: State for your CSR.
    - city - System.String: City for your CSR.
    - email - System.String: Email for your CSR.
    - surname - System.String: Surname for your CSR.
    - userId - System.String: User ID for your CSR.
- Returns Csr.
### generatesupportbundle
Collect log files from the cluster

Supported in v5.0+
To be used by Admin to collect necessary Rubrik's log files from all the nodes. Both event_id and reqeust_ids are optional. If nothing is specified, the whole support bundle is to be collected, if event_id is specified, the reqeuest_ids is ignored. If request id is specified, only collect logs related to the specific request, otherwise collect all the logs.

- There is a single argument of type GenerateSupportBundleInput.
- Returns AsyncRequestStatus.
### generatetotpsecret
Generate TOTP secret for a user.

- There is a single argument of type System.String.
- Returns GenerateTotpSecretReply.
### getdownloadurl
- There is a single argument of type System.Int64.
- Returns UserDownloadUrl.
### gethealthmonitorpolicystatus
Get health monitor policies on the Rubrik cluster.

- There is a single argument of type GetHealthMonitorPolicyStatusInput.
- Returns GetHealthMonitorPolicyStatusReply.
### hiderevealnasnamespaces
Hide and reveal NAS namespaces

Supported in v7.0+
Hide individually selected NAS namespaces by setting the "action" field to "Hide". Reveal the selected NAS namespaces by setting the "action" field to "Reveal".

- There is a single argument of type HideRevealNasNamespacesInput.
- Returns System.String.
### hiderevealnasshares
Hide or reveal NAS shares

Supported in v7.0+
Hide individually selected NAS shares by setting the "action" field to "Hide". Reveal selected NAS shares by setting the "action" field to "Reveal".

- There is a single argument of type HideRevealNasSharesInput.
- Returns ResponseSuccess.
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
### listcidrsforcomputesetting
List CIDRs for compute setting.

- There is a single argument of type ListCidrsForComputeSettingInput.
- Returns ListCidrsForComputeSettingReply.
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
### modifyactivedirectorylivemount
Modifies a Live Mount of an Active Directory domain controller snapshot

Supported in v9.0+
Modifies the parameters of a Live Mount of an Active Directory domain controller snapshot.

- There is a single argument of type ModifyActiveDirectoryLiveMountInput.
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
### mutaterole
- There are 5 arguments.
    - roleId - System.String: ID of the role.
    - name - System.String
    - description - System.String
    - permissions - list of PermissionInputs: Permissions in the role.
    - protectableClusters - list of System.Strings
- Returns System.String.
### notificationforgetlicense
Send notification when the user clicks on the Get License button.

- The notificationforgetlicense subcommand takes no arguments.
- Returns NotificationForGetLicenseReply.
### pausetarget
- There is a single argument of type PauseTargetInput.
- Returns PauseTargetReply.
### promotereadertarget
Promotes a reader Archival Location.

- There is a single argument of type PromoteReaderTargetInput.
- Returns System.String.
### recoverclouddirectmultipaths
Cloud Direct MultiPaths Recovery.

- There is a single argument of type RecoverCloudDirectMultiPathsInput.
- Returns AsyncRequestStatus.
### recoverclouddirectpath
Cloud Direct Path Recovery.

- There is a single argument of type RecoverCloudDirectPathInput.
- Returns AsyncRequestStatus.
### refreshdomain
Initiates an on-demand refresh job of a specified Active Directory domain.

- There is a single argument of type RefreshDomainInput.
- Returns AsyncRequestStatus.
### refreshglobalmanagerconnectivitystatus
- There is a single argument of type System.String.
- Returns GlobalManagerConnectivity.
### refreshnassystems
On-demand discovery of a list of NAS systems

Supported in v7.0+
Runs the NAS_DISCOVER job for autodiscovery/refresh of NAS systems.

- There is a single argument of type RefreshNasSystemsInput.
- Returns RefreshNasSystemsReply.
### refreshreadertarget
Refreshes a reader Archival Location.

- There is a single argument of type RefreshReaderTargetInput.
- Returns System.String.
### registernassystem
Register a NAS System

Supported in v7.0+
Register a NAS system such as a NetApp or an Isilon cluster to be protected.

- There is a single argument of type RegisterNasSystemInput.
- Returns RegisterNasSystemReply.
### removeclusternodes
Remove healthy nodes from a cluster.

- There is a single argument of type RemoveClusterNodesInput.
- Returns CcProvisionJobReply.
### removedisk
Marks the disk removed and updates cluster metadata

- There is a single argument of type RemoveDiskInput.
- Returns ResponseSuccess.
### removeinventoryworkloads
Remove account level inventory workloads.

- There is a single argument of type RemoveInventoryWorkloadsInput.
- Returns System.Boolean.
### removepolicyobjects
Remove policies from objects.

- There are 5 arguments.
    - policyIds - list of System.Strings
    - objectIds - list of System.Strings
    - objectRootIds - list of System.Strings: List of supported root IDs.
    - clusterIds - list of System.Strings: List of Rubrik cluster IDs.
    - runAsync - System.Boolean
- Returns list of System.Strings.
### removeprivateendpointlist
Remove private endpoint connection to RCV location.

- There is a single argument of type RemovePrivateEndpointConnectionInput.
- Returns System.String.
### removeproxyconfig
Delete existing proxy configuration

Supported in v5.0+
Delete an existing proxy that was configured.

- There is a single argument of type RemoveProxyConfigInput.
- Returns ResponseSuccess.
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
### resolvevolumegroupsconflict
Marks that the user has resolved that there are no conflicting volume groups on the host where this Exchange server exists

Supported in v8.0+
Marks that the user has resolved that there are no conflicting volume groups on the host where this Exchange server exists.

- There is a single argument of type ResolveVolumeGroupsConflictInput.
- Returns RequestSuccess.
### restoreactivedirectoryobjects
Restore the given objects to the Active Directory

Supported in v9.0+
Initiates a recovery for the given Active Directory objects.

- There is a single argument of type RestoreActiveDirectoryObjectsInput.
- Returns AsyncRequestStatus.
### resumetarget
- There is a single argument of type ResumeTargetInput.
- Returns ResumeTargetReply.
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
### setcustomertags
Sets customer-specified tags and the value whether the resource tags should be overridden by customer-specified tags for a given cloud type.

- There is a single argument of type SetCustomerTagsInput.
- Returns System.String.
### setdatastorefreespacethresholds
Set datastore freespace thresholds.

- There is a single argument of type SetDatastoreFreespaceThresholdsInput.
- Returns SetDatastoreFreespaceThresholdsReply.
### setipwhitelistenabled
- There is a single argument of type System.Boolean.
- Returns System.Boolean.
### setmfasetting
Update the MFA settings for the account. Return true when the operation succeeds.

- There is a single argument of type SetMfaSettingInput.
- Returns System.Boolean.
### setpasswordcomplexitypolicy
Set the password complexity policy for the current organization.

- There is a single argument of type SetPasswordComplexityPolicyInput.
- Returns System.String.
### settotpconfig
Setup TOTP configuration for a user. Return true when the operation succeeds.

- There is a single argument of type SetTotpConfigInput.
- Returns System.Boolean.
### setupdisk
Setup an unformatted disk

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
### supportportallogin
Log in to the Rubrik Support portal using username and password.

- There is a single argument of type SupportPortalLoginInput.
- Returns SupportPortalLoginReply.
### testsyslogexportrule
Test the specified syslog export rule

Supported in v5.1+
Send a test message using the syslog export rule specified by the given id.

- There is a single argument of type TestSyslogExportRuleInput.
- Returns TestSyslogExportRuleReply.
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
### updateauthdomainusershiddenstatus
Update the hidden status for the given auth domain users.

- There is a single argument of type UpdateAuthDomainUsersHiddenStatusInput.
- Returns System.String.
### updateautoenablepolicyclusterconfig
Update Rubrik cluster configuration to enable or not enable the Auto-enabled Data Discovery Policies feature.

- There is a single argument of type UpdateAutoEnablePolicyClusterConfigInput.
- Returns UpdateAutoEnablePolicyClusterConfigReply.
### updatebaddiskledstatus
Find bad disk of a node in the CDM cluster.

- There is a single argument of type UpdateBadDiskLedStatusInput.
- Returns UpdateBadDiskLedStatusReply.
### updateclusterdefaultaddress
Update the default address of a Rubrik cluster.

- There is a single argument of type UpdateClusterDefaultAddressInput.
- Returns UpdateClusterDefaultAddressReply.
### updateclusterlocation
- There are 2 arguments.
    - clusterUuid - System.String: The Rubrik cluster ID.
    - clusterLocation - ClusterLocationEdit
- Returns Cluster.
### updateclusterntpservers
Assign NTP servers to Rubrik cluster

Supported in v5.0+
Assign NTP servers to Rubrik cluster.

- There is a single argument of type UpdateClusterNtpServersInput.
- Returns ResponseSuccess.
### updateclustersettings
Update Rubrik CDM cluster settings.

- There is a single argument of type UpdateClusterSettingsInput.
- Returns UpdateClusterSettingsReply.
### updateconfiguredgroup
Update the configuration, name, or deletion status of a configured group.

- There is a single argument of type UpdateConfiguredGroupInput.
- Returns System.String.
### updatecustomanalyzer
Update a custom analyzer.

- There is a single argument of type CreateCustomAnalyzerInput.
- Returns Analyzer.
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
### updatefailoverclusterapp
Update a failover cluster app

Supported in v5.2+
Update the failover cluster app with specified properties.

- There is a single argument of type UpdateFailoverClusterAppInput.
- Returns UpdateFailoverClusterAppReply.
### updatefloatingips
Modify the list of cluster IPs

Supported in v5.0+
Modify the list of cluster IPs.

- There is a single argument of type UpdateFloatingIpsInput.
- Returns UpdateFloatingIpsReply.
### updateglaciertarget
Edit a reader target of type Glacier on a Rubrik cluster.

- There is a single argument of type UpdateGlacierTargetInput.
- Returns Target.
### updateguestcredential
Update guest OS credentials.

- There is a single argument of type UpdateGuestCredentialInput.
- Returns UpdateGuestCredentialReply.
### updatehealthmonitorpolicystatus
Run health monitor policies on the CDM cluster.

- There is a single argument of type UpdateHealthMonitorPolicyStatusInput.
- Returns UpdateHealthMonitorPolicyStatusReply.
### updateinsightstate
Toggle the dismissed state of an insight.

- There is a single argument of type UpdateInsightStateInput.
- Returns UpdateInsightStateReply.
### updateintegration
Update the integration with the specified integration ID.

- There is a single argument of type UpdateIntegrationInput.
- Returns System.String.
### updateintegrations
Update a batch of integrations.

- There is a single argument of type UpdateIntegrationsInput.
- Returns System.String.
### updateipwhitelist
- There are 2 arguments.
    - whitelistMode - WhitelistModeEnum
    - ipCidrs - list of System.Strings
- Returns System.Boolean.
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
### updatemanualtargetmapping
- There is a single argument of type UpdateManualTargetMappingInput.
- Returns TargetMapping.
### updatenasshares
Bulk update multiple NAS shares

Supported in v7.0+
Updates fields like changelist of multiple NAS shares.

- There is a single argument of type UpdateNasSharesInput.
- Returns System.String.
### updatenassystem
Modify the information for a registered NAS system

Supported in v7.0+
Change the hostname that is associated with a NAS system. Update the credentials used to access the vendor-specific APIs.

- There is a single argument of type UpdateNasSystemInput.
- Returns UpdateNasSystemReply.
### updatenetworkthrottle
- There is a single argument of type UpdateNetworkThrottleInput.
- Returns UpdateNetworkThrottleReply.
### updateorg
Update an organization.

- There is a single argument of type UpdateOrgInput.
- Returns UpdateOrgReply.
### updateorgsecuritypolicy
Update organization security policy.

- There is a single argument of type UpdateOrgSecurityPolicyInput.
- Returns System.String.
### updatepolicy
Update a classification policy.

- There is a single argument of type UpdatePolicyInput.
- Returns ClassificationPolicyDetail.
### updatepreviewerclusterconfig
Update previewer cluster configuration.

- There is a single argument of type PreviewerClusterConfigInput.
- Returns Cluster.
### updateproxyconfig
Update proxy config

Supported in v5.0+
Update proxy config.

- There is a single argument of type UpdateProxyConfigInput.
- Returns UpdateProxyConfigReply.
### updaterole
This endpoint is deprecated.

- There are 4 arguments.
    - roleId - System.String: ID of the role.
    - name - System.String
    - description - System.String
    - permissions - list of PermissionInputs: Permissions in the role.
- Returns System.Boolean.
### updateroleassignments
- There are 3 arguments.
    - userIds - list of System.Strings: List of user IDs.
    - groupIds - list of System.Strings: List of group IDs.
    - roleIds - list of System.Strings
- Returns System.Boolean.
### updates3compatibletarget
- There is a single argument of type UpdateS3CompatibleTargetInput.
- Returns Target.
### updatesnmpconfig
Update SNMP configuration

Supported in v5.0+
Update the SNMP configuration for a specified Rubrik cluster.

- There is a single argument of type UpdateSnmpConfigInput.
- Returns UpdateSnmpConfigReply.
### updatesupportuseraccess
Updates a Rubrik Support representative's access to the customer's account.

- There is a single argument of type UpdateSupportUserAccessInput.
- Returns System.String.
### updatesyslogexportrule
Update the specified syslog export rule

Supported in v5.1+
Update the syslog export rule specified by the given id.

- There is a single argument of type UpdateSyslogExportRuleInput.
- Returns UpdateSyslogExportRuleReply.
### updatetunnelstatus
Enable or disable the SSH Tunnel for Support Access

Supported in v5.0+
To be used by Admin to open or close a SSH tunnel for support. When enabling the support tunnel, the node 'id' must be *me* or the current node's 'id', because remote open is not supported. When disabling a support tunnel, the node 'id' can be that of any node in the cluster.

- There is a single argument of type UpdateTunnelStatusInput.
- Returns UpdateTunnelStatusReply.
### updatevolumegroup
Update Volume Group properties

Supported in v5.3+
Patch Volume Group with specified properties.

- There is a single argument of type UpdateVolumeGroupInput.
- Returns UpdateVolumeGroupReply.
### updatewhitelistedanalyzers
Update whitelisted analyzers for a path.

- There are 5 arguments.
    - stdPath - System.String
    - snappableFid - System.String
    - snapshotFid - System.String
    - analyzerIds - list of System.Strings
    - runAsync - System.Boolean
- Returns System.String.
### upgradecdmmanagedtarget
Upgrade archival locations managed through a Rubrik cluster.

- There is a single argument of type UpgradeCdmManagedTargetInput.
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
### warmsearchcache
Warms the search cache for an O365 workload.

- There is a single argument of type WarmSearchCacheInput.
- Returns System.Boolean.
