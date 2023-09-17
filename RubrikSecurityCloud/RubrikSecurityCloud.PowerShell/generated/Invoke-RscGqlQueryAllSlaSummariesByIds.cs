// Invoke-RscGqlQueryAllSlaSummariesByIds.cs
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
    /// Invoke GraphQL Query allSlaSummariesByIds
    /// allSlaSummariesByIds(slaIds: [UUID!]!): [SlaDomain!]!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "Invoke",
        "RscGqlQueryAllSlaSummariesByIds")
    ]
    public class Invoke_RscGqlQueryAllSlaSummariesByIds : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the Invoke-RscGqlQuery* cmdlets
        // fit in the Invoke-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
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
        /// Invoke GraphQL Query allSlaSummariesByIds
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

    } // class Invoke-RscGqlQueryAllSlaSummariesByIds
}