// New-RscQueryVcenter.cs
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
    /// Queries for the 'vSphere vCenter' API domain.
    /// </summary>
    /// <description>
    /// New-RscQueryVcenter is the cmdlet to work with operations in the {self.noun} API domain. It is a dynamic cmdlet that accepts any {self.noun} API operation as its first parameter:  {sc_names}.
    /// </description>
    /// <example>
    /// <code>New-RscQueryVcenter -Vcenter [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryVcenter -List [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryVcenter -PreAddInfo [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryVcenter -Networks [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryVcenter -HotAddNetwork [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryVcenter -NumProxiesNeeded [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryVcenter -HotAddProxy [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryVcenter -HotAddBandwidth [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryVcenter -AdvancedTagPreview [-Arg ..] [-Field ..]</code>
    /// </example>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscQueryVcenter",
        DefaultParameterSetName = "Vcenter")
    ]
    public class New_RscQueryVcenter : RscGqlPSCmdlet
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
            base.ProcessRecord();
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
            // Create new graphql operation vSphereVCenter
            InitQueryVsphereVcenter();
        }

        // This parameter set invokes a single graphql operation:
        // vSphereVCenterConnection.
        internal void ProcessRecord_List()
        {
            this._logger.name += " -List";
            // Create new graphql operation vSphereVCenterConnection
            InitQueryVsphereVcenterConnection();
        }

        // This parameter set invokes a single graphql operation:
        // vCenterPreAddInfo.
        internal void ProcessRecord_PreAddInfo()
        {
            this._logger.name += " -PreAddInfo";
            // Create new graphql operation vCenterPreAddInfo
            InitQueryVcenterPreAddInfo();
        }

        // This parameter set invokes a single graphql operation:
        // vCenterNetworks.
        internal void ProcessRecord_Networks()
        {
            this._logger.name += " -Networks";
            // Create new graphql operation vCenterNetworks
            InitQueryVcenterNetworks();
        }

        // This parameter set invokes a single graphql operation:
        // vCenterHotAddNetwork.
        internal void ProcessRecord_HotAddNetwork()
        {
            this._logger.name += " -HotAddNetwork";
            // Create new graphql operation vCenterHotAddNetwork
            InitQueryVcenterHotAddNetwork();
        }

        // This parameter set invokes a single graphql operation:
        // vCenterNumProxiesNeeded.
        internal void ProcessRecord_NumProxiesNeeded()
        {
            this._logger.name += " -NumProxiesNeeded";
            // Create new graphql operation vCenterNumProxiesNeeded
            InitQueryVcenterNumProxiesNeeded();
        }

        // This parameter set invokes a single graphql operation:
        // allVcenterHotAddProxyVms.
        internal void ProcessRecord_HotAddProxy()
        {
            this._logger.name += " -HotAddProxy";
            // Create new graphql operation allVcenterHotAddProxyVms
            InitQueryAllVcenterHotAddProxyVms();
        }

        // This parameter set invokes a single graphql operation:
        // vCenterHotAddBandwidth.
        internal void ProcessRecord_HotAddBandwidth()
        {
            this._logger.name += " -HotAddBandwidth";
            // Create new graphql operation vCenterHotAddBandwidth
            InitQueryVcenterHotAddBandwidth();
        }

        // This parameter set invokes a single graphql operation:
        // vCenterAdvancedTagPreview.
        internal void ProcessRecord_AdvancedTagPreview()
        {
            this._logger.name += " -AdvancedTagPreview";
            // Create new graphql operation vCenterAdvancedTagPreview
            InitQueryVcenterAdvancedTagPreview();
        }


        // Create new GraphQL Query:
        // vSphereVCenter(fid: UUID!): VsphereVcenter!
        internal void InitQueryVsphereVcenter()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryVsphereVcenter",
                "($fid: UUID!)",
                "VsphereVcenter",
                Query.VsphereVcenter_ObjectFieldSpec,
                Query.VsphereVcenterFieldSpec,
                @"# REQUIRED
