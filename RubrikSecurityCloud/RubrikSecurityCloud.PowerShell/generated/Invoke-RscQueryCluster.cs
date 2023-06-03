// Invoke-RscQueryCluster.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using Rubrik.SecurityCloud.Types;
using Rubrik.SecurityCloud.NetSDK.Client;
using Rubrik.SecurityCloud.PowerShell.Private;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Management.Automation;
using System.Text;
using System.Threading.Tasks;
using RubrikSecurityCloud.Schema.Utils;
using GraphQL;

namespace Rubrik.SecurityCloud.PowerShell.Cmdlets
{
    [Cmdlet(
        "Invoke",
        "RscQueryCluster",
        DefaultParameterSetName = "Cluster")
    ]
    public class Invoke_RscQueryCluster : RscPSCmdlet
    {
        
        // -------------------------------------------------------------------
        // Cloud parameter set
        //
        // GraphQL operation: allCloudClusters(cloudVendorType: CcpVendorType!):[CcWithCloudInfo!]!
        //
        [Parameter(
            ParameterSetName = "Cloud",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                List of Cloud Clusters with cloud information.
                GraphQL operation: allCloudClusters(cloudVendorType: CcpVendorType!):[CcWithCloudInfo!]!
                ",
            Position = 0
        )]
        public SwitchParameter Cloud { get; set; }

        [Parameter(
            ParameterSetName = "Cloud",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Cloud vendor name.
                GraphQL argument cloudVendorType: CcpVendorType!
                "
        )]
        public CcpVendorType? CloudVendorType { get; set; }
        
        // -------------------------------------------------------------------
        // Node parameter set
        //
        // GraphQL operation: clusterNodes(input: GetNodesInput!):NodeStatusListResponse!
        //
        [Parameter(
            ParameterSetName = "Node",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Get list of nodes in this Rubrik cluster

Supported in v5.0+
Returns the list of all Rubrik nodes.
                GraphQL operation: clusterNodes(input: GetNodesInput!):NodeStatusListResponse!
                ",
            Position = 0
        )]
        public SwitchParameter Node { get; set; }

        [Parameter(
            ParameterSetName = "Node",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Input for InternalGetNodes.
                GraphQL argument input: GetNodesInput!
                "
        )]
        public GetNodesInput? Input { get; set; }
        
        // -------------------------------------------------------------------
        // List parameter set
        //
        // GraphQL operation: clusterConnection(,   first: Int,   after: String,   last: Int,   before: String,   filter: ClusterFilterInput,   sortOrder: SortOrder = DESC,   sortBy: ClusterSortByEnum = ClusterType, ):ClusterConnection!
        //
        [Parameter(
            ParameterSetName = "List",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                List of the available cluster objects.
                GraphQL operation: clusterConnection(,   first: Int,   after: String,   last: Int,   before: String,   filter: ClusterFilterInput,   sortOrder: SortOrder = DESC,   sortBy: ClusterSortByEnum = ClusterType, ):ClusterConnection!
                ",
            Position = 0
        )]
        public SwitchParameter List { get; set; }

        [Parameter(
            ParameterSetName = "List",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Returns the first n elements from the list.
                GraphQL argument first: Int
                "
        )]
        public System.Int32? First { get; set; }
        [Parameter(
            ParameterSetName = "List",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Returns the elements in the list that come after the specified cursor.
                GraphQL argument after: String
                "
        )]
        public System.String? After { get; set; }
        [Parameter(
            ParameterSetName = "List",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Returns the last n elements from the list.
                GraphQL argument last: Int
                "
        )]
        public System.Int32? Last { get; set; }
        [Parameter(
            ParameterSetName = "List",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Returns the elements in the list that come before the specified cursor.
                GraphQL argument before: String
                "
        )]
        public System.String? Before { get; set; }
        [Parameter(
            ParameterSetName = "List",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                
                GraphQL argument filter: ClusterFilterInput
                "
        )]
        public ClusterFilterInput? Filter { get; set; }
        [Parameter(
            ParameterSetName = "List",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Cluster sort order.
                GraphQL argument sortOrder: SortOrder
                "
        )]
        public SortOrder? SortOrder { get; set; }
        [Parameter(
            ParameterSetName = "List",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Sort clusters by field.
                GraphQL argument sortBy: ClusterSortByEnum
                "
        )]
        public ClusterSortByEnum? SortBy { get; set; }
        
        // -------------------------------------------------------------------
        // Cluster parameter set
        //
        // GraphQL operation: cluster(clusterUuid: UUID!):Cluster!
        //
        [Parameter(
            ParameterSetName = "Cluster",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                A cluster object.
                GraphQL operation: cluster(clusterUuid: UUID!):Cluster!
                ",
            Position = 0
        )]
        public SwitchParameter Cluster { get; set; }

        [Parameter(
            ParameterSetName = "Cluster",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                The Rubrik cluster ID.
                GraphQL argument clusterUuid: UUID!
                "
        )]
        public System.String? ClusterUuid { get; set; }
        
        // -------------------------------------------------------------------
        // WithUpgradesInfo parameter set
        //
        // GraphQL operation: clusterWithUpgradesInfo(,   first: Int,   after: String,   last: Int,   before: String,   upgradeFilter: CdmUpgradeInfoFilterInput,   sortOrder: SortOrder = DESC,   sortBy: UpgradeInfoSortByEnum = ClusterType, ):ClusterConnection!
        //
        [Parameter(
            ParameterSetName = "WithUpgradesInfo",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                
                GraphQL operation: clusterWithUpgradesInfo(,   first: Int,   after: String,   last: Int,   before: String,   upgradeFilter: CdmUpgradeInfoFilterInput,   sortOrder: SortOrder = DESC,   sortBy: UpgradeInfoSortByEnum = ClusterType, ):ClusterConnection!
                ",
            Position = 0
        )]
        public SwitchParameter WithUpgradesInfo { get; set; }

        [Parameter(
            ParameterSetName = "WithUpgradesInfo",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                
                GraphQL argument upgradeFilter: CdmUpgradeInfoFilterInput
                "
        )]
        public CdmUpgradeInfoFilterInput? UpgradeFilter { get; set; }
        
