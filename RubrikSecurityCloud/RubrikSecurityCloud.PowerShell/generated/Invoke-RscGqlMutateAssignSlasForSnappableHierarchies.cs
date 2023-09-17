// Invoke-RscGqlMutateAssignSlasForSnappableHierarchies.cs
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
    /// Invoke GraphQL Mutation assignSlasForSnappableHierarchies
    /// assignSlasForSnappableHierarchies(
    ///     globalSlaOptionalFid: UUID
    ///     globalSlaAssignType: SlaAssignTypeEnum!
    ///     objectIds: [UUID!]!
    ///     applicableSnappableTypes: [WorkloadLevelHierarchy!]
    ///     shouldApplyToExistingSnapshots: Boolean
    ///     shouldApplyToNonPolicySnapshots: Boolean
    ///     globalExistingSnapshotRetention: GlobalExistingSnapshotRetention
    ///     userNote: String
    ///   ): [SlaAssignResult!]!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "Invoke",
        "RscGqlMutateAssignSlasForSnappableHierarchies")
    ]
    public class Invoke_RscGqlMutateAssignSlasForSnappableHierarchies : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the Invoke-RscGqlQuery* cmdlets
        // fit in the Invoke-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("assignSlasForSnappableHierarchies");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Invoke GraphQL Mutation assignSlasForSnappableHierarchies
        /// assignSlasForSnappableHierarchies(
        ///     globalSlaOptionalFid: UUID
        ///     globalSlaAssignType: SlaAssignTypeEnum!
        ///     objectIds: [UUID!]!
        ///     applicableSnappableTypes: [WorkloadLevelHierarchy!]
        ///     shouldApplyToExistingSnapshots: Boolean
        ///     shouldApplyToNonPolicySnapshots: Boolean
        ///     globalExistingSnapshotRetention: GlobalExistingSnapshotRetention
        ///     userNote: String
        ///   ): [SlaAssignResult!]!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_assignSlasForSnappableHierarchies();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_assignSlasForSnappableHierarchies()
        {
            this._logger.name += " -assignSlasForSnappableHierarchies";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("globalSlaOptionalFid", "UUID"),
                Tuple.Create("globalSlaAssignType", "SlaAssignTypeEnum!"),
                Tuple.Create("objectIds", "[UUID!]!"),
                Tuple.Create("applicableSnappableTypes", "[WorkloadLevelHierarchy!]"),
                Tuple.Create("shouldApplyToExistingSnapshots", "Boolean"),
                Tuple.Create("shouldApplyToNonPolicySnapshots", "Boolean"),
                Tuple.Create("globalExistingSnapshotRetention", "GlobalExistingSnapshotRetention"),
                Tuple.Create("userNote", "String"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationAssignSlasForSnappableHierarchies",
                "($globalSlaOptionalFid: UUID,$globalSlaAssignType: SlaAssignTypeEnum!,$objectIds: [UUID!]!,$applicableSnappableTypes: [WorkloadLevelHierarchy!],$shouldApplyToExistingSnapshots: Boolean,$shouldApplyToNonPolicySnapshots: Boolean,$globalExistingSnapshotRetention: GlobalExistingSnapshotRetention,$userNote: String)",
                "List<SlaAssignResult>",
                Mutation.AssignSlasForSnappableHierarchies_ObjectFieldSpec,
                Mutation.AssignSlasForSnappableHierarchiesFieldSpec,
                @"# OPTIONAL
$inputs.Var.globalSlaOptionalFid = <System.String>
# REQUIRED
$inputs.Var.globalSlaAssignType = <SlaAssignTypeEnum> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SlaAssignTypeEnum]) for enum values.
# REQUIRED
$inputs.Var.objectIds = @(
	<System.String>
)
# OPTIONAL
$inputs.Var.applicableSnappableTypes = @(
	<WorkloadLevelHierarchy> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.WorkloadLevelHierarchy]) for enum values.
)
# OPTIONAL
$inputs.Var.shouldApplyToExistingSnapshots = <System.Boolean>
# OPTIONAL
$inputs.Var.shouldApplyToNonPolicySnapshots = <System.Boolean>
# OPTIONAL
$inputs.Var.globalExistingSnapshotRetention = <GlobalExistingSnapshotRetention> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.GlobalExistingSnapshotRetention]) for enum values.
# OPTIONAL
$inputs.Var.userNote = <System.String>"
            );
        }

    } // class Invoke-RscGqlMutateAssignSlasForSnappableHierarchies
}