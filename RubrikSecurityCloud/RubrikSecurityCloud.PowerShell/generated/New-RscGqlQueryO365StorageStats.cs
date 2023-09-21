// New-RscGqlQueryO365StorageStats.cs
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
    /// Create new GraphQL Query o365StorageStats
    /// o365StorageStats(orgID: UUID): GetO365StorageStatsResp!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlQueryO365StorageStats")
    ]
    public class New_RscGqlQueryO365StorageStats : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("o365StorageStats");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Query o365StorageStats
        /// o365StorageStats(orgID: UUID): GetO365StorageStatsResp!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_o365StorageStats();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_o365StorageStats()
        {
            this._logger.name += " -o365StorageStats";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("orgID", "UUID"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryO365StorageStats",
                "($orgID: UUID)",
                "GetO365StorageStatsResp",
                Query.O365StorageStats_ObjectFieldSpec,
                Query.O365StorageStatsFieldSpec,
                @"# OPTIONAL
$inputs.Var.orgID = <System.String>"
            );
        }

    } // class New-RscGqlQueryO365StorageStats
}