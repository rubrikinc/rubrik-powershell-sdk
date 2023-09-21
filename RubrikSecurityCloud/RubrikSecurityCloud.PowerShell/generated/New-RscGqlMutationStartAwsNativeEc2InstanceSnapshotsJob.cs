// New-RscGqlMutationStartAwsNativeEc2InstanceSnapshotsJob.cs
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
    /// Create new GraphQL Mutation startAwsNativeEc2InstanceSnapshotsJob
    /// startAwsNativeEc2InstanceSnapshotsJob(input: StartAwsNativeEc2InstanceSnapshotsJobInput!): BatchAsyncJobStatus!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlMutationStartAwsNativeEc2InstanceSnapshotsJob")
    ]
    public class New_RscGqlMutationStartAwsNativeEc2InstanceSnapshotsJob : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("startAwsNativeEc2InstanceSnapshotsJob");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Mutation startAwsNativeEc2InstanceSnapshotsJob
        /// startAwsNativeEc2InstanceSnapshotsJob(input: StartAwsNativeEc2InstanceSnapshotsJobInput!): BatchAsyncJobStatus!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_startAwsNativeEc2InstanceSnapshotsJob();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_startAwsNativeEc2InstanceSnapshotsJob()
        {
            this._logger.name += " -startAwsNativeEc2InstanceSnapshotsJob";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "StartAwsNativeEc2InstanceSnapshotsJobInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationStartAwsNativeEc2InstanceSnapshotsJob",
                "($input: StartAwsNativeEc2InstanceSnapshotsJobInput!)",
                "BatchAsyncJobStatus",
                Mutation.StartAwsNativeEc2InstanceSnapshotsJob_ObjectFieldSpec,
                Mutation.StartAwsNativeEc2InstanceSnapshotsJobFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	ec2InstanceIds = @(
		<System.String>
	)
	# OPTIONAL
	retentionSlaId = <System.String>
}"
            );
        }

    } // class New-RscGqlMutationStartAwsNativeEc2InstanceSnapshotsJob
}