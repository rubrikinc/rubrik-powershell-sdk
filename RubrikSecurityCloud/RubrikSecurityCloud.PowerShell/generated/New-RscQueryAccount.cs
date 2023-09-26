// New-RscQueryAccount.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections;
using System.Collections.Generic;
using System.Management.Automation;
using System.Text;
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
    /// Create a new RscQuery object for any of the 5
    /// operations in the 'Account' API domain:
    /// Id, Owners, Products, Settings, or WithExocomputeMappings.
    /// </summary>
    /// <description>
    /// New-RscQueryAccount creates a new
    /// query object for operations
    /// in the 'Account' API domain. It only creates a data structure,
    /// it does not execute the operation. This cmdlet does not need a
    /// connection to run. To execute the operation, either call Invoke()
    /// on the object returned by this cmdlet, or pass the object to
    /// Invoke-Rsc.
    /// There are 5 operations
    /// in the 'Account' API domain. Select the operation this
    /// query is for by specifying the appropriate switch parameter;
    /// one of: -Id, -Owners, -Products, -Settings, -WithExocomputeMappings.
    /// Alternatively, you can specify the operation by setting the
    /// -Op parameter, for example: -Op Id,
    /// which is equivalent to specifying -Id.
    /// Each operation has its own set of variables that can be set with
    /// the -Var parameter. For more info about the variables, 
    /// call Info() on the object returned by this cmdlet, for example:
    /// (New-RscQueryAccount -Id).Info().
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
    /// (New-RscQueryAccount -Id).Info().
    /// You can combine a -Field parameter with patching parameters.
    /// -Field is applied first, then -FilePatch, -AddField and -RemoveField.
    ///
    /// </description>
    ///
    /// <example>
    /// Runs the Id operation
    /// of the 'Account' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Account
    /// # API Operation: Id
    /// 
    /// $query = New-RscQueryAccount -Id
    /// 
    /// # No variables for this query.
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: System.String
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the Owners operation
    /// of the 'Account' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Account
    /// # API Operation: Owners
    /// 
    /// $query = New-RscQueryAccount -Owners
    /// 
    /// # No variables for this query.
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: List&lt;User&gt;
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the Products operation
    /// of the 'Account' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Account
    /// # API Operation: Products
    /// 
    /// $query = New-RscQueryAccount -Products
    /// 
    /// # REQUIRED
    /// $query.Var.nameFilter = @(
    /// 	$someProductName # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ProductName]) for enum values.
    /// )
    /// # REQUIRED
    /// $query.Var.typeFilter = @(
    /// 	$someProductType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ProductType]) for enum values.
    /// )
    /// # REQUIRED
    /// $query.Var.stateFilter = @(
    /// 	$someProductState # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ProductState]) for enum values.
    /// )
    /// # OPTIONAL
    /// $query.Var.startDateArg = $someDateTime
    /// # OPTIONAL
    /// $query.Var.endDateArg = $someDateTime
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: List&lt;AccountProduct&gt;
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the Settings operation
    /// of the 'Account' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Account
    /// # API Operation: Settings
    /// 
    /// $query = New-RscQueryAccount -Settings
    /// 
    /// # No variables for this query.
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AccountSetting
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the WithExocomputeMappings operation
    /// of the 'Account' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Account
    /// # API Operation: WithExocomputeMappings
    /// 
    /// $query = New-RscQueryAccount -WithExocomputeMappings
    /// 
    /// # REQUIRED
    /// $query.Var.cloudVendor = $someCloudVendor # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudVendor]) for enum values.
    /// # REQUIRED
    /// $query.Var.features = @(
    /// 	$someCloudAccountFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
    /// )
    /// # REQUIRED
    /// $query.Var.exocomputeAccountIdsFilter = @(
    /// 	$someString
    /// )
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: List&lt;CloudAccountWithExocomputeMapping&gt;
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
        "RscQueryAccount",
        DefaultParameterSetName = "Id")
    ]
    public class New_RscQueryAccount : RscGqlPSCmdlet
    {
        
        [Parameter(
            ParameterSetName = "Id",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a query object for the 'Id' operation
in the 'Account' API domain.
Description of the operation:
Account ID.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/accountid.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter Id { get; set; }

        
        [Parameter(
            ParameterSetName = "Owners",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a query object for the 'Owners' operation
in the 'Account' API domain.
Description of the operation:
List of account owners.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/allaccountowners.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter Owners { get; set; }

        
        [Parameter(
            ParameterSetName = "Products",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a query object for the 'Products' operation
in the 'Account' API domain.
Description of the operation:

[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/allaccountproducts.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter Products { get; set; }

        
        [Parameter(
            ParameterSetName = "Settings",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a query object for the 'Settings' operation
in the 'Account' API domain.
Description of the operation:
This endpoint is deprecated.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/accountsettings.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter Settings { get; set; }

        
        [Parameter(
            ParameterSetName = "WithExocomputeMappings",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a query object for the 'WithExocomputeMappings' operation
in the 'Account' API domain.
Description of the operation:
Retrieves the list of all accounts with their Exocompute account mapping, if exists.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/allaccountswithexocomputemappings.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter WithExocomputeMappings { get; set; }



        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                switch(this.GetOp().OpName())
                {
                    case "Id":
                        this.ProcessRecord_Id();
                        break;
                    case "Owners":
                        this.ProcessRecord_Owners();
                        break;
                    case "Products":
                        this.ProcessRecord_Products();
                        break;
                    case "Settings":
                        this.ProcessRecord_Settings();
                        break;
                    case "WithExocomputeMappings":
                        this.ProcessRecord_WithExocomputeMappings();
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
        // accountId.
        internal void ProcessRecord_Id()
        {
            this._logger.name += " -Id";
            // Create new graphql operation accountId
            InitQueryAccountId();
        }

        // This parameter set invokes a single graphql operation:
        // allAccountOwners.
        internal void ProcessRecord_Owners()
        {
            this._logger.name += " -Owners";
            // Create new graphql operation allAccountOwners
            InitQueryAllAccountOwners();
        }

        // This parameter set invokes a single graphql operation:
        // allAccountProducts.
        internal void ProcessRecord_Products()
        {
            this._logger.name += " -Products";
            // Create new graphql operation allAccountProducts
            InitQueryAllAccountProducts();
        }

        // This parameter set invokes a single graphql operation:
        // accountSettings.
        internal void ProcessRecord_Settings()
        {
            this._logger.name += " -Settings";
            // Create new graphql operation accountSettings
            InitQueryAccountSettings();
        }

        // This parameter set invokes a single graphql operation:
        // allAccountsWithExocomputeMappings.
        internal void ProcessRecord_WithExocomputeMappings()
        {
            this._logger.name += " -WithExocomputeMappings";
            // Create new graphql operation allAccountsWithExocomputeMappings
            InitQueryAllAccountsWithExocomputeMappings();
        }


        // Create new GraphQL Query:
        // accountId: String!
        internal void InitQueryAccountId()
        {
            Tuple<string, string>[] argDefs = {
            };
            Initialize(
                argDefs,
                "query",
                "QueryAccountId",
                "",
                "System.String",
                Query.AccountId_ObjectFieldSpec,
                Query.AccountIdFieldSpec,
                @""
            );
        }

        // Create new GraphQL Query:
        // allAccountOwners: [User!]!
        internal void InitQueryAllAccountOwners()
        {
            Tuple<string, string>[] argDefs = {
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllAccountOwners",
                "",
                "List<User>",
                Query.AllAccountOwners_ObjectFieldSpec,
                Query.AllAccountOwnersFieldSpec,
                @""
            );
        }

        // Create new GraphQL Query:
        // allAccountProducts(
        //     nameFilter: [ProductName!]!
        //     typeFilter: [ProductType!]!
        //     stateFilter: [ProductState!]!
        //     startDateArg: DateTime
        //     endDateArg: DateTime
        //   ): [AccountProduct!]!
        internal void InitQueryAllAccountProducts()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("nameFilter", "[ProductName!]!"),
                Tuple.Create("typeFilter", "[ProductType!]!"),
                Tuple.Create("stateFilter", "[ProductState!]!"),
                Tuple.Create("startDateArg", "DateTime"),
                Tuple.Create("endDateArg", "DateTime"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllAccountProducts",
                "($nameFilter: [ProductName!]!,$typeFilter: [ProductType!]!,$stateFilter: [ProductState!]!,$startDateArg: DateTime,$endDateArg: DateTime)",
                "List<AccountProduct>",
                Query.AllAccountProducts_ObjectFieldSpec,
                Query.AllAccountProductsFieldSpec,
                @"# REQUIRED
$query.Var.nameFilter = @(
	$someProductName # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ProductName]) for enum values.
)
# REQUIRED
$query.Var.typeFilter = @(
	$someProductType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ProductType]) for enum values.
)
# REQUIRED
$query.Var.stateFilter = @(
	$someProductState # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ProductState]) for enum values.
)
# OPTIONAL
$query.Var.startDateArg = $someDateTime
# OPTIONAL
$query.Var.endDateArg = $someDateTime"
            );
        }

        // Create new GraphQL Query:
        // accountSettings: AccountSetting!
        internal void InitQueryAccountSettings()
        {
            Tuple<string, string>[] argDefs = {
            };
            Initialize(
                argDefs,
                "query",
                "QueryAccountSettings",
                "",
                "AccountSetting",
                Query.AccountSettings_ObjectFieldSpec,
                Query.AccountSettingsFieldSpec,
                @""
            );
        }

        // Create new GraphQL Query:
        // allAccountsWithExocomputeMappings(cloudVendor: CloudVendor!, features: [CloudAccountFeature!]! = [], exocomputeAccountIdsFilter: [UUID!]! = []): [CloudAccountWithExocomputeMapping!]!
        internal void InitQueryAllAccountsWithExocomputeMappings()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("cloudVendor", "CloudVendor!"),
                Tuple.Create("features", "[CloudAccountFeature!]!"),
                Tuple.Create("exocomputeAccountIdsFilter", "[UUID!]!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllAccountsWithExocomputeMappings",
                "($cloudVendor: CloudVendor!,$features: [CloudAccountFeature!]!,$exocomputeAccountIdsFilter: [UUID!]!)",
                "List<CloudAccountWithExocomputeMapping>",
                Query.AllAccountsWithExocomputeMappings_ObjectFieldSpec,
                Query.AllAccountsWithExocomputeMappingsFieldSpec,
                @"# REQUIRED
$query.Var.cloudVendor = $someCloudVendor # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudVendor]) for enum values.
# REQUIRED
$query.Var.features = @(
	$someCloudAccountFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
)
# REQUIRED
$query.Var.exocomputeAccountIdsFilter = @(
	$someString
)"
            );
        }


    } // class New_RscQueryAccount
}