// New-RscGqlQueryValidateAzureNativeSqlDatabaseDbNameForExport.cs
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
    /// Create new GraphQL Query validateAzureNativeSqlDatabaseDbNameForExport
    /// validateAzureNativeSqlDatabaseDbNameForExport(azureSqlDatabaseName: String!, azureSqlDatabaseServerRubrikId: UUID!): ValidateAzureNativeSqlDatabaseDbNameForExportReply!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlQueryValidateAzureNativeSqlDatabaseDbNameForExport")
    ]
    public class New_RscGqlQueryValidateAzureNativeSqlDatabaseDbNameForExport : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
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
        /// Create new GraphQL Query validateAzureNativeSqlDatabaseDbNameForExport
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

    } // class New-RscGqlQueryValidateAzureNativeSqlDatabaseDbNameForExport
}