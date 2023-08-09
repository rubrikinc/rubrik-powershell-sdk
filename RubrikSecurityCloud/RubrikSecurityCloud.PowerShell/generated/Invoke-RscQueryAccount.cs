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
    [Cmdlet(
        "Invoke",
        "RscQueryAccount",
        DefaultParameterSetName = "Id")
    ]
    public class Invoke_RscQueryAccount : RscPSCmdlet
    {
        
        // -------------------------------------------------------------------
        // Settings parameter set
        //
        // [GraphQL: accountSettings]
        //
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

        
        // -------------------------------------------------------------------
        // SWithExocomputeMappings parameter set
        //
        // [GraphQL: allAccountsWithExocomputeMappings]
        //
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

        
        // -------------------------------------------------------------------
        // Products parameter set
        //
        // [GraphQL: allAccountProducts]
        //
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

        
        // -------------------------------------------------------------------
        // Id parameter set
        //
        // [GraphQL: accountId]
        //
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

        
        // -------------------------------------------------------------------
        // Owners parameter set
        //
        // [GraphQL: allAccountOwners]
        //
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

        // This parameter set invokes a single graphql operation:
        // accountSettings.
        protected void ProcessRecord_Settings()
        {
            this._logger.name += " -Settings";
            // Invoke graphql operation accountSettings
            InvokeQueryAccountSettings();
        }

        // This parameter set invokes a single graphql operation:
        // allAccountsWithExocomputeMappings.
        protected void ProcessRecord_SWithExocomputeMappings()
        {
            this._logger.name += " -SWithExocomputeMappings";
            // Invoke graphql operation allAccountsWithExocomputeMappings
            InvokeQueryAllAccountsWithExocomputeMappings();
        }

        // This parameter set invokes a single graphql operation:
        // allAccountProducts.
        protected void ProcessRecord_Products()
        {
            this._logger.name += " -Products";
            // Invoke graphql operation allAccountProducts
            InvokeQueryAllAccountProducts();
        }

        // This parameter set invokes a single graphql operation:
        // accountId.
        protected void ProcessRecord_Id()
        {
            this._logger.name += " -Id";
            // Invoke graphql operation accountId
            InvokeQueryAccountId();
        }

        // This parameter set invokes a single graphql operation:
        // allAccountOwners.
        protected void ProcessRecord_Owners()
        {
            this._logger.name += " -Owners";
            // Invoke graphql operation allAccountOwners
            InvokeQueryAllAccountOwners();
        }


        // Invoke GraphQL Query:
        // accountSettings: AccountSetting!
        protected void InvokeQueryAccountSettings()
        {
            Tuple<string, string>[] argDefs = {
            };
            AccountSetting? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (AccountSetting)psObject.BaseObject;
                } else {
                    fieldSpecObj = (AccountSetting)this.Field;
                }
            }
            string fieldSpecDoc = Query.AccountSettings(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryAccountSettings",
                "",
                fieldSpecDoc,
                "AccountSetting"
            );
        }

        // Invoke GraphQL Query:
        // allAccountsWithExocomputeMappings(cloudVendor: CloudVendor!, features: [CloudAccountFeature!]! = [], exocomputeAccountIdsFilter: [UUID!]! = []): [CloudAccountWithExocomputeMapping!]!
        protected void InvokeQueryAllAccountsWithExocomputeMappings()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("cloudVendor", "CloudVendor!"),
                Tuple.Create("features", "[CloudAccountFeature!]!"),
                Tuple.Create("exocomputeAccountIdsFilter", "[UUID!]!"),
            };
            List<CloudAccountWithExocomputeMapping>? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (List<CloudAccountWithExocomputeMapping>)psObject.BaseObject;
                } else {
                    fieldSpecObj = (List<CloudAccountWithExocomputeMapping>)this.Field;
                }
            }
            string fieldSpecDoc = Query.AllAccountsWithExocomputeMappings(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryAllAccountsWithExocomputeMappings",
                "($cloudVendor: CloudVendor!,$features: [CloudAccountFeature!]!,$exocomputeAccountIdsFilter: [UUID!]!)",
                fieldSpecDoc,
                "List<CloudAccountWithExocomputeMapping>"
            );
        }

        // Invoke GraphQL Query:
        // allAccountProducts(
        //     nameFilter: [ProductName!]!
        //     typeFilter: [ProductType!]!
        //     stateFilter: [ProductState!]!
        //     startDateArg: DateTime
        //     endDateArg: DateTime
        //   ): [AccountProduct!]!
        protected void InvokeQueryAllAccountProducts()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("nameFilter", "[ProductName!]!"),
                Tuple.Create("typeFilter", "[ProductType!]!"),
                Tuple.Create("stateFilter", "[ProductState!]!"),
                Tuple.Create("startDateArg", "DateTime"),
                Tuple.Create("endDateArg", "DateTime"),
            };
            List<AccountProduct>? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (List<AccountProduct>)psObject.BaseObject;
                } else {
                    fieldSpecObj = (List<AccountProduct>)this.Field;
                }
            }
            string fieldSpecDoc = Query.AllAccountProducts(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryAllAccountProducts",
                "($nameFilter: [ProductName!]!,$typeFilter: [ProductType!]!,$stateFilter: [ProductState!]!,$startDateArg: DateTime,$endDateArg: DateTime)",
                fieldSpecDoc,
                "List<AccountProduct>"
            );
        }

        // Invoke GraphQL Query:
        // accountId: String!
        protected void InvokeQueryAccountId()
        {
            Tuple<string, string>[] argDefs = {
            };
            System.String? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (System.String)psObject.BaseObject;
                } else {
                    fieldSpecObj = (System.String)this.Field;
                }
            }
            string fieldSpecDoc = Query.AccountId(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryAccountId",
                "",
                fieldSpecDoc,
                "System.String"
            );
        }

        // Invoke GraphQL Query:
        // allAccountOwners: [User!]!
        protected void InvokeQueryAllAccountOwners()
        {
            Tuple<string, string>[] argDefs = {
            };
            List<User>? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (List<User>)psObject.BaseObject;
                } else {
                    fieldSpecObj = (List<User>)this.Field;
                }
            }
            string fieldSpecDoc = Query.AllAccountOwners(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryAllAccountOwners",
                "",
                fieldSpecDoc,
                "List<User>"
            );
        }


    } // class Invoke_RscQueryAccount
}