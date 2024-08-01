# New-RscQueryMisc
## Subcommands
### activecustomanalyzers
- The activecustomanalyzers subcommand takes no arguments.
- Returns AnalyzerConnection.
### activeinsights
The active insights for the account.

- There are 9 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
    - clusterUUIDs - list of System.Strings: List of Rubrik Cluster ID's to filter by.
    - severities - list of InsightSeveritys: List of severities to filter by.
    - includeClusterLevelInsights - System.Boolean: Specifies whether to include cluster level insights.
    - includeAccountLevelInsights - System.Boolean: Specifies whether to include account level insights.
    - includeDismissedInsights - System.Boolean: Specifies whether to include previously dismissed insights.
- Returns ActiveInsightConnection.
### adgroupmembers
Objects that match the specifications of the AD group.

- There are 4 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - orgId - System.String: Org UUID.
    - adGroupSpec - AdGroupSpecInput: The Azure Active Directory group spec.
- Returns O365AdGroupMemberConnection.
### advolumeexports
Active Directory volume export connection.

- There are 4 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - filters - list of AdVolumeExportFilters: Filter for Active Directory volume exports.
    - sortBy - AdVolumeExportSortByInput: Sort by argument for Active Directory volume exports.
- Returns AdVolumeExportConnection.
### agentdeploymentsetting
Get Rubrik Backup Service deployment setting

Supported in v5.0+
Retrieve the global setting for automatic deployment of the Rubrik Backup Service to virtual machines.

- There is a single argument of type GetVmAgentDeploymentSettingInput.
- Returns AgentDeploymentSettings.
### agentdeploymentsettings
Get all agent deployment settings.

- There is a single argument of type list of System.Strings.
- Returns list of AgentDeploymentSettingsInfos.
### allowedorgadminoperations
Returns privileges that are allowed to be asssigned to org admin roles.

- The allowedorgadminoperations subcommand takes no arguments.
- Returns list of Operations.
### analyzergroups
- The analyzergroups subcommand takes no arguments.
- Returns AnalyzerGroupConnection.
### analyzerusages
Returns which policies are using each analyzer.

- The analyzerusages subcommand takes no arguments.
- Returns AnalyzerUsageConnection.
### anomaliesobjects
Object level stats for anomalies.

- There is a single argument of type DateTime.
- Returns AnomaliesObjects.
### anomalydetectionobjectenablementstats
Anomaly Detection object enablement stats.

- There is a single argument of type DateTime.
- Returns GetAnomalyDetectionObjectEnablementStatsResponse.
### anomalyresultopt
Optional result of the Anomaly Investigation.

- There are 4 arguments.
    - clusterUuid - System.String: The Rubrik cluster ID.
    - snapshotId - System.String: Corresponds to snapshot ID in Rubrik CDM tables.
    - workloadId - System.String: The ID of the workload.
    - anomalyId - System.String: The ID of the anomaly.
- Returns GetAnomalyDetailsReply.
### anomalyresults
Results for Anomaly Investigations.

- There are 8 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
    - sortOrder - SortOrder: Sort order of result.
    - sortBy - AnomalyResultSortBy: Sort anomaly results by field.
    - filter - AnomalyResultFilterInput: Filter anomaly results by input.
    - timezoneOffset - System.Single: Offset based on customer timezone.
- Returns AnomalyResultConnection.
### anomalyresultsgrouped
Results for Anomaly Investigations grouped by an argument.

- There are 7 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
    - groupBy - AnomalyResultGroupBy: Group anomaly results by field.
    - filter - AnomalyResultFilterInput: Filter anomaly results by input.
    - timezoneOffset - System.Single: Offset based on customer timezone.
- Returns AnomalyResultGroupedDataConnection.
### appflowssummary
- The appflowssummary subcommand takes no arguments.
- Returns AppflowsSummary.
### aremultigeobackupsenabled
Retrieves the status of multi-geo backups for the specified organization.

- There is a single argument of type System.String.
- Returns System.Boolean.
### atlassiansite
RSC details for an Atlassian site.

- There is a single argument of type System.String.
- Returns AtlassianSite.
### atlassiansites
Atlassian sites in an account.

- There are 7 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
    - sortBy - HierarchySortByField: Sort hierarchy objects according to the hierarchy field.
    - sortOrder - SortOrder: Sort order of result.
    - filter - list of Filters: The hierarchy object filter.
- Returns AtlassianSiteConnection.
### attributedfeatureflag
Evaluate the feature flag with attributes.

- There are 2 arguments.
    - key - AttributedFeatureFlagName: Feature flag key.
    - attributes - list of FeatureFlagAttributeInputs: List of attributes used to evaluate the feature flag.
- Returns AttributedFeatureFlag.
### authorizationsforglobalresource
List of authorized operations for global resource.

- The authorizationsforglobalresource subcommand takes no arguments.
- Returns list of Operations.
### authorizationsforobject
List of authorizations for the object.

- There is a single argument of type System.String.
- Returns list of Operations.
### authorizationsforobjects
List of authorizations for the objects.

- There is a single argument of type list of System.Strings.
- Returns list of AuthorizedOperationss.
### awscomputesettings
List all aws compute settings.

- There are 4 arguments.
    - sortBy - AwsCloudComputeSettingQuerySortByField: Specification on how to sort a list of compute settings.
    - sortOrder - SortOrder: Sort order of result.
    - filter - list of AwsCloudComputeSettingFilterInputs: Specification on how to filter a list of compute settings.
    - contextFilter - ContextFilterTypeEnum: Specifies the context filter to use.
- Returns list of AwsComputeSettingss.
### azureresourcegroups
Get resource groups for a service principal in Azure.

- There are 2 arguments.
    - cloudAccountId - System.String: Cloud account ID.
    - azureRegion - System.String: Region for Azure cloud account.
- Returns list of System.Strings.
### azuresubnets
Get subnets for a given account in Azure.

- There is a single argument of type AzureSubnetReq.
- Returns list of System.Strings.
### backupthrottlesettings
Get all backup throttle settings.

- There is a single argument of type list of System.Strings.
- Returns list of BackupThrottleSettings.
### blueprint
- There is a single argument of type System.String.
- Returns Blueprint.
### blueprintlist
- There are 5 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - sortBy - HierarchySortByField: Sort hierarchy objects according to the hierarchy field.
    - sortOrder - SortOrder: Sort order of result.
    - filter - list of Filters: The hierarchy object filter.
- Returns BlueprintConnection.
### blueprintnew
- There is a single argument of type System.String.
- Returns BlueprintNew.
### blueprintrecoveryspecs
list the recovery specs associated with the given blueprint

- There are 7 arguments.
    - blueprintId - System.String: The Blueprint ID.
    - ignoreErrors - System.Boolean: Ignore invalid recovery specs or raise an error.
    - validate - System.Boolean: Validate the recovery specs if true.
    - getInvalidSpecs - System.Boolean: Get invalid recovery spec if true.
    - snappableInfos - list of SnappableInfoTypes: The list of workload recovery points.
    - failoverId - System.String: Failover summary ID.
    - resourceSpecType - list of ResourceSpecTypes: The type of resource specification TEMPLATE or INSTANCE.
- Returns BlueprintRecoverySpecs.
### blueprintresourcespecs
Describes the Blueprint resource specs.

- There are 3 arguments.
    - blueprintId - System.String: The Blueprint ID.
    - snappableInfos - list of SnappableInfoTypes: The list of workload recovery points.
    - failoverId - System.String: Failover summary ID.
- Returns list of ResourceSpecs.
### blueprints
All Blueprints.

- There are 12 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - sortBy - HierarchySortByField: Sort hierarchy objects according to the hierarchy field.
    - sortOrder - SortOrder: Sort order of result.
    - filter - list of Filters: The hierarchy object filter.
    - sourceLocationIdOpt - System.String: The ID of the source location.
    - targetLocationIdOpt - System.String: The ID of the intended remote target location.
    - statusOpt - BlueprintStatus: The status of the Recovery Plan.
    - failoverStatusOpt - FailoverStatusEnum: The status of the Recovery Plan failover.
    - blueprintRecoveryTypes - list of BlueprintRecoveryTypes: Recovery type of the Recovery Plan.
    - isBlueprintVisible - System.Boolean: Flag to enable visibility of the Recovery Plan.
    - blueprintIds - list of System.Strings: Recovery plan IDs.
- Returns BlueprintNewConnection.
### brandlogo
- The brandlogo subcommand takes no arguments.
- Returns GetBrandLogoReply.
### browsecalendar
Browse Exchange calendar.

- There are 7 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - snappableFid - System.String: The fid for the workload.
    - snapshotFid - System.String: The ID of the snapshot.
    - folderId - System.String
    - orgId - System.String: Org UUID.
    - calendarSearchFilter - CalendarSearchFilter: Search filter for calendar search.
- Returns O365ExchangeObjectConnection.
### browsecontacts
Browse Exchange contacts.

- There are 7 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - snappableFid - System.String: The fid for the workload.
    - snapshotFid - System.String: The ID of the snapshot.
    - folderId - System.String
    - orgId - System.String: Org UUID.
    - contactsSearchFilter - ContactsSearchFilter: Search filter for contacts search.
- Returns O365ExchangeObjectConnection.
### browsefolder
- There are 6 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - snappableFid - System.String: The fid for the workload.
    - snapshotFid - System.String: The ID of the snapshot.
    - folderId - System.String
    - orgId - System.String: Org UUID.
- Returns O365ExchangeObjectConnection.
### browseonedrive
Browse OneDrive files and folders.

- There are 7 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - snappableFid - System.String: The fid for the workload.
    - snapshotFid - System.String: The ID of the snapshot.
    - folderId - System.String
    - onedriveSearchFilter - OnedriveSearchFilter
    - orgId - System.String: Org UUID.
- Returns O365OnedriveObjectConnection.
### browseteamschannels
Browse channels in a Teams files snapshot.

- There are 7 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - snappableFid - System.String: The fid for the workload.
    - snapshotFid - System.String: The ID of the snapshot.
    - orgId - System.String: Org UUID.
    - channelMembershipTypeFilter - ChannelMembershipType: Filter on channel membership type.
    - nameFilter - System.String
- Returns O365TeamsChannelConnection.
### browseteamsdrive
Browse team files.

- There are 7 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - snappableFid - System.String: The fid for the workload.
    - snapshotFid - System.String: The ID of the snapshot.
    - folderId - System.String
    - teamsDriveSearchFilter - OnedriveSearchFilter
    - orgId - System.String: Org UUID.
- Returns O365OnedriveObjectConnection.
### bulkrecoveryprogress
Get bulk recovery progress.

- There is a single argument of type BulkRecoveryProgressInput.
- Returns BulkRecoveryProgressReply.
### cdmguestcredentials
Get all cdm guest credentials.

- There is a single argument of type list of System.Strings.
- Returns list of CdmGuestCredentials.
### cdminventorysubhierarchyroot
- There is a single argument of type InventorySubHierarchyRootEnum.
- Returns CdmInventorySubHierarchyRoot.
### cdmovadetails
The Rubrik CDM OVA details.

- The cdmovadetails subcommand takes no arguments.
- Returns list of CdmOvaDetails.
### cdmrbacmigrationstatuses
Returns CDM-to-RSC RBAC migration statuses for the specified clusters.

- There is a single argument of type list of System.Strings.
- Returns list of CdmMigrationStatuss.
### cdmrolesformigration
Authentication domain configuration of the current organization.

- There are 5 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
    - clusterId - System.String: The target cluster ID of the CDM RBAC migration API.
- Returns CdmRoleConnection.
### cdmssogroupsformigration
Details of the user's current organization.

- There are 5 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
    - clusterId - System.String: The target cluster ID of the CDM RBAC migration API.
- Returns CdmSSOGroupConnection.
### cdmusersformigration
Org details of the given org ID.

- There are 5 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
    - clusterId - System.String: The target cluster ID of the CDM RBAC migration API.
- Returns CdmUserConnection.
### cdmversioncheck
Check supported feature for cluster version.

- There is a single argument of type FeatureCdmVersionInput.
- Returns FeatureCdmVersionReply.
### cdpvmsinfos
Details of all the virtual machines with Continuous Data Protection (CDP) SLA Domain.

- There are 6 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
    - allCdpVmInfoSort - CdpPerfDashboardSortParam: Sort Type for getting all CDP VMs for CDP performance dashboard.
    - allCdpVmInfoFilter - list of CdpPerfDashboardFilterParams: Filter Type for getting all CDP VMs for CDP performance dashboard.
