// New-RscGqlMutationStartRefreshAzureNativeSubscriptionsJob.cs
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
    /// Create new GraphQL Mutation startRefreshAzureNativeSubscriptionsJob
    /// startRefreshAzureNativeSubscriptionsJob(input: StartRefreshAzureNativeSubscriptionsJobInput!): BatchAsyncJobStatus!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlMutationStartRefreshAzureNativeSubscriptionsJob")
    ]
    public class New_RscGqlMutationStartRefreshAzureNativeSubscriptionsJob : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("startRefreshAzureNativeSubscriptionsJob");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Mutation startRefreshAzureNativeSubscriptionsJob
        /// startRefreshAzureNativeSubscriptionsJob(input: StartRefreshAzureNativeSubscriptionsJobInput!): BatchAsyncJobStatus!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_startRefreshAzureNativeSubscriptionsJob();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_startRefreshAzureNativeSubscriptionsJob()
        {
            this._logger.name += " -startRefreshAzureNativeSubscriptionsJob";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "StartRefreshAzureNativeSubscriptionsJobInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationStartRefreshAzureNativeSubscriptionsJob",
                "($input: StartRefreshAzureNativeSubscriptionsJobInput!)",
                "BatchAsyncJobStatus",
                Mutation.StartRefreshAzureNativeSubscriptionsJob_ObjectFieldSpec,
                Mutation.StartRefreshAzureNativeSubscriptionsJobFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	azureSubscriptionRubrikIds = @(
		<System.String>
	)
}"
            );
        }

    } // class New-RscGqlMutationStartRefreshAzureNativeSubscriptionsJob
}