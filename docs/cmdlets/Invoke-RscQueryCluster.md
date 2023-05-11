# Invoke-RscQueryCluster
## Subcommands
### Certificate
Get all certificates

Supported in v5.1+
Get all certificates.

- The Input parameter takes a single value of type QueryCertificatesInput.
- Returns CertificateSummaryListResponse.
### Cloud
List of Cloud Clusters with cloud information.

- The Input parameter takes a single value of type CcpVendorType.
- Returns a list of CcWithCloudInfos.
### Cluster
A cluster object.

- The Input parameter takes a single value of type System.String.
- Returns Cluster.
### Connected
List all connected clusters.

- The Input parameter takes a single value of type ClusterTypeEnum.
- Returns a list of DataLocationSupportedClusters.
### Csr
Get the cluster certificate signing request

Supported in v7.0+
Returns the certificate signing request generated from the private key of the Rubrik cluster.

- The Input parameter takes a single value of type GetClusterCsrInput.
- Returns ClusterCsr.
### DefaultGateway
Get current default gateway

Supported in v5.0+
Get current default gateway.

- The Input parameter takes a single value of type GetDefaultGatewayInput.
- Returns InternalGetDefaultGatewayResponse.
### Dns
Rubrik cluster DNS information.

- The Input parameter takes a single value of type System.String.
- Returns ClusterDnsReply.
### EncryptionInfo
Filter clusters by encryption information.

- The Input parameter takes a hashtable with 10 name and value pairs.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
    - clusterName - System.String: The prefix of the name of the Rubrik cluster.
    - clusters - a list of System.Strings: The IDs of the Rubrik clusters to select.
    - encryptionStatusFilter - a list of ClusterEncryptionStatusFilters: The encryption status of the Rubrik cluster.
    - encryptionTypes - a list of ClusterEncryptionTypes: The types of encryption.
    - first - System.Int32: Returns the first n elements from the list.
    - keyProtection - a list of ClusterKeyProtections: The key type used for the most recent key rotation.
    - last - System.Int32: Returns the last n elements from the list.
    - sortOrder - SortOrder: Sorting order for the results.
- Returns ClusterEncryptionInfoConnection.
### FloatingIp
Get a list of a cluster's always-available Ips

Supported in v5.0+
Get a list of a cluster's always-available Ips.

- The Input parameter takes a single value of type GetClusterIpsInput.
- Returns InternalGetClusterIpsResponse.
### GlobalFileSearchMultiple
All files and folders matching input filters.

- The Input parameter takes a hashtable with 2 name and value pairs.
    - clusters - a list of System.Strings: List of Rubrik cluster UUID's. If no clusters are provided, the search is applied to all clusters that the user has access to.
    - regex - System.String: The regular expression used to filter the files and folders.
- Returns GlobalFileSearchReplyType.
### GlobalSla
Global SLA Domains protecting at least one object on the specified Rubrik cluster.

- The Input parameter takes a single value of type System.String.
- Returns a list of SlaInfos.
### GroupByList
- The Input parameter takes a hashtable with 7 name and value pairs.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
    - filter - ClusterFilterInput
    - first - System.Int32: Returns the first n elements from the list.
    - groupBy - ClusterGroupByEnum: Group by field.
    - last - System.Int32: Returns the last n elements from the list.
    - timezoneOffset - System.Single: Offset based on customer timezone.
- Returns ClusterGroupByConnection.
### HostFailover
Get details of the given host failover cluster.

- The Input parameter takes a single value of type System.String.
- Returns HostFailoverCluster.
### Ipmi
Get IPMI details

Supported in v5.0+
get IPMI details of availability and enabled access in the cluster.

- The Input parameter takes a single value of type GetIpmiInput.
- Returns ModifyIpmiReply.
### K8s
- The Input parameter takes a single value of type System.String.
- Returns K8sCluster.
### List
- The Input parameter takes a hashtable with 7 name and value pairs.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
    - filter - ClusterFilterInput
    - first - System.Int32: Returns the first n elements from the list.
    - last - System.Int32: Returns the last n elements from the list.
    - sortBy - ClusterSortByEnum: Sort clusters by field.
    - sortOrder - SortOrder: Cluster sort order.
- Returns ClusterConnection.
### NetworkInterface
Get network interfaces for a Rubrik Cluster cluster

Supported in v5.0+
Retrieves network interfaces(including VLANs) on bond0/bond1.

- The Input parameter takes a single value of type GetNetworkInterfaceInput.
- Returns NetworkInterfaceListResponse.
### Node
Get list of nodes in this Rubrik cluster

Supported in v5.0+
Returns the list of all Rubrik nodes.

- The Input parameter takes a single value of type GetNodesInput.
- Returns NodeStatusListResponse.
### NtpServer
Get NTP Servers

