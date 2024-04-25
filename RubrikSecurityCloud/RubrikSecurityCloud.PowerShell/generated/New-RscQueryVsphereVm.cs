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
using System.Linq;
using System.Threading.Tasks;
using GraphQL;
using RubrikSecurityCloud;
using RubrikSecurityCloud.Types;
using RubrikSecurityCloud.NetSDK.Client;
using RubrikSecurityCloud.PowerShell.Private;

// ignore warning 'Missing XML comment'
#pragma warning disable 1591

namespace RubrikSecurityCloud.PowerShell.Cmdlets
{
    /// <summary>
    /// Create a new RscQuery object for any of the 6
    /// operations in the 'VMware vSphere VM' API domain:
    /// AsyncRequestStatus, MissedRecoverableRange, New, NewList, RecoverableRange, or RecoverableRangeInBatch.
    /// </summary>
    /// <description>
    /// New-RscQueryVsphereVm creates a new
    /// query object for operations
    /// in the 'VMware vSphere VM' API domain. It only creates a data structure,
    /// it does not execute the operation. This cmdlet does not need a
    /// connection to run. To execute the operation, either call Invoke()
    /// on the object returned by this cmdlet, or pass the object to
    /// Invoke-Rsc.
    /// There are 6 operations
    /// in the 'VMware vSphere VM' API domain. Select the operation this
    /// query is for by specifying the appropriate value for the
    /// -Operation parameter;
    /// one of: AsyncRequestStatus, MissedRecoverableRange, New, NewList, RecoverableRange, or RecoverableRangeInBatch.
    /// Each operation has its own set of variables that can be set with
    /// the -Var parameter. For more info about the variables, 
    /// call Info() on the object returned by this cmdlet, for example:
    /// (New-RscQueryVsphereVm -AsyncRequestStatus).Info().
    /// Each operation also has its own set of fields that can be
    /// selected for retrieval. If you do not specify any fields,
    /// a set of default fields will be selected. The selection is
    /// rule-based, and tries to select the most commonly used fields.
    /// For example if a field is named 'id' or 'name', 
    /// it will be selected. If you give -FieldProfile DETAIL, then
    /// another set of rules will be used to select more fields on top
    /// of the default fields. The set of rules for selecting fields
    /// is called a field profile. You can specify a field profile
    /// with the -FieldProfile parameter. You can add or remove fields
    /// from the field profile with the -AddField and -RemoveField
    /// parameters. If you end up with too many -AddField and -RemoveField
    /// parameters, you can list them in a text file, one per line,
    /// with a '+' or '-' prefix, and pass the file name to the
    /// -FilePatch parameter. Profiles and Patches are one way to
    /// customize the fields that are selected. Another way is to
    /// specify the fields by passing the -Field parameter an object
    /// that contains the fields you want to select as properties.
    /// Any property that is not null in that object is interpreted
    /// as a field to select
    /// (and the actual values they are set to do not matter).
    /// The [RubrikSecurityCloud.Types] namespace
    /// contains a set of classes that you can use to specify fields.
    /// To know what [RubrikSecurityCloud.Types] object to use
    /// for a specific operation,
    /// call Info() on the object returned by this cmdlet, for example:
    /// (New-RscQueryVsphereVm -AsyncRequestStatus).Info().
    /// You can combine a -Field parameter with patching parameters.
    /// -Field is applied first, then -FilePatch, -AddField and -RemoveField.
    ///
    /// </description>
    ///
    /// <example>
    /// Runs the AsyncRequestStatus operation
    /// of the 'VMware vSphere VM' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    VsphereVm
    /// # API Operation: AsyncRequestStatus
    /// 
    /// $query = New-RscQueryVsphereVm -AsyncRequestStatus
    /// 
    /// # REQUIRED
    /// $query.Var.clusterUuid = $someString
    /// # REQUIRED
    /// $query.Var.id = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AsyncRequestStatus
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the MissedRecoverableRange operation
    /// of the 'VMware vSphere VM' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    VsphereVm
    /// # API Operation: MissedRecoverableRange
    /// 
    /// $query = New-RscQueryVsphereVm -MissedRecoverableRange
    /// 
    /// # REQUIRED
    /// $query.Var.snappableFid = $someString
    /// # OPTIONAL
    /// $query.Var.beforeTime = $someDateTime
    /// # OPTIONAL
    /// $query.Var.afterTime = $someDateTime
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: RecoverableRangeResponse
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the New operation
    /// of the 'VMware vSphere VM' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    VsphereVm
    /// # API Operation: New
    /// 
    /// $query = New-RscQueryVsphereVm -New
    /// 
    /// # REQUIRED
    /// $query.Var.fid = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: VsphereVm
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the NewList operation
    /// of the 'VMware vSphere VM' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    VsphereVm
    /// # API Operation: NewList
    /// 
    /// $query = New-RscQueryVsphereVm -NewList
    /// 
    /// # OPTIONAL
    /// $query.Var.first = $someInt
    /// # OPTIONAL
    /// $query.Var.after = $someString
    /// # OPTIONAL
    /// $query.Var.sortBy = $someHierarchySortByField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchySortByField]) for enum values.
    /// # OPTIONAL
    /// $query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
    /// # OPTIONAL
    /// $query.Var.filter = @(
    /// 	@{
    /// 		# OPTIONAL
    /// 		field = $someHierarchyFilterField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchyFilterField]) for enum values.
    /// 		# OPTIONAL
    /// 		texts = @(
    /// 			$someString
    /// 		)
    /// 		# OPTIONAL
    /// 		tagFilterParams = @(
    /// 			@{
    /// 				# OPTIONAL
    /// 				filterType = $someTagFilterType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TagFilterType]) for enum values.
    /// 				# OPTIONAL
    /// 				tagKey = $someString
    /// 				# OPTIONAL
    /// 				tagValue = $someString
    /// 			}
    /// 		)
    /// 		# OPTIONAL
    /// 		objectTypeFilterParams = @(
    /// 			$someManagedObjectType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ManagedObjectType]) for enum values.
    /// 		)
    /// 		# OPTIONAL
    /// 		awsNativeProtectionFeatureNames = @(
    /// 			$someAwsNativeProtectionFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeProtectionFeature]) for enum values.
    /// 		)
    /// 		# OPTIONAL
    /// 		isNegative = $someBoolean
    /// 		# OPTIONAL
    /// 		isSlowSearchEnabled = $someBoolean
    /// 		# OPTIONAL
    /// 		azureNativeProtectionFeatureNames = @(
    /// 			$someAzureNativeProtectionFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeProtectionFeature]) for enum values.
    /// 		)
    /// 		# OPTIONAL
    /// 		unmanagedObjectAvailabilityFilter = @(
    /// 			$someUnmanagedObjectAvailabilityFilter # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UnmanagedObjectAvailabilityFilter]) for enum values.
    /// 		)
    /// }
    /// )
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: VsphereVmConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the RecoverableRange operation
    /// of the 'VMware vSphere VM' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    VsphereVm
    /// # API Operation: RecoverableRange
    /// 
    /// $query = New-RscQueryVsphereVm -RecoverableRange
    /// 
    /// # REQUIRED
    /// $query.Var.snappableFid = $someString
    /// # OPTIONAL
    /// $query.Var.beforeTime = $someDateTime
    /// # OPTIONAL
    /// $query.Var.afterTime = $someDateTime
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: RecoverableRangeResponse
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the RecoverableRangeInBatch operation
    /// of the 'VMware vSphere VM' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    VsphereVm
    /// # API Operation: RecoverableRangeInBatch
    /// 
    /// $query = New-RscQueryVsphereVm -RecoverableRangeInBatch
    /// 
    /// # REQUIRED
    /// $query.Var.requestInfo = @{
    /// 	# OPTIONAL
    /// 	afterTime = $someDateTime
    /// 	# OPTIONAL
    /// 	beforeTime = $someDateTime
    /// 	# REQUIRED
    /// 	vmIds = @(
    /// 		$someString
    /// 	)
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: BatchVmwareVmRecoverableRanges
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscQueryVsphereVm",
        DefaultParameterSetName = "Operation")
    ]
    public class New_RscQueryVsphereVm : RscGqlPSCmdlet
    {
        [Parameter(
            Mandatory = true, 
            ParameterSetName = "Operation",
            HelpMessage = "API Operation. The set of operations depends on the API domain. See reference at: https://github.com/rubrikinc/rubrik-powershell-sdk/blob/main/docs/domains_and_operations.md",
            Position = 0,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = true)]
            [ValidateSet(
                "AsyncRequestStatus",
                "MissedRecoverableRange",
                "New",
                "NewList",
                "RecoverableRange",
                "RecoverableRangeInBatch",
                IgnoreCase = true)]
        public string Operation { get; set; } = "";

        internal override string GetOperationParameter()
        {
            return this.Operation;
        }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                switch(this.GetOp().OpName())
                {
                    case "AsyncRequestStatus":
                        this.ProcessRecord_AsyncRequestStatus();
                        break;
                    case "MissedRecoverableRange":
                        this.ProcessRecord_MissedRecoverableRange();
                        break;
                    case "New":
                        this.ProcessRecord_New();
                        break;
                    case "NewList":
                        this.ProcessRecord_NewList();
                        break;
                    case "RecoverableRange":
                        this.ProcessRecord_RecoverableRange();
                        break;
                    case "RecoverableRangeInBatch":
                        this.ProcessRecord_RecoverableRangeInBatch();
                        break;
                    default:
                        throw new Exception("Unknown Operation " + this.GetOp().OpName());
                }
           }
           catch (Exception ex)
           {
                ThrowTerminatingException(ex);
           }
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
        // vsphereVMMissedRecoverableRange.
        internal void ProcessRecord_MissedRecoverableRange()
        {
            this._logger.name += " -MissedRecoverableRange";
            // Create new graphql operation vsphereVMMissedRecoverableRange
            InitQueryVsphereVmMissedRecoverableRange();
        }

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
                Query.VsphereVmAsyncRequestStatus,
                Query.VsphereVmAsyncRequestStatusFieldSpec,
                @"# REQUIRED