- Returns CdpVmInfoConnection.
### chatbot
Chatbot information.

- There is a single argument of type GetChatbotInput.
- Returns Chatbot.
### chatbots
List of chatbots.

- There are 5 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
    - nameSearchFilter - System.String: String used for case-insensitive infix search on the chatbot name.
- Returns ChatbotConnection.
### chatbykey
Returns the ID of the chat with the specified key and usage, or undefined if no such chat exists.

- There are 2 arguments.
    - chatKey - System.String: The unique key of the chat.
    - chatUsage - ChatUsage: The usage of the chat.
- Returns GetChatByKeyReply.
### chatmessages
List of messages in a chat.

- There are 5 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
    - chatId - System.String: The ID of the chat.
- Returns ChatMessageConnection.
### chats
List of chats.

- There are 6 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
    - includeChatUsages - list of ChatUsages: The chat usages to be included from the list.
    - excludeChatUsages - list of ChatUsages: The chat usages to be excluded from the list.
- Returns ChatConnection.
### checkcloudcomputeconnectivityjobprogress
Get details of the cloud compute connectivity check request

Supported in v6.0+
Gets the details of the request that was triggered to check the cloud compute connectivity of an archival location.

- There is a single argument of type GetCloudComputeConnectivityCheckRequestStatusInput.
- Returns AsyncRequestStatus.
### checkguestosforappblueprint
check the child vm guestOS for given app blueprint

- There is a single argument of type System.String.
- Returns CheckGuestOsReply.
### checklatestversionmgmtappexists
Checks whether the latest version of the Microsoft 365 Management App exists.

- There is a single argument of type CheckLatestVersionMgmtAppExistsInput.
- Returns CheckLatestVersionMgmtAppExistsReply.
### classifiableassetcount
Returns the count of classifiable assets by platform.

- There is a single argument of type System.String.
- Returns list of ClassifiableAssetCounts.
### classificationbannersettings
- The classificationbannersettings subcommand takes no arguments.
- Returns ClassificationBannerSettings.
### classificationloginsettings
- The classificationloginsettings subcommand takes no arguments.
- Returns ClassificationLoginSettings.
### clouddirectnasexport
A Cloud Direct NAS export object.

- There is a single argument of type System.String.
- Returns CloudDirectNasExport.
### clouddirectshares
Retrieve shares from Cloud Direct site.

- There is a single argument of type AllCloudDirectSharesInput.
- Returns list of ShareExportIdPairs.
### clouddirectsites
List of the Cloud Direct Sites accessible by the current user.

- The clouddirectsites subcommand takes no arguments.
- Returns list of CloudDirectSites.
### clouddirectsystems
Retrieve systems managed by the Cloud Direct site.

- There is a single argument of type CloudDirectSystemsInput.
- Returns CloudDirectSystems.
### complianceretentionlockstatus
Status of the compliance retention lock configuration.

- The complianceretentionlockstatus subcommand takes no arguments.
- Returns ComplianceRetentionLockStatus.
### compliancetimeseries
Seven days of compliance status history for the specified lookback period.

- There are 4 arguments.
    - clusterUuid - System.String: The Rubrik cluster ID.
    - lookbackPeriod - LookbackPeriod: Period of time to look back when evaluating compliance status.
    - objectTypes - list of ObjectTypeEnums: Types of objects to limit the results. If absent, all object types are returned.
    - orgIds - list of System.Strings: Input for orgId filter.
- Returns list of DailyComplianceStatss.
### configprotectionbackups
List of configuration backups available.

- There are 7 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
    - input - ConfigProtectionBackupFilterInput: Filters to list configuration backups.
    - sortOrder - SortOrder: Sort order of result.
    - sortBy - ConfigProtectionBackupsSortByEnum: Sort configuration protection backup information.
- Returns ConfigProtectionBackupsConnection.
### configprotectionsetupinfo
Configuration protection setup information for a cluster.

- There is a single argument of type System.String.
- Returns ConfigProtectionSetupInfo.
### configuredgroupmembers
Objects that match the specifications of a configured group.

- There are 7 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - orgId - System.String: Org UUID.
    - wildcard - System.String: A wildcard pattern that group members' names or URLs must match.
    - pdls - list of System.Strings: A list of preferred data locations that group members must match.
    - workloadHierarchy - WorkloadLevelHierarchy: Each enumeration value represents the hierarchy of a specific workload type for RBAC and SLA Domain assignments. The None value represents the hierarchy of all workload types.
    - groupFilterAttributes - list of GroupFilterAttributes: A list of attributes to filter out group members.
- Returns O365ConfiguredGroupMemberConnection.
### corssettings
CORS setting for the customer's organization. Equals to `null` if CORS is not configured.

- The corssettings subcommand takes no arguments.
- Returns CorsSetting.
### crawl
Returns details for one crawl.

- There is a single argument of type System.String.
- Returns Crawl.
### crawls
Returns crawls for an account.

- The crawls subcommand takes no arguments.
- Returns CrawlConnection.
### crossaccountpairs
Lists all cross-account pairs.

- There are 7 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
    - sortBy - GetCrossAccountPairsSortByField: Specifies the field by which the list of cross-account pairs will be sorted.
    - filter - list of GetCrossAccountPairsFilters: Specification on how to filter a list of cross-account pairs.
    - sortOrder - SortOrder: Sort order of result.
- Returns CrossAccountPairInfoConnection.
### currentipaddress
- The currentipaddress subcommand takes no arguments.
- Returns System.String.
### currentorg
Details of the user's current organization.

- The currentorg subcommand takes no arguments.
- Returns Org.
### currentorgauthdomainconfig
Authentication domain configuration of the current organization.

- The currentorgauthdomainconfig subcommand takes no arguments.
- Returns TenantAuthDomainConfig.
### currentorgidentityproviders
Lists all identity providers for the current organization.

- The currentorgidentityproviders subcommand takes no arguments.
- Returns list of IdentityProviders.
### customanalyzer
- There is a single argument of type System.String.
- Returns Analyzer.
### cyberrecoveryobjects
Details of all the cyber recovery objects.

- There are 6 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
    - cyberRecoveryObjectsFilter - CyberRecoveryObjectsFilterParams: Cyber recovery objects filter parameters.
    - cyberRecoveryObjectsSort - CyberRecoveryObjectsSortParams: Cyber recovery objects sorting parameters.
- Returns CyberRecoveryObjectConnection.
### dashboardsummary
Returns hits grouped by analyzer and policy.

- There is a single argument of type System.Boolean.
- Returns GetDashboardSummaryReply.
### datadiscoveryobjectscount
Returns the counts of objects that are assigned policies, objects that are not assigned policies, and objects that are not supported by Data Discovery.

- The datadiscoveryobjectscount subcommand takes no arguments.
- Returns DataDiscoveryObjectsCount.
### datagovsecdesc
Returns permissions associated with a path.

- There are 5 arguments.
    - snappableFid - System.String
    - snapshotFid - System.String
    - stdPath - System.String
    - skipResolveSids - System.Boolean: Skip converting SIDs in response to friendly names
    - filters - SddlRequestFiltersInput: Filter for resolving security descriptor.
- Returns QuerySDDLReply.
### datalocationsperkmipserver
Get all data locations assigned to this KMIP Server.

- There are 7 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
    - sortOrder - SortOrder: Sort order of result.
    - kmipServerKeyAssignmentInfoSortBy - KmipServerKeyAssignmentInfoSortBy: The order to sort the KMIP server information.
    - serverAddressArg - System.String: The URL address of the KMIP server.
- Returns DataLocationsPerKmipServerConnection.
### datalocationsperkmskeyvault
Get all data locations assigned to this KMS Key Vault.

- There are 5 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
    - kmsKeyVaultId - System.String: The ID of the KMS server instance.
- Returns DataLocationsPerKmsKeyVaultConnection.
### dataviewmetadata
NG Alpha version report metadata.

- There are 2 arguments.
    - searchTerm - System.String: Search term to be used for testing all the report names.
    - polarisReportsFilters - list of PolarisReportsFilterInputs: A list of filters for CustomReports.
- Returns list of dataViewMetadatas.
### decryptexporturl
Decrypt Export URL.

- There are 2 arguments.
    - workloadFid - System.String: The FID of the workload.
    - exportUrlSpecsEnc - System.String: Encrypted string of Export URL Specs containing arbitrary characters
- Returns ExportUrlSpecs.
### deploymentipaddresses
All IP addresses on the Rubrik deployment.

- The deploymentipaddresses subcommand takes no arguments.
- Returns list of System.Strings.
### deploymentversion
Polaris deployment version.

- The deploymentversion subcommand takes no arguments.
- Returns System.String.
### dhrcactiverecommendations
Active DHRC recommendations for the requested categories.

- There is a single argument of type list of DhrcCategorys.
- Returns list of DhrcActiveRecommendations.
### dhrclatestmetrics
Latest DHRC metrics for the requested categories.

- There is a single argument of type list of DhrcCategorys.
- Returns list of DhrcCollectedMetrics.
### dhrcscores
DHRC scores for the requested categories and time span.

- There are 3 arguments.
    - categories - list of DhrcCategorys: Optional list of categories to filter on.
    - beginTime - DateTime: Optional start of timespan to filter on.
    - timespan - DhrcScoreTimespan: Optional timespan to filter on.
- Returns list of DhrcScores.
### difffmd
Browse diff FMD under given path.

- There are 4 arguments.
    - clusterUuid - System.String: The Rubrik cluster ID.
    - managedId - System.String: Workload managed ID.
    - snapshotId - System.String: Corresponds to snapshot ID in Rubrik CDM tables.
    - browseDiffPath - System.String: Root path to browse changes of FMD.
- Returns DiffResult.
### discovernodes
v5.0-v5.1: Discover bootstrappable nodes
v5.2+: (DEPRECATED) Discover bootstrappable nodes

Supported in v5.0+
v5.0-v5.1: Searches for nodes bootstrappable to the specified Rubrik cluster
v5.2+: Searches for nodes that can bootstrap into the specified Rubrik cluster. This endpoint will be moved to v1 in the next major version.

- There is a single argument of type System.String.
- Returns BootstrappableNodeInfoListResponse.
### discoverytimeline
Returns timeline data for all policies of an account.

- There are 7 arguments.
    - startDay - System.String: Start time, in string format (YYYY-MM-DD).
    - endDay - System.String: End time, in string format (YYYY-MM-DD).
    - timezone - System.String
    - getWhitelistedResults - System.Boolean: Include whitelisted objects in the results.
    - workloadTypes - list of DataGovObjectTypes: Types of workloads that can be used for filtering query results.
    - useOptimisedDiscoveryTimeline - System.Boolean: Specifies whether the optimized discovery timeline must be used for the request. If not passed, default is taken as false.
    - subscriptionIdsFilter - list of System.Strings: List of subscriptions for filtering results.
- Returns GetPoliciesTimelineReply.
### distributionlistdigest
Retrieve a custom distribution list event digest by ID.

- There is a single argument of type DistributionDigestByIdInput.
- Returns EventDigest.
### distributionlistdigests
Retrieve all custom distribution list event digests.

- The distributionlistdigests subcommand takes no arguments.
- Returns list of EventDigests.
### dummyfieldwithadminonlytag
- The dummyfieldwithadminonlytag subcommand takes no arguments.
- Returns System.Boolean.
### edgewindowstoollink
Download link for Rubrik Edge Deployment Tool for Microsoft Windows.

- The edgewindowstoollink subcommand takes no arguments.
- Returns EdgeWindowsToolLink.
### effectiverbacpermissions
Permissions assigned to the role that are in effect.

- There is a single argument of type System.String.
- Returns list of RbacPermissions.
### entityinsights
List entity insights.

- There are 5 arguments.
    - filter - ListEntityInsightsFilterInput: Filter to be applied when retrieving entity insights.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
- Returns NotificationConnection.
### envoyregistrationtoken
Retrieve access token for the Rubrik Envoy registration script.

- There is a single argument of type System.String.
- Returns EnvoyRegistrationToken.
### eventdigests
Retrieve event digests for specific recipients.

- There is a single argument of type AllEventDigestsInput.
- Returns list of EventDigests.
### exotaskimagebundle
Gets the list of exo-task images in the bundle along with information on how to download the images.

- There is a single argument of type GetExotaskImageBundleInput.
- Returns GetExotaskImageBundleReply.
### externaldeploymentname
Customer facing Polaris deployment name.

- The externaldeploymentname subcommand takes no arguments.
- Returns System.String.
### failedrestoreitemsinfo
Information on Microsoft 365 restore failed items.

