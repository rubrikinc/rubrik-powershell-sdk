// New-RscGqlQueryOracleDatabaseLogBackupConfig.cs
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
    /// Create new GraphQL Query oracleDatabaseLogBackupConfig
    /// oracleDatabaseLogBackupConfig(input: OracleDbInput!): OracleLogBackupConfig!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlQueryOracleDatabaseLogBackupConfig")
    ]
    public class New_RscGqlQueryOracleDatabaseLogBackupConfig : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("oracleDatabaseLogBackupConfig");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Query oracleDatabaseLogBackupConfig
        /// oracleDatabaseLogBackupConfig(input: OracleDbInput!): OracleLogBackupConfig!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_oracleDatabaseLogBackupConfig();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_oracleDatabaseLogBackupConfig()
        {
            this._logger.name += " -oracleDatabaseLogBackupConfig";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "OracleDbInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryOracleDatabaseLogBackupConfig",
                "($input: OracleDbInput!)",
                "OracleLogBackupConfig",
                Query.OracleDatabaseLogBackupConfig_ObjectFieldSpec,
                Query.OracleDatabaseLogBackupConfigFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
}"
            );
        }

    } // class New-RscGqlQueryOracleDatabaseLogBackupConfig
}