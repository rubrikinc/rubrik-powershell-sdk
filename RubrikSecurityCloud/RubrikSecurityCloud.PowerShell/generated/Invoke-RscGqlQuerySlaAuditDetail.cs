// Invoke-RscGqlQuerySlaAuditDetail.cs
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
    /// Invoke GraphQL Query slaAuditDetail
    /// slaAuditDetail(
    ///     first: Int
    ///     after: String
    ///     last: Int
    ///     before: String
    ///     SlaId: UUID!
    ///     filter: [SLAAuditDetailFilterInput!]
    ///     timezone: String
    ///   ): [SlaAuditDetail!]!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "Invoke",
        "RscGqlQuerySlaAuditDetail")
    ]
    public class Invoke_RscGqlQuerySlaAuditDetail : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the Invoke-RscGqlQuery* cmdlets
        // fit in the Invoke-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("slaAuditDetail");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Invoke GraphQL Query slaAuditDetail
        /// slaAuditDetail(
        ///     first: Int
        ///     after: String
        ///     last: Int
        ///     before: String
        ///     SlaId: UUID!
        ///     filter: [SLAAuditDetailFilterInput!]
        ///     timezone: String
        ///   ): [SlaAuditDetail!]!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_slaAuditDetail();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_slaAuditDetail()
        {
            this._logger.name += " -slaAuditDetail";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("SlaId", "UUID!"),
                Tuple.Create("filter", "[SLAAuditDetailFilterInput!]"),
                Tuple.Create("timezone", "String"),
            };
            Initialize(
                argDefs,
                "query",
                "QuerySlaAuditDetail",
                "($first: Int,$after: String,$last: Int,$before: String,$SlaId: UUID!,$filter: [SLAAuditDetailFilterInput!],$timezone: String)",
                "List<SlaAuditDetail>",
                Query.SlaAuditDetail_ObjectFieldSpec,
                Query.SlaAuditDetailFieldSpec,
                @"# OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# OPTIONAL
$inputs.Var.last = <System.Int32>
# OPTIONAL
$inputs.Var.before = <System.String>
# REQUIRED
$inputs.Var.SlaId = <System.String>
# OPTIONAL
$inputs.Var.filter = @(
	@{
		# OPTIONAL
		field = <SLAAuditDetailFilterFieldEnum> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SLAAuditDetailFilterFieldEnum]) for enum values.
		# OPTIONAL
		text = <System.String>
}
)
# OPTIONAL
$inputs.Var.timezone = <System.String>"
            );
        }

    } // class Invoke-RscGqlQuerySlaAuditDetail
}