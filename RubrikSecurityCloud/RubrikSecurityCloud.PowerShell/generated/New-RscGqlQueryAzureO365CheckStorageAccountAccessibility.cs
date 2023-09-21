// New-RscGqlQueryAzureO365CheckStorageAccountAccessibility.cs
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
    /// Create new GraphQL Query azureO365CheckStorageAccountAccessibility
    /// azureO365CheckStorageAccountAccessibility(
    ///     tenantId: String!
    ///     subscriptionId: UUID!
    ///     storage_account_name: String!
    ///     groupName: String!
    ///   ): AzureResourceAvailabilityResp!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlQueryAzureO365CheckStorageAccountAccessibility")
    ]
    public class New_RscGqlQueryAzureO365CheckStorageAccountAccessibility : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
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
        /// Create new GraphQL Query azureO365CheckStorageAccountAccessibility
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

    } // class New-RscGqlQueryAzureO365CheckStorageAccountAccessibility
}