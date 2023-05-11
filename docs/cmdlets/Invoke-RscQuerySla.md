# Invoke-RscQuerySla
## Subcommands
### ArchivalValidationWarning
SLA Domain warnings related to non-compliant archival retention duration in the archival policy.

- The Input parameter takes a single value of type SlaArchivalWarningsInput.
- Returns SlaArchivalValidationWithWarnings.
### AuditDetail
List of audit details for a given SLA Domain.

- The Input parameter takes a hashtable with 7 name and value pairs.
    - SlaId - System.String: SLA Domain ID for global SLA Domains and internal ID for SLA Domains created on Rubrik clusters.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
    - filter - a list of SLAAuditDetailFilterInputs: Filter for SLA Domain Audit details.
    - first - System.Int32: Returns the first n elements from the list.
    - last - System.Int32: Returns the last n elements from the list.
    - timezone - System.String: Timezone.
- Returns a list of SlaAuditDetails.
### ConflictObject
- The Input parameter takes a single value of type a list of System.Strings.
- Returns a list of HierarchyObjects.
### Domain
Query that retrieves an SLA Domain.

- The Input parameter takes a hashtable with 4 name and value pairs.
    - id - System.String: SLA Domain ID.
    - shouldShowPausedClusters - System.Boolean: Specifies whether to show the Rubrik clusters where this SLA Domain is paused.
    - shouldShowSyncStatus - System.Boolean: Specifies whether to show the SLA Domain sync status on Rubrik CDM.
    - shouldShowUpgradeInfo - System.Boolean: Specifies whether to show the upgrade information for an SLA Domain or not.
- Returns SlaDomain.
### DomainWithWarning
- The Input parameter takes a hashtable with 3 name and value pairs.
    - applicableSnappableTypes - a list of WorkloadLevelHierarchys: Provide optional snappable types under the object for SLA assignment. This is meant to be used only for objects that support multiple snappable hierarchies. See 'applicableSnappableType' for more details. If more than one is provided, the SLA will be assigned to all.
    - id - System.String: SLA Domain ID.
    - objectIds - a list of System.Strings: A list of object forever UUIDs to assign to the global SLA Domain.
- Returns SlaDomainWithWarnings.
### DomainWithWarningsList
Query sla list with warnings

- The Input parameter takes a hashtable with 12 name and value pairs.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - applicableSnappableTypes - a list of WorkloadLevelHierarchys: Provide optional snappable types under the object for SLA assignment. This is meant to be used only for objects that support multiple snappable hierarchies. See 'applicableSnappableType' for more details. If more than one is provided, the SLA will be assigned to all.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
    - contextFilter - ContextFilterTypeEnum: Specifies the context filter to use.
    - filter - a list of GlobalSlaFilterInputs: Filter for the SLA Domain query.
    - first - System.Int32: Returns the first n elements from the list.
    - last - System.Int32: Returns the last n elements from the list.
    - objectIds - a list of System.Strings: Provide list of object forever IDS you want to assign SLA
    - operation - SlaWarningsOperation: Assignment operation with the SLA Domain.
    - snapshotIds - a list of System.Strings: Provides the forever IDs of the snapshots to assign SLA Domains to.
    - sortBy - SlaQuerySortByField: Field to sort the SLA Domains list.
    - sortOrder - SortOrder: Sort order for sorting the SLA Domains returned by the query.
- Returns a list of SlaDomainWithWarningss.
### ManagedVolume
Details of a SLA Managed Volume object.

- The Input parameter takes a single value of type System.String.
- Returns ManagedVolume.
### SummariesById
List of SLA summaries for the given ids

- The Input parameter takes a single value of type a list of System.Strings.
- Returns a list of SlaDomains.
### allCdpVmName
Names of the virtual machines in compute cluster with Continuous Data Protection (CDP) SLA Domain.

- The Input parameter takes a single value of type System.String.
- Returns a list of System.Strings.
### allClusterGlobal
Global SLA Domains protecting at least one object on the specified Rubrik cluster.

- The Input parameter takes a single value of type System.String.
- Returns a list of SlaInfos.
### allIofilterStatus
The iofilter installation status of the compute clusters related to this SLA Domain.

- The Input parameter takes a single value of type System.String.
- Returns a list of ComputeClusterIofilterStatuss.
### allNcdComplianceData
NAS Cloud Direct SLA Domain compliance data for the requested clusters.

