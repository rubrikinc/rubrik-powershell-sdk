// New-RscGqlQueryVsphereVmwareCdpLiveInfo.cs
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
    /// Create new GraphQL Query vsphereVmwareCdpLiveInfo
    /// vsphereVmwareCdpLiveInfo(ids: [String!]!): BatchVmwareCdpLiveInfo!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlQueryVsphereVmwareCdpLiveInfo")
    ]
    public class New_RscGqlQueryVsphereVmwareCdpLiveInfo : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("vsphereVmwareCdpLiveInfo");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Query vsphereVmwareCdpLiveInfo
        /// vsphereVmwareCdpLiveInfo(ids: [String!]!): BatchVmwareCdpLiveInfo!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_vsphereVmwareCdpLiveInfo();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_vsphereVmwareCdpLiveInfo()
        {
            this._logger.name += " -vsphereVmwareCdpLiveInfo";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("ids", "[String!]!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryVsphereVmwareCdpLiveInfo",
                "($ids: [String!]!)",
                "BatchVmwareCdpLiveInfo",
                Query.VsphereVmwareCdpLiveInfo_ObjectFieldSpec,
                Query.VsphereVmwareCdpLiveInfoFieldSpec,
                @"# REQUIRED
$inputs.Var.ids = @(
	<System.String>
)"
            );
        }

    } // class New-RscGqlQueryVsphereVmwareCdpLiveInfo
}