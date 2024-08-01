// New-RscMutationMisc.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections;
using System.Collections.Generic;
using System.Management.Automation;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using GraphQL;
using RubrikSecurityCloud;
using RubrikSecurityCloud.Types;
using RubrikSecurityCloud.NetSDK.Client;
using RubrikSecurityCloud.PowerShell.Private;

// ignore warning 'Missing XML comment'
#pragma warning disable 1591

namespace RubrikSecurityCloud.PowerShell.Cmdlets
{
    /// <summary>
    /// Create a new RscQuery object for any of the 287
    /// operations in the 'Miscellaneous' API domain:
    /// AcknowledgeFedrampBoundaryExit, ActivateTrialAsync, AddAdGroupsToHierarchy, AddConfiguredGroupToHierarchy, AddCustomIntelFeed, AddInventoryWorkloads, AddRoleAssignments, AddSaasAppRecoveryOrg, AddVcdInstances, AddVlan, AddVmAppConsistentSpecs, AirGapStatus, ApproveTprRequest, ArchiveCrawl, AssignProtection, BatchDeassignRoleFromUserGroups, BatchRefreshDomains, BulkAddKmipServer, BulkCancelFailovers, BulkCreateNasFilesets, BulkUpdateSnapMirrorCloud, CancelBlueprintFailover, CancelBulkRecovery, CancelDownloadPackage, CancelJobInstance, CancelScheduledUpgrade, CancelTaskchain, CancelTprRequest, ChangePassword, CheckStatus, CleanupBlueprintFailover, CleanupIsolatedRecoveries, CleanupIsolatedRecovery, CompleteOperationalRecovery, CompleteSaasAppAuthConsent, CompleteTrialOnboarding, CompleteTrialTask, ComputeBucketImmutabilityLockDuration, ConfigureDns, ConfigureLogExport, ConfigureNtp, ConfigureTicketingPlatformWithOAuth, CreateBlueprint, CreateBlueprintRecoverySpec, CreateChat, CreateChatbot, CreateConfigProtectionBackup, CreateConfigProtectionSetup, CreateCustomAnalyzer, CreateEventDigestBatch, CreateGuestCredential, CreateLegalHold, CreateOnDemandVolumeGroupBackup, CreateOrgNetwork, CreatePasskey, CreateRbacMigrationSummaryDownload, CreateRecoveryPlan, CreateRecoverySchedule, CreateS3Bucket, CreateSnapMirrorCloud, CreateSnapMirrorCloudRelationship, CreateSnapMirrorCloudRestoreJob, CreateSsoUsers, CreateSupportCase, CreateUserAccessInsightTicket, CreateVappExport, CreateVappsInstantRecovery, DeactivateCustomAnalyzer, DeleteAccountSettingValue, DeleteAdGroupsFromHierarchy, DeleteBlueprint, DeleteBlueprints, DeleteBrandLogo, DeleteChatbot, DeleteDistributionListDigestBatch, DeleteEnvoyNgs, DeleteEventDigest, DeleteGuestCredentialById, DeleteIdentityProvider, DeleteIntelFeed, DeleteKmipServer, DeleteKmsInstance, DeleteOrgNetwork, DeletePasskey, DeleteRecoveryPlan, DeleteRecoveryPlans, DeleteRecoverySchedule, DeleteRecoverySpec, DeleteSmtpConfiguration, DeleteSnapMirrorCloud, DeleteSnapMirrorCloudRelationship, DeleteVcdInstances, DeleteVolumeGroupMount, DenyTprRequests, DeregisterPrivateContainerRegistry, DisableSupportUserAccess, DisableTprOrg, DisconnectTicketingPlatform, DissolveLegalHold, EditPasskey, EditSalesforceOrganization, EnableAutomaticFmdUpload, EnableDisableAppConsistency, EnableLambdaForWorkload, EnableMigrationWorkflow, EnableSupportUserAccess, EnableTprOrg, ExcludeVmDisks, ExecuteTprRequests, ExpireSnoozedDirectories, ExportPrincipalsSummary, ExportUnAccessedUsersSummary, ExtendRscAutoUpgradeDate, ExtendTrialAsync, GenerateConfigProtectionRestoreForm, GenerateSupportBundle, GetDownloadUrl, HideRevealNasNamespaces, IgnoreTrial, InstallIoFilter, InviteSsoGroup, InviteUsersToTrial, ListCidrsForComputeSetting, LockIsolatedRecovery, LockUsersByAdmin, LogoutFromRubrikSupportPortal, MakePrimary, MarkNotificationsAsRead, ModifyEventDigestBatch, ModifyIpmi, MountDisk, NotificationForGetLicense, PromoteRecovery, RecoverCloudDirectMultiPaths, RecoverCloudDirectPath, RefreshDomain, RefreshGlobalManagerConnectivityStatus, RefreshOrgNetwork, RefreshVcdInstances, RegisterAndEnableMigrationChoice, RemoveDisk, RemoveInventoryWorkloads, RemoveNodeForReplacement, RemovePrivateEndpointList, RemoveProxyConfig, RemoveVlans, ReseedLogShippingSecondary, ResetAllOrgUsersPasswords, ResetMigrationOnModeChange, ResetPasskeys, ResetUsersPasswordsWithUserIds, ResizeDisk, ResolveAnomaly, ResolveVolumeGroupsConflict, RestoreConfigProtectionBackup, RetryBackup, RetryDownloadPackageJob, RevokeAllOrgRoles, RunCustomAnalyzer, RunPrechecks, ScheduleUpgradeBatchJob, SendEmailNow, SendPactsafeEvent, SendTestSmtpEmail, SetAccountSettingValue, SetAnalyzerRisks, SetBrandLogo, SetBundleApprovalStatus, SetCorsSetting, SetCustomerTags, SetDatastoreFreespaceThresholds, SetFederatedLoginStatus, SetIdentityProvider, SetIpWhitelistEnabled, SetKmipClient, SetLiveMountIps, SetMfaSetting, SetMigrationStatus, SetPasskeyConfig, SetPrivateContainerRegistry, SetSmtpConfiguration, SetTotpConfig, SetUpgradeType, SetUserLevelTotpEnforcement, SetUserSessionManagementConfig, SetUserSetting, SetWorkloadAlertSetting, SetWwwTlsCert, SetupAtlassianSite, SetupDisk, SetupSalesforceOrganization, SnoozeEula, StartBlueprintFailover, StartBlueprintsFailover, StartBulkRecovery, StartCrawl, StartCyberRecovery, StartDownloadPackageBatchJob, StartExportRdsInstanceJob, StartFetchCdmRbacConfigJob, StartMalwareDetection, StartMigrateCdmRbacConfigJob, StartMultipleBulkRecoveries, StartNasAutomigrationJob, StartPeriodicUpgradePrechecksOnDemandJob, StartSaasAppAuthConsent, StartSaasAppsDeleteOrg, StartUpgradeBatchJob, StartVolumeGroupMount, StopJobInstance, StopJobInstanceFromEventSeries, SubmitTprRequest, SupportPortalLogin, SwitchProductToOnboardingMode, ToggleFeatureEnabled, TriggerCloudComputeConnectivityCheck, TriggerExocomputeHealthCheck, UninstallIoFilter, UnlockUsersByAdmin, UnmountDisk, UpdateAccountOwner, UpdateAccountSettings, UpdateAdGroup, UpdateAgentDeploymentSetting, UpdateAgentDeploymentSettingInBatch, UpdateAuthDomainUsersHiddenStatus, UpdateBackupThrottleSetting, UpdateBadDiskLedStatus, UpdateBlueprint, UpdateChat, UpdateChatbot, UpdateClassificationBannerEnabled, UpdateClassificationBannerSettings, UpdateClassificationLoginEnabled, UpdateClassificationLoginSettings, UpdateConfigProtectionSetup, UpdateConfiguredGroup, UpdateCustomAnalyzer, UpdateCustomIntelFeed, UpdateCustomerAppPermissions, UpdateCyberEventLockdown, UpdateDistributionListDigest, UpdateDnsServersAndSearchDomains, UpdateEulaAccepted, UpdateEventDigest, UpdateFloatingIps, UpdateGuestCredential, UpdateIdentityProvider, UpdateInsightState, UpdateIocStatus, UpdateIpWhitelist, UpdateKmipServer, UpdateLambdaSettings, UpdateLlmEnabled, UpdateLockoutConfig, UpdateManagedIdentities, UpdateNetworkThrottle, UpdateOrgNetwork, UpdatePactsafeEulaAccepted, UpdatePactsafeEulaSeen, UpdateProxyConfig, UpdateReaderLocationMasterKeyWithOwnerLocationKey, UpdateReaderLocationMasterKeyWithRsaKey, UpdateRecoveryPlan, UpdateRecoverySchedule, UpdateRoleAssignments, UpdateSnapMirrorCloud, UpdateSupportCase, UpdateSupportUserAccess, UpdateTprConfiguration, UpdateTunnelStatus, UpdateVcdInstances, UpdateVcdVapp, UpdateVlan, UpdateVolumeGroup, UpdateWhitelistedAnalyzers, UpgradeIoFilter, UpgradeToRsc, ValidateAndSaveCustomerKmsInfo, ValidateBlueprint, ValidateBlueprintRecoverySpec, ValidateBlueprints, ValidateCompleteOperationalRecoveryFeasibility, ValidateTicketingPlatformConfig, VmMakePrimary, VpshereVMRecoveryPointMount, or WarmSearchCache.
    /// </summary>
    /// <description>
    /// New-RscMutationMisc creates a new
    /// mutation object for operations
    /// in the 'Miscellaneous' API domain. It only creates a data structure,
    /// it does not execute the operation. This cmdlet does not need a
    /// connection to run. To execute the operation, either call Invoke()
    /// on the object returned by this cmdlet, or pass the object to
    /// Invoke-Rsc.
    /// There are 287 operations
    /// in the 'Miscellaneous' API domain. Select the operation this
    /// query is for by specifying the appropriate value for the
    /// -Operation parameter;
    /// one of: AcknowledgeFedrampBoundaryExit, ActivateTrialAsync, AddAdGroupsToHierarchy, AddConfiguredGroupToHierarchy, AddCustomIntelFeed, AddInventoryWorkloads, AddRoleAssignments, AddSaasAppRecoveryOrg, AddVcdInstances, AddVlan, AddVmAppConsistentSpecs, AirGapStatus, ApproveTprRequest, ArchiveCrawl, AssignProtection, BatchDeassignRoleFromUserGroups, BatchRefreshDomains, BulkAddKmipServer, BulkCancelFailovers, BulkCreateNasFilesets, BulkUpdateSnapMirrorCloud, CancelBlueprintFailover, CancelBulkRecovery, CancelDownloadPackage, CancelJobInstance, CancelScheduledUpgrade, CancelTaskchain, CancelTprRequest, ChangePassword, CheckStatus, CleanupBlueprintFailover, CleanupIsolatedRecoveries, CleanupIsolatedRecovery, CompleteOperationalRecovery, CompleteSaasAppAuthConsent, CompleteTrialOnboarding, CompleteTrialTask, ComputeBucketImmutabilityLockDuration, ConfigureDns, ConfigureLogExport, ConfigureNtp, ConfigureTicketingPlatformWithOAuth, CreateBlueprint, CreateBlueprintRecoverySpec, CreateChat, CreateChatbot, CreateConfigProtectionBackup, CreateConfigProtectionSetup, CreateCustomAnalyzer, CreateEventDigestBatch, CreateGuestCredential, CreateLegalHold, CreateOnDemandVolumeGroupBackup, CreateOrgNetwork, CreatePasskey, CreateRbacMigrationSummaryDownload, CreateRecoveryPlan, CreateRecoverySchedule, CreateS3Bucket, CreateSnapMirrorCloud, CreateSnapMirrorCloudRelationship, CreateSnapMirrorCloudRestoreJob, CreateSsoUsers, CreateSupportCase, CreateUserAccessInsightTicket, CreateVappExport, CreateVappsInstantRecovery, DeactivateCustomAnalyzer, DeleteAccountSettingValue, DeleteAdGroupsFromHierarchy, DeleteBlueprint, DeleteBlueprints, DeleteBrandLogo, DeleteChatbot, DeleteDistributionListDigestBatch, DeleteEnvoyNgs, DeleteEventDigest, DeleteGuestCredentialById, DeleteIdentityProvider, DeleteIntelFeed, DeleteKmipServer, DeleteKmsInstance, DeleteOrgNetwork, DeletePasskey, DeleteRecoveryPlan, DeleteRecoveryPlans, DeleteRecoverySchedule, DeleteRecoverySpec, DeleteSmtpConfiguration, DeleteSnapMirrorCloud, DeleteSnapMirrorCloudRelationship, DeleteVcdInstances, DeleteVolumeGroupMount, DenyTprRequests, DeregisterPrivateContainerRegistry, DisableSupportUserAccess, DisableTprOrg, DisconnectTicketingPlatform, DissolveLegalHold, EditPasskey, EditSalesforceOrganization, EnableAutomaticFmdUpload, EnableDisableAppConsistency, EnableLambdaForWorkload, EnableMigrationWorkflow, EnableSupportUserAccess, EnableTprOrg, ExcludeVmDisks, ExecuteTprRequests, ExpireSnoozedDirectories, ExportPrincipalsSummary, ExportUnAccessedUsersSummary, ExtendRscAutoUpgradeDate, ExtendTrialAsync, GenerateConfigProtectionRestoreForm, GenerateSupportBundle, GetDownloadUrl, HideRevealNasNamespaces, IgnoreTrial, InstallIoFilter, InviteSsoGroup, InviteUsersToTrial, ListCidrsForComputeSetting, LockIsolatedRecovery, LockUsersByAdmin, LogoutFromRubrikSupportPortal, MakePrimary, MarkNotificationsAsRead, ModifyEventDigestBatch, ModifyIpmi, MountDisk, NotificationForGetLicense, PromoteRecovery, RecoverCloudDirectMultiPaths, RecoverCloudDirectPath, RefreshDomain, RefreshGlobalManagerConnectivityStatus, RefreshOrgNetwork, RefreshVcdInstances, RegisterAndEnableMigrationChoice, RemoveDisk, RemoveInventoryWorkloads, RemoveNodeForReplacement, RemovePrivateEndpointList, RemoveProxyConfig, RemoveVlans, ReseedLogShippingSecondary, ResetAllOrgUsersPasswords, ResetMigrationOnModeChange, ResetPasskeys, ResetUsersPasswordsWithUserIds, ResizeDisk, ResolveAnomaly, ResolveVolumeGroupsConflict, RestoreConfigProtectionBackup, RetryBackup, RetryDownloadPackageJob, RevokeAllOrgRoles, RunCustomAnalyzer, RunPrechecks, ScheduleUpgradeBatchJob, SendEmailNow, SendPactsafeEvent, SendTestSmtpEmail, SetAccountSettingValue, SetAnalyzerRisks, SetBrandLogo, SetBundleApprovalStatus, SetCorsSetting, SetCustomerTags, SetDatastoreFreespaceThresholds, SetFederatedLoginStatus, SetIdentityProvider, SetIpWhitelistEnabled, SetKmipClient, SetLiveMountIps, SetMfaSetting, SetMigrationStatus, SetPasskeyConfig, SetPrivateContainerRegistry, SetSmtpConfiguration, SetTotpConfig, SetUpgradeType, SetUserLevelTotpEnforcement, SetUserSessionManagementConfig, SetUserSetting, SetWorkloadAlertSetting, SetWwwTlsCert, SetupAtlassianSite, SetupDisk, SetupSalesforceOrganization, SnoozeEula, StartBlueprintFailover, StartBlueprintsFailover, StartBulkRecovery, StartCrawl, StartCyberRecovery, StartDownloadPackageBatchJob, StartExportRdsInstanceJob, StartFetchCdmRbacConfigJob, StartMalwareDetection, StartMigrateCdmRbacConfigJob, StartMultipleBulkRecoveries, StartNasAutomigrationJob, StartPeriodicUpgradePrechecksOnDemandJob, StartSaasAppAuthConsent, StartSaasAppsDeleteOrg, StartUpgradeBatchJob, StartVolumeGroupMount, StopJobInstance, StopJobInstanceFromEventSeries, SubmitTprRequest, SupportPortalLogin, SwitchProductToOnboardingMode, ToggleFeatureEnabled, TriggerCloudComputeConnectivityCheck, TriggerExocomputeHealthCheck, UninstallIoFilter, UnlockUsersByAdmin, UnmountDisk, UpdateAccountOwner, UpdateAccountSettings, UpdateAdGroup, UpdateAgentDeploymentSetting, UpdateAgentDeploymentSettingInBatch, UpdateAuthDomainUsersHiddenStatus, UpdateBackupThrottleSetting, UpdateBadDiskLedStatus, UpdateBlueprint, UpdateChat, UpdateChatbot, UpdateClassificationBannerEnabled, UpdateClassificationBannerSettings, UpdateClassificationLoginEnabled, UpdateClassificationLoginSettings, UpdateConfigProtectionSetup, UpdateConfiguredGroup, UpdateCustomAnalyzer, UpdateCustomIntelFeed, UpdateCustomerAppPermissions, UpdateCyberEventLockdown, UpdateDistributionListDigest, UpdateDnsServersAndSearchDomains, UpdateEulaAccepted, UpdateEventDigest, UpdateFloatingIps, UpdateGuestCredential, UpdateIdentityProvider, UpdateInsightState, UpdateIocStatus, UpdateIpWhitelist, UpdateKmipServer, UpdateLambdaSettings, UpdateLlmEnabled, UpdateLockoutConfig, UpdateManagedIdentities, UpdateNetworkThrottle, UpdateOrgNetwork, UpdatePactsafeEulaAccepted, UpdatePactsafeEulaSeen, UpdateProxyConfig, UpdateReaderLocationMasterKeyWithOwnerLocationKey, UpdateReaderLocationMasterKeyWithRsaKey, UpdateRecoveryPlan, UpdateRecoverySchedule, UpdateRoleAssignments, UpdateSnapMirrorCloud, UpdateSupportCase, UpdateSupportUserAccess, UpdateTprConfiguration, UpdateTunnelStatus, UpdateVcdInstances, UpdateVcdVapp, UpdateVlan, UpdateVolumeGroup, UpdateWhitelistedAnalyzers, UpgradeIoFilter, UpgradeToRsc, ValidateAndSaveCustomerKmsInfo, ValidateBlueprint, ValidateBlueprintRecoverySpec, ValidateBlueprints, ValidateCompleteOperationalRecoveryFeasibility, ValidateTicketingPlatformConfig, VmMakePrimary, VpshereVMRecoveryPointMount, or WarmSearchCache.
    /// Each operation has its own set of variables that can be set with
    /// the -Var parameter. For more info about the variables, 
    /// call Info() on the object returned by this cmdlet, for example:
    /// (New-RscMutationMisc -AcknowledgeFedrampBoundaryExit).Info().
    /// Each operation also has its own set of fields that can be
    /// selected for retrieval. If you do not specify any fields,
    /// a set of default fields will be selected. The selection is
    /// rule-based, and tries to select the most commonly used fields.
    /// For example if a field is named 'id' or 'name', 
    /// it will be selected. If you give -FieldProfile DETAIL, then
    /// another set of rules will be used to select more fields on top
    /// of the default fields. The set of rules for selecting fields
    /// is called a field profile. You can specify a field profile
    /// with the -FieldProfile parameter. You can add or remove fields
    /// from the field profile with the -AddField and -RemoveField
    /// parameters. If you end up with too many -AddField and -RemoveField
    /// parameters, you can list them in a text file, one per line,
    /// with a '+' or '-' prefix, and pass the file name to the
    /// -FilePatch parameter. Profiles and Patches are one way to
    /// customize the fields that are selected. Another way is to
    /// specify the fields by passing the -Field parameter an object
    /// that contains the fields you want to select as properties.
    /// Any property that is not null in that object is interpreted
    /// as a field to select
    /// (and the actual values they are set to do not matter).
    /// The [RubrikSecurityCloud.Types] namespace
    /// contains a set of classes that you can use to specify fields.
    /// To know what [RubrikSecurityCloud.Types] object to use
    /// for a specific operation,
    /// call Info() on the object returned by this cmdlet, for example:
    /// (New-RscMutationMisc -AcknowledgeFedrampBoundaryExit).Info().
    /// You can combine a -Field parameter with patching parameters.
    /// -Field is applied first, then -FilePatch, -AddField and -RemoveField.
    ///
    /// </description>
    ///
    /// <example>
    /// Runs the AcknowledgeFedrampBoundaryExit operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: AcknowledgeFedrampBoundaryExit
    /// 
    /// $query = New-RscMutationMisc -AcknowledgeFedrampBoundaryExit
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	url = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: System.String
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the ActivateTrialAsync operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: ActivateTrialAsync
    /// 
    /// $query = New-RscMutationMisc -ActivateTrialAsync
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	trialId = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: ActivateTrialAsyncReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the AddAdGroupsToHierarchy operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: AddAdGroupsToHierarchy
    /// 
    /// $query = New-RscMutationMisc -AddAdGroupsToHierarchy
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	orgId = $someString
    /// 	# REQUIRED
    /// 	naturalIds = @(
    /// 		$someString
    /// 	)
    /// 	# OPTIONAL
    /// 	adGroupSpec = @(
    /// 		@{
    /// 			# REQUIRED
    /// 			naturalId = $someString
    /// 			# OPTIONAL
    /// 			displayName = $someString
    /// 			# REQUIRED
    /// 			filterAttributes = @(
    /// 				@{
    /// 					# OPTIONAL
    /// 					filterOpType = $someJoinOpType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.JoinOpType]) for enum values.
    /// 					# OPTIONAL
    /// 					attributeType = $someAttributeType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AttributeType]) for enum values.
    /// 					# OPTIONAL
    /// 					attributeKey = $someString
    /// 					# OPTIONAL
    /// 					attributeValue = $someString
    /// 					# OPTIONAL
    /// 					dataType = $someAttributeDataType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AttributeDataType]) for enum values.
    /// 				}
    /// 			)
    /// 		}
    /// 	)
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: RequestStatus
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the AddConfiguredGroupToHierarchy operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: AddConfiguredGroupToHierarchy
    /// 
    /// $query = New-RscMutationMisc -AddConfiguredGroupToHierarchy
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	orgId = $someString
    /// 	# REQUIRED
    /// 	displayName = $someString
    /// 	# OPTIONAL
    /// 	wildcard = $someString
    /// 	# REQUIRED
    /// 	pdls = @(
    /// 		$someString
    /// 	)
    /// 	# OPTIONAL
    /// 	workload = $someWorkloadLevelHierarchy # Call [Enum]::GetValues([RubrikSecurityCloud.Types.WorkloadLevelHierarchy]) for enum values.
    /// 	# OPTIONAL
    /// 	groupFilterAttributes = @(
    /// 		@{
    /// 			# OPTIONAL
    /// 			filterOpType = $someJoinOpType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.JoinOpType]) for enum values.
    /// 			# OPTIONAL
    /// 			attributeType = $someAttributeType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AttributeType]) for enum values.
    /// 			# OPTIONAL
    /// 			attributeKey = $someString
    /// 			# OPTIONAL
    /// 			attributeValue = $someString
    /// 			# OPTIONAL
    /// 			dataType = $someAttributeDataType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AttributeDataType]) for enum values.
    /// 		}
    /// 	)
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AddConfiguredGroupToHierarchyReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the AddCustomIntelFeed operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: AddCustomIntelFeed
    /// 
    /// $query = New-RscMutationMisc -AddCustomIntelFeed
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	name = $someString
    /// 	# OPTIONAL
    /// 	description = $someString
    /// 	# OPTIONAL
    /// 	userId = $someString
    /// 	# REQUIRED
    /// 	entries = @(
    /// 		@{
    /// 			# OPTIONAL
    /// 			iocString = $someString
    /// 			# OPTIONAL
    /// 			threatFamily = $someString
    /// 			# REQUIRED
    /// 			iocType = $someThreatFeedType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ThreatFeedType]) for enum values.
    /// 		}
    /// 	)
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AddCustomIntelFeedReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the AddInventoryWorkloads operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: AddInventoryWorkloads
    /// 
    /// $query = New-RscMutationMisc -AddInventoryWorkloads
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	inventoryCards = @(
    /// 		$someInventoryCard # Call [Enum]::GetValues([RubrikSecurityCloud.Types.InventoryCard]) for enum values.
    /// 	)
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: System.Boolean
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the AddRoleAssignments operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: AddRoleAssignments
    /// 
    /// $query = New-RscMutationMisc -AddRoleAssignments
    /// 
    /// # OPTIONAL
    /// $query.Var.userIds = @(
    /// 	$someString
    /// )
    /// # OPTIONAL
    /// $query.Var.groupIds = @(
    /// 	$someString
    /// )
    /// # REQUIRED
    /// $query.Var.roleIds = @(
    /// 	$someString
    /// )
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: System.Boolean
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the AddSaasAppRecoveryOrg operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: AddSaasAppRecoveryOrg
    /// 
    /// $query = New-RscMutationMisc -AddSaasAppRecoveryOrg
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	orgName = $someString
    /// 	# REQUIRED
    /// 	orgNaturalId = $someString
    /// 	# REQUIRED
    /// 	environmentType = $someSaasEnvironmentType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SaasEnvironmentType]) for enum values.
    /// 	# REQUIRED
    /// 	saasAppType = $someSaasAppType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SaasAppType]) for enum values.
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AddRecoveryOrgReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the AddVcdInstances operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: AddVcdInstances
    /// 
    /// $query = New-RscMutationMisc -AddVcdInstances
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	vcdConfigs = @(
    /// 		@{
    /// 			# REQUIRED
    /// 			clusterUuid = $someString
    /// 			# REQUIRED
    /// 			definition = @{
    /// 				# REQUIRED
    /// 				password = $someString
    /// 				# OPTIONAL
    /// 				vcdClusterBaseConfig = @{
    /// 					# OPTIONAL
    /// 					caCerts = $someString
    /// 					# REQUIRED
    /// 					hostname = $someString
    /// 					# REQUIRED
    /// 					username = $someString
    /// 				}
    /// 			}
    /// 		}
    /// 	)
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AddVcdInstancesReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the AddVlan operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: AddVlan
    /// 
    /// $query = New-RscMutationMisc -AddVlan
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	id = $someString
    /// 	# REQUIRED
    /// 	vlanInfo = @{
    /// 		# OPTIONAL
    /// 		gateway = $someString
    /// 		# OPTIONAL
    /// 		alias = $someString
    /// 		# REQUIRED
    /// 		interfaces = @(
    /// 			@{
    /// 				# REQUIRED
    /// 				ip = $someString
    /// 				# REQUIRED
    /// 				node = $someString
    /// 			}
    /// 		)
    /// 		# REQUIRED
    /// 		netmask = $someString
    /// 		# REQUIRED
    /// 		vlan = $someInt
    /// 	}
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: ResponseSuccess
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the AddVmAppConsistentSpecs operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: AddVmAppConsistentSpecs
    /// 
    /// $query = New-RscMutationMisc -AddVmAppConsistentSpecs
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	snappableIds = @(
    /// 		$someString
    /// 	)
    /// 	# OPTIONAL
    /// 	preSnapshotScriptPath = $someString
    /// 	# OPTIONAL
    /// 	preSnapshotScriptTimeoutInSeconds = $someInt
    /// 	# OPTIONAL
    /// 	postSnapshotScriptPath = $someString
    /// 	# OPTIONAL
    /// 	postSnapshotScriptTimeoutInSeconds = $someInt
    /// 	# REQUIRED
    /// 	cancelBackupIfPreScriptFails = $someBoolean
    /// 	# REQUIRED
    /// 	objectType = $someCloudNativeVmAppConsistentObjectType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudNativeVmAppConsistentObjectType]) for enum values.
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AddVmAppConsistentSpecsReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the AirGapStatus operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: AirGapStatus
    /// 
    /// $query = New-RscMutationMisc -AirGapStatus
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	isAirGapped = $someBoolean
    /// 	# REQUIRED
    /// 	clusterUuid = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: System.String
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the ApproveTprRequest operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: ApproveTprRequest
    /// 
    /// $query = New-RscMutationMisc -ApproveTprRequest
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	requestId = $someString
    /// 	# OPTIONAL
    /// 	comment = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: System.String
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the ArchiveCrawl operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: ArchiveCrawl
    /// 
    /// $query = New-RscMutationMisc -ArchiveCrawl
    /// 
    /// # REQUIRED
    /// $query.Var.crawlId = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: System.String
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the AssignProtection operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: AssignProtection
    /// 
    /// $query = New-RscMutationMisc -AssignProtection
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	globalSlaOptionalFid = $someString
    /// 	# REQUIRED
    /// 	globalSlaAssignType = $someSlaAssignTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SlaAssignTypeEnum]) for enum values.
    /// 	# REQUIRED
    /// 	objectIds = @(
    /// 		$someString
    /// 	)
    /// 	# REQUIRED
    /// 	backupInput = @{
    /// 		# OPTIONAL
    /// 		mosaicBackupStoreInfo = @{
    /// 			# OPTIONAL
    /// 			storeName = $someString
    /// 		}
    /// 		# OPTIONAL
    /// 		mosaicMonitorInfo = @{
    /// 			# OPTIONAL
    /// 			isEnabled = $someBoolean
    /// 			# OPTIONAL
    /// 			frequency = $someInt
    /// 			# OPTIONAL
    /// 			frequencyUnit = $someRetentionUnit # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
    /// 		}
    /// 		# OPTIONAL
    /// 		shouldBackupIndex = $someBoolean
    /// 		# OPTIONAL
    /// 		shouldDelete = $someBoolean
    /// 		# OPTIONAL
    /// 		shouldDeleteData = $someBoolean
    /// 	}
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: SlaAssignResult
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the BatchDeassignRoleFromUserGroups operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: BatchDeassignRoleFromUserGroups
    /// 
    /// $query = New-RscMutationMisc -BatchDeassignRoleFromUserGroups
    /// 
    /// # REQUIRED
    /// $query.Var.userGroupToRoles = @(
    /// 	@{
    /// 		# OPTIONAL
    /// 		userGroupId = $someString
    /// 		# OPTIONAL
    /// 		roleIds = @(
    /// 			$someString
    /// 		)
    /// }
    /// )
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: System.Boolean
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the BatchRefreshDomains operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: BatchRefreshDomains
    /// 
    /// $query = New-RscMutationMisc -BatchRefreshDomains
    /// 
    /// # REQUIRED
    /// $query.Var.domainFids = @(
    /// 	$someString
    /// )
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: BatchAsyncRequestStatus
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the BulkAddKmipServer operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: BulkAddKmipServer
    /// 
    /// $query = New-RscMutationMisc -BulkAddKmipServer
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	clusterIds = @(
    /// 		$someString
    /// 	)
    /// 	# REQUIRED
    /// 	serverAddress = $someString
    /// 	# REQUIRED
    /// 	port = $someInt
    /// 	# REQUIRED
    /// 	polarisCertId = $someInt
    /// 	# OPTIONAL
    /// 	polarisCertFid = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: BulkAddKmipServerReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the BulkCancelFailovers operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: BulkCancelFailovers
    /// 
    /// $query = New-RscMutationMisc -BulkCancelFailovers
    /// 
    /// # REQUIRED
    /// $query.Var.cancelFailoversConfig = @{
    /// 	# REQUIRED
    /// 	fids = @(
    /// 		$someString
    /// 	)
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: System.String
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the BulkCreateNasFilesets operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: BulkCreateNasFilesets
    /// 
    /// $query = New-RscMutationMisc -BulkCreateNasFilesets
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	bulkRequest = @{
    /// 		# OPTIONAL
    /// 		isHardlinkSupportEnabled = $someBoolean
    /// 		# OPTIONAL
    /// 		isPassthrough = $someBoolean
    /// 		# REQUIRED
    /// 		filesetTemplate = @{
    /// 			# OPTIONAL
    /// 			backupScriptErrorHandling = $someString
    /// 			# OPTIONAL
    /// 			backupScriptTimeout = $someInt64
    /// 			# OPTIONAL
    /// 			exceptions = @(
    /// 				$someString
    /// 			)
    /// 			# OPTIONAL
    /// 			excludes = @(
    /// 				$someString
    /// 			)
    /// 			# OPTIONAL
    /// 			isArrayEnabled = $someBoolean
    /// 			# OPTIONAL
    /// 			postBackupScript = $someString
    /// 			# OPTIONAL
    /// 			preBackupScript = $someString
    /// 			# OPTIONAL
    /// 			isCreatedByKupr = $someBoolean
    /// 			# OPTIONAL
    /// 			isCreatedByPolarisNas = $someBoolean
    /// 			# OPTIONAL
    /// 			operatingSystemType = $someFilesetTemplateCreateOperatingSystemType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.FilesetTemplateCreateOperatingSystemType]) for enum values.
    /// 			# OPTIONAL
    /// 			shareType = $someFilesetTemplateCreateShareType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.FilesetTemplateCreateShareType]) for enum values.
    /// 			# OPTIONAL
    /// 			filesetOptions = @{
    /// 				# OPTIONAL
    /// 				allowBackupHiddenFoldersInNetworkMounts = $someBoolean
    /// 				# OPTIONAL
    /// 				allowBackupNetworkMounts = $someBoolean
    /// 				# OPTIONAL
    /// 				useWindowsVss = $someBoolean
    /// 			}
    /// 			# REQUIRED
    /// 			includes = @(
    /// 				$someString
    /// 			)
    /// 			# REQUIRED
    /// 			name = $someString
    /// 		}
    /// 		# REQUIRED
    /// 		nasShareIds = @(
    /// 			$someString
    /// 		)
    /// 	}
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: BulkCreateNasFilesetsReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the BulkUpdateSnapMirrorCloud operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: BulkUpdateSnapMirrorCloud
    /// 
    /// $query = New-RscMutationMisc -BulkUpdateSnapMirrorCloud
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	updateDefinitions = @(
    /// 		@{
    /// 			# REQUIRED
    /// 			snapMirrorCloudId = $someString
    /// 			# REQUIRED
    /// 			snapMirrorLabel = $someString
    /// 		}
    /// 	)
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: BulkUpdateSnapMirrorCloudReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CancelBlueprintFailover operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: CancelBlueprintFailover
    /// 
    /// $query = New-RscMutationMisc -CancelBlueprintFailover
    /// 
    /// # REQUIRED
    /// $query.Var.taskchainId = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: Result
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CancelBulkRecovery operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: CancelBulkRecovery
    /// 
    /// $query = New-RscMutationMisc -CancelBulkRecovery
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	bulkRecoveryInstanceId = $someString
    /// 	# OPTIONAL
    /// 	subscriptionId = $someString
    /// 	# OPTIONAL
    /// 	groupId = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: CancelBulkRecoveryReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CancelDownloadPackage operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: CancelDownloadPackage
    /// 
    /// $query = New-RscMutationMisc -CancelDownloadPackage
    /// 
    /// # REQUIRED
    /// $query.Var.clusterUuid = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: CancelJobReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CancelJobInstance operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: CancelJobInstance
    /// 
    /// $query = New-RscMutationMisc -CancelJobInstance
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	clusterUuid = $someString
    /// 	# REQUIRED
    /// 	id = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: InternalJobInstanceDetail
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CancelScheduledUpgrade operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: CancelScheduledUpgrade
    /// 
    /// $query = New-RscMutationMisc -CancelScheduledUpgrade
    /// 
    /// # REQUIRED
    /// $query.Var.clusterUuid = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: CancelJobReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CancelTaskchain operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: CancelTaskchain
    /// 
    /// $query = New-RscMutationMisc -CancelTaskchain
    /// 
    /// # REQUIRED
    /// $query.Var.taskchainId = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: RequestStatus
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CancelTprRequest operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: CancelTprRequest
    /// 
    /// $query = New-RscMutationMisc -CancelTprRequest
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	requestIds = @(
    /// 		$someString
    /// 	)
    /// 	# OPTIONAL
    /// 	comment = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: System.String
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the ChangePassword operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: ChangePassword
    /// 
    /// $query = New-RscMutationMisc -ChangePassword
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	email = $someString
    /// 	# OPTIONAL
    /// 	password = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: System.Boolean
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CheckStatus operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: CheckStatus
    /// 
    /// $query = New-RscMutationMisc -CheckStatus
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	clusterUuid = $someString
    /// 	# OPTIONAL
    /// 	shouldSwitchMode = $someBoolean
    /// 	# OPTIONAL
    /// 	shouldRunOnlyRSCModeTasks = $someBoolean
    /// 	# OPTIONAL
    /// 	clusterMigrationMode = $someClusterMigrationModes # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ClusterMigrationModes]) for enum values.
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: BatchAsyncJobStatus
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CleanupBlueprintFailover operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: CleanupBlueprintFailover
    /// 
    /// $query = New-RscMutationMisc -CleanupBlueprintFailover
    /// 
    /// # REQUIRED
    /// $query.Var.cleanupJobconfig = @{
    /// 	# REQUIRED
    /// 	blueprintId = $someString
    /// 	# OPTIONAL
    /// 	comments = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: CreateOnDemandJobReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CleanupIsolatedRecoveries operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: CleanupIsolatedRecoveries
    /// 
    /// $query = New-RscMutationMisc -CleanupIsolatedRecoveries
    /// 
    /// # REQUIRED
    /// $query.Var.cleanupIsolatedRecoveriesJobInputConfig = @(
    /// 	@{
    /// 		# REQUIRED
    /// 		blueprintId = $someString
    /// 		# REQUIRED
    /// 		failoverId = $someString
    /// 		# OPTIONAL
    /// 		comments = $someString
    /// }
    /// )
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: List&lt;CreateOnDemandJobReply&gt;
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CleanupIsolatedRecovery operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: CleanupIsolatedRecovery
    /// 
    /// $query = New-RscMutationMisc -CleanupIsolatedRecovery
    /// 
    /// # REQUIRED
    /// $query.Var.cleanupIsolatedRecoveryJobconfig = @{
    /// 	# REQUIRED
    /// 	blueprintId = $someString
    /// 	# REQUIRED
    /// 	failoverId = $someString
    /// 	# OPTIONAL
    /// 	comments = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: CreateOnDemandJobReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CompleteOperationalRecovery operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: CompleteOperationalRecovery
    /// 
    /// $query = New-RscMutationMisc -CompleteOperationalRecovery
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	bulkRecoveryInstanceId = $someString
    /// 	# OPTIONAL
    /// 	bulkRecoveryTaskchainId = $someString
    /// 	# REQUIRED
    /// 	subscriptionId = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: StartBulkRecoveryV2Reply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CompleteSaasAppAuthConsent operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: CompleteSaasAppAuthConsent
    /// 
    /// $query = New-RscMutationMisc -CompleteSaasAppAuthConsent
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	sessionId = $someString
    /// 	# REQUIRED
    /// 	state = $someString
    /// 	# REQUIRED
    /// 	authorizationCode = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: CompleteSaasAppAuthConsentReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CompleteTrialOnboarding operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: CompleteTrialOnboarding
    /// 
    /// $query = New-RscMutationMisc -CompleteTrialOnboarding
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	trialId = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: System.String
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CompleteTrialTask operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: CompleteTrialTask
    /// 
    /// $query = New-RscMutationMisc -CompleteTrialTask
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	trialId = $someString
    /// 	# REQUIRED
    /// 	step = $someTrialStep # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TrialStep]) for enum values.
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: System.String
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the ComputeBucketImmutabilityLockDuration operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: ComputeBucketImmutabilityLockDuration
    /// 
    /// $query = New-RscMutationMisc -ComputeBucketImmutabilityLockDuration
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	archivalRetentionDays = $someInt
    /// 	# REQUIRED
    /// 	slaFrequencyUnit = $someRetentionUnit # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: ComputeBucketImmutabilityLockDurationReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the ConfigureDns operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: ConfigureDns
    /// 
    /// $query = New-RscMutationMisc -ConfigureDns
    /// 
    /// # REQUIRED
    /// $query.Var.dnsAddresses = @(
    /// 	$someString
    /// )
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: System.Boolean
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the ConfigureLogExport operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: ConfigureLogExport
    /// 
    /// $query = New-RscMutationMisc -ConfigureLogExport
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	id = $someString
    /// 	# REQUIRED
    /// 	shouldEnableLogExport = $someBoolean
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AsyncRequestStatus
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the ConfigureNtp operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: ConfigureNtp
    /// 
    /// $query = New-RscMutationMisc -ConfigureNtp
    /// 
    /// # REQUIRED
    /// $query.Var.ntpAddresses = @(
    /// 	$someString
    /// )
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: System.Boolean
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the ConfigureTicketingPlatformWithOAuth operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: ConfigureTicketingPlatformWithOAuth
    /// 
    /// $query = New-RscMutationMisc -ConfigureTicketingPlatformWithOAuth
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	platformConfig = @{
    /// 		# REQUIRED
    /// 		platformType = $someTicketingPlatform # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TicketingPlatform]) for enum values.
    /// 		# REQUIRED
    /// 		instanceUrl = $someString
    /// 	}
    /// 	# REQUIRED
    /// 	oauthConfig = @{
    /// 		# REQUIRED
    /// 		username = $someString
    /// 		# REQUIRED
    /// 		password = $someString
    /// 		# REQUIRED
    /// 		clientId = $someString
    /// 		# REQUIRED
    /// 		clientSecret = $someString
    /// 	}
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: System.String
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CreateBlueprint operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: CreateBlueprint
    /// 
    /// $query = New-RscMutationMisc -CreateBlueprint
    /// 
    /// # REQUIRED
    /// $query.Var.name = $someString
    /// # REQUIRED
    /// $query.Var.children = @(
    /// 	@{
    /// 		# REQUIRED
    /// 		fid = $someString
    /// 		# REQUIRED
    /// 		snappableType = $someObjectTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ObjectTypeEnum]) for enum values.
    /// 		# REQUIRED
    /// 		bootPriority = $someInt
    /// 		# OPTIONAL
    /// 		lastRecoveryPoint = $someInt64
    /// }
    /// )
    /// # REQUIRED
    /// $query.Var.sourceLocationId = $someString
    /// # REQUIRED
    /// $query.Var.sourceLocationType = $someBlueprintLocationType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.BlueprintLocationType]) for enum values.
    /// # OPTIONAL
    /// $query.Var.targetLocationType = $someBlueprintLocationType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.BlueprintLocationType]) for enum values.
    /// # OPTIONAL
    /// $query.Var.targetLocationId = $someString
    /// # REQUIRED
    /// $query.Var.status = $someBlueprintStatus # Call [Enum]::GetValues([RubrikSecurityCloud.Types.BlueprintStatus]) for enum values.
    /// # OPTIONAL
    /// $query.Var.enableHydration = $someBoolean
    /// # OPTIONAL
    /// $query.Var.timeoutBetweenPriorityGroups = @(
    /// 	$someInt64
    /// )
    /// # OPTIONAL
    /// $query.Var.blueprintRecoveryType = $someBlueprintRecoveryType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.BlueprintRecoveryType]) for enum values.
    /// # REQUIRED
    /// $query.Var.isBlueprintVisible = $someBoolean
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: BlueprintNew
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CreateBlueprintRecoverySpec operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: CreateBlueprintRecoverySpec
    /// 
    /// $query = New-RscMutationMisc -CreateBlueprintRecoverySpec
    /// 
    /// # REQUIRED
    /// $query.Var.blueprintId = $someString
    /// # REQUIRED
    /// $query.Var.specType = $someRecoverySpecType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RecoverySpecType]) for enum values.
    /// # REQUIRED
    /// $query.Var.recoveryConfigs = @(
    /// 	@{
    /// 		# REQUIRED
    /// 		planType = $somePlanName # Call [Enum]::GetValues([RubrikSecurityCloud.Types.PlanName]) for enum values.
    /// 		# OPTIONAL
    /// 		locationInfo = @{
    /// 			# OPTIONAL
    /// 			locationId = $someString
    /// 			# OPTIONAL
    /// 			locationType = $someLocationType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.LocationType]) for enum values.
    /// 		}
    /// 		# OPTIONAL
    /// 		userData = $someString
    /// 		# REQUIRED
    /// 		childRecoverySpecs = @(
    /// 			@{
    /// 				# REQUIRED
    /// 				snappableId = $someString
    /// 				# OPTIONAL
    /// 				slaId = $someString
    /// 				# OPTIONAL
    /// 				recoveryPoint = $someInt64
    /// 				# REQUIRED
    /// 				recoverySpec = @{
    /// 					# OPTIONAL
    /// 					awsSpec = @{
    /// 						# REQUIRED
    /// 						instanceTypeId = $someInt
    /// 						# OPTIONAL
    /// 						instanceTypeName = $someString
    /// 						# OPTIONAL
    /// 						hostAffinity = $someString
    /// 						# OPTIONAL
    /// 						availabilityZone = $someString
    /// 						# OPTIONAL
    /// 						dedicatedHostId = $someString
    /// 						# OPTIONAL
    /// 						placementGroup = $someString
    /// 						# OPTIONAL
    /// 						tenancy = $someAwsInstanceTenancy # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsInstanceTenancy]) for enum values.
    /// 						# OPTIONAL
    /// 						keyName = $someString
    /// 						# OPTIONAL
    /// 						volumes = @(
    /// 							@{
    /// 								# OPTIONAL
    /// 								key = $someInt
    /// 								# OPTIONAL
    /// 								volumeTypeId = $someInt
    /// 								# OPTIONAL
    /// 								sizeGbs = $someInt
    /// 								# OPTIONAL
    /// 								iops = $someInt
    /// 							}
    /// 						)
    /// 						# OPTIONAL
    /// 						nics = @(
    /// 							@{
    /// 								# OPTIONAL
    /// 								key = $someInt
    /// 								# OPTIONAL
    /// 								ipv4Address = $someString
    /// 								# OPTIONAL
    /// 								subnetId = $someString
    /// 								# OPTIONAL
    /// 								awsSubnetId = $someString
    /// 								# OPTIONAL
    /// 								securityGroupId = $someString
    /// 								# OPTIONAL
    /// 								awsSecurityGroupId = $someString
    /// 							}
    /// 						)
    /// 						# OPTIONAL
    /// 						version = $someInt64
    /// 						# OPTIONAL
    /// 						userData = $someString
    /// 					}
    /// 					# OPTIONAL
    /// 					vSphereSpec = @{
    /// 						# OPTIONAL
    /// 						vcpus = $someInt
    /// 						# OPTIONAL
    /// 						memoryMbs = $someInt
    /// 						# OPTIONAL
    /// 						volumes = @(
    /// 							@{
    /// 								# OPTIONAL
    /// 								key = $someString
    /// 								# OPTIONAL
    /// 								dataStoreId = $someString
    /// 								# OPTIONAL
    /// 								sizeGbs = $someSingle
    /// 								# OPTIONAL
    /// 								dataStoreCdmId = $someString
    /// 								# OPTIONAL
    /// 								datastoreClusterId = $someString
    /// 								# OPTIONAL
    /// 								label = $someString
    /// 							}
    /// 						)
    /// 						# OPTIONAL
    /// 						nics = @(
    /// 							@{
    /// 								# OPTIONAL
    /// 								key = $someString
    /// 								# OPTIONAL
    /// 								isPrimaryNic = $someBoolean
    /// 								# OPTIONAL
    /// 								networkType = $someNetworkType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.NetworkType]) for enum values.
    /// 								# OPTIONAL
    /// 								networkId = $someString
    /// 								# OPTIONAL
    /// 								networkMoid = $someString
    /// 								# OPTIONAL
    /// 								adapterType = $someNetworkAdapterType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.NetworkAdapterType]) for enum values.
    /// 								# OPTIONAL
    /// 								ipv4Address = $someString
    /// 								# OPTIONAL
    /// 								ipv6Address = $someString
    /// 								# OPTIONAL
    /// 								dnsInfos = @(
    /// 									$someString
    /// 								)
    /// 								# OPTIONAL
    /// 								gateway = $someString
    /// 								# OPTIONAL
    /// 								netmask = $someString
    /// 							}
    /// 						)
    /// 						# OPTIONAL
    /// 						version = $someInt64
    /// 						# OPTIONAL
    /// 						userData = $someString
    /// 						# OPTIONAL
    /// 						target = @{
    /// 							# OPTIONAL
    /// 							vcenterId = $someString
    /// 							# OPTIONAL
    /// 							vcenterName = $someString
    /// 							# OPTIONAL
    /// 							vcenterCdmId = $someString
    /// 							# OPTIONAL
    /// 							computeClusterId = $someString
    /// 							# OPTIONAL
    /// 							computeClusterCdmId = $someString
    /// 							# OPTIONAL
    /// 							computeClusterName = $someString
    /// 							# OPTIONAL
    /// 							resourcePoolId = $someString
    /// 							# OPTIONAL
    /// 							resourcePoolCdmId = $someString
    /// 							# OPTIONAL
    /// 							resourcePoolName = $someString
    /// 							# OPTIONAL
    /// 							hostId = $someString
    /// 							# OPTIONAL
    /// 							hostName = $someString
    /// 							# OPTIONAL
    /// 							hostCdmId = $someString
    /// 							# OPTIONAL
    /// 							datacenterId = $someString
    /// 							# OPTIONAL
    /// 							datacenterCdmId = $someString
    /// 							# OPTIONAL
    /// 							datacenterName = $someString
    /// 						}
    /// 						# OPTIONAL
    /// 						enableNetworkPreserve = $someBoolean
    /// 						# OPTIONAL
    /// 						enableMacPreserveOnly = $someBoolean
    /// 						# OPTIONAL
    /// 						email = $someString
    /// 						# OPTIONAL
    /// 						postScriptTimestamp = $someString
    /// 						# OPTIONAL
    /// 						postScriptHash = $someString
    /// 						# OPTIONAL
    /// 						enableNetworkDisconnect = $someBoolean
    /// 					}
    /// 					# OPTIONAL
    /// 					nutanixSpec = @{
    /// 						# OPTIONAL
    /// 						vCpus = $someInt64
    /// 						# OPTIONAL
    /// 						memoryMbs = $someInt64
    /// 						# OPTIONAL
    /// 						clusterId = $someString
    /// 						# OPTIONAL
    /// 						version = $someInt64
    /// 						# OPTIONAL
    /// 						removeAllNetwork = $someBoolean
    /// 						# OPTIONAL
    /// 						preserveMacAddress = $someBoolean
    /// 						# OPTIONAL
    /// 						volumes = @(
    /// 							@{
    /// 								# OPTIONAL
    /// 								storageContainerId = $someString
    /// 								# OPTIONAL
    /// 								storageContainerName = $someString
    /// 							}
    /// 						)
    /// 						# OPTIONAL
    /// 						nics = @(
    /// 							@{
    /// 								# OPTIONAL
    /// 								key = $someString
    /// 								# OPTIONAL
    /// 								networkName = $someString
    /// 							}
    /// 						)
    /// 						# OPTIONAL
    /// 						target = @{
    /// 							# OPTIONAL
    /// 							clusterId = $someString
    /// 							# OPTIONAL
    /// 							clusterName = $someString
    /// 							# OPTIONAL
    /// 							clusterHostname = $someString
    /// 							# OPTIONAL
    /// 							prismCentral = $someString
    /// 						}
    /// 					}
    /// 				}
    /// 			}
    /// 		)
    /// 		# OPTIONAL
    /// 		resourceSpecType = $someResourceSpecType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ResourceSpecType]) for enum values.
    /// 		# OPTIONAL
    /// 		failoverId = $someString
    /// }
    /// )
    /// # OPTIONAL
    /// $query.Var.isDefaultRecoverySpec = $someBoolean
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: List&lt;BlueprintRecoverySpec&gt;
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CreateChat operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: CreateChat
    /// 
    /// $query = New-RscMutationMisc -CreateChat
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	chatUsage = $someChatUsage # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ChatUsage]) for enum values.
    /// 	# OPTIONAL
    /// 	chatrockInput = @{
    /// 		# REQUIRED
    /// 		matchId = $someString
    /// 	}
    /// 	# OPTIONAL
    /// 	helpcenterInput = @{
    /// 		# REQUIRED
    /// 		query = $someString
    /// 		# REQUIRED
    /// 		response = $someString
    /// 		# OPTIONAL
    /// 		references = @(
    /// 			$someString
    /// 		)
    /// 	}
    /// 	# OPTIONAL
    /// 	dataChatInput = @{
    /// 		# REQUIRED
    /// 		chatbotId = $someString
    /// 	}
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: CreateChatReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CreateChatbot operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: CreateChatbot
    /// 
    /// $query = New-RscMutationMisc -CreateChatbot
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	name = $someString
    /// 	# OPTIONAL
    /// 	description = $someString
    /// 	# OPTIONAL
    /// 	filters = @{
    /// 		# OPTIONAL
    /// 		modifiedTimeRange = @{
    /// 			# OPTIONAL
    /// 			startTime = $someInt64
    /// 			# OPTIONAL
    /// 			endTime = $someInt64
    /// 		}
    /// 		# REQUIRED
    /// 		sensitiveDataPolicyIds = @(
    /// 			$someString
    /// 		)
    /// 		# REQUIRED
    /// 		extensionWhitelist = @(
    /// 			$someString
    /// 		)
    /// 	}
    /// 	# OPTIONAL
    /// 	userAssignment = @{
    /// 		# OPTIONAL
    /// 		roleName = $someString
    /// 		# OPTIONAL
    /// 		roleDescription = $someString
    /// 		# REQUIRED
    /// 		userIds = @(
    /// 			$someString
    /// 		)
    /// 		# REQUIRED
    /// 		userGroupIds = @(
    /// 			$someString
    /// 		)
    /// 	}
    /// 	# OPTIONAL
    /// 	chatbotSettings = @{
    /// 		# OPTIONAL
    /// 		enableDocLevelAccessControl = $someBoolean
    /// 		# OPTIONAL
    /// 		systemMessage = $someString
    /// 		# OPTIONAL
    /// 		numChunksToRetrieve = $someInt
    /// 	}
    /// 	# OPTIONAL
    /// 	embeddingFactorySettings = @{
    /// 		# OPTIONAL
    /// 		chunkerConfig = @{
    /// 			# REQUIRED
    /// 			variant = @{
    /// 				# OPTIONAL
    /// 				recursiveCharacterChunkerConfig = @{
    /// 					# OPTIONAL
    /// 					chunkSize = $someInt
    /// 					# OPTIONAL
    /// 					chunkOverlap = $someInt
    /// 					# OPTIONAL
    /// 					separators = @(
    /// 						$someString
    /// 					)
    /// 				}
    /// 			}
    /// 		}
    /// 	}
    /// 	# REQUIRED
    /// 	objects = @(
    /// 		@{
    /// 			# OPTIONAL
    /// 			workloadType = $someManagedObjectType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ManagedObjectType]) for enum values.
    /// 			# OPTIONAL
    /// 			pathFilter = @{
    /// 				# REQUIRED
    /// 				prefixInclusions = @(
    /// 					$someString
    /// 				)
    /// 			}
    /// 			# REQUIRED
    /// 			id = $someString
    /// 		}
    /// 	)
    /// 	# REQUIRED
    /// 	roleIds = @(
    /// 		$someString
    /// 	)
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: CreateChatbotReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CreateConfigProtectionBackup operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: CreateConfigProtectionBackup
    /// 
    /// $query = New-RscMutationMisc -CreateConfigProtectionBackup
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	clusterUuids = @(
    /// 		$someString
    /// 	)
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: BatchAsyncJobStatus
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CreateConfigProtectionSetup operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: CreateConfigProtectionSetup
    /// 
    /// $query = New-RscMutationMisc -CreateConfigProtectionSetup
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	clusterUuid = $someString
    /// 	# REQUIRED
    /// 	encryptionPassword = $someString
    /// 	# OPTIONAL
    /// 	caCertificate = @{
    /// 		# OPTIONAL
    /// 		uuid = $someString
    /// 		# OPTIONAL
    /// 		name = $someString
    /// 		# OPTIONAL
    /// 		description = $someString
    /// 		# OPTIONAL
    /// 		certificate = $someString
    /// 		# REQUIRED
    /// 		caProvider = $someCaCertProviderType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CaCertProviderType]) for enum values.
    /// 	}
    /// 	# OPTIONAL
    /// 	replicationTargetUuid = $someString
    /// 	# REQUIRED
    /// 	uploadLocationType = $someUploadLocationType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UploadLocationType]) for enum values.
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AsyncJobStatus
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CreateCustomAnalyzer operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: CreateCustomAnalyzer
    /// 
    /// $query = New-RscMutationMisc -CreateCustomAnalyzer
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	analyzerType = $someAnalyzerTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AnalyzerTypeEnum]) for enum values.
    /// 	# OPTIONAL
    /// 	id = $someString
    /// 	# OPTIONAL
    /// 	name = $someString
    /// 	# OPTIONAL
    /// 	dictionaryCsv = $someString
    /// 	# OPTIONAL
    /// 	dictionary = @(
    /// 		$someString
    /// 	)
    /// 	# OPTIONAL
    /// 	regex = $someString
    /// 	# OPTIONAL
    /// 	analyzerRiskInstance = @{
    /// 		# OPTIONAL
    /// 		analyzerId = $someString
    /// 		# OPTIONAL
    /// 		riskVersion = $someInt
    /// 		# OPTIONAL
    /// 		risk = $someRiskLevelType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RiskLevelType]) for enum values.
    /// 	}
    /// 	# OPTIONAL
    /// 	tagId = $someInt
    /// 	# OPTIONAL
    /// 	risk = $someRiskLevelType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RiskLevelType]) for enum values.
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: Analyzer
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CreateEventDigestBatch operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: CreateEventDigestBatch
    /// 
    /// $query = New-RscMutationMisc -CreateEventDigestBatch
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	digests = @(
    /// 		@{
    /// 			# OPTIONAL
    /// 			digestId = $someInt
    /// 			# REQUIRED
    /// 			digestName = $someString
    /// 			# REQUIRED
    /// 			frequencyHours = $someInt
    /// 			# REQUIRED
    /// 			isImmediate = $someBoolean
    /// 			# REQUIRED
    /// 			includeAudits = $someBoolean
    /// 			# REQUIRED
    /// 			includeEvents = $someBoolean
    /// 			# REQUIRED
    /// 			eventDigestConfig = @{
    /// 				# OPTIONAL
    /// 				objectType = @(
    /// 					$someActivityObjectTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ActivityObjectTypeEnum]) for enum values.
    /// 				)
    /// 				# OPTIONAL
    /// 				activityStatus = @(
    /// 					$someActivityStatusEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ActivityStatusEnum]) for enum values.
    /// 				)
    /// 				# OPTIONAL
    /// 				activityType = @(
    /// 					$someString
    /// 				)
    /// 				# OPTIONAL
    /// 				auditType = @(
    /// 					$someUserAuditTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UserAuditTypeEnum]) for enum values.
    /// 				)
    /// 				# OPTIONAL
    /// 				activitySeverity = @(
    /// 					$someActivitySeverityEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ActivitySeverityEnum]) for enum values.
    /// 				)
    /// 				# OPTIONAL
    /// 				clusters = @(
    /// 					$someString
    /// 				)
    /// 				# OPTIONAL
    /// 				emailAddresses = @(
    /// 					$someString
    /// 				)
    /// 			}
    /// 			# REQUIRED
    /// 			recipientUserId = $someString
    /// 			# REQUIRED
    /// 			clusterUuids = @(
    /// 				$someString
    /// 			)
    /// 		}
    /// 	)
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: System.String
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CreateGuestCredential operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: CreateGuestCredential
    /// 
    /// $query = New-RscMutationMisc -CreateGuestCredential
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	clusterUuid = $someString
    /// 	# REQUIRED
    /// 	definition = @{
    /// 		# OPTIONAL
    /// 		domain = $someString
    /// 		# OPTIONAL
    /// 		description = $someString
    /// 		# OPTIONAL
    /// 		baseGuestCredential = @{
    /// 			# REQUIRED
    /// 			password = $someString
    /// 			# REQUIRED
    /// 			username = $someString
    /// 		}
    /// 	}
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: CreateGuestCredentialReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CreateLegalHold operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: CreateLegalHold
    /// 
    /// $query = New-RscMutationMisc -CreateLegalHold
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	snapshotIds = @(
    /// 		$someString
    /// 	)
    /// 	# OPTIONAL
    /// 	holdConfig = @{
    /// 		# OPTIONAL
    /// 		shouldHoldInPlace = $someBoolean
    /// 	}
    /// 	# OPTIONAL
    /// 	userNote = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: CreateLegalHoldReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CreateOnDemandVolumeGroupBackup operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: CreateOnDemandVolumeGroupBackup
    /// 
    /// $query = New-RscMutationMisc -CreateOnDemandVolumeGroupBackup
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	config = @{
    /// 		# OPTIONAL
    /// 		volumeIdsIncludedInSnapshot = @(
    /// 			$someString
    /// 		)
    /// 		# OPTIONAL
    /// 		baseOnDemandSnapshotConfig = @{
    /// 			# OPTIONAL
    /// 			slaId = $someString
    /// 		}
    /// 	}
    /// 	# REQUIRED
    /// 	id = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AsyncRequestStatus
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CreateOrgNetwork operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: CreateOrgNetwork
    /// 
    /// $query = New-RscMutationMisc -CreateOrgNetwork
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	orgID = $someString
    /// 	# REQUIRED
    /// 	clusterUUID = $someString
    /// 	# REQUIRED
    /// 	orgNetworkName = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: CreateOrgNetworkReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CreatePasskey operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: CreatePasskey
    /// 
    /// $query = New-RscMutationMisc -CreatePasskey
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	additionalConfig = $someString
    /// 	# OPTIONAL
    /// 	os = $someString
    /// 	# OPTIONAL
    /// 	browser = $someString
    /// 	# REQUIRED
    /// 	credentialId = $someString
    /// 	# REQUIRED
    /// 	passkeyName = $someString
    /// 	# REQUIRED
    /// 	publicKey = $someString
    /// 	# REQUIRED
    /// 	keyType = $someKeyTypeEnumType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.KeyTypeEnumType]) for enum values.
    /// 	# REQUIRED
    /// 	clientData = $someString
    /// 	# REQUIRED
    /// 	authData = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: CreatePasskeyReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CreateRbacMigrationSummaryDownload operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: CreateRbacMigrationSummaryDownload
    /// 
    /// $query = New-RscMutationMisc -CreateRbacMigrationSummaryDownload
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	clusterId = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: CreateRbacMigrationSummaryDownloadReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CreateRecoveryPlan operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: CreateRecoveryPlan
    /// 
    /// $query = New-RscMutationMisc -CreateRecoveryPlan
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	name = $someString
    /// 	# REQUIRED
    /// 	recoveryType = $someBlueprintRecoveryType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.BlueprintRecoveryType]) for enum values.
    /// 	# REQUIRED
    /// 	sourceLocationId = $someString
    /// 	# REQUIRED
    /// 	sourceLocationType = $someBlueprintLocationType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.BlueprintLocationType]) for enum values.
    /// 	# OPTIONAL
    /// 	targetLocationId = $someString
    /// 	# OPTIONAL
    /// 	targetLocationType = $someBlueprintLocationType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.BlueprintLocationType]) for enum values.
    /// 	# REQUIRED
    /// 	children = @(
    /// 		@{
    /// 			# REQUIRED
    /// 			fid = $someString
    /// 			# REQUIRED
    /// 			snappableType = $someObjectTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ObjectTypeEnum]) for enum values.
    /// 			# REQUIRED
    /// 			bootPriority = $someInt
    /// 			# OPTIONAL
    /// 			lastRecoveryPoint = $someInt64
    /// 		}
    /// 	)
    /// 	# REQUIRED
    /// 	isHydrationEnabled = $someBoolean
    /// 	# REQUIRED
    /// 	pauseBetweenPriorityGroups = @(
    /// 		$someInt64
    /// 	)
    /// 	# REQUIRED
    /// 	isVisible = $someBoolean
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: CreateRecoveryPlanReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CreateRecoverySchedule operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: CreateRecoverySchedule
    /// 
    /// $query = New-RscMutationMisc -CreateRecoverySchedule
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	recoveryPlanFid = $someString
    /// 	# REQUIRED
    /// 	scheduleInfo = @{
    /// 		# OPTIONAL
    /// 		startRunTime = $someDateTime
    /// 		# OPTIONAL
    /// 		timezone = $someString
    /// 		# OPTIONAL
    /// 		frequency = $someScheduleFrequency # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ScheduleFrequency]) for enum values.
    /// 		# OPTIONAL
    /// 		recoveryConfig = @{
    /// 			# OPTIONAL
    /// 			dataTransferType = $someDataTransferType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DataTransferType]) for enum values.
    /// 		}
    /// 		# OPTIONAL
    /// 		recipients = @(
    /// 			$someString
    /// 		)
    /// 	}
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: CreateScheduleReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CreateS3Bucket operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: CreateS3Bucket
    /// 
    /// $query = New-RscMutationMisc -CreateS3Bucket
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	awsNativeAccountId = $someString
    /// 	# REQUIRED
    /// 	bucketName = $someString
    /// 	# REQUIRED
    /// 	region = $someString
    /// 	# REQUIRED
    /// 	bucketOwnershipControl = $someBucketOwnershipControls # Call [Enum]::GetValues([RubrikSecurityCloud.Types.BucketOwnershipControls]) for enum values.
    /// 	# REQUIRED
    /// 	tags = @(
    /// 		@{
    /// 			# REQUIRED
    /// 			tagKey = $someString
    /// 			# REQUIRED
    /// 			tagValue = $someString
    /// 		}
    /// 	)
    /// 	# REQUIRED
    /// 	versioningEnabled = $someBoolean
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: CreateS3BucketReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CreateSnapMirrorCloud operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: CreateSnapMirrorCloud
    /// 
    /// $query = New-RscMutationMisc -CreateSnapMirrorCloud
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	clusterUuid = $someString
    /// 	# REQUIRED
    /// 	definition = @{
    /// 		# OPTIONAL
    /// 		nasVolumeId = $someString
    /// 		# OPTIONAL
    /// 		snapMirrorLabel = $someString
    /// 	}
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: CreateSnapMirrorCloudReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CreateSnapMirrorCloudRelationship operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: CreateSnapMirrorCloudRelationship
    /// 
    /// $query = New-RscMutationMisc -CreateSnapMirrorCloudRelationship
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	clusterUuid = $someString
    /// 	# REQUIRED
    /// 	definition = @{
    /// 		# OPTIONAL
    /// 		objectStoreAccess = @{
    /// 			# OPTIONAL
    /// 			isSslEnabled = $someBoolean
    /// 			# OPTIONAL
    /// 			objectServerUrl = $someString
    /// 			# OPTIONAL
    /// 			providerType = $someString
    /// 			# OPTIONAL
    /// 			shouldUseHttpProxy = $someBoolean
    /// 		}
    /// 		# REQUIRED
    /// 		snapMirrorCloudId = $someString
    /// 	}
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: CreateSnapMirrorCloudRelationshipReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CreateSnapMirrorCloudRestoreJob operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: CreateSnapMirrorCloudRestoreJob
    /// 
    /// $query = New-RscMutationMisc -CreateSnapMirrorCloudRestoreJob
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	id = $someString
    /// 	# REQUIRED
    /// 	jobConfig = @{
    /// 		# OPTIONAL
    /// 		ignoreErrors = $someBoolean
    /// 		# OPTIONAL
    /// 		netAppAggregateName = $someString
    /// 		# OPTIONAL
    /// 		targetNasNamespaceId = $someString
    /// 		# OPTIONAL
    /// 		targetNasSystemId = $someString
    /// 		# OPTIONAL
    /// 		targetNasVolumeId = $someString
    /// 		# OPTIONAL
    /// 		targetNasVolumeName = $someString
    /// 		# REQUIRED
    /// 		isVolumeRestore = $someBoolean
    /// 		# OPTIONAL
    /// 		restorePathPairs = @(
    /// 			@{
    /// 				# OPTIONAL
    /// 				dstPath = $someString
    /// 				# REQUIRED
    /// 				srcPath = $someString
    /// 			}
    /// 		)
    /// 	}
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AsyncRequestStatus
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CreateSsoUsers operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: CreateSsoUsers
    /// 
    /// $query = New-RscMutationMisc -CreateSsoUsers
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	userEmails = @(
    /// 		$someString
    /// 	)
    /// 	# REQUIRED
    /// 	roleIds = @(
    /// 		$someString
    /// 	)
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: CreateSsoUsersReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CreateSupportCase operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: CreateSupportCase
    /// 
    /// $query = New-RscMutationMisc -CreateSupportCase
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	subject = $someString
    /// 	# REQUIRED
    /// 	caseType = $someNewCaseType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.NewCaseType]) for enum values.
    /// 	# REQUIRED
    /// 	priority = $someNewCasePriority # Call [Enum]::GetValues([RubrikSecurityCloud.Types.NewCasePriority]) for enum values.
    /// 	# OPTIONAL
    /// 	clusterId = $someString
    /// 	# REQUIRED
    /// 	contactMethod = $someNewCaseContactMethod # Call [Enum]::GetValues([RubrikSecurityCloud.Types.NewCaseContactMethod]) for enum values.
    /// 	# REQUIRED
    /// 	description = $someString
    /// 	# OPTIONAL
    /// 	caseSource = $someNewCaseSource # Call [Enum]::GetValues([RubrikSecurityCloud.Types.NewCaseSource]) for enum values.
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: CreateSupportCaseReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CreateUserAccessInsightTicket operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: CreateUserAccessInsightTicket
    /// 
    /// $query = New-RscMutationMisc -CreateUserAccessInsightTicket
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	insightUuid = $someString
    /// 	# REQUIRED
    /// 	platformType = $someTicketingPlatform # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TicketingPlatform]) for enum values.
    /// 	# REQUIRED
    /// 	ticketInfo = @{
    /// 		# REQUIRED
    /// 		name = $someString
    /// 		# REQUIRED
    /// 		reason = $someString
    /// 		# REQUIRED
    /// 		attachmentTypes = @(
    /// 			$someInsightTicketAttachmentType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.InsightTicketAttachmentType]) for enum values.
    /// 		)
    /// 		# REQUIRED
    /// 		comment = $someString
    /// 	}
    /// 	# REQUIRED
    /// 	timelineDate = $someInt64
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: CreateUserAccessInsightTicketReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CreateVappExport operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: CreateVappExport
    /// 
    /// $query = New-RscMutationMisc -CreateVappExport
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	config = @{
    /// 		# OPTIONAL
    /// 		shouldPowerOnVappAfterExport = $someBoolean
    /// 		# OPTIONAL
    /// 		targetVappId = $someString
    /// 		# REQUIRED
    /// 		exportMode = $someVappExportMode # Call [Enum]::GetValues([RubrikSecurityCloud.Types.VappExportMode]) for enum values.
    /// 		# REQUIRED
    /// 		networksToRestore = @(
    /// 			@{
    /// 				# OPTIONAL
    /// 				newName = $someString
    /// 				# OPTIONAL
    /// 				vappNetworkSummary = @{
    /// 					# OPTIONAL
    /// 					parentNetworkId = $someString
    /// 					# REQUIRED
    /// 					isDeployed = $someBoolean
    /// 					# REQUIRED
    /// 					name = $someString
    /// 				}
    /// 			}
    /// 		)
    /// 		# OPTIONAL
    /// 		newVappParams = @{
    /// 			# REQUIRED
    /// 			name = $someString
    /// 			# REQUIRED
    /// 			orgVdcId = $someString
    /// 		}
    /// 		# REQUIRED
    /// 		vmsToExport = @(
    /// 			@{
    /// 				# OPTIONAL
    /// 				storagePolicyId = $someString
    /// 				# REQUIRED
    /// 				name = $someString
    /// 				# REQUIRED
    /// 				networkConnections = @(
    /// 					@{
    /// 						# OPTIONAL
    /// 						ipAddress = $someString
    /// 						# OPTIONAL
    /// 						macAddress = $someString
    /// 						# OPTIONAL
    /// 						vappNetworkName = $someString
    /// 						# OPTIONAL
    /// 						networkAdapterType = $someString
    /// 						# REQUIRED
    /// 						addressingMode = $someVappVmIpAddressingMode # Call [Enum]::GetValues([RubrikSecurityCloud.Types.VappVmIpAddressingMode]) for enum values.
    /// 						# REQUIRED
    /// 						isConnected = $someBoolean
    /// 						# REQUIRED
    /// 						nicIndex = $someInt
    /// 					}
    /// 				)
    /// 				# REQUIRED
    /// 				vcdMoid = $someString
    /// 			}
    /// 		)
    /// 	}
    /// 	# REQUIRED
    /// 	snapshotId = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: List&lt;AsyncRequestStatus&gt;
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CreateVappsInstantRecovery operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: CreateVappsInstantRecovery
    /// 
    /// $query = New-RscMutationMisc -CreateVappsInstantRecovery
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	inputs = @(
    /// 		@{
    /// 			# REQUIRED
    /// 			config = @{
    /// 				# OPTIONAL
    /// 				shouldPowerOnVmsAfterRecovery = $someBoolean
    /// 				# REQUIRED
    /// 				vmsToRestore = @(
    /// 					@{
    /// 						# OPTIONAL
    /// 						storagePolicyId = $someString
    /// 						# REQUIRED
    /// 						name = $someString
    /// 						# REQUIRED
    /// 						networkConnections = @(
    /// 							@{
    /// 								# OPTIONAL
    /// 								ipAddress = $someString
    /// 								# OPTIONAL
    /// 								macAddress = $someString
    /// 								# OPTIONAL
    /// 								vappNetworkName = $someString
    /// 								# OPTIONAL
    /// 								networkAdapterType = $someString
    /// 								# REQUIRED
    /// 								addressingMode = $someVappVmIpAddressingMode # Call [Enum]::GetValues([RubrikSecurityCloud.Types.VappVmIpAddressingMode]) for enum values.
    /// 								# REQUIRED
    /// 								isConnected = $someBoolean
    /// 								# REQUIRED
    /// 								nicIndex = $someInt
    /// 							}
    /// 						)
    /// 						# REQUIRED
    /// 						vcdMoid = $someString
    /// 					}
    /// 				)
    /// 			}
    /// 			# REQUIRED
    /// 			snapshotId = $someString
    /// 		}
    /// 	)
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: CreateVappsInstantRecoveryReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the DeactivateCustomAnalyzer operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: DeactivateCustomAnalyzer
    /// 
    /// $query = New-RscMutationMisc -DeactivateCustomAnalyzer
    /// 
    /// # REQUIRED
    /// $query.Var.analyzerId = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: System.String
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the DeleteAccountSettingValue operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: DeleteAccountSettingValue
    /// 
    /// $query = New-RscMutationMisc -DeleteAccountSettingValue
    /// 
    /// # REQUIRED
    /// $query.Var.aspName = $someString
    /// # REQUIRED
    /// $query.Var.aspComponent = $someComponentEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ComponentEnum]) for enum values.
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: System.Boolean
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the DeleteAdGroupsFromHierarchy operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: DeleteAdGroupsFromHierarchy
    /// 
    /// $query = New-RscMutationMisc -DeleteAdGroupsFromHierarchy
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	orgId = $someString
    /// 	# REQUIRED
    /// 	groupIds = @(
    /// 		$someString
    /// 	)
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: RequestStatus
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the DeleteBlueprint operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: DeleteBlueprint
    /// 
    /// $query = New-RscMutationMisc -DeleteBlueprint
    /// 
    /// # REQUIRED
    /// $query.Var.fid = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: System.Boolean
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the DeleteBlueprints operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: DeleteBlueprints
    /// 
    /// $query = New-RscMutationMisc -DeleteBlueprints
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	fids = @(
    /// 		$someString
    /// 	)
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: System.Boolean
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the DeleteBrandLogo operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: DeleteBrandLogo
    /// 
    /// $query = New-RscMutationMisc -DeleteBrandLogo
    /// 
    /// # No variables for this query.
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: System.String
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the DeleteChatbot operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: DeleteChatbot
    /// 
    /// $query = New-RscMutationMisc -DeleteChatbot
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	chatbotId = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: System.String
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the DeleteDistributionListDigestBatch operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: DeleteDistributionListDigestBatch
    /// 
    /// $query = New-RscMutationMisc -DeleteDistributionListDigestBatch
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	digestIds = @(
    /// 		$someInt
    /// 	)
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: System.String
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the DeleteEnvoyNgs operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: DeleteEnvoyNgs
    /// 
    /// $query = New-RscMutationMisc -DeleteEnvoyNgs
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	orgNetworkID = $someString
    /// 	# REQUIRED
    /// 	envoyIds = @(
    /// 		$someString
    /// 	)
    /// 	# REQUIRED
    /// 	clusterUuid = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: System.String
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the DeleteEventDigest operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: DeleteEventDigest
    /// 
    /// $query = New-RscMutationMisc -DeleteEventDigest
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	recipientUserIds = @(
    /// 		$someString
    /// 	)
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: System.String
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the DeleteGuestCredentialById operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: DeleteGuestCredentialById
    /// 
    /// $query = New-RscMutationMisc -DeleteGuestCredentialById
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	clusterUuid = $someString
    /// 	# REQUIRED
    /// 	id = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: System.Boolean
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the DeleteIdentityProvider operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: DeleteIdentityProvider
    /// 
    /// $query = New-RscMutationMisc -DeleteIdentityProvider
    /// 
    /// # No variables for this query.
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: IdentityProvider
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the DeleteIntelFeed operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: DeleteIntelFeed
    /// 
    /// $query = New-RscMutationMisc -DeleteIntelFeed
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	providerId = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: System.String
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the DeleteKmipServer operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: DeleteKmipServer
    /// 
    /// $query = New-RscMutationMisc -DeleteKmipServer
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	clusterIds = @(
    /// 		$someString
    /// 	)
    /// 	# REQUIRED
    /// 	serverAddress = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: DeleteKmipServerReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the DeleteKmsInstance operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: DeleteKmsInstance
    /// 
    /// $query = New-RscMutationMisc -DeleteKmsInstance
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	kmsKeyVaultId = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: System.String
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the DeleteOrgNetwork operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: DeleteOrgNetwork
    /// 
    /// $query = New-RscMutationMisc -DeleteOrgNetwork
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	orgNetworkID = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: System.String
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the DeletePasskey operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: DeletePasskey
    /// 
    /// $query = New-RscMutationMisc -DeletePasskey
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	credentialId = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: DeletePasskeyReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the DeleteRecoveryPlan operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: DeleteRecoveryPlan
    /// 
    /// $query = New-RscMutationMisc -DeleteRecoveryPlan
    /// 
    /// # REQUIRED
    /// $query.Var.fid = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: System.String
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the DeleteRecoveryPlans operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: DeleteRecoveryPlans
    /// 
    /// $query = New-RscMutationMisc -DeleteRecoveryPlans
    /// 
    /// # REQUIRED
    /// $query.Var.fids = @(
    /// 	$someString
    /// )
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: System.String
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the DeleteRecoverySchedule operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: DeleteRecoverySchedule
    /// 
    /// $query = New-RscMutationMisc -DeleteRecoverySchedule
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	recoveryPlanFid = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: System.String
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the DeleteRecoverySpec operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: DeleteRecoverySpec
    /// 
    /// $query = New-RscMutationMisc -DeleteRecoverySpec
    /// 
    /// # REQUIRED
    /// $query.Var.blueprintId = $someString
    /// # REQUIRED
    /// $query.Var.excludePlanTypes = @(
    /// 	$somePlanName # Call [Enum]::GetValues([RubrikSecurityCloud.Types.PlanName]) for enum values.
    /// )
    /// # OPTIONAL
    /// $query.Var.failoverId = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: DeleteBlueprintRecoverySpecReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the DeleteSmtpConfiguration operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: DeleteSmtpConfiguration
    /// 
    /// $query = New-RscMutationMisc -DeleteSmtpConfiguration
    /// 
    /// # No variables for this query.
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: System.Boolean
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the DeleteSnapMirrorCloud operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: DeleteSnapMirrorCloud
    /// 
    /// $query = New-RscMutationMisc -DeleteSnapMirrorCloud
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	preserveSnapshots = $someBoolean
    /// 	# REQUIRED
    /// 	id = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: ResponseSuccess
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the DeleteSnapMirrorCloudRelationship operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: DeleteSnapMirrorCloudRelationship
    /// 
    /// $query = New-RscMutationMisc -DeleteSnapMirrorCloudRelationship
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	id = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: ResponseSuccess
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the DeleteVcdInstances operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: DeleteVcdInstances
    /// 
    /// $query = New-RscMutationMisc -DeleteVcdInstances
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	inputs = @(
    /// 		@{
    /// 			# REQUIRED
    /// 			clusterUuid = $someString
    /// 			# REQUIRED
    /// 			id = $someString
    /// 		}
    /// 	)
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: DeleteVcdInstancesReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the DeleteVolumeGroupMount operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: DeleteVolumeGroupMount
    /// 
    /// $query = New-RscMutationMisc -DeleteVolumeGroupMount
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	id = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AsyncRequestStatus
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the DenyTprRequests operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: DenyTprRequests
    /// 
    /// $query = New-RscMutationMisc -DenyTprRequests
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	requestIds = @(
    /// 		$someString
    /// 	)
    /// 	# OPTIONAL
    /// 	comment = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: System.String
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the DeregisterPrivateContainerRegistry operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: DeregisterPrivateContainerRegistry
    /// 
    /// $query = New-RscMutationMisc -DeregisterPrivateContainerRegistry
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	exocomputeAccountId = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: System.String
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the DisableSupportUserAccess operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: DisableSupportUserAccess
    /// 
    /// $query = New-RscMutationMisc -DisableSupportUserAccess
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	id = $someInt
    /// 	# OPTIONAL
    /// 	impersonatedUserId = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: System.String
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the DisableTprOrg operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: DisableTprOrg
    /// 
    /// $query = New-RscMutationMisc -DisableTprOrg
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	organizationId = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: System.String
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the DisconnectTicketingPlatform operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: DisconnectTicketingPlatform
    /// 
    /// $query = New-RscMutationMisc -DisconnectTicketingPlatform
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	platformConfig = @{
    /// 		# REQUIRED
    /// 		platformType = $someTicketingPlatform # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TicketingPlatform]) for enum values.
    /// 		# REQUIRED
    /// 		instanceUrl = $someString
    /// 	}
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: System.String
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the DissolveLegalHold operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: DissolveLegalHold
    /// 
    /// $query = New-RscMutationMisc -DissolveLegalHold
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	snapshotIds = @(
    /// 		$someString
    /// 	)
    /// 	# OPTIONAL
    /// 	userNote = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: DissolveLegalHoldReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the EditPasskey operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: EditPasskey
    /// 
    /// $query = New-RscMutationMisc -EditPasskey
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	credentialId = $someString
    /// 	# REQUIRED
    /// 	passkeyNewName = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: EditPasskeyReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the EditSalesforceOrganization operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: EditSalesforceOrganization
    /// 
    /// $query = New-RscMutationMisc -EditSalesforceOrganization
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	orgId = $someString
    /// 	# REQUIRED
    /// 	apiLimits = @{
    /// 		# OPTIONAL
    /// 		restApiLimit = $someInt
    /// 		# OPTIONAL
    /// 		bulkApiLimit = $someInt
    /// 		# OPTIONAL
    /// 		bulkApiV2Limit = $someInt
    /// 	}
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: EditSalesforceOrganizationReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the EnableAutomaticFmdUpload operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: EnableAutomaticFmdUpload
    /// 
    /// $query = New-RscMutationMisc -EnableAutomaticFmdUpload
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	clusterId = $someString
    /// 	# REQUIRED
    /// 	enabled = $someBoolean
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: EnableAutomaticFmdUploadReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the EnableDisableAppConsistency operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: EnableDisableAppConsistency
    /// 
    /// $query = New-RscMutationMisc -EnableDisableAppConsistency
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	workloadIds = @(
    /// 		$someString
    /// 	)
    /// 	# REQUIRED
    /// 	enable = $someBoolean
    /// 	# REQUIRED
    /// 	objectType = $someCloudNativeVmAppConsistentObjectType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudNativeVmAppConsistentObjectType]) for enum values.
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: EnableDisableAppConsistencyReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the EnableLambdaForWorkload operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: EnableLambdaForWorkload
    /// 
    /// $query = New-RscMutationMisc -EnableLambdaForWorkload
    /// 
    /// # REQUIRED
    /// $query.Var.snappableId = $someString
    /// # REQUIRED
    /// $query.Var.enableDiffFmd = $someBoolean
    /// # REQUIRED
    /// $query.Var.enableFullFmd = $someBoolean
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: EnableLambdaForSnappableReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the EnableMigrationWorkflow operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: EnableMigrationWorkflow
    /// 
    /// $query = New-RscMutationMisc -EnableMigrationWorkflow
    /// 
    /// # No variables for this query.
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: EnableMigrationWorkflowReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the EnableSupportUserAccess operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: EnableSupportUserAccess
    /// 
    /// $query = New-RscMutationMisc -EnableSupportUserAccess
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	impersonatedUserId = $someString
    /// 	# OPTIONAL
    /// 	ticketNumber = $someString
    /// 	# OPTIONAL
    /// 	durationInHours = $someInt
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: System.String
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the EnableTprOrg operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: EnableTprOrg
    /// 
    /// $query = New-RscMutationMisc -EnableTprOrg
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	organizationId = $someString
    /// 	# REQUIRED
    /// 	newTprAdminEmail = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: System.Boolean
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the ExcludeVmDisks operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: ExcludeVmDisks
    /// 
    /// $query = New-RscMutationMisc -ExcludeVmDisks
    /// 
    /// # REQUIRED
    /// $query.Var.input = @(
    /// 	@{
    /// 		# REQUIRED
    /// 		virtualDiskFid = $someString
    /// 		# REQUIRED
    /// 		excludeFromSnapshots = $someBoolean
    /// }
    /// )
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: RequestSuccess
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the ExecuteTprRequests operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: ExecuteTprRequests
    /// 
    /// $query = New-RscMutationMisc -ExecuteTprRequests
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	requestIds = @(
    /// 		$someString
    /// 	)
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: System.String
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the ExpireSnoozedDirectories operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: ExpireSnoozedDirectories
    /// 
    /// $query = New-RscMutationMisc -ExpireSnoozedDirectories
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	directories = @(
    /// 		$someString
    /// 	)
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: ExpireSnoozedDirectoriesReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the ExportPrincipalsSummary operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: ExportPrincipalsSummary
    /// 
    /// $query = New-RscMutationMisc -ExportPrincipalsSummary
    /// 
    /// # OPTIONAL
    /// $query.Var.filter = @{
    /// 	# OPTIONAL
    /// 	riskLevel = @(
    /// 		$someRiskLevelType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RiskLevelType]) for enum values.
    /// 	)
    /// 	# OPTIONAL
    /// 	policyIds = @(
    /// 		$someString
    /// 	)
    /// 	# OPTIONAL
    /// 	principalName = $someString
    /// 	# OPTIONAL
    /// 	objectIds = @(
    /// 		$someString
    /// 	)
    /// 	# OPTIONAL
    /// 	groupId = $someString
    /// 	# OPTIONAL
    /// 	principalSummaryCategory = $somePrincipalSummaryCategoryType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.PrincipalSummaryCategoryType]) for enum values.
    /// }
    /// # REQUIRED
    /// $query.Var.timelineDate = $someString
    /// # REQUIRED
    /// $query.Var.historicalDeltaDays = $someInt
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: ExportPrincipalSummaryResp
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the ExportUnAccessedUsersSummary operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: ExportUnAccessedUsersSummary
    /// 
    /// $query = New-RscMutationMisc -ExportUnAccessedUsersSummary
    /// 
    /// # OPTIONAL
    /// $query.Var.filter = @{
    /// 	# OPTIONAL
    /// 	policyId = $someString
    /// 	# OPTIONAL
    /// 	objectId = $someString
    /// 	# OPTIONAL
    /// 	userNamePrefix = $someString
    /// 	# OPTIONAL
    /// 	groupId = $someString
    /// 	# OPTIONAL
    /// 	sid = $someString
    /// 	# OPTIONAL
    /// 	activityThresholds = @(
    /// 		$someActivityThreshold # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ActivityThreshold]) for enum values.
    /// 	)
    /// 	# OPTIONAL
    /// 	userRisk = $someRiskLevelType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RiskLevelType]) for enum values.
    /// }
    /// # REQUIRED
    /// $query.Var.endTime = $someDateTime
    /// # REQUIRED
    /// $query.Var.timePeriod = $someTimePeriod # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TimePeriod]) for enum values.
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: ExportUnAccessedUsersSummaryResp
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the ExtendRscAutoUpgradeDate operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: ExtendRscAutoUpgradeDate
    /// 
    /// $query = New-RscMutationMisc -ExtendRscAutoUpgradeDate
    /// 
    /// # No variables for this query.
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: ExtendRscAutoUpgradeDateReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the ExtendTrialAsync operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: ExtendTrialAsync
    /// 
    /// $query = New-RscMutationMisc -ExtendTrialAsync
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	trialId = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: ExtendTrialAsyncReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the GenerateConfigProtectionRestoreForm operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: GenerateConfigProtectionRestoreForm
    /// 
    /// $query = New-RscMutationMisc -GenerateConfigProtectionRestoreForm
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	clusterUuid = $someString
    /// 	# REQUIRED
    /// 	restoreFormRequest = @{
    /// 		# REQUIRED
    /// 		backupFileName = $someString
    /// 		# REQUIRED
    /// 		encryptionPassword = $someString
    /// 	}
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: GenerateConfigProtectionRestoreFormReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the GenerateSupportBundle operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: GenerateSupportBundle
    /// 
    /// $query = New-RscMutationMisc -GenerateSupportBundle
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	clusterUuid = $someString
    /// 	# OPTIONAL
    /// 	definitions = @{
    /// 		# OPTIONAL
    /// 		eventId = $someString
    /// 		# OPTIONAL
    /// 		requestIds = @(
    /// 			$someString
    /// 		)
    /// 	}
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AsyncRequestStatus
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the GetDownloadUrl operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: GetDownloadUrl
    /// 
    /// $query = New-RscMutationMisc -GetDownloadUrl
    /// 
    /// # REQUIRED
    /// $query.Var.downloadId = $someInt64
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: UserDownloadUrl
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the HideRevealNasNamespaces operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: HideRevealNasNamespaces
    /// 
    /// $query = New-RscMutationMisc -HideRevealNasNamespaces
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	hideNasNamespacesRequest = @{
    /// 		# REQUIRED
    /// 		action = $someHideRevealAction # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HideRevealAction]) for enum values.
    /// 		# REQUIRED
    /// 		ids = @(
    /// 			$someString
    /// 		)
    /// 	}
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: System.String
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the IgnoreTrial operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: IgnoreTrial
    /// 
    /// $query = New-RscMutationMisc -IgnoreTrial
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	trialId = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: System.String
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the InstallIoFilter operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: InstallIoFilter
    /// 
    /// $query = New-RscMutationMisc -InstallIoFilter
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	fqdnInfo = @{
    /// 		# REQUIRED
    /// 		fqdn = $someString
    /// 	}
    /// 	# REQUIRED
    /// 	id = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: RequestSuccess
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the InviteSsoGroup operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: InviteSsoGroup
    /// 
    /// $query = New-RscMutationMisc -InviteSsoGroup
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	groupName = $someString
    /// 	# REQUIRED
    /// 	roleIds = @(
    /// 		$someString
    /// 	)
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: System.Boolean
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the InviteUsersToTrial operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: InviteUsersToTrial
    /// 
    /// $query = New-RscMutationMisc -InviteUsersToTrial
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	trialId = $someString
    /// 	# REQUIRED
    /// 	emails = @(
    /// 		$someString
    /// 	)
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: InviteUsersToTrialReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the ListCidrsForComputeSetting operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: ListCidrsForComputeSetting
    /// 
    /// $query = New-RscMutationMisc -ListCidrsForComputeSetting
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	clusterIds = @(
    /// 		$someString
    /// 	)
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: ListCidrsForComputeSettingReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the LockIsolatedRecovery operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: LockIsolatedRecovery
    /// 
    /// $query = New-RscMutationMisc -LockIsolatedRecovery
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	failoverId = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: System.Boolean
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the LockUsersByAdmin operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: LockUsersByAdmin
    /// 
    /// $query = New-RscMutationMisc -LockUsersByAdmin
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	userIds = @(
    /// 		$someString
    /// 	)
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: System.String
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the LogoutFromRubrikSupportPortal operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: LogoutFromRubrikSupportPortal
    /// 
    /// $query = New-RscMutationMisc -LogoutFromRubrikSupportPortal
    /// 
    /// # No variables for this query.
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: SupportPortalLogoutReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the MakePrimary operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: MakePrimary
    /// 
    /// $query = New-RscMutationMisc -MakePrimary
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	hosts = @{
    /// 		# OPTIONAL
    /// 		ids = @(
    /// 			$someString
    /// 		)
    /// 		# OPTIONAL
    /// 		oldPrimaryClusterUuid = $someString
    /// 	}
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AsyncRequestStatus
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the MarkNotificationsAsRead operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: MarkNotificationsAsRead
    /// 
    /// $query = New-RscMutationMisc -MarkNotificationsAsRead
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	notificationIds = @(
    /// 		$someString
    /// 	)
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: MarkNotificationsAsReadReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the ModifyEventDigestBatch operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: ModifyEventDigestBatch
    /// 
    /// $query = New-RscMutationMisc -ModifyEventDigestBatch
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	digests = @(
    /// 		@{
    /// 			# OPTIONAL
    /// 			digestId = $someInt
    /// 			# REQUIRED
    /// 			digestName = $someString
    /// 			# REQUIRED
    /// 			frequencyHours = $someInt
    /// 			# REQUIRED
    /// 			isImmediate = $someBoolean
    /// 			# REQUIRED
    /// 			includeAudits = $someBoolean
    /// 			# REQUIRED
    /// 			includeEvents = $someBoolean
    /// 			# REQUIRED
    /// 			eventDigestConfig = @{
    /// 				# OPTIONAL
    /// 				objectType = @(
    /// 					$someActivityObjectTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ActivityObjectTypeEnum]) for enum values.
    /// 				)
    /// 				# OPTIONAL
    /// 				activityStatus = @(
    /// 					$someActivityStatusEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ActivityStatusEnum]) for enum values.
    /// 				)
    /// 				# OPTIONAL
    /// 				activityType = @(
    /// 					$someString
    /// 				)
    /// 				# OPTIONAL
    /// 				auditType = @(
    /// 					$someUserAuditTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UserAuditTypeEnum]) for enum values.
    /// 				)
    /// 				# OPTIONAL
    /// 				activitySeverity = @(
    /// 					$someActivitySeverityEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ActivitySeverityEnum]) for enum values.
    /// 				)
    /// 				# OPTIONAL
    /// 				clusters = @(
    /// 					$someString
    /// 				)
    /// 				# OPTIONAL
    /// 				emailAddresses = @(
    /// 					$someString
    /// 				)
    /// 			}
    /// 			# REQUIRED
    /// 			recipientUserId = $someString
    /// 			# REQUIRED
    /// 			clusterUuids = @(
    /// 				$someString
    /// 			)
    /// 		}
    /// 	)
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: System.String
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the ModifyIpmi operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: ModifyIpmi
    /// 
    /// $query = New-RscMutationMisc -ModifyIpmi
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	id = $someString
    /// 	# REQUIRED
    /// 	updateProperties = @{
    /// 		# OPTIONAL
    /// 		password = $someString
    /// 		# OPTIONAL
    /// 		access = @{
    /// 			# OPTIONAL
    /// 			https = $someBoolean
    /// 			# OPTIONAL
    /// 			iKvm = $someBoolean
    /// 		}
    /// 	}
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: ModifyIpmiReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the MountDisk operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: MountDisk
    /// 
    /// $query = New-RscMutationMisc -MountDisk
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	snapshotId = $someString
    /// 	# REQUIRED
    /// 	targetWorkloadId = $someString
    /// 	# REQUIRED
    /// 	snapshotType = $someSnapshotType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SnapshotType]) for enum values.
    /// 	# REQUIRED
    /// 	mountDiskIds = @(
    /// 		$someString
    /// 	)
    /// 	# REQUIRED
    /// 	workloadType = $someCloudNativeObjectType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudNativeObjectType]) for enum values.
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: MountDiskReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the NotificationForGetLicense operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: NotificationForGetLicense
    /// 
    /// $query = New-RscMutationMisc -NotificationForGetLicense
    /// 
    /// # OPTIONAL
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	notificationType = $someGetLicenseNotificationRequest # Call [Enum]::GetValues([RubrikSecurityCloud.Types.GetLicenseNotificationRequest]) for enum values.
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: NotificationForGetLicenseReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the PromoteRecovery operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: PromoteRecovery
    /// 
    /// $query = New-RscMutationMisc -PromoteRecovery
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	blueprintId = $someString
    /// 	# REQUIRED
    /// 	failoverId = $someString
    /// 	# OPTIONAL
    /// 	comments = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: CreateOnDemandJobReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the RecoverCloudDirectMultiPaths operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: RecoverCloudDirectMultiPaths
    /// 
    /// $query = New-RscMutationMisc -RecoverCloudDirectMultiPaths
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	snapshotFid = $someString
    /// 	# REQUIRED
    /// 	restorePathPairList = @(
    /// 		@{
    /// 			# REQUIRED
    /// 			srcPath = $someString
    /// 			# REQUIRED
    /// 			dstPath = $someString
    /// 		}
    /// 	)
    /// 	# OPTIONAL
    /// 	dstExportId = $someInt
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AsyncRequestStatus
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the RecoverCloudDirectPath operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: RecoverCloudDirectPath
    /// 
    /// $query = New-RscMutationMisc -RecoverCloudDirectPath
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	snapshotFid = $someString
    /// 	# REQUIRED
    /// 	srcPath = $someString
    /// 	# OPTIONAL
    /// 	dstPath = $someString
    /// 	# OPTIONAL
    /// 	dstExportId = $someInt
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AsyncRequestStatus
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the RefreshDomain operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: RefreshDomain
    /// 
    /// $query = New-RscMutationMisc -RefreshDomain
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	id = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AsyncRequestStatus
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the RefreshGlobalManagerConnectivityStatus operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: RefreshGlobalManagerConnectivityStatus
    /// 
    /// $query = New-RscMutationMisc -RefreshGlobalManagerConnectivityStatus
    /// 
    /// # REQUIRED
    /// $query.Var.clusterUuid = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: GlobalManagerConnectivity
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the RefreshOrgNetwork operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: RefreshOrgNetwork
    /// 
    /// $query = New-RscMutationMisc -RefreshOrgNetwork
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	orgNetworkID = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: System.String
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the RefreshVcdInstances operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: RefreshVcdInstances
    /// 
    /// $query = New-RscMutationMisc -RefreshVcdInstances
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	inputs = @(
    /// 		@{
    /// 			# REQUIRED
    /// 			clusterUuid = $someString
    /// 			# REQUIRED
    /// 			id = $someString
    /// 		}
    /// 	)
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: RefreshVcdInstancesReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the RegisterAndEnableMigrationChoice operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: RegisterAndEnableMigrationChoice
    /// 
    /// $query = New-RscMutationMisc -RegisterAndEnableMigrationChoice
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	migrationChoice = $someMigrationChoice # Call [Enum]::GetValues([RubrikSecurityCloud.Types.MigrationChoice]) for enum values.
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: RegisterAndEnableMigrationReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the RemoveDisk operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: RemoveDisk
    /// 
    /// $query = New-RscMutationMisc -RemoveDisk
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	diskId = $someString
    /// 	# REQUIRED
    /// 	id = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: ResponseSuccess
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the RemoveInventoryWorkloads operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: RemoveInventoryWorkloads
    /// 
    /// $query = New-RscMutationMisc -RemoveInventoryWorkloads
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	inventoryCards = @(
    /// 		$someInventoryCard # Call [Enum]::GetValues([RubrikSecurityCloud.Types.InventoryCard]) for enum values.
    /// 	)
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: System.Boolean
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the RemoveNodeForReplacement operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: RemoveNodeForReplacement
    /// 
    /// $query = New-RscMutationMisc -RemoveNodeForReplacement
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	nodeIds = @(
    /// 		$someString
    /// 	)
    /// 	# OPTIONAL
    /// 	useQuickDrain = $someBoolean
    /// 	# REQUIRED
    /// 	clusterUuid = $someString
    /// 	# OPTIONAL
    /// 	nodeMetadata = @(
    /// 		@{
    /// 			# OPTIONAL
    /// 			nodeId = $someString
    /// 			# OPTIONAL
    /// 			chassisId = $someString
    /// 			# OPTIONAL
    /// 			platform = $someClusterNodePlatformType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ClusterNodePlatformType]) for enum values.
    /// 			# OPTIONAL
    /// 			status = $someClusterNodeStatus # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ClusterNodeStatus]) for enum values.
    /// 			# OPTIONAL
    /// 			useQuickDrain = $someBoolean
    /// 		}
    /// 	)
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: RemoveNodeForReplacementReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the RemovePrivateEndpointList operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: RemovePrivateEndpointList
    /// 
    /// $query = New-RscMutationMisc -RemovePrivateEndpointList
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	locationId = $someString
    /// 	# REQUIRED
    /// 	privateEndpointId = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: System.String
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the RemoveProxyConfig operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: RemoveProxyConfig
    /// 
    /// $query = New-RscMutationMisc -RemoveProxyConfig
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	clusterUuid = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: ResponseSuccess
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the RemoveVlans operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: RemoveVlans
    /// 
    /// $query = New-RscMutationMisc -RemoveVlans
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	id = $someString
    /// 	# REQUIRED
    /// 	vlanIds = @(
    /// 		$someInt
    /// 	)
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: RemoveVlansReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the ReseedLogShippingSecondary operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: ReseedLogShippingSecondary
    /// 
    /// $query = New-RscMutationMisc -ReseedLogShippingSecondary
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	config = @{
    /// 		# OPTIONAL
    /// 		mssqlLogShippingTargetStateOptions = @{
    /// 			# OPTIONAL
    /// 			shouldDisconnectStandbyUsers = $someBoolean
    /// 			# REQUIRED
    /// 			state = $someMssqlLogShippingOkState # Call [Enum]::GetValues([RubrikSecurityCloud.Types.MssqlLogShippingOkState]) for enum values.
    /// 		}
    /// 	}
    /// 	# REQUIRED
    /// 	id = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AsyncRequestStatus
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the ResetAllOrgUsersPasswords operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: ResetAllOrgUsersPasswords
    /// 
    /// $query = New-RscMutationMisc -ResetAllOrgUsersPasswords
    /// 
    /// # No variables for this query.
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: System.String
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the ResetMigrationOnModeChange operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: ResetMigrationOnModeChange
    /// 
    /// $query = New-RscMutationMisc -ResetMigrationOnModeChange
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	clusterUuid = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: ResetMigrationOnModeChangeReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the ResetPasskeys operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: ResetPasskeys
    /// 
    /// $query = New-RscMutationMisc -ResetPasskeys
    /// 
    /// # REQUIRED
    /// $query.Var.userId = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: System.String
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the ResetUsersPasswordsWithUserIds operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: ResetUsersPasswordsWithUserIds
    /// 
    /// $query = New-RscMutationMisc -ResetUsersPasswordsWithUserIds
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	userIds = @(
    /// 		$someString
    /// 	)
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: System.String
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the ResizeDisk operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: ResizeDisk
    /// 
    /// $query = New-RscMutationMisc -ResizeDisk
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	diskId = $someString
    /// 	# REQUIRED
    /// 	id = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: ResponseSuccess
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the ResolveAnomaly operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: ResolveAnomaly
    /// 
    /// $query = New-RscMutationMisc -ResolveAnomaly
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	anomalyType = $someAnomalyType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AnomalyType]) for enum values.
    /// 	# REQUIRED
    /// 	workloadId = $someString
    /// 	# REQUIRED
    /// 	anomalyId = $someString
    /// 	# OPTIONAL
    /// 	falsePositiveReport = @{
    /// 		# REQUIRED
    /// 		falsePositiveType = $someAnomalyFalsePositiveType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AnomalyFalsePositiveType]) for enum values.
    /// 		# OPTIONAL
    /// 		otherReason = $someString
    /// 	}
    /// 	# OPTIONAL
    /// 	directoriesToSnooze = @(
    /// 		$someString
    /// 	)
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: System.String
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the ResolveVolumeGroupsConflict operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: ResolveVolumeGroupsConflict
    /// 
    /// $query = New-RscMutationMisc -ResolveVolumeGroupsConflict
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	clusterUuid = $someString
    /// 	# REQUIRED
    /// 	id = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: RequestSuccess
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the RestoreConfigProtectionBackup operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: RestoreConfigProtectionBackup
    /// 
    /// $query = New-RscMutationMisc -RestoreConfigProtectionBackup
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	backupClusterUuid = $someString
    /// 	# REQUIRED
    /// 	restoreBackupRequestDetails = @{
    /// 		# REQUIRED
    /// 		clusterUuid = $someString
    /// 		# REQUIRED
    /// 		configRestoreRequest = @{
    /// 			# OPTIONAL
    /// 			isSourceSafe = $someBoolean
    /// 			# REQUIRED
    /// 			backupFileName = $someString
    /// 			# REQUIRED
    /// 			customizedRestoreForm = @{
    /// 				# REQUIRED
    /// 				configurationTypes = @(
    /// 					$someConfigurationTypes # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ConfigurationTypes]) for enum values.
    /// 				)
    /// 				# REQUIRED
    /// 				configurations = @{
    /// 					# OPTIONAL
    /// 					guestOsCredentials = @(
    /// 						@{
    /// 							# OPTIONAL
    /// 							password = $someString
    /// 							# OPTIONAL
    /// 							restoreFormConfigurationGuestOs = @{
    /// 								# OPTIONAL
    /// 								domain = $someString
    /// 								# REQUIRED
    /// 								username = $someString
    /// 							}
    /// 						}
    /// 					)
    /// 					# OPTIONAL
    /// 					kmipClient = @{
    /// 						# OPTIONAL
    /// 						password = $someString
    /// 						# OPTIONAL
    /// 						username = $someString
    /// 					}
    /// 					# OPTIONAL
    /// 					kmipServers = @(
    /// 						@{
    /// 							# REQUIRED
    /// 							serverAddress = $someString
    /// 						}
    /// 					)
    /// 					# OPTIONAL
    /// 					ldapServers = @(
    /// 						@{
    /// 							# OPTIONAL
    /// 							bindUserName = $someString
    /// 							# OPTIONAL
    /// 							bindUserPassword = $someString
    /// 							# OPTIONAL
    /// 							restoreFormConfigurationLdapServer = @{
    /// 								# REQUIRED
    /// 								name = $someString
    /// 							}
    /// 						}
    /// 					)
    /// 					# OPTIONAL
    /// 					nasHosts = @(
    /// 						@{
    /// 							# OPTIONAL
    /// 							apiPassword = $someString
    /// 							# OPTIONAL
    /// 							sharePassword = $someString
    /// 							# OPTIONAL
    /// 							shareUsername = $someString
    /// 							# OPTIONAL
    /// 							restoreFormConfigurationNasHost = @{
    /// 								# REQUIRED
    /// 								hostname = $someString
    /// 							}
    /// 							# OPTIONAL
    /// 							shares = @(
    /// 								@{
    /// 									# OPTIONAL
    /// 									password = $someString
    /// 									# OPTIONAL
    /// 									username = $someString
    /// 									# OPTIONAL
    /// 									restoreFormConfigurationNasShare = @{
    /// 										# REQUIRED
    /// 										exportPoint = $someString
    /// 									}
    /// 								}
    /// 							)
    /// 						}
    /// 					)
    /// 					# OPTIONAL
    /// 					objectStoreArchivalLocations = @(
    /// 						@{
    /// 							# OPTIONAL
    /// 							pemFileContent = $someString
    /// 							# OPTIONAL
    /// 							secretKey = $someString
    /// 							# OPTIONAL
    /// 							accessKey = $someString
    /// 							# OPTIONAL
    /// 							shouldRecoverSnappableMetadataOnly = $someBoolean
    /// 							# OPTIONAL
    /// 							restoreFormConfigurationObjectStoreArchivalLocation = @{
    /// 								# OPTIONAL
    /// 								bucket = $someString
    /// 								# OPTIONAL
    /// 								encryptionType = $someString
    /// 								# OPTIONAL
    /// 								endpoint = $someString
    /// 								# OPTIONAL
    /// 								numBuckets = $someInt64
    /// 								# REQUIRED
    /// 								name = $someString
    /// 							}
    /// 						}
    /// 					)
    /// 					# OPTIONAL
    /// 					organizations = @(
    /// 						@{
    /// 							# REQUIRED
    /// 							name = $someString
    /// 						}
    /// 					)
    /// 					# OPTIONAL
    /// 					replicationTargets = @(
    /// 						@{
    /// 							# OPTIONAL
    /// 							caCerts = $someString
    /// 							# REQUIRED
    /// 							password = $someString
    /// 							# OPTIONAL
    /// 							restoreFormConfigurationReplicationTarget = @{
    /// 								# OPTIONAL
    /// 								targetClusterName = $someString
    /// 								# REQUIRED
    /// 								targetClusterAddress = $someString
    /// 							}
    /// 							# REQUIRED
    /// 							username = $someString
    /// 						}
    /// 					)
    /// 					# OPTIONAL
    /// 					reports = @(
    /// 						@{
    /// 							# REQUIRED
    /// 							name = $someString
    /// 						}
    /// 					)
    /// 					# OPTIONAL
    /// 					roles = @(
    /// 						@{
    /// 							# REQUIRED
    /// 							name = $someString
    /// 							# REQUIRED
    /// 							organizationName = $someString
    /// 						}
    /// 					)
    /// 					# OPTIONAL
    /// 					s3ArchivalLocations = @(
    /// 						@{
    /// 							# OPTIONAL
    /// 							kmsMasterKeyId = $someString
    /// 							# OPTIONAL
    /// 							pemFileContent = $someString
    /// 							# OPTIONAL
    /// 							secretKey = $someString
    /// 							# OPTIONAL
    /// 							accessKey = $someString
    /// 							# OPTIONAL
    /// 							encryptionPassword = $someString
    /// 							# OPTIONAL
    /// 							shouldRecoverSnappableMetadataOnly = $someBoolean
    /// 							# OPTIONAL
    /// 							archivalProxyConfig = @{
    /// 								# OPTIONAL
    /// 								password = $someString
    /// 								# OPTIONAL
    /// 								userName = $someString
    /// 								# OPTIONAL
    /// 								restoreFormArchivalProxyConfig = @{
    /// 									# OPTIONAL
    /// 									proxyServer = $someString
    /// 								}
    /// 							}
    /// 							# OPTIONAL
    /// 							computeProxyConfig = @{
    /// 								# OPTIONAL
    /// 								password = $someString
    /// 								# OPTIONAL
    /// 								userName = $someString
    /// 								# OPTIONAL
    /// 								restoreFormComputeProxyConfig = @{
    /// 									# OPTIONAL
    /// 									proxyServer = $someString
    /// 								}
    /// 							}
    /// 							# OPTIONAL
    /// 							restoreFormConfigurationS3ArchivalLocation = @{
    /// 								# OPTIONAL
    /// 								bucket = $someString
    /// 								# OPTIONAL
    /// 								defaultRegion = $someString
    /// 								# OPTIONAL
    /// 								encryptionType = $someString
    /// 								# OPTIONAL
    /// 								cloudRehydrationSpeed = $someString
    /// 								# OPTIONAL
    /// 								storageClass = $someString
    /// 								# OPTIONAL
    /// 								archivalProxyConfig = @{
    /// 									# OPTIONAL
    /// 									proxyServer = $someString
    /// 								}
    /// 								# OPTIONAL
    /// 								computeProxyConfig = @{
    /// 									# OPTIONAL
    /// 									proxyServer = $someString
    /// 								}
    /// 								# REQUIRED
    /// 								name = $someString
    /// 							}
    /// 						}
    /// 					)
    /// 					# OPTIONAL
    /// 					slaDomains = @(
    /// 						@{
    /// 							# REQUIRED
    /// 							name = $someString
    /// 						}
    /// 					)
    /// 					# OPTIONAL
    /// 					smtpSettings = @(
    /// 						@{
    /// 							# OPTIONAL
    /// 							smtpPassword = $someString
    /// 							# OPTIONAL
    /// 							smtpUsername = $someString
    /// 							# OPTIONAL
    /// 							restoreFormConfigurationSmtp = @{
    /// 								# REQUIRED
    /// 								fromEmailId = $someString
    /// 								# REQUIRED
    /// 								smtpHostname = $someString
    /// 								# REQUIRED
    /// 								smtpPort = $someInt64
    /// 							}
    /// 						}
    /// 					)
    /// 					# OPTIONAL
    /// 					snmpSettings = @(
    /// 						@{
    /// 							# OPTIONAL
    /// 							authPassword = $someString
    /// 							# OPTIONAL
    /// 							privPassword = $someString
    /// 							# OPTIONAL
    /// 							restoreFormConfigurationSnmp = @{
    /// 								# REQUIRED
    /// 								username = $someString
    /// 							}
    /// 						}
    /// 					)
    /// 					# OPTIONAL
    /// 					users = @(
    /// 						@{
    /// 							# OPTIONAL
    /// 							password = $someString
    /// 							# OPTIONAL
    /// 							restoreFormConfigurationUser = @{
    /// 								# REQUIRED
    /// 								username = $someString
    /// 							}
    /// 						}
    /// 					)
    /// 					# OPTIONAL
    /// 					vcenterServers = @(
    /// 						@{
    /// 							# OPTIONAL
    /// 							password = $someString
    /// 							# OPTIONAL
    /// 							username = $someString
    /// 							# OPTIONAL
    /// 							restoreFormConfigurationVcenterServer = @{
    /// 								# REQUIRED
    /// 								hostname = $someString
    /// 							}
    /// 						}
    /// 					)
    /// 					# OPTIONAL
    /// 					winAndUnixHosts = @(
    /// 						@{
    /// 							# REQUIRED
    /// 							hostname = $someString
    /// 						}
    /// 					)
    /// 				}
    /// 			}
    /// 			# REQUIRED
    /// 			encryptionPassword = $someString
    /// 		}
    /// 	}
    /// 	# OPTIONAL
    /// 	caSignedCsr = $someString
    /// 	# OPTIONAL
    /// 	useDefaultConfigurations = $someBoolean
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AsyncJobStatus
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the RetryBackup operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: RetryBackup
    /// 
    /// $query = New-RscMutationMisc -RetryBackup
    /// 
    /// # REQUIRED
    /// $query.Var.backupObjects = @(
    /// 	@{
    /// 		# OPTIONAL
    /// 		objectFid = $someString
    /// 		# OPTIONAL
    /// 		eventSeriesId = $someString
    /// 		# OPTIONAL
    /// 		monitoringId = $someString
    /// }
    /// )
    /// # OPTIONAL
    /// $query.Var.backupRunConfig = @{
    /// 	# OPTIONAL
    /// 	runNow = $someBoolean
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: RetryBackupResp
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the RetryDownloadPackageJob operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: RetryDownloadPackageJob
    /// 
    /// $query = New-RscMutationMisc -RetryDownloadPackageJob
    /// 
    /// # REQUIRED
    /// $query.Var.clusterUuid = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: DownloadPackageReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the RevokeAllOrgRoles operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: RevokeAllOrgRoles
    /// 
    /// $query = New-RscMutationMisc -RevokeAllOrgRoles
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	userIds = @(
    /// 		$someString
    /// 	)
    /// 	# OPTIONAL
    /// 	groupIds = @(
    /// 		$someString
    /// 	)
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: System.String
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the RunCustomAnalyzer operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: RunCustomAnalyzer
    /// 
    /// $query = New-RscMutationMisc -RunCustomAnalyzer
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	dictionaryCsv = $someString
    /// 	# OPTIONAL
    /// 	regex = $someString
    /// 	# OPTIONAL
    /// 	content = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: RunCustomAnalyzerReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the RunPrechecks operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: RunPrechecks
    /// 
    /// $query = New-RscMutationMisc -RunPrechecks
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	clusterUuid = $someString
    /// 	# REQUIRED
    /// 	precheckNames = @(
    /// 		$somePrecheckName # Call [Enum]::GetValues([RubrikSecurityCloud.Types.PrecheckName]) for enum values.
    /// 	)
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: BatchAsyncJobStatus
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the ScheduleUpgradeBatchJob operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: ScheduleUpgradeBatchJob
    /// 
    /// $query = New-RscMutationMisc -ScheduleUpgradeBatchJob
    /// 
    /// # REQUIRED
    /// $query.Var.listClusterUuid = @(
    /// 	$someString
    /// )
    /// # REQUIRED
    /// $query.Var.mode = $someString
    /// # REQUIRED
    /// $query.Var.action = $someActionType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ActionType]) for enum values.
    /// # REQUIRED
    /// $query.Var.version = $someString
    /// # REQUIRED
    /// $query.Var.scheduleAt = $someDateTime
    /// # OPTIONAL
    /// $query.Var.context_tag = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: List&lt;UpgradeJobReplyWithUuid&gt;
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the SendEmailNow operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: SendEmailNow
    /// 
    /// $query = New-RscMutationMisc -SendEmailNow
    /// 
    /// # REQUIRED
    /// $query.Var.reportID = $someInt
    /// # OPTIONAL
    /// $query.Var.reportConfig = @{
    /// 	# REQUIRED
    /// 	name = $someString
    /// 	# REQUIRED
    /// 	dataViewType = $someDataViewTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DataViewTypeEnum]) for enum values.
    /// 	# REQUIRED
    /// 	columns = @(
    /// 		$someString
    /// 	)
    /// 	# REQUIRED
    /// 	groupBy = @{
    /// 		# REQUIRED
    /// 		groupById = $someString
    /// 		# REQUIRED
    /// 		aggregations = @(
    /// 			$someString
    /// 		)
    /// 	}
    /// 	# REQUIRED
    /// 	aggregations = @(
    /// 		$someString
    /// 	)
    /// 	# REQUIRED
    /// 	filters = @(
    /// 		@{
    /// 			# REQUIRED
    /// 			name = $someString
    /// 			# REQUIRED
    /// 			values = @(
    /// 				$someString
    /// 			)
    /// 		}
    /// 	)
    /// 	# REQUIRED
    /// 	sortBy = $someString
    /// 	# OPTIONAL
    /// 	sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
    /// }
    /// # REQUIRED
    /// $query.Var.recipients = @(
    /// 	$someString
    /// )
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: ReportGenerateReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the SendPactsafeEvent operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: SendPactsafeEvent
    /// 
    /// $query = New-RscMutationMisc -SendPactsafeEvent
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	contractType = $someContractType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ContractType]) for enum values.
    /// 	# REQUIRED
    /// 	versionId = $someString
    /// 	# REQUIRED
    /// 	event = $somePactsafeEvent # Call [Enum]::GetValues([RubrikSecurityCloud.Types.PactsafeEvent]) for enum values.
    /// 	# OPTIONAL
    /// 	customData = @{
    /// 		# REQUIRED
    /// 		firstName = $someString
    /// 		# REQUIRED
    /// 		lastName = $someString
    /// 		# REQUIRED
    /// 		company = $someString
    /// 		# REQUIRED
    /// 		title = $someString
    /// 	}
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: System.String
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the SendTestSmtpEmail operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: SendTestSmtpEmail
    /// 
    /// $query = New-RscMutationMisc -SendTestSmtpEmail
    /// 
    /// # REQUIRED
    /// $query.Var.useExisting = $someBoolean
    /// # REQUIRED
    /// $query.Var.recipient = $someString
    /// # OPTIONAL
    /// $query.Var.hostName = $someString
    /// # OPTIONAL
    /// $query.Var.port = $someInt
    /// # OPTIONAL
    /// $query.Var.userName = $someString
    /// # OPTIONAL
    /// $query.Var.password = $someString
    /// # OPTIONAL
    /// $query.Var.defaultFromEmail = $someString
    /// # OPTIONAL
    /// $query.Var.securityType = $someSMTPSecurityTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SMTPSecurityTypeEnum]) for enum values.
    /// # OPTIONAL
    /// $query.Var.trustedCertId = $someInt64
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: System.Boolean
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the SetAccountSettingValue operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: SetAccountSettingValue
    /// 
    /// $query = New-RscMutationMisc -SetAccountSettingValue
    /// 
    /// # REQUIRED
    /// $query.Var.aspName = $someString
    /// # REQUIRED
    /// $query.Var.aspComponent = $someComponentEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ComponentEnum]) for enum values.
    /// # REQUIRED
    /// $query.Var.aspValue = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AspValue
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the SetAnalyzerRisks operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: SetAnalyzerRisks
    /// 
    /// $query = New-RscMutationMisc -SetAnalyzerRisks
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	risks = @(
    /// 		@{
    /// 			# OPTIONAL
    /// 			analyzerId = $someString
    /// 			# OPTIONAL
    /// 			risk = $someRiskLevelType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RiskLevelType]) for enum values.
    /// 		}
    /// 	)
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: SetAnalyzerRisksReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the SetBrandLogo operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: SetBrandLogo
    /// 
    /// $query = New-RscMutationMisc -SetBrandLogo
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	imageBase64 = $someString
    /// 	# OPTIONAL
    /// 	fileName = $someString
    /// 	# OPTIONAL
    /// 	fileSizeBytes = $someInt
    /// 	# OPTIONAL
    /// 	isUrlEnabled = $someBoolean
    /// 	# OPTIONAL
    /// 	url = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: System.String
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the SetBundleApprovalStatus operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: SetBundleApprovalStatus
    /// 
    /// $query = New-RscMutationMisc -SetBundleApprovalStatus
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	bundleVersion = $someString
    /// 	# REQUIRED
    /// 	approvalStatus = $someExoBundleApprovalStatus # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ExoBundleApprovalStatus]) for enum values.
    /// 	# OPTIONAL
    /// 	bundleMetadata = @{
    /// 		# OPTIONAL
    /// 		eksVersion = $someString
    /// 	}
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: System.String
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the SetCorsSetting operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: SetCorsSetting
    /// 
    /// $query = New-RscMutationMisc -SetCorsSetting
    /// 
    /// # OPTIONAL
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	isEnabled = $someBoolean
    /// 	# OPTIONAL
    /// 	allowedOrigins = @(
    /// 		$someString
    /// 	)
    /// 	# OPTIONAL
    /// 	allowedHeaders = @(
    /// 		$someString
    /// 	)
    /// 	# OPTIONAL
    /// 	allowedMethods = @(
    /// 		$someHttpMethod # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HttpMethod]) for enum values.
    /// 	)
    /// 	# OPTIONAL
    /// 	allowedPaths = @(
    /// 		$someString
    /// 	)
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: CorsSetting
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the SetCustomerTags operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: SetCustomerTags
    /// 
    /// $query = New-RscMutationMisc -SetCustomerTags
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	cloudVendor = $someCloudVendor # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudVendor]) for enum values.
    /// 	# REQUIRED
    /// 	customerTags = @{
    /// 		# REQUIRED
    /// 		tagList = @(
    /// 			@{
    /// 				# REQUIRED
    /// 				key = $someString
    /// 				# REQUIRED
    /// 				value = $someString
    /// 			}
    /// 		)
    /// 	}
    /// 	# REQUIRED
    /// 	shouldOverrideResourceTags = $someBoolean
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: System.String
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the SetDatastoreFreespaceThresholds operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: SetDatastoreFreespaceThresholds
    /// 
    /// $query = New-RscMutationMisc -SetDatastoreFreespaceThresholds
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	thresholds = @(
    /// 		@{
    /// 			# REQUIRED
    /// 			clusterUuid = $someString
    /// 			# REQUIRED
    /// 			datastoreFreespaceThreshold = @{
    /// 				# OPTIONAL
    /// 				vmId = $someString
    /// 				# REQUIRED
    /// 				threshold = $someSingle
    /// 			}
    /// 		}
    /// 	)
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: SetDatastoreFreespaceThresholdsReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the SetFederatedLoginStatus operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: SetFederatedLoginStatus
    /// 
    /// $query = New-RscMutationMisc -SetFederatedLoginStatus
    /// 
    /// # REQUIRED
    /// $query.Var.federatedLoginStatusArg = @{
    /// 	# REQUIRED
    /// 	enabled = $someBoolean
    /// 	# REQUIRED
    /// 	inventoryCardEnabled = $someBoolean
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: System.Boolean
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the SetIdentityProvider operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: SetIdentityProvider
    /// 
    /// $query = New-RscMutationMisc -SetIdentityProvider
    /// 
    /// # REQUIRED
    /// $query.Var.entityId = $someString
    /// # REQUIRED
    /// $query.Var.signInUrl = $someString
    /// # REQUIRED
    /// $query.Var.signingCertificate = $someString
    /// # OPTIONAL
    /// $query.Var.metadataJson = $someString
    /// # OPTIONAL
    /// $query.Var.isTemp = $someBoolean
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: IdentityProvider
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the SetIpWhitelistEnabled operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: SetIpWhitelistEnabled
    /// 
    /// $query = New-RscMutationMisc -SetIpWhitelistEnabled
    /// 
    /// # REQUIRED
    /// $query.Var.enabled = $someBoolean
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: System.Boolean
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the SetKmipClient operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: SetKmipClient
    /// 
    /// $query = New-RscMutationMisc -SetKmipClient
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	config = @{
    /// 		# OPTIONAL
    /// 		clientCertificate = $someString
    /// 		# OPTIONAL
    /// 		password = $someString
    /// 		# OPTIONAL
    /// 		clientCertificateId = $someString
    /// 		# REQUIRED
    /// 		username = $someString
    /// 	}
    /// 	# REQUIRED
    /// 	id = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AsyncRequestStatus
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the SetLiveMountIps operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: SetLiveMountIps
    /// 
    /// $query = New-RscMutationMisc -SetLiveMountIps
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	orgNetworkID = $someString
    /// 	# REQUIRED
    /// 	liveMountIps = @(
    /// 		$someString
    /// 	)
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: System.String
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the SetMfaSetting operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: SetMfaSetting
    /// 
    /// $query = New-RscMutationMisc -SetMfaSetting
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	isTotpEnforcedGlobal = $someBoolean
    /// 	# OPTIONAL
    /// 	totpReminderHours = $someInt
    /// 	# OPTIONAL
    /// 	mfaRememberHours = $someInt
    /// 	# OPTIONAL
    /// 	passkeyConfig = @{
    /// 		# REQUIRED
    /// 		passkeysAllowed = $someBoolean
    /// 		# REQUIRED
    /// 		platformPasskeyAllowed = $someBoolean
    /// 		# REQUIRED
    /// 		roamingPasskeyAllowed = $someBoolean
    /// 		# REQUIRED
    /// 		maxPasskeysAllowed = $someInt
    /// 	}
    /// 	# OPTIONAL
    /// 	deletePasskeys = $someBoolean
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: System.Boolean
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the SetMigrationStatus operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: SetMigrationStatus
    /// 
    /// $query = New-RscMutationMisc -SetMigrationStatus
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	clusterUuid = $someString
    /// 	# REQUIRED
    /// 	precheckName = $somePrecheckName # Call [Enum]::GetValues([RubrikSecurityCloud.Types.PrecheckName]) for enum values.
    /// 	# REQUIRED
    /// 	migrationStatus = $someMigrationStatus # Call [Enum]::GetValues([RubrikSecurityCloud.Types.MigrationStatus]) for enum values.
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: SetMigrationStatusReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the SetPasskeyConfig operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: SetPasskeyConfig
    /// 
    /// $query = New-RscMutationMisc -SetPasskeyConfig
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	passkeyConfig = @{
    /// 		# REQUIRED
    /// 		passkeysAllowed = $someBoolean
    /// 		# REQUIRED
    /// 		platformPasskeyAllowed = $someBoolean
    /// 		# REQUIRED
    /// 		roamingPasskeyAllowed = $someBoolean
    /// 		# REQUIRED
    /// 		maxPasskeysAllowed = $someInt
    /// 	}
    /// 	# REQUIRED
    /// 	deletePasskeys = $someBoolean
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: SetPasskeyConfigReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the SetPrivateContainerRegistry operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: SetPrivateContainerRegistry
    /// 
    /// $query = New-RscMutationMisc -SetPrivateContainerRegistry
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	exocomputeAccountId = $someString
    /// 	# REQUIRED
    /// 	registryUrl = $someString
    /// 	# OPTIONAL
    /// 	pcrAwsImagePullDetails = @{
    /// 		# OPTIONAL
    /// 		awsNativeId = $someString
    /// 	}
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: System.String
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the SetSmtpConfiguration operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: SetSmtpConfiguration
    /// 
    /// $query = New-RscMutationMisc -SetSmtpConfiguration
    /// 
    /// # REQUIRED
    /// $query.Var.hostName = $someString
    /// # REQUIRED
    /// $query.Var.port = $someInt
    /// # REQUIRED
    /// $query.Var.userName = $someString
    /// # REQUIRED
    /// $query.Var.password = $someString
    /// # REQUIRED
    /// $query.Var.defaultFromEmail = $someString
    /// # REQUIRED
    /// $query.Var.securityType = $someSMTPSecurityTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SMTPSecurityTypeEnum]) for enum values.
    /// # REQUIRED
    /// $query.Var.trustedCertId = $someInt64
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: System.Boolean
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the SetTotpConfig operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: SetTotpConfig
    /// 
    /// $query = New-RscMutationMisc -SetTotpConfig
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	userId = $someString
    /// 	# OPTIONAL
    /// 	secret = $someString
    /// 	# OPTIONAL
    /// 	otp = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: System.Boolean
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the SetUpgradeType operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: SetUpgradeType
    /// 
    /// $query = New-RscMutationMisc -SetUpgradeType
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	clusterUuid = $someString
    /// 	# REQUIRED
    /// 	upgradeType = $someUpgradeType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UpgradeType]) for enum values.
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: SetUpgradeTypeReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the SetUserLevelTotpEnforcement operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: SetUserLevelTotpEnforcement
    /// 
    /// $query = New-RscMutationMisc -SetUserLevelTotpEnforcement
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	userIds = @(
    /// 		$someString
    /// 	)
    /// 	# OPTIONAL
    /// 	isEnforced = $someBoolean
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: System.Boolean
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the SetUserSessionManagementConfig operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: SetUserSessionManagementConfig
    /// 
    /// $query = New-RscMutationMisc -SetUserSessionManagementConfig
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	isConcurrentSessionLimitationEnabled = $someBoolean
    /// 	# REQUIRED
    /// 	inactivityTimeoutInSeconds = $someInt64
    /// 	# REQUIRED
    /// 	isInactivityTimeoutEnabled = $someBoolean
    /// 	# REQUIRED
    /// 	maxConcurrentSessions = $someInt
    /// 	# REQUIRED
    /// 	sessionTimeoutInSeconds = $someInt64
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: SetUserSessionManagementConfigReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the SetUserSetting operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: SetUserSetting
    /// 
    /// $query = New-RscMutationMisc -SetUserSetting
    /// 
    /// # OPTIONAL
    /// $query.Var.userSetting = @{
    /// 	# OPTIONAL
    /// 	setting = $someString
    /// 	# OPTIONAL
    /// 	value = $someString
    /// }
    /// # REQUIRED
    /// $query.Var.isOrgSpecificSetting = $someBoolean
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: UserSetting
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the SetWorkloadAlertSetting operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: SetWorkloadAlertSetting
    /// 
    /// $query = New-RscMutationMisc -SetWorkloadAlertSetting
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	clusterId = $someString
    /// 	# OPTIONAL
    /// 	workloadFid = $someString
    /// 	# OPTIONAL
    /// 	enabled = $someBoolean
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: SetWorkloadAlertSettingReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the SetWwwTlsCert operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: SetWwwTlsCert
    /// 
    /// $query = New-RscMutationMisc -SetWwwTlsCert
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	certificateId = $someInt64
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: System.Boolean
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the SetupAtlassianSite operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: SetupAtlassianSite
    /// 
    /// $query = New-RscMutationMisc -SetupAtlassianSite
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	siteId = $someString
    /// 	# REQUIRED
    /// 	siteName = $someString
    /// 	# OPTIONAL
    /// 	slaDomainId = $someString
    /// 	# REQUIRED
    /// 	storageRegion = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: SetupAtlassianSiteReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the SetupDisk operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: SetupDisk
    /// 
    /// $query = New-RscMutationMisc -SetupDisk
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	diskId = $someString
    /// 	# REQUIRED
    /// 	id = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: DiskInfo
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the SetupSalesforceOrganization operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: SetupSalesforceOrganization
    /// 
    /// $query = New-RscMutationMisc -SetupSalesforceOrganization
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	orgNaturalId = $someString
    /// 	# REQUIRED
    /// 	orgName = $someString
    /// 	# OPTIONAL
    /// 	slaDomainId = $someString
    /// 	# REQUIRED
    /// 	storageRegion = $someString
    /// 	# REQUIRED
    /// 	apiLimits = @{
    /// 		# OPTIONAL
    /// 		restApiLimit = $someInt
    /// 		# OPTIONAL
    /// 		bulkApiLimit = $someInt
    /// 		# OPTIONAL
    /// 		bulkApiV2Limit = $someInt
    /// 	}
    /// 	# REQUIRED
    /// 	environmentType = $someSaasEnvironmentType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SaasEnvironmentType]) for enum values.
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: SetupSalesforceOrganizationReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the SnoozeEula operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: SnoozeEula
    /// 
    /// $query = New-RscMutationMisc -SnoozeEula
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	durationInDays = $someInt64
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: System.String
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the StartBlueprintFailover operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: StartBlueprintFailover
    /// 
    /// $query = New-RscMutationMisc -StartBlueprintFailover
    /// 
    /// # REQUIRED
    /// $query.Var.failoverJobConfig = @{
    /// 	# REQUIRED
    /// 	blueprintId = $someString
    /// 	# OPTIONAL
    /// 	recoveryName = $someString
    /// 	# OPTIONAL
    /// 	targetLocationType = $someLocationType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.LocationType]) for enum values.
    /// 	# OPTIONAL
    /// 	targetLocationUuid = $someString
    /// 	# REQUIRED
    /// 	failoverType = $someString
    /// 	# OPTIONAL
    /// 	failoverFailureAction = $someString
    /// 	# OPTIONAL
    /// 	failoverOperation = $someString
    /// 	# OPTIONAL
    /// 	dataTransferType = $someDataTransferType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DataTransferType]) for enum values.
    /// 	# OPTIONAL
    /// 	childSnappableFailoverInfos = @(
    /// 		@{
    /// 			# REQUIRED
    /// 			snappableId = $someString
    /// 			# REQUIRED
    /// 			recoveryPoint = $someInt64
    /// 		}
    /// 	)
    /// 	# OPTIONAL
    /// 	failoverIgnorableErrors = @(
    /// 		$someBlueprintFailoverIgnorableError # Call [Enum]::GetValues([RubrikSecurityCloud.Types.BlueprintFailoverIgnorableError]) for enum values.
    /// 	)
    /// 	# OPTIONAL
    /// 	enableRecoveryWithRba = $someBoolean
    /// 	# OPTIONAL
    /// 	recoveryPlanId = $someString
    /// 	# OPTIONAL
    /// 	recoverySpecID = $someString
    /// 	# OPTIONAL
    /// 	isZeroRpo = $someBoolean
    /// 	# OPTIONAL
    /// 	timeoutInMinutes = $someInt
    /// 	# OPTIONAL
    /// 	updateRecoverySpecPostFailover = $someBoolean
    /// 	# OPTIONAL
    /// 	sourceWorkloadActionAfterFailover = $someSourceWorkloadActionAfterFailover # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SourceWorkloadActionAfterFailover]) for enum values.
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: CreateOnDemandJobReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the StartBlueprintsFailover operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: StartBlueprintsFailover
    /// 
    /// $query = New-RscMutationMisc -StartBlueprintsFailover
    /// 
    /// # REQUIRED
    /// $query.Var.failoverJobConfigs = @(
    /// 	@{
    /// 		# REQUIRED
    /// 		blueprintId = $someString
    /// 		# OPTIONAL
    /// 		recoveryName = $someString
    /// 		# OPTIONAL
    /// 		targetLocationType = $someLocationType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.LocationType]) for enum values.
    /// 		# OPTIONAL
    /// 		targetLocationUuid = $someString
    /// 		# REQUIRED
    /// 		failoverType = $someString
    /// 		# OPTIONAL
    /// 		failoverFailureAction = $someString
    /// 		# OPTIONAL
    /// 		failoverOperation = $someString
    /// 		# OPTIONAL
    /// 		dataTransferType = $someDataTransferType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DataTransferType]) for enum values.
    /// 		# OPTIONAL
    /// 		childSnappableFailoverInfos = @(
    /// 			@{
    /// 				# REQUIRED
    /// 				snappableId = $someString
    /// 				# REQUIRED
    /// 				recoveryPoint = $someInt64
    /// 			}
    /// 		)
    /// 		# OPTIONAL
    /// 		failoverIgnorableErrors = @(
    /// 			$someBlueprintFailoverIgnorableError # Call [Enum]::GetValues([RubrikSecurityCloud.Types.BlueprintFailoverIgnorableError]) for enum values.
    /// 		)
    /// 		# OPTIONAL
    /// 		enableRecoveryWithRba = $someBoolean
    /// 		# OPTIONAL
    /// 		recoveryPlanId = $someString
    /// 		# OPTIONAL
    /// 		recoverySpecID = $someString
    /// 		# OPTIONAL
    /// 		isZeroRpo = $someBoolean
    /// 		# OPTIONAL
    /// 		timeoutInMinutes = $someInt
    /// 		# OPTIONAL
    /// 		updateRecoverySpecPostFailover = $someBoolean
    /// 		# OPTIONAL
    /// 		sourceWorkloadActionAfterFailover = $someSourceWorkloadActionAfterFailover # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SourceWorkloadActionAfterFailover]) for enum values.
    /// }
    /// )
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: List&lt;CreateOnDemandJobReply&gt;
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the StartBulkRecovery operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: StartBulkRecovery
    /// 
    /// $query = New-RscMutationMisc -StartBulkRecovery
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	definition = @{
    /// 		# REQUIRED
    /// 		name = $someString
    /// 		# OPTIONAL
    /// 		o365GroupSelectorWithRecoverySpec = @{
    /// 			# OPTIONAL
    /// 			groupName = $someString
    /// 			# REQUIRED
    /// 			baseInfo = @{
    /// 				# REQUIRED
    /// 				snappableType = $someWorkloadType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.WorkloadType]) for enum values.
    /// 				# REQUIRED
    /// 				subSnappableType = $someSubWorkloadType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SubWorkloadType]) for enum values.
    /// 				# REQUIRED
    /// 				recoverySpec = @{
    /// 					# OPTIONAL
    /// 					inplaceRecoverySpec = @{
    /// 						# OPTIONAL
    /// 						nameCollisionRule = $someInplaceCollisionRule # Call [Enum]::GetValues([RubrikSecurityCloud.Types.InplaceCollisionRule]) for enum values.
    /// 					}
    /// 					# OPTIONAL
    /// 					operationalRecoverySpec = @{
    /// 						# OPTIONAL
    /// 						mailboxOperationalRecoverySpec = @{
    /// 							# OPTIONAL
    /// 							archiveFolderAction = $someMailboxArchiveFolderAction # Call [Enum]::GetValues([RubrikSecurityCloud.Types.MailboxArchiveFolderAction]) for enum values.
    /// 							# REQUIRED
    /// 							mailboxTimeRange = @{
    /// 								# OPTIONAL
    /// 								fromTime = $someDateTime
    /// 								# OPTIONAL
    /// 								untilTime = $someDateTime
    /// 							}
    /// 						}
    /// 						# OPTIONAL
    /// 						calendarOperationalRecoverySpec = @{
    /// 							# REQUIRED
    /// 							calendarTimeRange = @{
    /// 								# OPTIONAL
    /// 								fromTime = $someDateTime
    /// 								# OPTIONAL
    /// 								untilTime = $someDateTime
    /// 							}
    /// 						}
    /// 						# OPTIONAL
    /// 						operationalRecoveryStage = $someOperationalRecoveryStage # Call [Enum]::GetValues([RubrikSecurityCloud.Types.OperationalRecoveryStage]) for enum values.
    /// 						# OPTIONAL
    /// 						shouldAutoComplete = $someBoolean
    /// 						# OPTIONAL
    /// 						sharepointOperationalRecoverySpec = @{
    /// 							# OPTIONAL
    /// 							shouldSkipItemPermission = $someBoolean
    /// 							# OPTIONAL
    /// 							siteOwnerEmail = $someString
    /// 							# REQUIRED
    /// 							lastModifiedTimeFilter = @{
    /// 								# OPTIONAL
    /// 								fromTime = $someDateTime
    /// 								# OPTIONAL
    /// 								untilTime = $someDateTime
    /// 							}
    /// 							# OPTIONAL
    /// 							targetSiteCollectionUrl = $someString
    /// 						}
    /// 						# OPTIONAL
    /// 						onedriveOperationalRecoverySpec = @{
    /// 							# REQUIRED
    /// 							lastModifiedTimeFilter = @{
    /// 								# OPTIONAL
    /// 								fromTime = $someDateTime
    /// 								# OPTIONAL
    /// 								untilTime = $someDateTime
    /// 							}
    /// 							# OPTIONAL
    /// 							targetRootPath = $someString
    /// 						}
    /// 						# OPTIONAL
    /// 						lastPhaseRecoveryJobId = $someString
    /// 					}
    /// 					# REQUIRED
    /// 					recoveryPoint = $someInt64
    /// 					# REQUIRED
    /// 					srcSubscriptionId = $someString
    /// 					# REQUIRED
    /// 					targetSubscriptionId = $someString
    /// 				}
    /// 			}
    /// 			# OPTIONAL
    /// 			adGroupId = $someString
    /// 		}
    /// 		# REQUIRED
    /// 		failureAction = $someFailureActionType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.FailureActionType]) for enum values.
    /// 		# REQUIRED
    /// 		recoveryMode = $someRecoveryModeType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RecoveryModeType]) for enum values.
    /// 		# REQUIRED
    /// 		recoveryDomain = $someRecoveryDomainType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RecoveryDomainType]) for enum values.
    /// 	}
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: StartBulkRecoveryReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the StartCrawl operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: StartCrawl
    /// 
    /// $query = New-RscMutationMisc -StartCrawl
    /// 
    /// # REQUIRED
    /// $query.Var.name = $someString
    /// # REQUIRED
    /// $query.Var.resources = @(
    /// 	@{
    /// 		# OPTIONAL
    /// 		snappableFid = $someString
    /// 		# OPTIONAL
    /// 		snapshotFid = $someString
    /// }
    /// )
    /// # REQUIRED
    /// $query.Var.analyzerGroups = @(
    /// 	@{
    /// 		# OPTIONAL
    /// 		groupType = $someAnalyzerGroupTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AnalyzerGroupTypeEnum]) for enum values.
    /// 		# OPTIONAL
    /// 		id = $someString
    /// 		# OPTIONAL
    /// 		name = $someString
    /// 		# OPTIONAL
    /// 		analyzers = @(
    /// 			@{
    /// 				# OPTIONAL
    /// 				analyzerType = $someAnalyzerTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AnalyzerTypeEnum]) for enum values.
    /// 				# OPTIONAL
    /// 				id = $someString
    /// 				# OPTIONAL
    /// 				name = $someString
    /// 				# OPTIONAL
    /// 				dictionaryCsv = $someString
    /// 				# OPTIONAL
    /// 				dictionary = @(
    /// 					$someString
    /// 				)
    /// 				# OPTIONAL
    /// 				regex = $someString
    /// 				# OPTIONAL
    /// 				analyzerRiskInstance = @{
    /// 					# OPTIONAL
    /// 					analyzerId = $someString
    /// 					# OPTIONAL
    /// 					riskVersion = $someInt
    /// 					# OPTIONAL
    /// 					risk = $someRiskLevelType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RiskLevelType]) for enum values.
    /// 				}
    /// 				# OPTIONAL
    /// 				tagId = $someInt
    /// 				# OPTIONAL
    /// 				risk = $someRiskLevelType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RiskLevelType]) for enum values.
    /// 			}
    /// 		)
    /// }
    /// )
    /// # OPTIONAL
    /// $query.Var.extWhiteList = @(
    /// 	$someString
    /// )
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: StartCrawlReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the StartCyberRecovery operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: StartCyberRecovery
    /// 
    /// $query = New-RscMutationMisc -StartCyberRecovery
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	blueprintId = $someString
    /// 	# REQUIRED
    /// 	recoverySpecId = $someString
    /// 	# OPTIONAL
    /// 	targetLocationType = $someLocationType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.LocationType]) for enum values.
    /// 	# OPTIONAL
    /// 	targetLocationUuid = $someString
    /// 	# REQUIRED
    /// 	failoverType = $someString
    /// 	# OPTIONAL
    /// 	jobTriggerEmail = $someString
    /// 	# OPTIONAL
    /// 	failoverFailureAction = $someString
    /// 	# OPTIONAL
    /// 	failoverOperation = $someString
    /// 	# OPTIONAL
    /// 	dataTransferType = $someDataTransferType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DataTransferType]) for enum values.
    /// 	# OPTIONAL
    /// 	childSnappableFailoverInfos = @(
    /// 		@{
    /// 			# REQUIRED
    /// 			snappableId = $someString
    /// 			# REQUIRED
    /// 			recoveryPoint = $someInt64
    /// 		}
    /// 	)
    /// 	# OPTIONAL
    /// 	failoverIgnorableErrors = @(
    /// 		$someBlueprintFailoverIgnorableError # Call [Enum]::GetValues([RubrikSecurityCloud.Types.BlueprintFailoverIgnorableError]) for enum values.
    /// 	)
    /// 	# OPTIONAL
    /// 	timeoutInMinutes = $someInt
    /// 	# OPTIONAL
    /// 	recoveryName = $someString
    /// 	# OPTIONAL
    /// 	failoverId = $someString
    /// 	# OPTIONAL
    /// 	triggeredFrom = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: CreateOnDemandJobReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the StartDownloadPackageBatchJob operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: StartDownloadPackageBatchJob
    /// 
    /// $query = New-RscMutationMisc -StartDownloadPackageBatchJob
    /// 
    /// # REQUIRED
    /// $query.Var.listClusterUuid = @(
    /// 	$someString
    /// )
    /// # OPTIONAL
    /// $query.Var.downloadVersion = $someString
    /// # REQUIRED
    /// $query.Var.packageUrl = $someString
    /// # REQUIRED
    /// $query.Var.md5checksum = $someString
    /// # OPTIONAL
    /// $query.Var.size = $someInt64
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: List&lt;DownloadPackageReplyWithUuid&gt;
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the StartExportRdsInstanceJob operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: StartExportRdsInstanceJob
    /// 
    /// $query = New-RscMutationMisc -StartExportRdsInstanceJob
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	rdsInstanceId = $someString
    /// 	# REQUIRED
    /// 	isPointInTime = $someBoolean
    /// 	# OPTIONAL
    /// 	snapshotId = $someString
    /// 	# OPTIONAL
    /// 	exportTime = $someDateTime
    /// 	# REQUIRED
    /// 	dbInstanceName = $someString
    /// 	# REQUIRED
    /// 	destinationAwsNativeAccountId = $someString
    /// 	# REQUIRED
    /// 	destinationRegionNativeId = $someAwsNativeRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRegion]) for enum values.
    /// 	# REQUIRED
    /// 	dbInstanceClass = $someAwsNativeRdsDbInstanceClass # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRdsDbInstanceClass]) for enum values.
    /// 	# OPTIONAL
    /// 	databaseInstanceClass = $someString
    /// 	# OPTIONAL
    /// 	primaryAz = $someString
    /// 	# REQUIRED
    /// 	port = $someInt64
    /// 	# OPTIONAL
    /// 	optionGroupName = $someString
    /// 	# OPTIONAL
    /// 	parameterGroupName = $someString
    /// 	# OPTIONAL
    /// 	subnetGroupName = $someString
    /// 	# OPTIONAL
    /// 	storageType = $someAwsNativeRdsStorageType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRdsStorageType]) for enum values.
    /// 	# OPTIONAL
    /// 	securityGroupIds = @(
    /// 		$someString
    /// 	)
    /// 	# OPTIONAL
    /// 	iops = $someInt
    /// 	# REQUIRED
    /// 	isPubliclyAccessible = $someBoolean
    /// 	# REQUIRED
    /// 	shouldExportTags = $someBoolean
    /// 	# REQUIRED
    /// 	isMultiAz = $someBoolean
    /// 	# OPTIONAL
    /// 	kmsKeyId = $someString
    /// 	# OPTIONAL
    /// 	subnetIds = @(
    /// 		$someString
    /// 	)
    /// 	# OPTIONAL
    /// 	snapshotType = $someSnapshotType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SnapshotType]) for enum values.
    /// 	# OPTIONAL
    /// 	dbClusterName = $someString
    /// 	# OPTIONAL
    /// 	dbClusterParameterGroupName = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AsyncJobStatus
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the StartFetchCdmRbacConfigJob operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: StartFetchCdmRbacConfigJob
    /// 
    /// $query = New-RscMutationMisc -StartFetchCdmRbacConfigJob
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	clusterId = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: System.String
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the StartMalwareDetection operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: StartMalwareDetection
    /// 
    /// $query = New-RscMutationMisc -StartMalwareDetection
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	clusterUuid = $someString
    /// 	# REQUIRED
    /// 	malwareScanConfig = @{
    /// 		# OPTIONAL
    /// 		maxMatchesPerSnapshot = $someInt
    /// 		# OPTIONAL
    /// 		name = $someString
    /// 		# OPTIONAL
    /// 		notes = $someString
    /// 		# OPTIONAL
    /// 		shouldTrustFilesystemTimeInfo = $someBoolean
    /// 		# OPTIONAL
    /// 		fileScanCriteria = @{
    /// 			# OPTIONAL
    /// 			fileSizeLimits = @{
    /// 				# OPTIONAL
    /// 				maximumSizeInBytes = $someInt64
    /// 				# OPTIONAL
    /// 				minimumSizeInBytes = $someInt64
    /// 			}
    /// 			# OPTIONAL
    /// 			fileTimeLimits = @{
    /// 				# OPTIONAL
    /// 				earliestCreationTime = $someDateTime
    /// 				# OPTIONAL
    /// 				earliestModificationTime = $someDateTime
    /// 				# OPTIONAL
    /// 				latestCreationTime = $someDateTime
    /// 				# OPTIONAL
    /// 				latestModificationTime = $someDateTime
    /// 			}
    /// 			# OPTIONAL
    /// 			pathFilter = @{
    /// 				# OPTIONAL
    /// 				exceptions = @(
    /// 					$someString
    /// 				)
    /// 				# OPTIONAL
    /// 				excludes = @(
    /// 					$someString
    /// 				)
    /// 				# OPTIONAL
    /// 				includes = @(
    /// 					$someString
    /// 				)
    /// 			}
    /// 		}
    /// 		# REQUIRED
    /// 		indicatorsOfCompromise = @(
    /// 			@{
    /// 				# REQUIRED
    /// 				iocType = $someIndicatorOfCompromiseType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.IndicatorOfCompromiseType]) for enum values.
    /// 				# REQUIRED
    /// 				iocValue = $someString
    /// 			}
    /// 		)
    /// 		# REQUIRED
    /// 		objectIds = @(
    /// 			$someString
    /// 		)
    /// 		# OPTIONAL
    /// 		requestedMatchDetails = @{
    /// 			# OPTIONAL
    /// 			requestedHashTypes = @(
    /// 				$someHashType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HashType]) for enum values.
    /// 			)
    /// 		}
    /// 		# OPTIONAL
    /// 		snapshotScanLimit = @{
    /// 			# OPTIONAL
    /// 			endTime = $someDateTime
    /// 			# OPTIONAL
    /// 			maxSnapshotsPerObject = $someInt
    /// 			# OPTIONAL
    /// 			startTime = $someDateTime
    /// 			# OPTIONAL
    /// 			snapshotsToScanPerObject = @(
    /// 				@{
    /// 					# REQUIRED
    /// 					id = $someString
    /// 					# REQUIRED
    /// 					snapshots = @(
    /// 						$someString
    /// 					)
    /// 				}
    /// 			)
    /// 		}
    /// 	}
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AsyncRequestStatus
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the StartMigrateCdmRbacConfigJob operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: StartMigrateCdmRbacConfigJob
    /// 
    /// $query = New-RscMutationMisc -StartMigrateCdmRbacConfigJob
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	clusterId = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: System.String
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the StartMultipleBulkRecoveries operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: StartMultipleBulkRecoveries
    /// 
    /// $query = New-RscMutationMisc -StartMultipleBulkRecoveries
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	definitions = @(
    /// 		@{
    /// 			# OPTIONAL
    /// 			recoveryName = $someString
    /// 			# OPTIONAL
    /// 			o365GroupSelectorWithRecoverySpec = @{
    /// 				# REQUIRED
    /// 				selectorType = $someO365SelectorType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.O365SelectorType]) for enum values.
    /// 				# REQUIRED
    /// 				baseInfo = @{
    /// 					# REQUIRED
    /// 					snappableType = $someWorkloadType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.WorkloadType]) for enum values.
    /// 					# REQUIRED
    /// 					subSnappableType = $someSubWorkloadType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SubWorkloadType]) for enum values.
    /// 					# REQUIRED
    /// 					recoverySpec = @{
    /// 						# OPTIONAL
    /// 						inplaceRecoverySpec = @{
    /// 							# OPTIONAL
    /// 							nameCollisionRule = $someInplaceCollisionRule # Call [Enum]::GetValues([RubrikSecurityCloud.Types.InplaceCollisionRule]) for enum values.
    /// 						}
    /// 						# OPTIONAL
    /// 						operationalRecoverySpec = @{
    /// 							# OPTIONAL
    /// 							mailboxOperationalRecoverySpec = @{
    /// 								# OPTIONAL
    /// 								archiveFolderAction = $someMailboxArchiveFolderAction # Call [Enum]::GetValues([RubrikSecurityCloud.Types.MailboxArchiveFolderAction]) for enum values.
    /// 								# REQUIRED
    /// 								mailboxTimeRange = @{
    /// 									# OPTIONAL
    /// 									fromTime = $someDateTime
    /// 									# OPTIONAL
    /// 									untilTime = $someDateTime
    /// 								}
    /// 							}
    /// 							# OPTIONAL
    /// 							calendarOperationalRecoverySpec = @{
    /// 								# REQUIRED
    /// 								calendarTimeRange = @{
    /// 									# OPTIONAL
    /// 									fromTime = $someDateTime
    /// 									# OPTIONAL
    /// 									untilTime = $someDateTime
    /// 								}
    /// 							}
    /// 							# OPTIONAL
    /// 							operationalRecoveryStage = $someOperationalRecoveryStage # Call [Enum]::GetValues([RubrikSecurityCloud.Types.OperationalRecoveryStage]) for enum values.
    /// 							# OPTIONAL
    /// 							shouldAutoComplete = $someBoolean
    /// 							# OPTIONAL
    /// 							sharepointOperationalRecoverySpec = @{
    /// 								# OPTIONAL
    /// 								shouldSkipItemPermission = $someBoolean
    /// 								# OPTIONAL
    /// 								siteOwnerEmail = $someString
    /// 								# REQUIRED
    /// 								lastModifiedTimeFilter = @{
    /// 									# OPTIONAL
    /// 									fromTime = $someDateTime
    /// 									# OPTIONAL
    /// 									untilTime = $someDateTime
    /// 								}
    /// 								# OPTIONAL
    /// 								targetSiteCollectionUrl = $someString
    /// 							}
    /// 							# OPTIONAL
    /// 							onedriveOperationalRecoverySpec = @{
    /// 								# REQUIRED
    /// 								lastModifiedTimeFilter = @{
    /// 									# OPTIONAL
    /// 									fromTime = $someDateTime
    /// 									# OPTIONAL
    /// 									untilTime = $someDateTime
    /// 								}
    /// 								# OPTIONAL
    /// 								targetRootPath = $someString
    /// 							}
    /// 							# OPTIONAL
    /// 							lastPhaseRecoveryJobId = $someString
    /// 						}
    /// 						# REQUIRED
    /// 						recoveryPoint = $someInt64
    /// 						# REQUIRED
    /// 						srcSubscriptionId = $someString
    /// 						# REQUIRED
    /// 						targetSubscriptionId = $someString
    /// 					}
    /// 				}
    /// 				# REQUIRED
    /// 				groupId = $someString
    /// 			}
    /// 			# REQUIRED
    /// 			failureAction = $someV2FailureActionType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.V2FailureActionType]) for enum values.
    /// 			# REQUIRED
    /// 			recoveryMode = $someRecoveryModeType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RecoveryModeType]) for enum values.
    /// 			# REQUIRED
    /// 			recoveryDomain = $someRecoveryDomainType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RecoveryDomainType]) for enum values.
    /// 		}
    /// 	)
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: StartMultipleBulkRecoveriesReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the StartNasAutomigrationJob operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: StartNasAutomigrationJob
    /// 
    /// $query = New-RscMutationMisc -StartNasAutomigrationJob
    /// 
    /// # REQUIRED
    /// $query.Var.nasAutomigrationJobConfig = @{
    /// 	# REQUIRED
    /// 	MigrateAllHosts = $someBoolean
    /// 	# REQUIRED
    /// 	CopyableHostIDs = @(
    /// 		$someString
    /// 	)
    /// 	# REQUIRED
    /// 	NasSystemIDs = @(
    /// 		$someString
    /// 	)
    /// 	# OPTIONAL
    /// 	clusterUUID = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: CreateOnDemandJobReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the StartPeriodicUpgradePrechecksOnDemandJob operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: StartPeriodicUpgradePrechecksOnDemandJob
    /// 
    /// $query = New-RscMutationMisc -StartPeriodicUpgradePrechecksOnDemandJob
    /// 
    /// # REQUIRED
    /// $query.Var.clusterUuid = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: PrechecksJobReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the StartSaasAppAuthConsent operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: StartSaasAppAuthConsent
    /// 
    /// $query = New-RscMutationMisc -StartSaasAppAuthConsent
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	siteUrl = $someString
    /// 	# REQUIRED
    /// 	customerUrl = $someString
    /// 	# REQUIRED
    /// 	saasAppType = $someSaasAppType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SaasAppType]) for enum values.
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: StartSaasAppAuthConsentReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the StartSaasAppsDeleteOrg operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: StartSaasAppsDeleteOrg
    /// 
    /// $query = New-RscMutationMisc -StartSaasAppsDeleteOrg
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	orgID = $someString
    /// 	# REQUIRED
    /// 	saasAppType = $someSaasAppType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SaasAppType]) for enum values.
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: CreateOnDemandJobReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the StartUpgradeBatchJob operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: StartUpgradeBatchJob
    /// 
    /// $query = New-RscMutationMisc -StartUpgradeBatchJob
    /// 
    /// # REQUIRED
    /// $query.Var.listClusterUuid = @(
    /// 	$someString
    /// )
    /// # REQUIRED
    /// $query.Var.mode = $someString
    /// # REQUIRED
    /// $query.Var.action = $someActionType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ActionType]) for enum values.
    /// # REQUIRED
    /// $query.Var.version = $someString
    /// # OPTIONAL
    /// $query.Var.context_tag = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: List&lt;UpgradeJobReplyWithUuid&gt;
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the StartVolumeGroupMount operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: StartVolumeGroupMount
    /// 
    /// $query = New-RscMutationMisc -StartVolumeGroupMount
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	config = @{
    /// 		# OPTIONAL
    /// 		smbDomainName = $someString
    /// 		# OPTIONAL
    /// 		smbValidIps = @(
    /// 			$someString
    /// 		)
    /// 		# OPTIONAL
    /// 		smbValidUsers = @(
    /// 			$someString
    /// 		)
    /// 		# OPTIONAL
    /// 		targetHostId = $someString
    /// 		# REQUIRED
    /// 		volumeConfigs = @(
    /// 			@{
    /// 				# OPTIONAL
    /// 				mountPointOnHost = $someString
    /// 				# REQUIRED
    /// 				volumeId = $someString
    /// 			}
    /// 		)
    /// 	}
    /// 	# REQUIRED
    /// 	id = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AsyncRequestStatus
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the StopJobInstance operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: StopJobInstance
    /// 
    /// $query = New-RscMutationMisc -StopJobInstance
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	jobInstanceId = $someString
    /// 	# OPTIONAL
    /// 	eventSeriesId = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: StopJobInstanceReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the StopJobInstanceFromEventSeries operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: StopJobInstanceFromEventSeries
    /// 
    /// $query = New-RscMutationMisc -StopJobInstanceFromEventSeries
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	eventSeriesId = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: System.String
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the SubmitTprRequest operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: SubmitTprRequest
    /// 
    /// $query = New-RscMutationMisc -SubmitTprRequest
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	requestId = $someString
    /// 	# OPTIONAL
    /// 	comment = $someString
    /// 	# REQUIRED
    /// 	executionType = $someTprExecutionType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TprExecutionType]) for enum values.
    /// 	# OPTIONAL
    /// 	executionTimeoutHours = $someInt
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: System.String
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the SupportPortalLogin operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: SupportPortalLogin
    /// 
    /// $query = New-RscMutationMisc -SupportPortalLogin
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	account = $someString
    /// 	# OPTIONAL
    /// 	hostname = $someString
    /// 	# OPTIONAL
    /// 	organizationId = $someString
    /// 	# REQUIRED
    /// 	username = $someString
    /// 	# REQUIRED
    /// 	password = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: SupportPortalLoginReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the SwitchProductToOnboardingMode operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: SwitchProductToOnboardingMode
    /// 
    /// $query = New-RscMutationMisc -SwitchProductToOnboardingMode
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	orgId = $someString
    /// 	# REQUIRED
    /// 	workloadType = $someM365DashboardWorkloadType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.M365DashboardWorkloadType]) for enum values.
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: System.String
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the ToggleFeatureEnabled operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: ToggleFeatureEnabled
    /// 
    /// $query = New-RscMutationMisc -ToggleFeatureEnabled
    /// 
    /// # REQUIRED
    /// $query.Var.featureName = $someFeatureName # Call [Enum]::GetValues([RubrikSecurityCloud.Types.FeatureName]) for enum values.
    /// # REQUIRED
    /// $query.Var.enableFeature = $someBoolean
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: System.Boolean
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the TriggerCloudComputeConnectivityCheck operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: TriggerCloudComputeConnectivityCheck
    /// 
    /// $query = New-RscMutationMisc -TriggerCloudComputeConnectivityCheck
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	shouldCheckCloudConnectivityForCloudOut = $someBoolean
    /// 	# REQUIRED
    /// 	id = $someString
    /// 	# REQUIRED
    /// 	shouldCheckCloudConnectivityForCloudOn = $someBoolean
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AsyncRequestStatus
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the TriggerExocomputeHealthCheck operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: TriggerExocomputeHealthCheck
    /// 
    /// $query = New-RscMutationMisc -TriggerExocomputeHealthCheck
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	cloudVendor = $someCloudVendor # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudVendor]) for enum values.
    /// 	# REQUIRED
    /// 	exocomputeConfigId = $someString
    /// 	# OPTIONAL
    /// 	nodeType = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: TriggerExocomputeHealthCheckReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the UninstallIoFilter operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: UninstallIoFilter
    /// 
    /// $query = New-RscMutationMisc -UninstallIoFilter
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	id = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: RequestSuccess
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the UnlockUsersByAdmin operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: UnlockUsersByAdmin
    /// 
    /// $query = New-RscMutationMisc -UnlockUsersByAdmin
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	userIds = @(
    /// 		$someString
    /// 	)
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: System.String
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the UnmountDisk operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: UnmountDisk
    /// 
    /// $query = New-RscMutationMisc -UnmountDisk
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	liveMountId = $someInt64
    /// 	# REQUIRED
    /// 	mountIds = @(
    /// 		$someInt64
    /// 	)
    /// 	# REQUIRED
    /// 	targetWorkloadId = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: System.String
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the UpdateAccountOwner operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: UpdateAccountOwner
    /// 
    /// $query = New-RscMutationMisc -UpdateAccountOwner
    /// 
    /// # REQUIRED
    /// $query.Var.userId = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: System.Boolean
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the UpdateAccountSettings operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: UpdateAccountSettings
    /// 
    /// $query = New-RscMutationMisc -UpdateAccountSettings
    /// 
    /// # OPTIONAL
    /// $query.Var.isEulaAccepted = $someBoolean
    /// # OPTIONAL
    /// $query.Var.isEmailNotificationEnabled = $someBoolean
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AccountSetting
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the UpdateAdGroup operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: UpdateAdGroup
    /// 
    /// $query = New-RscMutationMisc -UpdateAdGroup
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	orgId = $someString
    /// 	# REQUIRED
    /// 	groupId = $someString
    /// 	# REQUIRED
    /// 	updatedDisplayName = $someString
    /// 	# REQUIRED
    /// 	updatedGroupFilterAttributes = @(
    /// 		@{
    /// 			# OPTIONAL
    /// 			filterOpType = $someJoinOpType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.JoinOpType]) for enum values.
    /// 			# OPTIONAL
    /// 			attributeType = $someAttributeType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AttributeType]) for enum values.
    /// 			# OPTIONAL
    /// 			attributeKey = $someString
    /// 			# OPTIONAL
    /// 			attributeValue = $someString
    /// 			# OPTIONAL
    /// 			dataType = $someAttributeDataType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AttributeDataType]) for enum values.
    /// 		}
    /// 	)
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: System.String
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the UpdateAgentDeploymentSetting operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: UpdateAgentDeploymentSetting
    /// 
    /// $query = New-RscMutationMisc -UpdateAgentDeploymentSetting
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	clusterUuid = $someString
    /// 	# REQUIRED
    /// 	settings = @{
    /// 		# REQUIRED
    /// 		isAutomatic = $someBoolean
    /// 	}
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AgentDeploymentSettings
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the UpdateAgentDeploymentSettingInBatch operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: UpdateAgentDeploymentSettingInBatch
    /// 
    /// $query = New-RscMutationMisc -UpdateAgentDeploymentSettingInBatch
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	requests = @(
    /// 		@{
    /// 			# REQUIRED
    /// 			clusterUuid = $someString
    /// 			# REQUIRED
    /// 			settings = @{
    /// 				# REQUIRED
    /// 				isAutomatic = $someBoolean
    /// 			}
    /// 		}
    /// 	)
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: UpdateAgentDeploymentSettingInBatchReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the UpdateAuthDomainUsersHiddenStatus operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: UpdateAuthDomainUsersHiddenStatus
    /// 
    /// $query = New-RscMutationMisc -UpdateAuthDomainUsersHiddenStatus
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	userIds = @(
    /// 		$someString
    /// 	)
    /// 	# REQUIRED
    /// 	isHidden = $someBoolean
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: System.String
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the UpdateBackupThrottleSetting operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: UpdateBackupThrottleSetting
    /// 
    /// $query = New-RscMutationMisc -UpdateBackupThrottleSetting
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	requests = @(
    /// 		@{
    /// 			# OPTIONAL
    /// 			clusterUuid = $someString
    /// 			# OPTIONAL
    /// 			enableThrottling = $someBoolean
    /// 			# OPTIONAL
    /// 			vmwareThrottlingSettings = @{
    /// 				# OPTIONAL
    /// 				ioLatencyThreshold = $someInt
    /// 				# OPTIONAL
    /// 				datastoreIoLatencyThreshold = $someInt
    /// 				# OPTIONAL
    /// 				cpuUtilizationThreshold = $someInt
    /// 			}
    /// 		}
    /// 	)
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: UpdateBackupThrottleSettingReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the UpdateBadDiskLedStatus operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: UpdateBadDiskLedStatus
    /// 
    /// $query = New-RscMutationMisc -UpdateBadDiskLedStatus
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	diskSerial = $someString
    /// 	# OPTIONAL
    /// 	turnOff = $someBoolean
    /// 	# REQUIRED
    /// 	id = $someString
    /// 	# REQUIRED
    /// 	nodeId = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: UpdateBadDiskLedStatusReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the UpdateBlueprint operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: UpdateBlueprint
    /// 
    /// $query = New-RscMutationMisc -UpdateBlueprint
    /// 
    /// # REQUIRED
    /// $query.Var.fid = $someString
    /// # REQUIRED
    /// $query.Var.name = $someString
    /// # REQUIRED
    /// $query.Var.children = @(
    /// 	@{
    /// 		# REQUIRED
    /// 		fid = $someString
    /// 		# REQUIRED
    /// 		snappableType = $someObjectTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ObjectTypeEnum]) for enum values.
    /// 		# REQUIRED
    /// 		bootPriority = $someInt
    /// 		# OPTIONAL
    /// 		lastRecoveryPoint = $someInt64
    /// }
    /// )
    /// # REQUIRED
    /// $query.Var.sourceLocationId = $someString
    /// # REQUIRED
    /// $query.Var.sourceLocationType = $someBlueprintLocationType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.BlueprintLocationType]) for enum values.
    /// # OPTIONAL
    /// $query.Var.targetLocationType = $someBlueprintLocationType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.BlueprintLocationType]) for enum values.
    /// # OPTIONAL
    /// $query.Var.targetLocationId = $someString
    /// # REQUIRED
    /// $query.Var.status = $someBlueprintStatus # Call [Enum]::GetValues([RubrikSecurityCloud.Types.BlueprintStatus]) for enum values.
    /// # REQUIRED
    /// $query.Var.version = $someInt
    /// # OPTIONAL
    /// $query.Var.enableHydration = $someBoolean
    /// # OPTIONAL
    /// $query.Var.timeoutBetweenPriorityGroups = @(
    /// 	$someInt64
    /// )
    /// # OPTIONAL
    /// $query.Var.blueprintRecoveryType = $someBlueprintRecoveryType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.BlueprintRecoveryType]) for enum values.
    /// # REQUIRED
    /// $query.Var.isBlueprintVisible = $someBoolean
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: BlueprintNew
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the UpdateChat operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: UpdateChat
    /// 
    /// $query = New-RscMutationMisc -UpdateChat
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	chatId = $someString
    /// 	# OPTIONAL
    /// 	isPinned = $someBoolean
    /// 	# OPTIONAL
    /// 	isArchived = $someBoolean
    /// 	# OPTIONAL
    /// 	title = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: System.String
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the UpdateChatbot operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: UpdateChatbot
    /// 
    /// $query = New-RscMutationMisc -UpdateChatbot
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	name = $someString
    /// 	# OPTIONAL
    /// 	description = $someString
    /// 	# OPTIONAL
    /// 	filters = @{
    /// 		# OPTIONAL
    /// 		modifiedTimeRange = @{
    /// 			# OPTIONAL
    /// 			startTime = $someInt64
    /// 			# OPTIONAL
    /// 			endTime = $someInt64
    /// 		}
    /// 		# REQUIRED
    /// 		sensitiveDataPolicyIds = @(
    /// 			$someString
    /// 		)
    /// 		# REQUIRED
    /// 		extensionWhitelist = @(
    /// 			$someString
    /// 		)
    /// 	}
    /// 	# REQUIRED
    /// 	chatbotId = $someString
    /// 	# REQUIRED
    /// 	objects = @(
    /// 		@{
    /// 			# OPTIONAL
    /// 			workloadType = $someManagedObjectType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ManagedObjectType]) for enum values.
    /// 			# OPTIONAL
    /// 			pathFilter = @{
    /// 				# REQUIRED
    /// 				prefixInclusions = @(
    /// 					$someString
    /// 				)
    /// 			}
    /// 			# REQUIRED
    /// 			id = $someString
    /// 		}
    /// 	)
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: UpdateChatbotReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the UpdateClassificationBannerEnabled operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: UpdateClassificationBannerEnabled
    /// 
    /// $query = New-RscMutationMisc -UpdateClassificationBannerEnabled
    /// 
    /// # No variables for this query.
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: System.Boolean
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the UpdateClassificationBannerSettings operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: UpdateClassificationBannerSettings
    /// 
    /// $query = New-RscMutationMisc -UpdateClassificationBannerSettings
    /// 
    /// # REQUIRED
    /// $query.Var.classificationBannerSettingsArg = @{
    /// 	# OPTIONAL
    /// 	account = $someString
    /// 	# OPTIONAL
    /// 	bannerText = $someString
    /// 	# OPTIONAL
    /// 	bannerColor = $someBannerColor # Call [Enum]::GetValues([RubrikSecurityCloud.Types.BannerColor]) for enum values.
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: System.Boolean
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the UpdateClassificationLoginEnabled operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: UpdateClassificationLoginEnabled
    /// 
    /// $query = New-RscMutationMisc -UpdateClassificationLoginEnabled
    /// 
    /// # No variables for this query.
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: System.Boolean
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the UpdateClassificationLoginSettings operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: UpdateClassificationLoginSettings
    /// 
    /// $query = New-RscMutationMisc -UpdateClassificationLoginSettings
    /// 
    /// # REQUIRED
    /// $query.Var.classificationLoginSettingsArg = @{
    /// 	# OPTIONAL
    /// 	account = $someString
    /// 	# OPTIONAL
    /// 	loginText = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: System.Boolean
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the UpdateConfigProtectionSetup operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: UpdateConfigProtectionSetup
    /// 
    /// $query = New-RscMutationMisc -UpdateConfigProtectionSetup
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	clusterUuid = $someString
    /// 	# OPTIONAL
    /// 	encryptionPassword = $someString
    /// 	# OPTIONAL
    /// 	caCertificate = @{
    /// 		# OPTIONAL
    /// 		uuid = $someString
    /// 		# OPTIONAL
    /// 		name = $someString
    /// 		# OPTIONAL
    /// 		description = $someString
    /// 		# OPTIONAL
    /// 		certificate = $someString
    /// 		# REQUIRED
    /// 		caProvider = $someCaCertProviderType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CaCertProviderType]) for enum values.
    /// 	}
    /// 	# OPTIONAL
    /// 	replicationTargetUuid = $someString
    /// 	# OPTIONAL
    /// 	uploadLocationType = $someUploadLocationType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UploadLocationType]) for enum values.
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AsyncJobStatus
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the UpdateConfiguredGroup operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: UpdateConfiguredGroup
    /// 
    /// $query = New-RscMutationMisc -UpdateConfiguredGroup
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	orgId = $someString
    /// 	# REQUIRED
    /// 	groupId = $someString
    /// 	# OPTIONAL
    /// 	updatedDisplayName = $someString
    /// 	# OPTIONAL
    /// 	updatedWildcard = $someString
    /// 	# REQUIRED
    /// 	updatedPdls = @(
    /// 		$someString
    /// 	)
    /// 	# OPTIONAL
    /// 	updatedGroupFilterAttributes = @(
    /// 		@{
    /// 			# OPTIONAL
    /// 			filterOpType = $someJoinOpType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.JoinOpType]) for enum values.
    /// 			# OPTIONAL
    /// 			attributeType = $someAttributeType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AttributeType]) for enum values.
    /// 			# OPTIONAL
    /// 			attributeKey = $someString
    /// 			# OPTIONAL
    /// 			attributeValue = $someString
    /// 			# OPTIONAL
    /// 			dataType = $someAttributeDataType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AttributeDataType]) for enum values.
    /// 		}
    /// 	)
    /// 	# REQUIRED
    /// 	performArchival = $someBoolean
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: System.String
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the UpdateCustomAnalyzer operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: UpdateCustomAnalyzer
    /// 
    /// $query = New-RscMutationMisc -UpdateCustomAnalyzer
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	analyzerType = $someAnalyzerTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AnalyzerTypeEnum]) for enum values.
    /// 	# OPTIONAL
    /// 	id = $someString
    /// 	# OPTIONAL
    /// 	name = $someString
    /// 	# OPTIONAL
    /// 	dictionaryCsv = $someString
    /// 	# OPTIONAL
    /// 	dictionary = @(
    /// 		$someString
    /// 	)
    /// 	# OPTIONAL
    /// 	regex = $someString
    /// 	# OPTIONAL
    /// 	analyzerRiskInstance = @{
    /// 		# OPTIONAL
    /// 		analyzerId = $someString
    /// 		# OPTIONAL
    /// 		riskVersion = $someInt
    /// 		# OPTIONAL
    /// 		risk = $someRiskLevelType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RiskLevelType]) for enum values.
    /// 	}
    /// 	# OPTIONAL
    /// 	tagId = $someInt
    /// 	# OPTIONAL
    /// 	risk = $someRiskLevelType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RiskLevelType]) for enum values.
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: Analyzer
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the UpdateCustomIntelFeed operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: UpdateCustomIntelFeed
    /// 
    /// $query = New-RscMutationMisc -UpdateCustomIntelFeed
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	user = $someString
    /// 	# OPTIONAL
    /// 	name = @{
    /// 		# OPTIONAL
    /// 		name = $someString
    /// 	}
    /// 	# OPTIONAL
    /// 	providerId = $someString
    /// 	# OPTIONAL
    /// 	description = @{
    /// 		# OPTIONAL
    /// 		description = $someString
    /// 	}
    /// 	# OPTIONAL
    /// 	entriesToAdd = @(
    /// 		@{
    /// 			# OPTIONAL
    /// 			iocString = $someString
    /// 			# OPTIONAL
    /// 			threatFamily = $someString
    /// 			# REQUIRED
    /// 			iocType = $someThreatFeedType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ThreatFeedType]) for enum values.
    /// 		}
    /// 	)
    /// 	# OPTIONAL
    /// 	entriesToRemove = @(
    /// 		$someString
    /// 	)
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: System.String
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the UpdateCustomerAppPermissions operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: UpdateCustomerAppPermissions
    /// 
    /// $query = New-RscMutationMisc -UpdateCustomerAppPermissions
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	appPermissions = @(
    /// 		$someAzureAppPermission # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureAppPermission]) for enum values.
    /// 	)
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: UpdateCustomerAppPermissionsReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the UpdateCyberEventLockdown operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: UpdateCyberEventLockdown
    /// 
    /// $query = New-RscMutationMisc -UpdateCyberEventLockdown
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	clusterUuid = $someString
    /// 	# REQUIRED
    /// 	updateCyberEventLockdownRequest = @{
    /// 		# REQUIRED
    /// 		shouldEnable = $someBoolean
    /// 	}
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: UpdateCyberEventLockdownResponse
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the UpdateDistributionListDigest operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: UpdateDistributionListDigest
    /// 
    /// $query = New-RscMutationMisc -UpdateDistributionListDigest
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	digestId = $someInt
    /// 	# OPTIONAL
    /// 	digestName = $someString
    /// 	# OPTIONAL
    /// 	frequencyHours = $someInt
    /// 	# OPTIONAL
    /// 	isImmediate = $someBoolean
    /// 	# OPTIONAL
    /// 	includeAudits = $someBoolean
    /// 	# OPTIONAL
    /// 	includeEvents = $someBoolean
    /// 	# REQUIRED
    /// 	eventDigestConfig = @{
    /// 		# OPTIONAL
    /// 		objectType = @(
    /// 			$someActivityObjectTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ActivityObjectTypeEnum]) for enum values.
    /// 		)
    /// 		# OPTIONAL
    /// 		activityStatus = @(
    /// 			$someActivityStatusEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ActivityStatusEnum]) for enum values.
    /// 		)
    /// 		# OPTIONAL
    /// 		activityType = @(
    /// 			$someString
    /// 		)
    /// 		# OPTIONAL
    /// 		auditType = @(
    /// 			$someUserAuditTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UserAuditTypeEnum]) for enum values.
    /// 		)
    /// 		# OPTIONAL
    /// 		activitySeverity = @(
    /// 			$someActivitySeverityEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ActivitySeverityEnum]) for enum values.
    /// 		)
    /// 		# OPTIONAL
    /// 		clusters = @(
    /// 			$someString
    /// 		)
    /// 		# OPTIONAL
    /// 		emailAddresses = @(
    /// 			$someString
    /// 		)
    /// 	}
    /// 	# REQUIRED
    /// 	recipientUserIds = @(
    /// 		$someString
    /// 	)
    /// 	# OPTIONAL
    /// 	clusterUuids = @(
    /// 		$someString
    /// 	)
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: UpdateDistributionListDigestReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the UpdateDnsServersAndSearchDomains operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: UpdateDnsServersAndSearchDomains
    /// 
    /// $query = New-RscMutationMisc -UpdateDnsServersAndSearchDomains
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	id = $someString
    /// 	# REQUIRED
    /// 	servers = @(
    /// 		$someString
    /// 	)
    /// 	# REQUIRED
    /// 	domains = @(
    /// 		$someString
    /// 	)
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: ResponseSuccess
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the UpdateEulaAccepted operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: UpdateEulaAccepted
    /// 
    /// $query = New-RscMutationMisc -UpdateEulaAccepted
    /// 
    /// # No variables for this query.
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: System.Boolean
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the UpdateEventDigest operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: UpdateEventDigest
    /// 
    /// $query = New-RscMutationMisc -UpdateEventDigest
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	digestId = $someInt
    /// 	# OPTIONAL
    /// 	digestName = $someString
    /// 	# OPTIONAL
    /// 	frequencyHours = $someInt
    /// 	# OPTIONAL
    /// 	isImmediate = $someBoolean
    /// 	# OPTIONAL
    /// 	includeAudits = $someBoolean
    /// 	# OPTIONAL
    /// 	includeEvents = $someBoolean
    /// 	# REQUIRED
    /// 	eventDigestConfig = @{
    /// 		# OPTIONAL
    /// 		objectType = @(
    /// 			$someActivityObjectTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ActivityObjectTypeEnum]) for enum values.
    /// 		)
    /// 		# OPTIONAL
    /// 		activityStatus = @(
    /// 			$someActivityStatusEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ActivityStatusEnum]) for enum values.
    /// 		)
    /// 		# OPTIONAL
    /// 		activityType = @(
    /// 			$someString
    /// 		)
    /// 		# OPTIONAL
    /// 		auditType = @(
    /// 			$someUserAuditTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UserAuditTypeEnum]) for enum values.
    /// 		)
    /// 		# OPTIONAL
    /// 		activitySeverity = @(
    /// 			$someActivitySeverityEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ActivitySeverityEnum]) for enum values.
    /// 		)
    /// 		# OPTIONAL
    /// 		clusters = @(
    /// 			$someString
    /// 		)
    /// 		# OPTIONAL
    /// 		emailAddresses = @(
    /// 			$someString
    /// 		)
    /// 	}
    /// 	# REQUIRED
    /// 	recipientUserIds = @(
    /// 		$someString
    /// 	)
    /// 	# OPTIONAL
    /// 	clusterUuids = @(
    /// 		$someString
    /// 	)
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: UpdateEventDigestReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the UpdateFloatingIps operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: UpdateFloatingIps
    /// 
    /// $query = New-RscMutationMisc -UpdateFloatingIps
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	clusterUuid = $someString
    /// 	# REQUIRED
    /// 	newClusterIps = @(
    /// 		$someString
    /// 	)
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: UpdateFloatingIpsReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the UpdateGuestCredential operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: UpdateGuestCredential
    /// 
    /// $query = New-RscMutationMisc -UpdateGuestCredential
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	clusterUuid = $someString
    /// 	# REQUIRED
    /// 	definition = @{
    /// 		# OPTIONAL
    /// 		domain = $someString
    /// 		# OPTIONAL
    /// 		description = $someString
    /// 		# OPTIONAL
    /// 		baseGuestCredential = @{
    /// 			# REQUIRED
    /// 			password = $someString
    /// 			# REQUIRED
    /// 			username = $someString
    /// 		}
    /// 	}
    /// 	# REQUIRED
    /// 	id = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: UpdateGuestCredentialReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the UpdateIdentityProvider operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: UpdateIdentityProvider
    /// 
    /// $query = New-RscMutationMisc -UpdateIdentityProvider
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	idpClaimAttribute = @(
    /// 		@{
    /// 			# REQUIRED
    /// 			name = $someString
    /// 			# REQUIRED
    /// 			type = $someString
    /// 		}
    /// 	)
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: UpdateIdentityProviderReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the UpdateInsightState operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: UpdateInsightState
    /// 
    /// $query = New-RscMutationMisc -UpdateInsightState
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	insightId = $someString
    /// 	# OPTIONAL
    /// 	isDismissed = $someBoolean
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: UpdateInsightStateReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the UpdateIocStatus operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: UpdateIocStatus
    /// 
    /// $query = New-RscMutationMisc -UpdateIocStatus
    /// 
    /// # REQUIRED
    /// $query.Var.input = @(
    /// 	@{
    /// 		# REQUIRED
    /// 		operation = $someIocOperation # Call [Enum]::GetValues([RubrikSecurityCloud.Types.IocOperation]) for enum values.
    /// 		# OPTIONAL
    /// 		iocHashOnly = @{
    /// 			# REQUIRED
    /// 			iocHashHex = $someString
    /// 		}
    /// 		# OPTIONAL
    /// 		iocHashWithProvider = @{
    /// 			# REQUIRED
    /// 			iocHashHex = $someString
    /// 			# REQUIRED
    /// 			providerId = $someString
    /// 		}
    /// 		# OPTIONAL
    /// 		iocProviderWithThreatFeedType = @{
    /// 			# REQUIRED
    /// 			providerId = $someString
    /// 			# REQUIRED
    /// 			type = $someThreatFeedType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ThreatFeedType]) for enum values.
    /// 		}
    /// }
    /// )
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: System.String
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the UpdateIpWhitelist operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: UpdateIpWhitelist
    /// 
    /// $query = New-RscMutationMisc -UpdateIpWhitelist
    /// 
    /// # REQUIRED
    /// $query.Var.whitelistMode = $someWhitelistModeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.WhitelistModeEnum]) for enum values.
    /// # REQUIRED
    /// $query.Var.ipCidrs = @(
    /// 	$someString
    /// )
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: System.Boolean
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the UpdateKmipServer operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: UpdateKmipServer
    /// 
    /// $query = New-RscMutationMisc -UpdateKmipServer
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	clusterIds = @(
    /// 		$someString
    /// 	)
    /// 	# REQUIRED
    /// 	serverAddress = $someString
    /// 	# REQUIRED
    /// 	port = $someInt
    /// 	# REQUIRED
    /// 	polarisCertId = $someInt
    /// 	# OPTIONAL
    /// 	polarisCertFid = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: UpdateKmipServerReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the UpdateLambdaSettings operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: UpdateLambdaSettings
    /// 
    /// $query = New-RscMutationMisc -UpdateLambdaSettings
    /// 
    /// # OPTIONAL
    /// $query.Var.anomalyThreshold = $someSingle
    /// # OPTIONAL
    /// $query.Var.ransomwareThreshold = $someSingle
    /// # OPTIONAL
    /// $query.Var.isAnomalyAlertEnabled = $someBoolean
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: LambdaSettings
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the UpdateLlmEnabled operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: UpdateLlmEnabled
    /// 
    /// $query = New-RscMutationMisc -UpdateLlmEnabled
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	isEnabled = $someBoolean
    /// 	# REQUIRED
    /// 	acceptTerms = $someBoolean
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: System.String
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the UpdateLockoutConfig operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: UpdateLockoutConfig
    /// 
    /// $query = New-RscMutationMisc -UpdateLockoutConfig
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	loginAttemptsLimit = $someInt
    /// 	# OPTIONAL
    /// 	selfServiceTokenValidityInMins = $someInt
    /// 	# OPTIONAL
    /// 	selfServiceAttemptsLimit = $someInt
    /// 	# OPTIONAL
    /// 	isSelfServiceEnabled = $someBoolean
    /// 	# OPTIONAL
    /// 	accountAutoUnlockDurationInMins = $someInt
    /// 	# OPTIONAL
    /// 	isBruteForceLockoutEnabled = $someBoolean
    /// 	# OPTIONAL
    /// 	isAutoUnlockFeatureEnabled = $someBoolean
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: UpdateLockoutConfigReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the UpdateManagedIdentities operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: UpdateManagedIdentities
    /// 
    /// $query = New-RscMutationMisc -UpdateManagedIdentities
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	cloudAccountId = $someString
    /// 	# REQUIRED
    /// 	clusterUuid = $someString
    /// 	# OPTIONAL
    /// 	managedIdentity = @{
    /// 		# OPTIONAL
    /// 		name = $someString
    /// 		# OPTIONAL
    /// 		clientId = $someString
    /// 		# OPTIONAL
    /// 		resourceGroup = $someString
    /// 	}
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: UpdateManagedIdentitiesReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the UpdateNetworkThrottle operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: UpdateNetworkThrottle
    /// 
    /// $query = New-RscMutationMisc -UpdateNetworkThrottle
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	clusterUuid = $someString
    /// 	# REQUIRED
    /// 	id = $someString
    /// 	# REQUIRED
    /// 	throttleUpdate = @{
    /// 		# OPTIONAL
    /// 		defaultThrottleLimit = $someSingle
    /// 		# OPTIONAL
    /// 		isEnabled = $someBoolean
    /// 		# OPTIONAL
    /// 		networkInterface = $someString
    /// 		# OPTIONAL
    /// 		archivalThrottlePort = $someInt
    /// 		# OPTIONAL
    /// 		scheduledThrottles = @(
    /// 			@{
    /// 				# REQUIRED
    /// 				daysOfWeek = @(
    /// 					$someInt
    /// 				)
    /// 				# REQUIRED
    /// 				endTime = $someInt64
    /// 				# REQUIRED
    /// 				startTime = $someInt64
    /// 				# REQUIRED
    /// 				throttleLimit = $someSingle
    /// 			}
    /// 		)
    /// 	}
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: UpdateNetworkThrottleReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the UpdateOrgNetwork operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: UpdateOrgNetwork
    /// 
    /// $query = New-RscMutationMisc -UpdateOrgNetwork
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	orgNetworkID = $someString
    /// 	# REQUIRED
    /// 	name = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: System.String
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the UpdatePactsafeEulaAccepted operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: UpdatePactsafeEulaAccepted
    /// 
    /// $query = New-RscMutationMisc -UpdatePactsafeEulaAccepted
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	firstName = $someString
    /// 	# REQUIRED
    /// 	lastName = $someString
    /// 	# REQUIRED
    /// 	title = $someString
    /// 	# REQUIRED
    /// 	companyName = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: UpdatePactsafeEulaAcceptedReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the UpdatePactsafeEulaSeen operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: UpdatePactsafeEulaSeen
    /// 
    /// $query = New-RscMutationMisc -UpdatePactsafeEulaSeen
    /// 
    /// # No variables for this query.
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: UpdatePactsafeEulaSeenReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the UpdateProxyConfig operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: UpdateProxyConfig
    /// 
    /// $query = New-RscMutationMisc -UpdateProxyConfig
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	clusterUuid = $someString
    /// 	# REQUIRED
    /// 	proxy = @{
    /// 		# OPTIONAL
    /// 		password = $someString
    /// 		# OPTIONAL
    /// 		port = $someInt
    /// 		# OPTIONAL
    /// 		username = $someString
    /// 		# REQUIRED
    /// 		host = $someString
    /// 		# REQUIRED
    /// 		protocol = $someString
    /// 	}
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: UpdateProxyConfigReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the UpdateReaderLocationMasterKeyWithOwnerLocationKey operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: UpdateReaderLocationMasterKeyWithOwnerLocationKey
    /// 
    /// $query = New-RscMutationMisc -UpdateReaderLocationMasterKeyWithOwnerLocationKey
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	locationId = $someString
    /// 	# REQUIRED
    /// 	ownerLocationId = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: System.String
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the UpdateReaderLocationMasterKeyWithRsaKey operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: UpdateReaderLocationMasterKeyWithRsaKey
    /// 
    /// $query = New-RscMutationMisc -UpdateReaderLocationMasterKeyWithRsaKey
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	locationId = $someString
    /// 	# REQUIRED
    /// 	newRsaKey = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: System.String
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the UpdateRecoveryPlan operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: UpdateRecoveryPlan
    /// 
    /// $query = New-RscMutationMisc -UpdateRecoveryPlan
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	name = $someString
    /// 	# REQUIRED
    /// 	id = $someString
    /// 	# OPTIONAL
    /// 	targetLocationId = $someString
    /// 	# OPTIONAL
    /// 	targetLocationType = $someBlueprintLocationType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.BlueprintLocationType]) for enum values.
    /// 	# REQUIRED
    /// 	children = @(
    /// 		@{
    /// 			# REQUIRED
    /// 			fid = $someString
    /// 			# REQUIRED
    /// 			snappableType = $someObjectTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ObjectTypeEnum]) for enum values.
    /// 			# REQUIRED
    /// 			bootPriority = $someInt
    /// 			# OPTIONAL
    /// 			lastRecoveryPoint = $someInt64
    /// 		}
    /// 	)
    /// 	# REQUIRED
    /// 	version = $someInt
    /// 	# REQUIRED
    /// 	isHydrationEnabled = $someBoolean
    /// 	# REQUIRED
    /// 	pauseBetweenPriorityGroups = @(
    /// 		$someInt64
    /// 	)
    /// 	# REQUIRED
    /// 	isVisible = $someBoolean
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: UpdateRecoveryPlanReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the UpdateRecoverySchedule operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: UpdateRecoverySchedule
    /// 
    /// $query = New-RscMutationMisc -UpdateRecoverySchedule
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	recoveryPlanFid = $someString
    /// 	# REQUIRED
    /// 	scheduleInfo = @{
    /// 		# OPTIONAL
    /// 		startRunTime = $someDateTime
    /// 		# OPTIONAL
    /// 		timezone = $someString
    /// 		# OPTIONAL
    /// 		frequency = $someScheduleFrequency # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ScheduleFrequency]) for enum values.
    /// 		# OPTIONAL
    /// 		recoveryConfig = @{
    /// 			# OPTIONAL
    /// 			dataTransferType = $someDataTransferType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DataTransferType]) for enum values.
    /// 		}
    /// 		# OPTIONAL
    /// 		recipients = @(
    /// 			$someString
    /// 		)
    /// 	}
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: System.String
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the UpdateRoleAssignments operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: UpdateRoleAssignments
    /// 
    /// $query = New-RscMutationMisc -UpdateRoleAssignments
    /// 
    /// # OPTIONAL
    /// $query.Var.userIds = @(
    /// 	$someString
    /// )
    /// # OPTIONAL
    /// $query.Var.groupIds = @(
    /// 	$someString
    /// )
    /// # REQUIRED
    /// $query.Var.roleIds = @(
    /// 	$someString
    /// )
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: System.Boolean
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the UpdateSnapMirrorCloud operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: UpdateSnapMirrorCloud
    /// 
    /// $query = New-RscMutationMisc -UpdateSnapMirrorCloud
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	id = $someString
    /// 	# REQUIRED
    /// 	snapmirrorCloudUpdateConfig = @{
    /// 		# REQUIRED
    /// 		snapMirrorLabel = $someString
    /// 	}
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: UpdateSnapMirrorCloudReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the UpdateSupportCase operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: UpdateSupportCase
    /// 
    /// $query = New-RscMutationMisc -UpdateSupportCase
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	caseId = $someString
    /// 	# OPTIONAL
    /// 	clusterUuid = $someString
    /// 	# REQUIRED
    /// 	attachments = @(
    /// 		@{
    /// 			# REQUIRED
    /// 			name = $someString
    /// 			# REQUIRED
    /// 			type = $someString
    /// 			# REQUIRED
    /// 			contentBase64 = $someString
    /// 		}
    /// 	)
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: UpdateSupportCaseReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the UpdateSupportUserAccess operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: UpdateSupportUserAccess
    /// 
    /// $query = New-RscMutationMisc -UpdateSupportUserAccess
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	id = $someInt
    /// 	# OPTIONAL
    /// 	impersonatedUserId = $someString
    /// 	# OPTIONAL
    /// 	newDurationInHours = $someInt
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: System.String
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the UpdateTprConfiguration operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: UpdateTprConfiguration
    /// 
    /// $query = New-RscMutationMisc -UpdateTprConfiguration
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	organizationId = $someString
    /// 	# OPTIONAL
    /// 	executionMaxTimeoutHours = $someInt
    /// 	# OPTIONAL
    /// 	requestTimeoutHours = $someInt
    /// 	# OPTIONAL
    /// 	reminderHours = $someInt
    /// 	# OPTIONAL
    /// 	staticQuorumApprovalsRequirement = $someInt
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: System.String
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the UpdateTunnelStatus operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: UpdateTunnelStatus
    /// 
    /// $query = New-RscMutationMisc -UpdateTunnelStatus
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	clusterUuid = $someString
    /// 	# REQUIRED
    /// 	config = @{
    /// 		# OPTIONAL
    /// 		inactivityTimeoutInSeconds = $someInt64
    /// 		# REQUIRED
    /// 		isTunnelEnabled = $someBoolean
    /// 	}
    /// 	# REQUIRED
    /// 	id = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: UpdateTunnelStatusReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the UpdateVcdInstances operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: UpdateVcdInstances
    /// 
    /// $query = New-RscMutationMisc -UpdateVcdInstances
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	vcdConfigs = @(
    /// 		@{
    /// 			# REQUIRED
    /// 			clusterUuid = $someString
    /// 			# REQUIRED
    /// 			id = $someString
    /// 			# REQUIRED
    /// 			definition = @{
    /// 				# OPTIONAL
    /// 				caCerts = $someString
    /// 				# OPTIONAL
    /// 				configuredSlaDomainId = $someString
    /// 				# OPTIONAL
    /// 				hostname = $someString
    /// 				# OPTIONAL
    /// 				password = $someString
    /// 				# OPTIONAL
    /// 				username = $someString
    /// 			}
    /// 		}
    /// 	)
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: UpdateVcdInstancesReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the UpdateVcdVapp operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: UpdateVcdVapp
    /// 
    /// $query = New-RscMutationMisc -UpdateVcdVapp
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	id = $someString
    /// 	# REQUIRED
    /// 	patchProperties = @{
    /// 		# OPTIONAL
    /// 		configuredSlaDomainId = $someString
    /// 		# OPTIONAL
    /// 		isBestEffortSynchronizationEnabled = $someBoolean
    /// 		# OPTIONAL
    /// 		isPaused = $someBoolean
    /// 		# OPTIONAL
    /// 		vcdVmMoidsToExcludeFromSnapshot = @(
    /// 			$someString
    /// 		)
    /// 	}
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: System.String
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the UpdateVlan operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: UpdateVlan
    /// 
    /// $query = New-RscMutationMisc -UpdateVlan
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	id = $someString
    /// 	# REQUIRED
    /// 	vlanInfo = @{
    /// 		# OPTIONAL
    /// 		gateway = $someString
    /// 		# OPTIONAL
    /// 		alias = $someString
    /// 		# REQUIRED
    /// 		interfaces = @(
    /// 			@{
    /// 				# REQUIRED
    /// 				ip = $someString
    /// 				# REQUIRED
    /// 				node = $someString
    /// 			}
    /// 		)
    /// 		# REQUIRED
    /// 		netmask = $someString
    /// 		# REQUIRED
    /// 		vlan = $someInt
    /// 	}
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: System.String
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the UpdateVolumeGroup operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: UpdateVolumeGroup
    /// 
    /// $query = New-RscMutationMisc -UpdateVolumeGroup
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	id = $someString
    /// 	# REQUIRED
    /// 	patchProperties = @{
    /// 		# OPTIONAL
    /// 		configuredSlaDomainId = $someString
    /// 		# OPTIONAL
    /// 		isPaused = $someBoolean
    /// 		# OPTIONAL
    /// 		volumeIdsIncludedInSnapshots = @(
    /// 			$someString
    /// 		)
    /// 		# OPTIONAL
    /// 		forceFull = $someBoolean
    /// 	}
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: UpdateVolumeGroupReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the UpdateWhitelistedAnalyzers operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: UpdateWhitelistedAnalyzers
    /// 
    /// $query = New-RscMutationMisc -UpdateWhitelistedAnalyzers
    /// 
    /// # REQUIRED
    /// $query.Var.stdPath = $someString
    /// # REQUIRED
    /// $query.Var.snappableFid = $someString
    /// # REQUIRED
    /// $query.Var.snapshotFid = $someString
    /// # REQUIRED
    /// $query.Var.analyzerIds = @(
    /// 	$someString
    /// )
    /// # REQUIRED
    /// $query.Var.runAsync = $someBoolean
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: System.String
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the UpgradeIoFilter operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: UpgradeIoFilter
    /// 
    /// $query = New-RscMutationMisc -UpgradeIoFilter
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	fqdnInfo = @{
    /// 		# REQUIRED
    /// 		fqdn = $someString
    /// 	}
    /// 	# REQUIRED
    /// 	id = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: RequestSuccess
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the UpgradeToRsc operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: UpgradeToRsc
    /// 
    /// $query = New-RscMutationMisc -UpgradeToRsc
    /// 
    /// # No variables for this query.
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: System.String
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the ValidateAndSaveCustomerKmsInfo operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: ValidateAndSaveCustomerKmsInfo
    /// 
    /// $query = New-RscMutationMisc -ValidateAndSaveCustomerKmsInfo
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	kmsSpec = @{
    /// 		# OPTIONAL
    /// 		cloudType = $someO365AzureCloudType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.O365AzureCloudType]) for enum values.
    /// 		# OPTIONAL
    /// 		tenantId = $someString
    /// 		# OPTIONAL
    /// 		kmsId = $someString
    /// 		# OPTIONAL
    /// 		appId = $someString
    /// 		# OPTIONAL
    /// 		appSecret = $someString
    /// 		# OPTIONAL
    /// 		keyName = $someString
    /// 		# OPTIONAL
    /// 		kekNameColossus = $someString
    /// 	}
    /// 	# REQUIRED
    /// 	appSecret = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: ValidateAndSaveCustomerKmsInfoReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the ValidateBlueprint operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: ValidateBlueprint
    /// 
    /// $query = New-RscMutationMisc -ValidateBlueprint
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	blueprintId = $someString
    /// 	# REQUIRED
    /// 	blueprintFailoverProperties = @{
    /// 		# OPTIONAL
    /// 		planType = $somePlanName # Call [Enum]::GetValues([RubrikSecurityCloud.Types.PlanName]) for enum values.
    /// 		# OPTIONAL
    /// 		dataTransferType = $someDataTransferType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DataTransferType]) for enum values.
    /// 		# OPTIONAL
    /// 		targetLocation = @{
    /// 			# OPTIONAL
    /// 			locationId = $someString
    /// 			# OPTIONAL
    /// 			locationType = $someLocationType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.LocationType]) for enum values.
    /// 		}
    /// 	}
    /// 	# REQUIRED
    /// 	childSnappableFailoverInfos = @(
    /// 		@{
    /// 			# OPTIONAL
    /// 			snappableId = $someString
    /// 			# OPTIONAL
    /// 			recoveryPoint = $someInt64
    /// 		}
    /// 	)
    /// 	# OPTIONAL
    /// 	enableRecoveryWithRba = $someBoolean
    /// 	# OPTIONAL
    /// 	skipSnappableRecoveryStatusValidation = $someBoolean
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: ValidateBlueprintReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the ValidateBlueprintRecoverySpec operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: ValidateBlueprintRecoverySpec
    /// 
    /// $query = New-RscMutationMisc -ValidateBlueprintRecoverySpec
    /// 
    /// # REQUIRED
    /// $query.Var.blueprintId = $someString
    /// # OPTIONAL
    /// $query.Var.validateSnapshotRecoverySpec = $someBoolean
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: ValidateBlueprintRecoverySpecReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the ValidateBlueprints operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: ValidateBlueprints
    /// 
    /// $query = New-RscMutationMisc -ValidateBlueprints
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	blueprintDetails = @(
    /// 		@{
    /// 			# REQUIRED
    /// 			blueprintId = $someString
    /// 			# REQUIRED
    /// 			blueprintFailoverProperties = @{
    /// 				# OPTIONAL
    /// 				planType = $somePlanName # Call [Enum]::GetValues([RubrikSecurityCloud.Types.PlanName]) for enum values.
    /// 				# OPTIONAL
    /// 				dataTransferType = $someDataTransferType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DataTransferType]) for enum values.
    /// 				# OPTIONAL
    /// 				targetLocation = @{
    /// 					# OPTIONAL
    /// 					locationId = $someString
    /// 					# OPTIONAL
    /// 					locationType = $someLocationType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.LocationType]) for enum values.
    /// 				}
    /// 			}
    /// 			# REQUIRED
    /// 			childSnappableFailoverInfos = @(
    /// 				@{
    /// 					# OPTIONAL
    /// 					snappableId = $someString
    /// 					# OPTIONAL
    /// 					recoveryPoint = $someInt64
    /// 				}
    /// 			)
    /// 			# OPTIONAL
    /// 			enableRecoveryWithRba = $someBoolean
    /// 			# OPTIONAL
    /// 			skipSnappableRecoveryStatusValidation = $someBoolean
    /// 		}
    /// 	)
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: ValidateBlueprintsReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the ValidateCompleteOperationalRecoveryFeasibility operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: ValidateCompleteOperationalRecoveryFeasibility
    /// 
    /// $query = New-RscMutationMisc -ValidateCompleteOperationalRecoveryFeasibility
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	bulkRecoveryInstanceId = $someString
    /// 	# OPTIONAL
    /// 	bulkRecoveryTaskchainId = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: ValidateCompleteOperationalRecoveryFeasibilityReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the ValidateTicketingPlatformConfig operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: ValidateTicketingPlatformConfig
    /// 
    /// $query = New-RscMutationMisc -ValidateTicketingPlatformConfig
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	platformConfig = @{
    /// 		# REQUIRED
    /// 		platformType = $someTicketingPlatform # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TicketingPlatform]) for enum values.
    /// 		# REQUIRED
    /// 		instanceUrl = $someString
    /// 	}
    /// 	# REQUIRED
    /// 	oauthConfig = @{
    /// 		# REQUIRED
    /// 		username = $someString
    /// 		# REQUIRED
    /// 		password = $someString
    /// 		# REQUIRED
    /// 		clientId = $someString
    /// 		# REQUIRED
    /// 		clientSecret = $someString
    /// 	}
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: ValidateTicketingPlatformConfigReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the VmMakePrimary operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: VmMakePrimary
    /// 
    /// $query = New-RscMutationMisc -VmMakePrimary
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	ids = @(
    /// 		$someString
    /// 	)
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AsyncRequestStatus
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the VpshereVMRecoveryPointMount operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: VpshereVMRecoveryPointMount
    /// 
    /// $query = New-RscMutationMisc -VpshereVMRecoveryPointMount
    /// 
    /// # OPTIONAL
    /// $query.Var.snapshotFid = $someString
    /// # REQUIRED
    /// $query.Var.snappableFid = $someString
    /// # OPTIONAL
    /// $query.Var.vmName = $someString
    /// # OPTIONAL
    /// $query.Var.disableNetwork = $someBoolean
    /// # OPTIONAL
    /// $query.Var.removeNetworkDevices = $someBoolean
    /// # OPTIONAL
    /// $query.Var.powerOn = $someBoolean
    /// # OPTIONAL
    /// $query.Var.keepMacAddresses = $someBoolean
    /// # OPTIONAL
    /// $query.Var.hostID = $someString
    /// # OPTIONAL
    /// $query.Var.datastoreName = $someString
    /// # OPTIONAL
    /// $query.Var.vlan = $someInt
    /// # OPTIONAL
    /// $query.Var.unregsiterVm = $someBoolean
    /// # OPTIONAL
    /// $query.Var.shouldRecoverTags = $someBoolean
    /// # OPTIONAL
    /// $query.Var.recoveryPoint = $someString
    /// # OPTIONAL
    /// $query.Var.createDatastoreOnly = $someBoolean
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: VsphereAsyncRequestStatus
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the WarmSearchCache operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: WarmSearchCache
    /// 
    /// $query = New-RscMutationMisc -WarmSearchCache
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	workloadFid = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: System.Boolean
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscMutationMisc",
        DefaultParameterSetName = "Operation")
    ]
    public class New_RscMutationMisc : RscGqlPSCmdlet
    {
        [Parameter(
            Mandatory = true, 
            ParameterSetName = "Operation",
            HelpMessage = "API Operation. The set of operations depends on the API domain. See reference at: https://github.com/rubrikinc/rubrik-powershell-sdk/blob/main/docs/domains_and_operations.md",
            Position = 0,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = true)]
            [ValidateSet(
                "AcknowledgeFedrampBoundaryExit",
                "ActivateTrialAsync",
                "AddAdGroupsToHierarchy",
                "AddConfiguredGroupToHierarchy",
                "AddCustomIntelFeed",
                "AddInventoryWorkloads",
                "AddRoleAssignments",
                "AddSaasAppRecoveryOrg",
                "AddVcdInstances",
                "AddVlan",
                "AddVmAppConsistentSpecs",
                "AirGapStatus",
                "ApproveTprRequest",
                "ArchiveCrawl",
                "AssignProtection",
                "BatchDeassignRoleFromUserGroups",
                "BatchRefreshDomains",
                "BulkAddKmipServer",
                "BulkCancelFailovers",
                "BulkCreateNasFilesets",
                "BulkUpdateSnapMirrorCloud",
                "CancelBlueprintFailover",
                "CancelBulkRecovery",
                "CancelDownloadPackage",
                "CancelJobInstance",
                "CancelScheduledUpgrade",
                "CancelTaskchain",
                "CancelTprRequest",
                "ChangePassword",
                "CheckStatus",
                "CleanupBlueprintFailover",
                "CleanupIsolatedRecoveries",
                "CleanupIsolatedRecovery",
                "CompleteOperationalRecovery",
                "CompleteSaasAppAuthConsent",
                "CompleteTrialOnboarding",
                "CompleteTrialTask",
                "ComputeBucketImmutabilityLockDuration",
                "ConfigureDns",
                "ConfigureLogExport",
                "ConfigureNtp",
                "ConfigureTicketingPlatformWithOAuth",
                "CreateBlueprint",
                "CreateBlueprintRecoverySpec",
                "CreateChat",
                "CreateChatbot",
                "CreateConfigProtectionBackup",
                "CreateConfigProtectionSetup",
                "CreateCustomAnalyzer",
                "CreateEventDigestBatch",
                "CreateGuestCredential",
                "CreateLegalHold",
                "CreateOnDemandVolumeGroupBackup",
                "CreateOrgNetwork",
                "CreatePasskey",
                "CreateRbacMigrationSummaryDownload",
                "CreateRecoveryPlan",
                "CreateRecoverySchedule",
                "CreateS3Bucket",
                "CreateSnapMirrorCloud",
                "CreateSnapMirrorCloudRelationship",
                "CreateSnapMirrorCloudRestoreJob",
                "CreateSsoUsers",
                "CreateSupportCase",
                "CreateUserAccessInsightTicket",
                "CreateVappExport",
                "CreateVappsInstantRecovery",
                "DeactivateCustomAnalyzer",
                "DeleteAccountSettingValue",
                "DeleteAdGroupsFromHierarchy",
                "DeleteBlueprint",
                "DeleteBlueprints",
                "DeleteBrandLogo",
                "DeleteChatbot",
                "DeleteDistributionListDigestBatch",
                "DeleteEnvoyNgs",
                "DeleteEventDigest",
                "DeleteGuestCredentialById",
                "DeleteIdentityProvider",
                "DeleteIntelFeed",
                "DeleteKmipServer",
                "DeleteKmsInstance",
                "DeleteOrgNetwork",
                "DeletePasskey",
                "DeleteRecoveryPlan",
                "DeleteRecoveryPlans",
                "DeleteRecoverySchedule",
                "DeleteRecoverySpec",
                "DeleteSmtpConfiguration",
                "DeleteSnapMirrorCloud",
                "DeleteSnapMirrorCloudRelationship",
                "DeleteVcdInstances",
                "DeleteVolumeGroupMount",
                "DenyTprRequests",
                "DeregisterPrivateContainerRegistry",
                "DisableSupportUserAccess",
                "DisableTprOrg",
                "DisconnectTicketingPlatform",
                "DissolveLegalHold",
                "EditPasskey",
                "EditSalesforceOrganization",
                "EnableAutomaticFmdUpload",
                "EnableDisableAppConsistency",
                "EnableLambdaForWorkload",
                "EnableMigrationWorkflow",
                "EnableSupportUserAccess",
                "EnableTprOrg",
                "ExcludeVmDisks",
                "ExecuteTprRequests",
                "ExpireSnoozedDirectories",
                "ExportPrincipalsSummary",
                "ExportUnAccessedUsersSummary",
                "ExtendRscAutoUpgradeDate",
                "ExtendTrialAsync",
                "GenerateConfigProtectionRestoreForm",
                "GenerateSupportBundle",
                "GetDownloadUrl",
                "HideRevealNasNamespaces",
                "IgnoreTrial",
                "InstallIoFilter",
                "InviteSsoGroup",
                "InviteUsersToTrial",
                "ListCidrsForComputeSetting",
                "LockIsolatedRecovery",
                "LockUsersByAdmin",
                "LogoutFromRubrikSupportPortal",
                "MakePrimary",
                "MarkNotificationsAsRead",
                "ModifyEventDigestBatch",
                "ModifyIpmi",
                "MountDisk",
                "NotificationForGetLicense",
                "PromoteRecovery",
                "RecoverCloudDirectMultiPaths",
                "RecoverCloudDirectPath",
                "RefreshDomain",
                "RefreshGlobalManagerConnectivityStatus",
                "RefreshOrgNetwork",
                "RefreshVcdInstances",
                "RegisterAndEnableMigrationChoice",
                "RemoveDisk",
                "RemoveInventoryWorkloads",
                "RemoveNodeForReplacement",
                "RemovePrivateEndpointList",
                "RemoveProxyConfig",
                "RemoveVlans",
                "ReseedLogShippingSecondary",
                "ResetAllOrgUsersPasswords",
                "ResetMigrationOnModeChange",
                "ResetPasskeys",
                "ResetUsersPasswordsWithUserIds",
                "ResizeDisk",
                "ResolveAnomaly",
                "ResolveVolumeGroupsConflict",
                "RestoreConfigProtectionBackup",
                "RetryBackup",
                "RetryDownloadPackageJob",
                "RevokeAllOrgRoles",
                "RunCustomAnalyzer",
                "RunPrechecks",
                "ScheduleUpgradeBatchJob",
                "SendEmailNow",
                "SendPactsafeEvent",
                "SendTestSmtpEmail",
                "SetAccountSettingValue",
                "SetAnalyzerRisks",
                "SetBrandLogo",
                "SetBundleApprovalStatus",
                "SetCorsSetting",
                "SetCustomerTags",
                "SetDatastoreFreespaceThresholds",
                "SetFederatedLoginStatus",
                "SetIdentityProvider",
                "SetIpWhitelistEnabled",
                "SetKmipClient",
                "SetLiveMountIps",
                "SetMfaSetting",
                "SetMigrationStatus",
                "SetPasskeyConfig",
                "SetPrivateContainerRegistry",
                "SetSmtpConfiguration",
                "SetTotpConfig",
                "SetUpgradeType",
                "SetUserLevelTotpEnforcement",
                "SetUserSessionManagementConfig",
                "SetUserSetting",
                "SetWorkloadAlertSetting",
                "SetWwwTlsCert",
                "SetupAtlassianSite",
                "SetupDisk",
                "SetupSalesforceOrganization",
                "SnoozeEula",
                "StartBlueprintFailover",
                "StartBlueprintsFailover",
                "StartBulkRecovery",
                "StartCrawl",
                "StartCyberRecovery",
                "StartDownloadPackageBatchJob",
                "StartExportRdsInstanceJob",
                "StartFetchCdmRbacConfigJob",
                "StartMalwareDetection",
                "StartMigrateCdmRbacConfigJob",
                "StartMultipleBulkRecoveries",
                "StartNasAutomigrationJob",
                "StartPeriodicUpgradePrechecksOnDemandJob",
                "StartSaasAppAuthConsent",
                "StartSaasAppsDeleteOrg",
                "StartUpgradeBatchJob",
                "StartVolumeGroupMount",
                "StopJobInstance",
                "StopJobInstanceFromEventSeries",
                "SubmitTprRequest",
                "SupportPortalLogin",
                "SwitchProductToOnboardingMode",
                "ToggleFeatureEnabled",
                "TriggerCloudComputeConnectivityCheck",
                "TriggerExocomputeHealthCheck",
                "UninstallIoFilter",
                "UnlockUsersByAdmin",
                "UnmountDisk",
                "UpdateAccountOwner",
                "UpdateAccountSettings",
                "UpdateAdGroup",
                "UpdateAgentDeploymentSetting",
                "UpdateAgentDeploymentSettingInBatch",
                "UpdateAuthDomainUsersHiddenStatus",
                "UpdateBackupThrottleSetting",
                "UpdateBadDiskLedStatus",
                "UpdateBlueprint",
                "UpdateChat",
                "UpdateChatbot",
                "UpdateClassificationBannerEnabled",
                "UpdateClassificationBannerSettings",
                "UpdateClassificationLoginEnabled",
                "UpdateClassificationLoginSettings",
                "UpdateConfigProtectionSetup",
                "UpdateConfiguredGroup",
                "UpdateCustomAnalyzer",
                "UpdateCustomIntelFeed",
                "UpdateCustomerAppPermissions",
                "UpdateCyberEventLockdown",
                "UpdateDistributionListDigest",
                "UpdateDnsServersAndSearchDomains",
                "UpdateEulaAccepted",
                "UpdateEventDigest",
                "UpdateFloatingIps",
                "UpdateGuestCredential",
                "UpdateIdentityProvider",
                "UpdateInsightState",
                "UpdateIocStatus",
                "UpdateIpWhitelist",
                "UpdateKmipServer",
                "UpdateLambdaSettings",
                "UpdateLlmEnabled",
                "UpdateLockoutConfig",
                "UpdateManagedIdentities",
                "UpdateNetworkThrottle",
                "UpdateOrgNetwork",
                "UpdatePactsafeEulaAccepted",
                "UpdatePactsafeEulaSeen",
                "UpdateProxyConfig",
                "UpdateReaderLocationMasterKeyWithOwnerLocationKey",
                "UpdateReaderLocationMasterKeyWithRsaKey",
                "UpdateRecoveryPlan",
                "UpdateRecoverySchedule",
                "UpdateRoleAssignments",
                "UpdateSnapMirrorCloud",
                "UpdateSupportCase",
                "UpdateSupportUserAccess",
                "UpdateTprConfiguration",
                "UpdateTunnelStatus",
                "UpdateVcdInstances",
                "UpdateVcdVapp",
                "UpdateVlan",
                "UpdateVolumeGroup",
                "UpdateWhitelistedAnalyzers",
                "UpgradeIoFilter",
                "UpgradeToRsc",
                "ValidateAndSaveCustomerKmsInfo",
                "ValidateBlueprint",
                "ValidateBlueprintRecoverySpec",
                "ValidateBlueprints",
                "ValidateCompleteOperationalRecoveryFeasibility",
                "ValidateTicketingPlatformConfig",
                "VmMakePrimary",
                "VpshereVMRecoveryPointMount",
                "WarmSearchCache",
                IgnoreCase = true)]
        public string Operation { get; set; } = "";

        internal override string GetOperationParameter()
        {
            return this.Operation;
        }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                switch(this.GetOp().OpName())
                {
                    case "AcknowledgeFedrampBoundaryExit":
                        this.ProcessRecord_AcknowledgeFedrampBoundaryExit();
                        break;
                    case "ActivateTrialAsync":
                        this.ProcessRecord_ActivateTrialAsync();
                        break;
                    case "AddAdGroupsToHierarchy":
                        this.ProcessRecord_AddAdGroupsToHierarchy();
                        break;
                    case "AddConfiguredGroupToHierarchy":
                        this.ProcessRecord_AddConfiguredGroupToHierarchy();
                        break;
                    case "AddCustomIntelFeed":
                        this.ProcessRecord_AddCustomIntelFeed();
                        break;
                    case "AddInventoryWorkloads":
                        this.ProcessRecord_AddInventoryWorkloads();
                        break;
                    case "AddRoleAssignments":
                        this.ProcessRecord_AddRoleAssignments();
                        break;
                    case "AddSaasAppRecoveryOrg":
                        this.ProcessRecord_AddSaasAppRecoveryOrg();
                        break;
                    case "AddVcdInstances":
                        this.ProcessRecord_AddVcdInstances();
                        break;
                    case "AddVlan":
                        this.ProcessRecord_AddVlan();
                        break;
                    case "AddVmAppConsistentSpecs":
                        this.ProcessRecord_AddVmAppConsistentSpecs();
                        break;
                    case "AirGapStatus":
                        this.ProcessRecord_AirGapStatus();
                        break;
                    case "ApproveTprRequest":
                        this.ProcessRecord_ApproveTprRequest();
                        break;
                    case "ArchiveCrawl":
                        this.ProcessRecord_ArchiveCrawl();
                        break;
                    case "AssignProtection":
                        this.ProcessRecord_AssignProtection();
                        break;
                    case "BatchDeassignRoleFromUserGroups":
                        this.ProcessRecord_BatchDeassignRoleFromUserGroups();
                        break;
                    case "BatchRefreshDomains":
                        this.ProcessRecord_BatchRefreshDomains();
                        break;
                    case "BulkAddKmipServer":
                        this.ProcessRecord_BulkAddKmipServer();
                        break;
                    case "BulkCancelFailovers":
                        this.ProcessRecord_BulkCancelFailovers();
                        break;
                    case "BulkCreateNasFilesets":
                        this.ProcessRecord_BulkCreateNasFilesets();
                        break;
                    case "BulkUpdateSnapMirrorCloud":
                        this.ProcessRecord_BulkUpdateSnapMirrorCloud();
                        break;
                    case "CancelBlueprintFailover":
                        this.ProcessRecord_CancelBlueprintFailover();
                        break;
                    case "CancelBulkRecovery":
                        this.ProcessRecord_CancelBulkRecovery();
                        break;
                    case "CancelDownloadPackage":
                        this.ProcessRecord_CancelDownloadPackage();
                        break;
                    case "CancelJobInstance":
                        this.ProcessRecord_CancelJobInstance();
                        break;
                    case "CancelScheduledUpgrade":
                        this.ProcessRecord_CancelScheduledUpgrade();
                        break;
                    case "CancelTaskchain":
                        this.ProcessRecord_CancelTaskchain();
                        break;
                    case "CancelTprRequest":
                        this.ProcessRecord_CancelTprRequest();
                        break;
                    case "ChangePassword":
                        this.ProcessRecord_ChangePassword();
                        break;
                    case "CheckStatus":
                        this.ProcessRecord_CheckStatus();
                        break;
                    case "CleanupBlueprintFailover":
                        this.ProcessRecord_CleanupBlueprintFailover();
                        break;
                    case "CleanupIsolatedRecoveries":
                        this.ProcessRecord_CleanupIsolatedRecoveries();
                        break;
                    case "CleanupIsolatedRecovery":
                        this.ProcessRecord_CleanupIsolatedRecovery();
                        break;
                    case "CompleteOperationalRecovery":
                        this.ProcessRecord_CompleteOperationalRecovery();
                        break;
                    case "CompleteSaasAppAuthConsent":
                        this.ProcessRecord_CompleteSaasAppAuthConsent();
                        break;
                    case "CompleteTrialOnboarding":
                        this.ProcessRecord_CompleteTrialOnboarding();
                        break;
                    case "CompleteTrialTask":
                        this.ProcessRecord_CompleteTrialTask();
                        break;
                    case "ComputeBucketImmutabilityLockDuration":
                        this.ProcessRecord_ComputeBucketImmutabilityLockDuration();
                        break;
                    case "ConfigureDns":
                        this.ProcessRecord_ConfigureDns();
                        break;
                    case "ConfigureLogExport":
                        this.ProcessRecord_ConfigureLogExport();
                        break;
                    case "ConfigureNtp":
                        this.ProcessRecord_ConfigureNtp();
                        break;
                    case "ConfigureTicketingPlatformWithOAuth":
                        this.ProcessRecord_ConfigureTicketingPlatformWithOAuth();
                        break;
                    case "CreateBlueprint":
                        this.ProcessRecord_CreateBlueprint();
                        break;
                    case "CreateBlueprintRecoverySpec":
                        this.ProcessRecord_CreateBlueprintRecoverySpec();
                        break;
                    case "CreateChat":
                        this.ProcessRecord_CreateChat();
                        break;
                    case "CreateChatbot":
                        this.ProcessRecord_CreateChatbot();
                        break;
                    case "CreateConfigProtectionBackup":
                        this.ProcessRecord_CreateConfigProtectionBackup();
                        break;
                    case "CreateConfigProtectionSetup":
                        this.ProcessRecord_CreateConfigProtectionSetup();
                        break;
                    case "CreateCustomAnalyzer":
                        this.ProcessRecord_CreateCustomAnalyzer();
                        break;
                    case "CreateEventDigestBatch":
                        this.ProcessRecord_CreateEventDigestBatch();
                        break;
                    case "CreateGuestCredential":
                        this.ProcessRecord_CreateGuestCredential();
                        break;
                    case "CreateLegalHold":
                        this.ProcessRecord_CreateLegalHold();
                        break;
                    case "CreateOnDemandVolumeGroupBackup":
                        this.ProcessRecord_CreateOnDemandVolumeGroupBackup();
                        break;
                    case "CreateOrgNetwork":
                        this.ProcessRecord_CreateOrgNetwork();
                        break;
                    case "CreatePasskey":
                        this.ProcessRecord_CreatePasskey();
                        break;
                    case "CreateRbacMigrationSummaryDownload":
                        this.ProcessRecord_CreateRbacMigrationSummaryDownload();
                        break;
                    case "CreateRecoveryPlan":
                        this.ProcessRecord_CreateRecoveryPlan();
                        break;
                    case "CreateRecoverySchedule":
                        this.ProcessRecord_CreateRecoverySchedule();
                        break;
                    case "CreateS3Bucket":
                        this.ProcessRecord_CreateS3Bucket();
                        break;
                    case "CreateSnapMirrorCloud":
                        this.ProcessRecord_CreateSnapMirrorCloud();
                        break;
                    case "CreateSnapMirrorCloudRelationship":
                        this.ProcessRecord_CreateSnapMirrorCloudRelationship();
                        break;
                    case "CreateSnapMirrorCloudRestoreJob":
                        this.ProcessRecord_CreateSnapMirrorCloudRestoreJob();
                        break;
                    case "CreateSsoUsers":
                        this.ProcessRecord_CreateSsoUsers();
                        break;
                    case "CreateSupportCase":
                        this.ProcessRecord_CreateSupportCase();
                        break;
                    case "CreateUserAccessInsightTicket":
                        this.ProcessRecord_CreateUserAccessInsightTicket();
                        break;
                    case "CreateVappExport":
                        this.ProcessRecord_CreateVappExport();
                        break;
                    case "CreateVappsInstantRecovery":
                        this.ProcessRecord_CreateVappsInstantRecovery();
                        break;
                    case "DeactivateCustomAnalyzer":
                        this.ProcessRecord_DeactivateCustomAnalyzer();
                        break;
                    case "DeleteAccountSettingValue":
                        this.ProcessRecord_DeleteAccountSettingValue();
                        break;
                    case "DeleteAdGroupsFromHierarchy":
                        this.ProcessRecord_DeleteAdGroupsFromHierarchy();
                        break;
                    case "DeleteBlueprint":
                        this.ProcessRecord_DeleteBlueprint();
                        break;
                    case "DeleteBlueprints":
                        this.ProcessRecord_DeleteBlueprints();
                        break;
                    case "DeleteBrandLogo":
                        this.ProcessRecord_DeleteBrandLogo();
                        break;
                    case "DeleteChatbot":
                        this.ProcessRecord_DeleteChatbot();
                        break;
                    case "DeleteDistributionListDigestBatch":
                        this.ProcessRecord_DeleteDistributionListDigestBatch();
                        break;
                    case "DeleteEnvoyNgs":
                        this.ProcessRecord_DeleteEnvoyNgs();
                        break;
                    case "DeleteEventDigest":
                        this.ProcessRecord_DeleteEventDigest();
                        break;
                    case "DeleteGuestCredentialById":
                        this.ProcessRecord_DeleteGuestCredentialById();
                        break;
                    case "DeleteIdentityProvider":
                        this.ProcessRecord_DeleteIdentityProvider();
                        break;
                    case "DeleteIntelFeed":
                        this.ProcessRecord_DeleteIntelFeed();
                        break;
                    case "DeleteKmipServer":
                        this.ProcessRecord_DeleteKmipServer();
                        break;
                    case "DeleteKmsInstance":
                        this.ProcessRecord_DeleteKmsInstance();
                        break;
                    case "DeleteOrgNetwork":
                        this.ProcessRecord_DeleteOrgNetwork();
                        break;
                    case "DeletePasskey":
                        this.ProcessRecord_DeletePasskey();
                        break;
                    case "DeleteRecoveryPlan":
                        this.ProcessRecord_DeleteRecoveryPlan();
                        break;
                    case "DeleteRecoveryPlans":
                        this.ProcessRecord_DeleteRecoveryPlans();
                        break;
                    case "DeleteRecoverySchedule":
                        this.ProcessRecord_DeleteRecoverySchedule();
                        break;
                    case "DeleteRecoverySpec":
                        this.ProcessRecord_DeleteRecoverySpec();
                        break;
                    case "DeleteSmtpConfiguration":
                        this.ProcessRecord_DeleteSmtpConfiguration();
                        break;
                    case "DeleteSnapMirrorCloud":
                        this.ProcessRecord_DeleteSnapMirrorCloud();
                        break;
                    case "DeleteSnapMirrorCloudRelationship":
                        this.ProcessRecord_DeleteSnapMirrorCloudRelationship();
                        break;
                    case "DeleteVcdInstances":
                        this.ProcessRecord_DeleteVcdInstances();
                        break;
                    case "DeleteVolumeGroupMount":
                        this.ProcessRecord_DeleteVolumeGroupMount();
                        break;
                    case "DenyTprRequests":
                        this.ProcessRecord_DenyTprRequests();
                        break;
                    case "DeregisterPrivateContainerRegistry":
                        this.ProcessRecord_DeregisterPrivateContainerRegistry();
                        break;
                    case "DisableSupportUserAccess":
                        this.ProcessRecord_DisableSupportUserAccess();
                        break;
                    case "DisableTprOrg":
                        this.ProcessRecord_DisableTprOrg();
                        break;
                    case "DisconnectTicketingPlatform":
                        this.ProcessRecord_DisconnectTicketingPlatform();
                        break;
                    case "DissolveLegalHold":
                        this.ProcessRecord_DissolveLegalHold();
                        break;
                    case "EditPasskey":
                        this.ProcessRecord_EditPasskey();
                        break;
                    case "EditSalesforceOrganization":
                        this.ProcessRecord_EditSalesforceOrganization();
                        break;
                    case "EnableAutomaticFmdUpload":
                        this.ProcessRecord_EnableAutomaticFmdUpload();
                        break;
                    case "EnableDisableAppConsistency":
                        this.ProcessRecord_EnableDisableAppConsistency();
                        break;
                    case "EnableLambdaForWorkload":
                        this.ProcessRecord_EnableLambdaForWorkload();
                        break;
                    case "EnableMigrationWorkflow":
                        this.ProcessRecord_EnableMigrationWorkflow();
                        break;
                    case "EnableSupportUserAccess":
                        this.ProcessRecord_EnableSupportUserAccess();
                        break;
                    case "EnableTprOrg":
                        this.ProcessRecord_EnableTprOrg();
                        break;
                    case "ExcludeVmDisks":
                        this.ProcessRecord_ExcludeVmDisks();
                        break;
                    case "ExecuteTprRequests":
                        this.ProcessRecord_ExecuteTprRequests();
                        break;
                    case "ExpireSnoozedDirectories":
                        this.ProcessRecord_ExpireSnoozedDirectories();
                        break;
                    case "ExportPrincipalsSummary":
                        this.ProcessRecord_ExportPrincipalsSummary();
                        break;
                    case "ExportUnAccessedUsersSummary":
                        this.ProcessRecord_ExportUnAccessedUsersSummary();
                        break;
                    case "ExtendRscAutoUpgradeDate":
                        this.ProcessRecord_ExtendRscAutoUpgradeDate();
                        break;
                    case "ExtendTrialAsync":
                        this.ProcessRecord_ExtendTrialAsync();
                        break;
                    case "GenerateConfigProtectionRestoreForm":
                        this.ProcessRecord_GenerateConfigProtectionRestoreForm();
                        break;
                    case "GenerateSupportBundle":
                        this.ProcessRecord_GenerateSupportBundle();
                        break;
                    case "GetDownloadUrl":
                        this.ProcessRecord_GetDownloadUrl();
                        break;
                    case "HideRevealNasNamespaces":
                        this.ProcessRecord_HideRevealNasNamespaces();
                        break;
                    case "IgnoreTrial":
                        this.ProcessRecord_IgnoreTrial();
                        break;
                    case "InstallIoFilter":
                        this.ProcessRecord_InstallIoFilter();
                        break;
                    case "InviteSsoGroup":
                        this.ProcessRecord_InviteSsoGroup();
                        break;
                    case "InviteUsersToTrial":
                        this.ProcessRecord_InviteUsersToTrial();
                        break;
                    case "ListCidrsForComputeSetting":
                        this.ProcessRecord_ListCidrsForComputeSetting();
                        break;
                    case "LockIsolatedRecovery":
                        this.ProcessRecord_LockIsolatedRecovery();
                        break;
                    case "LockUsersByAdmin":
                        this.ProcessRecord_LockUsersByAdmin();
                        break;
                    case "LogoutFromRubrikSupportPortal":
                        this.ProcessRecord_LogoutFromRubrikSupportPortal();
                        break;
                    case "MakePrimary":
                        this.ProcessRecord_MakePrimary();
                        break;
                    case "MarkNotificationsAsRead":
                        this.ProcessRecord_MarkNotificationsAsRead();
                        break;
                    case "ModifyEventDigestBatch":
                        this.ProcessRecord_ModifyEventDigestBatch();
                        break;
                    case "ModifyIpmi":
                        this.ProcessRecord_ModifyIpmi();
                        break;
                    case "MountDisk":
                        this.ProcessRecord_MountDisk();
                        break;
                    case "NotificationForGetLicense":
                        this.ProcessRecord_NotificationForGetLicense();
                        break;
                    case "PromoteRecovery":
                        this.ProcessRecord_PromoteRecovery();
                        break;
                    case "RecoverCloudDirectMultiPaths":
                        this.ProcessRecord_RecoverCloudDirectMultiPaths();
                        break;
                    case "RecoverCloudDirectPath":
                        this.ProcessRecord_RecoverCloudDirectPath();
                        break;
                    case "RefreshDomain":
                        this.ProcessRecord_RefreshDomain();
                        break;
                    case "RefreshGlobalManagerConnectivityStatus":
                        this.ProcessRecord_RefreshGlobalManagerConnectivityStatus();
                        break;
                    case "RefreshOrgNetwork":
                        this.ProcessRecord_RefreshOrgNetwork();
                        break;
                    case "RefreshVcdInstances":
                        this.ProcessRecord_RefreshVcdInstances();
                        break;
                    case "RegisterAndEnableMigrationChoice":
                        this.ProcessRecord_RegisterAndEnableMigrationChoice();
                        break;
                    case "RemoveDisk":
                        this.ProcessRecord_RemoveDisk();
                        break;
                    case "RemoveInventoryWorkloads":
                        this.ProcessRecord_RemoveInventoryWorkloads();
                        break;
                    case "RemoveNodeForReplacement":
                        this.ProcessRecord_RemoveNodeForReplacement();
                        break;
                    case "RemovePrivateEndpointList":
                        this.ProcessRecord_RemovePrivateEndpointList();
                        break;
                    case "RemoveProxyConfig":
                        this.ProcessRecord_RemoveProxyConfig();
                        break;
                    case "RemoveVlans":
                        this.ProcessRecord_RemoveVlans();
                        break;
                    case "ReseedLogShippingSecondary":
                        this.ProcessRecord_ReseedLogShippingSecondary();
                        break;
                    case "ResetAllOrgUsersPasswords":
                        this.ProcessRecord_ResetAllOrgUsersPasswords();
                        break;
                    case "ResetMigrationOnModeChange":
                        this.ProcessRecord_ResetMigrationOnModeChange();
                        break;
                    case "ResetPasskeys":
                        this.ProcessRecord_ResetPasskeys();
                        break;
                    case "ResetUsersPasswordsWithUserIds":
                        this.ProcessRecord_ResetUsersPasswordsWithUserIds();
                        break;
                    case "ResizeDisk":
                        this.ProcessRecord_ResizeDisk();
                        break;
                    case "ResolveAnomaly":
                        this.ProcessRecord_ResolveAnomaly();
                        break;
                    case "ResolveVolumeGroupsConflict":
                        this.ProcessRecord_ResolveVolumeGroupsConflict();
                        break;
                    case "RestoreConfigProtectionBackup":
                        this.ProcessRecord_RestoreConfigProtectionBackup();
                        break;
                    case "RetryBackup":
                        this.ProcessRecord_RetryBackup();
                        break;
                    case "RetryDownloadPackageJob":
                        this.ProcessRecord_RetryDownloadPackageJob();
                        break;
                    case "RevokeAllOrgRoles":
                        this.ProcessRecord_RevokeAllOrgRoles();
                        break;
                    case "RunCustomAnalyzer":
                        this.ProcessRecord_RunCustomAnalyzer();
                        break;
                    case "RunPrechecks":
                        this.ProcessRecord_RunPrechecks();
                        break;
                    case "ScheduleUpgradeBatchJob":
                        this.ProcessRecord_ScheduleUpgradeBatchJob();
                        break;
                    case "SendEmailNow":
                        this.ProcessRecord_SendEmailNow();
                        break;
                    case "SendPactsafeEvent":
                        this.ProcessRecord_SendPactsafeEvent();
                        break;
                    case "SendTestSmtpEmail":
                        this.ProcessRecord_SendTestSmtpEmail();
                        break;
                    case "SetAccountSettingValue":
                        this.ProcessRecord_SetAccountSettingValue();
                        break;
                    case "SetAnalyzerRisks":
                        this.ProcessRecord_SetAnalyzerRisks();
                        break;
                    case "SetBrandLogo":
                        this.ProcessRecord_SetBrandLogo();
                        break;
                    case "SetBundleApprovalStatus":
                        this.ProcessRecord_SetBundleApprovalStatus();
                        break;
                    case "SetCorsSetting":
                        this.ProcessRecord_SetCorsSetting();
                        break;
                    case "SetCustomerTags":
                        this.ProcessRecord_SetCustomerTags();
                        break;
                    case "SetDatastoreFreespaceThresholds":
                        this.ProcessRecord_SetDatastoreFreespaceThresholds();
                        break;
                    case "SetFederatedLoginStatus":
                        this.ProcessRecord_SetFederatedLoginStatus();
                        break;
                    case "SetIdentityProvider":
                        this.ProcessRecord_SetIdentityProvider();
                        break;
                    case "SetIpWhitelistEnabled":
                        this.ProcessRecord_SetIpWhitelistEnabled();
                        break;
                    case "SetKmipClient":
                        this.ProcessRecord_SetKmipClient();
                        break;
                    case "SetLiveMountIps":
                        this.ProcessRecord_SetLiveMountIps();
                        break;
                    case "SetMfaSetting":
                        this.ProcessRecord_SetMfaSetting();
                        break;
                    case "SetMigrationStatus":
                        this.ProcessRecord_SetMigrationStatus();
                        break;
                    case "SetPasskeyConfig":
                        this.ProcessRecord_SetPasskeyConfig();
                        break;
                    case "SetPrivateContainerRegistry":
                        this.ProcessRecord_SetPrivateContainerRegistry();
                        break;
                    case "SetSmtpConfiguration":
                        this.ProcessRecord_SetSmtpConfiguration();
                        break;
                    case "SetTotpConfig":
                        this.ProcessRecord_SetTotpConfig();
                        break;
                    case "SetUpgradeType":
                        this.ProcessRecord_SetUpgradeType();
                        break;
                    case "SetUserLevelTotpEnforcement":
                        this.ProcessRecord_SetUserLevelTotpEnforcement();
                        break;
                    case "SetUserSessionManagementConfig":
                        this.ProcessRecord_SetUserSessionManagementConfig();
                        break;
                    case "SetUserSetting":
                        this.ProcessRecord_SetUserSetting();
                        break;
                    case "SetWorkloadAlertSetting":
                        this.ProcessRecord_SetWorkloadAlertSetting();
                        break;
                    case "SetWwwTlsCert":
                        this.ProcessRecord_SetWwwTlsCert();
                        break;
                    case "SetupAtlassianSite":
                        this.ProcessRecord_SetupAtlassianSite();
                        break;
                    case "SetupDisk":
                        this.ProcessRecord_SetupDisk();
                        break;
                    case "SetupSalesforceOrganization":
                        this.ProcessRecord_SetupSalesforceOrganization();
                        break;
                    case "SnoozeEula":
                        this.ProcessRecord_SnoozeEula();
                        break;
                    case "StartBlueprintFailover":
                        this.ProcessRecord_StartBlueprintFailover();
                        break;
                    case "StartBlueprintsFailover":
                        this.ProcessRecord_StartBlueprintsFailover();
                        break;
                    case "StartBulkRecovery":
                        this.ProcessRecord_StartBulkRecovery();
                        break;
                    case "StartCrawl":
                        this.ProcessRecord_StartCrawl();
                        break;
                    case "StartCyberRecovery":
                        this.ProcessRecord_StartCyberRecovery();
                        break;
                    case "StartDownloadPackageBatchJob":
                        this.ProcessRecord_StartDownloadPackageBatchJob();
                        break;
                    case "StartExportRdsInstanceJob":
                        this.ProcessRecord_StartExportRdsInstanceJob();
                        break;
                    case "StartFetchCdmRbacConfigJob":
                        this.ProcessRecord_StartFetchCdmRbacConfigJob();
                        break;
                    case "StartMalwareDetection":
                        this.ProcessRecord_StartMalwareDetection();
                        break;
                    case "StartMigrateCdmRbacConfigJob":
                        this.ProcessRecord_StartMigrateCdmRbacConfigJob();
                        break;
                    case "StartMultipleBulkRecoveries":
                        this.ProcessRecord_StartMultipleBulkRecoveries();
                        break;
                    case "StartNasAutomigrationJob":
                        this.ProcessRecord_StartNasAutomigrationJob();
                        break;
                    case "StartPeriodicUpgradePrechecksOnDemandJob":
                        this.ProcessRecord_StartPeriodicUpgradePrechecksOnDemandJob();
                        break;
                    case "StartSaasAppAuthConsent":
                        this.ProcessRecord_StartSaasAppAuthConsent();
                        break;
                    case "StartSaasAppsDeleteOrg":
                        this.ProcessRecord_StartSaasAppsDeleteOrg();
                        break;
                    case "StartUpgradeBatchJob":
                        this.ProcessRecord_StartUpgradeBatchJob();
                        break;
                    case "StartVolumeGroupMount":
                        this.ProcessRecord_StartVolumeGroupMount();
                        break;
                    case "StopJobInstance":
                        this.ProcessRecord_StopJobInstance();
                        break;
                    case "StopJobInstanceFromEventSeries":
                        this.ProcessRecord_StopJobInstanceFromEventSeries();
                        break;
                    case "SubmitTprRequest":
                        this.ProcessRecord_SubmitTprRequest();
                        break;
                    case "SupportPortalLogin":
                        this.ProcessRecord_SupportPortalLogin();
                        break;
                    case "SwitchProductToOnboardingMode":
                        this.ProcessRecord_SwitchProductToOnboardingMode();
                        break;
                    case "ToggleFeatureEnabled":
                        this.ProcessRecord_ToggleFeatureEnabled();
                        break;
                    case "TriggerCloudComputeConnectivityCheck":
                        this.ProcessRecord_TriggerCloudComputeConnectivityCheck();
                        break;
                    case "TriggerExocomputeHealthCheck":
                        this.ProcessRecord_TriggerExocomputeHealthCheck();
                        break;
                    case "UninstallIoFilter":
                        this.ProcessRecord_UninstallIoFilter();
                        break;
                    case "UnlockUsersByAdmin":
                        this.ProcessRecord_UnlockUsersByAdmin();
                        break;
                    case "UnmountDisk":
                        this.ProcessRecord_UnmountDisk();
                        break;
                    case "UpdateAccountOwner":
                        this.ProcessRecord_UpdateAccountOwner();
                        break;
                    case "UpdateAccountSettings":
                        this.ProcessRecord_UpdateAccountSettings();
                        break;
                    case "UpdateAdGroup":
                        this.ProcessRecord_UpdateAdGroup();
                        break;
                    case "UpdateAgentDeploymentSetting":
                        this.ProcessRecord_UpdateAgentDeploymentSetting();
                        break;
                    case "UpdateAgentDeploymentSettingInBatch":
                        this.ProcessRecord_UpdateAgentDeploymentSettingInBatch();
                        break;
                    case "UpdateAuthDomainUsersHiddenStatus":
                        this.ProcessRecord_UpdateAuthDomainUsersHiddenStatus();
                        break;
                    case "UpdateBackupThrottleSetting":
                        this.ProcessRecord_UpdateBackupThrottleSetting();
                        break;
                    case "UpdateBadDiskLedStatus":
                        this.ProcessRecord_UpdateBadDiskLedStatus();
                        break;
                    case "UpdateBlueprint":
                        this.ProcessRecord_UpdateBlueprint();
                        break;
                    case "UpdateChat":
                        this.ProcessRecord_UpdateChat();
                        break;
                    case "UpdateChatbot":
                        this.ProcessRecord_UpdateChatbot();
                        break;
                    case "UpdateClassificationBannerEnabled":
                        this.ProcessRecord_UpdateClassificationBannerEnabled();
                        break;
                    case "UpdateClassificationBannerSettings":
                        this.ProcessRecord_UpdateClassificationBannerSettings();
                        break;
                    case "UpdateClassificationLoginEnabled":
                        this.ProcessRecord_UpdateClassificationLoginEnabled();
                        break;
                    case "UpdateClassificationLoginSettings":
                        this.ProcessRecord_UpdateClassificationLoginSettings();
                        break;
                    case "UpdateConfigProtectionSetup":
                        this.ProcessRecord_UpdateConfigProtectionSetup();
                        break;
                    case "UpdateConfiguredGroup":
                        this.ProcessRecord_UpdateConfiguredGroup();
                        break;
                    case "UpdateCustomAnalyzer":
                        this.ProcessRecord_UpdateCustomAnalyzer();
                        break;
                    case "UpdateCustomIntelFeed":
                        this.ProcessRecord_UpdateCustomIntelFeed();
                        break;
                    case "UpdateCustomerAppPermissions":
                        this.ProcessRecord_UpdateCustomerAppPermissions();
                        break;
                    case "UpdateCyberEventLockdown":
                        this.ProcessRecord_UpdateCyberEventLockdown();
                        break;
                    case "UpdateDistributionListDigest":
                        this.ProcessRecord_UpdateDistributionListDigest();
                        break;
                    case "UpdateDnsServersAndSearchDomains":
                        this.ProcessRecord_UpdateDnsServersAndSearchDomains();
                        break;
                    case "UpdateEulaAccepted":
                        this.ProcessRecord_UpdateEulaAccepted();
                        break;
                    case "UpdateEventDigest":
                        this.ProcessRecord_UpdateEventDigest();
                        break;
                    case "UpdateFloatingIps":
                        this.ProcessRecord_UpdateFloatingIps();
                        break;
                    case "UpdateGuestCredential":
                        this.ProcessRecord_UpdateGuestCredential();
                        break;
                    case "UpdateIdentityProvider":
                        this.ProcessRecord_UpdateIdentityProvider();
                        break;
                    case "UpdateInsightState":
                        this.ProcessRecord_UpdateInsightState();
                        break;
                    case "UpdateIocStatus":
                        this.ProcessRecord_UpdateIocStatus();
                        break;
                    case "UpdateIpWhitelist":
                        this.ProcessRecord_UpdateIpWhitelist();
                        break;
                    case "UpdateKmipServer":
                        this.ProcessRecord_UpdateKmipServer();
                        break;
                    case "UpdateLambdaSettings":
                        this.ProcessRecord_UpdateLambdaSettings();
                        break;
                    case "UpdateLlmEnabled":
                        this.ProcessRecord_UpdateLlmEnabled();
                        break;
                    case "UpdateLockoutConfig":
                        this.ProcessRecord_UpdateLockoutConfig();
                        break;
                    case "UpdateManagedIdentities":
                        this.ProcessRecord_UpdateManagedIdentities();
                        break;
                    case "UpdateNetworkThrottle":
                        this.ProcessRecord_UpdateNetworkThrottle();
                        break;
                    case "UpdateOrgNetwork":
                        this.ProcessRecord_UpdateOrgNetwork();
                        break;
                    case "UpdatePactsafeEulaAccepted":
                        this.ProcessRecord_UpdatePactsafeEulaAccepted();
                        break;
                    case "UpdatePactsafeEulaSeen":
                        this.ProcessRecord_UpdatePactsafeEulaSeen();
                        break;
                    case "UpdateProxyConfig":
                        this.ProcessRecord_UpdateProxyConfig();
                        break;
                    case "UpdateReaderLocationMasterKeyWithOwnerLocationKey":
                        this.ProcessRecord_UpdateReaderLocationMasterKeyWithOwnerLocationKey();
                        break;
                    case "UpdateReaderLocationMasterKeyWithRsaKey":
                        this.ProcessRecord_UpdateReaderLocationMasterKeyWithRsaKey();
                        break;
                    case "UpdateRecoveryPlan":
                        this.ProcessRecord_UpdateRecoveryPlan();
                        break;
                    case "UpdateRecoverySchedule":
                        this.ProcessRecord_UpdateRecoverySchedule();
                        break;
                    case "UpdateRoleAssignments":
                        this.ProcessRecord_UpdateRoleAssignments();
                        break;
                    case "UpdateSnapMirrorCloud":
                        this.ProcessRecord_UpdateSnapMirrorCloud();
                        break;
                    case "UpdateSupportCase":
                        this.ProcessRecord_UpdateSupportCase();
                        break;
                    case "UpdateSupportUserAccess":
                        this.ProcessRecord_UpdateSupportUserAccess();
                        break;
                    case "UpdateTprConfiguration":
                        this.ProcessRecord_UpdateTprConfiguration();
                        break;
                    case "UpdateTunnelStatus":
                        this.ProcessRecord_UpdateTunnelStatus();
                        break;
                    case "UpdateVcdInstances":
                        this.ProcessRecord_UpdateVcdInstances();
                        break;
                    case "UpdateVcdVapp":
                        this.ProcessRecord_UpdateVcdVapp();
                        break;
                    case "UpdateVlan":
                        this.ProcessRecord_UpdateVlan();
                        break;
                    case "UpdateVolumeGroup":
                        this.ProcessRecord_UpdateVolumeGroup();
                        break;
                    case "UpdateWhitelistedAnalyzers":
                        this.ProcessRecord_UpdateWhitelistedAnalyzers();
                        break;
                    case "UpgradeIoFilter":
                        this.ProcessRecord_UpgradeIoFilter();
                        break;
                    case "UpgradeToRsc":
                        this.ProcessRecord_UpgradeToRsc();
                        break;
                    case "ValidateAndSaveCustomerKmsInfo":
                        this.ProcessRecord_ValidateAndSaveCustomerKmsInfo();
                        break;
                    case "ValidateBlueprint":
                        this.ProcessRecord_ValidateBlueprint();
                        break;
                    case "ValidateBlueprintRecoverySpec":
                        this.ProcessRecord_ValidateBlueprintRecoverySpec();
                        break;
                    case "ValidateBlueprints":
                        this.ProcessRecord_ValidateBlueprints();
                        break;
                    case "ValidateCompleteOperationalRecoveryFeasibility":
                        this.ProcessRecord_ValidateCompleteOperationalRecoveryFeasibility();
                        break;
                    case "ValidateTicketingPlatformConfig":
                        this.ProcessRecord_ValidateTicketingPlatformConfig();
                        break;
                    case "VmMakePrimary":
                        this.ProcessRecord_VmMakePrimary();
                        break;
                    case "VpshereVMRecoveryPointMount":
                        this.ProcessRecord_VpshereVMRecoveryPointMount();
                        break;
                    case "WarmSearchCache":
                        this.ProcessRecord_WarmSearchCache();
                        break;
                    default:
                        throw new Exception("Unknown Operation " + this.GetOp().OpName());
                }
           }
           catch (Exception ex)
           {
                ThrowTerminatingException(ex);
           }
        }

        // This parameter set invokes a single graphql operation:
        // acknowledgeFedrampBoundaryExit.
        internal void ProcessRecord_AcknowledgeFedrampBoundaryExit()
        {
            this._logger.name += " -AcknowledgeFedrampBoundaryExit";
            // Create new graphql operation acknowledgeFedrampBoundaryExit
            InitMutationAcknowledgeFedrampBoundaryExit();
        }

        // This parameter set invokes a single graphql operation:
        // activateTrialAsync.
        internal void ProcessRecord_ActivateTrialAsync()
        {
            this._logger.name += " -ActivateTrialAsync";
            // Create new graphql operation activateTrialAsync
            InitMutationActivateTrialAsync();
        }

        // This parameter set invokes a single graphql operation:
        // addAdGroupsToHierarchy.
        internal void ProcessRecord_AddAdGroupsToHierarchy()
        {
            this._logger.name += " -AddAdGroupsToHierarchy";
            // Create new graphql operation addAdGroupsToHierarchy
            InitMutationAddAdGroupsToHierarchy();
        }

        // This parameter set invokes a single graphql operation:
        // addConfiguredGroupToHierarchy.
        internal void ProcessRecord_AddConfiguredGroupToHierarchy()
        {
            this._logger.name += " -AddConfiguredGroupToHierarchy";
            // Create new graphql operation addConfiguredGroupToHierarchy
            InitMutationAddConfiguredGroupToHierarchy();
        }

        // This parameter set invokes a single graphql operation:
        // addCustomIntelFeed.
        internal void ProcessRecord_AddCustomIntelFeed()
        {
            this._logger.name += " -AddCustomIntelFeed";
            // Create new graphql operation addCustomIntelFeed
            InitMutationAddCustomIntelFeed();
        }

        // This parameter set invokes a single graphql operation:
        // addInventoryWorkloads.
        internal void ProcessRecord_AddInventoryWorkloads()
        {
            this._logger.name += " -AddInventoryWorkloads";
            // Create new graphql operation addInventoryWorkloads
            InitMutationAddInventoryWorkloads();
        }

        // This parameter set invokes a single graphql operation:
        // addRoleAssignments.
        internal void ProcessRecord_AddRoleAssignments()
        {
            this._logger.name += " -AddRoleAssignments";
            // Create new graphql operation addRoleAssignments
            InitMutationAddRoleAssignments();
        }

        // This parameter set invokes a single graphql operation:
        // addSaasAppRecoveryOrg.
        internal void ProcessRecord_AddSaasAppRecoveryOrg()
        {
            this._logger.name += " -AddSaasAppRecoveryOrg";
            // Create new graphql operation addSaasAppRecoveryOrg
            InitMutationAddSaasAppRecoveryOrg();
        }

        // This parameter set invokes a single graphql operation:
        // addVcdInstances.
        internal void ProcessRecord_AddVcdInstances()
        {
            this._logger.name += " -AddVcdInstances";
            // Create new graphql operation addVcdInstances
            InitMutationAddVcdInstances();
        }

        // This parameter set invokes a single graphql operation:
        // addVlan.
        internal void ProcessRecord_AddVlan()
        {
            this._logger.name += " -AddVlan";
            // Create new graphql operation addVlan
            InitMutationAddVlan();
        }

        // This parameter set invokes a single graphql operation:
        // addVmAppConsistentSpecs.
        internal void ProcessRecord_AddVmAppConsistentSpecs()
        {
            this._logger.name += " -AddVmAppConsistentSpecs";
            // Create new graphql operation addVmAppConsistentSpecs
            InitMutationAddVmAppConsistentSpecs();
        }

        // This parameter set invokes a single graphql operation:
        // airGapStatus.
        internal void ProcessRecord_AirGapStatus()
        {
            this._logger.name += " -AirGapStatus";
            // Create new graphql operation airGapStatus
            InitMutationAirGapStatus();
        }

        // This parameter set invokes a single graphql operation:
        // approveTprRequest.
        internal void ProcessRecord_ApproveTprRequest()
        {
            this._logger.name += " -ApproveTprRequest";
            // Create new graphql operation approveTprRequest
            InitMutationApproveTprRequest();
        }

        // This parameter set invokes a single graphql operation:
        // archiveCrawl.
        internal void ProcessRecord_ArchiveCrawl()
        {
            this._logger.name += " -ArchiveCrawl";
            // Create new graphql operation archiveCrawl
            InitMutationArchiveCrawl();
        }

        // This parameter set invokes a single graphql operation:
        // assignProtection.
        internal void ProcessRecord_AssignProtection()
        {
            this._logger.name += " -AssignProtection";
            // Create new graphql operation assignProtection
            InitMutationAssignProtection();
        }

        // This parameter set invokes a single graphql operation:
        // batchDeassignRoleFromUserGroups.
        internal void ProcessRecord_BatchDeassignRoleFromUserGroups()
        {
            this._logger.name += " -BatchDeassignRoleFromUserGroups";
            // Create new graphql operation batchDeassignRoleFromUserGroups
            InitMutationBatchDeassignRoleFromUserGroups();
        }

        // This parameter set invokes a single graphql operation:
        // batchRefreshDomains.
        internal void ProcessRecord_BatchRefreshDomains()
        {
            this._logger.name += " -BatchRefreshDomains";
            // Create new graphql operation batchRefreshDomains
            InitMutationBatchRefreshDomains();
        }

        // This parameter set invokes a single graphql operation:
        // bulkAddKmipServer.
        internal void ProcessRecord_BulkAddKmipServer()
        {
            this._logger.name += " -BulkAddKmipServer";
            // Create new graphql operation bulkAddKmipServer
            InitMutationBulkAddKmipServer();
        }

        // This parameter set invokes a single graphql operation:
        // bulkCancelFailovers.
        internal void ProcessRecord_BulkCancelFailovers()
        {
            this._logger.name += " -BulkCancelFailovers";
            // Create new graphql operation bulkCancelFailovers
            InitMutationBulkCancelFailovers();
        }

        // This parameter set invokes a single graphql operation:
        // bulkCreateNasFilesets.
        internal void ProcessRecord_BulkCreateNasFilesets()
        {
            this._logger.name += " -BulkCreateNasFilesets";
            // Create new graphql operation bulkCreateNasFilesets
            InitMutationBulkCreateNasFilesets();
        }

        // This parameter set invokes a single graphql operation:
        // bulkUpdateSnapMirrorCloud.
        internal void ProcessRecord_BulkUpdateSnapMirrorCloud()
        {
            this._logger.name += " -BulkUpdateSnapMirrorCloud";
            // Create new graphql operation bulkUpdateSnapMirrorCloud
            InitMutationBulkUpdateSnapMirrorCloud();
        }

        // This parameter set invokes a single graphql operation:
        // cancelBlueprintFailover.
        internal void ProcessRecord_CancelBlueprintFailover()
        {
            this._logger.name += " -CancelBlueprintFailover";
            // Create new graphql operation cancelBlueprintFailover
            InitMutationCancelBlueprintFailover();
        }

        // This parameter set invokes a single graphql operation:
        // cancelBulkRecovery.
        internal void ProcessRecord_CancelBulkRecovery()
        {
            this._logger.name += " -CancelBulkRecovery";
            // Create new graphql operation cancelBulkRecovery
            InitMutationCancelBulkRecovery();
        }

        // This parameter set invokes a single graphql operation:
        // cancelDownloadPackage.
        internal void ProcessRecord_CancelDownloadPackage()
        {
            this._logger.name += " -CancelDownloadPackage";
            // Create new graphql operation cancelDownloadPackage
            InitMutationCancelDownloadPackage();
        }

        // This parameter set invokes a single graphql operation:
        // cancelJobInstance.
        internal void ProcessRecord_CancelJobInstance()
        {
            this._logger.name += " -CancelJobInstance";
            // Create new graphql operation cancelJobInstance
            InitMutationCancelJobInstance();
        }

        // This parameter set invokes a single graphql operation:
        // cancelScheduledUpgrade.
        internal void ProcessRecord_CancelScheduledUpgrade()
        {
            this._logger.name += " -CancelScheduledUpgrade";
            // Create new graphql operation cancelScheduledUpgrade
            InitMutationCancelScheduledUpgrade();
        }

        // This parameter set invokes a single graphql operation:
        // cancelTaskchain.
        internal void ProcessRecord_CancelTaskchain()
        {
            this._logger.name += " -CancelTaskchain";
            // Create new graphql operation cancelTaskchain
            InitMutationCancelTaskchain();
        }

        // This parameter set invokes a single graphql operation:
        // cancelTprRequest.
        internal void ProcessRecord_CancelTprRequest()
        {
            this._logger.name += " -CancelTprRequest";
            // Create new graphql operation cancelTprRequest
            InitMutationCancelTprRequest();
        }

        // This parameter set invokes a single graphql operation:
        // changePassword.
        internal void ProcessRecord_ChangePassword()
        {
            this._logger.name += " -ChangePassword";
            // Create new graphql operation changePassword
            InitMutationChangePassword();
        }

        // This parameter set invokes a single graphql operation:
        // checkStatus.
        internal void ProcessRecord_CheckStatus()
        {
            this._logger.name += " -CheckStatus";
            // Create new graphql operation checkStatus
            InitMutationCheckStatus();
        }

        // This parameter set invokes a single graphql operation:
        // cleanupBlueprintFailover.
        internal void ProcessRecord_CleanupBlueprintFailover()
        {
            this._logger.name += " -CleanupBlueprintFailover";
            // Create new graphql operation cleanupBlueprintFailover
            InitMutationCleanupBlueprintFailover();
        }

        // This parameter set invokes a single graphql operation:
        // cleanupIsolatedRecoveries.
        internal void ProcessRecord_CleanupIsolatedRecoveries()
        {
            this._logger.name += " -CleanupIsolatedRecoveries";
            // Create new graphql operation cleanupIsolatedRecoveries
            InitMutationCleanupIsolatedRecoveries();
        }

        // This parameter set invokes a single graphql operation:
        // cleanupIsolatedRecovery.
        internal void ProcessRecord_CleanupIsolatedRecovery()
        {
            this._logger.name += " -CleanupIsolatedRecovery";
            // Create new graphql operation cleanupIsolatedRecovery
            InitMutationCleanupIsolatedRecovery();
        }

        // This parameter set invokes a single graphql operation:
        // completeOperationalRecovery.
        internal void ProcessRecord_CompleteOperationalRecovery()
        {
            this._logger.name += " -CompleteOperationalRecovery";
            // Create new graphql operation completeOperationalRecovery
            InitMutationCompleteOperationalRecovery();
        }

        // This parameter set invokes a single graphql operation:
        // completeSaasAppAuthConsent.
        internal void ProcessRecord_CompleteSaasAppAuthConsent()
        {
            this._logger.name += " -CompleteSaasAppAuthConsent";
            // Create new graphql operation completeSaasAppAuthConsent
            InitMutationCompleteSaasAppAuthConsent();
        }

        // This parameter set invokes a single graphql operation:
        // completeTrialOnboarding.
        internal void ProcessRecord_CompleteTrialOnboarding()
        {
            this._logger.name += " -CompleteTrialOnboarding";
            // Create new graphql operation completeTrialOnboarding
            InitMutationCompleteTrialOnboarding();
        }

        // This parameter set invokes a single graphql operation:
        // completeTrialTask.
        internal void ProcessRecord_CompleteTrialTask()
        {
            this._logger.name += " -CompleteTrialTask";
            // Create new graphql operation completeTrialTask
            InitMutationCompleteTrialTask();
        }

        // This parameter set invokes a single graphql operation:
        // computeBucketImmutabilityLockDuration.
        internal void ProcessRecord_ComputeBucketImmutabilityLockDuration()
        {
            this._logger.name += " -ComputeBucketImmutabilityLockDuration";
            // Create new graphql operation computeBucketImmutabilityLockDuration
            InitMutationComputeBucketImmutabilityLockDuration();
        }

        // This parameter set invokes a single graphql operation:
        // configureDns.
        internal void ProcessRecord_ConfigureDns()
        {
            this._logger.name += " -ConfigureDns";
            // Create new graphql operation configureDns
            InitMutationConfigureDns();
        }

        // This parameter set invokes a single graphql operation:
        // configureLogExport.
        internal void ProcessRecord_ConfigureLogExport()
        {
            this._logger.name += " -ConfigureLogExport";
            // Create new graphql operation configureLogExport
            InitMutationConfigureLogExport();
        }

        // This parameter set invokes a single graphql operation:
        // configureNtp.
        internal void ProcessRecord_ConfigureNtp()
        {
            this._logger.name += " -ConfigureNtp";
            // Create new graphql operation configureNtp
            InitMutationConfigureNtp();
        }

        // This parameter set invokes a single graphql operation:
        // configureTicketingPlatformWithOAuth.
        internal void ProcessRecord_ConfigureTicketingPlatformWithOAuth()
        {
            this._logger.name += " -ConfigureTicketingPlatformWithOAuth";
            // Create new graphql operation configureTicketingPlatformWithOAuth
            InitMutationConfigureTicketingPlatformWithOauth();
        }

        // This parameter set invokes a single graphql operation:
        // createBlueprint.
        internal void ProcessRecord_CreateBlueprint()
        {
            this._logger.name += " -CreateBlueprint";
            // Create new graphql operation createBlueprint
            InitMutationCreateBlueprint();
        }

        // This parameter set invokes a single graphql operation:
        // createBlueprintRecoverySpec.
        internal void ProcessRecord_CreateBlueprintRecoverySpec()
        {
            this._logger.name += " -CreateBlueprintRecoverySpec";
            // Create new graphql operation createBlueprintRecoverySpec
            InitMutationCreateBlueprintRecoverySpec();
        }

        // This parameter set invokes a single graphql operation:
        // createChat.
        internal void ProcessRecord_CreateChat()
        {
            this._logger.name += " -CreateChat";
            // Create new graphql operation createChat
            InitMutationCreateChat();
        }

        // This parameter set invokes a single graphql operation:
        // createChatbot.
        internal void ProcessRecord_CreateChatbot()
        {
            this._logger.name += " -CreateChatbot";
            // Create new graphql operation createChatbot
            InitMutationCreateChatbot();
        }

        // This parameter set invokes a single graphql operation:
        // createConfigProtectionBackup.
        internal void ProcessRecord_CreateConfigProtectionBackup()
        {
            this._logger.name += " -CreateConfigProtectionBackup";
            // Create new graphql operation createConfigProtectionBackup
            InitMutationCreateConfigProtectionBackup();
        }

        // This parameter set invokes a single graphql operation:
        // createConfigProtectionSetup.
        internal void ProcessRecord_CreateConfigProtectionSetup()
        {
            this._logger.name += " -CreateConfigProtectionSetup";
            // Create new graphql operation createConfigProtectionSetup
            InitMutationCreateConfigProtectionSetup();
        }

        // This parameter set invokes a single graphql operation:
        // createCustomAnalyzer.
        internal void ProcessRecord_CreateCustomAnalyzer()
        {
            this._logger.name += " -CreateCustomAnalyzer";
            // Create new graphql operation createCustomAnalyzer
            InitMutationCreateCustomAnalyzer();
        }

        // This parameter set invokes a single graphql operation:
        // createEventDigestBatch.
        internal void ProcessRecord_CreateEventDigestBatch()
        {
            this._logger.name += " -CreateEventDigestBatch";
            // Create new graphql operation createEventDigestBatch
            InitMutationCreateEventDigestBatch();
        }

        // This parameter set invokes a single graphql operation:
        // createGuestCredential.
        internal void ProcessRecord_CreateGuestCredential()
        {
            this._logger.name += " -CreateGuestCredential";
            // Create new graphql operation createGuestCredential
            InitMutationCreateGuestCredential();
        }

        // This parameter set invokes a single graphql operation:
        // createLegalHold.
        internal void ProcessRecord_CreateLegalHold()
        {
            this._logger.name += " -CreateLegalHold";
            // Create new graphql operation createLegalHold
            InitMutationCreateLegalHold();
        }

        // This parameter set invokes a single graphql operation:
        // createOnDemandVolumeGroupBackup.
        internal void ProcessRecord_CreateOnDemandVolumeGroupBackup()
        {
            this._logger.name += " -CreateOnDemandVolumeGroupBackup";
            // Create new graphql operation createOnDemandVolumeGroupBackup
            InitMutationCreateOnDemandVolumeGroupBackup();
        }

        // This parameter set invokes a single graphql operation:
        // createOrgNetwork.
        internal void ProcessRecord_CreateOrgNetwork()
        {
            this._logger.name += " -CreateOrgNetwork";
            // Create new graphql operation createOrgNetwork
            InitMutationCreateOrgNetwork();
        }

        // This parameter set invokes a single graphql operation:
        // createPasskey.
        internal void ProcessRecord_CreatePasskey()
        {
            this._logger.name += " -CreatePasskey";
            // Create new graphql operation createPasskey
            InitMutationCreatePasskey();
        }

        // This parameter set invokes a single graphql operation:
        // createRbacMigrationSummaryDownload.
        internal void ProcessRecord_CreateRbacMigrationSummaryDownload()
        {
            this._logger.name += " -CreateRbacMigrationSummaryDownload";
            // Create new graphql operation createRbacMigrationSummaryDownload
            InitMutationCreateRbacMigrationSummaryDownload();
        }

        // This parameter set invokes a single graphql operation:
        // createRecoveryPlan.
        internal void ProcessRecord_CreateRecoveryPlan()
        {
            this._logger.name += " -CreateRecoveryPlan";
            // Create new graphql operation createRecoveryPlan
            InitMutationCreateRecoveryPlan();
        }

        // This parameter set invokes a single graphql operation:
        // createRecoverySchedule.
        internal void ProcessRecord_CreateRecoverySchedule()
        {
            this._logger.name += " -CreateRecoverySchedule";
            // Create new graphql operation createRecoverySchedule
            InitMutationCreateRecoverySchedule();
        }

        // This parameter set invokes a single graphql operation:
        // createS3Bucket.
        internal void ProcessRecord_CreateS3Bucket()
        {
            this._logger.name += " -CreateS3Bucket";
            // Create new graphql operation createS3Bucket
            InitMutationCreateS3Bucket();
        }

        // This parameter set invokes a single graphql operation:
        // createSnapMirrorCloud.
        internal void ProcessRecord_CreateSnapMirrorCloud()
        {
            this._logger.name += " -CreateSnapMirrorCloud";
            // Create new graphql operation createSnapMirrorCloud
            InitMutationCreateSnapMirrorCloud();
        }

        // This parameter set invokes a single graphql operation:
        // createSnapMirrorCloudRelationship.
        internal void ProcessRecord_CreateSnapMirrorCloudRelationship()
        {
            this._logger.name += " -CreateSnapMirrorCloudRelationship";
            // Create new graphql operation createSnapMirrorCloudRelationship
            InitMutationCreateSnapMirrorCloudRelationship();
        }

        // This parameter set invokes a single graphql operation:
        // createSnapMirrorCloudRestoreJob.
        internal void ProcessRecord_CreateSnapMirrorCloudRestoreJob()
        {
            this._logger.name += " -CreateSnapMirrorCloudRestoreJob";
            // Create new graphql operation createSnapMirrorCloudRestoreJob
            InitMutationCreateSnapMirrorCloudRestoreJob();
        }

        // This parameter set invokes a single graphql operation:
        // createSsoUsers.
        internal void ProcessRecord_CreateSsoUsers()
        {
            this._logger.name += " -CreateSsoUsers";
            // Create new graphql operation createSsoUsers
            InitMutationCreateSsoUsers();
        }

        // This parameter set invokes a single graphql operation:
        // createSupportCase.
        internal void ProcessRecord_CreateSupportCase()
        {
            this._logger.name += " -CreateSupportCase";
            // Create new graphql operation createSupportCase
            InitMutationCreateSupportCase();
        }

        // This parameter set invokes a single graphql operation:
        // createUserAccessInsightTicket.
        internal void ProcessRecord_CreateUserAccessInsightTicket()
        {
            this._logger.name += " -CreateUserAccessInsightTicket";
            // Create new graphql operation createUserAccessInsightTicket
            InitMutationCreateUserAccessInsightTicket();
        }

        // This parameter set invokes a single graphql operation:
        // createVappExport.
        internal void ProcessRecord_CreateVappExport()
        {
            this._logger.name += " -CreateVappExport";
            // Create new graphql operation createVappExport
            InitMutationCreateVappExport();
        }

        // This parameter set invokes a single graphql operation:
        // createVappsInstantRecovery.
        internal void ProcessRecord_CreateVappsInstantRecovery()
        {
            this._logger.name += " -CreateVappsInstantRecovery";
            // Create new graphql operation createVappsInstantRecovery
            InitMutationCreateVappsInstantRecovery();
        }

        // This parameter set invokes a single graphql operation:
        // deactivateCustomAnalyzer.
        internal void ProcessRecord_DeactivateCustomAnalyzer()
        {
            this._logger.name += " -DeactivateCustomAnalyzer";
            // Create new graphql operation deactivateCustomAnalyzer
            InitMutationDeactivateCustomAnalyzer();
        }

        // This parameter set invokes a single graphql operation:
        // deleteAccountSettingValue.
        internal void ProcessRecord_DeleteAccountSettingValue()
        {
            this._logger.name += " -DeleteAccountSettingValue";
            // Create new graphql operation deleteAccountSettingValue
            InitMutationDeleteAccountSettingValue();
        }

        // This parameter set invokes a single graphql operation:
        // deleteAdGroupsFromHierarchy.
        internal void ProcessRecord_DeleteAdGroupsFromHierarchy()
        {
            this._logger.name += " -DeleteAdGroupsFromHierarchy";
            // Create new graphql operation deleteAdGroupsFromHierarchy
            InitMutationDeleteAdGroupsFromHierarchy();
        }

        // This parameter set invokes a single graphql operation:
        // deleteBlueprint.
        internal void ProcessRecord_DeleteBlueprint()
        {
            this._logger.name += " -DeleteBlueprint";
            // Create new graphql operation deleteBlueprint
            InitMutationDeleteBlueprint();
        }

        // This parameter set invokes a single graphql operation:
        // deleteBlueprints.
        internal void ProcessRecord_DeleteBlueprints()
        {
            this._logger.name += " -DeleteBlueprints";
            // Create new graphql operation deleteBlueprints
            InitMutationDeleteBlueprints();
        }

        // This parameter set invokes a single graphql operation:
        // deleteBrandLogo.
        internal void ProcessRecord_DeleteBrandLogo()
        {
            this._logger.name += " -DeleteBrandLogo";
            // Create new graphql operation deleteBrandLogo
            InitMutationDeleteBrandLogo();
        }

        // This parameter set invokes a single graphql operation:
        // deleteChatbot.
        internal void ProcessRecord_DeleteChatbot()
        {
            this._logger.name += " -DeleteChatbot";
            // Create new graphql operation deleteChatbot
            InitMutationDeleteChatbot();
        }

        // This parameter set invokes a single graphql operation:
        // deleteDistributionListDigestBatch.
        internal void ProcessRecord_DeleteDistributionListDigestBatch()
        {
            this._logger.name += " -DeleteDistributionListDigestBatch";
            // Create new graphql operation deleteDistributionListDigestBatch
            InitMutationDeleteDistributionListDigestBatch();
        }

        // This parameter set invokes a single graphql operation:
        // deleteEnvoyNgs.
        internal void ProcessRecord_DeleteEnvoyNgs()
        {
            this._logger.name += " -DeleteEnvoyNgs";
            // Create new graphql operation deleteEnvoyNgs
            InitMutationDeleteEnvoyNgs();
        }

        // This parameter set invokes a single graphql operation:
        // deleteEventDigest.
        internal void ProcessRecord_DeleteEventDigest()
        {
            this._logger.name += " -DeleteEventDigest";
            // Create new graphql operation deleteEventDigest
            InitMutationDeleteEventDigest();
        }

        // This parameter set invokes a single graphql operation:
        // deleteGuestCredentialById.
        internal void ProcessRecord_DeleteGuestCredentialById()
        {
            this._logger.name += " -DeleteGuestCredentialById";
            // Create new graphql operation deleteGuestCredentialById
            InitMutationDeleteGuestCredentialById();
        }

        // This parameter set invokes a single graphql operation:
        // deleteIdentityProvider.
        internal void ProcessRecord_DeleteIdentityProvider()
        {
            this._logger.name += " -DeleteIdentityProvider";
            // Create new graphql operation deleteIdentityProvider
            InitMutationDeleteIdentityProvider();
        }

        // This parameter set invokes a single graphql operation:
        // deleteIntelFeed.
        internal void ProcessRecord_DeleteIntelFeed()
        {
            this._logger.name += " -DeleteIntelFeed";
            // Create new graphql operation deleteIntelFeed
            InitMutationDeleteIntelFeed();
        }

        // This parameter set invokes a single graphql operation:
        // deleteKmipServer.
        internal void ProcessRecord_DeleteKmipServer()
        {
            this._logger.name += " -DeleteKmipServer";
            // Create new graphql operation deleteKmipServer
            InitMutationDeleteKmipServer();
        }

        // This parameter set invokes a single graphql operation:
        // deleteKmsInstance.
        internal void ProcessRecord_DeleteKmsInstance()
        {
            this._logger.name += " -DeleteKmsInstance";
            // Create new graphql operation deleteKmsInstance
            InitMutationDeleteKmsInstance();
        }

        // This parameter set invokes a single graphql operation:
        // deleteOrgNetwork.
        internal void ProcessRecord_DeleteOrgNetwork()
        {
            this._logger.name += " -DeleteOrgNetwork";
            // Create new graphql operation deleteOrgNetwork
            InitMutationDeleteOrgNetwork();
        }

        // This parameter set invokes a single graphql operation:
        // deletePasskey.
        internal void ProcessRecord_DeletePasskey()
        {
            this._logger.name += " -DeletePasskey";
            // Create new graphql operation deletePasskey
            InitMutationDeletePasskey();
        }

        // This parameter set invokes a single graphql operation:
        // deleteRecoveryPlan.
        internal void ProcessRecord_DeleteRecoveryPlan()
        {
            this._logger.name += " -DeleteRecoveryPlan";
            // Create new graphql operation deleteRecoveryPlan
            InitMutationDeleteRecoveryPlan();
        }

        // This parameter set invokes a single graphql operation:
        // deleteRecoveryPlans.
        internal void ProcessRecord_DeleteRecoveryPlans()
        {
            this._logger.name += " -DeleteRecoveryPlans";
            // Create new graphql operation deleteRecoveryPlans
            InitMutationDeleteRecoveryPlans();
        }

        // This parameter set invokes a single graphql operation:
        // deleteRecoverySchedule.
        internal void ProcessRecord_DeleteRecoverySchedule()
        {
            this._logger.name += " -DeleteRecoverySchedule";
            // Create new graphql operation deleteRecoverySchedule
            InitMutationDeleteRecoverySchedule();
        }

        // This parameter set invokes a single graphql operation:
        // deleteRecoverySpec.
        internal void ProcessRecord_DeleteRecoverySpec()
        {
            this._logger.name += " -DeleteRecoverySpec";
            // Create new graphql operation deleteRecoverySpec
            InitMutationDeleteRecoverySpec();
        }

        // This parameter set invokes a single graphql operation:
        // deleteSmtpConfiguration.
        internal void ProcessRecord_DeleteSmtpConfiguration()
        {
            this._logger.name += " -DeleteSmtpConfiguration";
            // Create new graphql operation deleteSmtpConfiguration
            InitMutationDeleteSmtpConfiguration();
        }

        // This parameter set invokes a single graphql operation:
        // deleteSnapMirrorCloud.
        internal void ProcessRecord_DeleteSnapMirrorCloud()
        {
            this._logger.name += " -DeleteSnapMirrorCloud";
            // Create new graphql operation deleteSnapMirrorCloud
            InitMutationDeleteSnapMirrorCloud();
        }

        // This parameter set invokes a single graphql operation:
        // deleteSnapMirrorCloudRelationship.
        internal void ProcessRecord_DeleteSnapMirrorCloudRelationship()
        {
            this._logger.name += " -DeleteSnapMirrorCloudRelationship";
            // Create new graphql operation deleteSnapMirrorCloudRelationship
            InitMutationDeleteSnapMirrorCloudRelationship();
        }

        // This parameter set invokes a single graphql operation:
        // deleteVcdInstances.
        internal void ProcessRecord_DeleteVcdInstances()
        {
            this._logger.name += " -DeleteVcdInstances";
            // Create new graphql operation deleteVcdInstances
            InitMutationDeleteVcdInstances();
        }

        // This parameter set invokes a single graphql operation:
        // deleteVolumeGroupMount.
        internal void ProcessRecord_DeleteVolumeGroupMount()
        {
            this._logger.name += " -DeleteVolumeGroupMount";
            // Create new graphql operation deleteVolumeGroupMount
            InitMutationDeleteVolumeGroupMount();
        }

        // This parameter set invokes a single graphql operation:
        // denyTprRequests.
        internal void ProcessRecord_DenyTprRequests()
        {
            this._logger.name += " -DenyTprRequests";
            // Create new graphql operation denyTprRequests
            InitMutationDenyTprRequests();
        }

        // This parameter set invokes a single graphql operation:
        // deregisterPrivateContainerRegistry.
        internal void ProcessRecord_DeregisterPrivateContainerRegistry()
        {
            this._logger.name += " -DeregisterPrivateContainerRegistry";
            // Create new graphql operation deregisterPrivateContainerRegistry
            InitMutationDeregisterPrivateContainerRegistry();
        }

        // This parameter set invokes a single graphql operation:
        // disableSupportUserAccess.
        internal void ProcessRecord_DisableSupportUserAccess()
        {
            this._logger.name += " -DisableSupportUserAccess";
            // Create new graphql operation disableSupportUserAccess
            InitMutationDisableSupportUserAccess();
        }

        // This parameter set invokes a single graphql operation:
        // disableTprOrg.
        internal void ProcessRecord_DisableTprOrg()
        {
            this._logger.name += " -DisableTprOrg";
            // Create new graphql operation disableTprOrg
            InitMutationDisableTprOrg();
        }

        // This parameter set invokes a single graphql operation:
        // disconnectTicketingPlatform.
        internal void ProcessRecord_DisconnectTicketingPlatform()
        {
            this._logger.name += " -DisconnectTicketingPlatform";
            // Create new graphql operation disconnectTicketingPlatform
            InitMutationDisconnectTicketingPlatform();
        }

        // This parameter set invokes a single graphql operation:
        // dissolveLegalHold.
        internal void ProcessRecord_DissolveLegalHold()
        {
            this._logger.name += " -DissolveLegalHold";
            // Create new graphql operation dissolveLegalHold
            InitMutationDissolveLegalHold();
        }

        // This parameter set invokes a single graphql operation:
        // editPasskey.
        internal void ProcessRecord_EditPasskey()
        {
            this._logger.name += " -EditPasskey";
            // Create new graphql operation editPasskey
            InitMutationEditPasskey();
        }

        // This parameter set invokes a single graphql operation:
        // editSalesforceOrganization.
        internal void ProcessRecord_EditSalesforceOrganization()
        {
            this._logger.name += " -EditSalesforceOrganization";
            // Create new graphql operation editSalesforceOrganization
            InitMutationEditSalesforceOrganization();
        }

        // This parameter set invokes a single graphql operation:
        // enableAutomaticFmdUpload.
        internal void ProcessRecord_EnableAutomaticFmdUpload()
        {
            this._logger.name += " -EnableAutomaticFmdUpload";
            // Create new graphql operation enableAutomaticFmdUpload
            InitMutationEnableAutomaticFmdUpload();
        }

        // This parameter set invokes a single graphql operation:
        // enableDisableAppConsistency.
        internal void ProcessRecord_EnableDisableAppConsistency()
        {
            this._logger.name += " -EnableDisableAppConsistency";
            // Create new graphql operation enableDisableAppConsistency
            InitMutationEnableDisableAppConsistency();
        }

        // This parameter set invokes a single graphql operation:
        // enableLambdaForWorkload.
        internal void ProcessRecord_EnableLambdaForWorkload()
        {
            this._logger.name += " -EnableLambdaForWorkload";
            // Create new graphql operation enableLambdaForWorkload
            InitMutationEnableLambdaForWorkload();
        }

        // This parameter set invokes a single graphql operation:
        // enableMigrationWorkflow.
        internal void ProcessRecord_EnableMigrationWorkflow()
        {
            this._logger.name += " -EnableMigrationWorkflow";
            // Create new graphql operation enableMigrationWorkflow
            InitMutationEnableMigrationWorkflow();
        }

        // This parameter set invokes a single graphql operation:
        // enableSupportUserAccess.
        internal void ProcessRecord_EnableSupportUserAccess()
        {
            this._logger.name += " -EnableSupportUserAccess";
            // Create new graphql operation enableSupportUserAccess
            InitMutationEnableSupportUserAccess();
        }

        // This parameter set invokes a single graphql operation:
        // enableTprOrg.
        internal void ProcessRecord_EnableTprOrg()
        {
            this._logger.name += " -EnableTprOrg";
            // Create new graphql operation enableTprOrg
            InitMutationEnableTprOrg();
        }

        // This parameter set invokes a single graphql operation:
        // excludeVmDisks.
        internal void ProcessRecord_ExcludeVmDisks()
        {
            this._logger.name += " -ExcludeVmDisks";
            // Create new graphql operation excludeVmDisks
            InitMutationExcludeVmDisks();
        }

        // This parameter set invokes a single graphql operation:
        // executeTprRequests.
        internal void ProcessRecord_ExecuteTprRequests()
        {
            this._logger.name += " -ExecuteTprRequests";
            // Create new graphql operation executeTprRequests
            InitMutationExecuteTprRequests();
        }

        // This parameter set invokes a single graphql operation:
        // expireSnoozedDirectories.
        internal void ProcessRecord_ExpireSnoozedDirectories()
        {
            this._logger.name += " -ExpireSnoozedDirectories";
            // Create new graphql operation expireSnoozedDirectories
            InitMutationExpireSnoozedDirectories();
        }

        // This parameter set invokes a single graphql operation:
        // exportPrincipalsSummary.
        internal void ProcessRecord_ExportPrincipalsSummary()
        {
            this._logger.name += " -ExportPrincipalsSummary";
            // Create new graphql operation exportPrincipalsSummary
            InitMutationExportPrincipalsSummary();
        }

        // This parameter set invokes a single graphql operation:
        // exportUnAccessedUsersSummary.
        internal void ProcessRecord_ExportUnAccessedUsersSummary()
        {
            this._logger.name += " -ExportUnAccessedUsersSummary";
            // Create new graphql operation exportUnAccessedUsersSummary
            InitMutationExportUnAccessedUsersSummary();
        }

        // This parameter set invokes a single graphql operation:
        // extendRscAutoUpgradeDate.
        internal void ProcessRecord_ExtendRscAutoUpgradeDate()
        {
            this._logger.name += " -ExtendRscAutoUpgradeDate";
            // Create new graphql operation extendRscAutoUpgradeDate
            InitMutationExtendRscAutoUpgradeDate();
        }

        // This parameter set invokes a single graphql operation:
        // extendTrialAsync.
        internal void ProcessRecord_ExtendTrialAsync()
        {
            this._logger.name += " -ExtendTrialAsync";
            // Create new graphql operation extendTrialAsync
            InitMutationExtendTrialAsync();
        }

        // This parameter set invokes a single graphql operation:
        // generateConfigProtectionRestoreForm.
        internal void ProcessRecord_GenerateConfigProtectionRestoreForm()
        {
            this._logger.name += " -GenerateConfigProtectionRestoreForm";
            // Create new graphql operation generateConfigProtectionRestoreForm
            InitMutationGenerateConfigProtectionRestoreForm();
        }

        // This parameter set invokes a single graphql operation:
        // generateSupportBundle.
        internal void ProcessRecord_GenerateSupportBundle()
        {
            this._logger.name += " -GenerateSupportBundle";
            // Create new graphql operation generateSupportBundle
            InitMutationGenerateSupportBundle();
        }

        // This parameter set invokes a single graphql operation:
        // getDownloadUrl.
        internal void ProcessRecord_GetDownloadUrl()
        {
            this._logger.name += " -GetDownloadUrl";
            // Create new graphql operation getDownloadUrl
            InitMutationGetDownloadUrl();
        }

        // This parameter set invokes a single graphql operation:
        // hideRevealNasNamespaces.
        internal void ProcessRecord_HideRevealNasNamespaces()
        {
            this._logger.name += " -HideRevealNasNamespaces";
            // Create new graphql operation hideRevealNasNamespaces
            InitMutationHideRevealNasNamespaces();
        }

        // This parameter set invokes a single graphql operation:
        // ignoreTrial.
        internal void ProcessRecord_IgnoreTrial()
        {
            this._logger.name += " -IgnoreTrial";
            // Create new graphql operation ignoreTrial
            InitMutationIgnoreTrial();
        }

        // This parameter set invokes a single graphql operation:
        // installIoFilter.
        internal void ProcessRecord_InstallIoFilter()
        {
            this._logger.name += " -InstallIoFilter";
            // Create new graphql operation installIoFilter
            InitMutationInstallIoFilter();
        }

        // This parameter set invokes a single graphql operation:
        // inviteSsoGroup.
        internal void ProcessRecord_InviteSsoGroup()
        {
            this._logger.name += " -InviteSsoGroup";
            // Create new graphql operation inviteSsoGroup
            InitMutationInviteSsoGroup();
        }

        // This parameter set invokes a single graphql operation:
        // inviteUsersToTrial.
        internal void ProcessRecord_InviteUsersToTrial()
        {
            this._logger.name += " -InviteUsersToTrial";
            // Create new graphql operation inviteUsersToTrial
            InitMutationInviteUsersToTrial();
        }

        // This parameter set invokes a single graphql operation:
        // listCidrsForComputeSetting.
        internal void ProcessRecord_ListCidrsForComputeSetting()
        {
            this._logger.name += " -ListCidrsForComputeSetting";
            // Create new graphql operation listCidrsForComputeSetting
            InitMutationListCidrsForComputeSetting();
        }

        // This parameter set invokes a single graphql operation:
        // lockIsolatedRecovery.
        internal void ProcessRecord_LockIsolatedRecovery()
        {
            this._logger.name += " -LockIsolatedRecovery";
            // Create new graphql operation lockIsolatedRecovery
            InitMutationLockIsolatedRecovery();
        }

        // This parameter set invokes a single graphql operation:
        // lockUsersByAdmin.
        internal void ProcessRecord_LockUsersByAdmin()
        {
            this._logger.name += " -LockUsersByAdmin";
            // Create new graphql operation lockUsersByAdmin
            InitMutationLockUsersByAdmin();
        }

        // This parameter set invokes a single graphql operation:
        // logoutFromRubrikSupportPortal.
        internal void ProcessRecord_LogoutFromRubrikSupportPortal()
        {
            this._logger.name += " -LogoutFromRubrikSupportPortal";
            // Create new graphql operation logoutFromRubrikSupportPortal
            InitMutationLogoutFromRubrikSupportPortal();
        }

        // This parameter set invokes a single graphql operation:
        // makePrimary.
        internal void ProcessRecord_MakePrimary()
        {
            this._logger.name += " -MakePrimary";
            // Create new graphql operation makePrimary
            InitMutationMakePrimary();
        }

        // This parameter set invokes a single graphql operation:
        // markNotificationsAsRead.
        internal void ProcessRecord_MarkNotificationsAsRead()
        {
            this._logger.name += " -MarkNotificationsAsRead";
            // Create new graphql operation markNotificationsAsRead
            InitMutationMarkNotificationsAsRead();
        }

        // This parameter set invokes a single graphql operation:
        // modifyEventDigestBatch.
        internal void ProcessRecord_ModifyEventDigestBatch()
        {
            this._logger.name += " -ModifyEventDigestBatch";
            // Create new graphql operation modifyEventDigestBatch
            InitMutationModifyEventDigestBatch();
        }

        // This parameter set invokes a single graphql operation:
        // modifyIpmi.
        internal void ProcessRecord_ModifyIpmi()
        {
            this._logger.name += " -ModifyIpmi";
            // Create new graphql operation modifyIpmi
            InitMutationModifyIpmi();
        }

        // This parameter set invokes a single graphql operation:
        // mountDisk.
        internal void ProcessRecord_MountDisk()
        {
            this._logger.name += " -MountDisk";
            // Create new graphql operation mountDisk
            InitMutationMountDisk();
        }

        // This parameter set invokes a single graphql operation:
        // notificationForGetLicense.
        internal void ProcessRecord_NotificationForGetLicense()
        {
            this._logger.name += " -NotificationForGetLicense";
            // Create new graphql operation notificationForGetLicense
            InitMutationNotificationForGetLicense();
        }

        // This parameter set invokes a single graphql operation:
        // promoteRecovery.
        internal void ProcessRecord_PromoteRecovery()
        {
            this._logger.name += " -PromoteRecovery";
            // Create new graphql operation promoteRecovery
            InitMutationPromoteRecovery();
        }

        // This parameter set invokes a single graphql operation:
        // recoverCloudDirectMultiPaths.
        internal void ProcessRecord_RecoverCloudDirectMultiPaths()
        {
            this._logger.name += " -RecoverCloudDirectMultiPaths";
            // Create new graphql operation recoverCloudDirectMultiPaths
            InitMutationRecoverCloudDirectMultiPaths();
        }

        // This parameter set invokes a single graphql operation:
        // recoverCloudDirectPath.
        internal void ProcessRecord_RecoverCloudDirectPath()
        {
            this._logger.name += " -RecoverCloudDirectPath";
            // Create new graphql operation recoverCloudDirectPath
            InitMutationRecoverCloudDirectPath();
        }

        // This parameter set invokes a single graphql operation:
        // refreshDomain.
        internal void ProcessRecord_RefreshDomain()
        {
            this._logger.name += " -RefreshDomain";
            // Create new graphql operation refreshDomain
            InitMutationRefreshDomain();
        }

        // This parameter set invokes a single graphql operation:
        // refreshGlobalManagerConnectivityStatus.
        internal void ProcessRecord_RefreshGlobalManagerConnectivityStatus()
        {
            this._logger.name += " -RefreshGlobalManagerConnectivityStatus";
            // Create new graphql operation refreshGlobalManagerConnectivityStatus
            InitMutationRefreshGlobalManagerConnectivityStatus();
        }

        // This parameter set invokes a single graphql operation:
        // refreshOrgNetwork.
        internal void ProcessRecord_RefreshOrgNetwork()
        {
            this._logger.name += " -RefreshOrgNetwork";
            // Create new graphql operation refreshOrgNetwork
            InitMutationRefreshOrgNetwork();
        }

        // This parameter set invokes a single graphql operation:
        // refreshVcdInstances.
        internal void ProcessRecord_RefreshVcdInstances()
        {
            this._logger.name += " -RefreshVcdInstances";
            // Create new graphql operation refreshVcdInstances
            InitMutationRefreshVcdInstances();
        }

        // This parameter set invokes a single graphql operation:
        // registerAndEnableMigrationChoice.
        internal void ProcessRecord_RegisterAndEnableMigrationChoice()
        {
            this._logger.name += " -RegisterAndEnableMigrationChoice";
            // Create new graphql operation registerAndEnableMigrationChoice
            InitMutationRegisterAndEnableMigrationChoice();
        }

        // This parameter set invokes a single graphql operation:
        // removeDisk.
        internal void ProcessRecord_RemoveDisk()
        {
            this._logger.name += " -RemoveDisk";
            // Create new graphql operation removeDisk
            InitMutationRemoveDisk();
        }

        // This parameter set invokes a single graphql operation:
        // removeInventoryWorkloads.
        internal void ProcessRecord_RemoveInventoryWorkloads()
        {
            this._logger.name += " -RemoveInventoryWorkloads";
            // Create new graphql operation removeInventoryWorkloads
            InitMutationRemoveInventoryWorkloads();
        }

        // This parameter set invokes a single graphql operation:
        // removeNodeForReplacement.
        internal void ProcessRecord_RemoveNodeForReplacement()
        {
            this._logger.name += " -RemoveNodeForReplacement";
            // Create new graphql operation removeNodeForReplacement
            InitMutationRemoveNodeForReplacement();
        }

        // This parameter set invokes a single graphql operation:
        // removePrivateEndpointConnection.
        internal void ProcessRecord_RemovePrivateEndpointList()
        {
            this._logger.name += " -RemovePrivateEndpointList";
            // Create new graphql operation removePrivateEndpointConnection
            InitMutationRemovePrivateEndpointConnection();
        }

        // This parameter set invokes a single graphql operation:
        // removeProxyConfig.
        internal void ProcessRecord_RemoveProxyConfig()
        {
            this._logger.name += " -RemoveProxyConfig";
            // Create new graphql operation removeProxyConfig
            InitMutationRemoveProxyConfig();
        }

        // This parameter set invokes a single graphql operation:
        // removeVlans.
        internal void ProcessRecord_RemoveVlans()
        {
            this._logger.name += " -RemoveVlans";
            // Create new graphql operation removeVlans
            InitMutationRemoveVlans();
        }

        // This parameter set invokes a single graphql operation:
        // reseedLogShippingSecondary.
        internal void ProcessRecord_ReseedLogShippingSecondary()
        {
            this._logger.name += " -ReseedLogShippingSecondary";
            // Create new graphql operation reseedLogShippingSecondary
            InitMutationReseedLogShippingSecondary();
        }

        // This parameter set invokes a single graphql operation:
        // resetAllOrgUsersPasswords.
        internal void ProcessRecord_ResetAllOrgUsersPasswords()
        {
            this._logger.name += " -ResetAllOrgUsersPasswords";
            // Create new graphql operation resetAllOrgUsersPasswords
            InitMutationResetAllOrgUsersPasswords();
        }

        // This parameter set invokes a single graphql operation:
        // resetMigrationOnModeChange.
        internal void ProcessRecord_ResetMigrationOnModeChange()
        {
            this._logger.name += " -ResetMigrationOnModeChange";
            // Create new graphql operation resetMigrationOnModeChange
            InitMutationResetMigrationOnModeChange();
        }

        // This parameter set invokes a single graphql operation:
        // resetPasskeys.
        internal void ProcessRecord_ResetPasskeys()
        {
            this._logger.name += " -ResetPasskeys";
            // Create new graphql operation resetPasskeys
            InitMutationResetPasskeys();
        }

        // This parameter set invokes a single graphql operation:
        // resetUsersPasswordsWithUserIds.
        internal void ProcessRecord_ResetUsersPasswordsWithUserIds()
        {
            this._logger.name += " -ResetUsersPasswordsWithUserIds";
            // Create new graphql operation resetUsersPasswordsWithUserIds
            InitMutationResetUsersPasswordsWithUserIds();
        }

        // This parameter set invokes a single graphql operation:
        // resizeDisk.
        internal void ProcessRecord_ResizeDisk()
        {
            this._logger.name += " -ResizeDisk";
            // Create new graphql operation resizeDisk
            InitMutationResizeDisk();
        }

        // This parameter set invokes a single graphql operation:
        // resolveAnomaly.
        internal void ProcessRecord_ResolveAnomaly()
        {
            this._logger.name += " -ResolveAnomaly";
            // Create new graphql operation resolveAnomaly
            InitMutationResolveAnomaly();
        }

        // This parameter set invokes a single graphql operation:
        // resolveVolumeGroupsConflict.
        internal void ProcessRecord_ResolveVolumeGroupsConflict()
        {
            this._logger.name += " -ResolveVolumeGroupsConflict";
            // Create new graphql operation resolveVolumeGroupsConflict
            InitMutationResolveVolumeGroupsConflict();
        }

        // This parameter set invokes a single graphql operation:
        // restoreConfigProtectionBackup.
        internal void ProcessRecord_RestoreConfigProtectionBackup()
        {
            this._logger.name += " -RestoreConfigProtectionBackup";
            // Create new graphql operation restoreConfigProtectionBackup
            InitMutationRestoreConfigProtectionBackup();
        }

        // This parameter set invokes a single graphql operation:
        // retryBackup.
        internal void ProcessRecord_RetryBackup()
        {
            this._logger.name += " -RetryBackup";
            // Create new graphql operation retryBackup
            InitMutationRetryBackup();
        }

        // This parameter set invokes a single graphql operation:
        // retryDownloadPackageJob.
        internal void ProcessRecord_RetryDownloadPackageJob()
        {
            this._logger.name += " -RetryDownloadPackageJob";
            // Create new graphql operation retryDownloadPackageJob
            InitMutationRetryDownloadPackageJob();
        }

        // This parameter set invokes a single graphql operation:
        // revokeAllOrgRoles.
        internal void ProcessRecord_RevokeAllOrgRoles()
        {
            this._logger.name += " -RevokeAllOrgRoles";
            // Create new graphql operation revokeAllOrgRoles
            InitMutationRevokeAllOrgRoles();
        }

        // This parameter set invokes a single graphql operation:
        // runCustomAnalyzer.
        internal void ProcessRecord_RunCustomAnalyzer()
        {
            this._logger.name += " -RunCustomAnalyzer";
            // Create new graphql operation runCustomAnalyzer
            InitMutationRunCustomAnalyzer();
        }

        // This parameter set invokes a single graphql operation:
        // runPrechecks.
        internal void ProcessRecord_RunPrechecks()
        {
            this._logger.name += " -RunPrechecks";
            // Create new graphql operation runPrechecks
            InitMutationRunPrechecks();
        }

        // This parameter set invokes a single graphql operation:
        // scheduleUpgradeBatchJob.
        internal void ProcessRecord_ScheduleUpgradeBatchJob()
        {
            this._logger.name += " -ScheduleUpgradeBatchJob";
            // Create new graphql operation scheduleUpgradeBatchJob
            InitMutationScheduleUpgradeBatchJob();
        }

        // This parameter set invokes a single graphql operation:
        // sendEmailNow.
        internal void ProcessRecord_SendEmailNow()
        {
            this._logger.name += " -SendEmailNow";
            // Create new graphql operation sendEmailNow
            InitMutationSendEmailNow();
        }

        // This parameter set invokes a single graphql operation:
        // sendPactsafeEvent.
        internal void ProcessRecord_SendPactsafeEvent()
        {
            this._logger.name += " -SendPactsafeEvent";
            // Create new graphql operation sendPactsafeEvent
            InitMutationSendPactsafeEvent();
        }

        // This parameter set invokes a single graphql operation:
        // sendTestSmtpEmail.
        internal void ProcessRecord_SendTestSmtpEmail()
        {
            this._logger.name += " -SendTestSmtpEmail";
            // Create new graphql operation sendTestSmtpEmail
            InitMutationSendTestSmtpEmail();
        }

        // This parameter set invokes a single graphql operation:
        // setAccountSettingValue.
        internal void ProcessRecord_SetAccountSettingValue()
        {
            this._logger.name += " -SetAccountSettingValue";
            // Create new graphql operation setAccountSettingValue
            InitMutationSetAccountSettingValue();
        }

        // This parameter set invokes a single graphql operation:
        // setAnalyzerRisks.
        internal void ProcessRecord_SetAnalyzerRisks()
        {
            this._logger.name += " -SetAnalyzerRisks";
            // Create new graphql operation setAnalyzerRisks
            InitMutationSetAnalyzerRisks();
        }

        // This parameter set invokes a single graphql operation:
        // setBrandLogo.
        internal void ProcessRecord_SetBrandLogo()
        {
            this._logger.name += " -SetBrandLogo";
            // Create new graphql operation setBrandLogo
            InitMutationSetBrandLogo();
        }

        // This parameter set invokes a single graphql operation:
        // setBundleApprovalStatus.
        internal void ProcessRecord_SetBundleApprovalStatus()
        {
            this._logger.name += " -SetBundleApprovalStatus";
            // Create new graphql operation setBundleApprovalStatus
            InitMutationSetBundleApprovalStatus();
        }

        // This parameter set invokes a single graphql operation:
        // setCorsSetting.
        internal void ProcessRecord_SetCorsSetting()
        {
            this._logger.name += " -SetCorsSetting";
            // Create new graphql operation setCorsSetting
            InitMutationSetCorsSetting();
        }

        // This parameter set invokes a single graphql operation:
        // setCustomerTags.
        internal void ProcessRecord_SetCustomerTags()
        {
            this._logger.name += " -SetCustomerTags";
            // Create new graphql operation setCustomerTags
            InitMutationSetCustomerTags();
        }

        // This parameter set invokes a single graphql operation:
        // setDatastoreFreespaceThresholds.
        internal void ProcessRecord_SetDatastoreFreespaceThresholds()
        {
            this._logger.name += " -SetDatastoreFreespaceThresholds";
            // Create new graphql operation setDatastoreFreespaceThresholds
            InitMutationSetDatastoreFreespaceThresholds();
        }

        // This parameter set invokes a single graphql operation:
        // setFederatedLoginStatus.
        internal void ProcessRecord_SetFederatedLoginStatus()
        {
            this._logger.name += " -SetFederatedLoginStatus";
            // Create new graphql operation setFederatedLoginStatus
            InitMutationSetFederatedLoginStatus();
        }

        // This parameter set invokes a single graphql operation:
        // setIdentityProvider.
        internal void ProcessRecord_SetIdentityProvider()
        {
            this._logger.name += " -SetIdentityProvider";
            // Create new graphql operation setIdentityProvider
            InitMutationSetIdentityProvider();
        }

        // This parameter set invokes a single graphql operation:
        // setIpWhitelistEnabled.
        internal void ProcessRecord_SetIpWhitelistEnabled()
        {
            this._logger.name += " -SetIpWhitelistEnabled";
            // Create new graphql operation setIpWhitelistEnabled
            InitMutationSetIpWhitelistEnabled();
        }

        // This parameter set invokes a single graphql operation:
        // setKmipClient.
        internal void ProcessRecord_SetKmipClient()
        {
            this._logger.name += " -SetKmipClient";
            // Create new graphql operation setKmipClient
            InitMutationSetKmipClient();
        }

        // This parameter set invokes a single graphql operation:
        // setLiveMountIps.
        internal void ProcessRecord_SetLiveMountIps()
        {
            this._logger.name += " -SetLiveMountIps";
            // Create new graphql operation setLiveMountIps
            InitMutationSetLiveMountIps();
        }

        // This parameter set invokes a single graphql operation:
        // setMfaSetting.
        internal void ProcessRecord_SetMfaSetting()
        {
            this._logger.name += " -SetMfaSetting";
            // Create new graphql operation setMfaSetting
            InitMutationSetMfaSetting();
        }

        // This parameter set invokes a single graphql operation:
        // setMigrationStatus.
        internal void ProcessRecord_SetMigrationStatus()
        {
            this._logger.name += " -SetMigrationStatus";
            // Create new graphql operation setMigrationStatus
            InitMutationSetMigrationStatus();
        }

        // This parameter set invokes a single graphql operation:
        // setPasskeyConfig.
        internal void ProcessRecord_SetPasskeyConfig()
        {
            this._logger.name += " -SetPasskeyConfig";
            // Create new graphql operation setPasskeyConfig
            InitMutationSetPasskeyConfig();
        }

        // This parameter set invokes a single graphql operation:
        // setPrivateContainerRegistry.
        internal void ProcessRecord_SetPrivateContainerRegistry()
        {
            this._logger.name += " -SetPrivateContainerRegistry";
            // Create new graphql operation setPrivateContainerRegistry
            InitMutationSetPrivateContainerRegistry();
        }

        // This parameter set invokes a single graphql operation:
        // setSmtpConfiguration.
        internal void ProcessRecord_SetSmtpConfiguration()
        {
            this._logger.name += " -SetSmtpConfiguration";
            // Create new graphql operation setSmtpConfiguration
            InitMutationSetSmtpConfiguration();
        }

        // This parameter set invokes a single graphql operation:
        // setTotpConfig.
        internal void ProcessRecord_SetTotpConfig()
        {
            this._logger.name += " -SetTotpConfig";
            // Create new graphql operation setTotpConfig
            InitMutationSetTotpConfig();
        }

        // This parameter set invokes a single graphql operation:
        // setUpgradeType.
        internal void ProcessRecord_SetUpgradeType()
        {
            this._logger.name += " -SetUpgradeType";
            // Create new graphql operation setUpgradeType
            InitMutationSetUpgradeType();
        }

        // This parameter set invokes a single graphql operation:
        // setUserLevelTotpEnforcement.
        internal void ProcessRecord_SetUserLevelTotpEnforcement()
        {
            this._logger.name += " -SetUserLevelTotpEnforcement";
            // Create new graphql operation setUserLevelTotpEnforcement
            InitMutationSetUserLevelTotpEnforcement();
        }

        // This parameter set invokes a single graphql operation:
        // setUserSessionManagementConfig.
        internal void ProcessRecord_SetUserSessionManagementConfig()
        {
            this._logger.name += " -SetUserSessionManagementConfig";
            // Create new graphql operation setUserSessionManagementConfig
            InitMutationSetUserSessionManagementConfig();
        }

        // This parameter set invokes a single graphql operation:
        // setUserSetting.
        internal void ProcessRecord_SetUserSetting()
        {
            this._logger.name += " -SetUserSetting";
            // Create new graphql operation setUserSetting
            InitMutationSetUserSetting();
        }

        // This parameter set invokes a single graphql operation:
        // setWorkloadAlertSetting.
        internal void ProcessRecord_SetWorkloadAlertSetting()
        {
            this._logger.name += " -SetWorkloadAlertSetting";
            // Create new graphql operation setWorkloadAlertSetting
            InitMutationSetWorkloadAlertSetting();
        }

        // This parameter set invokes a single graphql operation:
        // setWwwTlsCert.
        internal void ProcessRecord_SetWwwTlsCert()
        {
            this._logger.name += " -SetWwwTlsCert";
            // Create new graphql operation setWwwTlsCert
            InitMutationSetWwwTlsCert();
        }

        // This parameter set invokes a single graphql operation:
        // setupAtlassianSite.
        internal void ProcessRecord_SetupAtlassianSite()
        {
            this._logger.name += " -SetupAtlassianSite";
            // Create new graphql operation setupAtlassianSite
            InitMutationSetupAtlassianSite();
        }

        // This parameter set invokes a single graphql operation:
        // setupDisk.
        internal void ProcessRecord_SetupDisk()
        {
            this._logger.name += " -SetupDisk";
            // Create new graphql operation setupDisk
            InitMutationSetupDisk();
        }

        // This parameter set invokes a single graphql operation:
        // setupSalesforceOrganization.
        internal void ProcessRecord_SetupSalesforceOrganization()
        {
            this._logger.name += " -SetupSalesforceOrganization";
            // Create new graphql operation setupSalesforceOrganization
            InitMutationSetupSalesforceOrganization();
        }

        // This parameter set invokes a single graphql operation:
        // snoozeEula.
        internal void ProcessRecord_SnoozeEula()
        {
            this._logger.name += " -SnoozeEula";
            // Create new graphql operation snoozeEula
            InitMutationSnoozeEula();
        }

        // This parameter set invokes a single graphql operation:
        // startBlueprintFailover.
        internal void ProcessRecord_StartBlueprintFailover()
        {
            this._logger.name += " -StartBlueprintFailover";
            // Create new graphql operation startBlueprintFailover
            InitMutationStartBlueprintFailover();
        }

        // This parameter set invokes a single graphql operation:
        // startBlueprintsFailover.
        internal void ProcessRecord_StartBlueprintsFailover()
        {
            this._logger.name += " -StartBlueprintsFailover";
            // Create new graphql operation startBlueprintsFailover
            InitMutationStartBlueprintsFailover();
        }

        // This parameter set invokes a single graphql operation:
        // startBulkRecovery.
        internal void ProcessRecord_StartBulkRecovery()
        {
            this._logger.name += " -StartBulkRecovery";
            // Create new graphql operation startBulkRecovery
            InitMutationStartBulkRecovery();
        }

        // This parameter set invokes a single graphql operation:
        // startCrawl.
        internal void ProcessRecord_StartCrawl()
        {
            this._logger.name += " -StartCrawl";
            // Create new graphql operation startCrawl
            InitMutationStartCrawl();
        }

        // This parameter set invokes a single graphql operation:
        // startCyberRecovery.
        internal void ProcessRecord_StartCyberRecovery()
        {
            this._logger.name += " -StartCyberRecovery";
            // Create new graphql operation startCyberRecovery
            InitMutationStartCyberRecovery();
        }

        // This parameter set invokes a single graphql operation:
        // startDownloadPackageBatchJob.
        internal void ProcessRecord_StartDownloadPackageBatchJob()
        {
            this._logger.name += " -StartDownloadPackageBatchJob";
            // Create new graphql operation startDownloadPackageBatchJob
            InitMutationStartDownloadPackageBatchJob();
        }

        // This parameter set invokes a single graphql operation:
        // startExportRdsInstanceJob.
        internal void ProcessRecord_StartExportRdsInstanceJob()
        {
            this._logger.name += " -StartExportRdsInstanceJob";
            // Create new graphql operation startExportRdsInstanceJob
            InitMutationStartExportRdsInstanceJob();
        }

        // This parameter set invokes a single graphql operation:
        // startFetchCdmRbacConfigJob.
        internal void ProcessRecord_StartFetchCdmRbacConfigJob()
        {
            this._logger.name += " -StartFetchCdmRbacConfigJob";
            // Create new graphql operation startFetchCdmRbacConfigJob
            InitMutationStartFetchCdmRbacConfigJob();
        }

        // This parameter set invokes a single graphql operation:
        // startMalwareDetection.
        internal void ProcessRecord_StartMalwareDetection()
        {
            this._logger.name += " -StartMalwareDetection";
            // Create new graphql operation startMalwareDetection
            InitMutationStartMalwareDetection();
        }

        // This parameter set invokes a single graphql operation:
        // startMigrateCdmRbacConfigJob.
        internal void ProcessRecord_StartMigrateCdmRbacConfigJob()
        {
            this._logger.name += " -StartMigrateCdmRbacConfigJob";
            // Create new graphql operation startMigrateCdmRbacConfigJob
            InitMutationStartMigrateCdmRbacConfigJob();
        }

        // This parameter set invokes a single graphql operation:
        // startMultipleBulkRecoveries.
        internal void ProcessRecord_StartMultipleBulkRecoveries()
        {
            this._logger.name += " -StartMultipleBulkRecoveries";
            // Create new graphql operation startMultipleBulkRecoveries
            InitMutationStartMultipleBulkRecoveries();
        }

        // This parameter set invokes a single graphql operation:
        // startNasAutomigrationJob.
        internal void ProcessRecord_StartNasAutomigrationJob()
        {
            this._logger.name += " -StartNasAutomigrationJob";
            // Create new graphql operation startNasAutomigrationJob
            InitMutationStartNasAutomigrationJob();
        }

        // This parameter set invokes a single graphql operation:
        // startPeriodicUpgradePrechecksOnDemandJob.
        internal void ProcessRecord_StartPeriodicUpgradePrechecksOnDemandJob()
        {
            this._logger.name += " -StartPeriodicUpgradePrechecksOnDemandJob";
            // Create new graphql operation startPeriodicUpgradePrechecksOnDemandJob
            InitMutationStartPeriodicUpgradePrechecksOnDemandJob();
        }

        // This parameter set invokes a single graphql operation:
        // startSaasAppAuthConsent.
        internal void ProcessRecord_StartSaasAppAuthConsent()
        {
            this._logger.name += " -StartSaasAppAuthConsent";
            // Create new graphql operation startSaasAppAuthConsent
            InitMutationStartSaasAppAuthConsent();
        }

        // This parameter set invokes a single graphql operation:
        // startSaasAppsDeleteOrg.
        internal void ProcessRecord_StartSaasAppsDeleteOrg()
        {
            this._logger.name += " -StartSaasAppsDeleteOrg";
            // Create new graphql operation startSaasAppsDeleteOrg
            InitMutationStartSaasAppsDeleteOrg();
        }

        // This parameter set invokes a single graphql operation:
        // startUpgradeBatchJob.
        internal void ProcessRecord_StartUpgradeBatchJob()
        {
            this._logger.name += " -StartUpgradeBatchJob";
            // Create new graphql operation startUpgradeBatchJob
            InitMutationStartUpgradeBatchJob();
        }

        // This parameter set invokes a single graphql operation:
        // startVolumeGroupMount.
        internal void ProcessRecord_StartVolumeGroupMount()
        {
            this._logger.name += " -StartVolumeGroupMount";
            // Create new graphql operation startVolumeGroupMount
            InitMutationStartVolumeGroupMount();
        }

        // This parameter set invokes a single graphql operation:
        // stopJobInstance.
        internal void ProcessRecord_StopJobInstance()
        {
            this._logger.name += " -StopJobInstance";
            // Create new graphql operation stopJobInstance
            InitMutationStopJobInstance();
        }

        // This parameter set invokes a single graphql operation:
        // stopJobInstanceFromEventSeries.
        internal void ProcessRecord_StopJobInstanceFromEventSeries()
        {
            this._logger.name += " -StopJobInstanceFromEventSeries";
            // Create new graphql operation stopJobInstanceFromEventSeries
            InitMutationStopJobInstanceFromEventSeries();
        }

        // This parameter set invokes a single graphql operation:
        // submitTprRequest.
        internal void ProcessRecord_SubmitTprRequest()
        {
            this._logger.name += " -SubmitTprRequest";
            // Create new graphql operation submitTprRequest
            InitMutationSubmitTprRequest();
        }

        // This parameter set invokes a single graphql operation:
        // supportPortalLogin.
        internal void ProcessRecord_SupportPortalLogin()
        {
            this._logger.name += " -SupportPortalLogin";
            // Create new graphql operation supportPortalLogin
            InitMutationSupportPortalLogin();
        }

        // This parameter set invokes a single graphql operation:
        // switchProductToOnboardingMode.
        internal void ProcessRecord_SwitchProductToOnboardingMode()
        {
            this._logger.name += " -SwitchProductToOnboardingMode";
            // Create new graphql operation switchProductToOnboardingMode
            InitMutationSwitchProductToOnboardingMode();
        }

        // This parameter set invokes a single graphql operation:
        // toggleFeatureEnabled.
        internal void ProcessRecord_ToggleFeatureEnabled()
        {
            this._logger.name += " -ToggleFeatureEnabled";
            // Create new graphql operation toggleFeatureEnabled
            InitMutationToggleFeatureEnabled();
        }

        // This parameter set invokes a single graphql operation:
        // triggerCloudComputeConnectivityCheck.
        internal void ProcessRecord_TriggerCloudComputeConnectivityCheck()
        {
            this._logger.name += " -TriggerCloudComputeConnectivityCheck";
            // Create new graphql operation triggerCloudComputeConnectivityCheck
            InitMutationTriggerCloudComputeConnectivityCheck();
        }

        // This parameter set invokes a single graphql operation:
        // triggerExocomputeHealthCheck.
        internal void ProcessRecord_TriggerExocomputeHealthCheck()
        {
            this._logger.name += " -TriggerExocomputeHealthCheck";
            // Create new graphql operation triggerExocomputeHealthCheck
            InitMutationTriggerExocomputeHealthCheck();
        }

        // This parameter set invokes a single graphql operation:
        // uninstallIoFilter.
        internal void ProcessRecord_UninstallIoFilter()
        {
            this._logger.name += " -UninstallIoFilter";
            // Create new graphql operation uninstallIoFilter
            InitMutationUninstallIoFilter();
        }

        // This parameter set invokes a single graphql operation:
        // unlockUsersByAdmin.
        internal void ProcessRecord_UnlockUsersByAdmin()
        {
            this._logger.name += " -UnlockUsersByAdmin";
            // Create new graphql operation unlockUsersByAdmin
            InitMutationUnlockUsersByAdmin();
        }

        // This parameter set invokes a single graphql operation:
        // unmountDisk.
        internal void ProcessRecord_UnmountDisk()
        {
            this._logger.name += " -UnmountDisk";
            // Create new graphql operation unmountDisk
            InitMutationUnmountDisk();
        }

        // This parameter set invokes a single graphql operation:
        // updateAccountOwner.
        internal void ProcessRecord_UpdateAccountOwner()
        {
            this._logger.name += " -UpdateAccountOwner";
            // Create new graphql operation updateAccountOwner
            InitMutationUpdateAccountOwner();
        }

        // This parameter set invokes a single graphql operation:
        // updateAccountSettings.
        internal void ProcessRecord_UpdateAccountSettings()
        {
            this._logger.name += " -UpdateAccountSettings";
            // Create new graphql operation updateAccountSettings
            InitMutationUpdateAccountSettings();
        }

        // This parameter set invokes a single graphql operation:
        // updateAdGroup.
        internal void ProcessRecord_UpdateAdGroup()
        {
            this._logger.name += " -UpdateAdGroup";
            // Create new graphql operation updateAdGroup
            InitMutationUpdateAdGroup();
        }

        // This parameter set invokes a single graphql operation:
        // updateAgentDeploymentSetting.
        internal void ProcessRecord_UpdateAgentDeploymentSetting()
        {
            this._logger.name += " -UpdateAgentDeploymentSetting";
            // Create new graphql operation updateAgentDeploymentSetting
            InitMutationUpdateAgentDeploymentSetting();
        }

        // This parameter set invokes a single graphql operation:
        // updateAgentDeploymentSettingInBatch.
        internal void ProcessRecord_UpdateAgentDeploymentSettingInBatch()
        {
            this._logger.name += " -UpdateAgentDeploymentSettingInBatch";
            // Create new graphql operation updateAgentDeploymentSettingInBatch
            InitMutationUpdateAgentDeploymentSettingInBatch();
        }

        // This parameter set invokes a single graphql operation:
        // updateAuthDomainUsersHiddenStatus.
        internal void ProcessRecord_UpdateAuthDomainUsersHiddenStatus()
        {
            this._logger.name += " -UpdateAuthDomainUsersHiddenStatus";
            // Create new graphql operation updateAuthDomainUsersHiddenStatus
            InitMutationUpdateAuthDomainUsersHiddenStatus();
        }

        // This parameter set invokes a single graphql operation:
        // updateBackupThrottleSetting.
        internal void ProcessRecord_UpdateBackupThrottleSetting()
        {
            this._logger.name += " -UpdateBackupThrottleSetting";
            // Create new graphql operation updateBackupThrottleSetting
            InitMutationUpdateBackupThrottleSetting();
        }

        // This parameter set invokes a single graphql operation:
        // updateBadDiskLedStatus.
        internal void ProcessRecord_UpdateBadDiskLedStatus()
        {
            this._logger.name += " -UpdateBadDiskLedStatus";
            // Create new graphql operation updateBadDiskLedStatus
            InitMutationUpdateBadDiskLedStatus();
        }

        // This parameter set invokes a single graphql operation:
        // updateBlueprint.
        internal void ProcessRecord_UpdateBlueprint()
        {
            this._logger.name += " -UpdateBlueprint";
            // Create new graphql operation updateBlueprint
            InitMutationUpdateBlueprint();
        }

        // This parameter set invokes a single graphql operation:
        // updateChat.
        internal void ProcessRecord_UpdateChat()
        {
            this._logger.name += " -UpdateChat";
            // Create new graphql operation updateChat
            InitMutationUpdateChat();
        }

        // This parameter set invokes a single graphql operation:
        // updateChatbot.
        internal void ProcessRecord_UpdateChatbot()
        {
            this._logger.name += " -UpdateChatbot";
            // Create new graphql operation updateChatbot
            InitMutationUpdateChatbot();
        }

        // This parameter set invokes a single graphql operation:
        // updateClassificationBannerEnabled.
        internal void ProcessRecord_UpdateClassificationBannerEnabled()
        {
            this._logger.name += " -UpdateClassificationBannerEnabled";
            // Create new graphql operation updateClassificationBannerEnabled
            InitMutationUpdateClassificationBannerEnabled();
        }

        // This parameter set invokes a single graphql operation:
        // updateClassificationBannerSettings.
        internal void ProcessRecord_UpdateClassificationBannerSettings()
        {
            this._logger.name += " -UpdateClassificationBannerSettings";
            // Create new graphql operation updateClassificationBannerSettings
            InitMutationUpdateClassificationBannerSettings();
        }

        // This parameter set invokes a single graphql operation:
        // updateClassificationLoginEnabled.
        internal void ProcessRecord_UpdateClassificationLoginEnabled()
        {
            this._logger.name += " -UpdateClassificationLoginEnabled";
            // Create new graphql operation updateClassificationLoginEnabled
            InitMutationUpdateClassificationLoginEnabled();
        }

        // This parameter set invokes a single graphql operation:
        // updateClassificationLoginSettings.
        internal void ProcessRecord_UpdateClassificationLoginSettings()
        {
            this._logger.name += " -UpdateClassificationLoginSettings";
            // Create new graphql operation updateClassificationLoginSettings
            InitMutationUpdateClassificationLoginSettings();
        }

        // This parameter set invokes a single graphql operation:
        // updateConfigProtectionSetup.
        internal void ProcessRecord_UpdateConfigProtectionSetup()
        {
            this._logger.name += " -UpdateConfigProtectionSetup";
            // Create new graphql operation updateConfigProtectionSetup
            InitMutationUpdateConfigProtectionSetup();
        }

        // This parameter set invokes a single graphql operation:
        // updateConfiguredGroup.
        internal void ProcessRecord_UpdateConfiguredGroup()
        {
            this._logger.name += " -UpdateConfiguredGroup";
            // Create new graphql operation updateConfiguredGroup
            InitMutationUpdateConfiguredGroup();
        }

        // This parameter set invokes a single graphql operation:
        // updateCustomAnalyzer.
        internal void ProcessRecord_UpdateCustomAnalyzer()
        {
            this._logger.name += " -UpdateCustomAnalyzer";
            // Create new graphql operation updateCustomAnalyzer
            InitMutationUpdateCustomAnalyzer();
        }

        // This parameter set invokes a single graphql operation:
        // updateCustomIntelFeed.
        internal void ProcessRecord_UpdateCustomIntelFeed()
        {
            this._logger.name += " -UpdateCustomIntelFeed";
            // Create new graphql operation updateCustomIntelFeed
            InitMutationUpdateCustomIntelFeed();
        }

        // This parameter set invokes a single graphql operation:
        // updateCustomerAppPermissions.
        internal void ProcessRecord_UpdateCustomerAppPermissions()
        {
            this._logger.name += " -UpdateCustomerAppPermissions";
            // Create new graphql operation updateCustomerAppPermissions
            InitMutationUpdateCustomerAppPermissions();
        }

        // This parameter set invokes a single graphql operation:
        // updateCyberEventLockdown.
        internal void ProcessRecord_UpdateCyberEventLockdown()
        {
            this._logger.name += " -UpdateCyberEventLockdown";
            // Create new graphql operation updateCyberEventLockdown
            InitMutationUpdateCyberEventLockdown();
        }

        // This parameter set invokes a single graphql operation:
        // updateDistributionListDigest.
        internal void ProcessRecord_UpdateDistributionListDigest()
        {
            this._logger.name += " -UpdateDistributionListDigest";
            // Create new graphql operation updateDistributionListDigest
            InitMutationUpdateDistributionListDigest();
        }

        // This parameter set invokes a single graphql operation:
        // updateDnsServersAndSearchDomains.
        internal void ProcessRecord_UpdateDnsServersAndSearchDomains()
        {
            this._logger.name += " -UpdateDnsServersAndSearchDomains";
            // Create new graphql operation updateDnsServersAndSearchDomains
            InitMutationUpdateDnsServersAndSearchDomains();
        }

        // This parameter set invokes a single graphql operation:
        // updateEulaAccepted.
        internal void ProcessRecord_UpdateEulaAccepted()
        {
            this._logger.name += " -UpdateEulaAccepted";
            // Create new graphql operation updateEulaAccepted
            InitMutationUpdateEulaAccepted();
        }

        // This parameter set invokes a single graphql operation:
        // updateEventDigest.
        internal void ProcessRecord_UpdateEventDigest()
        {
            this._logger.name += " -UpdateEventDigest";
            // Create new graphql operation updateEventDigest
            InitMutationUpdateEventDigest();
        }

        // This parameter set invokes a single graphql operation:
        // updateFloatingIps.
        internal void ProcessRecord_UpdateFloatingIps()
        {
            this._logger.name += " -UpdateFloatingIps";
            // Create new graphql operation updateFloatingIps
            InitMutationUpdateFloatingIps();
        }

        // This parameter set invokes a single graphql operation:
        // updateGuestCredential.
        internal void ProcessRecord_UpdateGuestCredential()
        {
            this._logger.name += " -UpdateGuestCredential";
            // Create new graphql operation updateGuestCredential
            InitMutationUpdateGuestCredential();
        }

        // This parameter set invokes a single graphql operation:
        // updateIdentityProvider.
        internal void ProcessRecord_UpdateIdentityProvider()
        {
            this._logger.name += " -UpdateIdentityProvider";
            // Create new graphql operation updateIdentityProvider
            InitMutationUpdateIdentityProvider();
        }

        // This parameter set invokes a single graphql operation:
        // updateInsightState.
        internal void ProcessRecord_UpdateInsightState()
        {
            this._logger.name += " -UpdateInsightState";
            // Create new graphql operation updateInsightState
            InitMutationUpdateInsightState();
        }

        // This parameter set invokes a single graphql operation:
        // updateIocStatus.
        internal void ProcessRecord_UpdateIocStatus()
        {
            this._logger.name += " -UpdateIocStatus";
            // Create new graphql operation updateIocStatus
            InitMutationUpdateIocStatus();
        }

        // This parameter set invokes a single graphql operation:
        // updateIpWhitelist.
        internal void ProcessRecord_UpdateIpWhitelist()
        {
            this._logger.name += " -UpdateIpWhitelist";
            // Create new graphql operation updateIpWhitelist
            InitMutationUpdateIpWhitelist();
        }

        // This parameter set invokes a single graphql operation:
        // updateKmipServer.
        internal void ProcessRecord_UpdateKmipServer()
        {
            this._logger.name += " -UpdateKmipServer";
            // Create new graphql operation updateKmipServer
            InitMutationUpdateKmipServer();
        }

        // This parameter set invokes a single graphql operation:
        // updateLambdaSettings.
        internal void ProcessRecord_UpdateLambdaSettings()
        {
            this._logger.name += " -UpdateLambdaSettings";
            // Create new graphql operation updateLambdaSettings
            InitMutationUpdateLambdaSettings();
        }

        // This parameter set invokes a single graphql operation:
        // updateLlmEnabled.
        internal void ProcessRecord_UpdateLlmEnabled()
        {
            this._logger.name += " -UpdateLlmEnabled";
            // Create new graphql operation updateLlmEnabled
            InitMutationUpdateLlmEnabled();
        }

        // This parameter set invokes a single graphql operation:
        // updateLockoutConfig.
        internal void ProcessRecord_UpdateLockoutConfig()
        {
            this._logger.name += " -UpdateLockoutConfig";
            // Create new graphql operation updateLockoutConfig
            InitMutationUpdateLockoutConfig();
        }

        // This parameter set invokes a single graphql operation:
        // updateManagedIdentities.
        internal void ProcessRecord_UpdateManagedIdentities()
        {
            this._logger.name += " -UpdateManagedIdentities";
            // Create new graphql operation updateManagedIdentities
            InitMutationUpdateManagedIdentities();
        }

        // This parameter set invokes a single graphql operation:
        // updateNetworkThrottle.
        internal void ProcessRecord_UpdateNetworkThrottle()
        {
            this._logger.name += " -UpdateNetworkThrottle";
            // Create new graphql operation updateNetworkThrottle
            InitMutationUpdateNetworkThrottle();
        }

        // This parameter set invokes a single graphql operation:
        // updateOrgNetwork.
        internal void ProcessRecord_UpdateOrgNetwork()
        {
            this._logger.name += " -UpdateOrgNetwork";
            // Create new graphql operation updateOrgNetwork
            InitMutationUpdateOrgNetwork();
        }

        // This parameter set invokes a single graphql operation:
        // updatePactsafeEulaAccepted.
        internal void ProcessRecord_UpdatePactsafeEulaAccepted()
        {
            this._logger.name += " -UpdatePactsafeEulaAccepted";
            // Create new graphql operation updatePactsafeEulaAccepted
            InitMutationUpdatePactsafeEulaAccepted();
        }

        // This parameter set invokes a single graphql operation:
        // updatePactsafeEulaSeen.
        internal void ProcessRecord_UpdatePactsafeEulaSeen()
        {
            this._logger.name += " -UpdatePactsafeEulaSeen";
            // Create new graphql operation updatePactsafeEulaSeen
            InitMutationUpdatePactsafeEulaSeen();
        }

        // This parameter set invokes a single graphql operation:
        // updateProxyConfig.
        internal void ProcessRecord_UpdateProxyConfig()
        {
            this._logger.name += " -UpdateProxyConfig";
            // Create new graphql operation updateProxyConfig
            InitMutationUpdateProxyConfig();
        }

        // This parameter set invokes a single graphql operation:
        // updateReaderLocationMasterKeyWithOwnerLocationKey.
        internal void ProcessRecord_UpdateReaderLocationMasterKeyWithOwnerLocationKey()
        {
            this._logger.name += " -UpdateReaderLocationMasterKeyWithOwnerLocationKey";
            // Create new graphql operation updateReaderLocationMasterKeyWithOwnerLocationKey
            InitMutationUpdateReaderLocationMasterKeyWithOwnerLocationKey();
        }

        // This parameter set invokes a single graphql operation:
        // updateReaderLocationMasterKeyWithRsaKey.
        internal void ProcessRecord_UpdateReaderLocationMasterKeyWithRsaKey()
        {
            this._logger.name += " -UpdateReaderLocationMasterKeyWithRsaKey";
            // Create new graphql operation updateReaderLocationMasterKeyWithRsaKey
            InitMutationUpdateReaderLocationMasterKeyWithRsaKey();
        }

        // This parameter set invokes a single graphql operation:
        // updateRecoveryPlan.
        internal void ProcessRecord_UpdateRecoveryPlan()
        {
            this._logger.name += " -UpdateRecoveryPlan";
            // Create new graphql operation updateRecoveryPlan
            InitMutationUpdateRecoveryPlan();
        }

        // This parameter set invokes a single graphql operation:
        // updateRecoverySchedule.
        internal void ProcessRecord_UpdateRecoverySchedule()
        {
            this._logger.name += " -UpdateRecoverySchedule";
            // Create new graphql operation updateRecoverySchedule
            InitMutationUpdateRecoverySchedule();
        }

        // This parameter set invokes a single graphql operation:
        // updateRoleAssignments.
        internal void ProcessRecord_UpdateRoleAssignments()
        {
            this._logger.name += " -UpdateRoleAssignments";
            // Create new graphql operation updateRoleAssignments
            InitMutationUpdateRoleAssignments();
        }

        // This parameter set invokes a single graphql operation:
        // updateSnapMirrorCloud.
        internal void ProcessRecord_UpdateSnapMirrorCloud()
        {
            this._logger.name += " -UpdateSnapMirrorCloud";
            // Create new graphql operation updateSnapMirrorCloud
            InitMutationUpdateSnapMirrorCloud();
        }

        // This parameter set invokes a single graphql operation:
        // updateSupportCase.
        internal void ProcessRecord_UpdateSupportCase()
        {
            this._logger.name += " -UpdateSupportCase";
            // Create new graphql operation updateSupportCase
            InitMutationUpdateSupportCase();
        }

        // This parameter set invokes a single graphql operation:
        // updateSupportUserAccess.
        internal void ProcessRecord_UpdateSupportUserAccess()
        {
            this._logger.name += " -UpdateSupportUserAccess";
            // Create new graphql operation updateSupportUserAccess
            InitMutationUpdateSupportUserAccess();
        }

        // This parameter set invokes a single graphql operation:
        // updateTprConfiguration.
        internal void ProcessRecord_UpdateTprConfiguration()
        {
            this._logger.name += " -UpdateTprConfiguration";
            // Create new graphql operation updateTprConfiguration
            InitMutationUpdateTprConfiguration();
        }

        // This parameter set invokes a single graphql operation:
        // updateTunnelStatus.
        internal void ProcessRecord_UpdateTunnelStatus()
        {
            this._logger.name += " -UpdateTunnelStatus";
            // Create new graphql operation updateTunnelStatus
            InitMutationUpdateTunnelStatus();
        }

        // This parameter set invokes a single graphql operation:
        // updateVcdInstances.
        internal void ProcessRecord_UpdateVcdInstances()
        {
            this._logger.name += " -UpdateVcdInstances";
            // Create new graphql operation updateVcdInstances
            InitMutationUpdateVcdInstances();
        }

        // This parameter set invokes a single graphql operation:
        // updateVcdVapp.
        internal void ProcessRecord_UpdateVcdVapp()
        {
            this._logger.name += " -UpdateVcdVapp";
            // Create new graphql operation updateVcdVapp
            InitMutationUpdateVcdVapp();
        }

        // This parameter set invokes a single graphql operation:
        // updateVlan.
        internal void ProcessRecord_UpdateVlan()
        {
            this._logger.name += " -UpdateVlan";
            // Create new graphql operation updateVlan
            InitMutationUpdateVlan();
        }

        // This parameter set invokes a single graphql operation:
        // updateVolumeGroup.
        internal void ProcessRecord_UpdateVolumeGroup()
        {
            this._logger.name += " -UpdateVolumeGroup";
            // Create new graphql operation updateVolumeGroup
            InitMutationUpdateVolumeGroup();
        }

        // This parameter set invokes a single graphql operation:
        // updateWhitelistedAnalyzers.
        internal void ProcessRecord_UpdateWhitelistedAnalyzers()
        {
            this._logger.name += " -UpdateWhitelistedAnalyzers";
            // Create new graphql operation updateWhitelistedAnalyzers
            InitMutationUpdateWhitelistedAnalyzers();
        }

        // This parameter set invokes a single graphql operation:
        // upgradeIoFilter.
        internal void ProcessRecord_UpgradeIoFilter()
        {
            this._logger.name += " -UpgradeIoFilter";
            // Create new graphql operation upgradeIoFilter
            InitMutationUpgradeIoFilter();
        }

        // This parameter set invokes a single graphql operation:
        // upgradeToRsc.
        internal void ProcessRecord_UpgradeToRsc()
        {
            this._logger.name += " -UpgradeToRsc";
            // Create new graphql operation upgradeToRsc
            InitMutationUpgradeToRsc();
        }

        // This parameter set invokes a single graphql operation:
        // validateAndSaveCustomerKmsInfo.
        internal void ProcessRecord_ValidateAndSaveCustomerKmsInfo()
        {
            this._logger.name += " -ValidateAndSaveCustomerKmsInfo";
            // Create new graphql operation validateAndSaveCustomerKmsInfo
            InitMutationValidateAndSaveCustomerKmsInfo();
        }

        // This parameter set invokes a single graphql operation:
        // validateBlueprint.
        internal void ProcessRecord_ValidateBlueprint()
        {
            this._logger.name += " -ValidateBlueprint";
            // Create new graphql operation validateBlueprint
            InitMutationValidateBlueprint();
        }

        // This parameter set invokes a single graphql operation:
        // validateBlueprintRecoverySpec.
        internal void ProcessRecord_ValidateBlueprintRecoverySpec()
        {
            this._logger.name += " -ValidateBlueprintRecoverySpec";
            // Create new graphql operation validateBlueprintRecoverySpec
            InitMutationValidateBlueprintRecoverySpec();
        }

        // This parameter set invokes a single graphql operation:
        // validateBlueprints.
        internal void ProcessRecord_ValidateBlueprints()
        {
            this._logger.name += " -ValidateBlueprints";
            // Create new graphql operation validateBlueprints
            InitMutationValidateBlueprints();
        }

        // This parameter set invokes a single graphql operation:
        // validateCompleteOperationalRecoveryFeasibility.
        internal void ProcessRecord_ValidateCompleteOperationalRecoveryFeasibility()
        {
            this._logger.name += " -ValidateCompleteOperationalRecoveryFeasibility";
            // Create new graphql operation validateCompleteOperationalRecoveryFeasibility
            InitMutationValidateCompleteOperationalRecoveryFeasibility();
        }

        // This parameter set invokes a single graphql operation:
        // validateTicketingPlatformConfig.
        internal void ProcessRecord_ValidateTicketingPlatformConfig()
        {
            this._logger.name += " -ValidateTicketingPlatformConfig";
            // Create new graphql operation validateTicketingPlatformConfig
            InitMutationValidateTicketingPlatformConfig();
        }

        // This parameter set invokes a single graphql operation:
        // vmMakePrimary.
        internal void ProcessRecord_VmMakePrimary()
        {
            this._logger.name += " -VmMakePrimary";
            // Create new graphql operation vmMakePrimary
            InitMutationVmMakePrimary();
        }

        // This parameter set invokes a single graphql operation:
        // vpshereVMRecoveryPointMount.
        internal void ProcessRecord_VpshereVMRecoveryPointMount()
        {
            this._logger.name += " -VpshereVMRecoveryPointMount";
            // Create new graphql operation vpshereVMRecoveryPointMount
            InitMutationVpshereVmRecoveryPointMount();
        }

        // This parameter set invokes a single graphql operation:
        // warmSearchCache.
        internal void ProcessRecord_WarmSearchCache()
        {
            this._logger.name += " -WarmSearchCache";
            // Create new graphql operation warmSearchCache
            InitMutationWarmSearchCache();
        }


        // Create new GraphQL Mutation:
        // acknowledgeFedrampBoundaryExit(input: AcknowledgeFedrampBoundaryExitInput!): Void
        internal void InitMutationAcknowledgeFedrampBoundaryExit()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "AcknowledgeFedrampBoundaryExitInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationAcknowledgeFedrampBoundaryExit",
                "($input: AcknowledgeFedrampBoundaryExitInput!)",
                "System.String",
                Mutation.AcknowledgeFedrampBoundaryExit,
                Mutation.AcknowledgeFedrampBoundaryExitFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	url = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // activateTrialAsync(input: ActivateTrialAsyncInput!): ActivateTrialAsyncReply!
        internal void InitMutationActivateTrialAsync()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "ActivateTrialAsyncInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationActivateTrialAsync",
                "($input: ActivateTrialAsyncInput!)",
                "ActivateTrialAsyncReply",
                Mutation.ActivateTrialAsync,
                Mutation.ActivateTrialAsyncFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	trialId = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // addAdGroupsToHierarchy(input: AddAdGroupsToHierarchyInput!): RequestStatus!
        internal void InitMutationAddAdGroupsToHierarchy()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "AddAdGroupsToHierarchyInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationAddAdGroupsToHierarchy",
                "($input: AddAdGroupsToHierarchyInput!)",
                "RequestStatus",
                Mutation.AddAdGroupsToHierarchy,
                Mutation.AddAdGroupsToHierarchyFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	orgId = $someString
	# REQUIRED
	naturalIds = @(
		$someString
	)
	# OPTIONAL
	adGroupSpec = @(
		@{
			# REQUIRED
			naturalId = $someString
			# OPTIONAL
			displayName = $someString
			# REQUIRED
			filterAttributes = @(
				@{
					# OPTIONAL
					filterOpType = $someJoinOpType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.JoinOpType]) for enum values.
					# OPTIONAL
					attributeType = $someAttributeType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AttributeType]) for enum values.
					# OPTIONAL
					attributeKey = $someString
					# OPTIONAL
					attributeValue = $someString
					# OPTIONAL
					dataType = $someAttributeDataType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AttributeDataType]) for enum values.
				}
			)
		}
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // addConfiguredGroupToHierarchy(input: AddConfiguredGroupToHierarchyInput!): AddConfiguredGroupToHierarchyReply!
        internal void InitMutationAddConfiguredGroupToHierarchy()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "AddConfiguredGroupToHierarchyInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationAddConfiguredGroupToHierarchy",
                "($input: AddConfiguredGroupToHierarchyInput!)",
                "AddConfiguredGroupToHierarchyReply",
                Mutation.AddConfiguredGroupToHierarchy,
                Mutation.AddConfiguredGroupToHierarchyFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	orgId = $someString
	# REQUIRED
	displayName = $someString
	# OPTIONAL
	wildcard = $someString
	# REQUIRED
	pdls = @(
		$someString
	)
	# OPTIONAL
	workload = $someWorkloadLevelHierarchy # Call [Enum]::GetValues([RubrikSecurityCloud.Types.WorkloadLevelHierarchy]) for enum values.
	# OPTIONAL
	groupFilterAttributes = @(
		@{
			# OPTIONAL
			filterOpType = $someJoinOpType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.JoinOpType]) for enum values.
			# OPTIONAL
			attributeType = $someAttributeType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AttributeType]) for enum values.
			# OPTIONAL
			attributeKey = $someString
			# OPTIONAL
			attributeValue = $someString
			# OPTIONAL
			dataType = $someAttributeDataType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AttributeDataType]) for enum values.
		}
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // addCustomIntelFeed(input: AddCustomIntelFeedInput!): AddCustomIntelFeedReply!
        internal void InitMutationAddCustomIntelFeed()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "AddCustomIntelFeedInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationAddCustomIntelFeed",
                "($input: AddCustomIntelFeedInput!)",
                "AddCustomIntelFeedReply",
                Mutation.AddCustomIntelFeed,
                Mutation.AddCustomIntelFeedFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	name = $someString
	# OPTIONAL
	description = $someString
	# OPTIONAL
	userId = $someString
	# REQUIRED
	entries = @(
		@{
			# OPTIONAL
			iocString = $someString
			# OPTIONAL
			threatFamily = $someString
			# REQUIRED
			iocType = $someThreatFeedType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ThreatFeedType]) for enum values.
		}
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // addInventoryWorkloads(input: AddInventoryWorkloadsInput!): Boolean!
        internal void InitMutationAddInventoryWorkloads()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "AddInventoryWorkloadsInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationAddInventoryWorkloads",
                "($input: AddInventoryWorkloadsInput!)",
                "System.Boolean",
                Mutation.AddInventoryWorkloads,
                Mutation.AddInventoryWorkloadsFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	inventoryCards = @(
		$someInventoryCard # Call [Enum]::GetValues([RubrikSecurityCloud.Types.InventoryCard]) for enum values.
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // addRoleAssignments(userIds: [String!], groupIds: [String!], roleIds: [String!]!): Boolean!
        internal void InitMutationAddRoleAssignments()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("userIds", "[String!]"),
                Tuple.Create("groupIds", "[String!]"),
                Tuple.Create("roleIds", "[String!]!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationAddRoleAssignments",
                "($userIds: [String!],$groupIds: [String!],$roleIds: [String!]!)",
                "System.Boolean",
                Mutation.AddRoleAssignments,
                Mutation.AddRoleAssignmentsFieldSpec,
                @"# OPTIONAL
$query.Var.userIds = @(
	$someString
)
# OPTIONAL
$query.Var.groupIds = @(
	$someString
)
# REQUIRED
$query.Var.roleIds = @(
	$someString
)"
            );
        }

        // Create new GraphQL Mutation:
        // addSaasAppRecoveryOrg(input: AddRecoveryOrgInput!): AddRecoveryOrgReply!
        internal void InitMutationAddSaasAppRecoveryOrg()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "AddRecoveryOrgInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationAddSaasAppRecoveryOrg",
                "($input: AddRecoveryOrgInput!)",
                "AddRecoveryOrgReply",
                Mutation.AddSaasAppRecoveryOrg,
                Mutation.AddSaasAppRecoveryOrgFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	orgName = $someString
	# REQUIRED
	orgNaturalId = $someString
	# REQUIRED
	environmentType = $someSaasEnvironmentType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SaasEnvironmentType]) for enum values.
	# REQUIRED
	saasAppType = $someSaasAppType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SaasAppType]) for enum values.
}"
            );
        }

        // Create new GraphQL Mutation:
        // addVcdInstances(input: AddVcdInstancesInput!): AddVcdInstancesReply!
        internal void InitMutationAddVcdInstances()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "AddVcdInstancesInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationAddVcdInstances",
                "($input: AddVcdInstancesInput!)",
                "AddVcdInstancesReply",
                Mutation.AddVcdInstances,
                Mutation.AddVcdInstancesFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	vcdConfigs = @(
		@{
			# REQUIRED
			clusterUuid = $someString
			# REQUIRED
			definition = @{
				# REQUIRED
				password = $someString
				# OPTIONAL
				vcdClusterBaseConfig = @{
					# OPTIONAL
					caCerts = $someString
					# REQUIRED
					hostname = $someString
					# REQUIRED
					username = $someString
				}
			}
		}
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // addVlan(input: AddVlanInput!): ResponseSuccess!
        internal void InitMutationAddVlan()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "AddVlanInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationAddVlan",
                "($input: AddVlanInput!)",
                "ResponseSuccess",
                Mutation.AddVlan,
                Mutation.AddVlanFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someString
	# REQUIRED
	vlanInfo = @{
		# OPTIONAL
		gateway = $someString
		# OPTIONAL
		alias = $someString
		# REQUIRED
		interfaces = @(
			@{
				# REQUIRED
				ip = $someString
				# REQUIRED
				node = $someString
			}
		)
		# REQUIRED
		netmask = $someString
		# REQUIRED
		vlan = $someInt
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // addVmAppConsistentSpecs(input: AddVmAppConsistentSpecsInput!): AddVmAppConsistentSpecsReply!
        internal void InitMutationAddVmAppConsistentSpecs()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "AddVmAppConsistentSpecsInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationAddVmAppConsistentSpecs",
                "($input: AddVmAppConsistentSpecsInput!)",
                "AddVmAppConsistentSpecsReply",
                Mutation.AddVmAppConsistentSpecs,
                Mutation.AddVmAppConsistentSpecsFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	snappableIds = @(
		$someString
	)
	# OPTIONAL
	preSnapshotScriptPath = $someString
	# OPTIONAL
	preSnapshotScriptTimeoutInSeconds = $someInt
	# OPTIONAL
	postSnapshotScriptPath = $someString
	# OPTIONAL
	postSnapshotScriptTimeoutInSeconds = $someInt
	# REQUIRED
	cancelBackupIfPreScriptFails = $someBoolean
	# REQUIRED
	objectType = $someCloudNativeVmAppConsistentObjectType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudNativeVmAppConsistentObjectType]) for enum values.
}"
            );
        }

        // Create new GraphQL Mutation:
        // airGapStatus(input: AirGapStatusInput!): Void
        internal void InitMutationAirGapStatus()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "AirGapStatusInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationAirGapStatus",
                "($input: AirGapStatusInput!)",
                "System.String",
                Mutation.AirGapStatus,
                Mutation.AirGapStatusFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	isAirGapped = $someBoolean
	# REQUIRED
	clusterUuid = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // approveTprRequest(input: ApproveTprRequestInput!): Void
        internal void InitMutationApproveTprRequest()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "ApproveTprRequestInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationApproveTprRequest",
                "($input: ApproveTprRequestInput!)",
                "System.String",
                Mutation.ApproveTprRequest,
                Mutation.ApproveTprRequestFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	requestId = $someString
	# OPTIONAL
	comment = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // archiveCrawl(crawlId: String!): String!
        internal void InitMutationArchiveCrawl()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("crawlId", "String!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationArchiveCrawl",
                "($crawlId: String!)",
                "System.String",
                Mutation.ArchiveCrawl,
                Mutation.ArchiveCrawlFieldSpec,
                @"# REQUIRED
$query.Var.crawlId = $someString"
            );
        }

        // Create new GraphQL Mutation:
        // assignProtection(input: AssignProtectionInput!): SlaAssignResult!
        internal void InitMutationAssignProtection()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "AssignProtectionInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationAssignProtection",
                "($input: AssignProtectionInput!)",
                "SlaAssignResult",
                Mutation.AssignProtection,
                Mutation.AssignProtectionFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	globalSlaOptionalFid = $someString
	# REQUIRED
	globalSlaAssignType = $someSlaAssignTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SlaAssignTypeEnum]) for enum values.
	# REQUIRED
	objectIds = @(
		$someString
	)
	# REQUIRED
	backupInput = @{
		# OPTIONAL
		mosaicBackupStoreInfo = @{
			# OPTIONAL
			storeName = $someString
		}
		# OPTIONAL
		mosaicMonitorInfo = @{
			# OPTIONAL
			isEnabled = $someBoolean
			# OPTIONAL
			frequency = $someInt
			# OPTIONAL
			frequencyUnit = $someRetentionUnit # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
		}
		# OPTIONAL
		shouldBackupIndex = $someBoolean
		# OPTIONAL
		shouldDelete = $someBoolean
		# OPTIONAL
		shouldDeleteData = $someBoolean
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // batchDeassignRoleFromUserGroups(userGroupToRoles: [UserGroupToRolesInput!]!): Boolean!
        internal void InitMutationBatchDeassignRoleFromUserGroups()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("userGroupToRoles", "[UserGroupToRolesInput!]!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationBatchDeassignRoleFromUserGroups",
                "($userGroupToRoles: [UserGroupToRolesInput!]!)",
                "System.Boolean",
                Mutation.BatchDeassignRoleFromUserGroups,
                Mutation.BatchDeassignRoleFromUserGroupsFieldSpec,
                @"# REQUIRED
$query.Var.userGroupToRoles = @(
	@{
		# OPTIONAL
		userGroupId = $someString
		# OPTIONAL
		roleIds = @(
			$someString
		)
}
)"
            );
        }

        // Create new GraphQL Mutation:
        // batchRefreshDomains(domainFids: [String!]!): BatchAsyncRequestStatus!
        internal void InitMutationBatchRefreshDomains()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("domainFids", "[String!]!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationBatchRefreshDomains",
                "($domainFids: [String!]!)",
                "BatchAsyncRequestStatus",
                Mutation.BatchRefreshDomains,
                Mutation.BatchRefreshDomainsFieldSpec,
                @"# REQUIRED
$query.Var.domainFids = @(
	$someString
)"
            );
        }

        // Create new GraphQL Mutation:
        // bulkAddKmipServer(input: BulkAddKmipServerInput!): BulkAddKmipServerReply!
        internal void InitMutationBulkAddKmipServer()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "BulkAddKmipServerInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationBulkAddKmipServer",
                "($input: BulkAddKmipServerInput!)",
                "BulkAddKmipServerReply",
                Mutation.BulkAddKmipServer,
                Mutation.BulkAddKmipServerFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	clusterIds = @(
		$someString
	)
	# REQUIRED
	serverAddress = $someString
	# REQUIRED
	port = $someInt
	# REQUIRED
	polarisCertId = $someInt
	# OPTIONAL
	polarisCertFid = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // bulkCancelFailovers(cancelFailoversConfig: BulkCancelFailoversInput!): Void
        internal void InitMutationBulkCancelFailovers()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("cancelFailoversConfig", "BulkCancelFailoversInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationBulkCancelFailovers",
                "($cancelFailoversConfig: BulkCancelFailoversInput!)",
                "System.String",
                Mutation.BulkCancelFailovers,
                Mutation.BulkCancelFailoversFieldSpec,
                @"# REQUIRED
$query.Var.cancelFailoversConfig = @{
	# REQUIRED
	fids = @(
		$someString
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // bulkCreateNasFilesets(input: BulkCreateNasFilesetsInput!): BulkCreateNasFilesetsReply!
        internal void InitMutationBulkCreateNasFilesets()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "BulkCreateNasFilesetsInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationBulkCreateNasFilesets",
                "($input: BulkCreateNasFilesetsInput!)",
                "BulkCreateNasFilesetsReply",
                Mutation.BulkCreateNasFilesets,
                Mutation.BulkCreateNasFilesetsFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	bulkRequest = @{
		# OPTIONAL
		isHardlinkSupportEnabled = $someBoolean
		# OPTIONAL
		isPassthrough = $someBoolean
		# REQUIRED
		filesetTemplate = @{
			# OPTIONAL
			backupScriptErrorHandling = $someString
			# OPTIONAL
			backupScriptTimeout = $someInt64
			# OPTIONAL
			exceptions = @(
				$someString
			)
			# OPTIONAL
			excludes = @(
				$someString
			)
			# OPTIONAL
			isArrayEnabled = $someBoolean
			# OPTIONAL
			postBackupScript = $someString
			# OPTIONAL
			preBackupScript = $someString
			# OPTIONAL
			isCreatedByKupr = $someBoolean
			# OPTIONAL
			isCreatedByPolarisNas = $someBoolean
			# OPTIONAL
			operatingSystemType = $someFilesetTemplateCreateOperatingSystemType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.FilesetTemplateCreateOperatingSystemType]) for enum values.
			# OPTIONAL
			shareType = $someFilesetTemplateCreateShareType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.FilesetTemplateCreateShareType]) for enum values.
			# OPTIONAL
			filesetOptions = @{
				# OPTIONAL
				allowBackupHiddenFoldersInNetworkMounts = $someBoolean
				# OPTIONAL
				allowBackupNetworkMounts = $someBoolean
				# OPTIONAL
				useWindowsVss = $someBoolean
			}
			# REQUIRED
			includes = @(
				$someString
			)
			# REQUIRED
			name = $someString
		}
		# REQUIRED
		nasShareIds = @(
			$someString
		)
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // bulkUpdateSnapMirrorCloud(input: BulkUpdateSnapMirrorCloudInput!): BulkUpdateSnapMirrorCloudReply!
        internal void InitMutationBulkUpdateSnapMirrorCloud()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "BulkUpdateSnapMirrorCloudInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationBulkUpdateSnapMirrorCloud",
                "($input: BulkUpdateSnapMirrorCloudInput!)",
                "BulkUpdateSnapMirrorCloudReply",
                Mutation.BulkUpdateSnapMirrorCloud,
                Mutation.BulkUpdateSnapMirrorCloudFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	updateDefinitions = @(
		@{
			# REQUIRED
			snapMirrorCloudId = $someString
			# REQUIRED
			snapMirrorLabel = $someString
		}
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // cancelBlueprintFailover(taskchainId: UUID!): Result!
        internal void InitMutationCancelBlueprintFailover()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("taskchainId", "UUID!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCancelBlueprintFailover",
                "($taskchainId: UUID!)",
                "Result",
                Mutation.CancelBlueprintFailover,
                Mutation.CancelBlueprintFailoverFieldSpec,
                @"# REQUIRED
$query.Var.taskchainId = $someString"
            );
        }

        // Create new GraphQL Mutation:
        // cancelBulkRecovery(input: CancelBulkRecoveryInput!): CancelBulkRecoveryReply!
        internal void InitMutationCancelBulkRecovery()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CancelBulkRecoveryInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCancelBulkRecovery",
                "($input: CancelBulkRecoveryInput!)",
                "CancelBulkRecoveryReply",
                Mutation.CancelBulkRecovery,
                Mutation.CancelBulkRecoveryFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	bulkRecoveryInstanceId = $someString
	# OPTIONAL
	subscriptionId = $someString
	# OPTIONAL
	groupId = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // cancelDownloadPackage(clusterUuid: UUID!): CancelJobReply!
        internal void InitMutationCancelDownloadPackage()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("clusterUuid", "UUID!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCancelDownloadPackage",
                "($clusterUuid: UUID!)",
                "CancelJobReply",
                Mutation.CancelDownloadPackage,
                Mutation.CancelDownloadPackageFieldSpec,
                @"# REQUIRED
$query.Var.clusterUuid = $someString"
            );
        }

        // Create new GraphQL Mutation:
        // cancelJobInstance(input: CancelJobInstanceInput!): InternalJobInstanceDetail!
        internal void InitMutationCancelJobInstance()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CancelJobInstanceInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCancelJobInstance",
                "($input: CancelJobInstanceInput!)",
                "InternalJobInstanceDetail",
                Mutation.CancelJobInstance,
                Mutation.CancelJobInstanceFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	clusterUuid = $someString
	# REQUIRED
	id = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // cancelScheduledUpgrade(clusterUuid: UUID!): CancelJobReply!
        internal void InitMutationCancelScheduledUpgrade()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("clusterUuid", "UUID!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCancelScheduledUpgrade",
                "($clusterUuid: UUID!)",
                "CancelJobReply",
                Mutation.CancelScheduledUpgrade,
                Mutation.CancelScheduledUpgradeFieldSpec,
                @"# REQUIRED
$query.Var.clusterUuid = $someString"
            );
        }

        // Create new GraphQL Mutation:
        // cancelTaskchain(taskchainId: String!): RequestStatus!
        internal void InitMutationCancelTaskchain()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("taskchainId", "String!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCancelTaskchain",
                "($taskchainId: String!)",
                "RequestStatus",
                Mutation.CancelTaskchain,
                Mutation.CancelTaskchainFieldSpec,
                @"# REQUIRED
$query.Var.taskchainId = $someString"
            );
        }

        // Create new GraphQL Mutation:
        // cancelTprRequest(input: CancelTprRequestInput!): Void
        internal void InitMutationCancelTprRequest()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CancelTprRequestInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCancelTprRequest",
                "($input: CancelTprRequestInput!)",
                "System.String",
                Mutation.CancelTprRequest,
                Mutation.CancelTprRequestFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	requestIds = @(
		$someString
	)
	# OPTIONAL
	comment = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // changePassword(input: ChangePasswordInput!): Boolean!
        internal void InitMutationChangePassword()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "ChangePasswordInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationChangePassword",
                "($input: ChangePasswordInput!)",
                "System.Boolean",
                Mutation.ChangePassword,
                Mutation.ChangePasswordFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	email = $someString
	# OPTIONAL
	password = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // checkStatus(input: CheckStatusInput!): BatchAsyncJobStatus!
        internal void InitMutationCheckStatus()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CheckStatusInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCheckStatus",
                "($input: CheckStatusInput!)",
                "BatchAsyncJobStatus",
                Mutation.CheckStatus,
                Mutation.CheckStatusFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	clusterUuid = $someString
	# OPTIONAL
	shouldSwitchMode = $someBoolean
	# OPTIONAL
	shouldRunOnlyRSCModeTasks = $someBoolean
	# OPTIONAL
	clusterMigrationMode = $someClusterMigrationModes # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ClusterMigrationModes]) for enum values.
}"
            );
        }

        // Create new GraphQL Mutation:
        // cleanupBlueprintFailover(cleanupJobconfig: CleanupFailoverJobInfo!): CreateOnDemandJobReply!
        internal void InitMutationCleanupBlueprintFailover()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("cleanupJobconfig", "CleanupFailoverJobInfo!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCleanupBlueprintFailover",
                "($cleanupJobconfig: CleanupFailoverJobInfo!)",
                "CreateOnDemandJobReply",
                Mutation.CleanupBlueprintFailover,
                Mutation.CleanupBlueprintFailoverFieldSpec,
                @"# REQUIRED
$query.Var.cleanupJobconfig = @{
	# REQUIRED
	blueprintId = $someString
	# OPTIONAL
	comments = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // cleanupIsolatedRecoveries(cleanupIsolatedRecoveriesJobInputConfig: [CleanupIsolatedRecoveryJobInfo!]!): [CreateOnDemandJobReply!]!
        internal void InitMutationCleanupIsolatedRecoveries()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("cleanupIsolatedRecoveriesJobInputConfig", "[CleanupIsolatedRecoveryJobInfo!]!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCleanupIsolatedRecoveries",
                "($cleanupIsolatedRecoveriesJobInputConfig: [CleanupIsolatedRecoveryJobInfo!]!)",
                "List<CreateOnDemandJobReply>",
                Mutation.CleanupIsolatedRecoveries,
                Mutation.CleanupIsolatedRecoveriesFieldSpec,
                @"# REQUIRED
$query.Var.cleanupIsolatedRecoveriesJobInputConfig = @(
	@{
		# REQUIRED
		blueprintId = $someString
		# REQUIRED
		failoverId = $someString
		# OPTIONAL
		comments = $someString
}
)"
            );
        }

        // Create new GraphQL Mutation:
        // cleanupIsolatedRecovery(cleanupIsolatedRecoveryJobconfig: CleanupIsolatedRecoveryJobInfo!): CreateOnDemandJobReply!
        internal void InitMutationCleanupIsolatedRecovery()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("cleanupIsolatedRecoveryJobconfig", "CleanupIsolatedRecoveryJobInfo!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCleanupIsolatedRecovery",
                "($cleanupIsolatedRecoveryJobconfig: CleanupIsolatedRecoveryJobInfo!)",
                "CreateOnDemandJobReply",
                Mutation.CleanupIsolatedRecovery,
                Mutation.CleanupIsolatedRecoveryFieldSpec,
                @"# REQUIRED
$query.Var.cleanupIsolatedRecoveryJobconfig = @{
	# REQUIRED
	blueprintId = $someString
	# REQUIRED
	failoverId = $someString
	# OPTIONAL
	comments = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // completeOperationalRecovery(input: CompleteOperationalRecoveryInput!): StartBulkRecoveryV2Reply!
        internal void InitMutationCompleteOperationalRecovery()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CompleteOperationalRecoveryInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCompleteOperationalRecovery",
                "($input: CompleteOperationalRecoveryInput!)",
                "StartBulkRecoveryV2Reply",
                Mutation.CompleteOperationalRecovery,
                Mutation.CompleteOperationalRecoveryFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	bulkRecoveryInstanceId = $someString
	# OPTIONAL
	bulkRecoveryTaskchainId = $someString
	# REQUIRED
	subscriptionId = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // completeSaasAppAuthConsent(input: CompleteSaasAppAuthConsentInput!): CompleteSaasAppAuthConsentReply!
        internal void InitMutationCompleteSaasAppAuthConsent()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CompleteSaasAppAuthConsentInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCompleteSaasAppAuthConsent",
                "($input: CompleteSaasAppAuthConsentInput!)",
                "CompleteSaasAppAuthConsentReply",
                Mutation.CompleteSaasAppAuthConsent,
                Mutation.CompleteSaasAppAuthConsentFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	sessionId = $someString
	# REQUIRED
	state = $someString
	# REQUIRED
	authorizationCode = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // completeTrialOnboarding(input: CompleteTrialOnboardingInput!): Void
        internal void InitMutationCompleteTrialOnboarding()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CompleteTrialOnboardingInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCompleteTrialOnboarding",
                "($input: CompleteTrialOnboardingInput!)",
                "System.String",
                Mutation.CompleteTrialOnboarding,
                Mutation.CompleteTrialOnboardingFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	trialId = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // completeTrialTask(input: CompleteTrialTaskInput!): Void
        internal void InitMutationCompleteTrialTask()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CompleteTrialTaskInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCompleteTrialTask",
                "($input: CompleteTrialTaskInput!)",
                "System.String",
                Mutation.CompleteTrialTask,
                Mutation.CompleteTrialTaskFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	trialId = $someString
	# REQUIRED
	step = $someTrialStep # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TrialStep]) for enum values.
}"
            );
        }

        // Create new GraphQL Mutation:
        // computeBucketImmutabilityLockDuration(input: ComputeBucketImmutabilityLockDurationInput!): ComputeBucketImmutabilityLockDurationReply!
        internal void InitMutationComputeBucketImmutabilityLockDuration()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "ComputeBucketImmutabilityLockDurationInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationComputeBucketImmutabilityLockDuration",
                "($input: ComputeBucketImmutabilityLockDurationInput!)",
                "ComputeBucketImmutabilityLockDurationReply",
                Mutation.ComputeBucketImmutabilityLockDuration,
                Mutation.ComputeBucketImmutabilityLockDurationFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	archivalRetentionDays = $someInt
	# REQUIRED
	slaFrequencyUnit = $someRetentionUnit # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
}"
            );
        }

        // Create new GraphQL Mutation:
        // configureDns(dnsAddresses: [String!]!): Boolean!
        internal void InitMutationConfigureDns()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("dnsAddresses", "[String!]!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationConfigureDns",
                "($dnsAddresses: [String!]!)",
                "System.Boolean",
                Mutation.ConfigureDns,
                Mutation.ConfigureDnsFieldSpec,
                @"# REQUIRED
$query.Var.dnsAddresses = @(
	$someString
)"
            );
        }

        // Create new GraphQL Mutation:
        // configureLogExport(input: ConfigureLogExportInput!): AsyncRequestStatus!
        internal void InitMutationConfigureLogExport()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "ConfigureLogExportInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationConfigureLogExport",
                "($input: ConfigureLogExportInput!)",
                "AsyncRequestStatus",
                Mutation.ConfigureLogExport,
                Mutation.ConfigureLogExportFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someString
	# REQUIRED
	shouldEnableLogExport = $someBoolean
}"
            );
        }

        // Create new GraphQL Mutation:
        // configureNtp(ntpAddresses: [String!]!): Boolean!
        internal void InitMutationConfigureNtp()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("ntpAddresses", "[String!]!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationConfigureNtp",
                "($ntpAddresses: [String!]!)",
                "System.Boolean",
                Mutation.ConfigureNtp,
                Mutation.ConfigureNtpFieldSpec,
                @"# REQUIRED
$query.Var.ntpAddresses = @(
	$someString
)"
            );
        }

        // Create new GraphQL Mutation:
        // configureTicketingPlatformWithOAuth(input: ConfigureTicketingPlatformWithOAuthInput!): Void
        internal void InitMutationConfigureTicketingPlatformWithOauth()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "ConfigureTicketingPlatformWithOAuthInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationConfigureTicketingPlatformWithOauth",
                "($input: ConfigureTicketingPlatformWithOAuthInput!)",
                "System.String",
                Mutation.ConfigureTicketingPlatformWithOauth,
                Mutation.ConfigureTicketingPlatformWithOauthFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	platformConfig = @{
		# REQUIRED
		platformType = $someTicketingPlatform # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TicketingPlatform]) for enum values.
		# REQUIRED
		instanceUrl = $someString
	}
	# REQUIRED
	oauthConfig = @{
		# REQUIRED
		username = $someString
		# REQUIRED
		password = $someString
		# REQUIRED
		clientId = $someString
		# REQUIRED
		clientSecret = $someString
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // createBlueprint(
        //     name: String!
        //     children: [AppBlueprintChildInput!]!
        //     sourceLocationId: String!
        //     sourceLocationType: BlueprintLocationType! = CDM
        //     targetLocationType: BlueprintLocationType = CDM
        //     targetLocationId: String
        //     status: BlueprintStatus! = INCOMPLETE
        //     enableHydration: Boolean
        //     timeoutBetweenPriorityGroups: [Long!]
        //     blueprintRecoveryType: BlueprintRecoveryType
        //     isBlueprintVisible: Boolean! = true
        //   ): BlueprintNew!
        internal void InitMutationCreateBlueprint()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("name", "String!"),
                Tuple.Create("children", "[AppBlueprintChildInput!]!"),
                Tuple.Create("sourceLocationId", "String!"),
                Tuple.Create("sourceLocationType", "BlueprintLocationType!"),
                Tuple.Create("targetLocationType", "BlueprintLocationType"),
                Tuple.Create("targetLocationId", "String"),
                Tuple.Create("status", "BlueprintStatus!"),
                Tuple.Create("enableHydration", "Boolean"),
                Tuple.Create("timeoutBetweenPriorityGroups", "[Long!]"),
                Tuple.Create("blueprintRecoveryType", "BlueprintRecoveryType"),
                Tuple.Create("isBlueprintVisible", "Boolean!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateBlueprint",
                "($name: String!,$children: [AppBlueprintChildInput!]!,$sourceLocationId: String!,$sourceLocationType: BlueprintLocationType!,$targetLocationType: BlueprintLocationType,$targetLocationId: String,$status: BlueprintStatus!,$enableHydration: Boolean,$timeoutBetweenPriorityGroups: [Long!],$blueprintRecoveryType: BlueprintRecoveryType,$isBlueprintVisible: Boolean!)",
                "BlueprintNew",
                Mutation.CreateBlueprint,
                Mutation.CreateBlueprintFieldSpec,
                @"# REQUIRED
$query.Var.name = $someString
# REQUIRED
$query.Var.children = @(
	@{
		# REQUIRED
		fid = $someString
		# REQUIRED
		snappableType = $someObjectTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ObjectTypeEnum]) for enum values.
		# REQUIRED
		bootPriority = $someInt
		# OPTIONAL
		lastRecoveryPoint = $someInt64
}
)
# REQUIRED
$query.Var.sourceLocationId = $someString
# REQUIRED
$query.Var.sourceLocationType = $someBlueprintLocationType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.BlueprintLocationType]) for enum values.
# OPTIONAL
$query.Var.targetLocationType = $someBlueprintLocationType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.BlueprintLocationType]) for enum values.
# OPTIONAL
$query.Var.targetLocationId = $someString
# REQUIRED
$query.Var.status = $someBlueprintStatus # Call [Enum]::GetValues([RubrikSecurityCloud.Types.BlueprintStatus]) for enum values.
# OPTIONAL
$query.Var.enableHydration = $someBoolean
# OPTIONAL
$query.Var.timeoutBetweenPriorityGroups = @(
	$someInt64
)
# OPTIONAL
$query.Var.blueprintRecoveryType = $someBlueprintRecoveryType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.BlueprintRecoveryType]) for enum values.
# REQUIRED
$query.Var.isBlueprintVisible = $someBoolean"
            );
        }

        // Create new GraphQL Mutation:
        // createBlueprintRecoverySpec(
        //     blueprintId: UUID!
        //     specType: RecoverySpecType!
        //     recoveryConfigs: [AppBlueprintRecoverySpecCreateReqInputType!]!
        //     isDefaultRecoverySpec: Boolean
        //   ): [BlueprintRecoverySpec!]!
        internal void InitMutationCreateBlueprintRecoverySpec()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("blueprintId", "UUID!"),
                Tuple.Create("specType", "RecoverySpecType!"),
                Tuple.Create("recoveryConfigs", "[AppBlueprintRecoverySpecCreateReqInputType!]!"),
                Tuple.Create("isDefaultRecoverySpec", "Boolean"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateBlueprintRecoverySpec",
                "($blueprintId: UUID!,$specType: RecoverySpecType!,$recoveryConfigs: [AppBlueprintRecoverySpecCreateReqInputType!]!,$isDefaultRecoverySpec: Boolean)",
                "List<BlueprintRecoverySpec>",
                Mutation.CreateBlueprintRecoverySpec,
                Mutation.CreateBlueprintRecoverySpecFieldSpec,
                @"# REQUIRED
$query.Var.blueprintId = $someString
# REQUIRED
$query.Var.specType = $someRecoverySpecType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RecoverySpecType]) for enum values.
# REQUIRED
$query.Var.recoveryConfigs = @(
	@{
		# REQUIRED
		planType = $somePlanName # Call [Enum]::GetValues([RubrikSecurityCloud.Types.PlanName]) for enum values.
		# OPTIONAL
		locationInfo = @{
			# OPTIONAL
			locationId = $someString
			# OPTIONAL
			locationType = $someLocationType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.LocationType]) for enum values.
		}
		# OPTIONAL
		userData = $someString
		# REQUIRED
		childRecoverySpecs = @(
			@{
				# REQUIRED
				snappableId = $someString
				# OPTIONAL
				slaId = $someString
				# OPTIONAL
				recoveryPoint = $someInt64
				# REQUIRED
				recoverySpec = @{
					# OPTIONAL
					awsSpec = @{
						# REQUIRED
						instanceTypeId = $someInt
						# OPTIONAL
						instanceTypeName = $someString
						# OPTIONAL
						hostAffinity = $someString
						# OPTIONAL
						availabilityZone = $someString
						# OPTIONAL
						dedicatedHostId = $someString
						# OPTIONAL
						placementGroup = $someString
						# OPTIONAL
						tenancy = $someAwsInstanceTenancy # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsInstanceTenancy]) for enum values.
						# OPTIONAL
						keyName = $someString
						# OPTIONAL
						volumes = @(
							@{
								# OPTIONAL
								key = $someInt
								# OPTIONAL
								volumeTypeId = $someInt
								# OPTIONAL
								sizeGbs = $someInt
								# OPTIONAL
								iops = $someInt
							}
						)
						# OPTIONAL
						nics = @(
							@{
								# OPTIONAL
								key = $someInt
								# OPTIONAL
								ipv4Address = $someString
								# OPTIONAL
								subnetId = $someString
								# OPTIONAL
								awsSubnetId = $someString
								# OPTIONAL
								securityGroupId = $someString
								# OPTIONAL
								awsSecurityGroupId = $someString
							}
						)
						# OPTIONAL
						version = $someInt64
						# OPTIONAL
						userData = $someString
					}
					# OPTIONAL
					vSphereSpec = @{
						# OPTIONAL
						vcpus = $someInt
						# OPTIONAL
						memoryMbs = $someInt
						# OPTIONAL
						volumes = @(
							@{
								# OPTIONAL
								key = $someString
								# OPTIONAL
								dataStoreId = $someString
								# OPTIONAL
								sizeGbs = $someSingle
								# OPTIONAL
								dataStoreCdmId = $someString
								# OPTIONAL
								datastoreClusterId = $someString
								# OPTIONAL
								label = $someString
							}
						)
						# OPTIONAL
						nics = @(
							@{
								# OPTIONAL
								key = $someString
								# OPTIONAL
								isPrimaryNic = $someBoolean
								# OPTIONAL
								networkType = $someNetworkType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.NetworkType]) for enum values.
								# OPTIONAL
								networkId = $someString
								# OPTIONAL
								networkMoid = $someString
								# OPTIONAL
								adapterType = $someNetworkAdapterType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.NetworkAdapterType]) for enum values.
								# OPTIONAL
								ipv4Address = $someString
								# OPTIONAL
								ipv6Address = $someString
								# OPTIONAL
								dnsInfos = @(
									$someString
								)
								# OPTIONAL
								gateway = $someString
								# OPTIONAL
								netmask = $someString
							}
						)
						# OPTIONAL
						version = $someInt64
						# OPTIONAL
						userData = $someString
						# OPTIONAL
						target = @{
							# OPTIONAL
							vcenterId = $someString
							# OPTIONAL
							vcenterName = $someString
							# OPTIONAL
							vcenterCdmId = $someString
							# OPTIONAL
							computeClusterId = $someString
							# OPTIONAL
							computeClusterCdmId = $someString
							# OPTIONAL
							computeClusterName = $someString
							# OPTIONAL
							resourcePoolId = $someString
							# OPTIONAL
							resourcePoolCdmId = $someString
							# OPTIONAL
							resourcePoolName = $someString
							# OPTIONAL
							hostId = $someString
							# OPTIONAL
							hostName = $someString
							# OPTIONAL
							hostCdmId = $someString
							# OPTIONAL
							datacenterId = $someString
							# OPTIONAL
							datacenterCdmId = $someString
							# OPTIONAL
							datacenterName = $someString
						}
						# OPTIONAL
						enableNetworkPreserve = $someBoolean
						# OPTIONAL
						enableMacPreserveOnly = $someBoolean
						# OPTIONAL
						email = $someString
						# OPTIONAL
						postScriptTimestamp = $someString
						# OPTIONAL
						postScriptHash = $someString
						# OPTIONAL
						enableNetworkDisconnect = $someBoolean
					}
					# OPTIONAL
					nutanixSpec = @{
						# OPTIONAL
						vCpus = $someInt64
						# OPTIONAL
						memoryMbs = $someInt64
						# OPTIONAL
						clusterId = $someString
						# OPTIONAL
						version = $someInt64
						# OPTIONAL
						removeAllNetwork = $someBoolean
						# OPTIONAL
						preserveMacAddress = $someBoolean
						# OPTIONAL
						volumes = @(
							@{
								# OPTIONAL
								storageContainerId = $someString
								# OPTIONAL
								storageContainerName = $someString
							}
						)
						# OPTIONAL
						nics = @(
							@{
								# OPTIONAL
								key = $someString
								# OPTIONAL
								networkName = $someString
							}
						)
						# OPTIONAL
						target = @{
							# OPTIONAL
							clusterId = $someString
							# OPTIONAL
							clusterName = $someString
							# OPTIONAL
							clusterHostname = $someString
							# OPTIONAL
							prismCentral = $someString
						}
					}
				}
			}
		)
		# OPTIONAL
		resourceSpecType = $someResourceSpecType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ResourceSpecType]) for enum values.
		# OPTIONAL
		failoverId = $someString
}
)
# OPTIONAL
$query.Var.isDefaultRecoverySpec = $someBoolean"
            );
        }

        // Create new GraphQL Mutation:
        // createChat(input: CreateChatInput!): CreateChatReply!
        internal void InitMutationCreateChat()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateChatInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateChat",
                "($input: CreateChatInput!)",
                "CreateChatReply",
                Mutation.CreateChat,
                Mutation.CreateChatFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	chatUsage = $someChatUsage # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ChatUsage]) for enum values.
	# OPTIONAL
	chatrockInput = @{
		# REQUIRED
		matchId = $someString
	}
	# OPTIONAL
	helpcenterInput = @{
		# REQUIRED
		query = $someString
		# REQUIRED
		response = $someString
		# OPTIONAL
		references = @(
			$someString
		)
	}
	# OPTIONAL
	dataChatInput = @{
		# REQUIRED
		chatbotId = $someString
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // createChatbot(input: CreateChatbotInput!): CreateChatbotReply!
        internal void InitMutationCreateChatbot()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateChatbotInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateChatbot",
                "($input: CreateChatbotInput!)",
                "CreateChatbotReply",
                Mutation.CreateChatbot,
                Mutation.CreateChatbotFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	name = $someString
	# OPTIONAL
	description = $someString
	# OPTIONAL
	filters = @{
		# OPTIONAL
		modifiedTimeRange = @{
			# OPTIONAL
			startTime = $someInt64
			# OPTIONAL
			endTime = $someInt64
		}
		# REQUIRED
		sensitiveDataPolicyIds = @(
			$someString
		)
		# REQUIRED
		extensionWhitelist = @(
			$someString
		)
	}
	# OPTIONAL
	userAssignment = @{
		# OPTIONAL
		roleName = $someString
		# OPTIONAL
		roleDescription = $someString
		# REQUIRED
		userIds = @(
			$someString
		)
		# REQUIRED
		userGroupIds = @(
			$someString
		)
	}
	# OPTIONAL
	chatbotSettings = @{
		# OPTIONAL
		enableDocLevelAccessControl = $someBoolean
		# OPTIONAL
		systemMessage = $someString
		# OPTIONAL
		numChunksToRetrieve = $someInt
	}
	# OPTIONAL
	embeddingFactorySettings = @{
		# OPTIONAL
		chunkerConfig = @{
			# REQUIRED
			variant = @{
				# OPTIONAL
				recursiveCharacterChunkerConfig = @{
					# OPTIONAL
					chunkSize = $someInt
					# OPTIONAL
					chunkOverlap = $someInt
					# OPTIONAL
					separators = @(
						$someString
					)
				}
			}
		}
	}
	# REQUIRED
	objects = @(
		@{
			# OPTIONAL
			workloadType = $someManagedObjectType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ManagedObjectType]) for enum values.
			# OPTIONAL
			pathFilter = @{
				# REQUIRED
				prefixInclusions = @(
					$someString
				)
			}
			# REQUIRED
			id = $someString
		}
	)
	# REQUIRED
	roleIds = @(
		$someString
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // createConfigProtectionBackup(input: ConfigProtectionBackupInput!): BatchAsyncJobStatus!
        internal void InitMutationCreateConfigProtectionBackup()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "ConfigProtectionBackupInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateConfigProtectionBackup",
                "($input: ConfigProtectionBackupInput!)",
                "BatchAsyncJobStatus",
                Mutation.CreateConfigProtectionBackup,
                Mutation.CreateConfigProtectionBackupFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	clusterUuids = @(
		$someString
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // createConfigProtectionSetup(input: CreateConfigProtectionSetupInput!): AsyncJobStatus!
        internal void InitMutationCreateConfigProtectionSetup()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateConfigProtectionSetupInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateConfigProtectionSetup",
                "($input: CreateConfigProtectionSetupInput!)",
                "AsyncJobStatus",
                Mutation.CreateConfigProtectionSetup,
                Mutation.CreateConfigProtectionSetupFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	clusterUuid = $someString
	# REQUIRED
	encryptionPassword = $someString
	# OPTIONAL
	caCertificate = @{
		# OPTIONAL
		uuid = $someString
		# OPTIONAL
		name = $someString
		# OPTIONAL
		description = $someString
		# OPTIONAL
		certificate = $someString
		# REQUIRED
		caProvider = $someCaCertProviderType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CaCertProviderType]) for enum values.
	}
	# OPTIONAL
	replicationTargetUuid = $someString
	# REQUIRED
	uploadLocationType = $someUploadLocationType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UploadLocationType]) for enum values.
}"
            );
        }

        // Create new GraphQL Mutation:
        // createCustomAnalyzer(input: CreateCustomAnalyzerInput!): Analyzer!
        internal void InitMutationCreateCustomAnalyzer()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateCustomAnalyzerInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateCustomAnalyzer",
                "($input: CreateCustomAnalyzerInput!)",
                "Analyzer",
                Mutation.CreateCustomAnalyzer,
                Mutation.CreateCustomAnalyzerFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	analyzerType = $someAnalyzerTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AnalyzerTypeEnum]) for enum values.
	# OPTIONAL
	id = $someString
	# OPTIONAL
	name = $someString
	# OPTIONAL
	dictionaryCsv = $someString
	# OPTIONAL
	dictionary = @(
		$someString
	)
	# OPTIONAL
	regex = $someString
	# OPTIONAL
	analyzerRiskInstance = @{
		# OPTIONAL
		analyzerId = $someString
		# OPTIONAL
		riskVersion = $someInt
		# OPTIONAL
		risk = $someRiskLevelType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RiskLevelType]) for enum values.
	}
	# OPTIONAL
	tagId = $someInt
	# OPTIONAL
	risk = $someRiskLevelType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RiskLevelType]) for enum values.
}"
            );
        }

        // Create new GraphQL Mutation:
        // createEventDigestBatch(input: CreateEventDigestBatchInput!): Void
        internal void InitMutationCreateEventDigestBatch()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateEventDigestBatchInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateEventDigestBatch",
                "($input: CreateEventDigestBatchInput!)",
                "System.String",
                Mutation.CreateEventDigestBatch,
                Mutation.CreateEventDigestBatchFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	digests = @(
		@{
			# OPTIONAL
			digestId = $someInt
			# REQUIRED
			digestName = $someString
			# REQUIRED
			frequencyHours = $someInt
			# REQUIRED
			isImmediate = $someBoolean
			# REQUIRED
			includeAudits = $someBoolean
			# REQUIRED
			includeEvents = $someBoolean
			# REQUIRED
			eventDigestConfig = @{
				# OPTIONAL
				objectType = @(
					$someActivityObjectTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ActivityObjectTypeEnum]) for enum values.
				)
				# OPTIONAL
				activityStatus = @(
					$someActivityStatusEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ActivityStatusEnum]) for enum values.
				)
				# OPTIONAL
				activityType = @(
					$someString
				)
				# OPTIONAL
				auditType = @(
					$someUserAuditTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UserAuditTypeEnum]) for enum values.
				)
				# OPTIONAL
				activitySeverity = @(
					$someActivitySeverityEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ActivitySeverityEnum]) for enum values.
				)
				# OPTIONAL
				clusters = @(
					$someString
				)
				# OPTIONAL
				emailAddresses = @(
					$someString
				)
			}
			# REQUIRED
			recipientUserId = $someString
			# REQUIRED
			clusterUuids = @(
				$someString
			)
		}
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // createGuestCredential(input: CreateGuestCredentialInput!): CreateGuestCredentialReply!
        internal void InitMutationCreateGuestCredential()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateGuestCredentialInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateGuestCredential",
                "($input: CreateGuestCredentialInput!)",
                "CreateGuestCredentialReply",
                Mutation.CreateGuestCredential,
                Mutation.CreateGuestCredentialFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	clusterUuid = $someString
	# REQUIRED
	definition = @{
		# OPTIONAL
		domain = $someString
		# OPTIONAL
		description = $someString
		# OPTIONAL
		baseGuestCredential = @{
			# REQUIRED
			password = $someString
			# REQUIRED
			username = $someString
		}
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // createLegalHold(input: CreateLegalHoldInput!): CreateLegalHoldReply!
        internal void InitMutationCreateLegalHold()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateLegalHoldInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateLegalHold",
                "($input: CreateLegalHoldInput!)",
                "CreateLegalHoldReply",
                Mutation.CreateLegalHold,
                Mutation.CreateLegalHoldFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	snapshotIds = @(
		$someString
	)
	# OPTIONAL
	holdConfig = @{
		# OPTIONAL
		shouldHoldInPlace = $someBoolean
	}
	# OPTIONAL
	userNote = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // createOnDemandVolumeGroupBackup(input: CreateOnDemandVolumeGroupBackupInput!): AsyncRequestStatus!
        internal void InitMutationCreateOnDemandVolumeGroupBackup()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateOnDemandVolumeGroupBackupInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateOnDemandVolumeGroupBackup",
                "($input: CreateOnDemandVolumeGroupBackupInput!)",
                "AsyncRequestStatus",
                Mutation.CreateOnDemandVolumeGroupBackup,
                Mutation.CreateOnDemandVolumeGroupBackupFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	config = @{
		# OPTIONAL
		volumeIdsIncludedInSnapshot = @(
			$someString
		)
		# OPTIONAL
		baseOnDemandSnapshotConfig = @{
			# OPTIONAL
			slaId = $someString
		}
	}
	# REQUIRED
	id = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // createOrgNetwork(input: CreateOrgNetworkInput!): CreateOrgNetworkReply!
        internal void InitMutationCreateOrgNetwork()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateOrgNetworkInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateOrgNetwork",
                "($input: CreateOrgNetworkInput!)",
                "CreateOrgNetworkReply",
                Mutation.CreateOrgNetwork,
                Mutation.CreateOrgNetworkFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	orgID = $someString
	# REQUIRED
	clusterUUID = $someString
	# REQUIRED
	orgNetworkName = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // createPasskey(input: CreatePasskeyInput!): CreatePasskeyReply!
        internal void InitMutationCreatePasskey()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreatePasskeyInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreatePasskey",
                "($input: CreatePasskeyInput!)",
                "CreatePasskeyReply",
                Mutation.CreatePasskey,
                Mutation.CreatePasskeyFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	additionalConfig = $someString
	# OPTIONAL
	os = $someString
	# OPTIONAL
	browser = $someString
	# REQUIRED
	credentialId = $someString
	# REQUIRED
	passkeyName = $someString
	# REQUIRED
	publicKey = $someString
	# REQUIRED
	keyType = $someKeyTypeEnumType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.KeyTypeEnumType]) for enum values.
	# REQUIRED
	clientData = $someString
	# REQUIRED
	authData = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // createRbacMigrationSummaryDownload(input: CreateRbacMigrationSummaryDownloadInput!): CreateRbacMigrationSummaryDownloadReply!
        internal void InitMutationCreateRbacMigrationSummaryDownload()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateRbacMigrationSummaryDownloadInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateRbacMigrationSummaryDownload",
                "($input: CreateRbacMigrationSummaryDownloadInput!)",
                "CreateRbacMigrationSummaryDownloadReply",
                Mutation.CreateRbacMigrationSummaryDownload,
                Mutation.CreateRbacMigrationSummaryDownloadFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	clusterId = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // createRecoveryPlan(input: CreateRecoveryPlanInput!): CreateRecoveryPlanReply!
        internal void InitMutationCreateRecoveryPlan()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateRecoveryPlanInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateRecoveryPlan",
                "($input: CreateRecoveryPlanInput!)",
                "CreateRecoveryPlanReply",
                Mutation.CreateRecoveryPlan,
                Mutation.CreateRecoveryPlanFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	name = $someString
	# REQUIRED
	recoveryType = $someBlueprintRecoveryType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.BlueprintRecoveryType]) for enum values.
	# REQUIRED
	sourceLocationId = $someString
	# REQUIRED
	sourceLocationType = $someBlueprintLocationType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.BlueprintLocationType]) for enum values.
	# OPTIONAL
	targetLocationId = $someString
	# OPTIONAL
	targetLocationType = $someBlueprintLocationType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.BlueprintLocationType]) for enum values.
	# REQUIRED
	children = @(
		@{
			# REQUIRED
			fid = $someString
			# REQUIRED
			snappableType = $someObjectTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ObjectTypeEnum]) for enum values.
			# REQUIRED
			bootPriority = $someInt
			# OPTIONAL
			lastRecoveryPoint = $someInt64
		}
	)
	# REQUIRED
	isHydrationEnabled = $someBoolean
	# REQUIRED
	pauseBetweenPriorityGroups = @(
		$someInt64
	)
	# REQUIRED
	isVisible = $someBoolean
}"
            );
        }

        // Create new GraphQL Mutation:
        // createRecoverySchedule(input: CreateRecoveryScheduleInput!): CreateScheduleReply!
        internal void InitMutationCreateRecoverySchedule()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateRecoveryScheduleInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateRecoverySchedule",
                "($input: CreateRecoveryScheduleInput!)",
                "CreateScheduleReply",
                Mutation.CreateRecoverySchedule,
                Mutation.CreateRecoveryScheduleFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	recoveryPlanFid = $someString
	# REQUIRED
	scheduleInfo = @{
		# OPTIONAL
		startRunTime = $someDateTime
		# OPTIONAL
		timezone = $someString
		# OPTIONAL
		frequency = $someScheduleFrequency # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ScheduleFrequency]) for enum values.
		# OPTIONAL
		recoveryConfig = @{
			# OPTIONAL
			dataTransferType = $someDataTransferType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DataTransferType]) for enum values.
		}
		# OPTIONAL
		recipients = @(
			$someString
		)
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // createS3Bucket(input: CreateS3BucketInput!): CreateS3BucketReply!
        internal void InitMutationCreateS3Bucket()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateS3BucketInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateS3Bucket",
                "($input: CreateS3BucketInput!)",
                "CreateS3BucketReply",
                Mutation.CreateS3Bucket,
                Mutation.CreateS3BucketFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	awsNativeAccountId = $someString
	# REQUIRED
	bucketName = $someString
	# REQUIRED
	region = $someString
	# REQUIRED
	bucketOwnershipControl = $someBucketOwnershipControls # Call [Enum]::GetValues([RubrikSecurityCloud.Types.BucketOwnershipControls]) for enum values.
	# REQUIRED
	tags = @(
		@{
			# REQUIRED
			tagKey = $someString
			# REQUIRED
			tagValue = $someString
		}
	)
	# REQUIRED
	versioningEnabled = $someBoolean
}"
            );
        }

        // Create new GraphQL Mutation:
        // createSnapMirrorCloud(input: CreateSnapMirrorCloudInput!): CreateSnapMirrorCloudReply!
        internal void InitMutationCreateSnapMirrorCloud()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateSnapMirrorCloudInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateSnapMirrorCloud",
                "($input: CreateSnapMirrorCloudInput!)",
                "CreateSnapMirrorCloudReply",
                Mutation.CreateSnapMirrorCloud,
                Mutation.CreateSnapMirrorCloudFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	clusterUuid = $someString
	# REQUIRED
	definition = @{
		# OPTIONAL
		nasVolumeId = $someString
		# OPTIONAL
		snapMirrorLabel = $someString
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // createSnapMirrorCloudRelationship(input: CreateSnapMirrorCloudRelationshipInput!): CreateSnapMirrorCloudRelationshipReply!
        internal void InitMutationCreateSnapMirrorCloudRelationship()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateSnapMirrorCloudRelationshipInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateSnapMirrorCloudRelationship",
                "($input: CreateSnapMirrorCloudRelationshipInput!)",
                "CreateSnapMirrorCloudRelationshipReply",
                Mutation.CreateSnapMirrorCloudRelationship,
                Mutation.CreateSnapMirrorCloudRelationshipFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	clusterUuid = $someString
	# REQUIRED
	definition = @{
		# OPTIONAL
		objectStoreAccess = @{
			# OPTIONAL
			isSslEnabled = $someBoolean
			# OPTIONAL
			objectServerUrl = $someString
			# OPTIONAL
			providerType = $someString
			# OPTIONAL
			shouldUseHttpProxy = $someBoolean
		}
		# REQUIRED
		snapMirrorCloudId = $someString
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // createSnapMirrorCloudRestoreJob(input: CreateSnapMirrorCloudRestoreJobInput!): AsyncRequestStatus!
        internal void InitMutationCreateSnapMirrorCloudRestoreJob()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateSnapMirrorCloudRestoreJobInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateSnapMirrorCloudRestoreJob",
                "($input: CreateSnapMirrorCloudRestoreJobInput!)",
                "AsyncRequestStatus",
                Mutation.CreateSnapMirrorCloudRestoreJob,
                Mutation.CreateSnapMirrorCloudRestoreJobFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someString
	# REQUIRED
	jobConfig = @{
		# OPTIONAL
		ignoreErrors = $someBoolean
		# OPTIONAL
		netAppAggregateName = $someString
		# OPTIONAL
		targetNasNamespaceId = $someString
		# OPTIONAL
		targetNasSystemId = $someString
		# OPTIONAL
		targetNasVolumeId = $someString
		# OPTIONAL
		targetNasVolumeName = $someString
		# REQUIRED
		isVolumeRestore = $someBoolean
		# OPTIONAL
		restorePathPairs = @(
			@{
				# OPTIONAL
				dstPath = $someString
				# REQUIRED
				srcPath = $someString
			}
		)
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // createSsoUsers(input: CreateSsoUsersInput!): CreateSsoUsersReply!
        internal void InitMutationCreateSsoUsers()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateSsoUsersInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateSsoUsers",
                "($input: CreateSsoUsersInput!)",
                "CreateSsoUsersReply",
                Mutation.CreateSsoUsers,
                Mutation.CreateSsoUsersFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	userEmails = @(
		$someString
	)
	# REQUIRED
	roleIds = @(
		$someString
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // createSupportCase(input: CreateSupportCaseInput!): CreateSupportCaseReply!
        internal void InitMutationCreateSupportCase()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateSupportCaseInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateSupportCase",
                "($input: CreateSupportCaseInput!)",
                "CreateSupportCaseReply",
                Mutation.CreateSupportCase,
                Mutation.CreateSupportCaseFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	subject = $someString
	# REQUIRED
	caseType = $someNewCaseType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.NewCaseType]) for enum values.
	# REQUIRED
	priority = $someNewCasePriority # Call [Enum]::GetValues([RubrikSecurityCloud.Types.NewCasePriority]) for enum values.
	# OPTIONAL
	clusterId = $someString
	# REQUIRED
	contactMethod = $someNewCaseContactMethod # Call [Enum]::GetValues([RubrikSecurityCloud.Types.NewCaseContactMethod]) for enum values.
	# REQUIRED
	description = $someString
	# OPTIONAL
	caseSource = $someNewCaseSource # Call [Enum]::GetValues([RubrikSecurityCloud.Types.NewCaseSource]) for enum values.
}"
            );
        }

        // Create new GraphQL Mutation:
        // createUserAccessInsightTicket(input: CreateUserAccessInsightTicketInput!): CreateUserAccessInsightTicketReply!
        internal void InitMutationCreateUserAccessInsightTicket()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateUserAccessInsightTicketInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateUserAccessInsightTicket",
                "($input: CreateUserAccessInsightTicketInput!)",
                "CreateUserAccessInsightTicketReply",
                Mutation.CreateUserAccessInsightTicket,
                Mutation.CreateUserAccessInsightTicketFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	insightUuid = $someString
	# REQUIRED
	platformType = $someTicketingPlatform # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TicketingPlatform]) for enum values.
	# REQUIRED
	ticketInfo = @{
		# REQUIRED
		name = $someString
		# REQUIRED
		reason = $someString
		# REQUIRED
		attachmentTypes = @(
			$someInsightTicketAttachmentType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.InsightTicketAttachmentType]) for enum values.
		)
		# REQUIRED
		comment = $someString
	}
	# REQUIRED
	timelineDate = $someInt64
}"
            );
        }

        // Create new GraphQL Mutation:
        // createVappExport(input: CreateVappExportInput!): [AsyncRequestStatus!]!
        internal void InitMutationCreateVappExport()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateVappExportInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateVappExport",
                "($input: CreateVappExportInput!)",
                "List<AsyncRequestStatus>",
                Mutation.CreateVappExport,
                Mutation.CreateVappExportFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	config = @{
		# OPTIONAL
		shouldPowerOnVappAfterExport = $someBoolean
		# OPTIONAL
		targetVappId = $someString
		# REQUIRED
		exportMode = $someVappExportMode # Call [Enum]::GetValues([RubrikSecurityCloud.Types.VappExportMode]) for enum values.
		# REQUIRED
		networksToRestore = @(
			@{
				# OPTIONAL
				newName = $someString
				# OPTIONAL
				vappNetworkSummary = @{
					# OPTIONAL
					parentNetworkId = $someString
					# REQUIRED
					isDeployed = $someBoolean
					# REQUIRED
					name = $someString
				}
			}
		)
		# OPTIONAL
		newVappParams = @{
			# REQUIRED
			name = $someString
			# REQUIRED
			orgVdcId = $someString
		}
		# REQUIRED
		vmsToExport = @(
			@{
				# OPTIONAL
				storagePolicyId = $someString
				# REQUIRED
				name = $someString
				# REQUIRED
				networkConnections = @(
					@{
						# OPTIONAL
						ipAddress = $someString
						# OPTIONAL
						macAddress = $someString
						# OPTIONAL
						vappNetworkName = $someString
						# OPTIONAL
						networkAdapterType = $someString
						# REQUIRED
						addressingMode = $someVappVmIpAddressingMode # Call [Enum]::GetValues([RubrikSecurityCloud.Types.VappVmIpAddressingMode]) for enum values.
						# REQUIRED
						isConnected = $someBoolean
						# REQUIRED
						nicIndex = $someInt
					}
				)
				# REQUIRED
				vcdMoid = $someString
			}
		)
	}
	# REQUIRED
	snapshotId = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // createVappsInstantRecovery(input: CreateVappsInstantRecoveryInput!): CreateVappsInstantRecoveryReply!
        internal void InitMutationCreateVappsInstantRecovery()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateVappsInstantRecoveryInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateVappsInstantRecovery",
                "($input: CreateVappsInstantRecoveryInput!)",
                "CreateVappsInstantRecoveryReply",
                Mutation.CreateVappsInstantRecovery,
                Mutation.CreateVappsInstantRecoveryFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	inputs = @(
		@{
			# REQUIRED
			config = @{
				# OPTIONAL
				shouldPowerOnVmsAfterRecovery = $someBoolean
				# REQUIRED
				vmsToRestore = @(
					@{
						# OPTIONAL
						storagePolicyId = $someString
						# REQUIRED
						name = $someString
						# REQUIRED
						networkConnections = @(
							@{
								# OPTIONAL
								ipAddress = $someString
								# OPTIONAL
								macAddress = $someString
								# OPTIONAL
								vappNetworkName = $someString
								# OPTIONAL
								networkAdapterType = $someString
								# REQUIRED
								addressingMode = $someVappVmIpAddressingMode # Call [Enum]::GetValues([RubrikSecurityCloud.Types.VappVmIpAddressingMode]) for enum values.
								# REQUIRED
								isConnected = $someBoolean
								# REQUIRED
								nicIndex = $someInt
							}
						)
						# REQUIRED
						vcdMoid = $someString
					}
				)
			}
			# REQUIRED
			snapshotId = $someString
		}
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // deactivateCustomAnalyzer(analyzerId: String!): String!
        internal void InitMutationDeactivateCustomAnalyzer()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("analyzerId", "String!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDeactivateCustomAnalyzer",
                "($analyzerId: String!)",
                "System.String",
                Mutation.DeactivateCustomAnalyzer,
                Mutation.DeactivateCustomAnalyzerFieldSpec,
                @"# REQUIRED
$query.Var.analyzerId = $someString"
            );
        }

        // Create new GraphQL Mutation:
        // deleteAccountSettingValue(aspName: String!, aspComponent: ComponentEnum!): Boolean!
        internal void InitMutationDeleteAccountSettingValue()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("aspName", "String!"),
                Tuple.Create("aspComponent", "ComponentEnum!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDeleteAccountSettingValue",
                "($aspName: String!,$aspComponent: ComponentEnum!)",
                "System.Boolean",
                Mutation.DeleteAccountSettingValue,
                Mutation.DeleteAccountSettingValueFieldSpec,
                @"# REQUIRED
$query.Var.aspName = $someString
# REQUIRED
$query.Var.aspComponent = $someComponentEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ComponentEnum]) for enum values."
            );
        }

        // Create new GraphQL Mutation:
        // deleteAdGroupsFromHierarchy(input: DeleteAdGroupsFromHierarchyInput!): RequestStatus!
        internal void InitMutationDeleteAdGroupsFromHierarchy()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteAdGroupsFromHierarchyInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDeleteAdGroupsFromHierarchy",
                "($input: DeleteAdGroupsFromHierarchyInput!)",
                "RequestStatus",
                Mutation.DeleteAdGroupsFromHierarchy,
                Mutation.DeleteAdGroupsFromHierarchyFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	orgId = $someString
	# REQUIRED
	groupIds = @(
		$someString
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // deleteBlueprint(fid: UUID!): Boolean!
        internal void InitMutationDeleteBlueprint()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDeleteBlueprint",
                "($fid: UUID!)",
                "System.Boolean",
                Mutation.DeleteBlueprint,
                Mutation.DeleteBlueprintFieldSpec,
                @"# REQUIRED
$query.Var.fid = $someString"
            );
        }

        // Create new GraphQL Mutation:
        // deleteBlueprints(input: DeleteBlueprintsInput!): Boolean!
        internal void InitMutationDeleteBlueprints()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteBlueprintsInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDeleteBlueprints",
                "($input: DeleteBlueprintsInput!)",
                "System.Boolean",
                Mutation.DeleteBlueprints,
                Mutation.DeleteBlueprintsFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	fids = @(
		$someString
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // deleteBrandLogo: Void
        internal void InitMutationDeleteBrandLogo()
        {
            Tuple<string, string>[] argDefs = {
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDeleteBrandLogo",
                "",
                "System.String",
                Mutation.DeleteBrandLogo,
                Mutation.DeleteBrandLogoFieldSpec,
                @""
            );
        }

        // Create new GraphQL Mutation:
        // deleteChatbot(input: DeleteChatbotInput!): Void
        internal void InitMutationDeleteChatbot()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteChatbotInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDeleteChatbot",
                "($input: DeleteChatbotInput!)",
                "System.String",
                Mutation.DeleteChatbot,
                Mutation.DeleteChatbotFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	chatbotId = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // deleteDistributionListDigestBatch(input: DeleteDistributionListDigestBatchInput!): Void
        internal void InitMutationDeleteDistributionListDigestBatch()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteDistributionListDigestBatchInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDeleteDistributionListDigestBatch",
                "($input: DeleteDistributionListDigestBatchInput!)",
                "System.String",
                Mutation.DeleteDistributionListDigestBatch,
                Mutation.DeleteDistributionListDigestBatchFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	digestIds = @(
		$someInt
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // deleteEnvoyNgs(input: DeleteEnvoyNgsInput!): Void
        internal void InitMutationDeleteEnvoyNgs()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteEnvoyNgsInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDeleteEnvoyNgs",
                "($input: DeleteEnvoyNgsInput!)",
                "System.String",
                Mutation.DeleteEnvoyNgs,
                Mutation.DeleteEnvoyNgsFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	orgNetworkID = $someString
	# REQUIRED
	envoyIds = @(
		$someString
	)
	# REQUIRED
	clusterUuid = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // deleteEventDigest(input: DeleteEventDigestInput!): Void
        internal void InitMutationDeleteEventDigest()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteEventDigestInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDeleteEventDigest",
                "($input: DeleteEventDigestInput!)",
                "System.String",
                Mutation.DeleteEventDigest,
                Mutation.DeleteEventDigestFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	recipientUserIds = @(
		$someString
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // deleteGuestCredentialById(input: DeleteGuestCredentialByIdInput!): Boolean!
        internal void InitMutationDeleteGuestCredentialById()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteGuestCredentialByIdInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDeleteGuestCredentialById",
                "($input: DeleteGuestCredentialByIdInput!)",
                "System.Boolean",
                Mutation.DeleteGuestCredentialById,
                Mutation.DeleteGuestCredentialByIdFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	clusterUuid = $someString
	# REQUIRED
	id = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // deleteIdentityProvider: IdentityProvider!
        internal void InitMutationDeleteIdentityProvider()
        {
            Tuple<string, string>[] argDefs = {
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDeleteIdentityProvider",
                "",
                "IdentityProvider",
                Mutation.DeleteIdentityProvider,
                Mutation.DeleteIdentityProviderFieldSpec,
                @""
            );
        }

        // Create new GraphQL Mutation:
        // deleteIntelFeed(input: DeleteIntelFeedInput!): Void
        internal void InitMutationDeleteIntelFeed()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteIntelFeedInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDeleteIntelFeed",
                "($input: DeleteIntelFeedInput!)",
                "System.String",
                Mutation.DeleteIntelFeed,
                Mutation.DeleteIntelFeedFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	providerId = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // deleteKmipServer(input: DeleteKmipServerInput!): DeleteKmipServerReply!
        internal void InitMutationDeleteKmipServer()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteKmipServerInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDeleteKmipServer",
                "($input: DeleteKmipServerInput!)",
                "DeleteKmipServerReply",
                Mutation.DeleteKmipServer,
                Mutation.DeleteKmipServerFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	clusterIds = @(
		$someString
	)
	# REQUIRED
	serverAddress = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // deleteKmsInstance(input: DeleteKmsInstanceInput!): Void
        internal void InitMutationDeleteKmsInstance()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteKmsInstanceInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDeleteKmsInstance",
                "($input: DeleteKmsInstanceInput!)",
                "System.String",
                Mutation.DeleteKmsInstance,
                Mutation.DeleteKmsInstanceFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	kmsKeyVaultId = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // deleteOrgNetwork(input: DeleteOrgNetworkInput!): Void
        internal void InitMutationDeleteOrgNetwork()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteOrgNetworkInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDeleteOrgNetwork",
                "($input: DeleteOrgNetworkInput!)",
                "System.String",
                Mutation.DeleteOrgNetwork,
                Mutation.DeleteOrgNetworkFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	orgNetworkID = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // deletePasskey(input: DeletePasskeyInput!): DeletePasskeyReply!
        internal void InitMutationDeletePasskey()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeletePasskeyInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDeletePasskey",
                "($input: DeletePasskeyInput!)",
                "DeletePasskeyReply",
                Mutation.DeletePasskey,
                Mutation.DeletePasskeyFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	credentialId = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // deleteRecoveryPlan(fid: UUID!): Void
        internal void InitMutationDeleteRecoveryPlan()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDeleteRecoveryPlan",
                "($fid: UUID!)",
                "System.String",
                Mutation.DeleteRecoveryPlan,
                Mutation.DeleteRecoveryPlanFieldSpec,
                @"# REQUIRED
$query.Var.fid = $someString"
            );
        }

        // Create new GraphQL Mutation:
        // deleteRecoveryPlans(fids: [UUID!]!): Void
        internal void InitMutationDeleteRecoveryPlans()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fids", "[UUID!]!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDeleteRecoveryPlans",
                "($fids: [UUID!]!)",
                "System.String",
                Mutation.DeleteRecoveryPlans,
                Mutation.DeleteRecoveryPlansFieldSpec,
                @"# REQUIRED
$query.Var.fids = @(
	$someString
)"
            );
        }

        // Create new GraphQL Mutation:
        // deleteRecoverySchedule(input: DeleteRecoveryScheduleInput!): Void
        internal void InitMutationDeleteRecoverySchedule()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteRecoveryScheduleInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDeleteRecoverySchedule",
                "($input: DeleteRecoveryScheduleInput!)",
                "System.String",
                Mutation.DeleteRecoverySchedule,
                Mutation.DeleteRecoveryScheduleFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	recoveryPlanFid = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // deleteRecoverySpec(blueprintId: UUID!, excludePlanTypes: [PlanName!]!, failoverId: UUID): DeleteBlueprintRecoverySpecReply!
        internal void InitMutationDeleteRecoverySpec()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("blueprintId", "UUID!"),
                Tuple.Create("excludePlanTypes", "[PlanName!]!"),
                Tuple.Create("failoverId", "UUID"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDeleteRecoverySpec",
                "($blueprintId: UUID!,$excludePlanTypes: [PlanName!]!,$failoverId: UUID)",
                "DeleteBlueprintRecoverySpecReply",
                Mutation.DeleteRecoverySpec,
                Mutation.DeleteRecoverySpecFieldSpec,
                @"# REQUIRED
$query.Var.blueprintId = $someString
# REQUIRED
$query.Var.excludePlanTypes = @(
	$somePlanName # Call [Enum]::GetValues([RubrikSecurityCloud.Types.PlanName]) for enum values.
)
# OPTIONAL
$query.Var.failoverId = $someString"
            );
        }

        // Create new GraphQL Mutation:
        // deleteSmtpConfiguration: Boolean!
        internal void InitMutationDeleteSmtpConfiguration()
        {
            Tuple<string, string>[] argDefs = {
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDeleteSmtpConfiguration",
                "",
                "System.Boolean",
                Mutation.DeleteSmtpConfiguration,
                Mutation.DeleteSmtpConfigurationFieldSpec,
                @""
            );
        }

        // Create new GraphQL Mutation:
        // deleteSnapMirrorCloud(input: DeleteSnapMirrorCloudInput!): ResponseSuccess!
        internal void InitMutationDeleteSnapMirrorCloud()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteSnapMirrorCloudInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDeleteSnapMirrorCloud",
                "($input: DeleteSnapMirrorCloudInput!)",
                "ResponseSuccess",
                Mutation.DeleteSnapMirrorCloud,
                Mutation.DeleteSnapMirrorCloudFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	preserveSnapshots = $someBoolean
	# REQUIRED
	id = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // deleteSnapMirrorCloudRelationship(input: DeleteSnapMirrorCloudRelationshipInput!): ResponseSuccess!
        internal void InitMutationDeleteSnapMirrorCloudRelationship()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteSnapMirrorCloudRelationshipInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDeleteSnapMirrorCloudRelationship",
                "($input: DeleteSnapMirrorCloudRelationshipInput!)",
                "ResponseSuccess",
                Mutation.DeleteSnapMirrorCloudRelationship,
                Mutation.DeleteSnapMirrorCloudRelationshipFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // deleteVcdInstances(input: DeleteVcdInstancesInput!): DeleteVcdInstancesReply!
        internal void InitMutationDeleteVcdInstances()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteVcdInstancesInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDeleteVcdInstances",
                "($input: DeleteVcdInstancesInput!)",
                "DeleteVcdInstancesReply",
                Mutation.DeleteVcdInstances,
                Mutation.DeleteVcdInstancesFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	inputs = @(
		@{
			# REQUIRED
			clusterUuid = $someString
			# REQUIRED
			id = $someString
		}
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // deleteVolumeGroupMount(input: DeleteVolumeGroupMountInput!): AsyncRequestStatus!
        internal void InitMutationDeleteVolumeGroupMount()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteVolumeGroupMountInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDeleteVolumeGroupMount",
                "($input: DeleteVolumeGroupMountInput!)",
                "AsyncRequestStatus",
                Mutation.DeleteVolumeGroupMount,
                Mutation.DeleteVolumeGroupMountFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // denyTprRequests(input: DenyTprRequestsInput!): Void
        internal void InitMutationDenyTprRequests()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DenyTprRequestsInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDenyTprRequests",
                "($input: DenyTprRequestsInput!)",
                "System.String",
                Mutation.DenyTprRequests,
                Mutation.DenyTprRequestsFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	requestIds = @(
		$someString
	)
	# OPTIONAL
	comment = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // deregisterPrivateContainerRegistry(input: DeregisterPrivateContainerRegistryInput!): Void
        internal void InitMutationDeregisterPrivateContainerRegistry()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeregisterPrivateContainerRegistryInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDeregisterPrivateContainerRegistry",
                "($input: DeregisterPrivateContainerRegistryInput!)",
                "System.String",
                Mutation.DeregisterPrivateContainerRegistry,
                Mutation.DeregisterPrivateContainerRegistryFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	exocomputeAccountId = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // disableSupportUserAccess(input: DisableSupportUserAccessInput!): Void
        internal void InitMutationDisableSupportUserAccess()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DisableSupportUserAccessInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDisableSupportUserAccess",
                "($input: DisableSupportUserAccessInput!)",
                "System.String",
                Mutation.DisableSupportUserAccess,
                Mutation.DisableSupportUserAccessFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	id = $someInt
	# OPTIONAL
	impersonatedUserId = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // disableTprOrg(input: DisableTprOrgInput!): Void
        internal void InitMutationDisableTprOrg()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DisableTprOrgInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDisableTprOrg",
                "($input: DisableTprOrgInput!)",
                "System.String",
                Mutation.DisableTprOrg,
                Mutation.DisableTprOrgFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	organizationId = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // disconnectTicketingPlatform(input: DisconnectTicketingPlatformInput!): Void
        internal void InitMutationDisconnectTicketingPlatform()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DisconnectTicketingPlatformInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDisconnectTicketingPlatform",
                "($input: DisconnectTicketingPlatformInput!)",
                "System.String",
                Mutation.DisconnectTicketingPlatform,
                Mutation.DisconnectTicketingPlatformFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	platformConfig = @{
		# REQUIRED
		platformType = $someTicketingPlatform # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TicketingPlatform]) for enum values.
		# REQUIRED
		instanceUrl = $someString
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // dissolveLegalHold(input: DissolveLegalHoldInput!): DissolveLegalHoldReply!
        internal void InitMutationDissolveLegalHold()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DissolveLegalHoldInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDissolveLegalHold",
                "($input: DissolveLegalHoldInput!)",
                "DissolveLegalHoldReply",
                Mutation.DissolveLegalHold,
                Mutation.DissolveLegalHoldFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	snapshotIds = @(
		$someString
	)
	# OPTIONAL
	userNote = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // editPasskey(input: EditPasskeyInput!): EditPasskeyReply!
        internal void InitMutationEditPasskey()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "EditPasskeyInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationEditPasskey",
                "($input: EditPasskeyInput!)",
                "EditPasskeyReply",
                Mutation.EditPasskey,
                Mutation.EditPasskeyFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	credentialId = $someString
	# REQUIRED
	passkeyNewName = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // editSalesforceOrganization(input: EditSalesforceOrganizationInput!): EditSalesforceOrganizationReply!
        internal void InitMutationEditSalesforceOrganization()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "EditSalesforceOrganizationInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationEditSalesforceOrganization",
                "($input: EditSalesforceOrganizationInput!)",
                "EditSalesforceOrganizationReply",
                Mutation.EditSalesforceOrganization,
                Mutation.EditSalesforceOrganizationFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	orgId = $someString
	# REQUIRED
	apiLimits = @{
		# OPTIONAL
		restApiLimit = $someInt
		# OPTIONAL
		bulkApiLimit = $someInt
		# OPTIONAL
		bulkApiV2Limit = $someInt
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // enableAutomaticFmdUpload(input: EnableAutomaticFmdUploadInput!): EnableAutomaticFmdUploadReply!
        internal void InitMutationEnableAutomaticFmdUpload()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "EnableAutomaticFmdUploadInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationEnableAutomaticFmdUpload",
                "($input: EnableAutomaticFmdUploadInput!)",
                "EnableAutomaticFmdUploadReply",
                Mutation.EnableAutomaticFmdUpload,
                Mutation.EnableAutomaticFmdUploadFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	clusterId = $someString
	# REQUIRED
	enabled = $someBoolean
}"
            );
        }

        // Create new GraphQL Mutation:
        // enableDisableAppConsistency(input: EnableDisableAppConsistencyInput!): EnableDisableAppConsistencyReply!
        internal void InitMutationEnableDisableAppConsistency()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "EnableDisableAppConsistencyInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationEnableDisableAppConsistency",
                "($input: EnableDisableAppConsistencyInput!)",
                "EnableDisableAppConsistencyReply",
                Mutation.EnableDisableAppConsistency,
                Mutation.EnableDisableAppConsistencyFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	workloadIds = @(
		$someString
	)
	# REQUIRED
	enable = $someBoolean
	# REQUIRED
	objectType = $someCloudNativeVmAppConsistentObjectType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudNativeVmAppConsistentObjectType]) for enum values.
}"
            );
        }

        // Create new GraphQL Mutation:
        // enableLambdaForWorkload(snappableId: UUID!, enableDiffFmd: Boolean!, enableFullFmd: Boolean!): EnableLambdaForSnappableReply!
        internal void InitMutationEnableLambdaForWorkload()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("snappableId", "UUID!"),
                Tuple.Create("enableDiffFmd", "Boolean!"),
                Tuple.Create("enableFullFmd", "Boolean!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationEnableLambdaForWorkload",
                "($snappableId: UUID!,$enableDiffFmd: Boolean!,$enableFullFmd: Boolean!)",
                "EnableLambdaForSnappableReply",
                Mutation.EnableLambdaForWorkload,
                Mutation.EnableLambdaForWorkloadFieldSpec,
                @"# REQUIRED
$query.Var.snappableId = $someString
# REQUIRED
$query.Var.enableDiffFmd = $someBoolean
# REQUIRED
$query.Var.enableFullFmd = $someBoolean"
            );
        }

        // Create new GraphQL Mutation:
        // enableMigrationWorkflow: EnableMigrationWorkflowReply!
        internal void InitMutationEnableMigrationWorkflow()
        {
            Tuple<string, string>[] argDefs = {
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationEnableMigrationWorkflow",
                "",
                "EnableMigrationWorkflowReply",
                Mutation.EnableMigrationWorkflow,
                Mutation.EnableMigrationWorkflowFieldSpec,
                @""
            );
        }

        // Create new GraphQL Mutation:
        // enableSupportUserAccess(input: EnableSupportUserAccessInput!): Void
        internal void InitMutationEnableSupportUserAccess()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "EnableSupportUserAccessInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationEnableSupportUserAccess",
                "($input: EnableSupportUserAccessInput!)",
                "System.String",
                Mutation.EnableSupportUserAccess,
                Mutation.EnableSupportUserAccessFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	impersonatedUserId = $someString
	# OPTIONAL
	ticketNumber = $someString
	# OPTIONAL
	durationInHours = $someInt
}"
            );
        }

        // Create new GraphQL Mutation:
        // enableTprOrg(input: EnableTprOrgInput!): Boolean!
        internal void InitMutationEnableTprOrg()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "EnableTprOrgInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationEnableTprOrg",
                "($input: EnableTprOrgInput!)",
                "System.Boolean",
                Mutation.EnableTprOrg,
                Mutation.EnableTprOrgFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	organizationId = $someString
	# REQUIRED
	newTprAdminEmail = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // excludeVmDisks(input: [ExcludeVmDisksInput!]!): RequestSuccess!
        internal void InitMutationExcludeVmDisks()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "[ExcludeVmDisksInput!]!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationExcludeVmDisks",
                "($input: [ExcludeVmDisksInput!]!)",
                "RequestSuccess",
                Mutation.ExcludeVmDisks,
                Mutation.ExcludeVmDisksFieldSpec,
                @"# REQUIRED
$query.Var.input = @(
	@{
		# REQUIRED
		virtualDiskFid = $someString
		# REQUIRED
		excludeFromSnapshots = $someBoolean
}
)"
            );
        }

        // Create new GraphQL Mutation:
        // executeTprRequests(input: ExecuteTprRequestsInput!): Void
        internal void InitMutationExecuteTprRequests()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "ExecuteTprRequestsInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationExecuteTprRequests",
                "($input: ExecuteTprRequestsInput!)",
                "System.String",
                Mutation.ExecuteTprRequests,
                Mutation.ExecuteTprRequestsFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	requestIds = @(
		$someString
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // expireSnoozedDirectories(input: ExpireSnoozedDirectoriesInput!): ExpireSnoozedDirectoriesReply!
        internal void InitMutationExpireSnoozedDirectories()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "ExpireSnoozedDirectoriesInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationExpireSnoozedDirectories",
                "($input: ExpireSnoozedDirectoriesInput!)",
                "ExpireSnoozedDirectoriesReply",
                Mutation.ExpireSnoozedDirectories,
                Mutation.ExpireSnoozedDirectoriesFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	directories = @(
		$someString
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // exportPrincipalsSummary(filter: ExportPrincipalsSummaryFilterInput, timelineDate: String!, historicalDeltaDays: Int! = 0): ExportPrincipalSummaryResp!
        internal void InitMutationExportPrincipalsSummary()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("filter", "ExportPrincipalsSummaryFilterInput"),
                Tuple.Create("timelineDate", "String!"),
                Tuple.Create("historicalDeltaDays", "Int!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationExportPrincipalsSummary",
                "($filter: ExportPrincipalsSummaryFilterInput,$timelineDate: String!,$historicalDeltaDays: Int!)",
                "ExportPrincipalSummaryResp",
                Mutation.ExportPrincipalsSummary,
                Mutation.ExportPrincipalsSummaryFieldSpec,
                @"# OPTIONAL
$query.Var.filter = @{
	# OPTIONAL
	riskLevel = @(
		$someRiskLevelType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RiskLevelType]) for enum values.
	)
	# OPTIONAL
	policyIds = @(
		$someString
	)
	# OPTIONAL
	principalName = $someString
	# OPTIONAL
	objectIds = @(
		$someString
	)
	# OPTIONAL
	groupId = $someString
	# OPTIONAL
	principalSummaryCategory = $somePrincipalSummaryCategoryType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.PrincipalSummaryCategoryType]) for enum values.
}
# REQUIRED
$query.Var.timelineDate = $someString
# REQUIRED
$query.Var.historicalDeltaDays = $someInt"
            );
        }

        // Create new GraphQL Mutation:
        // exportUnAccessedUsersSummary(filter: ExportUnAccessedUsersSummaryFilterInput, endTime: DateTime!, timePeriod: TimePeriod!): ExportUnAccessedUsersSummaryResp!
        internal void InitMutationExportUnAccessedUsersSummary()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("filter", "ExportUnAccessedUsersSummaryFilterInput"),
                Tuple.Create("endTime", "DateTime!"),
                Tuple.Create("timePeriod", "TimePeriod!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationExportUnAccessedUsersSummary",
                "($filter: ExportUnAccessedUsersSummaryFilterInput,$endTime: DateTime!,$timePeriod: TimePeriod!)",
                "ExportUnAccessedUsersSummaryResp",
                Mutation.ExportUnAccessedUsersSummary,
                Mutation.ExportUnAccessedUsersSummaryFieldSpec,
                @"# OPTIONAL
$query.Var.filter = @{
	# OPTIONAL
	policyId = $someString
	# OPTIONAL
	objectId = $someString
	# OPTIONAL
	userNamePrefix = $someString
	# OPTIONAL
	groupId = $someString
	# OPTIONAL
	sid = $someString
	# OPTIONAL
	activityThresholds = @(
		$someActivityThreshold # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ActivityThreshold]) for enum values.
	)
	# OPTIONAL
	userRisk = $someRiskLevelType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RiskLevelType]) for enum values.
}
# REQUIRED
$query.Var.endTime = $someDateTime
# REQUIRED
$query.Var.timePeriod = $someTimePeriod # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TimePeriod]) for enum values."
            );
        }

        // Create new GraphQL Mutation:
        // extendRscAutoUpgradeDate: ExtendRscAutoUpgradeDateReply!
        internal void InitMutationExtendRscAutoUpgradeDate()
        {
            Tuple<string, string>[] argDefs = {
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationExtendRscAutoUpgradeDate",
                "",
                "ExtendRscAutoUpgradeDateReply",
                Mutation.ExtendRscAutoUpgradeDate,
                Mutation.ExtendRscAutoUpgradeDateFieldSpec,
                @""
            );
        }

        // Create new GraphQL Mutation:
        // extendTrialAsync(input: ExtendTrialAsyncInput!): ExtendTrialAsyncReply!
        internal void InitMutationExtendTrialAsync()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "ExtendTrialAsyncInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationExtendTrialAsync",
                "($input: ExtendTrialAsyncInput!)",
                "ExtendTrialAsyncReply",
                Mutation.ExtendTrialAsync,
                Mutation.ExtendTrialAsyncFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	trialId = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // generateConfigProtectionRestoreForm(input: GenerateConfigProtectionRestoreFormInput!): GenerateConfigProtectionRestoreFormReply!
        internal void InitMutationGenerateConfigProtectionRestoreForm()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GenerateConfigProtectionRestoreFormInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationGenerateConfigProtectionRestoreForm",
                "($input: GenerateConfigProtectionRestoreFormInput!)",
                "GenerateConfigProtectionRestoreFormReply",
                Mutation.GenerateConfigProtectionRestoreForm,
                Mutation.GenerateConfigProtectionRestoreFormFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	clusterUuid = $someString
	# REQUIRED
	restoreFormRequest = @{
		# REQUIRED
		backupFileName = $someString
		# REQUIRED
		encryptionPassword = $someString
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // generateSupportBundle(input: GenerateSupportBundleInput!): AsyncRequestStatus!
        internal void InitMutationGenerateSupportBundle()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GenerateSupportBundleInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationGenerateSupportBundle",
                "($input: GenerateSupportBundleInput!)",
                "AsyncRequestStatus",
                Mutation.GenerateSupportBundle,
                Mutation.GenerateSupportBundleFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	clusterUuid = $someString
	# OPTIONAL
	definitions = @{
		# OPTIONAL
		eventId = $someString
		# OPTIONAL
		requestIds = @(
			$someString
		)
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // getDownloadUrl(downloadId: Long!): UserDownloadUrl!
        internal void InitMutationGetDownloadUrl()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("downloadId", "Long!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationGetDownloadUrl",
                "($downloadId: Long!)",
                "UserDownloadUrl",
                Mutation.GetDownloadUrl,
                Mutation.GetDownloadUrlFieldSpec,
                @"# REQUIRED
$query.Var.downloadId = $someInt64"
            );
        }

        // Create new GraphQL Mutation:
        // hideRevealNasNamespaces(input: HideRevealNasNamespacesInput!): Void
        internal void InitMutationHideRevealNasNamespaces()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "HideRevealNasNamespacesInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationHideRevealNasNamespaces",
                "($input: HideRevealNasNamespacesInput!)",
                "System.String",
                Mutation.HideRevealNasNamespaces,
                Mutation.HideRevealNasNamespacesFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	hideNasNamespacesRequest = @{
		# REQUIRED
		action = $someHideRevealAction # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HideRevealAction]) for enum values.
		# REQUIRED
		ids = @(
			$someString
		)
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // ignoreTrial(input: IgnoreTrialInput!): Void
        internal void InitMutationIgnoreTrial()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "IgnoreTrialInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationIgnoreTrial",
                "($input: IgnoreTrialInput!)",
                "System.String",
                Mutation.IgnoreTrial,
                Mutation.IgnoreTrialFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	trialId = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // installIoFilter(input: InstallIoFilterInput!): RequestSuccess!
        internal void InitMutationInstallIoFilter()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "InstallIoFilterInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationInstallIoFilter",
                "($input: InstallIoFilterInput!)",
                "RequestSuccess",
                Mutation.InstallIoFilter,
                Mutation.InstallIoFilterFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	fqdnInfo = @{
		# REQUIRED
		fqdn = $someString
	}
	# REQUIRED
	id = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // inviteSsoGroup(input: InviteSsoGroupInput!): Boolean!
        internal void InitMutationInviteSsoGroup()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "InviteSsoGroupInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationInviteSsoGroup",
                "($input: InviteSsoGroupInput!)",
                "System.Boolean",
                Mutation.InviteSsoGroup,
                Mutation.InviteSsoGroupFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	groupName = $someString
	# REQUIRED
	roleIds = @(
		$someString
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // inviteUsersToTrial(input: InviteUsersToTrialInput!): InviteUsersToTrialReply!
        internal void InitMutationInviteUsersToTrial()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "InviteUsersToTrialInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationInviteUsersToTrial",
                "($input: InviteUsersToTrialInput!)",
                "InviteUsersToTrialReply",
                Mutation.InviteUsersToTrial,
                Mutation.InviteUsersToTrialFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	trialId = $someString
	# REQUIRED
	emails = @(
		$someString
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // listCidrsForComputeSetting(input: ListCidrsForComputeSettingInput!): ListCidrsForComputeSettingReply!
        internal void InitMutationListCidrsForComputeSetting()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "ListCidrsForComputeSettingInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationListCidrsForComputeSetting",
                "($input: ListCidrsForComputeSettingInput!)",
                "ListCidrsForComputeSettingReply",
                Mutation.ListCidrsForComputeSetting,
                Mutation.ListCidrsForComputeSettingFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	clusterIds = @(
		$someString
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // lockIsolatedRecovery(input: LockIsolatedRecoveryInput!): Boolean!
        internal void InitMutationLockIsolatedRecovery()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "LockIsolatedRecoveryInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationLockIsolatedRecovery",
                "($input: LockIsolatedRecoveryInput!)",
                "System.Boolean",
                Mutation.LockIsolatedRecovery,
                Mutation.LockIsolatedRecoveryFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	failoverId = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // lockUsersByAdmin(input: LockUsersByAdminInput!): Void
        internal void InitMutationLockUsersByAdmin()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "LockUsersByAdminInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationLockUsersByAdmin",
                "($input: LockUsersByAdminInput!)",
                "System.String",
                Mutation.LockUsersByAdmin,
                Mutation.LockUsersByAdminFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	userIds = @(
		$someString
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // logoutFromRubrikSupportPortal: SupportPortalLogoutReply!
        internal void InitMutationLogoutFromRubrikSupportPortal()
        {
            Tuple<string, string>[] argDefs = {
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationLogoutFromRubrikSupportPortal",
                "",
                "SupportPortalLogoutReply",
                Mutation.LogoutFromRubrikSupportPortal,
                Mutation.LogoutFromRubrikSupportPortalFieldSpec,
                @""
            );
        }

        // Create new GraphQL Mutation:
        // makePrimary(input: MakePrimaryInput!): AsyncRequestStatus!
        internal void InitMutationMakePrimary()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "MakePrimaryInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationMakePrimary",
                "($input: MakePrimaryInput!)",
                "AsyncRequestStatus",
                Mutation.MakePrimary,
                Mutation.MakePrimaryFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	hosts = @{
		# OPTIONAL
		ids = @(
			$someString
		)
		# OPTIONAL
		oldPrimaryClusterUuid = $someString
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // markNotificationsAsRead(input: MarkNotificationsAsReadInput!): MarkNotificationsAsReadReply!
        internal void InitMutationMarkNotificationsAsRead()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "MarkNotificationsAsReadInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationMarkNotificationsAsRead",
                "($input: MarkNotificationsAsReadInput!)",
                "MarkNotificationsAsReadReply",
                Mutation.MarkNotificationsAsRead,
                Mutation.MarkNotificationsAsReadFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	notificationIds = @(
		$someString
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // modifyEventDigestBatch(input: ModifyEventDigestBatchInput!): Void
        internal void InitMutationModifyEventDigestBatch()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "ModifyEventDigestBatchInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationModifyEventDigestBatch",
                "($input: ModifyEventDigestBatchInput!)",
                "System.String",
                Mutation.ModifyEventDigestBatch,
                Mutation.ModifyEventDigestBatchFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	digests = @(
		@{
			# OPTIONAL
			digestId = $someInt
			# REQUIRED
			digestName = $someString
			# REQUIRED
			frequencyHours = $someInt
			# REQUIRED
			isImmediate = $someBoolean
			# REQUIRED
			includeAudits = $someBoolean
			# REQUIRED
			includeEvents = $someBoolean
			# REQUIRED
			eventDigestConfig = @{
				# OPTIONAL
				objectType = @(
					$someActivityObjectTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ActivityObjectTypeEnum]) for enum values.
				)
				# OPTIONAL
				activityStatus = @(
					$someActivityStatusEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ActivityStatusEnum]) for enum values.
				)
				# OPTIONAL
				activityType = @(
					$someString
				)
				# OPTIONAL
				auditType = @(
					$someUserAuditTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UserAuditTypeEnum]) for enum values.
				)
				# OPTIONAL
				activitySeverity = @(
					$someActivitySeverityEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ActivitySeverityEnum]) for enum values.
				)
				# OPTIONAL
				clusters = @(
					$someString
				)
				# OPTIONAL
				emailAddresses = @(
					$someString
				)
			}
			# REQUIRED
			recipientUserId = $someString
			# REQUIRED
			clusterUuids = @(
				$someString
			)
		}
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // modifyIpmi(input: ModifyIpmiInput!): ModifyIpmiReply!
        internal void InitMutationModifyIpmi()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "ModifyIpmiInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationModifyIpmi",
                "($input: ModifyIpmiInput!)",
                "ModifyIpmiReply",
                Mutation.ModifyIpmi,
                Mutation.ModifyIpmiFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someString
	# REQUIRED
	updateProperties = @{
		# OPTIONAL
		password = $someString
		# OPTIONAL
		access = @{
			# OPTIONAL
			https = $someBoolean
			# OPTIONAL
			iKvm = $someBoolean
		}
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // mountDisk(input: MountDiskInput!): MountDiskReply!
        internal void InitMutationMountDisk()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "MountDiskInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationMountDisk",
                "($input: MountDiskInput!)",
                "MountDiskReply",
                Mutation.MountDisk,
                Mutation.MountDiskFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	snapshotId = $someString
	# REQUIRED
	targetWorkloadId = $someString
	# REQUIRED
	snapshotType = $someSnapshotType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SnapshotType]) for enum values.
	# REQUIRED
	mountDiskIds = @(
		$someString
	)
	# REQUIRED
	workloadType = $someCloudNativeObjectType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudNativeObjectType]) for enum values.
}"
            );
        }

        // Create new GraphQL Mutation:
        // notificationForGetLicense(input: NotificationForGetLicenseInput): NotificationForGetLicenseReply!
        internal void InitMutationNotificationForGetLicense()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "NotificationForGetLicenseInput"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationNotificationForGetLicense",
                "($input: NotificationForGetLicenseInput)",
                "NotificationForGetLicenseReply",
                Mutation.NotificationForGetLicense,
                Mutation.NotificationForGetLicenseFieldSpec,
                @"# OPTIONAL
$query.Var.input = @{
	# REQUIRED
	notificationType = $someGetLicenseNotificationRequest # Call [Enum]::GetValues([RubrikSecurityCloud.Types.GetLicenseNotificationRequest]) for enum values.
}"
            );
        }

        // Create new GraphQL Mutation:
        // promoteRecovery(input: PromoteRecoveryInput!): CreateOnDemandJobReply!
        internal void InitMutationPromoteRecovery()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "PromoteRecoveryInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationPromoteRecovery",
                "($input: PromoteRecoveryInput!)",
                "CreateOnDemandJobReply",
                Mutation.PromoteRecovery,
                Mutation.PromoteRecoveryFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	blueprintId = $someString
	# REQUIRED
	failoverId = $someString
	# OPTIONAL
	comments = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // recoverCloudDirectMultiPaths(input: RecoverCloudDirectMultiPathsInput!): AsyncRequestStatus!
        internal void InitMutationRecoverCloudDirectMultiPaths()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "RecoverCloudDirectMultiPathsInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationRecoverCloudDirectMultiPaths",
                "($input: RecoverCloudDirectMultiPathsInput!)",
                "AsyncRequestStatus",
                Mutation.RecoverCloudDirectMultiPaths,
                Mutation.RecoverCloudDirectMultiPathsFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	snapshotFid = $someString
	# REQUIRED
	restorePathPairList = @(
		@{
			# REQUIRED
			srcPath = $someString
			# REQUIRED
			dstPath = $someString
		}
	)
	# OPTIONAL
	dstExportId = $someInt
}"
            );
        }

        // Create new GraphQL Mutation:
        // recoverCloudDirectPath(input: RecoverCloudDirectPathInput!): AsyncRequestStatus!
        internal void InitMutationRecoverCloudDirectPath()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "RecoverCloudDirectPathInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationRecoverCloudDirectPath",
                "($input: RecoverCloudDirectPathInput!)",
                "AsyncRequestStatus",
                Mutation.RecoverCloudDirectPath,
                Mutation.RecoverCloudDirectPathFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	snapshotFid = $someString
	# REQUIRED
	srcPath = $someString
	# OPTIONAL
	dstPath = $someString
	# OPTIONAL
	dstExportId = $someInt
}"
            );
        }

        // Create new GraphQL Mutation:
        // refreshDomain(input: RefreshDomainInput!): AsyncRequestStatus!
        internal void InitMutationRefreshDomain()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "RefreshDomainInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationRefreshDomain",
                "($input: RefreshDomainInput!)",
                "AsyncRequestStatus",
                Mutation.RefreshDomain,
                Mutation.RefreshDomainFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // refreshGlobalManagerConnectivityStatus(clusterUuid: UUID!): GlobalManagerConnectivity!
        internal void InitMutationRefreshGlobalManagerConnectivityStatus()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("clusterUuid", "UUID!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationRefreshGlobalManagerConnectivityStatus",
                "($clusterUuid: UUID!)",
                "GlobalManagerConnectivity",
                Mutation.RefreshGlobalManagerConnectivityStatus,
                Mutation.RefreshGlobalManagerConnectivityStatusFieldSpec,
                @"# REQUIRED
$query.Var.clusterUuid = $someString"
            );
        }

        // Create new GraphQL Mutation:
        // refreshOrgNetwork(input: RefreshOrgNetworkInput!): Void
        internal void InitMutationRefreshOrgNetwork()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "RefreshOrgNetworkInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationRefreshOrgNetwork",
                "($input: RefreshOrgNetworkInput!)",
                "System.String",
                Mutation.RefreshOrgNetwork,
                Mutation.RefreshOrgNetworkFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	orgNetworkID = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // refreshVcdInstances(input: RefreshVcdInstancesInput!): RefreshVcdInstancesReply!
        internal void InitMutationRefreshVcdInstances()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "RefreshVcdInstancesInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationRefreshVcdInstances",
                "($input: RefreshVcdInstancesInput!)",
                "RefreshVcdInstancesReply",
                Mutation.RefreshVcdInstances,
                Mutation.RefreshVcdInstancesFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	inputs = @(
		@{
			# REQUIRED
			clusterUuid = $someString
			# REQUIRED
			id = $someString
		}
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // registerAndEnableMigrationChoice(input: RegisterAndEnableMigrationChoiceInput!): RegisterAndEnableMigrationReply!
        internal void InitMutationRegisterAndEnableMigrationChoice()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "RegisterAndEnableMigrationChoiceInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationRegisterAndEnableMigrationChoice",
                "($input: RegisterAndEnableMigrationChoiceInput!)",
                "RegisterAndEnableMigrationReply",
                Mutation.RegisterAndEnableMigrationChoice,
                Mutation.RegisterAndEnableMigrationChoiceFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	migrationChoice = $someMigrationChoice # Call [Enum]::GetValues([RubrikSecurityCloud.Types.MigrationChoice]) for enum values.
}"
            );
        }

        // Create new GraphQL Mutation:
        // removeDisk(input: RemoveDiskInput!): ResponseSuccess!
        internal void InitMutationRemoveDisk()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "RemoveDiskInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationRemoveDisk",
                "($input: RemoveDiskInput!)",
                "ResponseSuccess",
                Mutation.RemoveDisk,
                Mutation.RemoveDiskFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	diskId = $someString
	# REQUIRED
	id = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // removeInventoryWorkloads(input: RemoveInventoryWorkloadsInput!): Boolean!
        internal void InitMutationRemoveInventoryWorkloads()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "RemoveInventoryWorkloadsInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationRemoveInventoryWorkloads",
                "($input: RemoveInventoryWorkloadsInput!)",
                "System.Boolean",
                Mutation.RemoveInventoryWorkloads,
                Mutation.RemoveInventoryWorkloadsFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	inventoryCards = @(
		$someInventoryCard # Call [Enum]::GetValues([RubrikSecurityCloud.Types.InventoryCard]) for enum values.
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // removeNodeForReplacement(input: RemoveNodeForReplacementInput!): RemoveNodeForReplacementReply!
        internal void InitMutationRemoveNodeForReplacement()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "RemoveNodeForReplacementInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationRemoveNodeForReplacement",
                "($input: RemoveNodeForReplacementInput!)",
                "RemoveNodeForReplacementReply",
                Mutation.RemoveNodeForReplacement,
                Mutation.RemoveNodeForReplacementFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	nodeIds = @(
		$someString
	)
	# OPTIONAL
	useQuickDrain = $someBoolean
	# REQUIRED
	clusterUuid = $someString
	# OPTIONAL
	nodeMetadata = @(
		@{
			# OPTIONAL
			nodeId = $someString
			# OPTIONAL
			chassisId = $someString
			# OPTIONAL
			platform = $someClusterNodePlatformType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ClusterNodePlatformType]) for enum values.
			# OPTIONAL
			status = $someClusterNodeStatus # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ClusterNodeStatus]) for enum values.
			# OPTIONAL
			useQuickDrain = $someBoolean
		}
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // removePrivateEndpointConnection(input: RemovePrivateEndpointConnectionInput!): Void
        internal void InitMutationRemovePrivateEndpointConnection()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "RemovePrivateEndpointConnectionInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationRemovePrivateEndpointConnection",
                "($input: RemovePrivateEndpointConnectionInput!)",
                "System.String",
                Mutation.RemovePrivateEndpointConnection,
                Mutation.RemovePrivateEndpointConnectionFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	locationId = $someString
	# REQUIRED
	privateEndpointId = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // removeProxyConfig(input: RemoveProxyConfigInput!): ResponseSuccess!
        internal void InitMutationRemoveProxyConfig()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "RemoveProxyConfigInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationRemoveProxyConfig",
                "($input: RemoveProxyConfigInput!)",
                "ResponseSuccess",
                Mutation.RemoveProxyConfig,
                Mutation.RemoveProxyConfigFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	clusterUuid = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // removeVlans(input: RemoveVlansInput!): RemoveVlansReply!
        internal void InitMutationRemoveVlans()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "RemoveVlansInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationRemoveVlans",
                "($input: RemoveVlansInput!)",
                "RemoveVlansReply",
                Mutation.RemoveVlans,
                Mutation.RemoveVlansFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someString
	# REQUIRED
	vlanIds = @(
		$someInt
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // reseedLogShippingSecondary(input: ReseedLogShippingSecondaryInput!): AsyncRequestStatus!
        internal void InitMutationReseedLogShippingSecondary()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "ReseedLogShippingSecondaryInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationReseedLogShippingSecondary",
                "($input: ReseedLogShippingSecondaryInput!)",
                "AsyncRequestStatus",
                Mutation.ReseedLogShippingSecondary,
                Mutation.ReseedLogShippingSecondaryFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	config = @{
		# OPTIONAL
		mssqlLogShippingTargetStateOptions = @{
			# OPTIONAL
			shouldDisconnectStandbyUsers = $someBoolean
			# REQUIRED
			state = $someMssqlLogShippingOkState # Call [Enum]::GetValues([RubrikSecurityCloud.Types.MssqlLogShippingOkState]) for enum values.
		}
	}
	# REQUIRED
	id = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // resetAllOrgUsersPasswords: Void
        internal void InitMutationResetAllOrgUsersPasswords()
        {
            Tuple<string, string>[] argDefs = {
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationResetAllOrgUsersPasswords",
                "",
                "System.String",
                Mutation.ResetAllOrgUsersPasswords,
                Mutation.ResetAllOrgUsersPasswordsFieldSpec,
                @""
            );
        }

        // Create new GraphQL Mutation:
        // resetMigrationOnModeChange(input: ResetMigrationOnModeChangeInput!): ResetMigrationOnModeChangeReply!
        internal void InitMutationResetMigrationOnModeChange()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "ResetMigrationOnModeChangeInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationResetMigrationOnModeChange",
                "($input: ResetMigrationOnModeChangeInput!)",
                "ResetMigrationOnModeChangeReply",
                Mutation.ResetMigrationOnModeChange,
                Mutation.ResetMigrationOnModeChangeFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	clusterUuid = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // resetPasskeys(userId: String!): Void
        internal void InitMutationResetPasskeys()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("userId", "String!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationResetPasskeys",
                "($userId: String!)",
                "System.String",
                Mutation.ResetPasskeys,
                Mutation.ResetPasskeysFieldSpec,
                @"# REQUIRED
$query.Var.userId = $someString"
            );
        }

        // Create new GraphQL Mutation:
        // resetUsersPasswordsWithUserIds(input: ResetUsersPasswordsWithUserIdsInput!): Void
        internal void InitMutationResetUsersPasswordsWithUserIds()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "ResetUsersPasswordsWithUserIdsInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationResetUsersPasswordsWithUserIds",
                "($input: ResetUsersPasswordsWithUserIdsInput!)",
                "System.String",
                Mutation.ResetUsersPasswordsWithUserIds,
                Mutation.ResetUsersPasswordsWithUserIdsFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	userIds = @(
		$someString
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // resizeDisk(input: ResizeDiskInput!): ResponseSuccess!
        internal void InitMutationResizeDisk()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "ResizeDiskInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationResizeDisk",
                "($input: ResizeDiskInput!)",
                "ResponseSuccess",
                Mutation.ResizeDisk,
                Mutation.ResizeDiskFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	diskId = $someString
	# REQUIRED
	id = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // resolveAnomaly(input: ResolveAnomalyInput!): Void
        internal void InitMutationResolveAnomaly()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "ResolveAnomalyInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationResolveAnomaly",
                "($input: ResolveAnomalyInput!)",
                "System.String",
                Mutation.ResolveAnomaly,
                Mutation.ResolveAnomalyFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	anomalyType = $someAnomalyType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AnomalyType]) for enum values.
	# REQUIRED
	workloadId = $someString
	# REQUIRED
	anomalyId = $someString
	# OPTIONAL
	falsePositiveReport = @{
		# REQUIRED
		falsePositiveType = $someAnomalyFalsePositiveType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AnomalyFalsePositiveType]) for enum values.
		# OPTIONAL
		otherReason = $someString
	}
	# OPTIONAL
	directoriesToSnooze = @(
		$someString
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // resolveVolumeGroupsConflict(input: ResolveVolumeGroupsConflictInput!): RequestSuccess!
        internal void InitMutationResolveVolumeGroupsConflict()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "ResolveVolumeGroupsConflictInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationResolveVolumeGroupsConflict",
                "($input: ResolveVolumeGroupsConflictInput!)",
                "RequestSuccess",
                Mutation.ResolveVolumeGroupsConflict,
                Mutation.ResolveVolumeGroupsConflictFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	clusterUuid = $someString
	# REQUIRED
	id = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // restoreConfigProtectionBackup(input: RestoreConfigProtectionBackupInput!): AsyncJobStatus!
        internal void InitMutationRestoreConfigProtectionBackup()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "RestoreConfigProtectionBackupInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationRestoreConfigProtectionBackup",
                "($input: RestoreConfigProtectionBackupInput!)",
                "AsyncJobStatus",
                Mutation.RestoreConfigProtectionBackup,
                Mutation.RestoreConfigProtectionBackupFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	backupClusterUuid = $someString
	# REQUIRED
	restoreBackupRequestDetails = @{
		# REQUIRED
		clusterUuid = $someString
		# REQUIRED
		configRestoreRequest = @{
			# OPTIONAL
			isSourceSafe = $someBoolean
			# REQUIRED
			backupFileName = $someString
			# REQUIRED
			customizedRestoreForm = @{
				# REQUIRED
				configurationTypes = @(
					$someConfigurationTypes # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ConfigurationTypes]) for enum values.
				)
				# REQUIRED
				configurations = @{
					# OPTIONAL
					guestOsCredentials = @(
						@{
							# OPTIONAL
							password = $someString
							# OPTIONAL
							restoreFormConfigurationGuestOs = @{
								# OPTIONAL
								domain = $someString
								# REQUIRED
								username = $someString
							}
						}
					)
					# OPTIONAL
					kmipClient = @{
						# OPTIONAL
						password = $someString
						# OPTIONAL
						username = $someString
					}
					# OPTIONAL
					kmipServers = @(
						@{
							# REQUIRED
							serverAddress = $someString
						}
					)
					# OPTIONAL
					ldapServers = @(
						@{
							# OPTIONAL
							bindUserName = $someString
							# OPTIONAL
							bindUserPassword = $someString
							# OPTIONAL
							restoreFormConfigurationLdapServer = @{
								# REQUIRED
								name = $someString
							}
						}
					)
					# OPTIONAL
					nasHosts = @(
						@{
							# OPTIONAL
							apiPassword = $someString
							# OPTIONAL
							sharePassword = $someString
							# OPTIONAL
							shareUsername = $someString
							# OPTIONAL
							restoreFormConfigurationNasHost = @{
								# REQUIRED
								hostname = $someString
							}
							# OPTIONAL
							shares = @(
								@{
									# OPTIONAL
									password = $someString
									# OPTIONAL
									username = $someString
									# OPTIONAL
									restoreFormConfigurationNasShare = @{
										# REQUIRED
										exportPoint = $someString
									}
								}
							)
						}
					)
					# OPTIONAL
					objectStoreArchivalLocations = @(
						@{
							# OPTIONAL
							pemFileContent = $someString
							# OPTIONAL
							secretKey = $someString
							# OPTIONAL
							accessKey = $someString
							# OPTIONAL
							shouldRecoverSnappableMetadataOnly = $someBoolean
							# OPTIONAL
							restoreFormConfigurationObjectStoreArchivalLocation = @{
								# OPTIONAL
								bucket = $someString
								# OPTIONAL
								encryptionType = $someString
								# OPTIONAL
								endpoint = $someString
								# OPTIONAL
								numBuckets = $someInt64
								# REQUIRED
								name = $someString
							}
						}
					)
					# OPTIONAL
					organizations = @(
						@{
							# REQUIRED
							name = $someString
						}
					)
					# OPTIONAL
					replicationTargets = @(
						@{
							# OPTIONAL
							caCerts = $someString
							# REQUIRED
							password = $someString
							# OPTIONAL
							restoreFormConfigurationReplicationTarget = @{
								# OPTIONAL
								targetClusterName = $someString
								# REQUIRED
								targetClusterAddress = $someString
							}
							# REQUIRED
							username = $someString
						}
					)
					# OPTIONAL
					reports = @(
						@{
							# REQUIRED
							name = $someString
						}
					)
					# OPTIONAL
					roles = @(
						@{
							# REQUIRED
							name = $someString
							# REQUIRED
							organizationName = $someString
						}
					)
					# OPTIONAL
					s3ArchivalLocations = @(
						@{
							# OPTIONAL
							kmsMasterKeyId = $someString
							# OPTIONAL
							pemFileContent = $someString
							# OPTIONAL
							secretKey = $someString
							# OPTIONAL
							accessKey = $someString
							# OPTIONAL
							encryptionPassword = $someString
							# OPTIONAL
							shouldRecoverSnappableMetadataOnly = $someBoolean
							# OPTIONAL
							archivalProxyConfig = @{
								# OPTIONAL
								password = $someString
								# OPTIONAL
								userName = $someString
								# OPTIONAL
								restoreFormArchivalProxyConfig = @{
									# OPTIONAL
									proxyServer = $someString
								}
							}
							# OPTIONAL
							computeProxyConfig = @{
								# OPTIONAL
								password = $someString
								# OPTIONAL
								userName = $someString
								# OPTIONAL
								restoreFormComputeProxyConfig = @{
									# OPTIONAL
									proxyServer = $someString
								}
							}
							# OPTIONAL
							restoreFormConfigurationS3ArchivalLocation = @{
								# OPTIONAL
								bucket = $someString
								# OPTIONAL
								defaultRegion = $someString
								# OPTIONAL
								encryptionType = $someString
								# OPTIONAL
								cloudRehydrationSpeed = $someString
								# OPTIONAL
								storageClass = $someString
								# OPTIONAL
								archivalProxyConfig = @{
									# OPTIONAL
									proxyServer = $someString
								}
								# OPTIONAL
								computeProxyConfig = @{
									# OPTIONAL
									proxyServer = $someString
								}
								# REQUIRED
								name = $someString
							}
						}
					)
					# OPTIONAL
					slaDomains = @(
						@{
							# REQUIRED
							name = $someString
						}
					)
					# OPTIONAL
					smtpSettings = @(
						@{
							# OPTIONAL
							smtpPassword = $someString
							# OPTIONAL
							smtpUsername = $someString
							# OPTIONAL
							restoreFormConfigurationSmtp = @{
								# REQUIRED
								fromEmailId = $someString
								# REQUIRED
								smtpHostname = $someString
								# REQUIRED
								smtpPort = $someInt64
							}
						}
					)
					# OPTIONAL
					snmpSettings = @(
						@{
							# OPTIONAL
							authPassword = $someString
							# OPTIONAL
							privPassword = $someString
							# OPTIONAL
							restoreFormConfigurationSnmp = @{
								# REQUIRED
								username = $someString
							}
						}
					)
					# OPTIONAL
					users = @(
						@{
							# OPTIONAL
							password = $someString
							# OPTIONAL
							restoreFormConfigurationUser = @{
								# REQUIRED
								username = $someString
							}
						}
					)
					# OPTIONAL
					vcenterServers = @(
						@{
							# OPTIONAL
							password = $someString
							# OPTIONAL
							username = $someString
							# OPTIONAL
							restoreFormConfigurationVcenterServer = @{
								# REQUIRED
								hostname = $someString
							}
						}
					)
					# OPTIONAL
					winAndUnixHosts = @(
						@{
							# REQUIRED
							hostname = $someString
						}
					)
				}
			}
			# REQUIRED
			encryptionPassword = $someString
		}
	}
	# OPTIONAL
	caSignedCsr = $someString
	# OPTIONAL
	useDefaultConfigurations = $someBoolean
}"
            );
        }

        // Create new GraphQL Mutation:
        // retryBackup(backupObjects: [BackupObject!]!, backupRunConfig: BackupRunConfig): RetryBackupResp!
        internal void InitMutationRetryBackup()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("backupObjects", "[BackupObject!]!"),
                Tuple.Create("backupRunConfig", "BackupRunConfig"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationRetryBackup",
                "($backupObjects: [BackupObject!]!,$backupRunConfig: BackupRunConfig)",
                "RetryBackupResp",
                Mutation.RetryBackup,
                Mutation.RetryBackupFieldSpec,
                @"# REQUIRED
$query.Var.backupObjects = @(
	@{
		# OPTIONAL
		objectFid = $someString
		# OPTIONAL
		eventSeriesId = $someString
		# OPTIONAL
		monitoringId = $someString
}
)
# OPTIONAL
$query.Var.backupRunConfig = @{
	# OPTIONAL
	runNow = $someBoolean
}"
            );
        }

        // Create new GraphQL Mutation:
        // retryDownloadPackageJob(clusterUuid: UUID!): DownloadPackageReply!
        internal void InitMutationRetryDownloadPackageJob()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("clusterUuid", "UUID!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationRetryDownloadPackageJob",
                "($clusterUuid: UUID!)",
                "DownloadPackageReply",
                Mutation.RetryDownloadPackageJob,
                Mutation.RetryDownloadPackageJobFieldSpec,
                @"# REQUIRED
$query.Var.clusterUuid = $someString"
            );
        }

        // Create new GraphQL Mutation:
        // revokeAllOrgRoles(input: RevokeAllOrgRolesInput!): Void
        internal void InitMutationRevokeAllOrgRoles()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "RevokeAllOrgRolesInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationRevokeAllOrgRoles",
                "($input: RevokeAllOrgRolesInput!)",
                "System.String",
                Mutation.RevokeAllOrgRoles,
                Mutation.RevokeAllOrgRolesFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	userIds = @(
		$someString
	)
	# OPTIONAL
	groupIds = @(
		$someString
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // runCustomAnalyzer(input: RunCustomAnalyzerInput!): RunCustomAnalyzerReply!
        internal void InitMutationRunCustomAnalyzer()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "RunCustomAnalyzerInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationRunCustomAnalyzer",
                "($input: RunCustomAnalyzerInput!)",
                "RunCustomAnalyzerReply",
                Mutation.RunCustomAnalyzer,
                Mutation.RunCustomAnalyzerFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	dictionaryCsv = $someString
	# OPTIONAL
	regex = $someString
	# OPTIONAL
	content = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // runPrechecks(input: RunPrechecksInput!): BatchAsyncJobStatus!
        internal void InitMutationRunPrechecks()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "RunPrechecksInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationRunPrechecks",
                "($input: RunPrechecksInput!)",
                "BatchAsyncJobStatus",
                Mutation.RunPrechecks,
                Mutation.RunPrechecksFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	clusterUuid = $someString
	# REQUIRED
	precheckNames = @(
		$somePrecheckName # Call [Enum]::GetValues([RubrikSecurityCloud.Types.PrecheckName]) for enum values.
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // scheduleUpgradeBatchJob(
        //     listClusterUuid: [UUID!]!
        //     mode: String!
        //     action: ActionType!
        //     version: String!
        //     scheduleAt: DateTime!
        //     context_tag: String = "{\"client\": \"polaris\"}"
        //   ): [UpgradeJobReplyWithUuid!]!
        internal void InitMutationScheduleUpgradeBatchJob()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("listClusterUuid", "[UUID!]!"),
                Tuple.Create("mode", "String!"),
                Tuple.Create("action", "ActionType!"),
                Tuple.Create("version", "String!"),
                Tuple.Create("scheduleAt", "DateTime!"),
                Tuple.Create("context_tag", "String"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationScheduleUpgradeBatchJob",
                "($listClusterUuid: [UUID!]!,$mode: String!,$action: ActionType!,$version: String!,$scheduleAt: DateTime!,$context_tag: String)",
                "List<UpgradeJobReplyWithUuid>",
                Mutation.ScheduleUpgradeBatchJob,
                Mutation.ScheduleUpgradeBatchJobFieldSpec,
                @"# REQUIRED
$query.Var.listClusterUuid = @(
	$someString
)
# REQUIRED
$query.Var.mode = $someString
# REQUIRED
$query.Var.action = $someActionType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ActionType]) for enum values.
# REQUIRED
$query.Var.version = $someString
# REQUIRED
$query.Var.scheduleAt = $someDateTime
# OPTIONAL
$query.Var.context_tag = $someString"
            );
        }

        // Create new GraphQL Mutation:
        // sendEmailNow(reportID: Int!, reportConfig: ReportConfigInput, recipients: [String!]!): reportGenerateReply!
        internal void InitMutationSendEmailNow()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("reportID", "Int!"),
                Tuple.Create("reportConfig", "ReportConfigInput"),
                Tuple.Create("recipients", "[String!]!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationSendEmailNow",
                "($reportID: Int!,$reportConfig: ReportConfigInput,$recipients: [String!]!)",
                "ReportGenerateReply",
                Mutation.SendEmailNow,
                Mutation.SendEmailNowFieldSpec,
                @"# REQUIRED
$query.Var.reportID = $someInt
# OPTIONAL
$query.Var.reportConfig = @{
	# REQUIRED
	name = $someString
	# REQUIRED
	dataViewType = $someDataViewTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DataViewTypeEnum]) for enum values.
	# REQUIRED
	columns = @(
		$someString
	)
	# REQUIRED
	groupBy = @{
		# REQUIRED
		groupById = $someString
		# REQUIRED
		aggregations = @(
			$someString
		)
	}
	# REQUIRED
	aggregations = @(
		$someString
	)
	# REQUIRED
	filters = @(
		@{
			# REQUIRED
			name = $someString
			# REQUIRED
			values = @(
				$someString
			)
		}
	)
	# REQUIRED
	sortBy = $someString
	# OPTIONAL
	sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
}
# REQUIRED
$query.Var.recipients = @(
	$someString
)"
            );
        }

        // Create new GraphQL Mutation:
        // sendPactsafeEvent(input: SendPactsafeEventInput!): Void
        internal void InitMutationSendPactsafeEvent()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "SendPactsafeEventInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationSendPactsafeEvent",
                "($input: SendPactsafeEventInput!)",
                "System.String",
                Mutation.SendPactsafeEvent,
                Mutation.SendPactsafeEventFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	contractType = $someContractType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ContractType]) for enum values.
	# REQUIRED
	versionId = $someString
	# REQUIRED
	event = $somePactsafeEvent # Call [Enum]::GetValues([RubrikSecurityCloud.Types.PactsafeEvent]) for enum values.
	# OPTIONAL
	customData = @{
		# REQUIRED
		firstName = $someString
		# REQUIRED
		lastName = $someString
		# REQUIRED
		company = $someString
		# REQUIRED
		title = $someString
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // sendTestSmtpEmail(
        //     useExisting: Boolean!
        //     recipient: String!
        //     hostName: String
        //     port: Int
        //     userName: String
        //     password: String
        //     defaultFromEmail: String
        //     securityType: SMTPSecurityTypeEnum
        //     trustedCertId: Long
        //   ): Boolean!
        internal void InitMutationSendTestSmtpEmail()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("useExisting", "Boolean!"),
                Tuple.Create("recipient", "String!"),
                Tuple.Create("hostName", "String"),
                Tuple.Create("port", "Int"),
                Tuple.Create("userName", "String"),
                Tuple.Create("password", "String"),
                Tuple.Create("defaultFromEmail", "String"),
                Tuple.Create("securityType", "SMTPSecurityTypeEnum"),
                Tuple.Create("trustedCertId", "Long"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationSendTestSmtpEmail",
                "($useExisting: Boolean!,$recipient: String!,$hostName: String,$port: Int,$userName: String,$password: String,$defaultFromEmail: String,$securityType: SMTPSecurityTypeEnum,$trustedCertId: Long)",
                "System.Boolean",
                Mutation.SendTestSmtpEmail,
                Mutation.SendTestSmtpEmailFieldSpec,
                @"# REQUIRED
$query.Var.useExisting = $someBoolean
# REQUIRED
$query.Var.recipient = $someString
# OPTIONAL
$query.Var.hostName = $someString
# OPTIONAL
$query.Var.port = $someInt
# OPTIONAL
$query.Var.userName = $someString
# OPTIONAL
$query.Var.password = $someString
# OPTIONAL
$query.Var.defaultFromEmail = $someString
# OPTIONAL
$query.Var.securityType = $someSMTPSecurityTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SMTPSecurityTypeEnum]) for enum values.
# OPTIONAL
$query.Var.trustedCertId = $someInt64"
            );
        }

        // Create new GraphQL Mutation:
        // setAccountSettingValue(aspName: String!, aspComponent: ComponentEnum!, aspValue: String!): ASPValue!
        internal void InitMutationSetAccountSettingValue()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("aspName", "String!"),
                Tuple.Create("aspComponent", "ComponentEnum!"),
                Tuple.Create("aspValue", "String!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationSetAccountSettingValue",
                "($aspName: String!,$aspComponent: ComponentEnum!,$aspValue: String!)",
                "AspValue",
                Mutation.SetAccountSettingValue,
                Mutation.SetAccountSettingValueFieldSpec,
                @"# REQUIRED
$query.Var.aspName = $someString
# REQUIRED
$query.Var.aspComponent = $someComponentEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ComponentEnum]) for enum values.
# REQUIRED
$query.Var.aspValue = $someString"
            );
        }

        // Create new GraphQL Mutation:
        // setAnalyzerRisks(input: SetAnalyzerRisksInput!): SetAnalyzerRisksReply!
        internal void InitMutationSetAnalyzerRisks()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "SetAnalyzerRisksInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationSetAnalyzerRisks",
                "($input: SetAnalyzerRisksInput!)",
                "SetAnalyzerRisksReply",
                Mutation.SetAnalyzerRisks,
                Mutation.SetAnalyzerRisksFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	risks = @(
		@{
			# OPTIONAL
			analyzerId = $someString
			# OPTIONAL
			risk = $someRiskLevelType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RiskLevelType]) for enum values.
		}
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // setBrandLogo(input: SetBrandLogoInput!): Void
        internal void InitMutationSetBrandLogo()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "SetBrandLogoInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationSetBrandLogo",
                "($input: SetBrandLogoInput!)",
                "System.String",
                Mutation.SetBrandLogo,
                Mutation.SetBrandLogoFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	imageBase64 = $someString
	# OPTIONAL
	fileName = $someString
	# OPTIONAL
	fileSizeBytes = $someInt
	# OPTIONAL
	isUrlEnabled = $someBoolean
	# OPTIONAL
	url = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // setBundleApprovalStatus(input: SetBundleApprovalStatusInput!): Void
        internal void InitMutationSetBundleApprovalStatus()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "SetBundleApprovalStatusInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationSetBundleApprovalStatus",
                "($input: SetBundleApprovalStatusInput!)",
                "System.String",
                Mutation.SetBundleApprovalStatus,
                Mutation.SetBundleApprovalStatusFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	bundleVersion = $someString
	# REQUIRED
	approvalStatus = $someExoBundleApprovalStatus # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ExoBundleApprovalStatus]) for enum values.
	# OPTIONAL
	bundleMetadata = @{
		# OPTIONAL
		eksVersion = $someString
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // setCorsSetting(input: SetCorsSettingInput): CorsSetting!
        internal void InitMutationSetCorsSetting()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "SetCorsSettingInput"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationSetCorsSetting",
                "($input: SetCorsSettingInput)",
                "CorsSetting",
                Mutation.SetCorsSetting,
                Mutation.SetCorsSettingFieldSpec,
                @"# OPTIONAL
$query.Var.input = @{
	# OPTIONAL
	isEnabled = $someBoolean
	# OPTIONAL
	allowedOrigins = @(
		$someString
	)
	# OPTIONAL
	allowedHeaders = @(
		$someString
	)
	# OPTIONAL
	allowedMethods = @(
		$someHttpMethod # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HttpMethod]) for enum values.
	)
	# OPTIONAL
	allowedPaths = @(
		$someString
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // setCustomerTags(input: SetCustomerTagsInput!): Void
        internal void InitMutationSetCustomerTags()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "SetCustomerTagsInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationSetCustomerTags",
                "($input: SetCustomerTagsInput!)",
                "System.String",
                Mutation.SetCustomerTags,
                Mutation.SetCustomerTagsFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	cloudVendor = $someCloudVendor # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudVendor]) for enum values.
	# REQUIRED
	customerTags = @{
		# REQUIRED
		tagList = @(
			@{
				# REQUIRED
				key = $someString
				# REQUIRED
				value = $someString
			}
		)
	}
	# REQUIRED
	shouldOverrideResourceTags = $someBoolean
}"
            );
        }

        // Create new GraphQL Mutation:
        // setDatastoreFreespaceThresholds(input: SetDatastoreFreespaceThresholdsInput!): SetDatastoreFreespaceThresholdsReply!
        internal void InitMutationSetDatastoreFreespaceThresholds()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "SetDatastoreFreespaceThresholdsInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationSetDatastoreFreespaceThresholds",
                "($input: SetDatastoreFreespaceThresholdsInput!)",
                "SetDatastoreFreespaceThresholdsReply",
                Mutation.SetDatastoreFreespaceThresholds,
                Mutation.SetDatastoreFreespaceThresholdsFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	thresholds = @(
		@{
			# REQUIRED
			clusterUuid = $someString
			# REQUIRED
			datastoreFreespaceThreshold = @{
				# OPTIONAL
				vmId = $someString
				# REQUIRED
				threshold = $someSingle
			}
		}
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // setFederatedLoginStatus(federatedLoginStatusArg: FederatedLoginStatusInput!): Boolean!
        internal void InitMutationSetFederatedLoginStatus()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("federatedLoginStatusArg", "FederatedLoginStatusInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationSetFederatedLoginStatus",
                "($federatedLoginStatusArg: FederatedLoginStatusInput!)",
                "System.Boolean",
                Mutation.SetFederatedLoginStatus,
                Mutation.SetFederatedLoginStatusFieldSpec,
                @"# REQUIRED
$query.Var.federatedLoginStatusArg = @{
	# REQUIRED
	enabled = $someBoolean
	# REQUIRED
	inventoryCardEnabled = $someBoolean
}"
            );
        }

        // Create new GraphQL Mutation:
        // setIdentityProvider(
        //     entityId: String!
        //     signInUrl: String!
        //     signingCertificate: String!
        //     metadataJson: String
        //     isTemp: Boolean
        //   ): IdentityProvider!
        internal void InitMutationSetIdentityProvider()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("entityId", "String!"),
                Tuple.Create("signInUrl", "String!"),
                Tuple.Create("signingCertificate", "String!"),
                Tuple.Create("metadataJson", "String"),
                Tuple.Create("isTemp", "Boolean"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationSetIdentityProvider",
                "($entityId: String!,$signInUrl: String!,$signingCertificate: String!,$metadataJson: String,$isTemp: Boolean)",
                "IdentityProvider",
                Mutation.SetIdentityProvider,
                Mutation.SetIdentityProviderFieldSpec,
                @"# REQUIRED
$query.Var.entityId = $someString
# REQUIRED
$query.Var.signInUrl = $someString
# REQUIRED
$query.Var.signingCertificate = $someString
# OPTIONAL
$query.Var.metadataJson = $someString
# OPTIONAL
$query.Var.isTemp = $someBoolean"
            );
        }

        // Create new GraphQL Mutation:
        // setIpWhitelistEnabled(enabled: Boolean!): Boolean!
        internal void InitMutationSetIpWhitelistEnabled()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("enabled", "Boolean!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationSetIpWhitelistEnabled",
                "($enabled: Boolean!)",
                "System.Boolean",
                Mutation.SetIpWhitelistEnabled,
                Mutation.SetIpWhitelistEnabledFieldSpec,
                @"# REQUIRED
$query.Var.enabled = $someBoolean"
            );
        }

        // Create new GraphQL Mutation:
        // setKmipClient(input: SetKmipClientInput!): AsyncRequestStatus!
        internal void InitMutationSetKmipClient()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "SetKmipClientInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationSetKmipClient",
                "($input: SetKmipClientInput!)",
                "AsyncRequestStatus",
                Mutation.SetKmipClient,
                Mutation.SetKmipClientFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	config = @{
		# OPTIONAL
		clientCertificate = $someString
		# OPTIONAL
		password = $someString
		# OPTIONAL
		clientCertificateId = $someString
		# REQUIRED
		username = $someString
	}
	# REQUIRED
	id = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // setLiveMountIps(input: SetLiveMountIpsInput!): Void
        internal void InitMutationSetLiveMountIps()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "SetLiveMountIpsInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationSetLiveMountIps",
                "($input: SetLiveMountIpsInput!)",
                "System.String",
                Mutation.SetLiveMountIps,
                Mutation.SetLiveMountIpsFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	orgNetworkID = $someString
	# REQUIRED
	liveMountIps = @(
		$someString
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // setMfaSetting(input: SetMfaSettingInput!): Boolean!
        internal void InitMutationSetMfaSetting()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "SetMfaSettingInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationSetMfaSetting",
                "($input: SetMfaSettingInput!)",
                "System.Boolean",
                Mutation.SetMfaSetting,
                Mutation.SetMfaSettingFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	isTotpEnforcedGlobal = $someBoolean
	# OPTIONAL
	totpReminderHours = $someInt
	# OPTIONAL
	mfaRememberHours = $someInt
	# OPTIONAL
	passkeyConfig = @{
		# REQUIRED
		passkeysAllowed = $someBoolean
		# REQUIRED
		platformPasskeyAllowed = $someBoolean
		# REQUIRED
		roamingPasskeyAllowed = $someBoolean
		# REQUIRED
		maxPasskeysAllowed = $someInt
	}
	# OPTIONAL
	deletePasskeys = $someBoolean
}"
            );
        }

        // Create new GraphQL Mutation:
        // setMigrationStatus(input: SetMigrationStatusInput!): SetMigrationStatusReply!
        internal void InitMutationSetMigrationStatus()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "SetMigrationStatusInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationSetMigrationStatus",
                "($input: SetMigrationStatusInput!)",
                "SetMigrationStatusReply",
                Mutation.SetMigrationStatus,
                Mutation.SetMigrationStatusFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	clusterUuid = $someString
	# REQUIRED
	precheckName = $somePrecheckName # Call [Enum]::GetValues([RubrikSecurityCloud.Types.PrecheckName]) for enum values.
	# REQUIRED
	migrationStatus = $someMigrationStatus # Call [Enum]::GetValues([RubrikSecurityCloud.Types.MigrationStatus]) for enum values.
}"
            );
        }

        // Create new GraphQL Mutation:
        // setPasskeyConfig(input: SetPasskeyConfigInput!): SetPasskeyConfigReply!
        internal void InitMutationSetPasskeyConfig()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "SetPasskeyConfigInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationSetPasskeyConfig",
                "($input: SetPasskeyConfigInput!)",
                "SetPasskeyConfigReply",
                Mutation.SetPasskeyConfig,
                Mutation.SetPasskeyConfigFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	passkeyConfig = @{
		# REQUIRED
		passkeysAllowed = $someBoolean
		# REQUIRED
		platformPasskeyAllowed = $someBoolean
		# REQUIRED
		roamingPasskeyAllowed = $someBoolean
		# REQUIRED
		maxPasskeysAllowed = $someInt
	}
	# REQUIRED
	deletePasskeys = $someBoolean
}"
            );
        }

        // Create new GraphQL Mutation:
        // setPrivateContainerRegistry(input: SetPrivateContainerRegistryInput!): Void
        internal void InitMutationSetPrivateContainerRegistry()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "SetPrivateContainerRegistryInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationSetPrivateContainerRegistry",
                "($input: SetPrivateContainerRegistryInput!)",
                "System.String",
                Mutation.SetPrivateContainerRegistry,
                Mutation.SetPrivateContainerRegistryFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	exocomputeAccountId = $someString
	# REQUIRED
	registryUrl = $someString
	# OPTIONAL
	pcrAwsImagePullDetails = @{
		# OPTIONAL
		awsNativeId = $someString
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // setSmtpConfiguration(
        //     hostName: String!
        //     port: Int!
        //     userName: String!
        //     password: String!
        //     defaultFromEmail: String!
        //     securityType: SMTPSecurityTypeEnum!
        //     trustedCertId: Long!
        //   ): Boolean!
        internal void InitMutationSetSmtpConfiguration()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("hostName", "String!"),
                Tuple.Create("port", "Int!"),
                Tuple.Create("userName", "String!"),
                Tuple.Create("password", "String!"),
                Tuple.Create("defaultFromEmail", "String!"),
                Tuple.Create("securityType", "SMTPSecurityTypeEnum!"),
                Tuple.Create("trustedCertId", "Long!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationSetSmtpConfiguration",
                "($hostName: String!,$port: Int!,$userName: String!,$password: String!,$defaultFromEmail: String!,$securityType: SMTPSecurityTypeEnum!,$trustedCertId: Long!)",
                "System.Boolean",
                Mutation.SetSmtpConfiguration,
                Mutation.SetSmtpConfigurationFieldSpec,
                @"# REQUIRED
$query.Var.hostName = $someString
# REQUIRED
$query.Var.port = $someInt
# REQUIRED
$query.Var.userName = $someString
# REQUIRED
$query.Var.password = $someString
# REQUIRED
$query.Var.defaultFromEmail = $someString
# REQUIRED
$query.Var.securityType = $someSMTPSecurityTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SMTPSecurityTypeEnum]) for enum values.
# REQUIRED
$query.Var.trustedCertId = $someInt64"
            );
        }

        // Create new GraphQL Mutation:
        // setTotpConfig(input: SetTotpConfigInput!): Boolean!
        internal void InitMutationSetTotpConfig()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "SetTotpConfigInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationSetTotpConfig",
                "($input: SetTotpConfigInput!)",
                "System.Boolean",
                Mutation.SetTotpConfig,
                Mutation.SetTotpConfigFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	userId = $someString
	# OPTIONAL
	secret = $someString
	# OPTIONAL
	otp = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // setUpgradeType(input: SetUpgradeTypeInput!): SetUpgradeTypeReply!
        internal void InitMutationSetUpgradeType()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "SetUpgradeTypeInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationSetUpgradeType",
                "($input: SetUpgradeTypeInput!)",
                "SetUpgradeTypeReply",
                Mutation.SetUpgradeType,
                Mutation.SetUpgradeTypeFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	clusterUuid = $someString
	# REQUIRED
	upgradeType = $someUpgradeType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UpgradeType]) for enum values.
}"
            );
        }

        // Create new GraphQL Mutation:
        // setUserLevelTotpEnforcement(input: SetUserLevelTotpEnforcementInput!): Boolean!
        internal void InitMutationSetUserLevelTotpEnforcement()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "SetUserLevelTotpEnforcementInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationSetUserLevelTotpEnforcement",
                "($input: SetUserLevelTotpEnforcementInput!)",
                "System.Boolean",
                Mutation.SetUserLevelTotpEnforcement,
                Mutation.SetUserLevelTotpEnforcementFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	userIds = @(
		$someString
	)
	# OPTIONAL
	isEnforced = $someBoolean
}"
            );
        }

        // Create new GraphQL Mutation:
        // setUserSessionManagementConfig(input: SetUserSessionManagementConfigInput!): SetUserSessionManagementConfigReply!
        internal void InitMutationSetUserSessionManagementConfig()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "SetUserSessionManagementConfigInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationSetUserSessionManagementConfig",
                "($input: SetUserSessionManagementConfigInput!)",
                "SetUserSessionManagementConfigReply",
                Mutation.SetUserSessionManagementConfig,
                Mutation.SetUserSessionManagementConfigFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	isConcurrentSessionLimitationEnabled = $someBoolean
	# REQUIRED
	inactivityTimeoutInSeconds = $someInt64
	# REQUIRED
	isInactivityTimeoutEnabled = $someBoolean
	# REQUIRED
	maxConcurrentSessions = $someInt
	# REQUIRED
	sessionTimeoutInSeconds = $someInt64
}"
            );
        }

        // Create new GraphQL Mutation:
        // setUserSetting(userSetting: UserSettingInputType, isOrgSpecificSetting: Boolean!): UserSetting!
        internal void InitMutationSetUserSetting()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("userSetting", "UserSettingInputType"),
                Tuple.Create("isOrgSpecificSetting", "Boolean!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationSetUserSetting",
                "($userSetting: UserSettingInputType,$isOrgSpecificSetting: Boolean!)",
                "UserSetting",
                Mutation.SetUserSetting,
                Mutation.SetUserSettingFieldSpec,
                @"# OPTIONAL
$query.Var.userSetting = @{
	# OPTIONAL
	setting = $someString
	# OPTIONAL
	value = $someString
}
# REQUIRED
$query.Var.isOrgSpecificSetting = $someBoolean"
            );
        }

        // Create new GraphQL Mutation:
        // setWorkloadAlertSetting(input: SetWorkloadAlertSettingInput!): SetWorkloadAlertSettingReply!
        internal void InitMutationSetWorkloadAlertSetting()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "SetWorkloadAlertSettingInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationSetWorkloadAlertSetting",
                "($input: SetWorkloadAlertSettingInput!)",
                "SetWorkloadAlertSettingReply",
                Mutation.SetWorkloadAlertSetting,
                Mutation.SetWorkloadAlertSettingFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	clusterId = $someString
	# OPTIONAL
	workloadFid = $someString
	# OPTIONAL
	enabled = $someBoolean
}"
            );
        }

        // Create new GraphQL Mutation:
        // setWwwTlsCert(input: SetWwwTlsCertInputType!): Boolean!
        internal void InitMutationSetWwwTlsCert()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "SetWwwTlsCertInputType!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationSetWwwTlsCert",
                "($input: SetWwwTlsCertInputType!)",
                "System.Boolean",
                Mutation.SetWwwTlsCert,
                Mutation.SetWwwTlsCertFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	certificateId = $someInt64
}"
            );
        }

        // Create new GraphQL Mutation:
        // setupAtlassianSite(input: SetupAtlassianSiteInput!): SetupAtlassianSiteReply!
        internal void InitMutationSetupAtlassianSite()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "SetupAtlassianSiteInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationSetupAtlassianSite",
                "($input: SetupAtlassianSiteInput!)",
                "SetupAtlassianSiteReply",
                Mutation.SetupAtlassianSite,
                Mutation.SetupAtlassianSiteFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	siteId = $someString
	# REQUIRED
	siteName = $someString
	# OPTIONAL
	slaDomainId = $someString
	# REQUIRED
	storageRegion = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // setupDisk(input: SetupDiskInput!): DiskInfo!
        internal void InitMutationSetupDisk()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "SetupDiskInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationSetupDisk",
                "($input: SetupDiskInput!)",
                "DiskInfo",
                Mutation.SetupDisk,
                Mutation.SetupDiskFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	diskId = $someString
	# REQUIRED
	id = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // setupSalesforceOrganization(input: SetupSalesforceOrganizationInput!): SetupSalesforceOrganizationReply!
        internal void InitMutationSetupSalesforceOrganization()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "SetupSalesforceOrganizationInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationSetupSalesforceOrganization",
                "($input: SetupSalesforceOrganizationInput!)",
                "SetupSalesforceOrganizationReply",
                Mutation.SetupSalesforceOrganization,
                Mutation.SetupSalesforceOrganizationFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	orgNaturalId = $someString
	# REQUIRED
	orgName = $someString
	# OPTIONAL
	slaDomainId = $someString
	# REQUIRED
	storageRegion = $someString
	# REQUIRED
	apiLimits = @{
		# OPTIONAL
		restApiLimit = $someInt
		# OPTIONAL
		bulkApiLimit = $someInt
		# OPTIONAL
		bulkApiV2Limit = $someInt
	}
	# REQUIRED
	environmentType = $someSaasEnvironmentType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SaasEnvironmentType]) for enum values.
}"
            );
        }

        // Create new GraphQL Mutation:
        // snoozeEula(input: SnoozeEulaInput!): Void
        internal void InitMutationSnoozeEula()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "SnoozeEulaInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationSnoozeEula",
                "($input: SnoozeEulaInput!)",
                "System.String",
                Mutation.SnoozeEula,
                Mutation.SnoozeEulaFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	durationInDays = $someInt64
}"
            );
        }

        // Create new GraphQL Mutation:
        // startBlueprintFailover(failoverJobConfig: BlueprintFailoverJobConfig!): CreateOnDemandJobReply!
        internal void InitMutationStartBlueprintFailover()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("failoverJobConfig", "BlueprintFailoverJobConfig!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationStartBlueprintFailover",
                "($failoverJobConfig: BlueprintFailoverJobConfig!)",
                "CreateOnDemandJobReply",
                Mutation.StartBlueprintFailover,
                Mutation.StartBlueprintFailoverFieldSpec,
                @"# REQUIRED
$query.Var.failoverJobConfig = @{
	# REQUIRED
	blueprintId = $someString
	# OPTIONAL
	recoveryName = $someString
	# OPTIONAL
	targetLocationType = $someLocationType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.LocationType]) for enum values.
	# OPTIONAL
	targetLocationUuid = $someString
	# REQUIRED
	failoverType = $someString
	# OPTIONAL
	failoverFailureAction = $someString
	# OPTIONAL
	failoverOperation = $someString
	# OPTIONAL
	dataTransferType = $someDataTransferType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DataTransferType]) for enum values.
	# OPTIONAL
	childSnappableFailoverInfos = @(
		@{
			# REQUIRED
			snappableId = $someString
			# REQUIRED
			recoveryPoint = $someInt64
		}
	)
	# OPTIONAL
	failoverIgnorableErrors = @(
		$someBlueprintFailoverIgnorableError # Call [Enum]::GetValues([RubrikSecurityCloud.Types.BlueprintFailoverIgnorableError]) for enum values.
	)
	# OPTIONAL
	enableRecoveryWithRba = $someBoolean
	# OPTIONAL
	recoveryPlanId = $someString
	# OPTIONAL
	recoverySpecID = $someString
	# OPTIONAL
	isZeroRpo = $someBoolean
	# OPTIONAL
	timeoutInMinutes = $someInt
	# OPTIONAL
	updateRecoverySpecPostFailover = $someBoolean
	# OPTIONAL
	sourceWorkloadActionAfterFailover = $someSourceWorkloadActionAfterFailover # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SourceWorkloadActionAfterFailover]) for enum values.
}"
            );
        }

        // Create new GraphQL Mutation:
        // startBlueprintsFailover(failoverJobConfigs: [BlueprintFailoverJobConfig!]!): [CreateOnDemandJobReply!]!
        internal void InitMutationStartBlueprintsFailover()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("failoverJobConfigs", "[BlueprintFailoverJobConfig!]!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationStartBlueprintsFailover",
                "($failoverJobConfigs: [BlueprintFailoverJobConfig!]!)",
                "List<CreateOnDemandJobReply>",
                Mutation.StartBlueprintsFailover,
                Mutation.StartBlueprintsFailoverFieldSpec,
                @"# REQUIRED
$query.Var.failoverJobConfigs = @(
	@{
		# REQUIRED
		blueprintId = $someString
		# OPTIONAL
		recoveryName = $someString
		# OPTIONAL
		targetLocationType = $someLocationType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.LocationType]) for enum values.
		# OPTIONAL
		targetLocationUuid = $someString
		# REQUIRED
		failoverType = $someString
		# OPTIONAL
		failoverFailureAction = $someString
		# OPTIONAL
		failoverOperation = $someString
		# OPTIONAL
		dataTransferType = $someDataTransferType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DataTransferType]) for enum values.
		# OPTIONAL
		childSnappableFailoverInfos = @(
			@{
				# REQUIRED
				snappableId = $someString
				# REQUIRED
				recoveryPoint = $someInt64
			}
		)
		# OPTIONAL
		failoverIgnorableErrors = @(
			$someBlueprintFailoverIgnorableError # Call [Enum]::GetValues([RubrikSecurityCloud.Types.BlueprintFailoverIgnorableError]) for enum values.
		)
		# OPTIONAL
		enableRecoveryWithRba = $someBoolean
		# OPTIONAL
		recoveryPlanId = $someString
		# OPTIONAL
		recoverySpecID = $someString
		# OPTIONAL
		isZeroRpo = $someBoolean
		# OPTIONAL
		timeoutInMinutes = $someInt
		# OPTIONAL
		updateRecoverySpecPostFailover = $someBoolean
		# OPTIONAL
		sourceWorkloadActionAfterFailover = $someSourceWorkloadActionAfterFailover # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SourceWorkloadActionAfterFailover]) for enum values.
}
)"
            );
        }

        // Create new GraphQL Mutation:
        // startBulkRecovery(input: StartBulkRecoveryInput!): StartBulkRecoveryReply!
        internal void InitMutationStartBulkRecovery()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "StartBulkRecoveryInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationStartBulkRecovery",
                "($input: StartBulkRecoveryInput!)",
                "StartBulkRecoveryReply",
                Mutation.StartBulkRecovery,
                Mutation.StartBulkRecoveryFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	definition = @{
		# REQUIRED
		name = $someString
		# OPTIONAL
		o365GroupSelectorWithRecoverySpec = @{
			# OPTIONAL
			groupName = $someString
			# REQUIRED
			baseInfo = @{
				# REQUIRED
				snappableType = $someWorkloadType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.WorkloadType]) for enum values.
				# REQUIRED
				subSnappableType = $someSubWorkloadType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SubWorkloadType]) for enum values.
				# REQUIRED
				recoverySpec = @{
					# OPTIONAL
					inplaceRecoverySpec = @{
						# OPTIONAL
						nameCollisionRule = $someInplaceCollisionRule # Call [Enum]::GetValues([RubrikSecurityCloud.Types.InplaceCollisionRule]) for enum values.
					}
					# OPTIONAL
					operationalRecoverySpec = @{
						# OPTIONAL
						mailboxOperationalRecoverySpec = @{
							# OPTIONAL
							archiveFolderAction = $someMailboxArchiveFolderAction # Call [Enum]::GetValues([RubrikSecurityCloud.Types.MailboxArchiveFolderAction]) for enum values.
							# REQUIRED
							mailboxTimeRange = @{
								# OPTIONAL
								fromTime = $someDateTime
								# OPTIONAL
								untilTime = $someDateTime
							}
						}
						# OPTIONAL
						calendarOperationalRecoverySpec = @{
							# REQUIRED
							calendarTimeRange = @{
								# OPTIONAL
								fromTime = $someDateTime
								# OPTIONAL
								untilTime = $someDateTime
							}
						}
						# OPTIONAL
						operationalRecoveryStage = $someOperationalRecoveryStage # Call [Enum]::GetValues([RubrikSecurityCloud.Types.OperationalRecoveryStage]) for enum values.
						# OPTIONAL
						shouldAutoComplete = $someBoolean
						# OPTIONAL
						sharepointOperationalRecoverySpec = @{
							# OPTIONAL
							shouldSkipItemPermission = $someBoolean
							# OPTIONAL
							siteOwnerEmail = $someString
							# REQUIRED
							lastModifiedTimeFilter = @{
								# OPTIONAL
								fromTime = $someDateTime
								# OPTIONAL
								untilTime = $someDateTime
							}
							# OPTIONAL
							targetSiteCollectionUrl = $someString
						}
						# OPTIONAL
						onedriveOperationalRecoverySpec = @{
							# REQUIRED
							lastModifiedTimeFilter = @{
								# OPTIONAL
								fromTime = $someDateTime
								# OPTIONAL
								untilTime = $someDateTime
							}
							# OPTIONAL
							targetRootPath = $someString
						}
						# OPTIONAL
						lastPhaseRecoveryJobId = $someString
					}
					# REQUIRED
					recoveryPoint = $someInt64
					# REQUIRED
					srcSubscriptionId = $someString
					# REQUIRED
					targetSubscriptionId = $someString
				}
			}
			# OPTIONAL
			adGroupId = $someString
		}
		# REQUIRED
		failureAction = $someFailureActionType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.FailureActionType]) for enum values.
		# REQUIRED
		recoveryMode = $someRecoveryModeType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RecoveryModeType]) for enum values.
		# REQUIRED
		recoveryDomain = $someRecoveryDomainType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RecoveryDomainType]) for enum values.
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // startCrawl(
        //     name: String!
        //     resources: [ResourceInput!]!
        //     analyzerGroups: [AnalyzerGroupInput!]!
        //     extWhiteList: [String!]
        //   ): StartCrawlReply!
        internal void InitMutationStartCrawl()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("name", "String!"),
                Tuple.Create("resources", "[ResourceInput!]!"),
                Tuple.Create("analyzerGroups", "[AnalyzerGroupInput!]!"),
                Tuple.Create("extWhiteList", "[String!]"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationStartCrawl",
                "($name: String!,$resources: [ResourceInput!]!,$analyzerGroups: [AnalyzerGroupInput!]!,$extWhiteList: [String!])",
                "StartCrawlReply",
                Mutation.StartCrawl,
                Mutation.StartCrawlFieldSpec,
                @"# REQUIRED
$query.Var.name = $someString
# REQUIRED
$query.Var.resources = @(
	@{
		# OPTIONAL
		snappableFid = $someString
		# OPTIONAL
		snapshotFid = $someString
}
)
# REQUIRED
$query.Var.analyzerGroups = @(
	@{
		# OPTIONAL
		groupType = $someAnalyzerGroupTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AnalyzerGroupTypeEnum]) for enum values.
		# OPTIONAL
		id = $someString
		# OPTIONAL
		name = $someString
		# OPTIONAL
		analyzers = @(
			@{
				# OPTIONAL
				analyzerType = $someAnalyzerTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AnalyzerTypeEnum]) for enum values.
				# OPTIONAL
				id = $someString
				# OPTIONAL
				name = $someString
				# OPTIONAL
				dictionaryCsv = $someString
				# OPTIONAL
				dictionary = @(
					$someString
				)
				# OPTIONAL
				regex = $someString
				# OPTIONAL
				analyzerRiskInstance = @{
					# OPTIONAL
					analyzerId = $someString
					# OPTIONAL
					riskVersion = $someInt
					# OPTIONAL
					risk = $someRiskLevelType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RiskLevelType]) for enum values.
				}
				# OPTIONAL
				tagId = $someInt
				# OPTIONAL
				risk = $someRiskLevelType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RiskLevelType]) for enum values.
			}
		)
}
)
# OPTIONAL
$query.Var.extWhiteList = @(
	$someString
)"
            );
        }

        // Create new GraphQL Mutation:
        // startCyberRecovery(input: StartCyberRecoveryInput!): CreateOnDemandJobReply!
        internal void InitMutationStartCyberRecovery()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "StartCyberRecoveryInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationStartCyberRecovery",
                "($input: StartCyberRecoveryInput!)",
                "CreateOnDemandJobReply",
                Mutation.StartCyberRecovery,
                Mutation.StartCyberRecoveryFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	blueprintId = $someString
	# REQUIRED
	recoverySpecId = $someString
	# OPTIONAL
	targetLocationType = $someLocationType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.LocationType]) for enum values.
	# OPTIONAL
	targetLocationUuid = $someString
	# REQUIRED
	failoverType = $someString
	# OPTIONAL
	jobTriggerEmail = $someString
	# OPTIONAL
	failoverFailureAction = $someString
	# OPTIONAL
	failoverOperation = $someString
	# OPTIONAL
	dataTransferType = $someDataTransferType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DataTransferType]) for enum values.
	# OPTIONAL
	childSnappableFailoverInfos = @(
		@{
			# REQUIRED
			snappableId = $someString
			# REQUIRED
			recoveryPoint = $someInt64
		}
	)
	# OPTIONAL
	failoverIgnorableErrors = @(
		$someBlueprintFailoverIgnorableError # Call [Enum]::GetValues([RubrikSecurityCloud.Types.BlueprintFailoverIgnorableError]) for enum values.
	)
	# OPTIONAL
	timeoutInMinutes = $someInt
	# OPTIONAL
	recoveryName = $someString
	# OPTIONAL
	failoverId = $someString
	# OPTIONAL
	triggeredFrom = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // startDownloadPackageBatchJob(
        //     listClusterUuid: [UUID!]!
        //     downloadVersion: String
        //     packageUrl: String!
        //     md5checksum: String!
        //     size: Long
        //   ): [DownloadPackageReplyWithUuid!]!
        internal void InitMutationStartDownloadPackageBatchJob()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("listClusterUuid", "[UUID!]!"),
                Tuple.Create("downloadVersion", "String"),
                Tuple.Create("packageUrl", "String!"),
                Tuple.Create("md5checksum", "String!"),
                Tuple.Create("size", "Long"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationStartDownloadPackageBatchJob",
                "($listClusterUuid: [UUID!]!,$downloadVersion: String,$packageUrl: String!,$md5checksum: String!,$size: Long)",
                "List<DownloadPackageReplyWithUuid>",
                Mutation.StartDownloadPackageBatchJob,
                Mutation.StartDownloadPackageBatchJobFieldSpec,
                @"# REQUIRED
$query.Var.listClusterUuid = @(
	$someString
)
# OPTIONAL
$query.Var.downloadVersion = $someString
# REQUIRED
$query.Var.packageUrl = $someString
# REQUIRED
$query.Var.md5checksum = $someString
# OPTIONAL
$query.Var.size = $someInt64"
            );
        }

        // Create new GraphQL Mutation:
        // startExportRdsInstanceJob(input: StartExportRdsInstanceJobInput!): AsyncJobStatus!
        internal void InitMutationStartExportRdsInstanceJob()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "StartExportRdsInstanceJobInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationStartExportRdsInstanceJob",
                "($input: StartExportRdsInstanceJobInput!)",
                "AsyncJobStatus",
                Mutation.StartExportRdsInstanceJob,
                Mutation.StartExportRdsInstanceJobFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	rdsInstanceId = $someString
	# REQUIRED
	isPointInTime = $someBoolean
	# OPTIONAL
	snapshotId = $someString
	# OPTIONAL
	exportTime = $someDateTime
	# REQUIRED
	dbInstanceName = $someString
	# REQUIRED
	destinationAwsNativeAccountId = $someString
	# REQUIRED
	destinationRegionNativeId = $someAwsNativeRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRegion]) for enum values.
	# REQUIRED
	dbInstanceClass = $someAwsNativeRdsDbInstanceClass # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRdsDbInstanceClass]) for enum values.
	# OPTIONAL
	databaseInstanceClass = $someString
	# OPTIONAL
	primaryAz = $someString
	# REQUIRED
	port = $someInt64
	# OPTIONAL
	optionGroupName = $someString
	# OPTIONAL
	parameterGroupName = $someString
	# OPTIONAL
	subnetGroupName = $someString
	# OPTIONAL
	storageType = $someAwsNativeRdsStorageType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRdsStorageType]) for enum values.
	# OPTIONAL
	securityGroupIds = @(
		$someString
	)
	# OPTIONAL
	iops = $someInt
	# REQUIRED
	isPubliclyAccessible = $someBoolean
	# REQUIRED
	shouldExportTags = $someBoolean
	# REQUIRED
	isMultiAz = $someBoolean
	# OPTIONAL
	kmsKeyId = $someString
	# OPTIONAL
	subnetIds = @(
		$someString
	)
	# OPTIONAL
	snapshotType = $someSnapshotType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SnapshotType]) for enum values.
	# OPTIONAL
	dbClusterName = $someString
	# OPTIONAL
	dbClusterParameterGroupName = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // startFetchCdmRbacConfigJob(input: StartFetchCdmRbacConfigJobInput!): Void
        internal void InitMutationStartFetchCdmRbacConfigJob()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "StartFetchCdmRbacConfigJobInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationStartFetchCdmRbacConfigJob",
                "($input: StartFetchCdmRbacConfigJobInput!)",
                "System.String",
                Mutation.StartFetchCdmRbacConfigJob,
                Mutation.StartFetchCdmRbacConfigJobFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	clusterId = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // startMalwareDetection(input: RunDetectMalwareInput!): AsyncRequestStatus!
        internal void InitMutationStartMalwareDetection()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "RunDetectMalwareInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationStartMalwareDetection",
                "($input: RunDetectMalwareInput!)",
                "AsyncRequestStatus",
                Mutation.StartMalwareDetection,
                Mutation.StartMalwareDetectionFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	clusterUuid = $someString
	# REQUIRED
	malwareScanConfig = @{
		# OPTIONAL
		maxMatchesPerSnapshot = $someInt
		# OPTIONAL
		name = $someString
		# OPTIONAL
		notes = $someString
		# OPTIONAL
		shouldTrustFilesystemTimeInfo = $someBoolean
		# OPTIONAL
		fileScanCriteria = @{
			# OPTIONAL
			fileSizeLimits = @{
				# OPTIONAL
				maximumSizeInBytes = $someInt64
				# OPTIONAL
				minimumSizeInBytes = $someInt64
			}
			# OPTIONAL
			fileTimeLimits = @{
				# OPTIONAL
				earliestCreationTime = $someDateTime
				# OPTIONAL
				earliestModificationTime = $someDateTime
				# OPTIONAL
				latestCreationTime = $someDateTime
				# OPTIONAL
				latestModificationTime = $someDateTime
			}
			# OPTIONAL
			pathFilter = @{
				# OPTIONAL
				exceptions = @(
					$someString
				)
				# OPTIONAL
				excludes = @(
					$someString
				)
				# OPTIONAL
				includes = @(
					$someString
				)
			}
		}
		# REQUIRED
		indicatorsOfCompromise = @(
			@{
				# REQUIRED
				iocType = $someIndicatorOfCompromiseType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.IndicatorOfCompromiseType]) for enum values.
				# REQUIRED
				iocValue = $someString
			}
		)
		# REQUIRED
		objectIds = @(
			$someString
		)
		# OPTIONAL
		requestedMatchDetails = @{
			# OPTIONAL
			requestedHashTypes = @(
				$someHashType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HashType]) for enum values.
			)
		}
		# OPTIONAL
		snapshotScanLimit = @{
			# OPTIONAL
			endTime = $someDateTime
			# OPTIONAL
			maxSnapshotsPerObject = $someInt
			# OPTIONAL
			startTime = $someDateTime
			# OPTIONAL
			snapshotsToScanPerObject = @(
				@{
					# REQUIRED
					id = $someString
					# REQUIRED
					snapshots = @(
						$someString
					)
				}
			)
		}
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // startMigrateCdmRbacConfigJob(input: StartMigrateCdmRbacConfigJobInput!): Void
        internal void InitMutationStartMigrateCdmRbacConfigJob()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "StartMigrateCdmRbacConfigJobInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationStartMigrateCdmRbacConfigJob",
                "($input: StartMigrateCdmRbacConfigJobInput!)",
                "System.String",
                Mutation.StartMigrateCdmRbacConfigJob,
                Mutation.StartMigrateCdmRbacConfigJobFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	clusterId = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // startMultipleBulkRecoveries(input: StartMultipleBulkRecoveriesInput!): StartMultipleBulkRecoveriesReply!
        internal void InitMutationStartMultipleBulkRecoveries()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "StartMultipleBulkRecoveriesInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationStartMultipleBulkRecoveries",
                "($input: StartMultipleBulkRecoveriesInput!)",
                "StartMultipleBulkRecoveriesReply",
                Mutation.StartMultipleBulkRecoveries,
                Mutation.StartMultipleBulkRecoveriesFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	definitions = @(
		@{
			# OPTIONAL
			recoveryName = $someString
			# OPTIONAL
			o365GroupSelectorWithRecoverySpec = @{
				# REQUIRED
				selectorType = $someO365SelectorType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.O365SelectorType]) for enum values.
				# REQUIRED
				baseInfo = @{
					# REQUIRED
					snappableType = $someWorkloadType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.WorkloadType]) for enum values.
					# REQUIRED
					subSnappableType = $someSubWorkloadType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SubWorkloadType]) for enum values.
					# REQUIRED
					recoverySpec = @{
						# OPTIONAL
						inplaceRecoverySpec = @{
							# OPTIONAL
							nameCollisionRule = $someInplaceCollisionRule # Call [Enum]::GetValues([RubrikSecurityCloud.Types.InplaceCollisionRule]) for enum values.
						}
						# OPTIONAL
						operationalRecoverySpec = @{
							# OPTIONAL
							mailboxOperationalRecoverySpec = @{
								# OPTIONAL
								archiveFolderAction = $someMailboxArchiveFolderAction # Call [Enum]::GetValues([RubrikSecurityCloud.Types.MailboxArchiveFolderAction]) for enum values.
								# REQUIRED
								mailboxTimeRange = @{
									# OPTIONAL
									fromTime = $someDateTime
									# OPTIONAL
									untilTime = $someDateTime
								}
							}
							# OPTIONAL
							calendarOperationalRecoverySpec = @{
								# REQUIRED
								calendarTimeRange = @{
									# OPTIONAL
									fromTime = $someDateTime
									# OPTIONAL
									untilTime = $someDateTime
								}
							}
							# OPTIONAL
							operationalRecoveryStage = $someOperationalRecoveryStage # Call [Enum]::GetValues([RubrikSecurityCloud.Types.OperationalRecoveryStage]) for enum values.
							# OPTIONAL
							shouldAutoComplete = $someBoolean
							# OPTIONAL
							sharepointOperationalRecoverySpec = @{
								# OPTIONAL
								shouldSkipItemPermission = $someBoolean
								# OPTIONAL
								siteOwnerEmail = $someString
								# REQUIRED
								lastModifiedTimeFilter = @{
									# OPTIONAL
									fromTime = $someDateTime
									# OPTIONAL
									untilTime = $someDateTime
								}
								# OPTIONAL
								targetSiteCollectionUrl = $someString
							}
							# OPTIONAL
							onedriveOperationalRecoverySpec = @{
								# REQUIRED
								lastModifiedTimeFilter = @{
									# OPTIONAL
									fromTime = $someDateTime
									# OPTIONAL
									untilTime = $someDateTime
								}
								# OPTIONAL
								targetRootPath = $someString
							}
							# OPTIONAL
							lastPhaseRecoveryJobId = $someString
						}
						# REQUIRED
						recoveryPoint = $someInt64
						# REQUIRED
						srcSubscriptionId = $someString
						# REQUIRED
						targetSubscriptionId = $someString
					}
				}
				# REQUIRED
				groupId = $someString
			}
			# REQUIRED
			failureAction = $someV2FailureActionType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.V2FailureActionType]) for enum values.
			# REQUIRED
			recoveryMode = $someRecoveryModeType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RecoveryModeType]) for enum values.
			# REQUIRED
			recoveryDomain = $someRecoveryDomainType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RecoveryDomainType]) for enum values.
		}
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // startNasAutomigrationJob(nasAutomigrationJobConfig: NasAutomigrationJobInput!): CreateOnDemandJobReply!
        internal void InitMutationStartNasAutomigrationJob()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("nasAutomigrationJobConfig", "NasAutomigrationJobInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationStartNasAutomigrationJob",
                "($nasAutomigrationJobConfig: NasAutomigrationJobInput!)",
                "CreateOnDemandJobReply",
                Mutation.StartNasAutomigrationJob,
                Mutation.StartNasAutomigrationJobFieldSpec,
                @"# REQUIRED
$query.Var.nasAutomigrationJobConfig = @{
	# REQUIRED
	MigrateAllHosts = $someBoolean
	# REQUIRED
	CopyableHostIDs = @(
		$someString
	)
	# REQUIRED
	NasSystemIDs = @(
		$someString
	)
	# OPTIONAL
	clusterUUID = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // startPeriodicUpgradePrechecksOnDemandJob(clusterUuid: UUID!): PrechecksJobReply!
        internal void InitMutationStartPeriodicUpgradePrechecksOnDemandJob()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("clusterUuid", "UUID!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationStartPeriodicUpgradePrechecksOnDemandJob",
                "($clusterUuid: UUID!)",
                "PrechecksJobReply",
                Mutation.StartPeriodicUpgradePrechecksOnDemandJob,
                Mutation.StartPeriodicUpgradePrechecksOnDemandJobFieldSpec,
                @"# REQUIRED
$query.Var.clusterUuid = $someString"
            );
        }

        // Create new GraphQL Mutation:
        // startSaasAppAuthConsent(input: StartSaasAppAuthConsentInput!): StartSaasAppAuthConsentReply!
        internal void InitMutationStartSaasAppAuthConsent()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "StartSaasAppAuthConsentInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationStartSaasAppAuthConsent",
                "($input: StartSaasAppAuthConsentInput!)",
                "StartSaasAppAuthConsentReply",
                Mutation.StartSaasAppAuthConsent,
                Mutation.StartSaasAppAuthConsentFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	siteUrl = $someString
	# REQUIRED
	customerUrl = $someString
	# REQUIRED
	saasAppType = $someSaasAppType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SaasAppType]) for enum values.
}"
            );
        }

        // Create new GraphQL Mutation:
        // startSaasAppsDeleteOrg(input: StartSaasAppsDeleteOrgInput!): CreateOnDemandJobReply!
        internal void InitMutationStartSaasAppsDeleteOrg()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "StartSaasAppsDeleteOrgInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationStartSaasAppsDeleteOrg",
                "($input: StartSaasAppsDeleteOrgInput!)",
                "CreateOnDemandJobReply",
                Mutation.StartSaasAppsDeleteOrg,
                Mutation.StartSaasAppsDeleteOrgFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	orgID = $someString
	# REQUIRED
	saasAppType = $someSaasAppType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SaasAppType]) for enum values.
}"
            );
        }

        // Create new GraphQL Mutation:
        // startUpgradeBatchJob(
        //     listClusterUuid: [UUID!]!
        //     mode: String!
        //     action: ActionType!
        //     version: String!
        //     context_tag: String = "{\"client\": \"polaris\"}"
        //   ): [UpgradeJobReplyWithUuid!]!
        internal void InitMutationStartUpgradeBatchJob()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("listClusterUuid", "[UUID!]!"),
                Tuple.Create("mode", "String!"),
                Tuple.Create("action", "ActionType!"),
                Tuple.Create("version", "String!"),
                Tuple.Create("context_tag", "String"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationStartUpgradeBatchJob",
                "($listClusterUuid: [UUID!]!,$mode: String!,$action: ActionType!,$version: String!,$context_tag: String)",
                "List<UpgradeJobReplyWithUuid>",
                Mutation.StartUpgradeBatchJob,
                Mutation.StartUpgradeBatchJobFieldSpec,
                @"# REQUIRED
$query.Var.listClusterUuid = @(
	$someString
)
# REQUIRED
$query.Var.mode = $someString
# REQUIRED
$query.Var.action = $someActionType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ActionType]) for enum values.
# REQUIRED
$query.Var.version = $someString
# OPTIONAL
$query.Var.context_tag = $someString"
            );
        }

        // Create new GraphQL Mutation:
        // startVolumeGroupMount(input: StartVolumeGroupMountInput!): AsyncRequestStatus!
        internal void InitMutationStartVolumeGroupMount()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "StartVolumeGroupMountInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationStartVolumeGroupMount",
                "($input: StartVolumeGroupMountInput!)",
                "AsyncRequestStatus",
                Mutation.StartVolumeGroupMount,
                Mutation.StartVolumeGroupMountFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	config = @{
		# OPTIONAL
		smbDomainName = $someString
		# OPTIONAL
		smbValidIps = @(
			$someString
		)
		# OPTIONAL
		smbValidUsers = @(
			$someString
		)
		# OPTIONAL
		targetHostId = $someString
		# REQUIRED
		volumeConfigs = @(
			@{
				# OPTIONAL
				mountPointOnHost = $someString
				# REQUIRED
				volumeId = $someString
			}
		)
	}
	# REQUIRED
	id = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // stopJobInstance(input: StopJobInstanceInput!): StopJobInstanceReply!
        internal void InitMutationStopJobInstance()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "StopJobInstanceInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationStopJobInstance",
                "($input: StopJobInstanceInput!)",
                "StopJobInstanceReply",
                Mutation.StopJobInstance,
                Mutation.StopJobInstanceFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	jobInstanceId = $someString
	# OPTIONAL
	eventSeriesId = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // stopJobInstanceFromEventSeries(input: StopJobInstanceFromEventSeriesInput!): Void
        internal void InitMutationStopJobInstanceFromEventSeries()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "StopJobInstanceFromEventSeriesInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationStopJobInstanceFromEventSeries",
                "($input: StopJobInstanceFromEventSeriesInput!)",
                "System.String",
                Mutation.StopJobInstanceFromEventSeries,
                Mutation.StopJobInstanceFromEventSeriesFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	eventSeriesId = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // submitTprRequest(input: SubmitTprRequestInput!): Void
        internal void InitMutationSubmitTprRequest()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "SubmitTprRequestInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationSubmitTprRequest",
                "($input: SubmitTprRequestInput!)",
                "System.String",
                Mutation.SubmitTprRequest,
                Mutation.SubmitTprRequestFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	requestId = $someString
	# OPTIONAL
	comment = $someString
	# REQUIRED
	executionType = $someTprExecutionType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TprExecutionType]) for enum values.
	# OPTIONAL
	executionTimeoutHours = $someInt
}"
            );
        }

        // Create new GraphQL Mutation:
        // supportPortalLogin(input: SupportPortalLoginInput!): SupportPortalLoginReply!
        internal void InitMutationSupportPortalLogin()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "SupportPortalLoginInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationSupportPortalLogin",
                "($input: SupportPortalLoginInput!)",
                "SupportPortalLoginReply",
                Mutation.SupportPortalLogin,
                Mutation.SupportPortalLoginFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	account = $someString
	# OPTIONAL
	hostname = $someString
	# OPTIONAL
	organizationId = $someString
	# REQUIRED
	username = $someString
	# REQUIRED
	password = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // switchProductToOnboardingMode(input: SwitchProductToOnboardingModeInput!): Void
        internal void InitMutationSwitchProductToOnboardingMode()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "SwitchProductToOnboardingModeInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationSwitchProductToOnboardingMode",
                "($input: SwitchProductToOnboardingModeInput!)",
                "System.String",
                Mutation.SwitchProductToOnboardingMode,
                Mutation.SwitchProductToOnboardingModeFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	orgId = $someString
	# REQUIRED
	workloadType = $someM365DashboardWorkloadType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.M365DashboardWorkloadType]) for enum values.
}"
            );
        }

        // Create new GraphQL Mutation:
        // toggleFeatureEnabled(featureName: FeatureName!, enableFeature: Boolean!): Boolean!
        internal void InitMutationToggleFeatureEnabled()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("featureName", "FeatureName!"),
                Tuple.Create("enableFeature", "Boolean!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationToggleFeatureEnabled",
                "($featureName: FeatureName!,$enableFeature: Boolean!)",
                "System.Boolean",
                Mutation.ToggleFeatureEnabled,
                Mutation.ToggleFeatureEnabledFieldSpec,
                @"# REQUIRED
$query.Var.featureName = $someFeatureName # Call [Enum]::GetValues([RubrikSecurityCloud.Types.FeatureName]) for enum values.
# REQUIRED
$query.Var.enableFeature = $someBoolean"
            );
        }

        // Create new GraphQL Mutation:
        // triggerCloudComputeConnectivityCheck(input: TriggerCloudComputeConnectivityCheckInput!): AsyncRequestStatus!
        internal void InitMutationTriggerCloudComputeConnectivityCheck()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "TriggerCloudComputeConnectivityCheckInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationTriggerCloudComputeConnectivityCheck",
                "($input: TriggerCloudComputeConnectivityCheckInput!)",
                "AsyncRequestStatus",
                Mutation.TriggerCloudComputeConnectivityCheck,
                Mutation.TriggerCloudComputeConnectivityCheckFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	shouldCheckCloudConnectivityForCloudOut = $someBoolean
	# REQUIRED
	id = $someString
	# REQUIRED
	shouldCheckCloudConnectivityForCloudOn = $someBoolean
}"
            );
        }

        // Create new GraphQL Mutation:
        // triggerExocomputeHealthCheck(input: TriggerExocomputeHealthCheckInput!): TriggerExocomputeHealthCheckReply!
        internal void InitMutationTriggerExocomputeHealthCheck()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "TriggerExocomputeHealthCheckInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationTriggerExocomputeHealthCheck",
                "($input: TriggerExocomputeHealthCheckInput!)",
                "TriggerExocomputeHealthCheckReply",
                Mutation.TriggerExocomputeHealthCheck,
                Mutation.TriggerExocomputeHealthCheckFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	cloudVendor = $someCloudVendor # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudVendor]) for enum values.
	# REQUIRED
	exocomputeConfigId = $someString
	# OPTIONAL
	nodeType = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // uninstallIoFilter(input: UninstallIoFilterInput!): RequestSuccess!
        internal void InitMutationUninstallIoFilter()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UninstallIoFilterInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUninstallIoFilter",
                "($input: UninstallIoFilterInput!)",
                "RequestSuccess",
                Mutation.UninstallIoFilter,
                Mutation.UninstallIoFilterFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // unlockUsersByAdmin(input: UnlockUsersByAdminInput!): Void
        internal void InitMutationUnlockUsersByAdmin()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UnlockUsersByAdminInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUnlockUsersByAdmin",
                "($input: UnlockUsersByAdminInput!)",
                "System.String",
                Mutation.UnlockUsersByAdmin,
                Mutation.UnlockUsersByAdminFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	userIds = @(
		$someString
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // unmountDisk(input: UnmountDiskInput!): Void
        internal void InitMutationUnmountDisk()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UnmountDiskInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUnmountDisk",
                "($input: UnmountDiskInput!)",
                "System.String",
                Mutation.UnmountDisk,
                Mutation.UnmountDiskFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	liveMountId = $someInt64
	# REQUIRED
	mountIds = @(
		$someInt64
	)
	# REQUIRED
	targetWorkloadId = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // updateAccountOwner(userId: String!): Boolean!
        internal void InitMutationUpdateAccountOwner()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("userId", "String!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateAccountOwner",
                "($userId: String!)",
                "System.Boolean",
                Mutation.UpdateAccountOwner,
                Mutation.UpdateAccountOwnerFieldSpec,
                @"# REQUIRED
$query.Var.userId = $someString"
            );
        }

        // Create new GraphQL Mutation:
        // updateAccountSettings(isEulaAccepted: Boolean, isEmailNotificationEnabled: Boolean): AccountSetting!
        internal void InitMutationUpdateAccountSettings()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("isEulaAccepted", "Boolean"),
                Tuple.Create("isEmailNotificationEnabled", "Boolean"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateAccountSettings",
                "($isEulaAccepted: Boolean,$isEmailNotificationEnabled: Boolean)",
                "AccountSetting",
                Mutation.UpdateAccountSettings,
                Mutation.UpdateAccountSettingsFieldSpec,
                @"# OPTIONAL
$query.Var.isEulaAccepted = $someBoolean
# OPTIONAL
$query.Var.isEmailNotificationEnabled = $someBoolean"
            );
        }

        // Create new GraphQL Mutation:
        // updateAdGroup(input: UpdateAdGroupInput!): Void
        internal void InitMutationUpdateAdGroup()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateAdGroupInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateAdGroup",
                "($input: UpdateAdGroupInput!)",
                "System.String",
                Mutation.UpdateAdGroup,
                Mutation.UpdateAdGroupFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	orgId = $someString
	# REQUIRED
	groupId = $someString
	# REQUIRED
	updatedDisplayName = $someString
	# REQUIRED
	updatedGroupFilterAttributes = @(
		@{
			# OPTIONAL
			filterOpType = $someJoinOpType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.JoinOpType]) for enum values.
			# OPTIONAL
			attributeType = $someAttributeType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AttributeType]) for enum values.
			# OPTIONAL
			attributeKey = $someString
			# OPTIONAL
			attributeValue = $someString
			# OPTIONAL
			dataType = $someAttributeDataType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AttributeDataType]) for enum values.
		}
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // updateAgentDeploymentSetting(input: UpdateVmAgentDeploymentSettingInput!): AgentDeploymentSettings!
        internal void InitMutationUpdateAgentDeploymentSetting()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateVmAgentDeploymentSettingInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateAgentDeploymentSetting",
                "($input: UpdateVmAgentDeploymentSettingInput!)",
                "AgentDeploymentSettings",
                Mutation.UpdateAgentDeploymentSetting,
                Mutation.UpdateAgentDeploymentSettingFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	clusterUuid = $someString
	# REQUIRED
	settings = @{
		# REQUIRED
		isAutomatic = $someBoolean
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // updateAgentDeploymentSettingInBatch(input: UpdateAgentDeploymentSettingInBatchInput!): UpdateAgentDeploymentSettingInBatchReply!
        internal void InitMutationUpdateAgentDeploymentSettingInBatch()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateAgentDeploymentSettingInBatchInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateAgentDeploymentSettingInBatch",
                "($input: UpdateAgentDeploymentSettingInBatchInput!)",
                "UpdateAgentDeploymentSettingInBatchReply",
                Mutation.UpdateAgentDeploymentSettingInBatch,
                Mutation.UpdateAgentDeploymentSettingInBatchFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	requests = @(
		@{
			# REQUIRED
			clusterUuid = $someString
			# REQUIRED
			settings = @{
				# REQUIRED
				isAutomatic = $someBoolean
			}
		}
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // updateAuthDomainUsersHiddenStatus(input: UpdateAuthDomainUsersHiddenStatusInput!): Void
        internal void InitMutationUpdateAuthDomainUsersHiddenStatus()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateAuthDomainUsersHiddenStatusInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateAuthDomainUsersHiddenStatus",
                "($input: UpdateAuthDomainUsersHiddenStatusInput!)",
                "System.String",
                Mutation.UpdateAuthDomainUsersHiddenStatus,
                Mutation.UpdateAuthDomainUsersHiddenStatusFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	userIds = @(
		$someString
	)
	# REQUIRED
	isHidden = $someBoolean
}"
            );
        }

        // Create new GraphQL Mutation:
        // updateBackupThrottleSetting(input: UpdateBackupThrottleSettingInput!): UpdateBackupThrottleSettingReply!
        internal void InitMutationUpdateBackupThrottleSetting()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateBackupThrottleSettingInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateBackupThrottleSetting",
                "($input: UpdateBackupThrottleSettingInput!)",
                "UpdateBackupThrottleSettingReply",
                Mutation.UpdateBackupThrottleSetting,
                Mutation.UpdateBackupThrottleSettingFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	requests = @(
		@{
			# OPTIONAL
			clusterUuid = $someString
			# OPTIONAL
			enableThrottling = $someBoolean
			# OPTIONAL
			vmwareThrottlingSettings = @{
				# OPTIONAL
				ioLatencyThreshold = $someInt
				# OPTIONAL
				datastoreIoLatencyThreshold = $someInt
				# OPTIONAL
				cpuUtilizationThreshold = $someInt
			}
		}
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // updateBadDiskLedStatus(input: UpdateBadDiskLedStatusInput!): UpdateBadDiskLedStatusReply!
        internal void InitMutationUpdateBadDiskLedStatus()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateBadDiskLedStatusInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateBadDiskLedStatus",
                "($input: UpdateBadDiskLedStatusInput!)",
                "UpdateBadDiskLedStatusReply",
                Mutation.UpdateBadDiskLedStatus,
                Mutation.UpdateBadDiskLedStatusFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	diskSerial = $someString
	# OPTIONAL
	turnOff = $someBoolean
	# REQUIRED
	id = $someString
	# REQUIRED
	nodeId = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // updateBlueprint(
        //     fid: UUID!
        //     name: String!
        //     children: [AppBlueprintChildInput!]!
        //     sourceLocationId: String!
        //     sourceLocationType: BlueprintLocationType! = CDM
        //     targetLocationType: BlueprintLocationType = CDM
        //     targetLocationId: String
        //     status: BlueprintStatus! = INCOMPLETE
        //     version: Int!
        //     enableHydration: Boolean
        //     timeoutBetweenPriorityGroups: [Long!]
        //     blueprintRecoveryType: BlueprintRecoveryType
        //     isBlueprintVisible: Boolean! = true
        //   ): BlueprintNew!
        internal void InitMutationUpdateBlueprint()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
                Tuple.Create("name", "String!"),
                Tuple.Create("children", "[AppBlueprintChildInput!]!"),
                Tuple.Create("sourceLocationId", "String!"),
                Tuple.Create("sourceLocationType", "BlueprintLocationType!"),
                Tuple.Create("targetLocationType", "BlueprintLocationType"),
                Tuple.Create("targetLocationId", "String"),
                Tuple.Create("status", "BlueprintStatus!"),
                Tuple.Create("version", "Int!"),
                Tuple.Create("enableHydration", "Boolean"),
                Tuple.Create("timeoutBetweenPriorityGroups", "[Long!]"),
                Tuple.Create("blueprintRecoveryType", "BlueprintRecoveryType"),
                Tuple.Create("isBlueprintVisible", "Boolean!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateBlueprint",
                "($fid: UUID!,$name: String!,$children: [AppBlueprintChildInput!]!,$sourceLocationId: String!,$sourceLocationType: BlueprintLocationType!,$targetLocationType: BlueprintLocationType,$targetLocationId: String,$status: BlueprintStatus!,$version: Int!,$enableHydration: Boolean,$timeoutBetweenPriorityGroups: [Long!],$blueprintRecoveryType: BlueprintRecoveryType,$isBlueprintVisible: Boolean!)",
                "BlueprintNew",
                Mutation.UpdateBlueprint,
                Mutation.UpdateBlueprintFieldSpec,
                @"# REQUIRED
$query.Var.fid = $someString
# REQUIRED
$query.Var.name = $someString
# REQUIRED
$query.Var.children = @(
	@{
		# REQUIRED
		fid = $someString
		# REQUIRED
		snappableType = $someObjectTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ObjectTypeEnum]) for enum values.
		# REQUIRED
		bootPriority = $someInt
		# OPTIONAL
		lastRecoveryPoint = $someInt64
}
)
# REQUIRED
$query.Var.sourceLocationId = $someString
# REQUIRED
$query.Var.sourceLocationType = $someBlueprintLocationType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.BlueprintLocationType]) for enum values.
# OPTIONAL
$query.Var.targetLocationType = $someBlueprintLocationType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.BlueprintLocationType]) for enum values.
# OPTIONAL
$query.Var.targetLocationId = $someString
# REQUIRED
$query.Var.status = $someBlueprintStatus # Call [Enum]::GetValues([RubrikSecurityCloud.Types.BlueprintStatus]) for enum values.
# REQUIRED
$query.Var.version = $someInt
# OPTIONAL
$query.Var.enableHydration = $someBoolean
# OPTIONAL
$query.Var.timeoutBetweenPriorityGroups = @(
	$someInt64
)
# OPTIONAL
$query.Var.blueprintRecoveryType = $someBlueprintRecoveryType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.BlueprintRecoveryType]) for enum values.
# REQUIRED
$query.Var.isBlueprintVisible = $someBoolean"
            );
        }

        // Create new GraphQL Mutation:
        // updateChat(input: UpdateChatReq!): Void
        internal void InitMutationUpdateChat()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateChatReq!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateChat",
                "($input: UpdateChatReq!)",
                "System.String",
                Mutation.UpdateChat,
                Mutation.UpdateChatFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	chatId = $someString
	# OPTIONAL
	isPinned = $someBoolean
	# OPTIONAL
	isArchived = $someBoolean
	# OPTIONAL
	title = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // updateChatbot(input: UpdateChatbotInput!): UpdateChatbotReply!
        internal void InitMutationUpdateChatbot()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateChatbotInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateChatbot",
                "($input: UpdateChatbotInput!)",
                "UpdateChatbotReply",
                Mutation.UpdateChatbot,
                Mutation.UpdateChatbotFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	name = $someString
	# OPTIONAL
	description = $someString
	# OPTIONAL
	filters = @{
		# OPTIONAL
		modifiedTimeRange = @{
			# OPTIONAL
			startTime = $someInt64
			# OPTIONAL
			endTime = $someInt64
		}
		# REQUIRED
		sensitiveDataPolicyIds = @(
			$someString
		)
		# REQUIRED
		extensionWhitelist = @(
			$someString
		)
	}
	# REQUIRED
	chatbotId = $someString
	# REQUIRED
	objects = @(
		@{
			# OPTIONAL
			workloadType = $someManagedObjectType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ManagedObjectType]) for enum values.
			# OPTIONAL
			pathFilter = @{
				# REQUIRED
				prefixInclusions = @(
					$someString
				)
			}
			# REQUIRED
			id = $someString
		}
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // updateClassificationBannerEnabled: Boolean!
        internal void InitMutationUpdateClassificationBannerEnabled()
        {
            Tuple<string, string>[] argDefs = {
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateClassificationBannerEnabled",
                "",
                "System.Boolean",
                Mutation.UpdateClassificationBannerEnabled,
                Mutation.UpdateClassificationBannerEnabledFieldSpec,
                @""
            );
        }

        // Create new GraphQL Mutation:
        // updateClassificationBannerSettings(classificationBannerSettingsArg: ClassificationBannerSettingsInputType!): Boolean!
        internal void InitMutationUpdateClassificationBannerSettings()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("classificationBannerSettingsArg", "ClassificationBannerSettingsInputType!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateClassificationBannerSettings",
                "($classificationBannerSettingsArg: ClassificationBannerSettingsInputType!)",
                "System.Boolean",
                Mutation.UpdateClassificationBannerSettings,
                Mutation.UpdateClassificationBannerSettingsFieldSpec,
                @"# REQUIRED
$query.Var.classificationBannerSettingsArg = @{
	# OPTIONAL
	account = $someString
	# OPTIONAL
	bannerText = $someString
	# OPTIONAL
	bannerColor = $someBannerColor # Call [Enum]::GetValues([RubrikSecurityCloud.Types.BannerColor]) for enum values.
}"
            );
        }

        // Create new GraphQL Mutation:
        // updateClassificationLoginEnabled: Boolean!
        internal void InitMutationUpdateClassificationLoginEnabled()
        {
            Tuple<string, string>[] argDefs = {
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateClassificationLoginEnabled",
                "",
                "System.Boolean",
                Mutation.UpdateClassificationLoginEnabled,
                Mutation.UpdateClassificationLoginEnabledFieldSpec,
                @""
            );
        }

        // Create new GraphQL Mutation:
        // updateClassificationLoginSettings(classificationLoginSettingsArg: ClassificationLoginSettingsInputType!): Boolean!
        internal void InitMutationUpdateClassificationLoginSettings()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("classificationLoginSettingsArg", "ClassificationLoginSettingsInputType!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateClassificationLoginSettings",
                "($classificationLoginSettingsArg: ClassificationLoginSettingsInputType!)",
                "System.Boolean",
                Mutation.UpdateClassificationLoginSettings,
                Mutation.UpdateClassificationLoginSettingsFieldSpec,
                @"# REQUIRED
$query.Var.classificationLoginSettingsArg = @{
	# OPTIONAL
	account = $someString
	# OPTIONAL
	loginText = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // updateConfigProtectionSetup(input: UpdateConfigProtectionSetupInput!): AsyncJobStatus!
        internal void InitMutationUpdateConfigProtectionSetup()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateConfigProtectionSetupInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateConfigProtectionSetup",
                "($input: UpdateConfigProtectionSetupInput!)",
                "AsyncJobStatus",
                Mutation.UpdateConfigProtectionSetup,
                Mutation.UpdateConfigProtectionSetupFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	clusterUuid = $someString
	# OPTIONAL
	encryptionPassword = $someString
	# OPTIONAL
	caCertificate = @{
		# OPTIONAL
		uuid = $someString
		# OPTIONAL
		name = $someString
		# OPTIONAL
		description = $someString
		# OPTIONAL
		certificate = $someString
		# REQUIRED
		caProvider = $someCaCertProviderType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CaCertProviderType]) for enum values.
	}
	# OPTIONAL
	replicationTargetUuid = $someString
	# OPTIONAL
	uploadLocationType = $someUploadLocationType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UploadLocationType]) for enum values.
}"
            );
        }

        // Create new GraphQL Mutation:
        // updateConfiguredGroup(input: UpdateConfiguredGroupInput!): Void
        internal void InitMutationUpdateConfiguredGroup()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateConfiguredGroupInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateConfiguredGroup",
                "($input: UpdateConfiguredGroupInput!)",
                "System.String",
                Mutation.UpdateConfiguredGroup,
                Mutation.UpdateConfiguredGroupFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	orgId = $someString
	# REQUIRED
	groupId = $someString
	# OPTIONAL
	updatedDisplayName = $someString
	# OPTIONAL
	updatedWildcard = $someString
	# REQUIRED
	updatedPdls = @(
		$someString
	)
	# OPTIONAL
	updatedGroupFilterAttributes = @(
		@{
			# OPTIONAL
			filterOpType = $someJoinOpType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.JoinOpType]) for enum values.
			# OPTIONAL
			attributeType = $someAttributeType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AttributeType]) for enum values.
			# OPTIONAL
			attributeKey = $someString
			# OPTIONAL
			attributeValue = $someString
			# OPTIONAL
			dataType = $someAttributeDataType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AttributeDataType]) for enum values.
		}
	)
	# REQUIRED
	performArchival = $someBoolean
}"
            );
        }

        // Create new GraphQL Mutation:
        // updateCustomAnalyzer(input: CreateCustomAnalyzerInput!): Analyzer!
        internal void InitMutationUpdateCustomAnalyzer()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateCustomAnalyzerInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateCustomAnalyzer",
                "($input: CreateCustomAnalyzerInput!)",
                "Analyzer",
                Mutation.UpdateCustomAnalyzer,
                Mutation.UpdateCustomAnalyzerFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	analyzerType = $someAnalyzerTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AnalyzerTypeEnum]) for enum values.
	# OPTIONAL
	id = $someString
	# OPTIONAL
	name = $someString
	# OPTIONAL
	dictionaryCsv = $someString
	# OPTIONAL
	dictionary = @(
		$someString
	)
	# OPTIONAL
	regex = $someString
	# OPTIONAL
	analyzerRiskInstance = @{
		# OPTIONAL
		analyzerId = $someString
		# OPTIONAL
		riskVersion = $someInt
		# OPTIONAL
		risk = $someRiskLevelType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RiskLevelType]) for enum values.
	}
	# OPTIONAL
	tagId = $someInt
	# OPTIONAL
	risk = $someRiskLevelType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RiskLevelType]) for enum values.
}"
            );
        }

        // Create new GraphQL Mutation:
        // updateCustomIntelFeed(input: UpdateCustomIntelFeedInput!): Void
        internal void InitMutationUpdateCustomIntelFeed()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateCustomIntelFeedInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateCustomIntelFeed",
                "($input: UpdateCustomIntelFeedInput!)",
                "System.String",
                Mutation.UpdateCustomIntelFeed,
                Mutation.UpdateCustomIntelFeedFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	user = $someString
	# OPTIONAL
	name = @{
		# OPTIONAL
		name = $someString
	}
	# OPTIONAL
	providerId = $someString
	# OPTIONAL
	description = @{
		# OPTIONAL
		description = $someString
	}
	# OPTIONAL
	entriesToAdd = @(
		@{
			# OPTIONAL
			iocString = $someString
			# OPTIONAL
			threatFamily = $someString
			# REQUIRED
			iocType = $someThreatFeedType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ThreatFeedType]) for enum values.
		}
	)
	# OPTIONAL
	entriesToRemove = @(
		$someString
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // updateCustomerAppPermissions(input: UpdateCustomerAppPermissionsInput!): UpdateCustomerAppPermissionsReply!
        internal void InitMutationUpdateCustomerAppPermissions()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateCustomerAppPermissionsInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateCustomerAppPermissions",
                "($input: UpdateCustomerAppPermissionsInput!)",
                "UpdateCustomerAppPermissionsReply",
                Mutation.UpdateCustomerAppPermissions,
                Mutation.UpdateCustomerAppPermissionsFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	appPermissions = @(
		$someAzureAppPermission # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureAppPermission]) for enum values.
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // updateCyberEventLockdown(input: UpdateCyberEventLockdownInput!): UpdateCyberEventLockdownResponse!
        internal void InitMutationUpdateCyberEventLockdown()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateCyberEventLockdownInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateCyberEventLockdown",
                "($input: UpdateCyberEventLockdownInput!)",
                "UpdateCyberEventLockdownResponse",
                Mutation.UpdateCyberEventLockdown,
                Mutation.UpdateCyberEventLockdownFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	clusterUuid = $someString
	# REQUIRED
	updateCyberEventLockdownRequest = @{
		# REQUIRED
		shouldEnable = $someBoolean
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // updateDistributionListDigest(input: UpdateDistributionListDigestInput!): UpdateDistributionListDigestReply!
        internal void InitMutationUpdateDistributionListDigest()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateDistributionListDigestInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateDistributionListDigest",
                "($input: UpdateDistributionListDigestInput!)",
                "UpdateDistributionListDigestReply",
                Mutation.UpdateDistributionListDigest,
                Mutation.UpdateDistributionListDigestFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	digestId = $someInt
	# OPTIONAL
	digestName = $someString
	# OPTIONAL
	frequencyHours = $someInt
	# OPTIONAL
	isImmediate = $someBoolean
	# OPTIONAL
	includeAudits = $someBoolean
	# OPTIONAL
	includeEvents = $someBoolean
	# REQUIRED
	eventDigestConfig = @{
		# OPTIONAL
		objectType = @(
			$someActivityObjectTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ActivityObjectTypeEnum]) for enum values.
		)
		# OPTIONAL
		activityStatus = @(
			$someActivityStatusEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ActivityStatusEnum]) for enum values.
		)
		# OPTIONAL
		activityType = @(
			$someString
		)
		# OPTIONAL
		auditType = @(
			$someUserAuditTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UserAuditTypeEnum]) for enum values.
		)
		# OPTIONAL
		activitySeverity = @(
			$someActivitySeverityEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ActivitySeverityEnum]) for enum values.
		)
		# OPTIONAL
		clusters = @(
			$someString
		)
		# OPTIONAL
		emailAddresses = @(
			$someString
		)
	}
	# REQUIRED
	recipientUserIds = @(
		$someString
	)
	# OPTIONAL
	clusterUuids = @(
		$someString
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // updateDnsServersAndSearchDomains(input: UpdateDnsServersAndSearchDomainsInput!): ResponseSuccess!
        internal void InitMutationUpdateDnsServersAndSearchDomains()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateDnsServersAndSearchDomainsInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateDnsServersAndSearchDomains",
                "($input: UpdateDnsServersAndSearchDomainsInput!)",
                "ResponseSuccess",
                Mutation.UpdateDnsServersAndSearchDomains,
                Mutation.UpdateDnsServersAndSearchDomainsFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someString
	# REQUIRED
	servers = @(
		$someString
	)
	# REQUIRED
	domains = @(
		$someString
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // updateEulaAccepted: Boolean!
        internal void InitMutationUpdateEulaAccepted()
        {
            Tuple<string, string>[] argDefs = {
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateEulaAccepted",
                "",
                "System.Boolean",
                Mutation.UpdateEulaAccepted,
                Mutation.UpdateEulaAcceptedFieldSpec,
                @""
            );
        }

        // Create new GraphQL Mutation:
        // updateEventDigest(input: UpdateEventDigestInput!): UpdateEventDigestReply!
        internal void InitMutationUpdateEventDigest()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateEventDigestInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateEventDigest",
                "($input: UpdateEventDigestInput!)",
                "UpdateEventDigestReply",
                Mutation.UpdateEventDigest,
                Mutation.UpdateEventDigestFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	digestId = $someInt
	# OPTIONAL
	digestName = $someString
	# OPTIONAL
	frequencyHours = $someInt
	# OPTIONAL
	isImmediate = $someBoolean
	# OPTIONAL
	includeAudits = $someBoolean
	# OPTIONAL
	includeEvents = $someBoolean
	# REQUIRED
	eventDigestConfig = @{
		# OPTIONAL
		objectType = @(
			$someActivityObjectTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ActivityObjectTypeEnum]) for enum values.
		)
		# OPTIONAL
		activityStatus = @(
			$someActivityStatusEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ActivityStatusEnum]) for enum values.
		)
		# OPTIONAL
		activityType = @(
			$someString
		)
		# OPTIONAL
		auditType = @(
			$someUserAuditTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UserAuditTypeEnum]) for enum values.
		)
		# OPTIONAL
		activitySeverity = @(
			$someActivitySeverityEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ActivitySeverityEnum]) for enum values.
		)
		# OPTIONAL
		clusters = @(
			$someString
		)
		# OPTIONAL
		emailAddresses = @(
			$someString
		)
	}
	# REQUIRED
	recipientUserIds = @(
		$someString
	)
	# OPTIONAL
	clusterUuids = @(
		$someString
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // updateFloatingIps(input: UpdateFloatingIpsInput!): UpdateFloatingIpsReply!
        internal void InitMutationUpdateFloatingIps()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateFloatingIpsInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateFloatingIps",
                "($input: UpdateFloatingIpsInput!)",
                "UpdateFloatingIpsReply",
                Mutation.UpdateFloatingIps,
                Mutation.UpdateFloatingIpsFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	clusterUuid = $someString
	# REQUIRED
	newClusterIps = @(
		$someString
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // updateGuestCredential(input: UpdateGuestCredentialInput!): UpdateGuestCredentialReply!
        internal void InitMutationUpdateGuestCredential()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateGuestCredentialInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateGuestCredential",
                "($input: UpdateGuestCredentialInput!)",
                "UpdateGuestCredentialReply",
                Mutation.UpdateGuestCredential,
                Mutation.UpdateGuestCredentialFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	clusterUuid = $someString
	# REQUIRED
	definition = @{
		# OPTIONAL
		domain = $someString
		# OPTIONAL
		description = $someString
		# OPTIONAL
		baseGuestCredential = @{
			# REQUIRED
			password = $someString
			# REQUIRED
			username = $someString
		}
	}
	# REQUIRED
	id = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // updateIdentityProvider(input: UpdateIdentityProviderInput!): UpdateIdentityProviderReply!
        internal void InitMutationUpdateIdentityProvider()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateIdentityProviderInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateIdentityProvider",
                "($input: UpdateIdentityProviderInput!)",
                "UpdateIdentityProviderReply",
                Mutation.UpdateIdentityProvider,
                Mutation.UpdateIdentityProviderFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	idpClaimAttribute = @(
		@{
			# REQUIRED
			name = $someString
			# REQUIRED
			type = $someString
		}
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // updateInsightState(input: UpdateInsightStateInput!): UpdateInsightStateReply!
        internal void InitMutationUpdateInsightState()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateInsightStateInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateInsightState",
                "($input: UpdateInsightStateInput!)",
                "UpdateInsightStateReply",
                Mutation.UpdateInsightState,
                Mutation.UpdateInsightStateFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	insightId = $someString
	# OPTIONAL
	isDismissed = $someBoolean
}"
            );
        }

        // Create new GraphQL Mutation:
        // updateIocStatus(input: [UpdateIocStatusInput!]!): Void
        internal void InitMutationUpdateIocStatus()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "[UpdateIocStatusInput!]!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateIocStatus",
                "($input: [UpdateIocStatusInput!]!)",
                "System.String",
                Mutation.UpdateIocStatus,
                Mutation.UpdateIocStatusFieldSpec,
                @"# REQUIRED
$query.Var.input = @(
	@{
		# REQUIRED
		operation = $someIocOperation # Call [Enum]::GetValues([RubrikSecurityCloud.Types.IocOperation]) for enum values.
		# OPTIONAL
		iocHashOnly = @{
			# REQUIRED
			iocHashHex = $someString
		}
		# OPTIONAL
		iocHashWithProvider = @{
			# REQUIRED
			iocHashHex = $someString
			# REQUIRED
			providerId = $someString
		}
		# OPTIONAL
		iocProviderWithThreatFeedType = @{
			# REQUIRED
			providerId = $someString
			# REQUIRED
			type = $someThreatFeedType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ThreatFeedType]) for enum values.
		}
}
)"
            );
        }

        // Create new GraphQL Mutation:
        // updateIpWhitelist(whitelistMode: WhitelistModeEnum!, ipCidrs: [String!]!): Boolean!
        internal void InitMutationUpdateIpWhitelist()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("whitelistMode", "WhitelistModeEnum!"),
                Tuple.Create("ipCidrs", "[String!]!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateIpWhitelist",
                "($whitelistMode: WhitelistModeEnum!,$ipCidrs: [String!]!)",
                "System.Boolean",
                Mutation.UpdateIpWhitelist,
                Mutation.UpdateIpWhitelistFieldSpec,
                @"# REQUIRED
$query.Var.whitelistMode = $someWhitelistModeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.WhitelistModeEnum]) for enum values.
# REQUIRED
$query.Var.ipCidrs = @(
	$someString
)"
            );
        }

        // Create new GraphQL Mutation:
        // updateKmipServer(input: UpdateKmipServerInput!): UpdateKmipServerReply!
        internal void InitMutationUpdateKmipServer()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateKmipServerInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateKmipServer",
                "($input: UpdateKmipServerInput!)",
                "UpdateKmipServerReply",
                Mutation.UpdateKmipServer,
                Mutation.UpdateKmipServerFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	clusterIds = @(
		$someString
	)
	# REQUIRED
	serverAddress = $someString
	# REQUIRED
	port = $someInt
	# REQUIRED
	polarisCertId = $someInt
	# OPTIONAL
	polarisCertFid = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // updateLambdaSettings(anomalyThreshold: Float, ransomwareThreshold: Float, isAnomalyAlertEnabled: Boolean): LambdaSettings!
        internal void InitMutationUpdateLambdaSettings()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("anomalyThreshold", "Float"),
                Tuple.Create("ransomwareThreshold", "Float"),
                Tuple.Create("isAnomalyAlertEnabled", "Boolean"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateLambdaSettings",
                "($anomalyThreshold: Float,$ransomwareThreshold: Float,$isAnomalyAlertEnabled: Boolean)",
                "LambdaSettings",
                Mutation.UpdateLambdaSettings,
                Mutation.UpdateLambdaSettingsFieldSpec,
                @"# OPTIONAL
$query.Var.anomalyThreshold = $someSingle
# OPTIONAL
$query.Var.ransomwareThreshold = $someSingle
# OPTIONAL
$query.Var.isAnomalyAlertEnabled = $someBoolean"
            );
        }

        // Create new GraphQL Mutation:
        // updateLlmEnabled(input: UpdateLlmEnabledReq!): Void
        internal void InitMutationUpdateLlmEnabled()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateLlmEnabledReq!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateLlmEnabled",
                "($input: UpdateLlmEnabledReq!)",
                "System.String",
                Mutation.UpdateLlmEnabled,
                Mutation.UpdateLlmEnabledFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	isEnabled = $someBoolean
	# REQUIRED
	acceptTerms = $someBoolean
}"
            );
        }

        // Create new GraphQL Mutation:
        // updateLockoutConfig(input: UpdateLockoutConfigInput!): UpdateLockoutConfigReply!
        internal void InitMutationUpdateLockoutConfig()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateLockoutConfigInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateLockoutConfig",
                "($input: UpdateLockoutConfigInput!)",
                "UpdateLockoutConfigReply",
                Mutation.UpdateLockoutConfig,
                Mutation.UpdateLockoutConfigFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	loginAttemptsLimit = $someInt
	# OPTIONAL
	selfServiceTokenValidityInMins = $someInt
	# OPTIONAL
	selfServiceAttemptsLimit = $someInt
	# OPTIONAL
	isSelfServiceEnabled = $someBoolean
	# OPTIONAL
	accountAutoUnlockDurationInMins = $someInt
	# OPTIONAL
	isBruteForceLockoutEnabled = $someBoolean
	# OPTIONAL
	isAutoUnlockFeatureEnabled = $someBoolean
}"
            );
        }

        // Create new GraphQL Mutation:
        // updateManagedIdentities(input: UpdateManagedIdentitiesInput!): UpdateManagedIdentitiesReply!
        internal void InitMutationUpdateManagedIdentities()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateManagedIdentitiesInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateManagedIdentities",
                "($input: UpdateManagedIdentitiesInput!)",
                "UpdateManagedIdentitiesReply",
                Mutation.UpdateManagedIdentities,
                Mutation.UpdateManagedIdentitiesFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	cloudAccountId = $someString
	# REQUIRED
	clusterUuid = $someString
	# OPTIONAL
	managedIdentity = @{
		# OPTIONAL
		name = $someString
		# OPTIONAL
		clientId = $someString
		# OPTIONAL
		resourceGroup = $someString
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // updateNetworkThrottle(input: UpdateNetworkThrottleInput!): UpdateNetworkThrottleReply!
        internal void InitMutationUpdateNetworkThrottle()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateNetworkThrottleInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateNetworkThrottle",
                "($input: UpdateNetworkThrottleInput!)",
                "UpdateNetworkThrottleReply",
                Mutation.UpdateNetworkThrottle,
                Mutation.UpdateNetworkThrottleFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	clusterUuid = $someString
	# REQUIRED
	id = $someString
	# REQUIRED
	throttleUpdate = @{
		# OPTIONAL
		defaultThrottleLimit = $someSingle
		# OPTIONAL
		isEnabled = $someBoolean
		# OPTIONAL
		networkInterface = $someString
		# OPTIONAL
		archivalThrottlePort = $someInt
		# OPTIONAL
		scheduledThrottles = @(
			@{
				# REQUIRED
				daysOfWeek = @(
					$someInt
				)
				# REQUIRED
				endTime = $someInt64
				# REQUIRED
				startTime = $someInt64
				# REQUIRED
				throttleLimit = $someSingle
			}
		)
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // updateOrgNetwork(input: UpdateOrgNetworkInput!): Void
        internal void InitMutationUpdateOrgNetwork()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateOrgNetworkInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateOrgNetwork",
                "($input: UpdateOrgNetworkInput!)",
                "System.String",
                Mutation.UpdateOrgNetwork,
                Mutation.UpdateOrgNetworkFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	orgNetworkID = $someString
	# REQUIRED
	name = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // updatePactsafeEulaAccepted(input: UpdatePactsafeEulaAcceptedInput!): UpdatePactsafeEulaAcceptedReply!
        internal void InitMutationUpdatePactsafeEulaAccepted()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdatePactsafeEulaAcceptedInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdatePactsafeEulaAccepted",
                "($input: UpdatePactsafeEulaAcceptedInput!)",
                "UpdatePactsafeEulaAcceptedReply",
                Mutation.UpdatePactsafeEulaAccepted,
                Mutation.UpdatePactsafeEulaAcceptedFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	firstName = $someString
	# REQUIRED
	lastName = $someString
	# REQUIRED
	title = $someString
	# REQUIRED
	companyName = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // updatePactsafeEulaSeen: UpdatePactsafeEulaSeenReply!
        internal void InitMutationUpdatePactsafeEulaSeen()
        {
            Tuple<string, string>[] argDefs = {
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdatePactsafeEulaSeen",
                "",
                "UpdatePactsafeEulaSeenReply",
                Mutation.UpdatePactsafeEulaSeen,
                Mutation.UpdatePactsafeEulaSeenFieldSpec,
                @""
            );
        }

        // Create new GraphQL Mutation:
        // updateProxyConfig(input: UpdateProxyConfigInput!): UpdateProxyConfigReply!
        internal void InitMutationUpdateProxyConfig()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateProxyConfigInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateProxyConfig",
                "($input: UpdateProxyConfigInput!)",
                "UpdateProxyConfigReply",
                Mutation.UpdateProxyConfig,
                Mutation.UpdateProxyConfigFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	clusterUuid = $someString
	# REQUIRED
	proxy = @{
		# OPTIONAL
		password = $someString
		# OPTIONAL
		port = $someInt
		# OPTIONAL
		username = $someString
		# REQUIRED
		host = $someString
		# REQUIRED
		protocol = $someString
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // updateReaderLocationMasterKeyWithOwnerLocationKey(input: UpdateReaderLocationMasterKeyWithOwnerLocationKeyInput!): Void
        internal void InitMutationUpdateReaderLocationMasterKeyWithOwnerLocationKey()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateReaderLocationMasterKeyWithOwnerLocationKeyInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateReaderLocationMasterKeyWithOwnerLocationKey",
                "($input: UpdateReaderLocationMasterKeyWithOwnerLocationKeyInput!)",
                "System.String",
                Mutation.UpdateReaderLocationMasterKeyWithOwnerLocationKey,
                Mutation.UpdateReaderLocationMasterKeyWithOwnerLocationKeyFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	locationId = $someString
	# REQUIRED
	ownerLocationId = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // updateReaderLocationMasterKeyWithRsaKey(input: UpdateReaderLocationMasterKeyWithRsaKeyInput!): Void
        internal void InitMutationUpdateReaderLocationMasterKeyWithRsaKey()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateReaderLocationMasterKeyWithRsaKeyInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateReaderLocationMasterKeyWithRsaKey",
                "($input: UpdateReaderLocationMasterKeyWithRsaKeyInput!)",
                "System.String",
                Mutation.UpdateReaderLocationMasterKeyWithRsaKey,
                Mutation.UpdateReaderLocationMasterKeyWithRsaKeyFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	locationId = $someString
	# REQUIRED
	newRsaKey = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // updateRecoveryPlan(input: UpdateRecoveryPlanInput!): UpdateRecoveryPlanReply!
        internal void InitMutationUpdateRecoveryPlan()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateRecoveryPlanInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateRecoveryPlan",
                "($input: UpdateRecoveryPlanInput!)",
                "UpdateRecoveryPlanReply",
                Mutation.UpdateRecoveryPlan,
                Mutation.UpdateRecoveryPlanFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	name = $someString
	# REQUIRED
	id = $someString
	# OPTIONAL
	targetLocationId = $someString
	# OPTIONAL
	targetLocationType = $someBlueprintLocationType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.BlueprintLocationType]) for enum values.
	# REQUIRED
	children = @(
		@{
			# REQUIRED
			fid = $someString
			# REQUIRED
			snappableType = $someObjectTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ObjectTypeEnum]) for enum values.
			# REQUIRED
			bootPriority = $someInt
			# OPTIONAL
			lastRecoveryPoint = $someInt64
		}
	)
	# REQUIRED
	version = $someInt
	# REQUIRED
	isHydrationEnabled = $someBoolean
	# REQUIRED
	pauseBetweenPriorityGroups = @(
		$someInt64
	)
	# REQUIRED
	isVisible = $someBoolean
}"
            );
        }

        // Create new GraphQL Mutation:
        // updateRecoverySchedule(input: UpdateRecoveryScheduleInput!): Void
        internal void InitMutationUpdateRecoverySchedule()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateRecoveryScheduleInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateRecoverySchedule",
                "($input: UpdateRecoveryScheduleInput!)",
                "System.String",
                Mutation.UpdateRecoverySchedule,
                Mutation.UpdateRecoveryScheduleFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	recoveryPlanFid = $someString
	# REQUIRED
	scheduleInfo = @{
		# OPTIONAL
		startRunTime = $someDateTime
		# OPTIONAL
		timezone = $someString
		# OPTIONAL
		frequency = $someScheduleFrequency # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ScheduleFrequency]) for enum values.
		# OPTIONAL
		recoveryConfig = @{
			# OPTIONAL
			dataTransferType = $someDataTransferType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DataTransferType]) for enum values.
		}
		# OPTIONAL
		recipients = @(
			$someString
		)
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // updateRoleAssignments(userIds: [String!], groupIds: [String!], roleIds: [String!]!): Boolean!
        internal void InitMutationUpdateRoleAssignments()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("userIds", "[String!]"),
                Tuple.Create("groupIds", "[String!]"),
                Tuple.Create("roleIds", "[String!]!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateRoleAssignments",
                "($userIds: [String!],$groupIds: [String!],$roleIds: [String!]!)",
                "System.Boolean",
                Mutation.UpdateRoleAssignments,
                Mutation.UpdateRoleAssignmentsFieldSpec,
                @"# OPTIONAL
$query.Var.userIds = @(
	$someString
)
# OPTIONAL
$query.Var.groupIds = @(
	$someString
)
# REQUIRED
$query.Var.roleIds = @(
	$someString
)"
            );
        }

        // Create new GraphQL Mutation:
        // updateSnapMirrorCloud(input: UpdateSnapMirrorCloudInput!): UpdateSnapMirrorCloudReply!
        internal void InitMutationUpdateSnapMirrorCloud()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateSnapMirrorCloudInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateSnapMirrorCloud",
                "($input: UpdateSnapMirrorCloudInput!)",
                "UpdateSnapMirrorCloudReply",
                Mutation.UpdateSnapMirrorCloud,
                Mutation.UpdateSnapMirrorCloudFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someString
	# REQUIRED
	snapmirrorCloudUpdateConfig = @{
		# REQUIRED
		snapMirrorLabel = $someString
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // updateSupportCase(input: UpdateSupportCaseInput!): UpdateSupportCaseReply!
        internal void InitMutationUpdateSupportCase()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateSupportCaseInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateSupportCase",
                "($input: UpdateSupportCaseInput!)",
                "UpdateSupportCaseReply",
                Mutation.UpdateSupportCase,
                Mutation.UpdateSupportCaseFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	caseId = $someString
	# OPTIONAL
	clusterUuid = $someString
	# REQUIRED
	attachments = @(
		@{
			# REQUIRED
			name = $someString
			# REQUIRED
			type = $someString
			# REQUIRED
			contentBase64 = $someString
		}
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // updateSupportUserAccess(input: UpdateSupportUserAccessInput!): Void
        internal void InitMutationUpdateSupportUserAccess()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateSupportUserAccessInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateSupportUserAccess",
                "($input: UpdateSupportUserAccessInput!)",
                "System.String",
                Mutation.UpdateSupportUserAccess,
                Mutation.UpdateSupportUserAccessFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	id = $someInt
	# OPTIONAL
	impersonatedUserId = $someString
	# OPTIONAL
	newDurationInHours = $someInt
}"
            );
        }

        // Create new GraphQL Mutation:
        // updateTprConfiguration(input: UpdateTprConfigurationInput!): Void
        internal void InitMutationUpdateTprConfiguration()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateTprConfigurationInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateTprConfiguration",
                "($input: UpdateTprConfigurationInput!)",
                "System.String",
                Mutation.UpdateTprConfiguration,
                Mutation.UpdateTprConfigurationFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	organizationId = $someString
	# OPTIONAL
	executionMaxTimeoutHours = $someInt
	# OPTIONAL
	requestTimeoutHours = $someInt
	# OPTIONAL
	reminderHours = $someInt
	# OPTIONAL
	staticQuorumApprovalsRequirement = $someInt
}"
            );
        }

        // Create new GraphQL Mutation:
        // updateTunnelStatus(input: UpdateTunnelStatusInput!): UpdateTunnelStatusReply!
        internal void InitMutationUpdateTunnelStatus()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateTunnelStatusInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateTunnelStatus",
                "($input: UpdateTunnelStatusInput!)",
                "UpdateTunnelStatusReply",
                Mutation.UpdateTunnelStatus,
                Mutation.UpdateTunnelStatusFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	clusterUuid = $someString
	# REQUIRED
	config = @{
		# OPTIONAL
		inactivityTimeoutInSeconds = $someInt64
		# REQUIRED
		isTunnelEnabled = $someBoolean
	}
	# REQUIRED
	id = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // updateVcdInstances(input: UpdateVcdInstancesInput!): UpdateVcdInstancesReply!
        internal void InitMutationUpdateVcdInstances()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateVcdInstancesInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateVcdInstances",
                "($input: UpdateVcdInstancesInput!)",
                "UpdateVcdInstancesReply",
                Mutation.UpdateVcdInstances,
                Mutation.UpdateVcdInstancesFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	vcdConfigs = @(
		@{
			# REQUIRED
			clusterUuid = $someString
			# REQUIRED
			id = $someString
			# REQUIRED
			definition = @{
				# OPTIONAL
				caCerts = $someString
				# OPTIONAL
				configuredSlaDomainId = $someString
				# OPTIONAL
				hostname = $someString
				# OPTIONAL
				password = $someString
				# OPTIONAL
				username = $someString
			}
		}
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // updateVcdVapp(input: UpdateVcdVappInput!): Void
        internal void InitMutationUpdateVcdVapp()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateVcdVappInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateVcdVapp",
                "($input: UpdateVcdVappInput!)",
                "System.String",
                Mutation.UpdateVcdVapp,
                Mutation.UpdateVcdVappFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someString
	# REQUIRED
	patchProperties = @{
		# OPTIONAL
		configuredSlaDomainId = $someString
		# OPTIONAL
		isBestEffortSynchronizationEnabled = $someBoolean
		# OPTIONAL
		isPaused = $someBoolean
		# OPTIONAL
		vcdVmMoidsToExcludeFromSnapshot = @(
			$someString
		)
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // updateVlan(input: UpdateVlanInput!): Void
        internal void InitMutationUpdateVlan()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateVlanInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateVlan",
                "($input: UpdateVlanInput!)",
                "System.String",
                Mutation.UpdateVlan,
                Mutation.UpdateVlanFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someString
	# REQUIRED
	vlanInfo = @{
		# OPTIONAL
		gateway = $someString
		# OPTIONAL
		alias = $someString
		# REQUIRED
		interfaces = @(
			@{
				# REQUIRED
				ip = $someString
				# REQUIRED
				node = $someString
			}
		)
		# REQUIRED
		netmask = $someString
		# REQUIRED
		vlan = $someInt
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // updateVolumeGroup(input: UpdateVolumeGroupInput!): UpdateVolumeGroupReply!
        internal void InitMutationUpdateVolumeGroup()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateVolumeGroupInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateVolumeGroup",
                "($input: UpdateVolumeGroupInput!)",
                "UpdateVolumeGroupReply",
                Mutation.UpdateVolumeGroup,
                Mutation.UpdateVolumeGroupFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someString
	# REQUIRED
	patchProperties = @{
		# OPTIONAL
		configuredSlaDomainId = $someString
		# OPTIONAL
		isPaused = $someBoolean
		# OPTIONAL
		volumeIdsIncludedInSnapshots = @(
			$someString
		)
		# OPTIONAL
		forceFull = $someBoolean
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // updateWhitelistedAnalyzers(
        //     stdPath: String!
        //     snappableFid: String!
        //     snapshotFid: String!
        //     analyzerIds: [String!]!
        //     runAsync: Boolean!
        //   ): String!
        internal void InitMutationUpdateWhitelistedAnalyzers()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("stdPath", "String!"),
                Tuple.Create("snappableFid", "String!"),
                Tuple.Create("snapshotFid", "String!"),
                Tuple.Create("analyzerIds", "[String!]!"),
                Tuple.Create("runAsync", "Boolean!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateWhitelistedAnalyzers",
                "($stdPath: String!,$snappableFid: String!,$snapshotFid: String!,$analyzerIds: [String!]!,$runAsync: Boolean!)",
                "System.String",
                Mutation.UpdateWhitelistedAnalyzers,
                Mutation.UpdateWhitelistedAnalyzersFieldSpec,
                @"# REQUIRED
$query.Var.stdPath = $someString
# REQUIRED
$query.Var.snappableFid = $someString
# REQUIRED
$query.Var.snapshotFid = $someString
# REQUIRED
$query.Var.analyzerIds = @(
	$someString
)
# REQUIRED
$query.Var.runAsync = $someBoolean"
            );
        }

        // Create new GraphQL Mutation:
        // upgradeIoFilter(input: UpgradeIoFilterInput!): RequestSuccess!
        internal void InitMutationUpgradeIoFilter()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpgradeIoFilterInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpgradeIoFilter",
                "($input: UpgradeIoFilterInput!)",
                "RequestSuccess",
                Mutation.UpgradeIoFilter,
                Mutation.UpgradeIoFilterFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	fqdnInfo = @{
		# REQUIRED
		fqdn = $someString
	}
	# REQUIRED
	id = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // upgradeToRsc: Void
        internal void InitMutationUpgradeToRsc()
        {
            Tuple<string, string>[] argDefs = {
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpgradeToRsc",
                "",
                "System.String",
                Mutation.UpgradeToRsc,
                Mutation.UpgradeToRscFieldSpec,
                @""
            );
        }

        // Create new GraphQL Mutation:
        // validateAndSaveCustomerKmsInfo(input: ValidateAndSaveCustomerKmsInfoInput!): ValidateAndSaveCustomerKmsInfoReply!
        internal void InitMutationValidateAndSaveCustomerKmsInfo()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "ValidateAndSaveCustomerKmsInfoInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationValidateAndSaveCustomerKmsInfo",
                "($input: ValidateAndSaveCustomerKmsInfoInput!)",
                "ValidateAndSaveCustomerKmsInfoReply",
                Mutation.ValidateAndSaveCustomerKmsInfo,
                Mutation.ValidateAndSaveCustomerKmsInfoFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	kmsSpec = @{
		# OPTIONAL
		cloudType = $someO365AzureCloudType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.O365AzureCloudType]) for enum values.
		# OPTIONAL
		tenantId = $someString
		# OPTIONAL
		kmsId = $someString
		# OPTIONAL
		appId = $someString
		# OPTIONAL
		appSecret = $someString
		# OPTIONAL
		keyName = $someString
		# OPTIONAL
		kekNameColossus = $someString
	}
	# REQUIRED
	appSecret = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // validateBlueprint(input: ValidateBlueprintInput!): ValidateBlueprintReply!
        internal void InitMutationValidateBlueprint()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "ValidateBlueprintInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationValidateBlueprint",
                "($input: ValidateBlueprintInput!)",
                "ValidateBlueprintReply",
                Mutation.ValidateBlueprint,
                Mutation.ValidateBlueprintFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	blueprintId = $someString
	# REQUIRED
	blueprintFailoverProperties = @{
		# OPTIONAL
		planType = $somePlanName # Call [Enum]::GetValues([RubrikSecurityCloud.Types.PlanName]) for enum values.
		# OPTIONAL
		dataTransferType = $someDataTransferType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DataTransferType]) for enum values.
		# OPTIONAL
		targetLocation = @{
			# OPTIONAL
			locationId = $someString
			# OPTIONAL
			locationType = $someLocationType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.LocationType]) for enum values.
		}
	}
	# REQUIRED
	childSnappableFailoverInfos = @(
		@{
			# OPTIONAL
			snappableId = $someString
			# OPTIONAL
			recoveryPoint = $someInt64
		}
	)
	# OPTIONAL
	enableRecoveryWithRba = $someBoolean
	# OPTIONAL
	skipSnappableRecoveryStatusValidation = $someBoolean
}"
            );
        }

        // Create new GraphQL Mutation:
        // validateBlueprintRecoverySpec(blueprintId: UUID!, validateSnapshotRecoverySpec: Boolean): ValidateBlueprintRecoverySpecReply!
        internal void InitMutationValidateBlueprintRecoverySpec()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("blueprintId", "UUID!"),
                Tuple.Create("validateSnapshotRecoverySpec", "Boolean"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationValidateBlueprintRecoverySpec",
                "($blueprintId: UUID!,$validateSnapshotRecoverySpec: Boolean)",
                "ValidateBlueprintRecoverySpecReply",
                Mutation.ValidateBlueprintRecoverySpec,
                Mutation.ValidateBlueprintRecoverySpecFieldSpec,
                @"# REQUIRED
$query.Var.blueprintId = $someString
# OPTIONAL
$query.Var.validateSnapshotRecoverySpec = $someBoolean"
            );
        }

        // Create new GraphQL Mutation:
        // validateBlueprints(input: ValidateBlueprintsInput!): ValidateBlueprintsReply!
        internal void InitMutationValidateBlueprints()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "ValidateBlueprintsInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationValidateBlueprints",
                "($input: ValidateBlueprintsInput!)",
                "ValidateBlueprintsReply",
                Mutation.ValidateBlueprints,
                Mutation.ValidateBlueprintsFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	blueprintDetails = @(
		@{
			# REQUIRED
			blueprintId = $someString
			# REQUIRED
			blueprintFailoverProperties = @{
				# OPTIONAL
				planType = $somePlanName # Call [Enum]::GetValues([RubrikSecurityCloud.Types.PlanName]) for enum values.
				# OPTIONAL
				dataTransferType = $someDataTransferType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DataTransferType]) for enum values.
				# OPTIONAL
				targetLocation = @{
					# OPTIONAL
					locationId = $someString
					# OPTIONAL
					locationType = $someLocationType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.LocationType]) for enum values.
				}
			}
			# REQUIRED
			childSnappableFailoverInfos = @(
				@{
					# OPTIONAL
					snappableId = $someString
					# OPTIONAL
					recoveryPoint = $someInt64
				}
			)
			# OPTIONAL
			enableRecoveryWithRba = $someBoolean
			# OPTIONAL
			skipSnappableRecoveryStatusValidation = $someBoolean
		}
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // validateCompleteOperationalRecoveryFeasibility(input: ValidateCompleteOperationalRecoveryFeasibilityInput!): ValidateCompleteOperationalRecoveryFeasibilityReply!
        internal void InitMutationValidateCompleteOperationalRecoveryFeasibility()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "ValidateCompleteOperationalRecoveryFeasibilityInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationValidateCompleteOperationalRecoveryFeasibility",
                "($input: ValidateCompleteOperationalRecoveryFeasibilityInput!)",
                "ValidateCompleteOperationalRecoveryFeasibilityReply",
                Mutation.ValidateCompleteOperationalRecoveryFeasibility,
                Mutation.ValidateCompleteOperationalRecoveryFeasibilityFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	bulkRecoveryInstanceId = $someString
	# OPTIONAL
	bulkRecoveryTaskchainId = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // validateTicketingPlatformConfig(input: ValidateTicketingPlatformConfigInput!): ValidateTicketingPlatformConfigReply!
        internal void InitMutationValidateTicketingPlatformConfig()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "ValidateTicketingPlatformConfigInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationValidateTicketingPlatformConfig",
                "($input: ValidateTicketingPlatformConfigInput!)",
                "ValidateTicketingPlatformConfigReply",
                Mutation.ValidateTicketingPlatformConfig,
                Mutation.ValidateTicketingPlatformConfigFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	platformConfig = @{
		# REQUIRED
		platformType = $someTicketingPlatform # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TicketingPlatform]) for enum values.
		# REQUIRED
		instanceUrl = $someString
	}
	# REQUIRED
	oauthConfig = @{
		# REQUIRED
		username = $someString
		# REQUIRED
		password = $someString
		# REQUIRED
		clientId = $someString
		# REQUIRED
		clientSecret = $someString
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // vmMakePrimary(input: VmMakePrimaryInput!): AsyncRequestStatus!
        internal void InitMutationVmMakePrimary()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "VmMakePrimaryInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationVmMakePrimary",
                "($input: VmMakePrimaryInput!)",
                "AsyncRequestStatus",
                Mutation.VmMakePrimary,
                Mutation.VmMakePrimaryFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	ids = @(
		$someString
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // vpshereVMRecoveryPointMount(
        //     snapshotFid: UUID
        //     snappableFid: UUID!
        //     vmName: String
        //     disableNetwork: Boolean
        //     removeNetworkDevices: Boolean
        //     powerOn: Boolean
        //     keepMacAddresses: Boolean
        //     hostID: String
        //     datastoreName: String
        //     vlan: Int
        //     unregsiterVm: Boolean
        //     shouldRecoverTags: Boolean
        //     recoveryPoint: String
        //     createDatastoreOnly: Boolean
        //   ): VsphereAsyncRequestStatus!
        internal void InitMutationVpshereVmRecoveryPointMount()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("snapshotFid", "UUID"),
                Tuple.Create("snappableFid", "UUID!"),
                Tuple.Create("vmName", "String"),
                Tuple.Create("disableNetwork", "Boolean"),
                Tuple.Create("removeNetworkDevices", "Boolean"),
                Tuple.Create("powerOn", "Boolean"),
                Tuple.Create("keepMacAddresses", "Boolean"),
                Tuple.Create("hostID", "String"),
                Tuple.Create("datastoreName", "String"),
                Tuple.Create("vlan", "Int"),
                Tuple.Create("unregsiterVm", "Boolean"),
                Tuple.Create("shouldRecoverTags", "Boolean"),
                Tuple.Create("recoveryPoint", "String"),
                Tuple.Create("createDatastoreOnly", "Boolean"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationVpshereVmRecoveryPointMount",
                "($snapshotFid: UUID,$snappableFid: UUID!,$vmName: String,$disableNetwork: Boolean,$removeNetworkDevices: Boolean,$powerOn: Boolean,$keepMacAddresses: Boolean,$hostID: String,$datastoreName: String,$vlan: Int,$unregsiterVm: Boolean,$shouldRecoverTags: Boolean,$recoveryPoint: String,$createDatastoreOnly: Boolean)",
                "VsphereAsyncRequestStatus",
                Mutation.VpshereVmRecoveryPointMount,
                Mutation.VpshereVmRecoveryPointMountFieldSpec,
                @"# OPTIONAL
$query.Var.snapshotFid = $someString
# REQUIRED
$query.Var.snappableFid = $someString
# OPTIONAL
$query.Var.vmName = $someString
# OPTIONAL
$query.Var.disableNetwork = $someBoolean
# OPTIONAL
$query.Var.removeNetworkDevices = $someBoolean
# OPTIONAL
$query.Var.powerOn = $someBoolean
# OPTIONAL
$query.Var.keepMacAddresses = $someBoolean
# OPTIONAL
$query.Var.hostID = $someString
# OPTIONAL
$query.Var.datastoreName = $someString
# OPTIONAL
$query.Var.vlan = $someInt
# OPTIONAL
$query.Var.unregsiterVm = $someBoolean
# OPTIONAL
$query.Var.shouldRecoverTags = $someBoolean
# OPTIONAL
$query.Var.recoveryPoint = $someString
# OPTIONAL
$query.Var.createDatastoreOnly = $someBoolean"
            );
        }

        // Create new GraphQL Mutation:
        // warmSearchCache(input: WarmSearchCacheInput!): Boolean!
        internal void InitMutationWarmSearchCache()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "WarmSearchCacheInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationWarmSearchCache",
                "($input: WarmSearchCacheInput!)",
                "System.Boolean",
                Mutation.WarmSearchCache,
                Mutation.WarmSearchCacheFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	workloadFid = $someString
}"
            );
        }


    } // class New_RscMutationMisc
}