- There are 2 arguments.
    - workloadFid - System.String: The FID of the workload.
    - failedItemsInstanceId - System.String: The instance ID corresponding to the failed restore items.
- Returns FailedRestoreItemsInfoReply.
### failover
failover

- There is a single argument of type System.String.
- Returns Failover.
### failoverallsourcelist
- There are 4 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
- Returns FailoverSourceConnection.
### failoveralltargetsitelist
- There are 4 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
- Returns FailoverTargetSiteConnection.
### failovergroupbylist
- There are 7 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
    - filter - FailoverFilterInput: filter appflows failover jobs by input
    - groupBy - FailoverGroupByEnum: group appflows failover jobs by a field.
    - timezoneOffset - System.Single: Offset based on customer timezone.
- Returns FailoverGroupByConnection.
### failoverlist
- There are 8 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
    - filter - FailoverFilterInput: filter appflows failover jobs by input
    - sortBy - FailoverSortByEnum: sort appflows failover jobs by field.
    - sortOrder - SortOrder: failover jobs sort order.
    - timezoneOffset - System.Single: Offset based on customer timezone.
- Returns FailoverConnection.
### failuresandwarningsstats
Returns the failures and warnings stats of an M365 organization.

- There is a single argument of type System.String.
- Returns list of FailuresAndWarningsStatss.
### featureflag
Evaluate a single feature flag and get the result

- There are 3 arguments.
    - flagName - FeatureFlagName: Name of flag to evaluate
    - entityType - FeatureFlagEntityType: The type of entity context to evaluate against. The value of this arg determines how the entity ID is inferred.
    - entityContext - list of FeatureFlagContextFields: List of flag names to evaluate
- Returns FeatureFlag.
### featureflagall
Evaluate all known feature flags.

- There are 2 arguments.
    - entityType - FeatureFlagEntityType: The type of entity context to evaluate against. The value of this arg determines how the entity ID is inferred.
    - entityContext - list of FeatureFlagContextFields: List of flag names to evaluate
- Returns FeatureFlagAll.
### featureflagnames
Get names of feature flags that surfaced in APIs

- The featureflagnames subcommand takes no arguments.
- Returns list of System.Strings.
### federatedloginstatus
Status of the federated login.

- The federatedloginstatus subcommand takes no arguments.
- Returns FederatedLoginStatus.
### fetchedcdmrbacconfigsummarystats
A numerical summary of the RBAC configuration fetched from the specified Rubrik cluster.

- There is a single argument of type System.String.
- Returns CdmRbacConfigSummaryStats.
### fetchfakedata
Fetch fake data for testing purpose.

- There are 4 arguments.
    - responsePeriodMs - System.Int64: Time taken by the request to serve the response.
    - shouldBlock - System.Boolean: Whether the request blocks the processing thread.
    - preProcessingBufferBytes - System.Int64: Buffer space allocated before making an RPC.
    - responseSizeBytes - System.Int64: Approx size of the response payload.
- Returns FakeDataConnection.
### fileactivities
List user activity for a specific file on a specific snapshot.

- There are 6 arguments.
    - ListFileActivitiesInput - ListFileActivitiesInput: Request for getting user activity for a specific path on a specific snapshot.
    - FileActivitiesSort - FileActivitiesSort: Sorts to apply when listing a file's user activities.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
- Returns UserActivityResultConnection.
### filesummariescount
Returns the counts of used and unused files categorized by risk level.

- There is a single argument of type System.String.
- Returns FilesSummaryCountResultType.
### flagrfeatureflagnames
Get names of checkr-flagr feature flags that are surfaced in APIs

- The flagrfeatureflagnames subcommand takes no arguments.
- Returns list of System.Strings.
### generatecontent
Generate content for a query.

- There are 2 arguments.
    - chatUsage - ChatUsage: The usage of the chat.
    - query - System.String: The query to input.
- Returns GenerateContentReply.
### geolocationlist
- The geolocationlist subcommand takes no arguments.
- Returns list of GroupCounts.
### getaccountsettingvalue
Obtain account settings value.

- There are 2 arguments.
    - aspName - System.String: Name of Account Setting Parameter (ASP) in account setting table.
    - aspComponent - ComponentEnum: Name of component that uses ASP in account setting table.
- Returns ASPValue.
### getaccountsettingvaluewithdefault
Obtains account settings value. Returns a default value when it is not set in the account setting table.

- There are 3 arguments.
    - aspName - System.String: Name of Account Setting Parameter (ASP) in account setting table.
    - aspComponent - ComponentEnum: Name of component that uses ASP in account setting table.
    - aspDefaultValue - System.String: Default value of ASP to use if it is absent in account setting table.
- Returns ASPValue.
### getallrolesinorglist
- There are 8 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
    - sortOrder - SortOrder: Sort order of result.
    - sortBy - RoleFieldEnum
    - nameFilter - System.String: Name to filter the results.
    - assignedRoleIds - list of System.Strings: List of role IDs that have already been assigned to a set of users. This list will be used to sort the set of all roles.
- Returns RoleConnection.
### getcdmreleasedetailsforversionfromsupportportal
Get CDM release details from support portal for a given list of clusters specific to a target version.

- There are 7 arguments.
    - listClusterUuid - list of System.Strings: Specifies the list of cluster UUIDs.
    - filterVersion - System.String: Prefix filter for available versions.
    - fetchLinks - System.Boolean: Retrieves version details.
    - filterUpgradeable - System.Boolean: Filters for the available upgrade versions.
    - shouldShowAll - System.Boolean: Shows all versions.
    - filterAfterSource - System.Boolean: Filter to include only the versions released after the source version.
    - sortOrder - SortOrder: Sort order of result.
- Returns CdmUpgradeReleaseDetailsFromSupportPortalReply.
### getcdmreleasedetailsfromsupportportal
Get available versions on support portal for a cluster.

- There are 9 arguments.
    - platform - System.String: Platform type of the cluster.
    - nodeCount - System.Int64: Number of nodes in the cluster.
    - sourceVersion - System.String: Source version of the cluster.
    - filterVersion - System.String: Prefix filter for available versions.
    - fetchLinks - System.Boolean: Retrieves version details.
    - filterUpgradeable - System.Boolean: Filters for the available upgrade versions.
    - shouldShowAll - System.Boolean: Shows all versions.
    - filterAfterSource - System.Boolean: Filter to include only the versions released after the source version.
    - sortOrder - SortOrder: Sort order of result.
- Returns CdmUpgradeReleaseDetailsFromSupportPortalReply.
### getcloudobjectscountbyregion
Get a count of cloud objects by region

- The getcloudobjectscountbyregion subcommand takes no arguments.
- Returns GetCloudObjectsCountByRegionReply.
### getdns
Get DNS server addresses.

- The getdns subcommand takes no arguments.
- Returns list of System.Strings.
### getgroupcountbyprechecksstatus
- The getgroupcountbyprechecksstatus subcommand takes no arguments.
- Returns list of GroupCounts.
### getgroupcountbyupgradejobstatus
- The getgroupcountbyupgradejobstatus subcommand takes no arguments.
- Returns list of GroupCounts.
### getgroupcountbyversionstatus
- The getgroupcountbyversionstatus subcommand takes no arguments.
- Returns list of GroupCounts.
### getkorgtaskchainstatus
- There is a single argument of type System.String.
- Returns GetTaskchainStatusReply.
### getlaminarfeaturestatus
Retrieve the status of laminar feature enablement for various cloud types

- The getlaminarfeaturestatus subcommand takes no arguments.
- Returns GetLaminarFeatureStatusReply.
### getmountdetails
Returns the details of mount disks.

- There is a single argument of type GetMountDetailsInput.
- Returns GetMountDetailsReply.
### getntp
Get NTP server addresses.

- The getntp subcommand takes no arguments.
- Returns list of System.Strings.
### getobjectprotectionandsensitivitysummary
Get object protection and sensitivity summary

- There is a single argument of type list of ManagedObjectTypes.
- Returns GetObjectProtectionAndSensitivitySummaryReply.
### getpermissions
Permissions assigned to the role that are in effect.

- There is a single argument of type System.String.
- Returns list of Permissions.
### getrolesbyids
- There is a single argument of type list of System.Strings.
- Returns list of Roles.
### getssowizardinfo
- The getssowizardinfo subcommand takes no arguments.
- Returns GetSSOWizardInfoReply.
### getuserdownloads
- There are 4 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
- Returns list of UserDownloads.
### globalfilesearch
All files matching input filters.

- There is a single argument of type GlobalFileSearchInput.
- Returns GlobalFileSearchReply.
### globallockoutconfig
Get the lockout configurations of the global organization.

- The globallockoutconfig subcommand takes no arguments.
- Returns LockoutConfig.
### globalmfasetting
Get global multifactor authentication (MFA) for an account.

- The globalmfasetting subcommand takes no arguments.
- Returns GetMfaSettingReply.
### globalobjectlocations
Get a list of object locations.

- There are 7 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
    - reportRoom - ReportRoomType: Room of the report view.
    - globalObjectLocationsFilters - list of GlobalObjectLocationsFilterInputs: A list of filters to filter locations.
    - shouldIncludePath - System.Boolean: Specifies whether the query result should include the path of a location.
- Returns GlobalObjectLocationConnection.
### globalsearchresults
- There are 7 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
    - sortBy - HierarchySortByField: Sort hierarchy objects according to the hierarchy field.
    - sortOrder - SortOrder: Sort order of result.
    - filter - list of Filters: The hierarchy object filter.
- Returns HierarchyObjectConnection.
### groupedreleasesnotes
List of release notes grouped by release and type.

- There are 6 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
    - version - System.String: Specifies the release version of the Release Note group.
    - filters - ReleaseNotesFiltersInput: Filter for release notes.
- Returns GroupedReleaseNoteConnection.
### groupsincurrentanddescendantorganization
Retrieve groups from current and descendant organizations based on the specified filters.

- There are 7 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
    - filter - GroupFilterInput: Specifies user group filters.
    - sortBy - GroupSortByParam: Specifies sort parameter.
    - shouldIncludeGroupsWithoutRole - System.Boolean: Specifies whether to include user groups without any assigned roles either in the current or descendant orgs. If roleIdsFilter is not empty, this field is always considered as false.
- Returns GroupConnection.
### guestcredentials
- There is a single argument of type QueryGuestCredentialInput.
- Returns GuestCredentialDetailListResponse.
### guestcredentialsv2
Get Guest OS credentials.

- There are 4 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - filter - list of GuestOsCredentialFilterInputs: Filter for Guest OS credentials.
    - sortBy - GuestOsCredentialSortBy: Sort Guest OS credentials.
- Returns GuestOsCredentialConnection.
### hasidpconfigured
Determine whether the current organization has configured identity providers.

- The hasidpconfigured subcommand takes no arguments.
- Returns System.Boolean.
### helpcontentsnippets
Paginated list of help content snippets.

- There are 5 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
    - filter - HelpContentSnippetsFilterInput: Filter for help content snippets.
- Returns HelpContentSnippetConnection.
### hierarchyobject
- There are 2 arguments.
    - fid - System.String: The Rubrik UUID for the object.
    - workloadHierarchy - WorkloadLevelHierarchy: Each enumeration value represents the hierarchy of a specific workload type for RBAC and SLA Domain assignments. The None value represents the hierarchy of all workload types.
- Returns HierarchyObject.
### hierarchyobjects
- There are 2 arguments.
    - fids - list of System.Strings: The Rubrik UUIDs for the objects.
    - filter - list of Filters: The hierarchy object filter.
- Returns list of HierarchyObjects.
### installedversionlist
- The installedversionlist subcommand takes no arguments.
- Returns list of InstalledVersionGroupCounts.
### inventoryroot
- The inventoryroot subcommand takes no arguments.
- Returns InventoryRoot.
### inventorysubhierarchyroot
- There is a single argument of type InventorySubHierarchyRootEnum.
- Returns InventorySubHierarchyRoot.
### inventoryworkloads
All account level inventory workloads.

- The inventoryworkloads subcommand takes no arguments.
- Returns list of InventoryCards.
### investigationcsvdownloadlink
Link to downloadable investigation results in CSV format.

- There are 3 arguments.
    - clusterUuid - System.String: The Rubrik cluster ID.
    - workloadId - System.String: ID of the object and not the FID.
    - snapshotId - System.String: Corresponds to snapshot ID in Rubrik CDM tables.
- Returns InvestigationCsvDownloadLinkReply.
### iocfeedentries
Lists IOC entries for a threat feed.

