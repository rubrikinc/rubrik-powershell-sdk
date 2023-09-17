// Invoke-RscMutateAzureO365.cs
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
    /// AzureO365 mutations
    /// </summary>
    /// <description>
    /// Invoke-RscMutateAzureO365 is a master cmdlet for AzureO365 work that can invoke any of the following subcommands: SetupExocompute.
    /// </description>
    /// <example>
    /// <code>Invoke-RscMutateAzureO365 -SetupExocompute [-Arg ..] [-Field ..]</code>
    /// </example>
    [CmdletBinding()]
    [Cmdlet(
        "Invoke",
        "RscMutateAzureO365",
        DefaultParameterSetName = "SetupExocompute")
    ]
    public class Invoke_RscMutateAzureO365 : RscGqlPSCmdlet
    {
        
        /// <summary>
        /// SetupExocompute parameter set
        ///
        /// [GraphQL: setupAzureO365Exocompute]
        /// </summary>
        [Parameter(
            ParameterSetName = "SetupExocompute",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Sets up Exocompute for an O365 subscription.
[GraphQL: setupAzureO365Exocompute]",
            Position = 0
        )]
        public SwitchParameter SetupExocompute { get; set; }


// ignore warning 'Missing XML comment'
#pragma warning disable 1591
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                switch(Op)
                {
                    case "SetupExocompute":
                        this.ProcessRecord_SetupExocompute();
                        break;
                    default:
                        throw new Exception("Unknown Operation " + Op);
                }
           }
           catch (Exception ex)
           {
                ThrowTerminatingException(ex);
           }
        }
#pragma warning restore 1591

        // This parameter set invokes a single graphql operation:
        // setupAzureO365Exocompute.
        internal void ProcessRecord_SetupExocompute()
        {
            this._logger.name += " -SetupExocompute";
            // Invoke graphql operation setupAzureO365Exocompute
            InvokeMutationSetupAzureO365Exocompute();
        }


        // Invoke GraphQL Mutation:
        // setupAzureO365Exocompute(tenantId: String!, subscriptionId: UUID!, exocomputeConfig: AzureO365ExocomputeConfig!): SetupAzureO365ExocomputeResp!
        internal void InvokeMutationSetupAzureO365Exocompute()
        {
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


    } // class Invoke_RscMutateAzureO365
}