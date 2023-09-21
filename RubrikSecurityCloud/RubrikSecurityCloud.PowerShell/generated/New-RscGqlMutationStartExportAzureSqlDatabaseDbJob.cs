// New-RscGqlMutationStartExportAzureSqlDatabaseDbJob.cs
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
    /// Create new GraphQL Mutation startExportAzureSqlDatabaseDbJob
    /// startExportAzureSqlDatabaseDbJob(input: StartExportAzureSqlDatabaseDbJobInput!): AsyncJobStatus!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlMutationStartExportAzureSqlDatabaseDbJob")
    ]
    public class New_RscGqlMutationStartExportAzureSqlDatabaseDbJob : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("startExportAzureSqlDatabaseDbJob");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Mutation startExportAzureSqlDatabaseDbJob
        /// startExportAzureSqlDatabaseDbJob(input: StartExportAzureSqlDatabaseDbJobInput!): AsyncJobStatus!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_startExportAzureSqlDatabaseDbJob();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_startExportAzureSqlDatabaseDbJob()
        {
            this._logger.name += " -startExportAzureSqlDatabaseDbJob";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "StartExportAzureSqlDatabaseDbJobInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationStartExportAzureSqlDatabaseDbJob",
                "($input: StartExportAzureSqlDatabaseDbJobInput!)",
                "AsyncJobStatus",
                Mutation.StartExportAzureSqlDatabaseDbJob_ObjectFieldSpec,
                Mutation.StartExportAzureSqlDatabaseDbJobFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	sourceDatabaseRubrikId = <System.String>
	# REQUIRED
	destinationDatabaseName = <System.String>
	# OPTIONAL
	destinationServerRubrikId = <System.String>
	# OPTIONAL
	elasticPoolName = <System.String>
	# REQUIRED
	shouldExportTags = <System.Boolean>
	# OPTIONAL
	azureSqlDatabaseDbPitExportInput = @{
		# REQUIRED
		restorePointInTime = <DateTime>
		# OPTIONAL
		dbBackupRedundancy = <AzureSqlBackupStorageRedundancyType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureSqlBackupStorageRedundancyType]) for enum values.
	}
	# OPTIONAL
	azureSqlDatabaseDbLtrExportInput = @{
		# REQUIRED
		sourceSnapshotRubrikId = <System.String>
		# REQUIRED
		destinationResourceGroupName = <System.String>
		# REQUIRED
		destinationServerName = <System.String>
		# REQUIRED
		destinationRegionName = <System.String>
		# OPTIONAL
		dbBackupRedundancy = <AzureSqlBackupStorageRedundancyType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureSqlBackupStorageRedundancyType]) for enum values.
	}
	# OPTIONAL
	persistentBackupExportInput = @{
		# REQUIRED
		sourceSnapshotRubrikId = <System.String>
		# OPTIONAL
		destinationServerCredentials = @{
			# REQUIRED
			login = <System.String>
			# REQUIRED
			password = <System.String>
		}
		# OPTIONAL
		authMechanism = <SqlAuthenticationMechanism> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SqlAuthenticationMechanism]) for enum values.
		# OPTIONAL
		sessionId = <System.String>
		# OPTIONAL
		dbBackupRedundancy = <AzureSqlBackupStorageRedundancyType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureSqlBackupStorageRedundancyType]) for enum values.
	}
	# OPTIONAL
	serviceTier = <System.String>
	# OPTIONAL
	serviceObjectiveName = <System.String>
}"
            );
        }

    } // class New-RscGqlMutationStartExportAzureSqlDatabaseDbJob
}