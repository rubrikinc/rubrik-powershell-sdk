// New-RscQueryCloudAccount.cs
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
    /// operations in the 'Cloud Account' API domain:
    /// CloudAccount, CurrentFeaturePermissions, ExocomputeMappings, or LatestFeaturePermissions.
    /// </summary>
    /// <description>
    /// New-RscQueryCloudAccount creates a new
    /// query object for operations
    /// in the 'Cloud Account' API domain. It only creates a data structure,
    /// it does not execute the operation. This cmdlet does not need a
    /// connection to run. To execute the operation, either call Invoke()
    /// on the object returned by this cmdlet, or pass the object to
    /// Invoke-Rsc.
    /// There are 4 operations
    /// in the 'Cloud Account' API domain. Select the operation this
    /// query is for by specifying the appropriate value for the
    /// -Operation parameter;
    /// one of: CloudAccount, CurrentFeaturePermissions, ExocomputeMappings, or LatestFeaturePermissions.
    /// Each operation has its own set of variables that can be set with
    /// the -Var parameter. For more info about the variables, 
    /// call Info() on the object returned by this cmdlet, for example:
    /// (New-RscQueryCloudAccount -CloudAccount).Info().
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
    /// (New-RscQueryCloudAccount -CloudAccount).Info().
    /// You can combine a -Field parameter with patching parameters.
    /// -Field is applied first, then -FilePatch, -AddField and -RemoveField.
    ///
    /// </description>
    ///
    /// <example>
    /// Runs the CloudAccount operation
    /// of the 'Cloud Account' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    CloudAccount
    /// # API Operation: CloudAccount
    /// 
    /// $query = New-RscQueryCloudAccount -CloudAccount
    /// 
    /// # REQUIRED
    /// $query.Var.cloudAccountId = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: CloudAccount
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CurrentFeaturePermissions operation
    /// of the 'Cloud Account' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    CloudAccount
    /// # API Operation: CurrentFeaturePermissions
    /// 
    /// $query = New-RscQueryCloudAccount -CurrentFeaturePermissions
    /// 
    /// # REQUIRED
    /// $query.Var.cloudVendor = $someCloudVendor # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudVendor]) for enum values.
    /// # REQUIRED
    /// $query.Var.cloudAccountIds = @(
    /// 	$someString
    /// )
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: List&lt;CloudAccountFeaturePermission&gt;
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the ExocomputeMappings operation
    /// of the 'Cloud Account' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    CloudAccount
    /// # API Operation: ExocomputeMappings
    /// 
    /// $query = New-RscQueryCloudAccount -ExocomputeMappings
    /// 
    /// # REQUIRED
    /// $query.Var.cloudVendor = $someCloudVendor # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudVendor]) for enum values.
    /// # REQUIRED
    /// $query.Var.exocomputeAccountIdsFilter = @(
    /// 	$someString
    /// )
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: List&lt;CloudAccountsExocomputeAccountMapping&gt;
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the LatestFeaturePermissions operation
    /// of the 'Cloud Account' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    CloudAccount
    /// # API Operation: LatestFeaturePermissions
    /// 
    /// $query = New-RscQueryCloudAccount -LatestFeaturePermissions
    /// 
    /// # REQUIRED
    /// $query.Var.cloudVendor = $someCloudVendor # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudVendor]) for enum values.
    /// # REQUIRED
    /// $query.Var.cloudAccountIds = @(
    /// 	$someString
    /// )
    /// # REQUIRED
    /// $query.Var.features = @(
    /// 	$someCloudAccountFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
    /// )
    /// # REQUIRED
    /// $query.Var.featuresWithPermissionsGroups = @(
    /// 	@{
    /// 		# OPTIONAL
    /// 		featureType = $someCloudAccountFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
    /// 		# OPTIONAL
    /// 		permissionsGroups = @(
    /// 			$somePermissionsGroup # Call [Enum]::GetValues([RubrikSecurityCloud.Types.PermissionsGroup]) for enum values.
    /// 		)
    /// }
    /// )
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: List&lt;CloudAccountFeaturePermission&gt;
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
        "RscQueryCloudAccount",
        DefaultParameterSetName = "Operation")
    ]
    public class New_RscQueryCloudAccount : RscGqlPSCmdlet
    {
        [Parameter(
            Mandatory = true, 
            ParameterSetName = "Operation",
            HelpMessage = "API Operation. The set of operations depends on the API domain. See reference at: https://github.com/rubrikinc/rubrik-powershell-sdk/blob/main/docs/domains_and_operations.md",
            Position = 0,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = true)]
            [ValidateSet(
                "CloudAccount",
                "CurrentFeaturePermissions",
                "ExocomputeMappings",
                "LatestFeaturePermissions",
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
                    case "CloudAccount":
                        this.ProcessRecord_CloudAccount();
                        break;
                    case "CurrentFeaturePermissions":
                        this.ProcessRecord_CurrentFeaturePermissions();
                        break;
                    case "ExocomputeMappings":
                        this.ProcessRecord_ExocomputeMappings();
                        break;
                    case "LatestFeaturePermissions":
                        this.ProcessRecord_LatestFeaturePermissions();
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
        // cloudAccount.
        internal void ProcessRecord_CloudAccount()
        {
            this._logger.name += " -CloudAccount";
            // Create new graphql operation cloudAccount
            InitQueryCloudAccount();
        }

        // This parameter set invokes a single graphql operation:
        // allCurrentFeaturePermissionsForCloudAccounts.
        internal void ProcessRecord_CurrentFeaturePermissions()
        {
            this._logger.name += " -CurrentFeaturePermissions";
            // Create new graphql operation allCurrentFeaturePermissionsForCloudAccounts
            InitQueryAllCurrentFeaturePermissionsForCloudAccounts();
        }

        // This parameter set invokes a single graphql operation:
        // allCloudAccountExocomputeMappings.
        internal void ProcessRecord_ExocomputeMappings()
        {
            this._logger.name += " -ExocomputeMappings";
            // Create new graphql operation allCloudAccountExocomputeMappings
            InitQueryAllCloudAccountExocomputeMappings();
        }

        // This parameter set invokes a single graphql operation:
        // allLatestFeaturePermissionsForCloudAccounts.
        internal void ProcessRecord_LatestFeaturePermissions()
        {
            this._logger.name += " -LatestFeaturePermissions";
            // Create new graphql operation allLatestFeaturePermissionsForCloudAccounts
            InitQueryAllLatestFeaturePermissionsForCloudAccounts();
        }


        // Create new GraphQL Query:
        // cloudAccount(cloudAccountId: UUID!): CloudAccount!
        internal void InitQueryCloudAccount()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("cloudAccountId", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryCloudAccount",
                "($cloudAccountId: UUID!)",
                "CloudAccount",
                Query.CloudAccount_ObjectFieldSpec,
                Query.CloudAccountFieldSpec,
                @"# REQUIRED
$query.Var.cloudAccountId = $someString"
            );
        }

        // Create new GraphQL Query:
        // allCurrentFeaturePermissionsForCloudAccounts(cloudVendor: CloudVendor!, cloudAccountIds: [UUID!]!): [CloudAccountFeaturePermission!]!
        internal void InitQueryAllCurrentFeaturePermissionsForCloudAccounts()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("cloudVendor", "CloudVendor!"),
                Tuple.Create("cloudAccountIds", "[UUID!]!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllCurrentFeaturePermissionsForCloudAccounts",
                "($cloudVendor: CloudVendor!,$cloudAccountIds: [UUID!]!)",
                "List<CloudAccountFeaturePermission>",
                Query.AllCurrentFeaturePermissionsForCloudAccounts_ObjectFieldSpec,
                Query.AllCurrentFeaturePermissionsForCloudAccountsFieldSpec,
                @"# REQUIRED
$query.Var.cloudVendor = $someCloudVendor # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudVendor]) for enum values.
# REQUIRED
$query.Var.cloudAccountIds = @(
	$someString
)"
            );
        }

        // Create new GraphQL Query:
        // allCloudAccountExocomputeMappings(cloudVendor: CloudVendor!, exocomputeAccountIdsFilter: [UUID!]! = []): [CloudAccountsExocomputeAccountMapping!]!
        internal void InitQueryAllCloudAccountExocomputeMappings()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("cloudVendor", "CloudVendor!"),
                Tuple.Create("exocomputeAccountIdsFilter", "[UUID!]!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllCloudAccountExocomputeMappings",
                "($cloudVendor: CloudVendor!,$exocomputeAccountIdsFilter: [UUID!]!)",
                "List<CloudAccountsExocomputeAccountMapping>",
                Query.AllCloudAccountExocomputeMappings_ObjectFieldSpec,
                Query.AllCloudAccountExocomputeMappingsFieldSpec,
                @"# REQUIRED
$query.Var.cloudVendor = $someCloudVendor # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudVendor]) for enum values.
# REQUIRED
$query.Var.exocomputeAccountIdsFilter = @(
	$someString
)"
            );
        }

        // Create new GraphQL Query:
        // allLatestFeaturePermissionsForCloudAccounts(
        //     cloudVendor: CloudVendor!
        //     cloudAccountIds: [UUID!]!
        //     features: [CloudAccountFeature!]!
        //     featuresWithPermissionsGroups: [FeatureWithPermissionsGroups!]! = []
        //   ): [CloudAccountFeaturePermission!]!
        internal void InitQueryAllLatestFeaturePermissionsForCloudAccounts()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("cloudVendor", "CloudVendor!"),
                Tuple.Create("cloudAccountIds", "[UUID!]!"),
                Tuple.Create("features", "[CloudAccountFeature!]!"),
                Tuple.Create("featuresWithPermissionsGroups", "[FeatureWithPermissionsGroups!]!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllLatestFeaturePermissionsForCloudAccounts",
                "($cloudVendor: CloudVendor!,$cloudAccountIds: [UUID!]!,$features: [CloudAccountFeature!]!,$featuresWithPermissionsGroups: [FeatureWithPermissionsGroups!]!)",
                "List<CloudAccountFeaturePermission>",
                Query.AllLatestFeaturePermissionsForCloudAccounts_ObjectFieldSpec,
                Query.AllLatestFeaturePermissionsForCloudAccountsFieldSpec,
                @"# REQUIRED
$query.Var.cloudVendor = $someCloudVendor # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudVendor]) for enum values.
# REQUIRED
$query.Var.cloudAccountIds = @(
	$someString
)
# REQUIRED
$query.Var.features = @(
	$someCloudAccountFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
)
# REQUIRED
$query.Var.featuresWithPermissionsGroups = @(
	@{
		# OPTIONAL
		featureType = $someCloudAccountFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
		# OPTIONAL
		permissionsGroups = @(
			$somePermissionsGroup # Call [Enum]::GetValues([RubrikSecurityCloud.Types.PermissionsGroup]) for enum values.
		)
}
)"
            );
        }


    } // class New_RscQueryCloudAccount
}