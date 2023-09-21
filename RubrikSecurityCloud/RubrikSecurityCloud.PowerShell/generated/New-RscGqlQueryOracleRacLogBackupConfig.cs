// New-RscGqlQueryOracleRacLogBackupConfig.cs
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
    /// Create new GraphQL Query oracleRacLogBackupConfig
    /// oracleRacLogBackupConfig(input: OracleRacInput!): OracleLogBackupConfig!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlQueryOracleRacLogBackupConfig")
    ]
    public class New_RscGqlQueryOracleRacLogBackupConfig : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("oracleRacLogBackupConfig");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Query oracleRacLogBackupConfig
        /// oracleRacLogBackupConfig(input: OracleRacInput!): OracleLogBackupConfig!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_oracleRacLogBackupConfig();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_oracleRacLogBackupConfig()
        {
            this._logger.name += " -oracleRacLogBackupConfig";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "OracleRacInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryOracleRacLogBackupConfig",
                "($input: OracleRacInput!)",
                "OracleLogBackupConfig",
                Query.OracleRacLogBackupConfig_ObjectFieldSpec,
                Query.OracleRacLogBackupConfigFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
}"
            );
        }

    } // class New-RscGqlQueryOracleRacLogBackupConfig
}