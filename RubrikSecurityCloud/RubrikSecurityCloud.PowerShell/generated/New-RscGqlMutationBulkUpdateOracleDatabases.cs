// New-RscGqlMutationBulkUpdateOracleDatabases.cs
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
    /// Create new GraphQL Mutation bulkUpdateOracleDatabases
    /// bulkUpdateOracleDatabases(input: BulkUpdateOracleDatabasesInput!): BulkUpdateOracleDatabasesReply!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlMutationBulkUpdateOracleDatabases")
    ]
    public class New_RscGqlMutationBulkUpdateOracleDatabases : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("bulkUpdateOracleDatabases");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Mutation bulkUpdateOracleDatabases
        /// bulkUpdateOracleDatabases(input: BulkUpdateOracleDatabasesInput!): BulkUpdateOracleDatabasesReply!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_bulkUpdateOracleDatabases();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_bulkUpdateOracleDatabases()
        {
            this._logger.name += " -bulkUpdateOracleDatabases";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "BulkUpdateOracleDatabasesInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationBulkUpdateOracleDatabases",
                "($input: BulkUpdateOracleDatabasesInput!)",
                "BulkUpdateOracleDatabasesReply",
                Mutation.BulkUpdateOracleDatabases_ObjectFieldSpec,
                Mutation.BulkUpdateOracleDatabasesFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	bulkUpdateProperties = @{
		# OPTIONAL
		oracleUpdate = @{
			# OPTIONAL
			configuredSlaDomainId = <System.String>
			# OPTIONAL
			hostMount = <System.String>
			# OPTIONAL
			logBackupFrequencyInMinutes = <System.Int32>
			# OPTIONAL
			logRetentionHours = <System.Int32>
			# OPTIONAL
			numChannels = <System.Int32>
			# OPTIONAL
			hostLogRetentionHours = <System.Int32>
			# OPTIONAL
			configuredSlaDomainIdDeprecated = <System.String>
			# OPTIONAL
			nodeOrder = @(
				@{
					# REQUIRED
					nodeName = <System.String>
					# REQUIRED
					order = <System.Int32>
				}
			)
			# OPTIONAL
			shouldDistributeBackupsAutomatically = <System.Boolean>
			# OPTIONAL
			oracleUpdateCommon = @{
				# OPTIONAL
				hostLogRetentionHours = <System.Int32>
				# OPTIONAL
				hostMount = <System.String>
				# OPTIONAL
				logBackupFrequencyInMinutes = <System.Int32>
				# OPTIONAL
				logRetentionHours = <System.Int32>
				# OPTIONAL
				numChannels = <System.Int32>
				# OPTIONAL
				hasLogConfigFromSla = <System.Boolean>
				# OPTIONAL
				shouldEnableHighFileCountSupport = <System.Boolean>
				# OPTIONAL
				shouldUseSecureThriftForDataTransfer = <System.Boolean>
				# OPTIONAL
				sectionSizeInGb = <System.Int32>
			}
		}
		# REQUIRED
		ids = @(
			<System.String>
		)
	}
}"
            );
        }

    } // class New-RscGqlMutationBulkUpdateOracleDatabases
}