// New-RscQuerySla.cs
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
    /// Create a new RscQuery object for any of the 14
    /// operations in the 'SLA' API domain:
    /// AuditDetail, ClusterDomains, ClusterGlobals, ConflictObjects, CountOfObjectsProtected, Domain, Domains, GlobalFilterList, GlobalStatuses, ManagedVolume, ManagedVolumes, NcdComplianceData, SummariesByIds, or VerifyWithReplicationToCluster.
    /// </summary>
    /// <description>
    /// New-RscQuerySla creates a new
    /// query object for operations
    /// in the 'SLA' API domain. It only creates a data structure,
    /// it does not execute the operation. This cmdlet does not need a
    /// connection to run. To execute the operation, either call Invoke()
    /// on the object returned by this cmdlet, or pass the object to
    /// Invoke-Rsc.
    /// There are 14 operations
    /// in the 'SLA' API domain. Select the operation this
    /// query is for by specifying the appropriate value for the
    /// -Operation parameter;
    /// one of: AuditDetail, ClusterDomains, ClusterGlobals, ConflictObjects, CountOfObjectsProtected, Domain, Domains, GlobalFilterList, GlobalStatuses, ManagedVolume, ManagedVolumes, NcdComplianceData, SummariesByIds, or VerifyWithReplicationToCluster.
    /// Each operation has its own set of variables that can be set with
    /// the -Var parameter. For more info about the variables, 
    /// call Info() on the object returned by this cmdlet, for example:
    /// (New-RscQuerySla -AuditDetail).Info().
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
    /// (New-RscQuerySla -AuditDetail).Info().
    /// You can combine a -Field parameter with patching parameters.
    /// -Field is applied first, then -FilePatch, -AddField and -RemoveField.
    ///
    /// </description>
    ///
    /// <example>
    /// Runs the AuditDetail operation
    /// of the 'SLA' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Sla
    /// # API Operation: AuditDetail
    /// 
    /// $query = New-RscQuerySla -AuditDetail
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
    /// $query.Var.SlaId = $someString
    /// # OPTIONAL
    /// $query.Var.filter = @(
    /// 	@{
    /// 		# OPTIONAL
    /// 		field = $someSLAAuditDetailFilterFieldEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SLAAuditDetailFilterFieldEnum]) for enum values.
    /// 		# OPTIONAL
    /// 		text = $someString
    /// }
    /// )
    /// # OPTIONAL
    /// $query.Var.timezone = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: List&lt;SlaAuditDetail&gt;
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the ClusterDomains operation
    /// of the 'SLA' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Sla
    /// # API Operation: ClusterDomains
    /// 
    /// $query = New-RscQuerySla -ClusterDomains
    /// 
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
    /// Write-Host $result.GetType().Name # prints: ClusterSlaDomainConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the ClusterGlobals operation
    /// of the 'SLA' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Sla
    /// # API Operation: ClusterGlobals
    /// 
    /// $query = New-RscQuerySla -ClusterGlobals
    /// 
    /// # REQUIRED
    /// $query.Var.cdmClusterUUID = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: List&lt;SlaInfo&gt;
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the ConflictObjects operation
    /// of the 'SLA' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Sla
    /// # API Operation: ConflictObjects
    /// 
    /// $query = New-RscQuerySla -ConflictObjects
    /// 
    /// # REQUIRED
    /// $query.Var.fids = @(
    /// 	$someString
    /// )
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: List&lt;HierarchyObject&gt;
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CountOfObjectsProtected operation
    /// of the 'SLA' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Sla
    /// # API Operation: CountOfObjectsProtected
    /// 
    /// $query = New-RscQuerySla -CountOfObjectsProtected
    /// 
    /// # OPTIONAL
    /// $query.Var.rootOptionalFid = $someString
    /// # REQUIRED
    /// $query.Var.slaIds = @(
    /// 	$someString
    /// )
    /// # OPTIONAL
    /// $query.Var.filter = @(
    /// 	@{
    /// 		# OPTIONAL
    /// 		field = $someHierarchyFilterField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchyFilterField]) for enum values.
    /// 		# OPTIONAL
    /// 		texts = @(
    /// 			$someString
    /// 		)
    /// 		# OPTIONAL
    /// 		tagFilterParams = @(
    /// 			@{
    /// 				# OPTIONAL
    /// 				filterType = $someTagFilterType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TagFilterType]) for enum values.
    /// 				# OPTIONAL
    /// 				tagKey = $someString
    /// 				# OPTIONAL
    /// 				tagValue = $someString
    /// 			}
    /// 		)
    /// 		# OPTIONAL
    /// 		objectTypeFilterParams = @(
    /// 			$someManagedObjectType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ManagedObjectType]) for enum values.
    /// 		)
    /// 		# OPTIONAL
    /// 		awsNativeProtectionFeatureNames = @(
    /// 			$someAwsNativeProtectionFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeProtectionFeature]) for enum values.
    /// 		)
    /// 		# OPTIONAL
    /// 		isNegative = $someBoolean
    /// 		# OPTIONAL
    /// 		isSlowSearchEnabled = $someBoolean
    /// 		# OPTIONAL
    /// 		azureNativeProtectionFeatureNames = @(
    /// 			$someAzureNativeProtectionFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeProtectionFeature]) for enum values.
    /// 		)
    /// 		# OPTIONAL
    /// 		unmanagedObjectAvailabilityFilter = @(
    /// 			$someUnmanagedObjectAvailabilityFilter # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UnmanagedObjectAvailabilityFilter]) for enum values.
    /// 		)
    /// }
    /// )
    /// # OPTIONAL
    /// $query.Var.typeFilter = @(
    /// 	$someHierarchyObjectTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchyObjectTypeEnum]) for enum values.
    /// )
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: CountOfObjectsProtectedBySlAsResult
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the Domain operation
    /// of the 'SLA' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Sla
    /// # API Operation: Domain
    /// 
    /// $query = New-RscQuerySla -Domain
    /// 
    /// # REQUIRED
    /// $query.Var.id = $someString
    /// # OPTIONAL
    /// $query.Var.shouldShowSyncStatus = $someBoolean
    /// # OPTIONAL
    /// $query.Var.shouldShowUpgradeInfo = $someBoolean
    /// # OPTIONAL
    /// $query.Var.shouldShowPausedClusters = $someBoolean
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: SlaDomain
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the Domains operation
    /// of the 'SLA' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Sla
    /// # API Operation: Domains
    /// 
    /// $query = New-RscQuerySla -Domains
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
    /// $query.Var.sortBy = $someSlaQuerySortByField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SlaQuerySortByField]) for enum values.
    /// # OPTIONAL
    /// $query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
    /// # OPTIONAL
    /// $query.Var.filter = @(
    /// 	@{
    /// 		# OPTIONAL
    /// 		field = $someGlobalSlaQueryFilterInputField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.GlobalSlaQueryFilterInputField]) for enum values.
    /// 		# OPTIONAL
    /// 		text = $someString
    /// 		# OPTIONAL
    /// 		objectTypeList = @(
    /// 			$someSlaObjectType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SlaObjectType]) for enum values.
    /// 		)
    /// 		# OPTIONAL
    /// 		textList = @(
    /// 			$someString
    /// 		)
    /// }
    /// )
    /// # OPTIONAL
    /// $query.Var.contextFilter = $someContextFilterTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ContextFilterTypeEnum]) for enum values.
    /// # OPTIONAL
    /// $query.Var.contextFilterInput = @(
    /// 	@{
    /// 		# REQUIRED
    /// 		field = $someString
    /// 		# REQUIRED
    /// 		text = $someString
    /// }
    /// )
    /// # OPTIONAL
    /// $query.Var.shouldShowSyncStatus = $someBoolean
    /// # OPTIONAL
    /// $query.Var.shouldShowProtectedObjectCount = $someBoolean
    /// # OPTIONAL
    /// $query.Var.shouldShowUpgradeInfo = $someBoolean
    /// # OPTIONAL
    /// $query.Var.showRemoteSlas = $someBoolean
    /// # OPTIONAL
    /// $query.Var.shouldShowPausedClusters = $someBoolean
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: SlaDomainConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the GlobalFilterList operation
    /// of the 'SLA' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Sla
    /// # API Operation: GlobalFilterList
    /// 
    /// $query = New-RscQuerySla -GlobalFilterList
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
    /// $query.Var.sortBy = $someSlaQuerySortByField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SlaQuerySortByField]) for enum values.
    /// # OPTIONAL
    /// $query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
    /// # OPTIONAL
    /// $query.Var.filter = @(
    /// 	@{
    /// 		# OPTIONAL
    /// 		field = $someGlobalSlaQueryFilterInputField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.GlobalSlaQueryFilterInputField]) for enum values.
    /// 		# OPTIONAL
    /// 		text = $someString
    /// 		# OPTIONAL
    /// 		objectTypeList = @(
    /// 			$someSlaObjectType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SlaObjectType]) for enum values.
    /// 		)
    /// 		# OPTIONAL
    /// 		textList = @(
    /// 			$someString
    /// 		)
    /// }
    /// )
    /// # OPTIONAL
    /// $query.Var.contextFilter = $someContextFilterTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ContextFilterTypeEnum]) for enum values.
    /// # OPTIONAL
    /// $query.Var.contextFilterInput = @(
    /// 	@{
    /// 		# REQUIRED
    /// 		field = $someString
    /// 		# REQUIRED
    /// 		text = $someString
    /// }
    /// )
    /// # OPTIONAL
    /// $query.Var.shouldShowSyncStatus = $someBoolean
    /// # OPTIONAL
    /// $query.Var.shouldShowProtectedObjectCount = $someBoolean
    /// # OPTIONAL
    /// $query.Var.shouldShowUpgradeInfo = $someBoolean
    /// # OPTIONAL
    /// $query.Var.showRemoteSlas = $someBoolean
    /// # OPTIONAL
    /// $query.Var.shouldShowPausedClusters = $someBoolean
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: GlobalSlaForFilterConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the GlobalStatuses operation
    /// of the 'SLA' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Sla
    /// # API Operation: GlobalStatuses
    /// 
    /// $query = New-RscQuerySla -GlobalStatuses
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
    /// 		field = $someSlaStatusFilterField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SlaStatusFilterField]) for enum values.
    /// 		# OPTIONAL
    /// 		text = $someString
    /// }
    /// )
    /// # REQUIRED
    /// $query.Var.SlaId = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: GlobalSlaStatusConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the ManagedVolume operation
    /// of the 'SLA' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Sla
    /// # API Operation: ManagedVolume
    /// 
    /// $query = New-RscQuerySla -ManagedVolume
    /// 
    /// # REQUIRED
    /// $query.Var.fid = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: ManagedVolume
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the ManagedVolumes operation
    /// of the 'SLA' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Sla
    /// # API Operation: ManagedVolumes
    /// 
    /// $query = New-RscQuerySla -ManagedVolumes
    /// 
    /// # OPTIONAL
    /// $query.Var.first = $someInt
    /// # OPTIONAL
    /// $query.Var.after = $someString
    /// # OPTIONAL
    /// $query.Var.sortBy = $someHierarchySortByField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchySortByField]) for enum values.
    /// # OPTIONAL
    /// $query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
    /// # OPTIONAL
    /// $query.Var.filter = @(
    /// 	@{
    /// 		# OPTIONAL
    /// 		field = $someHierarchyFilterField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchyFilterField]) for enum values.
    /// 		# OPTIONAL
    /// 		texts = @(
    /// 			$someString
    /// 		)
    /// 		# OPTIONAL
    /// 		tagFilterParams = @(
    /// 			@{
    /// 				# OPTIONAL
    /// 				filterType = $someTagFilterType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TagFilterType]) for enum values.
    /// 				# OPTIONAL
    /// 				tagKey = $someString
    /// 				# OPTIONAL
    /// 				tagValue = $someString
    /// 			}
    /// 		)
    /// 		# OPTIONAL
    /// 		objectTypeFilterParams = @(
    /// 			$someManagedObjectType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ManagedObjectType]) for enum values.
    /// 		)
    /// 		# OPTIONAL
    /// 		awsNativeProtectionFeatureNames = @(
    /// 			$someAwsNativeProtectionFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeProtectionFeature]) for enum values.
    /// 		)
    /// 		# OPTIONAL
    /// 		isNegative = $someBoolean
    /// 		# OPTIONAL
    /// 		isSlowSearchEnabled = $someBoolean
    /// 		# OPTIONAL
    /// 		azureNativeProtectionFeatureNames = @(
    /// 			$someAzureNativeProtectionFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeProtectionFeature]) for enum values.
    /// 		)
    /// 		# OPTIONAL
    /// 		unmanagedObjectAvailabilityFilter = @(
    /// 			$someUnmanagedObjectAvailabilityFilter # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UnmanagedObjectAvailabilityFilter]) for enum values.
    /// 		)
    /// }
    /// )
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: ManagedVolumeConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the NcdComplianceData operation
    /// of the 'SLA' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Sla
    /// # API Operation: NcdComplianceData
    /// 
    /// $query = New-RscQuerySla -NcdComplianceData
    /// 
    /// # REQUIRED
    /// $query.Var.clusters = @(
    /// 	$someString
    /// )
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: List&lt;NcdSlaComplianceData&gt;
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the SummariesByIds operation
    /// of the 'SLA' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Sla
    /// # API Operation: SummariesByIds
    /// 
    /// $query = New-RscQuerySla -SummariesByIds
    /// 
    /// # REQUIRED
    /// $query.Var.slaIds = @(
    /// 	$someString
    /// )
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: List&lt;SlaDomain&gt;
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the VerifyWithReplicationToCluster operation
    /// of the 'SLA' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Sla
    /// # API Operation: VerifyWithReplicationToCluster
    /// 
    /// $query = New-RscQuerySla -VerifyWithReplicationToCluster
    /// 
    /// # REQUIRED
    /// $query.Var.cdmClusterUUID = $someString
    /// # REQUIRED
    /// $query.Var.includeArchived = $someBoolean
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: VerifySlaWithReplicationToClusterResponse
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
        "RscQuerySla",
        DefaultParameterSetName = "Operation")
    ]
    public class New_RscQuerySla : RscGqlPSCmdlet
    {
        [Parameter(
            Mandatory = true, 
            ParameterSetName = "Operation",
            HelpMessage = "API Operation. The set of operations depends on the API domain. See reference at: https://github.com/rubrikinc/rubrik-powershell-sdk/blob/main/docs/domains_and_operations.md",
            Position = 0,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = true)]
            [ValidateSet(
                "AuditDetail",
                "ClusterDomains",
                "ClusterGlobals",
                "ConflictObjects",
                "CountOfObjectsProtected",
                "Domain",
                "Domains",
                "GlobalFilterList",
                "GlobalStatuses",
                "ManagedVolume",
                "ManagedVolumes",
                "NcdComplianceData",
                "SummariesByIds",
                "VerifyWithReplicationToCluster",
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
                    case "AuditDetail":
                        this.ProcessRecord_AuditDetail();
                        break;
                    case "ClusterDomains":
                        this.ProcessRecord_ClusterDomains();
                        break;
                    case "ClusterGlobals":
                        this.ProcessRecord_ClusterGlobals();
                        break;
                    case "ConflictObjects":
                        this.ProcessRecord_ConflictObjects();
                        break;
                    case "CountOfObjectsProtected":
                        this.ProcessRecord_CountOfObjectsProtected();
                        break;
                    case "Domain":
                        this.ProcessRecord_Domain();
                        break;
                    case "Domains":
                        this.ProcessRecord_Domains();
                        break;
                    case "GlobalFilterList":
                        this.ProcessRecord_GlobalFilterList();
                        break;
                    case "GlobalStatuses":
                        this.ProcessRecord_GlobalStatuses();
                        break;
                    case "ManagedVolume":
                        this.ProcessRecord_ManagedVolume();
                        break;
                    case "ManagedVolumes":
                        this.ProcessRecord_ManagedVolumes();
                        break;
                    case "NcdComplianceData":
                        this.ProcessRecord_NcdComplianceData();
                        break;
                    case "SummariesByIds":
                        this.ProcessRecord_SummariesByIds();
                        break;
                    case "VerifyWithReplicationToCluster":
                        this.ProcessRecord_VerifyWithReplicationToCluster();
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
        // slaAuditDetail.
        internal void ProcessRecord_AuditDetail()
        {
            this._logger.name += " -AuditDetail";
            // Create new graphql operation slaAuditDetail
            InitQuerySlaAuditDetail();
        }

        // This parameter set invokes a single graphql operation:
        // clusterSlaDomains.
        internal void ProcessRecord_ClusterDomains()
        {
            this._logger.name += " -ClusterDomains";
            // Create new graphql operation clusterSlaDomains
            InitQueryClusterSlaDomains();
        }

        // This parameter set invokes a single graphql operation:
        // allClusterGlobalSlas.
        internal void ProcessRecord_ClusterGlobals()
        {
            this._logger.name += " -ClusterGlobals";
            // Create new graphql operation allClusterGlobalSlas
            InitQueryAllClusterGlobalSlas();
        }

        // This parameter set invokes a single graphql operation:
        // slaConflictObjects.
        internal void ProcessRecord_ConflictObjects()
        {
            this._logger.name += " -ConflictObjects";
            // Create new graphql operation slaConflictObjects
            InitQuerySlaConflictObjects();
        }

        // This parameter set invokes a single graphql operation:
        // countOfObjectsProtectedBySlas.
        internal void ProcessRecord_CountOfObjectsProtected()
        {
            this._logger.name += " -CountOfObjectsProtected";
            // Create new graphql operation countOfObjectsProtectedBySlas
            InitQueryCountOfObjectsProtectedBySlas();
        }

        // This parameter set invokes a single graphql operation:
        // slaDomain.
        internal void ProcessRecord_Domain()
        {
            this._logger.name += " -Domain";
            // Create new graphql operation slaDomain
            InitQuerySlaDomain();
        }

        // This parameter set invokes a single graphql operation:
        // slaDomains.
        internal void ProcessRecord_Domains()
        {
            this._logger.name += " -Domains";
            // Create new graphql operation slaDomains
            InitQuerySlaDomains();
        }

        // This parameter set invokes a single graphql operation:
        // globalSlaFilterConnection.
        internal void ProcessRecord_GlobalFilterList()
        {
            this._logger.name += " -GlobalFilterList";
            // Create new graphql operation globalSlaFilterConnection
            InitQueryGlobalSlaFilterConnection();
        }

        // This parameter set invokes a single graphql operation:
        // globalSlaStatuses.
        internal void ProcessRecord_GlobalStatuses()
        {
            this._logger.name += " -GlobalStatuses";
            // Create new graphql operation globalSlaStatuses
            InitQueryGlobalSlaStatuses();
        }

        // This parameter set invokes a single graphql operation:
        // slaManagedVolume.
        internal void ProcessRecord_ManagedVolume()
        {
            this._logger.name += " -ManagedVolume";
            // Create new graphql operation slaManagedVolume
            InitQuerySlaManagedVolume();
        }

        // This parameter set invokes a single graphql operation:
        // slaManagedVolumes.
        internal void ProcessRecord_ManagedVolumes()
        {
            this._logger.name += " -ManagedVolumes";
            // Create new graphql operation slaManagedVolumes
            InitQuerySlaManagedVolumes();
        }

        // This parameter set invokes a single graphql operation:
        // allNcdSlaComplianceData.
        internal void ProcessRecord_NcdComplianceData()
        {
            this._logger.name += " -NcdComplianceData";
            // Create new graphql operation allNcdSlaComplianceData
            InitQueryAllNcdSlaComplianceData();
        }

        // This parameter set invokes a single graphql operation:
        // allSlaSummariesByIds.
        internal void ProcessRecord_SummariesByIds()
        {
            this._logger.name += " -SummariesByIds";
            // Create new graphql operation allSlaSummariesByIds
            InitQueryAllSlaSummariesByIds();
        }

        // This parameter set invokes a single graphql operation:
        // verifySlaWithReplicationToCluster.
        internal void ProcessRecord_VerifyWithReplicationToCluster()
        {
            this._logger.name += " -VerifyWithReplicationToCluster";
            // Create new graphql operation verifySlaWithReplicationToCluster
            InitQueryVerifySlaWithReplicationToCluster();
        }


        // Create new GraphQL Query:
        // slaAuditDetail(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     SlaId: UUID!
        //     filter: [SLAAuditDetailFilterInput!]
        //     timezone: String
        //   ): [SlaAuditDetail!]!
        internal void InitQuerySlaAuditDetail()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("SlaId", "UUID!"),
                Tuple.Create("filter", "[SLAAuditDetailFilterInput!]"),
                Tuple.Create("timezone", "String"),
            };
            Initialize(
                argDefs,
                "query",
                "QuerySlaAuditDetail",
                "($first: Int,$after: String,$last: Int,$before: String,$SlaId: UUID!,$filter: [SLAAuditDetailFilterInput!],$timezone: String)",
                "List<SlaAuditDetail>",
                Query.SlaAuditDetail_ObjectFieldSpec,
                Query.SlaAuditDetailFieldSpec,
                @"# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# OPTIONAL
$query.Var.last = $someInt
# OPTIONAL
$query.Var.before = $someString
# REQUIRED
$query.Var.SlaId = $someString
# OPTIONAL
$query.Var.filter = @(
	@{
		# OPTIONAL
		field = $someSLAAuditDetailFilterFieldEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SLAAuditDetailFilterFieldEnum]) for enum values.
		# OPTIONAL
		text = $someString
}
)
# OPTIONAL
$query.Var.timezone = $someString"
            );
        }

        // Create new GraphQL Query:
        // clusterSlaDomains(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //   ): ClusterSlaDomainConnection!
        internal void InitQueryClusterSlaDomains()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryClusterSlaDomains",
                "($first: Int,$after: String,$last: Int,$before: String)",
                "ClusterSlaDomainConnection",
                Query.ClusterSlaDomains_ObjectFieldSpec,
                Query.ClusterSlaDomainsFieldSpec,
                @"# OPTIONAL
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
        // allClusterGlobalSlas(cdmClusterUUID: UUID!): [SlaInfo!]!
        internal void InitQueryAllClusterGlobalSlas()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("cdmClusterUUID", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllClusterGlobalSlas",
                "($cdmClusterUUID: UUID!)",
                "List<SlaInfo>",
                Query.AllClusterGlobalSlas_ObjectFieldSpec,
                Query.AllClusterGlobalSlasFieldSpec,
                @"# REQUIRED
$query.Var.cdmClusterUUID = $someString"
            );
        }

        // Create new GraphQL Query:
        // slaConflictObjects(fids: [UUID!]!): [HierarchyObject!]!
        internal void InitQuerySlaConflictObjects()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fids", "[UUID!]!"),
            };
            Initialize(
                argDefs,
                "query",
                "QuerySlaConflictObjects",
                "($fids: [UUID!]!)",
                "List<HierarchyObject>",
                Query.SlaConflictObjects_ObjectFieldSpec,
                Query.SlaConflictObjectsFieldSpec,
                @"# REQUIRED
$query.Var.fids = @(
	$someString
)"
            );
        }

        // Create new GraphQL Query:
        // countOfObjectsProtectedBySlas(
        //     rootOptionalFid: UUID
        //     slaIds: [UUID!]!
        //     filter: [Filter!]
        //     typeFilter: [HierarchyObjectTypeEnum!]
        //   ): CountOfObjectsProtectedBySLAsResult!
        internal void InitQueryCountOfObjectsProtectedBySlas()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("rootOptionalFid", "UUID"),
                Tuple.Create("slaIds", "[UUID!]!"),
                Tuple.Create("filter", "[Filter!]"),
                Tuple.Create("typeFilter", "[HierarchyObjectTypeEnum!]"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryCountOfObjectsProtectedBySlas",
                "($rootOptionalFid: UUID,$slaIds: [UUID!]!,$filter: [Filter!],$typeFilter: [HierarchyObjectTypeEnum!])",
                "CountOfObjectsProtectedBySlAsResult",
                Query.CountOfObjectsProtectedBySlas_ObjectFieldSpec,
                Query.CountOfObjectsProtectedBySlasFieldSpec,
                @"# OPTIONAL
$query.Var.rootOptionalFid = $someString
# REQUIRED
$query.Var.slaIds = @(
	$someString
)
# OPTIONAL
$query.Var.filter = @(
	@{
		# OPTIONAL
		field = $someHierarchyFilterField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchyFilterField]) for enum values.
		# OPTIONAL
		texts = @(
			$someString
		)
		# OPTIONAL
		tagFilterParams = @(
			@{
				# OPTIONAL
				filterType = $someTagFilterType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TagFilterType]) for enum values.
				# OPTIONAL
				tagKey = $someString
				# OPTIONAL
				tagValue = $someString
			}
		)
		# OPTIONAL
		objectTypeFilterParams = @(
			$someManagedObjectType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ManagedObjectType]) for enum values.
		)
		# OPTIONAL
		awsNativeProtectionFeatureNames = @(
			$someAwsNativeProtectionFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		isNegative = $someBoolean
		# OPTIONAL
		isSlowSearchEnabled = $someBoolean
		# OPTIONAL
		azureNativeProtectionFeatureNames = @(
			$someAzureNativeProtectionFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		unmanagedObjectAvailabilityFilter = @(
			$someUnmanagedObjectAvailabilityFilter # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UnmanagedObjectAvailabilityFilter]) for enum values.
		)
}
)
# OPTIONAL
$query.Var.typeFilter = @(
	$someHierarchyObjectTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchyObjectTypeEnum]) for enum values.
)"
            );
        }

        // Create new GraphQL Query:
        // slaDomain(
        //     id: UUID!
        //     shouldShowSyncStatus: Boolean = false
        //     shouldShowUpgradeInfo: Boolean = false
        //     shouldShowPausedClusters: Boolean = false
        //   ): SlaDomain!
        internal void InitQuerySlaDomain()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("id", "UUID!"),
                Tuple.Create("shouldShowSyncStatus", "Boolean"),
                Tuple.Create("shouldShowUpgradeInfo", "Boolean"),
                Tuple.Create("shouldShowPausedClusters", "Boolean"),
            };
            Initialize(
                argDefs,
                "query",
                "QuerySlaDomain",
                "($id: UUID!,$shouldShowSyncStatus: Boolean,$shouldShowUpgradeInfo: Boolean,$shouldShowPausedClusters: Boolean)",
                "SlaDomain",
                Query.SlaDomain_ObjectFieldSpec,
                Query.SlaDomainFieldSpec,
                @"# REQUIRED
$query.Var.id = $someString
# OPTIONAL
$query.Var.shouldShowSyncStatus = $someBoolean
# OPTIONAL
$query.Var.shouldShowUpgradeInfo = $someBoolean
# OPTIONAL
$query.Var.shouldShowPausedClusters = $someBoolean"
            );
        }

        // Create new GraphQL Query:
        // slaDomains(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     sortBy: SlaQuerySortByField
        //     sortOrder: SortOrder
        //     filter: [GlobalSlaFilterInput!]
        //     contextFilter: ContextFilterTypeEnum
        //     contextFilterInput: [ContextFilterInputField!]
        //     shouldShowSyncStatus: Boolean = false
        //     shouldShowProtectedObjectCount: Boolean = false
        //     shouldShowUpgradeInfo: Boolean = false
        //     showRemoteSlas: Boolean
        //     shouldShowPausedClusters: Boolean = false
        //   ): SlaDomainConnection!
        internal void InitQuerySlaDomains()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("sortBy", "SlaQuerySortByField"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("filter", "[GlobalSlaFilterInput!]"),
                Tuple.Create("contextFilter", "ContextFilterTypeEnum"),
                Tuple.Create("contextFilterInput", "[ContextFilterInputField!]"),
                Tuple.Create("shouldShowSyncStatus", "Boolean"),
                Tuple.Create("shouldShowProtectedObjectCount", "Boolean"),
                Tuple.Create("shouldShowUpgradeInfo", "Boolean"),
                Tuple.Create("showRemoteSlas", "Boolean"),
                Tuple.Create("shouldShowPausedClusters", "Boolean"),
            };
            Initialize(
                argDefs,
                "query",
                "QuerySlaDomains",
                "($first: Int,$after: String,$last: Int,$before: String,$sortBy: SlaQuerySortByField,$sortOrder: SortOrder,$filter: [GlobalSlaFilterInput!],$contextFilter: ContextFilterTypeEnum,$contextFilterInput: [ContextFilterInputField!],$shouldShowSyncStatus: Boolean,$shouldShowProtectedObjectCount: Boolean,$shouldShowUpgradeInfo: Boolean,$showRemoteSlas: Boolean,$shouldShowPausedClusters: Boolean)",
                "SlaDomainConnection",
                Query.SlaDomains_ObjectFieldSpec,
                Query.SlaDomainsFieldSpec,
                @"# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# OPTIONAL
$query.Var.last = $someInt
# OPTIONAL
$query.Var.before = $someString
# OPTIONAL
$query.Var.sortBy = $someSlaQuerySortByField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SlaQuerySortByField]) for enum values.
# OPTIONAL
$query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$query.Var.filter = @(
	@{
		# OPTIONAL
		field = $someGlobalSlaQueryFilterInputField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.GlobalSlaQueryFilterInputField]) for enum values.
		# OPTIONAL
		text = $someString
		# OPTIONAL
		objectTypeList = @(
			$someSlaObjectType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SlaObjectType]) for enum values.
		)
		# OPTIONAL
		textList = @(
			$someString
		)
}
)
# OPTIONAL
$query.Var.contextFilter = $someContextFilterTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ContextFilterTypeEnum]) for enum values.
# OPTIONAL
$query.Var.contextFilterInput = @(
	@{
		# REQUIRED
		field = $someString
		# REQUIRED
		text = $someString
}
)
# OPTIONAL
$query.Var.shouldShowSyncStatus = $someBoolean
# OPTIONAL
$query.Var.shouldShowProtectedObjectCount = $someBoolean
# OPTIONAL
$query.Var.shouldShowUpgradeInfo = $someBoolean
# OPTIONAL
$query.Var.showRemoteSlas = $someBoolean
# OPTIONAL
$query.Var.shouldShowPausedClusters = $someBoolean"
            );
        }

        // Create new GraphQL Query:
        // globalSlaFilterConnection(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     sortBy: SlaQuerySortByField
        //     sortOrder: SortOrder
        //     filter: [GlobalSlaFilterInput!]
        //     contextFilter: ContextFilterTypeEnum
        //     contextFilterInput: [ContextFilterInputField!]
        //     shouldShowSyncStatus: Boolean = false
        //     shouldShowProtectedObjectCount: Boolean = false
        //     shouldShowUpgradeInfo: Boolean = false
        //     showRemoteSlas: Boolean
        //     shouldShowPausedClusters: Boolean = false
        //   ): GlobalSlaForFilterConnection!
        internal void InitQueryGlobalSlaFilterConnection()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("sortBy", "SlaQuerySortByField"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("filter", "[GlobalSlaFilterInput!]"),
                Tuple.Create("contextFilter", "ContextFilterTypeEnum"),
                Tuple.Create("contextFilterInput", "[ContextFilterInputField!]"),
                Tuple.Create("shouldShowSyncStatus", "Boolean"),
                Tuple.Create("shouldShowProtectedObjectCount", "Boolean"),
                Tuple.Create("shouldShowUpgradeInfo", "Boolean"),
                Tuple.Create("showRemoteSlas", "Boolean"),
                Tuple.Create("shouldShowPausedClusters", "Boolean"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryGlobalSlaFilterConnection",
                "($first: Int,$after: String,$last: Int,$before: String,$sortBy: SlaQuerySortByField,$sortOrder: SortOrder,$filter: [GlobalSlaFilterInput!],$contextFilter: ContextFilterTypeEnum,$contextFilterInput: [ContextFilterInputField!],$shouldShowSyncStatus: Boolean,$shouldShowProtectedObjectCount: Boolean,$shouldShowUpgradeInfo: Boolean,$showRemoteSlas: Boolean,$shouldShowPausedClusters: Boolean)",
                "GlobalSlaForFilterConnection",
                Query.GlobalSlaFilterConnection_ObjectFieldSpec,
                Query.GlobalSlaFilterConnectionFieldSpec,
                @"# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# OPTIONAL
$query.Var.last = $someInt
# OPTIONAL
$query.Var.before = $someString
# OPTIONAL
$query.Var.sortBy = $someSlaQuerySortByField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SlaQuerySortByField]) for enum values.
# OPTIONAL
$query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$query.Var.filter = @(
	@{
		# OPTIONAL
		field = $someGlobalSlaQueryFilterInputField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.GlobalSlaQueryFilterInputField]) for enum values.
		# OPTIONAL
		text = $someString
		# OPTIONAL
		objectTypeList = @(
			$someSlaObjectType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SlaObjectType]) for enum values.
		)
		# OPTIONAL
		textList = @(
			$someString
		)
}
)
# OPTIONAL
$query.Var.contextFilter = $someContextFilterTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ContextFilterTypeEnum]) for enum values.
# OPTIONAL
$query.Var.contextFilterInput = @(
	@{
		# REQUIRED
		field = $someString
		# REQUIRED
		text = $someString
}
)
# OPTIONAL
$query.Var.shouldShowSyncStatus = $someBoolean
# OPTIONAL
$query.Var.shouldShowProtectedObjectCount = $someBoolean
# OPTIONAL
$query.Var.shouldShowUpgradeInfo = $someBoolean
# OPTIONAL
$query.Var.showRemoteSlas = $someBoolean
# OPTIONAL
$query.Var.shouldShowPausedClusters = $someBoolean"
            );
        }

        // Create new GraphQL Query:
        // globalSlaStatuses(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     filter: [SlaStatusFilterInput!]
        //     SlaId: UUID!
        //   ): GlobalSlaStatusConnection!
        internal void InitQueryGlobalSlaStatuses()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("filter", "[SlaStatusFilterInput!]"),
                Tuple.Create("SlaId", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryGlobalSlaStatuses",
                "($first: Int,$after: String,$last: Int,$before: String,$filter: [SlaStatusFilterInput!],$SlaId: UUID!)",
                "GlobalSlaStatusConnection",
                Query.GlobalSlaStatuses_ObjectFieldSpec,
                Query.GlobalSlaStatusesFieldSpec,
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
		field = $someSlaStatusFilterField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SlaStatusFilterField]) for enum values.
		# OPTIONAL
		text = $someString
}
)
# REQUIRED
$query.Var.SlaId = $someString"
            );
        }

        // Create new GraphQL Query:
        // slaManagedVolume(fid: UUID!): ManagedVolume!
        internal void InitQuerySlaManagedVolume()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QuerySlaManagedVolume",
                "($fid: UUID!)",
                "ManagedVolume",
                Query.SlaManagedVolume_ObjectFieldSpec,
                Query.SlaManagedVolumeFieldSpec,
                @"# REQUIRED
