// Invoke-RscQueryCassandra.cs
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
        "RscQueryCassandra",
        DefaultParameterSetName = "Source")
    ]
    public class Invoke_RscQueryCassandra : RscPSCmdlet
    {
        
        // -------------------------------------------------------------------
        // Source parameter set
        //
        // GraphQL operation: cassandraSources(,   first: Int,   after: String,   sortBy: HierarchySortByField,   sortOrder: SortOrder,   filter: [Filter!], ):CassandraSourceConnection!
        //
        [Parameter(
            ParameterSetName = "Source",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Paginated list of cassandra sources.
                GraphQL operation: cassandraSources(,   first: Int,   after: String,   sortBy: HierarchySortByField,   sortOrder: SortOrder,   filter: [Filter!], ):CassandraSourceConnection!
                ",
            Position = 0
        )]
        public SwitchParameter Source { get; set; }

        [Parameter(
            ParameterSetName = "Source",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Returns the first n elements from the list.
                GraphQL argument first: Int
                "
        )]
        public System.Int32? First { get; set; }
        [Parameter(
            ParameterSetName = "Source",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Returns the elements in the list that come after the specified cursor.
                GraphQL argument after: String
                "
        )]
        public System.String? After { get; set; }
        [Parameter(
            ParameterSetName = "Source",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Sort hierarchy objects by hierarchy field.
                GraphQL argument sortBy: HierarchySortByField
                "
        )]
        public HierarchySortByField? SortBy { get; set; }
        [Parameter(
            ParameterSetName = "Source",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Sorting order for the results.
                GraphQL argument sortOrder: SortOrder
                "
        )]
        public SortOrder? SortOrder { get; set; }
        [Parameter(
            ParameterSetName = "Source",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                The hierarchy object filter.
                GraphQL argument filter: [Filter!]
                "
        )]
        public List<Filter>? Filter { get; set; }
        
        // -------------------------------------------------------------------
        // Keyspace parameter set
        //
        // GraphQL operation: cassandraKeyspaces(,   first: Int,   after: String,   sortBy: HierarchySortByField,   sortOrder: SortOrder,   filter: [Filter!], ):CassandraKeyspaceConnection!
        //
        [Parameter(
            ParameterSetName = "Keyspace",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Paginated list of cassandra keyspaces.
                GraphQL operation: cassandraKeyspaces(,   first: Int,   after: String,   sortBy: HierarchySortByField,   sortOrder: SortOrder,   filter: [Filter!], ):CassandraKeyspaceConnection!
                ",
            Position = 0
        )]
        public SwitchParameter Keyspace { get; set; }

        
        // -------------------------------------------------------------------
        // ColumnFamily parameter set
        //
        // GraphQL operation: cassandraColumnFamilies(,   first: Int,   after: String,   sortBy: HierarchySortByField,   sortOrder: SortOrder,   filter: [Filter!], ):CassandraColumnFamilyConnection!
        //
        [Parameter(
            ParameterSetName = "ColumnFamily",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Paginated list of cassandra column families.
                GraphQL operation: cassandraColumnFamilies(,   first: Int,   after: String,   sortBy: HierarchySortByField,   sortOrder: SortOrder,   filter: [Filter!], ):CassandraColumnFamilyConnection!
                ",
            Position = 0
        )]
        public SwitchParameter ColumnFamily { get; set; }

        
        // -------------------------------------------------------------------
        // ColumnFamilyRecoverableRange parameter set
        //
        // GraphQL operation: cassandraColumnFamilyRecoverableRange(input: GetMosaicRecoverableRangeInput!):GetMosaicRecoverableRangeResponse!
        //
        [Parameter(
            ParameterSetName = "ColumnFamilyRecoverableRange",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Get Recoverable Range of a Cassandra Column Family.
                GraphQL operation: cassandraColumnFamilyRecoverableRange(input: GetMosaicRecoverableRangeInput!):GetMosaicRecoverableRangeResponse!
                ",
            Position = 0
        )]
        public SwitchParameter ColumnFamilyRecoverableRange { get; set; }

        [Parameter(
            ParameterSetName = "ColumnFamilyRecoverableRange",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Input for V2GetMosaicRecoverableRange.
                GraphQL argument input: GetMosaicRecoverableRangeInput!
                "
        )]
        public GetMosaicRecoverableRangeInput? Input { get; set; }
        
        // -------------------------------------------------------------------
        // ColumnFamilySchema parameter set
        //
        // GraphQL operation: cassandraColumnFamilySchema(input: GetMosaicTableSchemaInput!):GetSchemaResponse!
        //
        [Parameter(
            ParameterSetName = "ColumnFamilySchema",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Get Schema of a Cassandra Column Family.
                GraphQL operation: cassandraColumnFamilySchema(input: GetMosaicTableSchemaInput!):GetSchemaResponse!
                ",
            Position = 0
        )]
        public SwitchParameter ColumnFamilySchema { get; set; }


        protected override void ProcessRecord()
        {
            try
            {
                switch(Op)
                {
                    case "Source":
                        this.ProcessRecord_Source();
                        break;
                    case "Keyspace":
                        this.ProcessRecord_Keyspace();
                        break;
                    case "ColumnFamily":
                        this.ProcessRecord_ColumnFamily();
                        break;
                    case "ColumnFamilyRecoverableRange":
                        this.ProcessRecord_ColumnFamilyRecoverableRange();
                        break;
                    case "ColumnFamilySchema":
                        this.ProcessRecord_ColumnFamilySchema();
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
                    "Invoke-RscQueryCassandra",
                    ErrorCategory.InvalidOperation,
                    null);
                ThrowTerminatingError(error);
           }
        }

        // This parameter set invokes a single graphql operation:
        // cassandraSources.
        protected void ProcessRecord_Source()
        {
            this._logger.name += " -Source";
            // Invoke graphql operation cassandraSources
            InvokeQueryCassandraSources();
        }

        // This parameter set invokes a single graphql operation:
        // cassandraKeyspaces.
        protected void ProcessRecord_Keyspace()
        {
            this._logger.name += " -Keyspace";
            // Invoke graphql operation cassandraKeyspaces
            InvokeQueryCassandraKeyspaces();
        }

        // This parameter set invokes a single graphql operation:
        // cassandraColumnFamilies.
        protected void ProcessRecord_ColumnFamily()
        {
            this._logger.name += " -ColumnFamily";
            // Invoke graphql operation cassandraColumnFamilies
            InvokeQueryCassandraColumnFamilies();
        }

        // This parameter set invokes a single graphql operation:
        // cassandraColumnFamilyRecoverableRange.
        protected void ProcessRecord_ColumnFamilyRecoverableRange()
        {
            this._logger.name += " -ColumnFamilyRecoverableRange";
            // Invoke graphql operation cassandraColumnFamilyRecoverableRange
            InvokeQueryCassandraColumnFamilyRecoverableRange();
        }

        // This parameter set invokes a single graphql operation:
        // cassandraColumnFamilySchema.
        protected void ProcessRecord_ColumnFamilySchema()
        {
            this._logger.name += " -ColumnFamilySchema";
            // Invoke graphql operation cassandraColumnFamilySchema
            InvokeQueryCassandraColumnFamilySchema();
        }


        // Invoke GraphQL Query:
        // cassandraSources(
        //     first: Int
        //     after: String
        //     sortBy: HierarchySortByField
        //     sortOrder: SortOrder
        //     filter: [Filter!]
        //   ): CassandraSourceConnection!
        protected void InvokeQueryCassandraSources()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("sortBy", "HierarchySortByField"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("filter", "[Filter!]"),
            };
            CassandraSourceConnection? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (CassandraSourceConnection)psObject.BaseObject;
                } else {
                    fields = (CassandraSourceConnection)this.Field;
                }
            }
            string document = Query.CassandraSources(ref fields);
            this._input.Initialize(argDefs, fields, "Query.CassandraSources");
            var parameters = "($first: Int,$after: String,$sortBy: HierarchySortByField,$sortOrder: SortOrder,$filter: [Filter!])\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryCassandraSources" + parameters + "{" + document + "}",
                OperationName = "QueryCassandraSources",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "CassandraSourceConnection", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // cassandraKeyspaces(
        //     first: Int
        //     after: String
        //     sortBy: HierarchySortByField
        //     sortOrder: SortOrder
        //     filter: [Filter!]
        //   ): CassandraKeyspaceConnection!
        protected void InvokeQueryCassandraKeyspaces()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("sortBy", "HierarchySortByField"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("filter", "[Filter!]"),
            };
            CassandraKeyspaceConnection? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (CassandraKeyspaceConnection)psObject.BaseObject;
                } else {
                    fields = (CassandraKeyspaceConnection)this.Field;
                }
            }
            string document = Query.CassandraKeyspaces(ref fields);
            this._input.Initialize(argDefs, fields, "Query.CassandraKeyspaces");
            var parameters = "($first: Int,$after: String,$sortBy: HierarchySortByField,$sortOrder: SortOrder,$filter: [Filter!])\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryCassandraKeyspaces" + parameters + "{" + document + "}",
                OperationName = "QueryCassandraKeyspaces",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "CassandraKeyspaceConnection", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // cassandraColumnFamilies(
        //     first: Int
        //     after: String
        //     sortBy: HierarchySortByField
        //     sortOrder: SortOrder
        //     filter: [Filter!]
        //   ): CassandraColumnFamilyConnection!
        protected void InvokeQueryCassandraColumnFamilies()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("sortBy", "HierarchySortByField"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("filter", "[Filter!]"),
            };
            CassandraColumnFamilyConnection? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (CassandraColumnFamilyConnection)psObject.BaseObject;
                } else {
                    fields = (CassandraColumnFamilyConnection)this.Field;
                }
            }
            string document = Query.CassandraColumnFamilies(ref fields);
            this._input.Initialize(argDefs, fields, "Query.CassandraColumnFamilies");
            var parameters = "($first: Int,$after: String,$sortBy: HierarchySortByField,$sortOrder: SortOrder,$filter: [Filter!])\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryCassandraColumnFamilies" + parameters + "{" + document + "}",
                OperationName = "QueryCassandraColumnFamilies",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "CassandraColumnFamilyConnection", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // cassandraColumnFamilyRecoverableRange(input: GetMosaicRecoverableRangeInput!): GetMosaicRecoverableRangeResponse!
        protected void InvokeQueryCassandraColumnFamilyRecoverableRange()
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
            string document = Query.CassandraColumnFamilyRecoverableRange(ref fields);
            this._input.Initialize(argDefs, fields, "Query.CassandraColumnFamilyRecoverableRange");
            var parameters = "($input: GetMosaicRecoverableRangeInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryCassandraColumnFamilyRecoverableRange" + parameters + "{" + document + "}",
                OperationName = "QueryCassandraColumnFamilyRecoverableRange",
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
        // cassandraColumnFamilySchema(input: GetMosaicTableSchemaInput!): GetSchemaResponse!
        protected void InvokeQueryCassandraColumnFamilySchema()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetMosaicTableSchemaInput!"),
            };
            GetSchemaResponse? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (GetSchemaResponse)psObject.BaseObject;
                } else {
                    fields = (GetSchemaResponse)this.Field;
                }
            }
            string document = Query.CassandraColumnFamilySchema(ref fields);
            this._input.Initialize(argDefs, fields, "Query.CassandraColumnFamilySchema");
            var parameters = "($input: GetMosaicTableSchemaInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryCassandraColumnFamilySchema" + parameters + "{" + document + "}",
                OperationName = "QueryCassandraColumnFamilySchema",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "GetSchemaResponse", this._logger, GetMetricTags());
            WriteObject(result, true);
        }


    } // class Invoke_RscQueryCassandra
}