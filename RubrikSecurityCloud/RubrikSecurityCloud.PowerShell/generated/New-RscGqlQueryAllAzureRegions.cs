// New-RscGqlQueryAllAzureRegions.cs
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
    /// Create new GraphQL Query allAzureRegions
    /// allAzureRegions(cloudAccountId: String!): [AzureCloudAccountRegion!]!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlQueryAllAzureRegions")
    ]
    public class New_RscGqlQueryAllAzureRegions : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("allAzureRegions");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Query allAzureRegions
        /// allAzureRegions(cloudAccountId: String!): [AzureCloudAccountRegion!]!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_allAzureRegions();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_allAzureRegions()
        {
            this._logger.name += " -allAzureRegions";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("cloudAccountId", "String!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllAzureRegions",
                "($cloudAccountId: String!)",
                "List<AzureCloudAccountRegion>",
                Query.AllAzureRegions_ObjectFieldSpec,
                Query.AllAzureRegionsFieldSpec,
                @"# REQUIRED
$inputs.Var.cloudAccountId = <System.String>"
            );
        }

    } // class New-RscGqlQueryAllAzureRegions
}