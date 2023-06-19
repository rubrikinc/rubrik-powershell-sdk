# Invoke-RscQueryCluster
## Subcommands
### Certificate
Get all certificates

Supported in v5.1+
Get all certificates.

- There is a single argument of type QueryCertificatesInput.
- Returns CertificateSummaryListResponse.
### Cloud
List of Cloud Clusters with cloud information.

- There is a single argument of type CcpVendorType.
- Returns list of CcWithCloudInfos.
### Cluster
A cluster object.

- There is a single argument of type System.String.
- Returns Cluster.
### Connected
List all connected clusters.

- There is a single argument of type ClusterTypeEnum.
- Returns list of DataLocationSupportedClusters.
### Csr
Get the cluster certificate signing request

Supported in v7.0+
Returns the certificate signing request generated from the private key of the Rubrik cluster.

- There is a single argument of type GetClusterCsrInput.
- Returns ClusterCsr.
### Defaultgateway
Get current default gateway

Supported in v5.0+
Get current default gateway.

- There is a single argument of type GetDefaultGatewayInput.
- Returns InternalGetDefaultGatewayResponse.
### Dns
Rubrik cluster DNS information.

- There is a single argument of type System.String.
- Returns ClusterDnsReply.
### Encryptioninfo
Filter clusters by encryption information.

- There are 10 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
    - sortOrder - SortOrder: Sorting order for the results.
    - clusterName - System.String: The prefix of the name of the Rubrik cluster.
    - encryptionStatusFilter - list of ClusterEncryptionStatusFilters: The encryption status of the Rubrik cluster.
    - keyProtection - list of ClusterKeyProtections: The key type used for the most recent key rotation.
    - clusters - list of System.Strings: The IDs of the Rubrik clusters to select.
    - encryptionTypes - list of ClusterEncryptionTypes: The types of encryption.
- Returns ClusterEncryptionInfoConnection.
### Floatingip
Get a list of a cluster's always-available Ips

Supported in v5.0+
Get a list of a cluster's always-available Ips.

- There is a single argument of type GetClusterIpsInput.
- Returns InternalGetClusterIpsResponse.
### Globalfilesearchmultiple
All files and folders matching input filters.

- There are 2 arguments.
    - clusters - list of System.Strings: List of Rubrik cluster UUID's. If no clusters are provided, the search is applied to all clusters that the user has access to.
    - regex - System.String: The regular expression used to filter the files and folders.
- Returns GlobalFileSearchReplyType.
### Globalsla
Global SLA Domains protecting at least one object on the specified Rubrik cluster.

- There is a single argument of type System.String.
- Returns list of SlaInfos.
### Groupbyconnection
- There are 7 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
    - groupBy - ClusterGroupByEnum: Group by field.
    - filter - ClusterFilterInput
    - timezoneOffset - System.Single: Offset based on customer timezone.
- Returns ClusterGroupByConnection.
### Hostfailover
Get details of the given host failover cluster.

- There is a single argument of type System.String.
- Returns HostFailoverCluster.
### Ipmi
Get IPMI details

Supported in v5.0+
get IPMI details of availability and enabled access in the cluster.

- There is a single argument of type GetIpmiInput.
- Returns ModifyIpmiReply.
### Ipv6mode
Rubrik cluster IPv6 mode.

- There is a single argument of type ClusterIpv6ModeInput.
- Returns ClusterIpv6ModeReply.
### Istotpacknecessary
Checks whether acknowledgement of the Time-based, One-Time Password (TOTP) mandate is required for upgrading the Rubrik cluster version.

- There is a single argument of type System.String.
- Returns System.Boolean.
### K8s
- There are 5 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - sortBy - HierarchySortByField: Sort hierarchy objects by hierarchy field.
    - sortOrder - SortOrder: Sorting order for the results.
    - filter - list of Filters: The hierarchy object filter.
