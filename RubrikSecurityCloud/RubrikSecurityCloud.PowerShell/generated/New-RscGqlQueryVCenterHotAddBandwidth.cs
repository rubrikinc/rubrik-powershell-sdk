// New-RscGqlQueryVCenterHotAddBandwidth.cs
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
    /// Create new GraphQL Query vCenterHotAddBandwidth
    /// vCenterHotAddBandwidth(input: GetHotAddBandwidthInput!): HotAddBandwidthInfo!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlQueryVCenterHotAddBandwidth")
    ]
    public class New_RscGqlQueryVCenterHotAddBandwidth : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("vCenterHotAddBandwidth");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Query vCenterHotAddBandwidth
        /// vCenterHotAddBandwidth(input: GetHotAddBandwidthInput!): HotAddBandwidthInfo!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_vCenterHotAddBandwidth();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_vCenterHotAddBandwidth()
        {
            this._logger.name += " -vCenterHotAddBandwidth";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetHotAddBandwidthInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryVcenterHotAddBandwidth",
                "($input: GetHotAddBandwidthInput!)",
                "HotAddBandwidthInfo",
                Query.VcenterHotAddBandwidth_ObjectFieldSpec,
                Query.VcenterHotAddBandwidthFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
}"
            );
        }

    } // class New-RscGqlQueryVCenterHotAddBandwidth
}