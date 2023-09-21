// New-RscGqlMutationVsphereExportSnapshotToStandaloneHostV2.cs
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
    /// Create new GraphQL Mutation vsphereExportSnapshotToStandaloneHostV2
    /// vsphereExportSnapshotToStandaloneHostV2(input: VsphereExportSnapshotToStandaloneHostV2Input!): AsyncRequestStatus!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlMutationVsphereExportSnapshotToStandaloneHostV2")
    ]
    public class New_RscGqlMutationVsphereExportSnapshotToStandaloneHostV2 : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("vsphereExportSnapshotToStandaloneHostV2");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Mutation vsphereExportSnapshotToStandaloneHostV2
        /// vsphereExportSnapshotToStandaloneHostV2(input: VsphereExportSnapshotToStandaloneHostV2Input!): AsyncRequestStatus!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_vsphereExportSnapshotToStandaloneHostV2();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_vsphereExportSnapshotToStandaloneHostV2()
        {
            this._logger.name += " -vsphereExportSnapshotToStandaloneHostV2";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "VsphereExportSnapshotToStandaloneHostV2Input!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationVsphereExportSnapshotToStandaloneHostV2",
                "($input: VsphereExportSnapshotToStandaloneHostV2Input!)",
                "AsyncRequestStatus",
                Mutation.VsphereExportSnapshotToStandaloneHostV2_ObjectFieldSpec,
                Mutation.VsphereExportSnapshotToStandaloneHostV2FieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	config = @{
		# OPTIONAL
		mountExportSnapshotJobCommonOptions = @{
			# OPTIONAL
			disableNetwork = <System.Boolean>
			# OPTIONAL
			keepMacAddresses = <System.Boolean>
			# OPTIONAL
			powerOn = <System.Boolean>
			# OPTIONAL
			removeNetworkDevices = <System.Boolean>
			# OPTIONAL
			vmName = <System.String>
		}
		# REQUIRED
		datastoreName = <System.String>
		# REQUIRED
		hostIpAddress = <System.String>
		# REQUIRED
		hostPassword = <System.String>
		# REQUIRED
		hostUsername = <System.String>
	}
	# REQUIRED
	id = <System.String>
}"
            );
        }

    } // class New-RscGqlMutationVsphereExportSnapshotToStandaloneHostV2
}