        // -------------------------------------------------------------------
        // Dns parameter set
        //
        // GraphQL operation: clusterDns(clusterUuid: UUID!):ClusterDnsReply!
        //
        [Parameter(
            ParameterSetName = "Dns",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Rubrik cluster DNS information.
                GraphQL operation: clusterDns(clusterUuid: UUID!):ClusterDnsReply!
                ",
            Position = 0
        )]
        public SwitchParameter Dns { get; set; }

        
        // -------------------------------------------------------------------
        // Proxy parameter set
        //
        // GraphQL operation: clusterProxy(clusterUuid: UUID!):ClusterProxyReply!
        //
        [Parameter(
            ParameterSetName = "Proxy",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Rubrik cluster proxy information.
                GraphQL operation: clusterProxy(clusterUuid: UUID!):ClusterProxyReply!
                ",
            Position = 0
        )]
        public SwitchParameter Proxy { get; set; }

        
        // -------------------------------------------------------------------
        // NtpServer parameter set
        //
        // GraphQL operation: clusterNtpServers(input: GetClusterNtpServersInput!):NtpServerConfigurationListResponse!
        //
        [Parameter(
            ParameterSetName = "NtpServer",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Get NTP Servers

Supported in v5.0+
Retrieve a list of the NTP servers assigned to the Rubrik cluster. Encryption keys are not reported.
                GraphQL operation: clusterNtpServers(input: GetClusterNtpServersInput!):NtpServerConfigurationListResponse!
                ",
            Position = 0
        )]
        public SwitchParameter NtpServer { get; set; }

        
        // -------------------------------------------------------------------
        // NetworkInterface parameter set
        //
        // GraphQL operation: clusterNetworkInterfaces(input: GetNetworkInterfaceInput!):NetworkInterfaceListResponse!
        //
        [Parameter(
            ParameterSetName = "NetworkInterface",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Get network interfaces for a Rubrik Cluster cluster

Supported in v5.0+
Retrieves network interfaces(including VLANs) on bond0/bond1.
                GraphQL operation: clusterNetworkInterfaces(input: GetNetworkInterfaceInput!):NetworkInterfaceListResponse!
                ",
            Position = 0
        )]
        public SwitchParameter NetworkInterface { get; set; }

        
        // -------------------------------------------------------------------
        // FloatingIp parameter set
        //
        // GraphQL operation: clusterFloatingIps(input: GetClusterIpsInput!):InternalGetClusterIpsResponse!
        //
        [Parameter(
            ParameterSetName = "FloatingIp",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Get a list of a cluster's always-available Ips

Supported in v5.0+
Get a list of a cluster's always-available Ips.
                GraphQL operation: clusterFloatingIps(input: GetClusterIpsInput!):InternalGetClusterIpsResponse!
                ",
            Position = 0
        )]
        public SwitchParameter FloatingIp { get; set; }

        
        // -------------------------------------------------------------------
        // Vlan parameter set
        //
        // GraphQL operation: clusterVlans(input: GetVlanInput!):VlanConfigListResponse!
        //
        [Parameter(
            ParameterSetName = "Vlan",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Rubrik cluster VLAN information.
                GraphQL operation: clusterVlans(input: GetVlanInput!):VlanConfigListResponse!
                ",
            Position = 0
        )]
        public SwitchParameter Vlan { get; set; }

        
        // -------------------------------------------------------------------
        // DefaultGateway parameter set
        //
        // GraphQL operation: clusterDefaultGateway(input: GetDefaultGatewayInput!):InternalGetDefaultGatewayResponse!
        //
        [Parameter(
            ParameterSetName = "DefaultGateway",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Get current default gateway

Supported in v5.0+
Get current default gateway.
                GraphQL operation: clusterDefaultGateway(input: GetDefaultGatewayInput!):InternalGetDefaultGatewayResponse!
                ",
            Position = 0
        )]
        public SwitchParameter DefaultGateway { get; set; }

        
        // -------------------------------------------------------------------
        // WebSignedCertificate parameter set
        //
        // GraphQL operation: clusterWebSignedCertificate(input: ClusterWebSignedCertificateInput!):ClusterWebSignedCertificateReply!
        //
        [Parameter(
            ParameterSetName = "WebSignedCertificate",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Get the signed certificate for Web server

Supported in v5.2+
If the web server uses a signed certificate, fetch it.
                GraphQL operation: clusterWebSignedCertificate(input: ClusterWebSignedCertificateInput!):ClusterWebSignedCertificateReply!
                ",
            Position = 0
        )]
        public SwitchParameter WebSignedCertificate { get; set; }

        
        // -------------------------------------------------------------------
        // Ipmi parameter set
        //
        // GraphQL operation: clusterIpmi(input: GetIpmiInput!):ModifyIpmiReply!
        //
        [Parameter(
            ParameterSetName = "Ipmi",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Get IPMI details

Supported in v5.0+
get IPMI details of availability and enabled access in the cluster.
                GraphQL operation: clusterIpmi(input: GetIpmiInput!):ModifyIpmiReply!
                ",
            Position = 0
        )]
        public SwitchParameter Ipmi { get; set; }

        
        // -------------------------------------------------------------------
        // Certificate parameter set
        //
        // GraphQL operation: clusterCertificates(input: QueryCertificatesInput!):CertificateSummaryListResponse!
        //
        [Parameter(
            ParameterSetName = "Certificate",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Get all certificates

Supported in v5.1+
Get all certificates.
                GraphQL operation: clusterCertificates(input: QueryCertificatesInput!):CertificateSummaryListResponse!
                ",
            Position = 0
        )]
        public SwitchParameter Certificate { get; set; }

        
        // -------------------------------------------------------------------
        // WebCertsAndIpmi parameter set
        //
        // GraphQL operation: allClusterWebCertsAndIpmis(input: BulkClusterWebCertAndIpmiInput!):[ClusterWebCertAndIpmi!]!
        //
        [Parameter(
            ParameterSetName = "WebCertsAndIpmi",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Get web server certificate and IPMI details for multiple clusters.
                GraphQL operation: allClusterWebCertsAndIpmis(input: BulkClusterWebCertAndIpmiInput!):[ClusterWebCertAndIpmi!]!
                ",
            Position = 0
        )]
        public SwitchParameter WebCertsAndIpmi { get; set; }

        
        // -------------------------------------------------------------------
        // OperationJobProgress parameter set
        //
        // GraphQL operation: clusterOperationJobProgress(input: ClusterOperationJobProgressInput!):ClusterOperationJobProgress!
        //
        [Parameter(
            ParameterSetName = "OperationJobProgress",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Get updates on the job progress of the Rubrik cluster operation.
                GraphQL operation: clusterOperationJobProgress(input: ClusterOperationJobProgressInput!):ClusterOperationJobProgress!
                ",
            Position = 0
        )]
        public SwitchParameter OperationJobProgress { get; set; }

        
        // -------------------------------------------------------------------
        // Ipv6Mode parameter set
        //
        // GraphQL operation: clusterIpv6Mode(input: ClusterIpv6ModeInput!):ClusterIpv6ModeReply!
        //
        [Parameter(
            ParameterSetName = "Ipv6Mode",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Rubrik cluster IPv6 mode.
                GraphQL operation: clusterIpv6Mode(input: ClusterIpv6ModeInput!):ClusterIpv6ModeReply!
                ",
            Position = 0
        )]
        public SwitchParameter Ipv6Mode { get; set; }

        
        // -------------------------------------------------------------------
        // Csr parameter set
        //
        // GraphQL operation: clusterCsr(input: GetClusterCsrInput!):ClusterCsr!
        //
        [Parameter(
            ParameterSetName = "Csr",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Get the cluster certificate signing request

Supported in v7.0+
Returns the certificate signing request generated from the private key of the Rubrik cluster.
                GraphQL operation: clusterCsr(input: GetClusterCsrInput!):ClusterCsr!
                ",
            Position = 0
        )]
        public SwitchParameter Csr { get; set; }

        
        // -------------------------------------------------------------------
        // TypeList parameter set
        //
        // GraphQL operation: clusterTypeList:[GroupCount!]!
        //
        [Parameter(
            ParameterSetName = "TypeList",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                
                GraphQL operation: clusterTypeList:[GroupCount!]!
                ",
            Position = 0
        )]
        public SwitchParameter TypeList { get; set; }

        
        // -------------------------------------------------------------------
        // GroupByList parameter set
        //
        // GraphQL operation: clusterGroupByConnection(,   first: Int,   after: String,   last: Int,   before: String,   groupBy: ClusterGroupByEnum!,   filter: ClusterFilterInput,   timezoneOffset: Float = 0.0, ):ClusterGroupByConnection!
        //
        [Parameter(
            ParameterSetName = "GroupByList",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                
                GraphQL operation: clusterGroupByConnection(,   first: Int,   after: String,   last: Int,   before: String,   groupBy: ClusterGroupByEnum!,   filter: ClusterFilterInput,   timezoneOffset: Float = 0.0, ):ClusterGroupByConnection!
                ",
            Position = 0
        )]
        public SwitchParameter GroupByList { get; set; }

        [Parameter(
            ParameterSetName = "GroupByList",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Group by field.
                GraphQL argument groupBy: ClusterGroupByEnum!
                "
        )]
        public ClusterGroupByEnum? GroupBy { get; set; }
        [Parameter(
            ParameterSetName = "GroupByList",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Offset based on customer timezone.
                GraphQL argument timezoneOffset: Float
                "
        )]
        public System.Single? TimezoneOffset { get; set; }
        
        // -------------------------------------------------------------------
        // WithConfigProtectionInfo parameter set
        //
        // GraphQL operation: clusterWithConfigProtectionInfo(,   first: Int,   after: String,   last: Int,   before: String,   configProtectionFilter: ConfigProtectionInfoFilterInput,   sortOrder: SortOrder = DESC,   sortBy: ConfigProtectionInfoSortBy = CLUSTER_NAME, ):ClusterConnection!
        //
        [Parameter(
            ParameterSetName = "WithConfigProtectionInfo",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                A cluster object with config protection information.
                GraphQL operation: clusterWithConfigProtectionInfo(,   first: Int,   after: String,   last: Int,   before: String,   configProtectionFilter: ConfigProtectionInfoFilterInput,   sortOrder: SortOrder = DESC,   sortBy: ConfigProtectionInfoSortBy = CLUSTER_NAME, ):ClusterConnection!
                ",
            Position = 0
        )]
        public SwitchParameter WithConfigProtectionInfo { get; set; }

        [Parameter(
            ParameterSetName = "WithConfigProtectionInfo",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Filters for the Configuration Protection page.
                GraphQL argument configProtectionFilter: ConfigProtectionInfoFilterInput
                "
        )]
        public ConfigProtectionInfoFilterInput? ConfigProtectionFilter { get; set; }
        
        // -------------------------------------------------------------------
        // RcvLocation parameter set
        //
        // GraphQL operation: clusterRcvLocations(,   first: Int,   after: String,   last: Int,   before: String,   sortOrder: SortOrder,   cdmClusterUUID: UUID!, ):RcvLocationBasicInfoConnection!
        //
        [Parameter(
            ParameterSetName = "RcvLocation",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                List Rubrik Cloud Vault locations of the cluster.
                GraphQL operation: clusterRcvLocations(,   first: Int,   after: String,   last: Int,   before: String,   sortOrder: SortOrder,   cdmClusterUUID: UUID!, ):RcvLocationBasicInfoConnection!
                ",
            Position = 0
        )]
        public SwitchParameter RcvLocation { get; set; }

        [Parameter(
            ParameterSetName = "RcvLocation",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                UUID of the Rubrik cluster.
                GraphQL argument cdmClusterUUID: UUID!
                "
        )]
        public System.String? CdmClusterUuid { get; set; }
        
        // -------------------------------------------------------------------
        // Connected parameter set
        //
        // GraphQL operation: allConnectedClusters(clusterFilterArg: ClusterTypeEnum):[DataLocationSupportedCluster!]!
        //
        [Parameter(
            ParameterSetName = "Connected",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                List all connected clusters.
                GraphQL operation: allConnectedClusters(clusterFilterArg: ClusterTypeEnum):[DataLocationSupportedCluster!]!
                ",
            Position = 0
        )]
        public SwitchParameter Connected { get; set; }

        [Parameter(
            ParameterSetName = "Connected",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Specification to filter cluster based on type.
                GraphQL argument clusterFilterArg: ClusterTypeEnum
                "
        )]
        public ClusterTypeEnum? ClusterFilterArg { get; set; }
        
