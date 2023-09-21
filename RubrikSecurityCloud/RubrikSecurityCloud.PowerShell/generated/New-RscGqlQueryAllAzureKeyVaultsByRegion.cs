// New-RscGqlQueryAllAzureKeyVaultsByRegion.cs
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
    /// Create new GraphQL Query allAzureKeyVaultsByRegion
    /// allAzureKeyVaultsByRegion(azureKeyVaultsInput: AzureKeyVaultsInput!): [AzureKeyVault!]!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlQueryAllAzureKeyVaultsByRegion")
    ]
    public class New_RscGqlQueryAllAzureKeyVaultsByRegion : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("allAzureKeyVaultsByRegion");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Query allAzureKeyVaultsByRegion
        /// allAzureKeyVaultsByRegion(azureKeyVaultsInput: AzureKeyVaultsInput!): [AzureKeyVault!]!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_allAzureKeyVaultsByRegion();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_allAzureKeyVaultsByRegion()
        {
            this._logger.name += " -allAzureKeyVaultsByRegion";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("azureKeyVaultsInput", "AzureKeyVaultsInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllAzureKeyVaultsByRegion",
                "($azureKeyVaultsInput: AzureKeyVaultsInput!)",
                "List<AzureKeyVault>",
                Query.AllAzureKeyVaultsByRegion_ObjectFieldSpec,
                Query.AllAzureKeyVaultsByRegionFieldSpec,
                @"# REQUIRED
$inputs.Var.azureKeyVaultsInput = @{
	# REQUIRED
	cloudAccountId = <System.String>
	# REQUIRED
	region = <AzureRegion> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureRegion]) for enum values.
	# OPTIONAL
	userAssignedManagedIdentityPrincipalId = <System.String>
}"
            );
        }

    } // class New-RscGqlQueryAllAzureKeyVaultsByRegion
}