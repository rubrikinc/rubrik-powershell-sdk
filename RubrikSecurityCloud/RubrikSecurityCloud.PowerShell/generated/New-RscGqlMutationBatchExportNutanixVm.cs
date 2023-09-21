// New-RscGqlMutationBatchExportNutanixVm.cs
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
    /// Create new GraphQL Mutation batchExportNutanixVm
    /// batchExportNutanixVm(input: BatchExportNutanixVmInput!): BatchExportNutanixVmReply!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlMutationBatchExportNutanixVm")
    ]
    public class New_RscGqlMutationBatchExportNutanixVm : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("batchExportNutanixVm");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Mutation batchExportNutanixVm
        /// batchExportNutanixVm(input: BatchExportNutanixVmInput!): BatchExportNutanixVmReply!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_batchExportNutanixVm();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_batchExportNutanixVm()
        {
            this._logger.name += " -batchExportNutanixVm";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "BatchExportNutanixVmInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationBatchExportNutanixVm",
                "($input: BatchExportNutanixVmInput!)",
                "BatchExportNutanixVmReply",
                Mutation.BatchExportNutanixVm_ObjectFieldSpec,
                Mutation.BatchExportNutanixVmFieldSpec,
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
				exportConfig = @{
					# OPTIONAL
					nutanixClusterId = <System.String>
					# OPTIONAL
					powerOn = <System.Boolean>
					# OPTIONAL
					removeNetworkDevices = <System.Boolean>
					# OPTIONAL
					vmName = <System.String>
					# OPTIONAL
					keepMacAddresses = <System.Boolean>
					# OPTIONAL
					nicNetworkUuids = @(
						<System.String>
					)
					# REQUIRED
					containerNaturalId = <System.String>
				}
				# REQUIRED
				vmId = <System.String>
			}
		)
	}
}"
            );
        }

    } // class New-RscGqlMutationBatchExportNutanixVm
}