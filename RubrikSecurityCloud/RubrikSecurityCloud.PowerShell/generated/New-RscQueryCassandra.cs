// New-RscQueryCassandra.cs
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
    /// Queries for the 'Cassandra' API domain.
    /// </summary>
    /// <description>
    /// New-RscQueryCassandra is a master cmdlet for Cassandra work that can invoke any of the following subcommands: Sources, Keyspaces, ColumnFamilies, ColumnFamilyRecoverableRange, ColumnFamilySchema, Source, Keyspace, ColumnFamily.
    /// </description>
    /// <example>
    /// <code>New-RscQueryCassandra -Sources [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryCassandra -Keyspaces [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryCassandra -ColumnFamilies [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryCassandra -ColumnFamilyRecoverableRange [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryCassandra -ColumnFamilySchema [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryCassandra -Source [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryCassandra -Keyspace [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryCassandra -ColumnFamily [-Arg ..] [-Field ..]</code>
    /// </example>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscQueryCassandra",
        DefaultParameterSetName = "Source")
    ]
    public class New_RscQueryCassandra : RscGqlPSCmdlet
    {
        
        /// <summary>
        /// Sources parameter set
        ///
        /// [GraphQL: cassandraSources]
        /// </summary>
        [Parameter(
            ParameterSetName = "Sources",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Paginated list of cassandra sources.
[GraphQL: cassandraSources]",
            Position = 0
        )]
        public SwitchParameter Sources { get; set; }

        
        /// <summary>
        /// Keyspaces parameter set
        ///
        /// [GraphQL: cassandraKeyspaces]
        /// </summary>
        [Parameter(
            ParameterSetName = "Keyspaces",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Paginated list of cassandra keyspaces.
[GraphQL: cassandraKeyspaces]",
            Position = 0
        )]
        public SwitchParameter Keyspaces { get; set; }

        
        /// <summary>
        /// ColumnFamilies parameter set
        ///
        /// [GraphQL: cassandraColumnFamilies]
        /// </summary>
        [Parameter(
            ParameterSetName = "ColumnFamilies",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Paginated list of cassandra column families.
[GraphQL: cassandraColumnFamilies]",
            Position = 0
        )]
        public SwitchParameter ColumnFamilies { get; set; }

        
        /// <summary>
        /// ColumnFamilyRecoverableRange parameter set
        ///
        /// [GraphQL: cassandraColumnFamilyRecoverableRange]
        /// </summary>
        [Parameter(
            ParameterSetName = "ColumnFamilyRecoverableRange",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Get Recoverable Range of a Cassandra Column Family.
[GraphQL: cassandraColumnFamilyRecoverableRange]",
            Position = 0
        )]
        public SwitchParameter ColumnFamilyRecoverableRange { get; set; }

        
        /// <summary>
        /// ColumnFamilySchema parameter set
        ///
        /// [GraphQL: cassandraColumnFamilySchema]
        /// </summary>
        [Parameter(
            ParameterSetName = "ColumnFamilySchema",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Get Schema of a Cassandra Column Family.
[GraphQL: cassandraColumnFamilySchema]",
            Position = 0
        )]
        public SwitchParameter ColumnFamilySchema { get; set; }

        
        /// <summary>
        /// Source parameter set
        ///
        /// [GraphQL: cassandraSource]
        /// </summary>
        [Parameter(
            ParameterSetName = "Source",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Details of a cassandra source.
[GraphQL: cassandraSource]",
            Position = 0
        )]
        public SwitchParameter Source { get; set; }

        
        /// <summary>
        /// Keyspace parameter set
        ///
        /// [GraphQL: cassandraKeyspace]
        /// </summary>
        [Parameter(
            ParameterSetName = "Keyspace",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Details of a cassandra keyspace.
[GraphQL: cassandraKeyspace]",
            Position = 0
        )]
        public SwitchParameter Keyspace { get; set; }

        
        /// <summary>
        /// ColumnFamily parameter set
        ///
        /// [GraphQL: cassandraColumnFamily]
        /// </summary>
        [Parameter(
            ParameterSetName = "ColumnFamily",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Details of a cassandra column family.
[GraphQL: cassandraColumnFamily]",
            Position = 0
        )]
        public SwitchParameter ColumnFamily { get; set; }


// ignore warning 'Missing XML comment'
#pragma warning disable 1591
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                switch(Op)
                {
                    case "Sources":
                        this.ProcessRecord_Sources();
                        break;
                    case "Keyspaces":
                        this.ProcessRecord_Keyspaces();
                        break;
                    case "ColumnFamilies":
                        this.ProcessRecord_ColumnFamilies();
                        break;
                    case "ColumnFamilyRecoverableRange":
                        this.ProcessRecord_ColumnFamilyRecoverableRange();
                        break;
                    case "ColumnFamilySchema":
                        this.ProcessRecord_ColumnFamilySchema();
                        break;
                    case "Source":
                        this.ProcessRecord_Source();
                        break;
                    case "Keyspace":
                        this.ProcessRecord_Keyspace();
                        break;
                    case "ColumnFamily":
                        this.ProcessRecord_ColumnFamily();
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
        // cassandraSources.
        internal void ProcessRecord_Sources()
        {
            this._logger.name += " -Sources";
            // Create new graphql operation cassandraSources
            InitQueryCassandraSources();
        }

        // This parameter set invokes a single graphql operation:
        // cassandraKeyspaces.
        internal void ProcessRecord_Keyspaces()
        {
            this._logger.name += " -Keyspaces";
            // Create new graphql operation cassandraKeyspaces
            InitQueryCassandraKeyspaces();
        }

        // This parameter set invokes a single graphql operation:
        // cassandraColumnFamilies.
        internal void ProcessRecord_ColumnFamilies()
        {
            this._logger.name += " -ColumnFamilies";
            // Create new graphql operation cassandraColumnFamilies
            InitQueryCassandraColumnFamilies();
        }

        // This parameter set invokes a single graphql operation:
        // cassandraColumnFamilyRecoverableRange.
        internal void ProcessRecord_ColumnFamilyRecoverableRange()
        {
            this._logger.name += " -ColumnFamilyRecoverableRange";
            // Create new graphql operation cassandraColumnFamilyRecoverableRange
            InitQueryCassandraColumnFamilyRecoverableRange();
        }

        // This parameter set invokes a single graphql operation:
        // cassandraColumnFamilySchema.
        internal void ProcessRecord_ColumnFamilySchema()
        {
            this._logger.name += " -ColumnFamilySchema";
            // Create new graphql operation cassandraColumnFamilySchema
            InitQueryCassandraColumnFamilySchema();
        }

        // This parameter set invokes a single graphql operation:
        // cassandraSource.
        internal void ProcessRecord_Source()
        {
            this._logger.name += " -Source";
            // Create new graphql operation cassandraSource
            InitQueryCassandraSource();
        }

        // This parameter set invokes a single graphql operation:
        // cassandraKeyspace.
        internal void ProcessRecord_Keyspace()
        {
            this._logger.name += " -Keyspace";
            // Create new graphql operation cassandraKeyspace
            InitQueryCassandraKeyspace();
        }

        // This parameter set invokes a single graphql operation:
        // cassandraColumnFamily.
        internal void ProcessRecord_ColumnFamily()
        {
            this._logger.name += " -ColumnFamily";
            // Create new graphql operation cassandraColumnFamily
            InitQueryCassandraColumnFamily();
        }


        // Create new GraphQL Query:
        // cassandraSources(
        //     first: Int
        //     after: String
        //     sortBy: HierarchySortByField
        //     sortOrder: SortOrder
        //     filter: [Filter!]
        //   ): CassandraSourceConnection!
        internal void InitQueryCassandraSources()
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
                "QueryCassandraSources",
                "($first: Int,$after: String,$sortBy: HierarchySortByField,$sortOrder: SortOrder,$filter: [Filter!])",
                "CassandraSourceConnection",
                Query.CassandraSources_ObjectFieldSpec,
                Query.CassandraSourcesFieldSpec,
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
        // cassandraKeyspaces(
        //     first: Int
        //     after: String
        //     sortBy: HierarchySortByField
        //     sortOrder: SortOrder
        //     filter: [Filter!]
        //   ): CassandraKeyspaceConnection!
        internal void InitQueryCassandraKeyspaces()
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
                "QueryCassandraKeyspaces",
                "($first: Int,$after: String,$sortBy: HierarchySortByField,$sortOrder: SortOrder,$filter: [Filter!])",
                "CassandraKeyspaceConnection",
                Query.CassandraKeyspaces_ObjectFieldSpec,
                Query.CassandraKeyspacesFieldSpec,
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
        // cassandraColumnFamilies(
        //     first: Int
        //     after: String
        //     sortBy: HierarchySortByField
        //     sortOrder: SortOrder
        //     filter: [Filter!]
        //   ): CassandraColumnFamilyConnection!
        internal void InitQueryCassandraColumnFamilies()
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
                "QueryCassandraColumnFamilies",
                "($first: Int,$after: String,$sortBy: HierarchySortByField,$sortOrder: SortOrder,$filter: [Filter!])",
                "CassandraColumnFamilyConnection",
                Query.CassandraColumnFamilies_ObjectFieldSpec,
                Query.CassandraColumnFamiliesFieldSpec,
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
        // cassandraColumnFamilyRecoverableRange(input: GetMosaicRecoverableRangeInput!): GetMosaicRecoverableRangeResponse!
        internal void InitQueryCassandraColumnFamilyRecoverableRange()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetMosaicRecoverableRangeInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryCassandraColumnFamilyRecoverableRange",
                "($input: GetMosaicRecoverableRangeInput!)",
                "GetMosaicRecoverableRangeResponse",
                Query.CassandraColumnFamilyRecoverableRange_ObjectFieldSpec,
                Query.CassandraColumnFamilyRecoverableRangeFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	clusterUuid = <System.String>
	# REQUIRED
	recoveryRangeRequestData = @{
		# OPTIONAL
		sourceType = <MosaicRecoverableRangeRequestSourceType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.MosaicRecoverableRangeRequestSourceType]) for enum values.
		# REQUIRED
		databaseName = <System.String>
		# REQUIRED
		sourceName = <System.String>
		# REQUIRED
		tableName = <System.String>
	}
}"
            );
        }

        // Create new GraphQL Query:
        // cassandraColumnFamilySchema(input: GetMosaicTableSchemaInput!): GetSchemaResponse!
        internal void InitQueryCassandraColumnFamilySchema()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetMosaicTableSchemaInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryCassandraColumnFamilySchema",
                "($input: GetMosaicTableSchemaInput!)",
                "GetSchemaResponse",
                Query.CassandraColumnFamilySchema_ObjectFieldSpec,
                Query.CassandraColumnFamilySchemaFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	clusterUuid = <System.String>
	# REQUIRED
	schemaRequestData = @{
		# REQUIRED
		databaseName = <System.String>
		# REQUIRED
		sourceName = <System.String>
		# REQUIRED
		tableName = <System.String>
		# REQUIRED
		versionTimestamp = <System.String>
	}
}"
            );
        }

        // Create new GraphQL Query:
        // cassandraSource(fid: UUID!): CassandraSource!
        internal void InitQueryCassandraSource()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryCassandraSource",
                "($fid: UUID!)",
                "CassandraSource",
                Query.CassandraSource_ObjectFieldSpec,
                Query.CassandraSourceFieldSpec,
                @"# REQUIRED
$inputs.Var.fid = <System.String>"
            );
        }

        // Create new GraphQL Query:
        // cassandraKeyspace(fid: UUID!): CassandraKeyspace!
        internal void InitQueryCassandraKeyspace()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryCassandraKeyspace",
                "($fid: UUID!)",
                "CassandraKeyspace",
                Query.CassandraKeyspace_ObjectFieldSpec,
                Query.CassandraKeyspaceFieldSpec,
                @"# REQUIRED
$inputs.Var.fid = <System.String>"
            );
        }

        // Create new GraphQL Query:
        // cassandraColumnFamily(fid: UUID!): CassandraColumnFamily!
        internal void InitQueryCassandraColumnFamily()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryCassandraColumnFamily",
                "($fid: UUID!)",
                "CassandraColumnFamily",
                Query.CassandraColumnFamily_ObjectFieldSpec,
                Query.CassandraColumnFamilyFieldSpec,
                @"# REQUIRED
$inputs.Var.fid = <System.String>"
            );
        }


    } // class New_RscQueryCassandra
}