- There are 8 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
    - providerId - System.String: ID of threat feed
    - threatFeedType - list of ThreatFeedTypes: Type of IOCs to return
    - feedEntryStatusFilter - FeedEntryStatusFilter: Filter feed entries by entry status.
    - feedEntrySort - FeedEntrySort: Sorts feed entries
- Returns IocFeedEntryConnection.
### ipwhitelist
- The ipwhitelist subcommand takes no arguments.
- Returns GetWhitelistReply.
### isipmienabled
Check if IPMI is enabled on the cluster.

- There is a single argument of type IsIpmiEnabledInput.
- Returns System.Boolean.
### isllmenabled
Returns whether the account has enabled LLMs.

- The isllmenabled subcommand takes no arguments.
- Returns GetLlmEnabledReply.
### isloggedintorubriksupportportal
Is Logged into Rubrik support portal.

- The isloggedintorubriksupportportal subcommand takes no arguments.
- Returns SupportPortalStatusReply.
### isreplacenodetprconfigured
Check if Replace Cluster Node Quorum Authorization policy is set on the cluster.

- There is a single argument of type System.String.
- Returns System.Boolean.
### issfdcreachable
Is Rubrik Suppport Portal reachable from this deployment.

- There are 2 arguments.
    - hostname - System.String: Hostname to access the Support portal.
    - organizationId - System.String: Support portal organization ID.
- Returns System.Boolean.
### issue
Returns details of one issue.

- There is a single argument of type System.String.
- Returns Issue.
### issues
Returns all issues filtered by status.

- There are 5 arguments.
    - status - IssueStatus
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
- Returns IssueConnection.
### issuesjobids
List IDs of running SONAR issues jobs.

- There is a single argument of type list of System.Strings.
- Returns list of System.Strings.
### isupgradeavailable
Is upgrade available for a particular cluster.

- There is a single argument of type System.String.
- Returns CdmUpgradeAvailabilityReply.
### isupgraderecommended
Is upgrade recommended for a particular cluster.

- There is a single argument of type System.String.
- Returns CdmUpgradeRecommendationReply.
### iszrsavailableforlocation
Checks if Zone Redundant Storage (ZRS) is available for a given combination of account, region, subscription and service tier.

- There are 3 arguments.
    - serviceTier - ServiceTier: The service tier of the database.
    - region - AzureNativeRegion: The azure region.
    - subscriptionId - System.String: Subscription ID.
- Returns ZrsAvailabilityReply.
### jirachangesummary
Returns the change summary across an Atlassian site.

- There are 4 arguments.
    - siteId - System.String: Rubrik ID of the Atlassian site.
    - jiraObjectType - JiraObjectType: Jira object type.
    - timezoneOffset - System.Single: Offset based on customer timezone.
    - duration - PastNdayScope: The scope of the query, defined in past number of days.
- Returns ChangeSummary.
### jiraissueassignees
Issue assignees in a Jira project.

- There are 8 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
    - siteId - System.String: Rubrik ID of the Atlassian site.
    - sortBy - JiraUserSortByField: Field to sort Jira users by.
    - sortOrder - SortOrder: Sort order of result.
    - searchTerm - System.String: The search term by which results will be filtered.
- Returns AtlassianUserConnection.
### jiraissuechangedetails
Returns the Jira issue change details across an Atlassian site.

- There are 9 arguments.
    - siteId - System.String: Rubrik ID of the Atlassian site.
    - startTime - DateTime: Start time of the day for which changes are aggregated.
    - filter - JiraIssueChangeDetailsFilter: Input for filtering a list of Jira project change details.
    - sortBy - JiraIssueChangeDetailsSortByField: Field used to sort Jira issue change summary.
    - sortOrder - SortOrder: Sort order of result.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
- Returns AppItemChangeCountConnection.
### jiraissuechangesummary
Returns the Jira issue change summary across an Atlassian site.

- There are 3 arguments.
    - siteId - System.String: Rubrik ID of the Atlassian site.
    - startTime - DateTime: Start time of the day for which changes are aggregated.
    - filter - JiraIssueChangeDetailsFilter: Input for filtering a list of Jira project change details.
- Returns ChangeSummary.
### jiraissues
Jira issues in a Jira project.

- There are 8 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
    - jiraProjectId - System.String: The Rubrik ID of the Jira project.
    - sortBy - JiraIssueSortByField: Field to sort Jira issues by.
    - sortOrder - SortOrder: Sort order of result.
    - filter - JiraIssueFilterInput: Input for filtering a list of Jira issues.
- Returns JiraIssueConnection.
### jiraissuetypes
Jira issue types.

- There is a single argument of type System.String.
- Returns list of JiraIssueTypes.
### jiraprojectcomponents
Jira project components in an Atlassian site.

- There are 8 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
    - siteId - System.String: Rubrik ID of the Atlassian site.
    - sortBy - JiraProjectComponentsSortByField: Field used to sort Jira components.
    - filter - JiraProjectComponentsFilterInput: Input for filtering a list of Jira project components.
    - sortOrder - SortOrder: Sort order of result.
- Returns JiraProjectComponentConnection.
### jiraprojectleads
Project leads in an Atlassian site.

- There are 8 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
    - siteId - System.String: Rubrik ID of the Atlassian site.
    - sortBy - JiraUserSortByField: Field to sort Jira users by.
    - sortOrder - SortOrder: Sort order of result.
    - searchTerm - System.String: The search term by which results will be filtered.
- Returns AtlassianUserConnection.
### jiraprojects
Jira projects in an Atlassian site.

- There are 8 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
    - siteId - System.String: Rubrik ID of the Atlassian site.
    - sortBy - HierarchySortByField: Sort hierarchy objects according to the hierarchy field.
    - sortOrder - SortOrder: Sort order of result.
    - filter - list of Filters: The hierarchy object filter.
- Returns JiraProjectConnection.
### jirasettings
List of Jira settings of the given type.

- There are 9 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
    - siteId - System.String: Rubrik ID of the Atlassian site.
    - jiraSettingsType - JiraSettingsType: Type of the settings to retrieve.
    - sortBy - JiraSettingsSortByField: Field to sort Jira settings by.
    - sortOrder - SortOrder: Sort order of result.
    - filter - JiraSettingsFilterInput: Input for filtering a list of Jira settings.
- Returns JiraSettingsConnection.
### jirasettingschangedetails
Returns details of changes for Jira settings across an Atlassian site.

- There are 9 arguments.
    - siteId - System.String: Rubrik ID of the Atlassian site.
    - startTime - DateTime: Start time of the day for which changes are aggregated.
    - filter - JiraSettingsChangeDetailsFilter: Input for filtering a list of Jira settings change details.
    - sortBy - JiraSettingsChangeDetailsSortByField: Field used to sort Jira settings change summary.
    - sortOrder - SortOrder: Sort order of result.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
- Returns AppItemChangeCountConnection.
### jirasettingschangesummary
Returns the Jira issue change summary across an Atlassian site.

- There are 3 arguments.
    - siteId - System.String: Rubrik ID of the Atlassian site.
    - startTime - DateTime: Start time of the day for which changes are aggregated.
    - filter - JiraSettingsChangeDetailsFilter: Input for filtering a list of Jira settings change details.
- Returns ChangeSummary.
### jobinfo
Information about a job running on CDM. Note that some types of jobs cannot be queries using this field. Refer to `JobType` enum to see which jobs types are available. Only users with Admin or Owner roles are allowed to access the field.

- There is a single argument of type JobInfoRequest.
- Returns JobInfo.
### jobinstance
REQUIRES SUPPORT TOKEN - Get details about a job instance

Supported in v5.0+
REQUIRES SUPPORT TOKEN - Retrieve the following information about job instance- ID of job instance, job status, error details, start time of job, end time of job, job type, ID of the node and job progress. A support token is required for this operation.

- There is a single argument of type GetJobInstanceInput.
- Returns InternalJobInstanceDetail.
### kmipserverlist
Filter KMIP Servers.

- There are 7 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
    - sortOrder - SortOrder: Sort order of result.
    - serverAddressArg - System.String: The URL address of the KMIP server.
    - kmipServerClustersArg - list of System.Strings: The IDs of the Rubrik clusters that use the KMIP server.
- Returns KmipServerConnection.
### kmsinstances
Get all KMS instances.

- There are 8 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
    - sortOrder - SortOrder: Sort order of result.
    - kmsSortBy - KmsInstancesSortBy: The order to sort the KMS instances.
    - kmsName - System.String: The prefix of the name of the KMS instance.
    - kmsTypeFilter - list of KmsTypes: The type of KMS instance to filter.
- Returns KmsInstanceConnection.
### knowledgebasearticle
A knowledge base article.

- There is a single argument of type System.String.
- Returns KnowledgeBaseArticle.
### kubernetesnamespacelist
Kubernetes namespace connection.

- There are 4 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - sortBy - KubernetesNamespaceSortByInput: Sort by argument for Kubernetes namespaces.
    - kubernetesClusterId - System.String: Kubernetes cluster UUID.
- Returns KubernetesNamespaceConnection.
### kubernetesprotectionset
Summary of a Kubernetes Protection Set.

- There is a single argument of type System.String.
- Returns KubernetesProtectionSet.
### kubernetesprotectionsets
Summary of all Kubernetes Protection Sets.

- There are 6 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - sortBy - HierarchySortByField: Sort hierarchy objects according to the hierarchy field.
    - sortOrder - SortOrder: Sort order of result.
    - filter - list of Filters: The hierarchy object filter.
    - k8sClusterOptionalId - System.String: Kubernetes cluster optional UUID.
- Returns KubernetesProtectionSetConnection.
### lambdasettings
- The lambdasettings subcommand takes no arguments.
- Returns LambdaSettings.
### latestconfigprotectionbackupsbyversion
Cluster with latest configuration backup.

- There is a single argument of type LatestConfigBackupFilterInput.
- Returns list of LatestConfigProtectionBackupss.
### latestinsightsync
Most recent time insights from Sentry AI were synced for the account.

- The latestinsightsync subcommand takes no arguments.
- Returns GetLastInsightSyncReply.
### licensedetails
Retrieves the license details for a product.

- There is a single argument of type LicenseDetailsInput.
- Returns list of LicenseDetailss.
### licensedproducts
Information about the licenses at the product level.

- The licensedproducts subcommand takes no arguments.
- Returns GetLicensedProductsInfoReply.
### licenseinsights
Retrieves the license insights.

- There is a single argument of type list of LicenseProducts.
- Returns GetLicenseInsightsReply.
### licenseproductusage
Retrieves the most recent product usage data.

- There is a single argument of type LicenseProduct.
- Returns GetLicenseProductUsageReply.
### listnasautomigrationtasks
List NAS Automigration tasks.

- The listnasautomigrationtasks subcommand takes no arguments.
- Returns NasAutomigrationTaskList.
### listrecentlyviewed
The viewed history for users searches.

- There is a single argument of type SearchComponent.
- Returns RecentlyViewedItem.
### llmoperations
List of operations initiated by the LLM.

- There are 5 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
    - chatId - System.String: The ID of the chat.
- Returns LlmOperationConnection.
### lockoutconfig
Get the lockout configurations of the current organization.

- The lockoutconfig subcommand takes no arguments.
- Returns LockoutConfig.
### malwaredetectiontaskresult
Get the result of a completed detection

Supported in v6.0+
Get the details of a completed malware detection.

- There is a single argument of type GetLambdaDetectMalwareResultInput.
- Returns MalwareScanResults.
### malwaredetectiontaskstatus
Get the result of a completed detection

Supported in v6.0+
Get the details of a completed malware detection.

- There is a single argument of type GetLambdaDetectMalwareRequestStatusInput.
- Returns AsyncRequestStatus.
### malwarescandetail
Get asynchronous request details for a malware detection

Supported in v6.0+
Get the details of an asynchronous malware detection.

- There is a single argument of type GetLambdaMalwareScanDetailInput.
- Returns GetLambdaMalwareScanDetailReply.
### malwarescans
List malware scans

Supported in v6.0+
List the malware scans.

- There is a single argument of type ListMalwareScansInput.
- Returns MalwareScanDetailListResponse.
### mandatorytotpgraceperiod
Get mandatory TOTP settings for an account.

- The mandatorytotpgraceperiod subcommand takes no arguments.
- Returns mandatoryTotpGracePeriod.
### maxprotectedappscount
Maximum number of protected apps that can be added per account.

- The maxprotectedappscount subcommand takes no arguments.
- Returns System.Int32.
### mfasetting
Get multifactor authentication (MFA) settings for an account.

