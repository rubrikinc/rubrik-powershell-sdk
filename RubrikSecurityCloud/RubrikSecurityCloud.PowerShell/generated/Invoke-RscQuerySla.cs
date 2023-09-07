// Invoke-RscQuerySla.cs
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
    /// SLA queries
    /// </summary>
    /// <description>
    /// Invoke-RscQuerySla is a master cmdlet for Sla work that can invoke any of the following subcommands: AllIofilterStatuses, AllCdpVmNames, Domains, DomainWithWarningsList, GlobalFilterList, Domain, DomainWithWarnings, ArchivalValidationWarnings, CountOfObjectsProtected, AuditDetail, AllSummariesByIds, GlobalStatuses, ProtectedClustersForGlobal, ConflictObjects, ManagedVolumes, ManagedVolume, ClusterDomains, ClusterDomainFilterList, VerifyWithReplicationToCluster, DownloadWithReplicationCsv, AllClusterGlobals, AllNcdComplianceData.
    /// </description>
    /// <example>
    /// <code>Invoke-RscQuerySla -AllIofilterStatuses [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscQuerySla -AllCdpVmNames [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscQuerySla -Domains [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscQuerySla -DomainWithWarningsList [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscQuerySla -GlobalFilterList [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscQuerySla -Domain [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscQuerySla -DomainWithWarnings [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscQuerySla -ArchivalValidationWarnings [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscQuerySla -CountOfObjectsProtected [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscQuerySla -AuditDetail [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscQuerySla -AllSummariesByIds [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscQuerySla -GlobalStatuses [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscQuerySla -ProtectedClustersForGlobal [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscQuerySla -ConflictObjects [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscQuerySla -ManagedVolumes [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscQuerySla -ManagedVolume [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscQuerySla -ClusterDomains [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscQuerySla -ClusterDomainFilterList [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscQuerySla -VerifyWithReplicationToCluster [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscQuerySla -DownloadWithReplicationCsv [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscQuerySla -AllClusterGlobals [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscQuerySla -AllNcdComplianceData [-Arg ..] [-Field ..]</code>
    /// </example>
    [Cmdlet(
        "Invoke",
        "RscQuerySla",
        DefaultParameterSetName = "Domain")
    ]
    public class Invoke_RscQuerySla : RscPSCmdlet
    {
        
        /// <summary>
        /// AllIofilterStatuses parameter set
        ///
        /// [GraphQL: allSlaIofilterStatuses]
        /// </summary>
        [Parameter(
            ParameterSetName = "AllIofilterStatuses",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"The iofilter installation status of the compute clusters related to this SLA Domain.
[GraphQL: allSlaIofilterStatuses]",
            Position = 0
        )]
        public SwitchParameter AllIofilterStatuses { get; set; }

        
        /// <summary>
        /// AllCdpVmNames parameter set
        ///
        /// [GraphQL: allCdpSlaVmNames]
        /// </summary>
        [Parameter(
            ParameterSetName = "AllCdpVmNames",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Names of the virtual machines in compute cluster with Continuous Data Protection (CDP) SLA Domain.
[GraphQL: allCdpSlaVmNames]",
            Position = 0
        )]
        public SwitchParameter AllCdpVmNames { get; set; }

        
        /// <summary>
        /// Domains parameter set
        ///
        /// [GraphQL: slaDomains]
        /// </summary>
        [Parameter(
            ParameterSetName = "Domains",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Retrieves a list of SLA Domains.
[GraphQL: slaDomains]",
            Position = 0
        )]
        public SwitchParameter Domains { get; set; }

        
        /// <summary>
        /// DomainWithWarningsList parameter set
        ///
        /// [GraphQL: slaDomainWithWarningsList]
        /// </summary>
        [Parameter(
            ParameterSetName = "DomainWithWarningsList",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Query sla list with warnings
[GraphQL: slaDomainWithWarningsList]",
            Position = 0
        )]
        public SwitchParameter DomainWithWarningsList { get; set; }

        
        /// <summary>
        /// GlobalFilterList parameter set
        ///
        /// [GraphQL: globalSlaFilterConnection]
        /// </summary>
        [Parameter(
            ParameterSetName = "GlobalFilterList",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Retrieves a list of SLA Domains.
[GraphQL: globalSlaFilterConnection]",
            Position = 0
        )]
        public SwitchParameter GlobalFilterList { get; set; }

        
        /// <summary>
        /// Domain parameter set
        ///
        /// [GraphQL: slaDomain]
        /// </summary>
        [Parameter(
            ParameterSetName = "Domain",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Query that retrieves an SLA Domain.
[GraphQL: slaDomain]",
            Position = 0
        )]
        public SwitchParameter Domain { get; set; }

        
        /// <summary>
        /// DomainWithWarnings parameter set
        ///
        /// [GraphQL: slaDomainWithWarnings]
        /// </summary>
        [Parameter(
            ParameterSetName = "DomainWithWarnings",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"
[GraphQL: slaDomainWithWarnings]",
            Position = 0
        )]
        public SwitchParameter DomainWithWarnings { get; set; }

        
        /// <summary>
        /// ArchivalValidationWarnings parameter set
        ///
        /// [GraphQL: slaArchivalValidationWarnings]
        /// </summary>
        [Parameter(
            ParameterSetName = "ArchivalValidationWarnings",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"SLA Domain warnings related to non-compliant archival retention duration in the archival policy.
[GraphQL: slaArchivalValidationWarnings]",
            Position = 0
        )]
        public SwitchParameter ArchivalValidationWarnings { get; set; }

        
        /// <summary>
        /// CountOfObjectsProtected parameter set
        ///
        /// [GraphQL: countOfObjectsProtectedBySlas]
        /// </summary>
        [Parameter(
            ParameterSetName = "CountOfObjectsProtected",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"The number of objects protected by the SLA Domains.
[GraphQL: countOfObjectsProtectedBySlas]",
            Position = 0
        )]
        public SwitchParameter CountOfObjectsProtected { get; set; }

        
        /// <summary>
        /// AuditDetail parameter set
        ///
        /// [GraphQL: slaAuditDetail]
        /// </summary>
        [Parameter(
            ParameterSetName = "AuditDetail",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"List of audit details for a given SLA Domain.
[GraphQL: slaAuditDetail]",
            Position = 0
        )]
        public SwitchParameter AuditDetail { get; set; }

        
        /// <summary>
        /// AllSummariesByIds parameter set
        ///
        /// [GraphQL: allSlaSummariesByIds]
        /// </summary>
        [Parameter(
            ParameterSetName = "AllSummariesByIds",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"List of SLA Domain summaries for the given IDs.
[GraphQL: allSlaSummariesByIds]",
            Position = 0
        )]
        public SwitchParameter AllSummariesByIds { get; set; }

        
        /// <summary>
        /// GlobalStatuses parameter set
        ///
        /// [GraphQL: globalSlaStatuses]
        /// </summary>
        [Parameter(
            ParameterSetName = "GlobalStatuses",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Status on the clusters where global SLA is synced.
[GraphQL: globalSlaStatuses]",
            Position = 0
        )]
        public SwitchParameter GlobalStatuses { get; set; }

        
        /// <summary>
        /// ProtectedClustersForGlobal parameter set
        ///
        /// [GraphQL: protectedClustersForGlobalSla]
        /// </summary>
        [Parameter(
            ParameterSetName = "ProtectedClustersForGlobal",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Clusters that have object(s) protected by global SLA.
[GraphQL: protectedClustersForGlobalSla]",
            Position = 0
        )]
        public SwitchParameter ProtectedClustersForGlobal { get; set; }

        
        /// <summary>
        /// ConflictObjects parameter set
        ///
        /// [GraphQL: slaConflictObjects]
        /// </summary>
        [Parameter(
            ParameterSetName = "ConflictObjects",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"
[GraphQL: slaConflictObjects]",
            Position = 0
        )]
        public SwitchParameter ConflictObjects { get; set; }

        
        /// <summary>
        /// ManagedVolumes parameter set
        ///
        /// [GraphQL: slaManagedVolumes]
        /// </summary>
        [Parameter(
            ParameterSetName = "ManagedVolumes",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Paginated list of SLA Managed Volumes.
[GraphQL: slaManagedVolumes]",
            Position = 0
        )]
        public SwitchParameter ManagedVolumes { get; set; }

        
        /// <summary>
        /// ManagedVolume parameter set
        ///
        /// [GraphQL: slaManagedVolume]
        /// </summary>
        [Parameter(
            ParameterSetName = "ManagedVolume",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Details of a SLA Managed Volume object.
[GraphQL: slaManagedVolume]",
            Position = 0
        )]
        public SwitchParameter ManagedVolume { get; set; }

        
        /// <summary>
        /// ClusterDomains parameter set
        ///
        /// [GraphQL: clusterSlaDomains]
        /// </summary>
        [Parameter(
            ParameterSetName = "ClusterDomains",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Returns paginated list of SLA domains that were created on Rubrik CDM.
[GraphQL: clusterSlaDomains]",
            Position = 0
        )]
        public SwitchParameter ClusterDomains { get; set; }

        
        /// <summary>
        /// ClusterDomainFilterList parameter set
        ///
        /// [GraphQL: clusterSlaDomainFilterConnection]
        /// </summary>
        [Parameter(
            ParameterSetName = "ClusterDomainFilterList",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"
[GraphQL: clusterSlaDomainFilterConnection]",
            Position = 0
        )]
        public SwitchParameter ClusterDomainFilterList { get; set; }

        
        /// <summary>
        /// VerifyWithReplicationToCluster parameter set
        ///
        /// [GraphQL: verifySlaWithReplicationToCluster]
        /// </summary>
        [Parameter(
            ParameterSetName = "VerifyWithReplicationToCluster",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Verify for a Rubrik cluster if it is replication target in any SLA Domain.
[GraphQL: verifySlaWithReplicationToCluster]",
            Position = 0
        )]
        public SwitchParameter VerifyWithReplicationToCluster { get; set; }

        
        /// <summary>
        /// DownloadWithReplicationCsv parameter set
        ///
        /// [GraphQL: downloadSlaWithReplicationCsv]
        /// </summary>
        [Parameter(
            ParameterSetName = "DownloadWithReplicationCsv",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Download list of Global SLA CSV that have Replication to the given Rubrik Cluster.
[GraphQL: downloadSlaWithReplicationCsv]",
            Position = 0
        )]
        public SwitchParameter DownloadWithReplicationCsv { get; set; }

        
        /// <summary>
        /// AllClusterGlobals parameter set
        ///
        /// [GraphQL: allClusterGlobalSlas]
        /// </summary>
        [Parameter(
            ParameterSetName = "AllClusterGlobals",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Global SLA Domains protecting at least one object on the specified Rubrik cluster.
[GraphQL: allClusterGlobalSlas]",
            Position = 0
        )]
        public SwitchParameter AllClusterGlobals { get; set; }

        
        /// <summary>
        /// AllNcdComplianceData parameter set
        ///
        /// [GraphQL: allNcdSlaComplianceData]
        /// </summary>
        [Parameter(
            ParameterSetName = "AllNcdComplianceData",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"NAS Cloud Direct SLA Domain compliance data for the requested clusters.
[GraphQL: allNcdSlaComplianceData]",
            Position = 0
        )]
        public SwitchParameter AllNcdComplianceData { get; set; }


// ignore warning 'Missing XML comment'
#pragma warning disable 1591
        protected override void ProcessRecord()
        {
            try
            {
                switch(Op)
                {
                    case "AllIofilterStatuses":
                        this.ProcessRecord_AllIofilterStatuses();
                        break;
                    case "AllCdpVmNames":
                        this.ProcessRecord_AllCdpVmNames();
                        break;
                    case "Domains":
                        this.ProcessRecord_Domains();
                        break;
                    case "DomainWithWarningsList":
                        this.ProcessRecord_DomainWithWarningsList();
                        break;
                    case "GlobalFilterList":
                        this.ProcessRecord_GlobalFilterList();
                        break;
                    case "Domain":
                        this.ProcessRecord_Domain();
                        break;
                    case "DomainWithWarnings":
                        this.ProcessRecord_DomainWithWarnings();
                        break;
                    case "ArchivalValidationWarnings":
                        this.ProcessRecord_ArchivalValidationWarnings();
                        break;
                    case "CountOfObjectsProtected":
                        this.ProcessRecord_CountOfObjectsProtected();
                        break;
                    case "AuditDetail":
                        this.ProcessRecord_AuditDetail();
                        break;
                    case "AllSummariesByIds":
                        this.ProcessRecord_AllSummariesByIds();
                        break;
                    case "GlobalStatuses":
                        this.ProcessRecord_GlobalStatuses();
                        break;
                    case "ProtectedClustersForGlobal":
                        this.ProcessRecord_ProtectedClustersForGlobal();
                        break;
                    case "ConflictObjects":
                        this.ProcessRecord_ConflictObjects();
                        break;
                    case "ManagedVolumes":
                        this.ProcessRecord_ManagedVolumes();
                        break;
                    case "ManagedVolume":
                        this.ProcessRecord_ManagedVolume();
                        break;
                    case "ClusterDomains":
                        this.ProcessRecord_ClusterDomains();
                        break;
                    case "ClusterDomainFilterList":
                        this.ProcessRecord_ClusterDomainFilterList();
                        break;
                    case "VerifyWithReplicationToCluster":
                        this.ProcessRecord_VerifyWithReplicationToCluster();
                        break;
                    case "DownloadWithReplicationCsv":
                        this.ProcessRecord_DownloadWithReplicationCsv();
                        break;
                    case "AllClusterGlobals":
                        this.ProcessRecord_AllClusterGlobals();
                        break;
                    case "AllNcdComplianceData":
                        this.ProcessRecord_AllNcdComplianceData();
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
        // allSlaIofilterStatuses.
        internal void ProcessRecord_AllIofilterStatuses()
        {
            this._logger.name += " -AllIofilterStatuses";
            // Invoke graphql operation allSlaIofilterStatuses
            InvokeQueryAllSlaIofilterStatuses();
        }

        // This parameter set invokes a single graphql operation:
        // allCdpSlaVmNames.
        internal void ProcessRecord_AllCdpVmNames()
        {
            this._logger.name += " -AllCdpVmNames";
            // Invoke graphql operation allCdpSlaVmNames
            InvokeQueryAllCdpSlaVmNames();
        }

        // This parameter set invokes a single graphql operation:
        // slaDomains.
        internal void ProcessRecord_Domains()
        {
            this._logger.name += " -Domains";
            // Invoke graphql operation slaDomains
            InvokeQuerySlaDomains();
        }

        // This parameter set invokes a single graphql operation:
        // slaDomainWithWarningsList.
        internal void ProcessRecord_DomainWithWarningsList()
        {
            this._logger.name += " -DomainWithWarningsList";
            // Invoke graphql operation slaDomainWithWarningsList
            InvokeQuerySlaDomainWithWarningsList();
        }

        // This parameter set invokes a single graphql operation:
        // globalSlaFilterConnection.
        internal void ProcessRecord_GlobalFilterList()
        {
            this._logger.name += " -GlobalFilterList";
            // Invoke graphql operation globalSlaFilterConnection
            InvokeQueryGlobalSlaFilterConnection();
        }

        // This parameter set invokes a single graphql operation:
        // slaDomain.
        internal void ProcessRecord_Domain()
        {
            this._logger.name += " -Domain";
            // Invoke graphql operation slaDomain
            InvokeQuerySlaDomain();
        }

        // This parameter set invokes a single graphql operation:
        // slaDomainWithWarnings.
        internal void ProcessRecord_DomainWithWarnings()
        {
            this._logger.name += " -DomainWithWarnings";
            // Invoke graphql operation slaDomainWithWarnings
            InvokeQuerySlaDomainWithWarnings();
        }

        // This parameter set invokes a single graphql operation:
        // slaArchivalValidationWarnings.
        internal void ProcessRecord_ArchivalValidationWarnings()
        {
            this._logger.name += " -ArchivalValidationWarnings";
            // Invoke graphql operation slaArchivalValidationWarnings
            InvokeQuerySlaArchivalValidationWarnings();
        }

        // This parameter set invokes a single graphql operation:
        // countOfObjectsProtectedBySlas.
        internal void ProcessRecord_CountOfObjectsProtected()
        {
            this._logger.name += " -CountOfObjectsProtected";
            // Invoke graphql operation countOfObjectsProtectedBySlas
            InvokeQueryCountOfObjectsProtectedBySlas();
        }

        // This parameter set invokes a single graphql operation:
        // slaAuditDetail.
        internal void ProcessRecord_AuditDetail()
        {
            this._logger.name += " -AuditDetail";
            // Invoke graphql operation slaAuditDetail
            InvokeQuerySlaAuditDetail();
        }

        // This parameter set invokes a single graphql operation:
        // allSlaSummariesByIds.
        internal void ProcessRecord_AllSummariesByIds()
        {
            this._logger.name += " -AllSummariesByIds";
            // Invoke graphql operation allSlaSummariesByIds
            InvokeQueryAllSlaSummariesByIds();
        }

        // This parameter set invokes a single graphql operation:
        // globalSlaStatuses.
        internal void ProcessRecord_GlobalStatuses()
        {
            this._logger.name += " -GlobalStatuses";
            // Invoke graphql operation globalSlaStatuses
            InvokeQueryGlobalSlaStatuses();
        }

        // This parameter set invokes a single graphql operation:
        // protectedClustersForGlobalSla.
        internal void ProcessRecord_ProtectedClustersForGlobal()
        {
            this._logger.name += " -ProtectedClustersForGlobal";
            // Invoke graphql operation protectedClustersForGlobalSla
            InvokeQueryProtectedClustersForGlobalSla();
        }

        // This parameter set invokes a single graphql operation:
        // slaConflictObjects.
        internal void ProcessRecord_ConflictObjects()
        {
            this._logger.name += " -ConflictObjects";
            // Invoke graphql operation slaConflictObjects
            InvokeQuerySlaConflictObjects();
        }

        // This parameter set invokes a single graphql operation:
        // slaManagedVolumes.
        internal void ProcessRecord_ManagedVolumes()
        {
            this._logger.name += " -ManagedVolumes";
            // Invoke graphql operation slaManagedVolumes
            InvokeQuerySlaManagedVolumes();
        }

        // This parameter set invokes a single graphql operation:
        // slaManagedVolume.
        internal void ProcessRecord_ManagedVolume()
        {
            this._logger.name += " -ManagedVolume";
            // Invoke graphql operation slaManagedVolume
            InvokeQuerySlaManagedVolume();
        }

        // This parameter set invokes a single graphql operation:
        // clusterSlaDomains.
        internal void ProcessRecord_ClusterDomains()
        {
            this._logger.name += " -ClusterDomains";
            // Invoke graphql operation clusterSlaDomains
            InvokeQueryClusterSlaDomains();
        }

        // This parameter set invokes a single graphql operation:
        // clusterSlaDomainFilterConnection.
        internal void ProcessRecord_ClusterDomainFilterList()
        {
            this._logger.name += " -ClusterDomainFilterList";
            // Invoke graphql operation clusterSlaDomainFilterConnection
            InvokeQueryClusterSlaDomainFilterConnection();
        }

        // This parameter set invokes a single graphql operation:
        // verifySlaWithReplicationToCluster.
        internal void ProcessRecord_VerifyWithReplicationToCluster()
        {
            this._logger.name += " -VerifyWithReplicationToCluster";
            // Invoke graphql operation verifySlaWithReplicationToCluster
            InvokeQueryVerifySlaWithReplicationToCluster();
        }

        // This parameter set invokes a single graphql operation:
        // downloadSlaWithReplicationCsv.
        internal void ProcessRecord_DownloadWithReplicationCsv()
        {
            this._logger.name += " -DownloadWithReplicationCsv";
            // Invoke graphql operation downloadSlaWithReplicationCsv
            InvokeQueryDownloadSlaWithReplicationCsv();
        }

        // This parameter set invokes a single graphql operation:
        // allClusterGlobalSlas.
        internal void ProcessRecord_AllClusterGlobals()
        {
            this._logger.name += " -AllClusterGlobals";
            // Invoke graphql operation allClusterGlobalSlas
            InvokeQueryAllClusterGlobalSlas();
        }

        // This parameter set invokes a single graphql operation:
        // allNcdSlaComplianceData.
        internal void ProcessRecord_AllNcdComplianceData()
        {
            this._logger.name += " -AllNcdComplianceData";
            // Invoke graphql operation allNcdSlaComplianceData
            InvokeQueryAllNcdSlaComplianceData();
        }


        // Invoke GraphQL Query:
        // allSlaIofilterStatuses(fid: UUID!): [ComputeClusterIofilterStatus!]!
        internal void InvokeQueryAllSlaIofilterStatuses()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllSlaIofilterStatuses",
                "($fid: UUID!)",
                "List<ComputeClusterIofilterStatus>"
                );
            List<ComputeClusterIofilterStatus>? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (List<ComputeClusterIofilterStatus>)this.Field;
            }
            string fieldSpecDoc = Query.AllSlaIofilterStatuses(ref fieldSpecObj);
            string inputExample = @"# REQUIRED
$inputs.Var.fid = <System.String>";
            BuildInput(fieldSpecObj, inputExample);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Query:
        // allCdpSlaVmNames(fid: UUID!): [String!]!
        internal void InvokeQueryAllCdpSlaVmNames()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllCdpSlaVmNames",
                "($fid: UUID!)",
                "List<System.String>"
                );
            List<System.String>? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (List<System.String>)this.Field;
            }
            string fieldSpecDoc = Query.AllCdpSlaVmNames(ref fieldSpecObj);
            string inputExample = @"# REQUIRED
