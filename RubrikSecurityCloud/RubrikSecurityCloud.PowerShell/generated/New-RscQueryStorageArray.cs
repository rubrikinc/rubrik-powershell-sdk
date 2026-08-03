// New-RscQueryStorageArray.cs
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
    /// Create a new RscQuery object for any of the 3
    /// operations in the 'Storage Arrays' API domain:
    /// PureStorageArrayV1, PureStorageArraysV1, or StorageArray.
    /// </summary>
    /// <description>
    /// New-RscQueryStorageArray creates a new
    /// query object for operations
    /// in the 'Storage Arrays' API domain. It only creates a data structure,
    /// it does not execute the operation. This cmdlet does not need a
    /// connection to run. To execute the operation, either call Invoke()
    /// on the object returned by this cmdlet, or pass the object to
    /// Invoke-Rsc.
    /// There are 3 operations
    /// in the 'Storage Arrays' API domain. Select the operation this
    /// query is for by specifying the appropriate value for the
    /// -Operation parameter;
    /// one of: PureStorageArrayV1, PureStorageArraysV1, or StorageArray.
    /// Each operation has its own set of variables that can be set with
    /// the -Var parameter. For more info about the variables, 
    /// call Info() on the object returned by this cmdlet, for example:
    /// (New-RscQueryStorageArray -PureStorageArrayV1).Info().
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
    /// (New-RscQueryStorageArray -PureStorageArrayV1).Info().
    /// You can combine a -Field parameter with patching parameters.
    /// -Field is applied first, then -FilePatch, -AddField and -RemoveField.
    ///
    /// </description>
    ///
    /// <example>
    /// Runs the PureStorageArrayV1 operation
    /// of the 'Storage Arrays' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    StorageArray
    /// # API Operation: PureStorageArrayV1
    /// 
    /// $query = New-RscQueryStorageArray -Operation PureStorageArrayV1
    /// 
    /// # REQUIRED
    /// $query.Var.id = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: PureStorageArrayV1
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the PureStorageArraysV1 operation
    /// of the 'Storage Arrays' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    StorageArray
    /// # API Operation: PureStorageArraysV1
    /// 
    /// $query = New-RscQueryStorageArray -Operation PureStorageArraysV1
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
    /// 		# OPTIONAL
    /// 		gcpNativeProtectionFeatureNames = @(
    /// 			$someGcpNativeProtectionFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.GcpNativeProtectionFeature]) for enum values.
    /// 		)
    /// 		# OPTIONAL
    /// 		timeParam = $someDateTime
    /// 		# OPTIONAL
    /// 		nativeTagFilterParams = @(
    /// 			@{
    /// 				# OPTIONAL
    /// 				source = $someNativeTagSource # Call [Enum]::GetValues([RubrikSecurityCloud.Types.NativeTagSource]) for enum values.
    /// 				# OPTIONAL
    /// 				nativeTagIds = @(
    /// 					$someString
    /// 				)
    /// 			}
    /// 		)
    /// }
    /// )
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: PureStorageArrayV1Connection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the StorageArray operation
    /// of the 'Storage Arrays' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    StorageArray
    /// # API Operation: StorageArray
    /// 
    /// $query = New-RscQueryStorageArray -Operation StorageArray
    /// 
    /// # REQUIRED
    /// $query.Var.input = @(
    /// 	$someString
    /// )
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AllStorageArraysReply
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
        "RscQueryStorageArray",
        DefaultParameterSetName = "Operation")
    ]
    public class New_RscQueryStorageArray : RscGqlPSCmdlet
    {
        [Parameter(
            Mandatory = true, 
            ParameterSetName = "Operation",
            HelpMessage = "API Operation. The set of operations depends on the API domain. See reference at: https://github.com/rubrikinc/rubrik-powershell-sdk/blob/main/docs/domains_and_operations.md",
            Position = 0,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = true)]
            [ValidateSet(
                "PureStorageArrayV1",
                "PureStorageArraysV1",
                "StorageArray",
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
                    case "PureStorageArrayV1":
                        this.ProcessRecord_PureStorageArrayV1();
                        break;
                    case "PureStorageArraysV1":
                        this.ProcessRecord_PureStorageArraysV1();
                        break;
                    case "StorageArray":
                        this.ProcessRecord_StorageArray();
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
        // pureStorageArrayV1.
        internal void ProcessRecord_PureStorageArrayV1()
        {
            this._logger.name += " -PureStorageArrayV1";
            // Create new graphql operation pureStorageArrayV1
            InitQueryPureStorageArrayV1();
        }

        // This parameter set invokes a single graphql operation:
        // pureStorageArraysV1.
        internal void ProcessRecord_PureStorageArraysV1()
        {
            this._logger.name += " -PureStorageArraysV1";
            // Create new graphql operation pureStorageArraysV1
            InitQueryPureStorageArraysV1();
        }

        // This parameter set invokes a single graphql operation:
        // allStorageArrays.
        internal void ProcessRecord_StorageArray()
        {
            this._logger.name += " -StorageArray";
            // Create new graphql operation allStorageArrays
            InitQueryAllStorageArrays();
        }


        // Create new GraphQL Query:
        // pureStorageArrayV1(id: UUID!): PureStorageArrayV1!
        internal void InitQueryPureStorageArrayV1()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("id", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryPureStorageArrayV1",
                "($id: UUID!)",
                "PureStorageArrayV1",
                Query.PureStorageArrayV1,
                Query.PureStorageArrayV1FieldSpec,
                @"# REQUIRED
$query.Var.id = $someString"
            );
        }

        // Create new GraphQL Query:
        // pureStorageArraysV1(
        //     first: Int
        //     after: String
        //     sortBy: HierarchySortByField
        //     sortOrder: SortOrder
        //     filter: [Filter!]
        //   ): PureStorageArrayV1Connection!
        internal void InitQueryPureStorageArraysV1()
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
                "QueryPureStorageArraysV1",
                "($first: Int,$after: String,$sortBy: HierarchySortByField,$sortOrder: SortOrder,$filter: [Filter!])",
                "PureStorageArrayV1Connection",
                Query.PureStorageArraysV1,
                Query.PureStorageArraysV1FieldSpec,
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
		# OPTIONAL
		gcpNativeProtectionFeatureNames = @(
			$someGcpNativeProtectionFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.GcpNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		timeParam = $someDateTime
		# OPTIONAL
		nativeTagFilterParams = @(
			@{
				# OPTIONAL
				source = $someNativeTagSource # Call [Enum]::GetValues([RubrikSecurityCloud.Types.NativeTagSource]) for enum values.
				# OPTIONAL
				nativeTagIds = @(
					$someString
				)
			}
		)
}
)"
            );
        }

        // Create new GraphQL Query:
        // allStorageArrays(input: [UUID!]!): AllStorageArraysReply!
        internal void InitQueryAllStorageArrays()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "[UUID!]!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllStorageArrays",
                "($input: [UUID!]!)",
                "AllStorageArraysReply",
                Query.AllStorageArrays,
                Query.AllStorageArraysFieldSpec,
                @"# REQUIRED
$query.Var.input = @(
	$someString
)"
            );
        }


    } // class New_RscQueryStorageArray
}