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
    /// Create a new RscQuery object for any of the 9
    /// operations in the 'Account' API domain:
    /// CurrentUser, CurrentUserLoginContext, EnabledFeatures, Id, Lookup, Owners, Products, Settings, or Users.
    /// </summary>
    /// <description>
    /// New-RscQueryAccount creates a new
    /// query object for operations
    /// in the 'Account' API domain. It only creates a data structure,
    /// it does not execute the operation. This cmdlet does not need a
    /// connection to run. To execute the operation, either call Invoke()
    /// on the object returned by this cmdlet, or pass the object to
    /// Invoke-Rsc.
    /// There are 9 operations
    /// in the 'Account' API domain. Select the operation this
    /// query is for by specifying the appropriate value for the
    /// -Operation parameter;
    /// one of: CurrentUser, CurrentUserLoginContext, EnabledFeatures, Id, Lookup, Owners, Products, Settings, or Users.
    /// Each operation has its own set of variables that can be set with
    /// the -Var parameter. For more info about the variables, 
    /// call Info() on the object returned by this cmdlet, for example:
    /// (New-RscQueryAccount -CurrentUser).Info().
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
    /// (New-RscQueryAccount -CurrentUser).Info().
    /// You can combine a -Field parameter with patching parameters.
    /// -Field is applied first, then -FilePatch, -AddField and -RemoveField.
    ///
    /// </description>
    ///
    /// <example>
    /// Runs the CurrentUser operation
    /// of the 'Account' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Account
    /// # API Operation: CurrentUser
    /// 
    /// $query = New-RscQueryAccount -CurrentUser
    /// 
    /// # No variables for this query.
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: User
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CurrentUserLoginContext operation
    /// of the 'Account' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Account
    /// # API Operation: CurrentUserLoginContext
    /// 
    /// $query = New-RscQueryAccount -CurrentUserLoginContext
    /// 
    /// # No variables for this query.
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: UserLoginContext
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the EnabledFeatures operation
    /// of the 'Account' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Account
    /// # API Operation: EnabledFeatures
    /// 
    /// $query = New-RscQueryAccount -EnabledFeatures
    /// 
    /// # No variables for this query.
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AllEnabledFeaturesForAccountReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
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
    /// Runs the Lookup operation
    /// of the 'Account' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Account
    /// # API Operation: Lookup
    /// 
    /// $query = New-RscQueryAccount -Lookup
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	includeExpiryDate = $someBoolean
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: LookupAccountReply
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
    /// Runs the Users operation
    /// of the 'Account' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Account
    /// # API Operation: Users
    /// 
    /// $query = New-RscQueryAccount -Users
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
    /// Write-Host $result.GetType().Name # prints: List&lt;User&gt;
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
        DefaultParameterSetName = "Operation")
    ]
    public class New_RscQueryAccount : RscGqlPSCmdlet
    {
        [Parameter(
            Mandatory = true, 
            ParameterSetName = "Operation",
            HelpMessage = "API Operation. The set of operations depends on the API domain. See reference at: https://github.com/rubrikinc/rubrik-powershell-sdk/blob/main/docs/domains_and_operations.md",
            Position = 0,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = true)]
            [ValidateSet(
                "CurrentUser",
                "CurrentUserLoginContext",
                "EnabledFeatures",
                "Id",
                "Lookup",
                "Owners",
                "Products",
                "Settings",
                "Users",
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
                    case "CurrentUser":
                        this.ProcessRecord_CurrentUser();
                        break;
                    case "CurrentUserLoginContext":
                        this.ProcessRecord_CurrentUserLoginContext();
                        break;
                    case "EnabledFeatures":
                        this.ProcessRecord_EnabledFeatures();
                        break;
                    case "Id":
                        this.ProcessRecord_Id();
                        break;
                    case "Lookup":
                        this.ProcessRecord_Lookup();
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
                    case "Users":
                        this.ProcessRecord_Users();
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
        // currentUser.
        internal void ProcessRecord_CurrentUser()
        {
            this._logger.name += " -CurrentUser";
            // Create new graphql operation currentUser
            InitQueryCurrentUser();
        }

        // This parameter set invokes a single graphql operation:
        // currentUserLoginContext.
        internal void ProcessRecord_CurrentUserLoginContext()
        {
            this._logger.name += " -CurrentUserLoginContext";
            // Create new graphql operation currentUserLoginContext
            InitQueryCurrentUserLoginContext();
        }

        // This parameter set invokes a single graphql operation:
        // allEnabledFeaturesForAccount.
        internal void ProcessRecord_EnabledFeatures()
        {
            this._logger.name += " -EnabledFeatures";
            // Create new graphql operation allEnabledFeaturesForAccount
            InitQueryAllEnabledFeaturesForAccount();
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
        // lookupAccount.
        internal void ProcessRecord_Lookup()
        {
            this._logger.name += " -Lookup";
            // Create new graphql operation lookupAccount
            InitQueryLookupAccount();
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
        // allUsersOnAccount.
        internal void ProcessRecord_Users()
        {
            this._logger.name += " -Users";
            // Create new graphql operation allUsersOnAccount
            InitQueryAllUsersOnAccount();
        }


        // Create new GraphQL Query:
        // currentUser: User!
        internal void InitQueryCurrentUser()
        {
            Tuple<string, string>[] argDefs = {
            };
            Initialize(
                argDefs,
                "query",
                "QueryCurrentUser",
                "",
                "User",
                Query.CurrentUser_ObjectFieldSpec,
                Query.CurrentUserFieldSpec,
                @""
            );
        }

        // Create new GraphQL Query:
        // currentUserLoginContext: UserLoginContext!
        internal void InitQueryCurrentUserLoginContext()
        {
            Tuple<string, string>[] argDefs = {
            };
            Initialize(
                argDefs,
                "query",
                "QueryCurrentUserLoginContext",
                "",
                "UserLoginContext",
                Query.CurrentUserLoginContext_ObjectFieldSpec,
                Query.CurrentUserLoginContextFieldSpec,
                @""
            );
        }

        // Create new GraphQL Query:
        // allEnabledFeaturesForAccount: AllEnabledFeaturesForAccountReply!
        internal void InitQueryAllEnabledFeaturesForAccount()
        {
            Tuple<string, string>[] argDefs = {
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllEnabledFeaturesForAccount",
                "",
                "AllEnabledFeaturesForAccountReply",
                Query.AllEnabledFeaturesForAccount_ObjectFieldSpec,
                Query.AllEnabledFeaturesForAccountFieldSpec,
                @""
            );
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
        // lookupAccount(input: LookupAccountInput!): LookupAccountReply!
        internal void InitQueryLookupAccount()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "LookupAccountInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryLookupAccount",
                "($input: LookupAccountInput!)",
                "LookupAccountReply",
                Query.LookupAccount_ObjectFieldSpec,
                Query.LookupAccountFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	includeExpiryDate = $someBoolean
}"
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
        // allUsersOnAccount(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //   ): [User!]!
        internal void InitQueryAllUsersOnAccount()
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
                "QueryAllUsersOnAccount",
                "($first: Int,$after: String,$last: Int,$before: String)",
                "List<User>",
                Query.AllUsersOnAccount_ObjectFieldSpec,
                Query.AllUsersOnAccountFieldSpec,
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


    } // class New_RscQueryAccount
}