- The mfasetting subcommand takes no arguments.
- Returns GetMfaSettingReply.
### migrationchoiceregistered
Get the customer type for migration.

- The migrationchoiceregistered subcommand takes no arguments.
- Returns MigrationChoiceRegisteredReply.
### migrationcustomer
Get the customer type for migration.

- The migrationcustomer subcommand takes no arguments.
- Returns MigrationCustomer.
### migrationmetadata
Get migration metadata of CDM clusters.

- The migrationmetadata subcommand takes no arguments.
- Returns list of MigrationMetadatas.
### migrationprechecks
Get all the prechecks for the CDM clusters.

- There is a single argument of type PrechecksFilterInput.
- Returns list of Precheckss.
### migrationsupportcase
Get migration support case details.

- The migrationsupportcase subcommand takes no arguments.
- Returns MigrationSupportCase.
### minimumcdmversionforfeatureset
Get minimum cluster version to support feature set.

- There is a single argument of type FeatureListMinimumCdmVersionInputType.
- Returns FeatureListMinimumCdmVersionReply.
### networkthrottle
Network Throttle Information.

- There is a single argument of type QueryNetworkThrottleInput.
- Returns NetworkThrottleSummaryListResponse.
### nfanomalyresults
Results for Non-Filesystem Anomaly Investigations.

- There are 8 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
    - sortOrder - SortOrder: Sort order of result.
    - sortBy - NfAnomalyResultSortBy: Sort non-filesystem anomaly results by field.
    - filter - NfAnomalyResultFilterInput: Filter non-filesystem anomaly results by input.
    - timezoneOffset - System.Single: Offset based on customer timezone.
- Returns NfAnomalyResultConnection.
### nfanomalyresultsgrouped
Results for Non-Filesystem Anomaly Investigations grouped by an argument.

- There are 7 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
    - groupBy - NfAnomalyResultGroupBy: Group non-filesystem anomaly results by field.
    - filter - NfAnomalyResultFilterInput: Filter non-filesystem anomaly results by input.
    - timezoneOffset - System.Single: Offset based on customer timezone.
- Returns NfAnomalyResultGroupedDataConnection.
### nodekeyrotation
Get latest key rotation for a Rubrik cluster.

- There are 9 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
    - sortOrder - SortOrder: Sort order of result.
    - clusterID - System.String: The ID of the cluster.
    - nodeID - System.String: The name of the node.
    - rotationStates - list of CdmKeyRotationStates: The state of the rotation.
    - nodeSortBy - NodeKeyRotationSortBy: The order to sort the nodes.
- Returns NodeKeyRotationConnection.
### noderemovalcancelpermission
Check if the running node-removal job is cancelable.

- There is a single argument of type NodeRemovalCancelPermissionInput.
- Returns NodeRemovalCancelPermissionReply.
### nodetoreplace
The ID of the Rubrik cluster node to replace.

- There is a single argument of type NodeToReplaceInput.
- Returns NodeToReplaceReply.
### nodetunnelstatuses
List of node tunnel status.

- There is a single argument of type GetNodesInput.
- Returns NodeTunnelStatusConnection.
### nosqlstoragelocations
List of Mosaic Storage Locations used for NoSQL backups

- There are 3 arguments.
    - sortBy - MosaicStorageLocationQuerySortByField: Specification on how to sort a list of Mosaic Storage Locations.
    - sortOrder - SortOrder: Sort order of result.
    - filter - list of MosaicStorageLocationFilterInputs: Specification on how to filter a list of Mosaic Storage Locations.
- Returns list of MosaicStorageLocations.
### notifications
List notifications.

- There are 5 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
    - filter - NotificationListFilterInput: Filter for notifications.
- Returns NotificationConnection.
### oauthcodesforedgereg
Reply for request to download Rubrik Edge from Rubrik Security Cloud.

- There are 2 arguments.
    - numberOfEdges - System.Int32: Input to enter the number of Rubrik Edge installations.
    - cdmOvaLink - System.String: Input to enter the Rubrik CDM virtual cluster OVA package link.
- Returns OauthCodesForEdgeRegReply.
### objectfiles
- There are 8 arguments.
    - filter - ListObjectFilesFiltersInput
    - sort - FileResultSortInput
    - day - System.String: Date in the format (YYYY-MM-DD).
    - timezone - System.String
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
- Returns FileResultConnection.
### objectsalreadyassignedtoorgs
Returns objects that have already been assigned to existing orgs.

- There are 3 arguments.
    - objectIdsForHierarchyTypes - list of ObjectIdsForHierarchyTypeInputs: Objects for each workload type.
    - allowedClusters - list of System.Strings: Allowed clusters in the org.
    - targetOrgId - System.String: The ID of the target organization to compare the rules of the current organization.
- Returns list of ObjectIdsForHierarchyTypes.
### objecttypeaccesssummary
Returns total sensitive hits grouped by object type and also gives policy level breakdown for each object type.

- There are 10 arguments.
    - timelineDate - System.String: Date for which the results will be retrieved.
    - historicalDeltaDays - System.Int32: Historical days to go backward in time to calculate the delta.
    - includeWhitelistedResults - System.Boolean: Specifies whether whitelisted results should be included.
    - sortOrder - SortOrder: Sort order of result.
    - filter - ObjectTypeSummariesFilter: Filter for object type summary.
    - sort - ObjectTypeAccessSummarySortBy: Field on which to perform the sorting operation.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
- Returns ObjectTypeAccessSummaryConnection.
### org
Org details of the given org ID.

- There is a single argument of type System.String.
- Returns Org.
### orgnetwork
Retrieve organization network information for a specific ID.

- There is a single argument of type System.String.
- Returns OrgNetwork.
### orgnetworks
Retrieve organization networks information.

- There are 7 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
    - sortBy - OrgNetworkSortByField: Field to sort organization networks by.
    - sortOrder - SortOrder: Sort order of result.
    - filter - OrgNetworkFilterInput: Input for filtering a list of organization networks.
- Returns OrgNetworkConnection.
### orgs
All orgs.

- There are 9 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
    - sortOrder - SortOrder: Sort order of result.
    - sortBy - OrgField: Field in the org to sort orgs by.
    - nameFilter - System.String: Name to filter the results.
    - mfaEnforcedFilter - System.Boolean: Filter orgs by the status of MFA enforcement. When the field is not used, all orgs are returned. When the field is set to true, only orgs that have MFA enforced are returned. When the field is set to false, only orgs that do not have MFA enforced are returned.
    - crossAccountEnabledFilter - System.Boolean: Filter organizations based on their cross-account enablement status. When the field is not used, all organizations are returned. When set to true, only organizations with cross-account enabled are returned. When set to false, only organizations without cross-account enabled are returned.
- Returns OrgConnection.
### orgsbyids
Orgs of given IDs.

- There is a single argument of type list of System.Strings.
- Returns list of Orgs.
### orgsforprincipal
Returns the list of organizations to which the principal has access.

- There is a single argument of type System.String.
- Returns OrgsForPrincipalReply.
### pactsafecontract
Get Pactsafe contract state.

- There is a single argument of type ContractType.
- Returns PactsafeContract.
### pactsafeeulastate
Get EULA state.

- The pactsafeeulastate subcommand takes no arguments.
- Returns PactsafeEulaState.
### passkeyconfig
Passkey config for current org.

- The passkeyconfig subcommand takes no arguments.
- Returns GetPasskeyConfigReply.
### passkeyinfo
Information about passkey config and current user's passkeys.

- The passkeyinfo subcommand takes no arguments.
- Returns GetPasskeyInfoReply.
### pendingaction
- There is a single argument of type System.String.
- Returns pendingAction.
### pendingactions
Pending actions.

- There are 8 arguments.
    - clusterFilter - System.String: Cluster filter.
    - pendingActionGroupTypeFilter - list of PendingActionGroupTypeEnums: Pending action group type filter.
    - pendingActionSubGroupTypeFilter - list of PendingActionSubGroupTypeEnums: Pending action subgroup type filter.
    - statusFilter - list of PendingActionStatuss: Status filter.
    - objectIds - list of System.Strings: Object ids.
    - sortedOrder - SortOrder: Result ordering.
    - historyOnly - System.Boolean: History only.
    - limit - System.Int64: Limit.
- Returns list of pendingActions.
### phoenixrolloutprogress
Retrieve Phoenix rollout progress.

- There is a single argument of type System.String.
- Returns PhoenixRolloutProgress.
### pipelinehealthfortimerange
Get the health metric for the radar pipeline covering the backup, indexing, and analysis jobs.

- There are 2 arguments.
    - beginTime - DateTime: Filters results that started after this time.
    - endTime - DateTime: Filters results that started before this time.
- Returns GetPipelineHealthReply.
### polarisinventorysubhierarchyroot
- There is a single argument of type InventorySubHierarchyRootEnum.
- Returns PolarisInventorySubHierarchyRoot.
### policydetails
Returns active policies for an account.

- The policydetails subcommand takes no arguments.
- Returns PolicyDetailConnection.
### policyobj
Returns details for one policy object.

- There are 3 arguments.
    - snappableFid - System.String
    - snapshotFid - System.String
    - includeWhitelistedResults - System.Boolean: Specifies whether whitelisted results should be included.
- Returns PolicyObj.
### policyobjopt
Returns details for one policy object if it exists.

- There are 3 arguments.
    - snappableFid - System.String
    - snapshotFid - System.String
    - includeWhitelistedResults - System.Boolean: Specifies whether whitelisted results should be included.
- Returns PolicyObj.
### policyobjs
Returns status for all objects at a specified timestamp.

- There are 36 arguments.
    - day - System.String: Date in the format (YYYY-MM-DD).
    - timezone - System.String
    - workloadTypes - list of DataGovObjectTypes: Types of workloads that can be used for filtering query results.
    - sortBy - System.String: Name of the column to sort result by.
    - sortOrder - SortOrder: Sort order of result.
    - analysisStatusesFilter - list of AnalysisStatuss: List of analysis statuses used for filtering results.
    - policyIdsFilter - list of System.Strings: List of policies used for filtering results.
    - riskLevelsFilter - list of RiskLevelTypes: List of risk levels used for filtering results.
    - clusterIdsFilter - list of System.Strings: List of Rubrik clusters for filtering results.
    - searchObjectName - System.String: Object name to search.
    - subscriptionIdsFilter - list of System.Strings: List of subscriptions for filtering results.
    - includeWhitelistedResults - System.Boolean: Specifies whether whitelisted results should be included.
    - sids - list of System.Strings: Filter for the given list of security identifiers.
    - insightsMetadataId - System.String: Filter objects with insights metadata ID.
    - includeInsightsMarker - System.Boolean: Specifies whether to include the insights marker.
    - userAccessObjectsFilter - System.Boolean: Filter objects with user access enabled.
    - objectIdsFilter - list of System.Strings: Object IDs to filter.
    - platformFilter - list of Platforms: Platform to filter.
    - platformCategoryFilter - list of PlatformCategorys: Platform category to filter.
    - cloudAccountIdsFilter - list of System.Strings: Cloud account IDs to filter.
    - resourceGroupsFilter - list of System.Strings: Resource groups to filter.
    - regionsFilter - list of System.Strings: Regions to filter.
    - dataTypeIdsFilter - list of System.Strings: Data Type IDs to filter.
    - firstSeenTimeRange - UserTimeRangeInput: First seen time range specified in the local timezone of the user.
    - lastAccessTimeRange - UserTimeRangeInput: Last access time range specified in the local timezone of the user.
    - creationTimeRange - UserTimeRangeInput: Creation time range specified in the local timezone of the user.
    - objectTagsFilter - ObjectTagsFilterInput: Object tags associated with workloads as key-value pairs.
    - backupStatusFilter - list of BackupStatuss: Filter by backup status.
    - slaIdsFilter - list of System.Strings: Filter by SLA Domain IDs.
    - networkAccessFilter - list of NetworkAccesss: Filter by network access type.
    - encryptionFilter - list of Encryptions: Filter by encryption type.
    - loggingFilter - list of Loggings: Filter by logging type.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
- Returns PolicyObjConnection.
### postgresqldatabase
Details of a PostgreSQL database for a given FID.

- There is a single argument of type System.String.
- Returns PostgreSQLDatabase.
### postgresqldatabases
Connection of filtered postgres database based on specific filters.

- There are 5 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - sortBy - HierarchySortByField: Sort hierarchy objects according to the hierarchy field.
    - sortOrder - SortOrder: Sort order of result.
    - filter - list of Filters: The hierarchy object filter.
- Returns PostgreSQLDatabaseConnection.
### prechecksstatus
Gets status of last prechecks job.

