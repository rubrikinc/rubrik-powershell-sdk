// Invoke-RscQueryVcenter.cs
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
        "RscQueryVcenter",
        DefaultParameterSetName = "Vcenter")
    ]
    public class Invoke_RscQueryVcenter : RscPSCmdlet
    {
        
        // -------------------------------------------------------------------
        // Vcenter parameter set
        //
        // [GraphQL: vSphereVCenter]
        //
        [Parameter(
            ParameterSetName = "Vcenter",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"
[GraphQL: vSphereVCenter]",
            Position = 0
        )]
        public SwitchParameter Vcenter { get; set; }

        [Parameter(
            ParameterSetName = "Vcenter",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"The Rubrik UUID for the object.
GraphQL argument fid: UUID!"
        )]
        public System.String? Fid { get; set; }
        
        // -------------------------------------------------------------------
        // List parameter set
        //
        // [GraphQL: vSphereVCenterConnection]
        //
        [Parameter(
            ParameterSetName = "List",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"
[GraphQL: vSphereVCenterConnection]",
            Position = 0
        )]
        public SwitchParameter List { get; set; }

        [Parameter(
            ParameterSetName = "List",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Returns the first n elements from the list.
GraphQL argument first: Int"
        )]
        public System.Int32? First { get; set; }
        [Parameter(
            ParameterSetName = "List",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Returns the elements in the list that come after the specified cursor.
GraphQL argument after: String"
        )]
        public System.String? After { get; set; }
        [Parameter(
            ParameterSetName = "List",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Sort hierarchy objects by hierarchy field.
GraphQL argument sortBy: HierarchySortByField"
        )]
        public HierarchySortByField? SortBy { get; set; }
        [Parameter(
            ParameterSetName = "List",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Sorting order for the results.
GraphQL argument sortOrder: SortOrder"
        )]
        public SortOrder? SortOrder { get; set; }
        [Parameter(
            ParameterSetName = "List",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"The hierarchy object filter.
GraphQL argument filter: [Filter!]"
        )]
        public List<Filter>? Filter { get; set; }
        
        // -------------------------------------------------------------------
        // Uniquecount parameter set
        //
        // [GraphQL: uniqueVSphereVCenterCount]
        //
        [Parameter(
            ParameterSetName = "Uniquecount",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"
[GraphQL: uniqueVSphereVCenterCount]",
            Position = 0
        )]
        public SwitchParameter Uniquecount { get; set; }

        
        // -------------------------------------------------------------------
        // Preaddinfo parameter set
        //
        // [GraphQL: vCenterPreAddInfo]
        //
        [Parameter(
            ParameterSetName = "Preaddinfo",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Get preAddInfo for a vcenter.
[GraphQL: vCenterPreAddInfo]",
            Position = 0
        )]
        public SwitchParameter Preaddinfo { get; set; }

        [Parameter(
            ParameterSetName = "Preaddinfo",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Input for V1PreAddVcenter.
GraphQL argument input: PreAddVcenterInput!"
        )]
        public PreAddVcenterInput? Input { get; set; }
        
        // -------------------------------------------------------------------
        // Network parameter set
        //
        // [GraphQL: vCenterNetworks]
        //
        [Parameter(
            ParameterSetName = "Network",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Get the user-configured networks in the vCenter

Supported in v5.3+
Get the names and IDs of the user configured networks in the vCenter. This information enables users to choose a desired network for backups to go through for VMware Cloud on AWS setups.
[GraphQL: vCenterNetworks]",
            Position = 0
        )]
        public SwitchParameter Network { get; set; }

        
        // -------------------------------------------------------------------
        // Hotaddnetwork parameter set
        //
        // [GraphQL: vCenterHotAddNetwork]
        //
        [Parameter(
            ParameterSetName = "Hotaddnetwork",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Retrieve the user-configured network for HotAdd operations

Supported in v5.3+
Retrieve the user-configured network for HotAdd backup and recovery operations on VMware on AWS.
[GraphQL: vCenterHotAddNetwork]",
            Position = 0
        )]
        public SwitchParameter Hotaddnetwork { get; set; }

        
        // -------------------------------------------------------------------
        // Numproxiesneeded parameter set
        //
        // [GraphQL: vCenterNumProxiesNeeded]
        //
        [Parameter(
            ParameterSetName = "Numproxiesneeded",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Get the number of HotAdd proxies needed for the vCenter

Supported in v5.3+
Get the number of HotAdd proxies that need to be deployed to the vCenter to support the maximum number of ingest jobs.
[GraphQL: vCenterNumProxiesNeeded]",
            Position = 0
        )]
        public SwitchParameter Numproxiesneeded { get; set; }

        
        // -------------------------------------------------------------------
        // Hotaddproxy parameter set
        //
        // [GraphQL: allVcenterHotAddProxyVms]
        //
        [Parameter(
            ParameterSetName = "Hotaddproxy",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Get a list of HotAdd proxy virtual machines

Supported in v5.3+
Retrieve summary information for all HotAdd proxy virtual machines.
[GraphQL: allVcenterHotAddProxyVms]",
            Position = 0
        )]
        public SwitchParameter Hotaddproxy { get; set; }

        [Parameter(
            ParameterSetName = "Hotaddproxy",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"List of cluster IDs.
GraphQL argument clusterUuids: [UUID!]!"
        )]
        public List<System.String>? ClusterUuids { get; set; }
        
        // -------------------------------------------------------------------
        // Hotaddbandwidth parameter set
        //
        // [GraphQL: vCenterHotAddBandwidth]
        //
        [Parameter(
            ParameterSetName = "Hotaddbandwidth",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Get the ingest and export bandwidth limits for HotAdd with the vCenter

Supported in v5.3+
Get the ingest and export bandwidth limits in Mbps when using HotAdd with the vCenter. These limits are shared across all HotAdd proxies for the Center.
[GraphQL: vCenterHotAddBandwidth]",
            Position = 0
        )]
        public SwitchParameter Hotaddbandwidth { get; set; }

        
        // -------------------------------------------------------------------
        // Advancedtagpreview parameter set
        //
        // [GraphQL: vCenterAdvancedTagPreview]
        //
        [Parameter(
            ParameterSetName = "Advancedtagpreview",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Preview list of virtual machines of a proposed filter condition

Supported in v7.0+
Preview list of virtual machines of a proposed filter condition. The result might not be accurate if new virtual machines were added after last vCenter refresh.
[GraphQL: vCenterAdvancedTagPreview]",
            Position = 0
        )]
        public SwitchParameter Advancedtagpreview { get; set; }


        protected override void ProcessRecord()
        {
            try
            {
                switch(Op)
                {
                    case "Vcenter":
                        this.ProcessRecord_Vcenter();
                        break;
                    case "List":
                        this.ProcessRecord_List();
                        break;
                    case "Uniquecount":
                        this.ProcessRecord_Uniquecount();
                        break;
                    case "Preaddinfo":
                        this.ProcessRecord_Preaddinfo();
                        break;
                    case "Network":
                        this.ProcessRecord_Network();
                        break;
                    case "Hotaddnetwork":
                        this.ProcessRecord_Hotaddnetwork();
                        break;
                    case "Numproxiesneeded":
                        this.ProcessRecord_Numproxiesneeded();
                        break;
                    case "Hotaddproxy":
                        this.ProcessRecord_Hotaddproxy();
                        break;
                    case "Hotaddbandwidth":
                        this.ProcessRecord_Hotaddbandwidth();
                        break;
                    case "Advancedtagpreview":
                        this.ProcessRecord_Advancedtagpreview();
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
        // vSphereVCenter.
        protected void ProcessRecord_Vcenter()
        {
            this._logger.name += " -Vcenter";
            // Invoke graphql operation vSphereVCenter
            InvokeQueryVsphereVcenter();
        }

        // This parameter set invokes a single graphql operation:
        // vSphereVCenterConnection.
        protected void ProcessRecord_List()
        {
            this._logger.name += " -List";
            // Invoke graphql operation vSphereVCenterConnection
            InvokeQueryVsphereVcenterConnection();
        }

        // This parameter set invokes a single graphql operation:
        // uniqueVSphereVCenterCount.
        protected void ProcessRecord_Uniquecount()
        {
            this._logger.name += " -Uniquecount";
            // Invoke graphql operation uniqueVSphereVCenterCount
            InvokeQueryUniqueVsphereVcenterCount();
        }

        // This parameter set invokes a single graphql operation:
        // vCenterPreAddInfo.
        protected void ProcessRecord_Preaddinfo()
        {
            this._logger.name += " -Preaddinfo";
            // Invoke graphql operation vCenterPreAddInfo
            InvokeQueryVcenterPreAddInfo();
        }

        // This parameter set invokes a single graphql operation:
        // vCenterNetworks.
        protected void ProcessRecord_Network()
        {
            this._logger.name += " -Network";
            // Invoke graphql operation vCenterNetworks
            InvokeQueryVcenterNetworks();
        }

        // This parameter set invokes a single graphql operation:
        // vCenterHotAddNetwork.
        protected void ProcessRecord_Hotaddnetwork()
        {
            this._logger.name += " -Hotaddnetwork";
            // Invoke graphql operation vCenterHotAddNetwork
            InvokeQueryVcenterHotAddNetwork();
        }

        // This parameter set invokes a single graphql operation:
        // vCenterNumProxiesNeeded.
        protected void ProcessRecord_Numproxiesneeded()
        {
            this._logger.name += " -Numproxiesneeded";
            // Invoke graphql operation vCenterNumProxiesNeeded
            InvokeQueryVcenterNumProxiesNeeded();
        }

        // This parameter set invokes a single graphql operation:
        // allVcenterHotAddProxyVms.
        protected void ProcessRecord_Hotaddproxy()
        {
            this._logger.name += " -Hotaddproxy";
            // Invoke graphql operation allVcenterHotAddProxyVms
            InvokeQueryAllVcenterHotAddProxyVms();
        }

        // This parameter set invokes a single graphql operation:
        // vCenterHotAddBandwidth.
        protected void ProcessRecord_Hotaddbandwidth()
        {
            this._logger.name += " -Hotaddbandwidth";
            // Invoke graphql operation vCenterHotAddBandwidth
            InvokeQueryVcenterHotAddBandwidth();
        }

        // This parameter set invokes a single graphql operation:
        // vCenterAdvancedTagPreview.
        protected void ProcessRecord_Advancedtagpreview()
        {
            this._logger.name += " -Advancedtagpreview";
            // Invoke graphql operation vCenterAdvancedTagPreview
            InvokeQueryVcenterAdvancedTagPreview();
        }


        // Invoke GraphQL Query:
        // vSphereVCenter(fid: UUID!): VsphereVcenter!
        protected void InvokeQueryVsphereVcenter()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            VsphereVcenter? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (VsphereVcenter)psObject.BaseObject;
                } else {
                    fields = (VsphereVcenter)this.Field;
                }
            }
            string document = Query.VsphereVcenter(ref fields);
            this._input.Initialize(argDefs, fields, "Query.VsphereVcenter");
            var parameters = "($fid: UUID!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryVsphereVcenter" + parameters + "{" + document + "}",
                OperationName = "QueryVsphereVcenter",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "VsphereVcenter", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // vSphereVCenterConnection(
        //     first: Int
        //     after: String
        //     sortBy: HierarchySortByField
        //     sortOrder: SortOrder
        //     filter: [Filter!]
        //   ): VsphereVcenterConnection!
        protected void InvokeQueryVsphereVcenterConnection()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("sortBy", "HierarchySortByField"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("filter", "[Filter!]"),
            };
            VsphereVcenterConnection? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (VsphereVcenterConnection)psObject.BaseObject;
                } else {
                    fields = (VsphereVcenterConnection)this.Field;
                }
            }
            string document = Query.VsphereVcenterConnection(ref fields);
            this._input.Initialize(argDefs, fields, "Query.VsphereVcenterConnection");
            var parameters = "($first: Int,$after: String,$sortBy: HierarchySortByField,$sortOrder: SortOrder,$filter: [Filter!])\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryVsphereVcenterConnection" + parameters + "{" + document + "}",
                OperationName = "QueryVsphereVcenterConnection",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "VsphereVcenterConnection", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // uniqueVSphereVCenterCount(filter: [Filter!]): Int!
        protected void InvokeQueryUniqueVsphereVcenterCount()
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
            string document = Query.UniqueVsphereVcenterCount(ref fields);
            this._input.Initialize(argDefs, fields, "Query.UniqueVsphereVcenterCount");
            var parameters = "($filter: [Filter!])\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryUniqueVsphereVcenterCount" + parameters + "{" + document + "}",
                OperationName = "QueryUniqueVsphereVcenterCount",
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
        // vCenterPreAddInfo(input: PreAddVcenterInput!): VcenterPreAddInfo!
        protected void InvokeQueryVcenterPreAddInfo()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "PreAddVcenterInput!"),
            };
            VcenterPreAddInfo? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (VcenterPreAddInfo)psObject.BaseObject;
                } else {
                    fields = (VcenterPreAddInfo)this.Field;
                }
            }
            string document = Query.VcenterPreAddInfo(ref fields);
            this._input.Initialize(argDefs, fields, "Query.VcenterPreAddInfo");
            var parameters = "($input: PreAddVcenterInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryVcenterPreAddInfo" + parameters + "{" + document + "}",
                OperationName = "QueryVcenterPreAddInfo",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "VcenterPreAddInfo", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // vCenterNetworks(input: GetNetworksInput!): NetworkInfoListResponse!
        protected void InvokeQueryVcenterNetworks()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetNetworksInput!"),
            };
            NetworkInfoListResponse? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (NetworkInfoListResponse)psObject.BaseObject;
                } else {
                    fields = (NetworkInfoListResponse)this.Field;
                }
            }
            string document = Query.VcenterNetworks(ref fields);
            this._input.Initialize(argDefs, fields, "Query.VcenterNetworks");
            var parameters = "($input: GetNetworksInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryVcenterNetworks" + parameters + "{" + document + "}",
                OperationName = "QueryVcenterNetworks",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "NetworkInfoListResponse", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // vCenterHotAddNetwork(input: GetHotAddNetworkInput!): HotAddNetworkConfigWithName!
        protected void InvokeQueryVcenterHotAddNetwork()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetHotAddNetworkInput!"),
            };
            HotAddNetworkConfigWithName? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (HotAddNetworkConfigWithName)psObject.BaseObject;
                } else {
                    fields = (HotAddNetworkConfigWithName)this.Field;
                }
            }
            string document = Query.VcenterHotAddNetwork(ref fields);
            this._input.Initialize(argDefs, fields, "Query.VcenterHotAddNetwork");
            var parameters = "($input: GetHotAddNetworkInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryVcenterHotAddNetwork" + parameters + "{" + document + "}",
                OperationName = "QueryVcenterHotAddNetwork",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "HotAddNetworkConfigWithName", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // vCenterNumProxiesNeeded(input: GetNumProxiesNeededInput!): Int!
        protected void InvokeQueryVcenterNumProxiesNeeded()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetNumProxiesNeededInput!"),
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
            string document = Query.VcenterNumProxiesNeeded(ref fields);
            this._input.Initialize(argDefs, fields, "Query.VcenterNumProxiesNeeded");
            var parameters = "($input: GetNumProxiesNeededInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryVcenterNumProxiesNeeded" + parameters + "{" + document + "}",
                OperationName = "QueryVcenterNumProxiesNeeded",
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
        // allVcenterHotAddProxyVms(clusterUuids: [UUID!]!): [VcenterHotAddProxyVmInfo!]!
        protected void InvokeQueryAllVcenterHotAddProxyVms()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("clusterUuids", "[UUID!]!"),
            };
            List<VcenterHotAddProxyVmInfo>? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (List<VcenterHotAddProxyVmInfo>)psObject.BaseObject;
                } else {
                    fields = (List<VcenterHotAddProxyVmInfo>)this.Field;
                }
            }
            string document = Query.AllVcenterHotAddProxyVms(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AllVcenterHotAddProxyVms");
            var parameters = "($clusterUuids: [UUID!]!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAllVcenterHotAddProxyVms" + parameters + "{" + document + "}",
                OperationName = "QueryAllVcenterHotAddProxyVms",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "List<VcenterHotAddProxyVmInfo>", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // vCenterHotAddBandwidth(input: GetHotAddBandwidthInput!): HotAddBandwidthInfo!
        protected void InvokeQueryVcenterHotAddBandwidth()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetHotAddBandwidthInput!"),
            };
            HotAddBandwidthInfo? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (HotAddBandwidthInfo)psObject.BaseObject;
                } else {
                    fields = (HotAddBandwidthInfo)this.Field;
                }
            }
            string document = Query.VcenterHotAddBandwidth(ref fields);
            this._input.Initialize(argDefs, fields, "Query.VcenterHotAddBandwidth");
            var parameters = "($input: GetHotAddBandwidthInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryVcenterHotAddBandwidth" + parameters + "{" + document + "}",
                OperationName = "QueryVcenterHotAddBandwidth",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "HotAddBandwidthInfo", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // vCenterAdvancedTagPreview(input: PreviewFilterInput!): VcenterAdvancedTagPreviewReply!
        protected void InvokeQueryVcenterAdvancedTagPreview()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "PreviewFilterInput!"),
            };
            VcenterAdvancedTagPreviewReply? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (VcenterAdvancedTagPreviewReply)psObject.BaseObject;
                } else {
                    fields = (VcenterAdvancedTagPreviewReply)this.Field;
                }
            }
            string document = Query.VcenterAdvancedTagPreview(ref fields);
            this._input.Initialize(argDefs, fields, "Query.VcenterAdvancedTagPreview");
            var parameters = "($input: PreviewFilterInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryVcenterAdvancedTagPreview" + parameters + "{" + document + "}",
                OperationName = "QueryVcenterAdvancedTagPreview",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "VcenterAdvancedTagPreviewReply", this._logger, GetMetricTags());
            WriteObject(result, true);
        }


    } // class Invoke_RscQueryVcenter
}