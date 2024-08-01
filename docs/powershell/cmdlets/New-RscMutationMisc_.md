# New-RscMutationMisc
## Subcommands
### acknowledgefedrampboundaryexit
Acknowledges that the user is exiting the FedRAMP boundary.

- There is a single argument of type AcknowledgeFedrampBoundaryExitInput.
- Returns System.String.
### activatetrialasync
Activate the trial asynchronously. Returns the UUID of the taskchain responsible for the trial activation.

- There is a single argument of type ActivateTrialAsyncInput.
- Returns ActivateTrialAsyncReply.
### addadgroupstohierarchy
Add AD Groups to O365 hierarchy.

- There is a single argument of type AddAdGroupsToHierarchyInput.
- Returns RequestStatus.
### addconfiguredgrouptohierarchy
Add a Configured Group to the O365 hierarchy.

- There is a single argument of type AddConfiguredGroupToHierarchyInput.
- Returns AddConfiguredGroupToHierarchyReply.
### addcustomintelfeed
Add custom intel feed.

- There is a single argument of type AddCustomIntelFeedInput.
- Returns AddCustomIntelFeedReply.
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
### addsaasapprecoveryorg
Adds a saas-app org used only for recovery.

- There is a single argument of type AddRecoveryOrgInput.
- Returns AddRecoveryOrgReply.
### addvcdinstances
Add vCD instances to Rubrik clusters.

- There is a single argument of type AddVcdInstancesInput.
- Returns AddVcdInstancesReply.
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
### batchdeassignrolefromusergroups
- There is a single argument of type list of UserGroupToRolesInputs.
- Returns System.Boolean.
### batchrefreshdomains
Initiates an on-demand refresh job of specified Active Directory domains.

- There is a single argument of type list of System.Strings.
- Returns BatchAsyncRequestStatus.
### bulkaddkmipserver
Add a KMIP server to the list of active KMIP servers on the specified Rubrik clusters.

- There is a single argument of type BulkAddKmipServerInput.
- Returns BulkAddKmipServerReply.
### bulkcancelfailovers
Cancel multiple failovers.

- There is a single argument of type BulkCancelFailoversInput.
- Returns System.String.
### bulkcreatenasfilesets
Create filesets in bulk for NAS shares

Supported in v7.0+
Create primary filesets for a list of NAS shares.

- There is a single argument of type BulkCreateNasFilesetsInput.
- Returns BulkCreateNasFilesetsReply.
### bulkupdatesnapmirrorcloud
Update SnapMirror Cloud objects

Supported in v7.0+
Update properties of the specified SnapMirror Cloud objects.

- There is a single argument of type BulkUpdateSnapMirrorCloudInput.
- Returns BulkUpdateSnapMirrorCloudReply.
### cancelblueprintfailover
- There is a single argument of type System.String.
- Returns Result.
### cancelbulkrecovery
Cancel bulk recovery.

- There is a single argument of type CancelBulkRecoveryInput.
- Returns CancelBulkRecoveryReply.
### canceldownloadpackage
Cancels download package job of a cluster.

- There is a single argument of type System.String.
- Returns CancelJobReply.
### canceljobinstance
REQUIRES SUPPORT TOKEN - Cancel job instance corresponding to id

Supported in v9.1+
REQUIRES SUPPORT TOKEN - Cancels the specified job instance if job state permits it. Returns job instance details.

- There is a single argument of type CancelJobInstanceInput.
- Returns InternalJobInstanceDetail.
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
### changepassword
- There is a single argument of type ChangePasswordInput.
- Returns System.Boolean.
### checkstatus
Check status for all tasks for a given Rubrik cluster.

- There is a single argument of type CheckStatusInput.
- Returns BatchAsyncJobStatus.
### cleanupblueprintfailover
- There is a single argument of type CleanupFailoverJobInfo.
- Returns CreateOnDemandJobReply.
### cleanupisolatedrecoveries
- There is a single argument of type list of CleanupIsolatedRecoveryJobInfos.
- Returns list of CreateOnDemandJobReplys.
### cleanupisolatedrecovery
- There is a single argument of type CleanupIsolatedRecoveryJobInfo.
- Returns CreateOnDemandJobReply.
### completeoperationalrecovery
Complete operational recovery.

- There is a single argument of type CompleteOperationalRecoveryInput.
- Returns StartBulkRecoveryV2Reply.
### completesaasappauthconsent
- There is a single argument of type CompleteSaasAppAuthConsentInput.
- Returns CompleteSaasAppAuthConsentReply.
### completetrialonboarding
Complete the onboarding phase of the trial.

- There is a single argument of type CompleteTrialOnboardingInput.
- Returns System.String.
### completetrialtask
Complete a specific trial task.

- There is a single argument of type CompleteTrialTaskInput.
- Returns System.String.
### computebucketimmutabilitylockduration
Computes the bucket immutability lock duration for archival location.

- There is a single argument of type ComputeBucketImmutabilityLockDurationInput.
- Returns ComputeBucketImmutabilityLockDurationReply.
### configuredns
Configure DNS server addresses.

