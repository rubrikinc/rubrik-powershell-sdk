// New-RscGqlMutationCreateHypervVirtualMachineSnapshotMount.cs
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
    /// Create new GraphQL Mutation createHypervVirtualMachineSnapshotMount
    /// createHypervVirtualMachineSnapshotMount(input: CreateHypervVirtualMachineSnapshotMountInput!): AsyncRequestStatus!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlMutationCreateHypervVirtualMachineSnapshotMount")
    ]
    public class New_RscGqlMutationCreateHypervVirtualMachineSnapshotMount : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("createHypervVirtualMachineSnapshotMount");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Mutation createHypervVirtualMachineSnapshotMount
        /// createHypervVirtualMachineSnapshotMount(input: CreateHypervVirtualMachineSnapshotMountInput!): AsyncRequestStatus!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_createHypervVirtualMachineSnapshotMount();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_createHypervVirtualMachineSnapshotMount()
        {
            this._logger.name += " -createHypervVirtualMachineSnapshotMount";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateHypervVirtualMachineSnapshotMountInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateHypervVirtualMachineSnapshotMount",
                "($input: CreateHypervVirtualMachineSnapshotMountInput!)",
                "AsyncRequestStatus",
                Mutation.CreateHypervVirtualMachineSnapshotMount_ObjectFieldSpec,
                Mutation.CreateHypervVirtualMachineSnapshotMountFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# OPTIONAL
	config = @{
		# OPTIONAL
		disableNetwork = <System.Boolean>
		# OPTIONAL
		hostId = <System.String>
		# OPTIONAL
		powerOn = <System.Boolean>
		# OPTIONAL
		removeNetworkDevices = <System.Boolean>
		# OPTIONAL
		vmName = <System.String>
	}
	# REQUIRED
	id = <System.String>
}"
            );
        }

    } // class New-RscGqlMutationCreateHypervVirtualMachineSnapshotMount
}