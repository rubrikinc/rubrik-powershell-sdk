// Invoke-RscGqlQueryAzureSqlManagedInstanceDbPointInTimeRestoreWindowFromAzure.cs
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
    /// Invoke GraphQL Query azureSqlManagedInstanceDbPointInTimeRestoreWindowFromAzure
    /// azureSqlManagedInstanceDbPointInTimeRestoreWindowFromAzure(
    ///     subscriptionId: UUID!
    ///     resourceGroupName: String!
    ///     azureSqlManagedInstanceName: String!
    ///     azureSqlDatabaseName: String!
    ///   ): AzureNativeSqlDatabasePointInTimeRestoreWindow!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "Invoke",
        "RscGqlQueryAzureSqlManagedInstanceDbPointInTimeRestoreWindowFromAzure")
    ]
    public class Invoke_RscGqlQueryAzureSqlManagedInstanceDbPointInTimeRestoreWindowFromAzure : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the Invoke-RscGqlQuery* cmdlets
        // fit in the Invoke-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("azureSqlManagedInstanceDbPointInTimeRestoreWindowFromAzure");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Invoke GraphQL Query azureSqlManagedInstanceDbPointInTimeRestoreWindowFromAzure
        /// azureSqlManagedInstanceDbPointInTimeRestoreWindowFromAzure(
        ///     subscriptionId: UUID!
        ///     resourceGroupName: String!
        ///     azureSqlManagedInstanceName: String!
        ///     azureSqlDatabaseName: String!
        ///   ): AzureNativeSqlDatabasePointInTimeRestoreWindow!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_azureSqlManagedInstanceDbPointInTimeRestoreWindowFromAzure();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_azureSqlManagedInstanceDbPointInTimeRestoreWindowFromAzure()
        {
            this._logger.name += " -azureSqlManagedInstanceDbPointInTimeRestoreWindowFromAzure";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("subscriptionId", "UUID!"),
                Tuple.Create("resourceGroupName", "String!"),
                Tuple.Create("azureSqlManagedInstanceName", "String!"),
                Tuple.Create("azureSqlDatabaseName", "String!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAzureSqlManagedInstanceDbPointInTimeRestoreWindowFromAzure",
                "($subscriptionId: UUID!,$resourceGroupName: String!,$azureSqlManagedInstanceName: String!,$azureSqlDatabaseName: String!)",
                "AzureNativeSqlDatabasePointInTimeRestoreWindow",
                Query.AzureSqlManagedInstanceDbPointInTimeRestoreWindowFromAzure_ObjectFieldSpec,
                Query.AzureSqlManagedInstanceDbPointInTimeRestoreWindowFromAzureFieldSpec,
                @"# REQUIRED
$inputs.Var.subscriptionId = <System.String>
# REQUIRED
$inputs.Var.resourceGroupName = <System.String>
# REQUIRED
$inputs.Var.azureSqlManagedInstanceName = <System.String>
# REQUIRED
$inputs.Var.azureSqlDatabaseName = <System.String>"
            );
        }

    } // class Invoke-RscGqlQueryAzureSqlManagedInstanceDbPointInTimeRestoreWindowFromAzure
}