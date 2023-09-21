// New-RscGqlMutationVsphereVmRegisterAgent.cs
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
    /// Create new GraphQL Mutation vsphereVmRegisterAgent
    /// vsphereVmRegisterAgent(input: VsphereVmRegisterAgentInput!): RequestSuccess!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlMutationVsphereVmRegisterAgent")
    ]
    public class New_RscGqlMutationVsphereVmRegisterAgent : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("vsphereVmRegisterAgent");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Mutation vsphereVmRegisterAgent
        /// vsphereVmRegisterAgent(input: VsphereVmRegisterAgentInput!): RequestSuccess!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_vsphereVmRegisterAgent();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_vsphereVmRegisterAgent()
        {
            this._logger.name += " -vsphereVmRegisterAgent";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "VsphereVmRegisterAgentInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationVsphereVmRegisterAgent",
                "($input: VsphereVmRegisterAgentInput!)",
                "RequestSuccess",
                Mutation.VsphereVmRegisterAgent_ObjectFieldSpec,
                Mutation.VsphereVmRegisterAgentFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
}"
            );
        }

    } // class New-RscGqlMutationVsphereVmRegisterAgent
}