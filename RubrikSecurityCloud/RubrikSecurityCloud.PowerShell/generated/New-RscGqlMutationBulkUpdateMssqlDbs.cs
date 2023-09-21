// New-RscGqlMutationBulkUpdateMssqlDbs.cs
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
    /// Create new GraphQL Mutation bulkUpdateMssqlDbs
    /// bulkUpdateMssqlDbs(input: BulkUpdateMssqlDbsInput!): BulkUpdateMssqlDbsReply!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlMutationBulkUpdateMssqlDbs")
    ]
    public class New_RscGqlMutationBulkUpdateMssqlDbs : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("bulkUpdateMssqlDbs");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Mutation bulkUpdateMssqlDbs
        /// bulkUpdateMssqlDbs(input: BulkUpdateMssqlDbsInput!): BulkUpdateMssqlDbsReply!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_bulkUpdateMssqlDbs();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_bulkUpdateMssqlDbs()
        {
            this._logger.name += " -bulkUpdateMssqlDbs";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "BulkUpdateMssqlDbsInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationBulkUpdateMssqlDbs",
                "($input: BulkUpdateMssqlDbsInput!)",
                "BulkUpdateMssqlDbsReply",
                Mutation.BulkUpdateMssqlDbs_ObjectFieldSpec,
                Mutation.BulkUpdateMssqlDbsFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	clusterUuid = <System.String>
	# REQUIRED
	dbsUpdateProperties = @(
		@{
			# REQUIRED
			databaseId = <System.String>
			# REQUIRED
			updateProperties = @{
				# OPTIONAL
				configuredSlaDomainId = <System.String>
				# OPTIONAL
				maxDataStreams = <System.Int32>
				# OPTIONAL
				postBackupScript = @{
					# REQUIRED
					scriptErrorAction = <ScriptErrorAction> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ScriptErrorAction]) for enum values.
					# REQUIRED
					scriptPath = <System.String>
					# REQUIRED
					timeoutMs = <System.Int64>
				}
				# OPTIONAL
				preBackupScript = @{
					# REQUIRED
					scriptErrorAction = <ScriptErrorAction> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ScriptErrorAction]) for enum values.
					# REQUIRED
					scriptPath = <System.String>
					# REQUIRED
					timeoutMs = <System.Int64>
				}
				# OPTIONAL
				isPaused = <System.Boolean>
				# OPTIONAL
				shouldForceFull = <System.Boolean>
				# OPTIONAL
				mssqlNonSlaProperties = @{
					# OPTIONAL
					copyOnly = <System.Boolean>
					# OPTIONAL
					logBackupFrequencyInSeconds = <System.Int32>
					# OPTIONAL
					logRetentionHours = <System.Int32>
				}
				# OPTIONAL
				mssqlSlaPatchProperties = @{
					# OPTIONAL
					configuredSlaDomainId = <System.String>
					# OPTIONAL
					useConfiguredDefaultLogRetention = <System.Boolean>
					# OPTIONAL
					mssqlSlaRelatedProperties = @{
						# OPTIONAL
						copyOnly = <System.Boolean>
						# OPTIONAL
						logBackupFrequencyInSeconds = <System.Int32>
						# OPTIONAL
						logRetentionHours = <System.Int32>
						# OPTIONAL
						hasLogConfigFromSla = <System.Boolean>
						# OPTIONAL
						hostLogRetention = <System.Int32>
					}
				}
				# OPTIONAL
				mssqlSlaRelatedProperties = @{
					# OPTIONAL
					copyOnly = <System.Boolean>
					# OPTIONAL
					logBackupFrequencyInSeconds = <System.Int32>
					# OPTIONAL
					logRetentionHours = <System.Int32>
					# OPTIONAL
					hasLogConfigFromSla = <System.Boolean>
					# OPTIONAL
					hostLogRetention = <System.Int32>
				}
			}
		}
	)
}"
            );
        }

    } // class New-RscGqlMutationBulkUpdateMssqlDbs
}