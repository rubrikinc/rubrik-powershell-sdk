// New-RscGqlMutationPatchDb2Instance.cs
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
    /// Create new GraphQL Mutation patchDb2Instance
    /// patchDb2Instance(input: PatchDb2InstanceInput!): PatchDb2InstanceReply!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlMutationPatchDb2Instance")
    ]
    public class New_RscGqlMutationPatchDb2Instance : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("patchDb2Instance");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Mutation patchDb2Instance
        /// patchDb2Instance(input: PatchDb2InstanceInput!): PatchDb2InstanceReply!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_patchDb2Instance();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_patchDb2Instance()
        {
            this._logger.name += " -patchDb2Instance";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "PatchDb2InstanceInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationPatchDb2Instance",
                "($input: PatchDb2InstanceInput!)",
                "PatchDb2InstanceReply",
                Mutation.PatchDb2Instance_ObjectFieldSpec,
                Mutation.PatchDb2InstanceFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	db2InstanceRequestConfig = @{
		# OPTIONAL
		hostIds = @(
			<System.String>
		)
		# OPTIONAL
		password = <System.String>
		# OPTIONAL
		username = <System.String>
		# OPTIONAL
		instanceName = <System.String>
	}
	# REQUIRED
	id = <System.String>
}"
            );
        }

    } // class New-RscGqlMutationPatchDb2Instance
}