// Invoke-RscQueryDb2.cs
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
    /// Db2 queries
    /// </summary>
    /// <description>
    /// Invoke-RscQueryDb2 is a master cmdlet for Db2 work that can invoke any of the following subcommands: Instances, Instance, Database, Databases, RecoverableRange, RecoverableRanges, LogSnapshot, LogSnapshots.
    /// </description>
    /// <example>
    /// <code>Invoke-RscQueryDb2 -Instances [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscQueryDb2 -Instance [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscQueryDb2 -Database [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscQueryDb2 -Databases [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscQueryDb2 -RecoverableRange [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscQueryDb2 -RecoverableRanges [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscQueryDb2 -LogSnapshot [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscQueryDb2 -LogSnapshots [-Arg ..] [-Field ..]</code>
    /// </example>
    [Cmdlet(
        "Invoke",
        "RscQueryDb2",
        DefaultParameterSetName = "Instances")
    ]
    public class Invoke_RscQueryDb2 : RscPSCmdlet
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
            // Invoke graphql operation db2Instances
            InvokeQueryDb2Instances();
        }

        // This parameter set invokes a single graphql operation:
        // db2Instance.
        internal void ProcessRecord_Instance()
        {
            this._logger.name += " -Instance";
            // Invoke graphql operation db2Instance
            InvokeQueryDb2Instance();
        }

        // This parameter set invokes a single graphql operation:
        // db2Database.
        internal void ProcessRecord_Database()
        {
            this._logger.name += " -Database";
            // Invoke graphql operation db2Database
            InvokeQueryDb2Database();
        }

        // This parameter set invokes a single graphql operation:
        // db2Databases.
        internal void ProcessRecord_Databases()
        {
            this._logger.name += " -Databases";
            // Invoke graphql operation db2Databases
            InvokeQueryDb2Databases();
        }

        // This parameter set invokes a single graphql operation:
        // db2RecoverableRange.
        internal void ProcessRecord_RecoverableRange()
        {
            this._logger.name += " -RecoverableRange";
            // Invoke graphql operation db2RecoverableRange
            InvokeQueryDb2RecoverableRange();
        }

        // This parameter set invokes a single graphql operation:
        // db2RecoverableRanges.
        internal void ProcessRecord_RecoverableRanges()
        {
            this._logger.name += " -RecoverableRanges";
            // Invoke graphql operation db2RecoverableRanges
            InvokeQueryDb2RecoverableRanges();
        }

        // This parameter set invokes a single graphql operation:
        // db2LogSnapshot.
        internal void ProcessRecord_LogSnapshot()
        {
            this._logger.name += " -LogSnapshot";
            // Invoke graphql operation db2LogSnapshot
            InvokeQueryDb2LogSnapshot();
        }

        // This parameter set invokes a single graphql operation:
        // db2LogSnapshots.
        internal void ProcessRecord_LogSnapshots()
        {
            this._logger.name += " -LogSnapshots";
            // Invoke graphql operation db2LogSnapshots
            InvokeQueryDb2LogSnapshots();
        }


        // Invoke GraphQL Query:
        // db2Instances(
        //     first: Int
        //     after: String
        //     sortBy: HierarchySortByField
        //     sortOrder: SortOrder
        //     filter: [Filter!]
        //   ): Db2InstanceConnection!
        internal void InvokeQueryDb2Instances()
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
                "Db2InstanceConnection"
                );
            Db2InstanceConnection? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (Db2InstanceConnection)this.Field;
            }
            string fieldSpecDoc = Query.Db2Instances(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Query:
        // db2Instance(id: UUID!): Db2Instance!
        internal void InvokeQueryDb2Instance()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("id", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryDb2Instance",
                "($id: UUID!)",
                "Db2Instance"
                );
            Db2Instance? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (Db2Instance)this.Field;
            }
            string fieldSpecDoc = Query.Db2Instance(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Query:
        // db2Database(fid: UUID!): Db2Database!
        internal void InvokeQueryDb2Database()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryDb2Database",
                "($fid: UUID!)",
                "Db2Database"
                );
            Db2Database? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (Db2Database)this.Field;
            }
            string fieldSpecDoc = Query.Db2Database(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Query:
        // db2Databases(
        //     first: Int
        //     after: String
        //     sortBy: HierarchySortByField
        //     sortOrder: SortOrder
        //     filter: [Filter!]
        //   ): Db2DatabaseConnection!
        internal void InvokeQueryDb2Databases()
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
                "Db2DatabaseConnection"
                );
            Db2DatabaseConnection? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (Db2DatabaseConnection)this.Field;
            }
            string fieldSpecDoc = Query.Db2Databases(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Query:
        // db2RecoverableRange(db2RecoverableRangeFid: UUID!): Db2RecoverableRange!
        internal void InvokeQueryDb2RecoverableRange()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("db2RecoverableRangeFid", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryDb2RecoverableRange",
                "($db2RecoverableRangeFid: UUID!)",
                "Db2RecoverableRange"
                );
            Db2RecoverableRange? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (Db2RecoverableRange)this.Field;
            }
            string fieldSpecDoc = Query.Db2RecoverableRange(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Query:
        // db2RecoverableRanges(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     sortOrder: SortOrder
        //     sortBy: Db2RecoverableRangeSortBy
        //     filter: Db2RecoverableRangeFilterInput
        //   ): Db2RecoverableRangeConnection!
        internal void InvokeQueryDb2RecoverableRanges()
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
                "Db2RecoverableRangeConnection"
                );
            Db2RecoverableRangeConnection? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (Db2RecoverableRangeConnection)this.Field;
            }
            string fieldSpecDoc = Query.Db2RecoverableRanges(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Query:
        // db2LogSnapshot(db2LogSnapshotFid: UUID!): Db2LogSnapshot!
        internal void InvokeQueryDb2LogSnapshot()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("db2LogSnapshotFid", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryDb2LogSnapshot",
                "($db2LogSnapshotFid: UUID!)",
                "Db2LogSnapshot"
                );
            Db2LogSnapshot? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (Db2LogSnapshot)this.Field;
            }
            string fieldSpecDoc = Query.Db2LogSnapshot(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Query:
        // db2LogSnapshots(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     sortOrder: SortOrder
        //     sortBy: Db2LogSnapshotSortBy
        //     filter: Db2LogSnapshotFilterInput
        //   ): Db2LogSnapshotConnection!
        internal void InvokeQueryDb2LogSnapshots()
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
                "Db2LogSnapshotConnection"
                );
            Db2LogSnapshotConnection? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (Db2LogSnapshotConnection)this.Field;
            }
            string fieldSpecDoc = Query.Db2LogSnapshots(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
        }


    } // class Invoke_RscQueryDb2
}