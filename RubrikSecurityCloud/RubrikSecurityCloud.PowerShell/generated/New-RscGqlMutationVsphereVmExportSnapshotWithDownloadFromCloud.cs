// New-RscGqlMutationVsphereVmExportSnapshotWithDownloadFromCloud.cs
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
    /// Create new GraphQL Mutation vsphereVmExportSnapshotWithDownloadFromCloud
    /// vsphereVmExportSnapshotWithDownloadFromCloud(input: VsphereVmExportSnapshotWithDownloadFromCloudInput!): AsyncRequestStatus!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlMutationVsphereVmExportSnapshotWithDownloadFromCloud")
    ]
    public class New_RscGqlMutationVsphereVmExportSnapshotWithDownloadFromCloud : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("vsphereVmExportSnapshotWithDownloadFromCloud");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Mutation vsphereVmExportSnapshotWithDownloadFromCloud
        /// vsphereVmExportSnapshotWithDownloadFromCloud(input: VsphereVmExportSnapshotWithDownloadFromCloudInput!): AsyncRequestStatus!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_vsphereVmExportSnapshotWithDownloadFromCloud();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_vsphereVmExportSnapshotWithDownloadFromCloud()
        {
            this._logger.name += " -vsphereVmExportSnapshotWithDownloadFromCloud";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "VsphereVmExportSnapshotWithDownloadFromCloudInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationVsphereVmExportSnapshotWithDownloadFromCloud",
                "($input: VsphereVmExportSnapshotWithDownloadFromCloudInput!)",
                "AsyncRequestStatus",
                Mutation.VsphereVmExportSnapshotWithDownloadFromCloud_ObjectFieldSpec,
                Mutation.VsphereVmExportSnapshotWithDownloadFromCloudFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	config = @{
		# OPTIONAL
		hostId = <System.String>
		# OPTIONAL
		shouldRecoverTags = <System.Boolean>
		# OPTIONAL
		unregisterVm = <System.Boolean>
		# OPTIONAL
		clusterId = <System.String>
		# OPTIONAL
		resourcePoolId = <System.String>
		# OPTIONAL
		vNicBindings = @(
			@{
				# REQUIRED
				backingNetworkInfo = @{
					# REQUIRED
					moid = <System.String>
					# REQUIRED
					name = <System.String>
				}
				# REQUIRED
				networkDeviceInfo = @{
					# REQUIRED
					key = <System.Int32>
					# REQUIRED
					name = <System.String>
				}
			}
		)
		# OPTIONAL
		shouldUseHotAddProxy = <System.Boolean>
		# OPTIONAL
		mountExportSnapshotJobCommonOptionsV2 = @{
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
		# OPTIONAL
		requiredRecoveryParameters = @{
			# OPTIONAL
			recoveryPoint = <DateTime>
			# OPTIONAL
			snapshotId = <System.String>
		}
		# OPTIONAL
		folderId = <System.String>
		# REQUIRED
		datastoreId = <System.String>
	}
	# REQUIRED
	id = <System.String>
}"
            );
        }

    } // class New-RscGqlMutationVsphereVmExportSnapshotWithDownloadFromCloud
}