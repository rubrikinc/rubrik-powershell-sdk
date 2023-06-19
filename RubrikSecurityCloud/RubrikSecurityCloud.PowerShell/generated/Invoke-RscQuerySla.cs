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
        // Alliofilterstatus parameter set
        //
        // [GraphQL: allSlaIofilterStatuses]
        //
        [Parameter(
            ParameterSetName = "Alliofilterstatus",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"The iofilter installation status of the compute clusters related to this SLA Domain.
[GraphQL: allSlaIofilterStatuses]",
            Position = 0
        )]
        public SwitchParameter Alliofilterstatus { get; set; }

        [Parameter(
            ParameterSetName = "Alliofilterstatus",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"The Rubrik UUID for the object.
GraphQL argument fid: UUID!"
        )]
        public System.String? Fid { get; set; }
        
        // -------------------------------------------------------------------
        // Allcdpvmname parameter set
        //
        // [GraphQL: allCdpSlaVmNames]
        //
        [Parameter(
            ParameterSetName = "Allcdpvmname",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Names of the virtual machines in compute cluster with Continuous Data Protection (CDP) SLA Domain.
[GraphQL: allCdpSlaVmNames]",
            Position = 0
        )]
        public SwitchParameter Allcdpvmname { get; set; }

        
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

        [Parameter(
            ParameterSetName = "Domain",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Returns the first n elements from the list.
GraphQL argument first: Int"
        )]
        public System.Int32? First { get; set; }
        [Parameter(
            ParameterSetName = "Domain",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Returns the elements in the list that come after the specified cursor.
GraphQL argument after: String"
        )]
        public System.String? After { get; set; }
        [Parameter(
            ParameterSetName = "Domain",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Returns the last n elements from the list.
GraphQL argument last: Int"
        )]
        public System.Int32? Last { get; set; }
        [Parameter(
            ParameterSetName = "Domain",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Returns the elements in the list that come before the specified cursor.
GraphQL argument before: String"
        )]
        public System.String? Before { get; set; }
        [Parameter(
            ParameterSetName = "Domain",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Field to sort the SLA Domains list.
GraphQL argument sortBy: SlaQuerySortByField"
        )]
        public SlaQuerySortByField? SortBy { get; set; }
        [Parameter(
            ParameterSetName = "Domain",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Sort order for sorting the SLA Domains returned by the query.
GraphQL argument sortOrder: SortOrder"
        )]
        public SortOrder? SortOrder { get; set; }
        [Parameter(
            ParameterSetName = "Domain",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Filter for the SLA Domain query.
GraphQL argument filter: [GlobalSlaFilterInput!]"
        )]
        public List<GlobalSlaFilterInput>? Filter { get; set; }
        [Parameter(
            ParameterSetName = "Domain",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Specifies the context filter to use.
GraphQL argument contextFilter: ContextFilterTypeEnum"
        )]
        public ContextFilterTypeEnum? ContextFilter { get; set; }
        [Parameter(
            ParameterSetName = "Domain",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Specifies the context filter input to use.
GraphQL argument contextFilterInput: [ContextFilterInputField!]"
        )]
        public List<ContextFilterInputField>? ContextFilterInput { get; set; }
        [Parameter(
            ParameterSetName = "Domain",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Specifies whether to show the SLA Domain sync status on Rubrik CDM.
GraphQL argument shouldShowSyncStatus: Boolean"
        )]
        public System.Boolean? ShouldShowSyncStatus { get; set; }
        [Parameter(
            ParameterSetName = "Domain",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Specifies whether to show the number of workloads protected by the SLA Domain.
GraphQL argument shouldShowProtectedObjectCount: Boolean"
        )]
        public System.Boolean? ShouldShowProtectedObjectCount { get; set; }
        [Parameter(
            ParameterSetName = "Domain",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Specifies whether to show the upgrade information for an SLA Domain or not.
GraphQL argument shouldShowUpgradeInfo: Boolean"
        )]
        public System.Boolean? ShouldShowUpgradeInfo { get; set; }
        [Parameter(
            ParameterSetName = "Domain",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Specifies whether to retrieve the remote SLA Domains from Rubrik CDM. By default, remote SLA Domains are not retrieved.
GraphQL argument showRemoteSlas: Boolean"
        )]
        public System.Boolean? ShowRemoteSlas { get; set; }
        [Parameter(
            ParameterSetName = "Domain",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Specifies whether to show the Rubrik clusters where this SLA Domain is paused.
GraphQL argument shouldShowPausedClusters: Boolean"
        )]
        public System.Boolean? ShouldShowPausedClusters { get; set; }
        
        // -------------------------------------------------------------------
        // Domainwithwarningslist parameter set
        //
        // [GraphQL: slaDomainWithWarningsList]
        //
        [Parameter(
            ParameterSetName = "Domainwithwarningslist",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Query sla list with warnings
[GraphQL: slaDomainWithWarningsList]",
            Position = 0
        )]
        public SwitchParameter Domainwithwarningslist { get; set; }

        [Parameter(
            ParameterSetName = "Domainwithwarningslist",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Provide list of object forever IDS you want to assign SLA
GraphQL argument objectIds: [UUID!]"
        )]
        public List<System.String>? ObjectIds { get; set; }
        [Parameter(
            ParameterSetName = "Domainwithwarningslist",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Provide optional snappable types under the object for SLA assignment. This is meant to be used only for objects that support multiple snappable hierarchies. See 'applicableSnappableType' for more details. If more than one is provided, the SLA will be assigned to all.
GraphQL argument applicableSnappableTypes: [WorkloadLevelHierarchy!]"
        )]
        public List<WorkloadLevelHierarchy>? ApplicableSnappableTypes { get; set; }
        [Parameter(
            ParameterSetName = "Domainwithwarningslist",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Provides the forever IDs of the snapshots to assign SLA Domains to.
GraphQL argument snapshotIds: [UUID!]"
        )]
        public List<System.String>? SnapshotIds { get; set; }
        [Parameter(
            ParameterSetName = "Domainwithwarningslist",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Assignment operation with the SLA Domain.
GraphQL argument operation: SlaWarningsOperation"
        )]
        public SlaWarningsOperation? Operation { get; set; }
        
        // -------------------------------------------------------------------
        // Globalfilterconnection parameter set
        //
        // [GraphQL: globalSlaFilterConnection]
        //
        [Parameter(
            ParameterSetName = "Globalfilterconnection",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"
[GraphQL: globalSlaFilterConnection]",
            Position = 0
        )]
        public SwitchParameter Globalfilterconnection { get; set; }

        
        // -------------------------------------------------------------------
        // Domainwithwarning parameter set
        //
        // [GraphQL: slaDomainWithWarnings]
        //
        [Parameter(
            ParameterSetName = "Domainwithwarning",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"
[GraphQL: slaDomainWithWarnings]",
            Position = 0
        )]
        public SwitchParameter Domainwithwarning { get; set; }

        [Parameter(
            ParameterSetName = "Domainwithwarning",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"SLA Domain ID.
GraphQL argument id: UUID!"
        )]
        public System.String? Id { get; set; }
        
        // -------------------------------------------------------------------
        // Archivalvalidationwarning parameter set
        //
        // [GraphQL: slaArchivalValidationWarnings]
        //
        [Parameter(
            ParameterSetName = "Archivalvalidationwarning",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"SLA Domain warnings related to non-compliant archival retention duration in the archival policy.
[GraphQL: slaArchivalValidationWarnings]",
            Position = 0
        )]
        public SwitchParameter Archivalvalidationwarning { get; set; }

        [Parameter(
            ParameterSetName = "Archivalvalidationwarning",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Input for requesting SLA Domain compliance warnings related to archival policy.
GraphQL argument input: SlaArchivalWarningsInput!"
        )]
        public SlaArchivalWarningsInput? Input { get; set; }
        
        // -------------------------------------------------------------------
        // Countofobjectsprotected parameter set
        //
        // [GraphQL: countOfObjectsProtectedBySlas]
        //
        [Parameter(
            ParameterSetName = "Countofobjectsprotected",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"The number of objects protected by the SLA Domains.
[GraphQL: countOfObjectsProtectedBySlas]",
            Position = 0
        )]
        public SwitchParameter Countofobjectsprotected { get; set; }

        [Parameter(
            ParameterSetName = "Countofobjectsprotected",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Forever UUID of the object root. The value of  `none` represents the global hierarchy root.
GraphQL argument rootOptionalFid: UUID"
        )]
        public System.String? RootOptionalFid { get; set; }
        [Parameter(
            ParameterSetName = "Countofobjectsprotected",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"A list of global SLA Domain IDs.
GraphQL argument slaIds: [UUID!]!"
        )]
        public List<System.String>? SlaIds { get; set; }
        [Parameter(
            ParameterSetName = "Countofobjectsprotected",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Types of objects to include.
GraphQL argument typeFilter: [HierarchyObjectTypeEnum!]"
        )]
        public List<HierarchyObjectTypeEnum>? TypeFilter { get; set; }
        
        // -------------------------------------------------------------------
        // Auditdetail parameter set
        //
        // [GraphQL: slaAuditDetail]
        //
        [Parameter(
            ParameterSetName = "Auditdetail",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"List of audit details for a given SLA Domain.
[GraphQL: slaAuditDetail]",
            Position = 0
        )]
        public SwitchParameter Auditdetail { get; set; }

        [Parameter(
            ParameterSetName = "Auditdetail",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"SLA Domain ID for global SLA Domains and internal ID for SLA Domains created on Rubrik clusters.
GraphQL argument SlaId: UUID!"
        )]
        public System.String? SlaId { get; set; }
        [Parameter(
            ParameterSetName = "Auditdetail",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Timezone.
GraphQL argument timezone: String"
        )]
        public System.String? Timezone { get; set; }
        
        // -------------------------------------------------------------------
        // Summariesbyid parameter set
        //
        // [GraphQL: slaSummariesByIds]
        //
        [Parameter(
            ParameterSetName = "Summariesbyid",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"List of SLA summaries for the given ids
[GraphQL: slaSummariesByIds]",
            Position = 0
        )]
        public SwitchParameter Summariesbyid { get; set; }

        
        // -------------------------------------------------------------------
        // Globalstatus parameter set
        //
        // [GraphQL: globalSlaStatuses]
        //
        [Parameter(
            ParameterSetName = "Globalstatus",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Status on the clusters where global SLA is synced.
[GraphQL: globalSlaStatuses]",
            Position = 0
        )]
        public SwitchParameter Globalstatus { get; set; }

        
        // -------------------------------------------------------------------
        // Protectedclustersforglobal parameter set
        //
        // [GraphQL: protectedClustersForGlobalSla]
        //
        [Parameter(
            ParameterSetName = "Protectedclustersforglobal",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Clusters that have object(s) protected by global SLA.
[GraphQL: protectedClustersForGlobalSla]",
            Position = 0
        )]
        public SwitchParameter Protectedclustersforglobal { get; set; }

        
        // -------------------------------------------------------------------
        // Conflictobject parameter set
        //
        // [GraphQL: slaConflictObjects]
        //
        [Parameter(
            ParameterSetName = "Conflictobject",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"
[GraphQL: slaConflictObjects]",
            Position = 0
        )]
        public SwitchParameter Conflictobject { get; set; }

        [Parameter(
            ParameterSetName = "Conflictobject",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"
GraphQL argument fids: [UUID!]!"
        )]
        public List<System.String>? Fids { get; set; }
        
        // -------------------------------------------------------------------
        // Managedvolume parameter set
        //
        // [GraphQL: slaManagedVolumes]
        //
        [Parameter(
            ParameterSetName = "Managedvolume",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Paginated list of SLA Managed Volumes.
[GraphQL: slaManagedVolumes]",
            Position = 0
        )]
        public SwitchParameter Managedvolume { get; set; }

        
        // -------------------------------------------------------------------
        // Clusterdomainconnection parameter set
        //
        // [GraphQL: clusterSlaDomainConnection]
        //
        [Parameter(
            ParameterSetName = "Clusterdomainconnection",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"
[GraphQL: clusterSlaDomainConnection]",
            Position = 0
        )]
        public SwitchParameter Clusterdomainconnection { get; set; }

        
        // -------------------------------------------------------------------
        // Clusterdomainfilterconnection parameter set
        //
        // [GraphQL: clusterSlaDomainFilterConnection]
        //
        [Parameter(
            ParameterSetName = "Clusterdomainfilterconnection",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"
[GraphQL: clusterSlaDomainFilterConnection]",
            Position = 0
        )]
        public SwitchParameter Clusterdomainfilterconnection { get; set; }

        
        // -------------------------------------------------------------------
        // Verifywithreplicationtocluster parameter set
        //
        // [GraphQL: verifySLAWithReplicationToCluster]
        //
        [Parameter(
            ParameterSetName = "Verifywithreplicationtocluster",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"
[GraphQL: verifySLAWithReplicationToCluster]",
            Position = 0
        )]
        public SwitchParameter Verifywithreplicationtocluster { get; set; }

        [Parameter(
            ParameterSetName = "Verifywithreplicationtocluster",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"UUID of the Rubrik cluster.
GraphQL argument cdmClusterUUID: UUID!"
        )]
        public System.String? CdmClusterUuid { get; set; }
        [Parameter(
            ParameterSetName = "Verifywithreplicationtocluster",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Include Archived SLA.
GraphQL argument includeArchived: Boolean!"
        )]
        public System.Boolean? IncludeArchived { get; set; }
        
        // -------------------------------------------------------------------
        // Downloadwithreplicationcsv parameter set
        //
        // [GraphQL: downloadSlaWithReplicationCsv]
        //
        [Parameter(
            ParameterSetName = "Downloadwithreplicationcsv",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Download list of Global SLA CSV that have Replication to the given Rubrik Cluster.
[GraphQL: downloadSlaWithReplicationCsv]",
            Position = 0
        )]
        public SwitchParameter Downloadwithreplicationcsv { get; set; }

        
        // -------------------------------------------------------------------
        // Allclusterglobal parameter set
        //
        // [GraphQL: allClusterGlobalSlas]
        //
        [Parameter(
            ParameterSetName = "Allclusterglobal",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Global SLA Domains protecting at least one object on the specified Rubrik cluster.
[GraphQL: allClusterGlobalSlas]",
            Position = 0
        )]
        public SwitchParameter Allclusterglobal { get; set; }

        
        // -------------------------------------------------------------------
        // Allobjecttestusernoteaudit parameter set
        //
        // [GraphQL: allObjectsLatestUserNoteAudit]
        //
        [Parameter(
            ParameterSetName = "Allobjecttestusernoteaudit",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Latest audit with usernote for a list of objects.
[GraphQL: allObjectsLatestUserNoteAudit]",
            Position = 0
        )]
        public SwitchParameter Allobjecttestusernoteaudit { get; set; }

        
        // -------------------------------------------------------------------
        // Allncdcompliancedata parameter set
        //
        // [GraphQL: allNcdSlaComplianceData]
        //
        [Parameter(
            ParameterSetName = "Allncdcompliancedata",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"NAS Cloud Direct SLA Domain compliance data for the requested clusters.
[GraphQL: allNcdSlaComplianceData]",
            Position = 0
        )]
        public SwitchParameter Allncdcompliancedata { get; set; }

        [Parameter(
            ParameterSetName = "Allncdcompliancedata",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"List of Rubrik clusters to filter.
GraphQL argument clusters: [UUID!]!"
        )]
        public List<System.String>? Clusters { get; set; }

        protected override void ProcessRecord()
        {
            try
            {
                switch(Op)
                {
                    case "Alliofilterstatus":
                        this.ProcessRecord_Alliofilterstatus();
                        break;
                    case "Allcdpvmname":
                        this.ProcessRecord_Allcdpvmname();
                        break;
                    case "Domain":
                        this.ProcessRecord_Domain();
                        break;
                    case "Domainwithwarningslist":
                        this.ProcessRecord_Domainwithwarningslist();
                        break;
                    case "Globalfilterconnection":
                        this.ProcessRecord_Globalfilterconnection();
                        break;
                    case "Domainwithwarning":
                        this.ProcessRecord_Domainwithwarning();
                        break;
                    case "Archivalvalidationwarning":
                        this.ProcessRecord_Archivalvalidationwarning();
                        break;
                    case "Countofobjectsprotected":
                        this.ProcessRecord_Countofobjectsprotected();
                        break;
                    case "Auditdetail":
                        this.ProcessRecord_Auditdetail();
                        break;
                    case "Summariesbyid":
                        this.ProcessRecord_Summariesbyid();
                        break;
                    case "Globalstatus":
                        this.ProcessRecord_Globalstatus();
                        break;
                    case "Protectedclustersforglobal":
                        this.ProcessRecord_Protectedclustersforglobal();
                        break;
                    case "Conflictobject":
                        this.ProcessRecord_Conflictobject();
                        break;
                    case "Managedvolume":
                        this.ProcessRecord_Managedvolume();
                        break;
                    case "Clusterdomainconnection":
                        this.ProcessRecord_Clusterdomainconnection();
                        break;
                    case "Clusterdomainfilterconnection":
                        this.ProcessRecord_Clusterdomainfilterconnection();
                        break;
                    case "Verifywithreplicationtocluster":
                        this.ProcessRecord_Verifywithreplicationtocluster();
                        break;
                    case "Downloadwithreplicationcsv":
                        this.ProcessRecord_Downloadwithreplicationcsv();
                        break;
                    case "Allclusterglobal":
                        this.ProcessRecord_Allclusterglobal();
                        break;
                    case "Allobjecttestusernoteaudit":
                        this.ProcessRecord_Allobjecttestusernoteaudit();
                        break;
                    case "Allncdcompliancedata":
                        this.ProcessRecord_Allncdcompliancedata();
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
        protected void ProcessRecord_Alliofilterstatus()
        {
            this._logger.name += " -Alliofilterstatus";
            // Invoke graphql operation allSlaIofilterStatuses
            InvokeQueryAllSlaIofilterStatuses();
        }

        // This parameter set invokes a single graphql operation:
        // allCdpSlaVmNames.
        protected void ProcessRecord_Allcdpvmname()
        {
            this._logger.name += " -Allcdpvmname";
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
        protected void ProcessRecord_Domainwithwarningslist()
        {
            this._logger.name += " -Domainwithwarningslist";
            // Invoke graphql operation slaDomainWithWarningsList
            InvokeQuerySlaDomainWithWarningsList();
        }

        // This parameter set invokes a single graphql operation:
        // globalSlaFilterConnection.
        protected void ProcessRecord_Globalfilterconnection()
        {
            this._logger.name += " -Globalfilterconnection";
            // Invoke graphql operation globalSlaFilterConnection
            InvokeQueryGlobalSlaFilterConnection();
        }

        // This parameter set invokes a single graphql operation:
        // slaDomainWithWarnings.
        protected void ProcessRecord_Domainwithwarning()
        {
            this._logger.name += " -Domainwithwarning";
            // Invoke graphql operation slaDomainWithWarnings
            InvokeQuerySlaDomainWithWarnings();
        }

        // This parameter set invokes a single graphql operation:
        // slaArchivalValidationWarnings.
        protected void ProcessRecord_Archivalvalidationwarning()
        {
            this._logger.name += " -Archivalvalidationwarning";
            // Invoke graphql operation slaArchivalValidationWarnings
            InvokeQuerySlaArchivalValidationWarnings();
        }

        // This parameter set invokes a single graphql operation:
        // countOfObjectsProtectedBySlas.
        protected void ProcessRecord_Countofobjectsprotected()
        {
            this._logger.name += " -Countofobjectsprotected";
            // Invoke graphql operation countOfObjectsProtectedBySlas
            InvokeQueryCountOfObjectsProtectedBySlas();
        }

        // This parameter set invokes a single graphql operation:
        // slaAuditDetail.
        protected void ProcessRecord_Auditdetail()
        {
            this._logger.name += " -Auditdetail";
            // Invoke graphql operation slaAuditDetail
            InvokeQuerySlaAuditDetail();
        }

        // This parameter set invokes a single graphql operation:
        // slaSummariesByIds.
        protected void ProcessRecord_Summariesbyid()
        {
            this._logger.name += " -Summariesbyid";
            // Invoke graphql operation slaSummariesByIds
            InvokeQuerySlaSummariesByIds();
        }

        // This parameter set invokes a single graphql operation:
        // globalSlaStatuses.
        protected void ProcessRecord_Globalstatus()
        {
            this._logger.name += " -Globalstatus";
            // Invoke graphql operation globalSlaStatuses
            InvokeQueryGlobalSlaStatuses();
        }

        // This parameter set invokes a single graphql operation:
        // protectedClustersForGlobalSla.
        protected void ProcessRecord_Protectedclustersforglobal()
        {
            this._logger.name += " -Protectedclustersforglobal";
            // Invoke graphql operation protectedClustersForGlobalSla
            InvokeQueryProtectedClustersForGlobalSla();
        }

        // This parameter set invokes a single graphql operation:
        // slaConflictObjects.
        protected void ProcessRecord_Conflictobject()
        {
            this._logger.name += " -Conflictobject";
            // Invoke graphql operation slaConflictObjects
            InvokeQuerySlaConflictObjects();
        }

        // This parameter set invokes a single graphql operation:
        // slaManagedVolumes.
        protected void ProcessRecord_Managedvolume()
        {
            this._logger.name += " -Managedvolume";
            // Invoke graphql operation slaManagedVolumes
            InvokeQuerySlaManagedVolumes();
        }

        // This parameter set invokes a single graphql operation:
        // clusterSlaDomainConnection.
        protected void ProcessRecord_Clusterdomainconnection()
        {
            this._logger.name += " -Clusterdomainconnection";
            // Invoke graphql operation clusterSlaDomainConnection
            InvokeQueryClusterSlaDomainConnection();
        }

        // This parameter set invokes a single graphql operation:
        // clusterSlaDomainFilterConnection.
        protected void ProcessRecord_Clusterdomainfilterconnection()
        {
            this._logger.name += " -Clusterdomainfilterconnection";
            // Invoke graphql operation clusterSlaDomainFilterConnection
            InvokeQueryClusterSlaDomainFilterConnection();
        }

        // This parameter set invokes a single graphql operation:
        // verifySLAWithReplicationToCluster.
        protected void ProcessRecord_Verifywithreplicationtocluster()
        {
            this._logger.name += " -Verifywithreplicationtocluster";
            // Invoke graphql operation verifySLAWithReplicationToCluster
            InvokeQueryVerifySlaWithReplicationToCluster();
        }

        // This parameter set invokes a single graphql operation:
        // downloadSlaWithReplicationCsv.
        protected void ProcessRecord_Downloadwithreplicationcsv()
        {
            this._logger.name += " -Downloadwithreplicationcsv";
            // Invoke graphql operation downloadSlaWithReplicationCsv
            InvokeQueryDownloadSlaWithReplicationCsv();
        }

        // This parameter set invokes a single graphql operation:
        // allClusterGlobalSlas.
        protected void ProcessRecord_Allclusterglobal()
        {
            this._logger.name += " -Allclusterglobal";
            // Invoke graphql operation allClusterGlobalSlas
            InvokeQueryAllClusterGlobalSlas();
        }

        // This parameter set invokes a single graphql operation:
        // allObjectsLatestUserNoteAudit.
        protected void ProcessRecord_Allobjecttestusernoteaudit()
        {
            this._logger.name += " -Allobjecttestusernoteaudit";
            // Invoke graphql operation allObjectsLatestUserNoteAudit
            InvokeQueryAllObjectsLatestUserNoteAudit();
        }

        // This parameter set invokes a single graphql operation:
        // allNcdSlaComplianceData.
        protected void ProcessRecord_Allncdcompliancedata()
        {
            this._logger.name += " -Allncdcompliancedata";
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
            OperationVariableSet vars = new();
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
            OperationVariableSet vars = new();
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
            OperationVariableSet vars = new();
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
            OperationVariableSet vars = new();
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
            OperationVariableSet vars = new();
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
            OperationVariableSet vars = new();
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
            OperationVariableSet vars = new();
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
            OperationVariableSet vars = new();
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
            OperationVariableSet vars = new();
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
            OperationVariableSet vars = new();
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
            OperationVariableSet vars = new();
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
            OperationVariableSet vars = new();
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
            OperationVariableSet vars = new();
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
            OperationVariableSet vars = new();
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
        // allObjectsLatestUserNoteAudit(objectIds: [String!]!): [LatestUserNote!]!
        protected void InvokeQueryAllObjectsLatestUserNoteAudit()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("objectIds", "[String!]!"),
            };
            List<LatestUserNote>? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (List<LatestUserNote>)psObject.BaseObject;
                } else {
                    fields = (List<LatestUserNote>)this.Field;
                }
            }
            string document = Query.AllObjectsLatestUserNoteAudit(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AllObjectsLatestUserNoteAudit");
            var parameters = "($objectIds: [String!]!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAllObjectsLatestUserNoteAudit" + parameters + "{" + document + "}",
                OperationName = "QueryAllObjectsLatestUserNoteAudit",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "List<LatestUserNote>", this._logger, GetMetricTags());
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
            OperationVariableSet vars = new();
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