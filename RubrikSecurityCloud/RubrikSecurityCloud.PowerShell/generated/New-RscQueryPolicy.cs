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
    /// Create a new RscQuery object for any of the 19
    /// operations in the 'Policy' API domain:
    /// CustomTprPolicies, HaPolicies, IsValidTprPolicyName, OrgSecurityPolicy, PasswordComplexityPolicy, Policies, Policy, PolicyCategories, PolicyFilterTypes, PolicyFilterValues, PolicyFrameworks, PolicyObjectUsages, PolicyRiskSummaries, PolicyViolationTicketNumbers, SecurityPolicies, SecurityPolicy, SidsPolicyHitsSummary, TopRiskPolicySummaries, or TprPolicyDetail.
    /// </summary>
    /// <description>
    /// New-RscQueryPolicy creates a new
    /// query object for operations
    /// in the 'Policy' API domain. It only creates a data structure,
    /// it does not execute the operation. This cmdlet does not need a
    /// connection to run. To execute the operation, either call Invoke()
    /// on the object returned by this cmdlet, or pass the object to
    /// Invoke-Rsc.
    /// There are 19 operations
    /// in the 'Policy' API domain. Select the operation this
    /// query is for by specifying the appropriate value for the
    /// -Operation parameter;
    /// one of: CustomTprPolicies, HaPolicies, IsValidTprPolicyName, OrgSecurityPolicy, PasswordComplexityPolicy, Policies, Policy, PolicyCategories, PolicyFilterTypes, PolicyFilterValues, PolicyFrameworks, PolicyObjectUsages, PolicyRiskSummaries, PolicyViolationTicketNumbers, SecurityPolicies, SecurityPolicy, SidsPolicyHitsSummary, TopRiskPolicySummaries, or TprPolicyDetail.
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
    /// 	# OPTIONAL
    /// 	orgs = @(
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
    /// 	# OPTIONAL
    /// 	ids = @(
    /// 		$someString
    /// 	)
    /// 	# OPTIONAL
    /// 	sourceClusterUuids = @(
    /// 		$someString
    /// 	)
    /// 	# OPTIONAL
    /// 	targetClusterUuids = @(
    /// 		$someString
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
    /// Runs the PolicyCategories operation
    /// of the 'Policy' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Policy
    /// # API Operation: PolicyCategories
    /// 
    /// $query = New-RscQueryPolicy -Operation PolicyCategories
    /// 
    /// # REQUIRED
    /// $query.Var.policyTypes = @(
    /// 	$somePolicyType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.PolicyType]) for enum values.
    /// )
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: GetPossibleCategoriesType
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the PolicyFilterTypes operation
    /// of the 'Policy' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Policy
    /// # API Operation: PolicyFilterTypes
    /// 
    /// $query = New-RscQueryPolicy -Operation PolicyFilterTypes
    /// 
    /// # REQUIRED
    /// $query.Var.resourceType = $somePolicyResourceType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.PolicyResourceType]) for enum values.
    /// # REQUIRED
    /// $query.Var.policyType = $somePolicyType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.PolicyType]) for enum values.
    /// # OPTIONAL
    /// $query.Var.idpTypes = @(
    /// 	$someIdpType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.IdpType]) for enum values.
    /// )
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: List&lt;FilterType&gt;
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the PolicyFilterValues operation
    /// of the 'Policy' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Policy
    /// # API Operation: PolicyFilterValues
    /// 
    /// $query = New-RscQueryPolicy -Operation PolicyFilterValues
    /// 
    /// # REQUIRED
    /// $query.Var.policyFilterType = $someFilterType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.FilterType]) for enum values.
    /// # OPTIONAL
    /// $query.Var.searchTerm = $someString
    /// # REQUIRED
    /// $query.Var.policyType = $somePolicyType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.PolicyType]) for enum values.
    /// # OPTIONAL
    /// $query.Var.policyTypeFilter = @{
    /// 	# OPTIONAL
    /// 	identityEventFilter = @{
    /// 		# OPTIONAL
    /// 		eventProviders = @(
    /// 			$someEventProvider # Call [Enum]::GetValues([RubrikSecurityCloud.Types.EventProvider]) for enum values.
    /// 		)
    /// 	}
    /// }
    /// # OPTIONAL
    /// $query.Var.eventProviders = @(
    /// 	$someEventProvider # Call [Enum]::GetValues([RubrikSecurityCloud.Types.EventProvider]) for enum values.
    /// )
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: GetPolicyFilterValuesType
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the PolicyFrameworks operation
    /// of the 'Policy' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Policy
    /// # API Operation: PolicyFrameworks
    /// 
    /// $query = New-RscQueryPolicy -Operation PolicyFrameworks
    /// 
    /// # REQUIRED
    /// $query.Var.policyTypes = @(
    /// 	$somePolicyType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.PolicyType]) for enum values.
    /// )
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: List&lt;System.String&gt;
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
    /// Runs the PolicyRiskSummaries operation
    /// of the 'Policy' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Policy
    /// # API Operation: PolicyRiskSummaries
    /// 
    /// $query = New-RscQueryPolicy -Operation PolicyRiskSummaries
    /// 
    /// # REQUIRED
    /// $query.Var.policyIds = @(
    /// 	$someString
    /// )
    /// # REQUIRED
    /// $query.Var.summaryDate = $someString
    /// # OPTIONAL
    /// $query.Var.includeWhitelistedResults = $someBoolean
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: List&lt;PolicyRiskSummary&gt;
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the PolicyViolationTicketNumbers operation
    /// of the 'Policy' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Policy
    /// # API Operation: PolicyViolationTicketNumbers
    /// 
    /// $query = New-RscQueryPolicy -Operation PolicyViolationTicketNumbers
    /// 
    /// # REQUIRED
    /// $query.Var.policyTypes = @(
    /// 	$somePolicyType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.PolicyType]) for enum values.
    /// )
    /// # OPTIONAL
    /// $query.Var.searchTerm = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: List&lt;System.String&gt;
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the SecurityPolicies operation
    /// of the 'Policy' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Policy
    /// # API Operation: SecurityPolicies
    /// 
    /// $query = New-RscQueryPolicy -Operation SecurityPolicies
    /// 
    /// # OPTIONAL
    /// $query.Var.isPolicyEnabled = $someBoolean
    /// # OPTIONAL
    /// $query.Var.isCustomPolicy = $someBoolean
    /// # OPTIONAL
    /// $query.Var.policyCategories = @(
    /// 	$someCategory # Call [Enum]::GetValues([RubrikSecurityCloud.Types.Category]) for enum values.
    /// )
    /// # OPTIONAL
    /// $query.Var.policySeverities = @(
    /// 	$someSeverity # Call [Enum]::GetValues([RubrikSecurityCloud.Types.Severity]) for enum values.
    /// )
    /// # OPTIONAL
    /// $query.Var.includeViolationInsights = $someBoolean
    /// # OPTIONAL
    /// $query.Var.policyIds = @(
    /// 	$someString
    /// )
    /// # OPTIONAL
    /// $query.Var.resourceIds = @(
    /// 	$someString
    /// )
    /// # OPTIONAL
    /// $query.Var.statuses = @(
    /// 	$somePolicyViolationStatus # Call [Enum]::GetValues([RubrikSecurityCloud.Types.PolicyViolationStatus]) for enum values.
    /// )
    /// # OPTIONAL
    /// $query.Var.statusReasons = @(
    /// 	$somePolicyViolationStatusReason # Call [Enum]::GetValues([RubrikSecurityCloud.Types.PolicyViolationStatusReason]) for enum values.
    /// )
    /// # OPTIONAL
    /// $query.Var.policyViolationIds = @(
    /// 	$someString
    /// )
    /// # OPTIONAL
    /// $query.Var.resourceTypes = @(
    /// 	$somePolicyResourceType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.PolicyResourceType]) for enum values.
    /// )
    /// # OPTIONAL
    /// $query.Var.sensitivityLevels = @(
    /// 	$someSensitivityLevel # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SensitivityLevel]) for enum values.
    /// )
    /// # OPTIONAL
    /// $query.Var.detectionDate = @{
    /// 	# REQUIRED
    /// 	start = $someDateTime
    /// 	# REQUIRED
    /// 	end = $someDateTime
    /// }
    /// # OPTIONAL
    /// $query.Var.updateDate = @{
    /// 	# REQUIRED
    /// 	start = $someDateTime
    /// 	# REQUIRED
    /// 	end = $someDateTime
    /// }
    /// # OPTIONAL
    /// $query.Var.policyName = $someString
    /// # OPTIONAL
    /// $query.Var.exactPolicyName = $someString
    /// # OPTIONAL
    /// $query.Var.policyUpdateDate = @{
    /// 	# REQUIRED
    /// 	start = $someDateTime
    /// 	# REQUIRED
    /// 	end = $someDateTime
    /// }
    /// # OPTIONAL
    /// $query.Var.parentViolationId = $someString
    /// # OPTIONAL
    /// $query.Var.dataTypeIds = @(
    /// 	$someString
    /// )
    /// # OPTIONAL
    /// $query.Var.documentTypeIds = @(
    /// 	$someString
    /// )
    /// # OPTIONAL
    /// $query.Var.dataCategoryIds = @(
    /// 	$someString
    /// )
    /// # OPTIONAL
    /// $query.Var.sortBy = $somePolicyViolationSortField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.PolicyViolationSortField]) for enum values.
    /// # OPTIONAL
    /// $query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
    /// # OPTIONAL
    /// $query.Var.resourceMetadataFilter = @{
    /// 	# OPTIONAL
    /// 	objectTypes = @(
    /// 		$someDataGovObjectType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DataGovObjectType]) for enum values.
    /// 	)
    /// 	# OPTIONAL
    /// 	cloudAccountIds = @(
    /// 		$someString
    /// 	)
    /// 	# OPTIONAL
    /// 	managedObjectTypes = @(
    /// 		$someManagedObjectType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ManagedObjectType]) for enum values.
    /// 	)
    /// 	# OPTIONAL
    /// 	principalTypes = @(
    /// 		$someViolationPrincipalType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ViolationPrincipalType]) for enum values.
    /// 	)
    /// 	# OPTIONAL
    /// 	resolutionTypes = @(
    /// 		$someIdentityResolutionType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.IdentityResolutionType]) for enum values.
    /// 	)
    /// 	# OPTIONAL
    /// 	domainFids = @(
    /// 		$someString
    /// 	)
    /// 	# OPTIONAL
    /// 	identityNameSearch = $someString
    /// 	# OPTIONAL
    /// 	accessTypes = @(
    /// 		$someAccessVia # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AccessVia]) for enum values.
    /// 	)
    /// 	# OPTIONAL
    /// 	sources = @(
    /// 		$someString
    /// 	)
    /// 	# OPTIONAL
    /// 	idpTypes = @(
    /// 		$someIdpType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.IdpType]) for enum values.
    /// 	)
    /// 	# OPTIONAL
    /// 	originEventDateRange = @{
    /// 		# REQUIRED
    /// 		start = $someDateTime
    /// 		# REQUIRED
    /// 		end = $someDateTime
    /// 	}
    /// 	# OPTIONAL
    /// 	identityTags = @(
    /// 		$someIdentityTag # Call [Enum]::GetValues([RubrikSecurityCloud.Types.IdentityTag]) for enum values.
    /// 	)
    /// 	# OPTIONAL
    /// 	actorIds = @(
    /// 		$someString
    /// 	)
    /// 	# OPTIONAL
    /// 	identityOrigins = @(
    /// 		$somePrincipalOrigin # Call [Enum]::GetValues([RubrikSecurityCloud.Types.PrincipalOrigin]) for enum values.
    /// 	)
    /// }
    /// # OPTIONAL
    /// $query.Var.policyViolationNameSearch = $someString
    /// # OPTIONAL
    /// $query.Var.violationNames = @(
    /// 	$someString
    /// )
    /// # OPTIONAL
    /// $query.Var.policyFrameworks = @(
    /// 	$someString
    /// )
    /// # OPTIONAL
    /// $query.Var.idpTypes = @(
    /// 	$someIdpType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.IdpType]) for enum values.
    /// )
    /// # REQUIRED
    /// $query.Var.policyTypes = @(
    /// 	$somePolicyType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.PolicyType]) for enum values.
    /// )
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: List&lt;PolicyResult&gt;
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the SecurityPolicy operation
    /// of the 'Policy' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Policy
    /// # API Operation: SecurityPolicy
    /// 
    /// $query = New-RscQueryPolicy -Operation SecurityPolicy
    /// 
    /// # REQUIRED
    /// $query.Var.policyId = $someString
    /// # OPTIONAL
    /// $query.Var.includeViolationInsights = $someBoolean
    /// # REQUIRED
    /// $query.Var.policyType = $somePolicyType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.PolicyType]) for enum values.
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: PolicyResult
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the SidsPolicyHitsSummary operation
    /// of the 'Policy' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Policy
    /// # API Operation: SidsPolicyHitsSummary
    /// 
    /// $query = New-RscQueryPolicy -Operation SidsPolicyHitsSummary
    /// 
    /// # REQUIRED
    /// $query.Var.sids = @(
    /// 	$someString
    /// )
    /// # REQUIRED
    /// $query.Var.day = $someString
    /// # REQUIRED
    /// $query.Var.historicalDeltaDays = $someInt
    /// # OPTIONAL
    /// $query.Var.policyId = $someString
    /// # OPTIONAL
    /// $query.Var.objectIdsFilter = @(
    /// 	$someString
    /// )
    /// # OPTIONAL
    /// $query.Var.includeWhitelistedResults = $someBoolean
    /// # OPTIONAL
    /// $query.Var.sortBy = $someSidPolicySummarySortBy # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SidPolicySummarySortBy]) for enum values.
    /// # OPTIONAL
    /// $query.Var.platformCategoryFilter = @(
    /// 	$somePlatformCategory # Call [Enum]::GetValues([RubrikSecurityCloud.Types.PlatformCategory]) for enum values.
    /// )
    /// # OPTIONAL
    /// $query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
    /// # OPTIONAL
    /// $query.Var.shouldCalculateAggregatedDataTypeLevelResults = $someBoolean
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: SidsPolicyHitsSummaries
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
                "PolicyCategories",
                "PolicyFilterTypes",
                "PolicyFilterValues",
                "PolicyFrameworks",
                "PolicyObjectUsages",
                "PolicyRiskSummaries",
                "PolicyViolationTicketNumbers",
                "SecurityPolicies",
                "SecurityPolicy",
                "SidsPolicyHitsSummary",
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
                    case "PolicyCategories":
                        this.ProcessRecord_PolicyCategories();
                        break;
                    case "PolicyFilterTypes":
                        this.ProcessRecord_PolicyFilterTypes();
                        break;
                    case "PolicyFilterValues":
                        this.ProcessRecord_PolicyFilterValues();
                        break;
                    case "PolicyFrameworks":
                        this.ProcessRecord_PolicyFrameworks();
                        break;
                    case "PolicyObjectUsages":
                        this.ProcessRecord_PolicyObjectUsages();
                        break;
                    case "PolicyRiskSummaries":
                        this.ProcessRecord_PolicyRiskSummaries();
                        break;
                    case "PolicyViolationTicketNumbers":
                        this.ProcessRecord_PolicyViolationTicketNumbers();
                        break;
                    case "SecurityPolicies":
                        this.ProcessRecord_SecurityPolicies();
                        break;
                    case "SecurityPolicy":
                        this.ProcessRecord_SecurityPolicy();
                        break;
                    case "SidsPolicyHitsSummary":
                        this.ProcessRecord_SidsPolicyHitsSummary();
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
        // allPolicyCategories.
        internal void ProcessRecord_PolicyCategories()
        {
            this._logger.name += " -PolicyCategories";
            // Create new graphql operation allPolicyCategories
            InitQueryAllPolicyCategories();
        }

        // This parameter set invokes a single graphql operation:
        // allPolicyFilterTypes.
        internal void ProcessRecord_PolicyFilterTypes()
        {
            this._logger.name += " -PolicyFilterTypes";
            // Create new graphql operation allPolicyFilterTypes
            InitQueryAllPolicyFilterTypes();
        }

        // This parameter set invokes a single graphql operation:
        // allPolicyFilterValues.
        internal void ProcessRecord_PolicyFilterValues()
        {
            this._logger.name += " -PolicyFilterValues";
            // Create new graphql operation allPolicyFilterValues
            InitQueryAllPolicyFilterValues();
        }

        // This parameter set invokes a single graphql operation:
        // allPolicyFrameworks.
        internal void ProcessRecord_PolicyFrameworks()
        {
            this._logger.name += " -PolicyFrameworks";
            // Create new graphql operation allPolicyFrameworks
            InitQueryAllPolicyFrameworks();
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
        // allPolicyRiskSummaries.
        internal void ProcessRecord_PolicyRiskSummaries()
        {
            this._logger.name += " -PolicyRiskSummaries";
            // Create new graphql operation allPolicyRiskSummaries
            InitQueryAllPolicyRiskSummaries();
        }

        // This parameter set invokes a single graphql operation:
        // allPolicyViolationTicketNumbers.
        internal void ProcessRecord_PolicyViolationTicketNumbers()
        {
            this._logger.name += " -PolicyViolationTicketNumbers";
            // Create new graphql operation allPolicyViolationTicketNumbers
            InitQueryAllPolicyViolationTicketNumbers();
        }

        // This parameter set invokes a single graphql operation:
        // allSecurityPolicies.
        internal void ProcessRecord_SecurityPolicies()
        {
            this._logger.name += " -SecurityPolicies";
            // Create new graphql operation allSecurityPolicies
            InitQueryAllSecurityPolicies();
        }

        // This parameter set invokes a single graphql operation:
        // securityPolicy.
        internal void ProcessRecord_SecurityPolicy()
        {
            this._logger.name += " -SecurityPolicy";
            // Create new graphql operation securityPolicy
            InitQuerySecurityPolicy();
        }

        // This parameter set invokes a single graphql operation:
        // sidsPolicyHitsSummary.
        internal void ProcessRecord_SidsPolicyHitsSummary()
        {
            this._logger.name += " -SidsPolicyHitsSummary";
            // Create new graphql operation sidsPolicyHitsSummary
            InitQuerySidsPolicyHitsSummary();
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
	# OPTIONAL
	orgs = @(
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
	# OPTIONAL
	ids = @(
		$someString
	)
	# OPTIONAL
	sourceClusterUuids = @(
		$someString
	)
	# OPTIONAL
	targetClusterUuids = @(
		$someString
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
        // allPolicyCategories(policyTypes: [PolicyType!]!): GetPossibleCategoriesType!
        internal void InitQueryAllPolicyCategories()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("policyTypes", "[PolicyType!]!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllPolicyCategories",
                "($policyTypes: [PolicyType!]!)",
                "GetPossibleCategoriesType",
                Query.AllPolicyCategories,
                Query.AllPolicyCategoriesFieldSpec,
                @"# REQUIRED
$query.Var.policyTypes = @(
	$somePolicyType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.PolicyType]) for enum values.
)"
            );
        }

        // Create new GraphQL Query:
        // allPolicyFilterTypes(resourceType: PolicyResourceType!, policyType: PolicyType!, idpTypes: [IdpType!]): [FilterType!]!
        internal void InitQueryAllPolicyFilterTypes()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("resourceType", "PolicyResourceType!"),
                Tuple.Create("policyType", "PolicyType!"),
                Tuple.Create("idpTypes", "[IdpType!]"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllPolicyFilterTypes",
                "($resourceType: PolicyResourceType!,$policyType: PolicyType!,$idpTypes: [IdpType!])",
                "List<FilterType>",
                Query.AllPolicyFilterTypes,
                Query.AllPolicyFilterTypesFieldSpec,
                @"# REQUIRED
$query.Var.resourceType = $somePolicyResourceType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.PolicyResourceType]) for enum values.
# REQUIRED
$query.Var.policyType = $somePolicyType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.PolicyType]) for enum values.
# OPTIONAL
$query.Var.idpTypes = @(
	$someIdpType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.IdpType]) for enum values.
)"
            );
        }

        // Create new GraphQL Query:
        // allPolicyFilterValues(
        //     policyFilterType: FilterType!
        //     searchTerm: String
        //     policyType: PolicyType!
        //     policyTypeFilter: PolicyTypeFilter
        //     eventProviders: [EventProvider!]
        //   ): GetPolicyFilterValuesType!
        internal void InitQueryAllPolicyFilterValues()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("policyFilterType", "FilterType!"),
                Tuple.Create("searchTerm", "String"),
                Tuple.Create("policyType", "PolicyType!"),
                Tuple.Create("policyTypeFilter", "PolicyTypeFilter"),
                Tuple.Create("eventProviders", "[EventProvider!]"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllPolicyFilterValues",
                "($policyFilterType: FilterType!,$searchTerm: String,$policyType: PolicyType!,$policyTypeFilter: PolicyTypeFilter,$eventProviders: [EventProvider!])",
                "GetPolicyFilterValuesType",
                Query.AllPolicyFilterValues,
                Query.AllPolicyFilterValuesFieldSpec,
                @"# REQUIRED
$query.Var.policyFilterType = $someFilterType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.FilterType]) for enum values.
# OPTIONAL
$query.Var.searchTerm = $someString
# REQUIRED
$query.Var.policyType = $somePolicyType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.PolicyType]) for enum values.
# OPTIONAL
$query.Var.policyTypeFilter = @{
	# OPTIONAL
	identityEventFilter = @{
		# OPTIONAL
		eventProviders = @(
			$someEventProvider # Call [Enum]::GetValues([RubrikSecurityCloud.Types.EventProvider]) for enum values.
		)
	}
}
# OPTIONAL
$query.Var.eventProviders = @(
	$someEventProvider # Call [Enum]::GetValues([RubrikSecurityCloud.Types.EventProvider]) for enum values.
)"
            );
        }

        // Create new GraphQL Query:
        // allPolicyFrameworks(policyTypes: [PolicyType!]!): [String!]!
        internal void InitQueryAllPolicyFrameworks()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("policyTypes", "[PolicyType!]!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllPolicyFrameworks",
                "($policyTypes: [PolicyType!]!)",
                "List<System.String>",
                Query.AllPolicyFrameworks,
                Query.AllPolicyFrameworksFieldSpec,
                @"# REQUIRED
$query.Var.policyTypes = @(
	$somePolicyType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.PolicyType]) for enum values.
)"
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
        // allPolicyRiskSummaries(policyIds: [String!]!, summaryDate: String!, includeWhitelistedResults: Boolean = true): [PolicyRiskSummary!]!
        internal void InitQueryAllPolicyRiskSummaries()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("policyIds", "[String!]!"),
                Tuple.Create("summaryDate", "String!"),
                Tuple.Create("includeWhitelistedResults", "Boolean"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllPolicyRiskSummaries",
                "($policyIds: [String!]!,$summaryDate: String!,$includeWhitelistedResults: Boolean)",
                "List<PolicyRiskSummary>",
                Query.AllPolicyRiskSummaries,
                Query.AllPolicyRiskSummariesFieldSpec,
                @"# REQUIRED
$query.Var.policyIds = @(
	$someString
)
# REQUIRED
$query.Var.summaryDate = $someString
# OPTIONAL
$query.Var.includeWhitelistedResults = $someBoolean"
            );
        }

        // Create new GraphQL Query:
        // allPolicyViolationTicketNumbers(policyTypes: [PolicyType!]!, searchTerm: String): [String!]!
        internal void InitQueryAllPolicyViolationTicketNumbers()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("policyTypes", "[PolicyType!]!"),
                Tuple.Create("searchTerm", "String"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllPolicyViolationTicketNumbers",
                "($policyTypes: [PolicyType!]!,$searchTerm: String)",
                "List<System.String>",
                Query.AllPolicyViolationTicketNumbers,
                Query.AllPolicyViolationTicketNumbersFieldSpec,
                @"# REQUIRED
$query.Var.policyTypes = @(
	$somePolicyType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.PolicyType]) for enum values.
)
# OPTIONAL
$query.Var.searchTerm = $someString"
            );
        }

        // Create new GraphQL Query:
        // allSecurityPolicies(
        //     isPolicyEnabled: Boolean
        //     isCustomPolicy: Boolean
        //     policyCategories: [Category!]
        //     policySeverities: [Severity!]
        //     includeViolationInsights: Boolean = false
        //     policyIds: [UUID!]
        //     resourceIds: [String!]
        //     statuses: [PolicyViolationStatus!]
        //     statusReasons: [PolicyViolationStatusReason!]
        //     policyViolationIds: [UUID!]
        //     resourceTypes: [PolicyResourceType!]
        //     sensitivityLevels: [SensitivityLevel!]
        //     detectionDate: TimeRangeInput
        //     updateDate: TimeRangeInput
        //     policyName: String
        //     exactPolicyName: String
        //     policyUpdateDate: TimeRangeInput
        //     parentViolationId: UUID
        //     dataTypeIds: [String!]
        //     documentTypeIds: [UUID!]
        //     dataCategoryIds: [String!]
        //     sortBy: PolicyViolationSortField
        //     sortOrder: SortOrder
        //     resourceMetadataFilter: ResourceMetadataFiltersInput
        //     policyViolationNameSearch: String
        //     violationNames: [String!]
        //     policyFrameworks: [String!]
        //     idpTypes: [IdpType!]
        //     policyTypes: [PolicyType!]!
        //   ): [PolicyResult!]!
        internal void InitQueryAllSecurityPolicies()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("isPolicyEnabled", "Boolean"),
                Tuple.Create("isCustomPolicy", "Boolean"),
                Tuple.Create("policyCategories", "[Category!]"),
                Tuple.Create("policySeverities", "[Severity!]"),
                Tuple.Create("includeViolationInsights", "Boolean"),
                Tuple.Create("policyIds", "[UUID!]"),
                Tuple.Create("resourceIds", "[String!]"),
                Tuple.Create("statuses", "[PolicyViolationStatus!]"),
                Tuple.Create("statusReasons", "[PolicyViolationStatusReason!]"),
                Tuple.Create("policyViolationIds", "[UUID!]"),
                Tuple.Create("resourceTypes", "[PolicyResourceType!]"),
                Tuple.Create("sensitivityLevels", "[SensitivityLevel!]"),
                Tuple.Create("detectionDate", "TimeRangeInput"),
                Tuple.Create("updateDate", "TimeRangeInput"),
                Tuple.Create("policyName", "String"),
                Tuple.Create("exactPolicyName", "String"),
                Tuple.Create("policyUpdateDate", "TimeRangeInput"),
                Tuple.Create("parentViolationId", "UUID"),
                Tuple.Create("dataTypeIds", "[String!]"),
                Tuple.Create("documentTypeIds", "[UUID!]"),
                Tuple.Create("dataCategoryIds", "[String!]"),
                Tuple.Create("sortBy", "PolicyViolationSortField"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("resourceMetadataFilter", "ResourceMetadataFiltersInput"),
                Tuple.Create("policyViolationNameSearch", "String"),
                Tuple.Create("violationNames", "[String!]"),
                Tuple.Create("policyFrameworks", "[String!]"),
                Tuple.Create("idpTypes", "[IdpType!]"),
                Tuple.Create("policyTypes", "[PolicyType!]!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllSecurityPolicies",
                "($isPolicyEnabled: Boolean,$isCustomPolicy: Boolean,$policyCategories: [Category!],$policySeverities: [Severity!],$includeViolationInsights: Boolean,$policyIds: [UUID!],$resourceIds: [String!],$statuses: [PolicyViolationStatus!],$statusReasons: [PolicyViolationStatusReason!],$policyViolationIds: [UUID!],$resourceTypes: [PolicyResourceType!],$sensitivityLevels: [SensitivityLevel!],$detectionDate: TimeRangeInput,$updateDate: TimeRangeInput,$policyName: String,$exactPolicyName: String,$policyUpdateDate: TimeRangeInput,$parentViolationId: UUID,$dataTypeIds: [String!],$documentTypeIds: [UUID!],$dataCategoryIds: [String!],$sortBy: PolicyViolationSortField,$sortOrder: SortOrder,$resourceMetadataFilter: ResourceMetadataFiltersInput,$policyViolationNameSearch: String,$violationNames: [String!],$policyFrameworks: [String!],$idpTypes: [IdpType!],$policyTypes: [PolicyType!]!)",
                "List<PolicyResult>",
                Query.AllSecurityPolicies,
                Query.AllSecurityPoliciesFieldSpec,
                @"# OPTIONAL
$query.Var.isPolicyEnabled = $someBoolean
# OPTIONAL
$query.Var.isCustomPolicy = $someBoolean
# OPTIONAL
$query.Var.policyCategories = @(
	$someCategory # Call [Enum]::GetValues([RubrikSecurityCloud.Types.Category]) for enum values.
)
# OPTIONAL
$query.Var.policySeverities = @(
	$someSeverity # Call [Enum]::GetValues([RubrikSecurityCloud.Types.Severity]) for enum values.
)
# OPTIONAL
$query.Var.includeViolationInsights = $someBoolean
# OPTIONAL
$query.Var.policyIds = @(
	$someString
)
# OPTIONAL
$query.Var.resourceIds = @(
	$someString
)
# OPTIONAL
$query.Var.statuses = @(
	$somePolicyViolationStatus # Call [Enum]::GetValues([RubrikSecurityCloud.Types.PolicyViolationStatus]) for enum values.
)
# OPTIONAL
$query.Var.statusReasons = @(
	$somePolicyViolationStatusReason # Call [Enum]::GetValues([RubrikSecurityCloud.Types.PolicyViolationStatusReason]) for enum values.
)
# OPTIONAL
$query.Var.policyViolationIds = @(
	$someString
)
# OPTIONAL
$query.Var.resourceTypes = @(
	$somePolicyResourceType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.PolicyResourceType]) for enum values.
)
# OPTIONAL
$query.Var.sensitivityLevels = @(
	$someSensitivityLevel # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SensitivityLevel]) for enum values.
)
# OPTIONAL
$query.Var.detectionDate = @{
	# REQUIRED
	start = $someDateTime
	# REQUIRED
	end = $someDateTime
}
# OPTIONAL
$query.Var.updateDate = @{
	# REQUIRED
	start = $someDateTime
	# REQUIRED
	end = $someDateTime
}
# OPTIONAL
$query.Var.policyName = $someString
# OPTIONAL
$query.Var.exactPolicyName = $someString
# OPTIONAL
$query.Var.policyUpdateDate = @{
	# REQUIRED
	start = $someDateTime
	# REQUIRED
	end = $someDateTime
}
# OPTIONAL
$query.Var.parentViolationId = $someString
# OPTIONAL
$query.Var.dataTypeIds = @(
	$someString
)
# OPTIONAL
$query.Var.documentTypeIds = @(
	$someString
)
# OPTIONAL
$query.Var.dataCategoryIds = @(
	$someString
)
# OPTIONAL
$query.Var.sortBy = $somePolicyViolationSortField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.PolicyViolationSortField]) for enum values.
# OPTIONAL
$query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$query.Var.resourceMetadataFilter = @{
	# OPTIONAL
	objectTypes = @(
		$someDataGovObjectType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DataGovObjectType]) for enum values.
	)
	# OPTIONAL
	cloudAccountIds = @(
		$someString
	)
	# OPTIONAL
	managedObjectTypes = @(
		$someManagedObjectType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ManagedObjectType]) for enum values.
	)
	# OPTIONAL
	principalTypes = @(
		$someViolationPrincipalType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ViolationPrincipalType]) for enum values.
	)
	# OPTIONAL
	resolutionTypes = @(
		$someIdentityResolutionType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.IdentityResolutionType]) for enum values.
	)
	# OPTIONAL
	domainFids = @(
		$someString
	)
	# OPTIONAL
	identityNameSearch = $someString
	# OPTIONAL
	accessTypes = @(
		$someAccessVia # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AccessVia]) for enum values.
	)
	# OPTIONAL
	sources = @(
		$someString
	)
	# OPTIONAL
	idpTypes = @(
		$someIdpType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.IdpType]) for enum values.
	)
	# OPTIONAL
	originEventDateRange = @{
		# REQUIRED
		start = $someDateTime
		# REQUIRED
		end = $someDateTime
	}
	# OPTIONAL
	identityTags = @(
		$someIdentityTag # Call [Enum]::GetValues([RubrikSecurityCloud.Types.IdentityTag]) for enum values.
	)
	# OPTIONAL
	actorIds = @(
		$someString
	)
	# OPTIONAL
	identityOrigins = @(
		$somePrincipalOrigin # Call [Enum]::GetValues([RubrikSecurityCloud.Types.PrincipalOrigin]) for enum values.
	)
}
# OPTIONAL
$query.Var.policyViolationNameSearch = $someString
# OPTIONAL
$query.Var.violationNames = @(
	$someString
)
# OPTIONAL
$query.Var.policyFrameworks = @(
	$someString
)
# OPTIONAL
$query.Var.idpTypes = @(
	$someIdpType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.IdpType]) for enum values.
)
# REQUIRED
$query.Var.policyTypes = @(
	$somePolicyType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.PolicyType]) for enum values.
)"
            );
        }

        // Create new GraphQL Query:
        // securityPolicy(policyId: UUID!, includeViolationInsights: Boolean = false, policyType: PolicyType!): PolicyResult!
        internal void InitQuerySecurityPolicy()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("policyId", "UUID!"),
                Tuple.Create("includeViolationInsights", "Boolean"),
                Tuple.Create("policyType", "PolicyType!"),
            };
            Initialize(
                argDefs,
                "query",
                "QuerySecurityPolicy",
                "($policyId: UUID!,$includeViolationInsights: Boolean,$policyType: PolicyType!)",
                "PolicyResult",
                Query.SecurityPolicy,
                Query.SecurityPolicyFieldSpec,
                @"# REQUIRED
$query.Var.policyId = $someString
# OPTIONAL
$query.Var.includeViolationInsights = $someBoolean
# REQUIRED
$query.Var.policyType = $somePolicyType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.PolicyType]) for enum values."
            );
        }

        // Create new GraphQL Query:
        // sidsPolicyHitsSummary(
        //     sids: [String!]!
        //     day: String!
        //     historicalDeltaDays: Int! = 0
        //     policyId: String
        //     objectIdsFilter: [String!]
        //     includeWhitelistedResults: Boolean = true
        //     sortBy: SidPolicySummarySortBy
        //     platformCategoryFilter: [PlatformCategory!]
        //     sortOrder: SortOrder = DESC
        //     shouldCalculateAggregatedDataTypeLevelResults: Boolean
        //   ): SidsPolicyHitsSummaries!
        internal void InitQuerySidsPolicyHitsSummary()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("sids", "[String!]!"),
                Tuple.Create("day", "String!"),
                Tuple.Create("historicalDeltaDays", "Int!"),
                Tuple.Create("policyId", "String"),
                Tuple.Create("objectIdsFilter", "[String!]"),
                Tuple.Create("includeWhitelistedResults", "Boolean"),
                Tuple.Create("sortBy", "SidPolicySummarySortBy"),
                Tuple.Create("platformCategoryFilter", "[PlatformCategory!]"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("shouldCalculateAggregatedDataTypeLevelResults", "Boolean"),
            };
            Initialize(
                argDefs,
                "query",
                "QuerySidsPolicyHitsSummary",
                "($sids: [String!]!,$day: String!,$historicalDeltaDays: Int!,$policyId: String,$objectIdsFilter: [String!],$includeWhitelistedResults: Boolean,$sortBy: SidPolicySummarySortBy,$platformCategoryFilter: [PlatformCategory!],$sortOrder: SortOrder,$shouldCalculateAggregatedDataTypeLevelResults: Boolean)",
                "SidsPolicyHitsSummaries",
                Query.SidsPolicyHitsSummary,
                Query.SidsPolicyHitsSummaryFieldSpec,
                @"# REQUIRED
$query.Var.sids = @(
	$someString
)
# REQUIRED
$query.Var.day = $someString
# REQUIRED
$query.Var.historicalDeltaDays = $someInt
# OPTIONAL
$query.Var.policyId = $someString
# OPTIONAL
$query.Var.objectIdsFilter = @(
	$someString
)
# OPTIONAL
$query.Var.includeWhitelistedResults = $someBoolean
# OPTIONAL
$query.Var.sortBy = $someSidPolicySummarySortBy # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SidPolicySummarySortBy]) for enum values.
# OPTIONAL
$query.Var.platformCategoryFilter = @(
	$somePlatformCategory # Call [Enum]::GetValues([RubrikSecurityCloud.Types.PlatformCategory]) for enum values.
)
# OPTIONAL
$query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$query.Var.shouldCalculateAggregatedDataTypeLevelResults = $someBoolean"
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