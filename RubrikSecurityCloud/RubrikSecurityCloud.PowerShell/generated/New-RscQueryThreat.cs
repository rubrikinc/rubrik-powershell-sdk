// New-RscQueryThreat.cs
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
    /// Create a new RscQuery object for any of the 8
    /// operations in the 'Threat' API domain:
    /// AnalyticsEnablement, Feeds, MonitoringMatchedFileDetails, MonitoringMatchedFileDetailsV2, MonitoringMatchedFiles, MonitoringMatchedObjects, MonitoringObjectEnablementStats, or MonitoringObjects.
    /// </summary>
    /// <description>
    /// New-RscQueryThreat creates a new
    /// query object for operations
    /// in the 'Threat' API domain. It only creates a data structure,
    /// it does not execute the operation. This cmdlet does not need a
    /// connection to run. To execute the operation, either call Invoke()
    /// on the object returned by this cmdlet, or pass the object to
    /// Invoke-Rsc.
    /// There are 8 operations
    /// in the 'Threat' API domain. Select the operation this
    /// query is for by specifying the appropriate value for the
    /// -Operation parameter;
    /// one of: AnalyticsEnablement, Feeds, MonitoringMatchedFileDetails, MonitoringMatchedFileDetailsV2, MonitoringMatchedFiles, MonitoringMatchedObjects, MonitoringObjectEnablementStats, or MonitoringObjects.
    /// Each operation has its own set of variables that can be set with
    /// the -Var parameter. For more info about the variables, 
    /// call Info() on the object returned by this cmdlet, for example:
    /// (New-RscQueryThreat -AnalyticsEnablement).Info().
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
    /// (New-RscQueryThreat -AnalyticsEnablement).Info().
    /// You can combine a -Field parameter with patching parameters.
    /// -Field is applied first, then -FilePatch, -AddField and -RemoveField.
    ///
    /// </description>
    ///
    /// <example>
    /// Runs the AnalyticsEnablement operation
    /// of the 'Threat' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Threat
    /// # API Operation: AnalyticsEnablement
    /// 
    /// $query = New-RscQueryThreat -Operation AnalyticsEnablement
    /// 
    /// # No variables for this query.
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: ThreatAnalyticsEnablement
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the Feeds operation
    /// of the 'Threat' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Threat
    /// # API Operation: Feeds
    /// 
    /// $query = New-RscQueryThreat -Operation Feeds
    /// 
    /// # No variables for this query.
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: ListThreatFeedsResponse
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the MonitoringMatchedFileDetails operation
    /// of the 'Threat' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Threat
    /// # API Operation: MonitoringMatchedFileDetails
    /// 
    /// $query = New-RscQueryThreat -Operation MonitoringMatchedFileDetails
    /// 
    /// # REQUIRED
    /// $query.Var.matchId = $someInt64
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: ThreatMonitoringFileMatchDetailsReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the MonitoringMatchedFileDetailsV2 operation
    /// of the 'Threat' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Threat
    /// # API Operation: MonitoringMatchedFileDetailsV2
    /// 
    /// $query = New-RscQueryThreat -Operation MonitoringMatchedFileDetailsV2
    /// 
    /// # REQUIRED
    /// $query.Var.matchedSnapshotFid = $someString
    /// # REQUIRED
    /// $query.Var.filepath = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: ThreatMonitoringFileMatchDetailsV2
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the MonitoringMatchedFiles operation
    /// of the 'Threat' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Threat
    /// # API Operation: MonitoringMatchedFiles
    /// 
    /// $query = New-RscQueryThreat -Operation MonitoringMatchedFiles
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
    /// $query.Var.objectFid = $someString
    /// # OPTIONAL
    /// $query.Var.filenameSearchFilter = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: FileMatchConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the MonitoringMatchedObjects operation
    /// of the 'Threat' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Threat
    /// # API Operation: MonitoringMatchedObjects
    /// 
    /// $query = New-RscQueryThreat -Operation MonitoringMatchedObjects
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
    /// $query.Var.objectTypeFilter = @(
    /// 	$someString
    /// )
    /// # OPTIONAL
    /// $query.Var.workloadNameSearch = $someString
    /// # OPTIONAL
    /// $query.Var.matchTypeFilter = @(
    /// 	$someIndicatorOfCompromiseKind # Call [Enum]::GetValues([RubrikSecurityCloud.Types.IndicatorOfCompromiseKind]) for enum values.
    /// )
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: ThreatMonitoringMatchedObjectConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the MonitoringObjectEnablementStats operation
    /// of the 'Threat' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Threat
    /// # API Operation: MonitoringObjectEnablementStats
    /// 
    /// $query = New-RscQueryThreat -Operation MonitoringObjectEnablementStats
    /// 
    /// # REQUIRED
    /// $query.Var.beginTime = $someDateTime
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: GetThreatMonitoringObjectEnablementStatsResponse
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the MonitoringObjects operation
    /// of the 'Threat' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Threat
    /// # API Operation: MonitoringObjects
    /// 
    /// $query = New-RscQueryThreat -Operation MonitoringObjects
    /// 
    /// # REQUIRED
    /// $query.Var.beginTime = $someDateTime
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: ThreatMonitoringObjects
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
        "RscQueryThreat",
        DefaultParameterSetName = "Operation")
    ]
    public class New_RscQueryThreat : RscGqlPSCmdlet
    {
        [Parameter(
            Mandatory = true, 
            ParameterSetName = "Operation",
            HelpMessage = "API Operation. The set of operations depends on the API domain. See reference at: https://github.com/rubrikinc/rubrik-powershell-sdk/blob/main/docs/domains_and_operations.md",
            Position = 0,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = true)]
            [ValidateSet(
                "AnalyticsEnablement",
                "Feeds",
                "MonitoringMatchedFileDetails",
                "MonitoringMatchedFileDetailsV2",
                "MonitoringMatchedFiles",
                "MonitoringMatchedObjects",
                "MonitoringObjectEnablementStats",
                "MonitoringObjects",
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
                    case "AnalyticsEnablement":
                        this.ProcessRecord_AnalyticsEnablement();
                        break;
                    case "Feeds":
                        this.ProcessRecord_Feeds();
                        break;
                    case "MonitoringMatchedFileDetails":
                        this.ProcessRecord_MonitoringMatchedFileDetails();
                        break;
                    case "MonitoringMatchedFileDetailsV2":
                        this.ProcessRecord_MonitoringMatchedFileDetailsV2();
                        break;
                    case "MonitoringMatchedFiles":
                        this.ProcessRecord_MonitoringMatchedFiles();
                        break;
                    case "MonitoringMatchedObjects":
                        this.ProcessRecord_MonitoringMatchedObjects();
                        break;
                    case "MonitoringObjectEnablementStats":
                        this.ProcessRecord_MonitoringObjectEnablementStats();
                        break;
                    case "MonitoringObjects":
                        this.ProcessRecord_MonitoringObjects();
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
        // threatAnalyticsEnablement.
        internal void ProcessRecord_AnalyticsEnablement()
        {
            this._logger.name += " -AnalyticsEnablement";
            // Create new graphql operation threatAnalyticsEnablement
            InitQueryThreatAnalyticsEnablement();
        }

        // This parameter set invokes a single graphql operation:
        // threatFeeds.
        internal void ProcessRecord_Feeds()
        {
            this._logger.name += " -Feeds";
            // Create new graphql operation threatFeeds
            InitQueryThreatFeeds();
        }

        // This parameter set invokes a single graphql operation:
        // threatMonitoringMatchedFileDetails.
        internal void ProcessRecord_MonitoringMatchedFileDetails()
        {
            this._logger.name += " -MonitoringMatchedFileDetails";
            // Create new graphql operation threatMonitoringMatchedFileDetails
            InitQueryThreatMonitoringMatchedFileDetails();
        }

        // This parameter set invokes a single graphql operation:
        // threatMonitoringMatchedFileDetailsV2.
        internal void ProcessRecord_MonitoringMatchedFileDetailsV2()
        {
            this._logger.name += " -MonitoringMatchedFileDetailsV2";
            // Create new graphql operation threatMonitoringMatchedFileDetailsV2
            InitQueryThreatMonitoringMatchedFileDetailsV2();
        }

        // This parameter set invokes a single graphql operation:
        // threatMonitoringMatchedFiles.
        internal void ProcessRecord_MonitoringMatchedFiles()
        {
            this._logger.name += " -MonitoringMatchedFiles";
            // Create new graphql operation threatMonitoringMatchedFiles
            InitQueryThreatMonitoringMatchedFiles();
        }

        // This parameter set invokes a single graphql operation:
        // threatMonitoringMatchedObjects.
        internal void ProcessRecord_MonitoringMatchedObjects()
        {
            this._logger.name += " -MonitoringMatchedObjects";
            // Create new graphql operation threatMonitoringMatchedObjects
            InitQueryThreatMonitoringMatchedObjects();
        }

        // This parameter set invokes a single graphql operation:
        // threatMonitoringObjectEnablementStats.
        internal void ProcessRecord_MonitoringObjectEnablementStats()
        {
            this._logger.name += " -MonitoringObjectEnablementStats";
            // Create new graphql operation threatMonitoringObjectEnablementStats
            InitQueryThreatMonitoringObjectEnablementStats();
        }

        // This parameter set invokes a single graphql operation:
        // threatMonitoringObjects.
        internal void ProcessRecord_MonitoringObjects()
        {
            this._logger.name += " -MonitoringObjects";
            // Create new graphql operation threatMonitoringObjects
            InitQueryThreatMonitoringObjects();
        }


        // Create new GraphQL Query:
        // threatAnalyticsEnablement: ThreatAnalyticsEnablement!
        internal void InitQueryThreatAnalyticsEnablement()
        {
            Tuple<string, string>[] argDefs = {
            };
            Initialize(
                argDefs,
                "query",
                "QueryThreatAnalyticsEnablement",
                "",
                "ThreatAnalyticsEnablement",
                Query.ThreatAnalyticsEnablement,
                Query.ThreatAnalyticsEnablementFieldSpec,
                @""
            );
        }

        // Create new GraphQL Query:
        // threatFeeds: ListThreatFeedsResponse!
        internal void InitQueryThreatFeeds()
        {
            Tuple<string, string>[] argDefs = {
            };
            Initialize(
                argDefs,
                "query",
                "QueryThreatFeeds",
                "",
                "ListThreatFeedsResponse",
                Query.ThreatFeeds,
                Query.ThreatFeedsFieldSpec,
                @""
            );
        }

        // Create new GraphQL Query:
        // threatMonitoringMatchedFileDetails(matchId: Long!): ThreatMonitoringFileMatchDetailsReply!
        internal void InitQueryThreatMonitoringMatchedFileDetails()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("matchId", "Long!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryThreatMonitoringMatchedFileDetails",
                "($matchId: Long!)",
                "ThreatMonitoringFileMatchDetailsReply",
                Query.ThreatMonitoringMatchedFileDetails,
                Query.ThreatMonitoringMatchedFileDetailsFieldSpec,
                @"# REQUIRED
$query.Var.matchId = $someInt64"
            );
        }

        // Create new GraphQL Query:
        // threatMonitoringMatchedFileDetailsV2(matchedSnapshotFid: UUID!, filepath: String!): ThreatMonitoringFileMatchDetailsV2!
        internal void InitQueryThreatMonitoringMatchedFileDetailsV2()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("matchedSnapshotFid", "UUID!"),
                Tuple.Create("filepath", "String!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryThreatMonitoringMatchedFileDetailsV2",
                "($matchedSnapshotFid: UUID!,$filepath: String!)",
                "ThreatMonitoringFileMatchDetailsV2",
                Query.ThreatMonitoringMatchedFileDetailsV2,
                Query.ThreatMonitoringMatchedFileDetailsV2FieldSpec,
                @"# REQUIRED
$query.Var.matchedSnapshotFid = $someString
# REQUIRED
$query.Var.filepath = $someString"
            );
        }

        // Create new GraphQL Query:
        // threatMonitoringMatchedFiles(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     objectFid: UUID!
        //     filenameSearchFilter: String
        //   ): FileMatchConnection!
        internal void InitQueryThreatMonitoringMatchedFiles()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("objectFid", "UUID!"),
                Tuple.Create("filenameSearchFilter", "String"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryThreatMonitoringMatchedFiles",
                "($first: Int,$after: String,$last: Int,$before: String,$objectFid: UUID!,$filenameSearchFilter: String)",
                "FileMatchConnection",
                Query.ThreatMonitoringMatchedFiles,
                Query.ThreatMonitoringMatchedFilesFieldSpec,
                @"# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# OPTIONAL
$query.Var.last = $someInt
# OPTIONAL
$query.Var.before = $someString
# REQUIRED
$query.Var.objectFid = $someString
# OPTIONAL
$query.Var.filenameSearchFilter = $someString"
            );
        }

        // Create new GraphQL Query:
        // threatMonitoringMatchedObjects(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     beginTime: DateTime
        //     endTime: DateTime
        //     clusterUuidFilter: [String!]
        //     objectTypeFilter: [String!]
        //     workloadNameSearch: String
        //     matchTypeFilter: [IndicatorOfCompromiseKind!]
        //   ): ThreatMonitoringMatchedObjectConnection!
        internal void InitQueryThreatMonitoringMatchedObjects()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("beginTime", "DateTime"),
                Tuple.Create("endTime", "DateTime"),
                Tuple.Create("clusterUuidFilter", "[String!]"),
                Tuple.Create("objectTypeFilter", "[String!]"),
                Tuple.Create("workloadNameSearch", "String"),
                Tuple.Create("matchTypeFilter", "[IndicatorOfCompromiseKind!]"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryThreatMonitoringMatchedObjects",
                "($first: Int,$after: String,$last: Int,$before: String,$beginTime: DateTime,$endTime: DateTime,$clusterUuidFilter: [String!],$objectTypeFilter: [String!],$workloadNameSearch: String,$matchTypeFilter: [IndicatorOfCompromiseKind!])",
                "ThreatMonitoringMatchedObjectConnection",
                Query.ThreatMonitoringMatchedObjects,
                Query.ThreatMonitoringMatchedObjectsFieldSpec,
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
$query.Var.objectTypeFilter = @(
	$someString
)
# OPTIONAL
$query.Var.workloadNameSearch = $someString
# OPTIONAL
$query.Var.matchTypeFilter = @(
	$someIndicatorOfCompromiseKind # Call [Enum]::GetValues([RubrikSecurityCloud.Types.IndicatorOfCompromiseKind]) for enum values.
)"
            );
        }

        // Create new GraphQL Query:
        // threatMonitoringObjectEnablementStats(beginTime: DateTime!): GetThreatMonitoringObjectEnablementStatsResponse!
        internal void InitQueryThreatMonitoringObjectEnablementStats()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("beginTime", "DateTime!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryThreatMonitoringObjectEnablementStats",
                "($beginTime: DateTime!)",
                "GetThreatMonitoringObjectEnablementStatsResponse",
                Query.ThreatMonitoringObjectEnablementStats,
                Query.ThreatMonitoringObjectEnablementStatsFieldSpec,
                @"# REQUIRED
$query.Var.beginTime = $someDateTime"
            );
        }

        // Create new GraphQL Query:
        // threatMonitoringObjects(beginTime: DateTime!): ThreatMonitoringObjects!
        internal void InitQueryThreatMonitoringObjects()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("beginTime", "DateTime!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryThreatMonitoringObjects",
                "($beginTime: DateTime!)",
                "ThreatMonitoringObjects",
                Query.ThreatMonitoringObjects,
                Query.ThreatMonitoringObjectsFieldSpec,
                @"# REQUIRED
$query.Var.beginTime = $someDateTime"
            );
        }


    } // class New_RscQueryThreat
}