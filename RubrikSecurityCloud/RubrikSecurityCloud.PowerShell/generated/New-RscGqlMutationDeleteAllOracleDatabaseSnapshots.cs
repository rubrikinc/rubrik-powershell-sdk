// New-RscGqlMutationDeleteAllOracleDatabaseSnapshots.cs
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
    /// Create new GraphQL Mutation deleteAllOracleDatabaseSnapshots
    /// deleteAllOracleDatabaseSnapshots(input: DeleteAllOracleDatabaseSnapshotsInput!): Void
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlMutationDeleteAllOracleDatabaseSnapshots")
    ]
    public class New_RscGqlMutationDeleteAllOracleDatabaseSnapshots : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("deleteAllOracleDatabaseSnapshots");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Mutation deleteAllOracleDatabaseSnapshots
        /// deleteAllOracleDatabaseSnapshots(input: DeleteAllOracleDatabaseSnapshotsInput!): Void
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_deleteAllOracleDatabaseSnapshots();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_deleteAllOracleDatabaseSnapshots()
        {
            this._logger.name += " -deleteAllOracleDatabaseSnapshots";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteAllOracleDatabaseSnapshotsInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDeleteAllOracleDatabaseSnapshots",
                "($input: DeleteAllOracleDatabaseSnapshotsInput!)",
                "System.String",
                Mutation.DeleteAllOracleDatabaseSnapshots_ObjectFieldSpec,
                Mutation.DeleteAllOracleDatabaseSnapshotsFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
}"
            );
        }

    } // class New-RscGqlMutationDeleteAllOracleDatabaseSnapshots
}