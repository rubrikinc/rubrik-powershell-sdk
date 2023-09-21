// New-RscGqlMutationVsphereDeleteVcenter.cs
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
    /// Create new GraphQL Mutation vsphereDeleteVcenter
    /// vsphereDeleteVcenter(input: VsphereDeleteVcenterInput!): AsyncRequestStatus!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlMutationVsphereDeleteVcenter")
    ]
    public class New_RscGqlMutationVsphereDeleteVcenter : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("vsphereDeleteVcenter");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Mutation vsphereDeleteVcenter
        /// vsphereDeleteVcenter(input: VsphereDeleteVcenterInput!): AsyncRequestStatus!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_vsphereDeleteVcenter();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_vsphereDeleteVcenter()
        {
            this._logger.name += " -vsphereDeleteVcenter";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "VsphereDeleteVcenterInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationVsphereDeleteVcenter",
                "($input: VsphereDeleteVcenterInput!)",
                "AsyncRequestStatus",
                Mutation.VsphereDeleteVcenter_ObjectFieldSpec,
                Mutation.VsphereDeleteVcenterFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
}"
            );
        }

    } // class New-RscGqlMutationVsphereDeleteVcenter
}