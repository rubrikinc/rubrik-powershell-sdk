# New-RscQueryCluster
## Subcommands
### cluster
A cluster object.

- There is a single argument of type System.String.
- Returns Cluster.
### connected
List all connected clusters.

- There is a single argument of type ClusterTypeEnum.
- Returns list of DataLocationSupportedClusters.
### databaselogreport
Get the database log backup delay information

Supported in v5.3+
v5.3: 
v6.0+: Get the database log backup delay information.

- There is a single argument of type QueryLogReportInput.
- Returns DbLogReportSummaryListReply.
### databaselogreportingproperties
Get the database log backup report properties

Supported in v5.3+
Get the properties for the database (SQL and Oracle) log backup delay email notification creation. The properties are logDelayThresholdInMin and logDelayNotificationFrequencyInMin.

- There is a single argument of type QueryReportPropertiesInput.
- Returns DbLogReportProperties.
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
### floatingips
Get a list of a cluster's always-available Ips

Supported in v5.0+
Get a list of a cluster's always-available Ips.

- There is a single argument of type GetClusterIpsInput.
- Returns InternalGetClusterIpsResponse.
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
### hostfailover
Get details of the given host failover cluster.

- There is a single argument of type System.String.
- Returns HostFailoverCluster.
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
### networkinterfaces
Get network interfaces for a Rubrik Cluster cluster

Supported in v5.0+
Retrieves network interfaces(including VLANs) on bond0/bond1.

- There is a single argument of type GetNetworkInterfaceInput.
- Returns NetworkInterfaceListResponse.
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
### proxy
Rubrik cluster proxy information.

- There is a single argument of type System.String.
- Returns ClusterProxyReply.
### registrationproductinfo
Info about the cluster product types the user is entitled to.

- The registrationproductinfo subcommand takes no arguments.
- Returns ClusterRegistrationProductInfoType.
### replicationtargets
All replication targets for a cluster.

- There is a single argument of type System.String.
- Returns list of ClusterReplicationTargets.
### reportmigrationcount
Retrieve the counts of the Rubrik cluster reports migration.

- There are 2 arguments.
    - clusterUuid - System.String: The Rubrik cluster ID.
    - status - list of CdmReportMigrationStatuss: Rubrik cluster report migration status.
- Returns ReportsMigrationCount.
### reportmigrationjobstatus
Retrieve the status of the cluster report migration job.

- There is a single argument of type System.String.
- Returns ClusterReportMigrationJobStatus.
### reportmigrationstatus
Retrieve details of the Rubrik clusters' reports migration.

- There are 6 arguments.
    - clusterUuid - System.String: The Rubrik cluster ID.
    - status - list of CdmReportMigrationStatuss: Rubrik cluster report migration status.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
- Returns ReportMigrationStatusConnection.
### totpackstatus
Checks whether acknowledgement of the Time-based, One-Time Password (TOTP) mandate is required for upgrading the Rubrik cluster version.

- There is a single argument of type list of System.Strings.
- Returns list of System.Booleans.
### typelist
- The typelist subcommand takes no arguments.
- Returns list of GroupCounts.
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
