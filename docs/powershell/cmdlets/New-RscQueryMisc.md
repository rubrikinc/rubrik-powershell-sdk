# New-RscQueryMisc
## Subcommands
### activecustomanalyzers
- The activecustomanalyzers subcommand takes no arguments.
- Returns AnalyzerConnection.
### adgroupmembers
Objects that match the specifications of the AD group.

- There are 4 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - orgId - System.String: Org UUID.
    - adGroupSpec - AdGroupSpecInput: The Azure Active Directory group spec.
- Returns O365AdGroupMemberConnection.
### advolumeexports
Active Directory volume export connection.

- There are 4 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
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

- There are 10 arguments.
    - dataCategoryIdsFilter - list of System.Strings: List of data categories used for filtering results.
    - riskLevelsFilter - list of RiskLevelTypes: List of risk levels used for filtering results.
    - sortBy - AnalyzerUsagesSortBy: Name of the column to sort result by.
    - sortOrder - SortOrder: Sorts the order of results.
    - dataTypeSourceFilter - DataTypeSource: Filter for data category type.
    - dataTypeNameSearchFilter - System.String: Data type name to search.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that occur before the specified cursor.
- Returns AnalyzerUsageConnection.
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
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that occur before the specified cursor.
    - sortOrder - SortOrder: Sorts the order of results.
    - sortBy - AnomalyResultSortBy: Sort anomaly results by field.
    - filter - AnomalyResultFilterInput: Filter anomaly results by input.
    - timezoneOffset - System.Single: Offset based on the customer timezone.
- Returns AnomalyResultConnection.
### anomalyresultsgrouped
Results for Anomaly Investigations grouped by an argument.

- There are 7 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that occur before the specified cursor.
    - groupBy - AnomalyResultGroupBy: Group anomaly results by field.
    - filter - AnomalyResultFilterInput: Filter anomaly results by input.
    - timezoneOffset - System.Single: Offset based on the customer timezone.
- Returns AnomalyResultGroupedDataConnection.
### aremultigeobackupsenabled
Retrieves the status of multi-geo backups for the specified organization.

- There is a single argument of type System.String.
- Returns System.Boolean.
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
### browsecalendar
Browse Exchange calendar.

- There are 7 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - snappableFid - System.String: The FID for the workload.
    - snapshotFid - System.String: The ID of the snapshot.
    - folderId - System.String
    - orgId - System.String: Org UUID.
    - calendarSearchFilter - CalendarSearchFilter: Search filter for calendar search.
- Returns O365ExchangeObjectConnection.
### browsecontacts
Browse Exchange contacts.

- There are 7 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - snappableFid - System.String: The FID for the workload.
    - snapshotFid - System.String: The ID of the snapshot.
    - folderId - System.String
    - orgId - System.String: Org UUID.
    - contactsSearchFilter - ContactsSearchFilter: Search filter for contacts search.
- Returns O365ExchangeObjectConnection.
### browsefolder
- There are 6 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - snappableFid - System.String: The FID for the workload.
    - snapshotFid - System.String: The ID of the snapshot.
    - folderId - System.String
    - orgId - System.String: Org UUID.
- Returns O365ExchangeObjectConnection.
### browseonedrive
Browse OneDrive files and folders.

- There are 7 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - snappableFid - System.String: The FID for the workload.
    - snapshotFid - System.String: The ID of the snapshot.
    - folderId - System.String
    - onedriveSearchFilter - OnedriveSearchFilter
    - orgId - System.String: Org UUID.
- Returns O365OnedriveObjectConnection.
### browseteamschannels
Browse channels in a Teams files snapshot.

- There are 7 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - snappableFid - System.String: The FID for the workload.
    - snapshotFid - System.String: The ID of the snapshot.
    - orgId - System.String: Org UUID.
    - channelMembershipTypeFilter - ChannelMembershipType: Filter on channel membership type.
    - nameFilter - System.String
- Returns O365TeamsChannelConnection.
### browseteamsdrive
Browse team files.

- There are 7 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - snappableFid - System.String: The FID for the workload.
    - snapshotFid - System.String: The ID of the snapshot.
    - folderId - System.String
    - teamsDriveSearchFilter - OnedriveSearchFilter
    - orgId - System.String: Org UUID.
- Returns O365OnedriveObjectConnection.
### ccprovisionmetadata
Retrieves ccprovision metadata.

- There is a single argument of type CcProvisionMetadataReq.
- Returns CcProvisionMetadataReply.
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
### cdmversioncheck
Check supported feature for cluster version.

- There is a single argument of type FeatureCdmVersionInput.
- Returns FeatureCdmVersionReply.
### cdpvmsinfos
Details of all the virtual machines with Continuous Data Protection (CDP) SLA Domain.

- There are 6 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that occur before the specified cursor.
    - allCdpVmInfoSort - CdpPerfDashboardSortParam: Sort Type for getting all CDP VMs for CDP performance dashboard.
    - allCdpVmInfoFilter - list of CdpPerfDashboardFilterParams: Filter Type for getting all CDP VMs for CDP performance dashboard.
- Returns CdpVmInfoConnection.
### checkcloudcomputeconnectivityjobprogress
Get details of the cloud compute connectivity check request