- There is a single argument of type list of System.Strings.
- Returns System.Boolean.
### configurelogexport
For a specific SLA Managed Volume, this endpoint configures the log export.

- There is a single argument of type ConfigureLogExportInput.
- Returns AsyncRequestStatus.
### configurentp
Configure NTP server addresses.

- There is a single argument of type list of System.Strings.
- Returns System.Boolean.
### configureticketingplatformwithoauth
Configure ticketing platform using OAuth.

- There is a single argument of type ConfigureTicketingPlatformWithOAuthInput.
- Returns System.String.
### createblueprint
- There are 11 arguments.
    - name - System.String
    - children - list of AppBlueprintChildInputs
    - sourceLocationId - System.String: The ID of the source location.
    - sourceLocationType - BlueprintLocationType: The type of the source location.
    - targetLocationType - BlueprintLocationType: The type of the intended remote target location.
    - targetLocationId - System.String: The ID of the intended remote target location.
    - status - BlueprintStatus: The status of the Recovery Plan.
    - enableHydration - System.Boolean: Specifies whether hydration is enabled for the Recovery Plan.
    - timeoutBetweenPriorityGroups - list of System.Int64s: A list of numbers representing the length of time, in minutes, to pause between each priority group during recovery. The numbers are ordered to align with the order of the priority groups. For example, consider a Blueprint with 3 priority groups. For this Blueprint, a value of [5,10,0] implies that there is a 5-minute pause between the 1st and 2nd priority groups and a 10-minute pause between the 2nd and 3rd priority groups. The last value in the list is always 0.
    - blueprintRecoveryType - BlueprintRecoveryType: Recovery type of the Recovery Plan.
    - isBlueprintVisible - System.Boolean: Flag to enable visibility of the Recovery Plan.
- Returns BlueprintNew.
### createblueprintrecoveryspec
create a list of blueprint recovery specs with a list of child snappable/snapshot recovery specs

- There are 4 arguments.
    - blueprintId - System.String: The Blueprint ID.
    - specType - RecoverySpecType: the type of the recovery specs (AWS_EC2, VMWARE_VM)
    - recoveryConfigs - list of AppBlueprintRecoverySpecCreateReqInputTypes: configurations of the recovery specs
    - isDefaultRecoverySpec - System.Boolean: Indicate if its not a default recovery spec request.
- Returns list of BlueprintRecoverySpecs.
### createchat
Create a chat.

- There is a single argument of type CreateChatInput.
- Returns CreateChatReply.
### createchatbot
Create a Chatbot.

- There is a single argument of type CreateChatbotInput.
- Returns CreateChatbotReply.
### createconfigprotectionbackup
Create the configuration protection backup.

- There is a single argument of type ConfigProtectionBackupInput.
- Returns BatchAsyncJobStatus.
### createconfigprotectionsetup
Set up configuration protection for a cluster.

- There is a single argument of type CreateConfigProtectionSetupInput.
- Returns AsyncJobStatus.
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
### createorgnetwork
Create the organization network in a specified organization.

- There is a single argument of type CreateOrgNetworkInput.
- Returns CreateOrgNetworkReply.
### createpasskey
Create a passkey for the account.

- There is a single argument of type CreatePasskeyInput.
- Returns CreatePasskeyReply.
### createrbacmigrationsummarydownload
Creates a download of the Rubrik cluster RBAC configuration migration summary for a specific cluster.

- There is a single argument of type CreateRbacMigrationSummaryDownloadInput.
- Returns CreateRbacMigrationSummaryDownloadReply.
### createrecoveryplan
Create a Recovery Plan

- There is a single argument of type CreateRecoveryPlanInput.
- Returns CreateRecoveryPlanReply.
### createrecoveryschedule
- There is a single argument of type CreateRecoveryScheduleInput.
- Returns CreateScheduleReply.
### creates3bucket
Creates an AWS S3 bucket.

- There is a single argument of type CreateS3BucketInput.
- Returns CreateS3BucketReply.
### createsnapmirrorcloud
v7.0-v8.0: Create a SnapMirror Cloud protected object for a NetApp volume
v8.1+: Create a SnapMirror Cloud workload for a NetApp volume

Supported in v7.0+
v7.0-v8.0: Create a SnapMirror Cloud protected object for a NetApp volume.
v8.1+: Create a SnapMirror Cloud workload for a NetApp volume.

- There is a single argument of type CreateSnapMirrorCloudInput.
- Returns CreateSnapMirrorCloudReply.
### createsnapmirrorcloudrelationship
Create a SnapMirrorCloud relationship on NetApp server between the volume and the cloud target

Supported in v7.0+
Creates a SnapMirrorCloud relationship on NetApp server between the volume and the cloud target which are configured on the SnapMirrorCloud protected object.

- There is a single argument of type CreateSnapMirrorCloudRelationshipInput.
- Returns CreateSnapMirrorCloudRelationshipReply.
### createsnapmirrorcloudrestorejob
Create restore job to restore multiple files/directories or the NetApp volume

Supported in v7.0+
Launches a job to restore a source NetApp volume or a subset of the files and directories in that volume to a target volume. The target volume can be the same as the source volume.

