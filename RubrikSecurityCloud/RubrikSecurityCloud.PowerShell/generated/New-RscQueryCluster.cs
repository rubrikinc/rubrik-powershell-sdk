// New-RscQueryCluster.cs
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
    /// <summary>
    /// Queries for the 'Cluster' API domain.
    /// </summary>
    /// <description>
    /// New-RscQueryCluster is a master cmdlet for Cluster work that can invoke any of the following subcommands: Nodes, List, Cluster, WithUpgradesInfo, Dns, Proxy, NtpServers, NetworkInterfaces, FloatingIps, Vlans, DefaultGateway, WebSignedCertificate, Ipmi, Certificates, WebCertsAndIpmis, OperationJobProgress, Ipv6Mode, Csr, TypeList, GroupByList, DatabaseLogReportingProperties, DatabaseLogReport, Connected, ReplicationTargets, HostFailover, K8s, Windows, ReportMigrationStatus, ReportMigrationCount, ReportMigrationJobStatus, SlaDomains, VerifySlaWithReplicationTo, GlobalSlas, RegistrationProductInfo, IsTotpAckNecessary, TotpAckStatus.
    /// </description>
    /// <example>
    /// <code>New-RscQueryCluster -Nodes [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryCluster -List [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryCluster -Cluster [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryCluster -WithUpgradesInfo [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryCluster -Dns [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryCluster -Proxy [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryCluster -NtpServers [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryCluster -NetworkInterfaces [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryCluster -FloatingIps [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryCluster -Vlans [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryCluster -DefaultGateway [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryCluster -WebSignedCertificate [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryCluster -Ipmi [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryCluster -Certificates [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryCluster -WebCertsAndIpmis [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryCluster -OperationJobProgress [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryCluster -Ipv6Mode [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryCluster -Csr [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryCluster -TypeList [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryCluster -GroupByList [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryCluster -DatabaseLogReportingProperties [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryCluster -DatabaseLogReport [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryCluster -Connected [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryCluster -ReplicationTargets [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryCluster -HostFailover [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryCluster -K8s [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryCluster -Windows [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryCluster -ReportMigrationStatus [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryCluster -ReportMigrationCount [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryCluster -ReportMigrationJobStatus [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryCluster -SlaDomains [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryCluster -VerifySlaWithReplicationTo [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryCluster -GlobalSlas [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryCluster -RegistrationProductInfo [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryCluster -IsTotpAckNecessary [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryCluster -TotpAckStatus [-Arg ..] [-Field ..]</code>
    /// </example>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscQueryCluster",
        DefaultParameterSetName = "Cluster")
    ]
    public class New_RscQueryCluster : RscGqlPSCmdlet
    {
        
        /// <summary>
        /// Nodes parameter set
        ///
        /// [GraphQL: clusterNodes]
        /// </summary>
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

        
        /// <summary>
        /// List parameter set
        ///
        /// [GraphQL: clusterConnection]
        /// </summary>
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

        
        /// <summary>
        /// Cluster parameter set
        ///
        /// [GraphQL: cluster]
        /// </summary>
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

        
        /// <summary>
        /// WithUpgradesInfo parameter set
        ///
        /// [GraphQL: clusterWithUpgradesInfo]
        /// </summary>
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

        
        /// <summary>
        /// Dns parameter set
        ///
        /// [GraphQL: clusterDns]
        /// </summary>
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

        
        /// <summary>
        /// Proxy parameter set
        ///
        /// [GraphQL: clusterProxy]
        /// </summary>
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

        
        /// <summary>
        /// NtpServers parameter set
        ///
        /// [GraphQL: clusterNtpServers]
        /// </summary>
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

        
        /// <summary>
        /// NetworkInterfaces parameter set
        ///
        /// [GraphQL: clusterNetworkInterfaces]
        /// </summary>
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

        
        /// <summary>
        /// FloatingIps parameter set
        ///
        /// [GraphQL: clusterFloatingIps]
        /// </summary>
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

        
        /// <summary>
        /// Vlans parameter set
        ///
        /// [GraphQL: clusterVlans]
        /// </summary>
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

        
        /// <summary>
        /// DefaultGateway parameter set
        ///
        /// [GraphQL: clusterDefaultGateway]
        /// </summary>
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

        
        /// <summary>
        /// WebSignedCertificate parameter set
        ///
        /// [GraphQL: clusterWebSignedCertificate]
        /// </summary>
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

        
        /// <summary>
        /// Ipmi parameter set
        ///
        /// [GraphQL: clusterIpmi]
        /// </summary>
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

        
        /// <summary>
        /// Certificates parameter set
        ///
        /// [GraphQL: clusterCertificates]
        /// </summary>
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

        
        /// <summary>
        /// WebCertsAndIpmis parameter set
        ///
        /// [GraphQL: allClusterWebCertsAndIpmis]
        /// </summary>
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

        
        /// <summary>
        /// OperationJobProgress parameter set
        ///
        /// [GraphQL: clusterOperationJobProgress]
        /// </summary>
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

        
        /// <summary>
        /// Ipv6Mode parameter set
        ///
        /// [GraphQL: clusterIpv6Mode]
        /// </summary>
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

        
        /// <summary>
        /// Csr parameter set
        ///
        /// [GraphQL: clusterCsr]
        /// </summary>
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

        
        /// <summary>
        /// TypeList parameter set
        ///
        /// [GraphQL: clusterTypeList]
        /// </summary>
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

        
        /// <summary>
        /// GroupByList parameter set
        ///
        /// [GraphQL: clusterGroupByConnection]
        /// </summary>
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

        
        /// <summary>
        /// DatabaseLogReportingProperties parameter set
        ///
        /// [GraphQL: databaseLogReportingPropertiesForCluster]
        /// </summary>
        [Parameter(
            ParameterSetName = "DatabaseLogReportingProperties",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Get the database log backup report properties

Supported in v5.3+
Get the properties for the database (SQL and Oracle) log backup delay email notification creation. The properties are logDelayThresholdInMin and logDelayNotificationFrequencyInMin.
[GraphQL: databaseLogReportingPropertiesForCluster]",
            Position = 0
        )]
        public SwitchParameter DatabaseLogReportingProperties { get; set; }

        
        /// <summary>
        /// DatabaseLogReport parameter set
        ///
        /// [GraphQL: databaseLogReportForCluster]
        /// </summary>
        [Parameter(
            ParameterSetName = "DatabaseLogReport",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Get the database log backup delay information

Supported in v5.3+
v5.3: 
v6.0+: Get the database log backup delay information.
[GraphQL: databaseLogReportForCluster]",
            Position = 0
        )]
        public SwitchParameter DatabaseLogReport { get; set; }

        
        /// <summary>
        /// Connected parameter set
        ///
        /// [GraphQL: allConnectedClusters]
        /// </summary>
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

        
        /// <summary>
        /// ReplicationTargets parameter set
        ///
        /// [GraphQL: allClusterReplicationTargets]
        /// </summary>
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

        
        /// <summary>
        /// HostFailover parameter set
        ///
        /// [GraphQL: hostFailoverCluster]
        /// </summary>
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

        
        /// <summary>
        /// K8s parameter set
        ///
        /// [GraphQL: k8sClusters]
        /// </summary>
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

        
        /// <summary>
        /// Windows parameter set
        ///
        /// [GraphQL: windowsCluster]
        /// </summary>
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

        
        /// <summary>
        /// ReportMigrationStatus parameter set
        ///
        /// [GraphQL: clusterReportMigrationStatus]
        /// </summary>
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

        
        /// <summary>
        /// ReportMigrationCount parameter set
        ///
        /// [GraphQL: clusterReportMigrationCount]
        /// </summary>
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

        
        /// <summary>
        /// ReportMigrationJobStatus parameter set
        ///
        /// [GraphQL: clusterReportMigrationJobStatus]
        /// </summary>
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

        
        /// <summary>
        /// SlaDomains parameter set
        ///
        /// [GraphQL: clusterSlaDomains]
        /// </summary>
        [Parameter(
            ParameterSetName = "SlaDomains",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Returns paginated list of SLA domains that were created on Rubrik CDM.
[GraphQL: clusterSlaDomains]",
            Position = 0
        )]
        public SwitchParameter SlaDomains { get; set; }

        
        /// <summary>
        /// VerifySlaWithReplicationTo parameter set
        ///
        /// [GraphQL: verifySlaWithReplicationToCluster]
        /// </summary>
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

        
        /// <summary>
        /// GlobalSlas parameter set
        ///
        /// [GraphQL: allClusterGlobalSlas]
        /// </summary>
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

        
        /// <summary>
        /// RegistrationProductInfo parameter set
        ///
        /// [GraphQL: clusterRegistrationProductInfo]
        /// </summary>
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

        
        /// <summary>
        /// IsTotpAckNecessary parameter set
        ///
        /// [GraphQL: isTotpAckNecessaryForCluster]
        /// </summary>
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

        
        /// <summary>
        /// TotpAckStatus parameter set
        ///
        /// [GraphQL: allClustersTotpAckStatus]
        /// </summary>
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


// ignore warning 'Missing XML comment'
#pragma warning disable 1591
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                switch(Op)
                {
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
                    case "DatabaseLogReportingProperties":
                        this.ProcessRecord_DatabaseLogReportingProperties();
                        break;
                    case "DatabaseLogReport":
                        this.ProcessRecord_DatabaseLogReport();
                        break;
                    case "Connected":
                        this.ProcessRecord_Connected();
                        break;
                    case "ReplicationTargets":
                        this.ProcessRecord_ReplicationTargets();
                        break;
                    case "HostFailover":
                        this.ProcessRecord_HostFailover();
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
                    case "SlaDomains":
                        this.ProcessRecord_SlaDomains();
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
#pragma warning restore 1591

        // This parameter set invokes a single graphql operation:
        // clusterNodes.
        internal void ProcessRecord_Nodes()
        {
            this._logger.name += " -Nodes";
            // Create new graphql operation clusterNodes
            InitQueryClusterNodes();
        }

        // This parameter set invokes a single graphql operation:
        // clusterConnection.
        internal void ProcessRecord_List()
        {
            this._logger.name += " -List";
            // Create new graphql operation clusterConnection
            InitQueryClusterConnection();
        }

        // This parameter set invokes a single graphql operation:
        // cluster.
        internal void ProcessRecord_Cluster()
        {
            this._logger.name += " -Cluster";
            // Create new graphql operation cluster
            InitQueryCluster();
        }

        // This parameter set invokes a single graphql operation:
        // clusterWithUpgradesInfo.
        internal void ProcessRecord_WithUpgradesInfo()
        {
            this._logger.name += " -WithUpgradesInfo";
            // Create new graphql operation clusterWithUpgradesInfo
            InitQueryClusterWithUpgradesInfo();
        }

        // This parameter set invokes a single graphql operation:
        // clusterDns.
        internal void ProcessRecord_Dns()
        {
            this._logger.name += " -Dns";
            // Create new graphql operation clusterDns
            InitQueryClusterDns();
        }

        // This parameter set invokes a single graphql operation:
        // clusterProxy.
        internal void ProcessRecord_Proxy()
        {
            this._logger.name += " -Proxy";
            // Create new graphql operation clusterProxy
            InitQueryClusterProxy();
        }

        // This parameter set invokes a single graphql operation:
        // clusterNtpServers.
        internal void ProcessRecord_NtpServers()
        {
            this._logger.name += " -NtpServers";
            // Create new graphql operation clusterNtpServers
            InitQueryClusterNtpServers();
        }

        // This parameter set invokes a single graphql operation:
        // clusterNetworkInterfaces.
        internal void ProcessRecord_NetworkInterfaces()
        {
            this._logger.name += " -NetworkInterfaces";
            // Create new graphql operation clusterNetworkInterfaces
            InitQueryClusterNetworkInterfaces();
        }

        // This parameter set invokes a single graphql operation:
        // clusterFloatingIps.
        internal void ProcessRecord_FloatingIps()
        {
            this._logger.name += " -FloatingIps";
            // Create new graphql operation clusterFloatingIps
            InitQueryClusterFloatingIps();
        }

        // This parameter set invokes a single graphql operation:
        // clusterVlans.
        internal void ProcessRecord_Vlans()
        {
            this._logger.name += " -Vlans";
            // Create new graphql operation clusterVlans
            InitQueryClusterVlans();
        }

        // This parameter set invokes a single graphql operation:
        // clusterDefaultGateway.
        internal void ProcessRecord_DefaultGateway()
        {
            this._logger.name += " -DefaultGateway";
            // Create new graphql operation clusterDefaultGateway
            InitQueryClusterDefaultGateway();
        }

        // This parameter set invokes a single graphql operation:
        // clusterWebSignedCertificate.
        internal void ProcessRecord_WebSignedCertificate()
        {
            this._logger.name += " -WebSignedCertificate";
            // Create new graphql operation clusterWebSignedCertificate
            InitQueryClusterWebSignedCertificate();
        }

        // This parameter set invokes a single graphql operation:
        // clusterIpmi.
        internal void ProcessRecord_Ipmi()
        {
            this._logger.name += " -Ipmi";
            // Create new graphql operation clusterIpmi
            InitQueryClusterIpmi();
        }

        // This parameter set invokes a single graphql operation:
        // clusterCertificates.
        internal void ProcessRecord_Certificates()
        {
            this._logger.name += " -Certificates";
            // Create new graphql operation clusterCertificates
            InitQueryClusterCertificates();
        }

        // This parameter set invokes a single graphql operation:
        // allClusterWebCertsAndIpmis.
        internal void ProcessRecord_WebCertsAndIpmis()
        {
            this._logger.name += " -WebCertsAndIpmis";
            // Create new graphql operation allClusterWebCertsAndIpmis
            InitQueryAllClusterWebCertsAndIpmis();
        }

        // This parameter set invokes a single graphql operation:
        // clusterOperationJobProgress.
        internal void ProcessRecord_OperationJobProgress()
        {
            this._logger.name += " -OperationJobProgress";
            // Create new graphql operation clusterOperationJobProgress
            InitQueryClusterOperationJobProgress();
        }

        // This parameter set invokes a single graphql operation:
        // clusterIpv6Mode.
        internal void ProcessRecord_Ipv6Mode()
        {
            this._logger.name += " -Ipv6Mode";
            // Create new graphql operation clusterIpv6Mode
            InitQueryClusterIpv6Mode();
        }

        // This parameter set invokes a single graphql operation:
        // clusterCsr.
        internal void ProcessRecord_Csr()
        {
            this._logger.name += " -Csr";
            // Create new graphql operation clusterCsr
            InitQueryClusterCsr();
        }

        // This parameter set invokes a single graphql operation:
        // clusterTypeList.
        internal void ProcessRecord_TypeList()
        {
            this._logger.name += " -TypeList";
            // Create new graphql operation clusterTypeList
            InitQueryClusterTypeList();
        }

        // This parameter set invokes a single graphql operation:
        // clusterGroupByConnection.
        internal void ProcessRecord_GroupByList()
        {
            this._logger.name += " -GroupByList";
            // Create new graphql operation clusterGroupByConnection
            InitQueryClusterGroupByConnection();
        }

        // This parameter set invokes a single graphql operation:
        // databaseLogReportingPropertiesForCluster.
        internal void ProcessRecord_DatabaseLogReportingProperties()
        {
            this._logger.name += " -DatabaseLogReportingProperties";
            // Create new graphql operation databaseLogReportingPropertiesForCluster
            InitQueryDatabaseLogReportingPropertiesForCluster();
        }

        // This parameter set invokes a single graphql operation:
        // databaseLogReportForCluster.
        internal void ProcessRecord_DatabaseLogReport()
        {
            this._logger.name += " -DatabaseLogReport";
            // Create new graphql operation databaseLogReportForCluster
            InitQueryDatabaseLogReportForCluster();
        }

        // This parameter set invokes a single graphql operation:
        // allConnectedClusters.
        internal void ProcessRecord_Connected()
        {
            this._logger.name += " -Connected";
            // Create new graphql operation allConnectedClusters
            InitQueryAllConnectedClusters();
        }

        // This parameter set invokes a single graphql operation:
        // allClusterReplicationTargets.
        internal void ProcessRecord_ReplicationTargets()
        {
            this._logger.name += " -ReplicationTargets";
            // Create new graphql operation allClusterReplicationTargets
            InitQueryAllClusterReplicationTargets();
        }

        // This parameter set invokes a single graphql operation:
        // hostFailoverCluster.
        internal void ProcessRecord_HostFailover()
        {
            this._logger.name += " -HostFailover";
            // Create new graphql operation hostFailoverCluster
            InitQueryHostFailoverCluster();
        }

        // This parameter set invokes a single graphql operation:
        // k8sClusters.
        internal void ProcessRecord_K8s()
        {
            this._logger.name += " -K8s";
            // Create new graphql operation k8sClusters
            InitQueryK8sClusters();
        }

        // This parameter set invokes a single graphql operation:
        // windowsCluster.
        internal void ProcessRecord_Windows()
        {
            this._logger.name += " -Windows";
            // Create new graphql operation windowsCluster
            InitQueryWindowsCluster();
        }

        // This parameter set invokes a single graphql operation:
        // clusterReportMigrationStatus.
        internal void ProcessRecord_ReportMigrationStatus()
        {
            this._logger.name += " -ReportMigrationStatus";
            // Create new graphql operation clusterReportMigrationStatus
            InitQueryClusterReportMigrationStatus();
        }

        // This parameter set invokes a single graphql operation:
        // clusterReportMigrationCount.
        internal void ProcessRecord_ReportMigrationCount()
        {
            this._logger.name += " -ReportMigrationCount";
            // Create new graphql operation clusterReportMigrationCount
            InitQueryClusterReportMigrationCount();
        }

        // This parameter set invokes a single graphql operation:
        // clusterReportMigrationJobStatus.
        internal void ProcessRecord_ReportMigrationJobStatus()
        {
            this._logger.name += " -ReportMigrationJobStatus";
            // Create new graphql operation clusterReportMigrationJobStatus
            InitQueryClusterReportMigrationJobStatus();
        }

        // This parameter set invokes a single graphql operation:
        // clusterSlaDomains.
        internal void ProcessRecord_SlaDomains()
        {
            this._logger.name += " -SlaDomains";
            // Create new graphql operation clusterSlaDomains
            InitQueryClusterSlaDomains();
        }

        // This parameter set invokes a single graphql operation:
        // verifySlaWithReplicationToCluster.
        internal void ProcessRecord_VerifySlaWithReplicationTo()
        {
            this._logger.name += " -VerifySlaWithReplicationTo";
            // Create new graphql operation verifySlaWithReplicationToCluster
            InitQueryVerifySlaWithReplicationToCluster();
        }

        // This parameter set invokes a single graphql operation:
        // allClusterGlobalSlas.
        internal void ProcessRecord_GlobalSlas()
        {
            this._logger.name += " -GlobalSlas";
            // Create new graphql operation allClusterGlobalSlas
            InitQueryAllClusterGlobalSlas();
        }

        // This parameter set invokes a single graphql operation:
        // clusterRegistrationProductInfo.
        internal void ProcessRecord_RegistrationProductInfo()
        {
            this._logger.name += " -RegistrationProductInfo";
            // Create new graphql operation clusterRegistrationProductInfo
            InitQueryClusterRegistrationProductInfo();
        }

        // This parameter set invokes a single graphql operation:
        // isTotpAckNecessaryForCluster.
        internal void ProcessRecord_IsTotpAckNecessary()
        {
            this._logger.name += " -IsTotpAckNecessary";
            // Create new graphql operation isTotpAckNecessaryForCluster
            InitQueryIsTotpAckNecessaryForCluster();
        }

        // This parameter set invokes a single graphql operation:
        // allClustersTotpAckStatus.
        internal void ProcessRecord_TotpAckStatus()
        {
            this._logger.name += " -TotpAckStatus";
            // Create new graphql operation allClustersTotpAckStatus
            InitQueryAllClustersTotpAckStatus();
        }


        // Create new GraphQL Query:
        // clusterNodes(input: GetNodesInput!): NodeStatusListResponse!
        internal void InitQueryClusterNodes()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetNodesInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryClusterNodes",
                "($input: GetNodesInput!)",
                "NodeStatusListResponse",
                Query.ClusterNodes_ObjectFieldSpec,
                Query.ClusterNodesFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	clusterUuid = <System.String>
}"
            );
        }

        // Create new GraphQL Query:
        // clusterConnection(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     filter: ClusterFilterInput
        //     sortOrder: SortOrder = DESC
        //     sortBy: ClusterSortByEnum = ClusterType
        //   ): ClusterConnection!
        internal void InitQueryClusterConnection()
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
            Initialize(
                argDefs,
                "query",
                "QueryClusterConnection",
                "($first: Int,$after: String,$last: Int,$before: String,$filter: ClusterFilterInput,$sortOrder: SortOrder,$sortBy: ClusterSortByEnum)",
                "ClusterConnection",
                Query.ClusterConnection_ObjectFieldSpec,
                Query.ClusterConnectionFieldSpec,
                @"# OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# OPTIONAL
$inputs.Var.last = <System.Int32>
# OPTIONAL
$inputs.Var.before = <System.String>
# OPTIONAL
$inputs.Var.filter = @{
	# OPTIONAL
	id = @(
		<System.String>
	)
	# OPTIONAL
	name = @(
		<System.String>
	)
	# OPTIONAL
	type = @(
		<ClusterTypeEnum> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ClusterTypeEnum]) for enum values.
	)
	# OPTIONAL
	objectType = @(
		<ObjectTypeEnum> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ObjectTypeEnum]) for enum values.
	)
	# OPTIONAL
	registrationTime_gt = <DateTime>
	# OPTIONAL
	registrationTime_lt = <DateTime>
	# OPTIONAL
	minSoftwareVersion = <System.String>
	# OPTIONAL
	clusterLocation = @(
		<System.String>
	)
	# OPTIONAL
	excludeEmptyCluster = <System.Boolean>
	# OPTIONAL
	productType = @(
		<ClusterProductEnum> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ClusterProductEnum]) for enum values.
	)
	# OPTIONAL
	registeredMode = @(
		<ClusterRegistrationMode> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ClusterRegistrationMode]) for enum values.
	)
	# OPTIONAL
	product = <Product> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.Product]) for enum values.
	# OPTIONAL
	orgId = @(
		<System.String>
	)
	# OPTIONAL
	productFilters = @(
		@{
			# REQUIRED
			productType = <ClusterProductEnum> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ClusterProductEnum]) for enum values.
			# OPTIONAL
			minSoftwareVersion = <System.String>
		}
	)
	# OPTIONAL
	excludeId = @(
		<System.String>
	)
	# OPTIONAL
	systemStatus = @(
		<ClusterSystemStatus> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ClusterSystemStatus]) for enum values.
	)
	# OPTIONAL
	connectionState = @(
		<ClusterStatus> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ClusterStatus]) for enum values.
	)
	# OPTIONAL
	isInFatalOrDisconnectedState = <System.Boolean>
}
# OPTIONAL
$inputs.Var.sortOrder = <SortOrder> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$inputs.Var.sortBy = <ClusterSortByEnum> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ClusterSortByEnum]) for enum values."
            );
        }

        // Create new GraphQL Query:
        // cluster(clusterUuid: UUID!): Cluster!
        internal void InitQueryCluster()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("clusterUuid", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryCluster",
                "($clusterUuid: UUID!)",
                "Cluster",
                Query.Cluster_ObjectFieldSpec,
                Query.ClusterFieldSpec,
                @"# REQUIRED
$inputs.Var.clusterUuid = <System.String>"
            );
        }

        // Create new GraphQL Query:
        // clusterWithUpgradesInfo(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     upgradeFilter: CdmUpgradeInfoFilterInput
        //     sortOrder: SortOrder = DESC
        //     sortBy: UpgradeInfoSortByEnum = ClusterType
        //   ): ClusterConnection!
        internal void InitQueryClusterWithUpgradesInfo()
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
            Initialize(
                argDefs,
                "query",
                "QueryClusterWithUpgradesInfo",
                "($first: Int,$after: String,$last: Int,$before: String,$upgradeFilter: CdmUpgradeInfoFilterInput,$sortOrder: SortOrder,$sortBy: UpgradeInfoSortByEnum)",
                "ClusterConnection",
                Query.ClusterWithUpgradesInfo_ObjectFieldSpec,
                Query.ClusterWithUpgradesInfoFieldSpec,
                @"# OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# OPTIONAL
$inputs.Var.last = <System.Int32>
# OPTIONAL
$inputs.Var.before = <System.String>
# OPTIONAL
$inputs.Var.upgradeFilter = @{
	# OPTIONAL
	id = @(
		<System.String>
	)
	# OPTIONAL
	name = @(
		<System.String>
	)
	# OPTIONAL
	type = @(
		<ClusterTypeEnum> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ClusterTypeEnum]) for enum values.
	)
	# OPTIONAL
	registrationTime_gt = <DateTime>
	# OPTIONAL
	registrationTime_lt = <DateTime>
	# OPTIONAL
	minSoftwareVersion = <System.String>
	# OPTIONAL
	downloadedVersion = @(
		<System.String>
	)
	# OPTIONAL
	installedVersion = @(
		<System.String>
	)
	# OPTIONAL
	upgradeJobStatus = @(
		<ClusterJobStatusTypeEnum> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ClusterJobStatusTypeEnum]) for enum values.
	)
	# OPTIONAL
	clusterLocation = @(
		<System.String>
	)
	# OPTIONAL
	versionStatus = @(
		<VersionStatus> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.VersionStatus]) for enum values.
	)
	# OPTIONAL
	prechecksStatus = @(
		<PrechecksStatusTypeEnum> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.PrechecksStatusTypeEnum]) for enum values.
	)
	# OPTIONAL
	connectionState = @(
		<ClusterStatus> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ClusterStatus]) for enum values.
	)
	# OPTIONAL
	upgradeScheduled = <System.Boolean>
	# OPTIONAL
	productType = @(
		<ClusterProductEnum> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ClusterProductEnum]) for enum values.
	)
}
# OPTIONAL
$inputs.Var.sortOrder = <SortOrder> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$inputs.Var.sortBy = <UpgradeInfoSortByEnum> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UpgradeInfoSortByEnum]) for enum values."
            );
        }

        // Create new GraphQL Query:
        // clusterDns(clusterUuid: UUID!): ClusterDnsReply!
        internal void InitQueryClusterDns()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("clusterUuid", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryClusterDns",
                "($clusterUuid: UUID!)",
                "ClusterDnsReply",
                Query.ClusterDns_ObjectFieldSpec,
                Query.ClusterDnsFieldSpec,
                @"# REQUIRED
$inputs.Var.clusterUuid = <System.String>"
            );
        }

        // Create new GraphQL Query:
        // clusterProxy(clusterUuid: UUID!): ClusterProxyReply!
        internal void InitQueryClusterProxy()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("clusterUuid", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryClusterProxy",
                "($clusterUuid: UUID!)",
                "ClusterProxyReply",
                Query.ClusterProxy_ObjectFieldSpec,
                Query.ClusterProxyFieldSpec,
                @"# REQUIRED
$inputs.Var.clusterUuid = <System.String>"
            );
        }

        // Create new GraphQL Query:
        // clusterNtpServers(input: GetClusterNtpServersInput!): NtpServerConfigurationListResponse!
        internal void InitQueryClusterNtpServers()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetClusterNtpServersInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryClusterNtpServers",
                "($input: GetClusterNtpServersInput!)",
                "NtpServerConfigurationListResponse",
                Query.ClusterNtpServers_ObjectFieldSpec,
                Query.ClusterNtpServersFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
}"
            );
        }

        // Create new GraphQL Query:
        // clusterNetworkInterfaces(input: GetNetworkInterfaceInput!): NetworkInterfaceListResponse!
        internal void InitQueryClusterNetworkInterfaces()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetNetworkInterfaceInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryClusterNetworkInterfaces",
                "($input: GetNetworkInterfaceInput!)",
                "NetworkInterfaceListResponse",
                Query.ClusterNetworkInterfaces_ObjectFieldSpec,
                Query.ClusterNetworkInterfacesFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# OPTIONAL
	interface = <System.String>
	# REQUIRED
	id = <System.String>
}"
            );
        }

        // Create new GraphQL Query:
        // clusterFloatingIps(input: GetClusterIpsInput!): InternalGetClusterIpsResponse!
        internal void InitQueryClusterFloatingIps()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetClusterIpsInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryClusterFloatingIps",
                "($input: GetClusterIpsInput!)",
                "InternalGetClusterIpsResponse",
                Query.ClusterFloatingIps_ObjectFieldSpec,
                Query.ClusterFloatingIpsFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	clusterUuid = <System.String>
}"
            );
        }

        // Create new GraphQL Query:
        // clusterVlans(input: GetVlanInput!): VlanConfigListResponse!
        internal void InitQueryClusterVlans()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetVlanInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryClusterVlans",
                "($input: GetVlanInput!)",
                "VlanConfigListResponse",
                Query.ClusterVlans_ObjectFieldSpec,
                Query.ClusterVlansFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# OPTIONAL
	vlan = <System.Int32>
	# REQUIRED
	id = <System.String>
}"
            );
        }

        // Create new GraphQL Query:
        // clusterDefaultGateway(input: GetDefaultGatewayInput!): InternalGetDefaultGatewayResponse!
        internal void InitQueryClusterDefaultGateway()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetDefaultGatewayInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryClusterDefaultGateway",
                "($input: GetDefaultGatewayInput!)",
                "InternalGetDefaultGatewayResponse",
                Query.ClusterDefaultGateway_ObjectFieldSpec,
                Query.ClusterDefaultGatewayFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	clusterUuid = <System.String>
}"
            );
        }

        // Create new GraphQL Query:
        // clusterWebSignedCertificate(input: ClusterWebSignedCertificateInput!): ClusterWebSignedCertificateReply!
        internal void InitQueryClusterWebSignedCertificate()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "ClusterWebSignedCertificateInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryClusterWebSignedCertificate",
                "($input: ClusterWebSignedCertificateInput!)",
                "ClusterWebSignedCertificateReply",
                Query.ClusterWebSignedCertificate_ObjectFieldSpec,
                Query.ClusterWebSignedCertificateFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
}"
            );
        }

        // Create new GraphQL Query:
        // clusterIpmi(input: GetIpmiInput!): ModifyIpmiReply!
        internal void InitQueryClusterIpmi()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetIpmiInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryClusterIpmi",
                "($input: GetIpmiInput!)",
                "ModifyIpmiReply",
                Query.ClusterIpmi_ObjectFieldSpec,
                Query.ClusterIpmiFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
}"
            );
        }

        // Create new GraphQL Query:
        // clusterCertificates(input: QueryCertificatesInput!): CertificateSummaryListResponse!
        internal void InitQueryClusterCertificates()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "QueryCertificatesInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryClusterCertificates",
                "($input: QueryCertificatesInput!)",
                "CertificateSummaryListResponse",
                Query.ClusterCertificates_ObjectFieldSpec,
                Query.ClusterCertificatesFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# OPTIONAL
	description = <System.String>
	# OPTIONAL
	expiration = <System.String>
	# OPTIONAL
	hasKey = <System.Boolean>
	# OPTIONAL
	includeExpired = <System.Boolean>
	# OPTIONAL
	isTrusted = <System.Boolean>
	# OPTIONAL
	name = <System.String>
	# OPTIONAL
	sortBy = <V1QueryCertificatesRequestSortBy> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.V1QueryCertificatesRequestSortBy]) for enum values.
	# OPTIONAL
	sortOrder = <V1QueryCertificatesRequestSortOrder> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.V1QueryCertificatesRequestSortOrder]) for enum values.
	# REQUIRED
	clusterUuid = <System.String>
}"
            );
        }

        // Create new GraphQL Query:
        // allClusterWebCertsAndIpmis(input: BulkClusterWebCertAndIpmiInput!): [ClusterWebCertAndIpmi!]!
        internal void InitQueryAllClusterWebCertsAndIpmis()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "BulkClusterWebCertAndIpmiInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllClusterWebCertsAndIpmis",
                "($input: BulkClusterWebCertAndIpmiInput!)",
                "List<ClusterWebCertAndIpmi>",
                Query.AllClusterWebCertsAndIpmis_ObjectFieldSpec,
                Query.AllClusterWebCertsAndIpmisFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	clusterUuids = @(
		<System.String>
	)
}"
            );
        }

        // Create new GraphQL Query:
        // clusterOperationJobProgress(input: ClusterOperationJobProgressInput!): ClusterOperationJobProgress!
        internal void InitQueryClusterOperationJobProgress()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "ClusterOperationJobProgressInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryClusterOperationJobProgress",
                "($input: ClusterOperationJobProgressInput!)",
                "ClusterOperationJobProgress",
                Query.ClusterOperationJobProgress_ObjectFieldSpec,
                Query.ClusterOperationJobProgressFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# OPTIONAL
	clusterUuid = <System.String>
	# REQUIRED
	jobType = <CcpJobType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CcpJobType]) for enum values.
}"
            );
        }

        // Create new GraphQL Query:
        // clusterIpv6Mode(input: ClusterIpv6ModeInput!): ClusterIpv6ModeReply!
        internal void InitQueryClusterIpv6Mode()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "ClusterIpv6ModeInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryClusterIpv6Mode",
                "($input: ClusterIpv6ModeInput!)",
                "ClusterIpv6ModeReply",
                Query.ClusterIpv6Mode_ObjectFieldSpec,
                Query.ClusterIpv6ModeFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	clusterUuid = <System.String>
}"
            );
        }

        // Create new GraphQL Query:
        // clusterCsr(input: GetClusterCsrInput!): ClusterCsr!
        internal void InitQueryClusterCsr()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetClusterCsrInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryClusterCsr",
                "($input: GetClusterCsrInput!)",
                "ClusterCsr",
                Query.ClusterCsr_ObjectFieldSpec,
                Query.ClusterCsrFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
}"
            );
        }

        // Create new GraphQL Query:
        // clusterTypeList: [GroupCount!]!
        internal void InitQueryClusterTypeList()
        {
            Tuple<string, string>[] argDefs = {
            };
            Initialize(
                argDefs,
                "query",
                "QueryClusterTypeList",
                "",
                "List<GroupCount>",
                Query.ClusterTypeList_ObjectFieldSpec,
                Query.ClusterTypeListFieldSpec,
                @""
            );
        }

        // Create new GraphQL Query:
        // clusterGroupByConnection(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     groupBy: ClusterGroupByEnum!
        //     filter: ClusterFilterInput
        //     timezoneOffset: Float = 0.0
        //   ): ClusterGroupByConnection!
        internal void InitQueryClusterGroupByConnection()
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
            Initialize(
                argDefs,
                "query",
                "QueryClusterGroupByConnection",
                "($first: Int,$after: String,$last: Int,$before: String,$groupBy: ClusterGroupByEnum!,$filter: ClusterFilterInput,$timezoneOffset: Float)",
                "ClusterGroupByConnection",
                Query.ClusterGroupByConnection_ObjectFieldSpec,
                Query.ClusterGroupByConnectionFieldSpec,
                @"# OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# OPTIONAL
$inputs.Var.last = <System.Int32>
# OPTIONAL
$inputs.Var.before = <System.String>
# REQUIRED
$inputs.Var.groupBy = <ClusterGroupByEnum> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ClusterGroupByEnum]) for enum values.
# OPTIONAL
$inputs.Var.filter = @{
	# OPTIONAL
	id = @(
		<System.String>
	)
	# OPTIONAL
	name = @(
		<System.String>
	)
	# OPTIONAL
	type = @(
		<ClusterTypeEnum> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ClusterTypeEnum]) for enum values.
	)
	# OPTIONAL
	objectType = @(
		<ObjectTypeEnum> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ObjectTypeEnum]) for enum values.
	)
	# OPTIONAL
	registrationTime_gt = <DateTime>
	# OPTIONAL
	registrationTime_lt = <DateTime>
	# OPTIONAL
	minSoftwareVersion = <System.String>
	# OPTIONAL
	clusterLocation = @(
		<System.String>
	)
	# OPTIONAL
	excludeEmptyCluster = <System.Boolean>
	# OPTIONAL
	productType = @(
		<ClusterProductEnum> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ClusterProductEnum]) for enum values.
	)
	# OPTIONAL
	registeredMode = @(
		<ClusterRegistrationMode> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ClusterRegistrationMode]) for enum values.
	)
	# OPTIONAL
	product = <Product> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.Product]) for enum values.
	# OPTIONAL
	orgId = @(
		<System.String>
	)
	# OPTIONAL
	productFilters = @(
		@{
			# REQUIRED
			productType = <ClusterProductEnum> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ClusterProductEnum]) for enum values.
			# OPTIONAL
			minSoftwareVersion = <System.String>
		}
	)
	# OPTIONAL
	excludeId = @(
		<System.String>
	)
	# OPTIONAL
	systemStatus = @(
		<ClusterSystemStatus> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ClusterSystemStatus]) for enum values.
	)
	# OPTIONAL
	connectionState = @(
		<ClusterStatus> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ClusterStatus]) for enum values.
	)
	# OPTIONAL
	isInFatalOrDisconnectedState = <System.Boolean>
}
# OPTIONAL
$inputs.Var.timezoneOffset = <System.Single>"
            );
        }

        // Create new GraphQL Query:
        // databaseLogReportingPropertiesForCluster(input: QueryReportPropertiesInput!): DbLogReportProperties!
        internal void InitQueryDatabaseLogReportingPropertiesForCluster()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "QueryReportPropertiesInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryDatabaseLogReportingPropertiesForCluster",
                "($input: QueryReportPropertiesInput!)",
                "DbLogReportProperties",
                Query.DatabaseLogReportingPropertiesForCluster_ObjectFieldSpec,
                Query.DatabaseLogReportingPropertiesForClusterFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	clusterUuid = <System.String>
}"
            );
        }

        // Create new GraphQL Query:
        // databaseLogReportForCluster(input: QueryLogReportInput!): DbLogReportSummaryListReply!
        internal void InitQueryDatabaseLogReportForCluster()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "QueryLogReportInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryDatabaseLogReportForCluster",
                "($input: QueryLogReportInput!)",
                "DbLogReportSummaryListReply",
                Query.DatabaseLogReportForCluster_ObjectFieldSpec,
                Query.DatabaseLogReportForClusterFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# OPTIONAL
	name = <System.String>
	# OPTIONAL
	logBackupDelay = <System.Int32>
	# OPTIONAL
	limit = <System.Int32>
	# OPTIONAL
	offset = <System.Int32>
	# OPTIONAL
	effectiveSlaDomainId = <System.String>
	# OPTIONAL
	databaseType = <System.String>
	# OPTIONAL
	location = <System.String>
	# OPTIONAL
	sortBy = <V1QueryLogReportRequestSortBy> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.V1QueryLogReportRequestSortBy]) for enum values.
	# OPTIONAL
	sortOrder = <V1QueryLogReportRequestSortOrder> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.V1QueryLogReportRequestSortOrder]) for enum values.
	# REQUIRED
	clusterUuid = <System.String>
}"
            );
        }

        // Create new GraphQL Query:
        // allConnectedClusters(clusterFilterArg: ClusterTypeEnum): [DataLocationSupportedCluster!]!
        internal void InitQueryAllConnectedClusters()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("clusterFilterArg", "ClusterTypeEnum"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllConnectedClusters",
                "($clusterFilterArg: ClusterTypeEnum)",
                "List<DataLocationSupportedCluster>",
                Query.AllConnectedClusters_ObjectFieldSpec,
                Query.AllConnectedClustersFieldSpec,
                @"# OPTIONAL
$inputs.Var.clusterFilterArg = <ClusterTypeEnum> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ClusterTypeEnum]) for enum values."
            );
        }

        // Create new GraphQL Query:
        // allClusterReplicationTargets(clusterUuid: UUID!): [ClusterReplicationTarget!]!
        internal void InitQueryAllClusterReplicationTargets()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("clusterUuid", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllClusterReplicationTargets",
                "($clusterUuid: UUID!)",
                "List<ClusterReplicationTarget>",
                Query.AllClusterReplicationTargets_ObjectFieldSpec,
                Query.AllClusterReplicationTargetsFieldSpec,
                @"# REQUIRED
$inputs.Var.clusterUuid = <System.String>"
            );
        }

        // Create new GraphQL Query:
        // hostFailoverCluster(fid: UUID!): HostFailoverCluster!
        internal void InitQueryHostFailoverCluster()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryHostFailoverCluster",
                "($fid: UUID!)",
                "HostFailoverCluster",
                Query.HostFailoverCluster_ObjectFieldSpec,
                Query.HostFailoverClusterFieldSpec,
                @"# REQUIRED