Supported in v6.0+
Gets the details of the request that was triggered to check the cloud compute connectivity of an archival location.

- There is a single argument of type GetCloudComputeConnectivityCheckRequestStatusInput.
- Returns AsyncRequestStatus.
### checklatestversionmgmtappexists
Checks whether the latest version of the Microsoft 365 Management App exists.

- There is a single argument of type CheckLatestVersionMgmtAppExistsInput.
- Returns CheckLatestVersionMgmtAppExistsReply.
### clouddirectchecksharepath
CloudDirectCheckSharePath validates if a share path is accessible on the specified host.

- There is a single argument of type CloudDirectCheckSharePathReq.
- Returns CloudDirectCheckSharePathResp.
### clouddirectnasbucket
NAS Cloud Direct bucket.

- There is a single argument of type System.String.
- Returns CloudDirectNasBucket.
### clouddirectnasbuckets
Paginated list of NAS Cloud Direct buckets.

- There are 5 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - sortBy - HierarchySortByField: Sort hierarchy objects according to the hierarchy field.
    - sortOrder - SortOrder: Sorts the order of results.
    - filter - list of Filters: Hierarchy object filter.
- Returns CloudDirectNasBucketConnection.
### clouddirectnasexport
Cloud Direct NAS export object.

- There is a single argument of type System.String.
- Returns CloudDirectNasExport.
### clouddirectnasnamespace
NAS Cloud Direct namespace.

- There is a single argument of type System.String.
- Returns CloudDirectNasNamespace.
### clouddirectnasnamespaces
Paginated list of NAS namespaces.

- There are 5 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - sortBy - HierarchySortByField: Sort hierarchy objects according to the hierarchy field.
    - sortOrder - SortOrder: Sorts the order of results.
    - filter - list of Filters: Hierarchy object filter.
- Returns CloudDirectNasNamespaceConnection.
### clouddirectnasshare
NAS Cloud Direct share.

- There is a single argument of type System.String.
- Returns CloudDirectNasShare.
### clouddirectshares
Retrieve shares from Cloud Direct site.

- There is a single argument of type AllCloudDirectSharesInput.
- Returns list of ShareExportIdPairs.
### clouddirectsites
List of the Cloud Direct Sites accessible by the current user.

- The clouddirectsites subcommand takes no arguments.
- Returns list of CloudDirectSites.
### clouddirectsitesettings
ListCloudDirectSiteSettings retrieves site configuration settings
for Cloud Direct deployments.

- There is a single argument of type ListCloudDirectSiteSettingsReq.
- Returns ListCloudDirectSiteSettingsResp.
### clouddirectsystems
Retrieve systems managed by the Cloud Direct site.

- There is a single argument of type CloudDirectSystemsInput.
- Returns CloudDirectSystems.
### configuredgroupmembers
Objects that match the specifications of a configured group.

- There are 7 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - orgId - System.String: Org UUID.
    - wildcard - System.String: A wildcard pattern that group members' names or URLs must match.
    - pdls - list of System.Strings: A list of preferred data locations that group members must match.
    - workloadHierarchy - WorkloadLevelHierarchy: Each enumeration value represents the hierarchy of a specific workload type for RBAC and SLA Domain assignments.  A value of 'None' represents the hierarchy of all workload types.
    - groupFilterAttributes - list of GroupFilterAttributes: A list of attributes to filter out group members.
- Returns O365ConfiguredGroupMemberConnection.
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
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that occur before the specified cursor.
    - sortBy - GetCrossAccountPairsSortByField: Specifies the field by which the list of cross-account pairs will be sorted.
    - filter - list of GetCrossAccountPairsFilters: Specification on how to filter a list of cross-account pairs.
    - sortOrder - SortOrder: Sorts the order of results.
- Returns CrossAccountPairInfoConnection.
### crowdstrikeingestionstatus
Get CrowdStrike ingestion status.

- The crowdstrikeingestionstatus subcommand takes no arguments.
- Returns CrowdStrikeIngestionStatus.
### currentipaddress
The IP address of the client making the request.

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
### dashboardsummary
Returns hits grouped by analyzer and policy.

- There is a single argument of type System.Boolean.
- Returns GetDashboardSummaryReply.
### datagovsecdesc
Returns permissions associated with a path.

- There are 5 arguments.
    - snappableFid - System.String
    - snapshotFid - System.String
    - stdPath - System.String
    - skipResolveSids - System.Boolean: Skip converting SIDs in response to friendly names
    - filters - SddlRequestFiltersInput: Filter for resolving security descriptor.
- Returns QuerySDDLReply.
### datapreview
Retrieve the list of data previews.

- There is a single argument of type GetDataPreviewRequest.
- Returns GetDataPreviewReply.
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

- There are 9 arguments.
    - startDay - System.String: Start time, in string format (YYYY-MM-DD).
    - endDay - System.String: End time, in string format (YYYY-MM-DD).
    - timezone - System.String
    - getWhitelistedResults - System.Boolean: Include whitelisted objects in the results.
    - workloadTypes - list of DataGovObjectTypes: Types of workloads that can be used for filtering query results.
    - useOptimisedDiscoveryTimeline - System.Boolean: Specifies whether the optimized discovery timeline must be used for the request. If not passed, default is taken as false.
    - subscriptionIdsFilter - list of System.Strings: List of subscriptions for filtering results.
    - objectIdsFilter - list of System.Strings: Object IDs to filter.
    - platformCategoryFilter - list of PlatformCategorys: Platform category to filter.
