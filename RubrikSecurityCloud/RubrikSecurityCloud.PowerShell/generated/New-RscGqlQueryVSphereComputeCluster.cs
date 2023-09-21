// New-RscGqlQueryVSphereComputeCluster.cs
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
    /// Create new GraphQL Query vSphereComputeCluster
    /// vSphereComputeCluster(fid: UUID!): VsphereComputeCluster!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlQueryVSphereComputeCluster")
    ]
    public class New_RscGqlQueryVSphereComputeCluster : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("vSphereComputeCluster");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Query vSphereComputeCluster
        /// vSphereComputeCluster(fid: UUID!): VsphereComputeCluster!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_vSphereComputeCluster();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_vSphereComputeCluster()
        {
            this._logger.name += " -vSphereComputeCluster";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryVsphereComputeCluster",
                "($fid: UUID!)",
                "VsphereComputeCluster",
                Query.VsphereComputeCluster_ObjectFieldSpec,
                Query.VsphereComputeClusterFieldSpec,
                @"# REQUIRED
$inputs.Var.fid = <System.String>"
            );
        }

    } // class New-RscGqlQueryVSphereComputeCluster
}