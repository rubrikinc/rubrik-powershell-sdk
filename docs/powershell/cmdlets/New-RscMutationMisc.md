# New-RscMutationMisc
## Subcommands
### addadgroupstohierarchy
Add AD Groups to O365 hierarchy.

- There is a single argument of type AddAdGroupsToHierarchyInput.
- Returns RequestStatus.
### addconfiguredgrouptohierarchy
Add a Configured Group to the O365 hierarchy.

- There is a single argument of type AddConfiguredGroupToHierarchyInput.
- Returns AddConfiguredGroupToHierarchyReply.
### addinventoryworkloads
Add account level inventory workloads.

- There is a single argument of type AddInventoryWorkloadsInput.
- Returns System.Boolean.
### addroleassignments
- There are 3 arguments.
    - userIds - list of System.Strings: List of user IDs.
    - groupIds - list of System.Strings: List of group IDs.
    - roleIds - list of System.Strings
- Returns System.Boolean.
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
### createcustomanalyzer
Create a new custom analyzer.

- There is a single argument of type CreateCustomAnalyzerInput.
- Returns Analyzer.
### createeventdigestbatch
Create event digests for specific recipients.

- There is a single argument of type CreateEventDigestBatchInput.
- Returns System.String.
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
### createvappsinstantrecovery
Initiate instant recovery from vApp snapshots.

- There is a single argument of type CreateVappsInstantRecoveryInput.
- Returns CreateVappsInstantRecoveryReply.
### deactivatecustomanalyzer
Deactivate a custom analyzer.

- There is a single argument of type System.String.
- Returns System.String.
### deleteadgroupsfromhierarchy
Delete AD Groups from O365 hierarchy.

- There is a single argument of type DeleteAdGroupsFromHierarchyInput.
- Returns RequestStatus.
### deletedistributionlistdigestbatch
Delete specific distribution list digests.

- There is a single argument of type DeleteDistributionListDigestBatchInput.
- Returns System.String.
### deleteeventdigest
Delete event digests for specific recipients.

- There is a single argument of type DeleteEventDigestInput.
- Returns System.String.
### deleteguestcredentialbyid
Delete guest OS credentials.

- There is a single argument of type DeleteGuestCredentialByIdInput.
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
### excludevmdisks
Exclude or include virtual disks during snapshot.

- There is a single argument of type list of ExcludeVmDisksInputs.
- Returns RequestSuccess.
### expiresnoozeddirectories
Expire snoozed directories.

- There is a single argument of type ExpireSnoozedDirectoriesInput.
- Returns ExpireSnoozedDirectoriesReply.
### generateconfigprotectionrestoreform
Generate restore form for the configuration backup file.

- There is a single argument of type GenerateConfigProtectionRestoreFormInput.
- Returns GenerateConfigProtectionRestoreFormReply.
### generatesupportbundle
Collect log files from the cluster

Supported in v5.0+
To be used by Admin to collect necessary Rubrik's log files from all the nodes. Both event_id and reqeust_ids are optional. If nothing is specified, the whole support bundle is to be collected, if event_id is specified, the reqeuest_ids is ignored. If request id is specified, only collect logs related to the specific request, otherwise collect all the logs.

- There is a single argument of type GenerateSupportBundleInput.
- Returns AsyncRequestStatus.
### getdownloadurl
- There is a single argument of type System.Int64.
- Returns UserDownloadUrl.
### hiderevealnasnamespaces
Hide and reveal NAS namespaces

Supported in v7.0+
Hide individually selected NAS namespaces by setting the "action" field to "Hide". Reveal the selected NAS namespaces by setting the "action" field to "Reveal".

- There is a single argument of type HideRevealNasNamespacesInput.
- Returns System.String.
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
### modifyeventdigestbatch
Modify event digests for specific recipients.

- There is a single argument of type ModifyEventDigestBatchInput.
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

- The notificationforgetlicense subcommand takes no arguments.
- Returns NotificationForGetLicenseReply.
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
### removedisk
Marks the disk removed and updates cluster metadata

- There is a single argument of type RemoveDiskInput.
- Returns ResponseSuccess.
### removeinventoryworkloads
Remove account level inventory workloads.

- There is a single argument of type RemoveInventoryWorkloadsInput.
- Returns System.Boolean.
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
### setprivatecontainerregistry
Sets the Private Container Registry (PCR) details for an Exocompute cloud account. Updates the details if the registry already exists and creates a new entry if it does not exist.

- There is a single argument of type SetPrivateContainerRegistryInput.
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
### switchproducttoonboardingmode
Moves an M365 organization product from day-to-day mode to onboarding mode.

- There is a single argument of type SwitchProductToOnboardingModeInput.
- Returns SwitchProductToOnboardingModeReply.
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
### updateagentdeploymentsetting
Change the Rubrik Backup Service deployment setting

Supported in v5.0+
Modify the global setting for automatic deployment of the Rubrik Backup Service to virtual machines.

- There is a single argument of type UpdateVmAgentDeploymentSettingInput.
- Returns AgentDeploymentSettings.
### updateauthdomainusershiddenstatus
Update the hidden status for the given auth domain users.

- There is a single argument of type UpdateAuthDomainUsersHiddenStatusInput.
- Returns System.String.
### updatebaddiskledstatus
Find bad disk of a node in the CDM cluster.

- There is a single argument of type UpdateBadDiskLedStatusInput.
- Returns UpdateBadDiskLedStatusReply.
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
### updatefloatingips
Modify the list of cluster IPs

Supported in v5.0+
Modify the list of cluster IPs.

- There is a single argument of type UpdateFloatingIpsInput.
- Returns UpdateFloatingIpsReply.
### updateguestcredential
Update guest OS credentials.

- There is a single argument of type UpdateGuestCredentialInput.
- Returns UpdateGuestCredentialReply.
### updateinsightstate
Toggle the dismissed state of an insight.

- There is a single argument of type UpdateInsightStateInput.
- Returns UpdateInsightStateReply.
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
### updatemanagedidentities
Transition to Managed Identities.

- There is a single argument of type UpdateManagedIdentitiesInput.
- Returns UpdateManagedIdentitiesReply.
### updatenetworkthrottle
- There is a single argument of type UpdateNetworkThrottleInput.
- Returns UpdateNetworkThrottleReply.
### updateproxyconfig
Update proxy config

Supported in v5.0+
Update proxy config.

- There is a single argument of type UpdateProxyConfigInput.
- Returns UpdateProxyConfigReply.
### updateroleassignments
- There are 3 arguments.
    - userIds - list of System.Strings: List of user IDs.
    - groupIds - list of System.Strings: List of group IDs.
    - roleIds - list of System.Strings
- Returns System.Boolean.
### updatesupportuseraccess
Updates a Rubrik Support representative's access to the customer's account.

- There is a single argument of type UpdateSupportUserAccessInput.
- Returns System.String.
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
