// New-RscGqlMutationStartRestoreAwsNativeEc2InstanceSnapshotJob.cs
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
    /// Create new GraphQL Mutation startRestoreAwsNativeEc2InstanceSnapshotJob
    /// startRestoreAwsNativeEc2InstanceSnapshotJob(input: StartRestoreAwsNativeEc2InstanceSnapshotJobInput!): AsyncJobStatus!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlMutationStartRestoreAwsNativeEc2InstanceSnapshotJob")
    ]
    public class New_RscGqlMutationStartRestoreAwsNativeEc2InstanceSnapshotJob : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("startRestoreAwsNativeEc2InstanceSnapshotJob");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Mutation startRestoreAwsNativeEc2InstanceSnapshotJob
        /// startRestoreAwsNativeEc2InstanceSnapshotJob(input: StartRestoreAwsNativeEc2InstanceSnapshotJobInput!): AsyncJobStatus!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_startRestoreAwsNativeEc2InstanceSnapshotJob();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_startRestoreAwsNativeEc2InstanceSnapshotJob()
        {
            this._logger.name += " -startRestoreAwsNativeEc2InstanceSnapshotJob";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "StartRestoreAwsNativeEc2InstanceSnapshotJobInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationStartRestoreAwsNativeEc2InstanceSnapshotJob",
                "($input: StartRestoreAwsNativeEc2InstanceSnapshotJobInput!)",
                "AsyncJobStatus",
                Mutation.StartRestoreAwsNativeEc2InstanceSnapshotJob_ObjectFieldSpec,
                Mutation.StartRestoreAwsNativeEc2InstanceSnapshotJobFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	snapshotId = <System.String>
	# REQUIRED
	shouldPowerOn = <System.Boolean>
	# REQUIRED
	shouldRestoreTags = <System.Boolean>
	# OPTIONAL
	snapshotTypeToUseIfSourceExpired = <SnapshotTypeToUseIfSourceExpired> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SnapshotTypeToUseIfSourceExpired]) for enum values.
}"
            );
        }

    } // class New-RscGqlMutationStartRestoreAwsNativeEc2InstanceSnapshotJob
}