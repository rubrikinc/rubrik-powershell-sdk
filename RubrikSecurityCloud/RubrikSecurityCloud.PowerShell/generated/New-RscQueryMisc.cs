// New-RscQueryMisc.cs
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
    /// Create a new RscQuery object for any of the 199
    /// operations in the 'Miscellaneous' API domain:
    /// ActiveCustomAnalyzers, AdGroupMembers, AdVolumeExports, AgentDeploymentSetting, AgentDeploymentSettings, AllowedOrgAdminOperations, AnalyzerGroups, AnalyzerUsages, AnomalyResultOpt, AnomalyResults, AnomalyResultsGrouped, AreMultiGeoBackupsEnabled, AuthorizationsForGlobalResource, AuthorizationsForObject, AuthorizationsForObjects, AwsComputeSettings, AzureResourceGroups, AzureSubnets, BackupThrottleSettings, BrowseCalendar, BrowseContacts, BrowseFolder, BrowseOnedrive, BrowseTeamsChannels, BrowseTeamsDrive, CdmGuestCredentials, CdmInventorySubHierarchyRoot, CdmOvaDetails, CdmVersionCheck, CdpVmsInfos, CheckCloudComputeConnectivityJobProgress, CheckLatestVersionMgmtAppExists, CloudDirectNasExport, CloudDirectNasNamespace, CloudDirectNasNamespaces, CloudDirectNasShare, CloudDirectShares, CloudDirectSites, CloudDirectSystems, ConfiguredGroupMembers, Crawl, Crawls, CrossAccountPairs, CurrentIpAddress, CurrentOrg, CurrentOrgAuthDomainConfig, CurrentOrgIdentityProviders, CustomAnalyzer, DashboardSummary, DatagovSecDesc, DecryptExportUrl, DeploymentIpAddresses, DeploymentVersion, DhrcActiveRecommendations, DhrcLatestMetrics, DhrcScores, DiffFmd, DiscoverNodes, DiscoveryTimeline, DistributionListDigest, DistributionListDigests, DummyFieldWithAdminOnlyTag, EdgeWindowsToolLink, EffectiveRbacPermissions, EventDigests, ExternalDeploymentName, FailedRestoreItemsInfo, FederatedLoginStatus, FileActivities, GeoLocationList, GetAllRolesInOrgList, GetCdmReleaseDetailsForVersionFromSupportPortal, GetCdmReleaseDetailsFromSupportPortal, GetGroupCountByPrechecksStatus, GetGroupCountByUpgradeJobStatus, GetGroupCountByVersionStatus, GetKorgTaskchainStatus, GetPermissions, GetRolesByIds, GetUserDownloads, GlobalFileSearch, GlobalLockoutConfig, GlobalMfaSetting, GlobalSearchResults, GroupsInCurrentAndDescendantOrganization, GuestCredentials, GuestCredentialsV2, HasIdpConfigured, HelpContentSnippets, HierarchyObject, HierarchyObjects, InstalledVersionList, InventoryRoot, InventorySubHierarchyRoot, InventoryWorkloads, InvestigationCsvDownloadLink, IpWhitelist, IsIpmiEnabled, IsLoggedIntoRubrikSupportPortal, IsReplaceNodeTprConfigured, IsSfdcReachable, IsUpgradeAvailable, IsUpgradeRecommended, IsZrsAvailableForLocation, Issue, Issues, IssuesJobIds, JobInfo, KnowledgeBaseArticle, LambdaSettings, LicensedProducts, LockoutConfig, MaxProtectedAppsCount, MfaSetting, MicrosoftSites, MinimumCdmVersionForFeatureSet, MipLabels, NetworkThrottle, NfAnomalyResults, NfAnomalyResultsGrouped, NodeRemovalCancelPermission, NodeToReplace, NodeTunnelStatuses, NosqlStorageLocations, OauthCodesForEdgeReg, ObjectFiles, ObjectTypeAccessSummary, ObjectsAlreadyAssignedToOrgs, Org, Orgs, OrgsByIds, OrgsForPrincipal, PasskeyConfig, PasskeyInfo, PendingAction, PendingActions, PhoenixRolloutProgress, PipelineHealthForTimeRange, PolarisInventorySubHierarchyRoot, PolicyDetails, PolicyObj, PolicyObjs, PrechecksStatus, PrechecksStatusWithNextJobInfo, PrivateContainerRegistry, ProductDocumentation, ProtectedObjectsList, ProtectedVolumesCount, QuarantinedDetailsForWorkload, QueryDatastoreFreespaceThresholds, RemovedNodeDetails, RoleTemplates, RscPermsToCdmInfo, SearchFileByPrefix, SnoozedDirectories, SsoGroupAlreadyExists, SupportBundle, SupportUserAccesses, TableFilters, Targets, TaskDetailGroupByList, TaskDetailList, Taskchain, TeamChannelNameAvailable, TotpConfigStatus, TprConfiguration, TprPublicConfiguration, TprRequestDetail, TprRequestSummaries, TprRoleEligibility, TprRulesMap, TprStatusForNodeRemoval, TunnelStatus, UniqueVcdCount, UnmanagedObjects, UnmanagedObjectsSupportedTypes, UpgradeStatus, UserActivities, UserAlreadyExists, UserAnalyzerAccess, UserAuditList, UserDetail, UserFile, UserFiles, UserGroups, UserNotifications, UserSessionManagementConfig, UserSettings, UsersInCurrentAndDescendantOrganization, UsersOnAccountList, ValidateOrgName, VcdVappVms, VerifyTotp, VirtualMachineFiles, VmRecoveryJobsInfo, VolumeGroupMounts, WorkloadAlertSetting, WorkloadAnomalies, or WorkloadForeverId.
    /// </summary>
    /// <description>
    /// New-RscQueryMisc creates a new
    /// query object for operations
    /// in the 'Miscellaneous' API domain. It only creates a data structure,
    /// it does not execute the operation. This cmdlet does not need a
    /// connection to run. To execute the operation, either call Invoke()
    /// on the object returned by this cmdlet, or pass the object to
    /// Invoke-Rsc.
    /// There are 199 operations
    /// in the 'Miscellaneous' API domain. Select the operation this
    /// query is for by specifying the appropriate value for the
    /// -Operation parameter;
    /// one of: ActiveCustomAnalyzers, AdGroupMembers, AdVolumeExports, AgentDeploymentSetting, AgentDeploymentSettings, AllowedOrgAdminOperations, AnalyzerGroups, AnalyzerUsages, AnomalyResultOpt, AnomalyResults, AnomalyResultsGrouped, AreMultiGeoBackupsEnabled, AuthorizationsForGlobalResource, AuthorizationsForObject, AuthorizationsForObjects, AwsComputeSettings, AzureResourceGroups, AzureSubnets, BackupThrottleSettings, BrowseCalendar, BrowseContacts, BrowseFolder, BrowseOnedrive, BrowseTeamsChannels, BrowseTeamsDrive, CdmGuestCredentials, CdmInventorySubHierarchyRoot, CdmOvaDetails, CdmVersionCheck, CdpVmsInfos, CheckCloudComputeConnectivityJobProgress, CheckLatestVersionMgmtAppExists, CloudDirectNasExport, CloudDirectNasNamespace, CloudDirectNasNamespaces, CloudDirectNasShare, CloudDirectShares, CloudDirectSites, CloudDirectSystems, ConfiguredGroupMembers, Crawl, Crawls, CrossAccountPairs, CurrentIpAddress, CurrentOrg, CurrentOrgAuthDomainConfig, CurrentOrgIdentityProviders, CustomAnalyzer, DashboardSummary, DatagovSecDesc, DecryptExportUrl, DeploymentIpAddresses, DeploymentVersion, DhrcActiveRecommendations, DhrcLatestMetrics, DhrcScores, DiffFmd, DiscoverNodes, DiscoveryTimeline, DistributionListDigest, DistributionListDigests, DummyFieldWithAdminOnlyTag, EdgeWindowsToolLink, EffectiveRbacPermissions, EventDigests, ExternalDeploymentName, FailedRestoreItemsInfo, FederatedLoginStatus, FileActivities, GeoLocationList, GetAllRolesInOrgList, GetCdmReleaseDetailsForVersionFromSupportPortal, GetCdmReleaseDetailsFromSupportPortal, GetGroupCountByPrechecksStatus, GetGroupCountByUpgradeJobStatus, GetGroupCountByVersionStatus, GetKorgTaskchainStatus, GetPermissions, GetRolesByIds, GetUserDownloads, GlobalFileSearch, GlobalLockoutConfig, GlobalMfaSetting, GlobalSearchResults, GroupsInCurrentAndDescendantOrganization, GuestCredentials, GuestCredentialsV2, HasIdpConfigured, HelpContentSnippets, HierarchyObject, HierarchyObjects, InstalledVersionList, InventoryRoot, InventorySubHierarchyRoot, InventoryWorkloads, InvestigationCsvDownloadLink, IpWhitelist, IsIpmiEnabled, IsLoggedIntoRubrikSupportPortal, IsReplaceNodeTprConfigured, IsSfdcReachable, IsUpgradeAvailable, IsUpgradeRecommended, IsZrsAvailableForLocation, Issue, Issues, IssuesJobIds, JobInfo, KnowledgeBaseArticle, LambdaSettings, LicensedProducts, LockoutConfig, MaxProtectedAppsCount, MfaSetting, MicrosoftSites, MinimumCdmVersionForFeatureSet, MipLabels, NetworkThrottle, NfAnomalyResults, NfAnomalyResultsGrouped, NodeRemovalCancelPermission, NodeToReplace, NodeTunnelStatuses, NosqlStorageLocations, OauthCodesForEdgeReg, ObjectFiles, ObjectTypeAccessSummary, ObjectsAlreadyAssignedToOrgs, Org, Orgs, OrgsByIds, OrgsForPrincipal, PasskeyConfig, PasskeyInfo, PendingAction, PendingActions, PhoenixRolloutProgress, PipelineHealthForTimeRange, PolarisInventorySubHierarchyRoot, PolicyDetails, PolicyObj, PolicyObjs, PrechecksStatus, PrechecksStatusWithNextJobInfo, PrivateContainerRegistry, ProductDocumentation, ProtectedObjectsList, ProtectedVolumesCount, QuarantinedDetailsForWorkload, QueryDatastoreFreespaceThresholds, RemovedNodeDetails, RoleTemplates, RscPermsToCdmInfo, SearchFileByPrefix, SnoozedDirectories, SsoGroupAlreadyExists, SupportBundle, SupportUserAccesses, TableFilters, Targets, TaskDetailGroupByList, TaskDetailList, Taskchain, TeamChannelNameAvailable, TotpConfigStatus, TprConfiguration, TprPublicConfiguration, TprRequestDetail, TprRequestSummaries, TprRoleEligibility, TprRulesMap, TprStatusForNodeRemoval, TunnelStatus, UniqueVcdCount, UnmanagedObjects, UnmanagedObjectsSupportedTypes, UpgradeStatus, UserActivities, UserAlreadyExists, UserAnalyzerAccess, UserAuditList, UserDetail, UserFile, UserFiles, UserGroups, UserNotifications, UserSessionManagementConfig, UserSettings, UsersInCurrentAndDescendantOrganization, UsersOnAccountList, ValidateOrgName, VcdVappVms, VerifyTotp, VirtualMachineFiles, VmRecoveryJobsInfo, VolumeGroupMounts, WorkloadAlertSetting, WorkloadAnomalies, or WorkloadForeverId.
    /// Each operation has its own set of variables that can be set with
    /// the -Var parameter. For more info about the variables, 
    /// call Info() on the object returned by this cmdlet, for example:
    /// (New-RscQueryMisc -ActiveCustomAnalyzers).Info().
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
    /// (New-RscQueryMisc -ActiveCustomAnalyzers).Info().
    /// You can combine a -Field parameter with patching parameters.
    /// -Field is applied first, then -FilePatch, -AddField and -RemoveField.
    ///
    /// </description>
    ///
    /// <example>
    /// Runs the ActiveCustomAnalyzers operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: ActiveCustomAnalyzers
    /// 
    /// $query = New-RscQueryMisc -Operation ActiveCustomAnalyzers
    /// 
    /// # No variables for this query.
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AnalyzerConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the AdGroupMembers operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: AdGroupMembers
    /// 
    /// $query = New-RscQueryMisc -Operation AdGroupMembers
    /// 
    /// # OPTIONAL
    /// $query.Var.first = $someInt
    /// # OPTIONAL
    /// $query.Var.after = $someString
    /// # REQUIRED
    /// $query.Var.orgId = $someString
    /// # REQUIRED
    /// $query.Var.adGroupSpec = @{
    /// 	# REQUIRED
    /// 	naturalId = $someString
    /// 	# OPTIONAL
    /// 	displayName = $someString
    /// 	# REQUIRED
    /// 	filterAttributes = @(
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
    /// Write-Host $result.GetType().Name # prints: O365AdGroupMemberConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the AdVolumeExports operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: AdVolumeExports
    /// 
    /// $query = New-RscQueryMisc -Operation AdVolumeExports
    /// 
    /// # OPTIONAL
    /// $query.Var.first = $someInt
    /// # OPTIONAL
    /// $query.Var.after = $someString
    /// # OPTIONAL
    /// $query.Var.filters = @(
    /// 	@{
    /// 		# OPTIONAL
    /// 		field = $someAdVolumeExportFilterField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AdVolumeExportFilterField]) for enum values.
    /// 		# OPTIONAL
    /// 		texts = @(
    /// 			$someString
    /// 		)
    /// }
    /// )
    /// # OPTIONAL
    /// $query.Var.sortBy = @{
    /// 	# OPTIONAL
    /// 	field = $someAdVolumeExportSortByField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AdVolumeExportSortByField]) for enum values.
    /// 	# OPTIONAL
    /// 	sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AdVolumeExportConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the AgentDeploymentSetting operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: AgentDeploymentSetting
    /// 
    /// $query = New-RscQueryMisc -Operation AgentDeploymentSetting
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
    /// Write-Host $result.GetType().Name # prints: AgentDeploymentSettings
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the AgentDeploymentSettings operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: AgentDeploymentSettings
    /// 
    /// $query = New-RscQueryMisc -Operation AgentDeploymentSettings
    /// 
    /// # REQUIRED
    /// $query.Var.clusterUuids = @(
    /// 	$someString
    /// )
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: List&lt;AgentDeploymentSettingsInfo&gt;
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the AllowedOrgAdminOperations operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: AllowedOrgAdminOperations
    /// 
    /// $query = New-RscQueryMisc -Operation AllowedOrgAdminOperations
    /// 
    /// # No variables for this query.
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: List&lt;Operation&gt;
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the AnalyzerGroups operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: AnalyzerGroups
    /// 
    /// $query = New-RscQueryMisc -Operation AnalyzerGroups
    /// 
    /// # No variables for this query.
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AnalyzerGroupConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the AnalyzerUsages operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: AnalyzerUsages
    /// 
    /// $query = New-RscQueryMisc -Operation AnalyzerUsages
    /// 
    /// # OPTIONAL
    /// $query.Var.dataCategoryIdsFilter = @(
    /// 	$someString
    /// )
    /// # OPTIONAL
    /// $query.Var.riskLevelsFilter = @(
    /// 	$someRiskLevelType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RiskLevelType]) for enum values.
    /// )
    /// # OPTIONAL
    /// $query.Var.sortBy = $someAnalyzerUsagesSortBy # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AnalyzerUsagesSortBy]) for enum values.
    /// # OPTIONAL
    /// $query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
    /// # OPTIONAL
    /// $query.Var.dataTypeSourceFilter = $someDataTypeSource # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DataTypeSource]) for enum values.
    /// # OPTIONAL
    /// $query.Var.dataTypeNameSearchFilter = $someString
    /// # OPTIONAL
    /// $query.Var.first = $someInt
    /// # OPTIONAL
    /// $query.Var.after = $someString
    /// # OPTIONAL
    /// $query.Var.last = $someInt
    /// # OPTIONAL
    /// $query.Var.before = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AnalyzerUsageConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the AnomalyResultOpt operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: AnomalyResultOpt
    /// 
    /// $query = New-RscQueryMisc -Operation AnomalyResultOpt
    /// 
    /// # OPTIONAL
    /// $query.Var.clusterUuid = $someString
    /// # OPTIONAL
    /// $query.Var.snapshotId = $someString
    /// # OPTIONAL
    /// $query.Var.workloadId = $someString
    /// # OPTIONAL
    /// $query.Var.anomalyId = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: GetAnomalyDetailsReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the AnomalyResults operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: AnomalyResults
    /// 
    /// $query = New-RscQueryMisc -Operation AnomalyResults
    /// 
    /// # OPTIONAL
    /// $query.Var.first = $someInt
    /// # OPTIONAL
    /// $query.Var.after = $someString
    /// # OPTIONAL
    /// $query.Var.last = $someInt
    /// # OPTIONAL
    /// $query.Var.before = $someString
    /// # OPTIONAL
    /// $query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
    /// # OPTIONAL
    /// $query.Var.sortBy = $someAnomalyResultSortBy # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AnomalyResultSortBy]) for enum values.
    /// # OPTIONAL
    /// $query.Var.filter = @{
    /// 	# OPTIONAL
    /// 	clusterUuid = @(
    /// 		$someString
    /// 	)
    /// 	# OPTIONAL
    /// 	managedId = @(
    /// 		$someString
    /// 	)
    /// 	# OPTIONAL
    /// 	startTime = $someDateTime
    /// 	# OPTIONAL
    /// 	endTime = $someDateTime
    /// 	# OPTIONAL
    /// 	isAnomaly = $someBoolean
    /// 	# OPTIONAL
    /// 	workloadFid = @(
    /// 		$someString
    /// 	)
    /// }
    /// # OPTIONAL
    /// $query.Var.timezoneOffset = $someSingle
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AnomalyResultConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the AnomalyResultsGrouped operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: AnomalyResultsGrouped
    /// 
    /// $query = New-RscQueryMisc -Operation AnomalyResultsGrouped
    /// 
    /// # OPTIONAL
    /// $query.Var.first = $someInt
    /// # OPTIONAL
    /// $query.Var.after = $someString
    /// # OPTIONAL
    /// $query.Var.last = $someInt
    /// # OPTIONAL
    /// $query.Var.before = $someString
    /// # REQUIRED
    /// $query.Var.groupBy = $someAnomalyResultGroupBy # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AnomalyResultGroupBy]) for enum values.
    /// # OPTIONAL
    /// $query.Var.filter = @{
    /// 	# OPTIONAL
    /// 	clusterUuid = @(
    /// 		$someString
    /// 	)
    /// 	# OPTIONAL
    /// 	managedId = @(
    /// 		$someString
    /// 	)
    /// 	# OPTIONAL
    /// 	startTime = $someDateTime
    /// 	# OPTIONAL
    /// 	endTime = $someDateTime
    /// 	# OPTIONAL
    /// 	isAnomaly = $someBoolean
    /// 	# OPTIONAL
    /// 	workloadFid = @(
    /// 		$someString
    /// 	)
    /// }
    /// # OPTIONAL
    /// $query.Var.timezoneOffset = $someSingle
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AnomalyResultGroupedDataConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the AreMultiGeoBackupsEnabled operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: AreMultiGeoBackupsEnabled
    /// 
    /// $query = New-RscQueryMisc -Operation AreMultiGeoBackupsEnabled
    /// 
    /// # REQUIRED
    /// $query.Var.orgId = $someString
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
    /// Runs the AuthorizationsForGlobalResource operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: AuthorizationsForGlobalResource
    /// 
    /// $query = New-RscQueryMisc -Operation AuthorizationsForGlobalResource
    /// 
    /// # No variables for this query.
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: List&lt;Operation&gt;
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the AuthorizationsForObject operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: AuthorizationsForObject
    /// 
    /// $query = New-RscQueryMisc -Operation AuthorizationsForObject
    /// 
    /// # REQUIRED
    /// $query.Var.fid = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: List&lt;Operation&gt;
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the AuthorizationsForObjects operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: AuthorizationsForObjects
    /// 
    /// $query = New-RscQueryMisc -Operation AuthorizationsForObjects
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
    /// Write-Host $result.GetType().Name # prints: List&lt;AuthorizedOperations&gt;
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the AwsComputeSettings operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: AwsComputeSettings
    /// 
    /// $query = New-RscQueryMisc -Operation AwsComputeSettings
    /// 
    /// # OPTIONAL
    /// $query.Var.sortBy = $someAwsCloudComputeSettingQuerySortByField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsCloudComputeSettingQuerySortByField]) for enum values.
    /// # OPTIONAL
    /// $query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
    /// # OPTIONAL
    /// $query.Var.filter = @(
    /// 	@{
    /// 		# OPTIONAL
    /// 		field = $someAwsCloudComputeSettingFilterField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsCloudComputeSettingFilterField]) for enum values.
    /// 		# OPTIONAL
    /// 		text = $someString
    /// }
    /// )
    /// # OPTIONAL
    /// $query.Var.contextFilter = $someContextFilterTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ContextFilterTypeEnum]) for enum values.
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: List&lt;AwsComputeSettings&gt;
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the AzureResourceGroups operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: AzureResourceGroups
    /// 
    /// $query = New-RscQueryMisc -Operation AzureResourceGroups
    /// 
    /// # REQUIRED
    /// $query.Var.cloudAccountId = $someString
    /// # REQUIRED
    /// $query.Var.azureRegion = $someString
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
    /// Runs the AzureSubnets operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: AzureSubnets
    /// 
    /// $query = New-RscQueryMisc -Operation AzureSubnets
    /// 
    /// # REQUIRED
    /// $query.Var.subnetRequest = @{
    /// 	# OPTIONAL
    /// 	cloudAccountId = $someString
    /// 	# OPTIONAL
    /// 	resourceGroup = $someString
    /// 	# OPTIONAL
    /// 	vnetName = $someString
    /// }
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
    /// Runs the BackupThrottleSettings operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: BackupThrottleSettings
    /// 
    /// $query = New-RscQueryMisc -Operation BackupThrottleSettings
    /// 
    /// # REQUIRED
    /// $query.Var.clusterUuids = @(
    /// 	$someString
    /// )
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: List&lt;BackupThrottleSetting&gt;
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the BrowseCalendar operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: BrowseCalendar
    /// 
    /// $query = New-RscQueryMisc -Operation BrowseCalendar
    /// 
    /// # OPTIONAL
    /// $query.Var.first = $someInt
    /// # OPTIONAL
    /// $query.Var.after = $someString
    /// # REQUIRED
    /// $query.Var.snappableFid = $someString
    /// # REQUIRED
    /// $query.Var.snapshotFid = $someString
    /// # REQUIRED
    /// $query.Var.folderId = $someString
    /// # REQUIRED
    /// $query.Var.orgId = $someString
    /// # OPTIONAL
    /// $query.Var.calendarSearchFilter = @{
    /// 	# OPTIONAL
    /// 	searchKeywordFilter = @{
    /// 		# OPTIONAL
    /// 		searchKeyword = $someString
    /// 		# OPTIONAL
    /// 		keywordType = $someCalendarSearchKeywordType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CalendarSearchKeywordType]) for enum values.
    /// 	}
    /// 	# OPTIONAL
    /// 	emailAddresses = @(
    /// 		@{
    /// 			# OPTIONAL
    /// 			emailAddress = $someString
    /// 			# OPTIONAL
    /// 			filterType = $someCalendarEmailAddressFilterType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CalendarEmailAddressFilterType]) for enum values.
    /// 		}
    /// 	)
    /// 	# OPTIONAL
    /// 	timerange = @{
    /// 		# OPTIONAL
    /// 		fromTime = $someDateTime
    /// 		# OPTIONAL
    /// 		untilTime = $someDateTime
    /// 	}
    /// 	# OPTIONAL
    /// 	searchObjectFilter = @{
    /// 		# OPTIONAL
    /// 		searchObjectType = $someO365CalendarSearchObjectType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.O365CalendarSearchObjectType]) for enum values.
    /// 	}
    /// 	# OPTIONAL
    /// 	recurrenceFilter = @{
    /// 		# OPTIONAL
    /// 		recurrenceType = $someCalendarRecurrenceType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CalendarRecurrenceType]) for enum values.
    /// 	}
    /// 	# OPTIONAL
    /// 	lambdaFilters = @{
    /// 		# OPTIONAL
    /// 		enableAbsolutePaths = $someBoolean
    /// 		# OPTIONAL
    /// 		enableAbsolutePathCachePreload = $someBoolean
    /// 		# OPTIONAL
    /// 		parentFolderIdBatch = @(
    /// 			$someString
    /// 		)
    /// 		# OPTIONAL
    /// 		searchRecurseFolderId = $someString
    /// 		# OPTIONAL
    /// 		includeAncestors = $someBoolean
    /// 	}
    /// 	# OPTIONAL
    /// 	skipRifItems = $someBoolean
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: O365ExchangeObjectConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the BrowseContacts operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: BrowseContacts
    /// 
    /// $query = New-RscQueryMisc -Operation BrowseContacts
    /// 
    /// # OPTIONAL
    /// $query.Var.first = $someInt
    /// # OPTIONAL
    /// $query.Var.after = $someString
    /// # REQUIRED
    /// $query.Var.snappableFid = $someString
    /// # REQUIRED
    /// $query.Var.snapshotFid = $someString
    /// # REQUIRED
    /// $query.Var.folderId = $someString
    /// # REQUIRED
    /// $query.Var.orgId = $someString
    /// # OPTIONAL
    /// $query.Var.contactsSearchFilter = @{
    /// 	# OPTIONAL
    /// 	searchKeywordFilter = @{
    /// 		# OPTIONAL
    /// 		searchKeyword = $someString
    /// 	}
    /// 	# OPTIONAL
    /// 	searchObjectFilter = @{
    /// 		# OPTIONAL
    /// 		searchObjectType = $someO365ContactsSearchObjectType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.O365ContactsSearchObjectType]) for enum values.
    /// 	}
    /// 	# OPTIONAL
    /// 	lambdaFilters = @{
    /// 		# OPTIONAL
    /// 		enableAbsolutePaths = $someBoolean
    /// 		# OPTIONAL
    /// 		enableAbsolutePathCachePreload = $someBoolean
    /// 		# OPTIONAL
    /// 		parentFolderIdBatch = @(
    /// 			$someString
    /// 		)
    /// 		# OPTIONAL
    /// 		searchRecurseFolderId = $someString
    /// 		# OPTIONAL
    /// 		includeAncestors = $someBoolean
    /// 	}
    /// 	# OPTIONAL
    /// 	skipRifItems = $someBoolean
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: O365ExchangeObjectConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the BrowseFolder operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: BrowseFolder
    /// 
    /// $query = New-RscQueryMisc -Operation BrowseFolder
    /// 
    /// # OPTIONAL
    /// $query.Var.first = $someInt
    /// # OPTIONAL
    /// $query.Var.after = $someString
    /// # REQUIRED
    /// $query.Var.snappableFid = $someString
    /// # REQUIRED
    /// $query.Var.snapshotFid = $someString
    /// # REQUIRED
    /// $query.Var.folderId = $someString
    /// # REQUIRED
    /// $query.Var.orgId = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: O365ExchangeObjectConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the BrowseOnedrive operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: BrowseOnedrive
    /// 
    /// $query = New-RscQueryMisc -Operation BrowseOnedrive
    /// 
    /// # OPTIONAL
    /// $query.Var.first = $someInt
    /// # OPTIONAL
    /// $query.Var.after = $someString
    /// # REQUIRED
    /// $query.Var.snappableFid = $someString
    /// # REQUIRED
    /// $query.Var.snapshotFid = $someString
    /// # OPTIONAL
    /// $query.Var.folderId = $someString
    /// # OPTIONAL
    /// $query.Var.onedriveSearchFilter = @{
    /// 	# OPTIONAL
    /// 	searchKeywordFilter = @{
    /// 		# OPTIONAL
    /// 		searchKeyword = $someString
    /// 		# OPTIONAL
    /// 		keywordType = $someOnedriveSearchKeywordType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.OnedriveSearchKeywordType]) for enum values.
    /// 	}
    /// 	# OPTIONAL
    /// 	modifiedTime = @{
    /// 		# OPTIONAL
    /// 		fromTime = $someDateTime
    /// 		# OPTIONAL
    /// 		untilTime = $someDateTime
    /// 	}
    /// 	# OPTIONAL
    /// 	createTime = @{
    /// 		# OPTIONAL
    /// 		fromTime = $someDateTime
    /// 		# OPTIONAL
    /// 		untilTime = $someDateTime
    /// 	}
    /// 	# OPTIONAL
    /// 	searchObjectFilter = @{
    /// 		# OPTIONAL
    /// 		searchObjectType = $someOnedriveSearchObjectType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.OnedriveSearchObjectType]) for enum values.
    /// 	}
    /// 	# OPTIONAL
    /// 	channelId = $someString
    /// 	# OPTIONAL
    /// 	channelFolderName = $someString
    /// 	# OPTIONAL
    /// 	channelMembershipType = $someChannelMembershipType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ChannelMembershipType]) for enum values.
    /// 	# OPTIONAL
    /// 	excludeItemsUnderRoot = $someBoolean
    /// 	# OPTIONAL
    /// 	channelNameKeyword = $someString
    /// 	# OPTIONAL
    /// 	useExactVersionMatch = $someBoolean
    /// 	# OPTIONAL
    /// 	lambdaFilters = @{
    /// 		# OPTIONAL
    /// 		enableAbsolutePaths = $someBoolean
    /// 		# OPTIONAL
    /// 		enableAbsolutePathCachePreload = $someBoolean
    /// 		# OPTIONAL
    /// 		parentFolderIdBatch = @(
    /// 			$someString
    /// 		)
    /// 		# OPTIONAL
    /// 		searchRecurseFolderId = $someString
    /// 		# OPTIONAL
    /// 		includeAncestors = $someBoolean
    /// 	}
    /// }
    /// # REQUIRED
    /// $query.Var.orgId = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: O365OnedriveObjectConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the BrowseTeamsChannels operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: BrowseTeamsChannels
    /// 
    /// $query = New-RscQueryMisc -Operation BrowseTeamsChannels
    /// 
    /// # OPTIONAL
    /// $query.Var.first = $someInt
    /// # OPTIONAL
    /// $query.Var.after = $someString
    /// # REQUIRED
    /// $query.Var.snappableFid = $someString
    /// # REQUIRED
    /// $query.Var.snapshotFid = $someString
    /// # REQUIRED
    /// $query.Var.orgId = $someString
    /// # REQUIRED
    /// $query.Var.channelMembershipTypeFilter = $someChannelMembershipType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ChannelMembershipType]) for enum values.
    /// # OPTIONAL
    /// $query.Var.nameFilter = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: O365TeamsChannelConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the BrowseTeamsDrive operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: BrowseTeamsDrive
    /// 
    /// $query = New-RscQueryMisc -Operation BrowseTeamsDrive
    /// 
    /// # OPTIONAL
    /// $query.Var.first = $someInt
    /// # OPTIONAL
    /// $query.Var.after = $someString
    /// # REQUIRED
    /// $query.Var.snappableFid = $someString
    /// # REQUIRED
    /// $query.Var.snapshotFid = $someString
    /// # OPTIONAL
    /// $query.Var.folderId = $someString
    /// # OPTIONAL
    /// $query.Var.teamsDriveSearchFilter = @{
    /// 	# OPTIONAL
    /// 	searchKeywordFilter = @{
    /// 		# OPTIONAL
    /// 		searchKeyword = $someString
    /// 		# OPTIONAL
    /// 		keywordType = $someOnedriveSearchKeywordType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.OnedriveSearchKeywordType]) for enum values.
    /// 	}
    /// 	# OPTIONAL
    /// 	modifiedTime = @{
    /// 		# OPTIONAL
    /// 		fromTime = $someDateTime
    /// 		# OPTIONAL
    /// 		untilTime = $someDateTime
    /// 	}
    /// 	# OPTIONAL
    /// 	createTime = @{
    /// 		# OPTIONAL
    /// 		fromTime = $someDateTime
    /// 		# OPTIONAL
    /// 		untilTime = $someDateTime
    /// 	}
    /// 	# OPTIONAL
    /// 	searchObjectFilter = @{
    /// 		# OPTIONAL
    /// 		searchObjectType = $someOnedriveSearchObjectType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.OnedriveSearchObjectType]) for enum values.
    /// 	}
    /// 	# OPTIONAL
    /// 	channelId = $someString
    /// 	# OPTIONAL
    /// 	channelFolderName = $someString
    /// 	# OPTIONAL
    /// 	channelMembershipType = $someChannelMembershipType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ChannelMembershipType]) for enum values.
    /// 	# OPTIONAL
    /// 	excludeItemsUnderRoot = $someBoolean
    /// 	# OPTIONAL
    /// 	channelNameKeyword = $someString
    /// 	# OPTIONAL
    /// 	useExactVersionMatch = $someBoolean
    /// 	# OPTIONAL
    /// 	lambdaFilters = @{
    /// 		# OPTIONAL
    /// 		enableAbsolutePaths = $someBoolean
    /// 		# OPTIONAL
    /// 		enableAbsolutePathCachePreload = $someBoolean
    /// 		# OPTIONAL
    /// 		parentFolderIdBatch = @(
    /// 			$someString
    /// 		)
    /// 		# OPTIONAL
    /// 		searchRecurseFolderId = $someString
    /// 		# OPTIONAL
    /// 		includeAncestors = $someBoolean
    /// 	}
    /// }
    /// # REQUIRED
    /// $query.Var.orgId = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: O365OnedriveObjectConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CdmGuestCredentials operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: CdmGuestCredentials
    /// 
    /// $query = New-RscQueryMisc -Operation CdmGuestCredentials
    /// 
    /// # REQUIRED
    /// $query.Var.clusterUuids = @(
    /// 	$someString
    /// )
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: List&lt;CdmGuestCredential&gt;
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CdmInventorySubHierarchyRoot operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: CdmInventorySubHierarchyRoot
    /// 
    /// $query = New-RscQueryMisc -Operation CdmInventorySubHierarchyRoot
    /// 
    /// # REQUIRED
    /// $query.Var.rootEnum = $someInventorySubHierarchyRootEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.InventorySubHierarchyRootEnum]) for enum values.
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: CdmInventorySubHierarchyRoot
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CdmOvaDetails operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: CdmOvaDetails
    /// 
    /// $query = New-RscQueryMisc -Operation CdmOvaDetails
    /// 
    /// # No variables for this query.
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: List&lt;CdmOvaDetail&gt;
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CdmVersionCheck operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: CdmVersionCheck
    /// 
    /// $query = New-RscQueryMisc -Operation CdmVersionCheck
    /// 
    /// # REQUIRED
    /// $query.Var.featureToCdmVersion = @{
    /// 	# REQUIRED
    /// 	clusterUuid = $someString
    /// 	# REQUIRED
    /// 	featureType = $someCdmFeatureFlagType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CdmFeatureFlagType]) for enum values.
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: FeatureCdmVersionReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CdpVmsInfos operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: CdpVmsInfos
    /// 
    /// $query = New-RscQueryMisc -Operation CdpVmsInfos
    /// 
    /// # OPTIONAL
    /// $query.Var.first = $someInt
    /// # OPTIONAL
    /// $query.Var.after = $someString
    /// # OPTIONAL
    /// $query.Var.last = $someInt
    /// # OPTIONAL
    /// $query.Var.before = $someString
    /// # OPTIONAL
    /// $query.Var.allCdpVmInfoSort = @{
    /// 	# OPTIONAL
    /// 	type = $someCdpPerfDashboardSortType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CdpPerfDashboardSortType]) for enum values.
    /// 	# OPTIONAL
    /// 	sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
    /// }
    /// # OPTIONAL
    /// $query.Var.allCdpVmInfoFilter = @(
    /// 	@{
    /// 		# OPTIONAL
    /// 		filterField = $someCdpPerfDashboardFilterField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CdpPerfDashboardFilterField]) for enum values.
    /// 		# OPTIONAL
    /// 		sourceClusterUuids = @(
    /// 			$someString
    /// 		)
    /// 		# OPTIONAL
    /// 		slaDomainIds = @(
    /// 			$someString
    /// 		)
    /// 		# OPTIONAL
    /// 		localStatus = @(
    /// 			$someCdpLocalStatus # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CdpLocalStatus]) for enum values.
    /// 		)
    /// 		# OPTIONAL
    /// 		replicationStatus = @(
    /// 			$someCdpReplicationStatus # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CdpReplicationStatus]) for enum values.
    /// 		)
    /// 		# OPTIONAL
    /// 		cdpIoFilterStatus = @(
    /// 			$someIoFilterStatus # Call [Enum]::GetValues([RubrikSecurityCloud.Types.IoFilterStatus]) for enum values.
    /// 		)
    /// 		# OPTIONAL
    /// 		vmName = $someString
    /// }
    /// )
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: CdpVmInfoConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CheckCloudComputeConnectivityJobProgress operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: CheckCloudComputeConnectivityJobProgress
    /// 
    /// $query = New-RscQueryMisc -Operation CheckCloudComputeConnectivityJobProgress
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
    /// Runs the CheckLatestVersionMgmtAppExists operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: CheckLatestVersionMgmtAppExists
    /// 
    /// $query = New-RscQueryMisc -Operation CheckLatestVersionMgmtAppExists
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	o365OrgId = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: CheckLatestVersionMgmtAppExistsReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CloudDirectNasExport operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: CloudDirectNasExport
    /// 
    /// $query = New-RscQueryMisc -Operation CloudDirectNasExport
    /// 
    /// # REQUIRED
    /// $query.Var.fid = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: CloudDirectNasExport
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CloudDirectNasNamespace operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: CloudDirectNasNamespace
    /// 
    /// $query = New-RscQueryMisc -Operation CloudDirectNasNamespace
    /// 
    /// # REQUIRED
    /// $query.Var.fid = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: CloudDirectNasNamespace
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CloudDirectNasNamespaces operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: CloudDirectNasNamespaces
    /// 
    /// $query = New-RscQueryMisc -Operation CloudDirectNasNamespaces
    /// 
    /// # OPTIONAL
    /// $query.Var.first = $someInt
    /// # OPTIONAL
    /// $query.Var.after = $someString
    /// # OPTIONAL
    /// $query.Var.sortBy = $someHierarchySortByField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchySortByField]) for enum values.
    /// # OPTIONAL
    /// $query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
    /// # OPTIONAL
    /// $query.Var.filter = @(
    /// 	@{
    /// 		# OPTIONAL
    /// 		field = $someHierarchyFilterField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchyFilterField]) for enum values.
    /// 		# OPTIONAL
    /// 		texts = @(
    /// 			$someString
    /// 		)
    /// 		# OPTIONAL
    /// 		tagFilterParams = @(
    /// 			@{
    /// 				# OPTIONAL
    /// 				filterType = $someTagFilterType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TagFilterType]) for enum values.
    /// 				# OPTIONAL
    /// 				tagKey = $someString
    /// 				# OPTIONAL
    /// 				tagValue = $someString
    /// 			}
    /// 		)
    /// 		# OPTIONAL
    /// 		objectTypeFilterParams = @(
    /// 			$someManagedObjectType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ManagedObjectType]) for enum values.
    /// 		)
    /// 		# OPTIONAL
    /// 		awsNativeProtectionFeatureNames = @(
    /// 			$someAwsNativeProtectionFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeProtectionFeature]) for enum values.
    /// 		)
    /// 		# OPTIONAL
    /// 		isNegative = $someBoolean
    /// 		# OPTIONAL
    /// 		isSlowSearchEnabled = $someBoolean
    /// 		# OPTIONAL
    /// 		azureNativeProtectionFeatureNames = @(
    /// 			$someAzureNativeProtectionFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeProtectionFeature]) for enum values.
    /// 		)
    /// 		# OPTIONAL
    /// 		unmanagedObjectAvailabilityFilter = @(
    /// 			$someUnmanagedObjectAvailabilityFilter # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UnmanagedObjectAvailabilityFilter]) for enum values.
    /// 		)
    /// }
    /// )
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: CloudDirectNasNamespaceConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CloudDirectNasShare operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: CloudDirectNasShare
    /// 
    /// $query = New-RscQueryMisc -Operation CloudDirectNasShare
    /// 
    /// # REQUIRED
    /// $query.Var.fid = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: CloudDirectNasShare
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CloudDirectShares operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: CloudDirectShares
    /// 
    /// $query = New-RscQueryMisc -Operation CloudDirectShares
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	systemName = $someString
    /// 	# REQUIRED
    /// 	exportType = $someShareTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ShareTypeEnum]) for enum values.
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: List&lt;ShareExportIdPair&gt;
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CloudDirectSites operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: CloudDirectSites
    /// 
    /// $query = New-RscQueryMisc -Operation CloudDirectSites
    /// 
    /// # No variables for this query.
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: List&lt;CloudDirectSite&gt;
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CloudDirectSystems operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: CloudDirectSystems
    /// 
    /// $query = New-RscQueryMisc -Operation CloudDirectSystems
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
    /// Write-Host $result.GetType().Name # prints: CloudDirectSystems
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the ConfiguredGroupMembers operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: ConfiguredGroupMembers
    /// 
    /// $query = New-RscQueryMisc -Operation ConfiguredGroupMembers
    /// 
    /// # OPTIONAL
    /// $query.Var.first = $someInt
    /// # OPTIONAL
    /// $query.Var.after = $someString
    /// # REQUIRED
    /// $query.Var.orgId = $someString
    /// # OPTIONAL
    /// $query.Var.wildcard = $someString
    /// # REQUIRED
    /// $query.Var.pdls = @(
    /// 	$someString
    /// )
    /// # OPTIONAL
    /// $query.Var.workloadHierarchy = $someWorkloadLevelHierarchy # Call [Enum]::GetValues([RubrikSecurityCloud.Types.WorkloadLevelHierarchy]) for enum values.
    /// # OPTIONAL
    /// $query.Var.groupFilterAttributes = @(
    /// 	@{
    /// 		# OPTIONAL
    /// 		filterOpType = $someJoinOpType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.JoinOpType]) for enum values.
    /// 		# OPTIONAL
    /// 		attributeType = $someAttributeType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AttributeType]) for enum values.
    /// 		# OPTIONAL
    /// 		attributeKey = $someString
    /// 		# OPTIONAL
    /// 		attributeValue = $someString
    /// 		# OPTIONAL
    /// 		dataType = $someAttributeDataType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AttributeDataType]) for enum values.
    /// }
    /// )
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: O365ConfiguredGroupMemberConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the Crawl operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: Crawl
    /// 
    /// $query = New-RscQueryMisc -Operation Crawl
    /// 
    /// # REQUIRED
    /// $query.Var.crawlId = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: Crawl
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the Crawls operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: Crawls
    /// 
    /// $query = New-RscQueryMisc -Operation Crawls
    /// 
    /// # No variables for this query.
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: CrawlConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CrossAccountPairs operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: CrossAccountPairs
    /// 
    /// $query = New-RscQueryMisc -Operation CrossAccountPairs
    /// 
    /// # OPTIONAL
    /// $query.Var.first = $someInt
    /// # OPTIONAL
    /// $query.Var.after = $someString
    /// # OPTIONAL
    /// $query.Var.last = $someInt
    /// # OPTIONAL
    /// $query.Var.before = $someString
    /// # OPTIONAL
    /// $query.Var.sortBy = $someGetCrossAccountPairsSortByField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.GetCrossAccountPairsSortByField]) for enum values.
    /// # OPTIONAL
    /// $query.Var.filter = @(
    /// 	@{
    /// 		# OPTIONAL
    /// 		field = $someGetCrossAccountPairsFilterField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.GetCrossAccountPairsFilterField]) for enum values.
    /// 		# OPTIONAL
    /// 		text = $someString
    /// }
    /// )
    /// # OPTIONAL
    /// $query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: CrossAccountPairInfoConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CurrentIpAddress operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: CurrentIpAddress
    /// 
    /// $query = New-RscQueryMisc -Operation CurrentIpAddress
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
    /// Runs the CurrentOrg operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: CurrentOrg
    /// 
    /// $query = New-RscQueryMisc -Operation CurrentOrg
    /// 
    /// # No variables for this query.
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: Org
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CurrentOrgAuthDomainConfig operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: CurrentOrgAuthDomainConfig
    /// 
    /// $query = New-RscQueryMisc -Operation CurrentOrgAuthDomainConfig
    /// 
    /// # No variables for this query.
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: TenantAuthDomainConfig
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CurrentOrgIdentityProviders operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: CurrentOrgIdentityProviders
    /// 
    /// $query = New-RscQueryMisc -Operation CurrentOrgIdentityProviders
    /// 
    /// # No variables for this query.
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: List&lt;IdentityProvider&gt;
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CustomAnalyzer operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: CustomAnalyzer
    /// 
    /// $query = New-RscQueryMisc -Operation CustomAnalyzer
    /// 
    /// # REQUIRED
    /// $query.Var.analyzerId = $someString
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
    /// Runs the DashboardSummary operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: DashboardSummary
    /// 
    /// $query = New-RscQueryMisc -Operation DashboardSummary
    /// 
    /// # REQUIRED
    /// $query.Var.getWhitelistedResults = $someBoolean
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: GetDashboardSummaryReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the DatagovSecDesc operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: DatagovSecDesc
    /// 
    /// $query = New-RscQueryMisc -Operation DatagovSecDesc
    /// 
    /// # REQUIRED
    /// $query.Var.snappableFid = $someString
    /// # REQUIRED
    /// $query.Var.snapshotFid = $someString
    /// # REQUIRED
    /// $query.Var.stdPath = $someString
    /// # OPTIONAL
    /// $query.Var.skipResolveSids = $someBoolean
    /// # OPTIONAL
    /// $query.Var.filters = @{
    /// 	# OPTIONAL
    /// 	resultsForSid = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: QuerySddlReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the DecryptExportUrl operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: DecryptExportUrl
    /// 
    /// $query = New-RscQueryMisc -Operation DecryptExportUrl
    /// 
    /// # REQUIRED
    /// $query.Var.workloadFid = $someString
    /// # REQUIRED
    /// $query.Var.exportUrlSpecsEnc = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: ExportUrlSpecs
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the DeploymentIpAddresses operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: DeploymentIpAddresses
    /// 
    /// $query = New-RscQueryMisc -Operation DeploymentIpAddresses
    /// 
    /// # No variables for this query.
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
    /// Runs the DeploymentVersion operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: DeploymentVersion
    /// 
    /// $query = New-RscQueryMisc -Operation DeploymentVersion
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
    /// Runs the DhrcActiveRecommendations operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: DhrcActiveRecommendations
    /// 
    /// $query = New-RscQueryMisc -Operation DhrcActiveRecommendations
    /// 
    /// # OPTIONAL
    /// $query.Var.categories = @(
    /// 	$someDhrcCategory # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DhrcCategory]) for enum values.
    /// )
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: List&lt;DhrcActiveRecommendation&gt;
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the DhrcLatestMetrics operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: DhrcLatestMetrics
    /// 
    /// $query = New-RscQueryMisc -Operation DhrcLatestMetrics
    /// 
    /// # OPTIONAL
    /// $query.Var.categories = @(
    /// 	$someDhrcCategory # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DhrcCategory]) for enum values.
    /// )
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: List&lt;DhrcCollectedMetric&gt;
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the DhrcScores operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: DhrcScores
    /// 
    /// $query = New-RscQueryMisc -Operation DhrcScores
    /// 
    /// # OPTIONAL
    /// $query.Var.categories = @(
    /// 	$someDhrcCategory # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DhrcCategory]) for enum values.
    /// )
    /// # OPTIONAL
    /// $query.Var.beginTime = $someDateTime
    /// # OPTIONAL
    /// $query.Var.timespan = $someDhrcScoreTimespan # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DhrcScoreTimespan]) for enum values.
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: List&lt;DhrcScore&gt;
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the DiffFmd operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: DiffFmd
    /// 
    /// $query = New-RscQueryMisc -Operation DiffFmd
    /// 
    /// # REQUIRED
    /// $query.Var.clusterUuid = $someString
    /// # REQUIRED
    /// $query.Var.managedId = $someString
    /// # REQUIRED
    /// $query.Var.snapshotId = $someString
    /// # REQUIRED
    /// $query.Var.browseDiffPath = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: DiffResult
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the DiscoverNodes operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: DiscoverNodes
    /// 
    /// $query = New-RscQueryMisc -Operation DiscoverNodes
    /// 
    /// # REQUIRED
    /// $query.Var.id = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: BootstrappableNodeInfoListResponse
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the DiscoveryTimeline operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: DiscoveryTimeline
    /// 
    /// $query = New-RscQueryMisc -Operation DiscoveryTimeline
    /// 
    /// # REQUIRED
    /// $query.Var.startDay = $someString
    /// # REQUIRED
    /// $query.Var.endDay = $someString
    /// # REQUIRED
    /// $query.Var.timezone = $someString
    /// # REQUIRED
    /// $query.Var.getWhitelistedResults = $someBoolean
    /// # REQUIRED
    /// $query.Var.workloadTypes = @(
    /// 	$someDataGovObjectType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DataGovObjectType]) for enum values.
    /// )
    /// # OPTIONAL
    /// $query.Var.useOptimisedDiscoveryTimeline = $someBoolean
    /// # OPTIONAL
    /// $query.Var.subscriptionIdsFilter = @(
    /// 	$someString
    /// )
    /// # OPTIONAL
    /// $query.Var.objectIdsFilter = @(
    /// 	$someString
    /// )
    /// # OPTIONAL
    /// $query.Var.platformCategoryFilter = @(
    /// 	$somePlatformCategory # Call [Enum]::GetValues([RubrikSecurityCloud.Types.PlatformCategory]) for enum values.
    /// )
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: GetPoliciesTimelineReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the DistributionListDigest operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: DistributionListDigest
    /// 
    /// $query = New-RscQueryMisc -Operation DistributionListDigest
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	digestId = $someInt
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: EventDigest
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the DistributionListDigests operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: DistributionListDigests
    /// 
    /// $query = New-RscQueryMisc -Operation DistributionListDigests
    /// 
    /// # No variables for this query.
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: List&lt;EventDigest&gt;
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the DummyFieldWithAdminOnlyTag operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: DummyFieldWithAdminOnlyTag
    /// 
    /// $query = New-RscQueryMisc -Operation DummyFieldWithAdminOnlyTag
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
    /// Runs the EdgeWindowsToolLink operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: EdgeWindowsToolLink
    /// 
    /// $query = New-RscQueryMisc -Operation EdgeWindowsToolLink
    /// 
    /// # No variables for this query.
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: EdgeWindowsToolLink
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the EffectiveRbacPermissions operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: EffectiveRbacPermissions
    /// 
    /// $query = New-RscQueryMisc -Operation EffectiveRbacPermissions
    /// 
    /// # REQUIRED
    /// $query.Var.roleId = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: List&lt;RbacPermission&gt;
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the EventDigests operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: EventDigests
    /// 
    /// $query = New-RscQueryMisc -Operation EventDigests
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
    /// Write-Host $result.GetType().Name # prints: List&lt;EventDigest&gt;
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the ExternalDeploymentName operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: ExternalDeploymentName
    /// 
    /// $query = New-RscQueryMisc -Operation ExternalDeploymentName
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
    /// Runs the FailedRestoreItemsInfo operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: FailedRestoreItemsInfo
    /// 
    /// $query = New-RscQueryMisc -Operation FailedRestoreItemsInfo
    /// 
    /// # REQUIRED
    /// $query.Var.workloadFid = $someString
    /// # REQUIRED
    /// $query.Var.failedItemsInstanceId = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: FailedRestoreItemsInfoReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the FederatedLoginStatus operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: FederatedLoginStatus
    /// 
    /// $query = New-RscQueryMisc -Operation FederatedLoginStatus
    /// 
    /// # No variables for this query.
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: FederatedLoginStatus
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the FileActivities operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: FileActivities
    /// 
    /// $query = New-RscQueryMisc -Operation FileActivities
    /// 
    /// # REQUIRED
    /// $query.Var.ListFileActivitiesInput = @{
    /// 	# REQUIRED
    /// 	snappableFid = $someString
    /// 	# REQUIRED
    /// 	stdPath = $someString
    /// 	# REQUIRED
    /// 	startDateTime = $someString
    /// 	# REQUIRED
    /// 	timezone = $someString
    /// }
    /// # REQUIRED
    /// $query.Var.FileActivitiesSort = @{
    /// 	# OPTIONAL
    /// 	sortBy = $someFileActivitiesSortBy # Call [Enum]::GetValues([RubrikSecurityCloud.Types.FileActivitiesSortBy]) for enum values.
    /// 	# OPTIONAL
    /// 	sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
    /// }
    /// # OPTIONAL
    /// $query.Var.first = $someInt
    /// # OPTIONAL
    /// $query.Var.after = $someString
    /// # OPTIONAL
    /// $query.Var.last = $someInt
    /// # OPTIONAL
    /// $query.Var.before = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: UserActivityResultConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the GeoLocationList operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: GeoLocationList
    /// 
    /// $query = New-RscQueryMisc -Operation GeoLocationList
    /// 
    /// # No variables for this query.
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: List&lt;GroupCount&gt;
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the GetAllRolesInOrgList operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: GetAllRolesInOrgList
    /// 
    /// $query = New-RscQueryMisc -Operation GetAllRolesInOrgList
    /// 
    /// # OPTIONAL
    /// $query.Var.first = $someInt
    /// # OPTIONAL
    /// $query.Var.after = $someString
    /// # OPTIONAL
    /// $query.Var.last = $someInt
    /// # OPTIONAL
    /// $query.Var.before = $someString
    /// # OPTIONAL
    /// $query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
    /// # OPTIONAL
    /// $query.Var.sortBy = $someRoleFieldEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RoleFieldEnum]) for enum values.
    /// # OPTIONAL
    /// $query.Var.nameFilter = $someString
    /// # OPTIONAL
    /// $query.Var.assignedRoleIds = @(
    /// 	$someString
    /// )
    /// # OPTIONAL
    /// $query.Var.roleSyncedFilter = $someBoolean
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: RoleConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the GetCdmReleaseDetailsForVersionFromSupportPortal operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: GetCdmReleaseDetailsForVersionFromSupportPortal
    /// 
    /// $query = New-RscQueryMisc -Operation GetCdmReleaseDetailsForVersionFromSupportPortal
    /// 
    /// # REQUIRED
    /// $query.Var.listClusterUuid = @(
    /// 	$someString
    /// )
    /// # REQUIRED
    /// $query.Var.filterVersion = $someString
    /// # REQUIRED
    /// $query.Var.fetchLinks = $someBoolean
    /// # REQUIRED
    /// $query.Var.filterUpgradeable = $someBoolean
    /// # REQUIRED
    /// $query.Var.shouldShowAll = $someBoolean
    /// # REQUIRED
    /// $query.Var.filterAfterSource = $someBoolean
    /// # OPTIONAL
    /// $query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: CdmUpgradeReleaseDetailsFromSupportPortalReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the GetCdmReleaseDetailsFromSupportPortal operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: GetCdmReleaseDetailsFromSupportPortal
    /// 
    /// $query = New-RscQueryMisc -Operation GetCdmReleaseDetailsFromSupportPortal
    /// 
    /// # REQUIRED
    /// $query.Var.platform = $someString
    /// # REQUIRED
    /// $query.Var.nodeCount = $someInt64
    /// # REQUIRED
    /// $query.Var.sourceVersion = $someString
    /// # REQUIRED
    /// $query.Var.filterVersion = $someString
    /// # REQUIRED
    /// $query.Var.fetchLinks = $someBoolean
    /// # REQUIRED
    /// $query.Var.filterUpgradeable = $someBoolean
    /// # REQUIRED
    /// $query.Var.shouldShowAll = $someBoolean
    /// # REQUIRED
    /// $query.Var.filterAfterSource = $someBoolean
    /// # OPTIONAL
    /// $query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: CdmUpgradeReleaseDetailsFromSupportPortalReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the GetGroupCountByPrechecksStatus operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: GetGroupCountByPrechecksStatus
    /// 
    /// $query = New-RscQueryMisc -Operation GetGroupCountByPrechecksStatus
    /// 
    /// # No variables for this query.
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: List&lt;GroupCount&gt;
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the GetGroupCountByUpgradeJobStatus operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: GetGroupCountByUpgradeJobStatus
    /// 
    /// $query = New-RscQueryMisc -Operation GetGroupCountByUpgradeJobStatus
    /// 
    /// # No variables for this query.
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: List&lt;GroupCount&gt;
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the GetGroupCountByVersionStatus operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: GetGroupCountByVersionStatus
    /// 
    /// $query = New-RscQueryMisc -Operation GetGroupCountByVersionStatus
    /// 
    /// # No variables for this query.
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: List&lt;GroupCount&gt;
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the GetKorgTaskchainStatus operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: GetKorgTaskchainStatus
    /// 
    /// $query = New-RscQueryMisc -Operation GetKorgTaskchainStatus
    /// 
    /// # REQUIRED
    /// $query.Var.taskchainId = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: GetTaskchainStatusReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the GetPermissions operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: GetPermissions
    /// 
    /// $query = New-RscQueryMisc -Operation GetPermissions
    /// 
    /// # REQUIRED
    /// $query.Var.roleId = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: List&lt;Permission&gt;
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the GetRolesByIds operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: GetRolesByIds
    /// 
    /// $query = New-RscQueryMisc -Operation GetRolesByIds
    /// 
    /// # REQUIRED
    /// $query.Var.roleIds = @(
    /// 	$someString
    /// )
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: List&lt;Role&gt;
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the GetUserDownloads operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: GetUserDownloads
    /// 
    /// $query = New-RscQueryMisc -Operation GetUserDownloads
    /// 
    /// # OPTIONAL
    /// $query.Var.first = $someInt
    /// # OPTIONAL
    /// $query.Var.after = $someString
    /// # OPTIONAL
    /// $query.Var.last = $someInt
    /// # OPTIONAL
    /// $query.Var.before = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: List&lt;UserDownload&gt;
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the GlobalFileSearch operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: GlobalFileSearch
    /// 
    /// $query = New-RscQueryMisc -Operation GlobalFileSearch
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	clusterUuid = $someString
    /// 	# REQUIRED
    /// 	query = @{
    /// 		# REQUIRED
    /// 		regex = $someString
    /// 		# REQUIRED
    /// 		snappableIds = @(
    /// 			$someString
    /// 		)
    /// 	}
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: GlobalFileSearchReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the GlobalLockoutConfig operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: GlobalLockoutConfig
    /// 
    /// $query = New-RscQueryMisc -Operation GlobalLockoutConfig
    /// 
    /// # No variables for this query.
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: LockoutConfig
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the GlobalMfaSetting operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: GlobalMfaSetting
    /// 
    /// $query = New-RscQueryMisc -Operation GlobalMfaSetting
    /// 
    /// # No variables for this query.
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: GetMfaSettingReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the GlobalSearchResults operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: GlobalSearchResults
    /// 
    /// $query = New-RscQueryMisc -Operation GlobalSearchResults
    /// 
    /// # OPTIONAL
    /// $query.Var.first = $someInt
    /// # OPTIONAL
    /// $query.Var.after = $someString
    /// # OPTIONAL
    /// $query.Var.last = $someInt
    /// # OPTIONAL
    /// $query.Var.before = $someString
    /// # OPTIONAL
    /// $query.Var.sortBy = $someHierarchySortByField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchySortByField]) for enum values.
    /// # OPTIONAL
    /// $query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
    /// # OPTIONAL
    /// $query.Var.filter = @(
    /// 	@{
    /// 		# OPTIONAL
    /// 		field = $someHierarchyFilterField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchyFilterField]) for enum values.
    /// 		# OPTIONAL
    /// 		texts = @(
    /// 			$someString
    /// 		)
    /// 		# OPTIONAL
    /// 		tagFilterParams = @(
    /// 			@{
    /// 				# OPTIONAL
    /// 				filterType = $someTagFilterType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TagFilterType]) for enum values.
    /// 				# OPTIONAL
    /// 				tagKey = $someString
    /// 				# OPTIONAL
    /// 				tagValue = $someString
    /// 			}
    /// 		)
    /// 		# OPTIONAL
    /// 		objectTypeFilterParams = @(
    /// 			$someManagedObjectType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ManagedObjectType]) for enum values.
    /// 		)
    /// 		# OPTIONAL
    /// 		awsNativeProtectionFeatureNames = @(
    /// 			$someAwsNativeProtectionFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeProtectionFeature]) for enum values.
    /// 		)
    /// 		# OPTIONAL
    /// 		isNegative = $someBoolean
    /// 		# OPTIONAL
    /// 		isSlowSearchEnabled = $someBoolean
    /// 		# OPTIONAL
    /// 		azureNativeProtectionFeatureNames = @(
    /// 			$someAzureNativeProtectionFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeProtectionFeature]) for enum values.
    /// 		)
    /// 		# OPTIONAL
    /// 		unmanagedObjectAvailabilityFilter = @(
    /// 			$someUnmanagedObjectAvailabilityFilter # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UnmanagedObjectAvailabilityFilter]) for enum values.
    /// 		)
    /// }
    /// )
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: HierarchyObjectConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the GroupsInCurrentAndDescendantOrganization operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: GroupsInCurrentAndDescendantOrganization
    /// 
    /// $query = New-RscQueryMisc -Operation GroupsInCurrentAndDescendantOrganization
    /// 
    /// # OPTIONAL
    /// $query.Var.first = $someInt
    /// # OPTIONAL
    /// $query.Var.after = $someString
    /// # OPTIONAL
    /// $query.Var.last = $someInt
    /// # OPTIONAL
    /// $query.Var.before = $someString
    /// # OPTIONAL
    /// $query.Var.filter = @{
    /// 	# OPTIONAL
    /// 	orgIdsFilter = @(
    /// 		$someString
    /// 	)
    /// 	# OPTIONAL
    /// 	roleIdsFilter = @(
    /// 		$someString
    /// 	)
    /// 	# OPTIONAL
    /// 	nameFilter = $someString
    /// 	# OPTIONAL
    /// 	authDomainIdsFilter = @(
    /// 		$someString
    /// 	)
    /// }
    /// # OPTIONAL
    /// $query.Var.sortBy = @{
    /// 	# OPTIONAL
    /// 	field = $someGroupSortByField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.GroupSortByField]) for enum values.
    /// 	# OPTIONAL
    /// 	sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
    /// }
    /// # OPTIONAL
    /// $query.Var.shouldIncludeGroupsWithoutRole = $someBoolean
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: GroupConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the GuestCredentials operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: GuestCredentials
    /// 
    /// $query = New-RscQueryMisc -Operation GuestCredentials
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
    /// Write-Host $result.GetType().Name # prints: GuestCredentialDetailListResponse
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the GuestCredentialsV2 operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: GuestCredentialsV2
    /// 
    /// $query = New-RscQueryMisc -Operation GuestCredentialsV2
    /// 
    /// # OPTIONAL
    /// $query.Var.first = $someInt
    /// # OPTIONAL
    /// $query.Var.after = $someString
    /// # OPTIONAL
    /// $query.Var.filter = @(
    /// 	@{
    /// 		# OPTIONAL
    /// 		field = $someGuestOsCredentialFilterField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.GuestOsCredentialFilterField]) for enum values.
    /// 		# OPTIONAL
    /// 		texts = @(
    /// 			$someString
    /// 		)
    /// }
    /// )
    /// # OPTIONAL
    /// $query.Var.sortBy = @{
    /// 	# OPTIONAL
    /// 	field = $someGuestOsCredentialSortByField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.GuestOsCredentialSortByField]) for enum values.
    /// 	# OPTIONAL
    /// 	sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: GuestOsCredentialConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the HasIdpConfigured operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: HasIdpConfigured
    /// 
    /// $query = New-RscQueryMisc -Operation HasIdpConfigured
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
    /// Runs the HelpContentSnippets operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: HelpContentSnippets
    /// 
    /// $query = New-RscQueryMisc -Operation HelpContentSnippets
    /// 
    /// # OPTIONAL
    /// $query.Var.first = $someInt
    /// # OPTIONAL
    /// $query.Var.after = $someString
    /// # OPTIONAL
    /// $query.Var.last = $someInt
    /// # OPTIONAL
    /// $query.Var.before = $someString
    /// # REQUIRED
    /// $query.Var.filter = @{
    /// 	# OPTIONAL
    /// 	initiator = $someHelpContentSnippetsFilterInitiator # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HelpContentSnippetsFilterInitiator]) for enum values.
    /// 	# OPTIONAL
    /// 	query = $someString
    /// 	# OPTIONAL
    /// 	language = $someString
    /// 	# OPTIONAL
    /// 	source = $someHelpContentSource # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HelpContentSource]) for enum values.
    /// 	# OPTIONAL
    /// 	categories = @(
    /// 		$someString
    /// 	)
    /// 	# OPTIONAL
    /// 	url = $someString
    /// 	# REQUIRED
    /// 	productDocumentationTypes = @(
    /// 		$someProductDocumentationType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ProductDocumentationType]) for enum values.
    /// 	)
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: HelpContentSnippetConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the HierarchyObject operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: HierarchyObject
    /// 
    /// $query = New-RscQueryMisc -Operation HierarchyObject
    /// 
    /// # REQUIRED
    /// $query.Var.fid = $someString
    /// # OPTIONAL
    /// $query.Var.workloadHierarchy = $someWorkloadLevelHierarchy # Call [Enum]::GetValues([RubrikSecurityCloud.Types.WorkloadLevelHierarchy]) for enum values.
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: HierarchyObject
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the HierarchyObjects operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: HierarchyObjects
    /// 
    /// $query = New-RscQueryMisc -Operation HierarchyObjects
    /// 
    /// # REQUIRED
    /// $query.Var.fids = @(
    /// 	$someString
    /// )
    /// # OPTIONAL
    /// $query.Var.filter = @(
    /// 	@{
    /// 		# OPTIONAL
    /// 		field = $someHierarchyFilterField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchyFilterField]) for enum values.
    /// 		# OPTIONAL
    /// 		texts = @(
    /// 			$someString
    /// 		)
    /// 		# OPTIONAL
    /// 		tagFilterParams = @(
    /// 			@{
    /// 				# OPTIONAL
    /// 				filterType = $someTagFilterType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TagFilterType]) for enum values.
    /// 				# OPTIONAL
    /// 				tagKey = $someString
    /// 				# OPTIONAL
    /// 				tagValue = $someString
    /// 			}
    /// 		)
    /// 		# OPTIONAL
    /// 		objectTypeFilterParams = @(
    /// 			$someManagedObjectType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ManagedObjectType]) for enum values.
    /// 		)
    /// 		# OPTIONAL
    /// 		awsNativeProtectionFeatureNames = @(
    /// 			$someAwsNativeProtectionFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeProtectionFeature]) for enum values.
    /// 		)
    /// 		# OPTIONAL
    /// 		isNegative = $someBoolean
    /// 		# OPTIONAL
    /// 		isSlowSearchEnabled = $someBoolean
    /// 		# OPTIONAL
    /// 		azureNativeProtectionFeatureNames = @(
    /// 			$someAzureNativeProtectionFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeProtectionFeature]) for enum values.
    /// 		)
    /// 		# OPTIONAL
    /// 		unmanagedObjectAvailabilityFilter = @(
    /// 			$someUnmanagedObjectAvailabilityFilter # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UnmanagedObjectAvailabilityFilter]) for enum values.
    /// 		)
    /// }
    /// )
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: List&lt;HierarchyObject&gt;
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the InstalledVersionList operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: InstalledVersionList
    /// 
    /// $query = New-RscQueryMisc -Operation InstalledVersionList
    /// 
    /// # No variables for this query.
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: List&lt;InstalledVersionGroupCount&gt;
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the InventoryRoot operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: InventoryRoot
    /// 
    /// $query = New-RscQueryMisc -Operation InventoryRoot
    /// 
    /// # No variables for this query.
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: InventoryRoot
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the InventorySubHierarchyRoot operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: InventorySubHierarchyRoot
    /// 
    /// $query = New-RscQueryMisc -Operation InventorySubHierarchyRoot
    /// 
    /// # REQUIRED
    /// $query.Var.rootEnum = $someInventorySubHierarchyRootEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.InventorySubHierarchyRootEnum]) for enum values.
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: InventorySubHierarchyRoot
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the InventoryWorkloads operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: InventoryWorkloads
    /// 
    /// $query = New-RscQueryMisc -Operation InventoryWorkloads
    /// 
    /// # No variables for this query.
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: List&lt;InventoryCard&gt;
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the InvestigationCsvDownloadLink operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: InvestigationCsvDownloadLink
    /// 
    /// $query = New-RscQueryMisc -Operation InvestigationCsvDownloadLink
    /// 
    /// # REQUIRED
    /// $query.Var.clusterUuid = $someString
    /// # REQUIRED
    /// $query.Var.workloadId = $someString
    /// # REQUIRED
    /// $query.Var.snapshotId = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: InvestigationCsvDownloadLinkReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the IpWhitelist operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: IpWhitelist
    /// 
    /// $query = New-RscQueryMisc -Operation IpWhitelist
    /// 
    /// # No variables for this query.
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: GetWhitelistReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the IsIpmiEnabled operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: IsIpmiEnabled
    /// 
    /// $query = New-RscQueryMisc -Operation IsIpmiEnabled
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
    /// Write-Host $result.GetType().Name # prints: System.Boolean
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the IsLoggedIntoRubrikSupportPortal operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: IsLoggedIntoRubrikSupportPortal
    /// 
    /// $query = New-RscQueryMisc -Operation IsLoggedIntoRubrikSupportPortal
    /// 
    /// # No variables for this query.
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: SupportPortalStatusReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the IsReplaceNodeTprConfigured operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: IsReplaceNodeTprConfigured
    /// 
    /// $query = New-RscQueryMisc -Operation IsReplaceNodeTprConfigured
    /// 
    /// # REQUIRED
    /// $query.Var.clusterUuid = $someString
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
    /// Runs the IsSfdcReachable operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: IsSfdcReachable
    /// 
    /// $query = New-RscQueryMisc -Operation IsSfdcReachable
    /// 
    /// # REQUIRED
    /// $query.Var.hostname = $someString
    /// # REQUIRED
    /// $query.Var.organizationId = $someString
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
    /// Runs the IsUpgradeAvailable operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: IsUpgradeAvailable
    /// 
    /// $query = New-RscQueryMisc -Operation IsUpgradeAvailable
    /// 
    /// # REQUIRED
    /// $query.Var.clusterUuid = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: CdmUpgradeAvailabilityReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the IsUpgradeRecommended operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: IsUpgradeRecommended
    /// 
    /// $query = New-RscQueryMisc -Operation IsUpgradeRecommended
    /// 
    /// # REQUIRED
    /// $query.Var.clusterUuid = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: CdmUpgradeRecommendationReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the IsZrsAvailableForLocation operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: IsZrsAvailableForLocation
    /// 
    /// $query = New-RscQueryMisc -Operation IsZrsAvailableForLocation
    /// 
    /// # REQUIRED
    /// $query.Var.serviceTier = $someServiceTier # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ServiceTier]) for enum values.
    /// # REQUIRED
    /// $query.Var.region = $someAzureNativeRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeRegion]) for enum values.
    /// # REQUIRED
    /// $query.Var.subscriptionId = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: ZrsAvailabilityReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the Issue operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: Issue
    /// 
    /// $query = New-RscQueryMisc -Operation Issue
    /// 
    /// # REQUIRED
    /// $query.Var.issueId = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: Issue
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the Issues operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: Issues
    /// 
    /// $query = New-RscQueryMisc -Operation Issues
    /// 
    /// # REQUIRED
    /// $query.Var.status = $someIssueStatus # Call [Enum]::GetValues([RubrikSecurityCloud.Types.IssueStatus]) for enum values.
    /// # OPTIONAL
    /// $query.Var.first = $someInt
    /// # OPTIONAL
    /// $query.Var.after = $someString
    /// # OPTIONAL
    /// $query.Var.last = $someInt
    /// # OPTIONAL
    /// $query.Var.before = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: IssueConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the IssuesJobIds operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: IssuesJobIds
    /// 
    /// $query = New-RscQueryMisc -Operation IssuesJobIds
    /// 
    /// # REQUIRED
    /// $query.Var.queryIds = @(
    /// 	$someString
    /// )
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
    /// Runs the JobInfo operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: JobInfo
    /// 
    /// $query = New-RscQueryMisc -Operation JobInfo
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	requestId = $someString
    /// 	# OPTIONAL
    /// 	clusterUuid = $someString
    /// 	# OPTIONAL
    /// 	type = $someJobType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.JobType]) for enum values.
    /// 	# REQUIRED
    /// 	additionalInfo = @{
    /// 		# OPTIONAL
    /// 		unmountInfo = @{
    /// 			# OPTIONAL
    /// 			liveMountFid = $someString
    /// 		}
    /// 		# OPTIONAL
    /// 		queryMountInfo = @{
    /// 			# OPTIONAL
    /// 			snapshotFid = $someString
    /// 		}
    /// 		# OPTIONAL
    /// 		sapHanaSystemInfo = @{
    /// 			# OPTIONAL
    /// 			sapHanaSystemFid = $someString
    /// 		}
    /// 		# OPTIONAL
    /// 		archivalLocationInfo = @{
    /// 			# OPTIONAL
    /// 			polarisManagedLocId = $someString
    /// 			# OPTIONAL
    /// 			locationName = $someString
    /// 			# OPTIONAL
    /// 			locationType = $someString
    /// 			# OPTIONAL
    /// 			operationType = $someArchivalLocationOperationType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ArchivalLocationOperationType]) for enum values.
    /// 			# OPTIONAL
    /// 			operationId = $someString
    /// 		}
    /// 		# OPTIONAL
    /// 		mosaicSourceInfo = @{
    /// 			# OPTIONAL
    /// 			sourceNames = @(
    /// 				$someString
    /// 			)
    /// 			# OPTIONAL
    /// 			refreshEffectiveSla = $someBoolean
    /// 			# OPTIONAL
    /// 			sourceType = $someMosaicSourceNosqlSourceType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.MosaicSourceNosqlSourceType]) for enum values.
    /// 		}
    /// 		# OPTIONAL
    /// 		snapshotFileDownloadInfo = @{
    /// 			# OPTIONAL
    /// 			downloadId = $someInt64
    /// 			# OPTIONAL
    /// 			snappableType = $someSnapshotFileDownloadSnappableType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SnapshotFileDownloadSnappableType]) for enum values.
    /// 		}
    /// 		# OPTIONAL
    /// 		mosaicStorageLocationInfo = @{
    /// 			# OPTIONAL
    /// 			storageLocationName = $someString
    /// 		}
    /// 		# OPTIONAL
    /// 		pendingSlaInfo = @{
    /// 			# OPTIONAL
    /// 			objectFids = @(
    /// 				$someString
    /// 			)
    /// 		}
    /// 		# OPTIONAL
    /// 		volumeGroupUnmountInfo = @{
    /// 			# OPTIONAL
    /// 			liveMountFid = $someString
    /// 		}
    /// 		# OPTIONAL
    /// 		db2InstanceInfo = @{
    /// 			# OPTIONAL
    /// 			db2InstanceFid = $someString
    /// 		}
    /// 		# OPTIONAL
    /// 		mssqlDbInfo = @{
    /// 			# OPTIONAL
    /// 			mssqlDbFid = $someString
    /// 		}
    /// 		# OPTIONAL
    /// 		logShippingInfo = @{
    /// 			# OPTIONAL
    /// 			secondaryDatabaseName = $someString
    /// 			# OPTIONAL
    /// 			databaseFid = $someString
    /// 		}
    /// 		# OPTIONAL
    /// 		addManagedVolumeInfo = @{
    /// 			# OPTIONAL
    /// 			managedVolumeFid = $someString
    /// 		}
    /// 		# OPTIONAL
    /// 		takeManagedVolumeOnDemandSnapshotInfo = @{
    /// 			# OPTIONAL
    /// 			managedVolumeFid = $someString
    /// 		}
    /// 		# OPTIONAL
    /// 		beginManagedVolumeSnapshotInfo = @{
    /// 			# OPTIONAL
    /// 			managedVolumeFid = $someString
    /// 		}
    /// 		# OPTIONAL
    /// 		endManagedVolumeSnapshotInfo = @{
    /// 			# OPTIONAL
    /// 			managedVolumeFid = $someString
    /// 		}
    /// 		# OPTIONAL
    /// 		resizeManagedVolumeInfo = @{
    /// 			# OPTIONAL
    /// 			managedVolumeFid = $someString
    /// 		}
    /// 		# OPTIONAL
    /// 		exportManagedVolumeSnapshotInfo = @{
    /// 			# OPTIONAL
    /// 			snapshotFid = $someString
    /// 			# OPTIONAL
    /// 			exportId = $someString
    /// 		}
    /// 		# OPTIONAL
    /// 		oracleExportInfo = @{
    /// 			# OPTIONAL
    /// 			isSameHostRestore = $someBoolean
    /// 			# OPTIONAL
    /// 			targetHostOrRacFid = $someString
    /// 			# OPTIONAL
    /// 			targetDbName = $someString
    /// 		}
    /// 		# OPTIONAL
    /// 		sapHanaDatabaseInfo = @{
    /// 			# OPTIONAL
    /// 			sapHanaDatabaseFid = $someString
    /// 			# OPTIONAL
    /// 			syncDbLogSnapshot = $someBoolean
    /// 		}
    /// 		# OPTIONAL
    /// 		liveMountRelocateInfo = @{
    /// 			# OPTIONAL
    /// 			liveMountFid = $someString
    /// 		}
    /// 		# OPTIONAL
    /// 		mongoSourceInfo = @{
    /// 			# OPTIONAL
    /// 			mongoSourceFid = $someString
    /// 		}
    /// 		# OPTIONAL
    /// 		hypervMountSnapshotInfo = @{
    /// 			# OPTIONAL
    /// 			snapshotFid = $someString
    /// 		}
    /// 		# OPTIONAL
    /// 		webCertificateInfo = @{
    /// 			# OPTIONAL
    /// 			cdmCertificateId = $someString
    /// 		}
    /// 		# OPTIONAL
    /// 		db2DatabaseInfo = @{
    /// 			# OPTIONAL
    /// 			db2DbFid = $someString
    /// 		}
    /// 		# OPTIONAL
    /// 		mongoCollectionsInfo = @{
    /// 			# OPTIONAL
    /// 			collectionFids = @(
    /// 				$someString
    /// 			)
    /// 		}
    /// 		# OPTIONAL
    /// 		vsphereFileRestoreInfo = @{
    /// 			# OPTIONAL
    /// 			vmFid = $someString
    /// 		}
    /// 		# OPTIONAL
    /// 		configureManagedVolumeLogExportInfo = @{
    /// 			# OPTIONAL
    /// 			managedVolumeFid = $someString
    /// 		}
    /// 		# OPTIONAL
    /// 		downloadSnapshotFromLocationInfo = @{
    /// 			# OPTIONAL
    /// 			snapshotId = $someString
    /// 			# OPTIONAL
    /// 			snappableType = $someDownloadSnapshotFromLocationSnappableType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DownloadSnapshotFromLocationSnappableType]) for enum values.
    /// 		}
    /// 		# OPTIONAL
    /// 		registeredHostInfo = @{
    /// 			# OPTIONAL
    /// 			hostFid = $someString
    /// 			# OPTIONAL
    /// 			hostRegisteredTime = $someDateTime
    /// 		}
    /// 		# OPTIONAL
    /// 		registerOracleHostsInfo = @{
    /// 			# OPTIONAL
    /// 			addedOracleHostFids = @(
    /// 				$someString
    /// 			)
    /// 			# OPTIONAL
    /// 			hostRegisteredTime = $someDateTime
    /// 		}
    /// 		# OPTIONAL
    /// 		llmInfo = @{
    /// 			# OPTIONAL
    /// 			functionType = $someLlmFunctionCallFunctionType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.LlmFunctionCallFunctionType]) for enum values.
    /// 			# OPTIONAL
    /// 			functionUuid = $someString
    /// 			# OPTIONAL
    /// 			subjectContexts = @(
    /// 				@{
    /// 					# OPTIONAL
    /// 					organizationId = $someString
    /// 					# OPTIONAL
    /// 					subjectId = $someString
    /// 					# OPTIONAL
    /// 					subjectType = $someSubjectContextType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SubjectContextType]) for enum values.
    /// 				}
    /// 			)
    /// 		}
    /// 		# OPTIONAL
    /// 		hostMakePrimaryInfo = @{
    /// 			# OPTIONAL
    /// 			hostFids = @(
    /// 				$someString
    /// 			)
    /// 		}
    /// 		# OPTIONAL
    /// 		vcenterDiagnosticRefreshInfo = @{
    /// 			# OPTIONAL
    /// 			vcenterFid = $someString
    /// 		}
    /// 		# OPTIONAL
    /// 		postgresDbClusterInfo = @{
    /// 			# OPTIONAL
    /// 			postgresDbClusterFid = $someString
    /// 		}
    /// 		# OPTIONAL
    /// 		hostsInfo = @{
    /// 			# OPTIONAL
    /// 			hostFids = @(
    /// 				$someString
    /// 			)
    /// 		}
    /// 		# OPTIONAL
    /// 		vsphereVmMakePrimaryInfo = @{
    /// 			# OPTIONAL
    /// 			vmFids = @(
    /// 				$someString
    /// 			)
    /// 		}
    /// 		# OPTIONAL
    /// 		mssqlAddHost = @{
    /// 			# OPTIONAL
    /// 			hostFid = $someString
    /// 			# OPTIONAL
    /// 			userId = $someString
    /// 		}
    /// 		# OPTIONAL
    /// 		kosmosRecoveryInfo = @{
    /// 			# OPTIONAL
    /// 			kosmosRecoveryFid = $someString
    /// 		}
    /// 		# OPTIONAL
    /// 		mssqlInstanceInfo = @{
    /// 			# OPTIONAL
    /// 			mssqlInstanceFid = $someString
    /// 		}
    /// 		# OPTIONAL
    /// 		mysqldbInstanceInfo = @{
    /// 			# OPTIONAL
    /// 			mysqldbInstanceFid = $someString
    /// 		}
    /// 	}
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: JobInfo
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the KnowledgeBaseArticle operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: KnowledgeBaseArticle
    /// 
    /// $query = New-RscQueryMisc -Operation KnowledgeBaseArticle
    /// 
    /// # REQUIRED
    /// $query.Var.id = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: KnowledgeBaseArticle
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the LambdaSettings operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: LambdaSettings
    /// 
    /// $query = New-RscQueryMisc -Operation LambdaSettings
    /// 
    /// # No variables for this query.
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
    /// Runs the LicensedProducts operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: LicensedProducts
    /// 
    /// $query = New-RscQueryMisc -Operation LicensedProducts
    /// 
    /// # No variables for this query.
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: GetLicensedProductsInfoReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the LockoutConfig operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: LockoutConfig
    /// 
    /// $query = New-RscQueryMisc -Operation LockoutConfig
    /// 
    /// # No variables for this query.
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: LockoutConfig
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the MaxProtectedAppsCount operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: MaxProtectedAppsCount
    /// 
    /// $query = New-RscQueryMisc -Operation MaxProtectedAppsCount
    /// 
    /// # No variables for this query.
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: System.Int32
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the MfaSetting operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: MfaSetting
    /// 
    /// $query = New-RscQueryMisc -Operation MfaSetting
    /// 
    /// # No variables for this query.
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: GetMfaSettingReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the MicrosoftSites operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: MicrosoftSites
    /// 
    /// $query = New-RscQueryMisc -Operation MicrosoftSites
    /// 
    /// # OPTIONAL
    /// $query.Var.first = $someInt
    /// # OPTIONAL
    /// $query.Var.after = $someString
    /// # OPTIONAL
    /// $query.Var.sortBy = $someHierarchySortByField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchySortByField]) for enum values.
    /// # OPTIONAL
    /// $query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
    /// # OPTIONAL
    /// $query.Var.filter = @(
    /// 	@{
    /// 		# OPTIONAL
    /// 		field = $someHierarchyFilterField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchyFilterField]) for enum values.
    /// 		# OPTIONAL
    /// 		texts = @(
    /// 			$someString
    /// 		)
    /// 		# OPTIONAL
    /// 		tagFilterParams = @(
    /// 			@{
    /// 				# OPTIONAL
    /// 				filterType = $someTagFilterType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TagFilterType]) for enum values.
    /// 				# OPTIONAL
    /// 				tagKey = $someString
    /// 				# OPTIONAL
    /// 				tagValue = $someString
    /// 			}
    /// 		)
    /// 		# OPTIONAL
    /// 		objectTypeFilterParams = @(
    /// 			$someManagedObjectType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ManagedObjectType]) for enum values.
    /// 		)
    /// 		# OPTIONAL
    /// 		awsNativeProtectionFeatureNames = @(
    /// 			$someAwsNativeProtectionFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeProtectionFeature]) for enum values.
    /// 		)
    /// 		# OPTIONAL
    /// 		isNegative = $someBoolean
    /// 		# OPTIONAL
    /// 		isSlowSearchEnabled = $someBoolean
    /// 		# OPTIONAL
    /// 		azureNativeProtectionFeatureNames = @(
    /// 			$someAzureNativeProtectionFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeProtectionFeature]) for enum values.
    /// 		)
    /// 		# OPTIONAL
    /// 		unmanagedObjectAvailabilityFilter = @(
    /// 			$someUnmanagedObjectAvailabilityFilter # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UnmanagedObjectAvailabilityFilter]) for enum values.
    /// 		)
    /// }
    /// )
    /// # REQUIRED
    /// $query.Var.o365OrgId = $someString
    /// # OPTIONAL
    /// $query.Var.excludeChildSites = $someBoolean
    /// # REQUIRED
    /// $query.Var.protectionType = $someProtectionType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ProtectionType]) for enum values.
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: MicrosoftSiteConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the MinimumCdmVersionForFeatureSet operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: MinimumCdmVersionForFeatureSet
    /// 
    /// $query = New-RscQueryMisc -Operation MinimumCdmVersionForFeatureSet
    /// 
    /// # REQUIRED
    /// $query.Var.featureListMinimumCdmVersion = @{
    /// 	# REQUIRED
    /// 	featureTypes = @(
    /// 		$someCdmFeatureFlagType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CdmFeatureFlagType]) for enum values.
    /// 	)
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: FeatureListMinimumCdmVersionReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the MipLabels operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: MipLabels
    /// 
    /// $query = New-RscQueryMisc -Operation MipLabels
    /// 
    /// # OPTIONAL
    /// $query.Var.onlyActiveFilter = $someBoolean
    /// # OPTIONAL
    /// $query.Var.onlyAppliableFilter = $someBoolean
    /// # OPTIONAL
    /// $query.Var.tenantIdFilter = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: List&lt;MicrosoftMipLabel&gt;
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the NetworkThrottle operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: NetworkThrottle
    /// 
    /// $query = New-RscQueryMisc -Operation NetworkThrottle
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	resourceId = $someInternalQueryNetworkThrottleRequestResourceId # Call [Enum]::GetValues([RubrikSecurityCloud.Types.InternalQueryNetworkThrottleRequestResourceId]) for enum values.
    /// 	# REQUIRED
    /// 	clusterUuid = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: NetworkThrottleSummaryListResponse
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the NfAnomalyResults operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: NfAnomalyResults
    /// 
    /// $query = New-RscQueryMisc -Operation NfAnomalyResults
    /// 
    /// # OPTIONAL
    /// $query.Var.first = $someInt
    /// # OPTIONAL
    /// $query.Var.after = $someString
    /// # OPTIONAL
    /// $query.Var.last = $someInt
    /// # OPTIONAL
    /// $query.Var.before = $someString
    /// # OPTIONAL
    /// $query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
    /// # OPTIONAL
    /// $query.Var.sortBy = $someNfAnomalyResultSortBy # Call [Enum]::GetValues([RubrikSecurityCloud.Types.NfAnomalyResultSortBy]) for enum values.
    /// # OPTIONAL
    /// $query.Var.filter = @{
    /// 	# OPTIONAL
    /// 	clusterUuid = @(
    /// 		$someString
    /// 	)
    /// 	# OPTIONAL
    /// 	startTime = $someDateTime
    /// 	# OPTIONAL
    /// 	endTime = $someDateTime
    /// 	# OPTIONAL
    /// 	isAnomaly = $someBoolean
    /// 	# OPTIONAL
    /// 	workloadFid = @(
    /// 		$someString
    /// 	)
    /// }
    /// # OPTIONAL
    /// $query.Var.timezoneOffset = $someSingle
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: NfAnomalyResultConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the NfAnomalyResultsGrouped operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: NfAnomalyResultsGrouped
    /// 
    /// $query = New-RscQueryMisc -Operation NfAnomalyResultsGrouped
    /// 
    /// # OPTIONAL
    /// $query.Var.first = $someInt
    /// # OPTIONAL
    /// $query.Var.after = $someString
    /// # OPTIONAL
    /// $query.Var.last = $someInt
    /// # OPTIONAL
    /// $query.Var.before = $someString
    /// # REQUIRED
    /// $query.Var.groupBy = $someNfAnomalyResultGroupBy # Call [Enum]::GetValues([RubrikSecurityCloud.Types.NfAnomalyResultGroupBy]) for enum values.
    /// # OPTIONAL
    /// $query.Var.filter = @{
    /// 	# OPTIONAL
    /// 	clusterUuid = @(
    /// 		$someString
    /// 	)
    /// 	# OPTIONAL
    /// 	startTime = $someDateTime
    /// 	# OPTIONAL
    /// 	endTime = $someDateTime
    /// 	# OPTIONAL
    /// 	isAnomaly = $someBoolean
    /// 	# OPTIONAL
    /// 	workloadFid = @(
    /// 		$someString
    /// 	)
    /// }
    /// # OPTIONAL
    /// $query.Var.timezoneOffset = $someSingle
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: NfAnomalyResultGroupedDataConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the NodeRemovalCancelPermission operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: NodeRemovalCancelPermission
    /// 
    /// $query = New-RscQueryMisc -Operation NodeRemovalCancelPermission
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
    /// Write-Host $result.GetType().Name # prints: NodeRemovalCancelPermissionReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the NodeToReplace operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: NodeToReplace
    /// 
    /// $query = New-RscQueryMisc -Operation NodeToReplace
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
    /// Write-Host $result.GetType().Name # prints: NodeToReplaceReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the NodeTunnelStatuses operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: NodeTunnelStatuses
    /// 
    /// $query = New-RscQueryMisc -Operation NodeTunnelStatuses
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
    /// Write-Host $result.GetType().Name # prints: NodeTunnelStatusConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the NosqlStorageLocations operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: NosqlStorageLocations
    /// 
    /// $query = New-RscQueryMisc -Operation NosqlStorageLocations
    /// 
    /// # OPTIONAL
    /// $query.Var.sortBy = $someMosaicStorageLocationQuerySortByField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.MosaicStorageLocationQuerySortByField]) for enum values.
    /// # OPTIONAL
    /// $query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
    /// # OPTIONAL
    /// $query.Var.filter = @(
    /// 	@{
    /// 		# OPTIONAL
    /// 		field = $someMosaicStorageLocationFilterField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.MosaicStorageLocationFilterField]) for enum values.
    /// 		# OPTIONAL
    /// 		text = $someString
    /// }
    /// )
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: List&lt;MosaicStorageLocation&gt;
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the OauthCodesForEdgeReg operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: OauthCodesForEdgeReg
    /// 
    /// $query = New-RscQueryMisc -Operation OauthCodesForEdgeReg
    /// 
    /// # REQUIRED
    /// $query.Var.numberOfEdges = $someInt
    /// # REQUIRED
    /// $query.Var.cdmOvaLink = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: OauthCodesForEdgeRegReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the ObjectFiles operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: ObjectFiles
    /// 
    /// $query = New-RscQueryMisc -Operation ObjectFiles
    /// 
    /// # OPTIONAL
    /// $query.Var.filter = @{
    /// 	# OPTIONAL
    /// 	openAccessTypes = @(
    /// 		$someOpenAccessType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.OpenAccessType]) for enum values.
    /// 	)
    /// 	# OPTIONAL
    /// 	stalenessTypes = @(
    /// 		$someStalenessType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.StalenessType]) for enum values.
    /// 	)
    /// 	# OPTIONAL
    /// 	analyzerGroupIds = @(
    /// 		$someString
    /// 	)
    /// 	# OPTIONAL
    /// 	clusterIds = @(
    /// 		$someString
    /// 	)
    /// 	# OPTIONAL
    /// 	pathPrefix = $someString
    /// 	# OPTIONAL
    /// 	snappableTypes = @(
    /// 		$someString
    /// 	)
    /// 	# OPTIONAL
    /// 	searchText = $someString
    /// 	# OPTIONAL
    /// 	whitelistEnabled = $someBoolean
    /// 	# OPTIONAL
    /// 	fileCountTypes = @(
    /// 		$someFileCountType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.FileCountType]) for enum values.
    /// 	)
    /// 	# OPTIONAL
    /// 	accessTypes = @(
    /// 		$someAccessType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AccessType]) for enum values.
    /// 	)
    /// 	# OPTIONAL
    /// 	activityTypes = @(
    /// 		$someActivityAccessType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ActivityAccessType]) for enum values.
    /// 	)
    /// 	# OPTIONAL
    /// 	objectIds = @(
    /// 		$someString
    /// 	)
    /// 	# OPTIONAL
    /// 	inodeTypes = @(
    /// 		$someInodeType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.InodeType]) for enum values.
    /// 	)
    /// 	# REQUIRED
    /// 	objectTypes = @(
    /// 		$someHierarchyObjectTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchyObjectTypeEnum]) for enum values.
    /// 	)
    /// }
    /// # OPTIONAL
    /// $query.Var.sort = @{
    /// 	# OPTIONAL
    /// 	sortBy = $someFileResultSortBy # Call [Enum]::GetValues([RubrikSecurityCloud.Types.FileResultSortBy]) for enum values.
    /// 	# OPTIONAL
    /// 	sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
    /// 	# OPTIONAL
    /// 	analyzerGroupId = $someString
    /// 	# OPTIONAL
    /// 	dataTypeId = $someString
    /// }
    /// # REQUIRED
    /// $query.Var.day = $someString
    /// # REQUIRED
    /// $query.Var.timezone = $someString
    /// # OPTIONAL
    /// $query.Var.first = $someInt
    /// # OPTIONAL
    /// $query.Var.after = $someString
    /// # OPTIONAL
    /// $query.Var.last = $someInt
    /// # OPTIONAL
    /// $query.Var.before = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: FileResultConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the ObjectTypeAccessSummary operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: ObjectTypeAccessSummary
    /// 
    /// $query = New-RscQueryMisc -Operation ObjectTypeAccessSummary
    /// 
    /// # REQUIRED
    /// $query.Var.timelineDate = $someString
    /// # REQUIRED
    /// $query.Var.historicalDeltaDays = $someInt
    /// # OPTIONAL
    /// $query.Var.includeWhitelistedResults = $someBoolean
    /// # OPTIONAL
    /// $query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
    /// # OPTIONAL
    /// $query.Var.filter = @{
    /// 	# OPTIONAL
    /// 	policyId = $someString
    /// 	# OPTIONAL
    /// 	objectTypes = @(
    /// 		$someDataGovObjectType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DataGovObjectType]) for enum values.
    /// 	)
    /// 	# OPTIONAL
    /// 	platformCategories = @(
    /// 		$somePlatformCategory # Call [Enum]::GetValues([RubrikSecurityCloud.Types.PlatformCategory]) for enum values.
    /// 	)
    /// }
    /// # OPTIONAL
    /// $query.Var.sort = $someObjectTypeAccessSummarySortBy # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ObjectTypeAccessSummarySortBy]) for enum values.
    /// # OPTIONAL
    /// $query.Var.groupBy = $someObjectTypeAccessSummaryGroupBy # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ObjectTypeAccessSummaryGroupBy]) for enum values.
    /// # OPTIONAL
    /// $query.Var.first = $someInt
    /// # OPTIONAL
    /// $query.Var.after = $someString
    /// # OPTIONAL
    /// $query.Var.last = $someInt
    /// # OPTIONAL
    /// $query.Var.before = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: ObjectTypeAccessSummaryConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the ObjectsAlreadyAssignedToOrgs operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: ObjectsAlreadyAssignedToOrgs
    /// 
    /// $query = New-RscQueryMisc -Operation ObjectsAlreadyAssignedToOrgs
    /// 
    /// # REQUIRED
    /// $query.Var.objectIdsForHierarchyTypes = @(
    /// 	@{
    /// 		# REQUIRED
    /// 		objectIds = @(
    /// 			$someString
    /// 		)
    /// 		# REQUIRED
    /// 		snappableType = $someWorkloadLevelHierarchy # Call [Enum]::GetValues([RubrikSecurityCloud.Types.WorkloadLevelHierarchy]) for enum values.
    /// }
    /// )
    /// # REQUIRED
    /// $query.Var.allowedClusters = @(
    /// 	$someString
    /// )
    /// # OPTIONAL
    /// $query.Var.targetOrgId = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: List&lt;ObjectIdsForHierarchyType&gt;
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the Org operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: Org
    /// 
    /// $query = New-RscQueryMisc -Operation Org
    /// 
    /// # REQUIRED
    /// $query.Var.orgId = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: Org
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the Orgs operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: Orgs
    /// 
    /// $query = New-RscQueryMisc -Operation Orgs
    /// 
    /// # OPTIONAL
    /// $query.Var.first = $someInt
    /// # OPTIONAL
    /// $query.Var.after = $someString
    /// # OPTIONAL
    /// $query.Var.last = $someInt
    /// # OPTIONAL
    /// $query.Var.before = $someString
    /// # OPTIONAL
    /// $query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
    /// # OPTIONAL
    /// $query.Var.sortBy = $someOrgField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.OrgField]) for enum values.
    /// # OPTIONAL
    /// $query.Var.nameFilter = $someString
    /// # OPTIONAL
    /// $query.Var.mfaEnforcedFilter = $someBoolean
    /// # OPTIONAL
    /// $query.Var.crossAccountEnabledFilter = $someBoolean
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: OrgConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the OrgsByIds operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: OrgsByIds
    /// 
    /// $query = New-RscQueryMisc -Operation OrgsByIds
    /// 
    /// # REQUIRED
    /// $query.Var.orgIds = @(
    /// 	$someString
    /// )
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: List&lt;Org&gt;
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the OrgsForPrincipal operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: OrgsForPrincipal
    /// 
    /// $query = New-RscQueryMisc -Operation OrgsForPrincipal
    /// 
    /// # OPTIONAL
    /// $query.Var.orgSearchFilter = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: OrgsForPrincipalReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the PasskeyConfig operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: PasskeyConfig
    /// 
    /// $query = New-RscQueryMisc -Operation PasskeyConfig
    /// 
    /// # No variables for this query.
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: GetPasskeyConfigReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the PasskeyInfo operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: PasskeyInfo
    /// 
    /// $query = New-RscQueryMisc -Operation PasskeyInfo
    /// 
    /// # No variables for this query.
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: GetPasskeyInfoReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the PendingAction operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: PendingAction
    /// 
    /// $query = New-RscQueryMisc -Operation PendingAction
    /// 
    /// # REQUIRED
    /// $query.Var.pendingActionId = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: PendingAction
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the PendingActions operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: PendingActions
    /// 
    /// $query = New-RscQueryMisc -Operation PendingActions
    /// 
    /// # OPTIONAL
    /// $query.Var.clusterFilter = $someString
    /// # OPTIONAL
    /// $query.Var.pendingActionGroupTypeFilter = @(
    /// 	$somePendingActionGroupTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.PendingActionGroupTypeEnum]) for enum values.
    /// )
    /// # OPTIONAL
    /// $query.Var.pendingActionSubGroupTypeFilter = @(
    /// 	$somePendingActionSubGroupTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.PendingActionSubGroupTypeEnum]) for enum values.
    /// )
    /// # OPTIONAL
    /// $query.Var.statusFilter = @(
    /// 	$somePendingActionStatus # Call [Enum]::GetValues([RubrikSecurityCloud.Types.PendingActionStatus]) for enum values.
    /// )
    /// # OPTIONAL
    /// $query.Var.objectIds = @(
    /// 	$someString
    /// )
    /// # OPTIONAL
    /// $query.Var.sortedOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
    /// # OPTIONAL
    /// $query.Var.historyOnly = $someBoolean
    /// # OPTIONAL
    /// $query.Var.limit = $someInt64
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: List&lt;PendingAction&gt;
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the PhoenixRolloutProgress operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: PhoenixRolloutProgress
    /// 
    /// $query = New-RscQueryMisc -Operation PhoenixRolloutProgress
    /// 
    /// # REQUIRED
    /// $query.Var.orgId = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: PhoenixRolloutProgress
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the PipelineHealthForTimeRange operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: PipelineHealthForTimeRange
    /// 
    /// $query = New-RscQueryMisc -Operation PipelineHealthForTimeRange
    /// 
    /// # REQUIRED
    /// $query.Var.beginTime = $someDateTime
    /// # OPTIONAL
    /// $query.Var.endTime = $someDateTime
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: GetPipelineHealthReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the PolarisInventorySubHierarchyRoot operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: PolarisInventorySubHierarchyRoot
    /// 
    /// $query = New-RscQueryMisc -Operation PolarisInventorySubHierarchyRoot
    /// 
    /// # REQUIRED
    /// $query.Var.rootEnum = $someInventorySubHierarchyRootEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.InventorySubHierarchyRootEnum]) for enum values.
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: PolarisInventorySubHierarchyRoot
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the PolicyDetails operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: PolicyDetails
    /// 
    /// $query = New-RscQueryMisc -Operation PolicyDetails
    /// 
    /// # OPTIONAL
    /// $query.Var.dataCategoryIds = @(
    /// 	$someString
    /// )
    /// # OPTIONAL
    /// $query.Var.dataTypeIds = @(
    /// 	$someString
    /// )
    /// # OPTIONAL
    /// $query.Var.dataCategoryType = $someDataCategoryType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DataCategoryType]) for enum values.
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: PolicyDetailConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the PolicyObj operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: PolicyObj
    /// 
    /// $query = New-RscQueryMisc -Operation PolicyObj
    /// 
    /// # REQUIRED
    /// $query.Var.snappableFid = $someString
    /// # REQUIRED
    /// $query.Var.snapshotFid = $someString
    /// # OPTIONAL
    /// $query.Var.includeWhitelistedResults = $someBoolean
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: PolicyObj
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the PolicyObjs operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: PolicyObjs
    /// 
    /// $query = New-RscQueryMisc -Operation PolicyObjs
    /// 
    /// # REQUIRED
    /// $query.Var.day = $someString
    /// # REQUIRED
    /// $query.Var.timezone = $someString
    /// # REQUIRED
    /// $query.Var.workloadTypes = @(
    /// 	$someDataGovObjectType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DataGovObjectType]) for enum values.
    /// )
    /// # OPTIONAL
    /// $query.Var.sortBy = $someString
    /// # OPTIONAL
    /// $query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
    /// # OPTIONAL
    /// $query.Var.analysisStatusesFilter = @(
    /// 	$someAnalysisStatus # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AnalysisStatus]) for enum values.
    /// )
    /// # OPTIONAL
    /// $query.Var.policyIdsFilter = @(
    /// 	$someString
    /// )
    /// # OPTIONAL
    /// $query.Var.riskLevelsFilter = @(
    /// 	$someRiskLevelType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RiskLevelType]) for enum values.
    /// )
    /// # OPTIONAL
    /// $query.Var.clusterIdsFilter = @(
    /// 	$someString
    /// )
    /// # OPTIONAL
    /// $query.Var.searchObjectName = $someString
    /// # OPTIONAL
    /// $query.Var.subscriptionIdsFilter = @(
    /// 	$someString
    /// )
    /// # OPTIONAL
    /// $query.Var.includeWhitelistedResults = $someBoolean
    /// # OPTIONAL
    /// $query.Var.sids = @(
    /// 	$someString
    /// )
    /// # OPTIONAL
    /// $query.Var.insightsMetadataId = $someString
    /// # OPTIONAL
    /// $query.Var.includeInsightsMarker = $someBoolean
    /// # REQUIRED
    /// $query.Var.userAccessObjectsFilter = $someBoolean
    /// # OPTIONAL
    /// $query.Var.objectIdsFilter = @(
    /// 	$someString
    /// )
    /// # OPTIONAL
    /// $query.Var.platformFilter = @(
    /// 	$somePlatform # Call [Enum]::GetValues([RubrikSecurityCloud.Types.Platform]) for enum values.
    /// )
    /// # OPTIONAL
    /// $query.Var.platformCategoryFilter = @(
    /// 	$somePlatformCategory # Call [Enum]::GetValues([RubrikSecurityCloud.Types.PlatformCategory]) for enum values.
    /// )
    /// # OPTIONAL
    /// $query.Var.cloudAccountIdsFilter = @(
    /// 	$someString
    /// )
    /// # OPTIONAL
    /// $query.Var.resourceGroupsFilter = @(
    /// 	$someString
    /// )
    /// # OPTIONAL
    /// $query.Var.regionsFilter = @(
    /// 	$someString
    /// )
    /// # OPTIONAL
    /// $query.Var.dataTypeIdsFilter = @(
    /// 	$someString
    /// )
    /// # OPTIONAL
    /// $query.Var.firstSeenTimeRange = @{
    /// 	# OPTIONAL
    /// 	startTime = $someString
    /// 	# OPTIONAL
    /// 	endTime = $someString
    /// 	# OPTIONAL
    /// 	timezone = $someString
    /// }
    /// # OPTIONAL
    /// $query.Var.lastAccessTimeRange = @{
    /// 	# OPTIONAL
    /// 	startTime = $someString
    /// 	# OPTIONAL
    /// 	endTime = $someString
    /// 	# OPTIONAL
    /// 	timezone = $someString
    /// }
    /// # OPTIONAL
    /// $query.Var.creationTimeRange = @{
    /// 	# OPTIONAL
    /// 	startTime = $someString
    /// 	# OPTIONAL
    /// 	endTime = $someString
    /// 	# OPTIONAL
    /// 	timezone = $someString
    /// }
    /// # OPTIONAL
    /// $query.Var.lastScanTimeRange = @{
    /// 	# OPTIONAL
    /// 	startTime = $someString
    /// 	# OPTIONAL
    /// 	endTime = $someString
    /// 	# OPTIONAL
    /// 	timezone = $someString
    /// }
    /// # OPTIONAL
    /// $query.Var.objectTagsFilter = @{
    /// 	# REQUIRED
    /// 	objectTags = @(
    /// 		@{
    /// 			# OPTIONAL
    /// 			key = $someString
    /// 			# OPTIONAL
    /// 			value = $someString
    /// 		}
    /// 	)
    /// }
    /// # OPTIONAL
    /// $query.Var.mipLabelsFilter = @(
    /// 	@{
    /// 		# OPTIONAL
    /// 		siteId = $someString
    /// 		# OPTIONAL
    /// 		labelId = $someString
    /// 		# OPTIONAL
    /// 		labelName = $someString
    /// }
    /// )
    /// # OPTIONAL
    /// $query.Var.backupStatusFilter = @(
    /// 	$someBackupStatus # Call [Enum]::GetValues([RubrikSecurityCloud.Types.BackupStatus]) for enum values.
    /// )
    /// # OPTIONAL
    /// $query.Var.slaIdsFilter = @(
    /// 	$someString
    /// )
    /// # OPTIONAL
    /// $query.Var.networkAccessFilter = @(
    /// 	$someNetworkAccess # Call [Enum]::GetValues([RubrikSecurityCloud.Types.NetworkAccess]) for enum values.
    /// )
    /// # OPTIONAL
    /// $query.Var.encryptionFilter = @(
    /// 	$someEncryption # Call [Enum]::GetValues([RubrikSecurityCloud.Types.Encryption]) for enum values.
    /// )
    /// # OPTIONAL
    /// $query.Var.loggingFilter = @(
    /// 	$someLogging # Call [Enum]::GetValues([RubrikSecurityCloud.Types.Logging]) for enum values.
    /// )
    /// # OPTIONAL
    /// $query.Var.violationSeverityFilter = @(
    /// 	$someViolationSeverity # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ViolationSeverity]) for enum values.
    /// )
    /// # OPTIONAL
    /// $query.Var.exposureFilter = @(
    /// 	$someOpenAccessType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.OpenAccessType]) for enum values.
    /// )
    /// # OPTIONAL
    /// $query.Var.first = $someInt
    /// # OPTIONAL
    /// $query.Var.after = $someString
    /// # OPTIONAL
    /// $query.Var.last = $someInt
    /// # OPTIONAL
    /// $query.Var.before = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: PolicyObjConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the PrechecksStatus operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: PrechecksStatus
    /// 
    /// $query = New-RscQueryMisc -Operation PrechecksStatus
    /// 
    /// # REQUIRED
    /// $query.Var.clusterUuid = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: PrechecksStatusReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the PrechecksStatusWithNextJobInfo operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: PrechecksStatusWithNextJobInfo
    /// 
    /// $query = New-RscQueryMisc -Operation PrechecksStatusWithNextJobInfo
    /// 
    /// # REQUIRED
    /// $query.Var.clusterUuid = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: PrechecksStatusReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the PrivateContainerRegistry operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: PrivateContainerRegistry
    /// 
    /// $query = New-RscQueryMisc -Operation PrivateContainerRegistry
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
    /// Write-Host $result.GetType().Name # prints: PrivateContainerRegistryReplyType
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the ProductDocumentation operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: ProductDocumentation
    /// 
    /// $query = New-RscQueryMisc -Operation ProductDocumentation
    /// 
    /// # REQUIRED
    /// $query.Var.id = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: ProductDocumentation
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the ProtectedObjectsList operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: ProtectedObjectsList
    /// 
    /// $query = New-RscQueryMisc -Operation ProtectedObjectsList
    /// 
    /// # OPTIONAL
    /// $query.Var.rootOptionalFid = $someString
    /// # REQUIRED
    /// $query.Var.slaIds = @(
    /// 	$someString
    /// )
    /// # OPTIONAL
    /// $query.Var.filter = @(
    /// 	@{
    /// 		# OPTIONAL
    /// 		field = $someHierarchyFilterField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchyFilterField]) for enum values.
    /// 		# OPTIONAL
    /// 		texts = @(
    /// 			$someString
    /// 		)
    /// 		# OPTIONAL
    /// 		tagFilterParams = @(
    /// 			@{
    /// 				# OPTIONAL
    /// 				filterType = $someTagFilterType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TagFilterType]) for enum values.
    /// 				# OPTIONAL
    /// 				tagKey = $someString
    /// 				# OPTIONAL
    /// 				tagValue = $someString
    /// 			}
    /// 		)
    /// 		# OPTIONAL
    /// 		objectTypeFilterParams = @(
    /// 			$someManagedObjectType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ManagedObjectType]) for enum values.
    /// 		)
    /// 		# OPTIONAL
    /// 		awsNativeProtectionFeatureNames = @(
    /// 			$someAwsNativeProtectionFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeProtectionFeature]) for enum values.
    /// 		)
    /// 		# OPTIONAL
    /// 		isNegative = $someBoolean
    /// 		# OPTIONAL
    /// 		isSlowSearchEnabled = $someBoolean
    /// 		# OPTIONAL
    /// 		azureNativeProtectionFeatureNames = @(
    /// 			$someAzureNativeProtectionFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeProtectionFeature]) for enum values.
    /// 		)
    /// 		# OPTIONAL
    /// 		unmanagedObjectAvailabilityFilter = @(
    /// 			$someUnmanagedObjectAvailabilityFilter # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UnmanagedObjectAvailabilityFilter]) for enum values.
    /// 		)
    /// }
    /// )
    /// # OPTIONAL
    /// $query.Var.objectTypeFilter = @(
    /// 	$someString
    /// )
    /// # OPTIONAL
    /// $query.Var.sortBy = $someHierarchySortByField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchySortByField]) for enum values.
    /// # OPTIONAL
    /// $query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
    /// # OPTIONAL
    /// $query.Var.first = $someInt
    /// # OPTIONAL
    /// $query.Var.after = $someString
    /// # OPTIONAL
    /// $query.Var.last = $someInt
    /// # OPTIONAL
    /// $query.Var.before = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: ProtectedObjectsConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the ProtectedVolumesCount operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: ProtectedVolumesCount
    /// 
    /// $query = New-RscQueryMisc -Operation ProtectedVolumesCount
    /// 
    /// # OPTIONAL
    /// $query.Var.filter = @(
    /// 	@{
    /// 		# OPTIONAL
    /// 		field = $someHierarchyFilterField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchyFilterField]) for enum values.
    /// 		# OPTIONAL
    /// 		texts = @(
    /// 			$someString
    /// 		)
    /// 		# OPTIONAL
    /// 		tagFilterParams = @(
    /// 			@{
    /// 				# OPTIONAL
    /// 				filterType = $someTagFilterType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TagFilterType]) for enum values.
    /// 				# OPTIONAL
    /// 				tagKey = $someString
    /// 				# OPTIONAL
    /// 				tagValue = $someString
    /// 			}
    /// 		)
    /// 		# OPTIONAL
    /// 		objectTypeFilterParams = @(
    /// 			$someManagedObjectType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ManagedObjectType]) for enum values.
    /// 		)
    /// 		# OPTIONAL
    /// 		awsNativeProtectionFeatureNames = @(
    /// 			$someAwsNativeProtectionFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeProtectionFeature]) for enum values.
    /// 		)
    /// 		# OPTIONAL
    /// 		isNegative = $someBoolean
    /// 		# OPTIONAL
    /// 		isSlowSearchEnabled = $someBoolean
    /// 		# OPTIONAL
    /// 		azureNativeProtectionFeatureNames = @(
    /// 			$someAzureNativeProtectionFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeProtectionFeature]) for enum values.
    /// 		)
    /// 		# OPTIONAL
    /// 		unmanagedObjectAvailabilityFilter = @(
    /// 			$someUnmanagedObjectAvailabilityFilter # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UnmanagedObjectAvailabilityFilter]) for enum values.
    /// 		)
    /// }
    /// )
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: System.Int32
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the QuarantinedDetailsForWorkload operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: QuarantinedDetailsForWorkload
    /// 
    /// $query = New-RscQueryMisc -Operation QuarantinedDetailsForWorkload
    /// 
    /// # REQUIRED
    /// $query.Var.workloadId = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: List&lt;QuarantineSpec&gt;
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the QueryDatastoreFreespaceThresholds operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: QueryDatastoreFreespaceThresholds
    /// 
    /// $query = New-RscQueryMisc -Operation QueryDatastoreFreespaceThresholds
    /// 
    /// # REQUIRED
    /// $query.Var.queryDatastoreFreespaceThresholdsInput = @(
    /// 	@{
    /// 		# REQUIRED
    /// 		clusterUuid = $someString
    /// 		# OPTIONAL
    /// 		vmId = $someString
    /// }
    /// )
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: QueryDatastoreFreespaceThresholdsReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the RemovedNodeDetails operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: RemovedNodeDetails
    /// 
    /// $query = New-RscQueryMisc -Operation RemovedNodeDetails
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	clusterUuid = $someString
    /// 	# REQUIRED
    /// 	nodeNames = @(
    /// 		$someString
    /// 	)
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: RemoveNodeDetailsReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the RoleTemplates operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: RoleTemplates
    /// 
    /// $query = New-RscQueryMisc -Operation RoleTemplates
    /// 
    /// # OPTIONAL
    /// $query.Var.first = $someInt
    /// # OPTIONAL
    /// $query.Var.after = $someString
    /// # OPTIONAL
    /// $query.Var.last = $someInt
    /// # OPTIONAL
    /// $query.Var.before = $someString
    /// # OPTIONAL
    /// $query.Var.nameFilter = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: RoleTemplateConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the RscPermsToCdmInfo operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: RscPermsToCdmInfo
    /// 
    /// $query = New-RscQueryMisc -Operation RscPermsToCdmInfo
    /// 
    /// # OPTIONAL
    /// $query.Var.first = $someInt
    /// # OPTIONAL
    /// $query.Var.after = $someString
    /// # OPTIONAL
    /// $query.Var.last = $someInt
    /// # OPTIONAL
    /// $query.Var.before = $someString
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
    /// # OPTIONAL
    /// $query.Var.roleId = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: RscPermsToCdmInfoOut
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the SearchFileByPrefix operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: SearchFileByPrefix
    /// 
    /// $query = New-RscQueryMisc -Operation SearchFileByPrefix
    /// 
    /// # REQUIRED
    /// $query.Var.clusterUuid = $someString
    /// # REQUIRED
    /// $query.Var.managedId = $someString
    /// # REQUIRED
    /// $query.Var.snapshotId = $someString
    /// # REQUIRED
    /// $query.Var.searchFolderPath = $someString
    /// # REQUIRED
    /// $query.Var.filenamePrefix = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: DiffResult
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the SnoozedDirectories operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: SnoozedDirectories
    /// 
    /// $query = New-RscQueryMisc -Operation SnoozedDirectories
    /// 
    /// # OPTIONAL
    /// $query.Var.first = $someInt
    /// # OPTIONAL
    /// $query.Var.after = $someString
    /// # OPTIONAL
    /// $query.Var.last = $someInt
    /// # OPTIONAL
    /// $query.Var.before = $someString
    /// # OPTIONAL
    /// $query.Var.snoozeStatusFilter = @(
    /// 	$someSnoozeStatus # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SnoozeStatus]) for enum values.
    /// )
    /// # OPTIONAL
    /// $query.Var.directorySearchFilter = $someString
    /// # OPTIONAL
    /// $query.Var.falsePositiveTypeFilter = @(
    /// 	$someAnomalyFalsePositiveType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AnomalyFalsePositiveType]) for enum values.
    /// )
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: SnoozedDirectoryConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the SsoGroupAlreadyExists operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: SsoGroupAlreadyExists
    /// 
    /// $query = New-RscQueryMisc -Operation SsoGroupAlreadyExists
    /// 
    /// # REQUIRED
    /// $query.Var.ssoGroupName = $someString
    /// # OPTIONAL
    /// $query.Var.userDomainId = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: SsoGroupAlreadyExistsReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the SupportBundle operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: SupportBundle
    /// 
    /// $query = New-RscQueryMisc -Operation SupportBundle
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
    /// Write-Host $result.GetType().Name # prints: AsyncRequestStatus
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the SupportUserAccesses operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: SupportUserAccesses
    /// 
    /// $query = New-RscQueryMisc -Operation SupportUserAccesses
    /// 
    /// # OPTIONAL
    /// $query.Var.first = $someInt
    /// # OPTIONAL
    /// $query.Var.after = $someString
    /// # OPTIONAL
    /// $query.Var.last = $someInt
    /// # OPTIONAL
    /// $query.Var.before = $someString
    /// # OPTIONAL
    /// $query.Var.sortBy = $someSupportUserAccessSortByField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SupportUserAccessSortByField]) for enum values.
    /// # OPTIONAL
    /// $query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
    /// # OPTIONAL
    /// $query.Var.filters = @(
    /// 	@{
    /// 		# OPTIONAL
    /// 		text = $someString
    /// 		# REQUIRED
    /// 		field = $someSupportUserAccessFilterField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SupportUserAccessFilterField]) for enum values.
    /// }
    /// )
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: SupportUserAccessConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the TableFilters operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: TableFilters
    /// 
    /// $query = New-RscQueryMisc -Operation TableFilters
    /// 
    /// # No variables for this query.
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: TableFilters
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the Targets operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: Targets
    /// 
    /// $query = New-RscQueryMisc -Operation Targets
    /// 
    /// # OPTIONAL
    /// $query.Var.sortBy = $someArchivalLocationQuerySortByField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ArchivalLocationQuerySortByField]) for enum values.
    /// # OPTIONAL
    /// $query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
    /// # OPTIONAL
    /// $query.Var.filter = @(
    /// 	@{
    /// 		# OPTIONAL
    /// 		field = $someTargetQueryFilterField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TargetQueryFilterField]) for enum values.
    /// 		# OPTIONAL
    /// 		text = $someString
    /// 		# OPTIONAL
    /// 		textList = @(
    /// 			$someString
    /// 		)
    /// }
    /// )
    /// # OPTIONAL
    /// $query.Var.contextFilter = $someContextFilterTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ContextFilterTypeEnum]) for enum values.
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: List&lt;Target&gt;
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the TaskDetailGroupByList operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: TaskDetailGroupByList
    /// 
    /// $query = New-RscQueryMisc -Operation TaskDetailGroupByList
    /// 
    /// # OPTIONAL
    /// $query.Var.first = $someInt
    /// # OPTIONAL
    /// $query.Var.after = $someString
    /// # OPTIONAL
    /// $query.Var.last = $someInt
    /// # OPTIONAL
    /// $query.Var.before = $someString
    /// # OPTIONAL
    /// $query.Var.filter = @{
    /// 	# OPTIONAL
    /// 	clusterUuid = @(
    /// 		$someString
    /// 	)
    /// 	# OPTIONAL
    /// 	clusterType = @(
    /// 		$someString
    /// 	)
    /// 	# OPTIONAL
    /// 	clusterLocation = @(
    /// 		$someString
    /// 	)
    /// 	# OPTIONAL
    /// 	objectType = @(
    /// 		$someString
    /// 	)
    /// 	# OPTIONAL
    /// 	slaDomain = @{
    /// 		# OPTIONAL
    /// 		id = @(
    /// 			$someString
    /// 		)
    /// 	}
    /// 	# OPTIONAL
    /// 	replicationSource = @(
    /// 		$someString
    /// 	)
    /// 	# OPTIONAL
    /// 	taskCategory = @(
    /// 		$someString
    /// 	)
    /// 	# OPTIONAL
    /// 	taskStatus = @(
    /// 		$someString
    /// 	)
    /// 	# OPTIONAL
    /// 	taskType = @(
    /// 		$someString
    /// 	)
    /// 	# OPTIONAL
    /// 	time_gt = $someDateTime
    /// 	# OPTIONAL
    /// 	time_lt = $someDateTime
    /// 	# OPTIONAL
    /// 	searchTerm = $someString
    /// 	# OPTIONAL
    /// 	orgId = @(
    /// 		$someString
    /// 	)
    /// }
    /// # REQUIRED
    /// $query.Var.groupBy = $someTaskDetailGroupByEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TaskDetailGroupByEnum]) for enum values.
    /// # OPTIONAL
    /// $query.Var.timezoneOffset = $someSingle
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: TaskDetailGroupByConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the TaskDetailList operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: TaskDetailList
    /// 
    /// $query = New-RscQueryMisc -Operation TaskDetailList
    /// 
    /// # OPTIONAL
    /// $query.Var.first = $someInt
    /// # OPTIONAL
    /// $query.Var.after = $someString
    /// # OPTIONAL
    /// $query.Var.last = $someInt
    /// # OPTIONAL
    /// $query.Var.before = $someString
    /// # OPTIONAL
    /// $query.Var.filter = @{
    /// 	# OPTIONAL
    /// 	clusterUuid = @(
    /// 		$someString
    /// 	)
    /// 	# OPTIONAL
    /// 	clusterType = @(
    /// 		$someString
    /// 	)
    /// 	# OPTIONAL
    /// 	clusterLocation = @(
    /// 		$someString
    /// 	)
    /// 	# OPTIONAL
    /// 	objectType = @(
    /// 		$someString
    /// 	)
    /// 	# OPTIONAL
    /// 	slaDomain = @{
    /// 		# OPTIONAL
    /// 		id = @(
    /// 			$someString
    /// 		)
    /// 	}
    /// 	# OPTIONAL
    /// 	replicationSource = @(
    /// 		$someString
    /// 	)
    /// 	# OPTIONAL
    /// 	taskCategory = @(
    /// 		$someString
    /// 	)
    /// 	# OPTIONAL
    /// 	taskStatus = @(
    /// 		$someString
    /// 	)
    /// 	# OPTIONAL
    /// 	taskType = @(
    /// 		$someString
    /// 	)
    /// 	# OPTIONAL
    /// 	time_gt = $someDateTime
    /// 	# OPTIONAL
    /// 	time_lt = $someDateTime
    /// 	# OPTIONAL
    /// 	searchTerm = $someString
    /// 	# OPTIONAL
    /// 	orgId = @(
    /// 		$someString
    /// 	)
    /// }
    /// # OPTIONAL
    /// $query.Var.sortBy = $someTaskDetailSortByEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TaskDetailSortByEnum]) for enum values.
    /// # OPTIONAL
    /// $query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
    /// # OPTIONAL
    /// $query.Var.timezoneOffset = $someSingle
    /// # OPTIONAL
    /// $query.Var.timezone = $someTimezone
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: TaskDetailConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the Taskchain operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: Taskchain
    /// 
    /// $query = New-RscQueryMisc -Operation Taskchain
    /// 
    /// # REQUIRED
    /// $query.Var.taskchainId = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: Taskchain
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the TeamChannelNameAvailable operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: TeamChannelNameAvailable
    /// 
    /// $query = New-RscQueryMisc -Operation TeamChannelNameAvailable
    /// 
    /// # REQUIRED
    /// $query.Var.teamUUID = $someString
    /// # REQUIRED
    /// $query.Var.channelName = $someString
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
    /// Runs the TotpConfigStatus operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: TotpConfigStatus
    /// 
    /// $query = New-RscQueryMisc -Operation TotpConfigStatus
    /// 
    /// # REQUIRED
    /// $query.Var.userId = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: GetTotpStatusReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the TprConfiguration operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: TprConfiguration
    /// 
    /// $query = New-RscQueryMisc -Operation TprConfiguration
    /// 
    /// # REQUIRED
    /// $query.Var.orgId = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: TprConfiguration
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the TprPublicConfiguration operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: TprPublicConfiguration
    /// 
    /// $query = New-RscQueryMisc -Operation TprPublicConfiguration
    /// 
    /// # REQUIRED
    /// $query.Var.orgId = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: TprPublicConfiguration
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the TprRequestDetail operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: TprRequestDetail
    /// 
    /// $query = New-RscQueryMisc -Operation TprRequestDetail
    /// 
    /// # REQUIRED
    /// $query.Var.tprRequestId = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: TprRequestDetailReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the TprRequestSummaries operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: TprRequestSummaries
    /// 
    /// $query = New-RscQueryMisc -Operation TprRequestSummaries
    /// 
    /// # OPTIONAL
    /// $query.Var.first = $someInt
    /// # OPTIONAL
    /// $query.Var.after = $someString
    /// # OPTIONAL
    /// $query.Var.last = $someInt
    /// # OPTIONAL
    /// $query.Var.before = $someString
    /// # OPTIONAL
    /// $query.Var.filter = @{
    /// 	# OPTIONAL
    /// 	timeGt = $someDateTime
    /// 	# OPTIONAL
    /// 	timeLt = $someDateTime
    /// 	# OPTIONAL
    /// 	statuses = @(
    /// 		$someTprReqStatus # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TprReqStatus]) for enum values.
    /// 	)
    /// 	# OPTIONAL
    /// 	orgs = @(
    /// 		$someString
    /// 	)
    /// 	# OPTIONAL
    /// 	submittedBy = $someTprSubmittedByUser # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TprSubmittedByUser]) for enum values.
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: TprRequestSummaryConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the TprRoleEligibility operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: TprRoleEligibility
    /// 
    /// $query = New-RscQueryMisc -Operation TprRoleEligibility
    /// 
    /// # REQUIRED
    /// $query.Var.orgId = $someString
    /// # REQUIRED
    /// $query.Var.email = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: TprRoleEligibilityType
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the TprRulesMap operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: TprRulesMap
    /// 
    /// $query = New-RscQueryMisc -Operation TprRulesMap
    /// 
    /// # No variables for this query.
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: TprRulesMap
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the TprStatusForNodeRemoval operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: TprStatusForNodeRemoval
    /// 
    /// $query = New-RscQueryMisc -Operation TprStatusForNodeRemoval
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	clusterUuid = $someString
    /// 	# REQUIRED
    /// 	tprRequestId = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: TprStatusForNodeRemoval
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the TunnelStatus operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: TunnelStatus
    /// 
    /// $query = New-RscQueryMisc -Operation TunnelStatus
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
    /// Write-Host $result.GetType().Name # prints: SupportTunnelInfo
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the UniqueVcdCount operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: UniqueVcdCount
    /// 
    /// $query = New-RscQueryMisc -Operation UniqueVcdCount
    /// 
    /// # OPTIONAL
    /// $query.Var.filter = @(
    /// 	@{
    /// 		# OPTIONAL
    /// 		field = $someHierarchyFilterField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchyFilterField]) for enum values.
    /// 		# OPTIONAL
    /// 		texts = @(
    /// 			$someString
    /// 		)
    /// 		# OPTIONAL
    /// 		tagFilterParams = @(
    /// 			@{
    /// 				# OPTIONAL
    /// 				filterType = $someTagFilterType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TagFilterType]) for enum values.
    /// 				# OPTIONAL
    /// 				tagKey = $someString
    /// 				# OPTIONAL
    /// 				tagValue = $someString
    /// 			}
    /// 		)
    /// 		# OPTIONAL
    /// 		objectTypeFilterParams = @(
    /// 			$someManagedObjectType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ManagedObjectType]) for enum values.
    /// 		)
    /// 		# OPTIONAL
    /// 		awsNativeProtectionFeatureNames = @(
    /// 			$someAwsNativeProtectionFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeProtectionFeature]) for enum values.
    /// 		)
    /// 		# OPTIONAL
    /// 		isNegative = $someBoolean
    /// 		# OPTIONAL
    /// 		isSlowSearchEnabled = $someBoolean
    /// 		# OPTIONAL
    /// 		azureNativeProtectionFeatureNames = @(
    /// 			$someAzureNativeProtectionFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeProtectionFeature]) for enum values.
    /// 		)
    /// 		# OPTIONAL
    /// 		unmanagedObjectAvailabilityFilter = @(
    /// 			$someUnmanagedObjectAvailabilityFilter # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UnmanagedObjectAvailabilityFilter]) for enum values.
    /// 		)
    /// }
    /// )
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: System.Int32
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the UnmanagedObjects operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: UnmanagedObjects
    /// 
    /// $query = New-RscQueryMisc -Operation UnmanagedObjects
    /// 
    /// # OPTIONAL
    /// $query.Var.first = $someInt
    /// # OPTIONAL
    /// $query.Var.after = $someString
    /// # OPTIONAL
    /// $query.Var.last = $someInt
    /// # OPTIONAL
    /// $query.Var.before = $someString
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	clusterUuid = $someString
    /// 	# OPTIONAL
    /// 	name = $someString
    /// 	# REQUIRED
    /// 	unmanagedStatuses = @(
    /// 		$someUnmanagedObjectAvailabilityFilter # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UnmanagedObjectAvailabilityFilter]) for enum values.
    /// 	)
    /// 	# REQUIRED
    /// 	objectTypes = @(
    /// 		$someManagedObjectType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ManagedObjectType]) for enum values.
    /// 	)
    /// 	# REQUIRED
    /// 	retentionSlaDomainIds = @(
    /// 		$someString
    /// 	)
    /// 	# OPTIONAL
    /// 	sortParam = @{
    /// 		# OPTIONAL
    /// 		type = $someUnmanagedObjectsSortType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UnmanagedObjectsSortType]) for enum values.
    /// 		# OPTIONAL
    /// 		sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
    /// 	}
    /// 	# OPTIONAL
    /// 	objectId = $someString
    /// 	# OPTIONAL
    /// 	regions = @(
    /// 		@{
    /// 			# REQUIRED
    /// 			gcpNativeRegion = $someString
    /// 			# REQUIRED
    /// 			awsNativeRegion = $someAwsNativeRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRegion]) for enum values.
    /// 			# REQUIRED
    /// 			azureNativeRegion = $someAzureNativeRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeRegion]) for enum values.
    /// 		}
    /// 	)
    /// 	# OPTIONAL
    /// 	cloudAccountIds = @(
    /// 		$someString
    /// 	)
    /// 	# OPTIONAL
    /// 	managedBy = $someCloudVendor # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudVendor]) for enum values.
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: UnmanagedObjectDetailConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the UnmanagedObjectsSupportedTypes operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: UnmanagedObjectsSupportedTypes
    /// 
    /// $query = New-RscQueryMisc -Operation UnmanagedObjectsSupportedTypes
    /// 
    /// # OPTIONAL
    /// $query.Var.productType = $someProductTargetType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ProductTargetType]) for enum values.
    /// # OPTIONAL
    /// $query.Var.cloudVendor = $someCloudVendor # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudVendor]) for enum values.
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: List&lt;ManagedObjectType&gt;
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the UpgradeStatus operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: UpgradeStatus
    /// 
    /// $query = New-RscQueryMisc -Operation UpgradeStatus
    /// 
    /// # REQUIRED
    /// $query.Var.clusterUuid = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: UpgradeStatusReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the UserActivities operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: UserActivities
    /// 
    /// $query = New-RscQueryMisc -Operation UserActivities
    /// 
    /// # OPTIONAL
    /// $query.Var.filter = @{
    /// 	# OPTIONAL
    /// 	openAccessTypes = @(
    /// 		$someOpenAccessType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.OpenAccessType]) for enum values.
    /// 	)
    /// 	# OPTIONAL
    /// 	stalenessTypes = @(
    /// 		$someStalenessType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.StalenessType]) for enum values.
    /// 	)
    /// 	# OPTIONAL
    /// 	analyzerGroupIds = @(
    /// 		$someString
    /// 	)
    /// 	# OPTIONAL
    /// 	clusterIds = @(
    /// 		$someString
    /// 	)
    /// 	# OPTIONAL
    /// 	pathPrefix = $someString
    /// 	# OPTIONAL
    /// 	snappableTypes = @(
    /// 		$someString
    /// 	)
    /// 	# OPTIONAL
    /// 	searchText = $someString
    /// 	# OPTIONAL
    /// 	whitelistEnabled = $someBoolean
    /// 	# OPTIONAL
    /// 	fileCountTypes = @(
    /// 		$someFileCountType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.FileCountType]) for enum values.
    /// 	)
    /// 	# OPTIONAL
    /// 	accessTypes = @(
    /// 		$someAccessType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AccessType]) for enum values.
    /// 	)
    /// 	# OPTIONAL
    /// 	activityTypes = @(
    /// 		$someActivityAccessType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ActivityAccessType]) for enum values.
    /// 	)
    /// 	# OPTIONAL
    /// 	objectIds = @(
    /// 		$someString
    /// 	)
    /// 	# OPTIONAL
    /// 	inodeTypes = @(
    /// 		$someInodeType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.InodeType]) for enum values.
    /// 	)
    /// 	# REQUIRED
    /// 	objectTypes = @(
    /// 		$someHierarchyObjectTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchyObjectTypeEnum]) for enum values.
    /// 	)
    /// }
    /// # OPTIONAL
    /// $query.Var.sort = @{
    /// 	# OPTIONAL
    /// 	sortBy = $someFileResultSortBy # Call [Enum]::GetValues([RubrikSecurityCloud.Types.FileResultSortBy]) for enum values.
    /// 	# OPTIONAL
    /// 	sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
    /// 	# OPTIONAL
    /// 	analyzerGroupId = $someString
    /// 	# OPTIONAL
    /// 	dataTypeId = $someString
    /// }
    /// # OPTIONAL
    /// $query.Var.timeRange = @{
    /// 	# OPTIONAL
    /// 	startTime = $someString
    /// 	# OPTIONAL
    /// 	endTime = $someString
    /// 	# OPTIONAL
    /// 	timezone = $someString
    /// }
    /// # REQUIRED
    /// $query.Var.userId = $someString
    /// # OPTIONAL
    /// $query.Var.first = $someInt
    /// # OPTIONAL
    /// $query.Var.after = $someString
    /// # OPTIONAL
    /// $query.Var.last = $someInt
    /// # OPTIONAL
    /// $query.Var.before = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: FileResultConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the UserAlreadyExists operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: UserAlreadyExists
    /// 
    /// $query = New-RscQueryMisc -Operation UserAlreadyExists
    /// 
    /// # REQUIRED
    /// $query.Var.emailOrUsername = $someString
    /// # REQUIRED
    /// $query.Var.userDomain = $someUserDomainEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UserDomainEnum]) for enum values.
    /// # OPTIONAL
    /// $query.Var.userDomainId = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: UserAlreadyExistsReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the UserAnalyzerAccess operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: UserAnalyzerAccess
    /// 
    /// $query = New-RscQueryMisc -Operation UserAnalyzerAccess
    /// 
    /// # REQUIRED
    /// $query.Var.userId = $someString
    /// # REQUIRED
    /// $query.Var.startDay = $someString
    /// # REQUIRED
    /// $query.Var.timezone = $someString
    /// # REQUIRED
    /// $query.Var.limit = $someInt
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AnalyzerAccessUsageConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the UserAuditList operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: UserAuditList
    /// 
    /// $query = New-RscQueryMisc -Operation UserAuditList
    /// 
    /// # OPTIONAL
    /// $query.Var.first = $someInt
    /// # OPTIONAL
    /// $query.Var.after = $someString
    /// # OPTIONAL
    /// $query.Var.last = $someInt
    /// # OPTIONAL
    /// $query.Var.before = $someString
    /// # OPTIONAL
    /// $query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
    /// # OPTIONAL
    /// $query.Var.sortBy = $someUserAuditSortField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UserAuditSortField]) for enum values.
    /// # OPTIONAL
    /// $query.Var.filters = @{
    /// 	# OPTIONAL
    /// 	auditSeverity = @(
    /// 		$someAuditSeverity # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AuditSeverity]) for enum values.
    /// 	)
    /// 	# OPTIONAL
    /// 	auditStatus = @(
    /// 		$someAuditStatus # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AuditStatus]) for enum values.
    /// 	)
    /// 	# OPTIONAL
    /// 	auditType = @(
    /// 		$someAuditType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AuditType]) for enum values.
    /// 	)
    /// 	# OPTIONAL
    /// 	auditObjectType = @(
    /// 		$someAuditObjectType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AuditObjectType]) for enum values.
    /// 	)
    /// 	# OPTIONAL
    /// 	clusterId = @(
    /// 		$someString
    /// 	)
    /// 	# OPTIONAL
    /// 	objectIds = @(
    /// 		$someString
    /// 	)
    /// 	# OPTIONAL
    /// 	objectFids = @(
    /// 		$someString
    /// 	)
    /// 	# OPTIONAL
    /// 	timeGt = $someDateTime
    /// 	# OPTIONAL
    /// 	timeLt = $someDateTime
    /// 	# OPTIONAL
    /// 	hasUserNote = $someBoolean
    /// 	# OPTIONAL
    /// 	searchTerm = $someString
    /// 	# OPTIONAL
    /// 	orgIds = @(
    /// 		$someString
    /// 	)
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: UserAuditConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the UserDetail operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: UserDetail
    /// 
    /// $query = New-RscQueryMisc -Operation UserDetail
    /// 
    /// # REQUIRED
    /// $query.Var.userId = $someString
    /// # REQUIRED
    /// $query.Var.startDay = $someString
    /// # REQUIRED
    /// $query.Var.timezone = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: GetUserDetailReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the UserFile operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: UserFile
    /// 
    /// $query = New-RscQueryMisc -Operation UserFile
    /// 
    /// # REQUIRED
    /// $query.Var.externalId = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: CustomerFacingFile
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the UserFiles operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: UserFiles
    /// 
    /// $query = New-RscQueryMisc -Operation UserFiles
    /// 
    /// # OPTIONAL
    /// $query.Var.first = $someInt
    /// # OPTIONAL
    /// $query.Var.after = $someString
    /// # OPTIONAL
    /// $query.Var.last = $someInt
    /// # OPTIONAL
    /// $query.Var.before = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: List&lt;GetCustomerFacingDownloadsReply&gt;
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the UserGroups operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: UserGroups
    /// 
    /// $query = New-RscQueryMisc -Operation UserGroups
    /// 
    /// # OPTIONAL
    /// $query.Var.first = $someInt
    /// # OPTIONAL
    /// $query.Var.after = $someString
    /// # OPTIONAL
    /// $query.Var.last = $someInt
    /// # OPTIONAL
    /// $query.Var.before = $someString
    /// # OPTIONAL
    /// $query.Var.roleIdsFilter = @(
    /// 	$someString
    /// )
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: List&lt;Group&gt;
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the UserNotifications operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: UserNotifications
    /// 
    /// $query = New-RscQueryMisc -Operation UserNotifications
    /// 
    /// # No variables for this query.
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: UserNotifications
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the UserSessionManagementConfig operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: UserSessionManagementConfig
    /// 
    /// $query = New-RscQueryMisc -Operation UserSessionManagementConfig
    /// 
    /// # No variables for this query.
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: GetUserSessionManagementConfigReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the UserSettings operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: UserSettings
    /// 
    /// $query = New-RscQueryMisc -Operation UserSettings
    /// 
    /// # No variables for this query.
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: UserSettings
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the UsersInCurrentAndDescendantOrganization operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: UsersInCurrentAndDescendantOrganization
    /// 
    /// $query = New-RscQueryMisc -Operation UsersInCurrentAndDescendantOrganization
    /// 
    /// # OPTIONAL
    /// $query.Var.first = $someInt
    /// # OPTIONAL
    /// $query.Var.after = $someString
    /// # OPTIONAL
    /// $query.Var.last = $someInt
    /// # OPTIONAL
    /// $query.Var.before = $someString
    /// # OPTIONAL
    /// $query.Var.sortBy = @{
    /// 	# OPTIONAL
    /// 	field = $someUserSortByField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UserSortByField]) for enum values.
    /// 	# OPTIONAL
    /// 	sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
    /// }
    /// # OPTIONAL
    /// $query.Var.filter = @{
    /// 	# OPTIONAL
    /// 	emailFilter = $someString
    /// 	# OPTIONAL
    /// 	domainFilter = @(
    /// 		$someUserDomainEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UserDomainEnum]) for enum values.
    /// 	)
    /// 	# OPTIONAL
    /// 	orgIdsFilter = @(
    /// 		$someString
    /// 	)
    /// 	# OPTIONAL
    /// 	roleIdsFilter = @(
    /// 		$someString
    /// 	)
    /// 	# OPTIONAL
    /// 	lockoutStateFilter = $someLockoutStateFilter # Call [Enum]::GetValues([RubrikSecurityCloud.Types.LockoutStateFilter]) for enum values.
    /// 	# OPTIONAL
    /// 	hiddenStateFilter = $someHiddenStateFilter # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HiddenStateFilter]) for enum values.
    /// 	# OPTIONAL
    /// 	authDomainIdsFilter = @(
    /// 		$someString
    /// 	)
    /// }
    /// # OPTIONAL
    /// $query.Var.shouldIncludeUserWithoutRole = $someBoolean
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: UserConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the UsersOnAccountList operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: UsersOnAccountList
    /// 
    /// $query = New-RscQueryMisc -Operation UsersOnAccountList
    /// 
    /// # OPTIONAL
    /// $query.Var.first = $someInt
    /// # OPTIONAL
    /// $query.Var.after = $someString
    /// # OPTIONAL
    /// $query.Var.last = $someInt
    /// # OPTIONAL
    /// $query.Var.before = $someString
    /// # OPTIONAL
    /// $query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
    /// # OPTIONAL
    /// $query.Var.sortBy = $someUserFieldEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UserFieldEnum]) for enum values.
    /// # OPTIONAL
    /// $query.Var.emailFilter = $someString
    /// # OPTIONAL
    /// $query.Var.roleIdsFilter = @(
    /// 	$someString
    /// )
    /// # OPTIONAL
    /// $query.Var.lockoutStateFilter = $someLockoutStateFilter # Call [Enum]::GetValues([RubrikSecurityCloud.Types.LockoutStateFilter]) for enum values.
    /// # OPTIONAL
    /// $query.Var.hiddenStateFilter = $someHiddenStateFilter # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HiddenStateFilter]) for enum values.
    /// # REQUIRED
    /// $query.Var.shouldGetLocalUsersOnly = $someBoolean
    /// # OPTIONAL
    /// $query.Var.userDomainsFilter = @(
    /// 	$someUserDomainEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UserDomainEnum]) for enum values.
    /// )
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: UserConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the ValidateOrgName operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: ValidateOrgName
    /// 
    /// $query = New-RscQueryMisc -Operation ValidateOrgName
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	fullName = $someString
    /// 	# OPTIONAL
    /// 	name = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: ValidateOrgNameReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the VcdVappVms operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: VcdVappVms
    /// 
    /// $query = New-RscQueryMisc -Operation VcdVappVms
    /// 
    /// # OPTIONAL
    /// $query.Var.first = $someInt
    /// # OPTIONAL
    /// $query.Var.after = $someString
    /// # OPTIONAL
    /// $query.Var.sortBy = $someHierarchySortByField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchySortByField]) for enum values.
    /// # OPTIONAL
    /// $query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
    /// # OPTIONAL
    /// $query.Var.filter = @(
    /// 	@{
    /// 		# OPTIONAL
    /// 		field = $someHierarchyFilterField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchyFilterField]) for enum values.
    /// 		# OPTIONAL
    /// 		texts = @(
    /// 			$someString
    /// 		)
    /// 		# OPTIONAL
    /// 		tagFilterParams = @(
    /// 			@{
    /// 				# OPTIONAL
    /// 				filterType = $someTagFilterType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TagFilterType]) for enum values.
    /// 				# OPTIONAL
    /// 				tagKey = $someString
    /// 				# OPTIONAL
    /// 				tagValue = $someString
    /// 			}
    /// 		)
    /// 		# OPTIONAL
    /// 		objectTypeFilterParams = @(
    /// 			$someManagedObjectType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ManagedObjectType]) for enum values.
    /// 		)
    /// 		# OPTIONAL
    /// 		awsNativeProtectionFeatureNames = @(
    /// 			$someAwsNativeProtectionFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeProtectionFeature]) for enum values.
    /// 		)
    /// 		# OPTIONAL
    /// 		isNegative = $someBoolean
    /// 		# OPTIONAL
    /// 		isSlowSearchEnabled = $someBoolean
    /// 		# OPTIONAL
    /// 		azureNativeProtectionFeatureNames = @(
    /// 			$someAzureNativeProtectionFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeProtectionFeature]) for enum values.
    /// 		)
    /// 		# OPTIONAL
    /// 		unmanagedObjectAvailabilityFilter = @(
    /// 			$someUnmanagedObjectAvailabilityFilter # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UnmanagedObjectAvailabilityFilter]) for enum values.
    /// 		)
    /// }
    /// )
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: VsphereVmConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the VerifyTotp operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: VerifyTotp
    /// 
    /// $query = New-RscQueryMisc -Operation VerifyTotp
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	otp = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: VerifyTotpReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the VirtualMachineFiles operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: VirtualMachineFiles
    /// 
    /// $query = New-RscQueryMisc -Operation VirtualMachineFiles
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
    /// Write-Host $result.GetType().Name # prints: VirtualMachineFilesReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the VmRecoveryJobsInfo operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: VmRecoveryJobsInfo
    /// 
    /// $query = New-RscQueryMisc -Operation VmRecoveryJobsInfo
    /// 
    /// # REQUIRED
    /// $query.Var.fid = $someString
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
    /// Write-Host $result.GetType().Name # prints: List&lt;VmRecoveryJobInfo&gt;
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the VolumeGroupMounts operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: VolumeGroupMounts
    /// 
    /// $query = New-RscQueryMisc -Operation VolumeGroupMounts
    /// 
    /// # OPTIONAL
    /// $query.Var.first = $someInt
    /// # OPTIONAL
    /// $query.Var.after = $someString
    /// # OPTIONAL
    /// $query.Var.filters = @(
    /// 	@{
    /// 		# OPTIONAL
    /// 		field = $someVolumeGroupLiveMountFilterField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.VolumeGroupLiveMountFilterField]) for enum values.
    /// 		# OPTIONAL
    /// 		texts = @(
    /// 			$someString
    /// 		)
    /// }
    /// )
    /// # OPTIONAL
    /// $query.Var.sortBy = @{
    /// 	# OPTIONAL
    /// 	field = $someVolumeGroupLiveMountSortByField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.VolumeGroupLiveMountSortByField]) for enum values.
    /// 	# OPTIONAL
    /// 	sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: VolumeGroupLiveMountConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the WorkloadAlertSetting operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: WorkloadAlertSetting
    /// 
    /// $query = New-RscQueryMisc -Operation WorkloadAlertSetting
    /// 
    /// # REQUIRED
    /// $query.Var.clusterUuid = $someString
    /// # REQUIRED
    /// $query.Var.workloadId = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: GetWorkloadAlertSettingReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the WorkloadAnomalies operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: WorkloadAnomalies
    /// 
    /// $query = New-RscQueryMisc -Operation WorkloadAnomalies
    /// 
    /// # OPTIONAL
    /// $query.Var.first = $someInt
    /// # OPTIONAL
    /// $query.Var.after = $someString
    /// # OPTIONAL
    /// $query.Var.last = $someInt
    /// # OPTIONAL
    /// $query.Var.before = $someString
    /// # REQUIRED
    /// $query.Var.beginTime = $someDateTime
    /// # OPTIONAL
    /// $query.Var.endTime = $someDateTime
    /// # OPTIONAL
    /// $query.Var.workloadNameSearch = $someString
    /// # OPTIONAL
    /// $query.Var.objectTypeFilter = @(
    /// 	$someString
    /// )
    /// # OPTIONAL
    /// $query.Var.clusterUuidFilter = @(
    /// 	$someString
    /// )
    /// # OPTIONAL
    /// $query.Var.slaFidFilter = @(
    /// 	$someString
    /// )
    /// # OPTIONAL
    /// $query.Var.encryptionFilter = @(
    /// 	$someEncryptionLevel # Call [Enum]::GetValues([RubrikSecurityCloud.Types.EncryptionLevel]) for enum values.
    /// )
    /// # OPTIONAL
    /// $query.Var.severityFilter = @(
    /// 	$someActivitySeverityEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ActivitySeverityEnum]) for enum values.
    /// )
    /// # OPTIONAL
    /// $query.Var.analyzerGroupFilter = @(
    /// 	$someString
    /// )
    /// # OPTIONAL
    /// $query.Var.sortBy = $someWorkloadAnomaliesSortBy # Call [Enum]::GetValues([RubrikSecurityCloud.Types.WorkloadAnomaliesSortBy]) for enum values.
    /// # OPTIONAL
    /// $query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
    /// # OPTIONAL
    /// $query.Var.orderParentsFirst = $someBoolean
    /// # OPTIONAL
    /// $query.Var.blueprintRecoveryTypes = @(
    /// 	$someBlueprintRecoveryType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.BlueprintRecoveryType]) for enum values.
    /// )
    /// # OPTIONAL
    /// $query.Var.locationsFilter = @(
    /// 	$someString
    /// )
    /// # OPTIONAL
    /// $query.Var.resolutionStatusFilter = @(
    /// 	$someResolutionStatus # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ResolutionStatus]) for enum values.
    /// )
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: WorkloadAnomalyConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the WorkloadForeverId operation
    /// of the 'Miscellaneous' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Misc
    /// # API Operation: WorkloadForeverId
    /// 
    /// $query = New-RscQueryMisc -Operation WorkloadForeverId
    /// 
    /// # REQUIRED
    /// $query.Var.clusterUuid = $someString
    /// # REQUIRED
    /// $query.Var.managedId = $someString
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
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscQueryMisc",
        DefaultParameterSetName = "Operation")
    ]
    public class New_RscQueryMisc : RscGqlPSCmdlet
    {
        [Parameter(
            Mandatory = true, 
            ParameterSetName = "Operation",
            HelpMessage = "API Operation. The set of operations depends on the API domain. See reference at: https://github.com/rubrikinc/rubrik-powershell-sdk/blob/main/docs/domains_and_operations.md",
            Position = 0,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = true)]
            [ValidateSet(
                "ActiveCustomAnalyzers",
                "AdGroupMembers",
                "AdVolumeExports",
                "AgentDeploymentSetting",
                "AgentDeploymentSettings",
                "AllowedOrgAdminOperations",
                "AnalyzerGroups",
                "AnalyzerUsages",
                "AnomalyResultOpt",
                "AnomalyResults",
                "AnomalyResultsGrouped",
                "AreMultiGeoBackupsEnabled",
                "AuthorizationsForGlobalResource",
                "AuthorizationsForObject",
                "AuthorizationsForObjects",
                "AwsComputeSettings",
                "AzureResourceGroups",
                "AzureSubnets",
                "BackupThrottleSettings",
                "BrowseCalendar",
                "BrowseContacts",
                "BrowseFolder",
                "BrowseOnedrive",
                "BrowseTeamsChannels",
                "BrowseTeamsDrive",
                "CdmGuestCredentials",
                "CdmInventorySubHierarchyRoot",
                "CdmOvaDetails",
                "CdmVersionCheck",
                "CdpVmsInfos",
                "CheckCloudComputeConnectivityJobProgress",
                "CheckLatestVersionMgmtAppExists",
                "CloudDirectNasExport",
                "CloudDirectNasNamespace",
                "CloudDirectNasNamespaces",
                "CloudDirectNasShare",
                "CloudDirectShares",
                "CloudDirectSites",
                "CloudDirectSystems",
                "ConfiguredGroupMembers",
                "Crawl",
                "Crawls",
                "CrossAccountPairs",
                "CurrentIpAddress",
                "CurrentOrg",
                "CurrentOrgAuthDomainConfig",
                "CurrentOrgIdentityProviders",
                "CustomAnalyzer",
                "DashboardSummary",
                "DatagovSecDesc",
                "DecryptExportUrl",
                "DeploymentIpAddresses",
                "DeploymentVersion",
                "DhrcActiveRecommendations",
                "DhrcLatestMetrics",
                "DhrcScores",
                "DiffFmd",
                "DiscoverNodes",
                "DiscoveryTimeline",
                "DistributionListDigest",
                "DistributionListDigests",
                "DummyFieldWithAdminOnlyTag",
                "EdgeWindowsToolLink",
                "EffectiveRbacPermissions",
                "EventDigests",
                "ExternalDeploymentName",
                "FailedRestoreItemsInfo",
                "FederatedLoginStatus",
                "FileActivities",
                "GeoLocationList",
                "GetAllRolesInOrgList",
                "GetCdmReleaseDetailsForVersionFromSupportPortal",
                "GetCdmReleaseDetailsFromSupportPortal",
                "GetGroupCountByPrechecksStatus",
                "GetGroupCountByUpgradeJobStatus",
                "GetGroupCountByVersionStatus",
                "GetKorgTaskchainStatus",
                "GetPermissions",
                "GetRolesByIds",
                "GetUserDownloads",
                "GlobalFileSearch",
                "GlobalLockoutConfig",
                "GlobalMfaSetting",
                "GlobalSearchResults",
                "GroupsInCurrentAndDescendantOrganization",
                "GuestCredentials",
                "GuestCredentialsV2",
                "HasIdpConfigured",
                "HelpContentSnippets",
                "HierarchyObject",
                "HierarchyObjects",
                "InstalledVersionList",
                "InventoryRoot",
                "InventorySubHierarchyRoot",
                "InventoryWorkloads",
                "InvestigationCsvDownloadLink",
                "IpWhitelist",
                "IsIpmiEnabled",
                "IsLoggedIntoRubrikSupportPortal",
                "IsReplaceNodeTprConfigured",
                "IsSfdcReachable",
                "IsUpgradeAvailable",
                "IsUpgradeRecommended",
                "IsZrsAvailableForLocation",
                "Issue",
                "Issues",
                "IssuesJobIds",
                "JobInfo",
                "KnowledgeBaseArticle",
                "LambdaSettings",
                "LicensedProducts",
                "LockoutConfig",
                "MaxProtectedAppsCount",
                "MfaSetting",
                "MicrosoftSites",
                "MinimumCdmVersionForFeatureSet",
                "MipLabels",
                "NetworkThrottle",
                "NfAnomalyResults",
                "NfAnomalyResultsGrouped",
                "NodeRemovalCancelPermission",
                "NodeToReplace",
                "NodeTunnelStatuses",
                "NosqlStorageLocations",
                "OauthCodesForEdgeReg",
                "ObjectFiles",
                "ObjectTypeAccessSummary",
                "ObjectsAlreadyAssignedToOrgs",
                "Org",
                "Orgs",
                "OrgsByIds",
                "OrgsForPrincipal",
                "PasskeyConfig",
                "PasskeyInfo",
                "PendingAction",
                "PendingActions",
                "PhoenixRolloutProgress",
                "PipelineHealthForTimeRange",
                "PolarisInventorySubHierarchyRoot",
                "PolicyDetails",
                "PolicyObj",
                "PolicyObjs",
                "PrechecksStatus",
                "PrechecksStatusWithNextJobInfo",
                "PrivateContainerRegistry",
                "ProductDocumentation",
                "ProtectedObjectsList",
                "ProtectedVolumesCount",
                "QuarantinedDetailsForWorkload",
                "QueryDatastoreFreespaceThresholds",
                "RemovedNodeDetails",
                "RoleTemplates",
                "RscPermsToCdmInfo",
                "SearchFileByPrefix",
                "SnoozedDirectories",
                "SsoGroupAlreadyExists",
                "SupportBundle",
                "SupportUserAccesses",
                "TableFilters",
                "Targets",
                "TaskDetailGroupByList",
                "TaskDetailList",
                "Taskchain",
                "TeamChannelNameAvailable",
                "TotpConfigStatus",
                "TprConfiguration",
                "TprPublicConfiguration",
                "TprRequestDetail",
                "TprRequestSummaries",
                "TprRoleEligibility",
                "TprRulesMap",
                "TprStatusForNodeRemoval",
                "TunnelStatus",
                "UniqueVcdCount",
                "UnmanagedObjects",
                "UnmanagedObjectsSupportedTypes",
                "UpgradeStatus",
                "UserActivities",
                "UserAlreadyExists",
                "UserAnalyzerAccess",
                "UserAuditList",
                "UserDetail",
                "UserFile",
                "UserFiles",
                "UserGroups",
                "UserNotifications",
                "UserSessionManagementConfig",
                "UserSettings",
                "UsersInCurrentAndDescendantOrganization",
                "UsersOnAccountList",
                "ValidateOrgName",
                "VcdVappVms",
                "VerifyTotp",
                "VirtualMachineFiles",
                "VmRecoveryJobsInfo",
                "VolumeGroupMounts",
                "WorkloadAlertSetting",
                "WorkloadAnomalies",
                "WorkloadForeverId",
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
                    case "ActiveCustomAnalyzers":
                        this.ProcessRecord_ActiveCustomAnalyzers();
                        break;
                    case "AdGroupMembers":
                        this.ProcessRecord_AdGroupMembers();
                        break;
                    case "AdVolumeExports":
                        this.ProcessRecord_AdVolumeExports();
                        break;
                    case "AgentDeploymentSetting":
                        this.ProcessRecord_AgentDeploymentSetting();
                        break;
                    case "AgentDeploymentSettings":
                        this.ProcessRecord_AgentDeploymentSettings();
                        break;
                    case "AllowedOrgAdminOperations":
                        this.ProcessRecord_AllowedOrgAdminOperations();
                        break;
                    case "AnalyzerGroups":
                        this.ProcessRecord_AnalyzerGroups();
                        break;
                    case "AnalyzerUsages":
                        this.ProcessRecord_AnalyzerUsages();
                        break;
                    case "AnomalyResultOpt":
                        this.ProcessRecord_AnomalyResultOpt();
                        break;
                    case "AnomalyResults":
                        this.ProcessRecord_AnomalyResults();
                        break;
                    case "AnomalyResultsGrouped":
                        this.ProcessRecord_AnomalyResultsGrouped();
                        break;
                    case "AreMultiGeoBackupsEnabled":
                        this.ProcessRecord_AreMultiGeoBackupsEnabled();
                        break;
                    case "AuthorizationsForGlobalResource":
                        this.ProcessRecord_AuthorizationsForGlobalResource();
                        break;
                    case "AuthorizationsForObject":
                        this.ProcessRecord_AuthorizationsForObject();
                        break;
                    case "AuthorizationsForObjects":
                        this.ProcessRecord_AuthorizationsForObjects();
                        break;
                    case "AwsComputeSettings":
                        this.ProcessRecord_AwsComputeSettings();
                        break;
                    case "AzureResourceGroups":
                        this.ProcessRecord_AzureResourceGroups();
                        break;
                    case "AzureSubnets":
                        this.ProcessRecord_AzureSubnets();
                        break;
                    case "BackupThrottleSettings":
                        this.ProcessRecord_BackupThrottleSettings();
                        break;
                    case "BrowseCalendar":
                        this.ProcessRecord_BrowseCalendar();
                        break;
                    case "BrowseContacts":
                        this.ProcessRecord_BrowseContacts();
                        break;
                    case "BrowseFolder":
                        this.ProcessRecord_BrowseFolder();
                        break;
                    case "BrowseOnedrive":
                        this.ProcessRecord_BrowseOnedrive();
                        break;
                    case "BrowseTeamsChannels":
                        this.ProcessRecord_BrowseTeamsChannels();
                        break;
                    case "BrowseTeamsDrive":
                        this.ProcessRecord_BrowseTeamsDrive();
                        break;
                    case "CdmGuestCredentials":
                        this.ProcessRecord_CdmGuestCredentials();
                        break;
                    case "CdmInventorySubHierarchyRoot":
                        this.ProcessRecord_CdmInventorySubHierarchyRoot();
                        break;
                    case "CdmOvaDetails":
                        this.ProcessRecord_CdmOvaDetails();
                        break;
                    case "CdmVersionCheck":
                        this.ProcessRecord_CdmVersionCheck();
                        break;
                    case "CdpVmsInfos":
                        this.ProcessRecord_CdpVmsInfos();
                        break;
                    case "CheckCloudComputeConnectivityJobProgress":
                        this.ProcessRecord_CheckCloudComputeConnectivityJobProgress();
                        break;
                    case "CheckLatestVersionMgmtAppExists":
                        this.ProcessRecord_CheckLatestVersionMgmtAppExists();
                        break;
                    case "CloudDirectNasExport":
                        this.ProcessRecord_CloudDirectNasExport();
                        break;
                    case "CloudDirectNasNamespace":
                        this.ProcessRecord_CloudDirectNasNamespace();
                        break;
                    case "CloudDirectNasNamespaces":
                        this.ProcessRecord_CloudDirectNasNamespaces();
                        break;
                    case "CloudDirectNasShare":
                        this.ProcessRecord_CloudDirectNasShare();
                        break;
                    case "CloudDirectShares":
                        this.ProcessRecord_CloudDirectShares();
                        break;
                    case "CloudDirectSites":
                        this.ProcessRecord_CloudDirectSites();
                        break;
                    case "CloudDirectSystems":
                        this.ProcessRecord_CloudDirectSystems();
                        break;
                    case "ConfiguredGroupMembers":
                        this.ProcessRecord_ConfiguredGroupMembers();
                        break;
                    case "Crawl":
                        this.ProcessRecord_Crawl();
                        break;
                    case "Crawls":
                        this.ProcessRecord_Crawls();
                        break;
                    case "CrossAccountPairs":
                        this.ProcessRecord_CrossAccountPairs();
                        break;
                    case "CurrentIpAddress":
                        this.ProcessRecord_CurrentIpAddress();
                        break;
                    case "CurrentOrg":
                        this.ProcessRecord_CurrentOrg();
                        break;
                    case "CurrentOrgAuthDomainConfig":
                        this.ProcessRecord_CurrentOrgAuthDomainConfig();
                        break;
                    case "CurrentOrgIdentityProviders":
                        this.ProcessRecord_CurrentOrgIdentityProviders();
                        break;
                    case "CustomAnalyzer":
                        this.ProcessRecord_CustomAnalyzer();
                        break;
                    case "DashboardSummary":
                        this.ProcessRecord_DashboardSummary();
                        break;
                    case "DatagovSecDesc":
                        this.ProcessRecord_DatagovSecDesc();
                        break;
                    case "DecryptExportUrl":
                        this.ProcessRecord_DecryptExportUrl();
                        break;
                    case "DeploymentIpAddresses":
                        this.ProcessRecord_DeploymentIpAddresses();
                        break;
                    case "DeploymentVersion":
                        this.ProcessRecord_DeploymentVersion();
                        break;
                    case "DhrcActiveRecommendations":
                        this.ProcessRecord_DhrcActiveRecommendations();
                        break;
                    case "DhrcLatestMetrics":
                        this.ProcessRecord_DhrcLatestMetrics();
                        break;
                    case "DhrcScores":
                        this.ProcessRecord_DhrcScores();
                        break;
                    case "DiffFmd":
                        this.ProcessRecord_DiffFmd();
                        break;
                    case "DiscoverNodes":
                        this.ProcessRecord_DiscoverNodes();
                        break;
                    case "DiscoveryTimeline":
                        this.ProcessRecord_DiscoveryTimeline();
                        break;
                    case "DistributionListDigest":
                        this.ProcessRecord_DistributionListDigest();
                        break;
                    case "DistributionListDigests":
                        this.ProcessRecord_DistributionListDigests();
                        break;
                    case "DummyFieldWithAdminOnlyTag":
                        this.ProcessRecord_DummyFieldWithAdminOnlyTag();
                        break;
                    case "EdgeWindowsToolLink":
                        this.ProcessRecord_EdgeWindowsToolLink();
                        break;
                    case "EffectiveRbacPermissions":
                        this.ProcessRecord_EffectiveRbacPermissions();
                        break;
                    case "EventDigests":
                        this.ProcessRecord_EventDigests();
                        break;
                    case "ExternalDeploymentName":
                        this.ProcessRecord_ExternalDeploymentName();
                        break;
                    case "FailedRestoreItemsInfo":
                        this.ProcessRecord_FailedRestoreItemsInfo();
                        break;
                    case "FederatedLoginStatus":
                        this.ProcessRecord_FederatedLoginStatus();
                        break;
                    case "FileActivities":
                        this.ProcessRecord_FileActivities();
                        break;
                    case "GeoLocationList":
                        this.ProcessRecord_GeoLocationList();
                        break;
                    case "GetAllRolesInOrgList":
                        this.ProcessRecord_GetAllRolesInOrgList();
                        break;
                    case "GetCdmReleaseDetailsForVersionFromSupportPortal":
                        this.ProcessRecord_GetCdmReleaseDetailsForVersionFromSupportPortal();
                        break;
                    case "GetCdmReleaseDetailsFromSupportPortal":
                        this.ProcessRecord_GetCdmReleaseDetailsFromSupportPortal();
                        break;
                    case "GetGroupCountByPrechecksStatus":
                        this.ProcessRecord_GetGroupCountByPrechecksStatus();
                        break;
                    case "GetGroupCountByUpgradeJobStatus":
                        this.ProcessRecord_GetGroupCountByUpgradeJobStatus();
                        break;
                    case "GetGroupCountByVersionStatus":
                        this.ProcessRecord_GetGroupCountByVersionStatus();
                        break;
                    case "GetKorgTaskchainStatus":
                        this.ProcessRecord_GetKorgTaskchainStatus();
                        break;
                    case "GetPermissions":
                        this.ProcessRecord_GetPermissions();
                        break;
                    case "GetRolesByIds":
                        this.ProcessRecord_GetRolesByIds();
                        break;
                    case "GetUserDownloads":
                        this.ProcessRecord_GetUserDownloads();
                        break;
                    case "GlobalFileSearch":
                        this.ProcessRecord_GlobalFileSearch();
                        break;
                    case "GlobalLockoutConfig":
                        this.ProcessRecord_GlobalLockoutConfig();
                        break;
                    case "GlobalMfaSetting":
                        this.ProcessRecord_GlobalMfaSetting();
                        break;
                    case "GlobalSearchResults":
                        this.ProcessRecord_GlobalSearchResults();
                        break;
                    case "GroupsInCurrentAndDescendantOrganization":
                        this.ProcessRecord_GroupsInCurrentAndDescendantOrganization();
                        break;
                    case "GuestCredentials":
                        this.ProcessRecord_GuestCredentials();
                        break;
                    case "GuestCredentialsV2":
                        this.ProcessRecord_GuestCredentialsV2();
                        break;
                    case "HasIdpConfigured":
                        this.ProcessRecord_HasIdpConfigured();
                        break;
                    case "HelpContentSnippets":
                        this.ProcessRecord_HelpContentSnippets();
                        break;
                    case "HierarchyObject":
                        this.ProcessRecord_HierarchyObject();
                        break;
                    case "HierarchyObjects":
                        this.ProcessRecord_HierarchyObjects();
                        break;
                    case "InstalledVersionList":
                        this.ProcessRecord_InstalledVersionList();
                        break;
                    case "InventoryRoot":
                        this.ProcessRecord_InventoryRoot();
                        break;
                    case "InventorySubHierarchyRoot":
                        this.ProcessRecord_InventorySubHierarchyRoot();
                        break;
                    case "InventoryWorkloads":
                        this.ProcessRecord_InventoryWorkloads();
                        break;
                    case "InvestigationCsvDownloadLink":
                        this.ProcessRecord_InvestigationCsvDownloadLink();
                        break;
                    case "IpWhitelist":
                        this.ProcessRecord_IpWhitelist();
                        break;
                    case "IsIpmiEnabled":
                        this.ProcessRecord_IsIpmiEnabled();
                        break;
                    case "IsLoggedIntoRubrikSupportPortal":
                        this.ProcessRecord_IsLoggedIntoRubrikSupportPortal();
                        break;
                    case "IsReplaceNodeTprConfigured":
                        this.ProcessRecord_IsReplaceNodeTprConfigured();
                        break;
                    case "IsSfdcReachable":
                        this.ProcessRecord_IsSfdcReachable();
                        break;
                    case "IsUpgradeAvailable":
                        this.ProcessRecord_IsUpgradeAvailable();
                        break;
                    case "IsUpgradeRecommended":
                        this.ProcessRecord_IsUpgradeRecommended();
                        break;
                    case "IsZrsAvailableForLocation":
                        this.ProcessRecord_IsZrsAvailableForLocation();
                        break;
                    case "Issue":
                        this.ProcessRecord_Issue();
                        break;
                    case "Issues":
                        this.ProcessRecord_Issues();
                        break;
                    case "IssuesJobIds":
                        this.ProcessRecord_IssuesJobIds();
                        break;
                    case "JobInfo":
                        this.ProcessRecord_JobInfo();
                        break;
                    case "KnowledgeBaseArticle":
                        this.ProcessRecord_KnowledgeBaseArticle();
                        break;
                    case "LambdaSettings":
                        this.ProcessRecord_LambdaSettings();
                        break;
                    case "LicensedProducts":
                        this.ProcessRecord_LicensedProducts();
                        break;
                    case "LockoutConfig":
                        this.ProcessRecord_LockoutConfig();
                        break;
                    case "MaxProtectedAppsCount":
                        this.ProcessRecord_MaxProtectedAppsCount();
                        break;
                    case "MfaSetting":
                        this.ProcessRecord_MfaSetting();
                        break;
                    case "MicrosoftSites":
                        this.ProcessRecord_MicrosoftSites();
                        break;
                    case "MinimumCdmVersionForFeatureSet":
                        this.ProcessRecord_MinimumCdmVersionForFeatureSet();
                        break;
                    case "MipLabels":
                        this.ProcessRecord_MipLabels();
                        break;
                    case "NetworkThrottle":
                        this.ProcessRecord_NetworkThrottle();
                        break;
                    case "NfAnomalyResults":
                        this.ProcessRecord_NfAnomalyResults();
                        break;
                    case "NfAnomalyResultsGrouped":
                        this.ProcessRecord_NfAnomalyResultsGrouped();
                        break;
                    case "NodeRemovalCancelPermission":
                        this.ProcessRecord_NodeRemovalCancelPermission();
                        break;
                    case "NodeToReplace":
                        this.ProcessRecord_NodeToReplace();
                        break;
                    case "NodeTunnelStatuses":
                        this.ProcessRecord_NodeTunnelStatuses();
                        break;
                    case "NosqlStorageLocations":
                        this.ProcessRecord_NosqlStorageLocations();
                        break;
                    case "OauthCodesForEdgeReg":
                        this.ProcessRecord_OauthCodesForEdgeReg();
                        break;
                    case "ObjectFiles":
                        this.ProcessRecord_ObjectFiles();
                        break;
                    case "ObjectTypeAccessSummary":
                        this.ProcessRecord_ObjectTypeAccessSummary();
                        break;
                    case "ObjectsAlreadyAssignedToOrgs":
                        this.ProcessRecord_ObjectsAlreadyAssignedToOrgs();
                        break;
                    case "Org":
                        this.ProcessRecord_Org();
                        break;
                    case "Orgs":
                        this.ProcessRecord_Orgs();
                        break;
                    case "OrgsByIds":
                        this.ProcessRecord_OrgsByIds();
                        break;
                    case "OrgsForPrincipal":
                        this.ProcessRecord_OrgsForPrincipal();
                        break;
                    case "PasskeyConfig":
                        this.ProcessRecord_PasskeyConfig();
                        break;
                    case "PasskeyInfo":
                        this.ProcessRecord_PasskeyInfo();
                        break;
                    case "PendingAction":
                        this.ProcessRecord_PendingAction();
                        break;
                    case "PendingActions":
                        this.ProcessRecord_PendingActions();
                        break;
                    case "PhoenixRolloutProgress":
                        this.ProcessRecord_PhoenixRolloutProgress();
                        break;
                    case "PipelineHealthForTimeRange":
                        this.ProcessRecord_PipelineHealthForTimeRange();
                        break;
                    case "PolarisInventorySubHierarchyRoot":
                        this.ProcessRecord_PolarisInventorySubHierarchyRoot();
                        break;
                    case "PolicyDetails":
                        this.ProcessRecord_PolicyDetails();
                        break;
                    case "PolicyObj":
                        this.ProcessRecord_PolicyObj();
                        break;
                    case "PolicyObjs":
                        this.ProcessRecord_PolicyObjs();
                        break;
                    case "PrechecksStatus":
                        this.ProcessRecord_PrechecksStatus();
                        break;
                    case "PrechecksStatusWithNextJobInfo":
                        this.ProcessRecord_PrechecksStatusWithNextJobInfo();
                        break;
                    case "PrivateContainerRegistry":
                        this.ProcessRecord_PrivateContainerRegistry();
                        break;
                    case "ProductDocumentation":
                        this.ProcessRecord_ProductDocumentation();
                        break;
                    case "ProtectedObjectsList":
                        this.ProcessRecord_ProtectedObjectsList();
                        break;
                    case "ProtectedVolumesCount":
                        this.ProcessRecord_ProtectedVolumesCount();
                        break;
                    case "QuarantinedDetailsForWorkload":
                        this.ProcessRecord_QuarantinedDetailsForWorkload();
                        break;
                    case "QueryDatastoreFreespaceThresholds":
                        this.ProcessRecord_QueryDatastoreFreespaceThresholds();
                        break;
                    case "RemovedNodeDetails":
                        this.ProcessRecord_RemovedNodeDetails();
                        break;
                    case "RoleTemplates":
                        this.ProcessRecord_RoleTemplates();
                        break;
                    case "RscPermsToCdmInfo":
                        this.ProcessRecord_RscPermsToCdmInfo();
                        break;
                    case "SearchFileByPrefix":
                        this.ProcessRecord_SearchFileByPrefix();
                        break;
                    case "SnoozedDirectories":
                        this.ProcessRecord_SnoozedDirectories();
                        break;
                    case "SsoGroupAlreadyExists":
                        this.ProcessRecord_SsoGroupAlreadyExists();
                        break;
                    case "SupportBundle":
                        this.ProcessRecord_SupportBundle();
                        break;
                    case "SupportUserAccesses":
                        this.ProcessRecord_SupportUserAccesses();
                        break;
                    case "TableFilters":
                        this.ProcessRecord_TableFilters();
                        break;
                    case "Targets":
                        this.ProcessRecord_Targets();
                        break;
                    case "TaskDetailGroupByList":
                        this.ProcessRecord_TaskDetailGroupByList();
                        break;
                    case "TaskDetailList":
                        this.ProcessRecord_TaskDetailList();
                        break;
                    case "Taskchain":
                        this.ProcessRecord_Taskchain();
                        break;
                    case "TeamChannelNameAvailable":
                        this.ProcessRecord_TeamChannelNameAvailable();
                        break;
                    case "TotpConfigStatus":
                        this.ProcessRecord_TotpConfigStatus();
                        break;
                    case "TprConfiguration":
                        this.ProcessRecord_TprConfiguration();
                        break;
                    case "TprPublicConfiguration":
                        this.ProcessRecord_TprPublicConfiguration();
                        break;
                    case "TprRequestDetail":
                        this.ProcessRecord_TprRequestDetail();
                        break;
                    case "TprRequestSummaries":
                        this.ProcessRecord_TprRequestSummaries();
                        break;
                    case "TprRoleEligibility":
                        this.ProcessRecord_TprRoleEligibility();
                        break;
                    case "TprRulesMap":
                        this.ProcessRecord_TprRulesMap();
                        break;
                    case "TprStatusForNodeRemoval":
                        this.ProcessRecord_TprStatusForNodeRemoval();
                        break;
                    case "TunnelStatus":
                        this.ProcessRecord_TunnelStatus();
                        break;
                    case "UniqueVcdCount":
                        this.ProcessRecord_UniqueVcdCount();
                        break;
                    case "UnmanagedObjects":
                        this.ProcessRecord_UnmanagedObjects();
                        break;
                    case "UnmanagedObjectsSupportedTypes":
                        this.ProcessRecord_UnmanagedObjectsSupportedTypes();
                        break;
                    case "UpgradeStatus":
                        this.ProcessRecord_UpgradeStatus();
                        break;
                    case "UserActivities":
                        this.ProcessRecord_UserActivities();
                        break;
                    case "UserAlreadyExists":
                        this.ProcessRecord_UserAlreadyExists();
                        break;
                    case "UserAnalyzerAccess":
                        this.ProcessRecord_UserAnalyzerAccess();
                        break;
                    case "UserAuditList":
                        this.ProcessRecord_UserAuditList();
                        break;
                    case "UserDetail":
                        this.ProcessRecord_UserDetail();
                        break;
                    case "UserFile":
                        this.ProcessRecord_UserFile();
                        break;
                    case "UserFiles":
                        this.ProcessRecord_UserFiles();
                        break;
                    case "UserGroups":
                        this.ProcessRecord_UserGroups();
                        break;
                    case "UserNotifications":
                        this.ProcessRecord_UserNotifications();
                        break;
                    case "UserSessionManagementConfig":
                        this.ProcessRecord_UserSessionManagementConfig();
                        break;
                    case "UserSettings":
                        this.ProcessRecord_UserSettings();
                        break;
                    case "UsersInCurrentAndDescendantOrganization":
                        this.ProcessRecord_UsersInCurrentAndDescendantOrganization();
                        break;
                    case "UsersOnAccountList":
                        this.ProcessRecord_UsersOnAccountList();
                        break;
                    case "ValidateOrgName":
                        this.ProcessRecord_ValidateOrgName();
                        break;
                    case "VcdVappVms":
                        this.ProcessRecord_VcdVappVms();
                        break;
                    case "VerifyTotp":
                        this.ProcessRecord_VerifyTotp();
                        break;
                    case "VirtualMachineFiles":
                        this.ProcessRecord_VirtualMachineFiles();
                        break;
                    case "VmRecoveryJobsInfo":
                        this.ProcessRecord_VmRecoveryJobsInfo();
                        break;
                    case "VolumeGroupMounts":
                        this.ProcessRecord_VolumeGroupMounts();
                        break;
                    case "WorkloadAlertSetting":
                        this.ProcessRecord_WorkloadAlertSetting();
                        break;
                    case "WorkloadAnomalies":
                        this.ProcessRecord_WorkloadAnomalies();
                        break;
                    case "WorkloadForeverId":
                        this.ProcessRecord_WorkloadForeverId();
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
        // activeCustomAnalyzers.
        internal void ProcessRecord_ActiveCustomAnalyzers()
        {
            this._logger.name += " -ActiveCustomAnalyzers";
            // Create new graphql operation activeCustomAnalyzers
            InitQueryActiveCustomAnalyzers();
        }

        // This parameter set invokes a single graphql operation:
        // adGroupMembers.
        internal void ProcessRecord_AdGroupMembers()
        {
            this._logger.name += " -AdGroupMembers";
            // Create new graphql operation adGroupMembers
            InitQueryAdGroupMembers();
        }

        // This parameter set invokes a single graphql operation:
        // adVolumeExports.
        internal void ProcessRecord_AdVolumeExports()
        {
            this._logger.name += " -AdVolumeExports";
            // Create new graphql operation adVolumeExports
            InitQueryAdVolumeExports();
        }

        // This parameter set invokes a single graphql operation:
        // agentDeploymentSetting.
        internal void ProcessRecord_AgentDeploymentSetting()
        {
            this._logger.name += " -AgentDeploymentSetting";
            // Create new graphql operation agentDeploymentSetting
            InitQueryAgentDeploymentSetting();
        }

        // This parameter set invokes a single graphql operation:
        // allAgentDeploymentSettings.
        internal void ProcessRecord_AgentDeploymentSettings()
        {
            this._logger.name += " -AgentDeploymentSettings";
            // Create new graphql operation allAgentDeploymentSettings
            InitQueryAllAgentDeploymentSettings();
        }

        // This parameter set invokes a single graphql operation:
        // allAllowedOrgAdminOperations.
        internal void ProcessRecord_AllowedOrgAdminOperations()
        {
            this._logger.name += " -AllowedOrgAdminOperations";
            // Create new graphql operation allAllowedOrgAdminOperations
            InitQueryAllAllowedOrgAdminOperations();
        }

        // This parameter set invokes a single graphql operation:
        // analyzerGroups.
        internal void ProcessRecord_AnalyzerGroups()
        {
            this._logger.name += " -AnalyzerGroups";
            // Create new graphql operation analyzerGroups
            InitQueryAnalyzerGroups();
        }

        // This parameter set invokes a single graphql operation:
        // analyzerUsages.
        internal void ProcessRecord_AnalyzerUsages()
        {
            this._logger.name += " -AnalyzerUsages";
            // Create new graphql operation analyzerUsages
            InitQueryAnalyzerUsages();
        }

        // This parameter set invokes a single graphql operation:
        // anomalyResultOpt.
        internal void ProcessRecord_AnomalyResultOpt()
        {
            this._logger.name += " -AnomalyResultOpt";
            // Create new graphql operation anomalyResultOpt
            InitQueryAnomalyResultOpt();
        }

        // This parameter set invokes a single graphql operation:
        // anomalyResults.
        internal void ProcessRecord_AnomalyResults()
        {
            this._logger.name += " -AnomalyResults";
            // Create new graphql operation anomalyResults
            InitQueryAnomalyResults();
        }

        // This parameter set invokes a single graphql operation:
        // anomalyResultsGrouped.
        internal void ProcessRecord_AnomalyResultsGrouped()
        {
            this._logger.name += " -AnomalyResultsGrouped";
            // Create new graphql operation anomalyResultsGrouped
            InitQueryAnomalyResultsGrouped();
        }

        // This parameter set invokes a single graphql operation:
        // areMultiGeoBackupsEnabled.
        internal void ProcessRecord_AreMultiGeoBackupsEnabled()
        {
            this._logger.name += " -AreMultiGeoBackupsEnabled";
            // Create new graphql operation areMultiGeoBackupsEnabled
            InitQueryAreMultiGeoBackupsEnabled();
        }

        // This parameter set invokes a single graphql operation:
        // allAuthorizationsForGlobalResource.
        internal void ProcessRecord_AuthorizationsForGlobalResource()
        {
            this._logger.name += " -AuthorizationsForGlobalResource";
            // Create new graphql operation allAuthorizationsForGlobalResource
            InitQueryAllAuthorizationsForGlobalResource();
        }

        // This parameter set invokes a single graphql operation:
        // allAuthorizationsForObject.
        internal void ProcessRecord_AuthorizationsForObject()
        {
            this._logger.name += " -AuthorizationsForObject";
            // Create new graphql operation allAuthorizationsForObject
            InitQueryAllAuthorizationsForObject();
        }

        // This parameter set invokes a single graphql operation:
        // allAuthorizationsForObjects.
        internal void ProcessRecord_AuthorizationsForObjects()
        {
            this._logger.name += " -AuthorizationsForObjects";
            // Create new graphql operation allAuthorizationsForObjects
            InitQueryAllAuthorizationsForObjects();
        }

        // This parameter set invokes a single graphql operation:
        // allAwsComputeSettings.
        internal void ProcessRecord_AwsComputeSettings()
        {
            this._logger.name += " -AwsComputeSettings";
            // Create new graphql operation allAwsComputeSettings
            InitQueryAllAwsComputeSettings();
        }

        // This parameter set invokes a single graphql operation:
        // allAzureResourceGroups.
        internal void ProcessRecord_AzureResourceGroups()
        {
            this._logger.name += " -AzureResourceGroups";
            // Create new graphql operation allAzureResourceGroups
            InitQueryAllAzureResourceGroups();
        }

        // This parameter set invokes a single graphql operation:
        // allAzureSubnets.
        internal void ProcessRecord_AzureSubnets()
        {
            this._logger.name += " -AzureSubnets";
            // Create new graphql operation allAzureSubnets
            InitQueryAllAzureSubnets();
        }

        // This parameter set invokes a single graphql operation:
        // allBackupThrottleSettings.
        internal void ProcessRecord_BackupThrottleSettings()
        {
            this._logger.name += " -BackupThrottleSettings";
            // Create new graphql operation allBackupThrottleSettings
            InitQueryAllBackupThrottleSettings();
        }

        // This parameter set invokes a single graphql operation:
        // browseCalendar.
        internal void ProcessRecord_BrowseCalendar()
        {
            this._logger.name += " -BrowseCalendar";
            // Create new graphql operation browseCalendar
            InitQueryBrowseCalendar();
        }

        // This parameter set invokes a single graphql operation:
        // browseContacts.
        internal void ProcessRecord_BrowseContacts()
        {
            this._logger.name += " -BrowseContacts";
            // Create new graphql operation browseContacts
            InitQueryBrowseContacts();
        }

        // This parameter set invokes a single graphql operation:
        // browseFolder.
        internal void ProcessRecord_BrowseFolder()
        {
            this._logger.name += " -BrowseFolder";
            // Create new graphql operation browseFolder
            InitQueryBrowseFolder();
        }

        // This parameter set invokes a single graphql operation:
        // browseOnedrive.
        internal void ProcessRecord_BrowseOnedrive()
        {
            this._logger.name += " -BrowseOnedrive";
            // Create new graphql operation browseOnedrive
            InitQueryBrowseOnedrive();
        }

        // This parameter set invokes a single graphql operation:
        // browseTeamsChannels.
        internal void ProcessRecord_BrowseTeamsChannels()
        {
            this._logger.name += " -BrowseTeamsChannels";
            // Create new graphql operation browseTeamsChannels
            InitQueryBrowseTeamsChannels();
        }

        // This parameter set invokes a single graphql operation:
        // browseTeamsDrive.
        internal void ProcessRecord_BrowseTeamsDrive()
        {
            this._logger.name += " -BrowseTeamsDrive";
            // Create new graphql operation browseTeamsDrive
            InitQueryBrowseTeamsDrive();
        }

        // This parameter set invokes a single graphql operation:
        // allCdmGuestCredentials.
        internal void ProcessRecord_CdmGuestCredentials()
        {
            this._logger.name += " -CdmGuestCredentials";
            // Create new graphql operation allCdmGuestCredentials
            InitQueryAllCdmGuestCredentials();
        }

        // This parameter set invokes a single graphql operation:
        // cdmInventorySubHierarchyRoot.
        internal void ProcessRecord_CdmInventorySubHierarchyRoot()
        {
            this._logger.name += " -CdmInventorySubHierarchyRoot";
            // Create new graphql operation cdmInventorySubHierarchyRoot
            InitQueryCdmInventorySubHierarchyRoot();
        }

        // This parameter set invokes a single graphql operation:
        // allCdmOvaDetails.
        internal void ProcessRecord_CdmOvaDetails()
        {
            this._logger.name += " -CdmOvaDetails";
            // Create new graphql operation allCdmOvaDetails
            InitQueryAllCdmOvaDetails();
        }

        // This parameter set invokes a single graphql operation:
        // cdmVersionCheck.
        internal void ProcessRecord_CdmVersionCheck()
        {
            this._logger.name += " -CdmVersionCheck";
            // Create new graphql operation cdmVersionCheck
            InitQueryCdmVersionCheck();
        }

        // This parameter set invokes a single graphql operation:
        // allCdpVmsInfos.
        internal void ProcessRecord_CdpVmsInfos()
        {
            this._logger.name += " -CdpVmsInfos";
            // Create new graphql operation allCdpVmsInfos
            InitQueryAllCdpVmsInfos();
        }

        // This parameter set invokes a single graphql operation:
        // checkCloudComputeConnectivityJobProgress.
        internal void ProcessRecord_CheckCloudComputeConnectivityJobProgress()
        {
            this._logger.name += " -CheckCloudComputeConnectivityJobProgress";
            // Create new graphql operation checkCloudComputeConnectivityJobProgress
            InitQueryCheckCloudComputeConnectivityJobProgress();
        }

        // This parameter set invokes a single graphql operation:
        // checkLatestVersionMgmtAppExists.
        internal void ProcessRecord_CheckLatestVersionMgmtAppExists()
        {
            this._logger.name += " -CheckLatestVersionMgmtAppExists";
            // Create new graphql operation checkLatestVersionMgmtAppExists
            InitQueryCheckLatestVersionMgmtAppExists();
        }

        // This parameter set invokes a single graphql operation:
        // cloudDirectNasExport.
        internal void ProcessRecord_CloudDirectNasExport()
        {
            this._logger.name += " -CloudDirectNasExport";
            // Create new graphql operation cloudDirectNasExport
            InitQueryCloudDirectNasExport();
        }

        // This parameter set invokes a single graphql operation:
        // cloudDirectNasNamespace.
        internal void ProcessRecord_CloudDirectNasNamespace()
        {
            this._logger.name += " -CloudDirectNasNamespace";
            // Create new graphql operation cloudDirectNasNamespace
            InitQueryCloudDirectNasNamespace();
        }

        // This parameter set invokes a single graphql operation:
        // cloudDirectNasNamespaces.
        internal void ProcessRecord_CloudDirectNasNamespaces()
        {
            this._logger.name += " -CloudDirectNasNamespaces";
            // Create new graphql operation cloudDirectNasNamespaces
            InitQueryCloudDirectNasNamespaces();
        }

        // This parameter set invokes a single graphql operation:
        // cloudDirectNasShare.
        internal void ProcessRecord_CloudDirectNasShare()
        {
            this._logger.name += " -CloudDirectNasShare";
            // Create new graphql operation cloudDirectNasShare
            InitQueryCloudDirectNasShare();
        }

        // This parameter set invokes a single graphql operation:
        // allCloudDirectShares.
        internal void ProcessRecord_CloudDirectShares()
        {
            this._logger.name += " -CloudDirectShares";
            // Create new graphql operation allCloudDirectShares
            InitQueryAllCloudDirectShares();
        }

        // This parameter set invokes a single graphql operation:
        // allCloudDirectSites.
        internal void ProcessRecord_CloudDirectSites()
        {
            this._logger.name += " -CloudDirectSites";
            // Create new graphql operation allCloudDirectSites
            InitQueryAllCloudDirectSites();
        }

        // This parameter set invokes a single graphql operation:
        // cloudDirectSystems.
        internal void ProcessRecord_CloudDirectSystems()
        {
            this._logger.name += " -CloudDirectSystems";
            // Create new graphql operation cloudDirectSystems
            InitQueryCloudDirectSystems();
        }

        // This parameter set invokes a single graphql operation:
        // configuredGroupMembers.
        internal void ProcessRecord_ConfiguredGroupMembers()
        {
            this._logger.name += " -ConfiguredGroupMembers";
            // Create new graphql operation configuredGroupMembers
            InitQueryConfiguredGroupMembers();
        }

        // This parameter set invokes a single graphql operation:
        // crawl.
        internal void ProcessRecord_Crawl()
        {
            this._logger.name += " -Crawl";
            // Create new graphql operation crawl
            InitQueryCrawl();
        }

        // This parameter set invokes a single graphql operation:
        // crawls.
        internal void ProcessRecord_Crawls()
        {
            this._logger.name += " -Crawls";
            // Create new graphql operation crawls
            InitQueryCrawls();
        }

        // This parameter set invokes a single graphql operation:
        // crossAccountPairs.
        internal void ProcessRecord_CrossAccountPairs()
        {
            this._logger.name += " -CrossAccountPairs";
            // Create new graphql operation crossAccountPairs
            InitQueryCrossAccountPairs();
        }

        // This parameter set invokes a single graphql operation:
        // currentIpAddress.
        internal void ProcessRecord_CurrentIpAddress()
        {
            this._logger.name += " -CurrentIpAddress";
            // Create new graphql operation currentIpAddress
            InitQueryCurrentIpAddress();
        }

        // This parameter set invokes a single graphql operation:
        // currentOrg.
        internal void ProcessRecord_CurrentOrg()
        {
            this._logger.name += " -CurrentOrg";
            // Create new graphql operation currentOrg
            InitQueryCurrentOrg();
        }

        // This parameter set invokes a single graphql operation:
        // currentOrgAuthDomainConfig.
        internal void ProcessRecord_CurrentOrgAuthDomainConfig()
        {
            this._logger.name += " -CurrentOrgAuthDomainConfig";
            // Create new graphql operation currentOrgAuthDomainConfig
            InitQueryCurrentOrgAuthDomainConfig();
        }

        // This parameter set invokes a single graphql operation:
        // allCurrentOrgIdentityProviders.
        internal void ProcessRecord_CurrentOrgIdentityProviders()
        {
            this._logger.name += " -CurrentOrgIdentityProviders";
            // Create new graphql operation allCurrentOrgIdentityProviders
            InitQueryAllCurrentOrgIdentityProviders();
        }

        // This parameter set invokes a single graphql operation:
        // customAnalyzer.
        internal void ProcessRecord_CustomAnalyzer()
        {
            this._logger.name += " -CustomAnalyzer";
            // Create new graphql operation customAnalyzer
            InitQueryCustomAnalyzer();
        }

        // This parameter set invokes a single graphql operation:
        // dashboardSummary.
        internal void ProcessRecord_DashboardSummary()
        {
            this._logger.name += " -DashboardSummary";
            // Create new graphql operation dashboardSummary
            InitQueryDashboardSummary();
        }

        // This parameter set invokes a single graphql operation:
        // datagovSecDesc.
        internal void ProcessRecord_DatagovSecDesc()
        {
            this._logger.name += " -DatagovSecDesc";
            // Create new graphql operation datagovSecDesc
            InitQueryDatagovSecDesc();
        }

        // This parameter set invokes a single graphql operation:
        // decryptExportUrl.
        internal void ProcessRecord_DecryptExportUrl()
        {
            this._logger.name += " -DecryptExportUrl";
            // Create new graphql operation decryptExportUrl
            InitQueryDecryptExportUrl();
        }

        // This parameter set invokes a single graphql operation:
        // allDeploymentIpAddresses.
        internal void ProcessRecord_DeploymentIpAddresses()
        {
            this._logger.name += " -DeploymentIpAddresses";
            // Create new graphql operation allDeploymentIpAddresses
            InitQueryAllDeploymentIpAddresses();
        }

        // This parameter set invokes a single graphql operation:
        // deploymentVersion.
        internal void ProcessRecord_DeploymentVersion()
        {
            this._logger.name += " -DeploymentVersion";
            // Create new graphql operation deploymentVersion
            InitQueryDeploymentVersion();
        }

        // This parameter set invokes a single graphql operation:
        // allDhrcActiveRecommendations.
        internal void ProcessRecord_DhrcActiveRecommendations()
        {
            this._logger.name += " -DhrcActiveRecommendations";
            // Create new graphql operation allDhrcActiveRecommendations
            InitQueryAllDhrcActiveRecommendations();
        }

        // This parameter set invokes a single graphql operation:
        // allDhrcLatestMetrics.
        internal void ProcessRecord_DhrcLatestMetrics()
        {
            this._logger.name += " -DhrcLatestMetrics";
            // Create new graphql operation allDhrcLatestMetrics
            InitQueryAllDhrcLatestMetrics();
        }

        // This parameter set invokes a single graphql operation:
        // allDhrcScores.
        internal void ProcessRecord_DhrcScores()
        {
            this._logger.name += " -DhrcScores";
            // Create new graphql operation allDhrcScores
            InitQueryAllDhrcScores();
        }

        // This parameter set invokes a single graphql operation:
        // diffFmd.
        internal void ProcessRecord_DiffFmd()
        {
            this._logger.name += " -DiffFmd";
            // Create new graphql operation diffFmd
            InitQueryDiffFmd();
        }

        // This parameter set invokes a single graphql operation:
        // discoverNodes.
        internal void ProcessRecord_DiscoverNodes()
        {
            this._logger.name += " -DiscoverNodes";
            // Create new graphql operation discoverNodes
            InitQueryDiscoverNodes();
        }

        // This parameter set invokes a single graphql operation:
        // discoveryTimeline.
        internal void ProcessRecord_DiscoveryTimeline()
        {
            this._logger.name += " -DiscoveryTimeline";
            // Create new graphql operation discoveryTimeline
            InitQueryDiscoveryTimeline();
        }

        // This parameter set invokes a single graphql operation:
        // distributionListDigest.
        internal void ProcessRecord_DistributionListDigest()
        {
            this._logger.name += " -DistributionListDigest";
            // Create new graphql operation distributionListDigest
            InitQueryDistributionListDigest();
        }

        // This parameter set invokes a single graphql operation:
        // allDistributionListDigests.
        internal void ProcessRecord_DistributionListDigests()
        {
            this._logger.name += " -DistributionListDigests";
            // Create new graphql operation allDistributionListDigests
            InitQueryAllDistributionListDigests();
        }

        // This parameter set invokes a single graphql operation:
        // dummyFieldWithAdminOnlyTag.
        internal void ProcessRecord_DummyFieldWithAdminOnlyTag()
        {
            this._logger.name += " -DummyFieldWithAdminOnlyTag";
            // Create new graphql operation dummyFieldWithAdminOnlyTag
            InitQueryDummyFieldWithAdminOnlyTag();
        }

        // This parameter set invokes a single graphql operation:
        // edgeWindowsToolLink.
        internal void ProcessRecord_EdgeWindowsToolLink()
        {
            this._logger.name += " -EdgeWindowsToolLink";
            // Create new graphql operation edgeWindowsToolLink
            InitQueryEdgeWindowsToolLink();
        }

        // This parameter set invokes a single graphql operation:
        // allEffectiveRbacPermissions.
        internal void ProcessRecord_EffectiveRbacPermissions()
        {
            this._logger.name += " -EffectiveRbacPermissions";
            // Create new graphql operation allEffectiveRbacPermissions
            InitQueryAllEffectiveRbacPermissions();
        }

        // This parameter set invokes a single graphql operation:
        // allEventDigests.
        internal void ProcessRecord_EventDigests()
        {
            this._logger.name += " -EventDigests";
            // Create new graphql operation allEventDigests
            InitQueryAllEventDigests();
        }

        // This parameter set invokes a single graphql operation:
        // externalDeploymentName.
        internal void ProcessRecord_ExternalDeploymentName()
        {
            this._logger.name += " -ExternalDeploymentName";
            // Create new graphql operation externalDeploymentName
            InitQueryExternalDeploymentName();
        }

        // This parameter set invokes a single graphql operation:
        // failedRestoreItemsInfo.
        internal void ProcessRecord_FailedRestoreItemsInfo()
        {
            this._logger.name += " -FailedRestoreItemsInfo";
            // Create new graphql operation failedRestoreItemsInfo
            InitQueryFailedRestoreItemsInfo();
        }

        // This parameter set invokes a single graphql operation:
        // federatedLoginStatus.
        internal void ProcessRecord_FederatedLoginStatus()
        {
            this._logger.name += " -FederatedLoginStatus";
            // Create new graphql operation federatedLoginStatus
            InitQueryFederatedLoginStatus();
        }

        // This parameter set invokes a single graphql operation:
        // allFileActivities.
        internal void ProcessRecord_FileActivities()
        {
            this._logger.name += " -FileActivities";
            // Create new graphql operation allFileActivities
            InitQueryAllFileActivities();
        }

        // This parameter set invokes a single graphql operation:
        // geoLocationList.
        internal void ProcessRecord_GeoLocationList()
        {
            this._logger.name += " -GeoLocationList";
            // Create new graphql operation geoLocationList
            InitQueryGeoLocationList();
        }

        // This parameter set invokes a single graphql operation:
        // getAllRolesInOrgConnection.
        internal void ProcessRecord_GetAllRolesInOrgList()
        {
            this._logger.name += " -GetAllRolesInOrgList";
            // Create new graphql operation getAllRolesInOrgConnection
            InitQueryGetAllRolesInOrgConnection();
        }

        // This parameter set invokes a single graphql operation:
        // getCdmReleaseDetailsForVersionFromSupportPortal.
        internal void ProcessRecord_GetCdmReleaseDetailsForVersionFromSupportPortal()
        {
            this._logger.name += " -GetCdmReleaseDetailsForVersionFromSupportPortal";
            // Create new graphql operation getCdmReleaseDetailsForVersionFromSupportPortal
            InitQueryGetCdmReleaseDetailsForVersionFromSupportPortal();
        }

        // This parameter set invokes a single graphql operation:
        // getCdmReleaseDetailsFromSupportPortal.
        internal void ProcessRecord_GetCdmReleaseDetailsFromSupportPortal()
        {
            this._logger.name += " -GetCdmReleaseDetailsFromSupportPortal";
            // Create new graphql operation getCdmReleaseDetailsFromSupportPortal
            InitQueryGetCdmReleaseDetailsFromSupportPortal();
        }

        // This parameter set invokes a single graphql operation:
        // getGroupCountByPrechecksStatus.
        internal void ProcessRecord_GetGroupCountByPrechecksStatus()
        {
            this._logger.name += " -GetGroupCountByPrechecksStatus";
            // Create new graphql operation getGroupCountByPrechecksStatus
            InitQueryGetGroupCountByPrechecksStatus();
        }

        // This parameter set invokes a single graphql operation:
        // getGroupCountByUpgradeJobStatus.
        internal void ProcessRecord_GetGroupCountByUpgradeJobStatus()
        {
            this._logger.name += " -GetGroupCountByUpgradeJobStatus";
            // Create new graphql operation getGroupCountByUpgradeJobStatus
            InitQueryGetGroupCountByUpgradeJobStatus();
        }

        // This parameter set invokes a single graphql operation:
        // getGroupCountByVersionStatus.
        internal void ProcessRecord_GetGroupCountByVersionStatus()
        {
            this._logger.name += " -GetGroupCountByVersionStatus";
            // Create new graphql operation getGroupCountByVersionStatus
            InitQueryGetGroupCountByVersionStatus();
        }

        // This parameter set invokes a single graphql operation:
        // getKorgTaskchainStatus.
        internal void ProcessRecord_GetKorgTaskchainStatus()
        {
            this._logger.name += " -GetKorgTaskchainStatus";
            // Create new graphql operation getKorgTaskchainStatus
            InitQueryGetKorgTaskchainStatus();
        }

        // This parameter set invokes a single graphql operation:
        // getPermissions.
        internal void ProcessRecord_GetPermissions()
        {
            this._logger.name += " -GetPermissions";
            // Create new graphql operation getPermissions
            InitQueryGetPermissions();
        }

        // This parameter set invokes a single graphql operation:
        // getRolesByIds.
        internal void ProcessRecord_GetRolesByIds()
        {
            this._logger.name += " -GetRolesByIds";
            // Create new graphql operation getRolesByIds
            InitQueryGetRolesByIds();
        }

        // This parameter set invokes a single graphql operation:
        // getUserDownloads.
        internal void ProcessRecord_GetUserDownloads()
        {
            this._logger.name += " -GetUserDownloads";
            // Create new graphql operation getUserDownloads
            InitQueryGetUserDownloads();
        }

        // This parameter set invokes a single graphql operation:
        // globalFileSearch.
        internal void ProcessRecord_GlobalFileSearch()
        {
            this._logger.name += " -GlobalFileSearch";
            // Create new graphql operation globalFileSearch
            InitQueryGlobalFileSearch();
        }

        // This parameter set invokes a single graphql operation:
        // globalLockoutConfig.
        internal void ProcessRecord_GlobalLockoutConfig()
        {
            this._logger.name += " -GlobalLockoutConfig";
            // Create new graphql operation globalLockoutConfig
            InitQueryGlobalLockoutConfig();
        }

        // This parameter set invokes a single graphql operation:
        // globalMfaSetting.
        internal void ProcessRecord_GlobalMfaSetting()
        {
            this._logger.name += " -GlobalMfaSetting";
            // Create new graphql operation globalMfaSetting
            InitQueryGlobalMfaSetting();
        }

        // This parameter set invokes a single graphql operation:
        // globalSearchResults.
        internal void ProcessRecord_GlobalSearchResults()
        {
            this._logger.name += " -GlobalSearchResults";
            // Create new graphql operation globalSearchResults
            InitQueryGlobalSearchResults();
        }

        // This parameter set invokes a single graphql operation:
        // groupsInCurrentAndDescendantOrganization.
        internal void ProcessRecord_GroupsInCurrentAndDescendantOrganization()
        {
            this._logger.name += " -GroupsInCurrentAndDescendantOrganization";
            // Create new graphql operation groupsInCurrentAndDescendantOrganization
            InitQueryGroupsInCurrentAndDescendantOrganization();
        }

        // This parameter set invokes a single graphql operation:
        // guestCredentials.
        internal void ProcessRecord_GuestCredentials()
        {
            this._logger.name += " -GuestCredentials";
            // Create new graphql operation guestCredentials
            InitQueryGuestCredentials();
        }

        // This parameter set invokes a single graphql operation:
        // guestCredentialsV2.
        internal void ProcessRecord_GuestCredentialsV2()
        {
            this._logger.name += " -GuestCredentialsV2";
            // Create new graphql operation guestCredentialsV2
            InitQueryGuestCredentialsV2();
        }

        // This parameter set invokes a single graphql operation:
        // hasIdpConfigured.
        internal void ProcessRecord_HasIdpConfigured()
        {
            this._logger.name += " -HasIdpConfigured";
            // Create new graphql operation hasIdpConfigured
            InitQueryHasIdpConfigured();
        }

        // This parameter set invokes a single graphql operation:
        // helpContentSnippets.
        internal void ProcessRecord_HelpContentSnippets()
        {
            this._logger.name += " -HelpContentSnippets";
            // Create new graphql operation helpContentSnippets
            InitQueryHelpContentSnippets();
        }

        // This parameter set invokes a single graphql operation:
        // hierarchyObject.
        internal void ProcessRecord_HierarchyObject()
        {
            this._logger.name += " -HierarchyObject";
            // Create new graphql operation hierarchyObject
            InitQueryHierarchyObject();
        }

        // This parameter set invokes a single graphql operation:
        // hierarchyObjects.
        internal void ProcessRecord_HierarchyObjects()
        {
            this._logger.name += " -HierarchyObjects";
            // Create new graphql operation hierarchyObjects
            InitQueryHierarchyObjects();
        }

        // This parameter set invokes a single graphql operation:
        // installedVersionList.
        internal void ProcessRecord_InstalledVersionList()
        {
            this._logger.name += " -InstalledVersionList";
            // Create new graphql operation installedVersionList
            InitQueryInstalledVersionList();
        }

        // This parameter set invokes a single graphql operation:
        // inventoryRoot.
        internal void ProcessRecord_InventoryRoot()
        {
            this._logger.name += " -InventoryRoot";
            // Create new graphql operation inventoryRoot
            InitQueryInventoryRoot();
        }

        // This parameter set invokes a single graphql operation:
        // inventorySubHierarchyRoot.
        internal void ProcessRecord_InventorySubHierarchyRoot()
        {
            this._logger.name += " -InventorySubHierarchyRoot";
            // Create new graphql operation inventorySubHierarchyRoot
            InitQueryInventorySubHierarchyRoot();
        }

        // This parameter set invokes a single graphql operation:
        // allInventoryWorkloads.
        internal void ProcessRecord_InventoryWorkloads()
        {
            this._logger.name += " -InventoryWorkloads";
            // Create new graphql operation allInventoryWorkloads
            InitQueryAllInventoryWorkloads();
        }

        // This parameter set invokes a single graphql operation:
        // investigationCsvDownloadLink.
        internal void ProcessRecord_InvestigationCsvDownloadLink()
        {
            this._logger.name += " -InvestigationCsvDownloadLink";
            // Create new graphql operation investigationCsvDownloadLink
            InitQueryInvestigationCsvDownloadLink();
        }

        // This parameter set invokes a single graphql operation:
        // ipWhitelist.
        internal void ProcessRecord_IpWhitelist()
        {
            this._logger.name += " -IpWhitelist";
            // Create new graphql operation ipWhitelist
            InitQueryIpWhitelist();
        }

        // This parameter set invokes a single graphql operation:
        // isIpmiEnabled.
        internal void ProcessRecord_IsIpmiEnabled()
        {
            this._logger.name += " -IsIpmiEnabled";
            // Create new graphql operation isIpmiEnabled
            InitQueryIsIpmiEnabled();
        }

        // This parameter set invokes a single graphql operation:
        // isLoggedIntoRubrikSupportPortal.
        internal void ProcessRecord_IsLoggedIntoRubrikSupportPortal()
        {
            this._logger.name += " -IsLoggedIntoRubrikSupportPortal";
            // Create new graphql operation isLoggedIntoRubrikSupportPortal
            InitQueryIsLoggedIntoRubrikSupportPortal();
        }

        // This parameter set invokes a single graphql operation:
        // isReplaceNodeTprConfigured.
        internal void ProcessRecord_IsReplaceNodeTprConfigured()
        {
            this._logger.name += " -IsReplaceNodeTprConfigured";
            // Create new graphql operation isReplaceNodeTprConfigured
            InitQueryIsReplaceNodeTprConfigured();
        }

        // This parameter set invokes a single graphql operation:
        // isSfdcReachable.
        internal void ProcessRecord_IsSfdcReachable()
        {
            this._logger.name += " -IsSfdcReachable";
            // Create new graphql operation isSfdcReachable
            InitQueryIsSfdcReachable();
        }

        // This parameter set invokes a single graphql operation:
        // isUpgradeAvailable.
        internal void ProcessRecord_IsUpgradeAvailable()
        {
            this._logger.name += " -IsUpgradeAvailable";
            // Create new graphql operation isUpgradeAvailable
            InitQueryIsUpgradeAvailable();
        }

        // This parameter set invokes a single graphql operation:
        // isUpgradeRecommended.
        internal void ProcessRecord_IsUpgradeRecommended()
        {
            this._logger.name += " -IsUpgradeRecommended";
            // Create new graphql operation isUpgradeRecommended
            InitQueryIsUpgradeRecommended();
        }

        // This parameter set invokes a single graphql operation:
        // isZrsAvailableForLocation.
        internal void ProcessRecord_IsZrsAvailableForLocation()
        {
            this._logger.name += " -IsZrsAvailableForLocation";
            // Create new graphql operation isZrsAvailableForLocation
            InitQueryIsZrsAvailableForLocation();
        }

        // This parameter set invokes a single graphql operation:
        // issue.
        internal void ProcessRecord_Issue()
        {
            this._logger.name += " -Issue";
            // Create new graphql operation issue
            InitQueryIssue();
        }

        // This parameter set invokes a single graphql operation:
        // issues.
        internal void ProcessRecord_Issues()
        {
            this._logger.name += " -Issues";
            // Create new graphql operation issues
            InitQueryIssues();
        }

        // This parameter set invokes a single graphql operation:
        // allIssuesJobIds.
        internal void ProcessRecord_IssuesJobIds()
        {
            this._logger.name += " -IssuesJobIds";
            // Create new graphql operation allIssuesJobIds
            InitQueryAllIssuesJobIds();
        }

        // This parameter set invokes a single graphql operation:
        // jobInfo.
        internal void ProcessRecord_JobInfo()
        {
            this._logger.name += " -JobInfo";
            // Create new graphql operation jobInfo
            InitQueryJobInfo();
        }

        // This parameter set invokes a single graphql operation:
        // knowledgeBaseArticle.
        internal void ProcessRecord_KnowledgeBaseArticle()
        {
            this._logger.name += " -KnowledgeBaseArticle";
            // Create new graphql operation knowledgeBaseArticle
            InitQueryKnowledgeBaseArticle();
        }

        // This parameter set invokes a single graphql operation:
        // lambdaSettings.
        internal void ProcessRecord_LambdaSettings()
        {
            this._logger.name += " -LambdaSettings";
            // Create new graphql operation lambdaSettings
            InitQueryLambdaSettings();
        }

        // This parameter set invokes a single graphql operation:
        // allLicensedProducts.
        internal void ProcessRecord_LicensedProducts()
        {
            this._logger.name += " -LicensedProducts";
            // Create new graphql operation allLicensedProducts
            InitQueryAllLicensedProducts();
        }

        // This parameter set invokes a single graphql operation:
        // lockoutConfig.
        internal void ProcessRecord_LockoutConfig()
        {
            this._logger.name += " -LockoutConfig";
            // Create new graphql operation lockoutConfig
            InitQueryLockoutConfig();
        }

        // This parameter set invokes a single graphql operation:
        // maxProtectedAppsCount.
        internal void ProcessRecord_MaxProtectedAppsCount()
        {
            this._logger.name += " -MaxProtectedAppsCount";
            // Create new graphql operation maxProtectedAppsCount
            InitQueryMaxProtectedAppsCount();
        }

        // This parameter set invokes a single graphql operation:
        // mfaSetting.
        internal void ProcessRecord_MfaSetting()
        {
            this._logger.name += " -MfaSetting";
            // Create new graphql operation mfaSetting
            InitQueryMfaSetting();
        }

        // This parameter set invokes a single graphql operation:
        // microsoftSites.
        internal void ProcessRecord_MicrosoftSites()
        {
            this._logger.name += " -MicrosoftSites";
            // Create new graphql operation microsoftSites
            InitQueryMicrosoftSites();
        }

        // This parameter set invokes a single graphql operation:
        // minimumCdmVersionForFeatureSet.
        internal void ProcessRecord_MinimumCdmVersionForFeatureSet()
        {
            this._logger.name += " -MinimumCdmVersionForFeatureSet";
            // Create new graphql operation minimumCdmVersionForFeatureSet
            InitQueryMinimumCdmVersionForFeatureSet();
        }

        // This parameter set invokes a single graphql operation:
        // allMipLabels.
        internal void ProcessRecord_MipLabels()
        {
            this._logger.name += " -MipLabels";
            // Create new graphql operation allMipLabels
            InitQueryAllMipLabels();
        }

        // This parameter set invokes a single graphql operation:
        // networkThrottle.
        internal void ProcessRecord_NetworkThrottle()
        {
            this._logger.name += " -NetworkThrottle";
            // Create new graphql operation networkThrottle
            InitQueryNetworkThrottle();
        }

        // This parameter set invokes a single graphql operation:
        // nfAnomalyResults.
        internal void ProcessRecord_NfAnomalyResults()
        {
            this._logger.name += " -NfAnomalyResults";
            // Create new graphql operation nfAnomalyResults
            InitQueryNfAnomalyResults();
        }

        // This parameter set invokes a single graphql operation:
        // nfAnomalyResultsGrouped.
        internal void ProcessRecord_NfAnomalyResultsGrouped()
        {
            this._logger.name += " -NfAnomalyResultsGrouped";
            // Create new graphql operation nfAnomalyResultsGrouped
            InitQueryNfAnomalyResultsGrouped();
        }

        // This parameter set invokes a single graphql operation:
        // nodeRemovalCancelPermission.
        internal void ProcessRecord_NodeRemovalCancelPermission()
        {
            this._logger.name += " -NodeRemovalCancelPermission";
            // Create new graphql operation nodeRemovalCancelPermission
            InitQueryNodeRemovalCancelPermission();
        }

        // This parameter set invokes a single graphql operation:
        // nodeToReplace.
        internal void ProcessRecord_NodeToReplace()
        {
            this._logger.name += " -NodeToReplace";
            // Create new graphql operation nodeToReplace
            InitQueryNodeToReplace();
        }

        // This parameter set invokes a single graphql operation:
        // nodeTunnelStatuses.
        internal void ProcessRecord_NodeTunnelStatuses()
        {
            this._logger.name += " -NodeTunnelStatuses";
            // Create new graphql operation nodeTunnelStatuses
            InitQueryNodeTunnelStatuses();
        }

        // This parameter set invokes a single graphql operation:
        // allNosqlStorageLocations.
        internal void ProcessRecord_NosqlStorageLocations()
        {
            this._logger.name += " -NosqlStorageLocations";
            // Create new graphql operation allNosqlStorageLocations
            InitQueryAllNosqlStorageLocations();
        }

        // This parameter set invokes a single graphql operation:
        // oauthCodesForEdgeReg.
        internal void ProcessRecord_OauthCodesForEdgeReg()
        {
            this._logger.name += " -OauthCodesForEdgeReg";
            // Create new graphql operation oauthCodesForEdgeReg
            InitQueryOauthCodesForEdgeReg();
        }

        // This parameter set invokes a single graphql operation:
        // objectFiles.
        internal void ProcessRecord_ObjectFiles()
        {
            this._logger.name += " -ObjectFiles";
            // Create new graphql operation objectFiles
            InitQueryObjectFiles();
        }

        // This parameter set invokes a single graphql operation:
        // objectTypeAccessSummary.
        internal void ProcessRecord_ObjectTypeAccessSummary()
        {
            this._logger.name += " -ObjectTypeAccessSummary";
            // Create new graphql operation objectTypeAccessSummary
            InitQueryObjectTypeAccessSummary();
        }

        // This parameter set invokes a single graphql operation:
        // allObjectsAlreadyAssignedToOrgs.
        internal void ProcessRecord_ObjectsAlreadyAssignedToOrgs()
        {
            this._logger.name += " -ObjectsAlreadyAssignedToOrgs";
            // Create new graphql operation allObjectsAlreadyAssignedToOrgs
            InitQueryAllObjectsAlreadyAssignedToOrgs();
        }

        // This parameter set invokes a single graphql operation:
        // org.
        internal void ProcessRecord_Org()
        {
            this._logger.name += " -Org";
            // Create new graphql operation org
            InitQueryOrg();
        }

        // This parameter set invokes a single graphql operation:
        // orgs.
        internal void ProcessRecord_Orgs()
        {
            this._logger.name += " -Orgs";
            // Create new graphql operation orgs
            InitQueryOrgs();
        }

        // This parameter set invokes a single graphql operation:
        // allOrgsByIds.
        internal void ProcessRecord_OrgsByIds()
        {
            this._logger.name += " -OrgsByIds";
            // Create new graphql operation allOrgsByIds
            InitQueryAllOrgsByIds();
        }

        // This parameter set invokes a single graphql operation:
        // orgsForPrincipal.
        internal void ProcessRecord_OrgsForPrincipal()
        {
            this._logger.name += " -OrgsForPrincipal";
            // Create new graphql operation orgsForPrincipal
            InitQueryOrgsForPrincipal();
        }

        // This parameter set invokes a single graphql operation:
        // passkeyConfig.
        internal void ProcessRecord_PasskeyConfig()
        {
            this._logger.name += " -PasskeyConfig";
            // Create new graphql operation passkeyConfig
            InitQueryPasskeyConfig();
        }

        // This parameter set invokes a single graphql operation:
        // passkeyInfo.
        internal void ProcessRecord_PasskeyInfo()
        {
            this._logger.name += " -PasskeyInfo";
            // Create new graphql operation passkeyInfo
            InitQueryPasskeyInfo();
        }

        // This parameter set invokes a single graphql operation:
        // pendingAction.
        internal void ProcessRecord_PendingAction()
        {
            this._logger.name += " -PendingAction";
            // Create new graphql operation pendingAction
            InitQueryPendingAction();
        }

        // This parameter set invokes a single graphql operation:
        // allPendingActions.
        internal void ProcessRecord_PendingActions()
        {
            this._logger.name += " -PendingActions";
            // Create new graphql operation allPendingActions
            InitQueryAllPendingActions();
        }

        // This parameter set invokes a single graphql operation:
        // phoenixRolloutProgress.
        internal void ProcessRecord_PhoenixRolloutProgress()
        {
            this._logger.name += " -PhoenixRolloutProgress";
            // Create new graphql operation phoenixRolloutProgress
            InitQueryPhoenixRolloutProgress();
        }

        // This parameter set invokes a single graphql operation:
        // pipelineHealthForTimeRange.
        internal void ProcessRecord_PipelineHealthForTimeRange()
        {
            this._logger.name += " -PipelineHealthForTimeRange";
            // Create new graphql operation pipelineHealthForTimeRange
            InitQueryPipelineHealthForTimeRange();
        }

        // This parameter set invokes a single graphql operation:
        // polarisInventorySubHierarchyRoot.
        internal void ProcessRecord_PolarisInventorySubHierarchyRoot()
        {
            this._logger.name += " -PolarisInventorySubHierarchyRoot";
            // Create new graphql operation polarisInventorySubHierarchyRoot
            InitQueryPolarisInventorySubHierarchyRoot();
        }

        // This parameter set invokes a single graphql operation:
        // policyDetails.
        internal void ProcessRecord_PolicyDetails()
        {
            this._logger.name += " -PolicyDetails";
            // Create new graphql operation policyDetails
            InitQueryPolicyDetails();
        }

        // This parameter set invokes a single graphql operation:
        // policyObj.
        internal void ProcessRecord_PolicyObj()
        {
            this._logger.name += " -PolicyObj";
            // Create new graphql operation policyObj
            InitQueryPolicyObj();
        }

        // This parameter set invokes a single graphql operation:
        // policyObjs.
        internal void ProcessRecord_PolicyObjs()
        {
            this._logger.name += " -PolicyObjs";
            // Create new graphql operation policyObjs
            InitQueryPolicyObjs();
        }

        // This parameter set invokes a single graphql operation:
        // prechecksStatus.
        internal void ProcessRecord_PrechecksStatus()
        {
            this._logger.name += " -PrechecksStatus";
            // Create new graphql operation prechecksStatus
            InitQueryPrechecksStatus();
        }

        // This parameter set invokes a single graphql operation:
        // prechecksStatusWithNextJobInfo.
        internal void ProcessRecord_PrechecksStatusWithNextJobInfo()
        {
            this._logger.name += " -PrechecksStatusWithNextJobInfo";
            // Create new graphql operation prechecksStatusWithNextJobInfo
            InitQueryPrechecksStatusWithNextJobInfo();
        }

        // This parameter set invokes a single graphql operation:
        // privateContainerRegistry.
        internal void ProcessRecord_PrivateContainerRegistry()
        {
            this._logger.name += " -PrivateContainerRegistry";
            // Create new graphql operation privateContainerRegistry
            InitQueryPrivateContainerRegistry();
        }

        // This parameter set invokes a single graphql operation:
        // productDocumentation.
        internal void ProcessRecord_ProductDocumentation()
        {
            this._logger.name += " -ProductDocumentation";
            // Create new graphql operation productDocumentation
            InitQueryProductDocumentation();
        }

        // This parameter set invokes a single graphql operation:
        // protectedObjectsConnection.
        internal void ProcessRecord_ProtectedObjectsList()
        {
            this._logger.name += " -ProtectedObjectsList";
            // Create new graphql operation protectedObjectsConnection
            InitQueryProtectedObjectsConnection();
        }

        // This parameter set invokes a single graphql operation:
        // protectedVolumesCount.
        internal void ProcessRecord_ProtectedVolumesCount()
        {
            this._logger.name += " -ProtectedVolumesCount";
            // Create new graphql operation protectedVolumesCount
            InitQueryProtectedVolumesCount();
        }

        // This parameter set invokes a single graphql operation:
        // allQuarantinedDetailsForWorkload.
        internal void ProcessRecord_QuarantinedDetailsForWorkload()
        {
            this._logger.name += " -QuarantinedDetailsForWorkload";
            // Create new graphql operation allQuarantinedDetailsForWorkload
            InitQueryAllQuarantinedDetailsForWorkload();
        }

        // This parameter set invokes a single graphql operation:
        // queryDatastoreFreespaceThresholds.
        internal void ProcessRecord_QueryDatastoreFreespaceThresholds()
        {
            this._logger.name += " -QueryDatastoreFreespaceThresholds";
            // Create new graphql operation queryDatastoreFreespaceThresholds
            InitQueryQueryDatastoreFreespaceThresholds();
        }

        // This parameter set invokes a single graphql operation:
        // removedNodeDetails.
        internal void ProcessRecord_RemovedNodeDetails()
        {
            this._logger.name += " -RemovedNodeDetails";
            // Create new graphql operation removedNodeDetails
            InitQueryRemovedNodeDetails();
        }

        // This parameter set invokes a single graphql operation:
        // roleTemplates.
        internal void ProcessRecord_RoleTemplates()
        {
            this._logger.name += " -RoleTemplates";
            // Create new graphql operation roleTemplates
            InitQueryRoleTemplates();
        }

        // This parameter set invokes a single graphql operation:
        // rscPermsToCdmInfo.
        internal void ProcessRecord_RscPermsToCdmInfo()
        {
            this._logger.name += " -RscPermsToCdmInfo";
            // Create new graphql operation rscPermsToCdmInfo
            InitQueryRscPermsToCdmInfo();
        }

        // This parameter set invokes a single graphql operation:
        // searchFileByPrefix.
        internal void ProcessRecord_SearchFileByPrefix()
        {
            this._logger.name += " -SearchFileByPrefix";
            // Create new graphql operation searchFileByPrefix
            InitQuerySearchFileByPrefix();
        }

        // This parameter set invokes a single graphql operation:
        // snoozedDirectories.
        internal void ProcessRecord_SnoozedDirectories()
        {
            this._logger.name += " -SnoozedDirectories";
            // Create new graphql operation snoozedDirectories
            InitQuerySnoozedDirectories();
        }

        // This parameter set invokes a single graphql operation:
        // ssoGroupAlreadyExists.
        internal void ProcessRecord_SsoGroupAlreadyExists()
        {
            this._logger.name += " -SsoGroupAlreadyExists";
            // Create new graphql operation ssoGroupAlreadyExists
            InitQuerySsoGroupAlreadyExists();
        }

        // This parameter set invokes a single graphql operation:
        // supportBundle.
        internal void ProcessRecord_SupportBundle()
        {
            this._logger.name += " -SupportBundle";
            // Create new graphql operation supportBundle
            InitQuerySupportBundle();
        }

        // This parameter set invokes a single graphql operation:
        // supportUserAccesses.
        internal void ProcessRecord_SupportUserAccesses()
        {
            this._logger.name += " -SupportUserAccesses";
            // Create new graphql operation supportUserAccesses
            InitQuerySupportUserAccesses();
        }

        // This parameter set invokes a single graphql operation:
        // tableFilters.
        internal void ProcessRecord_TableFilters()
        {
            this._logger.name += " -TableFilters";
            // Create new graphql operation tableFilters
            InitQueryTableFilters();
        }

        // This parameter set invokes a single graphql operation:
        // allTargets.
        internal void ProcessRecord_Targets()
        {
            this._logger.name += " -Targets";
            // Create new graphql operation allTargets
            InitQueryAllTargets();
        }

        // This parameter set invokes a single graphql operation:
        // taskDetailGroupByConnection.
        internal void ProcessRecord_TaskDetailGroupByList()
        {
            this._logger.name += " -TaskDetailGroupByList";
            // Create new graphql operation taskDetailGroupByConnection
            InitQueryTaskDetailGroupByConnection();
        }

        // This parameter set invokes a single graphql operation:
        // taskDetailConnection.
        internal void ProcessRecord_TaskDetailList()
        {
            this._logger.name += " -TaskDetailList";
            // Create new graphql operation taskDetailConnection
            InitQueryTaskDetailConnection();
        }

        // This parameter set invokes a single graphql operation:
        // taskchain.
        internal void ProcessRecord_Taskchain()
        {
            this._logger.name += " -Taskchain";
            // Create new graphql operation taskchain
            InitQueryTaskchain();
        }

        // This parameter set invokes a single graphql operation:
        // teamChannelNameAvailable.
        internal void ProcessRecord_TeamChannelNameAvailable()
        {
            this._logger.name += " -TeamChannelNameAvailable";
            // Create new graphql operation teamChannelNameAvailable
            InitQueryTeamChannelNameAvailable();
        }

        // This parameter set invokes a single graphql operation:
        // totpConfigStatus.
        internal void ProcessRecord_TotpConfigStatus()
        {
            this._logger.name += " -TotpConfigStatus";
            // Create new graphql operation totpConfigStatus
            InitQueryTotpConfigStatus();
        }

        // This parameter set invokes a single graphql operation:
        // tprConfiguration.
        internal void ProcessRecord_TprConfiguration()
        {
            this._logger.name += " -TprConfiguration";
            // Create new graphql operation tprConfiguration
            InitQueryTprConfiguration();
        }

        // This parameter set invokes a single graphql operation:
        // tprPublicConfiguration.
        internal void ProcessRecord_TprPublicConfiguration()
        {
            this._logger.name += " -TprPublicConfiguration";
            // Create new graphql operation tprPublicConfiguration
            InitQueryTprPublicConfiguration();
        }

        // This parameter set invokes a single graphql operation:
        // tprRequestDetail.
        internal void ProcessRecord_TprRequestDetail()
        {
            this._logger.name += " -TprRequestDetail";
            // Create new graphql operation tprRequestDetail
            InitQueryTprRequestDetail();
        }

        // This parameter set invokes a single graphql operation:
        // tprRequestSummaries.
        internal void ProcessRecord_TprRequestSummaries()
        {
            this._logger.name += " -TprRequestSummaries";
            // Create new graphql operation tprRequestSummaries
            InitQueryTprRequestSummaries();
        }

        // This parameter set invokes a single graphql operation:
        // tprRoleEligibility.
        internal void ProcessRecord_TprRoleEligibility()
        {
            this._logger.name += " -TprRoleEligibility";
            // Create new graphql operation tprRoleEligibility
            InitQueryTprRoleEligibility();
        }

        // This parameter set invokes a single graphql operation:
        // tprRulesMap.
        internal void ProcessRecord_TprRulesMap()
        {
            this._logger.name += " -TprRulesMap";
            // Create new graphql operation tprRulesMap
            InitQueryTprRulesMap();
        }

        // This parameter set invokes a single graphql operation:
        // tprStatusForNodeRemoval.
        internal void ProcessRecord_TprStatusForNodeRemoval()
        {
            this._logger.name += " -TprStatusForNodeRemoval";
            // Create new graphql operation tprStatusForNodeRemoval
            InitQueryTprStatusForNodeRemoval();
        }

        // This parameter set invokes a single graphql operation:
        // tunnelStatus.
        internal void ProcessRecord_TunnelStatus()
        {
            this._logger.name += " -TunnelStatus";
            // Create new graphql operation tunnelStatus
            InitQueryTunnelStatus();
        }

        // This parameter set invokes a single graphql operation:
        // uniqueVcdCount.
        internal void ProcessRecord_UniqueVcdCount()
        {
            this._logger.name += " -UniqueVcdCount";
            // Create new graphql operation uniqueVcdCount
            InitQueryUniqueVcdCount();
        }

        // This parameter set invokes a single graphql operation:
        // unmanagedObjects.
        internal void ProcessRecord_UnmanagedObjects()
        {
            this._logger.name += " -UnmanagedObjects";
            // Create new graphql operation unmanagedObjects
            InitQueryUnmanagedObjects();
        }

        // This parameter set invokes a single graphql operation:
        // allUnmanagedObjectsSupportedTypes.
        internal void ProcessRecord_UnmanagedObjectsSupportedTypes()
        {
            this._logger.name += " -UnmanagedObjectsSupportedTypes";
            // Create new graphql operation allUnmanagedObjectsSupportedTypes
            InitQueryAllUnmanagedObjectsSupportedTypes();
        }

        // This parameter set invokes a single graphql operation:
        // upgradeStatus.
        internal void ProcessRecord_UpgradeStatus()
        {
            this._logger.name += " -UpgradeStatus";
            // Create new graphql operation upgradeStatus
            InitQueryUpgradeStatus();
        }

        // This parameter set invokes a single graphql operation:
        // userActivities.
        internal void ProcessRecord_UserActivities()
        {
            this._logger.name += " -UserActivities";
            // Create new graphql operation userActivities
            InitQueryUserActivities();
        }

        // This parameter set invokes a single graphql operation:
        // userAlreadyExists.
        internal void ProcessRecord_UserAlreadyExists()
        {
            this._logger.name += " -UserAlreadyExists";
            // Create new graphql operation userAlreadyExists
            InitQueryUserAlreadyExists();
        }

        // This parameter set invokes a single graphql operation:
        // userAnalyzerAccess.
        internal void ProcessRecord_UserAnalyzerAccess()
        {
            this._logger.name += " -UserAnalyzerAccess";
            // Create new graphql operation userAnalyzerAccess
            InitQueryUserAnalyzerAccess();
        }

        // This parameter set invokes a single graphql operation:
        // userAuditConnection.
        internal void ProcessRecord_UserAuditList()
        {
            this._logger.name += " -UserAuditList";
            // Create new graphql operation userAuditConnection
            InitQueryUserAuditConnection();
        }

        // This parameter set invokes a single graphql operation:
        // userDetail.
        internal void ProcessRecord_UserDetail()
        {
            this._logger.name += " -UserDetail";
            // Create new graphql operation userDetail
            InitQueryUserDetail();
        }

        // This parameter set invokes a single graphql operation:
        // userFile.
        internal void ProcessRecord_UserFile()
        {
            this._logger.name += " -UserFile";
            // Create new graphql operation userFile
            InitQueryUserFile();
        }

        // This parameter set invokes a single graphql operation:
        // allUserFiles.
        internal void ProcessRecord_UserFiles()
        {
            this._logger.name += " -UserFiles";
            // Create new graphql operation allUserFiles
            InitQueryAllUserFiles();
        }

        // This parameter set invokes a single graphql operation:
        // userGroups.
        internal void ProcessRecord_UserGroups()
        {
            this._logger.name += " -UserGroups";
            // Create new graphql operation userGroups
            InitQueryUserGroups();
        }

        // This parameter set invokes a single graphql operation:
        // userNotifications.
        internal void ProcessRecord_UserNotifications()
        {
            this._logger.name += " -UserNotifications";
            // Create new graphql operation userNotifications
            InitQueryUserNotifications();
        }

        // This parameter set invokes a single graphql operation:
        // userSessionManagementConfig.
        internal void ProcessRecord_UserSessionManagementConfig()
        {
            this._logger.name += " -UserSessionManagementConfig";
            // Create new graphql operation userSessionManagementConfig
            InitQueryUserSessionManagementConfig();
        }

        // This parameter set invokes a single graphql operation:
        // userSettings.
        internal void ProcessRecord_UserSettings()
        {
            this._logger.name += " -UserSettings";
            // Create new graphql operation userSettings
            InitQueryUserSettings();
        }

        // This parameter set invokes a single graphql operation:
        // usersInCurrentAndDescendantOrganization.
        internal void ProcessRecord_UsersInCurrentAndDescendantOrganization()
        {
            this._logger.name += " -UsersInCurrentAndDescendantOrganization";
            // Create new graphql operation usersInCurrentAndDescendantOrganization
            InitQueryUsersInCurrentAndDescendantOrganization();
        }

        // This parameter set invokes a single graphql operation:
        // allUsersOnAccountConnection.
        internal void ProcessRecord_UsersOnAccountList()
        {
            this._logger.name += " -UsersOnAccountList";
            // Create new graphql operation allUsersOnAccountConnection
            InitQueryAllUsersOnAccountConnection();
        }

        // This parameter set invokes a single graphql operation:
        // validateOrgName.
        internal void ProcessRecord_ValidateOrgName()
        {
            this._logger.name += " -ValidateOrgName";
            // Create new graphql operation validateOrgName
            InitQueryValidateOrgName();
        }

        // This parameter set invokes a single graphql operation:
        // vcdVappVms.
        internal void ProcessRecord_VcdVappVms()
        {
            this._logger.name += " -VcdVappVms";
            // Create new graphql operation vcdVappVms
            InitQueryVcdVappVms();
        }

        // This parameter set invokes a single graphql operation:
        // verifyTotp.
        internal void ProcessRecord_VerifyTotp()
        {
            this._logger.name += " -VerifyTotp";
            // Create new graphql operation verifyTotp
            InitQueryVerifyTotp();
        }

        // This parameter set invokes a single graphql operation:
        // allVirtualMachineFiles.
        internal void ProcessRecord_VirtualMachineFiles()
        {
            this._logger.name += " -VirtualMachineFiles";
            // Create new graphql operation allVirtualMachineFiles
            InitQueryAllVirtualMachineFiles();
        }

        // This parameter set invokes a single graphql operation:
        // allVmRecoveryJobsInfo.
        internal void ProcessRecord_VmRecoveryJobsInfo()
        {
            this._logger.name += " -VmRecoveryJobsInfo";
            // Create new graphql operation allVmRecoveryJobsInfo
            InitQueryAllVmRecoveryJobsInfo();
        }

        // This parameter set invokes a single graphql operation:
        // volumeGroupMounts.
        internal void ProcessRecord_VolumeGroupMounts()
        {
            this._logger.name += " -VolumeGroupMounts";
            // Create new graphql operation volumeGroupMounts
            InitQueryVolumeGroupMounts();
        }

        // This parameter set invokes a single graphql operation:
        // workloadAlertSetting.
        internal void ProcessRecord_WorkloadAlertSetting()
        {
            this._logger.name += " -WorkloadAlertSetting";
            // Create new graphql operation workloadAlertSetting
            InitQueryWorkloadAlertSetting();
        }

        // This parameter set invokes a single graphql operation:
        // workloadAnomalies.
        internal void ProcessRecord_WorkloadAnomalies()
        {
            this._logger.name += " -WorkloadAnomalies";
            // Create new graphql operation workloadAnomalies
            InitQueryWorkloadAnomalies();
        }

        // This parameter set invokes a single graphql operation:
        // workloadForeverId.
        internal void ProcessRecord_WorkloadForeverId()
        {
            this._logger.name += " -WorkloadForeverId";
            // Create new graphql operation workloadForeverId
            InitQueryWorkloadForeverId();
        }


        // Create new GraphQL Query:
        // activeCustomAnalyzers: AnalyzerConnection!
        internal void InitQueryActiveCustomAnalyzers()
        {
            Tuple<string, string>[] argDefs = {
            };
            Initialize(
                argDefs,
                "query",
                "QueryActiveCustomAnalyzers",
                "",
                "AnalyzerConnection",
                Query.ActiveCustomAnalyzers,
                Query.ActiveCustomAnalyzersFieldSpec,
                @""
            );
        }

        // Create new GraphQL Query:
        // adGroupMembers(
        //     first: Int
        //     after: String
        //     orgId: UUID!
        //     adGroupSpec: AdGroupSpecInput!
        //   ): O365AdGroupMemberConnection!
        internal void InitQueryAdGroupMembers()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("orgId", "UUID!"),
                Tuple.Create("adGroupSpec", "AdGroupSpecInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAdGroupMembers",
                "($first: Int,$after: String,$orgId: UUID!,$adGroupSpec: AdGroupSpecInput!)",
                "O365AdGroupMemberConnection",
                Query.AdGroupMembers,
                Query.AdGroupMembersFieldSpec,
                @"# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# REQUIRED
$query.Var.orgId = $someString
# REQUIRED
$query.Var.adGroupSpec = @{
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
}"
            );
        }

        // Create new GraphQL Query:
        // adVolumeExports(
        //     first: Int
        //     after: String
        //     filters: [AdVolumeExportFilter!]
        //     sortBy: AdVolumeExportSortByInput
        //   ): AdVolumeExportConnection!
        internal void InitQueryAdVolumeExports()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("filters", "[AdVolumeExportFilter!]"),
                Tuple.Create("sortBy", "AdVolumeExportSortByInput"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAdVolumeExports",
                "($first: Int,$after: String,$filters: [AdVolumeExportFilter!],$sortBy: AdVolumeExportSortByInput)",
                "AdVolumeExportConnection",
                Query.AdVolumeExports,
                Query.AdVolumeExportsFieldSpec,
                @"# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# OPTIONAL
$query.Var.filters = @(
	@{
		# OPTIONAL
		field = $someAdVolumeExportFilterField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AdVolumeExportFilterField]) for enum values.
		# OPTIONAL
		texts = @(
			$someString
		)
}
)
# OPTIONAL
$query.Var.sortBy = @{
	# OPTIONAL
	field = $someAdVolumeExportSortByField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AdVolumeExportSortByField]) for enum values.
	# OPTIONAL
	sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
}"
            );
        }

        // Create new GraphQL Query:
        // agentDeploymentSetting(input: GetVmAgentDeploymentSettingInput!): AgentDeploymentSettings!
        internal void InitQueryAgentDeploymentSetting()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetVmAgentDeploymentSettingInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAgentDeploymentSetting",
                "($input: GetVmAgentDeploymentSettingInput!)",
                "AgentDeploymentSettings",
                Query.AgentDeploymentSetting,
                Query.AgentDeploymentSettingFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	clusterUuid = $someString
}"
            );
        }

        // Create new GraphQL Query:
        // allAgentDeploymentSettings(clusterUuids: [UUID!]!): [AgentDeploymentSettingsInfo!]!
        internal void InitQueryAllAgentDeploymentSettings()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("clusterUuids", "[UUID!]!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllAgentDeploymentSettings",
                "($clusterUuids: [UUID!]!)",
                "List<AgentDeploymentSettingsInfo>",
                Query.AllAgentDeploymentSettings,
                Query.AllAgentDeploymentSettingsFieldSpec,
                @"# REQUIRED
$query.Var.clusterUuids = @(
	$someString
)"
            );
        }

        // Create new GraphQL Query:
        // allAllowedOrgAdminOperations: [Operation!]!
        internal void InitQueryAllAllowedOrgAdminOperations()
        {
            Tuple<string, string>[] argDefs = {
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllAllowedOrgAdminOperations",
                "",
                "List<Operation>",
                Query.AllAllowedOrgAdminOperations,
                Query.AllAllowedOrgAdminOperationsFieldSpec,
                @""
            );
        }

        // Create new GraphQL Query:
        // analyzerGroups: AnalyzerGroupConnection!
        internal void InitQueryAnalyzerGroups()
        {
            Tuple<string, string>[] argDefs = {
            };
            Initialize(
                argDefs,
                "query",
                "QueryAnalyzerGroups",
                "",
                "AnalyzerGroupConnection",
                Query.AnalyzerGroups,
                Query.AnalyzerGroupsFieldSpec,
                @""
            );
        }

        // Create new GraphQL Query:
        // analyzerUsages(
        //     dataCategoryIdsFilter: [String!]
        //     riskLevelsFilter: [RiskLevelType!]
        //     sortBy: AnalyzerUsagesSortBy
        //     sortOrder: SortOrder
        //     dataTypeSourceFilter: DataTypeSource
        //     dataTypeNameSearchFilter: String
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //   ): AnalyzerUsageConnection!
        internal void InitQueryAnalyzerUsages()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("dataCategoryIdsFilter", "[String!]"),
                Tuple.Create("riskLevelsFilter", "[RiskLevelType!]"),
                Tuple.Create("sortBy", "AnalyzerUsagesSortBy"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("dataTypeSourceFilter", "DataTypeSource"),
                Tuple.Create("dataTypeNameSearchFilter", "String"),
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAnalyzerUsages",
                "($dataCategoryIdsFilter: [String!],$riskLevelsFilter: [RiskLevelType!],$sortBy: AnalyzerUsagesSortBy,$sortOrder: SortOrder,$dataTypeSourceFilter: DataTypeSource,$dataTypeNameSearchFilter: String,$first: Int,$after: String,$last: Int,$before: String)",
                "AnalyzerUsageConnection",
                Query.AnalyzerUsages,
                Query.AnalyzerUsagesFieldSpec,
                @"# OPTIONAL
$query.Var.dataCategoryIdsFilter = @(
	$someString
)
# OPTIONAL
$query.Var.riskLevelsFilter = @(
	$someRiskLevelType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RiskLevelType]) for enum values.
)
# OPTIONAL
$query.Var.sortBy = $someAnalyzerUsagesSortBy # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AnalyzerUsagesSortBy]) for enum values.
# OPTIONAL
$query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$query.Var.dataTypeSourceFilter = $someDataTypeSource # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DataTypeSource]) for enum values.
# OPTIONAL
$query.Var.dataTypeNameSearchFilter = $someString
# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# OPTIONAL
$query.Var.last = $someInt
# OPTIONAL
$query.Var.before = $someString"
            );
        }

        // Create new GraphQL Query:
        // anomalyResultOpt(
        //     clusterUuid: UUID
        //     snapshotId: String
        //     workloadId: UUID
        //     anomalyId: String
        //   ): GetAnomalyDetailsReply
        internal void InitQueryAnomalyResultOpt()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("clusterUuid", "UUID"),
                Tuple.Create("snapshotId", "String"),
                Tuple.Create("workloadId", "UUID"),
                Tuple.Create("anomalyId", "String"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAnomalyResultOpt",
                "($clusterUuid: UUID,$snapshotId: String,$workloadId: UUID,$anomalyId: String)",
                "GetAnomalyDetailsReply",
                Query.AnomalyResultOpt,
                Query.AnomalyResultOptFieldSpec,
                @"# OPTIONAL
$query.Var.clusterUuid = $someString
# OPTIONAL
$query.Var.snapshotId = $someString
# OPTIONAL
$query.Var.workloadId = $someString
# OPTIONAL
$query.Var.anomalyId = $someString"
            );
        }

        // Create new GraphQL Query:
        // anomalyResults(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     sortOrder: SortOrder
        //     sortBy: AnomalyResultSortBy
        //     filter: AnomalyResultFilterInput
        //     timezoneOffset: Float = 0.0
        //   ): AnomalyResultConnection!
        internal void InitQueryAnomalyResults()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("sortBy", "AnomalyResultSortBy"),
                Tuple.Create("filter", "AnomalyResultFilterInput"),
                Tuple.Create("timezoneOffset", "Float"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAnomalyResults",
                "($first: Int,$after: String,$last: Int,$before: String,$sortOrder: SortOrder,$sortBy: AnomalyResultSortBy,$filter: AnomalyResultFilterInput,$timezoneOffset: Float)",
                "AnomalyResultConnection",
                Query.AnomalyResults,
                Query.AnomalyResultsFieldSpec,
                @"# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# OPTIONAL
$query.Var.last = $someInt
# OPTIONAL
$query.Var.before = $someString
# OPTIONAL
$query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$query.Var.sortBy = $someAnomalyResultSortBy # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AnomalyResultSortBy]) for enum values.
# OPTIONAL
$query.Var.filter = @{
	# OPTIONAL
	clusterUuid = @(
		$someString
	)
	# OPTIONAL
	managedId = @(
		$someString
	)
	# OPTIONAL
	startTime = $someDateTime
	# OPTIONAL
	endTime = $someDateTime
	# OPTIONAL
	isAnomaly = $someBoolean
	# OPTIONAL
	workloadFid = @(
		$someString
	)
}
# OPTIONAL
$query.Var.timezoneOffset = $someSingle"
            );
        }

        // Create new GraphQL Query:
        // anomalyResultsGrouped(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     groupBy: AnomalyResultGroupBy!
        //     filter: AnomalyResultFilterInput
        //     timezoneOffset: Float = 0.0
        //   ): AnomalyResultGroupedDataConnection!
        internal void InitQueryAnomalyResultsGrouped()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("groupBy", "AnomalyResultGroupBy!"),
                Tuple.Create("filter", "AnomalyResultFilterInput"),
                Tuple.Create("timezoneOffset", "Float"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAnomalyResultsGrouped",
                "($first: Int,$after: String,$last: Int,$before: String,$groupBy: AnomalyResultGroupBy!,$filter: AnomalyResultFilterInput,$timezoneOffset: Float)",
                "AnomalyResultGroupedDataConnection",
                Query.AnomalyResultsGrouped,
                Query.AnomalyResultsGroupedFieldSpec,
                @"# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# OPTIONAL
$query.Var.last = $someInt
# OPTIONAL
$query.Var.before = $someString
# REQUIRED
$query.Var.groupBy = $someAnomalyResultGroupBy # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AnomalyResultGroupBy]) for enum values.
# OPTIONAL
$query.Var.filter = @{
	# OPTIONAL
	clusterUuid = @(
		$someString
	)
	# OPTIONAL
	managedId = @(
		$someString
	)
	# OPTIONAL
	startTime = $someDateTime
	# OPTIONAL
	endTime = $someDateTime
	# OPTIONAL
	isAnomaly = $someBoolean
	# OPTIONAL
	workloadFid = @(
		$someString
	)
}
# OPTIONAL
$query.Var.timezoneOffset = $someSingle"
            );
        }

        // Create new GraphQL Query:
        // areMultiGeoBackupsEnabled(orgId: UUID!): Boolean!
        internal void InitQueryAreMultiGeoBackupsEnabled()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("orgId", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAreMultiGeoBackupsEnabled",
                "($orgId: UUID!)",
                "System.Boolean",
                Query.AreMultiGeoBackupsEnabled,
                Query.AreMultiGeoBackupsEnabledFieldSpec,
                @"# REQUIRED
$query.Var.orgId = $someString"
            );
        }

        // Create new GraphQL Query:
        // allAuthorizationsForGlobalResource: [Operation!]!
        internal void InitQueryAllAuthorizationsForGlobalResource()
        {
            Tuple<string, string>[] argDefs = {
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllAuthorizationsForGlobalResource",
                "",
                "List<Operation>",
                Query.AllAuthorizationsForGlobalResource,
                Query.AllAuthorizationsForGlobalResourceFieldSpec,
                @""
            );
        }

        // Create new GraphQL Query:
        // allAuthorizationsForObject(fid: UUID!): [Operation!]!
        internal void InitQueryAllAuthorizationsForObject()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllAuthorizationsForObject",
                "($fid: UUID!)",
                "List<Operation>",
                Query.AllAuthorizationsForObject,
                Query.AllAuthorizationsForObjectFieldSpec,
                @"# REQUIRED
$query.Var.fid = $someString"
            );
        }

        // Create new GraphQL Query:
        // allAuthorizationsForObjects(fids: [UUID!]!): [AuthorizedOperations!]!
        internal void InitQueryAllAuthorizationsForObjects()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fids", "[UUID!]!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllAuthorizationsForObjects",
                "($fids: [UUID!]!)",
                "List<AuthorizedOperations>",
                Query.AllAuthorizationsForObjects,
                Query.AllAuthorizationsForObjectsFieldSpec,
                @"# REQUIRED
$query.Var.fids = @(
	$someString
)"
            );
        }

        // Create new GraphQL Query:
        // allAwsComputeSettings(
        //     sortBy: AwsCloudComputeSettingQuerySortByField
        //     sortOrder: SortOrder
        //     filter: [AwsCloudComputeSettingFilterInput!]
        //     contextFilter: ContextFilterTypeEnum
        //   ): [AwsComputeSettings!]!
        internal void InitQueryAllAwsComputeSettings()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("sortBy", "AwsCloudComputeSettingQuerySortByField"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("filter", "[AwsCloudComputeSettingFilterInput!]"),
                Tuple.Create("contextFilter", "ContextFilterTypeEnum"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllAwsComputeSettings",
                "($sortBy: AwsCloudComputeSettingQuerySortByField,$sortOrder: SortOrder,$filter: [AwsCloudComputeSettingFilterInput!],$contextFilter: ContextFilterTypeEnum)",
                "List<AwsComputeSettings>",
                Query.AllAwsComputeSettings,
                Query.AllAwsComputeSettingsFieldSpec,
                @"# OPTIONAL
$query.Var.sortBy = $someAwsCloudComputeSettingQuerySortByField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsCloudComputeSettingQuerySortByField]) for enum values.
# OPTIONAL
$query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$query.Var.filter = @(
	@{
		# OPTIONAL
		field = $someAwsCloudComputeSettingFilterField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsCloudComputeSettingFilterField]) for enum values.
		# OPTIONAL
		text = $someString
}
)
# OPTIONAL
$query.Var.contextFilter = $someContextFilterTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ContextFilterTypeEnum]) for enum values."
            );
        }

        // Create new GraphQL Query:
        // allAzureResourceGroups(cloudAccountId: String!, azureRegion: String!): [String!]!
        internal void InitQueryAllAzureResourceGroups()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("cloudAccountId", "String!"),
                Tuple.Create("azureRegion", "String!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllAzureResourceGroups",
                "($cloudAccountId: String!,$azureRegion: String!)",
                "List<System.String>",
                Query.AllAzureResourceGroups,
                Query.AllAzureResourceGroupsFieldSpec,
                @"# REQUIRED
$query.Var.cloudAccountId = $someString
# REQUIRED
$query.Var.azureRegion = $someString"
            );
        }

        // Create new GraphQL Query:
        // allAzureSubnets(subnetRequest: AzureSubnetReq!): [String!]!
        internal void InitQueryAllAzureSubnets()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("subnetRequest", "AzureSubnetReq!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllAzureSubnets",
                "($subnetRequest: AzureSubnetReq!)",
                "List<System.String>",
                Query.AllAzureSubnets,
                Query.AllAzureSubnetsFieldSpec,
                @"# REQUIRED
$query.Var.subnetRequest = @{
	# OPTIONAL
	cloudAccountId = $someString
	# OPTIONAL
	resourceGroup = $someString
	# OPTIONAL
	vnetName = $someString
}"
            );
        }

        // Create new GraphQL Query:
        // allBackupThrottleSettings(clusterUuids: [UUID!]!): [BackupThrottleSetting!]!
        internal void InitQueryAllBackupThrottleSettings()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("clusterUuids", "[UUID!]!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllBackupThrottleSettings",
                "($clusterUuids: [UUID!]!)",
                "List<BackupThrottleSetting>",
                Query.AllBackupThrottleSettings,
                Query.AllBackupThrottleSettingsFieldSpec,
                @"# REQUIRED
$query.Var.clusterUuids = @(
	$someString
)"
            );
        }

        // Create new GraphQL Query:
        // browseCalendar(
        //     first: Int
        //     after: String
        //     snappableFid: UUID!
        //     snapshotFid: UUID!
        //     folderId: String!
        //     orgId: UUID!
        //     calendarSearchFilter: CalendarSearchFilter
        //   ): O365ExchangeObjectConnection!
        internal void InitQueryBrowseCalendar()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("snappableFid", "UUID!"),
                Tuple.Create("snapshotFid", "UUID!"),
                Tuple.Create("folderId", "String!"),
                Tuple.Create("orgId", "UUID!"),
                Tuple.Create("calendarSearchFilter", "CalendarSearchFilter"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryBrowseCalendar",
                "($first: Int,$after: String,$snappableFid: UUID!,$snapshotFid: UUID!,$folderId: String!,$orgId: UUID!,$calendarSearchFilter: CalendarSearchFilter)",
                "O365ExchangeObjectConnection",
                Query.BrowseCalendar,
                Query.BrowseCalendarFieldSpec,
                @"# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# REQUIRED
$query.Var.snappableFid = $someString
# REQUIRED
$query.Var.snapshotFid = $someString
# REQUIRED
$query.Var.folderId = $someString
# REQUIRED
$query.Var.orgId = $someString
# OPTIONAL
$query.Var.calendarSearchFilter = @{
	# OPTIONAL
	searchKeywordFilter = @{
		# OPTIONAL
		searchKeyword = $someString
		# OPTIONAL
		keywordType = $someCalendarSearchKeywordType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CalendarSearchKeywordType]) for enum values.
	}
	# OPTIONAL
	emailAddresses = @(
		@{
			# OPTIONAL
			emailAddress = $someString
			# OPTIONAL
			filterType = $someCalendarEmailAddressFilterType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CalendarEmailAddressFilterType]) for enum values.
		}
	)
	# OPTIONAL
	timerange = @{
		# OPTIONAL
		fromTime = $someDateTime
		# OPTIONAL
		untilTime = $someDateTime
	}
	# OPTIONAL
	searchObjectFilter = @{
		# OPTIONAL
		searchObjectType = $someO365CalendarSearchObjectType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.O365CalendarSearchObjectType]) for enum values.
	}
	# OPTIONAL
	recurrenceFilter = @{
		# OPTIONAL
		recurrenceType = $someCalendarRecurrenceType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CalendarRecurrenceType]) for enum values.
	}
	# OPTIONAL
	lambdaFilters = @{
		# OPTIONAL
		enableAbsolutePaths = $someBoolean
		# OPTIONAL
		enableAbsolutePathCachePreload = $someBoolean
		# OPTIONAL
		parentFolderIdBatch = @(
			$someString
		)
		# OPTIONAL
		searchRecurseFolderId = $someString
		# OPTIONAL
		includeAncestors = $someBoolean
	}
	# OPTIONAL
	skipRifItems = $someBoolean
}"
            );
        }

        // Create new GraphQL Query:
        // browseContacts(
        //     first: Int
        //     after: String
        //     snappableFid: UUID!
        //     snapshotFid: UUID!
        //     folderId: String!
        //     orgId: UUID!
        //     contactsSearchFilter: ContactsSearchFilter
        //   ): O365ExchangeObjectConnection!
        internal void InitQueryBrowseContacts()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("snappableFid", "UUID!"),
                Tuple.Create("snapshotFid", "UUID!"),
                Tuple.Create("folderId", "String!"),
                Tuple.Create("orgId", "UUID!"),
                Tuple.Create("contactsSearchFilter", "ContactsSearchFilter"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryBrowseContacts",
                "($first: Int,$after: String,$snappableFid: UUID!,$snapshotFid: UUID!,$folderId: String!,$orgId: UUID!,$contactsSearchFilter: ContactsSearchFilter)",
                "O365ExchangeObjectConnection",
                Query.BrowseContacts,
                Query.BrowseContactsFieldSpec,
                @"# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# REQUIRED
$query.Var.snappableFid = $someString
# REQUIRED
$query.Var.snapshotFid = $someString
# REQUIRED
$query.Var.folderId = $someString
# REQUIRED
$query.Var.orgId = $someString
# OPTIONAL
$query.Var.contactsSearchFilter = @{
	# OPTIONAL
	searchKeywordFilter = @{
		# OPTIONAL
		searchKeyword = $someString
	}
	# OPTIONAL
	searchObjectFilter = @{
		# OPTIONAL
		searchObjectType = $someO365ContactsSearchObjectType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.O365ContactsSearchObjectType]) for enum values.
	}
	# OPTIONAL
	lambdaFilters = @{
		# OPTIONAL
		enableAbsolutePaths = $someBoolean
		# OPTIONAL
		enableAbsolutePathCachePreload = $someBoolean
		# OPTIONAL
		parentFolderIdBatch = @(
			$someString
		)
		# OPTIONAL
		searchRecurseFolderId = $someString
		# OPTIONAL
		includeAncestors = $someBoolean
	}
	# OPTIONAL
	skipRifItems = $someBoolean
}"
            );
        }

        // Create new GraphQL Query:
        // browseFolder(
        //     first: Int
        //     after: String
        //     snappableFid: UUID!
        //     snapshotFid: UUID!
        //     folderId: String!
        //     orgId: UUID!
        //   ): O365ExchangeObjectConnection!
        internal void InitQueryBrowseFolder()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("snappableFid", "UUID!"),
                Tuple.Create("snapshotFid", "UUID!"),
                Tuple.Create("folderId", "String!"),
                Tuple.Create("orgId", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryBrowseFolder",
                "($first: Int,$after: String,$snappableFid: UUID!,$snapshotFid: UUID!,$folderId: String!,$orgId: UUID!)",
                "O365ExchangeObjectConnection",
                Query.BrowseFolder,
                Query.BrowseFolderFieldSpec,
                @"# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# REQUIRED
$query.Var.snappableFid = $someString
# REQUIRED
$query.Var.snapshotFid = $someString
# REQUIRED
$query.Var.folderId = $someString
# REQUIRED
$query.Var.orgId = $someString"
            );
        }

        // Create new GraphQL Query:
        // browseOnedrive(
        //     first: Int
        //     after: String
        //     snappableFid: UUID!
        //     snapshotFid: UUID!
        //     folderId: String
        //     onedriveSearchFilter: OnedriveSearchFilter
        //     orgId: UUID!
        //   ): O365OnedriveObjectConnection!
        internal void InitQueryBrowseOnedrive()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("snappableFid", "UUID!"),
                Tuple.Create("snapshotFid", "UUID!"),
                Tuple.Create("folderId", "String"),
                Tuple.Create("onedriveSearchFilter", "OnedriveSearchFilter"),
                Tuple.Create("orgId", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryBrowseOnedrive",
                "($first: Int,$after: String,$snappableFid: UUID!,$snapshotFid: UUID!,$folderId: String,$onedriveSearchFilter: OnedriveSearchFilter,$orgId: UUID!)",
                "O365OnedriveObjectConnection",
                Query.BrowseOnedrive,
                Query.BrowseOnedriveFieldSpec,
                @"# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# REQUIRED
$query.Var.snappableFid = $someString
# REQUIRED
$query.Var.snapshotFid = $someString
# OPTIONAL
$query.Var.folderId = $someString
# OPTIONAL
$query.Var.onedriveSearchFilter = @{
	# OPTIONAL
	searchKeywordFilter = @{
		# OPTIONAL
		searchKeyword = $someString
		# OPTIONAL
		keywordType = $someOnedriveSearchKeywordType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.OnedriveSearchKeywordType]) for enum values.
	}
	# OPTIONAL
	modifiedTime = @{
		# OPTIONAL
		fromTime = $someDateTime
		# OPTIONAL
		untilTime = $someDateTime
	}
	# OPTIONAL
	createTime = @{
		# OPTIONAL
		fromTime = $someDateTime
		# OPTIONAL
		untilTime = $someDateTime
	}
	# OPTIONAL
	searchObjectFilter = @{
		# OPTIONAL
		searchObjectType = $someOnedriveSearchObjectType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.OnedriveSearchObjectType]) for enum values.
	}
	# OPTIONAL
	channelId = $someString
	# OPTIONAL
	channelFolderName = $someString
	# OPTIONAL
	channelMembershipType = $someChannelMembershipType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ChannelMembershipType]) for enum values.
	# OPTIONAL
	excludeItemsUnderRoot = $someBoolean
	# OPTIONAL
	channelNameKeyword = $someString
	# OPTIONAL
	useExactVersionMatch = $someBoolean
	# OPTIONAL
	lambdaFilters = @{
		# OPTIONAL
		enableAbsolutePaths = $someBoolean
		# OPTIONAL
		enableAbsolutePathCachePreload = $someBoolean
		# OPTIONAL
		parentFolderIdBatch = @(
			$someString
		)
		# OPTIONAL
		searchRecurseFolderId = $someString
		# OPTIONAL
		includeAncestors = $someBoolean
	}
}
# REQUIRED
$query.Var.orgId = $someString"
            );
        }

        // Create new GraphQL Query:
        // browseTeamsChannels(
        //     first: Int
        //     after: String
        //     snappableFid: UUID!
        //     snapshotFid: UUID!
        //     orgId: UUID!
        //     channelMembershipTypeFilter: ChannelMembershipType!
        //     nameFilter: String
        //   ): O365TeamsChannelConnection!
        internal void InitQueryBrowseTeamsChannels()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("snappableFid", "UUID!"),
                Tuple.Create("snapshotFid", "UUID!"),
                Tuple.Create("orgId", "UUID!"),
                Tuple.Create("channelMembershipTypeFilter", "ChannelMembershipType!"),
                Tuple.Create("nameFilter", "String"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryBrowseTeamsChannels",
                "($first: Int,$after: String,$snappableFid: UUID!,$snapshotFid: UUID!,$orgId: UUID!,$channelMembershipTypeFilter: ChannelMembershipType!,$nameFilter: String)",
                "O365TeamsChannelConnection",
                Query.BrowseTeamsChannels,
                Query.BrowseTeamsChannelsFieldSpec,
                @"# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# REQUIRED
$query.Var.snappableFid = $someString
# REQUIRED
$query.Var.snapshotFid = $someString
# REQUIRED
$query.Var.orgId = $someString
# REQUIRED
$query.Var.channelMembershipTypeFilter = $someChannelMembershipType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ChannelMembershipType]) for enum values.
# OPTIONAL
$query.Var.nameFilter = $someString"
            );
        }

        // Create new GraphQL Query:
        // browseTeamsDrive(
        //     first: Int
        //     after: String
        //     snappableFid: UUID!
        //     snapshotFid: UUID!
        //     folderId: String
        //     teamsDriveSearchFilter: OnedriveSearchFilter
        //     orgId: UUID!
        //   ): O365OnedriveObjectConnection!
        internal void InitQueryBrowseTeamsDrive()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("snappableFid", "UUID!"),
                Tuple.Create("snapshotFid", "UUID!"),
                Tuple.Create("folderId", "String"),
                Tuple.Create("teamsDriveSearchFilter", "OnedriveSearchFilter"),
                Tuple.Create("orgId", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryBrowseTeamsDrive",
                "($first: Int,$after: String,$snappableFid: UUID!,$snapshotFid: UUID!,$folderId: String,$teamsDriveSearchFilter: OnedriveSearchFilter,$orgId: UUID!)",
                "O365OnedriveObjectConnection",
                Query.BrowseTeamsDrive,
                Query.BrowseTeamsDriveFieldSpec,
                @"# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# REQUIRED
$query.Var.snappableFid = $someString
# REQUIRED
$query.Var.snapshotFid = $someString
# OPTIONAL
$query.Var.folderId = $someString
# OPTIONAL
$query.Var.teamsDriveSearchFilter = @{
	# OPTIONAL
	searchKeywordFilter = @{
		# OPTIONAL
		searchKeyword = $someString
		# OPTIONAL
		keywordType = $someOnedriveSearchKeywordType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.OnedriveSearchKeywordType]) for enum values.
	}
	# OPTIONAL
	modifiedTime = @{
		# OPTIONAL
		fromTime = $someDateTime
		# OPTIONAL
		untilTime = $someDateTime
	}
	# OPTIONAL
	createTime = @{
		# OPTIONAL
		fromTime = $someDateTime
		# OPTIONAL
		untilTime = $someDateTime
	}
	# OPTIONAL
	searchObjectFilter = @{
		# OPTIONAL
		searchObjectType = $someOnedriveSearchObjectType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.OnedriveSearchObjectType]) for enum values.
	}
	# OPTIONAL
	channelId = $someString
	# OPTIONAL
	channelFolderName = $someString
	# OPTIONAL
	channelMembershipType = $someChannelMembershipType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ChannelMembershipType]) for enum values.
	# OPTIONAL
	excludeItemsUnderRoot = $someBoolean
	# OPTIONAL
	channelNameKeyword = $someString
	# OPTIONAL
	useExactVersionMatch = $someBoolean
	# OPTIONAL
	lambdaFilters = @{
		# OPTIONAL
		enableAbsolutePaths = $someBoolean
		# OPTIONAL
		enableAbsolutePathCachePreload = $someBoolean
		# OPTIONAL
		parentFolderIdBatch = @(
			$someString
		)
		# OPTIONAL
		searchRecurseFolderId = $someString
		# OPTIONAL
		includeAncestors = $someBoolean
	}
}
# REQUIRED
$query.Var.orgId = $someString"
            );
        }

        // Create new GraphQL Query:
        // allCdmGuestCredentials(clusterUuids: [UUID!]!): [CdmGuestCredential!]!
        internal void InitQueryAllCdmGuestCredentials()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("clusterUuids", "[UUID!]!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllCdmGuestCredentials",
                "($clusterUuids: [UUID!]!)",
                "List<CdmGuestCredential>",
                Query.AllCdmGuestCredentials,
                Query.AllCdmGuestCredentialsFieldSpec,
                @"# REQUIRED
$query.Var.clusterUuids = @(
	$someString
)"
            );
        }

        // Create new GraphQL Query:
        // cdmInventorySubHierarchyRoot(rootEnum: InventorySubHierarchyRootEnum!): CdmInventorySubHierarchyRoot!
        internal void InitQueryCdmInventorySubHierarchyRoot()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("rootEnum", "InventorySubHierarchyRootEnum!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryCdmInventorySubHierarchyRoot",
                "($rootEnum: InventorySubHierarchyRootEnum!)",
                "CdmInventorySubHierarchyRoot",
                Query.CdmInventorySubHierarchyRoot,
                Query.CdmInventorySubHierarchyRootFieldSpec,
                @"# REQUIRED
$query.Var.rootEnum = $someInventorySubHierarchyRootEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.InventorySubHierarchyRootEnum]) for enum values."
            );
        }

        // Create new GraphQL Query:
        // allCdmOvaDetails: [CdmOvaDetail!]!
        internal void InitQueryAllCdmOvaDetails()
        {
            Tuple<string, string>[] argDefs = {
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllCdmOvaDetails",
                "",
                "List<CdmOvaDetail>",
                Query.AllCdmOvaDetails,
                Query.AllCdmOvaDetailsFieldSpec,
                @""
            );
        }

        // Create new GraphQL Query:
        // cdmVersionCheck(featureToCdmVersion: FeatureCdmVersionInput!): FeatureCdmVersionReply!
        internal void InitQueryCdmVersionCheck()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("featureToCdmVersion", "FeatureCdmVersionInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryCdmVersionCheck",
                "($featureToCdmVersion: FeatureCdmVersionInput!)",
                "FeatureCdmVersionReply",
                Query.CdmVersionCheck,
                Query.CdmVersionCheckFieldSpec,
                @"# REQUIRED
$query.Var.featureToCdmVersion = @{
	# REQUIRED
	clusterUuid = $someString
	# REQUIRED
	featureType = $someCdmFeatureFlagType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CdmFeatureFlagType]) for enum values.
}"
            );
        }

        // Create new GraphQL Query:
        // allCdpVmsInfos(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     allCdpVmInfoSort: CdpPerfDashboardSortParam
        //     allCdpVmInfoFilter: [CdpPerfDashboardFilterParam!]
        //   ): CdpVmInfoConnection!
        internal void InitQueryAllCdpVmsInfos()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("allCdpVmInfoSort", "CdpPerfDashboardSortParam"),
                Tuple.Create("allCdpVmInfoFilter", "[CdpPerfDashboardFilterParam!]"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllCdpVmsInfos",
                "($first: Int,$after: String,$last: Int,$before: String,$allCdpVmInfoSort: CdpPerfDashboardSortParam,$allCdpVmInfoFilter: [CdpPerfDashboardFilterParam!])",
                "CdpVmInfoConnection",
                Query.AllCdpVmsInfos,
                Query.AllCdpVmsInfosFieldSpec,
                @"# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# OPTIONAL
$query.Var.last = $someInt
# OPTIONAL
$query.Var.before = $someString
# OPTIONAL
$query.Var.allCdpVmInfoSort = @{
	# OPTIONAL
	type = $someCdpPerfDashboardSortType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CdpPerfDashboardSortType]) for enum values.
	# OPTIONAL
	sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
}
# OPTIONAL
$query.Var.allCdpVmInfoFilter = @(
	@{
		# OPTIONAL
		filterField = $someCdpPerfDashboardFilterField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CdpPerfDashboardFilterField]) for enum values.
		# OPTIONAL
		sourceClusterUuids = @(
			$someString
		)
		# OPTIONAL
		slaDomainIds = @(
			$someString
		)
		# OPTIONAL
		localStatus = @(
			$someCdpLocalStatus # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CdpLocalStatus]) for enum values.
		)
		# OPTIONAL
		replicationStatus = @(
			$someCdpReplicationStatus # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CdpReplicationStatus]) for enum values.
		)
		# OPTIONAL
		cdpIoFilterStatus = @(
			$someIoFilterStatus # Call [Enum]::GetValues([RubrikSecurityCloud.Types.IoFilterStatus]) for enum values.
		)
		# OPTIONAL
		vmName = $someString
}
)"
            );
        }

        // Create new GraphQL Query:
        // checkCloudComputeConnectivityJobProgress(input: GetCloudComputeConnectivityCheckRequestStatusInput!): AsyncRequestStatus!
        internal void InitQueryCheckCloudComputeConnectivityJobProgress()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetCloudComputeConnectivityCheckRequestStatusInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryCheckCloudComputeConnectivityJobProgress",
                "($input: GetCloudComputeConnectivityCheckRequestStatusInput!)",
                "AsyncRequestStatus",
                Query.CheckCloudComputeConnectivityJobProgress,
                Query.CheckCloudComputeConnectivityJobProgressFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someString
}"
            );
        }

        // Create new GraphQL Query:
        // checkLatestVersionMgmtAppExists(input: CheckLatestVersionMgmtAppExistsInput!): CheckLatestVersionMgmtAppExistsReply!
        internal void InitQueryCheckLatestVersionMgmtAppExists()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CheckLatestVersionMgmtAppExistsInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryCheckLatestVersionMgmtAppExists",
                "($input: CheckLatestVersionMgmtAppExistsInput!)",
                "CheckLatestVersionMgmtAppExistsReply",
                Query.CheckLatestVersionMgmtAppExists,
                Query.CheckLatestVersionMgmtAppExistsFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	o365OrgId = $someString
}"
            );
        }

        // Create new GraphQL Query:
        // cloudDirectNasExport(fid: UUID!): CloudDirectNasExport!
        internal void InitQueryCloudDirectNasExport()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryCloudDirectNasExport",
                "($fid: UUID!)",
                "CloudDirectNasExport",
                Query.CloudDirectNasExport,
                Query.CloudDirectNasExportFieldSpec,
                @"# REQUIRED
$query.Var.fid = $someString"
            );
        }

        // Create new GraphQL Query:
        // cloudDirectNasNamespace(fid: UUID!): CloudDirectNasNamespace!
        internal void InitQueryCloudDirectNasNamespace()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryCloudDirectNasNamespace",
                "($fid: UUID!)",
                "CloudDirectNasNamespace",
                Query.CloudDirectNasNamespace,
                Query.CloudDirectNasNamespaceFieldSpec,
                @"# REQUIRED
$query.Var.fid = $someString"
            );
        }

        // Create new GraphQL Query:
        // cloudDirectNasNamespaces(
        //     first: Int
        //     after: String
        //     sortBy: HierarchySortByField
        //     sortOrder: SortOrder
        //     filter: [Filter!]
        //   ): CloudDirectNasNamespaceConnection!
        internal void InitQueryCloudDirectNasNamespaces()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("sortBy", "HierarchySortByField"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("filter", "[Filter!]"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryCloudDirectNasNamespaces",
                "($first: Int,$after: String,$sortBy: HierarchySortByField,$sortOrder: SortOrder,$filter: [Filter!])",
                "CloudDirectNasNamespaceConnection",
                Query.CloudDirectNasNamespaces,
                Query.CloudDirectNasNamespacesFieldSpec,
                @"# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# OPTIONAL
$query.Var.sortBy = $someHierarchySortByField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchySortByField]) for enum values.
# OPTIONAL
$query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$query.Var.filter = @(
	@{
		# OPTIONAL
		field = $someHierarchyFilterField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchyFilterField]) for enum values.
		# OPTIONAL
		texts = @(
			$someString
		)
		# OPTIONAL
		tagFilterParams = @(
			@{
				# OPTIONAL
				filterType = $someTagFilterType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TagFilterType]) for enum values.
				# OPTIONAL
				tagKey = $someString
				# OPTIONAL
				tagValue = $someString
			}
		)
		# OPTIONAL
		objectTypeFilterParams = @(
			$someManagedObjectType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ManagedObjectType]) for enum values.
		)
		# OPTIONAL
		awsNativeProtectionFeatureNames = @(
			$someAwsNativeProtectionFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		isNegative = $someBoolean
		# OPTIONAL
		isSlowSearchEnabled = $someBoolean
		# OPTIONAL
		azureNativeProtectionFeatureNames = @(
			$someAzureNativeProtectionFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		unmanagedObjectAvailabilityFilter = @(
			$someUnmanagedObjectAvailabilityFilter # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UnmanagedObjectAvailabilityFilter]) for enum values.
		)
}
)"
            );
        }

        // Create new GraphQL Query:
        // cloudDirectNasShare(fid: UUID!): CloudDirectNasShare!
        internal void InitQueryCloudDirectNasShare()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryCloudDirectNasShare",
                "($fid: UUID!)",
                "CloudDirectNasShare",
                Query.CloudDirectNasShare,
                Query.CloudDirectNasShareFieldSpec,
                @"# REQUIRED
$query.Var.fid = $someString"
            );
        }

        // Create new GraphQL Query:
        // allCloudDirectShares(input: AllCloudDirectSharesInput!): [ShareExportIdPair!]!
        internal void InitQueryAllCloudDirectShares()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "AllCloudDirectSharesInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllCloudDirectShares",
                "($input: AllCloudDirectSharesInput!)",
                "List<ShareExportIdPair>",
                Query.AllCloudDirectShares,
                Query.AllCloudDirectSharesFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	systemName = $someString
	# REQUIRED
	exportType = $someShareTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ShareTypeEnum]) for enum values.
}"
            );
        }

        // Create new GraphQL Query:
        // allCloudDirectSites: [CloudDirectSite!]!
        internal void InitQueryAllCloudDirectSites()
        {
            Tuple<string, string>[] argDefs = {
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllCloudDirectSites",
                "",
                "List<CloudDirectSite>",
                Query.AllCloudDirectSites,
                Query.AllCloudDirectSitesFieldSpec,
                @""
            );
        }

        // Create new GraphQL Query:
        // cloudDirectSystems(input: CloudDirectSystemsInput!): CloudDirectSystems!
        internal void InitQueryCloudDirectSystems()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CloudDirectSystemsInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryCloudDirectSystems",
                "($input: CloudDirectSystemsInput!)",
                "CloudDirectSystems",
                Query.CloudDirectSystems,
                Query.CloudDirectSystemsFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	clusterId = $someString
}"
            );
        }

        // Create new GraphQL Query:
        // configuredGroupMembers(
        //     first: Int
        //     after: String
        //     orgId: UUID!
        //     wildcard: String
        //     pdls: [String!]!
        //     workloadHierarchy: WorkloadLevelHierarchy
        //     groupFilterAttributes: [GroupFilterAttribute!]
        //   ): O365ConfiguredGroupMemberConnection!
        internal void InitQueryConfiguredGroupMembers()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("orgId", "UUID!"),
                Tuple.Create("wildcard", "String"),
                Tuple.Create("pdls", "[String!]!"),
                Tuple.Create("workloadHierarchy", "WorkloadLevelHierarchy"),
                Tuple.Create("groupFilterAttributes", "[GroupFilterAttribute!]"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryConfiguredGroupMembers",
                "($first: Int,$after: String,$orgId: UUID!,$wildcard: String,$pdls: [String!]!,$workloadHierarchy: WorkloadLevelHierarchy,$groupFilterAttributes: [GroupFilterAttribute!])",
                "O365ConfiguredGroupMemberConnection",
                Query.ConfiguredGroupMembers,
                Query.ConfiguredGroupMembersFieldSpec,
                @"# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# REQUIRED
$query.Var.orgId = $someString
# OPTIONAL
$query.Var.wildcard = $someString
# REQUIRED
$query.Var.pdls = @(
	$someString
)
# OPTIONAL
$query.Var.workloadHierarchy = $someWorkloadLevelHierarchy # Call [Enum]::GetValues([RubrikSecurityCloud.Types.WorkloadLevelHierarchy]) for enum values.
# OPTIONAL
$query.Var.groupFilterAttributes = @(
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
)"
            );
        }

        // Create new GraphQL Query:
        // crawl(crawlId: String!): Crawl!
        internal void InitQueryCrawl()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("crawlId", "String!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryCrawl",
                "($crawlId: String!)",
                "Crawl",
                Query.Crawl,
                Query.CrawlFieldSpec,
                @"# REQUIRED
$query.Var.crawlId = $someString"
            );
        }

        // Create new GraphQL Query:
        // crawls: CrawlConnection!
        internal void InitQueryCrawls()
        {
            Tuple<string, string>[] argDefs = {
            };
            Initialize(
                argDefs,
                "query",
                "QueryCrawls",
                "",
                "CrawlConnection",
                Query.Crawls,
                Query.CrawlsFieldSpec,
                @""
            );
        }

        // Create new GraphQL Query:
        // crossAccountPairs(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     sortBy: GetCrossAccountPairsSortByField
        //     filter: [GetCrossAccountPairsFilter!]
        //     sortOrder: SortOrder
        //   ): CrossAccountPairInfoConnection!
        internal void InitQueryCrossAccountPairs()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("sortBy", "GetCrossAccountPairsSortByField"),
                Tuple.Create("filter", "[GetCrossAccountPairsFilter!]"),
                Tuple.Create("sortOrder", "SortOrder"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryCrossAccountPairs",
                "($first: Int,$after: String,$last: Int,$before: String,$sortBy: GetCrossAccountPairsSortByField,$filter: [GetCrossAccountPairsFilter!],$sortOrder: SortOrder)",
                "CrossAccountPairInfoConnection",
                Query.CrossAccountPairs,
                Query.CrossAccountPairsFieldSpec,
                @"# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# OPTIONAL
$query.Var.last = $someInt
# OPTIONAL
$query.Var.before = $someString
# OPTIONAL
$query.Var.sortBy = $someGetCrossAccountPairsSortByField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.GetCrossAccountPairsSortByField]) for enum values.
# OPTIONAL
$query.Var.filter = @(
	@{
		# OPTIONAL
		field = $someGetCrossAccountPairsFilterField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.GetCrossAccountPairsFilterField]) for enum values.
		# OPTIONAL
		text = $someString
}
)
# OPTIONAL
$query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values."
            );
        }

        // Create new GraphQL Query:
        // currentIpAddress: String!
        internal void InitQueryCurrentIpAddress()
        {
            Tuple<string, string>[] argDefs = {
            };
            Initialize(
                argDefs,
                "query",
                "QueryCurrentIpAddress",
                "",
                "System.String",
                Query.CurrentIpAddress,
                Query.CurrentIpAddressFieldSpec,
                @""
            );
        }

        // Create new GraphQL Query:
        // currentOrg: Org!
        internal void InitQueryCurrentOrg()
        {
            Tuple<string, string>[] argDefs = {
            };
            Initialize(
                argDefs,
                "query",
                "QueryCurrentOrg",
                "",
                "Org",
                Query.CurrentOrg,
                Query.CurrentOrgFieldSpec,
                @""
            );
        }

        // Create new GraphQL Query:
        // currentOrgAuthDomainConfig: TenantAuthDomainConfig!
        internal void InitQueryCurrentOrgAuthDomainConfig()
        {
            Tuple<string, string>[] argDefs = {
            };
            Initialize(
                argDefs,
                "query",
                "QueryCurrentOrgAuthDomainConfig",
                "",
                "TenantAuthDomainConfig",
                Query.CurrentOrgAuthDomainConfig,
                Query.CurrentOrgAuthDomainConfigFieldSpec,
                @""
            );
        }

        // Create new GraphQL Query:
        // allCurrentOrgIdentityProviders: [IdentityProvider!]!
        internal void InitQueryAllCurrentOrgIdentityProviders()
        {
            Tuple<string, string>[] argDefs = {
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllCurrentOrgIdentityProviders",
                "",
                "List<IdentityProvider>",
                Query.AllCurrentOrgIdentityProviders,
                Query.AllCurrentOrgIdentityProvidersFieldSpec,
                @""
            );
        }

        // Create new GraphQL Query:
        // customAnalyzer(analyzerId: String!): Analyzer!
        internal void InitQueryCustomAnalyzer()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("analyzerId", "String!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryCustomAnalyzer",
                "($analyzerId: String!)",
                "Analyzer",
                Query.CustomAnalyzer,
                Query.CustomAnalyzerFieldSpec,
                @"# REQUIRED
$query.Var.analyzerId = $someString"
            );
        }

        // Create new GraphQL Query:
        // dashboardSummary(getWhitelistedResults: Boolean!): GetDashboardSummaryReply!
        internal void InitQueryDashboardSummary()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("getWhitelistedResults", "Boolean!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryDashboardSummary",
                "($getWhitelistedResults: Boolean!)",
                "GetDashboardSummaryReply",
                Query.DashboardSummary,
                Query.DashboardSummaryFieldSpec,
                @"# REQUIRED
$query.Var.getWhitelistedResults = $someBoolean"
            );
        }

        // Create new GraphQL Query:
        // datagovSecDesc(
        //     snappableFid: String!
        //     snapshotFid: String!
        //     stdPath: String!
        //     skipResolveSids: Boolean
        //     filters: SddlRequestFiltersInput
        //   ): QuerySDDLReply!
        internal void InitQueryDatagovSecDesc()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("snappableFid", "String!"),
                Tuple.Create("snapshotFid", "String!"),
                Tuple.Create("stdPath", "String!"),
                Tuple.Create("skipResolveSids", "Boolean"),
                Tuple.Create("filters", "SddlRequestFiltersInput"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryDatagovSecDesc",
                "($snappableFid: String!,$snapshotFid: String!,$stdPath: String!,$skipResolveSids: Boolean,$filters: SddlRequestFiltersInput)",
                "QuerySddlReply",
                Query.DatagovSecDesc,
                Query.DatagovSecDescFieldSpec,
                @"# REQUIRED
$query.Var.snappableFid = $someString
# REQUIRED
$query.Var.snapshotFid = $someString
# REQUIRED
$query.Var.stdPath = $someString
# OPTIONAL
$query.Var.skipResolveSids = $someBoolean
# OPTIONAL
$query.Var.filters = @{
	# OPTIONAL
	resultsForSid = $someString
}"
            );
        }

        // Create new GraphQL Query:
        // decryptExportUrl(workloadFid: UUID!, exportUrlSpecsEnc: String!): ExportUrlSpecs!
        internal void InitQueryDecryptExportUrl()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("workloadFid", "UUID!"),
                Tuple.Create("exportUrlSpecsEnc", "String!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryDecryptExportUrl",
                "($workloadFid: UUID!,$exportUrlSpecsEnc: String!)",
                "ExportUrlSpecs",
                Query.DecryptExportUrl,
                Query.DecryptExportUrlFieldSpec,
                @"# REQUIRED
$query.Var.workloadFid = $someString
# REQUIRED
$query.Var.exportUrlSpecsEnc = $someString"
            );
        }

        // Create new GraphQL Query:
        // allDeploymentIpAddresses: [String!]!
        internal void InitQueryAllDeploymentIpAddresses()
        {
            Tuple<string, string>[] argDefs = {
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllDeploymentIpAddresses",
                "",
                "List<System.String>",
                Query.AllDeploymentIpAddresses,
                Query.AllDeploymentIpAddressesFieldSpec,
                @""
            );
        }

        // Create new GraphQL Query:
        // deploymentVersion: String!
        internal void InitQueryDeploymentVersion()
        {
            Tuple<string, string>[] argDefs = {
            };
            Initialize(
                argDefs,
                "query",
                "QueryDeploymentVersion",
                "",
                "System.String",
                Query.DeploymentVersion,
                Query.DeploymentVersionFieldSpec,
                @""
            );
        }

        // Create new GraphQL Query:
        // allDhrcActiveRecommendations(categories: [DhrcCategory!]): [DhrcActiveRecommendation!]!
        internal void InitQueryAllDhrcActiveRecommendations()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("categories", "[DhrcCategory!]"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllDhrcActiveRecommendations",
                "($categories: [DhrcCategory!])",
                "List<DhrcActiveRecommendation>",
                Query.AllDhrcActiveRecommendations,
                Query.AllDhrcActiveRecommendationsFieldSpec,
                @"# OPTIONAL
$query.Var.categories = @(
	$someDhrcCategory # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DhrcCategory]) for enum values.
)"
            );
        }

        // Create new GraphQL Query:
        // allDhrcLatestMetrics(categories: [DhrcCategory!]): [DhrcCollectedMetric!]!
        internal void InitQueryAllDhrcLatestMetrics()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("categories", "[DhrcCategory!]"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllDhrcLatestMetrics",
                "($categories: [DhrcCategory!])",
                "List<DhrcCollectedMetric>",
                Query.AllDhrcLatestMetrics,
                Query.AllDhrcLatestMetricsFieldSpec,
                @"# OPTIONAL
$query.Var.categories = @(
	$someDhrcCategory # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DhrcCategory]) for enum values.
)"
            );
        }

        // Create new GraphQL Query:
        // allDhrcScores(categories: [DhrcCategory!], beginTime: DateTime, timespan: DhrcScoreTimespan): [DhrcScore!]!
        internal void InitQueryAllDhrcScores()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("categories", "[DhrcCategory!]"),
                Tuple.Create("beginTime", "DateTime"),
                Tuple.Create("timespan", "DhrcScoreTimespan"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllDhrcScores",
                "($categories: [DhrcCategory!],$beginTime: DateTime,$timespan: DhrcScoreTimespan)",
                "List<DhrcScore>",
                Query.AllDhrcScores,
                Query.AllDhrcScoresFieldSpec,
                @"# OPTIONAL
$query.Var.categories = @(
	$someDhrcCategory # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DhrcCategory]) for enum values.
)
# OPTIONAL
$query.Var.beginTime = $someDateTime
# OPTIONAL
$query.Var.timespan = $someDhrcScoreTimespan # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DhrcScoreTimespan]) for enum values."
            );
        }

        // Create new GraphQL Query:
        // diffFmd(
        //     clusterUuid: UUID!
        //     managedId: String!
        //     snapshotId: String!
        //     browseDiffPath: String!
        //   ): DiffResult!
        internal void InitQueryDiffFmd()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("clusterUuid", "UUID!"),
                Tuple.Create("managedId", "String!"),
                Tuple.Create("snapshotId", "String!"),
                Tuple.Create("browseDiffPath", "String!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryDiffFmd",
                "($clusterUuid: UUID!,$managedId: String!,$snapshotId: String!,$browseDiffPath: String!)",
                "DiffResult",
                Query.DiffFmd,
                Query.DiffFmdFieldSpec,
                @"# REQUIRED
$query.Var.clusterUuid = $someString
# REQUIRED
$query.Var.managedId = $someString
# REQUIRED
$query.Var.snapshotId = $someString
# REQUIRED
$query.Var.browseDiffPath = $someString"
            );
        }

        // Create new GraphQL Query:
        // discoverNodes(id: String!): BootstrappableNodeInfoListResponse!
        internal void InitQueryDiscoverNodes()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("id", "String!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryDiscoverNodes",
                "($id: String!)",
                "BootstrappableNodeInfoListResponse",
                Query.DiscoverNodes,
                Query.DiscoverNodesFieldSpec,
                @"# REQUIRED
$query.Var.id = $someString"
            );
        }

        // Create new GraphQL Query:
        // discoveryTimeline(
        //     startDay: String!
        //     endDay: String!
        //     timezone: String!
        //     getWhitelistedResults: Boolean!
        //     workloadTypes: [DataGovObjectType!]! = []
        //     useOptimisedDiscoveryTimeline: Boolean
        //     subscriptionIdsFilter: [String!]
        //     objectIdsFilter: [String!]
        //     platformCategoryFilter: [PlatformCategory!]
        //   ): GetPoliciesTimelineReply!
        internal void InitQueryDiscoveryTimeline()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("startDay", "String!"),
                Tuple.Create("endDay", "String!"),
                Tuple.Create("timezone", "String!"),
                Tuple.Create("getWhitelistedResults", "Boolean!"),
                Tuple.Create("workloadTypes", "[DataGovObjectType!]!"),
                Tuple.Create("useOptimisedDiscoveryTimeline", "Boolean"),
                Tuple.Create("subscriptionIdsFilter", "[String!]"),
                Tuple.Create("objectIdsFilter", "[String!]"),
                Tuple.Create("platformCategoryFilter", "[PlatformCategory!]"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryDiscoveryTimeline",
                "($startDay: String!,$endDay: String!,$timezone: String!,$getWhitelistedResults: Boolean!,$workloadTypes: [DataGovObjectType!]!,$useOptimisedDiscoveryTimeline: Boolean,$subscriptionIdsFilter: [String!],$objectIdsFilter: [String!],$platformCategoryFilter: [PlatformCategory!])",
                "GetPoliciesTimelineReply",
                Query.DiscoveryTimeline,
                Query.DiscoveryTimelineFieldSpec,
                @"# REQUIRED
$query.Var.startDay = $someString
# REQUIRED
$query.Var.endDay = $someString
# REQUIRED
$query.Var.timezone = $someString
# REQUIRED
$query.Var.getWhitelistedResults = $someBoolean
# REQUIRED
$query.Var.workloadTypes = @(
	$someDataGovObjectType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DataGovObjectType]) for enum values.
)
# OPTIONAL
$query.Var.useOptimisedDiscoveryTimeline = $someBoolean
# OPTIONAL
$query.Var.subscriptionIdsFilter = @(
	$someString
)
# OPTIONAL
$query.Var.objectIdsFilter = @(
	$someString
)
# OPTIONAL
$query.Var.platformCategoryFilter = @(
	$somePlatformCategory # Call [Enum]::GetValues([RubrikSecurityCloud.Types.PlatformCategory]) for enum values.
)"
            );
        }

        // Create new GraphQL Query:
        // distributionListDigest(input: DistributionDigestByIdInput!): EventDigest!
        internal void InitQueryDistributionListDigest()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DistributionDigestByIdInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryDistributionListDigest",
                "($input: DistributionDigestByIdInput!)",
                "EventDigest",
                Query.DistributionListDigest,
                Query.DistributionListDigestFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	digestId = $someInt
}"
            );
        }

        // Create new GraphQL Query:
        // allDistributionListDigests: [EventDigest!]!
        internal void InitQueryAllDistributionListDigests()
        {
            Tuple<string, string>[] argDefs = {
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllDistributionListDigests",
                "",
                "List<EventDigest>",
                Query.AllDistributionListDigests,
                Query.AllDistributionListDigestsFieldSpec,
                @""
            );
        }

        // Create new GraphQL Query:
        // dummyFieldWithAdminOnlyTag: Boolean!
        internal void InitQueryDummyFieldWithAdminOnlyTag()
        {
            Tuple<string, string>[] argDefs = {
            };
            Initialize(
                argDefs,
                "query",
                "QueryDummyFieldWithAdminOnlyTag",
                "",
                "System.Boolean",
                Query.DummyFieldWithAdminOnlyTag,
                Query.DummyFieldWithAdminOnlyTagFieldSpec,
                @""
            );
        }

        // Create new GraphQL Query:
        // edgeWindowsToolLink: EdgeWindowsToolLink!
        internal void InitQueryEdgeWindowsToolLink()
        {
            Tuple<string, string>[] argDefs = {
            };
            Initialize(
                argDefs,
                "query",
                "QueryEdgeWindowsToolLink",
                "",
                "EdgeWindowsToolLink",
                Query.EdgeWindowsToolLink,
                Query.EdgeWindowsToolLinkFieldSpec,
                @""
            );
        }

        // Create new GraphQL Query:
        // allEffectiveRbacPermissions(roleId: String!): [RbacPermission!]!
        internal void InitQueryAllEffectiveRbacPermissions()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("roleId", "String!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllEffectiveRbacPermissions",
                "($roleId: String!)",
                "List<RbacPermission>",
                Query.AllEffectiveRbacPermissions,
                Query.AllEffectiveRbacPermissionsFieldSpec,
                @"# REQUIRED
$query.Var.roleId = $someString"
            );
        }

        // Create new GraphQL Query:
        // allEventDigests(input: AllEventDigestsInput!): [EventDigest!]!
        internal void InitQueryAllEventDigests()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "AllEventDigestsInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllEventDigests",
                "($input: AllEventDigestsInput!)",
                "List<EventDigest>",
                Query.AllEventDigests,
                Query.AllEventDigestsFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	recipientUserIds = @(
		$someString
	)
}"
            );
        }

        // Create new GraphQL Query:
        // externalDeploymentName: String!
        internal void InitQueryExternalDeploymentName()
        {
            Tuple<string, string>[] argDefs = {
            };
            Initialize(
                argDefs,
                "query",
                "QueryExternalDeploymentName",
                "",
                "System.String",
                Query.ExternalDeploymentName,
                Query.ExternalDeploymentNameFieldSpec,
                @""
            );
        }

        // Create new GraphQL Query:
        // failedRestoreItemsInfo(workloadFid: UUID!, failedItemsInstanceId: String!): FailedRestoreItemsInfoReply!
        internal void InitQueryFailedRestoreItemsInfo()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("workloadFid", "UUID!"),
                Tuple.Create("failedItemsInstanceId", "String!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryFailedRestoreItemsInfo",
                "($workloadFid: UUID!,$failedItemsInstanceId: String!)",
                "FailedRestoreItemsInfoReply",
                Query.FailedRestoreItemsInfo,
                Query.FailedRestoreItemsInfoFieldSpec,
                @"# REQUIRED
$query.Var.workloadFid = $someString
# REQUIRED
$query.Var.failedItemsInstanceId = $someString"
            );
        }

        // Create new GraphQL Query:
        // federatedLoginStatus: FederatedLoginStatus!
        internal void InitQueryFederatedLoginStatus()
        {
            Tuple<string, string>[] argDefs = {
            };
            Initialize(
                argDefs,
                "query",
                "QueryFederatedLoginStatus",
                "",
                "FederatedLoginStatus",
                Query.FederatedLoginStatus,
                Query.FederatedLoginStatusFieldSpec,
                @""
            );
        }

        // Create new GraphQL Query:
        // allFileActivities(
        //     ListFileActivitiesInput: ListFileActivitiesInput!
        //     FileActivitiesSort: FileActivitiesSort!
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //   ): UserActivityResultConnection!
        internal void InitQueryAllFileActivities()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("ListFileActivitiesInput", "ListFileActivitiesInput!"),
                Tuple.Create("FileActivitiesSort", "FileActivitiesSort!"),
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllFileActivities",
                "($ListFileActivitiesInput: ListFileActivitiesInput!,$FileActivitiesSort: FileActivitiesSort!,$first: Int,$after: String,$last: Int,$before: String)",
                "UserActivityResultConnection",
                Query.AllFileActivities,
                Query.AllFileActivitiesFieldSpec,
                @"# REQUIRED
$query.Var.ListFileActivitiesInput = @{
	# REQUIRED
	snappableFid = $someString
	# REQUIRED
	stdPath = $someString
	# REQUIRED
	startDateTime = $someString
	# REQUIRED
	timezone = $someString
}
# REQUIRED
$query.Var.FileActivitiesSort = @{
	# OPTIONAL
	sortBy = $someFileActivitiesSortBy # Call [Enum]::GetValues([RubrikSecurityCloud.Types.FileActivitiesSortBy]) for enum values.
	# OPTIONAL
	sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
}
# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# OPTIONAL
$query.Var.last = $someInt
# OPTIONAL
$query.Var.before = $someString"
            );
        }

        // Create new GraphQL Query:
        // geoLocationList: [GroupCount!]!
        internal void InitQueryGeoLocationList()
        {
            Tuple<string, string>[] argDefs = {
            };
            Initialize(
                argDefs,
                "query",
                "QueryGeoLocationList",
                "",
                "List<GroupCount>",
                Query.GeoLocationList,
                Query.GeoLocationListFieldSpec,
                @""
            );
        }

        // Create new GraphQL Query:
        // getAllRolesInOrgConnection(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     sortOrder: SortOrder
        //     sortBy: RoleFieldEnum = Name
        //     nameFilter: String
        //     assignedRoleIds: [UUID!]
        //     roleSyncedFilter: Boolean
        //   ): RoleConnection!
        internal void InitQueryGetAllRolesInOrgConnection()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("sortBy", "RoleFieldEnum"),
                Tuple.Create("nameFilter", "String"),
                Tuple.Create("assignedRoleIds", "[UUID!]"),
                Tuple.Create("roleSyncedFilter", "Boolean"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryGetAllRolesInOrgConnection",
                "($first: Int,$after: String,$last: Int,$before: String,$sortOrder: SortOrder,$sortBy: RoleFieldEnum,$nameFilter: String,$assignedRoleIds: [UUID!],$roleSyncedFilter: Boolean)",
                "RoleConnection",
                Query.GetAllRolesInOrgConnection,
                Query.GetAllRolesInOrgConnectionFieldSpec,
                @"# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# OPTIONAL
$query.Var.last = $someInt
# OPTIONAL
$query.Var.before = $someString
# OPTIONAL
$query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$query.Var.sortBy = $someRoleFieldEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RoleFieldEnum]) for enum values.
# OPTIONAL
$query.Var.nameFilter = $someString
# OPTIONAL
$query.Var.assignedRoleIds = @(
	$someString
)
# OPTIONAL
$query.Var.roleSyncedFilter = $someBoolean"
            );
        }

        // Create new GraphQL Query:
        // getCdmReleaseDetailsForVersionFromSupportPortal(
        //     listClusterUuid: [UUID!]!
        //     filterVersion: String! = ""
        //     fetchLinks: Boolean! = false
        //     filterUpgradeable: Boolean! = true
        //     shouldShowAll: Boolean! = true
        //     filterAfterSource: Boolean! = false
        //     sortOrder: SortOrder
        //   ): CdmUpgradeReleaseDetailsFromSupportPortalReply!
        internal void InitQueryGetCdmReleaseDetailsForVersionFromSupportPortal()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("listClusterUuid", "[UUID!]!"),
                Tuple.Create("filterVersion", "String!"),
                Tuple.Create("fetchLinks", "Boolean!"),
                Tuple.Create("filterUpgradeable", "Boolean!"),
                Tuple.Create("shouldShowAll", "Boolean!"),
                Tuple.Create("filterAfterSource", "Boolean!"),
                Tuple.Create("sortOrder", "SortOrder"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryGetCdmReleaseDetailsForVersionFromSupportPortal",
                "($listClusterUuid: [UUID!]!,$filterVersion: String!,$fetchLinks: Boolean!,$filterUpgradeable: Boolean!,$shouldShowAll: Boolean!,$filterAfterSource: Boolean!,$sortOrder: SortOrder)",
                "CdmUpgradeReleaseDetailsFromSupportPortalReply",
                Query.GetCdmReleaseDetailsForVersionFromSupportPortal,
                Query.GetCdmReleaseDetailsForVersionFromSupportPortalFieldSpec,
                @"# REQUIRED
$query.Var.listClusterUuid = @(
	$someString
)
# REQUIRED
$query.Var.filterVersion = $someString
# REQUIRED
$query.Var.fetchLinks = $someBoolean
# REQUIRED
$query.Var.filterUpgradeable = $someBoolean
# REQUIRED
$query.Var.shouldShowAll = $someBoolean
# REQUIRED
$query.Var.filterAfterSource = $someBoolean
# OPTIONAL
$query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values."
            );
        }

        // Create new GraphQL Query:
        // getCdmReleaseDetailsFromSupportPortal(
        //     platform: String! = ""
        //     nodeCount: Long! = 4
        //     sourceVersion: String! = ""
        //     filterVersion: String! = ""
        //     fetchLinks: Boolean! = false
        //     filterUpgradeable: Boolean! = true
        //     shouldShowAll: Boolean! = true
        //     filterAfterSource: Boolean! = false
        //     sortOrder: SortOrder
        //   ): CdmUpgradeReleaseDetailsFromSupportPortalReply!
        internal void InitQueryGetCdmReleaseDetailsFromSupportPortal()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("platform", "String!"),
                Tuple.Create("nodeCount", "Long!"),
                Tuple.Create("sourceVersion", "String!"),
                Tuple.Create("filterVersion", "String!"),
                Tuple.Create("fetchLinks", "Boolean!"),
                Tuple.Create("filterUpgradeable", "Boolean!"),
                Tuple.Create("shouldShowAll", "Boolean!"),
                Tuple.Create("filterAfterSource", "Boolean!"),
                Tuple.Create("sortOrder", "SortOrder"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryGetCdmReleaseDetailsFromSupportPortal",
                "($platform: String!,$nodeCount: Long!,$sourceVersion: String!,$filterVersion: String!,$fetchLinks: Boolean!,$filterUpgradeable: Boolean!,$shouldShowAll: Boolean!,$filterAfterSource: Boolean!,$sortOrder: SortOrder)",
                "CdmUpgradeReleaseDetailsFromSupportPortalReply",
                Query.GetCdmReleaseDetailsFromSupportPortal,
                Query.GetCdmReleaseDetailsFromSupportPortalFieldSpec,
                @"# REQUIRED
$query.Var.platform = $someString
# REQUIRED
$query.Var.nodeCount = $someInt64
# REQUIRED
$query.Var.sourceVersion = $someString
# REQUIRED
$query.Var.filterVersion = $someString
# REQUIRED
$query.Var.fetchLinks = $someBoolean
# REQUIRED
$query.Var.filterUpgradeable = $someBoolean
# REQUIRED
$query.Var.shouldShowAll = $someBoolean
# REQUIRED
$query.Var.filterAfterSource = $someBoolean
# OPTIONAL
$query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values."
            );
        }

        // Create new GraphQL Query:
        // getGroupCountByPrechecksStatus: [GroupCount!]!
        internal void InitQueryGetGroupCountByPrechecksStatus()
        {
            Tuple<string, string>[] argDefs = {
            };
            Initialize(
                argDefs,
                "query",
                "QueryGetGroupCountByPrechecksStatus",
                "",
                "List<GroupCount>",
                Query.GetGroupCountByPrechecksStatus,
                Query.GetGroupCountByPrechecksStatusFieldSpec,
                @""
            );
        }

        // Create new GraphQL Query:
        // getGroupCountByUpgradeJobStatus: [GroupCount!]!
        internal void InitQueryGetGroupCountByUpgradeJobStatus()
        {
            Tuple<string, string>[] argDefs = {
            };
            Initialize(
                argDefs,
                "query",
                "QueryGetGroupCountByUpgradeJobStatus",
                "",
                "List<GroupCount>",
                Query.GetGroupCountByUpgradeJobStatus,
                Query.GetGroupCountByUpgradeJobStatusFieldSpec,
                @""
            );
        }

        // Create new GraphQL Query:
        // getGroupCountByVersionStatus: [GroupCount!]!
        internal void InitQueryGetGroupCountByVersionStatus()
        {
            Tuple<string, string>[] argDefs = {
            };
            Initialize(
                argDefs,
                "query",
                "QueryGetGroupCountByVersionStatus",
                "",
                "List<GroupCount>",
                Query.GetGroupCountByVersionStatus,
                Query.GetGroupCountByVersionStatusFieldSpec,
                @""
            );
        }

        // Create new GraphQL Query:
        // getKorgTaskchainStatus(taskchainId: String!): GetTaskchainStatusReply!
        internal void InitQueryGetKorgTaskchainStatus()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("taskchainId", "String!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryGetKorgTaskchainStatus",
                "($taskchainId: String!)",
                "GetTaskchainStatusReply",
                Query.GetKorgTaskchainStatus,
                Query.GetKorgTaskchainStatusFieldSpec,
                @"# REQUIRED
$query.Var.taskchainId = $someString"
            );
        }

        // Create new GraphQL Query:
        // getPermissions(roleId: String!): [Permission!]!
        internal void InitQueryGetPermissions()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("roleId", "String!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryGetPermissions",
                "($roleId: String!)",
                "List<Permission>",
                Query.GetPermissions,
                Query.GetPermissionsFieldSpec,
                @"# REQUIRED
$query.Var.roleId = $someString"
            );
        }

        // Create new GraphQL Query:
        // getRolesByIds(roleIds: [String!]!): [Role!]!
        internal void InitQueryGetRolesByIds()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("roleIds", "[String!]!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryGetRolesByIds",
                "($roleIds: [String!]!)",
                "List<Role>",
                Query.GetRolesByIds,
                Query.GetRolesByIdsFieldSpec,
                @"# REQUIRED
$query.Var.roleIds = @(
	$someString
)"
            );
        }

        // Create new GraphQL Query:
        // getUserDownloads(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //   ): [UserDownload!]!
        internal void InitQueryGetUserDownloads()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryGetUserDownloads",
                "($first: Int,$after: String,$last: Int,$before: String)",
                "List<UserDownload>",
                Query.GetUserDownloads,
                Query.GetUserDownloadsFieldSpec,
                @"# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# OPTIONAL
$query.Var.last = $someInt
# OPTIONAL
$query.Var.before = $someString"
            );
        }

        // Create new GraphQL Query:
        // globalFileSearch(input: GlobalFileSearchInput!): GlobalFileSearchReply!
        internal void InitQueryGlobalFileSearch()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GlobalFileSearchInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryGlobalFileSearch",
                "($input: GlobalFileSearchInput!)",
                "GlobalFileSearchReply",
                Query.GlobalFileSearch,
                Query.GlobalFileSearchFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	clusterUuid = $someString
	# REQUIRED
	query = @{
		# REQUIRED
		regex = $someString
		# REQUIRED
		snappableIds = @(
			$someString
		)
	}
}"
            );
        }

        // Create new GraphQL Query:
        // globalLockoutConfig: LockoutConfig!
        internal void InitQueryGlobalLockoutConfig()
        {
            Tuple<string, string>[] argDefs = {
            };
            Initialize(
                argDefs,
                "query",
                "QueryGlobalLockoutConfig",
                "",
                "LockoutConfig",
                Query.GlobalLockoutConfig,
                Query.GlobalLockoutConfigFieldSpec,
                @""
            );
        }

        // Create new GraphQL Query:
        // globalMfaSetting: GetMfaSettingReply!
        internal void InitQueryGlobalMfaSetting()
        {
            Tuple<string, string>[] argDefs = {
            };
            Initialize(
                argDefs,
                "query",
                "QueryGlobalMfaSetting",
                "",
                "GetMfaSettingReply",
                Query.GlobalMfaSetting,
                Query.GlobalMfaSettingFieldSpec,
                @""
            );
        }

        // Create new GraphQL Query:
        // globalSearchResults(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     sortBy: HierarchySortByField
        //     sortOrder: SortOrder
        //     filter: [Filter!]
        //   ): HierarchyObjectConnection!
        internal void InitQueryGlobalSearchResults()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("sortBy", "HierarchySortByField"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("filter", "[Filter!]"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryGlobalSearchResults",
                "($first: Int,$after: String,$last: Int,$before: String,$sortBy: HierarchySortByField,$sortOrder: SortOrder,$filter: [Filter!])",
                "HierarchyObjectConnection",
                Query.GlobalSearchResults,
                Query.GlobalSearchResultsFieldSpec,
                @"# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# OPTIONAL
$query.Var.last = $someInt
# OPTIONAL
$query.Var.before = $someString
# OPTIONAL
$query.Var.sortBy = $someHierarchySortByField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchySortByField]) for enum values.
# OPTIONAL
$query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$query.Var.filter = @(
	@{
		# OPTIONAL
		field = $someHierarchyFilterField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchyFilterField]) for enum values.
		# OPTIONAL
		texts = @(
			$someString
		)
		# OPTIONAL
		tagFilterParams = @(
			@{
				# OPTIONAL
				filterType = $someTagFilterType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TagFilterType]) for enum values.
				# OPTIONAL
				tagKey = $someString
				# OPTIONAL
				tagValue = $someString
			}
		)
		# OPTIONAL
		objectTypeFilterParams = @(
			$someManagedObjectType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ManagedObjectType]) for enum values.
		)
		# OPTIONAL
		awsNativeProtectionFeatureNames = @(
			$someAwsNativeProtectionFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		isNegative = $someBoolean
		# OPTIONAL
		isSlowSearchEnabled = $someBoolean
		# OPTIONAL
		azureNativeProtectionFeatureNames = @(
			$someAzureNativeProtectionFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		unmanagedObjectAvailabilityFilter = @(
			$someUnmanagedObjectAvailabilityFilter # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UnmanagedObjectAvailabilityFilter]) for enum values.
		)
}
)"
            );
        }

        // Create new GraphQL Query:
        // groupsInCurrentAndDescendantOrganization(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     filter: GroupFilterInput
        //     sortBy: GroupSortByParam
        //     shouldIncludeGroupsWithoutRole: Boolean = false
        //   ): GroupConnection!
        internal void InitQueryGroupsInCurrentAndDescendantOrganization()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("filter", "GroupFilterInput"),
                Tuple.Create("sortBy", "GroupSortByParam"),
                Tuple.Create("shouldIncludeGroupsWithoutRole", "Boolean"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryGroupsInCurrentAndDescendantOrganization",
                "($first: Int,$after: String,$last: Int,$before: String,$filter: GroupFilterInput,$sortBy: GroupSortByParam,$shouldIncludeGroupsWithoutRole: Boolean)",
                "GroupConnection",
                Query.GroupsInCurrentAndDescendantOrganization,
                Query.GroupsInCurrentAndDescendantOrganizationFieldSpec,
                @"# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# OPTIONAL
$query.Var.last = $someInt
# OPTIONAL
$query.Var.before = $someString
# OPTIONAL
$query.Var.filter = @{
	# OPTIONAL
	orgIdsFilter = @(
		$someString
	)
	# OPTIONAL
	roleIdsFilter = @(
		$someString
	)
	# OPTIONAL
	nameFilter = $someString
	# OPTIONAL
	authDomainIdsFilter = @(
		$someString
	)
}
# OPTIONAL
$query.Var.sortBy = @{
	# OPTIONAL
	field = $someGroupSortByField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.GroupSortByField]) for enum values.
	# OPTIONAL
	sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
}
# OPTIONAL
$query.Var.shouldIncludeGroupsWithoutRole = $someBoolean"
            );
        }

        // Create new GraphQL Query:
        // guestCredentials(input: QueryGuestCredentialInput!): GuestCredentialDetailListResponse!
        internal void InitQueryGuestCredentials()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "QueryGuestCredentialInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryGuestCredentials",
                "($input: QueryGuestCredentialInput!)",
                "GuestCredentialDetailListResponse",
                Query.GuestCredentials,
                Query.GuestCredentialsFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	clusterUuid = $someString
}"
            );
        }

        // Create new GraphQL Query:
        // guestCredentialsV2(
        //     first: Int
        //     after: String
        //     filter: [GuestOsCredentialFilterInput!]
        //     sortBy: GuestOsCredentialSortBy
        //   ): GuestOsCredentialConnection!
        internal void InitQueryGuestCredentialsV2()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("filter", "[GuestOsCredentialFilterInput!]"),
                Tuple.Create("sortBy", "GuestOsCredentialSortBy"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryGuestCredentialsV2",
                "($first: Int,$after: String,$filter: [GuestOsCredentialFilterInput!],$sortBy: GuestOsCredentialSortBy)",
                "GuestOsCredentialConnection",
                Query.GuestCredentialsV2,
                Query.GuestCredentialsV2FieldSpec,
                @"# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# OPTIONAL
$query.Var.filter = @(
	@{
		# OPTIONAL
		field = $someGuestOsCredentialFilterField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.GuestOsCredentialFilterField]) for enum values.
		# OPTIONAL
		texts = @(
			$someString
		)
}
)
# OPTIONAL
$query.Var.sortBy = @{
	# OPTIONAL
	field = $someGuestOsCredentialSortByField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.GuestOsCredentialSortByField]) for enum values.
	# OPTIONAL
	sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
}"
            );
        }

        // Create new GraphQL Query:
        // hasIdpConfigured: Boolean!
        internal void InitQueryHasIdpConfigured()
        {
            Tuple<string, string>[] argDefs = {
            };
            Initialize(
                argDefs,
                "query",
                "QueryHasIdpConfigured",
                "",
                "System.Boolean",
                Query.HasIdpConfigured,
                Query.HasIdpConfiguredFieldSpec,
                @""
            );
        }

        // Create new GraphQL Query:
        // helpContentSnippets(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     filter: HelpContentSnippetsFilterInput!
        //   ): HelpContentSnippetConnection!
        internal void InitQueryHelpContentSnippets()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("filter", "HelpContentSnippetsFilterInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryHelpContentSnippets",
                "($first: Int,$after: String,$last: Int,$before: String,$filter: HelpContentSnippetsFilterInput!)",
                "HelpContentSnippetConnection",
                Query.HelpContentSnippets,
                Query.HelpContentSnippetsFieldSpec,
                @"# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# OPTIONAL
$query.Var.last = $someInt
# OPTIONAL
$query.Var.before = $someString
# REQUIRED
$query.Var.filter = @{
	# OPTIONAL
	initiator = $someHelpContentSnippetsFilterInitiator # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HelpContentSnippetsFilterInitiator]) for enum values.
	# OPTIONAL
	query = $someString
	# OPTIONAL
	language = $someString
	# OPTIONAL
	source = $someHelpContentSource # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HelpContentSource]) for enum values.
	# OPTIONAL
	categories = @(
		$someString
	)
	# OPTIONAL
	url = $someString
	# REQUIRED
	productDocumentationTypes = @(
		$someProductDocumentationType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ProductDocumentationType]) for enum values.
	)
}"
            );
        }

        // Create new GraphQL Query:
        // hierarchyObject(fid: UUID!, workloadHierarchy: WorkloadLevelHierarchy): HierarchyObject!
        internal void InitQueryHierarchyObject()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
                Tuple.Create("workloadHierarchy", "WorkloadLevelHierarchy"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryHierarchyObject",
                "($fid: UUID!,$workloadHierarchy: WorkloadLevelHierarchy)",
                "HierarchyObject",
                Query.HierarchyObject,
                Query.HierarchyObjectFieldSpec,
                @"# REQUIRED
$query.Var.fid = $someString
# OPTIONAL
$query.Var.workloadHierarchy = $someWorkloadLevelHierarchy # Call [Enum]::GetValues([RubrikSecurityCloud.Types.WorkloadLevelHierarchy]) for enum values."
            );
        }

        // Create new GraphQL Query:
        // hierarchyObjects(fids: [UUID!]!, filter: [Filter!]): [HierarchyObject!]!
        internal void InitQueryHierarchyObjects()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fids", "[UUID!]!"),
                Tuple.Create("filter", "[Filter!]"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryHierarchyObjects",
                "($fids: [UUID!]!,$filter: [Filter!])",
                "List<HierarchyObject>",
                Query.HierarchyObjects,
                Query.HierarchyObjectsFieldSpec,
                @"# REQUIRED
$query.Var.fids = @(
	$someString
)
# OPTIONAL
$query.Var.filter = @(
	@{
		# OPTIONAL
		field = $someHierarchyFilterField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchyFilterField]) for enum values.
		# OPTIONAL
		texts = @(
			$someString
		)
		# OPTIONAL
		tagFilterParams = @(
			@{
				# OPTIONAL
				filterType = $someTagFilterType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TagFilterType]) for enum values.
				# OPTIONAL
				tagKey = $someString
				# OPTIONAL
				tagValue = $someString
			}
		)
		# OPTIONAL
		objectTypeFilterParams = @(
			$someManagedObjectType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ManagedObjectType]) for enum values.
		)
		# OPTIONAL
		awsNativeProtectionFeatureNames = @(
			$someAwsNativeProtectionFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		isNegative = $someBoolean
		# OPTIONAL
		isSlowSearchEnabled = $someBoolean
		# OPTIONAL
		azureNativeProtectionFeatureNames = @(
			$someAzureNativeProtectionFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		unmanagedObjectAvailabilityFilter = @(
			$someUnmanagedObjectAvailabilityFilter # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UnmanagedObjectAvailabilityFilter]) for enum values.
		)
}
)"
            );
        }

        // Create new GraphQL Query:
        // installedVersionList: [InstalledVersionGroupCount!]!
        internal void InitQueryInstalledVersionList()
        {
            Tuple<string, string>[] argDefs = {
            };
            Initialize(
                argDefs,
                "query",
                "QueryInstalledVersionList",
                "",
                "List<InstalledVersionGroupCount>",
                Query.InstalledVersionList,
                Query.InstalledVersionListFieldSpec,
                @""
            );
        }

        // Create new GraphQL Query:
        // inventoryRoot: InventoryRoot!
        internal void InitQueryInventoryRoot()
        {
            Tuple<string, string>[] argDefs = {
            };
            Initialize(
                argDefs,
                "query",
                "QueryInventoryRoot",
                "",
                "InventoryRoot",
                Query.InventoryRoot,
                Query.InventoryRootFieldSpec,
                @""
            );
        }

        // Create new GraphQL Query:
        // inventorySubHierarchyRoot(rootEnum: InventorySubHierarchyRootEnum!): InventorySubHierarchyRoot!
        internal void InitQueryInventorySubHierarchyRoot()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("rootEnum", "InventorySubHierarchyRootEnum!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryInventorySubHierarchyRoot",
                "($rootEnum: InventorySubHierarchyRootEnum!)",
                "InventorySubHierarchyRoot",
                Query.InventorySubHierarchyRoot,
                Query.InventorySubHierarchyRootFieldSpec,
                @"# REQUIRED
$query.Var.rootEnum = $someInventorySubHierarchyRootEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.InventorySubHierarchyRootEnum]) for enum values."
            );
        }

        // Create new GraphQL Query:
        // allInventoryWorkloads: [InventoryCard!]!
        internal void InitQueryAllInventoryWorkloads()
        {
            Tuple<string, string>[] argDefs = {
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllInventoryWorkloads",
                "",
                "List<InventoryCard>",
                Query.AllInventoryWorkloads,
                Query.AllInventoryWorkloadsFieldSpec,
                @""
            );
        }

        // Create new GraphQL Query:
        // investigationCsvDownloadLink(clusterUuid: UUID!, workloadId: String!, snapshotId: String!): InvestigationCsvDownloadLinkReply!
        internal void InitQueryInvestigationCsvDownloadLink()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("clusterUuid", "UUID!"),
                Tuple.Create("workloadId", "String!"),
                Tuple.Create("snapshotId", "String!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryInvestigationCsvDownloadLink",
                "($clusterUuid: UUID!,$workloadId: String!,$snapshotId: String!)",
                "InvestigationCsvDownloadLinkReply",
                Query.InvestigationCsvDownloadLink,
                Query.InvestigationCsvDownloadLinkFieldSpec,
                @"# REQUIRED
$query.Var.clusterUuid = $someString
# REQUIRED
$query.Var.workloadId = $someString
# REQUIRED
$query.Var.snapshotId = $someString"
            );
        }

        // Create new GraphQL Query:
        // ipWhitelist: GetWhitelistReply!
        internal void InitQueryIpWhitelist()
        {
            Tuple<string, string>[] argDefs = {
            };
            Initialize(
                argDefs,
                "query",
                "QueryIpWhitelist",
                "",
                "GetWhitelistReply",
                Query.IpWhitelist,
                Query.IpWhitelistFieldSpec,
                @""
            );
        }

        // Create new GraphQL Query:
        // isIpmiEnabled(input: IsIpmiEnabledInput!): Boolean!
        internal void InitQueryIsIpmiEnabled()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "IsIpmiEnabledInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryIsIpmiEnabled",
                "($input: IsIpmiEnabledInput!)",
                "System.Boolean",
                Query.IsIpmiEnabled,
                Query.IsIpmiEnabledFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someString
}"
            );
        }

        // Create new GraphQL Query:
        // isLoggedIntoRubrikSupportPortal: SupportPortalStatusReply!
        internal void InitQueryIsLoggedIntoRubrikSupportPortal()
        {
            Tuple<string, string>[] argDefs = {
            };
            Initialize(
                argDefs,
                "query",
                "QueryIsLoggedIntoRubrikSupportPortal",
                "",
                "SupportPortalStatusReply",
                Query.IsLoggedIntoRubrikSupportPortal,
                Query.IsLoggedIntoRubrikSupportPortalFieldSpec,
                @""
            );
        }

        // Create new GraphQL Query:
        // isReplaceNodeTprConfigured(clusterUuid: UUID!): Boolean!
        internal void InitQueryIsReplaceNodeTprConfigured()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("clusterUuid", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryIsReplaceNodeTprConfigured",
                "($clusterUuid: UUID!)",
                "System.Boolean",
                Query.IsReplaceNodeTprConfigured,
                Query.IsReplaceNodeTprConfiguredFieldSpec,
                @"# REQUIRED
$query.Var.clusterUuid = $someString"
            );
        }

        // Create new GraphQL Query:
        // isSfdcReachable(hostname: String! = "rubrik.force.com", organizationId: String! = "00D40000000N3x2"): Boolean!
        internal void InitQueryIsSfdcReachable()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("hostname", "String!"),
                Tuple.Create("organizationId", "String!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryIsSfdcReachable",
                "($hostname: String!,$organizationId: String!)",
                "System.Boolean",
                Query.IsSfdcReachable,
                Query.IsSfdcReachableFieldSpec,
                @"# REQUIRED
$query.Var.hostname = $someString
# REQUIRED
$query.Var.organizationId = $someString"
            );
        }

        // Create new GraphQL Query:
        // isUpgradeAvailable(clusterUuid: UUID!): CdmUpgradeAvailabilityReply!
        internal void InitQueryIsUpgradeAvailable()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("clusterUuid", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryIsUpgradeAvailable",
                "($clusterUuid: UUID!)",
                "CdmUpgradeAvailabilityReply",
                Query.IsUpgradeAvailable,
                Query.IsUpgradeAvailableFieldSpec,
                @"# REQUIRED
$query.Var.clusterUuid = $someString"
            );
        }

        // Create new GraphQL Query:
        // isUpgradeRecommended(clusterUuid: UUID!): CdmUpgradeRecommendationReply!
        internal void InitQueryIsUpgradeRecommended()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("clusterUuid", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryIsUpgradeRecommended",
                "($clusterUuid: UUID!)",
                "CdmUpgradeRecommendationReply",
                Query.IsUpgradeRecommended,
                Query.IsUpgradeRecommendedFieldSpec,
                @"# REQUIRED
$query.Var.clusterUuid = $someString"
            );
        }

        // Create new GraphQL Query:
        // isZrsAvailableForLocation(serviceTier: ServiceTier!, region: AzureNativeRegion!, subscriptionId: UUID!): ZrsAvailabilityReply!
        internal void InitQueryIsZrsAvailableForLocation()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("serviceTier", "ServiceTier!"),
                Tuple.Create("region", "AzureNativeRegion!"),
                Tuple.Create("subscriptionId", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryIsZrsAvailableForLocation",
                "($serviceTier: ServiceTier!,$region: AzureNativeRegion!,$subscriptionId: UUID!)",
                "ZrsAvailabilityReply",
                Query.IsZrsAvailableForLocation,
                Query.IsZrsAvailableForLocationFieldSpec,
                @"# REQUIRED
$query.Var.serviceTier = $someServiceTier # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ServiceTier]) for enum values.
# REQUIRED
$query.Var.region = $someAzureNativeRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeRegion]) for enum values.
# REQUIRED
$query.Var.subscriptionId = $someString"
            );
        }

        // Create new GraphQL Query:
        // issue(issueId: String!): Issue!
        internal void InitQueryIssue()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("issueId", "String!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryIssue",
                "($issueId: String!)",
                "Issue",
                Query.Issue,
                Query.IssueFieldSpec,
                @"# REQUIRED
$query.Var.issueId = $someString"
            );
        }

        // Create new GraphQL Query:
        // issues(
        //     status: IssueStatus!
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //   ): IssueConnection!
        internal void InitQueryIssues()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("status", "IssueStatus!"),
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryIssues",
                "($status: IssueStatus!,$first: Int,$after: String,$last: Int,$before: String)",
                "IssueConnection",
                Query.Issues,
                Query.IssuesFieldSpec,
                @"# REQUIRED
$query.Var.status = $someIssueStatus # Call [Enum]::GetValues([RubrikSecurityCloud.Types.IssueStatus]) for enum values.
# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# OPTIONAL
$query.Var.last = $someInt
# OPTIONAL
$query.Var.before = $someString"
            );
        }

        // Create new GraphQL Query:
        // allIssuesJobIds(queryIds: [String!]!): [String!]!
        internal void InitQueryAllIssuesJobIds()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("queryIds", "[String!]!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllIssuesJobIds",
                "($queryIds: [String!]!)",
                "List<System.String>",
                Query.AllIssuesJobIds,
                Query.AllIssuesJobIdsFieldSpec,
                @"# REQUIRED
$query.Var.queryIds = @(
	$someString
)"
            );
        }

        // Create new GraphQL Query:
        // jobInfo(input: JobInfoRequest!): JobInfo!
        internal void InitQueryJobInfo()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "JobInfoRequest!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryJobInfo",
                "($input: JobInfoRequest!)",
                "JobInfo",
                Query.JobInfo,
                Query.JobInfoFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	requestId = $someString
	# OPTIONAL
	clusterUuid = $someString
	# OPTIONAL
	type = $someJobType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.JobType]) for enum values.
	# REQUIRED
	additionalInfo = @{
		# OPTIONAL
		unmountInfo = @{
			# OPTIONAL
			liveMountFid = $someString
		}
		# OPTIONAL
		queryMountInfo = @{
			# OPTIONAL
			snapshotFid = $someString
		}
		# OPTIONAL
		sapHanaSystemInfo = @{
			# OPTIONAL
			sapHanaSystemFid = $someString
		}
		# OPTIONAL
		archivalLocationInfo = @{
			# OPTIONAL
			polarisManagedLocId = $someString
			# OPTIONAL
			locationName = $someString
			# OPTIONAL
			locationType = $someString
			# OPTIONAL
			operationType = $someArchivalLocationOperationType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ArchivalLocationOperationType]) for enum values.
			# OPTIONAL
			operationId = $someString
		}
		# OPTIONAL
		mosaicSourceInfo = @{
			# OPTIONAL
			sourceNames = @(
				$someString
			)
			# OPTIONAL
			refreshEffectiveSla = $someBoolean
			# OPTIONAL
			sourceType = $someMosaicSourceNosqlSourceType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.MosaicSourceNosqlSourceType]) for enum values.
		}
		# OPTIONAL
		snapshotFileDownloadInfo = @{
			# OPTIONAL
			downloadId = $someInt64
			# OPTIONAL
			snappableType = $someSnapshotFileDownloadSnappableType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SnapshotFileDownloadSnappableType]) for enum values.
		}
		# OPTIONAL
		mosaicStorageLocationInfo = @{
			# OPTIONAL
			storageLocationName = $someString
		}
		# OPTIONAL
		pendingSlaInfo = @{
			# OPTIONAL
			objectFids = @(
				$someString
			)
		}
		# OPTIONAL
		volumeGroupUnmountInfo = @{
			# OPTIONAL
			liveMountFid = $someString
		}
		# OPTIONAL
		db2InstanceInfo = @{
			# OPTIONAL
			db2InstanceFid = $someString
		}
		# OPTIONAL
		mssqlDbInfo = @{
			# OPTIONAL
			mssqlDbFid = $someString
		}
		# OPTIONAL
		logShippingInfo = @{
			# OPTIONAL
			secondaryDatabaseName = $someString
			# OPTIONAL
			databaseFid = $someString
		}
		# OPTIONAL
		addManagedVolumeInfo = @{
			# OPTIONAL
			managedVolumeFid = $someString
		}
		# OPTIONAL
		takeManagedVolumeOnDemandSnapshotInfo = @{
			# OPTIONAL
			managedVolumeFid = $someString
		}
		# OPTIONAL
		beginManagedVolumeSnapshotInfo = @{
			# OPTIONAL
			managedVolumeFid = $someString
		}
		# OPTIONAL
		endManagedVolumeSnapshotInfo = @{
			# OPTIONAL
			managedVolumeFid = $someString
		}
		# OPTIONAL
		resizeManagedVolumeInfo = @{
			# OPTIONAL
			managedVolumeFid = $someString
		}
		# OPTIONAL
		exportManagedVolumeSnapshotInfo = @{
			# OPTIONAL
			snapshotFid = $someString
			# OPTIONAL
			exportId = $someString
		}
		# OPTIONAL
		oracleExportInfo = @{
			# OPTIONAL
			isSameHostRestore = $someBoolean
			# OPTIONAL
			targetHostOrRacFid = $someString
			# OPTIONAL
			targetDbName = $someString
		}
		# OPTIONAL
		sapHanaDatabaseInfo = @{
			# OPTIONAL
			sapHanaDatabaseFid = $someString
			# OPTIONAL
			syncDbLogSnapshot = $someBoolean
		}
		# OPTIONAL
		liveMountRelocateInfo = @{
			# OPTIONAL
			liveMountFid = $someString
		}
		# OPTIONAL
		mongoSourceInfo = @{
			# OPTIONAL
			mongoSourceFid = $someString
		}
		# OPTIONAL
		hypervMountSnapshotInfo = @{
			# OPTIONAL
			snapshotFid = $someString
		}
		# OPTIONAL
		webCertificateInfo = @{
			# OPTIONAL
			cdmCertificateId = $someString
		}
		# OPTIONAL
		db2DatabaseInfo = @{
			# OPTIONAL
			db2DbFid = $someString
		}
		# OPTIONAL
		mongoCollectionsInfo = @{
			# OPTIONAL
			collectionFids = @(
				$someString
			)
		}
		# OPTIONAL
		vsphereFileRestoreInfo = @{
			# OPTIONAL
			vmFid = $someString
		}
		# OPTIONAL
		configureManagedVolumeLogExportInfo = @{
			# OPTIONAL
			managedVolumeFid = $someString
		}
		# OPTIONAL
		downloadSnapshotFromLocationInfo = @{
			# OPTIONAL
			snapshotId = $someString
			# OPTIONAL
			snappableType = $someDownloadSnapshotFromLocationSnappableType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DownloadSnapshotFromLocationSnappableType]) for enum values.
		}
		# OPTIONAL
		registeredHostInfo = @{
			# OPTIONAL
			hostFid = $someString
			# OPTIONAL
			hostRegisteredTime = $someDateTime
		}
		# OPTIONAL
		registerOracleHostsInfo = @{
			# OPTIONAL
			addedOracleHostFids = @(
				$someString
			)
			# OPTIONAL
			hostRegisteredTime = $someDateTime
		}
		# OPTIONAL
		llmInfo = @{
			# OPTIONAL
			functionType = $someLlmFunctionCallFunctionType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.LlmFunctionCallFunctionType]) for enum values.
			# OPTIONAL
			functionUuid = $someString
			# OPTIONAL
			subjectContexts = @(
				@{
					# OPTIONAL
					organizationId = $someString
					# OPTIONAL
					subjectId = $someString
					# OPTIONAL
					subjectType = $someSubjectContextType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SubjectContextType]) for enum values.
				}
			)
		}
		# OPTIONAL
		hostMakePrimaryInfo = @{
			# OPTIONAL
			hostFids = @(
				$someString
			)
		}
		# OPTIONAL
		vcenterDiagnosticRefreshInfo = @{
			# OPTIONAL
			vcenterFid = $someString
		}
		# OPTIONAL
		postgresDbClusterInfo = @{
			# OPTIONAL
			postgresDbClusterFid = $someString
		}
		# OPTIONAL
		hostsInfo = @{
			# OPTIONAL
			hostFids = @(
				$someString
			)
		}
		# OPTIONAL
		vsphereVmMakePrimaryInfo = @{
			# OPTIONAL
			vmFids = @(
				$someString
			)
		}
		# OPTIONAL
		mssqlAddHost = @{
			# OPTIONAL
			hostFid = $someString
			# OPTIONAL
			userId = $someString
		}
		# OPTIONAL
		kosmosRecoveryInfo = @{
			# OPTIONAL
			kosmosRecoveryFid = $someString
		}
		# OPTIONAL
		mssqlInstanceInfo = @{
			# OPTIONAL
			mssqlInstanceFid = $someString
		}
		# OPTIONAL
		mysqldbInstanceInfo = @{
			# OPTIONAL
			mysqldbInstanceFid = $someString
		}
	}
}"
            );
        }

        // Create new GraphQL Query:
        // knowledgeBaseArticle(id: String!): KnowledgeBaseArticle!
        internal void InitQueryKnowledgeBaseArticle()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("id", "String!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryKnowledgeBaseArticle",
                "($id: String!)",
                "KnowledgeBaseArticle",
                Query.KnowledgeBaseArticle,
                Query.KnowledgeBaseArticleFieldSpec,
                @"# REQUIRED
$query.Var.id = $someString"
            );
        }

        // Create new GraphQL Query:
        // lambdaSettings: LambdaSettings!
        internal void InitQueryLambdaSettings()
        {
            Tuple<string, string>[] argDefs = {
            };
            Initialize(
                argDefs,
                "query",
                "QueryLambdaSettings",
                "",
                "LambdaSettings",
                Query.LambdaSettings,
                Query.LambdaSettingsFieldSpec,
                @""
            );
        }

        // Create new GraphQL Query:
        // allLicensedProducts: GetLicensedProductsInfoReply!
        internal void InitQueryAllLicensedProducts()
        {
            Tuple<string, string>[] argDefs = {
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllLicensedProducts",
                "",
                "GetLicensedProductsInfoReply",
                Query.AllLicensedProducts,
                Query.AllLicensedProductsFieldSpec,
                @""
            );
        }

        // Create new GraphQL Query:
        // lockoutConfig: LockoutConfig!
        internal void InitQueryLockoutConfig()
        {
            Tuple<string, string>[] argDefs = {
            };
            Initialize(
                argDefs,
                "query",
                "QueryLockoutConfig",
                "",
                "LockoutConfig",
                Query.LockoutConfig,
                Query.LockoutConfigFieldSpec,
                @""
            );
        }

        // Create new GraphQL Query:
        // maxProtectedAppsCount: Int!
        internal void InitQueryMaxProtectedAppsCount()
        {
            Tuple<string, string>[] argDefs = {
            };
            Initialize(
                argDefs,
                "query",
                "QueryMaxProtectedAppsCount",
                "",
                "System.Int32",
                Query.MaxProtectedAppsCount,
                Query.MaxProtectedAppsCountFieldSpec,
                @""
            );
        }

        // Create new GraphQL Query:
        // mfaSetting: GetMfaSettingReply!
        internal void InitQueryMfaSetting()
        {
            Tuple<string, string>[] argDefs = {
            };
            Initialize(
                argDefs,
                "query",
                "QueryMfaSetting",
                "",
                "GetMfaSettingReply",
                Query.MfaSetting,
                Query.MfaSettingFieldSpec,
                @""
            );
        }

        // Create new GraphQL Query:
        // microsoftSites(
        //     first: Int
        //     after: String
        //     sortBy: HierarchySortByField
        //     sortOrder: SortOrder
        //     filter: [Filter!]
        //     o365OrgId: UUID!
        //     excludeChildSites: Boolean
        //     protectionType: ProtectionType!
        //   ): MicrosoftSiteConnection!
        internal void InitQueryMicrosoftSites()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("sortBy", "HierarchySortByField"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("filter", "[Filter!]"),
                Tuple.Create("o365OrgId", "UUID!"),
                Tuple.Create("excludeChildSites", "Boolean"),
                Tuple.Create("protectionType", "ProtectionType!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryMicrosoftSites",
                "($first: Int,$after: String,$sortBy: HierarchySortByField,$sortOrder: SortOrder,$filter: [Filter!],$o365OrgId: UUID!,$excludeChildSites: Boolean,$protectionType: ProtectionType!)",
                "MicrosoftSiteConnection",
                Query.MicrosoftSites,
                Query.MicrosoftSitesFieldSpec,
                @"# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# OPTIONAL
$query.Var.sortBy = $someHierarchySortByField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchySortByField]) for enum values.
# OPTIONAL
$query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$query.Var.filter = @(
	@{
		# OPTIONAL
		field = $someHierarchyFilterField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchyFilterField]) for enum values.
		# OPTIONAL
		texts = @(
			$someString
		)
		# OPTIONAL
		tagFilterParams = @(
			@{
				# OPTIONAL
				filterType = $someTagFilterType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TagFilterType]) for enum values.
				# OPTIONAL
				tagKey = $someString
				# OPTIONAL
				tagValue = $someString
			}
		)
		# OPTIONAL
		objectTypeFilterParams = @(
			$someManagedObjectType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ManagedObjectType]) for enum values.
		)
		# OPTIONAL
		awsNativeProtectionFeatureNames = @(
			$someAwsNativeProtectionFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		isNegative = $someBoolean
		# OPTIONAL
		isSlowSearchEnabled = $someBoolean
		# OPTIONAL
		azureNativeProtectionFeatureNames = @(
			$someAzureNativeProtectionFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		unmanagedObjectAvailabilityFilter = @(
			$someUnmanagedObjectAvailabilityFilter # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UnmanagedObjectAvailabilityFilter]) for enum values.
		)
}
)
# REQUIRED
$query.Var.o365OrgId = $someString
# OPTIONAL
$query.Var.excludeChildSites = $someBoolean
# REQUIRED
$query.Var.protectionType = $someProtectionType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ProtectionType]) for enum values."
            );
        }

        // Create new GraphQL Query:
        // minimumCdmVersionForFeatureSet(featureListMinimumCdmVersion: FeatureListMinimumCdmVersionInputType!): FeatureListMinimumCdmVersionReply!
        internal void InitQueryMinimumCdmVersionForFeatureSet()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("featureListMinimumCdmVersion", "FeatureListMinimumCdmVersionInputType!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryMinimumCdmVersionForFeatureSet",
                "($featureListMinimumCdmVersion: FeatureListMinimumCdmVersionInputType!)",
                "FeatureListMinimumCdmVersionReply",
                Query.MinimumCdmVersionForFeatureSet,
                Query.MinimumCdmVersionForFeatureSetFieldSpec,
                @"# REQUIRED
$query.Var.featureListMinimumCdmVersion = @{
	# REQUIRED
	featureTypes = @(
		$someCdmFeatureFlagType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CdmFeatureFlagType]) for enum values.
	)
}"
            );
        }

        // Create new GraphQL Query:
        // allMipLabels(onlyActiveFilter: Boolean, onlyAppliableFilter: Boolean, tenantIdFilter: String): [MicrosoftMipLabel!]!
        internal void InitQueryAllMipLabels()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("onlyActiveFilter", "Boolean"),
                Tuple.Create("onlyAppliableFilter", "Boolean"),
                Tuple.Create("tenantIdFilter", "String"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllMipLabels",
                "($onlyActiveFilter: Boolean,$onlyAppliableFilter: Boolean,$tenantIdFilter: String)",
                "List<MicrosoftMipLabel>",
                Query.AllMipLabels,
                Query.AllMipLabelsFieldSpec,
                @"# OPTIONAL
$query.Var.onlyActiveFilter = $someBoolean
# OPTIONAL
$query.Var.onlyAppliableFilter = $someBoolean
# OPTIONAL
$query.Var.tenantIdFilter = $someString"
            );
        }

        // Create new GraphQL Query:
        // networkThrottle(input: QueryNetworkThrottleInput!): NetworkThrottleSummaryListResponse!
        internal void InitQueryNetworkThrottle()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "QueryNetworkThrottleInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryNetworkThrottle",
                "($input: QueryNetworkThrottleInput!)",
                "NetworkThrottleSummaryListResponse",
                Query.NetworkThrottle,
                Query.NetworkThrottleFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	resourceId = $someInternalQueryNetworkThrottleRequestResourceId # Call [Enum]::GetValues([RubrikSecurityCloud.Types.InternalQueryNetworkThrottleRequestResourceId]) for enum values.
	# REQUIRED
	clusterUuid = $someString
}"
            );
        }

        // Create new GraphQL Query:
        // nfAnomalyResults(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     sortOrder: SortOrder
        //     sortBy: NfAnomalyResultSortBy
        //     filter: NfAnomalyResultFilterInput
        //     timezoneOffset: Float = 0.0
        //   ): NfAnomalyResultConnection!
        internal void InitQueryNfAnomalyResults()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("sortBy", "NfAnomalyResultSortBy"),
                Tuple.Create("filter", "NfAnomalyResultFilterInput"),
                Tuple.Create("timezoneOffset", "Float"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryNfAnomalyResults",
                "($first: Int,$after: String,$last: Int,$before: String,$sortOrder: SortOrder,$sortBy: NfAnomalyResultSortBy,$filter: NfAnomalyResultFilterInput,$timezoneOffset: Float)",
                "NfAnomalyResultConnection",
                Query.NfAnomalyResults,
                Query.NfAnomalyResultsFieldSpec,
                @"# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# OPTIONAL
$query.Var.last = $someInt
# OPTIONAL
$query.Var.before = $someString
# OPTIONAL
$query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$query.Var.sortBy = $someNfAnomalyResultSortBy # Call [Enum]::GetValues([RubrikSecurityCloud.Types.NfAnomalyResultSortBy]) for enum values.
# OPTIONAL
$query.Var.filter = @{
	# OPTIONAL
	clusterUuid = @(
		$someString
	)
	# OPTIONAL
	startTime = $someDateTime
	# OPTIONAL
	endTime = $someDateTime
	# OPTIONAL
	isAnomaly = $someBoolean
	# OPTIONAL
	workloadFid = @(
		$someString
	)
}
# OPTIONAL
$query.Var.timezoneOffset = $someSingle"
            );
        }

        // Create new GraphQL Query:
        // nfAnomalyResultsGrouped(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     groupBy: NfAnomalyResultGroupBy!
        //     filter: NfAnomalyResultFilterInput
        //     timezoneOffset: Float = 0.0
        //   ): NfAnomalyResultGroupedDataConnection!
        internal void InitQueryNfAnomalyResultsGrouped()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("groupBy", "NfAnomalyResultGroupBy!"),
                Tuple.Create("filter", "NfAnomalyResultFilterInput"),
                Tuple.Create("timezoneOffset", "Float"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryNfAnomalyResultsGrouped",
                "($first: Int,$after: String,$last: Int,$before: String,$groupBy: NfAnomalyResultGroupBy!,$filter: NfAnomalyResultFilterInput,$timezoneOffset: Float)",
                "NfAnomalyResultGroupedDataConnection",
                Query.NfAnomalyResultsGrouped,
                Query.NfAnomalyResultsGroupedFieldSpec,
                @"# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# OPTIONAL
$query.Var.last = $someInt
# OPTIONAL
$query.Var.before = $someString
# REQUIRED
$query.Var.groupBy = $someNfAnomalyResultGroupBy # Call [Enum]::GetValues([RubrikSecurityCloud.Types.NfAnomalyResultGroupBy]) for enum values.
# OPTIONAL
$query.Var.filter = @{
	# OPTIONAL
	clusterUuid = @(
		$someString
	)
	# OPTIONAL
	startTime = $someDateTime
	# OPTIONAL
	endTime = $someDateTime
	# OPTIONAL
	isAnomaly = $someBoolean
	# OPTIONAL
	workloadFid = @(
		$someString
	)
}
# OPTIONAL
$query.Var.timezoneOffset = $someSingle"
            );
        }

        // Create new GraphQL Query:
        // nodeRemovalCancelPermission(input: NodeRemovalCancelPermissionInput!): NodeRemovalCancelPermissionReply!
        internal void InitQueryNodeRemovalCancelPermission()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "NodeRemovalCancelPermissionInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryNodeRemovalCancelPermission",
                "($input: NodeRemovalCancelPermissionInput!)",
                "NodeRemovalCancelPermissionReply",
                Query.NodeRemovalCancelPermission,
                Query.NodeRemovalCancelPermissionFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	clusterUuid = $someString
}"
            );
        }

        // Create new GraphQL Query:
        // nodeToReplace(input: NodeToReplaceInput!): NodeToReplaceReply!
        internal void InitQueryNodeToReplace()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "NodeToReplaceInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryNodeToReplace",
                "($input: NodeToReplaceInput!)",
                "NodeToReplaceReply",
                Query.NodeToReplace,
                Query.NodeToReplaceFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	clusterUuid = $someString
}"
            );
        }

        // Create new GraphQL Query:
        // nodeTunnelStatuses(input: GetNodesInput!): NodeTunnelStatusConnection!
        internal void InitQueryNodeTunnelStatuses()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetNodesInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryNodeTunnelStatuses",
                "($input: GetNodesInput!)",
                "NodeTunnelStatusConnection",
                Query.NodeTunnelStatuses,
                Query.NodeTunnelStatusesFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	clusterUuid = $someString
}"
            );
        }

        // Create new GraphQL Query:
        // allNosqlStorageLocations(sortBy: MosaicStorageLocationQuerySortByField, sortOrder: SortOrder, filter: [MosaicStorageLocationFilterInput!]): [MosaicStorageLocation!]!
        internal void InitQueryAllNosqlStorageLocations()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("sortBy", "MosaicStorageLocationQuerySortByField"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("filter", "[MosaicStorageLocationFilterInput!]"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllNosqlStorageLocations",
                "($sortBy: MosaicStorageLocationQuerySortByField,$sortOrder: SortOrder,$filter: [MosaicStorageLocationFilterInput!])",
                "List<MosaicStorageLocation>",
                Query.AllNosqlStorageLocations,
                Query.AllNosqlStorageLocationsFieldSpec,
                @"# OPTIONAL
$query.Var.sortBy = $someMosaicStorageLocationQuerySortByField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.MosaicStorageLocationQuerySortByField]) for enum values.
# OPTIONAL
$query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$query.Var.filter = @(
	@{
		# OPTIONAL
		field = $someMosaicStorageLocationFilterField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.MosaicStorageLocationFilterField]) for enum values.
		# OPTIONAL
		text = $someString
}
)"
            );
        }

        // Create new GraphQL Query:
        // oauthCodesForEdgeReg(numberOfEdges: Int!, cdmOvaLink: String!): OauthCodesForEdgeRegReply!
        internal void InitQueryOauthCodesForEdgeReg()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("numberOfEdges", "Int!"),
                Tuple.Create("cdmOvaLink", "String!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryOauthCodesForEdgeReg",
                "($numberOfEdges: Int!,$cdmOvaLink: String!)",
                "OauthCodesForEdgeRegReply",
                Query.OauthCodesForEdgeReg,
                Query.OauthCodesForEdgeRegFieldSpec,
                @"# REQUIRED
$query.Var.numberOfEdges = $someInt
# REQUIRED
$query.Var.cdmOvaLink = $someString"
            );
        }

        // Create new GraphQL Query:
        // objectFiles(
        //     filter: ListObjectFilesFiltersInput
        //     sort: FileResultSortInput
        //     day: String!
        //     timezone: String!
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //   ): FileResultConnection!
        internal void InitQueryObjectFiles()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("filter", "ListObjectFilesFiltersInput"),
                Tuple.Create("sort", "FileResultSortInput"),
                Tuple.Create("day", "String!"),
                Tuple.Create("timezone", "String!"),
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryObjectFiles",
                "($filter: ListObjectFilesFiltersInput,$sort: FileResultSortInput,$day: String!,$timezone: String!,$first: Int,$after: String,$last: Int,$before: String)",
                "FileResultConnection",
                Query.ObjectFiles,
                Query.ObjectFilesFieldSpec,
                @"# OPTIONAL
$query.Var.filter = @{
	# OPTIONAL
	openAccessTypes = @(
		$someOpenAccessType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.OpenAccessType]) for enum values.
	)
	# OPTIONAL
	stalenessTypes = @(
		$someStalenessType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.StalenessType]) for enum values.
	)
	# OPTIONAL
	analyzerGroupIds = @(
		$someString
	)
	# OPTIONAL
	clusterIds = @(
		$someString
	)
	# OPTIONAL
	pathPrefix = $someString
	# OPTIONAL
	snappableTypes = @(
		$someString
	)
	# OPTIONAL
	searchText = $someString
	# OPTIONAL
	whitelistEnabled = $someBoolean
	# OPTIONAL
	fileCountTypes = @(
		$someFileCountType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.FileCountType]) for enum values.
	)
	# OPTIONAL
	accessTypes = @(
		$someAccessType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AccessType]) for enum values.
	)
	# OPTIONAL
	activityTypes = @(
		$someActivityAccessType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ActivityAccessType]) for enum values.
	)
	# OPTIONAL
	objectIds = @(
		$someString
	)
	# OPTIONAL
	inodeTypes = @(
		$someInodeType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.InodeType]) for enum values.
	)
	# REQUIRED
	objectTypes = @(
		$someHierarchyObjectTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchyObjectTypeEnum]) for enum values.
	)
}
# OPTIONAL
$query.Var.sort = @{
	# OPTIONAL
	sortBy = $someFileResultSortBy # Call [Enum]::GetValues([RubrikSecurityCloud.Types.FileResultSortBy]) for enum values.
	# OPTIONAL
	sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
	# OPTIONAL
	analyzerGroupId = $someString
	# OPTIONAL
	dataTypeId = $someString
}
# REQUIRED
$query.Var.day = $someString
# REQUIRED
$query.Var.timezone = $someString
# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# OPTIONAL
$query.Var.last = $someInt
# OPTIONAL
$query.Var.before = $someString"
            );
        }

        // Create new GraphQL Query:
        // objectTypeAccessSummary(
        //     timelineDate: String!
        //     historicalDeltaDays: Int! = 0
        //     includeWhitelistedResults: Boolean
        //     sortOrder: SortOrder
        //     filter: ObjectTypeSummariesFilter
        //     sort: ObjectTypeAccessSummarySortBy
        //     groupBy: ObjectTypeAccessSummaryGroupBy
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //   ): ObjectTypeAccessSummaryConnection!
        internal void InitQueryObjectTypeAccessSummary()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("timelineDate", "String!"),
                Tuple.Create("historicalDeltaDays", "Int!"),
                Tuple.Create("includeWhitelistedResults", "Boolean"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("filter", "ObjectTypeSummariesFilter"),
                Tuple.Create("sort", "ObjectTypeAccessSummarySortBy"),
                Tuple.Create("groupBy", "ObjectTypeAccessSummaryGroupBy"),
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryObjectTypeAccessSummary",
                "($timelineDate: String!,$historicalDeltaDays: Int!,$includeWhitelistedResults: Boolean,$sortOrder: SortOrder,$filter: ObjectTypeSummariesFilter,$sort: ObjectTypeAccessSummarySortBy,$groupBy: ObjectTypeAccessSummaryGroupBy,$first: Int,$after: String,$last: Int,$before: String)",
                "ObjectTypeAccessSummaryConnection",
                Query.ObjectTypeAccessSummary,
                Query.ObjectTypeAccessSummaryFieldSpec,
                @"# REQUIRED
$query.Var.timelineDate = $someString
# REQUIRED
$query.Var.historicalDeltaDays = $someInt
# OPTIONAL
$query.Var.includeWhitelistedResults = $someBoolean
# OPTIONAL
$query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$query.Var.filter = @{
	# OPTIONAL
	policyId = $someString
	# OPTIONAL
	objectTypes = @(
		$someDataGovObjectType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DataGovObjectType]) for enum values.
	)
	# OPTIONAL
	platformCategories = @(
		$somePlatformCategory # Call [Enum]::GetValues([RubrikSecurityCloud.Types.PlatformCategory]) for enum values.
	)
}
# OPTIONAL
$query.Var.sort = $someObjectTypeAccessSummarySortBy # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ObjectTypeAccessSummarySortBy]) for enum values.
# OPTIONAL
$query.Var.groupBy = $someObjectTypeAccessSummaryGroupBy # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ObjectTypeAccessSummaryGroupBy]) for enum values.
# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# OPTIONAL
$query.Var.last = $someInt
# OPTIONAL
$query.Var.before = $someString"
            );
        }

        // Create new GraphQL Query:
        // allObjectsAlreadyAssignedToOrgs(objectIdsForHierarchyTypes: [ObjectIdsForHierarchyTypeInput!]!, allowedClusters: [String!]!, targetOrgId: String): [ObjectIdsForHierarchyType!]!
        internal void InitQueryAllObjectsAlreadyAssignedToOrgs()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("objectIdsForHierarchyTypes", "[ObjectIdsForHierarchyTypeInput!]!"),
                Tuple.Create("allowedClusters", "[String!]!"),
                Tuple.Create("targetOrgId", "String"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllObjectsAlreadyAssignedToOrgs",
                "($objectIdsForHierarchyTypes: [ObjectIdsForHierarchyTypeInput!]!,$allowedClusters: [String!]!,$targetOrgId: String)",
                "List<ObjectIdsForHierarchyType>",
                Query.AllObjectsAlreadyAssignedToOrgs,
                Query.AllObjectsAlreadyAssignedToOrgsFieldSpec,
                @"# REQUIRED
$query.Var.objectIdsForHierarchyTypes = @(
	@{
		# REQUIRED
		objectIds = @(
			$someString
		)
		# REQUIRED
		snappableType = $someWorkloadLevelHierarchy # Call [Enum]::GetValues([RubrikSecurityCloud.Types.WorkloadLevelHierarchy]) for enum values.
}
)
# REQUIRED
$query.Var.allowedClusters = @(
	$someString
)
# OPTIONAL
$query.Var.targetOrgId = $someString"
            );
        }

        // Create new GraphQL Query:
        // org(orgId: String!): Org!
        internal void InitQueryOrg()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("orgId", "String!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryOrg",
                "($orgId: String!)",
                "Org",
                Query.Org,
                Query.OrgFieldSpec,
                @"# REQUIRED
$query.Var.orgId = $someString"
            );
        }

        // Create new GraphQL Query:
        // orgs(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     sortOrder: SortOrder
        //     sortBy: OrgField = NAME
        //     nameFilter: String
        //     mfaEnforcedFilter: Boolean
        //     crossAccountEnabledFilter: Boolean
        //   ): OrgConnection!
        internal void InitQueryOrgs()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("sortBy", "OrgField"),
                Tuple.Create("nameFilter", "String"),
                Tuple.Create("mfaEnforcedFilter", "Boolean"),
                Tuple.Create("crossAccountEnabledFilter", "Boolean"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryOrgs",
                "($first: Int,$after: String,$last: Int,$before: String,$sortOrder: SortOrder,$sortBy: OrgField,$nameFilter: String,$mfaEnforcedFilter: Boolean,$crossAccountEnabledFilter: Boolean)",
                "OrgConnection",
                Query.Orgs,
                Query.OrgsFieldSpec,
                @"# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# OPTIONAL
$query.Var.last = $someInt
# OPTIONAL
$query.Var.before = $someString
# OPTIONAL
$query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$query.Var.sortBy = $someOrgField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.OrgField]) for enum values.
# OPTIONAL
$query.Var.nameFilter = $someString
# OPTIONAL
$query.Var.mfaEnforcedFilter = $someBoolean
# OPTIONAL
$query.Var.crossAccountEnabledFilter = $someBoolean"
            );
        }

        // Create new GraphQL Query:
        // allOrgsByIds(orgIds: [String!]!): [Org!]!
        internal void InitQueryAllOrgsByIds()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("orgIds", "[String!]!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllOrgsByIds",
                "($orgIds: [String!]!)",
                "List<Org>",
                Query.AllOrgsByIds,
                Query.AllOrgsByIdsFieldSpec,
                @"# REQUIRED
$query.Var.orgIds = @(
	$someString
)"
            );
        }

        // Create new GraphQL Query:
        // orgsForPrincipal(orgSearchFilter: String): OrgsForPrincipalReply!
        internal void InitQueryOrgsForPrincipal()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("orgSearchFilter", "String"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryOrgsForPrincipal",
                "($orgSearchFilter: String)",
                "OrgsForPrincipalReply",
                Query.OrgsForPrincipal,
                Query.OrgsForPrincipalFieldSpec,
                @"# OPTIONAL
$query.Var.orgSearchFilter = $someString"
            );
        }

        // Create new GraphQL Query:
        // passkeyConfig: GetPasskeyConfigReply!
        internal void InitQueryPasskeyConfig()
        {
            Tuple<string, string>[] argDefs = {
            };
            Initialize(
                argDefs,
                "query",
                "QueryPasskeyConfig",
                "",
                "GetPasskeyConfigReply",
                Query.PasskeyConfig,
                Query.PasskeyConfigFieldSpec,
                @""
            );
        }

        // Create new GraphQL Query:
        // passkeyInfo: GetPasskeyInfoReply!
        internal void InitQueryPasskeyInfo()
        {
            Tuple<string, string>[] argDefs = {
            };
            Initialize(
                argDefs,
                "query",
                "QueryPasskeyInfo",
                "",
                "GetPasskeyInfoReply",
                Query.PasskeyInfo,
                Query.PasskeyInfoFieldSpec,
                @""
            );
        }

        // Create new GraphQL Query:
        // pendingAction(pendingActionId: String!): pendingAction!
        internal void InitQueryPendingAction()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("pendingActionId", "String!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryPendingAction",
                "($pendingActionId: String!)",
                "PendingAction",
                Query.PendingAction,
                Query.PendingActionFieldSpec,
                @"# REQUIRED
$query.Var.pendingActionId = $someString"
            );
        }

        // Create new GraphQL Query:
        // allPendingActions(
        //     clusterFilter: UUID
        //     pendingActionGroupTypeFilter: [PendingActionGroupTypeEnum!]
        //     pendingActionSubGroupTypeFilter: [PendingActionSubGroupTypeEnum!]
        //     statusFilter: [PendingActionStatus!]
        //     objectIds: [String!]
        //     sortedOrder: SortOrder
        //     historyOnly: Boolean
        //     limit: Long
        //   ): [pendingAction!]!
        internal void InitQueryAllPendingActions()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("clusterFilter", "UUID"),
                Tuple.Create("pendingActionGroupTypeFilter", "[PendingActionGroupTypeEnum!]"),
                Tuple.Create("pendingActionSubGroupTypeFilter", "[PendingActionSubGroupTypeEnum!]"),
                Tuple.Create("statusFilter", "[PendingActionStatus!]"),
                Tuple.Create("objectIds", "[String!]"),
                Tuple.Create("sortedOrder", "SortOrder"),
                Tuple.Create("historyOnly", "Boolean"),
                Tuple.Create("limit", "Long"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllPendingActions",
                "($clusterFilter: UUID,$pendingActionGroupTypeFilter: [PendingActionGroupTypeEnum!],$pendingActionSubGroupTypeFilter: [PendingActionSubGroupTypeEnum!],$statusFilter: [PendingActionStatus!],$objectIds: [String!],$sortedOrder: SortOrder,$historyOnly: Boolean,$limit: Long)",
                "List<PendingAction>",
                Query.AllPendingActions,
                Query.AllPendingActionsFieldSpec,
                @"# OPTIONAL
$query.Var.clusterFilter = $someString
# OPTIONAL
$query.Var.pendingActionGroupTypeFilter = @(
	$somePendingActionGroupTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.PendingActionGroupTypeEnum]) for enum values.
)
# OPTIONAL
$query.Var.pendingActionSubGroupTypeFilter = @(
	$somePendingActionSubGroupTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.PendingActionSubGroupTypeEnum]) for enum values.
)
# OPTIONAL
$query.Var.statusFilter = @(
	$somePendingActionStatus # Call [Enum]::GetValues([RubrikSecurityCloud.Types.PendingActionStatus]) for enum values.
)
# OPTIONAL
$query.Var.objectIds = @(
	$someString
)
# OPTIONAL
$query.Var.sortedOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$query.Var.historyOnly = $someBoolean
# OPTIONAL
$query.Var.limit = $someInt64"
            );
        }

        // Create new GraphQL Query:
        // phoenixRolloutProgress(orgId: UUID!): PhoenixRolloutProgress!
        internal void InitQueryPhoenixRolloutProgress()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("orgId", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryPhoenixRolloutProgress",
                "($orgId: UUID!)",
                "PhoenixRolloutProgress",
                Query.PhoenixRolloutProgress,
                Query.PhoenixRolloutProgressFieldSpec,
                @"# REQUIRED
$query.Var.orgId = $someString"
            );
        }

        // Create new GraphQL Query:
        // pipelineHealthForTimeRange(beginTime: DateTime!, endTime: DateTime): GetPipelineHealthReply!
        internal void InitQueryPipelineHealthForTimeRange()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("beginTime", "DateTime!"),
                Tuple.Create("endTime", "DateTime"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryPipelineHealthForTimeRange",
                "($beginTime: DateTime!,$endTime: DateTime)",
                "GetPipelineHealthReply",
                Query.PipelineHealthForTimeRange,
                Query.PipelineHealthForTimeRangeFieldSpec,
                @"# REQUIRED
$query.Var.beginTime = $someDateTime
# OPTIONAL
$query.Var.endTime = $someDateTime"
            );
        }

        // Create new GraphQL Query:
        // polarisInventorySubHierarchyRoot(rootEnum: InventorySubHierarchyRootEnum!): PolarisInventorySubHierarchyRoot!
        internal void InitQueryPolarisInventorySubHierarchyRoot()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("rootEnum", "InventorySubHierarchyRootEnum!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryPolarisInventorySubHierarchyRoot",
                "($rootEnum: InventorySubHierarchyRootEnum!)",
                "PolarisInventorySubHierarchyRoot",
                Query.PolarisInventorySubHierarchyRoot,
                Query.PolarisInventorySubHierarchyRootFieldSpec,
                @"# REQUIRED
$query.Var.rootEnum = $someInventorySubHierarchyRootEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.InventorySubHierarchyRootEnum]) for enum values."
            );
        }

        // Create new GraphQL Query:
        // policyDetails(dataCategoryIds: [String!], dataTypeIds: [String!], dataCategoryType: DataCategoryType): PolicyDetailConnection!
        internal void InitQueryPolicyDetails()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("dataCategoryIds", "[String!]"),
                Tuple.Create("dataTypeIds", "[String!]"),
                Tuple.Create("dataCategoryType", "DataCategoryType"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryPolicyDetails",
                "($dataCategoryIds: [String!],$dataTypeIds: [String!],$dataCategoryType: DataCategoryType)",
                "PolicyDetailConnection",
                Query.PolicyDetails,
                Query.PolicyDetailsFieldSpec,
                @"# OPTIONAL
$query.Var.dataCategoryIds = @(
	$someString
)
# OPTIONAL
$query.Var.dataTypeIds = @(
	$someString
)
# OPTIONAL
$query.Var.dataCategoryType = $someDataCategoryType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DataCategoryType]) for enum values."
            );
        }

        // Create new GraphQL Query:
        // policyObj(snappableFid: String!, snapshotFid: String!, includeWhitelistedResults: Boolean): PolicyObj!
        internal void InitQueryPolicyObj()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("snappableFid", "String!"),
                Tuple.Create("snapshotFid", "String!"),
                Tuple.Create("includeWhitelistedResults", "Boolean"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryPolicyObj",
                "($snappableFid: String!,$snapshotFid: String!,$includeWhitelistedResults: Boolean)",
                "PolicyObj",
                Query.PolicyObj,
                Query.PolicyObjFieldSpec,
                @"# REQUIRED
$query.Var.snappableFid = $someString
# REQUIRED
$query.Var.snapshotFid = $someString
# OPTIONAL
$query.Var.includeWhitelistedResults = $someBoolean"
            );
        }

        // Create new GraphQL Query:
        // policyObjs(
        //     day: String!
        //     timezone: String!
        //     workloadTypes: [DataGovObjectType!]! = []
        //     sortBy: String
        //     sortOrder: SortOrder
        //     analysisStatusesFilter: [AnalysisStatus!]
        //     policyIdsFilter: [String!]
        //     riskLevelsFilter: [RiskLevelType!]
        //     clusterIdsFilter: [String!]
        //     searchObjectName: String
        //     subscriptionIdsFilter: [String!]
        //     includeWhitelistedResults: Boolean
        //     sids: [String!]
        //     insightsMetadataId: String
        //     includeInsightsMarker: Boolean
        //     userAccessObjectsFilter: Boolean! = false
        //     objectIdsFilter: [String!]
        //     platformFilter: [Platform!]
        //     platformCategoryFilter: [PlatformCategory!]
        //     cloudAccountIdsFilter: [String!]
        //     resourceGroupsFilter: [String!]
        //     regionsFilter: [String!]
        //     dataTypeIdsFilter: [String!]
        //     firstSeenTimeRange: UserTimeRangeInput
        //     lastAccessTimeRange: UserTimeRangeInput
        //     creationTimeRange: UserTimeRangeInput
        //     lastScanTimeRange: UserTimeRangeInput
        //     objectTagsFilter: ObjectTagsFilterInput
        //     mipLabelsFilter: [MipLabelsFilterInput!]
        //     backupStatusFilter: [BackupStatus!]
        //     slaIdsFilter: [String!]
        //     networkAccessFilter: [NetworkAccess!]
        //     encryptionFilter: [Encryption!]
        //     loggingFilter: [Logging!]
        //     violationSeverityFilter: [ViolationSeverity!]
        //     exposureFilter: [OpenAccessType!]
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //   ): PolicyObjConnection!
        internal void InitQueryPolicyObjs()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("day", "String!"),
                Tuple.Create("timezone", "String!"),
                Tuple.Create("workloadTypes", "[DataGovObjectType!]!"),
                Tuple.Create("sortBy", "String"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("analysisStatusesFilter", "[AnalysisStatus!]"),
                Tuple.Create("policyIdsFilter", "[String!]"),
                Tuple.Create("riskLevelsFilter", "[RiskLevelType!]"),
                Tuple.Create("clusterIdsFilter", "[String!]"),
                Tuple.Create("searchObjectName", "String"),
                Tuple.Create("subscriptionIdsFilter", "[String!]"),
                Tuple.Create("includeWhitelistedResults", "Boolean"),
                Tuple.Create("sids", "[String!]"),
                Tuple.Create("insightsMetadataId", "String"),
                Tuple.Create("includeInsightsMarker", "Boolean"),
                Tuple.Create("userAccessObjectsFilter", "Boolean!"),
                Tuple.Create("objectIdsFilter", "[String!]"),
                Tuple.Create("platformFilter", "[Platform!]"),
                Tuple.Create("platformCategoryFilter", "[PlatformCategory!]"),
                Tuple.Create("cloudAccountIdsFilter", "[String!]"),
                Tuple.Create("resourceGroupsFilter", "[String!]"),
                Tuple.Create("regionsFilter", "[String!]"),
                Tuple.Create("dataTypeIdsFilter", "[String!]"),
                Tuple.Create("firstSeenTimeRange", "UserTimeRangeInput"),
                Tuple.Create("lastAccessTimeRange", "UserTimeRangeInput"),
                Tuple.Create("creationTimeRange", "UserTimeRangeInput"),
                Tuple.Create("lastScanTimeRange", "UserTimeRangeInput"),
                Tuple.Create("objectTagsFilter", "ObjectTagsFilterInput"),
                Tuple.Create("mipLabelsFilter", "[MipLabelsFilterInput!]"),
                Tuple.Create("backupStatusFilter", "[BackupStatus!]"),
                Tuple.Create("slaIdsFilter", "[String!]"),
                Tuple.Create("networkAccessFilter", "[NetworkAccess!]"),
                Tuple.Create("encryptionFilter", "[Encryption!]"),
                Tuple.Create("loggingFilter", "[Logging!]"),
                Tuple.Create("violationSeverityFilter", "[ViolationSeverity!]"),
                Tuple.Create("exposureFilter", "[OpenAccessType!]"),
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryPolicyObjs",
                "($day: String!,$timezone: String!,$workloadTypes: [DataGovObjectType!]!,$sortBy: String,$sortOrder: SortOrder,$analysisStatusesFilter: [AnalysisStatus!],$policyIdsFilter: [String!],$riskLevelsFilter: [RiskLevelType!],$clusterIdsFilter: [String!],$searchObjectName: String,$subscriptionIdsFilter: [String!],$includeWhitelistedResults: Boolean,$sids: [String!],$insightsMetadataId: String,$includeInsightsMarker: Boolean,$userAccessObjectsFilter: Boolean!,$objectIdsFilter: [String!],$platformFilter: [Platform!],$platformCategoryFilter: [PlatformCategory!],$cloudAccountIdsFilter: [String!],$resourceGroupsFilter: [String!],$regionsFilter: [String!],$dataTypeIdsFilter: [String!],$firstSeenTimeRange: UserTimeRangeInput,$lastAccessTimeRange: UserTimeRangeInput,$creationTimeRange: UserTimeRangeInput,$lastScanTimeRange: UserTimeRangeInput,$objectTagsFilter: ObjectTagsFilterInput,$mipLabelsFilter: [MipLabelsFilterInput!],$backupStatusFilter: [BackupStatus!],$slaIdsFilter: [String!],$networkAccessFilter: [NetworkAccess!],$encryptionFilter: [Encryption!],$loggingFilter: [Logging!],$violationSeverityFilter: [ViolationSeverity!],$exposureFilter: [OpenAccessType!],$first: Int,$after: String,$last: Int,$before: String)",
                "PolicyObjConnection",
                Query.PolicyObjs,
                Query.PolicyObjsFieldSpec,
                @"# REQUIRED
$query.Var.day = $someString
# REQUIRED
$query.Var.timezone = $someString
# REQUIRED
$query.Var.workloadTypes = @(
	$someDataGovObjectType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DataGovObjectType]) for enum values.
)
# OPTIONAL
$query.Var.sortBy = $someString
# OPTIONAL
$query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$query.Var.analysisStatusesFilter = @(
	$someAnalysisStatus # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AnalysisStatus]) for enum values.
)
# OPTIONAL
$query.Var.policyIdsFilter = @(
	$someString
)
# OPTIONAL
$query.Var.riskLevelsFilter = @(
	$someRiskLevelType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RiskLevelType]) for enum values.
)
# OPTIONAL
$query.Var.clusterIdsFilter = @(
	$someString
)
# OPTIONAL
$query.Var.searchObjectName = $someString
# OPTIONAL
$query.Var.subscriptionIdsFilter = @(
	$someString
)
# OPTIONAL
$query.Var.includeWhitelistedResults = $someBoolean
# OPTIONAL
$query.Var.sids = @(
	$someString
)
# OPTIONAL
$query.Var.insightsMetadataId = $someString
# OPTIONAL
$query.Var.includeInsightsMarker = $someBoolean
# REQUIRED
$query.Var.userAccessObjectsFilter = $someBoolean
# OPTIONAL
$query.Var.objectIdsFilter = @(
	$someString
)
# OPTIONAL
$query.Var.platformFilter = @(
	$somePlatform # Call [Enum]::GetValues([RubrikSecurityCloud.Types.Platform]) for enum values.
)
# OPTIONAL
$query.Var.platformCategoryFilter = @(
	$somePlatformCategory # Call [Enum]::GetValues([RubrikSecurityCloud.Types.PlatformCategory]) for enum values.
)
# OPTIONAL
$query.Var.cloudAccountIdsFilter = @(
	$someString
)
# OPTIONAL
$query.Var.resourceGroupsFilter = @(
	$someString
)
# OPTIONAL
$query.Var.regionsFilter = @(
	$someString
)
# OPTIONAL
$query.Var.dataTypeIdsFilter = @(
	$someString
)
# OPTIONAL
$query.Var.firstSeenTimeRange = @{
	# OPTIONAL
	startTime = $someString
	# OPTIONAL
	endTime = $someString
	# OPTIONAL
	timezone = $someString
}
# OPTIONAL
$query.Var.lastAccessTimeRange = @{
	# OPTIONAL
	startTime = $someString
	# OPTIONAL
	endTime = $someString
	# OPTIONAL
	timezone = $someString
}
# OPTIONAL
$query.Var.creationTimeRange = @{
	# OPTIONAL
	startTime = $someString
	# OPTIONAL
	endTime = $someString
	# OPTIONAL
	timezone = $someString
}
# OPTIONAL
$query.Var.lastScanTimeRange = @{
	# OPTIONAL
	startTime = $someString
	# OPTIONAL
	endTime = $someString
	# OPTIONAL
	timezone = $someString
}
# OPTIONAL
$query.Var.objectTagsFilter = @{
	# REQUIRED
	objectTags = @(
		@{
			# OPTIONAL
			key = $someString
			# OPTIONAL
			value = $someString
		}
	)
}
# OPTIONAL
$query.Var.mipLabelsFilter = @(
	@{
		# OPTIONAL
		siteId = $someString
		# OPTIONAL
		labelId = $someString
		# OPTIONAL
		labelName = $someString
}
)
# OPTIONAL
$query.Var.backupStatusFilter = @(
	$someBackupStatus # Call [Enum]::GetValues([RubrikSecurityCloud.Types.BackupStatus]) for enum values.
)
# OPTIONAL
$query.Var.slaIdsFilter = @(
	$someString
)
# OPTIONAL
$query.Var.networkAccessFilter = @(
	$someNetworkAccess # Call [Enum]::GetValues([RubrikSecurityCloud.Types.NetworkAccess]) for enum values.
)
# OPTIONAL
$query.Var.encryptionFilter = @(
	$someEncryption # Call [Enum]::GetValues([RubrikSecurityCloud.Types.Encryption]) for enum values.
)
# OPTIONAL
$query.Var.loggingFilter = @(
	$someLogging # Call [Enum]::GetValues([RubrikSecurityCloud.Types.Logging]) for enum values.
)
# OPTIONAL
$query.Var.violationSeverityFilter = @(
	$someViolationSeverity # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ViolationSeverity]) for enum values.
)
# OPTIONAL
$query.Var.exposureFilter = @(
	$someOpenAccessType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.OpenAccessType]) for enum values.
)
# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# OPTIONAL
$query.Var.last = $someInt
# OPTIONAL
$query.Var.before = $someString"
            );
        }

        // Create new GraphQL Query:
        // prechecksStatus(clusterUuid: UUID!): PrechecksStatusReply!
        internal void InitQueryPrechecksStatus()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("clusterUuid", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryPrechecksStatus",
                "($clusterUuid: UUID!)",
                "PrechecksStatusReply",
                Query.PrechecksStatus,
                Query.PrechecksStatusFieldSpec,
                @"# REQUIRED
$query.Var.clusterUuid = $someString"
            );
        }

        // Create new GraphQL Query:
        // prechecksStatusWithNextJobInfo(clusterUuid: UUID!): PrechecksStatusReply!
        internal void InitQueryPrechecksStatusWithNextJobInfo()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("clusterUuid", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryPrechecksStatusWithNextJobInfo",
                "($clusterUuid: UUID!)",
                "PrechecksStatusReply",
                Query.PrechecksStatusWithNextJobInfo,
                Query.PrechecksStatusWithNextJobInfoFieldSpec,
                @"# REQUIRED
$query.Var.clusterUuid = $someString"
            );
        }

        // Create new GraphQL Query:
        // privateContainerRegistry(input: PrivateContainerRegistryInput!): PrivateContainerRegistryReplyType!
        internal void InitQueryPrivateContainerRegistry()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "PrivateContainerRegistryInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryPrivateContainerRegistry",
                "($input: PrivateContainerRegistryInput!)",
                "PrivateContainerRegistryReplyType",
                Query.PrivateContainerRegistry,
                Query.PrivateContainerRegistryFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	exocomputeAccountId = $someString
}"
            );
        }

        // Create new GraphQL Query:
        // productDocumentation(id: String!): ProductDocumentation!
        internal void InitQueryProductDocumentation()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("id", "String!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryProductDocumentation",
                "($id: String!)",
                "ProductDocumentation",
                Query.ProductDocumentation,
                Query.ProductDocumentationFieldSpec,
                @"# REQUIRED
$query.Var.id = $someString"
            );
        }

        // Create new GraphQL Query:
        // protectedObjectsConnection(
        //     rootOptionalFid: UUID
        //     slaIds: [UUID!]!
        //     filter: [Filter!]
        //     objectTypeFilter: [String!]
        //     sortBy: HierarchySortByField
        //     sortOrder: SortOrder
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //   ): ProtectedObjectsConnection!
        internal void InitQueryProtectedObjectsConnection()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("rootOptionalFid", "UUID"),
                Tuple.Create("slaIds", "[UUID!]!"),
                Tuple.Create("filter", "[Filter!]"),
                Tuple.Create("objectTypeFilter", "[String!]"),
                Tuple.Create("sortBy", "HierarchySortByField"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryProtectedObjectsConnection",
                "($rootOptionalFid: UUID,$slaIds: [UUID!]!,$filter: [Filter!],$objectTypeFilter: [String!],$sortBy: HierarchySortByField,$sortOrder: SortOrder,$first: Int,$after: String,$last: Int,$before: String)",
                "ProtectedObjectsConnection",
                Query.ProtectedObjectsConnection,
                Query.ProtectedObjectsConnectionFieldSpec,
                @"# OPTIONAL
$query.Var.rootOptionalFid = $someString
# REQUIRED
$query.Var.slaIds = @(
	$someString
)
# OPTIONAL
$query.Var.filter = @(
	@{
		# OPTIONAL
		field = $someHierarchyFilterField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchyFilterField]) for enum values.
		# OPTIONAL
		texts = @(
			$someString
		)
		# OPTIONAL
		tagFilterParams = @(
			@{
				# OPTIONAL
				filterType = $someTagFilterType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TagFilterType]) for enum values.
				# OPTIONAL
				tagKey = $someString
				# OPTIONAL
				tagValue = $someString
			}
		)
		# OPTIONAL
		objectTypeFilterParams = @(
			$someManagedObjectType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ManagedObjectType]) for enum values.
		)
		# OPTIONAL
		awsNativeProtectionFeatureNames = @(
			$someAwsNativeProtectionFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		isNegative = $someBoolean
		# OPTIONAL
		isSlowSearchEnabled = $someBoolean
		# OPTIONAL
		azureNativeProtectionFeatureNames = @(
			$someAzureNativeProtectionFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		unmanagedObjectAvailabilityFilter = @(
			$someUnmanagedObjectAvailabilityFilter # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UnmanagedObjectAvailabilityFilter]) for enum values.
		)
}
)
# OPTIONAL
$query.Var.objectTypeFilter = @(
	$someString
)
# OPTIONAL
$query.Var.sortBy = $someHierarchySortByField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchySortByField]) for enum values.
# OPTIONAL
$query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# OPTIONAL
$query.Var.last = $someInt
# OPTIONAL
$query.Var.before = $someString"
            );
        }

        // Create new GraphQL Query:
        // protectedVolumesCount(filter: [Filter!]): Int!
        internal void InitQueryProtectedVolumesCount()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("filter", "[Filter!]"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryProtectedVolumesCount",
                "($filter: [Filter!])",
                "System.Int32",
                Query.ProtectedVolumesCount,
                Query.ProtectedVolumesCountFieldSpec,
                @"# OPTIONAL
$query.Var.filter = @(
	@{
		# OPTIONAL
		field = $someHierarchyFilterField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchyFilterField]) for enum values.
		# OPTIONAL
		texts = @(
			$someString
		)
		# OPTIONAL
		tagFilterParams = @(
			@{
				# OPTIONAL
				filterType = $someTagFilterType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TagFilterType]) for enum values.
				# OPTIONAL
				tagKey = $someString
				# OPTIONAL
				tagValue = $someString
			}
		)
		# OPTIONAL
		objectTypeFilterParams = @(
			$someManagedObjectType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ManagedObjectType]) for enum values.
		)
		# OPTIONAL
		awsNativeProtectionFeatureNames = @(
			$someAwsNativeProtectionFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		isNegative = $someBoolean
		# OPTIONAL
		isSlowSearchEnabled = $someBoolean
		# OPTIONAL
		azureNativeProtectionFeatureNames = @(
			$someAzureNativeProtectionFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		unmanagedObjectAvailabilityFilter = @(
			$someUnmanagedObjectAvailabilityFilter # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UnmanagedObjectAvailabilityFilter]) for enum values.
		)
}
)"
            );
        }

        // Create new GraphQL Query:
        // allQuarantinedDetailsForWorkload(workloadId: String!): [QuarantineSpec!]!
        internal void InitQueryAllQuarantinedDetailsForWorkload()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("workloadId", "String!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllQuarantinedDetailsForWorkload",
                "($workloadId: String!)",
                "List<QuarantineSpec>",
                Query.AllQuarantinedDetailsForWorkload,
                Query.AllQuarantinedDetailsForWorkloadFieldSpec,
                @"# REQUIRED
$query.Var.workloadId = $someString"
            );
        }

        // Create new GraphQL Query:
        // queryDatastoreFreespaceThresholds(queryDatastoreFreespaceThresholdsInput: [QueryDatastoreFreespaceThresholdInput!]!): QueryDatastoreFreespaceThresholdsReply!
        internal void InitQueryQueryDatastoreFreespaceThresholds()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("queryDatastoreFreespaceThresholdsInput", "[QueryDatastoreFreespaceThresholdInput!]!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryQueryDatastoreFreespaceThresholds",
                "($queryDatastoreFreespaceThresholdsInput: [QueryDatastoreFreespaceThresholdInput!]!)",
                "QueryDatastoreFreespaceThresholdsReply",
                Query.QueryDatastoreFreespaceThresholds,
                Query.QueryDatastoreFreespaceThresholdsFieldSpec,
                @"# REQUIRED
$query.Var.queryDatastoreFreespaceThresholdsInput = @(
	@{
		# REQUIRED
		clusterUuid = $someString
		# OPTIONAL
		vmId = $someString
}
)"
            );
        }

        // Create new GraphQL Query:
        // removedNodeDetails(input: RemovedNodeDetailsInput!): RemoveNodeDetailsReply!
        internal void InitQueryRemovedNodeDetails()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "RemovedNodeDetailsInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryRemovedNodeDetails",
                "($input: RemovedNodeDetailsInput!)",
                "RemoveNodeDetailsReply",
                Query.RemovedNodeDetails,
                Query.RemovedNodeDetailsFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	clusterUuid = $someString
	# REQUIRED
	nodeNames = @(
		$someString
	)
}"
            );
        }

        // Create new GraphQL Query:
        // roleTemplates(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     nameFilter: String
        //   ): RoleTemplateConnection!
        internal void InitQueryRoleTemplates()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("nameFilter", "String"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryRoleTemplates",
                "($first: Int,$after: String,$last: Int,$before: String,$nameFilter: String)",
                "RoleTemplateConnection",
                Query.RoleTemplates,
                Query.RoleTemplatesFieldSpec,
                @"# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# OPTIONAL
$query.Var.last = $someInt
# OPTIONAL
$query.Var.before = $someString
# OPTIONAL
$query.Var.nameFilter = $someString"
            );
        }

        // Create new GraphQL Query:
        // rscPermsToCdmInfo(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     permissions: [PermissionInput!]!
        //     roleId: String
        //   ): RscPermsToCdmInfoOut!
        internal void InitQueryRscPermsToCdmInfo()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("permissions", "[PermissionInput!]!"),
                Tuple.Create("roleId", "String"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryRscPermsToCdmInfo",
                "($first: Int,$after: String,$last: Int,$before: String,$permissions: [PermissionInput!]!,$roleId: String)",
                "RscPermsToCdmInfoOut",
                Query.RscPermsToCdmInfo,
                Query.RscPermsToCdmInfoFieldSpec,
                @"# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# OPTIONAL
$query.Var.last = $someInt
# OPTIONAL
$query.Var.before = $someString
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
# OPTIONAL
$query.Var.roleId = $someString"
            );
        }

        // Create new GraphQL Query:
        // searchFileByPrefix(
        //     clusterUuid: UUID!
        //     managedId: String!
        //     snapshotId: String!
        //     searchFolderPath: String!
        //     filenamePrefix: String!
        //   ): DiffResult!
        internal void InitQuerySearchFileByPrefix()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("clusterUuid", "UUID!"),
                Tuple.Create("managedId", "String!"),
                Tuple.Create("snapshotId", "String!"),
                Tuple.Create("searchFolderPath", "String!"),
                Tuple.Create("filenamePrefix", "String!"),
            };
            Initialize(
                argDefs,
                "query",
                "QuerySearchFileByPrefix",
                "($clusterUuid: UUID!,$managedId: String!,$snapshotId: String!,$searchFolderPath: String!,$filenamePrefix: String!)",
                "DiffResult",
                Query.SearchFileByPrefix,
                Query.SearchFileByPrefixFieldSpec,
                @"# REQUIRED
$query.Var.clusterUuid = $someString
# REQUIRED
$query.Var.managedId = $someString
# REQUIRED
$query.Var.snapshotId = $someString
# REQUIRED
$query.Var.searchFolderPath = $someString
# REQUIRED
$query.Var.filenamePrefix = $someString"
            );
        }

        // Create new GraphQL Query:
        // snoozedDirectories(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     snoozeStatusFilter: [SnoozeStatus!]
        //     directorySearchFilter: String
        //     falsePositiveTypeFilter: [AnomalyFalsePositiveType!]
        //   ): SnoozedDirectoryConnection!
        internal void InitQuerySnoozedDirectories()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("snoozeStatusFilter", "[SnoozeStatus!]"),
                Tuple.Create("directorySearchFilter", "String"),
                Tuple.Create("falsePositiveTypeFilter", "[AnomalyFalsePositiveType!]"),
            };
            Initialize(
                argDefs,
                "query",
                "QuerySnoozedDirectories",
                "($first: Int,$after: String,$last: Int,$before: String,$snoozeStatusFilter: [SnoozeStatus!],$directorySearchFilter: String,$falsePositiveTypeFilter: [AnomalyFalsePositiveType!])",
                "SnoozedDirectoryConnection",
                Query.SnoozedDirectories,
                Query.SnoozedDirectoriesFieldSpec,
                @"# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# OPTIONAL
$query.Var.last = $someInt
# OPTIONAL
$query.Var.before = $someString
# OPTIONAL
$query.Var.snoozeStatusFilter = @(
	$someSnoozeStatus # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SnoozeStatus]) for enum values.
)
# OPTIONAL
$query.Var.directorySearchFilter = $someString
# OPTIONAL
$query.Var.falsePositiveTypeFilter = @(
	$someAnomalyFalsePositiveType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AnomalyFalsePositiveType]) for enum values.
)"
            );
        }

        // Create new GraphQL Query:
        // ssoGroupAlreadyExists(ssoGroupName: String!, userDomainId: String): SsoGroupAlreadyExistsReply!
        internal void InitQuerySsoGroupAlreadyExists()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("ssoGroupName", "String!"),
                Tuple.Create("userDomainId", "String"),
            };
            Initialize(
                argDefs,
                "query",
                "QuerySsoGroupAlreadyExists",
                "($ssoGroupName: String!,$userDomainId: String)",
                "SsoGroupAlreadyExistsReply",
                Query.SsoGroupAlreadyExists,
                Query.SsoGroupAlreadyExistsFieldSpec,
                @"# REQUIRED
$query.Var.ssoGroupName = $someString
# OPTIONAL
$query.Var.userDomainId = $someString"
            );
        }

        // Create new GraphQL Query:
        // supportBundle(input: QuerySupportBundleInput!): AsyncRequestStatus!
        internal void InitQuerySupportBundle()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "QuerySupportBundleInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QuerySupportBundle",
                "($input: QuerySupportBundleInput!)",
                "AsyncRequestStatus",
                Query.SupportBundle,
                Query.SupportBundleFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	clusterUuid = $someString
	# REQUIRED
	id = $someString
}"
            );
        }

        // Create new GraphQL Query:
        // supportUserAccesses(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     sortBy: SupportUserAccessSortByField
        //     sortOrder: SortOrder
        //     filters: [SupportUserAccessFilterInput!]
        //   ): SupportUserAccessConnection!
        internal void InitQuerySupportUserAccesses()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("sortBy", "SupportUserAccessSortByField"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("filters", "[SupportUserAccessFilterInput!]"),
            };
            Initialize(
                argDefs,
                "query",
                "QuerySupportUserAccesses",
                "($first: Int,$after: String,$last: Int,$before: String,$sortBy: SupportUserAccessSortByField,$sortOrder: SortOrder,$filters: [SupportUserAccessFilterInput!])",
                "SupportUserAccessConnection",
                Query.SupportUserAccesses,
                Query.SupportUserAccessesFieldSpec,
                @"# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# OPTIONAL
$query.Var.last = $someInt
# OPTIONAL
$query.Var.before = $someString
# OPTIONAL
$query.Var.sortBy = $someSupportUserAccessSortByField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SupportUserAccessSortByField]) for enum values.
# OPTIONAL
$query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$query.Var.filters = @(
	@{
		# OPTIONAL
		text = $someString
		# REQUIRED
		field = $someSupportUserAccessFilterField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SupportUserAccessFilterField]) for enum values.
}
)"
            );
        }

        // Create new GraphQL Query:
        // tableFilters: TableFilters!
        internal void InitQueryTableFilters()
        {
            Tuple<string, string>[] argDefs = {
            };
            Initialize(
                argDefs,
                "query",
                "QueryTableFilters",
                "",
                "TableFilters",
                Query.TableFilters,
                Query.TableFiltersFieldSpec,
                @""
            );
        }

        // Create new GraphQL Query:
        // allTargets(
        //     sortBy: ArchivalLocationQuerySortByField
        //     sortOrder: SortOrder
        //     filter: [TargetFilterInput!]
        //     contextFilter: ContextFilterTypeEnum
        //   ): [Target!]!
        internal void InitQueryAllTargets()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("sortBy", "ArchivalLocationQuerySortByField"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("filter", "[TargetFilterInput!]"),
                Tuple.Create("contextFilter", "ContextFilterTypeEnum"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllTargets",
                "($sortBy: ArchivalLocationQuerySortByField,$sortOrder: SortOrder,$filter: [TargetFilterInput!],$contextFilter: ContextFilterTypeEnum)",
                "List<Target>",
                Query.AllTargets,
                Query.AllTargetsFieldSpec,
                @"# OPTIONAL
$query.Var.sortBy = $someArchivalLocationQuerySortByField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ArchivalLocationQuerySortByField]) for enum values.
# OPTIONAL
$query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$query.Var.filter = @(
	@{
		# OPTIONAL
		field = $someTargetQueryFilterField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TargetQueryFilterField]) for enum values.
		# OPTIONAL
		text = $someString
		# OPTIONAL
		textList = @(
			$someString
		)
}
)
# OPTIONAL
$query.Var.contextFilter = $someContextFilterTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ContextFilterTypeEnum]) for enum values."
            );
        }

        // Create new GraphQL Query:
        // taskDetailGroupByConnection(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     filter: TaskDetailFilterInput
        //     groupBy: TaskDetailGroupByEnum!
        //     timezoneOffset: Float = 0.0
        //   ): TaskDetailGroupByConnection!
        internal void InitQueryTaskDetailGroupByConnection()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("filter", "TaskDetailFilterInput"),
                Tuple.Create("groupBy", "TaskDetailGroupByEnum!"),
                Tuple.Create("timezoneOffset", "Float"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryTaskDetailGroupByConnection",
                "($first: Int,$after: String,$last: Int,$before: String,$filter: TaskDetailFilterInput,$groupBy: TaskDetailGroupByEnum!,$timezoneOffset: Float)",
                "TaskDetailGroupByConnection",
                Query.TaskDetailGroupByConnection,
                Query.TaskDetailGroupByConnectionFieldSpec,
                @"# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# OPTIONAL
$query.Var.last = $someInt
# OPTIONAL
$query.Var.before = $someString
# OPTIONAL
$query.Var.filter = @{
	# OPTIONAL
	clusterUuid = @(
		$someString
	)
	# OPTIONAL
	clusterType = @(
		$someString
	)
	# OPTIONAL
	clusterLocation = @(
		$someString
	)
	# OPTIONAL
	objectType = @(
		$someString
	)
	# OPTIONAL
	slaDomain = @{
		# OPTIONAL
		id = @(
			$someString
		)
	}
	# OPTIONAL
	replicationSource = @(
		$someString
	)
	# OPTIONAL
	taskCategory = @(
		$someString
	)
	# OPTIONAL
	taskStatus = @(
		$someString
	)
	# OPTIONAL
	taskType = @(
		$someString
	)
	# OPTIONAL
	time_gt = $someDateTime
	# OPTIONAL
	time_lt = $someDateTime
	# OPTIONAL
	searchTerm = $someString
	# OPTIONAL
	orgId = @(
		$someString
	)
}
# REQUIRED
$query.Var.groupBy = $someTaskDetailGroupByEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TaskDetailGroupByEnum]) for enum values.
# OPTIONAL
$query.Var.timezoneOffset = $someSingle"
            );
        }

        // Create new GraphQL Query:
        // taskDetailConnection(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     filter: TaskDetailFilterInput
        //     sortBy: TaskDetailSortByEnum = EndTime
        //     sortOrder: SortOrder = DESC
        //     timezoneOffset: Float = 0.0
        //     timezone: Timezone
        //   ): TaskDetailConnection!
        internal void InitQueryTaskDetailConnection()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("filter", "TaskDetailFilterInput"),
                Tuple.Create("sortBy", "TaskDetailSortByEnum"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("timezoneOffset", "Float"),
                Tuple.Create("timezone", "Timezone"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryTaskDetailConnection",
                "($first: Int,$after: String,$last: Int,$before: String,$filter: TaskDetailFilterInput,$sortBy: TaskDetailSortByEnum,$sortOrder: SortOrder,$timezoneOffset: Float,$timezone: Timezone)",
                "TaskDetailConnection",
                Query.TaskDetailConnection,
                Query.TaskDetailConnectionFieldSpec,
                @"# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# OPTIONAL
$query.Var.last = $someInt
# OPTIONAL
$query.Var.before = $someString
# OPTIONAL
$query.Var.filter = @{
	# OPTIONAL
	clusterUuid = @(
		$someString
	)
	# OPTIONAL
	clusterType = @(
		$someString
	)
	# OPTIONAL
	clusterLocation = @(
		$someString
	)
	# OPTIONAL
	objectType = @(
		$someString
	)
	# OPTIONAL
	slaDomain = @{
		# OPTIONAL
		id = @(
			$someString
		)
	}
	# OPTIONAL
	replicationSource = @(
		$someString
	)
	# OPTIONAL
	taskCategory = @(
		$someString
	)
	# OPTIONAL
	taskStatus = @(
		$someString
	)
	# OPTIONAL
	taskType = @(
		$someString
	)
	# OPTIONAL
	time_gt = $someDateTime
	# OPTIONAL
	time_lt = $someDateTime
	# OPTIONAL
	searchTerm = $someString
	# OPTIONAL
	orgId = @(
		$someString
	)
}
# OPTIONAL
$query.Var.sortBy = $someTaskDetailSortByEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TaskDetailSortByEnum]) for enum values.
# OPTIONAL
$query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$query.Var.timezoneOffset = $someSingle
# OPTIONAL
$query.Var.timezone = $someTimezone"
            );
        }

        // Create new GraphQL Query:
        // taskchain(taskchainId: String!): Taskchain!
        internal void InitQueryTaskchain()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("taskchainId", "String!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryTaskchain",
                "($taskchainId: String!)",
                "Taskchain",
                Query.Taskchain,
                Query.TaskchainFieldSpec,
                @"# REQUIRED
$query.Var.taskchainId = $someString"
            );
        }

        // Create new GraphQL Query:
        // teamChannelNameAvailable(teamUUID: UUID!, channelName: String!): Boolean!
        internal void InitQueryTeamChannelNameAvailable()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("teamUUID", "UUID!"),
                Tuple.Create("channelName", "String!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryTeamChannelNameAvailable",
                "($teamUUID: UUID!,$channelName: String!)",
                "System.Boolean",
                Query.TeamChannelNameAvailable,
                Query.TeamChannelNameAvailableFieldSpec,
                @"# REQUIRED
$query.Var.teamUUID = $someString
# REQUIRED
$query.Var.channelName = $someString"
            );
        }

        // Create new GraphQL Query:
        // totpConfigStatus(userId: String!): GetTotpStatusReply!
        internal void InitQueryTotpConfigStatus()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("userId", "String!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryTotpConfigStatus",
                "($userId: String!)",
                "GetTotpStatusReply",
                Query.TotpConfigStatus,
                Query.TotpConfigStatusFieldSpec,
                @"# REQUIRED
$query.Var.userId = $someString"
            );
        }

        // Create new GraphQL Query:
        // tprConfiguration(orgId: String!): TprConfiguration!
        internal void InitQueryTprConfiguration()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("orgId", "String!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryTprConfiguration",
                "($orgId: String!)",
                "TprConfiguration",
                Query.TprConfiguration,
                Query.TprConfigurationFieldSpec,
                @"# REQUIRED
$query.Var.orgId = $someString"
            );
        }

        // Create new GraphQL Query:
        // tprPublicConfiguration(orgId: String!): TprPublicConfiguration!
        internal void InitQueryTprPublicConfiguration()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("orgId", "String!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryTprPublicConfiguration",
                "($orgId: String!)",
                "TprPublicConfiguration",
                Query.TprPublicConfiguration,
                Query.TprPublicConfigurationFieldSpec,
                @"# REQUIRED
$query.Var.orgId = $someString"
            );
        }

        // Create new GraphQL Query:
        // tprRequestDetail(tprRequestId: String!): TprRequestDetailReply!
        internal void InitQueryTprRequestDetail()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("tprRequestId", "String!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryTprRequestDetail",
                "($tprRequestId: String!)",
                "TprRequestDetailReply",
                Query.TprRequestDetail,
                Query.TprRequestDetailFieldSpec,
                @"# REQUIRED
$query.Var.tprRequestId = $someString"
            );
        }

        // Create new GraphQL Query:
        // tprRequestSummaries(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     filter: TprRequestFilterInput
        //   ): TprRequestSummaryConnection!
        internal void InitQueryTprRequestSummaries()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("filter", "TprRequestFilterInput"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryTprRequestSummaries",
                "($first: Int,$after: String,$last: Int,$before: String,$filter: TprRequestFilterInput)",
                "TprRequestSummaryConnection",
                Query.TprRequestSummaries,
                Query.TprRequestSummariesFieldSpec,
                @"# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# OPTIONAL
$query.Var.last = $someInt
# OPTIONAL
$query.Var.before = $someString
# OPTIONAL
$query.Var.filter = @{
	# OPTIONAL
	timeGt = $someDateTime
	# OPTIONAL
	timeLt = $someDateTime
	# OPTIONAL
	statuses = @(
		$someTprReqStatus # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TprReqStatus]) for enum values.
	)
	# OPTIONAL
	orgs = @(
		$someString
	)
	# OPTIONAL
	submittedBy = $someTprSubmittedByUser # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TprSubmittedByUser]) for enum values.
}"
            );
        }

        // Create new GraphQL Query:
        // tprRoleEligibility(orgId: String!, email: String!): TprRoleEligibilityType!
        internal void InitQueryTprRoleEligibility()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("orgId", "String!"),
                Tuple.Create("email", "String!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryTprRoleEligibility",
                "($orgId: String!,$email: String!)",
                "TprRoleEligibilityType",
                Query.TprRoleEligibility,
                Query.TprRoleEligibilityFieldSpec,
                @"# REQUIRED
$query.Var.orgId = $someString
# REQUIRED
$query.Var.email = $someString"
            );
        }

        // Create new GraphQL Query:
        // tprRulesMap: TprRulesMap!
        internal void InitQueryTprRulesMap()
        {
            Tuple<string, string>[] argDefs = {
            };
            Initialize(
                argDefs,
                "query",
                "QueryTprRulesMap",
                "",
                "TprRulesMap",
                Query.TprRulesMap,
                Query.TprRulesMapFieldSpec,
                @""
            );
        }

        // Create new GraphQL Query:
        // tprStatusForNodeRemoval(input: TprStatusForNodeRemovalInput!): TprStatusForNodeRemoval!
        internal void InitQueryTprStatusForNodeRemoval()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "TprStatusForNodeRemovalInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryTprStatusForNodeRemoval",
                "($input: TprStatusForNodeRemovalInput!)",
                "TprStatusForNodeRemoval",
                Query.TprStatusForNodeRemoval,
                Query.TprStatusForNodeRemovalFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	clusterUuid = $someString
	# REQUIRED
	tprRequestId = $someString
}"
            );
        }

        // Create new GraphQL Query:
        // tunnelStatus(input: GetTunnelStatusInput!): SupportTunnelInfo!
        internal void InitQueryTunnelStatus()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetTunnelStatusInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryTunnelStatus",
                "($input: GetTunnelStatusInput!)",
                "SupportTunnelInfo",
                Query.TunnelStatus,
                Query.TunnelStatusFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	clusterUuid = $someString
	# REQUIRED
	id = $someString
}"
            );
        }

        // Create new GraphQL Query:
        // uniqueVcdCount(filter: [Filter!] = []): Int!
        internal void InitQueryUniqueVcdCount()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("filter", "[Filter!]"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryUniqueVcdCount",
                "($filter: [Filter!])",
                "System.Int32",
                Query.UniqueVcdCount,
                Query.UniqueVcdCountFieldSpec,
                @"# OPTIONAL
$query.Var.filter = @(
	@{
		# OPTIONAL
		field = $someHierarchyFilterField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchyFilterField]) for enum values.
		# OPTIONAL
		texts = @(
			$someString
		)
		# OPTIONAL
		tagFilterParams = @(
			@{
				# OPTIONAL
				filterType = $someTagFilterType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TagFilterType]) for enum values.
				# OPTIONAL
				tagKey = $someString
				# OPTIONAL
				tagValue = $someString
			}
		)
		# OPTIONAL
		objectTypeFilterParams = @(
			$someManagedObjectType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ManagedObjectType]) for enum values.
		)
		# OPTIONAL
		awsNativeProtectionFeatureNames = @(
			$someAwsNativeProtectionFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		isNegative = $someBoolean
		# OPTIONAL
		isSlowSearchEnabled = $someBoolean
		# OPTIONAL
		azureNativeProtectionFeatureNames = @(
			$someAzureNativeProtectionFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		unmanagedObjectAvailabilityFilter = @(
			$someUnmanagedObjectAvailabilityFilter # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UnmanagedObjectAvailabilityFilter]) for enum values.
		)
}
)"
            );
        }

        // Create new GraphQL Query:
        // unmanagedObjects(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     input: UnmanagedObjectsInput!
        //   ): UnmanagedObjectDetailConnection!
        internal void InitQueryUnmanagedObjects()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("input", "UnmanagedObjectsInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryUnmanagedObjects",
                "($first: Int,$after: String,$last: Int,$before: String,$input: UnmanagedObjectsInput!)",
                "UnmanagedObjectDetailConnection",
                Query.UnmanagedObjects,
                Query.UnmanagedObjectsFieldSpec,
                @"# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# OPTIONAL
$query.Var.last = $someInt
# OPTIONAL
$query.Var.before = $someString
# REQUIRED
$query.Var.input = @{
	# REQUIRED
	clusterUuid = $someString
	# OPTIONAL
	name = $someString
	# REQUIRED
	unmanagedStatuses = @(
		$someUnmanagedObjectAvailabilityFilter # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UnmanagedObjectAvailabilityFilter]) for enum values.
	)
	# REQUIRED
	objectTypes = @(
		$someManagedObjectType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ManagedObjectType]) for enum values.
	)
	# REQUIRED
	retentionSlaDomainIds = @(
		$someString
	)
	# OPTIONAL
	sortParam = @{
		# OPTIONAL
		type = $someUnmanagedObjectsSortType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UnmanagedObjectsSortType]) for enum values.
		# OPTIONAL
		sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
	}
	# OPTIONAL
	objectId = $someString
	# OPTIONAL
	regions = @(
		@{
			# REQUIRED
			gcpNativeRegion = $someString
			# REQUIRED
			awsNativeRegion = $someAwsNativeRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRegion]) for enum values.
			# REQUIRED
			azureNativeRegion = $someAzureNativeRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeRegion]) for enum values.
		}
	)
	# OPTIONAL
	cloudAccountIds = @(
		$someString
	)
	# OPTIONAL
	managedBy = $someCloudVendor # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudVendor]) for enum values.
}"
            );
        }

        // Create new GraphQL Query:
        // allUnmanagedObjectsSupportedTypes(productType: ProductTargetType, cloudVendor: CloudVendor): [ManagedObjectType!]!
        internal void InitQueryAllUnmanagedObjectsSupportedTypes()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("productType", "ProductTargetType"),
                Tuple.Create("cloudVendor", "CloudVendor"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllUnmanagedObjectsSupportedTypes",
                "($productType: ProductTargetType,$cloudVendor: CloudVendor)",
                "List<ManagedObjectType>",
                Query.AllUnmanagedObjectsSupportedTypes,
                Query.AllUnmanagedObjectsSupportedTypesFieldSpec,
                @"# OPTIONAL
$query.Var.productType = $someProductTargetType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ProductTargetType]) for enum values.
# OPTIONAL
$query.Var.cloudVendor = $someCloudVendor # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudVendor]) for enum values."
            );
        }

        // Create new GraphQL Query:
        // upgradeStatus(clusterUuid: UUID!): UpgradeStatusReply!
        internal void InitQueryUpgradeStatus()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("clusterUuid", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryUpgradeStatus",
                "($clusterUuid: UUID!)",
                "UpgradeStatusReply",
                Query.UpgradeStatus,
                Query.UpgradeStatusFieldSpec,
                @"# REQUIRED
$query.Var.clusterUuid = $someString"
            );
        }

        // Create new GraphQL Query:
        // userActivities(
        //     filter: ListObjectFilesFiltersInput
        //     sort: FileResultSortInput
        //     timeRange: UserTimeRangeInput
        //     userId: String!
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //   ): FileResultConnection!
        internal void InitQueryUserActivities()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("filter", "ListObjectFilesFiltersInput"),
                Tuple.Create("sort", "FileResultSortInput"),
                Tuple.Create("timeRange", "UserTimeRangeInput"),
                Tuple.Create("userId", "String!"),
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryUserActivities",
                "($filter: ListObjectFilesFiltersInput,$sort: FileResultSortInput,$timeRange: UserTimeRangeInput,$userId: String!,$first: Int,$after: String,$last: Int,$before: String)",
                "FileResultConnection",
                Query.UserActivities,
                Query.UserActivitiesFieldSpec,
                @"# OPTIONAL
$query.Var.filter = @{
	# OPTIONAL
	openAccessTypes = @(
		$someOpenAccessType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.OpenAccessType]) for enum values.
	)
	# OPTIONAL
	stalenessTypes = @(
		$someStalenessType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.StalenessType]) for enum values.
	)
	# OPTIONAL
	analyzerGroupIds = @(
		$someString
	)
	# OPTIONAL
	clusterIds = @(
		$someString
	)
	# OPTIONAL
	pathPrefix = $someString
	# OPTIONAL
	snappableTypes = @(
		$someString
	)
	# OPTIONAL
	searchText = $someString
	# OPTIONAL
	whitelistEnabled = $someBoolean
	# OPTIONAL
	fileCountTypes = @(
		$someFileCountType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.FileCountType]) for enum values.
	)
	# OPTIONAL
	accessTypes = @(
		$someAccessType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AccessType]) for enum values.
	)
	# OPTIONAL
	activityTypes = @(
		$someActivityAccessType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ActivityAccessType]) for enum values.
	)
	# OPTIONAL
	objectIds = @(
		$someString
	)
	# OPTIONAL
	inodeTypes = @(
		$someInodeType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.InodeType]) for enum values.
	)
	# REQUIRED
	objectTypes = @(
		$someHierarchyObjectTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchyObjectTypeEnum]) for enum values.
	)
}
# OPTIONAL
$query.Var.sort = @{
	# OPTIONAL
	sortBy = $someFileResultSortBy # Call [Enum]::GetValues([RubrikSecurityCloud.Types.FileResultSortBy]) for enum values.
	# OPTIONAL
	sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
	# OPTIONAL
	analyzerGroupId = $someString
	# OPTIONAL
	dataTypeId = $someString
}
# OPTIONAL
$query.Var.timeRange = @{
	# OPTIONAL
	startTime = $someString
	# OPTIONAL
	endTime = $someString
	# OPTIONAL
	timezone = $someString
}
# REQUIRED
$query.Var.userId = $someString
# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# OPTIONAL
$query.Var.last = $someInt
# OPTIONAL
$query.Var.before = $someString"
            );
        }

        // Create new GraphQL Query:
        // userAlreadyExists(emailOrUsername: String!, userDomain: UserDomainEnum!, userDomainId: String): UserAlreadyExistsReply!
        internal void InitQueryUserAlreadyExists()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("emailOrUsername", "String!"),
                Tuple.Create("userDomain", "UserDomainEnum!"),
                Tuple.Create("userDomainId", "String"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryUserAlreadyExists",
                "($emailOrUsername: String!,$userDomain: UserDomainEnum!,$userDomainId: String)",
                "UserAlreadyExistsReply",
                Query.UserAlreadyExists,
                Query.UserAlreadyExistsFieldSpec,
                @"# REQUIRED
$query.Var.emailOrUsername = $someString
# REQUIRED
$query.Var.userDomain = $someUserDomainEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UserDomainEnum]) for enum values.
# OPTIONAL
$query.Var.userDomainId = $someString"
            );
        }

        // Create new GraphQL Query:
        // userAnalyzerAccess(
        //     userId: String!
        //     startDay: String!
        //     timezone: String!
        //     limit: Int! = 0
        //   ): AnalyzerAccessUsageConnection!
        internal void InitQueryUserAnalyzerAccess()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("userId", "String!"),
                Tuple.Create("startDay", "String!"),
                Tuple.Create("timezone", "String!"),
                Tuple.Create("limit", "Int!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryUserAnalyzerAccess",
                "($userId: String!,$startDay: String!,$timezone: String!,$limit: Int!)",
                "AnalyzerAccessUsageConnection",
                Query.UserAnalyzerAccess,
                Query.UserAnalyzerAccessFieldSpec,
                @"# REQUIRED
$query.Var.userId = $someString
# REQUIRED
$query.Var.startDay = $someString
# REQUIRED
$query.Var.timezone = $someString
# REQUIRED
$query.Var.limit = $someInt"
            );
        }

        // Create new GraphQL Query:
        // userAuditConnection(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     sortOrder: SortOrder
        //     sortBy: UserAuditSortField
        //     filters: UserAuditFilter
        //   ): UserAuditConnection!
        internal void InitQueryUserAuditConnection()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("sortBy", "UserAuditSortField"),
                Tuple.Create("filters", "UserAuditFilter"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryUserAuditConnection",
                "($first: Int,$after: String,$last: Int,$before: String,$sortOrder: SortOrder,$sortBy: UserAuditSortField,$filters: UserAuditFilter)",
                "UserAuditConnection",
                Query.UserAuditConnection,
                Query.UserAuditConnectionFieldSpec,
                @"# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# OPTIONAL
$query.Var.last = $someInt
# OPTIONAL
$query.Var.before = $someString
# OPTIONAL
$query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$query.Var.sortBy = $someUserAuditSortField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UserAuditSortField]) for enum values.
# OPTIONAL
$query.Var.filters = @{
	# OPTIONAL
	auditSeverity = @(
		$someAuditSeverity # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AuditSeverity]) for enum values.
	)
	# OPTIONAL
	auditStatus = @(
		$someAuditStatus # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AuditStatus]) for enum values.
	)
	# OPTIONAL
	auditType = @(
		$someAuditType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AuditType]) for enum values.
	)
	# OPTIONAL
	auditObjectType = @(
		$someAuditObjectType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AuditObjectType]) for enum values.
	)
	# OPTIONAL
	clusterId = @(
		$someString
	)
	# OPTIONAL
	objectIds = @(
		$someString
	)
	# OPTIONAL
	objectFids = @(
		$someString
	)
	# OPTIONAL
	timeGt = $someDateTime
	# OPTIONAL
	timeLt = $someDateTime
	# OPTIONAL
	hasUserNote = $someBoolean
	# OPTIONAL
	searchTerm = $someString
	# OPTIONAL
	orgIds = @(
		$someString
	)
}"
            );
        }

        // Create new GraphQL Query:
        // userDetail(userId: String!, startDay: String!, timezone: String!): GetUserDetailReply!
        internal void InitQueryUserDetail()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("userId", "String!"),
                Tuple.Create("startDay", "String!"),
                Tuple.Create("timezone", "String!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryUserDetail",
                "($userId: String!,$startDay: String!,$timezone: String!)",
                "GetUserDetailReply",
                Query.UserDetail,
                Query.UserDetailFieldSpec,
                @"# REQUIRED
$query.Var.userId = $someString
# REQUIRED
$query.Var.startDay = $someString
# REQUIRED
$query.Var.timezone = $someString"
            );
        }

        // Create new GraphQL Query:
        // userFile(externalId: String!): CustomerFacingFile!
        internal void InitQueryUserFile()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("externalId", "String!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryUserFile",
                "($externalId: String!)",
                "CustomerFacingFile",
                Query.UserFile,
                Query.UserFileFieldSpec,
                @"# REQUIRED
$query.Var.externalId = $someString"
            );
        }

        // Create new GraphQL Query:
        // allUserFiles(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //   ): [GetCustomerFacingDownloadsReply!]!
        internal void InitQueryAllUserFiles()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllUserFiles",
                "($first: Int,$after: String,$last: Int,$before: String)",
                "List<GetCustomerFacingDownloadsReply>",
                Query.AllUserFiles,
                Query.AllUserFilesFieldSpec,
                @"# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# OPTIONAL
$query.Var.last = $someInt
# OPTIONAL
$query.Var.before = $someString"
            );
        }

        // Create new GraphQL Query:
        // userGroups(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     roleIdsFilter: [UUID!]
        //   ): [Group!]!
        internal void InitQueryUserGroups()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("roleIdsFilter", "[UUID!]"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryUserGroups",
                "($first: Int,$after: String,$last: Int,$before: String,$roleIdsFilter: [UUID!])",
                "List<Group>",
                Query.UserGroups,
                Query.UserGroupsFieldSpec,
                @"# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# OPTIONAL
$query.Var.last = $someInt
# OPTIONAL
$query.Var.before = $someString
# OPTIONAL
$query.Var.roleIdsFilter = @(
	$someString
)"
            );
        }

        // Create new GraphQL Query:
        // userNotifications: UserNotifications!
        internal void InitQueryUserNotifications()
        {
            Tuple<string, string>[] argDefs = {
            };
            Initialize(
                argDefs,
                "query",
                "QueryUserNotifications",
                "",
                "UserNotifications",
                Query.UserNotifications,
                Query.UserNotificationsFieldSpec,
                @""
            );
        }

        // Create new GraphQL Query:
        // userSessionManagementConfig: GetUserSessionManagementConfigReply!
        internal void InitQueryUserSessionManagementConfig()
        {
            Tuple<string, string>[] argDefs = {
            };
            Initialize(
                argDefs,
                "query",
                "QueryUserSessionManagementConfig",
                "",
                "GetUserSessionManagementConfigReply",
                Query.UserSessionManagementConfig,
                Query.UserSessionManagementConfigFieldSpec,
                @""
            );
        }

        // Create new GraphQL Query:
        // userSettings: UserSettings!
        internal void InitQueryUserSettings()
        {
            Tuple<string, string>[] argDefs = {
            };
            Initialize(
                argDefs,
                "query",
                "QueryUserSettings",
                "",
                "UserSettings",
                Query.UserSettings,
                Query.UserSettingsFieldSpec,
                @""
            );
        }

        // Create new GraphQL Query:
        // usersInCurrentAndDescendantOrganization(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     sortBy: UserSortByParam
        //     filter: UserFilterInput
        //     shouldIncludeUserWithoutRole: Boolean = false
        //   ): UserConnection!
        internal void InitQueryUsersInCurrentAndDescendantOrganization()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("sortBy", "UserSortByParam"),
                Tuple.Create("filter", "UserFilterInput"),
                Tuple.Create("shouldIncludeUserWithoutRole", "Boolean"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryUsersInCurrentAndDescendantOrganization",
                "($first: Int,$after: String,$last: Int,$before: String,$sortBy: UserSortByParam,$filter: UserFilterInput,$shouldIncludeUserWithoutRole: Boolean)",
                "UserConnection",
                Query.UsersInCurrentAndDescendantOrganization,
                Query.UsersInCurrentAndDescendantOrganizationFieldSpec,
                @"# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# OPTIONAL
$query.Var.last = $someInt
# OPTIONAL
$query.Var.before = $someString
# OPTIONAL
$query.Var.sortBy = @{
	# OPTIONAL
	field = $someUserSortByField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UserSortByField]) for enum values.
	# OPTIONAL
	sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
}
# OPTIONAL
$query.Var.filter = @{
	# OPTIONAL
	emailFilter = $someString
	# OPTIONAL
	domainFilter = @(
		$someUserDomainEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UserDomainEnum]) for enum values.
	)
	# OPTIONAL
	orgIdsFilter = @(
		$someString
	)
	# OPTIONAL
	roleIdsFilter = @(
		$someString
	)
	# OPTIONAL
	lockoutStateFilter = $someLockoutStateFilter # Call [Enum]::GetValues([RubrikSecurityCloud.Types.LockoutStateFilter]) for enum values.
	# OPTIONAL
	hiddenStateFilter = $someHiddenStateFilter # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HiddenStateFilter]) for enum values.
	# OPTIONAL
	authDomainIdsFilter = @(
		$someString
	)
}
# OPTIONAL
$query.Var.shouldIncludeUserWithoutRole = $someBoolean"
            );
        }

        // Create new GraphQL Query:
        // allUsersOnAccountConnection(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     sortOrder: SortOrder
        //     sortBy: UserFieldEnum = Email
        //     emailFilter: String
        //     roleIdsFilter: [UUID!]
        //     lockoutStateFilter: LockoutStateFilter
        //     hiddenStateFilter: HiddenStateFilter
        //     shouldGetLocalUsersOnly: Boolean! = false
        //     userDomainsFilter: [UserDomainEnum!]
        //   ): UserConnection!
        internal void InitQueryAllUsersOnAccountConnection()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("sortBy", "UserFieldEnum"),
                Tuple.Create("emailFilter", "String"),
                Tuple.Create("roleIdsFilter", "[UUID!]"),
                Tuple.Create("lockoutStateFilter", "LockoutStateFilter"),
                Tuple.Create("hiddenStateFilter", "HiddenStateFilter"),
                Tuple.Create("shouldGetLocalUsersOnly", "Boolean!"),
                Tuple.Create("userDomainsFilter", "[UserDomainEnum!]"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllUsersOnAccountConnection",
                "($first: Int,$after: String,$last: Int,$before: String,$sortOrder: SortOrder,$sortBy: UserFieldEnum,$emailFilter: String,$roleIdsFilter: [UUID!],$lockoutStateFilter: LockoutStateFilter,$hiddenStateFilter: HiddenStateFilter,$shouldGetLocalUsersOnly: Boolean!,$userDomainsFilter: [UserDomainEnum!])",
                "UserConnection",
                Query.AllUsersOnAccountConnection,
                Query.AllUsersOnAccountConnectionFieldSpec,
                @"# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# OPTIONAL
$query.Var.last = $someInt
# OPTIONAL
$query.Var.before = $someString
# OPTIONAL
$query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$query.Var.sortBy = $someUserFieldEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UserFieldEnum]) for enum values.
# OPTIONAL
$query.Var.emailFilter = $someString
# OPTIONAL
$query.Var.roleIdsFilter = @(
	$someString
)
# OPTIONAL
$query.Var.lockoutStateFilter = $someLockoutStateFilter # Call [Enum]::GetValues([RubrikSecurityCloud.Types.LockoutStateFilter]) for enum values.
# OPTIONAL
$query.Var.hiddenStateFilter = $someHiddenStateFilter # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HiddenStateFilter]) for enum values.
# REQUIRED
$query.Var.shouldGetLocalUsersOnly = $someBoolean
# OPTIONAL
$query.Var.userDomainsFilter = @(
	$someUserDomainEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UserDomainEnum]) for enum values.
)"
            );
        }

        // Create new GraphQL Query:
        // validateOrgName(input: ValidateOrgNameInput!): ValidateOrgNameReply!
        internal void InitQueryValidateOrgName()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "ValidateOrgNameInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryValidateOrgName",
                "($input: ValidateOrgNameInput!)",
                "ValidateOrgNameReply",
                Query.ValidateOrgName,
                Query.ValidateOrgNameFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	fullName = $someString
	# OPTIONAL
	name = $someString
}"
            );
        }

        // Create new GraphQL Query:
        // vcdVappVms(
        //     first: Int
        //     after: String
        //     sortBy: HierarchySortByField
        //     sortOrder: SortOrder
        //     filter: [Filter!] = []
        //   ): VsphereVmConnection!
        internal void InitQueryVcdVappVms()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("sortBy", "HierarchySortByField"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("filter", "[Filter!]"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryVcdVappVms",
                "($first: Int,$after: String,$sortBy: HierarchySortByField,$sortOrder: SortOrder,$filter: [Filter!])",
                "VsphereVmConnection",
                Query.VcdVappVms,
                Query.VcdVappVmsFieldSpec,
                @"# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# OPTIONAL
$query.Var.sortBy = $someHierarchySortByField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchySortByField]) for enum values.
# OPTIONAL
$query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$query.Var.filter = @(
	@{
		# OPTIONAL
		field = $someHierarchyFilterField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchyFilterField]) for enum values.
		# OPTIONAL
		texts = @(
			$someString
		)
		# OPTIONAL
		tagFilterParams = @(
			@{
				# OPTIONAL
				filterType = $someTagFilterType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TagFilterType]) for enum values.
				# OPTIONAL
				tagKey = $someString
				# OPTIONAL
				tagValue = $someString
			}
		)
		# OPTIONAL
		objectTypeFilterParams = @(
			$someManagedObjectType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ManagedObjectType]) for enum values.
		)
		# OPTIONAL
		awsNativeProtectionFeatureNames = @(
			$someAwsNativeProtectionFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		isNegative = $someBoolean
		# OPTIONAL
		isSlowSearchEnabled = $someBoolean
		# OPTIONAL
		azureNativeProtectionFeatureNames = @(
			$someAzureNativeProtectionFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		unmanagedObjectAvailabilityFilter = @(
			$someUnmanagedObjectAvailabilityFilter # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UnmanagedObjectAvailabilityFilter]) for enum values.
		)
}
)"
            );
        }

        // Create new GraphQL Query:
        // verifyTotp(input: VerifyTotpInput!): VerifyTotpReply!
        internal void InitQueryVerifyTotp()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "VerifyTotpInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryVerifyTotp",
                "($input: VerifyTotpInput!)",
                "VerifyTotpReply",
                Query.VerifyTotp,
                Query.VerifyTotpFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	otp = $someString
}"
            );
        }

        // Create new GraphQL Query:
        // allVirtualMachineFiles(input: VirtualMachineFilesInput!): VirtualMachineFilesReply!
        internal void InitQueryAllVirtualMachineFiles()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "VirtualMachineFilesInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllVirtualMachineFiles",
                "($input: VirtualMachineFilesInput!)",
                "VirtualMachineFilesReply",
                Query.AllVirtualMachineFiles,
                Query.AllVirtualMachineFilesFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someString
}"
            );
        }

        // Create new GraphQL Query:
        // allVmRecoveryJobsInfo(fid: UUID!, input: AllVmRecoveryJobsInfoInput!): [VmRecoveryJobInfo!]!
        internal void InitQueryAllVmRecoveryJobsInfo()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
                Tuple.Create("input", "AllVmRecoveryJobsInfoInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllVmRecoveryJobsInfo",
                "($fid: UUID!,$input: AllVmRecoveryJobsInfoInput!)",
                "List<VmRecoveryJobInfo>",
                Query.AllVmRecoveryJobsInfo,
                Query.AllVmRecoveryJobsInfoFieldSpec,
                @"# REQUIRED
$query.Var.fid = $someString
# REQUIRED
$query.Var.input = @{
	# REQUIRED
	failoverId = $someString
}"
            );
        }

        // Create new GraphQL Query:
        // volumeGroupMounts(
        //     first: Int
        //     after: String
        //     filters: [VolumeGroupLiveMountFilterInput!]
        //     sortBy: VolumeGroupLiveMountSortByInput
        //   ): VolumeGroupLiveMountConnection!
        internal void InitQueryVolumeGroupMounts()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("filters", "[VolumeGroupLiveMountFilterInput!]"),
                Tuple.Create("sortBy", "VolumeGroupLiveMountSortByInput"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryVolumeGroupMounts",
                "($first: Int,$after: String,$filters: [VolumeGroupLiveMountFilterInput!],$sortBy: VolumeGroupLiveMountSortByInput)",
                "VolumeGroupLiveMountConnection",
                Query.VolumeGroupMounts,
                Query.VolumeGroupMountsFieldSpec,
                @"# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# OPTIONAL
$query.Var.filters = @(
	@{
		# OPTIONAL
		field = $someVolumeGroupLiveMountFilterField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.VolumeGroupLiveMountFilterField]) for enum values.
		# OPTIONAL
		texts = @(
			$someString
		)
}
)
# OPTIONAL
$query.Var.sortBy = @{
	# OPTIONAL
	field = $someVolumeGroupLiveMountSortByField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.VolumeGroupLiveMountSortByField]) for enum values.
	# OPTIONAL
	sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
}"
            );
        }

        // Create new GraphQL Query:
        // workloadAlertSetting(clusterUuid: UUID!, workloadId: UUID!): GetWorkloadAlertSettingReply!
        internal void InitQueryWorkloadAlertSetting()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("clusterUuid", "UUID!"),
                Tuple.Create("workloadId", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryWorkloadAlertSetting",
                "($clusterUuid: UUID!,$workloadId: UUID!)",
                "GetWorkloadAlertSettingReply",
                Query.WorkloadAlertSetting,
                Query.WorkloadAlertSettingFieldSpec,
                @"# REQUIRED
$query.Var.clusterUuid = $someString
# REQUIRED
$query.Var.workloadId = $someString"
            );
        }

        // Create new GraphQL Query:
        // workloadAnomalies(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     beginTime: DateTime!
        //     endTime: DateTime
        //     workloadNameSearch: String
        //     objectTypeFilter: [String!]
        //     clusterUuidFilter: [String!]
        //     slaFidFilter: [String!]
        //     encryptionFilter: [EncryptionLevel!]
        //     severityFilter: [ActivitySeverityEnum!]
        //     analyzerGroupFilter: [String!]
        //     sortBy: WorkloadAnomaliesSortBy
        //     sortOrder: SortOrder
        //     orderParentsFirst: Boolean
        //     blueprintRecoveryTypes: [BlueprintRecoveryType!]
        //     locationsFilter: [String!]
        //     resolutionStatusFilter: [ResolutionStatus!]
        //   ): WorkloadAnomalyConnection!
        internal void InitQueryWorkloadAnomalies()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("beginTime", "DateTime!"),
                Tuple.Create("endTime", "DateTime"),
                Tuple.Create("workloadNameSearch", "String"),
                Tuple.Create("objectTypeFilter", "[String!]"),
                Tuple.Create("clusterUuidFilter", "[String!]"),
                Tuple.Create("slaFidFilter", "[String!]"),
                Tuple.Create("encryptionFilter", "[EncryptionLevel!]"),
                Tuple.Create("severityFilter", "[ActivitySeverityEnum!]"),
                Tuple.Create("analyzerGroupFilter", "[String!]"),
                Tuple.Create("sortBy", "WorkloadAnomaliesSortBy"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("orderParentsFirst", "Boolean"),
                Tuple.Create("blueprintRecoveryTypes", "[BlueprintRecoveryType!]"),
                Tuple.Create("locationsFilter", "[String!]"),
                Tuple.Create("resolutionStatusFilter", "[ResolutionStatus!]"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryWorkloadAnomalies",
                "($first: Int,$after: String,$last: Int,$before: String,$beginTime: DateTime!,$endTime: DateTime,$workloadNameSearch: String,$objectTypeFilter: [String!],$clusterUuidFilter: [String!],$slaFidFilter: [String!],$encryptionFilter: [EncryptionLevel!],$severityFilter: [ActivitySeverityEnum!],$analyzerGroupFilter: [String!],$sortBy: WorkloadAnomaliesSortBy,$sortOrder: SortOrder,$orderParentsFirst: Boolean,$blueprintRecoveryTypes: [BlueprintRecoveryType!],$locationsFilter: [String!],$resolutionStatusFilter: [ResolutionStatus!])",
                "WorkloadAnomalyConnection",
                Query.WorkloadAnomalies,
                Query.WorkloadAnomaliesFieldSpec,
                @"# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# OPTIONAL
$query.Var.last = $someInt
# OPTIONAL
$query.Var.before = $someString
# REQUIRED
$query.Var.beginTime = $someDateTime
# OPTIONAL
$query.Var.endTime = $someDateTime
# OPTIONAL
$query.Var.workloadNameSearch = $someString
# OPTIONAL
$query.Var.objectTypeFilter = @(
	$someString
)
# OPTIONAL
$query.Var.clusterUuidFilter = @(
	$someString
)
# OPTIONAL
$query.Var.slaFidFilter = @(
	$someString
)
# OPTIONAL
$query.Var.encryptionFilter = @(
	$someEncryptionLevel # Call [Enum]::GetValues([RubrikSecurityCloud.Types.EncryptionLevel]) for enum values.
)
# OPTIONAL
$query.Var.severityFilter = @(
	$someActivitySeverityEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ActivitySeverityEnum]) for enum values.
)
# OPTIONAL
$query.Var.analyzerGroupFilter = @(
	$someString
)
# OPTIONAL
$query.Var.sortBy = $someWorkloadAnomaliesSortBy # Call [Enum]::GetValues([RubrikSecurityCloud.Types.WorkloadAnomaliesSortBy]) for enum values.
# OPTIONAL
$query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$query.Var.orderParentsFirst = $someBoolean
# OPTIONAL
$query.Var.blueprintRecoveryTypes = @(
	$someBlueprintRecoveryType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.BlueprintRecoveryType]) for enum values.
)
# OPTIONAL
$query.Var.locationsFilter = @(
	$someString
)
# OPTIONAL
$query.Var.resolutionStatusFilter = @(
	$someResolutionStatus # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ResolutionStatus]) for enum values.
)"
            );
        }

        // Create new GraphQL Query:
        // workloadForeverId(clusterUuid: UUID!, managedId: String!): UUID!
        internal void InitQueryWorkloadForeverId()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("clusterUuid", "UUID!"),
                Tuple.Create("managedId", "String!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryWorkloadForeverId",
                "($clusterUuid: UUID!,$managedId: String!)",
                "System.String",
                Query.WorkloadForeverId,
                Query.WorkloadForeverIdFieldSpec,
                @"# REQUIRED
$query.Var.clusterUuid = $someString
# REQUIRED
$query.Var.managedId = $someString"
            );
        }


    } // class New_RscQueryMisc
}