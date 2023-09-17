// Invoke-RscGqlQueryDb2RecoverableRange.cs
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
    /// Invoke GraphQL Query db2RecoverableRange
    /// db2RecoverableRange(db2RecoverableRangeFid: UUID!): Db2RecoverableRange!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "Invoke",
        "RscGqlQueryDb2RecoverableRange")
    ]
    public class Invoke_RscGqlQueryDb2RecoverableRange : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the Invoke-RscGqlQuery* cmdlets
        // fit in the Invoke-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("db2RecoverableRange");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Invoke GraphQL Query db2RecoverableRange
        /// db2RecoverableRange(db2RecoverableRangeFid: UUID!): Db2RecoverableRange!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_db2RecoverableRange();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_db2RecoverableRange()
        {
            this._logger.name += " -db2RecoverableRange";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("db2RecoverableRangeFid", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryDb2RecoverableRange",
                "($db2RecoverableRangeFid: UUID!)",
                "Db2RecoverableRange",
                Query.Db2RecoverableRange_ObjectFieldSpec,
                Query.Db2RecoverableRangeFieldSpec,
                @"# REQUIRED
$inputs.Var.db2RecoverableRangeFid = <System.String>"
            );
        }

    } // class Invoke-RscGqlQueryDb2RecoverableRange
}