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
            HypervTopLevelDescendantTypeConnection? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (HypervTopLevelDescendantTypeConnection)psObject.BaseObject;
                } else {
                    fieldSpecObj = (HypervTopLevelDescendantTypeConnection)this.Field;
                }
            }
            string fieldSpecDoc = Query.HypervTopLevelDescendants(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryHypervTopLevelDescendants",
                "($first: Int,$after: String,$sortBy: HierarchySortByField,$sortOrder: SortOrder,$typeFilter: [HierarchyObjectTypeEnum!],$filter: [Filter!])",
                fieldSpecDoc,
                "HypervTopLevelDescendantTypeConnection"
            );
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
            HyperVvirtualMachineConnection? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (HyperVvirtualMachineConnection)psObject.BaseObject;
                } else {
                    fieldSpecObj = (HyperVvirtualMachineConnection)this.Field;
                }
            }
            string fieldSpecDoc = Query.HypervVirtualMachines(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryHypervVirtualMachines",
                "($first: Int,$after: String,$sortBy: HierarchySortByField,$sortOrder: SortOrder,$filter: [Filter!])",
                fieldSpecDoc,
                "HyperVvirtualMachineConnection"
            );
        }

        // Invoke GraphQL Query:
        // hypervScvmm(fid: UUID!): HyperVSCVMM!
        internal void InvokeQueryHypervScvmm()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            HyperVscvmm? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (HyperVscvmm)psObject.BaseObject;
                } else {
                    fieldSpecObj = (HyperVscvmm)this.Field;
                }
            }
            string fieldSpecDoc = Query.HypervScvmm(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryHypervScvmm",
                "($fid: UUID!)",
                fieldSpecDoc,
                "HyperVscvmm"
            );
        }

        // Invoke GraphQL Query:
        // hypervCluster(fid: UUID!): HyperVCluster!
        internal void InvokeQueryHypervCluster()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            HyperVcluster? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (HyperVcluster)psObject.BaseObject;
                } else {
                    fieldSpecObj = (HyperVcluster)this.Field;
                }
            }
            string fieldSpecDoc = Query.HypervCluster(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryHypervCluster",
                "($fid: UUID!)",
                fieldSpecDoc,
                "HyperVcluster"
            );
        }

        // Invoke GraphQL Query:
        // hypervServer(fid: UUID!): HypervServer!
        internal void InvokeQueryHypervServer()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            HypervServer? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (HypervServer)psObject.BaseObject;
                } else {
                    fieldSpecObj = (HypervServer)this.Field;
                }
            }
            string fieldSpecDoc = Query.HypervServer(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryHypervServer",
                "($fid: UUID!)",
                fieldSpecDoc,
                "HypervServer"
            );
        }

        // Invoke GraphQL Query:
        // hypervVirtualMachine(fid: UUID!): HyperVVirtualMachine!
        internal void InvokeQueryHypervVirtualMachine()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            HyperVvirtualMachine? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (HyperVvirtualMachine)psObject.BaseObject;
                } else {
                    fieldSpecObj = (HyperVvirtualMachine)this.Field;
                }
            }
            string fieldSpecDoc = Query.HypervVirtualMachine(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryHypervVirtualMachine",
                "($fid: UUID!)",
                fieldSpecDoc,
                "HyperVvirtualMachine"
            );
        }

        // Invoke GraphQL Query:
        // uniqueHypervServersCount(filter: [Filter!]): Int!
        internal void InvokeQueryUniqueHypervServersCount()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("filter", "[Filter!]"),
            };
            System.Int32? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (System.Int32)psObject.BaseObject;
                } else {
                    fieldSpecObj = (System.Int32)this.Field;
                }
            }
            string fieldSpecDoc = Query.UniqueHypervServersCount(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryUniqueHypervServersCount",
                "($filter: [Filter!])",
                fieldSpecDoc,
                "System.Int32"
            );
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
            HyperVscvmmConnection? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (HyperVscvmmConnection)psObject.BaseObject;
                } else {
                    fieldSpecObj = (HyperVscvmmConnection)this.Field;
                }
            }
            string fieldSpecDoc = Query.HypervScvmms(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryHypervScvmms",
                "($first: Int,$after: String,$sortBy: HierarchySortByField,$sortOrder: SortOrder,$filter: [Filter!])",
                fieldSpecDoc,
                "HyperVscvmmConnection"
            );
        }

        // Invoke GraphQL Query:
        // hypervServers(input: QueryHypervHostInput!): HypervHostSummaryListResponse!
        internal void InvokeQueryHypervServers()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "QueryHypervHostInput!"),
            };
            HypervHostSummaryListResponse? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (HypervHostSummaryListResponse)psObject.BaseObject;
                } else {
                    fieldSpecObj = (HypervHostSummaryListResponse)this.Field;
                }
            }
            string fieldSpecDoc = Query.HypervServers(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryHypervServers",
                "($input: QueryHypervHostInput!)",
                fieldSpecDoc,
                "HypervHostSummaryListResponse"
            );
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
            HyperVliveMountConnection? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (HyperVliveMountConnection)psObject.BaseObject;
                } else {
                    fieldSpecObj = (HyperVliveMountConnection)this.Field;
                }
            }
            string fieldSpecDoc = Query.HypervMounts(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryHypervMounts",
                "($first: Int,$after: String,$filters: [HypervLiveMountFilterInput!],$sortBy: HypervLiveMountSortByInput)",
                fieldSpecDoc,
                "HyperVliveMountConnection"
            );
        }

        // Invoke GraphQL Query:
        // hypervVmDetail(input: GetHypervVirtualMachineInput!): HypervVirtualMachineDetail!
        internal void InvokeQueryHypervVmDetail()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetHypervVirtualMachineInput!"),
            };
            HypervVirtualMachineDetail? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (HypervVirtualMachineDetail)psObject.BaseObject;
                } else {
                    fieldSpecObj = (HypervVirtualMachineDetail)this.Field;
                }
            }
            string fieldSpecDoc = Query.HypervVmDetail(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryHypervVmDetail",
                "($input: GetHypervVirtualMachineInput!)",
                fieldSpecDoc,
                "HypervVirtualMachineDetail"
            );
        }

        // Invoke GraphQL Query:
        // hypervHostAsyncRequestStatus(input: GetHypervHostAsyncRequestStatusInput!): AsyncRequestStatus!
        internal void InvokeQueryHypervHostAsyncRequestStatus()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetHypervHostAsyncRequestStatusInput!"),
            };
            AsyncRequestStatus? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (AsyncRequestStatus)psObject.BaseObject;
                } else {
                    fieldSpecObj = (AsyncRequestStatus)this.Field;
                }
            }
            string fieldSpecDoc = Query.HypervHostAsyncRequestStatus(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryHypervHostAsyncRequestStatus",
                "($input: GetHypervHostAsyncRequestStatusInput!)",
                fieldSpecDoc,
                "AsyncRequestStatus"
            );
        }

        // Invoke GraphQL Query:
        // hypervScvmmAsyncRequestStatus(input: GetHypervScvmmAsyncRequestStatusInput!): AsyncRequestStatus!
        internal void InvokeQueryHypervScvmmAsyncRequestStatus()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetHypervScvmmAsyncRequestStatusInput!"),
            };
            AsyncRequestStatus? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (AsyncRequestStatus)psObject.BaseObject;
                } else {
                    fieldSpecObj = (AsyncRequestStatus)this.Field;
                }
            }
            string fieldSpecDoc = Query.HypervScvmmAsyncRequestStatus(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryHypervScvmmAsyncRequestStatus",
                "($input: GetHypervScvmmAsyncRequestStatusInput!)",
                fieldSpecDoc,
                "AsyncRequestStatus"
            );
        }

        // Invoke GraphQL Query:
        // hypervVirtualMachineAsyncRequestStatus(input: GetHypervVirtualMachineAsyncRequestStatusInput!): AsyncRequestStatus!
        internal void InvokeQueryHypervVirtualMachineAsyncRequestStatus()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetHypervVirtualMachineAsyncRequestStatusInput!"),
            };
            AsyncRequestStatus? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (AsyncRequestStatus)psObject.BaseObject;
                } else {
                    fieldSpecObj = (AsyncRequestStatus)this.Field;
                }
            }
            string fieldSpecDoc = Query.HypervVirtualMachineAsyncRequestStatus(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryHypervVirtualMachineAsyncRequestStatus",
                "($input: GetHypervVirtualMachineAsyncRequestStatusInput!)",
                fieldSpecDoc,
                "AsyncRequestStatus"
            );
        }


    } // class Invoke_RscQueryHyperv
}