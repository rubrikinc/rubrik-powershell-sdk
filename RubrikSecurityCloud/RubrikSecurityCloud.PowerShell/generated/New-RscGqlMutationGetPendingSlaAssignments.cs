// New-RscGqlMutationGetPendingSlaAssignments.cs
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
    /// Create new GraphQL Mutation getPendingSlaAssignments
    /// getPendingSlaAssignments(input: GetPendingSlaAssignmentsInput!): GetPendingSlaAssignmentsReply!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlMutationGetPendingSlaAssignments")
    ]
    public class New_RscGqlMutationGetPendingSlaAssignments : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("getPendingSlaAssignments");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Mutation getPendingSlaAssignments
        /// getPendingSlaAssignments(input: GetPendingSlaAssignmentsInput!): GetPendingSlaAssignmentsReply!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_getPendingSlaAssignments();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_getPendingSlaAssignments()
        {
            this._logger.name += " -getPendingSlaAssignments";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetPendingSlaAssignmentsInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationGetPendingSlaAssignments",
                "($input: GetPendingSlaAssignmentsInput!)",
                "GetPendingSlaAssignmentsReply",
                Mutation.GetPendingSlaAssignments_ObjectFieldSpec,
                Mutation.GetPendingSlaAssignmentsFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	pendingAssignmentsRequest = @{
		# REQUIRED
		objectIds = @(
			<System.String>
		)
	}
}"
            );
        }

    } // class New-RscGqlMutationGetPendingSlaAssignments
}