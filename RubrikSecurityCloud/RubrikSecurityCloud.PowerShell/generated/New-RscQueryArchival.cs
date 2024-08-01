// New-RscQueryArchival.cs
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
    /// operations in the 'Archival' API domain:
    /// BandwidthStats, Entities, HierarchyObjectRecoveryTarget, IsTotpMandatoryInTargetVersion, LocationEncryptionDetails, LocationEncryptionJobsSummary, RcsLocationsConsumptionStats, StorageUsage, Target, TargetMapping, TargetMappings, or Targets.
    /// </summary>
    /// <description>
    /// New-RscQueryArchival creates a new
    /// query object for operations
    /// in the 'Archival' API domain. It only creates a data structure,
    /// it does not execute the operation. This cmdlet does not need a
    /// connection to run. To execute the operation, either call Invoke()
    /// on the object returned by this cmdlet, or pass the object to
    /// Invoke-Rsc.
    /// There are 12 operations
    /// in the 'Archival' API domain. Select the operation this
    /// query is for by specifying the appropriate value for the
    /// -Operation parameter;
    /// one of: BandwidthStats, Entities, HierarchyObjectRecoveryTarget, IsTotpMandatoryInTargetVersion, LocationEncryptionDetails, LocationEncryptionJobsSummary, RcsLocationsConsumptionStats, StorageUsage, Target, TargetMapping, TargetMappings, or Targets.
    /// Each operation has its own set of variables that can be set with
    /// the -Var parameter. For more info about the variables, 
    /// call Info() on the object returned by this cmdlet, for example:
    /// (New-RscQueryArchival -BandwidthStats).Info().
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
    /// (New-RscQueryArchival -BandwidthStats).Info().
    /// You can combine a -Field parameter with patching parameters.
    /// -Field is applied first, then -FilePatch, -AddField and -RemoveField.
    ///
    /// </description>
    ///
    /// <example>
    /// Runs the BandwidthStats operation
    /// of the 'Archival' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Archival
    /// # API Operation: BandwidthStats
    /// 
    /// $query = New-RscQueryArchival -BandwidthStats
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	dataLocationId = $someString
    /// 	# OPTIONAL
    /// 	range = $someString
    /// 	# OPTIONAL
    /// 	bandwidthType = $someArchivalBandwidthStatsRequestType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ArchivalBandwidthStatsRequestType]) for enum values.
    /// 	# REQUIRED
    /// 	clusterUuid = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: ArchivalBandwidthStatsReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the Entities operation
    /// of the 'Archival' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Archival
    /// # API Operation: Entities
    /// 
    /// $query = New-RscQueryArchival -Entities
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
    /// $query.Var.filter = @(
    /// 	@{
    /// 		# OPTIONAL
    /// 		field = $someArchivalEntityQueryFilterField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ArchivalEntityQueryFilterField]) for enum values.
    /// 		# OPTIONAL
    /// 		textList = @(
    /// 			$someString
    /// 		)
    /// }
    /// )
    /// # OPTIONAL
    /// $query.Var.sortBy = $someArchivalEntityQuerySortByField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ArchivalEntityQuerySortByField]) for enum values.
    /// # OPTIONAL
    /// $query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: ArchivalEntityConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the HierarchyObjectRecoveryTarget operation
    /// of the 'Archival' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Archival
    /// # API Operation: HierarchyObjectRecoveryTarget
    /// 
    /// $query = New-RscQueryArchival -HierarchyObjectRecoveryTarget
    /// 
    /// # REQUIRED
    /// $query.Var.fid = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: HierarchyObject
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the IsTotpMandatoryInTargetVersion operation
    /// of the 'Archival' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Archival
    /// # API Operation: IsTotpMandatoryInTargetVersion
    /// 
    /// $query = New-RscQueryArchival -IsTotpMandatoryInTargetVersion
    /// 
    /// # REQUIRED
    /// $query.Var.version = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: System.Boolean
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the LocationEncryptionDetails operation
    /// of the 'Archival' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Archival
    /// # API Operation: LocationEncryptionDetails
    /// 
    /// $query = New-RscQueryArchival -LocationEncryptionDetails
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
    /// $query.Var.nameSearchPrefix = $someString
    /// # OPTIONAL
    /// $query.Var.sortBy = $someQueryArchivalLocationsEncryptionDetailsSortByField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.QueryArchivalLocationsEncryptionDetailsSortByField]) for enum values.
    /// # REQUIRED
    /// $query.Var.archivalLocationRekeyStatusFilterArg = @(
    /// 	$someArchivalLocationEncryptionJobStatus # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ArchivalLocationEncryptionJobStatus]) for enum values.
    /// )
    /// # REQUIRED
    /// $query.Var.archivalLocationRotationStatusFilterArg = @(
    /// 	$someArchivalLocationEncryptionJobStatus # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ArchivalLocationEncryptionJobStatus]) for enum values.
    /// )
    /// # REQUIRED
    /// $query.Var.archivalLocationKeyTypeFilterArg = @(
    /// 	$someArchivalLocationEncryptionKeyType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ArchivalLocationEncryptionKeyType]) for enum values.
    /// )
    /// # REQUIRED
    /// $query.Var.archivalLocationEncryptionStatusFilterArg = @(
    /// 	$someArchivalLocationEncryptionStatusFilter # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ArchivalLocationEncryptionStatusFilter]) for enum values.
    /// )
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: ArchivalLocationEncryptionDetailsConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the LocationEncryptionJobsSummary operation
    /// of the 'Archival' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Archival
    /// # API Operation: LocationEncryptionJobsSummary
    /// 
    /// $query = New-RscQueryArchival -LocationEncryptionJobsSummary
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	locationId = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: ArchivalLocationEncryptionJobsSummary
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the RcsLocationsConsumptionStats operation
    /// of the 'Archival' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Archival
    /// # API Operation: RcsLocationsConsumptionStats
    /// 
    /// $query = New-RscQueryArchival -RcsLocationsConsumptionStats
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
    /// Runs the StorageUsage operation
    /// of the 'Archival' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Archival
    /// # API Operation: StorageUsage
    /// 
    /// $query = New-RscQueryArchival -StorageUsage
    /// 
    /// # REQUIRED
    /// $query.Var.input = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: List&lt;ArchivalStorageUsage&gt;
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the Target operation
    /// of the 'Archival' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Archival
    /// # API Operation: Target
    /// 
    /// $query = New-RscQueryArchival -Target
    /// 
    /// # REQUIRED
    /// $query.Var.input = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: Target
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the TargetMapping operation
    /// of the 'Archival' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Archival
    /// # API Operation: TargetMapping
    /// 
    /// $query = New-RscQueryArchival -TargetMapping
    /// 
    /// # REQUIRED
    /// $query.Var.targetMappingId = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: TargetMapping
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the TargetMappings operation
    /// of the 'Archival' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Archival
    /// # API Operation: TargetMappings
    /// 
    /// $query = New-RscQueryArchival -TargetMappings
    /// 
    /// # OPTIONAL
    /// $query.Var.sortBy = $someArchivalGroupQuerySortByField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ArchivalGroupQuerySortByField]) for enum values.
    /// # OPTIONAL
    /// $query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
    /// # OPTIONAL
    /// $query.Var.filter = @(
    /// 	@{
    /// 		# OPTIONAL
    /// 		field = $someTargetMappingQueryFilterField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TargetMappingQueryFilterField]) for enum values.
    /// 		# OPTIONAL
    /// 		text = $someString
    /// 		# OPTIONAL
    /// 		textList = @(
    /// 			$someString
    /// 		)
    /// }
    /// )
    /// # OPTIONAL
    /// $query.Var.contextFilter = $someContextFilterTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ContextFilterTypeEnum]) for enum values.
    /// # OPTIONAL
    /// $query.Var.isRcsStatsRequired = $someBoolean
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: List&lt;TargetMapping&gt;
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the Targets operation
    /// of the 'Archival' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Archival
    /// # API Operation: Targets
    /// 
    /// $query = New-RscQueryArchival -Targets
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
    /// $query.Var.sortBy = $someArchivalLocationQuerySortByField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ArchivalLocationQuerySortByField]) for enum values.
    /// # OPTIONAL
    /// $query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
    /// # OPTIONAL
    /// $query.Var.filter = @(
    /// 	@{
    /// 		# OPTIONAL
    /// 		field = $someTargetQueryFilterField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TargetQueryFilterField]) for enum values.
    /// 		# OPTIONAL
    /// 		text = $someString
    /// 		# OPTIONAL
    /// 		textList = @(
    /// 			$someString
    /// 		)
    /// }
    /// )
    /// # OPTIONAL
    /// $query.Var.contextFilter = $someContextFilterTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ContextFilterTypeEnum]) for enum values.
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: TargetConnection
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
        "RscQueryArchival",
        DefaultParameterSetName = "Operation")
    ]
    public class New_RscQueryArchival : RscGqlPSCmdlet
    {
        [Parameter(
            Mandatory = true, 
            ParameterSetName = "Operation",
            HelpMessage = "API Operation. The set of operations depends on the API domain. See reference at: https://github.com/rubrikinc/rubrik-powershell-sdk/blob/main/docs/domains_and_operations.md",
            Position = 0,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = true)]
            [ValidateSet(
                "BandwidthStats",
                "Entities",
                "HierarchyObjectRecoveryTarget",
                "IsTotpMandatoryInTargetVersion",
                "LocationEncryptionDetails",
                "LocationEncryptionJobsSummary",
                "RcsLocationsConsumptionStats",
                "StorageUsage",
                "Target",
                "TargetMapping",
                "TargetMappings",
                "Targets",
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
                    case "BandwidthStats":
                        this.ProcessRecord_BandwidthStats();
                        break;
                    case "Entities":
                        this.ProcessRecord_Entities();
                        break;
                    case "HierarchyObjectRecoveryTarget":
                        this.ProcessRecord_HierarchyObjectRecoveryTarget();
                        break;
                    case "IsTotpMandatoryInTargetVersion":
                        this.ProcessRecord_IsTotpMandatoryInTargetVersion();
                        break;
                    case "LocationEncryptionDetails":
                        this.ProcessRecord_LocationEncryptionDetails();
                        break;
                    case "LocationEncryptionJobsSummary":
                        this.ProcessRecord_LocationEncryptionJobsSummary();
                        break;
                    case "RcsLocationsConsumptionStats":
                        this.ProcessRecord_RcsLocationsConsumptionStats();
                        break;
                    case "StorageUsage":
                        this.ProcessRecord_StorageUsage();
                        break;
                    case "Target":
                        this.ProcessRecord_Target();
                        break;
                    case "TargetMapping":
                        this.ProcessRecord_TargetMapping();
                        break;
                    case "TargetMappings":
                        this.ProcessRecord_TargetMappings();
                        break;
                    case "Targets":
                        this.ProcessRecord_Targets();
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
        // archivalBandwidthStats.
        internal void ProcessRecord_BandwidthStats()
        {
            this._logger.name += " -BandwidthStats";
            // Create new graphql operation archivalBandwidthStats
            InitQueryArchivalBandwidthStats();
        }

        // This parameter set invokes a single graphql operation:
        // archivalEntities.
        internal void ProcessRecord_Entities()
        {
            this._logger.name += " -Entities";
            // Create new graphql operation archivalEntities
            InitQueryArchivalEntities();
        }

        // This parameter set invokes a single graphql operation:
        // hierarchyObjectRecoveryTarget.
        internal void ProcessRecord_HierarchyObjectRecoveryTarget()
        {
            this._logger.name += " -HierarchyObjectRecoveryTarget";
            // Create new graphql operation hierarchyObjectRecoveryTarget
            InitQueryHierarchyObjectRecoveryTarget();
        }

        // This parameter set invokes a single graphql operation:
        // isTotpMandatoryInTargetVersion.
        internal void ProcessRecord_IsTotpMandatoryInTargetVersion()
        {
            this._logger.name += " -IsTotpMandatoryInTargetVersion";
            // Create new graphql operation isTotpMandatoryInTargetVersion
            InitQueryIsTotpMandatoryInTargetVersion();
        }

        // This parameter set invokes a single graphql operation:
        // archivalLocationEncryptionDetails.
        internal void ProcessRecord_LocationEncryptionDetails()
        {
            this._logger.name += " -LocationEncryptionDetails";
            // Create new graphql operation archivalLocationEncryptionDetails
            InitQueryArchivalLocationEncryptionDetails();
        }

        // This parameter set invokes a single graphql operation:
        // archivalLocationEncryptionJobsSummary.
        internal void ProcessRecord_LocationEncryptionJobsSummary()
        {
            this._logger.name += " -LocationEncryptionJobsSummary";
            // Create new graphql operation archivalLocationEncryptionJobsSummary
            InitQueryArchivalLocationEncryptionJobsSummary();
        }

        // This parameter set invokes a single graphql operation:
        // rcsArchivalLocationsConsumptionStats.
        internal void ProcessRecord_RcsLocationsConsumptionStats()
        {
            this._logger.name += " -RcsLocationsConsumptionStats";
            // Create new graphql operation rcsArchivalLocationsConsumptionStats
            InitQueryRcsArchivalLocationsConsumptionStats();
        }

        // This parameter set invokes a single graphql operation:
        // archivalStorageUsage.
        internal void ProcessRecord_StorageUsage()
        {
            this._logger.name += " -StorageUsage";
            // Create new graphql operation archivalStorageUsage
            InitQueryArchivalStorageUsage();
        }

        // This parameter set invokes a single graphql operation:
        // target.
        internal void ProcessRecord_Target()
        {
            this._logger.name += " -Target";
            // Create new graphql operation target
            InitQueryTarget();
        }

        // This parameter set invokes a single graphql operation:
        // targetMapping.
        internal void ProcessRecord_TargetMapping()
        {
            this._logger.name += " -TargetMapping";
            // Create new graphql operation targetMapping
            InitQueryTargetMapping();
        }

        // This parameter set invokes a single graphql operation:
        // allTargetMappings.
        internal void ProcessRecord_TargetMappings()
        {
            this._logger.name += " -TargetMappings";
            // Create new graphql operation allTargetMappings
            InitQueryAllTargetMappings();
        }

        // This parameter set invokes a single graphql operation:
        // targets.
        internal void ProcessRecord_Targets()
        {
            this._logger.name += " -Targets";
            // Create new graphql operation targets
            InitQueryTargets();
        }


        // Create new GraphQL Query:
        // archivalBandwidthStats(input: ArchivalBandwidthStatsInput!): ArchivalBandwidthStatsReply!
        internal void InitQueryArchivalBandwidthStats()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "ArchivalBandwidthStatsInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryArchivalBandwidthStats",
                "($input: ArchivalBandwidthStatsInput!)",
                "ArchivalBandwidthStatsReply",
                Query.ArchivalBandwidthStats,
                Query.ArchivalBandwidthStatsFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	dataLocationId = $someString
	# OPTIONAL
	range = $someString
	# OPTIONAL
	bandwidthType = $someArchivalBandwidthStatsRequestType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ArchivalBandwidthStatsRequestType]) for enum values.
	# REQUIRED
	clusterUuid = $someString
}"
            );
        }

        // Create new GraphQL Query:
        // archivalEntities(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     filter: [ArchivalEntityFilterInput!]
        //     sortBy: ArchivalEntityQuerySortByField
        //     sortOrder: SortOrder
        //   ): ArchivalEntityConnection!
        internal void InitQueryArchivalEntities()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("filter", "[ArchivalEntityFilterInput!]"),
                Tuple.Create("sortBy", "ArchivalEntityQuerySortByField"),
                Tuple.Create("sortOrder", "SortOrder"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryArchivalEntities",
                "($first: Int,$after: String,$last: Int,$before: String,$filter: [ArchivalEntityFilterInput!],$sortBy: ArchivalEntityQuerySortByField,$sortOrder: SortOrder)",
                "ArchivalEntityConnection",
                Query.ArchivalEntities,
                Query.ArchivalEntitiesFieldSpec,
                @"# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# OPTIONAL
$query.Var.last = $someInt
# OPTIONAL
$query.Var.before = $someString
# OPTIONAL
$query.Var.filter = @(
	@{
		# OPTIONAL
		field = $someArchivalEntityQueryFilterField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ArchivalEntityQueryFilterField]) for enum values.
		# OPTIONAL
		textList = @(
			$someString
		)
}
)
# OPTIONAL
$query.Var.sortBy = $someArchivalEntityQuerySortByField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ArchivalEntityQuerySortByField]) for enum values.
# OPTIONAL
$query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values."
            );
        }

        // Create new GraphQL Query:
        // hierarchyObjectRecoveryTarget(fid: UUID!): HierarchyObject!
        internal void InitQueryHierarchyObjectRecoveryTarget()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryHierarchyObjectRecoveryTarget",
                "($fid: UUID!)",
                "HierarchyObject",
                Query.HierarchyObjectRecoveryTarget,
                Query.HierarchyObjectRecoveryTargetFieldSpec,
                @"# REQUIRED
