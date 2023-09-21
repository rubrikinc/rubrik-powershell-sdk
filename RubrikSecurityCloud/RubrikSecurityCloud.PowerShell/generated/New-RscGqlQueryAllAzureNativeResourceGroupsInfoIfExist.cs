// New-RscGqlQueryAllAzureNativeResourceGroupsInfoIfExist.cs
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
    /// Create new GraphQL Query allAzureNativeResourceGroupsInfoIfExist
    /// allAzureNativeResourceGroupsInfoIfExist(input: AzureGetResourceGroupsInfoIfExistInput!): [AzureResourceGroupInfo!]!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlQueryAllAzureNativeResourceGroupsInfoIfExist")
    ]
    public class New_RscGqlQueryAllAzureNativeResourceGroupsInfoIfExist : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("allAzureNativeResourceGroupsInfoIfExist");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Query allAzureNativeResourceGroupsInfoIfExist
        /// allAzureNativeResourceGroupsInfoIfExist(input: AzureGetResourceGroupsInfoIfExistInput!): [AzureResourceGroupInfo!]!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_allAzureNativeResourceGroupsInfoIfExist();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_allAzureNativeResourceGroupsInfoIfExist()
        {
            this._logger.name += " -allAzureNativeResourceGroupsInfoIfExist";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "AzureGetResourceGroupsInfoIfExistInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllAzureNativeResourceGroupsInfoIfExist",
                "($input: AzureGetResourceGroupsInfoIfExistInput!)",
                "List<AzureResourceGroupInfo>",
                Query.AllAzureNativeResourceGroupsInfoIfExist_ObjectFieldSpec,
                Query.AllAzureNativeResourceGroupsInfoIfExistFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	sessionId = <System.String>
	# REQUIRED
	resourceGroupInputs = @(
		@{
			# REQUIRED
			subscriptionNativeId = <System.String>
			# REQUIRED
			resourceGroupName = <System.String>
		}
	)
}"
            );
        }

    } // class New-RscGqlQueryAllAzureNativeResourceGroupsInfoIfExist
}