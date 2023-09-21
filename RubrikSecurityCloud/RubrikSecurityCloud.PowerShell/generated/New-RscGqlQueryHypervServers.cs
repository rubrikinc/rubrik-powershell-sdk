// New-RscGqlQueryHypervServers.cs
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
    /// Create new GraphQL Query hypervServers
    /// hypervServers(input: QueryHypervHostInput!): HypervHostSummaryListResponse!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlQueryHypervServers")
    ]
    public class New_RscGqlQueryHypervServers : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("hypervServers");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Query hypervServers
        /// hypervServers(input: QueryHypervHostInput!): HypervHostSummaryListResponse!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_hypervServers();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_hypervServers()
        {
            this._logger.name += " -hypervServers";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "QueryHypervHostInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryHypervServers",
                "($input: QueryHypervHostInput!)",
                "HypervHostSummaryListResponse",
                Query.HypervServers_ObjectFieldSpec,
                Query.HypervServersFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# OPTIONAL
	effectiveSlaDomainId = <System.String>
	# OPTIONAL
	limit = <System.Int32>
	# OPTIONAL
	name = <System.String>
	# OPTIONAL
	offset = <System.Int32>
	# OPTIONAL
	primaryClusterId = <System.String>
	# OPTIONAL
	slaAssignment = <InternalQueryHypervHostRequestSlaAssignment> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.InternalQueryHypervHostRequestSlaAssignment]) for enum values.
	# OPTIONAL
	sortBy = <InternalQueryHypervHostRequestSortBy> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.InternalQueryHypervHostRequestSortBy]) for enum values.
	# OPTIONAL
	sortOrder = <InternalQueryHypervHostRequestSortOrder> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.InternalQueryHypervHostRequestSortOrder]) for enum values.
	# REQUIRED
	clusterUuid = <System.String>
}"
            );
        }

    } // class New-RscGqlQueryHypervServers
}