$inputs.Var.fid = <System.String>"
            );
        }

        // Create new GraphQL Query:
        // k8sClusters(
        //     first: Int
        //     after: String
        //     sortBy: HierarchySortByField
        //     sortOrder: SortOrder
        //     filter: [Filter!]
        //   ): K8sClusterConnection!
        internal void InitQueryK8sClusters()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("sortBy", "HierarchySortByField"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("filter", "[Filter!]"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryK8sClusters",
                "($first: Int,$after: String,$sortBy: HierarchySortByField,$sortOrder: SortOrder,$filter: [Filter!])",
                "K8sClusterConnection",
                Query.K8sClusters_ObjectFieldSpec,
                Query.K8sClustersFieldSpec,
                @"# OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# OPTIONAL
$inputs.Var.sortBy = <HierarchySortByField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchySortByField]) for enum values.
# OPTIONAL
$inputs.Var.sortOrder = <SortOrder> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$inputs.Var.filter = @(
	@{
		# OPTIONAL
		field = <HierarchyFilterField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchyFilterField]) for enum values.
		# OPTIONAL
		texts = @(
			<System.String>
		)
		# OPTIONAL
		tagFilterParams = @(
			@{
				# OPTIONAL
				filterType = <TagFilterType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TagFilterType]) for enum values.
				# OPTIONAL
				tagKey = <System.String>
				# OPTIONAL
				tagValue = <System.String>
			}
		)
		# OPTIONAL
		objectTypeFilterParams = @(
			<ManagedObjectType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ManagedObjectType]) for enum values.
		)
		# OPTIONAL
		awsNativeProtectionFeatureNames = @(
			<AwsNativeProtectionFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		isNegative = <System.Boolean>
		# OPTIONAL
		isSlowSearchEnabled = <System.Boolean>
		# OPTIONAL
		azureNativeProtectionFeatureNames = @(
			<AzureNativeProtectionFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		unmanagedObjectAvailabilityFilter = @(
			<UnmanagedObjectAvailabilityFilter> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UnmanagedObjectAvailabilityFilter]) for enum values.
		)
}
)"
            );
        }

        // Create new GraphQL Query:
        // windowsCluster(fid: UUID!): WindowsCluster!
        internal void InitQueryWindowsCluster()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryWindowsCluster",
                "($fid: UUID!)",
                "WindowsCluster",
                Query.WindowsCluster_ObjectFieldSpec,
                Query.WindowsClusterFieldSpec,
                @"# REQUIRED
