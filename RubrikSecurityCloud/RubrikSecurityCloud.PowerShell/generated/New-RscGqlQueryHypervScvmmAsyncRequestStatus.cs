// New-RscGqlQueryHypervScvmmAsyncRequestStatus.cs
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
    /// Create new GraphQL Query hypervScvmmAsyncRequestStatus
    /// hypervScvmmAsyncRequestStatus(input: GetHypervScvmmAsyncRequestStatusInput!): AsyncRequestStatus!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlQueryHypervScvmmAsyncRequestStatus")
    ]
    public class New_RscGqlQueryHypervScvmmAsyncRequestStatus : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("hypervScvmmAsyncRequestStatus");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Query hypervScvmmAsyncRequestStatus
        /// hypervScvmmAsyncRequestStatus(input: GetHypervScvmmAsyncRequestStatusInput!): AsyncRequestStatus!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_hypervScvmmAsyncRequestStatus();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_hypervScvmmAsyncRequestStatus()
        {
            this._logger.name += " -hypervScvmmAsyncRequestStatus";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetHypervScvmmAsyncRequestStatusInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryHypervScvmmAsyncRequestStatus",
                "($input: GetHypervScvmmAsyncRequestStatusInput!)",
                "AsyncRequestStatus",
                Query.HypervScvmmAsyncRequestStatus_ObjectFieldSpec,
                Query.HypervScvmmAsyncRequestStatusFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	clusterUuid = <System.String>
	# REQUIRED
	id = <System.String>
}"
            );
        }

    } // class New-RscGqlQueryHypervScvmmAsyncRequestStatus
}