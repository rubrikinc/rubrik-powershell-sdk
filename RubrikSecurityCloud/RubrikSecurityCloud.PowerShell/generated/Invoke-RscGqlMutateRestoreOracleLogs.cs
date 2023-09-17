// Invoke-RscGqlMutateRestoreOracleLogs.cs
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
    /// Invoke GraphQL Mutation restoreOracleLogs
    /// restoreOracleLogs(input: RestoreOracleLogsInput!): AsyncRequestStatus!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "Invoke",
        "RscGqlMutateRestoreOracleLogs")
    ]
    public class Invoke_RscGqlMutateRestoreOracleLogs : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the Invoke-RscGqlQuery* cmdlets
        // fit in the Invoke-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("restoreOracleLogs");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Invoke GraphQL Mutation restoreOracleLogs
        /// restoreOracleLogs(input: RestoreOracleLogsInput!): AsyncRequestStatus!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_restoreOracleLogs();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_restoreOracleLogs()
        {
            this._logger.name += " -restoreOracleLogs";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "RestoreOracleLogsInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationRestoreOracleLogs",
                "($input: RestoreOracleLogsInput!)",
                "AsyncRequestStatus",
                Mutation.RestoreOracleLogs_ObjectFieldSpec,
                Mutation.RestoreOracleLogsFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	config = @{
		# OPTIONAL
		targetMountPath = <System.String>
		# REQUIRED
		oracleLogRecoveryRange = @{
			# OPTIONAL
			oracleTimeRange = @{
				# OPTIONAL
				endTime = <DateTime>
				# OPTIONAL
				startTime = <DateTime>
			}
		}
		# REQUIRED
		shouldMountFilesOnly = <System.Boolean>
		# REQUIRED
		targetOracleHostOrRacId = <System.String>
	}
	# REQUIRED
	id = <System.String>
}"
            );
        }

    } // class Invoke-RscGqlMutateRestoreOracleLogs
}