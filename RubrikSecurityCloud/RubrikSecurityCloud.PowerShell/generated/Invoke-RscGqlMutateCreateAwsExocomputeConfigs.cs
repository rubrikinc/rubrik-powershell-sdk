// Invoke-RscGqlMutateCreateAwsExocomputeConfigs.cs
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
    /// Invoke GraphQL Mutation createAwsExocomputeConfigs
    /// createAwsExocomputeConfigs(input: CreateAwsExocomputeConfigsInput!): CreateAwsExocomputeConfigsReply!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "Invoke",
        "RscGqlMutateCreateAwsExocomputeConfigs")
    ]
    public class Invoke_RscGqlMutateCreateAwsExocomputeConfigs : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the Invoke-RscGqlQuery* cmdlets
        // fit in the Invoke-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("createAwsExocomputeConfigs");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Invoke GraphQL Mutation createAwsExocomputeConfigs
        /// createAwsExocomputeConfigs(input: CreateAwsExocomputeConfigsInput!): CreateAwsExocomputeConfigsReply!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_createAwsExocomputeConfigs();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_createAwsExocomputeConfigs()
        {
            this._logger.name += " -createAwsExocomputeConfigs";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateAwsExocomputeConfigsInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateAwsExocomputeConfigs",
                "($input: CreateAwsExocomputeConfigsInput!)",
                "CreateAwsExocomputeConfigsReply",
                Mutation.CreateAwsExocomputeConfigs_ObjectFieldSpec,
                Mutation.CreateAwsExocomputeConfigsFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	cloudAccountId = <System.String>
	# REQUIRED
	configs = @(
		@{
			# REQUIRED
			region = <AwsCloudAccountRegion> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsCloudAccountRegion]) for enum values.
			# OPTIONAL
			clusterSecurityGroupId = <System.String>
			# REQUIRED
			vpcId = <System.String>
			# OPTIONAL
			nodeSecurityGroupId = <System.String>
			# REQUIRED
			subnets = @(
				@{
					# REQUIRED
					subnetId = <System.String>
					# REQUIRED
					availabilityZone = <System.String>
				}
			)
			# REQUIRED
			isRscManaged = <System.Boolean>
		}
	)
	# OPTIONAL
	triggerHealthCheck = <System.Boolean>
}"
            );
        }

    } // class Invoke-RscGqlMutateCreateAwsExocomputeConfigs
}