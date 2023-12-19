# New-RscQueryMisc
## Subcommands
### activecustomanalyzers
- The activecustomanalyzers subcommand takes no arguments.
- Returns AnalyzerConnection.
### activedirectorydomain
Summary of the given Active Directory domain.

- There is a single argument of type System.String.
- Returns ActiveDirectoryDomain.
### activedirectorydomaincontroller
Summary of the given Active Directory domain controller.

- There is a single argument of type System.String.
- Returns ActiveDirectoryDomainController.
### activedirectorydomaincontrollers
Summary of all Active Directory domain controllers.

- There are 5 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - sortBy - HierarchySortByField: Sort hierarchy objects by hierarchy field.
    - sortOrder - SortOrder: Sorting order for the results.
    - filter - list of Filters: The hierarchy object filter.
- Returns ActiveDirectoryDomainControllerConnection.
### activedirectorydomains
Summary of all Active Directory domains.

- There are 5 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - sortBy - HierarchySortByField: Sort hierarchy objects by hierarchy field.
    - sortOrder - SortOrder: Sorting order for the results.
    - filter - list of Filters: The hierarchy object filter.
- Returns ActiveDirectoryDomainConnection.
### advolumeexports
Active Directory volume export connection.

- There are 4 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - filters - list of AdVolumeExportFilters: Filter for Active Directory volume exports.
    - sortBy - AdVolumeExportSortByInput: Sort by argument for Active Directory volume exports.
- Returns AdVolumeExportConnection.
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
    - sortOrder - SortOrder: Sorting order for the results.
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
### archivalstorageusage
Storage usage of an archival location.

- There is a single argument of type System.String.
- Returns list of ArchivalStorageUsages.
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
### cdmguestcredentials
Get all cdm guest credentials.

- There is a single argument of type list of System.Strings.
- Returns list of CdmGuestCredentials.
### cdmhierarchysnappablenew
- There is a single argument of type System.String.
- Returns CdmHierarchySnappableNew.
### cdmhierarchysnappablesnew
- There is a single argument of type list of System.Strings.
- Returns list of CdmHierarchySnappableNews.
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
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
    - allCdpVmInfoSort - CdpPerfDashboardSortParam: Sort Type for getting all CDP VMs for CDP performance dashboard.
    - allCdpVmInfoFilter - list of CdpPerfDashboardFilterParams: Filter Type for getting all CDP VMs for CDP performance dashboard.
- Returns CdpVmInfoConnection.
### checkcloudcomputeconnectivityjobprogress
Get details of the cloud compute connectivity check request

Supported in v6.0+
Gets the details of the request that was triggered to check the cloud compute connectivity of an archival location.

- There is a single argument of type GetCloudComputeConnectivityCheckRequestStatusInput.
- Returns AsyncRequestStatus.
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
### computeclusterstatus
Get details for the compute cluster

Supported in v5.1+
Get details for the compute cluster.

- There is a single argument of type GetComputeClusterInput.
- Returns ComputeClusterDetail.
### configuredgroupmembers
Objects that match the specifications of a configured group.

- There are 5 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - orgId - System.String: Org UUID.
    - wildcard - System.String: A wildcard pattern that group members' names or URLs must match.
    - pdls - list of System.Strings: A list of preferred data locations that group members must match.
- Returns O365ConfiguredGroupMemberConnection.
### crawl
Returns details for one crawl.

- There is a single argument of type System.String.
- Returns Crawl.
### crawls
Returns crawls for an account.

- The crawls subcommand takes no arguments.
- Returns CrawlConnection.
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
### currentuser
Currently logged-in user.

- The currentuser subcommand takes no arguments.
- Returns User.
### currentuserlogincontext
Current user login context.

- The currentuserlogincontext subcommand takes no arguments.
- Returns UserLoginContext.
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
### decryptexporturl
Decrypt Export URL.

- There are 2 arguments.
    - workloadFid - System.String: Optional FID of the workload.
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
### eventdigests
Retrieve event digests for specific recipients.

- There is a single argument of type AllEventDigestsInput.
- Returns list of EventDigests.
### externaldeploymentname
Customer facing Polaris deployment name.

- The externaldeploymentname subcommand takes no arguments.
- Returns System.String.
### failedrestoreitemsinfo
Information on Microsoft 365 restore failed items.