$inputs.Var.fid = <System.String>";
            BuildInput(fieldSpecObj, inputExample);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Query:
        // slaDomains(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     sortBy: SlaQuerySortByField
        //     sortOrder: SortOrder
        //     filter: [GlobalSlaFilterInput!]
        //     contextFilter: ContextFilterTypeEnum
        //     contextFilterInput: [ContextFilterInputField!]
        //     shouldShowSyncStatus: Boolean = false
        //     shouldShowProtectedObjectCount: Boolean = false
        //     shouldShowUpgradeInfo: Boolean = false
        //     showRemoteSlas: Boolean
        //     shouldShowPausedClusters: Boolean = false
        //   ): SlaDomainConnection!
        internal void InvokeQuerySlaDomains()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("sortBy", "SlaQuerySortByField"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("filter", "[GlobalSlaFilterInput!]"),
                Tuple.Create("contextFilter", "ContextFilterTypeEnum"),
                Tuple.Create("contextFilterInput", "[ContextFilterInputField!]"),
                Tuple.Create("shouldShowSyncStatus", "Boolean"),
                Tuple.Create("shouldShowProtectedObjectCount", "Boolean"),
                Tuple.Create("shouldShowUpgradeInfo", "Boolean"),
                Tuple.Create("showRemoteSlas", "Boolean"),
                Tuple.Create("shouldShowPausedClusters", "Boolean"),
            };
            Initialize(
                argDefs,
                "query",
                "QuerySlaDomains",
                "($first: Int,$after: String,$last: Int,$before: String,$sortBy: SlaQuerySortByField,$sortOrder: SortOrder,$filter: [GlobalSlaFilterInput!],$contextFilter: ContextFilterTypeEnum,$contextFilterInput: [ContextFilterInputField!],$shouldShowSyncStatus: Boolean,$shouldShowProtectedObjectCount: Boolean,$shouldShowUpgradeInfo: Boolean,$showRemoteSlas: Boolean,$shouldShowPausedClusters: Boolean)",
                "SlaDomainConnection"
                );
            SlaDomainConnection? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (SlaDomainConnection)this.Field;
            }
            string fieldSpecDoc = Query.SlaDomains(ref fieldSpecObj);
            string inputExample = @"# OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# OPTIONAL
