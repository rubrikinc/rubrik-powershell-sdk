// New-RscGqlMutationAssignMssqlSlaDomainProperties.cs
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
    /// Create new GraphQL Mutation assignMssqlSlaDomainProperties
    /// assignMssqlSlaDomainProperties(input: AssignMssqlSlaDomainPropertiesInput!): ResponseSuccess!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlMutationAssignMssqlSlaDomainProperties")
    ]
    public class New_RscGqlMutationAssignMssqlSlaDomainProperties : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("assignMssqlSlaDomainProperties");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Mutation assignMssqlSlaDomainProperties
        /// assignMssqlSlaDomainProperties(input: AssignMssqlSlaDomainPropertiesInput!): ResponseSuccess!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_assignMssqlSlaDomainProperties();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_assignMssqlSlaDomainProperties()
        {
            this._logger.name += " -assignMssqlSlaDomainProperties";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "AssignMssqlSlaDomainPropertiesInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationAssignMssqlSlaDomainProperties",
                "($input: AssignMssqlSlaDomainPropertiesInput!)",
                "ResponseSuccess",
                Mutation.AssignMssqlSlaDomainProperties_ObjectFieldSpec,
                Mutation.AssignMssqlSlaDomainPropertiesFieldSpec,
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
}"
            );
        }

    } // class New-RscGqlMutationAssignMssqlSlaDomainProperties
}