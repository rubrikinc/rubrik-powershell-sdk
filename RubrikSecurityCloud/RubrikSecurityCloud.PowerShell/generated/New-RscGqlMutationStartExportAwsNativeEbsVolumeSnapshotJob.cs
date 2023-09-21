// New-RscGqlMutationStartExportAwsNativeEbsVolumeSnapshotJob.cs
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
    /// Create new GraphQL Mutation startExportAwsNativeEbsVolumeSnapshotJob
    /// startExportAwsNativeEbsVolumeSnapshotJob(input: StartExportAwsNativeEbsVolumeSnapshotJobInput!): AsyncJobStatus!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlMutationStartExportAwsNativeEbsVolumeSnapshotJob")
    ]
    public class New_RscGqlMutationStartExportAwsNativeEbsVolumeSnapshotJob : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("startExportAwsNativeEbsVolumeSnapshotJob");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Mutation startExportAwsNativeEbsVolumeSnapshotJob
        /// startExportAwsNativeEbsVolumeSnapshotJob(input: StartExportAwsNativeEbsVolumeSnapshotJobInput!): AsyncJobStatus!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_startExportAwsNativeEbsVolumeSnapshotJob();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_startExportAwsNativeEbsVolumeSnapshotJob()
        {
            this._logger.name += " -startExportAwsNativeEbsVolumeSnapshotJob";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "StartExportAwsNativeEbsVolumeSnapshotJobInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationStartExportAwsNativeEbsVolumeSnapshotJob",
                "($input: StartExportAwsNativeEbsVolumeSnapshotJobInput!)",
                "AsyncJobStatus",
                Mutation.StartExportAwsNativeEbsVolumeSnapshotJob_ObjectFieldSpec,
                Mutation.StartExportAwsNativeEbsVolumeSnapshotJobFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	snapshotId = <System.String>
	# REQUIRED
	destinationAwsAccountRubrikId = <System.String>
	# REQUIRED
	destinationRegionNativeId = <AwsNativeRegion> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRegion]) for enum values.
	# REQUIRED
	volumeName = <System.String>
	# REQUIRED
	volumeSize = <System.Int32>
	# REQUIRED
	volumeType = <AwsNativeEbsVolumeType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeEbsVolumeType]) for enum values.
	# REQUIRED
	availabilityZone = <System.String>
	# REQUIRED
	iops = <System.Int32>
	# REQUIRED
	shouldCopyTags = <System.Boolean>
	# REQUIRED
	shouldReplaceAttached = <System.Boolean>
	# OPTIONAL
	kmsKeyId = <System.String>
	# OPTIONAL
	snapshotType = <SnapshotType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SnapshotType]) for enum values.
}"
            );
        }

    } // class New-RscGqlMutationStartExportAwsNativeEbsVolumeSnapshotJob
}