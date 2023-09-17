// Invoke-RscGqlQueryO365ServiceStatus.cs
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
    /// Invoke GraphQL Query o365ServiceStatus
    /// o365ServiceStatus(orgID: UUID): GetO365ServiceStatusResp!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "Invoke",
        "RscGqlQueryO365ServiceStatus")
    ]
    public class Invoke_RscGqlQueryO365ServiceStatus : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the Invoke-RscGqlQuery* cmdlets
        // fit in the Invoke-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("o365ServiceStatus");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Invoke GraphQL Query o365ServiceStatus
        /// o365ServiceStatus(orgID: UUID): GetO365ServiceStatusResp!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_o365ServiceStatus();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_o365ServiceStatus()
        {
            this._logger.name += " -o365ServiceStatus";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("orgID", "UUID"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryO365ServiceStatus",
                "($orgID: UUID)",
                "GetO365ServiceStatusResp",
                Query.O365ServiceStatus_ObjectFieldSpec,
                Query.O365ServiceStatusFieldSpec,
                @"# OPTIONAL
$inputs.Var.orgID = <System.String>"
            );
        }

    } // class Invoke-RscGqlQueryO365ServiceStatus
}