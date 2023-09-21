// New-RscQueryMongo.cs
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
    /// Queries for the 'Mongo' API domain.
    /// </summary>
    /// <description>
    /// New-RscQueryMongo is the cmdlet to work with operations in the {self.noun} API domain. It is a dynamic cmdlet that accepts any {self.noun} API operation as its first parameter:  {sc_names}.
    /// </description>
    /// <example>
    /// <code>New-RscQueryMongo -Sources [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryMongo -Databases [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryMongo -Collections [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryMongo -Source [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryMongo -Database [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryMongo -Collection [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryMongo -RecoverableRanges [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryMongo -BulkRecoverableRanges [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryMongo -DbSources [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryMongo -DbDatabases [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryMongo -DbCollections [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryMongo -DbSource [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryMongo -DbDatabase [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryMongo -DbCollection [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryMongo -DbCollectionRecoverableRange [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryMongo -DbBulkRecoverableRange [-Arg ..] [-Field ..]</code>
    /// </example>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscQueryMongo",
        DefaultParameterSetName = "Source")
    ]
    public class New_RscQueryMongo : RscGqlPSCmdlet
    {
        
        /// <summary>
        /// Sources parameter set
        ///
        /// [GraphQL: mongoSources]
        /// </summary>
        [Parameter(
            ParameterSetName = "Sources",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Paginated list of MongoDB sources.
[GraphQL: mongoSources]",
            Position = 0
        )]
        public SwitchParameter Sources { get; set; }

        
        /// <summary>
        /// Databases parameter set
        ///
        /// [GraphQL: mongoDatabases]
        /// </summary>
        [Parameter(
            ParameterSetName = "Databases",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Paginated list of MongoDB databases.
[GraphQL: mongoDatabases]",
            Position = 0
        )]
        public SwitchParameter Databases { get; set; }

        
        /// <summary>
        /// Collections parameter set
        ///
        /// [GraphQL: mongoCollections]
        /// </summary>
        [Parameter(
            ParameterSetName = "Collections",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Paginated list of MongoDB collections.
[GraphQL: mongoCollections]",
            Position = 0
        )]
        public SwitchParameter Collections { get; set; }

        
        /// <summary>
        /// Source parameter set
        ///
        /// [GraphQL: mongoSource]
        /// </summary>
        [Parameter(
            ParameterSetName = "Source",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Provides details for the MongoDB source cluster identified by the fid.
[GraphQL: mongoSource]",
            Position = 0
        )]
        public SwitchParameter Source { get; set; }

        
        /// <summary>
        /// Database parameter set
        ///
        /// [GraphQL: mongoDatabase]
        /// </summary>
        [Parameter(
            ParameterSetName = "Database",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Provides details for a MongoDB database identified by the fid.
[GraphQL: mongoDatabase]",
            Position = 0
        )]
        public SwitchParameter Database { get; set; }

        
        /// <summary>
        /// Collection parameter set
        ///
        /// [GraphQL: mongoCollection]
        /// </summary>
        [Parameter(
            ParameterSetName = "Collection",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Provides details for a MongoDB collection identified by the fid.
[GraphQL: mongoCollection]",
            Position = 0
        )]
        public SwitchParameter Collection { get; set; }

        
        /// <summary>
        /// RecoverableRanges parameter set
        ///
        /// [GraphQL: mongoRecoverableRanges]
        /// </summary>
        [Parameter(
            ParameterSetName = "RecoverableRanges",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Provides the point in time range for MongoDB object recovery.
[GraphQL: mongoRecoverableRanges]",
            Position = 0
        )]
        public SwitchParameter RecoverableRanges { get; set; }

        
        /// <summary>
        /// BulkRecoverableRanges parameter set
        ///
        /// [GraphQL: mongoBulkRecoverableRanges]
        /// </summary>
        [Parameter(
            ParameterSetName = "BulkRecoverableRanges",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Provides the bulk recoverable range for MongoDB object recovery, including data and log snapshots.
[GraphQL: mongoBulkRecoverableRanges]",
            Position = 0
        )]
        public SwitchParameter BulkRecoverableRanges { get; set; }

        
        /// <summary>
        /// DbSources parameter set
        ///
        /// [GraphQL: mongodbSources]
        /// </summary>
        [Parameter(
            ParameterSetName = "DbSources",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Paginated list of MongoDB sources on NoSQL cluster.
[GraphQL: mongodbSources]",
            Position = 0
        )]
        public SwitchParameter DbSources { get; set; }

        
        /// <summary>
        /// DbDatabases parameter set
        ///
        /// [GraphQL: mongodbDatabases]
        /// </summary>
        [Parameter(
            ParameterSetName = "DbDatabases",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Paginated list of MongoDB databases on NoSQL cluster.
[GraphQL: mongodbDatabases]",
            Position = 0
        )]
        public SwitchParameter DbDatabases { get; set; }

        
        /// <summary>
        /// DbCollections parameter set
        ///
        /// [GraphQL: mongodbCollections]
        /// </summary>
        [Parameter(
            ParameterSetName = "DbCollections",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Paginated list of MongoDB collections on NoSQL cluster.
[GraphQL: mongodbCollections]",
            Position = 0
        )]
        public SwitchParameter DbCollections { get; set; }

        
        /// <summary>
        /// DbSource parameter set
        ///
        /// [GraphQL: mongodbSource]
        /// </summary>
        [Parameter(
            ParameterSetName = "DbSource",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"MongoDB source cluster identified by FID on NoSQL cluster. 
For MongoDB, the term ""source"" is usually used for either a replica set or a sharded cluster. 
For more info on MongoDB cluster refer to : https://docs.mongodb.com/manual/introduction/
[GraphQL: mongodbSource]",
            Position = 0
        )]
        public SwitchParameter DbSource { get; set; }

        
        /// <summary>
        /// DbDatabase parameter set
        ///
        /// [GraphQL: mongodbDatabase]
        /// </summary>
        [Parameter(
            ParameterSetName = "DbDatabase",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"MongoDB database identified by FID on NoSQL cluster. 
MongoDB stores data records as documents which are gathered together in collections. 
A database stores one or more collections of documents. 
For more info refer to : https://docs.mongodb.com/manual/core/databases-and-collections/
[GraphQL: mongodbDatabase]",
            Position = 0
        )]
        public SwitchParameter DbDatabase { get; set; }

        
        /// <summary>
        /// DbCollection parameter set
        ///
        /// [GraphQL: mongodbCollection]
        /// </summary>
        [Parameter(
            ParameterSetName = "DbCollection",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"MongoDB collection identified by FID on NoSQL cluster. 
MongoDB stores data records as documents which are gathered together in collections. 
For more info refer to : https://docs.mongodb.com/manual/core/databases-and-collections
[GraphQL: mongodbCollection]",
            Position = 0
        )]
        public SwitchParameter DbCollection { get; set; }

        
        /// <summary>
        /// DbCollectionRecoverableRange parameter set
        ///
        /// [GraphQL: mongodbCollectionRecoverableRange]
        /// </summary>
        [Parameter(
            ParameterSetName = "DbCollectionRecoverableRange",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Recoverable Range of a MongoDB collection on NoSQL cluster.
[GraphQL: mongodbCollectionRecoverableRange]",
            Position = 0
        )]
        public SwitchParameter DbCollectionRecoverableRange { get; set; }

        
        /// <summary>
        /// DbBulkRecoverableRange parameter set
        ///
        /// [GraphQL: mongodbBulkRecoverableRange]
        /// </summary>
        [Parameter(
            ParameterSetName = "DbBulkRecoverableRange",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Recoverable range for multiple Management Objects on NoSQL cluster.
[GraphQL: mongodbBulkRecoverableRange]",
            Position = 0
        )]
        public SwitchParameter DbBulkRecoverableRange { get; set; }


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
                    case "Databases":
                        this.ProcessRecord_Databases();
                        break;
                    case "Collections":
                        this.ProcessRecord_Collections();
                        break;
                    case "Source":
                        this.ProcessRecord_Source();
                        break;
                    case "Database":
                        this.ProcessRecord_Database();
                        break;
                    case "Collection":
                        this.ProcessRecord_Collection();
                        break;
                    case "RecoverableRanges":
                        this.ProcessRecord_RecoverableRanges();
                        break;
                    case "BulkRecoverableRanges":
                        this.ProcessRecord_BulkRecoverableRanges();
                        break;
                    case "DbSources":
                        this.ProcessRecord_DbSources();
                        break;
                    case "DbDatabases":
                        this.ProcessRecord_DbDatabases();
                        break;
                    case "DbCollections":
                        this.ProcessRecord_DbCollections();
                        break;
                    case "DbSource":
                        this.ProcessRecord_DbSource();
                        break;
                    case "DbDatabase":
                        this.ProcessRecord_DbDatabase();
                        break;
                    case "DbCollection":
                        this.ProcessRecord_DbCollection();
                        break;
                    case "DbCollectionRecoverableRange":
                        this.ProcessRecord_DbCollectionRecoverableRange();
                        break;
                    case "DbBulkRecoverableRange":
                        this.ProcessRecord_DbBulkRecoverableRange();
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
        // mongoSources.
        internal void ProcessRecord_Sources()
        {
            this._logger.name += " -Sources";
            // Create new graphql operation mongoSources
            InitQueryMongoSources();
        }

        // This parameter set invokes a single graphql operation:
        // mongoDatabases.
        internal void ProcessRecord_Databases()
        {
            this._logger.name += " -Databases";
            // Create new graphql operation mongoDatabases
            InitQueryMongoDatabases();
        }

        // This parameter set invokes a single graphql operation:
        // mongoCollections.
        internal void ProcessRecord_Collections()
        {
            this._logger.name += " -Collections";
            // Create new graphql operation mongoCollections
            InitQueryMongoCollections();
        }

        // This parameter set invokes a single graphql operation:
        // mongoSource.
        internal void ProcessRecord_Source()
        {
            this._logger.name += " -Source";
            // Create new graphql operation mongoSource
            InitQueryMongoSource();
        }

        // This parameter set invokes a single graphql operation:
        // mongoDatabase.
        internal void ProcessRecord_Database()
        {
            this._logger.name += " -Database";
            // Create new graphql operation mongoDatabase
            InitQueryMongoDatabase();
        }

        // This parameter set invokes a single graphql operation:
        // mongoCollection.
        internal void ProcessRecord_Collection()
        {
            this._logger.name += " -Collection";
            // Create new graphql operation mongoCollection
            InitQueryMongoCollection();
        }

        // This parameter set invokes a single graphql operation:
        // mongoRecoverableRanges.
        internal void ProcessRecord_RecoverableRanges()
        {
            this._logger.name += " -RecoverableRanges";
            // Create new graphql operation mongoRecoverableRanges
            InitQueryMongoRecoverableRanges();
        }

        // This parameter set invokes a single graphql operation:
        // mongoBulkRecoverableRanges.
        internal void ProcessRecord_BulkRecoverableRanges()
        {
            this._logger.name += " -BulkRecoverableRanges";
            // Create new graphql operation mongoBulkRecoverableRanges
            InitQueryMongoBulkRecoverableRanges();
        }

        // This parameter set invokes a single graphql operation:
        // mongodbSources.
        internal void ProcessRecord_DbSources()
        {
            this._logger.name += " -DbSources";
            // Create new graphql operation mongodbSources
            InitQueryMongodbSources();
        }

        // This parameter set invokes a single graphql operation:
        // mongodbDatabases.
        internal void ProcessRecord_DbDatabases()
        {
            this._logger.name += " -DbDatabases";
            // Create new graphql operation mongodbDatabases
            InitQueryMongodbDatabases();
        }

        // This parameter set invokes a single graphql operation:
        // mongodbCollections.
        internal void ProcessRecord_DbCollections()
        {
            this._logger.name += " -DbCollections";
            // Create new graphql operation mongodbCollections
            InitQueryMongodbCollections();
        }

        // This parameter set invokes a single graphql operation:
        // mongodbSource.
        internal void ProcessRecord_DbSource()
        {
            this._logger.name += " -DbSource";
            // Create new graphql operation mongodbSource
            InitQueryMongodbSource();
        }

        // This parameter set invokes a single graphql operation:
        // mongodbDatabase.
        internal void ProcessRecord_DbDatabase()
        {
            this._logger.name += " -DbDatabase";
            // Create new graphql operation mongodbDatabase
            InitQueryMongodbDatabase();
        }

        // This parameter set invokes a single graphql operation:
        // mongodbCollection.
        internal void ProcessRecord_DbCollection()
        {
            this._logger.name += " -DbCollection";
            // Create new graphql operation mongodbCollection
            InitQueryMongodbCollection();
        }

        // This parameter set invokes a single graphql operation:
        // mongodbCollectionRecoverableRange.
        internal void ProcessRecord_DbCollectionRecoverableRange()
        {
            this._logger.name += " -DbCollectionRecoverableRange";
            // Create new graphql operation mongodbCollectionRecoverableRange
            InitQueryMongodbCollectionRecoverableRange();
        }

        // This parameter set invokes a single graphql operation:
        // mongodbBulkRecoverableRange.
        internal void ProcessRecord_DbBulkRecoverableRange()
        {
            this._logger.name += " -DbBulkRecoverableRange";
            // Create new graphql operation mongodbBulkRecoverableRange
            InitQueryMongodbBulkRecoverableRange();
        }


        // Create new GraphQL Query:
        // mongoSources(
        //     first: Int
        //     after: String
        //     sortBy: HierarchySortByField
        //     sortOrder: SortOrder
        //     filter: [Filter!]
        //   ): MongoSourceConnection!
        internal void InitQueryMongoSources()
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
                "QueryMongoSources",
                "($first: Int,$after: String,$sortBy: HierarchySortByField,$sortOrder: SortOrder,$filter: [Filter!])",
                "MongoSourceConnection",
                Query.MongoSources_ObjectFieldSpec,
                Query.MongoSourcesFieldSpec,
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
        // mongoDatabases(
        //     first: Int
        //     after: String
        //     sortBy: HierarchySortByField
        //     sortOrder: SortOrder
        //     filter: [Filter!]
        //   ): MongoDatabaseConnection!
        internal void InitQueryMongoDatabases()
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
                "QueryMongoDatabases",
                "($first: Int,$after: String,$sortBy: HierarchySortByField,$sortOrder: SortOrder,$filter: [Filter!])",
                "MongoDatabaseConnection",
                Query.MongoDatabases_ObjectFieldSpec,
                Query.MongoDatabasesFieldSpec,
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
        // mongoCollections(
        //     first: Int
        //     after: String
        //     sortBy: HierarchySortByField
        //     sortOrder: SortOrder
        //     filter: [Filter!]
        //   ): MongoCollectionConnection!
        internal void InitQueryMongoCollections()
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
                "QueryMongoCollections",
                "($first: Int,$after: String,$sortBy: HierarchySortByField,$sortOrder: SortOrder,$filter: [Filter!])",
                "MongoCollectionConnection",
                Query.MongoCollections_ObjectFieldSpec,
                Query.MongoCollectionsFieldSpec,
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
        // mongoSource(fid: UUID!): MongoSource!
        internal void InitQueryMongoSource()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryMongoSource",
                "($fid: UUID!)",
                "MongoSource",
                Query.MongoSource_ObjectFieldSpec,
                Query.MongoSourceFieldSpec,
                @"# REQUIRED
$inputs.Var.fid = <System.String>"
            );
        }

        // Create new GraphQL Query:
        // mongoDatabase(fid: UUID!): MongoDatabase!
        internal void InitQueryMongoDatabase()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryMongoDatabase",
                "($fid: UUID!)",
                "MongoDatabase",
                Query.MongoDatabase_ObjectFieldSpec,
                Query.MongoDatabaseFieldSpec,
                @"# REQUIRED
