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
    /// Create a new RscQuery object for any of the 18
    /// operations in the 'Threat' API domain:
    /// AnalyticsEnablement, Feeds, HuntDetail, HuntDetailV2, HuntMatchedSnapshots, HuntObjectMetrics, HuntResult, HuntSummary, HuntSummaryV2, HuntingObjectMatchedFiles, Hunts, MonitoringMatchedFileDetails, MonitoringMatchedFileDetailsV2, MonitoringMatchedFiles, MonitoringMatchedObjects, MonitoringObjectEnablementStats, MonitoringObjects, or ValidateBulkHunt.
    /// </summary>
    /// <description>
    /// New-RscQueryThreat creates a new
    /// query object for operations
    /// in the 'Threat' API domain. It only creates a data structure,
    /// it does not execute the operation. This cmdlet does not need a
    /// connection to run. To execute the operation, either call Invoke()
    /// on the object returned by this cmdlet, or pass the object to
    /// Invoke-Rsc.
    /// There are 18 operations
    /// in the 'Threat' API domain. Select the operation this
    /// query is for by specifying the appropriate value for the
    /// -Operation parameter;
    /// one of: AnalyticsEnablement, Feeds, HuntDetail, HuntDetailV2, HuntMatchedSnapshots, HuntObjectMetrics, HuntResult, HuntSummary, HuntSummaryV2, HuntingObjectMatchedFiles, Hunts, MonitoringMatchedFileDetails, MonitoringMatchedFileDetailsV2, MonitoringMatchedFiles, MonitoringMatchedObjects, MonitoringObjectEnablementStats, MonitoringObjects, or ValidateBulkHunt.
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
    /// Runs the HuntDetail operation
    /// of the 'Threat' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Threat
    /// # API Operation: HuntDetail
    /// 
    /// $query = New-RscQueryThreat -Operation HuntDetail
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
    /// Runs the HuntDetailV2 operation
    /// of the 'Threat' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Threat
    /// # API Operation: HuntDetailV2
    /// 
    /// $query = New-RscQueryThreat -Operation HuntDetailV2
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
    /// Runs the HuntMatchedSnapshots operation
    /// of the 'Threat' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Threat
    /// # API Operation: HuntMatchedSnapshots
    /// 
    /// $query = New-RscQueryThreat -Operation HuntMatchedSnapshots
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
    /// Runs the HuntObjectMetrics operation
    /// of the 'Threat' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Threat
    /// # API Operation: HuntObjectMetrics
    /// 
    /// $query = New-RscQueryThreat -Operation HuntObjectMetrics
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
    /// Runs the HuntResult operation
    /// of the 'Threat' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Threat
    /// # API Operation: HuntResult
    /// 
    /// $query = New-RscQueryThreat -Operation HuntResult
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
    /// Runs the HuntSummary operation
    /// of the 'Threat' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Threat
    /// # API Operation: HuntSummary
    /// 
    /// $query = New-RscQueryThreat -Operation HuntSummary
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
    /// Runs the HuntSummaryV2 operation
    /// of the 'Threat' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Threat
    /// # API Operation: HuntSummaryV2
    /// 
    /// $query = New-RscQueryThreat -Operation HuntSummaryV2
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
    /// Runs the HuntingObjectMatchedFiles operation
    /// of the 'Threat' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Threat
    /// # API Operation: HuntingObjectMatchedFiles
    /// 
    /// $query = New-RscQueryThreat -Operation HuntingObjectMatchedFiles
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
    /// Runs the Hunts operation
    /// of the 'Threat' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Threat
    /// # API Operation: Hunts
    /// 
    /// $query = New-RscQueryThreat -Operation Hunts
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
    /// <example>
    /// Runs the ValidateBulkHunt operation
    /// of the 'Threat' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Threat
    /// # API Operation: ValidateBulkHunt
    /// 
    /// $query = New-RscQueryThreat -Operation ValidateBulkHunt
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
                "HuntDetail",
                "HuntDetailV2",
                "HuntMatchedSnapshots",
                "HuntObjectMetrics",
                "HuntResult",
                "HuntSummary",
                "HuntSummaryV2",
                "HuntingObjectMatchedFiles",
                "Hunts",
                "MonitoringMatchedFileDetails",
                "MonitoringMatchedFileDetailsV2",
                "MonitoringMatchedFiles",
                "MonitoringMatchedObjects",
                "MonitoringObjectEnablementStats",
                "MonitoringObjects",
                "ValidateBulkHunt",
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
                    case "HuntDetail":
                        this.ProcessRecord_HuntDetail();
                        break;
                    case "HuntDetailV2":
                        this.ProcessRecord_HuntDetailV2();
                        break;
                    case "HuntMatchedSnapshots":
                        this.ProcessRecord_HuntMatchedSnapshots();
                        break;
                    case "HuntObjectMetrics":
                        this.ProcessRecord_HuntObjectMetrics();
                        break;
                    case "HuntResult":
                        this.ProcessRecord_HuntResult();
                        break;
                    case "HuntSummary":
                        this.ProcessRecord_HuntSummary();
                        break;
                    case "HuntSummaryV2":
                        this.ProcessRecord_HuntSummaryV2();
                        break;
                    case "HuntingObjectMatchedFiles":
                        this.ProcessRecord_HuntingObjectMatchedFiles();
                        break;
                    case "Hunts":
                        this.ProcessRecord_Hunts();
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
                    case "ValidateBulkHunt":
                        this.ProcessRecord_ValidateBulkHunt();
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
        // threatHuntDetail.
        internal void ProcessRecord_HuntDetail()
        {
            this._logger.name += " -HuntDetail";
            // Create new graphql operation threatHuntDetail
            InitQueryThreatHuntDetail();
        }

        // This parameter set invokes a single graphql operation:
        // threatHuntDetailV2.
        internal void ProcessRecord_HuntDetailV2()
        {
            this._logger.name += " -HuntDetailV2";
            // Create new graphql operation threatHuntDetailV2
            InitQueryThreatHuntDetailV2();
        }

        // This parameter set invokes a single graphql operation:
        // threatHuntMatchedSnapshots.
        internal void ProcessRecord_HuntMatchedSnapshots()
        {
            this._logger.name += " -HuntMatchedSnapshots";
            // Create new graphql operation threatHuntMatchedSnapshots
            InitQueryThreatHuntMatchedSnapshots();
        }

        // This parameter set invokes a single graphql operation:
        // threatHuntObjectMetrics.
        internal void ProcessRecord_HuntObjectMetrics()
        {
            this._logger.name += " -HuntObjectMetrics";
            // Create new graphql operation threatHuntObjectMetrics
            InitQueryThreatHuntObjectMetrics();
        }

        // This parameter set invokes a single graphql operation:
        // threatHuntResult.
        internal void ProcessRecord_HuntResult()
        {
            this._logger.name += " -HuntResult";
            // Create new graphql operation threatHuntResult
            InitQueryThreatHuntResult();
        }

        // This parameter set invokes a single graphql operation:
        // threatHuntSummary.
        internal void ProcessRecord_HuntSummary()
        {
            this._logger.name += " -HuntSummary";
            // Create new graphql operation threatHuntSummary
            InitQueryThreatHuntSummary();
        }

        // This parameter set invokes a single graphql operation:
        // threatHuntSummaryV2.
        internal void ProcessRecord_HuntSummaryV2()
        {
            this._logger.name += " -HuntSummaryV2";
            // Create new graphql operation threatHuntSummaryV2
            InitQueryThreatHuntSummaryV2();
        }

        // This parameter set invokes a single graphql operation:
        // threatHuntingObjectMatchedFiles.
        internal void ProcessRecord_HuntingObjectMatchedFiles()
        {
            this._logger.name += " -HuntingObjectMatchedFiles";
            // Create new graphql operation threatHuntingObjectMatchedFiles
            InitQueryThreatHuntingObjectMatchedFiles();
        }

        // This parameter set invokes a single graphql operation:
        // threatHunts.
        internal void ProcessRecord_Hunts()
        {
            this._logger.name += " -Hunts";
            // Create new graphql operation threatHunts
            InitQueryThreatHunts();
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

        // This parameter set invokes a single graphql operation:
        // validateBulkThreatHunt.
        internal void ProcessRecord_ValidateBulkHunt()
        {
            this._logger.name += " -ValidateBulkHunt";
            // Create new graphql operation validateBulkThreatHunt
            InitQueryValidateBulkThreatHunt();
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


    } // class New_RscQueryThreat
}