- There is a single argument of type System.String.
- Returns PrechecksStatusReply.
### prechecksstatuswithnextjobinfo
Get status of last completed prechecks Job along with details of currently running/scheduled next prechecks Job.

- There is a single argument of type System.String.
- Returns PrechecksStatusReply.
### principaldetails
Get principal details.

- There are 3 arguments.
    - sid - System.String: Security identifier.
    - timelineDate - System.String: Date for which the results will be retrieved.
    - includeWhitelistedResults - System.Boolean: Specifies whether whitelisted results should be included.
- Returns PrincipalDetails.
### principalobjectsummaries
List of principal object summaries.

- There are 9 arguments.
    - sids - list of System.Strings: List of security identifiers.
    - filter - PrincipalObjectSummariesFilterInput: Filter to be applied when retrieving principal object summaries.
    - timelineDate - System.String: Date for which the results will be retrieved.
    - includeCount - System.Boolean: Include counts in the results.
    - includeWhitelistedResults - System.Boolean: Specifies whether whitelisted results should be included.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
- Returns PrincipalObjectSummaryConnection.
### principalriskchanges
Return the principals whose risk has changed.

- There are 5 arguments.
    - principalRiskSummaryPrincipalType - PrincipalRiskySummaryPrincipalType: Specifies the type of principal.
    - limit - System.Int32: Maximum number of entries in the response.
    - startTime - DateTime: Start time in ISO string format (YYYY-MM-DDThh:mm:ssZ).
    - endTime - DateTime: End time in ISO string format (YYYY-MM-DDThh:mm:ssZ).
    - includeWhitelistedResults - System.Boolean: Specifies whether whitelisted results should be included.
- Returns GetPrincipalRiskChangesReply.
### principalrisksummaries
Get principal risk summaries.

- There are 5 arguments.
    - queryDate - System.String: Date for which the principal risk summary is retrieved.
    - historicalDeltaDays - System.Int32: Historical days to go backward in time to calculate the delta.
    - principalRiskSummaryPrincipalType - PrincipalRiskySummaryPrincipalType: Specifies the type of principal.
    - includeWhitelistedResults - System.Boolean: Specifies whether whitelisted results should be included.
    - PrincipalSummaryFilterType - PrincipalSummaryFilter
- Returns GetPrincipalRiskSummaryReply.
### principalrisktrend
Return the date-wise risk summary of a principal.

- There are 6 arguments.
    - sid - System.String: Security identifier.
    - startTime - DateTime: Start time in ISO string format (YYYY-MM-DDThh:mm:ssZ).
    - endTime - DateTime: End time in ISO string format (YYYY-MM-DDThh:mm:ssZ).
    - policyId - System.String: Policy id.
    - includeWhitelistedResults - System.Boolean: Specifies whether whitelisted results should be included.
    - includeInsightsMarker - System.Boolean: Specifies whether to include the insights marker.
- Returns GetPrincipalRiskTrendReply.
### principalsummaries
List of principal summaries.

- There are 12 arguments.
    - filter - PrincipalSummariesFilterInput: Filter to be applied when retrieving principal summaries.
    - timelineDate - System.String: Date for which the results will be retrieved.
    - sort - ListPrincipalsSummarySortInput: Field on which to perform the sorting operation.
    - includeCount - System.Boolean: Include counts in the results.
    - historicalDeltaDays - System.Int32: Historical days to go backward in time to calculate the delta.
    - includeWhitelistedResults - System.Boolean: Specifies whether whitelisted results should be included.
    - insightsMetadataId - System.String: Filter objects with insights metadata ID.
    - includeInsightsMarker - System.Boolean: Specifies whether to include the insights marker.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
- Returns PrincipalSummaryConnection.
### privatecontainerregistry
Retrieves the Private Container Registry (PCR) details for an Exocompute cloud account.

- There is a single argument of type PrivateContainerRegistryInput.
- Returns PrivateContainerRegistryReplyType.
### productdocumentation
A product documentation.

- There is a single argument of type System.String.
- Returns ProductDocumentation.
### protectedobjectslist
List of all objects protected by the SLA Domains.

- There are 10 arguments.
    - rootOptionalFid - System.String: Forever UUID of the object root. The value of  `none` represents the global hierarchy root.
    - slaIds - list of System.Strings: A list of SLA Domain IDs.
    - filter - list of Filters: The hierarchy object filter.
    - objectTypeFilter - list of System.Strings: Types of objects to include.
    - sortBy - HierarchySortByField: Sort hierarchy objects according to the hierarchy field.
    - sortOrder - SortOrder: Sort order of result.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
- Returns ProtectedObjectsConnection.
### protectedvolumescount
Total number of protected volumes across all hosts.

- There is a single argument of type list of Filters.
- Returns System.Int32.
### protectionsummary
- The protectionsummary subcommand takes no arguments.
- Returns ProtectionSummary.
### quarantineddetailsforworkload
Quarantine details of a workload.

- There is a single argument of type System.String.
- Returns list of QuarantineSpecs.
### querydatastorefreespacethresholds
Query datastore threshold configurations.

- There is a single argument of type list of QueryDatastoreFreespaceThresholdInputs.
- Returns QueryDatastoreFreespaceThresholdsReply.
### recoverypermissioncheck
Get information about permissions on the specific orchestrated recoveries.

- There is a single argument of type RecoveryPermissionCheckInput.
- Returns RecoveryPermissionCheckReply.
### recoveryplan
Recovery Plan.

- There is a single argument of type System.String.
- Returns RecoveryPlan.
### recoveryplanpermissioncheck
Get information about permissions on the specific Recovery Plans.

- There is a single argument of type RecoveryPlanPermissionCheckInput.
- Returns RecoveryPlanPermissionCheckReply.
### recoveryplans
List Recovery Plans based on filters.

- There are 6 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - sortBy - HierarchySortByField: Sort hierarchy objects according to the hierarchy field.
    - sortOrder - SortOrder: Sort order of result.
    - filter - list of Filters: The hierarchy object filter.
    - fids - list of System.Strings: The Rubrik UUIDs for the objects.
- Returns RecoveryPlanConnection.
### recoveryschedule
- There is a single argument of type GetRecoveryScheduleInput.
- Returns Schedule.
### regions
List of regions.

- There is a single argument of type System.String.
- Returns list of System.Strings.
### releasenote
Get a release note with the specified ID.
               A release note ID can be pulled from a ReleaseNote object
               and a list of release notes can be obtained by using the existing
               releasesNotes and groupedReleasesNotes endpoints.
            

- There is a single argument of type System.String.
- Returns ReleaseNote.
### releasesnotes
List of release notes matching the specified filter.

- There are 6 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
    - query - System.String: The keyword to search for release notes.
    - filters - ReleaseNotesFiltersInput: Filter for release notes.
- Returns ReleaseNoteConnection.
### removednodedetails
Get the information for removed nodes.

- There is a single argument of type RemovedNodeDetailsInput.
- Returns RemoveNodeDetailsReply.
### replicatedobjects
Lists all objects related by replication.

- There is a single argument of type GetReplicatedObjectsRequest.
- Returns list of ReplicatedObjectInfos.
### resourcegroups
List of resource groups.

- There is a single argument of type System.String.
- Returns list of ResourceGroupInfos.
### roletemplates
The list of available role templates.

- There are 5 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
    - nameFilter - System.String: Name to filter the results.
- Returns RoleTemplateConnection.
### rscautoupgradeinfo
Get RSC auto upgrade info.

- The rscautoupgradeinfo subcommand takes no arguments.
- Returns RscAutoUpgradeInfo.
### runningjobsstatus
Status of all running jobs for an account.

- The runningjobsstatus subcommand takes no arguments.
- Returns RunningJobsReply.
### saasappcascadeimpactkeys
Returns the keys of the items that are impacted by a given restore operation.

- There are 8 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
    - orgId - System.String: The Rubrik ID of the SaaS organization.
    - operationId - System.String: The ID of the cascading impact job.
    - pathIdentifier - System.String: The unique identifier for the path to the cascade impact summary.
    - cascadeActionType - CascadingImpactActionType: The different types of actions that can be performed on the keys to be restored.
- Returns SaasAppCascadeImpactKeysConnection.
### saasappcascadingimpact
Returns the list of object types that can be potentially impacted/restored when restoring the selected objects.

- There are 4 arguments.
    - saasAppType - SaasAppType: SaaS application type.
    - restoreConfig - AppItemRestoreConfig: Configuration for the items to be restored.
    - resolutionMode - CascadingImpactResolutionMode: The mode of cascading impact resolution. By default, the mode is set to `SYNCHRONOUS`.
    - stateToken - System.String: Token storing the current state of the current flow.
- Returns CascadingImpactResult.
### saasappcascadingimpactjobresult
Returns the status of the job and the list of object types that can be potentially impacted/restored when restoring the selected objects.

- There are 2 arguments.
    - orgId - System.String: The Rubrik ID of the SaaS organization.
    - operationId - System.String: The ID of the cascading impact job.
- Returns CascadingImpactJobResultReply.
### saasapporganizations
List of SaaS app organization.

- There are 9 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
    - sortBy - HierarchySortByField: Sort hierarchy objects according to the hierarchy field.
    - sortOrder - SortOrder: Sort order of result.
    - filter - list of Filters: The hierarchy object filter.
    - typeFilter - list of HierarchyObjectTypeEnums: Types of objects to include.
    - recoveryTargetFilter - RecoveryTargetFilter: Filter for organizations that are valid recovery targets for a source organization.
- Returns SaasAppsOrganizationConnection.
### saasapporgdetails
RSC details for a SaaS app organization.

- There are 2 arguments.
    - orgId - System.String: The Rubrik ID of the SaaS organization.
    - saasAppType - SaasAppType: SaaS application type.
- Returns SaasAppsOrganization.
### saasappschangesummary
Returns the change summary for the requested app item tokens or analyze object type.

- There are 5 arguments.
    - orgId - System.String: The Rubrik ID of the SaaS organization.
    - saasAppAnalyzeObjectTypes - list of SaasAppAnalyzeObjectTypes: Saas App object types to analyze.
    - timezoneOffset - System.Single: Offset based on customer timezone.
    - duration - PastNdayScope: The scope of the query, defined in past number of days.
    - appItemTypeTokens - list of System.Strings: Token[s] specifying the type of the data items. The tokens should match the tokens retrieved by the GraphQL query.
- Returns ChangeSummary.
### saasappsstorageregions
List of supported storage regions for backup data.

- There is a single argument of type SaasAppType.
- Returns SaasAppsRegionsReply.
### saasbackupjobinformation
Returns backup job information for a SaaS app.

- There are 4 arguments.
    - orgId - System.String: The Rubrik ID of the SaaS organization.
    - timezoneOffset - System.Single: Offset based on customer timezone.
    - duration - PastNdayScope: The scope of the query, defined in past number of days.
    - saasAppType - SaasAppType: SaaS application type.
- Returns OrgBackupJobInformation.
### saasconnectionstatus
Returns the connection status of a SaaS app.

- There are 2 arguments.
    - orgId - System.String: The Rubrik ID of the SaaS organization.
    - saasAppType - SaasAppType: SaaS application type.
- Returns ConnectionStatus.
### saaslicensedetails
Returns the SaaS license details.

- There are 2 arguments.
    - orgId - System.String: The Rubrik ID of the SaaS organization.
    - saasAppType - SaasAppType: SaaS application type.
- Returns SaasLicenseDetails.
### salesforcemetadatachangedetails
The change details for metadata components on a given day.

- There are 10 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
    - orgId - System.String: Rubrik ID of the Salesforce organization.
    - metadataType - System.String: The type of the Salesforce metadata components.
    - startTime - DateTime: Start time of the day for which changes are aggregated.
    - sortBy - SalesforceMetadataChangeDetailsSortByField: Field name to sort Salesforce metadata components.
    - filter - MetadataChangeFilter: Input for filtering records of the Salesforce Metadata Type for which RSC is calculating the summary changes.
    - sortOrder - SortOrder: Sort order of result.
- Returns MetadataComponentChangeConnection.
### salesforcemetadatachangesummary
The change summary for a given Salesforce metadata type.

- There are 4 arguments.
    - orgId - System.String: Rubrik ID of the Salesforce organization.
    - metadataType - System.String: The type of the Salesforce metadata components.
    - startTime - DateTime: Start time of the day for which changes are aggregated.
    - filter - MetadataChangeFilter: Input for filtering records of the Salesforce Metadata Type for which RSC is calculating the summary changes.
