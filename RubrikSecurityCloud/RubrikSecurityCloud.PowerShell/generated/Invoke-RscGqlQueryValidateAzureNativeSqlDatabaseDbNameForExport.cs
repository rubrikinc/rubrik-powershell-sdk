// Invoke-RscGqlQueryValidateAzureNativeSqlDatabaseDbNameForExport.cs
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
    /// Invoke GraphQL Query validateAzureNativeSqlDatabaseDbNameForExport
    /// validateAzureNativeSqlDatabaseDbNameForExport(azureSqlDatabaseName: String!, azureSqlDatabaseServerRubrikId: UUID!): ValidateAzureNativeSqlDatabaseDbNameForExportReply!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "Invoke",
        "RscGqlQueryValidateAzureNativeSqlDatabaseDbNameForExport")
    ]
    public class Invoke_RscGqlQueryValidateAzureNativeSqlDatabaseDbNameForExport : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the Invoke-RscGqlQuery* cmdlets
        // fit in the Invoke-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("validateAzureNativeSqlDatabaseDbNameForExport");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Invoke GraphQL Query validateAzureNativeSqlDatabaseDbNameForExport
        /// validateAzureNativeSqlDatabaseDbNameForExport(azureSqlDatabaseName: String!, azureSqlDatabaseServerRubrikId: UUID!): ValidateAzureNativeSqlDatabaseDbNameForExportReply!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_validateAzureNativeSqlDatabaseDbNameForExport();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_validateAzureNativeSqlDatabaseDbNameForExport()
        {
            this._logger.name += " -validateAzureNativeSqlDatabaseDbNameForExport";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("azureSqlDatabaseName", "String!"),
                Tuple.Create("azureSqlDatabaseServerRubrikId", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryValidateAzureNativeSqlDatabaseDbNameForExport",
                "($azureSqlDatabaseName: String!,$azureSqlDatabaseServerRubrikId: UUID!)",
                "ValidateAzureNativeSqlDatabaseDbNameForExportReply",
                Query.ValidateAzureNativeSqlDatabaseDbNameForExport_ObjectFieldSpec,
                Query.ValidateAzureNativeSqlDatabaseDbNameForExportFieldSpec,
                @"# REQUIRED
$inputs.Var.azureSqlDatabaseName = <System.String>
# REQUIRED
$inputs.Var.azureSqlDatabaseServerRubrikId = <System.String>"
            );
        }

    } // class Invoke-RscGqlQueryValidateAzureNativeSqlDatabaseDbNameForExport
}