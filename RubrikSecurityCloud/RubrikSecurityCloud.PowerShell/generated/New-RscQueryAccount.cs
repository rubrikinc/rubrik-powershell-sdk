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

namespace RubrikSecurityCloud.PowerShell.Cmdlets
{
    /// <summary>
    /// Queries for the 'Account' API domain.
    /// </summary>
    /// <description>
    /// New-RscQueryAccount is the cmdlet to work with operations in the {self.noun} API domain. It is a dynamic cmdlet that accepts any {self.noun} API operation as its first parameter:  {sc_names}.
    /// </description>
    /// <example>
    /// <code>New-RscQueryAccount -Settings [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryAccount -SWithExocomputeMappings [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryAccount -Products [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryAccount -Id [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryAccount -Owners [-Arg ..] [-Field ..]</code>
    /// </example>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscQueryAccount",
        DefaultParameterSetName = "Id")
    ]
    public class New_RscQueryAccount : RscGqlPSCmdlet
    {
        
        /// <summary>
        /// Settings parameter set
        ///
        /// [GraphQL: accountSettings]
        /// </summary>
        [Parameter(
            ParameterSetName = "Settings",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"This endpoint is deprecated.
[GraphQL: accountSettings]",
            Position = 0
        )]
        public SwitchParameter Settings { get; set; }

        
        /// <summary>
        /// SWithExocomputeMappings parameter set
        ///
        /// [GraphQL: allAccountsWithExocomputeMappings]
        /// </summary>
        [Parameter(
            ParameterSetName = "SWithExocomputeMappings",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Retrieves the list of all accounts with their Exocompute account mapping, if exists.
[GraphQL: allAccountsWithExocomputeMappings]",
            Position = 0
        )]
        public SwitchParameter SWithExocomputeMappings { get; set; }

        
        /// <summary>
        /// Products parameter set
        ///
        /// [GraphQL: allAccountProducts]
        /// </summary>
        [Parameter(
            ParameterSetName = "Products",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"
[GraphQL: allAccountProducts]",
            Position = 0
        )]
        public SwitchParameter Products { get; set; }

        
        /// <summary>
        /// Id parameter set
        ///
        /// [GraphQL: accountId]
        /// </summary>
        [Parameter(
            ParameterSetName = "Id",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Account ID.
[GraphQL: accountId]",
            Position = 0
        )]
        public SwitchParameter Id { get; set; }

        
        /// <summary>
        /// Owners parameter set
        ///
        /// [GraphQL: allAccountOwners]
        /// </summary>
        [Parameter(
            ParameterSetName = "Owners",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"List of account owners.
[GraphQL: allAccountOwners]",
            Position = 0
        )]
        public SwitchParameter Owners { get; set; }


// ignore warning 'Missing XML comment'
#pragma warning disable 1591
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                switch(Op)
                {
                    case "Settings":
                        this.ProcessRecord_Settings();
                        break;
                    case "SWithExocomputeMappings":
                        this.ProcessRecord_SWithExocomputeMappings();
                        break;
                    case "Products":
                        this.ProcessRecord_Products();
                        break;
                    case "Id":
                        this.ProcessRecord_Id();
                        break;
                    case "Owners":
                        this.ProcessRecord_Owners();
                        break;
                    default:
                        throw new Exception("Unknown Operation " + Op);
                }
           }
           catch (Exception ex)
           {
                ThrowTerminatingException(ex);
           }
        }
#pragma warning restore 1591

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
        internal void ProcessRecord_SWithExocomputeMappings()
        {
            this._logger.name += " -SWithExocomputeMappings";
            // Create new graphql operation allAccountsWithExocomputeMappings
            InitQueryAllAccountsWithExocomputeMappings();
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
$inputs.Var.cloudVendor = <CloudVendor> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudVendor]) for enum values.
# REQUIRED
$inputs.Var.features = @(
	<CloudAccountFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
)
# REQUIRED
$inputs.Var.exocomputeAccountIdsFilter = @(
	<System.String>
)"
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
$inputs.Var.nameFilter = @(
	<ProductName> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ProductName]) for enum values.
)
# REQUIRED
$inputs.Var.typeFilter = @(
	<ProductType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ProductType]) for enum values.
)
# REQUIRED
$inputs.Var.stateFilter = @(
	<ProductState> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ProductState]) for enum values.
)
# OPTIONAL
$inputs.Var.startDateArg = <DateTime>
# OPTIONAL
$inputs.Var.endDateArg = <DateTime>"
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


    } // class New_RscQueryAccount
}