$inputs.Var.fid = <System.String>"
            );
        }

        // Create new GraphQL Query:
        // mongoCollection(fid: UUID!): MongoCollection!
        internal void InitQueryMongoCollection()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryMongoCollection",
                "($fid: UUID!)",
                "MongoCollection",
                Query.MongoCollection_ObjectFieldSpec,
                Query.MongoCollectionFieldSpec,
                @"# REQUIRED
$inputs.Var.fid = <System.String>"
            );
        }

        // Create new GraphQL Query:
        // mongoRecoverableRanges(input: RecoverableRangeInput!): MongoRecoverableRanges!
        internal void InitQueryMongoRecoverableRanges()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "RecoverableRangeInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryMongoRecoverableRanges",
                "($input: RecoverableRangeInput!)",
                "MongoRecoverableRanges",
                Query.MongoRecoverableRanges_ObjectFieldSpec,
                Query.MongoRecoverableRangesFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	source = <System.String>
	# OPTIONAL
	databases = @(
		<System.String>
	)
	# OPTIONAL
	collections = @(
		<System.String>
	)
}"
            );
        }

        // Create new GraphQL Query:
        // mongoBulkRecoverableRanges(input: RecoverableRangeInput!): MongoRecoverableRanges!
        internal void InitQueryMongoBulkRecoverableRanges()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "RecoverableRangeInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryMongoBulkRecoverableRanges",
                "($input: RecoverableRangeInput!)",
                "MongoRecoverableRanges",
                Query.MongoBulkRecoverableRanges_ObjectFieldSpec,
                Query.MongoBulkRecoverableRangesFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	source = <System.String>
	# OPTIONAL
	databases = @(
		<System.String>
	)
	# OPTIONAL
	collections = @(
		<System.String>
	)
}"
            );
        }

        // Create new GraphQL Query:
        // mongodbSources(
        //     first: Int
        //     after: String
        //     sortBy: HierarchySortByField
        //     sortOrder: SortOrder
        //     filter: [Filter!]
        //   ): MongodbSourceConnection!
        internal void InitQueryMongodbSources()
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
                "QueryMongodbSources",
                "($first: Int,$after: String,$sortBy: HierarchySortByField,$sortOrder: SortOrder,$filter: [Filter!])",
                "MongodbSourceConnection",
                Query.MongodbSources_ObjectFieldSpec,
                Query.MongodbSourcesFieldSpec,
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
        // mongodbDatabases(
        //     first: Int
        //     after: String
        //     sortBy: HierarchySortByField
        //     sortOrder: SortOrder
        //     filter: [Filter!]
        //   ): MongodbDatabaseConnection!
        internal void InitQueryMongodbDatabases()
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
                "QueryMongodbDatabases",
                "($first: Int,$after: String,$sortBy: HierarchySortByField,$sortOrder: SortOrder,$filter: [Filter!])",
                "MongodbDatabaseConnection",
                Query.MongodbDatabases_ObjectFieldSpec,
                Query.MongodbDatabasesFieldSpec,
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
        // mongodbCollections(
        //     first: Int
        //     after: String
        //     sortBy: HierarchySortByField
        //     sortOrder: SortOrder
        //     filter: [Filter!]
        //   ): MongodbCollectionConnection!
        internal void InitQueryMongodbCollections()
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
                "QueryMongodbCollections",
                "($first: Int,$after: String,$sortBy: HierarchySortByField,$sortOrder: SortOrder,$filter: [Filter!])",
                "MongodbCollectionConnection",
                Query.MongodbCollections_ObjectFieldSpec,
                Query.MongodbCollectionsFieldSpec,
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
        // mongodbSource(fid: UUID!): MongodbSource!
        internal void InitQueryMongodbSource()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryMongodbSource",
                "($fid: UUID!)",
                "MongodbSource",
                Query.MongodbSource_ObjectFieldSpec,
                Query.MongodbSourceFieldSpec,
                @"# REQUIRED
