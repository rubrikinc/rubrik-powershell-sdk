// New-RscQueryCloudNative.cs
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
    /// operations in the 'Cloud Native' API domain:
    /// CheckArchivedSnapshotsLocked, CheckLabelRuleNameUniqueness, CheckRequiredPermissionsForFeature, CheckTagRuleNameUniqueness, CustomerTags, FileRecoveryEligibleSnapshots, IsFileRecoveryFeasible, LabelKeys, LabelRules, LabelValues, RbaInstallers, SnapshotDetailsForRecovery, SnapshotTypeDetails, Snapshots, SqlServerSetupScript, TagKeys, TagRules, TagValues, or WorkloadVersionedFiles.
    /// </summary>
    /// <description>
    /// New-RscQueryCloudNative creates a new
    /// query object for operations
    /// in the 'Cloud Native' API domain. It only creates a data structure,
    /// it does not execute the operation. This cmdlet does not need a
    /// connection to run. To execute the operation, either call Invoke()
    /// on the object returned by this cmdlet, or pass the object to
    /// Invoke-Rsc.
    /// There are 19 operations
    /// in the 'Cloud Native' API domain. Select the operation this
    /// query is for by specifying the appropriate value for the
    /// -Operation parameter;
    /// one of: CheckArchivedSnapshotsLocked, CheckLabelRuleNameUniqueness, CheckRequiredPermissionsForFeature, CheckTagRuleNameUniqueness, CustomerTags, FileRecoveryEligibleSnapshots, IsFileRecoveryFeasible, LabelKeys, LabelRules, LabelValues, RbaInstallers, SnapshotDetailsForRecovery, SnapshotTypeDetails, Snapshots, SqlServerSetupScript, TagKeys, TagRules, TagValues, or WorkloadVersionedFiles.
    /// Each operation has its own set of variables that can be set with
    /// the -Var parameter. For more info about the variables, 
    /// call Info() on the object returned by this cmdlet, for example:
    /// (New-RscQueryCloudNative -CheckArchivedSnapshotsLocked).Info().
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
    /// (New-RscQueryCloudNative -CheckArchivedSnapshotsLocked).Info().
    /// You can combine a -Field parameter with patching parameters.
    /// -Field is applied first, then -FilePatch, -AddField and -RemoveField.
    ///
    /// </description>
    ///
    /// <example>
    /// Runs the CheckArchivedSnapshotsLocked operation
    /// of the 'Cloud Native' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    CloudNative
    /// # API Operation: CheckArchivedSnapshotsLocked
    /// 
    /// $query = New-RscQueryCloudNative -Operation CheckArchivedSnapshotsLocked
    /// 
    /// # REQUIRED
    /// $query.Var.workloadId = $someString
    /// # OPTIONAL
    /// $query.Var.snapshotIds = @(
    /// 	$someString
    /// )
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: CheckArchivedSnapshotsLockedReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CheckLabelRuleNameUniqueness operation
    /// of the 'Cloud Native' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    CloudNative
    /// # API Operation: CheckLabelRuleNameUniqueness
    /// 
    /// $query = New-RscQueryCloudNative -Operation CheckLabelRuleNameUniqueness
    /// 
    /// # REQUIRED
    /// $query.Var.ruleName = $someString
    /// # REQUIRED
    /// $query.Var.objectType = $someCloudNativeLabelObjectType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudNativeLabelObjectType]) for enum values.
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: IsCloudNativeTagRuleNameUniqueReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CheckRequiredPermissionsForFeature operation
    /// of the 'Cloud Native' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    CloudNative
    /// # API Operation: CheckRequiredPermissionsForFeature
    /// 
    /// $query = New-RscQueryCloudNative -Operation CheckRequiredPermissionsForFeature
    /// 
    /// # REQUIRED
    /// $query.Var.cloudNativeAccountId = $someString
    /// # REQUIRED
    /// $query.Var.featurePermissionCheck = @{
    /// 	# OPTIONAL
    /// 	azureFeature = $someAzureFeatureForPermissionCheck # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureFeatureForPermissionCheck]) for enum values.
    /// 	# OPTIONAL
    /// 	awsFeature = $someAwsFeatureForPermissionCheck # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsFeatureForPermissionCheck]) for enum values.
    /// }
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
    /// Runs the CheckTagRuleNameUniqueness operation
    /// of the 'Cloud Native' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    CloudNative
    /// # API Operation: CheckTagRuleNameUniqueness
    /// 
    /// $query = New-RscQueryCloudNative -Operation CheckTagRuleNameUniqueness
    /// 
    /// # REQUIRED
    /// $query.Var.ruleName = $someString
    /// # REQUIRED
    /// $query.Var.objectType = $someCloudNativeTagObjectType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudNativeTagObjectType]) for enum values.
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: IsCloudNativeTagRuleNameUniqueReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CustomerTags operation
    /// of the 'Cloud Native' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    CloudNative
    /// # API Operation: CustomerTags
    /// 
    /// $query = New-RscQueryCloudNative -Operation CustomerTags
    /// 
    /// # REQUIRED
    /// $query.Var.cloudVendor = $someCloudVendor # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudVendor]) for enum values.
    /// # OPTIONAL
    /// $query.Var.cloudAccountId = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: CloudNativeCustomerTagsReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the FileRecoveryEligibleSnapshots operation
    /// of the 'Cloud Native' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    CloudNative
    /// # API Operation: FileRecoveryEligibleSnapshots
    /// 
    /// $query = New-RscQueryCloudNative -Operation FileRecoveryEligibleSnapshots
    /// 
    /// # REQUIRED
    /// $query.Var.workloadId = $someString
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
    /// Runs the IsFileRecoveryFeasible operation
    /// of the 'Cloud Native' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    CloudNative
    /// # API Operation: IsFileRecoveryFeasible
    /// 
    /// $query = New-RscQueryCloudNative -Operation IsFileRecoveryFeasible
    /// 
    /// # REQUIRED
    /// $query.Var.snapshotIds = @(
    /// 	$someString
    /// )
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: ValidateCloudNativeFileRecoveryFeasibilityReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the LabelKeys operation
    /// of the 'Cloud Native' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    CloudNative
    /// # API Operation: LabelKeys
    /// 
    /// $query = New-RscQueryCloudNative -Operation LabelKeys
    /// 
    /// # REQUIRED
    /// $query.Var.keySubStr = $someString
    /// # REQUIRED
    /// $query.Var.limit = $someInt
    /// # REQUIRED
    /// $query.Var.objectType = $someCloudNativeLabelObjectType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudNativeLabelObjectType]) for enum values.
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
    /// Runs the LabelRules operation
    /// of the 'Cloud Native' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    CloudNative
    /// # API Operation: LabelRules
    /// 
    /// $query = New-RscQueryCloudNative -Operation LabelRules
    /// 
    /// # REQUIRED
    /// $query.Var.objectType = $someCloudNativeLabelObjectType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudNativeLabelObjectType]) for enum values.
    /// # OPTIONAL
    /// $query.Var.filters = @(
    /// 	@{
    /// 		# OPTIONAL
    /// 		field = $someCloudNativeTagRuleFilterFields # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudNativeTagRuleFilterFields]) for enum values.
    /// 		# OPTIONAL
    /// 		texts = @(
    /// 			$someString
    /// 		)
    /// }
    /// )
    /// # OPTIONAL
    /// $query.Var.sortBy = $someCloudNativeTagRuleSortByFields # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudNativeTagRuleSortByFields]) for enum values.
    /// # OPTIONAL
    /// $query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: GetCloudNativeLabelRulesReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the LabelValues operation
    /// of the 'Cloud Native' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    CloudNative
    /// # API Operation: LabelValues
    /// 
    /// $query = New-RscQueryCloudNative -Operation LabelValues
    /// 
    /// # REQUIRED
    /// $query.Var.valueSubStr = $someString
    /// # REQUIRED
    /// $query.Var.key = $someString
    /// # REQUIRED
    /// $query.Var.limit = $someInt
    /// # REQUIRED
    /// $query.Var.objectType = $someCloudNativeLabelObjectType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudNativeLabelObjectType]) for enum values.
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
    /// Runs the RbaInstallers operation
    /// of the 'Cloud Native' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    CloudNative
    /// # API Operation: RbaInstallers
    /// 
    /// $query = New-RscQueryCloudNative -Operation RbaInstallers
    /// 
    /// # No variables for this query.
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: RbaInstallerUrls
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the SnapshotDetailsForRecovery operation
    /// of the 'Cloud Native' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    CloudNative
    /// # API Operation: SnapshotDetailsForRecovery
    /// 
    /// $query = New-RscQueryCloudNative -Operation SnapshotDetailsForRecovery
    /// 
    /// # REQUIRED
    /// $query.Var.snapshotId = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: CloudNativeSnapshotDetailsForRecoveryReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the SnapshotTypeDetails operation
    /// of the 'Cloud Native' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    CloudNative
    /// # API Operation: SnapshotTypeDetails
    /// 
    /// $query = New-RscQueryCloudNative -Operation SnapshotTypeDetails
    /// 
    /// # REQUIRED
    /// $query.Var.snapshotId = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: CloudNativeSnapshotTypeDetailsReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the Snapshots operation
    /// of the 'Cloud Native' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    CloudNative
    /// # API Operation: Snapshots
    /// 
    /// $query = New-RscQueryCloudNative -Operation Snapshots
    /// 
    /// # OPTIONAL
    /// $query.Var.first = $someInt
    /// # OPTIONAL
    /// $query.Var.after = $someString
    /// # REQUIRED
    /// $query.Var.path = $someString
    /// # REQUIRED
    /// $query.Var.snapshotFid = $someString
    /// # OPTIONAL
    /// $query.Var.searchPrefix = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: SnapshotFileConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the SqlServerSetupScript operation
    /// of the 'Cloud Native' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    CloudNative
    /// # API Operation: SqlServerSetupScript
    /// 
    /// $query = New-RscQueryCloudNative -Operation SqlServerSetupScript
    /// 
    /// # OPTIONAL
    /// $query.Var.cloudNativeObjectType = $someCloudNativeObjectType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudNativeObjectType]) for enum values.
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: CloudNativeSqlServerSetupScript
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the TagKeys operation
    /// of the 'Cloud Native' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    CloudNative
    /// # API Operation: TagKeys
    /// 
    /// $query = New-RscQueryCloudNative -Operation TagKeys
    /// 
    /// # REQUIRED
    /// $query.Var.keySubStr = $someString
    /// # REQUIRED
    /// $query.Var.limit = $someInt
    /// # REQUIRED
    /// $query.Var.objectType = $someCloudNativeTagObjectType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudNativeTagObjectType]) for enum values.
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
    /// Runs the TagRules operation
    /// of the 'Cloud Native' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    CloudNative
    /// # API Operation: TagRules
    /// 
    /// $query = New-RscQueryCloudNative -Operation TagRules
    /// 
    /// # REQUIRED
    /// $query.Var.objectType = $someCloudNativeTagObjectType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudNativeTagObjectType]) for enum values.
    /// # OPTIONAL
    /// $query.Var.filters = @(
    /// 	@{
    /// 		# OPTIONAL
    /// 		field = $someCloudNativeTagRuleFilterFields # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudNativeTagRuleFilterFields]) for enum values.
    /// 		# OPTIONAL
    /// 		texts = @(
    /// 			$someString
    /// 		)
    /// }
    /// )
    /// # OPTIONAL
    /// $query.Var.sortBy = $someCloudNativeTagRuleSortByFields # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudNativeTagRuleSortByFields]) for enum values.
    /// # OPTIONAL
    /// $query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: GetCloudNativeTagRulesReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the TagValues operation
    /// of the 'Cloud Native' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    CloudNative
    /// # API Operation: TagValues
    /// 
    /// $query = New-RscQueryCloudNative -Operation TagValues
    /// 
    /// # REQUIRED
    /// $query.Var.valueSubStr = $someString
    /// # REQUIRED
    /// $query.Var.key = $someString
    /// # REQUIRED
    /// $query.Var.limit = $someInt
    /// # REQUIRED
    /// $query.Var.objectType = $someCloudNativeTagObjectType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudNativeTagObjectType]) for enum values.
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
    /// Runs the WorkloadVersionedFiles operation
    /// of the 'Cloud Native' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    CloudNative
    /// # API Operation: WorkloadVersionedFiles
    /// 
    /// $query = New-RscQueryCloudNative -Operation WorkloadVersionedFiles
    /// 
    /// # OPTIONAL
    /// $query.Var.first = $someInt
    /// # OPTIONAL
    /// $query.Var.after = $someString
    /// # REQUIRED
    /// $query.Var.snappableId = $someString
    /// # REQUIRED
    /// $query.Var.searchQuery = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: CloudNativeVersionedFileConnection
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
        "RscQueryCloudNative",
        DefaultParameterSetName = "Operation")
    ]
    public class New_RscQueryCloudNative : RscGqlPSCmdlet
    {
        [Parameter(
            Mandatory = true, 
            ParameterSetName = "Operation",
            HelpMessage = "API Operation. The set of operations depends on the API domain. See reference at: https://github.com/rubrikinc/rubrik-powershell-sdk/blob/main/docs/domains_and_operations.md",
            Position = 0,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = true)]
            [ValidateSet(
                "CheckArchivedSnapshotsLocked",
                "CheckLabelRuleNameUniqueness",
                "CheckRequiredPermissionsForFeature",
                "CheckTagRuleNameUniqueness",
                "CustomerTags",
                "FileRecoveryEligibleSnapshots",
                "IsFileRecoveryFeasible",
                "LabelKeys",
                "LabelRules",
                "LabelValues",
                "RbaInstallers",
                "SnapshotDetailsForRecovery",
                "SnapshotTypeDetails",
                "Snapshots",
                "SqlServerSetupScript",
                "TagKeys",
                "TagRules",
                "TagValues",
                "WorkloadVersionedFiles",
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
                    case "CheckArchivedSnapshotsLocked":
                        this.ProcessRecord_CheckArchivedSnapshotsLocked();
                        break;
                    case "CheckLabelRuleNameUniqueness":
                        this.ProcessRecord_CheckLabelRuleNameUniqueness();
                        break;
                    case "CheckRequiredPermissionsForFeature":
                        this.ProcessRecord_CheckRequiredPermissionsForFeature();
                        break;
                    case "CheckTagRuleNameUniqueness":
                        this.ProcessRecord_CheckTagRuleNameUniqueness();
                        break;
                    case "CustomerTags":
                        this.ProcessRecord_CustomerTags();
                        break;
                    case "FileRecoveryEligibleSnapshots":
                        this.ProcessRecord_FileRecoveryEligibleSnapshots();
                        break;
                    case "IsFileRecoveryFeasible":
                        this.ProcessRecord_IsFileRecoveryFeasible();
                        break;
                    case "LabelKeys":
                        this.ProcessRecord_LabelKeys();
                        break;
                    case "LabelRules":
                        this.ProcessRecord_LabelRules();
                        break;
                    case "LabelValues":
                        this.ProcessRecord_LabelValues();
                        break;
                    case "RbaInstallers":
                        this.ProcessRecord_RbaInstallers();
                        break;
                    case "SnapshotDetailsForRecovery":
                        this.ProcessRecord_SnapshotDetailsForRecovery();
                        break;
                    case "SnapshotTypeDetails":
                        this.ProcessRecord_SnapshotTypeDetails();
                        break;
                    case "Snapshots":
                        this.ProcessRecord_Snapshots();
                        break;
                    case "SqlServerSetupScript":
                        this.ProcessRecord_SqlServerSetupScript();
                        break;
                    case "TagKeys":
                        this.ProcessRecord_TagKeys();
                        break;
                    case "TagRules":
                        this.ProcessRecord_TagRules();
                        break;
                    case "TagValues":
                        this.ProcessRecord_TagValues();
                        break;
                    case "WorkloadVersionedFiles":
                        this.ProcessRecord_WorkloadVersionedFiles();
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
        // cloudNativeCheckArchivedSnapshotsLocked.
        internal void ProcessRecord_CheckArchivedSnapshotsLocked()
        {
            this._logger.name += " -CheckArchivedSnapshotsLocked";
            // Create new graphql operation cloudNativeCheckArchivedSnapshotsLocked
            InitQueryCloudNativeCheckArchivedSnapshotsLocked();
        }

        // This parameter set invokes a single graphql operation:
        // checkCloudNativeLabelRuleNameUniqueness.
        internal void ProcessRecord_CheckLabelRuleNameUniqueness()
        {
            this._logger.name += " -CheckLabelRuleNameUniqueness";
            // Create new graphql operation checkCloudNativeLabelRuleNameUniqueness
            InitQueryCheckCloudNativeLabelRuleNameUniqueness();
        }

        // This parameter set invokes a single graphql operation:
        // cloudNativeCheckRequiredPermissionsForFeature.
        internal void ProcessRecord_CheckRequiredPermissionsForFeature()
        {
            this._logger.name += " -CheckRequiredPermissionsForFeature";
            // Create new graphql operation cloudNativeCheckRequiredPermissionsForFeature
            InitQueryCloudNativeCheckRequiredPermissionsForFeature();
        }

        // This parameter set invokes a single graphql operation:
        // checkCloudNativeTagRuleNameUniqueness.
        internal void ProcessRecord_CheckTagRuleNameUniqueness()
        {
            this._logger.name += " -CheckTagRuleNameUniqueness";
            // Create new graphql operation checkCloudNativeTagRuleNameUniqueness
            InitQueryCheckCloudNativeTagRuleNameUniqueness();
        }

        // This parameter set invokes a single graphql operation:
        // cloudNativeCustomerTags.
        internal void ProcessRecord_CustomerTags()
        {
            this._logger.name += " -CustomerTags";
            // Create new graphql operation cloudNativeCustomerTags
            InitQueryCloudNativeCustomerTags();
        }

        // This parameter set invokes a single graphql operation:
        // allCloudNativeFileRecoveryEligibleSnapshots.
        internal void ProcessRecord_FileRecoveryEligibleSnapshots()
        {
            this._logger.name += " -FileRecoveryEligibleSnapshots";
            // Create new graphql operation allCloudNativeFileRecoveryEligibleSnapshots
            InitQueryAllCloudNativeFileRecoveryEligibleSnapshots();
        }

        // This parameter set invokes a single graphql operation:
        // isCloudNativeFileRecoveryFeasible.
        internal void ProcessRecord_IsFileRecoveryFeasible()
        {
            this._logger.name += " -IsFileRecoveryFeasible";
            // Create new graphql operation isCloudNativeFileRecoveryFeasible
            InitQueryIsCloudNativeFileRecoveryFeasible();
        }

        // This parameter set invokes a single graphql operation:
        // allCloudNativeLabelKeys.
        internal void ProcessRecord_LabelKeys()
        {
            this._logger.name += " -LabelKeys";
            // Create new graphql operation allCloudNativeLabelKeys
            InitQueryAllCloudNativeLabelKeys();
        }

        // This parameter set invokes a single graphql operation:
        // cloudNativeLabelRules.
        internal void ProcessRecord_LabelRules()
        {
            this._logger.name += " -LabelRules";
            // Create new graphql operation cloudNativeLabelRules
            InitQueryCloudNativeLabelRules();
        }

        // This parameter set invokes a single graphql operation:
        // allCloudNativeLabelValues.
        internal void ProcessRecord_LabelValues()
        {
            this._logger.name += " -LabelValues";
            // Create new graphql operation allCloudNativeLabelValues
            InitQueryAllCloudNativeLabelValues();
        }

        // This parameter set invokes a single graphql operation:
        // cloudNativeRbaInstallers.
        internal void ProcessRecord_RbaInstallers()
        {
            this._logger.name += " -RbaInstallers";
            // Create new graphql operation cloudNativeRbaInstallers
            InitQueryCloudNativeRbaInstallers();
        }

        // This parameter set invokes a single graphql operation:
        // cloudNativeSnapshotDetailsForRecovery.
        internal void ProcessRecord_SnapshotDetailsForRecovery()
        {
            this._logger.name += " -SnapshotDetailsForRecovery";
            // Create new graphql operation cloudNativeSnapshotDetailsForRecovery
            InitQueryCloudNativeSnapshotDetailsForRecovery();
        }

        // This parameter set invokes a single graphql operation:
        // cloudNativeSnapshotTypeDetails.
        internal void ProcessRecord_SnapshotTypeDetails()
        {
            this._logger.name += " -SnapshotTypeDetails";
            // Create new graphql operation cloudNativeSnapshotTypeDetails
            InitQueryCloudNativeSnapshotTypeDetails();
        }

        // This parameter set invokes a single graphql operation:
        // cloudNativeSnapshots.
        internal void ProcessRecord_Snapshots()
        {
            this._logger.name += " -Snapshots";
            // Create new graphql operation cloudNativeSnapshots
            InitQueryCloudNativeSnapshots();
        }

        // This parameter set invokes a single graphql operation:
        // cloudNativeSqlServerSetupScript.
        internal void ProcessRecord_SqlServerSetupScript()
        {
            this._logger.name += " -SqlServerSetupScript";
            // Create new graphql operation cloudNativeSqlServerSetupScript
            InitQueryCloudNativeSqlServerSetupScript();
        }

        // This parameter set invokes a single graphql operation:
        // allCloudNativeTagKeys.
        internal void ProcessRecord_TagKeys()
        {
            this._logger.name += " -TagKeys";
            // Create new graphql operation allCloudNativeTagKeys
            InitQueryAllCloudNativeTagKeys();
        }

        // This parameter set invokes a single graphql operation:
        // cloudNativeTagRules.
        internal void ProcessRecord_TagRules()
        {
            this._logger.name += " -TagRules";
            // Create new graphql operation cloudNativeTagRules
            InitQueryCloudNativeTagRules();
        }

        // This parameter set invokes a single graphql operation:
        // allCloudNativeTagValues.
        internal void ProcessRecord_TagValues()
        {
            this._logger.name += " -TagValues";
            // Create new graphql operation allCloudNativeTagValues
            InitQueryAllCloudNativeTagValues();
        }

        // This parameter set invokes a single graphql operation:
        // cloudNativeWorkloadVersionedFiles.
        internal void ProcessRecord_WorkloadVersionedFiles()
        {
            this._logger.name += " -WorkloadVersionedFiles";
            // Create new graphql operation cloudNativeWorkloadVersionedFiles
            InitQueryCloudNativeWorkloadVersionedFiles();
        }


        // Create new GraphQL Query:
        // cloudNativeCheckArchivedSnapshotsLocked(workloadId: UUID!, snapshotIds: [UUID!]): CheckArchivedSnapshotsLockedReply!
        internal void InitQueryCloudNativeCheckArchivedSnapshotsLocked()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("workloadId", "UUID!"),
                Tuple.Create("snapshotIds", "[UUID!]"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryCloudNativeCheckArchivedSnapshotsLocked",
                "($workloadId: UUID!,$snapshotIds: [UUID!])",
                "CheckArchivedSnapshotsLockedReply",
                Query.CloudNativeCheckArchivedSnapshotsLocked,
                Query.CloudNativeCheckArchivedSnapshotsLockedFieldSpec,
                @"# REQUIRED
$query.Var.workloadId = $someString
# OPTIONAL
$query.Var.snapshotIds = @(
	$someString
)"
            );
        }

        // Create new GraphQL Query:
        // checkCloudNativeLabelRuleNameUniqueness(ruleName: String!, objectType: CloudNativeLabelObjectType!): IsCloudNativeTagRuleNameUniqueReply!
        internal void InitQueryCheckCloudNativeLabelRuleNameUniqueness()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("ruleName", "String!"),
                Tuple.Create("objectType", "CloudNativeLabelObjectType!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryCheckCloudNativeLabelRuleNameUniqueness",
                "($ruleName: String!,$objectType: CloudNativeLabelObjectType!)",
                "IsCloudNativeTagRuleNameUniqueReply",
                Query.CheckCloudNativeLabelRuleNameUniqueness,
                Query.CheckCloudNativeLabelRuleNameUniquenessFieldSpec,
                @"# REQUIRED
$query.Var.ruleName = $someString
# REQUIRED
$query.Var.objectType = $someCloudNativeLabelObjectType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudNativeLabelObjectType]) for enum values."
            );
        }

        // Create new GraphQL Query:
        // cloudNativeCheckRequiredPermissionsForFeature(cloudNativeAccountId: String!, featurePermissionCheck: CloudNativeFeatureForPermissionsCheck!): Boolean!
        internal void InitQueryCloudNativeCheckRequiredPermissionsForFeature()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("cloudNativeAccountId", "String!"),
                Tuple.Create("featurePermissionCheck", "CloudNativeFeatureForPermissionsCheck!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryCloudNativeCheckRequiredPermissionsForFeature",
                "($cloudNativeAccountId: String!,$featurePermissionCheck: CloudNativeFeatureForPermissionsCheck!)",
                "System.Boolean",
                Query.CloudNativeCheckRequiredPermissionsForFeature,
                Query.CloudNativeCheckRequiredPermissionsForFeatureFieldSpec,
                @"# REQUIRED
$query.Var.cloudNativeAccountId = $someString
# REQUIRED
$query.Var.featurePermissionCheck = @{
	# OPTIONAL
	azureFeature = $someAzureFeatureForPermissionCheck # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureFeatureForPermissionCheck]) for enum values.
	# OPTIONAL
	awsFeature = $someAwsFeatureForPermissionCheck # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsFeatureForPermissionCheck]) for enum values.
}"
            );
        }

        // Create new GraphQL Query:
        // checkCloudNativeTagRuleNameUniqueness(ruleName: String!, objectType: CloudNativeTagObjectType!): IsCloudNativeTagRuleNameUniqueReply!
        internal void InitQueryCheckCloudNativeTagRuleNameUniqueness()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("ruleName", "String!"),
                Tuple.Create("objectType", "CloudNativeTagObjectType!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryCheckCloudNativeTagRuleNameUniqueness",
                "($ruleName: String!,$objectType: CloudNativeTagObjectType!)",
                "IsCloudNativeTagRuleNameUniqueReply",
                Query.CheckCloudNativeTagRuleNameUniqueness,
                Query.CheckCloudNativeTagRuleNameUniquenessFieldSpec,
                @"# REQUIRED
$query.Var.ruleName = $someString
# REQUIRED
$query.Var.objectType = $someCloudNativeTagObjectType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudNativeTagObjectType]) for enum values."
            );
        }

        // Create new GraphQL Query:
        // cloudNativeCustomerTags(cloudVendor: CloudVendor!, cloudAccountId: UUID): CloudNativeCustomerTagsReply!
        internal void InitQueryCloudNativeCustomerTags()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("cloudVendor", "CloudVendor!"),
                Tuple.Create("cloudAccountId", "UUID"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryCloudNativeCustomerTags",
                "($cloudVendor: CloudVendor!,$cloudAccountId: UUID)",
                "CloudNativeCustomerTagsReply",
                Query.CloudNativeCustomerTags,
                Query.CloudNativeCustomerTagsFieldSpec,
                @"# REQUIRED
$query.Var.cloudVendor = $someCloudVendor # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudVendor]) for enum values.
# OPTIONAL
$query.Var.cloudAccountId = $someString"
            );
        }

        // Create new GraphQL Query:
        // allCloudNativeFileRecoveryEligibleSnapshots(workloadId: UUID!): [String!]!
        internal void InitQueryAllCloudNativeFileRecoveryEligibleSnapshots()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("workloadId", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllCloudNativeFileRecoveryEligibleSnapshots",
                "($workloadId: UUID!)",
                "List<System.String>",
                Query.AllCloudNativeFileRecoveryEligibleSnapshots,
                Query.AllCloudNativeFileRecoveryEligibleSnapshotsFieldSpec,
                @"# REQUIRED
$query.Var.workloadId = $someString"
            );
        }

        // Create new GraphQL Query:
        // isCloudNativeFileRecoveryFeasible(snapshotIds: [UUID!]!): ValidateCloudNativeFileRecoveryFeasibilityReply!
        internal void InitQueryIsCloudNativeFileRecoveryFeasible()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("snapshotIds", "[UUID!]!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryIsCloudNativeFileRecoveryFeasible",
                "($snapshotIds: [UUID!]!)",
                "ValidateCloudNativeFileRecoveryFeasibilityReply",
                Query.IsCloudNativeFileRecoveryFeasible,
                Query.IsCloudNativeFileRecoveryFeasibleFieldSpec,
                @"# REQUIRED
$query.Var.snapshotIds = @(
	$someString
)"
            );
        }

        // Create new GraphQL Query:
        // allCloudNativeLabelKeys(keySubStr: String!, limit: Int!, objectType: CloudNativeLabelObjectType!): [String!]!
        internal void InitQueryAllCloudNativeLabelKeys()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("keySubStr", "String!"),
                Tuple.Create("limit", "Int!"),
                Tuple.Create("objectType", "CloudNativeLabelObjectType!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllCloudNativeLabelKeys",
                "($keySubStr: String!,$limit: Int!,$objectType: CloudNativeLabelObjectType!)",
                "List<System.String>",
                Query.AllCloudNativeLabelKeys,
                Query.AllCloudNativeLabelKeysFieldSpec,
                @"# REQUIRED
$query.Var.keySubStr = $someString
# REQUIRED
$query.Var.limit = $someInt
# REQUIRED
$query.Var.objectType = $someCloudNativeLabelObjectType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudNativeLabelObjectType]) for enum values."
            );
        }

        // Create new GraphQL Query:
        // cloudNativeLabelRules(
        //     objectType: CloudNativeLabelObjectType!
        //     filters: [CloudNativeFilter!]
        //     sortBy: CloudNativeTagRuleSortByFields
        //     sortOrder: SortOrder
        //   ): GetCloudNativeLabelRulesReply!
        internal void InitQueryCloudNativeLabelRules()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("objectType", "CloudNativeLabelObjectType!"),
                Tuple.Create("filters", "[CloudNativeFilter!]"),
                Tuple.Create("sortBy", "CloudNativeTagRuleSortByFields"),
                Tuple.Create("sortOrder", "SortOrder"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryCloudNativeLabelRules",
                "($objectType: CloudNativeLabelObjectType!,$filters: [CloudNativeFilter!],$sortBy: CloudNativeTagRuleSortByFields,$sortOrder: SortOrder)",
                "GetCloudNativeLabelRulesReply",
                Query.CloudNativeLabelRules,
                Query.CloudNativeLabelRulesFieldSpec,
                @"# REQUIRED
$query.Var.objectType = $someCloudNativeLabelObjectType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudNativeLabelObjectType]) for enum values.
# OPTIONAL
$query.Var.filters = @(
	@{
		# OPTIONAL
		field = $someCloudNativeTagRuleFilterFields # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudNativeTagRuleFilterFields]) for enum values.
		# OPTIONAL
		texts = @(
			$someString
		)
}
)
# OPTIONAL
$query.Var.sortBy = $someCloudNativeTagRuleSortByFields # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudNativeTagRuleSortByFields]) for enum values.
# OPTIONAL
$query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values."
            );
        }

        // Create new GraphQL Query:
        // allCloudNativeLabelValues(
        //     valueSubStr: String!
        //     key: String!
        //     limit: Int!
        //     objectType: CloudNativeLabelObjectType!
        //   ): [String!]!
        internal void InitQueryAllCloudNativeLabelValues()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("valueSubStr", "String!"),
                Tuple.Create("key", "String!"),
                Tuple.Create("limit", "Int!"),
                Tuple.Create("objectType", "CloudNativeLabelObjectType!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllCloudNativeLabelValues",
                "($valueSubStr: String!,$key: String!,$limit: Int!,$objectType: CloudNativeLabelObjectType!)",
                "List<System.String>",
                Query.AllCloudNativeLabelValues,
                Query.AllCloudNativeLabelValuesFieldSpec,
                @"# REQUIRED
$query.Var.valueSubStr = $someString
# REQUIRED
$query.Var.key = $someString
# REQUIRED
$query.Var.limit = $someInt
# REQUIRED
$query.Var.objectType = $someCloudNativeLabelObjectType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudNativeLabelObjectType]) for enum values."
            );
        }

        // Create new GraphQL Query:
        // cloudNativeRbaInstallers: RbaInstallerUrls!
        internal void InitQueryCloudNativeRbaInstallers()
        {
            Tuple<string, string>[] argDefs = {
            };
            Initialize(
                argDefs,
                "query",
                "QueryCloudNativeRbaInstallers",
                "",
                "RbaInstallerUrls",
                Query.CloudNativeRbaInstallers,
                Query.CloudNativeRbaInstallersFieldSpec,
                @""
            );
        }

        // Create new GraphQL Query:
        // cloudNativeSnapshotDetailsForRecovery(snapshotId: UUID!): CloudNativeSnapshotDetailsForRecoveryReply!
        internal void InitQueryCloudNativeSnapshotDetailsForRecovery()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("snapshotId", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryCloudNativeSnapshotDetailsForRecovery",
                "($snapshotId: UUID!)",
                "CloudNativeSnapshotDetailsForRecoveryReply",
                Query.CloudNativeSnapshotDetailsForRecovery,
                Query.CloudNativeSnapshotDetailsForRecoveryFieldSpec,
                @"# REQUIRED
$query.Var.snapshotId = $someString"
            );
        }

        // Create new GraphQL Query:
        // cloudNativeSnapshotTypeDetails(snapshotId: UUID!): CloudNativeSnapshotTypeDetailsReply!
        internal void InitQueryCloudNativeSnapshotTypeDetails()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("snapshotId", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryCloudNativeSnapshotTypeDetails",
                "($snapshotId: UUID!)",
                "CloudNativeSnapshotTypeDetailsReply",
                Query.CloudNativeSnapshotTypeDetails,
                Query.CloudNativeSnapshotTypeDetailsFieldSpec,
                @"# REQUIRED
$query.Var.snapshotId = $someString"
            );
        }

        // Create new GraphQL Query:
        // cloudNativeSnapshots(
        //     first: Int
        //     after: String
        //     path: String!
        //     snapshotFid: UUID!
        //     searchPrefix: String
        //   ): SnapshotFileConnection!
        internal void InitQueryCloudNativeSnapshots()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("path", "String!"),
                Tuple.Create("snapshotFid", "UUID!"),
                Tuple.Create("searchPrefix", "String"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryCloudNativeSnapshots",
                "($first: Int,$after: String,$path: String!,$snapshotFid: UUID!,$searchPrefix: String)",
                "SnapshotFileConnection",
                Query.CloudNativeSnapshots,
                Query.CloudNativeSnapshotsFieldSpec,
                @"# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# REQUIRED
$query.Var.path = $someString
# REQUIRED
$query.Var.snapshotFid = $someString
# OPTIONAL
$query.Var.searchPrefix = $someString"
            );
        }

        // Create new GraphQL Query:
        // cloudNativeSqlServerSetupScript(cloudNativeObjectType: CloudNativeObjectType): CloudNativeSqlServerSetupScript!
        internal void InitQueryCloudNativeSqlServerSetupScript()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("cloudNativeObjectType", "CloudNativeObjectType"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryCloudNativeSqlServerSetupScript",
                "($cloudNativeObjectType: CloudNativeObjectType)",
                "CloudNativeSqlServerSetupScript",
                Query.CloudNativeSqlServerSetupScript,
                Query.CloudNativeSqlServerSetupScriptFieldSpec,
                @"# OPTIONAL
$query.Var.cloudNativeObjectType = $someCloudNativeObjectType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudNativeObjectType]) for enum values."
            );
        }

        // Create new GraphQL Query:
        // allCloudNativeTagKeys(keySubStr: String!, limit: Int!, objectType: CloudNativeTagObjectType!): [String!]!
        internal void InitQueryAllCloudNativeTagKeys()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("keySubStr", "String!"),
                Tuple.Create("limit", "Int!"),
                Tuple.Create("objectType", "CloudNativeTagObjectType!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllCloudNativeTagKeys",
                "($keySubStr: String!,$limit: Int!,$objectType: CloudNativeTagObjectType!)",
                "List<System.String>",
                Query.AllCloudNativeTagKeys,
                Query.AllCloudNativeTagKeysFieldSpec,
                @"# REQUIRED
$query.Var.keySubStr = $someString
# REQUIRED
$query.Var.limit = $someInt
# REQUIRED
$query.Var.objectType = $someCloudNativeTagObjectType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudNativeTagObjectType]) for enum values."
            );
        }

        // Create new GraphQL Query:
        // cloudNativeTagRules(
        //     objectType: CloudNativeTagObjectType!
        //     filters: [CloudNativeFilter!]
        //     sortBy: CloudNativeTagRuleSortByFields
        //     sortOrder: SortOrder
        //   ): GetCloudNativeTagRulesReply!
        internal void InitQueryCloudNativeTagRules()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("objectType", "CloudNativeTagObjectType!"),
                Tuple.Create("filters", "[CloudNativeFilter!]"),
                Tuple.Create("sortBy", "CloudNativeTagRuleSortByFields"),
                Tuple.Create("sortOrder", "SortOrder"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryCloudNativeTagRules",
                "($objectType: CloudNativeTagObjectType!,$filters: [CloudNativeFilter!],$sortBy: CloudNativeTagRuleSortByFields,$sortOrder: SortOrder)",
                "GetCloudNativeTagRulesReply",
                Query.CloudNativeTagRules,
                Query.CloudNativeTagRulesFieldSpec,
                @"# REQUIRED
$query.Var.objectType = $someCloudNativeTagObjectType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudNativeTagObjectType]) for enum values.
# OPTIONAL
$query.Var.filters = @(
	@{
		# OPTIONAL
		field = $someCloudNativeTagRuleFilterFields # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudNativeTagRuleFilterFields]) for enum values.
		# OPTIONAL
		texts = @(
			$someString
		)
}
)
# OPTIONAL
$query.Var.sortBy = $someCloudNativeTagRuleSortByFields # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudNativeTagRuleSortByFields]) for enum values.
# OPTIONAL
$query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values."
            );
        }

        // Create new GraphQL Query:
        // allCloudNativeTagValues(
        //     valueSubStr: String!
        //     key: String!
        //     limit: Int!
        //     objectType: CloudNativeTagObjectType!
        //   ): [String!]!
        internal void InitQueryAllCloudNativeTagValues()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("valueSubStr", "String!"),
                Tuple.Create("key", "String!"),
                Tuple.Create("limit", "Int!"),
                Tuple.Create("objectType", "CloudNativeTagObjectType!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllCloudNativeTagValues",
                "($valueSubStr: String!,$key: String!,$limit: Int!,$objectType: CloudNativeTagObjectType!)",
                "List<System.String>",
                Query.AllCloudNativeTagValues,
                Query.AllCloudNativeTagValuesFieldSpec,
                @"# REQUIRED
$query.Var.valueSubStr = $someString
# REQUIRED
$query.Var.key = $someString
# REQUIRED
$query.Var.limit = $someInt
# REQUIRED
$query.Var.objectType = $someCloudNativeTagObjectType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudNativeTagObjectType]) for enum values."
            );
        }

        // Create new GraphQL Query:
        // cloudNativeWorkloadVersionedFiles(
        //     first: Int
        //     after: String
        //     snappableId: UUID!
        //     searchQuery: String!
        //   ): CloudNativeVersionedFileConnection!
        internal void InitQueryCloudNativeWorkloadVersionedFiles()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("snappableId", "UUID!"),
                Tuple.Create("searchQuery", "String!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryCloudNativeWorkloadVersionedFiles",
                "($first: Int,$after: String,$snappableId: UUID!,$searchQuery: String!)",
                "CloudNativeVersionedFileConnection",
                Query.CloudNativeWorkloadVersionedFiles,
                Query.CloudNativeWorkloadVersionedFilesFieldSpec,
                @"# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# REQUIRED
$query.Var.snappableId = $someString
# REQUIRED
$query.Var.searchQuery = $someString"
            );
        }


    } // class New_RscQueryCloudNative
}