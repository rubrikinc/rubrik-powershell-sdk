// Invoke-RscQueryMongo.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using Rubrik.SecurityCloud.Types;
using Rubrik.SecurityCloud.NetSDK.Client;
using Rubrik.SecurityCloud.PowerShell.Private;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Management.Automation;
using System.Text;
using System.Threading.Tasks;
using RubrikSecurityCloud.Schema.Utils;
using GraphQL;

namespace Rubrik.SecurityCloud.PowerShell.Cmdlets
{
    [Cmdlet(
        "Invoke",
        "RscQueryMongo",
        DefaultParameterSetName = "Source")
    ]
    public class Invoke_RscQueryMongo : RscPSCmdlet
    {
        
        // -------------------------------------------------------------------
        // Source parameter set
        //
        // [GraphQL: mongoSources]
        //
        [Parameter(
            ParameterSetName = "Source",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Paginated list of MongoDB sources.
[GraphQL: mongoSources]",
            Position = 0
        )]
        public SwitchParameter Source { get; set; }

        [Parameter(
            ParameterSetName = "Source",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Returns the first n elements from the list.
GraphQL argument first: Int"
        )]
        public System.Int32? First { get; set; }
        [Parameter(
            ParameterSetName = "Source",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Returns the elements in the list that come after the specified cursor.
GraphQL argument after: String"
        )]
        public System.String? After { get; set; }
        [Parameter(
            ParameterSetName = "Source",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Sort hierarchy objects by hierarchy field.
GraphQL argument sortBy: HierarchySortByField"
        )]
        public HierarchySortByField? SortBy { get; set; }
        [Parameter(
            ParameterSetName = "Source",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Sorting order for the results.
GraphQL argument sortOrder: SortOrder"
        )]
        public SortOrder? SortOrder { get; set; }
        [Parameter(
            ParameterSetName = "Source",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"The hierarchy object filter.
GraphQL argument filter: [Filter!]"
        )]
        public List<Filter>? Filter { get; set; }
        
        // -------------------------------------------------------------------
        // Database parameter set
        //
        // [GraphQL: mongoDatabases]
        //
        [Parameter(
            ParameterSetName = "Database",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Paginated list of MongoDB databases.
[GraphQL: mongoDatabases]",
            Position = 0
        )]
        public SwitchParameter Database { get; set; }

        
        // -------------------------------------------------------------------
        // Collection parameter set
        //
        // [GraphQL: mongoCollections]
        //
        [Parameter(
            ParameterSetName = "Collection",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Paginated list of MongoDB collections.
[GraphQL: mongoCollections]",
            Position = 0
        )]
        public SwitchParameter Collection { get; set; }

        
        // -------------------------------------------------------------------
        // Recoverablerange parameter set
        //
        // [GraphQL: mongoRecoverableRanges]
        //
        [Parameter(
            ParameterSetName = "Recoverablerange",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Provides the range for recovery of MongoDB objects.
[GraphQL: mongoRecoverableRanges]",
            Position = 0
        )]
        public SwitchParameter Recoverablerange { get; set; }

        [Parameter(
            ParameterSetName = "Recoverablerange",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Arguments for MongoDB recoverable range.
GraphQL argument input: RecoverableRangeInput!"
        )]
        public RecoverableRangeInput? Input { get; set; }
        
