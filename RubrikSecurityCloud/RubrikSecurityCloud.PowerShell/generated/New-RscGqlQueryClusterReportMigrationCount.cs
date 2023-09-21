// New-RscGqlQueryClusterReportMigrationCount.cs
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
    /// Create new GraphQL Query clusterReportMigrationCount
    /// clusterReportMigrationCount(clusterUuid: UUID, status: [CdmReportMigrationStatus!]!): ReportsMigrationCount!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlQueryClusterReportMigrationCount")
    ]
    public class New_RscGqlQueryClusterReportMigrationCount : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("clusterReportMigrationCount");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Query clusterReportMigrationCount
        /// clusterReportMigrationCount(clusterUuid: UUID, status: [CdmReportMigrationStatus!]!): ReportsMigrationCount!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_clusterReportMigrationCount();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_clusterReportMigrationCount()
        {
            this._logger.name += " -clusterReportMigrationCount";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("clusterUuid", "UUID"),
                Tuple.Create("status", "[CdmReportMigrationStatus!]!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryClusterReportMigrationCount",
                "($clusterUuid: UUID,$status: [CdmReportMigrationStatus!]!)",
                "ReportsMigrationCount",
                Query.ClusterReportMigrationCount_ObjectFieldSpec,
                Query.ClusterReportMigrationCountFieldSpec,
                @"# OPTIONAL
$inputs.Var.clusterUuid = <System.String>
# REQUIRED
$inputs.Var.status = @(
	<CdmReportMigrationStatus> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CdmReportMigrationStatus]) for enum values.
)"
            );
        }

    } // class New-RscGqlQueryClusterReportMigrationCount
}