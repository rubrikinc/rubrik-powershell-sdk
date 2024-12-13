# New-RscQuerySla
## Subcommands
### auditdetail
List of audit details for a given SLA Domain.

- There are 7 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that occur before the specified cursor.
    - SlaId - System.String: SLA Domain ID for global SLA Domains and internal ID for SLA Domains created on Rubrik clusters.
    - filter - list of SLAAuditDetailFilterInputs: Filter for SLA Domain Audit details.
    - timezone - System.String: Timezone.
- Returns list of SlaAuditDetails.
### clusterdomains
Returns paginated list of SLA domains that were created on Rubrik CDM.

- There are 4 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that occur before the specified cursor.
- Returns ClusterSlaDomainConnection.
### clusterglobals
Global SLA Domains protecting at least one object on the specified Rubrik cluster.

- There is a single argument of type System.String.
- Returns list of SlaInfos.
### conflictobjects
Conflicting objects for an SLA Domain assignment.

- There is a single argument of type list of System.Strings.
- Returns list of HierarchyObjects.
### countofobjectsprotected
The number of objects protected by the SLA Domains.

- There are 4 arguments.
    - rootOptionalFid - System.String: Forever UUID of the object root. The value of  `none` represents the global hierarchy root.
    - slaIds - list of System.Strings: A list of SLA Domain IDs.
    - filter - list of Filters: Hierarchy object filter.
    - typeFilter - list of HierarchyObjectTypeEnums: Types of objects to include.
- Returns CountOfObjectsProtectedBySLAsResult.
### domain
Query that retrieves an SLA Domain.

- There are 4 arguments.
    - id - System.String: SLA Domain ID.
    - shouldShowSyncStatus - System.Boolean: Specifies whether to show the SLA Domain sync status on Rubrik CDM.
    - shouldShowUpgradeInfo - System.Boolean: Specifies whether to show the upgrade information for an SLA Domain.
    - shouldShowPausedClusters - System.Boolean: Specifies whether to show the Rubrik clusters where this SLA Domain is paused.
- Returns SlaDomain.
### domains
Retrieves a list of SLA Domains.

- There are 14 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that occur before the specified cursor.
    - sortBy - SlaQuerySortByField: Field to sort the SLA Domains list.
    - sortOrder - SortOrder: Sort order for sorting the SLA Domains returned by the query.
    - filter - list of GlobalSlaFilterInputs: Filter for the SLA Domain query.
    - contextFilter - ContextFilterTypeEnum: Specifies the context filter to use.
    - contextFilterInput - list of ContextFilterInputFields: Specifies the context filter input to use.
    - shouldShowSyncStatus - System.Boolean: Specifies whether to show the SLA Domain sync status on Rubrik CDM.
    - shouldShowProtectedObjectCount - System.Boolean: Specifies whether to show the number of workloads protected by the SLA Domain.
    - shouldShowUpgradeInfo - System.Boolean: Specifies whether to show the upgrade information for an SLA Domain.
    - showRemoteSlas - System.Boolean: Specifies whether to retrieve the remote SLA Domains from Rubrik CDM. By default, remote SLA Domains are not retrieved.
    - shouldShowPausedClusters - System.Boolean: Specifies whether to show the Rubrik clusters where this SLA Domain is paused.
- Returns SlaDomainConnection.
### downloadwithreplicationcsv
Download a CSV file containing a list of SLA Domains that replicate snapshots to the specified Rubrik cluster. Find the CSV file for download from the File Preparation Centre.

- There are 2 arguments.
    - cdmClusterUUID - System.String: UUID of the Rubrik cluster.
    - includeArchived - System.Boolean: Include archived SLA Domain.
- Returns DownloadSlaWithReplicationCsvReply.
### globalfilterlist
Retrieves a list of SLA Domains.

- There are 14 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that occur before the specified cursor.
    - sortBy - SlaQuerySortByField: Field to sort the SLA Domains list.
    - sortOrder - SortOrder: Sort order for sorting the SLA Domains returned by the query.
    - filter - list of GlobalSlaFilterInputs: Filter for the SLA Domain query.
    - contextFilter - ContextFilterTypeEnum: Specifies the context filter to use.
    - contextFilterInput - list of ContextFilterInputFields: Specifies the context filter input to use.
    - shouldShowSyncStatus - System.Boolean: Specifies whether to show the SLA Domain sync status on Rubrik CDM.
    - shouldShowProtectedObjectCount - System.Boolean: Specifies whether to show the number of workloads protected by the SLA Domain.
    - shouldShowUpgradeInfo - System.Boolean: Specifies whether to show the upgrade information for an SLA Domain.
    - showRemoteSlas - System.Boolean: Specifies whether to retrieve the remote SLA Domains from Rubrik CDM. By default, remote SLA Domains are not retrieved.
    - shouldShowPausedClusters - System.Boolean: Specifies whether to show the Rubrik clusters where this SLA Domain is paused.
- Returns GlobalSlaForFilterConnection.
### globalstatuses
Status on the clusters where global SLA is synced.

- There are 6 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that occur before the specified cursor.
    - filter - list of SlaStatusFilterInputs: Filters for SLAStatus.
    - SlaId - System.String: SLA ID for global SLAs.
- Returns GlobalSlaStatusConnection.
### managedvolume
Details of a SLA Managed Volume object.

- There is a single argument of type System.String.
- Returns ManagedVolume.
### managedvolumes
Paginated list of SLA Managed Volumes.

- There are 5 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that occur after the specified cursor.
    - sortBy - HierarchySortByField: Sort hierarchy objects according to the hierarchy field.
    - sortOrder - SortOrder: Sorts the order of results.
    - filter - list of Filters: Hierarchy object filter.
- Returns ManagedVolumeConnection.
### ncdcompliancedata
NAS Cloud Direct SLA Domain compliance data for the requested clusters.

- There is a single argument of type list of System.Strings.
- Returns list of NcdSlaComplianceDatas.
### summariesbyids
List of SLA Domain summaries for the given IDs.

- There is a single argument of type list of System.Strings.
- Returns list of SlaDomains.
### verifywithreplicationtocluster
Verify for a Rubrik cluster if it is replication target in any SLA Domain.

- There are 2 arguments.
    - cdmClusterUUID - System.String: UUID of the Rubrik cluster.
    - includeArchived - System.Boolean: Include archived SLA Domain.
- Returns VerifySlaWithReplicationToClusterResponse.
