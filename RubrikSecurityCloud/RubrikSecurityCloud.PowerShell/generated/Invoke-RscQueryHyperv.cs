// Invoke-RscQueryHyperv.cs
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
    /// Hyperv queries
    /// </summary>
    /// <description>
    /// Invoke-RscQueryHyperv is a master cmdlet for Hyperv work that can invoke any of the following subcommands: TopLevelDescendants, VirtualMachines, Scvmm, Cluster, Server, VirtualMachine, UniqueServersCount, Scvmms, Servers, Mounts, VmDetail, HostAsyncRequestStatus, ScvmmAsyncRequestStatus, VirtualMachineAsyncRequestStatus.
    /// </description>
    /// <example>
    /// <code>Invoke-RscQueryHyperv -TopLevelDescendants [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscQueryHyperv -VirtualMachines [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscQueryHyperv -Scvmm [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscQueryHyperv -Cluster [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscQueryHyperv -Server [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscQueryHyperv -VirtualMachine [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscQueryHyperv -UniqueServersCount [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscQueryHyperv -Scvmms [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscQueryHyperv -Servers [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscQueryHyperv -Mounts [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscQueryHyperv -VmDetail [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscQueryHyperv -HostAsyncRequestStatus [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscQueryHyperv -ScvmmAsyncRequestStatus [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscQueryHyperv -VirtualMachineAsyncRequestStatus [-Arg ..] [-Field ..]</code>
    /// </example>
    [Cmdlet(
        "Invoke",
        "RscQueryHyperv",
        DefaultParameterSetName = "Cluster")
    ]
    public class Invoke_RscQueryHyperv : RscPSCmdlet
    {
        
        /// <summary>
        /// TopLevelDescendants parameter set
        ///
        /// [GraphQL: hypervTopLevelDescendants]
        /// </summary>
        [Parameter(
            ParameterSetName = "TopLevelDescendants",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Paginated list of the highest-level HyperV Objects accessible by the current user.
[GraphQL: hypervTopLevelDescendants]",
            Position = 0
        )]
        public SwitchParameter TopLevelDescendants { get; set; }

        
        /// <summary>
        /// VirtualMachines parameter set
        ///
        /// [GraphQL: hypervVirtualMachines]
        /// </summary>
        [Parameter(
            ParameterSetName = "VirtualMachines",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Paginated list of HyperV Virtual Machines.
[GraphQL: hypervVirtualMachines]",
            Position = 0
        )]
        public SwitchParameter VirtualMachines { get; set; }

        
        /// <summary>
        /// Scvmm parameter set
        ///
        /// [GraphQL: hypervScvmm]
        /// </summary>
        [Parameter(
            ParameterSetName = "Scvmm",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Details of the given Hyper-V SCVMM.
[GraphQL: hypervScvmm]",
            Position = 0
        )]
        public SwitchParameter Scvmm { get; set; }

        
        /// <summary>
        /// Cluster parameter set
        ///
        /// [GraphQL: hypervCluster]
        /// </summary>
        [Parameter(
            ParameterSetName = "Cluster",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Details of the given Hyper-V Cluster.
[GraphQL: hypervCluster]",
            Position = 0
        )]
        public SwitchParameter Cluster { get; set; }

        
        /// <summary>
        /// Server parameter set
        ///
        /// [GraphQL: hypervServer]
        /// </summary>
        [Parameter(
            ParameterSetName = "Server",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Details of the given Hyper-V Server.
[GraphQL: hypervServer]",
            Position = 0
        )]
        public SwitchParameter Server { get; set; }

        
        /// <summary>
        /// VirtualMachine parameter set
        ///
        /// [GraphQL: hypervVirtualMachine]
        /// </summary>
        [Parameter(
            ParameterSetName = "VirtualMachine",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Details of the given Hyper-V Virtual Machine.
[GraphQL: hypervVirtualMachine]",
            Position = 0
        )]
        public SwitchParameter VirtualMachine { get; set; }

        
        /// <summary>
        /// UniqueServersCount parameter set
        ///
        /// [GraphQL: uniqueHypervServersCount]
        /// </summary>
        [Parameter(
            ParameterSetName = "UniqueServersCount",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Count of unique HyperV Servers.
[GraphQL: uniqueHypervServersCount]",
            Position = 0
        )]
        public SwitchParameter UniqueServersCount { get; set; }

        
        /// <summary>
        /// Scvmms parameter set
        ///
        /// [GraphQL: hypervScvmms]
        /// </summary>
        [Parameter(
            ParameterSetName = "Scvmms",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Paginated list of HyperV SCVMMs.
[GraphQL: hypervScvmms]",
            Position = 0
        )]
        public SwitchParameter Scvmms { get; set; }

        
        /// <summary>
        /// Servers parameter set
        ///
        /// [GraphQL: hypervServers]
        /// </summary>
        [Parameter(
            ParameterSetName = "Servers",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Get summary of all the Hyper-V hosts

Supported in v5.0+
Get summary of all the Hyper-V hosts.
[GraphQL: hypervServers]",
            Position = 0
        )]
        public SwitchParameter Servers { get; set; }

        
        /// <summary>
        /// Mounts parameter set
        ///
        /// [GraphQL: hypervMounts]
        /// </summary>
        [Parameter(
            ParameterSetName = "Mounts",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"HyperV Live Mount Connection.
[GraphQL: hypervMounts]",
            Position = 0
        )]
        public SwitchParameter Mounts { get; set; }

        
        /// <summary>
        /// VmDetail parameter set
        ///
        /// [GraphQL: hypervVmDetail]
        /// </summary>
        [Parameter(
            ParameterSetName = "VmDetail",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"HyperV Virtual Machine detail from CDM.
[GraphQL: hypervVmDetail]",
            Position = 0
        )]
        public SwitchParameter VmDetail { get; set; }

        
        /// <summary>
        /// HostAsyncRequestStatus parameter set
        ///
        /// [GraphQL: hypervHostAsyncRequestStatus]
        /// </summary>
        [Parameter(
            ParameterSetName = "HostAsyncRequestStatus",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Get Hyper-V host async request

Supported in v5.0+
Get details about a Hyper-V host related async request.
[GraphQL: hypervHostAsyncRequestStatus]",
            Position = 0
        )]
        public SwitchParameter HostAsyncRequestStatus { get; set; }

        
        /// <summary>
        /// ScvmmAsyncRequestStatus parameter set
        ///
        /// [GraphQL: hypervScvmmAsyncRequestStatus]
        /// </summary>
        [Parameter(
            ParameterSetName = "ScvmmAsyncRequestStatus",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Get Hyper-V SCVMM async request

Supported in v5.0+
Get details about a Hyper-V SCVMM related async request.
[GraphQL: hypervScvmmAsyncRequestStatus]",
            Position = 0
        )]
        public SwitchParameter ScvmmAsyncRequestStatus { get; set; }

        
        /// <summary>
        /// VirtualMachineAsyncRequestStatus parameter set
        ///
        /// [GraphQL: hypervVirtualMachineAsyncRequestStatus]
        /// </summary>
        [Parameter(
            ParameterSetName = "VirtualMachineAsyncRequestStatus",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Get VM async request details

Supported in v5.0+
Get details about a Hyper-V vm related async request.
[GraphQL: hypervVirtualMachineAsyncRequestStatus]",
            Position = 0
        )]
        public SwitchParameter VirtualMachineAsyncRequestStatus { get; set; }


// ignore warning 'Missing XML comment'
#pragma warning disable 1591
        protected override void ProcessRecord()
        {
            try
            {
                switch(Op)
                {
                    case "TopLevelDescendants":
                        this.ProcessRecord_TopLevelDescendants();
                        break;
                    case "VirtualMachines":
                        this.ProcessRecord_VirtualMachines();
                        break;
                    case "Scvmm":
                        this.ProcessRecord_Scvmm();
                        break;
                    case "Cluster":
                        this.ProcessRecord_Cluster();
                        break;
                    case "Server":
                        this.ProcessRecord_Server();
                        break;
                    case "VirtualMachine":
                        this.ProcessRecord_VirtualMachine();
                        break;
                    case "UniqueServersCount":
                        this.ProcessRecord_UniqueServersCount();
                        break;
                    case "Scvmms":
                        this.ProcessRecord_Scvmms();
                        break;
                    case "Servers":
                        this.ProcessRecord_Servers();
                        break;
                    case "Mounts":
                        this.ProcessRecord_Mounts();
                        break;
                    case "VmDetail":
                        this.ProcessRecord_VmDetail();
                        break;
                    case "HostAsyncRequestStatus":
                        this.ProcessRecord_HostAsyncRequestStatus();
                        break;
                    case "ScvmmAsyncRequestStatus":
                        this.ProcessRecord_ScvmmAsyncRequestStatus();
                        break;
                    case "VirtualMachineAsyncRequestStatus":
                        this.ProcessRecord_VirtualMachineAsyncRequestStatus();
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
        // hypervTopLevelDescendants.
        internal void ProcessRecord_TopLevelDescendants()
        {
            this._logger.name += " -TopLevelDescendants";
            // Invoke graphql operation hypervTopLevelDescendants
            InvokeQueryHypervTopLevelDescendants();
        }

        // This parameter set invokes a single graphql operation:
        // hypervVirtualMachines.
        internal void ProcessRecord_VirtualMachines()
        {
            this._logger.name += " -VirtualMachines";
            // Invoke graphql operation hypervVirtualMachines
            InvokeQueryHypervVirtualMachines();
        }

        // This parameter set invokes a single graphql operation:
        // hypervScvmm.
        internal void ProcessRecord_Scvmm()
        {
            this._logger.name += " -Scvmm";
            // Invoke graphql operation hypervScvmm
            InvokeQueryHypervScvmm();
        }

        // This parameter set invokes a single graphql operation:
        // hypervCluster.
        internal void ProcessRecord_Cluster()
        {
            this._logger.name += " -Cluster";
            // Invoke graphql operation hypervCluster
            InvokeQueryHypervCluster();
        }

        // This parameter set invokes a single graphql operation:
        // hypervServer.
        internal void ProcessRecord_Server()
        {
            this._logger.name += " -Server";
            // Invoke graphql operation hypervServer
            InvokeQueryHypervServer();
        }

        // This parameter set invokes a single graphql operation:
        // hypervVirtualMachine.
        internal void ProcessRecord_VirtualMachine()
        {
            this._logger.name += " -VirtualMachine";
            // Invoke graphql operation hypervVirtualMachine
            InvokeQueryHypervVirtualMachine();
        }

        // This parameter set invokes a single graphql operation:
        // uniqueHypervServersCount.
        internal void ProcessRecord_UniqueServersCount()
        {
            this._logger.name += " -UniqueServersCount";
            // Invoke graphql operation uniqueHypervServersCount
            InvokeQueryUniqueHypervServersCount();
        }

        // This parameter set invokes a single graphql operation:
        // hypervScvmms.
        internal void ProcessRecord_Scvmms()
        {
            this._logger.name += " -Scvmms";
            // Invoke graphql operation hypervScvmms
            InvokeQueryHypervScvmms();
        }

        // This parameter set invokes a single graphql operation:
        // hypervServers.
        internal void ProcessRecord_Servers()
        {
            this._logger.name += " -Servers";
            // Invoke graphql operation hypervServers
            InvokeQueryHypervServers();
        }

        // This parameter set invokes a single graphql operation:
        // hypervMounts.
        internal void ProcessRecord_Mounts()
        {
            this._logger.name += " -Mounts";
            // Invoke graphql operation hypervMounts
            InvokeQueryHypervMounts();
        }

        // This parameter set invokes a single graphql operation:
        // hypervVmDetail.
        internal void ProcessRecord_VmDetail()
        {
            this._logger.name += " -VmDetail";
            // Invoke graphql operation hypervVmDetail
            InvokeQueryHypervVmDetail();
        }

        // This parameter set invokes a single graphql operation:
        // hypervHostAsyncRequestStatus.
        internal void ProcessRecord_HostAsyncRequestStatus()
        {
            this._logger.name += " -HostAsyncRequestStatus";
            // Invoke graphql operation hypervHostAsyncRequestStatus
            InvokeQueryHypervHostAsyncRequestStatus();
        }

        // This parameter set invokes a single graphql operation:
        // hypervScvmmAsyncRequestStatus.
        internal void ProcessRecord_ScvmmAsyncRequestStatus()
        {
            this._logger.name += " -ScvmmAsyncRequestStatus";
            // Invoke graphql operation hypervScvmmAsyncRequestStatus
            InvokeQueryHypervScvmmAsyncRequestStatus();
        }

        // This parameter set invokes a single graphql operation:
        // hypervVirtualMachineAsyncRequestStatus.
        internal void ProcessRecord_VirtualMachineAsyncRequestStatus()
        {
            this._logger.name += " -VirtualMachineAsyncRequestStatus";
            // Invoke graphql operation hypervVirtualMachineAsyncRequestStatus
            InvokeQueryHypervVirtualMachineAsyncRequestStatus();
        }


        // Invoke GraphQL Query:
        // hypervTopLevelDescendants(
        //     first: Int
        //     after: String
        //     sortBy: HierarchySortByField
        //     sortOrder: SortOrder
        //     typeFilter: [HierarchyObjectTypeEnum!]
        //     filter: [Filter!]
        //   ): HypervTopLevelDescendantTypeConnection!
        internal void InvokeQueryHypervTopLevelDescendants()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("sortBy", "HierarchySortByField"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("typeFilter", "[HierarchyObjectTypeEnum!]"),
                Tuple.Create("filter", "[Filter!]"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryHypervTopLevelDescendants",
                "($first: Int,$after: String,$sortBy: HierarchySortByField,$sortOrder: SortOrder,$typeFilter: [HierarchyObjectTypeEnum!],$filter: [Filter!])",
                "HypervTopLevelDescendantTypeConnection"
                );
            HypervTopLevelDescendantTypeConnection? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (HypervTopLevelDescendantTypeConnection)this.Field;
            }
            string fieldSpecDoc = Query.HypervTopLevelDescendants(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Query:
        // hypervVirtualMachines(
        //     first: Int
        //     after: String
        //     sortBy: HierarchySortByField
        //     sortOrder: SortOrder
        //     filter: [Filter!]
        //   ): HyperVVirtualMachineConnection!
        internal void InvokeQueryHypervVirtualMachines()
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
                "QueryHypervVirtualMachines",
                "($first: Int,$after: String,$sortBy: HierarchySortByField,$sortOrder: SortOrder,$filter: [Filter!])",
                "HyperVvirtualMachineConnection"
                );
            HyperVvirtualMachineConnection? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (HyperVvirtualMachineConnection)this.Field;
            }
            string fieldSpecDoc = Query.HypervVirtualMachines(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Query:
        // hypervScvmm(fid: UUID!): HyperVSCVMM!
        internal void InvokeQueryHypervScvmm()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryHypervScvmm",
                "($fid: UUID!)",
                "HyperVscvmm"
                );
            HyperVscvmm? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (HyperVscvmm)this.Field;
            }
            string fieldSpecDoc = Query.HypervScvmm(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Query:
        // hypervCluster(fid: UUID!): HyperVCluster!
        internal void InvokeQueryHypervCluster()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryHypervCluster",
                "($fid: UUID!)",
                "HyperVcluster"
                );
            HyperVcluster? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (HyperVcluster)this.Field;
            }
            string fieldSpecDoc = Query.HypervCluster(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Query:
        // hypervServer(fid: UUID!): HypervServer!
        internal void InvokeQueryHypervServer()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryHypervServer",
                "($fid: UUID!)",
                "HypervServer"
                );
            HypervServer? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (HypervServer)this.Field;
            }
            string fieldSpecDoc = Query.HypervServer(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Query:
        // hypervVirtualMachine(fid: UUID!): HyperVVirtualMachine!
        internal void InvokeQueryHypervVirtualMachine()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryHypervVirtualMachine",
                "($fid: UUID!)",
                "HyperVvirtualMachine"
                );
            HyperVvirtualMachine? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (HyperVvirtualMachine)this.Field;
            }
            string fieldSpecDoc = Query.HypervVirtualMachine(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Query:
        // uniqueHypervServersCount(filter: [Filter!]): Int!
        internal void InvokeQueryUniqueHypervServersCount()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("filter", "[Filter!]"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryUniqueHypervServersCount",
                "($filter: [Filter!])",
                "System.Int32"
                );
            System.Int32? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (System.Int32)this.Field;
            }
            string fieldSpecDoc = Query.UniqueHypervServersCount(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Query:
        // hypervScvmms(
        //     first: Int
        //     after: String
        //     sortBy: HierarchySortByField
        //     sortOrder: SortOrder
        //     filter: [Filter!]
        //   ): HyperVSCVMMConnection!
        internal void InvokeQueryHypervScvmms()
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
                "QueryHypervScvmms",
                "($first: Int,$after: String,$sortBy: HierarchySortByField,$sortOrder: SortOrder,$filter: [Filter!])",
                "HyperVscvmmConnection"
                );
            HyperVscvmmConnection? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (HyperVscvmmConnection)this.Field;
            }
            string fieldSpecDoc = Query.HypervScvmms(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Query:
        // hypervServers(input: QueryHypervHostInput!): HypervHostSummaryListResponse!
        internal void InvokeQueryHypervServers()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "QueryHypervHostInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryHypervServers",
                "($input: QueryHypervHostInput!)",
                "HypervHostSummaryListResponse"
                );
            HypervHostSummaryListResponse? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (HypervHostSummaryListResponse)this.Field;
            }
            string fieldSpecDoc = Query.HypervServers(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Query:
        // hypervMounts(
        //     first: Int
        //     after: String
        //     filters: [HypervLiveMountFilterInput!]
        //     sortBy: HypervLiveMountSortByInput
        //   ): HyperVLiveMountConnection!
        internal void InvokeQueryHypervMounts()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("filters", "[HypervLiveMountFilterInput!]"),
                Tuple.Create("sortBy", "HypervLiveMountSortByInput"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryHypervMounts",
                "($first: Int,$after: String,$filters: [HypervLiveMountFilterInput!],$sortBy: HypervLiveMountSortByInput)",
                "HyperVliveMountConnection"
                );
            HyperVliveMountConnection? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (HyperVliveMountConnection)this.Field;
            }
            string fieldSpecDoc = Query.HypervMounts(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Query:
        // hypervVmDetail(input: GetHypervVirtualMachineInput!): HypervVirtualMachineDetail!
        internal void InvokeQueryHypervVmDetail()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetHypervVirtualMachineInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryHypervVmDetail",
                "($input: GetHypervVirtualMachineInput!)",
                "HypervVirtualMachineDetail"
                );
            HypervVirtualMachineDetail? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (HypervVirtualMachineDetail)this.Field;
            }
            string fieldSpecDoc = Query.HypervVmDetail(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Query:
        // hypervHostAsyncRequestStatus(input: GetHypervHostAsyncRequestStatusInput!): AsyncRequestStatus!
        internal void InvokeQueryHypervHostAsyncRequestStatus()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetHypervHostAsyncRequestStatusInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryHypervHostAsyncRequestStatus",
                "($input: GetHypervHostAsyncRequestStatusInput!)",
                "AsyncRequestStatus"
                );
            AsyncRequestStatus? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (AsyncRequestStatus)this.Field;
            }
            string fieldSpecDoc = Query.HypervHostAsyncRequestStatus(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Query:
        // hypervScvmmAsyncRequestStatus(input: GetHypervScvmmAsyncRequestStatusInput!): AsyncRequestStatus!
        internal void InvokeQueryHypervScvmmAsyncRequestStatus()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetHypervScvmmAsyncRequestStatusInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryHypervScvmmAsyncRequestStatus",
                "($input: GetHypervScvmmAsyncRequestStatusInput!)",
                "AsyncRequestStatus"
                );
            AsyncRequestStatus? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (AsyncRequestStatus)this.Field;
            }
            string fieldSpecDoc = Query.HypervScvmmAsyncRequestStatus(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Query:
        // hypervVirtualMachineAsyncRequestStatus(input: GetHypervVirtualMachineAsyncRequestStatusInput!): AsyncRequestStatus!
        internal void InvokeQueryHypervVirtualMachineAsyncRequestStatus()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetHypervVirtualMachineAsyncRequestStatusInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryHypervVirtualMachineAsyncRequestStatus",
                "($input: GetHypervVirtualMachineAsyncRequestStatusInput!)",
                "AsyncRequestStatus"
                );
            AsyncRequestStatus? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (AsyncRequestStatus)this.Field;
            }
            string fieldSpecDoc = Query.HypervVirtualMachineAsyncRequestStatus(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
        }


    } // class Invoke_RscQueryHyperv
}