$inputs.Var.last = <System.Int32>
# OPTIONAL
$inputs.Var.before = <System.String>
# OPTIONAL
$inputs.Var.sortBy = <SlaQuerySortByField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SlaQuerySortByField]) for enum values.
# OPTIONAL
$inputs.Var.sortOrder = <SortOrder> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$inputs.Var.filter = @(
	@{
		# OPTIONAL
		field = <GlobalSlaQueryFilterInputField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.GlobalSlaQueryFilterInputField]) for enum values.
		# OPTIONAL
		text = <System.String>
		# OPTIONAL
		objectTypeList = @(
			<SlaObjectType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SlaObjectType]) for enum values.
		)
		# OPTIONAL
		textList = @(
			<System.String>
		)
}
)
# OPTIONAL
$inputs.Var.contextFilter = <ContextFilterTypeEnum> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ContextFilterTypeEnum]) for enum values.
# OPTIONAL
$inputs.Var.contextFilterInput = @(
	@{
		# REQUIRED
		field = <System.String>
		# REQUIRED
		text = <System.String>
}
)
# OPTIONAL
$inputs.Var.shouldShowSyncStatus = <System.Boolean>
# OPTIONAL
$inputs.Var.shouldShowProtectedObjectCount = <System.Boolean>
# OPTIONAL
$inputs.Var.shouldShowUpgradeInfo = <System.Boolean>
# OPTIONAL
$inputs.Var.showRemoteSlas = <System.Boolean>
# OPTIONAL
$inputs.Var.shouldShowPausedClusters = <System.Boolean>";
            BuildInput(fieldSpecObj, inputExample);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Query:
        // slaDomainWithWarningsList(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     sortBy: SlaQuerySortByField
        //     sortOrder: SortOrder
        //     filter: [GlobalSlaFilterInput!]
        //     contextFilter: ContextFilterTypeEnum
        //     objectIds: [UUID!]
        //     applicableSnappableTypes: [WorkloadLevelHierarchy!]
        //     snapshotIds: [UUID!]
        //     operation: SlaWarningsOperation
        //   ): [SlaDomainWithWarnings!]!
        internal void InvokeQuerySlaDomainWithWarningsList()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("sortBy", "SlaQuerySortByField"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("filter", "[GlobalSlaFilterInput!]"),
                Tuple.Create("contextFilter", "ContextFilterTypeEnum"),
                Tuple.Create("objectIds", "[UUID!]"),
                Tuple.Create("applicableSnappableTypes", "[WorkloadLevelHierarchy!]"),
                Tuple.Create("snapshotIds", "[UUID!]"),
                Tuple.Create("operation", "SlaWarningsOperation"),
            };
            Initialize(
                argDefs,
                "query",
                "QuerySlaDomainWithWarningsList",
                "($first: Int,$after: String,$last: Int,$before: String,$sortBy: SlaQuerySortByField,$sortOrder: SortOrder,$filter: [GlobalSlaFilterInput!],$contextFilter: ContextFilterTypeEnum,$objectIds: [UUID!],$applicableSnappableTypes: [WorkloadLevelHierarchy!],$snapshotIds: [UUID!],$operation: SlaWarningsOperation)",
                "List<SlaDomainWithWarnings>"
                );
            List<SlaDomainWithWarnings>? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (List<SlaDomainWithWarnings>)this.Field;
            }
            string fieldSpecDoc = Query.SlaDomainWithWarningsList(ref fieldSpecObj);
            string inputExample = @"# OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# OPTIONAL
