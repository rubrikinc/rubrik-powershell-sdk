// Invoke-RscGqlMutateCreateVsphereVcenter.cs
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
    /// Invoke GraphQL Mutation createVsphereVcenter
    /// createVsphereVcenter(input: CreateVsphereVcenterInput!): CreateVsphereVcenterReply!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "Invoke",
        "RscGqlMutateCreateVsphereVcenter")
    ]
    public class Invoke_RscGqlMutateCreateVsphereVcenter : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the Invoke-RscGqlQuery* cmdlets
        // fit in the Invoke-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("createVsphereVcenter");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Invoke GraphQL Mutation createVsphereVcenter
        /// createVsphereVcenter(input: CreateVsphereVcenterInput!): CreateVsphereVcenterReply!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_createVsphereVcenter();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_createVsphereVcenter()
        {
            this._logger.name += " -createVsphereVcenter";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateVsphereVcenterInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateVsphereVcenter",
                "($input: CreateVsphereVcenterInput!)",
                "CreateVsphereVcenterReply",
                Mutation.CreateVsphereVcenter_ObjectFieldSpec,
                Mutation.CreateVsphereVcenterFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	clusterUuid = <System.String>
	# REQUIRED
	vcenterDetail = @{
		# OPTIONAL
		caCerts = <System.String>
		# OPTIONAL
		computeVisibilityFilter = @(
			@{
				# OPTIONAL
				isVmwareMetroStorageCluster = <System.Boolean>
				# REQUIRED
				hostGroupFilter = @(
					<System.String>
				)
				# REQUIRED
				id = <System.String>
			}
		)
		# OPTIONAL
		shouldEnableHotAddProxyForOnPrem = <System.Boolean>
		# OPTIONAL
		orgNetworkId = <System.String>
		# OPTIONAL
		conflictResolutionAuthz = <VcenterConfigV2ConflictResolutionAuthz> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.VcenterConfigV2ConflictResolutionAuthz]) for enum values.
		# REQUIRED
		hostname = <System.String>
		# REQUIRED
		password = <System.String>
		# REQUIRED
		username = <System.String>
	}
}"
            );
        }

    } // class Invoke-RscGqlMutateCreateVsphereVcenter
}