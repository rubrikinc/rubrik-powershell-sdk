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
    /// Create a new RscQuery object for any of the 10
    /// operations in the 'Policy' API domain:
    /// CustomTprPolicies, HaPolicies, IsValidTprPolicyName, OrgSecurityPolicy, PasswordComplexityPolicy, Policies, Policy, PolicyObjectUsages, TopRiskPolicySummaries, or TprPolicyDetail.
    /// </summary>
    /// <description>
    /// New-RscQueryPolicy creates a new
    /// query object for operations
    /// in the 'Policy' API domain. It only creates a data structure,
    /// it does not execute the operation. This cmdlet does not need a
    /// connection to run. To execute the operation, either call Invoke()
    /// on the object returned by this cmdlet, or pass the object to
    /// Invoke-Rsc.
    /// There are 10 operations
    /// in the 'Policy' API domain. Select the operation this
    /// query is for by specifying the appropriate value for the
    /// -Operation parameter;
    /// one of: CustomTprPolicies, HaPolicies, IsValidTprPolicyName, OrgSecurityPolicy, PasswordComplexityPolicy, Policies, Policy, PolicyObjectUsages, TopRiskPolicySummaries, or TprPolicyDetail.
    /// Each operation has its own set of variables that can be set with
    /// the -Var parameter. For more info about the variables, 
    /// call Info() on the object returned by this cmdlet, for example:
    /// (New-RscQueryPolicy -CustomTprPolicies).Info().
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
    /// (New-RscQueryPolicy -CustomTprPolicies).Info().
    /// You can combine a -Field parameter with patching parameters.
    /// -Field is applied first, then -FilePatch, -AddField and -RemoveField.
    ///
    /// </description>
    ///
    /// <example>
    /// Runs the CustomTprPolicies operation
    /// of the 'Policy' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Policy
    /// # API Operation: CustomTprPolicies
    /// 
    /// $query = New-RscQueryPolicy -Operation CustomTprPolicies
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
    /// $query.Var.sortBy = $someTprPolicySortByField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TprPolicySortByField]) for enum values.
    /// # OPTIONAL
    /// $query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
    /// # OPTIONAL
    /// $query.Var.filter = @{
    /// 	# OPTIONAL
    /// 	policyName = $someString
    /// 	# OPTIONAL
    /// 	policyIds = @(
    /// 		$someString
    /// 	)
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: CustomTprPolicyConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the HaPolicies operation
    /// of the 'Policy' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Policy
    /// # API Operation: HaPolicies
    /// 
    /// $query = New-RscQueryPolicy -Operation HaPolicies
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
    /// 	name = $someString
    /// 	# OPTIONAL
    /// 	status = @(
    /// 		$someFailoverGroupStatus # Call [Enum]::GetValues([RubrikSecurityCloud.Types.FailoverGroupStatus]) for enum values.
    /// 	)
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: HaPolicyConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the IsValidTprPolicyName operation
    /// of the 'Policy' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Policy
    /// # API Operation: IsValidTprPolicyName
    /// 
    /// $query = New-RscQueryPolicy -Operation IsValidTprPolicyName
    /// 
    /// # REQUIRED
    /// $query.Var.tprPolicyName = $someString
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
    /// Runs the OrgSecurityPolicy operation
    /// of the 'Policy' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Policy
    /// # API Operation: OrgSecurityPolicy
    /// 
    /// $query = New-RscQueryPolicy -Operation OrgSecurityPolicy
    /// 
    /// # No variables for this query.
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: OrgSecurityPolicy
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the PasswordComplexityPolicy operation
    /// of the 'Policy' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Policy
    /// # API Operation: PasswordComplexityPolicy
    /// 
    /// $query = New-RscQueryPolicy -Operation PasswordComplexityPolicy
    /// 
    /// # No variables for this query.
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: PasswordComplexityPolicy
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
    /// $query = New-RscQueryPolicy -Operation Policies
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
    /// $query = New-RscQueryPolicy -Operation Policy
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
    /// $query.Var.includeDataTypeHits = $someBoolean
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
    /// <example>
    /// Runs the PolicyObjectUsages operation
    /// of the 'Policy' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Policy
    /// # API Operation: PolicyObjectUsages
    /// 
    /// $query = New-RscQueryPolicy -Operation PolicyObjectUsages
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
    /// Runs the TopRiskPolicySummaries operation
    /// of the 'Policy' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Policy
    /// # API Operation: TopRiskPolicySummaries
    /// 
    /// $query = New-RscQueryPolicy -Operation TopRiskPolicySummaries
    /// 
    /// # REQUIRED
    /// $query.Var.getWhitelistedResults = $someBoolean
    /// # REQUIRED
    /// $query.Var.limit = $someInt
    /// # REQUIRED
    /// $query.Var.workloadTypes = @(
    /// 	$someDataGovObjectType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DataGovObjectType]) for enum values.
    /// )
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: List&lt;PolicySummary&gt;
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the TprPolicyDetail operation
    /// of the 'Policy' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Policy
    /// # API Operation: TprPolicyDetail
    /// 
    /// $query = New-RscQueryPolicy -Operation TprPolicyDetail
    /// 
    /// # REQUIRED
    /// $query.Var.tprPolicyId = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: TprPolicyDetail
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
                "CustomTprPolicies",
                "HaPolicies",
                "IsValidTprPolicyName",
                "OrgSecurityPolicy",
                "PasswordComplexityPolicy",
                "Policies",
                "Policy",
                "PolicyObjectUsages",
                "TopRiskPolicySummaries",
                "TprPolicyDetail",
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
                    case "CustomTprPolicies":
                        this.ProcessRecord_CustomTprPolicies();
                        break;
                    case "HaPolicies":
                        this.ProcessRecord_HaPolicies();
                        break;
                    case "IsValidTprPolicyName":
                        this.ProcessRecord_IsValidTprPolicyName();
                        break;
                    case "OrgSecurityPolicy":
                        this.ProcessRecord_OrgSecurityPolicy();
                        break;
                    case "PasswordComplexityPolicy":
                        this.ProcessRecord_PasswordComplexityPolicy();
                        break;
                    case "Policies":
                        this.ProcessRecord_Policies();
                        break;
                    case "Policy":
                        this.ProcessRecord_Policy();
                        break;
                    case "PolicyObjectUsages":
                        this.ProcessRecord_PolicyObjectUsages();
                        break;
                    case "TopRiskPolicySummaries":
                        this.ProcessRecord_TopRiskPolicySummaries();
                        break;
                    case "TprPolicyDetail":
                        this.ProcessRecord_TprPolicyDetail();
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
        // customTprPolicies.
        internal void ProcessRecord_CustomTprPolicies()
        {
            this._logger.name += " -CustomTprPolicies";
            // Create new graphql operation customTprPolicies
            InitQueryCustomTprPolicies();
        }

        // This parameter set invokes a single graphql operation:
        // haPolicies.
        internal void ProcessRecord_HaPolicies()
        {
            this._logger.name += " -HaPolicies";
            // Create new graphql operation haPolicies
            InitQueryHaPolicies();
        }

        // This parameter set invokes a single graphql operation:
        // isValidTprPolicyName.
        internal void ProcessRecord_IsValidTprPolicyName()
        {
            this._logger.name += " -IsValidTprPolicyName";
            // Create new graphql operation isValidTprPolicyName
            InitQueryIsValidTprPolicyName();
        }

        // This parameter set invokes a single graphql operation:
        // orgSecurityPolicy.
        internal void ProcessRecord_OrgSecurityPolicy()
        {
            this._logger.name += " -OrgSecurityPolicy";
            // Create new graphql operation orgSecurityPolicy
            InitQueryOrgSecurityPolicy();
        }

        // This parameter set invokes a single graphql operation:
        // passwordComplexityPolicy.
        internal void ProcessRecord_PasswordComplexityPolicy()
        {
            this._logger.name += " -PasswordComplexityPolicy";
            // Create new graphql operation passwordComplexityPolicy
            InitQueryPasswordComplexityPolicy();
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

        // This parameter set invokes a single graphql operation:
        // policyObjectUsages.
        internal void ProcessRecord_PolicyObjectUsages()
        {
            this._logger.name += " -PolicyObjectUsages";
            // Create new graphql operation policyObjectUsages
            InitQueryPolicyObjectUsages();
        }

        // This parameter set invokes a single graphql operation:
        // allTopRiskPolicySummaries.
        internal void ProcessRecord_TopRiskPolicySummaries()
        {
            this._logger.name += " -TopRiskPolicySummaries";
            // Create new graphql operation allTopRiskPolicySummaries
            InitQueryAllTopRiskPolicySummaries();
        }

        // This parameter set invokes a single graphql operation:
        // tprPolicyDetail.
        internal void ProcessRecord_TprPolicyDetail()
        {
            this._logger.name += " -TprPolicyDetail";
            // Create new graphql operation tprPolicyDetail
            InitQueryTprPolicyDetail();
        }


        // Create new GraphQL Query:
        // customTprPolicies(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     sortBy: TprPolicySortByField
        //     sortOrder: SortOrder
        //     filter: TprPolicyFilterInput
        //   ): CustomTprPolicyConnection!
        internal void InitQueryCustomTprPolicies()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("sortBy", "TprPolicySortByField"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("filter", "TprPolicyFilterInput"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryCustomTprPolicies",
                "($first: Int,$after: String,$last: Int,$before: String,$sortBy: TprPolicySortByField,$sortOrder: SortOrder,$filter: TprPolicyFilterInput)",
                "CustomTprPolicyConnection",
                Query.CustomTprPolicies,
                Query.CustomTprPoliciesFieldSpec,
                @"# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# OPTIONAL
$query.Var.last = $someInt
# OPTIONAL
$query.Var.before = $someString
# OPTIONAL
$query.Var.sortBy = $someTprPolicySortByField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TprPolicySortByField]) for enum values.
# OPTIONAL
$query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$query.Var.filter = @{
	# OPTIONAL
	policyName = $someString
	# OPTIONAL
	policyIds = @(
		$someString
	)
}"
            );
        }

        // Create new GraphQL Query:
        // haPolicies(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     filter: HaPolicyFilter
        //   ): HaPolicyConnection!
        internal void InitQueryHaPolicies()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("filter", "HaPolicyFilter"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryHaPolicies",
                "($first: Int,$after: String,$last: Int,$before: String,$filter: HaPolicyFilter)",
                "HaPolicyConnection",
                Query.HaPolicies,
                Query.HaPoliciesFieldSpec,
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
	name = $someString
	# OPTIONAL
	status = @(
		$someFailoverGroupStatus # Call [Enum]::GetValues([RubrikSecurityCloud.Types.FailoverGroupStatus]) for enum values.
	)
}"
            );
        }

        // Create new GraphQL Query:
        // isValidTprPolicyName(tprPolicyName: String!): Boolean!
        internal void InitQueryIsValidTprPolicyName()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("tprPolicyName", "String!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryIsValidTprPolicyName",
                "($tprPolicyName: String!)",
                "System.Boolean",
                Query.IsValidTprPolicyName,
                Query.IsValidTprPolicyNameFieldSpec,
                @"# REQUIRED
$query.Var.tprPolicyName = $someString"
            );
        }

        // Create new GraphQL Query:
        // orgSecurityPolicy: OrgSecurityPolicy!
        internal void InitQueryOrgSecurityPolicy()
        {
            Tuple<string, string>[] argDefs = {
            };
            Initialize(
                argDefs,
                "query",
                "QueryOrgSecurityPolicy",
                "",
                "OrgSecurityPolicy",
                Query.OrgSecurityPolicy,
                Query.OrgSecurityPolicyFieldSpec,
                @""
            );
        }

        // Create new GraphQL Query:
        // passwordComplexityPolicy: PasswordComplexityPolicy!
        internal void InitQueryPasswordComplexityPolicy()
        {
            Tuple<string, string>[] argDefs = {
            };
            Initialize(
                argDefs,
                "query",
                "QueryPasswordComplexityPolicy",
                "",
                "PasswordComplexityPolicy",
                Query.PasswordComplexityPolicy,
                Query.PasswordComplexityPolicyFieldSpec,
                @""
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
                Query.Policies,
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
        //     includeDataTypeHits: Boolean
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
                Tuple.Create("includeDataTypeHits", "Boolean"),
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryPolicy",
                "($policyId: String!,$workloadTypes: [DataGovObjectType!],$sortBy: PolicyDetailsSortBy,$sortOrder: SortOrder,$clusterIdsFilter: [String!],$replicationFilter: [String!],$searchObjectName: String,$hierarchyAncestorIdFilter: String,$policyAssignmentType: PolicyAssignmentType,$includeDataTypeHits: Boolean,$first: Int,$after: String,$last: Int,$before: String)",
                "ClassificationPolicyDetail",
                Query.Policy,
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
$query.Var.includeDataTypeHits = $someBoolean
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
                Query.PolicyObjectUsages,
                Query.PolicyObjectUsagesFieldSpec,
                @"# REQUIRED
$query.Var.objectIds = @(
	$someString
)"
            );
        }

        // Create new GraphQL Query:
        // allTopRiskPolicySummaries(getWhitelistedResults: Boolean!, limit: Int! = 0, workloadTypes: [DataGovObjectType!]! = []): [PolicySummary!]!
        internal void InitQueryAllTopRiskPolicySummaries()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("getWhitelistedResults", "Boolean!"),
                Tuple.Create("limit", "Int!"),
                Tuple.Create("workloadTypes", "[DataGovObjectType!]!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllTopRiskPolicySummaries",
                "($getWhitelistedResults: Boolean!,$limit: Int!,$workloadTypes: [DataGovObjectType!]!)",
                "List<PolicySummary>",
                Query.AllTopRiskPolicySummaries,
                Query.AllTopRiskPolicySummariesFieldSpec,
                @"# REQUIRED
$query.Var.getWhitelistedResults = $someBoolean
# REQUIRED
$query.Var.limit = $someInt
# REQUIRED
$query.Var.workloadTypes = @(
	$someDataGovObjectType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DataGovObjectType]) for enum values.
)"
            );
        }

        // Create new GraphQL Query:
        // tprPolicyDetail(tprPolicyId: UUID!): TprPolicyDetail!
        internal void InitQueryTprPolicyDetail()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("tprPolicyId", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryTprPolicyDetail",
                "($tprPolicyId: UUID!)",
                "TprPolicyDetail",
                Query.TprPolicyDetail,
                Query.TprPolicyDetailFieldSpec,
                @"# REQUIRED
$query.Var.tprPolicyId = $someString"
            );
        }


    } // class New_RscQueryPolicy
}