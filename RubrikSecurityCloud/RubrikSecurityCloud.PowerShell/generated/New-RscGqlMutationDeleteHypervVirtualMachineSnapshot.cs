// New-RscGqlMutationDeleteHypervVirtualMachineSnapshot.cs
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
    /// Create new GraphQL Mutation deleteHypervVirtualMachineSnapshot
    /// deleteHypervVirtualMachineSnapshot(input: DeleteHypervVirtualMachineSnapshotInput!): RequestSuccess!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlMutationDeleteHypervVirtualMachineSnapshot")
    ]
    public class New_RscGqlMutationDeleteHypervVirtualMachineSnapshot : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("deleteHypervVirtualMachineSnapshot");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Mutation deleteHypervVirtualMachineSnapshot
        /// deleteHypervVirtualMachineSnapshot(input: DeleteHypervVirtualMachineSnapshotInput!): RequestSuccess!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_deleteHypervVirtualMachineSnapshot();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_deleteHypervVirtualMachineSnapshot()
        {
            this._logger.name += " -deleteHypervVirtualMachineSnapshot";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteHypervVirtualMachineSnapshotInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDeleteHypervVirtualMachineSnapshot",
                "($input: DeleteHypervVirtualMachineSnapshotInput!)",
                "RequestSuccess",
                Mutation.DeleteHypervVirtualMachineSnapshot_ObjectFieldSpec,
                Mutation.DeleteHypervVirtualMachineSnapshotFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	location = <InternalDeleteHypervVirtualMachineSnapshotRequestLocation> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.InternalDeleteHypervVirtualMachineSnapshotRequestLocation]) for enum values.
	# REQUIRED
	id = <System.String>
}"
            );
        }

    } // class New-RscGqlMutationDeleteHypervVirtualMachineSnapshot
}