// New-RscQueryHyperv.cs
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
    /// Queries for the 'Hyperv' API domain.
    /// </summary>
    /// <description>
    /// New-RscQueryHyperv is a master cmdlet for Hyperv work that can invoke any of the following subcommands: TopLevelDescendants, VirtualMachines, Scvmm, Cluster, Server, VirtualMachine, UniqueServersCount, Scvmms, Servers, Mounts, VmDetail, HostAsyncRequestStatus, ScvmmAsyncRequestStatus, VirtualMachineAsyncRequestStatus.
    /// </description>
    /// <example>
    /// <code>New-RscQueryHyperv -TopLevelDescendants [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryHyperv -VirtualMachines [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryHyperv -Scvmm [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryHyperv -Cluster [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryHyperv -Server [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryHyperv -VirtualMachine [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryHyperv -UniqueServersCount [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryHyperv -Scvmms [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryHyperv -Servers [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryHyperv -Mounts [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryHyperv -VmDetail [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryHyperv -HostAsyncRequestStatus [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryHyperv -ScvmmAsyncRequestStatus [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryHyperv -VirtualMachineAsyncRequestStatus [-Arg ..] [-Field ..]</code>
    /// </example>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscQueryHyperv",
        DefaultParameterSetName = "Cluster")
    ]
    public class New_RscQueryHyperv : RscGqlPSCmdlet
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
            base.ProcessRecord();
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
            // Create new graphql operation hypervTopLevelDescendants
            InitQueryHypervTopLevelDescendants();
        }

        // This parameter set invokes a single graphql operation:
        // hypervVirtualMachines.
        internal void ProcessRecord_VirtualMachines()
        {
            this._logger.name += " -VirtualMachines";
            // Create new graphql operation hypervVirtualMachines
            InitQueryHypervVirtualMachines();
        }

        // This parameter set invokes a single graphql operation:
        // hypervScvmm.
        internal void ProcessRecord_Scvmm()
        {
            this._logger.name += " -Scvmm";
            // Create new graphql operation hypervScvmm
            InitQueryHypervScvmm();
        }

        // This parameter set invokes a single graphql operation:
        // hypervCluster.
        internal void ProcessRecord_Cluster()
        {
            this._logger.name += " -Cluster";
            // Create new graphql operation hypervCluster
            InitQueryHypervCluster();
        }

        // This parameter set invokes a single graphql operation:
        // hypervServer.
        internal void ProcessRecord_Server()
        {
            this._logger.name += " -Server";
            // Create new graphql operation hypervServer
            InitQueryHypervServer();
        }

        // This parameter set invokes a single graphql operation:
        // hypervVirtualMachine.
        internal void ProcessRecord_VirtualMachine()
        {
            this._logger.name += " -VirtualMachine";
            // Create new graphql operation hypervVirtualMachine
            InitQueryHypervVirtualMachine();
        }

        // This parameter set invokes a single graphql operation:
        // uniqueHypervServersCount.
        internal void ProcessRecord_UniqueServersCount()
        {
            this._logger.name += " -UniqueServersCount";
            // Create new graphql operation uniqueHypervServersCount
            InitQueryUniqueHypervServersCount();
        }

        // This parameter set invokes a single graphql operation:
        // hypervScvmms.
        internal void ProcessRecord_Scvmms()
        {
            this._logger.name += " -Scvmms";
            // Create new graphql operation hypervScvmms
            InitQueryHypervScvmms();
        }

        // This parameter set invokes a single graphql operation:
        // hypervServers.
        internal void ProcessRecord_Servers()
        {
            this._logger.name += " -Servers";
            // Create new graphql operation hypervServers
            InitQueryHypervServers();
        }

        // This parameter set invokes a single graphql operation:
        // hypervMounts.
        internal void ProcessRecord_Mounts()
        {
            this._logger.name += " -Mounts";
            // Create new graphql operation hypervMounts
            InitQueryHypervMounts();
        }

        // This parameter set invokes a single graphql operation:
        // hypervVmDetail.
        internal void ProcessRecord_VmDetail()
        {
            this._logger.name += " -VmDetail";
            // Create new graphql operation hypervVmDetail
            InitQueryHypervVmDetail();
        }

        // This parameter set invokes a single graphql operation:
        // hypervHostAsyncRequestStatus.
        internal void ProcessRecord_HostAsyncRequestStatus()
        {
            this._logger.name += " -HostAsyncRequestStatus";
            // Create new graphql operation hypervHostAsyncRequestStatus
            InitQueryHypervHostAsyncRequestStatus();
        }

        // This parameter set invokes a single graphql operation:
        // hypervScvmmAsyncRequestStatus.
        internal void ProcessRecord_ScvmmAsyncRequestStatus()
        {
            this._logger.name += " -ScvmmAsyncRequestStatus";
            // Create new graphql operation hypervScvmmAsyncRequestStatus
            InitQueryHypervScvmmAsyncRequestStatus();
        }

        // This parameter set invokes a single graphql operation:
        // hypervVirtualMachineAsyncRequestStatus.
        internal void ProcessRecord_VirtualMachineAsyncRequestStatus()
        {
            this._logger.name += " -VirtualMachineAsyncRequestStatus";
            // Create new graphql operation hypervVirtualMachineAsyncRequestStatus
            InitQueryHypervVirtualMachineAsyncRequestStatus();
        }


        // Create new GraphQL Query:
        // hypervTopLevelDescendants(
        //     first: Int
        //     after: String
        //     sortBy: HierarchySortByField
        //     sortOrder: SortOrder
        //     typeFilter: [HierarchyObjectTypeEnum!]
        //     filter: [Filter!]
        //   ): HypervTopLevelDescendantTypeConnection!
        internal void InitQueryHypervTopLevelDescendants()
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
                "HypervTopLevelDescendantTypeConnection",
                Query.HypervTopLevelDescendants_ObjectFieldSpec,
                Query.HypervTopLevelDescendantsFieldSpec,
                @"# OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# OPTIONAL
