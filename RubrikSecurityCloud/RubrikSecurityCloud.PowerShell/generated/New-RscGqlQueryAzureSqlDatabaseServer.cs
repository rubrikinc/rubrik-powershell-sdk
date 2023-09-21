// New-RscGqlQueryAzureSqlDatabaseServer.cs
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
    /// Create new GraphQL Query azureSqlDatabaseServer
    /// azureSqlDatabaseServer(azureSqlDatabaseServerRubrikId: UUID!): AzureSqlDatabaseServer!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlQueryAzureSqlDatabaseServer")
    ]
    public class New_RscGqlQueryAzureSqlDatabaseServer : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("azureSqlDatabaseServer");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Query azureSqlDatabaseServer
        /// azureSqlDatabaseServer(azureSqlDatabaseServerRubrikId: UUID!): AzureSqlDatabaseServer!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_azureSqlDatabaseServer();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_azureSqlDatabaseServer()
        {
            this._logger.name += " -azureSqlDatabaseServer";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("azureSqlDatabaseServerRubrikId", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAzureSqlDatabaseServer",
                "($azureSqlDatabaseServerRubrikId: UUID!)",
                "AzureSqlDatabaseServer",
                Query.AzureSqlDatabaseServer_ObjectFieldSpec,
                Query.AzureSqlDatabaseServerFieldSpec,
                @"# REQUIRED
$inputs.Var.azureSqlDatabaseServerRubrikId = <System.String>"
            );
        }

    } // class New-RscGqlQueryAzureSqlDatabaseServer
}