- Returns GetPoliciesTimelineReply.
### distributionlistdigest
Retrieve a custom distribution list event digest by ID.

- There is a single argument of type DistributionDigestByIdInput.
- Returns EventDigest.
### distributionlistdigests
Retrieve all custom distribution list event digests.

- The distributionlistdigests subcommand takes no arguments.
- Returns list of EventDigests.
### edgewindowstoollink
Download link for Rubrik Edge Deployment Tool for Microsoft Windows.

- The edgewindowstoollink subcommand takes no arguments.
- Returns EdgeWindowsToolLink.
### effectiverbacpermissions
Permissions assigned to the role that are in effect.

- There is a single argument of type System.String.
- Returns list of RbacPermissions.
### eventdigests
Retrieve event digests for specific recipients.

- There is a single argument of type AllEventDigestsInput.
- Returns list of EventDigests.
### exocomputegetsupportedhealthchecks
ExocomputeGetSupportedHealthChecks returns the supported health check
details for the given cloud type for Exocompute.

- There is a single argument of type ExocomputeGetSupportedHealthChecksReq.
- Returns ExocomputeGetSupportedHealthChecksReply.
### exocomputehealthchecks
ExocomputeHealthChecks returns the health checks for the
Exocompute configuration.

- There is a single argument of type ExocomputeHealthChecksReq.
- Returns ExocomputeHealthChecksReply.
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
### failovergroupworkloads
Retrieves workloads within a failover group for high-availability management.

- There are 6 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that occur before the specified cursor.
    - failoverGroupId - System.String: Failover group ID to get workloads for.
    - filter - FailoverGroupWorkloadFilter: Filters to apply to the query.
- Returns FailoverGroupWorkloadConnection.
### federatedloginstatus
Status of the federated login.

- The federatedloginstatus subcommand takes no arguments.
- Returns FederatedLoginStatus.
### fileactivities
List user activity for a specific file on a specific snapshot.

- There are 6 arguments.
    - ListFileActivitiesInput - ListFileActivitiesInput: Request for getting user activity for a specific path on a specific snapshot.
    - FileActivitiesSort - FileActivitiesSort: Sorts to apply when listing a file's user activities.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that occur before the specified cursor.
- Returns UserActivityResultConnection.
### geolocationlist
- The geolocationlist subcommand takes no arguments.
- Returns list of GroupCounts.
### getallrolesinorglist
- There are 9 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that occur before the specified cursor.
    - sortOrder - SortOrder: Sorts the order of results.
    - sortBy - RoleFieldEnum
    - nameFilter - System.String: Name to filter the results.
    - assignedRoleIds - list of System.Strings: List of role IDs that have already been assigned to a set of users. This list will be used to sort the set of all roles.
    - roleSyncedFilter - System.Boolean: Argument to filter roles based on whether they are marked to be synced to Rubrik cluster.
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
    - sortOrder - SortOrder: Sorts the order of results.
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
    - sortOrder - SortOrder: Sorts the order of results.
- Returns CdmUpgradeReleaseDetailsFromSupportPortalReply.
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
### getpermissions
Permissions assigned to the role that are in effect.

- There is a single argument of type System.String.
- Returns list of Permissions.
### getrolesbyids
- There are 2 arguments.
    - roleIds - list of System.Strings
    - syncedClustersFilter - System.String: Name to filter the synced clusters for role.
- Returns list of Roles.
### getuserdownloads
- There are 4 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that occur before the specified cursor.
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
### globalsearchresults
- There are 8 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that occur before the specified cursor.
    - sortBy - HierarchySortByField: Sort hierarchy objects according to the hierarchy field.
    - sortOrder - SortOrder: Sorts the order of results.
    - filter - list of Filters: Hierarchy object filter.
    - objectTypeFilterParams - list of ManagedObjectTypes: List of object types to filter by. If not provided, uses default global search types.
- Returns HierarchyObjectConnection.
### groupsincurrentanddescendantorganization
Retrieve groups from current and descendant organizations based on the specified filters.

- There are 7 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that occur before the specified cursor.
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
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
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
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that occur before the specified cursor.
    - filter - HelpContentSnippetsFilterInput: Filter for help content snippets.
- Returns HelpContentSnippetConnection.
### hierarchyobject
- There are 2 arguments.
    - fid - System.String: Rubrik UUID for the object.
    - workloadHierarchy - WorkloadLevelHierarchy: Each enumeration value represents the hierarchy of a specific workload type for RBAC and SLA Domain assignments.  A value of 'None' represents the hierarchy of all workload types.
- Returns HierarchyObject.
### hierarchyobjects
- There are 2 arguments.
    - fids - list of System.Strings: The Rubrik UUIDs for the objects.
    - filter - list of Filters: Hierarchy object filter.
- Returns list of HierarchyObjects.
### identitydatalocationsencryptioninfo
Retrieve the encryption information for identity data locations.