$query.Var.fid = $someString"
            );
        }

        // Create new GraphQL Query:
        // isTotpMandatoryInTargetVersion(version: String!): Boolean!
        internal void InitQueryIsTotpMandatoryInTargetVersion()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("version", "String!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryIsTotpMandatoryInTargetVersion",
                "($version: String!)",
                "System.Boolean",
                Query.IsTotpMandatoryInTargetVersion,
                Query.IsTotpMandatoryInTargetVersionFieldSpec,
                @"# REQUIRED
$query.Var.version = $someString"
            );
        }

        // Create new GraphQL Query:
        // archivalLocationEncryptionDetails(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     sortOrder: SortOrder
        //     nameSearchPrefix: String
        //     sortBy: QueryArchivalLocationsEncryptionDetailsSortByField
        //     archivalLocationRekeyStatusFilterArg: [ArchivalLocationEncryptionJobStatus!]! = []
        //     archivalLocationRotationStatusFilterArg: [ArchivalLocationEncryptionJobStatus!]! = []
        //     archivalLocationKeyTypeFilterArg: [ArchivalLocationEncryptionKeyType!]! = []
        //     archivalLocationEncryptionStatusFilterArg: [ArchivalLocationEncryptionStatusFilter!]! = []
        //   ): ArchivalLocationEncryptionDetailsConnection!
        internal void InitQueryArchivalLocationEncryptionDetails()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("nameSearchPrefix", "String"),
                Tuple.Create("sortBy", "QueryArchivalLocationsEncryptionDetailsSortByField"),
                Tuple.Create("archivalLocationRekeyStatusFilterArg", "[ArchivalLocationEncryptionJobStatus!]!"),
                Tuple.Create("archivalLocationRotationStatusFilterArg", "[ArchivalLocationEncryptionJobStatus!]!"),
                Tuple.Create("archivalLocationKeyTypeFilterArg", "[ArchivalLocationEncryptionKeyType!]!"),
                Tuple.Create("archivalLocationEncryptionStatusFilterArg", "[ArchivalLocationEncryptionStatusFilter!]!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryArchivalLocationEncryptionDetails",
                "($first: Int,$after: String,$last: Int,$before: String,$sortOrder: SortOrder,$nameSearchPrefix: String,$sortBy: QueryArchivalLocationsEncryptionDetailsSortByField,$archivalLocationRekeyStatusFilterArg: [ArchivalLocationEncryptionJobStatus!]!,$archivalLocationRotationStatusFilterArg: [ArchivalLocationEncryptionJobStatus!]!,$archivalLocationKeyTypeFilterArg: [ArchivalLocationEncryptionKeyType!]!,$archivalLocationEncryptionStatusFilterArg: [ArchivalLocationEncryptionStatusFilter!]!)",
                "ArchivalLocationEncryptionDetailsConnection",
                Query.ArchivalLocationEncryptionDetails,
                Query.ArchivalLocationEncryptionDetailsFieldSpec,
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
$query.Var.nameSearchPrefix = $someString
# OPTIONAL
$query.Var.sortBy = $someQueryArchivalLocationsEncryptionDetailsSortByField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.QueryArchivalLocationsEncryptionDetailsSortByField]) for enum values.
# REQUIRED
$query.Var.archivalLocationRekeyStatusFilterArg = @(
	$someArchivalLocationEncryptionJobStatus # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ArchivalLocationEncryptionJobStatus]) for enum values.
)
# REQUIRED
$query.Var.archivalLocationRotationStatusFilterArg = @(
	$someArchivalLocationEncryptionJobStatus # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ArchivalLocationEncryptionJobStatus]) for enum values.
)
# REQUIRED
$query.Var.archivalLocationKeyTypeFilterArg = @(
	$someArchivalLocationEncryptionKeyType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ArchivalLocationEncryptionKeyType]) for enum values.
)
# REQUIRED
$query.Var.archivalLocationEncryptionStatusFilterArg = @(
	$someArchivalLocationEncryptionStatusFilter # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ArchivalLocationEncryptionStatusFilter]) for enum values.
)"
            );
        }

        // Create new GraphQL Query:
        // archivalLocationEncryptionJobsSummary(input: ArchivalLocationEncryptionJobsSummaryInput!): ArchivalLocationEncryptionJobsSummary!
        internal void InitQueryArchivalLocationEncryptionJobsSummary()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "ArchivalLocationEncryptionJobsSummaryInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryArchivalLocationEncryptionJobsSummary",
                "($input: ArchivalLocationEncryptionJobsSummaryInput!)",
                "ArchivalLocationEncryptionJobsSummary",
                Query.ArchivalLocationEncryptionJobsSummary,
                Query.ArchivalLocationEncryptionJobsSummaryFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	locationId = $someString
}"
            );
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
                Query.RcsArchivalLocationsConsumptionStats,
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
        // archivalStorageUsage(input: UUID!): [ArchivalStorageUsage!]!
        internal void InitQueryArchivalStorageUsage()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryArchivalStorageUsage",
                "($input: UUID!)",
                "List<ArchivalStorageUsage>",
                Query.ArchivalStorageUsage,
                Query.ArchivalStorageUsageFieldSpec,
                @"# REQUIRED