- There are 2 arguments.
    - workloadFid - System.String: The FID of the workload.
    - taskchainId - System.String: Taskchain ID.
- Returns FailedRestoreItemsInfoReply.
### failoverclusterapp
Get details of the given failover cluster app.

- There is a single argument of type System.String.
- Returns FailoverClusterApp.
### failoverclusterapps
Get a summary of all failover cluster apps.

- There are 6 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - sortBy - HierarchySortByField: Sort hierarchy objects by hierarchy field.
    - sortOrder - SortOrder: Sorting order for the results.
    - filter - list of Filters: The hierarchy object filter.
    - hostFailoverClusterRoot - HostFailoverClusterRoot: Host failover cluster root type.
- Returns FailoverClusterAppConnection.
### failoverclustertopleveldescendants
Get a summary of all failover cluster top level descendants.

- There are 7 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - sortBy - HierarchySortByField: Sort hierarchy objects by hierarchy field.
    - sortOrder - SortOrder: Sorting order for the results.
    - typeFilter - list of HierarchyObjectTypeEnums: Types of objects to include.
    - filter - list of Filters: The hierarchy object filter.
    - hostFailoverClusterRoot - HostFailoverClusterRoot: Host failover cluster root type.
- Returns FailoverClusterTopLevelDescendantTypeConnection.
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
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
- Returns UserActivityResultConnection.
### geolocationlist
- The geolocationlist subcommand takes no arguments.
- Returns list of GroupCounts.
### getallrolesinorglist
- There are 7 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
    - sortOrder - SortOrder: Sorting order for the results.
    - sortBy - RoleFieldEnum
    - nameFilter - System.String: Name to filter the results.
- Returns RoleConnection.
### getcdmreleasedetailsforclusterfromsupportportal
Get CDM release details from support portal for a given list of clusters.

- There are 7 arguments.
    - listClusterUuid - list of System.Strings: Specifies the list of cluster UUIDs.
    - filterVersion - System.String: Prefix filter for available versions.
    - fetchLinks - System.Boolean: Retrieves version details.
    - filterUpgradeable - System.Boolean: Filters for the available upgrade versions.
    - shouldShowAll - System.Boolean: Shows all versions.
    - filterAfterSource - System.Boolean: Filter to include only the versions released after the source version.
    - sortOrder - SortOrder: Sorting order for the results.
- Returns CdmUpgradeReleaseDetailsFromSupportPortalReply.
### getcdmreleasedetailsforversionfromsupportportal
Get CDM release details from support portal for a given list of clusters specific to a target version.

- There are 7 arguments.
    - listClusterUuid - list of System.Strings: Specifies the list of cluster UUIDs.
    - filterVersion - System.String: Prefix filter for available versions.
    - fetchLinks - System.Boolean: Retrieves version details.
    - filterUpgradeable - System.Boolean: Filters for the available upgrade versions.
    - shouldShowAll - System.Boolean: Shows all versions.
    - filterAfterSource - System.Boolean: Filter to include only the versions released after the source version.
    - sortOrder - SortOrder: Sorting order for the results.
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
    - sortOrder - SortOrder: Sorting order for the results.
- Returns CdmUpgradeReleaseDetailsFromSupportPortalReply.
### getgroupcountbycdmclusterstatus
- The getgroupcountbycdmclusterstatus subcommand takes no arguments.
- Returns GroupCountListWithTotal.
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
- There is a single argument of type System.String.
- Returns list of Permissions.
### getrolesbyids
- There is a single argument of type list of System.Strings.
- Returns list of Roles.
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
### globalsearchresults
- There are 7 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
    - sortBy - HierarchySortByField: Sort hierarchy objects by hierarchy field.
    - sortOrder - SortOrder: Sorting order for the results.
    - filter - list of Filters: The hierarchy object filter.
- Returns HierarchyObjectConnection.
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
- There is a single argument of type System.String.
- Returns HierarchyObject.
### hierarchyobjectrecoverytarget
Returns a single hierarchy object to be used as a recovery target. Permission checks are performed against the ProvisionOnInfrastructure operation, not the ViewInventory operation.