- There are 7 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that occur before the specified cursor.
    - sortBy - IdentityDataLocationSortByField: Sort order for sorting data locations.
    - filter - IdentityDataLocationsFilter: Filter for listing identity data locations.
    - pagination - Pagination: Pagination param.
- Returns IdentityDataLocationEncryptionInfoConnection.
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
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that occur before the specified cursor.
    - providerId - System.String: ID of threat feed.
    - threatFeedType - list of ThreatFeedTypes: Type of IOCs to return.
    - feedEntryStatusFilter - FeedEntryStatusFilter: Filter feed entries by entry status.
    - feedEntrySort - FeedEntrySort: Sorts feed entries.
- Returns IocFeedEntryConnection.
### ipwhitelist
The IP allowlist for the given organization.

- The ipwhitelist subcommand takes no arguments.
- Returns GetWhitelistReply.
### ipwhitelistentries
Retrieve entries in the IP allowlist.

- There are 5 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that occur before the specified cursor.
    - filter - IpWhitelistEntryFilterInput: Specifies IP allowlist entry filters.
- Returns IpInfoConnection.
### ipwhitelistsettings
Retrieve settings of the IP allowlist.

- The ipwhitelistsettings subcommand takes no arguments.
- Returns IpWhitelistSettings.
### isclouddirectsharepathvalid
IsCloudDirectSharePathValid validates if a share path is
accessible on the specified system.

- There is a single argument of type CloudDirectValidateSharePathReq.
- Returns CloudDirectValidateSharePathResp.
### isipmienabled
Check if IPMI is enabled on the cluster.

- There is a single argument of type IsIpmiEnabledInput.
- Returns System.Boolean.
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

- There is a single argument of type System.String.
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
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that occur before the specified cursor.
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
### jobinfo
Information about a job running on CDM.
Note that some types of jobs cannot be queries using this
field. Refer to `JobType` enum to see which jobs types
are available. Only users with Admin or Owner roles are
allowed to access the field.

- There is a single argument of type JobInfoRequest.
- Returns JobInfo.
### knowledgebasearticle
A knowledge base article.

- There is a single argument of type System.String.
- Returns KnowledgeBaseArticle.
### lacpconfigurations
Check if the cluster has at least 1 node with its bond interfaces configured with LACP mode.

- There are 5 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that occur before the specified cursor.
    - clusterUuids - list of System.Strings: List of cluster UUIDs.
- Returns LacpPresenceCheckConnection.
### lambdasettings
- The lambdasettings subcommand takes no arguments.
- Returns LambdaSettings.
### licensedproducts
Information about the licenses at the product level.

- The licensedproducts subcommand takes no arguments.
- Returns GetLicensedProductsInfoReply.
### listalluploadrecords
List all the upload records.

- There is a single argument of type ListAllUploadRecordsInput.
- Returns ListAllUploadRecordsReply.
### lockoutconfig
Get the lockout configurations of the current organization.

- The lockoutconfig subcommand takes no arguments.
- Returns LockoutConfig.
### mfasetting
Get multifactor authentication (MFA) settings for an account.

- The mfasetting subcommand takes no arguments.
- Returns GetMfaSettingReply.
### microsoftgroups
List of Microsoft Groups in the organization.

- There are 8 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - sortBy - HierarchySortByField: Sort hierarchy objects according to the hierarchy field.
    - sortOrder - SortOrder: Sorts the order of results.
    - filter - list of Filters: Hierarchy object filter.
    - o365OrgId - System.String: The FID for the O365 organization.
    - microsoftObjectType - ManagedObjectType
    - protectionType - ProtectionType: Protection type for Microsoft 365 protection.
- Returns MicrosoftGroupConnection.
### microsoftsites
List of sites in the Microsoft 365 organization.

- There are 8 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - sortBy - HierarchySortByField: Sort hierarchy objects according to the hierarchy field.
    - sortOrder - SortOrder: Sorts the order of results.
    - filter - list of Filters: Hierarchy object filter.
    - o365OrgId - System.String: The FID for the O365 organization.
    - excludeChildSites - System.Boolean: When excludeChildSites is set to true, nested child sites are excluded from the results. If not specified, nested child sites are included.
    - protectionType - ProtectionType: Protection type for Microsoft 365 protection.
- Returns MicrosoftSiteConnection.
### minimumcdmversionforfeatureset
Get minimum cluster version to support feature set.

- There is a single argument of type FeatureListMinimumCdmVersionInputType.
- Returns FeatureListMinimumCdmVersionReply.
### miplabels
Returns all the MIP Labels for an account.

- There are 3 arguments.
    - onlyActiveFilter - System.Boolean: Restricts the search to active labels only.
    - onlyAppliableFilter - System.Boolean: Restricts the search to appliable labels only.
    - tenantIdFilter - System.String: Filter for Tenant ID.
- Returns list of MicrosoftMipLabels.
### networkthrottle
Network Throttle Information.

- There is a single argument of type QueryNetworkThrottleInput.
- Returns NetworkThrottleSummaryListResponse.
### nfanomalyresults
Results for Non-Filesystem Anomaly Investigations.

