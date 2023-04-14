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
using Rubrik.SecurityCloud.NetSDK.Library.HelperClasses;
using Rubrik.SecurityCloud.Operations;
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
        // GraphQL operation: accountSettings:AccountSetting!
        //
        [Parameter(
            ParameterSetName = "Setting",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: accountSettings:AccountSetting!",
            Position = 0
        )]
        public SwitchParameter Setting { get; set; }

        
        // -------------------------------------------------------------------
        // Product parameter set
        //
        // GraphQL operation: allAccountProducts(,   nameFilter: [ProductName!]!,   typeFilter: [ProductType!]!,   stateFilter: [ProductState!]!,   startDateArg: DateTime,   endDateArg: DateTime, ):[AccountProduct!]!
        //
        [Parameter(
            ParameterSetName = "Product",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: allAccountProducts(,   nameFilter: [ProductName!]!,   typeFilter: [ProductType!]!,   stateFilter: [ProductState!]!,   startDateArg: DateTime,   endDateArg: DateTime, ):[AccountProduct!]!",
            Position = 0
        )]
        public SwitchParameter Product { get; set; }

        [Parameter(
            ParameterSetName = "Product",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument nameFilter: [ProductName!]!"
        )]
        public List<ProductName>? NameFilter { get; set; }
        [Parameter(
            ParameterSetName = "Product",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument typeFilter: [ProductType!]!"
        )]
        public List<ProductType>? TypeFilter { get; set; }
        [Parameter(
            ParameterSetName = "Product",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument stateFilter: [ProductState!]!"
        )]
        public List<ProductState>? StateFilter { get; set; }
        [Parameter(
            ParameterSetName = "Product",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument startDateArg: DateTime"
        )]
        public DateTime? StartDateArg { get; set; }
        [Parameter(
            ParameterSetName = "Product",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument endDateArg: DateTime"
        )]
        public DateTime? EndDateArg { get; set; }
        
        // -------------------------------------------------------------------
        // Id parameter set
        //
        // GraphQL operation: accountId:String!
        //
        [Parameter(
            ParameterSetName = "Id",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: accountId:String!",
            Position = 0
        )]
        public SwitchParameter Id { get; set; }

        
        // -------------------------------------------------------------------
        // Owner parameter set
        //
        // GraphQL operation: allAccountOwners:[User!]!
        //
        [Parameter(
            ParameterSetName = "Owner",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: allAccountOwners:[User!]!",
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (AccountSetting)psObject.BaseObject;
                } else {
                    fields = (AccountSetting)this.Field;
                }
            }
            string document = Query.AccountSettings(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AccountSettings");
            string parameters = "";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAccountSettings" + parameters + "{" + document + "}",
                OperationName = "QueryAccountSettings",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            Task<AccountSetting> task = this._rbkClient.InvokeGenericCallAsync<AccountSetting>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (List<AccountProduct>)psObject.BaseObject;
                } else {
                    fields = (List<AccountProduct>)this.Field;
                }
            }
            string document = Query.AllAccountProducts(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AllAccountProducts");
            string parameters = "($nameFilter: [ProductName!]!,$typeFilter: [ProductType!]!,$stateFilter: [ProductState!]!,$startDateArg: DateTime,$endDateArg: DateTime)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAllAccountProducts" + parameters + "{" + document + "}",
                OperationName = "QueryAllAccountProducts",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<List<AccountProduct>> task = this._rbkClient.InvokeGenericCallAsync<List<AccountProduct>>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (System.String)psObject.BaseObject;
                } else {
                    fields = (System.String)this.Field;
                }
            }
            string document = Query.AccountId(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AccountId");
            string parameters = "";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAccountId" + parameters + "{" + document + "}",
                OperationName = "QueryAccountId",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            Task<System.String> task = this._rbkClient.InvokeGenericCallAsync<System.String>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (List<User>)psObject.BaseObject;
                } else {
                    fields = (List<User>)this.Field;
                }
            }
            string document = Query.AllAccountOwners(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AllAccountOwners");
            string parameters = "";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAllAccountOwners" + parameters + "{" + document + "}",
                OperationName = "QueryAllAccountOwners",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            Task<List<User>> task = this._rbkClient.InvokeGenericCallAsync<List<User>>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }


    } // class Invoke_RscQueryAccount
}