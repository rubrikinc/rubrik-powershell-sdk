// Invoke-RscGqlMutateStartExportAzureNativeVirtualMachineJob.cs
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
    /// Invoke GraphQL Mutation startExportAzureNativeVirtualMachineJob
    /// startExportAzureNativeVirtualMachineJob(input: StartExportAzureNativeVirtualMachineJobInput!): AsyncJobStatus!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "Invoke",
        "RscGqlMutateStartExportAzureNativeVirtualMachineJob")
    ]
    public class Invoke_RscGqlMutateStartExportAzureNativeVirtualMachineJob : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the Invoke-RscGqlQuery* cmdlets
        // fit in the Invoke-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("startExportAzureNativeVirtualMachineJob");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Invoke GraphQL Mutation startExportAzureNativeVirtualMachineJob
        /// startExportAzureNativeVirtualMachineJob(input: StartExportAzureNativeVirtualMachineJobInput!): AsyncJobStatus!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_startExportAzureNativeVirtualMachineJob();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_startExportAzureNativeVirtualMachineJob()
        {
            this._logger.name += " -startExportAzureNativeVirtualMachineJob";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "StartExportAzureNativeVirtualMachineJobInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationStartExportAzureNativeVirtualMachineJob",
                "($input: StartExportAzureNativeVirtualMachineJobInput!)",
                "AsyncJobStatus",
                Mutation.StartExportAzureNativeVirtualMachineJob_ObjectFieldSpec,
                Mutation.StartExportAzureNativeVirtualMachineJobFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	snapshotId = <System.String>
	# REQUIRED
	virtualMachineName = <System.String>
	# OPTIONAL
	diskEncryptionSetNativeId = <System.String>
	# REQUIRED
	resourceGroupName = <System.String>
	# REQUIRED
	destinationRegion = <AzureNativeRegion> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeRegion]) for enum values.
	# OPTIONAL
	destinationAvailabilityZone = <System.String>
	# OPTIONAL
	destinationSubscriptionRubrikId = <System.String>
	# REQUIRED
	virtualMachineSize = <System.String>
	# REQUIRED
	subnetNativeId = <System.String>
	# OPTIONAL
	networkSecurityGroupNativeId = <System.String>
	# REQUIRED
	shouldExportTags = <System.Boolean>
	# REQUIRED
	shouldPowerOff = <System.Boolean>
	# OPTIONAL
	shouldUseReplica = <System.Boolean>
	# OPTIONAL
	availabilitySetNativeId = <System.String>
	# OPTIONAL
	shouldEnableAcceleratedNetworking = <System.Boolean>
	# OPTIONAL
	snapshotType = <AzureSnapshotType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureSnapshotType]) for enum values.
	# OPTIONAL
	recoveryDiskIds = @(
		<System.String>
	)
}"
            );
        }

    } // class Invoke-RscGqlMutateStartExportAzureNativeVirtualMachineJob
}