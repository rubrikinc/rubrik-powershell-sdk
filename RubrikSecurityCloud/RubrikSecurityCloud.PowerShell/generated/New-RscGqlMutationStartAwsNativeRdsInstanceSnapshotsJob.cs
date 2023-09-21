// New-RscGqlMutationStartAwsNativeRdsInstanceSnapshotsJob.cs
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
    /// Create new GraphQL Mutation startAwsNativeRdsInstanceSnapshotsJob
    /// startAwsNativeRdsInstanceSnapshotsJob(input: StartAwsNativeRdsInstanceSnapshotsJobInput!): BatchAsyncJobStatus!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlMutationStartAwsNativeRdsInstanceSnapshotsJob")
    ]
    public class New_RscGqlMutationStartAwsNativeRdsInstanceSnapshotsJob : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("startAwsNativeRdsInstanceSnapshotsJob");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Mutation startAwsNativeRdsInstanceSnapshotsJob
        /// startAwsNativeRdsInstanceSnapshotsJob(input: StartAwsNativeRdsInstanceSnapshotsJobInput!): BatchAsyncJobStatus!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_startAwsNativeRdsInstanceSnapshotsJob();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_startAwsNativeRdsInstanceSnapshotsJob()
        {
            this._logger.name += " -startAwsNativeRdsInstanceSnapshotsJob";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "StartAwsNativeRdsInstanceSnapshotsJobInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationStartAwsNativeRdsInstanceSnapshotsJob",
                "($input: StartAwsNativeRdsInstanceSnapshotsJobInput!)",
                "BatchAsyncJobStatus",
                Mutation.StartAwsNativeRdsInstanceSnapshotsJob_ObjectFieldSpec,
                Mutation.StartAwsNativeRdsInstanceSnapshotsJobFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	rdsInstanceIds = @(
		<System.String>
	)
	# OPTIONAL
	retentionSlaId = <System.String>
}"
            );
        }

    } // class New-RscGqlMutationStartAwsNativeRdsInstanceSnapshotsJob
}