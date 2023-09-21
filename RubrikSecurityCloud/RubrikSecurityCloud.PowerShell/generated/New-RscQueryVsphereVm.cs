// New-RscQueryVsphereVm.cs
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
    /// Queries for the 'vSphere VM' API domain.
    /// </summary>
    /// <description>
    /// New-RscQueryVsphereVm is the cmdlet to work with operations in the {self.noun} API domain. It is a dynamic cmdlet that accepts any {self.noun} API operation as its first parameter:  {sc_names}.
    /// </description>
    /// <example>
    /// <code>New-RscQueryVsphereVm -New [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryVsphereVm -NewList [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryVsphereVm -AsyncRequestStatus [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryVsphereVm -RecoverableRange [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryVsphereVm -RecoverableRangeInBatch [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryVsphereVm -MissedRecoverableRange [-Arg ..] [-Field ..]</code>
    /// </example>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscQueryVsphereVm",
        DefaultParameterSetName = "New")
    ]
    public class New_RscQueryVsphereVm : RscGqlPSCmdlet
    {
        
        /// <summary>
        /// New parameter set
        ///
        /// [GraphQL: vSphereVmNew]
        /// </summary>
        [Parameter(
            ParameterSetName = "New",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"
[GraphQL: vSphereVmNew]",
            Position = 0
        )]
        public SwitchParameter New { get; set; }

        
        /// <summary>
        /// NewList parameter set
        ///
        /// [GraphQL: vSphereVmNewConnection]
        /// </summary>
        [Parameter(
            ParameterSetName = "NewList",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"
[GraphQL: vSphereVmNewConnection]",
            Position = 0
        )]
        public SwitchParameter NewList { get; set; }

        
        /// <summary>
        /// AsyncRequestStatus parameter set
        ///
        /// [GraphQL: vSphereVMAsyncRequestStatus]
        /// </summary>
        [Parameter(
            ParameterSetName = "AsyncRequestStatus",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"
[GraphQL: vSphereVMAsyncRequestStatus]",
            Position = 0
        )]
        public SwitchParameter AsyncRequestStatus { get; set; }

        
        /// <summary>
        /// RecoverableRange parameter set
        ///
        /// [GraphQL: vsphereVMRecoverableRange]
        /// </summary>
        [Parameter(
            ParameterSetName = "RecoverableRange",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"
[GraphQL: vsphereVMRecoverableRange]",
            Position = 0
        )]
        public SwitchParameter RecoverableRange { get; set; }

        
        /// <summary>
        /// RecoverableRangeInBatch parameter set
        ///
        /// [GraphQL: vsphereVMRecoverableRangeInBatch]
        /// </summary>
        [Parameter(
            ParameterSetName = "RecoverableRangeInBatch",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"
[GraphQL: vsphereVMRecoverableRangeInBatch]",
            Position = 0
        )]
        public SwitchParameter RecoverableRangeInBatch { get; set; }

        
        /// <summary>
        /// MissedRecoverableRange parameter set
        ///
        /// [GraphQL: vsphereVMMissedRecoverableRange]
        /// </summary>
        [Parameter(
            ParameterSetName = "MissedRecoverableRange",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"
[GraphQL: vsphereVMMissedRecoverableRange]",
            Position = 0
        )]
        public SwitchParameter MissedRecoverableRange { get; set; }


// ignore warning 'Missing XML comment'
#pragma warning disable 1591
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                switch(Op)
                {
                    case "New":
                        this.ProcessRecord_New();
                        break;
                    case "NewList":
                        this.ProcessRecord_NewList();
                        break;
                    case "AsyncRequestStatus":
                        this.ProcessRecord_AsyncRequestStatus();
                        break;
                    case "RecoverableRange":
                        this.ProcessRecord_RecoverableRange();
                        break;
                    case "RecoverableRangeInBatch":
                        this.ProcessRecord_RecoverableRangeInBatch();
                        break;
                    case "MissedRecoverableRange":
                        this.ProcessRecord_MissedRecoverableRange();
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
        // vSphereVmNew.
        internal void ProcessRecord_New()
        {
            this._logger.name += " -New";
            // Create new graphql operation vSphereVmNew
            InitQueryVsphereVmNew();
        }

        // This parameter set invokes a single graphql operation:
        // vSphereVmNewConnection.
        internal void ProcessRecord_NewList()
        {
            this._logger.name += " -NewList";
            // Create new graphql operation vSphereVmNewConnection
            InitQueryVsphereVmNewConnection();
        }

        // This parameter set invokes a single graphql operation:
        // vSphereVMAsyncRequestStatus.
        internal void ProcessRecord_AsyncRequestStatus()
        {
            this._logger.name += " -AsyncRequestStatus";
            // Create new graphql operation vSphereVMAsyncRequestStatus
            InitQueryVsphereVmAsyncRequestStatus();
        }

        // This parameter set invokes a single graphql operation:
        // vsphereVMRecoverableRange.
        internal void ProcessRecord_RecoverableRange()
        {
            this._logger.name += " -RecoverableRange";
            // Create new graphql operation vsphereVMRecoverableRange
            InitQueryVsphereVmRecoverableRange();
        }

        // This parameter set invokes a single graphql operation:
        // vsphereVMRecoverableRangeInBatch.
        internal void ProcessRecord_RecoverableRangeInBatch()
        {
            this._logger.name += " -RecoverableRangeInBatch";
            // Create new graphql operation vsphereVMRecoverableRangeInBatch
            InitQueryVsphereVmRecoverableRangeInBatch();
        }

        // This parameter set invokes a single graphql operation:
        // vsphereVMMissedRecoverableRange.
        internal void ProcessRecord_MissedRecoverableRange()
        {
            this._logger.name += " -MissedRecoverableRange";
            // Create new graphql operation vsphereVMMissedRecoverableRange
            InitQueryVsphereVmMissedRecoverableRange();
        }


        // Create new GraphQL Query:
        // vSphereVmNew(fid: UUID!): VsphereVm!
        internal void InitQueryVsphereVmNew()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryVsphereVmNew",
                "($fid: UUID!)",
                "VsphereVm",
                Query.VsphereVmNew_ObjectFieldSpec,
                Query.VsphereVmNewFieldSpec,
                @"# REQUIRED
$inputs.Var.fid = <System.String>"
            );
        }

        // Create new GraphQL Query:
        // vSphereVmNewConnection(
        //     first: Int
        //     after: String
        //     sortBy: HierarchySortByField
        //     sortOrder: SortOrder
        //     filter: [Filter!]
        //   ): VsphereVmConnection!
        internal void InitQueryVsphereVmNewConnection()
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
                "QueryVsphereVmNewConnection",
                "($first: Int,$after: String,$sortBy: HierarchySortByField,$sortOrder: SortOrder,$filter: [Filter!])",
                "VsphereVmConnection",
                Query.VsphereVmNewConnection_ObjectFieldSpec,
                Query.VsphereVmNewConnectionFieldSpec,
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
        // vSphereVMAsyncRequestStatus(clusterUuid: UUID!, id: String!): AsyncRequestStatus!
        internal void InitQueryVsphereVmAsyncRequestStatus()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("clusterUuid", "UUID!"),
                Tuple.Create("id", "String!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryVsphereVmAsyncRequestStatus",
                "($clusterUuid: UUID!,$id: String!)",
                "AsyncRequestStatus",
                Query.VsphereVmAsyncRequestStatus_ObjectFieldSpec,
                Query.VsphereVmAsyncRequestStatusFieldSpec,
                @"# REQUIRED
$inputs.Var.clusterUuid = <System.String>
# REQUIRED
$inputs.Var.id = <System.String>"
            );
        }

        // Create new GraphQL Query:
        // vsphereVMRecoverableRange(snappableFid: UUID!, beforeTime: DateTime, afterTime: DateTime): RecoverableRangeResponse!
        internal void InitQueryVsphereVmRecoverableRange()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("snappableFid", "UUID!"),
                Tuple.Create("beforeTime", "DateTime"),
                Tuple.Create("afterTime", "DateTime"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryVsphereVmRecoverableRange",
                "($snappableFid: UUID!,$beforeTime: DateTime,$afterTime: DateTime)",
                "RecoverableRangeResponse",
                Query.VsphereVmRecoverableRange_ObjectFieldSpec,
                Query.VsphereVmRecoverableRangeFieldSpec,
                @"# REQUIRED
$inputs.Var.snappableFid = <System.String>
# OPTIONAL
$inputs.Var.beforeTime = <DateTime>
# OPTIONAL
$inputs.Var.afterTime = <DateTime>"
            );
        }

        // Create new GraphQL Query:
        // vsphereVMRecoverableRangeInBatch(requestInfo: BatchVmwareVmRecoverableRangesRequestInput!): BatchVmwareVmRecoverableRanges!
        internal void InitQueryVsphereVmRecoverableRangeInBatch()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("requestInfo", "BatchVmwareVmRecoverableRangesRequestInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryVsphereVmRecoverableRangeInBatch",
                "($requestInfo: BatchVmwareVmRecoverableRangesRequestInput!)",
                "BatchVmwareVmRecoverableRanges",
                Query.VsphereVmRecoverableRangeInBatch_ObjectFieldSpec,
                Query.VsphereVmRecoverableRangeInBatchFieldSpec,
                @"# REQUIRED
$inputs.Var.requestInfo = @{
	# OPTIONAL
	afterTime = <DateTime>
	# OPTIONAL
	beforeTime = <DateTime>
	# REQUIRED
	vmIds = @(
		<System.String>
	)
}"
            );
        }

        // Create new GraphQL Query:
        // vsphereVMMissedRecoverableRange(snappableFid: UUID!, beforeTime: DateTime, afterTime: DateTime): RecoverableRangeResponse!
        internal void InitQueryVsphereVmMissedRecoverableRange()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("snappableFid", "UUID!"),
                Tuple.Create("beforeTime", "DateTime"),
                Tuple.Create("afterTime", "DateTime"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryVsphereVmMissedRecoverableRange",
                "($snappableFid: UUID!,$beforeTime: DateTime,$afterTime: DateTime)",
                "RecoverableRangeResponse",
                Query.VsphereVmMissedRecoverableRange_ObjectFieldSpec,
                Query.VsphereVmMissedRecoverableRangeFieldSpec,
                @"# REQUIRED
$inputs.Var.snappableFid = <System.String>
# OPTIONAL
$inputs.Var.beforeTime = <DateTime>
# OPTIONAL
$inputs.Var.afterTime = <DateTime>"
            );
        }


    } // class New_RscQueryVsphereVm
}