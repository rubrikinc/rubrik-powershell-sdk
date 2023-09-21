// New-RscGqlQueryAllAzureExocomputeConfigsInAccount.cs
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
    /// Create new GraphQL Query allAzureExocomputeConfigsInAccount
    /// allAzureExocomputeConfigsInAccount(azureExocomputeSearchQuery: String, cloudAccountIDs: [UUID!]): [AzureExocomputeConfigsInAccount!]!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlQueryAllAzureExocomputeConfigsInAccount")
    ]
    public class New_RscGqlQueryAllAzureExocomputeConfigsInAccount : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("allAzureExocomputeConfigsInAccount");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Query allAzureExocomputeConfigsInAccount
        /// allAzureExocomputeConfigsInAccount(azureExocomputeSearchQuery: String, cloudAccountIDs: [UUID!]): [AzureExocomputeConfigsInAccount!]!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_allAzureExocomputeConfigsInAccount();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_allAzureExocomputeConfigsInAccount()
        {
            this._logger.name += " -allAzureExocomputeConfigsInAccount";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("azureExocomputeSearchQuery", "String"),
                Tuple.Create("cloudAccountIDs", "[UUID!]"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllAzureExocomputeConfigsInAccount",
                "($azureExocomputeSearchQuery: String,$cloudAccountIDs: [UUID!])",
                "List<AzureExocomputeConfigsInAccount>",
                Query.AllAzureExocomputeConfigsInAccount_ObjectFieldSpec,
                Query.AllAzureExocomputeConfigsInAccountFieldSpec,
                @"# OPTIONAL
$inputs.Var.azureExocomputeSearchQuery = <System.String>
# OPTIONAL
$inputs.Var.cloudAccountIDs = @(
	<System.String>
)"
            );
        }

    } // class New-RscGqlQueryAllAzureExocomputeConfigsInAccount
}