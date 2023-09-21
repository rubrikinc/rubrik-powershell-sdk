// New-RscGqlMutationUpdateHypervVirtualMachine.cs
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
    /// Create new GraphQL Mutation updateHypervVirtualMachine
    /// updateHypervVirtualMachine(input: UpdateHypervVirtualMachineInput!): UpdateHypervVirtualMachineReply!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlMutationUpdateHypervVirtualMachine")
    ]
    public class New_RscGqlMutationUpdateHypervVirtualMachine : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("updateHypervVirtualMachine");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Mutation updateHypervVirtualMachine
        /// updateHypervVirtualMachine(input: UpdateHypervVirtualMachineInput!): UpdateHypervVirtualMachineReply!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_updateHypervVirtualMachine();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_updateHypervVirtualMachine()
        {
            this._logger.name += " -updateHypervVirtualMachine";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateHypervVirtualMachineInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateHypervVirtualMachine",
                "($input: UpdateHypervVirtualMachineInput!)",
                "UpdateHypervVirtualMachineReply",
                Mutation.UpdateHypervVirtualMachine_ObjectFieldSpec,
                Mutation.UpdateHypervVirtualMachineFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
	# REQUIRED
	vmUpdateProperties = @{
		# OPTIONAL
		cloudInstantiationSpec = @{
			# REQUIRED
			imageRetentionInSeconds = <System.Int64>
		}
		# OPTIONAL
		configuredSlaDomainId = <System.String>
		# OPTIONAL
		virtualDiskIdsExcludedFromSnapshot = @(
			<System.String>
		)
	}
}"
            );
        }

    } // class New-RscGqlMutationUpdateHypervVirtualMachine
}