$query.Var.fid = $someString"
            );
        }

        // Create new GraphQL Query:
        // slaManagedVolumes(
        //     first: Int
        //     after: String
        //     sortBy: HierarchySortByField
        //     sortOrder: SortOrder
        //     filter: [Filter!]
        //   ): ManagedVolumeConnection!
        internal void InitQuerySlaManagedVolumes()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("sortBy", "HierarchySortByField"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("filter", "[Filter!]"),
            };
            Initialize(
                argDefs,
                "query",
                "QuerySlaManagedVolumes",
                "($first: Int,$after: String,$sortBy: HierarchySortByField,$sortOrder: SortOrder,$filter: [Filter!])",
                "ManagedVolumeConnection",
                Query.SlaManagedVolumes_ObjectFieldSpec,
                Query.SlaManagedVolumesFieldSpec,
                @"# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# OPTIONAL
$query.Var.sortBy = $someHierarchySortByField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchySortByField]) for enum values.
# OPTIONAL
$query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$query.Var.filter = @(
	@{
		# OPTIONAL
		field = $someHierarchyFilterField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchyFilterField]) for enum values.
		# OPTIONAL
		texts = @(
			$someString
		)
		# OPTIONAL
		tagFilterParams = @(
			@{
				# OPTIONAL
				filterType = $someTagFilterType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TagFilterType]) for enum values.
				# OPTIONAL
				tagKey = $someString
				# OPTIONAL
				tagValue = $someString
			}
		)
		# OPTIONAL
		objectTypeFilterParams = @(
			$someManagedObjectType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ManagedObjectType]) for enum values.
		)
		# OPTIONAL
		awsNativeProtectionFeatureNames = @(
			$someAwsNativeProtectionFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		isNegative = $someBoolean
		# OPTIONAL
		isSlowSearchEnabled = $someBoolean
		# OPTIONAL
		azureNativeProtectionFeatureNames = @(
			$someAzureNativeProtectionFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		unmanagedObjectAvailabilityFilter = @(
			$someUnmanagedObjectAvailabilityFilter # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UnmanagedObjectAvailabilityFilter]) for enum values.
		)
}
)"
            );
        }

        // Create new GraphQL Query:
        // allNcdSlaComplianceData(clusters: [UUID!]!): [NcdSlaComplianceData!]!
        internal void InitQueryAllNcdSlaComplianceData()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("clusters", "[UUID!]!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllNcdSlaComplianceData",
                "($clusters: [UUID!]!)",
                "List<NcdSlaComplianceData>",
                Query.AllNcdSlaComplianceData_ObjectFieldSpec,
                Query.AllNcdSlaComplianceDataFieldSpec,
                @"# REQUIRED
$query.Var.clusters = @(
	$someString
)"
            );
        }

        // Create new GraphQL Query:
        // allSlaSummariesByIds(slaIds: [UUID!]!): [SlaDomain!]!
        internal void InitQueryAllSlaSummariesByIds()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("slaIds", "[UUID!]!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllSlaSummariesByIds",
                "($slaIds: [UUID!]!)",
                "List<SlaDomain>",
                Query.AllSlaSummariesByIds_ObjectFieldSpec,
                Query.AllSlaSummariesByIdsFieldSpec,
                @"# REQUIRED
$query.Var.slaIds = @(
	$someString
)"
            );
        }

        // Create new GraphQL Query:
        // verifySlaWithReplicationToCluster(cdmClusterUUID: UUID!, includeArchived: Boolean!): VerifySlaWithReplicationToClusterResponse!
        internal void InitQueryVerifySlaWithReplicationToCluster()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("cdmClusterUUID", "UUID!"),
                Tuple.Create("includeArchived", "Boolean!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryVerifySlaWithReplicationToCluster",
                "($cdmClusterUUID: UUID!,$includeArchived: Boolean!)",
                "VerifySlaWithReplicationToClusterResponse",
                Query.VerifySlaWithReplicationToCluster_ObjectFieldSpec,
                Query.VerifySlaWithReplicationToClusterFieldSpec,
                @"# REQUIRED
$query.Var.cdmClusterUUID = $someString
# REQUIRED
$query.Var.includeArchived = $someBoolean"
            );
        }


    } // class New_RscQuerySla
}