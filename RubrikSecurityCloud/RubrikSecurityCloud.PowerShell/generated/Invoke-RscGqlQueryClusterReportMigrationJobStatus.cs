// Invoke-RscGqlQueryClusterReportMigrationJobStatus.cs
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
    /// Invoke GraphQL Query clusterReportMigrationJobStatus
    /// clusterReportMigrationJobStatus(clusterUuid: UUID): ClusterReportMigrationJobStatus!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "Invoke",
        "RscGqlQueryClusterReportMigrationJobStatus")
    ]
    public class Invoke_RscGqlQueryClusterReportMigrationJobStatus : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the Invoke-RscGqlQuery* cmdlets
        // fit in the Invoke-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("clusterReportMigrationJobStatus");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Invoke GraphQL Query clusterReportMigrationJobStatus
        /// clusterReportMigrationJobStatus(clusterUuid: UUID): ClusterReportMigrationJobStatus!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_clusterReportMigrationJobStatus();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_clusterReportMigrationJobStatus()
        {
            this._logger.name += " -clusterReportMigrationJobStatus";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("clusterUuid", "UUID"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryClusterReportMigrationJobStatus",
                "($clusterUuid: UUID)",
                "ClusterReportMigrationJobStatus",
                Query.ClusterReportMigrationJobStatus_ObjectFieldSpec,
                Query.ClusterReportMigrationJobStatusFieldSpec,
                @"# OPTIONAL
$inputs.Var.clusterUuid = <System.String>"
            );
        }

    } // class Invoke-RscGqlQueryClusterReportMigrationJobStatus
}