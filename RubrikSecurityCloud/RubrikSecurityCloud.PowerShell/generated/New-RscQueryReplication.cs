// New-RscQueryReplication.cs
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
    /// Create a new RscQuery object for any of the 4
    /// operations in the 'Replication' API domain:
    /// IncomingStats, OutgoingStats, Pairs, or ValidTargets.
    /// </summary>
    /// <description>
    /// New-RscQueryReplication creates a new
    /// query object for operations
    /// in the 'Replication' API domain. It only creates a data structure,
    /// it does not execute the operation. This cmdlet does not need a
    /// connection to run. To execute the operation, either call Invoke()
    /// on the object returned by this cmdlet, or pass the object to
    /// Invoke-Rsc.
    /// There are 4 operations
    /// in the 'Replication' API domain. Select the operation this
    /// query is for by specifying the appropriate value for the
    /// -Operation parameter;
    /// one of: IncomingStats, OutgoingStats, Pairs, or ValidTargets.
    /// Each operation has its own set of variables that can be set with
    /// the -Var parameter. For more info about the variables, 
    /// call Info() on the object returned by this cmdlet, for example:
    /// (New-RscQueryReplication -IncomingStats).Info().
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
    /// (New-RscQueryReplication -IncomingStats).Info().
    /// You can combine a -Field parameter with patching parameters.
    /// -Field is applied first, then -FilePatch, -AddField and -RemoveField.
    ///
    /// </description>
    ///
    /// <example>
    /// Runs the IncomingStats operation
    /// of the 'Replication' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Replication
    /// # API Operation: IncomingStats
    /// 
    /// $query = New-RscQueryReplication -IncomingStats
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	range = $someString
    /// 	# REQUIRED
    /// 	clusterUuid = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: InternalReplicationBandwidthIncomingResponse
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the OutgoingStats operation
    /// of the 'Replication' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Replication
    /// # API Operation: OutgoingStats
    /// 
    /// $query = New-RscQueryReplication -OutgoingStats
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	range = $someString
    /// 	# REQUIRED
    /// 	clusterUuid = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: InternalReplicationBandwidthOutgoingResponse
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the Pairs operation
    /// of the 'Replication' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Replication
    /// # API Operation: Pairs
    /// 
    /// $query = New-RscQueryReplication -Pairs
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
    /// $query.Var.sortBy = $someReplicationPairsQuerySortByField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ReplicationPairsQuerySortByField]) for enum values.
    /// # OPTIONAL
    /// $query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
    /// # OPTIONAL
    /// $query.Var.filter = @{
    /// 	# OPTIONAL
    /// 	clusterName = $someString
    /// 	# OPTIONAL
    /// 	sourceClusterUuids = @(
    /// 		$someString
    /// 	)
    /// 	# OPTIONAL
    /// 	targetClusterUuids = @(
    /// 		$someString
    /// 	)
    /// 	# OPTIONAL
    /// 	status = @(
    /// 		$someReplicationPairConnectionStatus # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ReplicationPairConnectionStatus]) for enum values.
    /// 	)
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: ReplicationPairConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the ValidTargets operation
    /// of the 'Replication' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Replication
    /// # API Operation: ValidTargets
    /// 
    /// $query = New-RscQueryReplication -ValidTargets
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
    /// $query.Var.sortBy = $someListValidReplicationTargetsSortByField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ListValidReplicationTargetsSortByField]) for enum values.
    /// # OPTIONAL
    /// $query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
    /// # OPTIONAL
    /// $query.Var.isCrossAccount = $someBoolean
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: ValidReplicationTargetConnection
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
        "RscQueryReplication",
        DefaultParameterSetName = "Operation")
    ]
    public class New_RscQueryReplication : RscGqlPSCmdlet
    {
        [Parameter(
            Mandatory = true, 
            ParameterSetName = "Operation",
            HelpMessage = "API Operation. The set of operations depends on the API domain. See reference at: https://github.com/rubrikinc/rubrik-powershell-sdk/blob/main/docs/domains_and_operations.md",
            Position = 0,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = true)]
            [ValidateSet(
                "IncomingStats",
                "OutgoingStats",
                "Pairs",
                "ValidTargets",
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
                    case "IncomingStats":
                        this.ProcessRecord_IncomingStats();
                        break;
                    case "OutgoingStats":
                        this.ProcessRecord_OutgoingStats();
                        break;
                    case "Pairs":
                        this.ProcessRecord_Pairs();
                        break;
                    case "ValidTargets":
                        this.ProcessRecord_ValidTargets();
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
        // replicationIncomingStats.
        internal void ProcessRecord_IncomingStats()
        {
            this._logger.name += " -IncomingStats";
            // Create new graphql operation replicationIncomingStats
            InitQueryReplicationIncomingStats();
        }

        // This parameter set invokes a single graphql operation:
        // replicationOutgoingStats.
        internal void ProcessRecord_OutgoingStats()
        {
            this._logger.name += " -OutgoingStats";
            // Create new graphql operation replicationOutgoingStats
            InitQueryReplicationOutgoingStats();
        }

        // This parameter set invokes a single graphql operation:
        // replicationPairs.
        internal void ProcessRecord_Pairs()
        {
            this._logger.name += " -Pairs";
            // Create new graphql operation replicationPairs
            InitQueryReplicationPairs();
        }

        // This parameter set invokes a single graphql operation:
        // allValidReplicationTargets.
        internal void ProcessRecord_ValidTargets()
        {
            this._logger.name += " -ValidTargets";
            // Create new graphql operation allValidReplicationTargets
            InitQueryAllValidReplicationTargets();
        }


        // Create new GraphQL Query:
        // replicationIncomingStats(input: ReplicationBandwidthIncomingInput!): InternalReplicationBandwidthIncomingResponse!
        internal void InitQueryReplicationIncomingStats()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "ReplicationBandwidthIncomingInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryReplicationIncomingStats",
                "($input: ReplicationBandwidthIncomingInput!)",
                "InternalReplicationBandwidthIncomingResponse",
                Query.ReplicationIncomingStats_ObjectFieldSpec,
                Query.ReplicationIncomingStatsFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	range = $someString
	# REQUIRED
	clusterUuid = $someString
}"
            );
        }

        // Create new GraphQL Query:
        // replicationOutgoingStats(input: ReplicationBandwidthOutgoingInput!): InternalReplicationBandwidthOutgoingResponse!
        internal void InitQueryReplicationOutgoingStats()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "ReplicationBandwidthOutgoingInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryReplicationOutgoingStats",
                "($input: ReplicationBandwidthOutgoingInput!)",
                "InternalReplicationBandwidthOutgoingResponse",
                Query.ReplicationOutgoingStats_ObjectFieldSpec,
                Query.ReplicationOutgoingStatsFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	range = $someString
	# REQUIRED
	clusterUuid = $someString
}"
            );
        }

        // Create new GraphQL Query:
        // replicationPairs(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     sortBy: ReplicationPairsQuerySortByField
        //     sortOrder: SortOrder
        //     filter: ReplicationPairsQueryFilter
        //   ): ReplicationPairConnection!
        internal void InitQueryReplicationPairs()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("sortBy", "ReplicationPairsQuerySortByField"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("filter", "ReplicationPairsQueryFilter"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryReplicationPairs",
                "($first: Int,$after: String,$last: Int,$before: String,$sortBy: ReplicationPairsQuerySortByField,$sortOrder: SortOrder,$filter: ReplicationPairsQueryFilter)",
                "ReplicationPairConnection",
                Query.ReplicationPairs_ObjectFieldSpec,
                Query.ReplicationPairsFieldSpec,
                @"# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# OPTIONAL
$query.Var.last = $someInt
# OPTIONAL
$query.Var.before = $someString
# OPTIONAL
$query.Var.sortBy = $someReplicationPairsQuerySortByField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ReplicationPairsQuerySortByField]) for enum values.
# OPTIONAL
$query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$query.Var.filter = @{
	# OPTIONAL
	clusterName = $someString
	# OPTIONAL
	sourceClusterUuids = @(
		$someString
	)
	# OPTIONAL
	targetClusterUuids = @(
		$someString
	)
	# OPTIONAL
	status = @(
		$someReplicationPairConnectionStatus # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ReplicationPairConnectionStatus]) for enum values.
	)
}"
            );
        }

        // Create new GraphQL Query:
        // allValidReplicationTargets(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     sortBy: ListValidReplicationTargetsSortByField
        //     sortOrder: SortOrder
        //     isCrossAccount: Boolean
        //   ): ValidReplicationTargetConnection!
        internal void InitQueryAllValidReplicationTargets()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("sortBy", "ListValidReplicationTargetsSortByField"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("isCrossAccount", "Boolean"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllValidReplicationTargets",
                "($first: Int,$after: String,$last: Int,$before: String,$sortBy: ListValidReplicationTargetsSortByField,$sortOrder: SortOrder,$isCrossAccount: Boolean)",
                "ValidReplicationTargetConnection",
                Query.AllValidReplicationTargets_ObjectFieldSpec,
                Query.AllValidReplicationTargetsFieldSpec,
                @"# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# OPTIONAL
$query.Var.last = $someInt
# OPTIONAL
$query.Var.before = $someString
# OPTIONAL
$query.Var.sortBy = $someListValidReplicationTargetsSortByField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ListValidReplicationTargetsSortByField]) for enum values.
# OPTIONAL
$query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$query.Var.isCrossAccount = $someBoolean"
            );
        }


    } // class New_RscQueryReplication
}