- There are 8 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that occur before the specified cursor.
    - sortOrder - SortOrder: Sorts the order of results.
    - sortBy - NfAnomalyResultSortBy: Sort non-filesystem anomaly results by field.
    - filter - NfAnomalyResultFilterInput: Filter non-filesystem anomaly results by input.
    - timezoneOffset - System.Single: Offset based on the customer timezone.
- Returns NfAnomalyResultConnection.
### nfanomalyresultsgrouped
Results for Non-Filesystem Anomaly Investigations grouped by an argument.

- There are 7 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that occur before the specified cursor.
    - groupBy - NfAnomalyResultGroupBy: Group non-filesystem anomaly results by field.
    - filter - NfAnomalyResultFilterInput: Filter non-filesystem anomaly results by input.
    - timezoneOffset - System.Single: Offset based on the customer timezone.
- Returns NfAnomalyResultGroupedDataConnection.
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
    - sortOrder - SortOrder: Sorts the order of results.
    - filter - list of MosaicStorageLocationFilterInputs: Specification on how to filter a list of Mosaic Storage Locations.
- Returns list of MosaicStorageLocations.
### oauthcodesforedgereg
Reply for request to download Rubrik Edge from Rubrik Security Cloud.

- There are 2 arguments.
    - numberOfEdges - System.Int32: Input to enter the number of Rubrik Edge installations.
    - cdmOvaLink - System.String: Input to enter the Rubrik CDM virtual cluster OVA package link.
- Returns OauthCodesForEdgeRegReply.
### objectfiles
- There are 8 arguments.
    - filter - ListObjectFilesFiltersInput
    - sort - FileResultSortInput: Sorts to apply when listing file results.
    - day - System.String: Date in the format (YYYY-MM-DD).
    - timezone - System.String
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that occur before the specified cursor.
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

- There are 11 arguments.
    - timelineDate - System.String: Date for which the results will be retrieved.
    - historicalDeltaDays - System.Int32: Number of historical days to go backward in time to calculate the delta.
    - includeWhitelistedResults - System.Boolean: Specifies whether whitelisted results should be included.
    - sortOrder - SortOrder: Sorts the order of results.
    - filter - ObjectTypeSummariesFilter: Filter for object type summary.
    - sort - ObjectTypeAccessSummarySortBy: Field on which to perform the sorting operation.
    - groupBy - ObjectTypeAccessSummaryGroupBy: Field on which to perform the grouping operation.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that occur before the specified cursor.
- Returns ObjectTypeAccessSummaryConnection.
### org
Org details of the given org ID.

- There is a single argument of type System.String.
- Returns Org.
### orgs
All orgs.

- There are 11 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that occur before the specified cursor.
    - sortOrder - SortOrder: Sorts the order of results.
    - sortBy - OrgField: Field in the org to sort orgs by.
    - nameFilter - System.String: Name to filter the results.
    - mfaEnforcedFilter - System.Boolean: Filter orgs by the status of MFA enforcement. When the field is not used, all orgs are returned. When the field is set to true, only orgs that have MFA enforced are returned. When the field is set to false, only orgs that do not have MFA enforced are returned.
    - mfaStatusFilter - MfaStatus: Deprecated. Use MfaStatusesFilterArg instead.
    - mfaStatusesFilter - list of MfaStatuss: Filter organizations by MFA status.
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

- There are 6 arguments.
    - dataCategoryIds - list of System.Strings: Filter for data category IDs.
    - dataTypeIds - list of System.Strings: Data type IDs to filter.
    - dataCategoryType - DataCategoryType: Filter for data category type.
    - documentTypeIds - list of System.Strings: Document type IDs to filter.
    - sortBy - PoliciesDetailSortByField: Field to sort policies detail entries by.
    - sortOrder - SortOrder: Sorts the order of results.
- Returns PolicyDetailConnection.
### policyobj
Returns details for one policy object.

- There are 3 arguments.
    - snappableFid - System.String
    - snapshotFid - System.String
    - includeWhitelistedResults - System.Boolean: Specifies whether whitelisted results should be included.
- Returns PolicyObj.
### policyobjs
Returns status for all objects at a specified timestamp.

- There are 45 arguments.
    - day - System.String: Date in the format (YYYY-MM-DD).
    - timezone - System.String
    - workloadTypes - list of DataGovObjectTypes: Types of workloads that can be used for filtering query results.
    - sortBy - System.String: Name of the column to sort result by.
    - sortOrder - SortOrder: Sorts the order of results.
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
    - firstSeenTimeRange - UserTimeRangeInput: The first seen time range specified in the UTC timezone.
    - lastAccessTimeRange - UserTimeRangeInput: The last access time range specified in the UTC timezone.
    - creationTimeRange - UserTimeRangeInput: The creation time range specified in the UTC timezone.
    - lastScanTimeRange - UserTimeRangeInput: The last scan time range specified in the UTC timezone.
    - objectTagsFilter - ObjectTagsFilterInput: Object tags associated with workloads as key-value pairs.
    - mipLabelsFilter - list of MipLabelsFilterInputs: List of MIP Labels that will be used for filtering the result.
    - documentTypesFilter - list of System.Strings: List of document type IDs that will be used for filtering the result.
    - scanResultErrorCodesFilter - list of FlowErrorCodes: List of scan result error codes that will be used for filtering the result.
    - scanResultCategoriesFilter - list of ScanResultCategorys: List of scan result categories that will be used for filtering the result.
    - backupStatusFilter - list of BackupStatuss: Filter by backup status.
    - slaIdsFilter - list of System.Strings: Filter by SLA Domain IDs.
    - networkAccessFilter - list of NetworkAccesss: Filter by network access type.
    - encryptionFilter - list of Encryptions: Filter by encryption type.
    - loggingFilter - list of Loggings: Filter by logging type.
    - violationSeverityFilter - list of ViolationSeveritys: Violation Severity list input arg.
    - exposureFilter - list of OpenAccessTypes: Exposure to filter.
    - accessTypeFilter - list of AccessVias: Access types to filter by.
    - accessGrantingIdFilter - System.String: Filter policy objects by access granting identity ID. This filter should only be applied when an identity ID filter is also present, as access granting entities are only relevant in the context of specific identities.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that occur before the specified cursor.