- The Input parameter takes a single value of type a list of System.Strings.
- Returns a list of NcdSlaComplianceDatas.
### allObjecttestUserNoteAudit
Latest audit with usernote for a list of objects.

- The Input parameter takes a single value of type a list of System.Strings.
- Returns a list of LatestUserNotes.
### clusterDomainFilterList
- The Input parameter takes a hashtable with 4 name and value pairs.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
    - first - System.Int32: Returns the first n elements from the list.
    - last - System.Int32: Returns the last n elements from the list.
- Returns ClusterSlaDomainForFilterConnection.
### clusterDomainList
- The Input parameter takes a hashtable with 4 name and value pairs.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
    - first - System.Int32: Returns the first n elements from the list.
    - last - System.Int32: Returns the last n elements from the list.
- Returns ClusterSlaDomainConnection.
### countOfObjectsProtected
The number of objects protected by the SLA Domains.

- The Input parameter takes a hashtable with 4 name and value pairs.
    - filter - a list of Filters: The hierarchy object filter.
    - rootOptionalFid - System.String: Forever UUID of the object root. The value of  `none` represents the global hierarchy root.
    - slaIds - a list of System.Strings: A list of global SLA Domain IDs.
    - typeFilter - a list of HierarchyObjectTypeEnums: Types of objects to include.
- Returns CountOfObjectsProtectedBySLAsResult.
### downloadWithReplicationCsv
Download list of Global SLA CSV that have Replication to the given Rubrik Cluster.

- The Input parameter takes a hashtable with 2 name and value pairs.
    - cdmClusterUUID - System.String: UUID of the Rubrik cluster.
    - includeArchived - System.Boolean: Include Archived SLA.
- Returns DownloadSlaWithReplicationCsvReply.
### globalFilterList
- The Input parameter takes a hashtable with 14 name and value pairs.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
    - contextFilter - ContextFilterTypeEnum: Specifies the context filter to use.
    - contextFilterInput - a list of ContextFilterInputFields: Specifies the context filter input to use.
    - filter - a list of GlobalSlaFilterInputs: Filter for the SLA Domain query.
    - first - System.Int32: Returns the first n elements from the list.
    - last - System.Int32: Returns the last n elements from the list.
    - shouldShowPausedClusters - System.Boolean: Specifies whether to show the Rubrik clusters where this SLA Domain is paused.
    - shouldShowProtectedObjectCount - System.Boolean: Specifies whether to show the number of workloads protected by the SLA Domain.
    - shouldShowSyncStatus - System.Boolean: Specifies whether to show the SLA Domain sync status on Rubrik CDM.
    - shouldShowUpgradeInfo - System.Boolean: Specifies whether to show the upgrade information for an SLA Domain or not.
    - showRemoteSlas - System.Boolean: Specifies whether to retrieve the remote SLA Domains from Rubrik CDM. By default, remote SLA Domains are not retrieved.
    - sortBy - SlaQuerySortByField: Field to sort the SLA Domains list.
    - sortOrder - SortOrder: Sort order for sorting the SLA Domains returned by the query.
- Returns GlobalSlaForFilterConnection.
### globalStatus
Status on the clusters where global SLA is synced.

- The Input parameter takes a hashtable with 6 name and value pairs.
    - SlaId - System.String: SLA ID for global SLAs.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
    - filter - a list of SlaStatusFilterInputs: Filters for SLAStatus.
    - first - System.Int32: Returns the first n elements from the list.
    - last - System.Int32: Returns the last n elements from the list.
- Returns PolarisSlaStatusConnection.
### protectedClustersForGlobal
Clusters that have object(s) protected by global SLA.

- The Input parameter takes a hashtable with 5 name and value pairs.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
    - first - System.Int32: Returns the first n elements from the list.
    - last - System.Int32: Returns the last n elements from the list.
    - slaId - System.String: SLA ID for global SLAs.
- Returns ClusterConnection.
### verifyWithReplicationToCluster
- The Input parameter takes a hashtable with 2 name and value pairs.
    - cdmClusterUUID - System.String: UUID of the Rubrik cluster.
    - includeArchived - System.Boolean: Include Archived SLA.
- Returns VerifySLAWithReplicationToClusterResp.