        // -------------------------------------------------------------------
        // ReplicationTarget parameter set
        //
        // GraphQL operation: allClusterReplicationTargets(clusterUuid: UUID!):[ClusterReplicationTarget!]!
        //
        [Parameter(
            ParameterSetName = "ReplicationTarget",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                All replication targets for a cluster.
                GraphQL operation: allClusterReplicationTargets(clusterUuid: UUID!):[ClusterReplicationTarget!]!
                ",
            Position = 0
        )]
        public SwitchParameter ReplicationTarget { get; set; }

        
        // -------------------------------------------------------------------
        // EncryptionInfo parameter set
        //
        // GraphQL operation: clusterEncryptionInfo(,   first: Int,   after: String,   last: Int,   before: String,   sortOrder: SortOrder,   clusterName: String,   encryptionStatusFilter: [ClusterEncryptionStatusFilter!]! = [],   keyProtection: [ClusterKeyProtection!]! = [],   clusters: [UUID!]! = [],   encryptionTypes: [ClusterEncryptionType!]! = [], ):ClusterEncryptionInfoConnection!
        //
        [Parameter(
            ParameterSetName = "EncryptionInfo",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Filter clusters by encryption information.
                GraphQL operation: clusterEncryptionInfo(,   first: Int,   after: String,   last: Int,   before: String,   sortOrder: SortOrder,   clusterName: String,   encryptionStatusFilter: [ClusterEncryptionStatusFilter!]! = [],   keyProtection: [ClusterKeyProtection!]! = [],   clusters: [UUID!]! = [],   encryptionTypes: [ClusterEncryptionType!]! = [], ):ClusterEncryptionInfoConnection!
                ",
            Position = 0
        )]
        public SwitchParameter EncryptionInfo { get; set; }

        [Parameter(
            ParameterSetName = "EncryptionInfo",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                The prefix of the name of the Rubrik cluster.
                GraphQL argument clusterName: String
                "
        )]
        public System.String? ClusterName { get; set; }
        [Parameter(
            ParameterSetName = "EncryptionInfo",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                The encryption status of the Rubrik cluster.
                GraphQL argument encryptionStatusFilter: [ClusterEncryptionStatusFilter!]!
                "
        )]
        public List<ClusterEncryptionStatusFilter>? EncryptionStatusFilter { get; set; }
        [Parameter(
            ParameterSetName = "EncryptionInfo",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                The key type used for the most recent key rotation.
                GraphQL argument keyProtection: [ClusterKeyProtection!]!
                "
        )]
        public List<ClusterKeyProtection>? KeyProtection { get; set; }
        [Parameter(
            ParameterSetName = "EncryptionInfo",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                The IDs of the Rubrik clusters to select.
                GraphQL argument clusters: [UUID!]!
                "
        )]
        public List<System.String>? Clusters { get; set; }
        [Parameter(
            ParameterSetName = "EncryptionInfo",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                The types of encryption.
                GraphQL argument encryptionTypes: [ClusterEncryptionType!]!
                "
        )]
        public List<ClusterEncryptionType>? EncryptionTypes { get; set; }
        
        // -------------------------------------------------------------------
        // HostFailover parameter set
        //
        // GraphQL operation: hostFailoverCluster(fid: UUID!):HostFailoverCluster!
        //
        [Parameter(
            ParameterSetName = "HostFailover",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Get details of the given host failover cluster.
                GraphQL operation: hostFailoverCluster(fid: UUID!):HostFailoverCluster!
                ",
            Position = 0
        )]
        public SwitchParameter HostFailover { get; set; }

        [Parameter(
            ParameterSetName = "HostFailover",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                The Rubrik UUID for the object.
                GraphQL argument fid: UUID!
                "
        )]
        public System.String? Fid { get; set; }
        
        // -------------------------------------------------------------------
        // GlobalFileSearchMultiple parameter set
        //
        // GraphQL operation: allGlobalFileSearchMultipleClusters(clusters: [UUID!]! = [], regex: String!):GlobalFileSearchReplyType!
        //
        [Parameter(
            ParameterSetName = "GlobalFileSearchMultiple",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                All files and folders matching input filters.
                GraphQL operation: allGlobalFileSearchMultipleClusters(clusters: [UUID!]! = [], regex: String!):GlobalFileSearchReplyType!
                ",
            Position = 0
        )]
        public SwitchParameter GlobalFileSearchMultiple { get; set; }

        [Parameter(
            ParameterSetName = "GlobalFileSearchMultiple",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                The regular expression used to filter the files and folders.
                GraphQL argument regex: String!
                "
        )]
        public System.String? Regex { get; set; }
        
        // -------------------------------------------------------------------
        // K8s parameter set
        //
        // GraphQL operation: k8sClusters(,   first: Int,   after: String,   sortBy: HierarchySortByField,   sortOrder: SortOrder,   filter: [Filter!], ):K8sClusterConnection!
        //
        [Parameter(
            ParameterSetName = "K8s",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                
                GraphQL operation: k8sClusters(,   first: Int,   after: String,   sortBy: HierarchySortByField,   sortOrder: SortOrder,   filter: [Filter!], ):K8sClusterConnection!
                ",
            Position = 0
        )]
        public SwitchParameter K8s { get; set; }

        
        // -------------------------------------------------------------------
        // Window parameter set
        //
        // GraphQL operation: windowsCluster(fid: UUID!):WindowsCluster!
        //
        [Parameter(
            ParameterSetName = "Window",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                A Windows Cluster.
                GraphQL operation: windowsCluster(fid: UUID!):WindowsCluster!
                ",
            Position = 0
        )]
        public SwitchParameter Window { get; set; }

        
        // -------------------------------------------------------------------
        // laDomainList parameter set
        //
        // GraphQL operation: clusterSlaDomainConnection(,   first: Int,   after: String,   last: Int,   before: String, ):ClusterSlaDomainConnection!
        //
        [Parameter(
            ParameterSetName = "laDomainList",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                
                GraphQL operation: clusterSlaDomainConnection(,   first: Int,   after: String,   last: Int,   before: String, ):ClusterSlaDomainConnection!
                ",
            Position = 0
        )]
        public SwitchParameter laDomainList { get; set; }

        
        // -------------------------------------------------------------------
        // laDomainFilterList parameter set
        //
        // GraphQL operation: clusterSlaDomainFilterConnection(,   first: Int,   after: String,   last: Int,   before: String, ):ClusterSlaDomainForFilterConnection!
        //
        [Parameter(
            ParameterSetName = "laDomainFilterList",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                
                GraphQL operation: clusterSlaDomainFilterConnection(,   first: Int,   after: String,   last: Int,   before: String, ):ClusterSlaDomainForFilterConnection!
                ",
            Position = 0
        )]
        public SwitchParameter laDomainFilterList { get; set; }

        
        // -------------------------------------------------------------------
        // VerifySlaWithReplicationTo parameter set
        //
        // GraphQL operation: verifySLAWithReplicationToCluster(cdmClusterUUID: UUID!, includeArchived: Boolean!):VerifySLAWithReplicationToClusterResp!
        //
        [Parameter(
            ParameterSetName = "VerifySlaWithReplicationTo",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                
                GraphQL operation: verifySLAWithReplicationToCluster(cdmClusterUUID: UUID!, includeArchived: Boolean!):VerifySLAWithReplicationToClusterResp!
                ",
            Position = 0
        )]
        public SwitchParameter VerifySlaWithReplicationTo { get; set; }

        [Parameter(
            ParameterSetName = "VerifySlaWithReplicationTo",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Include Archived SLA.
                GraphQL argument includeArchived: Boolean!
                "
        )]
        public System.Boolean? IncludeArchived { get; set; }
        
        // -------------------------------------------------------------------
        // GlobalSla parameter set
        //
        // GraphQL operation: allClusterGlobalSlas(cdmClusterUUID: UUID!):[SlaInfo!]!
        //
        [Parameter(
            ParameterSetName = "GlobalSla",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Global SLA Domains protecting at least one object on the specified Rubrik cluster.
                GraphQL operation: allClusterGlobalSlas(cdmClusterUUID: UUID!):[SlaInfo!]!
                ",
            Position = 0
        )]
        public SwitchParameter GlobalSla { get; set; }

        
        // -------------------------------------------------------------------
        // RegistrationProductInfo parameter set
        //
        // GraphQL operation: clusterRegistrationProductInfo:ClusterRegistrationProductInfoType!
        //
        [Parameter(
            ParameterSetName = "RegistrationProductInfo",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Info about the cluster product types the user is entitled to.
                GraphQL operation: clusterRegistrationProductInfo:ClusterRegistrationProductInfoType!
                ",
            Position = 0
        )]
        public SwitchParameter RegistrationProductInfo { get; set; }

        
        // -------------------------------------------------------------------
        // Vcd parameter set
        //
        // GraphQL operation: vcdClusters(input: QueryVcdClusterInput!):VcdClusterSummaryListResponse!
        //
        [Parameter(
            ParameterSetName = "Vcd",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                List of vCloud Director clusters.
                GraphQL operation: vcdClusters(input: QueryVcdClusterInput!):VcdClusterSummaryListResponse!
                ",
            Position = 0
        )]
        public SwitchParameter Vcd { get; set; }

        
        // -------------------------------------------------------------------
        // isTotpAckNecessary parameter set
        //
        // GraphQL operation: isTotpAckNecessaryForCluster(clusterUuid: UUID!):Boolean!
        //
        [Parameter(
            ParameterSetName = "isTotpAckNecessary",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Checks whether acknowledgement of the Time-based, One-Time Password (TOTP) mandate is required for upgrading the Rubrik cluster version.
                GraphQL operation: isTotpAckNecessaryForCluster(clusterUuid: UUID!):Boolean!
                ",
            Position = 0
        )]
        public SwitchParameter isTotpAckNecessary { get; set; }

        
        // -------------------------------------------------------------------
        // TotpAckStatus parameter set
        //
        // GraphQL operation: allClustersTotpAckStatus(listClusterUuid: [UUID!]!):[Boolean!]!
        //
        [Parameter(
            ParameterSetName = "TotpAckStatus",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Checks whether acknowledgement of the Time-based, One-Time Password (TOTP) mandate is required for upgrading the Rubrik cluster version.
                GraphQL operation: allClustersTotpAckStatus(listClusterUuid: [UUID!]!):[Boolean!]!
                ",
            Position = 0
        )]
        public SwitchParameter TotpAckStatus { get; set; }

