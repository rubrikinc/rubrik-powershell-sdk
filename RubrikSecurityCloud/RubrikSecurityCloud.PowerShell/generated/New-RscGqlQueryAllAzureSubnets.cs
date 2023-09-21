// New-RscGqlQueryAllAzureSubnets.cs
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
    /// Create new GraphQL Query allAzureSubnets
    /// allAzureSubnets(subnetRequest: AzureSubnetReq!): [String!]!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlQueryAllAzureSubnets")
    ]
    public class New_RscGqlQueryAllAzureSubnets : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("allAzureSubnets");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Query allAzureSubnets
        /// allAzureSubnets(subnetRequest: AzureSubnetReq!): [String!]!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_allAzureSubnets();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_allAzureSubnets()
        {
            this._logger.name += " -allAzureSubnets";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("subnetRequest", "AzureSubnetReq!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllAzureSubnets",
                "($subnetRequest: AzureSubnetReq!)",
                "List<System.String>",
                Query.AllAzureSubnets_ObjectFieldSpec,
                Query.AllAzureSubnetsFieldSpec,
                @"# REQUIRED
$inputs.Var.subnetRequest = @{
	# OPTIONAL
	cloudAccountId = <System.String>
	# OPTIONAL
	resourceGroup = <System.String>
	# OPTIONAL
	vnetName = <System.String>
}"
            );
        }

    } // class New-RscGqlQueryAllAzureSubnets
}