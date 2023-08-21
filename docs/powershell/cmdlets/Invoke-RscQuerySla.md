# Invoke-RscQuerySla
## Subcommands
### allcdpvmnames
Names of the virtual machines in compute cluster with Continuous Data Protection (CDP) SLA Domain.

- There is a single argument of type System.String.
- Returns list of System.Strings.
### allclusterglobals
Global SLA Domains protecting at least one object on the specified Rubrik cluster.

- There is a single argument of type System.String.
- Returns list of SlaInfos.
### alliofilterstatuses
The iofilter installation status of the compute clusters related to this SLA Domain.

- There is a single argument of type System.String.
- Returns list of ComputeClusterIofilterStatuss.
### allncdcompliancedata
NAS Cloud Direct SLA Domain compliance data for the requested clusters.

- There is a single argument of type list of System.Strings.
- Returns list of NcdSlaComplianceDatas.
### allsummariesbyids
List of SLA Domain summaries for the given IDs.

- There is a single argument of type list of System.Strings.
- Returns list of SlaDomains.
### archivalvalidationwarnings
SLA Domain warnings related to non-compliant archival retention duration in the archival policy.

- There is a single argument of type SlaArchivalWarningsInput.
- Returns SlaArchivalValidationWithWarnings.
### auditdetail
List of audit details for a given SLA Domain.

- There are 7 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
    - SlaId - System.String: SLA Domain ID for global SLA Domains and internal ID for SLA Domains created on Rubrik clusters.
    - filter - list of SLAAuditDetailFilterInputs: Filter for SLA Domain Audit details.
    - timezone - System.String: Timezone.
- Returns list of SlaAuditDetails.
### clusterdomainfilterlist
- There are 4 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
- Returns ClusterSlaDomainForFilterConnection.
### clusterdomains
Returns paginated list of SLA domains that were created on Rubrik CDM.

- There are 4 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
- Returns ClusterSlaDomainConnection.
### conflictobjects
- There is a single argument of type list of System.Strings.
- Returns list of HierarchyObjects.
### countofobjectsprotected
The number of objects protected by the SLA Domains.

- There are 4 arguments.
    - rootOptionalFid - System.String: Forever UUID of the object root. The value of  `none` represents the global hierarchy root.
    - slaIds - list of System.Strings: A list of SLA Domain IDs.
    - filter - list of Filters: The hierarchy object filter.
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
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
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
### domainwithwarnings
- There are 3 arguments.
    - id - System.String: SLA Domain ID.
    - objectIds - list of System.Strings: A list of object forever UUIDs to assign to the SLA Domain.
    - applicableSnappableTypes - list of WorkloadLevelHierarchys: Provide optional workload types under the object for SLA Domain assignment. This is meant to be used only for objects that support multiple workload hierarchies. This allows an SLA Domain to be set for one or more specific workload types under the object, instead of applying the SLA Domain for all the workload types. For example, an AWS account object can potentially have 2 different workload types under it - AwsNativeEc2Instance and AwsNativeRdsInstance. This field can be set with the appropriate type so that the SLA Domain only gets applied to workloads of the selected type under that account. If the SLA Domain must be applicable for all the workload types under the object, then this field can be set to `AllSubHierarchyType` or left blank. This field must either be left blank or set to `AllSubHierarchyType` when assigning SLA Domain to a workload or to an object that does not support multiple workload types. If more than one is provided, the SLA will be assigned to all.
- Returns SlaDomainWithWarnings.
### domainwithwarningslist
Query sla list with warnings

- There are 12 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
    - sortBy - SlaQuerySortByField: Field to sort the SLA Domains list.
    - sortOrder - SortOrder: Sort order for sorting the SLA Domains returned by the query.
    - filter - list of GlobalSlaFilterInputs: Filter for the SLA Domain query.
    - contextFilter - ContextFilterTypeEnum: Specifies the context filter to use.
    - objectIds - list of System.Strings: Provide list of object forever IDS you want to assign SLA
    - applicableSnappableTypes - list of WorkloadLevelHierarchys: Provide optional workload types under the object for SLA Domain assignment. This is meant to be used only for objects that support multiple workload hierarchies. This allows an SLA Domain to be set for one or more specific workload types under the object, instead of applying the SLA Domain for all the workload types. For example, an AWS account object can potentially have 2 different workload types under it - AwsNativeEc2Instance and AwsNativeRdsInstance. This field can be set with the appropriate type so that the SLA Domain only gets applied to workloads of the selected type under that account. If the SLA Domain must be applicable for all the workload types under the object, then this field can be set to `AllSubHierarchyType` or left blank. This field must either be left blank or set to `AllSubHierarchyType` when assigning SLA Domain to a workload or to an object that does not support multiple workload types. If more than one is provided, the SLA will be assigned to all.
    - snapshotIds - list of System.Strings: Provides the forever IDs of the snapshots to assign SLA Domains to.
    - operation - SlaWarningsOperation: Assignment operation with the SLA Domain.
- Returns list of SlaDomainWithWarningss.
### downloadwithreplicationcsv
Download list of Global SLA CSV that have Replication to the given Rubrik Cluster.

- There are 2 arguments.
    - cdmClusterUUID - System.String: UUID of the Rubrik cluster.
    - includeArchived - System.Boolean: Include Archived SLA.
- Returns DownloadSlaWithReplicationCsvReply.
### globalfilterlist
Retrieves a list of SLA Domains.

- There are 14 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
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
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
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
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - sortBy - HierarchySortByField: Sort hierarchy objects by hierarchy field.
    - sortOrder - SortOrder: Sorting order for the results.
    - filter - list of Filters: The hierarchy object filter.
- Returns ManagedVolumeConnection.
### protectedclustersforglobal
Clusters that have object(s) protected by global SLA.

- There are 5 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
    - slaId - System.String: SLA ID for global SLAs.
- Returns ClusterConnection.
### verifywithreplicationtocluster
Verify for a Rubrik cluster if it is replication target in any SLA Domain.

- There are 2 arguments.
    - cdmClusterUUID - System.String: UUID of the Rubrik cluster.
    - includeArchived - System.Boolean: Include Archived SLA.
- Returns VerifySlaWithReplicationToClusterResponse.
