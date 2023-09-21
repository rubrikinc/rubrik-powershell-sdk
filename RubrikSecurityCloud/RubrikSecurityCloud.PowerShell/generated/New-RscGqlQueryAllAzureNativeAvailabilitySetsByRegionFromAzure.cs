// New-RscGqlQueryAllAzureNativeAvailabilitySetsByRegionFromAzure.cs
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
    /// Create new GraphQL Query allAzureNativeAvailabilitySetsByRegionFromAzure
    /// allAzureNativeAvailabilitySetsByRegionFromAzure(azureSubscriptionRubrikId: UUID!, resourceGroupName: String!, region: AzureNativeRegion!): [AzureNativeAvailabilitySet!]!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlQueryAllAzureNativeAvailabilitySetsByRegionFromAzure")
    ]
    public class New_RscGqlQueryAllAzureNativeAvailabilitySetsByRegionFromAzure : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("allAzureNativeAvailabilitySetsByRegionFromAzure");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Query allAzureNativeAvailabilitySetsByRegionFromAzure
        /// allAzureNativeAvailabilitySetsByRegionFromAzure(azureSubscriptionRubrikId: UUID!, resourceGroupName: String!, region: AzureNativeRegion!): [AzureNativeAvailabilitySet!]!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_allAzureNativeAvailabilitySetsByRegionFromAzure();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_allAzureNativeAvailabilitySetsByRegionFromAzure()
        {
            this._logger.name += " -allAzureNativeAvailabilitySetsByRegionFromAzure";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("azureSubscriptionRubrikId", "UUID!"),
                Tuple.Create("resourceGroupName", "String!"),
                Tuple.Create("region", "AzureNativeRegion!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllAzureNativeAvailabilitySetsByRegionFromAzure",
                "($azureSubscriptionRubrikId: UUID!,$resourceGroupName: String!,$region: AzureNativeRegion!)",
                "List<AzureNativeAvailabilitySet>",
                Query.AllAzureNativeAvailabilitySetsByRegionFromAzure_ObjectFieldSpec,
                Query.AllAzureNativeAvailabilitySetsByRegionFromAzureFieldSpec,
                @"# REQUIRED
$inputs.Var.azureSubscriptionRubrikId = <System.String>
# REQUIRED
$inputs.Var.resourceGroupName = <System.String>
# REQUIRED
$inputs.Var.region = <AzureNativeRegion> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeRegion]) for enum values."
            );
        }

    } // class New-RscGqlQueryAllAzureNativeAvailabilitySetsByRegionFromAzure
}