// New-RscGqlQueryAzureSqlManagedInstanceServer.cs
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
    /// Create new GraphQL Query azureSqlManagedInstanceServer
    /// azureSqlManagedInstanceServer(azureSqlManagedInstanceServerRubrikId: UUID!): AzureSqlManagedInstanceServer!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlQueryAzureSqlManagedInstanceServer")
    ]
    public class New_RscGqlQueryAzureSqlManagedInstanceServer : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("azureSqlManagedInstanceServer");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Query azureSqlManagedInstanceServer
        /// azureSqlManagedInstanceServer(azureSqlManagedInstanceServerRubrikId: UUID!): AzureSqlManagedInstanceServer!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_azureSqlManagedInstanceServer();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_azureSqlManagedInstanceServer()
        {
            this._logger.name += " -azureSqlManagedInstanceServer";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("azureSqlManagedInstanceServerRubrikId", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAzureSqlManagedInstanceServer",
                "($azureSqlManagedInstanceServerRubrikId: UUID!)",
                "AzureSqlManagedInstanceServer",
                Query.AzureSqlManagedInstanceServer_ObjectFieldSpec,
                Query.AzureSqlManagedInstanceServerFieldSpec,
                @"# REQUIRED
$inputs.Var.azureSqlManagedInstanceServerRubrikId = <System.String>"
            );
        }

    } // class New-RscGqlQueryAzureSqlManagedInstanceServer
}