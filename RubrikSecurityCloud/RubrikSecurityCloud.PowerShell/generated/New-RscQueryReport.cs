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
    /// Create a new RscQuery object for any of the 11
    /// operations in the 'Report' API domain:
    /// ClusterMigrationCount, ClusterMigrationJobStatus, ClusterMigrationStatus, Data, DatabaseLogForCluster, DatabaseLogingPropertiesForCluster, ScheduledReport, ScheduledReports, Sonar, SonarContent, or SonarRow.
    /// </summary>
    /// <description>
    /// New-RscQueryReport creates a new
    /// query object for operations
    /// in the 'Report' API domain. It only creates a data structure,
    /// it does not execute the operation. This cmdlet does not need a
    /// connection to run. To execute the operation, either call Invoke()
    /// on the object returned by this cmdlet, or pass the object to
    /// Invoke-Rsc.
    /// There are 11 operations
    /// in the 'Report' API domain. Select the operation this
    /// query is for by specifying the appropriate value for the
    /// -Operation parameter;
    /// one of: ClusterMigrationCount, ClusterMigrationJobStatus, ClusterMigrationStatus, Data, DatabaseLogForCluster, DatabaseLogingPropertiesForCluster, ScheduledReport, ScheduledReports, Sonar, SonarContent, or SonarRow.
    /// Each operation has its own set of variables that can be set with
    /// the -Var parameter. For more info about the variables, 
    /// call Info() on the object returned by this cmdlet, for example:
    /// (New-RscQueryReport -ClusterMigrationCount).Info().
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
    /// (New-RscQueryReport -ClusterMigrationCount).Info().
    /// You can combine a -Field parameter with patching parameters.
    /// -Field is applied first, then -FilePatch, -AddField and -RemoveField.
    ///
    /// </description>
    ///
    /// <example>
    /// Runs the ClusterMigrationCount operation
    /// of the 'Report' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Report
    /// # API Operation: ClusterMigrationCount
    /// 
    /// $query = New-RscQueryReport -ClusterMigrationCount
    /// 
    /// # OPTIONAL
    /// $query.Var.clusterUuid = $someString
    /// # REQUIRED
    /// $query.Var.status = @(
    /// 	$someCdmReportMigrationStatus # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CdmReportMigrationStatus]) for enum values.
    /// )
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: ReportsMigrationCount
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the ClusterMigrationJobStatus operation
    /// of the 'Report' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Report
    /// # API Operation: ClusterMigrationJobStatus
    /// 
    /// $query = New-RscQueryReport -ClusterMigrationJobStatus
    /// 
    /// # OPTIONAL
    /// $query.Var.clusterUuid = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: ClusterReportMigrationJobStatus
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the ClusterMigrationStatus operation
    /// of the 'Report' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Report
    /// # API Operation: ClusterMigrationStatus
    /// 
    /// $query = New-RscQueryReport -ClusterMigrationStatus
    /// 
    /// # OPTIONAL
    /// $query.Var.clusterUuid = $someString
    /// # REQUIRED
    /// $query.Var.status = @(
    /// 	$someCdmReportMigrationStatus # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CdmReportMigrationStatus]) for enum values.
    /// )
    /// # OPTIONAL
    /// $query.Var.first = $someInt
    /// # OPTIONAL
    /// $query.Var.after = $someString
    /// # OPTIONAL
    /// $query.Var.last = $someInt
    /// # OPTIONAL
    /// $query.Var.before = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: ReportMigrationStatusConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
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
    /// Runs the DatabaseLogForCluster operation
    /// of the 'Report' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Report
    /// # API Operation: DatabaseLogForCluster
    /// 
    /// $query = New-RscQueryReport -DatabaseLogForCluster
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	name = $someString
    /// 	# OPTIONAL
    /// 	logBackupDelay = $someInt
    /// 	# OPTIONAL
    /// 	limit = $someInt
    /// 	# OPTIONAL
    /// 	offset = $someInt
    /// 	# OPTIONAL
    /// 	effectiveSlaDomainId = $someString
    /// 	# OPTIONAL
    /// 	databaseType = $someString
    /// 	# OPTIONAL
    /// 	location = $someString
    /// 	# OPTIONAL
    /// 	sortBy = $someV1QueryLogReportRequestSortBy # Call [Enum]::GetValues([RubrikSecurityCloud.Types.V1QueryLogReportRequestSortBy]) for enum values.
    /// 	# OPTIONAL
    /// 	sortOrder = $someV1QueryLogReportRequestSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.V1QueryLogReportRequestSortOrder]) for enum values.
    /// 	# REQUIRED
    /// 	clusterUuid = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: DbLogReportSummaryListReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the DatabaseLogingPropertiesForCluster operation
    /// of the 'Report' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Report
    /// # API Operation: DatabaseLogingPropertiesForCluster
    /// 
    /// $query = New-RscQueryReport -DatabaseLogingPropertiesForCluster
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	clusterUuid = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: DbLogReportProperties
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the ScheduledReport operation
    /// of the 'Report' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Report
    /// # API Operation: ScheduledReport
    /// 
    /// $query = New-RscQueryReport -ScheduledReport
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
    /// <example>
    /// Runs the ScheduledReports operation
    /// of the 'Report' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Report
    /// # API Operation: ScheduledReports
    /// 
    /// $query = New-RscQueryReport -ScheduledReports
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
    /// $query.Var.filter = @{
    /// 	# OPTIONAL
    /// 	reportId = $someInt
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: ScheduledReportConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the Sonar operation
    /// of the 'Report' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Report
    /// # API Operation: Sonar
    /// 
    /// $query = New-RscQueryReport -Sonar
    /// 
    /// # REQUIRED
    /// $query.Var.sonarReportGroupBy = $someDiscoveryReportGroupBy # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DiscoveryReportGroupBy]) for enum values.
    /// # OPTIONAL
    /// $query.Var.filter = @(
    /// 	$someString
    /// )
    /// # OPTIONAL
    /// $query.Var.timeFilter = @{
    /// 	# OPTIONAL
    /// 	endTime = $someString
    /// 	# OPTIONAL
    /// 	startTime = $someString
    /// 	# OPTIONAL
    /// 	timeDuration = $someTimeDuration # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TimeDuration]) for enum values.
    /// 	# OPTIONAL
    /// 	timezone = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: SonarReportConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the SonarContent operation
    /// of the 'Report' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Report
    /// # API Operation: SonarContent
    /// 
    /// $query = New-RscQueryReport -SonarContent
    /// 
    /// # REQUIRED
    /// $query.Var.groupBy = $someDiscoveryContentReportGroupBy # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DiscoveryContentReportGroupBy]) for enum values.
    /// # OPTIONAL
    /// $query.Var.sortBy = $someDiscoveryContentReportSortBy # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DiscoveryContentReportSortBy]) for enum values.
    /// # OPTIONAL
    /// $query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
    /// # OPTIONAL
    /// $query.Var.filters = @{
    /// 	# OPTIONAL
    /// 	search = $someString
    /// 	# OPTIONAL
    /// 	policyIds = @(
    /// 		$someString
    /// 	)
    /// 	# OPTIONAL
    /// 	clusterIds = @(
    /// 		$someString
    /// 	)
    /// 	# OPTIONAL
    /// 	applyWhitelists = $someBoolean
    /// 	# OPTIONAL
    /// 	subscriptionIds = @(
    /// 		$someString
    /// 	)
    /// 	# REQUIRED
    /// 	objectTypes = @(
    /// 		$someHierarchyObjectTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchyObjectTypeEnum]) for enum values.
    /// 	)
    /// }
    /// # REQUIRED
    /// $query.Var.day = $someString
    /// # REQUIRED
    /// $query.Var.timezone = $someString
    /// # REQUIRED
    /// $query.Var.workloadTypes = @(
    /// 	$someDataGovObjectType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DataGovObjectType]) for enum values.
    /// )
    /// # OPTIONAL
    /// $query.Var.first = $someInt
    /// # OPTIONAL
    /// $query.Var.after = $someString
    /// # OPTIONAL
    /// $query.Var.last = $someInt
    /// # OPTIONAL
    /// $query.Var.before = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: SonarContentReportConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the SonarRow operation
    /// of the 'Report' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Report
    /// # API Operation: SonarRow
    /// 
    /// $query = New-RscQueryReport -SonarRow
    /// 
    /// # OPTIONAL
    /// $query.Var.sortBy = $someDiscoveryReportSortBy # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DiscoveryReportSortBy]) for enum values.
    /// # OPTIONAL
    /// $query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
    /// # OPTIONAL
    /// $query.Var.filter = @(
    /// 	$someString
    /// )
    /// # OPTIONAL
    /// $query.Var.endTime = $someString
    /// # OPTIONAL
    /// $query.Var.first = $someInt
    /// # OPTIONAL
    /// $query.Var.after = $someString
    /// # OPTIONAL
    /// $query.Var.last = $someInt
    /// # OPTIONAL
    /// $query.Var.before = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: SonarReportRowConnection
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
        DefaultParameterSetName = "Operation")
    ]
    public class New_RscQueryReport : RscGqlPSCmdlet
    {
        [Parameter(
            Mandatory = true, 
            ParameterSetName = "Operation",
            HelpMessage = "API Operation. The set of operations depends on the API domain. See reference at: https://github.com/rubrikinc/rubrik-powershell-sdk/blob/main/docs/domains_and_operations.md",
            Position = 0,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = true)]
            [ValidateSet(
                "ClusterMigrationCount",
                "ClusterMigrationJobStatus",
                "ClusterMigrationStatus",
                "Data",
                "DatabaseLogForCluster",
                "DatabaseLogingPropertiesForCluster",
                "ScheduledReport",
                "ScheduledReports",
                "Sonar",
                "SonarContent",
                "SonarRow",
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
                    case "ClusterMigrationCount":
                        this.ProcessRecord_ClusterMigrationCount();
                        break;
                    case "ClusterMigrationJobStatus":
                        this.ProcessRecord_ClusterMigrationJobStatus();
                        break;
                    case "ClusterMigrationStatus":
                        this.ProcessRecord_ClusterMigrationStatus();
                        break;
                    case "Data":
                        this.ProcessRecord_Data();
                        break;
                    case "DatabaseLogForCluster":
                        this.ProcessRecord_DatabaseLogForCluster();
                        break;
                    case "DatabaseLogingPropertiesForCluster":
                        this.ProcessRecord_DatabaseLogingPropertiesForCluster();
                        break;
                    case "ScheduledReport":
                        this.ProcessRecord_ScheduledReport();
                        break;
                    case "ScheduledReports":
                        this.ProcessRecord_ScheduledReports();
                        break;
                    case "Sonar":
                        this.ProcessRecord_Sonar();
                        break;
                    case "SonarContent":
                        this.ProcessRecord_SonarContent();
                        break;
                    case "SonarRow":
                        this.ProcessRecord_SonarRow();
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
        // clusterReportMigrationCount.
        internal void ProcessRecord_ClusterMigrationCount()
        {
            this._logger.name += " -ClusterMigrationCount";
            // Create new graphql operation clusterReportMigrationCount
            InitQueryClusterReportMigrationCount();
        }

        // This parameter set invokes a single graphql operation:
        // clusterReportMigrationJobStatus.
        internal void ProcessRecord_ClusterMigrationJobStatus()
        {
            this._logger.name += " -ClusterMigrationJobStatus";
            // Create new graphql operation clusterReportMigrationJobStatus
            InitQueryClusterReportMigrationJobStatus();
        }

        // This parameter set invokes a single graphql operation:
        // clusterReportMigrationStatus.
        internal void ProcessRecord_ClusterMigrationStatus()
        {
            this._logger.name += " -ClusterMigrationStatus";
            // Create new graphql operation clusterReportMigrationStatus
            InitQueryClusterReportMigrationStatus();
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
        // databaseLogReportForCluster.
        internal void ProcessRecord_DatabaseLogForCluster()
        {
            this._logger.name += " -DatabaseLogForCluster";
            // Create new graphql operation databaseLogReportForCluster
            InitQueryDatabaseLogReportForCluster();
        }

        // This parameter set invokes a single graphql operation:
        // databaseLogReportingPropertiesForCluster.
        internal void ProcessRecord_DatabaseLogingPropertiesForCluster()
        {
            this._logger.name += " -DatabaseLogingPropertiesForCluster";
            // Create new graphql operation databaseLogReportingPropertiesForCluster
            InitQueryDatabaseLogReportingPropertiesForCluster();
        }

        // This parameter set invokes a single graphql operation:
        // scheduledReport.
        internal void ProcessRecord_ScheduledReport()
        {
            this._logger.name += " -ScheduledReport";
            // Create new graphql operation scheduledReport
            InitQueryScheduledReport();
        }

        // This parameter set invokes a single graphql operation:
        // scheduledReports.
        internal void ProcessRecord_ScheduledReports()
        {
            this._logger.name += " -ScheduledReports";
            // Create new graphql operation scheduledReports
            InitQueryScheduledReports();
        }

        // This parameter set invokes a single graphql operation:
        // sonarReport.
        internal void ProcessRecord_Sonar()
        {
            this._logger.name += " -Sonar";
            // Create new graphql operation sonarReport
            InitQuerySonarReport();
        }

        // This parameter set invokes a single graphql operation:
        // sonarContentReport.
        internal void ProcessRecord_SonarContent()
        {
            this._logger.name += " -SonarContent";
            // Create new graphql operation sonarContentReport
            InitQuerySonarContentReport();
        }

        // This parameter set invokes a single graphql operation:
        // sonarReportRow.
        internal void ProcessRecord_SonarRow()
        {
            this._logger.name += " -SonarRow";
            // Create new graphql operation sonarReportRow
            InitQuerySonarReportRow();
        }


        // Create new GraphQL Query:
        // clusterReportMigrationCount(clusterUuid: UUID, status: [CdmReportMigrationStatus!]!): ReportsMigrationCount!
        internal void InitQueryClusterReportMigrationCount()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("clusterUuid", "UUID"),
                Tuple.Create("status", "[CdmReportMigrationStatus!]!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryClusterReportMigrationCount",
                "($clusterUuid: UUID,$status: [CdmReportMigrationStatus!]!)",
                "ReportsMigrationCount",
                Query.ClusterReportMigrationCount_ObjectFieldSpec,
                Query.ClusterReportMigrationCountFieldSpec,
                @"# OPTIONAL
$query.Var.clusterUuid = $someString
# REQUIRED
$query.Var.status = @(
	$someCdmReportMigrationStatus # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CdmReportMigrationStatus]) for enum values.
)"
            );
        }

        // Create new GraphQL Query:
        // clusterReportMigrationJobStatus(clusterUuid: UUID): ClusterReportMigrationJobStatus!
        internal void InitQueryClusterReportMigrationJobStatus()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("clusterUuid", "UUID"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryClusterReportMigrationJobStatus",
                "($clusterUuid: UUID)",
                "ClusterReportMigrationJobStatus",
                Query.ClusterReportMigrationJobStatus_ObjectFieldSpec,
                Query.ClusterReportMigrationJobStatusFieldSpec,
                @"# OPTIONAL
$query.Var.clusterUuid = $someString"
            );
        }

        // Create new GraphQL Query:
        // clusterReportMigrationStatus(
        //     clusterUuid: UUID
        //     status: [CdmReportMigrationStatus!]!
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //   ): ReportMigrationStatusConnection!
        internal void InitQueryClusterReportMigrationStatus()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("clusterUuid", "UUID"),
                Tuple.Create("status", "[CdmReportMigrationStatus!]!"),
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryClusterReportMigrationStatus",
                "($clusterUuid: UUID,$status: [CdmReportMigrationStatus!]!,$first: Int,$after: String,$last: Int,$before: String)",
                "ReportMigrationStatusConnection",
                Query.ClusterReportMigrationStatus_ObjectFieldSpec,
                Query.ClusterReportMigrationStatusFieldSpec,
                @"# OPTIONAL
$query.Var.clusterUuid = $someString
# REQUIRED
$query.Var.status = @(
	$someCdmReportMigrationStatus # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CdmReportMigrationStatus]) for enum values.
)
# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# OPTIONAL
$query.Var.last = $someInt
# OPTIONAL
$query.Var.before = $someString"
            );
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
        // databaseLogReportForCluster(input: QueryLogReportInput!): DbLogReportSummaryListReply!
        internal void InitQueryDatabaseLogReportForCluster()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "QueryLogReportInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryDatabaseLogReportForCluster",
                "($input: QueryLogReportInput!)",
                "DbLogReportSummaryListReply",
                Query.DatabaseLogReportForCluster_ObjectFieldSpec,
                Query.DatabaseLogReportForClusterFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	name = $someString
	# OPTIONAL
	logBackupDelay = $someInt
	# OPTIONAL
	limit = $someInt
	# OPTIONAL
	offset = $someInt
	# OPTIONAL
	effectiveSlaDomainId = $someString
	# OPTIONAL
	databaseType = $someString
	# OPTIONAL
	location = $someString
	# OPTIONAL
	sortBy = $someV1QueryLogReportRequestSortBy # Call [Enum]::GetValues([RubrikSecurityCloud.Types.V1QueryLogReportRequestSortBy]) for enum values.
	# OPTIONAL
	sortOrder = $someV1QueryLogReportRequestSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.V1QueryLogReportRequestSortOrder]) for enum values.
	# REQUIRED
	clusterUuid = $someString
}"
            );
        }

        // Create new GraphQL Query:
        // databaseLogReportingPropertiesForCluster(input: QueryReportPropertiesInput!): DbLogReportProperties!
        internal void InitQueryDatabaseLogReportingPropertiesForCluster()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "QueryReportPropertiesInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryDatabaseLogReportingPropertiesForCluster",
                "($input: QueryReportPropertiesInput!)",
                "DbLogReportProperties",
                Query.DatabaseLogReportingPropertiesForCluster_ObjectFieldSpec,
                Query.DatabaseLogReportingPropertiesForClusterFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	clusterUuid = $someString
}"
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

        // Create new GraphQL Query:
        // scheduledReports(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     filter: ScheduledReportFilterInput
        //   ): ScheduledReportConnection!
        internal void InitQueryScheduledReports()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("filter", "ScheduledReportFilterInput"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryScheduledReports",
                "($first: Int,$after: String,$last: Int,$before: String,$filter: ScheduledReportFilterInput)",
                "ScheduledReportConnection",
                Query.ScheduledReports_ObjectFieldSpec,
                Query.ScheduledReportsFieldSpec,
                @"# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# OPTIONAL
$query.Var.last = $someInt
# OPTIONAL
$query.Var.before = $someString
# OPTIONAL
$query.Var.filter = @{
	# OPTIONAL
	reportId = $someInt
}"
            );
        }

        // Create new GraphQL Query:
        // sonarReport(sonarReportGroupBy: DiscoveryReportGroupBy!, filter: [String!], timeFilter: TimeFilterInput): SonarReportConnection!
        internal void InitQuerySonarReport()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("sonarReportGroupBy", "DiscoveryReportGroupBy!"),
                Tuple.Create("filter", "[String!]"),
                Tuple.Create("timeFilter", "TimeFilterInput"),
            };
            Initialize(
                argDefs,
                "query",
                "QuerySonarReport",
                "($sonarReportGroupBy: DiscoveryReportGroupBy!,$filter: [String!],$timeFilter: TimeFilterInput)",
                "SonarReportConnection",
                Query.SonarReport_ObjectFieldSpec,
                Query.SonarReportFieldSpec,
                @"# REQUIRED
$query.Var.sonarReportGroupBy = $someDiscoveryReportGroupBy # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DiscoveryReportGroupBy]) for enum values.
# OPTIONAL
$query.Var.filter = @(
	$someString
)
# OPTIONAL
$query.Var.timeFilter = @{
	# OPTIONAL
	endTime = $someString
	# OPTIONAL
	startTime = $someString
	# OPTIONAL
	timeDuration = $someTimeDuration # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TimeDuration]) for enum values.
	# OPTIONAL
	timezone = $someString
}"
            );
        }

        // Create new GraphQL Query:
        // sonarContentReport(
        //     groupBy: DiscoveryContentReportGroupBy!
        //     sortBy: DiscoveryContentReportSortBy
        //     sortOrder: SortOrder
        //     filters: SonarContentReportFilter
        //     day: String!
        //     timezone: String!
        //     workloadTypes: [DataGovObjectType!]! = []
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //   ): SonarContentReportConnection!
        internal void InitQuerySonarContentReport()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("groupBy", "DiscoveryContentReportGroupBy!"),
                Tuple.Create("sortBy", "DiscoveryContentReportSortBy"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("filters", "SonarContentReportFilter"),
                Tuple.Create("day", "String!"),
                Tuple.Create("timezone", "String!"),
                Tuple.Create("workloadTypes", "[DataGovObjectType!]!"),
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
            };
            Initialize(
                argDefs,
                "query",
                "QuerySonarContentReport",
                "($groupBy: DiscoveryContentReportGroupBy!,$sortBy: DiscoveryContentReportSortBy,$sortOrder: SortOrder,$filters: SonarContentReportFilter,$day: String!,$timezone: String!,$workloadTypes: [DataGovObjectType!]!,$first: Int,$after: String,$last: Int,$before: String)",
                "SonarContentReportConnection",
                Query.SonarContentReport_ObjectFieldSpec,
                Query.SonarContentReportFieldSpec,
                @"# REQUIRED
$query.Var.groupBy = $someDiscoveryContentReportGroupBy # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DiscoveryContentReportGroupBy]) for enum values.
# OPTIONAL
$query.Var.sortBy = $someDiscoveryContentReportSortBy # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DiscoveryContentReportSortBy]) for enum values.
# OPTIONAL
$query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$query.Var.filters = @{
	# OPTIONAL
	search = $someString
	# OPTIONAL
	policyIds = @(
		$someString
	)
	# OPTIONAL
	clusterIds = @(
		$someString
	)
	# OPTIONAL
	applyWhitelists = $someBoolean
	# OPTIONAL
	subscriptionIds = @(
		$someString
	)
	# REQUIRED
	objectTypes = @(
		$someHierarchyObjectTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchyObjectTypeEnum]) for enum values.
	)
}
# REQUIRED
$query.Var.day = $someString
# REQUIRED
$query.Var.timezone = $someString
# REQUIRED
$query.Var.workloadTypes = @(
	$someDataGovObjectType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DataGovObjectType]) for enum values.
)
# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# OPTIONAL
$query.Var.last = $someInt
# OPTIONAL
$query.Var.before = $someString"
            );
        }

        // Create new GraphQL Query:
        // sonarReportRow(
        //     sortBy: DiscoveryReportSortBy
        //     sortOrder: SortOrder
        //     filter: [String!]
        //     endTime: String
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //   ): SonarReportRowConnection!
        internal void InitQuerySonarReportRow()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("sortBy", "DiscoveryReportSortBy"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("filter", "[String!]"),
                Tuple.Create("endTime", "String"),
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
            };
            Initialize(
                argDefs,
                "query",
                "QuerySonarReportRow",
                "($sortBy: DiscoveryReportSortBy,$sortOrder: SortOrder,$filter: [String!],$endTime: String,$first: Int,$after: String,$last: Int,$before: String)",
                "SonarReportRowConnection",
                Query.SonarReportRow_ObjectFieldSpec,
                Query.SonarReportRowFieldSpec,
                @"# OPTIONAL
$query.Var.sortBy = $someDiscoveryReportSortBy # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DiscoveryReportSortBy]) for enum values.
# OPTIONAL
$query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$query.Var.filter = @(
	$someString
)
# OPTIONAL
$query.Var.endTime = $someString
# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# OPTIONAL
$query.Var.last = $someInt
# OPTIONAL
$query.Var.before = $someString"
            );
        }


    } // class New_RscQueryReport
}