- Returns K8sClusterConnection.
### Ladomainconnection
- There are 4 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
- Returns ClusterSlaDomainConnection.
### Ladomainfilterconnection
- There are 4 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
- Returns ClusterSlaDomainForFilterConnection.
### List
List of the available cluster objects.

- There are 7 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
    - filter - ClusterFilterInput
    - sortOrder - SortOrder: Cluster sort order.
    - sortBy - ClusterSortByEnum: Sort clusters by field.
- Returns ClusterConnection.
### Networkinterface
Get network interfaces for a Rubrik Cluster cluster

Supported in v5.0+
Retrieves network interfaces(including VLANs) on bond0/bond1.

- There is a single argument of type GetNetworkInterfaceInput.
- Returns NetworkInterfaceListResponse.
### Node
Get list of nodes in this Rubrik cluster

Supported in v5.0+
Returns the list of all Rubrik nodes.

- There is a single argument of type GetNodesInput.
- Returns NodeStatusListResponse.
### Ntpserver
Get NTP Servers

Supported in v5.0+
Retrieve a list of the NTP servers assigned to the Rubrik cluster. Encryption keys are not reported.

- There is a single argument of type GetClusterNtpServersInput.
- Returns NtpServerConfigurationListResponse.
### Operationjobprogress
Get updates on the job progress of the Rubrik cluster operation.

- There is a single argument of type ClusterOperationJobProgressInput.
- Returns ClusterOperationJobProgress.
### Proxy
Rubrik cluster proxy information.

- There is a single argument of type System.String.
- Returns ClusterProxyReply.
### Rcvlocation
List Rubrik Cloud Vault locations of the cluster.

- There are 6 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
    - sortOrder - SortOrder: Sorting order for the results.
    - cdmClusterUUID - System.String: UUID of the Rubrik cluster.
- Returns RcvLocationBasicInfoConnection.
### Registrationproductinfo
Info about the cluster product types the user is entitled to.

- The Registrationproductinfo subcommand takes no arguments.
- Returns ClusterRegistrationProductInfoType.
### Replicationtarget
All replication targets for a cluster.

- There is a single argument of type System.String.
- Returns list of ClusterReplicationTargets.
### Totpackstatus
Checks whether acknowledgement of the Time-based, One-Time Password (TOTP) mandate is required for upgrading the Rubrik cluster version.

- There is a single argument of type list of System.Strings.
- Returns list of System.Booleans.
### Typelist
- The Typelist subcommand takes no arguments.
- Returns list of GroupCounts.
### Vcd
List of vCloud Director clusters.

- There is a single argument of type QueryVcdClusterInput.
- Returns VcdClusterSummaryListResponse.
### Verifyslawithreplicationto
- There are 2 arguments.
    - cdmClusterUUID - System.String: UUID of the Rubrik cluster.
    - includeArchived - System.Boolean: Include Archived SLA.
- Returns VerifySLAWithReplicationToClusterResp.
### Vlan
Rubrik cluster VLAN information.

- There is a single argument of type GetVlanInput.
- Returns VlanConfigListResponse.
### Webcertsandipmi
Get web server certificate and IPMI details for multiple clusters.

- There is a single argument of type BulkClusterWebCertAndIpmiInput.
- Returns list of ClusterWebCertAndIpmis.
### Websignedcertificate
Get the signed certificate for Web server

Supported in v5.2+
If the web server uses a signed certificate, fetch it.

- There is a single argument of type ClusterWebSignedCertificateInput.
- Returns ClusterWebSignedCertificateReply.
### Window
A Windows Cluster.

- There is a single argument of type System.String.
- Returns WindowsCluster.
### Withconfigprotectioninfo
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
### Withupgradesinfo
- There are 7 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
    - upgradeFilter - CdmUpgradeInfoFilterInput
    - sortOrder - SortOrder: Cluster sort order.
    - sortBy - UpgradeInfoSortByEnum: sort upgradeInfo by field
- Returns ClusterConnection.
