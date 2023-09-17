// Invoke-RscGqlMutateBatchMountNutanixVm.cs
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
    /// Invoke GraphQL Mutation batchMountNutanixVm
    /// batchMountNutanixVm(input: BatchMountNutanixVmInput!): BatchMountNutanixVmReply!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "Invoke",
        "RscGqlMutateBatchMountNutanixVm")
    ]
    public class Invoke_RscGqlMutateBatchMountNutanixVm : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the Invoke-RscGqlQuery* cmdlets
        // fit in the Invoke-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("batchMountNutanixVm");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Invoke GraphQL Mutation batchMountNutanixVm
        /// batchMountNutanixVm(input: BatchMountNutanixVmInput!): BatchMountNutanixVmReply!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_batchMountNutanixVm();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_batchMountNutanixVm()
        {
            this._logger.name += " -batchMountNutanixVm";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "BatchMountNutanixVmInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationBatchMountNutanixVm",
                "($input: BatchMountNutanixVmInput!)",
                "BatchMountNutanixVmReply",
                Mutation.BatchMountNutanixVm_ObjectFieldSpec,
                Mutation.BatchMountNutanixVmFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
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
					containerNaturalId = <System.String>
					# OPTIONAL
					nutanixClusterId = <System.String>
					# OPTIONAL
					shouldMigrateImmediately = <System.Boolean>
					# OPTIONAL
					shouldPowerOn = <System.Boolean>
					# OPTIONAL
					shouldRemoveNetwork = <System.Boolean>
					# OPTIONAL
					targetNetwork = <System.String>
					# OPTIONAL
					vmName = <System.String>
					# OPTIONAL
					keepMacAddresses = <System.Boolean>
					# OPTIONAL
					nicNetworkUuids = @(
						<System.String>
					)
					# REQUIRED
					shouldDisableMigration = <System.Boolean>
				}
				# REQUIRED
				vmId = <System.String>
			}
		)
	}
}"
            );
        }

    } // class Invoke-RscGqlMutateBatchMountNutanixVm
}