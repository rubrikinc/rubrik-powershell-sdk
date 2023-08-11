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
        
        /// <summary>
        /// Vcenter parameter set
        ///
        /// [GraphQL: vSphereVCenter]
        /// </summary>
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

        
        /// <summary>
        /// List parameter set
        ///
        /// [GraphQL: vSphereVCenterConnection]
        /// </summary>
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

        
        /// <summary>
        /// UniqueCount parameter set
        ///
        /// [GraphQL: uniqueVSphereVCenterCount]
        /// </summary>
        [Parameter(
            ParameterSetName = "UniqueCount",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"
[GraphQL: uniqueVSphereVCenterCount]",
            Position = 0
        )]
        public SwitchParameter UniqueCount { get; set; }

        
        /// <summary>
        /// PreAddInfo parameter set
        ///
        /// [GraphQL: vCenterPreAddInfo]
        /// </summary>
        [Parameter(
            ParameterSetName = "PreAddInfo",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Get preAddInfo for a vcenter.
[GraphQL: vCenterPreAddInfo]",
            Position = 0
        )]
        public SwitchParameter PreAddInfo { get; set; }

        
        /// <summary>
        /// Networks parameter set
        ///
        /// [GraphQL: vCenterNetworks]
        /// </summary>
        [Parameter(
            ParameterSetName = "Networks",
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
        public SwitchParameter Networks { get; set; }

        
        /// <summary>
        /// HotAddNetwork parameter set
        ///
        /// [GraphQL: vCenterHotAddNetwork]
        /// </summary>
        [Parameter(
            ParameterSetName = "HotAddNetwork",
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
        public SwitchParameter HotAddNetwork { get; set; }

        
        /// <summary>
        /// NumProxiesNeeded parameter set
        ///
        /// [GraphQL: vCenterNumProxiesNeeded]
        /// </summary>
        [Parameter(
            ParameterSetName = "NumProxiesNeeded",
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
        public SwitchParameter NumProxiesNeeded { get; set; }

        
        /// <summary>
        /// HotAddProxy parameter set
        ///
        /// [GraphQL: allVcenterHotAddProxyVms]
        /// </summary>
        [Parameter(
            ParameterSetName = "HotAddProxy",
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
        public SwitchParameter HotAddProxy { get; set; }

        
        /// <summary>
        /// HotAddBandwidth parameter set
        ///
        /// [GraphQL: vCenterHotAddBandwidth]
        /// </summary>
        [Parameter(
            ParameterSetName = "HotAddBandwidth",
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
        public SwitchParameter HotAddBandwidth { get; set; }

        
        /// <summary>
        /// AdvancedTagPreview parameter set
        ///
        /// [GraphQL: vCenterAdvancedTagPreview]
        /// </summary>
        [Parameter(
            ParameterSetName = "AdvancedTagPreview",
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
        public SwitchParameter AdvancedTagPreview { get; set; }


// ignore warning 'Missing XML comment'
#pragma warning disable 1591
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
                    case "UniqueCount":
                        this.ProcessRecord_UniqueCount();
                        break;
                    case "PreAddInfo":
                        this.ProcessRecord_PreAddInfo();
                        break;
                    case "Networks":
                        this.ProcessRecord_Networks();
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
                ThrowTerminatingException(ex);
           }
        }
#pragma warning restore 1591

        // This parameter set invokes a single graphql operation:
        // vSphereVCenter.
        internal void ProcessRecord_Vcenter()
        {
            this._logger.name += " -Vcenter";
            // Invoke graphql operation vSphereVCenter
            InvokeQueryVsphereVcenter();
        }

        // This parameter set invokes a single graphql operation:
        // vSphereVCenterConnection.
        internal void ProcessRecord_List()
        {
            this._logger.name += " -List";
            // Invoke graphql operation vSphereVCenterConnection
            InvokeQueryVsphereVcenterConnection();
        }

        // This parameter set invokes a single graphql operation:
        // uniqueVSphereVCenterCount.
        internal void ProcessRecord_UniqueCount()
        {
            this._logger.name += " -UniqueCount";
            // Invoke graphql operation uniqueVSphereVCenterCount
            InvokeQueryUniqueVsphereVcenterCount();
        }

        // This parameter set invokes a single graphql operation:
        // vCenterPreAddInfo.
        internal void ProcessRecord_PreAddInfo()
        {
            this._logger.name += " -PreAddInfo";
            // Invoke graphql operation vCenterPreAddInfo
            InvokeQueryVcenterPreAddInfo();
        }

        // This parameter set invokes a single graphql operation:
        // vCenterNetworks.
        internal void ProcessRecord_Networks()
        {
            this._logger.name += " -Networks";
            // Invoke graphql operation vCenterNetworks
            InvokeQueryVcenterNetworks();
        }

        // This parameter set invokes a single graphql operation:
        // vCenterHotAddNetwork.
        internal void ProcessRecord_HotAddNetwork()
        {
            this._logger.name += " -HotAddNetwork";
            // Invoke graphql operation vCenterHotAddNetwork
            InvokeQueryVcenterHotAddNetwork();
        }

        // This parameter set invokes a single graphql operation:
        // vCenterNumProxiesNeeded.
        internal void ProcessRecord_NumProxiesNeeded()
        {
            this._logger.name += " -NumProxiesNeeded";
            // Invoke graphql operation vCenterNumProxiesNeeded
            InvokeQueryVcenterNumProxiesNeeded();
        }

        // This parameter set invokes a single graphql operation:
        // allVcenterHotAddProxyVms.
        internal void ProcessRecord_HotAddProxy()
        {
            this._logger.name += " -HotAddProxy";
            // Invoke graphql operation allVcenterHotAddProxyVms
            InvokeQueryAllVcenterHotAddProxyVms();
        }

        // This parameter set invokes a single graphql operation:
        // vCenterHotAddBandwidth.
        internal void ProcessRecord_HotAddBandwidth()
        {
            this._logger.name += " -HotAddBandwidth";
            // Invoke graphql operation vCenterHotAddBandwidth
            InvokeQueryVcenterHotAddBandwidth();
        }

        // This parameter set invokes a single graphql operation:
        // vCenterAdvancedTagPreview.
        internal void ProcessRecord_AdvancedTagPreview()
        {
            this._logger.name += " -AdvancedTagPreview";
            // Invoke graphql operation vCenterAdvancedTagPreview
            InvokeQueryVcenterAdvancedTagPreview();
        }


        // Invoke GraphQL Query:
        // vSphereVCenter(fid: UUID!): VsphereVcenter!
        internal void InvokeQueryVsphereVcenter()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            VsphereVcenter? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (VsphereVcenter)psObject.BaseObject;
                } else {
                    fieldSpecObj = (VsphereVcenter)this.Field;
                }
            }
            string fieldSpecDoc = Query.VsphereVcenter(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryVsphereVcenter",
                "($fid: UUID!)",
                fieldSpecDoc,
                "VsphereVcenter"
            );
        }

        // Invoke GraphQL Query:
        // vSphereVCenterConnection(
        //     first: Int
        //     after: String
        //     sortBy: HierarchySortByField
        //     sortOrder: SortOrder
        //     filter: [Filter!]
        //   ): VsphereVcenterConnection!
        internal void InvokeQueryVsphereVcenterConnection()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("sortBy", "HierarchySortByField"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("filter", "[Filter!]"),
            };
            VsphereVcenterConnection? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (VsphereVcenterConnection)psObject.BaseObject;
                } else {
                    fieldSpecObj = (VsphereVcenterConnection)this.Field;
                }
            }
            string fieldSpecDoc = Query.VsphereVcenterConnection(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryVsphereVcenterConnection",
                "($first: Int,$after: String,$sortBy: HierarchySortByField,$sortOrder: SortOrder,$filter: [Filter!])",
                fieldSpecDoc,
                "VsphereVcenterConnection"
            );
        }

        // Invoke GraphQL Query:
        // uniqueVSphereVCenterCount(filter: [Filter!]): Int!
        internal void InvokeQueryUniqueVsphereVcenterCount()
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
            string fieldSpecDoc = Query.UniqueVsphereVcenterCount(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryUniqueVsphereVcenterCount",
                "($filter: [Filter!])",
                fieldSpecDoc,
                "System.Int32"
            );
        }

        // Invoke GraphQL Query:
        // vCenterPreAddInfo(input: PreAddVcenterInput!): VcenterPreAddInfo!
        internal void InvokeQueryVcenterPreAddInfo()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "PreAddVcenterInput!"),
            };
            VcenterPreAddInfo? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (VcenterPreAddInfo)psObject.BaseObject;
                } else {
                    fieldSpecObj = (VcenterPreAddInfo)this.Field;
                }
            }
            string fieldSpecDoc = Query.VcenterPreAddInfo(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryVcenterPreAddInfo",
                "($input: PreAddVcenterInput!)",
                fieldSpecDoc,
                "VcenterPreAddInfo"
            );
        }

        // Invoke GraphQL Query:
        // vCenterNetworks(input: GetNetworksInput!): NetworkInfoListResponse!
        internal void InvokeQueryVcenterNetworks()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetNetworksInput!"),
            };
            NetworkInfoListResponse? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (NetworkInfoListResponse)psObject.BaseObject;
                } else {
                    fieldSpecObj = (NetworkInfoListResponse)this.Field;
                }
            }
            string fieldSpecDoc = Query.VcenterNetworks(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryVcenterNetworks",
                "($input: GetNetworksInput!)",
                fieldSpecDoc,
                "NetworkInfoListResponse"
            );
        }

        // Invoke GraphQL Query:
        // vCenterHotAddNetwork(input: GetHotAddNetworkInput!): HotAddNetworkConfigWithName!
        internal void InvokeQueryVcenterHotAddNetwork()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetHotAddNetworkInput!"),
            };
            HotAddNetworkConfigWithName? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (HotAddNetworkConfigWithName)psObject.BaseObject;
                } else {
                    fieldSpecObj = (HotAddNetworkConfigWithName)this.Field;
                }
            }
            string fieldSpecDoc = Query.VcenterHotAddNetwork(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryVcenterHotAddNetwork",
                "($input: GetHotAddNetworkInput!)",
                fieldSpecDoc,
                "HotAddNetworkConfigWithName"
            );
        }

        // Invoke GraphQL Query:
        // vCenterNumProxiesNeeded(input: GetNumProxiesNeededInput!): Int!
        internal void InvokeQueryVcenterNumProxiesNeeded()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetNumProxiesNeededInput!"),
            };
            System.Int32? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (System.Int32)psObject.BaseObject;
                } else {
                    fieldSpecObj = (System.Int32)this.Field;
                }
            }
            string fieldSpecDoc = Query.VcenterNumProxiesNeeded(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryVcenterNumProxiesNeeded",
                "($input: GetNumProxiesNeededInput!)",
                fieldSpecDoc,
                "System.Int32"
            );
        }

        // Invoke GraphQL Query:
        // allVcenterHotAddProxyVms(clusterUuids: [UUID!]!): [VcenterHotAddProxyVmInfo!]!
        internal void InvokeQueryAllVcenterHotAddProxyVms()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("clusterUuids", "[UUID!]!"),
            };
            List<VcenterHotAddProxyVmInfo>? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (List<VcenterHotAddProxyVmInfo>)psObject.BaseObject;
                } else {
                    fieldSpecObj = (List<VcenterHotAddProxyVmInfo>)this.Field;
                }
            }
            string fieldSpecDoc = Query.AllVcenterHotAddProxyVms(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryAllVcenterHotAddProxyVms",
                "($clusterUuids: [UUID!]!)",
                fieldSpecDoc,
                "List<VcenterHotAddProxyVmInfo>"
            );
        }

        // Invoke GraphQL Query:
        // vCenterHotAddBandwidth(input: GetHotAddBandwidthInput!): HotAddBandwidthInfo!
        internal void InvokeQueryVcenterHotAddBandwidth()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetHotAddBandwidthInput!"),
            };
            HotAddBandwidthInfo? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (HotAddBandwidthInfo)psObject.BaseObject;
                } else {
                    fieldSpecObj = (HotAddBandwidthInfo)this.Field;
                }
            }
            string fieldSpecDoc = Query.VcenterHotAddBandwidth(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryVcenterHotAddBandwidth",
                "($input: GetHotAddBandwidthInput!)",
                fieldSpecDoc,
                "HotAddBandwidthInfo"
            );
        }

        // Invoke GraphQL Query:
        // vCenterAdvancedTagPreview(input: PreviewFilterInput!): VcenterAdvancedTagPreviewReply!
        internal void InvokeQueryVcenterAdvancedTagPreview()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "PreviewFilterInput!"),
            };
            VcenterAdvancedTagPreviewReply? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (VcenterAdvancedTagPreviewReply)psObject.BaseObject;
                } else {
                    fieldSpecObj = (VcenterAdvancedTagPreviewReply)this.Field;
                }
            }
            string fieldSpecDoc = Query.VcenterAdvancedTagPreview(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryVcenterAdvancedTagPreview",
                "($input: PreviewFilterInput!)",
                fieldSpecDoc,
                "VcenterAdvancedTagPreviewReply"
            );
        }


    } // class Invoke_RscQueryVcenter
}