// Invoke-RscGqlQueryGlobalSlaStatuses.cs
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
    /// Invoke GraphQL Query globalSlaStatuses
    /// globalSlaStatuses(
    ///     first: Int
    ///     after: String
    ///     last: Int
    ///     before: String
    ///     filter: [SlaStatusFilterInput!]
    ///     SlaId: UUID!
    ///   ): GlobalSlaStatusConnection!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "Invoke",
        "RscGqlQueryGlobalSlaStatuses")
    ]
    public class Invoke_RscGqlQueryGlobalSlaStatuses : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the Invoke-RscGqlQuery* cmdlets
        // fit in the Invoke-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("globalSlaStatuses");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Invoke GraphQL Query globalSlaStatuses
        /// globalSlaStatuses(
        ///     first: Int
        ///     after: String
        ///     last: Int
        ///     before: String
        ///     filter: [SlaStatusFilterInput!]
        ///     SlaId: UUID!
        ///   ): GlobalSlaStatusConnection!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_globalSlaStatuses();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_globalSlaStatuses()
        {
            this._logger.name += " -globalSlaStatuses";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("filter", "[SlaStatusFilterInput!]"),
                Tuple.Create("SlaId", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryGlobalSlaStatuses",
                "($first: Int,$after: String,$last: Int,$before: String,$filter: [SlaStatusFilterInput!],$SlaId: UUID!)",
                "GlobalSlaStatusConnection",
                Query.GlobalSlaStatuses_ObjectFieldSpec,
                Query.GlobalSlaStatusesFieldSpec,
                @"# OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# OPTIONAL
$inputs.Var.last = <System.Int32>
# OPTIONAL
$inputs.Var.before = <System.String>
# OPTIONAL
$inputs.Var.filter = @(
	@{
		# OPTIONAL
		field = <SlaStatusFilterField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SlaStatusFilterField]) for enum values.
		# OPTIONAL
		text = <System.String>
}
)
# REQUIRED
$inputs.Var.SlaId = <System.String>"
            );
        }

    } // class Invoke-RscGqlQueryGlobalSlaStatuses
}