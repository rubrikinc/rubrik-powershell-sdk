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
    [Cmdlet(
        "Invoke",
        "RscQuerySla",
        DefaultParameterSetName = "Domain")
    ]
    public class Invoke_RscQuerySla : RscPSCmdlet
    {
        
        // -------------------------------------------------------------------
        // AllIofilterStatus parameter set
        //
        // [GraphQL: allSlaIofilterStatuses]
        //
        [Parameter(
            ParameterSetName = "AllIofilterStatus",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"The iofilter installation status of the compute clusters related to this SLA Domain.
[GraphQL: allSlaIofilterStatuses]",
            Position = 0
        )]
        public SwitchParameter AllIofilterStatus { get; set; }

        
        // -------------------------------------------------------------------
        // AllCdpVmName parameter set
        //
        // [GraphQL: allCdpSlaVmNames]
        //
        [Parameter(
            ParameterSetName = "AllCdpVmName",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Names of the virtual machines in compute cluster with Continuous Data Protection (CDP) SLA Domain.
[GraphQL: allCdpSlaVmNames]",
            Position = 0
        )]
        public SwitchParameter AllCdpVmName { get; set; }

        
        // -------------------------------------------------------------------
        // Domain parameter set
        //
        // [GraphQL: slaDomains]
        //
        [Parameter(
            ParameterSetName = "Domain",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Retrieves a list of SLA Domains.
[GraphQL: slaDomains]",
            Position = 0
        )]
        public SwitchParameter Domain { get; set; }

        
        // -------------------------------------------------------------------
        // DomainWithWarningsList parameter set
        //
        // [GraphQL: slaDomainWithWarningsList]
        //
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

        
        // -------------------------------------------------------------------
        // GlobalFilterList parameter set
        //
        // [GraphQL: globalSlaFilterConnection]
        //
        [Parameter(
            ParameterSetName = "GlobalFilterList",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"
[GraphQL: globalSlaFilterConnection]",
            Position = 0
        )]
        public SwitchParameter GlobalFilterList { get; set; }

        
        // -------------------------------------------------------------------
        // DomainWithWarning parameter set
        //
        // [GraphQL: slaDomainWithWarnings]
        //
        [Parameter(
            ParameterSetName = "DomainWithWarning",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"
[GraphQL: slaDomainWithWarnings]",
            Position = 0
        )]
        public SwitchParameter DomainWithWarning { get; set; }

        
        // -------------------------------------------------------------------
        // ArchivalValidationWarning parameter set
        //
        // [GraphQL: slaArchivalValidationWarnings]
        //
        [Parameter(
            ParameterSetName = "ArchivalValidationWarning",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"SLA Domain warnings related to non-compliant archival retention duration in the archival policy.
[GraphQL: slaArchivalValidationWarnings]",
            Position = 0
        )]
        public SwitchParameter ArchivalValidationWarning { get; set; }

        
        // -------------------------------------------------------------------
        // CountOfObjectsProtected parameter set
        //
        // [GraphQL: countOfObjectsProtectedBySlas]
        //
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

        
        // -------------------------------------------------------------------
        // AuditDetail parameter set
        //
        // [GraphQL: slaAuditDetail]
        //
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

        
        // -------------------------------------------------------------------
        // SummariesById parameter set
        //
        // [GraphQL: slaSummariesByIds]
        //
        [Parameter(
            ParameterSetName = "SummariesById",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"List of SLA summaries for the given ids
[GraphQL: slaSummariesByIds]",
            Position = 0
        )]
        public SwitchParameter SummariesById { get; set; }

        
        // -------------------------------------------------------------------
        // GlobalStatus parameter set
        //
        // [GraphQL: globalSlaStatuses]
        //
        [Parameter(
            ParameterSetName = "GlobalStatus",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Status on the clusters where global SLA is synced.
[GraphQL: globalSlaStatuses]",
            Position = 0
        )]
        public SwitchParameter GlobalStatus { get; set; }

        
        // -------------------------------------------------------------------
        // ProtectedClustersForGlobal parameter set
        //
        // [GraphQL: protectedClustersForGlobalSla]
        //
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

        
        // -------------------------------------------------------------------
        // ConflictObject parameter set
        //
        // [GraphQL: slaConflictObjects]
        //
        [Parameter(
            ParameterSetName = "ConflictObject",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"
[GraphQL: slaConflictObjects]",
            Position = 0
        )]
        public SwitchParameter ConflictObject { get; set; }

        
        // -------------------------------------------------------------------
        // ManagedVolume parameter set
        //
        // [GraphQL: slaManagedVolumes]
        //
        [Parameter(
            ParameterSetName = "ManagedVolume",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Paginated list of SLA Managed Volumes.
[GraphQL: slaManagedVolumes]",
            Position = 0
        )]
        public SwitchParameter ManagedVolume { get; set; }

        
        // -------------------------------------------------------------------
        // ClusterDomainList parameter set
        //
        // [GraphQL: clusterSlaDomainConnection]
        //
        [Parameter(
            ParameterSetName = "ClusterDomainList",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"
[GraphQL: clusterSlaDomainConnection]",
            Position = 0
        )]
        public SwitchParameter ClusterDomainList { get; set; }

        
        // -------------------------------------------------------------------
        // ClusterDomainFilterList parameter set
        //
        // [GraphQL: clusterSlaDomainFilterConnection]
        //
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

        
        // -------------------------------------------------------------------
        // VerifyWithReplicationToCluster parameter set
        //
        // [GraphQL: verifySLAWithReplicationToCluster]
        //
        [Parameter(
            ParameterSetName = "VerifyWithReplicationToCluster",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"
[GraphQL: verifySLAWithReplicationToCluster]",
            Position = 0
        )]
        public SwitchParameter VerifyWithReplicationToCluster { get; set; }

        
        // -------------------------------------------------------------------
        // DownloadWithReplicationCsv parameter set
        //
        // [GraphQL: downloadSlaWithReplicationCsv]
        //
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

        
        // -------------------------------------------------------------------
        // AllClusterGlobal parameter set
        //
        // [GraphQL: allClusterGlobalSlas]
        //
        [Parameter(
            ParameterSetName = "AllClusterGlobal",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Global SLA Domains protecting at least one object on the specified Rubrik cluster.
[GraphQL: allClusterGlobalSlas]",
            Position = 0
        )]
        public SwitchParameter AllClusterGlobal { get; set; }

        
        // -------------------------------------------------------------------
        // AllNcdComplianceData parameter set
        //
        // [GraphQL: allNcdSlaComplianceData]
        //
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


        protected override void ProcessRecord()
        {
            try
            {
                switch(Op)
                {
                    case "AllIofilterStatus":
                        this.ProcessRecord_AllIofilterStatus();
                        break;
                    case "AllCdpVmName":
                        this.ProcessRecord_AllCdpVmName();
                        break;
                    case "Domain":
                        this.ProcessRecord_Domain();
                        break;
                    case "DomainWithWarningsList":
                        this.ProcessRecord_DomainWithWarningsList();
                        break;
                    case "GlobalFilterList":
                        this.ProcessRecord_GlobalFilterList();
                        break;
                    case "DomainWithWarning":
                        this.ProcessRecord_DomainWithWarning();
                        break;
                    case "ArchivalValidationWarning":
                        this.ProcessRecord_ArchivalValidationWarning();
                        break;
                    case "CountOfObjectsProtected":
                        this.ProcessRecord_CountOfObjectsProtected();
                        break;
                    case "AuditDetail":
                        this.ProcessRecord_AuditDetail();
                        break;
                    case "SummariesById":
                        this.ProcessRecord_SummariesById();
                        break;
                    case "GlobalStatus":
                        this.ProcessRecord_GlobalStatus();
                        break;
                    case "ProtectedClustersForGlobal":
                        this.ProcessRecord_ProtectedClustersForGlobal();
                        break;
                    case "ConflictObject":
                        this.ProcessRecord_ConflictObject();
                        break;
                    case "ManagedVolume":
                        this.ProcessRecord_ManagedVolume();
                        break;
                    case "ClusterDomainList":
                        this.ProcessRecord_ClusterDomainList();
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
                    case "AllClusterGlobal":
                        this.ProcessRecord_AllClusterGlobal();
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

        // This parameter set invokes a single graphql operation:
        // allSlaIofilterStatuses.
        protected void ProcessRecord_AllIofilterStatus()
        {
            this._logger.name += " -AllIofilterStatus";
            // Invoke graphql operation allSlaIofilterStatuses
            InvokeQueryAllSlaIofilterStatuses();
        }

        // This parameter set invokes a single graphql operation:
        // allCdpSlaVmNames.
        protected void ProcessRecord_AllCdpVmName()
        {
            this._logger.name += " -AllCdpVmName";
            // Invoke graphql operation allCdpSlaVmNames
            InvokeQueryAllCdpSlaVmNames();
        }

        // This parameter set invokes a single graphql operation:
        // slaDomains.
        protected void ProcessRecord_Domain()
        {
            this._logger.name += " -Domain";
            // Invoke graphql operation slaDomains
            InvokeQuerySlaDomains();
        }

        // This parameter set invokes a single graphql operation:
        // slaDomainWithWarningsList.
        protected void ProcessRecord_DomainWithWarningsList()
        {
            this._logger.name += " -DomainWithWarningsList";
            // Invoke graphql operation slaDomainWithWarningsList
            InvokeQuerySlaDomainWithWarningsList();
        }

        // This parameter set invokes a single graphql operation:
        // globalSlaFilterConnection.
        protected void ProcessRecord_GlobalFilterList()
        {
            this._logger.name += " -GlobalFilterList";
            // Invoke graphql operation globalSlaFilterConnection
            InvokeQueryGlobalSlaFilterConnection();
        }

        // This parameter set invokes a single graphql operation:
        // slaDomainWithWarnings.
        protected void ProcessRecord_DomainWithWarning()
        {
            this._logger.name += " -DomainWithWarning";
            // Invoke graphql operation slaDomainWithWarnings
            InvokeQuerySlaDomainWithWarnings();
        }

        // This parameter set invokes a single graphql operation:
        // slaArchivalValidationWarnings.
        protected void ProcessRecord_ArchivalValidationWarning()
        {
            this._logger.name += " -ArchivalValidationWarning";
            // Invoke graphql operation slaArchivalValidationWarnings
            InvokeQuerySlaArchivalValidationWarnings();
        }

        // This parameter set invokes a single graphql operation:
        // countOfObjectsProtectedBySlas.
        protected void ProcessRecord_CountOfObjectsProtected()
        {
            this._logger.name += " -CountOfObjectsProtected";
            // Invoke graphql operation countOfObjectsProtectedBySlas
            InvokeQueryCountOfObjectsProtectedBySlas();
        }

        // This parameter set invokes a single graphql operation:
        // slaAuditDetail.
        protected void ProcessRecord_AuditDetail()
        {
            this._logger.name += " -AuditDetail";
            // Invoke graphql operation slaAuditDetail
            InvokeQuerySlaAuditDetail();
        }

        // This parameter set invokes a single graphql operation:
        // slaSummariesByIds.
        protected void ProcessRecord_SummariesById()
        {
            this._logger.name += " -SummariesById";
            // Invoke graphql operation slaSummariesByIds
            InvokeQuerySlaSummariesByIds();
        }

        // This parameter set invokes a single graphql operation:
        // globalSlaStatuses.
        protected void ProcessRecord_GlobalStatus()
        {
            this._logger.name += " -GlobalStatus";
            // Invoke graphql operation globalSlaStatuses
            InvokeQueryGlobalSlaStatuses();
        }

        // This parameter set invokes a single graphql operation:
        // protectedClustersForGlobalSla.
        protected void ProcessRecord_ProtectedClustersForGlobal()
        {
            this._logger.name += " -ProtectedClustersForGlobal";
            // Invoke graphql operation protectedClustersForGlobalSla
            InvokeQueryProtectedClustersForGlobalSla();
        }

        // This parameter set invokes a single graphql operation:
        // slaConflictObjects.
        protected void ProcessRecord_ConflictObject()
        {
            this._logger.name += " -ConflictObject";
            // Invoke graphql operation slaConflictObjects
            InvokeQuerySlaConflictObjects();
        }

        // This parameter set invokes a single graphql operation:
        // slaManagedVolumes.
        protected void ProcessRecord_ManagedVolume()
        {
            this._logger.name += " -ManagedVolume";
            // Invoke graphql operation slaManagedVolumes
            InvokeQuerySlaManagedVolumes();
        }

        // This parameter set invokes a single graphql operation:
        // clusterSlaDomainConnection.
        protected void ProcessRecord_ClusterDomainList()
        {
            this._logger.name += " -ClusterDomainList";
            // Invoke graphql operation clusterSlaDomainConnection
            InvokeQueryClusterSlaDomainConnection();
        }

        // This parameter set invokes a single graphql operation:
        // clusterSlaDomainFilterConnection.
        protected void ProcessRecord_ClusterDomainFilterList()
        {
            this._logger.name += " -ClusterDomainFilterList";
            // Invoke graphql operation clusterSlaDomainFilterConnection
            InvokeQueryClusterSlaDomainFilterConnection();
        }

        // This parameter set invokes a single graphql operation:
        // verifySLAWithReplicationToCluster.
        protected void ProcessRecord_VerifyWithReplicationToCluster()
        {
            this._logger.name += " -VerifyWithReplicationToCluster";
            // Invoke graphql operation verifySLAWithReplicationToCluster
            InvokeQueryVerifySlaWithReplicationToCluster();
        }

        // This parameter set invokes a single graphql operation:
        // downloadSlaWithReplicationCsv.
        protected void ProcessRecord_DownloadWithReplicationCsv()
        {
            this._logger.name += " -DownloadWithReplicationCsv";
            // Invoke graphql operation downloadSlaWithReplicationCsv
            InvokeQueryDownloadSlaWithReplicationCsv();
        }

        // This parameter set invokes a single graphql operation:
        // allClusterGlobalSlas.
        protected void ProcessRecord_AllClusterGlobal()
        {
            this._logger.name += " -AllClusterGlobal";
            // Invoke graphql operation allClusterGlobalSlas
            InvokeQueryAllClusterGlobalSlas();
        }

        // This parameter set invokes a single graphql operation:
        // allNcdSlaComplianceData.
        protected void ProcessRecord_AllNcdComplianceData()
        {
            this._logger.name += " -AllNcdComplianceData";
            // Invoke graphql operation allNcdSlaComplianceData
            InvokeQueryAllNcdSlaComplianceData();
        }


        // Invoke GraphQL Query:
        // allSlaIofilterStatuses(fid: UUID!): [ComputeClusterIofilterStatus!]!
        protected void InvokeQueryAllSlaIofilterStatuses()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            List<ComputeClusterIofilterStatus>? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (List<ComputeClusterIofilterStatus>)psObject.BaseObject;
                } else {
                    fields = (List<ComputeClusterIofilterStatus>)this.Field;
                }
            }
            string document = Query.AllSlaIofilterStatuses(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AllSlaIofilterStatuses");
            var parameters = "($fid: UUID!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAllSlaIofilterStatuses" + parameters + "{" + document + "}",
                OperationName = "QueryAllSlaIofilterStatuses",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "List<ComputeClusterIofilterStatus>", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // allCdpSlaVmNames(fid: UUID!): [String!]!
        protected void InvokeQueryAllCdpSlaVmNames()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            List<System.String>? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (List<System.String>)psObject.BaseObject;
                } else {
                    fields = (List<System.String>)this.Field;
                }
            }
            string document = Query.AllCdpSlaVmNames(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AllCdpSlaVmNames");
            var parameters = "($fid: UUID!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAllCdpSlaVmNames" + parameters + "{" + document + "}",
                OperationName = "QueryAllCdpSlaVmNames",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "List<System.String>", this._logger, GetMetricTags());
            WriteObject(result, true);
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
        protected void InvokeQuerySlaDomains()
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
            SlaDomainConnection? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (SlaDomainConnection)psObject.BaseObject;
                } else {
                    fields = (SlaDomainConnection)this.Field;
                }
            }
            string document = Query.SlaDomains(ref fields);
            this._input.Initialize(argDefs, fields, "Query.SlaDomains");
            var parameters = "($first: Int,$after: String,$last: Int,$before: String,$sortBy: SlaQuerySortByField,$sortOrder: SortOrder,$filter: [GlobalSlaFilterInput!],$contextFilter: ContextFilterTypeEnum,$contextFilterInput: [ContextFilterInputField!],$shouldShowSyncStatus: Boolean,$shouldShowProtectedObjectCount: Boolean,$shouldShowUpgradeInfo: Boolean,$showRemoteSlas: Boolean,$shouldShowPausedClusters: Boolean)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QuerySlaDomains" + parameters + "{" + document + "}",
                OperationName = "QuerySlaDomains",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "SlaDomainConnection", this._logger, GetMetricTags());
            WriteObject(result, true);
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
        protected void InvokeQuerySlaDomainWithWarningsList()
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
            List<SlaDomainWithWarnings>? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (List<SlaDomainWithWarnings>)psObject.BaseObject;
                } else {
                    fields = (List<SlaDomainWithWarnings>)this.Field;
                }
            }
            string document = Query.SlaDomainWithWarningsList(ref fields);
            this._input.Initialize(argDefs, fields, "Query.SlaDomainWithWarningsList");
            var parameters = "($first: Int,$after: String,$last: Int,$before: String,$sortBy: SlaQuerySortByField,$sortOrder: SortOrder,$filter: [GlobalSlaFilterInput!],$contextFilter: ContextFilterTypeEnum,$objectIds: [UUID!],$applicableSnappableTypes: [WorkloadLevelHierarchy!],$snapshotIds: [UUID!],$operation: SlaWarningsOperation)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QuerySlaDomainWithWarningsList" + parameters + "{" + document + "}",
                OperationName = "QuerySlaDomainWithWarningsList",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "List<SlaDomainWithWarnings>", this._logger, GetMetricTags());
            WriteObject(result, true);
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
        protected void InvokeQueryGlobalSlaFilterConnection()
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
            GlobalSlaForFilterConnection? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (GlobalSlaForFilterConnection)psObject.BaseObject;
                } else {
                    fields = (GlobalSlaForFilterConnection)this.Field;
                }
            }
            string document = Query.GlobalSlaFilterConnection(ref fields);
            this._input.Initialize(argDefs, fields, "Query.GlobalSlaFilterConnection");
            var parameters = "($first: Int,$after: String,$last: Int,$before: String,$sortBy: SlaQuerySortByField,$sortOrder: SortOrder,$filter: [GlobalSlaFilterInput!],$contextFilter: ContextFilterTypeEnum,$contextFilterInput: [ContextFilterInputField!],$shouldShowSyncStatus: Boolean,$shouldShowProtectedObjectCount: Boolean,$shouldShowUpgradeInfo: Boolean,$showRemoteSlas: Boolean,$shouldShowPausedClusters: Boolean)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryGlobalSlaFilterConnection" + parameters + "{" + document + "}",
                OperationName = "QueryGlobalSlaFilterConnection",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "GlobalSlaForFilterConnection", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // slaDomainWithWarnings(id: UUID!, objectIds: [UUID!]!, applicableSnappableTypes: [WorkloadLevelHierarchy!]): SlaDomainWithWarnings!
        protected void InvokeQuerySlaDomainWithWarnings()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("id", "UUID!"),
                Tuple.Create("objectIds", "[UUID!]!"),
                Tuple.Create("applicableSnappableTypes", "[WorkloadLevelHierarchy!]"),
            };
            SlaDomainWithWarnings? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (SlaDomainWithWarnings)psObject.BaseObject;
                } else {
                    fields = (SlaDomainWithWarnings)this.Field;
                }
            }
            string document = Query.SlaDomainWithWarnings(ref fields);
            this._input.Initialize(argDefs, fields, "Query.SlaDomainWithWarnings");
            var parameters = "($id: UUID!,$objectIds: [UUID!]!,$applicableSnappableTypes: [WorkloadLevelHierarchy!])\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QuerySlaDomainWithWarnings" + parameters + "{" + document + "}",
                OperationName = "QuerySlaDomainWithWarnings",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "SlaDomainWithWarnings", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // slaArchivalValidationWarnings(input: SlaArchivalWarningsInput!): SlaArchivalValidationWithWarnings!
        protected void InvokeQuerySlaArchivalValidationWarnings()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "SlaArchivalWarningsInput!"),
            };
            SlaArchivalValidationWithWarnings? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (SlaArchivalValidationWithWarnings)psObject.BaseObject;
                } else {
                    fields = (SlaArchivalValidationWithWarnings)this.Field;
                }
            }
            string document = Query.SlaArchivalValidationWarnings(ref fields);
            this._input.Initialize(argDefs, fields, "Query.SlaArchivalValidationWarnings");
            var parameters = "($input: SlaArchivalWarningsInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QuerySlaArchivalValidationWarnings" + parameters + "{" + document + "}",
                OperationName = "QuerySlaArchivalValidationWarnings",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "SlaArchivalValidationWithWarnings", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // countOfObjectsProtectedBySlas(
        //     rootOptionalFid: UUID
        //     slaIds: [UUID!]!
        //     filter: [Filter!]
        //     typeFilter: [HierarchyObjectTypeEnum!]
        //   ): CountOfObjectsProtectedBySLAsResult!
        protected void InvokeQueryCountOfObjectsProtectedBySlas()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("rootOptionalFid", "UUID"),
                Tuple.Create("slaIds", "[UUID!]!"),
                Tuple.Create("filter", "[Filter!]"),
                Tuple.Create("typeFilter", "[HierarchyObjectTypeEnum!]"),
            };
            CountOfObjectsProtectedBySlAsResult? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (CountOfObjectsProtectedBySlAsResult)psObject.BaseObject;
                } else {
                    fields = (CountOfObjectsProtectedBySlAsResult)this.Field;
                }
            }
            string document = Query.CountOfObjectsProtectedBySlas(ref fields);
            this._input.Initialize(argDefs, fields, "Query.CountOfObjectsProtectedBySlas");
            var parameters = "($rootOptionalFid: UUID,$slaIds: [UUID!]!,$filter: [Filter!],$typeFilter: [HierarchyObjectTypeEnum!])\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryCountOfObjectsProtectedBySlas" + parameters + "{" + document + "}",
                OperationName = "QueryCountOfObjectsProtectedBySlas",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "CountOfObjectsProtectedBySlAsResult", this._logger, GetMetricTags());
            WriteObject(result, true);
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
        protected void InvokeQuerySlaAuditDetail()
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
            List<SlaAuditDetail>? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (List<SlaAuditDetail>)psObject.BaseObject;
                } else {
                    fields = (List<SlaAuditDetail>)this.Field;
                }
            }
            string document = Query.SlaAuditDetail(ref fields);
            this._input.Initialize(argDefs, fields, "Query.SlaAuditDetail");
            var parameters = "($first: Int,$after: String,$last: Int,$before: String,$SlaId: UUID!,$filter: [SLAAuditDetailFilterInput!],$timezone: String)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QuerySlaAuditDetail" + parameters + "{" + document + "}",
                OperationName = "QuerySlaAuditDetail",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "List<SlaAuditDetail>", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // slaSummariesByIds(slaIds: [UUID!]!): [SlaDomain!]!
        protected void InvokeQuerySlaSummariesByIds()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("slaIds", "[UUID!]!"),
            };
            List<SlaDomain>? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (List<SlaDomain>)psObject.BaseObject;
                } else {
                    fields = (List<SlaDomain>)this.Field;
                }
            }
            string document = Query.SlaSummariesByIds(ref fields);
            this._input.Initialize(argDefs, fields, "Query.SlaSummariesByIds");
            var parameters = "($slaIds: [UUID!]!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QuerySlaSummariesByIds" + parameters + "{" + document + "}",
                OperationName = "QuerySlaSummariesByIds",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "List<SlaDomain>", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // globalSlaStatuses(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     filter: [SlaStatusFilterInput!]
        //     SlaId: UUID!
        //   ): PolarisSlaStatusConnection!
        protected void InvokeQueryGlobalSlaStatuses()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("filter", "[SlaStatusFilterInput!]"),
                Tuple.Create("SlaId", "UUID!"),
            };
            PolarisSlaStatusConnection? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (PolarisSlaStatusConnection)psObject.BaseObject;
                } else {
                    fields = (PolarisSlaStatusConnection)this.Field;
                }
            }
            string document = Query.GlobalSlaStatuses(ref fields);
            this._input.Initialize(argDefs, fields, "Query.GlobalSlaStatuses");
            var parameters = "($first: Int,$after: String,$last: Int,$before: String,$filter: [SlaStatusFilterInput!],$SlaId: UUID!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryGlobalSlaStatuses" + parameters + "{" + document + "}",
                OperationName = "QueryGlobalSlaStatuses",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "PolarisSlaStatusConnection", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // protectedClustersForGlobalSla(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     slaId: UUID!
        //   ): ClusterConnection!
        protected void InvokeQueryProtectedClustersForGlobalSla()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("slaId", "UUID!"),
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
            string document = Query.ProtectedClustersForGlobalSla(ref fields);
            this._input.Initialize(argDefs, fields, "Query.ProtectedClustersForGlobalSla");
            var parameters = "($first: Int,$after: String,$last: Int,$before: String,$slaId: UUID!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryProtectedClustersForGlobalSla" + parameters + "{" + document + "}",
                OperationName = "QueryProtectedClustersForGlobalSla",
            };
            var vars = new OperationVariableSet();
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
        // slaConflictObjects(fids: [UUID!]!): [HierarchyObject!]!
        protected void InvokeQuerySlaConflictObjects()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fids", "[UUID!]!"),
            };
            List<HierarchyObject>? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (List<HierarchyObject>)psObject.BaseObject;
                } else {
                    fields = (List<HierarchyObject>)this.Field;
                }
            }
            string document = Query.SlaConflictObjects(ref fields);
            this._input.Initialize(argDefs, fields, "Query.SlaConflictObjects");
            var parameters = "($fids: [UUID!]!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QuerySlaConflictObjects" + parameters + "{" + document + "}",
                OperationName = "QuerySlaConflictObjects",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "List<HierarchyObject>", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // slaManagedVolumes(
        //     first: Int
        //     after: String
        //     sortBy: HierarchySortByField
        //     sortOrder: SortOrder
        //     filter: [Filter!]
        //   ): ManagedVolumeConnection!
        protected void InvokeQuerySlaManagedVolumes()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("sortBy", "HierarchySortByField"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("filter", "[Filter!]"),
            };
            ManagedVolumeConnection? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (ManagedVolumeConnection)psObject.BaseObject;
                } else {
                    fields = (ManagedVolumeConnection)this.Field;
                }
            }
            string document = Query.SlaManagedVolumes(ref fields);
            this._input.Initialize(argDefs, fields, "Query.SlaManagedVolumes");
            var parameters = "($first: Int,$after: String,$sortBy: HierarchySortByField,$sortOrder: SortOrder,$filter: [Filter!])\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QuerySlaManagedVolumes" + parameters + "{" + document + "}",
                OperationName = "QuerySlaManagedVolumes",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "ManagedVolumeConnection", this._logger, GetMetricTags());
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
            var vars = new OperationVariableSet();
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
            var vars = new OperationVariableSet();
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
            var vars = new OperationVariableSet();
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
        // downloadSlaWithReplicationCsv(cdmClusterUUID: UUID!, includeArchived: Boolean!): DownloadSlaWithReplicationCsvReply!
        protected void InvokeQueryDownloadSlaWithReplicationCsv()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("cdmClusterUUID", "UUID!"),
                Tuple.Create("includeArchived", "Boolean!"),
            };
            DownloadSlaWithReplicationCsvReply? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (DownloadSlaWithReplicationCsvReply)psObject.BaseObject;
                } else {
                    fields = (DownloadSlaWithReplicationCsvReply)this.Field;
                }
            }
            string document = Query.DownloadSlaWithReplicationCsv(ref fields);
            this._input.Initialize(argDefs, fields, "Query.DownloadSlaWithReplicationCsv");
            var parameters = "($cdmClusterUUID: UUID!,$includeArchived: Boolean!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryDownloadSlaWithReplicationCsv" + parameters + "{" + document + "}",
                OperationName = "QueryDownloadSlaWithReplicationCsv",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "DownloadSlaWithReplicationCsvReply", this._logger, GetMetricTags());
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
            var vars = new OperationVariableSet();
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
        // allNcdSlaComplianceData(clusters: [UUID!]!): [NcdSlaComplianceData!]!
        protected void InvokeQueryAllNcdSlaComplianceData()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("clusters", "[UUID!]!"),
            };
            List<NcdSlaComplianceData>? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (List<NcdSlaComplianceData>)psObject.BaseObject;
                } else {
                    fields = (List<NcdSlaComplianceData>)this.Field;
                }
            }
            string document = Query.AllNcdSlaComplianceData(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AllNcdSlaComplianceData");
            var parameters = "($clusters: [UUID!]!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAllNcdSlaComplianceData" + parameters + "{" + document + "}",
                OperationName = "QueryAllNcdSlaComplianceData",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "List<NcdSlaComplianceData>", this._logger, GetMetricTags());
            WriteObject(result, true);
        }


    } // class Invoke_RscQuerySla
}