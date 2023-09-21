// New-RscGqlMutationRegisterAgentNutanixVm.cs
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
    /// Create new GraphQL Mutation registerAgentNutanixVm
    /// registerAgentNutanixVm(input: RegisterAgentNutanixVmInput!): RequestSuccess!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlMutationRegisterAgentNutanixVm")
    ]
    public class New_RscGqlMutationRegisterAgentNutanixVm : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("registerAgentNutanixVm");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Mutation registerAgentNutanixVm
        /// registerAgentNutanixVm(input: RegisterAgentNutanixVmInput!): RequestSuccess!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_registerAgentNutanixVm();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_registerAgentNutanixVm()
        {
            this._logger.name += " -registerAgentNutanixVm";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "RegisterAgentNutanixVmInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationRegisterAgentNutanixVm",
                "($input: RegisterAgentNutanixVmInput!)",
                "RequestSuccess",
                Mutation.RegisterAgentNutanixVm_ObjectFieldSpec,
                Mutation.RegisterAgentNutanixVmFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
}"
            );
        }

    } // class New-RscGqlMutationRegisterAgentNutanixVm
}