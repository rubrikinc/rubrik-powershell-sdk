// Invoke-RscGqlMutateBulkOnDemandSnapshotNutanixVm.cs
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
    /// Invoke GraphQL Mutation bulkOnDemandSnapshotNutanixVm
    /// bulkOnDemandSnapshotNutanixVm(input: BulkOnDemandSnapshotNutanixVmInput!): BulkOnDemandSnapshotNutanixVmReply!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "Invoke",
        "RscGqlMutateBulkOnDemandSnapshotNutanixVm")
    ]
    public class Invoke_RscGqlMutateBulkOnDemandSnapshotNutanixVm : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the Invoke-RscGqlQuery* cmdlets
        // fit in the Invoke-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("bulkOnDemandSnapshotNutanixVm");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Invoke GraphQL Mutation bulkOnDemandSnapshotNutanixVm
        /// bulkOnDemandSnapshotNutanixVm(input: BulkOnDemandSnapshotNutanixVmInput!): BulkOnDemandSnapshotNutanixVmReply!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_bulkOnDemandSnapshotNutanixVm();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_bulkOnDemandSnapshotNutanixVm()
        {
            this._logger.name += " -bulkOnDemandSnapshotNutanixVm";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "BulkOnDemandSnapshotNutanixVmInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationBulkOnDemandSnapshotNutanixVm",
                "($input: BulkOnDemandSnapshotNutanixVmInput!)",
                "BulkOnDemandSnapshotNutanixVmReply",
                Mutation.BulkOnDemandSnapshotNutanixVm_ObjectFieldSpec,
                Mutation.BulkOnDemandSnapshotNutanixVmFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	config = @{
		# REQUIRED
		vms = @(
			@{
				# REQUIRED
				backupConfig = @{
					# OPTIONAL
					slaId = <System.String>
				}
				# REQUIRED
				vmId = <System.String>
			}
		)
	}
	# OPTIONAL
	userNote = <System.String>
}"
            );
        }

    } // class Invoke-RscGqlMutateBulkOnDemandSnapshotNutanixVm
}