// Invoke-RscGqlQueryAzureO365CheckStorageAccountAccessibility.cs
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
    /// Invoke GraphQL Query azureO365CheckStorageAccountAccessibility
    /// azureO365CheckStorageAccountAccessibility(
    ///     tenantId: String!
    ///     subscriptionId: UUID!
    ///     storage_account_name: String!
    ///     groupName: String!
    ///   ): AzureResourceAvailabilityResp!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "Invoke",
        "RscGqlQueryAzureO365CheckStorageAccountAccessibility")
    ]
    public class Invoke_RscGqlQueryAzureO365CheckStorageAccountAccessibility : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the Invoke-RscGqlQuery* cmdlets
        // fit in the Invoke-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("azureO365CheckStorageAccountAccessibility");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Invoke GraphQL Query azureO365CheckStorageAccountAccessibility
        /// azureO365CheckStorageAccountAccessibility(
        ///     tenantId: String!
        ///     subscriptionId: UUID!
        ///     storage_account_name: String!
        ///     groupName: String!
        ///   ): AzureResourceAvailabilityResp!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_azureO365CheckStorageAccountAccessibility();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_azureO365CheckStorageAccountAccessibility()
        {
            this._logger.name += " -azureO365CheckStorageAccountAccessibility";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("tenantId", "String!"),
                Tuple.Create("subscriptionId", "UUID!"),
                Tuple.Create("storage_account_name", "String!"),
                Tuple.Create("groupName", "String!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAzureO365CheckStorageAccountAccessibility",
                "($tenantId: String!,$subscriptionId: UUID!,$storage_account_name: String!,$groupName: String!)",
                "AzureResourceAvailabilityResp",
                Query.AzureO365CheckStorageAccountAccessibility_ObjectFieldSpec,
                Query.AzureO365CheckStorageAccountAccessibilityFieldSpec,
                @"# REQUIRED
$inputs.Var.tenantId = <System.String>
# REQUIRED
$inputs.Var.subscriptionId = <System.String>
# REQUIRED
$inputs.Var.storage_account_name = <System.String>
# REQUIRED
$inputs.Var.groupName = <System.String>"
            );
        }

    } // class Invoke-RscGqlQueryAzureO365CheckStorageAccountAccessibility
}