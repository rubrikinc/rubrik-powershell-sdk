// New-RscGqlQueryVSphereHostsByFids.cs
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
    /// Create new GraphQL Query vSphereHostsByFids
    /// vSphereHostsByFids(fids: [UUID!]!): [VsphereHost!]!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlQueryVSphereHostsByFids")
    ]
    public class New_RscGqlQueryVSphereHostsByFids : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("vSphereHostsByFids");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Query vSphereHostsByFids
        /// vSphereHostsByFids(fids: [UUID!]!): [VsphereHost!]!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_vSphereHostsByFids();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_vSphereHostsByFids()
        {
            this._logger.name += " -vSphereHostsByFids";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fids", "[UUID!]!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryVsphereHostsByFids",
                "($fids: [UUID!]!)",
                "List<VsphereHost>",
                Query.VsphereHostsByFids_ObjectFieldSpec,
                Query.VsphereHostsByFidsFieldSpec,
                @"# REQUIRED
$inputs.Var.fids = @(
	<System.String>
)"
            );
        }

    } // class New-RscGqlQueryVSphereHostsByFids
}