// New-RscGqlQueryNutanixVmAsyncRequestStatus.cs
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
    /// Create new GraphQL Query nutanixVmAsyncRequestStatus
    /// nutanixVmAsyncRequestStatus(input: GetNutanixVmAsyncRequestStatusInput!): AsyncRequestStatus!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlQueryNutanixVmAsyncRequestStatus")
    ]
    public class New_RscGqlQueryNutanixVmAsyncRequestStatus : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("nutanixVmAsyncRequestStatus");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Query nutanixVmAsyncRequestStatus
        /// nutanixVmAsyncRequestStatus(input: GetNutanixVmAsyncRequestStatusInput!): AsyncRequestStatus!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_nutanixVmAsyncRequestStatus();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_nutanixVmAsyncRequestStatus()
        {
            this._logger.name += " -nutanixVmAsyncRequestStatus";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetNutanixVmAsyncRequestStatusInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryNutanixVmAsyncRequestStatus",
                "($input: GetNutanixVmAsyncRequestStatusInput!)",
                "AsyncRequestStatus",
                Query.NutanixVmAsyncRequestStatus_ObjectFieldSpec,
                Query.NutanixVmAsyncRequestStatusFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	clusterUuid = <System.String>
	# REQUIRED
	id = <System.String>
}"
            );
        }

    } // class New-RscGqlQueryNutanixVmAsyncRequestStatus
}