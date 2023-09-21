// New-RscGqlQueryAzureCloudAccountSubscriptionWithFeatures.cs
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
    /// Create new GraphQL Query azureCloudAccountSubscriptionWithFeatures
    /// azureCloudAccountSubscriptionWithFeatures(cloudAccountId: UUID!): AzureCloudAccountSubscriptionWithFeatures!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlQueryAzureCloudAccountSubscriptionWithFeatures")
    ]
    public class New_RscGqlQueryAzureCloudAccountSubscriptionWithFeatures : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("azureCloudAccountSubscriptionWithFeatures");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Query azureCloudAccountSubscriptionWithFeatures
        /// azureCloudAccountSubscriptionWithFeatures(cloudAccountId: UUID!): AzureCloudAccountSubscriptionWithFeatures!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_azureCloudAccountSubscriptionWithFeatures();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_azureCloudAccountSubscriptionWithFeatures()
        {
            this._logger.name += " -azureCloudAccountSubscriptionWithFeatures";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("cloudAccountId", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAzureCloudAccountSubscriptionWithFeatures",
                "($cloudAccountId: UUID!)",
                "AzureCloudAccountSubscriptionWithFeatures",
                Query.AzureCloudAccountSubscriptionWithFeatures_ObjectFieldSpec,
                Query.AzureCloudAccountSubscriptionWithFeaturesFieldSpec,
                @"# REQUIRED
$inputs.Var.cloudAccountId = <System.String>"
            );
        }

    } // class New-RscGqlQueryAzureCloudAccountSubscriptionWithFeatures
}