// New-RscGqlQueryAzureCloudAccountPermissionConfig.cs
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
    /// Create new GraphQL Query azureCloudAccountPermissionConfig
    /// azureCloudAccountPermissionConfig(feature: CloudAccountFeature!): AzureCloudAccountPermissionConfigResponse!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlQueryAzureCloudAccountPermissionConfig")
    ]
    public class New_RscGqlQueryAzureCloudAccountPermissionConfig : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("azureCloudAccountPermissionConfig");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Query azureCloudAccountPermissionConfig
        /// azureCloudAccountPermissionConfig(feature: CloudAccountFeature!): AzureCloudAccountPermissionConfigResponse!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_azureCloudAccountPermissionConfig();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_azureCloudAccountPermissionConfig()
        {
            this._logger.name += " -azureCloudAccountPermissionConfig";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("feature", "CloudAccountFeature!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAzureCloudAccountPermissionConfig",
                "($feature: CloudAccountFeature!)",
                "AzureCloudAccountPermissionConfigResponse",
                Query.AzureCloudAccountPermissionConfig_ObjectFieldSpec,
                Query.AzureCloudAccountPermissionConfigFieldSpec,
                @"# REQUIRED
$inputs.Var.feature = <CloudAccountFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values."
            );
        }

    } // class New-RscGqlQueryAzureCloudAccountPermissionConfig
}