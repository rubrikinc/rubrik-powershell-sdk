// New-RscGqlQueryVsphereVMRecoverableRangeInBatch.cs
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
    /// Create new GraphQL Query vsphereVMRecoverableRangeInBatch
    /// vsphereVMRecoverableRangeInBatch(requestInfo: BatchVmwareVmRecoverableRangesRequestInput!): BatchVmwareVmRecoverableRanges!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlQueryVsphereVMRecoverableRangeInBatch")
    ]
    public class New_RscGqlQueryVsphereVMRecoverableRangeInBatch : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("vsphereVMRecoverableRangeInBatch");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Query vsphereVMRecoverableRangeInBatch
        /// vsphereVMRecoverableRangeInBatch(requestInfo: BatchVmwareVmRecoverableRangesRequestInput!): BatchVmwareVmRecoverableRanges!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_vsphereVMRecoverableRangeInBatch();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_vsphereVMRecoverableRangeInBatch()
        {
            this._logger.name += " -vsphereVMRecoverableRangeInBatch";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("requestInfo", "BatchVmwareVmRecoverableRangesRequestInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryVsphereVmRecoverableRangeInBatch",
                "($requestInfo: BatchVmwareVmRecoverableRangesRequestInput!)",
                "BatchVmwareVmRecoverableRanges",
                Query.VsphereVmRecoverableRangeInBatch_ObjectFieldSpec,
                Query.VsphereVmRecoverableRangeInBatchFieldSpec,
                @"# REQUIRED
$inputs.Var.requestInfo = @{
	# OPTIONAL
	afterTime = <DateTime>
	# OPTIONAL
	beforeTime = <DateTime>
	# REQUIRED
	vmIds = @(
		<System.String>
	)
}"
            );
        }

    } // class New-RscGqlQueryVsphereVMRecoverableRangeInBatch
}