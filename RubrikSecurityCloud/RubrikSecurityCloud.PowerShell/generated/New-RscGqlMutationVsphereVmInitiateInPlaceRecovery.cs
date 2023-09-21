// New-RscGqlMutationVsphereVmInitiateInPlaceRecovery.cs
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
    /// Create new GraphQL Mutation vsphereVmInitiateInPlaceRecovery
    /// vsphereVmInitiateInPlaceRecovery(input: VsphereVmInitiateInPlaceRecoveryInput!): AsyncRequestStatus!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlMutationVsphereVmInitiateInPlaceRecovery")
    ]
    public class New_RscGqlMutationVsphereVmInitiateInPlaceRecovery : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("vsphereVmInitiateInPlaceRecovery");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Mutation vsphereVmInitiateInPlaceRecovery
        /// vsphereVmInitiateInPlaceRecovery(input: VsphereVmInitiateInPlaceRecoveryInput!): AsyncRequestStatus!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_vsphereVmInitiateInPlaceRecovery();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_vsphereVmInitiateInPlaceRecovery()
        {
            this._logger.name += " -vsphereVmInitiateInPlaceRecovery";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "VsphereVmInitiateInPlaceRecoveryInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationVsphereVmInitiateInPlaceRecovery",
                "($input: VsphereVmInitiateInPlaceRecoveryInput!)",
                "AsyncRequestStatus",
                Mutation.VsphereVmInitiateInPlaceRecovery_ObjectFieldSpec,
                Mutation.VsphereVmInitiateInPlaceRecoveryFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
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
	id = <System.String>
}"
            );
        }

    } // class New-RscGqlMutationVsphereVmInitiateInPlaceRecovery
}