- There is a single argument of type CreateSnapMirrorCloudRestoreJobInput.
- Returns AsyncRequestStatus.
### createssousers
Create SSO users.

- There is a single argument of type CreateSsoUsersInput.
- Returns CreateSsoUsersReply.
### createsupportcase
Create a support case.

- There is a single argument of type CreateSupportCaseInput.
- Returns CreateSupportCaseReply.
### createuseraccessinsightticket
Create a ticket for a User Access insight.

- There is a single argument of type CreateUserAccessInsightTicketInput.
- Returns CreateUserAccessInsightTicketReply.
### createvappexport
Export vCD a vApp snapshot.

- There is a single argument of type CreateVappExportInput.
- Returns list of AsyncRequestStatuss.
### createvappsinstantrecovery
Initiate instant recovery from vApp snapshots.

- There is a single argument of type CreateVappsInstantRecoveryInput.
- Returns CreateVappsInstantRecoveryReply.
### deactivatecustomanalyzer
Deactivate a custom analyzer.

- There is a single argument of type System.String.
- Returns System.String.
### deleteaccountsettingvalue
Delete account settings value.

- There are 2 arguments.
    - aspName - System.String: Name of Account Setting Parameter (ASP) in account setting table.
    - aspComponent - ComponentEnum: Name of component that uses ASP in account setting table.
- Returns System.Boolean.
### deleteadgroupsfromhierarchy
Delete AD Groups from O365 hierarchy.

- There is a single argument of type DeleteAdGroupsFromHierarchyInput.
- Returns RequestStatus.
### deleteblueprint
- There is a single argument of type System.String.
- Returns System.Boolean.
### deleteblueprints
Delete multiple Blueprints.

- There is a single argument of type DeleteBlueprintsInput.
- Returns System.Boolean.
### deletebrandlogo
Remove the brand logo for the account.

- The deletebrandlogo subcommand takes no arguments.
- Returns System.String.
### deletechatbot
Delete a Chatbot.

- There is a single argument of type DeleteChatbotInput.
- Returns System.String.
### deletedistributionlistdigestbatch
Delete specific distribution list digests.

- There is a single argument of type DeleteDistributionListDigestBatchInput.
- Returns System.String.
### deleteenvoyngs
Delete EnvoyNgs for a specific organization network.

- There is a single argument of type DeleteEnvoyNgsInput.
- Returns System.String.
### deleteeventdigest
Delete event digests for specific recipients.

- There is a single argument of type DeleteEventDigestInput.
- Returns System.String.
### deleteguestcredentialbyid
Delete guest OS credentials.

- There is a single argument of type DeleteGuestCredentialByIdInput.
- Returns System.Boolean.
### deleteidentityprovider
- The deleteidentityprovider subcommand takes no arguments.
- Returns IdentityProvider.
### deleteintelfeed
Delete intel feed.

- There is a single argument of type DeleteIntelFeedInput.
- Returns System.String.
### deletekmipserver
Deletes a KMIP server from the specified Rubrik clusters.

- There is a single argument of type DeleteKmipServerInput.
- Returns DeleteKmipServerReply.
### deletekmsinstance
Delete an existing KMS via its UUID.

- There is a single argument of type DeleteKmsInstanceInput.
- Returns System.String.
### deleteorgnetwork
Delete the organization network in a specified organization.

- There is a single argument of type DeleteOrgNetworkInput.
- Returns System.String.
### deletepasskey
Delete a passkey for the user.

- There is a single argument of type DeletePasskeyInput.
- Returns DeletePasskeyReply.
### deleterecoveryplan
Delete a Recovery Plan.

- There is a single argument of type System.String.
- Returns System.String.
### deleterecoveryplans
Delete multiple Recovery Plans.

- There is a single argument of type list of System.Strings.
- Returns System.String.
### deleterecoveryschedule
- There is a single argument of type DeleteRecoveryScheduleInput.
- Returns System.String.
### deleterecoveryspec
Delete one or more recovery specifications associated with the Blueprint ID or failover summary ID.

- There are 3 arguments.
    - blueprintId - System.String: The Blueprint ID.
    - excludePlanTypes - list of PlanNames: List of plan types (PROD, TEST, PROD_LOCAL) that will be excluded from spec deletion.
    - failoverId - System.String: Failover summary ID.
- Returns DeleteBlueprintRecoverySpecReply.
### deletesmtpconfiguration
Delete SMTP configuration value.

- The deletesmtpconfiguration subcommand takes no arguments.
- Returns System.Boolean.
### deletesnapmirrorcloud
v7.0-v8.0: Delete a SnapMirror Cloud protected object
v8.1+: Delete a SnapMirror Cloud workload

Supported in v7.0+
v7.0-v8.0: Delete a SnapMirror Cloud protected object specified by the object ID.
v8.1+: Delete a SnapMirror Cloud workload specified by the object ID.

- There is a single argument of type DeleteSnapMirrorCloudInput.
- Returns ResponseSuccess.
### deletesnapmirrorcloudrelationship
Delete the SnapMirrorCloud relationship on the NetApp server between the volume and the cloud target

