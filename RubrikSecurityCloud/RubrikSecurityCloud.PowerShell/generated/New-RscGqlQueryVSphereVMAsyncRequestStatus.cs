// New-RscGqlQueryVSphereVMAsyncRequestStatus.cs
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
    /// Create new GraphQL Query vSphereVMAsyncRequestStatus
    /// vSphereVMAsyncRequestStatus(clusterUuid: UUID!, id: String!): AsyncRequestStatus!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlQueryVSphereVMAsyncRequestStatus")
    ]
    public class New_RscGqlQueryVSphereVMAsyncRequestStatus : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("vSphereVMAsyncRequestStatus");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Query vSphereVMAsyncRequestStatus
        /// vSphereVMAsyncRequestStatus(clusterUuid: UUID!, id: String!): AsyncRequestStatus!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_vSphereVMAsyncRequestStatus();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_vSphereVMAsyncRequestStatus()
        {
            this._logger.name += " -vSphereVMAsyncRequestStatus";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("clusterUuid", "UUID!"),
                Tuple.Create("id", "String!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryVsphereVmAsyncRequestStatus",
                "($clusterUuid: UUID!,$id: String!)",
                "AsyncRequestStatus",
                Query.VsphereVmAsyncRequestStatus_ObjectFieldSpec,
                Query.VsphereVmAsyncRequestStatusFieldSpec,
                @"# REQUIRED
$inputs.Var.clusterUuid = <System.String>
# REQUIRED
$inputs.Var.id = <System.String>"
            );
        }

    } // class New-RscGqlQueryVSphereVMAsyncRequestStatus
}