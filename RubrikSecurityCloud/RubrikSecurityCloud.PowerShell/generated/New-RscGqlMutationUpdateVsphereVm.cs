// New-RscGqlMutationUpdateVsphereVm.cs
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
    /// Create new GraphQL Mutation updateVsphereVm
    /// updateVsphereVm(input: UpdateVsphereVmInput!): RequestSuccess!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlMutationUpdateVsphereVm")
    ]
    public class New_RscGqlMutationUpdateVsphereVm : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("updateVsphereVm");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Mutation updateVsphereVm
        /// updateVsphereVm(input: UpdateVsphereVmInput!): RequestSuccess!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_updateVsphereVm();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_updateVsphereVm()
        {
            this._logger.name += " -updateVsphereVm";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateVsphereVmInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateVsphereVm",
                "($input: UpdateVsphereVmInput!)",
                "RequestSuccess",
                Mutation.UpdateVsphereVm_ObjectFieldSpec,
                Mutation.UpdateVsphereVmFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
	# REQUIRED
	vmUpdateProperties = @{
		# OPTIONAL
		guestCredential = @{
			# REQUIRED
			password = <System.String>
			# REQUIRED
			username = <System.String>
		}
		# OPTIONAL
		shouldRefreshCacheAfterUpdate = <System.Boolean>
		# OPTIONAL
		guestCredentialId = <System.String>
		# OPTIONAL
		virtualMachineUpdate = @{
			# OPTIONAL
			cloudInstantiationSpec = @{
				# REQUIRED
				imageRetentionInSeconds = <System.Int64>
			}
			# OPTIONAL
			configuredSlaDomainId = <System.String>
			# OPTIONAL
			isArrayIntegrationEnabled = <System.Boolean>
			# OPTIONAL
			isVmPaused = <System.Boolean>
			# OPTIONAL
			maxNestedVsphereSnapshots = <System.Int32>
			# OPTIONAL
			postBackupScript = @{
				# REQUIRED
				failureHandling = <VirtualMachineScriptDetailFailureHandling> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.VirtualMachineScriptDetailFailureHandling]) for enum values.
				# REQUIRED
				scriptPath = <System.String>
				# REQUIRED
				timeoutMs = <System.Int64>
			}
			# OPTIONAL
			postSnapScript = @{
				# REQUIRED
				failureHandling = <VirtualMachineScriptDetailFailureHandling> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.VirtualMachineScriptDetailFailureHandling]) for enum values.
				# REQUIRED
				scriptPath = <System.String>
				# REQUIRED
				timeoutMs = <System.Int64>
			}
			# OPTIONAL
			preBackupScript = @{
				# REQUIRED
				failureHandling = <VirtualMachineScriptDetailFailureHandling> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.VirtualMachineScriptDetailFailureHandling]) for enum values.
				# REQUIRED
				scriptPath = <System.String>
				# REQUIRED
				timeoutMs = <System.Int64>
			}
			# OPTIONAL
			throttlingSettings = @{
				# OPTIONAL
				cpuUtilizationThreshold = <System.Int32>
				# OPTIONAL
				datastoreIoLatencyThreshold = <System.Int32>
				# OPTIONAL
				ioLatencyThreshold = <System.Int32>
			}
			# OPTIONAL
			snapshotConsistencyMandate = <VirtualMachineUpdateSnapshotConsistencyMandate> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.VirtualMachineUpdateSnapshotConsistencyMandate]) for enum values.
		}
	}
}"
            );
        }

    } // class New-RscGqlMutationUpdateVsphereVm
}