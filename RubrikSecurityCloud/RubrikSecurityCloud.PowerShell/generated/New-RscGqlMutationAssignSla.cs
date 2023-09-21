// New-RscGqlMutationAssignSla.cs
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
    /// Create new GraphQL Mutation assignSla
    /// assignSla(input: AssignSlaInput!): SlaAssignResult!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlMutationAssignSla")
    ]
    public class New_RscGqlMutationAssignSla : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("assignSla");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Mutation assignSla
        /// assignSla(input: AssignSlaInput!): SlaAssignResult!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_assignSla();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_assignSla()
        {
            this._logger.name += " -assignSla";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "AssignSlaInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationAssignSla",
                "($input: AssignSlaInput!)",
                "SlaAssignResult",
                Mutation.AssignSla_ObjectFieldSpec,
                Mutation.AssignSlaFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	slaDomainAssignType = <SlaAssignTypeEnum> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SlaAssignTypeEnum]) for enum values.
	# OPTIONAL
	slaOptionalId = <System.String>
	# REQUIRED
	objectIds = @(
		<System.String>
	)
	# OPTIONAL
	applicableWorkloadType = <WorkloadLevelHierarchy> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.WorkloadLevelHierarchy]) for enum values.
	# OPTIONAL
	shouldApplyToExistingSnapshots = <System.Boolean>
	# OPTIONAL
	shouldApplyToNonPolicySnapshots = <System.Boolean>
	# OPTIONAL
	existingSnapshotRetention = <GlobalExistingSnapshotRetention> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.GlobalExistingSnapshotRetention]) for enum values.
	# OPTIONAL
	userNote = <System.String>
}"
            );
        }

    } // class New-RscGqlMutationAssignSla
}