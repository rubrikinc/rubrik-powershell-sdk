// New-RscGqlQueryAllAzureSqlDatabaseServerElasticPools.cs
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
    /// Create new GraphQL Query allAzureSqlDatabaseServerElasticPools
    /// allAzureSqlDatabaseServerElasticPools(
    ///     subscriptionId: UUID!
    ///     resourceGroupName: String!
    ///     azureSqlDatabaseServerName: String!
    ///     azureSqlDatabaseServerRubrikId: UUID!
    ///   ): [AzureSqlDatabaseServerElasticPool!]!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlQueryAllAzureSqlDatabaseServerElasticPools")
    ]
    public class New_RscGqlQueryAllAzureSqlDatabaseServerElasticPools : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("allAzureSqlDatabaseServerElasticPools");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Query allAzureSqlDatabaseServerElasticPools
        /// allAzureSqlDatabaseServerElasticPools(
        ///     subscriptionId: UUID!
        ///     resourceGroupName: String!
        ///     azureSqlDatabaseServerName: String!
        ///     azureSqlDatabaseServerRubrikId: UUID!
        ///   ): [AzureSqlDatabaseServerElasticPool!]!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_allAzureSqlDatabaseServerElasticPools();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_allAzureSqlDatabaseServerElasticPools()
        {
            this._logger.name += " -allAzureSqlDatabaseServerElasticPools";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("subscriptionId", "UUID!"),
                Tuple.Create("resourceGroupName", "String!"),
                Tuple.Create("azureSqlDatabaseServerName", "String!"),
                Tuple.Create("azureSqlDatabaseServerRubrikId", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllAzureSqlDatabaseServerElasticPools",
                "($subscriptionId: UUID!,$resourceGroupName: String!,$azureSqlDatabaseServerName: String!,$azureSqlDatabaseServerRubrikId: UUID!)",
                "List<AzureSqlDatabaseServerElasticPool>",
                Query.AllAzureSqlDatabaseServerElasticPools_ObjectFieldSpec,
                Query.AllAzureSqlDatabaseServerElasticPoolsFieldSpec,
                @"# REQUIRED
$inputs.Var.subscriptionId = <System.String>
# REQUIRED
$inputs.Var.resourceGroupName = <System.String>
# REQUIRED
$inputs.Var.azureSqlDatabaseServerName = <System.String>
# REQUIRED
$inputs.Var.azureSqlDatabaseServerRubrikId = <System.String>"
            );
        }

    } // class New-RscGqlQueryAllAzureSqlDatabaseServerElasticPools
}