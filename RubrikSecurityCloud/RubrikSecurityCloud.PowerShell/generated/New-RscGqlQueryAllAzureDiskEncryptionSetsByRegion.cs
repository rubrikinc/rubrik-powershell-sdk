// New-RscGqlQueryAllAzureDiskEncryptionSetsByRegion.cs
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
    /// Create new GraphQL Query allAzureDiskEncryptionSetsByRegion
    /// allAzureDiskEncryptionSetsByRegion(azureSubscriptionRubrikId: UUID!, region: AzureNativeRegion!): [AzureNativeDiskEncryptionSet!]!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlQueryAllAzureDiskEncryptionSetsByRegion")
    ]
    public class New_RscGqlQueryAllAzureDiskEncryptionSetsByRegion : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("allAzureDiskEncryptionSetsByRegion");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Query allAzureDiskEncryptionSetsByRegion
        /// allAzureDiskEncryptionSetsByRegion(azureSubscriptionRubrikId: UUID!, region: AzureNativeRegion!): [AzureNativeDiskEncryptionSet!]!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_allAzureDiskEncryptionSetsByRegion();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_allAzureDiskEncryptionSetsByRegion()
        {
            this._logger.name += " -allAzureDiskEncryptionSetsByRegion";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("azureSubscriptionRubrikId", "UUID!"),
                Tuple.Create("region", "AzureNativeRegion!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllAzureDiskEncryptionSetsByRegion",
                "($azureSubscriptionRubrikId: UUID!,$region: AzureNativeRegion!)",
                "List<AzureNativeDiskEncryptionSet>",
                Query.AllAzureDiskEncryptionSetsByRegion_ObjectFieldSpec,
                Query.AllAzureDiskEncryptionSetsByRegionFieldSpec,
                @"# REQUIRED
$inputs.Var.azureSubscriptionRubrikId = <System.String>
# REQUIRED
$inputs.Var.region = <AzureNativeRegion> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeRegion]) for enum values."
            );
        }

    } // class New-RscGqlQueryAllAzureDiskEncryptionSetsByRegion
}