// New-RscGqlMutationRestoreHypervVirtualMachineSnapshotFiles.cs
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
    /// Create new GraphQL Mutation restoreHypervVirtualMachineSnapshotFiles
    /// restoreHypervVirtualMachineSnapshotFiles(input: RestoreHypervVirtualMachineSnapshotFilesInput!): AsyncRequestStatus!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlMutationRestoreHypervVirtualMachineSnapshotFiles")
    ]
    public class New_RscGqlMutationRestoreHypervVirtualMachineSnapshotFiles : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("restoreHypervVirtualMachineSnapshotFiles");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Mutation restoreHypervVirtualMachineSnapshotFiles
        /// restoreHypervVirtualMachineSnapshotFiles(input: RestoreHypervVirtualMachineSnapshotFilesInput!): AsyncRequestStatus!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_restoreHypervVirtualMachineSnapshotFiles();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_restoreHypervVirtualMachineSnapshotFiles()
        {
            this._logger.name += " -restoreHypervVirtualMachineSnapshotFiles";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "RestoreHypervVirtualMachineSnapshotFilesInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationRestoreHypervVirtualMachineSnapshotFiles",
                "($input: RestoreHypervVirtualMachineSnapshotFilesInput!)",
                "AsyncRequestStatus",
                Mutation.RestoreHypervVirtualMachineSnapshotFiles_ObjectFieldSpec,
                Mutation.RestoreHypervVirtualMachineSnapshotFilesFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	config = @{
		# OPTIONAL
		targetVirtualMachineId = <System.String>
		# REQUIRED
		restoreConfig = @(
			@{
				# REQUIRED
				path = <System.String>
				# REQUIRED
				restorePath = <System.String>
			}
		)
	}
	# REQUIRED
	id = <System.String>
}"
            );
        }

    } // class New-RscGqlMutationRestoreHypervVirtualMachineSnapshotFiles
}