        [Parameter(
            ParameterSetName = "TotpAckStatus",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Specifies the list of cluster UUIDs.
                GraphQL argument listClusterUuid: [UUID!]!
                "
        )]
        public List<System.String>? ListClusterUuid { get; set; }

        protected override void ProcessRecord()
        {
            try
            {
                switch(Op)
                {
                    case "Cloud":
                        this.ProcessRecord_Cloud();
                        break;
                    case "Node":
                        this.ProcessRecord_Node();
                        break;
                    case "List":
                        this.ProcessRecord_List();
                        break;
                    case "Cluster":
                        this.ProcessRecord_Cluster();
                        break;
                    case "WithUpgradesInfo":
                        this.ProcessRecord_WithUpgradesInfo();
                        break;
                    case "Dns":
                        this.ProcessRecord_Dns();
                        break;
                    case "Proxy":
                        this.ProcessRecord_Proxy();
                        break;
                    case "NtpServer":
                        this.ProcessRecord_NtpServer();
                        break;
                    case "NetworkInterface":
                        this.ProcessRecord_NetworkInterface();
                        break;
                    case "FloatingIp":
                        this.ProcessRecord_FloatingIp();
                        break;
                    case "Vlan":
                        this.ProcessRecord_Vlan();
                        break;
                    case "DefaultGateway":
                        this.ProcessRecord_DefaultGateway();
                        break;
                    case "WebSignedCertificate":
                        this.ProcessRecord_WebSignedCertificate();
                        break;
                    case "Ipmi":
                        this.ProcessRecord_Ipmi();
                        break;
                    case "Certificate":
                        this.ProcessRecord_Certificate();
                        break;
                    case "WebCertsAndIpmi":
                        this.ProcessRecord_WebCertsAndIpmi();
                        break;
                    case "OperationJobProgress":
                        this.ProcessRecord_OperationJobProgress();
                        break;
                    case "Ipv6Mode":
                        this.ProcessRecord_Ipv6Mode();
                        break;
                    case "Csr":
                        this.ProcessRecord_Csr();
                        break;
                    case "TypeList":
                        this.ProcessRecord_TypeList();
                        break;
                    case "GroupByList":
                        this.ProcessRecord_GroupByList();
                        break;
                    case "WithConfigProtectionInfo":
                        this.ProcessRecord_WithConfigProtectionInfo();
                        break;
                    case "RcvLocation":
                        this.ProcessRecord_RcvLocation();
                        break;
                    case "Connected":
                        this.ProcessRecord_Connected();
                        break;
                    case "ReplicationTarget":
                        this.ProcessRecord_ReplicationTarget();
                        break;
                    case "EncryptionInfo":
                        this.ProcessRecord_EncryptionInfo();
                        break;
                    case "HostFailover":
                        this.ProcessRecord_HostFailover();
                        break;
                    case "GlobalFileSearchMultiple":
                        this.ProcessRecord_GlobalFileSearchMultiple();
                        break;
                    case "K8s":
                        this.ProcessRecord_K8s();
                        break;
                    case "Window":
                        this.ProcessRecord_Window();
                        break;
                    case "laDomainList":
                        this.ProcessRecord_laDomainList();
                        break;
                    case "laDomainFilterList":
                        this.ProcessRecord_laDomainFilterList();
                        break;
                    case "VerifySlaWithReplicationTo":
                        this.ProcessRecord_VerifySlaWithReplicationTo();
                        break;
                    case "GlobalSla":
                        this.ProcessRecord_GlobalSla();
                        break;
                    case "RegistrationProductInfo":
                        this.ProcessRecord_RegistrationProductInfo();
                        break;
                    case "Vcd":
                        this.ProcessRecord_Vcd();
                        break;
                    case "isTotpAckNecessary":
                        this.ProcessRecord_isTotpAckNecessary();
                        break;
                    case "TotpAckStatus":
                        this.ProcessRecord_TotpAckStatus();
                        break;
                    default:
                        throw new Exception("Unknown Operation " + Op);
                }
           }
           catch (Exception ex)
           {
                this._logger.Flush();
                var error = new ErrorRecord(
                    ex,
                    "Invoke-RscQueryCluster",
                    ErrorCategory.InvalidOperation,
                    null);
                ThrowTerminatingError(error);
           }
        }

        // This parameter set invokes a single graphql operation:
        // allCloudClusters.
        protected void ProcessRecord_Cloud()
        {
            this._logger.name += " -Cloud";
            // Invoke graphql operation allCloudClusters
            InvokeQueryAllCloudClusters();
        }

        // This parameter set invokes a single graphql operation:
        // clusterNodes.
        protected void ProcessRecord_Node()
        {
            this._logger.name += " -Node";
            // Invoke graphql operation clusterNodes
            InvokeQueryClusterNodes();
        }

        // This parameter set invokes a single graphql operation:
        // clusterConnection.
        protected void ProcessRecord_List()
        {
            this._logger.name += " -List";
            // Invoke graphql operation clusterConnection
            InvokeQueryClusterConnection();
        }

        // This parameter set invokes a single graphql operation:
        // cluster.
        protected void ProcessRecord_Cluster()
        {
            this._logger.name += " -Cluster";
            // Invoke graphql operation cluster
            InvokeQueryCluster();
        }

        // This parameter set invokes a single graphql operation:
        // clusterWithUpgradesInfo.
        protected void ProcessRecord_WithUpgradesInfo()
        {
            this._logger.name += " -WithUpgradesInfo";
            // Invoke graphql operation clusterWithUpgradesInfo
            InvokeQueryClusterWithUpgradesInfo();
        }

        // This parameter set invokes a single graphql operation:
        // clusterDns.
        protected void ProcessRecord_Dns()
        {
            this._logger.name += " -Dns";
            // Invoke graphql operation clusterDns
            InvokeQueryClusterDns();
        }

        // This parameter set invokes a single graphql operation:
        // clusterProxy.
        protected void ProcessRecord_Proxy()
        {
            this._logger.name += " -Proxy";
            // Invoke graphql operation clusterProxy
            InvokeQueryClusterProxy();
        }

        // This parameter set invokes a single graphql operation:
        // clusterNtpServers.
        protected void ProcessRecord_NtpServer()
        {
            this._logger.name += " -NtpServer";
            // Invoke graphql operation clusterNtpServers
            InvokeQueryClusterNtpServers();
        }

        // This parameter set invokes a single graphql operation:
        // clusterNetworkInterfaces.
        protected void ProcessRecord_NetworkInterface()
        {
            this._logger.name += " -NetworkInterface";
            // Invoke graphql operation clusterNetworkInterfaces
            InvokeQueryClusterNetworkInterfaces();
        }

        // This parameter set invokes a single graphql operation:
        // clusterFloatingIps.
        protected void ProcessRecord_FloatingIp()
        {
            this._logger.name += " -FloatingIp";
            // Invoke graphql operation clusterFloatingIps
            InvokeQueryClusterFloatingIps();
        }

        // This parameter set invokes a single graphql operation:
        // clusterVlans.
        protected void ProcessRecord_Vlan()
        {
            this._logger.name += " -Vlan";
            // Invoke graphql operation clusterVlans
            InvokeQueryClusterVlans();
        }

        // This parameter set invokes a single graphql operation:
        // clusterDefaultGateway.
        protected void ProcessRecord_DefaultGateway()
        {
            this._logger.name += " -DefaultGateway";
            // Invoke graphql operation clusterDefaultGateway
            InvokeQueryClusterDefaultGateway();
        }

        // This parameter set invokes a single graphql operation:
        // clusterWebSignedCertificate.
        protected void ProcessRecord_WebSignedCertificate()
        {
            this._logger.name += " -WebSignedCertificate";
            // Invoke graphql operation clusterWebSignedCertificate
            InvokeQueryClusterWebSignedCertificate();
        }

        // This parameter set invokes a single graphql operation:
        // clusterIpmi.
        protected void ProcessRecord_Ipmi()
        {
            this._logger.name += " -Ipmi";
            // Invoke graphql operation clusterIpmi
            InvokeQueryClusterIpmi();
        }

        // This parameter set invokes a single graphql operation:
        // clusterCertificates.
        protected void ProcessRecord_Certificate()
        {
            this._logger.name += " -Certificate";
            // Invoke graphql operation clusterCertificates
            InvokeQueryClusterCertificates();
        }

        // This parameter set invokes a single graphql operation:
        // allClusterWebCertsAndIpmis.
        protected void ProcessRecord_WebCertsAndIpmi()
        {
            this._logger.name += " -WebCertsAndIpmi";
            // Invoke graphql operation allClusterWebCertsAndIpmis
            InvokeQueryAllClusterWebCertsAndIpmis();
        }

