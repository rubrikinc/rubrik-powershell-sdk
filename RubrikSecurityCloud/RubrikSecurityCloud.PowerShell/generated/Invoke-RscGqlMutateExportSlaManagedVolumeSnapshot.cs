// Invoke-RscGqlMutateExportSlaManagedVolumeSnapshot.cs
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
    /// Invoke GraphQL Mutation exportSlaManagedVolumeSnapshot
    /// exportSlaManagedVolumeSnapshot(input: ExportSlaManagedVolumeSnapshotInput!): AsyncRequestStatus!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "Invoke",
        "RscGqlMutateExportSlaManagedVolumeSnapshot")
    ]
    public class Invoke_RscGqlMutateExportSlaManagedVolumeSnapshot : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the Invoke-RscGqlQuery* cmdlets
        // fit in the Invoke-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("exportSlaManagedVolumeSnapshot");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Invoke GraphQL Mutation exportSlaManagedVolumeSnapshot
        /// exportSlaManagedVolumeSnapshot(input: ExportSlaManagedVolumeSnapshotInput!): AsyncRequestStatus!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_exportSlaManagedVolumeSnapshot();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_exportSlaManagedVolumeSnapshot()
        {
            this._logger.name += " -exportSlaManagedVolumeSnapshot";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "ExportSlaManagedVolumeSnapshotInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationExportSlaManagedVolumeSnapshot",
                "($input: ExportSlaManagedVolumeSnapshotInput!)",
                "AsyncRequestStatus",
                Mutation.ExportSlaManagedVolumeSnapshot_ObjectFieldSpec,
                Mutation.ExportSlaManagedVolumeSnapshotFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
	# OPTIONAL
	params = @{
		# OPTIONAL
		shouldDownloadToLocal = <System.Boolean>
		# OPTIONAL
		managedVolumeSlaExportConfig = @{
			# OPTIONAL
			managedVolumeExportConfig = @{
				# OPTIONAL
				subnet = <System.String>
				# OPTIONAL
				managedVolumePatchConfig = @{
					# OPTIONAL
					hostPatterns = @(
						<System.String>
					)
					# OPTIONAL
					nodeHint = @(
						<System.String>
					)
					# OPTIONAL
					smbDomainName = <System.String>
					# OPTIONAL
					smbValidIps = @(
						<System.String>
					)
					# OPTIONAL
					smbValidUsers = @(
						<System.String>
					)
				}
				# OPTIONAL
				shareType = <ManagedVolumeShareType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ManagedVolumeShareType]) for enum values.
			}
			# REQUIRED
			hostId = <System.String>
			# REQUIRED
			hostMountPaths = @(
				<System.String>
			)
		}
	}
}"
            );
        }

    } // class Invoke-RscGqlMutateExportSlaManagedVolumeSnapshot
}