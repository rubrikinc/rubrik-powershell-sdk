// Invoke-RscGqlQuerySlaDomain.cs
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
    /// Invoke GraphQL Query slaDomain
    /// slaDomain(
    ///     id: UUID!
    ///     shouldShowSyncStatus: Boolean = false
    ///     shouldShowUpgradeInfo: Boolean = false
    ///     shouldShowPausedClusters: Boolean = false
    ///   ): SlaDomain!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "Invoke",
        "RscGqlQuerySlaDomain")
    ]
    public class Invoke_RscGqlQuerySlaDomain : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the Invoke-RscGqlQuery* cmdlets
        // fit in the Invoke-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("slaDomain");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Invoke GraphQL Query slaDomain
        /// slaDomain(
        ///     id: UUID!
        ///     shouldShowSyncStatus: Boolean = false
        ///     shouldShowUpgradeInfo: Boolean = false
        ///     shouldShowPausedClusters: Boolean = false
        ///   ): SlaDomain!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_slaDomain();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_slaDomain()
        {
            this._logger.name += " -slaDomain";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("id", "UUID!"),
                Tuple.Create("shouldShowSyncStatus", "Boolean"),
                Tuple.Create("shouldShowUpgradeInfo", "Boolean"),
                Tuple.Create("shouldShowPausedClusters", "Boolean"),
            };
            Initialize(
                argDefs,
                "query",
                "QuerySlaDomain",
                "($id: UUID!,$shouldShowSyncStatus: Boolean,$shouldShowUpgradeInfo: Boolean,$shouldShowPausedClusters: Boolean)",
                "SlaDomain",
                Query.SlaDomain_ObjectFieldSpec,
                Query.SlaDomainFieldSpec,
                @"# REQUIRED
$inputs.Var.id = <System.String>
# OPTIONAL
$inputs.Var.shouldShowSyncStatus = <System.Boolean>
# OPTIONAL
$inputs.Var.shouldShowUpgradeInfo = <System.Boolean>
# OPTIONAL
$inputs.Var.shouldShowPausedClusters = <System.Boolean>"
            );
        }

    } // class Invoke-RscGqlQuerySlaDomain
}