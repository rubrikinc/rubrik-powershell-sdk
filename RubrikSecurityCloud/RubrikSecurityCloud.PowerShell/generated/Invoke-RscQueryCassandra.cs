// Invoke-RscQueryCassandra.cs
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
        "RscQueryCassandra",
        DefaultParameterSetName = "Source")
    ]
    public class Invoke_RscQueryCassandra : RscPSCmdlet
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
            // Invoke graphql operation cassandraSources
            InvokeQueryCassandraSources();
        }

        // This parameter set invokes a single graphql operation:
        // cassandraKeyspaces.
        internal void ProcessRecord_Keyspaces()
        {
            this._logger.name += " -Keyspaces";
            // Invoke graphql operation cassandraKeyspaces
            InvokeQueryCassandraKeyspaces();
        }

        // This parameter set invokes a single graphql operation:
        // cassandraColumnFamilies.
        internal void ProcessRecord_ColumnFamilies()
        {
            this._logger.name += " -ColumnFamilies";
            // Invoke graphql operation cassandraColumnFamilies
            InvokeQueryCassandraColumnFamilies();
        }

        // This parameter set invokes a single graphql operation:
        // cassandraColumnFamilyRecoverableRange.
        internal void ProcessRecord_ColumnFamilyRecoverableRange()
        {
            this._logger.name += " -ColumnFamilyRecoverableRange";
            // Invoke graphql operation cassandraColumnFamilyRecoverableRange
            InvokeQueryCassandraColumnFamilyRecoverableRange();
        }

        // This parameter set invokes a single graphql operation:
        // cassandraColumnFamilySchema.
        internal void ProcessRecord_ColumnFamilySchema()
        {
            this._logger.name += " -ColumnFamilySchema";
            // Invoke graphql operation cassandraColumnFamilySchema
            InvokeQueryCassandraColumnFamilySchema();
        }

        // This parameter set invokes a single graphql operation:
        // cassandraSource.
        internal void ProcessRecord_Source()
        {
            this._logger.name += " -Source";
            // Invoke graphql operation cassandraSource
            InvokeQueryCassandraSource();
        }

        // This parameter set invokes a single graphql operation:
        // cassandraKeyspace.
        internal void ProcessRecord_Keyspace()
        {
            this._logger.name += " -Keyspace";
            // Invoke graphql operation cassandraKeyspace
            InvokeQueryCassandraKeyspace();
        }

        // This parameter set invokes a single graphql operation:
        // cassandraColumnFamily.
        internal void ProcessRecord_ColumnFamily()
        {
            this._logger.name += " -ColumnFamily";
            // Invoke graphql operation cassandraColumnFamily
            InvokeQueryCassandraColumnFamily();
        }


        // Invoke GraphQL Query:
        // cassandraSources(
        //     first: Int
        //     after: String
        //     sortBy: HierarchySortByField
        //     sortOrder: SortOrder
        //     filter: [Filter!]
        //   ): CassandraSourceConnection!
        internal void InvokeQueryCassandraSources()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("sortBy", "HierarchySortByField"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("filter", "[Filter!]"),
            };
            CassandraSourceConnection? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (CassandraSourceConnection)psObject.BaseObject;
                } else {
                    fieldSpecObj = (CassandraSourceConnection)this.Field;
                }
            }
            string fieldSpecDoc = Query.CassandraSources(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryCassandraSources",
                "($first: Int,$after: String,$sortBy: HierarchySortByField,$sortOrder: SortOrder,$filter: [Filter!])",
                fieldSpecDoc,
                "CassandraSourceConnection"
            );
        }

        // Invoke GraphQL Query:
        // cassandraKeyspaces(
        //     first: Int
        //     after: String
        //     sortBy: HierarchySortByField
        //     sortOrder: SortOrder
        //     filter: [Filter!]
        //   ): CassandraKeyspaceConnection!
        internal void InvokeQueryCassandraKeyspaces()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("sortBy", "HierarchySortByField"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("filter", "[Filter!]"),
            };
            CassandraKeyspaceConnection? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (CassandraKeyspaceConnection)psObject.BaseObject;
                } else {
                    fieldSpecObj = (CassandraKeyspaceConnection)this.Field;
                }
            }
            string fieldSpecDoc = Query.CassandraKeyspaces(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryCassandraKeyspaces",
                "($first: Int,$after: String,$sortBy: HierarchySortByField,$sortOrder: SortOrder,$filter: [Filter!])",
                fieldSpecDoc,
                "CassandraKeyspaceConnection"
            );
        }

        // Invoke GraphQL Query:
        // cassandraColumnFamilies(
        //     first: Int
        //     after: String
        //     sortBy: HierarchySortByField
        //     sortOrder: SortOrder
        //     filter: [Filter!]
        //   ): CassandraColumnFamilyConnection!
        internal void InvokeQueryCassandraColumnFamilies()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("sortBy", "HierarchySortByField"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("filter", "[Filter!]"),
            };
            CassandraColumnFamilyConnection? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (CassandraColumnFamilyConnection)psObject.BaseObject;
                } else {
                    fieldSpecObj = (CassandraColumnFamilyConnection)this.Field;
                }
            }
            string fieldSpecDoc = Query.CassandraColumnFamilies(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryCassandraColumnFamilies",
                "($first: Int,$after: String,$sortBy: HierarchySortByField,$sortOrder: SortOrder,$filter: [Filter!])",
                fieldSpecDoc,
                "CassandraColumnFamilyConnection"
            );
        }

        // Invoke GraphQL Query:
        // cassandraColumnFamilyRecoverableRange(input: GetMosaicRecoverableRangeInput!): GetMosaicRecoverableRangeResponse!
        internal void InvokeQueryCassandraColumnFamilyRecoverableRange()
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
            string fieldSpecDoc = Query.CassandraColumnFamilyRecoverableRange(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryCassandraColumnFamilyRecoverableRange",
                "($input: GetMosaicRecoverableRangeInput!)",
                fieldSpecDoc,
                "GetMosaicRecoverableRangeResponse"
            );
        }

        // Invoke GraphQL Query:
        // cassandraColumnFamilySchema(input: GetMosaicTableSchemaInput!): GetSchemaResponse!
        internal void InvokeQueryCassandraColumnFamilySchema()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetMosaicTableSchemaInput!"),
            };
            GetSchemaResponse? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (GetSchemaResponse)psObject.BaseObject;
                } else {
                    fieldSpecObj = (GetSchemaResponse)this.Field;
                }
            }
            string fieldSpecDoc = Query.CassandraColumnFamilySchema(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryCassandraColumnFamilySchema",
                "($input: GetMosaicTableSchemaInput!)",
                fieldSpecDoc,
                "GetSchemaResponse"
            );
        }

        // Invoke GraphQL Query:
        // cassandraSource(fid: UUID!): CassandraSource!
        internal void InvokeQueryCassandraSource()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            CassandraSource? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (CassandraSource)psObject.BaseObject;
                } else {
                    fieldSpecObj = (CassandraSource)this.Field;
                }
            }
            string fieldSpecDoc = Query.CassandraSource(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryCassandraSource",
                "($fid: UUID!)",
                fieldSpecDoc,
                "CassandraSource"
            );
        }

        // Invoke GraphQL Query:
        // cassandraKeyspace(fid: UUID!): CassandraKeyspace!
        internal void InvokeQueryCassandraKeyspace()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            CassandraKeyspace? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (CassandraKeyspace)psObject.BaseObject;
                } else {
                    fieldSpecObj = (CassandraKeyspace)this.Field;
                }
            }
            string fieldSpecDoc = Query.CassandraKeyspace(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryCassandraKeyspace",
                "($fid: UUID!)",
                fieldSpecDoc,
                "CassandraKeyspace"
            );
        }

        // Invoke GraphQL Query:
        // cassandraColumnFamily(fid: UUID!): CassandraColumnFamily!
        internal void InvokeQueryCassandraColumnFamily()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            CassandraColumnFamily? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (CassandraColumnFamily)psObject.BaseObject;
                } else {
                    fieldSpecObj = (CassandraColumnFamily)this.Field;
                }
            }
            string fieldSpecDoc = Query.CassandraColumnFamily(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryCassandraColumnFamily",
                "($fid: UUID!)",
                fieldSpecDoc,
                "CassandraColumnFamily"
            );
        }


    } // class Invoke_RscQueryCassandra
}