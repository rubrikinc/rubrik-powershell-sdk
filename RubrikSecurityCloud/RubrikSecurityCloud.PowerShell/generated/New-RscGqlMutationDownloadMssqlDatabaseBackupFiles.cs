// New-RscGqlMutationDownloadMssqlDatabaseBackupFiles.cs
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
    /// Create new GraphQL Mutation downloadMssqlDatabaseBackupFiles
    /// downloadMssqlDatabaseBackupFiles(input: DownloadMssqlDatabaseBackupFilesInput!): AsyncRequestStatus!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlMutationDownloadMssqlDatabaseBackupFiles")
    ]
    public class New_RscGqlMutationDownloadMssqlDatabaseBackupFiles : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("downloadMssqlDatabaseBackupFiles");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Mutation downloadMssqlDatabaseBackupFiles
        /// downloadMssqlDatabaseBackupFiles(input: DownloadMssqlDatabaseBackupFilesInput!): AsyncRequestStatus!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_downloadMssqlDatabaseBackupFiles();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_downloadMssqlDatabaseBackupFiles()
        {
            this._logger.name += " -downloadMssqlDatabaseBackupFiles";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DownloadMssqlDatabaseBackupFilesInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDownloadMssqlDatabaseBackupFiles",
                "($input: DownloadMssqlDatabaseBackupFilesInput!)",
                "AsyncRequestStatus",
                Mutation.DownloadMssqlDatabaseBackupFiles_ObjectFieldSpec,
                Mutation.DownloadMssqlDatabaseBackupFilesFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	config = @{
		# OPTIONAL
		legalHoldDownloadConfig = @{
			# REQUIRED
			isLegalHoldDownload = <System.Boolean>
		}
		# REQUIRED
		items = @(
			<System.String>
		)
	}
	# REQUIRED
	id = <System.String>
	# OPTIONAL
	userNote = <System.String>
}"
            );
        }

    } // class New-RscGqlMutationDownloadMssqlDatabaseBackupFiles
}