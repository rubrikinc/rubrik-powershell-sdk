// Invoke-RscQueryAccount.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using Rubrik.SecurityCloud.Types;
using Rubrik.SecurityCloud.NetSDK.Client;
using Rubrik.SecurityCloud.PowerShell.Private;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Management.Automation;
using System.Text;
using System.Threading.Tasks;
using RubrikSecurityCloud.Schema.Utils;
using GraphQL;

namespace Rubrik.SecurityCloud.PowerShell.Cmdlets
{
    [Cmdlet(
        "Invoke",
        "RscQueryAccount",
        DefaultParameterSetName = "Id")
    ]
    public class Invoke_RscQueryAccount : RscPSCmdlet
    {
        
        // -------------------------------------------------------------------
        // Setting parameter set
        //
        // [GraphQL: accountSettings]
        //
        [Parameter(
            ParameterSetName = "Setting",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"This endpoint is deprecated.
[GraphQL: accountSettings]",
            Position = 0
        )]
        public SwitchParameter Setting { get; set; }

        
        // -------------------------------------------------------------------
        // Swithexocomputemapping parameter set
        //
        // [GraphQL: allAccountsWithExocomputeMappings]
        //
        [Parameter(
            ParameterSetName = "Swithexocomputemapping",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Retrieves the list of all accounts with their Exocompute account mapping, if exists.
[GraphQL: allAccountsWithExocomputeMappings]",
            Position = 0
        )]
        public SwitchParameter Swithexocomputemapping { get; set; }

        [Parameter(
            ParameterSetName = "Swithexocomputemapping",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Vendor of the cloud account.
GraphQL argument cloudVendor: CloudVendor!"
        )]
        public CloudVendor? CloudVendor { get; set; }
        [Parameter(
            ParameterSetName = "Swithexocomputemapping",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Cloud account features. Rubrik offers a cloud account feature as part of Rubrik Security Cloud (RSC).
GraphQL argument features: [CloudAccountFeature!]!"
        )]
        public List<CloudAccountFeature>? Features { get; set; }
        [Parameter(
            ParameterSetName = "Swithexocomputemapping",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"List of mapped Exocompute account IDs.
GraphQL argument exocomputeAccountIdsFilter: [UUID!]!"
        )]
        public List<System.String>? ExocomputeAccountIdsFilter { get; set; }
        
        // -------------------------------------------------------------------
        // Product parameter set
        //
        // [GraphQL: allAccountProducts]
        //
        [Parameter(
            ParameterSetName = "Product",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"
[GraphQL: allAccountProducts]",
            Position = 0
        )]
        public SwitchParameter Product { get; set; }

        [Parameter(
            ParameterSetName = "Product",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Name of product (Data Protection, Ransomware Investigation, etc.).
GraphQL argument nameFilter: [ProductName!]!"
        )]
        public List<ProductName>? NameFilter { get; set; }
        [Parameter(
            ParameterSetName = "Product",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Type of product (Revenue, POC, etc.).
GraphQL argument typeFilter: [ProductType!]!"
        )]
        public List<ProductType>? TypeFilter { get; set; }
        [Parameter(
            ParameterSetName = "Product",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"State of product (Active, Expired, etc.).
GraphQL argument stateFilter: [ProductState!]!"
        )]
        public List<ProductState>? StateFilter { get; set; }
        [Parameter(
            ParameterSetName = "Product",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Start date of product (yyyy-mm-dd).
GraphQL argument startDateArg: DateTime"
        )]
        public DateTime? StartDateArg { get; set; }
        [Parameter(
            ParameterSetName = "Product",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"End date of product (yyyy-mm-dd).
GraphQL argument endDateArg: DateTime"
        )]
        public DateTime? EndDateArg { get; set; }
        
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
        // Owner parameter set
        //
        // [GraphQL: allAccountOwners]
        //
        [Parameter(
            ParameterSetName = "Owner",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"List of account owners.
[GraphQL: allAccountOwners]",
            Position = 0
        )]
        public SwitchParameter Owner { get; set; }


        protected override void ProcessRecord()
        {
            try
            {
                switch(Op)
                {
                    case "Setting":
                        this.ProcessRecord_Setting();
                        break;
                    case "Swithexocomputemapping":
                        this.ProcessRecord_Swithexocomputemapping();
                        break;
                    case "Product":
                        this.ProcessRecord_Product();
                        break;
                    case "Id":
                        this.ProcessRecord_Id();
                        break;
                    case "Owner":
                        this.ProcessRecord_Owner();
                        break;
                    default:
                        throw new Exception("Unknown Operation " + Op);
                }
           }
           catch (Exception ex)
           {
                this._logger.Flush();
                var error = new ErrorRecord(
                    ex,
                    "Invoke-RscQueryAccount",
                    ErrorCategory.InvalidOperation,
                    null);
                ThrowTerminatingError(error);
           }
        }

