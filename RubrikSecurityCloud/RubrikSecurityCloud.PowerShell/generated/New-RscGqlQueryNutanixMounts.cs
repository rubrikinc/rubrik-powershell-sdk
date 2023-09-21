// New-RscGqlQueryNutanixMounts.cs
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
    /// Create new GraphQL Query nutanixMounts
    /// nutanixMounts(
    ///     first: Int
    ///     after: String
    ///     filters: [NutanixLiveMountFilterInput!]
    ///     sortBy: NutanixLiveMountSortByInput
    ///   ): NutanixLiveMountConnection!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlQueryNutanixMounts")
    ]
    public class New_RscGqlQueryNutanixMounts : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("nutanixMounts");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Query nutanixMounts
        /// nutanixMounts(
        ///     first: Int
        ///     after: String
        ///     filters: [NutanixLiveMountFilterInput!]
        ///     sortBy: NutanixLiveMountSortByInput
        ///   ): NutanixLiveMountConnection!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_nutanixMounts();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_nutanixMounts()
        {
            this._logger.name += " -nutanixMounts";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("filters", "[NutanixLiveMountFilterInput!]"),
                Tuple.Create("sortBy", "NutanixLiveMountSortByInput"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryNutanixMounts",
                "($first: Int,$after: String,$filters: [NutanixLiveMountFilterInput!],$sortBy: NutanixLiveMountSortByInput)",
                "NutanixLiveMountConnection",
                Query.NutanixMounts_ObjectFieldSpec,
                Query.NutanixMountsFieldSpec,
                @"# OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# OPTIONAL
$inputs.Var.filters = @(
	@{
		# OPTIONAL
		field = <NutanixLiveMountFilterField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.NutanixLiveMountFilterField]) for enum values.
		# OPTIONAL
		texts = @(
			<System.String>
		)
}
)
# OPTIONAL
$inputs.Var.sortBy = @{
	# OPTIONAL
	field = <NutanixLiveMountSortByField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.NutanixLiveMountSortByField]) for enum values.
	# OPTIONAL
	sortOrder = <SortOrder> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
}"
            );
        }

    } // class New-RscGqlQueryNutanixMounts
}