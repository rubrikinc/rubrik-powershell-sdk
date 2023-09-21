// New-RscGqlQueryAllSlaSummariesByIds.cs
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
    /// Create new GraphQL Query allSlaSummariesByIds
    /// allSlaSummariesByIds(slaIds: [UUID!]!): [SlaDomain!]!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlQueryAllSlaSummariesByIds")
    ]
    public class New_RscGqlQueryAllSlaSummariesByIds : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("allSlaSummariesByIds");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Query allSlaSummariesByIds
        /// allSlaSummariesByIds(slaIds: [UUID!]!): [SlaDomain!]!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_allSlaSummariesByIds();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_allSlaSummariesByIds()
        {
            this._logger.name += " -allSlaSummariesByIds";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("slaIds", "[UUID!]!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllSlaSummariesByIds",
                "($slaIds: [UUID!]!)",
                "List<SlaDomain>",
                Query.AllSlaSummariesByIds_ObjectFieldSpec,
                Query.AllSlaSummariesByIdsFieldSpec,
                @"# REQUIRED
$inputs.Var.slaIds = @(
	<System.String>
)"
            );
        }

    } // class New-RscGqlQueryAllSlaSummariesByIds
}