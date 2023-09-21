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
using System.Threading.Tasks;
using GraphQL;
using RubrikSecurityCloud;
using RubrikSecurityCloud.Types;
using RubrikSecurityCloud.NetSDK.Client;
using RubrikSecurityCloud.PowerShell.Private;

namespace RubrikSecurityCloud.PowerShell.Cmdlets
{
    /// <summary>
    /// Queries for the 'Db2' API domain.
    /// </summary>
    /// <description>
    /// New-RscQueryDb2 is the cmdlet to work with operations in the {self.noun} API domain. It is a dynamic cmdlet that accepts any {self.noun} API operation as its first parameter:  {sc_names}.
    /// </description>
    /// <example>
    /// <code>New-RscQueryDb2 -Instances [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryDb2 -Instance [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryDb2 -Database [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryDb2 -Databases [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryDb2 -RecoverableRange [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryDb2 -RecoverableRanges [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryDb2 -LogSnapshot [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryDb2 -LogSnapshots [-Arg ..] [-Field ..]</code>
    /// </example>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscQueryDb2",
        DefaultParameterSetName = "Instances")
    ]
    public class New_RscQueryDb2 : RscGqlPSCmdlet
    {
        
        /// <summary>
        /// Instances parameter set
        ///
        /// [GraphQL: db2Instances]
        /// </summary>
        [Parameter(
            ParameterSetName = "Instances",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Connection of filtered db2 instances based on specific filters.
[GraphQL: db2Instances]",
            Position = 0
        )]
        public SwitchParameter Instances { get; set; }

        
        /// <summary>
        /// Instance parameter set
        ///
        /// [GraphQL: db2Instance]
        /// </summary>
        [Parameter(
            ParameterSetName = "Instance",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Details of a db2 instance for a given fid.
[GraphQL: db2Instance]",
            Position = 0
        )]
        public SwitchParameter Instance { get; set; }

        
        /// <summary>
        /// Database parameter set
        ///
        /// [GraphQL: db2Database]
        /// </summary>
        [Parameter(
            ParameterSetName = "Database",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Details of a db2 database for a given fid.
[GraphQL: db2Database]",
            Position = 0
        )]
        public SwitchParameter Database { get; set; }

        
        /// <summary>
        /// Databases parameter set
        ///
        /// [GraphQL: db2Databases]
        /// </summary>
        [Parameter(
            ParameterSetName = "Databases",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Connection of filtered db2 databases based on specific filters.
[GraphQL: db2Databases]",
            Position = 0
        )]
        public SwitchParameter Databases { get; set; }

        
        /// <summary>
        /// RecoverableRange parameter set
        ///
        /// [GraphQL: db2RecoverableRange]
        /// </summary>
        [Parameter(
            ParameterSetName = "RecoverableRange",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Details of a Db2 recoverable range for a given fid.
[GraphQL: db2RecoverableRange]",
            Position = 0
        )]
        public SwitchParameter RecoverableRange { get; set; }

        
        /// <summary>
        /// RecoverableRanges parameter set
        ///
        /// [GraphQL: db2RecoverableRanges]
        /// </summary>
        [Parameter(
            ParameterSetName = "RecoverableRanges",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Connection of all recoverable ranges for Db2.
[GraphQL: db2RecoverableRanges]",
            Position = 0
        )]
        public SwitchParameter RecoverableRanges { get; set; }

        
        /// <summary>
        /// LogSnapshot parameter set
        ///
        /// [GraphQL: db2LogSnapshot]
        /// </summary>
        [Parameter(
            ParameterSetName = "LogSnapshot",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Details of a Db2 log snapshot for a given fid.
[GraphQL: db2LogSnapshot]",
            Position = 0
        )]
        public SwitchParameter LogSnapshot { get; set; }

        
        /// <summary>
        /// LogSnapshots parameter set
        ///
        /// [GraphQL: db2LogSnapshots]
        /// </summary>
        [Parameter(
            ParameterSetName = "LogSnapshots",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Connection of all log snapshots for Db2.
[GraphQL: db2LogSnapshots]",
            Position = 0
        )]
        public SwitchParameter LogSnapshots { get; set; }


// ignore warning 'Missing XML comment'
#pragma warning disable 1591
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                switch(Op)
                {
                    case "Instances":
                        this.ProcessRecord_Instances();
                        break;
                    case "Instance":
                        this.ProcessRecord_Instance();
                        break;
                    case "Database":
                        this.ProcessRecord_Database();
                        break;
                    case "Databases":
                        this.ProcessRecord_Databases();
                        break;
                    case "RecoverableRange":
                        this.ProcessRecord_RecoverableRange();
                        break;
                    case "RecoverableRanges":
                        this.ProcessRecord_RecoverableRanges();
                        break;
                    case "LogSnapshot":
                        this.ProcessRecord_LogSnapshot();
                        break;
                    case "LogSnapshots":
                        this.ProcessRecord_LogSnapshots();
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
        // db2Instances.
        internal void ProcessRecord_Instances()
        {
            this._logger.name += " -Instances";
            // Create new graphql operation db2Instances
            InitQueryDb2Instances();
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
        // db2Database.
        internal void ProcessRecord_Database()
        {
            this._logger.name += " -Database";
            // Create new graphql operation db2Database
            InitQueryDb2Database();
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
                Query.Db2Instances_ObjectFieldSpec,
                Query.Db2InstancesFieldSpec,
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
                Query.Db2Instance_ObjectFieldSpec,
                Query.Db2InstanceFieldSpec,
                @"# REQUIRED
$inputs.Var.id = <System.String>"
            );
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
                Query.Db2Database_ObjectFieldSpec,
                Query.Db2DatabaseFieldSpec,
                @"# REQUIRED
$inputs.Var.fid = <System.String>"
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
                Query.Db2Databases_ObjectFieldSpec,
                Query.Db2DatabasesFieldSpec,
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
                Query.Db2RecoverableRange_ObjectFieldSpec,
                Query.Db2RecoverableRangeFieldSpec,
                @"# REQUIRED
$inputs.Var.db2RecoverableRangeFid = <System.String>"
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
                Query.Db2RecoverableRanges_ObjectFieldSpec,
                Query.Db2RecoverableRangesFieldSpec,
                @"# OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# OPTIONAL
$inputs.Var.last = <System.Int32>
# OPTIONAL
$inputs.Var.before = <System.String>
# OPTIONAL
$inputs.Var.sortOrder = <SortOrder> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$inputs.Var.sortBy = <Db2RecoverableRangeSortBy> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.Db2RecoverableRangeSortBy]) for enum values.
# OPTIONAL
$inputs.Var.filter = @{
	# OPTIONAL
	clusterUuid = @(
		<System.String>
	)
	# OPTIONAL
	databaseId = @(
		<System.String>
	)
	# OPTIONAL
	fromTime = <DateTime>
	# OPTIONAL
	toTime = <DateTime>
	# OPTIONAL
	isArchived = <System.Boolean>
}"
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
                Query.Db2LogSnapshot_ObjectFieldSpec,
                Query.Db2LogSnapshotFieldSpec,
                @"# REQUIRED
$inputs.Var.db2LogSnapshotFid = <System.String>"
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
                Query.Db2LogSnapshots_ObjectFieldSpec,
                Query.Db2LogSnapshotsFieldSpec,
                @"# OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# OPTIONAL
$inputs.Var.last = <System.Int32>
# OPTIONAL
$inputs.Var.before = <System.String>
# OPTIONAL
$inputs.Var.sortOrder = <SortOrder> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$inputs.Var.sortBy = <Db2LogSnapshotSortBy> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.Db2LogSnapshotSortBy]) for enum values.
# OPTIONAL
$inputs.Var.filter = @{
	# OPTIONAL
	workloadId = @(
		<System.String>
	)
	# OPTIONAL
	clusterUuid = @(
		<System.String>
	)
	# OPTIONAL
	fromTime = <DateTime>
	# OPTIONAL
	toTime = <DateTime>
	# OPTIONAL
	isArchived = <System.Boolean>
}"
            );
        }


    } // class New_RscQueryDb2
}