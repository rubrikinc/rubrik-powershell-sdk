// New-RscMutationSnapshot.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections;
using System.Collections.Generic;
using System.Management.Automation;
using System.Text;
using System.Linq;
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
    /// Create a new RscQuery object for any of the 17
    /// operations in the 'Snapshot' API domain:
    /// BatchQuarantine, BatchReleaseFromQuarantine, BulkTierExistings, CreateDomainController, CreateDownloadForVolumeGroup, CreateFileset, DeleteCloudWorkload, DeleteFilesets, FilesetDownloadFiles, FilesetExportFiles, RestoreDomainController, RestoreVolumeGroupFiles, StartEc2InstanceExportJob, StartRecoverS3Job, TakeOnDemand, UploadDatabaseToBlobstore, or VmwareDownloadFromLocation.
    /// </summary>
    /// <description>
    /// New-RscMutationSnapshot creates a new
    /// mutation object for operations
    /// in the 'Snapshot' API domain. It only creates a data structure,
    /// it does not execute the operation. This cmdlet does not need a
    /// connection to run. To execute the operation, either call Invoke()
    /// on the object returned by this cmdlet, or pass the object to
    /// Invoke-Rsc.
    /// There are 17 operations
    /// in the 'Snapshot' API domain. Select the operation this
    /// query is for by specifying the appropriate value for the
    /// -Operation parameter;
    /// one of: BatchQuarantine, BatchReleaseFromQuarantine, BulkTierExistings, CreateDomainController, CreateDownloadForVolumeGroup, CreateFileset, DeleteCloudWorkload, DeleteFilesets, FilesetDownloadFiles, FilesetExportFiles, RestoreDomainController, RestoreVolumeGroupFiles, StartEc2InstanceExportJob, StartRecoverS3Job, TakeOnDemand, UploadDatabaseToBlobstore, or VmwareDownloadFromLocation.
    /// Each operation has its own set of variables that can be set with
    /// the -Var parameter. For more info about the variables, 
    /// call Info() on the object returned by this cmdlet, for example:
    /// (New-RscMutationSnapshot -BatchQuarantine).Info().
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
    /// (New-RscMutationSnapshot -BatchQuarantine).Info().
    /// You can combine a -Field parameter with patching parameters.
    /// -Field is applied first, then -FilePatch, -AddField and -RemoveField.
    ///
    /// </description>
    ///
    /// <example>
    /// Runs the BatchQuarantine operation
    /// of the 'Snapshot' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Snapshot
    /// # API Operation: BatchQuarantine
    /// 
    /// $query = New-RscMutationSnapshot -BatchQuarantine
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	quarantineSpecs = @(
    /// 		@{
    /// 			# REQUIRED
    /// 			snapshotId = $someString
    /// 			# REQUIRED
    /// 			filesDetails = @(
    /// 				@{
    /// 					# REQUIRED
    /// 					fileName = $someString
    /// 				}
    /// 			)
    /// 		}
    /// 	)
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: BatchQuarantineSnapshotReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the BatchReleaseFromQuarantine operation
    /// of the 'Snapshot' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Snapshot
    /// # API Operation: BatchReleaseFromQuarantine
    /// 
    /// $query = New-RscMutationSnapshot -BatchReleaseFromQuarantine
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	quarantineSpecs = @(
    /// 		@{
    /// 			# REQUIRED
    /// 			snapshotId = $someString
    /// 			# REQUIRED
    /// 			filesDetails = @(
    /// 				@{
    /// 					# REQUIRED
    /// 					fileName = $someString
    /// 				}
    /// 			)
    /// 		}
    /// 	)
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: BatchReleaseFromQuarantineSnapshotReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the BulkTierExistings operation
    /// of the 'Snapshot' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Snapshot
    /// # API Operation: BulkTierExistings
    /// 
    /// $query = New-RscMutationSnapshot -BulkTierExistings
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	clusterUuid = $someString
    /// 	# REQUIRED
    /// 	objectTierInfo = @{
    /// 		# OPTIONAL
    /// 		locationId = $someString
    /// 		# REQUIRED
    /// 		objectIds = @(
    /// 			$someString
    /// 		)
    /// 	}
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AsyncRequestStatus
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CreateDomainController operation
    /// of the 'Snapshot' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Snapshot
    /// # API Operation: CreateDomainController
    /// 
    /// $query = New-RscMutationSnapshot -CreateDomainController
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	config = @{
    /// 		# OPTIONAL
    /// 		slaId = $someString
    /// 	}
    /// 	# REQUIRED
    /// 	id = $someString
    /// 	# OPTIONAL
    /// 	userNote = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AsyncRequestStatus
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CreateDownloadForVolumeGroup operation
    /// of the 'Snapshot' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Snapshot
    /// # API Operation: CreateDownloadForVolumeGroup
    /// 
    /// $query = New-RscMutationSnapshot -CreateDownloadForVolumeGroup
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	id = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AsyncRequestStatus
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CreateFileset operation
    /// of the 'Snapshot' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Snapshot
    /// # API Operation: CreateFileset
    /// 
    /// $query = New-RscMutationSnapshot -CreateFileset
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	config = @{
    /// 		# OPTIONAL
    /// 		slaId = $someString
    /// 	}
    /// 	# REQUIRED
    /// 	id = $someString
    /// 	# OPTIONAL
    /// 	userNote = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AsyncRequestStatus
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the DeleteCloudWorkload operation
    /// of the 'Snapshot' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Snapshot
    /// # API Operation: DeleteCloudWorkload
    /// 
    /// $query = New-RscMutationSnapshot -DeleteCloudWorkload
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	snapshotId = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: System.Boolean
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the DeleteFilesets operation
    /// of the 'Snapshot' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Snapshot
    /// # API Operation: DeleteFilesets
    /// 
    /// $query = New-RscMutationSnapshot -DeleteFilesets
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	clusterUuid = $someString
    /// 	# REQUIRED
    /// 	id = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: ResponseSuccess
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the FilesetDownloadFiles operation
    /// of the 'Snapshot' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Snapshot
    /// # API Operation: FilesetDownloadFiles
    /// 
    /// $query = New-RscMutationSnapshot -FilesetDownloadFiles
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	id = $someString
    /// 	# OPTIONAL
    /// 	nextSnapshotFid = $someString
    /// 	# OPTIONAL
    /// 	userNote = $someString
    /// 	# OPTIONAL
    /// 	zipPassword = $someString
    /// 	# REQUIRED
    /// 	config = @{
    /// 		# OPTIONAL
    /// 		legalHoldDownloadConfig = @{
    /// 			# REQUIRED
    /// 			isLegalHoldDownload = $someBoolean
    /// 		}
    /// 		# OPTIONAL
    /// 		zipPassword = $someString
    /// 		# REQUIRED
    /// 		sourceDirs = @(
    /// 			$someString
    /// 		)
    /// 	}
    /// 	# OPTIONAL
    /// 	deltaTypeFilter = @(
    /// 		$someDeltaType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DeltaType]) for enum values.
    /// 	)
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AsyncRequestStatus
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the FilesetExportFiles operation
    /// of the 'Snapshot' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Snapshot
    /// # API Operation: FilesetExportFiles
    /// 
    /// $query = New-RscMutationSnapshot -FilesetExportFiles
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	id = $someString
    /// 	# OPTIONAL
    /// 	nextSnapshotFid = $someString
    /// 	# OPTIONAL
    /// 	deltaTypeFilter = @(
    /// 		$someDeltaType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DeltaType]) for enum values.
    /// 	)
    /// 	# REQUIRED
    /// 	config = @{
    /// 		# OPTIONAL
    /// 		hostId = $someString
    /// 		# OPTIONAL
    /// 		ignoreErrors = $someBoolean
    /// 		# OPTIONAL
    /// 		shareId = $someString
    /// 		# REQUIRED
    /// 		exportPathPairs = @(
    /// 			@{
    /// 				# OPTIONAL
    /// 				exportPathPair = @{
    /// 					# REQUIRED
    /// 					dstPath = $someString
    /// 					# REQUIRED
    /// 					srcPath = $someString
    /// 				}
    /// 			}
    /// 		)
    /// 	}
    /// 	# REQUIRED
    /// 	shareType = $someShareTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ShareTypeEnum]) for enum values.
    /// 	# REQUIRED
    /// 	osType = $someGuestOsType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.GuestOsType]) for enum values.
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AsyncRequestStatus
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the RestoreDomainController operation
    /// of the 'Snapshot' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Snapshot
    /// # API Operation: RestoreDomainController
    /// 
    /// $query = New-RscMutationSnapshot -RestoreDomainController
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	config = @{
    /// 		# OPTIONAL
    /// 		snapshotForAuthoritativeRestore = $someString
    /// 		# REQUIRED
    /// 		domainControllerRestoreConfigs = @(
    /// 			@{
    /// 				# OPTIONAL
    /// 				hostId = $someString
    /// 				# REQUIRED
    /// 				snapshotId = $someString
    /// 			}
    /// 		)
    /// 		# REQUIRED
    /// 		shouldPerformAuthoritativeAdObjectsRestore = $someBoolean
    /// 		# REQUIRED
    /// 		shouldPerformAuthoritativeSysvolRestore = $someBoolean
    /// 	}
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AsyncRequestStatus
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the RestoreVolumeGroupFiles operation
    /// of the 'Snapshot' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Snapshot
    /// # API Operation: RestoreVolumeGroupFiles
    /// 
    /// $query = New-RscMutationSnapshot -RestoreVolumeGroupFiles
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	id = $someString
    /// 	# OPTIONAL
    /// 	nextSnapshotFid = $someString
    /// 	# REQUIRED
    /// 	config = @{
    /// 		# OPTIONAL
    /// 		targetHostId = $someString
    /// 		# REQUIRED
    /// 		restoreConfigs = @(
    /// 			@{
    /// 				# REQUIRED
    /// 				path = $someString
    /// 				# REQUIRED
    /// 				restorePath = $someString
    /// 			}
    /// 		)
    /// 	}
    /// 	# OPTIONAL
    /// 	deltaTypeFilter = @(
    /// 		$someDeltaType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DeltaType]) for enum values.
    /// 	)
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AsyncRequestStatus
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the StartEc2InstanceExportJob operation
    /// of the 'Snapshot' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Snapshot
    /// # API Operation: StartEc2InstanceExportJob
    /// 
    /// $query = New-RscMutationSnapshot -StartEc2InstanceExportJob
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	snapshotId = $someString
    /// 	# REQUIRED
    /// 	destinationAwsAccountRubrikId = $someString
    /// 	# REQUIRED
    /// 	instanceType = $someAwsNativeEc2InstanceType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeEc2InstanceType]) for enum values.
    /// 	# REQUIRED
    /// 	instanceName = $someString
    /// 	# REQUIRED
    /// 	securityGroupIds = @(
    /// 		$someString
    /// 	)
    /// 	# REQUIRED
    /// 	subnetId = $someString
    /// 	# REQUIRED
    /// 	destinationRegionId = $someAwsNativeRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRegion]) for enum values.
    /// 	# REQUIRED
    /// 	shouldCopyTags = $someBoolean
    /// 	# OPTIONAL
    /// 	kmsKeyId = $someString
    /// 	# OPTIONAL
    /// 	sshKeyPairName = $someString
    /// 	# OPTIONAL
    /// 	exportInstanceInPoweredOffState = $someBoolean
    /// 	# OPTIONAL
    /// 	snapshotType = $someSnapshotType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SnapshotType]) for enum values.
    /// 	# OPTIONAL
    /// 	amiId = $someString
    /// 	# OPTIONAL
    /// 	iamInstanceProfileArn = $someString
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
    /// Runs the StartRecoverS3Job operation
    /// of the 'Snapshot' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Snapshot
    /// # API Operation: StartRecoverS3Job
    /// 
    /// $query = New-RscMutationSnapshot -StartRecoverS3Job
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	workloadId = $someString
    /// 	# OPTIONAL
    /// 	snapshotId = $someString
    /// 	# OPTIONAL
    /// 	restoreDate = $someDateTime
    /// 	# REQUIRED
    /// 	destinationBucketArn = $someString
    /// 	# REQUIRED
    /// 	shouldRecoverFullBucket = $someBoolean
    /// 	# REQUIRED
    /// 	objectKeys = @(
    /// 		$someString
    /// 	)
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
    /// Runs the TakeOnDemand operation
    /// of the 'Snapshot' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Snapshot
    /// # API Operation: TakeOnDemand
    /// 
    /// $query = New-RscMutationSnapshot -TakeOnDemand
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	workloadIds = @(
    /// 		$someString
    /// 	)
    /// 	# REQUIRED
    /// 	slaId = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: TakeOnDemandSnapshotReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the UploadDatabaseToBlobstore operation
    /// of the 'Snapshot' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Snapshot
    /// # API Operation: UploadDatabaseToBlobstore
    /// 
    /// $query = New-RscMutationSnapshot -UploadDatabaseToBlobstore
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	snapshotId = $someString
    /// 	# OPTIONAL
    /// 	targetStorageAccountConfigInput = @{
    /// 		# REQUIRED
    /// 		subscriptionCloudAccountId = $someString
    /// 		# REQUIRED
    /// 		resourceGroupName = $someString
    /// 		# REQUIRED
    /// 		storageAccountName = $someString
    /// 		# OPTIONAL
    /// 		tags = @{
    /// 			# REQUIRED
    /// 			tagList = @(
    /// 				@{
    /// 					# REQUIRED
    /// 					key = $someString
    /// 					# REQUIRED
    /// 					value = $someString
    /// 				}
    /// 			)
    /// 		}
    /// 	}
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
    /// Runs the VmwareDownloadFromLocation operation
    /// of the 'Snapshot' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Snapshot
    /// # API Operation: VmwareDownloadFromLocation
    /// 
    /// $query = New-RscMutationSnapshot -VmwareDownloadFromLocation
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	downloadConfig = @{
    /// 		# OPTIONAL
    /// 		slaId = $someString
    /// 	}
    /// 	# REQUIRED
    /// 	locationId = $someString
    /// 	# REQUIRED
    /// 	snapshotId = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AsyncRequestStatus
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
        "RscMutationSnapshot",
        DefaultParameterSetName = "Operation")
    ]
    public class New_RscMutationSnapshot : RscGqlPSCmdlet
    {
        [Parameter(
            Mandatory = true, 
            ParameterSetName = "Operation",
            HelpMessage = "API Operation. The set of operations depends on the API domain. See reference at: https://github.com/rubrikinc/rubrik-powershell-sdk/blob/main/docs/domains_and_operations.md",
            Position = 0,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = true)]
            [ValidateSet(
                "BatchQuarantine",
                "BatchReleaseFromQuarantine",
                "BulkTierExistings",
                "CreateDomainController",
                "CreateDownloadForVolumeGroup",
                "CreateFileset",
                "DeleteCloudWorkload",
                "DeleteFilesets",
                "FilesetDownloadFiles",
                "FilesetExportFiles",
                "RestoreDomainController",
                "RestoreVolumeGroupFiles",
                "StartEc2InstanceExportJob",
                "StartRecoverS3Job",
                "TakeOnDemand",
                "UploadDatabaseToBlobstore",
                "VmwareDownloadFromLocation",
                IgnoreCase = true)]
        public string Operation { get; set; } = "";

        internal override string GetOperationParameter()
        {
            return this.Operation;
        }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                switch(this.GetOp().OpName())
                {
                    case "BatchQuarantine":
                        this.ProcessRecord_BatchQuarantine();
                        break;
                    case "BatchReleaseFromQuarantine":
                        this.ProcessRecord_BatchReleaseFromQuarantine();
                        break;
                    case "BulkTierExistings":
                        this.ProcessRecord_BulkTierExistings();
                        break;
                    case "CreateDomainController":
                        this.ProcessRecord_CreateDomainController();
                        break;
                    case "CreateDownloadForVolumeGroup":
                        this.ProcessRecord_CreateDownloadForVolumeGroup();
                        break;
                    case "CreateFileset":
                        this.ProcessRecord_CreateFileset();
                        break;
                    case "DeleteCloudWorkload":
                        this.ProcessRecord_DeleteCloudWorkload();
                        break;
                    case "DeleteFilesets":
                        this.ProcessRecord_DeleteFilesets();
                        break;
                    case "FilesetDownloadFiles":
                        this.ProcessRecord_FilesetDownloadFiles();
                        break;
                    case "FilesetExportFiles":
                        this.ProcessRecord_FilesetExportFiles();
                        break;
                    case "RestoreDomainController":
                        this.ProcessRecord_RestoreDomainController();
                        break;
                    case "RestoreVolumeGroupFiles":
                        this.ProcessRecord_RestoreVolumeGroupFiles();
                        break;
                    case "StartEc2InstanceExportJob":
                        this.ProcessRecord_StartEc2InstanceExportJob();
                        break;
                    case "StartRecoverS3Job":
                        this.ProcessRecord_StartRecoverS3Job();
                        break;
                    case "TakeOnDemand":
                        this.ProcessRecord_TakeOnDemand();
                        break;
                    case "UploadDatabaseToBlobstore":
                        this.ProcessRecord_UploadDatabaseToBlobstore();
                        break;
                    case "VmwareDownloadFromLocation":
                        this.ProcessRecord_VmwareDownloadFromLocation();
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
        // batchQuarantineSnapshot.
        internal void ProcessRecord_BatchQuarantine()
        {
            this._logger.name += " -BatchQuarantine";
            // Create new graphql operation batchQuarantineSnapshot
            InitMutationBatchQuarantineSnapshot();
        }

        // This parameter set invokes a single graphql operation:
        // batchReleaseFromQuarantineSnapshot.
        internal void ProcessRecord_BatchReleaseFromQuarantine()
        {
            this._logger.name += " -BatchReleaseFromQuarantine";
            // Create new graphql operation batchReleaseFromQuarantineSnapshot
            InitMutationBatchReleaseFromQuarantineSnapshot();
        }

        // This parameter set invokes a single graphql operation:
        // bulkTierExistingSnapshots.
        internal void ProcessRecord_BulkTierExistings()
        {
            this._logger.name += " -BulkTierExistings";
            // Create new graphql operation bulkTierExistingSnapshots
            InitMutationBulkTierExistingSnapshots();
        }

        // This parameter set invokes a single graphql operation:
        // createDomainControllerSnapshot.
        internal void ProcessRecord_CreateDomainController()
        {
            this._logger.name += " -CreateDomainController";
            // Create new graphql operation createDomainControllerSnapshot
            InitMutationCreateDomainControllerSnapshot();
        }

        // This parameter set invokes a single graphql operation:
        // createDownloadSnapshotForVolumeGroup.
        internal void ProcessRecord_CreateDownloadForVolumeGroup()
        {
            this._logger.name += " -CreateDownloadForVolumeGroup";
            // Create new graphql operation createDownloadSnapshotForVolumeGroup
            InitMutationCreateDownloadSnapshotForVolumeGroup();
        }

        // This parameter set invokes a single graphql operation:
        // createFilesetSnapshot.
        internal void ProcessRecord_CreateFileset()
        {
            this._logger.name += " -CreateFileset";
            // Create new graphql operation createFilesetSnapshot
            InitMutationCreateFilesetSnapshot();
        }

        // This parameter set invokes a single graphql operation:
        // deleteCloudWorkloadSnapshot.
        internal void ProcessRecord_DeleteCloudWorkload()
        {
            this._logger.name += " -DeleteCloudWorkload";
            // Create new graphql operation deleteCloudWorkloadSnapshot
            InitMutationDeleteCloudWorkloadSnapshot();
        }

        // This parameter set invokes a single graphql operation:
        // deleteFilesetSnapshots.
        internal void ProcessRecord_DeleteFilesets()
        {
            this._logger.name += " -DeleteFilesets";
            // Create new graphql operation deleteFilesetSnapshots
            InitMutationDeleteFilesetSnapshots();
        }

        // This parameter set invokes a single graphql operation:
        // filesetDownloadSnapshotFiles.
        internal void ProcessRecord_FilesetDownloadFiles()
        {
            this._logger.name += " -FilesetDownloadFiles";
            // Create new graphql operation filesetDownloadSnapshotFiles
            InitMutationFilesetDownloadSnapshotFiles();
        }

        // This parameter set invokes a single graphql operation:
        // filesetExportSnapshotFiles.
        internal void ProcessRecord_FilesetExportFiles()
        {
            this._logger.name += " -FilesetExportFiles";
            // Create new graphql operation filesetExportSnapshotFiles
            InitMutationFilesetExportSnapshotFiles();
        }

        // This parameter set invokes a single graphql operation:
        // restoreDomainControllerSnapshot.
        internal void ProcessRecord_RestoreDomainController()
        {
            this._logger.name += " -RestoreDomainController";
            // Create new graphql operation restoreDomainControllerSnapshot
            InitMutationRestoreDomainControllerSnapshot();
        }

        // This parameter set invokes a single graphql operation:
        // restoreVolumeGroupSnapshotFiles.
        internal void ProcessRecord_RestoreVolumeGroupFiles()
        {
            this._logger.name += " -RestoreVolumeGroupFiles";
            // Create new graphql operation restoreVolumeGroupSnapshotFiles
            InitMutationRestoreVolumeGroupSnapshotFiles();
        }

        // This parameter set invokes a single graphql operation:
        // startEc2InstanceSnapshotExportJob.
        internal void ProcessRecord_StartEc2InstanceExportJob()
        {
            this._logger.name += " -StartEc2InstanceExportJob";
            // Create new graphql operation startEc2InstanceSnapshotExportJob
            InitMutationStartEc2InstanceSnapshotExportJob();
        }

        // This parameter set invokes a single graphql operation:
        // startRecoverS3SnapshotJob.
        internal void ProcessRecord_StartRecoverS3Job()
        {
            this._logger.name += " -StartRecoverS3Job";
            // Create new graphql operation startRecoverS3SnapshotJob
            InitMutationStartRecoverS3SnapshotJob();
        }

        // This parameter set invokes a single graphql operation:
        // takeOnDemandSnapshot.
        internal void ProcessRecord_TakeOnDemand()
        {
            this._logger.name += " -TakeOnDemand";
            // Create new graphql operation takeOnDemandSnapshot
            InitMutationTakeOnDemandSnapshot();
        }

        // This parameter set invokes a single graphql operation:
        // uploadDatabaseSnapshotToBlobstore.
        internal void ProcessRecord_UploadDatabaseToBlobstore()
        {
            this._logger.name += " -UploadDatabaseToBlobstore";
            // Create new graphql operation uploadDatabaseSnapshotToBlobstore
            InitMutationUploadDatabaseSnapshotToBlobstore();
        }

        // This parameter set invokes a single graphql operation:
        // vmwareDownloadSnapshotFromLocation.
        internal void ProcessRecord_VmwareDownloadFromLocation()
        {
            this._logger.name += " -VmwareDownloadFromLocation";
            // Create new graphql operation vmwareDownloadSnapshotFromLocation
            InitMutationVmwareDownloadSnapshotFromLocation();
        }


        // Create new GraphQL Mutation:
        // batchQuarantineSnapshot(input: BatchQuarantineSnapshotInput!): BatchQuarantineSnapshotReply!
        internal void InitMutationBatchQuarantineSnapshot()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "BatchQuarantineSnapshotInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationBatchQuarantineSnapshot",
                "($input: BatchQuarantineSnapshotInput!)",
                "BatchQuarantineSnapshotReply",
                Mutation.BatchQuarantineSnapshot_ObjectFieldSpec,
                Mutation.BatchQuarantineSnapshotFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	quarantineSpecs = @(
		@{
			# REQUIRED
			snapshotId = $someString
			# REQUIRED
			filesDetails = @(
				@{
					# REQUIRED
					fileName = $someString
				}
			)
		}
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // batchReleaseFromQuarantineSnapshot(input: BatchReleaseFromQuarantineSnapshotInput!): BatchReleaseFromQuarantineSnapshotReply!
        internal void InitMutationBatchReleaseFromQuarantineSnapshot()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "BatchReleaseFromQuarantineSnapshotInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationBatchReleaseFromQuarantineSnapshot",
                "($input: BatchReleaseFromQuarantineSnapshotInput!)",
                "BatchReleaseFromQuarantineSnapshotReply",
                Mutation.BatchReleaseFromQuarantineSnapshot_ObjectFieldSpec,
                Mutation.BatchReleaseFromQuarantineSnapshotFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	quarantineSpecs = @(
		@{
			# REQUIRED
			snapshotId = $someString
			# REQUIRED
			filesDetails = @(
				@{
					# REQUIRED
					fileName = $someString
				}
			)
		}
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // bulkTierExistingSnapshots(input: BulkTierExistingSnapshotsInput!): AsyncRequestStatus!
        internal void InitMutationBulkTierExistingSnapshots()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "BulkTierExistingSnapshotsInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationBulkTierExistingSnapshots",
                "($input: BulkTierExistingSnapshotsInput!)",
                "AsyncRequestStatus",
                Mutation.BulkTierExistingSnapshots_ObjectFieldSpec,
                Mutation.BulkTierExistingSnapshotsFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	clusterUuid = $someString
	# REQUIRED
	objectTierInfo = @{
		# OPTIONAL
		locationId = $someString
		# REQUIRED
		objectIds = @(
			$someString
		)
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // createDomainControllerSnapshot(input: CreateDomainControllerSnapshotInput!): AsyncRequestStatus!
        internal void InitMutationCreateDomainControllerSnapshot()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateDomainControllerSnapshotInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateDomainControllerSnapshot",
                "($input: CreateDomainControllerSnapshotInput!)",
                "AsyncRequestStatus",
                Mutation.CreateDomainControllerSnapshot_ObjectFieldSpec,
                Mutation.CreateDomainControllerSnapshotFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	config = @{
		# OPTIONAL
		slaId = $someString
	}
	# REQUIRED
	id = $someString
	# OPTIONAL
	userNote = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // createDownloadSnapshotForVolumeGroup(input: CreateDownloadSnapshotForVolumeGroupInput!): AsyncRequestStatus!
        internal void InitMutationCreateDownloadSnapshotForVolumeGroup()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateDownloadSnapshotForVolumeGroupInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateDownloadSnapshotForVolumeGroup",
                "($input: CreateDownloadSnapshotForVolumeGroupInput!)",
                "AsyncRequestStatus",
                Mutation.CreateDownloadSnapshotForVolumeGroup_ObjectFieldSpec,
                Mutation.CreateDownloadSnapshotForVolumeGroupFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // createFilesetSnapshot(input: CreateFilesetSnapshotInput!): AsyncRequestStatus!
        internal void InitMutationCreateFilesetSnapshot()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateFilesetSnapshotInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateFilesetSnapshot",
                "($input: CreateFilesetSnapshotInput!)",
                "AsyncRequestStatus",
                Mutation.CreateFilesetSnapshot_ObjectFieldSpec,
                Mutation.CreateFilesetSnapshotFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	config = @{
		# OPTIONAL
		slaId = $someString
	}
	# REQUIRED
	id = $someString
	# OPTIONAL
	userNote = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // deleteCloudWorkloadSnapshot(input: DeleteCloudWorkloadSnapshotInput!): Boolean!
        internal void InitMutationDeleteCloudWorkloadSnapshot()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteCloudWorkloadSnapshotInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDeleteCloudWorkloadSnapshot",
                "($input: DeleteCloudWorkloadSnapshotInput!)",
                "System.Boolean",
                Mutation.DeleteCloudWorkloadSnapshot_ObjectFieldSpec,
                Mutation.DeleteCloudWorkloadSnapshotFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	snapshotId = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // deleteFilesetSnapshots(input: DeleteFilesetSnapshotsInput!): ResponseSuccess!
        internal void InitMutationDeleteFilesetSnapshots()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteFilesetSnapshotsInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDeleteFilesetSnapshots",
                "($input: DeleteFilesetSnapshotsInput!)",
                "ResponseSuccess",
                Mutation.DeleteFilesetSnapshots_ObjectFieldSpec,
                Mutation.DeleteFilesetSnapshotsFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	clusterUuid = $someString
	# REQUIRED
	id = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // filesetDownloadSnapshotFiles(input: FilesetDownloadSnapshotFilesInput!): AsyncRequestStatus!
        internal void InitMutationFilesetDownloadSnapshotFiles()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "FilesetDownloadSnapshotFilesInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationFilesetDownloadSnapshotFiles",
                "($input: FilesetDownloadSnapshotFilesInput!)",
                "AsyncRequestStatus",
                Mutation.FilesetDownloadSnapshotFiles_ObjectFieldSpec,
                Mutation.FilesetDownloadSnapshotFilesFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someString
	# OPTIONAL
	nextSnapshotFid = $someString
	# OPTIONAL
	userNote = $someString
	# OPTIONAL
	zipPassword = $someString
	# REQUIRED
	config = @{
		# OPTIONAL
		legalHoldDownloadConfig = @{
			# REQUIRED
			isLegalHoldDownload = $someBoolean
		}
		# OPTIONAL
		zipPassword = $someString
		# REQUIRED
		sourceDirs = @(
			$someString
		)
	}
	# OPTIONAL
	deltaTypeFilter = @(
		$someDeltaType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DeltaType]) for enum values.
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // filesetExportSnapshotFiles(input: FilesetExportSnapshotFilesInput!): AsyncRequestStatus!
        internal void InitMutationFilesetExportSnapshotFiles()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "FilesetExportSnapshotFilesInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationFilesetExportSnapshotFiles",
                "($input: FilesetExportSnapshotFilesInput!)",
                "AsyncRequestStatus",
                Mutation.FilesetExportSnapshotFiles_ObjectFieldSpec,
                Mutation.FilesetExportSnapshotFilesFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someString
	# OPTIONAL
	nextSnapshotFid = $someString
	# OPTIONAL
	deltaTypeFilter = @(
		$someDeltaType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DeltaType]) for enum values.
	)
	# REQUIRED
	config = @{
		# OPTIONAL
		hostId = $someString
		# OPTIONAL
		ignoreErrors = $someBoolean
		# OPTIONAL
		shareId = $someString
		# REQUIRED
		exportPathPairs = @(
			@{
				# OPTIONAL
				exportPathPair = @{
					# REQUIRED
					dstPath = $someString
					# REQUIRED
					srcPath = $someString
				}
			}
		)
	}
	# REQUIRED
	shareType = $someShareTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ShareTypeEnum]) for enum values.
	# REQUIRED
	osType = $someGuestOsType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.GuestOsType]) for enum values.
}"
            );
        }

        // Create new GraphQL Mutation:
        // restoreDomainControllerSnapshot(input: RestoreDomainControllerSnapshotInput!): AsyncRequestStatus!
        internal void InitMutationRestoreDomainControllerSnapshot()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "RestoreDomainControllerSnapshotInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationRestoreDomainControllerSnapshot",
                "($input: RestoreDomainControllerSnapshotInput!)",
                "AsyncRequestStatus",
                Mutation.RestoreDomainControllerSnapshot_ObjectFieldSpec,
                Mutation.RestoreDomainControllerSnapshotFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	config = @{
		# OPTIONAL
		snapshotForAuthoritativeRestore = $someString
		# REQUIRED
		domainControllerRestoreConfigs = @(
			@{
				# OPTIONAL
				hostId = $someString
				# REQUIRED
				snapshotId = $someString
			}
		)
		# REQUIRED
		shouldPerformAuthoritativeAdObjectsRestore = $someBoolean
		# REQUIRED
		shouldPerformAuthoritativeSysvolRestore = $someBoolean
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // restoreVolumeGroupSnapshotFiles(input: RestoreVolumeGroupSnapshotFilesInput!): AsyncRequestStatus!
        internal void InitMutationRestoreVolumeGroupSnapshotFiles()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "RestoreVolumeGroupSnapshotFilesInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationRestoreVolumeGroupSnapshotFiles",
                "($input: RestoreVolumeGroupSnapshotFilesInput!)",
                "AsyncRequestStatus",
                Mutation.RestoreVolumeGroupSnapshotFiles_ObjectFieldSpec,
                Mutation.RestoreVolumeGroupSnapshotFilesFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someString
	# OPTIONAL
	nextSnapshotFid = $someString
	# REQUIRED
	config = @{
		# OPTIONAL
		targetHostId = $someString
		# REQUIRED
		restoreConfigs = @(
			@{
				# REQUIRED
				path = $someString
				# REQUIRED
				restorePath = $someString
			}
		)
	}
	# OPTIONAL
	deltaTypeFilter = @(
		$someDeltaType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DeltaType]) for enum values.
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // startEc2InstanceSnapshotExportJob(input: StartEc2InstanceSnapshotExportJobInput!): AsyncJobStatus!
        internal void InitMutationStartEc2InstanceSnapshotExportJob()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "StartEc2InstanceSnapshotExportJobInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationStartEc2InstanceSnapshotExportJob",
                "($input: StartEc2InstanceSnapshotExportJobInput!)",
                "AsyncJobStatus",
                Mutation.StartEc2InstanceSnapshotExportJob_ObjectFieldSpec,
                Mutation.StartEc2InstanceSnapshotExportJobFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	snapshotId = $someString
	# REQUIRED
	destinationAwsAccountRubrikId = $someString
	# REQUIRED
	instanceType = $someAwsNativeEc2InstanceType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeEc2InstanceType]) for enum values.
	# REQUIRED
	instanceName = $someString
	# REQUIRED
	securityGroupIds = @(
		$someString
	)
	# REQUIRED
	subnetId = $someString
	# REQUIRED
	destinationRegionId = $someAwsNativeRegion # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRegion]) for enum values.
	# REQUIRED
	shouldCopyTags = $someBoolean
	# OPTIONAL
	kmsKeyId = $someString
	# OPTIONAL
	sshKeyPairName = $someString
	# OPTIONAL
	exportInstanceInPoweredOffState = $someBoolean
	# OPTIONAL
	snapshotType = $someSnapshotType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SnapshotType]) for enum values.
	# OPTIONAL
	amiId = $someString
	# OPTIONAL
	iamInstanceProfileArn = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // startRecoverS3SnapshotJob(input: StartRecoverS3SnapshotJobInput!): AsyncJobStatus!
        internal void InitMutationStartRecoverS3SnapshotJob()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "StartRecoverS3SnapshotJobInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationStartRecoverS3SnapshotJob",
                "($input: StartRecoverS3SnapshotJobInput!)",
                "AsyncJobStatus",
                Mutation.StartRecoverS3SnapshotJob_ObjectFieldSpec,
                Mutation.StartRecoverS3SnapshotJobFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	workloadId = $someString
	# OPTIONAL
	snapshotId = $someString
	# OPTIONAL
	restoreDate = $someDateTime
	# REQUIRED
	destinationBucketArn = $someString
	# REQUIRED
	shouldRecoverFullBucket = $someBoolean
	# REQUIRED
	objectKeys = @(
		$someString
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // takeOnDemandSnapshot(input: TakeOnDemandSnapshotInput!): TakeOnDemandSnapshotReply!
        internal void InitMutationTakeOnDemandSnapshot()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "TakeOnDemandSnapshotInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationTakeOnDemandSnapshot",
                "($input: TakeOnDemandSnapshotInput!)",
                "TakeOnDemandSnapshotReply",
                Mutation.TakeOnDemandSnapshot_ObjectFieldSpec,
                Mutation.TakeOnDemandSnapshotFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	workloadIds = @(
		$someString
	)
	# REQUIRED
	slaId = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // uploadDatabaseSnapshotToBlobstore(input: UploadDatabaseSnapshotToBlobstoreInput!): AsyncJobStatus!
        internal void InitMutationUploadDatabaseSnapshotToBlobstore()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UploadDatabaseSnapshotToBlobstoreInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUploadDatabaseSnapshotToBlobstore",
                "($input: UploadDatabaseSnapshotToBlobstoreInput!)",
                "AsyncJobStatus",
                Mutation.UploadDatabaseSnapshotToBlobstore_ObjectFieldSpec,
                Mutation.UploadDatabaseSnapshotToBlobstoreFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	snapshotId = $someString
	# OPTIONAL
	targetStorageAccountConfigInput = @{
		# REQUIRED
		subscriptionCloudAccountId = $someString
		# REQUIRED
		resourceGroupName = $someString
		# REQUIRED
		storageAccountName = $someString
		# OPTIONAL
		tags = @{
			# REQUIRED
			tagList = @(
				@{
					# REQUIRED
					key = $someString
					# REQUIRED
					value = $someString
				}
			)
		}
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // vmwareDownloadSnapshotFromLocation(input: VmwareDownloadSnapshotFromLocationInput!): AsyncRequestStatus!
        internal void InitMutationVmwareDownloadSnapshotFromLocation()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "VmwareDownloadSnapshotFromLocationInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationVmwareDownloadSnapshotFromLocation",
                "($input: VmwareDownloadSnapshotFromLocationInput!)",
                "AsyncRequestStatus",
                Mutation.VmwareDownloadSnapshotFromLocation_ObjectFieldSpec,
                Mutation.VmwareDownloadSnapshotFromLocationFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	downloadConfig = @{
		# OPTIONAL
		slaId = $someString
	}
	# REQUIRED
	locationId = $someString
	# REQUIRED
	snapshotId = $someString
}"
            );
        }


    } // class New_RscMutationSnapshot
}