- There is a single argument of type System.String.
- Returns HierarchyObject.
### hierarchyobjects
- There are 2 arguments.
    - fids - list of System.Strings: The Rubrik UUIDs for the objects.
    - filter - list of Filters: The hierarchy object filter.
- Returns list of HierarchyObjects.
### hierarchysnappables
- There are 5 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - sortBy - HierarchySortByField: Sort hierarchy objects by hierarchy field.
    - sortOrder - SortOrder: Sorting order for the results.
    - filter - list of Filters: The hierarchy object filter.
- Returns HierarchySnappableConnection.
### installedversionlist
- The installedversionlist subcommand takes no arguments.
- Returns list of InstalledVersionGroupCounts.
### integration
Read the integration with the specified integration ID.

- There is a single argument of type System.Int32.
- Returns ReadIntegrationReply.
### integrations
List the integrations of the specified types.

- There are 2 arguments.
    - integrationTypes - list of IntegrationTypes: List of integration types.
    - nameFilter - System.String: Optional filter for integration names.
- Returns ListIntegrationsReply.
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
### ipwhitelist
- The ipwhitelist subcommand takes no arguments.
- Returns GetWhitelistReply.
### isloggedintorubriksupportportal
Is Logged into Rubrik support portal.

- The isloggedintorubriksupportportal subcommand takes no arguments.
- Returns SupportPortalStatusReply.
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
### istotpmandatoryintargetversion
Checks whether enabling Time-based, One-Time Password (TOTP) is mandatory in the target Rubrik CDM upgrade version.

- There is a single argument of type System.String.
- Returns System.Boolean.
### isupgradeavailable
Is upgrade available for a particular cluster.

- There is a single argument of type System.String.
- Returns CdmUpgradeAvailabilityReply.
### isupgraderecommended
Is upgrade recommended for a particular cluster.

- There is a single argument of type System.String.
- Returns CdmUpgradeRecommendationReply.
### isvmwaremanagementenabled
- The isvmwaremanagementenabled subcommand takes no arguments.
- Returns System.Boolean.
### iszrsavailableforlocation
Checks if Zone Redundant Storage (ZRS) is available for a given combination of account, region, subscription and service tier.

- There are 3 arguments.
    - serviceTier - ServiceTier: The service tier of the database.
    - region - AzureNativeRegion: The azure region.
    - subscriptionId - System.String: Subscription ID.
- Returns ZrsAvailabilityReply.
### knowledgebasearticle
A knowledge base article.

- There is a single argument of type System.String.
- Returns KnowledgeBaseArticle.
### lambdasettings
- The lambdasettings subcommand takes no arguments.
- Returns LambdaSettings.
### licensedproducts
Information about the licenses at the product level.

- The licensedproducts subcommand takes no arguments.
- Returns GetLicensedProductsInfoReply.
### licensesforclusterproductsummary
Information about licenses for a specific cluster product, grouped by the product type.

- There is a single argument of type LicensesForClusterProductSummaryInput.
- Returns LicensesForClusterProductReply.
### lockoutconfig
Get the lockout configurations of the current organization.

- The lockoutconfig subcommand takes no arguments.
- Returns LockoutConfig.
### maxprotectedappscount
Maximum number of protected apps that can be added per account.

- The maxprotectedappscount subcommand takes no arguments.
- Returns System.Int32.
### mfasetting
Get multifactor authentication (MFA) settings for an account.

- The mfasetting subcommand takes no arguments.
- Returns GetMfaSettingReply.
### minimumcdmversionforfeatureset
Get minimum cluster version to support feature set.

- There is a single argument of type FeatureListMinimumCdmVersionInputType.
- Returns FeatureListMinimumCdmVersionReply.
### ncdbackendcapacity
NAS Cloud Direct back-end capacity for the requested clusters.

- There is a single argument of type list of System.Strings.
- Returns NcdBackEndCapacity.
### ncdfrontendcapacity
NAS Cloud Direct front-end capacity for the requested clusters.

- There is a single argument of type list of System.Strings.
- Returns NcdFrontEndCapacity.
### ncdobjectprotectionstatus
NAS Cloud Direct object protection status for the requested clusters.

- There is a single argument of type list of System.Strings.
- Returns NcdObjectProtectionStatus.
### ncdobjectsovertimedata
NAS Cloud Direct objects over time data for the requested clusters.