- Returns ChangeSummary.
### salesforcemetadatacomponents
The metadata components of a given metadata type in the Salesforce organization.

- There are 9 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
    - orgId - System.String: Rubrik ID of the Salesforce organization.
    - metadataType - System.String: The type of the Salesforce metadata components.
    - sortBy - SalesforceMetadataComponentsSortByField: Field to sort Salesforce metadata components by.
    - filter - SalesforceMetadataComponentsFilterInput: Input for filtering a list of Salesforce metadata components.
    - sortOrder - SortOrder: Sort order of result.
- Returns SalesforceMetadataComponentConnection.
### salesforcemetadatatypes
The metadata types in the Salesforce organization.

- There are 8 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
    - orgId - System.String: Rubrik ID of the Salesforce organization.
    - sortBy - SalesforceMetadataTypesSortByField: Field to sort Salesforce metadata types by.
    - filter - SalesforceMetadataTypesFilterInput: Input for filtering a list of Salesforce metadata types.
    - sortOrder - SortOrder: Sort order of result.
- Returns SalesforceMetadataTypeConnection.
### salesforceobjectfields
The fields of a Salesforce object.

- There are 8 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
    - workloadId - System.String: The ID of the workload.
    - filter - SalesforceObjectFieldsFilterInput: Input for filtering a list of Salesforce object fields.
    - sortBy - SalesforceObjectFieldsSortByField: Field to sort Salesforce object fields by.
    - sortOrder - SortOrder: Sort order of result.
- Returns SalesforceObjectFieldConnection.
### salesforceobjectrecords
The records in a Salesforce object.

- There are 9 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
    - workloadId - System.String: The ID of the workload.
    - filter - SalesforceRecordsFilterInput: Input for filtering a list of Salesforce records.
    - sortBy - System.String: Field to sort Salesforce records by.
    - sortOrder - SortOrder: Sort order of result.
    - fieldNames - list of System.Strings: The list of fields for which the record values must be returned. An empty input returns values for the ID and name fields only.
- Returns SalesforceRecords.
### salesforceobjects
The objects in the Salesforce organization.

- There are 8 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
    - orgId - System.String: Rubrik ID of the Salesforce organization.
    - sortBy - HierarchySortByField: Sort hierarchy objects according to the hierarchy field.
    - filter - list of Filters: The hierarchy object filter.
    - sortOrder - SortOrder: Sort order of result.
- Returns SalesforceObjectConnection.
### salesforcerecordschangedetails
The change details for records on a given day.

- There are 10 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
    - workloadId - System.String: The ID of the workload.
    - startTime - DateTime: Start time of the day for which changes are aggregated.
    - filter - ObjectRecordsChangeFilter: Input for filtering records of the Salesforce object for which RSC is calculating the summary changes.
    - sortBy - System.String: Field name used to sort Salesforce records.
    - sortOrder - SortOrder: Sort order of result.
    - fieldNames - list of System.Strings: The list of fields for which the record values must be returned. An empty input returns values for the ID and name fields only.
- Returns SalesforceRecordsChangeDetails.
### salesforcerecordschangesummary
The change summary for records of a given Salesforce object.

- There are 3 arguments.
    - workloadId - System.String: The ID of the workload.
    - startTime - DateTime: Start time of the day for which changes are aggregated.
    - filter - ObjectRecordsChangeFilter: Input for filtering records of the Salesforce object for which RSC is calculating the summary changes.
- Returns ChangeSummary.
### searchfilebyprefix
Search file under given folder and with given prefix.

- There are 5 arguments.
    - clusterUuid - System.String: The Rubrik cluster ID.
    - managedId - System.String: Workload managed ID.
    - snapshotId - System.String: Corresponds to snapshot ID in Rubrik CDM tables.
    - searchFolderPath - System.String: Root path to search file inside FMD.
    - filenamePrefix - System.String: Filename prefix that should match.
- Returns DiffResult.
### searchiocs
Intel search response.

- There is a single argument of type list of System.Strings.
- Returns SearchIntelResponse.
### searchsnapmirrorcloud
Search for a file within the SnapMirrorCloud

Supported in v7.0+
Search for a file within the SnapMirrorCloud. The search can use the full path prefix or the filename prefix.

- There is a single argument of type SearchSnapMirrorCloudInput.
- Returns SearchResponseListResponse.
### searchvappfiles
Search for a file in a vApp.

- There are 3 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - input - SearchVappFilesInput: Fid of vApp and path to search for files.
- Returns AppSearchResponseConnection.
### searchvectordb
Search VectorDB.

- There is a single argument of type SearchVectorDBInput.
- Returns SearchVectorDBReply.
### serviceprovidermetadatafields
- The serviceprovidermetadatafields subcommand takes no arguments.
- Returns GetSPExplicitReply.
### singleunifiedfeatureflag
Evaluate the requested feature flag in the unified feature flag framework.

- There is a single argument of type UnifiedFeatureFlagInput.
- Returns UnifiedFeatureFlag.
### skippediteminfo
Gets skipped item information.

- There are 2 arguments.
    - workloadFid - System.String: Optional FID of the workload.
    - snapshotFid - System.String: The ID of the snapshot.
- Returns SkippedItemInfoResponse.
### smtpconfiguration
- The smtpconfiguration subcommand takes no arguments.
- Returns GetSMTPConfigurationReply.
### snapmirrorcloud
A SnapMirror Cloud.

- There is a single argument of type System.String.
- Returns SnapMirrorCloud.
### snoozeddirectories
Lists the snoozed directories for the account.

- There are 7 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
    - snoozeStatusFilter - list of SnoozeStatuss: Filter by snooze status.
    - directorySearchFilter - System.String: Optional directory search.
    - falsePositiveTypeFilter - list of AnomalyFalsePositiveTypes: Filter by false positive type.
- Returns SnoozedDirectoryConnection.
### sourceblueprintinfo
- There is a single argument of type System.String.
- Returns SourceBlueprintInfo.
### sourcerecoveryspecs
Source recovery specifications.

- There are 4 arguments.
    - workloadInfos - list of SnappableInfoTypes: The list of workload recovery points.
    - sourceLocation - LocationInfo: Source location.
    - blueprintId - System.String: The Blueprint ID.
    - planType - PlanName: Type of the Recovery Plan, PROD, TEST, or PROD_LOCAL.
- Returns list of SourceRecoverySpecsReplys.
### supportbundle
Get the status of generating support bundle

Supported in v5.0+
Given a request ID for generate support bundle request, provide the status of the request. If the request is successful, the download link for the support bundle would be included.

- There is a single argument of type QuerySupportBundleInput.
- Returns AsyncRequestStatus.
### supportportalrole
Rubrik Support portal role.

- The supportportalrole subcommand takes no arguments.
- Returns SupportPortalRole.
### supportuseraccesses
All support user access objects that satisfy the query criteria.

- There are 7 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
    - sortBy - SupportUserAccessSortByField: Sorting field for support access.
    - sortOrder - SortOrder: Sorting order for support access.
    - filters - list of SupportUserAccessFilterInputs: Specifies how to filter the list of targets.
- Returns SupportUserAccessConnection.
### tablefilters
- The tablefilters subcommand takes no arguments.
- Returns TableFilters.
### targets
List all targets.

- There are 4 arguments.
    - sortBy - ArchivalLocationQuerySortByField: Specifies the field by which the list of targets will be sorted.
    - sortOrder - SortOrder: Sort order of result.
    - filter - list of TargetFilterInputs: Specifies how to filter the list of targets.
    - contextFilter - ContextFilterTypeEnum: Specifies the context filter to use.
- Returns list of Targets.
### taskchain
Details of a taskchain.

- There is a single argument of type System.String.
- Returns Taskchain.
### taskchaininfo
- There are 2 arguments.
    - taskchainId - System.String: Taskchain uuid
    - jobType - System.String: Job type
- Returns TaskchainInfoReply.
### taskdetailgroupbylist
- There are 7 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
    - filter - TaskDetailFilterInput: Filter task summary by input.
    - groupBy - TaskDetailGroupByEnum: Group task detail by a field.
    - timezoneOffset - System.Single: Offset based on customer timezone.
- Returns TaskDetailGroupByConnection.
### taskdetaillist
- There are 8 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
    - filter - TaskDetailFilterInput: Filter task summary by input.
    - sortBy - TaskDetailSortByEnum: Sort task detail by field.
    - sortOrder - SortOrder: Task detail sort order.
    - timezoneOffset - System.Single: Offset based on customer timezone.
- Returns TaskDetailConnection.
### tasksummarygroupbylist
- There are 7 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
    - filter - TaskSummaryFilterInput: filter task summary by input
    - groupBy - TaskSummaryGroupByEnum: group task summary by a field
    - timezoneOffset - System.Single: Offset based on customer timezone.
- Returns TaskSummaryGroupByConnection.
### tasksummarylist
- There are 8 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
    - filter - TaskSummaryFilterInput: filter task summary by input
    - sortBy - TaskSummarySortByEnum: sort task summary by field
    - sortOrder - SortOrder: Sort order of result.
    - timezoneOffset - System.Single: Offset based on customer timezone.
- Returns TaskSummaryConnection.
### teamchannelnameavailable
Checks the availability of the channel name in the Team.

- There are 2 arguments.
    - teamUUID - System.String
    - channelName - System.String
- Returns System.Boolean.
### ticketcreators
List ticket creators.

- There is a single argument of type TicketCreatorsInput.
- Returns TicketCreatorsReply.
### ticketingplatforminfo
Retrieve ticketing platform information.

- There is a single argument of type TicketingPlatformInfoInput.
- Returns TicketingPlatformInfoReply.
### tickets
List all tickets.

- There are 5 arguments.
    - input - TicketsInput: Input for retrieving tickets.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
- Returns TicketConnection.
### toggleablefeaturesenabled
- The toggleablefeaturesenabled subcommand takes no arguments.
- Returns list of FeatureNames.
### topriskprincipals
Return policy summary for security identifiers.

- There are 3 arguments.
    - principalRiskSummaryPrincipalType - PrincipalRiskySummaryPrincipalType: Specifies the type of principal.
    - limit - System.Int32: Maximum number of entries in the response.
    - policyId - System.String: Policy id.
- Returns TopRiskPrincipalsReply.
### totpconfigstatus
Get TOTP configuration status for a user.

- There is a single argument of type System.String.
- Returns GetTotpStatusReply.
### tprconfiguration
Specifies the current two-person rule (TPR) configuration for an organization.

- There is a single argument of type System.String.
- Returns GetTprConfigurationReply.
### tprpublicconfiguration
Specifies the publicly available two-person rule (TPR) configuration for an organization.

- There is a single argument of type System.String.
- Returns TprConfigurationPublic.
### tprrequestdetail
Details for a TPR request.

- There is a single argument of type System.String.
- Returns TprRequestDetailReply.
### tprrequestsummaries
Details of TPR requests.

- There are 5 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
    - filter - TprRequestFilterInput: Specifies the TPR request filters.
- Returns TprRequestSummaryConnection.
### tprroleeligibility
Checks if a user can be assigned a TPR role.

- There are 2 arguments.
    - orgId - System.String: Specifies the organization ID.
    - email - System.String: Specifies the user's email.
- Returns TprRoleEligibilityType.
### tprrulesmap
Map of TPR policy types to TPR rules.

- The tprrulesmap subcommand takes no arguments.
- Returns TprRulesMap.
### tprstatusfornoderemoval
Check and update TPR request for node removal or replacement.

- There is a single argument of type TprStatusForNodeRemovalInput.
- Returns TprStatusForNodeRemoval.
### trials
Lists all trials for a given user.

- There are 2 arguments.
    - states - list of TrialStates: Trial states.
    - types - list of TrialTypes: Trial types.
- Returns list of Trials.
### trialusers
Returns the list of users associated with the trial.

- There is a single argument of type System.String.
- Returns list of TrialUsers.
### tunnelstatus
Check support tunnel status for a particular node

Supported in v5.0+
To be used by Admin to check status of the support tunnel.

- There is a single argument of type GetTunnelStatusInput.
- Returns SupportTunnelInfo.
### unaccesseduserssummary
UnAccessed users summaries.

- There are 9 arguments.
    - timePeriod - TimePeriod: Time period for the activity.
    - filter - unAccessedUsersSummaryFilterInput: un-accessed users summary filter.
    - sortBy - UnAccessedUsersSummarySortBy: Field on which to perform the sorting operation.
    - endTime - DateTime: End time in ISO string format (YYYY-MM-DDThh:mm:ssZ).
    - sortOrder - SortOrder: Sort order of result.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