- Returns PolicyObjConnection.
### prechecksstatus
Gets status of last prechecks job.

- There is a single argument of type System.String.
- Returns PrechecksStatusReply.
### prechecksstatuswithnextjobinfo
Get status of last completed prechecks Job along with details of currently running/scheduled next prechecks Job.

- There is a single argument of type System.String.
- Returns PrechecksStatusReply.
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
    - filter - list of Filters: Hierarchy object filter.
    - objectTypeFilter - list of System.Strings: Types of objects to include.
    - sortBy - HierarchySortByField: Sort hierarchy objects according to the hierarchy field.
    - sortOrder - SortOrder: Sorts the order of results.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that occur before the specified cursor.
- Returns ProtectedObjectsConnection.
### protectedvolumescount
Total number of protected volumes across all hosts.

- There is a single argument of type list of Filters.
- Returns System.Int32.
### quarantineddetailsforworkload
Quarantine details of a workload.

- There is a single argument of type System.String.
- Returns list of QuarantineSpecs.
### querydatastorefreespacethresholds
Query datastore threshold configurations.

- There is a single argument of type list of QueryDatastoreFreespaceThresholdInputs.
- Returns QueryDatastoreFreespaceThresholdsReply.
### removednodedetails
Get the information for removed nodes.

- There is a single argument of type RemovedNodeDetailsInput.
- Returns RemoveNodeDetailsReply.
### resettypeofremovaljob
Get the reset type of a node removal job.

- There is a single argument of type ResetTypeOfRemovalJobInput.
- Returns ResetTypeOfRemovalJob.
### roletemplates
The list of available role templates.

- There are 5 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that occur before the specified cursor.
    - nameFilter - System.String: Name to filter the results.
- Returns RoleTemplateConnection.
### rscpermstocdminfo
Synced cluster information for RSC permissions.

- There are 7 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that occur before the specified cursor.
    - permissions - list of PermissionInputs: Permissions in the role.
    - roleId - System.String: ID of the role.
    - protectableClusters - list of System.Strings: List of protectable clusters.
- Returns RscPermsToCdmInfoOut.
### saasworkloadmetadatatypes
SaasWorkloadMetadataTypes returns the list of metadata types for a
specified SaaS app type.

- There is a single argument of type SaasWorkloadMetadataTypesReq.
- Returns SaasWorkloadMetadataTypesReply.
### scriptsformanualpermissionvalidation
GetScriptsForManualPermissionValidation returns the bash and powershell
scripts for non-OAuth permissions validation.

- There is a single argument of type GetScriptsForManualPermissionValidationReq.
- Returns GetScriptsForManualPermissionValidationReply.
### searchfilebyprefix
Search file under given folder and with given prefix.

- There are 5 arguments.
    - clusterUuid - System.String: The Rubrik cluster ID.
    - managedId - System.String: Workload managed ID.
    - snapshotId - System.String: Corresponds to snapshot ID in Rubrik CDM tables.
    - searchFolderPath - System.String: Root path to search file inside FMD.
    - filenamePrefix - System.String: Filename prefix that should match.
- Returns DiffResult.
### snoozeddirectories
Lists the snoozed directories for the account.

- There are 7 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that occur before the specified cursor.
    - snoozeStatusFilter - list of SnoozeStatuss: Filter by snooze status.
    - directorySearchFilter - System.String: Optional directory search.
    - falsePositiveTypeFilter - list of AnomalyFalsePositiveTypes: Filter by false positive type.
- Returns SnoozedDirectoryConnection.
### ssogroupalreadyexists
Determines if the SSO group already exists in the account.

- There are 2 arguments.
    - ssoGroupName - System.String: SSO group name.
    - userDomainId - System.String: User auth domain ID.
- Returns SsoGroupAlreadyExistsReply.
### supportbundle
Get the status of generating support bundle

Supported in v5.0+
Given a request ID for generate support bundle request, provide the status of the request. If the request is successful, the download link for the support bundle would be included.

- There is a single argument of type QuerySupportBundleInput.
- Returns AsyncRequestStatus.
### supportuseraccesses
All support user access objects that satisfy the query criteria.

