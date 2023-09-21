// New-RscGqlQueryAzureSubscriptions.cs
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
    /// Create new GraphQL Query azureSubscriptions
    /// azureSubscriptions(tenantId: String!): AzureSubscriptionConnection!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlQueryAzureSubscriptions")
    ]
    public class New_RscGqlQueryAzureSubscriptions : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("azureSubscriptions");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Query azureSubscriptions
        /// azureSubscriptions(tenantId: String!): AzureSubscriptionConnection!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_azureSubscriptions();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_azureSubscriptions()
        {
            this._logger.name += " -azureSubscriptions";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("tenantId", "String!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAzureSubscriptions",
                "($tenantId: String!)",
                "AzureSubscriptionConnection",
                Query.AzureSubscriptions_ObjectFieldSpec,
                Query.AzureSubscriptionsFieldSpec,
                @"# REQUIRED
$inputs.Var.tenantId = <System.String>"
            );
        }

    } // class New-RscGqlQueryAzureSubscriptions
}