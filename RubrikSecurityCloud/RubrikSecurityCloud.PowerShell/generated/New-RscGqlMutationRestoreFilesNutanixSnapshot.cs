// New-RscGqlMutationRestoreFilesNutanixSnapshot.cs
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
    /// Create new GraphQL Mutation restoreFilesNutanixSnapshot
    /// restoreFilesNutanixSnapshot(input: RestoreFilesNutanixSnapshotInput!): AsyncRequestStatus!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlMutationRestoreFilesNutanixSnapshot")
    ]
    public class New_RscGqlMutationRestoreFilesNutanixSnapshot : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("restoreFilesNutanixSnapshot");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Mutation restoreFilesNutanixSnapshot
        /// restoreFilesNutanixSnapshot(input: RestoreFilesNutanixSnapshotInput!): AsyncRequestStatus!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_restoreFilesNutanixSnapshot();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_restoreFilesNutanixSnapshot()
        {
            this._logger.name += " -restoreFilesNutanixSnapshot";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "RestoreFilesNutanixSnapshotInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationRestoreFilesNutanixSnapshot",
                "($input: RestoreFilesNutanixSnapshotInput!)",
                "AsyncRequestStatus",
                Mutation.RestoreFilesNutanixSnapshot_ObjectFieldSpec,
                Mutation.RestoreFilesNutanixSnapshotFieldSpec,
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

    } // class New-RscGqlMutationRestoreFilesNutanixSnapshot
}