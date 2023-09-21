// New-RscGqlMutationRefreshOracleDatabase.cs
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
    /// Create new GraphQL Mutation refreshOracleDatabase
    /// refreshOracleDatabase(input: RefreshOracleDatabaseInput!): AsyncRequestStatus!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlMutationRefreshOracleDatabase")
    ]
    public class New_RscGqlMutationRefreshOracleDatabase : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("refreshOracleDatabase");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Mutation refreshOracleDatabase
        /// refreshOracleDatabase(input: RefreshOracleDatabaseInput!): AsyncRequestStatus!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_refreshOracleDatabase();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_refreshOracleDatabase()
        {
            this._logger.name += " -refreshOracleDatabase";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "RefreshOracleDatabaseInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationRefreshOracleDatabase",
                "($input: RefreshOracleDatabaseInput!)",
                "AsyncRequestStatus",
                Mutation.RefreshOracleDatabase_ObjectFieldSpec,
                Mutation.RefreshOracleDatabaseFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
}"
            );
        }

    } // class New-RscGqlMutationRefreshOracleDatabase
}