$query.Var.clusterUuid = $someString
# REQUIRED
$query.Var.id = $someString"
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
                Query.VsphereVmMissedRecoverableRange,
                Query.VsphereVmMissedRecoverableRangeFieldSpec,
                @"# REQUIRED
$query.Var.snappableFid = $someString
# OPTIONAL
$query.Var.beforeTime = $someDateTime
# OPTIONAL
$query.Var.afterTime = $someDateTime"
            );
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
                Query.VsphereVmNew,
                Query.VsphereVmNewFieldSpec,
                @"# REQUIRED
$query.Var.fid = $someString"
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
                Query.VsphereVmNewConnection,
                Query.VsphereVmNewConnectionFieldSpec,
                @"# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# OPTIONAL
$query.Var.sortBy = $someHierarchySortByField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchySortByField]) for enum values.
# OPTIONAL
$query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$query.Var.filter = @(
	@{
		# OPTIONAL
		field = $someHierarchyFilterField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchyFilterField]) for enum values.
		# OPTIONAL
		texts = @(
			$someString
		)
		# OPTIONAL
		tagFilterParams = @(
			@{
				# OPTIONAL
				filterType = $someTagFilterType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TagFilterType]) for enum values.
				# OPTIONAL
				tagKey = $someString
				# OPTIONAL
				tagValue = $someString
			}
		)
		# OPTIONAL
		objectTypeFilterParams = @(
			$someManagedObjectType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ManagedObjectType]) for enum values.
		)
		# OPTIONAL
		awsNativeProtectionFeatureNames = @(
			$someAwsNativeProtectionFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		isNegative = $someBoolean
		# OPTIONAL
		isSlowSearchEnabled = $someBoolean
		# OPTIONAL
		azureNativeProtectionFeatureNames = @(
			$someAzureNativeProtectionFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		unmanagedObjectAvailabilityFilter = @(
			$someUnmanagedObjectAvailabilityFilter # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UnmanagedObjectAvailabilityFilter]) for enum values.
		)
}
)"
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
                Query.VsphereVmRecoverableRange,
                Query.VsphereVmRecoverableRangeFieldSpec,
                @"# REQUIRED
$query.Var.snappableFid = $someString
# OPTIONAL
$query.Var.beforeTime = $someDateTime
# OPTIONAL
$query.Var.afterTime = $someDateTime"
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
                Query.VsphereVmRecoverableRangeInBatch,
                Query.VsphereVmRecoverableRangeInBatchFieldSpec,
                @"# REQUIRED
$query.Var.requestInfo = @{
	# OPTIONAL
	afterTime = $someDateTime
	# OPTIONAL
	beforeTime = $someDateTime
	# REQUIRED
	vmIds = @(
		$someString
	)
}"
            );
        }


    } // class New_RscQueryVsphereVm
}