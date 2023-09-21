// New-RscGqlQueryAzureSqlDatabaseDbPointInTimeRestoreWindowFromAzure.cs
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
    /// Create new GraphQL Query azureSqlDatabaseDbPointInTimeRestoreWindowFromAzure
    /// azureSqlDatabaseDbPointInTimeRestoreWindowFromAzure(
    ///     subscriptionId: UUID!
    ///     resourceGroupName: String!
    ///     azureSqlDatabaseServerName: String!
    ///     azureSqlDatabaseName: String!
    ///   ): AzureNativeSqlDatabasePointInTimeRestoreWindow!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlQueryAzureSqlDatabaseDbPointInTimeRestoreWindowFromAzure")
    ]
    public class New_RscGqlQueryAzureSqlDatabaseDbPointInTimeRestoreWindowFromAzure : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("azureSqlDatabaseDbPointInTimeRestoreWindowFromAzure");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Query azureSqlDatabaseDbPointInTimeRestoreWindowFromAzure
        /// azureSqlDatabaseDbPointInTimeRestoreWindowFromAzure(
        ///     subscriptionId: UUID!
        ///     resourceGroupName: String!
        ///     azureSqlDatabaseServerName: String!
        ///     azureSqlDatabaseName: String!
        ///   ): AzureNativeSqlDatabasePointInTimeRestoreWindow!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_azureSqlDatabaseDbPointInTimeRestoreWindowFromAzure();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_azureSqlDatabaseDbPointInTimeRestoreWindowFromAzure()
        {
            this._logger.name += " -azureSqlDatabaseDbPointInTimeRestoreWindowFromAzure";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("subscriptionId", "UUID!"),
                Tuple.Create("resourceGroupName", "String!"),
                Tuple.Create("azureSqlDatabaseServerName", "String!"),
                Tuple.Create("azureSqlDatabaseName", "String!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAzureSqlDatabaseDbPointInTimeRestoreWindowFromAzure",
                "($subscriptionId: UUID!,$resourceGroupName: String!,$azureSqlDatabaseServerName: String!,$azureSqlDatabaseName: String!)",
                "AzureNativeSqlDatabasePointInTimeRestoreWindow",
                Query.AzureSqlDatabaseDbPointInTimeRestoreWindowFromAzure_ObjectFieldSpec,
                Query.AzureSqlDatabaseDbPointInTimeRestoreWindowFromAzureFieldSpec,
                @"# REQUIRED
$inputs.Var.subscriptionId = <System.String>
# REQUIRED
$inputs.Var.resourceGroupName = <System.String>
# REQUIRED
$inputs.Var.azureSqlDatabaseServerName = <System.String>
# REQUIRED
$inputs.Var.azureSqlDatabaseName = <System.String>"
            );
        }

    } // class New-RscGqlQueryAzureSqlDatabaseDbPointInTimeRestoreWindowFromAzure
}