- Returns UnAccessedDataUserSummaryConnection.
### unifiedfeatureflags
Evaluate all known feature flags in unified feature flag framework.

- The unifiedfeatureflags subcommand takes no arguments.
- Returns list of UnifiedFeatureFlags.
### uniquevcdcount
Number of unique vCloud Director instances.

- There is a single argument of type list of Filters.
- Returns System.Int32.
### unmanagedobjects
List of unmanaged objects.

- There are 5 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
    - input - UnmanagedObjectsInput: Query unmanaged objects.
- Returns UnmanagedObjectDetailConnection.
### unmanagedobjectssupportedtypes
List of supported object types.

- There are 2 arguments.
    - productType - ProductTargetType: Type of the product.
    - cloudVendor - CloudVendor: The cloud vendor type.
- Returns list of ManagedObjectTypes.
### unreadnotificationscount
Get unread notifications count.

- There is a single argument of type UnreadNotificationsCountInput.
- Returns System.Int32.
### upgradestatus
Gets the status for completed/running upgrade process.

- There is a single argument of type System.String.
- Returns UpgradeStatusReply.
### usagetimeseries
Retrieves product usage timeseries data.

- There is a single argument of type UsageTimeseriesInput.
- Returns UsageTimeseries.
### useraccessinsights
Return the user access insights for the given time range.

- There are 7 arguments.
    - startTime - DateTime: Start time in ISO string format (YYYY-MM-DDThh:mm:ssZ).
    - endTime - DateTime: End time in ISO string format (YYYY-MM-DDThh:mm:ssZ).
    - includeWhitelistedResults - System.Boolean: Specifies whether whitelisted results should be included.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
- Returns PrincipalInsightConnection.
### useraccessinsightticketdefaults
Default field values for user access insight ticket.

- There is a single argument of type UserAccessInsightTicketDefaultsInput.
- Returns UserAccessInsightTicketDefaultsReply.
### useraccessmetrics
User access metrics.

- The useraccessmetrics subcommand takes no arguments.
- Returns UserAccessMetrics.
### useractivities
- There are 8 arguments.
    - filter - ListObjectFilesFiltersInput
    - sort - FileResultSortInput
    - timeRange - UserTimeRangeInput: Time range specified in the user's local timezone.
    - userId - System.String
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
- Returns FileResultConnection.
### useranalyzeraccess
- There are 4 arguments.
    - userId - System.String
    - startDay - System.String: Start time, in string format (YYYY-MM-DD).
    - timezone - System.String
    - limit - System.Int32: Maximum number of entries in the response.
- Returns AnalyzerAccessUsageConnection.
### userauditgroupbylist
- There are 5 arguments.
    - sortOrder - SortOrder: User audit sort order.
    - sortBy - UserAuditSortByEnum: Sort user audit by field.
    - filters - UserAuditFilter
    - primaryGroupBy - UserAuditGroupBy: Primary field for grouping audits.
    - secondaryGroupBy - UserAuditGroupBy: Secondary field for grouping audits. This field is optional.
- Returns UserAuditGroupByInfoConnection.
### userauditlist
- There are 7 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
    - sortOrder - SortOrder: User audit sort order.
    - sortBy - UserAuditSortField: Sort user audit by field.
    - filters - UserAuditFilter
- Returns UserAuditConnection.
### userdetail
- There are 3 arguments.
    - userId - System.String
    - startDay - System.String: Start time, in string format (YYYY-MM-DD).
    - timezone - System.String
- Returns GetUserDetailReply.
### userfiles
All user files.

- There are 4 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
- Returns list of GetCustomerFacingDownloadsReplys.
### usergroups
- There are 5 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
    - roleIdsFilter - list of System.Strings
- Returns list of Groups.
### usernotifications
An object containing production notifications information for the current user.

- The usernotifications subcommand takes no arguments.
- Returns UserNotifications.
### usersessionmanagementconfig
Get the session management configurations for the user account.

- The usersessionmanagementconfig subcommand takes no arguments.
- Returns GetUserSessionManagementConfigReply.
### usersettings
- The usersettings subcommand takes no arguments.
- Returns UserSettings.
### usersincurrentanddescendantorganization
Retrieve users from current and descendant organizations based on the specified filters.

- There are 7 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
    - sortBy - UserSortByParam: Specifies sort parameter.
    - filter - UserFilterInput: Specifies user filters.
    - shouldIncludeUserWithoutRole - System.Boolean: Specifies whether we should include users without any roles assigned either in current or descendant orgs. If roleIdsFilter is not empty and this field is set to true, users without any roles will be included as well.
- Returns UserConnection.
### usersonaccountlist
- There are 11 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
    - sortOrder - SortOrder: Sort order of result.
    - sortBy - UserFieldEnum
    - emailFilter - System.String
    - roleIdsFilter - list of System.Strings
    - lockoutStateFilter - LockoutStateFilter: Filter users based on lockout status.
    - hiddenStateFilter - HiddenStateFilter: Filter users based on hidden status.
    - shouldGetLocalUsersOnly - System.Boolean: Get local users only.
- Returns UserConnection.
### userssummary
Returns the count of secure and insecure users.

- There are 3 arguments.
    - startDay - System.String: Start time, in string format (YYYY-MM-DD).
    - endDay - System.String: End time, in string format (YYYY-MM-DD).
    - filter - UsersSummaryFilterInput: Filter for users summary.
- Returns GetUsersSummaryReply.
### validateiocentry
Validates IOC entry.

- There is a single argument of type System.String.
- Returns ValidateEntryReply.
### validateorgname
Checks whether the tenant org name is valid and unique.

- There is a single argument of type ValidateOrgNameInput.
- Returns ValidateOrgNameReply.
### validatersakey
Verify RSA Key for encryption.

- There is a single argument of type System.String.
- Returns RsaKeyVerification.
### vcd
A vCloud Director.

- There is a single argument of type System.String.
- Returns Vcd.
### vcdcatalog
A vCloud Director Catalog.

- There is a single argument of type System.String.
- Returns VcdCatalog.
### vcdorg
A vCloud Director Organization.

- There is a single argument of type System.String.
- Returns VcdOrg.
### vcdorgs
Paginated list of vCloud Director orgs.

- There are 5 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - sortBy - HierarchySortByField: Sort hierarchy objects according to the hierarchy field.
    - sortOrder - SortOrder: Sort order of result.
    - filter - list of Filters: The hierarchy object filter.
- Returns VcdOrgConnection.
### vcdorgvdc
A vCloud Director Organization Virtual Data Center.

- There is a single argument of type System.String.
- Returns VcdOrgVdc.
### vcdtopleveldescendants
Paginated list of the highest-level vCloud Director Objects accessible by the current user.

- There are 6 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - sortBy - HierarchySortByField: Sort hierarchy objects according to the hierarchy field.
    - sortOrder - SortOrder: Sort order of result.
    - typeFilter - list of HierarchyObjectTypeEnums: Types of objects to include.
    - filter - list of Filters: The hierarchy object filter.
- Returns VcdTopLevelDescendantTypeConnection.
### vcdvapp
A vCloud Director vApp.

- There is a single argument of type System.String.
- Returns VcdVapp.
### vcdvapps
Paginated list of vCloud Director vApps.

- There are 5 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - sortBy - HierarchySortByField: Sort hierarchy objects according to the hierarchy field.
    - sortOrder - SortOrder: Sort order of result.
    - filter - list of Filters: The hierarchy object filter.
- Returns VcdVappConnection.
### vcdvappvms
Paginated list of virtual machines under vCloud Director hiearchy.

- There are 5 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - sortBy - HierarchySortByField: Sort hierarchy objects according to the hierarchy field.
    - sortOrder - SortOrder: Sort order of result.
    - filter - list of Filters: The hierarchy object filter.
- Returns VsphereVmConnection.
### vcdvimserver
A vCloud Director VIM Server.

- There is a single argument of type System.String.
- Returns VcdVimServer.
### vcdvimservers
List of VIM servers belonging to the vCD.

- There is a single argument of type QueryVcdVimServerInput.
- Returns VimserverSummaryListResponse.
### verifykmsname
Verify KMS Name.

- There is a single argument of type System.String.
- Returns KmsNameVerification.
### verifytotp
Verify TOTP for current user.

- There is a single argument of type VerifyTotpInput.
- Returns VerifyTotpReply.
### verifyvapptemplatename
Verify new vApp template name is unique.

- There is a single argument of type VerifyVappTemplateNameInput.
- Returns System.Boolean.
### virtualmachinefiles
Get virtual machine files for a snapshot

Supported in v9.0+
Returns all virtual machine files, such as .vmdk, .vmx, and .nvram files, for the specified virtual machine snapshot.

- There is a single argument of type VirtualMachineFilesInput.
- Returns VirtualMachineFilesReply.
### vmiofilterstatuses
The iofilter installation status of the compute clusters related to these virtual machines.

- There is a single argument of type list of System.Strings.
- Returns list of ComputeClusterIofilterStatuss.
### vmrecoveryjobsinfo
All Vm recovery jobs info.

- There are 2 arguments.
    - fid - System.String: The Rubrik UUID for the object.
    - input - AllVmRecoveryJobsInfoInput: Input to get all vm recovery jobs info.
- Returns list of VmRecoveryJobInfos.
### volumegroup
- There is a single argument of type System.String.
- Returns VolumeGroup.
### volumegroupasyncrequeststatus
Get async status of volume group request.

- There is a single argument of type GetVolumeGroupAsyncRequestStatusInput.
- Returns AsyncRequestStatus.
### volumegrouplist
- There are 5 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - sortBy - HierarchySortByField: Sort hierarchy objects according to the hierarchy field.
    - sortOrder - SortOrder: Sort order of result.
    - filter - list of Filters: The hierarchy object filter.
- Returns VolumeGroupConnection.
### volumegroupmounts
Volume Group Live Mount Connection.

- There are 4 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - filters - list of VolumeGroupLiveMountFilterInputs: Filter for volume group live mounts.
    - sortBy - VolumeGroupLiveMountSortByInput: Sort by argument for volume group live mounts.
- Returns VolumeGroupLiveMountConnection.
### workloadalertsetting
Get whether alerts for a given workload are enabled.

- There are 2 arguments.
    - clusterUuid - System.String: The Rubrik cluster ID.
    - workloadId - System.String: The FID of the workload.
- Returns GetWorkloadAlertSettingReply.
### workloadanomalies
Specifies workloads that have an anomalous snapshot.

- There are 19 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
    - beginTime - DateTime: Filters results that started after this time.
    - endTime - DateTime: Filters results that started before this time.
    - workloadNameSearch - System.String: Optional object name search filter to apply.
    - objectTypeFilter - list of System.Strings: Optional list of object types to filter by. Should be of type ManagedObjectType.
    - clusterUuidFilter - list of System.Strings: Optional list of Rubrik cluster UUIDs to filter by.
    - slaFidFilter - list of System.Strings: Optional list of SLA Domain FIDs to filter by.
    - encryptionFilter - list of EncryptionLevels: Optional list of encryption levels to filter by.
    - severityFilter - list of ActivitySeverityEnums: Optional list of severity levels to filter by.
    - analyzerGroupFilter - list of System.Strings: Optional list of analyzer group IDs to filter by.
    - sortBy - WorkloadAnomaliesSortBy: Sort object anomalies by field.
    - sortOrder - SortOrder: Sort order of result.
    - orderParentsFirst - System.Boolean: Order objects with children ahead of non-parents.
    - blueprintRecoveryTypes - list of BlueprintRecoveryTypes: Recovery type of the Recovery Plan.
    - locationsFilter - list of System.Strings: Filter results by their location.
    - resolutionStatusFilter - list of ResolutionStatuss: Filter by anomaly resolution.
- Returns WorkloadAnomalyConnection.
### workloadforeverid
Returns the RSC forever ID of a workload.

- There are 2 arguments.
    - clusterUuid - System.String: The Rubrik cluster ID.
    - managedId - System.String: Workload managed ID.
- Returns System.String.
### workloadgroupbyatspecifiedtime
- There are 4 arguments.
    - filters - WorkloadFilter: Filters of workloads.
    - primaryGroupBy - WorkloadGroupByEnum: Primary Group workloads by field.
    - secondaryGroupBy - WorkloadGroupByEnum: Secondary Group workloads by field.
    - specifiedTime - DateTime: Time to calculate the group by.
- Returns WorkloadGroupByReply.
### wwwtlscert
Configured web TLS cert.

- The wwwtlscert subcommand takes no arguments.
- Returns CertificateInfo.
