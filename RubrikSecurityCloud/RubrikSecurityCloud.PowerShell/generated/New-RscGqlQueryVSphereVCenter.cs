// New-RscGqlQueryVSphereVCenter.cs
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
    /// Create new GraphQL Query vSphereVCenter
    /// vSphereVCenter(fid: UUID!): VsphereVcenter!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlQueryVSphereVCenter")
    ]
    public class New_RscGqlQueryVSphereVCenter : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("vSphereVCenter");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Query vSphereVCenter
        /// vSphereVCenter(fid: UUID!): VsphereVcenter!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_vSphereVCenter();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_vSphereVCenter()
        {
            this._logger.name += " -vSphereVCenter";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryVsphereVcenter",
                "($fid: UUID!)",
                "VsphereVcenter",
                Query.VsphereVcenter_ObjectFieldSpec,
                Query.VsphereVcenterFieldSpec,
                @"# REQUIRED
$inputs.Var.fid = <System.String>"
            );
        }

    } // class New-RscGqlQueryVSphereVCenter
}