// New-RscGqlMutationAssignRetentionSLAToSnappables.cs
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
    /// Create new GraphQL Mutation assignRetentionSLAToSnappables
    /// assignRetentionSLAToSnappables(
    ///     globalSlaOptionalFid: UUID
    ///     globalSlaAssignType: SlaAssignTypeEnum!
    ///     objectIds: [UUID!]!
    ///     applicableSnappableType: WorkloadLevelHierarchy
    ///     shouldApplyToNonPolicySnapshots: Boolean
    ///     userNote: String
    ///   ): SlaAssignResult!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlMutationAssignRetentionSLAToSnappables")
    ]
    public class New_RscGqlMutationAssignRetentionSLAToSnappables : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("assignRetentionSLAToSnappables");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Mutation assignRetentionSLAToSnappables
        /// assignRetentionSLAToSnappables(
        ///     globalSlaOptionalFid: UUID
        ///     globalSlaAssignType: SlaAssignTypeEnum!
        ///     objectIds: [UUID!]!
        ///     applicableSnappableType: WorkloadLevelHierarchy
        ///     shouldApplyToNonPolicySnapshots: Boolean
        ///     userNote: String
        ///   ): SlaAssignResult!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_assignRetentionSLAToSnappables();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_assignRetentionSLAToSnappables()
        {
            this._logger.name += " -assignRetentionSLAToSnappables";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("globalSlaOptionalFid", "UUID"),
                Tuple.Create("globalSlaAssignType", "SlaAssignTypeEnum!"),
                Tuple.Create("objectIds", "[UUID!]!"),
                Tuple.Create("applicableSnappableType", "WorkloadLevelHierarchy"),
                Tuple.Create("shouldApplyToNonPolicySnapshots", "Boolean"),
                Tuple.Create("userNote", "String"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationAssignRetentionSlaToSnappables",
                "($globalSlaOptionalFid: UUID,$globalSlaAssignType: SlaAssignTypeEnum!,$objectIds: [UUID!]!,$applicableSnappableType: WorkloadLevelHierarchy,$shouldApplyToNonPolicySnapshots: Boolean,$userNote: String)",
                "SlaAssignResult",
                Mutation.AssignRetentionSlaToSnappables_ObjectFieldSpec,
                Mutation.AssignRetentionSlaToSnappablesFieldSpec,
                @"# OPTIONAL
$inputs.Var.globalSlaOptionalFid = <System.String>
# REQUIRED
$inputs.Var.globalSlaAssignType = <SlaAssignTypeEnum> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SlaAssignTypeEnum]) for enum values.
# REQUIRED
$inputs.Var.objectIds = @(
	<System.String>
)
# OPTIONAL
$inputs.Var.applicableSnappableType = <WorkloadLevelHierarchy> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.WorkloadLevelHierarchy]) for enum values.
# OPTIONAL
$inputs.Var.shouldApplyToNonPolicySnapshots = <System.Boolean>
# OPTIONAL
$inputs.Var.userNote = <System.String>"
            );
        }

    } // class New-RscGqlMutationAssignRetentionSLAToSnappables
}