$inputs.Var.last = <System.Int32>
# OPTIONAL
$inputs.Var.before = <System.String>
# OPTIONAL
$inputs.Var.sortBy = <SlaQuerySortByField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SlaQuerySortByField]) for enum values.
# OPTIONAL
$inputs.Var.sortOrder = <SortOrder> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$inputs.Var.filter = @(
	@{
		# OPTIONAL
		field = <GlobalSlaQueryFilterInputField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.GlobalSlaQueryFilterInputField]) for enum values.
		# OPTIONAL
		text = <System.String>
		# OPTIONAL
		objectTypeList = @(
			<SlaObjectType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SlaObjectType]) for enum values.
		)
		# OPTIONAL
		textList = @(
			<System.String>
		)
}
)
# OPTIONAL
$inputs.Var.contextFilter = <ContextFilterTypeEnum> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ContextFilterTypeEnum]) for enum values.
# OPTIONAL
$inputs.Var.objectIds = @(
	<System.String>
)
# OPTIONAL
$inputs.Var.applicableSnappableTypes = @(
	<WorkloadLevelHierarchy> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.WorkloadLevelHierarchy]) for enum values.
)
# OPTIONAL
$inputs.Var.snapshotIds = @(
	<System.String>
)
# OPTIONAL
$inputs.Var.operation = <SlaWarningsOperation> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SlaWarningsOperation]) for enum values.";
            BuildInput(fieldSpecObj, inputExample);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Query:
        // globalSlaFilterConnection(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     sortBy: SlaQuerySortByField
        //     sortOrder: SortOrder
        //     filter: [GlobalSlaFilterInput!]
        //     contextFilter: ContextFilterTypeEnum
        //     contextFilterInput: [ContextFilterInputField!]
        //     shouldShowSyncStatus: Boolean = false
        //     shouldShowProtectedObjectCount: Boolean = false
        //     shouldShowUpgradeInfo: Boolean = false
        //     showRemoteSlas: Boolean
        //     shouldShowPausedClusters: Boolean = false
        //   ): GlobalSlaForFilterConnection!
        internal void InvokeQueryGlobalSlaFilterConnection()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("sortBy", "SlaQuerySortByField"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("filter", "[GlobalSlaFilterInput!]"),
                Tuple.Create("contextFilter", "ContextFilterTypeEnum"),
                Tuple.Create("contextFilterInput", "[ContextFilterInputField!]"),
                Tuple.Create("shouldShowSyncStatus", "Boolean"),
                Tuple.Create("shouldShowProtectedObjectCount", "Boolean"),
                Tuple.Create("shouldShowUpgradeInfo", "Boolean"),
                Tuple.Create("showRemoteSlas", "Boolean"),
                Tuple.Create("shouldShowPausedClusters", "Boolean"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryGlobalSlaFilterConnection",
                "($first: Int,$after: String,$last: Int,$before: String,$sortBy: SlaQuerySortByField,$sortOrder: SortOrder,$filter: [GlobalSlaFilterInput!],$contextFilter: ContextFilterTypeEnum,$contextFilterInput: [ContextFilterInputField!],$shouldShowSyncStatus: Boolean,$shouldShowProtectedObjectCount: Boolean,$shouldShowUpgradeInfo: Boolean,$showRemoteSlas: Boolean,$shouldShowPausedClusters: Boolean)",
                "GlobalSlaForFilterConnection"
                );
            GlobalSlaForFilterConnection? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (GlobalSlaForFilterConnection)this.Field;
            }
            string fieldSpecDoc = Query.GlobalSlaFilterConnection(ref fieldSpecObj);
            string inputExample = @"# OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# OPTIONAL
