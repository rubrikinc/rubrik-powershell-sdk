// Invoke-RscGqlQueryCdmMssqlLogShippingTargets.cs
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
    /// Invoke GraphQL Query cdmMssqlLogShippingTargets
    /// cdmMssqlLogShippingTargets(
    ///     first: Int
    ///     after: String
    ///     sortBy: MssqlLogShippingTargetSortByInput
    ///     filters: [MssqlLogShippingTargetFilterInput!]
    ///   ): MssqlLogShippingTargetConnection!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "Invoke",
        "RscGqlQueryCdmMssqlLogShippingTargets")
    ]
    public class Invoke_RscGqlQueryCdmMssqlLogShippingTargets : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the Invoke-RscGqlQuery* cmdlets
        // fit in the Invoke-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("cdmMssqlLogShippingTargets");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Invoke GraphQL Query cdmMssqlLogShippingTargets
        /// cdmMssqlLogShippingTargets(
        ///     first: Int
        ///     after: String
        ///     sortBy: MssqlLogShippingTargetSortByInput
        ///     filters: [MssqlLogShippingTargetFilterInput!]
        ///   ): MssqlLogShippingTargetConnection!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_cdmMssqlLogShippingTargets();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_cdmMssqlLogShippingTargets()
        {
            this._logger.name += " -cdmMssqlLogShippingTargets";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("sortBy", "MssqlLogShippingTargetSortByInput"),
                Tuple.Create("filters", "[MssqlLogShippingTargetFilterInput!]"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryCdmMssqlLogShippingTargets",
                "($first: Int,$after: String,$sortBy: MssqlLogShippingTargetSortByInput,$filters: [MssqlLogShippingTargetFilterInput!])",
                "MssqlLogShippingTargetConnection",
                Query.CdmMssqlLogShippingTargets_ObjectFieldSpec,
                Query.CdmMssqlLogShippingTargetsFieldSpec,
                @"# OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# OPTIONAL
$inputs.Var.sortBy = @{
	# OPTIONAL
	field = <MssqlLogShippingTargetSortByField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.MssqlLogShippingTargetSortByField]) for enum values.
	# OPTIONAL
	sortOrder = <SortOrder> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
}
# OPTIONAL
$inputs.Var.filters = @(
	@{
		# OPTIONAL
		field = <MssqlLogShippingTargetFilterField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.MssqlLogShippingTargetFilterField]) for enum values.
		# OPTIONAL
		texts = @(
			<System.String>
		)
}
)"
            );
        }

    } // class Invoke-RscGqlQueryCdmMssqlLogShippingTargets
}