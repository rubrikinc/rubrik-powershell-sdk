// New-RscGqlQueryNutanixClusterAsyncRequestStatus.cs
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
    /// Create new GraphQL Query nutanixClusterAsyncRequestStatus
    /// nutanixClusterAsyncRequestStatus(input: GetNutanixClusterAsyncRequestStatusInput!): AsyncRequestStatus!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlQueryNutanixClusterAsyncRequestStatus")
    ]
    public class New_RscGqlQueryNutanixClusterAsyncRequestStatus : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("nutanixClusterAsyncRequestStatus");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Query nutanixClusterAsyncRequestStatus
        /// nutanixClusterAsyncRequestStatus(input: GetNutanixClusterAsyncRequestStatusInput!): AsyncRequestStatus!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_nutanixClusterAsyncRequestStatus();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_nutanixClusterAsyncRequestStatus()
        {
            this._logger.name += " -nutanixClusterAsyncRequestStatus";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetNutanixClusterAsyncRequestStatusInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryNutanixClusterAsyncRequestStatus",
                "($input: GetNutanixClusterAsyncRequestStatusInput!)",
                "AsyncRequestStatus",
                Query.NutanixClusterAsyncRequestStatus_ObjectFieldSpec,
                Query.NutanixClusterAsyncRequestStatusFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	clusterUuid = <System.String>
	# REQUIRED
	id = <System.String>
}"
            );
        }

    } // class New-RscGqlQueryNutanixClusterAsyncRequestStatus
}