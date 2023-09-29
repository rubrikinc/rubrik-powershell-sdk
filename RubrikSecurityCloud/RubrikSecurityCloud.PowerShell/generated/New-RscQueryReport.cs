// New-RscQueryReport.cs
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
    /// operations in the 'Report' API domain:
    /// Data, or Scheduled.
    /// </summary>
    /// <description>
    /// New-RscQueryReport creates a new
    /// query object for operations
    /// in the 'Report' API domain. It only creates a data structure,
    /// it does not execute the operation. This cmdlet does not need a
    /// connection to run. To execute the operation, either call Invoke()
    /// on the object returned by this cmdlet, or pass the object to
    /// Invoke-Rsc.
    /// There are 2 operations
    /// in the 'Report' API domain. Select the operation this
    /// query is for by specifying the appropriate switch parameter;
    /// one of: -Data, -Scheduled.
    /// Alternatively, you can specify the operation by setting the
    /// -Op parameter, for example: -Op Data,
    /// which is equivalent to specifying -Data.
    /// Each operation has its own set of variables that can be set with
    /// the -Var parameter. For more info about the variables, 
    /// call Info() on the object returned by this cmdlet, for example:
    /// (New-RscQueryReport -Data).Info().
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
    /// (New-RscQueryReport -Data).Info().
    /// You can combine a -Field parameter with patching parameters.
    /// -Field is applied first, then -FilePatch, -AddField and -RemoveField.
    ///
    /// </description>
    ///
    /// <example>
    /// Runs the Data operation
    /// of the 'Report' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Report
    /// # API Operation: Data
    /// 
    /// $query = New-RscQueryReport -Data
    /// 
    /// # OPTIONAL
    /// $query.Var.first = $someInt
    /// # OPTIONAL
    /// $query.Var.after = $someString
    /// # OPTIONAL
    /// $query.Var.last = $someInt
    /// # OPTIONAL
    /// $query.Var.before = $someString
    /// # REQUIRED
    /// $query.Var.dataView = $someDataViewTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DataViewTypeEnum]) for enum values.
    /// # REQUIRED
    /// $query.Var.columns = @(
    /// 	$someString
    /// )
    /// # OPTIONAL
    /// $query.Var.filters = @(
    /// 	@{
    /// 		# REQUIRED
    /// 		name = $someString
    /// 		# REQUIRED
    /// 		values = @(
    /// 			$someString
    /// 		)
    /// }
    /// )
    /// # OPTIONAL
    /// $query.Var.groupBy = @(
    /// 	$someString
    /// )
    /// # OPTIONAL
    /// $query.Var.secondaryGroupBy = $someString
    /// # OPTIONAL
    /// $query.Var.aggregations = @(
    /// 	$someString
    /// )
    /// # OPTIONAL
    /// $query.Var.sortBy = $someString
    /// # OPTIONAL
    /// $query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
    /// # OPTIONAL
    /// $query.Var.timezone = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: RowConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the Scheduled operation
    /// of the 'Report' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Report
    /// # API Operation: Scheduled
    /// 
    /// $query = New-RscQueryReport -Scheduled
    /// 
    /// # REQUIRED
    /// $query.Var.id = $someInt
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: ScheduledReport
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
        "RscQueryReport",
        DefaultParameterSetName = "Data")
    ]
    public class New_RscQueryReport : RscGqlPSCmdlet
    {
        
        [Parameter(
            ParameterSetName = "Data",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a query object for the 'Data' operation
in the 'Report' API domain.
Description of the operation:

[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/reportdata.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter Data { get; set; }

        
        [Parameter(
            ParameterSetName = "Scheduled",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a query object for the 'Scheduled' operation
in the 'Report' API domain.
Description of the operation:
Retrieve details of a scheduled report.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/scheduledreport.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter Scheduled { get; set; }



        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                switch(this.GetOp().OpName())
                {
                    case "Data":
                        this.ProcessRecord_Data();
                        break;
                    case "Scheduled":
                        this.ProcessRecord_Scheduled();
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
        // reportData.
        internal void ProcessRecord_Data()
        {
            this._logger.name += " -Data";
            // Create new graphql operation reportData
            InitQueryReportData();
        }

        // This parameter set invokes a single graphql operation:
        // scheduledReport.
        internal void ProcessRecord_Scheduled()
        {
            this._logger.name += " -Scheduled";
            // Create new graphql operation scheduledReport
            InitQueryScheduledReport();
        }


        // Create new GraphQL Query:
        // reportData(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     dataView: DataViewTypeEnum!
        //     columns: [String!]!
        //     filters: [ReportFilterInput!]
        //     groupBy: [String!]
        //     secondaryGroupBy: String
        //     aggregations: [String!]
        //     sortBy: String
        //     sortOrder: SortOrder
        //     timezone: String
        //   ): RowConnection!
        internal void InitQueryReportData()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("dataView", "DataViewTypeEnum!"),
                Tuple.Create("columns", "[String!]!"),
                Tuple.Create("filters", "[ReportFilterInput!]"),
                Tuple.Create("groupBy", "[String!]"),
                Tuple.Create("secondaryGroupBy", "String"),
                Tuple.Create("aggregations", "[String!]"),
                Tuple.Create("sortBy", "String"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("timezone", "String"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryReportData",
                "($first: Int,$after: String,$last: Int,$before: String,$dataView: DataViewTypeEnum!,$columns: [String!]!,$filters: [ReportFilterInput!],$groupBy: [String!],$secondaryGroupBy: String,$aggregations: [String!],$sortBy: String,$sortOrder: SortOrder,$timezone: String)",
                "RowConnection",
                Query.ReportData_ObjectFieldSpec,
                Query.ReportDataFieldSpec,
                @"# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# OPTIONAL
$query.Var.last = $someInt
# OPTIONAL
$query.Var.before = $someString
# REQUIRED
$query.Var.dataView = $someDataViewTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DataViewTypeEnum]) for enum values.
# REQUIRED
$query.Var.columns = @(
	$someString
)
# OPTIONAL
$query.Var.filters = @(
	@{
		# REQUIRED
		name = $someString
		# REQUIRED
		values = @(
			$someString
		)
}
)
# OPTIONAL
$query.Var.groupBy = @(
	$someString
)
# OPTIONAL
$query.Var.secondaryGroupBy = $someString
# OPTIONAL
$query.Var.aggregations = @(
	$someString
)
# OPTIONAL
$query.Var.sortBy = $someString
# OPTIONAL
$query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$query.Var.timezone = $someString"
            );
        }

        // Create new GraphQL Query:
        // scheduledReport(id: Int!): ScheduledReport
        internal void InitQueryScheduledReport()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("id", "Int!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryScheduledReport",
                "($id: Int!)",
                "ScheduledReport",
                Query.ScheduledReport_ObjectFieldSpec,
                Query.ScheduledReportFieldSpec,
                @"# REQUIRED
$query.Var.id = $someInt"
            );
        }


    } // class New_RscQueryReport
}