// Invoke-RscGqlMutateAssignRetentionSLAToSnapshots.cs
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
    /// Invoke GraphQL Mutation assignRetentionSLAToSnapshots
    /// assignRetentionSLAToSnapshots(
    ///     globalSlaOptionalFid: UUID
    ///     globalSlaAssignType: SlaAssignTypeEnum!
    ///     snapshotFids: [UUID!]!
    ///     userNote: String
    ///   ): SlaAssignResult!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "Invoke",
        "RscGqlMutateAssignRetentionSLAToSnapshots")
    ]
    public class Invoke_RscGqlMutateAssignRetentionSLAToSnapshots : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the Invoke-RscGqlQuery* cmdlets
        // fit in the Invoke-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("assignRetentionSLAToSnapshots");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Invoke GraphQL Mutation assignRetentionSLAToSnapshots
        /// assignRetentionSLAToSnapshots(
        ///     globalSlaOptionalFid: UUID
        ///     globalSlaAssignType: SlaAssignTypeEnum!
        ///     snapshotFids: [UUID!]!
        ///     userNote: String
        ///   ): SlaAssignResult!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_assignRetentionSLAToSnapshots();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_assignRetentionSLAToSnapshots()
        {
            this._logger.name += " -assignRetentionSLAToSnapshots";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("globalSlaOptionalFid", "UUID"),
                Tuple.Create("globalSlaAssignType", "SlaAssignTypeEnum!"),
                Tuple.Create("snapshotFids", "[UUID!]!"),
                Tuple.Create("userNote", "String"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationAssignRetentionSlaToSnapshots",
                "($globalSlaOptionalFid: UUID,$globalSlaAssignType: SlaAssignTypeEnum!,$snapshotFids: [UUID!]!,$userNote: String)",
                "SlaAssignResult",
                Mutation.AssignRetentionSlaToSnapshots_ObjectFieldSpec,
                Mutation.AssignRetentionSlaToSnapshotsFieldSpec,
                @"# OPTIONAL
$inputs.Var.globalSlaOptionalFid = <System.String>
# REQUIRED
$inputs.Var.globalSlaAssignType = <SlaAssignTypeEnum> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SlaAssignTypeEnum]) for enum values.
# REQUIRED
$inputs.Var.snapshotFids = @(
	<System.String>
)
# OPTIONAL
$inputs.Var.userNote = <System.String>"
            );
        }

    } // class Invoke-RscGqlMutateAssignRetentionSLAToSnapshots
}