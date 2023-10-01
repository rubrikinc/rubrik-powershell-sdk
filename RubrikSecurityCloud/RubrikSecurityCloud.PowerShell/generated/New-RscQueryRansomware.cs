// New-RscQueryRansomware.cs
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
    /// Create a new RscQuery object for any of the 12
    /// operations in the 'Ransomware' API domain:
    /// DetectionWorkloadLocations, InvestigationAnalysisSummary, InvestigationEnablement, InvestigationWorkloadScannedCount, OverallInvestigationSummary, PendingInvestigationResultsCount, ProcessedInvestigationWorkloadCount, ProtectedInvestigationWorkloadCount, Result, ResultOpt, Results, or ResultsGrouped.
    /// </summary>
    /// <description>
    /// New-RscQueryRansomware creates a new
    /// query object for operations
    /// in the 'Ransomware' API domain. It only creates a data structure,
    /// it does not execute the operation. This cmdlet does not need a
    /// connection to run. To execute the operation, either call Invoke()
    /// on the object returned by this cmdlet, or pass the object to
    /// Invoke-Rsc.
    /// There are 12 operations
    /// in the 'Ransomware' API domain. Select the operation this
    /// query is for by specifying the appropriate value for the
    /// -Operation parameter;
    /// one of: DetectionWorkloadLocations, InvestigationAnalysisSummary, InvestigationEnablement, InvestigationWorkloadScannedCount, OverallInvestigationSummary, PendingInvestigationResultsCount, ProcessedInvestigationWorkloadCount, ProtectedInvestigationWorkloadCount, Result, ResultOpt, Results, or ResultsGrouped.
    /// Each operation has its own set of variables that can be set with
    /// the -Var parameter. For more info about the variables, 
    /// call Info() on the object returned by this cmdlet, for example:
    /// (New-RscQueryRansomware -DetectionWorkloadLocations).Info().
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
    /// (New-RscQueryRansomware -DetectionWorkloadLocations).Info().
    /// You can combine a -Field parameter with patching parameters.
    /// -Field is applied first, then -FilePatch, -AddField and -RemoveField.
    ///
    /// </description>
    ///
    /// <example>
    /// Runs the DetectionWorkloadLocations operation
    /// of the 'Ransomware' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Ransomware
    /// # API Operation: DetectionWorkloadLocations
    /// 
    /// $query = New-RscQueryRansomware -DetectionWorkloadLocations
    /// 
    /// # REQUIRED
    /// $query.Var.beginTime = $someDateTime
    /// # OPTIONAL
    /// $query.Var.endTime = $someDateTime
    /// # REQUIRED
    /// $query.Var.returnOnlyForAnomalousEntities = $someBoolean
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: ListLocationsReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the InvestigationAnalysisSummary operation
    /// of the 'Ransomware' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Ransomware
    /// # API Operation: InvestigationAnalysisSummary
    /// 
    /// $query = New-RscQueryRansomware -InvestigationAnalysisSummary
    /// 
    /// # REQUIRED
    /// $query.Var.startDay = $someString
    /// # REQUIRED
    /// $query.Var.endDay = $someString
    /// # REQUIRED
    /// $query.Var.timezone = $someString
    /// # OPTIONAL
    /// $query.Var.objectTypeFilter = @(
    /// 	$someString
    /// )
    /// # OPTIONAL
    /// $query.Var.clusterUuidFilter = @(
    /// 	$someString
    /// )
    /// # OPTIONAL
    /// $query.Var.slaFidFilter = @(
    /// 	$someString
    /// )
    /// # OPTIONAL
    /// $query.Var.hideSuspiciousDataIfNonAnomalous = $someBoolean
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: RansomwareInvestigationAnalysisSummaryReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the InvestigationEnablement operation
    /// of the 'Ransomware' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Ransomware
    /// # API Operation: InvestigationEnablement
    /// 
    /// $query = New-RscQueryRansomware -InvestigationEnablement
    /// 
    /// # No variables for this query.
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: RansomwareInvestigationEnablementReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the InvestigationWorkloadScannedCount operation
    /// of the 'Ransomware' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Ransomware
    /// # API Operation: InvestigationWorkloadScannedCount
    /// 
    /// $query = New-RscQueryRansomware -InvestigationWorkloadScannedCount
    /// 
    /// # REQUIRED
    /// $query.Var.workloadId = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: RansomwareInvestigationWorkloadScannedCountReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the OverallInvestigationSummary operation
    /// of the 'Ransomware' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Ransomware
    /// # API Operation: OverallInvestigationSummary
    /// 
    /// $query = New-RscQueryRansomware -OverallInvestigationSummary
    /// 
    /// # REQUIRED
    /// $query.Var.historyNumHours = $someInt
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: OverallRansomwareInvestigationSummary
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the PendingInvestigationResultsCount operation
    /// of the 'Ransomware' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Ransomware
    /// # API Operation: PendingInvestigationResultsCount
    /// 
    /// $query = New-RscQueryRansomware -PendingInvestigationResultsCount
    /// 
    /// # No variables for this query.
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: PendingEvaluationResultsReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the ProcessedInvestigationWorkloadCount operation
    /// of the 'Ransomware' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Ransomware
    /// # API Operation: ProcessedInvestigationWorkloadCount
    /// 
    /// $query = New-RscQueryRansomware -ProcessedInvestigationWorkloadCount
    /// 
    /// # No variables for this query.
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: ProcessedRansomwareInvestigationWorkloadCountReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the ProtectedInvestigationWorkloadCount operation
    /// of the 'Ransomware' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Ransomware
    /// # API Operation: ProtectedInvestigationWorkloadCount
    /// 
    /// $query = New-RscQueryRansomware -ProtectedInvestigationWorkloadCount
    /// 
    /// # No variables for this query.
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: ProtectedRansomwareInvestigationWorkloadCountReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the Result operation
    /// of the 'Ransomware' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Ransomware
    /// # API Operation: Result
    /// 
    /// $query = New-RscQueryRansomware -Result
    /// 
    /// # REQUIRED
    /// $query.Var.clusterUuid = $someString
    /// # REQUIRED
    /// $query.Var.managedId = $someString
    /// # REQUIRED
    /// $query.Var.snapshotId = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: RansomwareResult
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the ResultOpt operation
    /// of the 'Ransomware' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Ransomware
    /// # API Operation: ResultOpt
    /// 
    /// $query = New-RscQueryRansomware -ResultOpt
    /// 
    /// # REQUIRED
    /// $query.Var.clusterUuid = $someString
    /// # REQUIRED
    /// $query.Var.managedId = $someString
    /// # REQUIRED
    /// $query.Var.snapshotId = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: RansomwareResult
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the Results operation
    /// of the 'Ransomware' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Ransomware
    /// # API Operation: Results
    /// 
    /// $query = New-RscQueryRansomware -Results
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
    /// $query.Var.sortBy = $someRansomwareResultSortBy # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RansomwareResultSortBy]) for enum values.
    /// # OPTIONAL
    /// $query.Var.filter = @{
    /// 	# OPTIONAL
    /// 	clusterUuid = @(
    /// 		$someString
    /// 	)
    /// 	# OPTIONAL
    /// 	managedId = @(
    /// 		$someString
    /// 	)
    /// 	# OPTIONAL
    /// 	startTime = $someDateTime
    /// 	# OPTIONAL
    /// 	endTime = $someDateTime
    /// 	# OPTIONAL
    /// 	isEncrypted = $someBoolean
    /// }
    /// # OPTIONAL
    /// $query.Var.timezoneOffset = $someSingle
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: RansomwareResultConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the ResultsGrouped operation
    /// of the 'Ransomware' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Ransomware
    /// # API Operation: ResultsGrouped
    /// 
    /// $query = New-RscQueryRansomware -ResultsGrouped
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
    /// $query.Var.groupBy = $someRansomwareResultGroupBy # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RansomwareResultGroupBy]) for enum values.
    /// # OPTIONAL
    /// $query.Var.filter = @{
    /// 	# OPTIONAL
    /// 	clusterUuid = @(
    /// 		$someString
    /// 	)
    /// 	# OPTIONAL
    /// 	managedId = @(
    /// 		$someString
    /// 	)
    /// 	# OPTIONAL
    /// 	startTime = $someDateTime
    /// 	# OPTIONAL
    /// 	endTime = $someDateTime
    /// 	# OPTIONAL
    /// 	isEncrypted = $someBoolean
    /// }
    /// # OPTIONAL
    /// $query.Var.timezoneOffset = $someSingle
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: RansomwareResultGroupedDataConnection
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
        "RscQueryRansomware",
        DefaultParameterSetName = "Operation")
    ]
    public class New_RscQueryRansomware : RscGqlPSCmdlet
    {
        [Parameter(
            Mandatory = true, 
            ParameterSetName = "Operation",
            HelpMessage = "API Operation. The set of operations depends on the API domain. See reference at: https://github.com/rubrikinc/rubrik-powershell-sdk/blob/main/docs/domains_and_operations.md",
            Position = 0,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = true)]
            [ValidateSet(
                "DetectionWorkloadLocations",
                "InvestigationAnalysisSummary",
                "InvestigationEnablement",
                "InvestigationWorkloadScannedCount",
                "OverallInvestigationSummary",
                "PendingInvestigationResultsCount",
                "ProcessedInvestigationWorkloadCount",
                "ProtectedInvestigationWorkloadCount",
                "Result",
                "ResultOpt",
                "Results",
                "ResultsGrouped",
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
                    case "DetectionWorkloadLocations":
                        this.ProcessRecord_DetectionWorkloadLocations();
                        break;
                    case "InvestigationAnalysisSummary":
                        this.ProcessRecord_InvestigationAnalysisSummary();
                        break;
                    case "InvestigationEnablement":
                        this.ProcessRecord_InvestigationEnablement();
                        break;
                    case "InvestigationWorkloadScannedCount":
                        this.ProcessRecord_InvestigationWorkloadScannedCount();
                        break;
                    case "OverallInvestigationSummary":
                        this.ProcessRecord_OverallInvestigationSummary();
                        break;
                    case "PendingInvestigationResultsCount":
                        this.ProcessRecord_PendingInvestigationResultsCount();
                        break;
                    case "ProcessedInvestigationWorkloadCount":
                        this.ProcessRecord_ProcessedInvestigationWorkloadCount();
                        break;
                    case "ProtectedInvestigationWorkloadCount":
                        this.ProcessRecord_ProtectedInvestigationWorkloadCount();
                        break;
                    case "Result":
                        this.ProcessRecord_Result();
                        break;
                    case "ResultOpt":
                        this.ProcessRecord_ResultOpt();
                        break;
                    case "Results":
                        this.ProcessRecord_Results();
                        break;
                    case "ResultsGrouped":
                        this.ProcessRecord_ResultsGrouped();
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
        // ransomwareDetectionWorkloadLocations.
        internal void ProcessRecord_DetectionWorkloadLocations()
        {
            this._logger.name += " -DetectionWorkloadLocations";
            // Create new graphql operation ransomwareDetectionWorkloadLocations
            InitQueryRansomwareDetectionWorkloadLocations();
        }

        // This parameter set invokes a single graphql operation:
        // ransomwareInvestigationAnalysisSummary.
        internal void ProcessRecord_InvestigationAnalysisSummary()
        {
            this._logger.name += " -InvestigationAnalysisSummary";
            // Create new graphql operation ransomwareInvestigationAnalysisSummary
            InitQueryRansomwareInvestigationAnalysisSummary();
        }

        // This parameter set invokes a single graphql operation:
        // ransomwareInvestigationEnablement.
        internal void ProcessRecord_InvestigationEnablement()
        {
            this._logger.name += " -InvestigationEnablement";
            // Create new graphql operation ransomwareInvestigationEnablement
            InitQueryRansomwareInvestigationEnablement();
        }

        // This parameter set invokes a single graphql operation:
        // ransomwareInvestigationWorkloadScannedCount.
        internal void ProcessRecord_InvestigationWorkloadScannedCount()
        {
            this._logger.name += " -InvestigationWorkloadScannedCount";
            // Create new graphql operation ransomwareInvestigationWorkloadScannedCount
            InitQueryRansomwareInvestigationWorkloadScannedCount();
        }

        // This parameter set invokes a single graphql operation:
        // overallRansomwareInvestigationSummary.
        internal void ProcessRecord_OverallInvestigationSummary()
        {
            this._logger.name += " -OverallInvestigationSummary";
            // Create new graphql operation overallRansomwareInvestigationSummary
            InitQueryOverallRansomwareInvestigationSummary();
        }

        // This parameter set invokes a single graphql operation:
        // pendingRansomwareInvestigationResultsCount.
        internal void ProcessRecord_PendingInvestigationResultsCount()
        {
            this._logger.name += " -PendingInvestigationResultsCount";
            // Create new graphql operation pendingRansomwareInvestigationResultsCount
            InitQueryPendingRansomwareInvestigationResultsCount();
        }

        // This parameter set invokes a single graphql operation:
        // processedRansomwareInvestigationWorkloadCount.
        internal void ProcessRecord_ProcessedInvestigationWorkloadCount()
        {
            this._logger.name += " -ProcessedInvestigationWorkloadCount";
            // Create new graphql operation processedRansomwareInvestigationWorkloadCount
            InitQueryProcessedRansomwareInvestigationWorkloadCount();
        }

        // This parameter set invokes a single graphql operation:
        // protectedRansomwareInvestigationWorkloadCount.
        internal void ProcessRecord_ProtectedInvestigationWorkloadCount()
        {
            this._logger.name += " -ProtectedInvestigationWorkloadCount";
            // Create new graphql operation protectedRansomwareInvestigationWorkloadCount
            InitQueryProtectedRansomwareInvestigationWorkloadCount();
        }

        // This parameter set invokes a single graphql operation:
        // ransomwareResult.
        internal void ProcessRecord_Result()
        {
            this._logger.name += " -Result";
            // Create new graphql operation ransomwareResult
            InitQueryRansomwareResult();
        }

        // This parameter set invokes a single graphql operation:
        // ransomwareResultOpt.
        internal void ProcessRecord_ResultOpt()
        {
            this._logger.name += " -ResultOpt";
            // Create new graphql operation ransomwareResultOpt
            InitQueryRansomwareResultOpt();
        }

        // This parameter set invokes a single graphql operation:
        // ransomwareResults.
        internal void ProcessRecord_Results()
        {
            this._logger.name += " -Results";
            // Create new graphql operation ransomwareResults
            InitQueryRansomwareResults();
        }

        // This parameter set invokes a single graphql operation:
        // ransomwareResultsGrouped.
        internal void ProcessRecord_ResultsGrouped()
        {
            this._logger.name += " -ResultsGrouped";
            // Create new graphql operation ransomwareResultsGrouped
            InitQueryRansomwareResultsGrouped();
        }


        // Create new GraphQL Query:
        // ransomwareDetectionWorkloadLocations(beginTime: DateTime!, endTime: DateTime, returnOnlyForAnomalousEntities: Boolean!): ListLocationsReply!
        internal void InitQueryRansomwareDetectionWorkloadLocations()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("beginTime", "DateTime!"),
                Tuple.Create("endTime", "DateTime"),
                Tuple.Create("returnOnlyForAnomalousEntities", "Boolean!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryRansomwareDetectionWorkloadLocations",
                "($beginTime: DateTime!,$endTime: DateTime,$returnOnlyForAnomalousEntities: Boolean!)",
                "ListLocationsReply",
                Query.RansomwareDetectionWorkloadLocations_ObjectFieldSpec,
                Query.RansomwareDetectionWorkloadLocationsFieldSpec,
                @"# REQUIRED
$query.Var.beginTime = $someDateTime
# OPTIONAL
$query.Var.endTime = $someDateTime
# REQUIRED
$query.Var.returnOnlyForAnomalousEntities = $someBoolean"
            );
        }

        // Create new GraphQL Query:
        // ransomwareInvestigationAnalysisSummary(
        //     startDay: String!
        //     endDay: String!
        //     timezone: String!
        //     objectTypeFilter: [String!]
        //     clusterUuidFilter: [String!]
        //     slaFidFilter: [String!]
        //     hideSuspiciousDataIfNonAnomalous: Boolean
        //   ): RansomwareInvestigationAnalysisSummaryReply!
        internal void InitQueryRansomwareInvestigationAnalysisSummary()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("startDay", "String!"),
                Tuple.Create("endDay", "String!"),
                Tuple.Create("timezone", "String!"),
                Tuple.Create("objectTypeFilter", "[String!]"),
                Tuple.Create("clusterUuidFilter", "[String!]"),
                Tuple.Create("slaFidFilter", "[String!]"),
                Tuple.Create("hideSuspiciousDataIfNonAnomalous", "Boolean"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryRansomwareInvestigationAnalysisSummary",
                "($startDay: String!,$endDay: String!,$timezone: String!,$objectTypeFilter: [String!],$clusterUuidFilter: [String!],$slaFidFilter: [String!],$hideSuspiciousDataIfNonAnomalous: Boolean)",
                "RansomwareInvestigationAnalysisSummaryReply",
                Query.RansomwareInvestigationAnalysisSummary_ObjectFieldSpec,
                Query.RansomwareInvestigationAnalysisSummaryFieldSpec,
                @"# REQUIRED
$query.Var.startDay = $someString
# REQUIRED
$query.Var.endDay = $someString
# REQUIRED
$query.Var.timezone = $someString
# OPTIONAL
$query.Var.objectTypeFilter = @(
	$someString
)
# OPTIONAL
$query.Var.clusterUuidFilter = @(
	$someString
)
# OPTIONAL
$query.Var.slaFidFilter = @(
	$someString
)
# OPTIONAL
$query.Var.hideSuspiciousDataIfNonAnomalous = $someBoolean"
            );
        }

        // Create new GraphQL Query:
        // ransomwareInvestigationEnablement: RansomwareInvestigationEnablementReply!
        internal void InitQueryRansomwareInvestigationEnablement()
        {
            Tuple<string, string>[] argDefs = {
            };
            Initialize(
                argDefs,
                "query",
                "QueryRansomwareInvestigationEnablement",
                "",
                "RansomwareInvestigationEnablementReply",
                Query.RansomwareInvestigationEnablement_ObjectFieldSpec,
                Query.RansomwareInvestigationEnablementFieldSpec,
                @""
            );
        }

        // Create new GraphQL Query:
        // ransomwareInvestigationWorkloadScannedCount(workloadId: String!): RansomwareInvestigationWorkloadScannedCountReply!
        internal void InitQueryRansomwareInvestigationWorkloadScannedCount()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("workloadId", "String!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryRansomwareInvestigationWorkloadScannedCount",
                "($workloadId: String!)",
                "RansomwareInvestigationWorkloadScannedCountReply",
                Query.RansomwareInvestigationWorkloadScannedCount_ObjectFieldSpec,
                Query.RansomwareInvestigationWorkloadScannedCountFieldSpec,
                @"# REQUIRED
$query.Var.workloadId = $someString"
            );
        }

        // Create new GraphQL Query:
        // overallRansomwareInvestigationSummary(historyNumHours: Int!): OverallRansomwareInvestigationSummary!
        internal void InitQueryOverallRansomwareInvestigationSummary()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("historyNumHours", "Int!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryOverallRansomwareInvestigationSummary",
                "($historyNumHours: Int!)",
                "OverallRansomwareInvestigationSummary",
                Query.OverallRansomwareInvestigationSummary_ObjectFieldSpec,
                Query.OverallRansomwareInvestigationSummaryFieldSpec,
                @"# REQUIRED
$query.Var.historyNumHours = $someInt"
            );
        }

        // Create new GraphQL Query:
        // pendingRansomwareInvestigationResultsCount: PendingEvaluationResultsReply!
        internal void InitQueryPendingRansomwareInvestigationResultsCount()
        {
            Tuple<string, string>[] argDefs = {
            };
            Initialize(
                argDefs,
                "query",
                "QueryPendingRansomwareInvestigationResultsCount",
                "",
                "PendingEvaluationResultsReply",
                Query.PendingRansomwareInvestigationResultsCount_ObjectFieldSpec,
                Query.PendingRansomwareInvestigationResultsCountFieldSpec,
                @""
            );
        }

        // Create new GraphQL Query:
        // processedRansomwareInvestigationWorkloadCount: ProcessedRansomwareInvestigationWorkloadCountReply!
        internal void InitQueryProcessedRansomwareInvestigationWorkloadCount()
        {
            Tuple<string, string>[] argDefs = {
            };
            Initialize(
                argDefs,
                "query",
                "QueryProcessedRansomwareInvestigationWorkloadCount",
                "",
                "ProcessedRansomwareInvestigationWorkloadCountReply",
                Query.ProcessedRansomwareInvestigationWorkloadCount_ObjectFieldSpec,
                Query.ProcessedRansomwareInvestigationWorkloadCountFieldSpec,
                @""
            );
        }

        // Create new GraphQL Query:
        // protectedRansomwareInvestigationWorkloadCount: ProtectedRansomwareInvestigationWorkloadCountReply!
        internal void InitQueryProtectedRansomwareInvestigationWorkloadCount()
        {
            Tuple<string, string>[] argDefs = {
            };
            Initialize(
                argDefs,
                "query",
                "QueryProtectedRansomwareInvestigationWorkloadCount",
                "",
                "ProtectedRansomwareInvestigationWorkloadCountReply",
                Query.ProtectedRansomwareInvestigationWorkloadCount_ObjectFieldSpec,
                Query.ProtectedRansomwareInvestigationWorkloadCountFieldSpec,
                @""
            );
        }

        // Create new GraphQL Query:
        // ransomwareResult(clusterUuid: UUID!, managedId: String!, snapshotId: String!): RansomwareResult!
        internal void InitQueryRansomwareResult()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("clusterUuid", "UUID!"),
                Tuple.Create("managedId", "String!"),
                Tuple.Create("snapshotId", "String!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryRansomwareResult",
                "($clusterUuid: UUID!,$managedId: String!,$snapshotId: String!)",
                "RansomwareResult",
                Query.RansomwareResult_ObjectFieldSpec,
                Query.RansomwareResultFieldSpec,
                @"# REQUIRED
$query.Var.clusterUuid = $someString
# REQUIRED
$query.Var.managedId = $someString
# REQUIRED
$query.Var.snapshotId = $someString"
            );
        }

        // Create new GraphQL Query:
        // ransomwareResultOpt(clusterUuid: UUID!, managedId: String!, snapshotId: String!): RansomwareResult
        internal void InitQueryRansomwareResultOpt()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("clusterUuid", "UUID!"),
                Tuple.Create("managedId", "String!"),
                Tuple.Create("snapshotId", "String!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryRansomwareResultOpt",
                "($clusterUuid: UUID!,$managedId: String!,$snapshotId: String!)",
                "RansomwareResult",
                Query.RansomwareResultOpt_ObjectFieldSpec,
                Query.RansomwareResultOptFieldSpec,
                @"# REQUIRED
$query.Var.clusterUuid = $someString
# REQUIRED
$query.Var.managedId = $someString
# REQUIRED
$query.Var.snapshotId = $someString"
            );
        }

        // Create new GraphQL Query:
        // ransomwareResults(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     sortBy: RansomwareResultSortBy
        //     filter: RansomwareResultFilterInput
        //     timezoneOffset: Float = 0.0
        //   ): RansomwareResultConnection!
        internal void InitQueryRansomwareResults()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("sortBy", "RansomwareResultSortBy"),
                Tuple.Create("filter", "RansomwareResultFilterInput"),
                Tuple.Create("timezoneOffset", "Float"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryRansomwareResults",
                "($first: Int,$after: String,$last: Int,$before: String,$sortBy: RansomwareResultSortBy,$filter: RansomwareResultFilterInput,$timezoneOffset: Float)",
                "RansomwareResultConnection",
                Query.RansomwareResults_ObjectFieldSpec,
                Query.RansomwareResultsFieldSpec,
                @"# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# OPTIONAL
$query.Var.last = $someInt
# OPTIONAL
$query.Var.before = $someString
# OPTIONAL
$query.Var.sortBy = $someRansomwareResultSortBy # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RansomwareResultSortBy]) for enum values.
# OPTIONAL
$query.Var.filter = @{
	# OPTIONAL
	clusterUuid = @(
		$someString
	)
	# OPTIONAL
	managedId = @(
		$someString
	)
	# OPTIONAL
	startTime = $someDateTime
	# OPTIONAL
	endTime = $someDateTime
	# OPTIONAL
	isEncrypted = $someBoolean
}
# OPTIONAL
$query.Var.timezoneOffset = $someSingle"
            );
        }

        // Create new GraphQL Query:
        // ransomwareResultsGrouped(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     groupBy: RansomwareResultGroupBy!
        //     filter: RansomwareResultFilterInput
        //     timezoneOffset: Float = 0.0
        //   ): RansomwareResultGroupedDataConnection!
        internal void InitQueryRansomwareResultsGrouped()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("groupBy", "RansomwareResultGroupBy!"),
                Tuple.Create("filter", "RansomwareResultFilterInput"),
                Tuple.Create("timezoneOffset", "Float"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryRansomwareResultsGrouped",
                "($first: Int,$after: String,$last: Int,$before: String,$groupBy: RansomwareResultGroupBy!,$filter: RansomwareResultFilterInput,$timezoneOffset: Float)",
                "RansomwareResultGroupedDataConnection",
                Query.RansomwareResultsGrouped_ObjectFieldSpec,
                Query.RansomwareResultsGroupedFieldSpec,
                @"# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# OPTIONAL
$query.Var.last = $someInt
# OPTIONAL
$query.Var.before = $someString
# REQUIRED
$query.Var.groupBy = $someRansomwareResultGroupBy # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RansomwareResultGroupBy]) for enum values.
# OPTIONAL
$query.Var.filter = @{
	# OPTIONAL
	clusterUuid = @(
		$someString
	)
	# OPTIONAL
	managedId = @(
		$someString
	)
	# OPTIONAL
	startTime = $someDateTime
	# OPTIONAL
	endTime = $someDateTime
	# OPTIONAL
	isEncrypted = $someBoolean
}
# OPTIONAL
$query.Var.timezoneOffset = $someSingle"
            );
        }


    } // class New_RscQueryRansomware
}