// New-RscGqlQueryMssqlLogShippingTargets.cs
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
    /// Create new GraphQL Query mssqlLogShippingTargets
    /// mssqlLogShippingTargets(input: QueryLogShippingConfigurationsV2Input!): MssqlLogShippingSummaryV2ListResponse
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlQueryMssqlLogShippingTargets")
    ]
    public class New_RscGqlQueryMssqlLogShippingTargets : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("mssqlLogShippingTargets");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Query mssqlLogShippingTargets
        /// mssqlLogShippingTargets(input: QueryLogShippingConfigurationsV2Input!): MssqlLogShippingSummaryV2ListResponse
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_mssqlLogShippingTargets();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_mssqlLogShippingTargets()
        {
            this._logger.name += " -mssqlLogShippingTargets";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "QueryLogShippingConfigurationsV2Input!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryMssqlLogShippingTargets",
                "($input: QueryLogShippingConfigurationsV2Input!)",
                "MssqlLogShippingSummaryV2ListResponse",
                Query.MssqlLogShippingTargets_ObjectFieldSpec,
                Query.MssqlLogShippingTargetsFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# OPTIONAL
	limit = <System.Int32>
	# OPTIONAL
	location = <System.String>
	# OPTIONAL
	offset = <System.Int32>
	# OPTIONAL
	primaryDatabaseId = <System.String>
	# OPTIONAL
	primaryDatabaseName = <System.String>
	# OPTIONAL
	secondaryDatabaseName = <System.String>
	# OPTIONAL
	sortBy = <V2QueryLogShippingConfigurationsV2RequestSortBy> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.V2QueryLogShippingConfigurationsV2RequestSortBy]) for enum values.
	# OPTIONAL
	sortOrder = <V2QueryLogShippingConfigurationsV2RequestSortOrder> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.V2QueryLogShippingConfigurationsV2RequestSortOrder]) for enum values.
	# OPTIONAL
	status = <V2QueryLogShippingConfigurationsV2RequestStatus> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.V2QueryLogShippingConfigurationsV2RequestStatus]) for enum values.
	# REQUIRED
	clusterUuid = <System.String>
}"
            );
        }

    } // class New-RscGqlQueryMssqlLogShippingTargets
}