$inputs.Var.last = <System.Int32>
# OPTIONAL
$inputs.Var.before = <System.String>
# OPTIONAL
$inputs.Var.sortBy = <SlaQuerySortByField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SlaQuerySortByField]) for enum values.
# OPTIONAL
$inputs.Var.sortOrder = <SortOrder> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$inputs.Var.filter = @(
	@{
		# OPTIONAL
		field = <GlobalSlaQueryFilterInputField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.GlobalSlaQueryFilterInputField]) for enum values.
		# OPTIONAL
		text = <System.String>
		# OPTIONAL
		objectTypeList = @(
			<SlaObjectType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SlaObjectType]) for enum values.
		)
		# OPTIONAL
		textList = @(
			<System.String>
		)
}
)
# OPTIONAL
$inputs.Var.contextFilter = <ContextFilterTypeEnum> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ContextFilterTypeEnum]) for enum values.
# OPTIONAL
$inputs.Var.contextFilterInput = @(
	@{
		# REQUIRED
		field = <System.String>
		# REQUIRED
		text = <System.String>
}
)
# OPTIONAL
$inputs.Var.shouldShowSyncStatus = <System.Boolean>
# OPTIONAL
$inputs.Var.shouldShowProtectedObjectCount = <System.Boolean>
# OPTIONAL
$inputs.Var.shouldShowUpgradeInfo = <System.Boolean>
# OPTIONAL
$inputs.Var.showRemoteSlas = <System.Boolean>
# OPTIONAL
$inputs.Var.shouldShowPausedClusters = <System.Boolean>";
            BuildInput(fieldSpecObj, inputExample);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Query:
        // slaDomain(
        //     id: UUID!
        //     shouldShowSyncStatus: Boolean = false
        //     shouldShowUpgradeInfo: Boolean = false
        //     shouldShowPausedClusters: Boolean = false
        //   ): SlaDomain!
        internal void InvokeQuerySlaDomain()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("id", "UUID!"),
                Tuple.Create("shouldShowSyncStatus", "Boolean"),
                Tuple.Create("shouldShowUpgradeInfo", "Boolean"),
                Tuple.Create("shouldShowPausedClusters", "Boolean"),
            };
            Initialize(
                argDefs,
                "query",
                "QuerySlaDomain",
                "($id: UUID!,$shouldShowSyncStatus: Boolean,$shouldShowUpgradeInfo: Boolean,$shouldShowPausedClusters: Boolean)",
                "SlaDomain"
                );
            SlaDomain? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (SlaDomain)this.Field;
            }
            string fieldSpecDoc = Query.SlaDomain(ref fieldSpecObj);
            string inputExample = @"# REQUIRED
