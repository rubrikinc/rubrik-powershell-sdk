// Invoke-RscQueryActivitySeries.cs
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
    /// Activity series queries
    /// </summary>
    /// <description>
    /// Invoke-RscQueryActivitySeries is a master cmdlet for ActivitySeries work that can invoke any of the following subcommands: ActivitySeries, List, GroupByList.
    /// </description>
    /// <example>
    /// <code>Invoke-RscQueryActivitySeries -ActivitySeries [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscQueryActivitySeries -List [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscQueryActivitySeries -GroupByList [-Arg ..] [-Field ..]</code>
    /// </example>
    [Cmdlet(
        "Invoke",
        "RscQueryActivitySeries",
        DefaultParameterSetName = "ActivitySeries")
    ]
    public class Invoke_RscQueryActivitySeries : RscPSCmdlet
    {
        
        /// <summary>
        /// ActivitySeries parameter set
        ///
        /// [GraphQL: activitySeries]
        /// </summary>
        [Parameter(
            ParameterSetName = "ActivitySeries",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Retrieve an activity series.
[GraphQL: activitySeries]",
            Position = 0
        )]
        public SwitchParameter ActivitySeries { get; set; }

        
        /// <summary>
        /// List parameter set
        ///
        /// [GraphQL: activitySeriesConnection]
        /// </summary>
        [Parameter(
            ParameterSetName = "List",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"
[GraphQL: activitySeriesConnection]",
            Position = 0
        )]
        public SwitchParameter List { get; set; }

        
        /// <summary>
        /// GroupByList parameter set
        ///
        /// [GraphQL: activitySeriesGroupByConnection]
        /// </summary>
        [Parameter(
            ParameterSetName = "GroupByList",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"
[GraphQL: activitySeriesGroupByConnection]",
            Position = 0
        )]
        public SwitchParameter GroupByList { get; set; }


// ignore warning 'Missing XML comment'
#pragma warning disable 1591
        protected override void ProcessRecord()
        {
            try
            {
                switch(Op)
                {
                    case "ActivitySeries":
                        this.ProcessRecord_ActivitySeries();
                        break;
                    case "List":
                        this.ProcessRecord_List();
                        break;
                    case "GroupByList":
                        this.ProcessRecord_GroupByList();
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
        // activitySeries.
        internal void ProcessRecord_ActivitySeries()
        {
            this._logger.name += " -ActivitySeries";
            // Invoke graphql operation activitySeries
            InvokeQueryActivitySeries();
        }

        // This parameter set invokes a single graphql operation:
        // activitySeriesConnection.
        internal void ProcessRecord_List()
        {
            this._logger.name += " -List";
            // Invoke graphql operation activitySeriesConnection
            InvokeQueryActivitySeriesConnection();
        }

        // This parameter set invokes a single graphql operation:
        // activitySeriesGroupByConnection.
        internal void ProcessRecord_GroupByList()
        {
            this._logger.name += " -GroupByList";
            // Invoke graphql operation activitySeriesGroupByConnection
            InvokeQueryActivitySeriesGroupByConnection();
        }


        // Invoke GraphQL Query:
        // activitySeries(input: ActivitySeriesInput!): ActivitySeries!
        internal void InvokeQueryActivitySeries()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "ActivitySeriesInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryActivitySeries",
                "($input: ActivitySeriesInput!)",
                "ActivitySeries"
                );
            ActivitySeries? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (ActivitySeries)this.Field;
            }
            string fieldSpecDoc = Query.ActivitySeries(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Query:
        // activitySeriesConnection(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     sortOrder: SortOrder
        //     sortBy: ActivitySeriesSortField
        //     filters: ActivitySeriesFilter
        //   ): ActivitySeriesConnection!
        internal void InvokeQueryActivitySeriesConnection()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("sortBy", "ActivitySeriesSortField"),
                Tuple.Create("filters", "ActivitySeriesFilter"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryActivitySeriesConnection",
                "($first: Int,$after: String,$last: Int,$before: String,$sortOrder: SortOrder,$sortBy: ActivitySeriesSortField,$filters: ActivitySeriesFilter)",
                "ActivitySeriesConnection"
                );
            ActivitySeriesConnection? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (ActivitySeriesConnection)this.Field;
            }
            string fieldSpecDoc = Query.ActivitySeriesConnection(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Query:
        // activitySeriesGroupByConnection(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     groupBy: ActivitySeriesGroupByEnum!
        //     filters: ActivitySeriesFilterInput
        //     timezoneOffset: Float = 0.0
        //   ): ActivitySeriesGroupByConnection!
        internal void InvokeQueryActivitySeriesGroupByConnection()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("groupBy", "ActivitySeriesGroupByEnum!"),
                Tuple.Create("filters", "ActivitySeriesFilterInput"),
                Tuple.Create("timezoneOffset", "Float"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryActivitySeriesGroupByConnection",
                "($first: Int,$after: String,$last: Int,$before: String,$groupBy: ActivitySeriesGroupByEnum!,$filters: ActivitySeriesFilterInput,$timezoneOffset: Float)",
                "ActivitySeriesGroupByConnection"
                );
            ActivitySeriesGroupByConnection? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (ActivitySeriesGroupByConnection)this.Field;
            }
            string fieldSpecDoc = Query.ActivitySeriesGroupByConnection(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
        }


    } // class Invoke_RscQueryActivitySeries
}