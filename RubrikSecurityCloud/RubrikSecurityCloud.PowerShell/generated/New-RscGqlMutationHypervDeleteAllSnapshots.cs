// New-RscGqlMutationHypervDeleteAllSnapshots.cs
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
    /// Create new GraphQL Mutation hypervDeleteAllSnapshots
    /// hypervDeleteAllSnapshots(input: HypervDeleteAllSnapshotsInput!): RequestSuccess!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlMutationHypervDeleteAllSnapshots")
    ]
    public class New_RscGqlMutationHypervDeleteAllSnapshots : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("hypervDeleteAllSnapshots");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Mutation hypervDeleteAllSnapshots
        /// hypervDeleteAllSnapshots(input: HypervDeleteAllSnapshotsInput!): RequestSuccess!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_hypervDeleteAllSnapshots();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_hypervDeleteAllSnapshots()
        {
            this._logger.name += " -hypervDeleteAllSnapshots";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "HypervDeleteAllSnapshotsInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationHypervDeleteAllSnapshots",
                "($input: HypervDeleteAllSnapshotsInput!)",
                "RequestSuccess",
                Mutation.HypervDeleteAllSnapshots_ObjectFieldSpec,
                Mutation.HypervDeleteAllSnapshotsFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
}"
            );
        }

    } // class New-RscGqlMutationHypervDeleteAllSnapshots
}