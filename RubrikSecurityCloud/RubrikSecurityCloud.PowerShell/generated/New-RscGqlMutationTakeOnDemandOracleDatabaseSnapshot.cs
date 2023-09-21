// New-RscGqlMutationTakeOnDemandOracleDatabaseSnapshot.cs
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
    /// Create new GraphQL Mutation takeOnDemandOracleDatabaseSnapshot
    /// takeOnDemandOracleDatabaseSnapshot(input: TakeOnDemandOracleDatabaseSnapshotInput!): AsyncRequestStatus!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlMutationTakeOnDemandOracleDatabaseSnapshot")
    ]
    public class New_RscGqlMutationTakeOnDemandOracleDatabaseSnapshot : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("takeOnDemandOracleDatabaseSnapshot");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Mutation takeOnDemandOracleDatabaseSnapshot
        /// takeOnDemandOracleDatabaseSnapshot(input: TakeOnDemandOracleDatabaseSnapshotInput!): AsyncRequestStatus!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_takeOnDemandOracleDatabaseSnapshot();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_takeOnDemandOracleDatabaseSnapshot()
        {
            this._logger.name += " -takeOnDemandOracleDatabaseSnapshot";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "TakeOnDemandOracleDatabaseSnapshotInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationTakeOnDemandOracleDatabaseSnapshot",
                "($input: TakeOnDemandOracleDatabaseSnapshotInput!)",
                "AsyncRequestStatus",
                Mutation.TakeOnDemandOracleDatabaseSnapshot_ObjectFieldSpec,
                Mutation.TakeOnDemandOracleDatabaseSnapshotFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	config = @{
		# OPTIONAL
		forceFullSnapshot = <System.Boolean>
		# OPTIONAL
		baseOnDemandSnapshotConfig = @{
			# OPTIONAL
			slaId = <System.String>
		}
	}
	# REQUIRED
	id = <System.String>
	# OPTIONAL
	userNote = <System.String>
}"
            );
        }

    } // class New-RscGqlMutationTakeOnDemandOracleDatabaseSnapshot
}