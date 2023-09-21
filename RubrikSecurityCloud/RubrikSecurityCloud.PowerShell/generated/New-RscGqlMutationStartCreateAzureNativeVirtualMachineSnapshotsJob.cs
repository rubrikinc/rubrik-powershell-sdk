// New-RscGqlMutationStartCreateAzureNativeVirtualMachineSnapshotsJob.cs
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
    /// Create new GraphQL Mutation startCreateAzureNativeVirtualMachineSnapshotsJob
    /// startCreateAzureNativeVirtualMachineSnapshotsJob(input: StartCreateAzureNativeVirtualMachineSnapshotsJobInput!): BatchAsyncJobStatus!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlMutationStartCreateAzureNativeVirtualMachineSnapshotsJob")
    ]
    public class New_RscGqlMutationStartCreateAzureNativeVirtualMachineSnapshotsJob : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("startCreateAzureNativeVirtualMachineSnapshotsJob");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Mutation startCreateAzureNativeVirtualMachineSnapshotsJob
        /// startCreateAzureNativeVirtualMachineSnapshotsJob(input: StartCreateAzureNativeVirtualMachineSnapshotsJobInput!): BatchAsyncJobStatus!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_startCreateAzureNativeVirtualMachineSnapshotsJob();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_startCreateAzureNativeVirtualMachineSnapshotsJob()
        {
            this._logger.name += " -startCreateAzureNativeVirtualMachineSnapshotsJob";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "StartCreateAzureNativeVirtualMachineSnapshotsJobInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationStartCreateAzureNativeVirtualMachineSnapshotsJob",
                "($input: StartCreateAzureNativeVirtualMachineSnapshotsJobInput!)",
                "BatchAsyncJobStatus",
                Mutation.StartCreateAzureNativeVirtualMachineSnapshotsJob_ObjectFieldSpec,
                Mutation.StartCreateAzureNativeVirtualMachineSnapshotsJobFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	virtualMachineRubrikIds = @(
		<System.String>
	)
	# OPTIONAL
	retentionSlaId = <System.String>
}"
            );
        }

    } // class New-RscGqlMutationStartCreateAzureNativeVirtualMachineSnapshotsJob
}