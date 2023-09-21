// New-RscGqlMutationPauseSla.cs
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
    /// Create new GraphQL Mutation pauseSla
    /// pauseSla(input: PauseSlaInput!): PauseSlaReply!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlMutationPauseSla")
    ]
    public class New_RscGqlMutationPauseSla : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("pauseSla");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Mutation pauseSla
        /// pauseSla(input: PauseSlaInput!): PauseSlaReply!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_pauseSla();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_pauseSla()
        {
            this._logger.name += " -pauseSla";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "PauseSlaInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationPauseSla",
                "($input: PauseSlaInput!)",
                "PauseSlaReply",
                Mutation.PauseSla_ObjectFieldSpec,
                Mutation.PauseSlaFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	slaId = <System.String>
	# REQUIRED
	clusterUuids = @(
		<System.String>
	)
	# REQUIRED
	pauseSla = <System.Boolean>
}"
            );
        }

    } // class New-RscGqlMutationPauseSla
}