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
    [Cmdlet(
        "Invoke",
        "RscQueryActivitySeries",
        DefaultParameterSetName = "ActivitySeries")
    ]
    public class Invoke_RscQueryActivitySeries : RscPSCmdlet
    {
        
        // -------------------------------------------------------------------
        // ActivitySeries parameter set
        //
        // [GraphQL: activitySeries]
        //
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

        
        // -------------------------------------------------------------------
        // List parameter set
        //
        // [GraphQL: activitySeriesConnection]
        //
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

        
        // -------------------------------------------------------------------
        // GroupByList parameter set
        //
        // [GraphQL: activitySeriesGroupByConnection]
        //
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

        // This parameter set invokes a single graphql operation:
        // activitySeries.
        protected void ProcessRecord_ActivitySeries()
        {
            this._logger.name += " -ActivitySeries";
            // Invoke graphql operation activitySeries
            InvokeQueryActivitySeries();
        }

        // This parameter set invokes a single graphql operation:
        // activitySeriesConnection.
        protected void ProcessRecord_List()
        {
            this._logger.name += " -List";
            // Invoke graphql operation activitySeriesConnection
            InvokeQueryActivitySeriesConnection();
        }

        // This parameter set invokes a single graphql operation:
        // activitySeriesGroupByConnection.
        protected void ProcessRecord_GroupByList()
        {
            this._logger.name += " -GroupByList";
            // Invoke graphql operation activitySeriesGroupByConnection
            InvokeQueryActivitySeriesGroupByConnection();
        }


        // Invoke GraphQL Query:
        // activitySeries(input: ActivitySeriesInput!): ActivitySeries!
        protected void InvokeQueryActivitySeries()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "ActivitySeriesInput!"),
            };
            ActivitySeries? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (ActivitySeries)psObject.BaseObject;
                } else {
                    fieldSpecObj = (ActivitySeries)this.Field;
                }
            }
            string fieldSpecDoc = Query.ActivitySeries(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryActivitySeries",
                "($input: ActivitySeriesInput!)",
                fieldSpecDoc,
                "ActivitySeries"
            );
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
        protected void InvokeQueryActivitySeriesConnection()
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
            ActivitySeriesConnection? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (ActivitySeriesConnection)psObject.BaseObject;
                } else {
                    fieldSpecObj = (ActivitySeriesConnection)this.Field;
                }
            }
            string fieldSpecDoc = Query.ActivitySeriesConnection(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryActivitySeriesConnection",
                "($first: Int,$after: String,$last: Int,$before: String,$sortOrder: SortOrder,$sortBy: ActivitySeriesSortField,$filters: ActivitySeriesFilter)",
                fieldSpecDoc,
                "ActivitySeriesConnection"
            );
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
        protected void InvokeQueryActivitySeriesGroupByConnection()
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
            ActivitySeriesGroupByConnection? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (ActivitySeriesGroupByConnection)psObject.BaseObject;
                } else {
                    fieldSpecObj = (ActivitySeriesGroupByConnection)this.Field;
                }
            }
            string fieldSpecDoc = Query.ActivitySeriesGroupByConnection(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryActivitySeriesGroupByConnection",
                "($first: Int,$after: String,$last: Int,$before: String,$groupBy: ActivitySeriesGroupByEnum!,$filters: ActivitySeriesFilterInput,$timezoneOffset: Float)",
                fieldSpecDoc,
                "ActivitySeriesGroupByConnection"
            );
        }


    } // class Invoke_RscQueryActivitySeries
}