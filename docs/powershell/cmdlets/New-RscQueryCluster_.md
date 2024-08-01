# New-RscQueryCluster
## Subcommands
### areclusteralertspaused
Retrieve whether alerts are paused for a Rubrik cluster.

- There is a single argument of type AreClusterAlertsPausedInput.
- Returns System.Boolean.
### capacityquotasfororg
Returns cluster capacity quotas that have been created on the org.

- There is a single argument of type GetClusterCapacityQuotasForOrgInput.
- Returns list of ClusterWithCapacityQuotas.
### cdmapicalls
Retrieve all the CDM API metrics for a Rubrik cluster.

- There is a single argument of type GetCDMApiMetricsInput.
- Returns list of CdmApiMetrics.
### cloud
List of Cloud Clusters with cloud information.

- There is a single argument of type CcpVendorType.
- Returns list of CcWithCloudInfos.
### cluster
A cluster object.

- There is a single argument of type System.String.
- Returns Cluster.
### computeclusterstatus
Get details for the compute cluster

Supported in v5.1+
Get details for the compute cluster.

- There is a single argument of type GetComputeClusterInput.
- Returns ComputeClusterDetail.
### connected
List all connected clusters.

- There is a single argument of type ClusterTypeEnum.
- Returns list of DataLocationSupportedClusters.
### countgroupbymigrationstatus
Get status for mandatory migrations across all clusters.

- The countgroupbymigrationstatus subcommand takes no arguments.
- Returns list of MigrationsStatusCounts.
### defaultgateway
Get current default gateway

Supported in v5.0+
Get current default gateway.

- There is a single argument of type GetDefaultGatewayInput.
- Returns InternalGetDefaultGatewayResponse.
### dns
Rubrik cluster DNS information.

- There is a single argument of type System.String.
- Returns ClusterDnsReply.
### encryptioninfo
Filter clusters by encryption information.

- There are 10 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
    - sortOrder - SortOrder: Sort order of result.
    - clusterName - System.String: The prefix of the name of the Rubrik cluster.
    - encryptionStatusFilter - list of ClusterEncryptionStatusFilters: The encryption status of the Rubrik cluster.
    - keyProtection - list of ClusterKeyProtections: The key type used for the most recent key rotation.
    - clusters - list of System.Strings: The IDs of the Rubrik clusters to select.
    - encryptionTypes - list of ClusterEncryptionTypes: The types of encryption.
- Returns ClusterEncryptionInfoConnection.
### floatingips
Get a list of a cluster's always-available Ips

Supported in v5.0+
Get a list of a cluster's always-available Ips.

- There is a single argument of type GetClusterIpsInput.
- Returns InternalGetClusterIpsResponse.
### getcdmreleasedetailsforclusterfromsupportportal
Get CDM release details from support portal for a given list of clusters.

- There are 7 arguments.
    - listClusterUuid - list of System.Strings: Specifies the list of cluster UUIDs.
    - filterVersion - System.String: Prefix filter for available versions.
    - fetchLinks - System.Boolean: Retrieves version details.
    - filterUpgradeable - System.Boolean: Filters for the available upgrade versions.
    - shouldShowAll - System.Boolean: Shows all versions.
    - filterAfterSource - System.Boolean: Filter to include only the versions released after the source version.
    - sortOrder - SortOrder: Sort order of result.
- Returns CdmUpgradeReleaseDetailsFromSupportPortalReply.
### getgroupcountbycdmclusterstatus
- The getgroupcountbycdmclusterstatus subcommand takes no arguments.
- Returns GroupCountListWithTotal.
### globalfilesearchmultiple
All files and folders matching input filters.

- There are 2 arguments.
    - clusters - list of System.Strings: List of Rubrik cluster UUID's. If no clusters are provided, the search is applied to all clusters that the user has access to.
    - regex - System.String: The regular expression used to filter the files and folders.
- Returns GlobalFileSearchReplyType.
### groupbylist
- There are 7 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
    - groupBy - ClusterGroupByEnum: Group by field.
    - filter - ClusterFilterInput: Filter by cluster.
    - timezoneOffset - System.Single: Offset based on customer timezone.
- Returns ClusterGroupByConnection.
### ipmi
Get IPMI details

Supported in v5.0+
get IPMI details of availability and enabled access in the cluster.

- There is a single argument of type GetIpmiInput.
- Returns ModifyIpmiReply.
### ipv6mode
Rubrik cluster IPv6 mode.

- There is a single argument of type ClusterIpv6ModeInput.
- Returns ClusterIpv6ModeReply.
### istotpacknecessary
Checks whether acknowledgement of the Time-based, One-Time Password (TOTP) mandate is required for upgrading the Rubrik cluster version.

- There is a single argument of type System.String.
- Returns System.Boolean.
### kubernetes
Summary of all Kubernetes Clusters.

- There are 5 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - sortBy - HierarchySortByField: Sort hierarchy objects according to the hierarchy field.
    - sortOrder - SortOrder: Sort order of result.
    - filter - list of Filters: The hierarchy object filter.
