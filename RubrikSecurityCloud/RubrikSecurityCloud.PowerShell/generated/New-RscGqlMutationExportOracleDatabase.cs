// New-RscGqlMutationExportOracleDatabase.cs
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
    /// Create new GraphQL Mutation exportOracleDatabase
    /// exportOracleDatabase(input: ExportOracleDatabaseInput!): AsyncRequestStatus!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlMutationExportOracleDatabase")
    ]
    public class New_RscGqlMutationExportOracleDatabase : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("exportOracleDatabase");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Mutation exportOracleDatabase
        /// exportOracleDatabase(input: ExportOracleDatabaseInput!): AsyncRequestStatus!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_exportOracleDatabase();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_exportOracleDatabase()
        {
            this._logger.name += " -exportOracleDatabase";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "ExportOracleDatabaseInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationExportOracleDatabase",
                "($input: ExportOracleDatabaseInput!)",
                "AsyncRequestStatus",
                Mutation.ExportOracleDatabase_ObjectFieldSpec,
                Mutation.ExportOracleDatabaseFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	request = @{
		# REQUIRED
		config = @{
			# OPTIONAL
			restoreFilesPath = <System.String>
			# OPTIONAL
			shouldRestoreFilesOnly = <System.Boolean>
			# OPTIONAL
			targetMountPath = <System.String>
			# OPTIONAL
			advancedRecoveryConfigBase64 = <System.String>
			# OPTIONAL
			archiveLogPath = <System.String>
			# OPTIONAL
			cloneDbName = <System.String>
			# OPTIONAL
			customPfilePath = <System.String>
			# OPTIONAL
			numChannels = <System.Int32>
			# OPTIONAL
			postScriptPath = <System.String>
			# OPTIONAL
			preScriptPath = <System.String>
			# OPTIONAL
			shouldStopRecoveryOnPreScriptFailure = <System.Boolean>
			# OPTIONAL
			pdbsToClone = @(
				<System.String>
			)
			# OPTIONAL
			shouldSkipDropDbInUndo = <System.Boolean>
			# OPTIONAL
			shouldAllowRenameToSource = <System.Boolean>
			# REQUIRED
			recoveryPoint = @{
				# OPTIONAL
				snapshotId = <System.String>
				# OPTIONAL
				timestampMs = <System.Int64>
			}
			# REQUIRED
			targetOracleHostOrRacId = <System.String>
		}
		# REQUIRED
		id = <System.String>
	}
	# OPTIONAL
	advancedRecoveryConfigMap = @(
		@{
			# OPTIONAL
			key = <System.String>
			# OPTIONAL
			value = <System.String>
		}
	)
}"
            );
        }

    } // class New-RscGqlMutationExportOracleDatabase
}