$inputs.Var.fid = <System.String>"
            );
        }

        // Create new GraphQL Query:
        // clusterReportMigrationStatus(
        //     clusterUuid: UUID
        //     status: [CdmReportMigrationStatus!]!
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //   ): ReportMigrationStatusConnection!
        internal void InitQueryClusterReportMigrationStatus()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("clusterUuid", "UUID"),
                Tuple.Create("status", "[CdmReportMigrationStatus!]!"),
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryClusterReportMigrationStatus",
                "($clusterUuid: UUID,$status: [CdmReportMigrationStatus!]!,$first: Int,$after: String,$last: Int,$before: String)",
                "ReportMigrationStatusConnection",
                Query.ClusterReportMigrationStatus_ObjectFieldSpec,
                Query.ClusterReportMigrationStatusFieldSpec,
                @"# OPTIONAL
$inputs.Var.clusterUuid = <System.String>
# REQUIRED
$inputs.Var.status = @(
	<CdmReportMigrationStatus> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CdmReportMigrationStatus]) for enum values.
)
# OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# OPTIONAL
$inputs.Var.last = <System.Int32>
# OPTIONAL
$inputs.Var.before = <System.String>"
            );
        }

        // Create new GraphQL Query:
        // clusterReportMigrationCount(clusterUuid: UUID, status: [CdmReportMigrationStatus!]!): ReportsMigrationCount!
        internal void InitQueryClusterReportMigrationCount()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("clusterUuid", "UUID"),
                Tuple.Create("status", "[CdmReportMigrationStatus!]!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryClusterReportMigrationCount",
                "($clusterUuid: UUID,$status: [CdmReportMigrationStatus!]!)",
                "ReportsMigrationCount",
                Query.ClusterReportMigrationCount_ObjectFieldSpec,
                Query.ClusterReportMigrationCountFieldSpec,
                @"# OPTIONAL
$inputs.Var.clusterUuid = <System.String>
# REQUIRED
$inputs.Var.status = @(
	<CdmReportMigrationStatus> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CdmReportMigrationStatus]) for enum values.
)"
            );
        }

        // Create new GraphQL Query:
        // clusterReportMigrationJobStatus(clusterUuid: UUID): ClusterReportMigrationJobStatus!
        internal void InitQueryClusterReportMigrationJobStatus()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("clusterUuid", "UUID"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryClusterReportMigrationJobStatus",
                "($clusterUuid: UUID)",
                "ClusterReportMigrationJobStatus",
                Query.ClusterReportMigrationJobStatus_ObjectFieldSpec,
                Query.ClusterReportMigrationJobStatusFieldSpec,
                @"# OPTIONAL
$inputs.Var.clusterUuid = <System.String>"
            );
        }

        // Create new GraphQL Query:
        // clusterSlaDomains(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //   ): ClusterSlaDomainConnection!
        internal void InitQueryClusterSlaDomains()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryClusterSlaDomains",
                "($first: Int,$after: String,$last: Int,$before: String)",
                "ClusterSlaDomainConnection",
                Query.ClusterSlaDomains_ObjectFieldSpec,
                Query.ClusterSlaDomainsFieldSpec,
                @"# OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# OPTIONAL