- Returns KubernetesClusterConnection.
### licensesforclusterproductsummary
Information about licenses for a specific cluster product, grouped by the product type.

- There is a single argument of type LicensesForClusterProductSummaryInput.
- Returns LicensesForClusterProductReply.
### list
List of the available cluster objects.

- There are 7 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
    - filter - ClusterFilterInput: Filter by cluster.
    - sortOrder - SortOrder: Cluster sort order.
    - sortBy - ClusterSortByEnum: Sort clusters by field.
- Returns ClusterConnection.
### migration
Get all migration clusters.

- There is a single argument of type GetAllMigrationClustersInput.
- Returns GetAllMigrationClustersReply.
### missing
All missing clusters from the account.

- There are 2 arguments.
    - connectionStatus - MissingClusterConnectionStatus: Rubrik cluster connection status.
    - isExcluded - System.Boolean: Rubrik cluster exclusion status.
- Returns MissingClusterConnection.
### networkinterfaces
Get network interfaces for a Rubrik Cluster cluster

Supported in v5.0+
Retrieves network interfaces(including VLANs) on bond0/bond1.

- There is a single argument of type GetNetworkInterfaceInput.
- Returns NetworkInterfaceListResponse.
### newmigration
Retrieve newly added Rubrik clusters to migrate to RSC.

- The newmigration subcommand takes no arguments.
- Returns GetNewlyAddedClustersReply.
### nodes
Get list of nodes in this Rubrik cluster

Supported in v5.0+
Returns the list of all Rubrik nodes.

- There is a single argument of type GetNodesInput.
- Returns NodeStatusListResponse.
### ntpservers
Get NTP Servers

Supported in v5.0+
Retrieve a list of the NTP servers assigned to the Rubrik cluster. Encryption keys are not reported.

- There is a single argument of type GetClusterNtpServersInput.
- Returns NtpServerConfigurationListResponse.
### operationjobprogress
Get updates on the job progress of the Rubrik cluster operation.

- There is a single argument of type ClusterOperationJobProgressInput.
- Returns ClusterOperationJobProgress.
### postgresdbclusterlivemounts
The live mounts of the given workloads.

- There are 4 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - filters - list of KosmosWorkloadLiveMountFilterInputs: Filter for Kosmos workload live mounts.
    - sortBy - KosmosWorkloadLiveMountSortByInput: Sort by argument for Kosmos Workload live mounts.
- Returns KosmosWorkloadLiveMountConnection.
### postgresqldb
Details of a PostgreSQL database cluster for a given FID.

- There is a single argument of type System.String.
- Returns PostgreSQLDbCluster.
### proxy
Rubrik cluster proxy information.

- There is a single argument of type System.String.
- Returns ClusterProxyReply.
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
### registrationproductinfo
Info about the cluster product types the user is entitled to.

- The registrationproductinfo subcommand takes no arguments.
- Returns ClusterRegistrationProductInfoType.
### replicationtargets
All replication targets for a cluster.

- There is a single argument of type System.String.
- Returns list of ClusterReplicationTargets.
### routes
Rubrik cluster routes information.

- There is a single argument of type System.String.
- Returns ClusterRoutesReply.
### thriftauthtoken
Get cluster thrift token for replication target.

- There is a single argument of type GetOrCreateThriftAuthReceiveTokenInput.
- Returns ThriftAuthToken.
### totpackstatus
Checks whether acknowledgement of the Time-based, One-Time Password (TOTP) mandate is required for upgrading the Rubrik cluster version.

- There is a single argument of type list of System.Strings.
- Returns list of System.Booleans.
### typelist
- The typelist subcommand takes no arguments.
- Returns list of GroupCounts.
### validateclusterlicensecapacity
Information about cluster license capacity validations.

- There is a single argument of type ValidateClusterLicenseCapacityInput.
- Returns ClusterLicenseCapacityValidations.
### vcd
List of vCloud Director clusters.

- There is a single argument of type QueryVcdClusterInput.
- Returns VcdClusterSummaryListResponse.
### vlans
Rubrik cluster VLAN information.

- There is a single argument of type GetVlanInput.
- Returns VlanConfigListResponse.
### webcertsandipmis
Get web server certificate and IPMI details for multiple clusters.

- There is a single argument of type BulkClusterWebCertAndIpmiInput.
- Returns list of ClusterWebCertAndIpmis.
### windows
A Windows Cluster.

- There is a single argument of type System.String.
- Returns WindowsCluster.
### withconfigprotectioninfo
A cluster object with config protection information.

- There are 7 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
    - configProtectionFilter - ConfigProtectionInfoFilterInput: Filters for the Configuration Protection page.
    - sortOrder - SortOrder: Cluster sort order.
    - sortBy - ConfigProtectionInfoSortBy: Sort configuration protection information by field.
- Returns ClusterConnection.
### withupgradesinfo
- There are 7 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
    - upgradeFilter - CdmUpgradeInfoFilterInput
    - sortOrder - SortOrder: Cluster sort order.
    - sortBy - UpgradeInfoSortByEnum: sort upgradeInfo by field
- Returns ClusterConnection.
