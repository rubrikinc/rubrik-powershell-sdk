// New-RscGqlQueryAllAzureNativeStorageAccountsFromAzure.cs
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
    /// Create new GraphQL Query allAzureNativeStorageAccountsFromAzure
    /// allAzureNativeStorageAccountsFromAzure(azureSubscriptionRubrikId: UUID!): [AzureNativeStorageAccount!]!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlQueryAllAzureNativeStorageAccountsFromAzure")
    ]
    public class New_RscGqlQueryAllAzureNativeStorageAccountsFromAzure : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("allAzureNativeStorageAccountsFromAzure");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Query allAzureNativeStorageAccountsFromAzure
        /// allAzureNativeStorageAccountsFromAzure(azureSubscriptionRubrikId: UUID!): [AzureNativeStorageAccount!]!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_allAzureNativeStorageAccountsFromAzure();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_allAzureNativeStorageAccountsFromAzure()
        {
            this._logger.name += " -allAzureNativeStorageAccountsFromAzure";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("azureSubscriptionRubrikId", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllAzureNativeStorageAccountsFromAzure",
                "($azureSubscriptionRubrikId: UUID!)",
                "List<AzureNativeStorageAccount>",
                Query.AllAzureNativeStorageAccountsFromAzure_ObjectFieldSpec,
                Query.AllAzureNativeStorageAccountsFromAzureFieldSpec,
                @"# REQUIRED
$inputs.Var.azureSubscriptionRubrikId = <System.String>"
            );
        }

    } // class New-RscGqlQueryAllAzureNativeStorageAccountsFromAzure
}