- There are 7 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that occur before the specified cursor.
    - sortBy - SupportUserAccessSortByField: Sorting field for support access.
    - sortOrder - SortOrder: Sorting order for support access.
    - filters - list of SupportUserAccessFilterInputs: Specifies how to filter the list of targets.
- Returns SupportUserAccessConnection.
### tablefilters
- The tablefilters subcommand takes no arguments.
- Returns TableFilters.
### taskchain
Details of a taskchain.

- There is a single argument of type System.String.
- Returns Taskchain.
### taskdetailgroupbylist
- There are 7 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that occur before the specified cursor.
    - filter - TaskDetailFilterInput: Filter task summary by input.
    - groupBy - TaskDetailGroupByEnum: Group task detail by a field.
    - timezoneOffset - System.Single: Offset based on the customer timezone.
- Returns TaskDetailGroupByConnection.
### taskdetaillist
Get task details.

- There are 9 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that occur before the specified cursor.
    - filter - TaskDetailFilterInput: Filter task detail by input.
    - sortBy - TaskDetailSortByEnum: Sort task detail by field.
    - sortOrder - SortOrder: Task detail sort order.
    - timezoneOffset - System.Single: Offset based on the customer timezone.
    - timezone - Timezone: Time zone identifier string. For example, 'America/Los_Angeles' is used for the U.S. Pacific Time zone.
- Returns TaskDetailConnection.
### teamchannelnameavailable
Checks the availability of the channel name in the Team.

- There are 2 arguments.
    - teamUUID - System.String
    - channelName - System.String
- Returns System.Boolean.
### totpconfigstatus
Get TOTP configuration status for a user.

- There is a single argument of type System.String.
- Returns GetTotpStatusReply.
### tprconfiguration
Specifies the current two-person rule (TPR) configuration for an organization.

- There is a single argument of type System.String.
- Returns TprConfiguration.
### tprpublicconfiguration
Specifies the publicly available two-person rule (TPR) configuration for an organization.

- There is a single argument of type System.String.
- Returns TprPublicConfiguration.
### tprrequestdetail
Details for a TPR request.

- There is a single argument of type System.String.
- Returns TprRequestDetailReply.
### tprrequestsummaries
Details of TPR requests.

- There are 5 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that occur before the specified cursor.
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
### tunnelstatus
Check support tunnel status for a particular node

Supported in v5.0+
To be used by Admin to check status of the support tunnel.

- There is a single argument of type GetTunnelStatusInput.
- Returns SupportTunnelInfo.
### uniquevcdcount
Number of unique vCloud Director instances.

- There is a single argument of type list of Filters.
- Returns System.Int32.
### unmanagedobjects
List of unmanaged objects.

- There are 5 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that occur before the specified cursor.
    - input - UnmanagedObjectsInput: Query unmanaged objects.
- Returns UnmanagedObjectDetailConnection.
### unmanagedobjectssupportedtypes
List of supported object types.

- There are 2 arguments.
    - productType - ProductTargetType: Type of the product.
    - cloudVendor - CloudVendor: The cloud vendor type.
- Returns list of ManagedObjectTypes.
### upgradestatus
Gets the status for completed/running upgrade process.

- There is a single argument of type System.String.
- Returns UpgradeStatusReply.
### useractivities
- There are 8 arguments.
    - filter - ListObjectFilesFiltersInput
    - sort - FileResultSortInput: Sorts to apply when listing file results.
    - timeRange - UserTimeRangeInput: Time range specified in the user's local timezone.
    - userId - System.String
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that occur before the specified cursor.
- Returns FileResultConnection.
### useralreadyexists
Determines if the user already exists in the account.

- There are 3 arguments.
    - emailOrUsername - System.String: User email or username.
    - userDomain - UserDomainEnum: User auth domain.
    - userDomainId - System.String: User auth domain ID.
- Returns UserAlreadyExistsReply.
### useranalyzeraccess
- There are 4 arguments.
    - userId - System.String
    - startDay - System.String: Start time, in string format (YYYY-MM-DD).
    - timezone - System.String
    - limit - System.Int32: Maximum number of entries in the response.
- Returns AnalyzerAccessUsageConnection.
### userauditlist
Paginated list of user audit data. Each page of the results will include at most 50 entries unless otherwise specified using the first parameter. Query the pageInfo.hasNextPage field to know whether all audits were returned.

- There are 7 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that occur before the specified cursor.
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
### userfile
User file.

- There is a single argument of type System.String.
- Returns CustomerFacingFile.
### userfiles
All user files.

- There are 4 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that occur before the specified cursor.
- Returns list of GetCustomerFacingDownloadsReplys.
### usergroups
- There are 5 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that occur before the specified cursor.
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
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that occur before the specified cursor.
    - sortBy - UserSortByParam: Specifies sort parameter.
    - filter - UserFilterInput: Specifies user filters.
    - shouldIncludeUserWithoutRole - System.Boolean: Specifies whether we should include users without any roles assigned either in current or descendant orgs. If roleIdsFilter is not empty and this field is set to true, users without any roles will be included as well.
