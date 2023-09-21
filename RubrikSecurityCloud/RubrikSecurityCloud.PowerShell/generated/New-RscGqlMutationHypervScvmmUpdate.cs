// New-RscGqlMutationHypervScvmmUpdate.cs
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
    /// Create new GraphQL Mutation hypervScvmmUpdate
    /// hypervScvmmUpdate(input: HypervScvmmUpdateInput!): HypervScvmmUpdateReply!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlMutationHypervScvmmUpdate")
    ]
    public class New_RscGqlMutationHypervScvmmUpdate : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("hypervScvmmUpdate");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Mutation hypervScvmmUpdate
        /// hypervScvmmUpdate(input: HypervScvmmUpdateInput!): HypervScvmmUpdateReply!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_hypervScvmmUpdate();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_hypervScvmmUpdate()
        {
            this._logger.name += " -hypervScvmmUpdate";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "HypervScvmmUpdateInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationHypervScvmmUpdate",
                "($input: HypervScvmmUpdateInput!)",
                "HypervScvmmUpdateReply",
                Mutation.HypervScvmmUpdate_ObjectFieldSpec,
                Mutation.HypervScvmmUpdateFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
	# REQUIRED
	updateProperties = @{
		# OPTIONAL
		configuredSlaDomainId = <System.String>
		# OPTIONAL
		hostname = <System.String>
		# OPTIONAL
		runAsAccount = <System.String>
		# OPTIONAL
		shouldDeployAgent = <System.Boolean>
	}
}"
            );
        }

    } // class New-RscGqlMutationHypervScvmmUpdate
}