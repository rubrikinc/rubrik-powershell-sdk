// Invoke-RscQueryMongo.cs
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
        "RscQueryMongo",
        DefaultParameterSetName = "Source")
    ]
    public class Invoke_RscQueryMongo : RscPSCmdlet
    {
        
        // -------------------------------------------------------------------
        // Sources parameter set
        //
        // [GraphQL: mongoSources]
        //
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

        
        // -------------------------------------------------------------------
        // Databases parameter set
        //
        // [GraphQL: mongoDatabases]
        //
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

        
        // -------------------------------------------------------------------
        // Collections parameter set
        //
        // [GraphQL: mongoCollections]
        //
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

        
        // -------------------------------------------------------------------
        // Source parameter set
        //
        // [GraphQL: mongoSource]
        //
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

        
        // -------------------------------------------------------------------
        // Database parameter set
        //
        // [GraphQL: mongoDatabase]
        //
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

        
        // -------------------------------------------------------------------
        // Collection parameter set
        //
        // [GraphQL: mongoCollection]
        //
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

        
        // -------------------------------------------------------------------
        // RecoverableRanges parameter set
        //
        // [GraphQL: mongoRecoverableRanges]
        //
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

        
        // -------------------------------------------------------------------
        // BulkRecoverableRanges parameter set
        //
        // [GraphQL: mongoBulkRecoverableRanges]
        //
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

        
        // -------------------------------------------------------------------
        // DbSources parameter set
        //
        // [GraphQL: mongodbSources]
        //
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

        
        // -------------------------------------------------------------------
        // DbDatabases parameter set
        //
        // [GraphQL: mongodbDatabases]
        //
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

        
        // -------------------------------------------------------------------
        // DbCollections parameter set
        //
        // [GraphQL: mongodbCollections]
        //
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

        
        // -------------------------------------------------------------------
        // DbSource parameter set
        //
        // [GraphQL: mongodbSource]
        //
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

        
        // -------------------------------------------------------------------
        // DbDatabase parameter set
        //
        // [GraphQL: mongodbDatabase]
        //
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

        
        // -------------------------------------------------------------------
        // DbCollection parameter set
        //
        // [GraphQL: mongodbCollection]
        //
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

        
        // -------------------------------------------------------------------
        // DbCollectionRecoverableRange parameter set
        //
        // [GraphQL: mongodbCollectionRecoverableRange]
        //
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

        
        // -------------------------------------------------------------------
        // DbBulkRecoverableRange parameter set
        //
        // [GraphQL: mongodbBulkRecoverableRange]
        //
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


        protected override void ProcessRecord()
        {
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

        // This parameter set invokes a single graphql operation:
        // mongoSources.
        protected void ProcessRecord_Sources()
        {
            this._logger.name += " -Sources";
            // Invoke graphql operation mongoSources
            InvokeQueryMongoSources();
        }

        // This parameter set invokes a single graphql operation:
        // mongoDatabases.
        protected void ProcessRecord_Databases()
        {
            this._logger.name += " -Databases";
            // Invoke graphql operation mongoDatabases
            InvokeQueryMongoDatabases();
        }

        // This parameter set invokes a single graphql operation:
        // mongoCollections.
        protected void ProcessRecord_Collections()
        {
            this._logger.name += " -Collections";
            // Invoke graphql operation mongoCollections
            InvokeQueryMongoCollections();
        }

        // This parameter set invokes a single graphql operation:
        // mongoSource.
        protected void ProcessRecord_Source()
        {
            this._logger.name += " -Source";
            // Invoke graphql operation mongoSource
            InvokeQueryMongoSource();
        }

        // This parameter set invokes a single graphql operation:
        // mongoDatabase.
        protected void ProcessRecord_Database()
        {
            this._logger.name += " -Database";
            // Invoke graphql operation mongoDatabase
            InvokeQueryMongoDatabase();
        }

        // This parameter set invokes a single graphql operation:
        // mongoCollection.
        protected void ProcessRecord_Collection()
        {
            this._logger.name += " -Collection";
            // Invoke graphql operation mongoCollection
            InvokeQueryMongoCollection();
        }

        // This parameter set invokes a single graphql operation:
        // mongoRecoverableRanges.
        protected void ProcessRecord_RecoverableRanges()
        {
            this._logger.name += " -RecoverableRanges";
            // Invoke graphql operation mongoRecoverableRanges
            InvokeQueryMongoRecoverableRanges();
        }

        // This parameter set invokes a single graphql operation:
        // mongoBulkRecoverableRanges.
        protected void ProcessRecord_BulkRecoverableRanges()
        {
            this._logger.name += " -BulkRecoverableRanges";
            // Invoke graphql operation mongoBulkRecoverableRanges
            InvokeQueryMongoBulkRecoverableRanges();
        }

        // This parameter set invokes a single graphql operation:
        // mongodbSources.
        protected void ProcessRecord_DbSources()
        {
            this._logger.name += " -DbSources";
            // Invoke graphql operation mongodbSources
            InvokeQueryMongodbSources();
        }

        // This parameter set invokes a single graphql operation:
        // mongodbDatabases.
        protected void ProcessRecord_DbDatabases()
        {
            this._logger.name += " -DbDatabases";
            // Invoke graphql operation mongodbDatabases
            InvokeQueryMongodbDatabases();
        }

        // This parameter set invokes a single graphql operation:
        // mongodbCollections.
        protected void ProcessRecord_DbCollections()
        {
            this._logger.name += " -DbCollections";
            // Invoke graphql operation mongodbCollections
            InvokeQueryMongodbCollections();
        }

        // This parameter set invokes a single graphql operation:
        // mongodbSource.
        protected void ProcessRecord_DbSource()
        {
            this._logger.name += " -DbSource";
            // Invoke graphql operation mongodbSource
            InvokeQueryMongodbSource();
        }

        // This parameter set invokes a single graphql operation:
        // mongodbDatabase.
        protected void ProcessRecord_DbDatabase()
        {
            this._logger.name += " -DbDatabase";
            // Invoke graphql operation mongodbDatabase
            InvokeQueryMongodbDatabase();
        }

        // This parameter set invokes a single graphql operation:
        // mongodbCollection.
        protected void ProcessRecord_DbCollection()
        {
            this._logger.name += " -DbCollection";
            // Invoke graphql operation mongodbCollection
            InvokeQueryMongodbCollection();
        }

        // This parameter set invokes a single graphql operation:
        // mongodbCollectionRecoverableRange.
        protected void ProcessRecord_DbCollectionRecoverableRange()
        {
            this._logger.name += " -DbCollectionRecoverableRange";
            // Invoke graphql operation mongodbCollectionRecoverableRange
            InvokeQueryMongodbCollectionRecoverableRange();
        }

        // This parameter set invokes a single graphql operation:
        // mongodbBulkRecoverableRange.
        protected void ProcessRecord_DbBulkRecoverableRange()
        {
            this._logger.name += " -DbBulkRecoverableRange";
            // Invoke graphql operation mongodbBulkRecoverableRange
            InvokeQueryMongodbBulkRecoverableRange();
        }


        // Invoke GraphQL Query:
        // mongoSources(
        //     first: Int
        //     after: String
        //     sortBy: HierarchySortByField
        //     sortOrder: SortOrder
        //     filter: [Filter!]
        //   ): MongoSourceConnection!
        protected void InvokeQueryMongoSources()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("sortBy", "HierarchySortByField"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("filter", "[Filter!]"),
            };
            MongoSourceConnection? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (MongoSourceConnection)psObject.BaseObject;
                } else {
                    fieldSpecObj = (MongoSourceConnection)this.Field;
                }
            }
            string fieldSpecDoc = Query.MongoSources(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryMongoSources",
                "($first: Int,$after: String,$sortBy: HierarchySortByField,$sortOrder: SortOrder,$filter: [Filter!])",
                fieldSpecDoc,
                "MongoSourceConnection"
            );
        }

        // Invoke GraphQL Query:
        // mongoDatabases(
        //     first: Int
        //     after: String
        //     sortBy: HierarchySortByField
        //     sortOrder: SortOrder
        //     filter: [Filter!]
        //   ): MongoDatabaseConnection!
        protected void InvokeQueryMongoDatabases()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("sortBy", "HierarchySortByField"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("filter", "[Filter!]"),
            };
            MongoDatabaseConnection? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (MongoDatabaseConnection)psObject.BaseObject;
                } else {
                    fieldSpecObj = (MongoDatabaseConnection)this.Field;
                }
            }
            string fieldSpecDoc = Query.MongoDatabases(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryMongoDatabases",
                "($first: Int,$after: String,$sortBy: HierarchySortByField,$sortOrder: SortOrder,$filter: [Filter!])",
                fieldSpecDoc,
                "MongoDatabaseConnection"
            );
        }

        // Invoke GraphQL Query:
        // mongoCollections(
        //     first: Int
        //     after: String
        //     sortBy: HierarchySortByField
        //     sortOrder: SortOrder
        //     filter: [Filter!]
        //   ): MongoCollectionConnection!
        protected void InvokeQueryMongoCollections()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("sortBy", "HierarchySortByField"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("filter", "[Filter!]"),
            };
            MongoCollectionConnection? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (MongoCollectionConnection)psObject.BaseObject;
                } else {
                    fieldSpecObj = (MongoCollectionConnection)this.Field;
                }
            }
            string fieldSpecDoc = Query.MongoCollections(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryMongoCollections",
                "($first: Int,$after: String,$sortBy: HierarchySortByField,$sortOrder: SortOrder,$filter: [Filter!])",
                fieldSpecDoc,
                "MongoCollectionConnection"
            );
        }

        // Invoke GraphQL Query:
        // mongoSource(fid: UUID!): MongoSource!
        protected void InvokeQueryMongoSource()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            MongoSource? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (MongoSource)psObject.BaseObject;
                } else {
                    fieldSpecObj = (MongoSource)this.Field;
                }
            }
            string fieldSpecDoc = Query.MongoSource(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryMongoSource",
                "($fid: UUID!)",
                fieldSpecDoc,
                "MongoSource"
            );
        }

        // Invoke GraphQL Query:
        // mongoDatabase(fid: UUID!): MongoDatabase!
        protected void InvokeQueryMongoDatabase()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            MongoDatabase? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (MongoDatabase)psObject.BaseObject;
                } else {
                    fieldSpecObj = (MongoDatabase)this.Field;
                }
            }
            string fieldSpecDoc = Query.MongoDatabase(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryMongoDatabase",
                "($fid: UUID!)",
                fieldSpecDoc,
                "MongoDatabase"
            );
        }

        // Invoke GraphQL Query:
        // mongoCollection(fid: UUID!): MongoCollection!
        protected void InvokeQueryMongoCollection()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            MongoCollection? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (MongoCollection)psObject.BaseObject;
                } else {
                    fieldSpecObj = (MongoCollection)this.Field;
                }
            }
            string fieldSpecDoc = Query.MongoCollection(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryMongoCollection",
                "($fid: UUID!)",
                fieldSpecDoc,
                "MongoCollection"
            );
        }

        // Invoke GraphQL Query:
        // mongoRecoverableRanges(input: RecoverableRangeInput!): MongoRecoverableRanges!
        protected void InvokeQueryMongoRecoverableRanges()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "RecoverableRangeInput!"),
            };
            MongoRecoverableRanges? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (MongoRecoverableRanges)psObject.BaseObject;
                } else {
                    fieldSpecObj = (MongoRecoverableRanges)this.Field;
                }
            }
            string fieldSpecDoc = Query.MongoRecoverableRanges(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryMongoRecoverableRanges",
                "($input: RecoverableRangeInput!)",
                fieldSpecDoc,
                "MongoRecoverableRanges"
            );
        }

        // Invoke GraphQL Query:
        // mongoBulkRecoverableRanges(input: RecoverableRangeInput!): MongoRecoverableRanges!
        protected void InvokeQueryMongoBulkRecoverableRanges()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "RecoverableRangeInput!"),
            };
            MongoRecoverableRanges? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (MongoRecoverableRanges)psObject.BaseObject;
                } else {
                    fieldSpecObj = (MongoRecoverableRanges)this.Field;
                }
            }
            string fieldSpecDoc = Query.MongoBulkRecoverableRanges(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryMongoBulkRecoverableRanges",
                "($input: RecoverableRangeInput!)",
                fieldSpecDoc,
                "MongoRecoverableRanges"
            );
        }

        // Invoke GraphQL Query:
        // mongodbSources(
        //     first: Int
        //     after: String
        //     sortBy: HierarchySortByField
        //     sortOrder: SortOrder
        //     filter: [Filter!]
        //   ): MongodbSourceConnection!
        protected void InvokeQueryMongodbSources()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("sortBy", "HierarchySortByField"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("filter", "[Filter!]"),
            };
            MongodbSourceConnection? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (MongodbSourceConnection)psObject.BaseObject;
                } else {
                    fieldSpecObj = (MongodbSourceConnection)this.Field;
                }
            }
            string fieldSpecDoc = Query.MongodbSources(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryMongodbSources",
                "($first: Int,$after: String,$sortBy: HierarchySortByField,$sortOrder: SortOrder,$filter: [Filter!])",
                fieldSpecDoc,
                "MongodbSourceConnection"
            );
        }

        // Invoke GraphQL Query:
        // mongodbDatabases(
        //     first: Int
        //     after: String
        //     sortBy: HierarchySortByField
        //     sortOrder: SortOrder
        //     filter: [Filter!]
        //   ): MongodbDatabaseConnection!
        protected void InvokeQueryMongodbDatabases()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("sortBy", "HierarchySortByField"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("filter", "[Filter!]"),
            };
            MongodbDatabaseConnection? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (MongodbDatabaseConnection)psObject.BaseObject;
                } else {
                    fieldSpecObj = (MongodbDatabaseConnection)this.Field;
                }
            }
            string fieldSpecDoc = Query.MongodbDatabases(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryMongodbDatabases",
                "($first: Int,$after: String,$sortBy: HierarchySortByField,$sortOrder: SortOrder,$filter: [Filter!])",
                fieldSpecDoc,
                "MongodbDatabaseConnection"
            );
        }

        // Invoke GraphQL Query:
        // mongodbCollections(
        //     first: Int
        //     after: String
        //     sortBy: HierarchySortByField
        //     sortOrder: SortOrder
        //     filter: [Filter!]
        //   ): MongodbCollectionConnection!
        protected void InvokeQueryMongodbCollections()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("sortBy", "HierarchySortByField"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("filter", "[Filter!]"),
            };
            MongodbCollectionConnection? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (MongodbCollectionConnection)psObject.BaseObject;
                } else {
                    fieldSpecObj = (MongodbCollectionConnection)this.Field;
                }
            }
            string fieldSpecDoc = Query.MongodbCollections(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryMongodbCollections",
                "($first: Int,$after: String,$sortBy: HierarchySortByField,$sortOrder: SortOrder,$filter: [Filter!])",
                fieldSpecDoc,
                "MongodbCollectionConnection"
            );
        }

        // Invoke GraphQL Query:
        // mongodbSource(fid: UUID!): MongodbSource!
        protected void InvokeQueryMongodbSource()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            MongodbSource? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (MongodbSource)psObject.BaseObject;
                } else {
                    fieldSpecObj = (MongodbSource)this.Field;
                }
            }
            string fieldSpecDoc = Query.MongodbSource(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryMongodbSource",
                "($fid: UUID!)",
                fieldSpecDoc,
                "MongodbSource"
            );
        }

        // Invoke GraphQL Query:
        // mongodbDatabase(fid: UUID!): MongodbDatabase!
        protected void InvokeQueryMongodbDatabase()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            MongodbDatabase? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (MongodbDatabase)psObject.BaseObject;
                } else {
                    fieldSpecObj = (MongodbDatabase)this.Field;
                }
            }
            string fieldSpecDoc = Query.MongodbDatabase(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryMongodbDatabase",
                "($fid: UUID!)",
                fieldSpecDoc,
                "MongodbDatabase"
            );
        }

        // Invoke GraphQL Query:
        // mongodbCollection(fid: UUID!): MongodbCollection!
        protected void InvokeQueryMongodbCollection()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            MongodbCollection? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (MongodbCollection)psObject.BaseObject;
                } else {
                    fieldSpecObj = (MongodbCollection)this.Field;
                }
            }
            string fieldSpecDoc = Query.MongodbCollection(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryMongodbCollection",
                "($fid: UUID!)",
                fieldSpecDoc,
                "MongodbCollection"
            );
        }

        // Invoke GraphQL Query:
        // mongodbCollectionRecoverableRange(input: GetMosaicRecoverableRangeInput!): GetMosaicRecoverableRangeResponse!
        protected void InvokeQueryMongodbCollectionRecoverableRange()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetMosaicRecoverableRangeInput!"),
            };
            GetMosaicRecoverableRangeResponse? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (GetMosaicRecoverableRangeResponse)psObject.BaseObject;
                } else {
                    fieldSpecObj = (GetMosaicRecoverableRangeResponse)this.Field;
                }
            }
            string fieldSpecDoc = Query.MongodbCollectionRecoverableRange(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryMongodbCollectionRecoverableRange",
                "($input: GetMosaicRecoverableRangeInput!)",
                fieldSpecDoc,
                "GetMosaicRecoverableRangeResponse"
            );
        }

        // Invoke GraphQL Query:
        // mongodbBulkRecoverableRange(input: MosaicBulkRecoveryRangeInput!): MosaicRecoveryRangeResponse!
        protected void InvokeQueryMongodbBulkRecoverableRange()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "MosaicBulkRecoveryRangeInput!"),
            };
            MosaicRecoveryRangeResponse? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (MosaicRecoveryRangeResponse)psObject.BaseObject;
                } else {
                    fieldSpecObj = (MosaicRecoveryRangeResponse)this.Field;
                }
            }
            string fieldSpecDoc = Query.MongodbBulkRecoverableRange(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryMongodbBulkRecoverableRange",
                "($input: MosaicBulkRecoveryRangeInput!)",
                fieldSpecDoc,
                "MosaicRecoveryRangeResponse"
            );
        }


    } // class Invoke_RscQueryMongo
}