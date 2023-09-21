// New-RscGqlQueryActivitySeries.cs
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
    /// Create new GraphQL Query activitySeries
    /// activitySeries(input: ActivitySeriesInput!): ActivitySeries!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlQueryActivitySeries")
    ]
    public class New_RscGqlQueryActivitySeries : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("activitySeries");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Query activitySeries
        /// activitySeries(input: ActivitySeriesInput!): ActivitySeries!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_activitySeries();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_activitySeries()
        {
            this._logger.name += " -activitySeries";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "ActivitySeriesInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryActivitySeries",
                "($input: ActivitySeriesInput!)",
                "ActivitySeries",
                Query.ActivitySeries_ObjectFieldSpec,
                Query.ActivitySeriesFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	activitySeriesId = <System.String>
	# OPTIONAL
	clusterUuid = <System.String>
}"
            );
        }

    } // class New-RscGqlQueryActivitySeries
}