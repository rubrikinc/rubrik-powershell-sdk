// New-RscGqlQueryAllAzureVnets.cs
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
    /// Create new GraphQL Query allAzureVnets
    /// allAzureVnets(vnetRequest: AzureVnetReq!): [String!]!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlQueryAllAzureVnets")
    ]
    public class New_RscGqlQueryAllAzureVnets : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("allAzureVnets");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Query allAzureVnets
        /// allAzureVnets(vnetRequest: AzureVnetReq!): [String!]!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_allAzureVnets();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_allAzureVnets()
        {
            this._logger.name += " -allAzureVnets";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("vnetRequest", "AzureVnetReq!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllAzureVnets",
                "($vnetRequest: AzureVnetReq!)",
                "List<System.String>",
                Query.AllAzureVnets_ObjectFieldSpec,
                Query.AllAzureVnetsFieldSpec,
                @"# REQUIRED
$inputs.Var.vnetRequest = @{
	# OPTIONAL
	cloudAccountId = <System.String>
	# OPTIONAL
	resourceGroup = <System.String>
}"
            );
        }

    } // class New-RscGqlQueryAllAzureVnets
}