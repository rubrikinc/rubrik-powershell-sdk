// New-RscGqlQueryAllAzureNativeExportCompatibleVmSizesByRegionFromAzure.cs
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
    /// Create new GraphQL Query allAzureNativeExportCompatibleVmSizesByRegionFromAzure
    /// allAzureNativeExportCompatibleVmSizesByRegionFromAzure(azureSubscriptionRubrikId: UUID!, region: AzureNativeRegion!, vmSnapshotId: UUID!): [AzureNativeExportCompatibleVmSizes!]!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlQueryAllAzureNativeExportCompatibleVmSizesByRegionFromAzure")
    ]
    public class New_RscGqlQueryAllAzureNativeExportCompatibleVmSizesByRegionFromAzure : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("allAzureNativeExportCompatibleVmSizesByRegionFromAzure");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Query allAzureNativeExportCompatibleVmSizesByRegionFromAzure
        /// allAzureNativeExportCompatibleVmSizesByRegionFromAzure(azureSubscriptionRubrikId: UUID!, region: AzureNativeRegion!, vmSnapshotId: UUID!): [AzureNativeExportCompatibleVmSizes!]!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_allAzureNativeExportCompatibleVmSizesByRegionFromAzure();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_allAzureNativeExportCompatibleVmSizesByRegionFromAzure()
        {
            this._logger.name += " -allAzureNativeExportCompatibleVmSizesByRegionFromAzure";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("azureSubscriptionRubrikId", "UUID!"),
                Tuple.Create("region", "AzureNativeRegion!"),
                Tuple.Create("vmSnapshotId", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllAzureNativeExportCompatibleVmSizesByRegionFromAzure",
                "($azureSubscriptionRubrikId: UUID!,$region: AzureNativeRegion!,$vmSnapshotId: UUID!)",
                "List<AzureNativeExportCompatibleVmSizes>",
                Query.AllAzureNativeExportCompatibleVmSizesByRegionFromAzure_ObjectFieldSpec,
                Query.AllAzureNativeExportCompatibleVmSizesByRegionFromAzureFieldSpec,
                @"# REQUIRED
$inputs.Var.azureSubscriptionRubrikId = <System.String>
# REQUIRED
$inputs.Var.region = <AzureNativeRegion> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeRegion]) for enum values.
# REQUIRED
$inputs.Var.vmSnapshotId = <System.String>"
            );
        }

    } // class New-RscGqlQueryAllAzureNativeExportCompatibleVmSizesByRegionFromAzure
}