$inputs.Var.last = <System.Int32>
# OPTIONAL
$inputs.Var.before = <System.String>"
            );
        }

        // Create new GraphQL Query:
        // verifySlaWithReplicationToCluster(cdmClusterUUID: UUID!, includeArchived: Boolean!): VerifySlaWithReplicationToClusterResponse!
        internal void InitQueryVerifySlaWithReplicationToCluster()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("cdmClusterUUID", "UUID!"),
                Tuple.Create("includeArchived", "Boolean!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryVerifySlaWithReplicationToCluster",
                "($cdmClusterUUID: UUID!,$includeArchived: Boolean!)",
                "VerifySlaWithReplicationToClusterResponse",
                Query.VerifySlaWithReplicationToCluster_ObjectFieldSpec,
                Query.VerifySlaWithReplicationToClusterFieldSpec,
                @"# REQUIRED
$inputs.Var.cdmClusterUUID = <System.String>
# REQUIRED
$inputs.Var.includeArchived = <System.Boolean>"
            );
        }

        // Create new GraphQL Query:
        // allClusterGlobalSlas(cdmClusterUUID: UUID!): [SlaInfo!]!
        internal void InitQueryAllClusterGlobalSlas()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("cdmClusterUUID", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllClusterGlobalSlas",
                "($cdmClusterUUID: UUID!)",
                "List<SlaInfo>",
                Query.AllClusterGlobalSlas_ObjectFieldSpec,
                Query.AllClusterGlobalSlasFieldSpec,
                @"# REQUIRED
$inputs.Var.cdmClusterUUID = <System.String>"
            );
        }

        // Create new GraphQL Query:
        // clusterRegistrationProductInfo: ClusterRegistrationProductInfoType!
        internal void InitQueryClusterRegistrationProductInfo()
        {
            Tuple<string, string>[] argDefs = {
            };
            Initialize(
                argDefs,
                "query",
                "QueryClusterRegistrationProductInfo",
                "",
                "ClusterRegistrationProductInfoType",
                Query.ClusterRegistrationProductInfo_ObjectFieldSpec,
                Query.ClusterRegistrationProductInfoFieldSpec,
                @""
            );
        }

        // Create new GraphQL Query:
        // isTotpAckNecessaryForCluster(clusterUuid: UUID!): Boolean!
        internal void InitQueryIsTotpAckNecessaryForCluster()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("clusterUuid", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryIsTotpAckNecessaryForCluster",
                "($clusterUuid: UUID!)",
                "System.Boolean",
                Query.IsTotpAckNecessaryForCluster_ObjectFieldSpec,
                Query.IsTotpAckNecessaryForClusterFieldSpec,
                @"# REQUIRED
$inputs.Var.clusterUuid = <System.String>"
            );
        }

        // Create new GraphQL Query:
        // allClustersTotpAckStatus(listClusterUuid: [UUID!]!): [Boolean!]!
        internal void InitQueryAllClustersTotpAckStatus()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("listClusterUuid", "[UUID!]!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllClustersTotpAckStatus",
                "($listClusterUuid: [UUID!]!)",
                "List<System.Boolean>",
                Query.AllClustersTotpAckStatus_ObjectFieldSpec,
                Query.AllClustersTotpAckStatusFieldSpec,
                @"# REQUIRED
$inputs.Var.listClusterUuid = @(
	<System.String>
)"
            );
        }


    } // class New_RscQueryCluster
}