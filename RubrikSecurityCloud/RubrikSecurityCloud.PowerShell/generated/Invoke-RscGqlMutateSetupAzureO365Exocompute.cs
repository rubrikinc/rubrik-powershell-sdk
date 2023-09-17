// Invoke-RscGqlMutateSetupAzureO365Exocompute.cs
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
    /// Invoke GraphQL Mutation setupAzureO365Exocompute
    /// setupAzureO365Exocompute(tenantId: String!, subscriptionId: UUID!, exocomputeConfig: AzureO365ExocomputeConfig!): SetupAzureO365ExocomputeResp!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "Invoke",
        "RscGqlMutateSetupAzureO365Exocompute")
    ]
    public class Invoke_RscGqlMutateSetupAzureO365Exocompute : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the Invoke-RscGqlQuery* cmdlets
        // fit in the Invoke-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("setupAzureO365Exocompute");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Invoke GraphQL Mutation setupAzureO365Exocompute
        /// setupAzureO365Exocompute(tenantId: String!, subscriptionId: UUID!, exocomputeConfig: AzureO365ExocomputeConfig!): SetupAzureO365ExocomputeResp!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_setupAzureO365Exocompute();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_setupAzureO365Exocompute()
        {
            this._logger.name += " -setupAzureO365Exocompute";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("tenantId", "String!"),
                Tuple.Create("subscriptionId", "UUID!"),
                Tuple.Create("exocomputeConfig", "AzureO365ExocomputeConfig!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationSetupAzureO365Exocompute",
                "($tenantId: String!,$subscriptionId: UUID!,$exocomputeConfig: AzureO365ExocomputeConfig!)",
                "SetupAzureO365ExocomputeResp",
                Mutation.SetupAzureO365Exocompute_ObjectFieldSpec,
                Mutation.SetupAzureO365ExocomputeFieldSpec,
                @"# REQUIRED
$inputs.Var.tenantId = <System.String>
# REQUIRED
$inputs.Var.subscriptionId = <System.String>
# REQUIRED
$inputs.Var.exocomputeConfig = @{
	# REQUIRED
	regionName = <System.String>
	# OPTIONAL
	newGroupConfig = @{
		# OPTIONAL
		name = <System.String>
	}
	# OPTIONAL
	existingGroupConfig = @{
		# OPTIONAL
		name = <System.String>
	}
	# OPTIONAL
	newComputeConfig = @{
		# OPTIONAL
		vnetName = <System.String>
		# OPTIONAL
		subnetName = <System.String>
		# OPTIONAL
		securityGroupName = <System.String>
	}
	# OPTIONAL
	existingComputeConfig = @{
		# OPTIONAL
		vnetId = <System.String>
		# OPTIONAL
		subnetId = <System.String>
	}
	# OPTIONAL
	newStorageAccountConfig = @{
		# OPTIONAL
		name = <System.String>
		# OPTIONAL
		tier = <StorageAccountTier> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.StorageAccountTier]) for enum values.
		# OPTIONAL
		sku = <StorageAccountSku> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.StorageAccountSku]) for enum values.
		# OPTIONAL
		storages = @(
			@{
				# OPTIONAL
				name = <System.String>
				# OPTIONAL
				tier = <StorageAccountTier> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.StorageAccountTier]) for enum values.
				# OPTIONAL
				sku = <StorageAccountSku> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.StorageAccountSku]) for enum values.
				# OPTIONAL
				containerImmutabilityStatus = <ColossusStorageContainerImmutabilityStatus> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ColossusStorageContainerImmutabilityStatus]) for enum values.
				# OPTIONAL
				versioningEnabled = <System.Boolean>
			}
		)
	}
	# OPTIONAL
	existingStorageAccountConfig = @{
		# OPTIONAL
		id = <System.String>
	}
}"
            );
        }

    } // class Invoke-RscGqlMutateSetupAzureO365Exocompute
}