        // This parameter set invokes a single graphql operation:
        // clusterOperationJobProgress.
        protected void ProcessRecord_OperationJobProgress()
        {
            this._logger.name += " -OperationJobProgress";
            // Invoke graphql operation clusterOperationJobProgress
            InvokeQueryClusterOperationJobProgress();
        }

        // This parameter set invokes a single graphql operation:
        // clusterIpv6Mode.
        protected void ProcessRecord_Ipv6Mode()
        {
            this._logger.name += " -Ipv6Mode";
            // Invoke graphql operation clusterIpv6Mode
            InvokeQueryClusterIpv6Mode();
        }

        // This parameter set invokes a single graphql operation:
        // clusterCsr.
        protected void ProcessRecord_Csr()
        {
            this._logger.name += " -Csr";
            // Invoke graphql operation clusterCsr
            InvokeQueryClusterCsr();
        }

        // This parameter set invokes a single graphql operation:
        // clusterTypeList.
        protected void ProcessRecord_TypeList()
        {
            this._logger.name += " -TypeList";
            // Invoke graphql operation clusterTypeList
            InvokeQueryClusterTypeList();
        }

        // This parameter set invokes a single graphql operation:
        // clusterGroupByConnection.
        protected void ProcessRecord_GroupByList()
        {
            this._logger.name += " -GroupByList";
            // Invoke graphql operation clusterGroupByConnection
            InvokeQueryClusterGroupByConnection();
        }

        // This parameter set invokes a single graphql operation:
        // clusterWithConfigProtectionInfo.
        protected void ProcessRecord_WithConfigProtectionInfo()
        {
            this._logger.name += " -WithConfigProtectionInfo";
            // Invoke graphql operation clusterWithConfigProtectionInfo
            InvokeQueryClusterWithConfigProtectionInfo();
        }

        // This parameter set invokes a single graphql operation:
        // clusterRcvLocations.
        protected void ProcessRecord_RcvLocation()
        {
            this._logger.name += " -RcvLocation";
            // Invoke graphql operation clusterRcvLocations
            InvokeQueryClusterRcvLocations();
        }

        // This parameter set invokes a single graphql operation:
        // allConnectedClusters.
        protected void ProcessRecord_Connected()
        {
            this._logger.name += " -Connected";
            // Invoke graphql operation allConnectedClusters
            InvokeQueryAllConnectedClusters();
        }

        // This parameter set invokes a single graphql operation:
        // allClusterReplicationTargets.
        protected void ProcessRecord_ReplicationTarget()
        {
            this._logger.name += " -ReplicationTarget";
            // Invoke graphql operation allClusterReplicationTargets
            InvokeQueryAllClusterReplicationTargets();
        }

        // This parameter set invokes a single graphql operation:
        // clusterEncryptionInfo.
        protected void ProcessRecord_EncryptionInfo()
        {
            this._logger.name += " -EncryptionInfo";
            // Invoke graphql operation clusterEncryptionInfo
            InvokeQueryClusterEncryptionInfo();
        }

        // This parameter set invokes a single graphql operation:
        // hostFailoverCluster.
        protected void ProcessRecord_HostFailover()
        {
            this._logger.name += " -HostFailover";
            // Invoke graphql operation hostFailoverCluster
            InvokeQueryHostFailoverCluster();
        }

        // This parameter set invokes a single graphql operation:
        // allGlobalFileSearchMultipleClusters.
        protected void ProcessRecord_GlobalFileSearchMultiple()
        {
            this._logger.name += " -GlobalFileSearchMultiple";
            // Invoke graphql operation allGlobalFileSearchMultipleClusters
            InvokeQueryAllGlobalFileSearchMultipleClusters();
        }

        // This parameter set invokes a single graphql operation:
        // k8sClusters.
        protected void ProcessRecord_K8s()
        {
            this._logger.name += " -K8s";
            // Invoke graphql operation k8sClusters
            InvokeQueryK8sClusters();
        }

        // This parameter set invokes a single graphql operation:
        // windowsCluster.
        protected void ProcessRecord_Window()
        {
            this._logger.name += " -Window";
            // Invoke graphql operation windowsCluster
            InvokeQueryWindowsCluster();
        }

        // This parameter set invokes a single graphql operation:
        // clusterSlaDomainConnection.
        protected void ProcessRecord_laDomainList()
        {
            this._logger.name += " -laDomainList";
            // Invoke graphql operation clusterSlaDomainConnection
            InvokeQueryClusterSlaDomainConnection();
        }

        // This parameter set invokes a single graphql operation:
        // clusterSlaDomainFilterConnection.
        protected void ProcessRecord_laDomainFilterList()
        {
            this._logger.name += " -laDomainFilterList";
            // Invoke graphql operation clusterSlaDomainFilterConnection
            InvokeQueryClusterSlaDomainFilterConnection();
        }

        // This parameter set invokes a single graphql operation:
        // verifySLAWithReplicationToCluster.
        protected void ProcessRecord_VerifySlaWithReplicationTo()
        {
            this._logger.name += " -VerifySlaWithReplicationTo";
            // Invoke graphql operation verifySLAWithReplicationToCluster
            InvokeQueryVerifySlaWithReplicationToCluster();
        }

        // This parameter set invokes a single graphql operation:
        // allClusterGlobalSlas.
        protected void ProcessRecord_GlobalSla()
        {
            this._logger.name += " -GlobalSla";
            // Invoke graphql operation allClusterGlobalSlas
            InvokeQueryAllClusterGlobalSlas();
        }

        // This parameter set invokes a single graphql operation:
        // clusterRegistrationProductInfo.
        protected void ProcessRecord_RegistrationProductInfo()
        {
            this._logger.name += " -RegistrationProductInfo";
            // Invoke graphql operation clusterRegistrationProductInfo
            InvokeQueryClusterRegistrationProductInfo();
        }

        // This parameter set invokes a single graphql operation:
        // vcdClusters.
        protected void ProcessRecord_Vcd()
        {
            this._logger.name += " -Vcd";
            // Invoke graphql operation vcdClusters
            InvokeQueryVcdClusters();
        }

        // This parameter set invokes a single graphql operation:
        // isTotpAckNecessaryForCluster.
        protected void ProcessRecord_isTotpAckNecessary()
        {
            this._logger.name += " -isTotpAckNecessary";
            // Invoke graphql operation isTotpAckNecessaryForCluster
            InvokeQueryIsTotpAckNecessaryForCluster();
        }

        // This parameter set invokes a single graphql operation:
        // allClustersTotpAckStatus.
        protected void ProcessRecord_TotpAckStatus()
        {
            this._logger.name += " -TotpAckStatus";
            // Invoke graphql operation allClustersTotpAckStatus
            InvokeQueryAllClustersTotpAckStatus();
        }


