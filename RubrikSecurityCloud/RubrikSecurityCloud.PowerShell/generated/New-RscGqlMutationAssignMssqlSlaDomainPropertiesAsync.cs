// New-RscGqlMutationAssignMssqlSlaDomainPropertiesAsync.cs
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
    /// Create new GraphQL Mutation assignMssqlSlaDomainPropertiesAsync
    /// assignMssqlSlaDomainPropertiesAsync(input: AssignMssqlSlaDomainPropertiesAsyncInput!): AssignMssqlSlaDomainPropertiesAsyncReply!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlMutationAssignMssqlSlaDomainPropertiesAsync")
    ]
    public class New_RscGqlMutationAssignMssqlSlaDomainPropertiesAsync : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("assignMssqlSlaDomainPropertiesAsync");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Mutation assignMssqlSlaDomainPropertiesAsync
        /// assignMssqlSlaDomainPropertiesAsync(input: AssignMssqlSlaDomainPropertiesAsyncInput!): AssignMssqlSlaDomainPropertiesAsyncReply!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_assignMssqlSlaDomainPropertiesAsync();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_assignMssqlSlaDomainPropertiesAsync()
        {
            this._logger.name += " -assignMssqlSlaDomainPropertiesAsync";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "AssignMssqlSlaDomainPropertiesAsyncInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationAssignMssqlSlaDomainPropertiesAsync",
                "($input: AssignMssqlSlaDomainPropertiesAsyncInput!)",
                "AssignMssqlSlaDomainPropertiesAsyncReply",
                Mutation.AssignMssqlSlaDomainPropertiesAsync_ObjectFieldSpec,
                Mutation.AssignMssqlSlaDomainPropertiesAsyncFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	updateInfo = @{
		# OPTIONAL
		shouldApplyToExistingSnapshots = <System.Boolean>
		# OPTIONAL
		shouldApplyToNonPolicySnapshots = <System.Boolean>
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
		existingSnapshotRetention = <ExistingSnapshotRetention> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ExistingSnapshotRetention]) for enum values.
		# REQUIRED
		ids = @(
			<System.String>
		)
	}
	# OPTIONAL
	userNote = <System.String>
}"
            );
        }

    } // class New-RscGqlMutationAssignMssqlSlaDomainPropertiesAsync
}