- There is a single argument of type list of System.Strings.
- Returns list of NcdObjectsOverTimeDatas.
### ncdtaskdata
NAS Cloud Direct task data for the requested clusters.

- There is a single argument of type list of System.Strings.
- Returns list of NcdTaskDatas.
### ncdusageovertimedata
NAS Cloud Direct usage over time data for the requested clusters.

- There is a single argument of type list of System.Strings.
- Returns list of NcdUsageOverTimeDatas.
### ncdvmimageurl
NAS Cloud Direct virtual machine image download URL.

- There is a single argument of type VmImageUrlInput.
- Returns NcdVmImageUrl.
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
    - sortOrder - SortOrder: Sorting order for the results.
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
### noderemovalcancelpermission
Check if the running node-removal job is cancelable.

- There is a single argument of type NodeRemovalCancelPermissionInput.
- Returns NodeRemovalCancelPermissionReply.
### nodetoreplace
The ID of the Rubrik cluster node to replace.

- There is a single argument of type NodeToReplaceInput.
- Returns NodeToReplaceReply.
### nosqlstoragelocations
List of Mosaic Storage Locations used for NoSQL backups

- There are 3 arguments.
    - sortBy - MosaicStorageLocationQuerySortByField: Specification on how to sort a list of Mosaic Storage Locations.
    - sortOrder - SortOrder: Sorting order for the results.
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
    - sort - FileResultSortInput
    - day - System.String: Day in the format (YYYY-MM-DD).
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
    - sortOrder - SortOrder: Sorting order for the results.
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
### orgs
All orgs.

- There are 8 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
    - sortOrder - SortOrder: Sorting order for the results.
    - sortBy - OrgField: Field in the org to sort orgs by.
    - nameFilter - System.String: Name to filter the results.
    - mfaEnforcedFilter - System.Boolean: Filter orgs by the status of MFA enforcement. When the field is not used, all orgs are returned. When the field is set to true, only orgs that have MFA enforced are returned. When the field is set to false, only orgs that do not have MFA enforced are returned.
- Returns OrgConnection.
### orgsbyids
Orgs of given IDs.

- There is a single argument of type list of System.Strings.
- Returns list of Orgs.
### orgsecuritypolicy
Organization security policy.

- The orgsecuritypolicy subcommand takes no arguments.
- Returns OrgSecurityPolicy.
### orgsforprincipal
Returns the list of organizations to which the principal has access.

- There is a single argument of type System.String.
- Returns OrgsForPrincipalReply.
### passwordcomplexitypolicy
Get the password policy for the current organization.

- The passwordcomplexitypolicy subcommand takes no arguments.
- Returns PasswordComplexityPolicy.
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
### prechecksstatus
Gets status of last prechecks job.

- There is a single argument of type System.String.
- Returns PrechecksStatusReply.
### prechecksstatuswithnextjobinfo
Get status of last completed prechecks Job along with details of currently running/scheduled next prechecks Job.

- There is a single argument of type System.String.
- Returns PrechecksStatusReply.
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
    - sortBy - HierarchySortByField: Sort hierarchy objects by hierarchy field.
    - sortOrder - SortOrder: Sorting order for the results.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
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
### radarclusterlist
- There are 7 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
    - filter - ClusterFilterInput: Filter by cluster.
    - sortOrder - SortOrder: Cluster sort order.
    - sortBy - ClusterSortByEnum: Sort clusters by field.
- Returns ClusterConnection.
### roletemplates
The list of available role templates.

- There are 5 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
    - nameFilter - System.String: Name to filter the results.
- Returns RoleTemplateConnection.
### searchfilebyprefix
Search file under given folder and with given prefix.

- There are 5 arguments.
    - clusterUuid - System.String: The Rubrik cluster ID.
    - managedId - System.String: Workload managed ID.
    - snapshotId - System.String: Corresponds to snapshot ID in Rubrik CDM tables.
    - searchFolderPath - System.String: Root path to search file inside FMD.
    - filenamePrefix - System.String: Filename prefix that should match.
- Returns DiffResult.
### searchsnappablelist
- There are 7 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
    - sortOrder - SortOrder: Sorting order for the results.
    - sortBy - SnappableSortByEnum: Sort workloads by field.
    - filter - SnappableFilterInputWithSearch: Filter workloads by input (with search by name).
