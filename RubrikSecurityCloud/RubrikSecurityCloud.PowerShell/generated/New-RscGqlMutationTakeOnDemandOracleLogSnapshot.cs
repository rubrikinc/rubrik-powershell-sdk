// New-RscGqlMutationTakeOnDemandOracleLogSnapshot.cs
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
    /// Create new GraphQL Mutation takeOnDemandOracleLogSnapshot
    /// takeOnDemandOracleLogSnapshot(input: TakeOnDemandOracleLogSnapshotInput!): AsyncRequestStatus!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlMutationTakeOnDemandOracleLogSnapshot")
    ]
    public class New_RscGqlMutationTakeOnDemandOracleLogSnapshot : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("takeOnDemandOracleLogSnapshot");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Mutation takeOnDemandOracleLogSnapshot
        /// takeOnDemandOracleLogSnapshot(input: TakeOnDemandOracleLogSnapshotInput!): AsyncRequestStatus!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_takeOnDemandOracleLogSnapshot();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_takeOnDemandOracleLogSnapshot()
        {
            this._logger.name += " -takeOnDemandOracleLogSnapshot";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "TakeOnDemandOracleLogSnapshotInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationTakeOnDemandOracleLogSnapshot",
                "($input: TakeOnDemandOracleLogSnapshotInput!)",
                "AsyncRequestStatus",
                Mutation.TakeOnDemandOracleLogSnapshot_ObjectFieldSpec,
                Mutation.TakeOnDemandOracleLogSnapshotFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
}"
            );
        }

    } // class New-RscGqlMutationTakeOnDemandOracleLogSnapshot
}