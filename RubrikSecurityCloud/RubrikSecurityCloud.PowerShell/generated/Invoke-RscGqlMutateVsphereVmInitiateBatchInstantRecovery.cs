// Invoke-RscGqlMutateVsphereVmInitiateBatchInstantRecovery.cs
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
    /// Invoke GraphQL Mutation vsphereVmInitiateBatchInstantRecovery
    /// vsphereVmInitiateBatchInstantRecovery(input: VsphereVmInitiateBatchInstantRecoveryInput!): BatchAsyncRequestStatus!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "Invoke",
        "RscGqlMutateVsphereVmInitiateBatchInstantRecovery")
    ]
    public class Invoke_RscGqlMutateVsphereVmInitiateBatchInstantRecovery : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the Invoke-RscGqlQuery* cmdlets
        // fit in the Invoke-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("vsphereVmInitiateBatchInstantRecovery");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Invoke GraphQL Mutation vsphereVmInitiateBatchInstantRecovery
        /// vsphereVmInitiateBatchInstantRecovery(input: VsphereVmInitiateBatchInstantRecoveryInput!): BatchAsyncRequestStatus!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_vsphereVmInitiateBatchInstantRecovery();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_vsphereVmInitiateBatchInstantRecovery()
        {
            this._logger.name += " -vsphereVmInitiateBatchInstantRecovery";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "VsphereVmInitiateBatchInstantRecoveryInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationVsphereVmInitiateBatchInstantRecovery",
                "($input: VsphereVmInitiateBatchInstantRecoveryInput!)",
                "BatchAsyncRequestStatus",
                Mutation.VsphereVmInitiateBatchInstantRecovery_ObjectFieldSpec,
                Mutation.VsphereVmInitiateBatchInstantRecoveryFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	clusterUuid = <System.String>
	# REQUIRED
	config = @{
		# REQUIRED
		snapshots = @(
			@{
				# OPTIONAL
				snapshotAfterDate = <DateTime>
				# OPTIONAL
				snapshotBeforeDate = <DateTime>
				# OPTIONAL
				snapshotId = <System.String>
				# REQUIRED
				config = @{
					# OPTIONAL
					hostId = <System.String>
					# OPTIONAL
					preserveMoid = <System.Boolean>
					# OPTIONAL
					shouldRecoverTags = <System.Boolean>
					# OPTIONAL
					vlan = <System.Int32>
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
					migrationConfig = @{
						# OPTIONAL
						diskDeviceKeyToStorageId = @(
							@{
								# OPTIONAL
								storageLocationId = <System.String>
								# REQUIRED
								deviceKey = <System.Int32>
							}
						)
						# OPTIONAL
						storageLocationId = <System.String>
						# OPTIONAL
						computeClusterId = <System.String>
						# OPTIONAL
						hostId = <System.String>
						# OPTIONAL
						networkDeviceKeyToNetworkName = @(
							@{
								# REQUIRED
								deviceKey = <System.Int32>
								# REQUIRED
								networkName = <System.String>
							}
						)
						# OPTIONAL
						resourcePoolId = <System.String>
					}
					# OPTIONAL
					shouldMigrateImmediately = <System.Boolean>
				}
				# REQUIRED
				vmId = <System.String>
			}
		)
	}
}"
            );
        }

    } // class Invoke-RscGqlMutateVsphereVmInitiateBatchInstantRecovery
}