        // This parameter set invokes a single graphql operation:
        // accountSettings.
        protected void ProcessRecord_Setting()
        {
            this._logger.name += " -Setting";
            // Invoke graphql operation accountSettings
            InvokeQueryAccountSettings();
        }

        // This parameter set invokes a single graphql operation:
        // allAccountsWithExocomputeMappings.
        protected void ProcessRecord_Swithexocomputemapping()
        {
            this._logger.name += " -Swithexocomputemapping";
            // Invoke graphql operation allAccountsWithExocomputeMappings
            InvokeQueryAllAccountsWithExocomputeMappings();
        }

        // This parameter set invokes a single graphql operation:
        // allAccountProducts.
        protected void ProcessRecord_Product()
        {
            this._logger.name += " -Product";
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
        protected void ProcessRecord_Owner()
        {
            this._logger.name += " -Owner";
            // Invoke graphql operation allAccountOwners
            InvokeQueryAllAccountOwners();
        }


        // Invoke GraphQL Query:
        // accountSettings: AccountSetting!
        protected void InvokeQueryAccountSettings()
        {
            Tuple<string, string>[] argDefs = {
            };
            AccountSetting? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (AccountSetting)psObject.BaseObject;
                } else {
                    fields = (AccountSetting)this.Field;
                }
            }
            string document = Query.AccountSettings(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AccountSettings");
            var parameters = "";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAccountSettings" + parameters + "{" + document + "}",
                OperationName = "QueryAccountSettings",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            var result = this._rbkClient.Invoke(
                request, vars, "AccountSetting", this._logger, GetMetricTags());
            WriteObject(result, true);
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
            List<CloudAccountWithExocomputeMapping>? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (List<CloudAccountWithExocomputeMapping>)psObject.BaseObject;
                } else {
                    fields = (List<CloudAccountWithExocomputeMapping>)this.Field;
                }
            }
            string document = Query.AllAccountsWithExocomputeMappings(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AllAccountsWithExocomputeMappings");
            var parameters = "($cloudVendor: CloudVendor!,$features: [CloudAccountFeature!]!,$exocomputeAccountIdsFilter: [UUID!]!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAllAccountsWithExocomputeMappings" + parameters + "{" + document + "}",
                OperationName = "QueryAllAccountsWithExocomputeMappings",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "List<CloudAccountWithExocomputeMapping>", this._logger, GetMetricTags());
            WriteObject(result, true);
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
            List<AccountProduct>? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (List<AccountProduct>)psObject.BaseObject;
                } else {
                    fields = (List<AccountProduct>)this.Field;
                }
            }
            string document = Query.AllAccountProducts(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AllAccountProducts");
            var parameters = "($nameFilter: [ProductName!]!,$typeFilter: [ProductType!]!,$stateFilter: [ProductState!]!,$startDateArg: DateTime,$endDateArg: DateTime)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAllAccountProducts" + parameters + "{" + document + "}",
                OperationName = "QueryAllAccountProducts",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "List<AccountProduct>", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // accountId: String!
        protected void InvokeQueryAccountId()
        {
            Tuple<string, string>[] argDefs = {
            };
            System.String? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (System.String)psObject.BaseObject;
                } else {
                    fields = (System.String)this.Field;
                }
            }
            string document = Query.AccountId(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AccountId");
            var parameters = "";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAccountId" + parameters + "{" + document + "}",
                OperationName = "QueryAccountId",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            var result = this._rbkClient.Invoke(
                request, vars, "System.String", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // allAccountOwners: [User!]!
        protected void InvokeQueryAllAccountOwners()
        {
            Tuple<string, string>[] argDefs = {
            };
            List<User>? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (List<User>)psObject.BaseObject;
                } else {
                    fields = (List<User>)this.Field;
                }
            }
            string document = Query.AllAccountOwners(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AllAccountOwners");
            var parameters = "";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAllAccountOwners" + parameters + "{" + document + "}",
                OperationName = "QueryAllAccountOwners",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            var result = this._rbkClient.Invoke(
                request, vars, "List<User>", this._logger, GetMetricTags());
            WriteObject(result, true);
        }


    } // class Invoke_RscQueryAccount
}