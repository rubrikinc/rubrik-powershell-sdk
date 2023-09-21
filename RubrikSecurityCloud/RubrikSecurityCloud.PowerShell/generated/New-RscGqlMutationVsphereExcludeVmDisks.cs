// New-RscGqlMutationVsphereExcludeVmDisks.cs
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
    /// Create new GraphQL Mutation vsphereExcludeVmDisks
    /// vsphereExcludeVmDisks(input: [VsphereExcludeVmDisksInput!]!): RequestSuccess!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlMutationVsphereExcludeVmDisks")
    ]
    public class New_RscGqlMutationVsphereExcludeVmDisks : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("vsphereExcludeVmDisks");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Mutation vsphereExcludeVmDisks
        /// vsphereExcludeVmDisks(input: [VsphereExcludeVmDisksInput!]!): RequestSuccess!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_vsphereExcludeVmDisks();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_vsphereExcludeVmDisks()
        {
            this._logger.name += " -vsphereExcludeVmDisks";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "[VsphereExcludeVmDisksInput!]!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationVsphereExcludeVmDisks",
                "($input: [VsphereExcludeVmDisksInput!]!)",
                "RequestSuccess",
                Mutation.VsphereExcludeVmDisks_ObjectFieldSpec,
                Mutation.VsphereExcludeVmDisksFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @(
	@{
		# REQUIRED
		virtualDiskFid = <System.String>
		# OPTIONAL
		excludeFromSnapshots = <System.Boolean>
}
)"
            );
        }

    } // class New-RscGqlMutationVsphereExcludeVmDisks
}