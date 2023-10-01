// New-RscQueryPolicy.cs
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
    /// Create a new RscQuery object for any of the 6
    /// operations in the 'Policy' API domain:
    /// Details, Obj, ObjectUsages, Objs, Policies, or Policy.
    /// </summary>
    /// <description>
    /// New-RscQueryPolicy creates a new
    /// query object for operations
    /// in the 'Policy' API domain. It only creates a data structure,
    /// it does not execute the operation. This cmdlet does not need a
    /// connection to run. To execute the operation, either call Invoke()
    /// on the object returned by this cmdlet, or pass the object to
    /// Invoke-Rsc.
    /// There are 6 operations
    /// in the 'Policy' API domain. Select the operation this
    /// query is for by specifying the appropriate value for the
    /// -Operation parameter;
    /// one of: Details, Obj, ObjectUsages, Objs, Policies, or Policy.
    /// Each operation has its own set of variables that can be set with
    /// the -Var parameter. For more info about the variables, 
    /// call Info() on the object returned by this cmdlet, for example:
    /// (New-RscQueryPolicy -Details).Info().
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
    /// (New-RscQueryPolicy -Details).Info().
    /// You can combine a -Field parameter with patching parameters.
    /// -Field is applied first, then -FilePatch, -AddField and -RemoveField.
    ///
    /// </description>
    ///
    /// <example>
    /// Runs the Details operation
    /// of the 'Policy' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Policy
    /// # API Operation: Details
    /// 
    /// $query = New-RscQueryPolicy -Details
    /// 
    /// # No variables for this query.
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: PolicyDetailConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the Obj operation
    /// of the 'Policy' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Policy
    /// # API Operation: Obj
    /// 
    /// $query = New-RscQueryPolicy -Obj
    /// 
    /// # REQUIRED
    /// $query.Var.snappableFid = $someString
    /// # REQUIRED
    /// $query.Var.snapshotFid = $someString
    /// # OPTIONAL
    /// $query.Var.includeWhitelistedResults = $someBoolean
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: PolicyObj
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the ObjectUsages operation
    /// of the 'Policy' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Policy
    /// # API Operation: ObjectUsages
    /// 
    /// $query = New-RscQueryPolicy -ObjectUsages
    /// 
    /// # REQUIRED
    /// $query.Var.objectIds = @(
    /// 	$someString
    /// )
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: PolicyObjectUsageConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the Objs operation
    /// of the 'Policy' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Policy
    /// # API Operation: Objs
    /// 
    /// $query = New-RscQueryPolicy -Objs
    /// 
    /// # REQUIRED
    /// $query.Var.day = $someString
    /// # REQUIRED
    /// $query.Var.timezone = $someString
    /// # REQUIRED
    /// $query.Var.workloadTypes = @(
    /// 	$someDataGovObjectType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DataGovObjectType]) for enum values.
    /// )
    /// # OPTIONAL
    /// $query.Var.sortBy = $someString
    /// # OPTIONAL
    /// $query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
    /// # OPTIONAL
    /// $query.Var.analysisStatusesFilter = @(
    /// 	$someAnalysisStatus # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AnalysisStatus]) for enum values.
    /// )
    /// # OPTIONAL
    /// $query.Var.policyIdsFilter = @(
    /// 	$someString
    /// )
    /// # OPTIONAL
    /// $query.Var.riskLevelsFilter = @(
    /// 	$someRiskLevelType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RiskLevelType]) for enum values.
    /// )
    /// # OPTIONAL
    /// $query.Var.clusterIdsFilter = @(
    /// 	$someString
    /// )
    /// # OPTIONAL
    /// $query.Var.searchObjectName = $someString
    /// # OPTIONAL
    /// $query.Var.subscriptionIdsFilter = @(
    /// 	$someString
    /// )
    /// # OPTIONAL
    /// $query.Var.includeWhitelistedResults = $someBoolean
    /// # OPTIONAL
    /// $query.Var.sids = @(
    /// 	$someString
    /// )
    /// # REQUIRED
    /// $query.Var.userAccessObjectsFilter = $someBoolean
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
    /// Write-Host $result.GetType().Name # prints: PolicyObjConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the Policies operation
    /// of the 'Policy' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Policy
    /// # API Operation: Policies
    /// 
    /// $query = New-RscQueryPolicy -Policies
    /// 
    /// # OPTIONAL
    /// $query.Var.policyObjectFilter = $somePolicyObjectFilter # Call [Enum]::GetValues([RubrikSecurityCloud.Types.PolicyObjectFilter]) for enum values.
    /// # OPTIONAL
    /// $query.Var.excludeHierarchyObjectList = $someBoolean
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: ClassificationPolicyDetailConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the Policy operation
    /// of the 'Policy' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Policy
    /// # API Operation: Policy
    /// 
    /// $query = New-RscQueryPolicy -Policy
    /// 
    /// # REQUIRED
    /// $query.Var.policyId = $someString
    /// # OPTIONAL
    /// $query.Var.workloadTypes = @(
    /// 	$someDataGovObjectType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DataGovObjectType]) for enum values.
    /// )
    /// # OPTIONAL
    /// $query.Var.sortBy = $somePolicyDetailsSortBy # Call [Enum]::GetValues([RubrikSecurityCloud.Types.PolicyDetailsSortBy]) for enum values.
    /// # OPTIONAL
    /// $query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
    /// # OPTIONAL
    /// $query.Var.clusterIdsFilter = @(
    /// 	$someString
    /// )
    /// # OPTIONAL
    /// $query.Var.replicationFilter = @(
    /// 	$someString
    /// )
    /// # OPTIONAL
    /// $query.Var.searchObjectName = $someString
    /// # OPTIONAL
    /// $query.Var.hierarchyAncestorIdFilter = $someString
    /// # OPTIONAL
    /// $query.Var.policyAssignmentType = $somePolicyAssignmentType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.PolicyAssignmentType]) for enum values.
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
    /// Write-Host $result.GetType().Name # prints: ClassificationPolicyDetail
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
        "RscQueryPolicy",
        DefaultParameterSetName = "Operation")
    ]
    public class New_RscQueryPolicy : RscGqlPSCmdlet
    {
        [Parameter(
            Mandatory = true, 
            ParameterSetName = "Operation",
            HelpMessage = "API Operation. The set of operations depends on the API domain. See reference at: https://github.com/rubrikinc/rubrik-powershell-sdk/blob/main/docs/domains_and_operations.md",
            Position = 0,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = true)]
            [ValidateSet(
                "Details",
                "Obj",
                "ObjectUsages",
                "Objs",
                "Policies",
                "Policy",
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
                    case "Details":
                        this.ProcessRecord_Details();
                        break;
                    case "Obj":
                        this.ProcessRecord_Obj();
                        break;
                    case "ObjectUsages":
                        this.ProcessRecord_ObjectUsages();
                        break;
                    case "Objs":
                        this.ProcessRecord_Objs();
                        break;
                    case "Policies":
                        this.ProcessRecord_Policies();
                        break;
                    case "Policy":
                        this.ProcessRecord_Policy();
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
        // policyDetails.
        internal void ProcessRecord_Details()
        {
            this._logger.name += " -Details";
            // Create new graphql operation policyDetails
            InitQueryPolicyDetails();
        }

        // This parameter set invokes a single graphql operation:
        // policyObj.
        internal void ProcessRecord_Obj()
        {
            this._logger.name += " -Obj";
            // Create new graphql operation policyObj
            InitQueryPolicyObj();
        }

        // This parameter set invokes a single graphql operation:
        // policyObjectUsages.
        internal void ProcessRecord_ObjectUsages()
        {
            this._logger.name += " -ObjectUsages";
            // Create new graphql operation policyObjectUsages
            InitQueryPolicyObjectUsages();
        }

        // This parameter set invokes a single graphql operation:
        // policyObjs.
        internal void ProcessRecord_Objs()
        {
            this._logger.name += " -Objs";
            // Create new graphql operation policyObjs
            InitQueryPolicyObjs();
        }

        // This parameter set invokes a single graphql operation:
        // policies.
        internal void ProcessRecord_Policies()
        {
            this._logger.name += " -Policies";
            // Create new graphql operation policies
            InitQueryPolicies();
        }

        // This parameter set invokes a single graphql operation:
        // policy.
        internal void ProcessRecord_Policy()
        {
            this._logger.name += " -Policy";
            // Create new graphql operation policy
            InitQueryPolicy();
        }


        // Create new GraphQL Query:
        // policyDetails: PolicyDetailConnection!
        internal void InitQueryPolicyDetails()
        {
            Tuple<string, string>[] argDefs = {
            };
            Initialize(
                argDefs,
                "query",
                "QueryPolicyDetails",
                "",
                "PolicyDetailConnection",
                Query.PolicyDetails_ObjectFieldSpec,
                Query.PolicyDetailsFieldSpec,
                @""
            );
        }

        // Create new GraphQL Query:
        // policyObj(snappableFid: String!, snapshotFid: String!, includeWhitelistedResults: Boolean): PolicyObj!
        internal void InitQueryPolicyObj()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("snappableFid", "String!"),
                Tuple.Create("snapshotFid", "String!"),
                Tuple.Create("includeWhitelistedResults", "Boolean"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryPolicyObj",
                "($snappableFid: String!,$snapshotFid: String!,$includeWhitelistedResults: Boolean)",
                "PolicyObj",
                Query.PolicyObj_ObjectFieldSpec,
                Query.PolicyObjFieldSpec,
                @"# REQUIRED
$query.Var.snappableFid = $someString
# REQUIRED
$query.Var.snapshotFid = $someString
# OPTIONAL
$query.Var.includeWhitelistedResults = $someBoolean"
            );
        }

        // Create new GraphQL Query:
        // policyObjectUsages(objectIds: [String!]! = []): PolicyObjectUsageConnection!
        internal void InitQueryPolicyObjectUsages()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("objectIds", "[String!]!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryPolicyObjectUsages",
                "($objectIds: [String!]!)",
                "PolicyObjectUsageConnection",
                Query.PolicyObjectUsages_ObjectFieldSpec,
                Query.PolicyObjectUsagesFieldSpec,
                @"# REQUIRED
$query.Var.objectIds = @(
	$someString
)"
            );
        }

        // Create new GraphQL Query:
        // policyObjs(
        //     day: String!
        //     timezone: String!
        //     workloadTypes: [DataGovObjectType!]! = []
        //     sortBy: String
        //     sortOrder: SortOrder
        //     analysisStatusesFilter: [AnalysisStatus!]
        //     policyIdsFilter: [String!]
        //     riskLevelsFilter: [RiskLevelType!]
        //     clusterIdsFilter: [String!]
        //     searchObjectName: String
        //     subscriptionIdsFilter: [String!]
        //     includeWhitelistedResults: Boolean
        //     sids: [String!]
        //     userAccessObjectsFilter: Boolean! = false
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //   ): PolicyObjConnection!
        internal void InitQueryPolicyObjs()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("day", "String!"),
                Tuple.Create("timezone", "String!"),
                Tuple.Create("workloadTypes", "[DataGovObjectType!]!"),
                Tuple.Create("sortBy", "String"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("analysisStatusesFilter", "[AnalysisStatus!]"),
                Tuple.Create("policyIdsFilter", "[String!]"),
                Tuple.Create("riskLevelsFilter", "[RiskLevelType!]"),
                Tuple.Create("clusterIdsFilter", "[String!]"),
                Tuple.Create("searchObjectName", "String"),
                Tuple.Create("subscriptionIdsFilter", "[String!]"),
                Tuple.Create("includeWhitelistedResults", "Boolean"),
                Tuple.Create("sids", "[String!]"),
                Tuple.Create("userAccessObjectsFilter", "Boolean!"),
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryPolicyObjs",
                "($day: String!,$timezone: String!,$workloadTypes: [DataGovObjectType!]!,$sortBy: String,$sortOrder: SortOrder,$analysisStatusesFilter: [AnalysisStatus!],$policyIdsFilter: [String!],$riskLevelsFilter: [RiskLevelType!],$clusterIdsFilter: [String!],$searchObjectName: String,$subscriptionIdsFilter: [String!],$includeWhitelistedResults: Boolean,$sids: [String!],$userAccessObjectsFilter: Boolean!,$first: Int,$after: String,$last: Int,$before: String)",
                "PolicyObjConnection",
                Query.PolicyObjs_ObjectFieldSpec,
                Query.PolicyObjsFieldSpec,
                @"# REQUIRED
$query.Var.day = $someString
# REQUIRED
$query.Var.timezone = $someString
# REQUIRED
$query.Var.workloadTypes = @(
	$someDataGovObjectType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DataGovObjectType]) for enum values.
)
# OPTIONAL
$query.Var.sortBy = $someString
# OPTIONAL
$query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$query.Var.analysisStatusesFilter = @(
	$someAnalysisStatus # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AnalysisStatus]) for enum values.
)
# OPTIONAL
$query.Var.policyIdsFilter = @(
	$someString
)
# OPTIONAL
$query.Var.riskLevelsFilter = @(
	$someRiskLevelType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RiskLevelType]) for enum values.
)
# OPTIONAL
$query.Var.clusterIdsFilter = @(
	$someString
)
# OPTIONAL
$query.Var.searchObjectName = $someString
# OPTIONAL
$query.Var.subscriptionIdsFilter = @(
	$someString
)
# OPTIONAL
$query.Var.includeWhitelistedResults = $someBoolean
# OPTIONAL
$query.Var.sids = @(
	$someString
)
# REQUIRED
$query.Var.userAccessObjectsFilter = $someBoolean
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
        // policies(policyObjectFilter: PolicyObjectFilter, excludeHierarchyObjectList: Boolean): ClassificationPolicyDetailConnection!
        internal void InitQueryPolicies()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("policyObjectFilter", "PolicyObjectFilter"),
                Tuple.Create("excludeHierarchyObjectList", "Boolean"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryPolicies",
                "($policyObjectFilter: PolicyObjectFilter,$excludeHierarchyObjectList: Boolean)",
                "ClassificationPolicyDetailConnection",
                Query.Policies_ObjectFieldSpec,
                Query.PoliciesFieldSpec,
                @"# OPTIONAL
$query.Var.policyObjectFilter = $somePolicyObjectFilter # Call [Enum]::GetValues([RubrikSecurityCloud.Types.PolicyObjectFilter]) for enum values.
# OPTIONAL
$query.Var.excludeHierarchyObjectList = $someBoolean"
            );
        }

        // Create new GraphQL Query:
        // policy(
        //     policyId: String!
        //     workloadTypes: [DataGovObjectType!]
        //     sortBy: PolicyDetailsSortBy
        //     sortOrder: SortOrder
        //     clusterIdsFilter: [String!]
        //     replicationFilter: [String!]
        //     searchObjectName: String
        //     hierarchyAncestorIdFilter: String
        //     policyAssignmentType: PolicyAssignmentType
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //   ): ClassificationPolicyDetail!
        internal void InitQueryPolicy()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("policyId", "String!"),
                Tuple.Create("workloadTypes", "[DataGovObjectType!]"),
                Tuple.Create("sortBy", "PolicyDetailsSortBy"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("clusterIdsFilter", "[String!]"),
                Tuple.Create("replicationFilter", "[String!]"),
                Tuple.Create("searchObjectName", "String"),
                Tuple.Create("hierarchyAncestorIdFilter", "String"),
                Tuple.Create("policyAssignmentType", "PolicyAssignmentType"),
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryPolicy",
                "($policyId: String!,$workloadTypes: [DataGovObjectType!],$sortBy: PolicyDetailsSortBy,$sortOrder: SortOrder,$clusterIdsFilter: [String!],$replicationFilter: [String!],$searchObjectName: String,$hierarchyAncestorIdFilter: String,$policyAssignmentType: PolicyAssignmentType,$first: Int,$after: String,$last: Int,$before: String)",
                "ClassificationPolicyDetail",
                Query.Policy_ObjectFieldSpec,
                Query.PolicyFieldSpec,
                @"# REQUIRED
$query.Var.policyId = $someString
# OPTIONAL
$query.Var.workloadTypes = @(
	$someDataGovObjectType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DataGovObjectType]) for enum values.
)
# OPTIONAL
$query.Var.sortBy = $somePolicyDetailsSortBy # Call [Enum]::GetValues([RubrikSecurityCloud.Types.PolicyDetailsSortBy]) for enum values.
# OPTIONAL
$query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$query.Var.clusterIdsFilter = @(
	$someString
)
# OPTIONAL
$query.Var.replicationFilter = @(
	$someString
)
# OPTIONAL
$query.Var.searchObjectName = $someString
# OPTIONAL
$query.Var.hierarchyAncestorIdFilter = $someString
# OPTIONAL
$query.Var.policyAssignmentType = $somePolicyAssignmentType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.PolicyAssignmentType]) for enum values.
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


    } // class New_RscQueryPolicy
}