$inputs.Var.sortBy = <HierarchySortByField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchySortByField]) for enum values.
# OPTIONAL
$inputs.Var.sortOrder = <SortOrder> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$inputs.Var.typeFilter = @(
	<HierarchyObjectTypeEnum> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchyObjectTypeEnum]) for enum values.
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
)"
            );
        }

        // Create new GraphQL Query:
        // hypervVirtualMachines(
        //     first: Int
        //     after: String
        //     sortBy: HierarchySortByField
        //     sortOrder: SortOrder
        //     filter: [Filter!]
        //   ): HyperVVirtualMachineConnection!
        internal void InitQueryHypervVirtualMachines()
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
                "HyperVvirtualMachineConnection",
                Query.HypervVirtualMachines_ObjectFieldSpec,
                Query.HypervVirtualMachinesFieldSpec,
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
        // hypervScvmm(fid: UUID!): HyperVSCVMM!
        internal void InitQueryHypervScvmm()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryHypervScvmm",
                "($fid: UUID!)",
                "HyperVscvmm",
                Query.HypervScvmm_ObjectFieldSpec,
                Query.HypervScvmmFieldSpec,
                @"# REQUIRED
$inputs.Var.fid = <System.String>"
            );
        }

        // Create new GraphQL Query:
        // hypervCluster(fid: UUID!): HyperVCluster!
        internal void InitQueryHypervCluster()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryHypervCluster",
                "($fid: UUID!)",
                "HyperVcluster",
                Query.HypervCluster_ObjectFieldSpec,
                Query.HypervClusterFieldSpec,
                @"# REQUIRED
$inputs.Var.fid = <System.String>"
            );
        }

        // Create new GraphQL Query:
        // hypervServer(fid: UUID!): HypervServer!
        internal void InitQueryHypervServer()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryHypervServer",
                "($fid: UUID!)",
                "HypervServer",
                Query.HypervServer_ObjectFieldSpec,
                Query.HypervServerFieldSpec,
                @"# REQUIRED
$inputs.Var.fid = <System.String>"
            );
        }

        // Create new GraphQL Query:
        // hypervVirtualMachine(fid: UUID!): HyperVVirtualMachine!
        internal void InitQueryHypervVirtualMachine()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryHypervVirtualMachine",
                "($fid: UUID!)",
                "HyperVvirtualMachine",
                Query.HypervVirtualMachine_ObjectFieldSpec,
                Query.HypervVirtualMachineFieldSpec,
                @"# REQUIRED
