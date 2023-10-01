// New-RscQueryRcs.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections;
using System.Collections.Generic;
using System.Management.Automation;
using System.Text;
using System.Linq;
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
    /// Create a new RscQuery object for any of the 3
    /// operations in the 'RCS' API domain:
    /// ArchivalLocationsConsumptionStats, Cluster, or Dhcores.
    /// </summary>
    /// <description>
    /// New-RscQueryRcs creates a new
    /// query object for operations
    /// in the 'RCS' API domain. It only creates a data structure,
    /// it does not execute the operation. This cmdlet does not need a
    /// connection to run. To execute the operation, either call Invoke()
    /// on the object returned by this cmdlet, or pass the object to
    /// Invoke-Rsc.
    /// There are 3 operations
    /// in the 'RCS' API domain. Select the operation this
    /// query is for by specifying the appropriate value for the
    /// -Operation parameter;
    /// one of: ArchivalLocationsConsumptionStats, Cluster, or Dhcores.
    /// Each operation has its own set of variables that can be set with
    /// the -Var parameter. For more info about the variables, 
    /// call Info() on the object returned by this cmdlet, for example:
    /// (New-RscQueryRcs -ArchivalLocationsConsumptionStats).Info().
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
    /// (New-RscQueryRcs -ArchivalLocationsConsumptionStats).Info().
    /// You can combine a -Field parameter with patching parameters.
    /// -Field is applied first, then -FilePatch, -AddField and -RemoveField.
    ///
    /// </description>
    ///
    /// <example>
    /// Runs the ArchivalLocationsConsumptionStats operation
    /// of the 'RCS' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Rcs
    /// # API Operation: ArchivalLocationsConsumptionStats
    /// 
    /// $query = New-RscQueryRcs -ArchivalLocationsConsumptionStats
    /// 
    /// # REQUIRED
    /// $query.Var.rcsAzureTargetConsumptionStatsRequest = @{
    /// 	# REQUIRED
    /// 	locationIds = @(
    /// 		$someString
    /// 	)
    /// 	# REQUIRED
    /// 	metricName = $someRcsConsumptionMetricNameType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RcsConsumptionMetricNameType]) for enum values.
    /// 	# OPTIONAL
    /// 	doForecasting = $someBoolean
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: RcsAzureArchivalLocationsConsumptionStatsOutput
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the Cluster operation
    /// of the 'RCS' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Rcs
    /// # API Operation: Cluster
    /// 
    /// $query = New-RscQueryRcs -Cluster
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	id = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: ClusterCsr
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the Dhcores operation
    /// of the 'RCS' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Rcs
    /// # API Operation: Dhcores
    /// 
    /// $query = New-RscQueryRcs -Dhcores
    /// 
    /// # OPTIONAL
    /// $query.Var.categories = @(
    /// 	$someDhrcCategory # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DhrcCategory]) for enum values.
    /// )
    /// # OPTIONAL
    /// $query.Var.beginTime = $someDateTime
    /// # OPTIONAL
    /// $query.Var.timespan = $someDhrcScoreTimespan # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DhrcScoreTimespan]) for enum values.
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: List&lt;DhrcScore&gt;
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
        "RscQueryRcs",
        DefaultParameterSetName = "Operation")
    ]
    public class New_RscQueryRcs : RscGqlPSCmdlet
    {
        [Parameter(
            Mandatory = true, 
            ParameterSetName = "Operation",
            HelpMessage = "API Operation. The set of operations depends on the API domain. See reference at: https://github.com/rubrikinc/rubrik-powershell-sdk/blob/main/docs/domains_and_operations.md",
            Position = 0,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = true)]
            [ValidateSet(
                "ArchivalLocationsConsumptionStats",
                "Cluster",
                "Dhcores",
                IgnoreCase = true)]
        public string Operation { get; set; } = "";

        internal override string GetOperationParameter()
        {
            return this.Operation;
        }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                switch(this.GetOp().OpName())
                {
                    case "ArchivalLocationsConsumptionStats":
                        this.ProcessRecord_ArchivalLocationsConsumptionStats();
                        break;
                    case "Cluster":
                        this.ProcessRecord_Cluster();
                        break;
                    case "Dhcores":
                        this.ProcessRecord_Dhcores();
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
        // rcsArchivalLocationsConsumptionStats.
        internal void ProcessRecord_ArchivalLocationsConsumptionStats()
        {
            this._logger.name += " -ArchivalLocationsConsumptionStats";
            // Create new graphql operation rcsArchivalLocationsConsumptionStats
            InitQueryRcsArchivalLocationsConsumptionStats();
        }

        // This parameter set invokes a single graphql operation:
        // clusterCsr.
        internal void ProcessRecord_Cluster()
        {
            this._logger.name += " -Cluster";
            // Create new graphql operation clusterCsr
            InitQueryClusterCsr();
        }

        // This parameter set invokes a single graphql operation:
        // allDhrcScores.
        internal void ProcessRecord_Dhcores()
        {
            this._logger.name += " -Dhcores";
            // Create new graphql operation allDhrcScores
            InitQueryAllDhrcScores();
        }


        // Create new GraphQL Query:
        // rcsArchivalLocationsConsumptionStats(rcsAzureTargetConsumptionStatsRequest: RcsConsumptionStatsInput!): RcsAzureArchivalLocationsConsumptionStatsOutput!
        internal void InitQueryRcsArchivalLocationsConsumptionStats()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("rcsAzureTargetConsumptionStatsRequest", "RcsConsumptionStatsInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryRcsArchivalLocationsConsumptionStats",
                "($rcsAzureTargetConsumptionStatsRequest: RcsConsumptionStatsInput!)",
                "RcsAzureArchivalLocationsConsumptionStatsOutput",
                Query.RcsArchivalLocationsConsumptionStats_ObjectFieldSpec,
                Query.RcsArchivalLocationsConsumptionStatsFieldSpec,
                @"# REQUIRED
$query.Var.rcsAzureTargetConsumptionStatsRequest = @{
	# REQUIRED
	locationIds = @(
		$someString
	)
	# REQUIRED
	metricName = $someRcsConsumptionMetricNameType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RcsConsumptionMetricNameType]) for enum values.
	# OPTIONAL
	doForecasting = $someBoolean
}"
            );
        }

        // Create new GraphQL Query:
        // clusterCsr(input: GetClusterCsrInput!): ClusterCsr!
        internal void InitQueryClusterCsr()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetClusterCsrInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryClusterCsr",
                "($input: GetClusterCsrInput!)",
                "ClusterCsr",
                Query.ClusterCsr_ObjectFieldSpec,
                Query.ClusterCsrFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someString
}"
            );
        }

        // Create new GraphQL Query:
        // allDhrcScores(categories: [DhrcCategory!], beginTime: DateTime, timespan: DhrcScoreTimespan): [DhrcScore!]!
        internal void InitQueryAllDhrcScores()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("categories", "[DhrcCategory!]"),
                Tuple.Create("beginTime", "DateTime"),
                Tuple.Create("timespan", "DhrcScoreTimespan"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllDhrcScores",
                "($categories: [DhrcCategory!],$beginTime: DateTime,$timespan: DhrcScoreTimespan)",
                "List<DhrcScore>",
                Query.AllDhrcScores_ObjectFieldSpec,
                Query.AllDhrcScoresFieldSpec,
                @"# OPTIONAL
$query.Var.categories = @(
	$someDhrcCategory # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DhrcCategory]) for enum values.
)
# OPTIONAL
$query.Var.beginTime = $someDateTime
# OPTIONAL
$query.Var.timespan = $someDhrcScoreTimespan # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DhrcScoreTimespan]) for enum values."
            );
        }


    } // class New_RscQueryRcs
}