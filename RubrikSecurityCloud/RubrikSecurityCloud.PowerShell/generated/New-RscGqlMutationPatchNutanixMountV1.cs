// New-RscGqlMutationPatchNutanixMountV1.cs
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
    /// Create new GraphQL Mutation patchNutanixMountV1
    /// patchNutanixMountV1(input: PatchNutanixMountV1Input!): PatchNutanixMountV1Reply!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlMutationPatchNutanixMountV1")
    ]
    public class New_RscGqlMutationPatchNutanixMountV1 : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("patchNutanixMountV1");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Mutation patchNutanixMountV1
        /// patchNutanixMountV1(input: PatchNutanixMountV1Input!): PatchNutanixMountV1Reply!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_patchNutanixMountV1();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_patchNutanixMountV1()
        {
            this._logger.name += " -patchNutanixMountV1";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "PatchNutanixMountV1Input!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationPatchNutanixMountV1",
                "($input: PatchNutanixMountV1Input!)",
                "PatchNutanixMountV1Reply",
                Mutation.PatchNutanixMountV1_ObjectFieldSpec,
                Mutation.PatchNutanixMountV1FieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	config = @{
		# REQUIRED
		shouldPowerOn = <System.Boolean>
	}
	# REQUIRED
	id = <System.String>
}"
            );
        }

    } // class New-RscGqlMutationPatchNutanixMountV1
}