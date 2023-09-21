// New-RscGqlQueryAllClusterGlobalSlas.cs
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
    /// Create new GraphQL Query allClusterGlobalSlas
    /// allClusterGlobalSlas(cdmClusterUUID: UUID!): [SlaInfo!]!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlQueryAllClusterGlobalSlas")
    ]
    public class New_RscGqlQueryAllClusterGlobalSlas : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
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
        /// Create new GraphQL Query allClusterGlobalSlas
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

    } // class New-RscGqlQueryAllClusterGlobalSlas
}