// New-RscGqlQueryAzureRegions.cs
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
    /// Create new GraphQL Query azureRegions
    /// azureRegions(tenantId: String!, subscriptionId: UUID!): RegionConnection!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlQueryAzureRegions")
    ]
    public class New_RscGqlQueryAzureRegions : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("azureRegions");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Query azureRegions
        /// azureRegions(tenantId: String!, subscriptionId: UUID!): RegionConnection!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_azureRegions();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_azureRegions()
        {
            this._logger.name += " -azureRegions";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("tenantId", "String!"),
                Tuple.Create("subscriptionId", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAzureRegions",
                "($tenantId: String!,$subscriptionId: UUID!)",
                "RegionConnection",
                Query.AzureRegions_ObjectFieldSpec,
                Query.AzureRegionsFieldSpec,
                @"# REQUIRED
$inputs.Var.tenantId = <System.String>
# REQUIRED
$inputs.Var.subscriptionId = <System.String>"
            );
        }

    } // class New-RscGqlQueryAzureRegions
}