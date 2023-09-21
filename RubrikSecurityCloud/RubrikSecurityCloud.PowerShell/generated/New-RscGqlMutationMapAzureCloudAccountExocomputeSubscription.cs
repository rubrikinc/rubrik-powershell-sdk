// New-RscGqlMutationMapAzureCloudAccountExocomputeSubscription.cs
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
    /// Create new GraphQL Mutation mapAzureCloudAccountExocomputeSubscription
    /// mapAzureCloudAccountExocomputeSubscription(input: MapAzureCloudAccountExocomputeSubscriptionInput!): MapAzureCloudAccountExocomputeSubscriptionReply!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlMutationMapAzureCloudAccountExocomputeSubscription")
    ]
    public class New_RscGqlMutationMapAzureCloudAccountExocomputeSubscription : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("mapAzureCloudAccountExocomputeSubscription");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Mutation mapAzureCloudAccountExocomputeSubscription
        /// mapAzureCloudAccountExocomputeSubscription(input: MapAzureCloudAccountExocomputeSubscriptionInput!): MapAzureCloudAccountExocomputeSubscriptionReply!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_mapAzureCloudAccountExocomputeSubscription();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_mapAzureCloudAccountExocomputeSubscription()
        {
            this._logger.name += " -mapAzureCloudAccountExocomputeSubscription";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "MapAzureCloudAccountExocomputeSubscriptionInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationMapAzureCloudAccountExocomputeSubscription",
                "($input: MapAzureCloudAccountExocomputeSubscriptionInput!)",
                "MapAzureCloudAccountExocomputeSubscriptionReply",
                Mutation.MapAzureCloudAccountExocomputeSubscription_ObjectFieldSpec,
                Mutation.MapAzureCloudAccountExocomputeSubscriptionFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	cloudAccountIds = @(
		<System.String>
	)
	# REQUIRED
	exocomputeCloudAccountId = <System.String>
}"
            );
        }

    } // class New-RscGqlMutationMapAzureCloudAccountExocomputeSubscription
}