$inputs.Var.id = <System.String>
# OPTIONAL
$inputs.Var.shouldShowSyncStatus = <System.Boolean>
# OPTIONAL
$inputs.Var.shouldShowUpgradeInfo = <System.Boolean>
# OPTIONAL
$inputs.Var.shouldShowPausedClusters = <System.Boolean>";
            BuildInput(fieldSpecObj, inputExample);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Query:
        // slaDomainWithWarnings(id: UUID!, objectIds: [UUID!]!, applicableSnappableTypes: [WorkloadLevelHierarchy!]): SlaDomainWithWarnings!
        internal void InvokeQuerySlaDomainWithWarnings()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("id", "UUID!"),
                Tuple.Create("objectIds", "[UUID!]!"),
                Tuple.Create("applicableSnappableTypes", "[WorkloadLevelHierarchy!]"),
            };
            Initialize(
                argDefs,
                "query",
                "QuerySlaDomainWithWarnings",
                "($id: UUID!,$objectIds: [UUID!]!,$applicableSnappableTypes: [WorkloadLevelHierarchy!])",
                "SlaDomainWithWarnings"
                );
            SlaDomainWithWarnings? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (SlaDomainWithWarnings)this.Field;
            }
            string fieldSpecDoc = Query.SlaDomainWithWarnings(ref fieldSpecObj);
            string inputExample = @"# REQUIRED
$inputs.Var.id = <System.String>
# REQUIRED
$inputs.Var.objectIds = @(
	<System.String>
)
# OPTIONAL
$inputs.Var.applicableSnappableTypes = @(
	<WorkloadLevelHierarchy> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.WorkloadLevelHierarchy]) for enum values.
)";
            BuildInput(fieldSpecObj, inputExample);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Query:
        // slaArchivalValidationWarnings(input: SlaArchivalWarningsInput!): SlaArchivalValidationWithWarnings!
        internal void InvokeQuerySlaArchivalValidationWarnings()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "SlaArchivalWarningsInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QuerySlaArchivalValidationWarnings",
                "($input: SlaArchivalWarningsInput!)",
                "SlaArchivalValidationWithWarnings"
                );
            SlaArchivalValidationWithWarnings? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (SlaArchivalValidationWithWarnings)this.Field;
            }
            string fieldSpecDoc = Query.SlaArchivalValidationWarnings(ref fieldSpecObj);
            string inputExample = @"# REQUIRED
$inputs.Var.input = @{
	# OPTIONAL
	snapshotSchedule = @{
		# OPTIONAL
		minute = @{
			# OPTIONAL
			basicSchedule = @{
				# OPTIONAL
				frequency = <System.Int32>
				# OPTIONAL
				retention = <System.Int32>
				# OPTIONAL
				retentionUnit = <RetentionUnit> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			}
		}
		# OPTIONAL
		hourly = @{
			# OPTIONAL
			basicSchedule = @{
				# OPTIONAL
				frequency = <System.Int32>
				# OPTIONAL
				retention = <System.Int32>
				# OPTIONAL
				retentionUnit = <RetentionUnit> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			}
		}
		# OPTIONAL
		daily = @{
			# OPTIONAL
			basicSchedule = @{
				# OPTIONAL
				frequency = <System.Int32>
				# OPTIONAL
				retention = <System.Int32>
				# OPTIONAL
				retentionUnit = <RetentionUnit> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			}
		}
		# OPTIONAL
		weekly = @{
			# OPTIONAL
			basicSchedule = @{
				# OPTIONAL
				frequency = <System.Int32>
				# OPTIONAL
				retention = <System.Int32>
				# OPTIONAL
				retentionUnit = <RetentionUnit> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			}
			# OPTIONAL
			dayOfWeek = <DayOfWeek> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DayOfWeek]) for enum values.
		}
		# OPTIONAL
		monthly = @{
			# OPTIONAL
			basicSchedule = @{
				# OPTIONAL
				frequency = <System.Int32>
				# OPTIONAL
				retention = <System.Int32>
				# OPTIONAL
				retentionUnit = <RetentionUnit> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			}
			# OPTIONAL
			dayOfMonth = <DayOfMonth> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DayOfMonth]) for enum values.
		}
		# OPTIONAL
		quarterly = @{
			# OPTIONAL
			basicSchedule = @{
				# OPTIONAL
				frequency = <System.Int32>
				# OPTIONAL
				retention = <System.Int32>
				# OPTIONAL
				retentionUnit = <RetentionUnit> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			}
			# OPTIONAL
			dayOfQuarter = <DayOfQuarter> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DayOfQuarter]) for enum values.
			# OPTIONAL
			quarterStartMonth = <Month> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.Month]) for enum values.
		}
		# OPTIONAL
		yearly = @{
			# OPTIONAL
			basicSchedule = @{
				# OPTIONAL
				frequency = <System.Int32>
				# OPTIONAL
				retention = <System.Int32>
				# OPTIONAL
				retentionUnit = <RetentionUnit> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			}
			# OPTIONAL
			dayOfYear = <DayOfYear> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DayOfYear]) for enum values.
			# OPTIONAL
			yearStartMonth = <Month> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.Month]) for enum values.
		}
	}
	# OPTIONAL
	archivalThreshold = <System.Int32>
	# OPTIONAL
	archivalThresholdUnit = <RetentionUnit> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
	# OPTIONAL
	archivalGroupId = <System.String>
	# OPTIONAL
	archivalLocationToClusterMapping = @(
		@{
			# OPTIONAL
			clusterUuid = <System.String>
			# OPTIONAL
			locationId = <System.String>
		}
	)
	# OPTIONAL
	frequencies = @(
		<RetentionUnit> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
	)
}";
            BuildInput(fieldSpecObj, inputExample);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Query:
        // countOfObjectsProtectedBySlas(
        //     rootOptionalFid: UUID
        //     slaIds: [UUID!]!
        //     filter: [Filter!]
        //     typeFilter: [HierarchyObjectTypeEnum!]
        //   ): CountOfObjectsProtectedBySLAsResult!
        internal void InvokeQueryCountOfObjectsProtectedBySlas()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("rootOptionalFid", "UUID"),
                Tuple.Create("slaIds", "[UUID!]!"),
                Tuple.Create("filter", "[Filter!]"),
                Tuple.Create("typeFilter", "[HierarchyObjectTypeEnum!]"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryCountOfObjectsProtectedBySlas",
                "($rootOptionalFid: UUID,$slaIds: [UUID!]!,$filter: [Filter!],$typeFilter: [HierarchyObjectTypeEnum!])",
                "CountOfObjectsProtectedBySlAsResult"
                );
            CountOfObjectsProtectedBySlAsResult? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (CountOfObjectsProtectedBySlAsResult)this.Field;
            }
            string fieldSpecDoc = Query.CountOfObjectsProtectedBySlas(ref fieldSpecObj);
            string inputExample = @"# OPTIONAL