$query.Var.input = $someString"
            );
        }

        // Create new GraphQL Query:
        // target(input: UUID!): Target!
        internal void InitQueryTarget()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryTarget",
                "($input: UUID!)",
                "Target",
                Query.Target,
                Query.TargetFieldSpec,
                @"# REQUIRED
$query.Var.input = $someString"
            );
        }

        // Create new GraphQL Query:
        // targetMapping(targetMappingId: UUID!): TargetMapping!
        internal void InitQueryTargetMapping()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("targetMappingId", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryTargetMapping",
                "($targetMappingId: UUID!)",
                "TargetMapping",
                Query.TargetMapping,
                Query.TargetMappingFieldSpec,
                @"# REQUIRED
$query.Var.targetMappingId = $someString"
            );
        }

        // Create new GraphQL Query:
        // allTargetMappings(
        //     sortBy: ArchivalGroupQuerySortByField
        //     sortOrder: SortOrder
        //     filter: [TargetMappingFilterInput!]
        //     contextFilter: ContextFilterTypeEnum
        //     isRcsStatsRequired: Boolean
        //   ): [TargetMapping!]!
        internal void InitQueryAllTargetMappings()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("sortBy", "ArchivalGroupQuerySortByField"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("filter", "[TargetMappingFilterInput!]"),
                Tuple.Create("contextFilter", "ContextFilterTypeEnum"),
                Tuple.Create("isRcsStatsRequired", "Boolean"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllTargetMappings",
                "($sortBy: ArchivalGroupQuerySortByField,$sortOrder: SortOrder,$filter: [TargetMappingFilterInput!],$contextFilter: ContextFilterTypeEnum,$isRcsStatsRequired: Boolean)",
                "List<TargetMapping>",
                Query.AllTargetMappings,
                Query.AllTargetMappingsFieldSpec,
                @"# OPTIONAL
$query.Var.sortBy = $someArchivalGroupQuerySortByField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ArchivalGroupQuerySortByField]) for enum values.
# OPTIONAL
$query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$query.Var.filter = @(
	@{
		# OPTIONAL
		field = $someTargetMappingQueryFilterField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TargetMappingQueryFilterField]) for enum values.
		# OPTIONAL
		text = $someString
		# OPTIONAL
		textList = @(
			$someString
		)
}
)
# OPTIONAL
$query.Var.contextFilter = $someContextFilterTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ContextFilterTypeEnum]) for enum values.
# OPTIONAL
$query.Var.isRcsStatsRequired = $someBoolean"
            );
        }

        // Create new GraphQL Query:
        // targets(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     sortBy: ArchivalLocationQuerySortByField
        //     sortOrder: SortOrder
        //     filter: [TargetFilterInput!]
        //     contextFilter: ContextFilterTypeEnum
        //   ): TargetConnection!
        internal void InitQueryTargets()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("sortBy", "ArchivalLocationQuerySortByField"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("filter", "[TargetFilterInput!]"),
                Tuple.Create("contextFilter", "ContextFilterTypeEnum"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryTargets",
                "($first: Int,$after: String,$last: Int,$before: String,$sortBy: ArchivalLocationQuerySortByField,$sortOrder: SortOrder,$filter: [TargetFilterInput!],$contextFilter: ContextFilterTypeEnum)",
                "TargetConnection",
                Query.Targets,
                Query.TargetsFieldSpec,
                @"# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# OPTIONAL
$query.Var.last = $someInt
# OPTIONAL
$query.Var.before = $someString
# OPTIONAL
$query.Var.sortBy = $someArchivalLocationQuerySortByField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ArchivalLocationQuerySortByField]) for enum values.
# OPTIONAL
$query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$query.Var.filter = @(
	@{
		# OPTIONAL
		field = $someTargetQueryFilterField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TargetQueryFilterField]) for enum values.
		# OPTIONAL
		text = $someString
		# OPTIONAL
		textList = @(
			$someString
		)
}
)
# OPTIONAL
$query.Var.contextFilter = $someContextFilterTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ContextFilterTypeEnum]) for enum values."
            );
        }


    } // class New_RscQueryArchival
}