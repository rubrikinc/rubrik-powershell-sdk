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
        
        // -------------------------------------------------------------------
        // TopLevelDescendant parameter set
        //
        // [GraphQL: hypervTopLevelDescendants]
        //
        [Parameter(
            ParameterSetName = "TopLevelDescendant",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Paginated list of the highest-level HyperV Objects accessible by the current user.
[GraphQL: hypervTopLevelDescendants]",
            Position = 0
        )]
        public SwitchParameter TopLevelDescendant { get; set; }

        
        // -------------------------------------------------------------------
        // VirtualMachine parameter set
        //
        // [GraphQL: hypervVirtualMachines]
        //
        [Parameter(
            ParameterSetName = "VirtualMachine",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Paginated list of HyperV Virtual Machines.
[GraphQL: hypervVirtualMachines]",
            Position = 0
        )]
        public SwitchParameter VirtualMachine { get; set; }

        
        // -------------------------------------------------------------------
        // Scvmm parameter set
        //
        // [GraphQL: hypervScvmm]
        //
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

        
        // -------------------------------------------------------------------
        // Cluster parameter set
        //
        // [GraphQL: hypervCluster]
        //
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

        
        // -------------------------------------------------------------------
        // Server parameter set
        //
        // [GraphQL: hypervServer]
        //
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

        
        // -------------------------------------------------------------------
        // UniqueServersCount parameter set
        //
        // [GraphQL: uniqueHypervServersCount]
        //
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

        
        // -------------------------------------------------------------------
        // Mount parameter set
        //
        // [GraphQL: hypervMounts]
        //
        [Parameter(
            ParameterSetName = "Mount",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"HyperV Live Mount Connection.
[GraphQL: hypervMounts]",
            Position = 0
        )]
        public SwitchParameter Mount { get; set; }

        
        // -------------------------------------------------------------------
        // VmDetail parameter set
        //
        // [GraphQL: hypervVmDetail]
        //
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

        
        // -------------------------------------------------------------------
        // HostAsyncRequestStatus parameter set
        //
        // [GraphQL: hypervHostAsyncRequestStatus]
        //
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

        
        // -------------------------------------------------------------------
        // ScvmmAsyncRequestStatus parameter set
        //
        // [GraphQL: hypervScvmmAsyncRequestStatus]
        //
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

        
        // -------------------------------------------------------------------
        // VirtualMachineAsyncRequestStatus parameter set
        //
        // [GraphQL: hypervVirtualMachineAsyncRequestStatus]
        //
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


        protected override void ProcessRecord()
        {
            try
            {
                switch(Op)
                {
                    case "TopLevelDescendant":
                        this.ProcessRecord_TopLevelDescendant();
                        break;
                    case "VirtualMachine":
                        this.ProcessRecord_VirtualMachine();
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
                    case "UniqueServersCount":
                        this.ProcessRecord_UniqueServersCount();
                        break;
                    case "Mount":
                        this.ProcessRecord_Mount();
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

        // This parameter set invokes a single graphql operation:
        // hypervTopLevelDescendants.
        protected void ProcessRecord_TopLevelDescendant()
        {
            this._logger.name += " -TopLevelDescendant";
            // Invoke graphql operation hypervTopLevelDescendants
            InvokeQueryHypervTopLevelDescendants();
        }

        // This parameter set invokes a single graphql operation:
        // hypervVirtualMachines.
        protected void ProcessRecord_VirtualMachine()
        {
            this._logger.name += " -VirtualMachine";
            // Invoke graphql operation hypervVirtualMachines
            InvokeQueryHypervVirtualMachines();
        }

        // This parameter set invokes a single graphql operation:
        // hypervScvmm.
        protected void ProcessRecord_Scvmm()
        {
            this._logger.name += " -Scvmm";
            // Invoke graphql operation hypervScvmm
            InvokeQueryHypervScvmm();
        }

        // This parameter set invokes a single graphql operation:
        // hypervCluster.
        protected void ProcessRecord_Cluster()
        {
            this._logger.name += " -Cluster";
            // Invoke graphql operation hypervCluster
            InvokeQueryHypervCluster();
        }

        // This parameter set invokes a single graphql operation:
        // hypervServer.
        protected void ProcessRecord_Server()
        {
            this._logger.name += " -Server";
            // Invoke graphql operation hypervServer
            InvokeQueryHypervServer();
        }

        // This parameter set invokes a single graphql operation:
        // uniqueHypervServersCount.
        protected void ProcessRecord_UniqueServersCount()
        {
            this._logger.name += " -UniqueServersCount";
            // Invoke graphql operation uniqueHypervServersCount
            InvokeQueryUniqueHypervServersCount();
        }

        // This parameter set invokes a single graphql operation:
        // hypervMounts.
        protected void ProcessRecord_Mount()
        {
            this._logger.name += " -Mount";
            // Invoke graphql operation hypervMounts
            InvokeQueryHypervMounts();
        }

        // This parameter set invokes a single graphql operation:
        // hypervVmDetail.
        protected void ProcessRecord_VmDetail()
        {
            this._logger.name += " -VmDetail";
            // Invoke graphql operation hypervVmDetail
            InvokeQueryHypervVmDetail();
        }

        // This parameter set invokes a single graphql operation:
        // hypervHostAsyncRequestStatus.
        protected void ProcessRecord_HostAsyncRequestStatus()
        {
            this._logger.name += " -HostAsyncRequestStatus";
            // Invoke graphql operation hypervHostAsyncRequestStatus
            InvokeQueryHypervHostAsyncRequestStatus();
        }

        // This parameter set invokes a single graphql operation:
        // hypervScvmmAsyncRequestStatus.
        protected void ProcessRecord_ScvmmAsyncRequestStatus()
        {
            this._logger.name += " -ScvmmAsyncRequestStatus";
            // Invoke graphql operation hypervScvmmAsyncRequestStatus
            InvokeQueryHypervScvmmAsyncRequestStatus();
        }

        // This parameter set invokes a single graphql operation:
        // hypervVirtualMachineAsyncRequestStatus.
        protected void ProcessRecord_VirtualMachineAsyncRequestStatus()
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
        protected void InvokeQueryHypervTopLevelDescendants()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("sortBy", "HierarchySortByField"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("typeFilter", "[HierarchyObjectTypeEnum!]"),
                Tuple.Create("filter", "[Filter!]"),
            };
            HypervTopLevelDescendantTypeConnection? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (HypervTopLevelDescendantTypeConnection)psObject.BaseObject;
                } else {
                    fields = (HypervTopLevelDescendantTypeConnection)this.Field;
                }
            }
            string document = Query.HypervTopLevelDescendants(ref fields);
            this._input.Initialize(argDefs, fields, "Query.HypervTopLevelDescendants");
            var parameters = "($first: Int,$after: String,$sortBy: HierarchySortByField,$sortOrder: SortOrder,$typeFilter: [HierarchyObjectTypeEnum!],$filter: [Filter!])\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryHypervTopLevelDescendants" + parameters + "{" + document + "}",
                OperationName = "QueryHypervTopLevelDescendants",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "HypervTopLevelDescendantTypeConnection", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // hypervVirtualMachines(
        //     first: Int
        //     after: String
        //     sortBy: HierarchySortByField
        //     sortOrder: SortOrder
        //     filter: [Filter!]
        //   ): HyperVVirtualMachineConnection!
        protected void InvokeQueryHypervVirtualMachines()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("sortBy", "HierarchySortByField"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("filter", "[Filter!]"),
            };
            HyperVvirtualMachineConnection? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (HyperVvirtualMachineConnection)psObject.BaseObject;
                } else {
                    fields = (HyperVvirtualMachineConnection)this.Field;
                }
            }
            string document = Query.HypervVirtualMachines(ref fields);
            this._input.Initialize(argDefs, fields, "Query.HypervVirtualMachines");
            var parameters = "($first: Int,$after: String,$sortBy: HierarchySortByField,$sortOrder: SortOrder,$filter: [Filter!])\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryHypervVirtualMachines" + parameters + "{" + document + "}",
                OperationName = "QueryHypervVirtualMachines",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "HyperVvirtualMachineConnection", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // hypervScvmm(fid: UUID!): HyperVSCVMM!
        protected void InvokeQueryHypervScvmm()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            HyperVscvmm? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (HyperVscvmm)psObject.BaseObject;
                } else {
                    fields = (HyperVscvmm)this.Field;
                }
            }
            string document = Query.HypervScvmm(ref fields);
            this._input.Initialize(argDefs, fields, "Query.HypervScvmm");
            var parameters = "($fid: UUID!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryHypervScvmm" + parameters + "{" + document + "}",
                OperationName = "QueryHypervScvmm",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "HyperVscvmm", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // hypervCluster(fid: UUID!): HyperVCluster!
        protected void InvokeQueryHypervCluster()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            HyperVcluster? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (HyperVcluster)psObject.BaseObject;
                } else {
                    fields = (HyperVcluster)this.Field;
                }
            }
            string document = Query.HypervCluster(ref fields);
            this._input.Initialize(argDefs, fields, "Query.HypervCluster");
            var parameters = "($fid: UUID!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryHypervCluster" + parameters + "{" + document + "}",
                OperationName = "QueryHypervCluster",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "HyperVcluster", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // hypervServer(fid: UUID!): HypervServer!
        protected void InvokeQueryHypervServer()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            HypervServer? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (HypervServer)psObject.BaseObject;
                } else {
                    fields = (HypervServer)this.Field;
                }
            }
            string document = Query.HypervServer(ref fields);
            this._input.Initialize(argDefs, fields, "Query.HypervServer");
            var parameters = "($fid: UUID!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryHypervServer" + parameters + "{" + document + "}",
                OperationName = "QueryHypervServer",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "HypervServer", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // uniqueHypervServersCount(filter: [Filter!]): Int!
        protected void InvokeQueryUniqueHypervServersCount()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("filter", "[Filter!]"),
            };
            System.Int32? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (System.Int32)psObject.BaseObject;
                } else {
                    fields = (System.Int32)this.Field;
                }
            }
            string document = Query.UniqueHypervServersCount(ref fields);
            this._input.Initialize(argDefs, fields, "Query.UniqueHypervServersCount");
            var parameters = "($filter: [Filter!])\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryUniqueHypervServersCount" + parameters + "{" + document + "}",
                OperationName = "QueryUniqueHypervServersCount",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "System.Int32", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // hypervMounts(
        //     first: Int
        //     after: String
        //     filters: [HypervLiveMountFilterInput!]
        //     sortBy: HypervLiveMountSortByInput
        //   ): HyperVLiveMountConnection!
        protected void InvokeQueryHypervMounts()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("filters", "[HypervLiveMountFilterInput!]"),
                Tuple.Create("sortBy", "HypervLiveMountSortByInput"),
            };
            HyperVliveMountConnection? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (HyperVliveMountConnection)psObject.BaseObject;
                } else {
                    fields = (HyperVliveMountConnection)this.Field;
                }
            }
            string document = Query.HypervMounts(ref fields);
            this._input.Initialize(argDefs, fields, "Query.HypervMounts");
            var parameters = "($first: Int,$after: String,$filters: [HypervLiveMountFilterInput!],$sortBy: HypervLiveMountSortByInput)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryHypervMounts" + parameters + "{" + document + "}",
                OperationName = "QueryHypervMounts",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "HyperVliveMountConnection", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // hypervVmDetail(input: GetHypervVirtualMachineInput!): HypervVirtualMachineDetail!
        protected void InvokeQueryHypervVmDetail()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetHypervVirtualMachineInput!"),
            };
            HypervVirtualMachineDetail? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (HypervVirtualMachineDetail)psObject.BaseObject;
                } else {
                    fields = (HypervVirtualMachineDetail)this.Field;
                }
            }
            string document = Query.HypervVmDetail(ref fields);
            this._input.Initialize(argDefs, fields, "Query.HypervVmDetail");
            var parameters = "($input: GetHypervVirtualMachineInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryHypervVmDetail" + parameters + "{" + document + "}",
                OperationName = "QueryHypervVmDetail",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "HypervVirtualMachineDetail", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // hypervHostAsyncRequestStatus(input: GetHypervHostAsyncRequestStatusInput!): AsyncRequestStatus!
        protected void InvokeQueryHypervHostAsyncRequestStatus()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetHypervHostAsyncRequestStatusInput!"),
            };
            AsyncRequestStatus? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (AsyncRequestStatus)psObject.BaseObject;
                } else {
                    fields = (AsyncRequestStatus)this.Field;
                }
            }
            string document = Query.HypervHostAsyncRequestStatus(ref fields);
            this._input.Initialize(argDefs, fields, "Query.HypervHostAsyncRequestStatus");
            var parameters = "($input: GetHypervHostAsyncRequestStatusInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryHypervHostAsyncRequestStatus" + parameters + "{" + document + "}",
                OperationName = "QueryHypervHostAsyncRequestStatus",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "AsyncRequestStatus", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // hypervScvmmAsyncRequestStatus(input: GetHypervScvmmAsyncRequestStatusInput!): AsyncRequestStatus!
        protected void InvokeQueryHypervScvmmAsyncRequestStatus()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetHypervScvmmAsyncRequestStatusInput!"),
            };
            AsyncRequestStatus? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (AsyncRequestStatus)psObject.BaseObject;
                } else {
                    fields = (AsyncRequestStatus)this.Field;
                }
            }
            string document = Query.HypervScvmmAsyncRequestStatus(ref fields);
            this._input.Initialize(argDefs, fields, "Query.HypervScvmmAsyncRequestStatus");
            var parameters = "($input: GetHypervScvmmAsyncRequestStatusInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryHypervScvmmAsyncRequestStatus" + parameters + "{" + document + "}",
                OperationName = "QueryHypervScvmmAsyncRequestStatus",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "AsyncRequestStatus", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // hypervVirtualMachineAsyncRequestStatus(input: GetHypervVirtualMachineAsyncRequestStatusInput!): AsyncRequestStatus!
        protected void InvokeQueryHypervVirtualMachineAsyncRequestStatus()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetHypervVirtualMachineAsyncRequestStatusInput!"),
            };
            AsyncRequestStatus? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (AsyncRequestStatus)psObject.BaseObject;
                } else {
                    fields = (AsyncRequestStatus)this.Field;
                }
            }
            string document = Query.HypervVirtualMachineAsyncRequestStatus(ref fields);
            this._input.Initialize(argDefs, fields, "Query.HypervVirtualMachineAsyncRequestStatus");
            var parameters = "($input: GetHypervVirtualMachineAsyncRequestStatusInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryHypervVirtualMachineAsyncRequestStatus" + parameters + "{" + document + "}",
                OperationName = "QueryHypervVirtualMachineAsyncRequestStatus",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "AsyncRequestStatus", this._logger, GetMetricTags());
            WriteObject(result, true);
        }


    } // class Invoke_RscQueryHyperv
}