$inputs.Var.rootOptionalFid = <System.String>
# REQUIRED
$inputs.Var.slaIds = @(
	<System.String>
)
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
)
# OPTIONAL
$inputs.Var.typeFilter = @(
	<HierarchyObjectTypeEnum> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchyObjectTypeEnum]) for enum values.
)";
            BuildInput(fieldSpecObj, inputExample);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Query:
        // slaAuditDetail(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     SlaId: UUID!
        //     filter: [SLAAuditDetailFilterInput!]
        //     timezone: String
        //   ): [SlaAuditDetail!]!
        internal void InvokeQuerySlaAuditDetail()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("SlaId", "UUID!"),
                Tuple.Create("filter", "[SLAAuditDetailFilterInput!]"),
                Tuple.Create("timezone", "String"),
            };
            Initialize(
                argDefs,
                "query",
                "QuerySlaAuditDetail",
                "($first: Int,$after: String,$last: Int,$before: String,$SlaId: UUID!,$filter: [SLAAuditDetailFilterInput!],$timezone: String)",
                "List<SlaAuditDetail>"
                );
            List<SlaAuditDetail>? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (List<SlaAuditDetail>)this.Field;
            }
            string fieldSpecDoc = Query.SlaAuditDetail(ref fieldSpecObj);
            string inputExample = @"# OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# OPTIONAL
$inputs.Var.last = <System.Int32>
# OPTIONAL
$inputs.Var.before = <System.String>
# REQUIRED
$inputs.Var.SlaId = <System.String>
# OPTIONAL
$inputs.Var.filter = @(
	@{
		# OPTIONAL
		field = <SLAAuditDetailFilterFieldEnum> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SLAAuditDetailFilterFieldEnum]) for enum values.
		# OPTIONAL
		text = <System.String>
}
)
# OPTIONAL
$inputs.Var.timezone = <System.String>";
            BuildInput(fieldSpecObj, inputExample);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Query:
        // allSlaSummariesByIds(slaIds: [UUID!]!): [SlaDomain!]!
        internal void InvokeQueryAllSlaSummariesByIds()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("slaIds", "[UUID!]!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllSlaSummariesByIds",
                "($slaIds: [UUID!]!)",
                "List<SlaDomain>"
                );
            List<SlaDomain>? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (List<SlaDomain>)this.Field;
            }
            string fieldSpecDoc = Query.AllSlaSummariesByIds(ref fieldSpecObj);
            string inputExample = @"# REQUIRED
$inputs.Var.slaIds = @(
	<System.String>
)";
            BuildInput(fieldSpecObj, inputExample);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Query:
        // globalSlaStatuses(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     filter: [SlaStatusFilterInput!]
        //     SlaId: UUID!
        //   ): GlobalSlaStatusConnection!
        internal void InvokeQueryGlobalSlaStatuses()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("filter", "[SlaStatusFilterInput!]"),
                Tuple.Create("SlaId", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryGlobalSlaStatuses",
                "($first: Int,$after: String,$last: Int,$before: String,$filter: [SlaStatusFilterInput!],$SlaId: UUID!)",
                "GlobalSlaStatusConnection"
                );
            GlobalSlaStatusConnection? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (GlobalSlaStatusConnection)this.Field;
            }
            string fieldSpecDoc = Query.GlobalSlaStatuses(ref fieldSpecObj);
            string inputExample = @"# OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# OPTIONAL
$inputs.Var.last = <System.Int32>
# OPTIONAL
$inputs.Var.before = <System.String>
# OPTIONAL
$inputs.Var.filter = @(
	@{
		# OPTIONAL
		field = <SlaStatusFilterField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SlaStatusFilterField]) for enum values.
		# OPTIONAL
		text = <System.String>
}
)
# REQUIRED
$inputs.Var.SlaId = <System.String>";
            BuildInput(fieldSpecObj, inputExample);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Query:
        // protectedClustersForGlobalSla(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     slaId: UUID!
        //   ): ClusterConnection!
        internal void InvokeQueryProtectedClustersForGlobalSla()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("slaId", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryProtectedClustersForGlobalSla",
                "($first: Int,$after: String,$last: Int,$before: String,$slaId: UUID!)",
                "ClusterConnection"
                );
            ClusterConnection? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (ClusterConnection)this.Field;
            }
            string fieldSpecDoc = Query.ProtectedClustersForGlobalSla(ref fieldSpecObj);
            string inputExample = @"# OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# OPTIONAL
$inputs.Var.last = <System.Int32>
# OPTIONAL
$inputs.Var.before = <System.String>
# REQUIRED
$inputs.Var.slaId = <System.String>";
            BuildInput(fieldSpecObj, inputExample);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Query:
        // slaConflictObjects(fids: [UUID!]!): [HierarchyObject!]!
        internal void InvokeQuerySlaConflictObjects()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fids", "[UUID!]!"),
            };
            Initialize(
                argDefs,
                "query",
                "QuerySlaConflictObjects",
                "($fids: [UUID!]!)",
                "List<HierarchyObject>"
                );
            List<HierarchyObject>? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (List<HierarchyObject>)this.Field;
            }
            string fieldSpecDoc = Query.SlaConflictObjects(ref fieldSpecObj);
            string inputExample = @"# REQUIRED
