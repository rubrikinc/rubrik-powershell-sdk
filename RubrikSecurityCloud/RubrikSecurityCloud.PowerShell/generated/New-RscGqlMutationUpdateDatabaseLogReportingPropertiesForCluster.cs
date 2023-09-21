// New-RscGqlMutationUpdateDatabaseLogReportingPropertiesForCluster.cs
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
    /// Create new GraphQL Mutation updateDatabaseLogReportingPropertiesForCluster
    /// updateDatabaseLogReportingPropertiesForCluster(input: UpdateDatabaseLogReportingPropertiesForClusterInput!): DbLogReportProperties!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlMutationUpdateDatabaseLogReportingPropertiesForCluster")
    ]
    public class New_RscGqlMutationUpdateDatabaseLogReportingPropertiesForCluster : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("updateDatabaseLogReportingPropertiesForCluster");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Mutation updateDatabaseLogReportingPropertiesForCluster
        /// updateDatabaseLogReportingPropertiesForCluster(input: UpdateDatabaseLogReportingPropertiesForClusterInput!): DbLogReportProperties!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_updateDatabaseLogReportingPropertiesForCluster();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_updateDatabaseLogReportingPropertiesForCluster()
        {
            this._logger.name += " -updateDatabaseLogReportingPropertiesForCluster";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateDatabaseLogReportingPropertiesForClusterInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateDatabaseLogReportingPropertiesForCluster",
                "($input: UpdateDatabaseLogReportingPropertiesForClusterInput!)",
                "DbLogReportProperties",
                Mutation.UpdateDatabaseLogReportingPropertiesForCluster_ObjectFieldSpec,
                Mutation.UpdateDatabaseLogReportingPropertiesForClusterFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	clusterUuid = <System.String>
	# REQUIRED
	properties = @{
		# OPTIONAL
		enableDelayNotification = <System.Boolean>
		# OPTIONAL
		logDelayThresholdInMin = <System.Int64>
		# OPTIONAL
		logDelayNotificationFrequencyInMin = <System.Int64>
	}
}"
            );
        }

    } // class New-RscGqlMutationUpdateDatabaseLogReportingPropertiesForCluster
}