// New-RscGqlQueryAllAzureCloudAccountMissingPermissions.cs
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
    /// Create new GraphQL Query allAzureCloudAccountMissingPermissions
    /// allAzureCloudAccountMissingPermissions(sessionId: String!, subscriptionIds: [UUID!]!, cloudAccountAction: CloudAccountAction!): [AzureSubscriptionMissingPermissions!]!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlQueryAllAzureCloudAccountMissingPermissions")
    ]
    public class New_RscGqlQueryAllAzureCloudAccountMissingPermissions : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("allAzureCloudAccountMissingPermissions");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Query allAzureCloudAccountMissingPermissions
        /// allAzureCloudAccountMissingPermissions(sessionId: String!, subscriptionIds: [UUID!]!, cloudAccountAction: CloudAccountAction!): [AzureSubscriptionMissingPermissions!]!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_allAzureCloudAccountMissingPermissions();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_allAzureCloudAccountMissingPermissions()
        {
            this._logger.name += " -allAzureCloudAccountMissingPermissions";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("sessionId", "String!"),
                Tuple.Create("subscriptionIds", "[UUID!]!"),
                Tuple.Create("cloudAccountAction", "CloudAccountAction!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllAzureCloudAccountMissingPermissions",
                "($sessionId: String!,$subscriptionIds: [UUID!]!,$cloudAccountAction: CloudAccountAction!)",
                "List<AzureSubscriptionMissingPermissions>",
                Query.AllAzureCloudAccountMissingPermissions_ObjectFieldSpec,
                Query.AllAzureCloudAccountMissingPermissionsFieldSpec,
                @"# REQUIRED
$inputs.Var.sessionId = <System.String>
# REQUIRED
$inputs.Var.subscriptionIds = @(
	<System.String>
)
# REQUIRED
$inputs.Var.cloudAccountAction = <CloudAccountAction> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountAction]) for enum values."
            );
        }

    } // class New-RscGqlQueryAllAzureCloudAccountMissingPermissions
}