// Invoke-RscQueryCluster.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections;
using System.Collections.Generic;
using System.Management.Automation;
using System.Text;
using System.Threading.Tasks;
using GraphQL;
using RubrikSecurityCloud;
using RubrikSecurityCloud.Types;
using RubrikSecurityCloud.NetSDK.Client;
using RubrikSecurityCloud.PowerShell.Private;

namespace RubrikSecurityCloud.PowerShell.Cmdlets
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
        // [GraphQL: allCloudClusters]
        //
        [Parameter(
            ParameterSetName = "Cloud",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"List of Cloud Clusters with cloud information.
[GraphQL: allCloudClusters]",
            Position = 0
        )]
        public SwitchParameter Cloud { get; set; }

        
        // -------------------------------------------------------------------
        // Nodes parameter set
        //
        // [GraphQL: clusterNodes]
        //
        [Parameter(
            ParameterSetName = "Nodes",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Get list of nodes in this Rubrik cluster

Supported in v5.0+
Returns the list of all Rubrik nodes.
[GraphQL: clusterNodes]",
            Position = 0
        )]
        public SwitchParameter Nodes { get; set; }

        
        // -------------------------------------------------------------------
        // List parameter set
        //
        // [GraphQL: clusterConnection]
        //
        [Parameter(
            ParameterSetName = "List",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"List of the available cluster objects.
[GraphQL: clusterConnection]",
            Position = 0
        )]
        public SwitchParameter List { get; set; }

        
        // -------------------------------------------------------------------
        // Cluster parameter set
        //
        // [GraphQL: cluster]
        //
        [Parameter(
            ParameterSetName = "Cluster",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"A cluster object.
[GraphQL: cluster]",
            Position = 0
        )]
        public SwitchParameter Cluster { get; set; }

        
        // -------------------------------------------------------------------
        // WithUpgradesInfo parameter set
        //
        // [GraphQL: clusterWithUpgradesInfo]
        //
        [Parameter(
            ParameterSetName = "WithUpgradesInfo",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"
[GraphQL: clusterWithUpgradesInfo]",
            Position = 0
        )]
        public SwitchParameter WithUpgradesInfo { get; set; }

        
        // -------------------------------------------------------------------
        // Dns parameter set
        //
        // [GraphQL: clusterDns]
        //
        [Parameter(
            ParameterSetName = "Dns",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Rubrik cluster DNS information.
[GraphQL: clusterDns]",
            Position = 0
        )]
        public SwitchParameter Dns { get; set; }

        
        // -------------------------------------------------------------------
        // Proxy parameter set
        //
        // [GraphQL: clusterProxy]
        //
        [Parameter(
            ParameterSetName = "Proxy",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Rubrik cluster proxy information.
[GraphQL: clusterProxy]",
            Position = 0
        )]
        public SwitchParameter Proxy { get; set; }

        
        // -------------------------------------------------------------------
        // NtpServers parameter set
        //
        // [GraphQL: clusterNtpServers]
        //
        [Parameter(
            ParameterSetName = "NtpServers",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Get NTP Servers

Supported in v5.0+
Retrieve a list of the NTP servers assigned to the Rubrik cluster. Encryption keys are not reported.
[GraphQL: clusterNtpServers]",
            Position = 0
        )]
        public SwitchParameter NtpServers { get; set; }

        
        // -------------------------------------------------------------------
        // NetworkInterfaces parameter set
        //
        // [GraphQL: clusterNetworkInterfaces]
        //
        [Parameter(
            ParameterSetName = "NetworkInterfaces",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Get network interfaces for a Rubrik Cluster cluster

Supported in v5.0+
Retrieves network interfaces(including VLANs) on bond0/bond1.
[GraphQL: clusterNetworkInterfaces]",
            Position = 0
        )]
        public SwitchParameter NetworkInterfaces { get; set; }

        
        // -------------------------------------------------------------------
        // FloatingIps parameter set
        //
        // [GraphQL: clusterFloatingIps]
        //
        [Parameter(
            ParameterSetName = "FloatingIps",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Get a list of a cluster's always-available Ips

Supported in v5.0+
Get a list of a cluster's always-available Ips.
[GraphQL: clusterFloatingIps]",
            Position = 0
        )]
        public SwitchParameter FloatingIps { get; set; }

        
        // -------------------------------------------------------------------
        // Vlans parameter set
        //
        // [GraphQL: clusterVlans]
        //
        [Parameter(
            ParameterSetName = "Vlans",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Rubrik cluster VLAN information.
[GraphQL: clusterVlans]",
            Position = 0
        )]
        public SwitchParameter Vlans { get; set; }

        
        // -------------------------------------------------------------------
        // DefaultGateway parameter set
        //
        // [GraphQL: clusterDefaultGateway]
        //
        [Parameter(
            ParameterSetName = "DefaultGateway",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Get current default gateway

Supported in v5.0+
Get current default gateway.
[GraphQL: clusterDefaultGateway]",
            Position = 0
        )]
        public SwitchParameter DefaultGateway { get; set; }

        
        // -------------------------------------------------------------------
        // WebSignedCertificate parameter set
        //
        // [GraphQL: clusterWebSignedCertificate]
        //
        [Parameter(
            ParameterSetName = "WebSignedCertificate",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Get the signed certificate for Web server

Supported in v5.2+
If the web server uses a signed certificate, fetch it.
[GraphQL: clusterWebSignedCertificate]",
            Position = 0
        )]
        public SwitchParameter WebSignedCertificate { get; set; }

        
        // -------------------------------------------------------------------
        // Ipmi parameter set
        //
        // [GraphQL: clusterIpmi]
        //
        [Parameter(
            ParameterSetName = "Ipmi",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Get IPMI details

Supported in v5.0+
get IPMI details of availability and enabled access in the cluster.
[GraphQL: clusterIpmi]",
            Position = 0
        )]
        public SwitchParameter Ipmi { get; set; }

        
        // -------------------------------------------------------------------
        // Certificates parameter set
        //
        // [GraphQL: clusterCertificates]
        //
        [Parameter(
            ParameterSetName = "Certificates",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Get all certificates

Supported in v5.1+
Get all certificates.
[GraphQL: clusterCertificates]",
            Position = 0
        )]
        public SwitchParameter Certificates { get; set; }

        
        // -------------------------------------------------------------------
        // WebCertsAndIpmis parameter set
        //
        // [GraphQL: allClusterWebCertsAndIpmis]
        //
        [Parameter(
            ParameterSetName = "WebCertsAndIpmis",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Get web server certificate and IPMI details for multiple clusters.
[GraphQL: allClusterWebCertsAndIpmis]",
            Position = 0
        )]
        public SwitchParameter WebCertsAndIpmis { get; set; }

        
        // -------------------------------------------------------------------
        // OperationJobProgress parameter set
        //
        // [GraphQL: clusterOperationJobProgress]
        //
        [Parameter(
            ParameterSetName = "OperationJobProgress",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Get updates on the job progress of the Rubrik cluster operation.
[GraphQL: clusterOperationJobProgress]",
            Position = 0
        )]
        public SwitchParameter OperationJobProgress { get; set; }

        
        // -------------------------------------------------------------------
        // Ipv6Mode parameter set
        //
        // [GraphQL: clusterIpv6Mode]
        //
        [Parameter(
            ParameterSetName = "Ipv6Mode",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Rubrik cluster IPv6 mode.
[GraphQL: clusterIpv6Mode]",
            Position = 0
        )]
        public SwitchParameter Ipv6Mode { get; set; }

        
        // -------------------------------------------------------------------
        // Csr parameter set
        //
        // [GraphQL: clusterCsr]
        //
        [Parameter(
            ParameterSetName = "Csr",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Get the cluster certificate signing request

Supported in v7.0+
Returns the certificate signing request generated from the private key of the Rubrik cluster.
[GraphQL: clusterCsr]",
            Position = 0
        )]
        public SwitchParameter Csr { get; set; }

        
        // -------------------------------------------------------------------
        // TypeList parameter set
        //
        // [GraphQL: clusterTypeList]
        //
        [Parameter(
            ParameterSetName = "TypeList",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"
[GraphQL: clusterTypeList]",
            Position = 0
        )]
        public SwitchParameter TypeList { get; set; }

        
        // -------------------------------------------------------------------
        // GroupByList parameter set
        //
        // [GraphQL: clusterGroupByConnection]
        //
        [Parameter(
            ParameterSetName = "GroupByList",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"
[GraphQL: clusterGroupByConnection]",
            Position = 0
        )]
        public SwitchParameter GroupByList { get; set; }

        
        // -------------------------------------------------------------------
        // WithConfigProtectionInfo parameter set
        //
        // [GraphQL: clusterWithConfigProtectionInfo]
        //
        [Parameter(
            ParameterSetName = "WithConfigProtectionInfo",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"A cluster object with config protection information.
[GraphQL: clusterWithConfigProtectionInfo]",
            Position = 0
        )]
        public SwitchParameter WithConfigProtectionInfo { get; set; }

        
        // -------------------------------------------------------------------
        // RcvLocations parameter set
        //
        // [GraphQL: clusterRcvLocations]
        //
        [Parameter(
            ParameterSetName = "RcvLocations",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"List Rubrik Cloud Vault locations of the cluster.
[GraphQL: clusterRcvLocations]",
            Position = 0
        )]
        public SwitchParameter RcvLocations { get; set; }

        
        // -------------------------------------------------------------------
        // Connected parameter set
        //
        // [GraphQL: allConnectedClusters]
        //
        [Parameter(
            ParameterSetName = "Connected",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"List all connected clusters.
[GraphQL: allConnectedClusters]",
            Position = 0
        )]
        public SwitchParameter Connected { get; set; }

        
        // -------------------------------------------------------------------
        // ReplicationTargets parameter set
        //
        // [GraphQL: allClusterReplicationTargets]
        //
        [Parameter(
            ParameterSetName = "ReplicationTargets",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"All replication targets for a cluster.
[GraphQL: allClusterReplicationTargets]",
            Position = 0
        )]
        public SwitchParameter ReplicationTargets { get; set; }

        
        // -------------------------------------------------------------------
        // EncryptionInfo parameter set
        //
        // [GraphQL: clusterEncryptionInfo]
        //
        [Parameter(
            ParameterSetName = "EncryptionInfo",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Filter clusters by encryption information.
[GraphQL: clusterEncryptionInfo]",
            Position = 0
        )]
        public SwitchParameter EncryptionInfo { get; set; }

        
        // -------------------------------------------------------------------
        // HostFailover parameter set
        //
        // [GraphQL: hostFailoverCluster]
        //
        [Parameter(
            ParameterSetName = "HostFailover",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Get details of the given host failover cluster.
[GraphQL: hostFailoverCluster]",
            Position = 0
        )]
        public SwitchParameter HostFailover { get; set; }

        
        // -------------------------------------------------------------------
        // GlobalFileSearchMultiple parameter set
        //
        // [GraphQL: allGlobalFileSearchMultipleClusters]
        //
        [Parameter(
            ParameterSetName = "GlobalFileSearchMultiple",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"All files and folders matching input filters.
[GraphQL: allGlobalFileSearchMultipleClusters]",
            Position = 0
        )]
        public SwitchParameter GlobalFileSearchMultiple { get; set; }

        
        // -------------------------------------------------------------------
        // Kubernetes parameter set
        //
        // [GraphQL: kubernetesClusters]
        //
        [Parameter(
            ParameterSetName = "Kubernetes",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Summary of all Kubernetes Clusters.
[GraphQL: kubernetesClusters]",
            Position = 0
        )]
        public SwitchParameter Kubernetes { get; set; }

        
        // -------------------------------------------------------------------
        // K8s parameter set
        //
        // [GraphQL: k8sClusters]
        //
        [Parameter(
            ParameterSetName = "K8s",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"
[GraphQL: k8sClusters]",
            Position = 0
        )]
        public SwitchParameter K8s { get; set; }

        
        // -------------------------------------------------------------------
        // Windows parameter set
        //
        // [GraphQL: windowsCluster]
        //
        [Parameter(
            ParameterSetName = "Windows",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"A Windows Cluster.
[GraphQL: windowsCluster]",
            Position = 0
        )]
        public SwitchParameter Windows { get; set; }

        
        // -------------------------------------------------------------------
        // ReportMigrationStatus parameter set
        //
        // [GraphQL: clusterReportMigrationStatus]
        //
        [Parameter(
            ParameterSetName = "ReportMigrationStatus",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Retrieve details of the Rubrik clusters' reports migration.
[GraphQL: clusterReportMigrationStatus]",
            Position = 0
        )]
        public SwitchParameter ReportMigrationStatus { get; set; }

        
        // -------------------------------------------------------------------
        // ReportMigrationCount parameter set
        //
        // [GraphQL: clusterReportMigrationCount]
        //
        [Parameter(
            ParameterSetName = "ReportMigrationCount",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Retrieve the counts of the Rubrik cluster reports migration.
[GraphQL: clusterReportMigrationCount]",
            Position = 0
        )]
        public SwitchParameter ReportMigrationCount { get; set; }

        
        // -------------------------------------------------------------------
        // ReportMigrationJobStatus parameter set
        //
        // [GraphQL: clusterReportMigrationJobStatus]
        //
        [Parameter(
            ParameterSetName = "ReportMigrationJobStatus",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Retrieve the status of the cluster report migration job.
[GraphQL: clusterReportMigrationJobStatus]",
            Position = 0
        )]
        public SwitchParameter ReportMigrationJobStatus { get; set; }

        
        // -------------------------------------------------------------------
        // LaDomains parameter set
        //
        // [GraphQL: clusterSlaDomains]
        //
        [Parameter(
            ParameterSetName = "LaDomains",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Returns paginated list of SLA domains that were created on Rubrik CDM.
[GraphQL: clusterSlaDomains]",
            Position = 0
        )]
        public SwitchParameter LaDomains { get; set; }

        
        // -------------------------------------------------------------------
        // LaDomainFilterList parameter set
        //
        // [GraphQL: clusterSlaDomainFilterConnection]
        //
        [Parameter(
            ParameterSetName = "LaDomainFilterList",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"
[GraphQL: clusterSlaDomainFilterConnection]",
            Position = 0
        )]
        public SwitchParameter LaDomainFilterList { get; set; }

        
        // -------------------------------------------------------------------
        // VerifySlaWithReplicationTo parameter set
        //
        // [GraphQL: verifySlaWithReplicationToCluster]
        //
        [Parameter(
            ParameterSetName = "VerifySlaWithReplicationTo",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Verify for a Rubrik cluster if it is replication target in any SLA Domain.
[GraphQL: verifySlaWithReplicationToCluster]",
            Position = 0
        )]
        public SwitchParameter VerifySlaWithReplicationTo { get; set; }

        
        // -------------------------------------------------------------------
        // GlobalSlas parameter set
        //
        // [GraphQL: allClusterGlobalSlas]
        //
        [Parameter(
            ParameterSetName = "GlobalSlas",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Global SLA Domains protecting at least one object on the specified Rubrik cluster.
[GraphQL: allClusterGlobalSlas]",
            Position = 0
        )]
        public SwitchParameter GlobalSlas { get; set; }

        
        // -------------------------------------------------------------------
        // RegistrationProductInfo parameter set
        //
        // [GraphQL: clusterRegistrationProductInfo]
        //
        [Parameter(
            ParameterSetName = "RegistrationProductInfo",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Info about the cluster product types the user is entitled to.
[GraphQL: clusterRegistrationProductInfo]",
            Position = 0
        )]
        public SwitchParameter RegistrationProductInfo { get; set; }

        
        // -------------------------------------------------------------------
        // Vcd parameter set
        //
        // [GraphQL: vcdClusters]
        //
        [Parameter(
            ParameterSetName = "Vcd",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"List of vCloud Director clusters.
[GraphQL: vcdClusters]",
            Position = 0
        )]
        public SwitchParameter Vcd { get; set; }

        
        // -------------------------------------------------------------------
        // IsTotpAckNecessary parameter set
        //
        // [GraphQL: isTotpAckNecessaryForCluster]
        //
        [Parameter(
            ParameterSetName = "IsTotpAckNecessary",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Checks whether acknowledgement of the Time-based, One-Time Password (TOTP) mandate is required for upgrading the Rubrik cluster version.
[GraphQL: isTotpAckNecessaryForCluster]",
            Position = 0
        )]
        public SwitchParameter IsTotpAckNecessary { get; set; }

        
        // -------------------------------------------------------------------
        // TotpAckStatus parameter set
        //
        // [GraphQL: allClustersTotpAckStatus]
        //
        [Parameter(
            ParameterSetName = "TotpAckStatus",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Checks whether acknowledgement of the Time-based, One-Time Password (TOTP) mandate is required for upgrading the Rubrik cluster version.
[GraphQL: allClustersTotpAckStatus]",
            Position = 0
        )]
        public SwitchParameter TotpAckStatus { get; set; }


        protected override void ProcessRecord()
        {
            try
            {
                switch(Op)
                {
                    case "Cloud":
                        this.ProcessRecord_Cloud();
                        break;
                    case "Nodes":
                        this.ProcessRecord_Nodes();
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
                    case "NtpServers":
                        this.ProcessRecord_NtpServers();
                        break;
                    case "NetworkInterfaces":
                        this.ProcessRecord_NetworkInterfaces();
                        break;
                    case "FloatingIps":
                        this.ProcessRecord_FloatingIps();
                        break;
                    case "Vlans":
                        this.ProcessRecord_Vlans();
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
                    case "Certificates":
                        this.ProcessRecord_Certificates();
                        break;
                    case "WebCertsAndIpmis":
                        this.ProcessRecord_WebCertsAndIpmis();
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
                    case "RcvLocations":
                        this.ProcessRecord_RcvLocations();
                        break;
                    case "Connected":
                        this.ProcessRecord_Connected();
                        break;
                    case "ReplicationTargets":
                        this.ProcessRecord_ReplicationTargets();
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
                    case "Kubernetes":
                        this.ProcessRecord_Kubernetes();
                        break;
                    case "K8s":
                        this.ProcessRecord_K8s();
                        break;
                    case "Windows":
                        this.ProcessRecord_Windows();
                        break;
                    case "ReportMigrationStatus":
                        this.ProcessRecord_ReportMigrationStatus();
                        break;
                    case "ReportMigrationCount":
                        this.ProcessRecord_ReportMigrationCount();
                        break;
                    case "ReportMigrationJobStatus":
                        this.ProcessRecord_ReportMigrationJobStatus();
                        break;
                    case "LaDomains":
                        this.ProcessRecord_LaDomains();
                        break;
                    case "LaDomainFilterList":
                        this.ProcessRecord_LaDomainFilterList();
                        break;
                    case "VerifySlaWithReplicationTo":
                        this.ProcessRecord_VerifySlaWithReplicationTo();
                        break;
                    case "GlobalSlas":
                        this.ProcessRecord_GlobalSlas();
                        break;
                    case "RegistrationProductInfo":
                        this.ProcessRecord_RegistrationProductInfo();
                        break;
                    case "Vcd":
                        this.ProcessRecord_Vcd();
                        break;
                    case "IsTotpAckNecessary":
                        this.ProcessRecord_IsTotpAckNecessary();
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
                ThrowTerminatingException(ex);
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
        protected void ProcessRecord_Nodes()
        {
            this._logger.name += " -Nodes";
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
        protected void ProcessRecord_NtpServers()
        {
            this._logger.name += " -NtpServers";
            // Invoke graphql operation clusterNtpServers
            InvokeQueryClusterNtpServers();
        }

        // This parameter set invokes a single graphql operation:
        // clusterNetworkInterfaces.
        protected void ProcessRecord_NetworkInterfaces()
        {
            this._logger.name += " -NetworkInterfaces";
            // Invoke graphql operation clusterNetworkInterfaces
            InvokeQueryClusterNetworkInterfaces();
        }

        // This parameter set invokes a single graphql operation:
        // clusterFloatingIps.
        protected void ProcessRecord_FloatingIps()
        {
            this._logger.name += " -FloatingIps";
            // Invoke graphql operation clusterFloatingIps
            InvokeQueryClusterFloatingIps();
        }

        // This parameter set invokes a single graphql operation:
        // clusterVlans.
        protected void ProcessRecord_Vlans()
        {
            this._logger.name += " -Vlans";
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
        protected void ProcessRecord_Certificates()
        {
            this._logger.name += " -Certificates";
            // Invoke graphql operation clusterCertificates
            InvokeQueryClusterCertificates();
        }

        // This parameter set invokes a single graphql operation:
        // allClusterWebCertsAndIpmis.
        protected void ProcessRecord_WebCertsAndIpmis()
        {
            this._logger.name += " -WebCertsAndIpmis";
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
        protected void ProcessRecord_RcvLocations()
        {
            this._logger.name += " -RcvLocations";
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
        protected void ProcessRecord_ReplicationTargets()
        {
            this._logger.name += " -ReplicationTargets";
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
        // kubernetesClusters.
        protected void ProcessRecord_Kubernetes()
        {
            this._logger.name += " -Kubernetes";
            // Invoke graphql operation kubernetesClusters
            InvokeQueryKubernetesClusters();
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
        protected void ProcessRecord_Windows()
        {
            this._logger.name += " -Windows";
            // Invoke graphql operation windowsCluster
            InvokeQueryWindowsCluster();
        }

        // This parameter set invokes a single graphql operation:
        // clusterReportMigrationStatus.
        protected void ProcessRecord_ReportMigrationStatus()
        {
            this._logger.name += " -ReportMigrationStatus";
            // Invoke graphql operation clusterReportMigrationStatus
            InvokeQueryClusterReportMigrationStatus();
        }

        // This parameter set invokes a single graphql operation:
        // clusterReportMigrationCount.
        protected void ProcessRecord_ReportMigrationCount()
        {
            this._logger.name += " -ReportMigrationCount";
            // Invoke graphql operation clusterReportMigrationCount
            InvokeQueryClusterReportMigrationCount();
        }

        // This parameter set invokes a single graphql operation:
        // clusterReportMigrationJobStatus.
        protected void ProcessRecord_ReportMigrationJobStatus()
        {
            this._logger.name += " -ReportMigrationJobStatus";
            // Invoke graphql operation clusterReportMigrationJobStatus
            InvokeQueryClusterReportMigrationJobStatus();
        }

        // This parameter set invokes a single graphql operation:
        // clusterSlaDomains.
        protected void ProcessRecord_LaDomains()
        {
            this._logger.name += " -LaDomains";
            // Invoke graphql operation clusterSlaDomains
            InvokeQueryClusterSlaDomains();
        }

        // This parameter set invokes a single graphql operation:
        // clusterSlaDomainFilterConnection.
        protected void ProcessRecord_LaDomainFilterList()
        {
            this._logger.name += " -LaDomainFilterList";
            // Invoke graphql operation clusterSlaDomainFilterConnection
            InvokeQueryClusterSlaDomainFilterConnection();
        }

        // This parameter set invokes a single graphql operation:
        // verifySlaWithReplicationToCluster.
        protected void ProcessRecord_VerifySlaWithReplicationTo()
        {
            this._logger.name += " -VerifySlaWithReplicationTo";
            // Invoke graphql operation verifySlaWithReplicationToCluster
            InvokeQueryVerifySlaWithReplicationToCluster();
        }

        // This parameter set invokes a single graphql operation:
        // allClusterGlobalSlas.
        protected void ProcessRecord_GlobalSlas()
        {
            this._logger.name += " -GlobalSlas";
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
        protected void ProcessRecord_IsTotpAckNecessary()
        {
            this._logger.name += " -IsTotpAckNecessary";
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
            List<CcWithCloudInfo>? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (List<CcWithCloudInfo>)psObject.BaseObject;
                } else {
                    fieldSpecObj = (List<CcWithCloudInfo>)this.Field;
                }
            }
            string fieldSpecDoc = Query.AllCloudClusters(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryAllCloudClusters",
                "($cloudVendorType: CcpVendorType!)",
                fieldSpecDoc,
                "List<CcWithCloudInfo>"
            );
        }

        // Invoke GraphQL Query:
        // clusterNodes(input: GetNodesInput!): NodeStatusListResponse!
        protected void InvokeQueryClusterNodes()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetNodesInput!"),
            };
            NodeStatusListResponse? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (NodeStatusListResponse)psObject.BaseObject;
                } else {
                    fieldSpecObj = (NodeStatusListResponse)this.Field;
                }
            }
            string fieldSpecDoc = Query.ClusterNodes(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryClusterNodes",
                "($input: GetNodesInput!)",
                fieldSpecDoc,
                "NodeStatusListResponse"
            );
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
            ClusterConnection? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (ClusterConnection)psObject.BaseObject;
                } else {
                    fieldSpecObj = (ClusterConnection)this.Field;
                }
            }
            string fieldSpecDoc = Query.ClusterConnection(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryClusterConnection",
                "($first: Int,$after: String,$last: Int,$before: String,$filter: ClusterFilterInput,$sortOrder: SortOrder,$sortBy: ClusterSortByEnum)",
                fieldSpecDoc,
                "ClusterConnection"
            );
        }

        // Invoke GraphQL Query:
        // cluster(clusterUuid: UUID!): Cluster!
        protected void InvokeQueryCluster()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("clusterUuid", "UUID!"),
            };
            Cluster? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (Cluster)psObject.BaseObject;
                } else {
                    fieldSpecObj = (Cluster)this.Field;
                }
            }
            string fieldSpecDoc = Query.Cluster(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryCluster",
                "($clusterUuid: UUID!)",
                fieldSpecDoc,
                "Cluster"
            );
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
            ClusterConnection? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (ClusterConnection)psObject.BaseObject;
                } else {
                    fieldSpecObj = (ClusterConnection)this.Field;
                }
            }
            string fieldSpecDoc = Query.ClusterWithUpgradesInfo(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryClusterWithUpgradesInfo",
                "($first: Int,$after: String,$last: Int,$before: String,$upgradeFilter: CdmUpgradeInfoFilterInput,$sortOrder: SortOrder,$sortBy: UpgradeInfoSortByEnum)",
                fieldSpecDoc,
                "ClusterConnection"
            );
        }

        // Invoke GraphQL Query:
        // clusterDns(clusterUuid: UUID!): ClusterDnsReply!
        protected void InvokeQueryClusterDns()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("clusterUuid", "UUID!"),
            };
            ClusterDnsReply? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (ClusterDnsReply)psObject.BaseObject;
                } else {
                    fieldSpecObj = (ClusterDnsReply)this.Field;
                }
            }
            string fieldSpecDoc = Query.ClusterDns(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryClusterDns",
                "($clusterUuid: UUID!)",
                fieldSpecDoc,
                "ClusterDnsReply"
            );
        }

        // Invoke GraphQL Query:
        // clusterProxy(clusterUuid: UUID!): ClusterProxyReply!
        protected void InvokeQueryClusterProxy()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("clusterUuid", "UUID!"),
            };
            ClusterProxyReply? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (ClusterProxyReply)psObject.BaseObject;
                } else {
                    fieldSpecObj = (ClusterProxyReply)this.Field;
                }
            }
            string fieldSpecDoc = Query.ClusterProxy(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryClusterProxy",
                "($clusterUuid: UUID!)",
                fieldSpecDoc,
                "ClusterProxyReply"
            );
        }

        // Invoke GraphQL Query:
        // clusterNtpServers(input: GetClusterNtpServersInput!): NtpServerConfigurationListResponse!
        protected void InvokeQueryClusterNtpServers()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetClusterNtpServersInput!"),
            };
            NtpServerConfigurationListResponse? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (NtpServerConfigurationListResponse)psObject.BaseObject;
                } else {
                    fieldSpecObj = (NtpServerConfigurationListResponse)this.Field;
                }
            }
            string fieldSpecDoc = Query.ClusterNtpServers(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryClusterNtpServers",
                "($input: GetClusterNtpServersInput!)",
                fieldSpecDoc,
                "NtpServerConfigurationListResponse"
            );
        }

        // Invoke GraphQL Query:
        // clusterNetworkInterfaces(input: GetNetworkInterfaceInput!): NetworkInterfaceListResponse!
        protected void InvokeQueryClusterNetworkInterfaces()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetNetworkInterfaceInput!"),
            };
            NetworkInterfaceListResponse? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (NetworkInterfaceListResponse)psObject.BaseObject;
                } else {
                    fieldSpecObj = (NetworkInterfaceListResponse)this.Field;
                }
            }
            string fieldSpecDoc = Query.ClusterNetworkInterfaces(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryClusterNetworkInterfaces",
                "($input: GetNetworkInterfaceInput!)",
                fieldSpecDoc,
                "NetworkInterfaceListResponse"
            );
        }

        // Invoke GraphQL Query:
        // clusterFloatingIps(input: GetClusterIpsInput!): InternalGetClusterIpsResponse!
        protected void InvokeQueryClusterFloatingIps()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetClusterIpsInput!"),
            };
            InternalGetClusterIpsResponse? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (InternalGetClusterIpsResponse)psObject.BaseObject;
                } else {
                    fieldSpecObj = (InternalGetClusterIpsResponse)this.Field;
                }
            }
            string fieldSpecDoc = Query.ClusterFloatingIps(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryClusterFloatingIps",
                "($input: GetClusterIpsInput!)",
                fieldSpecDoc,
                "InternalGetClusterIpsResponse"
            );
        }

        // Invoke GraphQL Query:
        // clusterVlans(input: GetVlanInput!): VlanConfigListResponse!
        protected void InvokeQueryClusterVlans()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetVlanInput!"),
            };
            VlanConfigListResponse? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (VlanConfigListResponse)psObject.BaseObject;
                } else {
                    fieldSpecObj = (VlanConfigListResponse)this.Field;
                }
            }
            string fieldSpecDoc = Query.ClusterVlans(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryClusterVlans",
                "($input: GetVlanInput!)",
                fieldSpecDoc,
                "VlanConfigListResponse"
            );
        }

        // Invoke GraphQL Query:
        // clusterDefaultGateway(input: GetDefaultGatewayInput!): InternalGetDefaultGatewayResponse!
        protected void InvokeQueryClusterDefaultGateway()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetDefaultGatewayInput!"),
            };
            InternalGetDefaultGatewayResponse? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (InternalGetDefaultGatewayResponse)psObject.BaseObject;
                } else {
                    fieldSpecObj = (InternalGetDefaultGatewayResponse)this.Field;
                }
            }
            string fieldSpecDoc = Query.ClusterDefaultGateway(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryClusterDefaultGateway",
                "($input: GetDefaultGatewayInput!)",
                fieldSpecDoc,
                "InternalGetDefaultGatewayResponse"
            );
        }

        // Invoke GraphQL Query:
        // clusterWebSignedCertificate(input: ClusterWebSignedCertificateInput!): ClusterWebSignedCertificateReply!
        protected void InvokeQueryClusterWebSignedCertificate()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "ClusterWebSignedCertificateInput!"),
            };
            ClusterWebSignedCertificateReply? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (ClusterWebSignedCertificateReply)psObject.BaseObject;
                } else {
                    fieldSpecObj = (ClusterWebSignedCertificateReply)this.Field;
                }
            }
            string fieldSpecDoc = Query.ClusterWebSignedCertificate(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryClusterWebSignedCertificate",
                "($input: ClusterWebSignedCertificateInput!)",
                fieldSpecDoc,
                "ClusterWebSignedCertificateReply"
            );
        }

        // Invoke GraphQL Query:
        // clusterIpmi(input: GetIpmiInput!): ModifyIpmiReply!
        protected void InvokeQueryClusterIpmi()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetIpmiInput!"),
            };
            ModifyIpmiReply? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (ModifyIpmiReply)psObject.BaseObject;
                } else {
                    fieldSpecObj = (ModifyIpmiReply)this.Field;
                }
            }
            string fieldSpecDoc = Query.ClusterIpmi(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryClusterIpmi",
                "($input: GetIpmiInput!)",
                fieldSpecDoc,
                "ModifyIpmiReply"
            );
        }

        // Invoke GraphQL Query:
        // clusterCertificates(input: QueryCertificatesInput!): CertificateSummaryListResponse!
        protected void InvokeQueryClusterCertificates()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "QueryCertificatesInput!"),
            };
            CertificateSummaryListResponse? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (CertificateSummaryListResponse)psObject.BaseObject;
                } else {
                    fieldSpecObj = (CertificateSummaryListResponse)this.Field;
                }
            }
            string fieldSpecDoc = Query.ClusterCertificates(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryClusterCertificates",
                "($input: QueryCertificatesInput!)",
                fieldSpecDoc,
                "CertificateSummaryListResponse"
            );
        }

        // Invoke GraphQL Query:
        // allClusterWebCertsAndIpmis(input: BulkClusterWebCertAndIpmiInput!): [ClusterWebCertAndIpmi!]!
        protected void InvokeQueryAllClusterWebCertsAndIpmis()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "BulkClusterWebCertAndIpmiInput!"),
            };
            List<ClusterWebCertAndIpmi>? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (List<ClusterWebCertAndIpmi>)psObject.BaseObject;
                } else {
                    fieldSpecObj = (List<ClusterWebCertAndIpmi>)this.Field;
                }
            }
            string fieldSpecDoc = Query.AllClusterWebCertsAndIpmis(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryAllClusterWebCertsAndIpmis",
                "($input: BulkClusterWebCertAndIpmiInput!)",
                fieldSpecDoc,
                "List<ClusterWebCertAndIpmi>"
            );
        }

        // Invoke GraphQL Query:
        // clusterOperationJobProgress(input: ClusterOperationJobProgressInput!): ClusterOperationJobProgress!
        protected void InvokeQueryClusterOperationJobProgress()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "ClusterOperationJobProgressInput!"),
            };
            ClusterOperationJobProgress? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (ClusterOperationJobProgress)psObject.BaseObject;
                } else {
                    fieldSpecObj = (ClusterOperationJobProgress)this.Field;
                }
            }
            string fieldSpecDoc = Query.ClusterOperationJobProgress(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryClusterOperationJobProgress",
                "($input: ClusterOperationJobProgressInput!)",
                fieldSpecDoc,
                "ClusterOperationJobProgress"
            );
        }

        // Invoke GraphQL Query:
        // clusterIpv6Mode(input: ClusterIpv6ModeInput!): ClusterIpv6ModeReply!
        protected void InvokeQueryClusterIpv6Mode()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "ClusterIpv6ModeInput!"),
            };
            ClusterIpv6ModeReply? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (ClusterIpv6ModeReply)psObject.BaseObject;
                } else {
                    fieldSpecObj = (ClusterIpv6ModeReply)this.Field;
                }
            }
            string fieldSpecDoc = Query.ClusterIpv6Mode(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryClusterIpv6Mode",
                "($input: ClusterIpv6ModeInput!)",
                fieldSpecDoc,
                "ClusterIpv6ModeReply"
            );
        }

        // Invoke GraphQL Query:
        // clusterCsr(input: GetClusterCsrInput!): ClusterCsr!
        protected void InvokeQueryClusterCsr()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetClusterCsrInput!"),
            };
            ClusterCsr? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (ClusterCsr)psObject.BaseObject;
                } else {
                    fieldSpecObj = (ClusterCsr)this.Field;
                }
            }
            string fieldSpecDoc = Query.ClusterCsr(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryClusterCsr",
                "($input: GetClusterCsrInput!)",
                fieldSpecDoc,
                "ClusterCsr"
            );
        }

        // Invoke GraphQL Query:
        // clusterTypeList: [GroupCount!]!
        protected void InvokeQueryClusterTypeList()
        {
            Tuple<string, string>[] argDefs = {
            };
            List<GroupCount>? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (List<GroupCount>)psObject.BaseObject;
                } else {
                    fieldSpecObj = (List<GroupCount>)this.Field;
                }
            }
            string fieldSpecDoc = Query.ClusterTypeList(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryClusterTypeList",
                "",
                fieldSpecDoc,
                "List<GroupCount>"
            );
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
            ClusterGroupByConnection? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (ClusterGroupByConnection)psObject.BaseObject;
                } else {
                    fieldSpecObj = (ClusterGroupByConnection)this.Field;
                }
            }
            string fieldSpecDoc = Query.ClusterGroupByConnection(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryClusterGroupByConnection",
                "($first: Int,$after: String,$last: Int,$before: String,$groupBy: ClusterGroupByEnum!,$filter: ClusterFilterInput,$timezoneOffset: Float)",
                fieldSpecDoc,
                "ClusterGroupByConnection"
            );
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
            ClusterConnection? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (ClusterConnection)psObject.BaseObject;
                } else {
                    fieldSpecObj = (ClusterConnection)this.Field;
                }
            }
            string fieldSpecDoc = Query.ClusterWithConfigProtectionInfo(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryClusterWithConfigProtectionInfo",
                "($first: Int,$after: String,$last: Int,$before: String,$configProtectionFilter: ConfigProtectionInfoFilterInput,$sortOrder: SortOrder,$sortBy: ConfigProtectionInfoSortBy)",
                fieldSpecDoc,
                "ClusterConnection"
            );
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
            RcvLocationBasicInfoConnection? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (RcvLocationBasicInfoConnection)psObject.BaseObject;
                } else {
                    fieldSpecObj = (RcvLocationBasicInfoConnection)this.Field;
                }
            }
            string fieldSpecDoc = Query.ClusterRcvLocations(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryClusterRcvLocations",
                "($first: Int,$after: String,$last: Int,$before: String,$sortOrder: SortOrder,$cdmClusterUUID: UUID!)",
                fieldSpecDoc,
                "RcvLocationBasicInfoConnection"
            );
        }

        // Invoke GraphQL Query:
        // allConnectedClusters(clusterFilterArg: ClusterTypeEnum): [DataLocationSupportedCluster!]!
        protected void InvokeQueryAllConnectedClusters()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("clusterFilterArg", "ClusterTypeEnum"),
            };
            List<DataLocationSupportedCluster>? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (List<DataLocationSupportedCluster>)psObject.BaseObject;
                } else {
                    fieldSpecObj = (List<DataLocationSupportedCluster>)this.Field;
                }
            }
            string fieldSpecDoc = Query.AllConnectedClusters(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryAllConnectedClusters",
                "($clusterFilterArg: ClusterTypeEnum)",
                fieldSpecDoc,
                "List<DataLocationSupportedCluster>"
            );
        }

        // Invoke GraphQL Query:
        // allClusterReplicationTargets(clusterUuid: UUID!): [ClusterReplicationTarget!]!
        protected void InvokeQueryAllClusterReplicationTargets()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("clusterUuid", "UUID!"),
            };
            List<ClusterReplicationTarget>? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (List<ClusterReplicationTarget>)psObject.BaseObject;
                } else {
                    fieldSpecObj = (List<ClusterReplicationTarget>)this.Field;
                }
            }
            string fieldSpecDoc = Query.AllClusterReplicationTargets(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryAllClusterReplicationTargets",
                "($clusterUuid: UUID!)",
                fieldSpecDoc,
                "List<ClusterReplicationTarget>"
            );
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
            ClusterEncryptionInfoConnection? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (ClusterEncryptionInfoConnection)psObject.BaseObject;
                } else {
                    fieldSpecObj = (ClusterEncryptionInfoConnection)this.Field;
                }
            }
            string fieldSpecDoc = Query.ClusterEncryptionInfo(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryClusterEncryptionInfo",
                "($first: Int,$after: String,$last: Int,$before: String,$sortOrder: SortOrder,$clusterName: String,$encryptionStatusFilter: [ClusterEncryptionStatusFilter!]!,$keyProtection: [ClusterKeyProtection!]!,$clusters: [UUID!]!,$encryptionTypes: [ClusterEncryptionType!]!)",
                fieldSpecDoc,
                "ClusterEncryptionInfoConnection"
            );
        }

        // Invoke GraphQL Query:
        // hostFailoverCluster(fid: UUID!): HostFailoverCluster!
        protected void InvokeQueryHostFailoverCluster()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            HostFailoverCluster? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (HostFailoverCluster)psObject.BaseObject;
                } else {
                    fieldSpecObj = (HostFailoverCluster)this.Field;
                }
            }
            string fieldSpecDoc = Query.HostFailoverCluster(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryHostFailoverCluster",
                "($fid: UUID!)",
                fieldSpecDoc,
                "HostFailoverCluster"
            );
        }

        // Invoke GraphQL Query:
        // allGlobalFileSearchMultipleClusters(clusters: [UUID!]! = [], regex: String!): GlobalFileSearchReplyType!
        protected void InvokeQueryAllGlobalFileSearchMultipleClusters()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("clusters", "[UUID!]!"),
                Tuple.Create("regex", "String!"),
            };
            GlobalFileSearchReplyType? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (GlobalFileSearchReplyType)psObject.BaseObject;
                } else {
                    fieldSpecObj = (GlobalFileSearchReplyType)this.Field;
                }
            }
            string fieldSpecDoc = Query.AllGlobalFileSearchMultipleClusters(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryAllGlobalFileSearchMultipleClusters",
                "($clusters: [UUID!]!,$regex: String!)",
                fieldSpecDoc,
                "GlobalFileSearchReplyType"
            );
        }

        // Invoke GraphQL Query:
        // kubernetesClusters(
        //     first: Int
        //     after: String
        //     sortBy: HierarchySortByField
        //     sortOrder: SortOrder
        //     filter: [Filter!]
        //   ): KubernetesClusterConnection!
        protected void InvokeQueryKubernetesClusters()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("sortBy", "HierarchySortByField"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("filter", "[Filter!]"),
            };
            KubernetesClusterConnection? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (KubernetesClusterConnection)psObject.BaseObject;
                } else {
                    fieldSpecObj = (KubernetesClusterConnection)this.Field;
                }
            }
            string fieldSpecDoc = Query.KubernetesClusters(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryKubernetesClusters",
                "($first: Int,$after: String,$sortBy: HierarchySortByField,$sortOrder: SortOrder,$filter: [Filter!])",
                fieldSpecDoc,
                "KubernetesClusterConnection"
            );
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
            K8sClusterConnection? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (K8sClusterConnection)psObject.BaseObject;
                } else {
                    fieldSpecObj = (K8sClusterConnection)this.Field;
                }
            }
            string fieldSpecDoc = Query.K8sClusters(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryK8sClusters",
                "($first: Int,$after: String,$sortBy: HierarchySortByField,$sortOrder: SortOrder,$filter: [Filter!])",
                fieldSpecDoc,
                "K8sClusterConnection"
            );
        }

        // Invoke GraphQL Query:
        // windowsCluster(fid: UUID!): WindowsCluster!
        protected void InvokeQueryWindowsCluster()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            WindowsCluster? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (WindowsCluster)psObject.BaseObject;
                } else {
                    fieldSpecObj = (WindowsCluster)this.Field;
                }
            }
            string fieldSpecDoc = Query.WindowsCluster(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryWindowsCluster",
                "($fid: UUID!)",
                fieldSpecDoc,
                "WindowsCluster"
            );
        }

        // Invoke GraphQL Query:
        // clusterReportMigrationStatus(
        //     clusterUuid: UUID
        //     status: [CdmReportMigrationStatus!]!
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //   ): ReportMigrationStatusConnection!
        protected void InvokeQueryClusterReportMigrationStatus()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("clusterUuid", "UUID"),
                Tuple.Create("status", "[CdmReportMigrationStatus!]!"),
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
            };
            ReportMigrationStatusConnection? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (ReportMigrationStatusConnection)psObject.BaseObject;
                } else {
                    fieldSpecObj = (ReportMigrationStatusConnection)this.Field;
                }
            }
            string fieldSpecDoc = Query.ClusterReportMigrationStatus(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryClusterReportMigrationStatus",
                "($clusterUuid: UUID,$status: [CdmReportMigrationStatus!]!,$first: Int,$after: String,$last: Int,$before: String)",
                fieldSpecDoc,
                "ReportMigrationStatusConnection"
            );
        }

        // Invoke GraphQL Query:
        // clusterReportMigrationCount(clusterUuid: UUID, status: [CdmReportMigrationStatus!]!): ReportsMigrationCount!
        protected void InvokeQueryClusterReportMigrationCount()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("clusterUuid", "UUID"),
                Tuple.Create("status", "[CdmReportMigrationStatus!]!"),
            };
            ReportsMigrationCount? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (ReportsMigrationCount)psObject.BaseObject;
                } else {
                    fieldSpecObj = (ReportsMigrationCount)this.Field;
                }
            }
            string fieldSpecDoc = Query.ClusterReportMigrationCount(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryClusterReportMigrationCount",
                "($clusterUuid: UUID,$status: [CdmReportMigrationStatus!]!)",
                fieldSpecDoc,
                "ReportsMigrationCount"
            );
        }

        // Invoke GraphQL Query:
        // clusterReportMigrationJobStatus(clusterUuid: UUID): ClusterReportMigrationJobStatus!
        protected void InvokeQueryClusterReportMigrationJobStatus()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("clusterUuid", "UUID"),
            };
            ClusterReportMigrationJobStatus? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (ClusterReportMigrationJobStatus)psObject.BaseObject;
                } else {
                    fieldSpecObj = (ClusterReportMigrationJobStatus)this.Field;
                }
            }
            string fieldSpecDoc = Query.ClusterReportMigrationJobStatus(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryClusterReportMigrationJobStatus",
                "($clusterUuid: UUID)",
                fieldSpecDoc,
                "ClusterReportMigrationJobStatus"
            );
        }

        // Invoke GraphQL Query:
        // clusterSlaDomains(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //   ): ClusterSlaDomainConnection!
        protected void InvokeQueryClusterSlaDomains()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
            };
            ClusterSlaDomainConnection? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (ClusterSlaDomainConnection)psObject.BaseObject;
                } else {
                    fieldSpecObj = (ClusterSlaDomainConnection)this.Field;
                }
            }
            string fieldSpecDoc = Query.ClusterSlaDomains(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryClusterSlaDomains",
                "($first: Int,$after: String,$last: Int,$before: String)",
                fieldSpecDoc,
                "ClusterSlaDomainConnection"
            );
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
            ClusterSlaDomainForFilterConnection? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (ClusterSlaDomainForFilterConnection)psObject.BaseObject;
                } else {
                    fieldSpecObj = (ClusterSlaDomainForFilterConnection)this.Field;
                }
            }
            string fieldSpecDoc = Query.ClusterSlaDomainFilterConnection(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryClusterSlaDomainFilterConnection",
                "($first: Int,$after: String,$last: Int,$before: String)",
                fieldSpecDoc,
                "ClusterSlaDomainForFilterConnection"
            );
        }

        // Invoke GraphQL Query:
        // verifySlaWithReplicationToCluster(cdmClusterUUID: UUID!, includeArchived: Boolean!): VerifySlaWithReplicationToClusterResponse!
        protected void InvokeQueryVerifySlaWithReplicationToCluster()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("cdmClusterUUID", "UUID!"),
                Tuple.Create("includeArchived", "Boolean!"),
            };
            VerifySlaWithReplicationToClusterResponse? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (VerifySlaWithReplicationToClusterResponse)psObject.BaseObject;
                } else {
                    fieldSpecObj = (VerifySlaWithReplicationToClusterResponse)this.Field;
                }
            }
            string fieldSpecDoc = Query.VerifySlaWithReplicationToCluster(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryVerifySlaWithReplicationToCluster",
                "($cdmClusterUUID: UUID!,$includeArchived: Boolean!)",
                fieldSpecDoc,
                "VerifySlaWithReplicationToClusterResponse"
            );
        }

        // Invoke GraphQL Query:
        // allClusterGlobalSlas(cdmClusterUUID: UUID!): [SlaInfo!]!
        protected void InvokeQueryAllClusterGlobalSlas()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("cdmClusterUUID", "UUID!"),
            };
            List<SlaInfo>? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (List<SlaInfo>)psObject.BaseObject;
                } else {
                    fieldSpecObj = (List<SlaInfo>)this.Field;
                }
            }
            string fieldSpecDoc = Query.AllClusterGlobalSlas(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryAllClusterGlobalSlas",
                "($cdmClusterUUID: UUID!)",
                fieldSpecDoc,
                "List<SlaInfo>"
            );
        }

        // Invoke GraphQL Query:
        // clusterRegistrationProductInfo: ClusterRegistrationProductInfoType!
        protected void InvokeQueryClusterRegistrationProductInfo()
        {
            Tuple<string, string>[] argDefs = {
            };
            ClusterRegistrationProductInfoType? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (ClusterRegistrationProductInfoType)psObject.BaseObject;
                } else {
                    fieldSpecObj = (ClusterRegistrationProductInfoType)this.Field;
                }
            }
            string fieldSpecDoc = Query.ClusterRegistrationProductInfo(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryClusterRegistrationProductInfo",
                "",
                fieldSpecDoc,
                "ClusterRegistrationProductInfoType"
            );
        }

        // Invoke GraphQL Query:
        // vcdClusters(input: QueryVcdClusterInput!): VcdClusterSummaryListResponse!
        protected void InvokeQueryVcdClusters()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "QueryVcdClusterInput!"),
            };
            VcdClusterSummaryListResponse? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (VcdClusterSummaryListResponse)psObject.BaseObject;
                } else {
                    fieldSpecObj = (VcdClusterSummaryListResponse)this.Field;
                }
            }
            string fieldSpecDoc = Query.VcdClusters(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryVcdClusters",
                "($input: QueryVcdClusterInput!)",
                fieldSpecDoc,
                "VcdClusterSummaryListResponse"
            );
        }

        // Invoke GraphQL Query:
        // isTotpAckNecessaryForCluster(clusterUuid: UUID!): Boolean!
        protected void InvokeQueryIsTotpAckNecessaryForCluster()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("clusterUuid", "UUID!"),
            };
            System.Boolean? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (System.Boolean)psObject.BaseObject;
                } else {
                    fieldSpecObj = (System.Boolean)this.Field;
                }
            }
            string fieldSpecDoc = Query.IsTotpAckNecessaryForCluster(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryIsTotpAckNecessaryForCluster",
                "($clusterUuid: UUID!)",
                fieldSpecDoc,
                "System.Boolean"
            );
        }

        // Invoke GraphQL Query:
        // allClustersTotpAckStatus(listClusterUuid: [UUID!]!): [Boolean!]!
        protected void InvokeQueryAllClustersTotpAckStatus()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("listClusterUuid", "[UUID!]!"),
            };
            List<System.Boolean>? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (List<System.Boolean>)psObject.BaseObject;
                } else {
                    fieldSpecObj = (List<System.Boolean>)this.Field;
                }
            }
            string fieldSpecDoc = Query.AllClustersTotpAckStatus(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryAllClustersTotpAckStatus",
                "($listClusterUuid: [UUID!]!)",
                fieldSpecDoc,
                "List<System.Boolean>"
            );
        }


    } // class Invoke_RscQueryCluster
}