Supported in v7.0+
Deletes the SnapMirrorCloud relationship on the NetApp server between the volume and the cloud target. Also deletes objects on the NetApp server used to establish the relationship.

- There is a single argument of type DeleteSnapMirrorCloudRelationshipInput.
- Returns ResponseSuccess.
### deletevcdinstances
Delete vCD instances from Rubrik clusters.

- There is a single argument of type DeleteVcdInstancesInput.
- Returns DeleteVcdInstancesReply.
### deletevolumegroupmount
Requst to delete a mount

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
### disconnectticketingplatform
Disconnect a configured ticketing platform.

- There is a single argument of type DisconnectTicketingPlatformInput.
- Returns System.String.
### dissolvelegalhold
Dissolve legal hold on snapshots.

- There is a single argument of type DissolveLegalHoldInput.
- Returns DissolveLegalHoldReply.
### editpasskey
Edit a passkey for the user.

- There is a single argument of type EditPasskeyInput.
- Returns EditPasskeyReply.
### editsalesforceorganization
Edit the Salesforce organization in RSC.

- There is a single argument of type EditSalesforceOrganizationInput.
- Returns EditSalesforceOrganizationReply.
### enableautomaticfmdupload
Enable/disable auto fmd upload on given cluster.

- There is a single argument of type EnableAutomaticFmdUploadInput.
- Returns EnableAutomaticFmdUploadReply.
### enabledisableappconsistency
Enable/ Disable App consistency for a VM

- There is a single argument of type EnableDisableAppConsistencyInput.
- Returns EnableDisableAppConsistencyReply.
### enablelambdaforworkload
Enable/disable lambda service for given workload on given cluster.

- There are 3 arguments.
    - snappableId - System.String: The FID of the workload.
    - enableDiffFmd - System.Boolean: Enable or disable diff FMD upload.
    - enableFullFmd - System.Boolean: Enable or disable full FMD upload.
- Returns EnableLambdaForSnappableReply.
### enablemigrationworkflow
Enable the migration workflow.

- The enablemigrationworkflow subcommand takes no arguments.
- Returns EnableMigrationWorkflowReply.
### enablesupportuseraccess
Enables a Rubrik Support representative's access to the customer's account.

- There is a single argument of type EnableSupportUserAccessInput.
- Returns System.String.
### enabletprorg
Enable TPR for an organization.

- There is a single argument of type EnableTprOrgInput.
- Returns System.Boolean.
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
### exportprincipalssummary
Export the user summary data.

- There are 3 arguments.
    - filter - ExportPrincipalsSummaryFilterInput: Filter to be applied when exporting principal summaries.
    - timelineDate - System.String: Date for which the results will be retrieved.
    - historicalDeltaDays - System.Int32: Historical days to go backward in time to calculate the delta.
- Returns ExportPrincipalSummaryResp.
### exportunaccesseduserssummary
Export the user summary that is not accessed.

- There are 3 arguments.
    - filter - ExportUnAccessedUsersSummaryFilterInput: Filter to be applied at the time of exporting the user summary that is not accessed.
    - endTime - DateTime: End time in ISO string format (YYYY-MM-DDThh:mm:ssZ).
    - timePeriod - TimePeriod: Time period for the activity.
- Returns ExportUnAccessedUsersSummaryResp.
### extendrscautoupgradedate
Extends RSC auto upgrade date to final upgrade date.

- The extendrscautoupgradedate subcommand takes no arguments.
- Returns ExtendRscAutoUpgradeDateReply.
### extendtrialasync
Initiate an asynchronous trial extension. Returns the UUID of the taskchain responsible for the trial extension.

- There is a single argument of type ExtendTrialAsyncInput.
- Returns ExtendTrialAsyncReply.
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
### ignoretrial
- There is a single argument of type IgnoreTrialInput.
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
### inviteuserstotrial
Invites users to the specified trial. If a user with the given email address does not exist, RSC creates a local user with that email address. Each invited user is granted a Rubrik-generated role that gives them permissions to complete all of the steps in the trial.

- There is a single argument of type InviteUsersToTrialInput.
- Returns InviteUsersToTrialReply.
### listcidrsforcomputesetting
List CIDRs for compute setting.

- There is a single argument of type ListCidrsForComputeSettingInput.
- Returns ListCidrsForComputeSettingReply.
### lockisolatedrecovery
Starts the process to lock the isolated recovery.

- There is a single argument of type LockIsolatedRecoveryInput.
- Returns System.Boolean.
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
### marknotificationsasread
Marks provided notifications as read.

- There is a single argument of type MarkNotificationsAsReadInput.
- Returns MarkNotificationsAsReadReply.
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

- There is a single argument of type NotificationForGetLicenseInput.
- Returns NotificationForGetLicenseReply.
### promoterecovery
- There is a single argument of type PromoteRecoveryInput.
- Returns CreateOnDemandJobReply.
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
### refreshorgnetwork
Refresh Envoy NGs associated with the organization network.

- There is a single argument of type RefreshOrgNetworkInput.
- Returns System.String.
### refreshvcdinstances
Refresh vCD instances from Rubrik clusters.

- There is a single argument of type RefreshVcdInstancesInput.
- Returns RefreshVcdInstancesReply.
### registerandenablemigrationchoice
Register the choice and enable the migration workflow.

