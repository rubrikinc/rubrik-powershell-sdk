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

        [Parameter(
            ParameterSetName = "ActivitySeries",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Input for retrieving an activity series.
GraphQL argument input: ActivitySeriesInput!"
        )]
        public ActivitySeriesInput? Input { get; set; }
        
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

        [Parameter(
            ParameterSetName = "List",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Returns the first n elements from the list.
GraphQL argument first: Int"
        )]
        public System.Int32? First { get; set; }
        [Parameter(
            ParameterSetName = "List",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Returns the elements in the list that come after the specified cursor.
GraphQL argument after: String"
        )]
        public System.String? After { get; set; }
        [Parameter(
            ParameterSetName = "List",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Returns the last n elements from the list.
GraphQL argument last: Int"
        )]
        public System.Int32? Last { get; set; }
        [Parameter(
            ParameterSetName = "List",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Returns the elements in the list that come before the specified cursor.
GraphQL argument before: String"
        )]
        public System.String? Before { get; set; }
        [Parameter(
            ParameterSetName = "List",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Activity sort order
GraphQL argument sortOrder: SortOrder"
        )]
        public SortOrder? SortOrder { get; set; }
        [Parameter(
            ParameterSetName = "List",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Sort activity series by field.
GraphQL argument sortBy: ActivitySeriesSortField"
        )]
        public ActivitySeriesSortField? SortBy { get; set; }
        [Parameter(
            ParameterSetName = "List",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"
GraphQL argument filters: ActivitySeriesFilter"
        )]
        public ActivitySeriesFilter? Filters { get; set; }
        
        // -------------------------------------------------------------------
        // Groupbyconnection parameter set
        //
        // [GraphQL: activitySeriesGroupByConnection]
        //
        [Parameter(
            ParameterSetName = "Groupbyconnection",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"
[GraphQL: activitySeriesGroupByConnection]",
            Position = 0
        )]
        public SwitchParameter Groupbyconnection { get; set; }

        [Parameter(
            ParameterSetName = "Groupbyconnection",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"group activity series by a field
GraphQL argument groupBy: ActivitySeriesGroupByEnum!"
        )]
        public ActivitySeriesGroupByEnum? GroupBy { get; set; }
        [Parameter(
            ParameterSetName = "Groupbyconnection",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Offset based on customer timezone.
GraphQL argument timezoneOffset: Float"
        )]
        public System.Single? TimezoneOffset { get; set; }

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
                    case "Groupbyconnection":
                        this.ProcessRecord_Groupbyconnection();
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
        protected void ProcessRecord_Groupbyconnection()
        {
            this._logger.name += " -Groupbyconnection";
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
            ActivitySeries? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (ActivitySeries)psObject.BaseObject;
                } else {
                    fields = (ActivitySeries)this.Field;
                }
            }
            string document = Query.ActivitySeries(ref fields);
            this._input.Initialize(argDefs, fields, "Query.ActivitySeries");
            var parameters = "($input: ActivitySeriesInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryActivitySeries" + parameters + "{" + document + "}",
                OperationName = "QueryActivitySeries",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "ActivitySeries", this._logger, GetMetricTags());
            WriteObject(result, true);
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
            ActivitySeriesConnection? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (ActivitySeriesConnection)psObject.BaseObject;
                } else {
                    fields = (ActivitySeriesConnection)this.Field;
                }
            }
            string document = Query.ActivitySeriesConnection(ref fields);
            this._input.Initialize(argDefs, fields, "Query.ActivitySeriesConnection");
            var parameters = "($first: Int,$after: String,$last: Int,$before: String,$sortOrder: SortOrder,$sortBy: ActivitySeriesSortField,$filters: ActivitySeriesFilter)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryActivitySeriesConnection" + parameters + "{" + document + "}",
                OperationName = "QueryActivitySeriesConnection",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "ActivitySeriesConnection", this._logger, GetMetricTags());
            WriteObject(result, true);
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
            ActivitySeriesGroupByConnection? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (ActivitySeriesGroupByConnection)psObject.BaseObject;
                } else {
                    fields = (ActivitySeriesGroupByConnection)this.Field;
                }
            }
            string document = Query.ActivitySeriesGroupByConnection(ref fields);
            this._input.Initialize(argDefs, fields, "Query.ActivitySeriesGroupByConnection");
            var parameters = "($first: Int,$after: String,$last: Int,$before: String,$groupBy: ActivitySeriesGroupByEnum!,$filters: ActivitySeriesFilterInput,$timezoneOffset: Float)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryActivitySeriesGroupByConnection" + parameters + "{" + document + "}",
                OperationName = "QueryActivitySeriesGroupByConnection",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "ActivitySeriesGroupByConnection", this._logger, GetMetricTags());
            WriteObject(result, true);
        }


    } // class Invoke_RscQueryActivitySeries
}