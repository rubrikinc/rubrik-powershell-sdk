// Invoke-RscGqlMutateUpdateOracleDataGuardGroup.cs
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
    /// Invoke GraphQL Mutation updateOracleDataGuardGroup
    /// updateOracleDataGuardGroup(input: UpdateOracleDataGuardGroupInput!): OracleDbDetail!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "Invoke",
        "RscGqlMutateUpdateOracleDataGuardGroup")
    ]
    public class Invoke_RscGqlMutateUpdateOracleDataGuardGroup : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the Invoke-RscGqlQuery* cmdlets
        // fit in the Invoke-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("updateOracleDataGuardGroup");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Invoke GraphQL Mutation updateOracleDataGuardGroup
        /// updateOracleDataGuardGroup(input: UpdateOracleDataGuardGroupInput!): OracleDbDetail!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_updateOracleDataGuardGroup();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_updateOracleDataGuardGroup()
        {
            this._logger.name += " -updateOracleDataGuardGroup";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateOracleDataGuardGroupInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateOracleDataGuardGroup",
                "($input: UpdateOracleDataGuardGroupInput!)",
                "OracleDbDetail",
                Mutation.UpdateOracleDataGuardGroup_ObjectFieldSpec,
                Mutation.UpdateOracleDataGuardGroupFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
	# REQUIRED
	updateProperties = @{
		# OPTIONAL
		preferredDgMemberUniqueNames = @(
			<System.String>
		)
		# OPTIONAL
		shouldBackupFromPrimaryOnly = <System.Boolean>
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
}"
            );
        }

    } // class Invoke-RscGqlMutateUpdateOracleDataGuardGroup
}