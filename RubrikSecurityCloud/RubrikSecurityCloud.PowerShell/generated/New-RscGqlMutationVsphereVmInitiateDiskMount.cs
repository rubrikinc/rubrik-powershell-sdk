// New-RscGqlMutationVsphereVmInitiateDiskMount.cs
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
    /// Create new GraphQL Mutation vsphereVmInitiateDiskMount
    /// vsphereVmInitiateDiskMount(input: VsphereVmInitiateDiskMountInput!): AsyncRequestStatus!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlMutationVsphereVmInitiateDiskMount")
    ]
    public class New_RscGqlMutationVsphereVmInitiateDiskMount : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("vsphereVmInitiateDiskMount");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Mutation vsphereVmInitiateDiskMount
        /// vsphereVmInitiateDiskMount(input: VsphereVmInitiateDiskMountInput!): AsyncRequestStatus!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_vsphereVmInitiateDiskMount();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_vsphereVmInitiateDiskMount()
        {
            this._logger.name += " -vsphereVmInitiateDiskMount";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "VsphereVmInitiateDiskMountInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationVsphereVmInitiateDiskMount",
                "($input: VsphereVmInitiateDiskMountInput!)",
                "AsyncRequestStatus",
                Mutation.VsphereVmInitiateDiskMount_ObjectFieldSpec,
                Mutation.VsphereVmInitiateDiskMountFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	config = @{
		# OPTIONAL
		targetVmId = <System.String>
		# OPTIONAL
		vlan = <System.Int32>
		# OPTIONAL
		vmdkIds = @(
			<System.String>
		)
	}
	# REQUIRED
	id = <System.String>
}"
            );
        }

    } // class New-RscGqlMutationVsphereVmInitiateDiskMount
}