// New-RscMutationAwsNative.cs
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

// ignore warning 'Missing XML comment'
#pragma warning disable 1591

namespace RubrikSecurityCloud.PowerShell.Cmdlets
{
    /// <summary>
    /// Create a new RscQuery object for any of the 8
    /// operations in the 'AWS Native' API domain:
    /// ExcludeEbsVolumesFromSnapshot, StartAccountDisableJob, StartCreateEbsVolumeSnapshotsJob, StartEc2InstanceSnapshotsJob, StartExportEbsVolumeSnapshotJob, StartRdsInstanceSnapshotsJob, StartRefreshAccountsJob, or StartRestoreEc2InstanceSnapshotJob.
    /// </summary>
    /// <description>
    /// New-RscMutationAwsNative creates a new
    /// mutation object for operations
    /// in the 'AWS Native' API domain. It only creates a data structure,
    /// it does not execute the operation. This cmdlet does not need a
    /// connection to run. To execute the operation, either call Invoke()
    /// on the object returned by this cmdlet, or pass the object to
    /// Invoke-Rsc.
    /// There are 8 operations
    /// in the 'AWS Native' API domain. Select the operation this
    /// query is for by specifying the appropriate switch parameter;
    /// one of: -ExcludeEbsVolumesFromSnapshot, -StartAccountDisableJob, -StartCreateEbsVolumeSnapshotsJob, -StartEc2InstanceSnapshotsJob, -StartExportEbsVolumeSnapshotJob, -StartRdsInstanceSnapshotsJob, -StartRefreshAccountsJob, -StartRestoreEc2InstanceSnapshotJob.
    /// Alternatively, you can specify the operation by setting the
    /// -Op parameter, for example: -Op ExcludeEbsVolumesFromSnapshot,
    /// which is equivalent to specifying -ExcludeEbsVolumesFromSnapshot.
    /// Each operation has its own set of variables that can be set with
    /// the -Var parameter. For more info about the variables, 
    /// call Info() on the object returned by this cmdlet, for example:
    /// (New-RscMutationAwsNative -ExcludeEbsVolumesFromSnapshot).Info().
    /// Each operation also has its own set of fields that can be
    /// selected for retrieval. If you do not specify any fields,
    /// a set of default fields will be selected. The selection is
    /// rule-based, and tries to select the most commonly used fields.
    /// For example if a field is named 'id' or 'name', 
    /// it will be selected. If you give -FieldProfile DETAIL, then
    /// another set of rules will be used to select more fields on top
    /// of the default fields. The set of rules for selecting fields
    /// is called a field profile. You can specify a field profile
    /// with the -FieldProfile parameter. You can add or remove fields
    /// from the field profile with the -AddField and -RemoveField
    /// parameters. If you end up with too many -AddField and -RemoveField
    /// parameters, you can list them in a text file, one per line,
    /// with a '+' or '-' prefix, and pass the file name to the
    /// -FilePatch parameter. Profiles and Patches are one way to
    /// customize the fields that are selected. Another way is to
    /// specify the fields by passing the -Field parameter an object
    /// that contains the fields you want to select as properties.
    /// Any property that is not null in that object is interpreted
    /// as a field to select
    /// (and the actual values they are set to do not matter).
    /// The [RubrikSecurityCloud.Types] namespace
    /// contains a set of classes that you can use to specify fields.
    /// To know what [RubrikSecurityCloud.Types] object to use
    /// for a specific operation,
    /// call Info() on the object returned by this cmdlet, for example:
    /// (New-RscMutationAwsNative -ExcludeEbsVolumesFromSnapshot).Info().
    /// You can combine a -Field parameter with patching parameters.
    /// -Field is applied first, then -FilePatch, -AddField and -RemoveField.
    ///
    /// </description>
    ///
    /// <example>
    /// Runs the ExcludeEbsVolumesFromSnapshot operation
    /// of the 'AWS Native' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    AwsNative
    /// # API Operation: ExcludeEbsVolumesFromSnapshot
    /// 
    /// $query = New-RscMutationAwsNative -ExcludeEbsVolumesFromSnapshot
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	awsNativeEc2InstanceId = $someString
    /// 	# REQUIRED
    /// 	volumeIdExclusions = @(
    /// 		@{
    /// 			# REQUIRED
    /// 			volumeId = $someString
    /// 			# REQUIRED
    /// 			isExcluded = $someBoolean
    /// 		}
    /// 	)
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: System.String
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the StartAccountDisableJob operation
    /// of the 'AWS Native' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    AwsNative
    /// # API Operation: StartAccountDisableJob
    /// 
    /// $query = New-RscMutationAwsNative -StartAccountDisableJob
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	awsAccountRubrikId = $someString
    /// 	# REQUIRED
    /// 	shouldDeleteNativeSnapshots = $someBoolean
    /// 	# REQUIRED
    /// 	awsNativeProtectionFeature = $someAwsNativeProtectionFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeProtectionFeature]) for enum values.
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AsyncJobStatus
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the StartCreateEbsVolumeSnapshotsJob operation
    /// of the 'AWS Native' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    AwsNative
    /// # API Operation: StartCreateEbsVolumeSnapshotsJob
    /// 
    /// $query = New-RscMutationAwsNative -StartCreateEbsVolumeSnapshotsJob
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	ebsVolumeIds = @(
    /// 		$someString
    /// 	)
    /// 	# OPTIONAL
    /// 	retentionSlaId = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: BatchAsyncJobStatus
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the StartEc2InstanceSnapshotsJob operation
    /// of the 'AWS Native' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    AwsNative
    /// # API Operation: StartEc2InstanceSnapshotsJob
    /// 
    /// $query = New-RscMutationAwsNative -StartEc2InstanceSnapshotsJob
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	ec2InstanceIds = @(
    /// 		$someString
    /// 	)
    /// 	# OPTIONAL
    /// 	retentionSlaId = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: BatchAsyncJobStatus
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the StartExportEbsVolumeSnapshotJob operation
    /// of the 'AWS Native' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    AwsNative
    /// # API Operation: StartExportEbsVolumeSnapshotJob
    /// 
    /// $query = New-RscMutationAwsNative -StartExportEbsVolumeSnapshotJob
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	snapshotId = $someString
    /// 	# REQUIRED
    /// 	destinationAwsAccountRubrikId = $someString
    /// 	# REQUIRED
    /// 	destinationRegionNativeId = $someAwsNativeRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRegion]) for enum values.
    /// 	# REQUIRED
    /// 	volumeName = $someString
    /// 	# REQUIRED
    /// 	volumeSize = $someInt
    /// 	# REQUIRED
    /// 	volumeType = $someAwsNativeEbsVolumeType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeEbsVolumeType]) for enum values.
    /// 	# REQUIRED
    /// 	availabilityZone = $someString
    /// 	# REQUIRED
    /// 	iops = $someInt
    /// 	# REQUIRED
    /// 	shouldCopyTags = $someBoolean
    /// 	# REQUIRED
    /// 	shouldReplaceAttached = $someBoolean
    /// 	# OPTIONAL
    /// 	kmsKeyId = $someString
    /// 	# OPTIONAL
    /// 	snapshotType = $someSnapshotType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SnapshotType]) for enum values.
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AsyncJobStatus
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the StartRdsInstanceSnapshotsJob operation
    /// of the 'AWS Native' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    AwsNative
    /// # API Operation: StartRdsInstanceSnapshotsJob
    /// 
    /// $query = New-RscMutationAwsNative -StartRdsInstanceSnapshotsJob
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	rdsInstanceIds = @(
    /// 		$someString
    /// 	)
    /// 	# OPTIONAL
    /// 	retentionSlaId = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: BatchAsyncJobStatus
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the StartRefreshAccountsJob operation
    /// of the 'AWS Native' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    AwsNative
    /// # API Operation: StartRefreshAccountsJob
    /// 
    /// $query = New-RscMutationAwsNative -StartRefreshAccountsJob
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	awsAccountRubrikIds = @(
    /// 		$someString
    /// 	)
    /// 	# REQUIRED
    /// 	awsNativeProtectionFeatures = @(
    /// 		$someAwsNativeProtectionFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeProtectionFeature]) for enum values.
    /// 	)
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: BatchAsyncJobStatus
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the StartRestoreEc2InstanceSnapshotJob operation
    /// of the 'AWS Native' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    AwsNative
    /// # API Operation: StartRestoreEc2InstanceSnapshotJob
    /// 
    /// $query = New-RscMutationAwsNative -StartRestoreEc2InstanceSnapshotJob
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	snapshotId = $someString
    /// 	# REQUIRED
    /// 	shouldPowerOn = $someBoolean
    /// 	# REQUIRED
    /// 	shouldRestoreTags = $someBoolean
    /// 	# OPTIONAL
    /// 	snapshotTypeToUseIfSourceExpired = $someSnapshotTypeToUseIfSourceExpired # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SnapshotTypeToUseIfSourceExpired]) for enum values.
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AsyncJobStatus
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscMutationAwsNative",
        DefaultParameterSetName = "StartAccountDisableJob")
    ]
    public class New_RscMutationAwsNative : RscGqlPSCmdlet
    {
        
        [Parameter(
            ParameterSetName = "ExcludeEbsVolumesFromSnapshot",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'ExcludeEbsVolumesFromSnapshot' operation
in the 'AWS Native' API domain.
Description of the operation:
Mark AWS Native EBS Volumes to be excluded from EC2 Instance snapshot. By default, all EBS Volumes are marked as included.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/excludeawsnativeebsvolumesfromsnapshot.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter ExcludeEbsVolumesFromSnapshot { get; set; }

        
        [Parameter(
            ParameterSetName = "StartAccountDisableJob",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'StartAccountDisableJob' operation
in the 'AWS Native' API domain.
Description of the operation:
Starts a job to disable a specific AWS Native account. When complete, the job will disable protection for the specified AWS Native account.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/startawsnativeaccountdisablejob.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter StartAccountDisableJob { get; set; }

        
        [Parameter(
            ParameterSetName = "StartCreateEbsVolumeSnapshotsJob",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'StartCreateEbsVolumeSnapshotsJob' operation
in the 'AWS Native' API domain.
Description of the operation:
Start job to create snapshots of EBS Volumes with given IDs. When completed, this will start taking an on-demand snapshot of the selected EBS Volumes  as per the SLA Policy assigned to the respective volumes.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/startcreateawsnativeebsvolumesnapshotsjob.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter StartCreateEbsVolumeSnapshotsJob { get; set; }

        
        [Parameter(
            ParameterSetName = "StartEc2InstanceSnapshotsJob",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'StartEc2InstanceSnapshotsJob' operation
in the 'AWS Native' API domain.
Description of the operation:
Start an on demand create snapshot job for AWS EC2 Instances.When completed, this will start taking an on-demand snapshot of the selected EC2 Instances  as per the SLA Policy assigned to the respective instances.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/startawsnativeec2instancesnapshotsjob.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter StartEc2InstanceSnapshotsJob { get; set; }

        
        [Parameter(
            ParameterSetName = "StartExportEbsVolumeSnapshotJob",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'StartExportEbsVolumeSnapshotJob' operation
in the 'AWS Native' API domain.
Description of the operation:
Start a job to export EBS Volume. The job creates a new EBS Volume with the same properties as that of the snapshot that is exported.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/startexportawsnativeebsvolumesnapshotjob.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter StartExportEbsVolumeSnapshotJob { get; set; }

        
        [Parameter(
            ParameterSetName = "StartRdsInstanceSnapshotsJob",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'StartRdsInstanceSnapshotsJob' operation
in the 'AWS Native' API domain.
Description of the operation:
Start job to create snapshots of RDS Instance with given IDs. When completed, this will start taking an on-demand snapshot of the selected RDS Instances  as per the SLA Policy assigned to the respective instances.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/startawsnativerdsinstancesnapshotsjob.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter StartRdsInstanceSnapshotsJob { get; set; }

        
        [Parameter(
            ParameterSetName = "StartRefreshAccountsJob",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'StartRefreshAccountsJob' operation
in the 'AWS Native' API domain.
Description of the operation:
Start an on demand job to refresh AWS accounts. The job updates the Rubrik platform with changes to the AWS Native accounts.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/startrefreshawsnativeaccountsjob.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter StartRefreshAccountsJob { get; set; }

        
        [Parameter(
            ParameterSetName = "StartRestoreEc2InstanceSnapshotJob",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'StartRestoreEc2InstanceSnapshotJob' operation
in the 'AWS Native' API domain.
Description of the operation:
Start an on demand restore snapshot job for AWS EC2 Instance. When completed, this will replace the original EC2 Instance with the selected snapshot.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/startrestoreawsnativeec2instancesnapshotjob.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter StartRestoreEc2InstanceSnapshotJob { get; set; }



        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                switch(this.GetOp().OpName())
                {
                    case "ExcludeEbsVolumesFromSnapshot":
                        this.ProcessRecord_ExcludeEbsVolumesFromSnapshot();
                        break;
                    case "StartAccountDisableJob":
                        this.ProcessRecord_StartAccountDisableJob();
                        break;
                    case "StartCreateEbsVolumeSnapshotsJob":
                        this.ProcessRecord_StartCreateEbsVolumeSnapshotsJob();
                        break;
                    case "StartEc2InstanceSnapshotsJob":
                        this.ProcessRecord_StartEc2InstanceSnapshotsJob();
                        break;
                    case "StartExportEbsVolumeSnapshotJob":
                        this.ProcessRecord_StartExportEbsVolumeSnapshotJob();
                        break;
                    case "StartRdsInstanceSnapshotsJob":
                        this.ProcessRecord_StartRdsInstanceSnapshotsJob();
                        break;
                    case "StartRefreshAccountsJob":
                        this.ProcessRecord_StartRefreshAccountsJob();
                        break;
                    case "StartRestoreEc2InstanceSnapshotJob":
                        this.ProcessRecord_StartRestoreEc2InstanceSnapshotJob();
                        break;
                    default:
                        throw new Exception("Unknown Operation " + this.GetOp().OpName());
                }
           }
           catch (Exception ex)
           {
                ThrowTerminatingException(ex);
           }
        }

        // This parameter set invokes a single graphql operation:
        // excludeAwsNativeEbsVolumesFromSnapshot.
        internal void ProcessRecord_ExcludeEbsVolumesFromSnapshot()
        {
            this._logger.name += " -ExcludeEbsVolumesFromSnapshot";
            // Create new graphql operation excludeAwsNativeEbsVolumesFromSnapshot
            InitMutationExcludeAwsNativeEbsVolumesFromSnapshot();
        }

        // This parameter set invokes a single graphql operation:
        // startAwsNativeAccountDisableJob.
        internal void ProcessRecord_StartAccountDisableJob()
        {
            this._logger.name += " -StartAccountDisableJob";
            // Create new graphql operation startAwsNativeAccountDisableJob
            InitMutationStartAwsNativeAccountDisableJob();
        }

        // This parameter set invokes a single graphql operation:
        // startCreateAwsNativeEbsVolumeSnapshotsJob.
        internal void ProcessRecord_StartCreateEbsVolumeSnapshotsJob()
        {
            this._logger.name += " -StartCreateEbsVolumeSnapshotsJob";
            // Create new graphql operation startCreateAwsNativeEbsVolumeSnapshotsJob
            InitMutationStartCreateAwsNativeEbsVolumeSnapshotsJob();
        }

        // This parameter set invokes a single graphql operation:
        // startAwsNativeEc2InstanceSnapshotsJob.
        internal void ProcessRecord_StartEc2InstanceSnapshotsJob()
        {
            this._logger.name += " -StartEc2InstanceSnapshotsJob";
            // Create new graphql operation startAwsNativeEc2InstanceSnapshotsJob
            InitMutationStartAwsNativeEc2InstanceSnapshotsJob();
        }

        // This parameter set invokes a single graphql operation:
        // startExportAwsNativeEbsVolumeSnapshotJob.
        internal void ProcessRecord_StartExportEbsVolumeSnapshotJob()
        {
            this._logger.name += " -StartExportEbsVolumeSnapshotJob";
            // Create new graphql operation startExportAwsNativeEbsVolumeSnapshotJob
            InitMutationStartExportAwsNativeEbsVolumeSnapshotJob();
        }

        // This parameter set invokes a single graphql operation:
        // startAwsNativeRdsInstanceSnapshotsJob.
        internal void ProcessRecord_StartRdsInstanceSnapshotsJob()
        {
            this._logger.name += " -StartRdsInstanceSnapshotsJob";
            // Create new graphql operation startAwsNativeRdsInstanceSnapshotsJob
            InitMutationStartAwsNativeRdsInstanceSnapshotsJob();
        }

        // This parameter set invokes a single graphql operation:
        // startRefreshAwsNativeAccountsJob.
        internal void ProcessRecord_StartRefreshAccountsJob()
        {
            this._logger.name += " -StartRefreshAccountsJob";
            // Create new graphql operation startRefreshAwsNativeAccountsJob
            InitMutationStartRefreshAwsNativeAccountsJob();
        }

        // This parameter set invokes a single graphql operation:
        // startRestoreAwsNativeEc2InstanceSnapshotJob.
        internal void ProcessRecord_StartRestoreEc2InstanceSnapshotJob()
        {
            this._logger.name += " -StartRestoreEc2InstanceSnapshotJob";
            // Create new graphql operation startRestoreAwsNativeEc2InstanceSnapshotJob
            InitMutationStartRestoreAwsNativeEc2InstanceSnapshotJob();
        }


        // Create new GraphQL Mutation:
        // excludeAwsNativeEbsVolumesFromSnapshot(input: ExcludeAwsNativeEbsVolumesFromSnapshotInput!): Void
        internal void InitMutationExcludeAwsNativeEbsVolumesFromSnapshot()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "ExcludeAwsNativeEbsVolumesFromSnapshotInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationExcludeAwsNativeEbsVolumesFromSnapshot",
                "($input: ExcludeAwsNativeEbsVolumesFromSnapshotInput!)",
                "System.String",
                Mutation.ExcludeAwsNativeEbsVolumesFromSnapshot_ObjectFieldSpec,
                Mutation.ExcludeAwsNativeEbsVolumesFromSnapshotFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	awsNativeEc2InstanceId = $someString
	# REQUIRED
	volumeIdExclusions = @(
		@{
			# REQUIRED
			volumeId = $someString
			# REQUIRED
			isExcluded = $someBoolean
		}
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // startAwsNativeAccountDisableJob(input: StartAwsNativeAccountDisableJobInput!): AsyncJobStatus!
        internal void InitMutationStartAwsNativeAccountDisableJob()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "StartAwsNativeAccountDisableJobInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationStartAwsNativeAccountDisableJob",
                "($input: StartAwsNativeAccountDisableJobInput!)",
                "AsyncJobStatus",
                Mutation.StartAwsNativeAccountDisableJob_ObjectFieldSpec,
                Mutation.StartAwsNativeAccountDisableJobFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	awsAccountRubrikId = $someString
	# REQUIRED
	shouldDeleteNativeSnapshots = $someBoolean
	# REQUIRED
	awsNativeProtectionFeature = $someAwsNativeProtectionFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeProtectionFeature]) for enum values.
}"
            );
        }

        // Create new GraphQL Mutation:
        // startCreateAwsNativeEbsVolumeSnapshotsJob(input: StartCreateAwsNativeEbsVolumeSnapshotsJobInput!): BatchAsyncJobStatus!
        internal void InitMutationStartCreateAwsNativeEbsVolumeSnapshotsJob()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "StartCreateAwsNativeEbsVolumeSnapshotsJobInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationStartCreateAwsNativeEbsVolumeSnapshotsJob",
                "($input: StartCreateAwsNativeEbsVolumeSnapshotsJobInput!)",
                "BatchAsyncJobStatus",
                Mutation.StartCreateAwsNativeEbsVolumeSnapshotsJob_ObjectFieldSpec,
                Mutation.StartCreateAwsNativeEbsVolumeSnapshotsJobFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	ebsVolumeIds = @(
		$someString
	)
	# OPTIONAL
	retentionSlaId = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // startAwsNativeEc2InstanceSnapshotsJob(input: StartAwsNativeEc2InstanceSnapshotsJobInput!): BatchAsyncJobStatus!
        internal void InitMutationStartAwsNativeEc2InstanceSnapshotsJob()
        {
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
$query.Var.input = @{
	# REQUIRED
	ec2InstanceIds = @(
		$someString
	)
	# OPTIONAL
	retentionSlaId = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // startExportAwsNativeEbsVolumeSnapshotJob(input: StartExportAwsNativeEbsVolumeSnapshotJobInput!): AsyncJobStatus!
        internal void InitMutationStartExportAwsNativeEbsVolumeSnapshotJob()
        {
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
$query.Var.input = @{
	# REQUIRED
	snapshotId = $someString
	# REQUIRED
	destinationAwsAccountRubrikId = $someString
	# REQUIRED
	destinationRegionNativeId = $someAwsNativeRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRegion]) for enum values.
	# REQUIRED
	volumeName = $someString
	# REQUIRED
	volumeSize = $someInt
	# REQUIRED
	volumeType = $someAwsNativeEbsVolumeType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeEbsVolumeType]) for enum values.
	# REQUIRED
	availabilityZone = $someString
	# REQUIRED
	iops = $someInt
	# REQUIRED
	shouldCopyTags = $someBoolean
	# REQUIRED
	shouldReplaceAttached = $someBoolean
	# OPTIONAL
	kmsKeyId = $someString
	# OPTIONAL
	snapshotType = $someSnapshotType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SnapshotType]) for enum values.
}"
            );
        }

        // Create new GraphQL Mutation:
        // startAwsNativeRdsInstanceSnapshotsJob(input: StartAwsNativeRdsInstanceSnapshotsJobInput!): BatchAsyncJobStatus!
        internal void InitMutationStartAwsNativeRdsInstanceSnapshotsJob()
        {
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
$query.Var.input = @{
	# REQUIRED
	rdsInstanceIds = @(
		$someString
	)
	# OPTIONAL
	retentionSlaId = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // startRefreshAwsNativeAccountsJob(input: StartRefreshAwsNativeAccountsJobInput!): BatchAsyncJobStatus!
        internal void InitMutationStartRefreshAwsNativeAccountsJob()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "StartRefreshAwsNativeAccountsJobInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationStartRefreshAwsNativeAccountsJob",
                "($input: StartRefreshAwsNativeAccountsJobInput!)",
                "BatchAsyncJobStatus",
                Mutation.StartRefreshAwsNativeAccountsJob_ObjectFieldSpec,
                Mutation.StartRefreshAwsNativeAccountsJobFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	awsAccountRubrikIds = @(
		$someString
	)
	# REQUIRED
	awsNativeProtectionFeatures = @(
		$someAwsNativeProtectionFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeProtectionFeature]) for enum values.
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // startRestoreAwsNativeEc2InstanceSnapshotJob(input: StartRestoreAwsNativeEc2InstanceSnapshotJobInput!): AsyncJobStatus!
        internal void InitMutationStartRestoreAwsNativeEc2InstanceSnapshotJob()
        {
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
$query.Var.input = @{
	# REQUIRED
	snapshotId = $someString
	# REQUIRED
	shouldPowerOn = $someBoolean
	# REQUIRED
	shouldRestoreTags = $someBoolean
	# OPTIONAL
	snapshotTypeToUseIfSourceExpired = $someSnapshotTypeToUseIfSourceExpired # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SnapshotTypeToUseIfSourceExpired]) for enum values.
}"
            );
        }


    } // class New_RscMutationAwsNative
}