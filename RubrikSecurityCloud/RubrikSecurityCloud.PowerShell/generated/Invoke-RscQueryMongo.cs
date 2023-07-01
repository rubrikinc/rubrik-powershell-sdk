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
        // RecoverableRange parameter set
        //
        // [GraphQL: mongoRecoverableRanges]
        //
        [Parameter(
            ParameterSetName = "RecoverableRange",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Provides the range for recovery of MongoDB objects.
[GraphQL: mongoRecoverableRanges]",
            Position = 0
        )]
        public SwitchParameter RecoverableRange { get; set; }

        
        // -------------------------------------------------------------------
        // DbSource parameter set
        //
        // [GraphQL: mongodbSources]
        //
        [Parameter(
            ParameterSetName = "DbSource",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Paginated list of MongoDB sources on NoSQL cluster.
[GraphQL: mongodbSources]",
            Position = 0
        )]
        public SwitchParameter DbSource { get; set; }

        
        // -------------------------------------------------------------------
        // DbDatabase parameter set
        //
        // [GraphQL: mongodbDatabases]
        //
        [Parameter(
            ParameterSetName = "DbDatabase",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Paginated list of MongoDB databases on NoSQL cluster.
[GraphQL: mongodbDatabases]",
            Position = 0
        )]
        public SwitchParameter DbDatabase { get; set; }

        
        // -------------------------------------------------------------------
        // DbCollection parameter set
        //
        // [GraphQL: mongodbCollections]
        //
        [Parameter(
            ParameterSetName = "DbCollection",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Paginated list of MongoDB collections on NoSQL cluster.
[GraphQL: mongodbCollections]",
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
                    case "Source":
                        this.ProcessRecord_Source();
                        break;
                    case "Database":
                        this.ProcessRecord_Database();
                        break;
                    case "Collection":
                        this.ProcessRecord_Collection();
                        break;
                    case "RecoverableRange":
                        this.ProcessRecord_RecoverableRange();
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
        protected void ProcessRecord_RecoverableRange()
        {
            this._logger.name += " -RecoverableRange";
            // Invoke graphql operation mongoRecoverableRanges
            InvokeQueryMongoRecoverableRanges();
        }

        // This parameter set invokes a single graphql operation:
        // mongodbSources.
        protected void ProcessRecord_DbSource()
        {
            this._logger.name += " -DbSource";
            // Invoke graphql operation mongodbSources
            InvokeQueryMongodbSources();
        }

        // This parameter set invokes a single graphql operation:
        // mongodbDatabases.
        protected void ProcessRecord_DbDatabase()
        {
            this._logger.name += " -DbDatabase";
            // Invoke graphql operation mongodbDatabases
            InvokeQueryMongodbDatabases();
        }

        // This parameter set invokes a single graphql operation:
        // mongodbCollections.
        protected void ProcessRecord_DbCollection()
        {
            this._logger.name += " -DbCollection";
            // Invoke graphql operation mongodbCollections
            InvokeQueryMongodbCollections();
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
            var vars = new OperationVariableSet();
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
            var vars = new OperationVariableSet();
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
            var vars = new OperationVariableSet();
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
            var vars = new OperationVariableSet();
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
            var vars = new OperationVariableSet();
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
            var vars = new OperationVariableSet();
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
            var vars = new OperationVariableSet();
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
            var vars = new OperationVariableSet();
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
            var vars = new OperationVariableSet();
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