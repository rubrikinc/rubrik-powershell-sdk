// Invoke-RscGqlQueryAllMssqlDatabaseRestoreFiles.cs
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
    /// Invoke GraphQL Query allMssqlDatabaseRestoreFiles
    /// allMssqlDatabaseRestoreFiles(input: MssqlGetRestoreFilesV1Input!): V1MssqlGetRestoreFilesV1Response!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "Invoke",
        "RscGqlQueryAllMssqlDatabaseRestoreFiles")
    ]
    public class Invoke_RscGqlQueryAllMssqlDatabaseRestoreFiles : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the Invoke-RscGqlQuery* cmdlets
        // fit in the Invoke-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("allMssqlDatabaseRestoreFiles");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Invoke GraphQL Query allMssqlDatabaseRestoreFiles
        /// allMssqlDatabaseRestoreFiles(input: MssqlGetRestoreFilesV1Input!): V1MssqlGetRestoreFilesV1Response!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_allMssqlDatabaseRestoreFiles();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_allMssqlDatabaseRestoreFiles()
        {
            this._logger.name += " -allMssqlDatabaseRestoreFiles";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "MssqlGetRestoreFilesV1Input!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllMssqlDatabaseRestoreFiles",
                "($input: MssqlGetRestoreFilesV1Input!)",
                "V1MssqlGetRestoreFilesV1Response",
                Query.AllMssqlDatabaseRestoreFiles_ObjectFieldSpec,
                Query.AllMssqlDatabaseRestoreFilesFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# OPTIONAL
	lsn = <System.String>
	# OPTIONAL
	recoveryForkGuid = <System.String>
	# OPTIONAL
	time = <DateTime>
	# REQUIRED
	id = <System.String>
}"
            );
        }

    } // class Invoke-RscGqlQueryAllMssqlDatabaseRestoreFiles
}