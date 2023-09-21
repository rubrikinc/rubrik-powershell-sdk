// New-RscGqlMutationVsphereVmInitiateInstantRecoveryV2.cs
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
    /// Create new GraphQL Mutation vsphereVmInitiateInstantRecoveryV2
    /// vsphereVmInitiateInstantRecoveryV2(input: VsphereVmInitiateInstantRecoveryV2Input!): AsyncRequestStatus!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlMutationVsphereVmInitiateInstantRecoveryV2")
    ]
    public class New_RscGqlMutationVsphereVmInitiateInstantRecoveryV2 : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("vsphereVmInitiateInstantRecoveryV2");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Mutation vsphereVmInitiateInstantRecoveryV2
        /// vsphereVmInitiateInstantRecoveryV2(input: VsphereVmInitiateInstantRecoveryV2Input!): AsyncRequestStatus!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_vsphereVmInitiateInstantRecoveryV2();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_vsphereVmInitiateInstantRecoveryV2()
        {
            this._logger.name += " -vsphereVmInitiateInstantRecoveryV2";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "VsphereVmInitiateInstantRecoveryV2Input!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationVsphereVmInitiateInstantRecoveryV2",
                "($input: VsphereVmInitiateInstantRecoveryV2Input!)",
                "AsyncRequestStatus",
                Mutation.VsphereVmInitiateInstantRecoveryV2_ObjectFieldSpec,
                Mutation.VsphereVmInitiateInstantRecoveryV2FieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
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
	id = <System.String>
}"
            );
        }

    } // class New-RscGqlMutationVsphereVmInitiateInstantRecoveryV2
}