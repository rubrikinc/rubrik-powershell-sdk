// New-RscGqlQueryDatabaseLogReportingPropertiesForCluster.cs
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
    /// Create new GraphQL Query databaseLogReportingPropertiesForCluster
    /// databaseLogReportingPropertiesForCluster(input: QueryReportPropertiesInput!): DbLogReportProperties!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlQueryDatabaseLogReportingPropertiesForCluster")
    ]
    public class New_RscGqlQueryDatabaseLogReportingPropertiesForCluster : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("databaseLogReportingPropertiesForCluster");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Query databaseLogReportingPropertiesForCluster
        /// databaseLogReportingPropertiesForCluster(input: QueryReportPropertiesInput!): DbLogReportProperties!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_databaseLogReportingPropertiesForCluster();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_databaseLogReportingPropertiesForCluster()
        {
            this._logger.name += " -databaseLogReportingPropertiesForCluster";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "QueryReportPropertiesInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryDatabaseLogReportingPropertiesForCluster",
                "($input: QueryReportPropertiesInput!)",
                "DbLogReportProperties",
                Query.DatabaseLogReportingPropertiesForCluster_ObjectFieldSpec,
                Query.DatabaseLogReportingPropertiesForClusterFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	clusterUuid = <System.String>
}"
            );
        }

    } // class New-RscGqlQueryDatabaseLogReportingPropertiesForCluster
}