        // -------------------------------------------------------------------
        // Dbsource parameter set
        //
        // [GraphQL: mongodbSources]
        //
        [Parameter(
            ParameterSetName = "Dbsource",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Paginated list of MongoDB sources on NoSQL cluster.
[GraphQL: mongodbSources]",
            Position = 0
        )]
        public SwitchParameter Dbsource { get; set; }

        
        // -------------------------------------------------------------------
        // Dbdatabase parameter set
        //
        // [GraphQL: mongodbDatabases]
        //
        [Parameter(
            ParameterSetName = "Dbdatabase",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Paginated list of MongoDB databases on NoSQL cluster.
[GraphQL: mongodbDatabases]",
            Position = 0
        )]
        public SwitchParameter Dbdatabase { get; set; }

        
        // -------------------------------------------------------------------
        // Dbcollection parameter set
        //
        // [GraphQL: mongodbCollections]
        //
        [Parameter(
            ParameterSetName = "Dbcollection",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Paginated list of MongoDB collections on NoSQL cluster.
[GraphQL: mongodbCollections]",
            Position = 0
        )]
        public SwitchParameter Dbcollection { get; set; }

        
        // -------------------------------------------------------------------
        // Dbcollectionrecoverablerange parameter set
        //
        // [GraphQL: mongodbCollectionRecoverableRange]
        //
        [Parameter(
            ParameterSetName = "Dbcollectionrecoverablerange",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Recoverable Range of a MongoDB collection on NoSQL cluster.
[GraphQL: mongodbCollectionRecoverableRange]",
            Position = 0
        )]
        public SwitchParameter Dbcollectionrecoverablerange { get; set; }

        
        // -------------------------------------------------------------------
        // Dbbulkrecoverablerange parameter set
        //
        // [GraphQL: mongodbBulkRecoverableRange]
        //
        [Parameter(
            ParameterSetName = "Dbbulkrecoverablerange",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Recoverable range for multiple Management Objects on NoSQL cluster.
[GraphQL: mongodbBulkRecoverableRange]",
            Position = 0
        )]
        public SwitchParameter Dbbulkrecoverablerange { get; set; }


        protected override void ProcessRecord()
        {
            try
            {
                switch(Op)
                {
                    case "Source":
                        this.ProcessRecord_Source();
                        break;
                    case "Database":
                        this.ProcessRecord_Database();
                        break;
                    case "Collection":
                        this.ProcessRecord_Collection();
                        break;
                    case "Recoverablerange":
                        this.ProcessRecord_Recoverablerange();
                        break;
                    case "Dbsource":
                        this.ProcessRecord_Dbsource();
                        break;
                    case "Dbdatabase":
                        this.ProcessRecord_Dbdatabase();
                        break;
                    case "Dbcollection":
                        this.ProcessRecord_Dbcollection();
                        break;
                    case "Dbcollectionrecoverablerange":
                        this.ProcessRecord_Dbcollectionrecoverablerange();
                        break;
                    case "Dbbulkrecoverablerange":
                        this.ProcessRecord_Dbbulkrecoverablerange();
                        break;
                    default:
                        throw new Exception("Unknown Operation " + Op);
                }
           }
           catch (Exception ex)
           {
                this._logger.Flush();
                var error = new ErrorRecord(
                    ex,
                    "Invoke-RscQueryMongo",
                    ErrorCategory.InvalidOperation,
                    null);
                ThrowTerminatingError(error);
           }
        }

        // This parameter set invokes a single graphql operation:
        // mongoSources.
        protected void ProcessRecord_Source()
        {
            this._logger.name += " -Source";
            // Invoke graphql operation mongoSources
            InvokeQueryMongoSources();
        }

        // This parameter set invokes a single graphql operation:
        // mongoDatabases.
        protected void ProcessRecord_Database()
        {
            this._logger.name += " -Database";
            // Invoke graphql operation mongoDatabases
            InvokeQueryMongoDatabases();
        }

        // This parameter set invokes a single graphql operation:
        // mongoCollections.
        protected void ProcessRecord_Collection()
        {
            this._logger.name += " -Collection";
            // Invoke graphql operation mongoCollections
            InvokeQueryMongoCollections();
        }

        // This parameter set invokes a single graphql operation:
        // mongoRecoverableRanges.
        protected void ProcessRecord_Recoverablerange()
        {
            this._logger.name += " -Recoverablerange";
            // Invoke graphql operation mongoRecoverableRanges
            InvokeQueryMongoRecoverableRanges();
        }

        // This parameter set invokes a single graphql operation:
        // mongodbSources.
        protected void ProcessRecord_Dbsource()
        {
            this._logger.name += " -Dbsource";
            // Invoke graphql operation mongodbSources
            InvokeQueryMongodbSources();
        }

