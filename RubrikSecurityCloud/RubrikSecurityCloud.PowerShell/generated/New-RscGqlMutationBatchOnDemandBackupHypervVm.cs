// New-RscGqlMutationBatchOnDemandBackupHypervVm.cs
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
    /// Create new GraphQL Mutation batchOnDemandBackupHypervVm
    /// batchOnDemandBackupHypervVm(input: BatchOnDemandBackupHypervVmInput!): BatchOnDemandBackupHypervVmReply!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlMutationBatchOnDemandBackupHypervVm")
    ]
    public class New_RscGqlMutationBatchOnDemandBackupHypervVm : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("batchOnDemandBackupHypervVm");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Mutation batchOnDemandBackupHypervVm
        /// batchOnDemandBackupHypervVm(input: BatchOnDemandBackupHypervVmInput!): BatchOnDemandBackupHypervVmReply!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_batchOnDemandBackupHypervVm();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_batchOnDemandBackupHypervVm()
        {
            this._logger.name += " -batchOnDemandBackupHypervVm";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "BatchOnDemandBackupHypervVmInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationBatchOnDemandBackupHypervVm",
                "($input: BatchOnDemandBackupHypervVmInput!)",
                "BatchOnDemandBackupHypervVmReply",
                Mutation.BatchOnDemandBackupHypervVm_ObjectFieldSpec,
                Mutation.BatchOnDemandBackupHypervVmFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# OPTIONAL
	userNote = <System.String>
	# REQUIRED
	config = @{
		# REQUIRED
		vms = @(
			@{
				# OPTIONAL
				backupConfig = @{
					# OPTIONAL
					slaId = <System.String>
				}
				# OPTIONAL
				vmId = <System.String>
			}
		)
	}
}"
            );
        }

    } // class New-RscGqlMutationBatchOnDemandBackupHypervVm
}