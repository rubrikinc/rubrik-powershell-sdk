# New-RscQueryMisc
## Subcommands
### activecustomanalyzers
Returns active custom analyzers.

- There are 4 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that occur before the specified cursor.
- Returns AnalyzerConnection.
### activities
List of activities.

- There are 8 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that occur before the specified cursor.
    - orderBy - OrderBy: The field and order to sort the activities.
    - filter - ListActivitiesFilter: Filter for the query.
    - includeRemediationStatus - System.Boolean: Whether to include remediation status for
each activity.
    - includeRemediationTypes - System.Boolean: Whether to include available remediation
types for each activity.
- Returns ActivityEntryConnection.
### adgroupmembers
Returns members matching an AD group spec, in a given org.

- There are 6 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that occur before the specified cursor.
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
Returns analyzer groups available for configuring a crawl.

- There are 4 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that occur before the specified cursor.
- Returns AnalyzerGroupConnection.
### analyzerusages
Returns which policies are using each analyzer.

- There are 11 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that occur before the specified cursor.
    - dataCategoryIdsFilter - list of System.Strings: List of data categories used for filtering results.
    - riskLevelsFilter - list of RiskLevelTypes: List of risk levels used for filtering results.
    - sortBy - AnalyzerUsagesSortBy: Name of the column to sort result by.
    - sortOrder - SortOrder: Sorts the order of results.
    - dataTypeSourceFilter - DataTypeSource: Filter for data category type.
    - dataTypeNameSearchFilter - System.String: Data type name to search.
    - analyzerStatusFilter - AnalyzerStatusFilter: Filter for analyzer status.
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
### appaccessgraph
GetAppAccessGraph returns aggregated counts for a user's app access paths.
Shows how many apps the user can access directly and via groups.

- There is a single argument of type AppAccessGraphInput.
- Returns AppAccessGraph.
### appaccessimpact
Returns the app access impact of an identity event -- which apps a user
gained or lost access to, and whether each change is a full access change
or a path-only change.

- There is a single argument of type AppAccessImpactInput.
- Returns AppAccessImpact.
### appaccessprincipals
ListAppAccessPrincipals returns a list of principals (groups or apps) that
participate in app access paths for a given user.

- There are 5 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that occur before the specified cursor.
    - filter - AppAccessPrincipalsFilterInput: Filter to be applied when retrieving app access principals.