- There is a single argument of type RegisterAndEnableMigrationChoiceInput.
- Returns RegisterAndEnableMigrationReply.
### removedisk
Marks the disk removed and updates cluster metadata

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
### resetmigrationonmodechange
Reset the migration on mode change.

- There is a single argument of type ResetMigrationOnModeChangeInput.
- Returns ResetMigrationOnModeChangeReply.
### resetpasskeys
Reset passkeys for the current user.

- There is a single argument of type System.String.
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
### restoreconfigprotectionbackup
Restore the configuration protection backup.

- There is a single argument of type RestoreConfigProtectionBackupInput.
- Returns AsyncJobStatus.
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
### runprechecks
Run list of migration prechecks for given cluster.

- There is a single argument of type RunPrechecksInput.
- Returns BatchAsyncJobStatus.
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
### sendemailnow
- There are 3 arguments.
    - reportID - System.Int32: The report ID.
    - reportConfig - ReportConfigInput
    - recipients - list of System.Strings
- Returns reportGenerateReply.
### sendpactsafeevent
Send an event to Pactsafe for the specified contract.

- There is a single argument of type SendPactsafeEventInput.
- Returns System.String.
### sendtestsmtpemail
- There are 9 arguments.
    - useExisting - System.Boolean: Specifies whether to use existing configuration or configuration that is passed in.
    - recipient - System.String: Recipient of test email.
    - hostName - System.String: Host name for your SMTP configuration.
    - port - System.Int32: Port number for your SMTP configuration.
    - userName - System.String: User name for your SMTP configuration.
    - password - System.String: Password for your SMTP configuration.
    - defaultFromEmail - System.String: Email address used to identify the sender for your SMTP configuration.
    - securityType - SMTPSecurityTypeEnum: Security type to use.
    - trustedCertId - System.Int64: Trusted certificate to use for your SMTP configuration.
- Returns System.Boolean.
### setaccountsettingvalue
Create (or update if already exists) the account settings value.

- There are 3 arguments.
    - aspName - System.String: Name of Account Setting Parameter (ASP) in account setting table.
    - aspComponent - ComponentEnum: Name of component that uses ASP in account setting table.
    - aspValue - System.String: Value of ASP in account setting table.
- Returns ASPValue.
### setanalyzerrisks
Set risk for analyzers.

- There is a single argument of type SetAnalyzerRisksInput.
- Returns SetAnalyzerRisksReply.
### setbrandlogo
Set or update the brand logo for the account.

- There is a single argument of type SetBrandLogoInput.
- Returns System.String.
### setbundleapprovalstatus
Sets the approval status of an Exocompute container image bundle.

- There is a single argument of type SetBundleApprovalStatusInput.
- Returns System.String.
### setcorssetting
Set organization-specified CORS setting.

- There is a single argument of type SetCorsSettingInput.
- Returns CorsSetting.
### setcustomertags
Sets customer-specified tags and the value whether the resource tags should be overridden by customer-specified tags for a given cloud type.

- There is a single argument of type SetCustomerTagsInput.
- Returns System.String.
### setdatastorefreespacethresholds
Set datastore freespace thresholds.

- There is a single argument of type SetDatastoreFreespaceThresholdsInput.
- Returns SetDatastoreFreespaceThresholdsReply.
### setfederatedloginstatus
Set federated login status.

- There is a single argument of type FederatedLoginStatusInput.
- Returns System.Boolean.
### setidentityprovider
- There are 5 arguments.
    - entityId - System.String: Entity ID of your identity provider.
    - signInUrl - System.String: Sign-in URL ID of your identity provider.
    - signingCertificate - System.String: Signing certificate of your identity provider.
    - metadataJson - System.String: Optional metadata of your identity provider in .json format.
    - isTemp - System.Boolean: Specifies if the identity provider should be set as temporary optionally.
- Returns IdentityProvider.
### setipwhitelistenabled
- There is a single argument of type System.Boolean.
- Returns System.Boolean.
### setkmipclient
Specify KMIP client credentials for nodes

Supported in v5.3+
Specify KMIP client credentials for each of the Rubrik cluster nodes.

- There is a single argument of type SetKmipClientInput.
- Returns AsyncRequestStatus.
### setlivemountips
Assigns live mount IP addresses for a specific organization network.

- There is a single argument of type SetLiveMountIpsInput.
- Returns System.String.
### setmfasetting
Update the MFA settings for the account. Return true when the operation succeeds.

- There is a single argument of type SetMfaSettingInput.
- Returns System.Boolean.
### setmigrationstatus
Set the migration status for the specified Rubrik cluster precheck.

- There is a single argument of type SetMigrationStatusInput.
- Returns SetMigrationStatusReply.
### setpasskeyconfig
Set passkey configuration.

- There is a single argument of type SetPasskeyConfigInput.
- Returns SetPasskeyConfigReply.
### setprivatecontainerregistry
Sets the Private Container Registry (PCR) details for an Exocompute cloud account. Updates the details if the registry already exists and creates a new entry if it does not exist.