        // This parameter set invokes a single graphql operation:
        // mongodbDatabases.
        protected void ProcessRecord_Dbdatabase()
        {
            this._logger.name += " -Dbdatabase";
            // Invoke graphql operation mongodbDatabases
            InvokeQueryMongodbDatabases();
        }

        // This parameter set invokes a single graphql operation:
        // mongodbCollections.
        protected void ProcessRecord_Dbcollection()
        {
            this._logger.name += " -Dbcollection";
            // Invoke graphql operation mongodbCollections
            InvokeQueryMongodbCollections();
        }

        // This parameter set invokes a single graphql operation:
        // mongodbCollectionRecoverableRange.
        protected void ProcessRecord_Dbcollectionrecoverablerange()
        {
            this._logger.name += " -Dbcollectionrecoverablerange";
            // Invoke graphql operation mongodbCollectionRecoverableRange
            InvokeQueryMongodbCollectionRecoverableRange();
        }

        // This parameter set invokes a single graphql operation:
        // mongodbBulkRecoverableRange.
        protected void ProcessRecord_Dbbulkrecoverablerange()
        {
            this._logger.name += " -Dbbulkrecoverablerange";
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
            MongoSourceConnection? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (MongoSourceConnection)psObject.BaseObject;
                } else {
                    fields = (MongoSourceConnection)this.Field;
                }
            }
            string document = Query.MongoSources(ref fields);
            this._input.Initialize(argDefs, fields, "Query.MongoSources");
            var parameters = "($first: Int,$after: String,$sortBy: HierarchySortByField,$sortOrder: SortOrder,$filter: [Filter!])\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryMongoSources" + parameters + "{" + document + "}",
                OperationName = "QueryMongoSources",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "MongoSourceConnection", this._logger, GetMetricTags());
            WriteObject(result, true);
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
            MongoDatabaseConnection? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (MongoDatabaseConnection)psObject.BaseObject;
                } else {
                    fields = (MongoDatabaseConnection)this.Field;
                }
            }
            string document = Query.MongoDatabases(ref fields);
            this._input.Initialize(argDefs, fields, "Query.MongoDatabases");
            var parameters = "($first: Int,$after: String,$sortBy: HierarchySortByField,$sortOrder: SortOrder,$filter: [Filter!])\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryMongoDatabases" + parameters + "{" + document + "}",
                OperationName = "QueryMongoDatabases",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "MongoDatabaseConnection", this._logger, GetMetricTags());
            WriteObject(result, true);
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
            MongoCollectionConnection? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (MongoCollectionConnection)psObject.BaseObject;
                } else {
                    fields = (MongoCollectionConnection)this.Field;
                }
            }
            string document = Query.MongoCollections(ref fields);
            this._input.Initialize(argDefs, fields, "Query.MongoCollections");
            var parameters = "($first: Int,$after: String,$sortBy: HierarchySortByField,$sortOrder: SortOrder,$filter: [Filter!])\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryMongoCollections" + parameters + "{" + document + "}",
                OperationName = "QueryMongoCollections",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "MongoCollectionConnection", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // mongoRecoverableRanges(input: RecoverableRangeInput!): MongoRecoverableRanges!
        protected void InvokeQueryMongoRecoverableRanges()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "RecoverableRangeInput!"),
            };
            MongoRecoverableRanges? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (MongoRecoverableRanges)psObject.BaseObject;
                } else {
                    fields = (MongoRecoverableRanges)this.Field;
                }
            }
            string document = Query.MongoRecoverableRanges(ref fields);
            this._input.Initialize(argDefs, fields, "Query.MongoRecoverableRanges");
            var parameters = "($input: RecoverableRangeInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryMongoRecoverableRanges" + parameters + "{" + document + "}",
                OperationName = "QueryMongoRecoverableRanges",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "MongoRecoverableRanges", this._logger, GetMetricTags());
            WriteObject(result, true);
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
            MongodbSourceConnection? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (MongodbSourceConnection)psObject.BaseObject;
                } else {
                    fields = (MongodbSourceConnection)this.Field;
                }
            }
            string document = Query.MongodbSources(ref fields);
            this._input.Initialize(argDefs, fields, "Query.MongodbSources");
            var parameters = "($first: Int,$after: String,$sortBy: HierarchySortByField,$sortOrder: SortOrder,$filter: [Filter!])\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryMongodbSources" + parameters + "{" + document + "}",
                OperationName = "QueryMongodbSources",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "MongodbSourceConnection", this._logger, GetMetricTags());
            WriteObject(result, true);
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
            MongodbDatabaseConnection? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (MongodbDatabaseConnection)psObject.BaseObject;
                } else {
                    fields = (MongodbDatabaseConnection)this.Field;
                }
            }
            string document = Query.MongodbDatabases(ref fields);
            this._input.Initialize(argDefs, fields, "Query.MongodbDatabases");
            var parameters = "($first: Int,$after: String,$sortBy: HierarchySortByField,$sortOrder: SortOrder,$filter: [Filter!])\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryMongodbDatabases" + parameters + "{" + document + "}",
                OperationName = "QueryMongodbDatabases",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "MongodbDatabaseConnection", this._logger, GetMetricTags());
            WriteObject(result, true);
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
            MongodbCollectionConnection? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (MongodbCollectionConnection)psObject.BaseObject;
                } else {
                    fields = (MongodbCollectionConnection)this.Field;
                }
            }
            string document = Query.MongodbCollections(ref fields);
            this._input.Initialize(argDefs, fields, "Query.MongodbCollections");
            var parameters = "($first: Int,$after: String,$sortBy: HierarchySortByField,$sortOrder: SortOrder,$filter: [Filter!])\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryMongodbCollections" + parameters + "{" + document + "}",
                OperationName = "QueryMongodbCollections",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "MongodbCollectionConnection", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // mongodbCollectionRecoverableRange(input: GetMosaicRecoverableRangeInput!): GetMosaicRecoverableRangeResponse!
        protected void InvokeQueryMongodbCollectionRecoverableRange()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetMosaicRecoverableRangeInput!"),
            };
            GetMosaicRecoverableRangeResponse? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (GetMosaicRecoverableRangeResponse)psObject.BaseObject;
                } else {
                    fields = (GetMosaicRecoverableRangeResponse)this.Field;
                }
            }
            string document = Query.MongodbCollectionRecoverableRange(ref fields);
            this._input.Initialize(argDefs, fields, "Query.MongodbCollectionRecoverableRange");
            var parameters = "($input: GetMosaicRecoverableRangeInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryMongodbCollectionRecoverableRange" + parameters + "{" + document + "}",
                OperationName = "QueryMongodbCollectionRecoverableRange",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "GetMosaicRecoverableRangeResponse", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // mongodbBulkRecoverableRange(input: MosaicBulkRecoveryRangeInput!): MosaicRecoveryRangeResponse!
        protected void InvokeQueryMongodbBulkRecoverableRange()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "MosaicBulkRecoveryRangeInput!"),
            };
            MosaicRecoveryRangeResponse? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (MosaicRecoveryRangeResponse)psObject.BaseObject;
                } else {
                    fields = (MosaicRecoveryRangeResponse)this.Field;
                }
            }
            string document = Query.MongodbBulkRecoverableRange(ref fields);
            this._input.Initialize(argDefs, fields, "Query.MongodbBulkRecoverableRange");
            var parameters = "($input: MosaicBulkRecoveryRangeInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryMongodbBulkRecoverableRange" + parameters + "{" + document + "}",
                OperationName = "QueryMongodbBulkRecoverableRange",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "MosaicRecoveryRangeResponse", this._logger, GetMetricTags());
            WriteObject(result, true);
        }


    } // class Invoke_RscQueryMongo
}