// Invoke-RscGqlQuerySlaDomains.cs
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
    /// Invoke GraphQL Query slaDomains
    /// slaDomains(
    ///     first: Int
    ///     after: String
    ///     last: Int
    ///     before: String
    ///     sortBy: SlaQuerySortByField
    ///     sortOrder: SortOrder
    ///     filter: [GlobalSlaFilterInput!]
    ///     contextFilter: ContextFilterTypeEnum
    ///     contextFilterInput: [ContextFilterInputField!]
    ///     shouldShowSyncStatus: Boolean = false
    ///     shouldShowProtectedObjectCount: Boolean = false
    ///     shouldShowUpgradeInfo: Boolean = false
    ///     showRemoteSlas: Boolean
    ///     shouldShowPausedClusters: Boolean = false
    ///   ): SlaDomainConnection!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "Invoke",
        "RscGqlQuerySlaDomains")
    ]
    public class Invoke_RscGqlQuerySlaDomains : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the Invoke-RscGqlQuery* cmdlets
        // fit in the Invoke-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("slaDomains");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Invoke GraphQL Query slaDomains
        /// slaDomains(
        ///     first: Int
        ///     after: String
        ///     last: Int
        ///     before: String
        ///     sortBy: SlaQuerySortByField
        ///     sortOrder: SortOrder
        ///     filter: [GlobalSlaFilterInput!]
        ///     contextFilter: ContextFilterTypeEnum
        ///     contextFilterInput: [ContextFilterInputField!]
        ///     shouldShowSyncStatus: Boolean = false
        ///     shouldShowProtectedObjectCount: Boolean = false
        ///     shouldShowUpgradeInfo: Boolean = false
        ///     showRemoteSlas: Boolean
        ///     shouldShowPausedClusters: Boolean = false
        ///   ): SlaDomainConnection!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_slaDomains();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_slaDomains()
        {
            this._logger.name += " -slaDomains";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("sortBy", "SlaQuerySortByField"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("filter", "[GlobalSlaFilterInput!]"),
                Tuple.Create("contextFilter", "ContextFilterTypeEnum"),
                Tuple.Create("contextFilterInput", "[ContextFilterInputField!]"),
                Tuple.Create("shouldShowSyncStatus", "Boolean"),
                Tuple.Create("shouldShowProtectedObjectCount", "Boolean"),
                Tuple.Create("shouldShowUpgradeInfo", "Boolean"),
                Tuple.Create("showRemoteSlas", "Boolean"),
                Tuple.Create("shouldShowPausedClusters", "Boolean"),
            };
            Initialize(
                argDefs,
                "query",
                "QuerySlaDomains",
                "($first: Int,$after: String,$last: Int,$before: String,$sortBy: SlaQuerySortByField,$sortOrder: SortOrder,$filter: [GlobalSlaFilterInput!],$contextFilter: ContextFilterTypeEnum,$contextFilterInput: [ContextFilterInputField!],$shouldShowSyncStatus: Boolean,$shouldShowProtectedObjectCount: Boolean,$shouldShowUpgradeInfo: Boolean,$showRemoteSlas: Boolean,$shouldShowPausedClusters: Boolean)",
                "SlaDomainConnection",
                Query.SlaDomains_ObjectFieldSpec,
                Query.SlaDomainsFieldSpec,
                @"# OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# OPTIONAL
$inputs.Var.last = <System.Int32>
# OPTIONAL
$inputs.Var.before = <System.String>
# OPTIONAL
$inputs.Var.sortBy = <SlaQuerySortByField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SlaQuerySortByField]) for enum values.
# OPTIONAL
$inputs.Var.sortOrder = <SortOrder> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$inputs.Var.filter = @(
	@{
		# OPTIONAL
		field = <GlobalSlaQueryFilterInputField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.GlobalSlaQueryFilterInputField]) for enum values.
		# OPTIONAL
		text = <System.String>
		# OPTIONAL
		objectTypeList = @(
			<SlaObjectType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SlaObjectType]) for enum values.
		)
		# OPTIONAL
		textList = @(
			<System.String>
		)
}
)
# OPTIONAL
$inputs.Var.contextFilter = <ContextFilterTypeEnum> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ContextFilterTypeEnum]) for enum values.
# OPTIONAL
$inputs.Var.contextFilterInput = @(
	@{
		# REQUIRED
		field = <System.String>
		# REQUIRED
		text = <System.String>
}
)
# OPTIONAL
$inputs.Var.shouldShowSyncStatus = <System.Boolean>
# OPTIONAL
$inputs.Var.shouldShowProtectedObjectCount = <System.Boolean>
# OPTIONAL
$inputs.Var.shouldShowUpgradeInfo = <System.Boolean>
# OPTIONAL
$inputs.Var.showRemoteSlas = <System.Boolean>
# OPTIONAL
$inputs.Var.shouldShowPausedClusters = <System.Boolean>"
            );
        }

    } // class Invoke-RscGqlQuerySlaDomains
}