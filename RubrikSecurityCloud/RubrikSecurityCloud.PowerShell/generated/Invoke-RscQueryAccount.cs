// Invoke-RscQueryAccount.cs
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
    /// Account queries
    /// </summary>
    /// <description>
    /// Invoke-RscQueryAccount is a master cmdlet for Account work that can invoke any of the following subcommands: Settings, SWithExocomputeMappings, Products, Id, Owners.
    /// </description>
    /// <example>
    /// <code>Invoke-RscQueryAccount -Settings [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscQueryAccount -SWithExocomputeMappings [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscQueryAccount -Products [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscQueryAccount -Id [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscQueryAccount -Owners [-Arg ..] [-Field ..]</code>
    /// </example>
    [Cmdlet(
        "Invoke",
        "RscQueryAccount",
        DefaultParameterSetName = "Id")
    ]
    public class Invoke_RscQueryAccount : RscPSCmdlet
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
            // Invoke graphql operation accountSettings
            InvokeQueryAccountSettings();
        }

        // This parameter set invokes a single graphql operation:
        // allAccountsWithExocomputeMappings.
        internal void ProcessRecord_SWithExocomputeMappings()
        {
            this._logger.name += " -SWithExocomputeMappings";
            // Invoke graphql operation allAccountsWithExocomputeMappings
            InvokeQueryAllAccountsWithExocomputeMappings();
        }

        // This parameter set invokes a single graphql operation:
        // allAccountProducts.
        internal void ProcessRecord_Products()
        {
            this._logger.name += " -Products";
            // Invoke graphql operation allAccountProducts
            InvokeQueryAllAccountProducts();
        }

        // This parameter set invokes a single graphql operation:
        // accountId.
        internal void ProcessRecord_Id()
        {
            this._logger.name += " -Id";
            // Invoke graphql operation accountId
            InvokeQueryAccountId();
        }

        // This parameter set invokes a single graphql operation:
        // allAccountOwners.
        internal void ProcessRecord_Owners()
        {
            this._logger.name += " -Owners";
            // Invoke graphql operation allAccountOwners
            InvokeQueryAllAccountOwners();
        }


        // Invoke GraphQL Query:
        // accountSettings: AccountSetting!
        internal void InvokeQueryAccountSettings()
        {
            Tuple<string, string>[] argDefs = {
            };
            Initialize(
                argDefs,
                "query",
                "QueryAccountSettings",
                "",
                "AccountSetting"
                );
            AccountSetting? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (AccountSetting)this.Field;
            }
            string fieldSpecDoc = Query.AccountSettings(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Query:
        // allAccountsWithExocomputeMappings(cloudVendor: CloudVendor!, features: [CloudAccountFeature!]! = [], exocomputeAccountIdsFilter: [UUID!]! = []): [CloudAccountWithExocomputeMapping!]!
        internal void InvokeQueryAllAccountsWithExocomputeMappings()
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
                "List<CloudAccountWithExocomputeMapping>"
                );
            List<CloudAccountWithExocomputeMapping>? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (List<CloudAccountWithExocomputeMapping>)this.Field;
            }
            string fieldSpecDoc = Query.AllAccountsWithExocomputeMappings(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Query:
        // allAccountProducts(
        //     nameFilter: [ProductName!]!
        //     typeFilter: [ProductType!]!
        //     stateFilter: [ProductState!]!
        //     startDateArg: DateTime
        //     endDateArg: DateTime
        //   ): [AccountProduct!]!
        internal void InvokeQueryAllAccountProducts()
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
                "List<AccountProduct>"
                );
            List<AccountProduct>? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (List<AccountProduct>)this.Field;
            }
            string fieldSpecDoc = Query.AllAccountProducts(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Query:
        // accountId: String!
        internal void InvokeQueryAccountId()
        {
            Tuple<string, string>[] argDefs = {
            };
            Initialize(
                argDefs,
                "query",
                "QueryAccountId",
                "",
                "System.String"
                );
            System.String? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (System.String)this.Field;
            }
            string fieldSpecDoc = Query.AccountId(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Query:
        // allAccountOwners: [User!]!
        internal void InvokeQueryAllAccountOwners()
        {
            Tuple<string, string>[] argDefs = {
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllAccountOwners",
                "",
                "List<User>"
                );
            List<User>? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (List<User>)this.Field;
            }
            string fieldSpecDoc = Query.AllAccountOwners(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
        }


    } // class Invoke_RscQueryAccount
}