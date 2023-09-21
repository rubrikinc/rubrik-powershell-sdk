// New-RscGqlQueryHypervVirtualMachineAsyncRequestStatus.cs
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
    /// Create new GraphQL Query hypervVirtualMachineAsyncRequestStatus
    /// hypervVirtualMachineAsyncRequestStatus(input: GetHypervVirtualMachineAsyncRequestStatusInput!): AsyncRequestStatus!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlQueryHypervVirtualMachineAsyncRequestStatus")
    ]
    public class New_RscGqlQueryHypervVirtualMachineAsyncRequestStatus : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("hypervVirtualMachineAsyncRequestStatus");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Query hypervVirtualMachineAsyncRequestStatus
        /// hypervVirtualMachineAsyncRequestStatus(input: GetHypervVirtualMachineAsyncRequestStatusInput!): AsyncRequestStatus!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_hypervVirtualMachineAsyncRequestStatus();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_hypervVirtualMachineAsyncRequestStatus()
        {
            this._logger.name += " -hypervVirtualMachineAsyncRequestStatus";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetHypervVirtualMachineAsyncRequestStatusInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryHypervVirtualMachineAsyncRequestStatus",
                "($input: GetHypervVirtualMachineAsyncRequestStatusInput!)",
                "AsyncRequestStatus",
                Query.HypervVirtualMachineAsyncRequestStatus_ObjectFieldSpec,
                Query.HypervVirtualMachineAsyncRequestStatusFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	clusterUuid = <System.String>
	# REQUIRED
	id = <System.String>
}"
            );
        }

    } // class New-RscGqlQueryHypervVirtualMachineAsyncRequestStatus
}