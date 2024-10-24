// New-RscQueryDb2.cs
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
    /// Create a new RscQuery object for any of the 9
    /// operations in the 'Db2' API domain:
    /// Database, DatabaseJobStatus, Databases, Instance, Instances, LogSnapshot, LogSnapshots, RecoverableRange, or RecoverableRanges.
    /// </summary>
    /// <description>
    /// New-RscQueryDb2 creates a new
    /// query object for operations
    /// in the 'Db2' API domain. It only creates a data structure,
    /// it does not execute the operation. This cmdlet does not need a
    /// connection to run. To execute the operation, either call Invoke()
    /// on the object returned by this cmdlet, or pass the object to
    /// Invoke-Rsc.
    /// There are 9 operations
    /// in the 'Db2' API domain. Select the operation this
    /// query is for by specifying the appropriate value for the
    /// -Operation parameter;
    /// one of: Database, DatabaseJobStatus, Databases, Instance, Instances, LogSnapshot, LogSnapshots, RecoverableRange, or RecoverableRanges.
    /// Each operation has its own set of variables that can be set with
    /// the -Var parameter. For more info about the variables, 
    /// call Info() on the object returned by this cmdlet, for example:
    /// (New-RscQueryDb2 -Database).Info().
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
    /// (New-RscQueryDb2 -Database).Info().
    /// You can combine a -Field parameter with patching parameters.
    /// -Field is applied first, then -FilePatch, -AddField and -RemoveField.
    ///
    /// </description>
    ///
    /// <example>
    /// Runs the Database operation
    /// of the 'Db2' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Db2
    /// # API Operation: Database
    /// 
    /// $query = New-RscQueryDb2 -Operation Database
    /// 
    /// # REQUIRED
    /// $query.Var.fid = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: Db2Database
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the DatabaseJobStatus operation
    /// of the 'Db2' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Db2
    /// # API Operation: DatabaseJobStatus
    /// 
    /// $query = New-RscQueryDb2 -Operation DatabaseJobStatus
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	clusterUuid = $someString
    /// 	# REQUIRED
    /// 	id = $someString
    /// }
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
    /// Runs the Databases operation
    /// of the 'Db2' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Db2
    /// # API Operation: Databases
    /// 
    /// $query = New-RscQueryDb2 -Operation Databases
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
    /// Write-Host $result.GetType().Name # prints: Db2DatabaseConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the Instance operation
    /// of the 'Db2' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Db2
    /// # API Operation: Instance
    /// 
    /// $query = New-RscQueryDb2 -Operation Instance
    /// 
    /// # REQUIRED
    /// $query.Var.id = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: Db2Instance
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the Instances operation
    /// of the 'Db2' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Db2
    /// # API Operation: Instances
    /// 
    /// $query = New-RscQueryDb2 -Operation Instances
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
    /// Write-Host $result.GetType().Name # prints: Db2InstanceConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the LogSnapshot operation
    /// of the 'Db2' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Db2
    /// # API Operation: LogSnapshot
    /// 
    /// $query = New-RscQueryDb2 -Operation LogSnapshot
    /// 
    /// # REQUIRED
    /// $query.Var.db2LogSnapshotFid = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: Db2LogSnapshot
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the LogSnapshots operation
    /// of the 'Db2' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Db2
    /// # API Operation: LogSnapshots
    /// 
    /// $query = New-RscQueryDb2 -Operation LogSnapshots
    /// 
    /// # OPTIONAL
    /// $query.Var.first = $someInt
    /// # OPTIONAL
    /// $query.Var.after = $someString
    /// # OPTIONAL
    /// $query.Var.last = $someInt
    /// # OPTIONAL
    /// $query.Var.before = $someString
    /// # OPTIONAL
    /// $query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
    /// # OPTIONAL
    /// $query.Var.sortBy = $someDb2LogSnapshotSortBy # Call [Enum]::GetValues([RubrikSecurityCloud.Types.Db2LogSnapshotSortBy]) for enum values.
    /// # OPTIONAL
    /// $query.Var.filter = @{
    /// 	# OPTIONAL
    /// 	workloadId = @(
    /// 		$someString
    /// 	)
    /// 	# OPTIONAL
    /// 	clusterUuid = @(
    /// 		$someString
    /// 	)
    /// 	# OPTIONAL
    /// 	fromTime = $someDateTime
    /// 	# OPTIONAL
    /// 	toTime = $someDateTime
    /// 	# OPTIONAL
    /// 	isArchived = $someBoolean
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: Db2LogSnapshotConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the RecoverableRange operation
    /// of the 'Db2' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Db2
    /// # API Operation: RecoverableRange
    /// 
    /// $query = New-RscQueryDb2 -Operation RecoverableRange
    /// 
    /// # REQUIRED
    /// $query.Var.db2RecoverableRangeFid = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: Db2RecoverableRange
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the RecoverableRanges operation
    /// of the 'Db2' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Db2
    /// # API Operation: RecoverableRanges
    /// 
    /// $query = New-RscQueryDb2 -Operation RecoverableRanges
    /// 
    /// # OPTIONAL
    /// $query.Var.first = $someInt
    /// # OPTIONAL
    /// $query.Var.after = $someString
    /// # OPTIONAL
    /// $query.Var.last = $someInt
    /// # OPTIONAL
    /// $query.Var.before = $someString
    /// # OPTIONAL
    /// $query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
    /// # OPTIONAL
    /// $query.Var.sortBy = $someDb2RecoverableRangeSortBy # Call [Enum]::GetValues([RubrikSecurityCloud.Types.Db2RecoverableRangeSortBy]) for enum values.
    /// # OPTIONAL
    /// $query.Var.filter = @{
    /// 	# OPTIONAL
    /// 	clusterUuid = @(
    /// 		$someString
    /// 	)
    /// 	# OPTIONAL
    /// 	databaseId = @(
    /// 		$someString
    /// 	)
    /// 	# OPTIONAL
    /// 	fromTime = $someDateTime
    /// 	# OPTIONAL
    /// 	toTime = $someDateTime
    /// 	# OPTIONAL
    /// 	isArchived = $someBoolean
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: Db2RecoverableRangeConnection
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
        "RscQueryDb2",
        DefaultParameterSetName = "Operation")
    ]
    public class New_RscQueryDb2 : RscGqlPSCmdlet
    {
        [Parameter(
            Mandatory = true, 
            ParameterSetName = "Operation",
            HelpMessage = "API Operation. The set of operations depends on the API domain. See reference at: https://github.com/rubrikinc/rubrik-powershell-sdk/blob/main/docs/domains_and_operations.md",
            Position = 0,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = true)]
            [ValidateSet(
                "Database",
                "DatabaseJobStatus",
                "Databases",
                "Instance",
                "Instances",
                "LogSnapshot",
                "LogSnapshots",
                "RecoverableRange",
                "RecoverableRanges",
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
                    case "Database":
                        this.ProcessRecord_Database();
                        break;
                    case "DatabaseJobStatus":
                        this.ProcessRecord_DatabaseJobStatus();
                        break;
                    case "Databases":
                        this.ProcessRecord_Databases();
                        break;
                    case "Instance":
                        this.ProcessRecord_Instance();
                        break;
                    case "Instances":
                        this.ProcessRecord_Instances();
                        break;
                    case "LogSnapshot":
                        this.ProcessRecord_LogSnapshot();
                        break;
                    case "LogSnapshots":
                        this.ProcessRecord_LogSnapshots();
                        break;
                    case "RecoverableRange":
                        this.ProcessRecord_RecoverableRange();
                        break;
                    case "RecoverableRanges":
                        this.ProcessRecord_RecoverableRanges();
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
        // db2Database.
        internal void ProcessRecord_Database()
        {
            this._logger.name += " -Database";
            // Create new graphql operation db2Database
            InitQueryDb2Database();
        }

        // This parameter set invokes a single graphql operation:
        // db2DatabaseJobStatus.
        internal void ProcessRecord_DatabaseJobStatus()
        {
            this._logger.name += " -DatabaseJobStatus";
            // Create new graphql operation db2DatabaseJobStatus
            InitQueryDb2DatabaseJobStatus();
        }

        // This parameter set invokes a single graphql operation:
        // db2Databases.
        internal void ProcessRecord_Databases()
        {
            this._logger.name += " -Databases";
            // Create new graphql operation db2Databases
            InitQueryDb2Databases();
        }

        // This parameter set invokes a single graphql operation:
        // db2Instance.
        internal void ProcessRecord_Instance()
        {
            this._logger.name += " -Instance";
            // Create new graphql operation db2Instance
            InitQueryDb2Instance();
        }

        // This parameter set invokes a single graphql operation:
        // db2Instances.
        internal void ProcessRecord_Instances()
        {
            this._logger.name += " -Instances";
            // Create new graphql operation db2Instances
            InitQueryDb2Instances();
        }

        // This parameter set invokes a single graphql operation:
        // db2LogSnapshot.
        internal void ProcessRecord_LogSnapshot()
        {
            this._logger.name += " -LogSnapshot";
            // Create new graphql operation db2LogSnapshot
            InitQueryDb2LogSnapshot();
        }

        // This parameter set invokes a single graphql operation:
        // db2LogSnapshots.
        internal void ProcessRecord_LogSnapshots()
        {
            this._logger.name += " -LogSnapshots";
            // Create new graphql operation db2LogSnapshots
            InitQueryDb2LogSnapshots();
        }

        // This parameter set invokes a single graphql operation:
        // db2RecoverableRange.
        internal void ProcessRecord_RecoverableRange()
        {
            this._logger.name += " -RecoverableRange";
            // Create new graphql operation db2RecoverableRange
            InitQueryDb2RecoverableRange();
        }

        // This parameter set invokes a single graphql operation:
        // db2RecoverableRanges.
        internal void ProcessRecord_RecoverableRanges()
        {
            this._logger.name += " -RecoverableRanges";
            // Create new graphql operation db2RecoverableRanges
            InitQueryDb2RecoverableRanges();
        }


        // Create new GraphQL Query:
        // db2Database(fid: UUID!): Db2Database!
        internal void InitQueryDb2Database()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryDb2Database",
                "($fid: UUID!)",
                "Db2Database",
                Query.Db2Database,
                Query.Db2DatabaseFieldSpec,
                @"# REQUIRED
$query.Var.fid = $someString"
            );
        }

        // Create new GraphQL Query:
        // db2DatabaseJobStatus(input: GetDb2DatabaseAsyncRequestStatusInput!): AsyncRequestStatus!
        internal void InitQueryDb2DatabaseJobStatus()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetDb2DatabaseAsyncRequestStatusInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryDb2DatabaseJobStatus",
                "($input: GetDb2DatabaseAsyncRequestStatusInput!)",
                "AsyncRequestStatus",
                Query.Db2DatabaseJobStatus,
                Query.Db2DatabaseJobStatusFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	clusterUuid = $someString
	# REQUIRED
	id = $someString
}"
            );
        }

        // Create new GraphQL Query:
        // db2Databases(
        //     first: Int
        //     after: String
        //     sortBy: HierarchySortByField
        //     sortOrder: SortOrder
        //     filter: [Filter!]
        //   ): Db2DatabaseConnection!
        internal void InitQueryDb2Databases()
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
                "QueryDb2Databases",
                "($first: Int,$after: String,$sortBy: HierarchySortByField,$sortOrder: SortOrder,$filter: [Filter!])",
                "Db2DatabaseConnection",
                Query.Db2Databases,
                Query.Db2DatabasesFieldSpec,
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
        // db2Instance(id: UUID!): Db2Instance!
        internal void InitQueryDb2Instance()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("id", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryDb2Instance",
                "($id: UUID!)",
                "Db2Instance",
                Query.Db2Instance,
                Query.Db2InstanceFieldSpec,
                @"# REQUIRED
$query.Var.id = $someString"
            );
        }

        // Create new GraphQL Query:
        // db2Instances(
        //     first: Int
        //     after: String
        //     sortBy: HierarchySortByField
        //     sortOrder: SortOrder
        //     filter: [Filter!]
        //   ): Db2InstanceConnection!
        internal void InitQueryDb2Instances()
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
                "QueryDb2Instances",
                "($first: Int,$after: String,$sortBy: HierarchySortByField,$sortOrder: SortOrder,$filter: [Filter!])",
                "Db2InstanceConnection",
                Query.Db2Instances,
                Query.Db2InstancesFieldSpec,
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
        // db2LogSnapshot(db2LogSnapshotFid: UUID!): Db2LogSnapshot!
        internal void InitQueryDb2LogSnapshot()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("db2LogSnapshotFid", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryDb2LogSnapshot",
                "($db2LogSnapshotFid: UUID!)",
                "Db2LogSnapshot",
                Query.Db2LogSnapshot,
                Query.Db2LogSnapshotFieldSpec,
                @"# REQUIRED
$query.Var.db2LogSnapshotFid = $someString"
            );
        }

        // Create new GraphQL Query:
        // db2LogSnapshots(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     sortOrder: SortOrder
        //     sortBy: Db2LogSnapshotSortBy
        //     filter: Db2LogSnapshotFilterInput
        //   ): Db2LogSnapshotConnection!
        internal void InitQueryDb2LogSnapshots()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("sortBy", "Db2LogSnapshotSortBy"),
                Tuple.Create("filter", "Db2LogSnapshotFilterInput"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryDb2LogSnapshots",
                "($first: Int,$after: String,$last: Int,$before: String,$sortOrder: SortOrder,$sortBy: Db2LogSnapshotSortBy,$filter: Db2LogSnapshotFilterInput)",
                "Db2LogSnapshotConnection",
                Query.Db2LogSnapshots,
                Query.Db2LogSnapshotsFieldSpec,
                @"# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# OPTIONAL
$query.Var.last = $someInt
# OPTIONAL
$query.Var.before = $someString
# OPTIONAL
$query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$query.Var.sortBy = $someDb2LogSnapshotSortBy # Call [Enum]::GetValues([RubrikSecurityCloud.Types.Db2LogSnapshotSortBy]) for enum values.
# OPTIONAL
$query.Var.filter = @{
	# OPTIONAL
	workloadId = @(
		$someString
	)
	# OPTIONAL
	clusterUuid = @(
		$someString
	)
	# OPTIONAL
	fromTime = $someDateTime
	# OPTIONAL
	toTime = $someDateTime
	# OPTIONAL
	isArchived = $someBoolean
}"
            );
        }

        // Create new GraphQL Query:
        // db2RecoverableRange(db2RecoverableRangeFid: UUID!): Db2RecoverableRange!
        internal void InitQueryDb2RecoverableRange()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("db2RecoverableRangeFid", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryDb2RecoverableRange",
                "($db2RecoverableRangeFid: UUID!)",
                "Db2RecoverableRange",
                Query.Db2RecoverableRange,
                Query.Db2RecoverableRangeFieldSpec,
                @"# REQUIRED
$query.Var.db2RecoverableRangeFid = $someString"
            );
        }

        // Create new GraphQL Query:
        // db2RecoverableRanges(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     sortOrder: SortOrder
        //     sortBy: Db2RecoverableRangeSortBy
        //     filter: Db2RecoverableRangeFilterInput
        //   ): Db2RecoverableRangeConnection!
        internal void InitQueryDb2RecoverableRanges()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("sortBy", "Db2RecoverableRangeSortBy"),
                Tuple.Create("filter", "Db2RecoverableRangeFilterInput"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryDb2RecoverableRanges",
                "($first: Int,$after: String,$last: Int,$before: String,$sortOrder: SortOrder,$sortBy: Db2RecoverableRangeSortBy,$filter: Db2RecoverableRangeFilterInput)",
                "Db2RecoverableRangeConnection",
                Query.Db2RecoverableRanges,
                Query.Db2RecoverableRangesFieldSpec,
                @"# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# OPTIONAL
$query.Var.last = $someInt
# OPTIONAL
$query.Var.before = $someString
# OPTIONAL
$query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$query.Var.sortBy = $someDb2RecoverableRangeSortBy # Call [Enum]::GetValues([RubrikSecurityCloud.Types.Db2RecoverableRangeSortBy]) for enum values.
# OPTIONAL
$query.Var.filter = @{
	# OPTIONAL
	clusterUuid = @(
		$someString
	)
	# OPTIONAL
	databaseId = @(
		$someString
	)
	# OPTIONAL
	fromTime = $someDateTime
	# OPTIONAL
	toTime = $someDateTime
	# OPTIONAL
	isArchived = $someBoolean
}"
            );
        }


    } // class New_RscQueryDb2
}