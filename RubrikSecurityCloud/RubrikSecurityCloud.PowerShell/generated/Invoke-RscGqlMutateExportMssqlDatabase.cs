// Invoke-RscGqlMutateExportMssqlDatabase.cs
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
    /// Invoke GraphQL Mutation exportMssqlDatabase
    /// exportMssqlDatabase(input: ExportMssqlDatabaseInput!): AsyncRequestStatus!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "Invoke",
        "RscGqlMutateExportMssqlDatabase")
    ]
    public class Invoke_RscGqlMutateExportMssqlDatabase : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the Invoke-RscGqlQuery* cmdlets
        // fit in the Invoke-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("exportMssqlDatabase");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Invoke GraphQL Mutation exportMssqlDatabase
        /// exportMssqlDatabase(input: ExportMssqlDatabaseInput!): AsyncRequestStatus!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_exportMssqlDatabase();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_exportMssqlDatabase()
        {
            this._logger.name += " -exportMssqlDatabase";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "ExportMssqlDatabaseInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationExportMssqlDatabase",
                "($input: ExportMssqlDatabaseInput!)",
                "AsyncRequestStatus",
                Mutation.ExportMssqlDatabase_ObjectFieldSpec,
                Mutation.ExportMssqlDatabaseFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	config = @{
		# OPTIONAL
		allowOverwrite = <System.Boolean>
		# OPTIONAL
		finishRecovery = <System.Boolean>
		# OPTIONAL
		maxDataStreams = <System.Int32>
		# OPTIONAL
		targetDataFilePath = <System.String>
		# OPTIONAL
		targetFilePaths = @(
			@{
				# OPTIONAL
				newFilename = <System.String>
				# OPTIONAL
				newLogicalName = <System.String>
				# REQUIRED
				exportPath = <System.String>
				# REQUIRED
				logicalName = <System.String>
			}
		)
		# OPTIONAL
		targetLogFilePath = <System.String>
		# REQUIRED
		recoveryPoint = @{
			# OPTIONAL
			lsnPoint = @{
				# OPTIONAL
				recoveryForkGuid = <System.String>
				# REQUIRED
				lsn = <System.String>
			}
			# OPTIONAL
			timestampMs = <System.Int64>
			# OPTIONAL
			date = <DateTime>
		}
		# REQUIRED
		targetDatabaseName = <System.String>
		# REQUIRED
		targetInstanceId = <System.String>
	}
	# REQUIRED
	id = <System.String>
}"
            );
        }

    } // class Invoke-RscGqlMutateExportMssqlDatabase
}