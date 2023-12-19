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
    /// Create a new RscQuery object for any of the 186
    /// operations in the 'Miscellaneous' API domain:
    /// AddAdGroupsToHierarchy, AddClusterNodes, AddConfiguredGroupToHierarchy, AddInventoryWorkloads, AddPolicyObjects, AddRoleAssignments, AddSyslogExportRule, AddVlan, AddVmAppConsistentSpecs, ArchiveCrawl, AssignProtection, BatchDeassignRoleFromUserGroups, BulkCreateNasFilesets, BulkDeleteFailoverClusterApp, BulkDeleteNasSystems, CancelDownloadPackage, CancelScheduledUpgrade, CancelTaskchain, ChangePassword, CreateActiveDirectoryLiveMount, CreateActiveDirectoryUnmount, CreateCustomAnalyzer, CreateFailoverClusterApp, CreateGlacierReaderTarget, CreateGuestCredential, CreateIntegration, CreateIntegrations, CreateManualTargetMapping, CreateOnDemandVolumeGroupBackup, CreateOrg, CreateOrgSwitchSession, CreatePolicy, CreateRole, CreateS3CompatibleReaderTarget, CreateS3CompatibleTarget, CreateUser, CreateUserWithPassword, CreateVappsInstantRecovery, DeactivateCustomAnalyzer, DeactivatePolicy, DeleteAdGroupsFromHierarchy, DeleteCsr, DeleteDistributionListDigestBatch, DeleteEventDigest, DeleteFailoverClusterApp, DeleteGuestCredentialById, DeleteIntegration, DeleteIntegrations, DeleteLogShipping, DeleteNasSystem, DeleteOrg, DeleteRole, DeleteSyslogExportRule, DeleteTarget, DeleteTargetMapping, DeleteTotpConfig, DeleteTotpConfigs, DeleteVolumeGroupMount, DisableSupportUserAccess, DisableTarget, EnableAutomaticFmdUpload, EnableDisableAppConsistency, EnableSupportUserAccess, EnableTarget, ExcludeVmDisks, GenerateClusterRegistrationToken, GenerateConfigProtectionRestoreForm, GenerateCsr, GenerateSupportBundle, GenerateTotpSecret, GetDownloadUrl, GetHealthMonitorPolicyStatus, HideRevealNasNamespaces, HideRevealNasShares, InstallIoFilter, InviteSsoGroup, ListCidrsForComputeSetting, LockUsersByAdmin, LogoutFromRubrikSupportPortal, MakePrimary, ModifyActiveDirectoryLiveMount, ModifyIpmi, MountDisk, MutateRole, NotificationForGetLicense, PauseTarget, PromoteReaderTarget, RecoverCloudDirectMultiPaths, RecoverCloudDirectPath, RefreshDomain, RefreshGlobalManagerConnectivityStatus, RefreshNasSystems, RefreshReaderTarget, RegisterNasSystem, RemoveClusterNodes, RemoveDisk, RemoveInventoryWorkloads, RemovePolicyObjects, RemovePrivateEndpointList, RemoveProxyConfig, RemoveVlans, ReseedLogShippingSecondary, ResetAllOrgUsersPasswords, ResetUsersPasswordsWithUserIds, ResizeDisk, ResolveVolumeGroupsConflict, RestoreActiveDirectoryObjects, ResumeTarget, RetryBackup, RetryDownloadPackageJob, RevokeAllOrgRoles, RunCustomAnalyzer, ScheduleUpgradeBatchJob, SetAnalyzerRisks, SetCustomerTags, SetDatastoreFreespaceThresholds, SetIpWhitelistEnabled, SetMfaSetting, SetPasswordComplexityPolicy, SetTotpConfig, SetUpgradeType, SetUserLevelTotpEnforcement, SetWorkloadAlertSetting, SetupDisk, StartCrawl, StartDownloadPackageBatchJob, StartExportRdsInstanceJob, StartPeriodicUpgradePrechecksOnDemandJob, StartUpgradeBatchJob, StartVolumeGroupMount, StopJobInstance, StopJobInstanceFromEventSeries, SupportPortalLogin, TestSyslogExportRule, TriggerCloudComputeConnectivityCheck, TriggerExocomputeHealthCheck, UninstallIoFilter, UnlockUsersByAdmin, UnmountDisk, UpdateAccountOwner, UpdateAuthDomainUsersHiddenStatus, UpdateAutoEnablePolicyClusterConfig, UpdateBadDiskLedStatus, UpdateClusterDefaultAddress, UpdateClusterLocation, UpdateClusterNtpServers, UpdateClusterSettings, UpdateConfiguredGroup, UpdateCustomAnalyzer, UpdateDistributionListDigest, UpdateDnsServersAndSearchDomains, UpdateEventDigest, UpdateFailoverClusterApp, UpdateFloatingIps, UpdateGlacierTarget, UpdateGuestCredential, UpdateHealthMonitorPolicyStatus, UpdateInsightState, UpdateIntegration, UpdateIntegrations, UpdateIpWhitelist, UpdateLambdaSettings, UpdateLockoutConfig, UpdateManualTargetMapping, UpdateNasShares, UpdateNasSystem, UpdateNetworkThrottle, UpdateOrg, UpdateOrgSecurityPolicy, UpdatePolicy, UpdatePreviewerClusterConfig, UpdateProxyConfig, UpdateRole, UpdateRoleAssignments, UpdateS3CompatibleTarget, UpdateSnmpConfig, UpdateSupportUserAccess, UpdateSyslogExportRule, UpdateTunnelStatus, UpdateVolumeGroup, UpdateWhitelistedAnalyzers, UpgradeCdmManagedTarget, UpgradeIoFilter, UpgradeToRsc, ValidateAndSaveCustomerKmsInfo, or WarmSearchCache.
    /// </summary>
    /// <description>
    /// New-RscMutationMisc creates a new
    /// mutation object for operations
    /// in the 'Miscellaneous' API domain. It only creates a data structure,
    /// it does not execute the operation. This cmdlet does not need a
    /// connection to run. To execute the operation, either call Invoke()
    /// on the object returned by this cmdlet, or pass the object to
    /// Invoke-Rsc.
    /// There are 186 operations
    /// in the 'Miscellaneous' API domain. Select the operation this
    /// query is for by specifying the appropriate value for the
    /// -Operation parameter;
    /// one of: AddAdGroupsToHierarchy, AddClusterNodes, AddConfiguredGroupToHierarchy, AddInventoryWorkloads, AddPolicyObjects, AddRoleAssignments, AddSyslogExportRule, AddVlan, AddVmAppConsistentSpecs, ArchiveCrawl, AssignProtection, BatchDeassignRoleFromUserGroups, BulkCreateNasFilesets, BulkDeleteFailoverClusterApp, BulkDeleteNasSystems, CancelDownloadPackage, CancelScheduledUpgrade, CancelTaskchain, ChangePassword, CreateActiveDirectoryLiveMount, CreateActiveDirectoryUnmount, CreateCustomAnalyzer, CreateFailoverClusterApp, CreateGlacierReaderTarget, CreateGuestCredential, CreateIntegration, CreateIntegrations, CreateManualTargetMapping, CreateOnDemandVolumeGroupBackup, CreateOrg, CreateOrgSwitchSession, CreatePolicy, CreateRole, CreateS3CompatibleReaderTarget, CreateS3CompatibleTarget, CreateUser, CreateUserWithPassword, CreateVappsInstantRecovery, DeactivateCustomAnalyzer, DeactivatePolicy, DeleteAdGroupsFromHierarchy, DeleteCsr, DeleteDistributionListDigestBatch, DeleteEventDigest, DeleteFailoverClusterApp, DeleteGuestCredentialById, DeleteIntegration, DeleteIntegrations, DeleteLogShipping, DeleteNasSystem, DeleteOrg, DeleteRole, DeleteSyslogExportRule, DeleteTarget, DeleteTargetMapping, DeleteTotpConfig, DeleteTotpConfigs, DeleteVolumeGroupMount, DisableSupportUserAccess, DisableTarget, EnableAutomaticFmdUpload, EnableDisableAppConsistency, EnableSupportUserAccess, EnableTarget, ExcludeVmDisks, GenerateClusterRegistrationToken, GenerateConfigProtectionRestoreForm, GenerateCsr, GenerateSupportBundle, GenerateTotpSecret, GetDownloadUrl, GetHealthMonitorPolicyStatus, HideRevealNasNamespaces, HideRevealNasShares, InstallIoFilter, InviteSsoGroup, ListCidrsForComputeSetting, LockUsersByAdmin, LogoutFromRubrikSupportPortal, MakePrimary, ModifyActiveDirectoryLiveMount, ModifyIpmi, MountDisk, MutateRole, NotificationForGetLicense, PauseTarget, PromoteReaderTarget, RecoverCloudDirectMultiPaths, RecoverCloudDirectPath, RefreshDomain, RefreshGlobalManagerConnectivityStatus, RefreshNasSystems, RefreshReaderTarget, RegisterNasSystem, RemoveClusterNodes, RemoveDisk, RemoveInventoryWorkloads, RemovePolicyObjects, RemovePrivateEndpointList, RemoveProxyConfig, RemoveVlans, ReseedLogShippingSecondary, ResetAllOrgUsersPasswords, ResetUsersPasswordsWithUserIds, ResizeDisk, ResolveVolumeGroupsConflict, RestoreActiveDirectoryObjects, ResumeTarget, RetryBackup, RetryDownloadPackageJob, RevokeAllOrgRoles, RunCustomAnalyzer, ScheduleUpgradeBatchJob, SetAnalyzerRisks, SetCustomerTags, SetDatastoreFreespaceThresholds, SetIpWhitelistEnabled, SetMfaSetting, SetPasswordComplexityPolicy, SetTotpConfig, SetUpgradeType, SetUserLevelTotpEnforcement, SetWorkloadAlertSetting, SetupDisk, StartCrawl, StartDownloadPackageBatchJob, StartExportRdsInstanceJob, StartPeriodicUpgradePrechecksOnDemandJob, StartUpgradeBatchJob, StartVolumeGroupMount, StopJobInstance, StopJobInstanceFromEventSeries, SupportPortalLogin, TestSyslogExportRule, TriggerCloudComputeConnectivityCheck, TriggerExocomputeHealthCheck, UninstallIoFilter, UnlockUsersByAdmin, UnmountDisk, UpdateAccountOwner, UpdateAuthDomainUsersHiddenStatus, UpdateAutoEnablePolicyClusterConfig, UpdateBadDiskLedStatus, UpdateClusterDefaultAddress, UpdateClusterLocation, UpdateClusterNtpServers, UpdateClusterSettings, UpdateConfiguredGroup, UpdateCustomAnalyzer, UpdateDistributionListDigest, UpdateDnsServersAndSearchDomains, UpdateEventDigest, UpdateFailoverClusterApp, UpdateFloatingIps, UpdateGlacierTarget, UpdateGuestCredential, UpdateHealthMonitorPolicyStatus, UpdateInsightState, UpdateIntegration, UpdateIntegrations, UpdateIpWhitelist, UpdateLambdaSettings, UpdateLockoutConfig, UpdateManualTargetMapping, UpdateNasShares, UpdateNasSystem, UpdateNetworkThrottle, UpdateOrg, UpdateOrgSecurityPolicy, UpdatePolicy, UpdatePreviewerClusterConfig, UpdateProxyConfig, UpdateRole, UpdateRoleAssignments, UpdateS3CompatibleTarget, UpdateSnmpConfig, UpdateSupportUserAccess, UpdateSyslogExportRule, UpdateTunnelStatus, UpdateVolumeGroup, UpdateWhitelistedAnalyzers, UpgradeCdmManagedTarget, UpgradeIoFilter, UpgradeToRsc, ValidateAndSaveCustomerKmsInfo, or WarmSearchCache.
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
    /// Runs the AddClusterNodes operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: AddClusterNodes
    /// 
    /// $query = New-RscMutationMisc -AddClusterNodes
    /// 
    /// # REQUIRED
    /// $query.Var.AddClusterNodesInput = @{
    /// 	# REQUIRED
    /// 	clusterUuid = $someString
    /// 	# REQUIRED
    /// 	nodesMap = @(
    /// 		@{
    /// 			# OPTIONAL
    /// 			key = $someString
    /// 			# REQUIRED
    /// 			value = @{
    /// 				# OPTIONAL
    /// 				dataIpConfig = @{
    /// 					# OPTIONAL
    /// 					vlan = $someInt
    /// 					# REQUIRED
    /// 					address = $someString
    /// 					# REQUIRED
    /// 					gateway = $someString
    /// 					# REQUIRED
    /// 					netmask = $someString
    /// 				}
    /// 				# REQUIRED
    /// 				ipmiIpConfig = @{
    /// 					# OPTIONAL
    /// 					vlan = $someInt
    /// 					# REQUIRED
    /// 					address = $someString
    /// 					# REQUIRED
    /// 					gateway = $someString
    /// 					# REQUIRED
    /// 					netmask = $someString
    /// 				}
    /// 				# REQUIRED
    /// 				managementIpConfig = @{
    /// 					# OPTIONAL
    /// 					vlan = $someInt
    /// 					# REQUIRED
    /// 					address = $someString
    /// 					# REQUIRED
    /// 					gateway = $someString
    /// 					# REQUIRED
    /// 					netmask = $someString
    /// 				}
    /// 				# OPTIONAL
    /// 				vlanIpConfigs = @(
    /// 					@{
    /// 						# REQUIRED
    /// 						ip = $someString
    /// 						# REQUIRED
    /// 						vlan = $someInt
    /// 					}
    /// 				)
    /// 			}
    /// 		}
    /// 	)
    /// 	# REQUIRED
    /// 	request = @{
    /// 		# OPTIONAL
    /// 		encryptionPassword = $someString
    /// 		# OPTIONAL
    /// 		isIpv4ManualDiscoveryMode = $someBoolean
    /// 		# OPTIONAL
    /// 		isLinkLocalIpv4Mode = $someBoolean
    /// 		# REQUIRED
    /// 		ipmiPassword = $someString
    /// 	}
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AddClusterNodesReply
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
    /// Runs the AddPolicyObjects operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: AddPolicyObjects
    /// 
    /// $query = New-RscMutationMisc -AddPolicyObjects
    /// 
    /// # REQUIRED
    /// $query.Var.policyIds = @(
    /// 	$someString
    /// )
    /// # REQUIRED
    /// $query.Var.objectIds = @(
    /// 	$someString
    /// )
    /// # REQUIRED
    /// $query.Var.objectRootIds = @(
    /// 	$someString
    /// )
    /// # REQUIRED
    /// $query.Var.clusterIds = @(
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
    /// Runs the AddSyslogExportRule operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: AddSyslogExportRule
    /// 
    /// $query = New-RscMutationMisc -AddSyslogExportRule
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	syslogExportRuleV51 = @{
    /// 		# OPTIONAL
    /// 		syslogCertificateInfo = @{
    /// 			# OPTIONAL
    /// 			serverCertificate = $someString
    /// 			# OPTIONAL
    /// 			serverCertificateName = $someString
    /// 		}
    /// 		# OPTIONAL
    /// 		syslogExportRuleFull = @{
    /// 			# OPTIONAL
    /// 			certificateId = $someString
    /// 			# REQUIRED
    /// 			facility = $someSyslogFacility # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogFacility]) for enum values.
    /// 			# REQUIRED
    /// 			protocol = $someTransportLayerProtocol # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TransportLayerProtocol]) for enum values.
    /// 			# REQUIRED
    /// 			severity = $someSyslogSeverity # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogSeverity]) for enum values.
    /// 			# REQUIRED
    /// 			enableTls = $someBoolean
    /// 			# REQUIRED
    /// 			hostname = $someString
    /// 			# REQUIRED
    /// 			port = $someInt
    /// 		}
    /// 	}
    /// 	# OPTIONAL
    /// 	syslogExportRuleV52 = @{
    /// 		# OPTIONAL
    /// 		certificateId = $someString
    /// 		# REQUIRED
    /// 		facility = $someSyslogFacility # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogFacility]) for enum values.
    /// 		# REQUIRED
    /// 		protocol = $someTransportLayerProtocol # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TransportLayerProtocol]) for enum values.
    /// 		# REQUIRED
    /// 		severity = $someSyslogSeverity # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogSeverity]) for enum values.
    /// 		# REQUIRED
    /// 		enableTls = $someBoolean
    /// 		# REQUIRED
    /// 		hostname = $someString
    /// 		# REQUIRED
    /// 		port = $someInt
    /// 	}
    /// 	# OPTIONAL
    /// 	syslogExportRuleV53 = @{
    /// 		# OPTIONAL
    /// 		certificateId = $someString
    /// 		# REQUIRED
    /// 		facility = $someSyslogFacility # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogFacility]) for enum values.
    /// 		# REQUIRED
    /// 		protocol = $someTransportLayerProtocol # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TransportLayerProtocol]) for enum values.
    /// 		# REQUIRED
    /// 		severity = $someSyslogSeverity # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogSeverity]) for enum values.
    /// 		# REQUIRED
    /// 		enableTls = $someBoolean
    /// 		# REQUIRED
    /// 		hostname = $someString
    /// 		# REQUIRED
    /// 		port = $someInt
    /// 	}
    /// 	# OPTIONAL
    /// 	syslogExportRuleV60 = @{
    /// 		# OPTIONAL
    /// 		certificateId = $someString
    /// 		# REQUIRED
    /// 		facility = $someSyslogFacility # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogFacility]) for enum values.
    /// 		# REQUIRED
    /// 		protocol = $someTransportLayerProtocol # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TransportLayerProtocol]) for enum values.
    /// 		# REQUIRED
    /// 		severity = $someSyslogSeverity # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogSeverity]) for enum values.
    /// 		# REQUIRED
    /// 		enableTls = $someBoolean
    /// 		# REQUIRED
    /// 		hostname = $someString
    /// 		# REQUIRED
    /// 		port = $someInt
    /// 	}
    /// 	# OPTIONAL
    /// 	syslogExportRuleV70 = @{
    /// 		# OPTIONAL
    /// 		certificateId = $someString
    /// 		# REQUIRED
    /// 		facility = $someSyslogFacility # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogFacility]) for enum values.
    /// 		# REQUIRED
    /// 		protocol = $someTransportLayerProtocol # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TransportLayerProtocol]) for enum values.
    /// 		# REQUIRED
    /// 		severity = $someSyslogSeverity # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogSeverity]) for enum values.
    /// 		# REQUIRED
    /// 		enableTls = $someBoolean
    /// 		# REQUIRED
    /// 		hostname = $someString
    /// 		# REQUIRED
    /// 		port = $someInt
    /// 	}
    /// 	# OPTIONAL
    /// 	syslogExportRuleV80 = @{
    /// 		# OPTIONAL
    /// 		certificateId = $someString
    /// 		# REQUIRED
    /// 		facility = $someSyslogFacility # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogFacility]) for enum values.
    /// 		# REQUIRED
    /// 		protocol = $someTransportLayerProtocol # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TransportLayerProtocol]) for enum values.
    /// 		# REQUIRED
    /// 		severity = $someSyslogSeverity # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogSeverity]) for enum values.
    /// 		# REQUIRED
    /// 		enableTls = $someBoolean
    /// 		# REQUIRED
    /// 		hostname = $someString
    /// 		# REQUIRED
    /// 		port = $someInt
    /// 	}
    /// 	# OPTIONAL
    /// 	syslogExportRuleV81 = @{
    /// 		# OPTIONAL
    /// 		certificateId = $someString
    /// 		# REQUIRED
    /// 		facility = $someSyslogFacility # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogFacility]) for enum values.
    /// 		# REQUIRED
    /// 		protocol = $someTransportLayerProtocol # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TransportLayerProtocol]) for enum values.
    /// 		# REQUIRED
    /// 		severity = $someSyslogSeverity # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogSeverity]) for enum values.
    /// 		# REQUIRED
    /// 		enableTls = $someBoolean
    /// 		# REQUIRED
    /// 		hostname = $someString
    /// 		# REQUIRED
    /// 		port = $someInt
    /// 	}
    /// 	# OPTIONAL
    /// 	syslogExportRuleV90 = @{
    /// 		# OPTIONAL
    /// 		certificateId = $someString
    /// 		# REQUIRED
    /// 		facility = $someSyslogFacility # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogFacility]) for enum values.
    /// 		# REQUIRED
    /// 		protocol = $someTransportLayerProtocol # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TransportLayerProtocol]) for enum values.
    /// 		# REQUIRED
    /// 		severity = $someSyslogSeverity # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogSeverity]) for enum values.
    /// 		# REQUIRED
    /// 		enableTls = $someBoolean
    /// 		# REQUIRED
    /// 		hostname = $someString
    /// 		# REQUIRED
    /// 		port = $someInt
    /// 	}
    /// 	# OPTIONAL
    /// 	syslogExportRuleV91 = @{
    /// 		# OPTIONAL
    /// 		certificateId = $someString
    /// 		# REQUIRED
    /// 		facility = $someSyslogFacility # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogFacility]) for enum values.
    /// 		# REQUIRED
    /// 		protocol = $someTransportLayerProtocol # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TransportLayerProtocol]) for enum values.
    /// 		# REQUIRED
    /// 		severity = $someSyslogSeverity # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogSeverity]) for enum values.
    /// 		# REQUIRED
    /// 		enableTls = $someBoolean
    /// 		# REQUIRED
    /// 		hostname = $someString
    /// 		# REQUIRED
    /// 		port = $someInt
    /// 	}
    /// 	# REQUIRED
    /// 	clusterUuid = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AddSyslogExportRuleReply
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
    /// 			filesetOptions = @{
    /// 				# OPTIONAL
    /// 				allowBackupHiddenFoldersInNetworkMounts = $someBoolean
    /// 				# OPTIONAL
    /// 				allowBackupNetworkMounts = $someBoolean
    /// 				# OPTIONAL
    /// 				useWindowsVss = $someBoolean
    /// 			}
    /// 			# OPTIONAL
    /// 			operatingSystemType = $someFilesetTemplateCreateOperatingSystemType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.FilesetTemplateCreateOperatingSystemType]) for enum values.
    /// 			# OPTIONAL
    /// 			shareType = $someFilesetTemplateCreateShareType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.FilesetTemplateCreateShareType]) for enum values.
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
    /// Runs the BulkDeleteFailoverClusterApp operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: BulkDeleteFailoverClusterApp
    /// 
    /// $query = New-RscMutationMisc -BulkDeleteFailoverClusterApp
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	preserveSnapshots = $someBoolean
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
    /// Write-Host $result.GetType().Name # prints: ResponseSuccess
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the BulkDeleteNasSystems operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: BulkDeleteNasSystems
    /// 
    /// $query = New-RscMutationMisc -BulkDeleteNasSystems
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	bulkDeleteNasSystemRequest = @{
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
    /// Write-Host $result.GetType().Name # prints: BatchAsyncRequestStatus
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
    /// Runs the CreateActiveDirectoryLiveMount operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: CreateActiveDirectoryLiveMount
    /// 
    /// $query = New-RscMutationMisc -CreateActiveDirectoryLiveMount
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	config = @{
    /// 		# OPTIONAL
    /// 		validUsers = @(
    /// 			$someString
    /// 		)
    /// 		# OPTIONAL
    /// 		validIps = @(
    /// 			$someString
    /// 		)
    /// 		# OPTIONAL
    /// 		password = $someString
    /// 		# OPTIONAL
    /// 		domainName = $someString
    /// 		# OPTIONAL
    /// 		subnet = $someString
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
    /// Runs the CreateActiveDirectoryUnmount operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: CreateActiveDirectoryUnmount
    /// 
    /// $query = New-RscMutationMisc -CreateActiveDirectoryUnmount
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
    /// Runs the CreateFailoverClusterApp operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: CreateFailoverClusterApp
    /// 
    /// $query = New-RscMutationMisc -CreateFailoverClusterApp
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	config = @{
    /// 		# OPTIONAL
    /// 		configuredSlaDomainId = $someString
    /// 		# REQUIRED
    /// 		failoverClusterType = $someFailoverClusterType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.FailoverClusterType]) for enum values.
    /// 		# REQUIRED
    /// 		failoverClusterAppSource = @{
    /// 			# OPTIONAL
    /// 			nodeOrders = @(
    /// 				@{
    /// 					# OPTIONAL
    /// 					nodeName = $someString
    /// 					# REQUIRED
    /// 					nodeId = $someString
    /// 					# REQUIRED
    /// 					order = $someInt
    /// 				}
    /// 			)
    /// 			# OPTIONAL
    /// 			virtualIps = @(
    /// 				$someString
    /// 			)
    /// 			# OPTIONAL
    /// 			vips = @(
    /// 				$someString
    /// 			)
    /// 		}
    /// 		# REQUIRED
    /// 		failoverClusterId = $someString
    /// 		# REQUIRED
    /// 		name = $someString
    /// 	}
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: CreateFailoverClusterAppReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CreateGlacierReaderTarget operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: CreateGlacierReaderTarget
    /// 
    /// $query = New-RscMutationMisc -CreateGlacierReaderTarget
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	name = $someString
    /// 	# REQUIRED
    /// 	cloudAccountId = $someString
    /// 	# REQUIRED
    /// 	vaultName = $someString
    /// 	# REQUIRED
    /// 	region = $someAwsRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsRegion]) for enum values.
    /// 	# OPTIONAL
    /// 	encryptionPassword = $someString
    /// 	# REQUIRED
    /// 	clusterUuid = $someString
    /// 	# OPTIONAL
    /// 	retrievalTier = $someAwsRetrievalTier # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsRetrievalTier]) for enum values.
    /// 	# REQUIRED
    /// 	readerRetrievalMethod = $someReaderRetrievalMethod # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ReaderRetrievalMethod]) for enum values.
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: Target
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
    /// Runs the CreateIntegration operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: CreateIntegration
    /// 
    /// $query = New-RscMutationMisc -CreateIntegration
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	name = $someString
    /// 	# REQUIRED
    /// 	integrationType = $someIntegrationType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.IntegrationType]) for enum values.
    /// 	# REQUIRED
    /// 	config = @{
    /// 		# OPTIONAL
    /// 		dataLossPrevention = @{
    /// 			# OPTIONAL
    /// 			policies = @(
    /// 				$someString
    /// 			)
    /// 			# OPTIONAL
    /// 			genericNas = @{
    /// 				# REQUIRED
    /// 				workloadId = $someString
    /// 				# REQUIRED
    /// 				shareType = $someDlpConfigShareType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DlpConfigShareType]) for enum values.
    /// 				# REQUIRED
    /// 				shareId = $someString
    /// 				# REQUIRED
    /// 				path = $someString
    /// 			}
    /// 			# OPTIONAL
    /// 			vmwareVm = @{
    /// 				# REQUIRED
    /// 				workloadId = $someString
    /// 				# REQUIRED
    /// 				osType = $someDlpConfigOsType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DlpConfigOsType]) for enum values.
    /// 				# REQUIRED
    /// 				path = $someString
    /// 			}
    /// 			# OPTIONAL
    /// 			serviceAccountId = $someString
    /// 			# OPTIONAL
    /// 			serviceAccountName = $someString
    /// 			# OPTIONAL
    /// 			status = @{
    /// 				# OPTIONAL
    /// 				code = $someDlpStatusCode # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DlpStatusCode]) for enum values.
    /// 			}
    /// 			# REQUIRED
    /// 			targetType = $someDlpConfigTargetType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DlpConfigTargetType]) for enum values.
    /// 		}
    /// 	}
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: CreateIntegrationReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CreateIntegrations operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: CreateIntegrations
    /// 
    /// $query = New-RscMutationMisc -CreateIntegrations
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	integrations = @(
    /// 		@{
    /// 			# REQUIRED
    /// 			name = $someString
    /// 			# REQUIRED
    /// 			integrationType = $someIntegrationType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.IntegrationType]) for enum values.
    /// 			# REQUIRED
    /// 			config = @{
    /// 				# OPTIONAL
    /// 				dataLossPrevention = @{
    /// 					# OPTIONAL
    /// 					policies = @(
    /// 						$someString
    /// 					)
    /// 					# OPTIONAL
    /// 					genericNas = @{
    /// 						# REQUIRED
    /// 						workloadId = $someString
    /// 						# REQUIRED
    /// 						shareType = $someDlpConfigShareType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DlpConfigShareType]) for enum values.
    /// 						# REQUIRED
    /// 						shareId = $someString
    /// 						# REQUIRED
    /// 						path = $someString
    /// 					}
    /// 					# OPTIONAL
    /// 					vmwareVm = @{
    /// 						# REQUIRED
    /// 						workloadId = $someString
    /// 						# REQUIRED
    /// 						osType = $someDlpConfigOsType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DlpConfigOsType]) for enum values.
    /// 						# REQUIRED
    /// 						path = $someString
    /// 					}
    /// 					# OPTIONAL
    /// 					serviceAccountId = $someString
    /// 					# OPTIONAL
    /// 					serviceAccountName = $someString
    /// 					# OPTIONAL
    /// 					status = @{
    /// 						# OPTIONAL
    /// 						code = $someDlpStatusCode # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DlpStatusCode]) for enum values.
    /// 					}
    /// 					# REQUIRED
    /// 					targetType = $someDlpConfigTargetType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DlpConfigTargetType]) for enum values.
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
    /// Write-Host $result.GetType().Name # prints: CreateIntegrationsReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CreateManualTargetMapping operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: CreateManualTargetMapping
    /// 
    /// $query = New-RscMutationMisc -CreateManualTargetMapping
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	name = $someString
    /// 	# OPTIONAL
    /// 	type = $someTargetType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TargetType]) for enum values.
    /// 	# OPTIONAL
    /// 	archivalLocationClusterMappings = @(
    /// 		@{
    /// 			# OPTIONAL
    /// 			locationId = $someString
    /// 			# OPTIONAL
    /// 			clusterUuid = $someString
    /// 		}
    /// 	)
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: TargetMapping
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
    /// Runs the CreateOrg operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: CreateOrg
    /// 
    /// $query = New-RscMutationMisc -CreateOrg
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	name = $someString
    /// 	# REQUIRED
    /// 	fullName = $someString
    /// 	# REQUIRED
    /// 	description = $someString
    /// 	# REQUIRED
    /// 	authDomainConfig = $someTenantAuthDomainConfig # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TenantAuthDomainConfig]) for enum values.
    /// 	# REQUIRED
    /// 	shouldEnforceMfaForAll = $someBoolean
    /// 	# REQUIRED
    /// 	isEnvoyRequired = $someBoolean
    /// 	# REQUIRED
    /// 	allowedClusters = @(
    /// 		$someString
    /// 	)
    /// 	# OPTIONAL
    /// 	existingUsers = @(
    /// 		@{
    /// 			# REQUIRED
    /// 			id = $someString
    /// 			# REQUIRED
    /// 			isOrgAdmin = $someBoolean
    /// 		}
    /// 	)
    /// 	# OPTIONAL
    /// 	userInvites = @(
    /// 		@{
    /// 			# REQUIRED
    /// 			email = $someString
    /// 			# REQUIRED
    /// 			note = $someString
    /// 			# REQUIRED
    /// 			isOrgAdmin = $someBoolean
    /// 		}
    /// 	)
    /// 	# REQUIRED
    /// 	permissions = @(
    /// 		@{
    /// 			# REQUIRED
    /// 			operation = $someOperation # Call [Enum]::GetValues([RubrikSecurityCloud.Types.Operation]) for enum values.
    /// 			# REQUIRED
    /// 			objectsForHierarchyTypes = @(
    /// 				@{
    /// 					# REQUIRED
    /// 					objectIds = @(
    /// 						$someString
    /// 					)
    /// 					# REQUIRED
    /// 					snappableType = $someWorkloadLevelHierarchy # Call [Enum]::GetValues([RubrikSecurityCloud.Types.WorkloadLevelHierarchy]) for enum values.
    /// 				}
    /// 			)
    /// 		}
    /// 	)
    /// 	# REQUIRED
    /// 	selfServicePermissions = @(
    /// 		@{
    /// 			# OPTIONAL
    /// 			inventoryRoot = $someInventorySubHierarchyRootEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.InventorySubHierarchyRootEnum]) for enum values.
    /// 			# REQUIRED
    /// 			inventoryWorkloadType = $someWorkloadLevelHierarchy # Call [Enum]::GetValues([RubrikSecurityCloud.Types.WorkloadLevelHierarchy]) for enum values.
    /// 			# REQUIRED
    /// 			operations = @(
    /// 				$someOperation # Call [Enum]::GetValues([RubrikSecurityCloud.Types.Operation]) for enum values.
    /// 			)
    /// 			# OPTIONAL
    /// 			hierarchyRoot = $someString
    /// 		}
    /// 	)
    /// 	# OPTIONAL
    /// 	existingSsoGroups = @(
    /// 		@{
    /// 			# REQUIRED
    /// 			id = $someString
    /// 			# REQUIRED
    /// 			isOrgAdmin = $someBoolean
    /// 		}
    /// 	)
    /// 	# OPTIONAL
    /// 	newSsoGroups = @(
    /// 		@{
    /// 			# REQUIRED
    /// 			name = $someString
    /// 			# REQUIRED
    /// 			isOrgAdmin = $someBoolean
    /// 		}
    /// 	)
    /// 	# OPTIONAL
    /// 	isServiceAccountEnabled = $someBoolean
    /// 	# OPTIONAL
    /// 	crossAccountCapabilities = @(
    /// 		$someCrossAccountCapability # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CrossAccountCapability]) for enum values.
    /// 	)
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: CreateOrgReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CreateOrgSwitchSession operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: CreateOrgSwitchSession
    /// 
    /// $query = New-RscMutationMisc -CreateOrgSwitchSession
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	orgId = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: CreateOrgSwitchSessionReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CreatePolicy operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: CreatePolicy
    /// 
    /// $query = New-RscMutationMisc -CreatePolicy
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	id = $someString
    /// 	# OPTIONAL
    /// 	name = $someString
    /// 	# OPTIONAL
    /// 	description = $someString
    /// 	# OPTIONAL
    /// 	colorEnum = $someClassificationPolicyColor # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ClassificationPolicyColor]) for enum values.
    /// 	# OPTIONAL
    /// 	mode = $someClassificationPolicyMode # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ClassificationPolicyMode]) for enum values.
    /// 	# OPTIONAL
    /// 	analyzerIds = @(
    /// 		$someString
    /// 	)
    /// 	# OPTIONAL
    /// 	updateName = $someBoolean
    /// 	# OPTIONAL
    /// 	updateDescription = $someBoolean
    /// 	# OPTIONAL
    /// 	updateMode = $someBoolean
    /// 	# OPTIONAL
    /// 	updateAnalyzerIds = $someBoolean
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: ClassificationPolicyDetail
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CreateRole operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: CreateRole
    /// 
    /// $query = New-RscMutationMisc -CreateRole
    /// 
    /// # REQUIRED
    /// $query.Var.name = $someString
    /// # REQUIRED
    /// $query.Var.description = $someString
    /// # REQUIRED
    /// $query.Var.permissions = @(
    /// 	@{
    /// 		# REQUIRED
    /// 		operation = $someOperation # Call [Enum]::GetValues([RubrikSecurityCloud.Types.Operation]) for enum values.
    /// 		# REQUIRED
    /// 		objectsForHierarchyTypes = @(
    /// 			@{
    /// 				# REQUIRED
    /// 				objectIds = @(
    /// 					$someString
    /// 				)
    /// 				# REQUIRED
    /// 				snappableType = $someWorkloadLevelHierarchy # Call [Enum]::GetValues([RubrikSecurityCloud.Types.WorkloadLevelHierarchy]) for enum values.
    /// 			}
    /// 		)
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
    /// Runs the CreateS3CompatibleReaderTarget operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: CreateS3CompatibleReaderTarget
    /// 
    /// $query = New-RscMutationMisc -CreateS3CompatibleReaderTarget
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	clusterUuid = $someString
    /// 	# REQUIRED
    /// 	name = $someString
    /// 	# REQUIRED
    /// 	accessKey = $someString
    /// 	# REQUIRED
    /// 	secretKey = $someString
    /// 	# REQUIRED
    /// 	endpoint = $someString
    /// 	# REQUIRED
    /// 	bucketPrefix = $someString
    /// 	# REQUIRED
    /// 	numberOfBuckets = $someInt
    /// 	# REQUIRED
    /// 	encryptionKeyInDer = $someString
    /// 	# REQUIRED
    /// 	isConsolidationEnabled = $someBoolean
    /// 	# REQUIRED
    /// 	useSystemProxy = $someBoolean
    /// 	# REQUIRED
    /// 	readerRetrievalMethod = $someReaderRetrievalMethod # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ReaderRetrievalMethod]) for enum values.
    /// 	# OPTIONAL
    /// 	subType = $someS3CompatibleSubType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.S3CompatibleSubType]) for enum values.
    /// 	# OPTIONAL
    /// 	encryptionPassword = $someString
    /// 	# OPTIONAL
    /// 	immutabilitySettings = @{
    /// 		# OPTIONAL
    /// 		bucketLockDurationDays = $someInt
    /// 	}
    /// 	# OPTIONAL
    /// 	ibmDetails = @{
    /// 		# OPTIONAL
    /// 		provisioningCode = $someString
    /// 		# OPTIONAL
    /// 		deploymentType = $someIbmDeploymentType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.IbmDeploymentType]) for enum values.
    /// 	}
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: Target
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CreateS3CompatibleTarget operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: CreateS3CompatibleTarget
    /// 
    /// $query = New-RscMutationMisc -CreateS3CompatibleTarget
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	clusterUuid = $someString
    /// 	# REQUIRED
    /// 	name = $someString
    /// 	# REQUIRED
    /// 	accessKey = $someString
    /// 	# REQUIRED
    /// 	secretKey = $someString
    /// 	# REQUIRED
    /// 	endpoint = $someString
    /// 	# REQUIRED
    /// 	bucketPrefix = $someString
    /// 	# REQUIRED
    /// 	numberOfBuckets = $someInt
    /// 	# REQUIRED
    /// 	encryptionKeyInDer = $someString
    /// 	# REQUIRED
    /// 	isConsolidationEnabled = $someBoolean
    /// 	# REQUIRED
    /// 	useSystemProxy = $someBoolean
    /// 	# OPTIONAL
    /// 	subType = $someS3CompatibleSubType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.S3CompatibleSubType]) for enum values.
    /// 	# OPTIONAL
    /// 	encryptionPassword = $someString
    /// 	# OPTIONAL
    /// 	immutabilitySettings = @{
    /// 		# OPTIONAL
    /// 		bucketLockDurationDays = $someInt
    /// 	}
    /// 	# OPTIONAL
    /// 	ibmDetails = @{
    /// 		# OPTIONAL
    /// 		provisioningCode = $someString
    /// 		# OPTIONAL
    /// 		deploymentType = $someIbmDeploymentType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.IbmDeploymentType]) for enum values.
    /// 	}
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: Target
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CreateUser operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: CreateUser
    /// 
    /// $query = New-RscMutationMisc -CreateUser
    /// 
    /// # REQUIRED
    /// $query.Var.email = $someString
    /// # REQUIRED
    /// $query.Var.roleIds = @(
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
    /// Runs the CreateUserWithPassword operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: CreateUserWithPassword
    /// 
    /// $query = New-RscMutationMisc -CreateUserWithPassword
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	email = $someString
    /// 	# OPTIONAL
    /// 	password = $someString
    /// 	# OPTIONAL
    /// 	roleIds = @(
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
    /// Runs the DeactivatePolicy operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: DeactivatePolicy
    /// 
    /// $query = New-RscMutationMisc -DeactivatePolicy
    /// 
    /// # REQUIRED
    /// $query.Var.policyId = $someString
    /// # REQUIRED
    /// $query.Var.runAsync = $someBoolean
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: List&lt;System.String&gt;
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
    /// Runs the DeleteCsr operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: DeleteCsr
    /// 
    /// $query = New-RscMutationMisc -DeleteCsr
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	csrFids = @(
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
    /// Runs the DeleteFailoverClusterApp operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: DeleteFailoverClusterApp
    /// 
    /// $query = New-RscMutationMisc -DeleteFailoverClusterApp
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
    /// Runs the DeleteIntegration operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: DeleteIntegration
    /// 
    /// $query = New-RscMutationMisc -DeleteIntegration
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	id = $someInt64
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
    /// Runs the DeleteIntegrations operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: DeleteIntegrations
    /// 
    /// $query = New-RscMutationMisc -DeleteIntegrations
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	ids = @(
    /// 		$someInt64
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
    /// Runs the DeleteLogShipping operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: DeleteLogShipping
    /// 
    /// $query = New-RscMutationMisc -DeleteLogShipping
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	deleteSecondaryDatabase = $someBoolean
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
    /// Runs the DeleteNasSystem operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: DeleteNasSystem
    /// 
    /// $query = New-RscMutationMisc -DeleteNasSystem
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
    /// Runs the DeleteOrg operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: DeleteOrg
    /// 
    /// $query = New-RscMutationMisc -DeleteOrg
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
    /// Write-Host $result.GetType().Name # prints: System.Boolean
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the DeleteRole operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: DeleteRole
    /// 
    /// $query = New-RscMutationMisc -DeleteRole
    /// 
    /// # REQUIRED
    /// $query.Var.roleId = $someString
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
    /// Runs the DeleteSyslogExportRule operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: DeleteSyslogExportRule
    /// 
    /// $query = New-RscMutationMisc -DeleteSyslogExportRule
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
    /// Write-Host $result.GetType().Name # prints: System.String
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the DeleteTarget operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: DeleteTarget
    /// 
    /// $query = New-RscMutationMisc -DeleteTarget
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	id = $someString
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
    /// Runs the DeleteTargetMapping operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: DeleteTargetMapping
    /// 
    /// $query = New-RscMutationMisc -DeleteTargetMapping
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	id = $someString
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
    /// Runs the DeleteTotpConfig operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: DeleteTotpConfig
    /// 
    /// $query = New-RscMutationMisc -DeleteTotpConfig
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
    /// Runs the DeleteTotpConfigs operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: DeleteTotpConfigs
    /// 
    /// $query = New-RscMutationMisc -DeleteTotpConfigs
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	userIds = @(
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
    /// Runs the DisableTarget operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: DisableTarget
    /// 
    /// $query = New-RscMutationMisc -DisableTarget
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	id = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: DisableTargetReply
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
    /// Runs the EnableTarget operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: EnableTarget
    /// 
    /// $query = New-RscMutationMisc -EnableTarget
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	id = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: EnableTargetReply
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
    /// Runs the GenerateClusterRegistrationToken operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: GenerateClusterRegistrationToken
    /// 
    /// $query = New-RscMutationMisc -GenerateClusterRegistrationToken
    /// 
    /// # OPTIONAL
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	managedByPolaris = $someBoolean
    /// 	# OPTIONAL
    /// 	nodeConfigs = @(
    /// 		@{
    /// 			# OPTIONAL
    /// 			id = $someString
    /// 			# OPTIONAL
    /// 			manufactureTime = $someDateTime
    /// 			# OPTIONAL
    /// 			serial = $someString
    /// 			# OPTIONAL
    /// 			systemUuid = $someString
    /// 			# OPTIONAL
    /// 			teleportToken = $someString
    /// 			# OPTIONAL
    /// 			clusterUuid = $someString
    /// 			# OPTIONAL
    /// 			platform = $someString
    /// 			# OPTIONAL
    /// 			capacity = $someString
    /// 			# OPTIONAL
    /// 			isEntitled = $someBoolean
    /// 		}
    /// 	)
    /// 	# OPTIONAL
    /// 	isOfflineRegistration = $someBoolean
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: ClusterRegistrationToken
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
    /// Runs the GenerateCsr operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: GenerateCsr
    /// 
    /// $query = New-RscMutationMisc -GenerateCsr
    /// 
    /// # REQUIRED
    /// $query.Var.name = $someString
    /// # REQUIRED
    /// $query.Var.hostnames = @(
    /// 	$someString
    /// )
    /// # OPTIONAL
    /// $query.Var.organization = $someString
    /// # OPTIONAL
    /// $query.Var.organizationUnit = $someString
    /// # OPTIONAL
    /// $query.Var.country = $someString
    /// # OPTIONAL
    /// $query.Var.state = $someString
    /// # OPTIONAL
    /// $query.Var.city = $someString
    /// # OPTIONAL
    /// $query.Var.email = $someString
    /// # OPTIONAL
    /// $query.Var.surname = $someString
    /// # OPTIONAL
    /// $query.Var.userId = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: Csr
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
    /// 	# OPTIONAL
    /// 	definitions = @{
    /// 		# OPTIONAL
    /// 		eventId = $someString
    /// 		# OPTIONAL
    /// 		requestIds = @(
    /// 			$someString
    /// 		)
    /// 	}
    /// 	# REQUIRED
    /// 	clusterUuid = $someString
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
    /// Runs the GenerateTotpSecret operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: GenerateTotpSecret
    /// 
    /// $query = New-RscMutationMisc -GenerateTotpSecret
    /// 
    /// # REQUIRED
    /// $query.Var.userId = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: GenerateTotpSecretReply
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
    /// Runs the GetHealthMonitorPolicyStatus operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: GetHealthMonitorPolicyStatus
    /// 
    /// $query = New-RscMutationMisc -GetHealthMonitorPolicyStatus
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	hasDetailedStatus = $someBoolean
    /// 	# OPTIONAL
    /// 	nodeIds = @(
    /// 		$someString
    /// 	)
    /// 	# OPTIONAL
    /// 	policyIds = @(
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
    /// Write-Host $result.GetType().Name # prints: GetHealthMonitorPolicyStatusReply
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
    /// Runs the HideRevealNasShares operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: HideRevealNasShares
    /// 
    /// $query = New-RscMutationMisc -HideRevealNasShares
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	hideNasSharesRequest = @{
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
    /// Write-Host $result.GetType().Name # prints: ResponseSuccess
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
    /// Runs the ModifyActiveDirectoryLiveMount operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: ModifyActiveDirectoryLiveMount
    /// 
    /// $query = New-RscMutationMisc -ModifyActiveDirectoryLiveMount
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	config = @{
    /// 		# OPTIONAL
    /// 		validIps = @(
    /// 			$someString
    /// 		)
    /// 		# OPTIONAL
    /// 		password = $someString
    /// 		# OPTIONAL
    /// 		subnet = $someString
    /// 	}
    /// 	# REQUIRED
    /// 	id = $someString
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
    /// 		access = @{
    /// 			# OPTIONAL
    /// 			https = $someBoolean
    /// 			# OPTIONAL
    /// 			iKvm = $someBoolean
    /// 		}
    /// 		# OPTIONAL
    /// 		password = $someString
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
    /// Runs the MutateRole operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: MutateRole
    /// 
    /// $query = New-RscMutationMisc -MutateRole
    /// 
    /// # OPTIONAL
    /// $query.Var.roleId = $someString
    /// # REQUIRED
    /// $query.Var.name = $someString
    /// # REQUIRED
    /// $query.Var.description = $someString
    /// # REQUIRED
    /// $query.Var.permissions = @(
    /// 	@{
    /// 		# REQUIRED
    /// 		operation = $someOperation # Call [Enum]::GetValues([RubrikSecurityCloud.Types.Operation]) for enum values.
    /// 		# REQUIRED
    /// 		objectsForHierarchyTypes = @(
    /// 			@{
    /// 				# REQUIRED
    /// 				objectIds = @(
    /// 					$someString
    /// 				)
    /// 				# REQUIRED
    /// 				snappableType = $someWorkloadLevelHierarchy # Call [Enum]::GetValues([RubrikSecurityCloud.Types.WorkloadLevelHierarchy]) for enum values.
    /// 			}
    /// 		)
    /// }
    /// )
    /// # REQUIRED
    /// $query.Var.protectableClusters = @(
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
    /// # No variables for this query.
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
    /// Runs the PauseTarget operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: PauseTarget
    /// 
    /// $query = New-RscMutationMisc -PauseTarget
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	id = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: PauseTargetReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the PromoteReaderTarget operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: PromoteReaderTarget
    /// 
    /// $query = New-RscMutationMisc -PromoteReaderTarget
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	locationId = $someString
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
    /// Runs the RefreshNasSystems operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: RefreshNasSystems
    /// 
    /// $query = New-RscMutationMisc -RefreshNasSystems
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	discoverNasSystemRequest = @{
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
    /// Write-Host $result.GetType().Name # prints: RefreshNasSystemsReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the RefreshReaderTarget operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: RefreshReaderTarget
    /// 
    /// $query = New-RscMutationMisc -RefreshReaderTarget
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	localDataSourceIds = @(
    /// 		$someString
    /// 	)
    /// 	# OPTIONAL
    /// 	archivalDataSourceIds = @(
    /// 		$someString
    /// 	)
    /// 	# OPTIONAL
    /// 	locationId = $someString
    /// 	# OPTIONAL
    /// 	externalLocationId = $someString
    /// 	# OPTIONAL
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
    /// Runs the RegisterNasSystem operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: RegisterNasSystem
    /// 
    /// $query = New-RscMutationMisc -RegisterNasSystem
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	clusterUuid = $someString
    /// 	# REQUIRED
    /// 	nasSystem = @{
    /// 		# OPTIONAL
    /// 		genericNasSystemParameters = @{
    /// 			# OPTIONAL
    /// 			smbCredentials = @{
    /// 				# REQUIRED
    /// 				password = $someString
    /// 				# REQUIRED
    /// 				username = $someString
    /// 			}
    /// 			# REQUIRED
    /// 			hasNfsSupport = $someBoolean
    /// 			# REQUIRED
    /// 			hasSmbSupport = $someBoolean
    /// 		}
    /// 		# OPTIONAL
    /// 		isIsilonChangelistEnabled = $someBoolean
    /// 		# OPTIONAL
    /// 		nasTmpApiCredentials = @{
    /// 			# OPTIONAL
    /// 			apiCertificate = $someString
    /// 			# OPTIONAL
    /// 			apiPassword = $someString
    /// 			# OPTIONAL
    /// 			apiUsername = $someString
    /// 			# OPTIONAL
    /// 			certificateId = $someString
    /// 		}
    /// 		# OPTIONAL
    /// 		nasFlashBladeApiCredentials = @{
    /// 			# OPTIONAL
    /// 			apiCertificate = $someString
    /// 			# OPTIONAL
    /// 			certificateId = $someString
    /// 			# OPTIONAL
    /// 			smbCredentials = @{
    /// 				# REQUIRED
    /// 				password = $someString
    /// 				# REQUIRED
    /// 				username = $someString
    /// 			}
    /// 			# REQUIRED
    /// 			apiToken = $someString
    /// 			# REQUIRED
    /// 			hasSmbSupport = $someBoolean
    /// 		}
    /// 		# OPTIONAL
    /// 		nutanixFileServerParameters = @{
    /// 			# OPTIONAL
    /// 			apiCertificate = $someString
    /// 			# OPTIONAL
    /// 			certificateId = $someString
    /// 			# OPTIONAL
    /// 			smbCredentials = @{
    /// 				# REQUIRED
    /// 				password = $someString
    /// 				# REQUIRED
    /// 				username = $someString
    /// 			}
    /// 			# OPTIONAL
    /// 			apiPassword = $someString
    /// 			# OPTIONAL
    /// 			apiUsername = $someString
    /// 			# REQUIRED
    /// 			hasSmbSupport = $someBoolean
    /// 		}
    /// 		# REQUIRED
    /// 		nasVendorType = $someNasVendorType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.NasVendorType]) for enum values.
    /// 		# REQUIRED
    /// 		hostname = $someString
    /// 	}
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: RegisterNasSystemReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the RemoveClusterNodes operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: RemoveClusterNodes
    /// 
    /// $query = New-RscMutationMisc -RemoveClusterNodes
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
    /// Write-Host $result.GetType().Name # prints: CcProvisionJobReply
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
    /// Runs the RemovePolicyObjects operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: RemovePolicyObjects
    /// 
    /// $query = New-RscMutationMisc -RemovePolicyObjects
    /// 
    /// # REQUIRED
    /// $query.Var.policyIds = @(
    /// 	$someString
    /// )
    /// # REQUIRED
    /// $query.Var.objectIds = @(
    /// 	$someString
    /// )
    /// # REQUIRED
    /// $query.Var.objectRootIds = @(
    /// 	$someString
    /// )
    /// # REQUIRED
    /// $query.Var.clusterIds = @(
    /// 	$someString
    /// )
    /// # REQUIRED
    /// $query.Var.runAsync = $someBoolean
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: List&lt;System.String&gt;
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
    /// Runs the RestoreActiveDirectoryObjects operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: RestoreActiveDirectoryObjects
    /// 
    /// $query = New-RscMutationMisc -RestoreActiveDirectoryObjects
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	config = @{
    /// 		# OPTIONAL
    /// 		shouldMergeLinkedAttrs = $someBoolean
    /// 		# OPTIONAL
    /// 		userRestoreOptions = @{
    /// 			# OPTIONAL
    /// 			shouldEnableUser = $someBoolean
    /// 			# OPTIONAL
    /// 			shouldChangePassword = $someBoolean
    /// 			# OPTIONAL
    /// 			password = $someString
    /// 			# OPTIONAL
    /// 			passwordOptions = $someActiveDirectoryUserPasswordRecoveryOption # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ActiveDirectoryUserPasswordRecoveryOption]) for enum values.
    /// 		}
    /// 		# OPTIONAL
    /// 		restoreToDifferentContainer = $someString
    /// 		# OPTIONAL
    /// 		shouldContinueOnError = $someBoolean
    /// 		# OPTIONAL
    /// 		clearUpAttrsIfNullInBackup = $someBoolean
    /// 		# OPTIONAL
    /// 		credsForRestore = @{
    /// 			# REQUIRED
    /// 			password = $someString
    /// 			# REQUIRED
    /// 			username = $someString
    /// 		}
    /// 		# OPTIONAL
    /// 		shouldCreateMissingParents = $someBoolean
    /// 		# OPTIONAL
    /// 		containerRestoreOptions = @{
    /// 			# OPTIONAL
    /// 			shouldDeleteExtraObjects = $someBoolean
    /// 			# OPTIONAL
    /// 			shouldOnlyRecreateMissingObjects = $someBoolean
    /// 		}
    /// 		# OPTIONAL
    /// 		locationId = $someString
    /// 		# OPTIONAL
    /// 		nameConflict = $someActiveDirectoryObjectNameConflictOption # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ActiveDirectoryObjectNameConflictOption]) for enum values.
    /// 		# OPTIONAL
    /// 		objectMovedOptions = $someActiveDirectoryObjectMovedOption # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ActiveDirectoryObjectMovedOption]) for enum values.
    /// 		# REQUIRED
    /// 		domainControllerRecoveryObjects = @(
    /// 			@{
    /// 				# OPTIONAL
    /// 				objectType = $someActiveDirectoryObjectType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ActiveDirectoryObjectType]) for enum values.
    /// 				# REQUIRED
    /// 				dnt = $someInt64
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
    /// Runs the ResumeTarget operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: ResumeTarget
    /// 
    /// $query = New-RscMutationMisc -ResumeTarget
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	id = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: ResumeTargetReply
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
    /// Runs the SetPasswordComplexityPolicy operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: SetPasswordComplexityPolicy
    /// 
    /// $query = New-RscMutationMisc -SetPasswordComplexityPolicy
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	policy = @{
    /// 		# REQUIRED
    /// 		lengthPolicy = @{
    /// 			# OPTIONAL
    /// 			minValue = $someInt
    /// 			# OPTIONAL
    /// 			maxValue = $someInt
    /// 			# OPTIONAL
    /// 			defaultValue = $someInt
    /// 			# REQUIRED
    /// 			isActive = $someBoolean
    /// 		}
    /// 		# REQUIRED
    /// 		lowercasePolicy = @{
    /// 			# OPTIONAL
    /// 			minValue = $someInt
    /// 			# OPTIONAL
    /// 			maxValue = $someInt
    /// 			# OPTIONAL
    /// 			defaultValue = $someInt
    /// 			# REQUIRED
    /// 			isActive = $someBoolean
    /// 		}
    /// 		# REQUIRED
    /// 		uppercasePolicy = @{
    /// 			# OPTIONAL
    /// 			minValue = $someInt
    /// 			# OPTIONAL
    /// 			maxValue = $someInt
    /// 			# OPTIONAL
    /// 			defaultValue = $someInt
    /// 			# REQUIRED
    /// 			isActive = $someBoolean
    /// 		}
    /// 		# REQUIRED
    /// 		specialCharsPolicy = @{
    /// 			# OPTIONAL
    /// 			minValue = $someInt
    /// 			# OPTIONAL
    /// 			maxValue = $someInt
    /// 			# OPTIONAL
    /// 			defaultValue = $someInt
    /// 			# REQUIRED
    /// 			isActive = $someBoolean
    /// 		}
    /// 		# REQUIRED
    /// 		numericPolicy = @{
    /// 			# OPTIONAL
    /// 			minValue = $someInt
    /// 			# OPTIONAL
    /// 			maxValue = $someInt
    /// 			# OPTIONAL
    /// 			defaultValue = $someInt
    /// 			# REQUIRED
    /// 			isActive = $someBoolean
    /// 		}
    /// 		# REQUIRED
    /// 		passwordReusePolicy = @{
    /// 			# OPTIONAL
    /// 			minValue = $someInt
    /// 			# OPTIONAL
    /// 			maxValue = $someInt
    /// 			# OPTIONAL
    /// 			defaultValue = $someInt
    /// 			# REQUIRED
    /// 			isActive = $someBoolean
    /// 		}
    /// 		# REQUIRED
    /// 		passwordExpirationPolicy = @{
    /// 			# OPTIONAL
    /// 			minValue = $someInt
    /// 			# OPTIONAL
    /// 			maxValue = $someInt
    /// 			# OPTIONAL
    /// 			defaultValue = $someInt
    /// 			# REQUIRED
    /// 			isActive = $someBoolean
    /// 		}
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
    /// Runs the TestSyslogExportRule operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: TestSyslogExportRule
    /// 
    /// $query = New-RscMutationMisc -TestSyslogExportRule
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	syslogExportRuleV51 = @{
    /// 		# OPTIONAL
    /// 		syslogCertificateInfo = @{
    /// 			# OPTIONAL
    /// 			serverCertificate = $someString
    /// 			# OPTIONAL
    /// 			serverCertificateName = $someString
    /// 		}
    /// 		# OPTIONAL
    /// 		syslogExportRuleFull = @{
    /// 			# OPTIONAL
    /// 			certificateId = $someString
    /// 			# REQUIRED
    /// 			facility = $someSyslogFacility # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogFacility]) for enum values.
    /// 			# REQUIRED
    /// 			protocol = $someTransportLayerProtocol # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TransportLayerProtocol]) for enum values.
    /// 			# REQUIRED
    /// 			severity = $someSyslogSeverity # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogSeverity]) for enum values.
    /// 			# REQUIRED
    /// 			enableTls = $someBoolean
    /// 			# REQUIRED
    /// 			hostname = $someString
    /// 			# REQUIRED
    /// 			port = $someInt
    /// 		}
    /// 	}
    /// 	# OPTIONAL
    /// 	syslogExportRuleV52 = @{
    /// 		# OPTIONAL
    /// 		certificateId = $someString
    /// 		# REQUIRED
    /// 		facility = $someSyslogFacility # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogFacility]) for enum values.
    /// 		# REQUIRED
    /// 		protocol = $someTransportLayerProtocol # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TransportLayerProtocol]) for enum values.
    /// 		# REQUIRED
    /// 		severity = $someSyslogSeverity # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogSeverity]) for enum values.
    /// 		# REQUIRED
    /// 		enableTls = $someBoolean
    /// 		# REQUIRED
    /// 		hostname = $someString
    /// 		# REQUIRED
    /// 		port = $someInt
    /// 	}
    /// 	# OPTIONAL
    /// 	syslogExportRuleV53 = @{
    /// 		# OPTIONAL
    /// 		certificateId = $someString
    /// 		# REQUIRED
    /// 		facility = $someSyslogFacility # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogFacility]) for enum values.
    /// 		# REQUIRED
    /// 		protocol = $someTransportLayerProtocol # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TransportLayerProtocol]) for enum values.
    /// 		# REQUIRED
    /// 		severity = $someSyslogSeverity # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogSeverity]) for enum values.
    /// 		# REQUIRED
    /// 		enableTls = $someBoolean
    /// 		# REQUIRED
    /// 		hostname = $someString
    /// 		# REQUIRED
    /// 		port = $someInt
    /// 	}
    /// 	# OPTIONAL
    /// 	syslogExportRuleV60 = @{
    /// 		# OPTIONAL
    /// 		certificateId = $someString
    /// 		# REQUIRED
    /// 		facility = $someSyslogFacility # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogFacility]) for enum values.
    /// 		# REQUIRED
    /// 		protocol = $someTransportLayerProtocol # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TransportLayerProtocol]) for enum values.
    /// 		# REQUIRED
    /// 		severity = $someSyslogSeverity # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogSeverity]) for enum values.
    /// 		# REQUIRED
    /// 		enableTls = $someBoolean
    /// 		# REQUIRED
    /// 		hostname = $someString
    /// 		# REQUIRED
    /// 		port = $someInt
    /// 	}
    /// 	# OPTIONAL
    /// 	syslogExportRuleV70 = @{
    /// 		# OPTIONAL
    /// 		certificateId = $someString
    /// 		# REQUIRED
    /// 		facility = $someSyslogFacility # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogFacility]) for enum values.
    /// 		# REQUIRED
    /// 		protocol = $someTransportLayerProtocol # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TransportLayerProtocol]) for enum values.
    /// 		# REQUIRED
    /// 		severity = $someSyslogSeverity # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogSeverity]) for enum values.
    /// 		# REQUIRED
    /// 		enableTls = $someBoolean
    /// 		# REQUIRED
    /// 		hostname = $someString
    /// 		# REQUIRED
    /// 		port = $someInt
    /// 	}
    /// 	# OPTIONAL
    /// 	syslogExportRuleV80 = @{
    /// 		# OPTIONAL
    /// 		certificateId = $someString
    /// 		# REQUIRED
    /// 		facility = $someSyslogFacility # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogFacility]) for enum values.
    /// 		# REQUIRED
    /// 		protocol = $someTransportLayerProtocol # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TransportLayerProtocol]) for enum values.
    /// 		# REQUIRED
    /// 		severity = $someSyslogSeverity # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogSeverity]) for enum values.
    /// 		# REQUIRED
    /// 		enableTls = $someBoolean
    /// 		# REQUIRED
    /// 		hostname = $someString
    /// 		# REQUIRED
    /// 		port = $someInt
    /// 	}
    /// 	# OPTIONAL
    /// 	syslogExportRuleV81 = @{
    /// 		# OPTIONAL
    /// 		certificateId = $someString
    /// 		# REQUIRED
    /// 		facility = $someSyslogFacility # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogFacility]) for enum values.
    /// 		# REQUIRED
    /// 		protocol = $someTransportLayerProtocol # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TransportLayerProtocol]) for enum values.
    /// 		# REQUIRED
    /// 		severity = $someSyslogSeverity # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogSeverity]) for enum values.
    /// 		# REQUIRED
    /// 		enableTls = $someBoolean
    /// 		# REQUIRED
    /// 		hostname = $someString
    /// 		# REQUIRED
    /// 		port = $someInt
    /// 	}
    /// 	# OPTIONAL
    /// 	syslogExportRuleV90 = @{
    /// 		# OPTIONAL
    /// 		certificateId = $someString
    /// 		# REQUIRED
    /// 		facility = $someSyslogFacility # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogFacility]) for enum values.
    /// 		# REQUIRED
    /// 		protocol = $someTransportLayerProtocol # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TransportLayerProtocol]) for enum values.
    /// 		# REQUIRED
    /// 		severity = $someSyslogSeverity # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogSeverity]) for enum values.
    /// 		# REQUIRED
    /// 		enableTls = $someBoolean
    /// 		# REQUIRED
    /// 		hostname = $someString
    /// 		# REQUIRED
    /// 		port = $someInt
    /// 	}
    /// 	# OPTIONAL
    /// 	syslogExportRuleV91 = @{
    /// 		# OPTIONAL
    /// 		certificateId = $someString
    /// 		# REQUIRED
    /// 		facility = $someSyslogFacility # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogFacility]) for enum values.
    /// 		# REQUIRED
    /// 		protocol = $someTransportLayerProtocol # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TransportLayerProtocol]) for enum values.
    /// 		# REQUIRED
    /// 		severity = $someSyslogSeverity # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogSeverity]) for enum values.
    /// 		# REQUIRED
    /// 		enableTls = $someBoolean
    /// 		# REQUIRED
    /// 		hostname = $someString
    /// 		# REQUIRED
    /// 		port = $someInt
    /// 	}
    /// 	# REQUIRED
    /// 	clusterUuid = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: TestSyslogExportRuleReply
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
    /// Runs the UpdateAutoEnablePolicyClusterConfig operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: UpdateAutoEnablePolicyClusterConfig
    /// 
    /// $query = New-RscMutationMisc -UpdateAutoEnablePolicyClusterConfig
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	clusterId = $someString
    /// 	# OPTIONAL
    /// 	enabled = $someBoolean
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: UpdateAutoEnablePolicyClusterConfigReply
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
    /// Runs the UpdateClusterDefaultAddress operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: UpdateClusterDefaultAddress
    /// 
    /// $query = New-RscMutationMisc -UpdateClusterDefaultAddress
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	clusterUuid = $someString
    /// 	# OPTIONAL
    /// 	address = $someString
    /// 	# OPTIONAL
    /// 	port = $someInt
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: UpdateClusterDefaultAddressReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the UpdateClusterLocation operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: UpdateClusterLocation
    /// 
    /// $query = New-RscMutationMisc -UpdateClusterLocation
    /// 
    /// # REQUIRED
    /// $query.Var.clusterUuid = $someString
    /// # REQUIRED
    /// $query.Var.clusterLocation = @{
    /// 	# REQUIRED
    /// 	address = $someString
    /// 	# REQUIRED
    /// 	latitude = $someSingle
    /// 	# REQUIRED
    /// 	longitude = $someSingle
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: Cluster
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the UpdateClusterNtpServers operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: UpdateClusterNtpServers
    /// 
    /// $query = New-RscMutationMisc -UpdateClusterNtpServers
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	id = $someString
    /// 	# REQUIRED
    /// 	ntpServerConfigs = @(
    /// 		@{
    /// 			# OPTIONAL
    /// 			symmetricKey = @{
    /// 				# REQUIRED
    /// 				key = $someString
    /// 				# REQUIRED
    /// 				keyId = $someInt
    /// 				# REQUIRED
    /// 				keyType = $someString
    /// 			}
    /// 			# REQUIRED
    /// 			server = $someString
    /// 		}
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
    /// Runs the UpdateClusterSettings operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: UpdateClusterSettings
    /// 
    /// $query = New-RscMutationMisc -UpdateClusterSettings
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	clusterUpdate = @{
    /// 		# OPTIONAL
    /// 		acceptedEulaVersion = $someString
    /// 		# OPTIONAL
    /// 		geolocation = @{
    /// 			# REQUIRED
    /// 			address = $someString
    /// 		}
    /// 		# OPTIONAL
    /// 		name = $someString
    /// 		# OPTIONAL
    /// 		timezone = @{
    /// 			# REQUIRED
    /// 			timezone = $someClusterTimezoneType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ClusterTimezoneType]) for enum values.
    /// 		}
    /// 	}
    /// 	# REQUIRED
    /// 	id = $someString
    /// 	# REQUIRED
    /// 	clusterUuid = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: UpdateClusterSettingsReply
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
    /// Runs the UpdateFailoverClusterApp operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: UpdateFailoverClusterApp
    /// 
    /// $query = New-RscMutationMisc -UpdateFailoverClusterApp
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	id = $someString
    /// 	# REQUIRED
    /// 	updateProperties = @{
    /// 		# OPTIONAL
    /// 		configuredSlaDomainId = $someString
    /// 		# REQUIRED
    /// 		failoverClusterType = $someFailoverClusterType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.FailoverClusterType]) for enum values.
    /// 		# REQUIRED
    /// 		failoverClusterAppSource = @{
    /// 			# OPTIONAL
    /// 			nodeOrders = @(
    /// 				@{
    /// 					# OPTIONAL
    /// 					nodeName = $someString
    /// 					# REQUIRED
    /// 					nodeId = $someString
    /// 					# REQUIRED
    /// 					order = $someInt
    /// 				}
    /// 			)
    /// 			# OPTIONAL
    /// 			virtualIps = @(
    /// 				$someString
    /// 			)
    /// 			# OPTIONAL
    /// 			vips = @(
    /// 				$someString
    /// 			)
    /// 		}
    /// 		# REQUIRED
    /// 		failoverClusterId = $someString
    /// 		# REQUIRED
    /// 		name = $someString
    /// 	}
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: UpdateFailoverClusterAppReply
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
    /// Runs the UpdateGlacierTarget operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: UpdateGlacierTarget
    /// 
    /// $query = New-RscMutationMisc -UpdateGlacierTarget
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	id = $someString
    /// 	# OPTIONAL
    /// 	name = $someString
    /// 	# OPTIONAL
    /// 	retrievalTier = $someAwsRetrievalTier # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsRetrievalTier]) for enum values.
    /// 	# OPTIONAL
    /// 	cloudAccountId = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: Target
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
    /// Runs the UpdateHealthMonitorPolicyStatus operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: UpdateHealthMonitorPolicyStatus
    /// 
    /// $query = New-RscMutationMisc -UpdateHealthMonitorPolicyStatus
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	clusterUuid = $someString
    /// 	# REQUIRED
    /// 	runRequest = @{
    /// 		# OPTIONAL
    /// 		nodeIds = @(
    /// 			$someString
    /// 		)
    /// 		# REQUIRED
    /// 		policyIds = @(
    /// 			$someString
    /// 		)
    /// 	}
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: UpdateHealthMonitorPolicyStatusReply
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
    /// Runs the UpdateIntegration operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: UpdateIntegration
    /// 
    /// $query = New-RscMutationMisc -UpdateIntegration
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	id = $someInt64
    /// 	# REQUIRED
    /// 	name = $someString
    /// 	# REQUIRED
    /// 	integrationType = $someIntegrationType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.IntegrationType]) for enum values.
    /// 	# REQUIRED
    /// 	config = @{
    /// 		# OPTIONAL
    /// 		dataLossPrevention = @{
    /// 			# OPTIONAL
    /// 			policies = @(
    /// 				$someString
    /// 			)
    /// 			# OPTIONAL
    /// 			genericNas = @{
    /// 				# REQUIRED
    /// 				workloadId = $someString
    /// 				# REQUIRED
    /// 				shareType = $someDlpConfigShareType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DlpConfigShareType]) for enum values.
    /// 				# REQUIRED
    /// 				shareId = $someString
    /// 				# REQUIRED
    /// 				path = $someString
    /// 			}
    /// 			# OPTIONAL
    /// 			vmwareVm = @{
    /// 				# REQUIRED
    /// 				workloadId = $someString
    /// 				# REQUIRED
    /// 				osType = $someDlpConfigOsType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DlpConfigOsType]) for enum values.
    /// 				# REQUIRED
    /// 				path = $someString
    /// 			}
    /// 			# OPTIONAL
    /// 			serviceAccountId = $someString
    /// 			# OPTIONAL
    /// 			serviceAccountName = $someString
    /// 			# OPTIONAL
    /// 			status = @{
    /// 				# OPTIONAL
    /// 				code = $someDlpStatusCode # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DlpStatusCode]) for enum values.
    /// 			}
    /// 			# REQUIRED
    /// 			targetType = $someDlpConfigTargetType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DlpConfigTargetType]) for enum values.
    /// 		}
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
    /// Runs the UpdateIntegrations operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: UpdateIntegrations
    /// 
    /// $query = New-RscMutationMisc -UpdateIntegrations
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	integrations = @(
    /// 		@{
    /// 			# REQUIRED
    /// 			id = $someInt64
    /// 			# REQUIRED
    /// 			name = $someString
    /// 			# REQUIRED
    /// 			integrationType = $someIntegrationType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.IntegrationType]) for enum values.
    /// 			# REQUIRED
    /// 			config = @{
    /// 				# OPTIONAL
    /// 				dataLossPrevention = @{
    /// 					# OPTIONAL
    /// 					policies = @(
    /// 						$someString
    /// 					)
    /// 					# OPTIONAL
    /// 					genericNas = @{
    /// 						# REQUIRED
    /// 						workloadId = $someString
    /// 						# REQUIRED
    /// 						shareType = $someDlpConfigShareType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DlpConfigShareType]) for enum values.
    /// 						# REQUIRED
    /// 						shareId = $someString
    /// 						# REQUIRED
    /// 						path = $someString
    /// 					}
    /// 					# OPTIONAL
    /// 					vmwareVm = @{
    /// 						# REQUIRED
    /// 						workloadId = $someString
    /// 						# REQUIRED
    /// 						osType = $someDlpConfigOsType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DlpConfigOsType]) for enum values.
    /// 						# REQUIRED
    /// 						path = $someString
    /// 					}
    /// 					# OPTIONAL
    /// 					serviceAccountId = $someString
    /// 					# OPTIONAL
    /// 					serviceAccountName = $someString
    /// 					# OPTIONAL
    /// 					status = @{
    /// 						# OPTIONAL
    /// 						code = $someDlpStatusCode # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DlpStatusCode]) for enum values.
    /// 					}
    /// 					# REQUIRED
    /// 					targetType = $someDlpConfigTargetType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DlpConfigTargetType]) for enum values.
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
    /// Runs the UpdateManualTargetMapping operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: UpdateManualTargetMapping
    /// 
    /// $query = New-RscMutationMisc -UpdateManualTargetMapping
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	id = $someString
    /// 	# OPTIONAL
    /// 	name = $someString
    /// 	# OPTIONAL
    /// 	archivalLocationClusterMappings = @(
    /// 		@{
    /// 			# OPTIONAL
    /// 			locationId = $someString
    /// 			# OPTIONAL
    /// 			clusterUuid = $someString
    /// 		}
    /// 	)
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: TargetMapping
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the UpdateNasShares operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: UpdateNasShares
    /// 
    /// $query = New-RscMutationMisc -UpdateNasShares
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	updateNasSharesRequest = @{
    /// 		# REQUIRED
    /// 		nasShareProperties = @(
    /// 			@{
    /// 				# OPTIONAL
    /// 				isIsilonChangelistEnabled = $someBoolean
    /// 				# REQUIRED
    /// 				id = $someString
    /// 			}
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
    /// Runs the UpdateNasSystem operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: UpdateNasSystem
    /// 
    /// $query = New-RscMutationMisc -UpdateNasSystem
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	id = $someString
    /// 	# REQUIRED
    /// 	nasSystemUpdateProperties = @{
    /// 		# OPTIONAL
    /// 		genericNasSystemParameters = @{
    /// 			# OPTIONAL
    /// 			smbCredentials = @{
    /// 				# REQUIRED
    /// 				password = $someString
    /// 				# REQUIRED
    /// 				username = $someString
    /// 			}
    /// 			# REQUIRED
    /// 			hasNfsSupport = $someBoolean
    /// 			# REQUIRED
    /// 			hasSmbSupport = $someBoolean
    /// 		}
    /// 		# OPTIONAL
    /// 		hostname = $someString
    /// 		# OPTIONAL
    /// 		isIsilonChangelistEnabled = $someBoolean
    /// 		# OPTIONAL
    /// 		nasApiCredentials = @{
    /// 			# OPTIONAL
    /// 			apiCertificate = $someString
    /// 			# OPTIONAL
    /// 			apiPassword = $someString
    /// 			# OPTIONAL
    /// 			apiUsername = $someString
    /// 			# OPTIONAL
    /// 			certificateId = $someString
    /// 		}
    /// 		# OPTIONAL
    /// 		nasFlashBladeApiCredentials = @{
    /// 			# OPTIONAL
    /// 			apiCertificate = $someString
    /// 			# OPTIONAL
    /// 			certificateId = $someString
    /// 			# OPTIONAL
    /// 			smbCredentials = @{
    /// 				# REQUIRED
    /// 				password = $someString
    /// 				# REQUIRED
    /// 				username = $someString
    /// 			}
    /// 			# REQUIRED
    /// 			apiToken = $someString
    /// 			# REQUIRED
    /// 			hasSmbSupport = $someBoolean
    /// 		}
    /// 		# OPTIONAL
    /// 		nutanixFileServerParameters = @{
    /// 			# OPTIONAL
    /// 			apiCertificate = $someString
    /// 			# OPTIONAL
    /// 			certificateId = $someString
    /// 			# OPTIONAL
    /// 			smbCredentials = @{
    /// 				# REQUIRED
    /// 				password = $someString
    /// 				# REQUIRED
    /// 				username = $someString
    /// 			}
    /// 			# OPTIONAL
    /// 			apiPassword = $someString
    /// 			# OPTIONAL
    /// 			apiUsername = $someString
    /// 			# REQUIRED
    /// 			hasSmbSupport = $someBoolean
    /// 		}
    /// 	}
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: UpdateNasSystemReply
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
    /// 		# OPTIONAL
    /// 		networkInterface = $someString
    /// 		# OPTIONAL
    /// 		archivalThrottlePort = $someInt
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
    /// Runs the UpdateOrg operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: UpdateOrg
    /// 
    /// $query = New-RscMutationMisc -UpdateOrg
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	organizationId = $someString
    /// 	# REQUIRED
    /// 	name = $someString
    /// 	# REQUIRED
    /// 	fullName = $someString
    /// 	# REQUIRED
    /// 	description = $someString
    /// 	# REQUIRED
    /// 	authDomainConfig = $someTenantAuthDomainConfig # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TenantAuthDomainConfig]) for enum values.
    /// 	# REQUIRED
    /// 	shouldEnforceMfaForAll = $someBoolean
    /// 	# REQUIRED
    /// 	isEnvoyRequired = $someBoolean
    /// 	# REQUIRED
    /// 	allowedClusters = @(
    /// 		$someString
    /// 	)
    /// 	# OPTIONAL
    /// 	existingUsers = @(
    /// 		@{
    /// 			# REQUIRED
    /// 			id = $someString
    /// 			# REQUIRED
    /// 			isOrgAdmin = $someBoolean
    /// 		}
    /// 	)
    /// 	# OPTIONAL
    /// 	userInvites = @(
    /// 		@{
    /// 			# REQUIRED
    /// 			email = $someString
    /// 			# REQUIRED
    /// 			note = $someString
    /// 			# REQUIRED
    /// 			isOrgAdmin = $someBoolean
    /// 		}
    /// 	)
    /// 	# REQUIRED
    /// 	permissions = @(
    /// 		@{
    /// 			# REQUIRED
    /// 			operation = $someOperation # Call [Enum]::GetValues([RubrikSecurityCloud.Types.Operation]) for enum values.
    /// 			# REQUIRED
    /// 			objectsForHierarchyTypes = @(
    /// 				@{
    /// 					# REQUIRED
    /// 					objectIds = @(
    /// 						$someString
    /// 					)
    /// 					# REQUIRED
    /// 					snappableType = $someWorkloadLevelHierarchy # Call [Enum]::GetValues([RubrikSecurityCloud.Types.WorkloadLevelHierarchy]) for enum values.
    /// 				}
    /// 			)
    /// 		}
    /// 	)
    /// 	# REQUIRED
    /// 	selfServicePermissions = @(
    /// 		@{
    /// 			# OPTIONAL
    /// 			inventoryRoot = $someInventorySubHierarchyRootEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.InventorySubHierarchyRootEnum]) for enum values.
    /// 			# REQUIRED
    /// 			inventoryWorkloadType = $someWorkloadLevelHierarchy # Call [Enum]::GetValues([RubrikSecurityCloud.Types.WorkloadLevelHierarchy]) for enum values.
    /// 			# REQUIRED
    /// 			operations = @(
    /// 				$someOperation # Call [Enum]::GetValues([RubrikSecurityCloud.Types.Operation]) for enum values.
    /// 			)
    /// 			# OPTIONAL
    /// 			hierarchyRoot = $someString
    /// 		}
    /// 	)
    /// 	# OPTIONAL
    /// 	existingSsoGroups = @(
    /// 		@{
    /// 			# REQUIRED
    /// 			id = $someString
    /// 			# REQUIRED
    /// 			isOrgAdmin = $someBoolean
    /// 		}
    /// 	)
    /// 	# OPTIONAL
    /// 	newSsoGroups = @(
    /// 		@{
    /// 			# REQUIRED
    /// 			name = $someString
    /// 			# REQUIRED
    /// 			isOrgAdmin = $someBoolean
    /// 		}
    /// 	)
    /// 	# OPTIONAL
    /// 	isServiceAccountEnabled = $someBoolean
    /// 	# OPTIONAL
    /// 	crossAccountCapabilities = @(
    /// 		$someCrossAccountCapability # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CrossAccountCapability]) for enum values.
    /// 	)
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: UpdateOrgReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the UpdateOrgSecurityPolicy operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: UpdateOrgSecurityPolicy
    /// 
    /// $query = New-RscMutationMisc -UpdateOrgSecurityPolicy
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	disallowWeakerPolicy = $someBoolean
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
    /// Runs the UpdatePolicy operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: UpdatePolicy
    /// 
    /// $query = New-RscMutationMisc -UpdatePolicy
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	id = $someString
    /// 	# OPTIONAL
    /// 	name = $someString
    /// 	# OPTIONAL
    /// 	description = $someString
    /// 	# OPTIONAL
    /// 	colorEnum = $someClassificationPolicyColor # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ClassificationPolicyColor]) for enum values.
    /// 	# OPTIONAL
    /// 	mode = $someClassificationPolicyMode # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ClassificationPolicyMode]) for enum values.
    /// 	# OPTIONAL
    /// 	analyzerIds = @(
    /// 		$someString
    /// 	)
    /// 	# OPTIONAL
    /// 	updateName = $someBoolean
    /// 	# OPTIONAL
    /// 	updateDescription = $someBoolean
    /// 	# OPTIONAL
    /// 	updateMode = $someBoolean
    /// 	# OPTIONAL
    /// 	updateAnalyzerIds = $someBoolean
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: ClassificationPolicyDetail
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the UpdatePreviewerClusterConfig operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: UpdatePreviewerClusterConfig
    /// 
    /// $query = New-RscMutationMisc -UpdatePreviewerClusterConfig
    /// 
    /// # REQUIRED
    /// $query.Var.previewerClusterConfig = @{
    /// 	# OPTIONAL
    /// 	clusterId = $someString
    /// 	# OPTIONAL
    /// 	enabled = $someBoolean
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: Cluster
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
    /// Runs the UpdateRole operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: UpdateRole
    /// 
    /// $query = New-RscMutationMisc -UpdateRole
    /// 
    /// # REQUIRED
    /// $query.Var.roleId = $someString
    /// # REQUIRED
    /// $query.Var.name = $someString
    /// # REQUIRED
    /// $query.Var.description = $someString
    /// # REQUIRED
    /// $query.Var.permissions = @(
    /// 	@{
    /// 		# REQUIRED
    /// 		operation = $someOperation # Call [Enum]::GetValues([RubrikSecurityCloud.Types.Operation]) for enum values.
    /// 		# REQUIRED
    /// 		objectsForHierarchyTypes = @(
    /// 			@{
    /// 				# REQUIRED
    /// 				objectIds = @(
    /// 					$someString
    /// 				)
    /// 				# REQUIRED
    /// 				snappableType = $someWorkloadLevelHierarchy # Call [Enum]::GetValues([RubrikSecurityCloud.Types.WorkloadLevelHierarchy]) for enum values.
    /// 			}
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
    /// Runs the UpdateS3CompatibleTarget operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: UpdateS3CompatibleTarget
    /// 
    /// $query = New-RscMutationMisc -UpdateS3CompatibleTarget
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	id = $someString
    /// 	# OPTIONAL
    /// 	name = $someString
    /// 	# OPTIONAL
    /// 	accessKey = $someString
    /// 	# OPTIONAL
    /// 	secretKey = $someString
    /// 	# OPTIONAL
    /// 	endpoint = $someString
    /// 	# OPTIONAL
    /// 	numberOfBuckets = $someInt
    /// 	# OPTIONAL
    /// 	isConsolidationEnabled = $someBoolean
    /// 	# OPTIONAL
    /// 	useSystemProxy = $someBoolean
    /// 	# OPTIONAL
    /// 	immutabilitySettings = @{
    /// 		# OPTIONAL
    /// 		bucketLockDurationDays = $someInt
    /// 	}
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: Target
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the UpdateSnmpConfig operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: UpdateSnmpConfig
    /// 
    /// $query = New-RscMutationMisc -UpdateSnmpConfig
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	snmpConfigV50 = @{
    /// 		# OPTIONAL
    /// 		communityString = $someString
    /// 		# OPTIONAL
    /// 		trapReceiverConfigs = @(
    /// 			@{
    /// 				# OPTIONAL
    /// 				user = $someString
    /// 				# OPTIONAL
    /// 				securityLevel = $someSnmpSecurityLevel # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SnmpSecurityLevel]) for enum values.
    /// 				# REQUIRED
    /// 				address = $someString
    /// 				# REQUIRED
    /// 				port = $someInt
    /// 			}
    /// 		)
    /// 		# OPTIONAL
    /// 		users = @(
    /// 			$someString
    /// 		)
    /// 		# REQUIRED
    /// 		isEnabled = $someBoolean
    /// 		# REQUIRED
    /// 		snmpAgentPort = $someInt
    /// 	}
    /// 	# OPTIONAL
    /// 	snmpConfigV51 = @{
    /// 		# OPTIONAL
    /// 		communityString = $someString
    /// 		# OPTIONAL
    /// 		trapReceiverConfigs = @(
    /// 			@{
    /// 				# OPTIONAL
    /// 				user = $someString
    /// 				# OPTIONAL
    /// 				securityLevel = $someSnmpSecurityLevel # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SnmpSecurityLevel]) for enum values.
    /// 				# REQUIRED
    /// 				address = $someString
    /// 				# REQUIRED
    /// 				port = $someInt
    /// 			}
    /// 		)
    /// 		# OPTIONAL
    /// 		users = @(
    /// 			$someString
    /// 		)
    /// 		# REQUIRED
    /// 		isEnabled = $someBoolean
    /// 		# REQUIRED
    /// 		snmpAgentPort = $someInt
    /// 	}
    /// 	# OPTIONAL
    /// 	snmpConfigV52 = @{
    /// 		# OPTIONAL
    /// 		communityString = $someString
    /// 		# OPTIONAL
    /// 		trapReceiverConfigs = @(
    /// 			@{
    /// 				# OPTIONAL
    /// 				user = $someString
    /// 				# OPTIONAL
    /// 				securityLevel = $someSnmpSecurityLevel # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SnmpSecurityLevel]) for enum values.
    /// 				# REQUIRED
    /// 				address = $someString
    /// 				# REQUIRED
    /// 				port = $someInt
    /// 			}
    /// 		)
    /// 		# OPTIONAL
    /// 		users = @(
    /// 			@{
    /// 				# REQUIRED
    /// 				authPassword = $someString
    /// 				# REQUIRED
    /// 				privPassword = $someString
    /// 				# REQUIRED
    /// 				username = $someString
    /// 			}
    /// 		)
    /// 		# REQUIRED
    /// 		isEnabled = $someBoolean
    /// 		# REQUIRED
    /// 		snmpAgentPort = $someInt
    /// 	}
    /// 	# OPTIONAL
    /// 	snmpConfigV53 = @{
    /// 		# OPTIONAL
    /// 		communityString = $someString
    /// 		# OPTIONAL
    /// 		trapReceiverConfigs = @(
    /// 			@{
    /// 				# OPTIONAL
    /// 				user = $someString
    /// 				# OPTIONAL
    /// 				securityLevel = $someSnmpSecurityLevel # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SnmpSecurityLevel]) for enum values.
    /// 				# REQUIRED
    /// 				address = $someString
    /// 				# REQUIRED
    /// 				port = $someInt
    /// 			}
    /// 		)
    /// 		# OPTIONAL
    /// 		users = @(
    /// 			@{
    /// 				# REQUIRED
    /// 				authPassword = $someString
    /// 				# REQUIRED
    /// 				privPassword = $someString
    /// 				# REQUIRED
    /// 				username = $someString
    /// 			}
    /// 		)
    /// 		# REQUIRED
    /// 		isEnabled = $someBoolean
    /// 		# REQUIRED
    /// 		snmpAgentPort = $someInt
    /// 	}
    /// 	# OPTIONAL
    /// 	snmpConfigV60 = @{
    /// 		# OPTIONAL
    /// 		communityString = $someString
    /// 		# OPTIONAL
    /// 		trapReceiverConfigs = @(
    /// 			@{
    /// 				# OPTIONAL
    /// 				user = $someString
    /// 				# OPTIONAL
    /// 				securityLevel = $someSnmpSecurityLevel # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SnmpSecurityLevel]) for enum values.
    /// 				# REQUIRED
    /// 				address = $someString
    /// 				# REQUIRED
    /// 				port = $someInt
    /// 			}
    /// 		)
    /// 		# OPTIONAL
    /// 		users = @(
    /// 			@{
    /// 				# REQUIRED
    /// 				authPassword = $someString
    /// 				# REQUIRED
    /// 				privPassword = $someString
    /// 				# REQUIRED
    /// 				username = $someString
    /// 			}
    /// 		)
    /// 		# REQUIRED
    /// 		isEnabled = $someBoolean
    /// 		# REQUIRED
    /// 		snmpAgentPort = $someInt
    /// 	}
    /// 	# OPTIONAL
    /// 	snmpConfigV70 = @{
    /// 		# OPTIONAL
    /// 		communityString = $someString
    /// 		# OPTIONAL
    /// 		trapReceiverConfigs = @(
    /// 			@{
    /// 				# OPTIONAL
    /// 				user = $someString
    /// 				# OPTIONAL
    /// 				securityLevel = $someSnmpSecurityLevel # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SnmpSecurityLevel]) for enum values.
    /// 				# REQUIRED
    /// 				address = $someString
    /// 				# REQUIRED
    /// 				port = $someInt
    /// 			}
    /// 		)
    /// 		# OPTIONAL
    /// 		users = @(
    /// 			@{
    /// 				# REQUIRED
    /// 				authPassword = $someString
    /// 				# REQUIRED
    /// 				privPassword = $someString
    /// 				# REQUIRED
    /// 				username = $someString
    /// 			}
    /// 		)
    /// 		# REQUIRED
    /// 		isEnabled = $someBoolean
    /// 		# REQUIRED
    /// 		snmpAgentPort = $someInt
    /// 	}
    /// 	# OPTIONAL
    /// 	snmpConfigV80 = @{
    /// 		# OPTIONAL
    /// 		communityString = $someString
    /// 		# OPTIONAL
    /// 		trapReceiverConfigs = @(
    /// 			@{
    /// 				# OPTIONAL
    /// 				user = $someString
    /// 				# OPTIONAL
    /// 				securityLevel = $someSnmpSecurityLevel # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SnmpSecurityLevel]) for enum values.
    /// 				# REQUIRED
    /// 				address = $someString
    /// 				# REQUIRED
    /// 				port = $someInt
    /// 			}
    /// 		)
    /// 		# OPTIONAL
    /// 		users = @(
    /// 			@{
    /// 				# REQUIRED
    /// 				authPassword = $someString
    /// 				# REQUIRED
    /// 				privPassword = $someString
    /// 				# REQUIRED
    /// 				username = $someString
    /// 			}
    /// 		)
    /// 		# REQUIRED
    /// 		isEnabled = $someBoolean
    /// 		# REQUIRED
    /// 		snmpAgentPort = $someInt
    /// 	}
    /// 	# OPTIONAL
    /// 	snmpConfigV81 = @{
    /// 		# OPTIONAL
    /// 		communityString = $someString
    /// 		# OPTIONAL
    /// 		trapReceiverConfigs = @(
    /// 			@{
    /// 				# OPTIONAL
    /// 				user = $someString
    /// 				# OPTIONAL
    /// 				securityLevel = $someSnmpSecurityLevel # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SnmpSecurityLevel]) for enum values.
    /// 				# REQUIRED
    /// 				address = $someString
    /// 				# REQUIRED
    /// 				port = $someInt
    /// 			}
    /// 		)
    /// 		# OPTIONAL
    /// 		users = @(
    /// 			@{
    /// 				# REQUIRED
    /// 				authPassword = $someString
    /// 				# REQUIRED
    /// 				privPassword = $someString
    /// 				# REQUIRED
    /// 				username = $someString
    /// 			}
    /// 		)
    /// 		# REQUIRED
    /// 		isEnabled = $someBoolean
    /// 		# REQUIRED
    /// 		snmpAgentPort = $someInt
    /// 	}
    /// 	# OPTIONAL
    /// 	snmpConfigV90 = @{
    /// 		# OPTIONAL
    /// 		communityString = $someString
    /// 		# OPTIONAL
    /// 		trapReceiverConfigs = @(
    /// 			@{
    /// 				# OPTIONAL
    /// 				user = $someString
    /// 				# OPTIONAL
    /// 				securityLevel = $someSnmpSecurityLevel # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SnmpSecurityLevel]) for enum values.
    /// 				# REQUIRED
    /// 				address = $someString
    /// 				# REQUIRED
    /// 				port = $someInt
    /// 			}
    /// 		)
    /// 		# OPTIONAL
    /// 		users = @(
    /// 			@{
    /// 				# REQUIRED
    /// 				authPassword = $someString
    /// 				# REQUIRED
    /// 				privPassword = $someString
    /// 				# REQUIRED
    /// 				username = $someString
    /// 			}
    /// 		)
    /// 		# REQUIRED
    /// 		isEnabled = $someBoolean
    /// 		# REQUIRED
    /// 		snmpAgentPort = $someInt
    /// 	}
    /// 	# OPTIONAL
    /// 	snmpConfigV91 = @{
    /// 		# OPTIONAL
    /// 		communityString = $someString
    /// 		# OPTIONAL
    /// 		trapReceiverConfigs = @(
    /// 			@{
    /// 				# OPTIONAL
    /// 				user = $someString
    /// 				# OPTIONAL
    /// 				securityLevel = $someSnmpSecurityLevel # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SnmpSecurityLevel]) for enum values.
    /// 				# REQUIRED
    /// 				address = $someString
    /// 				# REQUIRED
    /// 				port = $someInt
    /// 			}
    /// 		)
    /// 		# OPTIONAL
    /// 		users = @(
    /// 			@{
    /// 				# REQUIRED
    /// 				authPassword = $someString
    /// 				# REQUIRED
    /// 				privPassword = $someString
    /// 				# REQUIRED
    /// 				username = $someString
    /// 			}
    /// 		)
    /// 		# REQUIRED
    /// 		isEnabled = $someBoolean
    /// 		# REQUIRED
    /// 		snmpAgentPort = $someInt
    /// 	}
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
    /// Write-Host $result.GetType().Name # prints: UpdateSnmpConfigReply
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
    /// Runs the UpdateSyslogExportRule operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: UpdateSyslogExportRule
    /// 
    /// $query = New-RscMutationMisc -UpdateSyslogExportRule
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	syslogSettingsV51 = @{
    /// 		# OPTIONAL
    /// 		syslogCertificateInfo = @{
    /// 			# OPTIONAL
    /// 			serverCertificate = $someString
    /// 			# OPTIONAL
    /// 			serverCertificateName = $someString
    /// 		}
    /// 		# OPTIONAL
    /// 		syslogExportRulePartial = @{
    /// 			# OPTIONAL
    /// 			enableTls = $someBoolean
    /// 			# OPTIONAL
    /// 			hostname = $someString
    /// 			# OPTIONAL
    /// 			port = $someInt
    /// 			# OPTIONAL
    /// 			certificateId = $someString
    /// 			# OPTIONAL
    /// 			facility = $someSyslogFacility # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogFacility]) for enum values.
    /// 			# OPTIONAL
    /// 			protocol = $someTransportLayerProtocol # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TransportLayerProtocol]) for enum values.
    /// 			# OPTIONAL
    /// 			severity = $someSyslogSeverity # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogSeverity]) for enum values.
    /// 		}
    /// 	}
    /// 	# OPTIONAL
    /// 	syslogSettingsV52 = @{
    /// 		# OPTIONAL
    /// 		enableTls = $someBoolean
    /// 		# OPTIONAL
    /// 		hostname = $someString
    /// 		# OPTIONAL
    /// 		port = $someInt
    /// 		# OPTIONAL
    /// 		certificateId = $someString
    /// 		# OPTIONAL
    /// 		facility = $someSyslogFacility # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogFacility]) for enum values.
    /// 		# OPTIONAL
    /// 		protocol = $someTransportLayerProtocol # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TransportLayerProtocol]) for enum values.
    /// 		# OPTIONAL
    /// 		severity = $someSyslogSeverity # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogSeverity]) for enum values.
    /// 	}
    /// 	# OPTIONAL
    /// 	syslogSettingsV53 = @{
    /// 		# OPTIONAL
    /// 		enableTls = $someBoolean
    /// 		# OPTIONAL
    /// 		hostname = $someString
    /// 		# OPTIONAL
    /// 		port = $someInt
    /// 		# OPTIONAL
    /// 		certificateId = $someString
    /// 		# OPTIONAL
    /// 		facility = $someSyslogFacility # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogFacility]) for enum values.
    /// 		# OPTIONAL
    /// 		protocol = $someTransportLayerProtocol # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TransportLayerProtocol]) for enum values.
    /// 		# OPTIONAL
    /// 		severity = $someSyslogSeverity # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogSeverity]) for enum values.
    /// 	}
    /// 	# OPTIONAL
    /// 	syslogSettingsV60 = @{
    /// 		# OPTIONAL
    /// 		enableTls = $someBoolean
    /// 		# OPTIONAL
    /// 		hostname = $someString
    /// 		# OPTIONAL
    /// 		port = $someInt
    /// 		# OPTIONAL
    /// 		certificateId = $someString
    /// 		# OPTIONAL
    /// 		facility = $someSyslogFacility # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogFacility]) for enum values.
    /// 		# OPTIONAL
    /// 		protocol = $someTransportLayerProtocol # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TransportLayerProtocol]) for enum values.
    /// 		# OPTIONAL
    /// 		severity = $someSyslogSeverity # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogSeverity]) for enum values.
    /// 	}
    /// 	# OPTIONAL
    /// 	syslogSettingsV70 = @{
    /// 		# OPTIONAL
    /// 		enableTls = $someBoolean
    /// 		# OPTIONAL
    /// 		hostname = $someString
    /// 		# OPTIONAL
    /// 		port = $someInt
    /// 		# OPTIONAL
    /// 		certificateId = $someString
    /// 		# OPTIONAL
    /// 		facility = $someSyslogFacility # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogFacility]) for enum values.
    /// 		# OPTIONAL
    /// 		protocol = $someTransportLayerProtocol # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TransportLayerProtocol]) for enum values.
    /// 		# OPTIONAL
    /// 		severity = $someSyslogSeverity # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogSeverity]) for enum values.
    /// 	}
    /// 	# OPTIONAL
    /// 	syslogSettingsV80 = @{
    /// 		# OPTIONAL
    /// 		enableTls = $someBoolean
    /// 		# OPTIONAL
    /// 		hostname = $someString
    /// 		# OPTIONAL
    /// 		port = $someInt
    /// 		# OPTIONAL
    /// 		certificateId = $someString
    /// 		# OPTIONAL
    /// 		facility = $someSyslogFacility # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogFacility]) for enum values.
    /// 		# OPTIONAL
    /// 		protocol = $someTransportLayerProtocol # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TransportLayerProtocol]) for enum values.
    /// 		# OPTIONAL
    /// 		severity = $someSyslogSeverity # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogSeverity]) for enum values.
    /// 	}
    /// 	# OPTIONAL
    /// 	syslogSettingsV81 = @{
    /// 		# OPTIONAL
    /// 		enableTls = $someBoolean
    /// 		# OPTIONAL
    /// 		hostname = $someString
    /// 		# OPTIONAL
    /// 		port = $someInt
    /// 		# OPTIONAL
    /// 		certificateId = $someString
    /// 		# OPTIONAL
    /// 		facility = $someSyslogFacility # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogFacility]) for enum values.
    /// 		# OPTIONAL
    /// 		protocol = $someTransportLayerProtocol # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TransportLayerProtocol]) for enum values.
    /// 		# OPTIONAL
    /// 		severity = $someSyslogSeverity # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogSeverity]) for enum values.
    /// 	}
    /// 	# OPTIONAL
    /// 	syslogSettingsV90 = @{
    /// 		# OPTIONAL
    /// 		enableTls = $someBoolean
    /// 		# OPTIONAL
    /// 		hostname = $someString
    /// 		# OPTIONAL
    /// 		port = $someInt
    /// 		# OPTIONAL
    /// 		certificateId = $someString
    /// 		# OPTIONAL
    /// 		facility = $someSyslogFacility # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogFacility]) for enum values.
    /// 		# OPTIONAL
    /// 		protocol = $someTransportLayerProtocol # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TransportLayerProtocol]) for enum values.
    /// 		# OPTIONAL
    /// 		severity = $someSyslogSeverity # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogSeverity]) for enum values.
    /// 	}
    /// 	# OPTIONAL
    /// 	syslogSettingsV91 = @{
    /// 		# OPTIONAL
    /// 		enableTls = $someBoolean
    /// 		# OPTIONAL
    /// 		hostname = $someString
    /// 		# OPTIONAL
    /// 		port = $someInt
    /// 		# OPTIONAL
    /// 		certificateId = $someString
    /// 		# OPTIONAL
    /// 		facility = $someSyslogFacility # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogFacility]) for enum values.
    /// 		# OPTIONAL
    /// 		protocol = $someTransportLayerProtocol # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TransportLayerProtocol]) for enum values.
    /// 		# OPTIONAL
    /// 		severity = $someSyslogSeverity # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogSeverity]) for enum values.
    /// 	}
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
    /// Write-Host $result.GetType().Name # prints: UpdateSyslogExportRuleReply
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
    /// Runs the UpgradeCdmManagedTarget operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: UpgradeCdmManagedTarget
    /// 
    /// $query = New-RscMutationMisc -UpgradeCdmManagedTarget
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
                "AddClusterNodes",
                "AddConfiguredGroupToHierarchy",
                "AddInventoryWorkloads",
                "AddPolicyObjects",
                "AddRoleAssignments",
                "AddSyslogExportRule",
                "AddVlan",
                "AddVmAppConsistentSpecs",
                "ArchiveCrawl",
                "AssignProtection",
                "BatchDeassignRoleFromUserGroups",
                "BulkCreateNasFilesets",
                "BulkDeleteFailoverClusterApp",
                "BulkDeleteNasSystems",
                "CancelDownloadPackage",
                "CancelScheduledUpgrade",
                "CancelTaskchain",
                "ChangePassword",
                "CreateActiveDirectoryLiveMount",
                "CreateActiveDirectoryUnmount",
                "CreateCustomAnalyzer",
                "CreateFailoverClusterApp",
                "CreateGlacierReaderTarget",
                "CreateGuestCredential",
                "CreateIntegration",
                "CreateIntegrations",
                "CreateManualTargetMapping",
                "CreateOnDemandVolumeGroupBackup",
                "CreateOrg",
                "CreateOrgSwitchSession",
                "CreatePolicy",
                "CreateRole",
                "CreateS3CompatibleReaderTarget",
                "CreateS3CompatibleTarget",
                "CreateUser",
                "CreateUserWithPassword",
                "CreateVappsInstantRecovery",
                "DeactivateCustomAnalyzer",
                "DeactivatePolicy",
                "DeleteAdGroupsFromHierarchy",
                "DeleteCsr",
                "DeleteDistributionListDigestBatch",
                "DeleteEventDigest",
                "DeleteFailoverClusterApp",
                "DeleteGuestCredentialById",
                "DeleteIntegration",
                "DeleteIntegrations",
                "DeleteLogShipping",
                "DeleteNasSystem",
                "DeleteOrg",
                "DeleteRole",
                "DeleteSyslogExportRule",
                "DeleteTarget",
                "DeleteTargetMapping",
                "DeleteTotpConfig",
                "DeleteTotpConfigs",
                "DeleteVolumeGroupMount",
                "DisableSupportUserAccess",
                "DisableTarget",
                "EnableAutomaticFmdUpload",
                "EnableDisableAppConsistency",
                "EnableSupportUserAccess",
                "EnableTarget",
                "ExcludeVmDisks",
                "GenerateClusterRegistrationToken",
                "GenerateConfigProtectionRestoreForm",
                "GenerateCsr",
                "GenerateSupportBundle",
                "GenerateTotpSecret",
                "GetDownloadUrl",
                "GetHealthMonitorPolicyStatus",
                "HideRevealNasNamespaces",
                "HideRevealNasShares",
                "InstallIoFilter",
                "InviteSsoGroup",
                "ListCidrsForComputeSetting",
                "LockUsersByAdmin",
                "LogoutFromRubrikSupportPortal",
                "MakePrimary",
                "ModifyActiveDirectoryLiveMount",
                "ModifyIpmi",
                "MountDisk",
                "MutateRole",
                "NotificationForGetLicense",
                "PauseTarget",
                "PromoteReaderTarget",
                "RecoverCloudDirectMultiPaths",
                "RecoverCloudDirectPath",
                "RefreshDomain",
                "RefreshGlobalManagerConnectivityStatus",
                "RefreshNasSystems",
                "RefreshReaderTarget",
                "RegisterNasSystem",
                "RemoveClusterNodes",
                "RemoveDisk",
                "RemoveInventoryWorkloads",
                "RemovePolicyObjects",
                "RemovePrivateEndpointList",
                "RemoveProxyConfig",
                "RemoveVlans",
                "ReseedLogShippingSecondary",
                "ResetAllOrgUsersPasswords",
                "ResetUsersPasswordsWithUserIds",
                "ResizeDisk",
                "ResolveVolumeGroupsConflict",
                "RestoreActiveDirectoryObjects",
                "ResumeTarget",
                "RetryBackup",
                "RetryDownloadPackageJob",
                "RevokeAllOrgRoles",
                "RunCustomAnalyzer",
                "ScheduleUpgradeBatchJob",
                "SetAnalyzerRisks",
                "SetCustomerTags",
                "SetDatastoreFreespaceThresholds",
                "SetIpWhitelistEnabled",
                "SetMfaSetting",
                "SetPasswordComplexityPolicy",
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
                "SupportPortalLogin",
                "TestSyslogExportRule",
                "TriggerCloudComputeConnectivityCheck",
                "TriggerExocomputeHealthCheck",
                "UninstallIoFilter",
                "UnlockUsersByAdmin",
                "UnmountDisk",
                "UpdateAccountOwner",
                "UpdateAuthDomainUsersHiddenStatus",
                "UpdateAutoEnablePolicyClusterConfig",
                "UpdateBadDiskLedStatus",
                "UpdateClusterDefaultAddress",
                "UpdateClusterLocation",
                "UpdateClusterNtpServers",
                "UpdateClusterSettings",
                "UpdateConfiguredGroup",
                "UpdateCustomAnalyzer",
                "UpdateDistributionListDigest",
                "UpdateDnsServersAndSearchDomains",
                "UpdateEventDigest",
                "UpdateFailoverClusterApp",
                "UpdateFloatingIps",
                "UpdateGlacierTarget",
                "UpdateGuestCredential",
                "UpdateHealthMonitorPolicyStatus",
                "UpdateInsightState",
                "UpdateIntegration",
                "UpdateIntegrations",
                "UpdateIpWhitelist",
                "UpdateLambdaSettings",
                "UpdateLockoutConfig",
                "UpdateManualTargetMapping",
                "UpdateNasShares",
                "UpdateNasSystem",
                "UpdateNetworkThrottle",
                "UpdateOrg",
                "UpdateOrgSecurityPolicy",
                "UpdatePolicy",
                "UpdatePreviewerClusterConfig",
                "UpdateProxyConfig",
                "UpdateRole",
                "UpdateRoleAssignments",
                "UpdateS3CompatibleTarget",
                "UpdateSnmpConfig",
                "UpdateSupportUserAccess",
                "UpdateSyslogExportRule",
                "UpdateTunnelStatus",
                "UpdateVolumeGroup",
                "UpdateWhitelistedAnalyzers",
                "UpgradeCdmManagedTarget",
                "UpgradeIoFilter",
                "UpgradeToRsc",
                "ValidateAndSaveCustomerKmsInfo",
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
                    case "AddClusterNodes":
                        this.ProcessRecord_AddClusterNodes();
                        break;
                    case "AddConfiguredGroupToHierarchy":
                        this.ProcessRecord_AddConfiguredGroupToHierarchy();
                        break;
                    case "AddInventoryWorkloads":
                        this.ProcessRecord_AddInventoryWorkloads();
                        break;
                    case "AddPolicyObjects":
                        this.ProcessRecord_AddPolicyObjects();
                        break;
                    case "AddRoleAssignments":
                        this.ProcessRecord_AddRoleAssignments();
                        break;
                    case "AddSyslogExportRule":
                        this.ProcessRecord_AddSyslogExportRule();
                        break;
                    case "AddVlan":
                        this.ProcessRecord_AddVlan();
                        break;
                    case "AddVmAppConsistentSpecs":
                        this.ProcessRecord_AddVmAppConsistentSpecs();
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
                    case "BulkDeleteFailoverClusterApp":
                        this.ProcessRecord_BulkDeleteFailoverClusterApp();
                        break;
                    case "BulkDeleteNasSystems":
                        this.ProcessRecord_BulkDeleteNasSystems();
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
                    case "ChangePassword":
                        this.ProcessRecord_ChangePassword();
                        break;
                    case "CreateActiveDirectoryLiveMount":
                        this.ProcessRecord_CreateActiveDirectoryLiveMount();
                        break;
                    case "CreateActiveDirectoryUnmount":
                        this.ProcessRecord_CreateActiveDirectoryUnmount();
                        break;
                    case "CreateCustomAnalyzer":
                        this.ProcessRecord_CreateCustomAnalyzer();
                        break;
                    case "CreateFailoverClusterApp":
                        this.ProcessRecord_CreateFailoverClusterApp();
                        break;
                    case "CreateGlacierReaderTarget":
                        this.ProcessRecord_CreateGlacierReaderTarget();
                        break;
                    case "CreateGuestCredential":
                        this.ProcessRecord_CreateGuestCredential();
                        break;
                    case "CreateIntegration":
                        this.ProcessRecord_CreateIntegration();
                        break;
                    case "CreateIntegrations":
                        this.ProcessRecord_CreateIntegrations();
                        break;
                    case "CreateManualTargetMapping":
                        this.ProcessRecord_CreateManualTargetMapping();
                        break;
                    case "CreateOnDemandVolumeGroupBackup":
                        this.ProcessRecord_CreateOnDemandVolumeGroupBackup();
                        break;
                    case "CreateOrg":
                        this.ProcessRecord_CreateOrg();
                        break;
                    case "CreateOrgSwitchSession":
                        this.ProcessRecord_CreateOrgSwitchSession();
                        break;
                    case "CreatePolicy":
                        this.ProcessRecord_CreatePolicy();
                        break;
                    case "CreateRole":
                        this.ProcessRecord_CreateRole();
                        break;
                    case "CreateS3CompatibleReaderTarget":
                        this.ProcessRecord_CreateS3CompatibleReaderTarget();
                        break;
                    case "CreateS3CompatibleTarget":
                        this.ProcessRecord_CreateS3CompatibleTarget();
                        break;
                    case "CreateUser":
                        this.ProcessRecord_CreateUser();
                        break;
                    case "CreateUserWithPassword":
                        this.ProcessRecord_CreateUserWithPassword();
                        break;
                    case "CreateVappsInstantRecovery":
                        this.ProcessRecord_CreateVappsInstantRecovery();
                        break;
                    case "DeactivateCustomAnalyzer":
                        this.ProcessRecord_DeactivateCustomAnalyzer();
                        break;
                    case "DeactivatePolicy":
                        this.ProcessRecord_DeactivatePolicy();
                        break;
                    case "DeleteAdGroupsFromHierarchy":
                        this.ProcessRecord_DeleteAdGroupsFromHierarchy();
                        break;
                    case "DeleteCsr":
                        this.ProcessRecord_DeleteCsr();
                        break;
                    case "DeleteDistributionListDigestBatch":
                        this.ProcessRecord_DeleteDistributionListDigestBatch();
                        break;
                    case "DeleteEventDigest":
                        this.ProcessRecord_DeleteEventDigest();
                        break;
                    case "DeleteFailoverClusterApp":
                        this.ProcessRecord_DeleteFailoverClusterApp();
                        break;
                    case "DeleteGuestCredentialById":
                        this.ProcessRecord_DeleteGuestCredentialById();
                        break;
                    case "DeleteIntegration":
                        this.ProcessRecord_DeleteIntegration();
                        break;
                    case "DeleteIntegrations":
                        this.ProcessRecord_DeleteIntegrations();
                        break;
                    case "DeleteLogShipping":
                        this.ProcessRecord_DeleteLogShipping();
                        break;
                    case "DeleteNasSystem":
                        this.ProcessRecord_DeleteNasSystem();
                        break;
                    case "DeleteOrg":
                        this.ProcessRecord_DeleteOrg();
                        break;
                    case "DeleteRole":
                        this.ProcessRecord_DeleteRole();
                        break;
                    case "DeleteSyslogExportRule":
                        this.ProcessRecord_DeleteSyslogExportRule();
                        break;
                    case "DeleteTarget":
                        this.ProcessRecord_DeleteTarget();
                        break;
                    case "DeleteTargetMapping":
                        this.ProcessRecord_DeleteTargetMapping();
                        break;
                    case "DeleteTotpConfig":
                        this.ProcessRecord_DeleteTotpConfig();
                        break;
                    case "DeleteTotpConfigs":
                        this.ProcessRecord_DeleteTotpConfigs();
                        break;
                    case "DeleteVolumeGroupMount":
                        this.ProcessRecord_DeleteVolumeGroupMount();
                        break;
                    case "DisableSupportUserAccess":
                        this.ProcessRecord_DisableSupportUserAccess();
                        break;
                    case "DisableTarget":
                        this.ProcessRecord_DisableTarget();
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
                    case "EnableTarget":
                        this.ProcessRecord_EnableTarget();
                        break;
                    case "ExcludeVmDisks":
                        this.ProcessRecord_ExcludeVmDisks();
                        break;
                    case "GenerateClusterRegistrationToken":
                        this.ProcessRecord_GenerateClusterRegistrationToken();
                        break;
                    case "GenerateConfigProtectionRestoreForm":
                        this.ProcessRecord_GenerateConfigProtectionRestoreForm();
                        break;
                    case "GenerateCsr":
                        this.ProcessRecord_GenerateCsr();
                        break;
                    case "GenerateSupportBundle":
                        this.ProcessRecord_GenerateSupportBundle();
                        break;
                    case "GenerateTotpSecret":
                        this.ProcessRecord_GenerateTotpSecret();
                        break;
                    case "GetDownloadUrl":
                        this.ProcessRecord_GetDownloadUrl();
                        break;
                    case "GetHealthMonitorPolicyStatus":
                        this.ProcessRecord_GetHealthMonitorPolicyStatus();
                        break;
                    case "HideRevealNasNamespaces":
                        this.ProcessRecord_HideRevealNasNamespaces();
                        break;
                    case "HideRevealNasShares":
                        this.ProcessRecord_HideRevealNasShares();
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
                    case "ModifyActiveDirectoryLiveMount":
                        this.ProcessRecord_ModifyActiveDirectoryLiveMount();
                        break;
                    case "ModifyIpmi":
                        this.ProcessRecord_ModifyIpmi();
                        break;
                    case "MountDisk":
                        this.ProcessRecord_MountDisk();
                        break;
                    case "MutateRole":
                        this.ProcessRecord_MutateRole();
                        break;
                    case "NotificationForGetLicense":
                        this.ProcessRecord_NotificationForGetLicense();
                        break;
                    case "PauseTarget":
                        this.ProcessRecord_PauseTarget();
                        break;
                    case "PromoteReaderTarget":
                        this.ProcessRecord_PromoteReaderTarget();
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
                    case "RefreshNasSystems":
                        this.ProcessRecord_RefreshNasSystems();
                        break;
                    case "RefreshReaderTarget":
                        this.ProcessRecord_RefreshReaderTarget();
                        break;
                    case "RegisterNasSystem":
                        this.ProcessRecord_RegisterNasSystem();
                        break;
                    case "RemoveClusterNodes":
                        this.ProcessRecord_RemoveClusterNodes();
                        break;
                    case "RemoveDisk":
                        this.ProcessRecord_RemoveDisk();
                        break;
                    case "RemoveInventoryWorkloads":
                        this.ProcessRecord_RemoveInventoryWorkloads();
                        break;
                    case "RemovePolicyObjects":
                        this.ProcessRecord_RemovePolicyObjects();
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
                    case "ResolveVolumeGroupsConflict":
                        this.ProcessRecord_ResolveVolumeGroupsConflict();
                        break;
                    case "RestoreActiveDirectoryObjects":
                        this.ProcessRecord_RestoreActiveDirectoryObjects();
                        break;
                    case "ResumeTarget":
                        this.ProcessRecord_ResumeTarget();
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
                    case "SetPasswordComplexityPolicy":
                        this.ProcessRecord_SetPasswordComplexityPolicy();
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
                    case "SupportPortalLogin":
                        this.ProcessRecord_SupportPortalLogin();
                        break;
                    case "TestSyslogExportRule":
                        this.ProcessRecord_TestSyslogExportRule();
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
                    case "UpdateAuthDomainUsersHiddenStatus":
                        this.ProcessRecord_UpdateAuthDomainUsersHiddenStatus();
                        break;
                    case "UpdateAutoEnablePolicyClusterConfig":
                        this.ProcessRecord_UpdateAutoEnablePolicyClusterConfig();
                        break;
                    case "UpdateBadDiskLedStatus":
                        this.ProcessRecord_UpdateBadDiskLedStatus();
                        break;
                    case "UpdateClusterDefaultAddress":
                        this.ProcessRecord_UpdateClusterDefaultAddress();
                        break;
                    case "UpdateClusterLocation":
                        this.ProcessRecord_UpdateClusterLocation();
                        break;
                    case "UpdateClusterNtpServers":
                        this.ProcessRecord_UpdateClusterNtpServers();
                        break;
                    case "UpdateClusterSettings":
                        this.ProcessRecord_UpdateClusterSettings();
                        break;
                    case "UpdateConfiguredGroup":
                        this.ProcessRecord_UpdateConfiguredGroup();
                        break;
                    case "UpdateCustomAnalyzer":
                        this.ProcessRecord_UpdateCustomAnalyzer();
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
                    case "UpdateFailoverClusterApp":
                        this.ProcessRecord_UpdateFailoverClusterApp();
                        break;
                    case "UpdateFloatingIps":
                        this.ProcessRecord_UpdateFloatingIps();
                        break;
                    case "UpdateGlacierTarget":
                        this.ProcessRecord_UpdateGlacierTarget();
                        break;
                    case "UpdateGuestCredential":
                        this.ProcessRecord_UpdateGuestCredential();
                        break;
                    case "UpdateHealthMonitorPolicyStatus":
                        this.ProcessRecord_UpdateHealthMonitorPolicyStatus();
                        break;
                    case "UpdateInsightState":
                        this.ProcessRecord_UpdateInsightState();
                        break;
                    case "UpdateIntegration":
                        this.ProcessRecord_UpdateIntegration();
                        break;
                    case "UpdateIntegrations":
                        this.ProcessRecord_UpdateIntegrations();
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
                    case "UpdateManualTargetMapping":
                        this.ProcessRecord_UpdateManualTargetMapping();
                        break;
                    case "UpdateNasShares":
                        this.ProcessRecord_UpdateNasShares();
                        break;
                    case "UpdateNasSystem":
                        this.ProcessRecord_UpdateNasSystem();
                        break;
                    case "UpdateNetworkThrottle":
                        this.ProcessRecord_UpdateNetworkThrottle();
                        break;
                    case "UpdateOrg":
                        this.ProcessRecord_UpdateOrg();
                        break;
                    case "UpdateOrgSecurityPolicy":
                        this.ProcessRecord_UpdateOrgSecurityPolicy();
                        break;
                    case "UpdatePolicy":
                        this.ProcessRecord_UpdatePolicy();
                        break;
                    case "UpdatePreviewerClusterConfig":
                        this.ProcessRecord_UpdatePreviewerClusterConfig();
                        break;
                    case "UpdateProxyConfig":
                        this.ProcessRecord_UpdateProxyConfig();
                        break;
                    case "UpdateRole":
                        this.ProcessRecord_UpdateRole();
                        break;
                    case "UpdateRoleAssignments":
                        this.ProcessRecord_UpdateRoleAssignments();
                        break;
                    case "UpdateS3CompatibleTarget":
                        this.ProcessRecord_UpdateS3CompatibleTarget();
                        break;
                    case "UpdateSnmpConfig":
                        this.ProcessRecord_UpdateSnmpConfig();
                        break;
                    case "UpdateSupportUserAccess":
                        this.ProcessRecord_UpdateSupportUserAccess();
                        break;
                    case "UpdateSyslogExportRule":
                        this.ProcessRecord_UpdateSyslogExportRule();
                        break;
                    case "UpdateTunnelStatus":
                        this.ProcessRecord_UpdateTunnelStatus();
                        break;
                    case "UpdateVolumeGroup":
                        this.ProcessRecord_UpdateVolumeGroup();
                        break;
                    case "UpdateWhitelistedAnalyzers":
                        this.ProcessRecord_UpdateWhitelistedAnalyzers();
                        break;
                    case "UpgradeCdmManagedTarget":
                        this.ProcessRecord_UpgradeCdmManagedTarget();
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
        // addClusterNodes.
        internal void ProcessRecord_AddClusterNodes()
        {
            this._logger.name += " -AddClusterNodes";
            // Create new graphql operation addClusterNodes
            InitMutationAddClusterNodes();
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
        // addInventoryWorkloads.
        internal void ProcessRecord_AddInventoryWorkloads()
        {
            this._logger.name += " -AddInventoryWorkloads";
            // Create new graphql operation addInventoryWorkloads
            InitMutationAddInventoryWorkloads();
        }

        // This parameter set invokes a single graphql operation:
        // addPolicyObjects.
        internal void ProcessRecord_AddPolicyObjects()
        {
            this._logger.name += " -AddPolicyObjects";
            // Create new graphql operation addPolicyObjects
            InitMutationAddPolicyObjects();
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
        // addSyslogExportRule.
        internal void ProcessRecord_AddSyslogExportRule()
        {
            this._logger.name += " -AddSyslogExportRule";
            // Create new graphql operation addSyslogExportRule
            InitMutationAddSyslogExportRule();
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
        // bulkDeleteFailoverClusterApp.
        internal void ProcessRecord_BulkDeleteFailoverClusterApp()
        {
            this._logger.name += " -BulkDeleteFailoverClusterApp";
            // Create new graphql operation bulkDeleteFailoverClusterApp
            InitMutationBulkDeleteFailoverClusterApp();
        }

        // This parameter set invokes a single graphql operation:
        // bulkDeleteNasSystems.
        internal void ProcessRecord_BulkDeleteNasSystems()
        {
            this._logger.name += " -BulkDeleteNasSystems";
            // Create new graphql operation bulkDeleteNasSystems
            InitMutationBulkDeleteNasSystems();
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
        // changePassword.
        internal void ProcessRecord_ChangePassword()
        {
            this._logger.name += " -ChangePassword";
            // Create new graphql operation changePassword
            InitMutationChangePassword();
        }

        // This parameter set invokes a single graphql operation:
        // createActiveDirectoryLiveMount.
        internal void ProcessRecord_CreateActiveDirectoryLiveMount()
        {
            this._logger.name += " -CreateActiveDirectoryLiveMount";
            // Create new graphql operation createActiveDirectoryLiveMount
            InitMutationCreateActiveDirectoryLiveMount();
        }

        // This parameter set invokes a single graphql operation:
        // createActiveDirectoryUnmount.
        internal void ProcessRecord_CreateActiveDirectoryUnmount()
        {
            this._logger.name += " -CreateActiveDirectoryUnmount";
            // Create new graphql operation createActiveDirectoryUnmount
            InitMutationCreateActiveDirectoryUnmount();
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
        // createFailoverClusterApp.
        internal void ProcessRecord_CreateFailoverClusterApp()
        {
            this._logger.name += " -CreateFailoverClusterApp";
            // Create new graphql operation createFailoverClusterApp
            InitMutationCreateFailoverClusterApp();
        }

        // This parameter set invokes a single graphql operation:
        // createGlacierReaderTarget.
        internal void ProcessRecord_CreateGlacierReaderTarget()
        {
            this._logger.name += " -CreateGlacierReaderTarget";
            // Create new graphql operation createGlacierReaderTarget
            InitMutationCreateGlacierReaderTarget();
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
        // createIntegration.
        internal void ProcessRecord_CreateIntegration()
        {
            this._logger.name += " -CreateIntegration";
            // Create new graphql operation createIntegration
            InitMutationCreateIntegration();
        }

        // This parameter set invokes a single graphql operation:
        // createIntegrations.
        internal void ProcessRecord_CreateIntegrations()
        {
            this._logger.name += " -CreateIntegrations";
            // Create new graphql operation createIntegrations
            InitMutationCreateIntegrations();
        }

        // This parameter set invokes a single graphql operation:
        // createManualTargetMapping.
        internal void ProcessRecord_CreateManualTargetMapping()
        {
            this._logger.name += " -CreateManualTargetMapping";
            // Create new graphql operation createManualTargetMapping
            InitMutationCreateManualTargetMapping();
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
        // createOrg.
        internal void ProcessRecord_CreateOrg()
        {
            this._logger.name += " -CreateOrg";
            // Create new graphql operation createOrg
            InitMutationCreateOrg();
        }

        // This parameter set invokes a single graphql operation:
        // createOrgSwitchSession.
        internal void ProcessRecord_CreateOrgSwitchSession()
        {
            this._logger.name += " -CreateOrgSwitchSession";
            // Create new graphql operation createOrgSwitchSession
            InitMutationCreateOrgSwitchSession();
        }

        // This parameter set invokes a single graphql operation:
        // createPolicy.
        internal void ProcessRecord_CreatePolicy()
        {
            this._logger.name += " -CreatePolicy";
            // Create new graphql operation createPolicy
            InitMutationCreatePolicy();
        }

        // This parameter set invokes a single graphql operation:
        // createRole.
        internal void ProcessRecord_CreateRole()
        {
            this._logger.name += " -CreateRole";
            // Create new graphql operation createRole
            InitMutationCreateRole();
        }

        // This parameter set invokes a single graphql operation:
        // createS3CompatibleReaderTarget.
        internal void ProcessRecord_CreateS3CompatibleReaderTarget()
        {
            this._logger.name += " -CreateS3CompatibleReaderTarget";
            // Create new graphql operation createS3CompatibleReaderTarget
            InitMutationCreateS3CompatibleReaderTarget();
        }

        // This parameter set invokes a single graphql operation:
        // createS3CompatibleTarget.
        internal void ProcessRecord_CreateS3CompatibleTarget()
        {
            this._logger.name += " -CreateS3CompatibleTarget";
            // Create new graphql operation createS3CompatibleTarget
            InitMutationCreateS3CompatibleTarget();
        }

        // This parameter set invokes a single graphql operation:
        // createUser.
        internal void ProcessRecord_CreateUser()
        {
            this._logger.name += " -CreateUser";
            // Create new graphql operation createUser
            InitMutationCreateUser();
        }

        // This parameter set invokes a single graphql operation:
        // createUserWithPassword.
        internal void ProcessRecord_CreateUserWithPassword()
        {
            this._logger.name += " -CreateUserWithPassword";
            // Create new graphql operation createUserWithPassword
            InitMutationCreateUserWithPassword();
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
        // deactivatePolicy.
        internal void ProcessRecord_DeactivatePolicy()
        {
            this._logger.name += " -DeactivatePolicy";
            // Create new graphql operation deactivatePolicy
            InitMutationDeactivatePolicy();
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
        // deleteCsr.
        internal void ProcessRecord_DeleteCsr()
        {
            this._logger.name += " -DeleteCsr";
            // Create new graphql operation deleteCsr
            InitMutationDeleteCsr();
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
        // deleteFailoverClusterApp.
        internal void ProcessRecord_DeleteFailoverClusterApp()
        {
            this._logger.name += " -DeleteFailoverClusterApp";
            // Create new graphql operation deleteFailoverClusterApp
            InitMutationDeleteFailoverClusterApp();
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
        // deleteIntegration.
        internal void ProcessRecord_DeleteIntegration()
        {
            this._logger.name += " -DeleteIntegration";
            // Create new graphql operation deleteIntegration
            InitMutationDeleteIntegration();
        }

        // This parameter set invokes a single graphql operation:
        // deleteIntegrations.
        internal void ProcessRecord_DeleteIntegrations()
        {
            this._logger.name += " -DeleteIntegrations";
            // Create new graphql operation deleteIntegrations
            InitMutationDeleteIntegrations();
        }

        // This parameter set invokes a single graphql operation:
        // deleteLogShipping.
        internal void ProcessRecord_DeleteLogShipping()
        {
            this._logger.name += " -DeleteLogShipping";
            // Create new graphql operation deleteLogShipping
            InitMutationDeleteLogShipping();
        }

        // This parameter set invokes a single graphql operation:
        // deleteNasSystem.
        internal void ProcessRecord_DeleteNasSystem()
        {
            this._logger.name += " -DeleteNasSystem";
            // Create new graphql operation deleteNasSystem
            InitMutationDeleteNasSystem();
        }

        // This parameter set invokes a single graphql operation:
        // deleteOrg.
        internal void ProcessRecord_DeleteOrg()
        {
            this._logger.name += " -DeleteOrg";
            // Create new graphql operation deleteOrg
            InitMutationDeleteOrg();
        }

        // This parameter set invokes a single graphql operation:
        // deleteRole.
        internal void ProcessRecord_DeleteRole()
        {
            this._logger.name += " -DeleteRole";
            // Create new graphql operation deleteRole
            InitMutationDeleteRole();
        }

        // This parameter set invokes a single graphql operation:
        // deleteSyslogExportRule.
        internal void ProcessRecord_DeleteSyslogExportRule()
        {
            this._logger.name += " -DeleteSyslogExportRule";
            // Create new graphql operation deleteSyslogExportRule
            InitMutationDeleteSyslogExportRule();
        }

        // This parameter set invokes a single graphql operation:
        // deleteTarget.
        internal void ProcessRecord_DeleteTarget()
        {
            this._logger.name += " -DeleteTarget";
            // Create new graphql operation deleteTarget
            InitMutationDeleteTarget();
        }

        // This parameter set invokes a single graphql operation:
        // deleteTargetMapping.
        internal void ProcessRecord_DeleteTargetMapping()
        {
            this._logger.name += " -DeleteTargetMapping";
            // Create new graphql operation deleteTargetMapping
            InitMutationDeleteTargetMapping();
        }

        // This parameter set invokes a single graphql operation:
        // deleteTotpConfig.
        internal void ProcessRecord_DeleteTotpConfig()
        {
            this._logger.name += " -DeleteTotpConfig";
            // Create new graphql operation deleteTotpConfig
            InitMutationDeleteTotpConfig();
        }

        // This parameter set invokes a single graphql operation:
        // deleteTotpConfigs.
        internal void ProcessRecord_DeleteTotpConfigs()
        {
            this._logger.name += " -DeleteTotpConfigs";
            // Create new graphql operation deleteTotpConfigs
            InitMutationDeleteTotpConfigs();
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
        // disableSupportUserAccess.
        internal void ProcessRecord_DisableSupportUserAccess()
        {
            this._logger.name += " -DisableSupportUserAccess";
            // Create new graphql operation disableSupportUserAccess
            InitMutationDisableSupportUserAccess();
        }

        // This parameter set invokes a single graphql operation:
        // disableTarget.
        internal void ProcessRecord_DisableTarget()
        {
            this._logger.name += " -DisableTarget";
            // Create new graphql operation disableTarget
            InitMutationDisableTarget();
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
        // enableTarget.
        internal void ProcessRecord_EnableTarget()
        {
            this._logger.name += " -EnableTarget";
            // Create new graphql operation enableTarget
            InitMutationEnableTarget();
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
        // generateClusterRegistrationToken.
        internal void ProcessRecord_GenerateClusterRegistrationToken()
        {
            this._logger.name += " -GenerateClusterRegistrationToken";
            // Create new graphql operation generateClusterRegistrationToken
            InitMutationGenerateClusterRegistrationToken();
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
        // generateCsr.
        internal void ProcessRecord_GenerateCsr()
        {
            this._logger.name += " -GenerateCsr";
            // Create new graphql operation generateCsr
            InitMutationGenerateCsr();
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
        // generateTotpSecret.
        internal void ProcessRecord_GenerateTotpSecret()
        {
            this._logger.name += " -GenerateTotpSecret";
            // Create new graphql operation generateTotpSecret
            InitMutationGenerateTotpSecret();
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
        // getHealthMonitorPolicyStatus.
        internal void ProcessRecord_GetHealthMonitorPolicyStatus()
        {
            this._logger.name += " -GetHealthMonitorPolicyStatus";
            // Create new graphql operation getHealthMonitorPolicyStatus
            InitMutationGetHealthMonitorPolicyStatus();
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
        // hideRevealNasShares.
        internal void ProcessRecord_HideRevealNasShares()
        {
            this._logger.name += " -HideRevealNasShares";
            // Create new graphql operation hideRevealNasShares
            InitMutationHideRevealNasShares();
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
        // modifyActiveDirectoryLiveMount.
        internal void ProcessRecord_ModifyActiveDirectoryLiveMount()
        {
            this._logger.name += " -ModifyActiveDirectoryLiveMount";
            // Create new graphql operation modifyActiveDirectoryLiveMount
            InitMutationModifyActiveDirectoryLiveMount();
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
        // mutateRole.
        internal void ProcessRecord_MutateRole()
        {
            this._logger.name += " -MutateRole";
            // Create new graphql operation mutateRole
            InitMutationMutateRole();
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
        // pauseTarget.
        internal void ProcessRecord_PauseTarget()
        {
            this._logger.name += " -PauseTarget";
            // Create new graphql operation pauseTarget
            InitMutationPauseTarget();
        }

        // This parameter set invokes a single graphql operation:
        // promoteReaderTarget.
        internal void ProcessRecord_PromoteReaderTarget()
        {
            this._logger.name += " -PromoteReaderTarget";
            // Create new graphql operation promoteReaderTarget
            InitMutationPromoteReaderTarget();
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
        // refreshNasSystems.
        internal void ProcessRecord_RefreshNasSystems()
        {
            this._logger.name += " -RefreshNasSystems";
            // Create new graphql operation refreshNasSystems
            InitMutationRefreshNasSystems();
        }

        // This parameter set invokes a single graphql operation:
        // refreshReaderTarget.
        internal void ProcessRecord_RefreshReaderTarget()
        {
            this._logger.name += " -RefreshReaderTarget";
            // Create new graphql operation refreshReaderTarget
            InitMutationRefreshReaderTarget();
        }

        // This parameter set invokes a single graphql operation:
        // registerNasSystem.
        internal void ProcessRecord_RegisterNasSystem()
        {
            this._logger.name += " -RegisterNasSystem";
            // Create new graphql operation registerNasSystem
            InitMutationRegisterNasSystem();
        }

        // This parameter set invokes a single graphql operation:
        // removeClusterNodes.
        internal void ProcessRecord_RemoveClusterNodes()
        {
            this._logger.name += " -RemoveClusterNodes";
            // Create new graphql operation removeClusterNodes
            InitMutationRemoveClusterNodes();
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
        // removePolicyObjects.
        internal void ProcessRecord_RemovePolicyObjects()
        {
            this._logger.name += " -RemovePolicyObjects";
            // Create new graphql operation removePolicyObjects
            InitMutationRemovePolicyObjects();
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
        // resolveVolumeGroupsConflict.
        internal void ProcessRecord_ResolveVolumeGroupsConflict()
        {
            this._logger.name += " -ResolveVolumeGroupsConflict";
            // Create new graphql operation resolveVolumeGroupsConflict
            InitMutationResolveVolumeGroupsConflict();
        }

        // This parameter set invokes a single graphql operation:
        // restoreActiveDirectoryObjects.
        internal void ProcessRecord_RestoreActiveDirectoryObjects()
        {
            this._logger.name += " -RestoreActiveDirectoryObjects";
            // Create new graphql operation restoreActiveDirectoryObjects
            InitMutationRestoreActiveDirectoryObjects();
        }

        // This parameter set invokes a single graphql operation:
        // resumeTarget.
        internal void ProcessRecord_ResumeTarget()
        {
            this._logger.name += " -ResumeTarget";
            // Create new graphql operation resumeTarget
            InitMutationResumeTarget();
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
        // setPasswordComplexityPolicy.
        internal void ProcessRecord_SetPasswordComplexityPolicy()
        {
            this._logger.name += " -SetPasswordComplexityPolicy";
            // Create new graphql operation setPasswordComplexityPolicy
            InitMutationSetPasswordComplexityPolicy();
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
        // supportPortalLogin.
        internal void ProcessRecord_SupportPortalLogin()
        {
            this._logger.name += " -SupportPortalLogin";
            // Create new graphql operation supportPortalLogin
            InitMutationSupportPortalLogin();
        }

        // This parameter set invokes a single graphql operation:
        // testSyslogExportRule.
        internal void ProcessRecord_TestSyslogExportRule()
        {
            this._logger.name += " -TestSyslogExportRule";
            // Create new graphql operation testSyslogExportRule
            InitMutationTestSyslogExportRule();
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
        // updateAuthDomainUsersHiddenStatus.
        internal void ProcessRecord_UpdateAuthDomainUsersHiddenStatus()
        {
            this._logger.name += " -UpdateAuthDomainUsersHiddenStatus";
            // Create new graphql operation updateAuthDomainUsersHiddenStatus
            InitMutationUpdateAuthDomainUsersHiddenStatus();
        }

        // This parameter set invokes a single graphql operation:
        // updateAutoEnablePolicyClusterConfig.
        internal void ProcessRecord_UpdateAutoEnablePolicyClusterConfig()
        {
            this._logger.name += " -UpdateAutoEnablePolicyClusterConfig";
            // Create new graphql operation updateAutoEnablePolicyClusterConfig
            InitMutationUpdateAutoEnablePolicyClusterConfig();
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
        // updateClusterDefaultAddress.
        internal void ProcessRecord_UpdateClusterDefaultAddress()
        {
            this._logger.name += " -UpdateClusterDefaultAddress";
            // Create new graphql operation updateClusterDefaultAddress
            InitMutationUpdateClusterDefaultAddress();
        }

        // This parameter set invokes a single graphql operation:
        // updateClusterLocation.
        internal void ProcessRecord_UpdateClusterLocation()
        {
            this._logger.name += " -UpdateClusterLocation";
            // Create new graphql operation updateClusterLocation
            InitMutationUpdateClusterLocation();
        }

        // This parameter set invokes a single graphql operation:
        // updateClusterNtpServers.
        internal void ProcessRecord_UpdateClusterNtpServers()
        {
            this._logger.name += " -UpdateClusterNtpServers";
            // Create new graphql operation updateClusterNtpServers
            InitMutationUpdateClusterNtpServers();
        }

        // This parameter set invokes a single graphql operation:
        // updateClusterSettings.
        internal void ProcessRecord_UpdateClusterSettings()
        {
            this._logger.name += " -UpdateClusterSettings";
            // Create new graphql operation updateClusterSettings
            InitMutationUpdateClusterSettings();
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
        // updateFailoverClusterApp.
        internal void ProcessRecord_UpdateFailoverClusterApp()
        {
            this._logger.name += " -UpdateFailoverClusterApp";
            // Create new graphql operation updateFailoverClusterApp
            InitMutationUpdateFailoverClusterApp();
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
        // updateGlacierTarget.
        internal void ProcessRecord_UpdateGlacierTarget()
        {
            this._logger.name += " -UpdateGlacierTarget";
            // Create new graphql operation updateGlacierTarget
            InitMutationUpdateGlacierTarget();
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
        // updateHealthMonitorPolicyStatus.
        internal void ProcessRecord_UpdateHealthMonitorPolicyStatus()
        {
            this._logger.name += " -UpdateHealthMonitorPolicyStatus";
            // Create new graphql operation updateHealthMonitorPolicyStatus
            InitMutationUpdateHealthMonitorPolicyStatus();
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
        // updateIntegration.
        internal void ProcessRecord_UpdateIntegration()
        {
            this._logger.name += " -UpdateIntegration";
            // Create new graphql operation updateIntegration
            InitMutationUpdateIntegration();
        }

        // This parameter set invokes a single graphql operation:
        // updateIntegrations.
        internal void ProcessRecord_UpdateIntegrations()
        {
            this._logger.name += " -UpdateIntegrations";
            // Create new graphql operation updateIntegrations
            InitMutationUpdateIntegrations();
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
        // updateManualTargetMapping.
        internal void ProcessRecord_UpdateManualTargetMapping()
        {
            this._logger.name += " -UpdateManualTargetMapping";
            // Create new graphql operation updateManualTargetMapping
            InitMutationUpdateManualTargetMapping();
        }

        // This parameter set invokes a single graphql operation:
        // updateNasShares.
        internal void ProcessRecord_UpdateNasShares()
        {
            this._logger.name += " -UpdateNasShares";
            // Create new graphql operation updateNasShares
            InitMutationUpdateNasShares();
        }

        // This parameter set invokes a single graphql operation:
        // updateNasSystem.
        internal void ProcessRecord_UpdateNasSystem()
        {
            this._logger.name += " -UpdateNasSystem";
            // Create new graphql operation updateNasSystem
            InitMutationUpdateNasSystem();
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
        // updateOrg.
        internal void ProcessRecord_UpdateOrg()
        {
            this._logger.name += " -UpdateOrg";
            // Create new graphql operation updateOrg
            InitMutationUpdateOrg();
        }

        // This parameter set invokes a single graphql operation:
        // updateOrgSecurityPolicy.
        internal void ProcessRecord_UpdateOrgSecurityPolicy()
        {
            this._logger.name += " -UpdateOrgSecurityPolicy";
            // Create new graphql operation updateOrgSecurityPolicy
            InitMutationUpdateOrgSecurityPolicy();
        }

        // This parameter set invokes a single graphql operation:
        // updatePolicy.
        internal void ProcessRecord_UpdatePolicy()
        {
            this._logger.name += " -UpdatePolicy";
            // Create new graphql operation updatePolicy
            InitMutationUpdatePolicy();
        }

        // This parameter set invokes a single graphql operation:
        // updatePreviewerClusterConfig.
        internal void ProcessRecord_UpdatePreviewerClusterConfig()
        {
            this._logger.name += " -UpdatePreviewerClusterConfig";
            // Create new graphql operation updatePreviewerClusterConfig
            InitMutationUpdatePreviewerClusterConfig();
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
        // updateRole.
        internal void ProcessRecord_UpdateRole()
        {
            this._logger.name += " -UpdateRole";
            // Create new graphql operation updateRole
            InitMutationUpdateRole();
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
        // updateS3CompatibleTarget.
        internal void ProcessRecord_UpdateS3CompatibleTarget()
        {
            this._logger.name += " -UpdateS3CompatibleTarget";
            // Create new graphql operation updateS3CompatibleTarget
            InitMutationUpdateS3CompatibleTarget();
        }

        // This parameter set invokes a single graphql operation:
        // updateSnmpConfig.
        internal void ProcessRecord_UpdateSnmpConfig()
        {
            this._logger.name += " -UpdateSnmpConfig";
            // Create new graphql operation updateSnmpConfig
            InitMutationUpdateSnmpConfig();
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
        // updateSyslogExportRule.
        internal void ProcessRecord_UpdateSyslogExportRule()
        {
            this._logger.name += " -UpdateSyslogExportRule";
            // Create new graphql operation updateSyslogExportRule
            InitMutationUpdateSyslogExportRule();
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
        // upgradeCdmManagedTarget.
        internal void ProcessRecord_UpgradeCdmManagedTarget()
        {
            this._logger.name += " -UpgradeCdmManagedTarget";
            // Create new graphql operation upgradeCdmManagedTarget
            InitMutationUpgradeCdmManagedTarget();
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
                Mutation.AddAdGroupsToHierarchy_ObjectFieldSpec,
                Mutation.AddAdGroupsToHierarchyFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	orgId = $someString
	# REQUIRED
	naturalIds = @(
		$someString
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // addClusterNodes(AddClusterNodesInput: AddClusterNodesInput!): AddClusterNodesReply!
        internal void InitMutationAddClusterNodes()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("AddClusterNodesInput", "AddClusterNodesInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationAddClusterNodes",
                "($AddClusterNodesInput: AddClusterNodesInput!)",
                "AddClusterNodesReply",
                Mutation.AddClusterNodes_ObjectFieldSpec,
                Mutation.AddClusterNodesFieldSpec,
                @"# REQUIRED
$query.Var.AddClusterNodesInput = @{
	# REQUIRED
	clusterUuid = $someString
	# REQUIRED
	nodesMap = @(
		@{
			# OPTIONAL
			key = $someString
			# REQUIRED
			value = @{
				# OPTIONAL
				dataIpConfig = @{
					# OPTIONAL
					vlan = $someInt
					# REQUIRED
					address = $someString
					# REQUIRED
					gateway = $someString
					# REQUIRED
					netmask = $someString
				}
				# REQUIRED
				ipmiIpConfig = @{
					# OPTIONAL
					vlan = $someInt
					# REQUIRED
					address = $someString
					# REQUIRED
					gateway = $someString
					# REQUIRED
					netmask = $someString
				}
				# REQUIRED
				managementIpConfig = @{
					# OPTIONAL
					vlan = $someInt
					# REQUIRED
					address = $someString
					# REQUIRED
					gateway = $someString
					# REQUIRED
					netmask = $someString
				}
				# OPTIONAL
				vlanIpConfigs = @(
					@{
						# REQUIRED
						ip = $someString
						# REQUIRED
						vlan = $someInt
					}
				)
			}
		}
	)
	# REQUIRED
	request = @{
		# OPTIONAL
		encryptionPassword = $someString
		# OPTIONAL
		isIpv4ManualDiscoveryMode = $someBoolean
		# OPTIONAL
		isLinkLocalIpv4Mode = $someBoolean
		# REQUIRED
		ipmiPassword = $someString
	}
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
                Mutation.AddConfiguredGroupToHierarchy_ObjectFieldSpec,
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
                Mutation.AddInventoryWorkloads_ObjectFieldSpec,
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
        // addPolicyObjects(
        //     policyIds: [String!]!
        //     objectIds: [String!]! = []
        //     objectRootIds: [String!]! = []
        //     clusterIds: [String!]! = []
        //   ): String!
        internal void InitMutationAddPolicyObjects()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("policyIds", "[String!]!"),
                Tuple.Create("objectIds", "[String!]!"),
                Tuple.Create("objectRootIds", "[String!]!"),
                Tuple.Create("clusterIds", "[String!]!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationAddPolicyObjects",
                "($policyIds: [String!]!,$objectIds: [String!]!,$objectRootIds: [String!]!,$clusterIds: [String!]!)",
                "System.String",
                Mutation.AddPolicyObjects_ObjectFieldSpec,
                Mutation.AddPolicyObjectsFieldSpec,
                @"# REQUIRED
$query.Var.policyIds = @(
	$someString
)
# REQUIRED
$query.Var.objectIds = @(
	$someString
)
# REQUIRED
$query.Var.objectRootIds = @(
	$someString
)
# REQUIRED
$query.Var.clusterIds = @(
	$someString
)"
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
                Mutation.AddRoleAssignments_ObjectFieldSpec,
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
        // addSyslogExportRule(input: AddSyslogExportRuleInput!): AddSyslogExportRuleReply!
        internal void InitMutationAddSyslogExportRule()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "AddSyslogExportRuleInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationAddSyslogExportRule",
                "($input: AddSyslogExportRuleInput!)",
                "AddSyslogExportRuleReply",
                Mutation.AddSyslogExportRule_ObjectFieldSpec,
                Mutation.AddSyslogExportRuleFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	syslogExportRuleV51 = @{
		# OPTIONAL
		syslogCertificateInfo = @{
			# OPTIONAL
			serverCertificate = $someString
			# OPTIONAL
			serverCertificateName = $someString
		}
		# OPTIONAL
		syslogExportRuleFull = @{
			# OPTIONAL
			certificateId = $someString
			# REQUIRED
			facility = $someSyslogFacility # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogFacility]) for enum values.
			# REQUIRED
			protocol = $someTransportLayerProtocol # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TransportLayerProtocol]) for enum values.
			# REQUIRED
			severity = $someSyslogSeverity # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogSeverity]) for enum values.
			# REQUIRED
			enableTls = $someBoolean
			# REQUIRED
			hostname = $someString
			# REQUIRED
			port = $someInt
		}
	}
	# OPTIONAL
	syslogExportRuleV52 = @{
		# OPTIONAL
		certificateId = $someString
		# REQUIRED
		facility = $someSyslogFacility # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogFacility]) for enum values.
		# REQUIRED
		protocol = $someTransportLayerProtocol # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TransportLayerProtocol]) for enum values.
		# REQUIRED
		severity = $someSyslogSeverity # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogSeverity]) for enum values.
		# REQUIRED
		enableTls = $someBoolean
		# REQUIRED
		hostname = $someString
		# REQUIRED
		port = $someInt
	}
	# OPTIONAL
	syslogExportRuleV53 = @{
		# OPTIONAL
		certificateId = $someString
		# REQUIRED
		facility = $someSyslogFacility # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogFacility]) for enum values.
		# REQUIRED
		protocol = $someTransportLayerProtocol # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TransportLayerProtocol]) for enum values.
		# REQUIRED
		severity = $someSyslogSeverity # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogSeverity]) for enum values.
		# REQUIRED
		enableTls = $someBoolean
		# REQUIRED
		hostname = $someString
		# REQUIRED
		port = $someInt
	}
	# OPTIONAL
	syslogExportRuleV60 = @{
		# OPTIONAL
		certificateId = $someString
		# REQUIRED
		facility = $someSyslogFacility # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogFacility]) for enum values.
		# REQUIRED
		protocol = $someTransportLayerProtocol # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TransportLayerProtocol]) for enum values.
		# REQUIRED
		severity = $someSyslogSeverity # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogSeverity]) for enum values.
		# REQUIRED
		enableTls = $someBoolean
		# REQUIRED
		hostname = $someString
		# REQUIRED
		port = $someInt
	}
	# OPTIONAL
	syslogExportRuleV70 = @{
		# OPTIONAL
		certificateId = $someString
		# REQUIRED
		facility = $someSyslogFacility # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogFacility]) for enum values.
		# REQUIRED
		protocol = $someTransportLayerProtocol # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TransportLayerProtocol]) for enum values.
		# REQUIRED
		severity = $someSyslogSeverity # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogSeverity]) for enum values.
		# REQUIRED
		enableTls = $someBoolean
		# REQUIRED
		hostname = $someString
		# REQUIRED
		port = $someInt
	}
	# OPTIONAL
	syslogExportRuleV80 = @{
		# OPTIONAL
		certificateId = $someString
		# REQUIRED
		facility = $someSyslogFacility # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogFacility]) for enum values.
		# REQUIRED
		protocol = $someTransportLayerProtocol # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TransportLayerProtocol]) for enum values.
		# REQUIRED
		severity = $someSyslogSeverity # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogSeverity]) for enum values.
		# REQUIRED
		enableTls = $someBoolean
		# REQUIRED
		hostname = $someString
		# REQUIRED
		port = $someInt
	}
	# OPTIONAL
	syslogExportRuleV81 = @{
		# OPTIONAL
		certificateId = $someString
		# REQUIRED
		facility = $someSyslogFacility # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogFacility]) for enum values.
		# REQUIRED
		protocol = $someTransportLayerProtocol # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TransportLayerProtocol]) for enum values.
		# REQUIRED
		severity = $someSyslogSeverity # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogSeverity]) for enum values.
		# REQUIRED
		enableTls = $someBoolean
		# REQUIRED
		hostname = $someString
		# REQUIRED
		port = $someInt
	}
	# OPTIONAL
	syslogExportRuleV90 = @{
		# OPTIONAL
		certificateId = $someString
		# REQUIRED
		facility = $someSyslogFacility # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogFacility]) for enum values.
		# REQUIRED
		protocol = $someTransportLayerProtocol # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TransportLayerProtocol]) for enum values.
		# REQUIRED
		severity = $someSyslogSeverity # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogSeverity]) for enum values.
		# REQUIRED
		enableTls = $someBoolean
		# REQUIRED
		hostname = $someString
		# REQUIRED
		port = $someInt
	}
	# OPTIONAL
	syslogExportRuleV91 = @{
		# OPTIONAL
		certificateId = $someString
		# REQUIRED
		facility = $someSyslogFacility # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogFacility]) for enum values.
		# REQUIRED
		protocol = $someTransportLayerProtocol # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TransportLayerProtocol]) for enum values.
		# REQUIRED
		severity = $someSyslogSeverity # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogSeverity]) for enum values.
		# REQUIRED
		enableTls = $someBoolean
		# REQUIRED
		hostname = $someString
		# REQUIRED
		port = $someInt
	}
	# REQUIRED
	clusterUuid = $someString
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
                Mutation.AddVlan_ObjectFieldSpec,
                Mutation.AddVlanFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someString
	# REQUIRED
	vlanInfo = @{
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
                Mutation.AddVmAppConsistentSpecs_ObjectFieldSpec,
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
                Mutation.ArchiveCrawl_ObjectFieldSpec,
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
                Mutation.AssignProtection_ObjectFieldSpec,
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
                Mutation.BatchDeassignRoleFromUserGroups_ObjectFieldSpec,
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
                Mutation.BulkCreateNasFilesets_ObjectFieldSpec,
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
			filesetOptions = @{
				# OPTIONAL
				allowBackupHiddenFoldersInNetworkMounts = $someBoolean
				# OPTIONAL
				allowBackupNetworkMounts = $someBoolean
				# OPTIONAL
				useWindowsVss = $someBoolean
			}
			# OPTIONAL
			operatingSystemType = $someFilesetTemplateCreateOperatingSystemType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.FilesetTemplateCreateOperatingSystemType]) for enum values.
			# OPTIONAL
			shareType = $someFilesetTemplateCreateShareType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.FilesetTemplateCreateShareType]) for enum values.
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
        // bulkDeleteFailoverClusterApp(input: BulkDeleteFailoverClusterAppInput!): ResponseSuccess!
        internal void InitMutationBulkDeleteFailoverClusterApp()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "BulkDeleteFailoverClusterAppInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationBulkDeleteFailoverClusterApp",
                "($input: BulkDeleteFailoverClusterAppInput!)",
                "ResponseSuccess",
                Mutation.BulkDeleteFailoverClusterApp_ObjectFieldSpec,
                Mutation.BulkDeleteFailoverClusterAppFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	preserveSnapshots = $someBoolean
	# REQUIRED
	ids = @(
		$someString
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // bulkDeleteNasSystems(input: BulkDeleteNasSystemsInput!): BatchAsyncRequestStatus!
        internal void InitMutationBulkDeleteNasSystems()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "BulkDeleteNasSystemsInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationBulkDeleteNasSystems",
                "($input: BulkDeleteNasSystemsInput!)",
                "BatchAsyncRequestStatus",
                Mutation.BulkDeleteNasSystems_ObjectFieldSpec,
                Mutation.BulkDeleteNasSystemsFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	bulkDeleteNasSystemRequest = @{
		# REQUIRED
		ids = @(
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
                Mutation.CancelDownloadPackage_ObjectFieldSpec,
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
                Mutation.CancelScheduledUpgrade_ObjectFieldSpec,
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
                Mutation.CancelTaskchain_ObjectFieldSpec,
                Mutation.CancelTaskchainFieldSpec,
                @"# REQUIRED
$query.Var.taskchainId = $someString"
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
                Mutation.ChangePassword_ObjectFieldSpec,
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
        // createActiveDirectoryLiveMount(input: CreateActiveDirectoryLiveMountInput!): AsyncRequestStatus!
        internal void InitMutationCreateActiveDirectoryLiveMount()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateActiveDirectoryLiveMountInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateActiveDirectoryLiveMount",
                "($input: CreateActiveDirectoryLiveMountInput!)",
                "AsyncRequestStatus",
                Mutation.CreateActiveDirectoryLiveMount_ObjectFieldSpec,
                Mutation.CreateActiveDirectoryLiveMountFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	config = @{
		# OPTIONAL
		validUsers = @(
			$someString
		)
		# OPTIONAL
		validIps = @(
			$someString
		)
		# OPTIONAL
		password = $someString
		# OPTIONAL
		domainName = $someString
		# OPTIONAL
		subnet = $someString
	}
	# REQUIRED
	id = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // createActiveDirectoryUnmount(input: CreateActiveDirectoryUnmountInput!): AsyncRequestStatus!
        internal void InitMutationCreateActiveDirectoryUnmount()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateActiveDirectoryUnmountInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateActiveDirectoryUnmount",
                "($input: CreateActiveDirectoryUnmountInput!)",
                "AsyncRequestStatus",
                Mutation.CreateActiveDirectoryUnmount_ObjectFieldSpec,
                Mutation.CreateActiveDirectoryUnmountFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someString
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
                Mutation.CreateCustomAnalyzer_ObjectFieldSpec,
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
	risk = $someRiskLevelType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RiskLevelType]) for enum values.
}"
            );
        }

        // Create new GraphQL Mutation:
        // createFailoverClusterApp(input: CreateFailoverClusterAppInput!): CreateFailoverClusterAppReply!
        internal void InitMutationCreateFailoverClusterApp()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateFailoverClusterAppInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateFailoverClusterApp",
                "($input: CreateFailoverClusterAppInput!)",
                "CreateFailoverClusterAppReply",
                Mutation.CreateFailoverClusterApp_ObjectFieldSpec,
                Mutation.CreateFailoverClusterAppFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	config = @{
		# OPTIONAL
		configuredSlaDomainId = $someString
		# REQUIRED
		failoverClusterType = $someFailoverClusterType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.FailoverClusterType]) for enum values.
		# REQUIRED
		failoverClusterAppSource = @{
			# OPTIONAL
			nodeOrders = @(
				@{
					# OPTIONAL
					nodeName = $someString
					# REQUIRED
					nodeId = $someString
					# REQUIRED
					order = $someInt
				}
			)
			# OPTIONAL
			virtualIps = @(
				$someString
			)
			# OPTIONAL
			vips = @(
				$someString
			)
		}
		# REQUIRED
		failoverClusterId = $someString
		# REQUIRED
		name = $someString
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // createGlacierReaderTarget(input: CreateGlacierReaderTargetInput!): Target!
        internal void InitMutationCreateGlacierReaderTarget()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateGlacierReaderTargetInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateGlacierReaderTarget",
                "($input: CreateGlacierReaderTargetInput!)",
                "Target",
                Mutation.CreateGlacierReaderTarget_ObjectFieldSpec,
                Mutation.CreateGlacierReaderTargetFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	name = $someString
	# REQUIRED
	cloudAccountId = $someString
	# REQUIRED
	vaultName = $someString
	# REQUIRED
	region = $someAwsRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsRegion]) for enum values.
	# OPTIONAL
	encryptionPassword = $someString
	# REQUIRED
	clusterUuid = $someString
	# OPTIONAL
	retrievalTier = $someAwsRetrievalTier # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsRetrievalTier]) for enum values.
	# REQUIRED
	readerRetrievalMethod = $someReaderRetrievalMethod # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ReaderRetrievalMethod]) for enum values.
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
                Mutation.CreateGuestCredential_ObjectFieldSpec,
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
        // createIntegration(input: CreateIntegrationInput!): CreateIntegrationReply!
        internal void InitMutationCreateIntegration()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateIntegrationInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateIntegration",
                "($input: CreateIntegrationInput!)",
                "CreateIntegrationReply",
                Mutation.CreateIntegration_ObjectFieldSpec,
                Mutation.CreateIntegrationFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	name = $someString
	# REQUIRED
	integrationType = $someIntegrationType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.IntegrationType]) for enum values.
	# REQUIRED
	config = @{
		# OPTIONAL
		dataLossPrevention = @{
			# OPTIONAL
			policies = @(
				$someString
			)
			# OPTIONAL
			genericNas = @{
				# REQUIRED
				workloadId = $someString
				# REQUIRED
				shareType = $someDlpConfigShareType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DlpConfigShareType]) for enum values.
				# REQUIRED
				shareId = $someString
				# REQUIRED
				path = $someString
			}
			# OPTIONAL
			vmwareVm = @{
				# REQUIRED
				workloadId = $someString
				# REQUIRED
				osType = $someDlpConfigOsType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DlpConfigOsType]) for enum values.
				# REQUIRED
				path = $someString
			}
			# OPTIONAL
			serviceAccountId = $someString
			# OPTIONAL
			serviceAccountName = $someString
			# OPTIONAL
			status = @{
				# OPTIONAL
				code = $someDlpStatusCode # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DlpStatusCode]) for enum values.
			}
			# REQUIRED
			targetType = $someDlpConfigTargetType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DlpConfigTargetType]) for enum values.
		}
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // createIntegrations(input: CreateIntegrationsInput!): CreateIntegrationsReply!
        internal void InitMutationCreateIntegrations()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateIntegrationsInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateIntegrations",
                "($input: CreateIntegrationsInput!)",
                "CreateIntegrationsReply",
                Mutation.CreateIntegrations_ObjectFieldSpec,
                Mutation.CreateIntegrationsFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	integrations = @(
		@{
			# REQUIRED
			name = $someString
			# REQUIRED
			integrationType = $someIntegrationType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.IntegrationType]) for enum values.
			# REQUIRED
			config = @{
				# OPTIONAL
				dataLossPrevention = @{
					# OPTIONAL
					policies = @(
						$someString
					)
					# OPTIONAL
					genericNas = @{
						# REQUIRED
						workloadId = $someString
						# REQUIRED
						shareType = $someDlpConfigShareType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DlpConfigShareType]) for enum values.
						# REQUIRED
						shareId = $someString
						# REQUIRED
						path = $someString
					}
					# OPTIONAL
					vmwareVm = @{
						# REQUIRED
						workloadId = $someString
						# REQUIRED
						osType = $someDlpConfigOsType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DlpConfigOsType]) for enum values.
						# REQUIRED
						path = $someString
					}
					# OPTIONAL
					serviceAccountId = $someString
					# OPTIONAL
					serviceAccountName = $someString
					# OPTIONAL
					status = @{
						# OPTIONAL
						code = $someDlpStatusCode # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DlpStatusCode]) for enum values.
					}
					# REQUIRED
					targetType = $someDlpConfigTargetType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DlpConfigTargetType]) for enum values.
				}
			}
		}
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // createManualTargetMapping(input: CreateManualTargetMappingInput!): TargetMapping!
        internal void InitMutationCreateManualTargetMapping()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateManualTargetMappingInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateManualTargetMapping",
                "($input: CreateManualTargetMappingInput!)",
                "TargetMapping",
                Mutation.CreateManualTargetMapping_ObjectFieldSpec,
                Mutation.CreateManualTargetMappingFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	name = $someString
	# OPTIONAL
	type = $someTargetType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TargetType]) for enum values.
	# OPTIONAL
	archivalLocationClusterMappings = @(
		@{
			# OPTIONAL
			locationId = $someString
			# OPTIONAL
			clusterUuid = $someString
		}
	)
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
                Mutation.CreateOnDemandVolumeGroupBackup_ObjectFieldSpec,
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
        // createOrg(input: CreateOrgInput!): CreateOrgReply!
        internal void InitMutationCreateOrg()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateOrgInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateOrg",
                "($input: CreateOrgInput!)",
                "CreateOrgReply",
                Mutation.CreateOrg_ObjectFieldSpec,
                Mutation.CreateOrgFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	name = $someString
	# REQUIRED
	fullName = $someString
	# REQUIRED
	description = $someString
	# REQUIRED
	authDomainConfig = $someTenantAuthDomainConfig # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TenantAuthDomainConfig]) for enum values.
	# REQUIRED
	shouldEnforceMfaForAll = $someBoolean
	# REQUIRED
	isEnvoyRequired = $someBoolean
	# REQUIRED
	allowedClusters = @(
		$someString
	)
	# OPTIONAL
	existingUsers = @(
		@{
			# REQUIRED
			id = $someString
			# REQUIRED
			isOrgAdmin = $someBoolean
		}
	)
	# OPTIONAL
	userInvites = @(
		@{
			# REQUIRED
			email = $someString
			# REQUIRED
			note = $someString
			# REQUIRED
			isOrgAdmin = $someBoolean
		}
	)
	# REQUIRED
	permissions = @(
		@{
			# REQUIRED
			operation = $someOperation # Call [Enum]::GetValues([RubrikSecurityCloud.Types.Operation]) for enum values.
			# REQUIRED
			objectsForHierarchyTypes = @(
				@{
					# REQUIRED
					objectIds = @(
						$someString
					)
					# REQUIRED
					snappableType = $someWorkloadLevelHierarchy # Call [Enum]::GetValues([RubrikSecurityCloud.Types.WorkloadLevelHierarchy]) for enum values.
				}
			)
		}
	)
	# REQUIRED
	selfServicePermissions = @(
		@{
			# OPTIONAL
			inventoryRoot = $someInventorySubHierarchyRootEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.InventorySubHierarchyRootEnum]) for enum values.
			# REQUIRED
			inventoryWorkloadType = $someWorkloadLevelHierarchy # Call [Enum]::GetValues([RubrikSecurityCloud.Types.WorkloadLevelHierarchy]) for enum values.
			# REQUIRED
			operations = @(
				$someOperation # Call [Enum]::GetValues([RubrikSecurityCloud.Types.Operation]) for enum values.
			)
			# OPTIONAL
			hierarchyRoot = $someString
		}
	)
	# OPTIONAL
	existingSsoGroups = @(
		@{
			# REQUIRED
			id = $someString
			# REQUIRED
			isOrgAdmin = $someBoolean
		}
	)
	# OPTIONAL
	newSsoGroups = @(
		@{
			# REQUIRED
			name = $someString
			# REQUIRED
			isOrgAdmin = $someBoolean
		}
	)
	# OPTIONAL
	isServiceAccountEnabled = $someBoolean
	# OPTIONAL
	crossAccountCapabilities = @(
		$someCrossAccountCapability # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CrossAccountCapability]) for enum values.
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // createOrgSwitchSession(input: CreateOrgSwitchSessionInput!): CreateOrgSwitchSessionReply!
        internal void InitMutationCreateOrgSwitchSession()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateOrgSwitchSessionInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateOrgSwitchSession",
                "($input: CreateOrgSwitchSessionInput!)",
                "CreateOrgSwitchSessionReply",
                Mutation.CreateOrgSwitchSession_ObjectFieldSpec,
                Mutation.CreateOrgSwitchSessionFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	orgId = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // createPolicy(input: CreatePolicyInput!): ClassificationPolicyDetail!
        internal void InitMutationCreatePolicy()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreatePolicyInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreatePolicy",
                "($input: CreatePolicyInput!)",
                "ClassificationPolicyDetail",
                Mutation.CreatePolicy_ObjectFieldSpec,
                Mutation.CreatePolicyFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	id = $someString
	# OPTIONAL
	name = $someString
	# OPTIONAL
	description = $someString
	# OPTIONAL
	colorEnum = $someClassificationPolicyColor # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ClassificationPolicyColor]) for enum values.
	# OPTIONAL
	mode = $someClassificationPolicyMode # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ClassificationPolicyMode]) for enum values.
	# OPTIONAL
	analyzerIds = @(
		$someString
	)
	# OPTIONAL
	updateName = $someBoolean
	# OPTIONAL
	updateDescription = $someBoolean
	# OPTIONAL
	updateMode = $someBoolean
	# OPTIONAL
	updateAnalyzerIds = $someBoolean
}"
            );
        }

        // Create new GraphQL Mutation:
        // createRole(name: String!, description: String!, permissions: [PermissionInput!]!): UUID!
        internal void InitMutationCreateRole()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("name", "String!"),
                Tuple.Create("description", "String!"),
                Tuple.Create("permissions", "[PermissionInput!]!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateRole",
                "($name: String!,$description: String!,$permissions: [PermissionInput!]!)",
                "System.String",
                Mutation.CreateRole_ObjectFieldSpec,
                Mutation.CreateRoleFieldSpec,
                @"# REQUIRED
$query.Var.name = $someString
# REQUIRED
$query.Var.description = $someString
# REQUIRED
$query.Var.permissions = @(
	@{
		# REQUIRED
		operation = $someOperation # Call [Enum]::GetValues([RubrikSecurityCloud.Types.Operation]) for enum values.
		# REQUIRED
		objectsForHierarchyTypes = @(
			@{
				# REQUIRED
				objectIds = @(
					$someString
				)
				# REQUIRED
				snappableType = $someWorkloadLevelHierarchy # Call [Enum]::GetValues([RubrikSecurityCloud.Types.WorkloadLevelHierarchy]) for enum values.
			}
		)
}
)"
            );
        }

        // Create new GraphQL Mutation:
        // createS3CompatibleReaderTarget(input: CreateS3CompatibleReaderTargetInput!): Target!
        internal void InitMutationCreateS3CompatibleReaderTarget()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateS3CompatibleReaderTargetInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateS3CompatibleReaderTarget",
                "($input: CreateS3CompatibleReaderTargetInput!)",
                "Target",
                Mutation.CreateS3CompatibleReaderTarget_ObjectFieldSpec,
                Mutation.CreateS3CompatibleReaderTargetFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	clusterUuid = $someString
	# REQUIRED
	name = $someString
	# REQUIRED
	accessKey = $someString
	# REQUIRED
	secretKey = $someString
	# REQUIRED
	endpoint = $someString
	# REQUIRED
	bucketPrefix = $someString
	# REQUIRED
	numberOfBuckets = $someInt
	# REQUIRED
	encryptionKeyInDer = $someString
	# REQUIRED
	isConsolidationEnabled = $someBoolean
	# REQUIRED
	useSystemProxy = $someBoolean
	# REQUIRED
	readerRetrievalMethod = $someReaderRetrievalMethod # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ReaderRetrievalMethod]) for enum values.
	# OPTIONAL
	subType = $someS3CompatibleSubType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.S3CompatibleSubType]) for enum values.
	# OPTIONAL
	encryptionPassword = $someString
	# OPTIONAL
	immutabilitySettings = @{
		# OPTIONAL
		bucketLockDurationDays = $someInt
	}
	# OPTIONAL
	ibmDetails = @{
		# OPTIONAL
		provisioningCode = $someString
		# OPTIONAL
		deploymentType = $someIbmDeploymentType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.IbmDeploymentType]) for enum values.
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // createS3CompatibleTarget(input: CreateS3CompatibleTargetInput!): Target!
        internal void InitMutationCreateS3CompatibleTarget()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateS3CompatibleTargetInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateS3CompatibleTarget",
                "($input: CreateS3CompatibleTargetInput!)",
                "Target",
                Mutation.CreateS3CompatibleTarget_ObjectFieldSpec,
                Mutation.CreateS3CompatibleTargetFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	clusterUuid = $someString
	# REQUIRED
	name = $someString
	# REQUIRED
	accessKey = $someString
	# REQUIRED
	secretKey = $someString
	# REQUIRED
	endpoint = $someString
	# REQUIRED
	bucketPrefix = $someString
	# REQUIRED
	numberOfBuckets = $someInt
	# REQUIRED
	encryptionKeyInDer = $someString
	# REQUIRED
	isConsolidationEnabled = $someBoolean
	# REQUIRED
	useSystemProxy = $someBoolean
	# OPTIONAL
	subType = $someS3CompatibleSubType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.S3CompatibleSubType]) for enum values.
	# OPTIONAL
	encryptionPassword = $someString
	# OPTIONAL
	immutabilitySettings = @{
		# OPTIONAL
		bucketLockDurationDays = $someInt
	}
	# OPTIONAL
	ibmDetails = @{
		# OPTIONAL
		provisioningCode = $someString
		# OPTIONAL
		deploymentType = $someIbmDeploymentType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.IbmDeploymentType]) for enum values.
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // createUser(email: String!, roleIds: [String!]!): String!
        internal void InitMutationCreateUser()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("email", "String!"),
                Tuple.Create("roleIds", "[String!]!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateUser",
                "($email: String!,$roleIds: [String!]!)",
                "System.String",
                Mutation.CreateUser_ObjectFieldSpec,
                Mutation.CreateUserFieldSpec,
                @"# REQUIRED
$query.Var.email = $someString
# REQUIRED
$query.Var.roleIds = @(
	$someString
)"
            );
        }

        // Create new GraphQL Mutation:
        // createUserWithPassword(input: CreateUserWithPasswordInput!): String!
        internal void InitMutationCreateUserWithPassword()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateUserWithPasswordInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateUserWithPassword",
                "($input: CreateUserWithPasswordInput!)",
                "System.String",
                Mutation.CreateUserWithPassword_ObjectFieldSpec,
                Mutation.CreateUserWithPasswordFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	email = $someString
	# OPTIONAL
	password = $someString
	# OPTIONAL
	roleIds = @(
		$someString
	)
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
                Mutation.CreateVappsInstantRecovery_ObjectFieldSpec,
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
                Mutation.DeactivateCustomAnalyzer_ObjectFieldSpec,
                Mutation.DeactivateCustomAnalyzerFieldSpec,
                @"# REQUIRED
$query.Var.analyzerId = $someString"
            );
        }

        // Create new GraphQL Mutation:
        // deactivatePolicy(policyId: String!, runAsync: Boolean!): [String!]!
        internal void InitMutationDeactivatePolicy()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("policyId", "String!"),
                Tuple.Create("runAsync", "Boolean!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDeactivatePolicy",
                "($policyId: String!,$runAsync: Boolean!)",
                "List<System.String>",
                Mutation.DeactivatePolicy_ObjectFieldSpec,
                Mutation.DeactivatePolicyFieldSpec,
                @"# REQUIRED
$query.Var.policyId = $someString
# REQUIRED
$query.Var.runAsync = $someBoolean"
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
                Mutation.DeleteAdGroupsFromHierarchy_ObjectFieldSpec,
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
        // deleteCsr(input: DeleteCsrInput!): Void
        internal void InitMutationDeleteCsr()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteCsrInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDeleteCsr",
                "($input: DeleteCsrInput!)",
                "System.String",
                Mutation.DeleteCsr_ObjectFieldSpec,
                Mutation.DeleteCsrFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	csrFids = @(
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
                Mutation.DeleteDistributionListDigestBatch_ObjectFieldSpec,
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
                Mutation.DeleteEventDigest_ObjectFieldSpec,
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
        // deleteFailoverClusterApp(input: DeleteFailoverClusterAppInput!): ResponseSuccess!
        internal void InitMutationDeleteFailoverClusterApp()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteFailoverClusterAppInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDeleteFailoverClusterApp",
                "($input: DeleteFailoverClusterAppInput!)",
                "ResponseSuccess",
                Mutation.DeleteFailoverClusterApp_ObjectFieldSpec,
                Mutation.DeleteFailoverClusterAppFieldSpec,
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
                Mutation.DeleteGuestCredentialById_ObjectFieldSpec,
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
        // deleteIntegration(input: DeleteIntegrationInput!): Void
        internal void InitMutationDeleteIntegration()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteIntegrationInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDeleteIntegration",
                "($input: DeleteIntegrationInput!)",
                "System.String",
                Mutation.DeleteIntegration_ObjectFieldSpec,
                Mutation.DeleteIntegrationFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someInt64
}"
            );
        }

        // Create new GraphQL Mutation:
        // deleteIntegrations(input: DeleteIntegrationsInput!): Void
        internal void InitMutationDeleteIntegrations()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteIntegrationsInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDeleteIntegrations",
                "($input: DeleteIntegrationsInput!)",
                "System.String",
                Mutation.DeleteIntegrations_ObjectFieldSpec,
                Mutation.DeleteIntegrationsFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	ids = @(
		$someInt64
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // deleteLogShipping(input: DeleteLogShippingInput!): AsyncRequestStatus!
        internal void InitMutationDeleteLogShipping()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteLogShippingInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDeleteLogShipping",
                "($input: DeleteLogShippingInput!)",
                "AsyncRequestStatus",
                Mutation.DeleteLogShipping_ObjectFieldSpec,
                Mutation.DeleteLogShippingFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	deleteSecondaryDatabase = $someBoolean
	# REQUIRED
	id = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // deleteNasSystem(input: DeleteNasSystemInput!): AsyncRequestStatus!
        internal void InitMutationDeleteNasSystem()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteNasSystemInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDeleteNasSystem",
                "($input: DeleteNasSystemInput!)",
                "AsyncRequestStatus",
                Mutation.DeleteNasSystem_ObjectFieldSpec,
                Mutation.DeleteNasSystemFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // deleteOrg(input: DeleteOrgInput!): Boolean!
        internal void InitMutationDeleteOrg()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteOrgInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDeleteOrg",
                "($input: DeleteOrgInput!)",
                "System.Boolean",
                Mutation.DeleteOrg_ObjectFieldSpec,
                Mutation.DeleteOrgFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	organizationId = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // deleteRole(roleId: String!): Boolean!
        internal void InitMutationDeleteRole()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("roleId", "String!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDeleteRole",
                "($roleId: String!)",
                "System.Boolean",
                Mutation.DeleteRole_ObjectFieldSpec,
                Mutation.DeleteRoleFieldSpec,
                @"# REQUIRED
$query.Var.roleId = $someString"
            );
        }

        // Create new GraphQL Mutation:
        // deleteSyslogExportRule(input: DeleteSyslogExportRuleInput!): Void
        internal void InitMutationDeleteSyslogExportRule()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteSyslogExportRuleInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDeleteSyslogExportRule",
                "($input: DeleteSyslogExportRuleInput!)",
                "System.String",
                Mutation.DeleteSyslogExportRule_ObjectFieldSpec,
                Mutation.DeleteSyslogExportRuleFieldSpec,
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
        // deleteTarget(input: DeleteTargetInput!): Void
        internal void InitMutationDeleteTarget()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteTargetInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDeleteTarget",
                "($input: DeleteTargetInput!)",
                "System.String",
                Mutation.DeleteTarget_ObjectFieldSpec,
                Mutation.DeleteTargetFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	id = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // deleteTargetMapping(input: DeleteTargetMappingInput!): Void
        internal void InitMutationDeleteTargetMapping()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteTargetMappingInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDeleteTargetMapping",
                "($input: DeleteTargetMappingInput!)",
                "System.String",
                Mutation.DeleteTargetMapping_ObjectFieldSpec,
                Mutation.DeleteTargetMappingFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	id = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // deleteTotpConfig(userId: String!): Boolean!
        internal void InitMutationDeleteTotpConfig()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("userId", "String!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDeleteTotpConfig",
                "($userId: String!)",
                "System.Boolean",
                Mutation.DeleteTotpConfig_ObjectFieldSpec,
                Mutation.DeleteTotpConfigFieldSpec,
                @"# REQUIRED
$query.Var.userId = $someString"
            );
        }

        // Create new GraphQL Mutation:
        // deleteTotpConfigs(input: DeleteTotpConfigsInput!): Boolean!
        internal void InitMutationDeleteTotpConfigs()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteTotpConfigsInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDeleteTotpConfigs",
                "($input: DeleteTotpConfigsInput!)",
                "System.Boolean",
                Mutation.DeleteTotpConfigs_ObjectFieldSpec,
                Mutation.DeleteTotpConfigsFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	userIds = @(
		$someString
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
                Mutation.DeleteVolumeGroupMount_ObjectFieldSpec,
                Mutation.DeleteVolumeGroupMountFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someString
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
                Mutation.DisableSupportUserAccess_ObjectFieldSpec,
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
        // disableTarget(input: DisableTargetInput!): DisableTargetReply!
        internal void InitMutationDisableTarget()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DisableTargetInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDisableTarget",
                "($input: DisableTargetInput!)",
                "DisableTargetReply",
                Mutation.DisableTarget_ObjectFieldSpec,
                Mutation.DisableTargetFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	id = $someString
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
                Mutation.EnableAutomaticFmdUpload_ObjectFieldSpec,
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
                Mutation.EnableDisableAppConsistency_ObjectFieldSpec,
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
                Mutation.EnableSupportUserAccess_ObjectFieldSpec,
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
        // enableTarget(input: EnableTargetInput!): EnableTargetReply!
        internal void InitMutationEnableTarget()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "EnableTargetInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationEnableTarget",
                "($input: EnableTargetInput!)",
                "EnableTargetReply",
                Mutation.EnableTarget_ObjectFieldSpec,
                Mutation.EnableTargetFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	id = $someString
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
                Mutation.ExcludeVmDisks_ObjectFieldSpec,
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
        // generateClusterRegistrationToken(input: GenerateClusterRegistrationTokenInput): ClusterRegistrationToken!
        internal void InitMutationGenerateClusterRegistrationToken()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GenerateClusterRegistrationTokenInput"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationGenerateClusterRegistrationToken",
                "($input: GenerateClusterRegistrationTokenInput)",
                "ClusterRegistrationToken",
                Mutation.GenerateClusterRegistrationToken_ObjectFieldSpec,
                Mutation.GenerateClusterRegistrationTokenFieldSpec,
                @"# OPTIONAL
$query.Var.input = @{
	# OPTIONAL
	managedByPolaris = $someBoolean
	# OPTIONAL
	nodeConfigs = @(
		@{
			# OPTIONAL
			id = $someString
			# OPTIONAL
			manufactureTime = $someDateTime
			# OPTIONAL
			serial = $someString
			# OPTIONAL
			systemUuid = $someString
			# OPTIONAL
			teleportToken = $someString
			# OPTIONAL
			clusterUuid = $someString
			# OPTIONAL
			platform = $someString
			# OPTIONAL
			capacity = $someString
			# OPTIONAL
			isEntitled = $someBoolean
		}
	)
	# OPTIONAL
	isOfflineRegistration = $someBoolean
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
                Mutation.GenerateConfigProtectionRestoreForm_ObjectFieldSpec,
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
        // generateCsr(
        //     name: String!
        //     hostnames: [String!]!
        //     organization: String
        //     organizationUnit: String
        //     country: String
        //     state: String
        //     city: String
        //     email: String
        //     surname: String
        //     userId: String
        //   ): Csr!
        internal void InitMutationGenerateCsr()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("name", "String!"),
                Tuple.Create("hostnames", "[String!]!"),
                Tuple.Create("organization", "String"),
                Tuple.Create("organizationUnit", "String"),
                Tuple.Create("country", "String"),
                Tuple.Create("state", "String"),
                Tuple.Create("city", "String"),
                Tuple.Create("email", "String"),
                Tuple.Create("surname", "String"),
                Tuple.Create("userId", "String"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationGenerateCsr",
                "($name: String!,$hostnames: [String!]!,$organization: String,$organizationUnit: String,$country: String,$state: String,$city: String,$email: String,$surname: String,$userId: String)",
                "Csr",
                Mutation.GenerateCsr_ObjectFieldSpec,
                Mutation.GenerateCsrFieldSpec,
                @"# REQUIRED
$query.Var.name = $someString
# REQUIRED
$query.Var.hostnames = @(
	$someString
)
# OPTIONAL
$query.Var.organization = $someString
# OPTIONAL
$query.Var.organizationUnit = $someString
# OPTIONAL
$query.Var.country = $someString
# OPTIONAL
$query.Var.state = $someString
# OPTIONAL
$query.Var.city = $someString
# OPTIONAL
$query.Var.email = $someString
# OPTIONAL
$query.Var.surname = $someString
# OPTIONAL
$query.Var.userId = $someString"
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
                Mutation.GenerateSupportBundle_ObjectFieldSpec,
                Mutation.GenerateSupportBundleFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	definitions = @{
		# OPTIONAL
		eventId = $someString
		# OPTIONAL
		requestIds = @(
			$someString
		)
	}
	# REQUIRED
	clusterUuid = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // generateTotpSecret(userId: String!): GenerateTotpSecretReply!
        internal void InitMutationGenerateTotpSecret()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("userId", "String!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationGenerateTotpSecret",
                "($userId: String!)",
                "GenerateTotpSecretReply",
                Mutation.GenerateTotpSecret_ObjectFieldSpec,
                Mutation.GenerateTotpSecretFieldSpec,
                @"# REQUIRED
$query.Var.userId = $someString"
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
                Mutation.GetDownloadUrl_ObjectFieldSpec,
                Mutation.GetDownloadUrlFieldSpec,
                @"# REQUIRED
$query.Var.downloadId = $someInt64"
            );
        }

        // Create new GraphQL Mutation:
        // getHealthMonitorPolicyStatus(input: GetHealthMonitorPolicyStatusInput!): GetHealthMonitorPolicyStatusReply!
        internal void InitMutationGetHealthMonitorPolicyStatus()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetHealthMonitorPolicyStatusInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationGetHealthMonitorPolicyStatus",
                "($input: GetHealthMonitorPolicyStatusInput!)",
                "GetHealthMonitorPolicyStatusReply",
                Mutation.GetHealthMonitorPolicyStatus_ObjectFieldSpec,
                Mutation.GetHealthMonitorPolicyStatusFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	hasDetailedStatus = $someBoolean
	# OPTIONAL
	nodeIds = @(
		$someString
	)
	# OPTIONAL
	policyIds = @(
		$someString
	)
	# REQUIRED
	clusterUuid = $someString
}"
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
                Mutation.HideRevealNasNamespaces_ObjectFieldSpec,
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
        // hideRevealNasShares(input: HideRevealNasSharesInput!): ResponseSuccess!
        internal void InitMutationHideRevealNasShares()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "HideRevealNasSharesInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationHideRevealNasShares",
                "($input: HideRevealNasSharesInput!)",
                "ResponseSuccess",
                Mutation.HideRevealNasShares_ObjectFieldSpec,
                Mutation.HideRevealNasSharesFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	hideNasSharesRequest = @{
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
                Mutation.InstallIoFilter_ObjectFieldSpec,
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
                Mutation.InviteSsoGroup_ObjectFieldSpec,
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
                Mutation.ListCidrsForComputeSetting_ObjectFieldSpec,
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
                Mutation.LockUsersByAdmin_ObjectFieldSpec,
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
                Mutation.LogoutFromRubrikSupportPortal_ObjectFieldSpec,
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
                Mutation.MakePrimary_ObjectFieldSpec,
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
        // modifyActiveDirectoryLiveMount(input: ModifyActiveDirectoryLiveMountInput!): Void
        internal void InitMutationModifyActiveDirectoryLiveMount()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "ModifyActiveDirectoryLiveMountInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationModifyActiveDirectoryLiveMount",
                "($input: ModifyActiveDirectoryLiveMountInput!)",
                "System.String",
                Mutation.ModifyActiveDirectoryLiveMount_ObjectFieldSpec,
                Mutation.ModifyActiveDirectoryLiveMountFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	config = @{
		# OPTIONAL
		validIps = @(
			$someString
		)
		# OPTIONAL
		password = $someString
		# OPTIONAL
		subnet = $someString
	}
	# REQUIRED
	id = $someString
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
                Mutation.ModifyIpmi_ObjectFieldSpec,
                Mutation.ModifyIpmiFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someString
	# REQUIRED
	updateProperties = @{
		# OPTIONAL
		access = @{
			# OPTIONAL
			https = $someBoolean
			# OPTIONAL
			iKvm = $someBoolean
		}
		# OPTIONAL
		password = $someString
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
                Mutation.MountDisk_ObjectFieldSpec,
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
        // mutateRole(
        //     roleId: String
        //     name: String!
        //     description: String!
        //     permissions: [PermissionInput!]!
        //     protectableClusters: [String!]!
        //   ): UUID!
        internal void InitMutationMutateRole()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("roleId", "String"),
                Tuple.Create("name", "String!"),
                Tuple.Create("description", "String!"),
                Tuple.Create("permissions", "[PermissionInput!]!"),
                Tuple.Create("protectableClusters", "[String!]!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationMutateRole",
                "($roleId: String,$name: String!,$description: String!,$permissions: [PermissionInput!]!,$protectableClusters: [String!]!)",
                "System.String",
                Mutation.MutateRole_ObjectFieldSpec,
                Mutation.MutateRoleFieldSpec,
                @"# OPTIONAL
$query.Var.roleId = $someString
# REQUIRED
$query.Var.name = $someString
# REQUIRED
$query.Var.description = $someString
# REQUIRED
$query.Var.permissions = @(
	@{
		# REQUIRED
		operation = $someOperation # Call [Enum]::GetValues([RubrikSecurityCloud.Types.Operation]) for enum values.
		# REQUIRED
		objectsForHierarchyTypes = @(
			@{
				# REQUIRED
				objectIds = @(
					$someString
				)
				# REQUIRED
				snappableType = $someWorkloadLevelHierarchy # Call [Enum]::GetValues([RubrikSecurityCloud.Types.WorkloadLevelHierarchy]) for enum values.
			}
		)
}
)
# REQUIRED
$query.Var.protectableClusters = @(
	$someString
)"
            );
        }

        // Create new GraphQL Mutation:
        // notificationForGetLicense: NotificationForGetLicenseReply!
        internal void InitMutationNotificationForGetLicense()
        {
            Tuple<string, string>[] argDefs = {
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationNotificationForGetLicense",
                "",
                "NotificationForGetLicenseReply",
                Mutation.NotificationForGetLicense_ObjectFieldSpec,
                Mutation.NotificationForGetLicenseFieldSpec,
                @""
            );
        }

        // Create new GraphQL Mutation:
        // pauseTarget(input: PauseTargetInput!): PauseTargetReply!
        internal void InitMutationPauseTarget()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "PauseTargetInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationPauseTarget",
                "($input: PauseTargetInput!)",
                "PauseTargetReply",
                Mutation.PauseTarget_ObjectFieldSpec,
                Mutation.PauseTargetFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	id = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // promoteReaderTarget(input: PromoteReaderTargetInput!): Void
        internal void InitMutationPromoteReaderTarget()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "PromoteReaderTargetInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationPromoteReaderTarget",
                "($input: PromoteReaderTargetInput!)",
                "System.String",
                Mutation.PromoteReaderTarget_ObjectFieldSpec,
                Mutation.PromoteReaderTargetFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	locationId = $someString
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
                Mutation.RecoverCloudDirectMultiPaths_ObjectFieldSpec,
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
                Mutation.RecoverCloudDirectPath_ObjectFieldSpec,
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
                Mutation.RefreshDomain_ObjectFieldSpec,
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
                Mutation.RefreshGlobalManagerConnectivityStatus_ObjectFieldSpec,
                Mutation.RefreshGlobalManagerConnectivityStatusFieldSpec,
                @"# REQUIRED
$query.Var.clusterUuid = $someString"
            );
        }

        // Create new GraphQL Mutation:
        // refreshNasSystems(input: RefreshNasSystemsInput!): RefreshNasSystemsReply!
        internal void InitMutationRefreshNasSystems()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "RefreshNasSystemsInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationRefreshNasSystems",
                "($input: RefreshNasSystemsInput!)",
                "RefreshNasSystemsReply",
                Mutation.RefreshNasSystems_ObjectFieldSpec,
                Mutation.RefreshNasSystemsFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	discoverNasSystemRequest = @{
		# REQUIRED
		ids = @(
			$someString
		)
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // refreshReaderTarget(input: RefreshReaderTargetInput!): Void
        internal void InitMutationRefreshReaderTarget()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "RefreshReaderTargetInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationRefreshReaderTarget",
                "($input: RefreshReaderTargetInput!)",
                "System.String",
                Mutation.RefreshReaderTarget_ObjectFieldSpec,
                Mutation.RefreshReaderTargetFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	localDataSourceIds = @(
		$someString
	)
	# OPTIONAL
	archivalDataSourceIds = @(
		$someString
	)
	# OPTIONAL
	locationId = $someString
	# OPTIONAL
	externalLocationId = $someString
	# OPTIONAL
	clusterId = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // registerNasSystem(input: RegisterNasSystemInput!): RegisterNasSystemReply!
        internal void InitMutationRegisterNasSystem()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "RegisterNasSystemInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationRegisterNasSystem",
                "($input: RegisterNasSystemInput!)",
                "RegisterNasSystemReply",
                Mutation.RegisterNasSystem_ObjectFieldSpec,
                Mutation.RegisterNasSystemFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	clusterUuid = $someString
	# REQUIRED
	nasSystem = @{
		# OPTIONAL
		genericNasSystemParameters = @{
			# OPTIONAL
			smbCredentials = @{
				# REQUIRED
				password = $someString
				# REQUIRED
				username = $someString
			}
			# REQUIRED
			hasNfsSupport = $someBoolean
			# REQUIRED
			hasSmbSupport = $someBoolean
		}
		# OPTIONAL
		isIsilonChangelistEnabled = $someBoolean
		# OPTIONAL
		nasTmpApiCredentials = @{
			# OPTIONAL
			apiCertificate = $someString
			# OPTIONAL
			apiPassword = $someString
			# OPTIONAL
			apiUsername = $someString
			# OPTIONAL
			certificateId = $someString
		}
		# OPTIONAL
		nasFlashBladeApiCredentials = @{
			# OPTIONAL
			apiCertificate = $someString
			# OPTIONAL
			certificateId = $someString
			# OPTIONAL
			smbCredentials = @{
				# REQUIRED
				password = $someString
				# REQUIRED
				username = $someString
			}
			# REQUIRED
			apiToken = $someString
			# REQUIRED
			hasSmbSupport = $someBoolean
		}
		# OPTIONAL
		nutanixFileServerParameters = @{
			# OPTIONAL
			apiCertificate = $someString
			# OPTIONAL
			certificateId = $someString
			# OPTIONAL
			smbCredentials = @{
				# REQUIRED
				password = $someString
				# REQUIRED
				username = $someString
			}
			# OPTIONAL
			apiPassword = $someString
			# OPTIONAL
			apiUsername = $someString
			# REQUIRED
			hasSmbSupport = $someBoolean
		}
		# REQUIRED
		nasVendorType = $someNasVendorType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.NasVendorType]) for enum values.
		# REQUIRED
		hostname = $someString
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // removeClusterNodes(input: RemoveClusterNodesInput!): CcProvisionJobReply!
        internal void InitMutationRemoveClusterNodes()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "RemoveClusterNodesInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationRemoveClusterNodes",
                "($input: RemoveClusterNodesInput!)",
                "CcProvisionJobReply",
                Mutation.RemoveClusterNodes_ObjectFieldSpec,
                Mutation.RemoveClusterNodesFieldSpec,
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
                Mutation.RemoveDisk_ObjectFieldSpec,
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
                Mutation.RemoveInventoryWorkloads_ObjectFieldSpec,
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
        // removePolicyObjects(
        //     policyIds: [String!]!
        //     objectIds: [String!]! = []
        //     objectRootIds: [String!]! = []
        //     clusterIds: [String!]! = []
        //     runAsync: Boolean!
        //   ): [String!]!
        internal void InitMutationRemovePolicyObjects()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("policyIds", "[String!]!"),
                Tuple.Create("objectIds", "[String!]!"),
                Tuple.Create("objectRootIds", "[String!]!"),
                Tuple.Create("clusterIds", "[String!]!"),
                Tuple.Create("runAsync", "Boolean!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationRemovePolicyObjects",
                "($policyIds: [String!]!,$objectIds: [String!]!,$objectRootIds: [String!]!,$clusterIds: [String!]!,$runAsync: Boolean!)",
                "List<System.String>",
                Mutation.RemovePolicyObjects_ObjectFieldSpec,
                Mutation.RemovePolicyObjectsFieldSpec,
                @"# REQUIRED
$query.Var.policyIds = @(
	$someString
)
# REQUIRED
$query.Var.objectIds = @(
	$someString
)
# REQUIRED
$query.Var.objectRootIds = @(
	$someString
)
# REQUIRED
$query.Var.clusterIds = @(
	$someString
)
# REQUIRED
$query.Var.runAsync = $someBoolean"
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
                Mutation.RemovePrivateEndpointConnection_ObjectFieldSpec,
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
                Mutation.RemoveProxyConfig_ObjectFieldSpec,
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
                Mutation.RemoveVlans_ObjectFieldSpec,
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
                Mutation.ReseedLogShippingSecondary_ObjectFieldSpec,
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
                Mutation.ResetAllOrgUsersPasswords_ObjectFieldSpec,
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
                Mutation.ResetUsersPasswordsWithUserIds_ObjectFieldSpec,
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
                Mutation.ResizeDisk_ObjectFieldSpec,
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
                Mutation.ResolveVolumeGroupsConflict_ObjectFieldSpec,
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
        // restoreActiveDirectoryObjects(input: RestoreActiveDirectoryObjectsInput!): AsyncRequestStatus!
        internal void InitMutationRestoreActiveDirectoryObjects()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "RestoreActiveDirectoryObjectsInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationRestoreActiveDirectoryObjects",
                "($input: RestoreActiveDirectoryObjectsInput!)",
                "AsyncRequestStatus",
                Mutation.RestoreActiveDirectoryObjects_ObjectFieldSpec,
                Mutation.RestoreActiveDirectoryObjectsFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	config = @{
		# OPTIONAL
		shouldMergeLinkedAttrs = $someBoolean
		# OPTIONAL
		userRestoreOptions = @{
			# OPTIONAL
			shouldEnableUser = $someBoolean
			# OPTIONAL
			shouldChangePassword = $someBoolean
			# OPTIONAL
			password = $someString
			# OPTIONAL
			passwordOptions = $someActiveDirectoryUserPasswordRecoveryOption # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ActiveDirectoryUserPasswordRecoveryOption]) for enum values.
		}
		# OPTIONAL
		restoreToDifferentContainer = $someString
		# OPTIONAL
		shouldContinueOnError = $someBoolean
		# OPTIONAL
		clearUpAttrsIfNullInBackup = $someBoolean
		# OPTIONAL
		credsForRestore = @{
			# REQUIRED
			password = $someString
			# REQUIRED
			username = $someString
		}
		# OPTIONAL
		shouldCreateMissingParents = $someBoolean
		# OPTIONAL
		containerRestoreOptions = @{
			# OPTIONAL
			shouldDeleteExtraObjects = $someBoolean
			# OPTIONAL
			shouldOnlyRecreateMissingObjects = $someBoolean
		}
		# OPTIONAL
		locationId = $someString
		# OPTIONAL
		nameConflict = $someActiveDirectoryObjectNameConflictOption # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ActiveDirectoryObjectNameConflictOption]) for enum values.
		# OPTIONAL
		objectMovedOptions = $someActiveDirectoryObjectMovedOption # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ActiveDirectoryObjectMovedOption]) for enum values.
		# REQUIRED
		domainControllerRecoveryObjects = @(
			@{
				# OPTIONAL
				objectType = $someActiveDirectoryObjectType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ActiveDirectoryObjectType]) for enum values.
				# REQUIRED
				dnt = $someInt64
			}
		)
	}
	# REQUIRED
	id = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // resumeTarget(input: ResumeTargetInput!): ResumeTargetReply!
        internal void InitMutationResumeTarget()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "ResumeTargetInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationResumeTarget",
                "($input: ResumeTargetInput!)",
                "ResumeTargetReply",
                Mutation.ResumeTarget_ObjectFieldSpec,
                Mutation.ResumeTargetFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
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
                Mutation.RetryBackup_ObjectFieldSpec,
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
                Mutation.RetryDownloadPackageJob_ObjectFieldSpec,
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
                Mutation.RevokeAllOrgRoles_ObjectFieldSpec,
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
                Mutation.RunCustomAnalyzer_ObjectFieldSpec,
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
                Mutation.ScheduleUpgradeBatchJob_ObjectFieldSpec,
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
                Mutation.SetAnalyzerRisks_ObjectFieldSpec,
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
                Mutation.SetCustomerTags_ObjectFieldSpec,
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
                Mutation.SetDatastoreFreespaceThresholds_ObjectFieldSpec,
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
                Mutation.SetIpWhitelistEnabled_ObjectFieldSpec,
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
                Mutation.SetMfaSetting_ObjectFieldSpec,
                Mutation.SetMfaSettingFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	isTotpEnforcedGlobal = $someBoolean
	# OPTIONAL
	totpReminderHours = $someInt
	# OPTIONAL
	mfaRememberHours = $someInt
}"
            );
        }

        // Create new GraphQL Mutation:
        // setPasswordComplexityPolicy(input: SetPasswordComplexityPolicyInput!): Void
        internal void InitMutationSetPasswordComplexityPolicy()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "SetPasswordComplexityPolicyInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationSetPasswordComplexityPolicy",
                "($input: SetPasswordComplexityPolicyInput!)",
                "System.String",
                Mutation.SetPasswordComplexityPolicy_ObjectFieldSpec,
                Mutation.SetPasswordComplexityPolicyFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	policy = @{
		# REQUIRED
		lengthPolicy = @{
			# OPTIONAL
			minValue = $someInt
			# OPTIONAL
			maxValue = $someInt
			# OPTIONAL
			defaultValue = $someInt
			# REQUIRED
			isActive = $someBoolean
		}
		# REQUIRED
		lowercasePolicy = @{
			# OPTIONAL
			minValue = $someInt
			# OPTIONAL
			maxValue = $someInt
			# OPTIONAL
			defaultValue = $someInt
			# REQUIRED
			isActive = $someBoolean
		}
		# REQUIRED
		uppercasePolicy = @{
			# OPTIONAL
			minValue = $someInt
			# OPTIONAL
			maxValue = $someInt
			# OPTIONAL
			defaultValue = $someInt
			# REQUIRED
			isActive = $someBoolean
		}
		# REQUIRED
		specialCharsPolicy = @{
			# OPTIONAL
			minValue = $someInt
			# OPTIONAL
			maxValue = $someInt
			# OPTIONAL
			defaultValue = $someInt
			# REQUIRED
			isActive = $someBoolean
		}
		# REQUIRED
		numericPolicy = @{
			# OPTIONAL
			minValue = $someInt
			# OPTIONAL
			maxValue = $someInt
			# OPTIONAL
			defaultValue = $someInt
			# REQUIRED
			isActive = $someBoolean
		}
		# REQUIRED
		passwordReusePolicy = @{
			# OPTIONAL
			minValue = $someInt
			# OPTIONAL
			maxValue = $someInt
			# OPTIONAL
			defaultValue = $someInt
			# REQUIRED
			isActive = $someBoolean
		}
		# REQUIRED
		passwordExpirationPolicy = @{
			# OPTIONAL
			minValue = $someInt
			# OPTIONAL
			maxValue = $someInt
			# OPTIONAL
			defaultValue = $someInt
			# REQUIRED
			isActive = $someBoolean
		}
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
                Mutation.SetTotpConfig_ObjectFieldSpec,
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
                Mutation.SetUpgradeType_ObjectFieldSpec,
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
                Mutation.SetUserLevelTotpEnforcement_ObjectFieldSpec,
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
                Mutation.SetWorkloadAlertSetting_ObjectFieldSpec,
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
                Mutation.SetupDisk_ObjectFieldSpec,
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
                Mutation.StartCrawl_ObjectFieldSpec,
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
                Mutation.StartDownloadPackageBatchJob_ObjectFieldSpec,
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
                Mutation.StartExportRdsInstanceJob_ObjectFieldSpec,
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
                Mutation.StartPeriodicUpgradePrechecksOnDemandJob_ObjectFieldSpec,
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
                Mutation.StartUpgradeBatchJob_ObjectFieldSpec,
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
                Mutation.StartVolumeGroupMount_ObjectFieldSpec,
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
                Mutation.StopJobInstance_ObjectFieldSpec,
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
                Mutation.StopJobInstanceFromEventSeries_ObjectFieldSpec,
                Mutation.StopJobInstanceFromEventSeriesFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	eventSeriesId = $someString
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
                Mutation.SupportPortalLogin_ObjectFieldSpec,
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
        // testSyslogExportRule(input: TestSyslogExportRuleInput!): TestSyslogExportRuleReply!
        internal void InitMutationTestSyslogExportRule()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "TestSyslogExportRuleInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationTestSyslogExportRule",
                "($input: TestSyslogExportRuleInput!)",
                "TestSyslogExportRuleReply",
                Mutation.TestSyslogExportRule_ObjectFieldSpec,
                Mutation.TestSyslogExportRuleFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	syslogExportRuleV51 = @{
		# OPTIONAL
		syslogCertificateInfo = @{
			# OPTIONAL
			serverCertificate = $someString
			# OPTIONAL
			serverCertificateName = $someString
		}
		# OPTIONAL
		syslogExportRuleFull = @{
			# OPTIONAL
			certificateId = $someString
			# REQUIRED
			facility = $someSyslogFacility # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogFacility]) for enum values.
			# REQUIRED
			protocol = $someTransportLayerProtocol # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TransportLayerProtocol]) for enum values.
			# REQUIRED
			severity = $someSyslogSeverity # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogSeverity]) for enum values.
			# REQUIRED
			enableTls = $someBoolean
			# REQUIRED
			hostname = $someString
			# REQUIRED
			port = $someInt
		}
	}
	# OPTIONAL
	syslogExportRuleV52 = @{
		# OPTIONAL
		certificateId = $someString
		# REQUIRED
		facility = $someSyslogFacility # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogFacility]) for enum values.
		# REQUIRED
		protocol = $someTransportLayerProtocol # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TransportLayerProtocol]) for enum values.
		# REQUIRED
		severity = $someSyslogSeverity # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogSeverity]) for enum values.
		# REQUIRED
		enableTls = $someBoolean
		# REQUIRED
		hostname = $someString
		# REQUIRED
		port = $someInt
	}
	# OPTIONAL
	syslogExportRuleV53 = @{
		# OPTIONAL
		certificateId = $someString
		# REQUIRED
		facility = $someSyslogFacility # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogFacility]) for enum values.
		# REQUIRED
		protocol = $someTransportLayerProtocol # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TransportLayerProtocol]) for enum values.
		# REQUIRED
		severity = $someSyslogSeverity # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogSeverity]) for enum values.
		# REQUIRED
		enableTls = $someBoolean
		# REQUIRED
		hostname = $someString
		# REQUIRED
		port = $someInt
	}
	# OPTIONAL
	syslogExportRuleV60 = @{
		# OPTIONAL
		certificateId = $someString
		# REQUIRED
		facility = $someSyslogFacility # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogFacility]) for enum values.
		# REQUIRED
		protocol = $someTransportLayerProtocol # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TransportLayerProtocol]) for enum values.
		# REQUIRED
		severity = $someSyslogSeverity # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogSeverity]) for enum values.
		# REQUIRED
		enableTls = $someBoolean
		# REQUIRED
		hostname = $someString
		# REQUIRED
		port = $someInt
	}
	# OPTIONAL
	syslogExportRuleV70 = @{
		# OPTIONAL
		certificateId = $someString
		# REQUIRED
		facility = $someSyslogFacility # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogFacility]) for enum values.
		# REQUIRED
		protocol = $someTransportLayerProtocol # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TransportLayerProtocol]) for enum values.
		# REQUIRED
		severity = $someSyslogSeverity # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogSeverity]) for enum values.
		# REQUIRED
		enableTls = $someBoolean
		# REQUIRED
		hostname = $someString
		# REQUIRED
		port = $someInt
	}
	# OPTIONAL
	syslogExportRuleV80 = @{
		# OPTIONAL
		certificateId = $someString
		# REQUIRED
		facility = $someSyslogFacility # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogFacility]) for enum values.
		# REQUIRED
		protocol = $someTransportLayerProtocol # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TransportLayerProtocol]) for enum values.
		# REQUIRED
		severity = $someSyslogSeverity # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogSeverity]) for enum values.
		# REQUIRED
		enableTls = $someBoolean
		# REQUIRED
		hostname = $someString
		# REQUIRED
		port = $someInt
	}
	# OPTIONAL
	syslogExportRuleV81 = @{
		# OPTIONAL
		certificateId = $someString
		# REQUIRED
		facility = $someSyslogFacility # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogFacility]) for enum values.
		# REQUIRED
		protocol = $someTransportLayerProtocol # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TransportLayerProtocol]) for enum values.
		# REQUIRED
		severity = $someSyslogSeverity # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogSeverity]) for enum values.
		# REQUIRED
		enableTls = $someBoolean
		# REQUIRED
		hostname = $someString
		# REQUIRED
		port = $someInt
	}
	# OPTIONAL
	syslogExportRuleV90 = @{
		# OPTIONAL
		certificateId = $someString
		# REQUIRED
		facility = $someSyslogFacility # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogFacility]) for enum values.
		# REQUIRED
		protocol = $someTransportLayerProtocol # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TransportLayerProtocol]) for enum values.
		# REQUIRED
		severity = $someSyslogSeverity # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogSeverity]) for enum values.
		# REQUIRED
		enableTls = $someBoolean
		# REQUIRED
		hostname = $someString
		# REQUIRED
		port = $someInt
	}
	# OPTIONAL
	syslogExportRuleV91 = @{
		# OPTIONAL
		certificateId = $someString
		# REQUIRED
		facility = $someSyslogFacility # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogFacility]) for enum values.
		# REQUIRED
		protocol = $someTransportLayerProtocol # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TransportLayerProtocol]) for enum values.
		# REQUIRED
		severity = $someSyslogSeverity # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogSeverity]) for enum values.
		# REQUIRED
		enableTls = $someBoolean
		# REQUIRED
		hostname = $someString
		# REQUIRED
		port = $someInt
	}
	# REQUIRED
	clusterUuid = $someString
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
                Mutation.TriggerCloudComputeConnectivityCheck_ObjectFieldSpec,
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
                Mutation.TriggerExocomputeHealthCheck_ObjectFieldSpec,
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
                Mutation.UninstallIoFilter_ObjectFieldSpec,
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
                Mutation.UnlockUsersByAdmin_ObjectFieldSpec,
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
                Mutation.UnmountDisk_ObjectFieldSpec,
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
                Mutation.UpdateAccountOwner_ObjectFieldSpec,
                Mutation.UpdateAccountOwnerFieldSpec,
                @"# REQUIRED
$query.Var.userId = $someString"
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
                Mutation.UpdateAuthDomainUsersHiddenStatus_ObjectFieldSpec,
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
        // updateAutoEnablePolicyClusterConfig(input: UpdateAutoEnablePolicyClusterConfigInput!): UpdateAutoEnablePolicyClusterConfigReply!
        internal void InitMutationUpdateAutoEnablePolicyClusterConfig()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateAutoEnablePolicyClusterConfigInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateAutoEnablePolicyClusterConfig",
                "($input: UpdateAutoEnablePolicyClusterConfigInput!)",
                "UpdateAutoEnablePolicyClusterConfigReply",
                Mutation.UpdateAutoEnablePolicyClusterConfig_ObjectFieldSpec,
                Mutation.UpdateAutoEnablePolicyClusterConfigFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	clusterId = $someString
	# OPTIONAL
	enabled = $someBoolean
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
                Mutation.UpdateBadDiskLedStatus_ObjectFieldSpec,
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
        // updateClusterDefaultAddress(input: UpdateClusterDefaultAddressInput!): UpdateClusterDefaultAddressReply!
        internal void InitMutationUpdateClusterDefaultAddress()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateClusterDefaultAddressInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateClusterDefaultAddress",
                "($input: UpdateClusterDefaultAddressInput!)",
                "UpdateClusterDefaultAddressReply",
                Mutation.UpdateClusterDefaultAddress_ObjectFieldSpec,
                Mutation.UpdateClusterDefaultAddressFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	clusterUuid = $someString
	# OPTIONAL
	address = $someString
	# OPTIONAL
	port = $someInt
}"
            );
        }

        // Create new GraphQL Mutation:
        // updateClusterLocation(clusterUuid: UUID!, clusterLocation: ClusterLocationEdit!): Cluster!
        internal void InitMutationUpdateClusterLocation()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("clusterUuid", "UUID!"),
                Tuple.Create("clusterLocation", "ClusterLocationEdit!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateClusterLocation",
                "($clusterUuid: UUID!,$clusterLocation: ClusterLocationEdit!)",
                "Cluster",
                Mutation.UpdateClusterLocation_ObjectFieldSpec,
                Mutation.UpdateClusterLocationFieldSpec,
                @"# REQUIRED
$query.Var.clusterUuid = $someString
# REQUIRED
$query.Var.clusterLocation = @{
	# REQUIRED
	address = $someString
	# REQUIRED
	latitude = $someSingle
	# REQUIRED
	longitude = $someSingle
}"
            );
        }

        // Create new GraphQL Mutation:
        // updateClusterNtpServers(input: UpdateClusterNtpServersInput!): ResponseSuccess!
        internal void InitMutationUpdateClusterNtpServers()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateClusterNtpServersInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateClusterNtpServers",
                "($input: UpdateClusterNtpServersInput!)",
                "ResponseSuccess",
                Mutation.UpdateClusterNtpServers_ObjectFieldSpec,
                Mutation.UpdateClusterNtpServersFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someString
	# REQUIRED
	ntpServerConfigs = @(
		@{
			# OPTIONAL
			symmetricKey = @{
				# REQUIRED
				key = $someString
				# REQUIRED
				keyId = $someInt
				# REQUIRED
				keyType = $someString
			}
			# REQUIRED
			server = $someString
		}
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // updateClusterSettings(input: UpdateClusterSettingsInput!): UpdateClusterSettingsReply!
        internal void InitMutationUpdateClusterSettings()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateClusterSettingsInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateClusterSettings",
                "($input: UpdateClusterSettingsInput!)",
                "UpdateClusterSettingsReply",
                Mutation.UpdateClusterSettings_ObjectFieldSpec,
                Mutation.UpdateClusterSettingsFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	clusterUpdate = @{
		# OPTIONAL
		acceptedEulaVersion = $someString
		# OPTIONAL
		geolocation = @{
			# REQUIRED
			address = $someString
		}
		# OPTIONAL
		name = $someString
		# OPTIONAL
		timezone = @{
			# REQUIRED
			timezone = $someClusterTimezoneType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ClusterTimezoneType]) for enum values.
		}
	}
	# REQUIRED
	id = $someString
	# REQUIRED
	clusterUuid = $someString
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
                Mutation.UpdateConfiguredGroup_ObjectFieldSpec,
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
                Mutation.UpdateCustomAnalyzer_ObjectFieldSpec,
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
	risk = $someRiskLevelType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RiskLevelType]) for enum values.
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
                Mutation.UpdateDistributionListDigest_ObjectFieldSpec,
                Mutation.UpdateDistributionListDigestFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
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
                Mutation.UpdateDnsServersAndSearchDomains_ObjectFieldSpec,
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
                Mutation.UpdateEventDigest_ObjectFieldSpec,
                Mutation.UpdateEventDigestFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
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
        // updateFailoverClusterApp(input: UpdateFailoverClusterAppInput!): UpdateFailoverClusterAppReply!
        internal void InitMutationUpdateFailoverClusterApp()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateFailoverClusterAppInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateFailoverClusterApp",
                "($input: UpdateFailoverClusterAppInput!)",
                "UpdateFailoverClusterAppReply",
                Mutation.UpdateFailoverClusterApp_ObjectFieldSpec,
                Mutation.UpdateFailoverClusterAppFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someString
	# REQUIRED
	updateProperties = @{
		# OPTIONAL
		configuredSlaDomainId = $someString
		# REQUIRED
		failoverClusterType = $someFailoverClusterType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.FailoverClusterType]) for enum values.
		# REQUIRED
		failoverClusterAppSource = @{
			# OPTIONAL
			nodeOrders = @(
				@{
					# OPTIONAL
					nodeName = $someString
					# REQUIRED
					nodeId = $someString
					# REQUIRED
					order = $someInt
				}
			)
			# OPTIONAL
			virtualIps = @(
				$someString
			)
			# OPTIONAL
			vips = @(
				$someString
			)
		}
		# REQUIRED
		failoverClusterId = $someString
		# REQUIRED
		name = $someString
	}
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
                Mutation.UpdateFloatingIps_ObjectFieldSpec,
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
        // updateGlacierTarget(input: UpdateGlacierTargetInput!): Target!
        internal void InitMutationUpdateGlacierTarget()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateGlacierTargetInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateGlacierTarget",
                "($input: UpdateGlacierTargetInput!)",
                "Target",
                Mutation.UpdateGlacierTarget_ObjectFieldSpec,
                Mutation.UpdateGlacierTargetFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someString
	# OPTIONAL
	name = $someString
	# OPTIONAL
	retrievalTier = $someAwsRetrievalTier # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsRetrievalTier]) for enum values.
	# OPTIONAL
	cloudAccountId = $someString
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
                Mutation.UpdateGuestCredential_ObjectFieldSpec,
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
        // updateHealthMonitorPolicyStatus(input: UpdateHealthMonitorPolicyStatusInput!): UpdateHealthMonitorPolicyStatusReply!
        internal void InitMutationUpdateHealthMonitorPolicyStatus()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateHealthMonitorPolicyStatusInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateHealthMonitorPolicyStatus",
                "($input: UpdateHealthMonitorPolicyStatusInput!)",
                "UpdateHealthMonitorPolicyStatusReply",
                Mutation.UpdateHealthMonitorPolicyStatus_ObjectFieldSpec,
                Mutation.UpdateHealthMonitorPolicyStatusFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	clusterUuid = $someString
	# REQUIRED
	runRequest = @{
		# OPTIONAL
		nodeIds = @(
			$someString
		)
		# REQUIRED
		policyIds = @(
			$someString
		)
	}
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
                Mutation.UpdateInsightState_ObjectFieldSpec,
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
        // updateIntegration(input: UpdateIntegrationInput!): Void
        internal void InitMutationUpdateIntegration()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateIntegrationInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateIntegration",
                "($input: UpdateIntegrationInput!)",
                "System.String",
                Mutation.UpdateIntegration_ObjectFieldSpec,
                Mutation.UpdateIntegrationFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someInt64
	# REQUIRED
	name = $someString
	# REQUIRED
	integrationType = $someIntegrationType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.IntegrationType]) for enum values.
	# REQUIRED
	config = @{
		# OPTIONAL
		dataLossPrevention = @{
			# OPTIONAL
			policies = @(
				$someString
			)
			# OPTIONAL
			genericNas = @{
				# REQUIRED
				workloadId = $someString
				# REQUIRED
				shareType = $someDlpConfigShareType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DlpConfigShareType]) for enum values.
				# REQUIRED
				shareId = $someString
				# REQUIRED
				path = $someString
			}
			# OPTIONAL
			vmwareVm = @{
				# REQUIRED
				workloadId = $someString
				# REQUIRED
				osType = $someDlpConfigOsType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DlpConfigOsType]) for enum values.
				# REQUIRED
				path = $someString
			}
			# OPTIONAL
			serviceAccountId = $someString
			# OPTIONAL
			serviceAccountName = $someString
			# OPTIONAL
			status = @{
				# OPTIONAL
				code = $someDlpStatusCode # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DlpStatusCode]) for enum values.
			}
			# REQUIRED
			targetType = $someDlpConfigTargetType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DlpConfigTargetType]) for enum values.
		}
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // updateIntegrations(input: UpdateIntegrationsInput!): Void
        internal void InitMutationUpdateIntegrations()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateIntegrationsInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateIntegrations",
                "($input: UpdateIntegrationsInput!)",
                "System.String",
                Mutation.UpdateIntegrations_ObjectFieldSpec,
                Mutation.UpdateIntegrationsFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	integrations = @(
		@{
			# REQUIRED
			id = $someInt64
			# REQUIRED
			name = $someString
			# REQUIRED
			integrationType = $someIntegrationType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.IntegrationType]) for enum values.
			# REQUIRED
			config = @{
				# OPTIONAL
				dataLossPrevention = @{
					# OPTIONAL
					policies = @(
						$someString
					)
					# OPTIONAL
					genericNas = @{
						# REQUIRED
						workloadId = $someString
						# REQUIRED
						shareType = $someDlpConfigShareType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DlpConfigShareType]) for enum values.
						# REQUIRED
						shareId = $someString
						# REQUIRED
						path = $someString
					}
					# OPTIONAL
					vmwareVm = @{
						# REQUIRED
						workloadId = $someString
						# REQUIRED
						osType = $someDlpConfigOsType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DlpConfigOsType]) for enum values.
						# REQUIRED
						path = $someString
					}
					# OPTIONAL
					serviceAccountId = $someString
					# OPTIONAL
					serviceAccountName = $someString
					# OPTIONAL
					status = @{
						# OPTIONAL
						code = $someDlpStatusCode # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DlpStatusCode]) for enum values.
					}
					# REQUIRED
					targetType = $someDlpConfigTargetType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DlpConfigTargetType]) for enum values.
				}
			}
		}
	)
}"
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
                Mutation.UpdateIpWhitelist_ObjectFieldSpec,
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
                Mutation.UpdateLambdaSettings_ObjectFieldSpec,
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
                Mutation.UpdateLockoutConfig_ObjectFieldSpec,
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
        // updateManualTargetMapping(input: UpdateManualTargetMappingInput!): TargetMapping!
        internal void InitMutationUpdateManualTargetMapping()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateManualTargetMappingInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateManualTargetMapping",
                "($input: UpdateManualTargetMappingInput!)",
                "TargetMapping",
                Mutation.UpdateManualTargetMapping_ObjectFieldSpec,
                Mutation.UpdateManualTargetMappingFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	id = $someString
	# OPTIONAL
	name = $someString
	# OPTIONAL
	archivalLocationClusterMappings = @(
		@{
			# OPTIONAL
			locationId = $someString
			# OPTIONAL
			clusterUuid = $someString
		}
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // updateNasShares(input: UpdateNasSharesInput!): Void
        internal void InitMutationUpdateNasShares()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateNasSharesInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateNasShares",
                "($input: UpdateNasSharesInput!)",
                "System.String",
                Mutation.UpdateNasShares_ObjectFieldSpec,
                Mutation.UpdateNasSharesFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	updateNasSharesRequest = @{
		# REQUIRED
		nasShareProperties = @(
			@{
				# OPTIONAL
				isIsilonChangelistEnabled = $someBoolean
				# REQUIRED
				id = $someString
			}
		)
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // updateNasSystem(input: UpdateNasSystemInput!): UpdateNasSystemReply!
        internal void InitMutationUpdateNasSystem()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateNasSystemInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateNasSystem",
                "($input: UpdateNasSystemInput!)",
                "UpdateNasSystemReply",
                Mutation.UpdateNasSystem_ObjectFieldSpec,
                Mutation.UpdateNasSystemFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someString
	# REQUIRED
	nasSystemUpdateProperties = @{
		# OPTIONAL
		genericNasSystemParameters = @{
			# OPTIONAL
			smbCredentials = @{
				# REQUIRED
				password = $someString
				# REQUIRED
				username = $someString
			}
			# REQUIRED
			hasNfsSupport = $someBoolean
			# REQUIRED
			hasSmbSupport = $someBoolean
		}
		# OPTIONAL
		hostname = $someString
		# OPTIONAL
		isIsilonChangelistEnabled = $someBoolean
		# OPTIONAL
		nasApiCredentials = @{
			# OPTIONAL
			apiCertificate = $someString
			# OPTIONAL
			apiPassword = $someString
			# OPTIONAL
			apiUsername = $someString
			# OPTIONAL
			certificateId = $someString
		}
		# OPTIONAL
		nasFlashBladeApiCredentials = @{
			# OPTIONAL
			apiCertificate = $someString
			# OPTIONAL
			certificateId = $someString
			# OPTIONAL
			smbCredentials = @{
				# REQUIRED
				password = $someString
				# REQUIRED
				username = $someString
			}
			# REQUIRED
			apiToken = $someString
			# REQUIRED
			hasSmbSupport = $someBoolean
		}
		# OPTIONAL
		nutanixFileServerParameters = @{
			# OPTIONAL
			apiCertificate = $someString
			# OPTIONAL
			certificateId = $someString
			# OPTIONAL
			smbCredentials = @{
				# REQUIRED
				password = $someString
				# REQUIRED
				username = $someString
			}
			# OPTIONAL
			apiPassword = $someString
			# OPTIONAL
			apiUsername = $someString
			# REQUIRED
			hasSmbSupport = $someBoolean
		}
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
                Mutation.UpdateNetworkThrottle_ObjectFieldSpec,
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
		# OPTIONAL
		networkInterface = $someString
		# OPTIONAL
		archivalThrottlePort = $someInt
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // updateOrg(input: UpdateOrgInput!): UpdateOrgReply!
        internal void InitMutationUpdateOrg()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateOrgInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateOrg",
                "($input: UpdateOrgInput!)",
                "UpdateOrgReply",
                Mutation.UpdateOrg_ObjectFieldSpec,
                Mutation.UpdateOrgFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	organizationId = $someString
	# REQUIRED
	name = $someString
	# REQUIRED
	fullName = $someString
	# REQUIRED
	description = $someString
	# REQUIRED
	authDomainConfig = $someTenantAuthDomainConfig # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TenantAuthDomainConfig]) for enum values.
	# REQUIRED
	shouldEnforceMfaForAll = $someBoolean
	# REQUIRED
	isEnvoyRequired = $someBoolean
	# REQUIRED
	allowedClusters = @(
		$someString
	)
	# OPTIONAL
	existingUsers = @(
		@{
			# REQUIRED
			id = $someString
			# REQUIRED
			isOrgAdmin = $someBoolean
		}
	)
	# OPTIONAL
	userInvites = @(
		@{
			# REQUIRED
			email = $someString
			# REQUIRED
			note = $someString
			# REQUIRED
			isOrgAdmin = $someBoolean
		}
	)
	# REQUIRED
	permissions = @(
		@{
			# REQUIRED
			operation = $someOperation # Call [Enum]::GetValues([RubrikSecurityCloud.Types.Operation]) for enum values.
			# REQUIRED
			objectsForHierarchyTypes = @(
				@{
					# REQUIRED
					objectIds = @(
						$someString
					)
					# REQUIRED
					snappableType = $someWorkloadLevelHierarchy # Call [Enum]::GetValues([RubrikSecurityCloud.Types.WorkloadLevelHierarchy]) for enum values.
				}
			)
		}
	)
	# REQUIRED
	selfServicePermissions = @(
		@{
			# OPTIONAL
			inventoryRoot = $someInventorySubHierarchyRootEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.InventorySubHierarchyRootEnum]) for enum values.
			# REQUIRED
			inventoryWorkloadType = $someWorkloadLevelHierarchy # Call [Enum]::GetValues([RubrikSecurityCloud.Types.WorkloadLevelHierarchy]) for enum values.
			# REQUIRED
			operations = @(
				$someOperation # Call [Enum]::GetValues([RubrikSecurityCloud.Types.Operation]) for enum values.
			)
			# OPTIONAL
			hierarchyRoot = $someString
		}
	)
	# OPTIONAL
	existingSsoGroups = @(
		@{
			# REQUIRED
			id = $someString
			# REQUIRED
			isOrgAdmin = $someBoolean
		}
	)
	# OPTIONAL
	newSsoGroups = @(
		@{
			# REQUIRED
			name = $someString
			# REQUIRED
			isOrgAdmin = $someBoolean
		}
	)
	# OPTIONAL
	isServiceAccountEnabled = $someBoolean
	# OPTIONAL
	crossAccountCapabilities = @(
		$someCrossAccountCapability # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CrossAccountCapability]) for enum values.
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // updateOrgSecurityPolicy(input: UpdateOrgSecurityPolicyInput!): Void
        internal void InitMutationUpdateOrgSecurityPolicy()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateOrgSecurityPolicyInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateOrgSecurityPolicy",
                "($input: UpdateOrgSecurityPolicyInput!)",
                "System.String",
                Mutation.UpdateOrgSecurityPolicy_ObjectFieldSpec,
                Mutation.UpdateOrgSecurityPolicyFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	disallowWeakerPolicy = $someBoolean
}"
            );
        }

        // Create new GraphQL Mutation:
        // updatePolicy(input: UpdatePolicyInput!): ClassificationPolicyDetail!
        internal void InitMutationUpdatePolicy()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdatePolicyInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdatePolicy",
                "($input: UpdatePolicyInput!)",
                "ClassificationPolicyDetail",
                Mutation.UpdatePolicy_ObjectFieldSpec,
                Mutation.UpdatePolicyFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	id = $someString
	# OPTIONAL
	name = $someString
	# OPTIONAL
	description = $someString
	# OPTIONAL
	colorEnum = $someClassificationPolicyColor # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ClassificationPolicyColor]) for enum values.
	# OPTIONAL
	mode = $someClassificationPolicyMode # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ClassificationPolicyMode]) for enum values.
	# OPTIONAL
	analyzerIds = @(
		$someString
	)
	# OPTIONAL
	updateName = $someBoolean
	# OPTIONAL
	updateDescription = $someBoolean
	# OPTIONAL
	updateMode = $someBoolean
	# OPTIONAL
	updateAnalyzerIds = $someBoolean
}"
            );
        }

        // Create new GraphQL Mutation:
        // updatePreviewerClusterConfig(previewerClusterConfig: PreviewerClusterConfigInput!): Cluster!
        internal void InitMutationUpdatePreviewerClusterConfig()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("previewerClusterConfig", "PreviewerClusterConfigInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdatePreviewerClusterConfig",
                "($previewerClusterConfig: PreviewerClusterConfigInput!)",
                "Cluster",
                Mutation.UpdatePreviewerClusterConfig_ObjectFieldSpec,
                Mutation.UpdatePreviewerClusterConfigFieldSpec,
                @"# REQUIRED
$query.Var.previewerClusterConfig = @{
	# OPTIONAL
	clusterId = $someString
	# OPTIONAL
	enabled = $someBoolean
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
                Mutation.UpdateProxyConfig_ObjectFieldSpec,
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
        // updateRole(
        //     roleId: String!
        //     name: String!
        //     description: String!
        //     permissions: [PermissionInput!]!
        //   ): Boolean!
        internal void InitMutationUpdateRole()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("roleId", "String!"),
                Tuple.Create("name", "String!"),
                Tuple.Create("description", "String!"),
                Tuple.Create("permissions", "[PermissionInput!]!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateRole",
                "($roleId: String!,$name: String!,$description: String!,$permissions: [PermissionInput!]!)",
                "System.Boolean",
                Mutation.UpdateRole_ObjectFieldSpec,
                Mutation.UpdateRoleFieldSpec,
                @"# REQUIRED
$query.Var.roleId = $someString
# REQUIRED
$query.Var.name = $someString
# REQUIRED
$query.Var.description = $someString
# REQUIRED
$query.Var.permissions = @(
	@{
		# REQUIRED
		operation = $someOperation # Call [Enum]::GetValues([RubrikSecurityCloud.Types.Operation]) for enum values.
		# REQUIRED
		objectsForHierarchyTypes = @(
			@{
				# REQUIRED
				objectIds = @(
					$someString
				)
				# REQUIRED
				snappableType = $someWorkloadLevelHierarchy # Call [Enum]::GetValues([RubrikSecurityCloud.Types.WorkloadLevelHierarchy]) for enum values.
			}
		)
}
)"
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
                Mutation.UpdateRoleAssignments_ObjectFieldSpec,
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
        // updateS3CompatibleTarget(input: UpdateS3CompatibleTargetInput!): Target!
        internal void InitMutationUpdateS3CompatibleTarget()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateS3CompatibleTargetInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateS3CompatibleTarget",
                "($input: UpdateS3CompatibleTargetInput!)",
                "Target",
                Mutation.UpdateS3CompatibleTarget_ObjectFieldSpec,
                Mutation.UpdateS3CompatibleTargetFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someString
	# OPTIONAL
	name = $someString
	# OPTIONAL
	accessKey = $someString
	# OPTIONAL
	secretKey = $someString
	# OPTIONAL
	endpoint = $someString
	# OPTIONAL
	numberOfBuckets = $someInt
	# OPTIONAL
	isConsolidationEnabled = $someBoolean
	# OPTIONAL
	useSystemProxy = $someBoolean
	# OPTIONAL
	immutabilitySettings = @{
		# OPTIONAL
		bucketLockDurationDays = $someInt
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // updateSnmpConfig(input: UpdateSnmpConfigInput!): UpdateSnmpConfigReply!
        internal void InitMutationUpdateSnmpConfig()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateSnmpConfigInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateSnmpConfig",
                "($input: UpdateSnmpConfigInput!)",
                "UpdateSnmpConfigReply",
                Mutation.UpdateSnmpConfig_ObjectFieldSpec,
                Mutation.UpdateSnmpConfigFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	snmpConfigV50 = @{
		# OPTIONAL
		communityString = $someString
		# OPTIONAL
		trapReceiverConfigs = @(
			@{
				# OPTIONAL
				user = $someString
				# OPTIONAL
				securityLevel = $someSnmpSecurityLevel # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SnmpSecurityLevel]) for enum values.
				# REQUIRED
				address = $someString
				# REQUIRED
				port = $someInt
			}
		)
		# OPTIONAL
		users = @(
			$someString
		)
		# REQUIRED
		isEnabled = $someBoolean
		# REQUIRED
		snmpAgentPort = $someInt
	}
	# OPTIONAL
	snmpConfigV51 = @{
		# OPTIONAL
		communityString = $someString
		# OPTIONAL
		trapReceiverConfigs = @(
			@{
				# OPTIONAL
				user = $someString
				# OPTIONAL
				securityLevel = $someSnmpSecurityLevel # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SnmpSecurityLevel]) for enum values.
				# REQUIRED
				address = $someString
				# REQUIRED
				port = $someInt
			}
		)
		# OPTIONAL
		users = @(
			$someString
		)
		# REQUIRED
		isEnabled = $someBoolean
		# REQUIRED
		snmpAgentPort = $someInt
	}
	# OPTIONAL
	snmpConfigV52 = @{
		# OPTIONAL
		communityString = $someString
		# OPTIONAL
		trapReceiverConfigs = @(
			@{
				# OPTIONAL
				user = $someString
				# OPTIONAL
				securityLevel = $someSnmpSecurityLevel # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SnmpSecurityLevel]) for enum values.
				# REQUIRED
				address = $someString
				# REQUIRED
				port = $someInt
			}
		)
		# OPTIONAL
		users = @(
			@{
				# REQUIRED
				authPassword = $someString
				# REQUIRED
				privPassword = $someString
				# REQUIRED
				username = $someString
			}
		)
		# REQUIRED
		isEnabled = $someBoolean
		# REQUIRED
		snmpAgentPort = $someInt
	}
	# OPTIONAL
	snmpConfigV53 = @{
		# OPTIONAL
		communityString = $someString
		# OPTIONAL
		trapReceiverConfigs = @(
			@{
				# OPTIONAL
				user = $someString
				# OPTIONAL
				securityLevel = $someSnmpSecurityLevel # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SnmpSecurityLevel]) for enum values.
				# REQUIRED
				address = $someString
				# REQUIRED
				port = $someInt
			}
		)
		# OPTIONAL
		users = @(
			@{
				# REQUIRED
				authPassword = $someString
				# REQUIRED
				privPassword = $someString
				# REQUIRED
				username = $someString
			}
		)
		# REQUIRED
		isEnabled = $someBoolean
		# REQUIRED
		snmpAgentPort = $someInt
	}
	# OPTIONAL
	snmpConfigV60 = @{
		# OPTIONAL
		communityString = $someString
		# OPTIONAL
		trapReceiverConfigs = @(
			@{
				# OPTIONAL
				user = $someString
				# OPTIONAL
				securityLevel = $someSnmpSecurityLevel # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SnmpSecurityLevel]) for enum values.
				# REQUIRED
				address = $someString
				# REQUIRED
				port = $someInt
			}
		)
		# OPTIONAL
		users = @(
			@{
				# REQUIRED
				authPassword = $someString
				# REQUIRED
				privPassword = $someString
				# REQUIRED
				username = $someString
			}
		)
		# REQUIRED
		isEnabled = $someBoolean
		# REQUIRED
		snmpAgentPort = $someInt
	}
	# OPTIONAL
	snmpConfigV70 = @{
		# OPTIONAL
		communityString = $someString
		# OPTIONAL
		trapReceiverConfigs = @(
			@{
				# OPTIONAL
				user = $someString
				# OPTIONAL
				securityLevel = $someSnmpSecurityLevel # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SnmpSecurityLevel]) for enum values.
				# REQUIRED
				address = $someString
				# REQUIRED
				port = $someInt
			}
		)
		# OPTIONAL
		users = @(
			@{
				# REQUIRED
				authPassword = $someString
				# REQUIRED
				privPassword = $someString
				# REQUIRED
				username = $someString
			}
		)
		# REQUIRED
		isEnabled = $someBoolean
		# REQUIRED
		snmpAgentPort = $someInt
	}
	# OPTIONAL
	snmpConfigV80 = @{
		# OPTIONAL
		communityString = $someString
		# OPTIONAL
		trapReceiverConfigs = @(
			@{
				# OPTIONAL
				user = $someString
				# OPTIONAL
				securityLevel = $someSnmpSecurityLevel # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SnmpSecurityLevel]) for enum values.
				# REQUIRED
				address = $someString
				# REQUIRED
				port = $someInt
			}
		)
		# OPTIONAL
		users = @(
			@{
				# REQUIRED
				authPassword = $someString
				# REQUIRED
				privPassword = $someString
				# REQUIRED
				username = $someString
			}
		)
		# REQUIRED
		isEnabled = $someBoolean
		# REQUIRED
		snmpAgentPort = $someInt
	}
	# OPTIONAL
	snmpConfigV81 = @{
		# OPTIONAL
		communityString = $someString
		# OPTIONAL
		trapReceiverConfigs = @(
			@{
				# OPTIONAL
				user = $someString
				# OPTIONAL
				securityLevel = $someSnmpSecurityLevel # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SnmpSecurityLevel]) for enum values.
				# REQUIRED
				address = $someString
				# REQUIRED
				port = $someInt
			}
		)
		# OPTIONAL
		users = @(
			@{
				# REQUIRED
				authPassword = $someString
				# REQUIRED
				privPassword = $someString
				# REQUIRED
				username = $someString
			}
		)
		# REQUIRED
		isEnabled = $someBoolean
		# REQUIRED
		snmpAgentPort = $someInt
	}
	# OPTIONAL
	snmpConfigV90 = @{
		# OPTIONAL
		communityString = $someString
		# OPTIONAL
		trapReceiverConfigs = @(
			@{
				# OPTIONAL
				user = $someString
				# OPTIONAL
				securityLevel = $someSnmpSecurityLevel # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SnmpSecurityLevel]) for enum values.
				# REQUIRED
				address = $someString
				# REQUIRED
				port = $someInt
			}
		)
		# OPTIONAL
		users = @(
			@{
				# REQUIRED
				authPassword = $someString
				# REQUIRED
				privPassword = $someString
				# REQUIRED
				username = $someString
			}
		)
		# REQUIRED
		isEnabled = $someBoolean
		# REQUIRED
		snmpAgentPort = $someInt
	}
	# OPTIONAL
	snmpConfigV91 = @{
		# OPTIONAL
		communityString = $someString
		# OPTIONAL
		trapReceiverConfigs = @(
			@{
				# OPTIONAL
				user = $someString
				# OPTIONAL
				securityLevel = $someSnmpSecurityLevel # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SnmpSecurityLevel]) for enum values.
				# REQUIRED
				address = $someString
				# REQUIRED
				port = $someInt
			}
		)
		# OPTIONAL
		users = @(
			@{
				# REQUIRED
				authPassword = $someString
				# REQUIRED
				privPassword = $someString
				# REQUIRED
				username = $someString
			}
		)
		# REQUIRED
		isEnabled = $someBoolean
		# REQUIRED
		snmpAgentPort = $someInt
	}
	# REQUIRED
	clusterUuid = $someString
	# REQUIRED
	id = $someString
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
                Mutation.UpdateSupportUserAccess_ObjectFieldSpec,
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
        // updateSyslogExportRule(input: UpdateSyslogExportRuleInput!): UpdateSyslogExportRuleReply!
        internal void InitMutationUpdateSyslogExportRule()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateSyslogExportRuleInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateSyslogExportRule",
                "($input: UpdateSyslogExportRuleInput!)",
                "UpdateSyslogExportRuleReply",
                Mutation.UpdateSyslogExportRule_ObjectFieldSpec,
                Mutation.UpdateSyslogExportRuleFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	syslogSettingsV51 = @{
		# OPTIONAL
		syslogCertificateInfo = @{
			# OPTIONAL
			serverCertificate = $someString
			# OPTIONAL
			serverCertificateName = $someString
		}
		# OPTIONAL
		syslogExportRulePartial = @{
			# OPTIONAL
			enableTls = $someBoolean
			# OPTIONAL
			hostname = $someString
			# OPTIONAL
			port = $someInt
			# OPTIONAL
			certificateId = $someString
			# OPTIONAL
			facility = $someSyslogFacility # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogFacility]) for enum values.
			# OPTIONAL
			protocol = $someTransportLayerProtocol # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TransportLayerProtocol]) for enum values.
			# OPTIONAL
			severity = $someSyslogSeverity # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogSeverity]) for enum values.
		}
	}
	# OPTIONAL
	syslogSettingsV52 = @{
		# OPTIONAL
		enableTls = $someBoolean
		# OPTIONAL
		hostname = $someString
		# OPTIONAL
		port = $someInt
		# OPTIONAL
		certificateId = $someString
		# OPTIONAL
		facility = $someSyslogFacility # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogFacility]) for enum values.
		# OPTIONAL
		protocol = $someTransportLayerProtocol # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TransportLayerProtocol]) for enum values.
		# OPTIONAL
		severity = $someSyslogSeverity # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogSeverity]) for enum values.
	}
	# OPTIONAL
	syslogSettingsV53 = @{
		# OPTIONAL
		enableTls = $someBoolean
		# OPTIONAL
		hostname = $someString
		# OPTIONAL
		port = $someInt
		# OPTIONAL
		certificateId = $someString
		# OPTIONAL
		facility = $someSyslogFacility # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogFacility]) for enum values.
		# OPTIONAL
		protocol = $someTransportLayerProtocol # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TransportLayerProtocol]) for enum values.
		# OPTIONAL
		severity = $someSyslogSeverity # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogSeverity]) for enum values.
	}
	# OPTIONAL
	syslogSettingsV60 = @{
		# OPTIONAL
		enableTls = $someBoolean
		# OPTIONAL
		hostname = $someString
		# OPTIONAL
		port = $someInt
		# OPTIONAL
		certificateId = $someString
		# OPTIONAL
		facility = $someSyslogFacility # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogFacility]) for enum values.
		# OPTIONAL
		protocol = $someTransportLayerProtocol # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TransportLayerProtocol]) for enum values.
		# OPTIONAL
		severity = $someSyslogSeverity # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogSeverity]) for enum values.
	}
	# OPTIONAL
	syslogSettingsV70 = @{
		# OPTIONAL
		enableTls = $someBoolean
		# OPTIONAL
		hostname = $someString
		# OPTIONAL
		port = $someInt
		# OPTIONAL
		certificateId = $someString
		# OPTIONAL
		facility = $someSyslogFacility # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogFacility]) for enum values.
		# OPTIONAL
		protocol = $someTransportLayerProtocol # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TransportLayerProtocol]) for enum values.
		# OPTIONAL
		severity = $someSyslogSeverity # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogSeverity]) for enum values.
	}
	# OPTIONAL
	syslogSettingsV80 = @{
		# OPTIONAL
		enableTls = $someBoolean
		# OPTIONAL
		hostname = $someString
		# OPTIONAL
		port = $someInt
		# OPTIONAL
		certificateId = $someString
		# OPTIONAL
		facility = $someSyslogFacility # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogFacility]) for enum values.
		# OPTIONAL
		protocol = $someTransportLayerProtocol # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TransportLayerProtocol]) for enum values.
		# OPTIONAL
		severity = $someSyslogSeverity # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogSeverity]) for enum values.
	}
	# OPTIONAL
	syslogSettingsV81 = @{
		# OPTIONAL
		enableTls = $someBoolean
		# OPTIONAL
		hostname = $someString
		# OPTIONAL
		port = $someInt
		# OPTIONAL
		certificateId = $someString
		# OPTIONAL
		facility = $someSyslogFacility # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogFacility]) for enum values.
		# OPTIONAL
		protocol = $someTransportLayerProtocol # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TransportLayerProtocol]) for enum values.
		# OPTIONAL
		severity = $someSyslogSeverity # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogSeverity]) for enum values.
	}
	# OPTIONAL
	syslogSettingsV90 = @{
		# OPTIONAL
		enableTls = $someBoolean
		# OPTIONAL
		hostname = $someString
		# OPTIONAL
		port = $someInt
		# OPTIONAL
		certificateId = $someString
		# OPTIONAL
		facility = $someSyslogFacility # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogFacility]) for enum values.
		# OPTIONAL
		protocol = $someTransportLayerProtocol # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TransportLayerProtocol]) for enum values.
		# OPTIONAL
		severity = $someSyslogSeverity # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogSeverity]) for enum values.
	}
	# OPTIONAL
	syslogSettingsV91 = @{
		# OPTIONAL
		enableTls = $someBoolean
		# OPTIONAL
		hostname = $someString
		# OPTIONAL
		port = $someInt
		# OPTIONAL
		certificateId = $someString
		# OPTIONAL
		facility = $someSyslogFacility # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogFacility]) for enum values.
		# OPTIONAL
		protocol = $someTransportLayerProtocol # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TransportLayerProtocol]) for enum values.
		# OPTIONAL
		severity = $someSyslogSeverity # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SyslogSeverity]) for enum values.
	}
	# REQUIRED
	clusterUuid = $someString
	# REQUIRED
	id = $someString
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
                Mutation.UpdateTunnelStatus_ObjectFieldSpec,
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
                Mutation.UpdateVolumeGroup_ObjectFieldSpec,
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
                Mutation.UpdateWhitelistedAnalyzers_ObjectFieldSpec,
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
        // upgradeCdmManagedTarget(input: UpgradeCdmManagedTargetInput!): Void
        internal void InitMutationUpgradeCdmManagedTarget()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpgradeCdmManagedTargetInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpgradeCdmManagedTarget",
                "($input: UpgradeCdmManagedTargetInput!)",
                "System.String",
                Mutation.UpgradeCdmManagedTarget_ObjectFieldSpec,
                Mutation.UpgradeCdmManagedTargetFieldSpec,
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
                Mutation.UpgradeIoFilter_ObjectFieldSpec,
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
                Mutation.UpgradeToRsc_ObjectFieldSpec,
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
                Mutation.ValidateAndSaveCustomerKmsInfo_ObjectFieldSpec,
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
                Mutation.WarmSearchCache_ObjectFieldSpec,
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