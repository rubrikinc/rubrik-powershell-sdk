// Invoke-RscGqlQueryAllClusterGlobalSlas.cs
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
    /// Invoke GraphQL Query allClusterGlobalSlas
    /// allClusterGlobalSlas(cdmClusterUUID: UUID!): [SlaInfo!]!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "Invoke",
        "RscGqlQueryAllClusterGlobalSlas")
    ]
    public class Invoke_RscGqlQueryAllClusterGlobalSlas : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the Invoke-RscGqlQuery* cmdlets
        // fit in the Invoke-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("allClusterGlobalSlas");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Invoke GraphQL Query allClusterGlobalSlas
        /// allClusterGlobalSlas(cdmClusterUUID: UUID!): [SlaInfo!]!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_allClusterGlobalSlas();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_allClusterGlobalSlas()
        {
            this._logger.name += " -allClusterGlobalSlas";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("cdmClusterUUID", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllClusterGlobalSlas",
                "($cdmClusterUUID: UUID!)",
                "List<SlaInfo>",
                Query.AllClusterGlobalSlas_ObjectFieldSpec,
                Query.AllClusterGlobalSlasFieldSpec,
                @"# REQUIRED
$inputs.Var.cdmClusterUUID = <System.String>"
            );
        }

    } // class Invoke-RscGqlQueryAllClusterGlobalSlas
}