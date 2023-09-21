// New-RscGqlMutationDeleteOracleMount.cs
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
    /// Create new GraphQL Mutation deleteOracleMount
    /// deleteOracleMount(input: DeleteOracleMountInput!): AsyncRequestStatus!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlMutationDeleteOracleMount")
    ]
    public class New_RscGqlMutationDeleteOracleMount : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("deleteOracleMount");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Mutation deleteOracleMount
        /// deleteOracleMount(input: DeleteOracleMountInput!): AsyncRequestStatus!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_deleteOracleMount();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_deleteOracleMount()
        {
            this._logger.name += " -deleteOracleMount";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteOracleMountInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDeleteOracleMount",
                "($input: DeleteOracleMountInput!)",
                "AsyncRequestStatus",
                Mutation.DeleteOracleMount_ObjectFieldSpec,
                Mutation.DeleteOracleMountFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# OPTIONAL
	force = <System.Boolean>
	# REQUIRED
	id = <System.String>
}"
            );
        }

    } // class New-RscGqlMutationDeleteOracleMount
}