$inputs.Var.fid = <System.String>"
            );
        }

        // Create new GraphQL Query:
        // mongodbDatabase(fid: UUID!): MongodbDatabase!
        internal void InitQueryMongodbDatabase()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryMongodbDatabase",
                "($fid: UUID!)",
                "MongodbDatabase",
                Query.MongodbDatabase_ObjectFieldSpec,
                Query.MongodbDatabaseFieldSpec,
                @"# REQUIRED
$inputs.Var.fid = <System.String>"
            );
        }

        // Create new GraphQL Query:
        // mongodbCollection(fid: UUID!): MongodbCollection!
        internal void InitQueryMongodbCollection()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryMongodbCollection",
                "($fid: UUID!)",
                "MongodbCollection",
                Query.MongodbCollection_ObjectFieldSpec,
                Query.MongodbCollectionFieldSpec,
                @"# REQUIRED
$inputs.Var.fid = <System.String>"
            );
        }

        // Create new GraphQL Query:
        // mongodbCollectionRecoverableRange(input: GetMosaicRecoverableRangeInput!): GetMosaicRecoverableRangeResponse!
        internal void InitQueryMongodbCollectionRecoverableRange()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetMosaicRecoverableRangeInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryMongodbCollectionRecoverableRange",
                "($input: GetMosaicRecoverableRangeInput!)",
                "GetMosaicRecoverableRangeResponse",
                Query.MongodbCollectionRecoverableRange_ObjectFieldSpec,
                Query.MongodbCollectionRecoverableRangeFieldSpec,
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
        // mongodbBulkRecoverableRange(input: MosaicBulkRecoveryRangeInput!): MosaicRecoveryRangeResponse!
        internal void InitQueryMongodbBulkRecoverableRange()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "MosaicBulkRecoveryRangeInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryMongodbBulkRecoverableRange",
                "($input: MosaicBulkRecoveryRangeInput!)",
                "MosaicRecoveryRangeResponse",
                Query.MongodbBulkRecoverableRange_ObjectFieldSpec,
                Query.MongodbBulkRecoverableRangeFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	clusterUuid = <System.String>
	# REQUIRED
	recoveryRangeData = @{
		# OPTIONAL
		sourceType = <MosaicBulkRecoverableRangeRequestSourceType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.MosaicBulkRecoverableRangeRequestSourceType]) for enum values.
		# REQUIRED
		managementObjects = @{
			# OPTIONAL
			databases = @(
				@{
					# OPTIONAL
					dbName = <System.String>
					# OPTIONAL
					tables = @(
						<System.String>
					)
				}
			)
		}
		# REQUIRED
		sourceName = <System.String>
	}
}"
            );
        }


    } // class New_RscQueryMongo
}