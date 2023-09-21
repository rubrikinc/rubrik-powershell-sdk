// New-RscGqlMutationInstantRecoverOracleSnapshot.cs
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
    /// Create new GraphQL Mutation instantRecoverOracleSnapshot
    /// instantRecoverOracleSnapshot(input: InstantRecoverOracleSnapshotInput!): AsyncRequestStatus!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlMutationInstantRecoverOracleSnapshot")
    ]
    public class New_RscGqlMutationInstantRecoverOracleSnapshot : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("instantRecoverOracleSnapshot");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Mutation instantRecoverOracleSnapshot
        /// instantRecoverOracleSnapshot(input: InstantRecoverOracleSnapshotInput!): AsyncRequestStatus!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_instantRecoverOracleSnapshot();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_instantRecoverOracleSnapshot()
        {
            this._logger.name += " -instantRecoverOracleSnapshot";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "InstantRecoverOracleSnapshotInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationInstantRecoverOracleSnapshot",
                "($input: InstantRecoverOracleSnapshotInput!)",
                "AsyncRequestStatus",
                Mutation.InstantRecoverOracleSnapshot_ObjectFieldSpec,
                Mutation.InstantRecoverOracleSnapshotFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	config = @{
		# OPTIONAL
		numChannels = <System.Int32>
		# REQUIRED
		recoveryPoint = @{
			# OPTIONAL
			snapshotId = <System.String>
			# OPTIONAL
			timestampMs = <System.Int64>
		}
	}
	# REQUIRED
	id = <System.String>
}"
            );
        }

    } // class New-RscGqlMutationInstantRecoverOracleSnapshot
}