$inputs.Var.fids = @(
	<System.String>
)";
            BuildInput(fieldSpecObj, inputExample);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Query:
        // slaManagedVolumes(
        //     first: Int
        //     after: String
        //     sortBy: HierarchySortByField
        //     sortOrder: SortOrder
        //     filter: [Filter!]
        //   ): ManagedVolumeConnection!
        internal void InvokeQuerySlaManagedVolumes()
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
                "QuerySlaManagedVolumes",
                "($first: Int,$after: String,$sortBy: HierarchySortByField,$sortOrder: SortOrder,$filter: [Filter!])",
                "ManagedVolumeConnection"
                );
            ManagedVolumeConnection? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (ManagedVolumeConnection)this.Field;
            }
            string fieldSpecDoc = Query.SlaManagedVolumes(ref fieldSpecObj);
            string inputExample = @"# OPTIONAL
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
)";
            BuildInput(fieldSpecObj, inputExample);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Query:
        // slaManagedVolume(fid: UUID!): ManagedVolume!
        internal void InvokeQuerySlaManagedVolume()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QuerySlaManagedVolume",
                "($fid: UUID!)",
                "ManagedVolume"
                );
            ManagedVolume? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (ManagedVolume)this.Field;
            }
            string fieldSpecDoc = Query.SlaManagedVolume(ref fieldSpecObj);
            string inputExample = @"# REQUIRED
$inputs.Var.fid = <System.String>";
            BuildInput(fieldSpecObj, inputExample);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Query:
        // clusterSlaDomains(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //   ): ClusterSlaDomainConnection!
        internal void InvokeQueryClusterSlaDomains()
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
                "ClusterSlaDomainConnection"
                );
            ClusterSlaDomainConnection? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (ClusterSlaDomainConnection)this.Field;
            }
            string fieldSpecDoc = Query.ClusterSlaDomains(ref fieldSpecObj);
            string inputExample = @"# OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# OPTIONAL
$inputs.Var.last = <System.Int32>
# OPTIONAL
$inputs.Var.before = <System.String>";
            BuildInput(fieldSpecObj, inputExample);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Query:
        // clusterSlaDomainFilterConnection(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //   ): ClusterSlaDomainForFilterConnection!
        internal void InvokeQueryClusterSlaDomainFilterConnection()
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
                "QueryClusterSlaDomainFilterConnection",
                "($first: Int,$after: String,$last: Int,$before: String)",
                "ClusterSlaDomainForFilterConnection"
                );
            ClusterSlaDomainForFilterConnection? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (ClusterSlaDomainForFilterConnection)this.Field;
            }
            string fieldSpecDoc = Query.ClusterSlaDomainFilterConnection(ref fieldSpecObj);
            string inputExample = @"# OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# OPTIONAL
$inputs.Var.last = <System.Int32>
# OPTIONAL
$inputs.Var.before = <System.String>";
            BuildInput(fieldSpecObj, inputExample);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Query:
        // verifySlaWithReplicationToCluster(cdmClusterUUID: UUID!, includeArchived: Boolean!): VerifySlaWithReplicationToClusterResponse!
        internal void InvokeQueryVerifySlaWithReplicationToCluster()
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
                "VerifySlaWithReplicationToClusterResponse"
                );
            VerifySlaWithReplicationToClusterResponse? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (VerifySlaWithReplicationToClusterResponse)this.Field;
            }
            string fieldSpecDoc = Query.VerifySlaWithReplicationToCluster(ref fieldSpecObj);
            string inputExample = @"# REQUIRED
$inputs.Var.cdmClusterUUID = <System.String>
# REQUIRED
$inputs.Var.includeArchived = <System.Boolean>";
            BuildInput(fieldSpecObj, inputExample);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Query:
        // downloadSlaWithReplicationCsv(cdmClusterUUID: UUID!, includeArchived: Boolean!): DownloadSlaWithReplicationCsvReply!
        internal void InvokeQueryDownloadSlaWithReplicationCsv()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("cdmClusterUUID", "UUID!"),
                Tuple.Create("includeArchived", "Boolean!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryDownloadSlaWithReplicationCsv",
                "($cdmClusterUUID: UUID!,$includeArchived: Boolean!)",
                "DownloadSlaWithReplicationCsvReply"
                );
            DownloadSlaWithReplicationCsvReply? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (DownloadSlaWithReplicationCsvReply)this.Field;
            }
            string fieldSpecDoc = Query.DownloadSlaWithReplicationCsv(ref fieldSpecObj);
            string inputExample = @"# REQUIRED
$inputs.Var.cdmClusterUUID = <System.String>
# REQUIRED
$inputs.Var.includeArchived = <System.Boolean>";
            BuildInput(fieldSpecObj, inputExample);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Query:
        // allClusterGlobalSlas(cdmClusterUUID: UUID!): [SlaInfo!]!
        internal void InvokeQueryAllClusterGlobalSlas()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("cdmClusterUUID", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllClusterGlobalSlas",
                "($cdmClusterUUID: UUID!)",
                "List<SlaInfo>"
                );
            List<SlaInfo>? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (List<SlaInfo>)this.Field;
            }
            string fieldSpecDoc = Query.AllClusterGlobalSlas(ref fieldSpecObj);
            string inputExample = @"# REQUIRED
$inputs.Var.cdmClusterUUID = <System.String>";
            BuildInput(fieldSpecObj, inputExample);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Query:
        // allNcdSlaComplianceData(clusters: [UUID!]!): [NcdSlaComplianceData!]!
        internal void InvokeQueryAllNcdSlaComplianceData()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("clusters", "[UUID!]!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllNcdSlaComplianceData",
                "($clusters: [UUID!]!)",
                "List<NcdSlaComplianceData>"
                );
            List<NcdSlaComplianceData>? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (List<NcdSlaComplianceData>)this.Field;
            }
            string fieldSpecDoc = Query.AllNcdSlaComplianceData(ref fieldSpecObj);
            string inputExample = @"# REQUIRED
$inputs.Var.clusters = @(
	<System.String>
)";
            BuildInput(fieldSpecObj, inputExample);
            BuildRequest(fieldSpecDoc);
        }


    } // class Invoke_RscQuerySla
}