- Returns SnappableConnection.
### searchsnappableversionedfiles
- There are 4 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - snappableFid - System.String
    - searchQuery - System.String
- Returns VersionedFileConnection.
### snappablecontactsearch
Search over Exchange contacts.

- There are 5 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - snappableFid - System.String: The fid for the workload.
    - orgId - System.String: Org UUID.
    - contactsSearchFilter - ContactsSearchFilter: Search filter for contacts search.
- Returns O365ExchangeObjectConnection.
### snappableemailsearch
- There are 5 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - snappableFid - System.String: The fid for the workload.
    - orgId - System.String: Org UUID.
    - searchFilter - SearchFilter: search filters
- Returns O365ExchangeObjectConnection.
### snappableeventsearch
- There are 5 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - snappableFid - System.String: The fid for the workload.
    - orgId - System.String: Org UUID.
    - calendarSearchFilter - CalendarSearchFilter: Search filter for calendar search.
- Returns O365ExchangeObjectConnection.
### snappablegroupbylist
- There are 8 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
    - groupBy - SnappableGroupByEnum: Group workloads by field.
    - filter - SnappableGroupByFilterInput: Filter workloads by groups.
    - timezoneOffset - System.Single: Offset based on customer timezone.
    - requestedAggregations - list of SnappableAggregationsEnums: List of workload aggregations to retrieve. You can significantly reduce the runtime of the query by specifying a subset of aggregations to retrieve.
- Returns SnappableGroupByConnection.
### snappablelist
- There are 7 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
    - sortOrder - SortOrder: Sorting order for the results.
    - sortBy - SnappableSortByEnum: Sort workloads by field.
    - filter - SnappableFilterInput: Filter protected objects by input.
- Returns SnappableConnection.
### snappableonedrivesearch
- There are 5 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - snappableFid - System.String: The fid for the workload.
    - orgId - System.String: Org UUID.
    - onedriveSearchFilter - OnedriveSearchFilter
- Returns O365OnedriveObjectConnection.
### snappableteamsconversationssearch
- There are 7 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - snappableFid - System.String: The fid for the workload.
    - orgId - System.String: Org UUID.
    - snapshotFidOpt - System.String: snapshotFid arg which is of optional type
    - teamConvChannels - list of O365TeamConvChannelInputs: List of channel objects (naturalId and name).
    - teamsConversationsSearchFilter - TeamsConversationsSearchFilter
- Returns O365TeamsConversationsConnection.
### snappableteamsdrivesearch
- There are 7 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - snappableFid - System.String: The fid for the workload.
    - orgId - System.String: Org UUID.
    - channelId - System.String
    - channelFolderName - System.String
    - teamsDriveSearchFilter - OnedriveSearchFilter
- Returns O365OnedriveObjectConnection.
### snmpconfigurations
Get SNMP configuration of the cluster

Supported in v5.0+
Get SNMP configuration of the queried cluster.

- There is a single argument of type GetSnmpConfigurationInput.
- Returns SnmpConfiguration.
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
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
    - sortBy - SupportUserAccessSortByField: Sorting field for support access.
    - sortOrder - SortOrder: Sorting order for support access.
    - filters - list of SupportUserAccessFilterInputs: Specifies how to filter the list of targets.
- Returns SupportUserAccessConnection.
### syslogexportrules
Get the configured syslog export rules

Supported in v5.1+
Return the list of all configured syslog export rules.

- There is a single argument of type GetSyslogExportRulesInput.
- Returns SyslogExportRuleSummaryListResponse.
### tablefilters
- The tablefilters subcommand takes no arguments.
- Returns TableFilters.
### target
- There is a single argument of type System.String.
- Returns Target.
### targetmapping
- There is a single argument of type System.String.
- Returns TargetMapping.
### targetmappings
List all target mappings.

- There are 5 arguments.
    - sortBy - ArchivalGroupQuerySortByField: Specification on how to sort a list of target mappings.
    - sortOrder - SortOrder: Sorting order for the results.
    - filter - list of TargetMappingFilterInputs: Specification on how to filter a list of target mappings.
    - contextFilter - ContextFilterTypeEnum: Specifies the context filter to use.
    - isRcsStatsRequired - System.Boolean: Corresponds to rcs stats flag, only true value will add rcs stats in response.
