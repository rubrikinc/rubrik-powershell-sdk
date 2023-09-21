// New-RscGqlMutationBatchInstantRecoverHypervVm.cs
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
    /// Create new GraphQL Mutation batchInstantRecoverHypervVm
    /// batchInstantRecoverHypervVm(input: BatchInstantRecoverHypervVmInput!): BatchInstantRecoverHypervVmReply!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlMutationBatchInstantRecoverHypervVm")
    ]
    public class New_RscGqlMutationBatchInstantRecoverHypervVm : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("batchInstantRecoverHypervVm");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Mutation batchInstantRecoverHypervVm
        /// batchInstantRecoverHypervVm(input: BatchInstantRecoverHypervVmInput!): BatchInstantRecoverHypervVmReply!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_batchInstantRecoverHypervVm();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_batchInstantRecoverHypervVm()
        {
            this._logger.name += " -batchInstantRecoverHypervVm";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "BatchInstantRecoverHypervVmInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationBatchInstantRecoverHypervVm",
                "($input: BatchInstantRecoverHypervVmInput!)",
                "BatchInstantRecoverHypervVmReply",
                Mutation.BatchInstantRecoverHypervVm_ObjectFieldSpec,
                Mutation.BatchInstantRecoverHypervVmFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	clusterUuid = <System.String>
	# REQUIRED
	config = @{
		# REQUIRED
		snapshots = @(
			@{
				# OPTIONAL
				snapshotAfterDate = <DateTime>
				# OPTIONAL
				snapshotBeforeDate = <DateTime>
				# OPTIONAL
				snapshotId = <System.String>
				# REQUIRED
				instantRecoveryConfig = @{
					# OPTIONAL
					hostId = <System.String>
					# OPTIONAL
					vmName = <System.String>
				}
				# REQUIRED
				vmId = <System.String>
			}
		)
	}
}"
            );
        }

    } // class New-RscGqlMutationBatchInstantRecoverHypervVm
}