- There is a single argument of type SetPrivateContainerRegistryInput.
- Returns System.String.
### setsmtpconfiguration
- There are 7 arguments.
    - hostName - System.String: Host name for your SMTP configuration.
    - port - System.Int32: Port number for your SMTP configuration.
    - userName - System.String: User name for your SMTP configuration.
    - password - System.String: Password for your SMTP configuration.
    - defaultFromEmail - System.String: Email address used to identify the sender for your SMTP configuration.
    - securityType - SMTPSecurityTypeEnum: Security type to use.
    - trustedCertId - System.Int64: Trusted certificate to use for your SMTP configuration.
- Returns System.Boolean.
### settotpconfig
Setup TOTP configuration for a user. Return true when the operation succeeds.

- There is a single argument of type SetTotpConfigInput.
- Returns System.Boolean.
### setupatlassiansite
Set up the Atlassian site in Rsc.

- There is a single argument of type SetupAtlassianSiteInput.
- Returns SetupAtlassianSiteReply.
### setupdisk
Setup an unformatted disk

- There is a single argument of type SetupDiskInput.
- Returns DiskInfo.
### setupgradetype
Sets upgrade type of a cluster.

- There is a single argument of type SetUpgradeTypeInput.
- Returns SetUpgradeTypeReply.
### setupsalesforceorganization
Set up the salesforce organization in RSC.

- There is a single argument of type SetupSalesforceOrganizationInput.
- Returns SetupSalesforceOrganizationReply.
### setuserleveltotpenforcement
Update the user-level TOTP enforcement for given users. Return true when the operation succeeds.

- There is a single argument of type SetUserLevelTotpEnforcementInput.
- Returns System.Boolean.
### setusersessionmanagementconfig
Update the session management configurations for the user account.

- There is a single argument of type SetUserSessionManagementConfigInput.
- Returns SetUserSessionManagementConfigReply.
### setusersetting
Set user-specific settings.

- There are 2 arguments.
    - userSetting - UserSettingInputType: Settings to add for a specific user.
    - isOrgSpecificSetting - System.Boolean: Specifies whether the setting has been scoped to the tenant organization.
- Returns UserSetting.
### setworkloadalertsetting
Enable/disable alerts for given workload on given cluster.

- There is a single argument of type SetWorkloadAlertSettingInput.
- Returns SetWorkloadAlertSettingReply.
### setwwwtlscert
Set WWW TLS certificate.

- There is a single argument of type SetWwwTlsCertInputType.
- Returns System.Boolean.
### snoozeeula
Snooze the EULA.

- There is a single argument of type SnoozeEulaInput.
- Returns System.String.
### startblueprintfailover
- There is a single argument of type BlueprintFailoverJobConfig.
- Returns CreateOnDemandJobReply.
### startblueprintsfailover
Start failover jobs for multiple blueprints.

- There is a single argument of type list of BlueprintFailoverJobConfigs.
- Returns list of CreateOnDemandJobReplys.
### startbulkrecovery
Start bulk recovery.

- There is a single argument of type StartBulkRecoveryInput.
- Returns StartBulkRecoveryReply.
### startcrawl
Start a crawl.

- There are 4 arguments.
    - name - System.String
    - resources - list of ResourceInputs
    - analyzerGroups - list of AnalyzerGroupInputs
    - extWhiteList - list of System.Strings
- Returns StartCrawlReply.
### startcyberrecovery
- There is a single argument of type StartCyberRecoveryInput.
- Returns CreateOnDemandJobReply.
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
### startfetchcdmrbacconfigjob
Starts an on-demand job that will fetch the CDM RBAC configuration from the specified cluster and store it within RSC.

- There is a single argument of type StartFetchCdmRbacConfigJobInput.
- Returns System.String.
### startmalwaredetection
Detect malware

Supported in v6.0+
Initiate an asynchronous malware detection.

- There is a single argument of type RunDetectMalwareInput.
- Returns AsyncRequestStatus.
### startmigratecdmrbacconfigjob
Starts an on-demand job that will utilize the fetched CDM RBAC configuration for a specific cluster and create the corresponding RBAC configuration on RSC.

- There is a single argument of type StartMigrateCdmRbacConfigJobInput.
- Returns System.String.
### startmultiplebulkrecoveries
Start bulk recovery.

- There is a single argument of type StartMultipleBulkRecoveriesInput.
- Returns StartMultipleBulkRecoveriesReply.
### startnasautomigrationjob
Starts an asynchronous job to trigger NAS migration.

- There is a single argument of type NasAutomigrationJobInput.
- Returns CreateOnDemandJobReply.
### startperiodicupgradeprechecksondemandjob
Starts an on demand periodic upgrade prechecks job in CDM cluster.

- There is a single argument of type System.String.
- Returns PrechecksJobReply.
### startsaasappauthconsent
- There is a single argument of type StartSaasAppAuthConsentInput.
- Returns StartSaasAppAuthConsentReply.
### startsaasappsdeleteorg
Starts an asynchronous job to delete the Saas Apps org.

- There is a single argument of type StartSaasAppsDeleteOrgInput.
- Returns CreateOnDemandJobReply.
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
### togglefeatureenabled
- There are 2 arguments.
    - featureName - FeatureName
    - enableFeature - System.Boolean