- Returns UserConnection.
### usersonaccountlist
- There are 12 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that occur before the specified cursor.
    - sortOrder - SortOrder: Sorts the order of results.
    - sortBy - UserFieldEnum
    - emailFilter - System.String
    - roleIdsFilter - list of System.Strings
    - lockoutStateFilter - LockoutStateFilter: Filter users based on lockout status.
    - hiddenStateFilter - HiddenStateFilter: Filter users based on hidden status.
    - shouldGetLocalUsersOnly - System.Boolean: Get local users only.
    - userDomainsFilter - list of UserDomainEnums: Filter users based on their authentication domain.
- Returns UserConnection.
### validateadforesttransition
Validates if given account is ready to transition from Active Directory domain inventory page to Active Directory forest inventory page.

- The validateadforesttransition subcommand takes no arguments.
- Returns ValidateAdForestTransition.
### validateiocentry
Validates IOC entry.

- There is a single argument of type ValidateIocEntryInput.
- Returns ValidateEntryReply.
### validateorgname
Checks whether the tenant org name is valid and unique.

- There is a single argument of type ValidateOrgNameInput.
- Returns ValidateOrgNameReply.
### validaterdsexportexocomputeport
ValidateRdsExportExocomputePort checks if the exocompute worker node security group used for RDS export allows outbound traffic on a port.

- There is a single argument of type ValidateRdsExportExocomputePortReq.
- Returns ValidateRdsExportExocomputePortReply.
### validatescriptoutputformanualpermissionvalidation
ValidateScriptOutputForManualPermissionValidation validates the script
output provided by the customer for the manual permission validation.

- There is a single argument of type ValidateScriptOutputForManualPermissionValidationReq.
- Returns ValidateScriptOutputForManualPermissionValidationReply.
### validregionsfordynamodbrecovery
GetValidRegionsForDynamoDBRecovery returns a list of regions where the
provided cloud accounts have Exocompute configured for DynamoDB recovery.

- There is a single argument of type GetValidRegionsForDynamoDbRecoveryReq.
- Returns GetValidRegionsForDynamoDbRecoveryReply.
### vcdorgs
Paginated list of vCloud Director orgs.

- There are 5 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - sortBy - HierarchySortByField: Sort hierarchy objects according to the hierarchy field.
    - sortOrder - SortOrder: Sorts the order of results.
    - filter - list of Filters: Hierarchy object filter.
- Returns VcdOrgConnection.
### vcdtopleveldescendants
Paginated list of the highest-level vCloud Director objects accessible by the current user.

- There are 6 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - sortBy - HierarchySortByField: Sort hierarchy objects according to the hierarchy field.
    - sortOrder - SortOrder: Sorts the order of results.
    - typeFilter - list of HierarchyObjectTypeEnums: Types of objects to include.
    - filter - list of Filters: Hierarchy object filter.
- Returns VcdTopLevelDescendantTypeConnection.
### vcdvapps
Paginated list of vCloud Director vApps.

- There are 5 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - sortBy - HierarchySortByField: Sort hierarchy objects according to the hierarchy field.
    - sortOrder - SortOrder: Sorts the order of results.
    - filter - list of Filters: Hierarchy object filter.
- Returns VcdVappConnection.
### vcdvappvms
Paginated list of virtual machines under vCloud Director hiearchy.

- There are 5 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - sortBy - HierarchySortByField: Sort hierarchy objects according to the hierarchy field.
    - sortOrder - SortOrder: Sorts the order of results.
    - filter - list of Filters: The hierarchy object filter.
- Returns VsphereVmConnection.
### verifytotp
Verify TOTP for current user.

- There is a single argument of type VerifyTotpInput.
- Returns VerifyTotpReply.
### virtualmachinefiles
Get virtual machine files for a snapshot

Supported in v9.0+
Returns all virtual machine files, such as .vmdk, .vmx, and .nvram files, for the specified virtual machine snapshot.

- There is a single argument of type VirtualMachineFilesInput.
- Returns VirtualMachineFilesReply.
### vmrecoveryjobsinfo
All Vm recovery jobs info.

- There are 2 arguments.
    - fid - System.String: Rubrik UUID for the object.
    - input - AllVmRecoveryJobsInfoInput: Input to get all vm recovery jobs info.
- Returns list of VmRecoveryJobInfos.
### volumegroupmounts
Volume Group Live Mount Connection.

- There are 4 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
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
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that occur before the specified cursor.
    - beginTime - DateTime: Filters results that started after this time.
    - endTime - DateTime: Filters results that started before this time.
    - workloadNameSearch - System.String: Optional object name search filter with partial match.
    - objectTypeFilter - list of System.Strings: Optional list of object types to filter by. Should be of type ManagedObjectType.
    - clusterUuidFilter - list of System.Strings: Optional list of Rubrik cluster UUIDs to filter by.
    - slaFidFilter - list of System.Strings: Optional list of SLA Domain FIDs to filter by.
    - encryptionFilter - list of EncryptionLevels: Optional list of encryption levels to filter by.
    - severityFilter - list of ActivitySeverityEnums: Optional list of severity levels to filter by.
    - analyzerGroupFilter - list of System.Strings: Optional list of analyzer group IDs to filter by.
    - sortBy - WorkloadAnomaliesSortBy: Sort object anomalies by field.
    - sortOrder - SortOrder: Sorts the order of results.
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
