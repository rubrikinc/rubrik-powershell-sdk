// Invoke-RscGqlQueryDoesAzureNativeResourceGroupExist.cs
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
    /// Invoke GraphQL Query doesAzureNativeResourceGroupExist
    /// doesAzureNativeResourceGroupExist(
    ///     cloudAccountId: UUID!
    ///     azureSubscriptionNativeId: UUID!
    ///     resourceGroupName: String!
    ///     feature: CloudAccountFeature!
    ///   ): Boolean!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "Invoke",
        "RscGqlQueryDoesAzureNativeResourceGroupExist")
    ]
    public class Invoke_RscGqlQueryDoesAzureNativeResourceGroupExist : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the Invoke-RscGqlQuery* cmdlets
        // fit in the Invoke-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("doesAzureNativeResourceGroupExist");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Invoke GraphQL Query doesAzureNativeResourceGroupExist
        /// doesAzureNativeResourceGroupExist(
        ///     cloudAccountId: UUID!
        ///     azureSubscriptionNativeId: UUID!
        ///     resourceGroupName: String!
        ///     feature: CloudAccountFeature!
        ///   ): Boolean!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_doesAzureNativeResourceGroupExist();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_doesAzureNativeResourceGroupExist()
        {
            this._logger.name += " -doesAzureNativeResourceGroupExist";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("cloudAccountId", "UUID!"),
                Tuple.Create("azureSubscriptionNativeId", "UUID!"),
                Tuple.Create("resourceGroupName", "String!"),
                Tuple.Create("feature", "CloudAccountFeature!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryDoesAzureNativeResourceGroupExist",
                "($cloudAccountId: UUID!,$azureSubscriptionNativeId: UUID!,$resourceGroupName: String!,$feature: CloudAccountFeature!)",
                "System.Boolean",
                Query.DoesAzureNativeResourceGroupExist_ObjectFieldSpec,
                Query.DoesAzureNativeResourceGroupExistFieldSpec,
                @"# REQUIRED
$inputs.Var.cloudAccountId = <System.String>
# REQUIRED
$inputs.Var.azureSubscriptionNativeId = <System.String>
# REQUIRED
$inputs.Var.resourceGroupName = <System.String>
# REQUIRED
$inputs.Var.feature = <CloudAccountFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values."
            );
        }

    } // class Invoke-RscGqlQueryDoesAzureNativeResourceGroupExist
}