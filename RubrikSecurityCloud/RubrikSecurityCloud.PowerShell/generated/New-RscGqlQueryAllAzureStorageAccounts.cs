// New-RscGqlQueryAllAzureStorageAccounts.cs
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
    /// Create new GraphQL Query allAzureStorageAccounts
    /// allAzureStorageAccounts(storageAccountsRequest: AzureStorageAccountsReq!): [String!]!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlQueryAllAzureStorageAccounts")
    ]
    public class New_RscGqlQueryAllAzureStorageAccounts : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("allAzureStorageAccounts");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Query allAzureStorageAccounts
        /// allAzureStorageAccounts(storageAccountsRequest: AzureStorageAccountsReq!): [String!]!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_allAzureStorageAccounts();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_allAzureStorageAccounts()
        {
            this._logger.name += " -allAzureStorageAccounts";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("storageAccountsRequest", "AzureStorageAccountsReq!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllAzureStorageAccounts",
                "($storageAccountsRequest: AzureStorageAccountsReq!)",
                "List<System.String>",
                Query.AllAzureStorageAccounts_ObjectFieldSpec,
                Query.AllAzureStorageAccountsFieldSpec,
                @"# REQUIRED
$inputs.Var.storageAccountsRequest = @{
	# OPTIONAL
	cloudAccountId = <System.String>
	# OPTIONAL
	resourceGroup = <System.String>
}"
            );
        }

    } // class New-RscGqlQueryAllAzureStorageAccounts
}