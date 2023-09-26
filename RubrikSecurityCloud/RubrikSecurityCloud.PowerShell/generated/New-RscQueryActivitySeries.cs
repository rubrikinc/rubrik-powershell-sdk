// New-RscQueryActivitySeries.cs
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

// ignore warning 'Missing XML comment'
#pragma warning disable 1591

namespace RubrikSecurityCloud.PowerShell.Cmdlets
{
    /// <summary>
    /// Create a new RscQuery object for any of the 2
    /// operations in the 'Activity series' API domain:
    /// ActivitySeries, or List.
    /// </summary>
    /// <description>
    /// New-RscQueryActivitySeries creates a new
    /// query object for operations
    /// in the 'Activity series' API domain. It only creates a data structure,
    /// it does not execute the operation. This cmdlet does not need a
    /// connection to run. To execute the operation, either call Invoke()
    /// on the object returned by this cmdlet, or pass the object to
    /// Invoke-Rsc.
    /// There are 2 operations
    /// in the 'Activity series' API domain. Select the operation this
    /// query is for by specifying the appropriate switch parameter;
    /// one of: -ActivitySeries, -List.
    /// Alternatively, you can specify the operation by setting the
    /// -Op parameter, for example: -Op ActivitySeries,
    /// which is equivalent to specifying -ActivitySeries.
    /// Each operation has its own set of variables that can be set with
    /// the -Var parameter. For more info about the variables, 
    /// call Info() on the object returned by this cmdlet, for example:
    /// (New-RscQueryActivitySeries -ActivitySeries).Info().
    /// Each operation also has its own set of fields that can be
    /// selected for retrieval. If you do not specify any fields,
    /// a set of default fields will be selected. The selection is
    /// rule-based, and tries to select the most commonly used fields.
    /// For example if a field is named 'id' or 'name', 
    /// it will be selected. If you give -FieldProfile DETAIL, then
    /// another set of rules will be used to select more fields on top
    /// of the default fields. The set of rules for selecting fields
    /// is called a field profile. You can specify a field profile
    /// with the -FieldProfile parameter. You can add or remove fields
    /// from the field profile with the -AddField and -RemoveField
    /// parameters. If you end up with too many -AddField and -RemoveField
    /// parameters, you can list them in a text file, one per line,
    /// with a '+' or '-' prefix, and pass the file name to the
    /// -FilePatch parameter. Profiles and Patches are one way to
    /// customize the fields that are selected. Another way is to
    /// specify the fields by passing the -Field parameter an object
    /// that contains the fields you want to select as properties.
    /// Any property that is not null in that object is interpreted
    /// as a field to select
    /// (and the actual values they are set to do not matter).
    /// The [RubrikSecurityCloud.Types] namespace
    /// contains a set of classes that you can use to specify fields.
    /// To know what [RubrikSecurityCloud.Types] object to use
    /// for a specific operation,
    /// call Info() on the object returned by this cmdlet, for example:
    /// (New-RscQueryActivitySeries -ActivitySeries).Info().
    /// You can combine a -Field parameter with patching parameters.
    /// -Field is applied first, then -FilePatch, -AddField and -RemoveField.
    ///
    /// </description>
    ///
    /// <example>
    /// Runs the ActivitySeries operation
    /// of the 'Activity series' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Activity series
    /// # API Operation: ActivitySeries
    /// 
    /// $query = New-RscQueryActivitySeries -ActivitySeries
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	activitySeriesId = $someString
    /// 	# OPTIONAL
    /// 	clusterUuid = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: ActivitySeries
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the List operation
    /// of the 'Activity series' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Activity series
    /// # API Operation: List
    /// 
    /// $query = New-RscQueryActivitySeries -List
    /// 
    /// # OPTIONAL
    /// $query.Var.first = $someInt
    /// # OPTIONAL
    /// $query.Var.after = $someString
    /// # OPTIONAL
    /// $query.Var.last = $someInt
    /// # OPTIONAL
    /// $query.Var.before = $someString
    /// # OPTIONAL
    /// $query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
    /// # OPTIONAL
    /// $query.Var.sortBy = $someActivitySeriesSortField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ActivitySeriesSortField]) for enum values.
    /// # OPTIONAL
    /// $query.Var.filters = @{
    /// 	# OPTIONAL
    /// 	lastActivityStatus = @(
    /// 		$someEventStatus # Call [Enum]::GetValues([RubrikSecurityCloud.Types.EventStatus]) for enum values.
    /// 	)
    /// 	# OPTIONAL
    /// 	lastActivityType = @(
    /// 		$someEventType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.EventType]) for enum values.
    /// 	)
    /// 	# OPTIONAL
    /// 	severity = @(
    /// 		$someEventSeverity # Call [Enum]::GetValues([RubrikSecurityCloud.Types.EventSeverity]) for enum values.
    /// 	)
    /// 	# OPTIONAL
    /// 	objectName = $someString
    /// 	# OPTIONAL
    /// 	objectType = @(
    /// 		$someEventObjectType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.EventObjectType]) for enum values.
    /// 	)
    /// 	# OPTIONAL
    /// 	startTimeGt = $someDateTime
    /// 	# OPTIONAL
    /// 	startTimeLt = $someDateTime
    /// 	# OPTIONAL
    /// 	lastUpdatedTimeGt = $someDateTime
    /// 	# OPTIONAL
    /// 	lastUpdatedTimeLt = $someDateTime
    /// 	# OPTIONAL
    /// 	clusterId = @(
    /// 		$someString
    /// 	)
    /// 	# OPTIONAL
    /// 	clusterType = @(
    /// 		$someEventClusterType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.EventClusterType]) for enum values.
    /// 	)
    /// 	# OPTIONAL
    /// 	objectFid = @(
    /// 		$someString
    /// 	)
    /// 	# OPTIONAL
    /// 	ancestorId = $someString
    /// 	# OPTIONAL
    /// 	searchTerm = $someString
    /// 	# OPTIONAL
    /// 	orgIds = @(
    /// 		$someString
    /// 	)
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: ActivitySeriesConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscQueryActivitySeries",
        DefaultParameterSetName = "ActivitySeries")
    ]
    public class New_RscQueryActivitySeries : RscGqlPSCmdlet
    {
        
        [Parameter(
            ParameterSetName = "ActivitySeries",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a query object for the 'ActivitySeries' operation
in the 'Activity series' API domain.
Description of the operation:
Retrieve an activity series.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/activityseries.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter ActivitySeries { get; set; }

        
        [Parameter(
            ParameterSetName = "List",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a query object for the 'List' operation
in the 'Activity series' API domain.
Description of the operation:

[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/activityseriesconnection.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter List { get; set; }



        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                switch(this.GetOp().OpName())
                {
                    case "ActivitySeries":
                        this.ProcessRecord_ActivitySeries();
                        break;
                    case "List":
                        this.ProcessRecord_List();
                        break;
                    default:
                        throw new Exception("Unknown Operation " + this.GetOp().OpName());
                }
           }
           catch (Exception ex)
           {
                ThrowTerminatingException(ex);
           }
        }

        // This parameter set invokes a single graphql operation:
        // activitySeries.
        internal void ProcessRecord_ActivitySeries()
        {
            this._logger.name += " -ActivitySeries";
            // Create new graphql operation activitySeries
            InitQueryActivitySeries();
        }

        // This parameter set invokes a single graphql operation:
        // activitySeriesConnection.
        internal void ProcessRecord_List()
        {
            this._logger.name += " -List";
            // Create new graphql operation activitySeriesConnection
            InitQueryActivitySeriesConnection();
        }


        // Create new GraphQL Query:
        // activitySeries(input: ActivitySeriesInput!): ActivitySeries!
        internal void InitQueryActivitySeries()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "ActivitySeriesInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryActivitySeries",
                "($input: ActivitySeriesInput!)",
                "ActivitySeries",
                Query.ActivitySeries_ObjectFieldSpec,
                Query.ActivitySeriesFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	activitySeriesId = $someString
	# OPTIONAL
	clusterUuid = $someString
}"
            );
        }

        // Create new GraphQL Query:
        // activitySeriesConnection(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     sortOrder: SortOrder
        //     sortBy: ActivitySeriesSortField
        //     filters: ActivitySeriesFilter
        //   ): ActivitySeriesConnection!
        internal void InitQueryActivitySeriesConnection()
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
                "ActivitySeriesConnection",
                Query.ActivitySeriesConnection_ObjectFieldSpec,
                Query.ActivitySeriesConnectionFieldSpec,
                @"# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# OPTIONAL
$query.Var.last = $someInt
# OPTIONAL
$query.Var.before = $someString
# OPTIONAL
$query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$query.Var.sortBy = $someActivitySeriesSortField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ActivitySeriesSortField]) for enum values.
# OPTIONAL
$query.Var.filters = @{
	# OPTIONAL
	lastActivityStatus = @(
		$someEventStatus # Call [Enum]::GetValues([RubrikSecurityCloud.Types.EventStatus]) for enum values.
	)
	# OPTIONAL
	lastActivityType = @(
		$someEventType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.EventType]) for enum values.
	)
	# OPTIONAL
	severity = @(
		$someEventSeverity # Call [Enum]::GetValues([RubrikSecurityCloud.Types.EventSeverity]) for enum values.
	)
	# OPTIONAL
	objectName = $someString
	# OPTIONAL
	objectType = @(
		$someEventObjectType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.EventObjectType]) for enum values.
	)
	# OPTIONAL
	startTimeGt = $someDateTime
	# OPTIONAL
	startTimeLt = $someDateTime
	# OPTIONAL
	lastUpdatedTimeGt = $someDateTime
	# OPTIONAL
	lastUpdatedTimeLt = $someDateTime
	# OPTIONAL
	clusterId = @(
		$someString
	)
	# OPTIONAL
	clusterType = @(
		$someEventClusterType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.EventClusterType]) for enum values.
	)
	# OPTIONAL
	objectFid = @(
		$someString
	)
	# OPTIONAL
	ancestorId = $someString
	# OPTIONAL
	searchTerm = $someString
	# OPTIONAL
	orgIds = @(
		$someString
	)
}"
            );
        }


    } // class New_RscQueryActivitySeries
}