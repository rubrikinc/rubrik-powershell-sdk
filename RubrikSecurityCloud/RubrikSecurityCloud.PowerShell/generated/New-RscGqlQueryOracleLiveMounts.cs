// New-RscGqlQueryOracleLiveMounts.cs
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
    /// Create new GraphQL Query oracleLiveMounts
    /// oracleLiveMounts(
    ///     first: Int
    ///     after: String
    ///     filters: [OracleLiveMountFilterInput!]
    ///     sortBy: OracleLiveMountSortBy
    ///   ): OracleLiveMountConnection!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlQueryOracleLiveMounts")
    ]
    public class New_RscGqlQueryOracleLiveMounts : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("oracleLiveMounts");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Query oracleLiveMounts
        /// oracleLiveMounts(
        ///     first: Int
        ///     after: String
        ///     filters: [OracleLiveMountFilterInput!]
        ///     sortBy: OracleLiveMountSortBy
        ///   ): OracleLiveMountConnection!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_oracleLiveMounts();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_oracleLiveMounts()
        {
            this._logger.name += " -oracleLiveMounts";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("filters", "[OracleLiveMountFilterInput!]"),
                Tuple.Create("sortBy", "OracleLiveMountSortBy"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryOracleLiveMounts",
                "($first: Int,$after: String,$filters: [OracleLiveMountFilterInput!],$sortBy: OracleLiveMountSortBy)",
                "OracleLiveMountConnection",
                Query.OracleLiveMounts_ObjectFieldSpec,
                Query.OracleLiveMountsFieldSpec,
                @"# OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# OPTIONAL
$inputs.Var.filters = @(
	@{
		# OPTIONAL
		field = <OracleLiveMountFilterField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.OracleLiveMountFilterField]) for enum values.
		# OPTIONAL
		texts = @(
			<System.String>
		)
}
)
# OPTIONAL
$inputs.Var.sortBy = @{
	# OPTIONAL
	field = <OracleLiveMountSortByField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.OracleLiveMountSortByField]) for enum values.
	# OPTIONAL
	sortOrder = <SortOrder> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
}"
            );
        }

    } // class New-RscGqlQueryOracleLiveMounts
}