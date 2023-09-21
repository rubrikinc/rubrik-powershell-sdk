// New-RscGqlMutationVsphereVmBatchInPlaceRecovery.cs
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
    /// Create new GraphQL Mutation vsphereVmBatchInPlaceRecovery
    /// vsphereVmBatchInPlaceRecovery(input: VsphereVmBatchInPlaceRecoveryInput!): BatchAsyncRequestStatus!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlMutationVsphereVmBatchInPlaceRecovery")
    ]
    public class New_RscGqlMutationVsphereVmBatchInPlaceRecovery : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("vsphereVmBatchInPlaceRecovery");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Mutation vsphereVmBatchInPlaceRecovery
        /// vsphereVmBatchInPlaceRecovery(input: VsphereVmBatchInPlaceRecoveryInput!): BatchAsyncRequestStatus!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_vsphereVmBatchInPlaceRecovery();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_vsphereVmBatchInPlaceRecovery()
        {
            this._logger.name += " -vsphereVmBatchInPlaceRecovery";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "VsphereVmBatchInPlaceRecoveryInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationVsphereVmBatchInPlaceRecovery",
                "($input: VsphereVmBatchInPlaceRecoveryInput!)",
                "BatchAsyncRequestStatus",
                Mutation.VsphereVmBatchInPlaceRecovery_ObjectFieldSpec,
                Mutation.VsphereVmBatchInPlaceRecoveryFieldSpec,
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
				config = @{
					# OPTIONAL
					shouldKeepVsphereSnapshotAfterRecovery = <System.Boolean>
					# OPTIONAL
					requiredRecoveryParameters = @{
						# OPTIONAL
						recoveryPoint = <DateTime>
						# OPTIONAL
						snapshotId = <System.String>
					}
				}
				# REQUIRED
				vmId = <System.String>
			}
		)
	}
}"
            );
        }

    } // class New-RscGqlMutationVsphereVmBatchInPlaceRecovery
}