Supported in v5.0+
Retrieve a list of the NTP servers assigned to the Rubrik cluster. Encryption keys are not reported.

- The Input parameter takes a single value of type GetClusterNtpServersInput.
- Returns NtpServerConfigurationListResponse.
### OperationJobProgress
Get updates on the job progress of the Rubrik cluster operation.

- The Input parameter takes a single value of type ClusterOperationJobProgressInput.
- Returns ClusterOperationJobProgress.
### Proxy
Rubrik cluster proxy information.

- The Input parameter takes a single value of type System.String.
- Returns ClusterProxyReply.
### RcvLocation
List Rubrik Cloud Vault locations of the cluster.

- The Input parameter takes a hashtable with 6 name and value pairs.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
    - cdmClusterUUID - System.String: UUID of the Rubrik cluster.
    - first - System.Int32: Returns the first n elements from the list.
    - last - System.Int32: Returns the last n elements from the list.
    - sortOrder - SortOrder: Sorting order for the results.
- Returns RcvLocationBasicInfoConnection.
### RegistrationProductInfo
Info about the cluster product types the user is entitled to.

- The RegistrationProductInfo subcommand takes no arguments.
- Returns ClusterRegistrationProductInfoType.
### ReplicationTarget
All replication targets for a cluster.

- The Input parameter takes a single value of type System.String.
- Returns a list of ClusterReplicationTargets.
### TotpAckStatus
Checks whether acknowledgement of the Time-based, One-Time Password (TOTP) mandate is required for upgrading the Rubrik cluster version.

- The Input parameter takes a single value of type a list of System.Strings.
- Returns a list of System.Booleans.
### TypeList
- The TypeList subcommand takes no arguments.
- Returns a list of GroupCounts.
### Vcd
List of vCloud Director clusters.

- The Input parameter takes a single value of type QueryVcdClusterInput.
- Returns VcdClusterSummaryListResponse.
### VerifySlaWithReplicationTo
- The Input parameter takes a hashtable with 2 name and value pairs.
    - cdmClusterUUID - System.String: UUID of the Rubrik cluster.
    - includeArchived - System.Boolean: Include Archived SLA.
- Returns VerifySLAWithReplicationToClusterResp.
### Vlan
Rubrik cluster VLAN information.

- The Input parameter takes a single value of type GetVlanInput.
- Returns VlanConfigListResponse.
### WebCertsAndIpmi
Get web server certificate and IPMI details for multiple clusters.

- The Input parameter takes a single value of type BulkClusterWebCertAndIpmiInput.
- Returns a list of ClusterWebCertAndIpmis.
### WebSignedCertificate
Get the signed certificate for Web server

Supported in v5.2+
If the web server uses a signed certificate, fetch it.

- The Input parameter takes a single value of type ClusterWebSignedCertificateInput.
- Returns ClusterWebSignedCertificateReply.
### Window
A Windows Cluster.

- The Input parameter takes a single value of type System.String.
- Returns WindowsCluster.
### WithConfigProtectionInfo
A cluster object with config protection information.

- The Input parameter takes a hashtable with 7 name and value pairs.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
    - configProtectionFilter - ConfigProtectionInfoFilterInput: Filters for the Configuration Protection page.
    - first - System.Int32: Returns the first n elements from the list.
    - last - System.Int32: Returns the last n elements from the list.
    - sortBy - ConfigProtectionInfoSortBy: Sort configuration protection information by field.
    - sortOrder - SortOrder: Cluster sort order.
- Returns ClusterConnection.
### WithUpgradesInfo
- The Input parameter takes a hashtable with 7 name and value pairs.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
    - first - System.Int32: Returns the first n elements from the list.
    - last - System.Int32: Returns the last n elements from the list.
    - sortBy - UpgradeInfoSortByEnum: sort upgradeInfo by field
    - sortOrder - SortOrder: Cluster sort order.
    - upgradeFilter - CdmUpgradeInfoFilterInput
- Returns ClusterConnection.
### isTotpAckNecessary
Checks whether acknowledgement of the Time-based, One-Time Password (TOTP) mandate is required for upgrading the Rubrik cluster version.

- The Input parameter takes a single value of type System.String.
- Returns System.Boolean.
### laDomainFilterList
- The Input parameter takes a hashtable with 4 name and value pairs.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
    - first - System.Int32: Returns the first n elements from the list.
    - last - System.Int32: Returns the last n elements from the list.
- Returns ClusterSlaDomainForFilterConnection.
### laDomainList
- The Input parameter takes a hashtable with 4 name and value pairs.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
    - first - System.Int32: Returns the first n elements from the list.
    - last - System.Int32: Returns the last n elements from the list.
- Returns ClusterSlaDomainConnection.
