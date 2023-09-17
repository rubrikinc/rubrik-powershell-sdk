// Invoke-RscGqlMutateMountOracleDatabase.cs
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
    /// Invoke GraphQL Mutation mountOracleDatabase
    /// mountOracleDatabase(input: MountOracleDatabaseInput!): AsyncRequestStatus!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "Invoke",
        "RscGqlMutateMountOracleDatabase")
    ]
    public class Invoke_RscGqlMutateMountOracleDatabase : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the Invoke-RscGqlQuery* cmdlets
        // fit in the Invoke-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("mountOracleDatabase");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Invoke GraphQL Mutation mountOracleDatabase
        /// mountOracleDatabase(input: MountOracleDatabaseInput!): AsyncRequestStatus!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_mountOracleDatabase();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_mountOracleDatabase()
        {
            this._logger.name += " -mountOracleDatabase";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "MountOracleDatabaseInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationMountOracleDatabase",
                "($input: MountOracleDatabaseInput!)",
                "AsyncRequestStatus",
                Mutation.MountOracleDatabase_ObjectFieldSpec,
                Mutation.MountOracleDatabaseFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	request = @{
		# REQUIRED
		config = @{
			# OPTIONAL
			shouldMountFilesOnly = <System.Boolean>
			# OPTIONAL
			targetMountPath = <System.String>
			# OPTIONAL
			advancedRecoveryConfigBase64 = <System.String>
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
			pdbsToLiveMount = @(
				<System.String>
			)
			# OPTIONAL
			targetRacHostIds = @(
				<System.String>
			)
			# OPTIONAL
			lmDbName = <System.String>
			# OPTIONAL
			targetRacPrimaryHostId = <System.String>
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

    } // class Invoke-RscGqlMutateMountOracleDatabase
}