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
    /// Create a new RscQuery object for any of the 4
    /// operations in the 'Threat' API domain:
    /// HuntDetail, HuntResult, HuntSummary, or Hunts.
    /// </summary>
    /// <description>
    /// New-RscQueryThreat creates a new
    /// query object for operations
    /// in the 'Threat' API domain. It only creates a data structure,
    /// it does not execute the operation. This cmdlet does not need a
    /// connection to run. To execute the operation, either call Invoke()
    /// on the object returned by this cmdlet, or pass the object to
    /// Invoke-Rsc.
    /// There are 4 operations
    /// in the 'Threat' API domain. Select the operation this
    /// query is for by specifying the appropriate value for the
    /// -Operation parameter;
    /// one of: HuntDetail, HuntResult, HuntSummary, or Hunts.
    /// Each operation has its own set of variables that can be set with
    /// the -Var parameter. For more info about the variables, 
    /// call Info() on the object returned by this cmdlet, for example:
    /// (New-RscQueryThreat -HuntDetail).Info().
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
    /// (New-RscQueryThreat -HuntDetail).Info().
    /// You can combine a -Field parameter with patching parameters.
    /// -Field is applied first, then -FilePatch, -AddField and -RemoveField.
    ///
    /// </description>
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
    /// $query = New-RscQueryThreat -HuntDetail
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
    /// $query = New-RscQueryThreat -HuntResult
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
    /// $query = New-RscQueryThreat -HuntSummary
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
    /// $query = New-RscQueryThreat -Hunts
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
                "HuntDetail",
                "HuntResult",
                "HuntSummary",
                "Hunts",
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
                    case "HuntDetail":
                        this.ProcessRecord_HuntDetail();
                        break;
                    case "HuntResult":
                        this.ProcessRecord_HuntResult();
                        break;
                    case "HuntSummary":
                        this.ProcessRecord_HuntSummary();
                        break;
                    case "Hunts":
                        this.ProcessRecord_Hunts();
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
        internal void ProcessRecord_HuntDetail()
        {
            this._logger.name += " -HuntDetail";
            // Create new graphql operation threatHuntDetail
            InitQueryThreatHuntDetail();
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
        // threatHunts.
        internal void ProcessRecord_Hunts()
        {
            this._logger.name += " -Hunts";
            // Create new graphql operation threatHunts
            InitQueryThreatHunts();
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


    } // class New_RscQueryThreat
}