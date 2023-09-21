// New-RscGqlQueryAzureNativeResourceGroup.cs
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
    /// Create new GraphQL Query azureNativeResourceGroup
    /// azureNativeResourceGroup(resourceGroupId: UUID!): AzureNativeResourceGroup!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlQueryAzureNativeResourceGroup")
    ]
    public class New_RscGqlQueryAzureNativeResourceGroup : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("azureNativeResourceGroup");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Query azureNativeResourceGroup
        /// azureNativeResourceGroup(resourceGroupId: UUID!): AzureNativeResourceGroup!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_azureNativeResourceGroup();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_azureNativeResourceGroup()
        {
            this._logger.name += " -azureNativeResourceGroup";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("resourceGroupId", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAzureNativeResourceGroup",
                "($resourceGroupId: UUID!)",
                "AzureNativeResourceGroup",
                Query.AzureNativeResourceGroup_ObjectFieldSpec,
                Query.AzureNativeResourceGroupFieldSpec,
                @"# REQUIRED
$inputs.Var.resourceGroupId = <System.String>"
            );
        }

    } // class New-RscGqlQueryAzureNativeResourceGroup
}