$inputs.Var.fid = <System.String>"
            );
        }

        // Create new GraphQL Query:
        // uniqueHypervServersCount(filter: [Filter!]): Int!
        internal void InitQueryUniqueHypervServersCount()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("filter", "[Filter!]"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryUniqueHypervServersCount",
                "($filter: [Filter!])",
                "System.Int32",
                Query.UniqueHypervServersCount_ObjectFieldSpec,
                Query.UniqueHypervServersCountFieldSpec,
                @"# OPTIONAL
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
        // hypervScvmms(
        //     first: Int
        //     after: String
        //     sortBy: HierarchySortByField
        //     sortOrder: SortOrder
        //     filter: [Filter!]
        //   ): HyperVSCVMMConnection!
        internal void InitQueryHypervScvmms()
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
                "HyperVscvmmConnection",
                Query.HypervScvmms_ObjectFieldSpec,
                Query.HypervScvmmsFieldSpec,
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
        // hypervServers(input: QueryHypervHostInput!): HypervHostSummaryListResponse!
        internal void InitQueryHypervServers()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "QueryHypervHostInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryHypervServers",
                "($input: QueryHypervHostInput!)",
                "HypervHostSummaryListResponse",
                Query.HypervServers_ObjectFieldSpec,
                Query.HypervServersFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# OPTIONAL
	effectiveSlaDomainId = <System.String>
	# OPTIONAL
	limit = <System.Int32>
	# OPTIONAL
	name = <System.String>
	# OPTIONAL
	offset = <System.Int32>
	# OPTIONAL
	primaryClusterId = <System.String>
	# OPTIONAL
	slaAssignment = <InternalQueryHypervHostRequestSlaAssignment> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.InternalQueryHypervHostRequestSlaAssignment]) for enum values.
	# OPTIONAL
	sortBy = <InternalQueryHypervHostRequestSortBy> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.InternalQueryHypervHostRequestSortBy]) for enum values.
	# OPTIONAL
	sortOrder = <InternalQueryHypervHostRequestSortOrder> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.InternalQueryHypervHostRequestSortOrder]) for enum values.
	# REQUIRED
	clusterUuid = <System.String>
}"
            );
        }

        // Create new GraphQL Query:
        // hypervMounts(
        //     first: Int
        //     after: String
        //     filters: [HypervLiveMountFilterInput!]
        //     sortBy: HypervLiveMountSortByInput
        //   ): HyperVLiveMountConnection!
        internal void InitQueryHypervMounts()
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
                "HyperVliveMountConnection",
                Query.HypervMounts_ObjectFieldSpec,
                Query.HypervMountsFieldSpec,
                @"# OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# OPTIONAL
$inputs.Var.filters = @(
	@{
		# OPTIONAL
		field = <HypervLiveMountFilterField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HypervLiveMountFilterField]) for enum values.
		# OPTIONAL
		texts = @(
			<System.String>
		)
}
)
# OPTIONAL
$inputs.Var.sortBy = @{
	# OPTIONAL
	field = <HypervLiveMountSortByField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HypervLiveMountSortByField]) for enum values.
	# OPTIONAL
	sortOrder = <SortOrder> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
}"
            );
        }

        // Create new GraphQL Query:
        // hypervVmDetail(input: GetHypervVirtualMachineInput!): HypervVirtualMachineDetail!
        internal void InitQueryHypervVmDetail()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetHypervVirtualMachineInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryHypervVmDetail",
                "($input: GetHypervVirtualMachineInput!)",
                "HypervVirtualMachineDetail",
                Query.HypervVmDetail_ObjectFieldSpec,
                Query.HypervVmDetailFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
}"
            );
        }

        // Create new GraphQL Query:
        // hypervHostAsyncRequestStatus(input: GetHypervHostAsyncRequestStatusInput!): AsyncRequestStatus!
        internal void InitQueryHypervHostAsyncRequestStatus()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetHypervHostAsyncRequestStatusInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryHypervHostAsyncRequestStatus",
                "($input: GetHypervHostAsyncRequestStatusInput!)",
                "AsyncRequestStatus",
                Query.HypervHostAsyncRequestStatus_ObjectFieldSpec,
                Query.HypervHostAsyncRequestStatusFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	clusterUuid = <System.String>
	# REQUIRED
	id = <System.String>
}"
            );
        }

        // Create new GraphQL Query:
        // hypervScvmmAsyncRequestStatus(input: GetHypervScvmmAsyncRequestStatusInput!): AsyncRequestStatus!
        internal void InitQueryHypervScvmmAsyncRequestStatus()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetHypervScvmmAsyncRequestStatusInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryHypervScvmmAsyncRequestStatus",
                "($input: GetHypervScvmmAsyncRequestStatusInput!)",
                "AsyncRequestStatus",
                Query.HypervScvmmAsyncRequestStatus_ObjectFieldSpec,
                Query.HypervScvmmAsyncRequestStatusFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	clusterUuid = <System.String>
	# REQUIRED
	id = <System.String>
}"
            );
        }

        // Create new GraphQL Query:
        // hypervVirtualMachineAsyncRequestStatus(input: GetHypervVirtualMachineAsyncRequestStatusInput!): AsyncRequestStatus!
        internal void InitQueryHypervVirtualMachineAsyncRequestStatus()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetHypervVirtualMachineAsyncRequestStatusInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryHypervVirtualMachineAsyncRequestStatus",
                "($input: GetHypervVirtualMachineAsyncRequestStatusInput!)",
                "AsyncRequestStatus",
                Query.HypervVirtualMachineAsyncRequestStatus_ObjectFieldSpec,
                Query.HypervVirtualMachineAsyncRequestStatusFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	clusterUuid = <System.String>
	# REQUIRED
	id = <System.String>
}"
            );
        }


    } // class New_RscQueryHyperv
}