// New-RscGqlMutationRegisterHypervScvmm.cs
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
    /// Create new GraphQL Mutation registerHypervScvmm
    /// registerHypervScvmm(input: RegisterHypervScvmmInput!): AsyncRequestStatus!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlMutationRegisterHypervScvmm")
    ]
    public class New_RscGqlMutationRegisterHypervScvmm : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("registerHypervScvmm");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Mutation registerHypervScvmm
        /// registerHypervScvmm(input: RegisterHypervScvmmInput!): AsyncRequestStatus!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_registerHypervScvmm();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_registerHypervScvmm()
        {
            this._logger.name += " -registerHypervScvmm";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "RegisterHypervScvmmInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationRegisterHypervScvmm",
                "($input: RegisterHypervScvmmInput!)",
                "AsyncRequestStatus",
                Mutation.RegisterHypervScvmm_ObjectFieldSpec,
                Mutation.RegisterHypervScvmmFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	clusterUuid = <System.String>
	# REQUIRED
	scvmm = @{
		# REQUIRED
		hostname = <System.String>
		# REQUIRED
		runAsAccount = <System.String>
		# REQUIRED
		shouldDeployAgent = <System.Boolean>
	}
}"
            );
        }

    } // class New-RscGqlMutationRegisterHypervScvmm
}