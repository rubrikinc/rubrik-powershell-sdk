// New-RscGqlMutationStartRestoreAzureNativeVirtualMachineJob.cs
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
    /// Create new GraphQL Mutation startRestoreAzureNativeVirtualMachineJob
    /// startRestoreAzureNativeVirtualMachineJob(input: StartRestoreAzureNativeVirtualMachineJobInput!): AsyncJobStatus!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlMutationStartRestoreAzureNativeVirtualMachineJob")
    ]
    public class New_RscGqlMutationStartRestoreAzureNativeVirtualMachineJob : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("startRestoreAzureNativeVirtualMachineJob");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Mutation startRestoreAzureNativeVirtualMachineJob
        /// startRestoreAzureNativeVirtualMachineJob(input: StartRestoreAzureNativeVirtualMachineJobInput!): AsyncJobStatus!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_startRestoreAzureNativeVirtualMachineJob();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_startRestoreAzureNativeVirtualMachineJob()
        {
            this._logger.name += " -startRestoreAzureNativeVirtualMachineJob";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "StartRestoreAzureNativeVirtualMachineJobInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationStartRestoreAzureNativeVirtualMachineJob",
                "($input: StartRestoreAzureNativeVirtualMachineJobInput!)",
                "AsyncJobStatus",
                Mutation.StartRestoreAzureNativeVirtualMachineJob_ObjectFieldSpec,
                Mutation.StartRestoreAzureNativeVirtualMachineJobFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	snapshotId = <System.String>
	# REQUIRED
	shouldPowerOn = <System.Boolean>
	# REQUIRED
	shouldRestoreTags = <System.Boolean>
	# OPTIONAL
	snapshotTypeToUseIfSourceExpired = <SnapshotTypeForRestoreIfSourceExpired> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SnapshotTypeForRestoreIfSourceExpired]) for enum values.
	# OPTIONAL
	recoveryDiskIds = @(
		<System.String>
	)
}"
            );
        }

    } // class New-RscGqlMutationStartRestoreAzureNativeVirtualMachineJob
}