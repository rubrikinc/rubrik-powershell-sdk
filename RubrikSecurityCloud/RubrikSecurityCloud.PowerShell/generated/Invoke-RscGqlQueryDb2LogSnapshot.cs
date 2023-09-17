// Invoke-RscGqlQueryDb2LogSnapshot.cs
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
    /// Invoke GraphQL Query db2LogSnapshot
    /// db2LogSnapshot(db2LogSnapshotFid: UUID!): Db2LogSnapshot!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "Invoke",
        "RscGqlQueryDb2LogSnapshot")
    ]
    public class Invoke_RscGqlQueryDb2LogSnapshot : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the Invoke-RscGqlQuery* cmdlets
        // fit in the Invoke-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("db2LogSnapshot");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Invoke GraphQL Query db2LogSnapshot
        /// db2LogSnapshot(db2LogSnapshotFid: UUID!): Db2LogSnapshot!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_db2LogSnapshot();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_db2LogSnapshot()
        {
            this._logger.name += " -db2LogSnapshot";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("db2LogSnapshotFid", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryDb2LogSnapshot",
                "($db2LogSnapshotFid: UUID!)",
                "Db2LogSnapshot",
                Query.Db2LogSnapshot_ObjectFieldSpec,
                Query.Db2LogSnapshotFieldSpec,
                @"# REQUIRED
$inputs.Var.db2LogSnapshotFid = <System.String>"
            );
        }

    } // class Invoke-RscGqlQueryDb2LogSnapshot
}