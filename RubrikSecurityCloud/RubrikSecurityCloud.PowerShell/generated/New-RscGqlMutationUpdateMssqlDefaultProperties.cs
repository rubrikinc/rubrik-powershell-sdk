// New-RscGqlMutationUpdateMssqlDefaultProperties.cs
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
    /// Create new GraphQL Mutation updateMssqlDefaultProperties
    /// updateMssqlDefaultProperties(input: UpdateMssqlDefaultPropertiesInput!): UpdateMssqlDefaultPropertiesReply!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlMutationUpdateMssqlDefaultProperties")
    ]
    public class New_RscGqlMutationUpdateMssqlDefaultProperties : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("updateMssqlDefaultProperties");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Mutation updateMssqlDefaultProperties
        /// updateMssqlDefaultProperties(input: UpdateMssqlDefaultPropertiesInput!): UpdateMssqlDefaultPropertiesReply!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_updateMssqlDefaultProperties();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_updateMssqlDefaultProperties()
        {
            this._logger.name += " -updateMssqlDefaultProperties";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateMssqlDefaultPropertiesInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateMssqlDefaultProperties",
                "($input: UpdateMssqlDefaultPropertiesInput!)",
                "UpdateMssqlDefaultPropertiesReply",
                Mutation.UpdateMssqlDefaultProperties_ObjectFieldSpec,
                Mutation.UpdateMssqlDefaultPropertiesFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	clusterUuid = <System.String>
	# REQUIRED
	defaultProperties = @{
		# OPTIONAL
		cbtStatus = <System.Boolean>
		# OPTIONAL
		logBackupFrequencyInSeconds = <System.Int64>
		# OPTIONAL
		logRetentionTimeInHours = <System.Int32>
		# OPTIONAL
		shouldUseDefaultBackupLocation = <System.Boolean>
	}
}"
            );
        }

    } // class New-RscGqlMutationUpdateMssqlDefaultProperties
}