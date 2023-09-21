// New-RscGqlMutationUpdateNutanixVm.cs
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
    /// Create new GraphQL Mutation updateNutanixVm
    /// updateNutanixVm(input: UpdateNutanixVmInput!): Void
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlMutationUpdateNutanixVm")
    ]
    public class New_RscGqlMutationUpdateNutanixVm : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("updateNutanixVm");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Mutation updateNutanixVm
        /// updateNutanixVm(input: UpdateNutanixVmInput!): Void
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_updateNutanixVm();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_updateNutanixVm()
        {
            this._logger.name += " -updateNutanixVm";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateNutanixVmInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateNutanixVm",
                "($input: UpdateNutanixVmInput!)",
                "System.String",
                Mutation.UpdateNutanixVm_ObjectFieldSpec,
                Mutation.UpdateNutanixVmFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
	# REQUIRED
	vmPatchProperties = @{
		# OPTIONAL
		configuredSlaDomainId = <System.String>
		# OPTIONAL
		excludedDiskIds = @(
			<System.String>
		)
		# OPTIONAL
		isPaused = <System.Boolean>
		# OPTIONAL
		postBackupScript = @{
			# REQUIRED
			failureHandling = <NutanixVirtualMachineScriptDetailFailureHandling> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.NutanixVirtualMachineScriptDetailFailureHandling]) for enum values.
			# REQUIRED
			scriptPath = <System.String>
			# REQUIRED
			timeoutMs = <System.Int64>
		}
		# OPTIONAL
		postSnapScript = @{
			# REQUIRED
			failureHandling = <NutanixVirtualMachineScriptDetailFailureHandling> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.NutanixVirtualMachineScriptDetailFailureHandling]) for enum values.
			# REQUIRED
			scriptPath = <System.String>
			# REQUIRED
			timeoutMs = <System.Int64>
		}
		# OPTIONAL
		preBackupScript = @{
			# REQUIRED
			failureHandling = <NutanixVirtualMachineScriptDetailFailureHandling> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.NutanixVirtualMachineScriptDetailFailureHandling]) for enum values.
			# REQUIRED
			scriptPath = <System.String>
			# REQUIRED
			timeoutMs = <System.Int64>
		}
		# OPTIONAL
		snapshotConsistencyMandate = <CdmNutanixSnapshotConsistencyMandate> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CdmNutanixSnapshotConsistencyMandate]) for enum values.
	}
}"
            );
        }

    } // class New-RscGqlMutationUpdateNutanixVm
}