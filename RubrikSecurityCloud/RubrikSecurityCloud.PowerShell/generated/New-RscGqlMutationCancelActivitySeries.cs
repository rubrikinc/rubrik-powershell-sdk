// New-RscGqlMutationCancelActivitySeries.cs
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
    /// Create new GraphQL Mutation cancelActivitySeries
    /// cancelActivitySeries(input: CancelActivitySeriesInput!): Boolean!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlMutationCancelActivitySeries")
    ]
    public class New_RscGqlMutationCancelActivitySeries : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("cancelActivitySeries");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Mutation cancelActivitySeries
        /// cancelActivitySeries(input: CancelActivitySeriesInput!): Boolean!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_cancelActivitySeries();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_cancelActivitySeries()
        {
            this._logger.name += " -cancelActivitySeries";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CancelActivitySeriesInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCancelActivitySeries",
                "($input: CancelActivitySeriesInput!)",
                "System.Boolean",
                Mutation.CancelActivitySeries_ObjectFieldSpec,
                Mutation.CancelActivitySeriesFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	activitySeriesId = <System.String>
	# REQUIRED
	clusterUuid = <System.String>
}"
            );
        }

    } // class New-RscGqlMutationCancelActivitySeries
}