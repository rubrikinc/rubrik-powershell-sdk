// New-RscGqlQueryOracleHostLogBackupConfig.cs
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
    /// Create new GraphQL Query oracleHostLogBackupConfig
    /// oracleHostLogBackupConfig(input: OracleHostInput!): OracleLogBackupConfig!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlQueryOracleHostLogBackupConfig")
    ]
    public class New_RscGqlQueryOracleHostLogBackupConfig : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("oracleHostLogBackupConfig");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Query oracleHostLogBackupConfig
        /// oracleHostLogBackupConfig(input: OracleHostInput!): OracleLogBackupConfig!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_oracleHostLogBackupConfig();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_oracleHostLogBackupConfig()
        {
            this._logger.name += " -oracleHostLogBackupConfig";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "OracleHostInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryOracleHostLogBackupConfig",
                "($input: OracleHostInput!)",
                "OracleLogBackupConfig",
                Query.OracleHostLogBackupConfig_ObjectFieldSpec,
                Query.OracleHostLogBackupConfigFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
}"
            );
        }

    } // class New-RscGqlQueryOracleHostLogBackupConfig
}