- Returns list of TargetMappings.
### targets
List all targets.

- There are 4 arguments.
    - sortBy - ArchivalLocationQuerySortByField: Specifies the field by which the list of targets will be sorted.
    - sortOrder - SortOrder: Sorting order for the results.
    - filter - list of TargetFilterInputs: Specifies how to filter the list of targets.
    - contextFilter - ContextFilterTypeEnum: Specifies the context filter to use.
- Returns list of Targets.
### taskchain
Details of a taskchain.

- There is a single argument of type System.String.
- Returns Taskchain.
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
### teamchannelnameavailable
Checks the availability of the channel name in the Team.

- There are 2 arguments.
    - teamUUID - System.String
    - channelName - System.String
- Returns System.Boolean.
### topriskpolicysummaries
Retrieve most risky policies.

- There are 3 arguments.
    - getWhitelistedResults - System.Boolean: Include whitelisted objects in the results.
    - limit - System.Int32: Maximum number of entries in the response.
    - workloadTypes - list of DataGovObjectTypes: Types of workloads that can be used for filtering query results.
- Returns list of PolicySummarys.
### totpconfigstatus
Get TOTP configuration status for a user.

- There is a single argument of type System.String.
- Returns GetTotpStatusReply.
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
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
    - input - UnmanagedObjectsInput: Query unmanaged objects.
- Returns UnmanagedObjectDetailConnection.
### unmanagedobjectssupportedtypes
List of supported object types.

- The unmanagedobjectssupportedtypes subcommand takes no arguments.
- Returns list of ManagedObjectTypes.
### upgradestatus
Gets the status for completed/running upgrade process.

- There is a single argument of type System.String.
- Returns UpgradeStatusReply.
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
    - sortOrder - SortOrder: Sorting order for the results.
    - sortBy - UserFieldEnum
    - emailFilter - System.String
    - roleIdsFilter - list of System.Strings
    - lockoutStateFilter - LockoutStateFilter: Filter users based on lockout status.
    - hiddenStateFilter - HiddenStateFilter: Filter users based on hidden status.
    - shouldGetLocalUsersOnly - System.Boolean: Get local users only.
- Returns UserConnection.
### validateclusterlicensecapacity
Information about cluster license capacity validations.

- There is a single argument of type ValidateClusterLicenseCapacityInput.
- Returns ClusterLicenseCapacityValidations.
### validateorgname
Checks whether the tenant org name is valid and unique.

- There is a single argument of type ValidateOrgNameInput.
- Returns ValidateOrgNameReply.
### vcdvappvms
Paginated list of virtual machines under vCloud Director hiearchy.

- There are 5 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - sortBy - HierarchySortByField: Sort hierarchy objects by hierarchy field.
    - sortOrder - SortOrder: Sorting order for the results.
    - filter - list of Filters: The hierarchy object filter.
- Returns VsphereVmConnection.
### virtualmachinefiles
Get virtual machine files for a snapshot

Supported in v9.0+
Returns all virtual machine files, such as .vmdk, .vmx, and .nvram files, for the specified virtual machine snapshot.

- There is a single argument of type VirtualMachineFilesInput.
- Returns VirtualMachineFilesReply.
### vmrecoveryjobsinfo
All Vm recovery jobs info.

- There are 2 arguments.
    - fid - System.String: The Rubrik UUID for the object.
    - input - AllVmRecoveryJobsInfoInput: Input to get all vm recovery jobs info.
- Returns list of VmRecoveryJobInfos.
### vmwarecdpstateinfos
Batch get vsphere vmware cdp state infos.

- There is a single argument of type list of System.Strings.
- Returns list of VmwareCdpStateInfos.
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

- There are 18 arguments.
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
    - sortOrder - SortOrder: Sorting order for the results.
    - orderParentsFirst - System.Boolean: Order objects with children ahead of non-parents.
    - blueprintRecoveryTypes - list of BlueprintRecoveryTypes: Recovery type of the Recovery Plan.
    - locationsFilter - list of System.Strings: Filter results by their location.
- Returns WorkloadAnomalyConnection.
