// New-RscGqlQueryClusterReportMigrationStatus.cs
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
    /// Create new GraphQL Query clusterReportMigrationStatus
    /// clusterReportMigrationStatus(
    ///     clusterUuid: UUID
    ///     status: [CdmReportMigrationStatus!]!
    ///     first: Int
    ///     after: String
    ///     last: Int
    ///     before: String
    ///   ): ReportMigrationStatusConnection!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlQueryClusterReportMigrationStatus")
    ]
    public class New_RscGqlQueryClusterReportMigrationStatus : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("clusterReportMigrationStatus");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Query clusterReportMigrationStatus
        /// clusterReportMigrationStatus(
        ///     clusterUuid: UUID
        ///     status: [CdmReportMigrationStatus!]!
        ///     first: Int
        ///     after: String
        ///     last: Int
        ///     before: String
        ///   ): ReportMigrationStatusConnection!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_clusterReportMigrationStatus();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_clusterReportMigrationStatus()
        {
            this._logger.name += " -clusterReportMigrationStatus";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("clusterUuid", "UUID"),
                Tuple.Create("status", "[CdmReportMigrationStatus!]!"),
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryClusterReportMigrationStatus",
                "($clusterUuid: UUID,$status: [CdmReportMigrationStatus!]!,$first: Int,$after: String,$last: Int,$before: String)",
                "ReportMigrationStatusConnection",
                Query.ClusterReportMigrationStatus_ObjectFieldSpec,
                Query.ClusterReportMigrationStatusFieldSpec,
                @"# OPTIONAL
$inputs.Var.clusterUuid = <System.String>
# REQUIRED
$inputs.Var.status = @(
	<CdmReportMigrationStatus> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CdmReportMigrationStatus]) for enum values.
)
# OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# OPTIONAL
$inputs.Var.last = <System.Int32>
# OPTIONAL
$inputs.Var.before = <System.String>"
            );
        }

    } // class New-RscGqlQueryClusterReportMigrationStatus
}