        // Invoke GraphQL Query:
        // allCloudClusters(cloudVendorType: CcpVendorType!): [CcWithCloudInfo!]!
        protected void InvokeQueryAllCloudClusters()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("cloudVendorType", "CcpVendorType!"),
            };
            List<CcWithCloudInfo>? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (List<CcWithCloudInfo>)psObject.BaseObject;
                } else {
                    fields = (List<CcWithCloudInfo>)this.Field;
                }
            }
            string document = Query.AllCloudClusters(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AllCloudClusters");
            var parameters = "($cloudVendorType: CcpVendorType!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAllCloudClusters" + parameters + "{" + document + "}",
                OperationName = "QueryAllCloudClusters",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "List<CcWithCloudInfo>", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // clusterNodes(input: GetNodesInput!): NodeStatusListResponse!
        protected void InvokeQueryClusterNodes()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetNodesInput!"),
            };
            NodeStatusListResponse? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (NodeStatusListResponse)psObject.BaseObject;
                } else {
                    fields = (NodeStatusListResponse)this.Field;
                }
            }
            string document = Query.ClusterNodes(ref fields);
            this._input.Initialize(argDefs, fields, "Query.ClusterNodes");
            var parameters = "($input: GetNodesInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryClusterNodes" + parameters + "{" + document + "}",
                OperationName = "QueryClusterNodes",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "NodeStatusListResponse", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // clusterConnection(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     filter: ClusterFilterInput
        //     sortOrder: SortOrder = DESC
        //     sortBy: ClusterSortByEnum = ClusterType
        //   ): ClusterConnection!
        protected void InvokeQueryClusterConnection()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("filter", "ClusterFilterInput"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("sortBy", "ClusterSortByEnum"),
            };
            ClusterConnection? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (ClusterConnection)psObject.BaseObject;
                } else {
                    fields = (ClusterConnection)this.Field;
                }
            }
            string document = Query.ClusterConnection(ref fields);
            this._input.Initialize(argDefs, fields, "Query.ClusterConnection");
            var parameters = "($first: Int,$after: String,$last: Int,$before: String,$filter: ClusterFilterInput,$sortOrder: SortOrder,$sortBy: ClusterSortByEnum)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryClusterConnection" + parameters + "{" + document + "}",
                OperationName = "QueryClusterConnection",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "ClusterConnection", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // cluster(clusterUuid: UUID!): Cluster!
        protected void InvokeQueryCluster()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("clusterUuid", "UUID!"),
            };
            Cluster? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (Cluster)psObject.BaseObject;
                } else {
                    fields = (Cluster)this.Field;
                }
            }
            string document = Query.Cluster(ref fields);
            this._input.Initialize(argDefs, fields, "Query.Cluster");
            var parameters = "($clusterUuid: UUID!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryCluster" + parameters + "{" + document + "}",
                OperationName = "QueryCluster",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "Cluster", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // clusterWithUpgradesInfo(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     upgradeFilter: CdmUpgradeInfoFilterInput
        //     sortOrder: SortOrder = DESC
        //     sortBy: UpgradeInfoSortByEnum = ClusterType
        //   ): ClusterConnection!
        protected void InvokeQueryClusterWithUpgradesInfo()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("upgradeFilter", "CdmUpgradeInfoFilterInput"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("sortBy", "UpgradeInfoSortByEnum"),
            };
            ClusterConnection? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (ClusterConnection)psObject.BaseObject;
                } else {
                    fields = (ClusterConnection)this.Field;
                }
            }
            string document = Query.ClusterWithUpgradesInfo(ref fields);
            this._input.Initialize(argDefs, fields, "Query.ClusterWithUpgradesInfo");
            var parameters = "($first: Int,$after: String,$last: Int,$before: String,$upgradeFilter: CdmUpgradeInfoFilterInput,$sortOrder: SortOrder,$sortBy: UpgradeInfoSortByEnum)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryClusterWithUpgradesInfo" + parameters + "{" + document + "}",
                OperationName = "QueryClusterWithUpgradesInfo",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "ClusterConnection", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // clusterDns(clusterUuid: UUID!): ClusterDnsReply!
        protected void InvokeQueryClusterDns()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("clusterUuid", "UUID!"),
            };
            ClusterDnsReply? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (ClusterDnsReply)psObject.BaseObject;
                } else {
                    fields = (ClusterDnsReply)this.Field;
                }
            }
            string document = Query.ClusterDns(ref fields);
            this._input.Initialize(argDefs, fields, "Query.ClusterDns");
            var parameters = "($clusterUuid: UUID!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryClusterDns" + parameters + "{" + document + "}",
                OperationName = "QueryClusterDns",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "ClusterDnsReply", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // clusterProxy(clusterUuid: UUID!): ClusterProxyReply!
        protected void InvokeQueryClusterProxy()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("clusterUuid", "UUID!"),
            };
            ClusterProxyReply? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (ClusterProxyReply)psObject.BaseObject;
                } else {
                    fields = (ClusterProxyReply)this.Field;
                }
            }
            string document = Query.ClusterProxy(ref fields);
            this._input.Initialize(argDefs, fields, "Query.ClusterProxy");
            var parameters = "($clusterUuid: UUID!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryClusterProxy" + parameters + "{" + document + "}",
                OperationName = "QueryClusterProxy",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "ClusterProxyReply", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // clusterNtpServers(input: GetClusterNtpServersInput!): NtpServerConfigurationListResponse!
        protected void InvokeQueryClusterNtpServers()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetClusterNtpServersInput!"),
            };
            NtpServerConfigurationListResponse? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (NtpServerConfigurationListResponse)psObject.BaseObject;
                } else {
                    fields = (NtpServerConfigurationListResponse)this.Field;
                }
            }
            string document = Query.ClusterNtpServers(ref fields);
            this._input.Initialize(argDefs, fields, "Query.ClusterNtpServers");
            var parameters = "($input: GetClusterNtpServersInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryClusterNtpServers" + parameters + "{" + document + "}",
                OperationName = "QueryClusterNtpServers",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "NtpServerConfigurationListResponse", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // clusterNetworkInterfaces(input: GetNetworkInterfaceInput!): NetworkInterfaceListResponse!
        protected void InvokeQueryClusterNetworkInterfaces()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetNetworkInterfaceInput!"),
            };
            NetworkInterfaceListResponse? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (NetworkInterfaceListResponse)psObject.BaseObject;
                } else {
                    fields = (NetworkInterfaceListResponse)this.Field;
                }
            }
            string document = Query.ClusterNetworkInterfaces(ref fields);
            this._input.Initialize(argDefs, fields, "Query.ClusterNetworkInterfaces");
            var parameters = "($input: GetNetworkInterfaceInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryClusterNetworkInterfaces" + parameters + "{" + document + "}",
                OperationName = "QueryClusterNetworkInterfaces",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "NetworkInterfaceListResponse", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // clusterFloatingIps(input: GetClusterIpsInput!): InternalGetClusterIpsResponse!
        protected void InvokeQueryClusterFloatingIps()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetClusterIpsInput!"),
            };
            InternalGetClusterIpsResponse? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (InternalGetClusterIpsResponse)psObject.BaseObject;
                } else {
                    fields = (InternalGetClusterIpsResponse)this.Field;
                }
            }
            string document = Query.ClusterFloatingIps(ref fields);
            this._input.Initialize(argDefs, fields, "Query.ClusterFloatingIps");
            var parameters = "($input: GetClusterIpsInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryClusterFloatingIps" + parameters + "{" + document + "}",
                OperationName = "QueryClusterFloatingIps",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "InternalGetClusterIpsResponse", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // clusterVlans(input: GetVlanInput!): VlanConfigListResponse!
        protected void InvokeQueryClusterVlans()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetVlanInput!"),
            };
            VlanConfigListResponse? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (VlanConfigListResponse)psObject.BaseObject;
                } else {
                    fields = (VlanConfigListResponse)this.Field;
                }
            }
            string document = Query.ClusterVlans(ref fields);
            this._input.Initialize(argDefs, fields, "Query.ClusterVlans");
            var parameters = "($input: GetVlanInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryClusterVlans" + parameters + "{" + document + "}",
                OperationName = "QueryClusterVlans",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "VlanConfigListResponse", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // clusterDefaultGateway(input: GetDefaultGatewayInput!): InternalGetDefaultGatewayResponse!
        protected void InvokeQueryClusterDefaultGateway()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetDefaultGatewayInput!"),
            };
            InternalGetDefaultGatewayResponse? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (InternalGetDefaultGatewayResponse)psObject.BaseObject;
                } else {
                    fields = (InternalGetDefaultGatewayResponse)this.Field;
                }
            }
            string document = Query.ClusterDefaultGateway(ref fields);
            this._input.Initialize(argDefs, fields, "Query.ClusterDefaultGateway");
            var parameters = "($input: GetDefaultGatewayInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryClusterDefaultGateway" + parameters + "{" + document + "}",
                OperationName = "QueryClusterDefaultGateway",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "InternalGetDefaultGatewayResponse", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // clusterWebSignedCertificate(input: ClusterWebSignedCertificateInput!): ClusterWebSignedCertificateReply!
        protected void InvokeQueryClusterWebSignedCertificate()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "ClusterWebSignedCertificateInput!"),
            };
            ClusterWebSignedCertificateReply? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (ClusterWebSignedCertificateReply)psObject.BaseObject;
                } else {
                    fields = (ClusterWebSignedCertificateReply)this.Field;
                }
            }
            string document = Query.ClusterWebSignedCertificate(ref fields);
            this._input.Initialize(argDefs, fields, "Query.ClusterWebSignedCertificate");
            var parameters = "($input: ClusterWebSignedCertificateInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryClusterWebSignedCertificate" + parameters + "{" + document + "}",
                OperationName = "QueryClusterWebSignedCertificate",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "ClusterWebSignedCertificateReply", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // clusterIpmi(input: GetIpmiInput!): ModifyIpmiReply!
        protected void InvokeQueryClusterIpmi()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetIpmiInput!"),
            };
            ModifyIpmiReply? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (ModifyIpmiReply)psObject.BaseObject;
                } else {
                    fields = (ModifyIpmiReply)this.Field;
                }
            }
            string document = Query.ClusterIpmi(ref fields);
            this._input.Initialize(argDefs, fields, "Query.ClusterIpmi");
            var parameters = "($input: GetIpmiInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryClusterIpmi" + parameters + "{" + document + "}",
                OperationName = "QueryClusterIpmi",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "ModifyIpmiReply", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // clusterCertificates(input: QueryCertificatesInput!): CertificateSummaryListResponse!
        protected void InvokeQueryClusterCertificates()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "QueryCertificatesInput!"),
            };
            CertificateSummaryListResponse? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (CertificateSummaryListResponse)psObject.BaseObject;
                } else {
                    fields = (CertificateSummaryListResponse)this.Field;
                }
            }
            string document = Query.ClusterCertificates(ref fields);
            this._input.Initialize(argDefs, fields, "Query.ClusterCertificates");
            var parameters = "($input: QueryCertificatesInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryClusterCertificates" + parameters + "{" + document + "}",
                OperationName = "QueryClusterCertificates",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "CertificateSummaryListResponse", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // allClusterWebCertsAndIpmis(input: BulkClusterWebCertAndIpmiInput!): [ClusterWebCertAndIpmi!]!
        protected void InvokeQueryAllClusterWebCertsAndIpmis()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "BulkClusterWebCertAndIpmiInput!"),
            };
            List<ClusterWebCertAndIpmi>? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (List<ClusterWebCertAndIpmi>)psObject.BaseObject;
                } else {
                    fields = (List<ClusterWebCertAndIpmi>)this.Field;
                }
            }
            string document = Query.AllClusterWebCertsAndIpmis(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AllClusterWebCertsAndIpmis");
            var parameters = "($input: BulkClusterWebCertAndIpmiInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAllClusterWebCertsAndIpmis" + parameters + "{" + document + "}",
                OperationName = "QueryAllClusterWebCertsAndIpmis",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "List<ClusterWebCertAndIpmi>", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // clusterOperationJobProgress(input: ClusterOperationJobProgressInput!): ClusterOperationJobProgress!
        protected void InvokeQueryClusterOperationJobProgress()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "ClusterOperationJobProgressInput!"),
            };
            ClusterOperationJobProgress? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (ClusterOperationJobProgress)psObject.BaseObject;
                } else {
                    fields = (ClusterOperationJobProgress)this.Field;
                }
            }
            string document = Query.ClusterOperationJobProgress(ref fields);
            this._input.Initialize(argDefs, fields, "Query.ClusterOperationJobProgress");
            var parameters = "($input: ClusterOperationJobProgressInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryClusterOperationJobProgress" + parameters + "{" + document + "}",
                OperationName = "QueryClusterOperationJobProgress",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "ClusterOperationJobProgress", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // clusterIpv6Mode(input: ClusterIpv6ModeInput!): ClusterIpv6ModeReply!
        protected void InvokeQueryClusterIpv6Mode()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "ClusterIpv6ModeInput!"),
            };
            ClusterIpv6ModeReply? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (ClusterIpv6ModeReply)psObject.BaseObject;
                } else {
                    fields = (ClusterIpv6ModeReply)this.Field;
                }
            }
            string document = Query.ClusterIpv6Mode(ref fields);
            this._input.Initialize(argDefs, fields, "Query.ClusterIpv6Mode");
            var parameters = "($input: ClusterIpv6ModeInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryClusterIpv6Mode" + parameters + "{" + document + "}",
                OperationName = "QueryClusterIpv6Mode",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "ClusterIpv6ModeReply", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // clusterCsr(input: GetClusterCsrInput!): ClusterCsr!
        protected void InvokeQueryClusterCsr()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetClusterCsrInput!"),
            };
            ClusterCsr? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (ClusterCsr)psObject.BaseObject;
                } else {
                    fields = (ClusterCsr)this.Field;
                }
            }
            string document = Query.ClusterCsr(ref fields);
            this._input.Initialize(argDefs, fields, "Query.ClusterCsr");
            var parameters = "($input: GetClusterCsrInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryClusterCsr" + parameters + "{" + document + "}",
                OperationName = "QueryClusterCsr",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "ClusterCsr", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // clusterTypeList: [GroupCount!]!
        protected void InvokeQueryClusterTypeList()
        {
            Tuple<string, string>[] argDefs = {
            };
            List<GroupCount>? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (List<GroupCount>)psObject.BaseObject;
                } else {
                    fields = (List<GroupCount>)this.Field;
                }
            }
            string document = Query.ClusterTypeList(ref fields);
            this._input.Initialize(argDefs, fields, "Query.ClusterTypeList");
            var parameters = "";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryClusterTypeList" + parameters + "{" + document + "}",
                OperationName = "QueryClusterTypeList",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            var result = this._rbkClient.Invoke(
                request, vars, "List<GroupCount>", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // clusterGroupByConnection(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     groupBy: ClusterGroupByEnum!
        //     filter: ClusterFilterInput
        //     timezoneOffset: Float = 0.0
        //   ): ClusterGroupByConnection!
        protected void InvokeQueryClusterGroupByConnection()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("groupBy", "ClusterGroupByEnum!"),
                Tuple.Create("filter", "ClusterFilterInput"),
                Tuple.Create("timezoneOffset", "Float"),
            };
            ClusterGroupByConnection? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (ClusterGroupByConnection)psObject.BaseObject;
                } else {
                    fields = (ClusterGroupByConnection)this.Field;
                }
            }
            string document = Query.ClusterGroupByConnection(ref fields);
            this._input.Initialize(argDefs, fields, "Query.ClusterGroupByConnection");
            var parameters = "($first: Int,$after: String,$last: Int,$before: String,$groupBy: ClusterGroupByEnum!,$filter: ClusterFilterInput,$timezoneOffset: Float)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryClusterGroupByConnection" + parameters + "{" + document + "}",
                OperationName = "QueryClusterGroupByConnection",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "ClusterGroupByConnection", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // clusterWithConfigProtectionInfo(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     configProtectionFilter: ConfigProtectionInfoFilterInput
        //     sortOrder: SortOrder = DESC
        //     sortBy: ConfigProtectionInfoSortBy = CLUSTER_NAME
        //   ): ClusterConnection!
        protected void InvokeQueryClusterWithConfigProtectionInfo()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("configProtectionFilter", "ConfigProtectionInfoFilterInput"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("sortBy", "ConfigProtectionInfoSortBy"),
            };
            ClusterConnection? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (ClusterConnection)psObject.BaseObject;
                } else {
                    fields = (ClusterConnection)this.Field;
                }
            }
            string document = Query.ClusterWithConfigProtectionInfo(ref fields);
            this._input.Initialize(argDefs, fields, "Query.ClusterWithConfigProtectionInfo");
            var parameters = "($first: Int,$after: String,$last: Int,$before: String,$configProtectionFilter: ConfigProtectionInfoFilterInput,$sortOrder: SortOrder,$sortBy: ConfigProtectionInfoSortBy)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryClusterWithConfigProtectionInfo" + parameters + "{" + document + "}",
                OperationName = "QueryClusterWithConfigProtectionInfo",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "ClusterConnection", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // clusterRcvLocations(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     sortOrder: SortOrder
        //     cdmClusterUUID: UUID!
        //   ): RcvLocationBasicInfoConnection!
        protected void InvokeQueryClusterRcvLocations()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("cdmClusterUUID", "UUID!"),
            };
            RcvLocationBasicInfoConnection? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (RcvLocationBasicInfoConnection)psObject.BaseObject;
                } else {
                    fields = (RcvLocationBasicInfoConnection)this.Field;
                }
            }
            string document = Query.ClusterRcvLocations(ref fields);
            this._input.Initialize(argDefs, fields, "Query.ClusterRcvLocations");
            var parameters = "($first: Int,$after: String,$last: Int,$before: String,$sortOrder: SortOrder,$cdmClusterUUID: UUID!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryClusterRcvLocations" + parameters + "{" + document + "}",
                OperationName = "QueryClusterRcvLocations",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "RcvLocationBasicInfoConnection", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // allConnectedClusters(clusterFilterArg: ClusterTypeEnum): [DataLocationSupportedCluster!]!
        protected void InvokeQueryAllConnectedClusters()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("clusterFilterArg", "ClusterTypeEnum"),
            };
            List<DataLocationSupportedCluster>? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (List<DataLocationSupportedCluster>)psObject.BaseObject;
                } else {
                    fields = (List<DataLocationSupportedCluster>)this.Field;
                }
            }
            string document = Query.AllConnectedClusters(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AllConnectedClusters");
            var parameters = "($clusterFilterArg: ClusterTypeEnum)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAllConnectedClusters" + parameters + "{" + document + "}",
                OperationName = "QueryAllConnectedClusters",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "List<DataLocationSupportedCluster>", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // allClusterReplicationTargets(clusterUuid: UUID!): [ClusterReplicationTarget!]!
        protected void InvokeQueryAllClusterReplicationTargets()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("clusterUuid", "UUID!"),
            };
            List<ClusterReplicationTarget>? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (List<ClusterReplicationTarget>)psObject.BaseObject;
                } else {
                    fields = (List<ClusterReplicationTarget>)this.Field;
                }
            }
            string document = Query.AllClusterReplicationTargets(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AllClusterReplicationTargets");
            var parameters = "($clusterUuid: UUID!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAllClusterReplicationTargets" + parameters + "{" + document + "}",
                OperationName = "QueryAllClusterReplicationTargets",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "List<ClusterReplicationTarget>", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // clusterEncryptionInfo(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     sortOrder: SortOrder
        //     clusterName: String
        //     encryptionStatusFilter: [ClusterEncryptionStatusFilter!]! = []
        //     keyProtection: [ClusterKeyProtection!]! = []
        //     clusters: [UUID!]! = []
        //     encryptionTypes: [ClusterEncryptionType!]! = []
        //   ): ClusterEncryptionInfoConnection!
        protected void InvokeQueryClusterEncryptionInfo()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("clusterName", "String"),
                Tuple.Create("encryptionStatusFilter", "[ClusterEncryptionStatusFilter!]!"),
                Tuple.Create("keyProtection", "[ClusterKeyProtection!]!"),
                Tuple.Create("clusters", "[UUID!]!"),
                Tuple.Create("encryptionTypes", "[ClusterEncryptionType!]!"),
            };
            ClusterEncryptionInfoConnection? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (ClusterEncryptionInfoConnection)psObject.BaseObject;
                } else {
                    fields = (ClusterEncryptionInfoConnection)this.Field;
                }
            }
            string document = Query.ClusterEncryptionInfo(ref fields);
            this._input.Initialize(argDefs, fields, "Query.ClusterEncryptionInfo");
            var parameters = "($first: Int,$after: String,$last: Int,$before: String,$sortOrder: SortOrder,$clusterName: String,$encryptionStatusFilter: [ClusterEncryptionStatusFilter!]!,$keyProtection: [ClusterKeyProtection!]!,$clusters: [UUID!]!,$encryptionTypes: [ClusterEncryptionType!]!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryClusterEncryptionInfo" + parameters + "{" + document + "}",
                OperationName = "QueryClusterEncryptionInfo",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "ClusterEncryptionInfoConnection", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // hostFailoverCluster(fid: UUID!): HostFailoverCluster!
        protected void InvokeQueryHostFailoverCluster()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            HostFailoverCluster? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (HostFailoverCluster)psObject.BaseObject;
                } else {
                    fields = (HostFailoverCluster)this.Field;
                }
            }
            string document = Query.HostFailoverCluster(ref fields);
            this._input.Initialize(argDefs, fields, "Query.HostFailoverCluster");
            var parameters = "($fid: UUID!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryHostFailoverCluster" + parameters + "{" + document + "}",
                OperationName = "QueryHostFailoverCluster",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "HostFailoverCluster", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // allGlobalFileSearchMultipleClusters(clusters: [UUID!]! = [], regex: String!): GlobalFileSearchReplyType!
        protected void InvokeQueryAllGlobalFileSearchMultipleClusters()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("clusters", "[UUID!]!"),
                Tuple.Create("regex", "String!"),
            };
            GlobalFileSearchReplyType? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (GlobalFileSearchReplyType)psObject.BaseObject;
                } else {
                    fields = (GlobalFileSearchReplyType)this.Field;
                }
            }
            string document = Query.AllGlobalFileSearchMultipleClusters(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AllGlobalFileSearchMultipleClusters");
            var parameters = "($clusters: [UUID!]!,$regex: String!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAllGlobalFileSearchMultipleClusters" + parameters + "{" + document + "}",
                OperationName = "QueryAllGlobalFileSearchMultipleClusters",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "GlobalFileSearchReplyType", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // k8sClusters(
        //     first: Int
        //     after: String
        //     sortBy: HierarchySortByField
        //     sortOrder: SortOrder
        //     filter: [Filter!]
        //   ): K8sClusterConnection!
        protected void InvokeQueryK8sClusters()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("sortBy", "HierarchySortByField"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("filter", "[Filter!]"),
            };
            K8sClusterConnection? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (K8sClusterConnection)psObject.BaseObject;
                } else {
                    fields = (K8sClusterConnection)this.Field;
                }
            }
            string document = Query.K8sClusters(ref fields);
            this._input.Initialize(argDefs, fields, "Query.K8sClusters");
            var parameters = "($first: Int,$after: String,$sortBy: HierarchySortByField,$sortOrder: SortOrder,$filter: [Filter!])\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryK8sClusters" + parameters + "{" + document + "}",
                OperationName = "QueryK8sClusters",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "K8sClusterConnection", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // windowsCluster(fid: UUID!): WindowsCluster!
        protected void InvokeQueryWindowsCluster()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            WindowsCluster? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (WindowsCluster)psObject.BaseObject;
                } else {
                    fields = (WindowsCluster)this.Field;
                }
            }
            string document = Query.WindowsCluster(ref fields);
            this._input.Initialize(argDefs, fields, "Query.WindowsCluster");
            var parameters = "($fid: UUID!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryWindowsCluster" + parameters + "{" + document + "}",
                OperationName = "QueryWindowsCluster",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "WindowsCluster", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // clusterSlaDomainConnection(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //   ): ClusterSlaDomainConnection!
        protected void InvokeQueryClusterSlaDomainConnection()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
            };
            ClusterSlaDomainConnection? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (ClusterSlaDomainConnection)psObject.BaseObject;
                } else {
                    fields = (ClusterSlaDomainConnection)this.Field;
                }
            }
            string document = Query.ClusterSlaDomainConnection(ref fields);
            this._input.Initialize(argDefs, fields, "Query.ClusterSlaDomainConnection");
            var parameters = "($first: Int,$after: String,$last: Int,$before: String)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryClusterSlaDomainConnection" + parameters + "{" + document + "}",
                OperationName = "QueryClusterSlaDomainConnection",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "ClusterSlaDomainConnection", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // clusterSlaDomainFilterConnection(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //   ): ClusterSlaDomainForFilterConnection!
        protected void InvokeQueryClusterSlaDomainFilterConnection()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
            };
            ClusterSlaDomainForFilterConnection? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (ClusterSlaDomainForFilterConnection)psObject.BaseObject;
                } else {
                    fields = (ClusterSlaDomainForFilterConnection)this.Field;
                }
            }
            string document = Query.ClusterSlaDomainFilterConnection(ref fields);
            this._input.Initialize(argDefs, fields, "Query.ClusterSlaDomainFilterConnection");
            var parameters = "($first: Int,$after: String,$last: Int,$before: String)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryClusterSlaDomainFilterConnection" + parameters + "{" + document + "}",
                OperationName = "QueryClusterSlaDomainFilterConnection",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "ClusterSlaDomainForFilterConnection", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // verifySLAWithReplicationToCluster(cdmClusterUUID: UUID!, includeArchived: Boolean!): VerifySLAWithReplicationToClusterResp!
        protected void InvokeQueryVerifySlaWithReplicationToCluster()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("cdmClusterUUID", "UUID!"),
                Tuple.Create("includeArchived", "Boolean!"),
            };
            VerifySlaWithReplicationToClusterResp? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (VerifySlaWithReplicationToClusterResp)psObject.BaseObject;
                } else {
                    fields = (VerifySlaWithReplicationToClusterResp)this.Field;
                }
            }
            string document = Query.VerifySlaWithReplicationToCluster(ref fields);
            this._input.Initialize(argDefs, fields, "Query.VerifySlaWithReplicationToCluster");
            var parameters = "($cdmClusterUUID: UUID!,$includeArchived: Boolean!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryVerifySlaWithReplicationToCluster" + parameters + "{" + document + "}",
                OperationName = "QueryVerifySlaWithReplicationToCluster",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "VerifySlaWithReplicationToClusterResp", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // allClusterGlobalSlas(cdmClusterUUID: UUID!): [SlaInfo!]!
        protected void InvokeQueryAllClusterGlobalSlas()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("cdmClusterUUID", "UUID!"),
            };
            List<SlaInfo>? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (List<SlaInfo>)psObject.BaseObject;
                } else {
                    fields = (List<SlaInfo>)this.Field;
                }
            }
            string document = Query.AllClusterGlobalSlas(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AllClusterGlobalSlas");
            var parameters = "($cdmClusterUUID: UUID!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAllClusterGlobalSlas" + parameters + "{" + document + "}",
                OperationName = "QueryAllClusterGlobalSlas",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "List<SlaInfo>", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // clusterRegistrationProductInfo: ClusterRegistrationProductInfoType!
        protected void InvokeQueryClusterRegistrationProductInfo()
        {
            Tuple<string, string>[] argDefs = {
            };
            ClusterRegistrationProductInfoType? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (ClusterRegistrationProductInfoType)psObject.BaseObject;
                } else {
                    fields = (ClusterRegistrationProductInfoType)this.Field;
                }
            }
            string document = Query.ClusterRegistrationProductInfo(ref fields);
            this._input.Initialize(argDefs, fields, "Query.ClusterRegistrationProductInfo");
            var parameters = "";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryClusterRegistrationProductInfo" + parameters + "{" + document + "}",
                OperationName = "QueryClusterRegistrationProductInfo",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            var result = this._rbkClient.Invoke(
                request, vars, "ClusterRegistrationProductInfoType", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // vcdClusters(input: QueryVcdClusterInput!): VcdClusterSummaryListResponse!
        protected void InvokeQueryVcdClusters()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "QueryVcdClusterInput!"),
            };
            VcdClusterSummaryListResponse? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (VcdClusterSummaryListResponse)psObject.BaseObject;
                } else {
                    fields = (VcdClusterSummaryListResponse)this.Field;
                }
            }
            string document = Query.VcdClusters(ref fields);
            this._input.Initialize(argDefs, fields, "Query.VcdClusters");
            var parameters = "($input: QueryVcdClusterInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryVcdClusters" + parameters + "{" + document + "}",
                OperationName = "QueryVcdClusters",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "VcdClusterSummaryListResponse", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // isTotpAckNecessaryForCluster(clusterUuid: UUID!): Boolean!
        protected void InvokeQueryIsTotpAckNecessaryForCluster()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("clusterUuid", "UUID!"),
            };
            System.Boolean? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (System.Boolean)psObject.BaseObject;
                } else {
                    fields = (System.Boolean)this.Field;
                }
            }
            string document = Query.IsTotpAckNecessaryForCluster(ref fields);
            this._input.Initialize(argDefs, fields, "Query.IsTotpAckNecessaryForCluster");
            var parameters = "($clusterUuid: UUID!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryIsTotpAckNecessaryForCluster" + parameters + "{" + document + "}",
                OperationName = "QueryIsTotpAckNecessaryForCluster",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "System.Boolean", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // allClustersTotpAckStatus(listClusterUuid: [UUID!]!): [Boolean!]!
        protected void InvokeQueryAllClustersTotpAckStatus()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("listClusterUuid", "[UUID!]!"),
            };
            List<System.Boolean>? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (List<System.Boolean>)psObject.BaseObject;
                } else {
                    fields = (List<System.Boolean>)this.Field;
                }
            }
            string document = Query.AllClustersTotpAckStatus(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AllClustersTotpAckStatus");
            var parameters = "($listClusterUuid: [UUID!]!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAllClustersTotpAckStatus" + parameters + "{" + document + "}",
                OperationName = "QueryAllClustersTotpAckStatus",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "List<System.Boolean>", this._logger, GetMetricTags());
            WriteObject(result, true);
        }


    } // class Invoke_RscQueryCluster
}