- Returns AppAccessPrincipalConnection.
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
### backupwindowsforobjects
Returns backup window information for the specified managed objects.
The optional `scope` argument selects which layer to return per object:
OBJECT_LEVEL (the override only) or SLA_LEVEL (the SLA's window only).
When omitted (UNSPECIFIED), the effective window is returned: the
object-level override if set, else the SLA window. Each entry's `scope`
discriminator reports the layer that supplied the returned window,
always OBJECT_LEVEL or SLA_LEVEL.

- There are 2 arguments.
    - objectIds - list of System.Strings: Identifiers of the managed objects to look up.
    - scope - BackupWindowScope: Which backup window layer to return: OBJECT_LEVEL or
SLA_LEVEL. Defaults to effective behavior when omitted.
- Returns BackupWindowsForObjectsReply.
### browsecalendar
BrowseCalendarFolderItems returns the contents (calendar folders +
events) of a calendar folder inside a single snapshot. Encapsulates
the snapshot-expiry data check and the root-folder resolution logic
(In-Place Archive filter + multi-root disambiguation) previously
performed in the GraphQL resolver `browseCalendar`.

- There are 9 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that occur before the specified cursor.
    - snappableFid - System.String: The FID for the workload.
    - snapshotFid - System.String: The ID of the snapshot.
    - folderId - System.String: The folder being browsed.
    - orgId - System.String: Org UUID.
    - calendarSearchFilter - CalendarSearchFilter: Search filter for calendar search.
- Returns O365ExchangeObjectConnection.
### browsecontacts
BrowseContactsFolderItems returns the contents (contact folders +
contacts) of a contact folder inside a single snapshot.
Encapsulates the snapshot-expiry data check and the contacts
response shaping previously performed in the GraphQL resolver
`browseContacts`.

- There are 9 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that occur before the specified cursor.
    - snappableFid - System.String: The FID for the workload.
    - snapshotFid - System.String: The ID of the snapshot.
    - folderId - System.String: The folder being browsed.
    - orgId - System.String: Org UUID.
    - contactsSearchFilter - ContactsSearchFilter: Search filter for contacts search.
- Returns O365ExchangeObjectConnection.
### browsefolder
BrowseMailboxFolderItems returns the contents (folders + emails) of
a mailbox folder inside a single snapshot. Encapsulates the
snapshot-expiry data check and the mailbox response shaping
previously performed in the GraphQL resolver `browseFolder`.

- There are 8 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that occur before the specified cursor.
    - snappableFid - System.String: The FID for the workload.
    - snapshotFid - System.String: The ID of the snapshot.
    - folderId - System.String: The folder being browsed.
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
### capsettingsdata
GetCapSettings returns the current CAP configuration JSON for an
Entra ID Conditional Access Policy principal.

- There is a single argument of type CapSettingsDataInput.
- Returns CapSettingsData.
### ccprovisionmetadata
Retrieves ccprovision metadata.

- There is a single argument of type CcProvisionMetadataReq.
- Returns CcProvisionMetadataReply.
### cdmadminuser
Retrieves the admin user metadata for a list of clusters.

- There is a single argument of type GetCdmUserRequest.
- Returns GetCdmUserResponse.
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
### classifiableassetcount
Returns the count of classifiable assets by platform.

- There are 2 arguments.
    - day - System.String: Date in the format (YYYY-MM-DD).
    - workloadTypes - list of DataGovObjectTypes: Types of workloads used for filtering the query results.
- Returns list of ClassifiableAssetCounts.
### clouddirectchecksharepath
CloudDirectCheckSharePath validates if a share path is accessible on the specified host.

- There is a single argument of type CloudDirectCheckSharePathReq.
- Returns CloudDirectCheckSharePathResp.
### clouddirectglobalsearch
CloudDirectGlobalSearch performs a global search across all NAS Cloud Direct objects on a cluster.

- There is a single argument of type CloudDirectGlobalSearchReq.
- Returns CloudDirectGlobalSearchResult.
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
### coordinatorlabels
GetCoordinatorLabels retrieves the current coordinator
labels for all virtual machines in a Cloud Direct cluster.

- There is a single argument of type GetCoordinatorLabelsReq.
- Returns CoordinatorLabelsReply.
### coordinatorlabelsvalidation
Checks whether the label configuration on a Cloud Direct cluster
supports backup operations. Returns an error with a customer-friendly
message when the configuration would prevent backups from running.

- There is a single argument of type System.String.
- Returns System.String.
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
Returns the custom analyzer with the given ID.

- There is a single argument of type System.String.
- Returns Analyzer.
### dailyviolationssummary
Daily summary of violations.

- There are 5 arguments.
    - startDate - DateTime: Start date for fetching summary.
    - endDate - DateTime: End date for fetching summary.
    - policyTypes - list of PolicyTypes: List of policy types. If empty, no results will be returned.
    - resourceFilter - ResourceFilterInput: Resource to filter by.
    - idpTypes - list of IdpTypes: Identity provider types to filter by. If empty or null, the results will not be filtered.
- Returns DailyViolationsSummary.
### dashboardsummary
Returns hits grouped by analyzer and policy.

- There is a single argument of type System.Boolean.
- Returns GetDashboardSummaryReply.
### dataaccessstats
Aggregated access statistics with breakdown by access type and exposure
information.

- There is a single argument of type DataAccessStatsInput.
- Returns DataAccessStatsResponse.
### datadiscoveryobjectscount
Returns the counts of objects that are assigned policies, objects that are not assigned policies, and objects that are not supported by Data Discovery.

- The datadiscoveryobjectscount subcommand takes no arguments.
- Returns DataDiscoveryObjectsCount.
### datagovsecdesc
Returns permissions associated with a path.

- There are 5 arguments.
    - snappableFid - System.String: FID of the workload to query.
    - snapshotFid - System.String: Snapshot FID to query permissions in.
    - stdPath - System.String: The standard path of the directory to browse.
    - skipResolveSids - System.Boolean: Skip converting SIDs in response to friendly names
    - filters - SddlRequestFiltersInput: Filter for resolving security descriptor.
- Returns QuerySDDLReply.
### datapreview
Retrieve the list of data previews.

- There is a single argument of type GetDataPreviewRequest.
- Returns GetDataPreviewReply.
### dataprotectioncoveragesummary
Get data protection coverage summary for all platforms.

- There is a single argument of type System.Int32.
- Returns DataProtectionCoverageSummary.
### decryptexporturl
Decrypts an encrypted Export URL Specs blob.

- There are 2 arguments.
    - workloadFid - System.String: The FID of the workload.
    - exportUrlSpecsEnc - System.String: Encrypted string of Export URL Specs containing arbitrary characters.
- Returns ExportUrlSpecs.
### defenderingestionstatuses
Get Defender ingestion status.

- The defenderingestionstatuses subcommand takes no arguments.
- Returns list of DefenderIngestionStatuss.
### deploymentipaddresses
All IP addresses on the Rubrik deployment.

- The deploymentipaddresses subcommand takes no arguments.
- Returns list of System.Strings.
### deploymentversion
Polaris deployment version.

- The deploymentversion subcommand takes no arguments.
- Returns System.String.
### devopsbackupjobinformation
Retrieves account specific backup information.

- There are 2 arguments.
    - devopsOrgType - DevopsOrgType: Specifies the type of the DevOps organization.
    - eventObjectTypes - list of EventObjectTypes: Specifies the event object types to scope the
lookup to. Defaults to the repository types for the org when empty.
- Returns DevOpsBackupJobInformation.
### devopsprotectedobjectcountsummary
DevOps Protected object count summary.

- There is a single argument of type ManagedObjectType.
- Returns DevOpsProtectedObjectCountSummary.
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
    - timezone - System.String: The timezone in which to display timestamps.
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
### documenttypes
Returns all the document types for an account.

- The documenttypes subcommand takes no arguments.
- Returns list of DocumentAttributes.
### documenttypesdetails
Retrieve the list of document types and their details.

- There is a single argument of type DocumentTypeStatusFilter.
- Returns ListDocumentTypesDetailsReply.
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
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that occur before the specified cursor.
    - filter - ListEntityInsightsFilterInput: Filter to be applied when retrieving entity insights.
- Returns NotificationConnection.
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
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that occur before the specified cursor.
    - ListFileActivitiesInput - ListFileActivitiesInput: Request for getting user activity for a specific path on a specific snapshot.
    - FileActivitiesSort - FileActivitiesSort: Sorts to apply when listing a file's user activities.
- Returns UserActivityResultConnection.
### fileschemaresults
Returns a paginated list of analyzed columns for a file's schema, filtered and
sorted by data type relevance.

- There are 10 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that occur before the specified cursor.
    - dataTypeIdsFilter - list of System.Strings: Data type IDs to filter.
    - snapshotFid - System.String: FID of the snapshot to analyze.
    - snappableFid - System.String: FID of the object whose file schema results are requested.
    - stdPath - System.String: The standard path of the file/directory to browse.
    - filter - FileStructureFiltersInput: Optional filter for data type IDs.
    - sort - FileStructureSortInput: Optional sort configuration.
- Returns AnalyzedColumnConnection.
### filesummariescount
Returns the counts of used and unused files categorized by risk level.

- There is a single argument of type System.String.
- Returns FilesSummaryCountResultType.
### fusioncomputedatastore
Summary of a FusionCompute datastore.

- There is a single argument of type System.String.
- Returns FusionComputeDatastore.
### fusioncomputedatastores
Summary of all FusionCompute datastores.

- There are 5 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - sortBy - HierarchySortByField: Sort hierarchy objects according to the hierarchy field.
    - sortOrder - SortOrder: Sorts the order of results.
    - filter - list of Filters: Hierarchy object filter.
- Returns FusionComputeDatastoreConnection.
### fusioncomputeecho
Test endpoint. Remove once we have a real API.

- There is a single argument of type FusionComputeEchoRequest.
- Returns FusionComputeEchoResponse.
### fusioncomputemounts
Retrieve the list of FusionCompute live mounts.

- There are 7 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that occur before the specified cursor.
    - filter - list of QueryFusionComputeMountsFilters: Filter for the query.
    - sortBy - FusionComputeMountsSortByField: Field to sort by.
    - sortOrder - SortOrder: Sort order.
- Returns FusionComputeMountDetailConnection.
### fusioncomputenetwork
Summary of a FusionCompute network.

- There is a single argument of type System.String.
- Returns FusionComputeNetwork.
### fusioncomputenetworks
Summary of all FusionCompute networks.

- There are 5 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - sortBy - HierarchySortByField: Sort hierarchy objects according to the hierarchy field.
    - sortOrder - SortOrder: Sorts the order of results.
    - filter - list of Filters: Hierarchy object filter.
- Returns FusionComputeNetworkConnection.
### fusioncomputerecoverabledatastores
Summary of all FusionCompute datastores that the user can recover to.

- There are 5 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - sortBy - HierarchySortByField: Sort hierarchy objects according to the hierarchy field.
    - sortOrder - SortOrder: Sorts the order of results.
    - filter - list of Filters: Hierarchy object filter.
- Returns FusionComputeDatastoreConnection.
### fusioncomputerecoverablenetworks
Summary of all FusionCompute networks that the user can recover to.

- There are 5 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - sortBy - HierarchySortByField: Sort hierarchy objects according to the hierarchy field.
    - sortOrder - SortOrder: Sorts the order of results.
    - filter - list of Filters: Hierarchy object filter.
- Returns FusionComputeNetworkConnection.
### fusioncomputesite
Summary of a FusionCompute site.

- There is a single argument of type System.String.
- Returns FusionComputeSite.
### fusioncomputesites
Summary of all FusionCompute sites.

- There are 5 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - sortBy - HierarchySortByField: Sort hierarchy objects according to the hierarchy field.
    - sortOrder - SortOrder: Sorts the order of results.
    - filter - list of Filters: Hierarchy object filter.
- Returns FusionComputeSiteConnection.
### fusioncomputevirtualdisks
Get FusionCompute virtual disks for a virtual machine.

- There are 8 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that occur before the specified cursor.
    - fusionComputeVirtualMachineFid - System.String: FID of a FusionCompute virtual machine.
    - filter - list of QueryFusionComputeVirtualDisksFilters: Filter for the query.
    - sortBy - FusionComputeVirtualDisksSortByField: Field to sort by.
    - sortOrder - SortOrder: Sort order.
- Returns FusionComputeVirtualDiskConnection.
### fusioncomputevirtualmachine
Summary of a FusionCompute virtual machine.

- There is a single argument of type System.String.
- Returns FusionComputeVirtualMachine.
### fusioncomputevirtualmachines
Summary of all FusionCompute virtual machines.

- There are 5 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - sortBy - HierarchySortByField: Sort hierarchy objects according to the hierarchy field.
    - sortOrder - SortOrder: Sorts the order of results.
    - filter - list of Filters: Hierarchy object filter.
- Returns FusionComputeVirtualMachineConnection.
### fusioncomputevmrequeststatus
Get asynchronous request details for FusionCompute requests

Supported in v9.6
Get the details of an asynchronous request that involves FusionCompute operations.

- There is a single argument of type FusionComputeVmRequestStatusInput.
- Returns AsyncRequestStatus.
### fusioncomputevrm
Summary of a FusionCompute VRM.

- There is a single argument of type System.String.
- Returns FusionComputeVrm.
### fusioncomputevrms
Summary of all FusionCompute VRMs.

- There are 5 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - sortBy - HierarchySortByField: Sort hierarchy objects according to the hierarchy field.
    - sortOrder - SortOrder: Sorts the order of results.
    - filter - list of Filters: Hierarchy object filter.
- Returns FusionComputeVrmConnection.
### geolocationlist
- The geolocationlist subcommand takes no arguments.
- Returns list of GroupCounts.
### getallrolesinorglist
Get all roles in the current organization with filtering, sorting, and
pagination support.

- There are 9 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that occur before the specified cursor.
    - sortOrder - SortOrder: Sorts the order of results.
    - sortBy - RoleFieldEnum: Field to sort roles by (e.g., Name or Assignment).
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
### getcloudobjectscountbyregion
Get the count of cloud objects by region.

- There are 2 arguments.
    - workloadTypes - list of ManagedObjectTypes: Workload type for the protection summary dashboard.
    - awsServiceTypeFilter - list of AwsCloudAccountServiceTypes: Filter AWS objects by deployment model (BaaS / non-BaaS). Non-AWS objects pass through unfiltered. Empty or omitted disables the filter.
- Returns GetCloudObjectsCountByRegionReply.
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
Retrieve the status of the Laminar feature enablement for various cloud types.

- The getlaminarfeaturestatus subcommand takes no arguments.
- Returns GetLaminarFeatureStatusReply.
### getobjectprotectionandsensitivitysummary
Get the object protection and sensitivity summary for the UCL Laminar dashboard.

- There are 2 arguments.
    - workloadTypes - list of ManagedObjectTypes: Workload type for the protection summary dashboard.
    - awsServiceTypeFilter - list of AwsCloudAccountServiceTypes: Filter AWS objects by deployment model (BaaS / non-BaaS). Non-AWS objects pass through unfiltered. Empty or omitted disables the filter.
- Returns GetObjectProtectionAndSensitivitySummaryReply.
### getpermissions
Permissions assigned to the role that are in effect.

- There is a single argument of type System.String.
- Returns list of Permissions.
### getrolesbyids
Get roles by IDs.

- There are 2 arguments.
    - roleIds - list of System.Strings: List of role IDs to retrieve.
    - syncedClustersFilter - System.String: Name to filter the synced clusters for role.
- Returns list of Roles.
### getuserdownloads
GetUserDownloads returns downloads of a user in the last 24 hours.

- There are 4 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that occur before the specified cursor.
- Returns list of UserDownloads.
### githubconnectionstatussummary
GitHubConnectionStatusSummary returns the connection status of all the
GitHub cloud accounts.

- The githubconnectionstatussummary subcommand takes no arguments.
- Returns GitHubConnectionStatusSummaryReply.
### githuborganization
Query GitHub organization object.

- There is a single argument of type System.String.
- Returns GithubOrganization.
### githuborganizations
Query GitHub organization objects.

- There are 10 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that occur before the specified cursor.
    - queryType - QueryType: The type of query to perform (CHILDREN or DESCENDANTS).
    - ancestorId - System.String: Ancestor object/root ID.
    - filter - list of Filters: The hierarchy object filter.
    - sortBy - HierarchySortByField: Sort hierarchy objects according to the hierarchy field.
    - sortOrder - SortOrder: Sorts the order of results.
    - workloadHierarchy - WorkloadLevelHierarchy: Each enumeration value represents the hierarchy of a specific workload type for RBAC and SLA Domain assignments.  A value of 'None' represents the hierarchy of all workload types.
- Returns GithubOrganizationConnection.
### githubrepositories
Query GitHub repository objects.

- There are 10 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that occur before the specified cursor.
    - queryType - QueryType: The type of query to perform (CHILDREN or DESCENDANTS).
    - ancestorId - System.String: Ancestor object/root ID.
    - filter - list of Filters: The hierarchy object filter.
    - sortBy - HierarchySortByField: Sort hierarchy objects according to the hierarchy field.
    - sortOrder - SortOrder: Sorts the order of results.
    - workloadHierarchy - WorkloadLevelHierarchy: Each enumeration value represents the hierarchy of a specific workload type for RBAC and SLA Domain assignments.  A value of 'None' represents the hierarchy of all workload types.
- Returns GithubRepositoryConnection.
### githubrepository
Query GitHub repository object.

- There is a single argument of type System.String.
- Returns GithubRepository.
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
### glueiceberginventorystats
Returns aggregate counts for the AWS Glue Iceberg inventory card:
AWS native accounts with the Glue Iceberg feature enabled, total
catalogs, total databases, total tables, and protected tables. All
counts are scoped to what the caller can see.

- The glueiceberginventorystats subcommand takes no arguments.
- Returns GlueIcebergInventoryStatsReply.
### glueicebergtable
Represents an AWS Glue Iceberg Table with a specific Rubrik ID.

- There are 2 arguments.
    - glueIcebergTableRubrikId - System.String: Rubrik ID for the AWS Glue Iceberg table object.
    - includeSecurityMetadata - System.Boolean: Filter to include the security metadata.
- Returns GlueIcebergTable.
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
### hitsexposurestats
hitsExposureStats returns the aggregated statistics for exposure of
sensitive data.

- There is a single argument of type GetHitsExposureStatsInput.
- Returns GetHitsExposureStatsReply.
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
### isappaccessgraphready
Checks whether app access data is available for a domain.
Returns true when app assignment data is ready for the specified domain.

- There is a single argument of type System.String.
- Returns System.Boolean.
### isclouddirectsharepathvalid
IsCloudDirectSharePathValid validates if a share path is
accessible on the specified system.

- There is a single argument of type CloudDirectValidateSharePathReq.
- Returns CloudDirectValidateSharePathResp.
### isidentitysecurityroleassignmentcomplete
If IR room is configured.

- The isidentitysecurityroleassignmentcomplete subcommand takes no arguments.
- Returns System.Boolean.
### isidpsetupcomplete
Checks if any identity provider is set up.

- There is a single argument of type list of ManagedObjectTypes.
- Returns System.Boolean.
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
List IDs of running issues jobs.

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
Retrieves the contents of a single knowledge base article.

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
### laminarssodetails
SSO details required to deep link from RSC into the Laminar (DSPM) environment
associated with the current account.

- The laminarssodetails subcommand takes no arguments.
- Returns GetLaminarSSODetailsReply.
### latestgposettings
GetLatestGpoSettings returns the current GPO settings from the latest
DC snapshot, without requiring a change event. Use this when the GPO
has no activity events or when you need the current state regardless
of event history.

- There is a single argument of type GetLatestGpoSettingsReq.
- Returns GetLatestGpoSettingsRes.
### licensedproducts
Information about the licenses at the product level.

- The licensedproducts subcommand takes no arguments.
- Returns GetLicensedProductsInfoReply.
### listaccessgrantingidentities
ListAccessGrantingIdentities returns a list of identities that grant access to resources
based on the provided filter criteria.

- There are 5 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that occur before the specified cursor.
    - filter - AccessFilter: Filter to be applied when retrieving access granting identities.
- Returns PrincipalSummaryConnection.
### listalluploadrecords
List all the upload records.

- There is a single argument of type ListAllUploadRecordsInput.
- Returns ListAllUploadRecordsReply.
### listdataaccessidentities
ListDataAccessIdentities returns a list of identities with access to resources
based on the provided filter criteria.

- There are 5 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that occur before the specified cursor.
    - filter - AccessFilter: Filter to be applied when retrieving access identities.
- Returns PrincipalSummaryConnection.
### listlinkedentitiesforgpo
Returns a paginated list of AD structural entities (OUs, Domains, Sites)
linked to a specific GPO, along with GPO link details.

- There are 6 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that occur before the specified cursor.
    - filter - ListLinkedEntitiesForGpoFilterInput: Optional filter criteria for linked entities.
    - gpoId - System.String: Identifies the GPO whose linked entities to list.
- Returns LinkedEntityConnection.
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
### multihopupgradepath
Support portal related APIs
Returns the ordered sequence of CDM versions required to upgrade
from source_version to target_version. If source_version is omitted,
the current installed version for cluster_uuid is used.

- There are 4 arguments.
    - clusterUuid - System.String: The UUID of the cluster to upgrade.
    - sourceVersion - System.String: CDM version to upgrade from (e.g. "9.3.1-p1").
If empty, retrieved from the cdm_upgrades table.
    - targetVersion - System.String: The CDM version to upgrade to (e.g. "9.5.0").
    - shouldIncludeFullVersionName - System.Boolean: When true, returns the full release
version name including patch and build
number for each hop.
- Returns MultiHopUpgradePathReply.
### mysqldatabase
Details of a MySQL database for a given FID.

- There is a single argument of type System.String.
- Returns MysqldbDatabase.
### mysqldatabases
Connection of filtered MySQL databases based on specific filters.

- There are 5 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - sortBy - HierarchySortByField: Sort hierarchy objects according to the hierarchy field.
    - sortOrder - SortOrder: Sorts the order of results.
    - filter - list of Filters: Hierarchy object filter.
- Returns MysqldbDatabaseConnection.
### mysqlinstance
Details of a MySQL instance for a given FID.

- There is a single argument of type System.String.
- Returns MysqldbInstance.
### mysqlinstancelivemounts
The live mounts associated with the specified workloads.

- There are 4 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - filters - list of KosmosWorkloadLiveMountFilterInputs: Filter for Kosmos workload live mounts.
    - sortBy - KosmosWorkloadLiveMountSortByInput: Sort the live mounts of the Kosmos Workload based on the argument.
- Returns KosmosWorkloadLiveMountConnection.
### mysqlinstances
Connection of filtered MySQL instances based on specific filters.

- There are 5 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - sortBy - HierarchySortByField: Sort hierarchy objects according to the hierarchy field.
    - sortOrder - SortOrder: Sorts the order of results.
    - filter - list of Filters: Hierarchy object filter.
- Returns MysqldbInstanceConnection.
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
### nodestoremovebycount
Calculates which nodes to remove based on a specified removal count.
The backend auto-selects nodes while maintaining the dynamic-to-static
node ratio.

- There are 6 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that occur before the specified cursor.
    - clusterUuid - System.String: Unique ID of the Rubrik cluster.
    - nodeCount - System.Int32: Number of nodes to remove.
- Returns NodeToRemoveByCountConnection.
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
    - timezone - System.String: The timezone in which to display timestamps.
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
### objecttagkeys
List of object tag keys.

- The objecttagkeys subcommand takes no arguments.
- Returns list of System.Strings.
### objecttagvalues
List of object tag values for a particular key.

- There is a single argument of type System.String.
- Returns list of System.Strings.
### objecttypeaccesssummary
Returns total sensitive hits grouped by object type and also gives policy level breakdown for each object type.

- There are 11 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that occur before the specified cursor.
    - timelineDate - System.String: Date for which the results will be retrieved.
    - historicalDeltaDays - System.Int32: Number of historical days to go backward in time to calculate the delta.
    - includeWhitelistedResults - System.Boolean: Specifies whether allowlisted results should be included.
    - sortOrder - SortOrder: Sorts the order of results.
    - filter - ObjectTypeSummariesFilter: Filter for object type summary.
    - sort - ObjectTypeAccessSummarySortBy: Field on which to perform the sorting operation.
    - groupBy - ObjectTypeAccessSummaryGroupBy: Field on which to perform the grouping operation.
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
### ownersfiltervalues
GetOwnersFilterValues returns potential owners for identity filters.

- There is a single argument of type GetOwnersFilterValuesInput.
- Returns GetOwnersFilterValuesReply.
### passkeyconfig
Passkey config for current org.

- The passkeyconfig subcommand takes no arguments.
- Returns GetPasskeyConfigReply.
### passkeyinfo
Information about passkey config and current user's passkeys.

- The passkeyinfo subcommand takes no arguments.
- Returns GetPasskeyInfoReply.
### pausedobjects
Retrieves a list of directly paused objects based on the provided filters and arguments.

- There are 6 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that occur before the specified cursor.
    - sortBy - GetObjectPauseListSortByParams: Optional paramater to sort the response based on the provided field and order.
    - filter - GetObjectPauseListFilterParams: Optional paramater to filter the response based on the provided fields.
- Returns GetPausedObjectResConnection.
### pendingaction
Retrieve a specific pending action by its ID.

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
### policiesmaxlastevaluatedat
Get the maximum 'Last evaluated at' timestamp for policies.

- There is a single argument of type list of PolicyTypes.
- Returns GetPoliciesMaxLastEvaluatedAtType.
### policydetails
Returns data categories for an account.

- There are 12 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that occur before the specified cursor.
    - dataCategoryIds - list of System.Strings: Filter for data category IDs.
    - dataTypeIds - list of System.Strings: Data type IDs to filter.
    - dataCategoryType - DataCategoryType: Filter for data category type.
    - documentTypeIds - list of System.Strings: Document type IDs to filter.
    - sortBy - PoliciesDetailSortByField: Field to sort policies detail entries by.
    - sortOrder - SortOrder: Sorts the order of results.
    - includeInactiveDataCategories - System.Boolean: Include inactive data categories.
    - dataCategoryFilter - DataCategoryFilter: Filter controlling which data categories to include. Defaults to ACTIVE_DATA_CATEGORIES.
- Returns PolicyDetailConnection.
### policyobj
Returns details for one policy object.

- There are 3 arguments.
    - snappableFid - System.String: The unique identifier of the workload.
    - snapshotFid - System.String: The unique identifier of the snapshot.
    - includeWhitelistedResults - System.Boolean: Specifies whether allowlisted results should be included.
- Returns PolicyObj.
### policyobjfolderchildren
Browse the contents of a directory within a data governance policy object snapshot.

- There are 10 arguments.
    - workloadId - System.String: The ID of the workload.
    - snapshotId - System.String: The ID of the snapshot.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that occur before the specified cursor.
    - filter - BrowseDirectoryFiltersInput: Filters for browsing directory contents.
    - sort - FileResultSortInput: Sorts to apply when listing file results.
    - stdPath - System.String: The standard path of the directory to browse.
    - timezone - System.String: The timezone in which to display timestamps.
- Returns FileResultConnection.
### policyobjopt
Returns details for one policy object if it exists.

- There are 3 arguments.
    - snappableFid - System.String: The unique identifier of the workload.
    - snapshotFid - System.String: The unique identifier of the snapshot.
    - includeWhitelistedResults - System.Boolean: Specifies whether allowlisted results should be included.
- Returns PolicyObj.
### policyobjs
Returns status for all objects at a specified timestamp.

- There are 46 arguments.
    - day - System.String: Date in the format (YYYY-MM-DD).
    - timezone - System.String: The timezone in which to display timestamps.
    - workloadTypes - list of DataGovObjectTypes: Types of workloads that can be used for filtering query results.
    - sortBy - System.String: Name of the column to sort result by.
    - sortOrder - SortOrder: Sorts the order of results.
    - analysisStatusesFilter - list of AnalysisStatuss: List of analysis statuses used for filtering results.
    - policyIdsFilter - list of System.Strings: List of policies used for filtering results.
    - riskLevelsFilter - list of RiskLevelTypes: List of risk levels used for filtering results.
    - clusterIdsFilter - list of System.Strings: List of Rubrik clusters for filtering results.
    - searchObjectName - System.String: Object name to search.
    - subscriptionIdsFilter - list of System.Strings: List of subscriptions for filtering results.
    - includeWhitelistedResults - System.Boolean: Specifies whether allowlisted results should be included.
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
    - totalPrincipalCountsOnly - System.Boolean: When true, only total principal counts are computed, skipping per-risk-level breakdown.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that occur before the specified cursor.
- Returns PolicyObjConnection.
### policyviolation
Get a single policy violation.

- There are 2 arguments.
    - violationId - System.String: Violation ID.
    - policyTypes - list of PolicyTypes: List of policy types. If empty, no results will be returned.
- Returns PolicyViolation.
### policyviolationhistoryentries
Get the lifecycle history of a single policy violation, including status
changes and remediation activity, ordered by timestamp descending.

- There are 6 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that occur before the specified cursor.
    - violationId - System.String: The ID of the policy violation.
    - policyType - PolicyType: The policy type of the violation. Must match the
violation's actual policy type.
- Returns PolicyViolationHistoryEntryConnection.
### policyviolations
Get a paginated list of policy violations.

- There are 31 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that occur before the specified cursor.
    - policyIds - list of System.Strings: Policy IDs to filter by. If empty or null, the results will not be filtered.
    - resourceIds - list of System.Strings: Resource IDs to filter by. If empty or null, the results will not be filtered.
    - statuses - list of PolicyViolationStatuss: Policy violation statuses to filter by. If empty or null, the results will not be filtered.
    - statusReasons - list of PolicyViolationStatusReasons: Policy violation status reasons to filter by. If empty or null, the results will not be filtered.
    - policyTypes - list of PolicyTypes: List of policy types. If empty, no results will be returned.
    - policyViolationIds - list of System.Strings: Policy violation IDs to filter by. If empty or null, the results will not be filtered.
    - policySeverities - list of Severitys: Policy severities to filter by. If empty or null, the results will not be filtered.
    - policyCategories - list of Categorys: Policy categories to filter by. If empty or null, the results will not be filtered.
    - includeDeletedPolicies - System.Boolean: Include deleted policies in the results. If null or false, deleted policies will be excluded.
    - resourceTypes - list of PolicyResourceTypes: Resource types to filter by. If empty or null, the results will not be filtered.
    - sensitivityLevels - list of SensitivityLevels: Sensitivity levels to filter by. If empty or null, the results will not be filtered.
    - detectionDate - TimeRangeInput: Detection date range to filter by. If null, the results will not be filtered.
    - updateDate - TimeRangeInput: Violation update date range to filter by.
    - lastSeenDate - TimeRangeInput: Last seen date range to filter by. If null, the results will not be filtered.
    - includeResourceCounts - System.Boolean: Include resource-level total violation counts. If null, the data will not be included.
    - resourceMetadataFilter - ResourceMetadataFiltersInput: Resource metadata fields to filter by. If null, the results will not be filtered.
    - parentViolationId - System.String: Parent violation ID.
    - dataTypeIds - list of System.Strings: Data type IDs to filter.
    - documentTypeIds - list of System.Strings: Document type IDs to filter.
    - dataCategoryIds - list of System.Strings: Filter for data category IDs.
    - sortBy - PolicyViolationSortField: Field by which to sort policy violations.
    - sortOrder - SortOrder: Sort order for policy violations.
    - principalFilter - PrincipalSummariesFilterInput: Principal fields to filter by. If null, the results will not be filtered.
    - policyViolationNameSearch - System.String: Policy violation name to search for (substring match).
    - policyFrameworks - list of System.Strings: Policy frameworks to filter by. If empty or null, the results will not be filtered.
    - ticketNumbers - list of System.Strings: Ticket numbers to filter violations by. If empty or null, the results will not be filtered.
    - violationNames - list of System.Strings: Exact violation names to filter by. OR-combined with policyIds: a violation matches if its policyId is in policyIds OR its violationName is in violationNames. Distinct from policyViolationNameSearch (substring match, AND-combined).
- Returns PolicyViolationConnection.
### policyviolationsbyresource
Get a paginated list of policy violations grouped by resource.

- There are 27 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that occur before the specified cursor.
    - policyIds - list of System.Strings: Policy IDs to filter by. If empty or null, the results will not be filtered.
    - resourceIds - list of System.Strings: Resource IDs to filter by. If empty or null, the results will not be filtered.
    - statuses - list of PolicyViolationStatuss: Policy violation statuses to filter by. If empty or null, the results will not be filtered.
    - statusReasons - list of PolicyViolationStatusReasons: Policy violation status reasons to filter by. If empty or null, the results will not be filtered.
    - policyTypes - list of PolicyTypes: List of policy types. If empty, no results will be returned.
    - policyViolationIds - list of System.Strings: Policy violation IDs to filter by. If empty or null, the results will not be filtered.
    - policySeverities - list of Severitys: Policy severities to filter by. If empty or null, the results will not be filtered.
    - policyCategories - list of Categorys: Policy categories to filter by. If empty or null, the results will not be filtered.
    - includeDeletedPolicies - System.Boolean: Include deleted policies in the results. If null or false, deleted policies will be excluded.
    - resourceTypes - list of PolicyResourceTypes: Resource types to filter by. If empty or null, the results will not be filtered.
    - sensitivityLevels - list of SensitivityLevels: Sensitivity levels to filter by. If empty or null, the results will not be filtered.
    - detectionDate - TimeRangeInput: Detection date range to filter by. If null, the results will not be filtered.
    - updateDate - TimeRangeInput: Violation update date range to filter by.
    - parentViolationId - System.String: Parent violation ID.
    - dataTypeIds - list of System.Strings: Data type IDs to filter.
    - documentTypeIds - list of System.Strings: Document type IDs to filter.
    - dataCategoryIds - list of System.Strings: Filter for data category IDs.
    - sortBy - PolicyViolationSortField: Field by which to sort policy violations.
    - sortOrder - SortOrder: Sort order for policy violations.
    - policyViolationNameSearch - System.String: Policy violation name to search for (substring match).
    - principalMetadataFilters - PrincipalMetadataFiltersInput: Principal metadata fields to filter by. If null, the results will not be filtered.
    - policyFrameworks - list of System.Strings: Policy frameworks to filter by. If empty or null, the results will not be filtered.
    - violationNames - list of System.Strings: Exact violation names to filter by. OR-combined with policyIds: a violation matches if its policyId is in policyIds OR its violationName is in violationNames. Distinct from policyViolationNameSearch (substring match, AND-combined).
- Returns PolicyViolationsByResourceConnection.
### postgresqldatabase
Details of a PostgreSQL database for a given FID.

- There is a single argument of type System.String.
- Returns PostgreSQLDatabase.
### postgresqldatabases
Connection of filtered postgres database based on specific filters.

- There are 5 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - sortBy - HierarchySortByField: Sort hierarchy objects according to the hierarchy field.
    - sortOrder - SortOrder: Sorts the order of results.
    - filter - list of Filters: Hierarchy object filter.
- Returns PostgreSQLDatabaseConnection.
### prechecksstatus
Gets status of last prechecks job.

- There is a single argument of type System.String.
- Returns PrechecksStatusReply.
### prechecksstatuswithnextjobinfo
Get status of last completed prechecks Job along with details of currently running/scheduled next prechecks Job.

- There is a single argument of type System.String.
- Returns PrechecksStatusReply.
### principalapipermissions
GetPrincipalApiPermissions returns API permissions information for a
principal.

- There is a single argument of type PrincipalApiPermissionsInput.
- Returns PrincipalApiPermissionsReply.
### principalattributes
ListPrincipalAttributes returns per-principal directory attributes as a
cursor-paginated connection. Joins userawareness_principals_version
(UAPV) with userawareness_principals (UAP) on sid; returns one entry
per principal carrying its identifying fields plus an open bag of
attributes deserialized from UAPV.metadata (minus a server-side
sensitive-attribute deny-list).

v1 reality: only ON_PREM_AD principals carry populated attributes;
non-AD principals return with an empty bag.

Authorization: ViewIdentityResiliency, account-scoped (tenant
isolation enforced by the per-account customer DB).

- There are 5 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that occur before the specified cursor.
    - filter - PrincipalAttributeFilter: Optional filter (IdP types, principal types, domains,
prefix search on display name / SID).
- Returns PrincipalAttributesConnection.
### principalcountssummaries
Stats APIs
Principal count summaries.

- There are 2 arguments.
    - filter - PrincipalCountsFilterInput: Filter to be applied when retrieving principal count summaries.
    - historicalDeltaDays - System.Int32: Number of historical days to go backward in time to calculate the delta.
- Returns GetPrincipalCountsReply.
### principaldepartments
Returns distinct department values across all principals, used to
populate the department filter in the identity inventory UI.

- There is a single argument of type System.String.
- Returns list of System.Strings.
### principaldetails
Get principal details.

- There are 3 arguments.
    - sid - System.String: Security identifier.
    - timelineDate - System.String: Date for which the results will be retrieved.
    - includeWhitelistedResults - System.Boolean: Specifies whether whitelisted results should be included.
- Returns PrincipalDetails.
### principalentities
Principal entities.

- There is a single argument of type PrincipalEntitiesFilterInput.
- Returns list of PrincipalEntitys.
### principalobjectsummaries
List of principal object summaries.

- There are 9 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that occur before the specified cursor.
    - sids - list of System.Strings: List of security identifiers.
    - filter - PrincipalObjectSummariesFilterInput: Filter to be applied when retrieving principal object summaries.
    - timelineDate - System.String: Date for which the results will be retrieved.
    - includeCount - System.Boolean: Include counts in the results.
    - includeWhitelistedResults - System.Boolean: Specifies whether whitelisted results should be included.
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
    - historicalDeltaDays - System.Int32: Number of historical days to go backward in time to calculate the delta.
    - principalRiskSummaryPrincipalType - PrincipalRiskySummaryPrincipalType: Specifies the type of principal.
    - includeWhitelistedResults - System.Boolean: Specifies whether whitelisted results should be included.
    - PrincipalSummaryFilterType - PrincipalSummaryFilter: Principal summary filter.
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

- There are 13 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that occur before the specified cursor.
    - filter - PrincipalSummariesFilterInput: Filter to be applied when retrieving principal summaries.
    - timelineDate - System.String: Date for which the results will be retrieved.
    - sort - ListPrincipalsSummarySortInput: Field on which to perform the sorting operation.
    - includeCount - System.Boolean: Include counts in the results.
    - historicalDeltaDays - System.Int32: Number of historical days to go backward in time to calculate the delta.
    - includeWhitelistedResults - System.Boolean: Specifies whether whitelisted results should be included.
    - insightsMetadataId - System.String: Filter objects with insights metadata ID.
    - includeInsightsMarker - System.Boolean: Specifies whether to include the insights marker.
    - includeAdditionalMetadata - System.Boolean: Specifies whether to include additional metadata required for a feature.
- Returns PrincipalSummaryConnection.
### principalsummary
principalSummary returns the principal summary.

- There is a single argument of type GetPrincipalSummaryReqInput.
- Returns GetPrincipalSummaryReply.
### principaltagstats
principalTagStats returns the aggregated statistics for principal tags.

- There is a single argument of type GetPrincipalTagStatsInput.
- Returns GetPrincipalTagStatsReply.
### principaltitles
Principal titles.

- There is a single argument of type PrincipalTitlesFilterInput.
- Returns list of System.Strings.
### privatecontainerregistry
Retrieves the Private Container Registry (PCR) details for an Exocompute cloud account.

- There is a single argument of type PrivateContainerRegistryInput.
- Returns PrivateContainerRegistryReplyType.
### privilegedprincipalsummaries
Privileged Principal Summaries.

- There are 2 arguments.
    - filter - PrivilegedPrincipalFilterInput: Filter to be applied when retrieving privileged principal summaries.
    - historicalDeltaDays - System.Int32: Number of historical days to go backward in time to calculate the delta.
- Returns GetPrivilegedPrincipalsSummaryResp.
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
### protectionsummaryv2
Returns the protection summary for the Orchestrated Application Recovery
dashboard.

- The protectionsummaryv2 subcommand takes no arguments.
- Returns ProtectionSummaryV2.
### purestorageprotectiongroupquiescecandidates
List candidate quiesce targets for a Pure Storage protection group.

Supported in v9.6
Retrieve the discoverable VMware virtual machines (backed by the protection group's Pure volumes via VMFS datastores) and the connected RBA-installed hosts that the customer can select as quiesce targets for the protection group's app-consistent snapshot. The two streams are concatenated into a single ListResponse (VMware entries first, then RBA hosts) with stable per-source ordering so pagination is consistent across calls. Unreachable vCenters during discovery are logged at WARN server-side and silently skipped; the response carries no vCenter-status field because vCenter health is owned by the existing vCenter status surface. Authorization is the protection group's Read privilege; the caller's AuthorizationContext scopes both the virtual machine cross-check and the host listing so the response cannot be used to probe for objects the caller cannot already see.

- There is a single argument of type PureStorageProtectionGroupQuiesceCandidatesInput.
- Returns QuiesceCandidateListResponse.
### purestorageprotectiongroupsv1
Connection of Pure Storage protection groups.

- There are 5 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - sortBy - HierarchySortByField: Sort hierarchy objects according to the hierarchy field.
    - sortOrder - SortOrder: Sorts the order of results.
    - filter - list of Filters: Hierarchy object filter.
- Returns PureStorageProtectionGroupV1Connection.
### purestorageprotectiongroupv1
Details of a Pure Storage protection group for a given ID.

- There is a single argument of type System.String.
- Returns PureStorageProtectionGroupV1.
### purestoragevolumesv1
Connection of Pure Storage volumes.

- There are 5 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - sortBy - HierarchySortByField: Sort hierarchy objects according to the hierarchy field.
    - sortOrder - SortOrder: Sorts the order of results.
    - filter - list of Filters: Hierarchy object filter.
- Returns PureStorageVolumeV1Connection.
### purestoragevolumev1
Details of a Pure Storage volume for a given ID.

- There is a single argument of type System.String.
- Returns PureStorageVolumeV1.
### quarantineddetailsforworkload
Quarantine details of a workload.

- There is a single argument of type System.String.
- Returns list of QuarantineSpecs.
### querydatastorefreespacethresholds
Query datastore threshold configurations.

- There is a single argument of type list of QueryDatastoreFreespaceThresholdInputs.
- Returns QueryDatastoreFreespaceThresholdsReply.
### recoveries
Return a paginated list of recoveries corresponding to the filter passed.
RSC prioritizes recovery_ids if they are passed in the filter. All the filters, if passed, will work as AND logic.
A maximum of 50 objects per page is supported.

- There are 18 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that occur before the specified cursor.
    - recoveryIds - list of System.Strings: Filter by specific recovery IDs.
    - recoveryType - list of RecoveryTypes: Filter by recovery type.
    - endTime - DateTime: Only consider recoveries that started before this date.
    - startTime - DateTime: Only consider recoveries that started after this date.
    - recoveryPlanNames - list of System.Strings: Filter by recovery plan names.
    - workloadIds - list of System.Strings: Filter by workload IDs.
    - recoveryStatuses - list of RecoveryStatuss: Filter by recovery statuses.
    - recoveryOutcomes - list of RecoveryOutcomes: Filter by recovery outcomes.
    - recoveryNames - list of System.Strings: Filter by recovery names.
    - recoveryTriggeredFrom - list of RecoveryTriggeredFroms: Filter by how the recovery was triggered.
    - recoveryPlanIds - list of System.Strings: Filter by recovery plan IDs.
    - workloadTypeFilter - ManagedObjectType: Filter by workload type.
    - recoveryNameSubstring - System.String: Filter by recovery name substring.
    - sortParam - RecoverySortParamInput: Sorting parameters for the recovery list.
- Returns RecoveryConnection.
### recoveryspecs
List the workload recovery specifications associated with the given
recovery plan.
If recovery ID is provided it will retrieve recovery specifications
specific to that recovery.
Else it retrieves recovery specifications for the given recovery plan.

- There is a single argument of type RecoverySpecsInput.
- Returns RecoverySpecsReply.
### regions
List of regions.

- There is a single argument of type System.String.
- Returns list of System.Strings.
### remediationtypes
Get the list of possible remediation types for targets.

- There are 5 arguments.
    - violationId - System.String: Violation ID.
    - targets - RemediationTargetsInput: Remediation target IDs and their type.
    - location - RemediationLocation: Remediation location.
    - resourceType - PolicyResourceType: Resource type.
    - resourceId - System.String: Resource ID.
- Returns GetRemediationTypesType.
### removednodedetails
Get the information for removed nodes.

- There is a single argument of type RemovedNodeDetailsInput.
- Returns RemoveNodeDetailsReply.
### resettypeofremovaljob
Get the reset type of a node removal job.

- There is a single argument of type ResetTypeOfRemovalJobInput.
- Returns ResetTypeOfRemovalJob.
### resourcegroups
List of resource groups.

- There is a single argument of type System.String.
- Returns list of ResourceGroupInfos.
### resourcespecs
Lists resource specifications for the specified Recovery Plan or recovery.
If both a recovery ID and a Recovery Plan ID are provided, we return the
resource specifications used by that recovery and ignore the Recovery
Plan ID.

- There is a single argument of type ListResourceSpecsReq.
- Returns list of WorkloadResourceSpecs.
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
    - roleId - System.String: ID of the role.
    - protectableClusters - list of System.Strings: List of protectable clusters.
    - permissions - list of PermissionInputs: Permissions in the role.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that occur before the specified cursor.
- Returns RscPermsToCdmInfoOut.
### rvcdeploymenttoollink
Download links for the Rubrik Virtual Cluster Deployment Tool (Linux/Windows/MacOS).
Shared by both RVC LS and RVC SS wizards because the RVCDT binaries are product-agnostic.

- The rvcdeploymenttoollink subcommand takes no arguments.
- Returns RvcDeploymentToolLink.
### rvclsovadetails
The Rubrik CDM OVA details for RVC Local Storage.

- The rvclsovadetails subcommand takes no arguments.
- Returns list of CdmOvaDetails.
### rvcssovadetails
The Rubrik CDM OVA details for RVC Shared Storage.

- The rvcssovadetails subcommand takes no arguments.
- Returns list of CdmOvaDetails.
### s3tablesiceberginventorystats
Returns aggregate counts for the AWS S3 Tables Iceberg inventory card.
Scoped to the caller's visible objects.

- The s3tablesiceberginventorystats subcommand takes no arguments.
- Returns S3TablesIcebergInventoryStatsReply.
### saasapporganizations
List of SaaS app organization.

- There are 9 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that occur before the specified cursor.
    - sortBy - HierarchySortByField: Sort hierarchy objects according to the hierarchy field.
    - sortOrder - SortOrder: Sorts the order of results.
    - filter - list of Filters: The hierarchy object filter.
    - typeFilter - list of HierarchyObjectTypeEnums: Types of objects to include.
    - recoveryTargetFilter - RecoveryTargetFilter: Filter for organizations that are valid recovery targets for a source organization.
- Returns SaasAppsOrganizationConnection.
### saasworkloadmetadatatypes
SaasWorkloadMetadataTypes returns the list of metadata types for a
specified SaaS app type.

- There is a single argument of type SaasWorkloadMetadataTypesReq.
- Returns SaasWorkloadMetadataTypesReply.
### salesforceobjects
The objects in the Salesforce organization.

- There are 8 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that occur before the specified cursor.
    - orgId - System.String: Rubrik ID of the Salesforce organization.
    - sortBy - HierarchySortByField: Sort hierarchy objects according to the hierarchy field.
    - filter - list of Filters: The hierarchy object filter.
    - sortOrder - SortOrder: Sorts the order of results.
- Returns SalesforceObjectConnection.
### scriptsformanualpermissionvalidation
GetScriptsForManualPermissionValidation returns the bash and powershell
scripts for non-OAuth permissions validation.

- There is a single argument of type GetScriptsForManualPermissionValidationReq.
- Returns GetScriptsForManualPermissionValidationReply.
### searchclouddirectworkload
SearchCloudDirectWorkload searches for files across all snapshots of a
NAS Cloud Direct workload (share or bucket).

- There are 7 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that occur before the specified cursor.
    - workloadFid - System.String: ID of the NAS Cloud Direct workload to search.
    - searchQuery - System.String: Search query string to match against file names.
    - versionLimit - System.Int32: Maximum number of file versions to return per file.
- Returns SearchCloudDirectWorkloadEntryConnection.
### searchfilebyprefix
Search file under given folder and with given prefix.

- There are 5 arguments.
    - clusterUuid - System.String: The Rubrik cluster ID.
    - managedId - System.String: Workload managed ID.
    - snapshotId - System.String: Corresponds to snapshot ID in Rubrik CDM tables.
    - searchFolderPath - System.String: Root path to search file inside FMD.
    - filenamePrefix - System.String: Filename prefix that should match.
- Returns DiffResult.
### selfserverollingupgrade
Gets the rolling upgrade enabled setting for the account.

- The selfserverollingupgrade subcommand takes no arguments.
- Returns GetSelfServeRollingUpgradeReply.
### sensitivedatasummary
sensitiveDataSummary returns the sensitive data summary for the given filter.

- There is a single argument of type SensitiveDataSummaryInput.
- Returns SensitiveDataSummary.
### sensitivefiledetails
Retrieve the details of a file.

- There is a single argument of type SensitiveFileMetadataInput.
- Returns SensitiveFileDetailsReply.
### signinlogdetails
Get details for a specific sign-in event.

Retrieves comprehensive details for a single sign-in event by its ID.
For optimal performance, provide eventDate (extracted from the list view)
to enable BigQuery partition pruning (98.9% cost reduction).

- There are 2 arguments.
    - eventId - System.String: The unique identifier for the sign-in event (required).
    - eventDate - DateTime: Optional date for partition pruning optimization.
- Returns SigninLogDetails.
### signinlogfiltervalues
Get possible filter values for sign-in logs with optional search.

This API supports typeahead/autocomplete functionality for filter dropdowns.
When searchTerm is empty, returns top N most common values ordered by frequency.
When searchTerm is provided, returns values matching the prefix in alphabetical order.

- There are 5 arguments.
    - filterType - SigninLogFilterType: The type of filter to get possible values for (required).
    - timeRange - TimeRangeInput: Time range to scope the values (required for partition pruning).
    - searchTerm - System.String: Optional prefix to filter values (typeahead).
    - limit - System.Int32: Maximum results to return (default: 50, max: 100).
    - existingFilters - SigninLogsFilters: Optional filters to scope the search (cross-filter dependency).
- Returns SigninLogFilterValuesResponse.
### signinlogs
List sign-in logs with filtering and pagination.

Retrieves sign-in events from identity providers (Entra ID, Okta, On-Prem
AD) with support for filtering by time range, actor, provider, result, and
other criteria.

- There are 7 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that occur before the specified cursor.
    - timeRange - TimeRangeInput: The time range to query (required).
    - filters - SigninLogsFilters: Optional filters for the query.
    - sortBy - SigninLogSortBy: Optional sort order for the results.
- Returns SigninLogSummaryConnection.
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
### sourcerecoveryspecsv2
Lists recovery specifications for the source in the failback scenario.

- There is a single argument of type ListSourceRecoverySpecsReq.
- Returns list of SourceChildRecoverySpecMapV2s.
### sqlserversetupscriptsbulk
The script to setup the SQL Server / Managed Instance for backups, given
the list of object IDs.

- There is a single argument of type GetSqlServerSetupScriptsReqBulk.
- Returns GetSqlServerSetupScriptsReplyBulk.
### ssmdocumentforec2
GetSSMDocumentForEC2 retrieves the SSM document that allows RSC to
trigger scripts on EC2 instances. This will be used for triggering post
recovery script for application resilience.

- The ssmdocumentforec2 subcommand takes no arguments.
- Returns SsmDocumentForEc2Reply.
### ssogroupalreadyexists
Determines if the SSO group already exists in the account.

- There are 2 arguments.
    - ssoGroupName - System.String: SSO group name.
    - userDomainId - System.String: User auth domain ID.
- Returns SsoGroupAlreadyExistsReply.
### staticroutes
Get all existing route configs

Supported in v5.0+
Lists all existing route configs.

- There is a single argument of type GetRoutesInput.
- Returns InternalGetRoutesResponse.
### supportbundle
Get the status of generating support bundle

Supported in v5.0+
Given a request ID for generate support bundle request, provide the status of the request. If the request is successful, the download link for the support bundle would be included.

- There is a single argument of type QuerySupportBundleInput.
- Returns AsyncRequestStatus.
### supportcasecomments
GetSupportCaseComments retrieves the comments for a support case.

- There is a single argument of type System.String.
- Returns GetSupportCaseCommentsReply.
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
    - teamUUID - System.String: The UUID of the Team.
    - channelName - System.String: The channel name whose availability is being checked.
- Returns System.Boolean.
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
### unifiedunregistereddomaincontrollers
Lists auto-discovered AD domain controllers without RBS, deduplicated
across all Rubrik clusters in the account.

- There are 7 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that occur before the specified cursor.
    - sortBy - UnregisteredDcSortByField: Field to sort the results by.
    - sortOrder - SortOrder: Sort order (ASC / DESC).
    - filter - list of UnregisteredDcFilters: Filters to apply to the result set.
- Returns UnregisteredDomainControllerWithDomainConnection.
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

- There are 3 arguments.
    - productType - ProductTargetType: Deprecated. Use snapshotManagementType instead.
    - cloudVendor - CloudVendor: The cloud vendor type.
    - snapshotManagementType - SnapshotManagementType: Type of snapshot management.
- Returns list of ManagedObjectTypes.
### upgradepatheligibility
Checks whether the upgrade path from a cluster's current version to the
to the target version is eligible for the given operation without
initiating any download or upgrade. Returns all blocking reasons if the
path is not eligible.

- There are 3 arguments.
    - clusterUuid - System.String: Specifies the cluster UUID.
    - targetVersion - System.String: The CDM version to upgrade to (e.g. "9.5.0").
    - operation - System.String: The operation to validate: "download" or "upgrade".
- Returns UpgradePathEligibilityReply.
### upgradestatus
Gets the status for completed/running upgrade process.

- There is a single argument of type System.String.
- Returns UpgradeStatusReply.
### useraccessinsights
Return the user access insights for the given time range.

- There are 7 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that occur before the specified cursor.
    - startTime - DateTime: Start time in ISO string format (YYYY-MM-DDThh:mm:ssZ).
    - endTime - DateTime: End time in ISO string format (YYYY-MM-DDThh:mm:ssZ).
    - includeWhitelistedResults - System.Boolean: Specifies whether whitelisted results should be included.
- Returns PrincipalInsightConnection.
### useraccessmetrics
User access metrics.

- The useraccessmetrics subcommand takes no arguments.
- Returns UserAccessMetrics.
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
Returns a paginated list of the analyzers a user accessed, ranked by access
usage for the anchored day.

- There are 8 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that occur before the specified cursor.
    - userId - System.String: Stable identifier of the user.
    - startDay - System.String: Day to anchor the summary, in YYYY-MM-DD format.
    - timezone - System.String: Official IANA timezone name.
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
Returns summary details for a single user, including identity information
and an overview of their data access for the anchored day.

- There are 3 arguments.
    - userId - System.String: Stable identifier of the user.
    - startDay - System.String: Day to anchor the summary, in YYYY-MM-DD format.
    - timezone - System.String: Official IANA timezone name.
- Returns GetUserDetailReply.
### userfile
User file.

- There is a single argument of type System.String.
- Returns CustomerFacingFile.
### userfiles
All user files.

- There are 5 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that occur before the specified cursor.
    - filenamePrefix - System.String: Optional prefix to filter files by filename.
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
### userssummary
Returns the count of secure and insecure users.

- There are 3 arguments.
    - startDay - System.String: Start time, in string format (YYYY-MM-DD).
    - endDay - System.String: End time, in string format (YYYY-MM-DD).
    - filter - UsersSummaryFilterInput: Filter for users summary.
- Returns GetUsersSummaryReply.
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
### validateoutpostaccountnetwork
ValidateOutpostNetwork validates the network configuration of an outpost
account.

- There is a single argument of type ValidateOutpostAccountNetworkInput.
- Returns ValidateOutpostAccountNetworkReply.
### validaterdsexportexocomputeport
ValidateRdsExportExocomputePort checks if the exocompute worker node security group used for RDS export allows outbound traffic on a port.

- There is a single argument of type ValidateRdsExportExocomputePortReq.
- Returns ValidateRdsExportExocomputePortReply.
### validaterolename
Validate a role name.

- There is a single argument of type ValidateRoleNameReq.
- Returns ValidateRoleNameReply.
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
### violationscategorysummary
Summary of violations in each of the category.

- There are 3 arguments.
    - historicalDays - System.Int32: Number of days to lookback from the current day.
    - policyTypes - list of PolicyTypes: List of policy types. If empty, no results will be returned.
    - idpTypes - list of IdpTypes: Identity provider types to filter by. If empty or null, the results will not be filtered.
- Returns ViolationsCategorySummary.
### violationsenvironmentsummary
Summary of violations in each of the environment.

- There are 2 arguments.
    - historicalDays - System.Int32: Number of days to lookback from the current day.
    - policyTypes - list of PolicyTypes: List of policy types. If empty, no results will be returned.
- Returns ViolationsEnvironmentSummaries.
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
### workdayingestionstatus
Get Workday ingestion status.

- The workdayingestionstatus subcommand takes no arguments.
- Returns IntegrationIngestionStatus.
### workloadalertsetting
Get whether alerts for a given workload are enabled.

- There are 2 arguments.
    - clusterUuid - System.String: The Rubrik cluster ID.
    - workloadId - System.String: The FID of the workload.
- Returns GetWorkloadAlertSettingReply.
### workloadanomalies
Specifies workloads that have an anomalous snapshot.

- There are 20 arguments.
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
    - riskLevelTypesFilter - list of RiskLevelTypes: Filter by risk level type.
- Returns WorkloadAnomalyConnection.
### workloadforeverid
Returns the RSC forever ID of a workload.

- There are 2 arguments.
    - clusterUuid - System.String: The Rubrik cluster ID.
    - managedId - System.String: Workload managed ID.
- Returns System.String.
### workloadresourcespecs
Lists resource specifications for the specified workloads of a particular
type.

- There is a single argument of type ListWorkloadResourceSpecsInput.
- Returns list of WorkloadResourceSpecs.
### workloadsrecoveryinfo
GetAllWorkloadsRecoveryInfo returns information regarding all
workloads that are part of a specific recovery.

- There is a single argument of type AllWorkloadsRecoveryInfoInput.
- Returns AllWorkloadsRecoveryInfoReply.
