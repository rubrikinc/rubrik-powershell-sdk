// New-RscGqlQueryAzureSqlManagedInstanceDatabase.cs
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
    /// Create new GraphQL Query azureSqlManagedInstanceDatabase
    /// azureSqlManagedInstanceDatabase(azureSqlManagedInstanceDatabaseRubrikId: UUID!): AzureSqlManagedInstanceDatabase!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlQueryAzureSqlManagedInstanceDatabase")
    ]
    public class New_RscGqlQueryAzureSqlManagedInstanceDatabase : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("azureSqlManagedInstanceDatabase");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Query azureSqlManagedInstanceDatabase
        /// azureSqlManagedInstanceDatabase(azureSqlManagedInstanceDatabaseRubrikId: UUID!): AzureSqlManagedInstanceDatabase!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_azureSqlManagedInstanceDatabase();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_azureSqlManagedInstanceDatabase()
        {
            this._logger.name += " -azureSqlManagedInstanceDatabase";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("azureSqlManagedInstanceDatabaseRubrikId", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAzureSqlManagedInstanceDatabase",
                "($azureSqlManagedInstanceDatabaseRubrikId: UUID!)",
                "AzureSqlManagedInstanceDatabase",
                Query.AzureSqlManagedInstanceDatabase_ObjectFieldSpec,
                Query.AzureSqlManagedInstanceDatabaseFieldSpec,
                @"# REQUIRED
$inputs.Var.azureSqlManagedInstanceDatabaseRubrikId = <System.String>"
            );
        }

    } // class New-RscGqlQueryAzureSqlManagedInstanceDatabase
}