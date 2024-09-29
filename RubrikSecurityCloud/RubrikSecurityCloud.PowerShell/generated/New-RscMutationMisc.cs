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
    /// Create a new RscQuery object for any of the 144
    /// operations in the 'Miscellaneous' API domain:
    /// AddAdGroupsToHierarchy, AddConfiguredGroupToHierarchy, AddCustomIntelFeed, AddInventoryWorkloads, AddRoleAssignments, AddVlan, AddVmAppConsistentSpecs, AirGapStatus, ApproveTprRequest, ArchiveCrawl, AssignProtection, BatchDeassignRoleFromUserGroups, BulkCreateNasFilesets, CancelDownloadPackage, CancelScheduledUpgrade, CancelTaskchain, CancelTprRequest, ChangePassword, CreateCustomAnalyzer, CreateDistributionListDigestBatch, CreateEventDigestBatch, CreateGuestCredential, CreateLegalHold, CreateOnDemandVolumeGroupBackup, CreateVappsInstantRecovery, DeactivateCustomAnalyzer, DeleteAdGroupsFromHierarchy, DeleteDistributionListDigestBatch, DeleteEventDigest, DeleteGuestCredentialById, DeleteIntelFeed, DeleteVolumeGroupMount, DenyTprRequests, DeregisterPrivateContainerRegistry, DisableSupportUserAccess, DisableTprOrg, DissolveLegalHold, EnableAutomaticFmdUpload, EnableDisableAppConsistency, EnableSupportUserAccess, EnableTprOrg, ExcludeVmDisks, ExecuteTprRequests, ExpireSnoozedDirectories, GenerateConfigProtectionRestoreForm, GenerateSupportBundle, GetDownloadUrl, HideRevealNasNamespaces, InstallIoFilter, InviteSsoGroup, ListCidrsForComputeSetting, LockUsersByAdmin, LogoutFromRubrikSupportPortal, MakePrimary, ManageProtectionForLinkedObjects, ModifyDistributionListDigestBatch, ModifyEventDigestBatch, ModifyIpmi, MountDisk, NotificationForGetLicense, RecoverCloudDirectMultiPaths, RecoverCloudDirectPath, RefreshDomain, RefreshGlobalManagerConnectivityStatus, RemoveDisk, RemoveInventoryWorkloads, RemovePrivateEndpointList, RemoveProxyConfig, RemoveVlans, ReseedLogShippingSecondary, ResetAllOrgUsersPasswords, ResetUsersPasswordsWithUserIds, ResizeDisk, ResolveAnomaly, ResolveVolumeGroupsConflict, RetryBackup, RetryDownloadPackageJob, RevokeAllOrgRoles, RunCustomAnalyzer, ScheduleUpgradeBatchJob, SetAnalyzerRisks, SetBundleApprovalStatus, SetCustomerTags, SetDatastoreFreespaceThresholds, SetIpWhitelistEnabled, SetMfaSetting, SetPrivateContainerRegistry, SetTotpConfig, SetUpgradeType, SetUserLevelTotpEnforcement, SetWorkloadAlertSetting, SetupDisk, StartCrawl, StartDownloadPackageBatchJob, StartExportRdsInstanceJob, StartPeriodicUpgradePrechecksOnDemandJob, StartUpgradeBatchJob, StartVolumeGroupMount, StopJobInstance, StopJobInstanceFromEventSeries, SubmitTprRequest, SupportPortalLogin, SwitchProductToOnboardingMode, TriggerCloudComputeConnectivityCheck, TriggerExocomputeHealthCheck, UninstallIoFilter, UnlockUsersByAdmin, UnmountDisk, UpdateAccountOwner, UpdateAdGroup, UpdateAgentDeploymentSetting, UpdateAgentDeploymentSettingInBatch, UpdateAuthDomainUsersHiddenStatus, UpdateBackupThrottleSetting, UpdateBadDiskLedStatus, UpdateConfiguredGroup, UpdateCustomAnalyzer, UpdateCustomIntelFeed, UpdateCustomerAppPermissions, UpdateDistributionListDigest, UpdateDnsServersAndSearchDomains, UpdateEventDigest, UpdateFloatingIps, UpdateGuestCredential, UpdateInsightState, UpdateIocStatus, UpdateIpWhitelist, UpdateLambdaSettings, UpdateLockoutConfig, UpdateManagedIdentities, UpdateNetworkThrottle, UpdateProxyConfig, UpdateRoleAssignments, UpdateSupportUserAccess, UpdateTprConfiguration, UpdateTunnelStatus, UpdateVlan, UpdateVolumeGroup, UpdateWhitelistedAnalyzers, UpgradeIoFilter, UpgradeToRsc, ValidateAndSaveCustomerKmsInfo, VmMakePrimary, or WarmSearchCache.
    /// </summary>
    /// <description>
    /// New-RscMutationMisc creates a new
    /// mutation object for operations
    /// in the 'Miscellaneous' API domain. It only creates a data structure,
    /// it does not execute the operation. This cmdlet does not need a
    /// connection to run. To execute the operation, either call Invoke()
    /// on the object returned by this cmdlet, or pass the object to
    /// Invoke-Rsc.
    /// There are 144 operations
    /// in the 'Miscellaneous' API domain. Select the operation this
    /// query is for by specifying the appropriate value for the
    /// -Operation parameter;
    /// one of: AddAdGroupsToHierarchy, AddConfiguredGroupToHierarchy, AddCustomIntelFeed, AddInventoryWorkloads, AddRoleAssignments, AddVlan, AddVmAppConsistentSpecs, AirGapStatus, ApproveTprRequest, ArchiveCrawl, AssignProtection, BatchDeassignRoleFromUserGroups, BulkCreateNasFilesets, CancelDownloadPackage, CancelScheduledUpgrade, CancelTaskchain, CancelTprRequest, ChangePassword, CreateCustomAnalyzer, CreateDistributionListDigestBatch, CreateEventDigestBatch, CreateGuestCredential, CreateLegalHold, CreateOnDemandVolumeGroupBackup, CreateVappsInstantRecovery, DeactivateCustomAnalyzer, DeleteAdGroupsFromHierarchy, DeleteDistributionListDigestBatch, DeleteEventDigest, DeleteGuestCredentialById, DeleteIntelFeed, DeleteVolumeGroupMount, DenyTprRequests, DeregisterPrivateContainerRegistry, DisableSupportUserAccess, DisableTprOrg, DissolveLegalHold, EnableAutomaticFmdUpload, EnableDisableAppConsistency, EnableSupportUserAccess, EnableTprOrg, ExcludeVmDisks, ExecuteTprRequests, ExpireSnoozedDirectories, GenerateConfigProtectionRestoreForm, GenerateSupportBundle, GetDownloadUrl, HideRevealNasNamespaces, InstallIoFilter, InviteSsoGroup, ListCidrsForComputeSetting, LockUsersByAdmin, LogoutFromRubrikSupportPortal, MakePrimary, ManageProtectionForLinkedObjects, ModifyDistributionListDigestBatch, ModifyEventDigestBatch, ModifyIpmi, MountDisk, NotificationForGetLicense, RecoverCloudDirectMultiPaths, RecoverCloudDirectPath, RefreshDomain, RefreshGlobalManagerConnectivityStatus, RemoveDisk, RemoveInventoryWorkloads, RemovePrivateEndpointList, RemoveProxyConfig, RemoveVlans, ReseedLogShippingSecondary, ResetAllOrgUsersPasswords, ResetUsersPasswordsWithUserIds, ResizeDisk, ResolveAnomaly, ResolveVolumeGroupsConflict, RetryBackup, RetryDownloadPackageJob, RevokeAllOrgRoles, RunCustomAnalyzer, ScheduleUpgradeBatchJob, SetAnalyzerRisks, SetBundleApprovalStatus, SetCustomerTags, SetDatastoreFreespaceThresholds, SetIpWhitelistEnabled, SetMfaSetting, SetPrivateContainerRegistry, SetTotpConfig, SetUpgradeType, SetUserLevelTotpEnforcement, SetWorkloadAlertSetting, SetupDisk, StartCrawl, StartDownloadPackageBatchJob, StartExportRdsInstanceJob, StartPeriodicUpgradePrechecksOnDemandJob, StartUpgradeBatchJob, StartVolumeGroupMount, StopJobInstance, StopJobInstanceFromEventSeries, SubmitTprRequest, SupportPortalLogin, SwitchProductToOnboardingMode, TriggerCloudComputeConnectivityCheck, TriggerExocomputeHealthCheck, UninstallIoFilter, UnlockUsersByAdmin, UnmountDisk, UpdateAccountOwner, UpdateAdGroup, UpdateAgentDeploymentSetting, UpdateAgentDeploymentSettingInBatch, UpdateAuthDomainUsersHiddenStatus, UpdateBackupThrottleSetting, UpdateBadDiskLedStatus, UpdateConfiguredGroup, UpdateCustomAnalyzer, UpdateCustomIntelFeed, UpdateCustomerAppPermissions, UpdateDistributionListDigest, UpdateDnsServersAndSearchDomains, UpdateEventDigest, UpdateFloatingIps, UpdateGuestCredential, UpdateInsightState, UpdateIocStatus, UpdateIpWhitelist, UpdateLambdaSettings, UpdateLockoutConfig, UpdateManagedIdentities, UpdateNetworkThrottle, UpdateProxyConfig, UpdateRoleAssignments, UpdateSupportUserAccess, UpdateTprConfiguration, UpdateTunnelStatus, UpdateVlan, UpdateVolumeGroup, UpdateWhitelistedAnalyzers, UpgradeIoFilter, UpgradeToRsc, ValidateAndSaveCustomerKmsInfo, VmMakePrimary, or WarmSearchCache.
    /// Each operation has its own set of variables that can be set with
    /// the -Var parameter. For more info about the variables, 
    /// call Info() on the object returned by this cmdlet, for example:
    /// (New-RscMutationMisc -AddAdGroupsToHierarchy).Info().
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
    /// (New-RscMutationMisc -AddAdGroupsToHierarchy).Info().
    /// You can combine a -Field parameter with patching parameters.
    /// -Field is applied first, then -FilePatch, -AddField and -RemoveField.
    ///
    /// </description>
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
    /// 		# OPTIONAL
    /// 		snapMirrorLabelForFullBackup = $someString
    /// 		# OPTIONAL
    /// 		snapMirrorLabelForIncrementalBackup = $someString
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
    /// 	ruleTypes = @(
    /// 		$someAnalyzerRuleType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AnalyzerRuleType]) for enum values.
    /// 	)
    /// 	# OPTIONAL
    /// 	keyRegex = $someString
    /// 	# OPTIONAL
    /// 	structuredValueRegex = $someString
    /// 	# OPTIONAL
    /// 	structuredDictionaryCsv = $someString
    /// 	# OPTIONAL
    /// 	structuredDictionary = @(
    /// 		$someString
    /// 	)
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
    /// Runs the CreateDistributionListDigestBatch operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: CreateDistributionListDigestBatch
    /// 
    /// $query = New-RscMutationMisc -CreateDistributionListDigestBatch
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
    /// Write-Host $result.GetType().Name # prints: System.String
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
    /// Runs the ManageProtectionForLinkedObjects operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: ManageProtectionForLinkedObjects
    /// 
    /// $query = New-RscMutationMisc -ManageProtectionForLinkedObjects
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	operation = $someManageProtectionForLinkedObjectsOperationType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ManageProtectionForLinkedObjectsOperationType]) for enum values.
    /// 	# REQUIRED
    /// 	assignSlaReq = @{
    /// 		# REQUIRED
    /// 		slaDomainAssignType = $someSlaAssignTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SlaAssignTypeEnum]) for enum values.
    /// 		# OPTIONAL
    /// 		slaOptionalId = $someString
    /// 		# REQUIRED
    /// 		objectIds = @(
    /// 			$someString
    /// 		)
    /// 		# OPTIONAL
    /// 		applicableWorkloadType = $someWorkloadLevelHierarchy # Call [Enum]::GetValues([RubrikSecurityCloud.Types.WorkloadLevelHierarchy]) for enum values.
    /// 		# OPTIONAL
    /// 		shouldApplyToExistingSnapshots = $someBoolean
    /// 		# OPTIONAL
    /// 		shouldApplyToNonPolicySnapshots = $someBoolean
    /// 		# OPTIONAL
    /// 		existingSnapshotRetention = $someGlobalExistingSnapshotRetention # Call [Enum]::GetValues([RubrikSecurityCloud.Types.GlobalExistingSnapshotRetention]) for enum values.
    /// 		# OPTIONAL
    /// 		userNote = $someString
    /// 	}
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
    /// Runs the ModifyDistributionListDigestBatch operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: ModifyDistributionListDigestBatch
    /// 
    /// $query = New-RscMutationMisc -ModifyDistributionListDigestBatch
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
    /// 	# REQUIRED
    /// 	invalidateAllSessions = $someBoolean
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
    /// 				ruleTypes = @(
    /// 					$someAnalyzerRuleType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AnalyzerRuleType]) for enum values.
    /// 				)
    /// 				# OPTIONAL
    /// 				keyRegex = $someString
    /// 				# OPTIONAL
    /// 				structuredValueRegex = $someString
    /// 				# OPTIONAL
    /// 				structuredDictionaryCsv = $someString
    /// 				# OPTIONAL
    /// 				structuredDictionary = @(
    /// 					$someString
    /// 				)
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
    /// 	ruleTypes = @(
    /// 		$someAnalyzerRuleType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AnalyzerRuleType]) for enum values.
    /// 	)
    /// 	# OPTIONAL
    /// 	keyRegex = $someString
    /// 	# OPTIONAL
    /// 	structuredValueRegex = $someString
    /// 	# OPTIONAL
    /// 	structuredDictionaryCsv = $someString
    /// 	# OPTIONAL
    /// 	structuredDictionary = @(
    /// 		$someString
    /// 	)
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
                "AddAdGroupsToHierarchy",
                "AddConfiguredGroupToHierarchy",
                "AddCustomIntelFeed",
                "AddInventoryWorkloads",
                "AddRoleAssignments",
                "AddVlan",
                "AddVmAppConsistentSpecs",
                "AirGapStatus",
                "ApproveTprRequest",
                "ArchiveCrawl",
                "AssignProtection",
                "BatchDeassignRoleFromUserGroups",
                "BulkCreateNasFilesets",
                "CancelDownloadPackage",
                "CancelScheduledUpgrade",
                "CancelTaskchain",
                "CancelTprRequest",
                "ChangePassword",
                "CreateCustomAnalyzer",
                "CreateDistributionListDigestBatch",
                "CreateEventDigestBatch",
                "CreateGuestCredential",
                "CreateLegalHold",
                "CreateOnDemandVolumeGroupBackup",
                "CreateVappsInstantRecovery",
                "DeactivateCustomAnalyzer",
                "DeleteAdGroupsFromHierarchy",
                "DeleteDistributionListDigestBatch",
                "DeleteEventDigest",
                "DeleteGuestCredentialById",
                "DeleteIntelFeed",
                "DeleteVolumeGroupMount",
                "DenyTprRequests",
                "DeregisterPrivateContainerRegistry",
                "DisableSupportUserAccess",
                "DisableTprOrg",
                "DissolveLegalHold",
                "EnableAutomaticFmdUpload",
                "EnableDisableAppConsistency",
                "EnableSupportUserAccess",
                "EnableTprOrg",
                "ExcludeVmDisks",
                "ExecuteTprRequests",
                "ExpireSnoozedDirectories",
                "GenerateConfigProtectionRestoreForm",
                "GenerateSupportBundle",
                "GetDownloadUrl",
                "HideRevealNasNamespaces",
                "InstallIoFilter",
                "InviteSsoGroup",
                "ListCidrsForComputeSetting",
                "LockUsersByAdmin",
                "LogoutFromRubrikSupportPortal",
                "MakePrimary",
                "ManageProtectionForLinkedObjects",
                "ModifyDistributionListDigestBatch",
                "ModifyEventDigestBatch",
                "ModifyIpmi",
                "MountDisk",
                "NotificationForGetLicense",
                "RecoverCloudDirectMultiPaths",
                "RecoverCloudDirectPath",
                "RefreshDomain",
                "RefreshGlobalManagerConnectivityStatus",
                "RemoveDisk",
                "RemoveInventoryWorkloads",
                "RemovePrivateEndpointList",
                "RemoveProxyConfig",
                "RemoveVlans",
                "ReseedLogShippingSecondary",
                "ResetAllOrgUsersPasswords",
                "ResetUsersPasswordsWithUserIds",
                "ResizeDisk",
                "ResolveAnomaly",
                "ResolveVolumeGroupsConflict",
                "RetryBackup",
                "RetryDownloadPackageJob",
                "RevokeAllOrgRoles",
                "RunCustomAnalyzer",
                "ScheduleUpgradeBatchJob",
                "SetAnalyzerRisks",
                "SetBundleApprovalStatus",
                "SetCustomerTags",
                "SetDatastoreFreespaceThresholds",
                "SetIpWhitelistEnabled",
                "SetMfaSetting",
                "SetPrivateContainerRegistry",
                "SetTotpConfig",
                "SetUpgradeType",
                "SetUserLevelTotpEnforcement",
                "SetWorkloadAlertSetting",
                "SetupDisk",
                "StartCrawl",
                "StartDownloadPackageBatchJob",
                "StartExportRdsInstanceJob",
                "StartPeriodicUpgradePrechecksOnDemandJob",
                "StartUpgradeBatchJob",
                "StartVolumeGroupMount",
                "StopJobInstance",
                "StopJobInstanceFromEventSeries",
                "SubmitTprRequest",
                "SupportPortalLogin",
                "SwitchProductToOnboardingMode",
                "TriggerCloudComputeConnectivityCheck",
                "TriggerExocomputeHealthCheck",
                "UninstallIoFilter",
                "UnlockUsersByAdmin",
                "UnmountDisk",
                "UpdateAccountOwner",
                "UpdateAdGroup",
                "UpdateAgentDeploymentSetting",
                "UpdateAgentDeploymentSettingInBatch",
                "UpdateAuthDomainUsersHiddenStatus",
                "UpdateBackupThrottleSetting",
                "UpdateBadDiskLedStatus",
                "UpdateConfiguredGroup",
                "UpdateCustomAnalyzer",
                "UpdateCustomIntelFeed",
                "UpdateCustomerAppPermissions",
                "UpdateDistributionListDigest",
                "UpdateDnsServersAndSearchDomains",
                "UpdateEventDigest",
                "UpdateFloatingIps",
                "UpdateGuestCredential",
                "UpdateInsightState",
                "UpdateIocStatus",
                "UpdateIpWhitelist",
                "UpdateLambdaSettings",
                "UpdateLockoutConfig",
                "UpdateManagedIdentities",
                "UpdateNetworkThrottle",
                "UpdateProxyConfig",
                "UpdateRoleAssignments",
                "UpdateSupportUserAccess",
                "UpdateTprConfiguration",
                "UpdateTunnelStatus",
                "UpdateVlan",
                "UpdateVolumeGroup",
                "UpdateWhitelistedAnalyzers",
                "UpgradeIoFilter",
                "UpgradeToRsc",
                "ValidateAndSaveCustomerKmsInfo",
                "VmMakePrimary",
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
                    case "BulkCreateNasFilesets":
                        this.ProcessRecord_BulkCreateNasFilesets();
                        break;
                    case "CancelDownloadPackage":
                        this.ProcessRecord_CancelDownloadPackage();
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
                    case "CreateCustomAnalyzer":
                        this.ProcessRecord_CreateCustomAnalyzer();
                        break;
                    case "CreateDistributionListDigestBatch":
                        this.ProcessRecord_CreateDistributionListDigestBatch();
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
                    case "CreateVappsInstantRecovery":
                        this.ProcessRecord_CreateVappsInstantRecovery();
                        break;
                    case "DeactivateCustomAnalyzer":
                        this.ProcessRecord_DeactivateCustomAnalyzer();
                        break;
                    case "DeleteAdGroupsFromHierarchy":
                        this.ProcessRecord_DeleteAdGroupsFromHierarchy();
                        break;
                    case "DeleteDistributionListDigestBatch":
                        this.ProcessRecord_DeleteDistributionListDigestBatch();
                        break;
                    case "DeleteEventDigest":
                        this.ProcessRecord_DeleteEventDigest();
                        break;
                    case "DeleteGuestCredentialById":
                        this.ProcessRecord_DeleteGuestCredentialById();
                        break;
                    case "DeleteIntelFeed":
                        this.ProcessRecord_DeleteIntelFeed();
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
                    case "DissolveLegalHold":
                        this.ProcessRecord_DissolveLegalHold();
                        break;
                    case "EnableAutomaticFmdUpload":
                        this.ProcessRecord_EnableAutomaticFmdUpload();
                        break;
                    case "EnableDisableAppConsistency":
                        this.ProcessRecord_EnableDisableAppConsistency();
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
                    case "InstallIoFilter":
                        this.ProcessRecord_InstallIoFilter();
                        break;
                    case "InviteSsoGroup":
                        this.ProcessRecord_InviteSsoGroup();
                        break;
                    case "ListCidrsForComputeSetting":
                        this.ProcessRecord_ListCidrsForComputeSetting();
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
                    case "ManageProtectionForLinkedObjects":
                        this.ProcessRecord_ManageProtectionForLinkedObjects();
                        break;
                    case "ModifyDistributionListDigestBatch":
                        this.ProcessRecord_ModifyDistributionListDigestBatch();
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
                    case "RemoveDisk":
                        this.ProcessRecord_RemoveDisk();
                        break;
                    case "RemoveInventoryWorkloads":
                        this.ProcessRecord_RemoveInventoryWorkloads();
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
                    case "ScheduleUpgradeBatchJob":
                        this.ProcessRecord_ScheduleUpgradeBatchJob();
                        break;
                    case "SetAnalyzerRisks":
                        this.ProcessRecord_SetAnalyzerRisks();
                        break;
                    case "SetBundleApprovalStatus":
                        this.ProcessRecord_SetBundleApprovalStatus();
                        break;
                    case "SetCustomerTags":
                        this.ProcessRecord_SetCustomerTags();
                        break;
                    case "SetDatastoreFreespaceThresholds":
                        this.ProcessRecord_SetDatastoreFreespaceThresholds();
                        break;
                    case "SetIpWhitelistEnabled":
                        this.ProcessRecord_SetIpWhitelistEnabled();
                        break;
                    case "SetMfaSetting":
                        this.ProcessRecord_SetMfaSetting();
                        break;
                    case "SetPrivateContainerRegistry":
                        this.ProcessRecord_SetPrivateContainerRegistry();
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
                    case "SetWorkloadAlertSetting":
                        this.ProcessRecord_SetWorkloadAlertSetting();
                        break;
                    case "SetupDisk":
                        this.ProcessRecord_SetupDisk();
                        break;
                    case "StartCrawl":
                        this.ProcessRecord_StartCrawl();
                        break;
                    case "StartDownloadPackageBatchJob":
                        this.ProcessRecord_StartDownloadPackageBatchJob();
                        break;
                    case "StartExportRdsInstanceJob":
                        this.ProcessRecord_StartExportRdsInstanceJob();
                        break;
                    case "StartPeriodicUpgradePrechecksOnDemandJob":
                        this.ProcessRecord_StartPeriodicUpgradePrechecksOnDemandJob();
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
                    case "UpdateDistributionListDigest":
                        this.ProcessRecord_UpdateDistributionListDigest();
                        break;
                    case "UpdateDnsServersAndSearchDomains":
                        this.ProcessRecord_UpdateDnsServersAndSearchDomains();
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
                    case "UpdateInsightState":
                        this.ProcessRecord_UpdateInsightState();
                        break;
                    case "UpdateIocStatus":
                        this.ProcessRecord_UpdateIocStatus();
                        break;
                    case "UpdateIpWhitelist":
                        this.ProcessRecord_UpdateIpWhitelist();
                        break;
                    case "UpdateLambdaSettings":
                        this.ProcessRecord_UpdateLambdaSettings();
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
                    case "UpdateProxyConfig":
                        this.ProcessRecord_UpdateProxyConfig();
                        break;
                    case "UpdateRoleAssignments":
                        this.ProcessRecord_UpdateRoleAssignments();
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
                    case "VmMakePrimary":
                        this.ProcessRecord_VmMakePrimary();
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
        // bulkCreateNasFilesets.
        internal void ProcessRecord_BulkCreateNasFilesets()
        {
            this._logger.name += " -BulkCreateNasFilesets";
            // Create new graphql operation bulkCreateNasFilesets
            InitMutationBulkCreateNasFilesets();
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
        // createCustomAnalyzer.
        internal void ProcessRecord_CreateCustomAnalyzer()
        {
            this._logger.name += " -CreateCustomAnalyzer";
            // Create new graphql operation createCustomAnalyzer
            InitMutationCreateCustomAnalyzer();
        }

        // This parameter set invokes a single graphql operation:
        // createDistributionListDigestBatch.
        internal void ProcessRecord_CreateDistributionListDigestBatch()
        {
            this._logger.name += " -CreateDistributionListDigestBatch";
            // Create new graphql operation createDistributionListDigestBatch
            InitMutationCreateDistributionListDigestBatch();
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
        // deleteAdGroupsFromHierarchy.
        internal void ProcessRecord_DeleteAdGroupsFromHierarchy()
        {
            this._logger.name += " -DeleteAdGroupsFromHierarchy";
            // Create new graphql operation deleteAdGroupsFromHierarchy
            InitMutationDeleteAdGroupsFromHierarchy();
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
        // deleteIntelFeed.
        internal void ProcessRecord_DeleteIntelFeed()
        {
            this._logger.name += " -DeleteIntelFeed";
            // Create new graphql operation deleteIntelFeed
            InitMutationDeleteIntelFeed();
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
        // dissolveLegalHold.
        internal void ProcessRecord_DissolveLegalHold()
        {
            this._logger.name += " -DissolveLegalHold";
            // Create new graphql operation dissolveLegalHold
            InitMutationDissolveLegalHold();
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
        // listCidrsForComputeSetting.
        internal void ProcessRecord_ListCidrsForComputeSetting()
        {
            this._logger.name += " -ListCidrsForComputeSetting";
            // Create new graphql operation listCidrsForComputeSetting
            InitMutationListCidrsForComputeSetting();
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
        // manageProtectionForLinkedObjects.
        internal void ProcessRecord_ManageProtectionForLinkedObjects()
        {
            this._logger.name += " -ManageProtectionForLinkedObjects";
            // Create new graphql operation manageProtectionForLinkedObjects
            InitMutationManageProtectionForLinkedObjects();
        }

        // This parameter set invokes a single graphql operation:
        // modifyDistributionListDigestBatch.
        internal void ProcessRecord_ModifyDistributionListDigestBatch()
        {
            this._logger.name += " -ModifyDistributionListDigestBatch";
            // Create new graphql operation modifyDistributionListDigestBatch
            InitMutationModifyDistributionListDigestBatch();
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
        // scheduleUpgradeBatchJob.
        internal void ProcessRecord_ScheduleUpgradeBatchJob()
        {
            this._logger.name += " -ScheduleUpgradeBatchJob";
            // Create new graphql operation scheduleUpgradeBatchJob
            InitMutationScheduleUpgradeBatchJob();
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
        // setBundleApprovalStatus.
        internal void ProcessRecord_SetBundleApprovalStatus()
        {
            this._logger.name += " -SetBundleApprovalStatus";
            // Create new graphql operation setBundleApprovalStatus
            InitMutationSetBundleApprovalStatus();
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
        // setIpWhitelistEnabled.
        internal void ProcessRecord_SetIpWhitelistEnabled()
        {
            this._logger.name += " -SetIpWhitelistEnabled";
            // Create new graphql operation setIpWhitelistEnabled
            InitMutationSetIpWhitelistEnabled();
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
        // setPrivateContainerRegistry.
        internal void ProcessRecord_SetPrivateContainerRegistry()
        {
            this._logger.name += " -SetPrivateContainerRegistry";
            // Create new graphql operation setPrivateContainerRegistry
            InitMutationSetPrivateContainerRegistry();
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
        // setWorkloadAlertSetting.
        internal void ProcessRecord_SetWorkloadAlertSetting()
        {
            this._logger.name += " -SetWorkloadAlertSetting";
            // Create new graphql operation setWorkloadAlertSetting
            InitMutationSetWorkloadAlertSetting();
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
        // startCrawl.
        internal void ProcessRecord_StartCrawl()
        {
            this._logger.name += " -StartCrawl";
            // Create new graphql operation startCrawl
            InitMutationStartCrawl();
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
        // startPeriodicUpgradePrechecksOnDemandJob.
        internal void ProcessRecord_StartPeriodicUpgradePrechecksOnDemandJob()
        {
            this._logger.name += " -StartPeriodicUpgradePrechecksOnDemandJob";
            // Create new graphql operation startPeriodicUpgradePrechecksOnDemandJob
            InitMutationStartPeriodicUpgradePrechecksOnDemandJob();
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
        // updateLambdaSettings.
        internal void ProcessRecord_UpdateLambdaSettings()
        {
            this._logger.name += " -UpdateLambdaSettings";
            // Create new graphql operation updateLambdaSettings
            InitMutationUpdateLambdaSettings();
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
        // updateProxyConfig.
        internal void ProcessRecord_UpdateProxyConfig()
        {
            this._logger.name += " -UpdateProxyConfig";
            // Create new graphql operation updateProxyConfig
            InitMutationUpdateProxyConfig();
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
        // vmMakePrimary.
        internal void ProcessRecord_VmMakePrimary()
        {
            this._logger.name += " -VmMakePrimary";
            // Create new graphql operation vmMakePrimary
            InitMutationVmMakePrimary();
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
		# OPTIONAL
		snapMirrorLabelForFullBackup = $someString
		# OPTIONAL
		snapMirrorLabelForIncrementalBackup = $someString
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
	ruleTypes = @(
		$someAnalyzerRuleType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AnalyzerRuleType]) for enum values.
	)
	# OPTIONAL
	keyRegex = $someString
	# OPTIONAL
	structuredValueRegex = $someString
	# OPTIONAL
	structuredDictionaryCsv = $someString
	# OPTIONAL
	structuredDictionary = @(
		$someString
	)
	# OPTIONAL
	risk = $someRiskLevelType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RiskLevelType]) for enum values.
}"
            );
        }

        // Create new GraphQL Mutation:
        // createDistributionListDigestBatch(input: CreateDistributionListDigestBatchInput!): Void
        internal void InitMutationCreateDistributionListDigestBatch()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateDistributionListDigestBatchInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateDistributionListDigestBatch",
                "($input: CreateDistributionListDigestBatchInput!)",
                "System.String",
                Mutation.CreateDistributionListDigestBatch,
                Mutation.CreateDistributionListDigestBatchFieldSpec,
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
        // enableTprOrg(input: EnableTprOrgInput!): Void
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
                "System.String",
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
        // manageProtectionForLinkedObjects(input: ManageProtectionForLinkedObjectsInput!): CreateOnDemandJobReply!
        internal void InitMutationManageProtectionForLinkedObjects()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "ManageProtectionForLinkedObjectsInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationManageProtectionForLinkedObjects",
                "($input: ManageProtectionForLinkedObjectsInput!)",
                "CreateOnDemandJobReply",
                Mutation.ManageProtectionForLinkedObjects,
                Mutation.ManageProtectionForLinkedObjectsFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	operation = $someManageProtectionForLinkedObjectsOperationType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ManageProtectionForLinkedObjectsOperationType]) for enum values.
	# REQUIRED
	assignSlaReq = @{
		# REQUIRED
		slaDomainAssignType = $someSlaAssignTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SlaAssignTypeEnum]) for enum values.
		# OPTIONAL
		slaOptionalId = $someString
		# REQUIRED
		objectIds = @(
			$someString
		)
		# OPTIONAL
		applicableWorkloadType = $someWorkloadLevelHierarchy # Call [Enum]::GetValues([RubrikSecurityCloud.Types.WorkloadLevelHierarchy]) for enum values.
		# OPTIONAL
		shouldApplyToExistingSnapshots = $someBoolean
		# OPTIONAL
		shouldApplyToNonPolicySnapshots = $someBoolean
		# OPTIONAL
		existingSnapshotRetention = $someGlobalExistingSnapshotRetention # Call [Enum]::GetValues([RubrikSecurityCloud.Types.GlobalExistingSnapshotRetention]) for enum values.
		# OPTIONAL
		userNote = $someString
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // modifyDistributionListDigestBatch(input: ModifyDistributionListDigestBatchInput!): Void
        internal void InitMutationModifyDistributionListDigestBatch()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "ModifyDistributionListDigestBatchInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationModifyDistributionListDigestBatch",
                "($input: ModifyDistributionListDigestBatchInput!)",
                "System.String",
                Mutation.ModifyDistributionListDigestBatch,
                Mutation.ModifyDistributionListDigestBatchFieldSpec,
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
	# REQUIRED
	invalidateAllSessions = $someBoolean
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
				ruleTypes = @(
					$someAnalyzerRuleType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AnalyzerRuleType]) for enum values.
				)
				# OPTIONAL
				keyRegex = $someString
				# OPTIONAL
				structuredValueRegex = $someString
				# OPTIONAL
				structuredDictionaryCsv = $someString
				# OPTIONAL
				structuredDictionary = @(
					$someString
				)
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
	ruleTypes = @(
		$someAnalyzerRuleType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AnalyzerRuleType]) for enum values.
	)
	# OPTIONAL
	keyRegex = $someString
	# OPTIONAL
	structuredValueRegex = $someString
	# OPTIONAL
	structuredDictionaryCsv = $someString
	# OPTIONAL
	structuredDictionary = @(
		$someString
	)
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