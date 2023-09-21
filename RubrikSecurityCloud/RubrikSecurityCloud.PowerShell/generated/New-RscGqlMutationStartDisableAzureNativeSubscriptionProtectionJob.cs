// New-RscGqlMutationStartDisableAzureNativeSubscriptionProtectionJob.cs
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
    /// Create new GraphQL Mutation startDisableAzureNativeSubscriptionProtectionJob
    /// startDisableAzureNativeSubscriptionProtectionJob(input: StartDisableAzureNativeSubscriptionProtectionJobInput!): AsyncJobStatus!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlMutationStartDisableAzureNativeSubscriptionProtectionJob")
    ]
    public class New_RscGqlMutationStartDisableAzureNativeSubscriptionProtectionJob : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("startDisableAzureNativeSubscriptionProtectionJob");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Mutation startDisableAzureNativeSubscriptionProtectionJob
        /// startDisableAzureNativeSubscriptionProtectionJob(input: StartDisableAzureNativeSubscriptionProtectionJobInput!): AsyncJobStatus!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_startDisableAzureNativeSubscriptionProtectionJob();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_startDisableAzureNativeSubscriptionProtectionJob()
        {
            this._logger.name += " -startDisableAzureNativeSubscriptionProtectionJob";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "StartDisableAzureNativeSubscriptionProtectionJobInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationStartDisableAzureNativeSubscriptionProtectionJob",
                "($input: StartDisableAzureNativeSubscriptionProtectionJobInput!)",
                "AsyncJobStatus",
                Mutation.StartDisableAzureNativeSubscriptionProtectionJob_ObjectFieldSpec,
                Mutation.StartDisableAzureNativeSubscriptionProtectionJobFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	azureSubscriptionRubrikId = <System.String>
	# REQUIRED
	shouldDeleteNativeSnapshots = <System.Boolean>
	# REQUIRED
	azureNativeProtectionFeature = <AzureNativeProtectionFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeProtectionFeature]) for enum values.
}"
            );
        }

    } // class New-RscGqlMutationStartDisableAzureNativeSubscriptionProtectionJob
}