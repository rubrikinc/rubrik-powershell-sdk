// New-RscGqlQueryAllAzureNsgs.cs
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
    /// Create new GraphQL Query allAzureNsgs
    /// allAzureNsgs(nsgRequest: AzureNsgRequest!): [String!]!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlQueryAllAzureNsgs")
    ]
    public class New_RscGqlQueryAllAzureNsgs : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("allAzureNsgs");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Query allAzureNsgs
        /// allAzureNsgs(nsgRequest: AzureNsgRequest!): [String!]!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_allAzureNsgs();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_allAzureNsgs()
        {
            this._logger.name += " -allAzureNsgs";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("nsgRequest", "AzureNsgRequest!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllAzureNsgs",
                "($nsgRequest: AzureNsgRequest!)",
                "List<System.String>",
                Query.AllAzureNsgs_ObjectFieldSpec,
                Query.AllAzureNsgsFieldSpec,
                @"# REQUIRED
$inputs.Var.nsgRequest = @{
	# OPTIONAL
	cloudAccountId = <System.String>
	# OPTIONAL
	resourceGroup = <System.String>
}"
            );
        }

    } // class New-RscGqlQueryAllAzureNsgs
}