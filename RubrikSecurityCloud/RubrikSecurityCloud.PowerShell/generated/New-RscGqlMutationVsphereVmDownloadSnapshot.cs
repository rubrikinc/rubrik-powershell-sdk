// New-RscGqlMutationVsphereVmDownloadSnapshot.cs
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
    /// Create new GraphQL Mutation vsphereVmDownloadSnapshot
    /// vsphereVmDownloadSnapshot(input: VsphereVmDownloadSnapshotInput!): AsyncRequestStatus!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlMutationVsphereVmDownloadSnapshot")
    ]
    public class New_RscGqlMutationVsphereVmDownloadSnapshot : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("vsphereVmDownloadSnapshot");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Mutation vsphereVmDownloadSnapshot
        /// vsphereVmDownloadSnapshot(input: VsphereVmDownloadSnapshotInput!): AsyncRequestStatus!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_vsphereVmDownloadSnapshot();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_vsphereVmDownloadSnapshot()
        {
            this._logger.name += " -vsphereVmDownloadSnapshot";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "VsphereVmDownloadSnapshotInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationVsphereVmDownloadSnapshot",
                "($input: VsphereVmDownloadSnapshotInput!)",
                "AsyncRequestStatus",
                Mutation.VsphereVmDownloadSnapshot_ObjectFieldSpec,
                Mutation.VsphereVmDownloadSnapshotFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
}"
            );
        }

    } // class New-RscGqlMutationVsphereVmDownloadSnapshot
}