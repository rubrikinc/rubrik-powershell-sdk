// Invoke-RscQueryActivitySeries.cs
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
using Rubrik.SecurityCloud.NetSDK.Library.HelperClasses;
using Rubrik.SecurityCloud.Operations;
using GraphQL;

namespace Rubrik.SecurityCloud.PowerShell.Cmdlets
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
        // GraphQL operation: activitySeries(input: ActivitySeriesInput!):ActivitySeries!
        //
        [Parameter(
            ParameterSetName = "ActivitySeries",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: activitySeries(input: ActivitySeriesInput!):ActivitySeries!",
            Position = 0
        )]
        public SwitchParameter ActivitySeries { get; set; }

        [Parameter(
            ParameterSetName = "ActivitySeries",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument input: ActivitySeriesInput!"
        )]
        public ActivitySeriesInput? Input { get; set; }
        
        // -------------------------------------------------------------------
        // List parameter set
        //
        // GraphQL operation: activitySeriesConnection(,   first: Int,   after: String,   last: Int,   before: String,   sortOrder: SortOrder,   sortBy: ActivitySeriesSortField,   filters: ActivitySeriesFilter, ):ActivitySeriesConnection!
        //
        [Parameter(
            ParameterSetName = "List",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: activitySeriesConnection(,   first: Int,   after: String,   last: Int,   before: String,   sortOrder: SortOrder,   sortBy: ActivitySeriesSortField,   filters: ActivitySeriesFilter, ):ActivitySeriesConnection!",
            Position = 0
        )]
        public SwitchParameter List { get; set; }

        [Parameter(
            ParameterSetName = "List",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument first: Int"
        )]
        public System.Int32? First { get; set; }
        [Parameter(
            ParameterSetName = "List",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument after: String"
        )]
        public System.String? After { get; set; }
        [Parameter(
            ParameterSetName = "List",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument last: Int"
        )]
        public System.Int32? Last { get; set; }
        [Parameter(
            ParameterSetName = "List",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument before: String"
        )]
        public System.String? Before { get; set; }
        [Parameter(
            ParameterSetName = "List",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument sortOrder: SortOrder"
        )]
        public SortOrder? SortOrder { get; set; }
        [Parameter(
            ParameterSetName = "List",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument sortBy: ActivitySeriesSortField"
        )]
        public ActivitySeriesSortField? SortBy { get; set; }
        [Parameter(
            ParameterSetName = "List",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument filters: ActivitySeriesFilter"
        )]
        public ActivitySeriesFilter? Filters { get; set; }

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
                    default:
                        throw new Exception("Unknown Operation " + Op);
                }
           }
           catch (Exception ex)
           {
                this._logger.Flush();
                var error = new ErrorRecord(
                    ex,
                    "Invoke-RscQueryActivitySeries",
                    ErrorCategory.InvalidOperation,
                    null);
                ThrowTerminatingError(error);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (ActivitySeries)psObject.BaseObject;
                } else {
                    fields = (ActivitySeries)this.Field;
                }
            }
            string document = Query.ActivitySeries(ref fields);
            this._input.Initialize(argDefs, fields, "Query.ActivitySeries");
            string parameters = "($input: ActivitySeriesInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryActivitySeries" + parameters + "{" + document + "}",
                OperationName = "QueryActivitySeries",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<ActivitySeries> task = this._rbkClient.InvokeGenericCallAsync<ActivitySeries>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (ActivitySeriesConnection)psObject.BaseObject;
                } else {
                    fields = (ActivitySeriesConnection)this.Field;
                }
            }
            string document = Query.ActivitySeriesConnection(ref fields);
            this._input.Initialize(argDefs, fields, "Query.ActivitySeriesConnection");
            string parameters = "($first: Int,$after: String,$last: Int,$before: String,$sortOrder: SortOrder,$sortBy: ActivitySeriesSortField,$filters: ActivitySeriesFilter)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryActivitySeriesConnection" + parameters + "{" + document + "}",
                OperationName = "QueryActivitySeriesConnection",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<ActivitySeriesConnection> task = this._rbkClient.InvokeGenericCallAsync<ActivitySeriesConnection>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }


    } // class Invoke_RscQueryActivitySeries
}