// Invoke-RscGqlMutateBulkUpdateOracleRacs.cs
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
    /// Invoke GraphQL Mutation bulkUpdateOracleRacs
    /// bulkUpdateOracleRacs(input: BulkUpdateOracleRacsInput!): BulkUpdateOracleRacsReply!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "Invoke",
        "RscGqlMutateBulkUpdateOracleRacs")
    ]
    public class Invoke_RscGqlMutateBulkUpdateOracleRacs : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the Invoke-RscGqlQuery* cmdlets
        // fit in the Invoke-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("bulkUpdateOracleRacs");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Invoke GraphQL Mutation bulkUpdateOracleRacs
        /// bulkUpdateOracleRacs(input: BulkUpdateOracleRacsInput!): BulkUpdateOracleRacsReply!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_bulkUpdateOracleRacs();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_bulkUpdateOracleRacs()
        {
            this._logger.name += " -bulkUpdateOracleRacs";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "BulkUpdateOracleRacsInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationBulkUpdateOracleRacs",
                "($input: BulkUpdateOracleRacsInput!)",
                "BulkUpdateOracleRacsReply",
                Mutation.BulkUpdateOracleRacs_ObjectFieldSpec,
                Mutation.BulkUpdateOracleRacsFieldSpec,
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

    } // class Invoke-RscGqlMutateBulkUpdateOracleRacs
}