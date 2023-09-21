// New-RscGqlMutationCreateOraclePdbRestore.cs
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
    /// Create new GraphQL Mutation createOraclePdbRestore
    /// createOraclePdbRestore(input: CreateOraclePdbRestoreInput!): AsyncRequestStatus!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlMutationCreateOraclePdbRestore")
    ]
    public class New_RscGqlMutationCreateOraclePdbRestore : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("createOraclePdbRestore");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Mutation createOraclePdbRestore
        /// createOraclePdbRestore(input: CreateOraclePdbRestoreInput!): AsyncRequestStatus!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_createOraclePdbRestore();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_createOraclePdbRestore()
        {
            this._logger.name += " -createOraclePdbRestore";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateOraclePdbRestoreInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateOraclePdbRestore",
                "($input: CreateOraclePdbRestoreInput!)",
                "AsyncRequestStatus",
                Mutation.CreateOraclePdbRestore_ObjectFieldSpec,
                Mutation.CreateOraclePdbRestoreFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	config = @{
		# REQUIRED
		pdbsToRestore = @(
			<System.String>
		)
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

    } // class New-RscGqlMutationCreateOraclePdbRestore
}