- Returns System.Boolean.
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
### updateaccountsettings
This endpoint is deprecated.

- There are 2 arguments.
    - isEulaAccepted - System.Boolean: Flag to represent if the EULA has been accepted.
    - isEmailNotificationEnabled - System.Boolean: Flag to represent if email notification is enabled.
- Returns AccountSetting.
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
### updateauthdomainusershiddenstatus
Update the hidden status for the given auth domain users.

- There is a single argument of type UpdateAuthDomainUsersHiddenStatusInput.
- Returns System.String.
### updatebackupthrottlesetting
Update backup throttle setting.

- There is a single argument of type UpdateBackupThrottleSettingInput.
- Returns UpdateBackupThrottleSettingReply.
### updatebaddiskledstatus
Find bad disk of a node in the CDM cluster.

- There is a single argument of type UpdateBadDiskLedStatusInput.
- Returns UpdateBadDiskLedStatusReply.
### updateblueprint
- There are 13 arguments.
    - fid - System.String: The Rubrik UUID for the object.
    - name - System.String
    - children - list of AppBlueprintChildInputs
    - sourceLocationId - System.String: The ID of the source location.
    - sourceLocationType - BlueprintLocationType: The type of the source location.
    - targetLocationType - BlueprintLocationType: The type of the intended remote target location.
    - targetLocationId - System.String: The ID of the intended remote target location.
    - status - BlueprintStatus: The status of the Recovery Plan.
    - version - System.Int32: The version of the Recovery Plan.
    - enableHydration - System.Boolean: Specifies whether hydration is enabled for the Recovery Plan.
    - timeoutBetweenPriorityGroups - list of System.Int64s: A list of numbers representing the length of time, in minutes, to pause between each priority group during recovery. The numbers are ordered to align with the order of the priority groups. For example, consider a Blueprint with 3 priority groups. For this Blueprint, a value of [5,10,0] implies that there is a 5-minute pause between the 1st and 2nd priority groups and a 10-minute pause between the 2nd and 3rd priority groups. The last value in the list is always 0.
    - blueprintRecoveryType - BlueprintRecoveryType: Recovery type of the Recovery Plan.
    - isBlueprintVisible - System.Boolean: Flag to enable visibility of the Recovery Plan.
- Returns BlueprintNew.
### updatechat
Update a chat.

- There is a single argument of type UpdateChatReq.
- Returns System.String.
### updatechatbot
Update a Chatbot.

- There is a single argument of type UpdateChatbotInput.
- Returns UpdateChatbotReply.
### updateclassificationbannerenabled
- The updateclassificationbannerenabled subcommand takes no arguments.
- Returns System.Boolean.
### updateclassificationbannersettings
- There is a single argument of type ClassificationBannerSettingsInputType.
- Returns System.Boolean.
### updateclassificationloginenabled
- The updateclassificationloginenabled subcommand takes no arguments.
- Returns System.Boolean.
### updateclassificationloginsettings
- There is a single argument of type ClassificationLoginSettingsInputType.
- Returns System.Boolean.
### updateconfigprotectionsetup
Update configuration protection setup for a cluster.

- There is a single argument of type UpdateConfigProtectionSetupInput.
- Returns AsyncJobStatus.
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
### updatecybereventlockdown
Update the cyber event lockdown state

Supported in v9.2+
Update the cyber event lockdown state. Enable or disable the cyber event lockdown.

- There is a single argument of type UpdateCyberEventLockdownInput.
- Returns UpdateCyberEventLockdownResponse.
### updatedistributionlistdigest
Update specific distribution list digests.

- There is a single argument of type UpdateDistributionListDigestInput.
- Returns UpdateDistributionListDigestReply.
### updatednsserversandsearchdomains
Update cluster DNS servers and search domains.

- There is a single argument of type UpdateDnsServersAndSearchDomainsInput.
- Returns ResponseSuccess.
### updateeulaaccepted
Update Eula Acceptance details.

- The updateeulaaccepted subcommand takes no arguments.
- Returns System.Boolean.
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
### updateidentityprovider
Create or update existing custom claims.

- There is a single argument of type UpdateIdentityProviderInput.
- Returns UpdateIdentityProviderReply.
### updateinsightstate
Toggle the dismissed state of an insight.

- There is a single argument of type UpdateInsightStateInput.
- Returns UpdateInsightStateReply.
### updateiocstatus
Update IOC status.

- There is a single argument of type list of UpdateIocStatusInputs.
- Returns System.String.
### updateipwhitelist
- There are 2 arguments.
    - whitelistMode - WhitelistModeEnum
    - ipCidrs - list of System.Strings
- Returns System.Boolean.
### updatekmipserver
Updates a KMIP server on the specified Rubrik clusters.

- There is a single argument of type UpdateKmipServerInput.
- Returns UpdateKmipServerReply.
### updatelambdasettings
- There are 3 arguments.
    - anomalyThreshold - System.Single: Probability threshold for anomaly detector.
    - ransomwareThreshold - System.Single: Probability threshold for ransomware detector.
    - isAnomalyAlertEnabled - System.Boolean: Flag to represent if alert on anomaly workload is enabled.
