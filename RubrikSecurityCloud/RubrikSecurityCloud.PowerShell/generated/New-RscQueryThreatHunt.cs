// New-RscQueryThreatHunt.cs
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
    /// Create a new RscQuery object for any of the 10
    /// operations in the 'ThreatHunt' API domain:
    /// Detail, DetailV2, IngObjectMatchedFiles, MatchedSnapshots, ObjectMetrics, Result, S, Summary, SummaryV2, or ValidateBulk.
    /// </summary>
    /// <description>
    /// New-RscQueryThreatHunt creates a new
    /// query object for operations
    /// in the 'ThreatHunt' API domain. It only creates a data structure,
    /// it does not execute the operation. This cmdlet does not need a
    /// connection to run. To execute the operation, either call Invoke()
    /// on the object returned by this cmdlet, or pass the object to
    /// Invoke-Rsc.
    /// There are 10 operations
    /// in the 'ThreatHunt' API domain. Select the operation this
    /// query is for by specifying the appropriate value for the
    /// -Operation parameter;
    /// one of: Detail, DetailV2, IngObjectMatchedFiles, MatchedSnapshots, ObjectMetrics, Result, S, Summary, SummaryV2, or ValidateBulk.
    /// Each operation has its own set of variables that can be set with
    /// the -Var parameter. For more info about the variables, 
    /// call Info() on the object returned by this cmdlet, for example:
    /// (New-RscQueryThreatHunt -Detail).Info().
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
    /// (New-RscQueryThreatHunt -Detail).Info().
    /// You can combine a -Field parameter with patching parameters.
    /// -Field is applied first, then -FilePatch, -AddField and -RemoveField.
    ///
    /// </description>
    ///
    /// <example>
    /// Runs the Detail operation
    /// of the 'ThreatHunt' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    ThreatHunt
    /// # API Operation: Detail
    /// 
    /// $query = New-RscQueryThreatHunt -Operation Detail
    /// 
    /// # REQUIRED
    /// $query.Var.huntId = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: ThreatHunt
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the DetailV2 operation
    /// of the 'ThreatHunt' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    ThreatHunt
    /// # API Operation: DetailV2
    /// 
    /// $query = New-RscQueryThreatHunt -Operation DetailV2
    /// 
    /// # REQUIRED
    /// $query.Var.huntId = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: ThreatHuntDetailsV2
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the IngObjectMatchedFiles operation
    /// of the 'ThreatHunt' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    ThreatHunt
    /// # API Operation: IngObjectMatchedFiles
    /// 
    /// $query = New-RscQueryThreatHunt -Operation IngObjectMatchedFiles
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
    /// $query.Var.huntId = $someString
    /// # REQUIRED
    /// $query.Var.objectFid = $someString
    /// # OPTIONAL
    /// $query.Var.filenameSearchFilter = $someString
    /// # OPTIONAL
    /// $query.Var.quarantinedFileMatchFilter = $someThreatHuntQuarantinedMatchType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ThreatHuntQuarantinedMatchType]) for enum values.
    /// # OPTIONAL
    /// $query.Var.threatHuntMatchedFilesSort = @{
    /// 	# REQUIRED
    /// 	field = $someMatchedFilesSortByFields # Call [Enum]::GetValues([RubrikSecurityCloud.Types.MatchedFilesSortByFields]) for enum values.
    /// 	# REQUIRED
    /// 	sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: ThreatHuntingObjectFileMatchConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the MatchedSnapshots operation
    /// of the 'ThreatHunt' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    ThreatHunt
    /// # API Operation: MatchedSnapshots
    /// 
    /// $query = New-RscQueryThreatHunt -Operation MatchedSnapshots
    /// 
    /// # REQUIRED
    /// $query.Var.huntId = $someString
    /// # REQUIRED
    /// $query.Var.objectFid = $someString
    /// # REQUIRED
    /// $query.Var.matchIds = @(
    /// 	$someInt64
    /// )
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: ThreatHuntMatchedSnapshotsReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the ObjectMetrics operation
    /// of the 'ThreatHunt' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    ThreatHunt
    /// # API Operation: ObjectMetrics
    /// 
    /// $query = New-RscQueryThreatHunt -Operation ObjectMetrics
    /// 
    /// # REQUIRED
    /// $query.Var.huntId = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: ThreatHuntObjectMetricsReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the Result operation
    /// of the 'ThreatHunt' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    ThreatHunt
    /// # API Operation: Result
    /// 
    /// $query = New-RscQueryThreatHunt -Operation Result
    /// 
    /// # REQUIRED
    /// $query.Var.huntId = $someString
    /// # OPTIONAL
    /// $query.Var.objectId = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: ThreatHuntResult
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the S operation
    /// of the 'ThreatHunt' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    ThreatHunt
    /// # API Operation: S
    /// 
    /// $query = New-RscQueryThreatHunt -Operation S
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
    /// $query.Var.beginTime = $someDateTime
    /// # OPTIONAL
    /// $query.Var.endTime = $someDateTime
    /// # OPTIONAL
    /// $query.Var.clusterUuidFilter = @(
    /// 	$someString
    /// )
    /// # OPTIONAL
    /// $query.Var.statusFilter = @(
    /// 	$someThreatHuntStatus # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ThreatHuntStatus]) for enum values.
    /// )
    /// # OPTIONAL
    /// $query.Var.matchesFoundFilter = @(
    /// 	$someThreatHuntMatchesFound # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ThreatHuntMatchesFound]) for enum values.
    /// )
    /// # OPTIONAL
    /// $query.Var.quarantinedMatchesFilter = @(
    /// 	$someThreatHuntQuarantinedMatchType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ThreatHuntQuarantinedMatchType]) for enum values.
    /// )
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: ThreatHuntConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the Summary operation
    /// of the 'ThreatHunt' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    ThreatHunt
    /// # API Operation: Summary
    /// 
    /// $query = New-RscQueryThreatHunt -Operation Summary
    /// 
    /// # REQUIRED
    /// $query.Var.huntId = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: ThreatHuntSummaryReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the SummaryV2 operation
    /// of the 'ThreatHunt' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    ThreatHunt
    /// # API Operation: SummaryV2
    /// 
    /// $query = New-RscQueryThreatHunt -Operation SummaryV2
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
    /// $query.Var.huntId = $someString
    /// # OPTIONAL
    /// $query.Var.objectTypeFilter = @(
    /// 	$someString
    /// )
    /// # OPTIONAL
    /// $query.Var.matchesFoundFilter = $someThreatHuntMatchesFound # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ThreatHuntMatchesFound]) for enum values.
    /// # OPTIONAL
    /// $query.Var.quarantinedMatchesFilter = $someThreatHuntQuarantinedMatchType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ThreatHuntQuarantinedMatchType]) for enum values.
    /// # OPTIONAL
    /// $query.Var.threatHuntSummaryFilters = @{
    /// 	# REQUIRED
    /// 	clusterUuids = @(
    /// 		$someString
    /// 	)
    /// 	# OPTIONAL
    /// 	cloudProviders = @(
    /// 		$someString
    /// 	)
    /// 	# REQUIRED
    /// 	matchTypes = @(
    /// 		$someIndicatorOfCompromiseKind # Call [Enum]::GetValues([RubrikSecurityCloud.Types.IndicatorOfCompromiseKind]) for enum values.
    /// 	)
    /// 	# REQUIRED
    /// 	objectScanStatus = @(
    /// 		$someThreatHuntObjectStatus # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ThreatHuntObjectStatus]) for enum values.
    /// 	)
    /// }
    /// # OPTIONAL
    /// $query.Var.threatHuntSummarySort = @{
    /// 	# REQUIRED
    /// 	field = $someObjectSummariesSortByFields # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ObjectSummariesSortByFields]) for enum values.
    /// 	# REQUIRED
    /// 	sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
    /// }
    /// # OPTIONAL
    /// $query.Var.workloadNameSearch = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: ThreatHuntResultObjectsSummaryConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the ValidateBulk operation
    /// of the 'ThreatHunt' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    ThreatHunt
    /// # API Operation: ValidateBulk
    /// 
    /// $query = New-RscQueryThreatHunt -Operation ValidateBulk
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	objectInfos = @(
    /// 		@{
    /// 			# OPTIONAL
    /// 			objectFid = $someString
    /// 			# OPTIONAL
    /// 			clusterVersion = $someString
    /// 			# REQUIRED
    /// 			clusterUuid = $someString
    /// 		}
    /// 	)
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: ValidateBulkThreatHuntResponse
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
        "RscQueryThreatHunt",
        DefaultParameterSetName = "Operation")
    ]
    public class New_RscQueryThreatHunt : RscGqlPSCmdlet
    {
        [Parameter(
            Mandatory = true, 
            ParameterSetName = "Operation",
            HelpMessage = "API Operation. The set of operations depends on the API domain. See reference at: https://github.com/rubrikinc/rubrik-powershell-sdk/blob/main/docs/domains_and_operations.md",
            Position = 0,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = true)]
            [ValidateSet(
                "Detail",
                "DetailV2",
                "IngObjectMatchedFiles",
                "MatchedSnapshots",
                "ObjectMetrics",
                "Result",
                "S",
                "Summary",
                "SummaryV2",
                "ValidateBulk",
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
                    case "Detail":
                        this.ProcessRecord_Detail();
                        break;
                    case "DetailV2":
                        this.ProcessRecord_DetailV2();
                        break;
                    case "IngObjectMatchedFiles":
                        this.ProcessRecord_IngObjectMatchedFiles();
                        break;
                    case "MatchedSnapshots":
                        this.ProcessRecord_MatchedSnapshots();
                        break;
                    case "ObjectMetrics":
                        this.ProcessRecord_ObjectMetrics();
                        break;
                    case "Result":
                        this.ProcessRecord_Result();
                        break;
                    case "S":
                        this.ProcessRecord_S();
                        break;
                    case "Summary":
                        this.ProcessRecord_Summary();
                        break;
                    case "SummaryV2":
                        this.ProcessRecord_SummaryV2();
                        break;
                    case "ValidateBulk":
                        this.ProcessRecord_ValidateBulk();
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
        // threatHuntDetail.
        internal void ProcessRecord_Detail()
        {
            this._logger.name += " -Detail";
            // Create new graphql operation threatHuntDetail
            InitQueryThreatHuntDetail();
        }

        // This parameter set invokes a single graphql operation:
        // threatHuntDetailV2.
        internal void ProcessRecord_DetailV2()
        {
            this._logger.name += " -DetailV2";
            // Create new graphql operation threatHuntDetailV2
            InitQueryThreatHuntDetailV2();
        }

        // This parameter set invokes a single graphql operation:
        // threatHuntingObjectMatchedFiles.
        internal void ProcessRecord_IngObjectMatchedFiles()
        {
            this._logger.name += " -IngObjectMatchedFiles";
            // Create new graphql operation threatHuntingObjectMatchedFiles
            InitQueryThreatHuntingObjectMatchedFiles();
        }

        // This parameter set invokes a single graphql operation:
        // threatHuntMatchedSnapshots.
        internal void ProcessRecord_MatchedSnapshots()
        {
            this._logger.name += " -MatchedSnapshots";
            // Create new graphql operation threatHuntMatchedSnapshots
            InitQueryThreatHuntMatchedSnapshots();
        }

        // This parameter set invokes a single graphql operation:
        // threatHuntObjectMetrics.
        internal void ProcessRecord_ObjectMetrics()
        {
            this._logger.name += " -ObjectMetrics";
            // Create new graphql operation threatHuntObjectMetrics
            InitQueryThreatHuntObjectMetrics();
        }

        // This parameter set invokes a single graphql operation:
        // threatHuntResult.
        internal void ProcessRecord_Result()
        {
            this._logger.name += " -Result";
            // Create new graphql operation threatHuntResult
            InitQueryThreatHuntResult();
        }

        // This parameter set invokes a single graphql operation:
        // threatHunts.
        internal void ProcessRecord_S()
        {
            this._logger.name += " -S";
            // Create new graphql operation threatHunts
            InitQueryThreatHunts();
        }

        // This parameter set invokes a single graphql operation:
        // threatHuntSummary.
        internal void ProcessRecord_Summary()
        {
            this._logger.name += " -Summary";
            // Create new graphql operation threatHuntSummary
            InitQueryThreatHuntSummary();
        }

        // This parameter set invokes a single graphql operation:
        // threatHuntSummaryV2.
        internal void ProcessRecord_SummaryV2()
        {
            this._logger.name += " -SummaryV2";
            // Create new graphql operation threatHuntSummaryV2
            InitQueryThreatHuntSummaryV2();
        }

        // This parameter set invokes a single graphql operation:
        // validateBulkThreatHunt.
        internal void ProcessRecord_ValidateBulk()
        {
            this._logger.name += " -ValidateBulk";
            // Create new graphql operation validateBulkThreatHunt
            InitQueryValidateBulkThreatHunt();
        }


        // Create new GraphQL Query:
        // threatHuntDetail(huntId: String!): ThreatHunt!
        internal void InitQueryThreatHuntDetail()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("huntId", "String!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryThreatHuntDetail",
                "($huntId: String!)",
                "ThreatHunt",
                Query.ThreatHuntDetail,
                Query.ThreatHuntDetailFieldSpec,
                @"# REQUIRED
$query.Var.huntId = $someString"
            );
        }

        // Create new GraphQL Query:
        // threatHuntDetailV2(huntId: String!): ThreatHuntDetailsV2!
        internal void InitQueryThreatHuntDetailV2()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("huntId", "String!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryThreatHuntDetailV2",
                "($huntId: String!)",
                "ThreatHuntDetailsV2",
                Query.ThreatHuntDetailV2,
                Query.ThreatHuntDetailV2FieldSpec,
                @"# REQUIRED
$query.Var.huntId = $someString"
            );
        }

        // Create new GraphQL Query:
        // threatHuntingObjectMatchedFiles(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     huntId: String!
        //     objectFid: UUID!
        //     filenameSearchFilter: String
        //     quarantinedFileMatchFilter: ThreatHuntQuarantinedMatchType
        //     threatHuntMatchedFilesSort: ThreatHuntMatchedFilesSort
        //   ): ThreatHuntingObjectFileMatchConnection!
        internal void InitQueryThreatHuntingObjectMatchedFiles()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("huntId", "String!"),
                Tuple.Create("objectFid", "UUID!"),
                Tuple.Create("filenameSearchFilter", "String"),
                Tuple.Create("quarantinedFileMatchFilter", "ThreatHuntQuarantinedMatchType"),
                Tuple.Create("threatHuntMatchedFilesSort", "ThreatHuntMatchedFilesSort"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryThreatHuntingObjectMatchedFiles",
                "($first: Int,$after: String,$last: Int,$before: String,$huntId: String!,$objectFid: UUID!,$filenameSearchFilter: String,$quarantinedFileMatchFilter: ThreatHuntQuarantinedMatchType,$threatHuntMatchedFilesSort: ThreatHuntMatchedFilesSort)",
                "ThreatHuntingObjectFileMatchConnection",
                Query.ThreatHuntingObjectMatchedFiles,
                Query.ThreatHuntingObjectMatchedFilesFieldSpec,
                @"# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# OPTIONAL
$query.Var.last = $someInt
# OPTIONAL
$query.Var.before = $someString
# REQUIRED
$query.Var.huntId = $someString
# REQUIRED
$query.Var.objectFid = $someString
# OPTIONAL
$query.Var.filenameSearchFilter = $someString
# OPTIONAL
$query.Var.quarantinedFileMatchFilter = $someThreatHuntQuarantinedMatchType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ThreatHuntQuarantinedMatchType]) for enum values.
# OPTIONAL
$query.Var.threatHuntMatchedFilesSort = @{
	# REQUIRED
	field = $someMatchedFilesSortByFields # Call [Enum]::GetValues([RubrikSecurityCloud.Types.MatchedFilesSortByFields]) for enum values.
	# REQUIRED
	sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
}"
            );
        }

        // Create new GraphQL Query:
        // threatHuntMatchedSnapshots(huntId: String!, objectFid: UUID!, matchIds: [Long!]!): ThreatHuntMatchedSnapshotsReply!
        internal void InitQueryThreatHuntMatchedSnapshots()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("huntId", "String!"),
                Tuple.Create("objectFid", "UUID!"),
                Tuple.Create("matchIds", "[Long!]!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryThreatHuntMatchedSnapshots",
                "($huntId: String!,$objectFid: UUID!,$matchIds: [Long!]!)",
                "ThreatHuntMatchedSnapshotsReply",
                Query.ThreatHuntMatchedSnapshots,
                Query.ThreatHuntMatchedSnapshotsFieldSpec,
                @"# REQUIRED
$query.Var.huntId = $someString
# REQUIRED
$query.Var.objectFid = $someString
# REQUIRED
$query.Var.matchIds = @(
	$someInt64
)"
            );
        }

        // Create new GraphQL Query:
        // threatHuntObjectMetrics(huntId: String!): ThreatHuntObjectMetricsReply!
        internal void InitQueryThreatHuntObjectMetrics()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("huntId", "String!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryThreatHuntObjectMetrics",
                "($huntId: String!)",
                "ThreatHuntObjectMetricsReply",
                Query.ThreatHuntObjectMetrics,
                Query.ThreatHuntObjectMetricsFieldSpec,
                @"# REQUIRED
$query.Var.huntId = $someString"
            );
        }

        // Create new GraphQL Query:
        // threatHuntResult(huntId: String!, objectId: String): ThreatHuntResult!
        internal void InitQueryThreatHuntResult()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("huntId", "String!"),
                Tuple.Create("objectId", "String"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryThreatHuntResult",
                "($huntId: String!,$objectId: String)",
                "ThreatHuntResult",
                Query.ThreatHuntResult,
                Query.ThreatHuntResultFieldSpec,
                @"# REQUIRED
$query.Var.huntId = $someString
# OPTIONAL
$query.Var.objectId = $someString"
            );
        }

        // Create new GraphQL Query:
        // threatHunts(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     beginTime: DateTime
        //     endTime: DateTime
        //     clusterUuidFilter: [String!]
        //     statusFilter: [ThreatHuntStatus!]
        //     matchesFoundFilter: [ThreatHuntMatchesFound!]
        //     quarantinedMatchesFilter: [ThreatHuntQuarantinedMatchType!]
        //   ): ThreatHuntConnection!
        internal void InitQueryThreatHunts()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("beginTime", "DateTime"),
                Tuple.Create("endTime", "DateTime"),
                Tuple.Create("clusterUuidFilter", "[String!]"),
                Tuple.Create("statusFilter", "[ThreatHuntStatus!]"),
                Tuple.Create("matchesFoundFilter", "[ThreatHuntMatchesFound!]"),
                Tuple.Create("quarantinedMatchesFilter", "[ThreatHuntQuarantinedMatchType!]"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryThreatHunts",
                "($first: Int,$after: String,$last: Int,$before: String,$beginTime: DateTime,$endTime: DateTime,$clusterUuidFilter: [String!],$statusFilter: [ThreatHuntStatus!],$matchesFoundFilter: [ThreatHuntMatchesFound!],$quarantinedMatchesFilter: [ThreatHuntQuarantinedMatchType!])",
                "ThreatHuntConnection",
                Query.ThreatHunts,
                Query.ThreatHuntsFieldSpec,
                @"# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# OPTIONAL
$query.Var.last = $someInt
# OPTIONAL
$query.Var.before = $someString
# OPTIONAL
$query.Var.beginTime = $someDateTime
# OPTIONAL
$query.Var.endTime = $someDateTime
# OPTIONAL
$query.Var.clusterUuidFilter = @(
	$someString
)
# OPTIONAL
$query.Var.statusFilter = @(
	$someThreatHuntStatus # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ThreatHuntStatus]) for enum values.
)
# OPTIONAL
$query.Var.matchesFoundFilter = @(
	$someThreatHuntMatchesFound # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ThreatHuntMatchesFound]) for enum values.
)
# OPTIONAL
$query.Var.quarantinedMatchesFilter = @(
	$someThreatHuntQuarantinedMatchType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ThreatHuntQuarantinedMatchType]) for enum values.
)"
            );
        }

        // Create new GraphQL Query:
        // threatHuntSummary(huntId: String!): ThreatHuntSummaryReply!
        internal void InitQueryThreatHuntSummary()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("huntId", "String!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryThreatHuntSummary",
                "($huntId: String!)",
                "ThreatHuntSummaryReply",
                Query.ThreatHuntSummary,
                Query.ThreatHuntSummaryFieldSpec,
                @"# REQUIRED
$query.Var.huntId = $someString"
            );
        }

        // Create new GraphQL Query:
        // threatHuntSummaryV2(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     huntId: String!
        //     objectTypeFilter: [String!]
        //     matchesFoundFilter: ThreatHuntMatchesFound
        //     quarantinedMatchesFilter: ThreatHuntQuarantinedMatchType
        //     threatHuntSummaryFilters: ThreatHuntSummaryFiltersInput
        //     threatHuntSummarySort: ThreatHuntSummarySort
        //     workloadNameSearch: String
        //   ): ThreatHuntResultObjectsSummaryConnection!
        internal void InitQueryThreatHuntSummaryV2()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("huntId", "String!"),
                Tuple.Create("objectTypeFilter", "[String!]"),
                Tuple.Create("matchesFoundFilter", "ThreatHuntMatchesFound"),
                Tuple.Create("quarantinedMatchesFilter", "ThreatHuntQuarantinedMatchType"),
                Tuple.Create("threatHuntSummaryFilters", "ThreatHuntSummaryFiltersInput"),
                Tuple.Create("threatHuntSummarySort", "ThreatHuntSummarySort"),
                Tuple.Create("workloadNameSearch", "String"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryThreatHuntSummaryV2",
                "($first: Int,$after: String,$last: Int,$before: String,$huntId: String!,$objectTypeFilter: [String!],$matchesFoundFilter: ThreatHuntMatchesFound,$quarantinedMatchesFilter: ThreatHuntQuarantinedMatchType,$threatHuntSummaryFilters: ThreatHuntSummaryFiltersInput,$threatHuntSummarySort: ThreatHuntSummarySort,$workloadNameSearch: String)",
                "ThreatHuntResultObjectsSummaryConnection",
                Query.ThreatHuntSummaryV2,
                Query.ThreatHuntSummaryV2FieldSpec,
                @"# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# OPTIONAL
$query.Var.last = $someInt
# OPTIONAL
$query.Var.before = $someString
# REQUIRED
$query.Var.huntId = $someString
# OPTIONAL
$query.Var.objectTypeFilter = @(
	$someString
)
# OPTIONAL
$query.Var.matchesFoundFilter = $someThreatHuntMatchesFound # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ThreatHuntMatchesFound]) for enum values.
# OPTIONAL
$query.Var.quarantinedMatchesFilter = $someThreatHuntQuarantinedMatchType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ThreatHuntQuarantinedMatchType]) for enum values.
# OPTIONAL
$query.Var.threatHuntSummaryFilters = @{
	# REQUIRED
	clusterUuids = @(
		$someString
	)
	# OPTIONAL
	cloudProviders = @(
		$someString
	)
	# REQUIRED
	matchTypes = @(
		$someIndicatorOfCompromiseKind # Call [Enum]::GetValues([RubrikSecurityCloud.Types.IndicatorOfCompromiseKind]) for enum values.
	)
	# REQUIRED
	objectScanStatus = @(
		$someThreatHuntObjectStatus # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ThreatHuntObjectStatus]) for enum values.
	)
}
# OPTIONAL
$query.Var.threatHuntSummarySort = @{
	# REQUIRED
	field = $someObjectSummariesSortByFields # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ObjectSummariesSortByFields]) for enum values.
	# REQUIRED
	sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
}
# OPTIONAL
$query.Var.workloadNameSearch = $someString"
            );
        }

        // Create new GraphQL Query:
        // validateBulkThreatHunt(input: ValidateBulkThreatHuntInput!): ValidateBulkThreatHuntResponse!
        internal void InitQueryValidateBulkThreatHunt()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "ValidateBulkThreatHuntInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryValidateBulkThreatHunt",
                "($input: ValidateBulkThreatHuntInput!)",
                "ValidateBulkThreatHuntResponse",
                Query.ValidateBulkThreatHunt,
                Query.ValidateBulkThreatHuntFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	objectInfos = @(
		@{
			# OPTIONAL
			objectFid = $someString
			# OPTIONAL
			clusterVersion = $someString
			# REQUIRED
			clusterUuid = $someString
		}
	)
}"
            );
        }


    } // class New_RscQueryThreatHunt
}