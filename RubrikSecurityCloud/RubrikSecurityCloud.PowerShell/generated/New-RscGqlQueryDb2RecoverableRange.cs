// New-RscGqlQueryDb2RecoverableRange.cs
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
    /// Create new GraphQL Query db2RecoverableRange
    /// db2RecoverableRange(db2RecoverableRangeFid: UUID!): Db2RecoverableRange!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlQueryDb2RecoverableRange")
    ]
    public class New_RscGqlQueryDb2RecoverableRange : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
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
        /// Create new GraphQL Query db2RecoverableRange
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

    } // class New-RscGqlQueryDb2RecoverableRange
}