- Returns LambdaSettings.
### updatellmenabled
Update whether LLMs are enabled for the account.

- There is a single argument of type UpdateLlmEnabledReq.
- Returns System.String.
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
### updateorgnetwork
Update the organization network in a specified organization.

- There is a single argument of type UpdateOrgNetworkInput.
- Returns System.String.
### updatepactsafeeulaaccepted
Update whether the user has signed the EULA.

- There is a single argument of type UpdatePactsafeEulaAcceptedInput.
- Returns UpdatePactsafeEulaAcceptedReply.
### updatepactsafeeulaseen
Update whether the user has seen the EULA.

- The updatepactsafeeulaseen subcommand takes no arguments.
- Returns UpdatePactsafeEulaSeenReply.
### updateproxyconfig
Update proxy config

Supported in v5.0+
Update proxy config.

- There is a single argument of type UpdateProxyConfigInput.
- Returns UpdateProxyConfigReply.
### updatereaderlocationmasterkeywithownerlocationkey
Updates reader location's master key with owner location's key.

- There is a single argument of type UpdateReaderLocationMasterKeyWithOwnerLocationKeyInput.
- Returns System.String.
### updatereaderlocationmasterkeywithrsakey
Updates reader location's master key with RSA key.

- There is a single argument of type UpdateReaderLocationMasterKeyWithRsaKeyInput.
- Returns System.String.
### updaterecoveryplan
Update a Recovery Plan

- There is a single argument of type UpdateRecoveryPlanInput.
- Returns UpdateRecoveryPlanReply.
### updaterecoveryschedule
- There is a single argument of type UpdateRecoveryScheduleInput.
- Returns System.String.
### updateroleassignments
- There are 3 arguments.
    - userIds - list of System.Strings: List of user IDs.
    - groupIds - list of System.Strings: List of group IDs.
    - roleIds - list of System.Strings
- Returns System.Boolean.
### updatesnapmirrorcloud
Update a SnapMirror Cloud

Supported in v7.0+
Updates a SnapMirror Cloud with the specified properties.

- There is a single argument of type UpdateSnapMirrorCloudInput.
- Returns UpdateSnapMirrorCloudReply.
### updatesupportcase
Update a support case.

- There is a single argument of type UpdateSupportCaseInput.
- Returns UpdateSupportCaseReply.
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
### updatevcdinstances
Update vCD instances in Rubrik clusters.

- There is a single argument of type UpdateVcdInstancesInput.
- Returns UpdateVcdInstancesReply.
### updatevcdvapp
Update a VCD vApp in a Rubrik cluster.

- There is a single argument of type UpdateVcdVappInput.
- Returns System.String.
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
### validateblueprint
Validate the resource mapping, RBA status, cluster version of the given blueprint.

- There is a single argument of type ValidateBlueprintInput.
- Returns ValidateBlueprintReply.
### validateblueprintrecoveryspec
Validate the recovery specs with the given app blueprint snappable or snapshot fid.

- There are 2 arguments.
    - blueprintId - System.String: The Blueprint ID.
    - validateSnapshotRecoverySpec - System.Boolean: Flag to represent if it should validate snapshot recovery spec
- Returns ValidateBlueprintRecoverySpecReply.
### validateblueprints
Validate the resource mapping, RBA status, cluster version of all the given blueprints.

- There is a single argument of type ValidateBlueprintsInput.
- Returns ValidateBlueprintsReply.
### validatecompleteoperationalrecoveryfeasibility
Validate if can trigger complete operational recovery.

- There is a single argument of type ValidateCompleteOperationalRecoveryFeasibilityInput.
- Returns ValidateCompleteOperationalRecoveryFeasibilityReply.
### validateticketingplatformconfig
Validate platform configuration.

- There is a single argument of type ValidateTicketingPlatformConfigInput.
- Returns ValidateTicketingPlatformConfigReply.
### vmmakeprimary
Make this cluster the primary for agents on a set of VMs

Supported in v5.3+
Migrate the primary cluster with which the agent is able to communicate. For disaster recovery when migrating everything over from another cluster, the /host/make_primary endpoint can be used with the oldPrimaryClusterUuid parameter.

- There is a single argument of type VmMakePrimaryInput.
- Returns AsyncRequestStatus.
### vpsherevmrecoverypointmount
- There are 14 arguments.
    - snapshotFid - System.String
    - snappableFid - System.String
    - vmName - System.String
    - disableNetwork - System.Boolean
    - removeNetworkDevices - System.Boolean
    - powerOn - System.Boolean
    - keepMacAddresses - System.Boolean
    - hostID - System.String
    - datastoreName - System.String
    - vlan - System.Int32
    - unregsiterVm - System.Boolean
    - shouldRecoverTags - System.Boolean
    - recoveryPoint - System.String
    - createDatastoreOnly - System.Boolean
- Returns VsphereAsyncRequestStatus.
### warmsearchcache
Warms the search cache for an O365 workload.

- There is a single argument of type WarmSearchCacheInput.
- Returns System.Boolean.
