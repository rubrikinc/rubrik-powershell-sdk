// New-RscGqlMutationDownloadHypervVirtualMachineSnapshot.cs
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
    /// Create new GraphQL Mutation downloadHypervVirtualMachineSnapshot
    /// downloadHypervVirtualMachineSnapshot(input: DownloadHypervVirtualMachineSnapshotInput!): AsyncRequestStatus!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlMutationDownloadHypervVirtualMachineSnapshot")
    ]
    public class New_RscGqlMutationDownloadHypervVirtualMachineSnapshot : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("downloadHypervVirtualMachineSnapshot");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Mutation downloadHypervVirtualMachineSnapshot
        /// downloadHypervVirtualMachineSnapshot(input: DownloadHypervVirtualMachineSnapshotInput!): AsyncRequestStatus!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_downloadHypervVirtualMachineSnapshot();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_downloadHypervVirtualMachineSnapshot()
        {
            this._logger.name += " -downloadHypervVirtualMachineSnapshot";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DownloadHypervVirtualMachineSnapshotInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDownloadHypervVirtualMachineSnapshot",
                "($input: DownloadHypervVirtualMachineSnapshotInput!)",
                "AsyncRequestStatus",
                Mutation.DownloadHypervVirtualMachineSnapshot_ObjectFieldSpec,
                Mutation.DownloadHypervVirtualMachineSnapshotFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
}"
            );
        }

    } // class New-RscGqlMutationDownloadHypervVirtualMachineSnapshot
}