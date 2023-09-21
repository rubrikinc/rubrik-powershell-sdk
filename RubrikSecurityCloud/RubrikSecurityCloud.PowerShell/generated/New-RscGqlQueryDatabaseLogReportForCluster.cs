// New-RscGqlQueryDatabaseLogReportForCluster.cs
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
    /// Create new GraphQL Query databaseLogReportForCluster
    /// databaseLogReportForCluster(input: QueryLogReportInput!): DbLogReportSummaryListReply!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlQueryDatabaseLogReportForCluster")
    ]
    public class New_RscGqlQueryDatabaseLogReportForCluster : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("databaseLogReportForCluster");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Query databaseLogReportForCluster
        /// databaseLogReportForCluster(input: QueryLogReportInput!): DbLogReportSummaryListReply!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_databaseLogReportForCluster();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_databaseLogReportForCluster()
        {
            this._logger.name += " -databaseLogReportForCluster";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "QueryLogReportInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryDatabaseLogReportForCluster",
                "($input: QueryLogReportInput!)",
                "DbLogReportSummaryListReply",
                Query.DatabaseLogReportForCluster_ObjectFieldSpec,
                Query.DatabaseLogReportForClusterFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# OPTIONAL
	name = <System.String>
	# OPTIONAL
	logBackupDelay = <System.Int32>
	# OPTIONAL
	limit = <System.Int32>
	# OPTIONAL
	offset = <System.Int32>
	# OPTIONAL
	effectiveSlaDomainId = <System.String>
	# OPTIONAL
	databaseType = <System.String>
	# OPTIONAL
	location = <System.String>
	# OPTIONAL
	sortBy = <V1QueryLogReportRequestSortBy> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.V1QueryLogReportRequestSortBy]) for enum values.
	# OPTIONAL
	sortOrder = <V1QueryLogReportRequestSortOrder> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.V1QueryLogReportRequestSortOrder]) for enum values.
	# REQUIRED
	clusterUuid = <System.String>
}"
            );
        }

    } // class New-RscGqlQueryDatabaseLogReportForCluster
}