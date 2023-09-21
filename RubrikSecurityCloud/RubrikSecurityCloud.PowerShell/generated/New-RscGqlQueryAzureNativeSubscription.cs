// New-RscGqlQueryAzureNativeSubscription.cs
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
    /// Create new GraphQL Query azureNativeSubscription
    /// azureNativeSubscription(azureSubscriptionRubrikId: UUID!): AzureNativeSubscription!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlQueryAzureNativeSubscription")
    ]
    public class New_RscGqlQueryAzureNativeSubscription : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("azureNativeSubscription");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Query azureNativeSubscription
        /// azureNativeSubscription(azureSubscriptionRubrikId: UUID!): AzureNativeSubscription!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_azureNativeSubscription();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_azureNativeSubscription()
        {
            this._logger.name += " -azureNativeSubscription";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("azureSubscriptionRubrikId", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAzureNativeSubscription",
                "($azureSubscriptionRubrikId: UUID!)",
                "AzureNativeSubscription",
                Query.AzureNativeSubscription_ObjectFieldSpec,
                Query.AzureNativeSubscriptionFieldSpec,
                @"# REQUIRED
$inputs.Var.azureSubscriptionRubrikId = <System.String>"
            );
        }

    } // class New-RscGqlQueryAzureNativeSubscription
}