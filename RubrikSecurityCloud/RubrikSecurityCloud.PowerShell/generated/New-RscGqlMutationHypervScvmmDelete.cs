// New-RscGqlMutationHypervScvmmDelete.cs
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
    /// Create new GraphQL Mutation hypervScvmmDelete
    /// hypervScvmmDelete(input: HypervScvmmDeleteInput!): ResponseSuccess!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlMutationHypervScvmmDelete")
    ]
    public class New_RscGqlMutationHypervScvmmDelete : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("hypervScvmmDelete");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Mutation hypervScvmmDelete
        /// hypervScvmmDelete(input: HypervScvmmDeleteInput!): ResponseSuccess!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_hypervScvmmDelete();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_hypervScvmmDelete()
        {
            this._logger.name += " -hypervScvmmDelete";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "HypervScvmmDeleteInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationHypervScvmmDelete",
                "($input: HypervScvmmDeleteInput!)",
                "ResponseSuccess",
                Mutation.HypervScvmmDelete_ObjectFieldSpec,
                Mutation.HypervScvmmDeleteFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
}"
            );
        }

    } // class New-RscGqlMutationHypervScvmmDelete
}