// New-RscGqlQueryVsphereVMRecoverableRange.cs
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
    /// Create new GraphQL Query vsphereVMRecoverableRange
    /// vsphereVMRecoverableRange(snappableFid: UUID!, beforeTime: DateTime, afterTime: DateTime): RecoverableRangeResponse!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlQueryVsphereVMRecoverableRange")
    ]
    public class New_RscGqlQueryVsphereVMRecoverableRange : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("vsphereVMRecoverableRange");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Query vsphereVMRecoverableRange
        /// vsphereVMRecoverableRange(snappableFid: UUID!, beforeTime: DateTime, afterTime: DateTime): RecoverableRangeResponse!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_vsphereVMRecoverableRange();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_vsphereVMRecoverableRange()
        {
            this._logger.name += " -vsphereVMRecoverableRange";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("snappableFid", "UUID!"),
                Tuple.Create("beforeTime", "DateTime"),
                Tuple.Create("afterTime", "DateTime"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryVsphereVmRecoverableRange",
                "($snappableFid: UUID!,$beforeTime: DateTime,$afterTime: DateTime)",
                "RecoverableRangeResponse",
                Query.VsphereVmRecoverableRange_ObjectFieldSpec,
                Query.VsphereVmRecoverableRangeFieldSpec,
                @"# REQUIRED
$inputs.Var.snappableFid = <System.String>
# OPTIONAL
$inputs.Var.beforeTime = <DateTime>
# OPTIONAL
$inputs.Var.afterTime = <DateTime>"
            );
        }

    } // class New-RscGqlQueryVsphereVMRecoverableRange
}