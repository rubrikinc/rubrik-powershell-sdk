// New-RscGqlMutationDeleteAwsExocomputeConfigs.cs
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
    /// Create new GraphQL Mutation deleteAwsExocomputeConfigs
    /// deleteAwsExocomputeConfigs(input: DeleteAwsExocomputeConfigsInput!): DeleteAwsExocomputeConfigsReply!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlMutationDeleteAwsExocomputeConfigs")
    ]
    public class New_RscGqlMutationDeleteAwsExocomputeConfigs : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("deleteAwsExocomputeConfigs");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Mutation deleteAwsExocomputeConfigs
        /// deleteAwsExocomputeConfigs(input: DeleteAwsExocomputeConfigsInput!): DeleteAwsExocomputeConfigsReply!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_deleteAwsExocomputeConfigs();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_deleteAwsExocomputeConfigs()
        {
            this._logger.name += " -deleteAwsExocomputeConfigs";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteAwsExocomputeConfigsInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDeleteAwsExocomputeConfigs",
                "($input: DeleteAwsExocomputeConfigsInput!)",
                "DeleteAwsExocomputeConfigsReply",
                Mutation.DeleteAwsExocomputeConfigs_ObjectFieldSpec,
                Mutation.DeleteAwsExocomputeConfigsFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	configIdsToBeDeleted = @(
		<System.String>
	)
}"
            );
        }

    } // class New-RscGqlMutationDeleteAwsExocomputeConfigs
}