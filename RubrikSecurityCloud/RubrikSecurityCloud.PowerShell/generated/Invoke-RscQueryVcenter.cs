// Invoke-RscQueryVcenter.cs
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
using Rubrik.SecurityCloud.NetSDK.Library.HelperClasses;
using Rubrik.SecurityCloud.Operations;
using GraphQL;

namespace Rubrik.SecurityCloud.PowerShell.Cmdlets
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
        // GraphQL operation: vSphereVCenter(fid: UUID!):VsphereVcenter!
        //
        [Parameter(
            ParameterSetName = "Vcenter",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: vSphereVCenter(fid: UUID!):VsphereVcenter!",
            Position = 0
        )]
        public SwitchParameter Vcenter { get; set; }

        [Parameter(
            ParameterSetName = "Vcenter",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument fid: UUID!"
        )]
        public System.String? Fid { get; set; }
        
        // -------------------------------------------------------------------
        // List parameter set
        //
        // GraphQL operation: vSphereVCenterConnection(,   first: Int,   after: String,   sortBy: HierarchySortByField,   sortOrder: SortOrder,   filter: [Filter!], ):VsphereVcenterConnection!
        //
        [Parameter(
            ParameterSetName = "List",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: vSphereVCenterConnection(,   first: Int,   after: String,   sortBy: HierarchySortByField,   sortOrder: SortOrder,   filter: [Filter!], ):VsphereVcenterConnection!",
            Position = 0
        )]
        public SwitchParameter List { get; set; }

        [Parameter(
            ParameterSetName = "List",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument first: Int"
        )]
        public System.Int32? First { get; set; }
        [Parameter(
            ParameterSetName = "List",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument after: String"
        )]
        public System.String? After { get; set; }
        [Parameter(
            ParameterSetName = "List",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument sortBy: HierarchySortByField"
        )]
        public HierarchySortByField? SortBy { get; set; }
        [Parameter(
            ParameterSetName = "List",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument sortOrder: SortOrder"
        )]
        public SortOrder? SortOrder { get; set; }
        [Parameter(
            ParameterSetName = "List",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument filter: [Filter!]"
        )]
        public List<Filter>? Filter { get; set; }
        
        // -------------------------------------------------------------------
        // PreAddInfo parameter set
        //
        // GraphQL operation: vCenterPreAddInfo(input: PreAddVcenterInput!):VcenterPreAddInfo!
        //
        [Parameter(
            ParameterSetName = "PreAddInfo",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: vCenterPreAddInfo(input: PreAddVcenterInput!):VcenterPreAddInfo!",
            Position = 0
        )]
        public SwitchParameter PreAddInfo { get; set; }

        [Parameter(
            ParameterSetName = "PreAddInfo",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument input: PreAddVcenterInput!"
        )]
        public PreAddVcenterInput? Input { get; set; }
        
        // -------------------------------------------------------------------
        // Network parameter set
        //
        // GraphQL operation: vCenterNetworks(input: GetNetworksInput!):NetworkInfoListResponse!
        //
        [Parameter(
            ParameterSetName = "Network",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: vCenterNetworks(input: GetNetworksInput!):NetworkInfoListResponse!",
            Position = 0
        )]
        public SwitchParameter Network { get; set; }

        
        // -------------------------------------------------------------------
        // HotAddNetwork parameter set
        //
        // GraphQL operation: vCenterHotAddNetwork(input: GetHotAddNetworkInput!):HotAddNetworkConfigWithName!
        //
        [Parameter(
            ParameterSetName = "HotAddNetwork",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: vCenterHotAddNetwork(input: GetHotAddNetworkInput!):HotAddNetworkConfigWithName!",
            Position = 0
        )]
        public SwitchParameter HotAddNetwork { get; set; }

        
        // -------------------------------------------------------------------
        // NumProxiesNeeded parameter set
        //
        // GraphQL operation: vCenterNumProxiesNeeded(input: GetNumProxiesNeededInput!):Int!
        //
        [Parameter(
            ParameterSetName = "NumProxiesNeeded",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: vCenterNumProxiesNeeded(input: GetNumProxiesNeededInput!):Int!",
            Position = 0
        )]
        public SwitchParameter NumProxiesNeeded { get; set; }

        
        // -------------------------------------------------------------------
        // HotAddProxy parameter set
        //
        // GraphQL operation: allVcenterHotAddProxyVms(clusterUuids: [UUID!]!):[VcenterHotAddProxyVmInfo!]!
        //
        [Parameter(
            ParameterSetName = "HotAddProxy",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: allVcenterHotAddProxyVms(clusterUuids: [UUID!]!):[VcenterHotAddProxyVmInfo!]!",
            Position = 0
        )]
        public SwitchParameter HotAddProxy { get; set; }

        [Parameter(
            ParameterSetName = "HotAddProxy",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument clusterUuids: [UUID!]!"
        )]
        public List<System.String>? ClusterUuids { get; set; }
        
        // -------------------------------------------------------------------
        // HotAddBandwidth parameter set
        //
        // GraphQL operation: vCenterHotAddBandwidth(input: GetHotAddBandwidthInput!):HotAddBandwidthInfo!
        //
        [Parameter(
            ParameterSetName = "HotAddBandwidth",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: vCenterHotAddBandwidth(input: GetHotAddBandwidthInput!):HotAddBandwidthInfo!",
            Position = 0
        )]
        public SwitchParameter HotAddBandwidth { get; set; }

        
        // -------------------------------------------------------------------
        // AdvancedTagPreview parameter set
        //
        // GraphQL operation: vCenterAdvancedTagPreview(input: PreviewFilterInput!):VcenterAdvancedTagPreviewReply!
        //
        [Parameter(
            ParameterSetName = "AdvancedTagPreview",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: vCenterAdvancedTagPreview(input: PreviewFilterInput!):VcenterAdvancedTagPreviewReply!",
            Position = 0
        )]
        public SwitchParameter AdvancedTagPreview { get; set; }


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
                    case "PreAddInfo":
                        this.ProcessRecord_PreAddInfo();
                        break;
                    case "Network":
                        this.ProcessRecord_Network();
                        break;
                    case "HotAddNetwork":
                        this.ProcessRecord_HotAddNetwork();
                        break;
                    case "NumProxiesNeeded":
                        this.ProcessRecord_NumProxiesNeeded();
                        break;
                    case "HotAddProxy":
                        this.ProcessRecord_HotAddProxy();
                        break;
                    case "HotAddBandwidth":
                        this.ProcessRecord_HotAddBandwidth();
                        break;
                    case "AdvancedTagPreview":
                        this.ProcessRecord_AdvancedTagPreview();
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
                    "Invoke-RscQueryVcenter",
                    ErrorCategory.InvalidOperation,
                    null);
                ThrowTerminatingError(error);
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
        // vCenterPreAddInfo.
        protected void ProcessRecord_PreAddInfo()
        {
            this._logger.name += " -PreAddInfo";
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
        protected void ProcessRecord_HotAddNetwork()
        {
            this._logger.name += " -HotAddNetwork";
            // Invoke graphql operation vCenterHotAddNetwork
            InvokeQueryVcenterHotAddNetwork();
        }

        // This parameter set invokes a single graphql operation:
        // vCenterNumProxiesNeeded.
        protected void ProcessRecord_NumProxiesNeeded()
        {
            this._logger.name += " -NumProxiesNeeded";
            // Invoke graphql operation vCenterNumProxiesNeeded
            InvokeQueryVcenterNumProxiesNeeded();
        }

        // This parameter set invokes a single graphql operation:
        // allVcenterHotAddProxyVms.
        protected void ProcessRecord_HotAddProxy()
        {
            this._logger.name += " -HotAddProxy";
            // Invoke graphql operation allVcenterHotAddProxyVms
            InvokeQueryAllVcenterHotAddProxyVms();
        }

        // This parameter set invokes a single graphql operation:
        // vCenterHotAddBandwidth.
        protected void ProcessRecord_HotAddBandwidth()
        {
            this._logger.name += " -HotAddBandwidth";
            // Invoke graphql operation vCenterHotAddBandwidth
            InvokeQueryVcenterHotAddBandwidth();
        }

        // This parameter set invokes a single graphql operation:
        // vCenterAdvancedTagPreview.
        protected void ProcessRecord_AdvancedTagPreview()
        {
            this._logger.name += " -AdvancedTagPreview";
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (VsphereVcenter)psObject.BaseObject;
                } else {
                    fields = (VsphereVcenter)this.Field;
                }
            }
            string document = Query.VsphereVcenter(ref fields);
            this._input.Initialize(argDefs, fields, "Query.VsphereVcenter");
            string parameters = "($fid: UUID!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryVsphereVcenter" + parameters + "{" + document + "}",
                OperationName = "QueryVsphereVcenter",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<VsphereVcenter> task = this._rbkClient.InvokeGenericCallAsync<VsphereVcenter>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (VsphereVcenterConnection)psObject.BaseObject;
                } else {
                    fields = (VsphereVcenterConnection)this.Field;
                }
            }
            string document = Query.VsphereVcenterConnection(ref fields);
            this._input.Initialize(argDefs, fields, "Query.VsphereVcenterConnection");
            string parameters = "($first: Int,$after: String,$sortBy: HierarchySortByField,$sortOrder: SortOrder,$filter: [Filter!])\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryVsphereVcenterConnection" + parameters + "{" + document + "}",
                OperationName = "QueryVsphereVcenterConnection",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<VsphereVcenterConnection> task = this._rbkClient.InvokeGenericCallAsync<VsphereVcenterConnection>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (VcenterPreAddInfo)psObject.BaseObject;
                } else {
                    fields = (VcenterPreAddInfo)this.Field;
                }
            }
            string document = Query.VcenterPreAddInfo(ref fields);
            this._input.Initialize(argDefs, fields, "Query.VcenterPreAddInfo");
            string parameters = "($input: PreAddVcenterInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryVcenterPreAddInfo" + parameters + "{" + document + "}",
                OperationName = "QueryVcenterPreAddInfo",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<VcenterPreAddInfo> task = this._rbkClient.InvokeGenericCallAsync<VcenterPreAddInfo>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (NetworkInfoListResponse)psObject.BaseObject;
                } else {
                    fields = (NetworkInfoListResponse)this.Field;
                }
            }
            string document = Query.VcenterNetworks(ref fields);
            this._input.Initialize(argDefs, fields, "Query.VcenterNetworks");
            string parameters = "($input: GetNetworksInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryVcenterNetworks" + parameters + "{" + document + "}",
                OperationName = "QueryVcenterNetworks",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<NetworkInfoListResponse> task = this._rbkClient.InvokeGenericCallAsync<NetworkInfoListResponse>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (HotAddNetworkConfigWithName)psObject.BaseObject;
                } else {
                    fields = (HotAddNetworkConfigWithName)this.Field;
                }
            }
            string document = Query.VcenterHotAddNetwork(ref fields);
            this._input.Initialize(argDefs, fields, "Query.VcenterHotAddNetwork");
            string parameters = "($input: GetHotAddNetworkInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryVcenterHotAddNetwork" + parameters + "{" + document + "}",
                OperationName = "QueryVcenterHotAddNetwork",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<HotAddNetworkConfigWithName> task = this._rbkClient.InvokeGenericCallAsync<HotAddNetworkConfigWithName>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (System.Int32)psObject.BaseObject;
                } else {
                    fields = (System.Int32)this.Field;
                }
            }
            string document = Query.VcenterNumProxiesNeeded(ref fields);
            this._input.Initialize(argDefs, fields, "Query.VcenterNumProxiesNeeded");
            string parameters = "($input: GetNumProxiesNeededInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryVcenterNumProxiesNeeded" + parameters + "{" + document + "}",
                OperationName = "QueryVcenterNumProxiesNeeded",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<System.Int32> task = this._rbkClient.InvokeGenericCallAsync<System.Int32>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (List<VcenterHotAddProxyVmInfo>)psObject.BaseObject;
                } else {
                    fields = (List<VcenterHotAddProxyVmInfo>)this.Field;
                }
            }
            string document = Query.AllVcenterHotAddProxyVms(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AllVcenterHotAddProxyVms");
            string parameters = "($clusterUuids: [UUID!]!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAllVcenterHotAddProxyVms" + parameters + "{" + document + "}",
                OperationName = "QueryAllVcenterHotAddProxyVms",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<List<VcenterHotAddProxyVmInfo>> task = this._rbkClient.InvokeGenericCallAsync<List<VcenterHotAddProxyVmInfo>>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (HotAddBandwidthInfo)psObject.BaseObject;
                } else {
                    fields = (HotAddBandwidthInfo)this.Field;
                }
            }
            string document = Query.VcenterHotAddBandwidth(ref fields);
            this._input.Initialize(argDefs, fields, "Query.VcenterHotAddBandwidth");
            string parameters = "($input: GetHotAddBandwidthInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryVcenterHotAddBandwidth" + parameters + "{" + document + "}",
                OperationName = "QueryVcenterHotAddBandwidth",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<HotAddBandwidthInfo> task = this._rbkClient.InvokeGenericCallAsync<HotAddBandwidthInfo>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (VcenterAdvancedTagPreviewReply)psObject.BaseObject;
                } else {
                    fields = (VcenterAdvancedTagPreviewReply)this.Field;
                }
            }
            string document = Query.VcenterAdvancedTagPreview(ref fields);
            this._input.Initialize(argDefs, fields, "Query.VcenterAdvancedTagPreview");
            string parameters = "($input: PreviewFilterInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryVcenterAdvancedTagPreview" + parameters + "{" + document + "}",
                OperationName = "QueryVcenterAdvancedTagPreview",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<VcenterAdvancedTagPreviewReply> task = this._rbkClient.InvokeGenericCallAsync<VcenterAdvancedTagPreviewReply>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }


    } // class Invoke_RscQueryVcenter
}