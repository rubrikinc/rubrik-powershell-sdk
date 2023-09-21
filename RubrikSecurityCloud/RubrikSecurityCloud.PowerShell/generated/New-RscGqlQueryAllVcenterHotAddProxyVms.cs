// New-RscGqlQueryAllVcenterHotAddProxyVms.cs
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
    /// Create new GraphQL Query allVcenterHotAddProxyVms
    /// allVcenterHotAddProxyVms(clusterUuids: [UUID!]!): [VcenterHotAddProxyVmInfo!]!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlQueryAllVcenterHotAddProxyVms")
    ]
    public class New_RscGqlQueryAllVcenterHotAddProxyVms : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("allVcenterHotAddProxyVms");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Query allVcenterHotAddProxyVms
        /// allVcenterHotAddProxyVms(clusterUuids: [UUID!]!): [VcenterHotAddProxyVmInfo!]!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_allVcenterHotAddProxyVms();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_allVcenterHotAddProxyVms()
        {
            this._logger.name += " -allVcenterHotAddProxyVms";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("clusterUuids", "[UUID!]!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllVcenterHotAddProxyVms",
                "($clusterUuids: [UUID!]!)",
                "List<VcenterHotAddProxyVmInfo>",
                Query.AllVcenterHotAddProxyVms_ObjectFieldSpec,
                Query.AllVcenterHotAddProxyVmsFieldSpec,
                @"# REQUIRED
$inputs.Var.clusterUuids = @(
	<System.String>
)"
            );
        }

    } // class New-RscGqlQueryAllVcenterHotAddProxyVms
}