$inputs.Var.fid = <System.String>"
            );
        }

        // Create new GraphQL Query:
        // vSphereVCenterConnection(
        //     first: Int
        //     after: String
        //     sortBy: HierarchySortByField
        //     sortOrder: SortOrder
        //     filter: [Filter!]
        //   ): VsphereVcenterConnection!
        internal void InitQueryVsphereVcenterConnection()
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
                "QueryVsphereVcenterConnection",
                "($first: Int,$after: String,$sortBy: HierarchySortByField,$sortOrder: SortOrder,$filter: [Filter!])",
                "VsphereVcenterConnection",
                Query.VsphereVcenterConnection_ObjectFieldSpec,
                Query.VsphereVcenterConnectionFieldSpec,
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
        // vCenterPreAddInfo(input: PreAddVcenterInput!): VcenterPreAddInfo!
        internal void InitQueryVcenterPreAddInfo()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "PreAddVcenterInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryVcenterPreAddInfo",
                "($input: PreAddVcenterInput!)",
                "VcenterPreAddInfo",
                Query.VcenterPreAddInfo_ObjectFieldSpec,
                Query.VcenterPreAddInfoFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	clusterUuid = <System.String>
	# REQUIRED
	vcenterConfig = @{
		# OPTIONAL
		connectionConfig = @{
			# OPTIONAL
			caCerts = <System.String>
			# REQUIRED
			hostname = <System.String>
			# REQUIRED
			password = <System.String>
			# REQUIRED
			username = <System.String>
		}
		# OPTIONAL
		id = <System.String>
	}
}"
            );
        }

        // Create new GraphQL Query:
        // vCenterNetworks(input: GetNetworksInput!): NetworkInfoListResponse!
        internal void InitQueryVcenterNetworks()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetNetworksInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryVcenterNetworks",
                "($input: GetNetworksInput!)",
                "NetworkInfoListResponse",
                Query.VcenterNetworks_ObjectFieldSpec,
                Query.VcenterNetworksFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
}"
            );
        }

        // Create new GraphQL Query:
        // vCenterHotAddNetwork(input: GetHotAddNetworkInput!): HotAddNetworkConfigWithName!
        internal void InitQueryVcenterHotAddNetwork()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetHotAddNetworkInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryVcenterHotAddNetwork",
                "($input: GetHotAddNetworkInput!)",
                "HotAddNetworkConfigWithName",
                Query.VcenterHotAddNetwork_ObjectFieldSpec,
                Query.VcenterHotAddNetworkFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
}"
            );
        }

        // Create new GraphQL Query:
        // vCenterNumProxiesNeeded(input: GetNumProxiesNeededInput!): Int!
        internal void InitQueryVcenterNumProxiesNeeded()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetNumProxiesNeededInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryVcenterNumProxiesNeeded",
                "($input: GetNumProxiesNeededInput!)",
                "System.Int32",
                Query.VcenterNumProxiesNeeded_ObjectFieldSpec,
                Query.VcenterNumProxiesNeededFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
}"
            );
        }

        // Create new GraphQL Query:
        // allVcenterHotAddProxyVms(clusterUuids: [UUID!]!): [VcenterHotAddProxyVmInfo!]!
        internal void InitQueryAllVcenterHotAddProxyVms()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("clusterUuids", "[UUID!]!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllVcenterHotAddProxyVms",
                "($clusterUuids: [UUID!]!)",
                "List<VcenterHotAddProxyVmInfo>",
                Query.AllVcenterHotAddProxyVms_ObjectFieldSpec,
                Query.AllVcenterHotAddProxyVmsFieldSpec,
                @"# REQUIRED
$inputs.Var.clusterUuids = @(
	<System.String>
)"
            );
        }

        // Create new GraphQL Query:
        // vCenterHotAddBandwidth(input: GetHotAddBandwidthInput!): HotAddBandwidthInfo!
        internal void InitQueryVcenterHotAddBandwidth()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetHotAddBandwidthInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryVcenterHotAddBandwidth",
                "($input: GetHotAddBandwidthInput!)",
                "HotAddBandwidthInfo",
                Query.VcenterHotAddBandwidth_ObjectFieldSpec,
                Query.VcenterHotAddBandwidthFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
}"
            );
        }

        // Create new GraphQL Query:
        // vCenterAdvancedTagPreview(input: PreviewFilterInput!): VcenterAdvancedTagPreviewReply!
        internal void InitQueryVcenterAdvancedTagPreview()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "PreviewFilterInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryVcenterAdvancedTagPreview",
                "($input: PreviewFilterInput!)",
                "VcenterAdvancedTagPreviewReply",
                Query.VcenterAdvancedTagPreview_ObjectFieldSpec,
                Query.VcenterAdvancedTagPreviewFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# OPTIONAL
	limit = <System.Int32>
	# OPTIONAL
	offset = <System.Int32>
	# REQUIRED
	filterCondition = <System.String>
	# REQUIRED
	id = <System.String>
}"
            );
        }


    } // class New_RscQueryVcenter
}