// New-RscGqlMutationBatchMountHypervVm.cs
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
    /// Create new GraphQL Mutation batchMountHypervVm
    /// batchMountHypervVm(input: BatchMountHypervVmInput!): BatchMountHypervVmReply!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlMutationBatchMountHypervVm")
    ]
    public class New_RscGqlMutationBatchMountHypervVm : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("batchMountHypervVm");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Mutation batchMountHypervVm
        /// batchMountHypervVm(input: BatchMountHypervVmInput!): BatchMountHypervVmReply!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_batchMountHypervVm();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_batchMountHypervVm()
        {
            this._logger.name += " -batchMountHypervVm";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "BatchMountHypervVmInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationBatchMountHypervVm",
                "($input: BatchMountHypervVmInput!)",
                "BatchMountHypervVmReply",
                Mutation.BatchMountHypervVm_ObjectFieldSpec,
                Mutation.BatchMountHypervVmFieldSpec,
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
				# OPTIONAL
				vmNamePrefix = <System.String>
				# REQUIRED
				mountConfig = @{
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
				vmId = <System.String>
			}
		)
	}
}"
            );
        }

    } // class New-RscGqlMutationBatchMountHypervVm
}