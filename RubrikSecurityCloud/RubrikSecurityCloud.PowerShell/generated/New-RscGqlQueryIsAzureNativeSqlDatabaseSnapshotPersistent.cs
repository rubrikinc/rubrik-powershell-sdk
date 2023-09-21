// New-RscGqlQueryIsAzureNativeSqlDatabaseSnapshotPersistent.cs
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
    /// Create new GraphQL Query isAzureNativeSqlDatabaseSnapshotPersistent
    /// isAzureNativeSqlDatabaseSnapshotPersistent(snapshotId: UUID!): Boolean!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlQueryIsAzureNativeSqlDatabaseSnapshotPersistent")
    ]
    public class New_RscGqlQueryIsAzureNativeSqlDatabaseSnapshotPersistent : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("isAzureNativeSqlDatabaseSnapshotPersistent");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Query isAzureNativeSqlDatabaseSnapshotPersistent
        /// isAzureNativeSqlDatabaseSnapshotPersistent(snapshotId: UUID!): Boolean!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_isAzureNativeSqlDatabaseSnapshotPersistent();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_isAzureNativeSqlDatabaseSnapshotPersistent()
        {
            this._logger.name += " -isAzureNativeSqlDatabaseSnapshotPersistent";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("snapshotId", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryIsAzureNativeSqlDatabaseSnapshotPersistent",
                "($snapshotId: UUID!)",
                "System.Boolean",
                Query.IsAzureNativeSqlDatabaseSnapshotPersistent_ObjectFieldSpec,
                Query.IsAzureNativeSqlDatabaseSnapshotPersistentFieldSpec,
                @"# REQUIRED
$inputs.Var.snapshotId = <System.String>"
            );
        }

    } // class New-RscGqlQueryIsAzureNativeSqlDatabaseSnapshotPersistent
}