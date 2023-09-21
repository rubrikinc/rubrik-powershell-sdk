// New-RscGqlQueryVsphereVMMissedRecoverableRange.cs
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
    /// Create new GraphQL Query vsphereVMMissedRecoverableRange
    /// vsphereVMMissedRecoverableRange(snappableFid: UUID!, beforeTime: DateTime, afterTime: DateTime): RecoverableRangeResponse!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlQueryVsphereVMMissedRecoverableRange")
    ]
    public class New_RscGqlQueryVsphereVMMissedRecoverableRange : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("vsphereVMMissedRecoverableRange");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Query vsphereVMMissedRecoverableRange
        /// vsphereVMMissedRecoverableRange(snappableFid: UUID!, beforeTime: DateTime, afterTime: DateTime): RecoverableRangeResponse!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_vsphereVMMissedRecoverableRange();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_vsphereVMMissedRecoverableRange()
        {
            this._logger.name += " -vsphereVMMissedRecoverableRange";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("snappableFid", "UUID!"),
                Tuple.Create("beforeTime", "DateTime"),
                Tuple.Create("afterTime", "DateTime"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryVsphereVmMissedRecoverableRange",
                "($snappableFid: UUID!,$beforeTime: DateTime,$afterTime: DateTime)",
                "RecoverableRangeResponse",
                Query.VsphereVmMissedRecoverableRange_ObjectFieldSpec,
                Query.VsphereVmMissedRecoverableRangeFieldSpec,
                @"# REQUIRED
$inputs.Var.snappableFid = <System.String>
# OPTIONAL
$inputs.Var.beforeTime = <DateTime>
# OPTIONAL
$inputs.Var.afterTime = <DateTime>"
            );
        }

    } // class New-RscGqlQueryVsphereVMMissedRecoverableRange
}