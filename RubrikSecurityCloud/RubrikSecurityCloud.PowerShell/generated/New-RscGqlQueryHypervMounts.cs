// New-RscGqlQueryHypervMounts.cs
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
    /// Create new GraphQL Query hypervMounts
    /// hypervMounts(
    ///     first: Int
    ///     after: String
    ///     filters: [HypervLiveMountFilterInput!]
    ///     sortBy: HypervLiveMountSortByInput
    ///   ): HyperVLiveMountConnection!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlQueryHypervMounts")
    ]
    public class New_RscGqlQueryHypervMounts : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("hypervMounts");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Query hypervMounts
        /// hypervMounts(
        ///     first: Int
        ///     after: String
        ///     filters: [HypervLiveMountFilterInput!]
        ///     sortBy: HypervLiveMountSortByInput
        ///   ): HyperVLiveMountConnection!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_hypervMounts();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_hypervMounts()
        {
            this._logger.name += " -hypervMounts";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("filters", "[HypervLiveMountFilterInput!]"),
                Tuple.Create("sortBy", "HypervLiveMountSortByInput"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryHypervMounts",
                "($first: Int,$after: String,$filters: [HypervLiveMountFilterInput!],$sortBy: HypervLiveMountSortByInput)",
                "HyperVliveMountConnection",
                Query.HypervMounts_ObjectFieldSpec,
                Query.HypervMountsFieldSpec,
                @"# OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# OPTIONAL
$inputs.Var.filters = @(
	@{
		# OPTIONAL
		field = <HypervLiveMountFilterField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HypervLiveMountFilterField]) for enum values.
		# OPTIONAL
		texts = @(
			<System.String>
		)
}
)
# OPTIONAL
$inputs.Var.sortBy = @{
	# OPTIONAL
	field = <HypervLiveMountSortByField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HypervLiveMountSortByField]) for enum values.
	# OPTIONAL
	sortOrder = <SortOrder> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
}"
            );
        }

    } // class New-RscGqlQueryHypervMounts
}