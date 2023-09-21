// New-RscGqlMutationPatchDb2Database.cs
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
    /// Create new GraphQL Mutation patchDb2Database
    /// patchDb2Database(input: PatchDb2DatabaseInput!): PatchDb2DatabaseReply!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlMutationPatchDb2Database")
    ]
    public class New_RscGqlMutationPatchDb2Database : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("patchDb2Database");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Mutation patchDb2Database
        /// patchDb2Database(input: PatchDb2DatabaseInput!): PatchDb2DatabaseReply!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_patchDb2Database();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_patchDb2Database()
        {
            this._logger.name += " -patchDb2Database";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "PatchDb2DatabaseInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationPatchDb2Database",
                "($input: PatchDb2DatabaseInput!)",
                "PatchDb2DatabaseReply",
                Mutation.PatchDb2Database_ObjectFieldSpec,
                Mutation.PatchDb2DatabaseFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	db2DatabaseConfig = @{
		# OPTIONAL
		backupParallelism = <System.Int32>
		# OPTIONAL
		backupSessions = <System.Int32>
	}
	# REQUIRED
	id = <System.String>
}"
            );
        }

    } // class New-RscGqlMutationPatchDb2Database
}