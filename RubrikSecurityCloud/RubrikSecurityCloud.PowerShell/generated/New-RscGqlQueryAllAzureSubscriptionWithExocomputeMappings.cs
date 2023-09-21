// New-RscGqlQueryAllAzureSubscriptionWithExocomputeMappings.cs
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
    /// Create new GraphQL Query allAzureSubscriptionWithExocomputeMappings
    /// allAzureSubscriptionWithExocomputeMappings(features: [CloudAccountFeature!], exocomputeSubscriptionIdsFilter: [UUID!]): [AzureSubscriptionWithExocomputeMapping!]!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlQueryAllAzureSubscriptionWithExocomputeMappings")
    ]
    public class New_RscGqlQueryAllAzureSubscriptionWithExocomputeMappings : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("allAzureSubscriptionWithExocomputeMappings");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Query allAzureSubscriptionWithExocomputeMappings
        /// allAzureSubscriptionWithExocomputeMappings(features: [CloudAccountFeature!], exocomputeSubscriptionIdsFilter: [UUID!]): [AzureSubscriptionWithExocomputeMapping!]!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_allAzureSubscriptionWithExocomputeMappings();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_allAzureSubscriptionWithExocomputeMappings()
        {
            this._logger.name += " -allAzureSubscriptionWithExocomputeMappings";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("features", "[CloudAccountFeature!]"),
                Tuple.Create("exocomputeSubscriptionIdsFilter", "[UUID!]"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllAzureSubscriptionWithExocomputeMappings",
                "($features: [CloudAccountFeature!],$exocomputeSubscriptionIdsFilter: [UUID!])",
                "List<AzureSubscriptionWithExocomputeMapping>",
                Query.AllAzureSubscriptionWithExocomputeMappings_ObjectFieldSpec,
                Query.AllAzureSubscriptionWithExocomputeMappingsFieldSpec,
                @"# OPTIONAL
$inputs.Var.features = @(
	<CloudAccountFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
)
# OPTIONAL
$inputs.Var.exocomputeSubscriptionIdsFilter = @(
	<System.String>
)"
            );
        }

    } // class New-RscGqlQueryAllAzureSubscriptionWithExocomputeMappings
}