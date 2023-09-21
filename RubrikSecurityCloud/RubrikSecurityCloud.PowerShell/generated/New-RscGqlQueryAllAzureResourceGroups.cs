// New-RscGqlQueryAllAzureResourceGroups.cs
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
    /// Create new GraphQL Query allAzureResourceGroups
    /// allAzureResourceGroups(cloudAccountId: String!, azureRegion: String!): [String!]!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlQueryAllAzureResourceGroups")
    ]
    public class New_RscGqlQueryAllAzureResourceGroups : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("allAzureResourceGroups");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Query allAzureResourceGroups
        /// allAzureResourceGroups(cloudAccountId: String!, azureRegion: String!): [String!]!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_allAzureResourceGroups();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_allAzureResourceGroups()
        {
            this._logger.name += " -allAzureResourceGroups";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("cloudAccountId", "String!"),
                Tuple.Create("azureRegion", "String!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllAzureResourceGroups",
                "($cloudAccountId: String!,$azureRegion: String!)",
                "List<System.String>",
                Query.AllAzureResourceGroups_ObjectFieldSpec,
                Query.AllAzureResourceGroupsFieldSpec,
                @"# REQUIRED
$inputs.Var.cloudAccountId = <System.String>
# REQUIRED
$inputs.Var.azureRegion = <System.String>"
            );
        }

    } // class New-RscGqlQueryAllAzureResourceGroups
}